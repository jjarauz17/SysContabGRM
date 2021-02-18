Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Entities

Public Class FrmUsuariosEditar
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As FrmUsuariosEditar = Nothing

    Public Shared Function Instance() As FrmUsuariosEditar
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmUsuariosEditar()
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents cmdAcumulado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgCajas As DevExpress.XtraGrid.GridControl
    Friend WithEvents vVista As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbAsignados As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbRecursos As System.Windows.Forms.ListBox
    Friend WithEvents Button2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbEmprAsign As System.Windows.Forms.ListBox
    Friend WithEvents Button4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbEmpresas As System.Windows.Forms.ListBox
    Friend WithEvents Button3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents FrmUsuariosEditarConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents DockPanel3 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel3_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents dgSucursales As DevExpress.XtraGrid.GridControl
    Friend WithEvents vSucursales As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblUserID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbCentroCosto As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents hideContainerLeft As DevExpress.XtraBars.Docking.AutoHideContainer
    Friend WithEvents LayoutControl3 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtRepetirPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ckHabilitado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbSucursales As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbBodega As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents pFirma As DevExpress.XtraEditors.PictureEdit
    Private WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtCargo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbRoles As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtTelefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuariosEditar))
        Me.cmdAcumulado = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl3 = New DevExpress.XtraLayout.LayoutControl()
        Me.Button3 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button4 = New DevExpress.XtraEditors.SimpleButton()
        Me.lbEmprAsign = New System.Windows.Forms.ListBox()
        Me.lbEmpresas = New System.Windows.Forms.ListBox()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lblUserID = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.lbAsignados = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton()
        Me.lbRecursos = New System.Windows.Forms.ListBox()
        Me.Button2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.dgCajas = New DevExpress.XtraGrid.GridControl()
        Me.vVista = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.cbCentroCosto = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.FrmUsuariosEditarConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.txtTelefono = New DevExpress.XtraEditors.TextEdit()
        Me.cbRoles = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtCargo = New DevExpress.XtraEditors.TextEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.pFirma = New DevExpress.XtraEditors.PictureEdit()
        Me.cbBodega = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.cbSucursales = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.ckHabilitado = New DevExpress.XtraEditors.CheckEdit()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.txtRepetirPassword = New DevExpress.XtraEditors.TextEdit()
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.txtUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.iGrid = New DevExpress.XtraGrid.GridControl()
        Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.hideContainerLeft = New DevExpress.XtraBars.Docking.AutoHideContainer()
        Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockPanel3 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel3_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.dgSucursales = New DevExpress.XtraGrid.GridControl()
        Me.vSucursales = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.LayoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl3.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCajas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCentroCosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrmUsuariosEditarConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrmUsuariosEditarConvertedLayout.SuspendLayout()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbRoles.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCargo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pFirma.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbBodega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSucursales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckHabilitado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRepetirPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hideContainerLeft.SuspendLayout()
        Me.DockPanel2.SuspendLayout()
        Me.DockPanel2_Container.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel3.SuspendLayout()
        Me.DockPanel3_Container.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.dgSucursales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vSucursales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAcumulado
        '
        Me.cmdAcumulado.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAcumulado.Appearance.Options.UseFont = True
        Me.cmdAcumulado.ImageOptions.SvgImage = CType(resources.GetObject("cmdAcumulado.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.cmdAcumulado.Location = New System.Drawing.Point(12, 52)
        Me.cmdAcumulado.Name = "cmdAcumulado"
        Me.cmdAcumulado.Size = New System.Drawing.Size(109, 36)
        Me.cmdAcumulado.StyleController = Me.LayoutControl3
        Me.cmdAcumulado.TabIndex = 36
        Me.cmdAcumulado.Text = "&Salir"
        '
        'LayoutControl3
        '
        Me.LayoutControl3.Controls.Add(Me.Button3)
        Me.LayoutControl3.Controls.Add(Me.Button4)
        Me.LayoutControl3.Controls.Add(Me.lbEmprAsign)
        Me.LayoutControl3.Controls.Add(Me.lbEmpresas)
        Me.LayoutControl3.Controls.Add(Me.PanelControl1)
        Me.LayoutControl3.Controls.Add(Me.cmdAcumulado)
        Me.LayoutControl3.Controls.Add(Me.cmdAceptar)
        Me.LayoutControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl3.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem16, Me.LayoutControlItem19, Me.LayoutControlItem18, Me.LayoutControlItem20, Me.LayoutControlItem17})
        Me.LayoutControl3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl3.Name = "LayoutControl3"
        Me.LayoutControl3.Root = Me.LayoutControlGroup4
        Me.LayoutControl3.Size = New System.Drawing.Size(133, 421)
        Me.LayoutControl3.TabIndex = 52
        Me.LayoutControl3.Text = "LayoutControl3"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 96)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 22)
        Me.Button3.StyleController = Me.LayoutControl3
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "< Quitar"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 96)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 22)
        Me.Button4.StyleController = Me.LayoutControl3
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Asignar >"
        '
        'lbEmprAsign
        '
        Me.lbEmprAsign.Location = New System.Drawing.Point(12, 96)
        Me.lbEmprAsign.Name = "lbEmprAsign"
        Me.lbEmprAsign.Size = New System.Drawing.Size(108, 355)
        Me.lbEmprAsign.TabIndex = 1
        '
        'lbEmpresas
        '
        Me.lbEmpresas.Location = New System.Drawing.Point(12, 122)
        Me.lbEmpresas.Name = "lbEmpresas"
        Me.lbEmpresas.Size = New System.Drawing.Size(108, 160)
        Me.lbEmpresas.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lblUserID)
        Me.PanelControl1.Controls.Add(Me.PanelControl4)
        Me.PanelControl1.Controls.Add(Me.Label5)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 96)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(108, 510)
        Me.PanelControl1.TabIndex = 51
        '
        'lblUserID
        '
        Me.lblUserID.Location = New System.Drawing.Point(27, 105)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(43, 13)
        Me.lblUserID.TabIndex = 51
        Me.lblUserID.Text = "lblUserID"
        Me.lblUserID.Visible = False
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.lbAsignados)
        Me.PanelControl4.Controls.Add(Me.Label4)
        Me.PanelControl4.Controls.Add(Me.Button1)
        Me.PanelControl4.Controls.Add(Me.lbRecursos)
        Me.PanelControl4.Controls.Add(Me.Button2)
        Me.PanelControl4.Location = New System.Drawing.Point(5, 155)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(96, 34)
        Me.PanelControl4.TabIndex = 50
        Me.PanelControl4.Visible = False
        '
        'lbAsignados
        '
        Me.lbAsignados.Location = New System.Drawing.Point(290, 23)
        Me.lbAsignados.Name = "lbAsignados"
        Me.lbAsignados.Size = New System.Drawing.Size(208, 121)
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(223, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 25)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Asignar >"
        '
        'lbRecursos
        '
        Me.lbRecursos.Location = New System.Drawing.Point(9, 23)
        Me.lbRecursos.Name = "lbRecursos"
        Me.lbRecursos.Size = New System.Drawing.Size(208, 121)
        Me.lbRecursos.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(223, 75)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 25)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "< Quitar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(6, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 16)
        Me.Label5.TabIndex = 136
        Me.Label5.Text = "Roles Disponibles"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.ImageOptions.SvgImage = CType(resources.GetObject("cmdAceptar.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.cmdAceptar.Location = New System.Drawing.Point(12, 12)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(109, 36)
        Me.cmdAceptar.StyleController = Me.LayoutControl3
        Me.cmdAceptar.TabIndex = 34
        Me.cmdAceptar.Text = "&Guardar"
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.PanelControl1
        Me.LayoutControlItem16.CustomizationFormText = "LayoutControlItem16"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(112, 514)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.Button4
        Me.LayoutControlItem19.CustomizationFormText = "LayoutControlItem19"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(112, 26)
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.lbEmpresas
        Me.LayoutControlItem18.CustomizationFormText = "LayoutControlItem18"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 110)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(112, 166)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.Button3
        Me.LayoutControlItem20.CustomizationFormText = "LayoutControlItem20"
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(112, 26)
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.lbEmprAsign
        Me.LayoutControlItem17.CustomizationFormText = "LayoutControlItem17"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(112, 359)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "LayoutControlGroup4"
        Me.LayoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup4.GroupBordersVisible = False
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem15})
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(133, 421)
        Me.LayoutControlGroup4.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmdAceptar
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(113, 40)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.cmdAcumulado
        Me.LayoutControlItem15.CustomizationFormText = "LayoutControlItem15"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(113, 361)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'dgCajas
        '
        Me.dgCajas.Location = New System.Drawing.Point(12, 36)
        Me.dgCajas.MainView = Me.vVista
        Me.dgCajas.Name = "dgCajas"
        Me.dgCajas.Size = New System.Drawing.Size(319, 373)
        Me.dgCajas.TabIndex = 48
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
        Me.GridBand1.Caption = "Asignar Cajas - Facturación de Ventas"
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.VisibleIndex = 0
        '
        'cbCentroCosto
        '
        Me.cbCentroCosto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCentroCosto.Location = New System.Drawing.Point(148, 132)
        Me.cbCentroCosto.Name = "cbCentroCosto"
        Me.cbCentroCosto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCentroCosto.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.cbCentroCosto.Properties.Appearance.Options.UseFont = True
        Me.cbCentroCosto.Properties.Appearance.Options.UseForeColor = True
        Me.cbCentroCosto.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCentroCosto.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.MediumBlue
        Me.cbCentroCosto.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cbCentroCosto.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.cbCentroCosto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCentroCosto.Properties.DropDownRows = 10
        Me.cbCentroCosto.Properties.SelectAllItemCaption = "(Seleccionar Todo)"
        Me.cbCentroCosto.Size = New System.Drawing.Size(584, 20)
        Me.cbCentroCosto.StyleController = Me.FrmUsuariosEditarConvertedLayout
        Me.cbCentroCosto.TabIndex = 144
        '
        'FrmUsuariosEditarConvertedLayout
        '
        Me.FrmUsuariosEditarConvertedLayout.Controls.Add(Me.txtTelefono)
        Me.FrmUsuariosEditarConvertedLayout.Controls.Add(Me.cbRoles)
        Me.FrmUsuariosEditarConvertedLayout.Controls.Add(Me.txtCargo)
        Me.FrmUsuariosEditarConvertedLayout.Controls.Add(Me.CheckEdit1)
        Me.FrmUsuariosEditarConvertedLayout.Controls.Add(Me.pFirma)
        Me.FrmUsuariosEditarConvertedLayout.Controls.Add(Me.cbBodega)
        Me.FrmUsuariosEditarConvertedLayout.Controls.Add(Me.cbSucursales)
        Me.FrmUsuariosEditarConvertedLayout.Controls.Add(Me.ckHabilitado)
        Me.FrmUsuariosEditarConvertedLayout.Controls.Add(Me.txtEmail)
        Me.FrmUsuariosEditarConvertedLayout.Controls.Add(Me.txtRepetirPassword)
        Me.FrmUsuariosEditarConvertedLayout.Controls.Add(Me.txtPassword)
        Me.FrmUsuariosEditarConvertedLayout.Controls.Add(Me.txtUsuario)
        Me.FrmUsuariosEditarConvertedLayout.Controls.Add(Me.txtNombre)
        Me.FrmUsuariosEditarConvertedLayout.Controls.Add(Me.iGrid)
        Me.FrmUsuariosEditarConvertedLayout.Controls.Add(Me.cbCentroCosto)
        Me.FrmUsuariosEditarConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmUsuariosEditarConvertedLayout.Location = New System.Drawing.Point(21, 0)
        Me.FrmUsuariosEditarConvertedLayout.Name = "FrmUsuariosEditarConvertedLayout"
        Me.FrmUsuariosEditarConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1036, 327, 250, 350)
        Me.FrmUsuariosEditarConvertedLayout.Root = Me.LayoutControlGroup1
        Me.FrmUsuariosEditarConvertedLayout.Size = New System.Drawing.Size(744, 450)
        Me.FrmUsuariosEditarConvertedLayout.TabIndex = 144
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(571, 84)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(161, 20)
        Me.txtTelefono.StyleController = Me.FrmUsuariosEditarConvertedLayout
        Me.txtTelefono.TabIndex = 151
        '
        'cbRoles
        '
        Me.cbRoles.Location = New System.Drawing.Point(148, 108)
        Me.cbRoles.Name = "cbRoles"
        Me.cbRoles.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cbRoles.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.cbRoles.Properties.Appearance.Options.UseFont = True
        Me.cbRoles.Properties.Appearance.Options.UseForeColor = True
        Me.cbRoles.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbRoles.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.cbRoles.Size = New System.Drawing.Size(584, 20)
        Me.cbRoles.StyleController = Me.FrmUsuariosEditarConvertedLayout
        Me.cbRoles.TabIndex = 153
        Me.cbRoles.Tag = "True"
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'txtCargo
        '
        Me.txtCargo.Location = New System.Drawing.Point(148, 84)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(283, 20)
        Me.txtCargo.StyleController = Me.FrmUsuariosEditarConvertedLayout
        Me.txtCargo.TabIndex = 150
        Me.txtCargo.Tag = "True"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(606, 60)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit1.Properties.Caption = "Comite Crédito"
        Me.CheckEdit1.Size = New System.Drawing.Size(126, 20)
        Me.CheckEdit1.StyleController = Me.FrmUsuariosEditarConvertedLayout
        Me.CheckEdit1.TabIndex = 152
        '
        'pFirma
        '
        Me.pFirma.Cursor = System.Windows.Forms.Cursors.Default
        Me.pFirma.Location = New System.Drawing.Point(447, 221)
        Me.pFirma.Name = "pFirma"
        Me.pFirma.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.pFirma.Properties.ShowMenu = False
        Me.pFirma.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.pFirma.Size = New System.Drawing.Size(285, 153)
        Me.pFirma.StyleController = Me.FrmUsuariosEditarConvertedLayout
        Me.pFirma.TabIndex = 152
        '
        'cbBodega
        '
        Me.cbBodega.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbBodega.Location = New System.Drawing.Point(148, 180)
        Me.cbBodega.Name = "cbBodega"
        Me.cbBodega.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBodega.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.cbBodega.Properties.Appearance.Options.UseFont = True
        Me.cbBodega.Properties.Appearance.Options.UseForeColor = True
        Me.cbBodega.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBodega.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.MediumBlue
        Me.cbBodega.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cbBodega.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.cbBodega.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbBodega.Properties.DropDownRows = 10
        Me.cbBodega.Properties.SelectAllItemCaption = "(Seleccionar Todo)"
        Me.cbBodega.Size = New System.Drawing.Size(584, 20)
        Me.cbBodega.StyleController = Me.FrmUsuariosEditarConvertedLayout
        Me.cbBodega.TabIndex = 148
        '
        'cbSucursales
        '
        Me.cbSucursales.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbSucursales.Location = New System.Drawing.Point(148, 156)
        Me.cbSucursales.Name = "cbSucursales"
        Me.cbSucursales.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSucursales.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.cbSucursales.Properties.Appearance.Options.UseFont = True
        Me.cbSucursales.Properties.Appearance.Options.UseForeColor = True
        Me.cbSucursales.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSucursales.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.MediumBlue
        Me.cbSucursales.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cbSucursales.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.cbSucursales.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbSucursales.Properties.DropDownRows = 10
        Me.cbSucursales.Properties.SelectAllItemCaption = "(Seleccionar Todo)"
        Me.cbSucursales.Size = New System.Drawing.Size(584, 20)
        Me.cbSucursales.StyleController = Me.FrmUsuariosEditarConvertedLayout
        Me.cbSucursales.TabIndex = 147
        '
        'ckHabilitado
        '
        Me.ckHabilitado.Enabled = False
        Me.ckHabilitado.Location = New System.Drawing.Point(499, 60)
        Me.ckHabilitado.Name = "ckHabilitado"
        Me.ckHabilitado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckHabilitado.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.ckHabilitado.Properties.Appearance.Options.UseFont = True
        Me.ckHabilitado.Properties.Appearance.Options.UseForeColor = True
        Me.ckHabilitado.Properties.Caption = "Habilitado"
        Me.ckHabilitado.Size = New System.Drawing.Size(103, 20)
        Me.ckHabilitado.StyleController = Me.FrmUsuariosEditarConvertedLayout
        Me.ckHabilitado.TabIndex = 151
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(148, 60)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Size = New System.Drawing.Size(347, 20)
        Me.txtEmail.StyleController = Me.FrmUsuariosEditarConvertedLayout
        Me.txtEmail.TabIndex = 149
        Me.txtEmail.Tag = "True"
        '
        'txtRepetirPassword
        '
        Me.txtRepetirPassword.Location = New System.Drawing.Point(510, 36)
        Me.txtRepetirPassword.Name = "txtRepetirPassword"
        Me.txtRepetirPassword.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtRepetirPassword.Properties.Appearance.Options.UseBackColor = True
        Me.txtRepetirPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtRepetirPassword.Size = New System.Drawing.Size(222, 20)
        Me.txtRepetirPassword.StyleController = Me.FrmUsuariosEditarConvertedLayout
        Me.txtRepetirPassword.TabIndex = 150
        Me.txtRepetirPassword.Tag = "True"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(148, 36)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtPassword.Properties.Appearance.Options.UseBackColor = True
        Me.txtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Size = New System.Drawing.Size(222, 20)
        Me.txtPassword.StyleController = Me.FrmUsuariosEditarConvertedLayout
        Me.txtPassword.TabIndex = 149
        Me.txtPassword.Tag = "True"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(510, 12)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtUsuario.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtUsuario.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtUsuario.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtUsuario.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtUsuario.Properties.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(222, 20)
        Me.txtUsuario.StyleController = Me.FrmUsuariosEditarConvertedLayout
        Me.txtUsuario.TabIndex = 149
        Me.txtUsuario.Tag = "True"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(148, 12)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(222, 20)
        Me.txtNombre.StyleController = Me.FrmUsuariosEditarConvertedLayout
        Me.txtNombre.TabIndex = 148
        Me.txtNombre.Tag = "True"
        '
        'iGrid
        '
        Me.iGrid.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.iGrid.Location = New System.Drawing.Point(12, 223)
        Me.iGrid.MainView = Me.iVista
        Me.iGrid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.iGrid.Name = "iGrid"
        Me.iGrid.Size = New System.Drawing.Size(431, 215)
        Me.iGrid.TabIndex = 147
        Me.iGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista})
        '
        'iVista
        '
        Me.iVista.GridControl = Me.iGrid
        Me.iVista.Name = "iVista"
        Me.iVista.OptionsView.ShowAutoFilterRow = True
        Me.iVista.OptionsView.ShowFooter = True
        Me.iVista.OptionsView.ShowGroupPanel = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem14, Me.LayoutControlItem4, Me.LayoutControlItem21, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem22, Me.LayoutControlItem23, Me.EmptySpaceItem1, Me.LayoutControlItem24, Me.LayoutControlItem25, Me.LayoutControlItem26, Me.LayoutControlItem13})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(744, 450)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.cbCentroCosto
        Me.LayoutControlItem14.CustomizationFormText = "Centro de Costo:"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(724, 24)
        Me.LayoutControlItem14.Text = "Centro de Costo:"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(133, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem4.Control = Me.iGrid
        Me.LayoutControlItem4.CustomizationFormText = "Empresas Asignadas"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 192)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(435, 238)
        Me.LayoutControlItem4.Text = "Empresas Asignadas"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(133, 16)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.txtNombre
        Me.LayoutControlItem21.CustomizationFormText = "Nombre Completo:"
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(362, 24)
        Me.LayoutControlItem21.Text = "Nombre Completo:"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(133, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtUsuario
        Me.LayoutControlItem7.CustomizationFormText = "Nombre de Usuario:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(362, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(362, 24)
        Me.LayoutControlItem7.Text = "Login:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(133, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtPassword
        Me.LayoutControlItem8.CustomizationFormText = "Contraseña:"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(362, 24)
        Me.LayoutControlItem8.Text = "Contraseña:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(133, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtRepetirPassword
        Me.LayoutControlItem9.CustomizationFormText = "Repetir Contraseña:"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(362, 24)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(362, 24)
        Me.LayoutControlItem9.Text = "Repetir Contraseña:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(133, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtEmail
        Me.LayoutControlItem10.CustomizationFormText = "Correo Electronico:"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(487, 24)
        Me.LayoutControlItem10.Text = "Correo Electronico:"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(133, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.ckHabilitado
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(487, 48)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(107, 24)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(107, 24)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(107, 24)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cbSucursales
        Me.LayoutControlItem12.CustomizationFormText = "Sucursal:"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(724, 24)
        Me.LayoutControlItem12.Text = "Sucursal:"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(133, 13)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.cbBodega
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(724, 24)
        Me.LayoutControlItem22.Text = "Bodega:"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(133, 13)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem23.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem23.Control = Me.pFirma
        Me.LayoutControlItem23.CustomizationFormText = "Firma Digital"
        Me.LayoutControlItem23.Location = New System.Drawing.Point(435, 192)
        Me.LayoutControlItem23.MaxSize = New System.Drawing.Size(289, 174)
        Me.LayoutControlItem23.MinSize = New System.Drawing.Size(289, 174)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(289, 174)
        Me.LayoutControlItem23.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem23.Text = "Firma Digital"
        Me.LayoutControlItem23.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(133, 14)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(435, 366)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(289, 64)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.CheckEdit1
        Me.LayoutControlItem24.Location = New System.Drawing.Point(594, 48)
        Me.LayoutControlItem24.MaxSize = New System.Drawing.Size(130, 24)
        Me.LayoutControlItem24.MinSize = New System.Drawing.Size(130, 24)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(130, 24)
        Me.LayoutControlItem24.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem24.TextVisible = False
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.txtCargo
        Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(423, 24)
        Me.LayoutControlItem25.Text = "Cargo:"
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(133, 13)
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.cbRoles
        Me.LayoutControlItem26.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(724, 24)
        Me.LayoutControlItem26.Text = "Rol Asignado:"
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(133, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtTelefono
        Me.LayoutControlItem13.Location = New System.Drawing.Point(423, 72)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(301, 24)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(301, 24)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(301, 24)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.Text = "Telefono:"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(133, 13)
        '
        'CheckBox1
        '
        Me.CheckBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Red
        Me.CheckBox1.Location = New System.Drawing.Point(12, 12)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(319, 20)
        Me.CheckBox1.TabIndex = 143
        Me.CheckBox1.Text = "Seleccionar Todo"
        '
        'DockManager1
        '
        Me.DockManager1.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerLeft})
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'hideContainerLeft
        '
        Me.hideContainerLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.hideContainerLeft.Controls.Add(Me.DockPanel2)
        Me.hideContainerLeft.Controls.Add(Me.DockPanel3)
        Me.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.hideContainerLeft.Location = New System.Drawing.Point(0, 0)
        Me.hideContainerLeft.Name = "hideContainerLeft"
        Me.hideContainerLeft.Size = New System.Drawing.Size(21, 450)
        '
        'DockPanel2
        '
        Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
        Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel2.FloatSize = New System.Drawing.Size(300, 200)
        Me.DockPanel2.ID = New System.Guid("0bab771d-7e41-404a-a87f-a9369385ef12")
        Me.DockPanel2.Location = New System.Drawing.Point(21, 0)
        Me.DockPanel2.Name = "DockPanel2"
        Me.DockPanel2.Options.ShowCloseButton = False
        Me.DockPanel2.OriginalSize = New System.Drawing.Size(350, 200)
        Me.DockPanel2.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel2.SavedIndex = 2
        Me.DockPanel2.Size = New System.Drawing.Size(350, 450)
        Me.DockPanel2.Text = "Asignar Cajas"
        Me.DockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Controls.Add(Me.LayoutControl1)
        Me.DockPanel2_Container.Location = New System.Drawing.Point(3, 26)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(343, 421)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.dgCajas)
        Me.LayoutControl1.Controls.Add(Me.CheckBox1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup2
        Me.LayoutControl1.Size = New System.Drawing.Size(343, 421)
        Me.LayoutControl1.TabIndex = 144
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3})
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(343, 421)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dgCajas
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(323, 377)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.CheckBox1
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(323, 24)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'DockPanel3
        '
        Me.DockPanel3.Controls.Add(Me.DockPanel3_Container)
        Me.DockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel3.ID = New System.Guid("c50d9137-a1ff-44da-af9b-6324b96fae66")
        Me.DockPanel3.Location = New System.Drawing.Point(21, 0)
        Me.DockPanel3.Name = "DockPanel3"
        Me.DockPanel3.Options.ShowCloseButton = False
        Me.DockPanel3.OriginalSize = New System.Drawing.Size(400, 200)
        Me.DockPanel3.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel3.SavedIndex = 0
        Me.DockPanel3.Size = New System.Drawing.Size(400, 450)
        Me.DockPanel3.Text = "Asignar Series de Facturas"
        Me.DockPanel3.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'DockPanel3_Container
        '
        Me.DockPanel3_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel3_Container.Location = New System.Drawing.Point(3, 26)
        Me.DockPanel3_Container.Name = "DockPanel3_Container"
        Me.DockPanel3_Container.Size = New System.Drawing.Size(393, 421)
        Me.DockPanel3_Container.TabIndex = 0
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.CheckBox2)
        Me.LayoutControl2.Controls.Add(Me.dgSucursales)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup3
        Me.LayoutControl2.Size = New System.Drawing.Size(393, 421)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'CheckBox2
        '
        Me.CheckBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.Red
        Me.CheckBox2.Location = New System.Drawing.Point(12, 12)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(369, 20)
        Me.CheckBox2.TabIndex = 145
        Me.CheckBox2.Text = "Seleccionar Todo"
        '
        'dgSucursales
        '
        Me.dgSucursales.Location = New System.Drawing.Point(12, 36)
        Me.dgSucursales.MainView = Me.vSucursales
        Me.dgSucursales.Name = "dgSucursales"
        Me.dgSucursales.Size = New System.Drawing.Size(369, 373)
        Me.dgSucursales.TabIndex = 145
        Me.dgSucursales.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vSucursales})
        '
        'vSucursales
        '
        Me.vSucursales.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand2})
        Me.vSucursales.GridControl = Me.dgSucursales
        Me.vSucursales.Name = "vSucursales"
        Me.vSucursales.OptionsView.ShowFooter = True
        Me.vSucursales.OptionsView.ShowGroupPanel = False
        '
        'GridBand2
        '
        Me.GridBand2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridBand2.AppearanceHeader.Options.UseFont = True
        Me.GridBand2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand2.Caption = "Facturas Series"
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.VisibleIndex = 0
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem6})
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(393, 421)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.dgSucursales
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(373, 377)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.CheckBox2
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(373, 24)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.ID = New System.Guid("172991a3-5abc-40b5-9bbc-4b9b2b3ce20f")
        Me.DockPanel1.Location = New System.Drawing.Point(765, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(140, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(140, 450)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl3)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(133, 421)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'FrmUsuariosEditar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(905, 450)
        Me.Controls.Add(Me.FrmUsuariosEditarConvertedLayout)
        Me.Controls.Add(Me.DockPanel1)
        Me.Controls.Add(Me.hideContainerLeft)
        Me.Name = "FrmUsuariosEditar"
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl3.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCajas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCentroCosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrmUsuariosEditarConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrmUsuariosEditarConvertedLayout.ResumeLayout(False)
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbRoles.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCargo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pFirma.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbBodega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSucursales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckHabilitado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRepetirPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hideContainerLeft.ResumeLayout(False)
        Me.DockPanel2.ResumeLayout(False)
        Me.DockPanel2_Container.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel3.ResumeLayout(False)
        Me.DockPanel3_Container.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.dgSucursales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vSucursales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
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
    '
    Dim PasswordActual As String = vbNullString

    Dim objComite As New ClientesComiteCredito
    Dim dbComite As New db_ClientesComiteCredito

    Private Sub FrmUsuariosEditar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)

        'Rutinas.FormularioColor(Me)
        'VB.SysContab.Rutinas.CambiarEstilo(Me)

        'Me.cbRoles.Properties.DataSource = ObtieneDatos("SELECT 0 ID,'-- Seleccione Rol --' Nombre,'' Descripcion UNION SELECT ID,Nombre,Descripcion FROM REST_Roles").DefaultView
        'Me.cbRoles.Properties.DisplayMember = "Nombre"
        'Me.cbRoles.Properties.ValueMember = "ID"
        'Me.cbRoles.Properties.PopulateColumns()
        'Me.cbRoles.Properties.Columns("ID").Visible = False
        'Me.cbRoles.EditValue = 0

        SearchLookUp(
            cbRoles,
            ObtieneDatos("sp_sel_REST_Roles", 0),
            "Nombre",
            "ID", 0)

        GetCentrosCostosList(cbCentroCosto)
        GetSucursales_CheckList(cbSucursales)
        GetBodegasList(cbBodega)

        Dim DsUser As DataSet =
            VB.SysContab.SeguridadDB.GetUsuario(lblUserID.Text)

        txtNombre.Text = DsUser.Tables("Usuarios").Rows(0).Item("Usr_NombreCompleto").ToString
        txtUsuario.Text = DsUser.Tables("Usuarios").Rows(0).Item("Usr_Login").ToString
        txtPassword.Text = DsUser.Tables("Usuarios").Rows(0).Item("Usr_Password").ToString
        txtRepetirPassword.Text = DsUser.Tables("Usuarios").Rows(0).Item("Usr_Password").ToString
        txtEmail.Text = DsUser.Tables("Usuarios").Rows(0).Item("Usr_email").ToString
        ckHabilitado.Checked = DsUser.Tables("Usuarios").Rows(0).Item("Usr_Habilitado")
        Me.cbRoles.EditValue = DsUser.Tables("Usuarios").Rows(0).Item("Usr_Rol")
        PasswordActual = Me.txtPassword.Text
        txtCargo.Text = DsUser.Tables("Usuarios").Rows(0).Item("Cargo")
        txtTelefono.Text = DsUser.Tables("Usuarios").Rows(0).Item("Telefono")

        If Not dbComite.Detalles(CInt(lblUserID.Text), EmpresaActual) Is Nothing Then
            CheckEdit1.Checked = True
        End If

        'Centros de Costos
        Try
            cbCentroCosto.SetEditValue(ObtieneDatos("SELECT ucc.CentroCosto FROM UsuariosCentrosCostos AS ucc WHERE ucc.Usuario = " & lblUserID.Text & " AND ucc.Empresa = " & EmpresaActual).Rows.Item(0)(0))
        Catch ex As Exception
            cbCentroCosto.SetEditValue(DsUser.Tables("Usuarios").Rows(0).Item("Centro"))
        End Try
        'Sucursales
        Try
            cbSucursales.SetEditValue(ObtieneDatos("SELECT us.Sucursal FROM UsuariosSucursales AS us WHERE us.IdUsuario = " & lblUserID.Text & " AND us.Empresa = " & EmpresaActual).Rows.Item(0)(0))
        Catch ex As Exception
            cbSucursales.SetEditValue("")
        End Try
        'Bodegas
        Try
            cbBodega.SetEditValue(ObtieneDatos("SELECT ub.Bodega FROM UsuariosBodegas AS ub WHERE ub.Usuario = '" & lblUserID.Text & "' AND ub.Empresa = " & EmpresaActual).Rows.Item(0)(0))
        Catch ex As Exception
            cbBodega.SetEditValue(DsUser.Tables("Usuarios").Rows(0).Item("Bodega"))
        End Try

        CargarFirmaDigital()

        Dim Ds As DataSet = VB.SysContab.SeguridadDB.GetRolesActivos()

        Dim i As Integer
        Dim j As Integer
        Dim Cont As Integer = 0

        For i = 0 To Ds.Tables("Tabla").Rows.Count - 1

            Cont = 0

            For j = 0 To DsUser.Tables("UsuariosRoles").Rows.Count - 1

                If DsUser.Tables("UsuariosRoles").Rows(j).Item("Rol_ID") =
                        Ds.Tables("Tabla").Rows(i).Item("Rol") Then
                    Cont = Cont + 1
                    Exit For
                End If

            Next

            If Cont = 0 Then
                DisRow = DisTable.NewRow()
                DisRow(D1) = Ds.Tables("Tabla").Rows(i).Item("Rol")
                DisRow(D2) = Ds.Tables("Tabla").Rows(i).Item("Nombre")
                DisTable.Rows.Add(DisRow)
            End If

        Next

        lbRecursos.DataSource = Disponibles.Tables("Disponibles")
        lbRecursos.ValueMember = "D1"
        lbRecursos.DisplayMember = "D2"

        For i = 0 To DsUser.Tables("UsuariosRoles").Rows.Count - 1
            workRow = workTable.NewRow()
            workRow(c1) = DsUser.Tables("UsuariosRoles").Rows(i)("Rol_ID") 'Ds.Tables("Tabla").Rows(i).Item("Rol")
            workRow(c2) = DsUser.Tables("UsuariosRoles").Rows(i)("Nombre") 'Ds.Tables("Tabla").Rows(i).Item("Nombre")
            workTable.Rows.Add(workRow)
        Next

        lbAsignados.DataSource = Seleccionados.Tables("Seleccionados")
        lbAsignados.ValueMember = "c1"
        lbAsignados.DisplayMember = "c2"

        iGrid.DataSource =
            VB.SysContab.EmpresasDB.GetEmpresasAsignadas(lblUserID.Text)

        SimpleFormatGrid(iVista, True, DevExpress.Utils.HorzAlignment.Center, 0, 2, False, 0)

        For i = 0 To iVista.Columns.Count - 1
            iVista.Columns(i).OptionsColumn.AllowEdit = False
        Next

        iVista.Columns("ASIGNADA").OptionsColumn.AllowEdit = True


        Dim Empr As New VB.SysContab.EmpresasDB()

        Dim DsEmpr As DataSet = Empr.List()

        For i = 0 To DsEmpr.Tables("Empresas").Rows.Count - 1

            Cont = 0

            For j = 0 To DsUser.Tables("UsuariosEmpresas").Rows.Count - 1
                If DsUser.Tables("UsuariosEmpresas").Rows(j).Item("Empresa_ID") = DsEmpr.Tables("Empresas").Rows(i).Item("Codigo") Then
                    Cont = Cont + 1
                    Exit For
                End If
            Next

            If Cont = 0 Then
                EmprRow = EmprTable.NewRow()
                EmprRow(E1) = DsEmpr.Tables("Empresas").Rows(i).Item("Codigo")
                EmprRow(E2) = DsEmpr.Tables("Empresas").Rows(i).Item("Nombre")
                EmprTable.Rows.Add(EmprRow)
            End If
        Next

        lbEmpresas.DataSource = Empresas.Tables("Empresas")
        lbEmpresas.ValueMember = "e1"
        lbEmpresas.DisplayMember = "e2"



        For i = 0 To DsUser.Tables("UsuariosEmpresas").Rows.Count - 1
            AsingRow = AsignTable.NewRow()
            AsingRow(A1) = DsUser.Tables("UsuariosEmpresas").Rows(i)("Empresa_ID") 'DsEmpr.Tables("Empresas").Rows(i).Item("Codigo")
            AsingRow(A2) = DsUser.Tables("UsuariosEmpresas").Rows(i)("Nombre") 'DsEmpr.Tables("Empresas").Rows(i).Item("Nombre")
            AsignTable.Rows.Add(AsingRow)
        Next

        lbEmprAsign.DataSource = Asignadas.Tables("Asignadas")
        lbEmprAsign.ValueMember = "a1"
        lbEmprAsign.DisplayMember = "a2"

        ' Mostrar Cajas Asignadas al Usuario
        Me.dgCajas.DataSource = ObtieneDatos("sp_GetCajasUsuario", lblUserID.Text, EmpresaActual)
        Me.vVista.PopulateColumns()
        FormatoGrid(Me.vVista)
        '
        For t As Integer = 0 To Me.vVista.Columns.Count - 1
            Me.vVista.Columns(t).OptionsColumn.AllowEdit = False
        Next
        Me.vVista.Columns("Asignar").OptionsColumn.AllowEdit = True
        Me.vVista.Columns("Codigo").Visible = False
        Me.vVista.BestFitColumns()

        Me.dgSucursales.DataSource = ObtieneDatos("sp_GetCajasSeries " & lblUserID.Text & "," & EmpresaActual)
        Me.vSucursales.PopulateColumns()
        FormatoGrid(Me.vSucursales)
        '
        For t As Integer = 0 To Me.vSucursales.Columns.Count - 1
            Me.vSucursales.Columns(t).OptionsColumn.AllowEdit = False
        Next
        Me.vSucursales.Columns("Asignar").OptionsColumn.AllowEdit = True
        Me.vSucursales.BestFitColumns()
    End Sub

    Private Sub cmdAcumulado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcumulado.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Not DxValidationProvider1.Validate Then Exit Sub

        If txtPassword.Text <> txtRepetirPassword.Text Then
            XtraMsg("El Password debe coincidir en el campo repetir Password", MessageBoxIcon.Error)
            Me.txtPassword.Focus()
            Me.txtPassword.SelectAll()
            Exit Sub
        End If

        If PasswordActual <> Me.txtPassword.Text Then
            Dim Datos As New ArrayList
            Dim Variables As New ArrayList

            Datos.Add(txtUsuario.Text)
            Datos.Add(PasswordActual)
            Datos.Add(txtPassword.Text)
            Variables.Add("User")
            Variables.Add("Old")
            Variables.Add("Pass")

            If ProcedureSave(Datos, Variables, "SPChangePass") Then
                XtraMsg("Contraseña cambiada")
                If Login = Me.txtUsuario.Text Then
                    Password = txtPassword.Text
                End If
            Else
                XtraMsg("Error al cambiar la contraseña, intente nuevamente", MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        Dim DBConn As SqlConnection
        'Dim conexion As New VB.SysContab.Rutinas()
        DBConn = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        Dim Transaccion As SqlTransaction = Nothing

        Try

            DBConn.Open()
            Transaccion = DBConn.BeginTransaction

            VB.SysContab.SeguridadDB.
            UsuariosUpdate(
                lblUserID.Text,
                txtNombre.Text,
                txtUsuario.Text,
                txtPassword.Text,
                txtEmail.Text,
                ckHabilitado.Checked,
                DBConn,
                Transaccion,
                txtCargo.Text,
                txtTelefono.Text,
                cbRoles.EditValue,
                IIf(cbCentroCosto.EditValue Is Nothing, "", cbCentroCosto.EditValue),
                IIf(cbBodega.EditValue Is Nothing, "", cbBodega.EditValue))


            VB.SysContab.SeguridadDB.UsuariosRolesBorrar(lblUserID.Text, DBConn, Transaccion)
            VB.SysContab.SeguridadDB.UsuariosEmpresasBorrar(lblUserID.Text, DBConn, Transaccion)

            For i As Integer = 0 To Seleccionados.Tables("seleccionados").Rows.Count - 1
                VB.SysContab.SeguridadDB.UsuariosRolesAdd(Seleccionados.Tables("seleccionados").Rows(i).Item("C1"), lblUserID.Text, DBConn, Transaccion)
            Next

            'For i = 0 To Asignadas.Tables("Asignadas").Rows.Count - 1
            '    VB.SysContab.SeguridadDB.UsuarioEmpresasAdd(lblUserID.Text, Asignadas.Tables("Asignadas").Rows(i).Item("a1"), DBConn, Transaccion)
            'Next

            For i = 0 To iVista.DataRowCount - 1
                If iVista.GetRowCellValue(i, "ASIGNADA") Then
                    VB.SysContab.SeguridadDB.UsuarioEmpresasAdd(lblUserID.Text, iVista.GetRowCellValue(i, "CODIGO"), DBConn, Transaccion)
                End If
            Next

            Transaccion.Commit()
            DBConn.Close()
            '
            'Guardar si el Usuario es Comite de Credito.
            objComite.IdUsuario = CInt(lblUserID.Text)
            objComite.Empresa = EmpresaActual

            dbComite.Borrar(objComite)
            If CheckEdit1.Checked Then dbComite.Insertar(objComite)
        Catch ex As Exception
            XtraMsg("Error: " & ex.Message, MessageBoxIcon.Error)
            Transaccion.Rollback()
            DBConn.Close()
        End Try

        Try
            '   Agregar Cajas a Usuario
            GuardaDatos("DELETE FROM UsuariosCaja WHERE UsuarioId = " & lblUserID.Text & " AND Empresa = " & EmpresaActual)
            '
            For i = 0 To Me.vVista.DataRowCount - 1
                If Me.vVista.GetRowCellValue(i, "Asignar") Then
                    GuardaDatos("INSERT INTO UsuariosCaja VALUES (" & lblUserID.Text & "," & Me.vVista.GetRowCellValue(i, "Codigo") & "," & EmpresaActual & ")")
                End If
            Next

            GuardaDatos("DELETE FROM UsuariosSeries WHERE UsuarioId = " & lblUserID.Text & " AND Empresa = " & EmpresaActual)
            '
            For i = 0 To Me.vSucursales.DataRowCount - 1
                If Me.vSucursales.GetRowCellValue(i, "Asignar") Then
                    GuardaDatos("INSERT INTO UsuariosSeries VALUES (" & lblUserID.Text & ",'" & Me.vSucursales.GetRowCellValue(i, "Serie") & "'," & EmpresaActual & ")")
                End If
            Next

            'Centros de Costos por empresa
            GuardaDatos("DELETE FROM UsuariosCentrosCostos WHERE Usuario = " & lblUserID.Text & " AND Empresa = " & EmpresaActual)
            GuardaDatos("INSERT INTO UsuariosCentrosCostos VALUES (" & lblUserID.Text & "," & EmpresaActual & ",'" & IIf(cbCentroCosto.EditValue Is Nothing, "", cbCentroCosto.EditValue) & "')")
            'Sucursales por Usuario y Empresa
            GuardaDatos("DELETE FROM UsuariosSucursales WHERE IdUsuario = " & lblUserID.Text & " AND Empresa = " & EmpresaActual)
            GuardaDatos("INSERT INTO UsuariosSucursales VALUES (" & lblUserID.Text & "," & EmpresaActual & ",'" & IIf(cbSucursales.EditValue Is Nothing, "", cbSucursales.EditValue) & "')")
            'Bodegas por Empresas
            GuardaDatos("DELETE FROM UsuariosBodegas WHERE Usuario = " & lblUserID.Text & " AND Empresa = " & EmpresaActual)
            GuardaDatos("INSERT INTO UsuariosBodegas VALUES (" & lblUserID.Text & "," & EmpresaActual & ",'" & IIf(cbBodega.EditValue Is Nothing, "", cbBodega.EditValue) & "')")

            If Not pFirma.Image Is Nothing Then GuardarFirmaDigital(lblUserID.Text, pFirma.Image)

            Me.Close()

            Dim f As FrmUsuariosListar = FrmUsuariosListar.Instance
            f.Cargar()
        Catch ex As Exception
            XtraMsg("Error: " & ex.Message, MessageBoxIcon.Error)
        End Try
        ''Dim dsSeguridad As DataSet
        ''dsSeguridad = VB.SysContab.SeguridadDB.UsuarioRecursos(Usuario_ID)

        ''Rutinas.UsuariosRecursos(dsSeguridad)

        'Menu Principal
        ''Rutinas.DesabilitarRecursos(FormPrincipal.cmdBancos)
        ''Rutinas.DesabilitarRecursos(FormPrincipal.cmdBase)
        ''Rutinas.DesabilitarRecursos(FormPrincipal.cmdClientes)
        ''Rutinas.DesabilitarRecursos(FormPrincipal.cmdHerramientas)
        ''Rutinas.DesabilitarRecursos(FormPrincipal.cmdProcesos)
        ''Rutinas.DesabilitarRecursos(FormPrincipal.cmdProveedores)
        ''Rutinas.DesabilitarRecursos(FormPrincipal.cmdReportes)

        'Rutinas.DesabilitarRecursos(FormPrincipal.cmdPersonal)
        'Rutinas.DesabilitarRecursos(FormPrincipal.menuCatalogos)
        'Rutinas.DesabilitarRecursos(FormPrincipal.menuMovimientos)

        '''Menu Personal
        ''Rutinas.DesabilitarRecursos(FormPrincipal.cmdPersonal)
        '''Menu Catalogo
        ''Rutinas.DesabilitarRecursos(FormPrincipal.menuCatalogos)
        ''Rutinas.DesabilitarRecursos(FormPrincipal.menuMovimientos)
        '''Menu Procesos
        ''Rutinas.DesabilitarRecursos(FormPrincipal.menuProcesos)
        ''Rutinas.DesabilitarRecursos(FormPrincipal.menuPHorarios)
        ''Rutinas.DesabilitarRecursos(FormPrincipal.MenuPHorasExtras)
        ''Rutinas.DesabilitarRecursos(FormPrincipal.menuPMovimientos)
        ''Rutinas.DesabilitarRecursos(FormPrincipal.menuPlanilla)
        ''Rutinas.DesabilitarRecursos(FormPrincipal.menuVacaciones)
        ''Rutinas.DesabilitarRecursos(FormPrincipal.cmdPeriodos)

        '''Menu Reportes
        ''Rutinas.DesabilitarRecursos(FormPrincipal.MenuReportes)

        'Menu Herramientas

        ''Rutinas.DesabilitarRecursos(FormPrincipal.menuHerramientas)
        ''Rutinas.UsuariosRecursos(dsSeguridad)

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

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        For i As Integer = 0 To Me.vVista.DataRowCount - 1
            Me.vVista.SetRowCellValue(i, "Asignar", CheckBox1.Checked)
        Next
        Me.vVista.RefreshData()
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        For i As Integer = 0 To Me.vSucursales.DataRowCount - 1
            Me.vSucursales.SetRowCellValue(i, "Asignar", CheckBox2.Checked)
        Next
        Me.vVista.RefreshData()
    End Sub

    Private Sub pFirma_MouseClick(sender As Object, e As MouseEventArgs) Handles pFirma.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Or e.Button = Windows.Forms.MouseButtons.Right Then pFirma.LoadImage()
    End Sub

    Sub CargarFirmaDigital()
        Dim DT_FIRMA As DataTable = ObtieneDatos("sp_sel_UsuariosFirmas", EmpresaActual, lblUserID.Text)

        If DT_FIRMA.Rows.Count > 0 Then
            'Mostrar Firma Digital
            If DT_FIRMA.Rows.Item(0)("Firma") IsNot DBNull.Value Then
                Dim img As Image = Bytes2Image(CType(DT_FIRMA.Rows.Item(0)("Firma"), Byte()))
                If img IsNot Nothing Then
                    pFirma.Image = img
                End If
            End If
        End If
    End Sub

End Class
