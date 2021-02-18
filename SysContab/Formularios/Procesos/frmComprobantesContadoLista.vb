Imports System.Data
Imports System.Data.SqlClient
Imports Entities
Imports SysContab.VB.SysContab

Public Class frmComprobantesContadoLista
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmComprobantesContadoLista = Nothing
    Public Shared Function Instance() As frmComprobantesContadoLista
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmComprobantesContadoLista()
        End If
        ChildInstance.BringToFront()
        Return ChildInstance
    End Function
    Friend WithEvents gridDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Hasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Desde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbCajas As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtComentario As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnDescarga As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents frmComprobantesContadoListaConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
    Friend WithEvents lblTipo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbTipo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtComentario2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cbCentros As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem

    Dim FactVentas As New VB.SysContab.Facturas_VentasDB()

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
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQuit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnContabilizar As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComprobantesContadoLista))
        Me.btnContabilizar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnDescarga = New DevExpress.XtraEditors.SimpleButton()
        Me.btnQuit = New DevExpress.XtraEditors.SimpleButton()
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.frmComprobantesContadoListaConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.txtComentario2 = New DevExpress.XtraEditors.MemoEdit()
        Me.cbTipo = New DevExpress.XtraEditors.LookUpEdit()
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.lblTipo = New DevExpress.XtraEditors.LabelControl()
        Me.Fecha = New DevExpress.XtraEditors.DateEdit()
        Me.txtComentario = New DevExpress.XtraEditors.MemoEdit()
        Me.cbCajas = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.Hasta = New DevExpress.XtraEditors.DateEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.Desde = New DevExpress.XtraEditors.DateEdit()
        Me.gridDatos = New DevExpress.XtraGrid.GridControl()
        Me.vDatos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbCentros = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmComprobantesContadoListaConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmComprobantesContadoListaConvertedLayout.SuspendLayout()
        CType(Me.txtComentario2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComentario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCajas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Desde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Desde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCentros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnContabilizar
        '
        Me.btnContabilizar.Appearance.Options.UseTextOptions = True
        Me.btnContabilizar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnContabilizar.ImageOptions.Image = CType(resources.GetObject("btnContabilizar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnContabilizar.Location = New System.Drawing.Point(12, 12)
        Me.btnContabilizar.Name = "btnContabilizar"
        Me.btnContabilizar.Size = New System.Drawing.Size(118, 38)
        Me.btnContabilizar.StyleController = Me.LayoutControl1
        Me.btnContabilizar.TabIndex = 0
        Me.btnContabilizar.Text = "&Procesar"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.btnContabilizar)
        Me.LayoutControl1.Controls.Add(Me.btnDescarga)
        Me.LayoutControl1.Controls.Add(Me.btnQuit)
        Me.LayoutControl1.Controls.Add(Me.Button1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(958, 174, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup2
        Me.LayoutControl1.Size = New System.Drawing.Size(141, 382)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'btnDescarga
        '
        Me.btnDescarga.Appearance.Options.UseTextOptions = True
        Me.btnDescarga.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnDescarga.ImageOptions.Image = CType(resources.GetObject("btnDescarga.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDescarga.Location = New System.Drawing.Point(12, 54)
        Me.btnDescarga.Name = "btnDescarga"
        Me.btnDescarga.Size = New System.Drawing.Size(118, 38)
        Me.btnDescarga.StyleController = Me.LayoutControl1
        Me.btnDescarga.TabIndex = 3
        Me.btnDescarga.Text = "&Ver Detalle"
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.Appearance.Options.UseTextOptions = True
        Me.btnQuit.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnQuit.ImageOptions.Image = CType(resources.GetObject("btnQuit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnQuit.Location = New System.Drawing.Point(12, 315)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(118, 38)
        Me.btnQuit.StyleController = Me.LayoutControl1
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "Salir"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Appearance.Options.UseTextOptions = True
        Me.Button1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.Button1.ImageOptions.Image = CType(resources.GetObject("Button1.ImageOptions.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(12, 273)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 38)
        Me.Button1.StyleController = Me.LayoutControl1
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "E&xportar"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Root"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem15, Me.EmptySpaceItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(142, 365)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.btnContabilizar
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.btnDescarga
        Me.LayoutControlItem13.CustomizationFormText = "LayoutControlItem13"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.Button1
        Me.LayoutControlItem14.CustomizationFormText = "LayoutControlItem14"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 261)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.btnQuit
        Me.LayoutControlItem15.CustomizationFormText = "LayoutControlItem15"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 303)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 84)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(122, 177)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmComprobantesContadoListaConvertedLayout
        '
        Me.frmComprobantesContadoListaConvertedLayout.Controls.Add(Me.txtComentario2)
        Me.frmComprobantesContadoListaConvertedLayout.Controls.Add(Me.cbTipo)
        Me.frmComprobantesContadoListaConvertedLayout.Controls.Add(Me.ProgressBarControl1)
        Me.frmComprobantesContadoListaConvertedLayout.Controls.Add(Me.lblTipo)
        Me.frmComprobantesContadoListaConvertedLayout.Controls.Add(Me.Fecha)
        Me.frmComprobantesContadoListaConvertedLayout.Controls.Add(Me.txtComentario)
        Me.frmComprobantesContadoListaConvertedLayout.Controls.Add(Me.cbCajas)
        Me.frmComprobantesContadoListaConvertedLayout.Controls.Add(Me.btnBuscar)
        Me.frmComprobantesContadoListaConvertedLayout.Controls.Add(Me.Hasta)
        Me.frmComprobantesContadoListaConvertedLayout.Controls.Add(Me.CheckEdit1)
        Me.frmComprobantesContadoListaConvertedLayout.Controls.Add(Me.Desde)
        Me.frmComprobantesContadoListaConvertedLayout.Controls.Add(Me.gridDatos)
        Me.frmComprobantesContadoListaConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmComprobantesContadoListaConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.frmComprobantesContadoListaConvertedLayout.Name = "frmComprobantesContadoListaConvertedLayout"
        Me.frmComprobantesContadoListaConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1037, 246, 250, 350)
        Me.frmComprobantesContadoListaConvertedLayout.Root = Me.LayoutControlGroup1
        Me.frmComprobantesContadoListaConvertedLayout.Size = New System.Drawing.Size(758, 409)
        Me.frmComprobantesContadoListaConvertedLayout.TabIndex = 195
        '
        'txtComentario2
        '
        Me.txtComentario2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComentario2.Location = New System.Drawing.Point(115, 138)
        Me.txtComentario2.Name = "txtComentario2"
        Me.txtComentario2.Size = New System.Drawing.Size(514, 44)
        Me.txtComentario2.StyleController = Me.frmComprobantesContadoListaConvertedLayout
        Me.txtComentario2.TabIndex = 196
        '
        'cbTipo
        '
        Me.cbTipo.Location = New System.Drawing.Point(589, 64)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipo.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.cbTipo.Properties.Appearance.Options.UseFont = True
        Me.cbTipo.Properties.Appearance.Options.UseForeColor = True
        Me.cbTipo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipo.Properties.NullText = ""
        Me.cbTipo.Properties.ShowFooter = False
        Me.cbTipo.Properties.ShowHeader = False
        Me.cbTipo.Size = New System.Drawing.Size(157, 20)
        Me.cbTipo.StyleController = Me.frmComprobantesContadoListaConvertedLayout
        Me.cbTipo.TabIndex = 1017
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Location = New System.Drawing.Point(12, 379)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Properties.ShowTitle = True
        Me.ProgressBarControl1.Properties.Step = 1
        Me.ProgressBarControl1.Size = New System.Drawing.Size(734, 18)
        Me.ProgressBarControl1.StyleController = Me.frmComprobantesContadoListaConvertedLayout
        Me.ProgressBarControl1.TabIndex = 196
        '
        'lblTipo
        '
        Me.lblTipo.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.lblTipo.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTipo.Appearance.BorderColor = System.Drawing.Color.Red
        Me.lblTipo.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTipo.Appearance.Options.UseBackColor = True
        Me.lblTipo.Appearance.Options.UseBorderColor = True
        Me.lblTipo.Appearance.Options.UseFont = True
        Me.lblTipo.Appearance.Options.UseForeColor = True
        Me.lblTipo.Appearance.Options.UseTextOptions = True
        Me.lblTipo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblTipo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblTipo.Location = New System.Drawing.Point(344, 22)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(402, 19)
        Me.lblTipo.StyleController = Me.frmComprobantesContadoListaConvertedLayout
        Me.lblTipo.TabIndex = 194
        '
        'Fecha
        '
        Me.Fecha.EditValue = New Date(2009, 6, 26, 23, 46, 58, 0)
        Me.Fecha.Location = New System.Drawing.Point(115, 64)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.Fecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Properties.Appearance.Options.UseFont = True
        Me.Fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Fecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.Fecha.Size = New System.Drawing.Size(122, 20)
        Me.Fecha.StyleController = Me.frmComprobantesContadoListaConvertedLayout
        Me.Fecha.TabIndex = 193
        '
        'txtComentario
        '
        Me.txtComentario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComentario.Location = New System.Drawing.Point(115, 90)
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(631, 44)
        Me.txtComentario.StyleController = Me.frmComprobantesContadoListaConvertedLayout
        Me.txtComentario.TabIndex = 3
        '
        'cbCajas
        '
        Me.cbCajas.Location = New System.Drawing.Point(344, 64)
        Me.cbCajas.Name = "cbCajas"
        Me.cbCajas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCajas.Properties.Appearance.Options.UseFont = True
        Me.cbCajas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCajas.Properties.PopupFormMinSize = New System.Drawing.Size(400, 0)
        Me.cbCajas.Properties.ShowFooter = False
        Me.cbCajas.Size = New System.Drawing.Size(138, 22)
        Me.cbCajas.StyleController = Me.frmComprobantesContadoListaConvertedLayout
        Me.cbCajas.TabIndex = 2
        '
        'btnBuscar
        '
        Me.btnBuscar.ImageOptions.Image = CType(resources.GetObject("btnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(241, 22)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(99, 38)
        Me.btnBuscar.StyleController = Me.frmComprobantesContadoListaConvertedLayout
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "&Buscar"
        '
        'Hasta
        '
        Me.Hasta.EditValue = New Date(2015, 2, 24, 10, 5, 6, 0)
        Me.Hasta.Location = New System.Drawing.Point(115, 36)
        Me.Hasta.Name = "Hasta"
        Me.Hasta.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.Hasta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hasta.Properties.Appearance.Options.UseFont = True
        Me.Hasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Hasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Hasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.Hasta.Size = New System.Drawing.Size(122, 20)
        Me.Hasta.StyleController = Me.frmComprobantesContadoListaConvertedLayout
        Me.Hasta.TabIndex = 1
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckEdit1.Location = New System.Drawing.Point(633, 164)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit1.Properties.Caption = "Marcar Todos"
        Me.CheckEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.CheckEdit1.Size = New System.Drawing.Size(113, 22)
        Me.CheckEdit1.StyleController = Me.frmComprobantesContadoListaConvertedLayout
        Me.CheckEdit1.TabIndex = 192
        '
        'Desde
        '
        Me.Desde.EditValue = New Date(2015, 2, 24, 10, 5, 6, 0)
        Me.Desde.Location = New System.Drawing.Point(115, 12)
        Me.Desde.Name = "Desde"
        Me.Desde.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.Desde.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desde.Properties.Appearance.Options.UseFont = True
        Me.Desde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Desde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Desde.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.Desde.Size = New System.Drawing.Size(122, 20)
        Me.Desde.StyleController = Me.frmComprobantesContadoListaConvertedLayout
        Me.Desde.TabIndex = 0
        '
        'gridDatos
        '
        Me.gridDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDatos.Location = New System.Drawing.Point(12, 186)
        Me.gridDatos.MainView = Me.vDatos
        Me.gridDatos.Name = "gridDatos"
        Me.gridDatos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbCentros})
        Me.gridDatos.Size = New System.Drawing.Size(734, 189)
        Me.gridDatos.TabIndex = 5
        Me.gridDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vDatos})
        '
        'vDatos
        '
        Me.vDatos.GridControl = Me.gridDatos
        Me.vDatos.Name = "vDatos"
        Me.vDatos.OptionsView.ShowAutoFilterRow = True
        Me.vDatos.OptionsView.ShowFooter = True
        Me.vDatos.OptionsView.ShowGroupPanel = False
        '
        'cbCentros
        '
        Me.cbCentros.AutoHeight = False
        Me.cbCentros.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCentros.Name = "cbCentros"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem9, Me.LayoutControlItem11, Me.LayoutControlItem16, Me.LayoutControlItem8, Me.LayoutControlItem5, Me.LayoutControlItem4, Me.LayoutControlItem7, Me.LayoutControlItem6, Me.EmptySpaceItem1, Me.LayoutControlItem1, Me.EmptySpaceItem3, Me.LayoutControlItem3, Me.LayoutControlItem10})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(758, 409)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtComentario
        Me.LayoutControlItem2.CustomizationFormText = "Concepto:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 78)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(0, 48)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(115, 48)
        Me.LayoutControlItem2.Name = "txtComentarioitem"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(738, 48)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Concepto Ventas:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.gridDatos
        Me.LayoutControlItem9.CustomizationFormText = "gridDatositem"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 174)
        Me.LayoutControlItem9.Name = "gridDatositem"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(738, 193)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.ProgressBarControl1
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 367)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(0, 22)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(54, 22)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(738, 22)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.txtComentario2
        Me.LayoutControlItem16.CustomizationFormText = "Concepto Costos:"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(0, 48)
        Me.LayoutControlItem16.MinSize = New System.Drawing.Size(126, 48)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(621, 48)
        Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem16.Text = "Concepto Costos:"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.Desde
        Me.LayoutControlItem8.CustomizationFormText = "Desde:"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(229, 24)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(229, 24)
        Me.LayoutControlItem8.Name = "Desdeitem"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(229, 24)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.Text = "Desde:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.Hasta
        Me.LayoutControlItem5.CustomizationFormText = "Hasta:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(229, 28)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(229, 28)
        Me.LayoutControlItem5.Name = "Hastaitem"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(229, 28)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "Hasta:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.btnBuscar
        Me.LayoutControlItem4.CustomizationFormText = "Desde:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(229, 10)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(103, 42)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(103, 42)
        Me.LayoutControlItem4.Name = "btnBuscaritem"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(103, 42)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "Desde:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cbTipo
        Me.LayoutControlItem7.CustomizationFormText = "Comprobante Costo:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(474, 52)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(264, 26)
        Me.LayoutControlItem7.Text = "Comprobante Costo:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.CheckEdit1
        Me.LayoutControlItem6.CustomizationFormText = "CheckEdit1item"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(621, 152)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(117, 22)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(117, 22)
        Me.LayoutControlItem6.Name = "CheckEdit1item"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(117, 22)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(621, 126)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(117, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Fecha
        Me.LayoutControlItem1.CustomizationFormText = "Fecha de Proceso:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(229, 24)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(229, 24)
        Me.LayoutControlItem1.Name = "Fechaitem"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(229, 26)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Fecha de Proceso:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(100, 13)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(229, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(509, 10)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbCajas
        Me.LayoutControlItem3.CustomizationFormText = "Caja:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(229, 52)
        Me.LayoutControlItem3.Name = "cbCajasitem"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(245, 26)
        Me.LayoutControlItem3.Text = "Caja:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.lblTipo
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(332, 10)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(406, 42)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
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
        Me.DockPanel1.ID = New System.Guid("dab94ae9-c341-473b-b211-91d0d9fa38e3")
        Me.DockPanel1.Location = New System.Drawing.Point(758, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(150, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(150, 409)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(141, 382)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'frmComprobantesContadoLista
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(908, 409)
        Me.Controls.Add(Me.frmComprobantesContadoListaConvertedLayout)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "frmComprobantesContadoLista"
        Me.Text = "Comprobantes de Venta de Contado"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmComprobantesContadoListaConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmComprobantesContadoListaConvertedLayout.ResumeLayout(False)
        CType(Me.txtComentario2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComentario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCajas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Desde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Desde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCentros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Fact As String
    Public FactValor As String
    Public TipoFact As Integer = 0

    Dim r As New VB.SysContab.Rutinas()
    Dim Comp As New VB.SysContab.ComprobanteDB()
    Dim Tabla As New DataTable()
    Dim DT_VENTAS As New DataTable("Ventas")

    Private Sub frmComprobantesContadoLista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'dgEstadoCuenta.ReadOnly = True
        'Dim DS As New DataSet()
        'Dim Todos As Integer

        'If ckbTodos.Checked = True Then
        '    Todos = 1
        'Else
        '    Todos = 0
        'End If
        'If TipoFact = 1 Then
        '    DS = FactVentas.GetListContado(dtpFecha.Value, Todos)
        '    Me.Text = "Comprobantes de Ventas de Contado"
        'End If
        'If TipoFact = 2 Then
        '    DS = FactVentas.GetListCredito(dtpFecha.Value, Todos)
        '    Me.Text = "Comprobantes de Ventas de Crédito"
        'End If
        'dgEstadoCuenta.DataSource = DS.Tables("Tablas").DefaultView
        'Tabla = DS.Tables("Tablas")        
        'r.FormatGenerico(dgEstadoCuenta, Tabla)

        Me.Desde.DateTime = Now.Date
        Me.Hasta.DateTime = Now.Date
        Me.Fecha.DateTime = Now.Date
        GetCajasFacturacion(Me.cbCajas)

        Me.cbTipo.Properties.DataSource = Comp.GetTiposComprobantes(0).Tables("TipoComprobantes")
        Me.cbTipo.Properties.ValueMember = "TipComp_Id"
        Me.cbTipo.Properties.DisplayMember = "TipComp_Nombre"
        Me.cbTipo.Properties.PopulateColumns()

        For i As Integer = 0 To Me.cbTipo.Properties.Columns.Count - 1
            Me.cbTipo.Properties.Columns(i).Visible = False
        Next

        Me.cbTipo.Properties.Columns(2).Visible = True
        Me.cbTipo.ItemIndex = 0

        Combo(
            cbCentros,
            ObtieneDatos("SELECT cdc.Codigo, cdc.Nombre FROM CentroDeCosto cdc" _
                                                   + " WHERE cdc.Activo = 1 AND cdc.Empresa = " & EmpresaActual & " ORDER BY cdc.Nombre"))

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '' Buscar()
    End Sub

    Sub Buscar()

        'Dim DS As New DataSet()

        'Dim Todos As Integer

        'If ckbTodos.Checked = True Then
        '    Todos = 1
        'Else
        '    Todos = 0
        'End If

        'If TipoFact = 1 Then
        '    DS = FactVentas.GetListContado(dtpFecha.Value, Todos)
        'End If

        'If TipoFact = 2 Then
        '    DS = FactVentas.GetListCredito(dtpFecha.Value, Todos)
        'End If

        'dgEstadoCuenta.DataSource = DS.Tables("Tablas").DefaultView
        'Tabla = DS.Tables("Tablas")
    End Sub

    Private Sub cmdProceso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Close()
    End Sub

    Private Sub btnContabilizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContabilizar.Click
        'Verificar Cierre del Día
        '*******************************************************************************************
        If Not VerificarCierre(Fecha.DateTime.Date) Then
            Exit Sub
        End If
        '*******************************************************************************************

        '*******************************************************************************************
        ' Validar Cierre de Inventario
        If Not VerificarCierre_Inventario(Hasta.DateTime.Date) Then
            Exit Sub
        End If
        '*******************************************************************************************

        If vDatos.DataRowCount = 0 Then
            XtraMsg("No hay Facturas en la Lista")
            Exit Sub
        End If
        ''
        If cbTipo.ItemIndex = 0 Then
            XtraMsg("Seleccione el Tipo de Comprobante")
            Me.cbTipo.Focus()
            Exit Sub
        End If
        ''
        If txtComentario.Text.Trim.Length = 0 Then
            XtraMsg("Describa el Concepto del Comprobante de Ventas.", MessageBoxIcon.Information)
            txtComentario.Focus()
            Exit Sub
        End If
        ''
        If txtComentario2.Text.Trim.Length = 0 Then
            XtraMsg("Describa el Concepto del Comprobante de Costos.", MessageBoxIcon.Information)
            txtComentario2.Focus()
            Exit Sub
        End If
        ''
        Dim selec As Boolean = False
        For i As Integer = 0 To Me.vDatos.DataRowCount - 1
            If vDatos.GetRowCellValue(i, "Seleccionar") Then
                selec = True
                Exit For
            End If
        Next
        '
        If Not selec Then
            XtraMsg("Debe Seleccionar al Menos 1 Factura", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '        
        If Not XtraMsg2("Esta Seguro de Procesar la Información Seleccionada?") Then
            Exit Sub
        End If

        Dim dtl As DataTable
        Dim dtlCobro As DataTable
        Dim DetalleProducto As New ArticulosDetails
        '
        Dim CompNo As Integer = 0
        Dim CompNo_Costo As Integer = 0
        Dim Contabilizadas As Integer = 0
        Dim NoEncontrada As Integer = 0
        Dim SinCuenta As Integer = 0
        Dim iError As Integer = 0
        Dim Agregado As Boolean = False
        Dim Repetido As Boolean = False
        '
        Dim CuentaIVA As String
        Dim MontoIVA As Double = 0
        Dim CuentaIR As String
        '
        Dim CuentasCaja As New ArrayList    'CUENTAS CONTABLES DE LA CAJA
        Dim MontosCaja As New ArrayList        'MONTO DE LOS INGRESOS A LA CAJA
        '
        Dim CuentasCentros As New ArrayList       'CUENTAS CONTABLES DE LA CAJA
        Dim MontosCentros As New ArrayList        'MONTO DE LOS INGRESOS A LA CAJA
        '
        Dim CuentasTarjeta As New ArrayList       'CUENTAS CONTABLES DE TARJETA DE CREDITO
        Dim MontosTarjeta As New ArrayList        'MONTO DE LOS INGRESOS POR TARJETA DE CREDITO
        '
        Dim CuentasServicio As New ArrayList       'CUENTAS CONTABLES DE SERVICIOS
        Dim MontosServicio As New ArrayList        'MONTO DE LOS SERVICIOS
        '
        Dim CuentasIventario As New ArrayList     'CUENTAS CONTABLES D PRODUCTOS
        Dim MontosIventario As New ArrayList  'MONTO DE PRODUCTOS INVENTARIO
        '
        Dim CuentasCostos As New ArrayList     'CUENTAS CONTABLES D PRODUCTOS
        Dim MontosCostos As New ArrayList  'MONTO DE PRODUCTOS COSTO
        '
        Dim CuentasIngresos As New ArrayList   'CUENTAS CONTABLES D PRODUCTOS
        Dim MontosIngresos As New ArrayList  'MONTO DE PRODUCTOS INVENTARIO VS. COSTO
        '
        ''  Dim ArrayNombres As New ArrayList       '
        Dim ArrayCentros As New ArrayList       'CENTROS DE DISTRIBUCION
        '
        Dim TotalCredito As Double = 0, TotalDebito As Double = 0

        'Verificando Plantillas Contables
        Dim Plantilla As New VB.SysContab.PlantillaDB()
        Dim TipoCompr As Integer = 0

        If TipoFact = 1 Then    'Facturas de Contado
            If Plantilla.GetPlantillasDetails(4, 1).PlaID Is DBNull.Value Or Plantilla.GetPlantillasDetails(4, 1).PlaID Is Nothing Or Plantilla.GetPlantillasDetails(4, 1).PlaID = "" Then
                XtraMsg("No existen plantilla del tipo Pago de Contado", MessageBoxIcon.Error)
                Exit Sub
            End If

            TipoCompr = Plantilla.GetPlantillasDetails(4, 1).TipoCompr
            '
            Dim DsPlantillas As DataSet = Plantilla.GetPlantillasDetails(4, 1).Detalles
            '
            CuentaIR = DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")
            CuentaIVA = DsPlantillas.Tables("PlantillasDetalles").Rows(3).Item("Cuenta")
            'CuentaCaja = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
            'CuentaIngr = DsPlantillas.Tables("PlantillasDetalles").Rows(2).Item("Cuenta")
        ElseIf TipoFact = 2 Then    'Facturas de Credito
            If Plantilla.GetPlantillasDetails(4, 2).PlaID Is DBNull.Value Or Plantilla.GetPlantillasDetails(4, 2).PlaID Is Nothing Or Plantilla.GetPlantillasDetails(4, 2).PlaID = "" Then
                XtraMsg("No existen plantilla del tipo Pago de Crédito", MessageBoxIcon.Error)
                Exit Sub
            End If

            TipoCompr = Plantilla.GetPlantillasDetails(4, 2).TipoCompr
            '
            Dim DsPlantillas As DataSet = Plantilla.GetPlantillasDetails(4, 2).Detalles
            '
            CuentaIVA = DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")
            'CuentaIngr = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
        End If
        '         
        '****************   Genear Tabla Temporal de ARTICULOS  ******************
        Guardar("JAR_CrearArticulosTemp", EmpresaActual)
        '*************************************************************************

        Dim Per_Id As Integer =
            PeriodosDB.Activo(Me.Fecha.DateTime.Date)

        Try
            ' ENCABEZADO DEL COMPROBANTE
            CompNo = ComprobanteDB.AddComprobante_NoTrans(TipoCompr, 1.0, Me.txtComentario.Text.Trim,
                                         EmpresasDB.GetDetails(EmpresaActual).MonedaBase,
                                         Per_Id, Me.Fecha.DateTime.Date,
                                         0, "", False, 0, "", 0, Me.Fecha.DateTime.Day.ToString & Me.Fecha.DateTime.Month.ToString & Me.Fecha.DateTime.Year.ToString,
                                         VB.SysContab.Rutinas.Fecha, 0, OrigenComprobantes.VENTAS)

            CompNo_Costo = ComprobanteDB.AddComprobante_NoTrans(cbTipo.EditValue, 1.0, txtComentario2.Text,
                                         EmpresasDB.GetDetails(EmpresaActual).MonedaBase,
                                         Per_Id, Me.Fecha.DateTime.Date,
                                         0, "", False, 0, "", 0, Me.Fecha.DateTime.Day.ToString & Me.Fecha.DateTime.Month.ToString & Me.Fecha.DateTime.Year.ToString,
                                         VB.SysContab.Rutinas.Fecha, 0, OrigenComprobantes.VENTAS)

            Dim dtDistribucion As DataTable = CargaDistribucion(0, 0, 0)
            Dim dtDistribucion_Costos As DataTable = CargaDistribucion(0, 0, 0)

            '*********************  INICIAR TRANSACCION *************************************
            DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction()
            '*********************************************************************************

            '**************************************************************************************************************
            ' RECORRER CADA FACTURA
            '**************************************************************************************************************

            Me.ProgressBarControl1.Properties.Minimum = 0
            Me.ProgressBarControl1.Properties.Maximum = vDatos.DataRowCount
            '
            For i As Integer = 0 To Me.vDatos.DataRowCount - 1
                If Me.vDatos.GetRowCellValue(i, "Seleccionar") Then
                    Agregado = False
                    dtl = ObtieneDatosTrans("JAR_GetVentaDetalle",
                                            vDatos.GetRowCellValue(i, "FACTURA"),
                                            EmpresaActual)
                    '
                    ''dtlCobro = ObtieneDatosTrans("sp_GetCobrosxFacturaContado '" & Me.vDatos.GetRowCellValue(i, "FACTURA") & "'," & EmpresaActual)

                    If dtl.Rows.Count = 0 Then GoTo SALTAR

                    '*****************  DETALLE DE LA FACTURA ******************************
                    For j As Integer = 0 To dtl.Rows.Count - 1

                        'If dtl.Rows.Item(j)("ITEM") = "M02958A002" Then
                        '    XtraMsg(dtl.Rows.Item(j)("ITEM"))
                        '    XtraMsg("Detenerse Aqui")
                        'End If

                        DetalleProducto =
                            ArticulosDB.GetDetailsTrans(
                            dtl.Rows.Item(j)("ITEM"),
                            dtl.Rows.Item(j)("TIPO"),
                            EmpresaActual)
                        '***** Descargando Producto de Bodegas *********************
                        '
                        If dtl.Rows.Item(j)("TIPO") = "P" Then

                            If Agregado = False Then
                                VB.SysContab.BodegasDB.TransaccionBodega_Add(Me.vDatos.GetRowCellValue(i, "CODIGO_BODEGA"), "V", Me.vDatos.GetRowCellValue(i, "FACTURA"),
                                                                             Me.vDatos.GetRowCellValue(i, "FECHA"), 0)
                                Agregado = True
                            End If

                            VB.SysContab.BodegasDB.TransaccionBodegaDetalle_Add(Me.vDatos.GetRowCellValue(i, "CODIGO_BODEGA"), dtl.Rows.Item(j)("ITEM"), "V",
                                                                                Me.vDatos.GetRowCellValue(i, "FACTURA"), "S", CDbl(dtl.Rows.Item(j)("CANTIDAD")),
                                                                                dtl.Rows.Item(j)("COSTO"), 0, "P")
                            '
                            VB.SysContab.BodegasDB.Bodega_Articulos_Add(Me.vDatos.GetRowCellValue(i, "CODIGO_BODEGA"), dtl.Rows.Item(j)("ITEM"),
                                                                        CDbl(dtl.Rows.Item(j)("CANTIDAD")) * -1, dtl.Rows.Item(j)("COSTO"), "P")


                            '***** Termina descarga de Producto de Bodegas *********
                            '
                            Repetido = False
                            '' ***********   CUENTAS DE INGRESOS  ***************************************
                            For c As Integer = 0 To CuentasIngresos.Count - 1
                                If DetalleProducto.CIngreso = CuentasIngresos(c) Then
                                    MontosIngresos(c) = Math.Round(MontosIngresos(c) + dtl.Rows.Item(j)("TOTAL"), 2)
                                    TotalCredito = Math.Round(TotalCredito + dtl.Rows.Item(j)("TOTAL"), 2)
                                    Repetido = True
                                End If
                            Next

                            If Repetido = False Then
                                CuentasIngresos.Add(DetalleProducto.CIngreso)
                                MontosIngresos.Add(Math.Round(dtl.Rows.Item(j)("TOTAL"), 2))
                                TotalCredito = Math.Round(TotalCredito + dtl.Rows.Item(j)("TOTAL"), 2)
                            End If
                            '' ***********   FIN CUENTAS DE INGRESOS  **************************
                            '' ***********   CUENTAS DE INVENTARIO  ***************************************
                            Repetido = False

                            For c As Integer = 0 To CuentasIventario.Count - 1
                                If DetalleProducto.Cuenta = CuentasIventario(c) Then
                                    MontosIventario(c) = Math.Round(MontosIventario(c) + (dtl.Rows.Item(j)("CANTIDAD") * dtl.Rows.Item(j)("COSTO")), 2)
                                    Repetido = True
                                End If
                            Next

                            If Repetido = False Then
                                CuentasIventario.Add(DetalleProducto.Cuenta)
                                MontosIventario.Add(Math.Round((dtl.Rows.Item(j)("CANTIDAD") * dtl.Rows.Item(j)("COSTO")), 2))
                            End If
                            '' *********** FIN CUENTAS DE INVENTARIO  ***************************************

                            '' ***********   CUENTAS DE COSTO  ***************************************
                            Repetido = False

                            For c As Integer = 0 To CuentasCostos.Count - 1
                                If DetalleProducto.CCosto = CuentasCostos(c) Then
                                    MontosCostos(c) = Math.Round(MontosCostos(c) + (dtl.Rows.Item(j)("CANTIDAD") * dtl.Rows.Item(j)("COSTO")), 2)
                                    Repetido = True
                                End If
                            Next

                            If Repetido = False Then
                                CuentasCostos.Add(DetalleProducto.CCosto)
                                MontosCostos.Add(Math.Round((dtl.Rows.Item(j)("CANTIDAD") * dtl.Rows.Item(j)("COSTO")), 2))
                            End If
                            '' *********** FIN CUENTAS DE COSTO  ***************************************

                            '' Actualizar el Costo en el detalle del Factura
                            Guardar_Con_Transaccion("JAR_FacturaVentasUpdateCosto", dtl.Rows.Item(j)("FACTURA"), dtl.Rows.Item(j)("ITEM"), dtl.Rows.Item(j)("COSTO"), EmpresaActual)
                            '***********************************************************************************************
                            'FIN DE DISTRIBUCION -  CENTRO DE COSTOS
                            '***********************************************************************************************

                        ElseIf dtl.Rows.Item(j)("TIPO") = "S" Then
                            Repetido = False

                            For c As Integer = 0 To CuentasServicio.Count - 1
                                If DetalleProducto.Cuenta = CuentasServicio(c) Then
                                    MontosServicio(c) = Math.Round(MontosServicio(c) + dtl.Rows.Item(j)("TOTAL"), 2)
                                    Repetido = True
                                End If
                            Next

                            If Repetido = False Then
                                CuentasServicio.Add(DetalleProducto.Cuenta)
                                MontosServicio.Add(Math.Round(dtl.Rows.Item(j)("TOTAL"), 2))
                            End If

                            TotalCredito = Math.Round(TotalCredito + dtl.Rows.Item(j)("TOTAL"), 2)
                        End If

                        '/***************************************************************************************************
                        '*** EMPIEZA LA DISTRIBUCION
                        '***************************************************************************************************/
                        Dim Existe As Boolean = False, Existe_CCosto As Boolean = False
                        Dim ExisteCentro As Boolean = False

                        '' *********** VALIDAR DISTRIBUCION PARA EQUIPSA POR PRODUCTO ***************************************
                        'EQUIPOS Y ACCESORIOS
                        If EmpresaActual = 7 Or EmpresaActual = 17 Then

                            For c As Integer = 0 To ArrayCentros.Count - 1
                                ' Verifica si existe centro
                                If dtl.Rows.Item(j)("CENTRO") = ArrayCentros(c) Then

                                    If ObtieneDatosTrans("Select Codigo from  RubrosGastos WHERE CuentaContable = '" & DetalleProducto.CIngreso & "' AND Empresa  =" & EmpresaActual).Rows.Count > 0 Then
                                        ExisteCentro = True
                                        '' Distribucion Ingresos
                                        For d As Integer = 0 To dtDistribucion.Rows.Count - 1
                                            If DetalleProducto.CIngreso = dtDistribucion.Rows(d).Item("Cuenta") And
                                             dtDistribucion.Rows(d).Item("IdCentroCosto") = ArrayCentros(c) Then
                                                Existe = True
                                                dtDistribucion.Rows(d).Item("Valor") = Math.Round((dtl.Rows.Item(j)("TOTAL")), 2) + Math.Round(dtDistribucion.Rows(d).Item("Valor"), 2)
                                            End If
                                        Next
                                    Else
                                        Existe = True
                                    End If

                                    If dtl.Rows.Item(j)("TIPO") = "P" Then
                                        '''' Distribucion Costos
                                        For d As Integer = 0 To dtDistribucion_Costos.Rows.Count - 1
                                            If DetalleProducto.CCosto = dtDistribucion_Costos.Rows(d).Item("Cuenta") And
                                             dtDistribucion_Costos.Rows(d).Item("IdCentroCosto") = ArrayCentros(c) Then
                                                Existe_CCosto = True
                                                dtDistribucion_Costos.Rows(d).Item("Valor") = Math.Round((dtl.Rows.Item(j)("CANTIDAD") * dtl.Rows.Item(j)("COSTO")), 2) + Math.Round(dtDistribucion_Costos.Rows(d).Item("Valor"), 2)
                                            End If
                                        Next
                                    End If
                                End If
                            Next
                            '
                            If ExisteCentro = False Then
                                ' Verifica si no existe y lo agrega
                                ArrayCentros.Add(dtl.Rows.Item(j)("CENTRO"))
                            End If
                            '
                            ''******************** Agregar Distribucion de Ingresos *********************
                            If Existe = False Then

                                Dim row As DataRow
                                row = dtDistribucion.NewRow()
                                '
                                Try
                                    row("IdRubroGasto") = ObtieneDatosTrans("Select Codigo from  RubrosGastos WHERE CuentaContable = '" & DetalleProducto.CIngreso & "' AND Empresa  =" & EmpresaActual).Rows(0).Item("Codigo")

                                    row("IdEmpresa") = EmpresaActual
                                    row("NoComp") = CompNo
                                    row("Mes") = Month(CDate(Me.vDatos.GetRowCellValue(i, "FECHA")))
                                    row("Per_Id") = Per_Id
                                    row("IdCentroCosto") = dtl.Rows.Item(j)("CENTRO")
                                    row("Valor") = Math.Round(dtl.Rows.Item(j)("TOTAL"), 2)
                                    row("Tipo") = "C"
                                    row("Cuenta") = DetalleProducto.CIngreso

                                    dtDistribucion.Rows.Add(row)
                                Catch ex As Exception
                                    VB.SysContab.Rutinas.ErrorTransaccion()
                                    XtraMsg("La cuenta Contable de Ingreso: " & DetalleProducto.CIngreso & " no se encuentra en rubros de Distribución por favor agreguela para poder contabilizar ", MessageBoxIcon.Warning)
                                    Exit Sub
                                End Try

                            End If
                            ''
                            ''*************** Agregar Distribucion de los Costos *******************
                            If dtl.Rows.Item(j)("TIPO") = "P" Then

                                If Existe_CCosto = False Then

                                    Dim row As DataRow
                                    row = dtDistribucion_Costos.NewRow()
                                    '
                                    Try
                                        row("IdRubroGasto") = ObtieneDatosTrans("Select Codigo from  RubrosGastos WHERE CuentaContable = '" & DetalleProducto.CCosto & "' AND Empresa  =" & EmpresaActual).Rows(0).Item("Codigo")

                                        row("IdEmpresa") = EmpresaActual
                                        row("NoComp") = CompNo_Costo
                                        row("Mes") = Month(CDate(Me.vDatos.GetRowCellValue(i, "FECHA")))
                                        row("Per_Id") = Per_Id
                                        row("IdCentroCosto") = dtl.Rows.Item(j)("CENTRO")
                                        row("Valor") = Math.Round(dtl.Rows.Item(j)("CANTIDAD") * dtl.Rows.Item(j)("COSTO"), 2)
                                        row("Tipo") = "D"
                                        row("Cuenta") = DetalleProducto.CCosto

                                        dtDistribucion_Costos.Rows.Add(row)
                                    Catch ex As Exception
                                        VB.SysContab.Rutinas.ErrorTransaccion()
                                        XtraMsg("La cuenta Contable de Costo: " & DetalleProducto.CCosto & " no se encuentra en rubros de Distribución por favor agreguela para poder contabilizar ", MessageBoxIcon.Warning)
                                        Exit Sub
                                    End Try
                                End If
                            End If
                            '/*************************  PARA EL RESTO DE LAS COMPAÑIAS, LA DISTRIBUCION ES POR FACTURA ******************
                        Else
                            For c As Integer = 0 To ArrayCentros.Count - 1
                                ' Verifica si existe centro
                                If Me.vDatos.GetRowCellValue(i, "CentroID") = ArrayCentros(c) Then

                                    If ObtieneDatosTrans("Select Codigo from  RubrosGastos WHERE CuentaContable = '" & DetalleProducto.CIngreso & "' AND Empresa  =" & EmpresaActual).Rows.Count > 0 Then
                                        ExisteCentro = True
                                        '' Distribucion Ingresos
                                        For d As Integer = 0 To dtDistribucion.Rows.Count - 1
                                            If DetalleProducto.CIngreso = dtDistribucion.Rows(d).Item("Cuenta") And
                                             dtDistribucion.Rows(d).Item("IdCentroCosto") = ArrayCentros(c) Then
                                                Existe = True
                                                dtDistribucion.Rows(d).Item("Valor") = Math.Round((dtl.Rows.Item(j)("TOTAL")), 2) + Math.Round(dtDistribucion.Rows(d).Item("Valor"), 2)
                                            End If
                                        Next
                                    Else
                                        ExisteCentro = True
                                        Existe = True
                                    End If

                                    'ExisteCentro = True
                                    ' '' Distribucion Ingresos
                                    'For d As Integer = 0 To dtDistribucion.Rows.Count - 1
                                    '    If DetalleProducto.CIngreso = dtDistribucion.Rows(d).Item("Cuenta") And _
                                    '     dtDistribucion.Rows(d).Item("IdCentroCosto") = ArrayCentros(c) Then
                                    '        Existe = True
                                    '        dtDistribucion.Rows(d).Item("Valor") = Math.Round((dtl.Rows.Item(j)("TOTAL")), 2) + Math.Round(dtDistribucion.Rows(d).Item("Valor"), 2)
                                    '    End If
                                    'Next

                                    '''' Distribucion Costos
                                    If dtl.Rows.Item(j)("TIPO") = "P" Then

                                        For d As Integer = 0 To dtDistribucion_Costos.Rows.Count - 1
                                            If DetalleProducto.CCosto = dtDistribucion_Costos.Rows(d).Item("Cuenta") And
                                             dtDistribucion_Costos.Rows(d).Item("IdCentroCosto") = ArrayCentros(c) Then
                                                Existe_CCosto = True
                                                dtDistribucion_Costos.Rows(d).Item("Valor") = Math.Round((dtl.Rows.Item(j)("CANTIDAD") * dtl.Rows.Item(j)("COSTO")), 2) + Math.Round(dtDistribucion_Costos.Rows(d).Item("Valor"), 2)
                                            End If
                                        Next

                                    End If
                                End If
                            Next

                            If ExisteCentro = False Then
                                ' Verifica si no existe y lo agrega
                                ArrayCentros.Add(Me.vDatos.GetRowCellValue(i, "CentroID"))
                            End If
                            '

                            ''******************** Agregar Distribucion de Ingresos *********************
                            If Existe = False Then

                                Dim row As DataRow
                                row = dtDistribucion.NewRow()
                                '
                                Try
                                    row("IdRubroGasto") = ObtieneDatosTrans("Select Codigo from  RubrosGastos WHERE CuentaContable = '" & DetalleProducto.CIngreso & "' AND Empresa  =" & EmpresaActual).Rows(0).Item("Codigo")

                                    row("IdEmpresa") = EmpresaActual
                                    row("NoComp") = CompNo
                                    row("Mes") = Month(CDate(Me.vDatos.GetRowCellValue(i, "FECHA")))
                                    row("Per_Id") = Per_Id
                                    row("IdCentroCosto") = Me.vDatos.GetRowCellValue(i, "CentroID")
                                    row("Valor") = Math.Round(dtl.Rows.Item(j)("TOTAL"), 2)
                                    row("Tipo") = "C"
                                    row("Cuenta") = DetalleProducto.CIngreso

                                    dtDistribucion.Rows.Add(row)
                                Catch ex As Exception
                                    VB.SysContab.Rutinas.ErrorTransaccion()
                                    XtraMsg("La cuenta Contable de Ingreso: " & DetalleProducto.CIngreso & " no se encuentra en rubros de Distribución por favor agreguela para poder contabilizar ", MessageBoxIcon.Warning)
                                    Exit Sub
                                End Try
                            End If
                            ''
                            ''*************** Agregar Distribucion de los Costos *******************

                            If dtl.Rows.Item(j)("TIPO") = "P" Then

                                If Existe_CCosto = False Then

                                    Dim row As DataRow
                                    row = dtDistribucion_Costos.NewRow()
                                    '
                                    Try
                                        row("IdRubroGasto") = ObtieneDatosTrans("Select Codigo from  RubrosGastos WHERE CuentaContable = '" & DetalleProducto.CCosto & "' AND Empresa  =" & EmpresaActual).Rows(0).Item("Codigo")

                                        row("IdEmpresa") = EmpresaActual
                                        row("NoComp") = CompNo_Costo
                                        row("Mes") = Month(CDate(Me.vDatos.GetRowCellValue(i, "FECHA")))
                                        row("Per_Id") = Per_Id
                                        row("IdCentroCosto") = Me.vDatos.GetRowCellValue(i, "CentroID")
                                        row("Valor") = Math.Round(dtl.Rows.Item(j)("CANTIDAD") * dtl.Rows.Item(j)("COSTO"), 2)
                                        row("Tipo") = "D"
                                        row("Cuenta") = DetalleProducto.CCosto

                                        dtDistribucion_Costos.Rows.Add(row)
                                    Catch ex As Exception
                                        VB.SysContab.Rutinas.ErrorTransaccion()
                                        XtraMsg("La cuenta Contable de Costo: " & DetalleProducto.CCosto & " no se encuentra en rubros de Distribución por favor agreguela para poder contabilizar ", MessageBoxIcon.Warning)
                                        Exit Sub
                                        'Return Result
                                        'Result = Resultado.Distribucion
                                    End Try
                                End If
                            End If

                        End If

                        '/***************************************************************************************************
                        '*** TERMINA LA DISTRIBUCION
                        '***************************************************************************************************/
                    Next        '*****************  FIN DETALLE DE LA FACTURA ******************************

                    '*********************   CALCULANDO SUBTOTAL DE FACTURA (PARA LA CAJA Y CLIENTES) ***********************
                    'Esto es para DryClean, porque ellos calculan mal el descuento
                    Dim SubTotal_Monto As Double = vDatos.GetRowCellValue(i, "TOTAL") - IIf(EmpresaActual = 14, vDatos.GetRowCellValue(i, "DESCUENTO"), 0.0)   ' (vDatos.GetRowCellValue(i, "MONTO") + vDatos.GetRowCellValue(i, "IVA")) - vDatos.GetRowCellValue(i, "DESCUENTO")
                    Repetido = False

                    For c As Integer = 0 To CuentasCaja.Count - 1
                        If Me.vDatos.GetRowCellValue(i, "CUENTA CAJA") = CuentasCaja(c) Then
                            MontosCaja(c) = Math.Round(MontosCaja(c) + SubTotal_Monto, 2)
                            Repetido = True
                            TotalDebito = Math.Round(TotalDebito + SubTotal_Monto, 2)
                        End If
                    Next

                    If Repetido = False Then
                        CuentasCaja.Add(Me.vDatos.GetRowCellValue(i, "CUENTA CAJA"))
                        MontosCaja.Add(SubTotal_Monto)
                        TotalDebito = Math.Round(TotalDebito + SubTotal_Monto, 2)
                    End If

                    '*********************  FIN CALCULANDO SUBTOTAL DE FACTURA (PARA LA CAJA Y CLIENTES) ***********************

                    ''********************   DETALLE DEL COBRO PARA LAS FACTURAS DE CONTADO ************************
                    'dtlCobro = ObtieneDatosTrans("sp_GetCobrosxFacturaContado '" & Me.vDatos.GetRowCellValue(i, "FACTURA") & "'," & EmpresaActual)

                    'For k As Integer = 0 To dtlCobro.Rows.Count - 1
                    '    If dtlCobro.Rows.Item(k)("TIPO_PAGO") = 1 Or dtlCobro.Rows.Item(k)("TIPO_PAGO") = 2 Then    'Efectivo o Cheque
                    '        Dim Monto As Double = IIf(dtlCobro.Rows.Item(k)("TIPO_PAGO") = 1, dtlCobro.Rows.Item(k)("MONTO_EFECTIVO"), dtlCobro.Rows.Item(k)("MONTO_CHEQUE"))
                    '        Repetido = False
                    '        '
                    '        For c As Integer = 0 To CuentasCaja.Count - 1
                    '            If Me.vDatos.GetRowCellValue(i, "CUENTA CAJA") = CuentasCaja(c) Then
                    '                MontosCaja(c) = MontosCaja(c) + (Monto - ((Monto * Me.vDatos.GetRowCellValue(i, "IVA")) / dtlCobro.Rows.Item(k)("MONTO")))
                    '                Repetido = True
                    '                TotalDebito = Math.Round(TotalDebito + Monto, 2)
                    '            End If
                    '        Next

                    '        If Repetido = False Then
                    '            CuentasCaja.Add(Me.vDatos.GetRowCellValue(i, "CUENTA CAJA"))
                    '            MontosCaja.Add((Monto - ((Monto * Me.vDatos.GetRowCellValue(i, "IVA")) / dtlCobro.Rows.Item(k)("MONTO"))))
                    '            TotalDebito = Math.Round(TotalDebito + Monto, 2)
                    '        End If
                    '    ElseIf dtlCobro.Rows.Item(k)("TIPO_PAGO") = 3 Then  'Tarjeta
                    '        Repetido = False

                    '        For c As Integer = 0 To CuentasTarjeta.Count - 1
                    '            If dtlCobro.Rows.Item(k)("CUENTA") = CuentasTarjeta(c) Then
                    '                MontosTarjeta(c) = MontosTarjeta(c) + (dtlCobro.Rows.Item(k)("MONTO_TARJETA") - ((dtlCobro.Rows.Item(k)("MONTO_TARJETA") * Me.vDatos.GetRowCellValue(i, "IVA")) / dtlCobro.Rows.Item(k)("MONTO")))
                    '                Repetido = True
                    '                TotalDebito = Math.Round(TotalDebito + dtlCobro.Rows.Item(k)("MONTO_TARJETA"), 2)
                    '            End If
                    '        Next

                    '        If Repetido = False Then
                    '            CuentasTarjeta.Add(dtlCobro.Rows.Item(k)("CUENTA"))
                    '            MontosTarjeta.Add((dtlCobro.Rows.Item(k)("MONTO_TARJETA") - ((dtlCobro.Rows.Item(k)("MONTO_TARJETA") * Me.vDatos.GetRowCellValue(i, "IVA")) / dtlCobro.Rows.Item(k)("MONTO"))))
                    '            TotalDebito = Math.Round(TotalDebito + dtlCobro.Rows.Item(k)("MONTO_TARJETA"), 2)
                    '        End If
                    '    ElseIf dtlCobro.Rows.Item(k)("TIPO_PAGO") = 4 Then   'Nota de Debito
                    '    End If
                    'Next
                    ''********************   FIN DETALLE DEL COBRO PARA LAS FACTURAS DE CONTADO ********************

                    If Me.vDatos.GetRowCellValue(i, "IVA") > 0 Then
                        MontoIVA = Math.Round(MontoIVA + Me.vDatos.GetRowCellValue(i, "IVA"), 2)
                        TotalCredito = Math.Round(TotalCredito + Me.vDatos.GetRowCellValue(i, "IVA"), 2)
                    End If

                    Contabilizadas += 1 'Contador de Facturas Procesadas
                    ''Marcar Factura como Contabilizada...........
                    Guardar_Con_Transaccion("JAR_FacturaVentasUpdateEstado", vDatos.GetRowCellValue(i, "FACTURA"),
                                            CompNo,
                                            Per_Id,
                                            Fecha.DateTime.Date.Month,
                                            EmpresaActual)
                End If
SALTAR:
                Me.ProgressBarControl1.Increment(1)
                Me.ProgressBarControl1.Refresh()
            Next

            Dim CuentaDiferencia As String = "" '', TipoDiferencia As String = "D"
            Dim TotalDiferencia As Double = TotalDebito - TotalCredito
            If TotalDiferencia < 0 Then TotalDiferencia = TotalDiferencia * -1

            'XtraMsg("Diferencias Encontradas, TotalDebito = " & CDbl(TotalDebito).ToString("n2") & ". TotalCredito = " & CDbl(TotalCredito).ToString("n2") & _
            '            vbCrLf & "Diferencia = " & CDbl(TotalDebito - TotalCredito).ToString("n2"), MessageBoxIcon.Exclamation)
            'Rutinas.ErrorTransaccion()
            'Exit Sub

            If TotalDebito <> TotalCredito Then
                XtraMsg("Diferencias Encontradas, TotalDebito = " & CDbl(TotalDebito).ToString("n2") & ". TotalCredito = " & CDbl(TotalCredito).ToString("n2") &
                        vbCrLf & "Diferencia = " & CDbl(TotalDebito - TotalCredito).ToString("n2"), MessageBoxIcon.Exclamation)

                If XtraMsg2("Desea Ajustar Diferencia ?") Then
                    With frmCuentaDiferenciaVentas
                        .ShowDialog()
                        If .ok = "SI" Then
                            CuentaDiferencia = .cbCatalogo.EditValue
                            ''TipoDiferencia = .RadioGroup1.EditValue
                            .Dispose()
                        Else
                            Rutinas.ErrorTransaccion()
                            Finalizar()
                            Exit Sub
                        End If
                    End With
                Else
                    Rutinas.ErrorTransaccion()
                    Finalizar()
                    Exit Sub
                End If
            End If

            '*****************  CONTABILIZANDO DEBITOS ***********************
            '*****************************************************************
            'Cajas / Clientes
            'IIf(TipoFact = 1, "Ingresos y Cajas", "Cuentas x Cobrar a Clientes"),
            For c As Integer = 0 To CuentasCaja.Count - 1
                ComprobanteDB.AddComprobanteDetalles(
                    CompNo,
                    CuentasCaja(c),
                    txtComentario.Text,
                    Math.Round(MontosCaja(c), 2),
                    "0",
                    TipoCompr,
                    "D",
                    "0",
                    "0",
                    Fecha.DateTime.Date, 1)
            Next
            'Tarjetas
            For c As Integer = 0 To CuentasTarjeta.Count - 1
                ComprobanteDB.AddComprobanteDetalles(CompNo, CuentasTarjeta(c), ObtieneNombreCuenta(CuentasTarjeta(c)),
                                            Math.Round(MontosTarjeta(c), 2), "0", TipoCompr, "D", "0", "0", Me.Fecha.DateTime.Date, 1)
            Next
            'Costos de Venta
            For c As Integer = 0 To CuentasCostos.Count - 1
                ComprobanteDB.AddComprobanteDetalles(CompNo_Costo, CuentasCostos(c), ObtieneNombreCuenta(CuentasCostos(c)),
                                            Math.Round(MontosCostos(c), 2), "0", cbTipo.EditValue, "D", "0", "0", Me.Fecha.DateTime.Date, 1)
            Next

            '*****************  CONTABILIZANDO CREDITO ***********************
            '*****************************************************************

            'Servicios
            For c As Integer = 0 To CuentasServicio.Count - 1
                ComprobanteDB.AddComprobanteDetalles(CompNo, CuentasServicio(c), ObtieneNombreCuenta(CuentasServicio(c)),
                                            IIf(Math.Round(MontosServicio(c), 2) < 0, Math.Round(MontosServicio(c), 2) * -1, Math.Round(MontosServicio(c), 2)),
                                            "0", TipoCompr, IIf(Math.Round(MontosServicio(c), 2) < 0, "D", "C"), "0", "0", Me.Fecha.DateTime.Date, 1)
            Next
            'Ingresos de Venta
            For c As Integer = 0 To CuentasIngresos.Count - 1
                ComprobanteDB.AddComprobanteDetalles(CompNo, CuentasIngresos(c), ObtieneNombreCuenta(CuentasIngresos(c)),
                                            Math.Round(MontosIngresos(c), 2), "0", TipoCompr, "C", "0", "0", Me.Fecha.DateTime.Date, 1)
            Next
            'Inventario
            For c As Integer = 0 To CuentasIventario.Count - 1
                ComprobanteDB.AddComprobanteDetalles(CompNo_Costo, CuentasIventario(c), ObtieneNombreCuenta(CuentasIventario(c)),
                                            Math.Round(MontosIventario(c), 2), "0", cbTipo.EditValue, "C", "0", "0", Me.Fecha.DateTime.Date, 1)
            Next

            'IVA
            If MontoIVA > 0 Then
                ComprobanteDB.AddComprobanteDetalles(CompNo, CuentaIVA, ObtieneNombreCuenta(CuentaIVA),
                                            Math.Round(MontoIVA, 2), "0", TipoCompr, "C", "0", "0", Me.Fecha.DateTime.Date, 1)
            End If


            If TotalDebito <> TotalCredito Then
                If TotalDebito < TotalCredito Then
                    ComprobanteDB.AddComprobanteDetalles(CompNo, CuentaDiferencia, "Ajuste por Diferencias",
                                        Math.Round(TotalDiferencia, 2), "0", TipoCompr, "D", "0", "0", Me.Fecha.DateTime.Date, 1)
                Else
                    ComprobanteDB.AddComprobanteDetalles(CompNo, CuentaDiferencia, "Ajuste por Diferencias",
                                        Math.Round(TotalDiferencia, 2), "0", TipoCompr, "C", "0", "0", Me.Fecha.DateTime.Date, 1)
                End If
            End If

            Rutinas.okTransaccion()

            '----------------------
            'Guarda la Distribucion
            '----------------------

            For i As Integer = 0 To dtDistribucion.Rows.Count - 1
                If dtDistribucion.Rows.Item(i)("Valor") < 0 Then
                    dtDistribucion.Rows.Item(i)("Valor") = dtDistribucion.Rows.Item(i)("Valor") * -1
                    dtDistribucion.Rows.Item(i)("Tipo") = "D"
                End If
            Next

            GuardarDistribucion(dtDistribucion, Me.Fecha.DateTime.Date, CompNo)
            GuardarDistribucion(dtDistribucion_Costos, Me.Fecha.DateTime.Date, CompNo_Costo)

            'If SinDistribuir = False Then            
            '    'GuardarDistribucion(TC, dtDistribucion, Me.Fecha.DateTime.Date, CompNo)
            'End If
            '-----------------------------
            'Fin de Guarda Distribucion
            '-----------------------------
            'Rutinas.ErrorTransaccion()

            'Verificar si se contabilizaron los Costos,
            'sino hubo contabilizacion de Costos, entonces se borra el comprobante.
            If CuentasCostos.Count = 0 Then
                Guardar("JAR_BorrarComprobante", CompNo_Costo,
                                                 Per_Id,
                                                 Fecha.DateTime.Date.Month,
                                                 EmpresaActual)
            End If

            XtraMsg("Las Ventas de " + IIf(TipoFact = 1, "CONTADO", "CREDITO").ToString + " han sido procesadas correctamente!!!")
            '
            Finalizar()
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            Rutinas.ErrorTransaccion()

            Finalizar()
            'ProgressBarControl1.EditValue = 0
        End Try

        'Dim Config As New VB.SysContab.ConfiguracionDB()
        'Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails()
        'ConfigDetalles = Config.GetConfigDetails

        'Fact = dgEstadoCuenta.Item(dgEstadoCuenta.CurrentRowIndex, 1)
        'FactValor = dgEstadoCuenta.Item(dgEstadoCuenta.CurrentRowIndex, 9)

        'Dim Subtotal As String = dgEstadoCuenta.Item(dgEstadoCuenta.CurrentRowIndex, 7)
        'Dim IVA As String = dgEstadoCuenta.Item(dgEstadoCuenta.CurrentRowIndex, 8)
        'Dim FechaFact As String = dgEstadoCuenta.Item(dgEstadoCuenta.CurrentRowIndex, 2)

        'Dim IR As String

        'IR = CDbl(CDbl(Subtotal).ToString(Round)) * (CDbl(ConfigDetalles.IRProd) / 100.0)
        'FactValor = CDbl(CDbl(Subtotal).ToString(Round)) + CDbl(CDbl(IVA).ToString(Round)) - CDbl(CDbl(IR).ToString(Round))

        'Dim CuentaIngr As String
        'Dim CuentaIVA As String
        'Dim CuentaCaja As String
        'Dim CuentaIR As String

        'Dim Comprobantes As New VB.SysContab.ComprobanteDB()
        ''Dim Plantilla As New VB.SysContab.PlantillaDB()
        'Dim TasaCambio As New VB.SysContab.Tasa_CambioDB()


        'Dim Todos As Integer
        'If ckbTodos.Checked = True Then
        '    Todos = 1
        'Else
        '    Todos = 0
        'End If

        'If TipoFact = 1 Then

        '    'Dim TipoCOmpr As String = Plantilla.GetPlantillasDetails(4, 1).TipoCompr

        '    If Plantilla.GetPlantillasDetails(4, 1).PlaID Is DBNull.Value Or Plantilla.GetPlantillasDetails(4, 1).PlaID Is Nothing Or Plantilla.GetPlantillasDetails(4, 1).PlaID = "" Then
        '        MsgBox("No existen plantilla del tipo Pago de Contado")
        '        Return
        '    Else
        '        Dim DsPlantillas As DataSet = Plantilla.GetPlantillasDetails(4, 1).Detalles
        '        CuentaCaja = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
        '        CuentaIR = DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")
        '        CuentaIngr = DsPlantillas.Tables("PlantillasDetalles").Rows(2).Item("Cuenta")
        '        CuentaIVA = DsPlantillas.Tables("PlantillasDetalles").Rows(3).Item("Cuenta")

        '        'CuentaIngr = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
        '        'CuentaIVA = DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")
        '        'CuentaCaja = DsPlantillas.Tables("PlantillasDetalles").Rows(2).Item("Cuenta")

        '        ' FALTA la Moneda y la tasa de cambio
        '        If Comprobantes.GeneraComprobanteFactura(CuentaCaja, FactValor, "Por Factura No. " & Fact, _
        '                                                  CuentaIngr, Subtotal, "Ingreso por Fact No. " & Fact, _
        '                                                   CuentaIVA, IVA, "IVA Por Fact. No. " & Fact, TipoCOmpr, _
        '                                                1, _
        '                                                1, "Comprobante de Factura No. " & Fact, TipoCOmpr, FechaFact, Fact, CuentaIR, IR, "IR Por Fact. No " & Fact, 1) = True Then

        '            MsgBox("Se ha contabilizado correctamente la Factura", MsgBoxStyle.Information)
        '            Dim DS As New DataSet()

        '            DS = FactVentas.GetListContado(dtpFecha.Value, Todos)


        '            dgEstadoCuenta.DataSource = DS.Tables("Tablas").DefaultView
        '            Tabla = DS.Tables("Tablas")

        '            'r.FormatGenerico(dgEstadoCuenta, Tabla)
        '        Else
        '            MsgBox("No se ha podido contabilizar la Factura", MsgBoxStyle.Exclamation)
        '        End If
        '    End If


        'End If

        ''Crédito
        'If TipoFact = 2 Then

        '    Dim Cliente As String = dgEstadoCuenta.Item(dgEstadoCuenta.CurrentRowIndex, 0)

        '    Dim ClientesDB As New VB.SysContab.ClientesDB()

        '    Dim TipoCOmpr As String = Plantilla.GetPlantillasDetails(4, 2).TipoCompr

        '    If Plantilla.GetPlantillasDetails(4, 2).PlaID Is DBNull.Value Or Plantilla.GetPlantillasDetails(4, 2).PlaID Is Nothing Or Plantilla.GetPlantillasDetails(4, 2).PlaID = "" Then
        '        MsgBox("No existen plantilla del tipo Pago de Crédito")
        '        Return
        '    Else
        '        Dim DsPlantillas As DataSet = Plantilla.GetPlantillasDetails(4, 2).Detalles
        '        'CuentaCaja = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
        '        'CuentaIR = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
        '        CuentaIngr = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
        '        CuentaIVA = DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")
        '        'CuentaIngr = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
        '        'CuentaIVA = DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")

        '        ' FALTA la Moneda y la tasa de cambio
        '        'If Comprobantes.GeneraComprobanteFactura(ClientesDB.GetDetails(Cliente).Cuenta, FactValor, "Por Factura No." & Fact, _
        '        '                                           CuentaIngr, Subtotal, "Ingreso por Fact No." & Fact, _
        '        '                                           CuentaIVA, IVA, "IVA Por Fact. No." & Fact, TipoCOmpr, _
        '        '                                        1, _
        '        '                                        1, "Comprobante de Factura No. " & Fact, TipoCOmpr, Today, Fact) = True Then

        '        FactValor = CDbl(CDbl(Subtotal).ToString(Round)) + CDbl(CDbl(IVA).ToString(Round)) '- CDbl(CDbl(IR).ToString(Round))
        '        IR = 0

        '        If Comprobantes.GeneraComprobanteFactura(ClientesDB.GetDetails(Cliente).Cuenta, FactValor, "Por Factura No." & Fact, _
        '                                   CuentaIngr, Subtotal, "Ingreso por Fact No." & Fact, _
        '                                   CuentaIVA, IVA, "IVA Por Fact. No." & Fact, TipoCOmpr, _
        '                                1, _
        '                                1, "Comprobante de Factura No. " & Fact, TipoCOmpr, FechaFact, Fact, CuentaIR, IR, "IR Por Fact. No " & Fact, 2) = True Then
        '            MsgBox("Se ha contabilizado correctamente la Factura", MsgBoxStyle.Information)
        '            Dim DS As New DataSet()

        '            DS = FactVentas.GetListContado(dtpFecha.Value, Todos)


        '            dgEstadoCuenta.DataSource = DS.Tables("Tablas").DefaultView
        '            Tabla = DS.Tables("Tablas")
        '            'r.FormatGenerico(dgEstadoCuenta, Tabla)
        '        Else
        '            MsgBox("No se ha podido contabilizar la Factura", MsgBoxStyle.Exclamation)
        '        End If
        '    End If
        'End If

    End Sub

    Sub Finalizar()
        '' ******  Limpiando Controles  ******************
        Me.ProgressBarControl1.EditValue = 0
        txtComentario.Text = ""
        txtComentario2.Text = ""
        CheckEdit1.Checked = False
        '' ***********************************************
        '
        Cargar()
    End Sub

    Function ObtieneNombreCuenta(ByVal Cuenta As String) As String
        Try
            Return ObtieneDatosTrans("SELECT c.NOMBRE FROM CATALOGO c WHERE c.CUENTA = '" & Cuenta & "' AND c.EMPRESA = " & EmpresaActual).Rows.Item(0)(0)
        Catch ex As Exception
            Return ""
        End Try
    End Function


    Public Shared Sub GuardarDistribucion(ByVal DT_Distribucion As DataTable,
                                          ByVal Fecha As Date,
                                          Optional ByVal Comprobante As String = vbNullString)

        Dim dbDistribucion As New db_Distribucion,
            objDistribucion As New Distribucion

        objDistribucion.IdEmpresa = EmpresaActual
        objDistribucion.NoComp = Comprobante
        objDistribucion.Mes = Fecha.Month
        objDistribucion.Per_Id = PeriodosDB.Activo(Fecha.Date)

        Dim DT_F As DataTable = DT_Distribucion
        If Not DT_F Is Nothing Then
            For i As Integer = 0 To DT_F.Rows.Count - 1
                With DT_F

                    objDistribucion.IdRubroGasto = .Rows(i).Item("IdRubroGasto")
                    objDistribucion.IdCentroCosto = .Rows(i).Item("IdCentroCosto")
                    objDistribucion.Valor = .Rows(i).Item("Valor")
                    objDistribucion.Tipo = .Rows(i).Item("Tipo")
                    objDistribucion.Cuenta = .Rows(i).Item("Cuenta")

                    dbDistribucion.Insertar(objDistribucion)

                    'GuardaDatos("INSERT INTO Distribucion(IdEmpresa,NoComp,Mes,Per_Id,IdRubroGasto,IdCentroCosto,Valor,Tipo,Cuenta) " &
                    ' " VALUES(" & EmpresaActual & "," & Comprobante & "," & Fecha.Month & "," &
                    'VB.SysContab.PeriodosDB.Activo(Fecha.Date) & "," & .Rows(i).Item("IdRubroGasto") & "," & .Rows(i).Item("IdCentroCosto") & "," & Math.Round(.Rows(i).Item("Valor"), 2) & ",'" & .Rows(i).Item("Tipo") & "','" & .Rows(i).Item("Cuenta") & "')")
                End With
            Next
        End If
    End Sub


    'Public Shared Function DT_Distribucion() As DataTable

    '    Dim DtResult As New DataTable
    '    Dim column As DataColumn
    '    Dim row As DataRow

    '    column = New DataColumn
    '    column.DataType = System.Type.GetType("System.Int32")
    '    column.ColumnName = "Mes"
    '    DtResult.Columns.Add(column)

    '    column = New DataColumn
    '    column.DataType = System.Type.GetType("System.Int32")
    '    column.ColumnName = "idRubroGasto"
    '    DtResult.Columns.Add(column)

    '    column = New DataColumn
    '    column.DataType = System.Type.GetType("System.Int32")
    '    column.ColumnName = "idCentroCosto"
    '    DtResult.Columns.Add(column)

    '    column = New DataColumn
    '    column.DataType = System.Type.GetType("System.Double")
    '    column.ColumnName = "Valor"
    '    DtResult.Columns.Add(column)

    '    column = New DataColumn
    '    column.DataType = System.Type.GetType("System.String")
    '    column.ColumnName = "Tipo"
    '    DtResult.Columns.Add(column)


    '    column = New DataColumn
    '    column.DataType = System.Type.GetType("System.String")
    '    column.ColumnName = "Cuenta"
    '    DtResult.Columns.Add(column)

    '    Return DtResult


    'End Function

    Private Sub ckbTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'If ckbTodos.Checked = True Then

        '    dgEstadoCuenta.ReadOnly = True
        '    Dim DS As New DataSet()

        '    If TipoFact = 1 Then
        '        DS = FactVentas.GetListContado(dtpFecha.Value, 1)
        '        Me.Text = "Comprobantes de Ventas de Contado"
        '    End If

        '    If TipoFact = 2 Then
        '        DS = FactVentas.GetListCredito(dtpFecha.Value, 1)
        '        Me.Text = "Comprobantes de Ventas de Crédito"
        '    End If

        '    dgEstadoCuenta.DataSource = DS.Tables("Tablas").DefaultView
        '    Tabla = DS.Tables("Tablas")

        '    'r.FormatGenerico(dgEstadoCuenta, Tabla)

        'Else

        '    dgEstadoCuenta.ReadOnly = True
        '    Dim DS As New DataSet()

        '    If TipoFact = 1 Then
        '        DS = FactVentas.GetListContado(dtpFecha.Value, 0)
        '        Me.Text = "Comprobantes de Ventas de Contado"
        '    End If

        '    If TipoFact = 2 Then
        '        DS = FactVentas.GetListCredito(dtpFecha.Value, 0)
        '        Me.Text = "Comprobantes de Ventas de Crédito"
        '    End If

        '    dgEstadoCuenta.DataSource = DS.Tables("Tablas").DefaultView
        '    Tabla = DS.Tables("Tablas")

        '    'r.FormatGenerico(dgEstadoCuenta, Tabla)
        'End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmExportarImprimir.Mostrar(gridDatos, lblTipo.Text)
        'If TipoFact = 1 Then
        '    Help.ShowHelp(Me, "Ayuda/Procesos/ProcesosContab.chm", HelpNavigator.KeywordIndex, "Sec1.1")
        'ElseIf TipoFact = 2 Then
        '    Help.ShowHelp(Me, "Ayuda/Procesos/ProcesosContab.chm", HelpNavigator.KeywordIndex, "Sec1.2")
        'End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Cargar()
    End Sub

    Sub Cargar()

        Dim Datos As New ArrayList
        Dim Variables As New ArrayList

        Variables.Add("Desde")
        Variables.Add("Hasta")
        Variables.Add("Caja")
        Variables.Add("Empresa")

        Datos.Add(Desde.DateTime.Date)
        Datos.Add(Hasta.DateTime.Date)
        Datos.Add(cbCajas.EditValue)
        Datos.Add(EmpresaActual)

        If TipoFact = 1 Then
            DT_VENTAS = ProcedureParameters(Datos, Variables, "_FacturasVentasGetListxFecha")
            Me.gridDatos.DataSource = DT_VENTAS
        ElseIf TipoFact = 2 Then
            DT_VENTAS = ProcedureParameters(Datos, Variables, "_FacturasVentasGetListxFechaCredito")
            Me.gridDatos.DataSource = DT_VENTAS
        End If

        Me.vDatos.PopulateColumns()
        FormatoGrid(Me.vDatos)
        '
        For i As Integer = 0 To Me.vDatos.Columns.Count - 1
            Me.vDatos.Columns(i).OptionsColumn.AllowEdit = False
        Next
        '
        Me.vDatos.Columns("Seleccionar").OptionsColumn.AllowEdit = True
        Me.vDatos.Columns("ClienteID").Visible = False
        Me.vDatos.Columns("CODIGO_BODEGA").Visible = False
        'Me.vDatos.Columns("CentroID").Visible = False
        Me.vDatos.Columns("CentroID").OptionsColumn.AllowEdit = True
        Me.vDatos.Columns("CentroID").Caption = "CENTRO COSTO"
        Me.vDatos.Columns("CentroID").ColumnEdit = cbCentros

        If TipoFact = 1 Then        'Contado
            Me.vDatos.Columns("CUENTA CAJA").Caption = "CUENTA CAJA"
        ElseIf TipoFact = 2 Then    'Credito
            Me.vDatos.Columns("CUENTA CAJA").Caption = "CUENTA CLIENTE"
        End If
        '
        Me.vDatos.Columns("MONTO").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("MONTO").DisplayFormat.FormatString = "{0:n2}"
        Me.vDatos.Columns("MONTO").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("MONTO").SummaryItem.DisplayFormat = "{0:n2}"

        Me.vDatos.Columns("DESCUENTO").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("DESCUENTO").DisplayFormat.FormatString = "{0:n2}"
        Me.vDatos.Columns("DESCUENTO").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("DESCUENTO").SummaryItem.DisplayFormat = "{0:n2}"

        Me.vDatos.Columns("SUBTOTAL").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("SUBTOTAL").DisplayFormat.FormatString = "{0:n2}"
        Me.vDatos.Columns("SUBTOTAL").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("SUBTOTAL").SummaryItem.DisplayFormat = "{0:n2}"

        Me.vDatos.Columns("IVA").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("IVA").DisplayFormat.FormatString = "{0:n2}"
        Me.vDatos.Columns("IVA").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("IVA").SummaryItem.DisplayFormat = "{0:n2}"

        Me.vDatos.Columns("TOTAL").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("TOTAL").DisplayFormat.FormatString = "{0:n2}"
        Me.vDatos.Columns("TOTAL").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("TOTAL").SummaryItem.DisplayFormat = "{0:n2}"
        '
        ' Me.vDatos.BestFitColumns()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        Try
            For i As Integer = 0 To Me.vDatos.DataRowCount - 1
                Me.vDatos.SetRowCellValue(i, "Seleccionar", Me.CheckEdit1.Checked)
            Next
            '
            Me.vDatos.RefreshData()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnDescarga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDescarga.Click
        frmDetalleVentasCostos.Dispose()
        '
        With frmDetalleVentasCostos
            .Desde = Desde.DateTime.Date
            .Hasta = Hasta.DateTime.Date
            .Caja = Me.cbCajas.EditValue
            .Tipo = TipoFact
            .Show()
            .lblTipo.Text = "DETALLE " & lblTipo.Text & ", Del: " & Desde.DateTime.ToShortDateString & " al: " & Hasta.DateTime.ToShortDateString
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub dgEstadoCuenta_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs)

    End Sub
End Class

