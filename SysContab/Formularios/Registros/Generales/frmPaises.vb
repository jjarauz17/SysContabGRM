Imports System
Imports System.IO

Public Class frmPaises
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmPaises = Nothing

    Public Shared Function Instance() As frmPaises
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmPaises
        End If
        ChildInstance.BringToFront()

        Return ChildInstance

    End Function
    Dim r As New VB.SysContab.Rutinas
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
    Friend WithEvents dgPaises As System.Windows.Forms.DataGrid
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
        Me.dgPaises = New System.Windows.Forms.DataGrid
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgPaises, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 26)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Buscar:"
        Me.Label1.Visible = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(96, 17)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(315, 20)
        Me.txtBuscar.TabIndex = 9
        Me.txtBuscar.Visible = False
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 180)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(399, 51)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.Location = New System.Drawing.Point(242, 17)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 26)
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(320, 17)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 26)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(398, 17)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 26)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "Imprimir"
        Me.cmdImprimir.Visible = False
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.Location = New System.Drawing.Point(164, 17)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 26)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "Borrar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.Location = New System.Drawing.Point(86, 17)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(72, 26)
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "Editar"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.Location = New System.Drawing.Point(8, 17)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(72, 26)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "Nuevo"
        '
        'dgPaises
        '
        Me.dgPaises.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPaises.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgPaises.DataMember = ""
        Me.dgPaises.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgPaises.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgPaises.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgPaises.Location = New System.Drawing.Point(8, 43)
        Me.dgPaises.Name = "dgPaises"
        Me.dgPaises.ReadOnly = True
        Me.dgPaises.Size = New System.Drawing.Size(403, 131)
        Me.dgPaises.TabIndex = 7
        '
        'frmPaises
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(419, 241)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgPaises)
        Me.Name = "frmPaises"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgPaises, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmPaises_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As New DataTable

        ''VB.SysContab.RutinasNomina.CambiarEstilo(Me)
        RolesDB.UsuarioAcciones(GroupBox1)

        ds = VB.SysContab.PaisesDB.GetList(True)

        dgPaises.DataSource = ds.DefaultView

        r.FormatGenerico(dgPaises, ds)

        If ds.Rows.Count <> 0 Then
            Registro = dgPaises.Item(0, 0)
        Else
            Registro = "Vacio"
        End If

        dgPaises.CaptionText = "Información de Paises"

        Me.Text = "Mantenimiento de Paises"
        ''VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        Me.Refresh()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim z As frmAgregarPais = frmAgregarPais.Instance
        Nuevo = "SI"
        z.MdiParent = Me.MdiParent
        z.Show()

    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        'Dim Departamentos As New VB.SysContab.DepartamentosDB
        'dgDepartamentos.DataSource = Departamentos.GetListBuscar(txtBuscar.Text).Tables("Departamentos").DefaultView

        'If Departamentos.GetListBuscar(txtBuscar.Text).Tables("Departamentos").Rows.Count = 0 Then
        '    Exit Sub

        'End If

        'Registro = dgDepartamentos.Item(dgDepartamentos.CurrentRowIndex, 0)
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        Dim f As frmAgregarPais = frmAgregarPais.Instance

        Nuevo = "NO"
        If Registro = "Vacio" Then
            MsgBox("Seleccione el País que desea Editar", MsgBoxStyle.Information)
            Exit Sub
        End If

        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub

    Private Sub dgDepartamentos_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgPaises.CurrentCellChanged
        Registro = dgPaises.Item(dgPaises.CurrentRowIndex, 0)

    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        Dim resp As DialogResult

        If Registro = "Vacio" Then
            MsgBox("Seleccione el País que desea Borrar", MsgBoxStyle.Information)
            Exit Sub
        End If

        resp = MsgBox("Esta seguro que dese borrar el Pais: " & dgPaises.Item(dgPaises.CurrentRowIndex, 0) & " - " & dgPaises.Item(dgPaises.CurrentRowIndex, 1), MsgBoxStyle.YesNo + MsgBoxStyle.Question)

        If resp = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Try
            VB.SysContab.PaisesDB.Delete(dgPaises.Item(dgPaises.CurrentRowIndex, 0))
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub

        End Try

        MsgBox("El registro ha sido borrado", MsgBoxStyle.Information)

        Dim ds As New DataTable

        VB.SysContab.RutinasNomina.CambiarEstilo(Me)

        ds = VB.SysContab.PaisesDB.GetList(True)

        dgPaises.DataSource = ds.DefaultView

        If ds.Rows.Count = 0 Then
            Registro = "Vacio"
        Else
            Registro = dgPaises.Item(0, 0)

        End If

        r.FormatGenerico(dgPaises, ds)

    End Sub


    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True

        End If

    End Sub

    Private Sub frmDepartamentos_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Opened = "NO"
        ''
        'FormPrincipal.IsMdiContainer = False
        'FormPrincipal.Text = NombreEmpresaActual
        'FormPrincipal.Refresh()

    End Sub

    Private Sub frmDepartamentos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        'Menu Herramientas
        'FormPrincipal.menuHerramientas.Visible = False
    End Sub

    Private Sub txtBuscar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.MouseEnter
        'Menu Herramientas
        ' FormPrincipal.menuHerramientas.Visible = False
    End Sub

    Private Sub dgDepartamentos_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgPaises.MouseEnter
        'Menu Herramientas
        'FormPrincipal.menuHerramientas.Visible = False
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        
    End Sub
End Class
