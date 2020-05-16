Public Class frmAgregarFormaPago
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAgregarFormaPago = Nothing

    Public Shared Function Instance() As frmAgregarFormaPago
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarFormaPago()
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDias As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDias = New System.Windows.Forms.TextBox()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label1, Me.txtDias, Me.cmdCancelar, Me.cmdAceptar, Me.Label2, Me.txtNombre})
        Me.GroupBox1.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 191)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Días:"
        '
        'txtDias
        '
        Me.txtDias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDias.Location = New System.Drawing.Point(96, 83)
        Me.txtDias.MaxLength = 3
        Me.txtDias.Name = "txtDias"
        Me.txtDias.Size = New System.Drawing.Size(72, 20)
        Me.txtDias.TabIndex = 1
        Me.txtDias.Text = ""
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Location = New System.Drawing.Point(240, 120)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 24)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Location = New System.Drawing.Point(120, 120)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 24)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "Aceptar"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(96, 40)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(344, 20)
        Me.txtNombre.TabIndex = 0
        Me.txtNombre.Text = ""
        '
        'frmAgregarFormaPago
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(584, 286)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox1})
        Me.Name = "frmAgregarFormaPago"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.WindowState = FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim FormaPago As New VB.SysContab.Forma_PagoDB()
        Dim r As New VB.SysContab.Rutinas()

        If Trim(txtNombre.Text) = "" Then
            MsgBox("Introduzca el Nombre de la Forma de Pago", MsgBoxStyle.Information)
            txtNombre.Focus()
            txtNombre.SelectAll()
            Exit Sub
        End If

        If Trim(txtDias.Text) = "" Then
            MsgBox("Introduzca el número de días", MsgBoxStyle.Information)
            txtDias.Focus()
            txtDias.SelectAll()
            Exit Sub
        End If

        If Nuevo = "SI" Then
            FormaPago.AddItem(txtNombre.Text, txtDias.Text)
            'MsgBox("El registro se ha grabado correctamente", MsgBoxStyle.Information)

            r.LimpiarControles(GroupBox1)

            txtNombre.Focus()

        Else
            FormaPago.Update(Registro, txtNombre.Text, txtDias.Text)
            'MsgBox("El registro se ha actualizado correctamente", MsgBoxStyle.Information)
            Me.Close()

        End If

    End Sub

    Private Sub frmAgregarFormaPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim FormaPago As New VB.SysContab.Forma_PagoDB()

        GroupBox1.Top = Me.Height / 4
        GroupBox1.Left = Me.Height / 4

        If Nuevo = "NO" Then
            Me.Text = "Editar Forma de Pago"
            Dim Detalles As VB.SysContab.Forma_PagoDetails = FormaPago.GetDetails(Registro)
            Me.txtNombre.Text = Detalles.Nombre
            Me.txtDias.Text = Detalles.Dias

        Else
            Me.Text = "Agregar Forma de Pago"

        End If

        Me.Refresh()

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()

    End Sub

    Private Sub frmAgregarFormaPago_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim r As New VB.SysContab.Rutinas()
        Dim FormaPago As New VB.SysContab.Forma_PagoDB()
        Dim f As frmFormaPago = f.Instance
        Dim Tabla As New DataTable()
        Dim dt As New DataTable()

        dt = FormaPago.GetList()
        f.dgFormaPago.DataSource = FormaPago.GetList().DefaultView
        Tabla = dt

        r.FormatGenerico(f.dgFormaPago, Tabla)

        If dt.Rows.Count <> 0 Then
            Registro = f.dgFormaPago.Item(0, 0)
        End If

    End Sub

    Private Sub txtDias_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDias.KeyPress
        If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
            If Char.IsDigit(e.KeyChar) = False Then
                e.Handled = True
                Exit Sub
            End If
        End If
    End Sub
End Class
