Public Class FrmTrasladoCuentas
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As FrmTrasladoCuentas = Nothing

    Public Shared Function Instance() As FrmTrasladoCuentas
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmTrasladoCuentas()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Private ds As DataSet
    Private ds2 As DataSet
    Private Bancos As New VB.SysContab.BancosDB()
    Private Catalogo_Bancos As New VB.SysContab.Catalogo_BancosDB()
    Private Comprobantes As New VB.SysContab.ComprobanteDB()
    Private Catalogos As New VB.SysContab.CatalogoDB()
    Private Rutinas As New VB.SysContab.Rutinas()
    Dim PlantillasDB As New VB.SysContab.PlantillaDB()

    Public BancoID As String
    Public BancoID2 As String
    Dim CuentaCaja As String

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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GBMes As System.Windows.Forms.GroupBox
    Friend WithEvents cbBancos As System.Windows.Forms.ComboBox
    Friend WithEvents cbCuentas As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbCuentas2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbBancos2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSeleccionar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNota As System.Windows.Forms.TextBox
    Friend WithEvents FechaPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbComprobantes As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCheque As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblBalance1 As System.Windows.Forms.Label
    Friend WithEvents lblBalance2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents etInicio As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.etInicio = New System.Windows.Forms.Label
        Me.lblBalance2 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblBalance1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCheque = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtNota = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cbCuentas2 = New System.Windows.Forms.ComboBox
        Me.cbBancos2 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GBMes = New System.Windows.Forms.GroupBox
        Me.cbCuentas = New System.Windows.Forms.ComboBox
        Me.cbBancos = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbComprobantes = New System.Windows.Forms.ComboBox
        Me.FechaPicker = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSeleccionar = New DevExpress.XtraEditors.SimpleButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GBMes.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.etInicio)
        Me.GroupBox1.Controls.Add(Me.lblBalance2)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lblBalance1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtCheque)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtNota)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GBMes)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbComprobantes)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(992, 356)
        Me.GroupBox1.TabIndex = 143
        Me.GroupBox1.TabStop = False
        '
        'etInicio
        '
        Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etInicio.Location = New System.Drawing.Point(514, 168)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(72, 26)
        Me.etInicio.TabIndex = 155
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
        '
        'lblBalance2
        '
        Me.lblBalance2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance2.Location = New System.Drawing.Point(872, 138)
        Me.lblBalance2.Name = "lblBalance2"
        Me.lblBalance2.Size = New System.Drawing.Size(112, 25)
        Me.lblBalance2.TabIndex = 154
        Me.lblBalance2.Text = "0"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(792, 138)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 26)
        Me.Label11.TabIndex = 153
        Me.Label11.Text = "Balance:"
        '
        'lblBalance1
        '
        Me.lblBalance1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance1.Location = New System.Drawing.Point(872, 52)
        Me.lblBalance1.Name = "lblBalance1"
        Me.lblBalance1.Size = New System.Drawing.Size(112, 24)
        Me.lblBalance1.TabIndex = 152
        Me.lblBalance1.Text = "0"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(792, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 26)
        Me.Label8.TabIndex = 151
        Me.Label8.Text = "Balance:"
        '
        'txtCheque
        '
        Me.txtCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheque.Location = New System.Drawing.Point(275, 220)
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(184, 20)
        Me.txtCheque.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(62, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(240, 26)
        Me.Label7.TabIndex = 149
        Me.Label7.Text = "No. Cheque o Transferencia"
        '
        'txtNota
        '
        Me.txtNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNota.Location = New System.Drawing.Point(275, 254)
        Me.txtNota.Multiline = True
        Me.txtNota.Name = "txtNota"
        Me.txtNota.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNota.Size = New System.Drawing.Size(328, 61)
        Me.txtNota.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(190, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 26)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Nota:"
        '
        'txtMonto
        '
        Me.txtMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.Location = New System.Drawing.Point(275, 177)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(184, 20)
        Me.txtMonto.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(110, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 26)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Monto a Transferir:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbCuentas2)
        Me.GroupBox2.Controls.Add(Me.cbBancos2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 95)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(768, 69)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'cbCuentas2
        '
        Me.cbCuentas2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCuentas2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCuentas2.Location = New System.Drawing.Point(512, 26)
        Me.cbCuentas2.Name = "cbCuentas2"
        Me.cbCuentas2.Size = New System.Drawing.Size(248, 23)
        Me.cbCuentas2.TabIndex = 4
        '
        'cbBancos2
        '
        Me.cbBancos2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBancos2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBancos2.Location = New System.Drawing.Point(176, 26)
        Me.cbBancos2.Name = "cbBancos2"
        Me.cbBancos2.Size = New System.Drawing.Size(328, 23)
        Me.cbBancos2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 26)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Transferir Fondos a:"
        '
        'GBMes
        '
        Me.GBMes.Controls.Add(Me.cbCuentas)
        Me.GBMes.Controls.Add(Me.cbBancos)
        Me.GBMes.Controls.Add(Me.Label4)
        Me.GBMes.Location = New System.Drawing.Point(18, 20)
        Me.GBMes.Name = "GBMes"
        Me.GBMes.Size = New System.Drawing.Size(768, 69)
        Me.GBMes.TabIndex = 18
        Me.GBMes.TabStop = False
        '
        'cbCuentas
        '
        Me.cbCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCuentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCuentas.Location = New System.Drawing.Point(512, 26)
        Me.cbCuentas.Name = "cbCuentas"
        Me.cbCuentas.Size = New System.Drawing.Size(248, 23)
        Me.cbCuentas.TabIndex = 2
        '
        'cbBancos
        '
        Me.cbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBancos.Location = New System.Drawing.Point(176, 26)
        Me.cbBancos.Name = "cbBancos"
        Me.cbBancos.Size = New System.Drawing.Size(328, 23)
        Me.cbBancos.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(16, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 26)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Transferir Fondos de:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(79, 321)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 26)
        Me.Label6.TabIndex = 148
        Me.Label6.Text = "Tipo de Comprobantes:"
        Me.Label6.Visible = False
        '
        'cbComprobantes
        '
        Me.cbComprobantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbComprobantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbComprobantes.Location = New System.Drawing.Point(275, 321)
        Me.cbComprobantes.Name = "cbComprobantes"
        Me.cbComprobantes.Size = New System.Drawing.Size(328, 23)
        Me.cbComprobantes.TabIndex = 7
        Me.cbComprobantes.Visible = False
        '
        'FechaPicker
        '
        Me.FechaPicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaPicker.Location = New System.Drawing.Point(888, 17)
        Me.FechaPicker.Name = "FechaPicker"
        Me.FechaPicker.Size = New System.Drawing.Size(112, 20)
        Me.FechaPicker.TabIndex = 144
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(808, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 26)
        Me.Label1.TabIndex = 145
        Me.Label1.Text = "Fecha:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdAyuda)
        Me.GroupBox3.Controls.Add(Me.cmdSalir)
        Me.GroupBox3.Controls.Add(Me.cmdSeleccionar)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 404)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(992, 69)
        Me.GroupBox3.TabIndex = 146
        Me.GroupBox3.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Location = New System.Drawing.Point(94, 17)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 35)
        Me.cmdAyuda.TabIndex = 10
        Me.cmdAyuda.Text = "Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(172, 17)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 35)
        Me.cmdSalir.TabIndex = 11
        Me.cmdSalir.Text = "Salir"
        '
        'cmdSeleccionar
        '
        Me.cmdSeleccionar.Location = New System.Drawing.Point(16, 17)
        Me.cmdSeleccionar.Name = "cmdSeleccionar"
        Me.cmdSeleccionar.Size = New System.Drawing.Size(72, 35)
        Me.cmdSeleccionar.TabIndex = 9
        Me.cmdSeleccionar.Text = "Transferir"
        '
        'RadioButton1
        '
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.Maroon
        Me.RadioButton1.Location = New System.Drawing.Point(8, 17)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(200, 26)
        Me.RadioButton1.TabIndex = 147
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Transferencia entre Bancos"
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.Maroon
        Me.RadioButton2.Location = New System.Drawing.Point(232, 17)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(224, 26)
        Me.RadioButton2.TabIndex = 148
        Me.RadioButton2.Text = "Transferencia entre Banco y Caja"
        '
        'FrmTrasladoCuentas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 513)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.FechaPicker)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmTrasladoCuentas"
        Me.Text = "Traslado de Cuentas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GBMes.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim r As New VB.SysContab.Rutinas()

    Private Sub FrmTrasladoCuentas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        r.FormularioColor(Me)
        ds = Bancos.GetListActivos()
        ds2 = Bancos.GetListActivos()

        cbBancos.DataSource = Bancos.GetListActivos.Tables("Bancos")
        cbBancos.ValueMember = "Codigo"
        cbBancos.DisplayMember = "Nombre"

        cbBancos2.DataSource = Bancos.GetListActivos.Tables("Bancos")
        cbBancos2.ValueMember = "Codigo"
        cbBancos2.DisplayMember = "Nombre"

        cbComprobantes.DataSource = Comprobantes.GetTiposComprobantes.Tables("TipoComprobantes")
        cbComprobantes.ValueMember = "TipComp_Id"
        cbComprobantes.DisplayMember = "TipComp_Nombre"

        If ds.Tables("Bancos").Rows.Count <> 0 Then
            BancoID = cbBancos.SelectedValue
        Else
            BancoID = "Vacio"
        End If

        If ds2.Tables("Bancos").Rows.Count <> 0 Then
            BancoID2 = cbBancos2.SelectedValue
        Else
            BancoID2 = "Vacio"
        End If

        If BancoID <> "Vacio" Then
            cbCuentas.DataSource = Catalogo_Bancos.GetList(BancoID).Tables("CATALOGO_BANCOS")
            cbCuentas.ValueMember = "Cuenta"
            cbCuentas.DisplayMember = "NoCuenta"
        End If

        If BancoID2 <> "Vacio" Then
            cbCuentas2.DataSource = Catalogo_Bancos.GetList(BancoID2).Tables("CATALOGO_BANCOS")
            cbCuentas2.ValueMember = "Cuenta"
            cbCuentas2.DisplayMember = "NoCuenta"
        End If
        Me.etInicio.Text = "0"
    End Sub

    Private Sub cbBancos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBancos.SelectedIndexChanged
        If Me.etInicio.Text = "1" Then
            Exit Sub
        End If
        'If IsNumeric(cbBancos.SelectedValue) Then
        cbCuentas.DataSource = Catalogo_Bancos.GetList(cbBancos.SelectedValue).Tables("CATALOGO_BANCOS")
        cbCuentas.ValueMember = "Cuenta"
        cbCuentas.DisplayMember = "NoCuenta"

        If cbCuentas.SelectedValue = Nothing Then
            Exit Sub
        End If
        lblBalance1.Text = CDbl(Comprobantes.SaldoxCuenta(cbCuentas.SelectedValue, VB.SysContab.PeriodosDB.Activo(Me.FechaPicker.Value))).ToString(Round)
        'End If
    End Sub

    Private Sub cbBancos2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBancos2.SelectedIndexChanged
        If RadioButton2.Checked = True Then
            'If IsNumeric(cbBancos2.SelectedValue) Then
            If Me.etInicio.Text = "1" Then
                Exit Sub
            End If
            cbCuentas2.DataSource = Catalogos.GetListSubCuenta(cbBancos2.SelectedValue, EmpresaActual).Tables("Catalogo")
            cbCuentas2.ValueMember = "CUENTA"
            cbCuentas2.DisplayMember = "NOMBRE"

            If cbCuentas2.SelectedValue = Nothing Then
                Exit Sub
            End If
            lblBalance2.Text = CDbl(Comprobantes.SaldoxCuenta(cbCuentas2.SelectedValue, VB.SysContab.PeriodosDB.Activo(Me.FechaPicker.Value))).ToString(Round)
            'End If
        End If

        If RadioButton1.Checked = True Then
            If Me.etInicio.Text = "1" Then
                Exit Sub
            End If

            'If IsNumeric(cbBancos2.SelectedValue) Then
            cbCuentas2.DataSource = Catalogo_Bancos.GetList(cbBancos2.SelectedValue).Tables("CATALOGO_BANCOS")
            cbCuentas2.ValueMember = "Cuenta"
            cbCuentas2.DisplayMember = "NoCuenta"

            If cbCuentas2.SelectedValue = Nothing Then
                Exit Sub
            End If
            lblBalance2.Text = CDbl(Comprobantes.SaldoxCuenta(cbCuentas2.SelectedValue, VB.SysContab.PeriodosDB.Activo(Me.FechaPicker.Value))).ToString(Round)
            'End If
        End If
    End Sub

    Private Sub cmdSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSeleccionar.Click
        If Me.cbBancos.SelectedValue = 0 Then
            MsgBox("Seleccione la cuenta origen", MsgBoxStyle.Information)
            Me.cbBancos.Focus()
            Exit Sub
        End If

        If Me.cbBancos2.SelectedValue = 0 Then
            MsgBox("Seleccione la cuenta destino", MsgBoxStyle.Information)
            Me.cbBancos2.Focus()
            Exit Sub
        End If

        If Trim(txtMonto.Text) = "" Then
            MsgBox("Escriba el Monto a Transferir", MsgBoxStyle.Information)
            txtMonto.Focus()
            txtMonto.SelectAll()
            Exit Sub
        End If

        If IsNumeric(txtMonto.Text) = False Then
            MsgBox("El Monto a transferir debe ser una expresion numerica", MsgBoxStyle.Information)
            txtMonto.Focus()
            txtMonto.SelectAll()
            Exit Sub
        End If

        If Trim(txtMonto.Text) <= 0 Then
            MsgBox("El Monto a Transferir debe ser Mayor que  0", MsgBoxStyle.Information)
            txtMonto.Focus()
            txtMonto.SelectAll()
            Exit Sub
        End If

        'If cbComprobantes.SelectedValue = 0 Then
        '    MsgBox("Debe seleccionar un Tipo de Comprobante", MsgBoxStyle.Information)
        '    cbComprobantes.Focus()
        '    cbComprobantes.SelectAll()
        '    Exit Sub
        'End If

        If cbCuentas.SelectedValue = cbCuentas2.SelectedValue Then
            MsgBox("La transferencia no puede ser entre la misma cuenta", MsgBoxStyle.Information)
            cbCuentas2.Focus()
            cbCuentas2.SelectAll()
            Exit Sub
        End If

        Dim dsPlantillas As DataSet = PlantillasDB.GetPlantillasDetails(5, 1).Detalles
        Dim TipoCOmpr As String = PlantillasDB.GetPlantillasDetails(5, 1).TipoCompr

        If dsPlantillas.Tables("PlantillasDetalles").Rows.Count = 0 Then
            MsgBox("Falta Plantilla", MsgBoxStyle.Information)
            Me.RadioButton1.Checked = True
            Exit Sub
        End If

        Me.cbComprobantes.SelectedValue = TipoCOmpr

        ' FALTA TASA CAMBIO
        If Me.RadioButton1.Checked = True Then
            If Comprobantes.Transferencia(cbCuentas.SelectedValue, cbCuentas2.SelectedValue, txtMonto.Text, cbComprobantes.SelectedValue, 1, 1, txtNota.Text, cbComprobantes.SelectedValue, FechaPicker.Value, txtCheque.Text) = True Then
                Rutinas.LimpiarControles(GroupBox1)
                lblBalance1.Text = CDbl(Comprobantes.SaldoxCuenta(cbCuentas.SelectedValue, VB.SysContab.PeriodosDB.Activo(Me.FechaPicker.Value))).ToString(Round)
                lblBalance2.Text = CDbl(Comprobantes.SaldoxCuenta(cbCuentas2.SelectedValue, VB.SysContab.PeriodosDB.Activo(Me.FechaPicker.Value))).ToString(Round)
                MsgBox("Se realizado satisfactoriamente la transferencia")
            Else
                'MsgBox("Error al realizar la transferencia")
            End If
        Else
            If Comprobantes.Transferencia(cbCuentas.SelectedValue, CuentaCaja, txtMonto.Text, cbComprobantes.SelectedValue, 1, 1, txtNota.Text, cbComprobantes.SelectedValue, FechaPicker.Value, txtCheque.Text) = True Then
                Rutinas.LimpiarControles(GroupBox1)
                lblBalance1.Text = CDbl(Comprobantes.SaldoxCuenta(cbCuentas.SelectedValue, VB.SysContab.PeriodosDB.Activo(Me.FechaPicker.Value))).ToString(Round)
                lblBalance2.Text = CDbl(Comprobantes.SaldoxCuenta(CuentaCaja, VB.SysContab.PeriodosDB.Activo(Me.FechaPicker.Value))).ToString(Round)
                MsgBox("Se realizado satisfactoriamente la transferencia")
            Else
                'MsgBox("Error al realizar la transferencia")
            End If

        End If


        'Else
        '    If Comprobantes.Transferencia(cbCuentas.SelectedValue, cbCuentas2.SelectedValue, txtMonto.Text, cbComprobantes.SelectedValue, 1, 1, txtNota.Text, cbComprobantes.SelectedValue, FechaPicker.Value, txtCheque.Text) = True Then
        '        Rutinas.LimpiarControles(GroupBox1)
        '        lblBalance1.Text = CDbl(Comprobantes.SaldoxCuenta(cbCuentas.SelectedValue)).ToString(Round)
        '        lblBalance2.Text = CDbl(Comprobantes.SaldoxCuenta(cbCuentas2.SelectedValue)).ToString(Round)
        '        MsgBox("Se realizado satisfactoriamente la transferencia")
        '    Else
        '        'MsgBox("Error al realizar la transferencia")
        '    End If

        'End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    'Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
    '    If RadioButton2.Checked = True Then
    '        cbBancos2.DataSource = Catalogos.CatalogoList("A").Tables("CATALOGO")
    '        cbBancos2.ValueMember = "Cuenta"
    '        cbBancos2.DisplayMember = "Nombre2"

    '        Me.cbBancos2.Enabled = False
    '        Me.cbCuentas2.Enabled = False

    '        Dim dsPlantillas As DataSet = PlantillasDB.GetPlantillasDetails(5, 1).Detalles
    '        Dim TipoCOmpr As String = PlantillasDB.GetPlantillasDetails(5, 1).TipoCompr

    '        Me.cbComprobantes.SelectedValue = TipoCOmpr

    '        If dsPlantillas.Tables("PlantillasDetalles").Rows.Count = 0 Then
    '            MsgBox("Falta Plantilla", MsgBoxStyle.Information)
    '            Me.RadioButton1.Checked = True
    '            Exit Sub
    '        End If

    '        CuentaCaja = dsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")

    '        Me.cbBancos2.SelectedValue = CuentaCaja

    '    Else
    '        Me.cbBancos2.Enabled = True
    '        Me.cbCuentas2.Enabled = True

    '    End If

    'End Sub

    'Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
    '    If RadioButton1.Checked = True Then
    '        Me.cbBancos2.Enabled = True
    '        Me.cbCuentas2.Enabled = True

    '        'If IsNumeric(cbBancos2.SelectedValue) Then
    '        If Me.etInicio.Text = "1" Then
    '            Exit Sub
    '        End If

    '        cbBancos2.DataSource = Bancos.GetListActivos.Tables("Bancos")
    '        cbBancos2.ValueMember = "Codigo"
    '        cbBancos2.DisplayMember = "Nombre"

    '        If ds2.Tables("Bancos").Rows.Count <> 0 Then
    '            BancoID2 = cbBancos2.SelectedValue
    '        Else
    '            BancoID2 = "Vacio"
    '        End If


    '        If BancoID2 <> "Vacio" Then

    '            cbCuentas2.DataSource = Catalogo_Bancos.GetList(BancoID2).Tables("CATALOGO_BANCOS")
    '            cbCuentas2.ValueMember = "CUENTA"
    '            cbCuentas2.DisplayMember = "NUMERO_CUENTA"

    '        End If

    '        'End If
    '    Else
    '        Me.cbBancos2.Enabled = False
    '        Me.cbCuentas2.Enabled = False
    '    End If
    'End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        If RadioButton1.Checked = True Then
            Me.cbBancos2.Enabled = True
            Me.cbCuentas2.Enabled = True

            'If IsNumeric(cbBancos2.SelectedValue) Then
            If Me.etInicio.Text = "1" Then
                Exit Sub
            End If

            cbBancos2.DataSource = Bancos.GetListActivos.Tables("Bancos")
            cbBancos2.ValueMember = "Codigo"
            cbBancos2.DisplayMember = "Nombre"

            If ds2.Tables("Bancos").Rows.Count <> 0 Then
                BancoID2 = cbBancos2.SelectedValue
            Else
                BancoID2 = "Vacio"
            End If


            If BancoID2 <> "Vacio" Then

                cbCuentas2.DataSource = Catalogo_Bancos.GetList(BancoID2).Tables("CATALOGO_BANCOS")
                cbCuentas2.ValueMember = "Cuenta"
                cbCuentas2.DisplayMember = "NoCuenta"

            End If

            'End If
        Else
            'Me.cbBancos2.Enabled = False
            Me.cbCuentas2.Enabled = False
        End If
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        If RadioButton2.Checked = True Then
            cbBancos2.DataSource = Catalogos.CatalogoList("A", 1).Tables("CATALOGO")
            cbBancos2.ValueMember = "Cuenta"
            cbBancos2.DisplayMember = "Nombre2"

            'Me.cbBancos2.DataSource = Catalogos.CatalogoList("A", 1).Tables("CATALOGO")
            'Me.cbBancos2.ValueMember = "Cuenta"
            'Me.cbBancos2.DisplayMember = "Nombre"

            'Me.cbBancos2.Enabled = False
            Me.cbCuentas2.Enabled = False

            'Dim dsPlantillas As DataSet = PlantillasDB.GetPlantillasDetails(5, 1).Detalles
            'Dim TipoCOmpr As String = PlantillasDB.GetPlantillasDetails(5, 1).TipoCompr

            'If dsPlantillas.Tables("PlantillasDetalles").Rows.Count = 0 Then
            '    MsgBox("Falta Plantilla", MsgBoxStyle.Information)
            '    Me.RadioButton1.Checked = True
            '    Exit Sub
            'End If

            'Me.cbComprobantes.SelectedValue = TipoCOmpr
            'CuentaCaja = dsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")

            'Me.cbBancos2.SelectedValue = CuentaCaja



        Else
            Me.cbBancos2.Enabled = True
            Me.cbCuentas2.Enabled = True

        End If
    End Sub

    Private Sub txtMonto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMonto.Leave
        If Trim(Me.txtMonto.Text) = "" Then
            Me.txtMonto.Text = "0.00"
            Exit Sub
        End If

        If Not IsNumeric(Me.txtMonto.Text) Then
            MsgBox("El Monto a transferir debe ser una expresion numérica", MsgBoxStyle.Information)
            Me.txtMonto.Focus()
            Exit Sub
        End If

        Me.txtMonto.Text = CDbl(Me.txtMonto.Text).ToString(Round)
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/BancosTrans.chm")
    End Sub
End Class
