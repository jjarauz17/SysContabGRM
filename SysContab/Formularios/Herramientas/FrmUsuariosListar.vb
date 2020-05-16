Imports DevExpress.XtraEditors

Public Class FrmUsuariosListar
    'Inherits System.Windows.Forms.Form
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As FrmUsuariosListar = Nothing

    Public Shared Function Instance() As FrmUsuariosListar
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmUsuariosListar
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
    Friend WithEvents vUsuarios As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents bExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dgUsuarios As DevExpress.XtraGrid.GridControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuariosListar))
        Me.dgUsuarios = New DevExpress.XtraGrid.GridControl()
        Me.vUsuarios = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.bExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgUsuarios
        '
        Me.dgUsuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgUsuarios.Location = New System.Drawing.Point(12, 12)
        Me.dgUsuarios.MainView = Me.vUsuarios
        Me.dgUsuarios.Name = "dgUsuarios"
        Me.dgUsuarios.Size = New System.Drawing.Size(621, 209)
        Me.dgUsuarios.TabIndex = 43
        Me.dgUsuarios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vUsuarios})
        '
        'vUsuarios
        '
        Me.vUsuarios.GridControl = Me.dgUsuarios
        Me.vUsuarios.Name = "vUsuarios"
        Me.vUsuarios.OptionsBehavior.Editable = False
        Me.vUsuarios.OptionsView.ShowAutoFilterRow = True
        Me.vUsuarios.OptionsView.ShowFooter = True
        Me.vUsuarios.OptionsView.ShowGroupPanel = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Enabled = False
        Me.btnNuevo.ImageOptions.Image = CType(resources.GetObject("btnNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(12, 225)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(96, 38)
        Me.btnNuevo.StyleController = Me.LayoutControl1
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "&Nuevo"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.bExportar)
        Me.LayoutControl1.Controls.Add(Me.btnSalir)
        Me.LayoutControl1.Controls.Add(Me.btnAyuda)
        Me.LayoutControl1.Controls.Add(Me.btnBorrar)
        Me.LayoutControl1.Controls.Add(Me.btnEditar)
        Me.LayoutControl1.Controls.Add(Me.btnNuevo)
        Me.LayoutControl1.Controls.Add(Me.dgUsuarios)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(837, 209, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(645, 275)
        Me.LayoutControl1.TabIndex = 45
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'bExportar
        '
        Me.bExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bExportar.Enabled = False
        Me.bExportar.ImageOptions.Image = CType(resources.GetObject("bExportar.ImageOptions.Image"), System.Drawing.Image)
        Me.bExportar.Location = New System.Drawing.Point(431, 225)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(102, 38)
        Me.bExportar.StyleController = Me.LayoutControl1
        Me.bExportar.TabIndex = 46
        Me.bExportar.Text = "E&xportar"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.ImageOptions.Image = CType(resources.GetObject("btnSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(537, 225)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 38)
        Me.btnSalir.StyleController = Me.LayoutControl1
        Me.btnSalir.TabIndex = 0
        Me.btnSalir.Text = "&Salir"
        '
        'btnAyuda
        '
        Me.btnAyuda.Enabled = False
        Me.btnAyuda.ImageOptions.Image = CType(resources.GetObject("btnAyuda.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAyuda.Location = New System.Drawing.Point(489, 426)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(84, 38)
        Me.btnAyuda.StyleController = Me.LayoutControl1
        Me.btnAyuda.TabIndex = 0
        Me.btnAyuda.Text = "&Ayuda"
        '
        'btnBorrar
        '
        Me.btnBorrar.Enabled = False
        Me.btnBorrar.ImageOptions.Image = CType(resources.GetObject("btnBorrar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBorrar.Location = New System.Drawing.Point(212, 225)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(109, 38)
        Me.btnBorrar.StyleController = Me.LayoutControl1
        Me.btnBorrar.TabIndex = 0
        Me.btnBorrar.Text = "&Deshabilitar"
        '
        'btnEditar
        '
        Me.btnEditar.Enabled = False
        Me.btnEditar.ImageOptions.Image = CType(resources.GetObject("btnEditar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(112, 225)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(96, 38)
        Me.btnEditar.StyleController = Me.LayoutControl1
        Me.btnEditar.TabIndex = 0
        Me.btnEditar.Text = "&Editar"
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.btnAyuda
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(477, 414)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(88, 42)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem6, Me.EmptySpaceItem1, Me.LayoutControlItem7})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(645, 275)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dgUsuarios
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(625, 213)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.btnNuevo
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 213)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.btnEditar
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(100, 213)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.btnBorrar
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(200, 213)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.btnSalir
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(525, 213)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(313, 213)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(106, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.bExportar
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(419, 213)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'FrmUsuariosListar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(645, 275)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "FrmUsuariosListar"
        Me.Text = "Listado de Usuarios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Rutinas As New VB.SysContab.Rutinas
    Public Origen As Integer '1 = Seguridad de Inicio, 2 = Desde el Menu Herramientas

    Private Sub FrmUsuariosListar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Rutinas.FormularioColor(Me)
        'Rutinas.CambiarEstilo(Me)

        'dgRoles.DataSource = Ds.Tables("Tabla")
        'Rutinas.FormatGenerico(dgRoles, Ds.Tables("Tabla"))
        'Me.dgRoles.ReadOnly = True

        RolesDB.UsuarioAcciones(LayoutControl1)
        Cargar()

        '*********************************
        ''''Me.cmdNuevo.Enabled = False
        ''''Me.cmdModificar.Enabled = False
        '''''Me.cmdImprimir.Enabled = False
        ''''Me.cmdBorrar.Enabled = False

        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        '*********************************
    End Sub

    Public Sub Cargar()
        'Dim Ds As DataSet = VB.SysContab.SeguridadDB.GetUsuariosList()

        'Me.dgUsuarios.DataSource = Ds.Tables("Tabla")

        Me.dgUsuarios.DataSource = ObtieneDatos("sp_GetUsuariosList")
        Me.vUsuarios.PopulateColumns()
        FormatoGrid(Me.vUsuarios)

        vUsuarios.Columns("Nombre").Width = 250
        vUsuarios.Columns("Correo").Width = 150
        vUsuarios.Columns("Rol Asignado").Width = 250
        vUsuarios.Columns("Empresa").Width = 300

        ' Me.vUsuarios.BestFitColumns()
    End Sub

    'Private Sub cmdAcumulado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.Close()
    'End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim f As FrmUsuarios = f.Instance
    '    f.MdiParent = Me.MdiParent
    '    f.Show()
    'End Sub

    'Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim f As FrmUsuariosEditar = f.Instance
    '    f.lblUserID.Text = dgRoles.Item(dgRoles.CurrentRowIndex, 0)
    '    f.MdiParent = Me.MdiParent
    '    f.Show()
    'End Sub

    'Private Sub cmdEstadoCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'End Sub

    'Private Sub FrmUsuariosListar_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
    '    'If Origen = 1 Then
    '    '    Dim f As frmPrincipalSeguridad = f.Instance
    '    '    f.IsMdiContainer = False
    '    '    f.Close()
    '    'End If
    'End Sub

    'Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Help.ShowHelp(Me, "Ayuda/Herramientas/Usuarios.chm")
    'End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAyuda.Click
        Help.ShowHelp(Me, "Ayuda/Herramientas/Usuarios.chm")
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        If Me.vUsuarios.FocusedRowHandle < 0 Then Exit Sub

        If XtraMessageBox.Show("¿ Esta Seguro que desea Deshabilitar el Usuario: " & Me.vUsuarios.GetFocusedRowCellValue("Login") & " ?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        End If

        'GuardaDatos("UPDATE Usuarios SET Usr_Habilitado = 0 WHERE Usr_Id =" & Me.vUsuarios.GetFocusedRowCellValue("Usuario"))

        If VB.SysContab.SeguridadDB.DeshabilitarUsuario(vUsuarios.GetFocusedRowCellValue("Usuario")) Then Cargar()

        'If MsgBox("Esta Seguro que desea Borrar este Usuario", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '    Try
        '        VB.SysContab.SeguridadDB.UsuariosBorrar(dgRoles.Item(dgRoles.CurrentRowIndex, 0))
        '        Dim Ds As DataSet = VB.SysContab.SeguridadDB.GetUsuariosList()
        '        dgRoles.DataSource = Ds.Tables("Tabla")
        '        Rutinas.FormatGenerico(dgRoles, Ds.Tables("Tabla"))
        '    Catch ex As Exception
        '    End Try
        'End If
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        If Me.vUsuarios.FocusedRowHandle < 0 Then Exit Sub

        Dim frm As FrmUsuariosEditar = FrmUsuariosEditar.Instance()
        frm.Dispose()

        Dim f As FrmUsuariosEditar = FrmUsuariosEditar.Instance()
        f.lblUserID.Text = Me.vUsuarios.GetFocusedRowCellValue("Usuario")  'dgRoles.Item(dgRoles.CurrentRowIndex, 0)
        f.MdiParent = Me.MdiParent
        f.Show()
        f.Text = "Editar Usuario"
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim f As FrmUsuarios = FrmUsuarios.Instance()
        f.MdiParent = Me.MdiParent
        f.Show()
        f.Text = "Registrar Nuevo Usuario"
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(dgUsuarios)
    End Sub
End Class
