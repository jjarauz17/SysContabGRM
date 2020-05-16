Imports System
Imports System.Data
Imports System.Data.SqlClient

Namespace DataGridTextBoxCombo
    Public Class frmChequesEditarEC
        Inherits DevExpress.XtraEditors.XtraForm

        Private Shared ChildInstance As frmChequesEditarEC = Nothing

        Public Shared Function Instance() As frmChequesEditarEC
            If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
                ChildInstance = New frmChequesEditarEC()
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
        Friend WithEvents etPeriodo As System.Windows.Forms.Label
        Friend WithEvents etFecha As System.Windows.Forms.Label
        Friend WithEvents etComprobante As System.Windows.Forms.Label
        Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents etRuc As System.Windows.Forms.Label
        Friend WithEvents txtRuc As System.Windows.Forms.TextBox
        Friend WithEvents cmdImprimirComp As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents etMoneda As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents txtMontoMonedaBase As System.Windows.Forms.TextBox
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents etTotal As System.Windows.Forms.Label
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.cbBancos = New System.Windows.Forms.ComboBox
            Me.Label25 = New System.Windows.Forms.Label
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            Me.Label10 = New System.Windows.Forms.Label
            Me.txtMontoMonedaBase = New System.Windows.Forms.TextBox
            Me.etRuc = New System.Windows.Forms.Label
            Me.txtRuc = New System.Windows.Forms.TextBox
            Me.etFecha = New System.Windows.Forms.Label
            Me.etPeriodo = New System.Windows.Forms.Label
            Me.etComprobante = New System.Windows.Forms.Label
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
            Me.etMoneda = New System.Windows.Forms.Label
            Me.Label7 = New System.Windows.Forms.Label
            Me.txtDocumento = New System.Windows.Forms.TextBox
            Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
            Me.Label8 = New System.Windows.Forms.Label
            Me.etBalance = New System.Windows.Forms.Label
            Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
            Me.dgCatalogo = New System.Windows.Forms.DataGrid
            Me.cmdRecalcular = New DevExpress.XtraEditors.SimpleButton
            Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
            Me.cmdImprimirComp = New DevExpress.XtraEditors.SimpleButton
            Me.Label11 = New System.Windows.Forms.Label
            Me.etTotal = New System.Windows.Forms.Label
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'cbBancos
            '
            Me.cbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbBancos.Location = New System.Drawing.Point(160, 9)
            Me.cbBancos.Name = "cbBancos"
            Me.cbBancos.Size = New System.Drawing.Size(480, 21)
            Me.cbBancos.TabIndex = 0
            '
            'Label25
            '
            Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label25.Location = New System.Drawing.Point(8, 9)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(128, 25)
            Me.Label25.TabIndex = 143
            Me.Label25.Text = "Cuentas de Bancos:"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.Label10)
            Me.GroupBox1.Controls.Add(Me.txtMontoMonedaBase)
            Me.GroupBox1.Controls.Add(Me.etRuc)
            Me.GroupBox1.Controls.Add(Me.txtRuc)
            Me.GroupBox1.Controls.Add(Me.etFecha)
            Me.GroupBox1.Controls.Add(Me.etPeriodo)
            Me.GroupBox1.Controls.Add(Me.etComprobante)
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
            Me.GroupBox1.Controls.Add(Me.etMoneda)
            Me.GroupBox1.Location = New System.Drawing.Point(8, 34)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1000, 199)
            Me.GroupBox1.TabIndex = 144
            Me.GroupBox1.TabStop = False
            '
            'Label10
            '
            Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label10.Location = New System.Drawing.Point(664, 86)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(136, 26)
            Me.Label10.TabIndex = 165
            Me.Label10.Text = "Monto Moneda Base:"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtMontoMonedaBase
            '
            Me.txtMontoMonedaBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMontoMonedaBase.Location = New System.Drawing.Point(808, 86)
            Me.txtMontoMonedaBase.MaxLength = 13
            Me.txtMontoMonedaBase.Name = "txtMontoMonedaBase"
            Me.txtMontoMonedaBase.ReadOnly = True
            Me.txtMontoMonedaBase.Size = New System.Drawing.Size(184, 20)
            Me.txtMontoMonedaBase.TabIndex = 164
            Me.txtMontoMonedaBase.Text = "0.00"
            '
            'etRuc
            '
            Me.etRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etRuc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etRuc.Location = New System.Drawing.Point(664, 129)
            Me.etRuc.Name = "etRuc"
            Me.etRuc.Size = New System.Drawing.Size(80, 26)
            Me.etRuc.TabIndex = 163
            Me.etRuc.Text = "RUC/Cédula:"
            Me.etRuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtRuc
            '
            Me.txtRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRuc.Location = New System.Drawing.Point(752, 129)
            Me.txtRuc.MaxLength = 50
            Me.txtRuc.Name = "txtRuc"
            Me.txtRuc.Size = New System.Drawing.Size(240, 20)
            Me.txtRuc.TabIndex = 162
            '
            'etFecha
            '
            Me.etFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etFecha.Location = New System.Drawing.Point(432, 78)
            Me.etFecha.Name = "etFecha"
            Me.etFecha.Size = New System.Drawing.Size(48, 25)
            Me.etFecha.TabIndex = 161
            Me.etFecha.Text = "Fecha"
            Me.etFecha.Visible = False
            '
            'etPeriodo
            '
            Me.etPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etPeriodo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etPeriodo.Location = New System.Drawing.Point(384, 78)
            Me.etPeriodo.Name = "etPeriodo"
            Me.etPeriodo.Size = New System.Drawing.Size(40, 25)
            Me.etPeriodo.TabIndex = 160
            Me.etPeriodo.Text = "Per"
            Me.etPeriodo.Visible = False
            '
            'etComprobante
            '
            Me.etComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etComprobante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etComprobante.Location = New System.Drawing.Point(520, 78)
            Me.etComprobante.Name = "etComprobante"
            Me.etComprobante.Size = New System.Drawing.Size(56, 25)
            Me.etComprobante.TabIndex = 159
            Me.etComprobante.Text = "Comp"
            Me.etComprobante.Visible = False
            '
            'Label9
            '
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label9.Location = New System.Drawing.Point(528, 26)
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
            Me.etMontoLetras.Location = New System.Drawing.Point(152, 129)
            Me.etMontoLetras.Name = "etMontoLetras"
            Me.etMontoLetras.Size = New System.Drawing.Size(504, 35)
            Me.etMontoLetras.TabIndex = 157
            '
            'cbPagar1
            '
            Me.cbPagar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbPagar1.Location = New System.Drawing.Point(664, 17)
            Me.cbPagar1.Name = "cbPagar1"
            Me.cbPagar1.Size = New System.Drawing.Size(56, 21)
            Me.cbPagar1.TabIndex = 156
            Me.cbPagar1.Visible = False
            '
            'etInicio
            '
            Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etInicio.Location = New System.Drawing.Point(488, 78)
            Me.etInicio.Name = "etInicio"
            Me.etInicio.Size = New System.Drawing.Size(24, 25)
            Me.etInicio.TabIndex = 155
            Me.etInicio.Text = "1"
            Me.etInicio.Visible = False
            '
            'Label5
            '
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label5.Location = New System.Drawing.Point(728, 9)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(104, 25)
            Me.Label5.TabIndex = 152
            Me.Label5.Text = "No. de Cheque:"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtCheque
            '
            Me.txtCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCheque.Location = New System.Drawing.Point(840, 9)
            Me.txtCheque.MaxLength = 13
            Me.txtCheque.Name = "txtCheque"
            Me.txtCheque.Size = New System.Drawing.Size(152, 20)
            Me.txtCheque.TabIndex = 3
            '
            'Label4
            '
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label4.Location = New System.Drawing.Point(16, 52)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(128, 26)
            Me.Label4.TabIndex = 150
            Me.Label4.Text = "Cheque a Nombre de:"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtNombre
            '
            Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombre.Location = New System.Drawing.Point(152, 52)
            Me.txtNombre.MaxLength = 60
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(480, 20)
            Me.txtNombre.TabIndex = 2
            '
            'Label3
            '
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(16, 95)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(104, 26)
            Me.Label3.TabIndex = 148
            Me.Label3.Text = "Monto:"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtMonto
            '
            Me.txtMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMonto.Location = New System.Drawing.Point(152, 95)
            Me.txtMonto.MaxLength = 13
            Me.txtMonto.Name = "txtMonto"
            Me.txtMonto.Size = New System.Drawing.Size(136, 20)
            Me.txtMonto.TabIndex = 5
            Me.txtMonto.Text = "0.00"
            '
            'cbPagar
            '
            Me.cbPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbPagar.Location = New System.Drawing.Point(152, 9)
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
            Me.Label1.Size = New System.Drawing.Size(64, 26)
            Me.Label1.TabIndex = 145
            Me.Label1.Text = "Pagar a:"
            '
            'Label2
            '
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(728, 43)
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
            Me.dtpFecha.Location = New System.Drawing.Point(840, 43)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
            Me.dtpFecha.TabIndex = 4
            Me.dtpFecha.Value = New Date(2006, 8, 10, 10, 38, 43, 562)
            '
            'Label6
            '
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(16, 164)
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
            Me.txtConcepto.Location = New System.Drawing.Point(152, 164)
            Me.txtConcepto.MaxLength = 100
            Me.txtConcepto.Name = "txtConcepto"
            Me.txtConcepto.Size = New System.Drawing.Size(840, 20)
            Me.txtConcepto.TabIndex = 6
            '
            'cbTipoComp
            '
            Me.cbTipoComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbTipoComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbTipoComp.Location = New System.Drawing.Point(584, 26)
            Me.cbTipoComp.Name = "cbTipoComp"
            Me.cbTipoComp.Size = New System.Drawing.Size(40, 21)
            Me.cbTipoComp.TabIndex = 151
            Me.cbTipoComp.Visible = False
            '
            'etMoneda
            '
            Me.etMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etMoneda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etMoneda.Location = New System.Drawing.Point(296, 95)
            Me.etMoneda.Name = "etMoneda"
            Me.etMoneda.Size = New System.Drawing.Size(360, 26)
            Me.etMoneda.TabIndex = 162
            Me.etMoneda.Text = "Moneda"
            Me.etMoneda.Visible = False
            '
            'Label7
            '
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label7.Location = New System.Drawing.Point(469, 321)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(120, 25)
            Me.Label7.TabIndex = 154
            Me.Label7.Text = "No. Documento:"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Label7.Visible = False
            '
            'txtDocumento
            '
            Me.txtDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDocumento.Location = New System.Drawing.Point(605, 321)
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
            Me.cmdAceptar.Location = New System.Drawing.Point(13, 430)
            Me.cmdAceptar.Name = "cmdAceptar"
            Me.cmdAceptar.Size = New System.Drawing.Size(72, 26)
            Me.cmdAceptar.TabIndex = 8
            Me.cmdAceptar.Text = "&Aceptar"
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
            Me.cmdSalir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdSalir.Appearance.Options.UseFont = True
            Me.cmdSalir.Location = New System.Drawing.Point(405, 430)
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
            Me.dgCatalogo.Location = New System.Drawing.Point(8, 233)
            Me.dgCatalogo.Name = "dgCatalogo"
            Me.dgCatalogo.ParentRowsBackColor = System.Drawing.Color.LightGray
            Me.dgCatalogo.ParentRowsForeColor = System.Drawing.Color.Black
            Me.dgCatalogo.SelectionBackColor = System.Drawing.Color.Firebrick
            Me.dgCatalogo.SelectionForeColor = System.Drawing.Color.White
            Me.dgCatalogo.Size = New System.Drawing.Size(1000, 191)
            Me.dgCatalogo.TabIndex = 7
            '
            'cmdRecalcular
            '
            Me.cmdRecalcular.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdRecalcular.Appearance.Options.UseFont = True
            Me.cmdRecalcular.Location = New System.Drawing.Point(93, 430)
            Me.cmdRecalcular.Name = "cmdRecalcular"
            Me.cmdRecalcular.Size = New System.Drawing.Size(72, 26)
            Me.cmdRecalcular.TabIndex = 9
            Me.cmdRecalcular.Text = "&Recalcular"
            '
            'cmdImprimir
            '
            Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdImprimir.Appearance.Options.UseFont = True
            Me.cmdImprimir.Location = New System.Drawing.Point(173, 430)
            Me.cmdImprimir.Name = "cmdImprimir"
            Me.cmdImprimir.Size = New System.Drawing.Size(72, 26)
            Me.cmdImprimir.TabIndex = 10
            Me.cmdImprimir.Text = "&Imprimir"
            '
            'cmdImprimirComp
            '
            Me.cmdImprimirComp.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdImprimirComp.Appearance.Options.UseFont = True
            Me.cmdImprimirComp.Location = New System.Drawing.Point(253, 430)
            Me.cmdImprimirComp.Name = "cmdImprimirComp"
            Me.cmdImprimirComp.Size = New System.Drawing.Size(144, 26)
            Me.cmdImprimirComp.TabIndex = 155
            Me.cmdImprimirComp.Text = "Imprimir &Comprobante"
            Me.cmdImprimirComp.Visible = False
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label11.Location = New System.Drawing.Point(632, 439)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(56, 17)
            Me.Label11.TabIndex = 1016
            Me.Label11.Text = "Total:"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'etTotal
            '
            Me.etTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTotal.ForeColor = System.Drawing.Color.Maroon
            Me.etTotal.Location = New System.Drawing.Point(704, 439)
            Me.etTotal.Name = "etTotal"
            Me.etTotal.Size = New System.Drawing.Size(88, 17)
            Me.etTotal.TabIndex = 1015
            Me.etTotal.Text = "0.00"
            Me.etTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'frmChequesEditarEC
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(1016, 469)
            Me.Controls.Add(Me.Label11)
            Me.Controls.Add(Me.etTotal)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.txtDocumento)
            Me.Controls.Add(Me.cmdImprimirComp)
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
            Me.Name = "frmChequesEditarEC"
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

        Dim TasaCambio As New VB.SysContab.Tasa_CambioDB()
        Dim CatalogoBancos As New VB.SysContab.Catalogo_BancosDB()
        Dim Proveedores As New VB.SysContab.ProveedoresDB()
        Dim Catalogo As New VB.SysContab.CatalogoDB()
        Private Comprobantes As New VB.SysContab.ComprobanteDB()
        Dim compDet As New VB.SysContab.ComprobantesDetails()
        Dim PeriodosDB As New VB.SysContab.PeriodosDB()
        Dim ProveedoresDetalles As New VB.SysContab.ProveedoresDetails()
        'Dim Bancos As New VB.SysContab.BancosDB()
        'Dim BancosDetalles As New VB.SysContab.BancosDetails()
        Dim CatBancos As New VB.SysContab.Catalogo_BancosDB()
        Dim r As New VB.SysContab.Rutinas()
        Dim dsCB As DataSet

        Dim ds1 As DataSet

        Dim ts As Double

        Public Shared StrFechaComp As String

        Private Sub frmChequesEditarEC_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

            cbTipoComp.DataSource = Comprobantes.TiposComprobantesCheques().Tables("TipoComprobantes")
            cbTipoComp.ValueMember = "TipComp_Id"
            cbTipoComp.DisplayMember = "TipComp_Nombre"

            'Me.dtpFecha.MinDate = VB.SysContab.PeriodosDB.GetDetails(Me.etPeriodo.Text).Inicio
            'Me.dtpFecha.MaxDate = VB.SysContab.PeriodosDB.GetDetails(Me.etPeriodo.Text).Final

            Me.cbBancos.SelectedValue = VB.SysContab.ComprobanteDB.ChequesCuentaBanco(Me.etComprobante.Text, Me.etPeriodo.Text, etFecha.Text)

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
                'Me.etAnulado.Visible = True
                'compDet = Comprobantes.GetComprobanteAnuladoDetails(Me.etComprobante.Text, Me.etPeriodo.Text, Me.etFecha.Text)
            Else
                Me.dgCatalogo.ReadOnly = False
            End If

            ds1 = compDet.Detalles

            'Me.txtCheque.Text = CatBancos.GetCheque(Registro, dgCatalogoBancos.Item(dgCatalogoBancos.CurrentRowIndex, 3))

            MakeDataSet()
            Me.dgCatalogo.SetDataBinding(myDataSet, "Articulos")
            AddCustomDataTableStyle()

            Me.etMontoLetras.Text = r.Letras(CDbl(Me.txtMonto.Text))
            Me.txtCheque.Text = compDet.Cheque
            Me.cbTipoComp.SelectedValue = compDet.Tipo1
            Me.txtConcepto.Text = compDet.Concepto
            Me.txtRuc.Text = compDet.Ruc
            Me.dtpFecha.Text = compDet.Fecha

            If compDet.Pagara = "" Then
            Else
                Me.cbPagar.SelectedValue = compDet.Pagara
                Me.cbPagar1.SelectedValue = compDet.Pagara
            End If

            Me.txtNombre.Text = compDet.ChequeNombre

            Saldo()

            ProveedorDetalle()

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

            Me.cbPagar1.SelectedIndex = Me.cbPagar.SelectedIndex

            Me.txtNombre.Text = Me.cbPagar1.Text

            ProveedorDetalle()

            'If tCust.Rows.Count = 0 Then
            '    Dim newRow1 As DataRow
            '    newRow1 = tCust.NewRow
            '    newRow1("Codigo") = Me.cbPagar.SelectedValue
            '    ' Add the row to the Customers table.
            '    tCust.Rows.Add(newRow1)

            '    tCust.Rows(0)("Descripcion") = Me.cbPagar.Text
            '    tCust.Rows(0)("Monto") = Me.txtMonto.Text
            '    'tCust.Rows(rowChanging)("Articulo") = Articulo.ColumnComboBox.Items.Item(Indice)
            '    'tCust.Rows(rowChanging)("Cantidad") = 1
            '    'tCust.Rows(rowChanging)("Precio") = CDbl(DetallesProducto.Costo).ToString(Round)
            '    'tCust.Rows(rowChanging)("Tipo") = ItemTipo.ColumnComboBox.Items.Item(Indice)
            'Else
            '    tCust.Rows(0)("Codigo") = Me.cbPagar.SelectedValue
            '    tCust.Rows(0)("Descripcion") = Me.cbPagar.Text
            '    tCust.Rows(0)("Monto") = Me.txtMonto.Text
            '    'tCust.Rows(rowChanging)("Articulo") = Articulo.ColumnComboBox.Items.Item(Indice)
            '    'tCust.Rows(rowChanging)("Precio") = CDbl(DetallesProducto.Costo).ToString(Round)
            '    'tCust.Rows(rowChanging)("Tipo") = ItemTipo.ColumnComboBox.Items.Item(Indice)
            'End If
        End Sub

        Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
            'Dim conexion As New VB.SysContab.Rutinas()

            If Me.cbBancos.SelectedValue = "0" Then
                MsgBox("Seleccione el Banco", MsgBoxStyle.Information)
                Me.cbBancos.Focus()
                Exit Sub
            End If

            'If Me.cbPagar.SelectedValue = "0" Or Me.cbPagar.SelectedValue = Nothing Then
            '    MsgBox("Seleccione a quien se va a pagar", MsgBoxStyle.Information)
            '    Me.cbPagar.Focus()
            '    Exit Sub
            'End If

            If Trim(Me.txtNombre.Text) = "" Then
                MsgBox("Introduzca a nombre de quien es el cheque", MsgBoxStyle.Information)
                Me.txtNombre.Focus()
                Me.txtNombre.SelectAll()
                Exit Sub
            End If

            If Trim(Me.txtMonto.Text) = "" Then
                MsgBox("Introduzca el monto", MsgBoxStyle.Information)
                Me.txtMonto.Focus()
                Me.txtMonto.SelectAll()
                Exit Sub
            End If

            If Me.cbTipoComp.SelectedValue = "0" Or Me.cbTipoComp.SelectedValue = Nothing Then
                MsgBox("Seleccione el Tipo de Comprobante", MsgBoxStyle.Information)
                Me.cbTipoComp.Focus()
                Exit Sub
            End If

            If tCust.Rows.Count = 0 Then
                MsgBox("Seleccione al menos cuenta", MsgBoxStyle.Information)
                Me.dgCatalogo.Focus()
                Exit Sub
            End If


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

            If CDbl(CDbl(Total).ToString(Round)) > CDbl(CDbl(Me.txtMontoMonedaBase.Text).ToString(Round)) Then
                MsgBox("La suma del detalle en las Lineas es mayor que el Monto a Pagar", MsgBoxStyle.Information)
                Me.dgCatalogo.Focus()
                Exit Sub
            ElseIf CDbl(CDbl(Total).ToString(Round)) < CDbl(CDbl(Me.txtMontoMonedaBase.Text).ToString(Round)) Then
                MsgBox("La suma del detalle en las Lineas es menor que el Monto a Pagar", MsgBoxStyle.Information)
                Me.dgCatalogo.Focus()
                Exit Sub
            End If
            'if me.

            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction()

            'Cambiar igual que el comprobante cuando el numero es de otro mes
            Dim CompNumero As Double

            Try
                Dim DC As String
                Comprobantes.ComprobanteDetalleDelete(Me.etComprobante.Text, Me.etPeriodo.Text, Me.etFecha.Text)
                CompNumero = Comprobantes.ComprobanteUpdate(Me.etComprobante.Text, Me.cbTipoComp.SelectedValue, ts, Me.txtConcepto.Text, VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MonedaBase, Me.etPeriodo.Text, Me.dtpFecha.Value, 0, False, Me.etFecha.Text, Me.txtRuc.Text, Me.txtNombre.Text, Me.cbPagar.SelectedValue, "", r.Fecha, 0, 2)
                'Dim NoComprob As Double = Comprobantes.AddComprobante(Me.cbTipoComp.SelectedValue, 1, txtConcepto.Text, VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MonedaBase, PeriodosDB.Activo, dtpFecha.Value, 0, Me.txtNombre.Text, False, Me.cbPagar.SelectedValue)
                DC = "C"

                'If Trim(Me.txtCheque.Text) <> "" Then
                '    Comprobantes.ActualizarCheque(Me.cbBancos.SelectedValue, Me.txtCheque.Text)
                'End If

                Comprobantes.AddComprobanteDetalles1(CompNumero, Me.cbBancos.SelectedValue, "", Me.txtMontoMonedaBase.Text, Me.txtCheque.Text, Me.cbTipoComp.SelectedValue, DC, 0, 0, Me.etPeriodo.Text, Me.dtpFecha.Value, 0)
                'Comprobantes.AddCatalogoTrans(Me.cbBancos.SelectedValue, 0, Me.txtMonto.Text, "")
                'Catalogo.ActualizarCuentas(Me.cbBancos.SelectedValue, Me.txtMonto.Text, 1)

                For i = 0 To tCust.Rows.Count - 1

                    'Dim Debe As Double = 0
                    'Dim Haber As Double = 0
                    Dim Opera As Integer

                    'Estos comentarios estaban antes de eliminar el comentario marcado con (********)
                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''             

                    'If tCust.Rows(i)("Descuento").ToString = "Débito" Then
                    '    Debe = tCust.Rows(i)("Precio")
                    '    DC = "D"
                    '    Opera = 1
                    'End If

                    'If tCust.Rows(i)("Descuento").ToString = "Crédito" Then
                    '    Haber = tCust.Rows(i)("Precio")
                    '    DC = "C"
                    '    Opera = 2
                    'End If

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    '(*********)
                    'If VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo1")).Tables("Catalogo").Rows(0).Item("Clase") = 1 And CDbl(tCust.Rows(i)("Monto")) >= 0 Then
                    '    DC = "D"
                    '    Opera = 1
                    'ElseIf VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo1")).Tables("Catalogo").Rows(0).Item("Clase") = 1 And CDbl(tCust.Rows(i)("Monto")) < 0 Then
                    '    DC = "C"
                    '    Opera = 2
                    'ElseIf VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo1")).Tables("Catalogo").Rows(0).Item("Clase") = 2 And CDbl(tCust.Rows(i)("Monto")) >= 0 Then
                    '    DC = "D"
                    '    Opera = 1
                    'ElseIf VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo1")).Tables("Catalogo").Rows(0).Item("Clase") = 2 And CDbl(tCust.Rows(i)("Monto")) < 0 Then
                    '    DC = "C"
                    '    Opera = 2
                    'End If

                    If CDbl(tCust.Rows(i)("Monto")) >= 0 Then
                        DC = "D"
                        Opera = 1
                    ElseIf CDbl(tCust.Rows(i)("Monto")) < 0 Then
                        DC = "C"
                        Opera = 2
                    End If
                    'If CatalogoDB.GetDetails(tCust.Rows(i)("ArticuloCodigo")).Tipo = "A" Then

                    Comprobantes.AddComprobanteDetalles1(CompNumero, tCust.Rows(i)("Codigo1"), tCust.Rows(i)("Concepto").ToString, Math.Abs(CDbl(tCust.Rows(i)("Monto"))), Me.txtCheque.Text, Me.cbTipoComp.SelectedValue, DC, 0, 0, Me.etPeriodo.Text, Me.dtpFecha.Value, 1)
                    'Comprobantes.AddCatalogoTrans(tCust.Rows(i)("Codigo1"), tCust.Rows(i)("Monto"), 0, tCust.Rows(i)("Descripcion").ToString)
                    'Catalogo.ActualizarCuentas(tCust.Rows(i)("Codigo1"), tCust.Rows(i)("Monto"), Opera)
                    'Else
                    '    transaccionFacturas.Rollback()
                    '    MsgBox("No se ha creado el comprobante. Debe cambiar una cuenta de Tipo Mayor por auxiliares", MsgBoxStyle.Critical)
                    '    Exit Sub
                    'End If
                Next

                VB.SysContab.Rutinas.okTransaccion()

            Catch Mensaje As Exception
                VB.SysContab.Rutinas.ErrorTransaccion()
                MsgBox(Mensaje.Message)
                Exit Sub

            End Try


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

            'MakeDataSet()
            'Me.dgCatalogo.SetDataBinding(myDataSet, "Articulos")
            'AddCustomDataTableStyle()

            'r.ComboAutoComplete(Codigo.ColumnComboBox)
            'r.ComboAutoComplete(Descripcion.ColumnComboBox)

        End Sub

        Private Sub cbBancos_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbBancos.SelectedValueChanged
            If Me.etInicio.Text = "1" Then
                Exit Sub
            End If
            Saldo()
        End Sub

        Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
            Me.Close()
        End Sub

        Private Sub MakeDataSet()

            ' Create a DataSet.
            myDataSet = New DataSet("myDataSet")

            ' Create two DataTables.
            'Dim tCust As DataTable
            tCust = New DataTable("Articulos")

            ' Create two columns, and add them to the first table.

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

            For j = 0 To ds1.Tables("ComprobantesDetalles").Rows.Count - 1
                If ds1.Tables("ComprobantesDetalles").Rows(j).Item("Cuenta") = Me.cbBancos.SelectedValue Then
                    Me.txtMonto.Text = CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("Monto")).ToString(Round)
                Else
                    newRow1 = tCust.NewRow
                    newRow1("Codigo") = ds1.Tables("ComprobantesDetalles").Rows(j).Item("Cuenta") & " - " & ds1.Tables("ComprobantesDetalles").Rows(j).Item("Nombre")
                    tCust.Rows.Add(newRow1)

                    'tCust.Rows(j)("Codigo1") = ds1.Tables("ComprobantesDetalles").Rows(j).Item("Cuenta")
                    newRow1("Codigo1") = ds1.Tables("ComprobantesDetalles").Rows(j).Item("Cuenta")
                    newRow1("Descripcion") = ds1.Tables("ComprobantesDetalles").Rows(j).Item("Nombre")
                    newRow1("Concepto") = ds1.Tables("ComprobantesDetalles").Rows(j).Item("Concepto")

                    If ds1.Tables("ComprobantesDetalles").Rows(j).Item("Proceso") = "Débito" Then
                        newRow1("Monto") = CDbl(CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("Monto")) * CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("TasaCambio"))).ToString(Round)
                        'DebitoMonto = DebitoMonto + CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("Monto"))
                    ElseIf ds1.Tables("ComprobantesDetalles").Rows(j).Item("Proceso") = "Crédito" Then
                        newRow1("Monto") = "-" & CDbl(CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("Monto")) * CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("TasaCambio"))).ToString(Round)
                        'CreditoMonto = CreditoMonto + CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("Monto"))
                    End If

                    Total = Total + newRow1("Monto")

                    'Me.lblDebito.Text = DebitoMonto.ToString(Round)
                    'Me.lblCredito.Text = CreditoMonto.ToString(Round)

                    'tCust.Rows(j)("Proceso") = ds1.Tables("ComprobantesDetalles").Rows(j).Item("Proceso")
                End If
            Next
            Me.etTotal.Text = Total.ToString(Round)
        End Sub

        Private Sub AddCustomDataTableStyle()

            'STEP 1: Create a DataTable style object and set properties if required.
            Dim ts1 As DataGridTableStyle
            ts1 = New DataGridTableStyle()
            'specify the table from dataset (required step)
            ts1.MappingName = "Articulos"
            ' Set other properties (optional step)
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

            'Dim ArticuloCodigo As DataGridComboBoxColumn
            Codigo = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))
            Codigo.MappingName = "Codigo"
            Codigo.HeaderText = "Cuenta"
            Codigo.Width = 350
            'Codigo.ColumnComboBox.Font = Me.dgCatalogo.Font

            'AddHandler Codigo.ColumnComboBox.KeyDown, AddressOf Evento_KeyPress

            ts1.GridColumnStyles.Add(Codigo)
            ts1.PreferredRowHeight = (Codigo.ColumnComboBox.Height + 3)

            Codigo.NullText = ""

            colCount = (colCount + 1)

            'Dim Articulo As DataGridComboBoxColumn
            Descripcion = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))
            Descripcion.MappingName = "Descripcion"
            Descripcion.HeaderText = "Nombre"
            Descripcion.Width = 300

            'AddHandler descripcion.ColumnComboBox.KeyDown, AddressOf Evento_KeyPress

            ts1.GridColumnStyles.Add(Descripcion)
            ts1.PreferredRowHeight = (Descripcion.ColumnComboBox.Height + 3)

            Descripcion.NullText = ""
            colCount = (colCount + 1)

            'Dim Cantidad As DataGridTextBoxColumn
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

            'AddHandler Precio.TextBox.Leave, New EventHandler(AddressOf TextBoxPrecioLeaveHandler)

            ts1.GridColumnStyles.Add(Concepto)
            colCount = (colCount + 1)

            Concepto.NullText = ""


            'If Me.rbInventario.Checked = True Then
            '    BuscarCombo = False
            '    'txtFactura.Text = Facturas.OrdenCompraCCNumero
            '    dsItems = ArticulosCC.ArticulosCCList("", 0, 0, 0, 0)
            '    For i = 0 To dsItems.Tables("GruposCC").Rows.Count - 1
            '        ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("GruposCC").Rows(i).Item("Código"))
            '        Articulo.ColumnComboBox.Items.Add(dsItems.Tables("GruposCC").Rows(i).Item("Nombre"))
            '        ItemTipo.ColumnComboBox.Items.Add("I")
            '    Next
            'Else
            '    BuscarCombo = True
            '    'Me.txtFactura.Text = Facturas.Numero
            '    dsItems = Articulos.ProductosGetAll("P")
            '    For i = 0 To dsItems.Tables("Articulos").Rows.Count - 1
            '        ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Codigo"))
            '        Articulo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Nombre"))
            '        ItemTipo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Tipo"))
            '    Next
            'End If
            Dim i As Long
            ds = Catalogo.CatalogoList1("A")
            For i = 0 To ds.Tables("CATALOGO").Rows.Count - 1
                Codigo1.ColumnComboBox.Items.Add(ds.Tables("CATALOGO").Rows(i).Item("Cuenta"))
                Codigo.ColumnComboBox.Items.Add(ds.Tables("CATALOGO").Rows(i).Item("Cuenta") & " - " & ds.Tables("CATALOGO").Rows(i).Item("Nombre"))
                Descripcion.ColumnComboBox.Items.Add(ds.Tables("CATALOGO").Rows(i).Item("Nombre"))
            Next

            'Codigo.ColumnComboBox.Items.Add("1111 01 01")
            'Descripcion.ColumnComboBox.Items.Add("Esta es una prueba")

            Codigo.ColumnComboBox.DropDownStyle = ComboBoxStyle.DropDown
            'Codigo.ColumnComboBox.SelectedValue = 0

            Descripcion.ColumnComboBox.DropDownStyle = ComboBoxStyle.DropDown
            'Descripcion.ColumnComboBox.SelectedValue = 0

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            'STEP 6: Add the tablestyle to your datagrids tablestlye collection
            ts1.GridLineColor = Color.FromArgb(70, 130, 180)
            ts1.AllowSorting = False
            ts1.HeaderFont = Me.dgCatalogo.HeaderFont
            ts1.HeaderBackColor = Color.LightSteelBlue  'Color.LightBlue
            Me.dgCatalogo.CaptionVisible = False

            Me.dgCatalogo.TableStyles.Clear()
            Me.dgCatalogo.TableStyles.Add(ts1)

        End Sub

        Public Sub MyComboValueChanged(ByVal rowChanging As Integer, ByVal newValue As Object)
            Console.WriteLine("index changed {0} {1}", rowChanging, newValue)

            Try
                If Indice >= 0 Then
                    'DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(ArticuloCodigo.ColumnComboBox.Items.Item(Indice).ToString, ItemTipo.ColumnComboBox.Items.Item(Indice).ToString, EmpresaActual)

                    If tCust.Rows.Count < rowChanging + 1 Then
                        Dim newRow1 As DataRow
                        newRow1 = tCust.NewRow
                        newRow1("Codigo") = Codigo.ColumnComboBox.Items.Item(Indice)
                        ' Add the row to the Customers table.
                        tCust.Rows.Add(newRow1)

                        tCust.Rows(rowChanging)("Codigo1") = Codigo1.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Descripcion") = Descripcion.ColumnComboBox.Items.Item(Indice)
                        'tCust.Rows(rowChanging)("Articulo") = Articulo.ColumnComboBox.Items.Item(Indice)
                        'tCust.Rows(rowChanging)("Cantidad") = 1
                        'tCust.Rows(rowChanging)("Precio") = CDbl(DetallesProducto.Costo).ToString(Round)
                        'tCust.Rows(rowChanging)("Tipo") = ItemTipo.ColumnComboBox.Items.Item(Indice)
                    Else
                        tCust.Rows(rowChanging)("Codigo1") = Codigo1.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Codigo") = Codigo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Descripcion") = Descripcion.ColumnComboBox.Items.Item(Indice)
                        'tCust.Rows(rowChanging)("Articulo") = Articulo.ColumnComboBox.Items.Item(Indice)
                        'tCust.Rows(rowChanging)("Precio") = CDbl(DetallesProducto.Costo).ToString(Round)
                        'tCust.Rows(rowChanging)("Tipo") = ItemTipo.ColumnComboBox.Items.Item(Indice)
                    End If

                End If
            Catch ex As Exception
                MsgBox(ex.Message & "MyComboValueChanged")
            End Try

        End Sub

        Dim Total As Double
        Dim i As Integer
        Private Sub TextBoxMontoLeaveHandler(ByVal sender As Object, ByVal e As EventArgs)
            Try
                'Monto.TextBox.Text
                'microsoft.VisualBas
                Monto.TextBox.Text = CDbl(Monto.TextBox.Text).ToString(Round)
                Total = 0
                tCust.Rows(Me.dgCatalogo.CurrentRowIndex)("Monto") = CDbl(Monto.TextBox.Text).ToString(Round)

                For i = 0 To tCust.Rows.Count - 1
                    If tCust.Rows(i)("Monto") Is DBNull.Value Or tCust.Rows(i)("Monto").ToString = "" Then
                    Else
                        Total = Total + CDbl(tCust.Rows(i)("Monto"))
                    End If
                Next

                Me.etTotal.Text = Total.ToString(Round)
            Catch ex As Exception
                'MsgBox(ex.Message)
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

            If MonedaBase = dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("mon_codigo") Then
                'Moneda de la Cuenta = Moneda Base 
                Me.txtMontoMonedaBase.Text = Me.txtMonto.Text
                ts = 1
            Else
                'TasaCambioDia
                ts = TasaCambio.TasaCambioDia(Me.dtpFecha.Value.Day, Me.dtpFecha.Value.Month, Me.dtpFecha.Value.Year, MonedaBase, dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("mon_codigo"))
                Me.txtMontoMonedaBase.Text = Me.etTotal.Text 'CDbl(CDbl(Me.txtMonto.Text) * ts).ToString(Round)
            End If
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
                        Total = Total + (CDbl(tCust.Rows(i)("Monto")) / ts)
                    End If
                End If
            Next

            Me.txtMonto.Text = Total.ToString(Round)
            Me.etMontoLetras.Text = r.Letras(CDbl(Me.txtMonto.Text))
            Me.txtMontoMonedaBase.Text = Me.etTotal.Text 'CDbl(CDbl(Me.txtMonto.Text) * ts).ToString(Round)

        End Sub

        Private Sub Saldo()
            If Me.cbBancos.SelectedValue = "0" Then
                Me.Label8.Visible = False
                Me.etBalance.Text = 0
                Me.etBalance.Visible = False
                'Me.txtCheque.Text = ""
                Me.etMoneda.Visible = False
            Else
                Me.Label8.Visible = True
                Me.etBalance.Visible = True
                Me.etMoneda.Visible = True

                dsCB = CatBancos.CatalogoBancosXCuenta(Me.cbBancos.SelectedValue)

                'MsgBox(MonedaBase)
                If MonedaBase = dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("mon_codigo") Then
                    'Moneda de la Cuenta = Moneda Base 
                    Me.txtMontoMonedaBase.Text = Me.txtMonto.Text
                    ts = 1
                Else
                    'TasaCambioDia
                    ts = TasaCambio.TasaCambioDia(Me.dtpFecha.Value.Day, Me.dtpFecha.Value.Month, Me.dtpFecha.Value.Year, MonedaBase, dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("mon_codigo"))
                    Me.txtMontoMonedaBase.Text = Me.etTotal.Text 'CDbl(CDbl(Me.txtMonto.Text) * ts).ToString(Round)
                End If

                'BancosDetalles = Bancos.GetDetails(Me.cbBancos.SelectedValue)
                '
                'dsCB = CatBancos.CatalogoBancosXCuenta(Me.cbBancos.SelectedValue)
                'Me.txtCheque.Text = CatBancos.GetCheque(dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Banco"), dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Numero_Cuenta")).ToString
                Me.etBalance.Text = CDbl(Comprobantes.SaldoxCuenta(Me.cbBancos.SelectedValue, VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.Value))).ToString(Round)
                'Me.etBalance.Text = CDbl(Comprobantes.SaldoxCuenta(Me.cbBancos.SelectedValue)).ToString(Round)
                Me.etMoneda.Text = dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("mon_descripcion")
            End If
        End Sub

        Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
            Try
                Dim ValorLetras As String = Me.etMontoLetras.Text 'VB.SysContab.Rutinas.ConversionDecimales( CDbl(lblDebito.Text).ToString(Round))
                Dim fReportes As New frmReportes()
                'Dim P As New VB.SysContab.PeriodosDB()
                'If lblCheque.Text = "0" Then
                '    Dim rFactura As New rptComprobante()
                '    rFactura.SetDataSource(comp.ImprimirCombrobante(lblNoComprobante.Text, lblPeriodo.Text, ValorLetras, Me.txtFecha.Text))
                '    fReportes.crvReportes.ReportSource = rFactura
                'Else
                'Dim rFactura As New rptComprobanteCheque()

                'ChequeNombre1 = Paguese A
                'Text19 = Valor Número
                'Text20 = Valor Letras

                'If MonedaBase = dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("mon_codigo") Then
                '    Dim rFactura As New rptComprobanteCheque()
                '    rFactura.SetDataSource(Comprobantes.ImprimirCombrobante(Me.etComprobante.Text, Me.etPeriodo.Text, ValorLetras, Me.etFecha.Text, CDbl(Me.txtMonto.Text)))
                '    fReportes.crvReportes.ReportSource = rFactura
                '    fReportes.Show()
                'Else

                'Dim rFactura As New rptComprobanteCKDinamico()

                Dim rFactura As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                rFactura.Load(Application.StartupPath & "\Reportes\rptComprobanteCKDinamico.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

                'Dim rFactura As New rptComprobanteCheque()

                ''rFactura.ReportDefinition.ReportObjects.Item("CompFecha1").Top = CDbl(Me.txtVertical.Text) * 750 '- ((CDbl(Me.txtVertical.Text) * 750) * CDbl(Me.txtConcepto.Text))   'OK 0.12
                'rFactura.ReportDefinition.ReportObjects.Item("CompFecha1").Left = CDbl(Me.txtVertical.Text) * 650
                'rFactura.ReportDefinition.ReportObjects.Item("CompFecha1").Top = CDbl(Me.txtHorizontal.Text) * 750

                rFactura.SetDataSource(VB.SysContab.ComprobanteDB.ImprimirCombrobante(Me.etComprobante.Text, Me.etPeriodo.Text, ValorLetras, Me.etFecha.Text, CDbl(Me.txtMonto.Text)))
                fReportes.crvReportes.ReportSource = rFactura
                fReportes.Show()
                'End If             
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        '15.600
        '2.110
        Private Sub ProveedorDetalle()
            If Me.cbPagar.SelectedValue = 0 Then
                'Me.txtRuc.Text = ""
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

        Private Sub cmdImprimirComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimirComp.Click
            'Dim ValorLetras As String = Me.etMontoLetras.Text
            'Dim fReportes As New frmReportes
            'If EmpresaActual = 13 Then
            '    Dim rFactura As New rptComprobanteChequeSIMTESIS
            '    rFactura.SetDataSource(Comprobantes.ImprimirCombrobante(Me.etComprobante.Text, Me.etPeriodo.Text, ValorLetras, Me.etFecha.Text, CDbl(Me.txtMonto.Text)))
            '    fReportes.crvReportes.ReportSource = rFactura
            '    fReportes.Show()
            'Else
            '    Dim rFactura As New rptComprobanteCheque2
            '    rFactura.SetDataSource(Comprobantes.ImprimirCombrobante(Me.etComprobante.Text, Me.etPeriodo.Text, ValorLetras, Me.etFecha.Text, CDbl(Me.txtMonto.Text)))
            '    fReportes.crvReportes.ReportSource = rFactura
            '    fReportes.Show()
            'End If

        End Sub

        Private Sub cbBancos_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbBancos.Leave
            If Me.cbBancos.SelectedValue = "0" Then
                MsgBox("Seleccione una Cuenta de Bancos", MsgBoxStyle.Information)
                Me.cbBancos.Focus()
                Exit Sub
            End If
        End Sub

        Private Sub dtpFecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
            If Me.etInicio.Text = "1" Then
                Exit Sub
            End If
            If MonedaBase = dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("mon_codigo") Then
                'Moneda de la Cuenta = Moneda Base 
                Me.txtMontoMonedaBase.Text = Me.txtMonto.Text
                ts = 1
            Else
                'TasaCambioDia
                ts = VB.SysContab.Tasa_CambioDB.TasaCambioDia(Me.dtpFecha.Value.Day, Me.dtpFecha.Value.Month, Me.dtpFecha.Value.Year, MonedaBase, dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("mon_codigo"))
                Me.txtMontoMonedaBase.Text = Me.etTotal.Text 'CDbl(CDbl(Me.txtMonto.Text) * ts).ToString(Round)
            End If
        End Sub
    End Class

End Namespace
