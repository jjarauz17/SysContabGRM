Imports DevExpress.XtraEditors

Public Class frmAgregarDeposito
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAgregarDeposito = Nothing

    Public Shared Function Instance() As frmAgregarDeposito
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarDeposito()
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbBancos As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents txtDocumento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cbCuenta = New System.Windows.Forms.ComboBox
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbBancos = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDocumento = New DevExpress.XtraEditors.TextEdit
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        CType(Me.txtDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbCuenta
        '
        Me.cbCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCuenta.Location = New System.Drawing.Point(151, 135)
        Me.cbCuenta.Name = "cbCuenta"
        Me.cbCuenta.Size = New System.Drawing.Size(176, 23)
        Me.cbCuenta.TabIndex = 3
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(151, 52)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(128, 20)
        Me.dtpFecha.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(88, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 144
        Me.Label2.Text = "Fecha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(86, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "Banco:"
        '
        'cbBancos
        '
        Me.cbBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBancos.Location = New System.Drawing.Point(151, 106)
        Me.cbBancos.Name = "cbBancos"
        Me.cbBancos.Size = New System.Drawing.Size(652, 23)
        Me.cbBancos.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(55, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 16)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "No. Cuenta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(24, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "No. de Deposito:"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.SystemColors.Info
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.DarkRed
        Me.txtCodigo.Location = New System.Drawing.Point(151, 23)
        Me.txtCodigo.MaxLength = 50
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(176, 23)
        Me.txtCodigo.TabIndex = 0
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Appearance.Options.UseForeColor = True
        Me.cmdCancelar.Location = New System.Drawing.Point(91, 12)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 26)
        Me.cmdCancelar.TabIndex = 1
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Appearance.Options.UseForeColor = True
        Me.cmdAceptar.Location = New System.Drawing.Point(13, 12)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 26)
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Text = "Aceptar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(52, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 16)
        Me.Label5.TabIndex = 144
        Me.Label5.Text = "Documento:"
        '
        'txtDocumento
        '
        Me.txtDocumento.Location = New System.Drawing.Point(151, 78)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumento.Properties.Appearance.Options.UseFont = True
        Me.txtDocumento.Size = New System.Drawing.Size(176, 22)
        Me.txtDocumento.TabIndex = 145
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl1.Controls.Add(Me.txtDocumento)
        Me.GroupControl1.Controls.Add(Me.txtCodigo)
        Me.GroupControl1.Controls.Add(Me.cbCuenta)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.dtpFecha)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.cbBancos)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Location = New System.Drawing.Point(3, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(809, 179)
        Me.GroupControl1.TabIndex = 120
        Me.GroupControl1.Text = "REGISTRO DE HOJAS DE DEPOSITOS"
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.cmdAceptar)
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Location = New System.Drawing.Point(3, 197)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(809, 50)
        Me.PanelControl1.TabIndex = 121
        '
        'frmAgregarDeposito
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(816, 260)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "frmAgregarDeposito"
        Me.Text = "* Hoja de Deposito *"
        CType(Me.txtDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim r As New VB.SysContab.Rutinas()
    Dim Depositos As New VB.SysContab.DepositosDB()
    Dim Bancos As New VB.SysContab.BancosDB()

    Private Sub frmAgregarDeposito_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dtpFecha.Value = r.Fecha

        cbBancos.DataSource = Bancos.List().Tables("BANCOS")
        cbBancos.ValueMember = "Codigo"
        cbBancos.DisplayMember = "Nombre"

        cbBancos.DropDownStyle = ComboBoxStyle.DropDownList
        cbCuenta.DropDownStyle = ComboBoxStyle.DropDownList
        cbBancos.SelectedIndex = 0

        'r.FormularioColor(Me)
        txtCodigo.Text = Depositos.Numero(Now.Date.Date) '& "-" & Now.Day.ToString("00") & Now.Month.ToString("00") & Now.Year.ToString("00")
        txtCodigo.Focus()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        'MsgBox(Depositos.Numero(Now.Date.ToShortDateString))
        'Exit Sub
        Try
            If cbBancos.SelectedValue = 0 Then
                MsgBox("Seleccione el Banco", MsgBoxStyle.Information)
                cbBancos.Focus()
                Exit Sub
            End If

            Dim Deposito As String

            txtCodigo.Text = Depositos.Numero(dtpFecha.Value.Date) '& "-" & dtpFecha.Value.Day.ToString("00") & dtpFecha.Value.Month.ToString("00") & dtpFecha.Value.Year.ToString("00")
            '
            Deposito = Depositos.Numero(dtpFecha.Value.ToShortDateString) & "-" & dtpFecha.Value.Day.ToString("00") & dtpFecha.Value.Month.ToString("00") & dtpFecha.Value.Year.ToString("00")
            '
            Depositos.AddItem(Depositos.Numero(dtpFecha.Value.Date), Deposito, dtpFecha.Value.ToShortDateString, cbBancos.SelectedValue, cbCuenta.SelectedValue, Me.txtDocumento.Text)

            'r.LimpiarControles(GroupBox1)

            txtCodigo.Text = Depositos.Numero(dtpFecha.Value.Date) '& "-" & dtpFecha.Value.Day.ToString("00") & dtpFecha.Value.Month.ToString("00") & dtpFecha.Value.Year.ToString("00")
            cbBancos.SelectedIndex = 0
            Me.txtDocumento.Text = vbNullString
            Me.txtDocumento.Focus()

            XtraMessageBox.Show("El Registro se ha Grabado Correctamente !", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cbBancos_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbBancos.SelectedValueChanged
        Try
            cbCuenta.DataSource = Bancos.Cuentas(cbBancos.SelectedValue.ToString).Tables("CATALOGO_BANCOS")
            cbCuenta.ValueMember = "Numero_Cuenta"
            cbCuenta.DisplayMember = "Numero_Cuenta"
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtpFecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
        txtCodigo.Text = Depositos.Numero(dtpFecha.Value.Date) '& "-" & dtpFecha.Value.Day.ToString("00") & dtpFecha.Value.Month.ToString("00") & dtpFecha.Value.Year.ToString("00")
    End Sub

    Private Sub frmAgregarDeposito_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim f As frmCobrosTotales = f.Instance
        Dim ds As DataSet
        ds = Depositos.List(0, "", "", 0)
        f.cbDepositos.DataSource = ds.Tables("Depositos")
        f.cbDepositos.ValueMember = "Deposito_ID"
        f.cbDepositos.DisplayMember = "DisplayMember"
        If ds.Tables("Depositos").Rows.Count = 0 Then
            'No hay registros
        Else
            f.cbDepositos.SelectedValue = ds.Tables("Depositos").Rows(0).Item("Deposito_ID")
        End If
    End Sub

End Class
