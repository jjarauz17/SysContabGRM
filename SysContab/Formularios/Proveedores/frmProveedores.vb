Imports System.Data
Imports System.Data.SqlClient

Public Class frmProveedores
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmProveedores = Nothing

    Public Shared Function Instance() As frmProveedores
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmProveedores()
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
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEstadoCuenta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAcumulado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDevoluciones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNotasCreditos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents VProveedores As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dgProveedores As DevExpress.XtraGrid.GridControl
    Friend WithEvents cbIncompletos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSelector As DevExpress.XtraEditors.CheckEdit
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
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents btnNotasList As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedores))
        Me.btnNotasList = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.bExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNotasCreditos = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAcumulado = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdDevoluciones = New DevExpress.XtraEditors.SimpleButton()
        Me.cbIncompletos = New DevExpress.XtraEditors.CheckEdit()
        Me.chkSelector = New DevExpress.XtraEditors.CheckEdit()
        Me.cmdEstadoCuenta = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.dgProveedores = New DevExpress.XtraGrid.GridControl()
        Me.VProveedores = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cbIncompletos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSelector.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNotasList
        '
        Me.btnNotasList.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotasList.Appearance.Options.UseFont = True
        Me.btnNotasList.Appearance.Options.UseTextOptions = True
        Me.btnNotasList.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnNotasList.Enabled = False
        Me.btnNotasList.Location = New System.Drawing.Point(510, 394)
        Me.btnNotasList.Name = "btnNotasList"
        Me.btnNotasList.Size = New System.Drawing.Size(118, 22)
        Me.btnNotasList.StyleController = Me.LayoutControl1
        Me.btnNotasList.TabIndex = 167
        Me.btnNotasList.Text = "&Listado de Notas D/C"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cmdSalir)
        Me.LayoutControl1.Controls.Add(Me.cmdAyuda)
        Me.LayoutControl1.Controls.Add(Me.bExportar)
        Me.LayoutControl1.Controls.Add(Me.cmdImprimir)
        Me.LayoutControl1.Controls.Add(Me.cmdBorrar)
        Me.LayoutControl1.Controls.Add(Me.btnNotasList)
        Me.LayoutControl1.Controls.Add(Me.cmdNotasCreditos)
        Me.LayoutControl1.Controls.Add(Me.cmdAcumulado)
        Me.LayoutControl1.Controls.Add(Me.cmdDevoluciones)
        Me.LayoutControl1.Controls.Add(Me.cbIncompletos)
        Me.LayoutControl1.Controls.Add(Me.chkSelector)
        Me.LayoutControl1.Controls.Add(Me.cmdEstadoCuenta)
        Me.LayoutControl1.Controls.Add(Me.cmdNuevo)
        Me.LayoutControl1.Controls.Add(Me.cmdModificar)
        Me.LayoutControl1.Controls.Add(Me.dgProveedores)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.LayoutControlItem10, Me.LayoutControlItem9, Me.LayoutControlItem12, Me.LayoutControlItem14})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1026, 191, 450, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(911, 444)
        Me.LayoutControl1.TabIndex = 164
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.ImageOptions.Image = CType(resources.GetObject("cmdSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(797, 394)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(102, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl1
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAyuda.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAyuda.Appearance.Options.UseFont = True
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.Location = New System.Drawing.Point(686, 394)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(156, 22)
        Me.cmdAyuda.StyleController = Me.LayoutControl1
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'bExportar
        '
        Me.bExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bExportar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bExportar.Appearance.Options.UseFont = True
        Me.bExportar.Enabled = False
        Me.bExportar.ImageOptions.Image = CType(resources.GetObject("bExportar.ImageOptions.Image"), System.Drawing.Image)
        Me.bExportar.Location = New System.Drawing.Point(689, 394)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(104, 38)
        Me.bExportar.StyleController = Me.LayoutControl1
        Me.bExportar.TabIndex = 168
        Me.bExportar.Text = "E&xportar"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImprimir.Appearance.Options.UseFont = True
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Location = New System.Drawing.Point(478, 394)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(257, 22)
        Me.cmdImprimir.StyleController = Me.LayoutControl1
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBorrar.Appearance.Options.UseFont = True
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.ImageOptions.Image = CType(resources.GetObject("cmdBorrar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdBorrar.Location = New System.Drawing.Point(214, 394)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(96, 38)
        Me.cmdBorrar.StyleController = Me.LayoutControl1
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "&Borrar"
        '
        'cmdNotasCreditos
        '
        Me.cmdNotasCreditos.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNotasCreditos.Appearance.Options.UseFont = True
        Me.cmdNotasCreditos.Appearance.Options.UseTextOptions = True
        Me.cmdNotasCreditos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdNotasCreditos.Enabled = False
        Me.cmdNotasCreditos.Location = New System.Drawing.Point(425, 394)
        Me.cmdNotasCreditos.Name = "cmdNotasCreditos"
        Me.cmdNotasCreditos.Size = New System.Drawing.Size(81, 22)
        Me.cmdNotasCreditos.StyleController = Me.LayoutControl1
        Me.cmdNotasCreditos.TabIndex = 166
        Me.cmdNotasCreditos.Text = "&Notas de D/C"
        '
        'cmdAcumulado
        '
        Me.cmdAcumulado.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAcumulado.Appearance.Options.UseFont = True
        Me.cmdAcumulado.Enabled = False
        Me.cmdAcumulado.ImageOptions.Image = CType(resources.GetObject("cmdAcumulado.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAcumulado.Location = New System.Drawing.Point(314, 394)
        Me.cmdAcumulado.Name = "cmdAcumulado"
        Me.cmdAcumulado.Size = New System.Drawing.Size(104, 38)
        Me.cmdAcumulado.StyleController = Me.LayoutControl1
        Me.cmdAcumulado.TabIndex = 117
        Me.cmdAcumulado.Text = "&Acumulado"
        '
        'cmdDevoluciones
        '
        Me.cmdDevoluciones.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDevoluciones.Appearance.Options.UseFont = True
        Me.cmdDevoluciones.Enabled = False
        Me.cmdDevoluciones.Location = New System.Drawing.Point(612, 377)
        Me.cmdDevoluciones.Name = "cmdDevoluciones"
        Me.cmdDevoluciones.Size = New System.Drawing.Size(80, 22)
        Me.cmdDevoluciones.StyleController = Me.LayoutControl1
        Me.cmdDevoluciones.TabIndex = 163
        Me.cmdDevoluciones.Text = "&Devoluciones"
        '
        'cbIncompletos
        '
        Me.cbIncompletos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbIncompletos.Location = New System.Drawing.Point(723, 12)
        Me.cbIncompletos.Name = "cbIncompletos"
        Me.cbIncompletos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.cbIncompletos.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.cbIncompletos.Properties.Appearance.Options.UseFont = True
        Me.cbIncompletos.Properties.Appearance.Options.UseForeColor = True
        Me.cbIncompletos.Properties.Caption = "Registros Incompletos"
        Me.cbIncompletos.Size = New System.Drawing.Size(176, 20)
        Me.cbIncompletos.StyleController = Me.LayoutControl1
        Me.cbIncompletos.TabIndex = 161
        Me.cbIncompletos.Visible = False
        '
        'chkSelector
        '
        Me.chkSelector.Location = New System.Drawing.Point(12, 12)
        Me.chkSelector.Name = "chkSelector"
        Me.chkSelector.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSelector.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.chkSelector.Properties.Appearance.Options.UseFont = True
        Me.chkSelector.Properties.Appearance.Options.UseForeColor = True
        Me.chkSelector.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.chkSelector.Properties.Caption = "Mostrar Mas Datos"
        Me.chkSelector.Size = New System.Drawing.Size(707, 20)
        Me.chkSelector.StyleController = Me.LayoutControl1
        Me.chkSelector.TabIndex = 162
        '
        'cmdEstadoCuenta
        '
        Me.cmdEstadoCuenta.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEstadoCuenta.Appearance.Options.UseFont = True
        Me.cmdEstadoCuenta.Appearance.Options.UseTextOptions = True
        Me.cmdEstadoCuenta.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdEstadoCuenta.Enabled = False
        Me.cmdEstadoCuenta.ImageOptions.Image = CType(resources.GetObject("cmdEstadoCuenta.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdEstadoCuenta.Location = New System.Drawing.Point(422, 394)
        Me.cmdEstadoCuenta.Name = "cmdEstadoCuenta"
        Me.cmdEstadoCuenta.Size = New System.Drawing.Size(135, 38)
        Me.cmdEstadoCuenta.StyleController = Me.LayoutControl1
        Me.cmdEstadoCuenta.TabIndex = 8
        Me.cmdEstadoCuenta.Text = "Estado de &Cuenta"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuevo.Appearance.Options.UseFont = True
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.ImageOptions.Image = CType(resources.GetObject("cmdNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdNuevo.Location = New System.Drawing.Point(12, 394)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(97, 38)
        Me.cmdNuevo.StyleController = Me.LayoutControl1
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'cmdModificar
        '
        Me.cmdModificar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModificar.Appearance.Options.UseFont = True
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.ImageOptions.Image = CType(resources.GetObject("cmdModificar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdModificar.Location = New System.Drawing.Point(113, 394)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(97, 38)
        Me.cmdModificar.StyleController = Me.LayoutControl1
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "&Editar"
        '
        'dgProveedores
        '
        Me.dgProveedores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgProveedores.Location = New System.Drawing.Point(12, 36)
        Me.dgProveedores.MainView = Me.VProveedores
        Me.dgProveedores.Name = "dgProveedores"
        Me.dgProveedores.Size = New System.Drawing.Size(887, 354)
        Me.dgProveedores.TabIndex = 160
        Me.dgProveedores.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VProveedores})
        '
        'VProveedores
        '
        Me.VProveedores.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn1, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16})
        Me.VProveedores.GridControl = Me.dgProveedores
        Me.VProveedores.Name = "VProveedores"
        Me.VProveedores.OptionsFind.AlwaysVisible = True
        Me.VProveedores.OptionsFind.ShowClearButton = False
        Me.VProveedores.OptionsView.ShowAutoFilterRow = True
        Me.VProveedores.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VProveedores.OptionsView.ShowFooter = True
        Me.VProveedores.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "APROBAR"
        Me.GridColumn2.FieldName = "APROBAR"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 4
        Me.GridColumn2.Width = 55
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "CONFIRMAR"
        Me.GridColumn1.FieldName = "CONFIRMAR"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 5
        Me.GridColumn1.Width = 55
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "CODIGO"
        Me.GridColumn3.FieldName = "CODIGO"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 81
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "CUENTA"
        Me.GridColumn4.FieldName = "CUENTA"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 119
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn5.AppearanceHeader.Options.UseFont = True
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "NOMBRE"
        Me.GridColumn5.FieldName = "NOMBRE"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 210
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn6.AppearanceHeader.Options.UseFont = True
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "ENCARGADO"
        Me.GridColumn6.FieldName = "ENCARGADO"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 6
        Me.GridColumn6.Width = 55
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn7.AppearanceHeader.Options.UseFont = True
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "DIRECCION"
        Me.GridColumn7.FieldName = "DIRECCION"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 7
        Me.GridColumn7.Width = 55
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn8.AppearanceHeader.Options.UseFont = True
        Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.Caption = "CIUDAD"
        Me.GridColumn8.FieldName = "CIUDAD"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 8
        Me.GridColumn8.Width = 55
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn9.AppearanceHeader.Options.UseFont = True
        Me.GridColumn9.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.Caption = "TELEFONO"
        Me.GridColumn9.FieldName = "TELEFONO"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 9
        Me.GridColumn9.Width = 55
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn10.AppearanceHeader.Options.UseFont = True
        Me.GridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.Caption = "FAX"
        Me.GridColumn10.FieldName = "FAX"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 10
        Me.GridColumn10.Width = 55
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn11.AppearanceHeader.Options.UseFont = True
        Me.GridColumn11.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.Caption = "RUC"
        Me.GridColumn11.FieldName = "RUC"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 11
        Me.GridColumn11.Width = 79
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn12.AppearanceHeader.Options.UseFont = True
        Me.GridColumn12.Caption = "CODIGO LETRA"
        Me.GridColumn12.FieldName = "CodigoLetra"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 1
        Me.GridColumn12.Width = 97
        '
        'GridColumn13
        '
        Me.GridColumn13.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn13.AppearanceHeader.Options.UseFont = True
        Me.GridColumn13.Caption = "EXCENTO IR"
        Me.GridColumn13.FieldName = "EXENTO"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 12
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "RECAUDADOR IVA"
        Me.GridColumn14.FieldName = "RECAUDADOR IVA"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 13
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "ORIGEN"
        Me.GridColumn15.FieldName = "ORIGEN"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 14
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "PREFIJO"
        Me.GridColumn16.FieldName = "PREFIJO"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 15
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmdDevoluciones
        Me.LayoutControlItem8.Location = New System.Drawing.Point(620, 365)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(84, 42)
        Me.LayoutControlItem8.Text = "Devoluciones"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.btnNotasList
        Me.LayoutControlItem10.Location = New System.Drawing.Point(498, 382)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem10.Text = "Listado de Notas D/C"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmdNotasCreditos
        Me.LayoutControlItem9.CustomizationFormText = "Notas de D/C"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(413, 382)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(85, 42)
        Me.LayoutControlItem9.Text = "Notas de D/C"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cmdImprimir
        Me.LayoutControlItem12.Location = New System.Drawing.Point(466, 382)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(261, 42)
        Me.LayoutControlItem12.Text = "Imprimir"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.cmdAyuda
        Me.LayoutControlItem14.Location = New System.Drawing.Point(674, 382)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(160, 42)
        Me.LayoutControlItem14.Text = "Ayuda"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem13, Me.LayoutControlItem15, Me.LayoutControlItem1, Me.LayoutControlItem11, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(911, 444)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.chkSelector
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(711, 24)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbIncompletos
        Me.LayoutControlItem3.Location = New System.Drawing.Point(711, 0)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(180, 24)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(180, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(180, 24)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmdNuevo
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 382)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(101, 42)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(101, 42)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(101, 42)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmdModificar
        Me.LayoutControlItem5.Location = New System.Drawing.Point(101, 382)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(101, 42)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(101, 42)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(101, 42)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cmdAcumulado
        Me.LayoutControlItem6.Location = New System.Drawing.Point(302, 382)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(108, 42)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(108, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(108, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cmdEstadoCuenta
        Me.LayoutControlItem7.Location = New System.Drawing.Point(410, 382)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(139, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(139, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(139, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.bExportar
        Me.LayoutControlItem13.Location = New System.Drawing.Point(677, 382)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(108, 42)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(108, 42)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(108, 42)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.cmdSalir
        Me.LayoutControlItem15.Location = New System.Drawing.Point(785, 382)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dgProveedores
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(891, 358)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cmdBorrar
        Me.LayoutControlItem11.Location = New System.Drawing.Point(202, 382)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(549, 382)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(128, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmProveedores
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(911, 444)
        Me.Controls.Add(Me.LayoutControl1)
        Me.KeyPreview = True
        Me.Name = "frmProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cbIncompletos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSelector.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Estado As Integer

    Private Sub frmProveedores_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then Cargar()
    End Sub

    Private Sub frmProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(LayoutControl1)

        Estado = 0
        Me.cbIncompletos.Checked = False
        Cargar()
        Grid()

        ' VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)            
    End Sub

    Public Sub Cargar()

        If Me.cbIncompletos.Checked = True Then
            Estado = 1
        Else
            Estado = 0
        End If

        Me.dgProveedores.DataSource =
            VB.SysContab _
            .ProveedoresDB _
            .ListaProveedores(
            "",
            Estado) _
            .Tables("Proveedores")
    End Sub

    Sub Grid()
        VProveedores.PopulateColumns()
        FormatoGrid(VProveedores)

        'Me.VProveedores.Columns("CODIGO").Width = 50
        'Me.VProveedores.Columns("CodigoLetra").Width = 50

        VProveedores.Columns("NOMBRE").Width = 150
        VProveedores.Columns("CUENTA").Width = 120
        VProveedores.Columns("TRANSITO").Width = 120


        'If Not ChkProveedores Then  'Si se requiere Confirmacion de Proveedores
        '    Me.VProveedores.Columns("APROBAR").Visible = False
        '    Me.VProveedores.Columns("APROBAR").OptionsColumn.ShowInCustomizationForm = False
        '    Me.VProveedores.Columns("CONFIRMAR").Visible = False
        '    Me.VProveedores.Columns("CONFIRMAR").OptionsColumn.ShowInCustomizationForm = False
        'Else
        '    Me.VProveedores.Columns("APROBAR").Width = 50
        '    Me.VProveedores.Columns("CONFIRMAR").Width = 50
        'End If

        VProveedores.OptionsBehavior.Editable = False
        Me.VProveedores.Columns("ENCARGADO").Visible = False
        Me.VProveedores.Columns("ENCARGADO").OptionsColumn.ShowInCustomizationForm = True
        Me.VProveedores.Columns("DIRECCION").Visible = False
        Me.VProveedores.Columns("DIRECCION").OptionsColumn.ShowInCustomizationForm = True
        Me.VProveedores.Columns("CIUDAD").OptionsColumn.ShowInCustomizationForm = True
        Me.VProveedores.Columns("TELEFONO").Visible = False
        Me.VProveedores.Columns("TELEFONO").OptionsColumn.ShowInCustomizationForm = True
        Me.VProveedores.Columns("FAX").Visible = False
        Me.VProveedores.Columns("FAX").OptionsColumn.ShowInCustomizationForm = True
        'Me.VProveedores.Columns("RUC").Visible = False
        'Me.VProveedores.Columns("RUC").OptionsColumn.ShowInCustomizationForm = True

        ' Me.VProveedores.BestFitColumns()

        If Me.VProveedores.DataRowCount <> 0 Then
            Registro = Me.VProveedores.GetFocusedRowCellValue("CODIGO")
        Else
            Registro = "Vacio"
        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub


    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As frmAgregarProveedor = frmAgregarProveedor.Instance()
        f.etInicio.Text = "1"
        Nuevo = "SI"

        f.MdiParent = Me.MdiParent
        f.Show()

        f.etInicio.Text = "0"
        f.txtNombre.Focus()
        f.cbZona.SelectedValue = 0
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If Me.VProveedores.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro!")
            Exit Sub
        End If

        Registro = Me.VProveedores.GetFocusedRowCellValue("CODIGO")

        Dim f As frmAgregarProveedor = frmAgregarProveedor.Instance
        Nuevo = "NO"
        f.etInicio.Text = "0"

        If Registro = "Vacio" Then
            MsgBox("Seleccione el Proveedor que desea Editar", MsgBoxStyle.Information)
            Exit Sub
        End If

        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
        f.cbMunicipios.EditValue = f.Detalles.Municipio

    End Sub



    Private Sub frmProveedores_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Opened = "NO"
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        If Me.VProveedores.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro!")
            Exit Sub
        End If
        Registro = Me.VProveedores.GetFocusedRowCellValue("CODIGO")

        If ObtieneDatos("Select count(*) as cuenta from comprobantes Where empresa = " & EmpresaActual & " and proveedor = " & Registro).Rows(0).Item(0) > 0 Then
            XtraMsg("No se puede Eliminar el registro, porque tiene transacciones en Comprobantes Contables", MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not XtraMsg2("Esta seguro que dese borrar el Proveedor: " & Me.VProveedores.GetFocusedRowCellValue("NOMBRE")) Then
            Exit Sub
        End If

        Try
            VB.SysContab.ProveedoresDB.Delete(Registro)

            Me.Cargar()
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim f As frmReportesProveedores = frmReportesProveedores.Instance
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmProveedores_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter

    End Sub

    Private Sub dgProveedores_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtBuscar_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/ProvListProv.chm")
    End Sub

    Private Sub cmdEstadoCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEstadoCuenta.Click
        If Me.VProveedores.DataRowCount = 0 Then
            XtraMsg("No hay registros en la lista", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        Dim frm As frmEstadoCuentaProveedor = frmEstadoCuentaProveedor.Instance()
        frm.Dispose()
        '
        Registro = Me.VProveedores.GetFocusedRowCellValue("CODIGO")
        Dim f As frmEstadoCuentaProveedor = frmEstadoCuentaProveedor.Instance()
        f.etProveedor.Text = Registro
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub cbIncompletos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Me.cbIncompletos.Checked = True Then
        '    Estado = 1
        'Else
        '    Estado = 0
        'End If
        'Me.dgProveedores.DataSource =
        '    VB.SysContab.ProveedoresDB.ListaProveedores("", Estado).Tables("Proveedores")
    End Sub

    Private Sub cmdAcumulado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcumulado.Click
        If Me.VProveedores.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Contab")
            Exit Sub
        End If
        Registro = Me.VProveedores.GetFocusedRowCellValue("CODIGO")

        Dim f As frmAcumuladosProveedor = frmAcumuladosProveedor.Instance()

        f.Proveedor = Registro

        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub

    Private Sub cmdDevoluciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDevoluciones.Click
        If Me.VProveedores.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Contab")
            Exit Sub
        End If
        Registro = Me.VProveedores.GetFocusedRowCellValue("CODIGO")

        Dim f As frmDevolucionesProveedorList = frmDevolucionesProveedorList.Instance()
        f.etInicio.Text = "1"
        f.Proveedor = Me.VProveedores.GetFocusedRowCellValue("CODIGO")
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
        f.cbProveedores.SelectedValue = Me.VProveedores.GetFocusedRowCellValue("CODIGO")
        f.cbProveedores.Focus()
        f.etInicio.Text = "0"
    End Sub

    Private Sub cmdNotasCreditos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNotasCreditos.Click
        If Me.VProveedores.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Contab")
            Exit Sub
        End If
        Registro = Me.VProveedores.GetFocusedRowCellValue("CODIGO")

        Dim f As frmNotasCreditoProveedor = frmNotasCreditoProveedor.Instance()
        f.etInicio.Text = "1"
        f.etProveedorCodigo.Text = Me.VProveedores.GetFocusedRowCellValue("CODIGO")

        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "0"
    End Sub

    Private Sub VProveedores_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles VProveedores.CellValueChanged
        Try
            If e.Column.FieldName = "PREFIJO" Then
                Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())

                Conn.RemoveParameters()
                Conn.AddParameter("Prefijo", SqlDbType.NVarChar, 50, ParameterDirection.Input, VProveedores.GetRowCellValue(e.RowHandle, "PREFIJO"))
                Conn.AddParameter("Codigo", SqlDbType.Int, 5, ParameterDirection.Input, VProveedores.GetRowCellValue(e.RowHandle, "CODIGO"))
                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)

                Conn.EjecutarComando("JAR_UpdateProveedores_Prefijo")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub VProveedores_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles VProveedores.FocusedRowChanged
        Registro = Me.VProveedores.GetFocusedRowCellValue("CODIGO")

    End Sub

    Private Sub chkSelector_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelector.CheckedChanged
        If Me.chkSelector.Checked = True Then Me.VProveedores.ColumnsCustomization() Else Me.VProveedores.DestroyCustomization()
    End Sub

    Private Sub VProveedores_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles VProveedores.CellValueChanging
        If Not ChkProveedores Then
            Exit Sub
        End If


        'Aprobar Proveedor
        If e.Column.FieldName = "APROBAR" Then
            Dim Codigo1 As String
            Try
                'Verificar Si existe el Codigo de Aprobación
                Codigo1 = ObtieneDatos("Select Codigo from CodigoFactura WHERE Tipo = 4").Rows.Item(0)("Codigo")

                If Me.VProveedores.GetRowCellValue(e.RowHandle, "APROBAR") = True Then
                    Me.VProveedores.SetRowCellValue(e.RowHandle, "APROBAR", True)
                Else
                    Dim c As String = InputBox("Introduzca el Codigo de Aprobación del Proveedor", "Aprobar Proveedor")
                    If c.Trim = Codigo1 Then
                        Me.VProveedores.SetRowCellValue(e.RowHandle, "APROBAR", True)
                        GuardarArobacion("APROBAR", Me.VProveedores.FocusedRowHandle)
                        MsgBox("El Proveedor ha sido debidamente Aprobado", MsgBoxStyle.Information)
                    Else
                        MsgBox("Codigo Inválido", MsgBoxStyle.Exclamation)
                        Me.VProveedores.SetRowCellValue(e.RowHandle, "APROBAR", False)
                    End If
                End If

                Me.VProveedores.RefreshData()
                Exit Sub
            Catch ex As Exception
                MsgBox("No Existe Codigo de Aprobación", MsgBoxStyle.Exclamation)
                Exit Sub
            End Try
        End If

        'Confirmar Aprobación de Proveedor
        If e.Column.FieldName = "CONFIRMAR" Then
            Dim Codigo2 As String
            Try
                'Verificar Si existe el Codigo de Confirmación
                Codigo2 = ObtieneDatos("Select Codigo from CodigoFactura WHERE Tipo = 5").Rows.Item(0)("Codigo")

                If Me.VProveedores.GetRowCellValue(e.RowHandle, "APROBAR") = False Then
                    MsgBox("El Proveedor deber ser Aprobado y Luego Confirmado", MsgBoxStyle.Exclamation, "STS-Contab")
                    Me.VProveedores.SetRowCellValue(e.RowHandle, "APROBAR", False)
                    Me.VProveedores.RefreshData()
                    Exit Sub
                Else
                    If Me.VProveedores.GetRowCellValue(e.RowHandle, "CONFIRMAR") = True Then
                        Me.VProveedores.SetRowCellValue(e.RowHandle, "CONFIRMAR", True)
                    Else
                        Dim c As String = InputBox("Introduzca el Codigo de Confirmación del Proveedor", "Confirmar Proveedor")
                        If c.Trim = Codigo2 Then
                            Me.VProveedores.SetRowCellValue(e.RowHandle, "CONFIRMAR", True)
                            GuardarArobacion("CONFIRMAR", Me.VProveedores.FocusedRowHandle)
                            MsgBox("El Proveedor ha sido debidamente Confirmado", MsgBoxStyle.Information)
                        Else
                            MsgBox("Codigo Inválido", MsgBoxStyle.Exclamation)
                            Me.VProveedores.SetRowCellValue(e.RowHandle, "CONFIRMAR", False)
                        End If
                    End If
                End If

                Me.VProveedores.RefreshData()
            Catch ex As Exception
                MsgBox("No Existe Codigo de Aprobación", MsgBoxStyle.Exclamation)
                Exit Sub
            End Try
        End If

    End Sub

    Sub GuardarArobacion(ByVal op As String, ByVal i As Integer)

        Dim sSQL As String = String.Empty
        Dim Con As New SqlConnection(VB.SysContab.Rutinas.AbrirConexion)

        If op = "APROBAR" Then
            sSQL = "UPDATE PROVEEDORES SET Aprobar = 1 WHERE CODIGO = " & Me.VProveedores.GetRowCellValue(i, "CODIGO") & " AND EMPRESA = " & EmpresaActual
        ElseIf op = "CONFIRMAR" Then
            sSQL = "UPDATE PROVEEDORES SET Confirmar = 1 WHERE CODIGO = " & Me.VProveedores.GetRowCellValue(i, "CODIGO") & " AND EMPRESA = " & EmpresaActual
        End If

        Try
            Con.Open()
            Dim cmd As New SqlCommand(sSQL, Con)
            cmd.ExecuteNonQuery()

            Con.Close()
        Catch ex As Exception
            Con.Close()
            MsgBox("ERROR al Actualizar Datos", MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub btnNotasList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotasList.Click
        Dim f As New frmNotasProveedoresList
        f.MdiParent = Me.MdiParent
        f.WindowState = FormWindowState.Maximized
        f.Show()
    End Sub

    Private Sub bExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(dgProveedores)
    End Sub

    Private Sub cbIncompletos_CheckedChanged_1(sender As Object, e As EventArgs) Handles cbIncompletos.CheckedChanged
        Cargar()
    End Sub
End Class
