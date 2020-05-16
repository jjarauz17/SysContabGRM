Public Class frmAgregarBanco
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAgregarBanco = Nothing

    Public Shared Function Instance() As frmAgregarBanco
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarBanco()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance

    End Function

    Dim cuenta As String
    Dim Cod_Cuenta As String

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
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCiudad As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCuentas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbCatalogo As System.Windows.Forms.ComboBox
    Friend WithEvents cbActivo As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAbreviatura As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdCuentas = New DevExpress.XtraEditors.SimpleButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtAbreviatura = New System.Windows.Forms.TextBox
        Me.cbActivo = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbCatalogo = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtCorreo = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtFax = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCiudad = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDireccion = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Appearance.Options.UseForeColor = True
        Me.cmdCancelar.Location = New System.Drawing.Point(255, 25)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 34)
        Me.cmdCancelar.TabIndex = 11
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Appearance.Options.UseForeColor = True
        Me.cmdAceptar.Location = New System.Drawing.Point(63, 25)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 34)
        Me.cmdAceptar.TabIndex = 9
        Me.cmdAceptar.Text = "Aceptar"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cmdCuentas)
        Me.GroupBox1.Controls.Add(Me.cmdCancelar)
        Me.GroupBox1.Controls.Add(Me.cmdAceptar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(168, 321)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 77)
        Me.GroupBox1.TabIndex = 115
        Me.GroupBox1.TabStop = False
        '
        'cmdCuentas
        '
        Me.cmdCuentas.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCuentas.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdCuentas.Appearance.Options.UseFont = True
        Me.cmdCuentas.Appearance.Options.UseForeColor = True
        Me.cmdCuentas.Location = New System.Drawing.Point(151, 25)
        Me.cmdCuentas.Name = "cmdCuentas"
        Me.cmdCuentas.Size = New System.Drawing.Size(96, 34)
        Me.cmdCuentas.TabIndex = 10
        Me.cmdCuentas.Text = "Cuentas"
        Me.cmdCuentas.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(40, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 26)
        Me.Label2.TabIndex = 135
        Me.Label2.Text = "Siglas:"
        '
        'txtAbreviatura
        '
        Me.txtAbreviatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbreviatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbreviatura.Location = New System.Drawing.Point(168, 69)
        Me.txtAbreviatura.MaxLength = 50
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(144, 20)
        Me.txtAbreviatura.TabIndex = 1
        '
        'cbActivo
        '
        Me.cbActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbActivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbActivo.Location = New System.Drawing.Point(40, 310)
        Me.cbActivo.Name = "cbActivo"
        Me.cbActivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbActivo.Size = New System.Drawing.Size(80, 26)
        Me.cbActivo.TabIndex = 8
        Me.cbActivo.Text = "Activo"
        Me.cbActivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(40, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 26)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "Cuenta:"
        '
        'cbCatalogo
        '
        Me.cbCatalogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCatalogo.Location = New System.Drawing.Point(168, 103)
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.Size = New System.Drawing.Size(528, 23)
        Me.cbCatalogo.TabIndex = 2
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(40, 267)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(104, 26)
        Me.Label22.TabIndex = 80
        Me.Label22.Text = "E-Mail:"
        '
        'txtCorreo
        '
        Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(168, 267)
        Me.txtCorreo.MaxLength = 50
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(384, 20)
        Me.txtCorreo.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(328, 233)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 25)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "Fax:"
        '
        'txtFax
        '
        Me.txtFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFax.Location = New System.Drawing.Point(416, 233)
        Me.txtFax.MaxLength = 10
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(152, 20)
        Me.txtFax.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(40, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 25)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Teléfono:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(168, 233)
        Me.txtTelefono.MaxLength = 10
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(144, 20)
        Me.txtTelefono.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(40, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 26)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Ciudad:"
        '
        'txtCiudad
        '
        Me.txtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiudad.Location = New System.Drawing.Point(168, 198)
        Me.txtCiudad.MaxLength = 50
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(384, 20)
        Me.txtCiudad.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(40, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 26)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Dirección:"
        '
        'txtDireccion
        '
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(168, 146)
        Me.txtDireccion.MaxLength = 150
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDireccion.Size = New System.Drawing.Size(640, 44)
        Me.txtDireccion.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(40, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 26)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(168, 34)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(528, 20)
        Me.txtNombre.TabIndex = 0
        '
        'frmAgregarBanco
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(816, 421)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCiudad)
        Me.Controls.Add(Me.txtAbreviatura)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.cbActivo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbCatalogo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.txtFax)
        Me.Name = "frmAgregarBanco"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmAgregarBanco_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Catalogo As New VB.SysContab.CatalogoDB()
        Dim r As New VB.SysContab.Rutinas()
        Dim Bancos As New VB.SysContab.BancosDB()

        cbCatalogo.DataSource = Catalogo.GetListBuscarComboBanco("%", EmpresaActual).Tables("CATALOGO")
        cbCatalogo.ValueMember = "CUENTA"
        cbCatalogo.DisplayMember = "NOMBRE"

        'r.CambiarEstilo(Me)

        If Nuevo = "NO" Then
            Me.Text = "Editar Banco"

            Dim Detalles As VB.SysContab.BancosDetails = Bancos.GetDetails(Registro)
            'Me.txtCodigo.Text = Detalles.Codigo
            'Nombre = Detalles.Nombre
            Cod_Cuenta = Detalles.Cuenta
            Cod_CuentaP = Cod_Cuenta
            Me.cbCatalogo.SelectedValue = Detalles.Cuenta
            Me.txtNombre.Text = Detalles.Nombre
            Me.txtDireccion.Text = Detalles.Direccion
            Me.txtCiudad.Text = Detalles.Ciudad
            Me.txtTelefono.Text = Detalles.Telefono
            Me.txtFax.Text = Detalles.Fax
            Me.txtCorreo.Text = Detalles.Correo
            Me.cbActivo.Checked = Detalles.Activo
            Me.txtAbreviatura.Text = Detalles.Siglas

            If cbActivo.Checked = True Then
                cmdCuentas.Visible = True
            Else
                cmdCuentas.Visible = False
            End If
        Else
            Me.Text = "Agregar Banco"

            cmdCuentas.Visible = False
            'Nombre = ""

        End If

        r.ComboAutoComplete(Me.cbCatalogo)

        Me.Refresh()

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim r As New VB.SysContab.Rutinas()
        Dim Bancos As New VB.SysContab.BancosDB()
        Dim Activo As Integer

        If Trim(Me.txtNombre.Text = "") Then
            MsgBox("Introduzca el Nombre del Banco", MsgBoxStyle.Information)
            Me.txtNombre.Focus()
            Me.txtNombre.SelectAll()
            Exit Sub
        End If

        If Trim(Me.txtAbreviatura.Text = "") Then
            MsgBox("Introduzca las Siglas del Banco", MsgBoxStyle.Information)
            Me.txtAbreviatura.Focus()
            Me.txtAbreviatura.SelectAll()
            Exit Sub
        End If

        If Me.cbCatalogo.SelectedValue = Nothing Then
            MsgBox("Seleccione una Cuenta", MsgBoxStyle.Information)
            Me.cbCatalogo.Focus()
            Exit Sub
        End If

        'MsgBox(CInt(cbActivo))
        If cbActivo.Checked = True Then
            Activo = 1
        Else
            Activo = 0
        End If
        Try
            If Nuevo = "SI" Then
                Bancos.AddItem(Me.cbCatalogo.SelectedValue, txtNombre.Text, txtDireccion.Text, txtCiudad.Text, txtTelefono.Text, txtFax.Text, txtCorreo.Text, Activo, Me.txtAbreviatura.Text)
                If cbActivo.Checked = False Then
                    Exit Sub
                End If

                BancoP = Bancos.GetListCatalogo().Tables("BANCOS").Rows(0).Item("Codigo")

                Dim frmChildInstance As frmCatalogoBancos = frmCatalogoBancos.Instance
                frmChildInstance.MdiParent = Me.MdiParent
                frmChildInstance.Show()
                frmChildInstance.Refresh()

                frmChildInstance.cbCatalogo.EditValue = -1
                frmChildInstance.cbInstitucion.SelectedValue = -1
                frmChildInstance.cbMoneda.EditValue = -1
                frmChildInstance.cbTipoCuenta.SelectedValue = -1

            Else
                Bancos.Update(Me.cbCatalogo.SelectedValue, Registro, txtNombre.Text, txtDireccion.Text, txtCiudad.Text, txtTelefono.Text, txtFax.Text, txtCorreo.Text, Activo, Me.txtAbreviatura.Text)
                Me.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmAgregarBanco_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim b As frmBancos = frmBancos.Instance
        b.cargar()

    End Sub

    Private Sub cmdCuentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCuentas.Click
        Dim f As frmCatalogoBancos = frmCatalogoBancos.Instance
        BancoP = Registro
        f.cBanco = Registro
        f.MdiParent = Me.MdiParent
        f.Show()
        f.Refresh()

        'f.cbCatalogo.EditValue = -1
        'f.cbFormato.SelectedValue = -1
        'f.cbMoneda.EditValue = -1
        'f.cbTipoCuenta.SelectedValue = -1

    End Sub

    Private Sub cbCatalogo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCatalogo.Leave
        If Me.cbCatalogo.SelectedValue = Nothing Then
            MsgBox("Seleccione una cuenta", MsgBoxStyle.Information)
            Me.cbCatalogo.Focus()
            Exit Sub
        End If
    End Sub

End Class
