Public Class frmAgregarAgrupacion
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAgregarAgrupacion = Nothing

    Public Shared Function Instance() As frmAgregarAgrupacion
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarAgrupacion()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.etGruposSup = New System.Windows.Forms.Label
        Me.lbGruposSup = New System.Windows.Forms.ListBox
        Me.etCodigo = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.txtNivel = New System.Windows.Forms.TextBox
        Me.etNivel = New System.Windows.Forms.Label
        Me.etNombre = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.etGruposSup)
        Me.GroupBox1.Controls.Add(Me.lbGruposSup)
        Me.GroupBox1.Controls.Add(Me.etCodigo)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.cmdCancelar)
        Me.GroupBox1.Controls.Add(Me.cmdAceptar)
        Me.GroupBox1.Controls.Add(Me.txtNivel)
        Me.GroupBox1.Controls.Add(Me.etNivel)
        Me.GroupBox1.Controls.Add(Me.etNombre)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 440)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(2, 155)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(484, 9)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'etGruposSup
        '
        Me.etGruposSup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etGruposSup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etGruposSup.Location = New System.Drawing.Point(16, 172)
        Me.etGruposSup.Name = "etGruposSup"
        Me.etGruposSup.Size = New System.Drawing.Size(176, 18)
        Me.etGruposSup.TabIndex = 12
        Me.etGruposSup.Text = "Grupos Superiores:"
        Me.etGruposSup.Visible = False
        '
        'lbGruposSup
        '
        Me.lbGruposSup.BackColor = System.Drawing.SystemColors.Control
        Me.lbGruposSup.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbGruposSup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGruposSup.ItemHeight = 16
        Me.lbGruposSup.Location = New System.Drawing.Point(16, 198)
        Me.lbGruposSup.Name = "lbGruposSup"
        Me.lbGruposSup.Size = New System.Drawing.Size(456, 176)
        Me.lbGruposSup.TabIndex = 11
        '
        'etCodigo
        '
        Me.etCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etCodigo.Location = New System.Drawing.Point(16, 34)
        Me.etCodigo.Name = "etCodigo"
        Me.etCodigo.Size = New System.Drawing.Size(72, 26)
        Me.etCodigo.TabIndex = 8
        Me.etCodigo.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(96, 34)
        Me.txtCodigo.MaxLength = 6
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(112, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(240, 396)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 26)
        Me.cmdCancelar.TabIndex = 4
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Location = New System.Drawing.Point(128, 396)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 26)
        Me.cmdAceptar.TabIndex = 3
        Me.cmdAceptar.Text = "Aceptar"
        '
        'txtNivel
        '
        Me.txtNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNivel.Location = New System.Drawing.Point(96, 121)
        Me.txtNivel.MaxLength = 1
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.Size = New System.Drawing.Size(40, 20)
        Me.txtNivel.TabIndex = 2
        '
        'etNivel
        '
        Me.etNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etNivel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etNivel.Location = New System.Drawing.Point(16, 121)
        Me.etNivel.Name = "etNivel"
        Me.etNivel.Size = New System.Drawing.Size(64, 25)
        Me.etNivel.TabIndex = 4
        Me.etNivel.Text = "Nivel"
        '
        'etNombre
        '
        Me.etNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etNombre.Location = New System.Drawing.Point(16, 78)
        Me.etNombre.Name = "etNombre"
        Me.etNombre.Size = New System.Drawing.Size(72, 25)
        Me.etNombre.TabIndex = 2
        Me.etNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(96, 78)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(344, 20)
        Me.txtNombre.TabIndex = 1
        '
        'frmAgregarAgrupacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(520, 470)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAgregarAgrupacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAgregarAgrupacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim r As New VB.SysContab.Rutinas()
        Dim Agrupaciones As New VB.SysContab.AgrupacionesDB()
        'Dim f As New frmGrupos()

        ''r.CambiarEstilo(Me)

        Me.Text = "Editar Agrupación"
        Me.Refresh()

        GroupBox1.Top = Me.Height / 12
        GroupBox1.Left = Me.Height / 4

        If Nuevo = "NO" Then
            txtCodigo.ReadOnly = True
            Dim Detalles As VB.SysContab.AgrupacionesDetails = Agrupaciones.GetDetails(Registro)
            Me.txtCodigo.Text = Detalles.Codigo
            Me.txtNombre.Text = Detalles.Nombre
            Me.txtNivel.Text = Detalles.Nivel
            'Me.txtNivel.Text = Detalles.Nivel

            'Dim g As New VB.SysContab.GruposDB()
            Dim longitud As Integer
            Dim i As Integer


            'longitud = txtCodigo.Text.Length
            longitud = Registro.Length

            If longitud = 1 Then
                Exit Sub
            Else
                lbGruposSup.Items.Clear()
                For i = 0 To longitud - 2
                    If Agrupaciones.GetListCodigo(txtCodigo.Text.Substring(0, i + 1)).Tables("Agrupaciones").Rows.Count <> 0 Then
                        lbGruposSup.Items.Add(Agrupaciones.GetListCodigo(txtCodigo.Text.Substring(0, i + 1)).Tables("Agrupaciones").Rows(0).Item("Codigo_Agrupacion") & " - " & Agrupaciones.GetListCodigo(txtCodigo.Text.Substring(0, i + 1)).Tables("Agrupaciones").Rows(0).Item("Nombre"))

                    End If

                Next

                If lbGruposSup.Items.Count <> 0 Then
                    etGruposSup.Visible = True
                    lbGruposSup.Visible = True

                End If

            End If

        Else
            Me.Text = "Agregar Agrupaciones"

        End If

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim Agrupaciones As New VB.SysContab.AgrupacionesDB()
        Dim r As New VB.SysContab.Rutinas()

        If Trim(txtCodigo.Text) = "" Then
            MsgBox("Introduzca el Código de la Agrupación", MsgBoxStyle.Information)
            txtCodigo.Focus()
            txtCodigo.SelectAll()
            Exit Sub

        End If

        If Trim(txtNombre.Text) = "" Then
            MsgBox("Introduzca el Nombre de la Agrupación", MsgBoxStyle.Information)
            txtNombre.Focus()
            txtNombre.SelectAll()
            Exit Sub

        End If

        If Trim(txtNivel.Text) = "" Then
            MsgBox("Introduzca el Nivel de la Agrupación", MsgBoxStyle.Information)
            txtNivel.Focus()
            txtNivel.SelectAll()
            Exit Sub

        End If

        If IsNumeric(txtNivel.Text) Then
            'OK
        Else
            MsgBox("El Nivel del Grupo debe ser un Número", MsgBoxStyle.Information)
            txtNivel.Focus()
            txtNivel.SelectAll()
            Exit Sub

        End If

        If Nuevo = "SI" Then
            Agrupaciones.AddItem(txtCodigo.Text, txtNombre.Text, txtNivel.Text, "")
            'MsgBox("El registro se ha grabado correctamente", MsgBoxStyle.Information)

            r.LimpiarControles(GroupBox1)

            txtCodigo.Focus()

        Else
            Agrupaciones.Update(txtCodigo.Text, txtNombre.Text, txtNivel.Text, "")
            'MsgBox("El registro se ha actualizado correctamente", MsgBoxStyle.Information)
            Me.Close()

        End If

    End Sub

    Private Sub frmAgregarAgrupacion_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim Agrupaciones As New VB.SysContab.AgrupacionesDB()
        Dim r As New VB.SysContab.Rutinas()
        Dim f As frmAgrupaciones = f.Instance
        Dim Tabla As New DataTable()
        Dim ds As New DataSet()

        ds = Agrupaciones.GetList()

        f.dgAgrupaciones.DataSource = Agrupaciones.GetList().Tables("Agrupaciones").DefaultView
        Tabla = ds.Tables("Agrupaciones")

        r.FormatGenerico(f.dgAgrupaciones, Tabla)

        If ds.Tables("Agrupaciones").Rows.Count <> 0 Then
            Registro = f.dgAgrupaciones.Item(0, 0)
        End If


    End Sub

    Private Sub txtCodigo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.Leave
        Dim Agrupaciones As New VB.SysContab.AgrupacionesDB()
        Dim longitud As Integer
        Dim i As Integer

        If Nuevo = "NO" Then
            Exit Sub
        End If

        If Trim(txtCodigo.Text) <> "" Then
            longitud = txtCodigo.Text.Length
            Agrupaciones.GetListCodigo(txtCodigo.Text)

            If longitud = 1 Then
                If Agrupaciones.GetListCodigo(txtCodigo.Text).Tables("Agrupaciones").Rows.Count <> 0 Then
                    MsgBox("Código de Agrupación ya existe", MsgBoxStyle.Information)
                    txtCodigo.Focus()
                    Exit Sub

                End If
            Else
                If Agrupaciones.GetListCodigo(txtCodigo.Text).Tables("Agrupaciones").Rows.Count <> 0 Then
                    MsgBox("Código de Agrupación ya existe", MsgBoxStyle.Information)
                    txtCodigo.Focus()
                    Exit Sub

                End If

                lbGruposSup.Items.Clear()
                For i = 0 To longitud - 2
                    If Agrupaciones.GetListCodigo(txtCodigo.Text.Substring(0, i + 1)).Tables("Agrupaciones").Rows.Count <> 0 Then
                        lbGruposSup.Items.Add(Agrupaciones.GetListCodigo(txtCodigo.Text.Substring(0, i + 1)).Tables("Agrupaciones").Rows(0).Item("Codigo_Agrupacion") & " - " & Agrupaciones.GetListCodigo(txtCodigo.Text.Substring(0, i + 1)).Tables("Agrupaciones").Rows(0).Item("Nombre"))

                    End If

                Next

                If lbGruposSup.Items.Count <> 0 Then
                    etGruposSup.Visible = True
                    lbGruposSup.Visible = True

                End If

            End If

        End If

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()

    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
            If Char.IsDigit(e.KeyChar) = False Then
                e.Handled = True
                Exit Sub

            End If
        End If

    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged
        lbGruposSup.Items.Clear()
        lbGruposSup.Visible = False
        etGruposSup.Visible = False

    End Sub
End Class
