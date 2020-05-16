Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration


Public Class FrmRolesAgregar
    Inherits DevExpress.XtraEditors.XtraForm

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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAcumulado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbRecursos As System.Windows.Forms.ListBox
    Friend WithEvents lbAsignados As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents ckHabilitado As System.Windows.Forms.CheckBox
    Friend WithEvents tvAcciones As System.Windows.Forms.TreeView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tvAcciones1 As System.Windows.Forms.TreeView
    Friend WithEvents tvTipo As System.Windows.Forms.TreeView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdAcumulado = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tvAcciones1 = New System.Windows.Forms.TreeView()
        Me.ckHabilitado = New System.Windows.Forms.CheckBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tvAcciones = New System.Windows.Forms.TreeView()
        Me.lbAsignados = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbRecursos = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tvTipo = New System.Windows.Forms.TreeView()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdAcumulado, Me.cmdAceptar})
        Me.GroupBox2.Location = New System.Drawing.Point(928, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(80, 520)
        Me.GroupBox2.TabIndex = 39
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
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.tvAcciones1, Me.ckHabilitado, Me.txtNombre, Me.Label29, Me.Label13, Me.txtDescripcion, Me.Label1})
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(912, 112)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        '
        'tvAcciones1
        '
        Me.tvAcciones1.CheckBoxes = True
        Me.tvAcciones1.ImageIndex = -1
        Me.tvAcciones1.Location = New System.Drawing.Point(576, 48)
        Me.tvAcciones1.Name = "tvAcciones1"
        Me.tvAcciones1.SelectedImageIndex = -1
        Me.tvAcciones1.Size = New System.Drawing.Size(72, 24)
        Me.tvAcciones1.TabIndex = 143
        Me.tvAcciones1.Visible = False
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
        Me.txtNombre.Size = New System.Drawing.Size(280, 20)
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
        Me.txtDescripcion.Size = New System.Drawing.Size(280, 20)
        Me.txtDescripcion.TabIndex = 2
        Me.txtDescripcion.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(432, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.tvTipo, Me.tvAcciones, Me.lbAsignados, Me.Label3, Me.lbRecursos, Me.Button2, Me.Button1, Me.Label4, Me.Label2})
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(8, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(912, 408)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
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
        Me.tvAcciones.TabIndex = 141
        '
        'lbAsignados
        '
        Me.lbAsignados.Location = New System.Drawing.Point(344, 32)
        Me.lbAsignados.Name = "lbAsignados"
        Me.lbAsignados.Size = New System.Drawing.Size(208, 303)
        Me.lbAsignados.TabIndex = 1
        Me.lbAsignados.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label3.Location = New System.Drawing.Point(384, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 24)
        Me.Label3.TabIndex = 137
        Me.Label3.Text = "Recursos Asignados"
        Me.Label3.Visible = False
        '
        'lbRecursos
        '
        Me.lbRecursos.Location = New System.Drawing.Point(16, 32)
        Me.lbRecursos.Name = "lbRecursos"
        Me.lbRecursos.Size = New System.Drawing.Size(208, 303)
        Me.lbRecursos.TabIndex = 0
        Me.lbRecursos.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 24)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "Recursos Disponibles"
        Me.Label2.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(248, 120)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Quitar"
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(248, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Asignar"
        Me.Button1.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 24)
        Me.Label4.TabIndex = 140
        Me.Label4.Text = "Recursos"
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
        Me.tvTipo.TabIndex = 142
        Me.tvTipo.Visible = False
        '
        'FrmRolesAgregar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1016, 526)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox1, Me.GroupBox2, Me.GroupBox3})
        Me.Name = "FrmRolesAgregar"
        Me.Text = "Agregar Roles"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Shared ChildInstance As FrmRolesAgregar = Nothing

    Public Shared Function Instance() As FrmRolesAgregar
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmRolesAgregar
        End If
        ChildInstance.BringToFront()

        Return ChildInstance

    End Function

    Dim Rutinas As New VB.SysContab.Rutinas

    Dim Disponibles As DataSet = New DataSet
    Dim DisTable As DataTable = Disponibles.Tables.Add("Disponibles")
    Dim DisRow As DataRow = DisTable.NewRow()
    Dim D1 As DataColumn = DisTable.Columns.Add("D1")
    Dim D2 As DataColumn = DisTable.Columns.Add("D2")


    Dim Seleccionados As DataSet = New DataSet
    Dim workTable As DataTable = Seleccionados.Tables.Add("Seleccionados")
    Dim workRow As DataRow = workTable.NewRow()
    Dim c1 As DataColumn = workTable.Columns.Add("c1")
    Dim c2 As DataColumn = workTable.Columns.Add("c2")

    Dim RolID As Integer


    Private Sub FrmRolesAgregar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Rutinas.FormularioColor(Me)

        Me.lbAsignados.BackColor = Color.White
        Me.lbRecursos.BackColor = Color.White
        Me.tvAcciones.BackColor = Color.White

        Label1.Text = Me.Name

        RolID = "-1"

        Dim Ds As DataSet = VB.SysContab.SeguridadDB.GetLisRecursos()

        Dim Rol As DataSet = VB.SysContab.SeguridadDB.GetRol(RolID)

        Dim i As Integer
        Dim j As Integer

        Me.tvAcciones.Nodes.Clear()
        'Me.tvAcciones1.Nodes.Clear()

        'Me.tvAcciones1.Visible = True

        'Agregar el Menu Principal
        Dim dsMenu As DataSet = VB.SysContab.SeguridadDB.MenuPrincipal(1, 0, RolID)
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
            dsRecursos = VB.SysContab.SeguridadDB.MenuRecursos(RolID, dsMenu.Tables("Menu").Rows(j).Item("Menu_ID"))

            dsMenu1 = VB.SysContab.SeguridadDB.MenuPrincipal(2, dsMenu.Tables("Menu").Rows(j).Item("Menu_ID"), RolID)

            For a = 0 To dsMenu1.Tables("Menu").Rows.Count - 1
                Me.tvAcciones.Nodes(j).Nodes.Add(dsMenu1.Tables("Menu").Rows(a).Item("Menu_Nombre"))
                Me.tvAcciones1.Nodes(j).Nodes.Add(dsMenu1.Tables("Menu").Rows(a).Item("Menu_ID"))
                Me.tvAcciones.Nodes(j).Nodes.Item(a).ForeColor = Color.Green
                'Sub Menu. Generales, Contables, ...

                Me.tvTipo.Nodes(j).Nodes.Add("M")

                Me.tvAcciones.Nodes(j).Nodes.Item(a).Checked = dsMenu1.Tables("Menu").Rows(a).Item("Asignado")

                dsRecursos1 = VB.SysContab.SeguridadDB.MenuRecursos(RolID, dsMenu1.Tables("Menu").Rows(a).Item("Menu_ID"))

                dsMenu2 = VB.SysContab.SeguridadDB.MenuPrincipal(3, dsMenu1.Tables("Menu").Rows(a).Item("Menu_ID"), RolID)

                For b = 0 To dsMenu2.Tables("Menu").Rows.Count - 1
                    Me.tvAcciones.Nodes(j).Nodes(a).Nodes.Add(dsMenu2.Tables("Menu").Rows(b).Item("Menu_Nombre"))
                    Me.tvAcciones1.Nodes(j).Nodes(a).Nodes.Add(dsMenu2.Tables("Menu").Rows(b).Item("Menu_ID"))

                    Me.tvTipo.Nodes(j).Nodes(a).Nodes.Add("M")

                    Me.tvAcciones.Nodes(j).Nodes(a).Nodes.Item(b).Checked = dsMenu2.Tables("Menu").Rows(b).Item("Asignado")

                    dsRecursos2 = VB.SysContab.SeguridadDB.MenuRecursos(RolID, dsMenu2.Tables("Menu").Rows(b).Item("Menu_ID"))

                    For o = 0 To dsRecursos2.Tables("Menu").Rows.Count - 1
                        Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).Nodes.Add(dsRecursos2.Tables("Menu").Rows(o).Item("Res_Nombre"))
                        Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(b).Nodes.Add(dsRecursos2.Tables("Menu").Rows(o).Item("Res_ID"))

                        Me.tvTipo.Nodes(j).Nodes(a).Nodes(b).Nodes.Add("R")
                        Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).Nodes.Item(o).Checked = dsRecursos2.Tables("Menu").Rows(o).Item("Asignado")

                        dsAcciones = VB.SysContab.SeguridadDB.RecursosAcciones(1, 0, dsRecursos2.Tables("Menu").Rows(o).Item("Res_ID"), RolID)

                        For x = 0 To dsAcciones.Tables("Usuarios").Rows.Count - 1
                            Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).Nodes(o).Nodes.Add(dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_Nombre"))
                            Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(b).Nodes(o).Nodes.Add(dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"))
                            Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).Nodes(o).Nodes.Item(x).Checked = dsAcciones.Tables("Usuarios").Rows(x).Item("Asignado")
                            Me.tvTipo.Nodes(j).Nodes(a).Nodes(b).Nodes(o).Nodes.Add("A")

                            ''
                            For y = 0 To VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos2.Tables("Menu").Rows(o).Item("Res_ID"), RolID).Tables("Usuarios").Rows.Count - 1
                                Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).Nodes(o).Nodes(x).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos2.Tables("Menu").Rows(o).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Accion_Nombre"))
                                Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(b).Nodes(o).Nodes(x).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos2.Tables("Menu").Rows(o).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"))
                                Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).Nodes(o).Nodes(x).Nodes.Item(y).Checked = VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos2.Tables("Menu").Rows(o).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Asignado")
                                Me.tvTipo.Nodes(j).Nodes(a).Nodes(b).Nodes(o).Nodes(x).Nodes.Add("A")

                                For z = 0 To VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos2.Tables("Menu").Rows(o).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos2.Tables("Menu").Rows(o).Item("Res_ID"), RolID).Tables("Usuarios").Rows.Count - 1
                                    Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).Nodes(o).Nodes(x).Nodes(y).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos2.Tables("Menu").Rows(o).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos2.Tables("Menu").Rows(o).Item("Res_ID"), RolID).Tables("Usuarios").Rows(z).Item("Accion_Nombre"))
                                    Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(b).Nodes(o).Nodes(x).Nodes(y).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos2.Tables("Menu").Rows(o).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos2.Tables("Menu").Rows(o).Item("Res_ID"), RolID).Tables("Usuarios").Rows(z).Item("Accion_ID"))
                                    Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).Nodes(o).Nodes(x).Nodes(y).Nodes.Item(z).Checked = VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos2.Tables("Menu").Rows(o).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos2.Tables("Menu").Rows(o).Item("Res_ID"), RolID).Tables("Usuarios").Rows(z).Item("Asignado")
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

                    dsAcciones = VB.SysContab.SeguridadDB.RecursosAcciones(1, 0, dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID)

                    'Revisar si se puede con el nivel del Recurso y no con el indice
                    If a = 1 Then
                        For x = 0 To dsAcciones.Tables("Usuarios").Rows.Count - 1
                            Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n + 1).Nodes.Add(dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_Nombre"))
                            Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(n + 1).Nodes.Add(dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"))
                            Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n + 1).Nodes.Item(x).Checked = dsAcciones.Tables("Usuarios").Rows(x).Item("Asignado")
                            Me.tvTipo.Nodes(j).Nodes(a).Nodes(n + 1).Nodes.Add("A")


                            For y = 0 To VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows.Count - 1
                                Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n + 1).Nodes(x).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Accion_Nombre"))
                                Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(n + 1).Nodes(x).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"))
                                Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n + 1).Nodes(x).Nodes.Item(y).Checked = VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Asignado")
                                Me.tvTipo.Nodes(j).Nodes(a).Nodes(n + 1).Nodes(x).Nodes.Add("A")

                                For z = 0 To VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows.Count - 1
                                    Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n + 1).Nodes(x).Nodes(y).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows(z).Item("Accion_Nombre"))
                                    Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(n + 1).Nodes(x).Nodes(y).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows(z).Item("Accion_ID"))
                                    Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n + 1).Nodes(x).Nodes(y).Nodes.Item(z).Checked = VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows(z).Item("Asignado")
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


                            For y = 0 To VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows.Count - 1
                                Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n).Nodes(x).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Accion_Nombre"))
                                Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(n).Nodes(x).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"))
                                Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n).Nodes(x).Nodes.Item(y).Checked = VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Asignado")
                                Me.tvTipo.Nodes(j).Nodes(a).Nodes(n).Nodes(x).Nodes.Add("A")

                                For z = 0 To VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows.Count - 1
                                    Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n).Nodes(x).Nodes(y).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows(z).Item("Accion_Nombre"))
                                    Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(n).Nodes(x).Nodes(y).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows(z).Item("Accion_ID"))
                                    Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n).Nodes(x).Nodes(y).Nodes.Item(z).Checked = VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows(z).Item("Asignado")
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

            ''''    dsAcciones = VB.SysContab.SeguridadDB.RecursosAcciones(1, 0, dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID)

            ''''    For x = 0 To dsAcciones.Tables("Usuarios").Rows.Count - 1
            ''''        Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n).Nodes.Add(dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_Nombre"))
            ''''        Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(n).Nodes.Add(dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"))
            ''''        Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n).Nodes.Item(x).Checked = dsAcciones.Tables("Usuarios").Rows(x).Item("Asignado")


            ''''        For y = 0 To VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows.Count - 1
            ''''            Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n).Nodes(x).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Accion_Nombre"))
            ''''            Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(n).Nodes(x).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"))
            ''''            Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n).Nodes(x).Nodes.Item(y).Checked = VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Asignado")

            ''''            For z = 0 To VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows.Count - 1
            ''''                Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n).Nodes(x).Nodes(y).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows(z).Item("Accion_Nombre"))
            ''''                Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(n).Nodes(x).Nodes(y).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows(z).Item("Accion_ID"))
            ''''                Me.tvAcciones.Nodes(j).Nodes(a).Nodes(n).Nodes(x).Nodes(y).Nodes.Item(z).Checked = VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos1.Tables("Menu").Rows(n).Item("Res_ID"), RolID).Tables("Usuarios").Rows(z).Item("Asignado")
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

                dsAcciones = VB.SysContab.SeguridadDB.RecursosAcciones(1, 0, dsRecursos.Tables("Menu").Rows(m).Item("Res_ID"), RolID)

                For x = 0 To dsAcciones.Tables("Usuarios").Rows.Count - 1
                    Me.tvAcciones.Nodes(j).Nodes(m).Nodes.Add(dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_Nombre"))
                    Me.tvAcciones1.Nodes(j).Nodes(m).Nodes.Add(dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"))
                    Me.tvTipo.Nodes(j).Nodes(m).Nodes.Add("A")
                    Me.tvAcciones.Nodes(j).Nodes(m).Nodes.Item(x).Checked = dsAcciones.Tables("Usuarios").Rows(x).Item("Asignado")


                    For y = 0 To VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos.Tables("Menu").Rows(m).Item("Res_ID"), RolID).Tables("Usuarios").Rows.Count - 1
                        Me.tvAcciones.Nodes(j).Nodes(m).Nodes(x).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos.Tables("Menu").Rows(m).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Accion_Nombre"))
                        Me.tvAcciones1.Nodes(j).Nodes(m).Nodes(x).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos.Tables("Menu").Rows(m).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"))
                        Me.tvAcciones.Nodes(j).Nodes(m).Nodes(x).Nodes.Item(y).Checked = VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos.Tables("Menu").Rows(m).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Asignado")
                        Me.tvTipo.Nodes(j).Nodes(m).Nodes(x).Nodes.Add("A")

                        For z = 0 To VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos.Tables("Menu").Rows(m).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos.Tables("Menu").Rows(m).Item("Res_ID"), RolID).Tables("Usuarios").Rows.Count - 1
                            Me.tvAcciones.Nodes(j).Nodes(m).Nodes(x).Nodes(y).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos.Tables("Menu").Rows(m).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos.Tables("Menu").Rows(m).Item("Res_ID"), RolID).Tables("Usuarios").Rows(z).Item("Accion_Nombre"))
                            Me.tvAcciones1.Nodes(j).Nodes(m).Nodes(x).Nodes(y).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos.Tables("Menu").Rows(m).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos.Tables("Menu").Rows(m).Item("Res_ID"), RolID).Tables("Usuarios").Rows(z).Item("Accion_ID"))
                            Me.tvAcciones.Nodes(j).Nodes(m).Nodes(x).Nodes(y).Nodes.Item(z).Checked = VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), dsRecursos.Tables("Menu").Rows(m).Item("Res_ID"), RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"), dsRecursos.Tables("Menu").Rows(m).Item("Res_ID"), RolID).Tables("Usuarios").Rows(z).Item("Asignado")
                            Me.tvTipo.Nodes(j).Nodes(m).Nodes(x).Nodes(y).Nodes.Add("A")
                        Next
                    Next
                Next

            Next
        Next

        '''''''''''For i = 0 To Ds.Tables("Tabla").Rows.Count - 1
        '''''''''''    DisRow = DisTable.NewRow()
        '''''''''''    DisRow(D1) = Ds.Tables("Tabla").Rows(i).Item("Recurso")
        '''''''''''    DisRow(D2) = Ds.Tables("Tabla").Rows(i).Item("Nombre")
        '''''''''''    DisTable.Rows.Add(DisRow)
        '''''''''''Next

        '''''''''''lbRecursos.DataSource = Disponibles.Tables("Disponibles")
        '''''''''''lbRecursos.ValueMember = "D1"
        '''''''''''lbRecursos.DisplayMember = "D2"

        '''''''''''Me.tvAcciones.Nodes.Clear()
        ''''''''''''Me.tvAcciones1.Nodes.Clear()

        '''''''''''For j = 0 To Rol.Tables("RolesRecursos").Rows.Count - 1
        '''''''''''    '
        '''''''''''    Me.tvAcciones.Nodes.Add(Rol.Tables("RolesRecursos").Rows(j).Item("Res_Nombre"))
        '''''''''''    Me.tvAcciones1.Nodes.Add(Rol.Tables("RolesRecursos").Rows(j).Item("Res_ID"))
        '''''''''''    Me.tvAcciones.Nodes.Item(j).Checked = Rol.Tables("RolesRecursos").Rows(j).Item("Asignado")
        '''''''''''Next


        ''''''''''''For i = 0 To Seleccionados.Tables("Seleccionados").Rows.Count - 1
        ''''''''''''    Me.tvAcciones.Nodes.Add(Seleccionados.Tables("Seleccionados").Rows(i).Item("c2"))
        ''''''''''''    Me.tvAcciones1.Nodes.Add(Seleccionados.Tables("Seleccionados").Rows(i).Item("c1"))

        ''''''''''''    'Me.tvAcciones.Nodes.Item(i).Checked = Seleccionados.Tables("RolesRecursos").Rows(i).Item("Asignado")
        ''''''''''''Next

        '''''''''''Dim x As Integer
        '''''''''''Dim y As Integer
        '''''''''''Dim z As Integer
        '''''''''''Dim dsAcciones As DataSet

        '''''''''''For i = 0 To Me.tvAcciones1.GetNodeCount(False) - 1
        '''''''''''    'MsgBox(Me.tvAcciones1.Nodes.Item(i).Text)
        '''''''''''    dsAcciones = VB.SysContab.SeguridadDB.RecursosAcciones(1, 0, Me.tvAcciones1.Nodes.Item(i).Text, RolID)

        '''''''''''    For x = 0 To dsAcciones.Tables("Usuarios").Rows.Count - 1
        '''''''''''        Me.tvAcciones.Nodes(i).Nodes.Add(dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_Nombre"))
        '''''''''''        Me.tvAcciones1.Nodes(i).Nodes.Add(dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"))

        '''''''''''        Me.tvAcciones.Nodes(i).Nodes.Item(x).Checked = dsAcciones.Tables("Usuarios").Rows(x).Item("Asignado")

        '''''''''''        For y = 0 To VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, RolID).Tables("Usuarios").Rows.Count - 1
        '''''''''''            Me.tvAcciones.Nodes(i).Nodes(x).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, RolID).Tables("Usuarios").Rows(y).Item("Accion_Nombre"))
        '''''''''''            Me.tvAcciones1.Nodes(i).Nodes(x).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"))

        '''''''''''            Me.tvAcciones.Nodes(i).Nodes(x).Nodes.Item(y).Checked = VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, RolID).Tables("Usuarios").Rows(y).Item("Asignado")

        '''''''''''            For z = 0 To VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), 1, RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"), 1, RolID).Tables("Usuarios").Rows.Count - 1
        '''''''''''                Me.tvAcciones.Nodes(i).Nodes(x).Nodes(y).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, RolID).Tables("Usuarios").Rows(z).Item("Accion_Nombre"))
        '''''''''''                Me.tvAcciones1.Nodes(i).Nodes(x).Nodes(y).Nodes.Add(VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, RolID).Tables("Usuarios").Rows(z).Item("Accion_ID"))

        '''''''''''                Me.tvAcciones.Nodes(i).Nodes(x).Nodes(y).Nodes.Item(z) = VB.SysContab.SeguridadDB.RecursosAcciones(3, VB.SysContab.SeguridadDB.RecursosAcciones(2, dsAcciones.Tables("Usuarios").Rows(x).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, RolID).Tables("Usuarios").Rows(y).Item("Accion_ID"), Me.tvAcciones1.Nodes.Item(i).Text, RolID).Tables("Usuarios").Rows(z).Item("Asignado")
        '''''''''''            Next
        '''''''''''        Next
        '''''''''''    Next
        '''''''''''Next

    End Sub

    Private Sub cmdAcumulado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcumulado.Click
        Me.Close()
    End Sub


    ' Asignar
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

    ' Quitar
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

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        Dim DBConn As SqlConnection
        Dim conexion As New VB.SysContab.Rutinas
        DBConn = New SqlConnection(Rutinas.AbrirConexion())
        Dim Transaccion As SqlTransaction
        Dim i As Integer = 0
        Dim j As Integer

        Dim x As Integer
        Dim y As Integer
        Dim z As Integer

        Try

            DBConn.Open()
            Transaccion = DBConn.BeginTransaction

            Dim RolID As String = VB.SysContab.SeguridadDB.RolesAdd(txtNombre.Text, txtDescripcion.Text, ckHabilitado.Checked, DBConn, Transaccion)

            Dim a As Integer
            Dim b As Integer
            Dim c As Integer

            Dim m As Integer
            Dim n As Integer
            '''Dim o As Integer

            For j = 0 To Me.tvAcciones.GetNodeCount(False) - 1
                If Me.tvAcciones.Nodes.Item(j).Checked = True Then
                    If Me.tvTipo.Nodes.Item(j).Text = "M" Then
                        VB.SysContab.SeguridadDB.RolesMenuAdd(RolID, Me.tvAcciones1.Nodes.Item(j).Text, DBConn, Transaccion)
                    ElseIf Me.tvTipo.Nodes.Item(j).Text = "R" Then
                        VB.SysContab.SeguridadDB.RolesRecursosAdd(RolID, Me.tvAcciones1.Nodes.Item(j).Text, DBConn, Transaccion)
                    Else
                        VB.SysContab.SeguridadDB.RolesAccionesAdd(RolID, Me.tvAcciones1.Nodes.Item(j).Text, DBConn, Transaccion)
                    End If
                End If

                For a = 0 To Me.tvAcciones.Nodes(j).GetNodeCount(False) - 1
                    If Me.tvAcciones.Nodes(j).Nodes.Item(a).Checked = True Then
                        If Me.tvTipo.Nodes(j).Nodes.Item(a).Text = "M" Then
                            VB.SysContab.SeguridadDB.RolesMenuAdd(RolID, Me.tvAcciones1.Nodes(j).Nodes.Item(a).Text, DBConn, Transaccion)
                        ElseIf Me.tvTipo.Nodes(j).Nodes.Item(a).Text = "R" Then
                            VB.SysContab.SeguridadDB.RolesRecursosAdd(RolID, Me.tvAcciones1.Nodes(j).Nodes.Item(a).Text, DBConn, Transaccion)
                        Else
                            VB.SysContab.SeguridadDB.RolesAccionesAdd(RolID, Me.tvAcciones1.Nodes(j).Nodes.Item(a).Text, DBConn, Transaccion)
                        End If

                    End If

                    For b = 0 To Me.tvAcciones.Nodes(j).Nodes(a).GetNodeCount(False) - 1
                        If Me.tvAcciones.Nodes(j).Nodes(a).Nodes.Item(b).Checked = True Then
                            If Me.tvTipo.Nodes(j).Nodes(a).Nodes.Item(b).Text = "M" Then
                                VB.SysContab.SeguridadDB.RolesMenuAdd(RolID, Me.tvAcciones1.Nodes(j).Nodes(a).Nodes.Item(b).Text, DBConn, Transaccion)
                            ElseIf Me.tvTipo.Nodes(j).Nodes(a).Nodes.Item(b).Text = "R" Then
                                VB.SysContab.SeguridadDB.RolesRecursosAdd(RolID, Me.tvAcciones1.Nodes(j).Nodes(a).Nodes.Item(b).Text, DBConn, Transaccion)
                            Else
                                VB.SysContab.SeguridadDB.RolesAccionesAdd(RolID, Me.tvAcciones1.Nodes(j).Nodes(a).Nodes.Item(b).Text, DBConn, Transaccion)
                            End If
                        End If

                        For m = 0 To Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).GetNodeCount(False) - 1
                            If Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).Nodes.Item(m).Checked = True Then
                                If Me.tvTipo.Nodes(j).Nodes(a).Nodes(b).Nodes.Item(m).Text = "M" Then
                                    VB.SysContab.SeguridadDB.RolesMenuAdd(RolID, Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(b).Nodes.Item(m).Text, DBConn, Transaccion)
                                ElseIf Me.tvTipo.Nodes(j).Nodes(a).Nodes(b).Nodes.Item(m).Text = "R" Then
                                    VB.SysContab.SeguridadDB.RolesRecursosAdd(RolID, Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(b).Nodes.Item(m).Text, DBConn, Transaccion)
                                Else
                                    VB.SysContab.SeguridadDB.RolesAccionesAdd(RolID, Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(b).Nodes.Item(m).Text, DBConn, Transaccion)
                                End If

                                'For n = 0 To Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).Nodes(m).GetNodeCount(False) - 1
                                '    If Me.tvTipo.Nodes(j).Nodes(a).Nodes(b).Nodes(m).Nodes.Item(n).Text = "M" Then
                                '        VB.SysContab.SeguridadDB.RolesMenuAdd(RolID, Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(b).Nodes(m).Nodes.Item(n).Text, DBConn, Transaccion)
                                '    ElseIf Me.tvTipo.Nodes(j).Nodes(a).Nodes(b).Nodes(m).Nodes.Item(n).Text = "R" Then
                                '        VB.SysContab.SeguridadDB.RolesRecursosAdd(RolID, Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(b).Nodes(m).Nodes.Item(n).Text, DBConn, Transaccion)
                                '    Else
                                '        VB.SysContab.SeguridadDB.RolesAccionesAdd(RolID, Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(b).Nodes(m).Nodes.Item(n).Text, DBConn, Transaccion)
                                '    End If
                                'Next

                                'MsgBox(Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).Nodes(m).Nodes.Item(0).Text)
                            End If

                            For n = 0 To Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).Nodes(m).GetNodeCount(False) - 1
                                If Me.tvAcciones.Nodes(j).Nodes(a).Nodes(b).Nodes(m).Nodes.Item(n).Checked = True Then
                                    If Me.tvTipo.Nodes(j).Nodes(a).Nodes(b).Nodes(m).Nodes.Item(n).Text = "M" Then
                                        VB.SysContab.SeguridadDB.RolesMenuAdd(RolID, Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(b).Nodes(m).Nodes.Item(n).Text, DBConn, Transaccion)
                                    ElseIf Me.tvTipo.Nodes(j).Nodes(a).Nodes(b).Nodes(m).Nodes.Item(n).Text = "R" Then
                                        VB.SysContab.SeguridadDB.RolesRecursosAdd(RolID, Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(b).Nodes(m).Nodes.Item(n).Text, DBConn, Transaccion)
                                    Else
                                        VB.SysContab.SeguridadDB.RolesAccionesAdd(RolID, Me.tvAcciones1.Nodes(j).Nodes(a).Nodes(b).Nodes(m).Nodes.Item(n).Text, DBConn, Transaccion)
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




            '''''''For i = 0 To Me.tvAcciones.GetNodeCount(False) - 1
            '''''''    If Me.tvAcciones.Nodes.Item(i).Checked = True Then
            '''''''        VB.SysContab.SeguridadDB.RolesRecursosAdd(RolID, Me.tvAcciones1.Nodes.Item(i).Text, DBConn, Transaccion)
            '''''''    End If

            '''''''    For x = 0 To Me.tvAcciones.Nodes(i).GetNodeCount(False) - 1
            '''''''        If Me.tvAcciones.Nodes(i).Nodes.Item(x).Checked = True Then
            '''''''            VB.SysContab.SeguridadDB.RolesAccionesAdd(RolID, Me.tvAcciones1.Nodes(i).Nodes.Item(x).Text, DBConn, Transaccion)
            '''''''            'MsgBox(Me.tvAcciones.Nodes(i).Nodes.Item(x).Text)
            '''''''        End If

            '''''''        For y = 0 To Me.tvAcciones.Nodes(i).Nodes(x).GetNodeCount(False) - 1
            '''''''            If Me.tvAcciones.Nodes(i).Nodes(x).Nodes.Item(y).Checked = True Then
            '''''''                VB.SysContab.SeguridadDB.RolesAccionesAdd(RolID, Me.tvAcciones1.Nodes(i).Nodes(x).Nodes.Item(y).Text, DBConn, Transaccion)
            '''''''                'MsgBox(Me.tvAcciones.Nodes(i).Nodes(x).Nodes.Item(y).Text)
            '''''''            End If

            '''''''            For z = 0 To Me.tvAcciones.Nodes(i).Nodes(x).Nodes(y).GetNodeCount(False) - 1
            '''''''                If Me.tvAcciones.Nodes(i).Nodes(x).Nodes(y).Nodes.Item(z).Checked = True Then
            '''''''                    VB.SysContab.SeguridadDB.RolesAccionesAdd(RolID, Me.tvAcciones1.Nodes(i).Nodes(x).Nodes(y).Nodes.Item(z).Text, DBConn, Transaccion)
            '''''''                    'MsgBox(Me.tvAcciones.Nodes(i).Nodes(x).Nodes(y).Nodes.Item(z).Text)
            '''''''                End If
            '''''''            Next
            '''''''        Next
            '''''''    Next
            '''''''Next

            'For i = 0 To Seleccionados.Tables("seleccionados").Rows.Count - 1
            '    VB.SysContab.SeguridadDB.RolesRecursosAdd(RolID, Seleccionados.Tables("seleccionados").Rows(i).Item("C1"), DBConn, Transaccion)
            'Next

            Transaccion.Commit()
            DBConn.Close()

            MsgBox("Se Registrado Correctamente el Rol")

            Me.Close()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Information)
            Transaccion.Rollback()
            DBConn.Close()
        End Try
    End Sub

End Class