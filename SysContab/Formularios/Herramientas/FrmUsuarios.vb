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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAcumulado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbAsignados As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbRecursos As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtRepetirPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents ckHabilitado As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbEmpresas As System.Windows.Forms.ListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dgCajas As DevExpress.XtraGrid.GridControl
    Friend WithEvents vVista As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cbRoles As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbEmprAsign As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.ckHabilitado = New System.Windows.Forms.CheckBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRepetirPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmdAcumulado = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.lbAsignados = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbRecursos = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton()
        Me.lbEmprAsign = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbEmpresas = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button3 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button4 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.dgCajas = New DevExpress.XtraGrid.GridControl()
        Me.vVista = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.cbRoles = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.dgCajas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.cbRoles.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(638, 5)
        Me.txtUsuario.MaxLength = 50
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(240, 20)
        Me.txtUsuario.TabIndex = 2
        '
        'ckHabilitado
        '
        Me.ckHabilitado.AutoSize = True
        Me.ckHabilitado.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckHabilitado.ForeColor = System.Drawing.Color.Red
        Me.ckHabilitado.Location = New System.Drawing.Point(638, 57)
        Me.ckHabilitado.Name = "ckHabilitado"
        Me.ckHabilitado.Size = New System.Drawing.Size(83, 20)
        Me.ckHabilitado.TabIndex = 142
        Me.ckHabilitado.Text = "Habilitado"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(133, 57)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(376, 20)
        Me.txtEmail.TabIndex = 140
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(11, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 141
        Me.Label3.Text = "Correo Electronico:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(522, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "Repetir Password:"
        '
        'txtRepetirPassword
        '
        Me.txtRepetirPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRepetirPassword.Location = New System.Drawing.Point(638, 31)
        Me.txtRepetirPassword.MaxLength = 50
        Me.txtRepetirPassword.Name = "txtRepetirPassword"
        Me.txtRepetirPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtRepetirPassword.Size = New System.Drawing.Size(240, 20)
        Me.txtRepetirPassword.TabIndex = 138
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(62, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(133, 31)
        Me.txtPassword.MaxLength = 50
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Size = New System.Drawing.Size(219, 20)
        Me.txtPassword.TabIndex = 136
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(133, 5)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(376, 20)
        Me.txtNombre.TabIndex = 0
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(17, 13)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(110, 13)
        Me.Label29.TabIndex = 135
        Me.Label29.Text = "Nombre Completo:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(531, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Nombre Usuario:"
        '
        'cmdAcumulado
        '
        Me.cmdAcumulado.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAcumulado.Appearance.Options.UseFont = True
        Me.cmdAcumulado.ImageOptions.Image = Global.SysContab.My.Resources.Resources._115_25x25
        Me.cmdAcumulado.Location = New System.Drawing.Point(5, 48)
        Me.cmdAcumulado.Name = "cmdAcumulado"
        Me.cmdAcumulado.Size = New System.Drawing.Size(96, 35)
        Me.cmdAcumulado.TabIndex = 36
        Me.cmdAcumulado.Text = "&Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.ImageOptions.Image = Global.SysContab.My.Resources.Resources.RibbonUserDesigner_SaveFileLarge
        Me.cmdAceptar.Location = New System.Drawing.Point(5, 10)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(96, 32)
        Me.cmdAceptar.TabIndex = 34
        Me.cmdAceptar.Text = "&Guardar"
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
        Me.lbEmprAsign.Location = New System.Drawing.Point(290, 30)
        Me.lbEmprAsign.Name = "lbEmprAsign"
        Me.lbEmprAsign.Size = New System.Drawing.Size(208, 225)
        Me.lbEmprAsign.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(294, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 16)
        Me.Label6.TabIndex = 137
        Me.Label6.Text = "Empresas Asignadas"
        '
        'lbEmpresas
        '
        Me.lbEmpresas.Location = New System.Drawing.Point(9, 30)
        Me.lbEmpresas.Name = "lbEmpresas"
        Me.lbEmpresas.Size = New System.Drawing.Size(208, 225)
        Me.lbEmpresas.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(13, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 16)
        Me.Label7.TabIndex = 136
        Me.Label7.Text = "Empresas Disponibles"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(223, 82)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(61, 25)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "< Quitar"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(223, 52)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(61, 24)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Asignar >"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdAcumulado)
        Me.PanelControl1.Controls.Add(Me.cmdAceptar)
        Me.PanelControl1.Location = New System.Drawing.Point(904, 9)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(107, 388)
        Me.PanelControl1.TabIndex = 43
        '
        'dgCajas
        '
        Me.dgCajas.Location = New System.Drawing.Point(523, 131)
        Me.dgCajas.MainView = Me.vVista
        Me.dgCajas.Name = "dgCajas"
        Me.dgCajas.Size = New System.Drawing.Size(368, 266)
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
        Me.GridBand1.Caption = "Asignar Cajas - Facturación de Ventas"
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.VisibleIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.cbRoles)
        Me.PanelControl2.Controls.Add(Me.Label8)
        Me.PanelControl2.Controls.Add(Me.txtUsuario)
        Me.PanelControl2.Controls.Add(Me.ckHabilitado)
        Me.PanelControl2.Controls.Add(Me.txtNombre)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.Label29)
        Me.PanelControl2.Controls.Add(Me.txtRepetirPassword)
        Me.PanelControl2.Controls.Add(Me.txtEmail)
        Me.PanelControl2.Controls.Add(Me.Label13)
        Me.PanelControl2.Controls.Add(Me.txtPassword)
        Me.PanelControl2.Controls.Add(Me.Label3)
        Me.PanelControl2.Controls.Add(Me.Label1)
        Me.PanelControl2.Location = New System.Drawing.Point(8, 9)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(883, 116)
        Me.PanelControl2.TabIndex = 45
        '
        'cbRoles
        '
        Me.cbRoles.Location = New System.Drawing.Point(133, 83)
        Me.cbRoles.Name = "cbRoles"
        Me.cbRoles.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRoles.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.cbRoles.Properties.Appearance.Options.UseFont = True
        Me.cbRoles.Properties.Appearance.Options.UseForeColor = True
        Me.cbRoles.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbRoles.Properties.ShowFooter = False
        Me.cbRoles.Properties.ShowHeader = False
        Me.cbRoles.Size = New System.Drawing.Size(745, 22)
        Me.cbRoles.TabIndex = 145
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(41, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 144
        Me.Label8.Text = "Rol Asignado:"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.lbEmprAsign)
        Me.PanelControl3.Controls.Add(Me.Label6)
        Me.PanelControl3.Controls.Add(Me.Button4)
        Me.PanelControl3.Controls.Add(Me.lbEmpresas)
        Me.PanelControl3.Controls.Add(Me.Button3)
        Me.PanelControl3.Controls.Add(Me.Label7)
        Me.PanelControl3.Location = New System.Drawing.Point(8, 131)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(509, 266)
        Me.PanelControl3.TabIndex = 46
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.lbAsignados)
        Me.PanelControl4.Controls.Add(Me.Label4)
        Me.PanelControl4.Controls.Add(Me.Button1)
        Me.PanelControl4.Controls.Add(Me.lbRecursos)
        Me.PanelControl4.Controls.Add(Me.Button2)
        Me.PanelControl4.Controls.Add(Me.Label5)
        Me.PanelControl4.Location = New System.Drawing.Point(8, 412)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(509, 50)
        Me.PanelControl4.TabIndex = 47
        Me.PanelControl4.Visible = False
        '
        'FrmUsuarios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 404)
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.dgCajas)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmUsuarios"
        Me.Text = "Registrar Usuarios"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.dgCajas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.cbRoles.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
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

        'Rutinas.FormularioColor(Me)
        'VB.SysContab.Rutinas.CambiarEstilo(Me)

        Me.cbRoles.Properties.DataSource = ObtieneDatos("SELECT 0 ID,'[Seleccione Rol]' Nombre,'' Descripcion UNION SELECT ID,Nombre,Descripcion FROM REST_Roles").DefaultView
        Me.cbRoles.Properties.DisplayMember = "Nombre"
        Me.cbRoles.Properties.ValueMember = "ID"
        Me.cbRoles.Properties.PopulateColumns()
        Me.cbRoles.Properties.Columns("ID").Visible = False
        Me.cbRoles.Properties.Columns("Descripcion").Visible = False
        Me.cbRoles.EditValue = 0

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
        FormatoGrid(Me.vVista)
        '
        For cont As Integer = 0 To Me.vVista.Columns.Count - 1
            Me.vVista.Columns(cont).OptionsColumn.AllowEdit = False
        Next
        Me.vVista.Columns("Asignar").OptionsColumn.AllowEdit = True
        Me.vVista.Columns("Codigo").Visible = False
        Me.vVista.BestFitColumns()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

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

                Dim UserID As String = VB.SysContab.SeguridadDB.UsuariosAdd(txtUsuario.Text, txtNombre.Text, txtPassword.Text, txtEmail.Text, ckHabilitado.Checked, DBConn, Transaccion, Me.cbRoles.EditValue)

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
End Class
