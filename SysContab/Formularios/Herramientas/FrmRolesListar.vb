Public Class FrmRolesListar
    'Inherits System.Windows.Forms.Form
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As FrmRolesListar = Nothing

    Public Shared Function Instance() As FrmRolesListar
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmRolesListar()
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
    Friend WithEvents dgRolesE As DevExpress.XtraGrid.GridControl
    Friend WithEvents vRoles As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRolesListar))
        Me.dgRolesE = New DevExpress.XtraGrid.GridControl
        Me.vRoles = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.btnEditar = New DevExpress.XtraEditors.SimpleButton
        Me.btnBorrar = New DevExpress.XtraEditors.SimpleButton
        Me.btnAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton
        CType(Me.dgRolesE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgRolesE
        '
        Me.dgRolesE.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgRolesE.Location = New System.Drawing.Point(8, 9)
        Me.dgRolesE.MainView = Me.vRoles
        Me.dgRolesE.Name = "dgRolesE"
        Me.dgRolesE.Size = New System.Drawing.Size(568, 217)
        Me.dgRolesE.TabIndex = 44
        Me.dgRolesE.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vRoles})
        '
        'vRoles
        '
        Me.vRoles.GridControl = Me.dgRolesE
        Me.vRoles.Name = "vRoles"
        Me.vRoles.OptionsBehavior.Editable = False
        Me.vRoles.OptionsView.ShowAutoFilterRow = True
        Me.vRoles.OptionsView.ShowFooter = True
        Me.vRoles.OptionsView.ShowGroupPanel = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.btnNuevo)
        Me.PanelControl1.Controls.Add(Me.btnEditar)
        Me.PanelControl1.Controls.Add(Me.btnBorrar)
        Me.PanelControl1.Controls.Add(Me.btnAyuda)
        Me.PanelControl1.Controls.Add(Me.btnSalir)
        Me.PanelControl1.Location = New System.Drawing.Point(8, 230)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(568, 58)
        Me.PanelControl1.TabIndex = 45
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(16, 10)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(90, 37)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "&Nuevo"
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(120, 10)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(90, 37)
        Me.btnEditar.TabIndex = 0
        Me.btnEditar.Text = "&Editar"
        '
        'btnBorrar
        '
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.Location = New System.Drawing.Point(224, 10)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(104, 37)
        Me.btnBorrar.TabIndex = 0
        Me.btnBorrar.Text = "&Deshabilitar"
        '
        'btnAyuda
        '
        Me.btnAyuda.Image = CType(resources.GetObject("btnAyuda.Image"), System.Drawing.Image)
        Me.btnAyuda.Location = New System.Drawing.Point(344, 10)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(90, 37)
        Me.btnAyuda.TabIndex = 0
        Me.btnAyuda.Text = "&Ayuda"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(464, 10)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(90, 37)
        Me.btnSalir.TabIndex = 0
        Me.btnSalir.Text = "&Salir"
        '
        'FrmRolesListar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(584, 314)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.dgRolesE)
        Me.Name = "FrmRolesListar"
        Me.Text = "Lista de Roles"
        CType(Me.dgRolesE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vRoles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Rutinas As New VB.SysContab.Rutinas()
    Public Origen As Integer '1 = Seguridad de Inicio, 2 = Desde el Menu Herramientas

    Private Sub FrmRolesListar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Rutinas.FormularioColor(Me)
        'Rutinas.CambiarEstilo(Me)

        Cargar()

        '*********************************
        ''Me.cmdNuevo.Enabled = False
        ''Me.cmdModificar.Enabled = False
        '''Me.cmdImprimir.Enabled = False
        ''Me.cmdBorrar.Enabled = False

        ''VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        '*********************************
    End Sub

    Sub Cargar()
        Dim Ds As DataSet = VB.SysContab.SeguridadDB.GetLisRoles()

        Me.dgRolesE.DataSource = Ds.Tables("Tabla").DefaultView
        Me.vRoles.PopulateColumns()
        FormatoGrid(Me.vRoles)
        Me.vRoles.BestFitColumns()
    End Sub


    Private Sub FrmRolesListar_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed        
    End Sub


    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim F As FrmRolesAgregar = F.Instance
        F.MdiParent = Me.MdiParent
        F.Show()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        If Me.vRoles.FocusedRowHandle < 0 Then Exit Sub

        Dim F As FrmRolesEditar = FrmRolesEditar.Instance
        F.lblRolID.Text = Me.vRoles.GetFocusedRowCellValue("Rol") ' dgRoles.Item(dgRoles.CurrentRowIndex, 0)
        F.MdiParent = Me.MdiParent
        F.Show()
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        If Me.vRoles.FocusedRowHandle < 0 Then Exit Sub

        If DevExpress.XtraEditors.XtraMessageBox.Show("¿ Esta Seguro que desea Borrar este Rol: " & Me.vRoles.GetFocusedRowCellValue("Nombre") & " ?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        End If

        Try
            VB.SysContab.SeguridadDB.RolesBorrar(Me.vRoles.GetFocusedRowCellValue("Rol"))
            Cargar()
            'Dim Ds As DataSet = VB.SysContab.SeguridadDB.GetLisRoles()
            'dgRole.DataSource = Ds.Tables("Tabla")
            'Rutinas.FormatGenerico(dgRoles, Ds.Tables("Tabla"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAyuda.Click
        Help.ShowHelp(Me, "Ayuda/Herramientas/Roles.chm")
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
