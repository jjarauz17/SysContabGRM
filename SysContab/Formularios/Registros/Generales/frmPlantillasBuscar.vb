Public Class frmPlantillasBuscar
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmPlantillasBuscar = Nothing

    Public Shared Function Instance() As frmPlantillasBuscar
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmPlantillasBuscar()
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
    Friend WithEvents dgZonas As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dgZonas = New System.Windows.Forms.DataGrid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.dgZonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgZonas
        '
        Me.dgZonas.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgZonas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgZonas.BackColor = System.Drawing.Color.Gainsboro
        Me.dgZonas.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgZonas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgZonas.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgZonas.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgZonas.CaptionForeColor = System.Drawing.Color.Black
        Me.dgZonas.DataMember = ""
        Me.dgZonas.FlatMode = True
        Me.dgZonas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgZonas.ForeColor = System.Drawing.Color.Black
        Me.dgZonas.GridLineColor = System.Drawing.Color.Silver
        Me.dgZonas.HeaderBackColor = System.Drawing.Color.Black
        Me.dgZonas.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgZonas.HeaderForeColor = System.Drawing.Color.White
        Me.dgZonas.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgZonas.Location = New System.Drawing.Point(16, 12)
        Me.dgZonas.Name = "dgZonas"
        Me.dgZonas.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgZonas.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgZonas.ReadOnly = True
        Me.dgZonas.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgZonas.SelectionForeColor = System.Drawing.Color.White
        Me.dgZonas.Size = New System.Drawing.Size(469, 145)
        Me.dgZonas.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdAyuda)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdImprimir)
        Me.GroupBox1.Controls.Add(Me.cmdBorrar)
        Me.GroupBox1.Controls.Add(Me.cmdModificar)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 163)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(469, 60)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.Location = New System.Drawing.Point(289, 17)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 35)
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = Global.SysContab.My.Resources.Resources._115_25x25
        Me.cmdSalir.Location = New System.Drawing.Point(385, 17)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 35)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(495, 17)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 35)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "Imprimir"
        Me.cmdImprimir.Visible = False
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.Location = New System.Drawing.Point(193, 17)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 35)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "Borrar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.Location = New System.Drawing.Point(104, 17)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(72, 35)
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "Editar"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.Location = New System.Drawing.Point(8, 17)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(72, 35)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "Nuevo"
        '
        'frmPlantillasBuscar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(504, 236)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgZonas)
        Me.Name = "frmPlantillasBuscar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgZonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Plant As New VB.SysContab.PlantillaDB()
    Dim r As New VB.SysContab.Rutinas()
    Dim Tabla As New DataTable()
    Dim ds As New DataSet()


    Private Sub frmPlantillasBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''  '''r.CambiarEstilo(Me)

        RolesDB.UsuarioAcciones(GroupBox1)
        ds = Plant.GetList()

        dgZonas.DataSource = Plant.GetList().Tables("Tablas").DefaultView
        Tabla = ds.Tables("Tablas")

        r.FormatGenerico(dgZonas, Tabla)

        If ds.Tables("Tablas").Rows.Count <> 0 Then
            Registro = dgZonas.Item(0, 0)
        Else
            Registro = "Vacio"
        End If

        '''VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)

        dgZonas.CaptionText = "Información de Plantillas"

        Me.Text = "Mantenimiento de Plantillas"
        Me.Refresh()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As frmTipoPlantillasAgregar = frmTipoPlantillasAgregar.Instance()
        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub


    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        Dim f As frmTipoPlantillasAgregarVer = f.Instance

        If Registro = "Vacio" Then
            MsgBox("Seleccione la Plantilla que desea Editar", MsgBoxStyle.Information)
            Exit Sub
        End If

        Registro = dgZonas.Item(Me.dgZonas.CurrentRowIndex, 0)

        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub

    Private Sub dgZonas_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgZonas.CurrentCellChanged
        Registro = dgZonas.Item(dgZonas.CurrentRowIndex, 0)
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        Dim resp As DialogResult

        If Registro = "Vacio" Then
            MsgBox("Seleccione la Zona que desea Borrar", MsgBoxStyle.Information)
            Exit Sub
        End If

        Registro = dgZonas.Item(Me.dgZonas.CurrentRowIndex, 0)

        resp = MsgBox("Esta seguro que dese borrar la Plantilla: " & dgZonas.Item(dgZonas.CurrentRowIndex, 0), MsgBoxStyle.YesNo + MsgBoxStyle.Question)

        If resp = DialogResult.No Then
            Exit Sub
        End If

        Try
            Plant.Delete(dgZonas.Item(dgZonas.CurrentRowIndex, 0))
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub

        End Try

        MsgBox("El registro ha sido borrado", MsgBoxStyle.Information)

        Dim r As New VB.SysContab.Rutinas()
        Dim Tabla As New DataTable()
        'Dim f As New frmGrupos()
        Dim ds As New DataSet()

        ''  '''r.CambiarEstilo(Me)

        ds = Plant.GetList

        dgZonas.DataSource = ds.Tables("Tablas").DefaultView
        Tabla = ds.Tables("Tablas")

        If ds.Tables("Tablas").Rows.Count = 0 Then
            Registro = "Vacio"
        Else
            Registro = dgZonas.Item(0, 0)

        End If

        r.FormatGenerico(dgZonas, Tabla)

    End Sub


    Private Sub dgZonas_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dgZonas.Navigate

    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = "'" Then
            e.Handled = True

        End If

    End Sub

    Private Sub dgZonas_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgZonas.MouseEnter
        'FormPrincipal.menuRegistros.Visible = False
        'FormPrincipal.menu1.Visible = False
        'FormPrincipal.menuContabilidad.Visible = False
        'FormPrincipal.menuGrupos.Visible = False
        'FormPrincipal.menuInventario.Visible = False

        ''Menu Herramientas
        'FormPrincipal.menuHerramientas.Visible = False

    End Sub

    Private Sub frmZonas_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        'FormPrincipal.menuRegistros.Visible = False
        'FormPrincipal.menu1.Visible = False
        'FormPrincipal.menuContabilidad.Visible = False
        'FormPrincipal.menuGrupos.Visible = False
        'FormPrincipal.menuInventario.Visible = False

        ''Menu Herramientas
        'FormPrincipal.menuHerramientas.Visible = False

    End Sub

    Private Sub txtBuscar_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'FormPrincipal.menuRegistros.Visible = False
        'FormPrincipal.menu1.Visible = False
        'FormPrincipal.menuContabilidad.Visible = False
        'FormPrincipal.menuGrupos.Visible = False
        'FormPrincipal.menuInventario.Visible = False

        ''Menu Herramientas
        'FormPrincipal.menuHerramientas.Visible = False

    End Sub

    'Private Sub frmZonas_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
    '    Opened = "NO"
    '    ''
    '    FormPrincipal.IsMdiContainer = False
    '    FormPrincipal.Text = NombreEmpresaActual
    '    FormPrincipal.Refresh()

    'End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click

        Dim fReporte As New frmReportes()
        'Dim rPlantilla As New rptPlantillas()
        Dim Plantilla As New VB.SysContab.PlantillaDB()
        Dim r As New VB.SysContab.Rutinas()

        Dim rPlantilla As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rPlantilla.Load(Application.StartupPath & "\Reportes\rptPlantillas.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        rPlantilla.SetDataSource(Plantilla.GetList2(EmpresaActual))
        fReporte.crvReportes.ReportSource = rPlantilla
        fReporte.Show()

    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/STSContab.chm", HelpNavigator.KeywordIndex, "Plantillas")
    End Sub
End Class
