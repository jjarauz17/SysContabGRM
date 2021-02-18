Imports System.IO
Imports DevExpress.XtraReports.UI
Imports ClasesBLL
Imports ZohoApi
Imports Entities
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmArticulos
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmArticulos = Nothing

    Public Shared Function Instance() As frmArticulos
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmArticulos()
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
    Friend WithEvents Vista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dgArticulos As DevExpress.XtraGrid.GridControl
    Friend WithEvents cbProveedores As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cbLineas As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnBarras As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbGrupos As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cbSubGrupos As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBodegas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnCBarras As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sCantidad As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btnDiseno As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cbGruposPNR As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bRestauraEsquema As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bGuardaEsquema As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents rLink As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents bKitCombos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbFabricantes As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents cbSubSubGrupos As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArticulos))
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Me.btnDiseno = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.bKitCombos = New DevExpress.XtraEditors.SimpleButton()
        Me.bRestauraEsquema = New DevExpress.XtraEditors.SimpleButton()
        Me.bGuardaEsquema = New DevExpress.XtraEditors.SimpleButton()
        Me.sCantidad = New DevExpress.XtraEditors.SpinEdit()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBodegas = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBarras = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCBarras = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.dgArticulos = New DevExpress.XtraGrid.GridControl()
        Me.Vista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbProveedores = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cbLineas = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cbGrupos = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cbSubGrupos = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cbSubSubGrupos = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cbGruposPNR = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.rLink = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.cbFabricantes = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.sCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSubGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSubSubGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbGruposPNR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbFabricantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDiseno
        '
        Me.btnDiseno.Appearance.Options.UseTextOptions = True
        Me.btnDiseno.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnDiseno.Enabled = False
        Me.btnDiseno.ImageOptions.Image = CType(resources.GetObject("btnDiseno.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDiseno.Location = New System.Drawing.Point(12, 510)
        Me.btnDiseno.Name = "btnDiseno"
        Me.btnDiseno.Size = New System.Drawing.Size(118, 38)
        Me.btnDiseno.StyleController = Me.LayoutControl1
        Me.btnDiseno.TabIndex = 13
        Me.btnDiseno.Text = "&Diseño"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.bKitCombos)
        Me.LayoutControl1.Controls.Add(Me.bRestauraEsquema)
        Me.LayoutControl1.Controls.Add(Me.bGuardaEsquema)
        Me.LayoutControl1.Controls.Add(Me.sCantidad)
        Me.LayoutControl1.Controls.Add(Me.cmdSalir)
        Me.LayoutControl1.Controls.Add(Me.btnDiseno)
        Me.LayoutControl1.Controls.Add(Me.btnBodegas)
        Me.LayoutControl1.Controls.Add(Me.btnBarras)
        Me.LayoutControl1.Controls.Add(Me.btnCBarras)
        Me.LayoutControl1.Controls.Add(Me.btnExportar)
        Me.LayoutControl1.Controls.Add(Me.cmdAyuda)
        Me.LayoutControl1.Controls.Add(Me.cmdNuevo)
        Me.LayoutControl1.Controls.Add(Me.cmdModificar)
        Me.LayoutControl1.Controls.Add(Me.cmdImprimir)
        Me.LayoutControl1.Controls.Add(Me.cmdBorrar)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(650, 138, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(141, 619)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'bKitCombos
        '
        Me.bKitCombos.Appearance.Options.UseTextOptions = True
        Me.bKitCombos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bKitCombos.Enabled = False
        Me.bKitCombos.ImageOptions.Image = CType(resources.GetObject("bKitCombos.ImageOptions.Image"), System.Drawing.Image)
        Me.bKitCombos.Location = New System.Drawing.Point(12, 222)
        Me.bKitCombos.Name = "bKitCombos"
        Me.bKitCombos.Size = New System.Drawing.Size(118, 38)
        Me.bKitCombos.StyleController = Me.LayoutControl1
        Me.bKitCombos.TabIndex = 166
        Me.bKitCombos.Text = "&Kit / Combos"
        '
        'bRestauraEsquema
        '
        Me.bRestauraEsquema.Appearance.Options.UseTextOptions = True
        Me.bRestauraEsquema.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bRestauraEsquema.Enabled = False
        Me.bRestauraEsquema.ImageOptions.Image = CType(resources.GetObject("bRestauraEsquema.ImageOptions.Image"), System.Drawing.Image)
        Me.bRestauraEsquema.Location = New System.Drawing.Point(12, 468)
        Me.bRestauraEsquema.Name = "bRestauraEsquema"
        Me.bRestauraEsquema.Size = New System.Drawing.Size(118, 38)
        Me.bRestauraEsquema.StyleController = Me.LayoutControl1
        Me.bRestauraEsquema.TabIndex = 15
        Me.bRestauraEsquema.Text = "&Restaurar Esquema"
        '
        'bGuardaEsquema
        '
        Me.bGuardaEsquema.Appearance.Options.UseTextOptions = True
        Me.bGuardaEsquema.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bGuardaEsquema.Enabled = False
        Me.bGuardaEsquema.ImageOptions.Image = CType(resources.GetObject("bGuardaEsquema.ImageOptions.Image"), System.Drawing.Image)
        Me.bGuardaEsquema.Location = New System.Drawing.Point(12, 426)
        Me.bGuardaEsquema.Name = "bGuardaEsquema"
        Me.bGuardaEsquema.Size = New System.Drawing.Size(118, 38)
        Me.bGuardaEsquema.StyleController = Me.LayoutControl1
        Me.bGuardaEsquema.TabIndex = 14
        Me.bGuardaEsquema.Text = "Guardar Es&quema"
        '
        'sCantidad
        '
        Me.sCantidad.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.sCantidad.Location = New System.Drawing.Point(12, 306)
        Me.sCantidad.Name = "sCantidad"
        Me.sCantidad.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sCantidad.Properties.Appearance.Options.UseFont = True
        Me.sCantidad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sCantidad.Size = New System.Drawing.Size(118, 22)
        Me.sCantidad.StyleController = Me.LayoutControl1
        Me.sCantidad.TabIndex = 12
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.ImageOptions.Image = CType(resources.GetObject("cmdSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(12, 552)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(118, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl1
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'btnBodegas
        '
        Me.btnBodegas.Enabled = False
        Me.btnBodegas.ImageOptions.Image = CType(resources.GetObject("btnBodegas.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBodegas.Location = New System.Drawing.Point(12, 138)
        Me.btnBodegas.Name = "btnBodegas"
        Me.btnBodegas.Size = New System.Drawing.Size(118, 38)
        Me.btnBodegas.StyleController = Me.LayoutControl1
        Me.btnBodegas.TabIndex = 10
        Me.btnBodegas.Text = "&Bodegas"
        '
        'btnBarras
        '
        Me.btnBarras.Appearance.Options.UseTextOptions = True
        Me.btnBarras.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnBarras.Enabled = False
        Me.btnBarras.ImageOptions.Image = CType(resources.GetObject("btnBarras.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBarras.Location = New System.Drawing.Point(12, 332)
        Me.btnBarras.Name = "btnBarras"
        Me.btnBarras.Size = New System.Drawing.Size(118, 38)
        Me.btnBarras.StyleController = Me.LayoutControl1
        Me.btnBarras.TabIndex = 8
        Me.btnBarras.Text = "&Imprimir Codigos"
        '
        'btnCBarras
        '
        Me.btnCBarras.Appearance.Options.UseTextOptions = True
        Me.btnCBarras.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnCBarras.Enabled = False
        Me.btnCBarras.ImageOptions.Image = CType(resources.GetObject("btnCBarras.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCBarras.Location = New System.Drawing.Point(12, 264)
        Me.btnCBarras.Name = "btnCBarras"
        Me.btnCBarras.Size = New System.Drawing.Size(118, 38)
        Me.btnCBarras.StyleController = Me.LayoutControl1
        Me.btnCBarras.TabIndex = 11
        Me.btnCBarras.Text = "Imprimir &Individual"
        '
        'btnExportar
        '
        Me.btnExportar.Enabled = False
        Me.btnExportar.ImageOptions.Image = CType(resources.GetObject("btnExportar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExportar.Location = New System.Drawing.Point(12, 384)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(118, 38)
        Me.btnExportar.StyleController = Me.LayoutControl1
        Me.btnExportar.TabIndex = 9
        Me.btnExportar.Text = "&Exportar"
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.Location = New System.Drawing.Point(10, 231)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(186, 20)
        Me.cmdAyuda.StyleController = Me.LayoutControl1
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.ImageOptions.Image = CType(resources.GetObject("cmdNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdNuevo.Location = New System.Drawing.Point(12, 12)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(118, 38)
        Me.cmdNuevo.StyleController = Me.LayoutControl1
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'cmdModificar
        '
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.ImageOptions.Image = CType(resources.GetObject("cmdModificar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdModificar.Location = New System.Drawing.Point(12, 54)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(118, 38)
        Me.cmdModificar.StyleController = Me.LayoutControl1
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "&Editar"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.ImageOptions.Image = CType(resources.GetObject("cmdImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdImprimir.Location = New System.Drawing.Point(12, 180)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(118, 38)
        Me.cmdImprimir.StyleController = Me.LayoutControl1
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.ImageOptions.Image = CType(resources.GetObject("cmdBorrar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdBorrar.Location = New System.Drawing.Point(12, 96)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(118, 38)
        Me.cmdBorrar.StyleController = Me.LayoutControl1
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "B&orrar"
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cmdAyuda
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 252)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(227, 27)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.EmptySpaceItem1, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem6})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(142, 602)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cmdNuevo
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmdModificar
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmdBorrar
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.btnBodegas
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmdImprimir
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.btnCBarras
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 252)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.btnBarras
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 320)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.btnDiseno
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 498)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cmdSalir
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 540)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.sCantidad
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 294)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(122, 26)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 362)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(122, 10)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.bGuardaEsquema
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 414)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.bRestauraEsquema
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 456)
        Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem16.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.bKitCombos
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 210)
        Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem17.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.btnExportar
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 372)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'dgArticulos
        '
        Me.dgArticulos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgArticulos.Location = New System.Drawing.Point(12, 38)
        Me.dgArticulos.MainView = Me.Vista
        Me.dgArticulos.Name = "dgArticulos"
        Me.dgArticulos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbProveedores, Me.cbLineas, Me.cbGrupos, Me.cbSubGrupos, Me.cbSubSubGrupos, Me.cbGruposPNR, Me.rLink, Me.cbFabricantes, Me.RepositoryItemHyperLinkEdit1})
        Me.dgArticulos.Size = New System.Drawing.Size(515, 596)
        Me.dgArticulos.TabIndex = 161
        Me.dgArticulos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Vista})
        '
        'Vista
        '
        Me.Vista.GridControl = Me.dgArticulos
        Me.Vista.Name = "Vista"
        Me.Vista.OptionsView.ShowAutoFilterRow = True
        Me.Vista.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Vista.OptionsView.ShowFooter = True
        Me.Vista.OptionsView.ShowGroupPanel = False
        '
        'cbProveedores
        '
        Me.cbProveedores.AutoHeight = False
        Me.cbProveedores.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProveedores.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 150, "Nombre")})
        Me.cbProveedores.Name = "cbProveedores"
        Me.cbProveedores.NullText = ""
        '
        'cbLineas
        '
        Me.cbLineas.AutoHeight = False
        Me.cbLineas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbLineas.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Código", "", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 150, "Nombre")})
        Me.cbLineas.Name = "cbLineas"
        Me.cbLineas.NullText = ""
        '
        'cbGrupos
        '
        Me.cbGrupos.AutoHeight = False
        Me.cbGrupos.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbGrupos.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Código", "", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 150, "Nombre")})
        Me.cbGrupos.Name = "cbGrupos"
        Me.cbGrupos.NullText = ""
        '
        'cbSubGrupos
        '
        Me.cbSubGrupos.AutoHeight = False
        Me.cbSubGrupos.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbSubGrupos.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Código", "", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 150, "Nombre")})
        Me.cbSubGrupos.Name = "cbSubGrupos"
        Me.cbSubGrupos.NullText = ""
        '
        'cbSubSubGrupos
        '
        Me.cbSubSubGrupos.AutoHeight = False
        Me.cbSubSubGrupos.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbSubSubGrupos.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Código", "", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 150, "Nombre")})
        Me.cbSubSubGrupos.Name = "cbSubSubGrupos"
        Me.cbSubSubGrupos.NullText = ""
        '
        'cbGruposPNR
        '
        Me.cbGruposPNR.AutoHeight = False
        ToolTipTitleItem1.Text = "Agregar Grupo"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        ToolTipTitleItem2.Text = "Editar Grupo"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        Me.cbGruposPNR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, True, True, True, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, SuperToolTip1), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo, "", -1, True, True, True, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, SuperToolTip2)})
        Me.cbGruposPNR.Name = "cbGruposPNR"
        Me.cbGruposPNR.NullText = "[Grupo PNR]"
        '
        'rLink
        '
        Me.rLink.AutoHeight = False
        Me.rLink.Caption = "Digitales"
        Me.rLink.Name = "rLink"
        '
        'cbFabricantes
        '
        Me.cbFabricantes.AutoHeight = False
        Me.cbFabricantes.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbFabricantes.Name = "cbFabricantes"
        Me.cbFabricantes.NullText = "[Fabricante]"
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(12, 12)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "Mostrar Mas Datos"
        Me.CheckEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.CheckEdit1.Size = New System.Drawing.Size(515, 22)
        Me.CheckEdit1.StyleController = Me.LayoutControl2
        Me.CheckEdit1.TabIndex = 162
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.dgArticulos)
        Me.LayoutControl2.Controls.Add(Me.CheckEdit1)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(539, 646)
        Me.LayoutControl2.TabIndex = 164
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem13, Me.LayoutControlItem14})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(539, 646)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.dgArticulos
        Me.LayoutControlItem13.CustomizationFormText = "LayoutControlItem13"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(519, 600)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.CheckEdit1
        Me.LayoutControlItem14.CustomizationFormText = "LayoutControlItem14"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(519, 26)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
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
        Me.DockPanel1.ID = New System.Guid("fe90f654-f37e-430b-a317-8d13684eb6f9")
        Me.DockPanel1.Location = New System.Drawing.Point(539, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(150, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(150, 646)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(141, 619)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'frmArticulos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(689, 646)
        Me.Controls.Add(Me.LayoutControl2)
        Me.Controls.Add(Me.DockPanel1)
        Me.KeyPreview = True
        Me.Name = "frmArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.sCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbLineas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSubGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSubSubGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbGruposPNR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbFabricantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "Variables"
    Dim Articulos As New VB.SysContab.ArticulosDB
    Dim ds As New DataSet
    Dim Proveedores As New VB.SysContab.ProveedoresDB
    Dim Grupos As New VB.SysContab.Grupos_InventarioDB
    Dim Estado As Integer
    Dim bMasDatos As Boolean = False

#End Region

    Dim DT_ROL As DataTable,
        _DT_CABYS As DataTable = New DataTable("CABYS")

    Private Sub frmArticulos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then Cargar()
    End Sub

    Private Sub frmArticulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DT_ROL = RolesDB.UsuarioAcciones(LayoutControl1)

        Dim Tabla As New DataTable
        Estado = 0

        cbProveedores.DataSource = Proveedores.ProveedoresList(3).Tables("PROVEEDORES")
        cbProveedores.ValueMember = "Codigo"
        cbProveedores.DisplayMember = "Nombre"

        cbLineas.DataSource = Grupos.Lineas("P").Tables("GruposCC")
        cbLineas.ValueMember = "Código"
        cbLineas.DisplayMember = "Nombre"

        Me.cbGrupos.DataSource = Grupos.Grupos("%", "P").Tables("GruposCC")
        Me.cbGrupos.ValueMember = "Código"
        Me.cbGrupos.DisplayMember = "Nombre"

        Me.cbSubGrupos.DataSource = Grupos.SubGrupos("%", "P").Tables("GruposCC")
        Me.cbSubGrupos.ValueMember = "Código"
        Me.cbSubGrupos.DisplayMember = "Nombre"

        Me.cbSubSubGrupos.DataSource = Grupos.S_SubGrupos("%", "P").Tables("GruposCC")
        Me.cbSubSubGrupos.ValueMember = "Código"
        Me.cbSubSubGrupos.DisplayMember = "Nombre"

        Combo(cbGruposPNR, ObtieneDatos("PRN_sel_grupos 0," & EmpresaActual))
        Combo(cbFabricantes, db_Articulos_Fabricantes.Listar(0))

        Cargar()
        ArmarGrid()

        LeerEsquemaInicial(Me.Name,
                           Me.Text,
                           Vista)
        ValidarAccesos()
        '
        'Cargar Catalogo CABYS para CR
        _DT_CABYS = ObtieneDatos("sp_sel_CR_CABYS", EmpresaActual)

        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        'Me.Text = "Mantenimiento de Productos"
        'Me.Refresh()
    End Sub

    Public Sub Cargar()
        dgArticulos.DataSource = Articulos.ArticulosConsultaLetra()
    End Sub

    Sub ValidarAccesos()
        If DT_ROL.Rows.Count > 0 Then
            Dim dr() As DataRow = DT_ROL.Select("Control = 'Costo'")

            If dr.Length > 0 Then
                'Vista.Columns("COSTO").Visible = True
                'Vista.Columns("COSTO 2").Visible = True
                'Vista.Columns("Costo Promedio").Visible = False
            Else
                'Vista.Columns("COSTO").Visible = False
                'Vista.Columns("COSTO 2").Visible = False
                'Vista.Columns("Costo Promedio").Visible = False

                Vista.Columns("COSTO").OptionsColumn.ShowInCustomizationForm = False
                Vista.Columns("COSTO 2").OptionsColumn.ShowInCustomizationForm = False
                Vista.Columns("Costo Promedio").OptionsColumn.ShowInCustomizationForm = False
            End If

            'Validar para Movil
            Dim dr2() As DataRow = DT_ROL.Select("Control = 'Movil'")

            If dr2.Length > 0 Then
                Vista.Columns("Movil").OptionsColumn.AllowEdit = True
            Else
                Vista.Columns("Movil").OptionsColumn.AllowEdit = False
            End If
            'Validar para Producto Activo
            Dim dr3() As DataRow = DT_ROL.Select("Control = 'Activo'")

            If dr3.Length > 0 Then
                Vista.Columns("Activo").OptionsColumn.AllowEdit = True
            Else
                Vista.Columns("Activo").OptionsColumn.AllowEdit = False
            End If
            'Validar para Valdidar Precio
            Dim dr4() As DataRow = DT_ROL.Select("Control = 'Validar'")

            If dr4.Length > 0 Then
                Vista.Columns("Valida Precio").OptionsColumn.AllowEdit = True
            Else
                Vista.Columns("Valida Precio").OptionsColumn.AllowEdit = False
            End If
        Else
            Vista.Columns("COSTO").Visible = False
            Vista.Columns("COSTO 2").Visible = False
            Vista.Columns("Costo Promedio").Visible = False

            Vista.Columns("COSTO").OptionsColumn.ShowInCustomizationForm = False
            Vista.Columns("Costo Promedio").OptionsColumn.ShowInCustomizationForm = False
            Vista.Columns("Movil").OptionsColumn.AllowEdit = False
            Vista.Columns("Activo").OptionsColumn.AllowEdit = False
            Vista.Columns("Valida Precio").OptionsColumn.AllowEdit = False
        End If
    End Sub

    Public Sub ArmarGrid()
        Me.Vista.PopulateColumns()
        FormatoGrid(Me.Vista)

        For i As Integer = 0 To Me.Vista.Columns.Count - 1
            Me.Vista.Columns(i).OptionsColumn.AllowEdit = False
        Next

        Dim rLink1 As New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        rLink1.Caption = "Digitales"

        Dim rLink2 As New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        rLink2.Caption = "Url"

        Dim rLink3 As New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        rLink3.Caption = "Ver"

        '
        Me.Vista.Columns("UBICACION").Visible = False
        Me.Vista.Columns("UBICACION").OptionsColumn.AllowEdit = True
        Me.Vista.Columns("Grupo PNR").OptionsColumn.AllowEdit = True

        'Me.Vista.Columns("#").OptionsColumn.AllowEdit = True
        Me.Vista.Columns("#").ColumnEdit = rLink1
        Me.Vista.Columns("#").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        Vista.Columns("#1").Caption = "#"
        'Me.Vista.Columns("#1").OptionsColumn.AllowEdit = True
        Me.Vista.Columns("#1").ColumnEdit = rLink2
        Me.Vista.Columns("#1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        Vista.Columns("#2").Caption = "#"
        'Me.Vista.Columns("#2").OptionsColumn.AllowEdit = True
        Me.Vista.Columns("#2").ColumnEdit = rLink3
        Me.Vista.Columns("#2").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        Me.Vista.Columns("Cuenta").Visible = False
        Me.Vista.Columns("Cuenta Nombre").Visible = False
        ' Me.Vista.Columns("Grupo").Visible = False
        Me.Vista.Columns("Sub Grupo").Visible = False
        Me.Vista.Columns("Sub Sub Grupo").Visible = False
        Me.Vista.Columns("PRESENTACION").Visible = False
        Me.Vista.Columns("Costo Promedio").Visible = False
        Me.Vista.Columns("CUENTA_COSTO").Visible = False
        Me.Vista.Columns("CUENTA_INGRESO").Visible = False
        Me.Vista.Columns("CUENTA_DEVOLUCION").Visible = False
        Me.Vista.Columns("CUENTA_REBAJA").Visible = False
        Me.Vista.Columns("Centro Costo").Visible = False
        Vista.Columns("COSTO").Visible = False
        Vista.Columns("COSTO 2").Visible = False
        Vista.Columns("Costo Promedio").Visible = False
        Me.Vista.Columns("UNIDAD").Visible = False
        Me.Vista.Columns("MODELO").Visible = False
        Me.Vista.Columns("PRESENTACION").Visible = False
        Me.Vista.Columns("PRECIO").Visible = False
        Me.Vista.Columns("PRECIO 2").Visible = False
        Me.Vista.Columns("MARGEN").Visible = False
        Me.Vista.Columns("FACTOR").Visible = False
        Me.Vista.Columns("SAC").Visible = False
        Me.Vista.Columns("Alta").Visible = False
        Me.Vista.Columns("SAC").Visible = False
        Me.Vista.Columns("Movil").Visible = False
        Me.Vista.Columns("Temporal").Visible = False
        Me.Vista.Columns("Valida Precio").Visible = False
        Me.Vista.Columns("Obsoleto").Visible = False
        Me.Vista.Columns("Usuario").Visible = False

        Me.Vista.Columns("URL").Visible = False
        Me.Vista.Columns("URL").OptionsColumn.ShowInCustomizationForm = False
        Me.Vista.Columns("Tipo").Visible = False
        Me.Vista.Columns("Tipo").OptionsColumn.ShowInCustomizationForm = False

        Me.Vista.Columns("Proveedor").ColumnEdit = cbProveedores
        Me.Vista.Columns("Linea").ColumnEdit = cbLineas
        Me.Vista.Columns("Grupo").ColumnEdit = cbGrupos
        Me.Vista.Columns("Sub Grupo").ColumnEdit = cbSubGrupos
        Me.Vista.Columns("Sub Sub Grupo").ColumnEdit = cbSubSubGrupos
        Me.Vista.Columns("Grupo PNR").ColumnEdit = cbGruposPNR
        Me.Vista.Columns("Fabricante").ColumnEdit = cbFabricantes

        Me.Vista.Columns("PRECIO").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Vista.Columns("PRECIO").DisplayFormat.FormatString = "{0:" & RoundP & "}"
        Me.Vista.Columns("PRECIO").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Vista.Columns("PRECIO").SummaryItem.DisplayFormat = "{0:" & RoundP & "}"

        Me.Vista.Columns("PRECIO 2").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Vista.Columns("PRECIO 2").DisplayFormat.FormatString = "{0:" & RoundP & "}"
        Me.Vista.Columns("PRECIO 2").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Vista.Columns("PRECIO 2").SummaryItem.DisplayFormat = "{0:" & RoundP & "}"

        Me.Vista.Columns("COSTO").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Vista.Columns("COSTO").DisplayFormat.FormatString = "{0:" & Round & "}"
        Me.Vista.Columns("COSTO").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Vista.Columns("COSTO").SummaryItem.DisplayFormat = "{0:" & Round & "}"

        Me.Vista.Columns("Costo Promedio").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Vista.Columns("Costo Promedio").DisplayFormat.FormatString = "{0:" & Round & "}"
        Me.Vista.Columns("Costo Promedio").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Vista.Columns("Costo Promedio").SummaryItem.DisplayFormat = "{0:" & Round & "}"

        'Me.Vista.Columns("Existencias").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.Vista.Columns("Existencias").DisplayFormat.FormatString = "{0:" & Round & "}"
        'Me.Vista.Columns("Existencias").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.Vista.Columns("Existencias").SummaryItem.DisplayFormat = "{0:" & Round & "}"

        Me.Vista.Columns("FACTOR").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Vista.Columns("FACTOR").DisplayFormat.FormatString = "{0:n4}"
        Me.Vista.Columns("FACTOR").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Vista.Columns("FACTOR").SummaryItem.DisplayFormat = "{0:n4}"

        'Vista.Columns("Nombre").Width = 200
        'Vista.Columns("Proveedor").Width = 200
        'Vista.Columns("Grupo PNR").Width = 180

        If Me.Vista.DataRowCount = 0 Then
            Registro = "Vacio"
        Else
            Registro = Me.Vista.GetRowCellValue(0, "Codigo")
        End If
    End Sub


    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub


    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Inicio = True
        '
        frmProductosAdd.Dispose()
        '
        Nuevo = "SI"
        '
        With frmProductosAdd
            .MdiParent = Me.MdiParent
            .Text = "Nuevo Producto"
            .DT_CABYS = _DT_CABYS
            .Show()
            .WindowState = FormWindowState.Maximized
            '.cbProveedores.EditValue = Nothing
            '.cbLinea.SelectedValue = -1
            '.cbGrupo.SelectedValue = -1
            '.cbSubGrupo.SelectedValue = -1
        End With


        'Dim f As frmAgregarArticulo = frmAgregarArticulo.Instance

        'Nuevo = "SI"

        'f.MdiParent = Me.MdiParent
        'f.Show()

        'f.cbProveedores.EditValue = Nothing
        'f.cbLinea.SelectedValue = -1
        'f.cbGrupo.SelectedValue = -1
        'f.cbSubGrupo.SelectedValue = -1
        '
        Inicio = False
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If Me.Vista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
            Registro = "Vacio"
            Exit Sub
        Else
            Registro = Me.Vista.GetFocusedRowCellValue("Codigo")
        End If
        '
        frmProductosAdd.Dispose()
        '
        Inicio = True
        '
        Nuevo = "NO"
        '
        With frmProductosAdd
            .MdiParent = Me.MdiParent
            .Text = "Editar Producto"
            .DT_CABYS = _DT_CABYS
            .Show()
            .WindowState = FormWindowState.Maximized
        End With

        'Dim f As frmAgregarArticulo = frmAgregarArticulo.Instance()
        'Nuevo = "NO"
        'f.etInicio.Text = "1"
        'f.MdiParent = Me.MdiParent
        'f.Show()
        'f.etInicio.Text = "0"
        '
        Inicio = False
    End Sub
    Private Sub Vista_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles Vista.FocusedRowChanged
        Registro = Me.Vista.GetFocusedRowCellValue("Codigo")
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        If Me.Vista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
            Registro = "Vacio"
            Exit Sub
        Else
            Registro = Me.Vista.GetFocusedRowCellValue("Codigo")
        End If

        'If ObtieneDatos("SELECT * FROM Transaccion_Bodega_Detalle tbd WHERE tbd.codigo_articulo = '" & Registro & "' AND tbd.Articulo_tipo= 'P' AND tbd.empresa = " & EmpresaActual).Rows.Count > 0 Then
        '    XtraMsg("El Producto: " & Registro & " - " & Me.Vista.GetFocusedRowCellValue("Nombre") & " Contiene Movimientos de Inventario.", MessageBoxIcon.Error)
        '    Exit Sub
        'End If

        If Not XtraMsg2("Esta seguro que dese borrar el Producto: " & Registro & " - " & Me.Vista.GetFocusedRowCellValue("Nombre")) Then
            Exit Sub
        End If


        Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
        Conn.IniciarTransaccion()

        Try
            ShowSplash("Borrando producto...")
            Dim msg As String = ""

            Conn.AddParameter("Item", SqlDbType.NVarChar, 100, ParameterDirection.Input, Registro)
            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Conn.AddParameter("msg", SqlDbType.NVarChar, 256, ParameterDirection.Output, msg)

            Conn.EjecutarComando("sp_BorrarProducto")
            msg = Conn.GetParameter("msg").Valor

            Conn.CompletarTransaccion()

            HideSplash()

            If msg = "OK" Then
                Cargar()
            Else
                XtraMsg("El Producto " & Registro & " - " & Vista.GetFocusedRowCellValue("Nombre") & " no se puede Borrar porque " & vbCrLf &
                        msg.Replace("/", vbCrLf), MessageBoxIcon.Error)
            End If

            'GuardaDatos("sp_BorrarProducto '" & Registro & "'," & EmpresaActual)
            'VB.SysContab.ArticulosDB.Delete(Registro, "P", "P")

        Catch ex As Exception
            Conn.AnularTransaccion()
            HideSplash()
            XtraMsg("ERROR: " + ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmArticulos_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Opened = "NO"
        ''
    End Sub

    Private Sub frmArticulos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        '
    End Sub


    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim f As frmReportesProductos = frmReportesProductos.Instance
        f.MdiParent = Me.MdiParent
        f.Show()
        f.cbProveedores.SelectedIndex = 0
        f.cbLineas.SelectedIndex = 0
        f.cbGrupos.SelectedIndex = 0
        f.cbSubGrupos.SelectedIndex = 0

    End Sub


    'Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
    '    ds = Articulos.ArticulosConsulta(txtCodigo.Text, cbDescripcion.Text, cbLineas.Text, cbProveedores.Text)
    '    dgArticulos.DataSource = ds.Tables("Articulos").DefaultView

    '    If ds.Tables("Articulos").Rows.Count = 0 Then
    '        MsgBox("No se encontraron datos...", MsgBoxStyle.Information)
    '        cmdBuscar.Focus()
    '        Exit Sub
    '    End If
    'End Sub


    Private Sub cmdAyuda_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "Ayuda/RegISProductos.chm")
    End Sub


    Private Sub dgArticulos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgArticulos.DoubleClick
        Try
            Dim f As frmDetalleArticulo = frmDetalleArticulo.Instance
            Registro = Me.Vista.GetFocusedRowCellValue("Codigo")
            f.MdiParent = Me.MdiParent
            f.Show()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Empleados_HideCustomizationForm(ByVal sender As Object, ByVal e As System.EventArgs) Handles Vista.HideCustomizationForm
        Me.CheckEdit1.Checked = False
        'Me.bMasDatos = False
    End Sub

    Private Sub dgArticulos_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgArticulos.KeyUp
        If e.KeyCode = Keys.F5 Then
            Me.Cargar()
        End If
    End Sub

    Private Sub Vista_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles Vista.CellValueChanged
        Try
            If e.Column.FieldName = "UBICACION" Then
                GuardaDatos("UPDATE ARTICULOS SET UBICACION = '" & e.Value & "' WHERE Codigo_Articulo = '" & Me.Vista.GetRowCellValue(e.RowHandle, "Codigo") & "' AND TIPO = 'P' AND EMPRESA = " & EmpresaActual)
            End If
            '
            If e.Column.FieldName = "Grupo PNR" Then
                GuardaDatos("UPDATE ARTICULOS SET IdGrupo = '" & e.Value & "' WHERE Codigo_Articulo = '" & Me.Vista.GetRowCellValue(e.RowHandle, "Codigo") & "' AND TIPO = 'P' AND EMPRESA = " & EmpresaActual)
            End If

            If e.Column.FieldName = "Movil" Then
                GuardaDatos("UPDATE ARTICULOS SET Movil = " & IIf(e.Value, 1, 0) & " WHERE Codigo_Articulo = '" & Vista.GetRowCellValue(e.RowHandle, "Codigo") & "' AND TIPO = 'P' AND EMPRESA = " & EmpresaActual)
            End If

            If e.Column.FieldName = "Activo" Then
                GuardaDatos("UPDATE ARTICULOS SET Activo = " & IIf(e.Value, 1, 0) & " WHERE Codigo_Articulo = '" & Vista.GetRowCellValue(e.RowHandle, "Codigo") & "' AND TIPO = 'P' AND EMPRESA = " & EmpresaActual)
            End If

            If e.Column.FieldName = "Valida Precio" Then
                GuardaDatos("UPDATE ARTICULOS SET Validar_Precio = " & IIf(e.Value, 1, 0) & " WHERE Codigo_Articulo = '" & Vista.GetRowCellValue(e.RowHandle, "Codigo") & "' AND TIPO = 'P' AND EMPRESA = " & EmpresaActual)
            End If

            'If e.Column.FieldName = "Exento" Then
            '    GuardaDatos("UPDATE ARTICULOS SET Exento = '" & IIf(e.Value, 1, 0) & "' WHERE Codigo_Articulo = '" & Me.Vista.GetRowCellValue(e.RowHandle, "Codigo") & "' AND TIPO = 'P' AND EMPRESA = " & EmpresaActual)
            'End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        My.Forms.frmExportarImprimir.Mostrar(Me.dgArticulos)
    End Sub

    Private Sub btnBodegas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBodegas.Click
        If Me.Vista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
            Registro = "Vacio"
            Exit Sub
        Else
            Registro = Me.Vista.GetFocusedRowCellValue("Codigo")
        End If
        '
        Dim f As frmGridArticulosxBodega = frmGridArticulosxBodega.Instance()
        f.cArticulo = Registro
        f.Text = "PRODUCTO: " + Registro
        f.TipoProducto = "P"
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked Then
            Me.Vista.ColumnsCustomization()
        Else
            Me.Vista.DestroyCustomization()
        End If
        'If Me.bMasDatos = False Then
        '    Me.Vista.ColumnsCustomization()
        '    Me.bMasDatos = True
        'Else
        '    Me.Vista.DestroyCustomization()
        '    Me.bMasDatos = False
        'End If
    End Sub

    Private Sub btnCBarras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCBarras.Click

        If Vista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Regristro")
            Exit Sub
        End If
        '
        Dim Cadena As String
        Dim Temp As Boolean = False
        Dim Data() As Byte

        Try
            Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 16 AND Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())

            Temp = True
            Dim Tamano As Integer
            Tamano = Data.GetUpperBound(0)

            Cadena = Application.StartupPath & "\RptCBarras.repx"

            If File.Exists(Cadena) Then Kill(Cadena)
            Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
            Archivo.Write(Data, 0, Tamano)
            Archivo.Close()

        Catch ex As Exception
            Temp = False
        End Try

        Dim Rep As rtpCodigoBarra

        If Temp = True Then
            Rep = XtraReport.FromFile(Application.StartupPath & "\RptCBarras.repx", True)
        Else
            Rep = New rtpCodigoBarra
        End If

        Dim ds As New DataSet
        Dim da As New System.Data.SqlClient.SqlDataAdapter("JAR_GetProductosCBarras 'P'," & EmpresaActual & ",'" & Me.Vista.GetFocusedRowCellValue("Codigo") & "'", SysContab.VB.SysContab.Rutinas.AbrirConexion())

        For i As Integer = 0 To sCantidad.Value - 1
            da.Fill(ds)
        Next

        Rep.DataSource = ds.Tables(0)

        Rep.ShowPrintMarginsWarning = False
        Rep.BringToFront()
        Rep.ShowRibbonPreview()

        'Dim rpt As New rtpCodigoBarra

        'Dim ds As New DataSet
        'Dim da As New System.Data.SqlClient.SqlDataAdapter("JAR_GetProductosCBarras 'P'," & EmpresaActual & ",'" & Me.Vista.GetFocusedRowCellValue("Codigo") & "'", SysContab.VB.SysContab.Rutinas.AbrirConexion())

        'For i As Integer = 0 To sCantidad.Value - 1
        '    da.Fill(ds)
        'Next

        'rpt.DataSource = ds.Tables(0)  'ObtieneDatos("JAR_GetProductosCBarras 'P'," & EmpresaActual & ",'" & Me.Vista.GetFocusedRowCellValue("Codigo") & "'")
        'rpt.ShowRibbonPreview()
    End Sub

    Private Sub btnBarras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBarras.Click

        Dim Cadena As String
        Dim Temp As Boolean = False
        Dim Data() As Byte

        Try
            Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 16 AND Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())

            Temp = True
            Dim Tamano As Integer
            Tamano = Data.GetUpperBound(0)

            Cadena = Application.StartupPath & "\RptCBarras.repx"

            If File.Exists(Cadena) Then Kill(Cadena)
            Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
            Archivo.Write(Data, 0, Tamano)
            Archivo.Close()
        Catch ex As Exception
            Temp = False
        End Try

        Dim Rep As rtpCodigoBarra

        If Temp = True Then
            Rep = XtraReport.FromFile(Application.StartupPath & "\RptCBarras.repx", True)
        Else
            Rep = New rtpCodigoBarra
        End If
        '
        Rep.DataSource = ObtieneDatos("JAR_GetProductosCBarras",
                                      "P",
                                      EmpresaActual)

        Rep.ShowPrintMarginsWarning = False
        Rep.BringToFront()
        Rep.ShowRibbonPreview()

        'Dim rpt As New rtpCodigoBarra
        'rpt.DataSource = ObtieneDatos("JAR_GetProductosCBarras 'P'," & EmpresaActual)
        'rpt.ShowRibbonPreview()
    End Sub

    Private Sub btnDiseno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiseno.Click

        'Dim prod As New Novazys.Products
        'Dim Url As New ZohoUrl

        'Url = Url.Load(EmpresaActual)

        'prod.EnviarToZoho(
        '    "23440027",
        '    "F3220NG FTR, NON LUBE MODULE 1900 SCFM # ",
        '    "EQUIPOS",
        '    "23440027",
        '    10584.61,
        '    1,
        '    "NI",
        '    Url.UrlEnviar)

        'Exit Sub

        FrmConfiguraCheque.Dispose()
        '
        Dim f As New FrmConfiguraCheque
        f.Tipo = 16
        f.Text = "Diseño Codigos de Barras"
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cbGruposPNR_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cbGruposPNR.ButtonClick
        If e.Button.Index = 1 Then  ''Agregar
            With frmAgregarGrupoPNR
                .IdGrupo = 0
                .ShowDialog()
                If .Ok = "SI" Then Combo(cbGruposPNR, ObtieneDatos("PRN_sel_grupos 0," & EmpresaActual))
                .Dispose()
            End With
        ElseIf e.Button.Index = 2 Then  ''Actualizar
            With frmAgregarGrupoPNR
                .IdGrupo = Vista.GetFocusedRowCellValue("Grupo PNR")
                .ShowDialog()
                If .Ok = "SI" Then Combo(cbGruposPNR, ObtieneDatos("PRN_sel_grupos 0," & EmpresaActual))
                .Dispose()
            End With
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles bGuardaEsquema.Click

        Try
            ''Borrar Archivo, para evitar cache
            If IO.File.Exists(Application.StartupPath & "\xml\xml_" & Me.Name.ToString & ".xml") Then
                Kill(Application.StartupPath & "\xml\xml_" & Me.Name.ToString & ".xml")
            End If

            ''Verificar Configuracion Inicial
            If db_Esquemas.GetEsquema(Me.Name, 1).Rows.Count = 0 Then
                ''Guardar Configuracion Inicial
                Vista.SaveLayoutToXml(Application.StartupPath & "\xml\xml_" & Me.Name.ToString & ".xml")
                db_Esquemas.Guardar(Me.Name, Me.Text, Application.StartupPath & "\xml\xml_" & Me.Name.ToString & ".xml", 1)
            Else
                Vista.SaveLayoutToXml(Application.StartupPath & "\xml\xml_" & Me.Name.ToString & ".xml")
                db_Esquemas.Guardar(Me.Name, Me.Text, Application.StartupPath & "\xml\xml_" & Me.Name.ToString & ".xml", 0)
            End If

            XtraMsg("Esquema Guardado!")
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    'Sub LeerEsquemaInicial()
    '    ''Borrar Archivo, para evitar cache
    '    If IO.File.Exists(Application.StartupPath & "\xml\xml_" & Me.Name.ToString & ".xml") Then
    '        Kill(Application.StartupPath & "\xml\xml_" & Me.Name.ToString & ".xml")
    '    End If
    '    '
    '    ''Guardar Configuracion Inicial
    '    Vista.SaveLayoutToXml(Application.StartupPath & "\xml\xml_" & Me.Name.ToString & ".xml")
    '    db_Esquemas.GuardarInicial(
    '        Me.Name,
    '        Me.Text,
    '        Application.StartupPath & "\xml\xml_" & Me.Name.ToString & ".xml")
    '    '
    '    ValidarGridSchema(Vista, Me.Name)
    'End Sub

    Private Sub bRestauraEsquema_Click(sender As Object, e As EventArgs) Handles bRestauraEsquema.Click
        db_Esquemas.Borrar(Me.Name, 0)
        ValidarGridSchema(Vista, Me.Name)
        ValidarAccesos()
    End Sub

    Private Sub rLink_Click(sender As Object, e As EventArgs) Handles rLink.Click
        If Me.Vista.FocusedRowHandle < 0 Then Exit Sub
        '
        With frmDocumentos
            .Tipo = "PRODUCTO"
            .Codigo = Vista.GetFocusedRowCellValue("Codigo")
            .NDocumento = Vista.GetFocusedRowCellValue("Nombre")
            .Text = "Soporte Digital del Producto: " & Vista.GetFocusedRowCellValue("Nombre")
            .txtNombre.Text = Vista.GetFocusedRowCellValue("Nombre")
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub bKitCombos_Click(sender As Object, e As EventArgs) Handles bKitCombos.Click
        frmCombosList.Dispose()
        frmCombosList.Show()
    End Sub

    Private Sub Vista_Click(sender As Object, e As EventArgs) Handles Vista.Click
        If Me.Vista.FocusedRowHandle < 0 Then Exit Sub
        '

        If Vista.FocusedColumn.FieldName = "#" Then
            With frmDocumentos
                .Tipo = "PRODUCTO"
                .Codigo = Vista.GetFocusedRowCellValue("Codigo")
                .NDocumento = Vista.GetFocusedRowCellValue("Nombre")
                .Text = "Soporte Digital del Producto: " & Vista.GetFocusedRowCellValue("Nombre")
                .txtNombre.Text = Vista.GetFocusedRowCellValue("Nombre")
                .ShowDialog()
                .Dispose()
            End With
        End If
        '
        If Vista.FocusedColumn.FieldName = "#1" Then
            If Vista.GetRowCellValue(Vista.FocusedRowHandle, "URL").ToString().Length > 0 Then
                Try
                    Process.Start(Vista.GetRowCellValue(Vista.FocusedRowHandle, "URL"))
                Catch ex As Exception
                    XtraMsg("URL inválida: " + ex.Message, MessageBoxIcon.Error)
                End Try
            End If

        End If

        If Vista.FocusedColumn.FieldName = "#2" Then
            With frmProductoDetalle
                .Text = "Producto: " + Vista.GetFocusedRowCellValue("Codigo") + "  " + Vista.GetFocusedRowCellValue("Nombre")
                .Codigo = Vista.GetFocusedRowCellValue("Codigo")
                .Tipo = "P"
                .ShowDialog()
                .Dispose()
            End With
        End If


    End Sub

    Private Sub Vista_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles Vista.RowCellStyle
        If e.Column.FieldName = "CABYS" Then
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            e.Appearance.ForeColor = Color.MidnightBlue
            e.Appearance.Font = New Font("Tahoma", 8, FontStyle.Underline)

        End If
    End Sub
    '
    Private Sub Vista_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles Vista.RowCellClick
        If e.Column.FieldName = "CABYS" Then

            If Vista.GetRowCellValue(e.RowHandle, "CABYS").ToString.Length > 0 Then

                With frmCatalogoCABYS
                    .Main(_DT_CABYS)

                    If .ok Then
                        Vista.SetRowCellValue(e.RowHandle, "CABYS", .Codigo)
                        Vista.SetRowCellValue(e.RowHandle, "Impuesto", $"{ .Impuesto.ToString}%")
                        Vista.SetRowCellValue(e.RowHandle, "Exento", IIf(.Impuesto = 0, True, False))

                        VB.SysContab.ArticulosDB.UpdateCabys(
                            Vista.GetRowCellValue(Vista.FocusedRowHandle, "Codigo"),
                            "P",
                            .Codigo,
                            .Impuesto)
                    End If
                End With

            End If

        End If

    End Sub
End Class
