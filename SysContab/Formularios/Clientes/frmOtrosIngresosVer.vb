Imports System
Imports System.Data
Imports System.Data.SqlClient

Namespace DataGridTextBoxCombo
    Public Class frmOtrosIngresosVer
        Inherits DevExpress.XtraEditors.XtraForm

        Private Shared ChildInstance As frmOtrosIngresosVer = Nothing

        Public Shared Function Instance() As frmOtrosIngresosVer
            If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
                ChildInstance = New frmOtrosIngresosVer()
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
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents cmdRecalcular As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents etRuc As System.Windows.Forms.Label
        Friend WithEvents txtRuc As System.Windows.Forms.TextBox
        Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cbPagar2 As System.Windows.Forms.ComboBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents chkEfectivo As System.Windows.Forms.CheckBox
        Friend WithEvents chkCheque As System.Windows.Forms.CheckBox
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents txtFactura As System.Windows.Forms.TextBox
        Friend WithEvents txtRecibo As System.Windows.Forms.TextBox
        Friend WithEvents chkRecibo As System.Windows.Forms.CheckBox
        Friend WithEvents etFecha As System.Windows.Forms.Label
        Friend WithEvents etPeriodo As System.Windows.Forms.Label
        Friend WithEvents etComprobante As System.Windows.Forms.Label
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.cbBancos = New System.Windows.Forms.ComboBox()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.chkRecibo = New System.Windows.Forms.CheckBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.txtFactura = New System.Windows.Forms.TextBox()
            Me.chkCheque = New System.Windows.Forms.CheckBox()
            Me.chkEfectivo = New System.Windows.Forms.CheckBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.etRuc = New System.Windows.Forms.Label()
            Me.txtRuc = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.cbPagar1 = New System.Windows.Forms.ComboBox()
            Me.etInicio = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtCheque = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtMonto = New System.Windows.Forms.TextBox()
            Me.cbPagar = New System.Windows.Forms.ComboBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtConcepto = New System.Windows.Forms.TextBox()
            Me.cbTipoComp = New System.Windows.Forms.ComboBox()
            Me.cbPagar2 = New System.Windows.Forms.ComboBox()
            Me.txtRecibo = New System.Windows.Forms.TextBox()
            Me.etPeriodo = New System.Windows.Forms.Label()
            Me.etFecha = New System.Windows.Forms.Label()
            Me.etComprobante = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtDocumento = New System.Windows.Forms.TextBox()
            Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.etBalance = New System.Windows.Forms.Label()
            Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
            Me.dgCatalogo = New System.Windows.Forms.DataGrid()
            Me.cmdRecalcular = New DevExpress.XtraEditors.SimpleButton()
            Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'cbBancos
            '
            Me.cbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbBancos.Location = New System.Drawing.Point(112, 9)
            Me.cbBancos.Name = "cbBancos"
            Me.cbBancos.Size = New System.Drawing.Size(480, 21)
            Me.cbBancos.TabIndex = 0
            '
            'Label25
            '
            Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label25.Location = New System.Drawing.Point(24, 9)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(80, 25)
            Me.Label25.TabIndex = 143
            Me.Label25.Text = "Caja:"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.chkRecibo)
            Me.GroupBox1.Controls.Add(Me.Label11)
            Me.GroupBox1.Controls.Add(Me.txtFactura)
            Me.GroupBox1.Controls.Add(Me.chkCheque)
            Me.GroupBox1.Controls.Add(Me.chkEfectivo)
            Me.GroupBox1.Controls.Add(Me.Label10)
            Me.GroupBox1.Controls.Add(Me.etRuc)
            Me.GroupBox1.Controls.Add(Me.txtRuc)
            Me.GroupBox1.Controls.Add(Me.Label9)
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
            Me.GroupBox1.Controls.Add(Me.txtRecibo)
            Me.GroupBox1.Controls.Add(Me.etPeriodo)
            Me.GroupBox1.Controls.Add(Me.etFecha)
            Me.GroupBox1.Controls.Add(Me.etComprobante)
            Me.GroupBox1.Location = New System.Drawing.Point(8, 34)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1000, 199)
            Me.GroupBox1.TabIndex = 144
            Me.GroupBox1.TabStop = False
            '
            'chkRecibo
            '
            Me.chkRecibo.Checked = True
            Me.chkRecibo.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkRecibo.ForeColor = System.Drawing.Color.Black
            Me.chkRecibo.Location = New System.Drawing.Point(760, 70)
            Me.chkRecibo.Name = "chkRecibo"
            Me.chkRecibo.Size = New System.Drawing.Size(72, 26)
            Me.chkRecibo.TabIndex = 166
            Me.chkRecibo.Text = "Recibo"
            Me.chkRecibo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label11
            '
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label11.Location = New System.Drawing.Point(728, 44)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(104, 26)
            Me.Label11.TabIndex = 165
            Me.Label11.Text = "Factura:"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtFactura
            '
            Me.txtFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFactura.Location = New System.Drawing.Point(840, 44)
            Me.txtFactura.MaxLength = 13
            Me.txtFactura.Name = "txtFactura"
            Me.txtFactura.Size = New System.Drawing.Size(152, 20)
            Me.txtFactura.TabIndex = 164
            '
            'chkCheque
            '
            Me.chkCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkCheque.ForeColor = System.Drawing.Color.Black
            Me.chkCheque.Location = New System.Drawing.Point(920, 97)
            Me.chkCheque.Name = "chkCheque"
            Me.chkCheque.Size = New System.Drawing.Size(72, 25)
            Me.chkCheque.TabIndex = 163
            Me.chkCheque.Text = "Cheque"
            Me.chkCheque.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'chkEfectivo
            '
            Me.chkEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkEfectivo.ForeColor = System.Drawing.Color.Black
            Me.chkEfectivo.Location = New System.Drawing.Point(840, 97)
            Me.chkEfectivo.Name = "chkEfectivo"
            Me.chkEfectivo.Size = New System.Drawing.Size(72, 25)
            Me.chkEfectivo.TabIndex = 162
            Me.chkEfectivo.Text = "Efectivo"
            '
            'Label10
            '
            Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label10.Location = New System.Drawing.Point(720, 97)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(112, 25)
            Me.Label10.TabIndex = 161
            Me.Label10.Text = "Forma de Pago:"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etRuc
            '
            Me.etRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etRuc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etRuc.Location = New System.Drawing.Point(256, 74)
            Me.etRuc.Name = "etRuc"
            Me.etRuc.Size = New System.Drawing.Size(80, 26)
            Me.etRuc.TabIndex = 160
            Me.etRuc.Text = "RUC/Cédula:"
            Me.etRuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtRuc
            '
            Me.txtRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRuc.Location = New System.Drawing.Point(344, 74)
            Me.txtRuc.MaxLength = 50
            Me.txtRuc.Name = "txtRuc"
            Me.txtRuc.Size = New System.Drawing.Size(240, 20)
            Me.txtRuc.TabIndex = 159
            '
            'Label9
            '
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label9.Location = New System.Drawing.Point(592, 106)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(40, 26)
            Me.Label9.TabIndex = 158
            Me.Label9.Text = "Tipo:"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Label9.Visible = False
            '
            'cbPagar1
            '
            Me.cbPagar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbPagar1.Location = New System.Drawing.Point(608, 17)
            Me.cbPagar1.Name = "cbPagar1"
            Me.cbPagar1.Size = New System.Drawing.Size(80, 21)
            Me.cbPagar1.TabIndex = 156
            Me.cbPagar1.Visible = False
            '
            'etInicio
            '
            Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etInicio.Location = New System.Drawing.Point(592, 52)
            Me.etInicio.Name = "etInicio"
            Me.etInicio.Size = New System.Drawing.Size(16, 26)
            Me.etInicio.TabIndex = 155
            Me.etInicio.Text = "1"
            Me.etInicio.Visible = False
            '
            'Label5
            '
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label5.Location = New System.Drawing.Point(728, 131)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(104, 26)
            Me.Label5.TabIndex = 152
            Me.Label5.Text = "No. de Cheque:"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtCheque
            '
            Me.txtCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCheque.Location = New System.Drawing.Point(840, 131)
            Me.txtCheque.MaxLength = 13
            Me.txtCheque.Name = "txtCheque"
            Me.txtCheque.Size = New System.Drawing.Size(152, 20)
            Me.txtCheque.TabIndex = 3
            '
            'Label4
            '
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label4.Location = New System.Drawing.Point(16, 44)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(64, 26)
            Me.Label4.TabIndex = 150
            Me.Label4.Text = "Nombre:"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtNombre
            '
            Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombre.Location = New System.Drawing.Point(104, 44)
            Me.txtNombre.MaxLength = 60
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(480, 20)
            Me.txtNombre.TabIndex = 2
            '
            'Label3
            '
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(16, 74)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(64, 26)
            Me.Label3.TabIndex = 148
            Me.Label3.Text = "Monto:"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtMonto
            '
            Me.txtMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMonto.Location = New System.Drawing.Point(104, 74)
            Me.txtMonto.MaxLength = 13
            Me.txtMonto.Name = "txtMonto"
            Me.txtMonto.Size = New System.Drawing.Size(136, 20)
            Me.txtMonto.TabIndex = 5
            Me.txtMonto.Text = "0.00"
            '
            'cbPagar
            '
            Me.cbPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbPagar.Location = New System.Drawing.Point(104, 17)
            Me.cbPagar.Name = "cbPagar"
            Me.cbPagar.Size = New System.Drawing.Size(480, 21)
            Me.cbPagar.TabIndex = 1
            '
            'Label1
            '
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(16, 17)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(72, 26)
            Me.Label1.TabIndex = 145
            Me.Label1.Text = "A Cobrar a:"
            '
            'Label2
            '
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(728, 17)
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
            Me.dtpFecha.Location = New System.Drawing.Point(840, 17)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
            Me.dtpFecha.TabIndex = 4
            Me.dtpFecha.Value = New Date(2006, 8, 10, 10, 38, 43, 562)
            '
            'Label6
            '
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(16, 106)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(72, 26)
            Me.Label6.TabIndex = 152
            Me.Label6.Text = "Concepto:"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtConcepto
            '
            Me.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtConcepto.Location = New System.Drawing.Point(104, 106)
            Me.txtConcepto.MaxLength = 100
            Me.txtConcepto.Multiline = True
            Me.txtConcepto.Name = "txtConcepto"
            Me.txtConcepto.Size = New System.Drawing.Size(480, 52)
            Me.txtConcepto.TabIndex = 6
            '
            'cbTipoComp
            '
            Me.cbTipoComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbTipoComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbTipoComp.Location = New System.Drawing.Point(640, 106)
            Me.cbTipoComp.Name = "cbTipoComp"
            Me.cbTipoComp.Size = New System.Drawing.Size(48, 21)
            Me.cbTipoComp.TabIndex = 151
            Me.cbTipoComp.Visible = False
            '
            'cbPagar2
            '
            Me.cbPagar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbPagar2.Location = New System.Drawing.Point(608, 44)
            Me.cbPagar2.Name = "cbPagar2"
            Me.cbPagar2.Size = New System.Drawing.Size(80, 21)
            Me.cbPagar2.TabIndex = 157
            Me.cbPagar2.Visible = False
            '
            'txtRecibo
            '
            Me.txtRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRecibo.Location = New System.Drawing.Point(840, 70)
            Me.txtRecibo.MaxLength = 13
            Me.txtRecibo.Name = "txtRecibo"
            Me.txtRecibo.Size = New System.Drawing.Size(152, 20)
            Me.txtRecibo.TabIndex = 155
            '
            'etPeriodo
            '
            Me.etPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etPeriodo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etPeriodo.Location = New System.Drawing.Point(616, 57)
            Me.etPeriodo.Name = "etPeriodo"
            Me.etPeriodo.Size = New System.Drawing.Size(40, 25)
            Me.etPeriodo.TabIndex = 190
            Me.etPeriodo.Text = "Per"
            Me.etPeriodo.Visible = False
            '
            'etFecha
            '
            Me.etFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etFecha.Location = New System.Drawing.Point(656, 57)
            Me.etFecha.Name = "etFecha"
            Me.etFecha.Size = New System.Drawing.Size(48, 25)
            Me.etFecha.TabIndex = 191
            Me.etFecha.Text = "Fecha"
            Me.etFecha.Visible = False
            '
            'etComprobante
            '
            Me.etComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etComprobante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etComprobante.Location = New System.Drawing.Point(616, 82)
            Me.etComprobante.Name = "etComprobante"
            Me.etComprobante.Size = New System.Drawing.Size(56, 26)
            Me.etComprobante.TabIndex = 189
            Me.etComprobante.Text = "Comp"
            Me.etComprobante.Visible = False
            '
            'Label7
            '
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label7.Location = New System.Drawing.Point(746, 396)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(120, 26)
            Me.Label7.TabIndex = 154
            Me.Label7.Text = "No. Documento:"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Label7.Visible = False
            '
            'txtDocumento
            '
            Me.txtDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDocumento.Location = New System.Drawing.Point(576, 402)
            Me.txtDocumento.MaxLength = 60
            Me.txtDocumento.Name = "txtDocumento"
            Me.txtDocumento.Size = New System.Drawing.Size(136, 20)
            Me.txtDocumento.TabIndex = 153
            Me.txtDocumento.Visible = False
            '
            'cmdAceptar
            '
            Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdAceptar.Appearance.Options.UseFont = True
            Me.cmdAceptar.Location = New System.Drawing.Point(345, 402)
            Me.cmdAceptar.Name = "cmdAceptar"
            Me.cmdAceptar.Size = New System.Drawing.Size(72, 26)
            Me.cmdAceptar.TabIndex = 8
            Me.cmdAceptar.Text = "&Guardar"
            Me.cmdAceptar.Visible = False
            '
            'Label8
            '
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label8.Location = New System.Drawing.Point(600, 9)
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
            Me.etBalance.Location = New System.Drawing.Point(672, 9)
            Me.etBalance.Name = "etBalance"
            Me.etBalance.Size = New System.Drawing.Size(200, 25)
            Me.etBalance.TabIndex = 147
            Me.etBalance.Text = "0"
            Me.etBalance.Visible = False
            '
            'cmdSalir
            '
            Me.cmdSalir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdSalir.Appearance.Options.UseFont = True
            Me.cmdSalir.Location = New System.Drawing.Point(936, 402)
            Me.cmdSalir.Name = "cmdSalir"
            Me.cmdSalir.Size = New System.Drawing.Size(72, 26)
            Me.cmdSalir.TabIndex = 11
            Me.cmdSalir.Text = "&Salir"
            '
            'dgCatalogo
            '
            Me.dgCatalogo.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
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
            Me.dgCatalogo.Location = New System.Drawing.Point(8, 198)
            Me.dgCatalogo.Name = "dgCatalogo"
            Me.dgCatalogo.ParentRowsBackColor = System.Drawing.Color.LightGray
            Me.dgCatalogo.ParentRowsForeColor = System.Drawing.Color.Black
            Me.dgCatalogo.SelectionBackColor = System.Drawing.Color.Firebrick
            Me.dgCatalogo.SelectionForeColor = System.Drawing.Color.White
            Me.dgCatalogo.Size = New System.Drawing.Size(1000, 198)
            Me.dgCatalogo.TabIndex = 7
            '
            'cmdRecalcular
            '
            Me.cmdRecalcular.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdRecalcular.Appearance.Options.UseFont = True
            Me.cmdRecalcular.Location = New System.Drawing.Point(189, 402)
            Me.cmdRecalcular.Name = "cmdRecalcular"
            Me.cmdRecalcular.Size = New System.Drawing.Size(72, 26)
            Me.cmdRecalcular.TabIndex = 10
            Me.cmdRecalcular.Text = "&Recalcular"
            Me.cmdRecalcular.Visible = False
            '
            'cmdImprimir
            '
            Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdImprimir.Appearance.Options.UseFont = True
            Me.cmdImprimir.Location = New System.Drawing.Point(267, 402)
            Me.cmdImprimir.Name = "cmdImprimir"
            Me.cmdImprimir.Size = New System.Drawing.Size(72, 26)
            Me.cmdImprimir.TabIndex = 9
            Me.cmdImprimir.Text = "&Imprimir"
            Me.cmdImprimir.Visible = False
            '
            'frmOtrosIngresosVer
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(1016, 439)
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
            Me.Name = "frmOtrosIngresosVer"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.dgCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region
        Dim WithEvents tCust As DataTable
        Private WithEvents myDataSet As DataSet
        Dim ds As DataSet

        Dim WithEvents Codigo1 As DataGridComboBoxColumn
        Dim WithEvents Codigo As DataGridComboBoxColumn
        Dim WithEvents Descripcion As DataGridComboBoxColumn
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
        Dim Config As New VB.SysContab.ConfiguracionDB()
        Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails()
        Dim compDet As New VB.SysContab.ComprobantesDetails()
        'Dim dsCB As DataSet

        Dim NoComprob As Double

        Dim d As Integer
        Dim dd As String
        Dim Digitos As Integer
        Dim Recibo As String
        Dim Fechas As New VB.SysContab.FechasdeTrabajo

        Private Sub frmOtrosIngresosVer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

            r.FormularioColor(Me)

            ConfigDetalles = Config.GetConfigDetails
            Digitos = ConfigDetalles.ReciboDigitos

            For d = 0 To Digitos - 1
                dd = dd & "0"
            Next

            Me.cbBancos.DataSource = Catalogo.CatalogoList("A", 1).Tables("CATALOGO")
            Me.cbBancos.ValueMember = "Cuenta"
            Me.cbBancos.DisplayMember = "Nombre"

            Me.cbPagar.DataSource = Clientes.GetList().Tables("Clientes") 'Proveedores.PagarList().Tables("Proveedores")
            Me.cbPagar.ValueMember = "Codigo"
            Me.cbPagar.DisplayMember = "Nombre"

            ''If Clientes.GenerarRecibo.Tables("Cobros").Rows.Count = 0 Then
            ''    txtRecibo.Text = Format(ConfigDetalles.ReciboNumero, dd)
            ''Else
            ''    txtRecibo.Text = Format(Clientes.GenerarRecibo.Tables("Cobros").Rows(0).Item("Recibo") + 1, dd)
            ''End If

            'Me.cbPagar1.DataSource = Proveedores.PagarList1().Tables("Proveedores")
            'Me.cbPagar1.ValueMember = "Codigo"
            'Me.cbPagar1.DisplayMember = "Nombre"

            'Me.cbPagar2.DataSource = Clientes.GetList().Tables("Clientes") 'Proveedores.PagarList().Tables("Proveedores")
            'Me.cbPagar2.ValueMember = "Codigo"
            'Me.cbPagar2.DisplayMember = "Nombre"

            cbTipoComp.DataSource = Comprobantes.TiposComprobantesCheques().Tables("TipoComprobantes")
            cbTipoComp.ValueMember = "TipComp_Id"
            cbTipoComp.DisplayMember = "TipComp_Nombre"

            Me.chkEfectivo.Checked = True

            'Me.dtpFecha.MinDate = Fechas.FechaMinima 'VB.SysContab.PeriodosDB.GetDetails(VB.SysContab.PeriodosDB.Activo).Inicio
            'Me.dtpFecha.MaxDate = Fechas.FechaMaxima 'VB.SysContab.PeriodosDB.GetDetails(VB.SysContab.PeriodosDB.Activo).Final
            'Dim Fecha As Date

            'Fecha = CDate(r.Fecha)
            'If Me.dtpFecha.MaxDate > Fecha Then
            '    Me.dtpFecha.Value = Fecha
            'Else
            'End If

            ''' Falta Me.cbBancos.SelectedValue = VB.SysContab.ComprobanteDB.ChequesCuentaBanco(Me.etComprobante.Text, Me.etPeriodo.Text, Me.etFecha.Text)

            compDet = Comprobantes.GetComprobanteDetails(Me.etComprobante.Text, Me.etPeriodo.Text, Me.etFecha.Text)

            Dim Registros As Integer
            Registros = Comprobantes.ComprobanteAnularBuscar(Me.etComprobante.Text, Me.etPeriodo.Text, Me.etFecha.Text)

            If Registros > 0 Then
                Me.dgCatalogo.ReadOnly = True
                Me.txtConcepto.ReadOnly = True
                Me.dtpFecha.Enabled = False
                Me.cbTipoComp.Enabled = False
                Me.cmdAceptar.Enabled = False
                Me.cmdAceptar.Enabled = False
                Me.cmdRecalcular.Enabled = False

            Else
                Me.dgCatalogo.ReadOnly = False
            End If

            ds = compDet.Detalles

            MakeDataSet()
            Me.dgCatalogo.SetDataBinding(myDataSet, "Articulos")
            AddCustomDataTableStyle()

            Me.txtCheque.Text = compDet.Cheque
            Me.txtFactura.Text = compDet.Factura1
            Me.txtRecibo.Text = compDet.Recibo
            Me.dtpFecha.Value = compDet.Fecha
            Recibo = Me.txtRecibo.Text

            If compDet.Pagara = "0" Then
                Me.etRuc.Visible = False
                Me.txtRuc.Visible = False
            Else
                Me.cbPagar.SelectedValue = compDet.Pagara
                Me.cbPagar1.SelectedValue = compDet.Pagara
            End If

            If compDet.Cheque = "0" Or compDet.Cheque = "" Then
                Me.chkCheque.Checked = False
                Me.chkEfectivo.Checked = True
                Me.txtCheque.Enabled = False
            Else
                Me.chkCheque.Checked = True
                Me.chkEfectivo.Checked = False
            End If

            Me.txtNombre.Text = compDet.ChequeNombre

            Me.txtConcepto.Text = compDet.Concepto

            LeaveCommit = False
            BuscarCombo = False

            r.ComboAutoComplete(Me.cbPagar)
            r.ComboAutoComplete(Codigo.ColumnComboBox)
            r.ComboAutoComplete(Descripcion.ColumnComboBox)

        End Sub

        Private Sub cbPagar_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPagar.SelectedValueChanged
            If Me.etInicio.Text = "1" Then
                Exit Sub
            End If

            'Me.cbPagar1.SelectedIndex = Me.cbPagar.SelectedIndex
            'Me.cbPagar2.SelectedIndex = Me.cbPagar.SelectedIndex

            'Me.txtNombre.Text = Me.cbPagar1.Text
            Me.txtNombre.Text = Me.cbPagar.Text

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

            Me.txtDocumento.Text = ""
            Me.txtMonto.Text = "0.00"
            Me.cbPagar.SelectedValue = 0
            Me.txtNombre.Text = ""
            Me.txtConcepto.Text = ""
            Me.txtCheque.Text = ""
            Me.txtFactura.Text = ""
            If Me.chkRecibo.Checked = True Then
                txtRecibo.Text = Format(Clientes.GenerarRecibo.Tables("Cobros").Rows(0).Item("Recibo") + 1, dd)
            Else
                Me.txtRecibo.Text = ""
            End If

            'Me.etMontoLetras.Text = r.ConversionDecimales(CDbl(Me.txtMonto.Text))

            'dsCB = CatBancos.CatalogoBancosXCuenta(Me.cbBancos.SelectedValue)
            'Me.txtCheque.Text = CatBancos.GetCheque(dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Banco"), dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Numero_Cuenta")).ToString
            Me.etBalance.Text = CDbl(Comprobantes.SaldoxCuenta(Me.cbBancos.SelectedValue, VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.Value))).ToString(Round)
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

                'dsCB = CatBancos.CatalogoBancosXCuenta(Me.cbBancos.SelectedValue)
                'Me.txtCheque.Text = CatBancos.GetCheque(dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Banco"), dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Numero_Cuenta")).ToString
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

            Dim j As Integer
            'DebitoMonto = 0
            'CreditoMonto = 0

            For j = 0 To ds.Tables("ComprobantesDetalles").Rows.Count - 1
                If ds.Tables("ComprobantesDetalles").Rows(j).Item("Detalle") = 0 Then
                    Me.cbBancos.SelectedValue = ds.Tables("ComprobantesDetalles").Rows(j).Item("Cuenta")
                    Me.txtMonto.Text = CDbl(ds.Tables("ComprobantesDetalles").Rows(j).Item("Monto")).ToString(Round)
                Else
                    newRow1 = tCust.NewRow
                    newRow1("Codigo") = ds.Tables("ComprobantesDetalles").Rows(j).Item("Cuenta") & " - " & ds.Tables("ComprobantesDetalles").Rows(j).Item("Nombre")
                    tCust.Rows.Add(newRow1)

                    newRow1("Codigo1") = ds.Tables("ComprobantesDetalles").Rows(j).Item("Cuenta")
                    newRow1("Descripcion") = ds.Tables("ComprobantesDetalles").Rows(j).Item("Nombre")
                    newRow1("Concepto") = ds.Tables("ComprobantesDetalles").Rows(j).Item("Concepto")

                    If ds.Tables("ComprobantesDetalles").Rows(j).Item("Proceso") = "Crédito" Then
                        newRow1("Monto") = CDbl(CDbl(ds.Tables("ComprobantesDetalles").Rows(j).Item("Monto")) * CDbl(ds.Tables("ComprobantesDetalles").Rows(j).Item("TasaCambio"))).ToString(Round)
                    ElseIf ds.Tables("ComprobantesDetalles").Rows(j).Item("Proceso") = "Débito" Then
                        newRow1("Monto") = "-" & CDbl(CDbl(ds.Tables("ComprobantesDetalles").Rows(j).Item("Monto")) * CDbl(ds.Tables("ComprobantesDetalles").Rows(j).Item("TasaCambio"))).ToString(Round)
                    End If
                End If
            Next

        End Sub

        Private Sub AddCustomDataTableStyle()

            Dim ts1 As DataGridTableStyle
            ts1 = New DataGridTableStyle()
            ts1.MappingName = "Articulos"
            ts1.AlternatingBackColor = Color.LightBlue

            Dim colCount As Integer
            colCount = 0

            Codigo1 = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))
            Codigo1.MappingName = "Codigo1"
            Codigo1.HeaderText = ""
            Codigo1.Width = 0

            ts1.GridColumnStyles.Add(Codigo1)
            ts1.PreferredRowHeight = (Codigo1.ColumnComboBox.Height + 3)

            Codigo1.NullText = ""

            colCount = (colCount + 1)

            Codigo = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))
            Codigo.MappingName = "Codigo"
            Codigo.HeaderText = "Cuenta"
            Codigo.Width = 350

            ts1.GridColumnStyles.Add(Codigo)
            ts1.PreferredRowHeight = (Codigo.ColumnComboBox.Height + 3)

            Codigo.NullText = ""

            colCount = (colCount + 1)

            Descripcion = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))
            Descripcion.MappingName = "Descripcion"
            Descripcion.HeaderText = "Nombre"
            Descripcion.Width = 300

            ts1.GridColumnStyles.Add(Descripcion)
            ts1.PreferredRowHeight = (Descripcion.ColumnComboBox.Height + 3)

            Descripcion.NullText = ""
            colCount = (colCount + 1)

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


            Dim i As Long
            ds = Catalogo.CatalogoList1("A")
            For i = 0 To ds.Tables("CATALOGO").Rows.Count - 1
                Codigo1.ColumnComboBox.Items.Add(ds.Tables("CATALOGO").Rows(i).Item("Cuenta"))
                Codigo.ColumnComboBox.Items.Add(ds.Tables("CATALOGO").Rows(i).Item("Cuenta") & " - " & ds.Tables("CATALOGO").Rows(i).Item("Nombre"))
                Descripcion.ColumnComboBox.Items.Add(ds.Tables("CATALOGO").Rows(i).Item("Nombre"))
            Next

            Codigo.ColumnComboBox.DropDownStyle = ComboBoxStyle.DropDown

            Descripcion.ColumnComboBox.DropDownStyle = ComboBoxStyle.DropDown

            ts1.GridLineColor = Color.FromArgb(70, 130, 180)
            ts1.AllowSorting = False
            ts1.HeaderFont = Me.dgCatalogo.HeaderFont
            ts1.HeaderBackColor = Color.LightSteelBlue
            Me.dgCatalogo.CaptionVisible = False

            Me.dgCatalogo.TableStyles.Clear()
            Me.dgCatalogo.TableStyles.Add(ts1)

        End Sub

        Public Sub MyComboValueChanged(ByVal rowChanging As Integer, ByVal newValue As Object)
            Console.WriteLine("index changed {0} {1}", rowChanging, newValue)

            Try
                If Indice >= 0 Then
                    If tCust.Rows.Count < rowChanging + 1 Then
                        Dim newRow1 As DataRow
                        newRow1 = tCust.NewRow
                        newRow1("Codigo") = Codigo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows.Add(newRow1)

                        tCust.Rows(rowChanging)("Codigo1") = Codigo1.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Descripcion") = Descripcion.ColumnComboBox.Items.Item(Indice)

                        If rowChanging = 0 And tCust.Rows.Count = 1 Then
                            tCust.Rows(rowChanging)("Monto") = CDbl(Me.txtMonto.Text).ToString(Round)
                        End If
                    Else
                        tCust.Rows(rowChanging)("Codigo1") = Codigo1.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Codigo") = Codigo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Descripcion") = Descripcion.ColumnComboBox.Items.Item(Indice)

                    End If

                End If
            Catch ex As Exception
                MsgBox(ex.Message & "MyComboValueChanged")
            End Try

        End Sub

        Private Sub Evento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
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
            'Me.etMontoLetras.Text = r.ConversionDecimales(CDbl(Me.txtMonto.Text))
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
            'Me.etMontoLetras.Text = r.ConversionDecimales(CDbl(Me.txtMonto.Text))
        End Sub

        Private Function Guardar() As Boolean
            If Me.cbBancos.SelectedValue = "0" Then
                MsgBox("Seleccione la Caja", MsgBoxStyle.Information)
                Me.cbBancos.Focus()
                Return False
                Exit Function
            End If

            If Trim(Me.txtNombre.Text) = "" Then
                MsgBox("Introduzca nombre de quien realiza el pago", MsgBoxStyle.Information)
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

            If Me.chkCheque.Checked = True Then
                If Trim(Me.txtCheque.Text) = "" Then
                    MsgBox("Introduzca el No. de Cheque", MsgBoxStyle.Information)
                    Me.txtCheque.Focus()
                    Return False
                    Exit Function
                End If
            Else
                Me.txtCheque.Text = "0"
            End If

            If Me.chkRecibo.Checked = True Then
                If Trim(Me.txtRecibo.Text) = "" Then
                    MsgBox("Introduzca el No. de Recibo", MsgBoxStyle.Information)
                    Me.txtRecibo.Focus()
                    Return False
                    Exit Function
                End If
            Else
                Me.txtRecibo.Text = "0"
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

            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction()

            Dim CompNumero As Double

            Try
                Dim DC As String
                ' Tipo = 3 Otros Ingresos
                'NoComprob = Comprobantes.AddComprobante(Me.cbTipoComp.SelectedValue, 1, txtConcepto.Text, VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MonedaBase, PeriodosDB.Activo, dtpFecha.Value, 0, Me.txtNombre.Text, False, Me.cbPagar.SelectedValue, Me.txtRuc.Text, 3, Me.txtFactura.Text, VB.SysContab.Rutinas.Fecha, 0)
                DC = "D"
                Comprobantes.ComprobanteDetalleDelete(Me.etComprobante.Text, Me.etPeriodo.Text, Me.etFecha.Text)
                CompNumero = Comprobantes.ComprobanteUpdate(Me.etComprobante.Text, Me.cbTipoComp.SelectedValue, 1, Me.txtConcepto.Text, VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MonedaBase, Me.etPeriodo.Text, Me.dtpFecha.Value, 0, False, Me.etFecha.Text, Me.txtRuc.Text, Me.txtNombre.Text, Me.cbPagar.SelectedValue, Me.txtFactura.Text, r.Fecha, 0, 3)

                Comprobantes.AddComprobanteDetalles(CompNumero, Me.cbBancos.SelectedValue, "", Me.txtMonto.Text, Me.txtCheque.Text, Me.cbTipoComp.SelectedValue, DC, 0, Me.txtRecibo.Text, Me.dtpFecha.Value, 0)
                'Comprobantes.AddComprobanteDetalles1(CompNumero, Me.cbBancos.SelectedValue, "", Me.txtMonto.Text, Me.txtCheque.Text, Me.cbTipoComp.SelectedValue, DC, 0, 0, Me.etPeriodo.Text, Me.dtpFecha.Value, 0)

                If Trim(Me.txtRecibo.Text) = "" Then
                    Me.txtRecibo.Text = "0"
                End If

                For i = 0 To tCust.Rows.Count - 1
                    'If VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo1")).Tables("Catalogo").Rows(0).Item("Clase") = 1 Then
                    '    DC = "C"
                    'ElseIf VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo1")).Tables("Catalogo").Rows(0).Item("Clase") = 2 And CDbl(tCust.Rows(i)("Monto")) >= 0 Then
                    '    DC = "C"
                    'ElseIf VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo1")).Tables("Catalogo").Rows(0).Item("Clase") = 2 And CDbl(tCust.Rows(i)("Monto")) < 0 Then
                    '    DC = "D"
                    'End If
                    'cambiado abr 12 2007
                    'If VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo1")).Tables("Catalogo").Rows(0).Item("Clase") = 1 And CDbl(tCust.Rows(i)("Monto")) >= 0 Then
                    '    DC = "C"
                    'ElseIf VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo1")).Tables("Catalogo").Rows(0).Item("Clase") = 1 And CDbl(tCust.Rows(i)("Monto")) < 0 Then
                    '    DC = "D"
                    'ElseIf VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo1")).Tables("Catalogo").Rows(0).Item("Clase") = 2 And CDbl(tCust.Rows(i)("Monto")) >= 0 Then
                    '    DC = "C"
                    'ElseIf VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo1")).Tables("Catalogo").Rows(0).Item("Clase") = 2 And CDbl(tCust.Rows(i)("Monto")) < 0 Then
                    '    DC = "D"
                    'End If
                    If CDbl(tCust.Rows(i)("Monto")) >= 0 Then
                        DC = "D"
                    ElseIf CDbl(tCust.Rows(i)("Monto")) < 0 Then
                        DC = "C"
                    End If
                    Comprobantes.AddComprobanteDetalles(CompNumero, tCust.Rows(i)("Codigo1"), tCust.Rows(i)("Concepto").ToString, Math.Abs(CDbl(tCust.Rows(i)("Monto"))), Me.txtCheque.Text, Me.cbTipoComp.SelectedValue, DC, 0, Me.txtRecibo.Text, Me.dtpFecha.Value, 1)
                Next

                VB.SysContab.Rutinas.okTransaccion()

            Catch Mensaje As Exception
                VB.SysContab.Rutinas.ErrorTransaccion()
                MsgBox(Mensaje.Message)
                Return False
                Exit Function
            End Try

            'Me.txtCheque.Text = "WHERE " & Me.txtCheque.Text & " LIKE " & Me.txtCheque.Text & "*"

            Me.Close()
            'MakeDataSet()
            'Me.dgCatalogo.SetDataBinding(myDataSet, "Articulos")
            'AddCustomDataTableStyle()

            'r.ComboAutoComplete(Codigo.ColumnComboBox)
            'r.ComboAutoComplete(Descripcion.ColumnComboBox)

            Return True
        End Function

        Private Sub cbPagar_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPagar.Leave
            'Dim Cliente As Boolean
            'Dim Proveedor As Boolean
            'Cliente = False
            'Proveedor = False

            'If Trim(Me.cbPagar.Text) = "" Then
            '    Exit Sub
            'End If

            ''If Me.cbPagar.Text = Me.cbPagar2.Text Then
            ''    Exit Sub
            ''End If

            'If Clientes.ClientesBuscar(Trim(Me.cbPagar.Text)).Tables("Clientes").Rows.Count = 0 Then
            '    Cliente = True
            'End If

            'If Proveedores.ProveedoresBuscar(Trim(Me.cbPagar.Text)).Tables("Proveedores").Rows.Count = 0 Then
            '    Proveedor = True
            '    Me.cbPagar.Text = Me.cbPagar.Text.ToUpper

            '    If Cliente = True And Proveedor = True Then
            '        If (MsgBox("Proveedor no existe. Desea agregarlo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)) = MsgBoxResult.No Then
            '            Me.etRuc.Visible = True
            '            Me.txtRuc.Visible = True
            '            Me.txtNombre.Text = Me.cbPagar.Text.ToUpper
            '            Me.cbPagar.SelectedValue = 0
            '            'Me.cbPagar1.SelectedValue = 0
            '            Me.cbPagar.Text = Me.txtNombre.Text
            '        Else
            '            Dim f As New frmAgregarProveedorQuick()
            '            f.WindowState = FormWindowState.Normal
            '            f.StartPosition = FormStartPosition.CenterScreen

            '            f.txtNombre.Text = Me.cbPagar.Text.ToUpper
            '            cbPagar.Text = cbPagar.Text.ToUpper

            '            f.ShowDialog()

            '            Me.cbPagar.DataSource = Proveedores.PagarList().Tables("Proveedores")
            '            Me.cbPagar.ValueMember = "Codigo"
            '            Me.cbPagar.DisplayMember = "Nombre"

            '            'Me.cbPagar1.DataSource = Proveedores.PagarList1().Tables("Proveedores")
            '            'Me.cbPagar1.ValueMember = "Codigo"
            '            'Me.cbPagar1.DisplayMember = "Nombre"

            '            cbPagar.SelectedValue = f.txtCodigo.Text
            '            'Me.cbPagar1.SelectedIndex = Me.cbPagar.SelectedIndex
            '            Me.txtNombre.Text = f.txtNombre.Text.ToUpper

            '            Me.etRuc.Visible = False
            '            Me.txtRuc.Visible = False
            '        End If
            '        Exit Sub
            '    End If
            'End If

            If Trim(Me.cbPagar.Text) = "" Then
                Me.txtRuc.Text = ""
                Exit Sub
            End If

            If Clientes.ClientesBuscar(Trim(Me.cbPagar.Text)).Tables("Clientes").Rows.Count = 0 Then
                Me.cbPagar.Text = Me.cbPagar.Text.ToUpper
                txtRuc.Text = ""

                If (MsgBox("Cliente no existe. ¿Desea agregarlo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)) = MsgBoxResult.No Then
                    'Cod_Cliente = "9999" 'Clientes Varios
                    'DetallesCliente = VB.SysContab.ClientesDB.GetDetails(Cod_Cliente)
                    'DetallesVendedor = Vendedor.GetDetails(0)
                    'DetallesVendedor = Vendedor.GetDetails(DetallesCliente.Vendedor)

                    Me.etRuc.Visible = True
                    Me.txtRuc.Visible = True
                    Me.txtNombre.Text = Me.cbPagar.Text.ToUpper
                    Me.cbPagar.SelectedValue = 0
                    'Me.cbPagar1.SelectedValue = 0
                    Me.cbPagar.Text = Me.txtNombre.Text
                Else
                    Dim f As New frmAgregarClienteQuick()
                    f.WindowState = FormWindowState.Normal
                    f.StartPosition = FormStartPosition.CenterScreen
                    NombreCliente = Me.cbPagar.Text.ToUpper
                    'cbCliente.Text = cbCliente.Text.ToUpper

                    f.ShowDialog()

                    Me.cbPagar.DataSource = Clientes.GetList().Tables("Clientes")
                    Me.cbPagar.ValueMember = "Codigo"
                    Me.cbPagar.DisplayMember = "Nombre"

                    Me.cbPagar.SelectedValue = f.txtCodigo.Text

                    'Me.cbPagar1.SelectedIndex = Me.cbPagar.SelectedIndex
                    Me.txtNombre.Text = f.txtNombre.Text.ToUpper

                    Me.etRuc.Visible = False
                    Me.txtRuc.Visible = False

                End If

                Exit Sub

            End If

            Me.cbPagar.Refresh()
        End Sub

        Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
            'Exit Sub
            'If Guardar() = False Then
            '    Exit Sub
            'End If

            ''Dim ValorLetras As String = Me.etMontoLetras.Text 
            'Dim fReportes As New frmReportes()

            'Dim rFactura As New rptComprobanteCheque()
            ''rFactura.SetDataSource(Comprobantes.ImprimirCombrobante(NoComprob, PeriodosDB.Activo, ValorLetras, Me.dtpFecha.Value, CDbl(Me.txtMonto.Text)))
            'fReportes.crvReportes.ReportSource = rFactura

            'Me.txtDocumento.Text = ""
            'Me.txtMonto.Text = "0.00"
            'Me.cbPagar.SelectedValue = 0
            'Me.txtNombre.Text = ""
            'Me.txtConcepto.Text = ""

            ''Me.etMontoLetras.Text = r.ConversionDecimales(CDbl(Me.txtMonto.Text))

            ''dsCB = CatBancos.CatalogoBancosXCuenta(Me.cbBancos.SelectedValue)
            ''Me.txtCheque.Text = CatBancos.GetCheque(dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Banco"), dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Numero_Cuenta")).ToString
            'Me.etBalance.Text = CDbl(Comprobantes.SaldoxCuenta(Me.cbBancos.SelectedValue, VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.Value))).ToString(Round)
            'fReportes.Show()
        End Sub

        Private Sub dgCatalogo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCatalogo.DoubleClick
            Dim f As New frmNuevaCuentaQuick()
            Nuevo = "SI"
            f.ShowDialog()
            Me.dgCatalogo.Item(Me.dgCatalogo.CurrentRowIndex, 0) = f.txtCodigo.Text
            Me.dgCatalogo.Item(Me.dgCatalogo.CurrentRowIndex, 1) = f.txtCodigo.Text & " - " & f.txtNombre.Text
            Me.dgCatalogo.Item(Me.dgCatalogo.CurrentRowIndex, 2) = f.txtNombre.Text
        End Sub

        Private Sub chkEfectivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEfectivo.CheckedChanged
            If Me.chkEfectivo.Checked = True Then
                Me.chkCheque.Checked = False
                Me.txtCheque.Enabled = False
                Me.txtCheque.Text = ""
            Else
                Me.chkCheque.Checked = True
            End If
        End Sub

        Private Sub chkCheque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCheque.CheckedChanged
            If Me.chkCheque.Checked = True Then
                Me.chkEfectivo.Checked = False
                Me.txtCheque.Enabled = True
            Else
                Me.chkEfectivo.Checked = True
                Me.txtCheque.Text = ""
            End If
        End Sub

        Private Sub txtRecibo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRecibo.KeyPress
            If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
                If Char.IsDigit(e.KeyChar) = False Then
                    e.Handled = True
                    Exit Sub
                End If
            End If
        End Sub

        Private Sub chkRecibo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRecibo.CheckedChanged
            If Me.chkRecibo.Checked = True Then
                Me.txtRecibo.Enabled = True
                'Me.txtRecibo.Text = Recibo
                If Clientes.GenerarRecibo.Tables("Cobros").Rows.Count = 0 Then
                    txtRecibo.Text = Format(ConfigDetalles.ReciboNumero, dd)
                Else
                    txtRecibo.Text = Format(Clientes.GenerarRecibo.Tables("Cobros").Rows(0).Item("Recibo") + 1, dd)
                End If
            Else
                Me.txtRecibo.Enabled = False
                Me.txtRecibo.Text = ""
            End If
        End Sub
    End Class

End Namespace
