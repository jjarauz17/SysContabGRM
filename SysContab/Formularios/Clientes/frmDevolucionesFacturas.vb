Imports ClasesBLL
Imports System.Linq
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports SysContab.VB.SysContab

Public Class frmDevolucionesFacturas
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmDevolucionesFacturas = Nothing

    Public Shared Function Instance() As frmDevolucionesFacturas
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmDevolucionesFacturas()
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
    Friend WithEvents cmdPagos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents etInicio As System.Windows.Forms.Label
    Friend WithEvents cmdDevoluciones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEntrada As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdVerDevolucion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Hasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Desde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cbCajas As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents rgTipo As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevolucionesFacturas))
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.rgTipo = New DevExpress.XtraEditors.RadioGroup()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.etInicio = New System.Windows.Forms.Label()
        Me.cmdDevoluciones = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdVerDevolucion = New DevExpress.XtraEditors.SimpleButton()
        Me.dgDatos = New DevExpress.XtraGrid.GridControl()
        Me.vDatos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdEntrada = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdPagos = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.cbCajas = New DevExpress.XtraEditors.LookUpEdit()
        Me.Desde = New DevExpress.XtraEditors.DateEdit()
        Me.Hasta = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.rgTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCajas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Desde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Desde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.Location = New System.Drawing.Point(121, 711)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(642, 22)
        Me.cmdAyuda.StyleController = Me.LayoutControl1
        Me.cmdAyuda.TabIndex = 161
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.rgTipo)
        Me.LayoutControl1.Controls.Add(Me.cmdSalir)
        Me.LayoutControl1.Controls.Add(Me.etInicio)
        Me.LayoutControl1.Controls.Add(Me.cmdAyuda)
        Me.LayoutControl1.Controls.Add(Me.cmdDevoluciones)
        Me.LayoutControl1.Controls.Add(Me.cmdVerDevolucion)
        Me.LayoutControl1.Controls.Add(Me.dgDatos)
        Me.LayoutControl1.Controls.Add(Me.cmdImprimir)
        Me.LayoutControl1.Controls.Add(Me.cmdEntrada)
        Me.LayoutControl1.Controls.Add(Me.cmdBorrar)
        Me.LayoutControl1.Controls.Add(Me.cmdPagos)
        Me.LayoutControl1.Controls.Add(Me.cmdModificar)
        Me.LayoutControl1.Controls.Add(Me.cmdBuscar)
        Me.LayoutControl1.Controls.Add(Me.cbCajas)
        Me.LayoutControl1.Controls.Add(Me.Desde)
        Me.LayoutControl1.Controls.Add(Me.Hasta)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem10, Me.LayoutControlItem9, Me.LayoutControlItem8, Me.LayoutControlItem7, Me.LayoutControlItem6, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem11})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(900, 216, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(834, 661)
        Me.LayoutControl1.TabIndex = 166
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'rgTipo
        '
        Me.rgTipo.EditValue = 1
        Me.rgTipo.Location = New System.Drawing.Point(121, 615)
        Me.rgTipo.Name = "rgTipo"
        Me.rgTipo.Properties.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.rgTipo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgTipo.Properties.Appearance.ForeColor = System.Drawing.Color.OrangeRed
        Me.rgTipo.Properties.Appearance.Options.UseBackColor = True
        Me.rgTipo.Properties.Appearance.Options.UseFont = True
        Me.rgTipo.Properties.Appearance.Options.UseForeColor = True
        Me.rgTipo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Devolución Total"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Devolución Parcial")})
        Me.rgTipo.Size = New System.Drawing.Size(598, 34)
        Me.rgTipo.StyleController = Me.LayoutControl1
        Me.rgTipo.TabIndex = 165
        '
        'cmdSalir
        '
        Me.cmdSalir.ImageOptions.Image = CType(resources.GetObject("cmdSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(723, 611)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(99, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl1
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'etInicio
        '
        Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etInicio.Location = New System.Drawing.Point(788, 12)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(34, 48)
        Me.etInicio.TabIndex = 158
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
        '
        'cmdDevoluciones
        '
        Me.cmdDevoluciones.ImageOptions.Image = CType(resources.GetObject("cmdDevoluciones.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdDevoluciones.Location = New System.Drawing.Point(12, 611)
        Me.cmdDevoluciones.Name = "cmdDevoluciones"
        Me.cmdDevoluciones.Size = New System.Drawing.Size(105, 38)
        Me.cmdDevoluciones.StyleController = Me.LayoutControl1
        Me.cmdDevoluciones.TabIndex = 160
        Me.cmdDevoluciones.Text = "&Devolución"
        '
        'cmdVerDevolucion
        '
        Me.cmdVerDevolucion.Appearance.Options.UseTextOptions = True
        Me.cmdVerDevolucion.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdVerDevolucion.Enabled = False
        Me.cmdVerDevolucion.Location = New System.Drawing.Point(121, 711)
        Me.cmdVerDevolucion.Name = "cmdVerDevolucion"
        Me.cmdVerDevolucion.Size = New System.Drawing.Size(535, 22)
        Me.cmdVerDevolucion.StyleController = Me.LayoutControl1
        Me.cmdVerDevolucion.TabIndex = 159
        Me.cmdVerDevolucion.Text = "&Listado de Devoluciones"
        '
        'dgDatos
        '
        Me.dgDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDatos.Location = New System.Drawing.Point(12, 90)
        Me.dgDatos.MainView = Me.vDatos
        Me.dgDatos.Name = "dgDatos"
        Me.dgDatos.Size = New System.Drawing.Size(810, 505)
        Me.dgDatos.TabIndex = 163
        Me.dgDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vDatos})
        '
        'vDatos
        '
        Me.vDatos.GridControl = Me.dgDatos
        Me.vDatos.Name = "vDatos"
        Me.vDatos.OptionsBehavior.Editable = False
        Me.vDatos.OptionsView.ShowAutoFilterRow = True
        Me.vDatos.OptionsView.ShowFooter = True
        Me.vDatos.OptionsView.ShowGroupPanel = False
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(787, 363)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(57, 22)
        Me.cmdImprimir.StyleController = Me.LayoutControl1
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Reporte"
        Me.cmdImprimir.Visible = False
        '
        'cmdEntrada
        '
        Me.cmdEntrada.Appearance.Options.UseTextOptions = True
        Me.cmdEntrada.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdEntrada.Location = New System.Drawing.Point(12, 363)
        Me.cmdEntrada.Name = "cmdEntrada"
        Me.cmdEntrada.Size = New System.Drawing.Size(832, 22)
        Me.cmdEntrada.StyleController = Me.LayoutControl1
        Me.cmdEntrada.TabIndex = 1
        Me.cmdEntrada.Text = "&Registrar Entrada"
        Me.cmdEntrada.Visible = False
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(735, 363)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(109, 22)
        Me.cmdBorrar.StyleController = Me.LayoutControl1
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "&Borrar"
        Me.cmdBorrar.Visible = False
        '
        'cmdPagos
        '
        Me.cmdPagos.Location = New System.Drawing.Point(474, 363)
        Me.cmdPagos.Name = "cmdPagos"
        Me.cmdPagos.Size = New System.Drawing.Size(370, 22)
        Me.cmdPagos.StyleController = Me.LayoutControl1
        Me.cmdPagos.TabIndex = 7
        Me.cmdPagos.Text = "Ver &Pagos"
        Me.cmdPagos.Visible = False
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(697, 363)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(147, 22)
        Me.cmdModificar.StyleController = Me.LayoutControl1
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "&Ver"
        Me.cmdModificar.Visible = False
        '
        'cmdBuscar
        '
        Me.cmdBuscar.ImageOptions.Image = CType(resources.GetObject("cmdBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdBuscar.Location = New System.Drawing.Point(242, 22)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(98, 38)
        Me.cmdBuscar.StyleController = Me.LayoutControl1
        Me.cmdBuscar.TabIndex = 162
        Me.cmdBuscar.Text = "B&uscar"
        '
        'cbCajas
        '
        Me.cbCajas.Location = New System.Drawing.Point(107, 64)
        Me.cbCajas.Name = "cbCajas"
        Me.cbCajas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCajas.Properties.Appearance.Options.UseFont = True
        Me.cbCajas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCajas.Properties.PopupFormMinSize = New System.Drawing.Size(400, 0)
        Me.cbCajas.Properties.ShowFooter = False
        Me.cbCajas.Size = New System.Drawing.Size(715, 22)
        Me.cbCajas.StyleController = Me.LayoutControl1
        Me.cbCajas.TabIndex = 164
        '
        'Desde
        '
        Me.Desde.EditValue = Nothing
        Me.Desde.Location = New System.Drawing.Point(107, 12)
        Me.Desde.Name = "Desde"
        Me.Desde.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desde.Properties.Appearance.Options.UseFont = True
        Me.Desde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Desde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Desde.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.Desde.Size = New System.Drawing.Size(131, 20)
        Me.Desde.StyleController = Me.LayoutControl1
        Me.Desde.TabIndex = 154
        '
        'Hasta
        '
        Me.Hasta.EditValue = Nothing
        Me.Hasta.Location = New System.Drawing.Point(107, 36)
        Me.Hasta.Name = "Hasta"
        Me.Hasta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hasta.Properties.Appearance.Options.UseFont = True
        Me.Hasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Hasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Hasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.Hasta.Size = New System.Drawing.Size(131, 20)
        Me.Hasta.StyleController = Me.LayoutControl1
        Me.Hasta.TabIndex = 154
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cmdImprimir
        Me.LayoutControlItem10.Location = New System.Drawing.Point(775, 351)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(61, 26)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmdBorrar
        Me.LayoutControlItem9.Location = New System.Drawing.Point(723, 351)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(113, 26)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmdModificar
        Me.LayoutControlItem8.Location = New System.Drawing.Point(685, 351)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(151, 26)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cmdPagos
        Me.LayoutControlItem7.Location = New System.Drawing.Point(462, 351)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(374, 26)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cmdEntrada
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 351)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(836, 26)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.cmdVerDevolucion
        Me.LayoutControlItem13.Location = New System.Drawing.Point(109, 699)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(539, 42)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.cmdAyuda
        Me.LayoutControlItem14.Location = New System.Drawing.Point(109, 699)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(646, 42)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.EmptySpaceItem1, Me.LayoutControlItem5, Me.EmptySpaceItem2, Me.LayoutControlItem12, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.EmptySpaceItem3, Me.EmptySpaceItem4})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(834, 661)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Desde
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(230, 24)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(230, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(230, 24)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Desde:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Hasta
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(230, 28)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(230, 28)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(230, 28)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Hasta:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbCajas
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(814, 26)
        Me.LayoutControlItem3.Text = "Caja:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.dgDatos
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 78)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(814, 509)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(332, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(482, 52)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmdBuscar
        Me.LayoutControlItem5.Location = New System.Drawing.Point(230, 10)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(230, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(102, 10)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.etInicio
        Me.LayoutControlItem11.Location = New System.Drawing.Point(776, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(38, 52)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        Me.LayoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cmdDevoluciones
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 599)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(109, 42)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(109, 42)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(109, 42)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.cmdSalir
        Me.LayoutControlItem15.Location = New System.Drawing.Point(711, 599)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(103, 42)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(103, 42)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(103, 42)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem16.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem16.Control = Me.rgTipo
        Me.LayoutControlItem16.Location = New System.Drawing.Point(109, 587)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(602, 54)
        Me.LayoutControlItem16.Text = "Tipo Devolución:"
        Me.LayoutControlItem16.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(92, 13)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(711, 587)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(103, 12)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 587)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(109, 12)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmDevolucionesFacturas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(834, 661)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmDevolucionesFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturas de Clientes"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.rgTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCajas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Desde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Desde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Clientes As New VB.SysContab.ClientesDB()
    Dim Cajas As New VB.SysContab.CajasDB()
    Dim FormaPago As New VB.SysContab.Forma_PagoDB()
    Dim r As New VB.SysContab.Rutinas()
    Dim ds As DataSet

    'Public Inicio As Boolean

    'Dim BuscarPor As Integer

    'Public Fecha1 As String
    'Public Fecha2 As String

    Private Sub frmListaFacturaClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'RolesDB.UsuarioAcciones(PanelControl2)

        'Dim Tabla As DataTable

        'Dim dsFormaPago As DataSet
        'Dim i As Integer

        'BuscarPor = 2

        'Fecha1 = ""
        'Fecha2 = ""

        'Me.Desde.DateTime = r.Fecha
        'Me.Hasta.DateTime = r.Fecha
        '

        Dim f As Date = r.Fecha().Date
        Desde.DateTime = New DateTime(f.Year, f.Month, 1).Date
        Hasta.DateTime = UltimoDiaDelMes(f.Date).Date

        GetCajasxUsuario(Me.cbCajas)

        'cbClientes.DataSource = Clientes.GetList.Tables("Clientes")
        'cbClientes.ValueMember = "Codigo"
        'cbClientes.DisplayMember = "Nombre"

        Buscar()
        ArmarGrid()
        'ds = Clientes.DevolucionesFacturas(Me.txtFactura.Text, "", 0, 0, 0, Fecha1, Fecha2, BuscarPor)
        'dgFacturasClientes.DataSource = ds.Tables("Facturas_Ventas").DefaultView
        'Tabla = ds.Tables("Facturas_Ventas")

        'r.FormatGenerico(dgFacturasClientes, Tabla)

        'If ds.Tables("Facturas_Ventas").Rows.Count <> 0 Then
        '    Registro = dgFacturasClientes.Item(0, 0)
        'Else
        '    Registro = "Vacio"
        'End If

        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)

        'dgFacturasClientes.CaptionText = "          Facturas de Clientes"
        'r.ComboAutoComplete(Me.cbClientes)

        'Me.Text = "F a c t u r a s  de  C l i e n t e s"
        'Me.Refresh()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Public Sub Buscar()
        ShowSplash("Cargando Facturas...")
        dgDatos.DataSource = ObtieneDatos("sp_DevolucionesFacturas",
                                          Desde.DateTime.Date,
                                          Hasta.DateTime.Date,
                                          cbCajas.EditValue,
                                          EmpresaActual,
                                          Usuario_ID)
        HideSplash()

        'Dim Datos As New ArrayList
        'Dim Varialbes As New ArrayList

        'Varialbes.Add("Desde")
        'Varialbes.Add("Hasta")
        'Varialbes.Add("Caja")
        'Varialbes.Add("Empresa")
        'Varialbes.Add("Usuario")
        ''
        'Datos.Add(Me.Desde.DateTime.Date)
        'Datos.Add(Me.Hasta.DateTime.Date)
        'Datos.Add(Me.cbCajas.EditValue)
        'Datos.Add(EmpresaActual)
        'Datos.Add(Usuario_ID)

        'Me.dgDatos.DataSource = ProcedureParameters(Datos, Varialbes, "sp_DevolucionesFacturas")
        ''ds = Clientes.DevolucionesFacturas(Me.txtFactura.Text, "", 0, 0, 0, Me.Desde.DateTime.Date, Me.Hasta.DateTime.Date, BuscarPor)
        ''Me.dgDatos.DataSource = ds.Tables("Facturas_Ventas").DefaultView       
    End Sub

    Sub ArmarGrid()
        Me.vDatos.PopulateColumns()
        FormatoGrid(Me.vDatos, 2, 0, False)
        '
        Me.vDatos.Columns("ClienteID").Visible = False
        Me.vDatos.Columns("CODIGO_BODEGA").Visible = False
        Me.vDatos.Columns("CUENTA CAJA").Visible = False
        Me.vDatos.Columns("CentroID").Visible = False
        Me.vDatos.Columns("FormaPagoID").Visible = False
        Me.vDatos.Columns("Seleccionar").Visible = False
        vDatos.Columns("DIAS").Visible = False
        'Me.vDatos.Columns("Tipo").Visible = False
        '
        'Me.vDatos.Columns("MONTO").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.vDatos.Columns("MONTO").DisplayFormat.FormatString = "{0:n2}"
        'Me.vDatos.Columns("MONTO").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.vDatos.Columns("MONTO").SummaryItem.DisplayFormat = "{0:n2}"
        ''
        'Me.vDatos.Columns("DESCUENTO").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.vDatos.Columns("DESCUENTO").DisplayFormat.FormatString = "{0:n2}"
        'Me.vDatos.Columns("DESCUENTO").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.vDatos.Columns("DESCUENTO").SummaryItem.DisplayFormat = "{0:n2}"
        ''
        'Me.vDatos.Columns("SUBTOTAL").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.vDatos.Columns("SUBTOTAL").DisplayFormat.FormatString = "{0:n2}"
        'Me.vDatos.Columns("SUBTOTAL").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.vDatos.Columns("SUBTOTAL").SummaryItem.DisplayFormat = "{0:n2}"
        ''
        'Me.vDatos.Columns("IVA").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.vDatos.Columns("IVA").DisplayFormat.FormatString = "{0:n2}"
        'Me.vDatos.Columns("IVA").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.vDatos.Columns("IVA").SummaryItem.DisplayFormat = "{0:n2}"
        ''
        'Me.vDatos.Columns("TOTAL").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.vDatos.Columns("TOTAL").DisplayFormat.FormatString = "{0:n2}"
        'Me.vDatos.Columns("TOTAL").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.vDatos.Columns("TOTAL").SummaryItem.DisplayFormat = "{0:n2}"
        ' Me.vDatos.BestFitColumns()
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        'If Me.vDatos.FocusedRowHandle < 0 Then
        '    XtraMsg("Seleccione una Factura")
        '    Exit Sub
        'End If

        ''If Me.dgFacturasClientes.CurrentRowIndex = ds.Tables("Facturas_Ventas").Rows.Count - 1 Then
        ''    MsgBox("Seleccione una Factura", MsgBoxStyle.Information)
        ''    Exit Sub
        ''End If

        'Dim f As DataGridTextBoxCombo.frmFacturacionClienteVer = f.Instance

        ''Registro = dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 0)
        'Registro = Me.vDatos.GetFocusedRowCellValue("No Factura")

        'If Registro = "Vacio" Then
        '    MsgBox("Seleccione la Factura", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'f.MdiParent = Me.MdiParent
        'f.Show()
        'f.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub frmListaFacturaClientes_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter


    End Sub

    Private Sub dgFacturasClientes_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        'If Me.vDatos.FocusedRowHandle < 0 Then
        '    XtraMsg("Seleccione una Factura")
        '    Exit Sub
        'End If

        'Registro = Me.vDatos.GetFocusedRowCellValue("No Factura")

        'Dim resp As DialogResult
        'Dim clientes As New VB.SysContab.ClientesDB()

        ''Registro = dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 0)

        ''If Registro = "Vacio" Then
        ''    MsgBox("Seleccione la Factura que desea Borrar", MsgBoxStyle.Information)
        ''    Exit Sub
        ''End If

        'resp = MsgBox("Esta seguro que dese borrar la Factura: " & dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 0), MsgBoxStyle.YesNo + MsgBoxStyle.Question)

        'If resp = DialogResult.No Then
        '    Exit Sub
        'End If

        'Try
        '    clientes.FacturaDelete(dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 0))
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    Exit Sub
        'End Try

        'Dim r As New VB.SysContab.Rutinas()
        'Dim Tabla As New DataTable()
        'Dim ds As New DataSet()

        'dgFacturasClientes.DataSource = ds.Tables("Facturas_Ventas").DefaultView
        'Tabla = ds.Tables("Facturas_Ventas")

        'If ds.Tables("Facturas_Ventas").Rows.Count = 0 Then
        '    Registro = "Vacio"

        'End If

        'r.FormatGenerico(dgFacturasClientes, Tabla)
    End Sub

    'Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
    '    'Dim fReportes As New frmReportes()
    '    'Dim rFacturas As New rptFacturas()
    '    'Dim Clientes As New VB.SysContab.ClientesDB()

    '    'rFacturas.SetDataSource(Clientes.FacturasPrint(Registro))
    '    'fReportes.crvReportes.ReportSource = rFacturas

    '    'freportes.Show()
    '    Dim f As frmReportesFactura = f.Instance
    '    f.MdiParent = Me.MdiParent
    '    f.WindowState = FormWindowState.Maximized
    '    f.Show()


    'End Sub

    Private Sub dgFacturasClientes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        'If Me.dgFacturasClientes.CurrentRowIndex = ds.Tables("Facturas_Ventas").Rows.Count - 1 Then
        '    MsgBox("Seleccione una Factura", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'Dim f As DataGridTextBoxCombo.frmFacturacionClienteVer = f.Instance
        'Registro = dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 0)

        'If Registro = "Vacio" Then
        '    MsgBox("Seleccione la Factura", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'f.MdiParent = Me.MdiParent
        'f.Show()
        'f.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub cmdPagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPagos.Click
        'Dim ds As DataSet
        'Registro = dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 0)
        'If Registro = "Vacio" Then
        '    MsgBox("Seleccione la Factura", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'ds = Clientes.CobrosHistorial(Registro)

        'If ds.Tables("Cobros").Rows.Count = 0 Then
        '    MsgBox("La Factura seleccionada no tiene ningún pago", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'Dim f As frmHistorialCobros = f.Instance

        'f.MdiParent = Me.MdiParent
        'f.WindowState = FormWindowState.Maximized
        'f.Show()

    End Sub

    Private Sub checkBoxFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If etInicio.Text = "1" Then
        '    Exit Sub
        'End If

        'Try
        '    If checkBoxFecha.Checked = True Then
        '        Fecha1 = Me.dtpFechaDesde.Value.Date
        '        Fecha2 = Me.dtpFechaHasta.Value.Date

        '        dtpFechaDesde.Enabled = True
        '        dtpFechaHasta.Enabled = True

        '        BuscarPor = 2
        '    Else
        '        Fecha1 = ""
        '        Fecha2 = ""

        '        BuscarPor = 1

        '        dtpFechaDesde.Enabled = False
        '        dtpFechaHasta.Enabled = False
        '    End If
        '    ds = Clientes.DevolucionesFacturas(Me.txtFactura.Text, cbClientes.Text, 0, 0, 0, Fecha1, Fecha2, BuscarPor)
        '    dgFacturasClientes.DataSource = ds.Tables("Facturas_Ventas").DefaultView
        'Catch ex As ExecutionEngineException
        '    MsgBox(ex.Message & " checkBoxFecha_CheckedChanged")
        'End Try
    End Sub

    Private Sub dtpFechaDesde_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dtpFechaHasta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cbClientes_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'If etInicio.Text = "1" Then
        '    Exit Sub
        'End If

        'Try
        '    ds = Clientes.DevolucionesFacturas(Me.txtFactura.Text, cbClientes.Text, 0, 0, 0, Fecha1, Fecha2, BuscarPor)
        '    dgFacturasClientes.DataSource = ds.Tables("Facturas_Ventas").DefaultView

        '    If ds.Tables("Facturas_Ventas").Rows.Count = 0 Then
        '        Registro = "Vacio"
        '        Exit Sub
        '    End If

        '    Registro = dgFacturasClientes.Item(0, 0)
        'Catch ex As Exception
        '    MsgBox(ex.Message & " cbClientes_SelectedValueChanged")

        'End Try
    End Sub

    Private Sub cmdSalidaBodega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVerDevolucion.Click
        Me.etInicio.Text = "1"
        Dim f As frmDevolucionesClienteList = frmDevolucionesClienteList.Instance()
        f.etInicio.Text = "1"
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "0"
    End Sub

    Private Sub cmdDevoluciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDevoluciones.Click
        Me.etInicio.Text = "1"

        If Me.vDatos.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione una Factura")
            Exit Sub
        End If
        '
        If Clientes.FacturaDetalleDevolucion(
            vDatos.GetFocusedRowCellValue("FACTURA")).Tables("Facturas_Ventas").Rows.Count = 0 Then
            XtraMsg("La Factura no tiene productos para devolución",
                    MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        'Validar el Estado de la Factura en el Caso de Facturacion Electronica CR.
        Dim Estado As String = vDatos.GetFocusedRowCellValue("ATV")

        'If (Estado <> "aceptado" And Estado <> "n/a") Then
        '    XtraMsg("La factura no ha sido aceptada por Hacienda aún.", MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        ''
        If Estado.Equals(String.Empty) Or
             Estado.Equals("procesando") Or
                Estado.Equals("rechazado") Then
            XtraMsg("La factura debe ser aceptada por Hacienda primero.",
                    MessageBoxIcon.Error)
            Exit Sub
        End If

        'If Estado.Equals("aceptado") Then
        '    XtraMsg("La factura ya ha sido aceptada en Hacienda, sin embargo este módulo esta deshabilitado para este proceso, vaya a módulo de Facturas!", MessageBoxIcon.Warning)
        '    Exit Sub
        'End If

        'Validar Cuando la Factura es de Contado
        If vDatos.GetFocusedRowCellValue("DIAS") = 0 Then
            If Not XtraMsg2("La Factura #: " & vDatos.GetFocusedRowCellValue("FACTURA") & " es de CONTADO." & vbCrLf &
                        "Esta Seguro de Continuar con esta Devolución ?") Then
                Exit Sub
            End If
        End If
        '
        'Validar Cuando la Factura No tiene Saldo
        If Math.Round(CDbl(vDatos.GetFocusedRowCellValue("SALDO")), 2) = 0.0 Then
            If Not XtraMsg2("La Factura #: " & vDatos.GetFocusedRowCellValue("FACTURA") & " No tiene SALDO pendiente." & vbCrLf &
                        "Esta Seguro de Continuar con esta Devolución ?") Then
                Exit Sub
            End If
        End If

        'Validar Cuando la Factura Contiene Abonos
        If Math.Round(CDbl(vDatos.GetFocusedRowCellValue("SALDO")), 2) > 0.0 And
            Math.Round(CDbl(vDatos.GetFocusedRowCellValue("SALDO")), 2) < Math.Round(CDbl(vDatos.GetFocusedRowCellValue("TOTAL")), 2) Then
            If Not XtraMsg2("La Factura #: " & vDatos.GetFocusedRowCellValue("FACTURA") & " Contiene ABONOS." & vbCrLf &
                        "Esta Seguro de Continuar con esta Devolución ?") Then
                Exit Sub
            End If
        End If
        '
        'Devolucion Total
        If rgTipo.EditValue = 1 Then

            With frmDatosDevolucionCR
                .NoFactura = vDatos.GetFocusedRowCellValue("FACTURA")
                .Text = "Devolución Electrónica Factura No. " & vDatos.GetFocusedRowCellValue("FACTURA")
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
                    '
                    Dim DT_Header As DataTable = ObtieneDatos("sp_sel_FACTURAS_VENTAS",
                                                              vDatos.GetFocusedRowCellValue("FACTURA"),
                                                              EmpresaActual)

                    Dim ClienteDetalle As New VB.SysContab.ClientesDetails
                    ClienteDetalle = VB.SysContab.ClientesDB.GetDetails(
                        DT_Header.Rows.Item(0)("CLIENTE"))
                    '
                    If GuardarDevolucion(Plantilla.GetPlantillasDetails(plan).TipoCompr,
                                             DT_Header,
                                             ClienteDetalle,
                                             .Fecha.DateTime.Date,
                                             .cbTipoNota.EditValue,
                                             .cbMovimientos.EditValue,
                                             .txtReferencia.Text,
                                              .Razon.Text) Then
                        .Dispose()
                        Close()
                    End If
                End If

                .Dispose()
            End With

        Else    'Devolucion Parcial
            Dim f As frmDevolucionCliente = frmDevolucionCliente.Instance()
            f.txtFactura.Text = Me.vDatos.GetFocusedRowCellValue("FACTURA")
            f.Bodega = Me.vDatos.GetFocusedRowCellValue("CODIGO_BODEGA")
            f.CuentaCaja = Me.vDatos.GetFocusedRowCellValue("CUENTA CAJA")
            f.Cliente = vDatos.GetFocusedRowCellValue("ClienteID")
            f.TipoPago = Me.vDatos.GetFocusedRowCellValue("FormaPagoID")
            f.dtpFecha.DateTime = Me.vDatos.GetFocusedRowCellValue("FECHA")
            f.txtCliente.Text = Me.vDatos.GetFocusedRowCellValue("NOMBRE")

            f.MdiParent = frmPrincipalRibbon    ' Me.MdiParent
            f.Show()
            f.WindowState = FormWindowState.Maximized

            Close()
        End If

    End Sub

    Function GuardarDevolucion(TipoComp As Integer,
                               DT_Header As DataTable,
                               ClienteDetalle As VB.SysContab.ClientesDetails,
                               FechaDevolucion As Date,
                               TipoNC As Integer,
                               MovimientoID As Integer,
                               Referencia As String,
                               Concepto As String) As Boolean

        Dim CuentaCliente As String = String.Empty,
            CompNo As Integer = 0,
            NoFactura As String = DT_Header.Rows.Item(0)("FACTURA"),
            EsProducto As Boolean = True,
            Repetido As Boolean = False,
            CuentaIVA As String = String.Empty,
            fp As Integer = 0,
            CuentaMtto As String = String.Empty,
            TCambio As Double = GetTasaCambioDia(FechaDevolucion)

        Dim CuentasIventario As New ArrayList,     'CUENTAS CONTABLES D PRODUCTOS
            MontosIventario As New ArrayList,  'MONTO DE PRODUCTOS INVENTARIO        
            CuentasCostos As New ArrayList,     'CUENTAS CONTABLES D PRODUCTOS
            MontosCostos As New ArrayList,  'MONTO DE PRODUCTOS COSTO        
            CuentasIngresos As New ArrayList,   'CUENTAS CONTABLES D PRODUCTOS
            MontosIngresos As New ArrayList,  'MONTO DE PRODUCTOS INVENTARIO VS. COSTO
            ArrayCentros As New ArrayList,   'DISTRIBUION A LOS CENTROS DE COSTOS.
            TotalCaja As Double = 0,
            MontoIVA As Double = 0,
            DT_DETALLE As New DataTable

        Dim PlanillaDetalle As New VB.SysContab.PlantillaDetails()
        Dim Per_Id As Integer = PeriodosDB.Activo(FechaDevolucion)
        Dim Numero As String = DevolucionesClienteDB.Numero()
        Dim Dev As New DevolucionesClienteDB()
        Dim DTDistribucion As DataTable = CargaDistribucion(0, 0, 0)

        If Clientes.FacturaDetalleDevolucion(NoFactura) _
            .Tables("Facturas_Ventas") _
            .Rows.Count = 0 Then EsProducto = False

        'Buscar Plantilla de Mantenimiento de Valor.
        Dim DsPlantillas As DataSet =
            PlantillaDB.GetPlantillasDetails(7, 1).Detalles

        If DsPlantillas.Tables("PlantillasDetalles").Rows.Count <= 1 Then
            XtraMsg("Hace Falta la Plantilla de Mantenimiento de Valor.", MessageBoxIcon.Error)
            Return False
        End If

        'Factura de Contado
        If FormaPago.FormaPagoDias(DT_Header.Rows.Item(0)("TIPO_FACTURA")) = 0 Then   'Contado
            fp = 0
            PlanillaDetalle =
                PlantillaDB.GetPlantillasDetails(4, 1)

            If PlanillaDetalle.PlaID Is DBNull.Value Or
                PlanillaDetalle.PlaID Is Nothing Or
                PlanillaDetalle.PlaID = "" Then

                XtraMsg("No existen plantilla del tipo Factura de Contado", MessageBoxIcon.Warning)
                Return False
            Else
                CuentaCliente = PlanillaDetalle.Detalles.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
                CuentaIVA = PlanillaDetalle.Detalles.Tables("PlantillasDetalles").Rows(3).Item("Cuenta")
                'CuentaIR = PlanillaDetalle.Detalles.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")
                'CuentaIR_Alcaldia = PlanillaDetalle.Detalles.Tables("PlantillasDetalles").Rows(6).Item("Cuenta")
            End If
        Else    'Factura de Credito
            fp = 1
            PlanillaDetalle = VB.SysContab.PlantillaDB.GetPlantillasDetails(4, 2)

            If ClienteDetalle.Cuenta.Trim = "" Then
                XtraMsg("No se puede contabilizar la Devolución, porque no hay cuenta contable para el cliente: " & ClienteDetalle.Nombre, MessageBoxIcon.Error)
                Return False
            End If
            '
            If PlanillaDetalle.PlaID Is DBNull.Value Or
               PlanillaDetalle.PlaID Is Nothing Or
               PlanillaDetalle.PlaID = "" Then

                XtraMsg("No existen plantilla del tipo Factura de Crédito", MessageBoxIcon.Warning)
                Return False
            Else
                CuentaCliente = ClienteDetalle.Cuenta
                CuentaIVA = PlanillaDetalle.Detalles.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")
            End If
        End If
        '
        'Iniciar Transacción...
        '/****************************************************************************
        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction
        '****************************************************************************/

        Try
            '***************  CONTABILIZANDO DEVOLUCION FACTURA
            CompNo = ComprobanteDB.AddComprobante(TipoComp, 1,
           "Nota de Crédito por Devolución #: " & Numero & ", Referencia #: " & Referencia,
           MonedaBase, Per_Id,
           FechaDevolucion, 0, "", False,
           DT_Header.Rows.Item(0)("CLIENTE"), "", 0, "NC" & IIf(NoFactura.Length < 6, NoFactura.PadLeft(6, "0"), NoFactura),
           Rutinas.Fecha, 0,
           IIf(CInt(EmpresaActual) = 20, OrigenComprobantes.NC_ELECTRONICA, OrigenComprobantes.NC_DEVOLUCION))

            Dev.AddItem(Numero,
                        NoFactura,
                        Referencia,
                        CompNo,
                        Per_Id,
                        FechaDevolucion.Month,
                        0,
                        "",
                        Concepto)

            DT_DETALLE = Facturas_VentasDB.ListaDetalle(NoFactura)

            For i As Integer = 0 To DT_DETALLE.Rows.Count - 1

                Dim IVAUnidad As Double = IIf(CDbl(DT_DETALLE.Rows.Item(i)("IVA")) > 0,
                                              CDbl(DT_DETALLE.Rows.Item(i)("CANTIDAD") * DT_DETALLE.Rows.Item(i)("PRECIO")) *
                                              CDbl(DT_DETALLE.Rows.Item(i)("Iva_Porcentaje") / 100.0), 0.00)

                Dim Descuento As Double = DT_DETALLE.Rows.Item(i)("DESCUENTO")

                Dev.AddItemDetalle(
                    Numero,
                    DT_DETALLE.Rows.Item(i)("ITEM"),
                    DT_DETALLE.Rows.Item(i)("TIPO"),
                    DT_DETALLE.Rows.Item(i)("CANTIDAD"),
                    IVAUnidad,
                    DT_DETALLE.Rows.Item(i)("PRECIO"))

                Guardar_Con_Transaccion("sp_DevolucionClienteDetalle_Proyecto",
                                                DT_DETALLE.Rows.Item(i)("NUMERO"),
                                                DT_DETALLE.Rows.Item(i)("CANTIDAD"),
                                                EmpresaActual)

                Guardar_Con_Transaccion("sp_DevolucionClienteDetalle_Devuelto",
                                        DT_DETALLE.Rows.Item(i)("NUMERO"),
                                        EmpresaActual)


                ''***********   CUENTAS DE INGRESOS  **********************
                Repetido = False

                For c As Integer = 0 To CuentasIngresos.Count - 1
                    If DT_DETALLE.Rows.Item(i)("CUENTA_DEVOLUCION") = CuentasIngresos(c) Then
                        MontosIngresos(c) = MontosIngresos(c) + ((DT_DETALLE.Rows.Item(i)("CANTIDAD") * (DT_DETALLE.Rows.Item(i)("PRECIOUSD") * TCambio)) -
                                                                 (DT_DETALLE.Rows.Item(i)("CANTIDAD") * (DT_DETALLE.Rows.Item(i)("PRECIOUSD") * TCambio) * (Descuento / 100.0)))
                        Repetido = True
                    End If
                Next
                '
                If Repetido = False Then
                    CuentasIngresos.Add(DT_DETALLE.Rows.Item(i)("CUENTA_DEVOLUCION"))

                    MontosIngresos.Add((DT_DETALLE.Rows.Item(i)("CANTIDAD") * (DT_DETALLE.Rows.Item(i)("PRECIOUSD") * TCambio)) -
                                                   (DT_DETALLE.Rows.Item(i)("CANTIDAD") * (DT_DETALLE.Rows.Item(i)("PRECIOUSD") * TCambio) * (Descuento / 100.0)))
                End If
                '' ***********   FIN CUENTAS DE INGRESOS  *********************
                '' ***********  DISTRIBUCION CUENTAS DE INGRESOS  *************
                Dim ExisteCentro As Boolean = False
                Dim Existe As Boolean = False
                '
                For c As Integer = 0 To ArrayCentros.Count - 1
                    'Verifica si existe centro
                    If DT_DETALLE.Rows.Item(i)("CentroID") = ArrayCentros(c) Then
                        ExisteCentro = True
                        'Distribucion Ingresos
                        For d As Integer = 0 To DTDistribucion.Rows.Count - 1
                            If DT_DETALLE.Rows.Item(i)("CUENTA_DEVOLUCION") = DTDistribucion.Rows(d).Item("Cuenta") And
                                         DTDistribucion.Rows(d).Item("IdCentroCosto") = ArrayCentros(c) Then

                                Existe = True
                                DTDistribucion.Rows(d).Item("Valor") = Math.Round(((DT_DETALLE.Rows.Item(i)("CANTIDAD") * (DT_DETALLE.Rows.Item(i)("PRECIOUSD") * TCambio)) -
                                                                                 (DT_DETALLE.Rows.Item(i)("CANTIDAD") * (DT_DETALLE.Rows.Item(i)("PRECIO") * TCambio) * (Descuento / 100))) +
                                                                                  DTDistribucion.Rows(d).Item("Valor"), 2)
                            End If
                        Next
                    End If
                Next
                '
                If ExisteCentro = False Then
                    'Verifica si no existe y lo agrega
                    ArrayCentros.Add(DT_DETALLE.Rows.Item(i)("CentroID"))
                End If
                '' ***********  FIN DISTRIBUCION CUENTAS DE INGRESOS  *************
                ''******************** AGREGAR DISTRIBUCION A LA TABLA ***********
                If Existe = False Then
                    Dim row As DataRow = DTDistribucion.NewRow()
                    Dim DT_RG As DataTable = ObtieneDatosTrans("sp_sel_RubroGastos",
                                                                DT_DETALLE.Rows.Item(i)("CUENTA_DEVOLUCION"),
                                                                EmpresaActual)

                    If DT_RG.Rows.Count > 0 Then
                        row("IdRubroGasto") = DT_RG.Rows(0).Item("Codigo")
                        row("IdEmpresa") = EmpresaActual
                        row("NoComp") = CompNo
                        row("Mes") = FechaDevolucion.Month
                        row("Per_Id") = Per_Id
                        row("IdCentroCosto") = DT_DETALLE.Rows.Item(i)("CentroID")   'cbCentroCosto.EditValue  
                        row("Valor") = Math.Round(((DT_DETALLE.Rows.Item(i)("CANTIDAD") * (DT_DETALLE.Rows.Item(i)("PRECIO") * TCambio)) -
                                                            (DT_DETALLE.Rows.Item(i)("CANTIDAD") * (DT_DETALLE.Rows.Item(i)("PRECIO") * TCambio) * (Descuento / 100))), 2)
                        row("Tipo") = "D"
                        row("Cuenta") = DT_DETALLE.Rows.Item(i)("CUENTA_DEVOLUCION")

                        DTDistribucion.Rows.Add(row)
                    End If
                End If
                '**************************************************
                'FIN DE DISTRIBUCION -  CENTRO DE COSTOS
                '**************************************************
                TotalCaja = TotalCaja + ((DT_DETALLE.Rows.Item(i)("CANTIDAD") * DT_DETALLE.Rows.Item(i)("PRECIO")) -
                                                            (DT_DETALLE.Rows.Item(i)("CANTIDAD") * DT_DETALLE.Rows.Item(i)("PRECIO") * (Descuento / 100)))
                '
                'MontoIVA = MontoIVA + (DT_DETALLE.Rows.Item(i)("IVA"))
                MontoIVA = MontoIVA + +(IIf(CDbl(DT_DETALLE.Rows.Item(i)("IVA")) > 0,
                                              CDbl(DT_DETALLE.Rows.Item(i)("CANTIDAD") * DT_DETALLE.Rows.Item(i)("PRECIO")) *
                                              CDbl(DT_DETALLE.Rows.Item(i)("Iva_Porcentaje") / 100.0), 0.00))
            Next
            '
            '*****************  CONTABILIZANDO DEBITOS ***********************
            '*****************************************************************
            'Ingresos 
            For c As Integer = 0 To CuentasIngresos.Count - 1
                ComprobanteDB.AddComprobanteDetalles(CompNo, CuentasIngresos(c), "Ingreso por Devolucion No. " & Numero,
                                          Math.Round(MontosIngresos(c), 2), "0", TipoComp, "D", "0", "0", FechaDevolucion.Date, 1)
            Next
            '
            'IVA    
            If MontoIVA > 0 Then
                ComprobanteDB.AddComprobanteDetalles(CompNo, CuentaIVA, "IVA Por Devolucion No. " & Numero,
                                          Math.Round(MontoIVA, 2), "0", TipoComp, "D", "0", "0", FechaDevolucion.Date, 1)
            End If
            '
            '*****************  CONTABILIZANDO CREDITO ***********************
            '*****************************************************************
            'Cajas
            ComprobanteDB.AddComprobanteDetalles(CompNo, CuentaCliente, IIf(fp = 0, "Fondos por Depositar/Cajas", "Cuentas x Cobrar Clientes"),
                                        Math.Round(TotalCaja + MontoIVA, 2), "0", TipoComp, "C", "0", "0", FechaDevolucion.Date, 1)
            '
            '----------------------
            'Guarda la Distribucion
            '----------------------
            GuardaDistribucionTrans(
                DTDistribucion,
                FechaDevolucion.Date,
                CompNo)

            Rutinas.okTransaccion()

            'GuardarNotaCredito("NC" + NoFactura.PadLeft(6, "0"c),
            '                   ClienteDetalle,
            '                   FechaDevolucion,
            '                   TipoNC,
            '                   MovimientoID,
            '                   TipoComp,
            '                   TotalCaja,
            '                   MontoIVA,
            '                   "Nota de Crédito por Devolución #: " & Numero & ", Referencia #: NC" & NoFactura.PadLeft(6, "0"c))

            'Return True
        Catch ex As Exception
            XtraMsg(ex.Message & " Contabilizar.",
                    MessageBoxIcon.Error)
            Rutinas.ErrorTransaccion()
            Return False
        End Try
        '
        Try
            '***************** GUARDAR NOTA DE CREDITO ***********************
            Dim db_Notas As New db_MaestroNotasCD
            Dim NoNota As String = "NC" + IIf(NoFactura.Length < 6, NoFactura.PadLeft(6, "0"), NoFactura)

            Dim IdNota As Integer = db_Notas.Guardar(
                NoNota,
                ClienteDetalle.Codigo,
                FechaDevolucion.Date,
                TipoComp,
                TotalCaja + MontoIVA,
                "Nota de Crédito por Devolución #: " & Numero & ", Referencia #: " & Referencia,
                1,
                MonedaBase,
                CompNo,
                Per_Id,
                FechaDevolucion.Month,
                FechaDevolucion.Date,
                0,
                TipoNC,
                "",
                Numero)

            If IdNota > 0 Then
                'Detalle de la N/C
                db_Notas.GuardarDetalle(
                    IdNota,
                    NoFactura,
                    TotalCaja + MontoIVA,
                    FechaDevolucion.Date,
                    0.00)
            End If
            ''*************** FIN REGISTRO NOTA DE CREDITO ****************
            '----------------------------------------
            'Guarda Movimiento de Inventario
            '----------------------------------------
            If EsProducto Then
                'Validar si hay registros para procesar
                'Dim dr() As DataRow = DT_DETALLE.Select("EsProyecto = 0")
                Dim dr() As DataRow = DT_DETALLE.Select("TIPO = 'P'")
                If dr.Length > 0 Then

                    Dim _DETALLE As DataTable = DT_DETALLE.Select("TIPO = 'P'").CopyToDataTable

                    'Productos sin relacion con los proyectos
                    If _DETALLE.Select("IdProyecto = 0").Length > 0 Then

                        Dim _SIN_PROY As DataTable =
                            _DETALLE.Select("IdProyecto = 0") _
                            .CopyToDataTable

                        If _SIN_PROY.Rows.Count > 0 Then

                            Dim Requisa As Integer = db_requisas.Add(
                                EmpresaActual,
                                "E",
                                FechaDevolucion.Date,
                                _SIN_PROY.Rows.Item(0)("Bodega"),
                                Login, Numero,
                                MovimientoID,
                                Referencia,
                                "Nota de Crédito por Devolución #: " & Numero & ", Referencia #: NC" & Referencia,
                                "", "", "", "", "", "", ClienteDetalle.Codigo, "", 0, 0, 0, Numero)

                            For i As Integer = 0 To _SIN_PROY.Rows.Count - 1
                                'If _SIN_PROY.Rows.Item(i)("TIPO") = "P" Then

                                db_requisas.AddDetalle(
                                        EmpresaActual,
                                        Requisa,
                                        _SIN_PROY.Rows.Item(i)("ITEM"),
                                        "P",
                                        _SIN_PROY.Rows.Item(i)("CANTIDAD"),
                                        _SIN_PROY.Rows.Item(i)("COSTO"),
                                        "NC", "", "", "")

                                'End If
                            Next
                        End If

                    End If
                    '
                    'Productos con Relacion a los Proyectos.
                    If _DETALLE.Select("IdProyecto > 0") _
                        .Length > 0 Then

                        Dim _CON_PROY As DataTable = _DETALLE _
                            .Select("IdProyecto > 0") _
                            .CopyToDataTable

                        If _CON_PROY.Rows.Count > 0 Then

                            Dim req = From row In _CON_PROY.AsEnumerable()
                                      Select row.Field(Of Object)("IdProyecto") Distinct

                            For Each s As Object In req
                                If Not s Is Nothing Then

                                    Dim _DT As DataTable =
                                        _CON_PROY _
                                        .Select("IdProyecto = " & s) _
                                        .CopyToDataTable

                                    Dim Requisa As Integer = db_requisas.Add(
                                        EmpresaActual,
                                        "E",
                                        FechaDevolucion.Date,
                                        _DT.Rows.Item(0)("Bodega"),
                                        Login,
                                        Numero,
                                        MovimientoID,
                                        Referencia,
                                        "Nota de Crédito por Devolución #: " & Numero & ", Referencia #: NC" & Referencia,
                                        "", "", "", "", "", "", ClienteDetalle.Codigo, "", s, 0, 0, Numero)

                                    For i As Integer = 0 To _DT.Rows.Count - 1
                                        'If _DT.Rows.Item(i)("TIPO") = "P" Then

                                        db_requisas.AddDetalle(
                                                EmpresaActual,
                                                Requisa,
                                                _DT.Rows.Item(i)("ITEM"),
                                                "P",
                                                _DT.Rows.Item(i)("CANTIDAD"),
                                                _DT.Rows.Item(i)("COSTO"),
                                                "NC", "", "", "")
                                        ' End If
                                    Next
                                End If
                            Next
                        End If
                    End If
                End If
            End If
            'Verificar si el Comprobante tiene diferencias, por Deslizamiento de la moneda.



            'XtraMsg("Devolución Electrónica realizada Éxitosamente !!!", MessageBoxIcon.Information)
            'Return True

            XtraMsg("Devolución realizada Exitosamente !!!",
                    MessageBoxIcon.Information)

            'XtraMsg("Devolución Electrónica realizada Éxitosamente !!!",
            '        MessageBoxIcon.Information)

            ''Imprimir el Comprobante Contable de la Devolución
            ComprobanteDB.ImprimirComprobante(
                CompNo,
                PeriodosDB.Activo(FechaDevolucion.Date),
                FechaDevolucion.Date)

            'Actualizar Lista de Devoluciones
            Dim f As frmDevolucionesClienteList = frmDevolucionesClienteList.Instance()
            If f.Created Then f.Cargar()

            Return True
        Catch ex As Exception
            XtraMsg(ex.Message & ". Guardar N/C",
                    MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    'Sub GuardarNotaCredito(NoNota As String,
    '                       ClienteDetalle As VB.SysContab.ClientesDetails,
    '                       FechaDevolucion As Date,
    '                       TipoNC As Integer,
    '                       MovimientoID As Integer,
    '                       TipoCompr As Integer,
    '                       TotalCaja As Double,
    '                       MontoIVA As Double,
    '                       Concepto As String)





    'End Sub


    'Private Sub txtFactura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyData = Keys.Enter Then
    '        Me.cmdBuscar.Focus()
    '    End If
    'End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Buscar()

        'If etInicio.Text = "1" Then
        '    Exit Sub
        'End If
        'Try
        '    ds = Clientes.DevolucionesFacturas(Me.txtFactura.Text, cbClientes.Text, 0, 0, 0, Fecha1, Fecha2, BuscarPor)
        '    dgFacturasClientes.DataSource = ds.Tables("Facturas_Ventas").DefaultView

        'Catch ex As Exception
        '    MsgBox(ex.Message & " cbClientes_SelectedValueChanged")
        'End Try
    End Sub

    Private Sub cmdEntrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEntrada.Click
        'Me.etInicio.Text = "1"
        'Dim f As frmDevolucionesClienteList = f.Instance
        'f.etInicio.Text = "1"
        'f.MdiParent = Me.MdiParent
        'f.WindowState = FormWindowState.Maximized
        'f.Show()
        'f.etInicio.Text = "0"
    End Sub

    Private Sub Ayuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/ClientesDevoluciones.chm")
    End Sub

    Private Sub Desde_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Desde.EditValueChanged
        'If etInicio.Text = "1" Then
        '    Exit Sub
        'End If

        'Try
        '    If checkBoxFecha.Checked = True Then
        '        Fecha1 = Me.dtpFechaDesde.Value.Date
        '        Fecha2 = Me.dtpFechaHasta.Value.Date
        '        ds = Clientes.DevolucionesFacturas(cbClientes.Text, 0, 0, 0, 0, Fecha1, Fecha2, BuscarPor)
        '        dgFacturasClientes.DataSource = ds.Tables("Facturas_Ventas").DefaultView
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message & " dtpFechaDesde_ValueChanged1")
        'End Try
    End Sub

    Private Sub Hasta_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hasta.EditValueChanged
        'If etInicio.Text = "1" Then
        '    Exit Sub
        'End If

        'Try
        '    If checkBoxFecha.Checked = True Then
        '        Me.dtpFechaDesde.MaxDate = Me.dtpFechaHasta.Value
        '        Fecha1 = Me.dtpFechaDesde.Value.Date
        '        Fecha2 = Me.dtpFechaHasta.Value.Date
        '        ds = Clientes.DevolucionesFacturas(cbClientes.Text, 0, 0, 0, 0, Fecha1, Fecha2, BuscarPor)
        '        dgFacturasClientes.DataSource = ds.Tables("Facturas_Ventas").DefaultView
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message & " dtpFechaDesde_ValueChanged2")
        'End Try
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click

    End Sub

    Private Sub vDatos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vDatos.DoubleClick
        If Me.vDatos.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione una Factura")
            Exit Sub
        End If

        Dim f As DataGridTextBoxCombo.frmFacturacionClienteVer = DataGridTextBoxCombo.frmFacturacionClienteVer.Instance()

        Registro = Me.vDatos.GetFocusedRowCellValue("FACTURA")
        'Registro = dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 0)

        'If Registro = "Vacio" Then
        '    MsgBox("Seleccione la Factura", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub vDatos_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles vDatos.RowCellStyle
        If e.Column.FieldName = "ATV" Then
            e.Appearance.Font = New Font("Tahoma", 8.25, FontStyle.Bold)
            e.Appearance.BackColor = Color.LightGray
            e.Appearance.BackColor2 = Color.Gray
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            If vDatos.GetRowCellValue(e.RowHandle, "ATV") = "aceptado" Then
                e.Appearance.ForeColor = Color.DarkGreen
            ElseIf vDatos.GetRowCellValue(e.RowHandle, "ATV") = "rechazado" Then
                e.Appearance.ForeColor = Color.DarkRed
            ElseIf vDatos.GetRowCellValue(e.RowHandle, "ATV") = "procesando" Then
                e.Appearance.ForeColor = Color.Navy
            ElseIf vDatos.GetRowCellValue(e.RowHandle, "ATV") = "recibido" Then
                e.Appearance.ForeColor = Color.Navy
            Else
                e.Appearance.ForeColor = Color.White
            End If
        End If
    End Sub
End Class
