Imports System.Data.SqlClient
Imports SysContab.VB

Public Class FrmHacerCheques
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As FrmHacerCheques = Nothing

    Public Shared Function Instance() As FrmHacerCheques
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmHacerCheques
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
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdguardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemCuenta As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ItemCuentas As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbbancos As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbiva As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbir As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbalcaldia As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbproveedor As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtbalance As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtiva As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtir As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtalcaldia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkiva As System.Windows.Forms.CheckBox
    Friend WithEvents chkir As System.Windows.Forms.CheckBox
    Friend WithEvents chkalcaldia As System.Windows.Forms.CheckBox
    Friend WithEvents txtnocheque As DevExpress.XtraEditors.TextEdit
    Friend WithEvents fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtconcepto As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtanombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtmonto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtletras As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtmonedabase As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtruc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtmoneda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtcedula As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbcentro As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbFacturas As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents etSaldo As System.Windows.Forms.Label
    Friend WithEvents ckLiquidar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbOrdenCompra As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
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
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents chkAnticipos As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmbbancos = New DevExpress.XtraEditors.LookUpEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.ckLiquidar = New DevExpress.XtraEditors.CheckEdit()
        Me.GridDetalle = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemCuenta = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemCuentas = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbOrdenCompra = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cmdguardar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbcentro = New DevExpress.XtraEditors.LookUpEdit()
        Me.etSaldo = New System.Windows.Forms.Label()
        Me.chkAnticipos = New System.Windows.Forms.CheckBox()
        Me.txtconcepto = New DevExpress.XtraEditors.MemoEdit()
        Me.txtiva = New DevExpress.XtraEditors.TextEdit()
        Me.cbFacturas = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtir = New DevExpress.XtraEditors.TextEdit()
        Me.txtanombre = New DevExpress.XtraEditors.TextEdit()
        Me.cmdsalir = New DevExpress.XtraEditors.SimpleButton()
        Me.chkir = New System.Windows.Forms.CheckBox()
        Me.txtletras = New DevExpress.XtraEditors.TextEdit()
        Me.txtalcaldia = New DevExpress.XtraEditors.TextEdit()
        Me.txtmonto = New DevExpress.XtraEditors.TextEdit()
        Me.txtbalance = New DevExpress.XtraEditors.TextEdit()
        Me.cmbproveedor = New DevExpress.XtraEditors.LookUpEdit()
        Me.fecha = New DevExpress.XtraEditors.DateEdit()
        Me.txtmonedabase = New DevExpress.XtraEditors.TextEdit()
        Me.txtnocheque = New DevExpress.XtraEditors.TextEdit()
        Me.txtmoneda = New DevExpress.XtraEditors.TextEdit()
        Me.chkiva = New System.Windows.Forms.CheckBox()
        Me.chkalcaldia = New System.Windows.Forms.CheckBox()
        Me.txtruc = New DevExpress.XtraEditors.TextEdit()
        Me.txtcedula = New DevExpress.XtraEditors.TextEdit()
        Me.cmbiva = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbir = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbalcaldia = New DevExpress.XtraEditors.LookUpEdit()
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
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.cmbbancos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.ckLiquidar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbcentro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtconcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtiva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbFacturas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtanombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtletras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtalcaldia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtbalance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbproveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmonedabase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnocheque.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtruc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcedula.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbiva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbalcaldia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbbancos
        '
        Me.cmbbancos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbbancos.Location = New System.Drawing.Point(116, 12)
        Me.cmbbancos.Name = "cmbbancos"
        Me.cmbbancos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbbancos.Properties.NullText = ""
        Me.cmbbancos.Properties.ShowFooter = False
        Me.cmbbancos.Properties.ShowHeader = False
        Me.cmbbancos.Size = New System.Drawing.Size(494, 20)
        Me.cmbbancos.StyleController = Me.LayoutControl1
        Me.cmbbancos.TabIndex = 0
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.ckLiquidar)
        Me.LayoutControl1.Controls.Add(Me.GridDetalle)
        Me.LayoutControl1.Controls.Add(Me.cmdguardar)
        Me.LayoutControl1.Controls.Add(Me.cmbcentro)
        Me.LayoutControl1.Controls.Add(Me.etSaldo)
        Me.LayoutControl1.Controls.Add(Me.chkAnticipos)
        Me.LayoutControl1.Controls.Add(Me.txtconcepto)
        Me.LayoutControl1.Controls.Add(Me.txtiva)
        Me.LayoutControl1.Controls.Add(Me.cbFacturas)
        Me.LayoutControl1.Controls.Add(Me.txtir)
        Me.LayoutControl1.Controls.Add(Me.txtanombre)
        Me.LayoutControl1.Controls.Add(Me.cmdsalir)
        Me.LayoutControl1.Controls.Add(Me.chkir)
        Me.LayoutControl1.Controls.Add(Me.txtletras)
        Me.LayoutControl1.Controls.Add(Me.txtalcaldia)
        Me.LayoutControl1.Controls.Add(Me.txtmonto)
        Me.LayoutControl1.Controls.Add(Me.txtbalance)
        Me.LayoutControl1.Controls.Add(Me.cmbproveedor)
        Me.LayoutControl1.Controls.Add(Me.fecha)
        Me.LayoutControl1.Controls.Add(Me.txtmonedabase)
        Me.LayoutControl1.Controls.Add(Me.txtnocheque)
        Me.LayoutControl1.Controls.Add(Me.txtmoneda)
        Me.LayoutControl1.Controls.Add(Me.chkiva)
        Me.LayoutControl1.Controls.Add(Me.chkalcaldia)
        Me.LayoutControl1.Controls.Add(Me.txtruc)
        Me.LayoutControl1.Controls.Add(Me.txtcedula)
        Me.LayoutControl1.Controls.Add(Me.cmbbancos)
        Me.LayoutControl1.Controls.Add(Me.cmbiva)
        Me.LayoutControl1.Controls.Add(Me.cmbir)
        Me.LayoutControl1.Controls.Add(Me.cmbalcaldia)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1173, 180, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(934, 419)
        Me.LayoutControl1.TabIndex = 12
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'ckLiquidar
        '
        Me.ckLiquidar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckLiquidar.Location = New System.Drawing.Point(472, 204)
        Me.ckLiquidar.Name = "ckLiquidar"
        Me.ckLiquidar.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckLiquidar.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.ckLiquidar.Properties.Appearance.Options.UseFont = True
        Me.ckLiquidar.Properties.Appearance.Options.UseForeColor = True
        Me.ckLiquidar.Properties.Caption = "Agreagar a liquidación"
        Me.ckLiquidar.Size = New System.Drawing.Size(151, 19)
        Me.ckLiquidar.StyleController = Me.LayoutControl1
        Me.ckLiquidar.TabIndex = 1023
        '
        'GridDetalle
        '
        Me.GridDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDetalle.Location = New System.Drawing.Point(12, 267)
        Me.GridDetalle.MainView = Me.GridView1
        Me.GridDetalle.Name = "GridDetalle"
        Me.GridDetalle.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ItemCuenta, Me.ItemCuentas, Me.cbOrdenCompra})
        Me.GridDetalle.Size = New System.Drawing.Size(910, 98)
        Me.GridDetalle.TabIndex = 1
        Me.GridDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.GridView1.GridControl = Me.GridDetalle
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowColumnResizing = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "No Cuenta"
        Me.GridColumn1.ColumnEdit = Me.ItemCuenta
        Me.GridColumn1.FieldName = "Cuenta"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'ItemCuenta
        '
        Me.ItemCuenta.AutoHeight = False
        Me.ItemCuenta.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemCuenta.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cuenta", 150, "Cuenta"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Display", 350, "Display")})
        Me.ItemCuenta.DisplayMember = "Cuenta"
        Me.ItemCuenta.Name = "ItemCuenta"
        Me.ItemCuenta.NullText = ""
        Me.ItemCuenta.PopupFormMinSize = New System.Drawing.Size(500, 0)
        Me.ItemCuenta.ShowFooter = False
        Me.ItemCuenta.ShowHeader = False
        Me.ItemCuenta.ValueMember = "Cuenta"
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Nombre Cuenta"
        Me.GridColumn2.ColumnEdit = Me.ItemCuentas
        Me.GridColumn2.FieldName = "Cuenta"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'ItemCuentas
        '
        Me.ItemCuentas.AutoHeight = False
        Me.ItemCuentas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemCuentas.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cuenta", "", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Display", 300, "Display")})
        Me.ItemCuentas.DisplayMember = "Display"
        Me.ItemCuentas.Name = "ItemCuentas"
        Me.ItemCuentas.NullText = ""
        Me.ItemCuentas.PopupFormMinSize = New System.Drawing.Size(300, 0)
        Me.ItemCuentas.ShowFooter = False
        Me.ItemCuentas.ShowHeader = False
        Me.ItemCuentas.ValueMember = "Cuenta"
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Creditos"
        Me.GridColumn3.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "Creditos"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Creditos", "{0:n2}")})
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Debitos"
        Me.GridColumn4.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "Debitos"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debitos", "{0:n2}")})
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn5.AppearanceHeader.Options.UseFont = True
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Observacion"
        Me.GridColumn5.FieldName = "Observacion"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "No Orden"
        Me.GridColumn6.ColumnEdit = Me.cbOrdenCompra
        Me.GridColumn6.FieldName = "NoOrden"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Width = 50
        '
        'cbOrdenCompra
        '
        Me.cbOrdenCompra.AutoHeight = False
        Me.cbOrdenCompra.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbOrdenCompra.Name = "cbOrdenCompra"
        Me.cbOrdenCompra.NullText = ""
        '
        'cmdguardar
        '
        Me.cmdguardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdguardar.Image = Global.SysContab.My.Resources.Resources.RibbonPrintPreview_SaveLarge
        Me.cmdguardar.Location = New System.Drawing.Point(716, 369)
        Me.cmdguardar.Name = "cmdguardar"
        Me.cmdguardar.Size = New System.Drawing.Size(102, 38)
        Me.cmdguardar.StyleController = Me.LayoutControl1
        Me.cmdguardar.TabIndex = 9
        Me.cmdguardar.Text = "&Guardar"
        '
        'cmbcentro
        '
        Me.cmbcentro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbcentro.Location = New System.Drawing.Point(800, 84)
        Me.cmbcentro.Name = "cmbcentro"
        Me.cmbcentro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbcentro.Properties.NullText = ""
        Me.cmbcentro.Properties.ShowFooter = False
        Me.cmbcentro.Properties.ShowHeader = False
        Me.cmbcentro.Size = New System.Drawing.Size(122, 20)
        Me.cmbcentro.StyleController = Me.LayoutControl1
        Me.cmbcentro.TabIndex = 10
        '
        'etSaldo
        '
        Me.etSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etSaldo.ForeColor = System.Drawing.Color.Firebrick
        Me.etSaldo.Location = New System.Drawing.Point(303, 132)
        Me.etSaldo.Name = "etSaldo"
        Me.etSaldo.Size = New System.Drawing.Size(320, 20)
        Me.etSaldo.TabIndex = 13
        Me.etSaldo.Text = "0.00"
        Me.etSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkAnticipos
        '
        Me.chkAnticipos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAnticipos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAnticipos.ForeColor = System.Drawing.Color.DarkRed
        Me.chkAnticipos.Location = New System.Drawing.Point(624, 12)
        Me.chkAnticipos.Name = "chkAnticipos"
        Me.chkAnticipos.Size = New System.Drawing.Size(71, 20)
        Me.chkAnticipos.TabIndex = 11
        Me.chkAnticipos.Text = "Anticipo"
        '
        'txtconcepto
        '
        Me.txtconcepto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtconcepto.Location = New System.Drawing.Point(116, 228)
        Me.txtconcepto.Name = "txtconcepto"
        Me.txtconcepto.Size = New System.Drawing.Size(806, 35)
        Me.txtconcepto.StyleController = Me.LayoutControl1
        Me.txtconcepto.TabIndex = 5
        '
        'txtiva
        '
        Me.txtiva.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtiva.Location = New System.Drawing.Point(471, 36)
        Me.txtiva.Name = "txtiva"
        Me.txtiva.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtiva.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtiva.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtiva.Properties.Appearance.Options.UseBackColor = True
        Me.txtiva.Properties.Appearance.Options.UseFont = True
        Me.txtiva.Properties.Appearance.Options.UseForeColor = True
        Me.txtiva.Properties.Appearance.Options.UseTextOptions = True
        Me.txtiva.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtiva.Properties.Mask.EditMask = "n2"
        Me.txtiva.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtiva.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtiva.Properties.ReadOnly = True
        Me.txtiva.Size = New System.Drawing.Size(125, 20)
        Me.txtiva.StyleController = Me.LayoutControl1
        Me.txtiva.TabIndex = 2
        '
        'cbFacturas
        '
        Me.cbFacturas.Location = New System.Drawing.Point(116, 132)
        Me.cbFacturas.Name = "cbFacturas"
        Me.cbFacturas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbFacturas.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Factura", "No. Factura"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Saldo", "Saldo")})
        Me.cbFacturas.Properties.DisplayMember = "Factura"
        Me.cbFacturas.Properties.NullText = ""
        Me.cbFacturas.Properties.ShowFooter = False
        Me.cbFacturas.Properties.ShowHeader = False
        Me.cbFacturas.Properties.ValueMember = "Factura"
        Me.cbFacturas.Size = New System.Drawing.Size(183, 20)
        Me.cbFacturas.StyleController = Me.LayoutControl1
        Me.cbFacturas.TabIndex = 11
        '
        'txtir
        '
        Me.txtir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtir.Location = New System.Drawing.Point(471, 60)
        Me.txtir.Name = "txtir"
        Me.txtir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtir.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtir.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtir.Properties.Appearance.Options.UseBackColor = True
        Me.txtir.Properties.Appearance.Options.UseFont = True
        Me.txtir.Properties.Appearance.Options.UseForeColor = True
        Me.txtir.Properties.Appearance.Options.UseTextOptions = True
        Me.txtir.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtir.Properties.Mask.EditMask = "n2"
        Me.txtir.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtir.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtir.Properties.ReadOnly = True
        Me.txtir.Size = New System.Drawing.Size(125, 20)
        Me.txtir.StyleController = Me.LayoutControl1
        Me.txtir.TabIndex = 4
        '
        'txtanombre
        '
        Me.txtanombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtanombre.Location = New System.Drawing.Point(116, 156)
        Me.txtanombre.Name = "txtanombre"
        Me.txtanombre.Size = New System.Drawing.Size(507, 20)
        Me.txtanombre.StyleController = Me.LayoutControl1
        Me.txtanombre.TabIndex = 1
        '
        'cmdsalir
        '
        Me.cmdsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdsalir.Image = Global.SysContab.My.Resources.Resources._115
        Me.cmdsalir.Location = New System.Drawing.Point(822, 369)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(100, 38)
        Me.cmdsalir.StyleController = Me.LayoutControl1
        Me.cmdsalir.TabIndex = 10
        Me.cmdsalir.Text = "&Salir"
        '
        'chkir
        '
        Me.chkir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.chkir.Location = New System.Drawing.Point(600, 60)
        Me.chkir.Name = "chkir"
        Me.chkir.Size = New System.Drawing.Size(92, 20)
        Me.chkir.TabIndex = 3
        Me.chkir.TabStop = False
        Me.chkir.Text = "Aplicar"
        '
        'txtletras
        '
        Me.txtletras.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtletras.Location = New System.Drawing.Point(116, 204)
        Me.txtletras.Name = "txtletras"
        Me.txtletras.Properties.ReadOnly = True
        Me.txtletras.Size = New System.Drawing.Size(352, 20)
        Me.txtletras.StyleController = Me.LayoutControl1
        Me.txtletras.TabIndex = 4
        '
        'txtalcaldia
        '
        Me.txtalcaldia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtalcaldia.Location = New System.Drawing.Point(471, 84)
        Me.txtalcaldia.Name = "txtalcaldia"
        Me.txtalcaldia.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtalcaldia.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalcaldia.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtalcaldia.Properties.Appearance.Options.UseBackColor = True
        Me.txtalcaldia.Properties.Appearance.Options.UseFont = True
        Me.txtalcaldia.Properties.Appearance.Options.UseForeColor = True
        Me.txtalcaldia.Properties.Appearance.Options.UseTextOptions = True
        Me.txtalcaldia.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtalcaldia.Properties.Mask.EditMask = "n2"
        Me.txtalcaldia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtalcaldia.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtalcaldia.Properties.ReadOnly = True
        Me.txtalcaldia.Size = New System.Drawing.Size(125, 20)
        Me.txtalcaldia.StyleController = Me.LayoutControl1
        Me.txtalcaldia.TabIndex = 6
        '
        'txtmonto
        '
        Me.txtmonto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmonto.Location = New System.Drawing.Point(743, 138)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtmonto.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmonto.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtmonto.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtmonto.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtmonto.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtmonto.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtmonto.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtmonto.Properties.Mask.EditMask = "n2"
        Me.txtmonto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtmonto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtmonto.Properties.ReadOnly = True
        Me.txtmonto.Size = New System.Drawing.Size(167, 20)
        Me.txtmonto.StyleController = Me.LayoutControl1
        Me.txtmonto.TabIndex = 6
        '
        'txtbalance
        '
        Me.txtbalance.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbalance.Location = New System.Drawing.Point(803, 12)
        Me.txtbalance.Name = "txtbalance"
        Me.txtbalance.Properties.Mask.EditMask = "n2"
        Me.txtbalance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtbalance.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtbalance.Properties.ReadOnly = True
        Me.txtbalance.Size = New System.Drawing.Size(119, 20)
        Me.txtbalance.StyleController = Me.LayoutControl1
        Me.txtbalance.TabIndex = 7
        '
        'cmbproveedor
        '
        Me.cmbproveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbproveedor.Location = New System.Drawing.Point(116, 108)
        Me.cmbproveedor.Name = "cmbproveedor"
        Me.cmbproveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbproveedor.Properties.NullText = ""
        Me.cmbproveedor.Properties.ShowFooter = False
        Me.cmbproveedor.Properties.ShowHeader = False
        Me.cmbproveedor.Size = New System.Drawing.Size(507, 20)
        Me.cmbproveedor.StyleController = Me.LayoutControl1
        Me.cmbproveedor.TabIndex = 0
        '
        'fecha
        '
        Me.fecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fecha.EditValue = Nothing
        Me.fecha.Location = New System.Drawing.Point(810, 60)
        Me.fecha.Name = "fecha"
        Me.fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.fecha.Size = New System.Drawing.Size(112, 20)
        Me.fecha.StyleController = Me.LayoutControl1
        Me.fecha.TabIndex = 9
        '
        'txtmonedabase
        '
        Me.txtmonedabase.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmonedabase.Location = New System.Drawing.Point(743, 186)
        Me.txtmonedabase.Name = "txtmonedabase"
        Me.txtmonedabase.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtmonedabase.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmonedabase.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtmonedabase.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtmonedabase.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtmonedabase.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtmonedabase.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtmonedabase.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtmonedabase.Properties.Mask.EditMask = "n2"
        Me.txtmonedabase.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtmonedabase.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtmonedabase.Properties.ReadOnly = True
        Me.txtmonedabase.Size = New System.Drawing.Size(167, 20)
        Me.txtmonedabase.StyleController = Me.LayoutControl1
        Me.txtmonedabase.TabIndex = 8
        '
        'txtnocheque
        '
        Me.txtnocheque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnocheque.Location = New System.Drawing.Point(810, 36)
        Me.txtnocheque.Name = "txtnocheque"
        Me.txtnocheque.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnocheque.Properties.Appearance.Options.UseFont = True
        Me.txtnocheque.Properties.Appearance.Options.UseTextOptions = True
        Me.txtnocheque.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtnocheque.Size = New System.Drawing.Size(112, 20)
        Me.txtnocheque.StyleController = Me.LayoutControl1
        Me.txtnocheque.TabIndex = 8
        '
        'txtmoneda
        '
        Me.txtmoneda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmoneda.Location = New System.Drawing.Point(743, 162)
        Me.txtmoneda.Name = "txtmoneda"
        Me.txtmoneda.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtmoneda.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmoneda.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtmoneda.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtmoneda.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtmoneda.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtmoneda.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtmoneda.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtmoneda.Properties.ReadOnly = True
        Me.txtmoneda.Size = New System.Drawing.Size(167, 20)
        Me.txtmoneda.StyleController = Me.LayoutControl1
        Me.txtmoneda.TabIndex = 7
        '
        'chkiva
        '
        Me.chkiva.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkiva.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.chkiva.Location = New System.Drawing.Point(600, 36)
        Me.chkiva.Name = "chkiva"
        Me.chkiva.Size = New System.Drawing.Size(92, 20)
        Me.chkiva.TabIndex = 3
        Me.chkiva.TabStop = False
        Me.chkiva.Text = "Aplicar"
        '
        'chkalcaldia
        '
        Me.chkalcaldia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkalcaldia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkalcaldia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.chkalcaldia.Location = New System.Drawing.Point(600, 84)
        Me.chkalcaldia.Name = "chkalcaldia"
        Me.chkalcaldia.Size = New System.Drawing.Size(92, 20)
        Me.chkalcaldia.TabIndex = 3
        Me.chkalcaldia.TabStop = False
        Me.chkalcaldia.Text = "Aplicar"
        '
        'txtruc
        '
        Me.txtruc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtruc.Location = New System.Drawing.Point(116, 180)
        Me.txtruc.Name = "txtruc"
        Me.txtruc.Size = New System.Drawing.Size(183, 20)
        Me.txtruc.StyleController = Me.LayoutControl1
        Me.txtruc.TabIndex = 2
        '
        'txtcedula
        '
        Me.txtcedula.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcedula.Location = New System.Drawing.Point(407, 180)
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Size = New System.Drawing.Size(216, 20)
        Me.txtcedula.StyleController = Me.LayoutControl1
        Me.txtcedula.TabIndex = 3
        '
        'cmbiva
        '
        Me.cmbiva.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbiva.Location = New System.Drawing.Point(116, 36)
        Me.cmbiva.Name = "cmbiva"
        Me.cmbiva.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbiva.Properties.NullText = ""
        Me.cmbiva.Properties.ReadOnly = True
        Me.cmbiva.Properties.ShowFooter = False
        Me.cmbiva.Properties.ShowHeader = False
        Me.cmbiva.Size = New System.Drawing.Size(351, 20)
        Me.cmbiva.StyleController = Me.LayoutControl1
        Me.cmbiva.TabIndex = 1
        '
        'cmbir
        '
        Me.cmbir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbir.Location = New System.Drawing.Point(116, 60)
        Me.cmbir.Name = "cmbir"
        Me.cmbir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbir.Properties.NullText = ""
        Me.cmbir.Properties.ReadOnly = True
        Me.cmbir.Properties.ShowFooter = False
        Me.cmbir.Properties.ShowHeader = False
        Me.cmbir.Size = New System.Drawing.Size(351, 20)
        Me.cmbir.StyleController = Me.LayoutControl1
        Me.cmbir.TabIndex = 3
        '
        'cmbalcaldia
        '
        Me.cmbalcaldia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbalcaldia.Location = New System.Drawing.Point(116, 84)
        Me.cmbalcaldia.Name = "cmbalcaldia"
        Me.cmbalcaldia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbalcaldia.Properties.NullText = ""
        Me.cmbalcaldia.Properties.ReadOnly = True
        Me.cmbalcaldia.Properties.ShowFooter = False
        Me.cmbalcaldia.Properties.ShowHeader = False
        Me.cmbalcaldia.Size = New System.Drawing.Size(351, 20)
        Me.cmbalcaldia.StyleController = Me.LayoutControl1
        Me.cmbalcaldia.TabIndex = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem24, Me.LayoutControlItem25, Me.LayoutControlItem26, Me.LayoutControlItem28, Me.LayoutControlItem29, Me.LayoutControlItem30, Me.LayoutControlGroup2, Me.LayoutControlItem19, Me.LayoutControlItem20, Me.LayoutControlItem18, Me.LayoutControlItem27, Me.EmptySpaceItem1, Me.EmptySpaceItem3, Me.EmptySpaceItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(934, 419)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cmbbancos
        Me.LayoutControlItem1.CustomizationFormText = "Banco:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(602, 24)
        Me.LayoutControlItem1.Text = "Banco:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(101, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmbiva
        Me.LayoutControlItem2.CustomizationFormText = "Cuenta IVA:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(459, 24)
        Me.LayoutControlItem2.Text = "Cuenta IVA:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(101, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmbir
        Me.LayoutControlItem3.CustomizationFormText = "Cuenta IR:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(459, 24)
        Me.LayoutControlItem3.Text = "Cuenta IR:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(101, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmbalcaldia
        Me.LayoutControlItem4.CustomizationFormText = "Cuenta ALMA:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(459, 24)
        Me.LayoutControlItem4.Text = "Cuenta ALMA:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(101, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.chkAnticipos
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(612, 0)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(75, 24)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(75, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(75, 24)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtiva
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(459, 24)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(129, 24)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(129, 24)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(129, 24)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtir
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(459, 48)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(129, 24)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(129, 24)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(129, 24)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtalcaldia
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(459, 72)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(129, 24)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(129, 24)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(129, 24)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.chkiva
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(588, 24)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(96, 24)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(96, 24)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(96, 24)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.chkir
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(588, 48)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(96, 24)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(96, 24)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(96, 24)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.chkalcaldia
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(588, 72)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(96, 24)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(96, 24)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(96, 24)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtbalance
        Me.LayoutControlItem12.CustomizationFormText = "Balance:"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(687, 0)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(227, 24)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(227, 24)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(227, 24)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.Text = "Balance:"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(101, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtnocheque
        Me.LayoutControlItem13.CustomizationFormText = "# Cheque:"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(694, 24)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(220, 24)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(220, 24)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(220, 24)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.Text = "# Cheque:"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(101, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.fecha
        Me.LayoutControlItem14.CustomizationFormText = "Fecha:"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(694, 48)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(220, 24)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(220, 24)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(220, 24)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.Text = "Fecha:"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(101, 13)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.cmbcentro
        Me.LayoutControlItem15.CustomizationFormText = "Centro:"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(684, 72)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(230, 24)
        Me.LayoutControlItem15.Text = "Centro:"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(101, 13)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.cmbproveedor
        Me.LayoutControlItem16.CustomizationFormText = "Pagar A:"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(615, 24)
        Me.LayoutControlItem16.Text = "Pagar A:"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(101, 13)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.cbFacturas
        Me.LayoutControlItem17.CustomizationFormText = "#Factura:"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(291, 24)
        Me.LayoutControlItem17.MinSize = New System.Drawing.Size(291, 24)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(291, 24)
        Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem17.Text = "#Factura:"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(101, 13)
        Me.LayoutControlItem17.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.etSaldo
        Me.LayoutControlItem24.CustomizationFormText = "LayoutControlItem24"
        Me.LayoutControlItem24.Location = New System.Drawing.Point(291, 120)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(324, 24)
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem24.TextVisible = False
        Me.LayoutControlItem24.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.txtletras
        Me.LayoutControlItem25.CustomizationFormText = "Monto en Letras:"
        Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 192)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(460, 24)
        Me.LayoutControlItem25.Text = "Monto en Letras:"
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(101, 13)
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.txtconcepto
        Me.LayoutControlItem26.CustomizationFormText = "Concepto:"
        Me.LayoutControlItem26.Location = New System.Drawing.Point(0, 216)
        Me.LayoutControlItem26.MaxSize = New System.Drawing.Size(0, 39)
        Me.LayoutControlItem26.MinSize = New System.Drawing.Size(119, 39)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(914, 39)
        Me.LayoutControlItem26.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem26.Text = "Concepto:"
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(101, 13)
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.Control = Me.cmdguardar
        Me.LayoutControlItem28.CustomizationFormText = "LayoutControlItem28"
        Me.LayoutControlItem28.Location = New System.Drawing.Point(704, 357)
        Me.LayoutControlItem28.MaxSize = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem28.MinSize = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem28.Name = "LayoutControlItem28"
        Me.LayoutControlItem28.Size = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem28.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem28.TextVisible = False
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.Control = Me.cmdsalir
        Me.LayoutControlItem29.CustomizationFormText = "LayoutControlItem29"
        Me.LayoutControlItem29.Location = New System.Drawing.Point(810, 357)
        Me.LayoutControlItem29.MaxSize = New System.Drawing.Size(104, 42)
        Me.LayoutControlItem29.MinSize = New System.Drawing.Size(104, 42)
        Me.LayoutControlItem29.Name = "LayoutControlItem29"
        Me.LayoutControlItem29.Size = New System.Drawing.Size(104, 42)
        Me.LayoutControlItem29.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem29.TextVisible = False
        '
        'LayoutControlItem30
        '
        Me.LayoutControlItem30.Control = Me.GridDetalle
        Me.LayoutControlItem30.CustomizationFormText = "LayoutControlItem30"
        Me.LayoutControlItem30.Location = New System.Drawing.Point(0, 255)
        Me.LayoutControlItem30.Name = "LayoutControlItem30"
        Me.LayoutControlItem30.Size = New System.Drawing.Size(914, 102)
        Me.LayoutControlItem30.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem30.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Montos"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem21, Me.LayoutControlItem22, Me.LayoutControlItem23})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(615, 96)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(299, 120)
        Me.LayoutControlGroup2.Text = "Montos"
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.txtmonto
        Me.LayoutControlItem21.CustomizationFormText = "Monto:"
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem21.MaxSize = New System.Drawing.Size(275, 24)
        Me.LayoutControlItem21.MinSize = New System.Drawing.Size(275, 24)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(275, 24)
        Me.LayoutControlItem21.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem21.Text = "Monto:"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(101, 13)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.txtmoneda
        Me.LayoutControlItem22.CustomizationFormText = "Moneda:"
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem22.MaxSize = New System.Drawing.Size(275, 24)
        Me.LayoutControlItem22.MinSize = New System.Drawing.Size(275, 24)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(275, 24)
        Me.LayoutControlItem22.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem22.Text = "Moneda:"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(101, 13)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.txtmonedabase
        Me.LayoutControlItem23.CustomizationFormText = "Monto Mondea Base:"
        Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem23.MaxSize = New System.Drawing.Size(275, 29)
        Me.LayoutControlItem23.MinSize = New System.Drawing.Size(275, 29)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(275, 30)
        Me.LayoutControlItem23.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem23.Text = "Monto Mondea Base:"
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(101, 13)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.txtruc
        Me.LayoutControlItem19.CustomizationFormText = "#RUC:"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem19.MaxSize = New System.Drawing.Size(291, 24)
        Me.LayoutControlItem19.MinSize = New System.Drawing.Size(291, 24)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(291, 24)
        Me.LayoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem19.Text = "#RUC:"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(101, 13)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.txtcedula
        Me.LayoutControlItem20.CustomizationFormText = "Cédula:"
        Me.LayoutControlItem20.Location = New System.Drawing.Point(291, 168)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(324, 24)
        Me.LayoutControlItem20.Text = "Cédula:"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(101, 13)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.txtanombre
        Me.LayoutControlItem18.CustomizationFormText = "A Nombre de:"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(615, 24)
        Me.LayoutControlItem18.Text = "A Nombre de:"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(101, 13)
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.ckLiquidar
        Me.LayoutControlItem27.CustomizationFormText = "LayoutControlItem27"
        Me.LayoutControlItem27.Location = New System.Drawing.Point(460, 192)
        Me.LayoutControlItem27.MaxSize = New System.Drawing.Size(155, 24)
        Me.LayoutControlItem27.MinSize = New System.Drawing.Size(155, 24)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(155, 24)
        Me.LayoutControlItem27.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem27.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 357)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(704, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(602, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(10, 24)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(684, 24)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(10, 48)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'FrmHacerCheques
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(934, 419)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "FrmHacerCheques"
        Me.Text = "Hacer Cheques"
        CType(Me.cmbbancos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.ckLiquidar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbcentro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtconcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtiva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbFacturas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtanombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtletras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtalcaldia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtbalance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbproveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmonedabase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnocheque.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtruc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcedula.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbiva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbalcaldia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private DT As DataTable
    Private TS As Double
    Dim dsCB As DataSet
    Public NCheque As String = "0"
    Public NBanco As Integer = 0
    Dim NoFactura As String = ""

    Dim NoComprob As Integer = 0
    Private DT_Distribucion As DataTable = New DataTable("Distribucion")

    Private Sub cmdsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsalir.Click
        Close()
    End Sub

    Private Sub FrmHacerCheques_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DT_Distribucion = CargaDistribucion(0, 0, 0)

        Dim CatalogoBancos As New VB.SysContab.Catalogo_BancosDB
        Dim Proveedores As New VB.SysContab.ProveedoresDB

        fecha.EditValue = Now.Date

        MostrarCombos(1)
        GridDetalle.DataSource = ObtieneDatos("SELECT CDET_Cuenta as Cuenta,CASE WHEN CDet_DC = 'D' THEN CDet_Importe ELSE 0.00 END as Debitos " & _
                                              ",CASE WHEN CDet_DC = 'D' THEN 0.00 ELSE CDet_Importe END as Creditos,CDet_Concepto as Observacion, " & _
                                              "0 NoOrden FROM ComprobantesDetalles WHERE CDet_NoChk = '" & IIf(txtnocheque.Text = vbNullString, "xxx", txtnocheque.Text) & "' AND Empresa = " & EmpresaActual)

        cmbcentro.Properties.DataSource = ObtieneDatos("SP_CentrosCosto " & EmpresaActual)
        cmbcentro.Properties.ValueMember = "Codigo"
        cmbcentro.Properties.DisplayMember = "Nombre"
        cmbcentro.Properties.PopulateColumns()
        cmbcentro.Properties.Columns("Codigo").Visible = False

        cmbbancos.Properties.DataSource = ObtieneDatos("SP_GetCatalogoBancos " & EmpresaActual)
        cmbbancos.Properties.ValueMember = "Cuenta"
        cmbbancos.Properties.DisplayMember = "Nombre"
        cmbbancos.Properties.PopulateColumns()

        cmbbancos.Properties.Columns("Codigo").Visible = False
        cmbbancos.Properties.Columns("Orden").Visible = False

        cmbiva.Properties.DataSource = ObtieneDatos("SP_CatalogoList 'A'," & EmpresaActual)
        cmbiva.Properties.ValueMember = "Cuenta"
        cmbiva.Properties.DisplayMember = "Nombre2"
        cmbiva.Properties.PopulateColumns()
        cmbiva.Properties.Columns("Nombre").Visible = False
        cmbiva.Properties.Columns("Orden").Visible = False

        cmbalcaldia.Properties.DataSource = ObtieneDatos("SP_CatalogoList 'A'," & EmpresaActual)
        cmbalcaldia.Properties.ValueMember = "Cuenta"
        cmbalcaldia.Properties.DisplayMember = "Nombre2"
        cmbalcaldia.Properties.PopulateColumns()
        cmbalcaldia.Properties.Columns("Nombre").Visible = False
        cmbalcaldia.Properties.Columns("Orden").Visible = False

        cmbir.Properties.DataSource = ObtieneDatos("SP_CatalogoList 'A'," & EmpresaActual)
        cmbir.Properties.ValueMember = "Cuenta"
        cmbir.Properties.DisplayMember = "Nombre2"
        cmbir.Properties.PopulateColumns()
        cmbir.Properties.Columns("Nombre").Visible = False
        cmbir.Properties.Columns("Orden").Visible = False

        cmbproveedor.Properties.DataSource = Proveedores.PagarList().Tables("Proveedores")
        cmbproveedor.Properties.ValueMember = "Codigo"
        cmbproveedor.Properties.DisplayMember = "Nombre"
        cmbproveedor.Properties.PopulateColumns()
        cmbproveedor.Properties.Columns("Codigo").Visible = False
        cmbproveedor.Properties.Columns("Cuenta").Visible = False
        cmbproveedor.Properties.Columns("Orden").Visible = False
        cmbproveedor.Properties.Columns("Tipo").Visible = False
        cmbproveedor.ItemIndex = 0

        Try
            cmbbancos.ItemIndex = 0
        Catch ex As Exception
        End Try

        If NCheque <> "0" And NBanco <> 0 Then
            cmdguardar.Visible = False
            Dim DT As DataTable = ObtieneDatos("SP_GetDetalleCheque '" & NCheque & "'," & NBanco & "," & EmpresaActual)
            GridDetalle.DataSource = DT
            cmbbancos.EditValue = DT.Rows(0).Item("CuentaBanco")

            Try
                If DT.Rows(0).Item("IVA") > 0 Then
                    chkiva.Checked = True
                    cmbiva.EditValue = DT.Rows(0).Item("CuentaIVA")
                    txtiva.Text = DT.Rows(0).Item("IVA")
                End If
            Catch ex As Exception
                chkiva.Checked = False
                txtiva.Text = "0.00"
            End Try

            Try
                If DT.Rows(0).Item("IR") > 0 Then
                    chkir.Checked = True
                    cmbir.EditValue = DT.Rows(0).Item("CuentaIR")
                    txtir.Text = DT.Rows(0).Item("IR")
                End If
            Catch ex As Exception
                chkir.Checked = False
                txtir.Text = "0.00"
            End Try

            Try
                If DT.Rows(0).Item("Alcaldia") > 0 Then
                    chkalcaldia.Checked = True
                    cmbalcaldia.EditValue = DT.Rows(0).Item("CuentaAlcaldia")
                    txtalcaldia.Text = DT.Rows(0).Item("Alcaldia")
                End If
            Catch ex As Exception
                chkalcaldia.Checked = False
                txtalcaldia.Text = "0.00"
            End Try


            If DT.Rows(0).Item("Proveedor") = 0 Then
                txtanombre.Text = DT.Rows(0).Item("ANombre").ToString
                txtruc.Text = DT.Rows(0).Item("Ruc").ToString
                txtcedula.Text = DT.Rows(0).Item("Cedula").ToString
            Else
                cmbproveedor.EditValue = DT.Rows(0).Item("Proveedor")
            End If
            txtconcepto.Text = DT.Rows(0).Item("Concepto")
            cmbcentro.EditValue = DT.Rows(0).Item("Centro")
        End If
        'If VerifyLiqOption() Then ckLiquidar.Visible = True
    End Sub

    Private Sub chkiva_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkiva.CheckedChanged
        txtiva.Properties.ReadOnly = Not sender.checked
        cmbiva.Properties.ReadOnly = Not sender.checked
        txtiva.Text = ""
        cmbiva.EditValue = Nothing
        cmbiva.Focus()
    End Sub

    Private Sub chkir_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkir.CheckedChanged
        txtir.Properties.ReadOnly = Not sender.checked
        cmbir.Properties.ReadOnly = Not sender.checked
        txtir.Text = ""
        cmbir.EditValue = Nothing
        cmbir.Focus()
    End Sub

    Private Sub chkalcaldia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkalcaldia.CheckedChanged
        txtalcaldia.Properties.ReadOnly = Not sender.checked
        cmbalcaldia.Properties.ReadOnly = Not sender.checked
        txtalcaldia.Text = ""
        cmbalcaldia.EditValue = Nothing
        cmbalcaldia.Focus()
    End Sub

    Private Sub cmbbancos_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbancos.EditValueChanged
        Dim CatBancos As New VB.SysContab.Catalogo_BancosDB
        Dim Comprobantes As New VB.SysContab.ComprobanteDB
        Dim dsCB As DataSet

        dsCB = CatBancos.CatalogoBancosXCuenta(Me.cmbbancos.EditValue)
        Me.txtnocheque.Text = CatBancos.GetCheque(dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Banco"), dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Numero_Cuenta")).ToString
        Me.txtbalance.Text = CDbl(IsNull(Comprobantes.SaldoxCuenta(Me.cmbbancos.EditValue, VB.SysContab.PeriodosDB.Activo(Me.fecha.DateTime.Date)), 0))
        Me.txtmoneda.Text = dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("mon_descripcion")
    End Sub

    Private Sub cmbproveedor_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbproveedor.EditValueChanged
        txtruc.Text = ""
        txtcedula.Text = ""
        txtanombre.Text = ""

        If sender.editvalue = 0 Then
            txtruc.Properties.ReadOnly = False
            txtcedula.Properties.ReadOnly = False
            txtanombre.Properties.ReadOnly = False
        Else
            txtruc.Text = cmbproveedor.GetColumnValue("Ruc")
            txtcedula.Text = cmbproveedor.GetColumnValue("Cedula")
            txtanombre.Text = cmbproveedor.GetColumnValue("Name")
            'txtruc.Properties.ReadOnly = True
            'txtcedula.Properties.ReadOnly = True
            'txtanombre.Properties.ReadOnly = True
        End If

        Try
            'Mostrar Facturas Pendientes del Proveedor  
            Me.cbFacturas.Properties.DataSource = ObtieneDatos("SELECT '--- Seleccione Factura ---' Factura, 0 Saldo UNION Select Factura_ID Factura,Factura_Saldo Saldo from Facturas_Compras WHERE Fact_Cancelado = 0 AND Factura_Estado = 'F' AND Proveedor_ID = " & Me.cmbproveedor.EditValue & " AND Empresa_ID = " & EmpresaActual).DefaultView
            Me.cbFacturas.EditValue = "--- Seleccione Factura ---"
            NoFactura = ""
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtmonto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmonto.EditValueChanged
        Dim TasaCambio As New VB.SysContab.Tasa_CambioDB
        Dim CatBancos As New VB.SysContab.Catalogo_BancosDB

        dsCB = CatBancos.CatalogoBancosXCuenta(Me.cmbbancos.EditValue)

        txtletras.Text = VB.SysContab.Rutinas.Letras(IsNull(txtmonto.EditValue, 0), txtmoneda.Text)
        If MonedaBase = dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("mon_codigo") Then
            'Moneda de la Cuenta = Moneda Base 
            Me.txtmonedabase.Text = Me.txtmonto.Text
            TS = 1
        Else
            'TasaCambioDia
            TS = TasaCambio.TasaCambioDia(Me.fecha.DateTime.Day, fecha.DateTime.Month, fecha.DateTime.Year, MonedaBase, dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("mon_codigo"))
            Me.txtmonedabase.Text = CDbl(CDbl(Me.txtmonto.Text) * TS).ToString(Round)
        End If

    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        If GridView1.FocusedRowHandle < 0 Then Exit Sub

        Try
            'If dgFacturacionCliente.CurrentRowIndex >= 0 Then
            Dim forma As New FrmDetalleRequisas
            'With dgFacturacionCliente
            With GridView1
                forma.Cuenta = .GetRowCellValue(.FocusedRowHandle, "Cuenta")

                Dim Importe As Double = Math.Round(IIf(CDbl(IsNull(.GetFocusedRowCellValue("Debitos"), 0.0)) = 0, CDbl(IsNull(.GetFocusedRowCellValue("Creditos"), 0)), CDbl(IsNull(.GetFocusedRowCellValue("Debitos"), 0.0))) * TS, 2)
                Dim DC As String = IIf(CDbl(IsNull(.GetFocusedRowCellValue("Debitos"), 0.0)) = 0, "C", "D")

                forma.Monto = Importe
                forma.Tipo = DC
                forma.Periodo = VB.SysContab.PeriodosDB.Activo(Me.fecha.DateTime)
                forma.CompNo = NoComprob
                forma.Cuenta = .GetRowCellValue(.FocusedRowHandle, "Cuenta")
                forma.Mes = fecha.DateTime.Month


                forma.Mostrar(DT_Distribucion)
                DT_Distribucion.DefaultView.RowFilter = ""
            End With
            'End If
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GridView1_ShowingEditor(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridView1.ShowingEditor
        If GridView1.FocusedColumn.FieldName = "Creditos" Then
            If IsNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Debitos"), 0) > 0 Then e.Cancel = True
        End If
        If GridView1.FocusedColumn.FieldName = "Debitos" Then
            If IsNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Creditos"), 0) > 0 Then e.Cancel = True
        End If
    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If e.Column.FieldName = "Debitos" Or e.Column.FieldName = "Creditos" Then
            GridView1.UpdateSummary()
            CalcularMonto()
        End If
    End Sub

    Private Sub CalcularMonto()
        Try
            txtmonto.Text = IsNull(GridView1.Columns("Debitos").SummaryItem.SummaryValue, 0) - IsNull(GridView1.Columns("Creditos").SummaryItem.SummaryValue, 0) _
                    + IsNull(txtiva.EditValue, 0) - IsNull(txtir.EditValue, 0) - IsNull(txtalcaldia.EditValue, 0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridView1_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView1.RowUpdated
        GridView1.UpdateSummary()
        CalcularMonto()
    End Sub

    Private Sub GridView1_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView1.ValidateRow
        If IsNull(GridView1.GetRowCellValue(e.RowHandle, "Cuenta"), "0") = "0" Or (IsNull(GridView1.GetRowCellValue(e.RowHandle, "Creditos"), 0) = 0 And IsNull(GridView1.GetRowCellValue(e.RowHandle, "Debitos"), 0) = 0) Then
            e.ErrorText = "Debe existir al menos un registro de credito/debito" & vbCrLf
            e.Valid = False
        End If
    End Sub

    Private Sub cmdguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdguardar.Click
        'Verificar Cierre del Día
        '---------------------------------------------------------------------
        If Not VerificarCierre(Me.fecha.DateTime.Date) Then
            ' XtraMsg("Ya se ha cerrado el dia", MessageBoxIcon.Error)
            Exit Sub
        End If
        '---------------------------------------------------------------------

        If cmbbancos.EditValue = Nothing Then
            XtraMsg("Seleccione la cuenta de banco")
            cmbbancos.Focus()
            Exit Sub
        End If

        If chkiva.CheckState And (cmbiva.EditValue = Nothing Or txtiva.EditValue Is Nothing) Then
            XtraMsg("Complete la informacion del IVA")
            cmbiva.Focus()
            Exit Sub
        End If

        If chkir.CheckState And (cmbir.EditValue Is Nothing Or txtir.EditValue Is Nothing) Then
            XtraMsg("Complete la informacion del IR")
            cmbir.Focus()
            Exit Sub
        End If

        If chkalcaldia.CheckState And (cmbalcaldia.EditValue Is Nothing Or txtalcaldia.EditValue Is Nothing) Then
            XtraMsg("Complete la informacion de la Alcaldia")
            cmbalcaldia.Focus()
            Exit Sub
        End If

        If GridView1.DataRowCount - 1 < 0 Then
            XtraMsg("Complete la informacion de las cuentas de gasto")
            GridView1.Focus()
            Exit Sub
        End If

        If cmbproveedor.ItemIndex > 0 And cmbproveedor.EditValue Is Nothing Then
            XtraMsg("Seleccione a quien se paga el cheque")
            cmbproveedor.Focus()
            Exit Sub
        End If

        If cmbproveedor.ItemIndex = 0 And txtanombre.Text.Trim.Length = 0 Then
            XtraMsg("Escriba el nombre")
            txtanombre.Focus()
            Exit Sub
        End If

        'If cmbcentro.EditValue = Nothing Then
        '    MsgBox("Seleccione el centro de costo", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        If IsNull(txtmonto.EditValue, 0) <= 0 Then
            XtraMsg("No puede pagar un valo menor que cero (0)", MessageBoxIcon.Error)
            txtmonto.Focus()
            Exit Sub
        End If
        '
        If chkAnticipos.Checked Then
            If cmbproveedor.EditValue Is Nothing Or cmbproveedor.ItemIndex = 0 Then
                XtraMsg("Seleccione al Proveedor que dese aplicar el Anticipo!", MessageBoxIcon.Warning)
                cmbproveedor.Focus()
                Exit Sub
            End If
        End If

        '******** VERIFICAR DISTRIBUCION ***********************************
        For i As Integer = 0 To GridView1.DataRowCount - 1
            Dim CTemp As String = vbNullString
            Try
                CTemp = ObtieneDatos("SELECT CuentaContable FROM RubrosGastos WHERE Activo = 1 AND" _
                                     + " CuentaContable = '" & GridView1.GetRowCellValue(i, "Cuenta") & "'" _
                                     + " AND Empresa = " & EmpresaActual).Rows(0).Item(0)
            Catch ex As Exception
                CTemp = "xxx"
            End Try

            If CTemp <> "xxx" And CTemp <> vbNullString Then
                '
                If VerificaDistribucion(CTemp) = False And ObligarDistribucion = True Then
                    XtraMsg("La Cuenta " & GridView1.GetRowCellValue(i, "Cuenta").ToString & " Seleccionada es de Distribución, Favor Distribuirla " & vbCrLf & _
                           "ó Verifique el Detalle de la Distribución.", MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If
        Next
        '******** FIN VERIFICAR DISTRIBUCION *****************************

        If Not XtraMsg2("¿ Esta Seguro que la Información Registrada en el Cheque #: " & Me.txtnocheque.Text & " a Nombre de " & Me.txtanombre.Text & " es Correcta ?") Then
            Exit Sub
        End If

        Dim OrdenSelected As Integer = 0
        For i As Integer = 0 To GridView1.DataRowCount - 1
            If IsNull(GridView1.GetRowCellValue(i, "NoOrden"), 0) <> 0 Then OrdenSelected += 1
        Next
        If ckLiquidar.Checked And OrdenSelected = 0 Then
            XtraMsg("Favor seleccione al menos un No. de pedido.")
            Exit Sub
        End If

        If GuardarComprobante() = True Then
            Close()
        End If

    End Sub

    Private Function VerificaDistribucion(ByVal Cuenta As String) As Boolean
        Dim tmp As Boolean = False

        If DT_Distribucion Is Nothing Then
            Return False
        End If

        For i As Integer = 0 To DT_Distribucion.Rows.Count - 1
            If Cuenta = DT_Distribucion.Rows(i).Item("Cuenta") Then
                tmp = True
                Exit For
            End If
        Next

        Return tmp
    End Function

    Private Function GuardarComprobante() As Boolean

        Dim r As New VB.SysContab.Rutinas
        Dim PeriodosDB As New VB.SysContab.PeriodosDB
        Dim Comprobantes As New VB.SysContab.ComprobanteDB
        Dim TipoComprobante As Integer = IsNull(ObtieneDatos("_TipoComprobantesCheque " & EmpresaActual).Rows(0).Item("TipComp_Id"), 0)

        If TipoComprobante = 0 Then
            MsgBox("No ha definido el tipo de comprobante de cheque", MsgBoxStyle.Information)
            Return False
            Exit Function
        End If

        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction()

        Try
            'NoComprob = Comprobantes.AddComprobante(Me.cbTipoComp.SelectedValue, ts, txtConcepto.Text, VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MonedaBase, PeriodosDB.Activo, dtpFecha.Value, 0, Me.txtNombre.Text, False, Me.cbPagar.SelectedValue, Me.txtRuc.Text, 2, "", VB.SysContab.Rutinas.Fecha, 0)
            NoComprob = VB.SysContab.ComprobanteDB.AddComprobante(TipoComprobante, TS, txtconcepto.Text,
            dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("mon_codigo"), VB.SysContab.PeriodosDB.Activo(fecha.DateTime.Date),
            fecha.DateTime.Date, 0, IIf(IsNull(cmbproveedor.EditValue, 0) = 0, txtanombre.Text, cmbproveedor.GetColumnValue("Name")), False, IsNull(cmbproveedor.EditValue, 0), Me.txtruc.Text, 2, NoFactura,
            VB.SysContab.Rutinas.Fecha, 0, OrigenComprobantes.CHEQUE_DIRECTO, txtcedula.Text, IsNull(cmbcentro.EditValue, 0), IIf(Me.chkAnticipos.Checked, 1, 0))
            '
            'Dim NoComprob As Double = Comprobantes.AddComprobante(Me.cbTipoComp.SelectedValue, 1, txtConcepto.Text, VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MonedaBase, PeriodosDB.Activo, dtpFecha.Value, 0, Me.txtNombre.Text, False, Me.cbPagar.SelectedValue, Me.txtRuc.Text)

            If Trim(txtnocheque.EditValue) <> "" Then
                If IsNumeric(txtnocheque.EditValue) Then VB.SysContab.ComprobanteDB.ActualizarCheque(cmbbancos.EditValue, txtnocheque.Text)
            End If

            'Agrega la cuenta del banco
            VB.SysContab.ComprobanteDB.AddComprobanteDetalles(NoComprob, cmbbancos.EditValue, cmbbancos.GetColumnValue("Descripcion"), Math.Round(CDbl(txtmonedabase.EditValue), 2),
            txtnocheque.Text, TipoComprobante, "C", IIf(NoFactura = "", 0, NoFactura), 0, fecha.DateTime.Date, 0)

            'Agrega la cuenta del iva si existe
            If chkiva.Checked Then VB.SysContab.ComprobanteDB.AddComprobanteDetalles(NoComprob, cmbiva.EditValue, "IVA", Math.Round(CDbl(txtiva.EditValue * TS), 2),
                txtnocheque.Text, TipoComprobante, "D", IIf(NoFactura = "", 0, NoFactura), 0, fecha.DateTime.Date, 1, 1)

            'Agrega la cuenta del ir si existe
            If chkir.Checked Then VB.SysContab.ComprobanteDB.AddComprobanteDetalles(NoComprob, cmbir.EditValue, "IR", Math.Round(CDbl(txtir.EditValue * TS), 2),
            txtnocheque.Text, TipoComprobante, "C", IIf(NoFactura = "", 0, NoFactura), 0, fecha.DateTime.Date, 1, 2)

            'Agrega la cuenta del alcaldia si existe
            If chkalcaldia.Checked Then VB.SysContab.ComprobanteDB.AddComprobanteDetalles(NoComprob, cmbalcaldia.EditValue, "Impuesto Alcaldia", Math.Round(CDbl(txtalcaldia.EditValue * TS), 2),
            txtnocheque.Text, TipoComprobante, "C", IIf(NoFactura = "", 0, NoFactura), 0, fecha.DateTime.Date, 1, 3)

            For i As Integer = 0 To GridView1.DataRowCount - 1
                Dim Importe As Double = 0
                Dim DC As String

                If IsNull(GridView1.GetRowCellValue(i, "Creditos"), 0) = 0 Then
                    Importe = Math.Round(CDbl(GridView1.GetRowCellValue(i, "Debitos") * TS), 2)
                    DC = "D"
                Else
                    Importe = Math.Round(CDbl(GridView1.GetRowCellValue(i, "Creditos") * TS), 2)
                    DC = "C"
                End If

                VB.SysContab.ComprobanteDB.AddComprobanteDetalles(NoComprob, GridView1.GetRowCellValue(i, "Cuenta"), _
                IsNull(GridView1.GetRowCellValue(i, "Observacion"), ""), _
                Importe, txtnocheque.Text, TipoComprobante, _
                DC, IIf(NoFactura = "", 0, NoFactura), 0, fecha.DateTime.Date, 1, IIf(Me.chkAnticipos.Checked And DC = "D", 4, 0))
            Next

            'If NoFactura <> "" Then
            '    Dim tFact As DataTable = ObtieneDatosTrans("SELECT Comp_No,Per_Id,Comp_Fecha,Mes FROM Comprobantes WHERE Factura = '" & NoFactura & "' AND Proveedor = " & Me.cmbproveedor.EditValue & " and Empresa = " & EmpresaActual)

            '    If tFact.Rows.Count > 0 Then
            '        VB.SysContab.ComprobanteDB.CancelarFactura(NoFactura, Me.cmbproveedor.EditValue, 1)
            '        VB.SysContab.ComprobanteDB.PagosFactura(tFact.Rows.Item(0)("Comp_No"), tFact.Rows.Item(0)("Per_Id"), tFact.Rows.Item(0)("Comp_Fecha"), CDbl(Me.txtmonedabase.Text), NoComprob, PeriodosDB.Activo(fecha.DateTime.Date), fecha.DateTime.Date, NoFactura, Me.cmbproveedor.EditValue, NoComprob)
            '    End If
            'End If

            'If VerifyLiqOption() Then
            '    If ckLiquidar.Checked Then
            '        Dim ComprobanteID As Integer = ObtieneDatosTrans("SELECT ComprobanteID FROM Comprobantes c WHERE c.Comp_No =" & NoComprob & _
            '                                                    " AND c.Empresa = " & EmpresaActual & "AND Per_ID = " & PeriodosDB.Activo(fecha.DateTime.Date) & _
            '                                                    " AND c.Mes = " & fecha.DateTime.Month).Rows(0).Item(0)
            '        For j As Integer = 0 To GridView1.DataRowCount - 1
            '            If IsNull(GridView1.GetRowCellValue(j, "NoOrden"), 0) <> 0 Then
            '                If Not GuardaDatosTrans("SPJLiqMTAddDetalle " & GridView1.GetRowCellValue(j, "NoOrden") & "," & 5 & "," & ComprobanteID & ",'" & GridView1.GetRowCellValue(j, "Cuenta") & _
            '                              "'," & IIf(GridView1.GetRowCellValue(j, "Debito") = 0, GridView1.GetRowCellValue(j, "Credito"), GridView1.GetRowCellValue(j, "Debito")) & _
            '                                                                       "," & 0 & "," & EmpresaActual) Then

            '                    DevExpress.XtraEditors.XtraMessageBox.Show("ERROR al Guardar Datos de Liquidación", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '                    VB.SysContab.Rutinas.ErrorTransaccion()
            '                    Exit Function
            '                End If
            '            End If
            '        Next
            '    End If
            'End If


            VB.SysContab.Rutinas.okTransaccion()
            ' SetTiempos(OrigenComprobantes.CHEQUE, funciones.Tiempos.TiempoFin, Now, funciones.Eventos.Guarda, txtnocheque.Text)

            '----------------------
            'Guarda la Distribucion
            '----------------------

            GuardaDistribucion(DT_Distribucion, fecha.DateTime.Date, NoComprob)
            'CargaDistribucion(fecha.DateTime.Month, NoComprob, PeriodosDB.Activo(fecha.DateTime.Date))
            '--------------------------
            'Fin de Guarda Distribucion
            '--------------------------

            Return True
        Catch Mensaje As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            XtraMsg("ERROR: " & vbCrLf & Mensaje.Message, MessageBoxIcon.Error)
            Return False
            Exit Function
        End Try
    End Function

    Private Sub txtiva_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtiva.EditValueChanged, txtir.EditValueChanged, txtalcaldia.EditValueChanged
        CalcularMonto()
    End Sub

    Private Sub cbFacturas_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFacturas.EditValueChanged
        Try
            Dim s As Double = Me.cbFacturas.GetColumnValue("Saldo")
            Me.etSaldo.Text = s.ToString(Round)
            NoFactura = Me.cbFacturas.EditValue
        Catch ex As Exception
        End Try
    End Sub

    Private Sub chkAnticipos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAnticipos.Click
        ' MostrarCombos(IIf(Me.chkAnticipos.Checked, 2, 1))
    End Sub

    Sub MostrarCombos(ByVal op As Integer)
        DT = Nothing

        If op = 1 Then  ' Mostrar Todas Las Cuentas
            DT = ObtieneDatos("SP_CatalogoList 'A'," & EmpresaActual)
            'GridDetalle.DataSource = ObtieneDatos("SELECT CDET_Cuenta as Cuenta,CASE WHEN CDet_DC = 'D' THEN CDet_Importe ELSE 0.00 END as Debitos,CASE WHEN CDet_DC = 'D' THEN 0.00 ELSE CDet_Importe END as Creditos,CDet_Concepto as Observacion FROM ComprobantesDetalles WHERE CDet_NoChk = '" & IIf(txtnocheque.Text = vbNullString, "xxx", txtnocheque.Text) & "'")
        ElseIf op = 2 Then  ' Mostrar Cuentas Marcadas Como Anticipo
            DT = ObtieneDatos("_CatalogoList_Anticipos 'A'," & EmpresaActual)
            GridDetalle.DataSource = ObtieneDatos("SELECT CDET_Cuenta as Cuenta,CASE WHEN CDet_DC = 'D' THEN CDet_Importe ELSE 0.00 END as Debitos,CASE WHEN CDet_DC = 'D' THEN 0.00 ELSE CDet_Importe END as Creditos,CDet_Concepto as Observacion FROM ComprobantesDetalles WHERE CDet_NoChk = '" & IIf(txtnocheque.Text = vbNullString, "xxx", txtnocheque.Text) & "'")
        End If

        ItemCuenta.DataSource = DT
        ItemCuenta.DisplayMember = "Cuenta"
        ItemCuenta.ValueMember = "Cuenta"
        ItemCuenta.PopulateColumns()

        ItemCuentas.DataSource = DT
        ItemCuentas.DisplayMember = "Nombre"
        ItemCuentas.ValueMember = "Cuenta"
        ItemCuentas.PopulateColumns()

        For i As Integer = 2 To ItemCuenta.Columns.Count - 1
            ItemCuentas.Columns(i).Visible = False
            ItemCuenta.Columns(i).Visible = False
        Next
        'ItemCuenta.Columns(1).Visible = False
        ItemCuentas.Columns(0).Visible = False
    End Sub

    Private Sub chkAnticipos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAnticipos.CheckedChanged
        'Dim tConfig As DataTable = ObtieneDatos("SELECT * from Micros_Configuraciones")
        'If tConfig.Rows.Item(0)("CttaAnticipos").ToString.Length = 0 Then
        '    MsgBox("No Existe Cuenta de Anticipos Configurada", MsgBoxStyle.Exclamation, "Hacer Cheques")
        '    Exit Sub
        'End If

        ''Dim Cuenta As String = tConfig.Rows.Item(0)("CttaAnticipos")

        'If Me.chkAnticipos.Checked Then
        '    GridDetalle.DataSource = ObtieneDatos("SELECT '" & Cuenta & "' as Cuenta,0.00 as Debitos,NULL as Creditos,'Anticipo a Facturas' as Observacion")
        'Else
        '    GridDetalle.DataSource = ObtieneDatos("SELECT CDET_Cuenta as Cuenta,CASE WHEN CDet_DC = 'D' THEN CDet_Importe ELSE 0.00 END as Debitos,CASE WHEN CDet_DC = 'D' THEN 0.00 ELSE CDet_Importe END as Creditos,CDet_Concepto as Observacion FROM ComprobantesDetalles WHERE CDet_NoChk = '" & IIf(txtnocheque.Text = vbNullString, "xxx", txtnocheque.Text) & "'")
        'End If
    End Sub

    Private Sub GridView1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If Me.GridView1.DataRowCount = 0 Then Exit Sub
        If e.KeyCode = Keys.Delete Then
            Me.GridView1.DeleteSelectedRows()
        End If
    End Sub

    Private Sub ckLiquidar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckLiquidar.CheckedChanged
        If ckLiquidar.Checked Then
            GridView1.Columns("NoOrden").Visible = True : GridView1.Columns("NoOrden").VisibleIndex = 5
            cbOrdenCompra.DataSource = ObtieneDatos("SPJLiqcbTipo " & 1 & "," & EmpresaActual)
            cbOrdenCompra.DisplayMember = "NoOrden"
            cbOrdenCompra.ValueMember = "LiqID"
            cbOrdenCompra.PopulateColumns()
            cbOrdenCompra.Columns(0).Visible = False
        Else
            GridView1.Columns("NoOrden").Visible = False
        End If
    End Sub
End Class









