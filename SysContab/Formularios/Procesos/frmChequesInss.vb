Imports System
Imports System.Data
Imports System.Data.SqlClient

Namespace DataGridTextBoxCombo
    Public Class frmChequesInss
        Inherits DevExpress.XtraEditors.XtraForm

        Private Shared ChildInstance As frmChequesInss = Nothing

        Public Shared Function Instance() As frmChequesInss
            If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
                ChildInstance = New frmChequesInss()
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
        Friend WithEvents cbBancos As System.Windows.Forms.ComboBox
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtMonto As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtNombre As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents cbPagar As System.Windows.Forms.ComboBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
        Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents txtDocumento As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents etBalance As System.Windows.Forms.Label
        Friend WithEvents etInicio As System.Windows.Forms.Label
        Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents dgCatalogo As System.Windows.Forms.DataGrid
        Friend WithEvents txtCheque As System.Windows.Forms.TextBox
        Friend WithEvents cbPagar1 As System.Windows.Forms.ComboBox
        Friend WithEvents cbTipoComp As System.Windows.Forms.ComboBox
        Friend WithEvents etMontoLetras As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents cmdRecalcular As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents etRuc As System.Windows.Forms.Label
        Friend WithEvents txtRuc As System.Windows.Forms.TextBox
        Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cbPagar2 As System.Windows.Forms.ComboBox
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.cbBancos = New System.Windows.Forms.ComboBox
            Me.Label25 = New System.Windows.Forms.Label
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            Me.etRuc = New System.Windows.Forms.Label
            Me.txtRuc = New System.Windows.Forms.TextBox
            Me.Label9 = New System.Windows.Forms.Label
            Me.etMontoLetras = New System.Windows.Forms.Label
            Me.cbPagar1 = New System.Windows.Forms.ComboBox
            Me.etInicio = New System.Windows.Forms.Label
            Me.Label5 = New System.Windows.Forms.Label
            Me.txtCheque = New System.Windows.Forms.TextBox
            Me.Label4 = New System.Windows.Forms.Label
            Me.txtNombre = New System.Windows.Forms.TextBox
            Me.Label3 = New System.Windows.Forms.Label
            Me.txtMonto = New System.Windows.Forms.TextBox
            Me.cbPagar = New System.Windows.Forms.ComboBox
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label2 = New System.Windows.Forms.Label
            Me.dtpFecha = New System.Windows.Forms.DateTimePicker
            Me.Label6 = New System.Windows.Forms.Label
            Me.txtConcepto = New System.Windows.Forms.TextBox
            Me.cbTipoComp = New System.Windows.Forms.ComboBox
            Me.cbPagar2 = New System.Windows.Forms.ComboBox
            Me.Label7 = New System.Windows.Forms.Label
            Me.txtDocumento = New System.Windows.Forms.TextBox
            Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
            Me.Label8 = New System.Windows.Forms.Label
            Me.etBalance = New System.Windows.Forms.Label
            Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
            Me.dgCatalogo = New System.Windows.Forms.DataGrid
            Me.cmdRecalcular = New DevExpress.XtraEditors.SimpleButton
            Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'cbBancos
            '
            Me.cbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbBancos.Location = New System.Drawing.Point(158, 9)
            Me.cbBancos.Name = "cbBancos"
            Me.cbBancos.Size = New System.Drawing.Size(480, 21)
            Me.cbBancos.TabIndex = 0
            '
            'Label25
            '
            Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label25.Location = New System.Drawing.Point(14, 9)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(130, 25)
            Me.Label25.TabIndex = 143
            Me.Label25.Text = "Cuentas de Bancos:"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.etRuc)
            Me.GroupBox1.Controls.Add(Me.txtRuc)
            Me.GroupBox1.Controls.Add(Me.Label9)
            Me.GroupBox1.Controls.Add(Me.etMontoLetras)
            Me.GroupBox1.Controls.Add(Me.cbPagar1)
            Me.GroupBox1.Controls.Add(Me.etInicio)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.txtCheque)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.txtNombre)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.txtMonto)
            Me.GroupBox1.Controls.Add(Me.cbPagar)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.dtpFecha)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.txtConcepto)
            Me.GroupBox1.Controls.Add(Me.cbTipoComp)
            Me.GroupBox1.Controls.Add(Me.cbPagar2)
            Me.GroupBox1.Location = New System.Drawing.Point(8, 34)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1000, 155)
            Me.GroupBox1.TabIndex = 144
            Me.GroupBox1.TabStop = False
            '
            'etRuc
            '
            Me.etRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etRuc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etRuc.Location = New System.Drawing.Point(294, 52)
            Me.etRuc.Name = "etRuc"
            Me.etRuc.Size = New System.Drawing.Size(90, 26)
            Me.etRuc.TabIndex = 160
            Me.etRuc.Text = "RUC/Cédula:"
            Me.etRuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtRuc
            '
            Me.txtRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRuc.Location = New System.Drawing.Point(392, 52)
            Me.txtRuc.MaxLength = 50
            Me.txtRuc.Name = "txtRuc"
            Me.txtRuc.Size = New System.Drawing.Size(240, 20)
            Me.txtRuc.TabIndex = 159
            '
            'Label9
            '
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label9.Location = New System.Drawing.Point(4, 69)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(40, 26)
            Me.Label9.TabIndex = 158
            Me.Label9.Text = "Tipo:"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Label9.Visible = False
            '
            'etMontoLetras
            '
            Me.etMontoLetras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etMontoLetras.ForeColor = System.Drawing.Color.Black
            Me.etMontoLetras.Location = New System.Drawing.Point(150, 75)
            Me.etMontoLetras.Name = "etMontoLetras"
            Me.etMontoLetras.Size = New System.Drawing.Size(840, 34)
            Me.etMontoLetras.TabIndex = 157
            '
            'cbPagar1
            '
            Me.cbPagar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbPagar1.Location = New System.Drawing.Point(640, 17)
            Me.cbPagar1.Name = "cbPagar1"
            Me.cbPagar1.Size = New System.Drawing.Size(80, 21)
            Me.cbPagar1.TabIndex = 156
            Me.cbPagar1.Visible = False
            '
            'etInicio
            '
            Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etInicio.Location = New System.Drawing.Point(6, 95)
            Me.etInicio.Name = "etInicio"
            Me.etInicio.Size = New System.Drawing.Size(40, 25)
            Me.etInicio.TabIndex = 155
            Me.etInicio.Text = "1"
            Me.etInicio.Visible = False
            '
            'Label5
            '
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label5.Location = New System.Drawing.Point(728, 17)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(104, 26)
            Me.Label5.TabIndex = 152
            Me.Label5.Text = "No. de Cheque:"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtCheque
            '
            Me.txtCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCheque.Location = New System.Drawing.Point(840, 17)
            Me.txtCheque.MaxLength = 13
            Me.txtCheque.Name = "txtCheque"
            Me.txtCheque.Size = New System.Drawing.Size(152, 20)
            Me.txtCheque.TabIndex = 3
            '
            'Label4
            '
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label4.Location = New System.Drawing.Point(6, 17)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(138, 26)
            Me.Label4.TabIndex = 150
            Me.Label4.Text = "Cheque a Nombre de:"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtNombre
            '
            Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombre.Location = New System.Drawing.Point(150, 17)
            Me.txtNombre.MaxLength = 60
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(480, 20)
            Me.txtNombre.TabIndex = 2
            '
            'Label3
            '
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(16, 52)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(104, 26)
            Me.Label3.TabIndex = 148
            Me.Label3.Text = "Monto:"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtMonto
            '
            Me.txtMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMonto.Location = New System.Drawing.Point(150, 52)
            Me.txtMonto.MaxLength = 13
            Me.txtMonto.Name = "txtMonto"
            Me.txtMonto.Size = New System.Drawing.Size(136, 20)
            Me.txtMonto.TabIndex = 5
            Me.txtMonto.Text = "0.00"
            '
            'cbPagar
            '
            Me.cbPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbPagar.Location = New System.Drawing.Point(152, 172)
            Me.cbPagar.Name = "cbPagar"
            Me.cbPagar.Size = New System.Drawing.Size(480, 21)
            Me.cbPagar.TabIndex = 1
            Me.cbPagar.Visible = False
            '
            'Label1
            '
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(16, 172)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(64, 26)
            Me.Label1.TabIndex = 145
            Me.Label1.Text = "Pagar a:"
            Me.Label1.Visible = False
            '
            'Label2
            '
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(728, 52)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(104, 17)
            Me.Label2.TabIndex = 145
            Me.Label2.Text = "Fecha:"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'dtpFecha
            '
            Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFecha.Location = New System.Drawing.Point(840, 52)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
            Me.dtpFecha.TabIndex = 4
            Me.dtpFecha.Value = New Date(2006, 8, 10, 10, 38, 43, 562)
            '
            'Label6
            '
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(16, 112)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(112, 26)
            Me.Label6.TabIndex = 152
            Me.Label6.Text = "Concepto:"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtConcepto
            '
            Me.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtConcepto.Location = New System.Drawing.Point(150, 112)
            Me.txtConcepto.MaxLength = 100
            Me.txtConcepto.Multiline = True
            Me.txtConcepto.Name = "txtConcepto"
            Me.txtConcepto.Size = New System.Drawing.Size(840, 35)
            Me.txtConcepto.TabIndex = 6
            '
            'cbTipoComp
            '
            Me.cbTipoComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbTipoComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbTipoComp.Location = New System.Drawing.Point(77, 81)
            Me.cbTipoComp.Name = "cbTipoComp"
            Me.cbTipoComp.Size = New System.Drawing.Size(240, 21)
            Me.cbTipoComp.TabIndex = 151
            Me.cbTipoComp.Visible = False
            '
            'cbPagar2
            '
            Me.cbPagar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbPagar2.Location = New System.Drawing.Point(640, 52)
            Me.cbPagar2.Name = "cbPagar2"
            Me.cbPagar2.Size = New System.Drawing.Size(80, 21)
            Me.cbPagar2.TabIndex = 157
            Me.cbPagar2.Visible = False
            '
            'Label7
            '
            Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label7.Location = New System.Drawing.Point(360, 503)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(120, 26)
            Me.Label7.TabIndex = 154
            Me.Label7.Text = "No. Documento:"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Label7.Visible = False
            '
            'txtDocumento
            '
            Me.txtDocumento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDocumento.Location = New System.Drawing.Point(496, 503)
            Me.txtDocumento.MaxLength = 60
            Me.txtDocumento.Name = "txtDocumento"
            Me.txtDocumento.Size = New System.Drawing.Size(136, 20)
            Me.txtDocumento.TabIndex = 153
            Me.txtDocumento.Visible = False
            '
            'cmdAceptar
            '
            Me.cmdAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdAceptar.Appearance.Options.UseFont = True
            Me.cmdAceptar.Location = New System.Drawing.Point(8, 503)
            Me.cmdAceptar.Name = "cmdAceptar"
            Me.cmdAceptar.Size = New System.Drawing.Size(72, 26)
            Me.cmdAceptar.TabIndex = 8
            Me.cmdAceptar.Text = "&Guardar"
            '
            'Label8
            '
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label8.Location = New System.Drawing.Point(648, 9)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(64, 25)
            Me.Label8.TabIndex = 146
            Me.Label8.Text = "Balance:"
            Me.Label8.Visible = False
            '
            'etBalance
            '
            Me.etBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etBalance.Location = New System.Drawing.Point(720, 9)
            Me.etBalance.Name = "etBalance"
            Me.etBalance.Size = New System.Drawing.Size(200, 25)
            Me.etBalance.TabIndex = 147
            Me.etBalance.Text = "0"
            Me.etBalance.Visible = False
            '
            'cmdSalir
            '
            Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.cmdSalir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdSalir.Appearance.Options.UseFont = True
            Me.cmdSalir.Location = New System.Drawing.Point(272, 503)
            Me.cmdSalir.Name = "cmdSalir"
            Me.cmdSalir.Size = New System.Drawing.Size(72, 26)
            Me.cmdSalir.TabIndex = 11
            Me.cmdSalir.Text = "&Salir"
            '
            'dgCatalogo
            '
            Me.dgCatalogo.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
            Me.dgCatalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgCatalogo.BackColor = System.Drawing.Color.Gainsboro
            Me.dgCatalogo.BackgroundColor = System.Drawing.Color.DarkGray
            Me.dgCatalogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.dgCatalogo.CaptionBackColor = System.Drawing.Color.DarkKhaki
            Me.dgCatalogo.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            Me.dgCatalogo.CaptionForeColor = System.Drawing.Color.Black
            Me.dgCatalogo.DataMember = ""
            Me.dgCatalogo.FlatMode = True
            Me.dgCatalogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgCatalogo.ForeColor = System.Drawing.Color.Black
            Me.dgCatalogo.GridLineColor = System.Drawing.Color.Silver
            Me.dgCatalogo.HeaderBackColor = System.Drawing.Color.Black
            Me.dgCatalogo.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            Me.dgCatalogo.HeaderForeColor = System.Drawing.Color.White
            Me.dgCatalogo.LinkColor = System.Drawing.Color.DarkSlateBlue
            Me.dgCatalogo.Location = New System.Drawing.Point(8, 195)
            Me.dgCatalogo.Name = "dgCatalogo"
            Me.dgCatalogo.ParentRowsBackColor = System.Drawing.Color.LightGray
            Me.dgCatalogo.ParentRowsForeColor = System.Drawing.Color.Black
            Me.dgCatalogo.SelectionBackColor = System.Drawing.Color.Firebrick
            Me.dgCatalogo.SelectionForeColor = System.Drawing.Color.White
            Me.dgCatalogo.Size = New System.Drawing.Size(1000, 302)
            Me.dgCatalogo.TabIndex = 7
            '
            'cmdRecalcular
            '
            Me.cmdRecalcular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.cmdRecalcular.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdRecalcular.Appearance.Options.UseFont = True
            Me.cmdRecalcular.Location = New System.Drawing.Point(184, 503)
            Me.cmdRecalcular.Name = "cmdRecalcular"
            Me.cmdRecalcular.Size = New System.Drawing.Size(72, 26)
            Me.cmdRecalcular.TabIndex = 10
            Me.cmdRecalcular.Text = "&Recalcular"
            '
            'cmdImprimir
            '
            Me.cmdImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdImprimir.Appearance.Options.UseFont = True
            Me.cmdImprimir.Location = New System.Drawing.Point(96, 503)
            Me.cmdImprimir.Name = "cmdImprimir"
            Me.cmdImprimir.Size = New System.Drawing.Size(72, 26)
            Me.cmdImprimir.TabIndex = 9
            Me.cmdImprimir.Text = "&Imprimir"
            Me.cmdImprimir.Visible = False
            '
            'frmChequesInss
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(1016, 537)
            Me.Controls.Add(Me.cmdImprimir)
            Me.Controls.Add(Me.cmdRecalcular)
            Me.Controls.Add(Me.dgCatalogo)
            Me.Controls.Add(Me.cmdSalir)
            Me.Controls.Add(Me.etBalance)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.cmdAceptar)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.cbBancos)
            Me.Controls.Add(Me.Label25)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.txtDocumento)
            Me.Name = "frmChequesInss"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.dgCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region
        Public WithEvents tCust As DataTable
        Private WithEvents myDataSet As DataSet
        Dim ds As DataSet

        'Dim WithEvents Codigo1 As DataGridComboBoxColumn
        'Public WithEvents Codigo As DataGridComboBoxColumn
        'Public WithEvents Descripcion As DataGridComboBoxColumn

        Dim WithEvents Codigo1 As DataGridTextBoxColumn
        Public WithEvents Codigo As DataGridTextBoxColumn
        Public WithEvents Descripcion As DataGridTextBoxColumn
        Dim Monto As DataGridTextBoxColumn

        Dim CatalogoBancos As New VB.SysContab.Catalogo_BancosDB()
        Dim Proveedores As New VB.SysContab.ProveedoresDB()
        Dim ProveedoresDetalles As New VB.SysContab.ProveedoresDetails()
        Dim Catalogo As New VB.SysContab.CatalogoDB()
        Private Comprobantes As New VB.SysContab.ComprobanteDB()
        Dim PeriodosDB As New VB.SysContab.PeriodosDB()
        Dim Clientes As New VB.SysContab.ClientesDB()
        Dim CatBancos As New VB.SysContab.Catalogo_BancosDB()
        Dim r As New VB.SysContab.Rutinas()
        Dim dsCB As DataSet

        Dim NoComprob As Double

        Public Comp, Per, Fecha, Mes As String
        Dim Fechas As New VB.SysContab.FechasdeTrabajo

        Private Sub frmChequesInss_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

            r.FormularioColor(Me)
            Me.cbBancos.DataSource = CatalogoBancos.CatalogoBancos().Tables("Tabla")
            Me.cbBancos.ValueMember = "Cuenta"
            Me.cbBancos.DisplayMember = "Nombre"

            Me.cbPagar.DataSource = Proveedores.PagarList().Tables("Proveedores")
            Me.cbPagar.ValueMember = "Codigo"
            Me.cbPagar.DisplayMember = "Nombre"

            Me.cbPagar1.DataSource = Proveedores.PagarList1().Tables("Proveedores")
            Me.cbPagar1.ValueMember = "Codigo"
            Me.cbPagar1.DisplayMember = "Nombre"

            Me.cbPagar2.DataSource = Proveedores.PagarList().Tables("Proveedores")
            Me.cbPagar2.ValueMember = "Codigo"
            Me.cbPagar2.DisplayMember = "Nombre"

            cbTipoComp.DataSource = Comprobantes.TiposComprobantesCheques().Tables("TipoComprobantes")
            cbTipoComp.ValueMember = "TipComp_Id"
            cbTipoComp.DisplayMember = "TipComp_Nombre"

            Me.dtpFecha.MinDate = Fechas.FechaMinima 'VB.SysContab.PeriodosDB.GetDetails(VB.SysContab.PeriodosDB.Activo).Inicio
            Me.dtpFecha.MaxDate = Fechas.FechaMaxima 'VB.SysContab.PeriodosDB.GetDetails(VB.SysContab.PeriodosDB.Activo).Final
            Dim Fecha As Date

            Fecha = CDate(r.Fecha)
            If Me.dtpFecha.MaxDate > Fecha Then
                Me.dtpFecha.Value = Fecha
            Else
            End If

            'Me.etMontoLetras.Text = r.ConversionDecimales(0)

            MakeDataSet()
            Me.dgCatalogo.SetDataBinding(myDataSet, "Articulos")
            AddCustomDataTableStyle()

            LeaveCommit = False
            BuscarCombo = False

            r.ComboAutoComplete(Me.cbPagar)
            'r.ComboAutoComplete(Codigo.ColumnComboBox)
            'r.ComboAutoComplete(Descripcion.ColumnComboBox)

        End Sub

        Private Sub cbPagar_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPagar.SelectedValueChanged
            If Me.etInicio.Text = "1" Then
                Exit Sub
            End If

            Me.cbPagar1.SelectedIndex = Me.cbPagar.SelectedIndex
            Me.cbPagar2.SelectedIndex = Me.cbPagar.SelectedIndex

            Me.txtNombre.Text = Me.cbPagar1.Text

            If Me.cbPagar.SelectedValue = 0 Then
                Me.etRuc.Visible = True
                Me.txtRuc.Visible = True
                Exit Sub
            End If

            ProveedoresDetalles = VB.SysContab.ProveedoresDB.GetDetails(Me.cbPagar.SelectedValue)

            If ProveedoresDetalles.Varios = True Then
                Me.etRuc.Visible = True
                Me.txtRuc.Visible = True
            Else
                Me.txtRuc.Text = ""
                Me.etRuc.Visible = False
                Me.txtRuc.Visible = False
            End If
        End Sub

        Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
            If Guardar() = False Then
                Exit Sub
            End If

            Me.Close()

            'Me.txtDocumento.Text = ""
            'Me.txtMonto.Text = "0.00"
            'Me.cbPagar.SelectedValue = 0
            'Me.txtNombre.Text = ""
            'Me.txtConcepto.Text = ""

            'Me.etMontoLetras.Text = r.ConversionDecimales(CDbl(Me.txtMonto.Text))

            'dsCB = CatBancos.CatalogoBancosXCuenta(Me.cbBancos.SelectedValue)
            'Me.txtCheque.Text = CatBancos.GetCheque(dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Banco"), dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Numero_Cuenta")).ToString
            'Me.etBalance.Text = CDbl(Comprobantes.SaldoxCuenta(Me.cbBancos.SelectedValue, VB.SysContab.PeriodosDB.Activo)).ToString(Round)
        End Sub

        Private Sub cbBancos_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbBancos.SelectedValueChanged
            If Me.etInicio.Text = "1" Then
                Exit Sub
            End If
            If Me.cbBancos.SelectedValue = "0" Then
                Me.Label8.Visible = False
                Me.etBalance.Text = 0
                Me.etBalance.Visible = False
                Me.txtCheque.Text = ""
            Else
                Me.Label8.Visible = True
                Me.etBalance.Visible = True

                dsCB = CatBancos.CatalogoBancosXCuenta(Me.cbBancos.SelectedValue)
                Me.txtCheque.Text = CatBancos.GetCheque(dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Banco"), dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Numero_Cuenta")).ToString
                Me.etBalance.Text = CDbl(Comprobantes.SaldoxCuenta(Me.cbBancos.SelectedValue, VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.Value))).ToString(Round)
            End If
        End Sub

        Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
            Me.Close()
        End Sub

        Private Sub MakeDataSet()

            myDataSet = New DataSet("myDataSet")

            tCust = New DataTable("Articulos")

            Dim cCodigo1 As DataColumn
            cCodigo1 = New DataColumn("Codigo1")

            Dim cCodigo As DataColumn
            cCodigo = New DataColumn("Codigo")

            Dim cDescripcion As DataColumn
            cDescripcion = New DataColumn("Descripcion")

            Dim cMonto As DataColumn
            cMonto = New DataColumn("Monto")

            Dim cConcepto As DataColumn
            cConcepto = New DataColumn("Concepto")

            tCust.Columns.Add(cCodigo1)
            tCust.Columns.Add(cCodigo)
            tCust.Columns.Add(cDescripcion)
            tCust.Columns.Add(cMonto)
            tCust.Columns.Add(cConcepto)
            myDataSet.Tables.Add(tCust)

            Dim newRow1 As DataRow

        End Sub

        Private Sub AddCustomDataTableStyle()

            Dim ts1 As DataGridTableStyle
            ts1 = New DataGridTableStyle()
            ts1.MappingName = "Articulos"
            ts1.AlternatingBackColor = Color.LightBlue

            Dim colCount As Integer
            colCount = 0

            'Codigo1 = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))
            'Codigo1.MappingName = "Codigo1"
            'Codigo1.HeaderText = ""
            'Codigo1.Width = 0
            'ts1.GridColumnStyles.Add(Codigo1)
            'ts1.PreferredRowHeight = (Codigo1.ColumnComboBox.Height + 3)
            'Codigo1.NullText = ""
            'colCount = (colCount + 1)

            'Codigo = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))
            'Codigo.MappingName = "Codigo"
            'Codigo.HeaderText = "Cuenta"
            'Codigo.Width = 350
            'ts1.GridColumnStyles.Add(Codigo)
            'ts1.PreferredRowHeight = (Codigo.ColumnComboBox.Height + 3)
            'Codigo.NullText = ""
            'colCount = (colCount + 1)

            'Descripcion = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))
            'Descripcion.MappingName = "Descripcion"
            'Descripcion.HeaderText = "Nombre"
            'Descripcion.Width = 300
            'ts1.GridColumnStyles.Add(Descripcion)
            'ts1.PreferredRowHeight = (Descripcion.ColumnComboBox.Height + 3)
            'Descripcion.NullText = ""
            'colCount = (colCount + 1)

            Codigo1 = New DataGridTextBoxColumn()
            Codigo1.MappingName = "Codigo1"
            Codigo1.HeaderText = ""
            Codigo1.Width = 0
            Codigo1.Alignment = HorizontalAlignment.Left
            Codigo1.ReadOnly = False
            ts1.GridColumnStyles.Add(Codigo1)
            colCount = (colCount + 1)
            Codigo1.NullText = ""

            Codigo = New DataGridTextBoxColumn()
            Codigo.MappingName = "Codigo"
            Codigo.HeaderText = "Cuenta"
            Codigo.Width = 350
            Codigo.Alignment = HorizontalAlignment.Left
            Codigo.ReadOnly = False
            ts1.GridColumnStyles.Add(Codigo)
            colCount = (colCount + 1)
            Codigo.NullText = ""

            Descripcion = New DataGridTextBoxColumn()
            Descripcion.MappingName = "Descripcion"
            Descripcion.HeaderText = "Nombre"
            Descripcion.Width = 300
            Descripcion.Alignment = HorizontalAlignment.Left
            Descripcion.ReadOnly = False
            ts1.GridColumnStyles.Add(Descripcion)
            colCount = (colCount + 1)
            Descripcion.NullText = ""

            Monto = New DataGridTextBoxColumn()
            Monto.MappingName = "Monto"
            Monto.HeaderText = "Monto"
            Monto.Width = 100
            Monto.Alignment = HorizontalAlignment.Right
            Monto.ReadOnly = False

            AddHandler Monto.TextBox.Leave, New EventHandler(AddressOf TextBoxMontoLeaveHandler)
            ts1.GridColumnStyles.Add(Monto)
            colCount = (colCount + 1)

            Monto.NullText = "0.00"

            Dim Concepto As DataGridTextBoxColumn
            Concepto = New DataGridTextBoxColumn()
            Concepto.MappingName = "Concepto"
            Concepto.HeaderText = "Descripción"
            Concepto.Width = 210
            Concepto.Alignment = HorizontalAlignment.Left
            Concepto.ReadOnly = False

            ts1.GridColumnStyles.Add(Concepto)
            colCount = (colCount + 1)

            Concepto.NullText = ""


            'Dim i As Long
            'ds = Catalogo.CatalogoList1("A")
            'For i = 0 To ds.Tables("CATALOGO").Rows.Count - 1
            '    Codigo1.ColumnComboBox.Items.Add(ds.Tables("CATALOGO").Rows(i).Item("Cuenta"))
            '    Codigo.ColumnComboBox.Items.Add(ds.Tables("CATALOGO").Rows(i).Item("Cuenta") & " - " & ds.Tables("CATALOGO").Rows(i).Item("Nombre"))
            '    Descripcion.ColumnComboBox.Items.Add(ds.Tables("CATALOGO").Rows(i).Item("Nombre"))
            'Next

            'Codigo.ColumnComboBox.DropDownStyle = ComboBoxStyle.DropDown
            'Descripcion.ColumnComboBox.DropDownStyle = ComboBoxStyle.DropDown

            ts1.GridLineColor = Color.FromArgb(70, 130, 180)
            ts1.AllowSorting = False
            ts1.HeaderFont = Me.dgCatalogo.HeaderFont
            ts1.HeaderBackColor = Color.LightSteelBlue
            ts1.PreferredRowHeight = 25

            Me.dgCatalogo.CaptionVisible = False
            Me.dgCatalogo.ReadOnly = True

            Me.dgCatalogo.TableStyles.Clear()
            Me.dgCatalogo.TableStyles.Add(ts1)

        End Sub

        'Public Sub MyComboValueChanged(ByVal rowChanging As Integer, ByVal newValue As Object)
        '    Console.WriteLine("index changed {0} {1}", rowChanging, newValue)

        '    Try
        '        If Indice >= 0 Then
        '            If tCust.Rows.Count < rowChanging + 1 Then
        '                Dim newRow1 As DataRow
        '                newRow1 = tCust.NewRow
        '                newRow1("Codigo") = Codigo.ColumnComboBox.Items.Item(Indice)
        '                tCust.Rows.Add(newRow1)

        '                tCust.Rows(rowChanging)("Codigo1") = Codigo1.ColumnComboBox.Items.Item(Indice)
        '                tCust.Rows(rowChanging)("Descripcion") = Descripcion.ColumnComboBox.Items.Item(Indice)

        '                If rowChanging = 0 And tCust.Rows.Count = 1 Then
        '                    tCust.Rows(rowChanging)("Monto") = CDbl(Me.txtMonto.Text).ToString(Round)
        '                End If

        '            Else
        '                tCust.Rows(rowChanging)("Codigo1") = Codigo1.ColumnComboBox.Items.Item(Indice)
        '                tCust.Rows(rowChanging)("Codigo") = Codigo.ColumnComboBox.Items.Item(Indice)
        '                tCust.Rows(rowChanging)("Descripcion") = Descripcion.ColumnComboBox.Items.Item(Indice)
        '            End If

        '        End If
        '    Catch ex As Exception
        '        MsgBox(ex.Message & "MyComboValueChanged")
        '    End Try
        'End Sub

        Private Sub Evento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
            MsgBox(e.KeyCode)
        End Sub

        Private Sub TextBoxMontoLeaveHandler(ByVal sender As Object, ByVal e As EventArgs)
            Try
                Monto.TextBox.Text = CDbl(Monto.TextBox.Text).ToString(Round)

            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
                If Me.dgCatalogo.Item(Me.dgCatalogo.CurrentRowIndex, 2) Is DBNull.Value Then
                    Monto.TextBox.Text = "0.00"
                Else
                    Monto.TextBox.Text = CDbl(Me.dgCatalogo.Item(Me.dgCatalogo.CurrentRowIndex, 2)).ToString(Round) 'CDbl(tCust.Rows(Me.dgCatalogo.CurrentRowIndex)("Monto")).ToString(Round) 'ValorActualCantidad
                End If

                MsgBox("Introduzca un monto válido", MsgBoxStyle.Information)
                Me.dgCatalogo.Focus()
                Monto.TextBox.Focus()
                Exit Sub

            End Try
        End Sub

        Private Sub txtMonto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMonto.Leave
            If Trim(Me.txtMonto.Text) = "" Then
                Me.txtMonto.Text = "0.00"
            End If

            If Not IsNumeric(Me.txtMonto.Text) Then
                MsgBox("Introduzca un valor númerico", MsgBoxStyle.Information)
                Me.txtMonto.Focus()
                Me.txtMonto.SelectAll()
                Exit Sub
            End If

            Me.txtMonto.Text = CDbl(Me.txtMonto.Text).ToString(Round)
            Me.etMontoLetras.Text = r.Letras(CDbl(Me.txtMonto.Text)) ' r.Letras(Me.txtMonto.Text)
        End Sub

        Private Sub txtCheque_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCheque.KeyPress
            If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
                If Char.IsDigit(e.KeyChar) = False Then
                    e.Handled = True
                    Exit Sub
                End If
            End If
        End Sub

        Private Sub cmdRecalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRecalcular.Click
            Dim i As Integer
            Dim Total As Double
            Total = 0

            For i = 0 To tCust.Rows.Count - 1
                If (tCust.Rows(tCust.Rows.Count - 1)("Codigo1").ToString = "" Or tCust.Rows(tCust.Rows.Count - 1)("Codigo1") Is DBNull.Value) And (tCust.Rows(tCust.Rows.Count - 1)("Codigo").ToString = "" Or tCust.Rows(tCust.Rows.Count - 1)("Codigo") Is DBNull.Value) And (tCust.Rows(tCust.Rows.Count - 1)("Descripcion").ToString = "" Or tCust.Rows(tCust.Rows.Count - 1)("Descripcion") Is DBNull.Value) And (tCust.Rows(tCust.Rows.Count - 1)("Monto").ToString = "" Or tCust.Rows(tCust.Rows.Count - 1)("Monto") Is DBNull.Value) And (tCust.Rows(tCust.Rows.Count - 1)("Concepto").ToString = "" Or tCust.Rows(tCust.Rows.Count - 1)("Concepto") Is DBNull.Value) Then
                    tCust.Rows(tCust.Rows.Count - 1).Delete()
                End If
            Next

            For i = 0 To tCust.Rows.Count - 1
                If tCust.Rows(i)("Codigo1") Is DBNull.Value Or tCust.Rows(i)("Codigo1").ToString = "" Then
                    MsgBox("Especifique una cuenta en la linea " & i + 1, MsgBoxStyle.Information)
                    Me.dgCatalogo.Focus()
                    Codigo.TextBox.Focus()
                    Exit Sub
                Else
                    If tCust.Rows(i)("Monto") Is DBNull.Value Then
                        '
                    Else
                        Total = Total + CDbl(tCust.Rows(i)("Monto"))
                    End If

                End If
            Next

            Me.txtMonto.Text = Total.ToString(Round)
            Me.etMontoLetras.Text = r.Letras(CDbl(Me.txtMonto.Text))
        End Sub

        Private Function Guardar() As Boolean
            If Me.cbBancos.SelectedValue = "0" Then
                MsgBox("Seleccione el Banco", MsgBoxStyle.Information)
                Me.cbBancos.Focus()
                Return False
                Exit Function
            End If

            If Trim(Me.txtNombre.Text) = "" Then
                MsgBox("Introduzca a nombre de quien es el cheque", MsgBoxStyle.Information)
                Me.txtNombre.Focus()
                Me.txtNombre.SelectAll()
                Return False
                Exit Function
            End If

            If Trim(Me.txtMonto.Text) = "" Then
                MsgBox("Introduzca el monto", MsgBoxStyle.Information)
                Me.txtMonto.Focus()
                Me.txtMonto.SelectAll()
                Return False
                Exit Function
            End If

            If Me.cbTipoComp.SelectedValue = "0" Or Me.cbTipoComp.SelectedValue = Nothing Then
                MsgBox("Seleccione el Tipo de Comprobante", MsgBoxStyle.Information)
                Me.cbTipoComp.Focus()
                Return False
                Exit Function
            End If

            If tCust.Rows.Count = 0 Then
                MsgBox("Seleccione al menos cuenta", MsgBoxStyle.Information)
                Me.dgCatalogo.Focus()
                Return False
                Exit Function
            End If

            Dim i As Integer
            Dim j As Integer
            Dim Total As Double
            Total = 0

            For i = 0 To tCust.Rows.Count - 1
                If (tCust.Rows(tCust.Rows.Count - 1)("Codigo1").ToString = "" Or tCust.Rows(tCust.Rows.Count - 1)("Codigo1") Is DBNull.Value) And (tCust.Rows(tCust.Rows.Count - 1)("Codigo").ToString = "" Or tCust.Rows(tCust.Rows.Count - 1)("Codigo") Is DBNull.Value) And (tCust.Rows(tCust.Rows.Count - 1)("Descripcion").ToString = "" Or tCust.Rows(tCust.Rows.Count - 1)("Descripcion") Is DBNull.Value) And (tCust.Rows(tCust.Rows.Count - 1)("Monto").ToString = "" Or tCust.Rows(tCust.Rows.Count - 1)("Monto") Is DBNull.Value) And (tCust.Rows(tCust.Rows.Count - 1)("Concepto").ToString = "" Or tCust.Rows(tCust.Rows.Count - 1)("Concepto") Is DBNull.Value) Then
                    tCust.Rows(tCust.Rows.Count - 1).Delete()
                End If
            Next

            For j = 0 To tCust.Rows.Count - 1
                If tCust.Rows(j)("Codigo1") Is DBNull.Value Or tCust.Rows(j)("Codigo1").ToString = "" Then
                    MsgBox("Especifique una cuenta en la linea " & j + 1, MsgBoxStyle.Information)
                    Me.dgCatalogo.Focus()
                    Codigo.TextBox.Focus()
                    Return False
                    Exit Function
                Else
                    If tCust.Rows(j)("Monto") Is DBNull.Value Then
                        '
                    Else
                        Total = Total + CDbl(tCust.Rows(j)("Monto"))
                    End If

                End If

            Next

            If CDbl(CDbl(Total).ToString(Round)) > CDbl(CDbl(Me.txtMonto.Text).ToString(Round)) Then
                MsgBox("La suma del detalle en las Lineas es mayor que el Monto a Pagar", MsgBoxStyle.Information)
                Me.dgCatalogo.Focus()
                Return False
                Exit Function
            ElseIf CDbl(CDbl(Total).ToString(Round)) < CDbl(CDbl(Me.txtMonto.Text).ToString(Round)) Then
                MsgBox("La suma del detalle en las Lineas es menor que el Monto a Pagar", MsgBoxStyle.Information)
                Me.dgCatalogo.Focus()
                Return False
                Exit Function
            End If
            'if me.
            Dim dsLaboral As DataSet
            Dim dsPatronal As DataSet

            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction()

            Try
                Dim DC As String
                NoComprob = Comprobantes.AddComprobante(Me.cbTipoComp.SelectedValue, 1, txtConcepto.Text, VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MonedaBase, PeriodosDB.Activo(Me.dtpFecha.Value), dtpFecha.Value, 0, Me.txtNombre.Text, False, Me.cbPagar.SelectedValue, Me.txtRuc.Text, 2, "", VB.SysContab.Rutinas.Fecha, 0, OrigenComprobantes.CHEQUE)
                DC = "C"

                dsLaboral = VB.SysContab.PeriodoNominaDB.InssLaboralXMes(Me.Mes)
                dsPatronal = VB.SysContab.PeriodoNominaDB.InssPatronalXMes(Me.Mes)

                'dsLaboral.Tables("Tabla").Rows(0).Item("CDet_Cuenta") & " - " & dsLaboral.Tables("Tabla").Rows(0).Item("NombreCuenta")
                For i = 0 To dsLaboral.Tables("Tabla").Rows.Count - 1
                    Comprobantes.PagosFactura(dsLaboral.Tables("Tabla").Rows(i).Item("Comp_No"), dsLaboral.Tables("Tabla").Rows(i).Item("Per_ID"), dsLaboral.Tables("Tabla").Rows(i).Item("Comp_Fecha"), dsLaboral.Tables("Tabla").Rows(i).Item("Monto"), NoComprob, VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.Value), dtpFecha.Value, 0, 0, "021")
                Next

                For i = 0 To dsPatronal.Tables("Tabla").Rows.Count - 1
                    Comprobantes.PagosFactura(dsPatronal.Tables("Tabla").Rows(i).Item("Comp_No"), dsPatronal.Tables("Tabla").Rows(i).Item("Per_ID"), dsPatronal.Tables("Tabla").Rows(i).Item("Comp_Fecha"), dsPatronal.Tables("Tabla").Rows(i).Item("Monto"), NoComprob, VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.Value), dtpFecha.Value, 0, 0, "000")
                Next

                If Trim(Me.txtCheque.Text) <> "" Then
                    Comprobantes.ActualizarCheque(Me.cbBancos.SelectedValue, Me.txtCheque.Text)
                End If

                Comprobantes.AddComprobanteDetalles(NoComprob, Me.cbBancos.SelectedValue, "", Me.txtMonto.Text, Me.txtCheque.Text, Me.cbTipoComp.SelectedValue, DC, 0, 0, Me.dtpFecha.Value, 0)

                For i = 0 To tCust.Rows.Count - 1

                    Dim Opera As Integer

                    If VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo1")).Tables("Catalogo").Rows(0).Item("Clase") = 1 Then
                        DC = "D"
                        Opera = 1
                    ElseIf VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo1")).Tables("Catalogo").Rows(0).Item("Clase") = 2 And CDbl(tCust.Rows(i)("Monto")) >= 0 Then
                        DC = "D"
                        Opera = 1
                    ElseIf VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo1")).Tables("Catalogo").Rows(0).Item("Clase") = 2 And CDbl(tCust.Rows(i)("Monto")) < 0 Then
                        DC = "C"
                        Opera = 2
                    End If

                    Comprobantes.AddComprobanteDetalles(NoComprob, tCust.Rows(i)("Codigo1"), tCust.Rows(i)("Concepto").ToString, Math.Abs(CDbl(tCust.Rows(i)("Monto"))), Me.txtCheque.Text, Me.cbTipoComp.SelectedValue, DC, 0, 0, Me.dtpFecha.Value, 1)
                Next

                VB.SysContab.Rutinas.okTransaccion()

            Catch Mensaje As Exception
                VB.SysContab.Rutinas.ErrorTransaccion()
                MsgBox(Mensaje.Message)
                Return False
                Exit Function
            End Try

            MakeDataSet()
            Me.dgCatalogo.SetDataBinding(myDataSet, "Articulos")
            AddCustomDataTableStyle()

            'r.ComboAutoComplete(Codigo.ColumnComboBox)
            'r.ComboAutoComplete(Descripcion.ColumnComboBox)

            Return True

        End Function

        Private Sub cbPagar_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPagar.Leave
            Dim Cliente As Boolean
            Dim Proveedor As Boolean
            Cliente = False
            Proveedor = False

            If Trim(Me.cbPagar.Text) = "" Then
                Exit Sub
            End If

            If Me.cbPagar.Text = Me.cbPagar2.Text Then
                Exit Sub
            End If

            If Clientes.ClientesBuscar(Trim(Me.cbPagar.Text)).Tables("Clientes").Rows.Count = 0 Then
                Cliente = True
            End If

            If Proveedores.ProveedoresBuscar(Trim(Me.cbPagar.Text)).Tables("Proveedores").Rows.Count = 0 Then
                Proveedor = True
                Me.cbPagar.Text = Me.cbPagar.Text.ToUpper

                If Cliente = True And Proveedor = True Then
                    If (MsgBox("Proveedor no existe. Desea agregarlo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)) = MsgBoxResult.No Then
                        Me.etRuc.Visible = True
                        Me.txtRuc.Visible = True
                        Me.txtNombre.Text = Me.cbPagar.Text.ToUpper
                        Me.cbPagar.SelectedValue = 0
                        Me.cbPagar1.SelectedValue = 0
                        Me.cbPagar.Text = Me.txtNombre.Text
                    Else
                        Dim f As New frmAgregarProveedorQuick()
                        f.WindowState = FormWindowState.Normal
                        f.StartPosition = FormStartPosition.CenterScreen

                        f.txtNombre.Text = Me.cbPagar.Text.ToUpper
                        cbPagar.Text = cbPagar.Text.ToUpper

                        f.ShowDialog()

                        Me.cbPagar.DataSource = Proveedores.PagarList().Tables("Proveedores")
                        Me.cbPagar.ValueMember = "Codigo"
                        Me.cbPagar.DisplayMember = "Nombre"

                        Me.cbPagar1.DataSource = Proveedores.PagarList1().Tables("Proveedores")
                        Me.cbPagar1.ValueMember = "Codigo"
                        Me.cbPagar1.DisplayMember = "Nombre"

                        cbPagar.SelectedValue = f.txtCodigo.Text
                        Me.cbPagar1.SelectedIndex = Me.cbPagar.SelectedIndex
                        Me.txtNombre.Text = f.txtNombre.Text.ToUpper

                        Me.etRuc.Visible = False
                        Me.txtRuc.Visible = False
                    End If
                    Exit Sub
                End If
            End If

            Me.cbPagar.Refresh()
        End Sub

        Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
            'If Guardar() = False Then
            '    Exit Sub
            'End If

            'Dim ValorLetras As String = Me.etMontoLetras.Text
            'Dim fReportes As New frmReportes()

            'Dim rFactura As New rptComprobanteCheque()
            'rFactura.SetDataSource(Comprobantes.ImprimirCombrobante(NoComprob, PeriodosDB.Activo(Me.dtpFecha.Value), ValorLetras, Me.dtpFecha.Value, CDbl(Me.txtMonto.Text)))
            'fReportes.crvReportes.ReportSource = rFactura

            'Me.txtDocumento.Text = ""
            'Me.txtMonto.Text = "0.00"
            'Me.cbPagar.SelectedValue = 0
            'Me.txtNombre.Text = ""
            'Me.txtConcepto.Text = ""

            'Me.etMontoLetras.Text = r.Letras(CDbl(Me.txtMonto.Text))

            'dsCB = CatBancos.CatalogoBancosXCuenta(Me.cbBancos.SelectedValue)
            'Me.txtCheque.Text = CatBancos.GetCheque(dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Banco"), dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Numero_Cuenta")).ToString
            'Me.etBalance.Text = CDbl(Comprobantes.SaldoxCuenta(Me.cbBancos.SelectedValue, VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.Value))).ToString(Round)

            'fReportes.Show()
        End Sub

        Private Sub dgCatalogo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCatalogo.DoubleClick
            'Dim f As New frmNuevaCuentaQuick()
            'Nuevo = "SI"
            'f.ShowDialog()
            'Me.dgCatalogo.Item(Me.dgCatalogo.CurrentRowIndex, 0) = f.txtCodigo.Text
            'Me.dgCatalogo.Item(Me.dgCatalogo.CurrentRowIndex, 1) = f.txtCodigo.Text & " - " & f.txtNombre.Text
            'Me.dgCatalogo.Item(Me.dgCatalogo.CurrentRowIndex, 2) = f.txtNombre.Text

        End Sub

        Private Sub frmChequesInss_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
            Dim f As frmInssPagar = f.Instance
            f.dgPlanillas.DataSource = VB.SysContab.PeriodoNominaDB.InssPagar().Tables(0)
        End Sub

    End Class

End Namespace
