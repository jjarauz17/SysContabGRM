Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class FrmRolesEditar
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As FrmRolesEditar = Nothing

    Public Shared Function Instance() As FrmRolesEditar
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmRolesEditar()
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
    Friend WithEvents lblRolID As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ckHabilitado As System.Windows.Forms.CheckBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAcumulado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbAsignados As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbRecursos As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tvAcciones As System.Windows.Forms.TreeView
    Friend WithEvents tvAcciones1 As System.Windows.Forms.TreeView
    Friend WithEvents tvTipo As System.Windows.Forms.TreeView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblRolID = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ckHabilitado = New System.Windows.Forms.CheckBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.tvAcciones1 = New System.Windows.Forms.TreeView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdAcumulado = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tvTipo = New System.Windows.Forms.TreeView()
        Me.tvAcciones = New System.Windows.Forms.TreeView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbAsignados = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbRecursos = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRolID
        '
        Me.lblRolID.Location = New System.Drawing.Point(832, 0)
        Me.lblRolID.Name = "lblRolID"
        Me.lblRolID.TabIndex = 0
        Me.lblRolID.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.ckHabilitado, Me.txtNombre, Me.Label29, Me.Label13, Me.txtDescripcion})
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(912, 112)
        Me.GroupBox3.TabIndex = 41
        Me.GroupBox3.TabStop = False
        '
        'ckHabilitado
        '
        Me.ckHabilitado.Location = New System.Drawing.Point(8, 80)
        Me.ckHabilitado.Name = "ckHabilitado"
        Me.ckHabilitado.Size = New System.Drawing.Size(112, 24)
        Me.ckHabilitado.TabIndex = 142
        Me.ckHabilitado.Text = "Habilitado"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(128, 16)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(440, 20)
        Me.txtNombre.TabIndex = 0
        Me.txtNombre.Text = ""
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label29.Location = New System.Drawing.Point(8, 16)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(128, 24)
        Me.Label29.TabIndex = 135
        Me.Label29.Text = "Nombre"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 24)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Descripcion"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(128, 48)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(440, 20)
        Me.txtDescripcion.TabIndex = 2
        Me.txtDescripcion.Text = ""
        '
        'tvAcciones1
        '
        Me.tvAcciones1.CheckBoxes = True
        Me.tvAcciones1.ImageIndex = -1
        Me.tvAcciones1.Location = New System.Drawing.Point(592, 48)
        Me.tvAcciones1.Name = "tvAcciones1"
        Me.tvAcciones1.SelectedImageIndex = -1
        Me.tvAcciones1.Size = New System.Drawing.Size(88, 152)
        Me.tvAcciones1.TabIndex = 140
        Me.tvAcciones1.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdAcumulado, Me.cmdAceptar})
        Me.GroupBox2.Location = New System.Drawing.Point(928, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(80, 520)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        '
        'cmdAcumulado
        '
        Me.cmdAcumulado.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.cmdAcumulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAcumulado.Location = New System.Drawing.Point(8, 48)
        Me.cmdAcumulado.Name = "cmdAcumulado"
        Me.cmdAcumulado.Size = New System.Drawing.Size(64, 24)
        Me.cmdAcumulado.TabIndex = 36
        Me.cmdAcumulado.Text = "&Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Location = New System.Drawing.Point(8, 10)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(64, 22)
        Me.cmdAceptar.TabIndex = 34
        Me.cmdAceptar.Text = "&Guardar"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.tvAcciones1, Me.tvTipo, Me.tvAcciones, Me.Label1, Me.lbAsignados, Me.Label3, Me.lbRecursos, Me.Label2, Me.Button2, Me.Button1})
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(8, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(912, 408)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        '
        'tvTipo
        '
        Me.tvTipo.CheckBoxes = True
        Me.tvTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvTipo.ImageIndex = -1
        Me.tvTipo.Indent = 40
        Me.tvTipo.Location = New System.Drawing.Point(544, 16)
        Me.tvTipo.Name = "tvTipo"
        Me.tvTipo.SelectedImageIndex = -1
        Me.tvTipo.Size = New System.Drawing.Size(360, 376)
        Me.tvTipo.TabIndex = 140
        Me.tvTipo.Visible = False
        '
        'tvAcciones
        '
        Me.tvAcciones.CheckBoxes = True
        Me.tvAcciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvAcciones.ImageIndex = -1
        Me.tvAcciones.Indent = 40
        Me.tvAcciones.Location = New System.Drawing.Point(16, 24)
        Me.tvAcciones.Name = "tvAcciones"
        Me.tvAcciones.Nodes.AddRange(New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("Nuevo"), New System.Windows.Forms.TreeNode("Editar", New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("Activos")}), New System.Windows.Forms.TreeNode("Imprimir", New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("Fijos"), New System.Windows.Forms.TreeNode("Contrato"), New System.Windows.Forms.TreeNode("Registro"), New System.Windows.Forms.TreeNode("Datos Generales"), New System.Windows.Forms.TreeNode("Ubicación")}), New System.Windows.Forms.TreeNode("Horarios"), New System.Windows.Forms.TreeNode("Borrar")})
        Me.tvAcciones.SelectedImageIndex = -1
        Me.tvAcciones.Size = New System.Drawing.Size(520, 376)
        Me.tvAcciones.TabIndex = 139
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Location = New System.Drawing.Point(568, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 24)
        Me.Label1.TabIndex = 138
        Me.Label1.Text = "Acciones"
        Me.Label1.Visible = False
        '
        'lbAsignados
        '
        Me.lbAsignados.Location = New System.Drawing.Point(248, 96)
        Me.lbAsignados.Name = "lbAsignados"
        Me.lbAsignados.Size = New System.Drawing.Size(72, 173)
        Me.lbAsignados.TabIndex = 1
        Me.lbAsignados.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 24)
        Me.Label3.TabIndex = 137
        Me.Label3.Text = "Recursos"
        '
        'lbRecursos
        '
        Me.lbRecursos.Location = New System.Drawing.Point(16, 32)
        Me.lbRecursos.Name = "lbRecursos"
        Me.lbRecursos.Size = New System.Drawing.Size(208, 342)
        Me.lbRecursos.TabIndex = 0
        Me.lbRecursos.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 24)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "Recursos Disponibles"
        Me.Label2.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(248, 72)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Quitar"
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(248, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Asignar"
        Me.Button1.Visible = False
        '
        'FrmRolesEditar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1016, 526)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox3, Me.GroupBox2, Me.GroupBox1, Me.lblRolID})
        Me.Name = "FrmRolesEditar"
        Me.Text = "Editar Roles"
        Me.TopMost = True
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
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

    Private Sub FrmRolesEditar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Rutinas.FormularioColor(Me)
        'VB.SysContab.Rutinas.CambiarEstilo(Me)

        '''Me.lbAsignados.BackColor = Color.White
        '''Me.lbRecursos.BackColor = Color.White
        Me.tvAcciones.BackColor = Color.White

        Dim Rol As DataSet = VB.SysContab.SeguridadDB.GetRol(lblRolID.Text)

        txtNombre.Text = Rol.Tables("Roles").Rows(0).Item("Rol_Nombre")
        txtDescripcion.Text = Rol.Tables("Roles").Rows(0).Item("Rol_Descripcion")
        ckHabilitado.Checked = Rol.Tables("Roles").Rows(0).Item("Rol_Habilitado")

        '''lbAsignados.DataSource = Rol.Tables("RolesRecursos")
        '''lbAsignados.ValueMember = "Res_ID"
        '''lbAsignados.DisplayMember = "Res_Nombre"

        Dim Ds As DataSet = VB.SysContab.SeguridadDB.GetLisRecursos()

        Dim i As Integer
        Dim j As Integer
        '''Dim Cont As Integer = 0

        'rol.Tables("")

        '''For i = 0 To Ds.Tables("Tabla").Rows.Count - 1
        '''    Cont = 0
        '''    For j = 0 To Rol.Tables("RolesRecursos").Rows.Count - 1
        '''        If Rol.Tables("RolesRecursos").Rows(j).Item("Res_ID") = Ds.Tables("Tabla").Rows(i).Item("Recurso") Then
        '''            Cont = Cont + 1
        '''            Exit For
        '''        End If
        '''    Next

        '''    If Cont = 0 Then
        '''        DisRow = DisTable.NewRow()
        '''        DisRow(D1) = Ds.Tables("Tabla").Rows(i).Item("Recurso")
        '''        DisRow(D2) = Ds.Tables("Tabla").Rows(i).Item("Nombre")
        '''        DisTable.Rows.Add(DisRow)
        '''    End If
        '''Next

        '''lbRecursos.DataSource = Disponibles.Tables("Disponibles")
        '''lbRecursos.ValueMember = "D1"
        '''lbRecursos.DisplayMember = "D2"

        '''For i = 0 To Rol.Tables("RolesRecursos").Rows.Count - 1
        '''    workRow = workTable.NewRow()
        '''    workRow(c1) = Rol.Tables("RolesRecursos").Rows(i).Item("Res_ID")
        '''    workRow(c2) = Rol.Tables("RolesRecursos").Rows(i).Item("Res_Nombre")
        '''    workTable.Rows.Add(workRow)
        '''Next

        '''lbAsignados.DataSource = Seleccionados.Tables("Seleccionados")
        '''lbAsignados.ValueMember = "c1"
        '''lbAsignados.DisplayMember = "c2"

        Me.tvAcciones.Nodes.Clear()
        'Me.tvAcciones1.Nodes.Clear()

        'Me.tvAcciones1.Visible = True

        'Agregar el Menu Principal
        Dim dsMenu As DataSet = VB.SysContab.SeguridadDB.MenuPrincipal(1, 0, lblRolID.Text)
        Dim dsMenu1 As DataSet
        Dim dsMenu2 As DataSet
        Dim a As Integer
        Dim b As Integer

        Dim m As Integer
        Dim n As Integer
        Dim o As Integer

        Dim x As Integer
        Dim y As Integer
        Dim z As Integer

        Dim dsRecursos As DataSet
        Dim dsRecursos1 As DataSet
        Dim dsRecursos2 As DataSet

        Dim dsAcciones As DataSet

        For j = 0 To dsMenu.Tables("Menu").Rows.Count - 1
            Me.tvAcciones.Nodes.Add(dsMenu.Tables("Menu").Rows(j).Item("Menu_Nombre"))
            Me.tvAcciones1.Nodes.Add(dsMenu.Tables("Menu").Rows(j).Item("Menu_ID"))

            Me.tvTipo.Nodes.Add("M")
            'Menu Principal. Registros, CLientes, Proveedores, ...
            Me.tvAcciones.Nodes.Item(j).Checked = dsMenu.Tables("Menu").Rows(j).Item("Asignado")
            Me.tvAcciones.Nodes.Item(j).ForeColor = Color.Blue
            dsRecursos = VB.SysContab.SeguridadDB.MenuRecursos(Me.lblRolID.Text, dsMenu.Tables("Menu").Rows(j).Item("Menu_ID"))

            dsMenu1 = VB.SysContab.SeguridadDB.MenuPrincipal(2, dsMenu.Tables("Menu").Rows(j).Item("Menu_ID"), lblRolID.Text)

            For a = 0 To dsMenu1.Tables("Menu").Rows.Count - 1
                Me.tvAcciones.Nodes(j).Nodes.Add(dsMenu1.Tables("Menu").Rows(a).Item("Menu_Nombre"))
                Me.tvAcciones1.Nodes(j).Nodes.Add(dsMenu1.Tables("Menu").Rows(a).Item("Menu_ID"))
                Me.tvAcciones.Nodes(j).Nodes.Item(a).ForeColor = Color.Green
                'Sub Menu. Generales, Contables, ...

                Me.tvTipo.Nodes(j).Nodes.Add("M")

                Me.tvAcciones.Nodes(j).Nodes.Item(a).Checked = dsMenu1.Tables("Menu").Rows(a).Item("Asignado")

                dsRecursos1 = VB.SysContab.SeguridadDB.MenuRecursos(Me.lblRolID.Text, dsMenu1.Tables("Menu").Rows(a).Item("Menu_ID"))

                dsMenu2 = VB.SysContab.SeguridadDB.MenuPrincipal(3, dsMenu1.Tables("Menu").Rows(a).Item("Menu_ID"), lblRolID.Text)

                For b = 0 To dsMenu2.Tables("Menu").Rows.Count - 1
                    Me.tvAcciones.Nodes(j).Nodes(a).Nodes.Add(dsMenu2.Tables("Menu").Rows(b).Item("Menu_Nombre"))
                    Me.tvAcciones1.Nodes(j).Nodes(a).Nodes.Add(dsMenu2.Tables("Menu").Rows(b).Item("Menu_ID"))

                    Me.tvTipo.Nodes(j).Nodes(a).Nodes.Add("M")

                    Me.tvAcciones.Nodes(j).Nodes(a).Nodes.Item(b).Checked = dsMenu2.Tables("Menu").Rows(b).Item("Asignado")

                    dsRecursos2 = VB.SysContab.SeguridadDB.MenuRecursos(Me.lblRolID.Text, dsMenu2.Tables("Menu").Rows(b).Item("Menu_ID"))

                    For o = 0 To dsRecursos2.Tables("Menu").Rows.Count - 1
                        Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).Nodes.Add(dsRecursos2.Tables("Menu").Rows(o).Item("Res_Nombre"))
                        Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(b).Nodes.Add(dsRecursos2.Tables("Menu").Rows(o).Item("Res_ID"))

                        Me.tvTipo.Nodes(j).Nodes(a).Nodes(b).Nodes.Add("R")
                        Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).Nodes.Item(o).Checked = dsRecursos2.Tables("Menu").Rows(o).Item("Asignado")

                        dsAcciones = VB.SysContab.SeguridadDB.RecursosAcciones(1, 0, dsRecursos2.Tables("Menu").Rows(o).Item("Res_ID"), lblRolID.Text)

                        For x = 0 To dsAcciones.Tables("Usuarios").Rows.Count - 1
                            Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).Nodes(o).Nodes.Add(dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_Nombre"))
                            Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(b).Nodes(o).Nodes.Add(dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"))
                            Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).Nodes(o).Nodes.Item(x).Checked = dsAcciones.Tables("Usuarios").Rows(x).Item("Asignado")
                            Me.tvTipo.Nodes(j).Nodes(a).Nodes(b).Nodes(o).Nodes.Add("A")

                            ''
                            For y = 0 To VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos2.Tables("Menu").Rows(o).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows.Count - 1
                                Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).Nodes(o).Nodes(x).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos2.Tables("Menu").Rows(o).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_Nombre"))
                                Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(b).Nodes(o).Nodes(x).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos2.Tables("Menu").Rows(o).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"))
                                Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).Nodes(o).Nodes(x).Nodes.Item(y).Checked = VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos2.Tables("Menu").Rows(o).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Asignado")
                                Me.tvTipo.Nodes(j).Nodes(a).Nodes(b).Nodes(o).Nodes(x).Nodes.Add("A")

                                For z = 0 To VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos2.Tables("Menu").Rows(o).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos2.Tables("Menu").Rows(o).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows.Count - 1
                                    Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).Nodes(o).Nodes(x).Nodes(y).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos2.Tables("Menu").Rows(o).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos2.Tables("Menu").Rows(o).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(z).Item("Accion_Nombre"))
                                    Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(b).Nodes(o).Nodes(x).Nodes(y).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos2.Tables("Menu").Rows(o).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos2.Tables("Menu").Rows(o).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(z).Item("Accion_ID"))
                                    Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).Nodes(o).Nodes(x).Nodes(y).Nodes.Item(z).Checked = VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos2.Tables("Menu").Rows(o).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos2.Tables("Menu").Rows(o).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(z).Item("Asignado")
                                    Me.tvTipo.Nodes(j).Nodes(a).Nodes(b).Nodes(o).Nodes(x).Nodes(y).Nodes.Add("A")

                                Next

                            Next
                        Next
                    Next

                    '''
                Next

                For n = 0 To dsRecursos1.Tables("Menu").Rows.Count - 1
                    Me.tvAcciones.Nodes(j).Nodes(a).Nodes.Add(dsRecursos1.Tables("Menu").Rows(n).Item("Res_Nombre"))
                    Me.tvAcciones1.Nodes(j).Nodes(a).Nodes.Add(dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"))

                    Me.tvTipo.Nodes(j).Nodes(a).Nodes.Add("R")
                    If a = 1 Then
                        Me.tvAcciones.Nodes(j).Nodes(a).Nodes.Item(n + 1).Checked = dsRecursos1.Tables("Menu").Rows(n).Item("Asignado")
                    Else
                        Me.tvAcciones.Nodes(j).Nodes(a).Nodes.Item(n).Checked = dsRecursos1.Tables("Menu").Rows(n).Item("Asignado")
                    End If

                    dsAcciones = VB.SysContab.SeguridadDB.RecursosAcciones(1, 0, dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text)

                    'Revisar si se puede con el nivel del Recurso y no con el indice
                    If a = 1 Then
                        For x = 0 To dsAcciones.Tables("Usuarios").Rows.Count - 1
                            Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n + 1).Nodes.Add(dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_Nombre"))
                            Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(n + 1).Nodes.Add(dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"))
                            Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n + 1).Nodes.Item(x).Checked = dsAcciones.Tables("Usuarios").Rows(x).Item("Asignado")
                            Me.tvTipo.Nodes(j).Nodes(a).Nodes(n + 1).Nodes.Add("A")


                            For y = 0 To VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows.Count - 1
                                Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n + 1).Nodes(x).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_Nombre"))
                                Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(n + 1).Nodes(x).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"))
                                Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n + 1).Nodes(x).Nodes.Item(y).Checked = VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Asignado")
                                Me.tvTipo.Nodes(j).Nodes(a).Nodes(n + 1).Nodes(x).Nodes.Add("A")

                                For z = 0 To VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows.Count - 1
                                    Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n + 1).Nodes(x).Nodes(y).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(z).Item("Accion_Nombre"))
                                    Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(n + 1).Nodes(x).Nodes(y).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(z).Item("Accion_ID"))
                                    Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n + 1).Nodes(x).Nodes(y).Nodes.Item(z).Checked = VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(z).Item("Asignado")
                                    Me.tvTipo.Nodes(j).Nodes(a).Nodes(n + 1).Nodes(x).Nodes(y).Nodes.Add("A")
                                Next
                            Next
                        Next
                    Else
                        For x = 0 To dsAcciones.Tables("Usuarios").Rows.Count - 1
                            Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n).Nodes.Add(dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_Nombre"))
                            Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(n).Nodes.Add(dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"))
                            Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n).Nodes.Item(x).Checked = dsAcciones.Tables("Usuarios").Rows(x).Item("Asignado")
                            Me.tvTipo.Nodes(j).Nodes(a).Nodes(n).Nodes.Add("A")


                            For y = 0 To VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows.Count - 1
                                Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n).Nodes(x).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_Nombre"))
                                Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(n).Nodes(x).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"))
                                Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n).Nodes(x).Nodes.Item(y).Checked = VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Asignado")
                                Me.tvTipo.Nodes(j).Nodes(a).Nodes(n).Nodes(x).Nodes.Add("A")

                                For z = 0 To VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows.Count - 1
                                    Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n).Nodes(x).Nodes(y).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(z).Item("Accion_Nombre"))
                                    Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(n).Nodes(x).Nodes(y).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(z).Item("Accion_ID"))
                                    Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n).Nodes(x).Nodes(y).Nodes.Item(z).Checked = VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(z).Item("Asignado")
                                    Me.tvTipo.Nodes(j).Nodes(a).Nodes(n).Nodes(x).Nodes(y).Nodes.Add("A")
                                Next
                            Next
                        Next
                    End If
                Next
            Next

            ''''For n = 0 To dsRecursos1.Tables("Menu").Rows.Count - 1
            ''''    Me.tvAcciones.Nodes(j).Nodes(a).Nodes.Add(dsRecursos1.Tables("Menu").Rows(n).Item("Res_Nombre") & "EEEEE")
            ''''    Me.tvAcciones1.Nodes(j).Nodes(a).Nodes.Add(dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"))

            ''''    Me.tvTipo.Nodes(j).Nodes(a).Nodes.Add("R")
            ''''    Me.tvAcciones.Nodes(j).Nodes(a).Nodes.Item(n).Checked = dsRecursos1.Tables("Menu").Rows(n).Item("Asignado")

            ''''    dsAcciones = VB.SysContab.SeguridadDB.RecursosAcciones(1, 0, dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text)

            ''''    For x = 0 To dsAcciones.Tables("Usuarios").Rows.Count - 1
            ''''        Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n).Nodes.Add(dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_Nombre"))
            ''''        Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(n).Nodes.Add(dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"))
            ''''        Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n).Nodes.Item(x).Checked = dsAcciones.Tables("Usuarios").Rows(x).Item("Asignado")


            ''''        For y = 0 To VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows.Count - 1
            ''''            Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n).Nodes(x).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_Nombre"))
            ''''            Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(n).Nodes(x).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"))
            ''''            Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n).Nodes(x).Nodes.Item(y).Checked = VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Asignado")

            ''''            For z = 0 To VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows.Count - 1
            ''''                Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n).Nodes(x).Nodes(y).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(z).Item("Accion_Nombre"))
            ''''                Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(n).Nodes(x).Nodes(y).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(z).Item("Accion_ID"))
            ''''                Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n).Nodes(x).Nodes(y).Nodes.Item(z).Checked = VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(z).Item("Asignado")
            ''''            Next
            ''''        Next
            ''''    Next
            ''''Next

            For m = 0 To dsRecursos.Tables("Menu").Rows.Count - 1
                'Recursos de menu Principal. Clientes = Facturacion, Facturas, ....
                Me.tvAcciones.Nodes(j).Nodes.Add(dsRecursos.Tables("Menu").Rows(m).Item("Res_Nombre"))
                Me.tvAcciones1.Nodes(j).Nodes.Add(dsRecursos.Tables("Menu").Rows(m).Item("Res_ID"))
                Me.tvAcciones.Nodes(j).Nodes.Item(m).Checked = dsRecursos.Tables("Menu").Rows(m).Item("Asignado")

                Me.tvTipo.Nodes(j).Nodes.Add("R")

                dsAcciones = VB.SysContab.SeguridadDB.RecursosAcciones(1, 0, dsRecursos.Tables("Menu").Rows(m).Item("Res_ID"), lblRolID.Text)

                For x = 0 To dsAcciones.Tables("Usuarios").Rows.Count - 1
                    Me.tvAcciones.Nodes(j).Nodes(m).Nodes.Add(dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_Nombre"))
                    Me.tvAcciones1.Nodes(j).Nodes(m).Nodes.Add(dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"))
                    Me.tvTipo.Nodes(j).Nodes(m).Nodes.Add("A")
                    Me.tvAcciones.Nodes(j).Nodes(m).Nodes.Item(x).Checked = dsAcciones.Tables("Usuarios").Rows(x).Item("Asignado")


                    For y = 0 To VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos.Tables("Menu").Rows(m).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows.Count - 1
                        Me.tvAcciones.Nodes(j).Nodes(m).Nodes(x).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos.Tables("Menu").Rows(m).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_Nombre"))
                        Me.tvAcciones1.Nodes(j).Nodes(m).Nodes(x).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos.Tables("Menu").Rows(m).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"))
                        Me.tvAcciones.Nodes(j).Nodes(m).Nodes(x).Nodes.Item(y).Checked = VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos.Tables("Menu").Rows(m).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Asignado")
                        Me.tvTipo.Nodes(j).Nodes(m).Nodes(x).Nodes.Add("A")

                        For z = 0 To VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos.Tables("Menu").Rows(m).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos.Tables("Menu").Rows(m).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows.Count - 1
                            Me.tvAcciones.Nodes(j).Nodes(m).Nodes(x).Nodes(y).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos.Tables("Menu").Rows(m).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos.Tables("Menu").Rows(m).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(z).Item("Accion_Nombre"))
                            Me.tvAcciones1.Nodes(j).Nodes(m).Nodes(x).Nodes(y).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos.Tables("Menu").Rows(m).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos.Tables("Menu").Rows(m).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(z).Item("Accion_ID"))
                            Me.tvAcciones.Nodes(j).Nodes(m).Nodes(x).Nodes(y).Nodes.Item(z).Checked = VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos.Tables("Menu").Rows(m).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos.Tables("Menu").Rows(m).Item("Res_ID"), lblRolID.Text).Tables("Usuarios").Rows(z).Item("Asignado")
                            Me.tvTipo.Nodes(j).Nodes(m).Nodes(x).Nodes(y).Nodes.Add("A")
                        Next
                    Next
                Next

            Next
        Next




        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Exit Sub

        For j = 0 To Rol.Tables("RolesRecursos").Rows.Count - 1
            Me.tvAcciones.Nodes.Add(Rol.Tables("RolesRecursos").Rows(j).Item("Res_Nombre"))
            Me.tvAcciones1.Nodes.Add(Rol.Tables("RolesRecursos").Rows(j).Item("Res_ID"))
            Me.tvAcciones.Nodes.Item(j).Checked = Rol.Tables("RolesRecursos").Rows(j).Item("Asignado")
        Next


        'Dim x As Integer
        'Dim y As Integer
        'Dim z As Integer
        'Dim dsAcciones As DataSet

        For i = 0 To Me.tvAcciones1.GetNodeCount(False) - 1
            dsAcciones = VB.SysContab.SeguridadDB.RecursosAcciones(1, 0, Me.tvAcciones1.Nodes.Item(i).Text, lblRolID.Text)

            For x = 0 To dsAcciones.Tables("Usuarios").Rows.Count - 1
                Me.tvAcciones.Nodes(i).Nodes.Add(dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_Nombre"))
                Me.tvAcciones1.Nodes(i).Nodes.Add(dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"))

                Me.tvAcciones.Nodes(i).Nodes.Item(x).Checked = dsAcciones.Tables("Usuarios").Rows(x).Item("Asignado")

                For y = 0 To VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, lblRolID.Text).Tables("Usuarios").Rows.Count - 1
                    Me.tvAcciones.Nodes(i).Nodes(x).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_Nombre"))
                    Me.tvAcciones1.Nodes(i).Nodes(x).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"))

                    Me.tvAcciones.Nodes(i).Nodes(x).Nodes.Item(y).Checked = VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, lblRolID.Text).Tables("Usuarios").Rows(y).Item("Asignado")

                    For z = 0 To VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), 1, lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"), 1, lblRolID.Text).Tables("Usuarios").Rows.Count - 1
                        Me.tvAcciones.Nodes(i).Nodes(x).Nodes(y).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, lblRolID.Text).Tables("Usuarios").Rows(z).Item("Accion_Nombre"))
                        Me.tvAcciones1.Nodes(i).Nodes(x).Nodes(y).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, lblRolID.Text).Tables("Usuarios").Rows(z).Item("Accion_ID"))

                        Me.tvAcciones.Nodes(i).Nodes(x).Nodes(y).Nodes.Item(z) = VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, lblRolID.Text).Tables("Usuarios").Rows(z).Item("Asignado")
                    Next
                Next
            Next
        Next

    End Sub

    Private Sub cmdAcumulado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcumulado.Click
        Me.Close()
    End Sub

    ' Asignar
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'If lbRecursos.Items.Count > 0 Then
        '    workRow = workTable.NewRow()
        '    workRow(c1) = lbRecursos.SelectedValue
        '    workRow(c2) = lbRecursos.Text
        '    workTable.Rows.Add(workRow)
        '    lbAsignados.DataSource = Seleccionados.Tables("Seleccionados")
        '    lbAsignados.ValueMember = "c1"
        '    lbAsignados.DisplayMember = "c2"
        '    Disponibles.Tables("Disponibles").Rows(lbRecursos.SelectedIndex).Delete()
        'End If



    End Sub

    ' Quitar
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'If lbAsignados.Items.Count > 0 Then
        '    DisRow = DisTable.NewRow()
        '    DisRow(D1) = lbAsignados.SelectedValue
        '    DisRow(D2) = lbAsignados.Text
        '    DisTable.Rows.Add(DisRow)
        '    lbRecursos.DataSource = Disponibles.Tables("Disponibles")
        '    lbRecursos.ValueMember = "D1"
        '    lbRecursos.DisplayMember = "D2"
        '    Seleccionados.Tables("Seleccionados").Rows(lbAsignados.SelectedIndex).Delete()
        'End If
        If Me.tvAcciones.GetNodeCount(True) > 0 Then
            Me.tvAcciones.Nodes.Remove(tvAcciones.SelectedNode)
            Me.tvAcciones1.Nodes.Remove(tvAcciones.SelectedNode)
            Me.tvAcciones.Focus()
            'Me.tvAcciones.Nodes.RemoveAt(tvAcciones.Nodes.Item())

        End If

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        Dim x As Integer
        Dim y As Integer
        Dim z As Integer

        Dim DBConn As SqlConnection
        Dim conexion As New VB.SysContab.Rutinas()
        DBConn = New SqlConnection(Rutinas.AbrirConexion())
        Dim Transaccion As SqlTransaction
        Dim i As Integer = 0
        Dim j As Integer

        Try
            DBConn.Open()
            Transaccion = DBConn.BeginTransaction
            VB.SysContab.SeguridadDB.RolesUpdate(lblRolID.Text, txtNombre.Text, txtDescripcion.Text, ckHabilitado.Checked, DBConn, Transaccion)

            'Borrar los Recursos de los Roles
            VB.SysContab.SeguridadDB.RolesRecursosBorrar(lblRolID.Text, DBConn, Transaccion)
            'Borrar los Recursos de los Roles
            VB.SysContab.SeguridadDB.RolesMenuBorrar(lblRolID.Text, DBConn, Transaccion)

            'Borrar las Acciones de los Roles
            VB.SysContab.SeguridadDB.RolesAccionesBorrar(lblRolID.Text, DBConn, Transaccion)


            'Agregar el Menu Principal
            '''Dim dsMenu As DataSet = VB.SysContab.SeguridadDB.MenuPrincipal(1, 0, lblRolID.Text)
            '''Dim dsMenu1 As DataSet
            '''Dim dsMenu2 As DataSet
            Dim a As Integer
            Dim b As Integer
            Dim c As Integer

            Dim m As Integer
            Dim n As Integer
            '''Dim o As Integer

            For j = 0 To Me.tvAcciones.GetNodeCount(False) - 1
                If Me.tvAcciones.Nodes.Item(j).Checked = True Then
                    If Me.tvTipo.Nodes.Item(j).Text = "M" Then
                        VB.SysContab.SeguridadDB.RolesMenuAdd(lblRolID.Text, Me.tvAcciones1.Nodes.Item(j).Text, DBConn, Transaccion)
                    ElseIf Me.tvTipo.Nodes.Item(j).Text = "R" Then
                        VB.SysContab.SeguridadDB.RolesRecursosAdd(lblRolID.Text, Me.tvAcciones1.Nodes.Item(j).Text, DBConn, Transaccion)
                    Else
                        VB.SysContab.SeguridadDB.RolesAccionesAdd(lblRolID.Text, Me.tvAcciones1.Nodes.Item(j).Text, DBConn, Transaccion)
                    End If
                End If

                For a = 0 To Me.tvAcciones.Nodes(j).GetNodeCount(False) - 1
                    If Me.tvAcciones.Nodes(j).Nodes.Item(a).Checked = True Then
                        If Me.tvTipo.Nodes(j).Nodes.Item(a).Text = "M" Then
                            VB.SysContab.SeguridadDB.RolesMenuAdd(lblRolID.Text, Me.tvAcciones1.Nodes(j).Nodes.Item(a).Text, DBConn, Transaccion)
                        ElseIf Me.tvTipo.Nodes(j).Nodes.Item(a).Text = "R" Then
                            VB.SysContab.SeguridadDB.RolesRecursosAdd(lblRolID.Text, Me.tvAcciones1.Nodes(j).Nodes.Item(a).Text, DBConn, Transaccion)
                        Else
                            VB.SysContab.SeguridadDB.RolesAccionesAdd(lblRolID.Text, Me.tvAcciones1.Nodes(j).Nodes.Item(a).Text, DBConn, Transaccion)
                        End If

                    End If

                    For b = 0 To Me.tvAcciones.Nodes(j).Nodes(a).GetNodeCount(False) - 1
                        If Me.tvAcciones.Nodes(j).Nodes(a).Nodes.Item(b).Checked = True Then
                            If Me.tvTipo.Nodes(j).Nodes(a).Nodes.Item(b).Text = "M" Then
                                VB.SysContab.SeguridadDB.RolesMenuAdd(lblRolID.Text, Me.tvAcciones1.Nodes(j).Nodes(a).Nodes.Item(b).Text, DBConn, Transaccion)
                            ElseIf Me.tvTipo.Nodes(j).Nodes(a).Nodes.Item(b).Text = "R" Then
                                VB.SysContab.SeguridadDB.RolesRecursosAdd(lblRolID.Text, Me.tvAcciones1.Nodes(j).Nodes(a).Nodes.Item(b).Text, DBConn, Transaccion)
                            Else
                                VB.SysContab.SeguridadDB.RolesAccionesAdd(lblRolID.Text, Me.tvAcciones1.Nodes(j).Nodes(a).Nodes.Item(b).Text, DBConn, Transaccion)
                            End If
                        End If

                        For m = 0 To Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).GetNodeCount(False) - 1
                            If Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).Nodes.Item(m).Checked = True Then
                                If Me.tvTipo.Nodes(j).Nodes(a).Nodes(b).Nodes.Item(m).Text = "M" Then
                                    VB.SysContab.SeguridadDB.RolesMenuAdd(lblRolID.Text, Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(b).Nodes.Item(m).Text, DBConn, Transaccion)
                                ElseIf Me.tvTipo.Nodes(j).Nodes(a).Nodes(b).Nodes.Item(m).Text = "R" Then
                                    VB.SysContab.SeguridadDB.RolesRecursosAdd(lblRolID.Text, Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(b).Nodes.Item(m).Text, DBConn, Transaccion)
                                Else
                                    VB.SysContab.SeguridadDB.RolesAccionesAdd(lblRolID.Text, Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(b).Nodes.Item(m).Text, DBConn, Transaccion)
                                End If

                                'For n = 0 To Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).Nodes(m).GetNodeCount(False) - 1
                                '    If Me.tvTipo.Nodes(j).Nodes(a).Nodes(b).Nodes(m).Nodes.Item(n).Text = "M" Then
                                '        VB.SysContab.SeguridadDB.RolesMenuAdd(lblRolID.Text, Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(b).Nodes(m).Nodes.Item(n).Text, DBConn, Transaccion)
                                '    ElseIf Me.tvTipo.Nodes(j).Nodes(a).Nodes(b).Nodes(m).Nodes.Item(n).Text = "R" Then
                                '        VB.SysContab.SeguridadDB.RolesRecursosAdd(lblRolID.Text, Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(b).Nodes(m).Nodes.Item(n).Text, DBConn, Transaccion)
                                '    Else
                                '        VB.SysContab.SeguridadDB.RolesAccionesAdd(lblRolID.Text, Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(b).Nodes(m).Nodes.Item(n).Text, DBConn, Transaccion)
                                '    End If
                                'Next

                                'MsgBox(Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).Nodes(m).Nodes.Item(0).Text)
                            End If

                            For n = 0 To Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).Nodes(m).GetNodeCount(False) - 1
                                If Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).Nodes(m).Nodes.Item(n).Checked = True Then
                                    If Me.tvTipo.Nodes(j).Nodes(a).Nodes(b).Nodes(m).Nodes.Item(n).Text = "M" Then
                                        VB.SysContab.SeguridadDB.RolesMenuAdd(lblRolID.Text, Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(b).Nodes(m).Nodes.Item(n).Text, DBConn, Transaccion)
                                    ElseIf Me.tvTipo.Nodes(j).Nodes(a).Nodes(b).Nodes(m).Nodes.Item(n).Text = "R" Then
                                        VB.SysContab.SeguridadDB.RolesRecursosAdd(lblRolID.Text, Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(b).Nodes(m).Nodes.Item(n).Text, DBConn, Transaccion)
                                    Else
                                        VB.SysContab.SeguridadDB.RolesAccionesAdd(lblRolID.Text, Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(b).Nodes(m).Nodes.Item(n).Text, DBConn, Transaccion)
                                    End If
                                End If
                            Next
                        Next


                        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                        'For c = 0 To Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).GetNodeCount(False) - 1
                        'Next
                        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    Next
                Next
                'For a = 0 To Me.tvAcciones.Nodes(j).GetNodeCount(False) - 1
                '    If Me.tvAcciones.Nodes(j).Nodes.Item(a).Checked = True Then
                '        MsgBox("Menu: " & Me.tvAcciones.Nodes(j).Nodes.Item(a).Text)
                '    End If
                '    For b = 0 To Me.tvAcciones.Nodes(j).Nodes(a).GetNodeCount(False) - 1
                '        If Me.tvAcciones.Nodes(j).Nodes(a).Nodes.Item(b).Checked = True Then
                '            MsgBox("Menu: " & Me.tvAcciones.Nodes(j).Nodes(a).Nodes.Item(b).Text)
                '        End If
                '        For o = 0 To Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).GetNodeCount(False) - 1
                '            If Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).Nodes.Item(o).Checked = True Then
                '                MsgBox("Recurso: " & Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).Nodes.Item(o).Text)
                '            End If
                '        Next
                '    Next
                '    For n = 0 To Me.tvAcciones.Nodes(j).Nodes(a).GetNodeCount(False) - 1
                '        If Me.tvAcciones.Nodes(j).Nodes(a).Nodes.Item(n).Checked = True Then
                '            MsgBox("Recurso: " & Me.tvAcciones.Nodes(j).Nodes(a).Nodes.Item(n).Text)
                '        End If
                '    Next
                'Next
            Next



            'Exit Sub


            '''''For i = 0 To Me.tvAcciones.GetNodeCount(False) - 1
            '''''    If Me.tvAcciones.Nodes.Item(i).Checked = True Then
            '''''        VB.SysContab.SeguridadDB.RolesRecursosAdd(lblRolID.Text, Me.tvAcciones1.Nodes.Item(i).Text, DBConn, Transaccion)
            '''''    End If

            '''''    For x = 0 To Me.tvAcciones.Nodes(i).GetNodeCount(False) - 1
            '''''        If Me.tvAcciones.Nodes(i).Nodes.Item(x).Checked = True Then
            '''''            VB.SysContab.SeguridadDB.RolesAccionesAdd(lblRolID.Text, Me.tvAcciones1.Nodes(i).Nodes.Item(x).Text, DBConn, Transaccion)
            '''''        End If

            '''''        For y = 0 To Me.tvAcciones.Nodes(i).Nodes(x).GetNodeCount(False) - 1
            '''''            If Me.tvAcciones.Nodes(i).Nodes(x).Nodes.Item(y).Checked = True Then
            '''''                VB.SysContab.SeguridadDB.RolesAccionesAdd(lblRolID.Text, Me.tvAcciones1.Nodes(i).Nodes(x).Nodes.Item(y).Text, DBConn, Transaccion)
            '''''            End If

            '''''            For z = 0 To Me.tvAcciones.Nodes(i).Nodes(x).Nodes(y).GetNodeCount(False) - 1
            '''''                If Me.tvAcciones.Nodes(i).Nodes(x).Nodes(y).Nodes.Item(z).Checked = True Then
            '''''                    VB.SysContab.SeguridadDB.RolesAccionesAdd(lblRolID.Text, Me.tvAcciones1.Nodes(i).Nodes(x).Nodes(y).Nodes.Item(z).Text, DBConn, Transaccion)
            '''''                End If
            '''''            Next
            '''''        Next
            '''''    Next
            '''''Next

            Transaccion.Commit()
            DBConn.Close()

            Me.Close()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Information)
            Transaccion.Rollback()
            DBConn.Close()
        End Try

        Rutinas.RecursosUsuario()
        Rutinas.MenuUsuario()

        ''Dim dsSeguridad As DataSet
        ''dsSeguridad = VB.SysContab.SeguridadDB.UsuarioRecursos(Usuario_ID)

        'Rutinas.DesabilitarRecursos(FormPrincipal.cmdPersonal)
        'Rutinas.DesabilitarRecursos(FormPrincipal.menuCatalogos)
        'Rutinas.DesabilitarRecursos(FormPrincipal.menuMovimientos)


        '''Menu Principal
        ''Rutinas.DesabilitarRecursos(FormPrincipal.cmdBancos)
        ''Rutinas.DesabilitarRecursos(FormPrincipal.cmdBase)
        ''Rutinas.DesabilitarRecursos(FormPrincipal.cmdClientes)
        ''Rutinas.DesabilitarRecursos(FormPrincipal.cmdHerramientas)
        ''Rutinas.DesabilitarRecursos(FormPrincipal.cmdProcesos)
        ''Rutinas.DesabilitarRecursos(FormPrincipal.cmdProveedores)
        ''Rutinas.DesabilitarRecursos(FormPrincipal.cmdReportes)

        ''Menu Catalogo
        'Rutinas.DesabilitarRecursos(FormPrincipal.menuCatalogos)
        'Rutinas.DesabilitarRecursos(FormPrincipal.menuMovimientos)
        ''Menu Procesos
        'Rutinas.DesabilitarRecursos(FormPrincipal.menuProcesos)
        'Rutinas.DesabilitarRecursos(FormPrincipal.menuPHorarios)
        'Rutinas.DesabilitarRecursos(FormPrincipal.MenuPHorasExtras)
        'Rutinas.DesabilitarRecursos(FormPrincipal.menuPMovimientos)
        'Rutinas.DesabilitarRecursos(FormPrincipal.menuPlanilla)
        'Rutinas.DesabilitarRecursos(FormPrincipal.menuVacaciones)
        'Rutinas.DesabilitarRecursos(FormPrincipal.cmdPeriodos)

        ''Menu Reportes
        'Rutinas.DesabilitarRecursos(FormPrincipal.MenuReportes)

        'Menu Herramientas
        ''Rutinas.DesabilitarRecursos(FormPrincipal.menuHerramientas)

        ''Rutinas.UsuariosRecursos(dsSeguridad)

    End Sub

    Private Sub lbAsignados_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbAsignados.SelectedIndexChanged
        If Not IsNumeric(Me.lbAsignados.SelectedValue) Then
            Exit Sub
        End If

        Exit Sub

        Dim x As Integer
        Dim y As Integer
        Dim z As Integer

        Me.tvAcciones.Nodes.Clear()
        Me.tvAcciones1.Nodes.Clear()

        Dim dsAcciones As DataSet
        dsAcciones = VB.SysContab.SeguridadDB.RecursosAcciones(1, 0, Me.lbAsignados.SelectedValue, lblRolID.Text)

        For x = 0 To dsAcciones.Tables("Usuarios").Rows.Count - 1
            Me.tvAcciones.Nodes.Add(dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_Nombre"))
            Me.tvAcciones1.Nodes.Add(dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"))

            For y = 0 To VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), Me.lbAsignados.SelectedValue, lblRolID.Text).Tables("Usuarios").Rows.Count - 1
                Me.tvAcciones.Nodes(x).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), Me.lbAsignados.SelectedValue, lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_Nombre"))
                Me.tvAcciones1.Nodes(x).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), Me.lbAsignados.SelectedValue, lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"))

                For z = 0 To VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), Me.lbAsignados.SelectedValue, lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"), Me.lbAsignados.SelectedValue, lblRolID.Text).Tables("Usuarios").Rows.Count - 1
                    Me.tvAcciones.Nodes(x).Nodes(y).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), Me.lbAsignados.SelectedValue, lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"), Me.lbAsignados.SelectedValue, lblRolID.Text).Tables("Usuarios").Rows(z).Item("Accion_Nombre"))
                    Me.tvAcciones1.Nodes(x).Nodes(y).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), Me.lbAsignados.SelectedValue, lblRolID.Text).Tables("Usuarios").Rows(y).Item("Accion_ID"), Me.lbAsignados.SelectedValue, lblRolID.Text).Tables("Usuarios").Rows(z).Item("Accion_ID"))
                Next
            Next
        Next

    End Sub

End Class
