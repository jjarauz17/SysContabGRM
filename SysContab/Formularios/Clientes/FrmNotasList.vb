Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.Configuration
Imports DevExpress.XtraReports.UI
Imports ClasesBLL
Imports SysContab.VB.SysContab
Imports Newtonsoft.Json
Imports DevExpress.XtraGrid.Views.Grid

Public Class FrmNotasList
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As FrmNotasList = Nothing

    Public Shared Function Instance() As FrmNotasList
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmNotasList
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
    Friend WithEvents GridDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents vNotas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdnuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdanular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
    Friend WithEvents FrmNotasListConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents Hasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Desde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents bDiseno As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bTipoNC As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bDevolucionE As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdver As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNotasList))
        Me.GridDetalle = New DevExpress.XtraGrid.GridControl()
        Me.vNotas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdnuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.FrmNotasListConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.bDevolucionE = New DevExpress.XtraEditors.SimpleButton()
        Me.bTipoNC = New DevExpress.XtraEditors.SimpleButton()
        Me.bDiseno = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Hasta = New DevExpress.XtraEditors.DateEdit()
        Me.Desde = New DevExpress.XtraEditors.DateEdit()
        Me.cmdsalir = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdver = New DevExpress.XtraEditors.SimpleButton()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdanular = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrmNotasListConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrmNotasListConvertedLayout.SuspendLayout()
        CType(Me.Hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Desde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Desde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridDetalle
        '
        Me.GridDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDetalle.Location = New System.Drawing.Point(12, 62)
        Me.GridDetalle.MainView = Me.vNotas
        Me.GridDetalle.Name = "GridDetalle"
        Me.GridDetalle.Size = New System.Drawing.Size(1060, 367)
        Me.GridDetalle.TabIndex = 0
        Me.GridDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vNotas})
        '
        'vNotas
        '
        Me.vNotas.GridControl = Me.GridDetalle
        Me.vNotas.GroupPanelText = "Arrastre para Agrupar"
        Me.vNotas.Name = "vNotas"
        Me.vNotas.OptionsBehavior.Editable = False
        Me.vNotas.OptionsView.ShowAutoFilterRow = True
        Me.vNotas.OptionsView.ShowFooter = True
        Me.vNotas.OptionsView.ShowGroupPanel = False
        '
        'cmdnuevo
        '
        Me.cmdnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdnuevo.Enabled = False
        Me.cmdnuevo.ImageOptions.Image = CType(resources.GetObject("cmdnuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdnuevo.Location = New System.Drawing.Point(12, 433)
        Me.cmdnuevo.Name = "cmdnuevo"
        Me.cmdnuevo.Size = New System.Drawing.Size(97, 38)
        Me.cmdnuevo.StyleController = Me.FrmNotasListConvertedLayout
        Me.cmdnuevo.TabIndex = 1
        Me.cmdnuevo.Text = "&Nueva"
        '
        'FrmNotasListConvertedLayout
        '
        Me.FrmNotasListConvertedLayout.Controls.Add(Me.bDevolucionE)
        Me.FrmNotasListConvertedLayout.Controls.Add(Me.bTipoNC)
        Me.FrmNotasListConvertedLayout.Controls.Add(Me.bDiseno)
        Me.FrmNotasListConvertedLayout.Controls.Add(Me.SimpleButton2)
        Me.FrmNotasListConvertedLayout.Controls.Add(Me.Hasta)
        Me.FrmNotasListConvertedLayout.Controls.Add(Me.Desde)
        Me.FrmNotasListConvertedLayout.Controls.Add(Me.cmdsalir)
        Me.FrmNotasListConvertedLayout.Controls.Add(Me.SimpleButton1)
        Me.FrmNotasListConvertedLayout.Controls.Add(Me.btnBorrar)
        Me.FrmNotasListConvertedLayout.Controls.Add(Me.cmdver)
        Me.FrmNotasListConvertedLayout.Controls.Add(Me.btnImprimir)
        Me.FrmNotasListConvertedLayout.Controls.Add(Me.cmdanular)
        Me.FrmNotasListConvertedLayout.Controls.Add(Me.cmdnuevo)
        Me.FrmNotasListConvertedLayout.Controls.Add(Me.GridDetalle)
        Me.FrmNotasListConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmNotasListConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.FrmNotasListConvertedLayout.Name = "FrmNotasListConvertedLayout"
        Me.FrmNotasListConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(844, 100, 250, 350)
        Me.FrmNotasListConvertedLayout.Root = Me.LayoutControlGroup1
        Me.FrmNotasListConvertedLayout.Size = New System.Drawing.Size(1084, 483)
        Me.FrmNotasListConvertedLayout.TabIndex = 5
        '
        'bDevolucionE
        '
        Me.bDevolucionE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bDevolucionE.Appearance.Options.UseTextOptions = True
        Me.bDevolucionE.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bDevolucionE.Enabled = False
        Me.bDevolucionE.ImageOptions.Image = CType(resources.GetObject("bDevolucionE.ImageOptions.Image"), System.Drawing.Image)
        Me.bDevolucionE.Location = New System.Drawing.Point(311, 433)
        Me.bDevolucionE.Name = "bDevolucionE"
        Me.bDevolucionE.Size = New System.Drawing.Size(108, 38)
        Me.bDevolucionE.StyleController = Me.FrmNotasListConvertedLayout
        Me.bDevolucionE.TabIndex = 6
        Me.bDevolucionE.Text = "&Notas ND/CD" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Electrónica"
        '
        'bTipoNC
        '
        Me.bTipoNC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bTipoNC.Appearance.Options.UseTextOptions = True
        Me.bTipoNC.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bTipoNC.Enabled = False
        Me.bTipoNC.ImageOptions.Image = CType(resources.GetObject("bTipoNC.ImageOptions.Image"), System.Drawing.Image)
        Me.bTipoNC.Location = New System.Drawing.Point(679, 433)
        Me.bTipoNC.Name = "bTipoNC"
        Me.bTipoNC.Size = New System.Drawing.Size(103, 38)
        Me.bTipoNC.StyleController = Me.FrmNotasListConvertedLayout
        Me.bTipoNC.TabIndex = 6
        Me.bTipoNC.Text = "&Tipos de NC"
        '
        'bDiseno
        '
        Me.bDiseno.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bDiseno.Appearance.Options.UseTextOptions = True
        Me.bDiseno.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bDiseno.Enabled = False
        Me.bDiseno.ImageOptions.Image = CType(resources.GetObject("bDiseno.ImageOptions.Image"), System.Drawing.Image)
        Me.bDiseno.Location = New System.Drawing.Point(786, 433)
        Me.bDiseno.Name = "bDiseno"
        Me.bDiseno.Size = New System.Drawing.Size(95, 38)
        Me.bDiseno.StyleController = Me.FrmNotasListConvertedLayout
        Me.bDiseno.TabIndex = 6
        Me.bDiseno.Text = "&Diseño de Impresión"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(168, 36)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(89, 22)
        Me.SimpleButton2.StyleController = Me.FrmNotasListConvertedLayout
        Me.SimpleButton2.TabIndex = 6
        Me.SimpleButton2.Text = "&Buscar"
        '
        'Hasta
        '
        Me.Hasta.EditValue = Nothing
        Me.Hasta.Location = New System.Drawing.Point(49, 36)
        Me.Hasta.Name = "Hasta"
        Me.Hasta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hasta.Properties.Appearance.Options.UseFont = True
        Me.Hasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Hasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Hasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.Hasta.Size = New System.Drawing.Size(115, 20)
        Me.Hasta.StyleController = Me.FrmNotasListConvertedLayout
        Me.Hasta.TabIndex = 5
        '
        'Desde
        '
        Me.Desde.EditValue = Nothing
        Me.Desde.Location = New System.Drawing.Point(49, 12)
        Me.Desde.Name = "Desde"
        Me.Desde.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desde.Properties.Appearance.Options.UseFont = True
        Me.Desde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Desde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Desde.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.Desde.Size = New System.Drawing.Size(115, 20)
        Me.Desde.StyleController = Me.FrmNotasListConvertedLayout
        Me.Desde.TabIndex = 4
        '
        'cmdsalir
        '
        Me.cmdsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdsalir.ImageOptions.Image = CType(resources.GetObject("cmdsalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdsalir.Location = New System.Drawing.Point(984, 433)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(88, 38)
        Me.cmdsalir.StyleController = Me.FrmNotasListConvertedLayout
        Me.cmdsalir.TabIndex = 1
        Me.cmdsalir.Text = "&Salir"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Enabled = False
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(885, 433)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(95, 38)
        Me.SimpleButton1.StyleController = Me.FrmNotasListConvertedLayout
        Me.SimpleButton1.TabIndex = 3
        Me.SimpleButton1.Text = "&Exportar"
        '
        'btnBorrar
        '
        Me.btnBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBorrar.Enabled = False
        Me.btnBorrar.ImageOptions.Image = CType(resources.GetObject("btnBorrar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBorrar.Location = New System.Drawing.Point(515, 433)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(91, 38)
        Me.btnBorrar.StyleController = Me.FrmNotasListConvertedLayout
        Me.btnBorrar.TabIndex = 2
        Me.btnBorrar.Text = "&Borrar"
        '
        'cmdver
        '
        Me.cmdver.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdver.ImageOptions.Image = CType(resources.GetObject("cmdver.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdver.Location = New System.Drawing.Point(113, 433)
        Me.cmdver.Name = "cmdver"
        Me.cmdver.Size = New System.Drawing.Size(95, 38)
        Me.cmdver.StyleController = Me.FrmNotasListConvertedLayout
        Me.cmdver.TabIndex = 1
        Me.cmdver.Text = "&Ver Nota"
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Enabled = False
        Me.btnImprimir.ImageOptions.Image = CType(resources.GetObject("btnImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(212, 433)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(95, 38)
        Me.btnImprimir.StyleController = Me.FrmNotasListConvertedLayout
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "&Imprimir"
        '
        'cmdanular
        '
        Me.cmdanular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdanular.Enabled = False
        Me.cmdanular.ImageOptions.Image = CType(resources.GetObject("cmdanular.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdanular.Location = New System.Drawing.Point(423, 433)
        Me.cmdanular.Name = "cmdanular"
        Me.cmdanular.Size = New System.Drawing.Size(88, 38)
        Me.cmdanular.StyleController = Me.FrmNotasListConvertedLayout
        Me.cmdanular.TabIndex = 1
        Me.cmdanular.Text = "&Anular"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.EmptySpaceItem1, Me.LayoutControlItem1, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.LayoutControlItem12, Me.LayoutControlItem7, Me.LayoutControlItem13, Me.LayoutControlItem14})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1084, 483)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.GridDetalle
        Me.LayoutControlItem2.CustomizationFormText = "GridDetalleitem"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem2.Name = "GridDetalleitem"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1064, 371)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmdnuevo
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 421)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(101, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(101, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(101, 42)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmdver
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(101, 421)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmdanular
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(411, 421)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(92, 42)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(92, 42)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(92, 42)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.btnBorrar
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(503, 421)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.SimpleButton1
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(873, 421)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmdsalir
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(972, 421)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(92, 42)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(92, 42)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(92, 42)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(598, 421)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(69, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Desde
        Me.LayoutControlItem1.CustomizationFormText = "Desde:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(156, 24)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(156, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(156, 24)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Desde:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(34, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.Hasta
        Me.LayoutControlItem10.CustomizationFormText = "Hasta:"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(156, 26)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(156, 26)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(156, 26)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.Text = "Hasta:"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(34, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.SimpleButton2
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(156, 24)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(93, 26)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(93, 26)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(93, 26)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(249, 24)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(815, 26)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(156, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(908, 24)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.bDiseno
        Me.LayoutControlItem12.Location = New System.Drawing.Point(774, 421)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.btnImprimir
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(200, 421)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.bTipoNC
        Me.LayoutControlItem13.Location = New System.Drawing.Point(667, 421)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(107, 42)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(107, 42)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(107, 42)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.bDevolucionE
        Me.LayoutControlItem14.Location = New System.Drawing.Point(299, 421)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'FrmNotasList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1084, 483)
        Me.Controls.Add(Me.FrmNotasListConvertedLayout)
        Me.Name = "FrmNotasList"
        Me.Text = "Lista de Notas"
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vNotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrmNotasListConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrmNotasListConvertedLayout.ResumeLayout(False)
        CType(Me.Hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Desde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Desde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsalir.Click
        Close()
    End Sub

    Private Sub cmdnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnuevo.Click
        Inicio = True
        ShowSplash()
        Dim f As FrmNotasCreditoDebitoNew = FrmNotasCreditoDebitoNew.Instance()
        f.Dispose()
        '
        Dim Forma As FrmNotasCreditoDebitoNew = FrmNotasCreditoDebitoNew.Instance()
        Forma.MdiParent = Me.MdiParent
        Forma.Show()
        Forma.Text = "Nueva Nota D/C"
        Forma.WindowState = FormWindowState.Maximized
        HideSplash()
        Inicio = False
    End Sub

    Private Sub cmdlista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If Me.vNotas.FocusedRowHandle < 0 Then Exit Sub

        'Imprimir Nota de Credito Electronica
        If EmpresaActual.Equals("18") Then
            If vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "ATV") = "aceptado" Then
                Dim _dt As DataTable = Facturas_VentasDB.MensajeRechazo(
                    "aceptado",
                    vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "NoNota"),
                    "03")

                If _dt.Rows.Count > 0 Then
                    Dim api As HaciendaGT.ResponseApi =
                    JsonConvert.DeserializeObject(Of HaciendaGT.ResponseApi)(_dt.Rows.Item(0)("MensajeHacienda"))

                    Dim sLink As String = $"{_dt.Rows.Item(0)("Link")}{api.uuid}"

                    Process.Start(sLink)
                End If
            End If
        End If
            '
            Facturas_VentasDB.DevolucionImprimir(
             vNotas.GetFocusedRowCellValue("IdNota"),
             vNotas.GetFocusedRowCellValue("NoNota"),
             vNotas.GetFocusedRowCellValue("Tipo").ToString.Substring(0, 1),
             vNotas.GetFocusedRowCellValue("Monto"))




        'ShowSplash("Imprimiendo...")

        ''Dim Temp As Boolean = False

        ''Try
        ''    Dim Data() As Byte = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 6 And Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())
        ''    Temp = True
        ''    Dim Tamano As Integer = Data.GetUpperBound(0)
        ''    Dim Cadena As String = Application.StartupPath & "\rptNotaDC.repx"
        ''    If File.Exists(Cadena) Then Kill(Cadena)
        ''    Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
        ''    Archivo.Write(Data, 0, Tamano)
        ''    Archivo.Close()
        ''    Temp = True
        ''Catch ex As Exception
        ''    Temp = False
        ''End Try
        ''

        'Dim Temp As Boolean = db_Formatos.FormatoImpreso(
        '    6,
        '    "rptNotaDC")

        'Dim rpt As rptNotasProveedores

        'If Temp = True Then
        '    rpt = XtraReport.FromFile(Application.StartupPath & "\rptNotaDC.repx", True)
        'Else
        '    rpt = New rptNotasProveedores
        'End If
        ''
        'Dim DT_NDC As DataTable = ObtieneDatos("JAR_NotaClienteImprimir",
        '                                       vNotas.GetFocusedRowCellValue("IdNota"),
        '                                        vNotas.GetFocusedRowCellValue("Tipo").ToString.Substring(0, 1),
        '                                        VB.SysContab.Rutinas.Letras(vNotas.GetFocusedRowCellValue("Monto")),
        '                                        EmpresaActual)

        'VistaPreviaDX(
        '    rpt,
        '    DT_NDC,
        '    "NOTA DE " & vNotas.GetFocusedRowCellValue("Tipo").ToString() &
        '    " NO. " &
        '    vNotas.GetFocusedRowCellValue("NoNota"))
        'HideSplash()




        'rpt.ShowPrintMarginsWarning = False
        'rpt.BringToFront()
        'HideSplash()
        'rpt.ShowRibbonPreview()
    End Sub

    Private Sub FrmNotasList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(FrmNotasListConvertedLayout)

        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date

        Desde.DateTime = New DateTime(f.Year, f.Month, 1).Date
        Hasta.DateTime = f.Date

        GetData()

        vNotas.PopulateColumns()
        FormatoGrid(vNotas)

        vNotas.Columns("IdNota").Visible = False
        vNotas.Columns("Comp_No").Visible = False
        vNotas.Columns("Per_Id").Visible = False
        vNotas.Columns("Mes").Visible = False
        '
        vNotas.Columns("Monto").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        vNotas.Columns("Monto").DisplayFormat.FormatString = "n2"
        vNotas.Columns("Monto").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        vNotas.Columns("Monto").SummaryItem.DisplayFormat = "{0:n2}"
    End Sub

    Private Sub GetData()
        GridDetalle.DataSource = ObtieneDatos("SPGetNotas",
                                              0,
                                              EmpresaActual,
                                              1,
                                              Desde.DateTime.Date,
                                              Hasta.DateTime.Date)
    End Sub

    Private Sub FrmNotasList_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        ''GetData()
    End Sub

    Private Sub FrmNotasList_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        ' GetData()
    End Sub

    Private Sub cmdanular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdanular.Click

        If vNotas.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro")
            Exit Sub
        End If
        '
        If Not VerificarCierre(CDate(vNotas.GetFocusedRowCellValue("Fecha")).Date) Then
            Exit Sub
        End If
        '
        If vNotas.GetFocusedRowCellValue("Estado").ToString().Equals("ANULADA") Then
            XtraMsg($"La NOTA DE {vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "Tipo")} ya se encuentra ANULADA", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If ObtieneDatos("JAR_GetRecibosxFactura",
                        vNotas.GetFocusedRowCellValue("NoNota"),
                        EmpresaActual).Rows.Count > 0 Then
            XtraMsg("La Nota de Débito Contiene Pagos, NO SE PUEDE ANULAR!!!", MessageBoxIcon.Error)

            With frmRecibosxFactura

                .Titulo.Text = "La Nota de Débito Contiene los siguientes Pagos." '' & vbCrLf & "Anular de todas formas?"
                .Cliente.Text = "CLIENTE: " & vNotas.GetFocusedRowCellValue("Cliente")
                .Factura = vNotas.GetFocusedRowCellValue("NoNota")
                .ShowDialog()

                If .OK = "NO" Then
                    .Dispose()
                    Exit Sub
                End If

                .Dispose()
            End With

            Exit Sub
        End If
        '
        If ObtieneDatos("sp_sel_COBROS_NCD",
                        vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "NoNota"),
                        EmpresaActual) _
                        .Rows _
                        .Count > 0 Then
            XtraMsg("Esta nota contiene registros de pagos, no puede anularla",
                    MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If Facturas_VentasDB.BuscarDevolucionNC(
            vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "IdNota")) _
            .Rows _
            .Count > 0 Then

            XtraMsg("La N/C es parte de una Devolución, no se puede anular desde este módulo.",
                    MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "No.Electronico") _
            .ToString().Length < 10 Then
            XtraMsg("La Devolución es una Nota de Crédito Electrónica, no puede ser Borrada",
                    MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If CBool(vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "NC_Electrónica")) Then
            XtraMsg("La Nota de Crédito es Electrónica, no puede ser Anulada", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        'Verificar si el Comprobante Contiene cuentas de Ingreso y si el Mes ya esta declarado RAMAC
        If ObtieneDatos("sp_ValidarIngresosBOLNASA", vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "Comp_No"),
                        vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "Per_Id"),
                        vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "Mes"),
                        EmpresaActual).Rows.Count > 0 Then

            'Verificar Cierre de Bolsa
            If CDate(vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "Fecha")).Date <= db_FACTURAS_BOLSA.UltimoCierre().Date Then
                XtraMsg("La Nota No: " & vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "NoNota") & " ya fue reportada en BOLSA AGROPECUARIA, " & vbCrLf &
                    "Ultima fecha reportada al:  " & db_FACTURAS_BOLSA.UltimoCierre().Date.ToShortDateString, MessageBoxIcon.Error)
                Exit Sub
            End If
            '*******************************************************************************************
        End If

        If XtraMsg2("Desea Anular la Nota#: " &
                    vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "NoNota")) Then
            If Guardar("SPAnulaNota",
                       vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "IdNota")) Then GetData()  'ObtieneDatos("SPAnulaNota '" & vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "IdNota") & "'") Then
        End If
    End Sub

    Private Sub cmdver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdver.Click
        If vNotas.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro")
            Exit Sub
        End If

        frmNotasDetalle.IdNota = vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "IdNota")
        frmNotasDetalle.TipoDC = vNotas.GetFocusedRowCellValue("Tipo").ToString.Substring(0, 1)
        frmNotasDetalle.ShowDialog()
        frmNotasDetalle.Dispose()

        'Dim Forma As FrmNotasCreditoDebitoNew = FrmNotasCreditoDebitoNew.Instance
        'Forma.MdiParent = Me.MdiParent
        'Forma.Nota = GridView1.GetFocusedRowCellValue("IdNota")
        ''Forma.Size = New Size(760, 288)
        'Forma.Show()
        'Forma.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        If vNotas.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro")
            Exit Sub
        End If
        '
        If vNotas.GetFocusedRowCellValue("Estado").ToString().Equals("PROCESADA") Then
            XtraMsg("Debe Anular primero la Nota para Borrarla.", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        If XtraMsg2("Desea Borrar el Registro Completo de la Nota#: " & vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "NoNota")) Then
            '
            ObtieneDatos("SPBorrarNota '" & vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "IdNota") & "'")
            GetData()
        End If
    End Sub

    Private Sub vNotas_RowCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles vNotas.RowCellStyle
        Dim Cadena As String = vbNullString

        If e.Column.FieldName = "Estado" Then
            If Not vNotas.GetRowCellValue(e.RowHandle, "Estado") Is Nothing Then
                If vNotas.GetRowCellValue(e.RowHandle, "Estado") = "ANULADA" Then
                    e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    e.Appearance.Font = New Font("Tahoma", 9, FontStyle.Bold)
                    e.Appearance.BackColor = Color.Salmon
                End If
            End If
        End If
        '
        If e.Column.FieldName = "NC_Electrónica" Then
            If CBool(vNotas.GetRowCellValue(e.RowHandle, "NC_Electrónica")) Then
                e.Appearance.BackColor = Color.MediumSeaGreen
            End If
        End If
        '
        If e.Column.FieldName = "ATV" Then
            e.Appearance.Font = New Font("Tahoma", 8.25, FontStyle.Bold)
            e.Appearance.BackColor = Color.LightGray
            e.Appearance.BackColor2 = Color.Gray
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            If vNotas.GetRowCellValue(e.RowHandle, "ATV") = "aceptado" Then
                e.Appearance.ForeColor = Color.DarkGreen
            ElseIf vNotas.GetRowCellValue(e.RowHandle, "ATV") = "rechazado" Then
                e.Appearance.ForeColor = Color.DarkRed
            ElseIf vNotas.GetRowCellValue(e.RowHandle, "ATV") = "procesando" Then
                e.Appearance.ForeColor = Color.Navy
            ElseIf vNotas.GetRowCellValue(e.RowHandle, "ATV") = "recibido" Then
                e.Appearance.ForeColor = Color.Navy
            Else
                e.Appearance.ForeColor = Color.White
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        My.Forms.frmExportarImprimir.Mostrar(Me.GridDetalle)
    End Sub

    Private Sub DateEdit2_EditValueChanged(sender As Object, e As EventArgs) Handles Hasta.EditValueChanged
        ' Has()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        ShowSplash("Cargando N D/C...")
        GetData()
        HideSplash()
    End Sub

    Private Sub bDiseno_Click(sender As Object, e As EventArgs) Handles bDiseno.Click
        With FrmConfiguraCheque
            .Tipo = 6
            .Text = "Diseño de Notas D / C"
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub bTipoNC_Click(sender As Object, e As EventArgs) Handles bTipoNC.Click
        With frmNotasTipo
            .Text = "Tipos de Notas"
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub bDevolucionE_Click(sender As Object, e As EventArgs) Handles bDevolucionE.Click
        If vNotas.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        If vNotas.GetFocusedRowCellValue("Estado").ToString().Equals("ANULADA") Then
            XtraMsg($"La NOTA DE {vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "Tipo")} se encuentra ANULADA",
                    MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        Dim Estado As String =
            vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "ATV")
        '        
        'Factura Electronica de Guatemala
        If EmpresaActual.Equals("18") Then

            Dim Tipo As String = vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "Tipo")

            If vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "Tipo") _
            .ToString() _
            .Equals("DEBITO") Then
                XtraMsg("Seleccione una Nota de Crédito",
                    MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim _dtNC As DataTable =
                Facturas_VentasDB.FacturasVentasBuscarNC(vNotas.GetFocusedRowCellValue("IdNota"))

            If _dtNC.Rows.Count = 0 Then
                XtraMsg("La Nota de Crédito no contiene ninguna Factura de Cliente Asociada", MessageBoxIcon.Error)
                Exit Sub
            End If
            '
            If _dtNC.Rows.Count > 1 Then
                XtraMsg("La Nota de Crédito contiene más de 1 Factura Asociada", MessageBoxIcon.Error)
                Exit Sub
            End If
            '
            Dim _dt As DataTable = Facturas_VentasDB.MensajeRechazo(
                    "aceptado",
                    _dtNC.Rows.Item(0)("Factura"),
                    "01")

            If _dt.Rows.Count = 0 Then
                XtraMsg($"La Factura: {_dtNC.Rows.Item(0)("Factura")} aún no se ha certificado en Hacienda!",
                        MessageBoxIcon.Error)
                Exit Sub
            End If

            'Dim api As HaciendaGT.ResponseApi =
            '    JsonConvert.DeserializeObject(Of HaciendaGT.ResponseApi)(_dt.Rows.Item(0)("MensajeHacienda"))

            With New frmNotaCreditoGT

                .RespuestaHacienda = _dt.Rows.Item(0)("MensajeHacienda")
                .IdNota = vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "IdNota")
                .NoNota = vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "NoNota")
                .Factura.Text = _dtNC.Rows.Item(0)("Factura")
                .Cliente.Text = vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "Cliente")

                .ShowDialog()

                If .Ok Then
                    GetData()
                End If

                .Dispose()
                Exit Sub

            End With
        End If

        If EmpresaActual.Equals("20") Then

            If vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "Tipo") _
            .ToString() _
            .Equals("DEBITO") Then
                XtraMsg("Seleccione una Nota de Crédito",
                    MessageBoxIcon.Warning)
                Exit Sub
            End If

            If Estado.Equals("n/a") Then
                XtraMsg($"Este acción no aplica para este tipo de NOTA DE {vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "Tipo")}",
                    MessageBoxIcon.Error)
                Exit Sub
            End If
            '
            Dim CantFact As Integer = Facturas_VentasDB.BuscarFacturasNC(
            vNotas.GetFocusedRowCellValue("Facturas"))

            If CantFact = 0 Then
                XtraMsg("La Nota de Crédito no contiene ninguna Factura Asociada", MessageBoxIcon.Error)
                Exit Sub
            End If
            '
            If CantFact > 1 Then
                XtraMsg("La Nota de Crédito contiene más de 1 Factura Asociada", MessageBoxIcon.Error)
                Exit Sub
            End If

            If Facturas_VentasDB.BuscarDevolucionNC(
            vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "IdNota")) _
            .Rows _
            .Count = 0 Then

                XtraMsg("No se ha podido encontrar la Devolución asociada a esta N/C.",
                        MessageBoxIcon.Error)
                Exit Sub
            End If
            '
            Dim fv As New Factura_ElectronicaCR
            Dim enviaFactura As New Comunicacion

            'enviaFactura = fv.ConsultarComprobante(
            '        vNotas.GetFocusedRowCellValue("Facturas"),
            '        "03")

            If Estado.Equals("aceptado") Then

                If EmpresaActual.Equals("18") Then
                    XtraMsg($"La NOTA DE {vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "Tipo")} ya se encuentra aceptada en Hacienda.")
                ElseIf EmpresaActual.Equals("20") Then
                    If XtraMsg2($"La NOTA DE {vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "Tipo")} ya se encuetra aceptada en Hacienda." & vbCrLf &
                            "Desea Reenviar el comprobante al Cliente?") Then

                        EnviarMailComprobante(
                            True,
                            Estado)
                    End If
                End If
                '
                Exit Sub
            End If
            '
            If Estado.Equals("procesando") Or
                 Estado.Equals("recibido") Then

                If Not XtraMsg2("Desea consultar el estado actual de la Nota de Crédito Electrónica?") Then
                    Exit Sub
                End If
                '                
                enviaFactura = fv.ConsultarComprobante(
                    vNotas.GetFocusedRowCellValue("Facturas"),
                    "03")
                '            
                XtraMsg(enviaFactura.mensajeRespuesta)

                If Not IsNothing(enviaFactura) Then
                    EnviarMailComprobante(
                        False,
                        enviaFactura.estadoFactura)
                End If

            ElseIf Estado.Equals("sin respuesta") Then

                enviaFactura = fv.ConsultarComprobante(
                 vNotas.GetFocusedRowCellValue("Facturas"),
                 "03")

                'Si codigo de respuesta es 400 signigica que haciend,
                'no lo ha recibido aun.
                If IsNothing(enviaFactura) Then
                    ClientesDB.MaestroNotasCDUpdateATV(
                        vNotas.GetFocusedRowCellValue("IdNota"),
                        String.Empty)
                Else
                    XtraMsg(enviaFactura.mensajeRespuesta)
                End If

            ElseIf Estado.Equals(String.Empty) Or
                    Estado.Equals("n/a") Or
                        Estado.Equals("rechazado") Then
                'ShowSplash("Enviando N/C...")
                '
                enviaFactura =
                    fv.EnviarComprobante(
                    vNotas.GetFocusedRowCellValue("Facturas"),
                    "03",
                    "NotaCreditoElectronica",
                    vNotas.GetFocusedRowCellValue("Fecha"),
                    "N/C Electrónica por Devolución de factura No." & vNotas.GetFocusedRowCellValue("Facturas"),
                    vNotas.GetFocusedRowCellValue("IdNota"))
                '
                'HideSplash()

                If enviaFactura.estadoFactura.Equals("acepatado") Then

                    Dim DT_Header As DataTable = ObtieneDatos("sp_sel_FACTURAS_VENTAS",
                                                              vNotas.GetFocusedRowCellValue("Facturas"),
                                                              EmpresaActual)

                    Dim ClienteDetalle As New VB.SysContab.ClientesDetails
                    ClienteDetalle = VB.SysContab.ClientesDB.GetDetails(DT_Header.Rows.Item(0)("CLIENTE"))

                    If IsNull(ClienteDetalle.Correo, "").ToString.Trim.Length = 0 Then
                        XtraMsg("El Cliente :" & ClienteDetalle.Nombre.Trim & " No tiene correo de Envío en su perfil" &
                                "de cliente, intente Re-Enviar correo en unos minutos...", MessageBoxIcon.Warning)
                    Else
                        EnviarMailComprobante(
                            False,
                            Estado)
                    End If
                End If
            End If

        End If
        '   
        ShowSplash("Cargando N D/C...")
        GetData()
        HideSplash()
    End Sub

    Sub EnviarMailComprobante(ver As Boolean,
                           Estado As String)

        If Estado.Equals("aceptado") Then
            Dim TieneCorreo As Boolean = True

            Dim DT_Header As DataTable = ObtieneDatos("sp_sel_FACTURAS_VENTAS",
                                                      vNotas.GetFocusedRowCellValue("Facturas"),
                                                      EmpresaActual)

            Dim ClienteDetalle As New VB.SysContab.ClientesDetails
            ClienteDetalle = VB.SysContab.ClientesDB.GetDetails(DT_Header.Rows.Item(0)("CLIENTE"))
            '
            If IsNull(ClienteDetalle.Correo, "").ToString.Trim.Length = 0 Then
                XtraMsg("El Cliente :" & ClienteDetalle.Nombre.Trim &
                        " No tiene correo de Envío en su perfil de cliente, intente Re-Enviar la factuara en unos minutos...",
                        MessageBoxIcon.Warning)
                TieneCorreo = False
            End If
            '
            If TieneCorreo Then
                If ver Then
                    If Not XtraMsg2("Desea Reenviar la Nota de Crédito Electrónica al Cliente?") Then
                        Exit Sub
                    End If
                End If
                '
                ShowSplash("Enviando Correo...")
                '
                Facturas_VentasDB.EnviarCorreoClienteNE(
                    vNotas.GetFocusedRowCellValue("Facturas"),
                    vNotas.GetFocusedRowCellValue("NoNota"),
                    DT_Header.Rows.Item(0)("CLIENTE"),
                    ClienteDetalle.Correo,
                    "03")
                '
                HideSplash()
            End If
        End If
        '
        'ShowSplash("Cargando N D/C...")
        'GetData()
        'HideSplash()

    End Sub

    Private Sub vNotas_DoubleClick(sender As Object, e As EventArgs) Handles vNotas.DoubleClick
        If vNotas.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        Dim Estado As String =
            vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "ATV")

        'Nota Electronica Guatemala
        If EmpresaActual.Equals("18") Then
            If Estado.Equals("rechazado") Or
                    Estado.Equals("aceptado") Then

                With New frmMotivoRechazo

                    .Tipo = 1
                    .Consecutivo = Estado
                    .Factura = vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "NoNota")
                    .TipoDocumento = "03"
                    .ShowDialog()
                    .Dispose()

                End With
            End If
        End If
        '
        ''Nota Electronica Costa Rica
        If EmpresaActual.Equals("20") Then
            If Estado.Equals("rechazado") Then

                With New frmMotivoRechazo

                    .Tipo = 3
                    .ID = vNotas.GetRowCellValue(vNotas.FocusedRowHandle, "IdNota")
                    .ShowDialog()
                    .Dispose()

                End With
            End If
        End If

    End Sub

    Private Sub vNotas_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles vNotas.RowCellClick

    End Sub
End Class
