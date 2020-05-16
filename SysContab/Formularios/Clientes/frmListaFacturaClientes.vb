Imports ClasesBLL
Imports System.Linq
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting.BarCode
Imports SysContab.VB.SysContab

Public Class frmListaFacturaClientes
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmListaFacturaClientes = Nothing

    Public Shared Function Instance() As frmListaFacturaClientes
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmListaFacturaClientes()
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
    Friend WithEvents bEntregarProd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bNoEntregados As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPagos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents checkBoxFecha As System.Windows.Forms.CheckBox
    Friend WithEvents etInicio As System.Windows.Forms.Label
    Friend WithEvents cmdAnular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vFacturas As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtpFechaHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpFechaDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GuardarFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbTipoFactura As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cEstadoF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbMeses As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbCajas As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
    Friend WithEvents frmListaFacturaClientesConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents AlertControl1 As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents AlertControl2 As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bImpresoraFiscal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents bEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bElectronica As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bDevolucion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lyDevolucion As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bConsultarFE As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cmddiseño As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaFacturaClientes))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.cEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cEstadoF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.bConsultarFE = New DevExpress.XtraEditors.SimpleButton()
        Me.bDevolucion = New DevExpress.XtraEditors.SimpleButton()
        Me.bElectronica = New DevExpress.XtraEditors.SimpleButton()
        Me.bEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.bImpresoraFiscal = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmddiseño = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.bNoEntregados = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAnular = New DevExpress.XtraEditors.SimpleButton()
        Me.bEntregarProd = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdPagos = New DevExpress.XtraEditors.SimpleButton()
        Me.lyDevolucion = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.frmListaFacturaClientesConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.etInicio = New System.Windows.Forms.Label()
        Me.cbTipoFactura = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbMeses = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbCajas = New DevExpress.XtraEditors.LookUpEdit()
        Me.checkBoxFecha = New System.Windows.Forms.CheckBox()
        Me.dtpFechaHasta = New DevExpress.XtraEditors.DateEdit()
        Me.dtpFechaDesde = New DevExpress.XtraEditors.DateEdit()
        Me.gridDatos = New DevExpress.XtraGrid.GridControl()
        Me.vFacturas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.GuardarFile = New System.Windows.Forms.SaveFileDialog()
        Me.LayoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AlertControl1 = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        Me.AlertControl2 = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.lyDevolucion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmListaFacturaClientesConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmListaFacturaClientesConvertedLayout.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipoFactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMeses.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCajas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'cEstado
        '
        Me.cEstado.Caption = "Estado"
        Me.cEstado.FieldName = "Estado"
        Me.cEstado.Name = "cEstado"
        Me.cEstado.OptionsColumn.AllowEdit = False
        '
        'cEstadoF
        '
        Me.cEstadoF.Caption = "Estado"
        Me.cEstadoF.FieldName = "EstadoF"
        Me.cEstadoF.Name = "cEstadoF"
        Me.cEstadoF.OptionsColumn.AllowEdit = False
        Me.cEstadoF.OptionsColumn.ReadOnly = True
        Me.cEstadoF.Visible = True
        Me.cEstadoF.VisibleIndex = 10
        Me.cEstadoF.Width = 95
        '
        'btnBorrar
        '
        Me.btnBorrar.Appearance.Options.UseTextOptions = True
        Me.btnBorrar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnBorrar.Enabled = False
        Me.btnBorrar.ImageOptions.Image = CType(resources.GetObject("btnBorrar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBorrar.Location = New System.Drawing.Point(12, 180)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(107, 38)
        Me.btnBorrar.StyleController = Me.LayoutControl1
        Me.btnBorrar.TabIndex = 161
        Me.btnBorrar.Text = "&Borrar"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.bConsultarFE)
        Me.LayoutControl1.Controls.Add(Me.bDevolucion)
        Me.LayoutControl1.Controls.Add(Me.bElectronica)
        Me.LayoutControl1.Controls.Add(Me.bEditar)
        Me.LayoutControl1.Controls.Add(Me.cmdSalir)
        Me.LayoutControl1.Controls.Add(Me.bImpresoraFiscal)
        Me.LayoutControl1.Controls.Add(Me.btnExport)
        Me.LayoutControl1.Controls.Add(Me.cmdModificar)
        Me.LayoutControl1.Controls.Add(Me.cmddiseño)
        Me.LayoutControl1.Controls.Add(Me.cmdAyuda)
        Me.LayoutControl1.Controls.Add(Me.bNoEntregados)
        Me.LayoutControl1.Controls.Add(Me.btnPrint)
        Me.LayoutControl1.Controls.Add(Me.cmdAnular)
        Me.LayoutControl1.Controls.Add(Me.btnBorrar)
        Me.LayoutControl1.Controls.Add(Me.bEntregarProd)
        Me.LayoutControl1.Controls.Add(Me.cmdPagos)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lyDevolucion})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup2
        Me.LayoutControl1.Size = New System.Drawing.Size(131, 709)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'bConsultarFE
        '
        Me.bConsultarFE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bConsultarFE.Appearance.Options.UseTextOptions = True
        Me.bConsultarFE.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bConsultarFE.Enabled = False
        Me.bConsultarFE.ImageOptions.Image = CType(resources.GetObject("bConsultarFE.ImageOptions.Image"), System.Drawing.Image)
        Me.bConsultarFE.Location = New System.Drawing.Point(12, 306)
        Me.bConsultarFE.Name = "bConsultarFE"
        Me.bConsultarFE.Size = New System.Drawing.Size(107, 38)
        Me.bConsultarFE.StyleController = Me.LayoutControl1
        Me.bConsultarFE.TabIndex = 164
        Me.bConsultarFE.Text = "&Consultar Fact. Electro"
        '
        'bDevolucion
        '
        Me.bDevolucion.Appearance.Options.UseTextOptions = True
        Me.bDevolucion.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bDevolucion.Enabled = False
        Me.bDevolucion.ImageOptions.Image = CType(resources.GetObject("bDevolucion.ImageOptions.Image"), System.Drawing.Image)
        Me.bDevolucion.Location = New System.Drawing.Point(12, 306)
        Me.bDevolucion.Name = "bDevolucion"
        Me.bDevolucion.Size = New System.Drawing.Size(107, 38)
        Me.bDevolucion.StyleController = Me.LayoutControl1
        Me.bDevolucion.TabIndex = 164
        Me.bDevolucion.Text = "&Devolución Electrónica"
        '
        'bElectronica
        '
        Me.bElectronica.Appearance.Options.UseTextOptions = True
        Me.bElectronica.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bElectronica.Enabled = False
        Me.bElectronica.ImageOptions.Image = CType(resources.GetObject("bElectronica.ImageOptions.Image"), System.Drawing.Image)
        Me.bElectronica.Location = New System.Drawing.Point(12, 264)
        Me.bElectronica.Name = "bElectronica"
        Me.bElectronica.Size = New System.Drawing.Size(107, 38)
        Me.bElectronica.StyleController = Me.LayoutControl1
        Me.bElectronica.TabIndex = 164
        Me.bElectronica.Text = "&Factura Electrónica"
        '
        'bEditar
        '
        Me.bEditar.Appearance.Options.UseTextOptions = True
        Me.bEditar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bEditar.Enabled = False
        Me.bEditar.ImageOptions.Image = CType(resources.GetObject("bEditar.ImageOptions.Image"), System.Drawing.Image)
        Me.bEditar.Location = New System.Drawing.Point(12, 54)
        Me.bEditar.Name = "bEditar"
        Me.bEditar.Size = New System.Drawing.Size(107, 38)
        Me.bEditar.StyleController = Me.LayoutControl1
        Me.bEditar.TabIndex = 164
        Me.bEditar.Text = "&Editar"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Appearance.Options.UseTextOptions = True
        Me.cmdSalir.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdSalir.ImageOptions.Image = CType(resources.GetObject("cmdSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(12, 659)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(107, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl1
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'bImpresoraFiscal
        '
        Me.bImpresoraFiscal.Appearance.Options.UseTextOptions = True
        Me.bImpresoraFiscal.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bImpresoraFiscal.Enabled = False
        Me.bImpresoraFiscal.ImageOptions.Image = CType(resources.GetObject("bImpresoraFiscal.ImageOptions.Image"), System.Drawing.Image)
        Me.bImpresoraFiscal.Location = New System.Drawing.Point(12, 222)
        Me.bImpresoraFiscal.Name = "bImpresoraFiscal"
        Me.bImpresoraFiscal.Size = New System.Drawing.Size(107, 38)
        Me.bImpresoraFiscal.StyleController = Me.LayoutControl1
        Me.bImpresoraFiscal.TabIndex = 163
        Me.bImpresoraFiscal.Text = "Impresora &Fiscal"
        '
        'btnExport
        '
        Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExport.Appearance.Options.UseTextOptions = True
        Me.btnExport.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnExport.Enabled = False
        Me.btnExport.ImageOptions.Image = CType(resources.GetObject("btnExport.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExport.Location = New System.Drawing.Point(12, 617)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(107, 38)
        Me.btnExport.StyleController = Me.LayoutControl1
        Me.btnExport.TabIndex = 159
        Me.btnExport.Text = "&Exportar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Appearance.Options.UseTextOptions = True
        Me.cmdModificar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.ImageOptions.Image = CType(resources.GetObject("cmdModificar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdModificar.Location = New System.Drawing.Point(12, 12)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(107, 38)
        Me.cmdModificar.StyleController = Me.LayoutControl1
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "&Ver"
        '
        'cmddiseño
        '
        Me.cmddiseño.Appearance.Options.UseTextOptions = True
        Me.cmddiseño.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmddiseño.Enabled = False
        Me.cmddiseño.ImageOptions.Image = CType(resources.GetObject("cmddiseño.ImageOptions.Image"), System.Drawing.Image)
        Me.cmddiseño.Location = New System.Drawing.Point(12, 575)
        Me.cmddiseño.Name = "cmddiseño"
        Me.cmddiseño.Size = New System.Drawing.Size(107, 38)
        Me.cmddiseño.StyleController = Me.LayoutControl1
        Me.cmddiseño.TabIndex = 10
        Me.cmddiseño.Text = "&Diseño de Impresión"
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAyuda.Appearance.Options.UseTextOptions = True
        Me.cmdAyuda.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.ImageOptions.Image = CType(resources.GetObject("cmdAyuda.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAyuda.Location = New System.Drawing.Point(12, 474)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(107, 38)
        Me.cmdAyuda.StyleController = Me.LayoutControl1
        Me.cmdAyuda.TabIndex = 9
        Me.cmdAyuda.Text = "Detalle de &Ventas"
        '
        'bNoEntregados
        '
        Me.bNoEntregados.Appearance.Options.UseTextOptions = True
        Me.bNoEntregados.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bNoEntregados.Enabled = False
        Me.bNoEntregados.ImageOptions.Image = CType(resources.GetObject("bNoEntregados.ImageOptions.Image"), System.Drawing.Image)
        Me.bNoEntregados.Location = New System.Drawing.Point(12, 432)
        Me.bNoEntregados.Name = "bNoEntregados"
        Me.bNoEntregados.Size = New System.Drawing.Size(107, 38)
        Me.bNoEntregados.StyleController = Me.LayoutControl1
        Me.bNoEntregados.TabIndex = 1
        Me.bNoEntregados.Text = "Productos &No Entregados"
        '
        'btnPrint
        '
        Me.btnPrint.Appearance.Options.UseTextOptions = True
        Me.btnPrint.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnPrint.Enabled = False
        Me.btnPrint.ImageOptions.Image = CType(resources.GetObject("btnPrint.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(12, 96)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(107, 38)
        Me.btnPrint.StyleController = Me.LayoutControl1
        Me.btnPrint.TabIndex = 160
        Me.btnPrint.Text = "&Imprimir"
        '
        'cmdAnular
        '
        Me.cmdAnular.Appearance.Options.UseTextOptions = True
        Me.cmdAnular.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdAnular.Enabled = False
        Me.cmdAnular.ImageOptions.Image = CType(resources.GetObject("cmdAnular.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAnular.Location = New System.Drawing.Point(12, 138)
        Me.cmdAnular.Name = "cmdAnular"
        Me.cmdAnular.Size = New System.Drawing.Size(107, 38)
        Me.cmdAnular.StyleController = Me.LayoutControl1
        Me.cmdAnular.TabIndex = 8
        Me.cmdAnular.Text = "Anular"
        '
        'bEntregarProd
        '
        Me.bEntregarProd.Appearance.Options.UseTextOptions = True
        Me.bEntregarProd.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bEntregarProd.Enabled = False
        Me.bEntregarProd.ImageOptions.Image = CType(resources.GetObject("bEntregarProd.ImageOptions.Image"), System.Drawing.Image)
        Me.bEntregarProd.Location = New System.Drawing.Point(12, 390)
        Me.bEntregarProd.Name = "bEntregarProd"
        Me.bEntregarProd.Size = New System.Drawing.Size(107, 38)
        Me.bEntregarProd.StyleController = Me.LayoutControl1
        Me.bEntregarProd.TabIndex = 4
        Me.bEntregarProd.Text = "Entregar &Productos"
        '
        'cmdPagos
        '
        Me.cmdPagos.Appearance.Options.UseTextOptions = True
        Me.cmdPagos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdPagos.Enabled = False
        Me.cmdPagos.ImageOptions.Image = CType(resources.GetObject("cmdPagos.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdPagos.Location = New System.Drawing.Point(12, 348)
        Me.cmdPagos.Name = "cmdPagos"
        Me.cmdPagos.Size = New System.Drawing.Size(107, 38)
        Me.cmdPagos.StyleController = Me.LayoutControl1
        Me.cmdPagos.TabIndex = 7
        Me.cmdPagos.Text = "Ver &Pagos"
        '
        'lyDevolucion
        '
        Me.lyDevolucion.Control = Me.bDevolucion
        Me.lyDevolucion.Location = New System.Drawing.Point(0, 294)
        Me.lyDevolucion.MaxSize = New System.Drawing.Size(111, 42)
        Me.lyDevolucion.MinSize = New System.Drawing.Size(111, 42)
        Me.lyDevolucion.Name = "lyDevolucion"
        Me.lyDevolucion.Size = New System.Drawing.Size(111, 42)
        Me.lyDevolucion.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lyDevolucion.Text = "Devolución Electrónica"
        Me.lyDevolucion.TextSize = New System.Drawing.Size(0, 0)
        Me.lyDevolucion.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem15, Me.LayoutControlItem1, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem19, Me.EmptySpaceItem5, Me.LayoutControlItem20, Me.LayoutControlItem18, Me.LayoutControlItem21, Me.LayoutControlItem22, Me.LayoutControlItem23, Me.LayoutControlItem24, Me.LayoutControlItem26})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(131, 709)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmdModificar
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.btnPrint
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.cmdAnular
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.btnBorrar
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.bImpresoraFiscal
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 210)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.cmdPagos
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 336)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.bEntregarProd
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 378)
        Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem17.MinSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.bNoEntregados
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 420)
        Me.LayoutControlItem19.MaxSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem19.MinSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(0, 504)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(111, 59)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.cmdAyuda
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 462)
        Me.LayoutControlItem20.MaxSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem20.MinSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem20.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.cmddiseño
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 563)
        Me.LayoutControlItem18.MaxSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem18.MinSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.btnExport
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 605)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem21.TextVisible = False
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.cmdSalir
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 647)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem22.TextVisible = False
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.bEditar
        Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem23.TextVisible = False
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.bElectronica
        Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 252)
        Me.LayoutControlItem24.MaxSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem24.MinSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem24.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem24.TextVisible = False
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.bConsultarFE
        Me.LayoutControlItem26.Location = New System.Drawing.Point(0, 294)
        Me.LayoutControlItem26.MaxSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem26.MinSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem26.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem26.TextVisible = False
        '
        'frmListaFacturaClientesConvertedLayout
        '
        Me.frmListaFacturaClientesConvertedLayout.Controls.Add(Me.CheckEdit1)
        Me.frmListaFacturaClientesConvertedLayout.Controls.Add(Me.btnBuscar)
        Me.frmListaFacturaClientesConvertedLayout.Controls.Add(Me.etInicio)
        Me.frmListaFacturaClientesConvertedLayout.Controls.Add(Me.cbTipoFactura)
        Me.frmListaFacturaClientesConvertedLayout.Controls.Add(Me.cbMeses)
        Me.frmListaFacturaClientesConvertedLayout.Controls.Add(Me.cbCajas)
        Me.frmListaFacturaClientesConvertedLayout.Controls.Add(Me.checkBoxFecha)
        Me.frmListaFacturaClientesConvertedLayout.Controls.Add(Me.dtpFechaHasta)
        Me.frmListaFacturaClientesConvertedLayout.Controls.Add(Me.dtpFechaDesde)
        Me.frmListaFacturaClientesConvertedLayout.Controls.Add(Me.gridDatos)
        Me.frmListaFacturaClientesConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmListaFacturaClientesConvertedLayout.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem11})
        Me.frmListaFacturaClientesConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.frmListaFacturaClientesConvertedLayout.Name = "frmListaFacturaClientesConvertedLayout"
        Me.frmListaFacturaClientesConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1058, 142, 250, 350)
        Me.frmListaFacturaClientesConvertedLayout.Root = Me.LayoutControlGroup1
        Me.frmListaFacturaClientesConvertedLayout.Size = New System.Drawing.Size(862, 736)
        Me.frmListaFacturaClientesConvertedLayout.TabIndex = 162
        '
        'CheckEdit1
        '
        Me.CheckEdit1.AutoSizeInLayoutControl = True
        Me.CheckEdit1.Location = New System.Drawing.Point(717, 64)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit1.Properties.Caption = "Mostrar Más Datos"
        Me.CheckEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.CheckEdit1.Size = New System.Drawing.Size(133, 22)
        Me.CheckEdit1.StyleController = Me.frmListaFacturaClientesConvertedLayout
        Me.CheckEdit1.TabIndex = 161
        '
        'btnBuscar
        '
        Me.btnBuscar.ImageOptions.Image = CType(resources.GetObject("btnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(207, 22)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(102, 38)
        Me.btnBuscar.StyleController = Me.frmListaFacturaClientesConvertedLayout
        Me.btnBuscar.TabIndex = 162
        Me.btnBuscar.Text = "&Buscar"
        '
        'etInicio
        '
        Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etInicio.Location = New System.Drawing.Point(506, 146)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(490, 22)
        Me.etInicio.TabIndex = 158
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
        '
        'cbTipoFactura
        '
        Me.cbTipoFactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTipoFactura.Location = New System.Drawing.Point(649, 38)
        Me.cbTipoFactura.Name = "cbTipoFactura"
        Me.cbTipoFactura.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoFactura.Properties.Appearance.Options.UseFont = True
        Me.cbTipoFactura.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipoFactura.Properties.ShowFooter = False
        Me.cbTipoFactura.Properties.ShowHeader = False
        Me.cbTipoFactura.Size = New System.Drawing.Size(201, 22)
        Me.cbTipoFactura.StyleController = Me.frmListaFacturaClientesConvertedLayout
        Me.cbTipoFactura.TabIndex = 159
        '
        'cbMeses
        '
        Me.cbMeses.Location = New System.Drawing.Point(649, 12)
        Me.cbMeses.Name = "cbMeses"
        Me.cbMeses.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMeses.Properties.Appearance.Options.UseFont = True
        Me.cbMeses.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMeses.Properties.Items.AddRange(New Object() {"--- Todos ---", "ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cbMeses.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbMeses.Size = New System.Drawing.Size(201, 22)
        Me.cbMeses.StyleController = Me.frmListaFacturaClientesConvertedLayout
        Me.cbMeses.TabIndex = 160
        Me.cbMeses.Visible = False
        '
        'cbCajas
        '
        Me.cbCajas.Location = New System.Drawing.Point(79, 64)
        Me.cbCajas.Name = "cbCajas"
        Me.cbCajas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCajas.Properties.Appearance.Options.UseFont = True
        Me.cbCajas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCajas.Properties.PopupFormMinSize = New System.Drawing.Size(400, 0)
        Me.cbCajas.Properties.ShowFooter = False
        Me.cbCajas.Size = New System.Drawing.Size(634, 22)
        Me.cbCajas.StyleController = Me.frmListaFacturaClientesConvertedLayout
        Me.cbCajas.TabIndex = 161
        '
        'checkBoxFecha
        '
        Me.checkBoxFecha.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBoxFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.checkBoxFecha.Location = New System.Drawing.Point(491, 12)
        Me.checkBoxFecha.Name = "checkBoxFecha"
        Me.checkBoxFecha.Size = New System.Drawing.Size(87, 22)
        Me.checkBoxFecha.TabIndex = 150
        Me.checkBoxFecha.Text = "Por Fecha"
        Me.checkBoxFecha.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.checkBoxFecha.Visible = False
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.EditValue = Nothing
        Me.dtpFechaHasta.Location = New System.Drawing.Point(79, 36)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dtpFechaHasta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaHasta.Properties.Appearance.Options.UseFont = True
        Me.dtpFechaHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaHasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaHasta.Properties.Mask.BeepOnError = True
        Me.dtpFechaHasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dtpFechaHasta.Size = New System.Drawing.Size(124, 20)
        Me.dtpFechaHasta.StyleController = Me.frmListaFacturaClientesConvertedLayout
        Me.dtpFechaHasta.TabIndex = 157
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.EditValue = Nothing
        Me.dtpFechaDesde.Location = New System.Drawing.Point(79, 12)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dtpFechaDesde.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaDesde.Properties.Appearance.Options.UseFont = True
        Me.dtpFechaDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaDesde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaDesde.Properties.Mask.BeepOnError = True
        Me.dtpFechaDesde.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dtpFechaDesde.Size = New System.Drawing.Size(124, 20)
        Me.dtpFechaDesde.StyleController = Me.frmListaFacturaClientesConvertedLayout
        Me.dtpFechaDesde.TabIndex = 157
        '
        'gridDatos
        '
        Me.gridDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDatos.Location = New System.Drawing.Point(12, 90)
        Me.gridDatos.MainView = Me.vFacturas
        Me.gridDatos.Name = "gridDatos"
        Me.gridDatos.Size = New System.Drawing.Size(838, 634)
        Me.gridDatos.TabIndex = 159
        Me.gridDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vFacturas})
        '
        'vFacturas
        '
        Me.vFacturas.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vFacturas.Appearance.HeaderPanel.Options.UseFont = True
        Me.vFacturas.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.vFacturas.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.vFacturas.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.vFacturas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn15, Me.GridColumn13, Me.GridColumn5, Me.GridColumn7, Me.GridColumn6, Me.GridColumn8, Me.GridColumn9, Me.GridColumn19, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.cEstado, Me.GridColumn14, Me.cEstadoF, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.AliceBlue
        StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.AliceBlue
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.cEstado
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = 1
        StyleFormatCondition1.Value2 = 1
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.AliceBlue
        StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.AliceBlue
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.DarkRed
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Column = Me.cEstadoF
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "ANULADA"
        StyleFormatCondition2.Value2 = "ANULADA"
        Me.vFacturas.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.vFacturas.GridControl = Me.gridDatos
        Me.vFacturas.Name = "vFacturas"
        Me.vFacturas.OptionsFind.AlwaysVisible = True
        Me.vFacturas.OptionsFind.ShowClearButton = False
        Me.vFacturas.OptionsView.ShowAutoFilterRow = True
        Me.vFacturas.OptionsView.ShowFooter = True
        Me.vFacturas.OptionsView.ShowGroupPanel = False
        Me.vFacturas.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "No Factura"
        Me.GridColumn1.FieldName = "No Factura"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "No Factura", "{0:d}")})
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 73
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Fecha"
        Me.GridColumn2.FieldName = "Fecha"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Vencimiento"
        Me.GridColumn3.FieldName = "Fecha Vencimiento"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 83
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Cliente"
        Me.GridColumn4.FieldName = "Cliente"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 156
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Código"
        Me.GridColumn15.FieldName = "Codigo"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.OptionsColumn.ReadOnly = True
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 4
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Forma Pago"
        Me.GridColumn13.FieldName = "Forma Pago"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 5
        Me.GridColumn13.Width = 93
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Monto"
        Me.GridColumn5.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "Monto"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Monto", "{0:n2}")})
        Me.GridColumn5.Width = 72
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Sub Total"
        Me.GridColumn7.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "Sub Total"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Sub Total", "{0:n2}")})
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        Me.GridColumn7.Width = 66
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Descuento"
        Me.GridColumn6.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "Descuento"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Descuento", "{0:n2}")})
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "IVA"
        Me.GridColumn8.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "IVA"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IVA", "{0:n2}")})
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        Me.GridColumn8.Width = 47
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Total"
        Me.GridColumn9.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "Total"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:n2}")})
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 8
        Me.GridColumn9.Width = 76
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Total U$"
        Me.GridColumn19.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn19.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn19.FieldName = "TotalU"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.OptionsColumn.AllowEdit = False
        Me.GridColumn19.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalU", "{0:n2}")})
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 9
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Abono"
        Me.GridColumn10.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn10.FieldName = "Abono"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Abono", "{0:n2}")})
        Me.GridColumn10.Width = 64
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Saldo"
        Me.GridColumn11.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn11.FieldName = "Saldo"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Saldo", "{0:n2}")})
        Me.GridColumn11.Width = 72
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Numero"
        Me.GridColumn12.FieldName = "Numero"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "DIAS"
        Me.GridColumn14.FieldName = "DIAS"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        Me.GridColumn14.Width = 79
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Tipo"
        Me.GridColumn16.FieldName = "Tipo"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.AllowEdit = False
        Me.GridColumn16.OptionsColumn.AllowFocus = False
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Caja"
        Me.GridColumn17.FieldName = "Caja"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Contabilizada"
        Me.GridColumn18.FieldName = "Contab"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.AllowEdit = False
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 11
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Saldo U$"
        Me.GridColumn20.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn20.FieldName = "SaldoU"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.OptionsColumn.AllowEdit = False
        Me.GridColumn20.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SaldoU", "{0:n2}")})
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Vendedor"
        Me.GridColumn21.FieldName = "Vendedor"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.OptionsColumn.AllowEdit = False
        Me.GridColumn21.OptionsColumn.AllowFocus = False
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "IR"
        Me.GridColumn22.FieldName = "Fact_IR"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.OptionsColumn.AllowEdit = False
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 12
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "IR_Alcaldia"
        Me.GridColumn23.FieldName = "IR_Alcaldia"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.OptionsColumn.AllowEdit = False
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 13
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "Formato"
        Me.GridColumn24.FieldName = "Formato"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.OptionsColumn.AllowEdit = False
        Me.GridColumn24.OptionsColumn.AllowFocus = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.etInicio
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(494, 134)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(494, 26)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.EmptySpaceItem1, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem12, Me.EmptySpaceItem2, Me.LayoutControlItem7, Me.EmptySpaceItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(862, 736)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.gridDatos
        Me.LayoutControlItem3.CustomizationFormText = "gridDatositem"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 78)
        Me.LayoutControlItem3.Name = "gridDatositem"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(842, 638)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.dtpFechaDesde
        Me.LayoutControlItem4.CustomizationFormText = "Desde:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(195, 24)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(195, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(195, 24)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "Desde:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(64, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.dtpFechaHasta
        Me.LayoutControlItem5.CustomizationFormText = "Hasta:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(195, 28)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(195, 28)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(195, 28)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "Hasta:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(64, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cbCajas
        Me.LayoutControlItem6.CustomizationFormText = "Caja:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(705, 26)
        Me.LayoutControlItem6.Text = "Caja:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(64, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(301, 26)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(269, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cbMeses
        Me.LayoutControlItem8.CustomizationFormText = "Mes"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(570, 0)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(272, 26)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(272, 26)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(272, 26)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.Text = "Mes"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(64, 13)
        Me.LayoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.checkBoxFecha
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(479, 0)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(91, 26)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(91, 26)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(91, 26)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        Me.LayoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cbTipoFactura
        Me.LayoutControlItem10.CustomizationFormText = "Tipo Factura:"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(570, 26)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(272, 26)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(272, 26)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(272, 26)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.Text = "Tipo Factura:"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(64, 13)
        Me.LayoutControlItem10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.CheckEdit1
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(705, 52)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(137, 26)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(137, 26)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(137, 26)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(301, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(178, 26)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.btnBuscar
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(195, 10)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(195, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(106, 10)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'GuardarFile
        '
        Me.GuardarFile.Filter = "Archivos de Excel (*.xls)|*.xls"
        Me.GuardarFile.Title = "Exportar Datos"
        '
        'Timer1
        '
        Me.Timer1.Interval = 30000
        '
        'AlertControl1
        '
        Me.AlertControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlertControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Red
        Me.AlertControl1.AppearanceCaption.Options.UseFont = True
        Me.AlertControl1.AppearanceCaption.Options.UseForeColor = True
        Me.AlertControl1.AppearanceText.ForeColor = System.Drawing.Color.MediumBlue
        Me.AlertControl1.AppearanceText.Options.UseForeColor = True
        Me.AlertControl1.AutoFormDelay = 20000
        Me.AlertControl1.AutoHeight = True
        Me.AlertControl1.FormDisplaySpeed = DevExpress.XtraBars.Alerter.AlertFormDisplaySpeed.Slow
        Me.AlertControl1.FormMaxCount = 2
        '
        'AlertControl2
        '
        Me.AlertControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlertControl2.AppearanceCaption.ForeColor = System.Drawing.Color.LightCoral
        Me.AlertControl2.AppearanceCaption.Options.UseFont = True
        Me.AlertControl2.AppearanceCaption.Options.UseForeColor = True
        Me.AlertControl2.AppearanceText.ForeColor = System.Drawing.Color.MediumBlue
        Me.AlertControl2.AppearanceText.Options.UseForeColor = True
        Me.AlertControl2.AutoFormDelay = 20000
        Me.AlertControl2.AutoHeight = True
        Me.AlertControl2.FormDisplaySpeed = DevExpress.XtraBars.Alerter.AlertFormDisplaySpeed.Slow
        Me.AlertControl2.FormMaxCount = 2
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.ID = New System.Guid("30d726fc-2068-4eb4-990e-f6cf8e297516")
        Me.DockPanel1.Location = New System.Drawing.Point(862, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(140, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(140, 736)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(131, 709)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'frmListaFacturaClientes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1002, 736)
        Me.Controls.Add(Me.frmListaFacturaClientesConvertedLayout)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "frmListaFacturaClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.lyDevolucion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmListaFacturaClientesConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmListaFacturaClientesConvertedLayout.ResumeLayout(False)
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipoFactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMeses.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCajas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Clientes As New VB.SysContab.ClientesDB()
    Dim Cajas As New VB.SysContab.CajasDB()
    Dim FormaPago As New VB.SysContab.Forma_PagoDB()
    Dim r As New VB.SysContab.Rutinas()
    Dim ds As DataSet

    Dim FacturasVencidas As Integer = 0
    Dim FvProximasVencer As Integer = 0
    Dim DT_ROL As DataTable = Nothing

    Private Sub frmListaFacturaClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'GetFormaPagoListAll(Me.cbTipoFactura)
        'GetCajasFacturacion(Me.cbCajas)

        GetCajasxUsuario(Me.cbCajas)

        'cbEstado.SelectedIndex = 0
        'cbMeses.SelectedIndex = Now.Month

        'cbClientes.DataSource = Clientes.GetList.Tables("Clientes")
        'cbClientes.ValueMember = "Codigo"
        'cbClientes.DisplayMember = "Nombre"
        'cbTipoFactura.DataSource = FormaPago.FormaPagoListAll().Tables("Forma_Pago")
        'cbTipoFactura.ValueMember = "Codigo"
        'cbTipoFactura.DisplayMember = "Nombre"

        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date

        Me.dtpFechaDesde.DateTime = New DateTime(f.Year, f.Month, 1)
        Me.dtpFechaHasta.DateTime = f.Date

        'Fecha1 = ""
        'Fecha2 = ""

        'dtpFechaDesde.Enabled = False
        'dtpFechaHasta.Enabled = False

        Cargar()
        Formato()

        'r.FormatGenerico(dgFacturasClientes, Tabla)
        'If ds.Tables("Facturas_Ventas").Rows.Count <> 0 Then
        '    Registro = dgFacturasClientes.Item(0, 0)
        'Else
        '    Registro = "Vacio"
        'End If
        'dgFacturasClientes.CaptionText = "Información de Facturas Clientes"
        ''VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        'Me.Text = "F a c t u r a s  C l i e n t e s"


        Me.etInicio.Text = "0"
        DT_ROL = RolesDB.UsuarioAcciones(LayoutControl1)

        FacturasVencidas = ObtieneDatos("JAR_GetFacturasVencidas", EmpresaActual, 2).Rows.Item(0)("CANTIDAD")
        FvProximasVencer = ObtieneDatos("JAR_GetFacturasProximasAVencer", EmpresaActual, 2).Rows.Item(0)("CANTIDAD")

        If DT_ROL.Rows.Count > 0 Then
            'Verificar si el Usuario tiene permiso de Cambiar los IR a Facturas
            Dim dr() As DataRow = DT_ROL.Select("Control = 'IR'")

            If dr.Length > 0 Then
                vFacturas.Columns("Fact_IR").OptionsColumn.AllowEdit = True
                vFacturas.Columns("IR_Alcaldia").OptionsColumn.AllowEdit = True
            End If

            'Verificar si el usuario tendra activas las Alertas
            Dim dr2() As DataRow = DT_ROL.Select("Control = 'Alertas'")
            If dr2.Length > 0 Then IniciaContador(1000)
        End If
    End Sub

    Sub Cargar()
        If etInicio.Text = "0" Then ShowSplash()

        ds = Clientes.FacturasXTipoList(
            0,
            0,
            dtpFechaDesde.DateTime.Date,
            dtpFechaHasta.DateTime.Date,
            cbCajas.EditValue)

        gridDatos.DataSource = ds.Tables("Facturas_Ventas") _
            .DefaultView

        'Me.vFacturas.Columns("No Factura").BestFit()
        'Me.vFacturas.Columns("Fecha").BestFit()
        'Me.vFacturas.Columns("Fecha Vencimiento").BestFit()
        'Me.vFacturas.Columns("Cliente").BestFit()
        '
        If etInicio.Text = "0" Then HideSplash()
    End Sub

    Sub Formato()
        vFacturas.PopulateColumns()
        FormatoGrid(vFacturas, 2, 0)

        ' vFacturas.Columns("Monto").Visible = FalseC
        vFacturas.Columns("Numero").Visible = False
        vFacturas.Columns("Abono").Visible = False
        vFacturas.Columns("Saldo").Visible = False
        vFacturas.Columns("Estado").Visible = False
        vFacturas.Columns("DIAS").Visible = False
        vFacturas.Columns("Vendedor").Visible = False
        vFacturas.Columns("Caja").Visible = False
        vFacturas.Columns("Formato").Visible = False
        vFacturas.Columns("Comp_No").Visible = False
        vFacturas.Columns("Dias de Pago").Visible = False
        vFacturas.Columns("Registro").Visible = False
        vFacturas.Columns("Cuenta").Visible = False
        vFacturas.Columns("Agro").Visible = False
        vFacturas.Columns("O/C").Visible = False
        vFacturas.Columns("O/Entrega").Visible = False
        vFacturas.Columns("T/C").Visible = False
        vFacturas.Columns("Fact_IR").Visible = False
        vFacturas.Columns("IR_Alcaldia").Visible = False
        vFacturas.Columns("Exento").Visible = False
        vFacturas.Columns("Remision").Visible = False

        vFacturas.Columns("EstadoF").Caption = "Estado"
        vFacturas.Columns("Contab").Caption = "Contabilizada"
        vFacturas.Columns("Fecha Vencimiento").Caption = "Vencimiento"
        vFacturas.Columns("TotalU").Caption = "Total U$"

        'vFacturas.Columns("A Nombre").Width = 250

        Me.vFacturas.Columns("Numero").OptionsColumn.ShowInCustomizationForm = False
        Me.vFacturas.Columns("DIAS").OptionsColumn.ShowInCustomizationForm = False
        Me.vFacturas.Columns("Estado").OptionsColumn.ShowInCustomizationForm = False

        For i As Integer = 0 To vFacturas.Columns.Count - 1
            vFacturas.Columns(i).OptionsColumn.AllowEdit = False
        Next

        vFacturas.Columns("EstadoF").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        vFacturas.Columns("Entrega").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bNoEntregados.Click
        ShowSplash()

        frmProductosNoEntregados.Dispose()
        frmProductosNoEntregados.MdiParent = Me.MdiParent
        frmProductosNoEntregados.Show()
        frmProductosNoEntregados.Text = "Productos No Entregados"
        frmProductosNoEntregados.WindowState = FormWindowState.Maximized

        HideSplash()


        'frmFacturasClientes_SaldoInicial.Dispose()
        'frmFacturasClientes_SaldoInicial.MdiParent = Me.MdiParent
        'frmFacturasClientes_SaldoInicial.Show()
        'frmFacturasClientes_SaldoInicial.WindowState = FormWindowState.Maximized
        ''        Dim f As DataGridTextBoxCombo.frmFacturacionCliente = f.Instance
        'Dim F As FrmFacturacionClienteNew = F.Instance
        'F.txtCaja.Text = Cajas.PcNombre(Environment.MachineName.ToString).Tables("Cajas").Rows(0).Item("cj_Codigo").ToString
        'NuevaFactura = "SI"
        'F.MdiParent = Me.MdiParent
        'F.WindowState = FormWindowState.Maximized
        'F.Show()        
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If vFacturas.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione una Factura")
            Exit Sub
        End If
        '
        frmFacturasVentasEditar.Dispose()

        With frmFacturasVentasEditar
            ShowSplash()
            '
            .MdiParent = Me.MdiParent
            .Factura = vFacturas.GetFocusedRowCellValue("No Factura")

            .Show()
            .bGuardar.Enabled = False
            .vFact.OptionsBehavior.Editable = False
            .Text = "Ver Factura"
            .WindowState = FormWindowState.Maximized
            '
            HideSplash()
        End With





        'If Me.dgFacturasClientes.CurrentRowIndex = ds.Tables("Facturas_Ventas").Rows.Count - 1 Then
        '    MsgBox("Seleccione una Factura", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'If Me.vFacturas.FocusedRowHandle < 0 Then
        '    XtraMsg("Seleccione una Factura")
        '    Exit Sub
        'End If

        'Dim f As DataGridTextBoxCombo.frmFacturacionClienteVer = DataGridTextBoxCombo.frmFacturacionClienteVer.Instance()

        'Registro = Me.vFacturas.GetFocusedRowCellValue("No Factura")
        ''Registro = dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 0)

        ''If Registro = "Vacio" Then
        ''    MsgBox("Seleccione la Factura", MsgBoxStyle.Information)
        ''    Exit Sub
        ''End If

        'f.MdiParent = Me.MdiParent
        'f.Show()
        'f.Text = "Ver Factura"
        'f.WindowState = FormWindowState.Maximized

    End Sub

    'Private Sub dgFacturasClientes_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFacturasClientes.CurrentCellChanged
    '    Registro = dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 0)
    'End Sub

    Private Sub frmListaFacturaClientes_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        'VB.SysContab.Rutinas.OcultarMenu(FormPrincipal)
    End Sub

    Private Sub dgFacturasClientes_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        'VB.SysContab.Rutinas.OcultarMenu(FormPrincipal)
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bEntregarProd.Click
        If Me.vFacturas.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione una Factura")
            Exit Sub
        End If

        With frmEntregarProducto
            .NoFactura = vFacturas.GetFocusedRowCellValue("No Factura")
            .Text = "Entregar Producto"
            .ShowDialog()
            .Dispose()
        End With

        ''Dim fReportes As New frmReportes()
        ''Dim rFacturas As New rptFacturas()
        ''Dim Clientes As New VB.SysContab.ClientesDB()

        ''rFacturas.SetDataSource(Clientes.FacturasPrint(Registro))
        ''fReportes.crvReportes.ReportSource = rFacturas

        ''freportes.Show()
        'Dim f As frmReportesFactura = frmReportesFactura.Instance()
        'f.MdiParent = Me.MdiParent
        'f.WindowState = FormWindowState.Maximized
        'f.Show()
    End Sub

    'Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar1.TextChanged
    '    Try
    '        'If cbTipoFactura.Enabled = True Then
    '        dgFacturasClientes.DataSource = Clientes.FacturasXTipoList(txtBuscar.Text, cbTFCodigo.Text, cbMeses.SelectedIndex, cbEstado.SelectedIndex).Tables("Facturas_Ventas").DefaultView

    '        If Clientes.FacturasXTipoList(txtBuscar.Text, cbTFCodigo.Text, cbMeses.SelectedIndex, cbEstado.SelectedIndex).Tables("Facturas_Ventas").Rows.Count = 0 Then
    '            Registro = "Vacio"
    '            Exit Sub

    '        End If
    '        'Else
    '        '    dgFacturasClientes.DataSource = Clientes.ListFacturas(txtBuscar.Text).Tables("Facturas_Ventas").DefaultView

    '        '    If Clientes.ListFacturas(txtBuscar.Text).Tables("Facturas_Ventas").Rows.Count = 0 Then
    '        '        Registro = "Vacio"
    '        '        Exit Sub

    '        '    End If
    '        'End If
    '        Registro = dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 0)
    '    Catch ex As Exception

    '    End Try

    'End Sub

    'Private Sub dgFacturasClientes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFacturasClientes.DoubleClick
    '    If Me.dgFacturasClientes.CurrentRowIndex = ds.Tables("Facturas_Ventas").Rows.Count - 1 Then
    '        MsgBox("Seleccione una Factura", MsgBoxStyle.Information)
    '        Exit Sub
    '    End If

    '    Dim f As DataGridTextBoxCombo.frmFacturacionClienteVer = f.Instance
    '    Registro = dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 0)

    '    If Registro = "Vacio" Then
    '        MsgBox("Seleccione la Factura", MsgBoxStyle.Information)
    '        Exit Sub
    '    End If

    '    f.MdiParent = Me.MdiParent
    '    f.Show()
    '    f.WindowState = FormWindowState.Maximized

    'End Sub

    Private Sub cmdPagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPagos.Click
        Dim ds As DataSet
        'Registro = dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 0)
        'If Registro = "Vacio" Then
        '    MsgBox("Seleccione la Factura", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        If Me.vFacturas.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione la Factura")
            Exit Sub
        End If

        Registro = Me.vFacturas.GetFocusedRowCellValue("No Factura")

        ds = Clientes.CobrosHistorial(Registro)

        If ds.Tables("Cobros").Rows.Count = 0 Then
            XtraMsg("La Factura seleccionada no tiene ningún pago", MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim f As frmHistorialCobros = frmHistorialCobros.Instance()

        f.MdiParent = Me.MdiParent
        f.WindowState = FormWindowState.Maximized
        f.Show()
        f.Text = "Historico de Pagos"
        f.WindowState = FormWindowState.Maximized

    End Sub

    'Private Sub cbTipoFactura_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTipoFactura.SelectedValueChanged
    '    Try
    '        If IsNumeric(cbTipoFactura.SelectedValue) And cbTipoFactura.Enabled = True Then
    '            dgFacturasClientes.DataSource = Clientes.FacturasXTipo(txtBuscar.Text, cbTipoFactura.SelectedValue.ToString, cbMeses.SelectedIndex).Tables("Facturas_Ventas").DefaultView
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Sub cbTipo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipo.CheckedChanged
    '    If cbTipo.Checked = True Then
    '        dgFacturasClientes.DataSource = Clientes.FacturasXTipo(txtBuscar.Text, cbTipoFactura.SelectedValue.ToString, cbMeses.SelectedIndex).Tables("Facturas_Ventas").DefaultView
    '        cbTipoFactura.Enabled = True
    '    Else
    '        cbTipoFactura.Enabled = False
    '        dgFacturasClientes.DataSource = Clientes.ListFacturas("").Tables("Facturas_Ventas").DefaultView
    '    End If
    'End Sub

    Private Sub checkBoxFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkBoxFecha.CheckedChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        Try
            If checkBoxFecha.Checked = True Then
                cbMeses.SelectedIndex = 0
                dtpFechaDesde.Enabled = True
                dtpFechaHasta.Enabled = True
                cbMeses.Enabled = False

                Fecha1 = dtpFechaDesde.DateTime.Date
                Fecha2 = dtpFechaHasta.DateTime.Date
                Me.dtpFechaHasta.Properties.MinValue = Me.dtpFechaDesde.DateTime
            Else
                cbMeses.Enabled = True
                dtpFechaDesde.Enabled = False
                dtpFechaHasta.Enabled = False
                Fecha1 = ""
                Fecha2 = ""
            End If
            Cargar()
        Catch ex As ExecutionEngineException
        End Try
    End Sub

    Private Sub cbEstado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'If etInicio.Text = "1" Then
        '    Exit Sub
        'End If

        'Try
        '    Cargar()
        'Catch ex As Exception
        'End Try
    End Sub

    'Dim dsBuscar As DataSet
    'Private Sub cbClientes_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbClientes.TextChanged
    '    If Not IsNumeric(Me.cbTipoFactura.SelectedValue) Or Not IsNumeric(Me.cbMeses.SelectedIndex) Or Not IsNumeric(cbClientes.SelectedValue) Or Not IsNumeric(Me.cbEstado.SelectedIndex) Then
    '        Exit Sub
    '    End If

    '    Try
    '        If checkBoxFecha.Checked = True Then
    '            ds = Clientes.FacturasXFecha(cbClientes.Text, cbTipoFactura.SelectedValue, dtpFechaDesde.Value.ToShortDateString, dtpFechaHasta.Value.ToShortDateString, cbEstado.SelectedIndex)
    '        Else
    '            ds = Clientes.FacturasXTipoList(cbClientes.Text, cbTipoFactura.SelectedValue, cbMeses.SelectedIndex, cbEstado.SelectedIndex)
    '        End If

    '        dgFacturasClientes.DataSource = ds.Tables("Facturas_Ventas").DefaultView

    '        If ds.Tables("Facturas_Ventas").Rows.Count = 0 Then
    '            Registro = "Vacio"
    '            Exit Sub
    '        End If

    '        Registro = dgFacturasClientes.Item(0, 0)
    '    Catch ex As Exception
    '        MsgBox(ex.Message & " cbClientes_TextChanged")

    '    End Try
    'End Sub

    Private Sub cbClientes_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'If etInicio.Text = "1" Then
        '    Exit Sub
        'End If

        'Try
        '    'If checkBoxFecha.Checked = True Then
        '    '    ds = Clientes.FacturasXFecha(cbClientes.Text, cbTipoFactura.SelectedValue, dtpFechaDesde.Value.ToShortDateString, dtpFechaHasta.Value.ToShortDateString, cbEstado.SelectedIndex)
        '    'Else
        '    ds = Clientes.FacturasXTipoList("", cbClientes.Text, cbTipoFactura.SelectedValue, cbMeses.SelectedIndex, cbEstado.SelectedIndex, Fecha1, Fecha2)
        '    'End If

        '    'dgFacturasClientes.DataSource = ds.Tables("Facturas_Ventas").DefaultView

        '    'If ds.Tables("Facturas_Ventas").Rows.Count = 0 Then
        '    '    Registro = "Vacio"
        '    '    Exit Sub
        '    'End If

        '    'Registro = dgFacturasClientes.Item(0, 0)
        'Catch ex As Exception
        '    MsgBox(ex.Message & " cbClientes_SelectedValueChanged")
        'End Try
    End Sub

    'Private Sub cmdSalidaBodega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim f As DataGridTextBoxCombo.frmSalidaBodega = f.Instance

    '    'f.txtFactura.Text = dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 0)

    '    f.MdiParent = Me.MdiParent
    '    f.Show()
    '    f.WindowState = FormWindowState.Maximized

    'End Sub

    Private Sub cmdAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnular.Click

        'Dim dsFactura As DataSet
        'Dim dsComp As DataSet
        'Dim Articulos As New VB.SysContab.ArticulosDB()
        'Dim Comp As New VB.SysContab.ComprobanteDB()
        ' Dim i As Integer

        If Me.vFacturas.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione una Factura")
            Exit Sub
        End If

        'Verificar Cierre del Día
        '------------------------------------------------------------------------------------
        If Not VerificarCierre(CDate(vFacturas.GetFocusedRowCellValue("Fecha")).Date) Then
            Exit Sub
        End If
        '-------------------------------------------------------------------------------------

        If vFacturas.GetFocusedRowCellValue("Estado") Then
            XtraMsg("La factura ya se encuentra Anulada.", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        If vFacturas.GetFocusedRowCellValue("ATV") <> "n/a" Then
            XtraMsg("La factura ya fue reportada como Factura Electrónica, NO SE PUEDE ANULAR!!!", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If vFacturas.GetFocusedRowCellValue("Bolsa") Then
            XtraMsg("La factura ya fué reportada en Bolsa, no se puede Anular...",
                    MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        'If vFacturas.GetFocusedRowCellValue("Fiscal") Then
        '    XtraMsg("La factura ya se genero XML para Impresora Fiscal, NO SE PUEDE ANULAR!!!", MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        '
        If vFacturas.GetFocusedRowCellValue("Entrega") = "Devuelto" Then
            XtraMsg("La factura contiene Devolución asociada.", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        If Clientes.FacturaSalida(vFacturas.GetFocusedRowCellValue("No Factura")).Tables("Facturas_Ventas").Rows.Count <> 0 Then
            XtraMsg("La factura no puede ser anulada porque ya fue descargada de Inventario.", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        If vFacturas.GetFocusedRowCellValue("Contab") Then
            XtraMsg("La factura ya fue Contabilizada", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        If ObtieneDatos("JAR_GetRecibosxFactura", vFacturas.GetFocusedRowCellValue("No Factura"), EmpresaActual).Rows.Count > 0 Then
            XtraMsg("La Factura Contiene Pagos, NO SE PUEDE ANULAR!!!", MessageBoxIcon.Error)

            With frmRecibosxFactura

                .Titulo.Text = "La Factura Contiene los siguientes recibos de Caja." '' & vbCrLf & "Anular de todas formas?"
                .Cliente.Text = "CLIENTE: " & Me.vFacturas.GetFocusedRowCellValue("Cliente")
                .Factura = Me.vFacturas.GetFocusedRowCellValue("No Factura")
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
        Try

            If Not XtraMsg2("Desea Anular la Factura?") Then
                Exit Sub
            End If

            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction

            Clientes.UpdateFacturaEstado(vFacturas.GetFocusedRowCellValue("No Factura"), 1)
            Clientes.FacturaCobroDelete(vFacturas.GetFocusedRowCellValue("No Factura"))

            'Try
            '    dsComp = Clientes.ComprobanteBuscarXFactura(Me.vFacturas.GetFocusedRowCellValue("No Factura"), 0)
            '    Comp.ComprobanteAnular(dsComp.Tables("Tabla").Rows(0).Item("Comp_No"), dsComp.Tables("Tabla").Rows(0).Item("Per_ID"), dsComp.Tables("Tabla").Rows(0).Item("Fecha"))
            'Catch ex As Exception
            'End Try

            'MsgBox("Hasta Aqui Todo bien....")

            'For i = 0 To dsFactura.Tables("Facturas_Ventas").Rows.Count - 1
            '    Articulos.SumarExistencias(dsFactura.Tables("Facturas_Ventas").Rows(i).Item("Item"), dsFactura.Tables("Facturas_Ventas").Rows(i).Item("Cantidad"), "P")
            'Next

            VB.SysContab.Rutinas.okTransaccion()
            '
            If EmpresaActual = "26" Then
                Dim fv As New Factura_ElectronicaCR
                fv.ImpresoraFiscalXML(vFacturas.GetFocusedRowCellValue("No Factura"), 3, True)
            End If
            '
            Cargar()
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            VB.SysContab.Rutinas.ErrorTransaccion()
        End Try
    End Sub


    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        'Help.ShowHelp(Me, "ayuda/ClientesFacturas.chm")
        frmDetalleVentasCostos.Dispose()

        With frmDetalleVentasCostos
            .Desde = dtpFechaDesde.DateTime.Date
            .Hasta = dtpFechaHasta.DateTime.Date
            .Caja = cbCajas.EditValue
            .Tipo = 3
            .lblTipo.Text = "Detalle Ventas Del: " & dtpFechaDesde.DateTime.ToShortDateString & " al: " & dtpFechaHasta.DateTime.ToShortDateString
            .WindowState = FormWindowState.Maximized
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub cmddiseño_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddiseño.Click
        If ObtieneDatos("sp_sel_TipoFacturas", 0, EmpresaActual).Rows.Count > 0 Then

            With FrmFormatos
                .Text = "Diseño de Formatos de Factura"
                .Show()
                .WindowState = FormWindowState.Maximized
            End With

        Else
            With frmDiseñoFacturaCliente
                .ShowDialog()
                If .ok = "SI" Then
                    With FrmConfiguraCheque
                        .Tipo = My.Forms.frmDiseñoFacturaCliente.RadioGroup1.EditValue ''Es un Número que identifica el tipo de documento
                        .Text = "Diseño Factura"
                        .Show()
                        .WindowState = FormWindowState.Maximized
                    End With
                End If
                .Dispose()
            End With
        End If
        'My.Forms.frmDiseñoFacturaCliente.ShowDialog()

        'If My.Forms.frmDiseñoFacturaCliente.ok = "SI" Then

        '    With FrmConfiguraCheque
        '        .Tipo = My.Forms.frmDiseñoFacturaCliente.RadioGroup1.EditValue ''Es un Número que identifica el tipo de documento
        '        .Text = "Diseño Factura"
        '        .Show()
        '        .WindowState = FormWindowState.Maximized
        '    End With
        '    'Dim forma As New FrmConfiguraCheque

        '    'forma.Tipo = My.Forms.frmDiseñoFacturaCliente.RadioGroup1.EditValue
        '    'forma.Text = "Diseño Factura"
        '    'forma.Show()
        'End If
        'My.Forms.frmDiseñoFacturaCliente.Dispose()

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        If Me.vFacturas.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione una Factura")
            Exit Sub
        End If

        If vFacturas.GetFocusedRowCellValue("Formato") = 0 Then Facturas_VentasDB.ImprimirFactura(vFacturas.GetFocusedRowCellValue("No Factura"),
                                                                                                  vFacturas.GetFocusedRowCellValue("DIAS"))

        If vFacturas.GetFocusedRowCellValue("Formato") <> 0 Then Facturas_VentasDB.ImprimirFactura2(vFacturas.GetFocusedRowCellValue("No Factura"),
                                                                                                    vFacturas.GetFocusedRowCellValue("Formato"))

        'If vFacturas.GetFocusedRowCellValue("Formato") = 0 Then ImprimirNormal()
        'If vFacturas.GetFocusedRowCellValue("Formato") <> 0 Then Imprimir2()

        'Dim rpt As New rptCodigoQR
        'rpt.ShowRibbonPreview
    End Sub

    Public Function CreateQRCodeBarCode(ByVal BarCodeText As String) As XRBarCode
        ' Create a bar code control.
        Dim barCode As New XRBarCode()

        ' Set the bar code's type to QRCode.
        barCode.Symbology = New QRCodeGenerator()

        ' Adjust the bar code's main properties.
        barCode.Text = BarCodeText
        barCode.Width = 400
        barCode.Height = 150

        ' If the AutoModule property is set to false, uncomment the next line.
        barCode.AutoModule = True
        ' barcode.Module = 3;

        ' Adjust the properties specific to the bar code type.
        CType(barCode.Symbology, QRCodeGenerator).CompactionMode = QRCodeCompactionMode.AlphaNumeric
        CType(barCode.Symbology, QRCodeGenerator).ErrorCorrectionLevel = QRCodeErrorCorrectionLevel.H
        CType(barCode.Symbology, QRCodeGenerator).Version = QRCodeVersion.AutoVersion

        Return barCode
    End Function


    'Sub ImprimirNormal()

    '    Dim Cadena As String
    '    Dim Temp As Boolean = False
    '    Dim Data() As Byte

    '    ShowSplash("Imprimiendo...")

    '    Try
    '        If Me.vFacturas.GetFocusedRowCellValue("DIAS") = 0 Then '** Factura de Contado
    '            Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 2 AND Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())
    '        Else    '** Factura de Credito
    '            Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 9 AND Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())
    '        End If

    '        Temp = True
    '        Dim Tamano As Integer
    '        Tamano = Data.GetUpperBound(0)

    '        If Me.vFacturas.GetFocusedRowCellValue("DIAS") = 0 Then '** Factura de Contado
    '            Cadena = Application.StartupPath & "\RptFactura.repx"
    '        Else    '** Factura de Credito
    '            Cadena = Application.StartupPath & "\RptFacturaCredito.repx"
    '        End If

    '        If File.Exists(Cadena) Then Kill(Cadena)
    '        Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
    '        Archivo.Write(Data, 0, Tamano)
    '        Archivo.Close()

    '    Catch ex As Exception
    '        Temp = False
    '    End Try

    '    Dim Rep As XtraReport

    '    If Temp = True Then
    '        If Me.vFacturas.GetFocusedRowCellValue("DIAS") = 0 Then '** Factura de Contado
    '            Rep = XtraReport.FromFile(Application.StartupPath & "\RptFactura.repx", True)
    '        Else    '** Factura de Credito
    '            Rep = XtraReport.FromFile(Application.StartupPath & "\RptFacturaCredito.repx", True)
    '        End If
    '    Else
    '        If Me.vFacturas.GetFocusedRowCellValue("DIAS") = 0 Then '** Factura de Contado
    '            Rep = New RptFacturaNew
    '        Else
    '            Rep = New RptFacturaNewCredito
    '        End If
    '    End If

    '    If Me.vFacturas.GetFocusedRowCellValue("DIAS") = 0 Then '** Factura de Contado
    '        Rep.DataSource = ObtieneDatos("sp_GetRptFacturaContado " & EmpresaActual & ",'" & Me.vFacturas.GetFocusedRowCellValue("No Factura") & "'")
    '    Else
    '        Rep.DataSource = ObtieneDatos("sp_GetRptFacturaCredito " & EmpresaActual & ",'" & Me.vFacturas.GetFocusedRowCellValue("No Factura") & "'")
    '    End If

    '    HideSplash()
    '    Rep.ShowPrintMarginsWarning = False
    '    Rep.BringToFront()
    '    Rep.ShowRibbonPreview()
    'End Sub

    'Sub Imprimir2()

    '    ShowSplash("Imprimiendo...")

    '    Dim Temp As Boolean = False

    '    Try
    '        Dim Data() As Byte = CType(db_TipoFacturas.Listar(vFacturas.GetFocusedRowCellValue("Formato")).Rows.Item(0)("Formato"), Byte())

    '        Temp = True
    '        Dim Tamano As Integer = 0
    '        Tamano = Data.GetUpperBound(0)

    '        Dim Cadena As String = Application.StartupPath & "\rptFormato.repx"

    '        If File.Exists(Cadena) Then Kill(Cadena)
    '        Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
    '        Archivo.Write(Data, 0, Tamano)
    '        Archivo.Close()

    '    Catch ex As Exception
    '        Temp = False
    '    End Try

    '    ''Solo para Costa Rica, Imprimir Codigo QR
    '    ''If EmpresaActual = 20 Then
    '    '    Dim rpt As New rptFormatoFactura
    '    '    If Temp Then rpt = XtraReport.FromFile(Application.StartupPath & "\rptFormato.repx", True)
    '    '    rpt.DataSource = ObtieneDatos("sp_GetRptFacturaCredito", EmpresaActual, vFacturas.GetFocusedRowCellValue("No Factura"))
    '    '    rpt.XrBarCode1 = VB.SysContab.Facturas_VentasDB.CreateQRCodeBarCode("1572126")
    '    '    HideSplash()
    '    '    rpt.ShowPrintMarginsWarning = False
    '    '    rpt.BringToFront()
    '    '    rpt.ShowRibbonPreview()
    '    'Else

    '    Dim rpt As New RptFacturaNew

    '    If Temp Then rpt = XtraReport.FromFile(Application.StartupPath & "\rptFormato.repx", True)

    '    'rpt.DataSource = ObtieneDatos("sp_GetRptFacturaCredito", EmpresaActual, vFacturas.GetFocusedRowCellValue("No Factura"))
    '    VistaPreviaDX(rpt,
    '                   ObtieneDatos("sp_GetRptFacturaCredito", EmpresaActual, vFacturas.GetFocusedRowCellValue("No Factura")),
    '                  "Factura No. " & vFacturas.GetFocusedRowCellValue("No Factura"))
    '    HideSplash()

    '    'rpt.ShowPrintMarginsWarning = False
    '    'rpt.BringToFront()
    '    'rpt.ShowRibbonPreview()
    '    ' End If

    'End Sub

    Private Sub vFacturas_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vFacturas.CellValueChanged
        Try
            If e.Column.FieldName = "Fact_IR" Then
                Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())

                Conn.RemoveParameters()
                Conn.AddParameter("Factura", SqlDbType.NVarChar, 50, ParameterDirection.Input, vFacturas.GetRowCellValue(e.RowHandle, "No Factura"))
                Conn.AddParameter("IR", SqlDbType.Int, 5, ParameterDirection.Input, IIf(vFacturas.GetRowCellValue(e.RowHandle, "Fact_IR"), 1, 0))
                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)

                Conn.EjecutarComando("JAR_UpdateEstadoIR")
            End If
            '
            If e.Column.FieldName = "IR_Alcaldia" Then
                Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())

                Conn.RemoveParameters()
                Conn.AddParameter("Factura", SqlDbType.NVarChar, 50, ParameterDirection.Input, vFacturas.GetRowCellValue(e.RowHandle, "No Factura"))
                Conn.AddParameter("IR", SqlDbType.Int, 5, ParameterDirection.Input, IIf(vFacturas.GetRowCellValue(e.RowHandle, "IR_Alcaldia"), 1, 0))
                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)

                Conn.EjecutarComando("JAR_UpdateEstadoIR_Alcaldia")
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub vFacturas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vFacturas.DoubleClick
        cmdModificar_Click(Nothing, Nothing)
    End Sub

    Private Sub dtpFechaDesde_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaDesde.EditValueChanged
        'If etInicio.Text = "1" Then
        '    Exit Sub
        'End If

        'Try
        '    Fecha1 = dtpFechaDesde.DateTime.Date
        '    Fecha2 = dtpFechaHasta.DateTime.Date
        '    dtpFechaHasta.Properties.MinValue = dtpFechaDesde.DateTime.Date

        '    'ds = Clientes.FacturasXTipoList("", cbClientes.Text, cbTipoFactura.SelectedValue, Me.cbMeses.SelectedIndex, Me.cbEstado.SelectedIndex, Fecha1, Fecha2)
        '    'Me.gridDatos.DataSource = ds.Tables("Facturas_Ventas").DefaultView
        '    'dgFacturasClientes.DataSource = ds.Tables("Facturas_Ventas").DefaultView
        '    Cargar()
        'Catch ex As Exception
        '    'MsgBox(ex.Message & " dtpFechaDesde_ValueChanged1")
        'End Try
    End Sub

    Private Sub dtpFechaHasta_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaHasta.EditValueChanged
        'If etInicio.Text = "1" Then
        '    Exit Sub
        'End If

        'Try
        '    Fecha1 = dtpFechaDesde.DateTime.Date
        '    Fecha2 = dtpFechaHasta.DateTime.Date

        '    'ds = Clientes.FacturasXTipoList("", cbClientes.Text, cbTipoFactura.SelectedValue, Me.cbMeses.SelectedIndex, Me.cbEstado.SelectedIndex, Fecha1, Fecha2)
        '    'dgFacturasClientes.DataSource = ds.Tables("Facturas_Ventas").DefaultView
        '    'Me.gridDatos.DataSource = ds.Tables("Facturas_Ventas").DefaultView
        '    Cargar()
        'Catch ex As Exception
        '    'MsgBox(ex.Message & " dtpFechaDesde_ValueChanged2")
        'End Try
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        My.Forms.frmExportarImprimir.Mostrar(Me.gridDatos)
        'If Me.GuardarFile.ShowDialog = DialogResult.OK Then
        '    Try
        '        Me.gridDatos.ExportToXls(Me.GuardarFile.FileName)
        '        Process.Start(Me.GuardarFile.FileName)
        '    Catch ex As Exception
        '    End Try
        'End If
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        If Me.vFacturas.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione una Factura")
            Exit Sub
        End If


        If Me.vFacturas.GetFocusedRowCellValue("Estado") <> 1 Then
            XtraMsg("Solamente Se pude BORRAR la Factura que ha sido ANULADA", MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Me.vFacturas.GetFocusedRowCellValue("Fiscal") Then
            XtraMsg("La factura ya fue enviada a impresora Fiscal, No puede ser Borrada...", MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not XtraMsg2("Esta Seguro que desea Borrar la Factura Señalada, " & vbCrLf &
                        "Una vez realizado este proceso no podra deshacer los cambios " & vbCrLf &
                        "¿Borrar Factura #: " & Me.vFacturas.GetFocusedRowCellValue("No Factura") & " ?") Then
            Exit Sub
        End If

        If GuardaDatos("sp_BorrarFacturaV '" & Me.vFacturas.GetFocusedRowCellValue("No Factura") & "'," & EmpresaActual) Then
            XtraMsg("La Factura ha Sido Borrada de la Base de Datos")
        Else
            XtraMsg("ERROR : La Operación no se pudo Completar, Consulte con el Administrador del Sistema", MessageBoxIcon.Error)
        End If

        'ds = Clientes.FacturasXTipoList("", cbClientes.Text, cbTipoFactura.SelectedValue, cbMeses.SelectedIndex, cbEstado.SelectedIndex, Fecha1, Fecha2)
        'Me.gridDatos.DataSource = ds.Tables("Facturas_Ventas").DefaultView

        Cargar()
    End Sub

    'Private Sub cbTipoFactura_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If etInicio.Text = "1" Then
    '        Exit Sub
    '    End If

    '    Try
    '        'If checkBoxFecha.Checked = True Then
    '        '    ds = Clientes.FacturasXFecha(cbClientes.Text, cbTipoFactura.SelectedValue, dtpFechaDesde.Value.ToShortDateString, dtpFechaHasta.Value.ToShortDateString, cbEstado.SelectedIndex)
    '        'Else
    '        'ds = Clientes.FacturasXTipoList("", cbClientes.Text, cbTipoFactura.SelectedValue, cbMeses.SelectedIndex, cbEstado.SelectedIndex, Fecha1, Fecha2)
    '        'End If

    '        'dgFacturasClientes.DataSource = ds.Tables("Facturas_Ventas").DefaultView
    '        Me.gridDatos.DataSource = ds.Tables("Facturas_Ventas").DefaultView
    '    Catch ex As Exception
    '        MsgBox(ex.Message & " cbTipoFactura_SelectedValueChanged")
    '    End Try
    'End Sub

    Private Sub cbTipoFactura_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoFactura.EditValueChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        Try
            Cargar()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbMeses_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMeses.SelectedIndexChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        Try
            Cargar()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbCajas_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCajas.EditValueChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        Try
            Cargar()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        If sender.checked = True Then Me.vFacturas.ColumnsCustomization() Else Me.vFacturas.DestroyCustomization()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Cargar()
    End Sub

    Private Sub vFacturas_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles vFacturas.RowCellStyle
        If e.Column.FieldName = "Contab" Then
            If vFacturas.GetRowCellValue(e.RowHandle, "Contab") Then
                e.Appearance.BackColor = Color.HotPink
            End If
        End If
        '
        If e.Column.FieldName = "Fiscal" Then
            If vFacturas.GetRowCellValue(e.RowHandle, "Fiscal") Then
                e.Appearance.BackColor = Color.HotPink
            End If
        End If
        '
        If e.Column.FieldName = "Exento" Then
            If vFacturas.GetRowCellValue(e.RowHandle, "Exento") Then
                e.Appearance.BackColor = Color.Bisque
            End If
        End If
        '
        If e.Column.FieldName = "EstadoF" Then
            If vFacturas.GetRowCellValue(e.RowHandle, "EstadoF") = "ANULADA" Then
                e.Appearance.BackColor = Color.AliceBlue
                e.Appearance.ForeColor = Color.DarkRed
                e.Appearance.Font = New Font("Tahoma", 8.25, FontStyle.Bold)
            End If
        End If
        '
        If e.Column.FieldName = "Entrega" Then
            e.Appearance.Font = New Font("Tahoma", 8.25, FontStyle.Bold)

            If vFacturas.GetRowCellValue(e.RowHandle, "Entrega") = "Anulada" Then
                e.Appearance.BackColor = Color.AliceBlue
                e.Appearance.ForeColor = Color.DarkRed
            ElseIf vFacturas.GetRowCellValue(e.RowHandle, "Entrega") = "Entregado" Then
                e.Appearance.BackColor = Color.LimeGreen
            ElseIf vFacturas.GetRowCellValue(e.RowHandle, "Entrega") = "Pendiente" Then
                e.Appearance.BackColor = Color.Salmon
            ElseIf vFacturas.GetRowCellValue(e.RowHandle, "Entrega") = "Parcial" Then
                e.Appearance.BackColor = Color.LightSalmon
            ElseIf vFacturas.GetRowCellValue(e.RowHandle, "Entrega") = "Devuelto" Then
                e.Appearance.BackColor = Color.DarkTurquoise
            End If
        End If
        '
        If e.Column.FieldName = "ATV" Then
            e.Appearance.Font = New Font("Tahoma", 8.25, FontStyle.Bold)
            e.Appearance.BackColor = Color.LightGray
            e.Appearance.BackColor2 = Color.Gray
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            If vFacturas.GetRowCellValue(e.RowHandle, "ATV") = "aceptado" Then
                e.Appearance.ForeColor = Color.DarkGreen
            ElseIf vFacturas.GetRowCellValue(e.RowHandle, "ATV") = "rechazado" Then
                e.Appearance.ForeColor = Color.DarkRed
            ElseIf vFacturas.GetRowCellValue(e.RowHandle, "ATV") = "procesando" Then
                e.Appearance.ForeColor = Color.Navy
            ElseIf vFacturas.GetRowCellValue(e.RowHandle, "ATV") = "recibido" Then
                e.Appearance.ForeColor = Color.Navy
            Else
                e.Appearance.ForeColor = Color.White
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Mostrar Notificacion si se encuentran facturas Vencidas
        If FacturasVencidas > 0 Then
            AlertControl1.Show(Me, "Alerta  de Facturas Vencidas!", "Existen " & FacturasVencidas.ToString & " Facturas Vencidas al día de Hoy." & vbCrLf & vbCrLf & vbCrLf &
                               "Clic Aqui para Ver Reporte")

            IniciaContador(300000)
        End If
        '
        'Mostrar Notificacion si se encuentran facturas Proximas a Vencer
        If FvProximasVencer > 0 Then
            AlertControl2.Show(Me, "Alerta  de Facturas Próximas a Vencer!", "Existen " & FvProximasVencer.ToString & " Facturas Próximas a Vencer." & vbCrLf & vbCrLf & vbCrLf &
                               "Clic Aqui para Ver Reporte")

            IniciaContador(300000)
        End If

    End Sub

    Private Sub IniciaContador(Intervalo As Integer)
        Timer1.Enabled = True
        Timer1.Interval = Intervalo
        Timer1.Start()
    End Sub

    Private Sub AlertControl1_AlertClick(sender As Object, e As DevExpress.XtraBars.Alerter.AlertClickEventArgs) Handles AlertControl1.AlertClick
        With frmFacturasVentasVencidas
            .Text = "Facturas Vencidas"
            .sProc = "JAR_GetFacturasVencidas"
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub AlertControl2_AlertClick(sender As Object, e As DevExpress.XtraBars.Alerter.AlertClickEventArgs) Handles AlertControl2.AlertClick
        With frmFacturasVentasVencidas
            .Text = "Facturas Proximas a Vencer"
            .sProc = "JAR_GetFacturasProximasAVencer"
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles bImpresoraFiscal.Click
        If vFacturas.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione una Factura")
            Exit Sub
        End If
        '
        Dim fv As New Factura_ElectronicaCR
        fv.ImpresoraFiscalXML(vFacturas.GetFocusedRowCellValue("No Factura"), 2)

        '
        'EnviarXLM(vFacturas.GetFocusedRowCellValue("No Factura"))

        'Try
        '    Dim DT_ENCABEZADO As DataTable = ObtieneDatosTN("sp_GetFacturaFiscal", "Mercurio", vFacturas.GetFocusedRowCellValue("No Factura"), 2, EmpresaActual)
        '    Dim DT_DETALLE As DataTable = ObtieneDatosTN("sp_GetFacturaFiscalDetalle", "SalesLines", vFacturas.GetFocusedRowCellValue("No Factura"), EmpresaActual)

        '    Dim DS As New DataSet("Mercurio_Invoices")
        '    DS.Tables.Add(DT_ENCABEZADO)
        '    DS.Tables.Add(DT_DETALLE)

        '    Dim path As String = "C:\XML\FACT_NO_" & vFacturas.GetFocusedRowCellValue("No Factura") & ".xml"

        '    If File.Exists(path) Then File.Delete(path)

        '    Dim xmlSW As StreamWriter = New System.IO.StreamWriter(path)
        '    DS.WriteXml(xmlSW, XmlWriteMode.WriteSchema)
        '    xmlSW.Close()

        '    XtraMsg("El XML fue creado y enviado a: " & path)
        'Catch ex As Exception
        '    XtraMsg(ex.Message, MessageBoxIcon.Error)
        'End Try

    End Sub

    Private Sub bEditar_Click(sender As Object, e As EventArgs) Handles bEditar.Click
        If vFacturas.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione una Factura")
            Exit Sub
        End If
        '
        frmFacturasVentasEditar.Dispose()

        With frmFacturasVentasEditar

            If vFacturas.GetFocusedRowCellValue("ATV") = "aceptado" Or
                vFacturas.GetFocusedRowCellValue("ATV") = "comprobando" Then
                XtraMsg("Esta Factura ya se encuentra procesada como factura Electrónica!", MessageBoxIcon.Warning)

                .bGuardar.Enabled = False
                .vFact.OptionsBehavior.Editable = False
                .cmbformapago.Enabled = False
                .cbCliente.Enabled = False
                .cmbmoneda.Enabled = False
                .fecha.Enabled = False

                If Login.ToUpper.Equals("jarauz".ToUpper.ToUpper) Or
                    Login.ToUpper.Equals("stsadmin".ToUpper.ToUpper) Then
                    .vFact.OptionsBehavior.Editable = True
                    .bGuardar.Enabled = True
                End If
            End If
                '
                If vFacturas.GetFocusedRowCellValue("Contab") Then
                XtraMsg("Esta Factura ya se encuentra procesada, no puede ser modificada...",
                        MessageBoxIcon.Warning)
                .bGuardar.Enabled = False
            End If
            '
            If Me.vFacturas.GetFocusedRowCellValue("Entrega") = "Devuelto" Then
                XtraMsg("La factura contiene Devolución asociada.",
                        MessageBoxIcon.Warning)

                If Login.ToUpper.Equals("jarauz".ToUpper.ToUpper) Or
                    Login.ToUpper.Equals("stsadmin".ToUpper.ToUpper) Then
                    .vFact.OptionsBehavior.Editable = True
                    .bGuardar.Enabled = True
                End If
            End If
            '
            If Me.vFacturas.GetFocusedRowCellValue("EstadoF") = "ANULADA" Then
                XtraMsg("La factura se encuentra Anulada, no puede ser modificada",
                        MessageBoxIcon.Warning)
                .bGuardar.Enabled = False
            End If
            '
            If ObtieneDatos("JAR_GetRecibosxFactura",
                            vFacturas.GetFocusedRowCellValue("No Factura"),
                            EmpresaActual) _
                            .Rows.Count > 0 Then
                XtraMsg("La Factura Contiene Pagos, no se deben alterar los montos originales.", MessageBoxIcon.Warning)
                '
                Dim dr() As DataRow = DT_ROL.Select("Control = 'EditarPagos'")
                If dr.Length = 0 Then .vFact.OptionsBehavior.Editable = False

            End If

            ShowSplash()
            '
            .MdiParent = Me.MdiParent
            .Factura = vFacturas.GetFocusedRowCellValue("No Factura")

            .Show()
            .Text = "Editar Factura"
            .WindowState = FormWindowState.Maximized
            '
            HideSplash()
        End With

    End Sub

    Private Sub bElectronica_Click(sender As Object, e As EventArgs) Handles bElectronica.Click
        If vFacturas.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione una Factura")
            Exit Sub
        End If
        '     
        If vFacturas.GetFocusedRowCellValue("Estado") Then
            XtraMsg("La factura solicitada se encuentra ANULADA...", MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim Estado As String = vFacturas.GetFocusedRowCellValue("ATV")

        If Estado.Equals("aceptado") Then
            XtraMsg("La factura ya ha sido ""aceptada"" en Hacienda", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If vFacturas.GetFocusedRowCellValue("Entrega").ToString().Equals("Devuelto") Then
            XtraMsg("La factura ya contiene una Nota de Crédito Electrónica por Devolución", MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim fv As New Factura_ElectronicaCR
        Dim EnviaFactura As New Comunicacion
        '
        If Estado.Equals("procesando") Then

            If Not XtraMsg2("Desea consultar el estado actual de la Factura Electrónica?") Then
                Exit Sub
            End If
            '            
            'ShowSplash("Consultando Estado...")
            '
            EnviaFactura = fv.ConsultarComprobante(
                vFacturas.GetFocusedRowCellValue("No Factura"),
                "01")
            '
            'HideSplash()

            XtraMsg(EnviaFactura.mensajeRespuesta)

            If Not IsNothing(EnviaFactura) Then _
                EnviarMailComprobante(
                False,
                EnviaFactura.estadoFactura)

            'ConsultarComprobante(False, "01")
        Else
            Dim SinReceptor As Boolean = False

            With frmFacturaElectronicaTipo
                .ShowDialog()
                If Not .Ok Then
                    .Dispose()
                    Exit Sub
                End If
                '
                SinReceptor = IIf(.RadioGroup1.EditValue = 1, False, True)
                .Dispose()
            End With
            '
            If SinReceptor Then
                If Not XtraMsg2("Esta Seguro de Enviar esta factura sin Receptor ?") Then
                    Exit Sub
                End If
            End If

            'ShowSplash("Enviando Factura...")
            '
            EnviaFactura = fv.EnviarComprobante(
                vFacturas.GetFocusedRowCellValue("No Factura"),
                "01",
                "FacturaElectronica",
                vFacturas.GetFocusedRowCellValue("Fecha"),
                "",
                0,
                IIf(SinReceptor, 1, 0))
            '
            'HideSplash()
            '            
            If EnviaFactura.estadoFactura _
                .Equals("aceptado") Then

                Dim DT_Header As DataTable =
                    ObtieneDatos("sp_sel_FACTURAS_VENTAS",
                                 vFacturas.GetFocusedRowCellValue("No Factura"),
                                 EmpresaActual)

                Dim ClienteDetalle As New VB.SysContab.ClientesDetails
                ClienteDetalle = VB.SysContab.ClientesDB.GetDetails(DT_Header.Rows.Item(0)("CLIENTE"))

                If IsNull(ClienteDetalle.Correo, "").ToString.Trim.Length = 0 Then
                    XtraMsg("El Cliente :" & ClienteDetalle.Nombre.Trim &
                            " No tiene correo de Envío en su perfil de cliente, intente Re-Enviar la factuara en unos minutos...",
                            MessageBoxIcon.Warning)
                Else
                    ShowSplash("Enviando Correo...")
                    VB.SysContab.Facturas_VentasDB.EnviarCorreoClienteFE(
                        vFacturas.GetFocusedRowCellValue("No Factura"),
                        DT_Header.Rows.Item(0)("CLIENTE"),
                        ClienteDetalle.Correo,
                        vFacturas.GetFocusedRowCellValue("Formato"),
                        "01")
                    HideSplash()
                End If
            End If

            Cargar()
        End If




        '    If Estado = "procesando" Then
        '    'If XtraMsg2("Desea consultar el estado actual de esta Factura?") Then
        '    '    ShowSplash("Consultando Estado...")
        '    '    '
        '    '    Dim fvXml As New FacturaXML
        '    '    Dim obj As New IDP_FacturaElectronica
        '    '    Dim fe As New Factura_ElectronicaCR

        '    '    fvXml.Detalle(vFacturas.GetFocusedRowCellValue("No Factura"))
        '    '    obj = IDP_FacturaElectronicaToken.Detalles()


        '    '    ' obj = IDP_FacturaElectronicaToken.Detalles()
        '    '    'Dim DT As DataTable = GetDatosFactura(Factura, Tipo, FechaEmision, Razon)

        '    '    'Dim Token As String = getToken(obj.Usuario, obj.Password, obj.IDP_CLIENT_ID, obj.IDP_URI)

        '    '    Dim enviaFactura As New Comunicacion
        '    '    enviaFactura.ConsultaEstatus(fvXml.Token, fvXml.ClaveNumerica, obj.APIUrl, obj.DirectorioATV, fvXml.Consecutivo)

        '    '    If enviaFactura.statusCode = "403" Then
        '    '        'Token Vencido, Usar el Refresh token.
        '    '        'Dim Token As String = fe.getTokenRefresh(obj.Usuario, obj.Password, obj.IDP_CLIENT_ID, obj.IDP_URI)

        '    '        Dim iToken As New TokenHacienda
        '    '        iToken.GetTokenHacienda(obj.Usuario, obj.Password, obj.IDP_URI, obj.IDP_CLIENT_ID)

        '    '        enviaFactura.ConsultaComprobantesEnviados(iToken.refreshToken, fvXml.ClaveNumerica, obj.APIUrl, obj.DirectorioATV, fvXml.Consecutivo)
        '    '        enviaFactura.ConsultaEstatus(Token, fvXml.ClaveNumerica, obj.APIUrl, obj.DirectorioATV, fvXml.Consecutivo)
        '    '    End If
        '    '    '
        '    '    fv.ActualizarEstadoFacturaXML(vFacturas.GetFocusedRowCellValue("No Factura"),
        '    '                                  IIf(IsNothing(enviaFactura.estadoFactura), "sin respuesta", enviaFactura.estadoFactura), enviaFactura.mensajeRespuesta,
        '    '                                  fvXml.Consecutivo)
        '    '    HideSplash()
        '    '    '
        '    '    XtraMsg(enviaFactura.mensajeRespuesta)
        '    '    Cargar()
        '    '    Exit Sub
        '    'Else
        '    '    Exit Sub
        '    'End If
        'End If
        '
        'ShowSplash("Enviando Factura...")

        'If fv.EnviarComprobante(vFacturas.GetFocusedRowCellValue("No Factura"), "01", "FacturaElectronica", vFacturas.GetFocusedRowCellValue("Fecha"), "") <> "" Then
        '    HideSplash()
        '    Cargar()
        'Else
        '    HideSplash()
        'End If

        'Obtener Datos del Token
        'Dim _dt As DataTable = FacturaElectronica.AutenticacionToken()
        ''Si el token esta recibido correctamente
        'If Not _dt Is Nothing Then
        '    FacturaElectronica.EnviarComprobante(_dt.Rows.Item(0)("access_token"), _dt.Rows.Item(0)("refresh_token"),
        '                                         vFacturas.GetFocusedRowCellValue("No Factura"), "01")
        'End If

        'Dim Json As String = fact_elec.Genera_XML(vFacturas.GetFocusedRowCellValue("No Factura"), "01")

        'If Json <> "Error" Then
        '    Dim _DT As DataTable = fact_elec.GetDatosJson(Json)
        'End If

    End Sub

    Private Sub bConsultarFE_Click(sender As Object, e As EventArgs) Handles bConsultarFE.Click

        If vFacturas.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione una Factura")
            Exit Sub
        End If
        '     
        If vFacturas.GetFocusedRowCellValue("Estado") Then
            XtraMsg("La factura solicitada se encuentra ANULADA...", MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim Estado As String = vFacturas.GetFocusedRowCellValue("ATV")

        If Estado.Equals("n/a") Then
            XtraMsg("La factura no ha sido registrada como Factura Electrónica.", MessageBoxIcon.Warning)
            Exit Sub
        End If

        'If Estado <> "aceptado" Then
        '    XtraMsg("La factura ya ha sido ""aceptada"" en ATV", MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        '
        If Estado.Equals("rechazado") Then
            With frmMotivoRechazo
                .Consecutivo = vFacturas.GetRowCellValue(vFacturas.FocusedRowHandle, "F.Electrónica")
                .Factura = vFacturas.GetRowCellValue(vFacturas.FocusedRowHandle, "No Factura")
                '.mMotivo.Text = IsNull(iVista.GetRowCellValue(iVista.FocusedRowHandle, "MensajeHacienda"), "").ToString()
                .ShowDialog()
                .Dispose()
            End With
            Exit Sub
        End If

        If Not XtraMsg2("Desea consultar el estado actual de esta Factura?") Then
            Exit Sub
        End If
        '
        Dim fv As New Factura_ElectronicaCR
        Dim enviaFactura As New Comunicacion

        ' ShowSplash("Consultando Estado...")
        '
        enviaFactura =
            fv.ConsultarComprobante(
                vFacturas.GetFocusedRowCellValue("No Factura"),
                "01")
        '
        'HideSplash()

        XtraMsg(enviaFactura.mensajeRespuesta)

        If Not IsNothing(enviaFactura) Then _
            EnviarMailComprobante(
            True,
            enviaFactura.estadoFactura)

        'If vFacturas.GetFocusedRowCellValue("Entrega") <> "Devuelto" Then ConsultarComprobante(True, "01")
        'If vFacturas.GetFocusedRowCellValue("Entrega") = "Devuelto" Then ConsultarComprobante(True, "03")

        'Dim fvXml As New FacturaXML
        'Dim obj As New IDP_FacturaElectronica
        'Dim fe As New Factura_ElectronicaCR

        'fvXml.Detalle(vFacturas.GetFocusedRowCellValue("No Factura"))
        'obj = IDP_FacturaElectronicaToken.Detalles()
        'Dim enviaFactura As New Comunicacion
        ''Token Vencido, Usar el Refresh token.
        'Dim Token As String = fe.getTokenRefresh(obj.Usuario, obj.Password, obj.IDP_CLIENT_ID, obj.IDP_URI)
        'enviaFactura.ConsultaComprobantesEnviados(Token, fvXml.ClaveNumerica, obj.APIUrl, obj.DirectorioATV, fvXml.Consecutivo)
    End Sub

    Sub EnviarMailComprobante(ver As Boolean,
                             Estado As String)

        'Dim fv As New Factura_ElectronicaCR

        'ShowSplash("Consultando Estado...")
        ''
        'Dim fvXml As New FacturaXML
        'Dim obj As New IDP_FacturaElectronica

        ''Dim fe As New Factura_ElectronicaCR
        'Dim EsAccessToken As Boolean = True

        'fvXml.Detalle(vFacturas.GetFocusedRowCellValue("No Factura"), Tipo)

        'obj = IDP_FacturaElectronicaToken.Detalles()

        '' obj = IDP_FacturaElectronicaToken.Detalles()
        ''Dim DT As DataTable = GetDatosFactura(Factura, Tipo, FechaEmision, Razon)
        ''Dim Token As String = getToken(obj.Usuario, obj.Password, obj.IDP_CLIENT_ID, obj.IDP_URI)

        ''Token Vencido, Usar el Refresh token.                
        'Dim iToken As New TokenHacienda
        'iToken.GetTokenHacienda(obj.Usuario, obj.Password, obj.IDP_URI, obj.IDP_CLIENT_ID)
        ''
        'Dim enviaFactura As New Comunicacion
        'enviaFactura.ConsultaEstatus(iToken.accessToken, fvXml.ClaveNumerica, obj.APIUrl, obj.DirectorioATV, fvXml.Consecutivo)
        ''
        'If enviaFactura.statusCode = "403" Then
        '    enviaFactura.ConsultaEstatus(iToken.refreshToken, fvXml.ClaveNumerica, obj.APIUrl, obj.DirectorioATV, fvXml.Consecutivo)
        '    EsAccessToken = False
        'End If
        ''
        'Dim XmlResp As Object = Nothing
        'If Not IsNothing(enviaFactura.xmlRespuesta) Then XmlResp = enviaFactura.xmlRespuesta.InnerXml

        'fv.FacturaElectronicaXML(vFacturas.GetFocusedRowCellValue("No Factura"), Nothing, Nothing,
        '                        XmlResp, fvXml.Consecutivo)

        'fv.FacturaElectronicaUpdateEstado(vFacturas.GetFocusedRowCellValue("No Factura"),
        '                                      IIf(IsNothing(enviaFactura.estadoFactura), "sin respuesta", enviaFactura.estadoFactura),
        '                                      enviaFactura.mensajeRespuesta, IIf(EsAccessToken, iToken.accessToken, iToken.refreshToken),
        '                                      fvXml.Consecutivo)

        ''fv.ActualizarEstadoFacturaXML(vFacturas.GetFocusedRowCellValue("No Factura"),
        ''                              IIf(IsNothing(enviaFactura.estadoFactura), "sin respuesta", enviaFactura.estadoFactura), enviaFactura.mensajeRespuesta,
        ''                              fvXml.Consecutivo)
        'HideSplash()
        ''        
        'XtraMsg(enviaFactura.mensajeRespuesta)

        ''Validar si es N/C, Borrar la Devolucion
        'If Tipo = "03" Then If enviaFactura.estadoFactura = "rechazado" Then Facturas_VentasDB.BorrarNotaCreditoElectronica(vFacturas.GetFocusedRowCellValue("No Factura"))
        '
        'If enviaFactura.estadoFactura = "aceptado" Then
        If Estado.Equals("aceptado") Then

            Dim TieneCorreo As Boolean = True

            Dim DT_Header As DataTable = ObtieneDatos("sp_sel_FACTURAS_VENTAS",
                                                      vFacturas.GetFocusedRowCellValue("No Factura"),
                                                      EmpresaActual)

            Dim ClienteDetalle As New VB.SysContab.ClientesDetails
            ClienteDetalle = VB.SysContab.ClientesDB.GetDetails(DT_Header.Rows.Item(0)("CLIENTE"))

            ''With frmDatosDevolucionCR
            ''    .NoFactura = vFacturas.GetFocusedRowCellValue("No Factura")
            ''    .Fecha.Properties.MinValue = UltimoDiaDelMes(vFacturas.GetFocusedRowCellValue("Fecha")).AddDays(1).Date
            ''    .Text = "Devolución Electrónica Factura No. " & vFacturas.GetFocusedRowCellValue("No Factura")
            ''    .ShowDialog()

            ''    If .Ok = "SI" Then

            ''        Dim Plantilla As New VB.SysContab.PlantillaDB
            ''        Dim plan As String = Plantilla.GetTipoPlantilla(4, 4).ToString
            ''        '
            ''        If plan = "" Or plan Is DBNull.Value Then
            ''            XtraMsg("No hay Plantilla Contable de Devolución para Realizar esta Transacción", MessageBoxIcon.Error)
            ''            .Dispose()
            ''            Exit Sub
            ''        End If

            ''        ShowSplash("Enviando Factura...")
            ''        '
            ''        'Mandar a Guardar Devolucion Contable y Movimientos de inventario en caso de contener productos.                    
            ''        If GuardarDevolucion(Plantilla.GetPlantillasDetails(plan).TipoCompr,
            ''                             DT_Header,
            ''                             ClienteDetalle,
            ''                             .Fecha.DateTime.Date,
            ''                             fvXml.Consecutivo,
            ''                             .cbTipoNota.EditValue,
            ''                             .cbMovimientos.EditValue) Then

            ''            'Si fue aceptada a la primera Vez, se envia el correo.
            ''            If enviaFactura.estadoFactura = "acepatado" Then

            ''                If IsNull(ClienteDetalle.Correo, "").ToString.Trim.Length = 0 Then
            ''                    XtraMsg("El Cliente :" & ClienteDetalle.Nombre.Trim & " No tiene correo de Envío en su perfil de cliente, intente Re-Enviar correo en unos minutos...", MessageBoxIcon.Warning)
            ''                Else
            ''                    ShowSplash("Enviando Correo...")
            ''                    '                            
            ''                    Facturas_VentasDB.EnviarCorreoClienteNE(vFacturas.GetFocusedRowCellValue("No Factura"),
            ''                                                                         "NC" + vFacturas.GetFocusedRowCellValue("No Factura").ToString.PadLeft(6, "0"c),
            ''                                                                          DT_Header.Rows.Item(0)("CLIENTE"),
            ''                                                                          ClienteDetalle.Correo,
            ''                                                                          "03")
            ''                    HideSplash()
            ''                End If
            ''            End If

            ''        End If
            ''        '  End If

            ''    End If

            ''    .Dispose()
            ''    Cargar()
            ''End With


            If IsNull(ClienteDetalle.Correo, "").ToString.Trim.Length = 0 Then
                XtraMsg("El Cliente :" & ClienteDetalle.Nombre.Trim & " No tiene correo de Envío en su perfil de cliente, intente Re-Enviar la factuara en unos minutos...", MessageBoxIcon.Warning)
                TieneCorreo = False
            End If
            '
            If TieneCorreo Then

                If ver Then
                    If Not XtraMsg2("Desea Reenviar la Factura Electrónica al Cliente?") Then
                        Cargar()
                        Exit Sub
                    End If
                End If
                '
                ShowSplash("Enviando Correo...")
                '
                Facturas_VentasDB.EnviarCorreoClienteFE(
                            vFacturas.GetFocusedRowCellValue("No Factura"),
                            DT_Header.Rows.Item(0)("CLIENTE"),
                            ClienteDetalle.Correo,
                            vFacturas.GetFocusedRowCellValue("Formato"),
                            "01")
                '
                HideSplash()

                'If ver Then
                '    'enviaFactura.xmlRespuesta.Save(Application.StartupPath & "\xml\" & fvXml.Consecutivo & "_XML_RESPUESTA.xml")

                '    If XtraMsg2("Desea Reenviar la Factura Electrónica al Cliente?") Then
                '        ShowSplash("Enviando Correo...")

                '        Facturas_VentasDB.EnviarCorreoClienteFE(
                '            vFacturas.GetFocusedRowCellValue("No Factura"),
                '            DT_Header.Rows.Item(0)("CLIENTE"),
                '            ClienteDetalle.Correo,
                '            vFacturas.GetFocusedRowCellValue("Formato"),
                '            "01")

                '        'If Tipo = "01" Then

                '        '    Facturas_VentasDB.EnviarCorreoClienteFE(vFacturas.GetFocusedRowCellValue("No Factura"),
                '        '                                                                              DT_Header.Rows.Item(0)("CLIENTE"),
                '        '                                                                              ClienteDetalle.Correo,
                '        '                                                                              vFacturas.GetFocusedRowCellValue("Formato"),
                '        '                                                                              Tipo)
                '        'ElseIf Tipo = "03" Then

                '        '    Facturas_VentasDB.EnviarCorreoClienteNE(vFacturas.GetFocusedRowCellValue("No Factura"),
                '        '                                                          "NC" + vFacturas.GetFocusedRowCellValue("No Factura").ToString.PadLeft(6, "0"c),
                '        '                                                           DT_Header.Rows.Item(0)("CLIENTE"),
                '        '                                                           ClienteDetalle.Correo,
                '        '                                                           Tipo)
                '        'End If

                '        HideSplash()
                '    End If
                'Else

                '    ShowSplash("Enviando Correo...")

                '    Facturas_VentasDB.EnviarCorreoClienteFE(
                '        vFacturas.GetFocusedRowCellValue("No Factura"),
                '        DT_Header.Rows.Item(0)("CLIENTE"),
                '        ClienteDetalle.Correo,
                '        vFacturas.GetFocusedRowCellValue("Formato"),
                '        "01")

                '    'If Tipo = "01" Then

                '    '    Facturas_VentasDB.EnviarCorreoClienteFE(vFacturas.GetFocusedRowCellValue("No Factura"),
                '    '                                                                                  DT_Header.Rows.Item(0)("CLIENTE"),
                '    '                                                                                  ClienteDetalle.Correo,
                '    '                                                                                  vFacturas.GetFocusedRowCellValue("Formato"),
                '    '                                                                                  Tipo)
                '    'ElseIf Tipo = "03" Then

                '    '    Facturas_VentasDB.EnviarCorreoClienteNE(vFacturas.GetFocusedRowCellValue("No Factura"),
                '    '                                                              "NC" + vFacturas.GetFocusedRowCellValue("No Factura").ToString.PadLeft(6, "0"c),
                '    '                                                               DT_Header.Rows.Item(0)("CLIENTE"),
                '    '                                                               ClienteDetalle.Correo,
                '    '                                                               Tipo)
                '    'End If

                '    HideSplash()
                'End If
            End If
        End If
        '
        Cargar()

    End Sub

    Private Sub bDevolucion_Click(sender As Object, e As EventArgs) Handles bDevolucion.Click
        If vFacturas.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione una Factura")
            Exit Sub
        End If
        '     
        If vFacturas.GetFocusedRowCellValue("Estado") Then
            XtraMsg("La factura solicitada se encuentra ANULADA...", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        'If vFacturas.GetFocusedRowCellValue("Contab") Then
        '    XtraMsg("La factura ya fue Contabilizada", MessageBoxIcon.Warning)
        '    Exit Sub
        'End If
        ''
        'If vFacturas.GetFocusedRowCellValue("Entrega") = "Devuelto" Then
        '    XtraMsg("La factura ya contiene una devolución asociada.", MessageBoxIcon.Warning)
        '    Exit Sub
        'End If
        '
        Dim Estado As String = vFacturas.GetFocusedRowCellValue("ATV")

        If Estado = "rechazado" Then
            XtraMsg("Para procesar la Nota de Crédito electrónica el estado debe ser ""*aceptado*""", MessageBoxIcon.Warning)
            Exit Sub
        End If

        If (Estado = "aceptado" And vFacturas.GetFocusedRowCellValue("Entrega") = "Devuelto") Then
            XtraMsg("La Nota de Crédito ya ha sido recibida y aceptada por Hacienda...", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If Estado = "n/a" Then
            XtraMsg("No existe Facturación Electrónica para aplicar esta Nota de Crédito.", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        XtraMsg("VAYA AL MODULO DE DEVOLUCIONES PARA ENVIAR NOTAS DE CREDITO ELECTRONICAS", MessageBoxIcon.Information)
        Exit Sub

        If Estado = "recibido" Or
            Estado = "procesando" Then

            If Not XtraMsg2("Desea consultar el estado actual de la Nota de Crédito Electrónica?") Then
                Exit Sub
            End If
            '         
            Dim fv As New Factura_ElectronicaCR
            Dim enviaFactura As New Comunicacion

            enviaFactura = fv.ConsultarComprobante(
                vFacturas.GetFocusedRowCellValue("No Factura"),
                "03")

            XtraMsg(enviaFactura.mensajeRespuesta)

            If Not IsNothing(enviaFactura) Then EnviarMailComprobante(False,
                                                                     enviaFactura.estadoFactura)
        Else
            'Borrar Nota en caso de ser rechazada
            If Estado = "rechazado" Then _
                Facturas_VentasDB.BorrarNotaCreditoElectronica(vFacturas.GetFocusedRowCellValue("No Factura"))
            '
            With frmDatosDevolucionCR

                If CBool(vFacturas.GetFocusedRowCellValue("Contab")) Then
                    .Fecha.Properties.MinValue = UltimoDiaDelMes(vFacturas.GetFocusedRowCellValue("Fecha")).AddDays(1).Date
                End If

                .NoFactura = vFacturas.GetFocusedRowCellValue("No Factura")
                .Text = "Devolución Electrónica Factura No. " & vFacturas.GetFocusedRowCellValue("No Factura")
                .ShowDialog()

                If .Ok = "SI" Then

                    Dim Plantilla As New VB.SysContab.PlantillaDB
                    Dim plan As String = Plantilla.GetTipoPlantilla(4, 4).ToString
                    '
                    If plan = "" Or plan Is DBNull.Value Then
                        XtraMsg("No hay Plantilla Contable de Devolución para Realizar esta Transacción", MessageBoxIcon.Error)
                        .Dispose()
                        Exit Sub
                    End If

                    Dim fv As New Factura_ElectronicaCR

                    ShowSplash("Enviando Factura...")

                    Dim EnviaFactura As New Comunicacion
                    EnviaFactura = fv.EnviarComprobanteNC(vFacturas.GetFocusedRowCellValue("No Factura"),
                                                                       "03",
                                                                       "NotaCreditoElectronica",
                                                                       .Fecha.DateTime,
                                                                       .Razon.Text)
                    If EnviaFactura.estadoFactura = "recibido" Or
                        EnviaFactura.estadoFactura = "procesando" Then

                        Dim DT_Header As DataTable = ObtieneDatos("sp_sel_FACTURAS_VENTAS",
                                                                  vFacturas.GetFocusedRowCellValue("No Factura"),
                                                                  EmpresaActual)

                        Dim ClienteDetalle As New VB.SysContab.ClientesDetails
                        ClienteDetalle = VB.SysContab.ClientesDB.GetDetails(DT_Header.Rows.Item(0)("CLIENTE"))
                        '
                        'Mandar a Guardar Devolucion Contable y Movimientos de inventario en caso de contener productos.
                        'If GuardarDevolucion(Plantilla.GetPlantillasDetails(plan).TipoCompr,
                        '                     DT_Header,
                        '                     ClienteDetalle,
                        '                     .Fecha.DateTime.Date,
                        '                     EnviaFactura.Consecutivo,
                        '                     .cbTipoNota.EditValue,
                        '                     .cbMovimientos.EditValue) Then

                        '    'Si fue aceptada a la primera Vez, se envia el correo.
                        '    If EnviaFactura.estadoFactura = "acepatado" Then

                        '        If IsNull(ClienteDetalle.Correo, "").ToString.Trim.Length = 0 Then
                        '            XtraMsg("El Cliente :" & ClienteDetalle.Nombre.Trim & " No tiene correo de Envío en su perfil de cliente, intente Re-Enviar correo en unos minutos...", MessageBoxIcon.Warning)
                        '        Else
                        '            ShowSplash("Enviando Correo...")
                        '            '                            
                        '            Facturas_VentasDB.EnviarCorreoClienteNE(vFacturas.GetFocusedRowCellValue("No Factura"),
                        '                                                                 "NC" + vFacturas.GetFocusedRowCellValue("No Factura").ToString.PadLeft(6, "0"c),
                        '                                                                  DT_Header.Rows.Item(0)("CLIENTE"),
                        '                                                                  ClienteDetalle.Correo,
                        '                                                                  "03")
                        '            HideSplash()
                        '        End If
                        '    End If

                        'End If
                    End If

                End If

                .Dispose()
                Cargar()
            End With
        End If


    End Sub

    'Function GuardarDevolucion(TipoComp As Integer, DT_Header As DataTable,
    '                           ClienteDetalle As VB.SysContab.ClientesDetails,
    '                           FechaDevolucion As Date,
    '                           Referencia As String,
    '                           TipoNC As Integer,
    '                           MovimientoID As Integer) As Boolean

    '    Dim CuentaCliente As String = String.Empty,
    '        CompNo As Integer = 0,
    '        NoFactura As String = DT_Header.Rows.Item(0)("FACTURA"),
    '        EsProducto As Boolean = True,
    '        Repetido As Boolean = False,
    '        CuentaIVA As String = String.Empty,
    '        fp As Integer = 0

    '    'CuentaIR As String = String.Empty,        
    '    'CuentaIR_Alcaldia As String = String.Empty,

    '    Dim CuentasIventario As New ArrayList,     'CUENTAS CONTABLES D PRODUCTOS
    '        MontosIventario As New ArrayList,  'MONTO DE PRODUCTOS INVENTARIO        
    '        CuentasCostos As New ArrayList,     'CUENTAS CONTABLES D PRODUCTOS
    '        MontosCostos As New ArrayList,  'MONTO DE PRODUCTOS COSTO        
    '        CuentasIngresos As New ArrayList,   'CUENTAS CONTABLES D PRODUCTOS
    '        MontosIngresos As New ArrayList,  'MONTO DE PRODUCTOS INVENTARIO VS. COSTO
    '        ArrayCentros As New ArrayList,   'DISTRIBUION A LOS CENTROS DE COSTOS.
    '        TotalCaja As Double = 0,
    '        MontoIVA As Double = 0,
    '        DT_DETALLE As New DataTable

    '    Dim PlanillaDetalle As New VB.SysContab.PlantillaDetails()
    '    Dim Per_Id As Integer = PeriodosDB.Activo(FechaDevolucion)
    '    Dim Numero As String = DevolucionesClienteDB.Numero()
    '    Dim Dev As New DevolucionesClienteDB()
    '    Dim DTDistribucion As DataTable = CargaDistribucion(0, 0, 0)

    '    If Clientes.FacturaDetalleDevolucion(NoFactura).Tables("Facturas_Ventas").Rows.Count = 0 Then EsProducto = False

    '    If FormaPago.FormaPagoDias(DT_Header.Rows.Item(0)("TIPO_FACTURA")) = 0 Then   'Contado

    '        fp = 0
    '        PlanillaDetalle = VB.SysContab.PlantillaDB.GetPlantillasDetails(4, 1)

    '        If PlanillaDetalle.PlaID Is DBNull.Value Or
    '            PlanillaDetalle.PlaID Is Nothing Or
    '            PlanillaDetalle.PlaID = "" Then

    '            XtraMsg("No existen plantilla del tipo Factura de Contado", MessageBoxIcon.Warning)
    '            Return False
    '        Else

    '            CuentaCliente = PlanillaDetalle.Detalles.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
    '            CuentaIVA = PlanillaDetalle.Detalles.Tables("PlantillasDetalles").Rows(3).Item("Cuenta")

    '            'CuentaIR = PlanillaDetalle.Detalles.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")
    '            'CuentaIR_Alcaldia = PlanillaDetalle.Detalles.Tables("PlantillasDetalles").Rows(6).Item("Cuenta")

    '        End If

    '    Else    'Credito
    '        fp = 1
    '        PlanillaDetalle = VB.SysContab.PlantillaDB.GetPlantillasDetails(4, 2)

    '        If ClienteDetalle.Cuenta.Trim = "" Then
    '            XtraMsg("No se puede contabilizar la Devolución, porque no hay cuenta contable para el cliente: " & ClienteDetalle.Nombre, MessageBoxIcon.Error)
    '            Return False
    '        End If
    '        '
    '        If PlanillaDetalle.PlaID Is DBNull.Value Or
    '           PlanillaDetalle.PlaID Is Nothing Or
    '           PlanillaDetalle.PlaID = "" Then

    '            XtraMsg("No existen plantilla del tipo Factura de Crédito", MessageBoxIcon.Warning)
    '            Return False
    '        Else
    '            CuentaCliente = ClienteDetalle.Cuenta
    '            CuentaIVA = PlanillaDetalle.Detalles.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")
    '        End If


    '    End If

    '    'Iniciar Transacción...
    '    '/****************************************************************************
    '    DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
    '    DBConnFacturas.Open()
    '    transaccionFacturas = DBConnFacturas.BeginTransaction
    '    '****************************************************************************/

    '    Try
    '        '***************  CONTABILIZANDO DEVOLUCION FACTURA
    '        CompNo = ComprobanteDB.AddComprobante(TipoComp, 1,
    '       "Comprobante de Devolucion #: " & Numero & ", Referencia#: " & Referencia,
    '       MonedaBase, Per_Id,
    '       FechaDevolucion, 0, "", False, DT_Header.Rows.Item(0)("CLIENTE"), "", 0, "D" & Numero,
    '                                              VB.SysContab.Rutinas.Fecha, 0, OrigenComprobantes.NC_ELECTRONICA)

    '        If EsProducto Then Dev.AddItem(Numero,
    '                                       NoFactura,
    '                                       Referencia,
    '                                       CompNo,
    '                                       Per_Id,
    '                                       FechaDevolucion.Month,
    '                                       Referencia)

    '        DT_DETALLE = Facturas_VentasDB.ListaDetalle(NoFactura)

    '        For i As Integer = 0 To DT_DETALLE.Rows.Count - 1

    '            Dim IVAUnidad As Double = DT_DETALLE.Rows.Item(i)("IVA")
    '            Dim Descuento As Double = DT_DETALLE.Rows.Item(i)("DESCUENTO")

    '            'Guardar Detalle de la Devolucion
    '            '**************************************************************************
    '            If EsProducto Then
    '                If DT_DETALLE.Rows.Item(i)("TIPO") = "P" Then
    '                    Dev.AddItemDetalle(Numero,
    '                                       DT_DETALLE.Rows.Item(i)("ITEM"),
    '                                       "P",
    '                                       DT_DETALLE.Rows.Item(i)("CANTIDAD"),
    '                                       IVAUnidad)

    '                    Guardar_Con_Transaccion("sp_DevolucionClienteDetalle_Proyecto",
    '                                            DT_DETALLE.Rows.Item(i)("NUMERO"),
    '                                            DT_DETALLE.Rows.Item(i)("CANTIDAD"),
    '                                            EmpresaActual)

    '                    Guardar_Con_Transaccion("sp_DevolucionClienteDetalle_Devuelto",
    '                                            DT_DETALLE.Rows.Item(i)("NUMERO"),
    '                                            EmpresaActual)
    '                End If
    '            End If

    '            ''***********   CUENTAS DE INGRESOS  **********************
    '            Repetido = False

    '            For c As Integer = 0 To CuentasIngresos.Count - 1
    '                If DT_DETALLE.Rows.Item(i)("CUENTA_DEVOLUCION") = CuentasIngresos(c) Then
    '                    MontosIngresos(c) = MontosIngresos(c) + ((DT_DETALLE.Rows.Item(i)("CANTIDAD") * DT_DETALLE.Rows.Item(i)("PRECIO")) -
    '                                                             (DT_DETALLE.Rows.Item(i)("CANTIDAD") * DT_DETALLE.Rows.Item(i)("PRECIO") * (Descuento / 100.0)))
    '                    Repetido = True
    '                End If
    '            Next
    '            '
    '            If Repetido = False Then
    '                CuentasIngresos.Add(DT_DETALLE.Rows.Item(i)("CUENTA_DEVOLUCION"))

    '                MontosIngresos.Add((DT_DETALLE.Rows.Item(i)("CANTIDAD") * DT_DETALLE.Rows.Item(i)("PRECIO")) -
    '                                               (DT_DETALLE.Rows.Item(i)("CANTIDAD") * DT_DETALLE.Rows.Item(i)("PRECIO") * (Descuento / 100.0)))
    '            End If
    '            '' ***********   FIN CUENTAS DE INGRESOS  ************************************* 
    '            '
    '            '' ***********  DISTRIBUCION CUENTAS DE INGRESOS  *****************************
    '            Dim ExisteCentro As Boolean = False
    '            Dim Existe As Boolean = False

    '            For c As Integer = 0 To ArrayCentros.Count - 1
    '                'Verifica si existe centro
    '                If DT_DETALLE.Rows.Item(i)("CentroID") = ArrayCentros(c) Then
    '                    ExisteCentro = True
    '                    'Distribucion Ingresos
    '                    For d As Integer = 0 To DTDistribucion.Rows.Count - 1
    '                        If DT_DETALLE.Rows.Item(i)("CUENTA_DEVOLUCION") = DTDistribucion.Rows(d).Item("Cuenta") And
    '                                     DTDistribucion.Rows(d).Item("IdCentroCosto") = ArrayCentros(c) Then

    '                            Existe = True
    '                            DTDistribucion.Rows(d).Item("Valor") = Math.Round(((DT_DETALLE.Rows.Item(i)("CANTIDAD") * DT_DETALLE.Rows.Item(i)("PRECIO")) -
    '                                                                             (DT_DETALLE.Rows.Item(i)("CANTIDAD") * DT_DETALLE.Rows.Item(i)("PRECIO") * (Descuento / 100))) +
    '                                                                              DTDistribucion.Rows(d).Item("Valor"), 2)
    '                        End If
    '                    Next
    '                End If
    '            Next
    '            '
    '            If ExisteCentro = False Then
    '                'Verifica si no existe y lo agrega
    '                ArrayCentros.Add(DT_DETALLE.Rows.Item(i)("CentroID"))
    '            End If
    '            '
    '            ''******************** AGREGAR DISTRIBUCION A LA TABLA *********************
    '            If Existe = False Then

    '                Dim row As DataRow = DTDistribucion.NewRow()
    '                Dim DT_RG As DataTable = ObtieneDatosTrans("sp_sel_RubroGastos",
    '                                                            DT_DETALLE.Rows.Item(i)("CUENTA_DEVOLUCION"),
    '                                                            EmpresaActual)
    '                If DT_RG.Rows.Count > 0 Then
    '                    row("IdRubroGasto") = DT_RG.Rows(0).Item("Codigo")
    '                    row("IdEmpresa") = EmpresaActual
    '                    row("NoComp") = CompNo
    '                    row("Mes") = FechaDevolucion.Month
    '                    row("Per_Id") = Per_Id
    '                    row("IdCentroCosto") = DT_DETALLE.Rows.Item(i)("CentroID")   'cbCentroCosto.EditValue  
    '                    row("Valor") = Math.Round(((DT_DETALLE.Rows.Item(i)("CANTIDAD") * DT_DETALLE.Rows.Item(i)("PRECIO")) -
    '                                                        (DT_DETALLE.Rows.Item(i)("CANTIDAD") * DT_DETALLE.Rows.Item(i)("PRECIO") * (Descuento / 100))), 2)
    '                    row("Tipo") = "D"
    '                    row("Cuenta") = DT_DETALLE.Rows.Item(i)("CUENTA_DEVOLUCION")

    '                    DTDistribucion.Rows.Add(row)
    '                End If

    '            End If

    '            '***********************************************************************************************
    '            'FIN DE DISTRIBUCION -  CENTRO DE COSTOS
    '            '***********************************************************************************************
    '            '
    '            TotalCaja = TotalCaja + ((DT_DETALLE.Rows.Item(i)("CANTIDAD") * DT_DETALLE.Rows.Item(i)("PRECIO")) -
    '                                                        (DT_DETALLE.Rows.Item(i)("CANTIDAD") * DT_DETALLE.Rows.Item(i)("PRECIO") * (Descuento / 100)))
    '            '
    '            MontoIVA = MontoIVA + (DT_DETALLE.Rows.Item(i)("IVA"))
    '        Next
    '        '
    '        '*****************  CONTABILIZANDO DEBITOS ***********************
    '        '*****************************************************************
    '        'Ingresos 
    '        For c As Integer = 0 To CuentasIngresos.Count - 1
    '            ComprobanteDB.AddComprobanteDetalles(CompNo, CuentasIngresos(c), "Ingreso por Devolucion No. " & Numero,
    '                                      Math.Round(MontosIngresos(c), 2), "0", TipoComp, "D", "0", "0", FechaDevolucion.Date, 1)
    '        Next
    '        '
    '        'IVA    
    '        If MontoIVA > 0 Then
    '            ComprobanteDB.AddComprobanteDetalles(CompNo, CuentaIVA, "IVA Por Devolucion No. " & Numero,
    '                                      Math.Round(MontoIVA, 2), "0", TipoComp, "D", "0", "0", FechaDevolucion.Date, 1)
    '        End If
    '        '
    '        '*****************  CONTABILIZANDO CREDITO ***********************
    '        '*****************************************************************
    '        'Cajas
    '        ComprobanteDB.AddComprobanteDetalles(CompNo, CuentaCliente, IIf(fp = 0, "Fondos por Depositar/Cajas", "Cuentas x Cobrar Clientes"),
    '                                    Math.Round(TotalCaja + MontoIVA, 2), "0", TipoComp, "C", "0", "0", FechaDevolucion.Date, 1)
    '        '
    '        '----------------------
    '        'Guarda la Distribucion
    '        '----------------------
    '        GuardaDistribucionTrans(DTDistribucion, FechaDevolucion.Date, CompNo)


    '        VB.SysContab.Rutinas.okTransaccion()
    '    Catch ex As Exception
    '        XtraMsg(ex.Message & " Contabilizar", MessageBoxIcon.Error)
    '        Rutinas.ErrorTransaccion()
    '        Return False
    '    End Try
    '    '
    '    '----------------------------------------------
    '    'Guardar N/C y Movimiento en el Inventario.
    '    '---------------------------------------------

    '    Try
    '        Dim Note As String = "NC" + NoFactura.PadLeft(6, "0"c)

    '        Dim db_Notas As New db_MaestroNotasCD
    '        'Encabezado de la N/C
    '        Dim IdNota As Integer = db_Notas.Guardar(Note,
    '                                                 ClienteDetalle.Codigo, FechaDevolucion.Date,
    '                                                 TipoComp,
    '                                                 TotalCaja + MontoIVA, "Nota de Credito por Devolución #: " & Numero & ", Referencia#: " & Referencia,
    '                                                 1, MonedaBase, CompNo, Per_Id,
    '                                                 FechaDevolucion.Month,
    '                                                 FechaDevolucion.Date, 0, TipoNC, Referencia, Numero)

    '        If IdNota > 0 Then
    '            'Detalle de la N/C
    '            db_Notas.GuardarDetalle(IdNota,
    '                                NoFactura,
    '                                TotalCaja + MontoIVA,
    '                                FechaDevolucion.Date, 0.00)
    '            ''****************   FIN REGISTRO NOTA DE CREDITO ****************************
    '        End If
    '        '            
    '        '----------------------------------------
    '        'Guarda Movimiento de Inventario
    '        '----------------------------------------

    '        If EsProducto Then
    '            'Validar si hay registros para procesar
    '            Dim dr() As DataRow = DT_DETALLE.Select("EsProyecto = 0")

    '            If dr.Length > 0 Then

    '                Dim _DETALLE As DataTable = DT_DETALLE.Select("EsProyecto = 0").CopyToDataTable

    '                'Productos sin relacion con los proyectos
    '                If _DETALLE.Select("IdProyecto = 0").Length > 0 Then
    '                    Dim _SIN_PROY As DataTable = _DETALLE.Select("IdProyecto = 0").CopyToDataTable

    '                    If _SIN_PROY.Rows.Count > 0 Then

    '                        Dim Requisa As Integer = db_requisas.Add(EmpresaActual, "E", FechaDevolucion.Date, _SIN_PROY.Rows.Item(0)("Bodega"), Login,
    '                                                         Numero, MovimientoID, Referencia,
    '                                                         "Nota de Credito por Devolución #: " & Numero & ", Referencia#: " & Referencia,
    '                                                         "", "", "", "", "", "", ClienteDetalle.Codigo, "", 0, 0, 0, Numero,)

    '                        For i As Integer = 0 To _SIN_PROY.Rows.Count - 1
    '                            If _SIN_PROY.Rows.Item(i)("TIPO") = "P" Then

    '                                db_requisas.AddDetalle(EmpresaActual, Requisa, _SIN_PROY.Rows.Item(i)("ITEM"), "P", _SIN_PROY.Rows.Item(i)("CANTIDAD"),
    '                                            _SIN_PROY.Rows.Item(i)("COSTO"), "NC", "", "", "")
    '                            End If
    '                        Next

    '                    End If

    '                End If

    '                'Productos con Relacion a los Proyectos.
    '                If _DETALLE.Select("IdProyecto > 0").Length > 0 Then
    '                    Dim _CON_PROY As DataTable = _DETALLE.Select("IdProyecto > 0").CopyToDataTable

    '                    If _CON_PROY.Rows.Count > 0 Then

    '                        Dim req = From row In _CON_PROY.AsEnumerable()
    '                                  Select row.Field(Of String)("IdProyecto") Distinct

    '                        For Each s As Object In req
    '                            If Not s Is Nothing Then

    '                                Dim _DT As DataTable = _CON_PROY.Select("IdProyecto = " & s).CopyToDataTable

    '                                Dim Requisa As Integer = db_requisas.Add(EmpresaActual, "E", FechaDevolucion.Date, _DT.Rows.Item(0)("Bodega"), Login,
    '                                                        Numero, MovimientoID, Referencia,
    '                                                        "Nota de Credito por Devolución #: " & Numero & ", Referencia#: " & Referencia,
    '                                                        "", "", "", "", "", "", ClienteDetalle.Codigo, "", s, 0, 0, Numero)

    '                                For i As Integer = 0 To _DT.Rows.Count - 1
    '                                    If _DT.Rows.Item(i)("TIPO") = "P" Then

    '                                        db_requisas.AddDetalle(EmpresaActual, Requisa, _DT.Rows.Item(i)("ITEM"), "P", _DT.Rows.Item(i)("CANTIDAD"),
    '                                                        _DT.Rows.Item(i)("COSTO"), "NC", "", "", "")
    '                                    End If
    '                                Next

    '                            End If
    '                        Next
    '                    End If
    '                End If
    '            End If
    '        End If

    '        XtraMsg("Devolución Electrónica realizada Éxitosamente !!!", MessageBoxIcon.Information)

    '        Return True
    '    Catch ex As Exception
    '        XtraMsg(ex.Message & " Guardar N/C", MessageBoxIcon.Error)
    '        Return False
    '    End Try

    'End Function


    'Sub EnviarXLM(Factura As String)

    '    Dim DT_ENCABEZADO As DataTable = ObtieneDatosTN("sp_GetFacturaFiscal", "Mercurio", Factura, 2, EmpresaActual)
    '    Dim DT_DETALLE As DataTable = ObtieneDatosTN("sp_GetFacturaFiscalDetalle", "SalesLines", Factura, EmpresaActual)

    '    Dim path As String = "C:\XML\FACT_NO_" & vFacturas.GetFocusedRowCellValue("No Factura") & ".xml"

    '    If File.Exists(path) Then File.Delete(path)
    '    'Dim path As String = Server.MapPath("~/OfertaMarcas.xml")

    '    Dim writer As New XmlTextWriter(path, Encoding.UTF8)

    '    writer.Formatting = Xml.Formatting.Indented
    '    writer.WriteStartDocument()

    '    Try
    '        writer.WriteStartElement("Mercurio_Invoices")
    '        writer.WriteStartElement("Mercurio")

    '        writer.WriteAttributeString("Customer_ID", DT_ENCABEZADO.Rows.Item(0)("Customer_ID"))
    '        writer.WriteAttributeString("Customer_Name", DT_ENCABEZADO.Rows.Item(0)("Customer_Name"))
    '        writer.WriteAttributeString("RUC_Cedula", DT_ENCABEZADO.Rows.Item(0)("RUC_Cedula"))
    '        writer.WriteAttributeString("Invoice_Number", DT_ENCABEZADO.Rows.Item(0)("Invoice_Number"))
    '        writer.WriteAttributeString("Invoice_Date", DT_ENCABEZADO.Rows.Item(0)("Invoice_Date"))
    '        writer.WriteAttributeString("Doc_Type", DT_ENCABEZADO.Rows.Item(0)("Doc_Type"))
    '        writer.WriteAttributeString("Salesman_name", DT_ENCABEZADO.Rows.Item(0)("Salesman_name"))
    '        writer.WriteAttributeString("Discount_Amount", DT_ENCABEZADO.Rows.Item(0)("Discount_Amount"))
    '        writer.WriteAttributeString("Discount_Date", DT_ENCABEZADO.Rows.Item(0)("Discount_Date"))
    '        writer.WriteAttributeString("Displayed_Comments", DT_ENCABEZADO.Rows.Item(0)("Displayed_Comments"))
    '        writer.WriteAttributeString("ApplyToInvoiceNumber", DT_ENCABEZADO.Rows.Item(0)("ApplyToInvoiceNumber"))
    '        writer.WriteAttributeString("Total_Amount", DT_ENCABEZADO.Rows.Item(0)("Total_Amount"))
    '        writer.WriteAttributeString("Total_Tax", DT_ENCABEZADO.Rows.Item(0)("Total_Tax"))
    '        writer.WriteAttributeString("Order_No", DT_ENCABEZADO.Rows.Item(0)("Order_No"))
    '        writer.WriteAttributeString("Telefono", DT_ENCABEZADO.Rows.Item(0)("Telefono"))


    '        writer.WriteStartElement("SalesLines")

    '        For i As Integer = 0 To DT_DETALLE.Rows.Count - 1
    '            writer.WriteStartElement("SalesLine")

    '            writer.WriteAttributeString("Item_code", DT_DETALLE.Rows.Item(i)("Item_code"))
    '            writer.WriteAttributeString("item_barcode", DT_DETALLE.Rows.Item(i)("item_barcode"))
    '            writer.WriteAttributeString("Quantity", DT_DETALLE.Rows.Item(i)("Quantity"))
    '            writer.WriteAttributeString("Description", DT_DETALLE.Rows.Item(i)("Description"))
    '            writer.WriteAttributeString("Unit_Price", DT_DETALLE.Rows.Item(i)("Unit_Price"))
    '            writer.WriteAttributeString("Tax_Percent", DT_DETALLE.Rows.Item(i)("Tax_Percent"))
    '            writer.WriteAttributeString("Amount", DT_DETALLE.Rows.Item(i)("Amount"))
    '            writer.WriteAttributeString("Discount", DT_DETALLE.Rows.Item(i)("Discount"))
    '            writer.WriteAttributeString("UOM", DT_DETALLE.Rows.Item(i)("UOM"))
    '            '
    '            writer.WriteEndElement()
    '        Next
    '        'Cierra SalesLines
    '        writer.WriteEndElement()
    '        'Cierra Mercurio_Invoices y Mercurio
    '        writer.WriteEndElement()
    '        writer.Close()
    '        '
    '        XtraMsg("El XML fue creado y enviado a: " & path)
    '    Catch ex As Exception
    '        XtraMsg(ex.Message, MessageBoxIcon.Error)
    '    End Try

    'End Sub


End Class
