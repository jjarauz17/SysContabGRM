Public Class frmGruposDepreciacion
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmGruposDepreciacion = Nothing

    Public Shared Function Instance() As frmGruposDepreciacion
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmGruposDepreciacion()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance

    End Function


#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dgGrupos_Depreciacion As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.dgGrupos_Depreciacion = New System.Windows.Forms.DataGrid
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        CType(Me.dgGrupos_Depreciacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 26)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(96, 17)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(384, 20)
        Me.txtBuscar.TabIndex = 11
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.Location = New System.Drawing.Point(399, 5)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 35)
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(495, 5)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 35)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Location = New System.Drawing.Point(207, 5)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 35)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.Location = New System.Drawing.Point(303, 5)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 35)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "&Borrar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.Location = New System.Drawing.Point(111, 5)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(72, 35)
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "&Editar"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.Location = New System.Drawing.Point(15, 5)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(72, 35)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'dgGrupos_Depreciacion
        '
        Me.dgGrupos_Depreciacion.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgGrupos_Depreciacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgGrupos_Depreciacion.BackColor = System.Drawing.Color.Gainsboro
        Me.dgGrupos_Depreciacion.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgGrupos_Depreciacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgGrupos_Depreciacion.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgGrupos_Depreciacion.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgGrupos_Depreciacion.CaptionForeColor = System.Drawing.Color.Black
        Me.dgGrupos_Depreciacion.DataMember = ""
        Me.dgGrupos_Depreciacion.FlatMode = True
        Me.dgGrupos_Depreciacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgGrupos_Depreciacion.ForeColor = System.Drawing.Color.Black
        Me.dgGrupos_Depreciacion.GridLineColor = System.Drawing.Color.Silver
        Me.dgGrupos_Depreciacion.HeaderBackColor = System.Drawing.Color.Black
        Me.dgGrupos_Depreciacion.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgGrupos_Depreciacion.HeaderForeColor = System.Drawing.Color.White
        Me.dgGrupos_Depreciacion.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgGrupos_Depreciacion.Location = New System.Drawing.Point(16, 43)
        Me.dgGrupos_Depreciacion.Name = "dgGrupos_Depreciacion"
        Me.dgGrupos_Depreciacion.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgGrupos_Depreciacion.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgGrupos_Depreciacion.ReadOnly = True
        Me.dgGrupos_Depreciacion.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgGrupos_Depreciacion.SelectionForeColor = System.Drawing.Color.White
        Me.dgGrupos_Depreciacion.Size = New System.Drawing.Size(820, 312)
        Me.dgGrupos_Depreciacion.TabIndex = 9
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdAyuda)
        Me.PanelControl1.Controls.Add(Me.cmdModificar)
        Me.PanelControl1.Controls.Add(Me.cmdSalir)
        Me.PanelControl1.Controls.Add(Me.cmdNuevo)
        Me.PanelControl1.Controls.Add(Me.cmdImprimir)
        Me.PanelControl1.Controls.Add(Me.cmdBorrar)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 361)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(848, 45)
        Me.PanelControl1.TabIndex = 13
        '
        'frmGruposDepreciacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(848, 406)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.dgGrupos_Depreciacion)
        Me.Name = "frmGruposDepreciacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgGrupos_Depreciacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim r As New VB.SysContab.Rutinas()

    Private Sub frmGrupos_Depreciacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(Me.PanelControl1)
        ''
        Dim Grupos_Depreciacion As New VB.SysContab.Grupos_DepreciacionDB()
        Dim Tabla As New DataTable()
        Dim ds As New DataSet()

        ''r.CambiarEstilo(Me)

        ds = Grupos_Depreciacion.GetList()

        dgGrupos_Depreciacion.DataSource = Grupos_Depreciacion.GetList().Tables("Grupos_Depreciacion").DefaultView
        Tabla = ds.Tables("Grupos_Depreciacion")

        r.FormatGenerico(dgGrupos_Depreciacion, Tabla)

        If ds.Tables("Grupos_Depreciacion").Rows.Count <> 0 Then
            Registro = dgGrupos_Depreciacion.Item(0, 0)
        Else
            Registro = "Vacio"
        End If

        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)

        dgGrupos_Depreciacion.CaptionText = "Información de Grupos de Depreciación"

        Me.Text = "Mantenimiento de Grupos de Depreciación"
        Me.Refresh()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim z As frmAgregarGrupoDepreciacion = z.Instance
        Nuevo = "SI"
        z.MdiParent = Me.MdiParent
        z.Show()

    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Dim Grupos_Depreciacion As New VB.SysContab.Grupos_DepreciacionDB()
        dgGrupos_Depreciacion.DataSource = Grupos_Depreciacion.GetListBuscar(txtBuscar.Text).Tables("Grupos_Depreciacion").DefaultView

        If Grupos_Depreciacion.GetListBuscar(txtBuscar.Text).Tables("Grupos_Depreciacion").Rows.Count = 0 Then
            Exit Sub

        End If

        Registro = dgGrupos_Depreciacion.Item(dgGrupos_Depreciacion.CurrentRowIndex, 0)
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        Dim f As frmAgregarGrupoDepreciacion = f.Instance
        Dim Grupos_Depreciacion As New VB.SysContab.Grupos_DepreciacionDB()

        Nuevo = "NO"

        If Registro = "Vacio" Then
            MsgBox("Seleccione el Grupos_Depreciacion que desea Editar", MsgBoxStyle.Information)
            Exit Sub
        End If

        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub

    Private Sub dgGrupos_Depreciacion_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgGrupos_Depreciacion.CurrentCellChanged
        Registro = dgGrupos_Depreciacion.Item(dgGrupos_Depreciacion.CurrentRowIndex, 0)

    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        Dim resp As DialogResult
        Dim Grupos_Depreciacion As New VB.SysContab.Grupos_DepreciacionDB()

        If Registro = "Vacio" Then
            MsgBox("Seleccione el Grupo de Depreciación que desea Borrar", MsgBoxStyle.Information)
            Exit Sub
        End If

        resp = MsgBox("Esta seguro que dese borrar el Grupo de Depreciación: " & dgGrupos_Depreciacion.Item(dgGrupos_Depreciacion.CurrentRowIndex, 0) & " - " & dgGrupos_Depreciacion.Item(dgGrupos_Depreciacion.CurrentRowIndex, 1), MsgBoxStyle.YesNo + MsgBoxStyle.Question)

        If resp = DialogResult.No Then
            Exit Sub
        End If

        Try
            Grupos_Depreciacion.Delete(dgGrupos_Depreciacion.Item(dgGrupos_Depreciacion.CurrentRowIndex, 0))
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub

        End Try

        MsgBox("El registro ha sido borrado", MsgBoxStyle.Information)

        Dim Tabla As New DataTable()
        'Dim f As New frmGrupos()
        Dim ds As New DataSet()

        '''r.CambiarEstilo(Me)

        ds = Grupos_Depreciacion.GetList

        dgGrupos_Depreciacion.DataSource = Grupos_Depreciacion.GetList().Tables("Grupos_Depreciacion").DefaultView
        Tabla = ds.Tables("Grupos_Depreciacion")

        If ds.Tables("Grupos_Depreciacion").Rows.Count = 0 Then
            Registro = "Vacio"
        Else
            Registro = dgGrupos_Depreciacion.Item(0, 0)

        End If

        r.FormatGenerico(dgGrupos_Depreciacion, Tabla)

    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True

        End If

    End Sub

    Private Sub frmGruposDepreciacion_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        ''
    End Sub

    Private Sub txtBuscar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.MouseEnter
        ''
    End Sub

    Private Sub dgGrupos_Depreciacion_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgGrupos_Depreciacion.MouseEnter
        ''
    End Sub

    Private Sub frmGruposDepreciacion_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Opened = "NO"
        ''
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/STSContab.chm", HelpNavigator.KeywordIndex, "Depreciacion")
    End Sub

End Class
