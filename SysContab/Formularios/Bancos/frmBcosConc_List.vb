Imports DevExpress.XtraGrid
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.Columns

Public Class frmBcosConc_List
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmBcosConc_List = Nothing

    Public Shared Function Instance() As frmBcosConc_List
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmBcosConc_List
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Vista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQuit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents frmBcosConc_ListConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents bImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbPeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnDetalle As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBcosConc_List))
        Me.dgDatos = New DevExpress.XtraGrid.GridControl()
        Me.Vista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.frmBcosConc_ListConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.cbPeriodo = New DevExpress.XtraEditors.LookUpEdit()
        Me.bEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.bBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.bImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnQuit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDetalle = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmBcosConc_ListConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmBcosConc_ListConvertedLayout.SuspendLayout()
        CType(Me.cbPeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgDatos
        '
        Me.dgDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDatos.Location = New System.Drawing.Point(12, 36)
        Me.dgDatos.MainView = Me.Vista
        Me.dgDatos.Name = "dgDatos"
        Me.dgDatos.Size = New System.Drawing.Size(723, 264)
        Me.dgDatos.TabIndex = 6
        Me.dgDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Vista})
        '
        'Vista
        '
        Me.Vista.GridControl = Me.dgDatos
        Me.Vista.Name = "Vista"
        Me.Vista.OptionsBehavior.Editable = False
        Me.Vista.OptionsView.ShowAutoFilterRow = True
        Me.Vista.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Vista.OptionsView.ShowFooter = True
        Me.Vista.OptionsView.ShowGroupPanel = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Options.UseTextOptions = True
        Me.btnNuevo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnNuevo.Enabled = False
        Me.btnNuevo.ImageOptions.Image = Global.SysContab.My.Resources.Resources.RibbonPrintPreview_PageOrientationPortrait
        Me.btnNuevo.Location = New System.Drawing.Point(12, 304)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(96, 38)
        Me.btnNuevo.StyleController = Me.frmBcosConc_ListConvertedLayout
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.ToolTip = "Cargar Datos"
        '
        'frmBcosConc_ListConvertedLayout
        '
        Me.frmBcosConc_ListConvertedLayout.Controls.Add(Me.cbPeriodo)
        Me.frmBcosConc_ListConvertedLayout.Controls.Add(Me.bEditar)
        Me.frmBcosConc_ListConvertedLayout.Controls.Add(Me.bBorrar)
        Me.frmBcosConc_ListConvertedLayout.Controls.Add(Me.bImprimir)
        Me.frmBcosConc_ListConvertedLayout.Controls.Add(Me.btnQuit)
        Me.frmBcosConc_ListConvertedLayout.Controls.Add(Me.btnExportar)
        Me.frmBcosConc_ListConvertedLayout.Controls.Add(Me.btnDetalle)
        Me.frmBcosConc_ListConvertedLayout.Controls.Add(Me.btnNuevo)
        Me.frmBcosConc_ListConvertedLayout.Controls.Add(Me.dgDatos)
        Me.frmBcosConc_ListConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmBcosConc_ListConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.frmBcosConc_ListConvertedLayout.Name = "frmBcosConc_ListConvertedLayout"
        Me.frmBcosConc_ListConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(915, 197, 250, 350)
        Me.frmBcosConc_ListConvertedLayout.Root = Me.LayoutControlGroup1
        Me.frmBcosConc_ListConvertedLayout.Size = New System.Drawing.Size(747, 354)
        Me.frmBcosConc_ListConvertedLayout.TabIndex = 8
        '
        'cbPeriodo
        '
        Me.cbPeriodo.Location = New System.Drawing.Point(55, 12)
        Me.cbPeriodo.Name = "cbPeriodo"
        Me.cbPeriodo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPeriodo.Properties.Appearance.Options.UseFont = True
        Me.cbPeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPeriodo.Properties.NullText = "[Seleccione Periodo Contable]"
        Me.cbPeriodo.Properties.ShowFooter = False
        Me.cbPeriodo.Properties.ShowHeader = False
        Me.cbPeriodo.Size = New System.Drawing.Size(680, 20)
        Me.cbPeriodo.StyleController = Me.frmBcosConc_ListConvertedLayout
        Me.cbPeriodo.TabIndex = 175
        '
        'bEditar
        '
        Me.bEditar.Appearance.Options.UseTextOptions = True
        Me.bEditar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bEditar.Enabled = False
        Me.bEditar.ImageOptions.Image = CType(resources.GetObject("bEditar.ImageOptions.Image"), System.Drawing.Image)
        Me.bEditar.Location = New System.Drawing.Point(112, 304)
        Me.bEditar.Name = "bEditar"
        Me.bEditar.Size = New System.Drawing.Size(96, 38)
        Me.bEditar.StyleController = Me.frmBcosConc_ListConvertedLayout
        Me.bEditar.TabIndex = 9
        Me.bEditar.Text = "&Editar"
        Me.bEditar.ToolTip = "Cargar Datos"
        '
        'bBorrar
        '
        Me.bBorrar.Appearance.Options.UseTextOptions = True
        Me.bBorrar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bBorrar.Enabled = False
        Me.bBorrar.ImageOptions.Image = CType(resources.GetObject("bBorrar.ImageOptions.Image"), System.Drawing.Image)
        Me.bBorrar.Location = New System.Drawing.Point(421, 304)
        Me.bBorrar.Name = "bBorrar"
        Me.bBorrar.Size = New System.Drawing.Size(96, 38)
        Me.bBorrar.StyleController = Me.frmBcosConc_ListConvertedLayout
        Me.bBorrar.TabIndex = 9
        Me.bBorrar.Text = "&Anular"
        '
        'bImprimir
        '
        Me.bImprimir.Appearance.Options.UseTextOptions = True
        Me.bImprimir.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bImprimir.Enabled = False
        Me.bImprimir.ImageOptions.Image = CType(resources.GetObject("bImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.bImprimir.Location = New System.Drawing.Point(321, 304)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(96, 38)
        Me.bImprimir.StyleController = Me.frmBcosConc_ListConvertedLayout
        Me.bImprimir.TabIndex = 9
        Me.bImprimir.Text = "&Imprimir"
        Me.bImprimir.ToolTip = "Imprimir Conciliación"
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.Appearance.Options.UseTextOptions = True
        Me.btnQuit.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnQuit.ImageOptions.Image = CType(resources.GetObject("btnQuit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnQuit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnQuit.Location = New System.Drawing.Point(640, 304)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(95, 38)
        Me.btnQuit.StyleController = Me.frmBcosConc_ListConvertedLayout
        Me.btnQuit.TabIndex = 6
        Me.btnQuit.Text = "&Salir"
        '
        'btnExportar
        '
        Me.btnExportar.Appearance.Options.UseTextOptions = True
        Me.btnExportar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnExportar.Enabled = False
        Me.btnExportar.ImageOptions.Image = CType(resources.GetObject("btnExportar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExportar.Location = New System.Drawing.Point(541, 304)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(95, 38)
        Me.btnExportar.StyleController = Me.frmBcosConc_ListConvertedLayout
        Me.btnExportar.TabIndex = 1
        Me.btnExportar.Text = "&Exportar"
        '
        'btnDetalle
        '
        Me.btnDetalle.Appearance.Options.UseTextOptions = True
        Me.btnDetalle.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnDetalle.Enabled = False
        Me.btnDetalle.ImageOptions.Image = CType(resources.GetObject("btnDetalle.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDetalle.Location = New System.Drawing.Point(212, 304)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.Size = New System.Drawing.Size(105, 38)
        Me.btnDetalle.StyleController = Me.frmBcosConc_ListConvertedLayout
        Me.btnDetalle.TabIndex = 2
        Me.btnDetalle.Text = "&Ver Detalle"
        Me.btnDetalle.ToolTip = "Ver Formato para Importar Datos"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem6, Me.LayoutControlItem1, Me.LayoutControlItem7, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem5, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(747, 354)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.dgDatos
        Me.LayoutControlItem2.CustomizationFormText = "dgDatositem"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "dgDatositem"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(727, 268)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.btnNuevo
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 292)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.btnDetalle
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(200, 292)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(109, 42)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(109, 42)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(109, 42)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.btnQuit
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(628, 292)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.bImprimir
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(309, 292)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.bBorrar
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(409, 292)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.bEditar
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(100, 292)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cbPeriodo
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(727, 24)
        Me.LayoutControlItem10.Text = "Periodo:"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(40, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.btnExportar
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(529, 292)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(509, 292)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(20, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.btnNuevo
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 292)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(94, 42)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(94, 42)
        Me.LayoutControlItem8.Name = "LayoutControlItem3"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(94, 42)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'frmBcosConc_List
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(747, 354)
        Me.Controls.Add(Me.frmBcosConc_ListConvertedLayout)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Blue"
        Me.Name = "frmBcosConc_List"
        Me.Text = "Conciliación Bancaria"
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmBcosConc_ListConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmBcosConc_ListConvertedLayout.ResumeLayout(False)
        CType(Me.cbPeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim DT_ROL As DataTable = Nothing

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        frmExportarImprimir.Mostrar(dgDatos)
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim f2 As frmBcosConc = frmBcosConc.Instance()
        f2.Dispose()
        ''
        Dim f As frmBcosConc = frmBcosConc.Instance()
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmBcosConc_List_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DT_ROL = RolesDB.UsuarioAcciones(frmBcosConc_ListConvertedLayout)

        CargarPeriodo()
        Cargar()
        Grid()
    End Sub

    Sub Grid()
        Vista.PopulateColumns()
        FormatoGrid(Vista)

        Vista.Columns("Per_id").Visible = False
        Vista.Columns("cb_banco").Visible = False
        Vista.Columns("CUENTA").Visible = False
        Vista.Columns("BANCO").Width = 150


        Dim columnCustomer As GridColumn = Vista.Columns("ANULADA")
        columnCustomer.FilterInfo = New ColumnFilterInfo("[ANULADA] = 'False'")


        'Me.Vista.Columns("BANCO").BestFit()
        'Me.Vista.Columns("SALDO A/BANCO").BestFit()
        'Me.Vista.Columns("DEBITO BANCO").BestFit()
        'Me.Vista.Columns("CREDITO BANCO").BestFit()
        'Me.Vista.Columns("SALDO ANTERIOR").BestFit()

        'Me.Vista.Columns("SALDO A/BANCO").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.Vista.Columns("SALDO A/BANCO").DisplayFormat.FormatString = "n2"
        'Me.Vista.Columns("SALDO A/BANCO").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.Vista.Columns("SALDO A/BANCO").SummaryItem.DisplayFormat = "{0:n2}"

        'Me.Vista.Columns("DEBITO BANCO").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.Vista.Columns("DEBITO BANCO").DisplayFormat.FormatString = "n2"
        'Me.Vista.Columns("DEBITO BANCO").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.Vista.Columns("DEBITO BANCO").SummaryItem.DisplayFormat = "{0:n2}"

        'Me.Vista.Columns("CREDITO BANCO").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.Vista.Columns("CREDITO BANCO").DisplayFormat.FormatString = "n2"
        'Me.Vista.Columns("CREDITO BANCO").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.Vista.Columns("CREDITO BANCO").SummaryItem.DisplayFormat = "{0:n2}"

        'Me.Vista.Columns("SALDO BANCO").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.Vista.Columns("SALDO BANCO").DisplayFormat.FormatString = "n2"
        'Me.Vista.Columns("SALDO BANCO").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.Vista.Columns("SALDO BANCO").SummaryItem.DisplayFormat = "{0:n2}"

        'Me.Vista.Columns("SALDO ANTERIOR").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.Vista.Columns("SALDO ANTERIOR").DisplayFormat.FormatString = "n2"
        'Me.Vista.Columns("SALDO ANTERIOR").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.Vista.Columns("SALDO ANTERIOR").SummaryItem.DisplayFormat = "{0:n2}"

        'Me.Vista.Columns("DEBITOS").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.Vista.Columns("DEBITOS").DisplayFormat.FormatString = "n2"
        'Me.Vista.Columns("DEBITOS").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.Vista.Columns("DEBITOS").SummaryItem.DisplayFormat = "{0:n2}"

        'Me.Vista.Columns("CREDITOS").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.Vista.Columns("CREDITOS").DisplayFormat.FormatString = "n2"
        'Me.Vista.Columns("CREDITOS").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.Vista.Columns("CREDITOS").SummaryItem.DisplayFormat = "{0:n2}"

        'Me.Vista.Columns("SALDO").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.Vista.Columns("SALDO").DisplayFormat.FormatString = "n2"
        'Me.Vista.Columns("SALDO").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.Vista.Columns("SALDO").SummaryItem.DisplayFormat = "{0:n2}"
    End Sub

    Sub CargarPeriodo()
        LookUp(cbPeriodo, VB.SysContab.PeriodosDB.GetList().Tables("Periodos"), "descripcion", "codigo", "[Seleccione Periodo]", 0, 2, 3, 4, 5)
        'Seleccionar Periodo Actual
        Dim Per_Id As Integer = VB.SysContab.PeriodosDB.Actual
        If Per_Id <> 0 Then cbPeriodo.EditValue = Per_Id
    End Sub

    Public Sub Cargar()
        dgDatos.DataSource = ObtieneDatos("_GetBcosConc_List", EmpresaActual, cbPeriodo.EditValue).DefaultView
        ValidarEditar()
    End Sub

    Private Sub Vista_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vista.DoubleClick
        VerDetalle()
    End Sub

    Private Sub btnDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalle.Click
        VerDetalle()
    End Sub

    Sub VerDetalle()
        If Me.Vista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
            Exit Sub
        End If

        Dim f As New frmBcosConc_Detalle
        f.LayoutControlGroup2.Text = "CONCILIACION BANCARIA # " & Me.Vista.GetFocusedRowCellValue("CODIGO") & " - " & Me.Vista.GetFocusedRowCellValue("BANCO")
        f.Codigo = Vista.GetFocusedRowCellValue("CODIGO")
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub bImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bImprimir.Click
        If Me.Vista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
            Exit Sub
        End If

        ShowSplash("Imprimiendo...")
        '
        Dim rpt As New rptConciliacionBancaria
        Dim rptSub As New rptNoConciliadoDetalle

        rptSub.DataSource = ObtieneDatos("JAR_GetConciliacionImpresa '" & Vista.GetFocusedRowCellValue("CODIGO") & "',1," & EmpresaActual)
        'rpt.DataSource = ObtieneDatos("JAR_GetConciliacionImpresa '" & Vista.GetFocusedRowCellValue("CODIGO") & "',0," & EmpresaActual)
        rpt.Periodo.Text = "Desde : " & CDate(Vista.GetFocusedRowCellValue("DESDE")).Date & " Hasta : " & CDate(Vista.GetFocusedRowCellValue("HASTA")).Date
        rpt.XrSubreport1.ReportSource = rptSub

        VistaPreviaDX(rpt,
                    ObtieneDatos("JAR_GetConciliacionImpresa", Vista.GetFocusedRowCellValue("CODIGO"), 0, EmpresaActual),
                    "Conciliación Bancaria No. " & Vista.GetFocusedRowCellValue("CODIGO"))
        '
        HideSplash()

        'rpt.ShowPrintMarginsWarning = False
        'rpt.BringToFront()
        'rpt.ShowRibbonPreview()
    End Sub

    Private Sub bBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bBorrar.Click
        If Me.Vista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
            Exit Sub
        End If
        '
        If Not XtraMsg2("Esta Seguro de Anular la Conciliación Bancaria #: " & Vista.GetFocusedRowCellValue("CODIGO") & vbCrLf & _
                    "Este proceso no se puede revertir. Confirmar Operación?") Then
            Exit Sub
        End If
        '
        Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())

        Try
            Conn.IniciarTransaccion()
            '
            Conn.RemoveParameters()
            Conn.AddParameter("Codigo", SqlDbType.NVarChar, 50, ParameterDirection.Input, Vista.GetFocusedRowCellValue("CODIGO"))
            Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)

            Conn.EjecutarComando("JAR_AnularConciliacion")
            Conn.CompletarTransaccion()

            XtraMsg("La Conciliación Bancaria #: " & Vista.GetFocusedRowCellValue("CODIGO") & " ha sido Anulada con Exito!")
            Cargar()
        Catch ex As Exception
            Conn.AnularTransaccion()
            XtraMsg("ERROR: " & ex.Message, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bEditar_Click(sender As Object, e As EventArgs) Handles bEditar.Click
        If Vista.FocusedRowHandle < 0 Then Exit Sub

        If Vista.GetFocusedRowCellValue("ANULADA") Then
            XtraMsg("La Conciliacion Bancaria #: " & Vista.GetFocusedRowCellValue("CODIGO") & " se encuentra Anulada, no es posible ser Editada...", MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Vista.GetFocusedRowCellValue("CERRADA") Then
            XtraMsg("La Conciliacion Bancaria #: " & Vista.GetFocusedRowCellValue("CODIGO") & " se encuentra Cerrada, no es posible ser Editada...", MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim f2 As frmBcosConc = frmBcosConc.Instance()
        f2.Dispose()
        ''
        Dim f As frmBcosConc = frmBcosConc.Instance()
        f.MdiParent = Me.MdiParent
        f.IdConciliacion = Vista.GetFocusedRowCellValue("CODIGO")
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Vista_FocusedRowChanged(sender As Object, e As Views.Base.FocusedRowChangedEventArgs) Handles Vista.FocusedRowChanged
        ValidarEditar()
    End Sub

    Sub ValidarEditar()
        If DT_ROL.Rows.Count > 0 Then

            'Verificiar si el usuario tiene el Rol de Editar
            Dim dr() As DataRow = DT_ROL.Select("Control = 'bEditar'")

            If dr.Length > 0 Then
                If Vista.FocusedRowHandle < 0 Then Exit Sub
                bEditar.Enabled = Not Vista.GetFocusedRowCellValue("CERRADA")
            End If
            
        End If
    End Sub

    Private Sub Vista_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles Vista.RowCellStyle
        If e.Column.FieldName = "ANULADA" Then
            If Vista.GetRowCellValue(e.RowHandle, "ANULADA") Then e.Appearance.BackColor = Color.Salmon        
        End If

        If e.Column.FieldName = "CERRADA" Then            
            If Not Vista.GetRowCellValue(e.RowHandle, "CERRADA") Then e.Appearance.BackColor = Color.YellowGreen
        End If
    End Sub

    Private Sub cbPeriodo_EditValueChanged(sender As Object, e As EventArgs) Handles cbPeriodo.EditValueChanged
        If Not Inicio Then
            ShowSplash()
            Cargar()
            HideSplash()
        End If
    End Sub

    Private Sub frmBcosConc_List_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            ShowSplash()
            Cargar()
            HideSplash()
        End If
    End Sub
End Class

