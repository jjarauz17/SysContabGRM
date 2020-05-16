Public Class frmAgregarEmisor
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAgregarEmisor = Nothing

    Public Shared Function Instance() As frmAgregarEmisor
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarEmisor()
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
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents etNombre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbCatalogo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.etNombre = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.cbCatalogo = New DevExpress.XtraEditors.LookUpEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.cbCatalogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbCatalogo)
        Me.GroupBox1.Controls.Add(Me.cmdCancelar)
        Me.GroupBox1.Controls.Add(Me.cmdAceptar)
        Me.GroupBox1.Controls.Add(Me.etNombre)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 207)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(97, 151)
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
        Me.cmdAceptar.Location = New System.Drawing.Point(19, 151)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 26)
        Me.cmdAceptar.TabIndex = 3
        Me.cmdAceptar.Text = "Aceptar"
        '
        'etNombre
        '
        Me.etNombre.AutoSize = True
        Me.etNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etNombre.Location = New System.Drawing.Point(16, 54)
        Me.etNombre.Name = "etNombre"
        Me.etNombre.Size = New System.Drawing.Size(67, 16)
        Me.etNombre.TabIndex = 2
        Me.etNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(97, 49)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(360, 21)
        Me.txtNombre.TabIndex = 1
        '
        'cbCatalogo
        '
        Me.cbCatalogo.Location = New System.Drawing.Point(97, 86)
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo.Size = New System.Drawing.Size(359, 20)
        Me.cbCatalogo.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(23, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cuenta:"
        '
        'frmAgregarEmisor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(521, 249)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAgregarEmisor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cbCatalogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim r As New VB.SysContab.Rutinas()
    Dim Emisores As New VB.SysContab.EmisoresDB()
    Public Codigo As Integer
    Dim dt As DataTable

    Private Sub frmAgregarEmisor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'r.FormularioColor(Me)
        Me.cbCatalogo.Properties.DataSource = ObtieneDatos("_GetCatalogo_Cuenta " & EmpresaActual)
        Me.cbCatalogo.Properties.DisplayMember = "Display"
        Me.cbCatalogo.Properties.ValueMember = "Cuenta"
        Me.cbCatalogo.Properties.PopulateColumns()
        Me.cbCatalogo.Properties.Columns("Display").Visible = False

        txtNombre.Focus()
        If Nuevo = "NO" Then
            dt = ObtieneDatos("SELECT * FROM Emisores e WHERE e.Emisor_ID = " & Codigo & " AND e.Empresa_ID = " & EmpresaActual)

            Me.txtNombre.Text = dt.Rows.Item(0)(2)
            Me.cbCatalogo.EditValue = dt.Rows.Item(0)(3)
        End If
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Trim(txtNombre.Text) = "" Then
            MsgBox("Introduzca el nombre del Emisor", MsgBoxStyle.Exclamation)
            txtNombre.Focus()
            txtNombre.SelectAll()
            Exit Sub
        End If

        If Me.cbCatalogo.EditValue Is Nothing Then
            MsgBox("Introduzca La Cuenta Contable", MsgBoxStyle.Exclamation)
            Me.cbCatalogo.Focus()
            Exit Sub
        End If

        Try
            If Nuevo = "SI" Then
                Emisores.AddItem(txtNombre.Text, Me.cbCatalogo.EditValue)
            Else
                GuardaDatos("UPDATE Emisores SET Emisor_Nombre = '" & Me.txtNombre.Text & "',Cuenta = '" & Me.cbCatalogo.EditValue & "'" _
                            + " WHERE Emisor_ID = " & Codigo & " And Empresa_ID = " & EmpresaActual)
            End If

            'MsgBox("El registro se ha grabado correctamente", MsgBoxStyle.Information)
            'r.LimpiarControles(GroupBox1)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmAgregarEmisor_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim f As frmEmisores = f.Instance
        Dim ds As New DataSet()
        ds = Emisores.List
        f.gridDatos.DataSource = ds.Tables("Emisores").DefaultView
    End Sub

End Class
