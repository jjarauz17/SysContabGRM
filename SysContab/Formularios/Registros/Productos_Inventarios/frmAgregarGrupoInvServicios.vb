Imports System.Text.RegularExpressions

Public Class frmAgregarGrupoInvServicios
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAgregarGrupoInvServicios = Nothing

    Public Shared Function Instance() As frmAgregarGrupoInvServicios
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarGrupoInvServicios()
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
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMonto = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit()
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
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.SpinEdit1)
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
        Me.GroupBox1.Size = New System.Drawing.Size(538, 409)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(157, 100)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.Properties.Appearance.Options.UseFont = True
        Me.txtMonto.Properties.Mask.EditMask = "n2"
        Me.txtMonto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMonto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMonto.Size = New System.Drawing.Size(112, 22)
        Me.txtMonto.TabIndex = 17
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl1.Location = New System.Drawing.Point(237, 81)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl1.TabIndex = 16
        Me.LabelControl1.Text = "* Solo Aplica a Nivel 3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Monto Retención:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(43, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Retención %:"
        '
        'SpinEdit1
        '
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SpinEdit1.Location = New System.Drawing.Point(157, 72)
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpinEdit1.Properties.Appearance.Options.UseFont = True
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SpinEdit1.Properties.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.SpinEdit1.Properties.Mask.EditMask = "n2"
        Me.SpinEdit1.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.SpinEdit1.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.SpinEdit1.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SpinEdit1.Size = New System.Drawing.Size(74, 22)
        Me.SpinEdit1.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(2, 155)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(530, 10)
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
        Me.lbGruposSup.Size = New System.Drawing.Size(456, 160)
        Me.lbGruposSup.TabIndex = 11
        '
        'etCodigo
        '
        Me.etCodigo.AutoSize = True
        Me.etCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etCodigo.Location = New System.Drawing.Point(72, 24)
        Me.etCodigo.Name = "etCodigo"
        Me.etCodigo.Size = New System.Drawing.Size(62, 16)
        Me.etCodigo.TabIndex = 8
        Me.etCodigo.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(157, 20)
        Me.txtCodigo.MaxLength = 15
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(112, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(240, 372)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 26)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Location = New System.Drawing.Point(128, 372)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 26)
        Me.cmdAceptar.TabIndex = 4
        Me.cmdAceptar.Text = "Aceptar"
        '
        'txtNivel
        '
        Me.txtNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNivel.Location = New System.Drawing.Point(440, 132)
        Me.txtNivel.MaxLength = 1
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.Size = New System.Drawing.Size(32, 20)
        Me.txtNivel.TabIndex = 2
        Me.txtNivel.Visible = False
        '
        'etNivel
        '
        Me.etNivel.AutoSize = True
        Me.etNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etNivel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etNivel.Location = New System.Drawing.Point(228, 136)
        Me.etNivel.Name = "etNivel"
        Me.etNivel.Size = New System.Drawing.Size(206, 16)
        Me.etNivel.TabIndex = 4
        Me.etNivel.Text = "Nivel de Cuentas en Informe:"
        Me.etNivel.Visible = False
        '
        'etNombre
        '
        Me.etNombre.AutoSize = True
        Me.etNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etNombre.Location = New System.Drawing.Point(67, 50)
        Me.etNombre.Name = "etNombre"
        Me.etNombre.Size = New System.Drawing.Size(67, 16)
        Me.etNombre.TabIndex = 2
        Me.etNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(157, 46)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(366, 20)
        Me.txtNombre.TabIndex = 1
        '
        'frmAgregarGrupoInvServicios
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(566, 438)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAgregarGrupoInvServicios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Nivel As Integer
    Dim r As New VB.SysContab.Rutinas()
    Dim gruposInv As New VB.SysContab.Grupos_InventarioDB()

    Private Sub frmAgregarGrupoInvServicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ''r.CambiarEstilo(Me)

        Me.Text = "Editar Grupo de Servicios"
        Me.Refresh()

        GroupBox1.Top = Me.Height / 12
        GroupBox1.Left = Me.Height / 4

        If Nuevo = "NO" Then
            txtCodigo.ReadOnly = True
            Dim Detalles As VB.SysContab.Grupos_InventarioDetails = gruposInv.GetDetails(Registro, TipoGrupoInv)
            Me.txtCodigo.Text = Detalles.Codigo
            Me.txtNombre.Text = Detalles.Nombre
            Me.SpinEdit1.EditValue = Detalles.Retencion
            Me.txtMonto.EditValue = Detalles.MontoRetencion

            'Me.txtNivel.Text = Detalles.Nivel

            Dim g As New VB.SysContab.Grupos_InventarioDB()
            Dim longitud As Integer
            Dim i As Integer

            'longitud = txtCodigo.Text.Length
            longitud = Registro.Length

            If longitud = 1 Then
                Exit Sub
            Else
                lbGruposSup.Items.Clear()
                For i = 0 To longitud - 2
                    If g.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), TipoGrupoInv).Tables("Grupos_Inventario").Rows.Count <> 0 Then
                        lbGruposSup.Items.Add(g.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), TipoGrupoInv).Tables("Grupos_Inventario").Rows(0).Item("Codigo_Grupo") & " - " & g.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), TipoGrupoInv).Tables("Grupos_Inventario").Rows(0).Item("Nombre"))

                    End If

                Next

                If lbGruposSup.Items.Count <> 0 Then
                    etGruposSup.Visible = True
                    lbGruposSup.Visible = True

                End If

            End If

        Else
            Me.Text = "Agregar Grupo de Servicios"
        End If
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

        If lbGruposSup.Items.Count = 0 Then
            Nivel = 1
        ElseIf lbGruposSup.Items.Count = 1 Then
            Nivel = 2
        ElseIf lbGruposSup.Items.Count = 2 Then
            Nivel = 3
        ElseIf Me.lbGruposSup.Items.Count = 3 Then
            Nivel = 4
        End If

        If Nuevo = "SI" Then
            If Nivel = 3 Then
                gruposInv.AddItem(txtCodigo.Text, txtNombre.Text, "S", Nivel, Me.SpinEdit1.EditValue, txtMonto.EditValue)
            Else
                gruposInv.AddItem(txtCodigo.Text, txtNombre.Text, "S", Nivel)
            End If

            gruposInv.AddItem(txtCodigo.Text, txtNombre.Text, "S", Nivel)
            'MsgBox("El registro se ha grabado correctamente", MsgBoxStyle.Information)
            r.LimpiarControles(GroupBox1)
            txtCodigo.Focus()
        Else
            If Nivel = 3 Then
                gruposInv.Update(txtCodigo.Text, txtNombre.Text, "S", Me.SpinEdit1.EditValue, txtMonto.EditValue)
            Else
                gruposInv.Update(txtCodigo.Text, txtNombre.Text, "S")
            End If

            'MsgBox("El registro se ha actualizado correctamente", MsgBoxStyle.Information)
            Me.Close()
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmAgregarGrupoInvServicios_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Dim GruposInv As New VB.SysContab.Grupos_InventarioDB
        'Dim r As New VB.SysContab.Rutinas
        Dim grupoInv As frmGruposInventarios = frmGruposInventarios.Instance()
        grupoInv.Cargar(TipoGrupoInv)
        'Dim Tabla As New DataTable
        'Dim ds As New DataSet

        ' grupoInv.Cargar()

        'ds = GruposInv.GetList(TipoGrupoInv)

        'grupoInv.dgGruposInventario.DataSource = GruposInv.GetList(TipoGrupoInv).Tables("GRUPOS_INVENTARIO").DefaultView
        'Tabla = ds.Tables("GRUPOS_INVENTARIO")

        'r.FormatGenerico(grupoInv.dgGruposInventario, Tabla)

        'If ds.Tables("GRUPOS_INVENTARIO").Rows.Count <> 0 Then
        '    Registro = grupoInv.dgGruposInventario.Item(0, 0)
        'End If

    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged
        lbGruposSup.Items.Clear()
        lbGruposSup.Visible = False
        etGruposSup.Visible = False

        'Dim codigo As New Regex("\d{1}", RegexOptions.IgnoreCase)

        'If Not codigo.IsMatch(txtCodigo.Text) Then
        '    txtCodigo.ResetText()

        'End If

    End Sub

    Private Sub txtCodigo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.Leave
        Dim g As New VB.SysContab.Grupos_InventarioDB
        Dim longitud As Integer
        Dim i As Integer

        If Nuevo = "NO" Then
            Exit Sub
        End If

        If Trim(txtCodigo.Text) <> "" Then
            longitud = txtCodigo.Text.Length
            g.GetListCodigo(txtCodigo.Text, TipoGrupoInv)

            If longitud = 1 Then
                If g.GetListCodigo(txtCodigo.Text, TipoGrupoInv).Tables("Grupos_INVENTARIO").Rows.Count <> 0 Then
                    MsgBox("Código de Grupo ya existe", MsgBoxStyle.Information)
                    txtCodigo.Focus()
                    Exit Sub

                End If
            Else
                If g.GetListCodigo(txtCodigo.Text, TipoGrupoInv).Tables("Grupos_Inventario").Rows.Count <> 0 Then
                    MsgBox("Código de Grupo ya existe", MsgBoxStyle.Information)
                    txtCodigo.Focus()
                    Exit Sub

                End If

                lbGruposSup.Items.Clear()
                For i = 0 To longitud - 2
                    If g.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), TipoGrupoInv).Tables("Grupos_Inventario").Rows.Count <> 0 Then
                        lbGruposSup.Items.Add(g.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), TipoGrupoInv).Tables("Grupos_Inventario").Rows(0).Item("Codigo_Grupo") & " - " & g.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), TipoGrupoInv).Tables("Grupos_Inventario").Rows(0).Item("Nombre"))

                    End If

                Next

                If lbGruposSup.Items.Count <> 0 Then
                    etGruposSup.Visible = True
                    lbGruposSup.Visible = True

                End If

            End If

        End If

    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
            If Char.IsDigit(e.KeyChar) = False Then
                e.Handled = True
                Exit Sub

            End If
        End If

    End Sub
End Class
