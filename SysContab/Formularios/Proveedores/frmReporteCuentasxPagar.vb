Imports DevExpress.XtraReports.UI

Public Class frmReporteCuentasxPagar
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmReporteCuentasxPagar = Nothing

    Public Shared Function Instance() As frmReporteCuentasxPagar
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmReporteCuentasxPagar()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Dim Mes As New VB.SysContab.MesesDB()
    Dim Proveedores As New VB.SysContab.ProveedoresDB()
    Dim Articulo As New VB.SysContab.ArticulosDB()
    Dim Puntos_Venta As New VB.SysContab.PuntosVentasDB()
    Dim Servicios As New VB.SysContab.ServiciosDB()
    Dim Vendedores As New VB.SysContab.VendedoresDB()
    Dim Rutinas As New VB.SysContab.Rutinas()
    Dim FormaPago As New VB.SysContab.Forma_PagoDB()
    Friend WithEvents cbRubro As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents rgTipo As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents rgTipoR As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents DTPickerHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DTPickerDe As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DTPicker As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cbMonedas As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbMes As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkResumido As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cbFormaPago As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cbProveedores As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dgCodigo As System.Windows.Forms.DataGrid

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
    Friend WithEvents Print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tbValorTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rbRango As System.Windows.Forms.RadioButton
    Friend WithEvents rbFecha1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbMes As System.Windows.Forms.RadioButton
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporteCuentasxPagar))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cbProveedores = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbFormaPago = New DevExpress.XtraEditors.LookUpEdit()
        Me.rbRango = New System.Windows.Forms.RadioButton()
        Me.rbFecha1 = New System.Windows.Forms.RadioButton()
        Me.DTPickerHasta = New DevExpress.XtraEditors.DateEdit()
        Me.cbMes = New DevExpress.XtraEditors.LookUpEdit()
        Me.rbMes = New System.Windows.Forms.RadioButton()
        Me.DTPickerDe = New DevExpress.XtraEditors.DateEdit()
        Me.DTPicker = New DevExpress.XtraEditors.DateEdit()
        Me.rgTipoR = New DevExpress.XtraEditors.RadioGroup()
        Me.chkResumido = New DevExpress.XtraEditors.CheckEdit()
        Me.rgTipo = New DevExpress.XtraEditors.RadioGroup()
        Me.cbMonedas = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbRubro = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.Cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.Print = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.tbValorTotal = New System.Windows.Forms.TextBox()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cbProveedores.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbFormaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTPickerHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTPickerHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTPickerDe.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTPickerDe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTPicker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTPicker.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgTipoR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkResumido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMonedas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbRubro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cbProveedores)
        Me.LayoutControl1.Controls.Add(Me.cbFormaPago)
        Me.LayoutControl1.Controls.Add(Me.rbRango)
        Me.LayoutControl1.Controls.Add(Me.rbFecha1)
        Me.LayoutControl1.Controls.Add(Me.DTPickerHasta)
        Me.LayoutControl1.Controls.Add(Me.cbMes)
        Me.LayoutControl1.Controls.Add(Me.rbMes)
        Me.LayoutControl1.Controls.Add(Me.DTPickerDe)
        Me.LayoutControl1.Controls.Add(Me.DTPicker)
        Me.LayoutControl1.Controls.Add(Me.rgTipoR)
        Me.LayoutControl1.Controls.Add(Me.chkResumido)
        Me.LayoutControl1.Controls.Add(Me.rgTipo)
        Me.LayoutControl1.Controls.Add(Me.cbMonedas)
        Me.LayoutControl1.Controls.Add(Me.cbRubro)
        Me.LayoutControl1.Controls.Add(Me.Label4)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1153, 185, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(619, 375)
        Me.LayoutControl1.TabIndex = 116
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cbProveedores
        '
        Me.cbProveedores.Location = New System.Drawing.Point(88, 69)
        Me.cbProveedores.Name = "cbProveedores"
        Me.cbProveedores.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cbProveedores.Properties.Appearance.Options.UseFont = True
        Me.cbProveedores.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProveedores.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.cbProveedores.Size = New System.Drawing.Size(490, 20)
        Me.cbProveedores.StyleController = Me.LayoutControl1
        Me.cbProveedores.TabIndex = 119
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'cbFormaPago
        '
        Me.cbFormaPago.Location = New System.Drawing.Point(88, 93)
        Me.cbFormaPago.Name = "cbFormaPago"
        Me.cbFormaPago.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cbFormaPago.Properties.Appearance.Options.UseFont = True
        Me.cbFormaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbFormaPago.Size = New System.Drawing.Size(233, 20)
        Me.cbFormaPago.StyleController = Me.LayoutControl1
        Me.cbFormaPago.TabIndex = 118
        '
        'rbRango
        '
        Me.rbRango.BackColor = System.Drawing.Color.Transparent
        Me.rbRango.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRango.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbRango.Location = New System.Drawing.Point(24, 301)
        Me.rbRango.Name = "rbRango"
        Me.rbRango.Size = New System.Drawing.Size(108, 25)
        Me.rbRango.TabIndex = 3
        Me.rbRango.Text = "RANGO"
        Me.rbRango.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbRango.UseVisualStyleBackColor = False
        '
        'rbFecha1
        '
        Me.rbFecha1.BackColor = System.Drawing.Color.Transparent
        Me.rbFecha1.Checked = True
        Me.rbFecha1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFecha1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbFecha1.Location = New System.Drawing.Point(24, 272)
        Me.rbFecha1.Name = "rbFecha1"
        Me.rbFecha1.Size = New System.Drawing.Size(108, 25)
        Me.rbFecha1.TabIndex = 2
        Me.rbFecha1.TabStop = True
        Me.rbFecha1.Text = "Fecha"
        Me.rbFecha1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbFecha1.UseVisualStyleBackColor = False
        '
        'DTPickerHasta
        '
        Me.DTPickerHasta.EditValue = Nothing
        Me.DTPickerHasta.Location = New System.Drawing.Point(200, 330)
        Me.DTPickerHasta.Name = "DTPickerHasta"
        Me.DTPickerHasta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPickerHasta.Properties.Appearance.Options.UseFont = True
        Me.DTPickerHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DTPickerHasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DTPickerHasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.DTPickerHasta.Size = New System.Drawing.Size(140, 20)
        Me.DTPickerHasta.StyleController = Me.LayoutControl1
        Me.DTPickerHasta.TabIndex = 3
        '
        'cbMes
        '
        Me.cbMes.Location = New System.Drawing.Point(136, 243)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMes.Properties.Appearance.Options.UseFont = True
        Me.cbMes.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cbMes.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cbMes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMes.Size = New System.Drawing.Size(204, 20)
        Me.cbMes.StyleController = Me.LayoutControl1
        Me.cbMes.TabIndex = 117
        '
        'rbMes
        '
        Me.rbMes.BackColor = System.Drawing.Color.Transparent
        Me.rbMes.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMes.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbMes.Location = New System.Drawing.Point(24, 243)
        Me.rbMes.Name = "rbMes"
        Me.rbMes.Size = New System.Drawing.Size(108, 25)
        Me.rbMes.TabIndex = 0
        Me.rbMes.Text = "Mes"
        Me.rbMes.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbMes.UseVisualStyleBackColor = False
        '
        'DTPickerDe
        '
        Me.DTPickerDe.EditValue = Nothing
        Me.DTPickerDe.Location = New System.Drawing.Point(200, 301)
        Me.DTPickerDe.Name = "DTPickerDe"
        Me.DTPickerDe.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPickerDe.Properties.Appearance.Options.UseFont = True
        Me.DTPickerDe.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DTPickerDe.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DTPickerDe.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.DTPickerDe.Size = New System.Drawing.Size(140, 20)
        Me.DTPickerDe.StyleController = Me.LayoutControl1
        Me.DTPickerDe.TabIndex = 2
        '
        'DTPicker
        '
        Me.DTPicker.EditValue = Nothing
        Me.DTPicker.Location = New System.Drawing.Point(136, 272)
        Me.DTPicker.Name = "DTPicker"
        Me.DTPicker.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPicker.Properties.Appearance.Options.UseFont = True
        Me.DTPicker.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DTPicker.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DTPicker.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.DTPicker.Size = New System.Drawing.Size(204, 20)
        Me.DTPicker.StyleController = Me.LayoutControl1
        Me.DTPicker.TabIndex = 1
        '
        'rgTipoR
        '
        Me.rgTipoR.EditValue = 2
        Me.rgTipoR.Location = New System.Drawing.Point(157, 169)
        Me.rgTipoR.Name = "rgTipoR"
        Me.rgTipoR.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgTipoR.Properties.Appearance.Options.UseFont = True
        Me.rgTipoR.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Reporte Tradicional"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Consolidado de Saldos")})
        Me.rgTipoR.Size = New System.Drawing.Size(421, 25)
        Me.rgTipoR.StyleController = Me.LayoutControl1
        Me.rgTipoR.TabIndex = 1
        '
        'chkResumido
        '
        Me.chkResumido.Location = New System.Drawing.Point(24, 169)
        Me.chkResumido.Name = "chkResumido"
        Me.chkResumido.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkResumido.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.chkResumido.Properties.Appearance.Options.UseFont = True
        Me.chkResumido.Properties.Appearance.Options.UseForeColor = True
        Me.chkResumido.Properties.Caption = "Resumido"
        Me.chkResumido.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkResumido.Size = New System.Drawing.Size(129, 22)
        Me.chkResumido.StyleController = Me.LayoutControl1
        Me.chkResumido.TabIndex = 115
        '
        'rgTipo
        '
        Me.rgTipo.EditValue = 1
        Me.rgTipo.Location = New System.Drawing.Point(157, 168)
        Me.rgTipo.Name = "rgTipo"
        Me.rgTipo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgTipo.Properties.Appearance.Options.UseFont = True
        Me.rgTipo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Contable"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Auxiliar")})
        Me.rgTipo.Size = New System.Drawing.Size(543, 25)
        Me.rgTipo.StyleController = Me.LayoutControl1
        Me.rgTipo.TabIndex = 5
        '
        'cbMonedas
        '
        Me.cbMonedas.Location = New System.Drawing.Point(88, 143)
        Me.cbMonedas.Name = "cbMonedas"
        Me.cbMonedas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMonedas.Properties.Appearance.Options.UseFont = True
        Me.cbMonedas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMonedas.Size = New System.Drawing.Size(490, 22)
        Me.cbMonedas.StyleController = Me.LayoutControl1
        Me.cbMonedas.TabIndex = 3
        '
        'cbRubro
        '
        Me.cbRubro.Location = New System.Drawing.Point(88, 117)
        Me.cbRubro.Name = "cbRubro"
        Me.cbRubro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRubro.Properties.Appearance.Options.UseFont = True
        Me.cbRubro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbRubro.Size = New System.Drawing.Size(490, 22)
        Me.cbRubro.StyleController = Me.LayoutControl1
        Me.cbRubro.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(12, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(578, 20)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "REPORTE DE CUENTAS POR PAGAR"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.rgTipo
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(133, 100)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(0, 29)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(54, 29)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(547, 29)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlGroup2, Me.LayoutControlGroup4})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(602, 376)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Label4
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(24, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(582, 24)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup2.AppearanceGroup.ForeColor = System.Drawing.Color.Maroon
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseTextOptions = True
        Me.LayoutControlGroup2.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlGroup2.CustomizationFormText = "CRITERIOS DE SELECCION"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.EmptySpaceItem2, Me.LayoutControlItem2, Me.LayoutControlItem6, Me.LayoutControlItem9, Me.LayoutControlItem5, Me.LayoutControlItem4})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(582, 174)
        Me.LayoutControlGroup2.Text = "CRITERIOS DE SELECCION"
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.rgTipoR
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(133, 100)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(0, 29)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(54, 29)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(425, 29)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(301, 24)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(257, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cbFormaPago
        Me.LayoutControlItem2.CustomizationFormText = "Vencimiento:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(301, 24)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(301, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(301, 24)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Vencimiento:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cbMonedas
        Me.LayoutControlItem6.CustomizationFormText = "Moneda:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 74)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(558, 26)
        Me.LayoutControlItem6.Text = "Moneda:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.chkResumido
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 100)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(133, 29)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(133, 29)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(133, 29)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cbRubro
        Me.LayoutControlItem5.CustomizationFormText = "Rubro:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(558, 26)
        Me.LayoutControlItem5.Text = "Rubro:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cbProveedores
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(558, 24)
        Me.LayoutControlItem4.Text = "Proveedor:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup4.AppearanceGroup.ForeColor = System.Drawing.Color.Maroon
        Me.LayoutControlGroup4.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup4.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup4.AppearanceGroup.Options.UseTextOptions = True
        Me.LayoutControlGroup4.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlGroup4.CustomizationFormText = "TIEMPOS"
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem15, Me.LayoutControlItem14, Me.LayoutControlItem16, Me.EmptySpaceItem1, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.EmptySpaceItem3})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 198)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(582, 158)
        Me.LayoutControlGroup4.Text = "TIEMPOS"
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.rbFecha1
        Me.LayoutControlItem15.CustomizationFormText = "LayoutControlItem15"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 29)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(112, 29)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(112, 29)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(112, 29)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.rbMes
        Me.LayoutControlItem14.CustomizationFormText = "LayoutControlItem14"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(112, 29)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(112, 29)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(112, 29)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.rbRango
        Me.LayoutControlItem16.CustomizationFormText = "LayoutControlItem16"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 58)
        Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(112, 29)
        Me.LayoutControlItem16.MinSize = New System.Drawing.Size(112, 29)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(112, 29)
        Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 87)
        Me.EmptySpaceItem1.MaxSize = New System.Drawing.Size(112, 26)
        Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(112, 26)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(112, 26)
        Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cbMes
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(112, 0)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(208, 29)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(208, 29)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(208, 29)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.DTPicker
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(112, 29)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(208, 29)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(208, 29)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(208, 29)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.DTPickerDe
        Me.LayoutControlItem12.CustomizationFormText = "Desde:"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(112, 58)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(208, 29)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(208, 29)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(208, 29)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.Text = "Desde:"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.DTPickerHasta
        Me.LayoutControlItem13.CustomizationFormText = "Hasta:"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(112, 87)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(208, 26)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(208, 26)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(208, 26)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.Text = "Hasta:"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(61, 13)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(320, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(238, 113)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'cmdAyuda
        '
        Me.cmdAyuda.ImageOptions.Image = Global.SysContab.My.Resources.Resources.RibbonPrintPreview_ParametersLarge
        Me.cmdAyuda.Location = New System.Drawing.Point(12, 54)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(168, 38)
        Me.cmdAyuda.StyleController = Me.LayoutControl2
        Me.cmdAyuda.TabIndex = 1
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.Cancel)
        Me.LayoutControl2.Controls.Add(Me.cmdAyuda)
        Me.LayoutControl2.Controls.Add(Me.Print)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem18})
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup3
        Me.LayoutControl2.Size = New System.Drawing.Size(143, 346)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'Cancel
        '
        Me.Cancel.ImageOptions.Image = CType(resources.GetObject("Cancel.ImageOptions.Image"), System.Drawing.Image)
        Me.Cancel.Location = New System.Drawing.Point(12, 52)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(119, 36)
        Me.Cancel.StyleController = Me.LayoutControl2
        Me.Cancel.TabIndex = 2
        Me.Cancel.Text = "&Salir"
        '
        'Print
        '
        Me.Print.ImageOptions.Image = CType(resources.GetObject("Print.ImageOptions.Image"), System.Drawing.Image)
        Me.Print.Location = New System.Drawing.Point(12, 12)
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(119, 36)
        Me.Print.StyleController = Me.LayoutControl2
        Me.Print.TabIndex = 0
        Me.Print.Text = "&Generar"
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.cmdAyuda
        Me.LayoutControlItem18.CustomizationFormText = "LayoutControlItem18"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(172, 42)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "LayoutControlGroup3"
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem17, Me.LayoutControlItem19})
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(143, 346)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.Print
        Me.LayoutControlItem17.CustomizationFormText = "LayoutControlItem17"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(123, 40)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.Cancel
        Me.LayoutControlItem19.CustomizationFormText = "LayoutControlItem19"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(123, 286)
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'tbValorTotal
        '
        Me.tbValorTotal.BackColor = System.Drawing.SystemColors.HotTrack
        Me.tbValorTotal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbValorTotal.ForeColor = System.Drawing.Color.Chartreuse
        Me.tbValorTotal.Location = New System.Drawing.Point(152, 24)
        Me.tbValorTotal.Name = "tbValorTotal"
        Me.tbValorTotal.Size = New System.Drawing.Size(104, 20)
        Me.tbValorTotal.TabIndex = 8
        Me.tbValorTotal.Text = "33333333333333"
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
        Me.DockPanel1.ID = New System.Guid("df796dd5-b6f3-4d50-8570-2689d2cef60b")
        Me.DockPanel1.Location = New System.Drawing.Point(619, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(150, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(150, 375)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(143, 346)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'frmReporteCuentasxPagar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(769, 375)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.IconOptions.Icon = CType(resources.GetObject("frmReporteCuentasxPagar.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "frmReporteCuentasxPagar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cbProveedores.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbFormaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTPickerHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTPickerHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTPickerDe.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTPickerDe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTPicker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTPicker.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgTipoR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkResumido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMonedas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbRubro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub frmReportesFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Proveedor As New VB.SysContab.ProveedoresDB()
        Dim Linea As New VB.SysContab.Grupos_InventarioDB()


        'cbOrdenRed.DataSource = Puntos_Venta.Getlist().Tables("PUNTOS_VENTA")
        'cbOrdenRed.ValueMember = "Codigo"
        'cbOrdenRed.DisplayMember = "Nombre"
        'cbOrdenRed.SelectedValue = -1

        'cbMes.DataSource = VB.SysContab.MesesDB.MesexPeriodo.Tables("Meses")
        'cbMes.ValueMember = "Mes"
        'cbMes.DisplayMember = "MesAnno"
        'cbMes.SelectedValue = 0

        'cbClientes.DataSource = Proveedores.ProveedoresListCombo.Tables("Proveedores")
        'cbClientes.ValueMember = "CODIGO"
        'cbClientes.DisplayMember = "NOMBRE"
        'cbClientes.SelectedValue = 0

        GetMesesList(cbMes)
        'GetCatalogoProveedores(cbProveedores, iVista, 1)

        SearchLookUp(
            cbProveedores,
            ObtieneDatos("sp_sel_Proveedores", EmpresaActual, 1),
            "NOMBRE",
            "CODIGO")
        cbProveedores.EditValue = 0


        'cbVendedores.DataSource = FormaPago.FormaPagoListAll().Tables("Forma_Pago")
        'cbVendedores.ValueMember = "Codigo"
        'cbVendedores.DisplayMember = "Nombre"
        'cbVendedores.SelectedValue = 0

        GetFormaPagoListAll(cbFormaPago)

        'cbGrupos.DataSource = Linea.GetListBuscarCombo("%", "P").Tables("GRUPOS_INVENTARIO")
        'cbGrupos.ValueMember = "CODIGO_GRUPO"
        'cbGrupos.DisplayMember = "NOMBRE"

        'cbSubGrupos.DataSource = Linea.GetListBuscarCombo("%", "P").Tables("GRUPOS_INVENTARIO")
        'cbSubGrupos.ValueMember = "CODIGO_GRUPO"
        'cbSubGrupos.DisplayMember = "NOMBRE"
        ' Rutinas.ComboAutoComplete(Me.cbClientes)

        Me.cbRubro.Properties.DataSource = ObtieneDatos("sp_GetTiposProveedores " & EmpresaActual)
        Me.cbRubro.Properties.ValueMember = "CUENTA"
        Me.cbRubro.Properties.DisplayMember = "Display"
        Me.cbRubro.Properties.PopulateColumns()
        Me.cbRubro.Properties.Columns("Display").Visible = False
        Me.cbRubro.ItemIndex = 0
        '
        GetMonedas(Me.cbMonedas)
        Me.cbMonedas.EditValue = MonedaBase
        '

        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date

        Me.DTPicker.DateTime = f.Date
        Me.DTPickerDe.DateTime = New DateTime(f.Year, f.Month, 1)
        Me.DTPickerHasta.DateTime = f.Date
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub rbTodas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'cbMes.SelectedValue = 0
        'cbMes.Enabled = False
        'DTPicker.Enabled = False
        'DTPickerDe.Enabled = False
        'DTPickerHasta.Enabled = False
    End Sub

    Private Sub rbMes_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMes.CheckedChanged
        cbMes.Enabled = True
        DTPicker.Enabled = False
        DTPickerDe.Enabled = False
        DTPickerHasta.Enabled = False
    End Sub

    Private Sub rbFecha1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFecha1.CheckedChanged
        ' cbMes.SelectedValue = 0
        cbMes.Enabled = False
        DTPicker.Enabled = True
        DTPickerDe.Enabled = False
        DTPickerHasta.Enabled = False
        ' Me.DTPickerDe.DateTime = Me.DTPicker.DateTime
        ' Me.DTPickerHasta.DateTime = Me.DTPicker.DateTime
    End Sub

    Private Sub rbRango_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRango.CheckedChanged
        'cbMes.SelectedValue = 0
        cbMes.Enabled = False
        DTPicker.Enabled = False
        DTPickerDe.Enabled = True
        DTPickerHasta.Enabled = True
    End Sub

    Private Sub Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Print.Click

        Dim Mes As String
        Dim Fecha As String
        Dim FechaDesde As String
        Dim FechaHasta As String
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date

        If rgTipoR.EditValue = 1 Then
            If Me.rgTipo.EditValue = 2 Then
                If Not Me.rbRango.Checked Then
                    XtraMsg("Seleccione Rango de Fechas a ser Evaluadas", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If

            If rbMes.Checked = True Then
                Mes = cbMes.EditValue
                Fecha = ""

                FechaDesde = New DateTime(f.Year, cbMes.EditValue, 1)
                FechaHasta = f.Date

                'FechaDesde = New Date(Year(Me.cbMes.DataSource.rows(Me.cbMes.SelectedIndex)("Fecha")), _
                '    Month(Me.cbMes.DataSource.rows(Me.cbMes.SelectedIndex)("Fecha")), 1)
                'FechaHasta = New Date(Year(Me.cbMes.DataSource.rows(Me.cbMes.SelectedIndex)("Fecha")), _
                '    Month(Me.cbMes.DataSource.rows(Me.cbMes.SelectedIndex)("Fecha")), Meses(cbMes.SelectedValue - 1))
            End If

            If rbFecha1.Checked = True Then
                Mes = 0
                Fecha = DTPicker.DateTime.Date
                FechaDesde = DTPicker.DateTime.Date
                FechaHasta = DTPicker.DateTime.Date
            End If

            If rbRango.Checked = True Then
                Mes = 0
                Fecha = ""
                ' FechaDesde = DTPickerDe.DateTime.Date
                ' FechaHasta = DTPickerHasta.DateTime.Date
            End If

            ShowSplash("Generando Reporte...")

            Dim fReportes As New frmReportes
            Dim Clientes As New VB.SysContab.ClientesDB

            If Me.rgTipo.EditValue = 2 Then 'Auxiliar
                Clientes.EstadoCuentaProveedorReporte(FechaDesde, FechaHasta,
                                                      IIf(Me.cbRubro.ItemIndex = 0, "%", Me.cbRubro.EditValue), _
                                                      cbProveedores.EditValue).WriteXml(Application.StartupPath & "\xml\RptCuentasPorPagar.xml", XmlWriteMode.WriteSchema)
            Else
                Clientes.EstadoCuentaProveedorReporte(cbProveedores.EditValue, Mes, _
                                cbFormaPago.EditValue, Fecha, _
                                DTPickerDe.DateTime.Date, DTPickerHasta.DateTime.Date, _
                                IIf(Me.cbRubro.ItemIndex = 0, "%", Me.cbRubro.EditValue)).WriteXml(Application.StartupPath & "\xml\RptCuentasPorPagar.xml", XmlWriteMode.WriteSchema)
            End If

            If Me.chkResumido.Checked = False Then
                'Dim rFacturas As New RptCuentasPorPagar

                Dim rFacturas As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                rFacturas.Load(Application.StartupPath & "\Reportes\RptCuentasPorPagar.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

                rFacturas.Database.Tables(0).Location = Application.StartupPath & "\xml\RptCuentasPorPagar.xml"
                fReportes.crvReportes.ReportSource = rFacturas
            Else
                'Dim rFacturas As New RptCuentasPorPagarResumido
                Dim rFacturas As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                rFacturas.Load(Application.StartupPath & "\Reportes\RptCuentasPorPagarResumido.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

                rFacturas.Database.Tables(0).Location = Application.StartupPath & "\xml\RptCuentasPorPagar.xml"
                fReportes.crvReportes.ReportSource = rFacturas
            End If

            'If rbScreen.Checked = True Then
            '    fReportes.Show()
            'ElseIf rbPrint.Checked = True Then
            '    fReportes.crvReportes.PrintReport()
            'Else
            '    fReportes.crvReportes.ExportReport()
            'End If

            fReportes.Show()
            fReportes.WindowState = FormWindowState.Maximized
            HideSplash()

        ElseIf rgTipoR.EditValue = 2 Then

            If Not rbFecha1.Checked Then
                XtraMsg("Seleccione Fecha de Corte", MessageBoxIcon.Warning)
                rbFecha1.Checked = True
                DTPicker.Focus()
                Exit Sub
            End If

            'Dim datos As New ArrayList, variables As New ArrayList

            'variables.Add("FechaDesde")
            'variables.Add("Fechahasta")
            'variables.Add("Cuenta")
            'variables.Add("Empresa")
            'variables.Add("Moneda")
            'variables.Add("Proveedor")

            'datos.Add(Me.DTPicker.DateTime.Date)
            'datos.Add(Me.DTPicker.DateTime.Date)
            'datos.Add(Me.cbRubro.EditValue)
            'datos.Add(EmpresaActual)
            'datos.Add(Me.cbMonedas.EditValue)
            'datos.Add(cbProveedores.EditValue)

            ShowSplash("Generando Saldos...")
            '
            Dim rpt As New rptSaldoProveedores
            rpt.Moneda.Text = Me.cbMonedas.Text
            ''rpt.Periodo.Text = "Desde : " & DTPickerDe.DateTime.Date & " Hasta : " & DTPickerHasta.DateTime.Date
            rpt.Periodo.Text = "Al Corte: " & DTPicker.DateTime.Date
            ' rpt.DataSource = ProcedureParameters(datos, variables, "sp_GetSaldosProveedorV2")

            Dim _DT As DataTable = ObtieneDatos("sp_GetSaldosProveedorV2", DTPicker.DateTime.Date,
                                          DTPicker.DateTime.Date,
                                          cbRubro.EditValue,
                                          EmpresaActual,
                                          cbMonedas.EditValue,
                                           cbProveedores.EditValue)

            VistaPreviaDX(rpt, _DT, "Reporte de Cuentas por Pagar")

            'rpt.ShowPrintMarginsWarning = False
            'rpt.BringToFront()
            'rpt.ShowRibbonPreview()
            '
            HideSplash()
        End If
    End Sub


    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/Reportes/ReportesGestion.chm", HelpNavigator.KeywordIndex, "2")
    End Sub

    Private Sub cbMes_EditValueChanged(sender As Object, e As EventArgs) Handles cbMes.EditValueChanged
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date

        Me.DTPickerDe.DateTime = New DateTime(f.Year, cbMes.EditValue, 1)
        Me.DTPickerHasta.DateTime = f.Date
    End Sub

    Private Sub cbMes_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'Dim mes, c As String
        'If IsNumeric(Me.cbMes.SelectedValue) Then
        '    mes = Me.cbMes.SelectedItem.row.itemarray(0)
        '    mes = mes.PadLeft(2, "0")
        '    c = Me.cbMes.SelectedItem.row.itemarray(2)
        '    mes = mes & "-" & c.Substring(Len(c.Trim) - 4, 4)

        '    If mes <> "" Then
        '        Me.DTPickerDe.DateTime = New DateTime(mes.Substring(3, 4), mes.Substring(0, 2), 1)
        '        Me.DTPickerHasta.DateTime = New DateTime(mes.Substring(3, 4), mes.Substring(0, 2), Meses(mes.Substring(0, 2) - 1))
        '    End If
        'End If
    End Sub

    'Private Sub DTPicker_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DTPicker.TextChanged
    '    Me.DTPickerDe.DateTime = Me.DTPicker.DateTime
    '    Me.DTPickerHasta.DateTime = Me.DTPicker.DateTime
    'End Sub

    'Private Sub DTPicker_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DTPicker.Validating
    '    Me.DTPickerDe.DateTime = Me.DTPicker.DateTime
    '    Me.DTPickerHasta.DateTime = Me.DTPicker.DateTime
    'End Sub

  
End Class