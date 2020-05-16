Imports System.IO
Imports DevExpress.XtraReports.UI

Public Class frmLibroAuxiliar
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmLibroAuxiliar = Nothing
    Private i As Integer
    Private Empresa As New VB.SysContab.EmpresasDetails()
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkZeros As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cbNivel As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtTitulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbMoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dtpHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents cbTipo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtChk As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDocumento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Private Empresas As New VB.SysContab.EmpresasDB()

    Public Shared Function Instance() As frmLibroAuxiliar
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmLibroAuxiliar()
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbCatalogo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents vCatalogo As DevExpress.XtraGrid.Views.Grid.GridView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLibroAuxiliar))
        Me.cbCatalogo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.vCatalogo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtChk = New DevExpress.XtraEditors.TextEdit()
        Me.txtDocumento = New DevExpress.XtraEditors.TextEdit()
        Me.cbTipo = New DevExpress.XtraEditors.LookUpEdit()
        Me.dtpHasta = New DevExpress.XtraEditors.DateEdit()
        Me.dtpDesde = New DevExpress.XtraEditors.DateEdit()
        Me.txtTitulo = New DevExpress.XtraEditors.TextEdit()
        Me.cbMoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.chkZeros = New DevExpress.XtraEditors.CheckEdit()
        Me.cbNivel = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.cbCatalogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtChk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkZeros.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbNivel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbCatalogo
        '
        Me.cbCatalogo.EditValue = ""
        Me.cbCatalogo.Location = New System.Drawing.Point(119, 65)
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cbCatalogo.Properties.Appearance.Options.UseFont = True
        Me.cbCatalogo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo.Properties.NullText = ""
        Me.cbCatalogo.Properties.ShowFooter = False
        Me.cbCatalogo.Properties.View = Me.vCatalogo
        Me.cbCatalogo.Size = New System.Drawing.Size(541, 20)
        Me.cbCatalogo.StyleController = Me.LayoutControl1
        Me.cbCatalogo.TabIndex = 25
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
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtChk)
        Me.LayoutControl1.Controls.Add(Me.txtDocumento)
        Me.LayoutControl1.Controls.Add(Me.cbTipo)
        Me.LayoutControl1.Controls.Add(Me.dtpHasta)
        Me.LayoutControl1.Controls.Add(Me.dtpDesde)
        Me.LayoutControl1.Controls.Add(Me.txtTitulo)
        Me.LayoutControl1.Controls.Add(Me.cbMoneda)
        Me.LayoutControl1.Controls.Add(Me.chkZeros)
        Me.LayoutControl1.Controls.Add(Me.cbNivel)
        Me.LayoutControl1.Controls.Add(Me.cbCatalogo)
        Me.LayoutControl1.Controls.Add(Me.lblTitulo)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1077, 199, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(684, 411)
        Me.LayoutControl1.TabIndex = 6
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtChk
        '
        Me.txtChk.Location = New System.Drawing.Point(440, 365)
        Me.txtChk.Name = "txtChk"
        Me.txtChk.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChk.Properties.Appearance.Options.UseFont = True
        Me.txtChk.Properties.MaxLength = 8
        Me.txtChk.Size = New System.Drawing.Size(220, 22)
        Me.txtChk.StyleController = Me.LayoutControl1
        Me.txtChk.TabIndex = 32
        '
        'txtDocumento
        '
        Me.txtDocumento.Location = New System.Drawing.Point(119, 365)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumento.Properties.Appearance.Options.UseFont = True
        Me.txtDocumento.Properties.Mask.EditMask = "d"
        Me.txtDocumento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDocumento.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDocumento.Properties.MaxLength = 8
        Me.txtDocumento.Size = New System.Drawing.Size(222, 22)
        Me.txtDocumento.StyleController = Me.LayoutControl1
        Me.txtDocumento.TabIndex = 31
        '
        'cbTipo
        '
        Me.cbTipo.Location = New System.Drawing.Point(119, 341)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipo.Properties.Appearance.Options.UseFont = True
        Me.cbTipo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipo.Size = New System.Drawing.Size(541, 20)
        Me.cbTipo.StyleController = Me.LayoutControl1
        Me.cbTipo.TabIndex = 28
        '
        'dtpHasta
        '
        Me.dtpHasta.EditValue = Nothing
        Me.dtpHasta.Location = New System.Drawing.Point(119, 231)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Properties.Appearance.Options.UseFont = True
        Me.dtpHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpHasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpHasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dtpHasta.Size = New System.Drawing.Size(134, 20)
        Me.dtpHasta.StyleController = Me.LayoutControl1
        Me.dtpHasta.TabIndex = 30
        '
        'dtpDesde
        '
        Me.dtpDesde.EditValue = Nothing
        Me.dtpDesde.Location = New System.Drawing.Point(119, 207)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Properties.Appearance.Options.UseFont = True
        Me.dtpDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDesde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDesde.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dtpDesde.Size = New System.Drawing.Size(134, 20)
        Me.dtpDesde.StyleController = Me.LayoutControl1
        Me.dtpDesde.TabIndex = 29
        '
        'txtTitulo
        '
        Me.txtTitulo.EditValue = "Libro Mayor Auxiliar"
        Me.txtTitulo.Location = New System.Drawing.Point(119, 181)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.txtTitulo.Properties.Appearance.Options.UseFont = True
        Me.txtTitulo.Properties.Appearance.Options.UseForeColor = True
        Me.txtTitulo.Size = New System.Drawing.Size(541, 22)
        Me.txtTitulo.StyleController = Me.LayoutControl1
        Me.txtTitulo.TabIndex = 28
        '
        'cbMoneda
        '
        Me.cbMoneda.Location = New System.Drawing.Point(119, 157)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMoneda.Properties.Appearance.Options.UseFont = True
        Me.cbMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMoneda.Size = New System.Drawing.Size(541, 20)
        Me.cbMoneda.StyleController = Me.LayoutControl1
        Me.cbMoneda.TabIndex = 27
        '
        'chkZeros
        '
        Me.chkZeros.Location = New System.Drawing.Point(545, 89)
        Me.chkZeros.Name = "chkZeros"
        Me.chkZeros.Properties.Caption = "Eliminar Ceros (0)"
        Me.chkZeros.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkZeros.Size = New System.Drawing.Size(115, 22)
        Me.chkZeros.StyleController = Me.LayoutControl1
        Me.chkZeros.TabIndex = 27
        '
        'cbNivel
        '
        Me.cbNivel.Location = New System.Drawing.Point(119, 89)
        Me.cbNivel.Name = "cbNivel"
        Me.cbNivel.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNivel.Properties.Appearance.Options.UseFont = True
        Me.cbNivel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbNivel.Size = New System.Drawing.Size(422, 20)
        Me.cbNivel.StyleController = Me.LayoutControl1
        Me.cbNivel.TabIndex = 26
        '
        'lblTitulo
        '
        Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.lblTitulo.Appearance.Options.UseFont = True
        Me.lblTitulo.Appearance.Options.UseForeColor = True
        Me.lblTitulo.Location = New System.Drawing.Point(12, 12)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(153, 19)
        Me.lblTitulo.StyleController = Me.LayoutControl1
        Me.lblTitulo.TabIndex = 7
        Me.lblTitulo.Text = "Libro Mayor Auxiliar"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlGroup3, Me.LayoutControlGroup4, Me.EmptySpaceItem2, Me.LayoutControlGroup5})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(684, 411)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.lblTitulo
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(664, 23)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem3})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 23)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(664, 92)
        Me.LayoutControlGroup3.Text = "Cuenta"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cbCatalogo
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(640, 24)
        Me.LayoutControlItem2.Text = "Cuenta:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.chkZeros
        Me.LayoutControlItem4.Location = New System.Drawing.Point(521, 24)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(119, 26)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(119, 26)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(119, 26)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbNivel
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(521, 26)
        Me.LayoutControlItem3.Text = "Niveles:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.EmptySpaceItem3})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 115)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(664, 140)
        Me.LayoutControlGroup4.Text = "Rango de Fechas"
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cbMoneda
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(640, 24)
        Me.LayoutControlItem7.Text = "Moneda:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtTitulo
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(640, 26)
        Me.LayoutControlItem8.Text = "Titulo:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.dtpDesde
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(233, 24)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(233, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(233, 24)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "Desde:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.dtpHasta
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 74)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(233, 24)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(233, 24)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(233, 24)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Hasta:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(92, 13)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(233, 50)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(407, 48)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 255)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(664, 44)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 299)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(664, 92)
        Me.LayoutControlGroup5.Text = "Filtros de Busqueda"
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cbTipo
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(640, 24)
        Me.LayoutControlItem9.Text = "Tipo Comprobante:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtDocumento
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(321, 26)
        Me.LayoutControlItem10.Text = "#Comprobante:"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txtChk
        Me.LayoutControlItem11.Location = New System.Drawing.Point(321, 24)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(319, 26)
        Me.LayoutControlItem11.Text = "#Cheque:"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(92, 13)
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Options.UseTextOptions = True
        Me.SimpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 96)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(118, 38)
        Me.SimpleButton1.StyleController = Me.LayoutControl2
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "Imprimir &Consilidado"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl2.Controls.Add(Me.cmdSalir)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl2.Controls.Add(Me.cmdImprimir)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(901, 175, 250, 350)
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(141, 384)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Options.UseTextOptions = True
        Me.SimpleButton2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(12, 12)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(118, 38)
        Me.SimpleButton2.StyleController = Me.LayoutControl2
        Me.SimpleButton2.TabIndex = 8
        Me.SimpleButton2.Text = "Imprimir &Mayor Auxiliar"
        '
        'cmdSalir
        '
        Me.cmdSalir.ImageOptions.Image = CType(resources.GetObject("cmdSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(12, 317)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(118, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl2
        Me.cmdSalir.TabIndex = 1
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Appearance.Options.UseTextOptions = True
        Me.cmdImprimir.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdImprimir.ImageOptions.Image = CType(resources.GetObject("cmdImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdImprimir.Location = New System.Drawing.Point(12, 54)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(118, 38)
        Me.cmdImprimir.StyleController = Me.LayoutControl2
        Me.cmdImprimir.TabIndex = 0
        Me.cmdImprimir.Text = "Imprimir &Original"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.EmptySpaceItem1, Me.LayoutControlItem15})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(142, 367)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cmdImprimir
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        Me.LayoutControlItem12.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.SimpleButton1
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.cmdSalir
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 305)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 126)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(122, 179)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.SimpleButton2
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
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
        Me.DockPanel1.ID = New System.Guid("1558435c-c9df-4f9f-a43a-dab906aa6711")
        Me.DockPanel1.Location = New System.Drawing.Point(684, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(150, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(150, 411)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(141, 384)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'frmLibroAuxiliar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(834, 411)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLibroAuxiliar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes - Mayor Auxliar"
        CType(Me.cbCatalogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtChk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkZeros.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbNivel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Per_Detail As New VB.SysContab.PeriodoDetails()
    Dim Periodos As New VB.SysContab.PeriodosDB
    Dim Fechas As New VB.SysContab.FechasdeTrabajo

    Private Sub frmLibroAuxiliar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim Catalogo As New VB.SysContab.CatalogoDB()
        Dim TComprobantes As New VB.SysContab.ComprobanteDB()
        Dim r As New VB.SysContab.RutinasNomina()
        Dim Tasa As New VB.SysContab.Tasa_CambioDB
        Dim Libros As New VB.SysContab.LibrosDB

        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        dtpDesde.DateTime = New DateTime(f.Year, f.Month, 1).Date
        dtpHasta.DateTime = UltimoDiaDelMes(f).Date

        ''r.CambiarEstilo(Me)
        'i = 0
        'cbMonedaCambio.DataSource = Tasa.GetListTasaCambioDisponibles().Tables("Tasa_Cambio")
        'cbMonedaCambio.ValueMember = "MonedaCambio"
        'cbMonedaCambio.DisplayMember = "Nombre"

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

        Combo(cbNivel, Libros.Niveles().Tables("Niveles"))
        cbNivel.ItemIndex = 0

        GetMonedasList(cbMoneda)

        GetComprobantesList(cbTipo)

        'cbNiveles.DataSource = Libros.Niveles().Tables("Niveles") 'Grupos.GetList_SP("%").Tables("Niveles")
        'cbNiveles.ValueMember = "Nivel"
        'cbNiveles.DisplayMember = "Descripcion"

        'cbTComprobante.DataSource = TComprobantes.GetTiposComprobantes().Tables("TipoComprobantes")
        'cbTComprobante.ValueMember = "TipComp_Id"
        'cbTComprobante.DisplayMember = "TipComp_Nombre"
        Me.txtChk.Text = ""
        Me.txtDocumento.Text = ""
        ' Me.cbMonedaCambio.SelectedValue = MonedaBase
    End Sub

    'Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
    '    ShowSplash()
    '    '
    '    Dim fReportes As New frmReportes
    '    Dim Libros As New VB.SysContab.LibrosDB()
    '    Dim r As New VB.SysContab.RutinasNomina()
    '    Dim dsEncabezado1 As DataSet

    '    'Dim rcolilla As New rptLibroAuxiliar_V2_CRXI

    '    Dim rcolilla As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    '    rcolilla.Load(Application.StartupPath & "\Reportes\rptLibroAuxiliar_V2_CRXI.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
    '    'rcolilla.Load(Application.StartupPath & "\Reportes\rptAcumuladoAguinaldo.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

    '    Empresa = Empresas.GetDetails(EmpresaActual)

    '    'dsEncabezado1 = Libros.Imprimir_LibroAuxiliarV2(Me.dtpDesde.DateTime.Date, Me.dtpHasta.DateTime.Date, Me.cbCatalogo.EditValue, _
    '    '            IIf(Me.cbNivel.EditValue = "%", cbNiveles.Items(Me.cbNiveles.Items.Count - 1).row.itemarray(0), Me.cbNiveles.SelectedValue), _
    '    '           cbTipo.EditValue, txtDocumento.EditValue, Me.txtChk.Text, _
    '    '           Usuario, txtTitulo.Text, Empresa.MonedaBase, Me.cbMoneda.EditValue, False, Empresa.Nombre, False)

    '    dsEncabezado1 = Libros.Imprimir_LibroAuxiliarV2(Me.dtpDesde.DateTime.Date, Me.dtpHasta.DateTime.Date, Me.cbCatalogo.EditValue, _
    '                IIf(cbNivel.ItemIndex = 0, Libros.Niveles().Tables("Niveles").Rows.Count - 1, cbNivel.EditValue), _
    '               cbTipo.EditValue, txtDocumento.EditValue, Me.txtChk.Text, _
    '               Usuario, txtTitulo.Text, Empresa.MonedaBase, Me.cbMoneda.EditValue, False, Empresa.Nombre, False)

    '    dsEncabezado1.WriteXml(Application.StartupPath & "\xml\LA_V2.xml", XmlWriteMode.WriteSchema)

    '    rcolilla.Database.Tables("LibroAuxiliar").Location = Application.StartupPath & "\xml\LA_V2.xml"
    '    rcolilla.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoempresa.xml"

    '    fReportes.crvReportes.ReportSource = rcolilla

    '    fReportes.crvReportes.Zoom(91)
    '    fReportes.Show()
    '    '
    '    HideSplash()
    'End Sub

    Private Sub cmdSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        ShowSplash("Imprimiendo...")
        '
        ' Dim dtl As VB.SysContab.EmpresasDetails = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)
        'Dim DT_LOGO As DataTable = VB.SysContab.EmpresasDB.GetLogoEmpresa().Tables(0)

        Dim rpt As New rptLibroAuxiliar
        rpt.Nivel = cbNivel.Properties.GetDataSourceRowIndex("Nivel", cbNivel.EditValue)
        rpt.pLogo.Image = frmPrincipalRibbon.pLogo.Image

        'Try
        '    Dim data As Byte() = DirectCast(DT_LOGO.Rows.Item(0)("Logo"), Byte())
        '    Dim ms As New MemoryStream(data)
        '    rpt.pLogo.Image = Image.FromStream(ms)
        'Catch ex As Exception
        'End Try

        'rpt.DataSource = VB.SysContab.LibrosDB.Libro_Auxiliar_DX(dtpDesde.DateTime.Date, dtpHasta.DateTime.Date, cbMoneda.EditValue, cbCatalogo.EditValue)

        Dim DT_LA As DataTable = VB.SysContab.LibrosDB.Libro_Auxiliar_DX(dtpDesde.DateTime.Date,
                                                                         dtpHasta.DateTime.Date,
                                                                         cbMoneda.EditValue,
                                                                         cbCatalogo.EditValue)

        VistaPreviaDX(rpt, DT_LA, "Libro Auxiliar Consolidado")
        HideSplash()

        'rpt.ShowPrintMarginsWarning = False
        'rpt.BringToFront()
        'rpt.ShowRibbonPreview()

        ' ''  Dim fReportes As New frmReportes
        ''Dim Libros As New VB.SysContab.LibrosDB()
        ''Dim r As New VB.SysContab.RutinasNomina()
        ''Dim dsEncabezado1 As DataSet

        ' ''Dim rcolilla As New rptLibroAuxiliar_V2_CRXI
        ' ''Dim rcolilla As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        ' ''rcolilla.Load(Application.StartupPath & "\Reportes\rptLibroAuxiliar_V2_CRXI.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        ''Empresa = Empresas.GetDetails(EmpresaActual)

        ''Dim rpt As New rptMayorAuxiliar
        ''rpt.Periodo.Text = "Desde : " & dtpDesde.DateTime.Date & " Hasta : " & dtpHasta.DateTime.Date

        ' ''rpt.DataSource = Libros.Imprimir_LibroAuxiliarV2(Me.dtpDesde.DateTime.Date, Me.dtpHasta.DateTime.Date, Me.cbCatalogo.EditValue, _
        ' ''           IIf(Me.cbNiveles.SelectedValue = "%", Me.cbNiveles.Items(Me.cbNiveles.Items.Count - 1).row.itemarray(0), Me.cbNiveles.SelectedValue), _
        ' ''           Me.cbTipo.EditValue, Me.txtDocumento.EditValue, Me.txtChk.Text, _
        ' ''           Usuario, Me.txtTitulo.Text, Empresa.MonedaBase, Me.cbMoneda.EditValue, False, Empresa.Nombre, False).Tables(0)

        ''dsEncabezado1 = Libros.Imprimir_LibroAuxiliarV2(Me.dtpDesde.DateTime.Date, Me.dtpHasta.DateTime.Date, Me.cbCatalogo.EditValue, _
        ''            IIf(cbNivel.ItemIndex = 0, Libros.Niveles().Tables("Niveles").Rows.Count - 1, cbNivel.EditValue), _
        ''           cbTipo.EditValue, txtDocumento.EditValue, Me.txtChk.Text, _
        ''           Usuario, txtTitulo.Text, Empresa.MonedaBase, Me.cbMoneda.EditValue, False, Empresa.Nombre, False)


        ''rpt.ShowRibbonPreview()
        ' ''dsEncabezado1.WriteXml(Application.StartupPath & "\xml\LA_V2.xml", XmlWriteMode.WriteSchema)

        ' ''rcolilla.Database.Tables("LibroAuxiliar").Location = Application.StartupPath & "\xml\LA_V2.xml"
        ' ''rcolilla.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoempresa.xml"

        ' ''fReportes.crvReportes.ReportSource = rcolilla

        ' ''fReportes.crvReportes.Zoom(91)
        ' ''fReportes.Show()
        '

    End Sub

    Private Sub cbTComprobante_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        'If cbCatalogo.EditValue = "%" Then
        '    XtraMsg("Seleccione una Cuenta!")
        '    cbCatalogo.Focus()
        '    Exit Sub
        'End If

        ShowSplash()
        '
        'Dim DT_LOGO As DataTable = VB.SysContab.EmpresasDB.GetLogoEmpresa().Tables(0)

        Dim rpt As New rptLibroAuxiliar2
        rpt.Nivel = cbNivel.Properties.GetDataSourceRowIndex("Nivel", cbNivel.EditValue)
        rpt.pLogo.Image = frmPrincipalRibbon.pLogo.Image

        'Try
        '    Dim data As Byte() = DirectCast(DT_LOGO.Rows.Item(0)("Logo"), Byte())
        '    Dim ms As New MemoryStream(data)
        '    rpt.pLogo.Image = Image.FromStream(ms)
        'Catch ex As Exception
        'End Try

        Dim DT As DataTable = VB.SysContab.LibrosDB.Libro_Auxiliar_DX2(dtpDesde.DateTime.Date,
                                                                       dtpHasta.DateTime.Date,
                                                                       cbMoneda.EditValue,
                                                                       cbCatalogo.EditValue)


        For i As Integer = 0 To DT.Rows.Count - 1
            Try
                If DT.Rows.Item(i)("Concepto") <> "Saldo Anterior" Then DT.Rows.Item(i)("Acumulado") = DT.Rows.Item(i - 1)("Acumulado") +
                    IIf(DT.Rows.Item(i)("Clase") = 1, (DT.Rows.Item(i)("debe") - DT.Rows.Item(i)("haber")), (DT.Rows.Item(i)("haber") - DT.Rows.Item(i)("debe")))
            Catch ex As Exception
            End Try
        Next

        VistaPreviaDX(rpt, DT, "Reporte Mayor Auxiliar")
        '
        HideSplash()

        'rpt.DataSource = DT
        'HideSplash()

        'rpt.ShowPrintMarginsWarning = False
        'rpt.BringToFront()
        'rpt.ShowRibbonPreview()
    End Sub
End Class
