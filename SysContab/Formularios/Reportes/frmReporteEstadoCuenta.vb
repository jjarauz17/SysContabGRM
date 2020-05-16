Imports System.IO
Imports System
Imports System.Linq
Imports System.Data
Imports DevExpress.XtraReports.UI

Public Class frmReporteEstadoCuenta
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmReporteEstadoCuenta = Nothing

    Public Shared Function Instance() As frmReporteEstadoCuenta
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmReporteEstadoCuenta
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Dim Mes As New VB.SysContab.MesesDB
    Dim Cliente As New VB.SysContab.ClientesDB
    Dim Articulo As New VB.SysContab.ArticulosDB
    Dim Puntos_Venta As New VB.SysContab.PuntosVentasDB
    Dim Servicios As New VB.SysContab.ServiciosDB
    Dim Vendedores As New VB.SysContab.VendedoresDB
    Dim Rutinas As New VB.SysContab.Rutinas
    Dim FormaPago As New VB.SysContab.Forma_PagoDB
    Friend WithEvents dgCodigo As System.Windows.Forms.DataGrid
    Friend WithEvents cbSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DTPickerHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DTPickerDe As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DTPicker As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cbMoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbFormaPago As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cbMeses As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbBodegas As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbRubro As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lyQuitarSaldo As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbClientes As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Dim r As New VB.SysContab.Rutinas

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporteEstadoCuenta))
        Me.cbMoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cbClientes = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.cbRubro = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbBodegas = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.cbMeses = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbFormaPago = New DevExpress.XtraEditors.LookUpEdit()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.rbRango = New System.Windows.Forms.RadioButton()
        Me.DTPickerHasta = New DevExpress.XtraEditors.DateEdit()
        Me.rbFecha1 = New System.Windows.Forms.RadioButton()
        Me.rbMes = New System.Windows.Forms.RadioButton()
        Me.DTPickerDe = New DevExpress.XtraEditors.DateEdit()
        Me.cbSucursal = New DevExpress.XtraEditors.LookUpEdit()
        Me.DTPicker = New DevExpress.XtraEditors.DateEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyQuitarSaldo = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.Cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Print = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.tbValorTotal = New System.Windows.Forms.TextBox()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cbClientes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbRubro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbBodegas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMeses.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbFormaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTPickerHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTPickerHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTPickerDe.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTPickerDe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTPicker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTPicker.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyQuitarSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbMoneda
        '
        Me.cbMoneda.Location = New System.Drawing.Point(89, 146)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMoneda.Properties.Appearance.Options.UseFont = True
        Me.cbMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMoneda.Properties.ShowFooter = False
        Me.cbMoneda.Properties.ShowHeader = False
        Me.cbMoneda.Size = New System.Drawing.Size(725, 22)
        Me.cbMoneda.StyleController = Me.LayoutControl1
        Me.cbMoneda.TabIndex = 10
        Me.cbMoneda.Visible = False
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cbClientes)
        Me.LayoutControl1.Controls.Add(Me.CheckEdit1)
        Me.LayoutControl1.Controls.Add(Me.cbRubro)
        Me.LayoutControl1.Controls.Add(Me.cbBodegas)
        Me.LayoutControl1.Controls.Add(Me.cbMeses)
        Me.LayoutControl1.Controls.Add(Me.cbFormaPago)
        Me.LayoutControl1.Controls.Add(Me.RadioGroup1)
        Me.LayoutControl1.Controls.Add(Me.rbRango)
        Me.LayoutControl1.Controls.Add(Me.DTPickerHasta)
        Me.LayoutControl1.Controls.Add(Me.rbFecha1)
        Me.LayoutControl1.Controls.Add(Me.cbMoneda)
        Me.LayoutControl1.Controls.Add(Me.rbMes)
        Me.LayoutControl1.Controls.Add(Me.DTPickerDe)
        Me.LayoutControl1.Controls.Add(Me.cbSucursal)
        Me.LayoutControl1.Controls.Add(Me.DTPicker)
        Me.LayoutControl1.Controls.Add(Me.Label4)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1109, 181, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(619, 383)
        Me.LayoutControl1.TabIndex = 116
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cbClientes
        '
        Me.cbClientes.Location = New System.Drawing.Point(88, 67)
        Me.cbClientes.Name = "cbClientes"
        Me.cbClientes.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClientes.Properties.Appearance.Options.UseFont = True
        Me.cbClientes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbClientes.Properties.View = Me.SearchLookUpEdit1View
        Me.cbClientes.Size = New System.Drawing.Size(507, 20)
        Me.cbClientes.StyleController = Me.LayoutControl1
        Me.cbClientes.TabIndex = 121
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(334, 318)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit1.Properties.Caption = "Quitar Saldos Ceros (0)"
        Me.CheckEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.CheckEdit1.Size = New System.Drawing.Size(261, 22)
        Me.CheckEdit1.StyleController = Me.LayoutControl1
        Me.CheckEdit1.TabIndex = 120
        '
        'cbRubro
        '
        Me.cbRubro.Location = New System.Drawing.Point(88, 169)
        Me.cbRubro.Name = "cbRubro"
        Me.cbRubro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRubro.Properties.Appearance.Options.UseFont = True
        Me.cbRubro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbRubro.Size = New System.Drawing.Size(507, 20)
        Me.cbRubro.StyleController = Me.LayoutControl1
        Me.cbRubro.TabIndex = 119
        '
        'cbBodegas
        '
        Me.cbBodegas.Location = New System.Drawing.Point(88, 143)
        Me.cbBodegas.Name = "cbBodegas"
        Me.cbBodegas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cbBodegas.Properties.Appearance.Options.UseFont = True
        Me.cbBodegas.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cbBodegas.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cbBodegas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbBodegas.Size = New System.Drawing.Size(507, 22)
        Me.cbBodegas.StyleController = Me.LayoutControl1
        Me.cbBodegas.TabIndex = 118
        '
        'cbMeses
        '
        Me.cbMeses.Location = New System.Drawing.Point(124, 236)
        Me.cbMeses.Name = "cbMeses"
        Me.cbMeses.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cbMeses.Properties.Appearance.Options.UseFont = True
        Me.cbMeses.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cbMeses.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cbMeses.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMeses.Size = New System.Drawing.Size(206, 20)
        Me.cbMeses.StyleController = Me.LayoutControl1
        Me.cbMeses.TabIndex = 116
        '
        'cbFormaPago
        '
        Me.cbFormaPago.Location = New System.Drawing.Point(88, 91)
        Me.cbFormaPago.Name = "cbFormaPago"
        Me.cbFormaPago.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFormaPago.Properties.Appearance.Options.UseFont = True
        Me.cbFormaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbFormaPago.Size = New System.Drawing.Size(308, 20)
        Me.cbFormaPago.StyleController = Me.LayoutControl1
        Me.cbFormaPago.TabIndex = 115
        '
        'RadioGroup1
        '
        Me.RadioGroup1.EditValue = 2
        Me.RadioGroup1.Location = New System.Drawing.Point(334, 236)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioGroup1.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.RadioGroup1.Properties.Appearance.Options.UseBackColor = True
        Me.RadioGroup1.Properties.Appearance.Options.UseFont = True
        Me.RadioGroup1.Properties.Appearance.Options.UseForeColor = True
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Para el Cliente"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Mostrar Estado Cuenta Lineal")})
        Me.RadioGroup1.Size = New System.Drawing.Size(261, 78)
        Me.RadioGroup1.StyleController = Me.LayoutControl1
        Me.RadioGroup1.TabIndex = 10
        '
        'rbRango
        '
        Me.rbRango.BackColor = System.Drawing.Color.Transparent
        Me.rbRango.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbRango.Location = New System.Drawing.Point(24, 294)
        Me.rbRango.Name = "rbRango"
        Me.rbRango.Size = New System.Drawing.Size(96, 25)
        Me.rbRango.TabIndex = 3
        Me.rbRango.Text = "RANGO"
        Me.rbRango.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbRango.UseVisualStyleBackColor = False
        '
        'DTPickerHasta
        '
        Me.DTPickerHasta.EditValue = Nothing
        Me.DTPickerHasta.Location = New System.Drawing.Point(188, 318)
        Me.DTPickerHasta.Name = "DTPickerHasta"
        Me.DTPickerHasta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPickerHasta.Properties.Appearance.Options.UseFont = True
        Me.DTPickerHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DTPickerHasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DTPickerHasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.DTPickerHasta.Size = New System.Drawing.Size(142, 20)
        Me.DTPickerHasta.StyleController = Me.LayoutControl1
        Me.DTPickerHasta.TabIndex = 8
        '
        'rbFecha1
        '
        Me.rbFecha1.BackColor = System.Drawing.Color.Transparent
        Me.rbFecha1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbFecha1.Location = New System.Drawing.Point(24, 265)
        Me.rbFecha1.Name = "rbFecha1"
        Me.rbFecha1.Size = New System.Drawing.Size(96, 25)
        Me.rbFecha1.TabIndex = 2
        Me.rbFecha1.Text = "A la Fecha:"
        Me.rbFecha1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbFecha1.UseVisualStyleBackColor = False
        '
        'rbMes
        '
        Me.rbMes.BackColor = System.Drawing.Color.Transparent
        Me.rbMes.Checked = True
        Me.rbMes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbMes.Location = New System.Drawing.Point(24, 236)
        Me.rbMes.Name = "rbMes"
        Me.rbMes.Size = New System.Drawing.Size(96, 25)
        Me.rbMes.TabIndex = 1
        Me.rbMes.TabStop = True
        Me.rbMes.Text = "Mes"
        Me.rbMes.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbMes.UseVisualStyleBackColor = False
        '
        'DTPickerDe
        '
        Me.DTPickerDe.EditValue = Nothing
        Me.DTPickerDe.Location = New System.Drawing.Point(188, 289)
        Me.DTPickerDe.Name = "DTPickerDe"
        Me.DTPickerDe.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPickerDe.Properties.Appearance.Options.UseFont = True
        Me.DTPickerDe.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DTPickerDe.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DTPickerDe.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.DTPickerDe.Size = New System.Drawing.Size(142, 20)
        Me.DTPickerDe.StyleController = Me.LayoutControl1
        Me.DTPickerDe.TabIndex = 7
        '
        'cbSucursal
        '
        Me.cbSucursal.Location = New System.Drawing.Point(88, 117)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSucursal.Properties.Appearance.Options.UseFont = True
        Me.cbSucursal.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSucursal.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cbSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbSucursal.Properties.ShowFooter = False
        Me.cbSucursal.Properties.ShowHeader = False
        Me.cbSucursal.Size = New System.Drawing.Size(507, 22)
        Me.cbSucursal.StyleController = Me.LayoutControl1
        Me.cbSucursal.TabIndex = 25
        '
        'DTPicker
        '
        Me.DTPicker.EditValue = Nothing
        Me.DTPicker.Location = New System.Drawing.Point(124, 260)
        Me.DTPicker.Name = "DTPicker"
        Me.DTPicker.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPicker.Properties.Appearance.Options.UseFont = True
        Me.DTPicker.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DTPicker.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DTPicker.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.DTPicker.Size = New System.Drawing.Size(206, 20)
        Me.DTPicker.StyleController = Me.LayoutControl1
        Me.DTPicker.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(12, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(595, 20)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "REPORTE DE CUENTAS POR COBRAR"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cbMoneda
        Me.LayoutControlItem6.CustomizationFormText = "Moneda:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 78)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(794, 26)
        Me.LayoutControlItem6.Text = "Moneda:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlGroup2, Me.LayoutControlGroup3, Me.EmptySpaceItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(619, 383)
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
        Me.LayoutControlItem1.Size = New System.Drawing.Size(599, 24)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup2.AppearanceGroup.ForeColor = System.Drawing.Color.DarkRed
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseTextOptions = True
        Me.LayoutControlGroup2.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlGroup2.CustomizationFormText = "CRITERIOS DE SELECCION"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem15, Me.EmptySpaceItem2, Me.LayoutControlItem7, Me.LayoutControlItem18, Me.LayoutControlItem20})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(599, 169)
        Me.LayoutControlGroup2.Text = "CRITERIOS DE SELECCION"
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cbSucursal
        Me.LayoutControlItem5.CustomizationFormText = "Sucursal:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(575, 26)
        Me.LayoutControlItem5.Text = "Sucursal:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.cbFormaPago
        Me.LayoutControlItem15.CustomizationFormText = "Vencimiento:"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(376, 26)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(376, 26)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(376, 26)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.Text = "Vencimiento:"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(61, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(376, 24)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(199, 26)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cbBodegas
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 76)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(575, 26)
        Me.LayoutControlItem7.Text = "Sucursal:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(61, 13)
        Me.LayoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.cbRubro
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 102)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(575, 24)
        Me.LayoutControlItem18.Text = "Rubro:"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.cbClientes
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(575, 24)
        Me.LayoutControlItem20.Text = "Cliente:"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup3.AppearanceGroup.ForeColor = System.Drawing.Color.DarkRed
        Me.LayoutControlGroup3.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup3.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup3.AppearanceGroup.Options.UseTextOptions = True
        Me.LayoutControlGroup3.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlGroup3.CustomizationFormText = "TIEMPOS"
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem11, Me.LayoutControlItem2, Me.LayoutControlItem12, Me.LayoutControlItem8, Me.LayoutControlItem13, Me.LayoutControlItem9, Me.EmptySpaceItem1, Me.LayoutControlItem10, Me.LayoutControlItem4, Me.lyQuitarSaldo})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 193)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(599, 151)
        Me.LayoutControlGroup3.Text = "TIEMPOS"
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.rbMes
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(100, 29)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(100, 29)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(100, 29)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.RadioGroup1
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(310, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(265, 82)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.rbFecha1
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 29)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(100, 29)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(100, 29)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(100, 29)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.DTPicker
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(100, 24)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(210, 29)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(210, 29)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(210, 29)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.rbRango
        Me.LayoutControlItem13.CustomizationFormText = "LayoutControlItem13"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 58)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(100, 29)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(100, 29)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(100, 29)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.DTPickerDe
        Me.LayoutControlItem9.CustomizationFormText = "Desde:"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(100, 53)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(210, 29)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(210, 29)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(210, 29)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.Text = "Desde:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(61, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 87)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(100, 21)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.DTPickerHasta
        Me.LayoutControlItem10.CustomizationFormText = "Hasta:"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(100, 82)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(210, 26)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(210, 26)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(210, 26)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.Text = "Hasta:"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cbMeses
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(100, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(210, 24)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'lyQuitarSaldo
        '
        Me.lyQuitarSaldo.Control = Me.CheckEdit1
        Me.lyQuitarSaldo.Location = New System.Drawing.Point(310, 82)
        Me.lyQuitarSaldo.Name = "lyQuitarSaldo"
        Me.lyQuitarSaldo.Size = New System.Drawing.Size(265, 26)
        Me.lyQuitarSaldo.TextSize = New System.Drawing.Size(0, 0)
        Me.lyQuitarSaldo.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 344)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(599, 19)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'Cancel
        '
        Me.Cancel.ImageOptions.Image = CType(resources.GetObject("Cancel.ImageOptions.Image"), System.Drawing.Image)
        Me.Cancel.Location = New System.Drawing.Point(12, 289)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(118, 38)
        Me.Cancel.StyleController = Me.LayoutControl2
        Me.Cancel.TabIndex = 1
        Me.Cancel.Text = "&Salir"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl2.Controls.Add(Me.Print)
        Me.LayoutControl2.Controls.Add(Me.Cancel)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(949, 487, 250, 350)
        Me.LayoutControl2.Root = Me.LayoutControlGroup4
        Me.LayoutControl2.Size = New System.Drawing.Size(141, 356)
        Me.LayoutControl2.TabIndex = 3
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(12, 247)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(118, 38)
        Me.SimpleButton2.StyleController = Me.LayoutControl2
        Me.SimpleButton2.TabIndex = 118
        Me.SimpleButton2.Text = "&Diseño"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Options.UseTextOptions = True
        Me.SimpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 54)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(118, 38)
        Me.SimpleButton1.StyleController = Me.LayoutControl2
        Me.SimpleButton1.TabIndex = 118
        Me.SimpleButton1.Text = "&Informe por Cobrar"
        '
        'Print
        '
        Me.Print.ImageOptions.Image = CType(resources.GetObject("Print.ImageOptions.Image"), System.Drawing.Image)
        Me.Print.Location = New System.Drawing.Point(12, 12)
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(118, 38)
        Me.Print.StyleController = Me.LayoutControl2
        Me.Print.TabIndex = 0
        Me.Print.Text = "&Imprimir"
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "LayoutControlGroup4"
        Me.LayoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup4.GroupBordersVisible = False
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem14, Me.LayoutControlItem16, Me.EmptySpaceItem4, Me.LayoutControlItem17, Me.LayoutControlItem19})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "Root"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(142, 339)
        Me.LayoutControlGroup4.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.Print
        Me.LayoutControlItem14.CustomizationFormText = "LayoutControlItem14"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.Cancel
        Me.LayoutControlItem16.CustomizationFormText = "LayoutControlItem16"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 277)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 84)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(122, 151)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.SimpleButton1
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem17.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.SimpleButton2
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 235)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(122, 42)
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
        Me.DockPanel1.ID = New System.Guid("6ea6876d-21da-41f5-a259-e71e01951bc0")
        Me.DockPanel1.Location = New System.Drawing.Point(619, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(150, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(150, 383)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(141, 356)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'frmReporteEstadoCuenta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(769, 383)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReporteEstadoCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cbClientes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbRubro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbBodegas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMeses.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbFormaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTPickerHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTPickerHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTPickerDe.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTPickerDe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTPicker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTPicker.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyQuitarSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmReportesFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Proveedor As New VB.SysContab.ProveedoresDB
        Dim Linea As New VB.SysContab.Grupos_InventarioDB

        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date

        Me.DTPicker.DateTime = f.Date

        ''Me.DTPickerDe.DateTime = r.Fecha
        ''Me.DTPickerHasta.DateTime = r.Fecha

        DTPickerDe.DateTime = New DateTime(f.Year, f.Month, 1)
        DTPickerHasta.DateTime = UltimoDiaDelMes(f.Date).Date

        'cbOrdenRed.DataSource = Puntos_Venta.Getlist().Tables("PUNTOS_VENTA")
        'cbOrdenRed.ValueMember = "Codigo"
        'cbOrdenRed.DisplayMember = "Nombre"
        'cbOrdenRed.SelectedValue = -1
        'cbMes.DataSource = VB.SysContab.MesesDB.MesexPeriodo.Tables("Meses")
        'cbMes.ValueMember = "Mes"
        'cbMes.DisplayMember = "MesAnno"
        'cbMes.SelectedValue = 0

        GetMesesList(cbMeses)

        SearchLookUp(
            cbClientes,
            ObtieneDatos("SP_GetClientes", EmpresaActual, 0),
            "Nombre",
            "Codigo",
            6, 8, 9, 10, 11, 12, 13, 14, 15, 16)

        ' GetClientesList(cbClientes)
        cbClientes.EditValue = 0

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

        'cbSucursal.Properties.DataSource = ObtieneDatos("sp_GetSucursalesClientes " & EmpresaActual)
        'cbSucursal.Properties.ValueMember = "Codigo"
        'cbSucursal.Properties.DisplayMember = "Sucursal"
        'cbSucursal.Properties.PopulateColumns()
        'cbSucursal.ItemIndex = 0
        '
        Combo(cbSucursal, ObtieneDatos("JAR_GetSucursalesClientes", EmpresaActual))
        cbSucursal.ItemIndex = 0

        LookUp(cbRubro, ObtieneDatos("JAR_GetRubrosClientesxUsuario", EmpresaActual), "Display", "Cuenta", "[Seleccione Rubro]", 2)
        cbRubro.ItemIndex = 0

        ''GetMonedasList(cbMoneda)
        Me.Text = "Gestión Comercial - Cuentas x Cobrar"
    End Sub

    Private Sub rbOrdenRed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub rbOredenWeb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub rbTodas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  cbMeses.EditValue = "0"
        cbMeses.Enabled = False
        DTPicker.Enabled = False
        DTPickerDe.Enabled = False
        DTPickerHasta.Enabled = False
    End Sub

    Private Sub rbMes_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMes.CheckedChanged
        cbMeses.Enabled = True
        DTPicker.Enabled = False
        DTPickerDe.Enabled = False
        DTPickerHasta.Enabled = False
    End Sub

    Private Sub rbFecha1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFecha1.CheckedChanged
        '   cbMeses.EditValue = "0"
        cbMeses.Enabled = False
        DTPicker.Enabled = True
        DTPickerDe.Enabled = False
        DTPickerHasta.Enabled = False
    End Sub

    Private Sub rbRango_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRango.CheckedChanged
        '  cbMeses.EditValue = "0"
        cbMeses.Enabled = False
        DTPicker.Enabled = False
        DTPickerDe.Enabled = True
        DTPickerHasta.Enabled = True
    End Sub

    Private Sub Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Print.Click

        Dim Mes As String
        Dim Fecha As String
        Dim FechaDesde As String
        Dim FechaHasta As String

        If RadioGroup1.EditValue = 1 Then  '' Estado de Cuenta para Cliente
            If Not rbFecha1.Checked Then
                XtraMsg("Seleccione la Fecha de Corte")
                rbFecha1.Checked = True
                DTPicker.Focus()
                Exit Sub
            End If
            ''
            If cbClientes.EditValue = 0 Then
                XtraMsg("Seleccione el Cliente")
                Exit Sub
            End If
            ''
            'If Not rbRango.Checked Then
            '    XtraMsg("Seleccione Rango de Fecha")
            '    Exit Sub
            'End If

            ShowSplash("Imprimiendo Reporte...")
            ''
            Dim r As New rptEstadoCuentaEnviar

            r.Periodo.Text = "Al Corte: " & DTPicker.DateTime.Date
            ''r.Periodo.Text = "Desde : " & DTPickerDe.DateTime.Date & " Hasta : " & DTPickerHasta.DateTime.Date
            Dim _DT As DataTable = ObtieneDatos("SP_EstadoCuentaReporteEnviar",
                                                cbClientes.EditValue,
                                                DTPicker.DateTime.Date,
                                                DTPicker.DateTime.Date,
                                                EmpresaActual)

            'r.DataSource = ObtieneDatos("SP_EstadoCuentaReporteEnviar", cbClientes.EditValue, DTPicker.DateTime.Date, DTPicker.DateTime.Date, EmpresaActual)
            'HideSplash()

            VistaPreviaDX(r, _DT, "ESTADO CUENTA DE CLIENTE - " & cbClientes.Text)

            'r.ShowPrintMarginsWarning = False
            'r.BringToFront()
            'r.ShowRibbonPreview()
            ''
            HideSplash()
        ElseIf RadioGroup1.EditValue = 2 Then   'Estado de Cuenta Lineal
            ShowSplash("Imprimiendo Reporte...")
            ''
            Dim Cadena As String
            Dim Temp As Boolean = False
            Dim Data() As Byte

            Try
                Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 27 and Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())
                Temp = True
                '
                Dim Tamano As Integer
                Tamano = Data.GetUpperBound(0)
                Cadena = Application.StartupPath & "\rptCuentasxCobrar.repx"
                If File.Exists(Cadena) Then Kill(Cadena)
                Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
                Archivo.Write(Data, 0, Tamano)
                Archivo.Close()
            Catch ex As Exception
                Temp = False
            End Try

            Dim rpt As RptEstadoCuentaCliente

            If Temp = True Then
                rpt = XtraReport.FromFile(Application.StartupPath & "\rptCuentasxCobrar.repx", True)
            Else
                rpt = New RptEstadoCuentaCliente
            End If

            ' Dim rpt As New RptEstadoCuentaCliente
            '
            If rbMes.Checked = True Then
                Mes = cbMeses.EditValue
                Fecha = ""
                FechaDesde = New Date(Year(cbMeses.GetColumnValue("Fecha")),
                    Month(cbMeses.GetColumnValue("Fecha")), 1)

                FechaHasta = New Date(Year(cbMeses.GetColumnValue("Fecha")),
                    Month(cbMeses.GetColumnValue("Fecha")), Meses(cbMeses.EditValue - 1))

                rpt.Periodo.Text = "Del mes : " & cbMeses.Text & vbCrLf &
                    IIf(cbRubro.ItemIndex = 0, "", "Rubro: " & cbRubro.Text)
            End If

            If rbFecha1.Checked = True Then
                Mes = 0
                Fecha = DTPicker.DateTime.Date
                FechaDesde = DTPicker.DateTime.Date
                FechaHasta = DTPicker.DateTime.Date
                rpt.Periodo.Text = "Del dia : " & DTPicker.DateTime.Date.ToShortDateString & vbCrLf &
                    IIf(cbRubro.ItemIndex = 0, "", "Rubro: " & cbRubro.Text)
            End If

            If rbRango.Checked = True Then
                Mes = 0
                Fecha = ""
                FechaDesde = DTPickerDe.DateTime.Date
                FechaHasta = DTPickerHasta.DateTime.Date
                rpt.Periodo.Text = "Desde : " & DTPickerDe.DateTime.Date.ToShortDateString & " Hasta : " & DTPickerHasta.DateTime.Date.ToShortDateString & vbCrLf &
                    IIf(cbRubro.ItemIndex = 0, "", "Rubro: " & cbRubro.Text)
            End If

            Dim Clientes As New VB.SysContab.ClientesDB

            Dim DT_EC As DataTable = Clientes.EstadoCuentaReporteNew(cbClientes.EditValue, Mes,
                                cbFormaPago.EditValue, Fecha, FechaDesde,
                                FechaHasta, IIf(cbSucursal.ItemIndex = 0, "%", cbSucursal.EditValue),
                                IIf(cbRubro.ItemIndex = 0, "%", cbRubro.EditValue), IIf(CheckEdit1.Checked, 1, 0)).Tables(0)


            If CheckEdit1.Checked Then
                DT_EC = DT_EC.Select("Saldo > 0").CopyToDataTable
            End If

            'rpt.DataSource = DT_EC

            Try
                Dim DT_LOGO As DataTable = VB.SysContab.EmpresasDB.GetLogoEmpresa().Tables(0)
                Dim _logo As Byte() = DirectCast(DT_LOGO.Rows.Item(0)("Logo"), Byte())
                Dim ms As New System.IO.MemoryStream(_logo)
                rpt.Logo.Image = Image.FromStream(ms)
            Catch ex As Exception
            End Try

            VistaPreviaDX(rpt, DT_EC, "Reporte de Cuentas por Cobrar")

            HideSplash()

            'rpt.ShowPrintMarginsWarning = False
            'rpt.BringToFront()
            'rpt.ShowRibbonPreview()

        ElseIf RadioGroup1.EditValue = 3 Then   'Cuentas por Cobrar

        End If


        ''

        'If rbMes.Checked = True Then
        '    Mes = cbMes.SelectedValue
        '    Fecha = ""
        '    FechaDesde = New Date(Year(Me.cbMes.DataSource.rows(Me.cbMes.SelectedIndex)("Fecha")), _
        '        Month(Me.cbMes.DataSource.rows(Me.cbMes.SelectedIndex)("Fecha")), 1)
        '    FechaHasta = New Date(Year(Me.cbMes.DataSource.rows(Me.cbMes.SelectedIndex)("Fecha")), _
        '        Month(Me.cbMes.DataSource.rows(Me.cbMes.SelectedIndex)("Fecha")), Meses(cbMes.SelectedValue - 1))
        'End If

        'If rbFecha1.Checked = True Then
        '    Mes = 0
        '    Fecha = DTPicker.Value.Date
        '    FechaDesde = DTPicker.Value.Date
        '    FechaHasta = DTPicker.Value.Date
        'End If

        'If rbRango.Checked = True Then
        '    Mes = 0
        '    Fecha = ""
        '    FechaDesde = DTPickerDe.Value.Date
        '    FechaHasta = DTPickerHasta.Value.Date
        'End If


        'Dim fReportes As New frmReportes
        'Dim rFacturas As New RptCuentasPorCobrar
        'Dim Clientes As New VB.SysContab.ClientesDB
        'Clientes.EstadoCuentaReporte(cbClientes.SelectedValue, Mes, _
        '                    cbVendedores.SelectedValue, Fecha, FechaDesde, _
        '                    FechaHasta).WriteXml(Application.StartupPath & "\xml\RptCuentasPorCobrar.xml", XmlWriteMode.WriteSchema)

        'rFacturas.Database.Tables(0).Location = Application.StartupPath & "\xml\RptCuentasPorCobrar.xml"

        'fReportes.crvReportes.ReportSource = rFacturas

        'If rbScreen.Checked = True Then
        '    fReportes.Show()
        'ElseIf rbPrint.Checked = True Then
        '    fReportes.crvReportes.PrintReport()
        'Else
        '    fReportes.crvReportes.ExportReport()
        'End If
    End Sub

    Private Sub DTPickerDe_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Help.ShowHelp(Me, "Ayuda/Reportes/ReportesGestion.chm", HelpNavigator.KeywordIndex, "5")
    End Sub

    'Private Sub cbMes_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Dim mes, c As String
    '    If IsNumeric(Me.cbMes.SelectedValue) Then
    '        mes = Me.cbMes.SelectedItem.row.itemarray(0)
    '        mes = mes.PadLeft(2, "0")
    '        c = Me.cbMes.SelectedItem.row.itemarray(2)
    '        mes = mes & "-" & c.Substring(Len(c.Trim) - 4, 4)

    '        If mes <> "" Then
    '            Me.DTPickerDe.DateTime = New DateTime(mes.Substring(3, 4), mes.Substring(0, 2), 1)
    '            Me.DTPickerHasta.DateTime = New DateTime(mes.Substring(3, 4), mes.Substring(0, 2), Meses(mes.Substring(0, 2) - 1))
    '        End If
    '    End If
    'End Sub

    Private Sub DTPicker_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DTPicker.TextChanged
        ''Me.DTPickerDe.DateTime = Me.DTPicker.DateTime
        '' Me.DTPickerHasta.DateTime = Me.DTPicker.DateTime
    End Sub

    Private Sub DTPicker_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DTPicker.Validating
        ''Me.DTPickerDe.DateTime = Me.DTPicker.DateTime
        '' Me.DTPickerHasta.DateTime = Me.DTPicker.DateTime
    End Sub

    Private Sub CheckEdit2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If CheckEdit2.Checked Then
        '    rbFecha1.Checked = False
        '    rbRango.Checked = True
        'End If
    End Sub

    Private Sub cbClientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If CheckEdit1.Checked Then
        '    rbFecha1.Checked = True
        '    rbRango.Checked = False
        '    DTPicker.DateTime = Now.Date
        '    DTPicker.Focus()
        'Else
        '    rbFecha1.Checked = False
        '    rbRango.Checked = True
        'End If
    End Sub

    Private Sub DTPickerDe_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPickerDe.EditValueChanged

    End Sub

    Private Sub DTPicker_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPicker.EditValueChanged

    End Sub

    Private Sub DTPickerHasta_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPickerHasta.EditValueChanged

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        frmCuentasxCobrar.Dispose()
        frmCuentasxCobrar.Show()
        frmCuentasxCobrar.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        With FrmConfiguraCheque
            .Tipo = 27
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup1.SelectedIndexChanged
        If RadioGroup1.EditValue = 1 Then lyQuitarSaldo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        If RadioGroup1.EditValue = 2 Then lyQuitarSaldo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
    End Sub
End Class