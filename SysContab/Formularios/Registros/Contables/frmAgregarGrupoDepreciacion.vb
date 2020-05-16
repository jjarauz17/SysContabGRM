Public Class frmAgregarGrupoDepreciacion
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAgregarGrupoDepreciacion = Nothing

    Public Shared Function Instance() As frmAgregarGrupoDepreciacion
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarGrupoDepreciacion()
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
    Friend WithEvents etCodigo As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPorcentaje As System.Windows.Forms.TextBox
    Friend WithEvents txtVidaUtil As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPorcentaje = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtVidaUtil = New System.Windows.Forms.TextBox()
        Me.etCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label4, Me.txtPorcentaje, Me.Label3, Me.Label1, Me.txtVidaUtil, Me.etCodigo, Me.txtCodigo, Me.cmdCancelar, Me.cmdAceptar, Me.Label2, Me.txtNombre})
        Me.GroupBox1.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(512, 240)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 24)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Porcentaje Anual:"
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPorcentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcentaje.Location = New System.Drawing.Point(152, 168)
        Me.txtPorcentaje.MaxLength = 5
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.Size = New System.Drawing.Size(68, 20)
        Me.txtPorcentaje.TabIndex = 14
        Me.txtPorcentaje.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(224, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 24)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Años."
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 24)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Vida Util:"
        '
        'txtVidaUtil
        '
        Me.txtVidaUtil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVidaUtil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVidaUtil.Location = New System.Drawing.Point(152, 120)
        Me.txtVidaUtil.MaxLength = 5
        Me.txtVidaUtil.Name = "txtVidaUtil"
        Me.txtVidaUtil.Size = New System.Drawing.Size(68, 20)
        Me.txtVidaUtil.TabIndex = 11
        Me.txtVidaUtil.Text = ""
        '
        'etCodigo
        '
        Me.etCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.etCodigo.Location = New System.Drawing.Point(16, 24)
        Me.etCodigo.Name = "etCodigo"
        Me.etCodigo.Size = New System.Drawing.Size(72, 24)
        Me.etCodigo.TabIndex = 10
        Me.etCodigo.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(152, 24)
        Me.txtCodigo.MaxLength = 3
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(112, 20)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.Text = ""
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Location = New System.Drawing.Point(240, 200)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 24)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Location = New System.Drawing.Point(120, 200)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 24)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "Aceptar"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Descripción:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(152, 72)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(344, 20)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.Text = ""
        '
        'frmAgregarGrupoDepreciacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(584, 302)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox1})
        Me.Name = "frmAgregarGrupoDepreciacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim Grupos_Depreciacion As New VB.SysContab.Grupos_DepreciacionDB()
        Dim r As New VB.SysContab.Rutinas()

        If Trim(txtCodigo.Text) = "" Then
            MsgBox("Introduzca el Código del Grupo de Depreciación", MsgBoxStyle.Information)
            txtCodigo.Focus()
            txtCodigo.SelectAll()
            Exit Sub

        End If

        If Trim(txtNombre.Text) = "" Then
            MsgBox("Introduzca la Descripción del Grupo de Depreciación", MsgBoxStyle.Information)
            txtNombre.Focus()
            txtNombre.SelectAll()
            Exit Sub

        End If

        If Nuevo = "SI" Then
            Try
                Grupos_Depreciacion.AddItem(txtCodigo.Text, txtNombre.Text, txtVidaUtil.Text, txtPorcentaje.Text)
            Catch ex As Exception
                MsgBox(ex.Message)
                txtCodigo.Focus()
                Exit Sub

            End Try

            'MsgBox("El registro se ha grabado correctamente", MsgBoxStyle.Information)
            r.LimpiarControles(GroupBox1)
            txtCodigo.Focus()

        Else
            Grupos_Depreciacion.Update(Registro, txtNombre.Text, txtVidaUtil.Text, txtPorcentaje.Text)
            'MsgBox("El registro se ha actualizado correctamente", MsgBoxStyle.Information)
            Me.Close()

        End If

    End Sub

    Private Sub frmAgregarGrupos_Depreciacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Grupos_Depreciacion As New VB.SysContab.Grupos_DepreciacionDB()

        GroupBox1.Top = Me.Height / 4
        GroupBox1.Left = Me.Height / 4

        If Nuevo = "NO" Then
            Me.Text = "Editar Grupo de Depreciación"
            txtCodigo.ReadOnly = True
            Dim Detalles As VB.SysContab.Grupos_DepreciacionDetails = Grupos_Depreciacion.GetDetails(Registro)
            Me.txtCodigo.Text = Detalles.Codigo
            Me.txtNombre.Text = Detalles.Descripcion
            Me.txtVidaUtil.Text = Detalles.Vida_Util
            Me.txtPorcentaje.Text = Detalles.Porcentaje

            Me.txtNombre.Focus()

        Else
            Me.Text = "Agregar Grupo de Depreciación"

        End If

        Me.Refresh()

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmAgregarGrupos_Depreciacion_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim r As New VB.SysContab.Rutinas()
        Dim Grupos_Depreciacions As New VB.SysContab.Grupos_DepreciacionDB()
        Dim d As frmGruposDepreciacion = d.Instance
        Dim Tabla As New DataTable()
        Dim ds As New DataSet()

        ds = Grupos_Depreciacions.GetList()
        d.dgGrupos_Depreciacion.DataSource = Grupos_Depreciacions.GetList().Tables("Grupos_Depreciacion").DefaultView
        Tabla = ds.Tables("Grupos_Depreciacion")

        r.FormatGenerico(d.dgGrupos_Depreciacion, Tabla)

        If ds.Tables("Grupos_Depreciacion").Rows.Count <> 0 Then
            Registro = d.dgGrupos_Depreciacion.Item(0, 0)
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
