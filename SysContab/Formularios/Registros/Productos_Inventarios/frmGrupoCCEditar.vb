Imports System.Text.RegularExpressions

Public Class frmGrupoCCEditar
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmGrupoCCEditar = Nothing

    Public Shared Function Instance() As frmGrupoCCEditar
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmGrupoCCEditar()
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents etGruposSup As System.Windows.Forms.Label
    Friend WithEvents lbGruposSup As System.Windows.Forms.ListBox
    Friend WithEvents etCodigo As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNivel As System.Windows.Forms.TextBox
    Friend WithEvents etNivel As System.Windows.Forms.Label
    Friend WithEvents etNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.etGruposSup = New System.Windows.Forms.Label()
        Me.lbGruposSup = New System.Windows.Forms.ListBox()
        Me.etCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtNivel = New System.Windows.Forms.TextBox()
        Me.etNivel = New System.Windows.Forms.Label()
        Me.etNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox2, Me.etGruposSup, Me.lbGruposSup, Me.etCodigo, Me.txtCodigo, Me.cmdCancelar, Me.cmdAceptar, Me.txtNivel, Me.etNivel, Me.etNombre, Me.txtNombre})
        Me.GroupBox1.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 408)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(2, 144)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(484, 8)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'etGruposSup
        '
        Me.etGruposSup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etGruposSup.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.etGruposSup.Location = New System.Drawing.Point(16, 160)
        Me.etGruposSup.Name = "etGruposSup"
        Me.etGruposSup.Size = New System.Drawing.Size(176, 16)
        Me.etGruposSup.TabIndex = 12
        Me.etGruposSup.Text = "Grupos Superiores:"
        Me.etGruposSup.Visible = False
        '
        'lbGruposSup
        '
        Me.lbGruposSup.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.lbGruposSup.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbGruposSup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGruposSup.ItemHeight = 16
        Me.lbGruposSup.Location = New System.Drawing.Point(16, 184)
        Me.lbGruposSup.Name = "lbGruposSup"
        Me.lbGruposSup.Size = New System.Drawing.Size(456, 176)
        Me.lbGruposSup.TabIndex = 11
        '
        'etCodigo
        '
        Me.etCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.etCodigo.Location = New System.Drawing.Point(16, 32)
        Me.etCodigo.Name = "etCodigo"
        Me.etCodigo.Size = New System.Drawing.Size(72, 24)
        Me.etCodigo.TabIndex = 8
        Me.etCodigo.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(96, 32)
        Me.txtCodigo.MaxLength = 6
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(112, 20)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.Text = ""
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Location = New System.Drawing.Point(240, 368)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 24)
        Me.cmdCancelar.TabIndex = 4
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Location = New System.Drawing.Point(128, 368)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 24)
        Me.cmdAceptar.TabIndex = 3
        Me.cmdAceptar.Text = "Aceptar"
        '
        'txtNivel
        '
        Me.txtNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNivel.Location = New System.Drawing.Point(232, 112)
        Me.txtNivel.MaxLength = 1
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.Size = New System.Drawing.Size(32, 20)
        Me.txtNivel.TabIndex = 2
        Me.txtNivel.Text = ""
        Me.txtNivel.Visible = False
        '
        'etNivel
        '
        Me.etNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etNivel.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.etNivel.Location = New System.Drawing.Point(16, 112)
        Me.etNivel.Name = "etNivel"
        Me.etNivel.Size = New System.Drawing.Size(208, 24)
        Me.etNivel.TabIndex = 4
        Me.etNivel.Text = "Nivel de Cuentas en Informe:"
        Me.etNivel.Visible = False
        '
        'etNombre
        '
        Me.etNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etNombre.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.etNombre.Location = New System.Drawing.Point(16, 72)
        Me.etNombre.Name = "etNombre"
        Me.etNombre.Size = New System.Drawing.Size(72, 24)
        Me.etNombre.TabIndex = 2
        Me.etNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(96, 72)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(376, 20)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.Text = ""
        '
        'frmGrupoCCEditar
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(520, 438)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox1})
        Me.Name = "frmGrupoCCEditar"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    'Dim Nivel As Integer

    Dim GruposCC As New VB.SysContab.GruposCCDB()
    Dim r As New VB.SysContab.Rutinas()

    Private Sub frmGrupoCCEditar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        r.FormularioColor(Me)

        'Me.Text = "Editar Grupo de Productos"
        'Me.Refresh()

        GroupBox1.Top = Me.Height / 12
        GroupBox1.Left = Me.Height / 4
        Dim ds As DataSet
        ds = GruposCC.Detalles(Me.txtCodigo.Text)

        txtCodigo.ReadOnly = True
        'Dim Detalles As VB.SysContab.Grupos_InventarioDetails = gruposInv.GetDetails(Registro, TipoGrupoInv)
        'Me.txtCodigo.Text = Detalles.Codigo
        Me.txtNombre.Text = ds.Tables("GruposCC").Rows(0).Item("Nombre")
        'Nivel = ds.Tables("GruposCC").Rows(0).Item("Nivel")

        Dim longitud As Integer
        Dim i As Integer
        longitud = Me.txtCodigo.Text.Length

        If longitud = 1 Then
            Exit Sub
        Else
            lbGruposSup.Items.Clear()
            For i = 0 To longitud - 2
                If GruposCC.NivelSuperior(txtCodigo.Text.Substring(0, i + 1)).Tables("GruposCC").Rows.Count <> 0 Then
                    lbGruposSup.Items.Add(GruposCC.NivelSuperior(txtCodigo.Text.Substring(0, i + 1)).Tables("GruposCC").Rows(0).Item("Código") & " - " & GruposCC.NivelSuperior(txtCodigo.Text.Substring(0, i + 1)).Tables("GruposCC").Rows(0).Item("Nombre"))
                End If
            Next

            If lbGruposSup.Items.Count <> 0 Then
                etGruposSup.Visible = True
                lbGruposSup.Visible = True
            End If
        End If

        Me.Text = "Editar Grupo de Inventario"
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Trim(txtCodigo.Text) = "" Then
            MsgBox("Introduzca el Código del Grupo", MsgBoxStyle.Information)
            txtCodigo.Focus()
            txtCodigo.SelectAll()
            Exit Sub

        End If

        If Trim(txtNombre.Text) = "" Then
            MsgBox("Introduzca el Nombre del Grupo", MsgBoxStyle.Information)
            txtNombre.Focus()
            txtNombre.SelectAll()
            Exit Sub
        End If

        'If lbGruposSup.Items.Count = 0 Then
        '    Nivel = 1
        'ElseIf lbGruposSup.Items.Count = 1 Then
        '    Nivel = 2
        'ElseIf lbGruposSup.Items.Count = 2 Then
        '    Nivel = 3
        'End If

        Try
            GruposCC.Edit(txtCodigo.Text, txtNombre.Text)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged
        lbGruposSup.Items.Clear()
        lbGruposSup.Visible = False
        etGruposSup.Visible = False
    End Sub

    Private Sub txtCodigo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.Leave
        ''Dim g As New VB.SysContab.Grupos_InventarioDB()
        'Dim longitud As Integer
        'Dim i As Integer

        ''If Nuevo = "NO" Then
        ''    Exit Sub
        ''End If

        'If Trim(txtCodigo.Text) <> "" Then
        '    longitud = txtCodigo.Text.Length
        '    GruposCC.GetListCodigo(txtCodigo.Text)

        '    If longitud = 1 Then
        '        If GruposCC.GetListCodigo(txtCodigo.Text).Tables("GruposCC").Rows.Count <> 0 Then
        '            MsgBox("Código de Grupo ya existe", MsgBoxStyle.Information)
        '            txtCodigo.Focus()
        '            Exit Sub
        '        End If
        '    Else
        '        If GruposCC.GetListCodigo(txtCodigo.Text).Tables("GruposCC").Rows.Count <> 0 Then
        '            MsgBox("Código de Grupo ya existe", MsgBoxStyle.Information)
        '            txtCodigo.Focus()
        '            Exit Sub
        '        End If

        '        lbGruposSup.Items.Clear()
        '        For i = 0 To longitud - 2
        '            If GruposCC.GetListCodigo(txtCodigo.Text.Substring(0, i + 1)).Tables("GruposCC").Rows.Count <> 0 Then
        '                lbGruposSup.Items.Add(GruposCC.GetListCodigo(txtCodigo.Text.Substring(0, i + 1)).Tables("GruposCC").Rows(0).Item("Código") & " - " & GruposCC.GetListCodigo(txtCodigo.Text.Substring(0, i + 1)).Tables("GruposCC").Rows(0).Item("Nombre"))
        '            End If
        '        Next

        '        If lbGruposSup.Items.Count <> 0 Then
        '            etGruposSup.Visible = True
        '            lbGruposSup.Visible = True
        '        End If
        '    End If
        'End If

    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        'If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
        '    If Char.IsDigit(e.KeyChar) = False Then
        '        e.Handled = True
        '        Exit Sub
        '    End If
        'End If
    End Sub

    Private Sub frmGrupoCCEditar_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim f As frmGruposCC = f.Instance
        f.ds = GruposCC.List()

        f.dgGruposInventario.DataSource = f.ds.Tables("GruposCC").DefaultView
        f.Tabla = f.ds.Tables("GruposCC")
    End Sub

End Class
