Public Class frmFormaPago
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmFormaPago = Nothing

    Public Shared Function Instance() As frmFormaPago
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmFormaPago()
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
    Friend WithEvents dgFormaPago As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dgFormaPago = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBuscar = New System.Windows.Forms.TextBox
        CType(Me.dgFormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgFormaPago
        '
        Me.dgFormaPago.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgFormaPago.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgFormaPago.BackColor = System.Drawing.Color.Gainsboro
        Me.dgFormaPago.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgFormaPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgFormaPago.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgFormaPago.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgFormaPago.CaptionForeColor = System.Drawing.Color.Black
        Me.dgFormaPago.DataMember = ""
        Me.dgFormaPago.FlatMode = True
        Me.dgFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgFormaPago.ForeColor = System.Drawing.Color.Black
        Me.dgFormaPago.GridLineColor = System.Drawing.Color.Silver
        Me.dgFormaPago.HeaderBackColor = System.Drawing.Color.Black
        Me.dgFormaPago.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgFormaPago.HeaderForeColor = System.Drawing.Color.White
        Me.dgFormaPago.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgFormaPago.Location = New System.Drawing.Point(12, 35)
        Me.dgFormaPago.Name = "dgFormaPago"
        Me.dgFormaPago.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgFormaPago.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgFormaPago.ReadOnly = True
        Me.dgFormaPago.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgFormaPago.SelectionForeColor = System.Drawing.Color.White
        Me.dgFormaPago.Size = New System.Drawing.Size(481, 146)
        Me.dgFormaPago.TabIndex = 0
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
        Me.GroupBox1.Location = New System.Drawing.Point(0, 194)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(508, 60)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.Location = New System.Drawing.Point(242, 17)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 35)
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = Global.SysContab.My.Resources.Resources._115_25x25
        Me.cmdSalir.Location = New System.Drawing.Point(320, 17)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 35)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(398, 17)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 35)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Imprimir"
        Me.cmdImprimir.Visible = False
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.Location = New System.Drawing.Point(164, 17)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 35)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "&Borrar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.Location = New System.Drawing.Point(86, 17)
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
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(24, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(104, 9)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(389, 20)
        Me.txtBuscar.TabIndex = 7
        '
        'frmFormaPago
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(508, 254)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgFormaPago)
        Me.Name = "frmFormaPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgFormaPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmFormaPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Forma_Pago As New VB.SysContab.Forma_PagoDB()
        Dim r As New VB.SysContab.Rutinas()
        Dim Tabla As New DataTable()
        Dim ds As New DataTable()

        ''  '''r.CambiarEstilo(Me)

        RolesDB.UsuarioAcciones(GroupBox1)
        ''
        ds = Forma_Pago.GetList()

        dgFormaPago.DataSource = Forma_Pago.GetList().DefaultView
        Tabla = ds

        r.FormatGenerico(dgFormaPago, Tabla)

        If ds.Rows.Count <> 0 Then
            Registro = dgFormaPago.Item(0, 0)
        Else
            Registro = "Vacio"
        End If

        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)

        dgFormaPago.CaptionText = "Información de Formas de Pago"

        Me.Text = "Mantenimiento de Formas de Pago"
        Me.Refresh()

    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Dim FormaPago As New VB.SysContab.Forma_PagoDB()

        dgFormaPago.DataSource = FormaPago.GetListBuscar(txtBuscar.Text).Tables("Forma_Pago").DefaultView


        If FormaPago.GetListBuscar(txtBuscar.Text).Tables("Forma_Pago").Rows.Count = 0 Then
            Exit Sub

        End If

        Registro = dgFormaPago.Item(dgFormaPago.CurrentRowIndex, 0)
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As frmAgregarFormaPago = frmAgregarFormaPago.Instance()
        Nuevo = "SI"
        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        Dim f As frmAgregarFormaPago = frmAgregarFormaPago.Instance()
        'Dim FormaPago As New VB.SysContab.Forma_PagoDB()

        Nuevo = "NO"

        If Registro = "Vacio" Then
            MsgBox("Seleccione la Foma de Pago que desea Editar", MsgBoxStyle.Information)
            Exit Sub
        End If

        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub

    Private Sub dgFormaPago_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFormaPago.CurrentCellChanged
        Registro = dgFormaPago.Item(dgFormaPago.CurrentRowIndex, 0)

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        Dim resp As DialogResult
        Dim FormaPago As New VB.SysContab.Forma_PagoDB()

        If Registro = "Vacio" Then
            MsgBox("Seleccione la Forma de Pago que desea Borrar", MsgBoxStyle.Information)
            Exit Sub
        End If

        resp = MsgBox("Esta seguro que dese borrar la Forma de Pago: " & dgFormaPago.Item(dgFormaPago.CurrentRowIndex, 1), MsgBoxStyle.YesNo + MsgBoxStyle.Question)

        If resp = DialogResult.No Then
            Exit Sub
        End If

        Try
            FormaPago.Delete(dgFormaPago.Item(dgFormaPago.CurrentRowIndex, 0))
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub

        End Try

        Dim r As New VB.SysContab.Rutinas()
        Dim Tabla As New DataTable()
        Dim ds As New DataTable()

        ds = FormaPago.GetList()

        dgFormaPago.DataSource = FormaPago.GetList().DefaultView
        Tabla = ds

        If ds.Rows.Count = 0 Then
            Registro = "Vacio"
        Else
            Registro = dgFormaPago.Item(0, 0)

        End If

        r.FormatGenerico(dgFormaPago, Tabla)

    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True

        End If

    End Sub

    'Private Sub frmFormaPago_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
    '    FormPrincipal.menuRegistros.Visible = False
    '    FormPrincipal.menu1.Visible = False
    '    FormPrincipal.menuContabilidad.Visible = False
    '    FormPrincipal.menuGrupos.Visible = False
    '    FormPrincipal.menuInventario.Visible = False

    '    'Menu Herramientas
    '    FormPrincipal.menuHerramientas.Visible = False

    'End Sub

    'Private Sub txtBuscar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.MouseEnter
    '    FormPrincipal.menuRegistros.Visible = False
    '    FormPrincipal.menu1.Visible = False
    '    FormPrincipal.menuContabilidad.Visible = False
    '    FormPrincipal.menuGrupos.Visible = False
    '    FormPrincipal.menuInventario.Visible = False

    '    'Menu Herramientas
    '    FormPrincipal.menuHerramientas.Visible = False

    'End Sub

    'Private Sub dgFormaPago_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFormaPago.MouseEnter
    '    FormPrincipal.menuRegistros.Visible = False
    '    FormPrincipal.menu1.Visible = False
    '    FormPrincipal.menuContabilidad.Visible = False
    '    FormPrincipal.menuGrupos.Visible = False
    '    FormPrincipal.menuInventario.Visible = False

    '    'Menu Herramientas
    '    FormPrincipal.menuHerramientas.Visible = False

    'End Sub

    Private Sub frmFormaPago_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Opened = "NO"
        '''
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        'Dim fReportes As New frmReportes()
        'Dim rFormaPago As New rptFormasPago()
        'Dim FormaPago As New VB.SysContab.Forma_PagoDB()
        'Dim r As New VB.SysContab.Rutinas()

        'rFormaPago.SetDataSource(FormaPago.GetListReporte(txtBuscar.Text, EmpresaActual))
        'fReportes.crvReportes.ReportSource = rFormaPago
        'fReportes.Show()
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/RegFormasPago.chm")
        'Help.ShowHelp(Me, "ayuda/STSContab.chm", HelpNavigator.KeywordIndex, "FormadePago")
    End Sub
End Class
