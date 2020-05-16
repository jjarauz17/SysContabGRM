Public Class frmEmisores
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmEmisores = Nothing

    Public Shared Function Instance() As frmEmisores
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmEmisores()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance

    End Function

#Region " Código generado por el Diseñador de Windows Forms "

    Private Sub New()
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.gridDatos = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupBox1.SuspendLayout()
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdAyuda)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdImprimir)
        Me.GroupBox1.Controls.Add(Me.cmdBorrar)
        Me.GroupBox1.Controls.Add(Me.cmdModificar)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 352)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(614, 60)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.Location = New System.Drawing.Point(392, 17)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 35)
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = Global.SysContab.My.Resources.Resources._115_25x25
        Me.cmdSalir.Location = New System.Drawing.Point(488, 17)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 35)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Location = New System.Drawing.Point(200, 17)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 35)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.Location = New System.Drawing.Point(296, 17)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 35)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "&Borrar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.Location = New System.Drawing.Point(104, 17)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(72, 35)
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "&Editar"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.Location = New System.Drawing.Point(8, 17)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(72, 35)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'gridDatos
        '
        Me.gridDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDatos.Location = New System.Drawing.Point(12, 12)
        Me.gridDatos.MainView = Me.GridView1
        Me.gridDatos.Name = "gridDatos"
        Me.gridDatos.Size = New System.Drawing.Size(588, 334)
        Me.gridDatos.TabIndex = 27
        Me.gridDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gridDatos
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'frmEmisores
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(614, 412)
        Me.Controls.Add(Me.gridDatos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmEmisores"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Emisores As New VB.SysContab.EmisoresDB()
    Dim r As New VB.SysContab.Rutinas()
    Dim Tabla As New DataTable()
    Dim ds As New DataSet()

    Private Sub frmEmisores_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ''r.FormularioColor(Me)
            ''  '''r.CambiarEstilo(Me)

            RolesDB.UsuarioAcciones(GroupBox1)
            ''
            ds = Emisores.List
            Me.gridDatos.DataSource = ds.Tables("Emisores").DefaultView
            'dgEmisores.DataSource = ds.Tables("Emisores").DefaultView
            'Tabla = ds.Tables("Emisores")
            'r.FormatGenerico(dgEmisores, Tabla)

            Registro = Me.GridView1.GetRowCellValue(0, "Codigo")

            '''VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)

            'dgEmisores.CaptionText = "Información de Emisores de Tarjetas de Créditos"
            Me.Text = "Mantenimiento de Emisores de Tarjetas de Créditos"
            Me.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As frmAgregarEmisor = f.Instance
        Nuevo = "SI"
        f.MdiParent = Me.MdiParent
        f.Show()
        f.txtNombre.Focus()
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/RegEmisores.chm")
        'Help.ShowHelp(Me, "ayuda/STSContab.chm", HelpNavigator.KeywordIndex, "Emisores")
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        My.Forms.frmExportarImprimir.Mostrar(Me.gridDatos)
        'Dim fReportes As New frmReportes()
        'Dim rEmisores As New rptEmisores()
        'Dim Emisores As New VB.SysContab.EmisoresDB()
        'Dim r As New VB.SysContab.Rutinas()

        'rEmisores.SetDataSource(Emisores.GetList2(EmpresaActual))
        'fReportes.crvReportes.ReportSource = rEmisores
        'freportes.Show()
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If Me.GridView1.DataRowCount = 0 Then
            MsgBox("Seleccione un Registro", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Me.GridView1.FocusedRowHandle < 0 Then
            MsgBox("Seleccione un Registro", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim f As frmAgregarEmisor = f.Instance
        Nuevo = "NO"
        f.Codigo = Me.GridView1.GetFocusedRowCellValue("Codigo")
        f.MdiParent = Me.MdiParent
        f.Show()
        f.txtNombre.Focus()
    End Sub
End Class
