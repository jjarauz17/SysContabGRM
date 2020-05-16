Imports System
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors

Public Class frmListaPedidos
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmListaPedidos = Nothing

    Public Shared Function Instance() As frmListaPedidos
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmListaPedidos()
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
    Friend WithEvents cmdOrdenCompra As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPedidosSugerido As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdFacturar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents fHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cbEstado As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents frmListaPedidosConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
    Friend WithEvents bDiseno As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbEstadoitem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents fDesdeitem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents fHastaitem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bAprobar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents gridPedidos As DevExpress.XtraGrid.GridControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaPedidos))
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.bExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.frmListaPedidosConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.bAprobar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdFacturar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.bDiseno = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdPedidosSugerido = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdOrdenCompra = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.cbEstado = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.fHasta = New DevExpress.XtraEditors.DateEdit()
        Me.fDesde = New DevExpress.XtraEditors.DateEdit()
        Me.gridPedidos = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.cbEstadoitem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.fDesdeitem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.fHastaitem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
        CType(Me.frmListaPedidosConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmListaPedidosConvertedLayout.SuspendLayout()
        CType(Me.cbEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbEstadoitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fDesdeitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fHastaitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bExportar
        '
        Me.bExportar.Enabled = False
        Me.bExportar.Image = CType(resources.GetObject("bExportar.Image"), System.Drawing.Image)
        Me.bExportar.Location = New System.Drawing.Point(811, 380)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(95, 38)
        Me.bExportar.StyleController = Me.frmListaPedidosConvertedLayout
        Me.bExportar.TabIndex = 7
        Me.bExportar.Text = "E&xportar"
        '
        'frmListaPedidosConvertedLayout
        '
        Me.frmListaPedidosConvertedLayout.Controls.Add(Me.bAprobar)
        Me.frmListaPedidosConvertedLayout.Controls.Add(Me.cmdFacturar)
        Me.frmListaPedidosConvertedLayout.Controls.Add(Me.cmdSalir)
        Me.frmListaPedidosConvertedLayout.Controls.Add(Me.bExportar)
        Me.frmListaPedidosConvertedLayout.Controls.Add(Me.bDiseno)
        Me.frmListaPedidosConvertedLayout.Controls.Add(Me.cmdPedidosSugerido)
        Me.frmListaPedidosConvertedLayout.Controls.Add(Me.cmdOrdenCompra)
        Me.frmListaPedidosConvertedLayout.Controls.Add(Me.cmdBorrar)
        Me.frmListaPedidosConvertedLayout.Controls.Add(Me.cmdImprimir)
        Me.frmListaPedidosConvertedLayout.Controls.Add(Me.SimpleButton1)
        Me.frmListaPedidosConvertedLayout.Controls.Add(Me.cmdModificar)
        Me.frmListaPedidosConvertedLayout.Controls.Add(Me.cmdNuevo)
        Me.frmListaPedidosConvertedLayout.Controls.Add(Me.cbEstado)
        Me.frmListaPedidosConvertedLayout.Controls.Add(Me.fHasta)
        Me.frmListaPedidosConvertedLayout.Controls.Add(Me.fDesde)
        Me.frmListaPedidosConvertedLayout.Controls.Add(Me.gridPedidos)
        Me.frmListaPedidosConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmListaPedidosConvertedLayout.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem13})
        Me.frmListaPedidosConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.frmListaPedidosConvertedLayout.Name = "frmListaPedidosConvertedLayout"
        Me.frmListaPedidosConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(358, 103, 250, 294)
        Me.frmListaPedidosConvertedLayout.Root = Me.LayoutControlGroup1
        Me.frmListaPedidosConvertedLayout.Size = New System.Drawing.Size(1008, 430)
        Me.frmListaPedidosConvertedLayout.TabIndex = 3
        '
        'bAprobar
        '
        Me.bAprobar.Appearance.Options.UseTextOptions = True
        Me.bAprobar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bAprobar.Enabled = False
        Me.bAprobar.Image = CType(resources.GetObject("bAprobar.Image"), System.Drawing.Image)
        Me.bAprobar.Location = New System.Drawing.Point(608, 380)
        Me.bAprobar.Name = "bAprobar"
        Me.bAprobar.Size = New System.Drawing.Size(91, 38)
        Me.bAprobar.StyleController = Me.frmListaPedidosConvertedLayout
        Me.bAprobar.TabIndex = 6
        Me.bAprobar.Text = "&Aprobar Pedido"
        '
        'cmdFacturar
        '
        Me.cmdFacturar.Appearance.Options.UseTextOptions = True
        Me.cmdFacturar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdFacturar.Enabled = False
        Me.cmdFacturar.Location = New System.Drawing.Point(835, 323)
        Me.cmdFacturar.Name = "cmdFacturar"
        Me.cmdFacturar.Size = New System.Drawing.Size(159, 22)
        Me.cmdFacturar.StyleController = Me.frmListaPedidosConvertedLayout
        Me.cmdFacturar.TabIndex = 4
        Me.cmdFacturar.Text = "&Registro de Datos de Factura"
        Me.cmdFacturar.Visible = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = Global.SysContab.My.Resources.Resources._115
        Me.cmdSalir.Location = New System.Drawing.Point(910, 380)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(86, 38)
        Me.cmdSalir.StyleController = Me.frmListaPedidosConvertedLayout
        Me.cmdSalir.TabIndex = 8
        Me.cmdSalir.Text = "&Salir"
        '
        'bDiseno
        '
        Me.bDiseno.Enabled = False
        Me.bDiseno.Image = CType(resources.GetObject("bDiseno.Image"), System.Drawing.Image)
        Me.bDiseno.Location = New System.Drawing.Point(722, 380)
        Me.bDiseno.Name = "bDiseno"
        Me.bDiseno.Size = New System.Drawing.Size(85, 38)
        Me.bDiseno.StyleController = Me.frmListaPedidosConvertedLayout
        Me.bDiseno.TabIndex = 9
        Me.bDiseno.Text = "&Diseño"
        '
        'cmdPedidosSugerido
        '
        Me.cmdPedidosSugerido.Appearance.Options.UseTextOptions = True
        Me.cmdPedidosSugerido.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdPedidosSugerido.Enabled = False
        Me.cmdPedidosSugerido.Image = CType(resources.GetObject("cmdPedidosSugerido.Image"), System.Drawing.Image)
        Me.cmdPedidosSugerido.Location = New System.Drawing.Point(295, 380)
        Me.cmdPedidosSugerido.Name = "cmdPedidosSugerido"
        Me.cmdPedidosSugerido.Size = New System.Drawing.Size(100, 38)
        Me.cmdPedidosSugerido.StyleController = Me.frmListaPedidosConvertedLayout
        Me.cmdPedidosSugerido.TabIndex = 2
        Me.cmdPedidosSugerido.Text = "&Pedidos Sugeridos "
        '
        'cmdOrdenCompra
        '
        Me.cmdOrdenCompra.Appearance.Options.UseTextOptions = True
        Me.cmdOrdenCompra.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdOrdenCompra.Enabled = False
        Me.cmdOrdenCompra.Image = CType(resources.GetObject("cmdOrdenCompra.Image"), System.Drawing.Image)
        Me.cmdOrdenCompra.Location = New System.Drawing.Point(399, 380)
        Me.cmdOrdenCompra.Name = "cmdOrdenCompra"
        Me.cmdOrdenCompra.Size = New System.Drawing.Size(97, 38)
        Me.cmdOrdenCompra.StyleController = Me.frmListaPedidosConvertedLayout
        Me.cmdOrdenCompra.TabIndex = 3
        Me.cmdOrdenCompra.Text = "&Orden de Compra"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.Image = CType(resources.GetObject("cmdBorrar.Image"), System.Drawing.Image)
        Me.cmdBorrar.Location = New System.Drawing.Point(199, 380)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(92, 38)
        Me.cmdBorrar.StyleController = Me.frmListaPedidosConvertedLayout
        Me.cmdBorrar.TabIndex = 6
        Me.cmdBorrar.Text = "&Borrar"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.Location = New System.Drawing.Point(500, 380)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(104, 38)
        Me.cmdImprimir.StyleController = Me.frmListaPedidosConvertedLayout
        Me.cmdImprimir.TabIndex = 5
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = Global.SysContab.My.Resources.Resources.Find
        Me.SimpleButton1.Location = New System.Drawing.Point(201, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(100, 44)
        Me.SimpleButton1.StyleController = Me.frmListaPedidosConvertedLayout
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "&Buscar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.Image = CType(resources.GetObject("cmdModificar.Image"), System.Drawing.Image)
        Me.cmdModificar.Location = New System.Drawing.Point(102, 380)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(93, 38)
        Me.cmdModificar.StyleController = Me.frmListaPedidosConvertedLayout
        Me.cmdModificar.TabIndex = 1
        Me.cmdModificar.Text = "&Editar"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.Image = CType(resources.GetObject("cmdNuevo.Image"), System.Drawing.Image)
        Me.cmdNuevo.Location = New System.Drawing.Point(12, 380)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(86, 38)
        Me.cmdNuevo.StyleController = Me.frmListaPedidosConvertedLayout
        Me.cmdNuevo.TabIndex = 0
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'cbEstado
        '
        Me.cbEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbEstado.Location = New System.Drawing.Point(699, 28)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstado.Properties.Appearance.Options.UseFont = True
        Me.cbEstado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbEstado.Properties.Items.AddRange(New Object() {"Todos", "Pendientes de Orden de Compra", "Orden de Compra Registrada", "Cancelados"})
        Me.cbEstado.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbEstado.Size = New System.Drawing.Size(297, 22)
        Me.cbEstado.StyleController = Me.frmListaPedidosConvertedLayout
        Me.cbEstado.TabIndex = 1
        '
        'fHasta
        '
        Me.fHasta.EditValue = Nothing
        Me.fHasta.EnterMoveNextControl = True
        Me.fHasta.Location = New System.Drawing.Point(52, 36)
        Me.fHasta.Name = "fHasta"
        Me.fHasta.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.fHasta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fHasta.Properties.Appearance.Options.UseFont = True
        Me.fHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fHasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.fHasta.Properties.Mask.EditMask = "ddMMyy"
        Me.fHasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.fHasta.Size = New System.Drawing.Size(145, 20)
        Me.fHasta.StyleController = Me.frmListaPedidosConvertedLayout
        Me.fHasta.TabIndex = 4
        '
        'fDesde
        '
        Me.fDesde.EditValue = Nothing
        Me.fDesde.EnterMoveNextControl = True
        Me.fDesde.Location = New System.Drawing.Point(52, 12)
        Me.fDesde.Name = "fDesde"
        Me.fDesde.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.fDesde.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fDesde.Properties.Appearance.Options.UseFont = True
        Me.fDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fDesde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.fDesde.Properties.Mask.EditMask = "ddMMyy"
        Me.fDesde.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.fDesde.Size = New System.Drawing.Size(145, 20)
        Me.fDesde.StyleController = Me.frmListaPedidosConvertedLayout
        Me.fDesde.TabIndex = 3
        '
        'gridPedidos
        '
        Me.gridPedidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridLevelNode2.RelationName = "Level1"
        Me.gridPedidos.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.gridPedidos.Location = New System.Drawing.Point(12, 60)
        Me.gridPedidos.MainView = Me.GridView1
        Me.gridPedidos.Name = "gridPedidos"
        Me.gridPedidos.Size = New System.Drawing.Size(984, 316)
        Me.gridPedidos.TabIndex = 1
        Me.gridPedidos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.ColumnPanelRowHeight = 40
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn14, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn15})
        Me.GridView1.GridControl = Me.gridPedidos
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "#Sistema"
        Me.GridColumn1.FieldName = "No. Pedido"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.AllowFocus = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 69
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "#Pedido"
        Me.GridColumn14.FieldName = "NoPedidoAlterno"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        Me.GridColumn14.OptionsColumn.AllowFocus = False
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 1
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Fecha"
        Me.GridColumn2.FieldName = "Fecha"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 110
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Fecha de Entrega"
        Me.GridColumn3.FieldName = "Fecha Entrega"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 110
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Proveedor"
        Me.GridColumn4.FieldName = "Proveedor"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 216
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Total"
        Me.GridColumn5.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "Total"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:n2}")})
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        Me.GridColumn5.Width = 104
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Estado"
        Me.GridColumn6.FieldName = "Estado"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 6
        Me.GridColumn6.Width = 110
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "No. Orden"
        Me.GridColumn7.FieldName = "No. Orden"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 8
        Me.GridColumn7.Width = 76
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Tipo Pedido"
        Me.GridColumn8.FieldName = "TipoPedido"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Width = 88
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Gerencia Comercial"
        Me.GridColumn9.FieldName = "Aprobar"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 9
        Me.GridColumn9.Width = 72
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Codigo"
        Me.GridColumn10.FieldName = "Codigo"
        Me.GridColumn10.Name = "GridColumn10"
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Gerencia Financiera"
        Me.GridColumn11.FieldName = "Aprobar2"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 10
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Confirmar"
        Me.GridColumn12.FieldName = "Confirmar"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 11
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Terminos"
        Me.GridColumn13.FieldName = "Termino Pago"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.OptionsColumn.AllowFocus = False
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 7
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Usuario"
        Me.GridColumn15.FieldName = "Usuario"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.OptionsColumn.AllowFocus = False
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 12
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.cmdFacturar
        Me.LayoutControlItem13.CustomizationFormText = "LayoutControlItem13"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(823, 311)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(163, 42)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.cbEstadoitem, Me.fDesdeitem, Me.fHastaitem, Me.LayoutControlItem6, Me.EmptySpaceItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.EmptySpaceItem1, Me.LayoutControlItem10, Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1008, 430)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.gridPedidos
        Me.LayoutControlItem2.CustomizationFormText = "gridPedidositem"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem2.Name = "gridPedidositem"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(988, 320)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'cbEstadoitem
        '
        Me.cbEstadoitem.Control = Me.cbEstado
        Me.cbEstadoitem.CustomizationFormText = "Estado:"
        Me.cbEstadoitem.Location = New System.Drawing.Point(687, 0)
        Me.cbEstadoitem.MaxSize = New System.Drawing.Size(301, 48)
        Me.cbEstadoitem.MinSize = New System.Drawing.Size(301, 48)
        Me.cbEstadoitem.Name = "cbEstadoitem"
        Me.cbEstadoitem.Size = New System.Drawing.Size(301, 48)
        Me.cbEstadoitem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.cbEstadoitem.Text = "Estado:"
        Me.cbEstadoitem.TextLocation = DevExpress.Utils.Locations.Top
        Me.cbEstadoitem.TextSize = New System.Drawing.Size(37, 13)
        '
        'fDesdeitem
        '
        Me.fDesdeitem.Control = Me.fDesde
        Me.fDesdeitem.CustomizationFormText = "Desde:"
        Me.fDesdeitem.Location = New System.Drawing.Point(0, 0)
        Me.fDesdeitem.MaxSize = New System.Drawing.Size(189, 24)
        Me.fDesdeitem.MinSize = New System.Drawing.Size(189, 24)
        Me.fDesdeitem.Name = "fDesdeitem"
        Me.fDesdeitem.Size = New System.Drawing.Size(189, 24)
        Me.fDesdeitem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.fDesdeitem.Text = "Desde:"
        Me.fDesdeitem.TextSize = New System.Drawing.Size(37, 13)
        '
        'fHastaitem
        '
        Me.fHastaitem.Control = Me.fHasta
        Me.fHastaitem.CustomizationFormText = "Hasta:"
        Me.fHastaitem.Location = New System.Drawing.Point(0, 24)
        Me.fHastaitem.MaxSize = New System.Drawing.Size(189, 24)
        Me.fHastaitem.MinSize = New System.Drawing.Size(189, 24)
        Me.fHastaitem.Name = "fHastaitem"
        Me.fHastaitem.Size = New System.Drawing.Size(189, 24)
        Me.fHastaitem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.fHastaitem.Text = "Hasta:"
        Me.fHastaitem.TextSize = New System.Drawing.Size(37, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.SimpleButton1
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(189, 0)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(104, 48)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(104, 48)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(104, 48)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(293, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(394, 48)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmdNuevo
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 368)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(90, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(90, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(90, 42)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmdModificar
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(90, 368)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmdPedidosSugerido
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(283, 368)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(104, 42)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(104, 42)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(104, 42)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cmdOrdenCompra
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(387, 368)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(101, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(101, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(101, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmdImprimir
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(488, 368)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(108, 42)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(108, 42)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(108, 42)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.bDiseno
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(710, 368)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(89, 42)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(89, 42)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(89, 42)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.bExportar
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(799, 368)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cmdSalir
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(898, 368)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(90, 42)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(90, 42)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(90, 42)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(691, 368)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(19, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cmdBorrar
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(187, 368)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(96, 42)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(96, 42)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(96, 42)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.bAprobar
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(596, 368)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'frmListaPedidos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1008, 430)
        Me.Controls.Add(Me.frmListaPedidosConvertedLayout)
        Me.LookAndFeel.SkinName = "Blue"
        Me.Name = "frmListaPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.frmListaPedidosConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmListaPedidosConvertedLayout.ResumeLayout(False)
        CType(Me.cbEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbEstadoitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fDesdeitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fHastaitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Pedidos As New VB.SysContab.PedidosDB()
    Dim Proveedores As New VB.SysContab.ProveedoresDB()
    Dim r As New VB.SysContab.Rutinas()
    'Public ds As DataSet

    Private Sub frmListaPedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(frmListaPedidosConvertedLayout)

        Dim f As Date = r.Fecha()

        Me.fDesde.DateTime = New DateTime(f.Year, f.Month, 1)
        Me.fHasta.DateTime = f.Date
        '  GetCatalogoProveedores(Me.cbProveedores, Me.vProveedor, 1)
        ' Me.cbProveedores.EditValue = 0
        ' ds = Pedidos.PedidosList(0, 0)
        cbEstado.SelectedIndex = 0
        Cargar()
        CargarRegistro()

        ' Me.Text = "*** LISTA DE PEDIDOS ***"
    End Sub

    Public Sub Cargar()
        Me.gridPedidos.DataSource = Pedidos.PedidosList(0, cbEstado.SelectedIndex).Tables("Pedidos").DefaultView   ' ds.Tables("Pedidos").DefaultView
        Me.GridView1.Columns(0).SortOrder = DevExpress.Data.ColumnSortOrder.Descending
        FormatoGrid(Me.GridView1)
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If Me.GridView1.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione el Pedido")
            Exit Sub
        End If

        RegistroPedido = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "No. Pedido")
        Inicio = True
        ShowSplash()
        ' Dim f As DataGridTextBoxCombo.frmPedidosVer = DataGridTextBoxCombo.frmPedidosVer.Instance
        Dim f As frmPedidos = frmPedidos.Instance()
        '  f.TipoPedido = Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "TipoPedido") 'dgPedidos.Item(dgPedidos.CurrentRowIndex, 8).ToString
        f.IdPedido = Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "No. Pedido")

        f.MdiParent = Me.MdiParent
        f.Show()
        f.Text = "Solicitud de Pedido..."
        f.WindowState = FormWindowState.Maximized
        HideSplash()
        Inicio = False
    End Sub


    Private Sub cmdNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Inicio = True
        ShowSplash()
        Dim f As frmPedidos = frmPedidos.Instance()

        f.MdiParent = Me.MdiParent
        f.IdPedido = 0
        f.Show()
        f.Text = "Solicitud de Pedido..."
        f.WindowState = FormWindowState.Maximized
        HideSplash()
        Inicio = False
    End Sub

    'Private Sub checkBoxFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not IsNumeric(cbProveedores.EditValue) Or Not IsNumeric(Me.cbEstado.SelectedIndex) Then
    '        Exit Sub
    '    End If

    '    If checkBoxFecha.Checked = True Then
    '        ds = Pedidos.PedidosListXFecha(cbProveedores.EditValue, Me.cbEstado.SelectedIndex, Me.fDesde.DateTime.Date, Me.fHasta.DateTime.Date)
    '        Cargar()
    '        Me.fDesde.Enabled = True
    '        Me.fHasta.Enabled = True
    '    Else
    '        ds = Pedidos.PedidosList(cbProveedores.EditValue, Me.cbEstado.SelectedIndex)
    '        Cargar()
    '        Me.fDesde.Enabled = False
    '        Me.fHasta.Enabled = False
    '    End If
    'End Sub


    Private Sub cmdOrdenCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOrdenCompra.Click
        If Me.GridView1.FocusedRowHandle < 0 Then
            MsgBox("Seleccione un Pedido", MsgBoxStyle.Information)
            Exit Sub
        End If

        If AbroparPedidos Then  'Verificar Aprobacion de Pedidos 

            If Not GridView1.GetFocusedRowCellValue("Aprobar") Then
                XtraMsg("El Pedido no ha sido Aprobado por Gerencia Comercial...", MessageBoxIcon.Warning)
                Exit Sub
            End If
            '
            If Not GridView1.GetFocusedRowCellValue("Aprobar2") Then
                XtraMsg("El Pedido no ha sido Aprobado por Gerencia Financiera...", MessageBoxIcon.Warning)
                Exit Sub
            End If
            '
            If Not GridView1.GetFocusedRowCellValue("Confirmar") Then
                XtraMsg("El Pedido no ha sido Confirmado...", MessageBoxIcon.Warning)
                Exit Sub
            End If


            If GridView1.GetFocusedRowCellValue("Aprobar") And _
            GridView1.GetFocusedRowCellValue("Aprobar2") And _
            GridView1.GetFocusedRowCellValue("Confirmar") Then
                XtraMsg("El Pedido Ya Se encuentra Aprobado!")
                Exit Sub
            End If
        End If

        RegistroPedido = Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "No. Pedido")
        'RegistroPedido = dgPedidos.Item(dgPedidos.CurrentRowIndex, 0).ToString

        'If RegistroPedido = "" Then 'If dgPedidos.CurrentRowIndex = ds.Tables("Pedidos").Rows.Count - 1 Then
        '    MsgBox("Seleccione un Pedido", MsgBoxStyle.Information)
        '    Exit Sub
        'End If
        'If dgPedidos.Item(dgPedidos.CurrentRowIndex, 6).ToString = "Facturado" Then
        '    MsgBox("El Pedido ya tiene Orden de Compra", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        If Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "Estado") = "Facturado" Then
            MsgBox("El Pedido ya tiene Orden de Compra", MsgBoxStyle.Information)
            Exit Sub
        End If
        'If ds.Tables("Pedidos").Rows(dgPedidos.CurrentRowIndex).Item("Estado") = "Facturado" Then
        '    MsgBox("El Pedido ya tiene Orden de Compra", MsgBoxStyle.Information)
        '    Exit Sub
        'End If
        Inicio = True

        Dim f As DataGridTextBoxCombo.frmOrdenesCompra = f.Instance

        f.CargarPedido = True
        f.TipoPedido = Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "TipoPedido") 'dgPedidos.Item(dgPedidos.CurrentRowIndex, 8).ToString
        f.Pedido = Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "No. Pedido")  'dgPedidos.Item(dgPedidos.CurrentRowIndex, 0).ToString
        f.lbOrigen.Text = "Pedidos"
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized

        Inicio = False
    End Sub

    Private Sub cmdPedidosSugerido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPedidosSugerido.Click
        Inicio = True

        Dim f As DataGridTextBoxCombo.frmPedidosSugerido = DataGridTextBoxCombo.frmPedidosSugerido.Instance

        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized

        Inicio = False
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        If Me.GridView1.FocusedRowHandle < 0 Then
            MsgBox("Seleccione un Pedido", MsgBoxStyle.Information)
            Exit Sub
        End If

        'If dgPedidos.Item(dgPedidos.CurrentRowIndex, 0).ToString = "" Then
        '    MsgBox("Seleccione un Pedido", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        If Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "No. Orden").ToString <> "" Then
            MsgBox("No se puede borrar el Pedido, este ya tiene una Orden de Compra", MsgBoxStyle.Critical)
            Exit Sub
        End If

        'If dgPedidos.Item(dgPedidos.CurrentRowIndex, 7).ToString <> "" Then
        '    MsgBox("No se puede borrar el Pedido, este ya tiene una Orden de Compra", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If

        If MsgBox("Esta seguro que quiere borrar el Pedido: " & Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "No. Pedido"), MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            Exit Sub
        Else
            Try

                DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
                DBConnFacturas.Open()
                transaccionFacturas = DBConnFacturas.BeginTransaction
                'Pedidos.DeletePedidosLineas(dgPedidos.Item(dgPedidos.CurrentRowIndex, 0).ToString)
                'Pedidos.DeletePedidos(dgPedidos.Item(dgPedidos.CurrentRowIndex, 0).ToString)

                Pedidos.DeletePedidosLineas(Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "No. Pedido"))
                Pedidos.DeletePedidos(Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "No. Pedido"))
                VB.SysContab.Rutinas.okTransaccion()

                Cargar()
                CargarRegistro()

                'If checkBoxFecha.Checked = True Then
                '    ds = Pedidos.PedidosListXFecha(cbProveedores.EditValue, Me.cbEstado.SelectedIndex, Me.fDesde.DateTime.Date, Me.fHasta.DateTime.Date)
                '    'dgPedidos.DataSource = ds.Tables("Pedidos").DefaultView
                '    Me.gridPedidos.DataSource = ds.Tables("Pedidos").DefaultView
                'Else
                '    ds = Pedidos.PedidosList(cbProveedores.EditValue, Me.cbEstado.SelectedIndex)
                '    'dgPedidos.DataSource = ds.Tables("Pedidos").DefaultView
                '    Me.gridPedidos.DataSource = ds.Tables("Pedidos").DefaultView
                'End If
            Catch ex As Exception
                XtraMsg(ex.Message, MessageBoxIcon.Error)
                VB.SysContab.Rutinas.ErrorTransaccion()
            End Try
        End If
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        If Me.GridView1.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Pedido")
            Exit Sub
        End If

        Dim Cadena As String
        Dim Temp As Boolean = False
        Dim Data() As Byte

        Try
            Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 19 AND Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())
            Temp = True
            Dim Tamano As Integer
            Tamano = Data.GetUpperBound(0)

            Cadena = Application.StartupPath & "\RptOrdenCompra.repx"
            If File.Exists(Cadena) Then Kill(Cadena)
            Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
            Archivo.Write(Data, 0, Tamano)
            Archivo.Close()

        Catch ex As Exception
            Temp = False            
        End Try

        Dim Rep As rptOrdenCompra

        If Temp = True Then
            Rep = XtraReport.FromFile(Application.StartupPath & "\RptOrdenCompra.repx", True)
        Else
            Rep = New rptOrdenCompra
        End If

        Rep.DataSource = ObtieneDatos("JAR_PedidoCompraImpreso '" & Me.GridView1.GetFocusedRowCellValue("No. Pedido") & "'," & EmpresaActual)

        Rep.ShowPrintMarginsWarning = False
        Rep.BringToFront()
        Rep.ShowRibbonPreview()
        'If dgPedidos.Item(dgPedidos.CurrentRowIndex, 0).ToString = "" Then 'If dgPedidos.CurrentRowIndex = ds.Tables("Pedidos").Rows.Count - 1 Then
        '    MsgBox("Seleccione un Pedido", MsgBoxStyle.Information)
        '    Exit Sub
        'End If
        'Pedidos.ImprimirOrden(Me.dgPedidos.Item(Me.dgPedidos.CurrentRowIndex, 0))
        'Pedidos.ImprimirOrden(Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "No. Pedido"))
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bExportar.Click
        'Help.ShowHelp(Me, "ayuda/ProvPedi.chm")
        frmExportarImprimir.Mostrar(gridPedidos)
    End Sub

    Public Sub CargarRegistro()

        If AbroparPedidos = False Then
            Me.GridView1.Columns("Aprobar").Visible = False
        End If

        If GridView1.DataRowCount <> 0 Then
            RegistroPedido = Me.GridView1.GetRowCellValue(0, "No. Pedido")
        Else
            RegistroPedido = "Vacio"
        End If


        'If ds.Tables("Pedidos").Rows.Count <> 0 Then
        '    RegistroPedido = Me.GridView1.GetRowCellValue(0, "No. Pedido")
        '    'RegistroPedido = dgPedidos.Item(0, 0).ToString
        'Else
        '    RegistroPedido = "Vacio"
        'End If
    End Sub

    Private Sub cmdFacturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFacturar.Click
        Dim Verify As New VB.SysContab.Facturas_ComprasDB

        If Me.GridView1.FocusedRowHandle < 0 Then
            MsgBox("Favor seleccione un pedido con orden de compra.", MsgBoxStyle.Information)
            Exit Sub
        End If

        If AbroparPedidos Then  'Verificar Aprobacion de Pedidos 
            If Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "Aprobar") = False Then
                MsgBox("El Pedido debe Aprobarse para Poder ser Procesado", MsgBoxStyle.Information)
                Exit Sub
            End If
        End If

        'If dgPedidos.Item(dgPedidos.CurrentRowIndex, 0).ToString = "" Then 'If dgPedidos.CurrentRowIndex = ds.Tables("Pedidos").Rows.Count - 1 Then
        '    MsgBox("Favor seleccione un pedido con orden de compra.", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        If Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "No. Orden").ToString = "" Then
            MsgBox("Este pedido aun no tiene un no. de orden de compra.", MsgBoxStyle.Information)
            Exit Sub
        End If

        'If dgPedidos.Item(dgPedidos.CurrentRowIndex, 7).ToString = "" Then
        '    MsgBox("Este pedido aun no tiene un no. de orden de compra.", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'If Verify.VerifyOrder(dgPedidos.Item(dgPedidos.CurrentRowIndex, 7)) = "F" Then
        '    MsgBox("Este pedido ya fue facturado.", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        If Verify.VerifyOrder(Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "No. Orden")) = "F" Then
            MsgBox("Este pedido ya fue facturado.", MsgBoxStyle.Information)
            Exit Sub
        End If

        Inicio = True

        'If dgPedidos.Item(dgPedidos.CurrentRowIndex, 8) = 1 Then
        If Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "TipoPedido") = 1 Then
            Dim f As frmFacturasCompra = frmFacturasCompra.Instance
            f.txtOrden.Text = Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "No. Orden") 'dgPedidos.Item(dgPedidos.CurrentRowIndex, 7)
            f.etOrigen.Text = 1 'dgPedidos.Item(dgPedidos.CurrentRowIndex, 9)
            'f.rbProductos.Checked = True
            f.gbTipo.Enabled = False
            f.gbTipo.EditValue = 1

            f.MdiParent = Me.MdiParent
            f.lbOrigen.Text = "Pedidos"
            f.Show()
            f.WindowState = FormWindowState.Maximized
            f.txtfactura.Focus()
            f.Nuevo = False

            'ElseIf dgPedidos.Item(dgPedidos.CurrentRowIndex, 8) = 2 Then
        ElseIf Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "TipoPedido") = 2 Then
            Dim f As frmFacturasCompra = frmFacturasCompra.Instance
            f.txtOrden.Text = Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "No. Orden") 'dgPedidos.Item(dgPedidos.CurrentRowIndex, 7)
            f.etOrigen.Text = 1 'dgPedidos.Item(dgPedidos.CurrentRowIndex, 9)
            'f.rbProductos.Checked = True
            f.gbTipo.Enabled = False
            f.gbTipo.EditValue = 4

            f.MdiParent = Me.MdiParent
            f.lbOrigen.Text = "Pedidos"
            f.Show()
            f.WindowState = FormWindowState.Maximized
            f.txtfactura.Focus()
            f.Nuevo = False

            'Dim f1 As DataGridTextBoxCombo.frmFacturasCompraCC = f1.Instance
            'f1.txtOrden.Text = Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "No. Orden") 'dgPedidos.Item(dgPedidos.CurrentRowIndex, 7)
            'f1.etOrigen.Text = 1 'Me.dgOrdenes.Item(Me.dgOrdenes.CurrentRowIndex, 9)
            'f1.rbInventario.Checked = True
            'f1.gbTipo.Enabled = False
            'f1.MdiParent = Me.MdiParent
            'f1.lbOrigen.Text = "Pedidos"
            'f1.Show()
            'f1.WindowState = FormWindowState.Maximized
            'f1.txtFactura.Focus()
            'f1.Nuevo = False
        End If
        Inicio = False
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        'If AbroparPedidos = False Then  'Si la Empresa No requiere Codigo de Aprobación
        '    Exit Sub
        'End If
        ''
        'Dim DT As DataTable = ObtieneDatos("JAR_GetCodigos 'PCOMPRA'," & EmpresaActual)
        ' ''
        'If DT.Rows.Count = 0 Then
        '    XtraMsg("No Existe Código de Aprobación!", MessageBoxIcon.Error)
        '    GridView1.SetRowCellValue(e.RowHandle, "Aprobar", False)
        '    GridView1.RefreshData()
        '    Exit Sub
        'End If
        ''
        'If e.Column.FieldName = "Aprobar" Then
        '    If GridView1.GetRowCellValue(e.RowHandle, "Aprobar") Then
        '        '    GridView1.SetRowCellValue(e.RowHandle, "Aprobar", True)
        '        'Else
        '        With frmAprobarPedido
        '            .ShowDialog()
        '            If .Ok = "SI" Then
        '                If .txtCodigo.Text = DT.Rows.Item(0)("Codigo1") Then
        '                    GridView1.SetRowCellValue(e.RowHandle, "Aprobar", True)
        '                    GuardarArpbacion(GridView1.GetRowCellValue(e.RowHandle, "No. Pedido"), 1)
        '                    XtraMsg("Pedido Aprobado por Gerencia Comercial!")
        '                Else
        '                    XtraMsg("Codigo Inválido", MessageBoxIcon.Error)
        '                    GridView1.SetRowCellValue(e.RowHandle, "Aprobar", False)
        '                    GridView1.RefreshData()
        '                End If
        '            Else
        '                GridView1.SetRowCellValue(e.RowHandle, "Aprobar", False)
        '                GridView1.RefreshData()
        '            End If
        '            .Dispose()
        '        End With
        '    End If
        '    Me.GridView1.RefreshData()
        'End If
    End Sub

    Private Sub GridView1_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanging
        'If AbroparPedidos = False Then  'Si la Empresa No requiere Codigo de Aprobación
        '    Exit Sub
        'End If
        ''
        'Dim DT As DataTable = ObtieneDatos("JAR_GetCodigos 'PCOMPRA'," & EmpresaActual)
        ''
        'If DT.Rows.Count = 0 Then
        '    XtraMsg("No Existe Código de Aprobación!", MessageBoxIcon.Error)
        '    GridView1.SetRowCellValue(e.RowHandle, "Aprobar", False)
        '    GridView1.RefreshData()
        '    Exit Sub
        'End If
        ' ''
        'If e.Column.FieldName = "Aprobar" Then
        '    If GridView1.GetRowCellValue(e.RowHandle, "Aprobar") = True Then
        '        GridView1.SetRowCellValue(e.RowHandle, "Aprobar", True)
        '    Else
        '        With frmAprobarPedido
        '            .ShowDialog()
        '            If .Ok = "SI" Then
        '                If .txtCodigo.Text = DT.Rows.Item(0)("Codigo1") Then
        '                    GridView1.SetRowCellValue(e.RowHandle, "Aprobar", True)
        '                    GuardarArpbacion(GridView1.GetRowCellValue(e.RowHandle, "No. Pedido"), 1)
        '                    XtraMsg("Pedido Aprobado por Gerencia Comercial!")
        '                Else
        '                    XtraMsg("Codigo Inválido", MessageBoxIcon.Error)
        '                    GridView1.SetRowCellValue(e.RowHandle, "Aprobar", False)
        '                    GridView1.RefreshData()
        '                End If
        '            Else
        '                GridView1.SetRowCellValue(e.RowHandle, "Aprobar", False)
        '                GridView1.RefreshData()
        '            End If
        '            .Dispose()
        '        End With
        '    End If
        '    Me.GridView1.RefreshData()
        'End If
        ''
        'If e.Column.FieldName = "Aprobar2" Then
        '    If GridView1.GetRowCellValue(e.RowHandle, "Aprobar2") = True Then
        '        GridView1.SetRowCellValue(e.RowHandle, "Aprobar2", True)
        '    Else
        '        With frmAprobarPedido
        '            .ShowDialog()
        '            If .Ok = "SI" Then
        '                If .txtCodigo.Text = DT.Rows.Item(0)("Codigo2") Then
        '                    GridView1.SetRowCellValue(e.RowHandle, "Aprobar2", True)
        '                    GuardarArpbacion()
        '                    XtraMsg("Pedido Aprobado por Gerencia Financiera!")
        '                Else
        '                    XtraMsg("Codigo Inválido", MessageBoxIcon.Error)
        '                    GridView1.SetRowCellValue(e.RowHandle, "Aprobar2", False)
        '                End If
        '            Else
        '                GridView1.SetRowCellValue(e.RowHandle, "Aprobar", False)
        '            End If
        '            .Dispose()
        '        End With
        '    End If
        '    Me.GridView1.RefreshData()
        'End If
        ''
        'If e.Column.FieldName = "Confirmar" Then
        '    If GridView1.GetRowCellValue(e.RowHandle, "Confirmar") = True Then
        '        GridView1.SetRowCellValue(e.RowHandle, "Confirmar", True)
        '    Else
        '        With frmAprobarPedido
        '            .ShowDialog()
        '            If .Ok = "SI" Then
        '                If .txtCodigo.Text = DT.Rows.Item(0)("Codigo3") Then
        '                    GridView1.SetRowCellValue(e.RowHandle, "Confirmar", True)
        '                    GuardarArpbacion()
        '                    XtraMsg("Pedido Confirmado!")
        '                Else
        '                    XtraMsg("Codigo Inválido", MessageBoxIcon.Error)
        '                    GridView1.SetRowCellValue(e.RowHandle, "Confirmar", False)
        '                End If
        '            Else
        '                GridView1.SetRowCellValue(e.RowHandle, "Aprobar", False)
        '            End If
        '            .Dispose()
        '        End With
        '    End If
        '    Me.GridView1.RefreshData()
        'End If

    End Sub

    Sub GuardarArpbacion(Numero As String, op As Integer)

        GuardaDatos("JAR_GuardarAprobacion '" & Numero & "'," & op & "," & EmpresaActual)

        'Dim sSQL As String = String.Empty
        'Dim Con As New SqlConnection(r.AbrirConexion)
        'If Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "TipoPedido") = 1 Then
        '    sSQL = "UPDATE PEDIDOS SET Aprobado = 1 WHERE Ped_ID = " & Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "No. Pedido")
        'Else
        '    sSQL = "UPDATE PEDIDOSCC SET Aprobado = 1 WHERE Ped_ID = " & Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "No. Pedido")
        'End If

        'Try
        '    Con.Open()
        '    Dim cmd As New SqlCommand(sSQL, Con)
        '    cmd.ExecuteNonQuery()

        '    Con.Close()
        'Catch ex As Exception
        '    Con.Close()
        '    MsgBox("ERROR al Actualizar Datos", MsgBoxStyle.Critical)
        'End Try
    End Sub

    'Private Sub fDesde_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fDesde.EditValueChanged
    '    If checkBoxFecha.Checked = True Then
    '        ds = Pedidos.PedidosListXFecha(cbProveedores.EditValue, Me.cbEstado.SelectedIndex, Me.fDesde.DateTime.Date, Me.fHasta.DateTime.Date)
    '        Cargar()
    '    End If
    'End Sub

    'Private Sub fHasta_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fHasta.EditValueChanged
    '    If checkBoxFecha.Checked = True Then
    '        ds = Pedidos.PedidosListXFecha(cbProveedores.EditValue, Me.cbEstado.SelectedIndex, Me.fDesde.DateTime.Date, Me.fHasta.DateTime.Date)
    '        Cargar()
    '    End If
    'End Sub

    'Private Sub cbProveedor_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If IsNumeric(cbProveedores.EditValue) And IsNumeric(Me.cbEstado.SelectedIndex) Then
    '        If checkBoxFecha.Checked = True Then
    '            ds = Pedidos.PedidosListXFecha(cbProveedores.EditValue, Me.cbEstado.SelectedIndex, Me.fDesde.DateTime.Date, Me.fHasta.DateTime.Date)
    '            Cargar()
    '        Else
    '            ds = Pedidos.PedidosList(cbProveedores.EditValue, Me.cbEstado.SelectedIndex)
    '            Cargar()
    '        End If
    '    End If
    'End Sub


    Private Sub cbEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEstado.SelectedIndexChanged
        Cargar()
        'If IsNumeric(cbProveedores.EditValue) And IsNumeric(Me.cbEstado.SelectedIndex) Then
        '    If checkBoxFecha.Checked = True Then
        '        ds = Pedidos.PedidosListXFecha(cbProveedores.EditValue, Me.cbEstado.SelectedIndex, Me.fDesde.DateTime.Date, Me.fHasta.DateTime.Date)
        '        Cargar
        '    Else
        '        ds = Pedidos.PedidosList(cbProveedores.EditValue, Me.cbEstado.SelectedIndex)
        '        Cargar
        '    End If
        'End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ShowSplash()
        Cargar()
        HideSplash()
    End Sub

    Private Sub bDiseno_Click(sender As Object, e As EventArgs) Handles bDiseno.Click
        With My.Forms.FrmConfiguraCheque
            .Tipo = 19
            .Text = "*** Diseñar Pedido de Compra ***"
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub GridView1_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        'If AbroparPedidos = False Then  'Si la Empresa No requiere Codigo de Aprobación
        '    Exit Sub
        'End If
        ''
        'Dim DT As DataTable = ObtieneDatos("JAR_GetCodigos 'PCOMPRA'," & EmpresaActual)
        ''
        'If DT.Rows.Count = 0 Then
        '    XtraMsg("No Existe Código de Aprobación!", MessageBoxIcon.Error)
        '    GridView1.SetRowCellValue(e.RowHandle, "Aprobar", False)
        '    GridView1.RefreshData()
        '    Exit Sub
        'End If
        ''
        'If e.Column.FieldName = "Aprobar" Then
        '    If GridView1.GetRowCellValue(e.RowHandle, "Aprobar") = True Then
        '        GridView1.SetRowCellValue(e.RowHandle, "Aprobar", True)
        '    Else
        '        With frmAprobarPedido
        '            .ShowDialog()
        '            If .Ok = "SI" Then
        '                If .txtCodigo.Text = DT.Rows.Item(0)("Codigo1") Then
        '                    GridView1.SetRowCellValue(e.RowHandle, "Aprobar", True)
        '                    GuardarArpbacion(GridView1.GetRowCellValue(e.RowHandle, "No. Pedido"), 1)
        '                    XtraMsg("Pedido Aprobado por Gerencia Comercial!")
        '                Else
        '                    XtraMsg("Codigo Inválido", MessageBoxIcon.Error)
        '                    GridView1.SetRowCellValue(e.RowHandle, "Aprobar", False)
        '                    GridView1.RefreshData()
        '                End If
        '            Else
        '                GridView1.SetRowCellValue(e.RowHandle, "Aprobar", False)
        '                GridView1.RefreshData()
        '            End If
        '            .Dispose()
        '        End With
        '    End If
        '    Me.GridView1.RefreshData()
        'End If
    End Sub

    Private Sub GridView1_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick

    End Sub

    Private Sub GridView1_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView1.ValidateRow
        'If AbroparPedidos = False Then  'Si la Empresa No requiere Codigo de Aprobación
        '    Exit Sub
        'End If
    End Sub

    Private Sub bAprobar_Click(sender As Object, e As EventArgs) Handles bAprobar.Click
        If Me.GridView1.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione el Pedido")
            Exit Sub
        End If
        '
        If GridView1.GetFocusedRowCellValue("Aprobar") And _
            GridView1.GetFocusedRowCellValue("Aprobar2") And _
            GridView1.GetFocusedRowCellValue("Confirmar") Then
            XtraMsg("El Pedido Ya Se encuentra Aprobado!")
            Exit Sub
        End If

        With frmTipoAprobado
            If GridView1.GetFocusedRowCellValue("Aprobar") Then .SimpleButton1.Enabled = False
            If GridView1.GetFocusedRowCellValue("Aprobar2") Then .SimpleButton2.Enabled = False
            If GridView1.GetFocusedRowCellValue("Confirmar") Then .SimpleButton3.Enabled = False
            .ShowDialog()
            If .Tipo <> 0 Then

                Dim DT As DataTable = ObtieneDatos("JAR_GetCodigos 'PCOMPRA'," & EmpresaActual)
                '
                If DT.Rows.Count = 0 Then
                    XtraMsg("No Existe Código de Aprobación!", MessageBoxIcon.Error)
                    Exit Sub
                End If

                If .Tipo = 1 Then   ''Aprobado por Gerencia Comercial
                    With frmAprobarPedido
                        .lyTitulo.Text = "Introduzca Código de Aprobación del Pedido de Compra" & vbCrLf & frmTipoAprobado.SimpleButton1.Text
                        .ShowDialog()
                        If .Ok = "SI" Then
                            If .txtCodigo.Text = DT.Rows.Item(0)("Codigo1") Then
                                GuardarArpbacion(GridView1.GetFocusedRowCellValue("No. Pedido"), 1)
                                XtraMsg("Pedido Aprobado por Gerencia Comercial!")
                                '
                                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Aprobar", True)
                                GridView1.RefreshData()
                            Else
                                XtraMsg("Codigo Inválido", MessageBoxIcon.Error)
                            End If
                        End If
                        .Dispose()
                    End With

                End If
                ''
                If .Tipo = 2 Then   ''Aprobado por Gerencia Financiera
                    With frmAprobarPedido
                        .lyTitulo.Text = "Introduzca Código de Aprobación del Pedido de Compra" & vbCrLf & frmTipoAprobado.SimpleButton2.Text
                        .ShowDialog()
                        If .Ok = "SI" Then
                            If .txtCodigo.Text = DT.Rows.Item(0)("Codigo2") Then
                                GuardarArpbacion(GridView1.GetFocusedRowCellValue("No. Pedido"), 2)
                                XtraMsg("Pedido Aprobado por Gerencia Financiera!")
                                '
                                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Aprobar2", True)
                                GridView1.RefreshData()
                            Else
                                XtraMsg("Codigo Inválido", MessageBoxIcon.Error)
                            End If
                        End If
                        .Dispose()
                    End With

                End If
                ''
                If .Tipo = 3 Then   ''Confirmar Pedido
                    With frmAprobarPedido
                        .lyTitulo.Text = "Introduzca Código de Aprobación del Pedido de Compra" & vbCrLf & frmTipoAprobado.SimpleButton2.Text
                        .ShowDialog()
                        If .Ok = "SI" Then
                            If .txtCodigo.Text = DT.Rows.Item(0)("Codigo3") Then
                                GuardarArpbacion(GridView1.GetFocusedRowCellValue("No. Pedido"), 3)
                                XtraMsg("Pedido Confirmado!")
                                '
                                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Confirmar", True)
                                GridView1.RefreshData()
                            Else
                                XtraMsg("Codigo Inválido", MessageBoxIcon.Error)
                            End If
                        End If
                        .Dispose()
                    End With

                End If
            End If
            .Dispose()
        End With

    End Sub
End Class
