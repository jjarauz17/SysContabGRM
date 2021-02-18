Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class FrmUsuarios
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As FrmUsuarios = Nothing

    Public Shared Function Instance() As FrmUsuarios
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmUsuarios()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance

    End Function

#Region " Windows Form Designer generated code "

    Private Sub New()
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
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAcumulado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbAsignados As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbRecursos As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ckHabilitado As System.Windows.Forms.CheckBox
    Friend WithEvents lbEmpresas As System.Windows.Forms.ListBox
    Friend WithEvents Button3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgCajas As DevExpress.XtraGrid.GridControl
    Friend WithEvents vVista As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cbRoles As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtTelefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCargo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtRepetirPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lbEmprAsign As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuarios))
        Me.ckHabilitado = New System.Windows.Forms.CheckBox()
        Me.cmdAcumulado = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lbAsignados = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbRecursos = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton()
        Me.lbEmprAsign = New System.Windows.Forms.ListBox()
        Me.lbEmpresas = New System.Windows.Forms.ListBox()
        Me.Button3 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.txtRepetirPassword = New DevExpress.XtraEditors.TextEdit()
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.txtUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.dgCajas = New DevExpress.XtraGrid.GridControl()
        Me.vVista = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.Button4 = New DevExpress.XtraEditors.SimpleButton()
        Me.cbRoles = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtTelefono = New DevExpress.XtraEditors.TextEdit()
        Me.txtCargo = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRepetirPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.dgCajas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbRoles.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCargo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ckHabilitado
        '
        Me.ckHabilitado.Checked = True
        Me.ckHabilitado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckHabilitado.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckHabilitado.ForeColor = System.Drawing.Color.Red
        Me.ckHabilitado.Location = New System.Drawing.Point(925, 60)
        Me.ckHabilitado.Name = "ckHabilitado"
        Me.ckHabilitado.Size = New System.Drawing.Size(104, 20)
        Me.ckHabilitado.TabIndex = 142
        Me.ckHabilitado.Text = "Habilitado"
        '
        'cmdAcumulado
        '
        Me.cmdAcumulado.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAcumulado.Appearance.Options.UseFont = True
        Me.cmdAcumulado.ImageOptions.SvgImage = CType(resources.GetObject("cmdAcumulado.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.cmdAcumulado.Location = New System.Drawing.Point(12, 52)
        Me.cmdAcumulado.Name = "cmdAcumulado"
        Me.cmdAcumulado.Size = New System.Drawing.Size(109, 36)
        Me.cmdAcumulado.StyleController = Me.LayoutControl2
        Me.cmdAcumulado.TabIndex = 36
        Me.cmdAcumulado.Text = "&Salir"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.cmdAcumulado)
        Me.LayoutControl2.Controls.Add(Me.cmdAceptar)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup1
        Me.LayoutControl2.Size = New System.Drawing.Size(133, 667)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.ImageOptions.SvgImage = CType(resources.GetObject("cmdAceptar.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.cmdAceptar.Location = New System.Drawing.Point(12, 12)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(109, 36)
        Me.cmdAceptar.StyleController = Me.LayoutControl2
        Me.cmdAceptar.TabIndex = 34
        Me.cmdAceptar.Text = "&Guardar"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem16, Me.EmptySpaceItem2, Me.LayoutControlItem17})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(133, 667)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.cmdAceptar
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(113, 40)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 80)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(113, 567)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.cmdAcumulado
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(113, 40)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'lbAsignados
        '
        Me.lbAsignados.Location = New System.Drawing.Point(290, 23)
        Me.lbAsignados.Name = "lbAsignados"
        Me.lbAsignados.Size = New System.Drawing.Size(208, 147)
        Me.lbAsignados.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(344, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 16)
        Me.Label4.TabIndex = 137
        Me.Label4.Text = "Roles Asignados"
        '
        'lbRecursos
        '
        Me.lbRecursos.Location = New System.Drawing.Point(9, 23)
        Me.lbRecursos.Name = "lbRecursos"
        Me.lbRecursos.Size = New System.Drawing.Size(208, 147)
        Me.lbRecursos.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(16, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 16)
        Me.Label5.TabIndex = 136
        Me.Label5.Text = "Roles Disponibles"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(223, 75)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 25)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "< Quitar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(223, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 25)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Asignar >"
        '
        'lbEmprAsign
        '
        Me.lbEmprAsign.Location = New System.Drawing.Point(403, 148)
        Me.lbEmprAsign.Name = "lbEmprAsign"
        Me.lbEmprAsign.Size = New System.Drawing.Size(296, 524)
        Me.lbEmprAsign.TabIndex = 1
        '
        'lbEmpresas
        '
        Me.lbEmpresas.Location = New System.Drawing.Point(12, 148)
        Me.lbEmpresas.Name = "lbEmpresas"
        Me.lbEmpresas.Size = New System.Drawing.Size(296, 524)
        Me.lbEmpresas.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.ImageOptions.Image = CType(resources.GetObject("Button3.ImageOptions.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(312, 158)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 22)
        Me.Button3.StyleController = Me.LayoutControl1
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Quitar"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.CheckEdit1)
        Me.LayoutControl1.Controls.Add(Me.txtEmail)
        Me.LayoutControl1.Controls.Add(Me.txtRepetirPassword)
        Me.LayoutControl1.Controls.Add(Me.txtPassword)
        Me.LayoutControl1.Controls.Add(Me.txtUsuario)
        Me.LayoutControl1.Controls.Add(Me.txtNombre)
        Me.LayoutControl1.Controls.Add(Me.PanelControl4)
        Me.LayoutControl1.Controls.Add(Me.Button3)
        Me.LayoutControl1.Controls.Add(Me.dgCajas)
        Me.LayoutControl1.Controls.Add(Me.Button4)
        Me.LayoutControl1.Controls.Add(Me.lbEmprAsign)
        Me.LayoutControl1.Controls.Add(Me.cbRoles)
        Me.LayoutControl1.Controls.Add(Me.txtTelefono)
        Me.LayoutControl1.Controls.Add(Me.lbEmpresas)
        Me.LayoutControl1.Controls.Add(Me.txtCargo)
        Me.LayoutControl1.Controls.Add(Me.ckHabilitado)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem15})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(924, 448, 650, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1041, 696)
        Me.LayoutControl1.TabIndex = 48
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(950, 108)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "Todo"
        Me.CheckEdit1.Size = New System.Drawing.Size(79, 20)
        Me.CheckEdit1.StyleController = Me.LayoutControl1
        Me.CheckEdit1.TabIndex = 155
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(117, 60)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Size = New System.Drawing.Size(804, 20)
        Me.txtEmail.StyleController = Me.LayoutControl1
        Me.txtEmail.TabIndex = 150
        Me.txtEmail.Tag = "True"
        '
        'txtRepetirPassword
        '
        Me.txtRepetirPassword.Location = New System.Drawing.Point(621, 36)
        Me.txtRepetirPassword.Name = "txtRepetirPassword"
        Me.txtRepetirPassword.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtRepetirPassword.Properties.Appearance.Options.UseBackColor = True
        Me.txtRepetirPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtRepetirPassword.Size = New System.Drawing.Size(408, 20)
        Me.txtRepetirPassword.StyleController = Me.LayoutControl1
        Me.txtRepetirPassword.TabIndex = 151
        Me.txtRepetirPassword.Tag = "True"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(117, 36)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtPassword.Properties.Appearance.Options.UseBackColor = True
        Me.txtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Size = New System.Drawing.Size(395, 20)
        Me.txtPassword.StyleController = Me.LayoutControl1
        Me.txtPassword.TabIndex = 150
        Me.txtPassword.Tag = "True"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(753, 12)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtUsuario.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtUsuario.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtUsuario.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtUsuario.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtUsuario.Size = New System.Drawing.Size(276, 20)
        Me.txtUsuario.StyleController = Me.LayoutControl1
        Me.txtUsuario.TabIndex = 150
        Me.txtUsuario.Tag = "True"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(117, 12)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(527, 20)
        Me.txtNombre.StyleController = Me.LayoutControl1
        Me.txtNombre.TabIndex = 149
        Me.txtNombre.Tag = "True"
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.lbAsignados)
        Me.PanelControl4.Controls.Add(Me.Label4)
        Me.PanelControl4.Controls.Add(Me.Button1)
        Me.PanelControl4.Controls.Add(Me.lbRecursos)
        Me.PanelControl4.Controls.Add(Me.Button2)
        Me.PanelControl4.Controls.Add(Me.Label5)
        Me.PanelControl4.Location = New System.Drawing.Point(12, 184)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(852, 500)
        Me.PanelControl4.TabIndex = 47
        Me.PanelControl4.Visible = False
        '
        'dgCajas
        '
        Me.dgCajas.Location = New System.Drawing.Point(703, 132)
        Me.dgCajas.MainView = Me.vVista
        Me.dgCajas.Name = "dgCajas"
        Me.dgCajas.Size = New System.Drawing.Size(326, 552)
        Me.dgCajas.TabIndex = 44
        Me.dgCajas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vVista})
        '
        'vVista
        '
        Me.vVista.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.vVista.GridControl = Me.dgCajas
        Me.vVista.Name = "vVista"
        Me.vVista.OptionsView.ShowFooter = True
        Me.vVista.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridBand1.AppearanceHeader.Options.UseFont = True
        Me.GridBand1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.VisibleIndex = 0
        '
        'Button4
        '
        Me.Button4.ImageOptions.Image = CType(resources.GetObject("Button4.ImageOptions.Image"), System.Drawing.Image)
        Me.Button4.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(312, 132)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(87, 22)
        Me.Button4.StyleController = Me.LayoutControl1
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Asignar"
        '
        'cbRoles
        '
        Me.cbRoles.Location = New System.Drawing.Point(117, 108)
        Me.cbRoles.Name = "cbRoles"
        Me.cbRoles.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cbRoles.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.cbRoles.Properties.Appearance.Options.UseFont = True
        Me.cbRoles.Properties.Appearance.Options.UseForeColor = True
        Me.cbRoles.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbRoles.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.cbRoles.Size = New System.Drawing.Size(829, 20)
        Me.cbRoles.StyleController = Me.LayoutControl1
        Me.cbRoles.TabIndex = 154
        Me.cbRoles.Tag = "True"
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(814, 84)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(215, 20)
        Me.txtTelefono.StyleController = Me.LayoutControl1
        Me.txtTelefono.TabIndex = 153
        '
        'txtCargo
        '
        Me.txtCargo.Location = New System.Drawing.Point(117, 84)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(588, 20)
        Me.txtCargo.StyleController = Me.LayoutControl1
        Me.txtCargo.TabIndex = 152
        Me.txtCargo.Tag = "True"
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.PanelControl4
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 172)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(856, 504)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        Me.LayoutControlItem15.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem14, Me.LayoutControlItem13, Me.LayoutControlItem12, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.EmptySpaceItem1, Me.LayoutControlItem18})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1041, 696)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.ckHabilitado
        Me.LayoutControlItem6.Location = New System.Drawing.Point(913, 48)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(108, 24)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(108, 24)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(108, 24)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtCargo
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(697, 24)
        Me.LayoutControlItem7.Text = "Cargo:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtTelefono
        Me.LayoutControlItem8.Location = New System.Drawing.Point(697, 72)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(324, 24)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(324, 24)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(324, 24)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.Text = "Telefono:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cbRoles
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(938, 24)
        Me.LayoutControlItem9.Text = "Rol Asignado:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.lbEmpresas
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(300, 0)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(300, 40)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(300, 556)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.Text = "Empresas Disponibles"
        Me.LayoutControlItem10.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.lbEmprAsign
        Me.LayoutControlItem11.Location = New System.Drawing.Point(391, 120)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(300, 0)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(300, 40)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(300, 556)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.Text = "Empresas Asignadas"
        Me.LayoutControlItem11.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.dgCajas
        Me.LayoutControlItem14.Location = New System.Drawing.Point(691, 120)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(330, 556)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.Button3
        Me.LayoutControlItem13.Location = New System.Drawing.Point(300, 146)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(91, 26)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(91, 26)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(91, 26)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.Button4
        Me.LayoutControlItem12.Location = New System.Drawing.Point(300, 120)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(91, 26)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(91, 26)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(91, 26)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtNombre
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(636, 24)
        Me.LayoutControlItem1.Text = "Nombre Completo:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtUsuario
        Me.LayoutControlItem2.Location = New System.Drawing.Point(636, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(385, 24)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(385, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(385, 24)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Login:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtPassword
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(504, 24)
        Me.LayoutControlItem3.Text = "Contraseña:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtRepetirPassword
        Me.LayoutControlItem4.Location = New System.Drawing.Point(504, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(517, 24)
        Me.LayoutControlItem4.Text = "Repetir Contraseña:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtEmail
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(913, 24)
        Me.LayoutControlItem5.Text = "Correo:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(102, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(300, 172)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(91, 504)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.CheckEdit1
        Me.LayoutControlItem18.Location = New System.Drawing.Point(938, 96)
        Me.LayoutControlItem18.MaxSize = New System.Drawing.Size(83, 24)
        Me.LayoutControlItem18.MinSize = New System.Drawing.Size(83, 24)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(83, 24)
        Me.LayoutControlItem18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.ID = New System.Guid("810556be-aa55-41b5-8f23-27eef32eb24f")
        Me.DockPanel1.Location = New System.Drawing.Point(1041, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(140, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(140, 696)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(133, 667)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'FrmUsuarios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1181, 696)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "FrmUsuarios"
        Me.Text = "Registrar Usuarios"
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRepetirPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.dgCajas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbRoles.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCargo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Rutinas As New VB.SysContab.Rutinas()
    Dim Disponibles As DataSet = New DataSet()
    Dim DisTable As DataTable = Disponibles.Tables.Add("Disponibles")
    Dim DisRow As DataRow = DisTable.NewRow()
    Dim D1 As DataColumn = DisTable.Columns.Add("D1")
    Dim D2 As DataColumn = DisTable.Columns.Add("D2")

    Dim Seleccionados As DataSet = New DataSet()
    Dim workTable As DataTable = Seleccionados.Tables.Add("Seleccionados")
    Dim workRow As DataRow = workTable.NewRow()
    Dim c1 As DataColumn = workTable.Columns.Add("c1")
    Dim c2 As DataColumn = workTable.Columns.Add("c2")


    Dim Empresas As DataSet = New DataSet()
    Dim EmprTable As DataTable = Empresas.Tables.Add("Empresas")
    Dim EmprRow As DataRow = EmprTable.NewRow()
    Dim E1 As DataColumn = EmprTable.Columns.Add("e1")
    Dim E2 As DataColumn = EmprTable.Columns.Add("e2")


    Dim Asignadas As DataSet = New DataSet()
    Dim AsignTable As DataTable = Asignadas.Tables.Add("Asignadas")
    Dim AsingRow As DataRow = AsignTable.NewRow()
    Dim A1 As DataColumn = AsignTable.Columns.Add("a1")
    Dim A2 As DataColumn = AsignTable.Columns.Add("a2")

    Private Sub FrmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)
        'Rutinas.FormularioColor(Me)
        'VB.SysContab.Rutinas.CambiarEstilo(Me)

        'Me.cbRoles.Properties.DataSource = ObtieneDatos("SELECT 0 ID,'[Seleccione Rol]' Nombre,'' Descripcion UNION SELECT ID,Nombre,Descripcion FROM REST_Roles").DefaultView
        'Me.cbRoles.Properties.DisplayMember = "Nombre"
        'Me.cbRoles.Properties.ValueMember = "ID"
        'Me.cbRoles.Properties.PopulateColumns()
        'Me.cbRoles.Properties.Columns("ID").Visible = False
        'Me.cbRoles.Properties.Columns("Descripcion").Visible = False
        'Me.cbRoles.EditValue = 0

        SearchLookUp(
            cbRoles,
            ObtieneDatos("sp_sel_REST_Roles", 0),
            "Nombre",
            "ID", 0)

        Dim Ds As DataSet = VB.SysContab.SeguridadDB.GetRolesActivos()

        Dim i As Integer

        For i = 0 To Ds.Tables("Tabla").Rows.Count - 1
            DisRow = DisTable.NewRow()
            DisRow(D1) = Ds.Tables("Tabla").Rows(i).Item("Rol")
            DisRow(D2) = Ds.Tables("Tabla").Rows(i).Item("Nombre")
            DisTable.Rows.Add(DisRow)
        Next

        lbRecursos.DataSource = Disponibles.Tables("Disponibles")
        lbRecursos.ValueMember = "D1"
        lbRecursos.DisplayMember = "D2"


        Dim Empr As New VB.SysContab.EmpresasDB()

        Dim DsEmpr As DataSet = Empr.List()

        For i = 0 To DsEmpr.Tables("Empresas").Rows.Count - 1
            EmprRow = EmprTable.NewRow()
            EmprRow(E1) = DsEmpr.Tables("Empresas").Rows(i).Item("Codigo")
            EmprRow(E2) = DsEmpr.Tables("Empresas").Rows(i).Item("Nombre")
            EmprTable.Rows.Add(EmprRow)
        Next

        lbEmpresas.DataSource = Empresas.Tables("Empresas")
        lbEmpresas.ValueMember = "e1"
        lbEmpresas.DisplayMember = "e2"

        'UserDetails = VB.SysContab.SeguridadDB.Login(Login, Password)

        Me.dgCajas.DataSource = ObtieneDatos("sp_GetCajasUsuario 0," & EmpresaActual)
        Me.vVista.PopulateColumns()
        FormatoGridNew(vVista, 2, 0, False, True, True, True, "Asignar Cajas de Facturación")
        '
        For cont As Integer = 0 To Me.vVista.Columns.Count - 1
            Me.vVista.Columns(cont).OptionsColumn.AllowEdit = False
        Next
        Me.vVista.Columns("Asignar").OptionsColumn.AllowEdit = True
        Me.vVista.Columns("Codigo").Visible = False
        Me.vVista.BestFitColumns()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Not DxValidationProvider1.Validate Then Exit Sub
        'If Me.cbRoles.ItemIndex = 0 Then
        '    XtraMsg("Seleccione el Rol del Usuario", MessageBoxIcon.Information)
        '    Exit Sub
        'End If

        If txtPassword.Text = txtRepetirPassword.Text Then

            Dim DBConn As SqlConnection
            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())
            Dim Transaccion As SqlTransaction
            Dim i As Integer = 0

            Try

                DBConn.Open()
                Transaccion = DBConn.BeginTransaction

                Dim UserID As String = VB.SysContab.SeguridadDB.
                    UsuariosAdd(
                    txtUsuario.Text,
                    txtNombre.Text,
                    txtPassword.Text,
                    txtEmail.Text,
                    ckHabilitado.Checked,
                    txtCargo.Text,
                    txtTelefono.Text,
                    DBConn,
                    Transaccion,
                    cbRoles.EditValue)

                For i = 0 To Asignadas.Tables("Asignadas").Rows.Count < -1
                    VB.SysContab.SeguridadDB.UsuarioEmpresasAdd(UserID, Asignadas.Tables("Asignadas").Rows(i).Item("a1"), DBConn, Transaccion)
                Next

                For i = 0 To Seleccionados.Tables("seleccionados").Rows.Count - 1
                    VB.SysContab.SeguridadDB.UsuariosRolesAdd(Seleccionados.Tables("seleccionados").Rows(i).Item("C1"), UserID, DBConn, Transaccion)
                Next

                Transaccion.Commit()
                DBConn.Close()

                '   Agregar Cajas a Usuario
                For i = 0 To Me.vVista.DataRowCount - 1
                    If Me.vVista.GetRowCellValue(i, "Asignar") Then
                        GuardaDatos("INSERT INTO UsuariosCaja VALUES (" & UserID & "," & Me.vVista.GetRowCellValue(i, "Codigo") & "," & EmpresaActual & ")")
                    End If
                Next

                '****************  Guardar Usuario en SQL ********************
                Try
                    Dim Variables As New ArrayList
                    Dim Datos As New ArrayList
                    '
                    Variables.Add("Nombre")
                    Variables.Add("Login")
                    Variables.Add("Password")
                    '
                    Datos.Add(txtNombre.Text)
                    Datos.Add(txtUsuario.Text)
                    Datos.Add(txtPassword.Text)
                    ProcedureParameters(Datos, Variables, "SPGuardaUsuario")

                Catch ex As Exception
                    XtraMsg("Error al crear usuario en SQL: " & ex.Message, MessageBoxIcon.Error)
                    VB.SysContab.SeguridadDB.UsuariosBorrar(UserID)
                End Try
                '****************  Fin Guardar Usuario en SQL ******************

                XtraMsg("Se ha Registrado Correctamente el Usuario")
                Me.Close()

                Dim f As FrmUsuariosListar = FrmUsuariosListar.Instance
                f.Cargar()
            Catch ex As Exception
                XtraMsg("Error: " & ex.Message, MessageBoxIcon.Error)
                Transaccion.Rollback()
                DBConn.Close()
            End Try
        Else
            XtraMsg("El Password debe coincidir en el campo repetir Password", MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If lbRecursos.Items.Count > 0 Then

            workRow = workTable.NewRow()
            workRow(c1) = lbRecursos.SelectedValue
            workRow(c2) = lbRecursos.Text
            workTable.Rows.Add(workRow)

            lbAsignados.DataSource = Seleccionados.Tables("Seleccionados")
            lbAsignados.ValueMember = "c1"
            lbAsignados.DisplayMember = "c2"

            Disponibles.Tables("Disponibles").Rows(lbRecursos.SelectedIndex).Delete()

        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If lbAsignados.Items.Count > 0 Then

            DisRow = DisTable.NewRow()
            DisRow(D1) = lbAsignados.SelectedValue
            DisRow(D2) = lbAsignados.Text
            DisTable.Rows.Add(DisRow)

            lbRecursos.DataSource = Disponibles.Tables("Disponibles")
            lbRecursos.ValueMember = "D1"
            lbRecursos.DisplayMember = "D2"

            Seleccionados.Tables("Seleccionados").Rows(lbAsignados.SelectedIndex).Delete()

        End If

    End Sub

    Private Sub cmdAcumulado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcumulado.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If lbEmpresas.Items.Count > 0 Then

            AsingRow = AsignTable.NewRow()
            AsingRow(A1) = lbEmpresas.SelectedValue
            AsingRow(A2) = lbEmpresas.Text
            AsignTable.Rows.Add(AsingRow)

            lbEmprAsign.DataSource = Asignadas.Tables("Asignadas")
            lbEmprAsign.ValueMember = "a1"
            lbEmprAsign.DisplayMember = "a2"

            Empresas.Tables("Empresas").Rows(lbEmpresas.SelectedIndex).Delete()

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If lbEmprAsign.Items.Count > 0 Then



            EmprRow = EmprTable.NewRow()
            EmprRow(E1) = lbEmprAsign.SelectedValue
            EmprRow(E2) = lbEmprAsign.Text
            EmprTable.Rows.Add(EmprRow)

            lbEmpresas.DataSource = Empresas.Tables("Empresas")
            lbEmpresas.ValueMember = "e1"
            lbEmpresas.DisplayMember = "e2"

            Asignadas.Tables("Asignadas").Rows(lbEmprAsign.SelectedIndex).Delete()

        End If

    End Sub


    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtCargo_EditValueChanged(sender As Object, e As EventArgs) Handles txtCargo.EditValueChanged

    End Sub

    Private Sub lbEmpresas_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lbEmpresas_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lbEmpresas.SelectedIndexChanged

    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        For i As Integer = 0 To vVista.DataRowCount - 1
            vVista.SetRowCellValue(i, "Asignar", CheckEdit1.Checked)
        Next
        vVista.RefreshData()

    End Sub
End Class
