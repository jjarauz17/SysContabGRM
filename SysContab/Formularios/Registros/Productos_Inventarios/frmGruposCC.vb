Public Class frmGruposCC
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmGruposCC = Nothing

    Public Shared Function Instance() As frmGruposCC
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmGruposCC()
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgGruposInventario As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.dgGruposInventario = New System.Windows.Forms.DataGrid
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgGruposInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(24, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 26)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(104, 17)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(384, 20)
        Me.txtBuscar.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdAyuda)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdImprimir)
        Me.GroupBox1.Controls.Add(Me.cmdBorrar)
        Me.GroupBox1.Controls.Add(Me.cmdModificar)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 455)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 60)
        Me.GroupBox1.TabIndex = 6
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
        'dgGruposInventario
        '
        Me.dgGruposInventario.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgGruposInventario.BackColor = System.Drawing.Color.Gainsboro
        Me.dgGruposInventario.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgGruposInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgGruposInventario.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgGruposInventario.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgGruposInventario.CaptionForeColor = System.Drawing.Color.Black
        Me.dgGruposInventario.DataMember = ""
        Me.dgGruposInventario.FlatMode = True
        Me.dgGruposInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgGruposInventario.ForeColor = System.Drawing.Color.Black
        Me.dgGruposInventario.GridLineColor = System.Drawing.Color.Silver
        Me.dgGruposInventario.HeaderBackColor = System.Drawing.Color.Black
        Me.dgGruposInventario.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgGruposInventario.HeaderForeColor = System.Drawing.Color.White
        Me.dgGruposInventario.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgGruposInventario.Location = New System.Drawing.Point(24, 52)
        Me.dgGruposInventario.Name = "dgGruposInventario"
        Me.dgGruposInventario.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgGruposInventario.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgGruposInventario.ReadOnly = True
        Me.dgGruposInventario.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgGruposInventario.SelectionForeColor = System.Drawing.Color.White
        Me.dgGruposInventario.Size = New System.Drawing.Size(976, 403)
        Me.dgGruposInventario.TabIndex = 5
        '
        'frmGruposCC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 526)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgGruposInventario)
        Me.Name = "frmGruposCC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgGruposInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim r As New VB.SysContab.Rutinas()
    Public GruposCC As New VB.SysContab.GruposCCDB()
    Public Tabla As New DataTable()
    Public ds As New DataSet()

    Private Sub frmGruposCC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(GroupBox1)
        ''r.FormularioColor(Me)

        ds = GruposCC.List()

        dgGruposInventario.DataSource = ds.Tables("GruposCC").DefaultView
        Tabla = ds.Tables("GruposCC")

        r.FormatGenerico(dgGruposInventario, Tabla)

        dgGruposInventario.CaptionText = ""

        Me.Text = ""

        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)

        Me.Refresh()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As frmAgregarGrupoCC = f.Instance
        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        Dim f As frmGrupoCCEditar = f.Instance
        f.MdiParent = Me.MdiParent
        f.txtCodigo.Text = dgGruposInventario.Item(dgGruposInventario.CurrentRowIndex, 0)
        f.Show()
    End Sub

    Private Sub dgGruposInventario_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgGruposInventario.CurrentCellChanged
        Registro = dgGruposInventario.Item(dgGruposInventario.CurrentRowIndex, 0)
    End Sub

    'Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
    '    Exit Sub
    '    Dim gruposInv As New VB.SysContab.Grupos_InventarioDB()

    '    dgGruposInventario.DataSource = gruposInv.GetListBuscar(txtBuscar.Text, TipoGrupoInv).Tables("GRUPOS_INVENTARIO").DefaultView


    '    If gruposInv.GetListBuscar(txtBuscar.Text, TipoGrupoInv).Tables("Grupos_Inventario").Rows.Count = 0 Then
    '        Registro = "Vacio"
    '        Exit Sub

    '    End If

    '    Registro = dgGruposInventario.Item(dgGruposInventario.CurrentRowIndex, 0)

    'End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        Dim resp As DialogResult
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim longitud As Integer
        Dim i As Integer
        Dim j As Integer
        Dim Codigo As String
        Dim Nivel As Integer
        Dim Temp As Boolean = False

        Codigo = dgGruposInventario.Item(dgGruposInventario.CurrentRowIndex, 0)

        Nivel = ObtieneDatos("SELECT Grupo_Nivel FROM GruposCC WHERE Empresa_ID = " & EmpresaActual & " AND Grupo_Id = '" & Codigo & "'").Rows(0).Item(0)
        Select Case Nivel
            Case 1 : Temp = IIf(ObtieneDatos("SELECT ISNULL(COUNT(*),0) FROM ArticulosCC WHERE Empresa_ID = " & EmpresaActual & " AND Linea_Id = '" & Codigo & "'").Rows(0).Item(0) > 0, True, False)
            Case 2 : Temp = IIf(ObtieneDatos("SELECT ISNULL(COUNT(*),0) FROM ArticulosCC WHERE Empresa_ID = " & EmpresaActual & " AND Grupo_Id = '" & Codigo & "'").Rows(0).Item(0) > 0, True, False)
            Case 3 : Temp = IIf(ObtieneDatos("SELECT ISNULL(COUNT(*),0) FROM ArticulosCC WHERE Empresa_ID = " & EmpresaActual & " AND SubGrupo_Id = '" & Codigo & "'").Rows(0).Item(0) > 0, True, False)
        End Select

        If (ObtieneDatos("SELECT ISNULL(COUNT(*),0) FROM GruposCC WHERE Empresa_ID = " & EmpresaActual & " AND Grupo_Id Like '" & Codigo & "%'").Rows(0).Item(0) > 1) Or Temp Then
            MsgBox("No puede borrar el registro...", MsgBoxStyle.Information)
            Exit Sub
        End If

        'j = 0
        'longitud = Codigo.Length

        ''lbGruposSup.Items.Clear()
        'For i = 0 To longitud - 2
        'If GruposCC.GetListCodigo(Codigo.Substring(0, i + 1)).Tables("GruposCC").Rows.Count <> 0 Then
        '        j = j + 1
        '        'Exit For
        '        'lbGruposSup.Items.Add(GruposCC.GetListCodigo(txtCodigo.Text.Substring(0, i + 1)).Tables("GruposCC").Rows(0).Item("Código") & " - " & GruposCC.GetListCodigo(txtCodigo.Text.Substring(0, i + 1)).Tables("GruposCC").Rows(0).Item("Nombre"))
        '    End If
        'Next

        'If j <= 1 Then
        '    MsgBox("No puede borrar el registro...", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'If Trim(dgGruposInventario.Item(dgGruposInventario.CurrentRowIndex, 0)) <> "" Then
        '    longitud = dgGruposInventario.Item(dgGruposInventario.CurrentRowIndex, 0).ToString.Length
        '    GruposCC.GetListCodigo(dgGruposInventario.Item(dgGruposInventario.CurrentRowIndex, 0))

        '    If longitud = 1 Then
        '        If GruposCC.GetListCodigo(dgGruposInventario.Item(dgGruposInventario.CurrentRowIndex, 0)).Tables("GruposCC").Rows.Count <> 0 Then
        '            MsgBox("Código de Grupo ya existe", MsgBoxStyle.Information)
        '            Exit Sub
        '        End If
        '    Else
        '        If GruposCC.GetListCodigo(dgGruposInventario.Item(dgGruposInventario.CurrentRowIndex, 0)).Tables("GruposCC").Rows.Count <> 0 Then
        '            MsgBox("Código de Grupo ya existe", MsgBoxStyle.Information)
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
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''




        If ds.Tables("GruposCC").Rows.Count = 0 Then
            MsgBox("Seleccione el Grupo que desea Borrar", MsgBoxStyle.Information)
            Exit Sub
        End If

        resp = MsgBox("Esta seguro que dese borrar el Grupo: " & dgGruposInventario.Item(dgGruposInventario.CurrentRowIndex, 0) & " - " & dgGruposInventario.Item(dgGruposInventario.CurrentRowIndex, 1), MsgBoxStyle.YesNo + MsgBoxStyle.Question)

        If resp = DialogResult.No Then
            Exit Sub
        End If

        GruposCC.Delete(dgGruposInventario.Item(dgGruposInventario.CurrentRowIndex, 0))

        ds = GruposCC.List()
        dgGruposInventario.DataSource = ds.Tables("GruposCC").DefaultView
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmGruposInventarios_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        '
    End Sub

    Private Sub txtBuscar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.MouseEnter
        '
    End Sub

    Private Sub dgGruposInventario_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgGruposInventario.MouseEnter
        '
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click

    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/RegISInventario.chm")
    End Sub
End Class
