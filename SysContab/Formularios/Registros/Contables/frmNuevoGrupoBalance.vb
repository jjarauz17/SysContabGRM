Imports System.Windows.Forms.Application
Imports System.Globalization
Imports System.Text.RegularExpressions

Public Class frmNuevoGrupoBalance
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmNuevoGrupoBalance = Nothing

    Public Shared Function Instance() As frmNuevoGrupoBalance
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmNuevoGrupoBalance()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

#Region "Variables"
    Dim Detalle As Integer = 0
    Dim Detalles As New VB.SysContab.GruposDetails
#End Region

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
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtNivel As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents etNombre As System.Windows.Forms.Label
    Friend WithEvents etCodigo As System.Windows.Forms.Label
    Friend WithEvents etNivel As System.Windows.Forms.Label
    Friend WithEvents Vista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dgNiveles As DevExpress.XtraGrid.GridControl
    Friend WithEvents cmdArriba As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmdAbajo As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.etNombre = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.etCodigo = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.txtNivel = New System.Windows.Forms.TextBox
        Me.etNivel = New System.Windows.Forms.Label
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.dgNiveles = New DevExpress.XtraGrid.GridControl
        Me.Vista = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmdArriba = New DevExpress.XtraEditors.SimpleButton
        Me.CmdAbajo = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgNiveles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(96, 78)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(344, 20)
        Me.txtNombre.TabIndex = 2
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.etCodigo)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.txtNivel)
        Me.GroupBox1.Controls.Add(Me.etNivel)
        Me.GroupBox1.Controls.Add(Me.etNombre)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 155)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
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
        Me.txtCodigo.TabIndex = 1
        '
        'txtNivel
        '
        Me.txtNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNivel.Location = New System.Drawing.Point(232, 121)
        Me.txtNivel.MaxLength = 1
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.Size = New System.Drawing.Size(40, 20)
        Me.txtNivel.TabIndex = 3
        '
        'etNivel
        '
        Me.etNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etNivel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etNivel.Location = New System.Drawing.Point(16, 121)
        Me.etNivel.Name = "etNivel"
        Me.etNivel.Size = New System.Drawing.Size(208, 25)
        Me.etNivel.TabIndex = 4
        Me.etNivel.Text = "Nivel de Cuentas en Informe:"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(432, 442)
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
        Me.cmdAceptar.Location = New System.Drawing.Point(344, 442)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 26)
        Me.cmdAceptar.TabIndex = 4
        Me.cmdAceptar.Text = "Aceptar"
        '
        'dgNiveles
        '
        Me.dgNiveles.Location = New System.Drawing.Point(16, 181)
        Me.dgNiveles.LookAndFeel.UseDefaultLookAndFeel = True
        Me.dgNiveles.LookAndFeel.UseWindowsXPTheme = False
        Me.dgNiveles.MainView = Me.Vista
        Me.dgNiveles.Name = "dgNiveles"
        Me.dgNiveles.Size = New System.Drawing.Size(488, 255)
        Me.dgNiveles.TabIndex = 8
        Me.dgNiveles.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Vista})
        '
        'Vista
        '
        Me.Vista.GridControl = Me.dgNiveles
        Me.Vista.Name = "Vista"
        Me.Vista.OptionsCustomization.AllowColumnMoving = False
        Me.Vista.OptionsCustomization.AllowColumnResizing = False
        Me.Vista.OptionsCustomization.AllowFilter = False
        Me.Vista.OptionsCustomization.AllowGroup = False
        Me.Vista.OptionsCustomization.AllowSort = False
        Me.Vista.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Vista.OptionsView.ShowGroupPanel = False
        '
        'cmdArriba
        '
        Me.cmdArriba.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdArriba.Appearance.Options.UseFont = True
        Me.cmdArriba.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdArriba.Location = New System.Drawing.Point(512, 181)
        Me.cmdArriba.Name = "cmdArriba"
        Me.cmdArriba.Size = New System.Drawing.Size(44, 26)
        Me.cmdArriba.TabIndex = 6
        Me.cmdArriba.Text = "Arriba"
        '
        'CmdAbajo
        '
        Me.CmdAbajo.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAbajo.Appearance.Options.UseFont = True
        Me.CmdAbajo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdAbajo.Location = New System.Drawing.Point(512, 215)
        Me.CmdAbajo.Name = "CmdAbajo"
        Me.CmdAbajo.Size = New System.Drawing.Size(44, 26)
        Me.CmdAbajo.TabIndex = 7
        Me.CmdAbajo.Text = "Abajo"
        '
        'frmNuevoGrupoBalance
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(560, 477)
        Me.Controls.Add(Me.CmdAbajo)
        Me.Controls.Add(Me.cmdArriba)
        Me.Controls.Add(Me.dgNiveles)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Name = "frmNuevoGrupoBalance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgNiveles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmNuevoGrupoBalance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim grupos As New VB.SysContab.GruposDB
        Me.Text = "Editar Grupo de Balance"

        If Nuevo = "NO" Then
            txtCodigo.ReadOnly = True
            Detalles = grupos.GetDetails(Registro, TipoGrupo)
            Me.txtCodigo.Text = Detalles.Codigo
            Me.txtNombre.Text = Detalles.Nombre
            Me.txtNivel.Text = Detalles.Nivel

            Dim g As New VB.SysContab.GruposDB
            Dim longitud As Integer
            Dim i As Integer

            longitud = Registro.Length
            Me.Cargar(Detalles)
            'If longitud = 1 Then
            '    Exit Sub
            'Else
            '    lbGruposSup.Items.Clear()
            '    For i = 0 To longitud - 2
            '        If g.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), TipoGrupo).Tables("Grupos").Rows.Count <> 0 Then
            '            lbGruposSup.Items.Add(g.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), TipoGrupo).Tables("Grupos").Rows(0).Item("Codigo_Grupo") & " - " & g.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), TipoGrupo).Tables("Grupos").Rows(0).Item("Nombre"))

            '        End If

            '    Next

            '    If lbGruposSup.Items.Count <> 0 Then
            '        etGruposSup.Visible = True
            '        lbGruposSup.Visible = True

            '    End If

            'End If
        Else
            Me.Text = "Agregar Grupo de Balance"
        End If
        txtCodigo.Focus()
        txtCodigo.SelectAll()
    End Sub

    Public Sub Cargar(ByVal Det As VB.SysContab.GruposDetails)

        Detalle = ObtieneDatos("Select max(Nivel) from grupos where empresa = " & EmpresaActual & " and tipo = 'B'").Rows(0)(0)
        If Det.Nivel = 1 Then
            Me.dgNiveles.DataSource = ObtieneDatos("Select Codigo_grupo as Codigo, Nombre as Nombre, Nivel, Orden, Detalle from grupos where empresa = " & EmpresaActual & " and nivel <> 0 and tipo = 'B' and nivel <= " & Det.Nivel)
        Else
            Me.dgNiveles.DataSource = ObtieneDatos("Select Codigo_grupo as Codigo, Nombre as Nombre, Nivel, Orden, Detalle from grupos where codigo_grupo like '" & IIf(Me.txtCodigo.Text = "", "-", Me.txtCodigo.Text.Substring(0, IIf(Me.txtCodigo.Text.Length >= Det.Nivel, Det.Nivel - 1, Me.txtCodigo.Text.Length - 1))) & "' + '%' and empresa = " & EmpresaActual & " and nivel <> 0 and tipo = 'B' and nivel <= " & Det.Nivel)
        End If

        'Me.Vista.Columns("Orden").Visible = False
        Me.Vista.Columns("Nivel").Visible = False

    End Sub
    Private Sub cmdArriba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdArriba.Click
        If Me.Vista.GetFocusedRowCellValue("Nivel") < Detalles.Nivel Then
            Exit Sub
        End If
        If Me.Vista.FocusedRowHandle = 0 Then
            Exit Sub
        End If
        Dim O1, O2 As Integer
        O1 = Me.Vista.GetRowCellValue(Me.Vista.FocusedRowHandle - 1, "Orden")
        O2 = Me.Vista.GetRowCellValue(Me.Vista.FocusedRowHandle, "Orden")
        Me.Vista.SetRowCellValue(Me.Vista.FocusedRowHandle - 1, "Orden", O2)
        Me.Vista.SetRowCellValue(Me.Vista.FocusedRowHandle, "Orden", O1)
        'Me.Vista.RefreshData()
        Me.Vista.Columns("Orden").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending

    End Sub

    Private Sub CmdAbajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAbajo.Click
        If Me.Vista.GetFocusedRowCellValue("Nivel") < Detalles.Nivel Then
            Exit Sub
        End If
        If Me.Vista.FocusedRowHandle = Me.Vista.DataRowCount - 1 Then
            Exit Sub
        End If
        Dim O1, O2 As Integer

        O1 = Me.Vista.GetRowCellValue(Me.Vista.FocusedRowHandle, "Orden")
        O2 = Me.Vista.GetRowCellValue(Me.Vista.FocusedRowHandle + 1, "Orden")

        Me.Vista.SetRowCellValue(Me.Vista.FocusedRowHandle + 1, "Orden", O1)
        Me.Vista.SetRowCellValue(Me.Vista.FocusedRowHandle, "Orden", O2)
        'Me.Vista.RefreshData()
        Me.Vista.Columns("Orden").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        Dim grupos As New VB.SysContab.GruposDB
        Dim r As New VB.SysContab.Rutinas

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

        If Trim(txtNivel.Text) = "" Then
            MsgBox("Introduzca el Nivel del Grupo", MsgBoxStyle.Information)
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
            grupos.AddItem(txtCodigo.Text, txtNombre.Text, txtNivel.Text, "", "B")
            Detalle = ObtieneDatos("SELECT ISNULL(MAX(Orden),0) + 1  FROM grupos WHERE Empresa = " & EmpresaActual & " AND Tipo = 'B' AND Nivel =" & txtNivel.Text).Rows(0)(0) '" & Detalles.Nivel).Rows(0)(0)
            grupos.Update_Orden(Me.txtCodigo.Text, "B", Detalle, True)
            r.LimpiarControles(GroupBox1)
            txtCodigo.Focus()
        Else
            grupos.Update(txtCodigo.Text, txtNombre.Text, txtNivel.Text, "", "B")
        End If

        If Nuevo = "NO" Then
            'Actualizar los ordenes
            Dim i As Integer = 0
            For i = 0 To Me.Vista.DataRowCount - 1
                'If Detalle = Me.Vista.GetRowCellValue(i, "Nivel") Then
                grupos.Update_Orden(Me.Vista.GetRowCellValue(i, "Codigo"), "B", Me.Vista.GetRowCellValue(i, "Orden"), Me.Vista.GetRowCellValue(i, "Detalle"))
                'End If

            Next
        Else
            'Detalle = ObtieneDatos("SELECT ISNULL(MAX(Orden),0) + 1  FROM grupos WHERE Empresa = " & EmpresaActual & " AND Tipo = 'B' AND Nivel =" & txtNivel.Text).Rows(0)(0) '" & Detalles.Nivel).Rows(0)(0)
            'grupos.Update_Orden(Me.txtCodigo.Text, "B", Detalle, True)
        End If
        Me.txtNombre.Focus()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmNuevoGrupoBalance_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim grupo As frmGrupos = grupo.Instance
        grupo.cargar()
    End Sub

    Private Sub txtCodigo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.Leave
        'Dim g As New VB.SysContab.GruposDB
        'Dim longitud As Integer
        'Dim i As Integer

        'If Nuevo = "NO" Then
        '    Exit Sub
        'End If

        'If Trim(txtCodigo.Text) <> "" Then
        '    longitud = txtCodigo.Text.Length
        '    g.GetListCodigo(txtCodigo.Text, TipoGrupo)

        '    If longitud = 1 Then
        '        If g.GetListCodigo(txtCodigo.Text, TipoGrupo).Tables("Grupos").Rows.Count <> 0 Then
        '            MsgBox("Código de Grupo ya existe", MsgBoxStyle.Information)
        '            txtCodigo.Focus()
        '            Exit Sub

        '        End If
        '    Else
        '        If g.GetListCodigo(txtCodigo.Text, TipoGrupo).Tables("Grupos").Rows.Count <> 0 Then
        '            MsgBox("Código de Grupo ya existe", MsgBoxStyle.Information)
        '            txtCodigo.Focus()
        '            Exit Sub

        '        End If

        '        lbGruposSup.Items.Clear()
        '        For i = 0 To longitud - 2
        '            If g.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), TipoGrupo).Tables("Grupos").Rows.Count <> 0 Then
        '                lbGruposSup.Items.Add(g.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), TipoGrupo).Tables("Grupos").Rows(0).Item("Codigo_Grupo") & " - " & g.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), TipoGrupo).Tables("Grupos").Rows(0).Item("Nombre"))

        '            End If

        '        Next

        '        If lbGruposSup.Items.Count <> 0 Then
        '            etGruposSup.Visible = True
        '            lbGruposSup.Visible = True

        '        End If

        '    End If

        'End If

    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged
        'lbGruposSup.Items.Clear()
        'lbGruposSup.Visible = False
        'etGruposSup.Visible = False

        'Dim codigo As New Regex("\d{1}", RegexOptions.IgnoreCase)

        'If Not codigo.IsMatch(txtCodigo.Text) Then
        '    txtCodigo.ResetText()

        'End If

    End Sub

    'Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
    '    If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
    '        If Char.IsDigit(e.KeyChar) = False Then
    '            e.Handled = True
    '            Exit Sub

    '        End If
    '    End If

    'End Sub


End Class