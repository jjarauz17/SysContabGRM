
Public Class frmAgregarAreaConsumo
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAgregarAreaConsumo = Nothing

    Public Shared Function Instance() As frmAgregarAreaConsumo
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarAreaConsumo()
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
    Friend WithEvents etNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents cbResponsable As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents cbDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents cbCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents etInicio As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtFax = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbCuenta = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbDepartamento = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDireccion = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbTipo = New System.Windows.Forms.ComboBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.cbResponsable = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.etGruposSup = New System.Windows.Forms.Label
        Me.lbGruposSup = New System.Windows.Forms.ListBox
        Me.etCodigo = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.etNombre = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.etInicio = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtFax)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbCuenta)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbDepartamento)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbTipo)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.cbResponsable)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.etGruposSup)
        Me.GroupBox1.Controls.Add(Me.lbGruposSup)
        Me.GroupBox1.Controls.Add(Me.etCodigo)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.etNombre)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(808, 497)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(368, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 26)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Fax:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtFax
        '
        Me.txtFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFax.Location = New System.Drawing.Point(456, 103)
        Me.txtFax.MaxLength = 20
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(344, 20)
        Me.txtFax.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(320, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 26)
        Me.Label6.TabIndex = 95
        Me.Label6.Text = "Cuenta Contable:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbCuenta
        '
        Me.cbCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCuenta.ItemHeight = 15
        Me.cbCuenta.Location = New System.Drawing.Point(456, 224)
        Me.cbCuenta.Name = "cbCuenta"
        Me.cbCuenta.Size = New System.Drawing.Size(344, 23)
        Me.cbCuenta.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(336, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 25)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Departamento:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbDepartamento
        '
        Me.cbDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDepartamento.ItemHeight = 15
        Me.cbDepartamento.Location = New System.Drawing.Point(456, 190)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(344, 23)
        Me.cbDepartamento.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(16, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 25)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "e-mail:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(96, 190)
        Me.txtEmail.MaxLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(232, 20)
        Me.txtEmail.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 26)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Dirección:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtDireccion
        '
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(96, 138)
        Me.txtDireccion.MaxLength = 150
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDireccion.Size = New System.Drawing.Size(704, 43)
        Me.txtDireccion.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 26)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Tipo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbTipo
        '
        Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipo.ItemHeight = 15
        Me.cbTipo.Items.AddRange(New Object() {"", "Administrativa", "Operativa", "Apoyo", "Dirección"})
        Me.cbTipo.Location = New System.Drawing.Point(96, 69)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(240, 23)
        Me.cbTipo.TabIndex = 2
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(352, 69)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(96, 26)
        Me.Label25.TabIndex = 85
        Me.Label25.Text = "Responsable:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbResponsable
        '
        Me.cbResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbResponsable.ItemHeight = 15
        Me.cbResponsable.Location = New System.Drawing.Point(456, 69)
        Me.cbResponsable.Name = "cbResponsable"
        Me.cbResponsable.Size = New System.Drawing.Size(344, 23)
        Me.cbResponsable.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 26)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Teléfono:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(96, 103)
        Me.txtTelefono.MaxLength = 20
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(240, 20)
        Me.txtTelefono.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(2, 250)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(804, 8)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'etGruposSup
        '
        Me.etGruposSup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etGruposSup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etGruposSup.Location = New System.Drawing.Point(16, 267)
        Me.etGruposSup.Name = "etGruposSup"
        Me.etGruposSup.Size = New System.Drawing.Size(176, 17)
        Me.etGruposSup.TabIndex = 12
        Me.etGruposSup.Text = "Areas Superiores:"
        Me.etGruposSup.Visible = False
        '
        'lbGruposSup
        '
        Me.lbGruposSup.BackColor = System.Drawing.SystemColors.Control
        Me.lbGruposSup.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbGruposSup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGruposSup.ItemHeight = 16
        Me.lbGruposSup.Location = New System.Drawing.Point(16, 293)
        Me.lbGruposSup.Name = "lbGruposSup"
        Me.lbGruposSup.Size = New System.Drawing.Size(776, 176)
        Me.lbGruposSup.TabIndex = 12
        '
        'etCodigo
        '
        Me.etCodigo.BackColor = System.Drawing.Color.Transparent
        Me.etCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etCodigo.Location = New System.Drawing.Point(16, 34)
        Me.etCodigo.Name = "etCodigo"
        Me.etCodigo.Size = New System.Drawing.Size(72, 26)
        Me.etCodigo.TabIndex = 8
        Me.etCodigo.Text = "Código:"
        Me.etCodigo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(96, 34)
        Me.txtCodigo.MaxLength = 50
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(152, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'etNombre
        '
        Me.etNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etNombre.Location = New System.Drawing.Point(376, 34)
        Me.etNombre.Name = "etNombre"
        Me.etNombre.Size = New System.Drawing.Size(72, 26)
        Me.etNombre.TabIndex = 2
        Me.etNombre.Text = "Nombre:"
        Me.etNombre.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(456, 34)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(344, 20)
        Me.txtNombre.TabIndex = 1
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(8, 52)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 26)
        Me.cmdCancelar.TabIndex = 11
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Location = New System.Drawing.Point(8, 17)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 26)
        Me.cmdAceptar.TabIndex = 10
        Me.cmdAceptar.Text = "Aceptar"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.etInicio)
        Me.GroupBox3.Controls.Add(Me.cmdAceptar)
        Me.GroupBox3.Controls.Add(Me.cmdCancelar)
        Me.GroupBox3.Location = New System.Drawing.Point(832, 17)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(88, 497)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        '
        'etInicio
        '
        Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etInicio.Location = New System.Drawing.Point(40, 396)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(32, 26)
        Me.etInicio.TabIndex = 159
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
        '
        'frmAgregarAreaConsumo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 526)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAgregarAreaConsumo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Nivel As Integer
    Dim GruposCC As New VB.SysContab.GruposCCDB()
    Dim r As New VB.SysContab.Rutinas()
    Dim Catalogo As New VB.SysContab.CatalogoDB()
    Dim D As New VB.SysContab.DepartamentosDB()
    Dim Empleados As New VB.SysContab.EmpleadosDB()

    Private Sub frmAgregarAreaConsumo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        r.FormularioColor(Me)
        'Me.cbTipo.DataSource = Catalogo.List().Tables("Catalogo")
        'Me.cbTipo.ValueMember = "Codigo"
        'Me.cbTipo.DisplayMember = "Nombre"
        'Me.cbTipo.SelectedValue = 0

        Me.cbResponsable.DataSource = Empleados.GetListReporte("", EmpresaActual).Tables("EMPLEADOS")
        Me.cbResponsable.ValueMember = "emp_codigo"
        Me.cbResponsable.DisplayMember = "nombre"
        Me.cbResponsable.SelectedValue = 0

        Me.cbDepartamento.DataSource = D.GetListReporte("", EmpresaActual).Tables("DEPARTAMENTOS")
        Me.cbDepartamento.ValueMember = "dep_codigo"
        Me.cbDepartamento.DisplayMember = "dep_NOMBRE"
        Me.cbDepartamento.SelectedValue = 0

        Me.cbCuenta.DataSource = Catalogo.List().Tables("Catalogo")
        Me.cbCuenta.ValueMember = "Codigo"
        Me.cbCuenta.DisplayMember = "Nombre"
        Me.cbCuenta.SelectedValue = 0

        'GroupBox1.Top = Me.Height / 12
        'GroupBox1.Left = Me.Height / 4
        Me.Text = "Agregar Grupo de Inventario"
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
        End If

        'If Nuevo = "SI" Then
        Try
            GruposCC.AreasAddItem(txtCodigo.Text, txtNombre.Text, Me.cbTipo.SelectedIndex, Me.cbResponsable.SelectedValue, Me.txtTelefono.Text, Me.txtFax.Text, Me.txtDireccion.Text, Me.txtEmail.Text, Me.cbDepartamento.SelectedValue, Me.cbCuenta.SelectedValue)
            r.LimpiarControles(GroupBox1)
            Me.cbTipo.SelectedValue = 0
            Me.cbResponsable.SelectedValue = 0
            Me.cbDepartamento.SelectedValue = 0
            Me.cbCuenta.SelectedValue = 0
            txtCodigo.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Else
        '    'gruposInv.Update(txtCodigo.Text, txtNombre.Text, "P")
        '    Me.Close()
        'End If
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
        Dim longitud As Integer
        Dim i As Integer

        If Trim(txtCodigo.Text) <> "" Then
            longitud = txtCodigo.Text.Length
            GruposCC.ACBuscarCodigo(txtCodigo.Text)

            If longitud = 1 Then
                If GruposCC.ACBuscarCodigo(txtCodigo.Text).Tables("GruposCC").Rows.Count <> 0 Then
                    MsgBox("Código de Grupo ya existe", MsgBoxStyle.Information)
                    txtCodigo.Focus()
                    Exit Sub
                End If
            Else
                If GruposCC.ACBuscarCodigo(txtCodigo.Text).Tables("GruposCC").Rows.Count <> 0 Then
                    MsgBox("Código de Grupo ya existe", MsgBoxStyle.Information)
                    txtCodigo.Focus()
                    Exit Sub
                End If

                lbGruposSup.Items.Clear()
                For i = 0 To longitud - 2
                    If GruposCC.ACBuscarCodigo(txtCodigo.Text.Substring(0, i + 1)).Tables("GruposCC").Rows.Count <> 0 Then
                        'lbGruposSup.Items.Add(GruposCC.NivelSuperior(txtCodigo.Text.Substring(0, i + 1)).Tables("GruposCC").Rows(0).Item("Código") & " - " & GruposCC.NivelSuperior(txtCodigo.Text.Substring(0, i + 1)).Tables("GruposCC").Rows(0).Item("Nombre"))
                        lbGruposSup.Items.Add(GruposCC.ACBuscarCodigo(txtCodigo.Text.Substring(0, i + 1)).Tables("GruposCC").Rows(0).Item("Código") & " - " & GruposCC.ACBuscarCodigo(txtCodigo.Text.Substring(0, i + 1)).Tables("GruposCC").Rows(0).Item("Nombre"))
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

    Private Sub frmAgregarAreaConsumo_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim f As frmAreasConsumo = f.Instance
        f.ds = GruposCC.AreasList()

        f.dgGruposInventario.DataSource = f.ds.Tables("GruposCC").DefaultView
        f.Tabla = f.ds.Tables("GruposCC")
    End Sub

End Class
