Imports System.IO
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports ClasesBLL

Public Class frmFacturasComprasList
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmFacturasComprasList = Nothing

    Public Shared Function Instance() As frmFacturasComprasList
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmFacturasComprasList()
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
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents cmdEntradaAlmacen As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents etInicio As System.Windows.Forms.Label
    Friend WithEvents cbOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents cmdVerEntradaAlmacen As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAnular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbDestino As System.Windows.Forms.ComboBox
    Friend WithEvents cmdeditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSairi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents VFacturas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnPrintRet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnDisenoRet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Hasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Desde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dgFacturas As DevExpress.XtraGrid.GridControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturasComprasList))
        Me.cbDestino = New System.Windows.Forms.ComboBox()
        Me.btnDisenoRet = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSairi = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPrintRet = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdeditar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAnular = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdVerEntradaAlmacen = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdEntradaAlmacen = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.Hasta = New DevExpress.XtraEditors.DateEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.etInicio = New System.Windows.Forms.Label()
        Me.dgFacturas = New DevExpress.XtraGrid.GridControl()
        Me.VFacturas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Desde = New DevExpress.XtraEditors.DateEdit()
        Me.cbOrigen = New System.Windows.Forms.ComboBox()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Desde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Desde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbDestino
        '
        Me.cbDestino.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDestino.Items.AddRange(New Object() {"--Todas--", "Productos", "Inventario", "Ambos"})
        Me.cbDestino.Location = New System.Drawing.Point(433, 37)
        Me.cbDestino.Name = "cbDestino"
        Me.cbDestino.Size = New System.Drawing.Size(20, 21)
        Me.cbDestino.TabIndex = 6
        '
        'btnDisenoRet
        '
        Me.btnDisenoRet.Appearance.Options.UseTextOptions = True
        Me.btnDisenoRet.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnDisenoRet.Enabled = False
        Me.btnDisenoRet.ImageOptions.SvgImage = CType(resources.GetObject("btnDisenoRet.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnDisenoRet.Location = New System.Drawing.Point(12, 469)
        Me.btnDisenoRet.Name = "btnDisenoRet"
        Me.btnDisenoRet.Size = New System.Drawing.Size(118, 38)
        Me.btnDisenoRet.StyleController = Me.LayoutControl2
        Me.btnDisenoRet.TabIndex = 10
        Me.btnDisenoRet.Text = "&Diseño Retención"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.cmdExportar)
        Me.LayoutControl2.Controls.Add(Me.cmdSalir)
        Me.LayoutControl2.Controls.Add(Me.btnDisenoRet)
        Me.LayoutControl2.Controls.Add(Me.cmdNuevo)
        Me.LayoutControl2.Controls.Add(Me.cmdSairi)
        Me.LayoutControl2.Controls.Add(Me.btnPrintRet)
        Me.LayoutControl2.Controls.Add(Me.cmdModificar)
        Me.LayoutControl2.Controls.Add(Me.cmdeditar)
        Me.LayoutControl2.Controls.Add(Me.cmdImprimir)
        Me.LayoutControl2.Controls.Add(Me.cmdAnular)
        Me.LayoutControl2.Controls.Add(Me.btnBorrar)
        Me.LayoutControl2.Controls.Add(Me.cmdVerEntradaAlmacen)
        Me.LayoutControl2.Controls.Add(Me.cmdEntradaAlmacen)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1364, 543, 250, 350)
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(143, 599)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'cmdExportar
        '
        Me.cmdExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExportar.Enabled = False
        Me.cmdExportar.ImageOptions.SvgImage = CType(resources.GetObject("cmdExportar.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.cmdExportar.Location = New System.Drawing.Point(12, 511)
        Me.cmdExportar.Name = "cmdExportar"
        Me.cmdExportar.Size = New System.Drawing.Size(119, 36)
        Me.cmdExportar.StyleController = Me.LayoutControl2
        Me.cmdExportar.TabIndex = 11
        Me.cmdExportar.Text = "E&xportar"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.ImageOptions.SvgImage = CType(resources.GetObject("cmdSalir.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.cmdSalir.Location = New System.Drawing.Point(12, 551)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(119, 36)
        Me.cmdSalir.StyleController = Me.LayoutControl2
        Me.cmdSalir.TabIndex = 12
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.ImageOptions.SvgImage = CType(resources.GetObject("cmdNuevo.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.cmdNuevo.Location = New System.Drawing.Point(12, 12)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(119, 36)
        Me.cmdNuevo.StyleController = Me.LayoutControl2
        Me.cmdNuevo.TabIndex = 0
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'cmdSairi
        '
        Me.cmdSairi.Appearance.Options.UseTextOptions = True
        Me.cmdSairi.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdSairi.Enabled = False
        Me.cmdSairi.ImageOptions.SvgImage = CType(resources.GetObject("cmdSairi.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.cmdSairi.Location = New System.Drawing.Point(12, 427)
        Me.cmdSairi.Name = "cmdSairi"
        Me.cmdSairi.Size = New System.Drawing.Size(118, 38)
        Me.cmdSairi.StyleController = Me.LayoutControl2
        Me.cmdSairi.TabIndex = 8
        Me.cmdSairi.Text = "Di&seño O/P."
        '
        'btnPrintRet
        '
        Me.btnPrintRet.Appearance.Options.UseTextOptions = True
        Me.btnPrintRet.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnPrintRet.Enabled = False
        Me.btnPrintRet.ImageOptions.SvgImage = CType(resources.GetObject("btnPrintRet.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnPrintRet.Location = New System.Drawing.Point(12, 336)
        Me.btnPrintRet.Name = "btnPrintRet"
        Me.btnPrintRet.Size = New System.Drawing.Size(118, 38)
        Me.btnPrintRet.StyleController = Me.LayoutControl2
        Me.btnPrintRet.TabIndex = 9
        Me.btnPrintRet.Text = "Imprimir Re&tención"
        '
        'cmdModificar
        '
        Me.cmdModificar.Appearance.Options.UseTextOptions = True
        Me.cmdModificar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.ImageOptions.SvgImage = CType(resources.GetObject("cmdModificar.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.cmdModificar.Location = New System.Drawing.Point(12, 52)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(119, 36)
        Me.cmdModificar.StyleController = Me.LayoutControl2
        Me.cmdModificar.TabIndex = 1
        Me.cmdModificar.Text = "&Ver"
        '
        'cmdeditar
        '
        Me.cmdeditar.Appearance.Options.UseTextOptions = True
        Me.cmdeditar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdeditar.Enabled = False
        Me.cmdeditar.ImageOptions.SvgImage = CType(resources.GetObject("cmdeditar.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.cmdeditar.Location = New System.Drawing.Point(12, 92)
        Me.cmdeditar.Name = "cmdeditar"
        Me.cmdeditar.Size = New System.Drawing.Size(119, 36)
        Me.cmdeditar.StyleController = Me.LayoutControl2
        Me.cmdeditar.TabIndex = 4
        Me.cmdeditar.Text = "&Modificar"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.ImageOptions.SvgImage = CType(resources.GetObject("cmdImprimir.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.cmdImprimir.Location = New System.Drawing.Point(12, 212)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(119, 36)
        Me.cmdImprimir.StyleController = Me.LayoutControl2
        Me.cmdImprimir.TabIndex = 7
        Me.cmdImprimir.Text = "Im&primir"
        '
        'cmdAnular
        '
        Me.cmdAnular.Appearance.Options.UseTextOptions = True
        Me.cmdAnular.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdAnular.Enabled = False
        Me.cmdAnular.ImageOptions.Image = CType(resources.GetObject("cmdAnular.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAnular.Location = New System.Drawing.Point(12, 132)
        Me.cmdAnular.Name = "cmdAnular"
        Me.cmdAnular.Size = New System.Drawing.Size(119, 36)
        Me.cmdAnular.StyleController = Me.LayoutControl2
        Me.cmdAnular.TabIndex = 2
        Me.cmdAnular.Text = "&Anular"
        '
        'btnBorrar
        '
        Me.btnBorrar.Appearance.Options.UseTextOptions = True
        Me.btnBorrar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnBorrar.Enabled = False
        Me.btnBorrar.ImageOptions.Image = CType(resources.GetObject("btnBorrar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBorrar.Location = New System.Drawing.Point(12, 172)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(119, 36)
        Me.btnBorrar.StyleController = Me.LayoutControl2
        Me.btnBorrar.TabIndex = 3
        Me.btnBorrar.Text = "&Borrar"
        '
        'cmdVerEntradaAlmacen
        '
        Me.cmdVerEntradaAlmacen.Appearance.Options.UseTextOptions = True
        Me.cmdVerEntradaAlmacen.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdVerEntradaAlmacen.Enabled = False
        Me.cmdVerEntradaAlmacen.ImageOptions.SvgImage = CType(resources.GetObject("cmdVerEntradaAlmacen.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.cmdVerEntradaAlmacen.Location = New System.Drawing.Point(12, 294)
        Me.cmdVerEntradaAlmacen.Name = "cmdVerEntradaAlmacen"
        Me.cmdVerEntradaAlmacen.Size = New System.Drawing.Size(118, 38)
        Me.cmdVerEntradaAlmacen.StyleController = Me.LayoutControl2
        Me.cmdVerEntradaAlmacen.TabIndex = 6
        Me.cmdVerEntradaAlmacen.Text = "Ver &Entrada"
        '
        'cmdEntradaAlmacen
        '
        Me.cmdEntradaAlmacen.Appearance.Options.UseTextOptions = True
        Me.cmdEntradaAlmacen.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdEntradaAlmacen.Enabled = False
        Me.cmdEntradaAlmacen.ImageOptions.SvgImage = CType(resources.GetObject("cmdEntradaAlmacen.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.cmdEntradaAlmacen.Location = New System.Drawing.Point(12, 252)
        Me.cmdEntradaAlmacen.Name = "cmdEntradaAlmacen"
        Me.cmdEntradaAlmacen.Size = New System.Drawing.Size(118, 38)
        Me.cmdEntradaAlmacen.StyleController = Me.LayoutControl2
        Me.cmdEntradaAlmacen.TabIndex = 5
        Me.cmdEntradaAlmacen.Text = "&Registro Entrada"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem15, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem16, Me.LayoutControlItem23, Me.LayoutControlItem17, Me.LayoutControlItem18, Me.LayoutControlItem20, Me.LayoutControlItem19, Me.LayoutControlItem21, Me.EmptySpaceItem5, Me.LayoutControlItem22})
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(143, 599)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cmdNuevo
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(123, 40)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cmdModificar
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(123, 40)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.cmdeditar
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 80)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(123, 40)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.cmdAnular
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(123, 40)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.btnBorrar
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 160)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(123, 40)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.cmdEntradaAlmacen
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 240)
        Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem16.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(123, 42)
        Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.cmdSalir
        Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 539)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(123, 40)
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem23.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.cmdVerEntradaAlmacen
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 282)
        Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem17.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(123, 42)
        Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.cmdImprimir
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 200)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(123, 40)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.btnPrintRet
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 324)
        Me.LayoutControlItem20.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem20.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(123, 42)
        Me.LayoutControlItem20.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.cmdSairi
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 415)
        Me.LayoutControlItem19.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem19.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(123, 42)
        Me.LayoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.btnDisenoRet
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 457)
        Me.LayoutControlItem21.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem21.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(123, 42)
        Me.LayoutControlItem21.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem21.TextVisible = False
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(0, 366)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(123, 49)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.cmdExportar
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 499)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(123, 40)
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem22.TextVisible = False
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.Hasta)
        Me.LayoutControl1.Controls.Add(Me.CheckEdit1)
        Me.LayoutControl1.Controls.Add(Me.btnBuscar)
        Me.LayoutControl1.Controls.Add(Me.etInicio)
        Me.LayoutControl1.Controls.Add(Me.dgFacturas)
        Me.LayoutControl1.Controls.Add(Me.Desde)
        Me.LayoutControl1.Controls.Add(Me.cbOrigen)
        Me.LayoutControl1.Controls.Add(Me.cbEstado)
        Me.LayoutControl1.Controls.Add(Me.cbTipo)
        Me.LayoutControl1.Controls.Add(Me.cbDestino)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(727, 358, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(600, 628)
        Me.LayoutControl1.TabIndex = 175
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Hasta
        '
        Me.Hasta.EditValue = Nothing
        Me.Hasta.Location = New System.Drawing.Point(55, 36)
        Me.Hasta.Name = "Hasta"
        Me.Hasta.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.Hasta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hasta.Properties.Appearance.Options.UseFont = True
        Me.Hasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Hasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Hasta.Properties.Mask.BeepOnError = True
        Me.Hasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.Hasta.Size = New System.Drawing.Size(130, 20)
        Me.Hasta.StyleController = Me.LayoutControl1
        Me.Hasta.TabIndex = 1
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(457, 37)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Selector de Datos"
        Me.CheckEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.CheckEdit1.Size = New System.Drawing.Size(131, 22)
        Me.CheckEdit1.StyleController = Me.LayoutControl1
        Me.CheckEdit1.TabIndex = 171
        '
        'btnBuscar
        '
        Me.btnBuscar.ImageOptions.Image = CType(resources.GetObject("btnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(189, 23)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(103, 38)
        Me.btnBuscar.StyleController = Me.LayoutControl1
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "&Buscar"
        '
        'etInicio
        '
        Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etInicio.Location = New System.Drawing.Point(149, 10)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(137, 22)
        Me.etInicio.TabIndex = 160
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
        '
        'dgFacturas
        '
        Me.dgFacturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgFacturas.Location = New System.Drawing.Point(12, 65)
        Me.dgFacturas.MainView = Me.VFacturas
        Me.dgFacturas.Name = "dgFacturas"
        Me.dgFacturas.Size = New System.Drawing.Size(576, 551)
        Me.dgFacturas.TabIndex = 170
        Me.dgFacturas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VFacturas})
        '
        'VFacturas
        '
        Me.VFacturas.GridControl = Me.dgFacturas
        Me.VFacturas.Name = "VFacturas"
        Me.VFacturas.OptionsBehavior.Editable = False
        Me.VFacturas.OptionsFind.AlwaysVisible = True
        Me.VFacturas.OptionsFind.ShowClearButton = False
        Me.VFacturas.OptionsView.ShowAutoFilterRow = True
        Me.VFacturas.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VFacturas.OptionsView.ShowFooter = True
        Me.VFacturas.OptionsView.ShowGroupPanel = False
        '
        'Desde
        '
        Me.Desde.EditValue = Nothing
        Me.Desde.Location = New System.Drawing.Point(55, 12)
        Me.Desde.Name = "Desde"
        Me.Desde.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.Desde.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desde.Properties.Appearance.Options.UseFont = True
        Me.Desde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Desde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Desde.Properties.Mask.BeepOnError = True
        Me.Desde.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.Desde.Size = New System.Drawing.Size(130, 20)
        Me.Desde.StyleController = Me.LayoutControl1
        Me.Desde.TabIndex = 0
        '
        'cbOrigen
        '
        Me.cbOrigen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOrigen.Items.AddRange(New Object() {"--Todas--", "1 - Usuarios", "2 - Sistema"})
        Me.cbOrigen.Location = New System.Drawing.Point(433, 12)
        Me.cbOrigen.Name = "cbOrigen"
        Me.cbOrigen.Size = New System.Drawing.Size(155, 21)
        Me.cbOrigen.TabIndex = 5
        '
        'cbEstado
        '
        Me.cbEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstado.Items.AddRange(New Object() {"--Todas--", "Pendientes de Entrada en Almacen", "Registradas en Almacen", "Anuladas"})
        Me.cbEstado.Location = New System.Drawing.Point(366, 12)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(20, 21)
        Me.cbEstado.TabIndex = 3
        '
        'cbTipo
        '
        Me.cbTipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipo.Location = New System.Drawing.Point(366, 37)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(20, 21)
        Me.cbTipo.TabIndex = 4
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.etInicio
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(167, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(168, 28)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.EmptySpaceItem3, Me.LayoutControlItem3, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.LayoutControlItem10})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(600, 628)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Desde
        Me.LayoutControlItem1.CustomizationFormText = "Desde:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(177, 24)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(177, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(177, 24)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Desde:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(40, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Hasta
        Me.LayoutControlItem2.CustomizationFormText = "Hasta:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(177, 29)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(177, 29)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(177, 29)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Hasta:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(40, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cbEstado
        Me.LayoutControlItem4.CustomizationFormText = "Estado:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(311, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(67, 25)
        Me.LayoutControlItem4.Text = "Estado:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(40, 13)
        Me.LayoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cbTipo
        Me.LayoutControlItem5.CustomizationFormText = "Tipo:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(311, 25)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(67, 28)
        Me.LayoutControlItem5.Text = "Tipo:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(40, 13)
        Me.LayoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cbOrigen
        Me.LayoutControlItem6.CustomizationFormText = "Origen:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(378, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(202, 25)
        Me.LayoutControlItem6.Text = "Origen:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(40, 13)
        Me.LayoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cbDestino
        Me.LayoutControlItem7.CustomizationFormText = "Destino:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(378, 25)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(67, 28)
        Me.LayoutControlItem7.Text = "Destino:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(40, 13)
        Me.LayoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.dgFacturas
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 53)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(580, 555)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(284, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(27, 25)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.btnBuscar
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(177, 11)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(107, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(107, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(107, 42)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(177, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(107, 11)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(284, 25)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(27, 28)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.CheckEdit1
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(445, 25)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(135, 28)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(135, 28)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(135, 28)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
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
        Me.DockPanel1.ID = New System.Guid("fa3c575c-8b6a-4138-94bd-a0c2e8bb0f03")
        Me.DockPanel1.Location = New System.Drawing.Point(600, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(150, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(150, 628)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(143, 599)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'frmFacturasComprasList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(750, 628)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "frmFacturasComprasList"
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Desde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Desde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Proveedores As New VB.SysContab.ProveedoresDB
    Dim FormaPago As New VB.SysContab.Forma_PagoDB

    Private Sub frmFacturasComprasList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(LayoutControl2)
        '
        Me.cbEstado.SelectedIndex = 0
        Me.cbOrigen.SelectedIndex = 0
        Me.cbDestino.SelectedIndex = 0
        '
        If Me.cbEstado.Enabled = False Then
            Me.cbEstado.SelectedIndex = 1
        End If
        '
        cbTipo.DataSource = FormaPago.FormaPagoListAll().Tables("Forma_Pago")
        cbTipo.ValueMember = "Codigo"
        cbTipo.DisplayMember = "Nombre"
        cbTipo.SelectedValue = 0
        '
        Desde.DateTime = New DateTime(Now.Year, Now.Month, 1)
        Hasta.DateTime = Now.Date

        Cargar()
        Grid()
    End Sub

    Public Sub Cargar()
        Me.dgFacturas.DataSource =
            VB.SysContab.Facturas_ComprasDB _
            .FacturasCompraLista_V2(
            cbEstado.SelectedIndex,
            cbTipo.SelectedValue,
            0,
            cbOrigen.SelectedIndex,
            cbDestino.SelectedIndex,
            Desde.DateTime.Date,
            Hasta.DateTime.Date) _
            .Tables("Facturas_Compra")
    End Sub

    Sub Grid()
        'SimpleFormatGrid(VFacturas, False, DevExpress.Utils.HorzAlignment.Center, 0, 2, 5, 10, 6, 15, 16, 17, 18, 20, 21, 22)
        VFacturas.PopulateColumns()
        FormatoGrid(VFacturas, 2, 0, True, False, True)

        '  Me.VFacturas.Columns("Fecha").SortOrder = DevExpress.Data.ColumnSortOrder.Descending
        'Me.VFacturas.Columns("Monto").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.VFacturas.Columns("Monto").DisplayFormat.FormatString = "n2"
        'Me.VFacturas.Columns("Monto").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.VFacturas.Columns("Monto").SummaryItem.DisplayFormat = "{0:n2}"

        ''Me.VFacturas.Columns("Descuento").Width = 100
        'Me.VFacturas.Columns("Descuento").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.VFacturas.Columns("Descuento").DisplayFormat.FormatString = "n2"
        'Me.VFacturas.Columns("Descuento").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.VFacturas.Columns("Descuento").SummaryItem.DisplayFormat = "{0:n2}"

        ''Me.VFacturas.Columns("Sub Total").Width = 100
        'Me.VFacturas.Columns("Sub Total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.VFacturas.Columns("Sub Total").DisplayFormat.FormatString = "n2"
        'Me.VFacturas.Columns("Sub Total").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.VFacturas.Columns("Sub Total").SummaryItem.DisplayFormat = "{0:n2}"

        ''Me.VFacturas.Columns("IVA").Width = 100
        'Me.VFacturas.Columns("IVA").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.VFacturas.Columns("IVA").DisplayFormat.FormatString = "n2"
        'Me.VFacturas.Columns("IVA").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.VFacturas.Columns("IVA").SummaryItem.DisplayFormat = "{0:n2}"

        ''Me.VFacturas.Columns("Total").Width = 100
        'Me.VFacturas.Columns("Total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.VFacturas.Columns("Total").DisplayFormat.FormatString = "n2"
        'Me.VFacturas.Columns("Total").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.VFacturas.Columns("Total").SummaryItem.DisplayFormat = "{0:n2}"

        ''Me.VFacturas.Columns("SubTotalIR").Width = 100
        'Me.VFacturas.Columns("SubTotalIR").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.VFacturas.Columns("SubTotalIR").DisplayFormat.FormatString = "n2"
        'Me.VFacturas.Columns("SubTotalIR").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.VFacturas.Columns("SubTotalIR").SummaryItem.DisplayFormat = "{0:n2}"

        'Me.VFacturas.Columns("IR").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.VFacturas.Columns("IR").DisplayFormat.FormatString = "n2"
        'Me.VFacturas.Columns("IR").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.VFacturas.Columns("IR").SummaryItem.DisplayFormat = "{0:n2}"

        'Me.VFacturas.Columns("PAGOS").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.VFacturas.Columns("PAGOS").DisplayFormat.FormatString = "n2"
        'Me.VFacturas.Columns("PAGOS").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.VFacturas.Columns("PAGOS").SummaryItem.DisplayFormat = "{0:n2}"

        'Me.VFacturas.Columns("Saldo").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.VFacturas.Columns("Saldo").DisplayFormat.FormatString = "n2"
        'Me.VFacturas.Columns("Saldo").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.VFacturas.Columns("Saldo").SummaryItem.DisplayFormat = "{0:n2}"
        ''
        'Me.VFacturas.Columns("Factura").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        'Me.VFacturas.Columns("Factura").SummaryItem.DisplayFormat = "{0:n0}"

        'Me.VFacturas.Columns("Monto").Visible = False
        'Me.VFacturas.Columns("Descuento").Visible = False
        'Me.VFacturas.Columns("Proveedor_ID").Visible = False
        'Me.VFacturas.Columns("Destino").Visible = False
        'Me.VFacturas.Columns("TipoF").Visible = False
        'Me.VFacturas.Columns("Tipo").Visible = False
        'Me.VFacturas.Columns("LiqTipo").Visible = False

        Me.VFacturas.Columns("Proveedor_ID").OptionsColumn.ShowInCustomizationForm = False
        Me.VFacturas.Columns("Destino").OptionsColumn.ShowInCustomizationForm = False
        Me.VFacturas.Columns("TipoF").OptionsColumn.ShowInCustomizationForm = False
        Me.VFacturas.Columns("Tipo").OptionsColumn.ShowInCustomizationForm = False

        'Me.VFacturas.Columns("LiqTipo").OptionsColumn.ShowInCustomizationForm = False


        Me.VFacturas.Columns("Concepto").Visible = False
        Me.VFacturas.Columns("Descuento").Visible = False
        Me.VFacturas.Columns("PAGOS").Visible = False
        'Me.VFacturas.Columns("Saldo").Visible = False
        Me.VFacturas.Columns("SubTotalIR").Visible = False
        Me.VFacturas.Columns("IR").Visible = False
        Me.VFacturas.Columns("Proveedor_ID").Visible = False
        Me.VFacturas.Columns("Destino").Visible = False
        Me.VFacturas.Columns("TipoF").Visible = False
        Me.VFacturas.Columns("Tipo").Visible = False
        Me.VFacturas.Columns("Monto").Visible = False
        Me.VFacturas.Columns("Registro").Visible = False
        Me.VFacturas.Columns("Ruc").Visible = False

        'Me.VFacturas.Columns("LineasLiq").Visible = False
        'Me.VFacturas.Columns("LiqTipo").Visible = False

        ' Me.VFacturas.BestFitColumns()
        Me.VFacturas.Columns("Nombre").Width = 120

        If VFacturas.DataRowCount = 0 Then Registro = "Vacio"
        If VFacturas.DataRowCount > 0 Then Registro = VFacturas.GetRowCellValue(0, "No. Orden Pago")

        Dim columnCustomer As GridColumn = VFacturas.Columns("Estado")
        columnCustomer.FilterInfo = New ColumnFilterInfo("[Estado] <> 'Anulada'")
    End Sub
    Private Sub cbProveedor_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If etInicio.Text = "1" Then
            Exit Sub
        End If
        Me.Cargar()
    End Sub


    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        ShowSplash()
        Inicio = True
        Dim frm As frmFacturasCompra = frmFacturasCompra.Instance()
        frm.Dispose()
        '

        Dim f As frmFacturasCompra = frmFacturasCompra.Instance()
        f.MdiParent = Me.MdiParent
        f.Show()
        f.Text = "Nueva Orden de Pago"
        f.WindowState = FormWindowState.Maximized
        f.Nuevo = True
        Inicio = False
        HideSplash()
    End Sub


    Private Sub cbEstado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbEstado.SelectedIndexChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If
        Me.Cargar()
    End Sub

    Private Sub cbTipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTipo.SelectedIndexChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        Me.Cargar()
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        If VFacturas.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
            Exit Sub
        End If
        '
        ShowSplash("Imprimiendo O/P...")
        'Dim Temp As Boolean = False

        'Try
        '    Dim Data() As Byte = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 18 AND Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())

        '    Temp = True
        '    Dim Tamano As Integer = Data.GetUpperBound(0)
        '    Dim Cadena As String = Application.StartupPath & "\rptOrdenPago.repx"

        '    If File.Exists(Cadena) Then Kill(Cadena)
        '    Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
        '    Archivo.Write(Data, 0, Tamano)
        '    Archivo.Close()
        'Catch ex As Exception
        '    Temp = False
        'End Try
        Dim Temp As Boolean = db_Formatos.FormatoImpreso(18, "rptOrdenPago")
        '
        Dim rpt As rptOrdenPago

        If Temp = True Then
            rpt = XtraReport.FromFile(Application.StartupPath & "\rptOrdenPago.repx", True)
        Else
            rpt = New rptOrdenPago
        End If
        '
        Dim _DT As DataTable = ObtieneDatos("JAR_GetOrdenPagoImpresa", VFacturas.GetFocusedRowCellValue("No. Orden Pago"),
                                      VFacturas.GetFocusedRowCellValue("Proveedor_ID"),
                                      EmpresaActual)

        'rpt.DataSource =  'DSComp.Tables(0)

        VistaPreviaDX(rpt, _DT,
                      "Orden de Pago No. " & VFacturas.GetFocusedRowCellValue("No. Orden Pago"))

        HideSplash()

        'rpt.ShowPrintMarginsWarning = False
        'rpt.BringToFront()
        'rpt.ShowRibbonPreview()
    End Sub

    Private Sub cmdEntradaAlmacen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEntradaAlmacen.Click

        If Me.VFacturas.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Contab")
            Exit Sub
        End If

        If Me.VFacturas.GetFocusedRowCellValue("No. Orden Pago") = "" Then
            MsgBox("Seleccione una Factura", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Me.VFacturas.GetFocusedRowCellValue("Estado") = "Facturada" Then
            MsgBox("La Factura ya fue Procesada", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Me.VFacturas.GetFocusedRowCellValue("Estado") = "Anulada" Then
            MsgBox("La Factura fue Anulada", MsgBoxStyle.Information)
            Exit Sub
        End If

        'If Me.VFacturas.GetFocusedRowCellValue("A Liquidar") Then
        '    MsgBox("Solo se pueder dar entrada al Almacen a las compras Locales.", MsgBoxStyle.Information, formtitulo)
        '    Exit Sub
        'End If

        Inicio = True

        Dim f As DataGridTextBoxCombo.frmEntradaAlmacen = DataGridTextBoxCombo.frmEntradaAlmacen.Instance()
        f.etInicio.Text = "1"
        f.txtFactura.Text = Me.VFacturas.GetFocusedRowCellValue("No. Orden Pago")
        'f.txtProveedor.Text = Me.VFacturas.GetFocusedRowCellValue("Proveedor_ID")
        f.IdProveedor = Me.VFacturas.GetFocusedRowCellValue("Proveedor_ID")
        'f.etDestino.Text = Me.VFacturas.GetFocusedRowCellValue("Destino")
        f.txtSubTotalIR.EditValue = Me.VFacturas.GetFocusedRowCellValue("SubTotalIR")

        'If Me.VFacturas.GetFocusedRowCellValue("TipoF") = "P" Then
        '    f.rbProductos.Checked = True
        'ElseIf Me.VFacturas.GetFocusedRowCellValue("TipoF") = "S" Then
        '    f.rbServicios.Checked = True
        'ElseIf Me.VFacturas.GetFocusedRowCellValue("TipoF") = "I" Then
        '    f.rbInventario.Checked = True
        'ElseIf Me.VFacturas.GetFocusedRowCellValue("TipoF") = "A" Then
        '    f.rbProdInvet.Checked = True
        'End If

        'f.gbTipo.Enabled = False
        f.MdiParent = Me.MdiParent
        f.Show()
        f.Text = "Registro de Entrada"
        f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "0"
        f.Nuevo = False
        Inicio = False
    End Sub


    Private Sub cbOrigen_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbOrigen.SelectedIndexChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        Me.Cargar()
    End Sub

    Private Sub cbDestino_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDestino.SelectedIndexChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        Me.Cargar()
    End Sub

    Private Sub cmdVerEntradaAlmacen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVerEntradaAlmacen.Click
        If Me.VFacturas.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
            Exit Sub
        End If

        'If Me.VFacturas.GetFocusedRowCellValue("No. Orden Pago") = "" Then
        '    MsgBox("Seleccione una Factura", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        If Me.VFacturas.GetFocusedRowCellValue("Estado") = "Pendiente" Then
            XtraMsg("La Factura no ha entrado a Almacen")
            Exit Sub
        End If

        If Me.VFacturas.GetFocusedRowCellValue("Estado") = "Anulada" Then
            XtraMsg("La Factura fue Anulada")
            Exit Sub
        End If

        Inicio = True
        Dim f As DataGridTextBoxCombo.frmEntradaAlmacenVer = DataGridTextBoxCombo.frmEntradaAlmacenVer.Instance
        f.etInicio.Text = "1"
        f.txtFactura.Text = Me.VFacturas.GetFocusedRowCellValue("No. Orden Pago")
        f.txtProveedor.Text = Me.VFacturas.GetFocusedRowCellValue("Proveedor_ID")
        f.etDestino.Text = Me.VFacturas.GetFocusedRowCellValue("Destino")

        If Me.VFacturas.GetFocusedRowCellValue("TipoF") = "P" Then
            f.rbProductos.Checked = True
        ElseIf Me.VFacturas.GetFocusedRowCellValue("TipoF") = "S" Then
            f.rbServicios.Checked = True
        ElseIf Me.VFacturas.GetFocusedRowCellValue("TipoF") = "I" Then
            f.rbInventario.Checked = True
        ElseIf Me.VFacturas.GetFocusedRowCellValue("TipoF") = "A" Then
            f.rbProdInvet.Checked = True
        End If

        f.gbTipo.Enabled = False
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "0"
        f.Nuevo = False
        Inicio = False
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If Me.VFacturas.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Information, formtitulo)
            Exit Sub
        End If

        If Me.VFacturas.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione una Factura")
            Exit Sub
        End If

        ShowSplash()
        '
        Dim frm As frmFacturasCompra = frmFacturasCompra.Instance()
        frm.Dispose()
        '
        Dim f As frmFacturasCompra = frmFacturasCompra.Instance()
        f.etInicio.Text = "1"

        f.cmdAceptar.Enabled = False
        f.cmbdistribucion.Enabled = False
        f.btnDetalle.Enabled = False
        'f.gridDatos.Enabled = False
        f.ckIR.Enabled = False
        f.chkIRAlc.Enabled = False
        'f.ckLiquidar.Enabled = False
        f.ckIVAAsumido.Enabled = False

        f.txtfactura.Text = Me.VFacturas.GetFocusedRowCellValue("No. Orden Pago")
        f.Proveedor = Me.VFacturas.GetFocusedRowCellValue("Proveedor_ID")
        f.etOrigen.Text = Me.VFacturas.GetFocusedRowCellValue("Destino")
        f.TipoF = Me.VFacturas.GetFocusedRowCellValue("TipoF")
        f.Modifica = True
        f.VerFactura = True
        f.TipoC = 2
        'f.rbServicios.Checked = True
        f.gbTipo.Enabled = False

        If f.TipoF = "P" Then
            f.gbTipo.EditValue = 0
        ElseIf f.TipoF = "S" Then
            f.gbTipo.EditValue = 1
        ElseIf f.TipoF = "A" Then
            f.gbTipo.EditValue = 3
        ElseIf f.TipoF = "I" Then
            f.gbTipo.EditValue = 4
        End If

        'If VFacturas.GetFocusedRowCellValue("LineasLiq") = True Then
        '    f.ckLiquidar.Checked = True
        '    f.cbTipo.SelectedIndex = VFacturas.GetFocusedRowCellValue("LiqTipo")
        'End If

        f.MdiParent = Me.MdiParent
        f.Show()
        f.Text = "Ver Orden de Pago"
        f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "0"
        '
        HideSplash()

        'If Me.VFacturas.DataRowCount = 0 Then
        '    MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Contab")
        '    Exit Sub
        'End If

        'If Me.VFacturas.FocusedRowHandle < 0 Then
        '    MsgBox("Seleccione una Factura", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        ''Dim f As frmFacturasCompra = f.Instance
        'Dim f As DataGridTextBoxCombo.frmFacturasCompraVer = f.Instance

        ''f.txtFactura.Text = Me.VFacturas.GetFocusedRowCellValue("Factura")
        'f.txtFactura.Text = Me.VFacturas.GetFocusedRowCellValue("No. Orden Pago")
        'f.txtProveedor.Text = Me.VFacturas.GetFocusedRowCellValue("Proveedor_ID")
        'f.etDestino.Text = Me.VFacturas.GetFocusedRowCellValue("Destino")

        'If Me.VFacturas.GetFocusedRowCellValue("TipoF") = "P" Then
        '    f.rbProductos.Checked = True
        'ElseIf Me.VFacturas.GetFocusedRowCellValue("TipoF") = "S" Then
        '    f.rbServicios.Checked = True
        'ElseIf Me.VFacturas.GetFocusedRowCellValue("TipoF") = "I" Then
        '    f.rbInventario.Checked = True
        'ElseIf Me.VFacturas.GetFocusedRowCellValue("TipoF") = "A" Then
        '    f.rbProdInvet.Checked = True
        'End If

        'f.gbTipo.Enabled = False
        'f.MdiParent = Me.MdiParent
        'f.Show()
        'f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cmdAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnular.Click
        If VFacturas.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione una Factura")
            Exit Sub
        End If

        'Verificar Cierre del Día
        '---------------------------------------------------------------------
        If Not VerificarCierre(CDate(Me.VFacturas.GetFocusedRowCellValue("Fecha")).Date) Then
            Exit Sub
        End If
        '--------------------------------------------------------------------

        If CDbl(Me.VFacturas.GetFocusedRowCellValue("PAGOS")) > 0 Then
            XtraMsg("La O/P Seleccionada ya tiene registrado Pagos", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '

        'If VFacturas.GetFocusedRowCellValue("Tipo") = 0 And
        '    VFacturas.GetFocusedRowCellValue("Estado") = "Facturada" Then
        '    XtraMsg("La Factura Seleccionada ya ingreso a Bodega", MessageBoxIcon.Warning)
        '    Exit Sub
        'End If
        '
        'If VFacturas.GetFocusedRowCellValue("Tipo") = 3 And
        '    VFacturas.GetFocusedRowCellValue("Estado") = "Facturada" Then
        '    XtraMsg("La Factura Seleccionada ya ingreso a Bodega", MessageBoxIcon.Warning)
        '    Exit Sub
        'End If

        If VFacturas.GetFocusedRowCellValue("Estado") = "Anulada" Then
            XtraMsg("La factura ya fue anulada", MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim requisa As New ClasesBLL.db_requisas

        requisa.Detalles(VFacturas.GetFocusedRowCellValue("No. Orden Pago"),
                         VFacturas.GetFocusedRowCellValue("Proveedor_ID"))

        'Si la OP Tiene Movimiento de Inventario
        If requisa.req_codigo > 0 Then
            If requisa.Procesado Then
                XtraMsg("La O/P Seleccionada contiene un movimiento ya procesado en el Inventario, No puede ser Anulada!", MessageBoxIcon.Error)
                Exit Sub
            Else
                If XtraMsg2("Esta O/P " & VFacturas.GetFocusedRowCellValue("No. Orden Pago") & " contiene el Movimiento de Inventario No. " & requisa.req_codigo.ToString() & " el cual se borrará Permanentemente." & vbCrLf &
                                "Esta Seguro de Anular esta O/P ?") Then

                    If Not requisa.BorrarMovimiento(requisa.req_codigo) Then
                        Exit Sub
                    End If
                Else
                    Exit Sub
                End If
            End If
        Else
            If Not XtraMsg2("Desea Anular la Factura: " & Me.VFacturas.GetFocusedRowCellValue("No. Orden Pago") & " del proveedor: " & Me.VFacturas.GetFocusedRowCellValue("Nombre") & ".?") Then
                Exit Sub
            End If
        End If


        'If Me.VFacturas.DataRowCount = 0 Then
        '    MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Contab")
        '    Exit Sub
        'End If

        ''Dim dsFactura As DataSet
        'Dim Articulos As New VB.SysContab.ArticulosDB
        'Dim Comp As New VB.SysContab.ComprobanteDB

        'If Me.VFacturas.GetFocusedRowCellValue("No. Orden Pago") = "" Then
        '    XtraMsg("Seleccione una Factura", MessageBoxIcon.Error)
        '    Exit Sub
        'End If


        '  dsFactura = VB.SysContab.Facturas_ComprasDB.FacturaDetalle(Me.VFacturas.GetFocusedRowCellValue("No. Orden Pago"), _
        'Me.VFacturas.GetFocusedRowCellValue("Proveedor_ID"), _
        'Me.VFacturas.GetFocusedRowCellValue("Destino"))

        Dim dsxAnular As DataSet = VB.SysContab.ComprobanteDB.GetComprobante(Me.VFacturas.GetFocusedRowCellValue("No. Orden Pago"),
                Me.VFacturas.GetFocusedRowCellValue("Proveedor_ID"),
                Me.VFacturas.GetFocusedRowCellValue("Fecha"))

        If dsxAnular.Tables(0).Rows.Count > 1 Then
            XtraMsg("Mas de un comprobante encontrado.", MessageBoxIcon.Warning)
            Exit Sub
        End If

        If dsxAnular.Tables(0).Rows.Count = 1 Then
            Dim Registros As Integer = VB.SysContab.ComprobanteDB.ComprobanteAnularBuscar(dsxAnular.Tables(0).Rows(0).Item("Comp_No"),
                                                dsxAnular.Tables(0).Rows(0).Item("Per_ID"),
                                                 dsxAnular.Tables(0).Rows(0).Item("Comp_Fecha"))

            If Registros > 0 Then
                XtraMsg("El comprobante ya fue anulado", MessageBoxIcon.Warning)
                Exit Sub
            End If
        Else
            XtraMsg("La O/P " & VFacturas.GetFocusedRowCellValue("No. Orden Pago") & " No contiene Comprobante Contable", MessageBoxIcon.Error)
        End If

        Try
            ''*************  INICIAR TRANSACCION    *****************************
            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction
            ''**********************************************************************

            VB.SysContab.ComprobanteDB.ComprobanteAnular(dsxAnular.Tables(0).Rows(0).Item("Comp_No"),
                                                    dsxAnular.Tables(0).Rows(0).Item("Per_ID"),
                                                     dsxAnular.Tables(0).Rows(0).Item("Comp_Fecha"))

            'NO ES NECESARIO PORQUE AL ANULAR EL  COMPROBANTE SE BORRA LA DISTRIBUCION.
            'With dsxAnular.Tables(0).Rows(0)
            '    EliminaDistribucionTrans(.Item("Comp_No"), .Item("Per_Id"), .Item("Comp_Fecha").Month) 'Revisar si funciona
            'End With

            VB.SysContab.ComprobanteDB.CancelarFactura(dsxAnular.Tables(0).Rows(0).Item("Factura"), dsxAnular.Tables(0).Rows(0).Item("Proveedor"), 0)
            VB.SysContab.ComprobanteDB.PagosFacturasBorrar(dsxAnular.Tables(0).Rows(0).Item("Comp_No"), dsxAnular.Tables(0).Rows(0).Item("Mes"), dsxAnular.Tables(0).Rows(0).Item("Per_ID"))

            ''Verificar Si la Factura Entro a Bodega y Deshacer Transacción.
            'If Me.VFacturas.GetFocusedRowCellValue("Estado") = "Facturada" And Me.VFacturas.GetFocusedRowCellValue("TipoF") <> "S" Then
            '    Dim dtl As DataTable = ObtieneDatosTrans("sp_GetEntradaBodega '" & Me.VFacturas.GetFocusedRowCellValue("No. Orden Pago") & "'," _
            '                                             + " '" & Me.VFacturas.GetFocusedRowCellValue("Proveedor_ID") & "'," _
            '                                             + " " & EmpresaActual)
            '    With dtl
            '        For i As Integer = 0 To dtl.Rows.Count - 1
            '            'Restar Existencias de la Entrada registrada Segun Factura.
            '            GuardaDatosTrans("sp_SumarExistencias '" & .Rows.Item(i)("codigo_bodega") & "'," _
            '                             + " '" & .Rows.Item(i)("codigo_articulo") & "'," _
            '                             + " " & (.Rows.Item(i)("cantidad") * -1) & "," _
            '                             + " '" & .Rows.Item(i)("Articulo_tipo") & "'," & EmpresaActual)
            '        Next
            '    End With

            '    'Borrar Transaccion Generadas en Bodega.
            '    GuardaDatosTrans("sp_TransaccionBodegaDelete '" & Me.VFacturas.GetFocusedRowCellValue("No. Orden Pago") & "'," _
            '                     + " " & Me.VFacturas.GetFocusedRowCellValue("Proveedor_ID") & "," & EmpresaActual)
            'End If

            VB.SysContab.Facturas_ComprasDB.UpdateEstado(Me.VFacturas.GetFocusedRowCellValue("No. Orden Pago"),
                    "A", VB.SysContab.Rutinas.Fecha, Me.VFacturas.GetFocusedRowCellValue("Proveedor_ID"))

            VB.SysContab.Rutinas.okTransaccion()
            '
            ShowSplash()
            Cargar()
            HideSplash()
        Catch ex As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdeditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdeditar.Click

        If Me.VFacturas.DataRowCount = 0 Then
            XtraMsg("No hay registros en la lista")
            Exit Sub
        End If

        If Me.VFacturas.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione una Factura")
            Exit Sub
        End If

        'Verificar Cierre del Día
        '---------------------------------------------------------------------
        If Not VerificarCierre(CDate(Me.VFacturas.GetFocusedRowCellValue("Fecha")).Date) Then
            Exit Sub
        End If
        '--------------------------------------------------------------------

        Dim Estado As Boolean = True,
            Pagos As Boolean = False

        If Me.VFacturas.GetFocusedRowCellValue("Estado") = "Anulada" Then
            XtraMsg("La Factura Seleccionada se encuentra ANULADA")
            Estado = False
            'Exit Sub
        End If

        'If VFacturas.GetFocusedRowCellValue("Tipo") = 0 And
        '   VFacturas.GetFocusedRowCellValue("Estado") = "Facturada" Then
        '    XtraMsg("La Factura Seleccionada ya ingreso a Bodega", MessageBoxIcon.Warning)
        '    Exit Sub
        'End If
        '
        'If VFacturas.GetFocusedRowCellValue("Tipo") = 3 And _
        '    VFacturas.GetFocusedRowCellValue("Estado") = "Facturada" Then
        '    XtraMsg("La Factura Seleccionada ya ingreso a Bodega", MessageBoxIcon.Warning)
        '    Exit Sub
        'End If

        Dim req As New db_requisas

        req.Detalles(VFacturas.GetFocusedRowCellValue("No. Orden Pago"),
                         VFacturas.GetFocusedRowCellValue("Proveedor_ID"))


        'Si la OP Tiene Movimiento de Inventario
        If req.req_codigo > 0 Then
            If req.Procesado Then
                XtraMsg("La O/P Seleccionada contiene un movimiento ya procesado en el Inventario, No puede ser Modificada!", MessageBoxIcon.Error)
                Estado = False
                'Exit Sub
            Else
                XtraMsg("Esta O/P: " & VFacturas.GetFocusedRowCellValue("No. Orden Pago") & " contiene el Movimiento de Inventario No. " & req.req_codigo.ToString() & ", debe ser borrado primero para poder ser Modificada." & vbCrLf, MessageBoxIcon.Warning)
                Estado = False
                'Exit Sub
            End If
        End If

        If CDbl(Me.VFacturas.GetFocusedRowCellValue("PAGOS")) > 0 Then
            Pagos = True
            If Not XtraMsg2("La Factura Seleccionada ya tiene registrado Pagos." & vbCrLf &
                        "Esta Seguro que desea Modificarla?", MessageBoxIcon.Warning) Then
                Exit Sub
            End If
        End If

        'If Me.VFacturas.GetFocusedRowCellValue("TipoF") <> "S" Then
        '    If Me.VFacturas.GetFocusedRowCellValue("Estado") = "Facturada" Then
        '        DevExpress.XtraEditors.XtraMessageBox.Show("La Factura Seleccionada ya registró Entrada al Almacén", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        Exit Sub
        '    End If
        'End If

        'If Me.VFacturas.GetFocusedRowCellValue("TipoF") <> "S" Then
        '    MsgBox("Solo puede Editar Facturas de Servicio", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        ShowSplash("Cargando O/P...")
        '
        Dim frm As frmFacturasCompra = frmFacturasCompra.Instance()
        frm.Dispose()
        '
        Dim f As frmFacturasCompra = frmFacturasCompra.Instance()
        f.etInicio.Text = "1"

        f.txtfactura.Text = Me.VFacturas.GetFocusedRowCellValue("No. Orden Pago")
        f.Proveedor = Me.VFacturas.GetFocusedRowCellValue("Proveedor_ID")
        f.etOrigen.Text = Me.VFacturas.GetFocusedRowCellValue("Destino")
        f.TipoF = Me.VFacturas.GetFocusedRowCellValue("TipoF")
        f.Modifica = True
        f.cmdAceptar.Enabled = Estado
        f.TipoC = 2
        f.TienePagos = Pagos

        'f.rbServicios.Checked = True

        f.gbTipo.Enabled = False

        If f.TipoF = "P" Then
            f.gbTipo.EditValue = 0
        ElseIf f.TipoF = "S" Then
            f.gbTipo.EditValue = 1
        ElseIf f.TipoF = "A" Then
            f.gbTipo.EditValue = 3
        ElseIf f.TipoF = "I" Then
            f.gbTipo.EditValue = 4
        End If

        f.MdiParent = Me.MdiParent
        f.Show()
        f.Text = "Modificar Orden de Pago"
        f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "0"
        '
        HideSplash()
    End Sub

    Private Sub cmdSairi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSairi.Click
        ShowSplash("Cargando Diseño...")
        '
        Dim f As New FrmConfiguraCheque
        f.Tipo = 18
        f.Text = "Formato Orden Pago"
        f.Show()
        f.WindowState = FormWindowState.Maximized
        '
        HideSplash()

        'My.Forms.frmSairi.MdiParent = Me.MdiParent
        'My.Forms.frmSairi.Show()
        'My.Forms.frmSairi.WindowState = FormWindowState.Maximized
        ''Dim f As frmSairi = f.Instance
        ''f.Show()
    End Sub

    Private Sub frmFacturasComprasList_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        'cargar()
    End Sub

    Private Sub btnPrintRet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintRet.Click

        If Me.VFacturas.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un  registro de la lista")
            Exit Sub
        End If

        'If Me.VFacturas.GetFocusedRowCellValue("Estado") = "Pendiente" Then
        '    MsgBox("La Factura no ha entrado a Almacen", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        If Me.VFacturas.GetFocusedRowCellValue("Estado") = "Anulada" Then
            XtraMsg("La Factura fue Anulada")
            Exit Sub
        End If

        ImprimeRetencion()
    End Sub

    Private Sub ImprimeRetencion()

        Dim Cadena As String
        Dim Temp As Boolean = False
        Dim Data() As Byte
        Try
            'Dim Datas() As Byte = CType(ObtieneDatos("SELECT ChequeD FROM Catalogo_Bancos WHERE Codigo = " & Cod).Rows(0).Item(0), Byte())
            Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 5 and Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())
            Temp = True

            Dim Tamano As Integer
            Tamano = Data.GetUpperBound(0)
            Cadena = Application.StartupPath & "\RptRetencion.repx"

            If File.Exists(Cadena) Then Kill(Cadena)
            Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
            Archivo.Write(Data, 0, Tamano)
            Archivo.Close()

        Catch ex As Exception
            Temp = False
            'Exit Sub
        End Try

        'Dim Data() As Byte = CType(ObtieneDatos("SELECT ChequeD FROM Catalogo_Bancos WHERE Codigo = " & Cod).Rows(0).Item(0), Byte())
        Dim Rep As XtraReport
        'XtraReport()
        If Temp = True Then
            Rep = XtraReport.FromFile(Application.StartupPath & "\RptRetencion.repx", True)
        Else
            Rep = New RptRetencion
        End If

        Dim Datos As New ArrayList
        Dim Variables As New ArrayList

        Variables.Add("Cheque")
        Variables.Add("Empresa")
        'Variables.Add("Banco")

        Datos.Add(Me.VFacturas.GetFocusedRowCellValue("No. Orden Pago"))
        Datos.Add(CInt(EmpresaActual))

        'Datos.Add(CInt(cmbbancos.GetColumnValue("Cod")))
        'Datos.Add(IIf(cbBancos.SelectedIndex <= 0, CInt(GridView1.GetFocusedRowCellValue("Banco")), CInt(cbBancos.SelectedValue)))
        Try
            Dim dtR As DataTable = ProcedureParameters(Datos, Variables, "SP_GetRetencionesFC")

            If dtR.Rows.Count = 0 Then
                MsgBox("La Factura de Compra #: " & Me.VFacturas.GetFocusedRowCellValue("No. Orden Pago") & " No Tiene IR", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If dtR.Rows.Count > 0 Then
                If dtR.Rows.Item(0)("TotalC") = 0 Then
                    MsgBox("La Factura de Compra #: " & Me.VFacturas.GetFocusedRowCellValue("No. Orden Pago") & " No Tiene IR", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            End If

            Rep.DataSource = dtR 'ProcedureParameters(Datos, Variables, "SP_GetRetencionesFC")

            Rep.ShowPrintMarginsWarning = False
            Rep.BringToFront()
            Rep.ShowRibbonPreview()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Rep.DataSource = GetChequeDb(GridView1.GetFocusedRowCellValue("Per_ID"), GridView1.GetFocusedRowCellValue("Comp_No"), GridView1.GetFocusedRowCellValue("Fecha"), "")
        'If Directo Then Rep.PrintDialog() Else 
    End Sub

    Private Sub cmdconfret_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        If Me.VFacturas.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione una Factura")
            Exit Sub
        End If

        'Verificar Cierre del Día
        '---------------------------------------------------------------------
        If Not VerificarCierre(CDate(Me.VFacturas.GetFocusedRowCellValue("Fecha")).Date) Then
            Exit Sub
        End If
        '--------------------------------------------------------------------

        If Me.VFacturas.GetFocusedRowCellValue("Estado") <> "Anulada" Then
            XtraMsg("Debe Anular Primero la Factura", MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not XtraMsg2("Desea Borrar Completamente la Factura del Sistema ?") Then
            Exit Sub
        End If

        'Dim dsxAnular As New DataSet
        'Dim Comp As New VB.SysContab.ComprobanteDB

        'dsxAnular = VB.SysContab.ComprobanteDB.GetComprobante(Me.VFacturas.GetFocusedRowCellValue("No. Orden Pago"), _
        '     Me.VFacturas.GetFocusedRowCellValue("Proveedor_ID"), _
        '     Me.VFacturas.GetFocusedRowCellValue("Fecha"))

        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction

        Dim ProveId = Me.VFacturas.GetFocusedRowCellValue("Proveedor_ID")
        Dim Factura = Me.VFacturas.GetFocusedRowCellValue("No. Orden Pago")

        Try
            If GuardaDatosTrans("DELETE FROM Facturas_Compras_Lineas WHERE Empresa_Id = " & EmpresaActual & " AND Factura_Id = '" & Factura & "'" & " AND Proveedor_ID = " & ProveId) = False Then
                XtraMsg("Error al modificar, intente nuevamente", MessageBoxIcon.Error)
            End If
            If GuardaDatosTrans("DELETE FROM Facturas_Compras WHERE Empresa_Id = " & EmpresaActual & " AND Factura_ID = '" & Factura & "'" & " AND Proveedor_ID = " & ProveId) = False Then
                XtraMsg("Error al modificar, intente nuevamente", MessageBoxIcon.Error)
            End If
            If GuardaDatosTrans("DELETE FROM FacturasFechas WHERE Empresa = " & EmpresaActual & " AND Factura = '" & Factura & "'" & " AND Proveedor = " & ProveId) = False Then
                XtraMsg("Error al modificar, intente nuevamente", MessageBoxIcon.Error)
            End If
            If GuardaDatosTrans("DELETE FROM FacturasTransacciones WHERE Empresa_Id = " & EmpresaActual & " AND Factura_Id = '" & Factura & "'" & " AND Proveedor_ID = " & ProveId) = False Then
                XtraMsg("Error al modificar, intente nuevamente", MessageBoxIcon.Error)
            End If

            'Comp.ComprobanteAnular(dsxAnular.Tables(0).Rows(0).Item("Comp_No"), _
            '                                       dsxAnular.Tables(0).Rows(0).Item("Per_ID"), _
            '                                        dsxAnular.Tables(0).Rows(0).Item("Comp_Fecha"), 2)

            VB.SysContab.Rutinas.okTransaccion()
            Me.Cargar()
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            VB.SysContab.Rutinas.ErrorTransaccion()
        End Try
    End Sub
    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        If Me.CheckEdit1.Checked Then Me.VFacturas.ShowCustomization()
        If Not Me.CheckEdit1.Checked Then Me.VFacturas.DestroyCustomization()
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExportar.Click
        My.Forms.frmExportarImprimir.Mostrar(Me.dgFacturas, Me.Text,
                                             "Del Periodo: " & Desde.DateTime.ToShortDateString & " Al " & Hasta.DateTime.ToShortDateString)
    End Sub

    Private Sub btnDisenoRet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisenoRet.Click
        Dim f As New FrmConfiguraCheque
        f.Tipo = 5
        f.Text = "Formato Retenciones"
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        ShowSplash()
        Cargar()
        HideSplash()
    End Sub

    Private Sub VFacturas_HideCustomizationForm(sender As Object, e As EventArgs) Handles VFacturas.HideCustomizationForm
        CheckEdit1.Checked = False
    End Sub

    Private Sub VFacturas_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles VFacturas.RowCellStyle
        If e.Column.FieldName = "A Liquidar" Then
            If VFacturas.GetRowCellValue(e.RowHandle, "A Liquidar") Then e.Appearance.BackColor = Color.HotPink
        End If
    End Sub
End Class
