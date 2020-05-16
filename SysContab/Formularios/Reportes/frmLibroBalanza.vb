
Public Class frmLibroBalanza
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmLibroBalanza = Nothing
    Private i As Integer
    Dim Catalogo As New VB.SysContab.CatalogoDB()
    Dim Grupos As New VB.SysContab.GruposDB()
    Dim Periodos As New VB.SysContab.PeriodosDB()
    Dim TComprobantes As New VB.SysContab.ComprobanteDB()
    Dim Libros As New VB.SysContab.LibrosDB()
    Dim r As New VB.SysContab.Rutinas()
    Dim tcuenta As String
    Dim Empresa As New VB.SysContab.EmpresasDetails()
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents dtpHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpDesde As DevExpress.XtraEditors.DateEdit
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
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Dim Empresas As New VB.SysContab.EmpresasDB()

    Public Shared Function Instance() As frmLibroBalanza
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmLibroBalanza()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents cbTCuentas As System.Windows.Forms.ComboBox
    Friend WithEvents cbNiveles As System.Windows.Forms.ComboBox
    Friend WithEvents chkZeros As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chkSincuenta As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbMonedaCambio As System.Windows.Forms.ComboBox
    Friend WithEvents cbCtaDistribucion As System.Windows.Forms.ComboBox
    Friend WithEvents cbCatalogo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents vCatalogo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbSAnterior As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbMovimientos As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbSaldoActual As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmdNew As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLibroBalanza))
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cbSaldoActual = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.dtpHasta = New DevExpress.XtraEditors.DateEdit()
        Me.cbMovimientos = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbCatalogo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.vCatalogo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbSAnterior = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.dtpDesde = New DevExpress.XtraEditors.DateEdit()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.cbCtaDistribucion = New System.Windows.Forms.ComboBox()
        Me.cbMonedaCambio = New System.Windows.Forms.ComboBox()
        Me.chkSincuenta = New System.Windows.Forms.CheckBox()
        Me.cbNiveles = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbTCuentas = New System.Windows.Forms.ComboBox()
        Me.chkZeros = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdNew = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cbSaldoActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMovimientos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSAnterior.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(516, 229)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Crimson
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit1.Properties.Caption = "Incluir Cierre Fiscal"
        Me.CheckEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.CheckEdit1.Size = New System.Drawing.Size(154, 22)
        Me.CheckEdit1.StyleController = Me.LayoutControl1
        Me.CheckEdit1.TabIndex = 18
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cbSaldoActual)
        Me.LayoutControl1.Controls.Add(Me.CheckEdit1)
        Me.LayoutControl1.Controls.Add(Me.dtpHasta)
        Me.LayoutControl1.Controls.Add(Me.cbMovimientos)
        Me.LayoutControl1.Controls.Add(Me.cbCatalogo)
        Me.LayoutControl1.Controls.Add(Me.cbSAnterior)
        Me.LayoutControl1.Controls.Add(Me.dtpDesde)
        Me.LayoutControl1.Controls.Add(Me.txtTitulo)
        Me.LayoutControl1.Controls.Add(Me.cbCtaDistribucion)
        Me.LayoutControl1.Controls.Add(Me.cbMonedaCambio)
        Me.LayoutControl1.Controls.Add(Me.chkSincuenta)
        Me.LayoutControl1.Controls.Add(Me.cbNiveles)
        Me.LayoutControl1.Controls.Add(Me.Label11)
        Me.LayoutControl1.Controls.Add(Me.cbTCuentas)
        Me.LayoutControl1.Controls.Add(Me.chkZeros)
        Me.LayoutControl1.Controls.Add(Me.Label10)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(995, 135, 450, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(694, 441)
        Me.LayoutControl1.TabIndex = 8
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cbSaldoActual
        '
        Me.cbSaldoActual.Location = New System.Drawing.Point(197, 394)
        Me.cbSaldoActual.Name = "cbSaldoActual"
        Me.cbSaldoActual.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbSaldoActual.Properties.Items.AddRange(New Object() {"Débito y Crédito", "Saldo"})
        Me.cbSaldoActual.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbSaldoActual.Size = New System.Drawing.Size(232, 20)
        Me.cbSaldoActual.StyleController = Me.LayoutControl1
        Me.cbSaldoActual.TabIndex = 30
        '
        'dtpHasta
        '
        Me.dtpHasta.EditValue = Nothing
        Me.dtpHasta.Location = New System.Drawing.Point(199, 231)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Properties.Appearance.Options.UseFont = True
        Me.dtpHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpHasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpHasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dtpHasta.Size = New System.Drawing.Size(133, 20)
        Me.dtpHasta.StyleController = Me.LayoutControl1
        Me.dtpHasta.TabIndex = 32
        '
        'cbMovimientos
        '
        Me.cbMovimientos.Location = New System.Drawing.Point(197, 370)
        Me.cbMovimientos.Name = "cbMovimientos"
        Me.cbMovimientos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMovimientos.Properties.Items.AddRange(New Object() {"Débito y Crédito", "Saldo"})
        Me.cbMovimientos.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbMovimientos.Size = New System.Drawing.Size(232, 20)
        Me.cbMovimientos.StyleController = Me.LayoutControl1
        Me.cbMovimientos.TabIndex = 28
        '
        'cbCatalogo
        '
        Me.cbCatalogo.EditValue = ""
        Me.cbCatalogo.Location = New System.Drawing.Point(109, 67)
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cbCatalogo.Properties.Appearance.Options.UseFont = True
        Me.cbCatalogo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo.Properties.NullText = ""
        Me.cbCatalogo.Properties.ShowFooter = False
        Me.cbCatalogo.Properties.View = Me.vCatalogo
        Me.cbCatalogo.Size = New System.Drawing.Size(561, 20)
        Me.cbCatalogo.StyleController = Me.LayoutControl1
        Me.cbCatalogo.TabIndex = 19
        '
        'vCatalogo
        '
        Me.vCatalogo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.vCatalogo.Name = "vCatalogo"
        Me.vCatalogo.OptionsBehavior.Editable = False
        Me.vCatalogo.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.vCatalogo.OptionsView.ShowAutoFilterRow = True
        Me.vCatalogo.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vCatalogo.OptionsView.ShowGroupedColumns = True
        Me.vCatalogo.OptionsView.ShowGroupPanel = False
        '
        'cbSAnterior
        '
        Me.cbSAnterior.Location = New System.Drawing.Point(197, 346)
        Me.cbSAnterior.Name = "cbSAnterior"
        Me.cbSAnterior.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbSAnterior.Properties.Items.AddRange(New Object() {"Débito y Crédito", "Saldo"})
        Me.cbSAnterior.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbSAnterior.Size = New System.Drawing.Size(232, 20)
        Me.cbSAnterior.StyleController = Me.LayoutControl1
        Me.cbSAnterior.TabIndex = 26
        '
        'dtpDesde
        '
        Me.dtpDesde.EditValue = Nothing
        Me.dtpDesde.Location = New System.Drawing.Point(199, 207)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Properties.Appearance.Options.UseFont = True
        Me.dtpDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDesde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDesde.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dtpDesde.Size = New System.Drawing.Size(133, 20)
        Me.dtpDesde.StyleController = Me.LayoutControl1
        Me.dtpDesde.TabIndex = 31
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(109, 158)
        Me.txtTitulo.MaxLength = 50
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(561, 20)
        Me.txtTitulo.TabIndex = 17
        '
        'cbCtaDistribucion
        '
        Me.cbCtaDistribucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCtaDistribucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCtaDistribucion.Items.AddRange(New Object() {"Todas Las Cuentas", "Solo  Cuentas Distribucion", "Excluir Cuentas Distribucion"})
        Me.cbCtaDistribucion.Location = New System.Drawing.Point(109, 321)
        Me.cbCtaDistribucion.Name = "cbCtaDistribucion"
        Me.cbCtaDistribucion.Size = New System.Drawing.Size(561, 23)
        Me.cbCtaDistribucion.TabIndex = 23
        '
        'cbMonedaCambio
        '
        Me.cbMonedaCambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonedaCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMonedaCambio.Location = New System.Drawing.Point(109, 182)
        Me.cbMonedaCambio.Name = "cbMonedaCambio"
        Me.cbMonedaCambio.Size = New System.Drawing.Size(561, 23)
        Me.cbMonedaCambio.TabIndex = 0
        '
        'chkSincuenta
        '
        Me.chkSincuenta.Location = New System.Drawing.Point(326, 297)
        Me.chkSincuenta.Name = "chkSincuenta"
        Me.chkSincuenta.Size = New System.Drawing.Size(111, 20)
        Me.chkSincuenta.TabIndex = 22
        '
        'cbNiveles
        '
        Me.cbNiveles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNiveles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNiveles.Location = New System.Drawing.Point(109, 91)
        Me.cbNiveles.Name = "cbNiveles"
        Me.cbNiveles.Size = New System.Drawing.Size(561, 23)
        Me.cbNiveles.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(210, 297)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 20)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Sin #Cuenta:"
        '
        'cbTCuentas
        '
        Me.cbTCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTCuentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTCuentas.Items.AddRange(New Object() {"BALANCE", "RESULTADO", "TODAS"})
        Me.cbTCuentas.Location = New System.Drawing.Point(109, 42)
        Me.cbTCuentas.Name = "cbTCuentas"
        Me.cbTCuentas.Size = New System.Drawing.Size(561, 23)
        Me.cbTCuentas.TabIndex = 0
        '
        'chkZeros
        '
        Me.chkZeros.Location = New System.Drawing.Point(155, 297)
        Me.chkZeros.Name = "chkZeros"
        Me.chkZeros.Size = New System.Drawing.Size(51, 20)
        Me.chkZeros.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(24, 297)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 20)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Eliminar Ceros?:"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup3, Me.LayoutControlGroup4, Me.LayoutControlGroup5})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(694, 441)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(674, 116)
        Me.LayoutControlGroup3.Text = "Grupos"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cbTCuentas
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(650, 25)
        Me.LayoutControlItem1.Text = "Tipo de Cuentas:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cbCatalogo
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 25)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(650, 24)
        Me.LayoutControlItem2.Text = "Cuenta:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbNiveles
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 49)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(650, 25)
        Me.LayoutControlItem3.Text = "Niveles:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.EmptySpaceItem3, Me.LayoutControlItem8, Me.EmptySpaceItem7, Me.EmptySpaceItem2})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 116)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(674, 139)
        Me.LayoutControlGroup4.Text = "Filtros de Fechas"
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtTitulo
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(650, 24)
        Me.LayoutControlItem4.Text = "Titulo:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cbMonedaCambio
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(650, 25)
        Me.LayoutControlItem5.Text = "Moneda:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.dtpDesde
        Me.LayoutControlItem6.Location = New System.Drawing.Point(90, 49)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(222, 24)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(222, 24)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(222, 24)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Desde:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.dtpHasta
        Me.LayoutControlItem7.Location = New System.Drawing.Point(90, 73)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(222, 24)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(222, 24)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(222, 24)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "Hasta:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(82, 13)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(312, 49)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(338, 22)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.CheckEdit1
        Me.LayoutControlItem8.Location = New System.Drawing.Point(492, 71)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(158, 26)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(158, 26)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(158, 26)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'EmptySpaceItem7
        '
        Me.EmptySpaceItem7.AllowHotTrack = False
        Me.EmptySpaceItem7.Location = New System.Drawing.Point(0, 49)
        Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Size = New System.Drawing.Size(90, 48)
        Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(312, 71)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(180, 26)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem15, Me.EmptySpaceItem6, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem18, Me.LayoutControlItem19, Me.EmptySpaceItem8, Me.EmptySpaceItem1})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 255)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(674, 166)
        Me.LayoutControlGroup5.Text = "Tipo de Reporte"
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.Label10
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(131, 24)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(131, 24)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(131, 24)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.chkZeros
        Me.LayoutControlItem13.Location = New System.Drawing.Point(131, 0)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(55, 24)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(55, 24)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(55, 24)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.Label11
        Me.LayoutControlItem14.Location = New System.Drawing.Point(186, 0)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(116, 24)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(116, 24)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(116, 24)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.chkSincuenta
        Me.LayoutControlItem15.Location = New System.Drawing.Point(302, 0)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(115, 24)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(115, 24)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(115, 24)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(417, 0)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(233, 24)
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.cbCtaDistribucion
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(650, 25)
        Me.LayoutControlItem16.Text = "Por Distribución:"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.cbSAnterior
        Me.LayoutControlItem17.Location = New System.Drawing.Point(88, 49)
        Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(321, 24)
        Me.LayoutControlItem17.MinSize = New System.Drawing.Size(321, 24)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(321, 24)
        Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem17.Text = "Saldo Anterior:"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.cbMovimientos
        Me.LayoutControlItem18.Location = New System.Drawing.Point(88, 73)
        Me.LayoutControlItem18.MaxSize = New System.Drawing.Size(321, 24)
        Me.LayoutControlItem18.MinSize = New System.Drawing.Size(321, 24)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(321, 24)
        Me.LayoutControlItem18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem18.Text = "Movimientos:"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.cbSaldoActual
        Me.LayoutControlItem19.Location = New System.Drawing.Point(88, 97)
        Me.LayoutControlItem19.MaxSize = New System.Drawing.Size(321, 27)
        Me.LayoutControlItem19.MinSize = New System.Drawing.Size(321, 27)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(321, 27)
        Me.LayoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem19.Text = "Saldo Actual:"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(82, 13)
        '
        'EmptySpaceItem8
        '
        Me.EmptySpaceItem8.AllowHotTrack = False
        Me.EmptySpaceItem8.Location = New System.Drawing.Point(409, 49)
        Me.EmptySpaceItem8.Name = "EmptySpaceItem8"
        Me.EmptySpaceItem8.Size = New System.Drawing.Size(241, 75)
        Me.EmptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 49)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(88, 75)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'cmdSalir
        '
        Me.cmdSalir.ImageOptions.Image = CType(resources.GetObject("cmdSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(12, 364)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(107, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl2
        Me.cmdSalir.TabIndex = 1
        Me.cmdSalir.Text = "Salir"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.cmdNew)
        Me.LayoutControl2.Controls.Add(Me.cmdSalir)
        Me.LayoutControl2.Controls.Add(Me.cmdImprimir)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(992, 176, 450, 400)
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(131, 414)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(12, 54)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(107, 22)
        Me.cmdNew.StyleController = Me.LayoutControl2
        Me.cmdNew.TabIndex = 0
        Me.cmdNew.Text = "Dev"
        Me.cmdNew.Visible = False
        '
        'cmdImprimir
        '
        Me.cmdImprimir.ImageOptions.Image = CType(resources.GetObject("cmdImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdImprimir.Location = New System.Drawing.Point(12, 12)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(107, 38)
        Me.cmdImprimir.StyleController = Me.LayoutControl2
        Me.cmdImprimir.TabIndex = 0
        Me.cmdImprimir.Text = "Imprimir"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem11, Me.LayoutControlItem10, Me.EmptySpaceItem4})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(131, 414)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmdImprimir
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cmdNew
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(111, 26)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        Me.LayoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cmdSalir
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 352)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 68)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(111, 284)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
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
        Me.DockPanel1.ID = New System.Guid("5a2ab964-fbbf-456a-8d25-99eaa4416df6")
        Me.DockPanel1.Location = New System.Drawing.Point(694, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(140, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(140, 441)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(131, 414)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(427, 0)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(8, 8)
        Me.SimpleButton1.TabIndex = 10
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'frmLibroBalanza
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(834, 441)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "frmLibroBalanza"
        Me.Text = "Reportes - Balanza de Comprobación"
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cbSaldoActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMovimientos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSAnterior.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Per_Detail As New VB.SysContab.PeriodoDetails
    Dim Fechas As New VB.SysContab.FechasdeOperacion

    Private Sub frmLibroBalanza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Tasa As New VB.SysContab.Tasa_CambioDB()
        ''r.CambiarEstilo(Me)
        i = 0

        cbMonedaCambio.DataSource = Tasa.GetListTasaCambioDisponibles().Tables("Tasa_Cambio")
        cbMonedaCambio.ValueMember = "MonedaCambio"
        cbMonedaCambio.DisplayMember = "Nombre"

        cbCatalogo.Properties.DataSource = Catalogo.GetList_SP("%").Tables("Catalogo")
        cbCatalogo.Properties.ValueMember = "CUENTA"
        cbCatalogo.Properties.DisplayMember = "NOMBRE"
        cbCatalogo.Properties.PopulateViewColumns()
        '
        For i As Integer = 0 To Me.vCatalogo.Columns.Count - 1
            Me.vCatalogo.Columns(i).Visible = False
        Next
        Me.vCatalogo.Columns("NOMBRE").Visible = True
        cbCatalogo.EditValue = "%"
        Me.cbCatalogo.Properties.PopupFormWidth = Me.cbCatalogo.Width

        cbNiveles.DataSource = Libros.Niveles().Tables("Niveles") 'Grupos.GetList_SP("%").Tables("Niveles")
        cbNiveles.ValueMember = "Nivel"
        cbNiveles.DisplayMember = "Descripcion"


        Me.chkZeros.Checked = True
        Me.cbTCuentas.SelectedItem = "TODAS"
        Me.cbCtaDistribucion.SelectedIndex = 0

        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date

        'Me.dtpDesde.MinDate = Fechas.FechaMinima
        'Me.dtpDesde.MaxDate = Fechas.FechaMaxima
        'Me.dtpHasta.MinDate = Fechas.FechaMinima
        'Me.dtpHasta.MaxDate = Fechas.FechaMaxima

        dtpDesde.DateTime = New DateTime(f.Year, f.Month, 1).Date
        dtpHasta.DateTime = UltimoDiaDelMes(f).Date

        Me.cbMonedaCambio.SelectedValue = MonedaBase

        Me.cbSAnterior.SelectedIndex = 0
        Me.cbMovimientos.SelectedIndex = 0
        Me.cbSaldoActual.SelectedIndex = 0
    End Sub


    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        ShowSplash()
        '
        Dim fReportes As New frmReportes
        Dim Catalogo As New VB.SysContab.CatalogoDB
        Dim Libros As New VB.SysContab.LibrosDB
        Dim r As New VB.SysContab.RutinasNomina

        Dim dsBalanza As New DataSet
        Dim DetalleNivel As New VB.SysContab.NivelDetailsDB
        Dim rNivel As Integer

        Empresa = Empresas.GetDetails(EmpresaActual)

        'Dim reporte As New rptBalanzaconsubreportesxml
        Dim ds As New DataSet
        Dim dsSR As New DataSet
        Dim dsDistribucion As New DataSet

        Dim reporte As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        If EmpresaActual = 1 Then
            reporte.Load(Application.StartupPath & "\Reportes\rptBalanzaconsubreportesxml_RAMAC.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
        Else
            reporte.Load(Application.StartupPath & "\Reportes\rptBalanzaconsubreportesxml.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
        End If


        If Not CheckEdit1.Checked Then
            Libros.Imprimir_LibroBalanza(0, Me.dtpDesde.DateTime.Date, Me.dtpHasta.DateTime.Date, Login,
            Me.txtTitulo.Text, tcuenta, Me.cbCatalogo.EditValue,
            IIf(Me.cbNiveles.SelectedValue = "%", Me.cbNiveles.Items(Me.cbNiveles.Items.Count - 1).row.itemarray(0), Me.cbNiveles.SelectedValue),
            Me.chkSincuenta.Checked, Empresa.MonedaBase, Me.cbMonedaCambio.SelectedValue, Me.chkZeros.Checked, "%", "%",
            "B", False, ds, False, "",
            IIf(Me.cbCtaDistribucion.SelectedIndex = 0, "%", IIf(Me.cbCtaDistribucion.SelectedIndex = 1, "1", "0")), "%",
            Me.cbSAnterior.SelectedIndex, Me.cbMovimientos.SelectedIndex, Me.cbSaldoActual.SelectedIndex)

        Else
            Libros.Imprimir_LibroBalanza_Con_Cierre_Fiscal(0, Me.dtpDesde.DateTime.Date, Me.dtpHasta.DateTime.Date, Login,
            Me.txtTitulo.Text, tcuenta, Me.cbCatalogo.EditValue,
            IIf(Me.cbNiveles.SelectedValue = "%", Me.cbNiveles.Items(Me.cbNiveles.Items.Count - 1).row.itemarray(0), Me.cbNiveles.SelectedValue),
            Me.chkSincuenta.Checked, Empresa.MonedaBase, Me.cbMonedaCambio.SelectedValue, Me.chkZeros.Checked, "%", "%",
            "B", False, ds, False, "",
            IIf(Me.cbCtaDistribucion.SelectedIndex = 0, "%", IIf(Me.cbCtaDistribucion.SelectedIndex = 1, "1", "0")), "%",
            Me.cbSAnterior.SelectedIndex, Me.cbMovimientos.SelectedIndex, Me.cbSaldoActual.SelectedIndex)

        End If



        ds.WriteXml(Application.StartupPath & "\xml\balanza.xml", XmlWriteMode.WriteSchema)

        dsSR = Libros.Detalle_Apie(Me.dtpDesde.DateTime.Date, Me.dtpHasta.DateTime.Date, 0, Me.cbMonedaCambio.SelectedValue)
        dsSR.WriteXml(Application.StartupPath & "\xml\detalleBalanza.xml", XmlWriteMode.WriteSchema)

        dsDistribucion = VB.SysContab.LibrosDB.Detalle_Distribucion(Me.dtpDesde.DateTime.Date, Me.dtpHasta.DateTime.Date, Me.cbMonedaCambio.SelectedValue)
        dsDistribucion.WriteXml(Application.StartupPath & "\xml\dDistribucion.xml", XmlWriteMode.WriteSchema)

        reporte.Database.Tables("vcd").Location = Application.StartupPath & "\xml\balanza.xml"
        Dim i As Integer
        For i = 0 To reporte.Subreports.Count - 1
            reporte.Subreports.Item(i).Database.Tables("_GetDetalleApie;1").Location = Application.StartupPath & "\xml\detalleBalanza.xml"
        Next

        fReportes.crvReportes.ReportSource = reporte
        'fReportes.MdiParent = Me.MdiParent
        fReportes.crvReportes.Zoom(100)
        fReportes.Show()
        '
        HideSplash()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cbTCuentas_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTCuentas.SelectedIndexChanged

        'Filtrar el listado de cuentas segun el tipo

        Select Case Me.cbTCuentas.SelectedItem.ToUpper
            Case "BALANCE"
                tcuenta = "B"
            Case "RESULTADO"
                tcuenta = "R"
            Case Else
                tcuenta = "%"
        End Select
        cbCatalogo.Properties.DataSource = Catalogo.GetList_SP(tcuenta).Tables("Catalogo")
        cbCatalogo.Properties.ValueMember = "CUENTA"
        cbCatalogo.Properties.DisplayMember = "NOMBRE"

    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        'Dim Rep As New XtraBalanzaComprobacion
        'Dim Datos As New ArrayList
        'Dim Variables As New ArrayList
        'Variables.Add("Empresa")
        'Variables.Add("Desde")
        'Variables.Add("Hasta")
        'Variables.Add("Cuenta")
        'Variables.Add("TCuenta")
        ''Variables.Add("Ceros")
        'Datos.Add(EmpresaActual)
        'Datos.Add(dtpDesde.Value.Date)
        'Datos.Add(dtpHasta.Value.Date)
        'Datos.Add(cbCatalogo.EditValue)
        'Datos.Add(IsNull(cbTCuentas.SelectedValue, ""))
        ''Datos.Add(chkZeros.Checked)
        'Rep.Ceros = chkZeros.Checked
        'Rep.DataSource = ProcedureParameters(Datos, Variables, "SPTempBalanza")
        'Select Case cbNiveles.SelectedIndex
        '    Case 0
        '        Rep.GrpMayor.Visible = True
        '        Rep.GrpSC01.Visible = True
        '        Rep.GrpSC02.Visible = True
        '        Rep.GrpSC03.Visible = True
        '        Rep.GrpCuenta.Visible = True
        '    Case 1
        '        Rep.GrpMayor.Visible = True
        '        Rep.GrpSC01.Visible = False
        '        Rep.GrpSC02.Visible = False
        '        Rep.GrpSC03.Visible = False
        '        Rep.GrpCuenta.Visible = False
        '    Case 2
        '        Rep.GrpMayor.Visible = False
        '        Rep.GrpSC01.Visible = True
        '        Rep.GrpSC02.Visible = False
        '        Rep.GrpSC03.Visible = False
        '        Rep.GrpCuenta.Visible = False
        '    Case 2
        '        Rep.GrpMayor.Visible = False
        '        Rep.GrpSC01.Visible = False
        '        Rep.GrpSC02.Visible = True
        '        Rep.GrpSC03.Visible = False
        '        Rep.GrpCuenta.Visible = False
        '    Case 3
        '        Rep.GrpMayor.Visible = False
        '        Rep.GrpSC01.Visible = False
        '        Rep.GrpSC02.Visible = False
        '        Rep.GrpSC03.Visible = True
        '        Rep.GrpCuenta.Visible = False
        'End Select
        'Rep.ShowRibbonPreview()
    End Sub

    Private Sub dtpDesde_EditValueChanged(sender As Object, e As EventArgs) Handles dtpDesde.EditValueChanged

    End Sub
End Class
