Imports System.IO
Imports System.Xml
Imports SysContab.ws_tc
Imports System.Globalization
Imports ClasesBLL

Public Class frmTasaCambio
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmTasaCambio = Nothing

    Public Shared Function Instance() As frmTasaCambio
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmTasaCambio()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance

    End Function


    Dim Dias As Integer
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bTasaWeb As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbMonedaOrigen As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbMonedaDestino As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbMeses As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents sAnio As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents rTasa As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents bBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Dim xmlds As DataSet

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
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    'Friend WithEvents rptPrueba As AxCrystal.AxCrystalReport
    Friend WithEvents cmdImportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTasaCambio))
        Me.bTasaWeb = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.bBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImportar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cbMeses = New DevExpress.XtraEditors.LookUpEdit()
        Me.sAnio = New DevExpress.XtraEditors.SpinEdit()
        Me.cbMonedaDestino = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbMonedaOrigen = New DevExpress.XtraEditors.LookUpEdit()
        Me.iGrid = New DevExpress.XtraGrid.GridControl()
        Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.rTasa = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
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
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cbMeses.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sAnio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMonedaDestino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMonedaOrigen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rTasa, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bTasaWeb
        '
        Me.bTasaWeb.Appearance.Options.UseTextOptions = True
        Me.bTasaWeb.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bTasaWeb.Enabled = False
        Me.bTasaWeb.ImageOptions.Image = CType(resources.GetObject("bTasaWeb.ImageOptions.Image"), System.Drawing.Image)
        Me.bTasaWeb.Location = New System.Drawing.Point(232, 611)
        Me.bTasaWeb.Name = "bTasaWeb"
        Me.bTasaWeb.Size = New System.Drawing.Size(106, 38)
        Me.bTasaWeb.StyleController = Me.LayoutControl1
        Me.bTasaWeb.TabIndex = 10
        Me.bTasaWeb.Text = "Importar desde &BCN"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.bBuscar)
        Me.LayoutControl1.Controls.Add(Me.cmdSalir)
        Me.LayoutControl1.Controls.Add(Me.cmdAyuda)
        Me.LayoutControl1.Controls.Add(Me.cmdModificar)
        Me.LayoutControl1.Controls.Add(Me.bTasaWeb)
        Me.LayoutControl1.Controls.Add(Me.cmdImportar)
        Me.LayoutControl1.Controls.Add(Me.cmdImprimir)
        Me.LayoutControl1.Controls.Add(Me.cbMeses)
        Me.LayoutControl1.Controls.Add(Me.sAnio)
        Me.LayoutControl1.Controls.Add(Me.cbMonedaDestino)
        Me.LayoutControl1.Controls.Add(Me.cbMonedaOrigen)
        Me.LayoutControl1.Controls.Add(Me.iGrid)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1161, 295, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(711, 661)
        Me.LayoutControl1.TabIndex = 165
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'bBuscar
        '
        Me.bBuscar.ImageOptions.Image = CType(resources.GetObject("bBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.bBuscar.Location = New System.Drawing.Point(606, 70)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(93, 38)
        Me.bBuscar.StyleController = Me.LayoutControl1
        Me.bBuscar.TabIndex = 170
        Me.bBuscar.Text = "&Buscar"
        '
        'cmdSalir
        '
        Me.cmdSalir.ImageOptions.Image = CType(resources.GetObject("cmdSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(591, 611)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(108, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl1
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.ImageOptions.Image = CType(resources.GetObject("cmdAyuda.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAyuda.Location = New System.Drawing.Point(342, 611)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(84, 38)
        Me.cmdAyuda.StyleController = Me.LayoutControl1
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'cmdModificar
        '
        Me.cmdModificar.Appearance.Options.UseTextOptions = True
        Me.cmdModificar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.ImageOptions.Image = CType(resources.GetObject("cmdModificar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdModificar.Location = New System.Drawing.Point(122, 611)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(106, 38)
        Me.cmdModificar.StyleController = Me.LayoutControl1
        Me.cmdModificar.TabIndex = 9
        Me.cmdModificar.Text = "&Editar"
        '
        'cmdImportar
        '
        Me.cmdImportar.Appearance.Options.UseTextOptions = True
        Me.cmdImportar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdImportar.Enabled = False
        Me.cmdImportar.ImageOptions.Image = CType(resources.GetObject("cmdImportar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdImportar.Location = New System.Drawing.Point(12, 611)
        Me.cmdImportar.Name = "cmdImportar"
        Me.cmdImportar.Size = New System.Drawing.Size(106, 38)
        Me.cmdImportar.StyleController = Me.LayoutControl1
        Me.cmdImportar.TabIndex = 8
        Me.cmdImportar.Text = "I&mportar de Excel"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Appearance.Options.UseTextOptions = True
        Me.cmdImprimir.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.ImageOptions.Image = CType(resources.GetObject("cmdImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdImprimir.Location = New System.Drawing.Point(481, 611)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(106, 38)
        Me.cmdImprimir.StyleController = Me.LayoutControl1
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Exportar / Imprimir"
        '
        'cbMeses
        '
        Me.cbMeses.Location = New System.Drawing.Point(96, 86)
        Me.cbMeses.Name = "cbMeses"
        Me.cbMeses.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMeses.Properties.Appearance.Options.UseFont = True
        Me.cbMeses.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMeses.Size = New System.Drawing.Size(506, 20)
        Me.cbMeses.StyleController = Me.LayoutControl1
        Me.cbMeses.TabIndex = 168
        '
        'sAnio
        '
        Me.sAnio.EditValue = New Decimal(New Integer() {1990, 0, 0, 0})
        Me.sAnio.Location = New System.Drawing.Point(96, 60)
        Me.sAnio.Name = "sAnio"
        Me.sAnio.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sAnio.Properties.Appearance.Options.UseFont = True
        Me.sAnio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sAnio.Properties.Mask.EditMask = "f0"
        Me.sAnio.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.sAnio.Properties.MaxValue = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.sAnio.Properties.MinValue = New Decimal(New Integer() {1990, 0, 0, 0})
        Me.sAnio.Size = New System.Drawing.Size(109, 22)
        Me.sAnio.StyleController = Me.LayoutControl1
        Me.sAnio.TabIndex = 169
        '
        'cbMonedaDestino
        '
        Me.cbMonedaDestino.Location = New System.Drawing.Point(96, 36)
        Me.cbMonedaDestino.Name = "cbMonedaDestino"
        Me.cbMonedaDestino.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMonedaDestino.Properties.Appearance.Options.UseFont = True
        Me.cbMonedaDestino.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMonedaDestino.Size = New System.Drawing.Size(603, 20)
        Me.cbMonedaDestino.StyleController = Me.LayoutControl1
        Me.cbMonedaDestino.TabIndex = 168
        '
        'cbMonedaOrigen
        '
        Me.cbMonedaOrigen.Location = New System.Drawing.Point(96, 12)
        Me.cbMonedaOrigen.Name = "cbMonedaOrigen"
        Me.cbMonedaOrigen.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMonedaOrigen.Properties.Appearance.Options.UseFont = True
        Me.cbMonedaOrigen.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbMonedaOrigen.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cbMonedaOrigen.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cbMonedaOrigen.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.cbMonedaOrigen.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMonedaOrigen.Properties.ReadOnly = True
        Me.cbMonedaOrigen.Size = New System.Drawing.Size(603, 20)
        Me.cbMonedaOrigen.StyleController = Me.LayoutControl1
        Me.cbMonedaOrigen.TabIndex = 167
        '
        'iGrid
        '
        Me.iGrid.Location = New System.Drawing.Point(12, 112)
        Me.iGrid.MainView = Me.iVista
        Me.iGrid.Name = "iGrid"
        Me.iGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rTasa})
        Me.iGrid.Size = New System.Drawing.Size(687, 495)
        Me.iGrid.TabIndex = 166
        Me.iGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista})
        '
        'iVista
        '
        Me.iVista.GridControl = Me.iGrid
        Me.iVista.Name = "iVista"
        Me.iVista.OptionsView.ShowAutoFilterRow = True
        Me.iVista.OptionsView.ShowFooter = True
        Me.iVista.OptionsView.ShowGroupPanel = False
        '
        'rTasa
        '
        Me.rTasa.AutoHeight = False
        Me.rTasa.Mask.EditMask = "n4"
        Me.rTasa.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rTasa.Mask.UseMaskAsDisplayFormat = True
        Me.rTasa.Name = "rTasa"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.LayoutControlItem12, Me.EmptySpaceItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(711, 661)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.iGrid
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 100)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(691, 499)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cbMonedaOrigen
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(691, 24)
        Me.LayoutControlItem2.Text = "Moneda Origen:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbMonedaDestino
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(691, 24)
        Me.LayoutControlItem3.Text = "Moneda Destino:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.sAnio
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(197, 26)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(197, 26)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(197, 26)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "Año:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cbMeses
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 74)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(594, 26)
        Me.LayoutControlItem5.Text = "Mes:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cmdImportar
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 599)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.bTasaWeb
        Me.LayoutControlItem7.Location = New System.Drawing.Point(220, 599)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmdImprimir
        Me.LayoutControlItem8.Location = New System.Drawing.Point(469, 599)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmdModificar
        Me.LayoutControlItem9.Location = New System.Drawing.Point(110, 599)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cmdAyuda
        Me.LayoutControlItem10.Location = New System.Drawing.Point(330, 599)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(88, 42)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(88, 42)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(88, 42)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        Me.LayoutControlItem10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cmdSalir
        Me.LayoutControlItem11.Location = New System.Drawing.Point(579, 599)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(197, 48)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(397, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(418, 599)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(51, 42)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.bBuscar
        Me.LayoutControlItem12.Location = New System.Drawing.Point(594, 58)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(594, 48)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(97, 10)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmTasaCambio
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(711, 661)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmTasaCambio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cbMeses.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sAnio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMonedaDestino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMonedaOrigen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rTasa, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim r As New VB.SysContab.Rutinas()
    Dim Monedas As New VB.SysContab.MonedaDB()
    Public Inicio As Boolean
    Dim dsTasaCambio As DataSet
    Dim DT_ROL As New DataTable("Roles")
    Private TC As New db_TasaCambio

    Private Sub frmTasaCambio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim Tasa_Cambio As New VB.SysContab.Tasa_CambioDB()
        'Dim Tabla As New DataTable()
        'Dim i As Integer
        ''  '''r.CambiarEstilo(Me)

        DT_ROL = RolesDB.UsuarioAcciones(LayoutControl1)

        GetMonedasList(cbMonedaOrigen)

        GetMonedasList(cbMonedaDestino)
        cbMonedaDestino.ItemIndex = 1

        'GetMesesList(cbMeses)        
        sAnio.EditValue = VB.SysContab.Rutinas.Fecha().Year

        Combo(cbMeses, ObtieneDatos("sp_MesesList", sAnio.EditValue))
        cbMeses.EditValue = VB.SysContab.Rutinas.Fecha().Month
        '
        Cargar()

        'nudAnio.Value = CDate(VB.SysContab.Rutinas.Fecha).Year
        'cbMes.SelectedIndex = CDate(VB.SysContab.Rutinas.Fecha).Month - 1
        'dsTasaCambio = Tasa_Cambio.GetList(1, 2)

        'cbMoneda1.DataSource = Monedas.GetList.Tables("Monedas")
        'cbMoneda1.ValueMember = "Codigo"
        'cbMoneda1.DisplayMember = "Descripcion"

        'cbMoneda2.DataSource = Monedas.GetList.Tables("Monedas")
        'cbMoneda2.ValueMember = "Codigo"
        'cbMoneda2.DisplayMember = "Descripcion"

        'Me.cbMoneda1.SelectedValue = MonedaBase

        'Try
        '    Me.cbMoneda2.SelectedIndex = 1
        'Catch ex As Exception
        'End Try


        'If Me.cbMoneda1.SelectedValue Is Nothing Then
        '    dsTasaCambio = Nothing
        'ElseIf Me.cbMoneda2.SelectedValue Is Nothing Then
        '    dsTasaCambio = Nothing
        'Else
        '    dsTasaCambio = VB.SysContab.Tasa_CambioDB.GetTasaCambioMes(Now.Month, Now.Year, Me.cbMoneda1.SelectedValue, Me.cbMoneda2.SelectedValue)

        '    If dsTasaCambio.Tables("TASA_CAMBIO").Rows.Count = 0 Then
        '        For i = 1 To Now.DaysInMonth(nudAnio.Value, cbMes.SelectedIndex + 1)
        '            Tasa_Cambio.AddItem(Me.cbMoneda1.SelectedValue, Me.cbMoneda2.SelectedValue, i, cbMes.SelectedIndex + 1, nudAnio.Value, 1)
        '        Next
        '        dsTasaCambio = Tasa_Cambio.GetTasaCambioMes(cbMes.SelectedIndex + 1, nudAnio.Value, Me.cbMoneda1.SelectedValue, Me.cbMoneda2.SelectedValue)
        '    End If
        'End If

        '''VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        'dsTasaCambio.Tables("Tasa_Cambio").DefaultView.AllowDelete = False
        'dsTasaCambio.Tables("Tasa_Cambio").DefaultView.AllowNew = False
        'dsTasaCambio.Tables("Tasa_Cambio").DefaultView.AllowEdit = True

        'dgTasaCambio.DataSource = dsTasaCambio.Tables("Tasa_Cambio").DefaultView 'Tasa_Cambio.GetList().Tables("TASA_CAMBIO_TEMPORAL").DefaultView

        'Tabla = dsTasaCambio.Tables("Tasa_Cambio")
        ' r.FormatGenerico(dgTasaCambio, Tabla)
        ' dgTasaCambio.AllowSorting = False
    End Sub

    Sub Cargar()
        '
        dsTasaCambio = VB.SysContab.Tasa_CambioDB.GetTasaCambioMes(cbMeses.EditValue, sAnio.EditValue, cbMonedaOrigen.EditValue, cbMonedaDestino.EditValue)

        If dsTasaCambio.Tables("TASA_CAMBIO").Rows.Count = 0 Then
            For i As Integer = 1 To DateTime.DaysInMonth(sAnio.EditValue, cbMeses.EditValue)
                VB.SysContab.Tasa_CambioDB.AddItem(cbMonedaOrigen.EditValue,
                                                   cbMonedaDestino.EditValue,
                                                   i,
                                                   cbMeses.EditValue,
                                                   sAnio.EditValue,
                                                   1.0,
                                                   1.0)
            Next

            dsTasaCambio = VB.SysContab.Tasa_CambioDB.GetTasaCambioMes(cbMeses.EditValue,
                                                                       sAnio.EditValue,
                                                                       cbMonedaOrigen.EditValue,
                                                                       cbMonedaDestino.EditValue)
        End If

        iGrid.DataSource = dsTasaCambio.Tables("Tasa_Cambio").DefaultView
        iVista.PopulateColumns()
        FormatoGrid(iVista, 4, 0, False, True, False)

        For i As Integer = 0 To iVista.Columns.Count - 1
            iVista.Columns(i).OptionsColumn.AllowEdit = False
            iVista.Columns(i).OptionsColumn.AllowFocus = False
        Next

        iVista.Columns("Dia").Visible = False
        iVista.Columns("Mes").Visible = False
        iVista.Columns("Año").Visible = False
        iVista.Columns("Tasa Cambio").ColumnEdit = rTasa
        iVista.Columns("Tasa Paralela").ColumnEdit = rTasa


        iVista.Columns("Tasa Cambio").SummaryItem.DisplayFormat = "{0:n4}"
        iVista.Columns("Tasa Cambio").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Average
        '
        iVista.Columns("Tasa Paralela").SummaryItem.DisplayFormat = "{0:n4}"
        iVista.Columns("Tasa Paralela").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Average
    End Sub

    Private Sub cbAnio_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Dim Tasa_Cambio As New VB.SysContab.Tasa_CambioDB()
        'Dim r As New VB.SysContab.Rutinas()
        'Dim Tabla As New DataTable()
        'Dim i As Integer

        ''  '''r.CambiarEstilo(Me)

        'If cbAnio.Text = "" Then
        '    Exit Sub

        'End If

        'dsTasaCambio = Tasa_Cambio.GetList(cbMes.SelectedIndex + 1, cbAnio.Text)

        'If dsTasaCambio.Tables("TASA_CAMBIO").Rows.Count = 0 Then
        '    For i = 1 To Now.DaysInMonth(cbAnio.Text, cbMes.SelectedIndex + 1)
        '        Tasa_Cambio.AddItem(1, 2, i, cbMes.SelectedIndex + 1, cbAnio.Text, 0)
        '    Next
        'End If

        'dsTasaCambio = Tasa_Cambio.GetList(cbMes.SelectedIndex + 1, cbAnio.Text)

        'dsTasaCambio.Tables("TASA_CAMBIO").DefaultView.AllowDelete = False
        'dsTasaCambio.Tables("TASA_CAMBIO").DefaultView.AllowNew = False
        'dsTasaCambio.Tables("TASA_CAMBIO").DefaultView.AllowEdit = True

        'dgTasaCambio.DataSource = dsTasaCambio.Tables("TASA_CAMBIO").DefaultView 'Tasa_Cambio.GetList().Tables("TASA_CAMBIO_TEMPORAL").DefaultView

        'Tabla = dsTasaCambio.Tables("TASA_CAMBIO")

        'r.FormatGenerico(dgTasaCambio, Tabla)

    End Sub

    Private Sub dgTasaCambio_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'Dim Tasa_Cambio As New VB.SysContab.Tasa_CambioDB()
        'Dim i As Integer
        'For i = 1 To Now.DaysInMonth(nudAnio.Value, cbMes.SelectedIndex + 1)
        '    Tasa_Cambio.Update(Me.cbMoneda1.SelectedValue, Me.cbMoneda2.SelectedValue, i, cbMes.SelectedIndex + 1, nudAnio.Value, dgTasaCambio.Item(i - 1, 1))
        'Next
    End Sub

    Private Sub frmTasaCambio_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        '''
    End Sub

    Private Sub cbMes_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        '''
    End Sub

    Private Sub cbAnio_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '''
    End Sub

    Private Sub dgTasaCambio_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        '''
    End Sub

    Private Sub frmTasaCambio_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Opened = "NO"
        ''
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click

        frmExportarImprimir.Mostrar(iGrid, "Tasa de Cambio", cbMeses.Text)

        'Dim fReportes As New frmReportes()
        ''Dim rTasaCambio As New rptTasaCambio()
        'Dim TasaCambio As New VB.SysContab.Tasa_CambioDB()
        'Dim r As New VB.SysContab.Rutinas()

        'Dim rTasaCambio As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'rTasaCambio.Load(Application.StartupPath & "\Reportes\rptTasaCambio.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        'rTasaCambio.SetDataSource(TasaCambio.GetListReporte(cbMes.SelectedIndex + 1, nudAnio.Value))
        'fReportes.crvReportes.ReportSource = rTasaCambio
        'fReportes.Show()
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        'Help.ShowHelp(Me, "ayuda/RegTasaCambio.chm")
        'Help.ShowHelp(Me, "ayuda/STSContab.chm", HelpNavigator.KeywordIndex, "TasadeCambio")
    End Sub

    Private Sub cbMes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'If Not IsNumeric(Me.cbMes.SelectedIndex) Or Me.cbMes.SelectedIndex = -1 Then
        '    Exit Sub
        'End If
        'If Not IsNumeric(Me.cbMoneda2.SelectedValue) Then
        '    Exit Sub
        'End If

        'If Not IsNumeric(Me.cbMoneda1.SelectedValue) Then
        '    Exit Sub
        'End If

        'If Me.Inicio = True Then
        '    Exit Sub
        'End If

        'Dim Tasa_Cambio As New VB.SysContab.Tasa_CambioDB
        'Dim r As New VB.SysContab.Rutinas
        'Dim Tabla As New DataTable
        'Dim i As Integer

        ' ''  '''r.CambiarEstilo(Me)

        ''If cbAnio.Text = "" Then
        ''    Exit Sub

        ''End If

        'dsTasaCambio = Tasa_Cambio.GetTasaCambioMes(cbMes.SelectedIndex + 1, nudAnio.Value, Me.cbMoneda1.SelectedValue, Me.cbMoneda2.SelectedValue)

        'If dsTasaCambio.Tables("TASA_CAMBIO").Rows.Count = 0 Then
        '    For i = 1 To Now.DaysInMonth(nudAnio.Value, cbMes.SelectedIndex + 1)
        '        Tasa_Cambio.AddItem(Me.cbMoneda1.SelectedValue, Me.cbMoneda2.SelectedValue, i, cbMes.SelectedIndex + 1, nudAnio.Value, 1)
        '    Next

        '    dsTasaCambio = Tasa_Cambio.GetTasaCambioMes(cbMes.SelectedIndex + 1, nudAnio.Value, Me.cbMoneda1.SelectedValue, Me.cbMoneda2.SelectedValue)
        'End If



        ''dsTasaCambio = Tasa_Cambio.GetList(cbMes.SelectedIndex + 1, cbAnio.Text)

        'dsTasaCambio.Tables("TASA_CAMBIO").DefaultView.AllowDelete = False
        'dsTasaCambio.Tables("TASA_CAMBIO").DefaultView.AllowNew = False
        'dsTasaCambio.Tables("TASA_CAMBIO").DefaultView.AllowEdit = True

        'dgTasaCambio.DataSource = dsTasaCambio.Tables("TASA_CAMBIO").DefaultView 'Tasa_Cambio.GetList().Tables("TASA_CAMBIO_TEMPORAL").DefaultView

        'Tabla = dsTasaCambio.Tables("TASA_CAMBIO")

        'r.FormatGenerico(dgTasaCambio, Tabla)
    End Sub

    Private Sub cbMoneda1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)

        'If Not IsNumeric(Me.cbMes.SelectedValue) Or Me.cbMes.SelectedIndex = -1 Then
        '    Exit Sub
        'End If

        'If Not IsNumeric(Me.cbMoneda2.SelectedValue) Then
        '    Exit Sub
        'End If

        'If Not IsNumeric(Me.cbMoneda1.SelectedValue) Then
        '    Exit Sub
        'End If

        'If Me.Inicio = True Then
        '    Exit Sub
        'End If

        'Dim Tasa_Cambio As New VB.SysContab.Tasa_CambioDB
        'Dim r As New VB.SysContab.Rutinas
        'Dim Tabla As New DataTable
        'Dim i As Integer

        ' ''  '''r.CambiarEstilo(Me)

        ''If cbAnio.Text = "" Then
        ''    Exit Sub
        ''End If

        'dsTasaCambio = Tasa_Cambio.GetTasaCambioMes(cbMes.SelectedIndex + 1, nudAnio.Value, Me.cbMoneda1.SelectedValue, Me.cbMoneda2.SelectedValue)

        'If dsTasaCambio.Tables("TASA_CAMBIO").Rows.Count = 0 Then
        '    For i = 1 To Now.DaysInMonth(nudAnio.Value, cbMes.SelectedIndex + 1)
        '        Tasa_Cambio.AddItem(Me.cbMoneda1.SelectedValue, Me.cbMoneda2.SelectedValue, i, cbMes.SelectedIndex + 1, nudAnio.Value, 1)
        '    Next

        '    dsTasaCambio = Tasa_Cambio.GetTasaCambioMes(cbMes.SelectedIndex + 1, nudAnio.Value, Me.cbMoneda1.SelectedValue, Me.cbMoneda2.SelectedValue)
        'End If



        ''dsTasaCambio = Tasa_Cambio.GetList(cbMes.SelectedIndex + 1, cbAnio.Text)

        'dsTasaCambio.Tables("TASA_CAMBIO").DefaultView.AllowDelete = False
        'dsTasaCambio.Tables("TASA_CAMBIO").DefaultView.AllowNew = False
        'dsTasaCambio.Tables("TASA_CAMBIO").DefaultView.AllowEdit = True

        'dgTasaCambio.DataSource = dsTasaCambio.Tables("TASA_CAMBIO").DefaultView 'Tasa_Cambio.GetList().Tables("TASA_CAMBIO_TEMPORAL").DefaultView

        'Tabla = dsTasaCambio.Tables("TASA_CAMBIO")

        'r.FormatGenerico(dgTasaCambio, Tabla)
    End Sub

    Private Sub cbMoneda2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'If Not IsNumeric(Me.cbMoneda2.SelectedValue) Or Me.cbMes.SelectedIndex = -1 Then
        '    Exit Sub
        'End If

        'If Not IsNumeric(Me.cbMoneda1.SelectedValue) Then
        '    Exit Sub
        'End If


        'If Me.Inicio = True Then
        '    Exit Sub
        'End If

        'Dim Tasa_Cambio As New VB.SysContab.Tasa_CambioDB
        'Dim r As New VB.SysContab.Rutinas
        'Dim Tabla As New DataTable
        'Dim i As Integer

        ' ''  '''r.CambiarEstilo(Me)
        ''If cbAnio.Text = "" Then
        ''    Exit Sub
        ''End If

        'dsTasaCambio = Tasa_Cambio.GetTasaCambioMes(cbMes.SelectedIndex + 1, nudAnio.Value, Me.cbMoneda1.SelectedValue, Me.cbMoneda2.SelectedValue)

        'If dsTasaCambio.Tables("TASA_CAMBIO").Rows.Count = 0 Then
        '    For i = 1 To Now.DaysInMonth(nudAnio.Value, cbMes.SelectedIndex + 1)
        '        Tasa_Cambio.AddItem(Me.cbMoneda1.SelectedValue, Me.cbMoneda2.SelectedValue, i, cbMes.SelectedIndex + 1, nudAnio.Value, 1)
        '    Next

        '    dsTasaCambio = Tasa_Cambio.GetTasaCambioMes(cbMes.SelectedIndex + 1, nudAnio.Value, Me.cbMoneda1.SelectedValue, Me.cbMoneda2.SelectedValue)
        'End If



        ''dsTasaCambio = Tasa_Cambio.GetList(cbMes.SelectedIndex + 1, cbAnio.Text)

        'dsTasaCambio.Tables("TASA_CAMBIO").DefaultView.AllowDelete = False
        'dsTasaCambio.Tables("TASA_CAMBIO").DefaultView.AllowNew = False
        'dsTasaCambio.Tables("TASA_CAMBIO").DefaultView.AllowEdit = True

        'dgTasaCambio.DataSource = dsTasaCambio.Tables("TASA_CAMBIO").DefaultView 'Tasa_Cambio.GetList().Tables("TASA_CAMBIO_TEMPORAL").DefaultView

        'Tabla = dsTasaCambio.Tables("TASA_CAMBIO")

        'r.FormatGenerico(dgTasaCambio, Tabla)
    End Sub

    Private Sub cmdImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImportar.Click

        With frmImportarComprobante
            .Tipo = "TASA_CAMBIO"
            .ShowDialog()

            If .Ok = "NO" Then
                .Dispose()
                Exit Sub
            End If

            If Not .DT Is Nothing Then
                ShowSplash("Importando...")
                Dim DT_IMPORT As DataTable = .DT

                'Borrar las tasas de cambio
                For i As Integer = 1 To DateTime.DaysInMonth(sAnio.EditValue, cbMeses.EditValue)
                    VB.SysContab.Tasa_CambioDB.Delete(cbMonedaOrigen.EditValue, _
                                                      cbMonedaDestino.EditValue, _
                                                      i, _
                                                      cbMeses.EditValue, _
                                                      sAnio.EditValue)
                Next
                '
                For i As Integer = 0 To DT_IMPORT.Rows.Count - 1
                    'Validar Tipo de Datos del Archivo que se importo
                    If IsDate(DT_IMPORT.Rows.Item(i)("Fecha")) And
                        IsNumeric(DT_IMPORT.Rows.Item(i)("Tasa")) Then

                        VB.SysContab.Tasa_CambioDB.AddItem(cbMonedaOrigen.EditValue,
                                                           cbMonedaDestino.EditValue,
                                                           CDate(DT_IMPORT.Rows.Item(i)("Fecha")).Day,
                                                           cbMeses.EditValue,
                                                           sAnio.EditValue,
                                                           DT_IMPORT.Rows.Item(i)("Tasa"),
                                                           IsNull(DT_IMPORT.Rows.Item(i)("Paralelo"), 1.0))
                    Else
                        XtraMsg(String.Format("Formato de Datos Incorrectos: {0},{1}", "[ Fecha = " & IsNull(DT_IMPORT.Rows.Item(i)("Fecha"), "").ToString & "]", "[ Tasa = " & IsNull(DT_IMPORT.Rows.Item(i)("Valor"), "").ToString & "]"), MessageBoxIcon.Error)
                    End If
                Next

                HideSplash()
                XtraMsg("Archivo Importado")
                Buscar()
            End If
            .Dispose()
        End With

        '        Dim i As Integer
        '        Dim TC As New VB.SysContab.Tasa_CambioDB
        '        Dim dTC As New VB.SysContab.Tasa_CambioDetails

        '        'Tasa de Cambio
        '        Dim nArchivo As String
        '        Dim myStream As Stream = Nothing
        '        Dim Documentos As New VB.SysContab.DocumentosDB

        '        If Not XtraMsg2("Con este procedimiento se borraran las tasas de cambio anteriores del mes seleccionado y " & vbCrLf & _
        '             "se sustituiran por las tasas contenidas en el archivo a seleccionar, esta seguro " & vbCrLf & _
        '             "de realizar esta operacion?") Then
        '            Exit Sub
        '        End If

        '        Me.ofd.InitialDirectory = Application.StartupPath()

        '        Me.ofd.Filter = "CSV Files (*.csv)|*.csv|Text Files (*.txt)|*.txt"
        '        Me.ofd.FilterIndex = 1
        '        Me.ofd.RestoreDirectory = True

        '        If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        '            Try
        '                myStream = Me.ofd.OpenFile()
        '            Catch Ex As Exception
        '                XtraMsg("No se puede leer el archivo. Error original: " & vbCrLf & Ex.Message, MessageBoxIcon.Error)
        '                Exit Sub
        '            Finally
        '                ' Check this again, since we need to make sure we didn't throw an exception on open.
        '                If Not IsNothing(myStream) Then
        '                    nArchivo = Me.ofd.FileName
        '                    myStream.Close()
        '                    xmlds = New DataSet
        '                    If Documentos.Leer_Archivo(nArchivo, xmlds) = -1 Then  'xmlds =VB.SysContab.RutinasNomina.LeerXML(nArchivo)
        '                        XtraMsg("Error al cargar el archivo", MessageBoxIcon.Error)
        '                    End If
        '                End If
        '            End Try
        '        End If
        '        If IsNothing(myStream) Then
        '            Exit Sub
        '        End If
        '        If xmlds.Tables(0).Columns(0).ColumnName.ToLower <> "fecha" Then
        '            XtraMsg("El nombre del primer campo debe ser <Fecha>", MessageBoxIcon.Warning)
        '            Exit Sub
        '        End If
        '        If xmlds.Tables(0).Columns(1).ColumnName.ToLower <> "valor" Then
        '            XtraMsg("El nombre del segundo campo debe ser <Valor>", MessageBoxIcon.Warning)
        '            Exit Sub
        '        End If

        '        Dim Errores As New DataSet
        '        Errores = xmlds.Clone()
        '        Errores.Tables(0).Columns.Add("TError")
        '        For i = 0 To xmlds.Tables(0).Rows.Count - 1
        '            If Not IsDate(xmlds.Tables(0).Rows(i)("fecha")) Then
        '                Errores.Tables(0).Rows.Add(xmlds.Tables(0).Rows(i).ItemArray)
        '                Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("TError") = "Fecha Inválida"
        '                GoTo ContinueT
        '            End If
        '            If Not IsNumeric(xmlds.Tables(0).Rows(i)("valor")) Then
        '                Errores.Tables(0).Rows.Add(xmlds.Tables(0).Rows(i).ItemArray)
        '                Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("TError") = "Numero de formato inválido"
        '                GoTo ContinueT
        '            End If

        'ContinueT: Next
        '        If Errores.Tables(0).Rows.Count <> 0 Then
        '            XtraMsg("Este archivo contiene errores, favor revisarlo", MessageBoxIcon.Error)
        '            Exit Sub
        '        Else
        'Borrar las tasas de cambio
        'For i = 1 To Now.DaysInMonth(nudAnio.Value, cbMes.SelectedIndex + 1)
        '    TC.Delete(Me.cbMoneda1.SelectedValue, Me.cbMoneda2.SelectedValue, i, cbMes.SelectedIndex + 1, nudAnio.Value)
        'Next
        'For i = 0 To xmlds.Tables(0).Rows.Count - 1
        '    TC.AddItem(Me.cbMoneda1.SelectedValue, Me.cbMoneda2.SelectedValue, _
        '        DatePart(DateInterval.Day, xmlds.Tables(0).Rows(i)("fecha")), _
        '        cbMes.SelectedIndex + 1, nudAnio.Value, xmlds.Tables(0).Rows(i)("valor"))
        'Next

        'XtraMsg("Archivo Importado")

        'dsTasaCambio = TC.GetTasaCambioMes(cbMes.SelectedIndex + 1, nudAnio.Value, Me.cbMoneda1.SelectedValue, Me.cbMoneda2.SelectedValue)
        'dsTasaCambio.Tables("TASA_CAMBIO").DefaultView.AllowDelete = False
        'dsTasaCambio.Tables("TASA_CAMBIO").DefaultView.AllowNew = False
        'dsTasaCambio.Tables("TASA_CAMBIO").DefaultView.AllowEdit = True
        'dgTasaCambio.DataSource = dsTasaCambio.Tables("TASA_CAMBIO").DefaultView
        'r.FormatGenerico(dgTasaCambio, dsTasaCambio.Tables("TASA_CAMBIO"))
        ' End If
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        'dgTasaCambio.ReadOnly = False
        If sender.Text = "&Editar" Then

            Dim dr() As DataRow = DT_ROL.Select("Control = 'EditarParalea'")

            If dr.Length = 0 Then
                iVista.Columns("Tasa Cambio").OptionsColumn.AllowEdit = True
                iVista.Columns("Tasa Cambio").OptionsColumn.AllowFocus = True

                iVista.Columns("Tasa Paralela").OptionsColumn.AllowEdit = True
                iVista.Columns("Tasa Paralela").OptionsColumn.AllowFocus = True
            Else
                iVista.Columns("Tasa Paralela").OptionsColumn.AllowEdit = True
                iVista.Columns("Tasa Paralela").OptionsColumn.AllowFocus = True
            End If
            '
            sender.Text = "&Cancelar Edición"
        Else
            iVista.Columns("Tasa Cambio").OptionsColumn.AllowEdit = False
            iVista.Columns("Tasa Cambio").OptionsColumn.AllowFocus = False

            iVista.Columns("Tasa Paralela").OptionsColumn.AllowEdit = False
            iVista.Columns("Tasa Paralela").OptionsColumn.AllowFocus = False

            ShowSplash("Actualizando Cambios...")
            sender.Text = "&Editar"
            GuardarTasaEdicion()
            HideSplash()
        End If
    End Sub

    Sub GuardarTasaEdicion()


        Dim _DT As DataTable = dsTasaCambio.Tables("Tasa_Cambio").GetChanges(DataRowState.Modified)

        For i As Integer = 0 To _DT.Rows.Count - 1
            VB.SysContab.Tasa_CambioDB.Update(cbMonedaOrigen.EditValue,
                                                cbMonedaDestino.EditValue,
                                                _DT.Rows.Item(i)("Dia"),
                                                cbMeses.EditValue,
                                                sAnio.EditValue,
                                                _DT.Rows.Item(i)("Tasa Cambio"),
                                                _DT.Rows.Item(i)("Tasa Paralela"))


            'VB.SysContab.Tasa_CambioDB.Update(cbMonedaOrigen.EditValue,
            '                                  cbMonedaDestino.EditValue,
            '                                  iVista.GetRowCellValue(i, "Dia"),
            '                                  cbMeses.EditValue,
            '                                  sAnio.EditValue,
            '                                  iVista.GetRowCellValue(i, "Tasa Cambio"),
            '                                  iVista.GetRowCellValue(i, "Tasa Paralela"))
        Next

        Buscar()



        'Dim Tasa_Cambio As New VB.SysContab.Tasa_CambioDB()
        'Dim i As Integer
        'For i = 1 To Now.DaysInMonth(nudAnio.Value, cbMes.SelectedIndex + 1)
        '    Tasa_Cambio.Update(Me.cbMoneda1.SelectedValue, Me.cbMoneda2.SelectedValue, i, cbMes.SelectedIndex + 1, nudAnio.Value, dgTasaCambio.Item(i - 1, 1))
        'Next
    End Sub

    Private Sub bTasaWeb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bTasaWeb.Click
        Try
            ShowSplash("Importando de BCN...")

            Dim ws As New ws_tc.Tipo_Cambio_BCN
            Dim objElement As XmlElement
            Dim xmlNodLista As XmlNodeList
            Dim dt As New DataTable

            'CONSUMIMOS EL SERVICIO
            objElement = ws.RecuperaTC_Mes(sAnio.EditValue, cbMeses.EditValue)
            xmlNodLista = objElement.GetElementsByTagName("Tc")

            'AGREGAMOS LAS COLUMNAS AL DATATABLE 
            For Each Node As XmlNode In xmlNodLista.Item(0).ChildNodes
                Dim Col As New DataColumn(Node.Name, System.Type.GetType("System.String"))
                dt.Columns.Add(Col)
            Next

            'AGREGAR LA INFORMACION AL DATATABLE 
            For IntVal As Integer = 0 To xmlNodLista.Count - 1
                Dim dr As DataRow = dt.NewRow
                For Col As Integer = 0 To dt.Columns.Count - 1
                    If Not IsDBNull(xmlNodLista.Item(IntVal).ChildNodes(Col).InnerText) Then
                        dr(Col) = xmlNodLista.Item(IntVal).ChildNodes(Col).InnerText
                    Else
                        dr(Col) = Nothing
                    End If
                Next
                dt.Rows.Add(dr)
            Next


            'Borrar las tasas de cambio
            For i As Integer = 1 To DateTime.DaysInMonth(sAnio.EditValue, cbMeses.EditValue)
                VB.SysContab.Tasa_CambioDB.Delete(cbMonedaOrigen.EditValue, _
                                                  cbMonedaDestino.EditValue, _
                                                  i, _
                                                  cbMeses.EditValue, _
                                                  sAnio.EditValue)
            Next
            '
            For i As Integer = 0 To dt.Rows.Count - 1
                VB.SysContab.Tasa_CambioDB.AddItem(cbMonedaOrigen.EditValue,
                                                   cbMonedaDestino.EditValue,
                                                   dt.Rows.Item(i)("Dia"),
                                                   cbMeses.EditValue,
                                                   sAnio.EditValue,
                                                   dt.Rows.Item(i)("Valor"),
                                                   dt.Rows.Item(i)("Valor"))
            Next

            HideSplash()

            XtraMsg("Tasa Cambio Actualizada con éxito!!!")

            Buscar()

            'Dim Tasa_Cambio As New VB.SysContab.Tasa_CambioDB()
            'Dim Tabla As New DataTable()
            'dsTasaCambio = Tasa_Cambio.GetTasaCambioMes(cbMes.SelectedIndex + 1, nudAnio.Value, Me.cbMoneda1.SelectedValue, Me.cbMoneda2.SelectedValue)

            ''dsTasaCambio = Tasa_Cambio.GetList(cbMes.SelectedIndex + 1, cbAnio.Text)

            'dsTasaCambio.Tables("Tasa_Cambio").DefaultView.AllowDelete = False
            'dsTasaCambio.Tables("Tasa_Cambio").DefaultView.AllowNew = False
            'dsTasaCambio.Tables("Tasa_Cambio").DefaultView.AllowEdit = True

            'dgTasaCambio.DataSource = dsTasaCambio.Tables("Tasa_Cambio").DefaultView 'Tasa_Cambio.GetList().Tables("TASA_CAMBIO_TEMPORAL").DefaultView

            'Tabla = dsTasaCambio.Tables("Tasa_Cambio")
            'r.FormatGenerico(dgTasaCambio, Tabla)
        Catch ex As Exception
            HideSplash()
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        Buscar()
    End Sub

    Sub Buscar()
        If cbMonedaDestino.EditValue Is Nothing Or _
            cbMonedaOrigen.EditValue Is Nothing Then
            dsTasaCambio = Nothing
            XtraMsg("Seleccione Moneda")
            cbMonedaOrigen.Focus()
            Exit Sub
        End If
        '
        dsTasaCambio = VB.SysContab.Tasa_CambioDB.GetTasaCambioMes(cbMeses.EditValue, sAnio.EditValue, Me.cbMonedaOrigen.EditValue, Me.cbMonedaDestino.EditValue)

        If dsTasaCambio.Tables("TASA_CAMBIO").Rows.Count = 0 Then
            For i As Integer = 1 To DateTime.DaysInMonth(sAnio.EditValue, cbMeses.EditValue)
                VB.SysContab.Tasa_CambioDB.AddItem(cbMonedaOrigen.EditValue, cbMonedaDestino.EditValue, i, cbMeses.EditValue, sAnio.EditValue, 1.0, 1.0)
            Next

            dsTasaCambio = VB.SysContab.Tasa_CambioDB.GetTasaCambioMes(cbMeses.EditValue, sAnio.EditValue, Me.cbMonedaOrigen.EditValue, Me.cbMonedaDestino.EditValue)
        End If

        iGrid.DataSource = dsTasaCambio.Tables("Tasa_Cambio").DefaultView

        iVista.Columns("Tasa Cambio").OptionsColumn.AllowEdit = False
        iVista.Columns("Tasa Cambio").OptionsColumn.AllowFocus = False
        cmdModificar.Text = "&Editar"
    End Sub

    Private Sub sAnio_EditValueChanged(sender As Object, e As EventArgs) Handles sAnio.EditValueChanged
        Combo(cbMeses, ObtieneDatos("sp_MesesList", sAnio.EditValue))
    End Sub

    Private Sub frmTasaCambio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        TC.GetTasaCambio(
            MonedaBase,
            VB.SysContab.Rutinas.Fecha().Date)

        ShowTCambio(TC.TC_Oficial)
    End Sub
End Class
