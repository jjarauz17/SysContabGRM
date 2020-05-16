Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports SysContab.VB.SysContab

Namespace DataGridTextBoxCombo
    Public Class frmPagosCajaChicaVer
        Inherits DevExpress.XtraEditors.XtraForm

        Private Shared ChildInstance As frmPagosCajaChicaVer = Nothing

        Public Shared Function Instance() As frmPagosCajaChicaVer
            If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
                ChildInstance = New frmPagosCajaChicaVer()
            End If
            ChildInstance.BringToFront()

            Return ChildInstance
        End Function

        Dim Proveedores As New VB.SysContab.ProveedoresDB()
        Dim PeriodosDB As New VB.SysContab.PeriodosDB()
        Dim CatalogoDB As New VB.SysContab.CatalogoDB()
        Dim Comprobantes As New VB.SysContab.ComprobanteDB()
        Dim compDet As New VB.SysContab.ComprobantesDetails()
        Dim Concept As New VB.SysContab.ConceptosDB()
        Dim Monedas As New VB.SysContab.MonedaDB()
        Dim Tasa As New VB.SysContab.Tasa_CambioDB()
        Dim WithEvents Codigo As DataGridComboBoxColumn
        Dim WithEvents Codigo1 As DataGridComboBoxColumn
        Dim r As New VB.SysContab.Rutinas()
        'Dim Concepto As DataGridTextBoxColumn()
        'Dim Tipo As DataGridComboBoxColumn
        'Dim WithEvents ConceptoID As DataGridComboBoxColumn
        'Dim WithEvents Cantidad As DataGridTextBoxColumn
        Dim WithEvents Catalogo As DataGridComboBoxColumn
        Dim WithEvents Proveedor As DataGridComboBoxColumn
        Dim Monto As DataGridTextBoxColumn
        Dim MontoInicial As DataGridTextBoxColumn
        Dim Factura As DataGridTextBoxColumn
        'Dim WithEvents Descuento As DataGridComboBoxColumn
        Dim ValorActualDescuento As Double
        Dim WithEvents tCust As DataTable
        Private WithEvents myDataSet As DataSet
        Dim ds As DataSet
        Dim i As Integer
        Dim j As Integer
        Dim Item As Integer
        Dim dsCatalogo As DataSet

        Dim Credito As Double
        Dim Debito As Double

        Dim ValorActualMonto As Double
        Dim ValorActualFactura As String

        Public Facturas As New VB.SysContab.Facturas_ComprasDB()

        Dim dsFacturas As DataSet

        Dim Conf As New VB.SysContab.ConfiguracionDB()
        Public Inicio As Boolean
        Dim ds1 As DataSet

        Public Nombre As String
        Public Pagara As String
        Dim Fechas As New VB.SysContab.FechasdeTrabajo

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
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents dgFacturacionCliente As System.Windows.Forms.DataGrid
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents lblTasaCambio As System.Windows.Forms.Label
        Friend WithEvents lblNoComprobante As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents Button2 As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents Button3 As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
        Friend WithEvents etDiferencia As System.Windows.Forms.Label
        Friend WithEvents Label39 As System.Windows.Forms.Label
        Friend WithEvents Label38 As System.Windows.Forms.Label
        Friend WithEvents etDebito As System.Windows.Forms.Label
        Friend WithEvents etCredito As System.Windows.Forms.Label
        Friend WithEvents etTotalT As System.Windows.Forms.Label
        Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents etProveedor As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents cbCaja As System.Windows.Forms.ComboBox
        Friend WithEvents etDisponible As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents cbTipoComp As System.Windows.Forms.ComboBox
        Friend WithEvents chkFacturas As System.Windows.Forms.CheckBox
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents cbPagar1 As System.Windows.Forms.ComboBox
        Friend WithEvents cbPagar2 As System.Windows.Forms.ComboBox
        Friend WithEvents cbPagar As System.Windows.Forms.ComboBox
        Friend WithEvents etFecha As System.Windows.Forms.Label
        Friend WithEvents etPeriodo As System.Windows.Forms.Label
        Friend WithEvents etComprobante As System.Windows.Forms.Label
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents lblrecibo As System.Windows.Forms.Label
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.Label25 = New System.Windows.Forms.Label
            Me.GroupBox4 = New System.Windows.Forms.GroupBox
            Me.TextBox2 = New System.Windows.Forms.TextBox
            Me.Label4 = New System.Windows.Forms.Label
            Me.Label5 = New System.Windows.Forms.Label
            Me.Label6 = New System.Windows.Forms.Label
            Me.lblNoComprobante = New System.Windows.Forms.Label
            Me.etProveedor = New System.Windows.Forms.Label
            Me.dgFacturacionCliente = New System.Windows.Forms.DataGrid
            Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            Me.TextBox1 = New System.Windows.Forms.TextBox
            Me.Label3 = New System.Windows.Forms.Label
            Me.Label7 = New System.Windows.Forms.Label
            Me.Label8 = New System.Windows.Forms.Label
            Me.lblTasaCambio = New System.Windows.Forms.Label
            Me.txtConcepto = New System.Windows.Forms.TextBox
            Me.Label2 = New System.Windows.Forms.Label
            Me.GroupBox2 = New System.Windows.Forms.GroupBox
            Me.Button3 = New DevExpress.XtraEditors.SimpleButton
            Me.Button2 = New DevExpress.XtraEditors.SimpleButton
            Me.dtpFecha = New System.Windows.Forms.DateTimePicker
            Me.etDiferencia = New System.Windows.Forms.Label
            Me.Label39 = New System.Windows.Forms.Label
            Me.Label38 = New System.Windows.Forms.Label
            Me.etDebito = New System.Windows.Forms.Label
            Me.etCredito = New System.Windows.Forms.Label
            Me.etTotalT = New System.Windows.Forms.Label
            Me.cbCaja = New System.Windows.Forms.ComboBox
            Me.Label1 = New System.Windows.Forms.Label
            Me.etDisponible = New System.Windows.Forms.Label
            Me.Label9 = New System.Windows.Forms.Label
            Me.Label10 = New System.Windows.Forms.Label
            Me.cbTipoComp = New System.Windows.Forms.ComboBox
            Me.chkFacturas = New System.Windows.Forms.CheckBox
            Me.cbPagar = New System.Windows.Forms.ComboBox
            Me.Label11 = New System.Windows.Forms.Label
            Me.cbPagar1 = New System.Windows.Forms.ComboBox
            Me.cbPagar2 = New System.Windows.Forms.ComboBox
            Me.etFecha = New System.Windows.Forms.Label
            Me.etPeriodo = New System.Windows.Forms.Label
            Me.etComprobante = New System.Windows.Forms.Label
            Me.Label12 = New System.Windows.Forms.Label
            Me.lblrecibo = New System.Windows.Forms.Label
            Me.GroupBox4.SuspendLayout()
            CType(Me.dgFacturacionCliente, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'Label25
            '
            Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label25.Location = New System.Drawing.Point(672, 16)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(48, 24)
            Me.Label25.TabIndex = 143
            Me.Label25.Text = "Fecha:"
            Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'GroupBox4
            '
            Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.GroupBox4.Controls.Add(Me.TextBox2)
            Me.GroupBox4.Controls.Add(Me.Label4)
            Me.GroupBox4.Controls.Add(Me.Label5)
            Me.GroupBox4.Controls.Add(Me.Label6)
            Me.GroupBox4.Controls.Add(Me.lblNoComprobante)
            Me.GroupBox4.Controls.Add(Me.etProveedor)
            Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
            Me.GroupBox4.Location = New System.Drawing.Point(16, 96)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(120, 72)
            Me.GroupBox4.TabIndex = 145
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "No. Comprobante"
            Me.GroupBox4.Visible = False
            '
            'TextBox2
            '
            Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox2.Location = New System.Drawing.Point(832, 16)
            Me.TextBox2.MaxLength = 50
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.ReadOnly = True
            Me.TextBox2.Size = New System.Drawing.Size(136, 20)
            Me.TextBox2.TabIndex = 123
            Me.TextBox2.Text = ""
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label4.Location = New System.Drawing.Point(752, 16)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(72, 24)
            Me.Label4.TabIndex = 103
            Me.Label4.Text = "Teléfono:"
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.Maroon
            Me.Label5.Location = New System.Drawing.Point(632, 440)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(112, 24)
            Me.Label5.TabIndex = 110
            Me.Label5.Text = "0.00"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label6.Location = New System.Drawing.Point(536, 440)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(96, 24)
            Me.Label6.TabIndex = 109
            Me.Label6.Text = "Total:"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblNoComprobante
            '
            Me.lblNoComprobante.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.lblNoComprobante.Location = New System.Drawing.Point(8, 16)
            Me.lblNoComprobante.Name = "lblNoComprobante"
            Me.lblNoComprobante.Size = New System.Drawing.Size(208, 16)
            Me.lblNoComprobante.TabIndex = 149
            Me.lblNoComprobante.Text = "Label2"
            '
            'etProveedor
            '
            Me.etProveedor.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.etProveedor.Location = New System.Drawing.Point(16, 40)
            Me.etProveedor.Name = "etProveedor"
            Me.etProveedor.Size = New System.Drawing.Size(64, 23)
            Me.etProveedor.TabIndex = 1013
            Me.etProveedor.Text = "Proveedor"
            Me.etProveedor.Visible = False
            '
            'dgFacturacionCliente
            '
            Me.dgFacturacionCliente.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
            Me.dgFacturacionCliente.BackColor = System.Drawing.Color.Gainsboro
            Me.dgFacturacionCliente.BackgroundColor = System.Drawing.Color.DarkGray
            Me.dgFacturacionCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.dgFacturacionCliente.CaptionBackColor = System.Drawing.Color.DarkKhaki
            Me.dgFacturacionCliente.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            Me.dgFacturacionCliente.CaptionForeColor = System.Drawing.Color.Black
            Me.dgFacturacionCliente.DataMember = ""
            Me.dgFacturacionCliente.FlatMode = True
            Me.dgFacturacionCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgFacturacionCliente.ForeColor = System.Drawing.Color.Black
            Me.dgFacturacionCliente.GridLineColor = System.Drawing.Color.Silver
            Me.dgFacturacionCliente.HeaderBackColor = System.Drawing.Color.Black
            Me.dgFacturacionCliente.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            Me.dgFacturacionCliente.HeaderForeColor = System.Drawing.Color.White
            Me.dgFacturacionCliente.LinkColor = System.Drawing.Color.DarkSlateBlue
            Me.dgFacturacionCliente.Location = New System.Drawing.Point(8, 72)
            Me.dgFacturacionCliente.Name = "dgFacturacionCliente"
            Me.dgFacturacionCliente.ParentRowsBackColor = System.Drawing.Color.LightGray
            Me.dgFacturacionCliente.ParentRowsForeColor = System.Drawing.Color.Black
            Me.dgFacturacionCliente.SelectionBackColor = System.Drawing.Color.Firebrick
            Me.dgFacturacionCliente.SelectionForeColor = System.Drawing.Color.White
            Me.dgFacturacionCliente.Size = New System.Drawing.Size(1000, 336)
            Me.dgFacturacionCliente.TabIndex = 149
            '
            'cmdAceptar
            '
            Me.cmdAceptar.Enabled = False
            Me.cmdAceptar.Location = New System.Drawing.Point(8, 16)
            Me.cmdAceptar.Name = "cmdAceptar"
            Me.cmdAceptar.Size = New System.Drawing.Size(64, 24)
            Me.cmdAceptar.TabIndex = 152
            Me.cmdAceptar.Text = "Guardar"
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.GroupBox1.Controls.Add(Me.TextBox1)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label7)
            Me.GroupBox1.Controls.Add(Me.Label8)
            Me.GroupBox1.Controls.Add(Me.lblTasaCambio)
            Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
            Me.GroupBox1.Location = New System.Drawing.Point(144, 96)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(256, 48)
            Me.GroupBox1.TabIndex = 153
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Tasa de Cambio"
            Me.GroupBox1.Visible = False
            '
            'TextBox1
            '
            Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox1.Location = New System.Drawing.Point(832, 16)
            Me.TextBox1.MaxLength = 50
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.ReadOnly = True
            Me.TextBox1.Size = New System.Drawing.Size(136, 20)
            Me.TextBox1.TabIndex = 123
            Me.TextBox1.Text = ""
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label3.Location = New System.Drawing.Point(752, 16)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(72, 24)
            Me.Label3.TabIndex = 103
            Me.Label3.Text = "Teléfono:"
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.Maroon
            Me.Label7.Location = New System.Drawing.Point(632, 440)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(112, 24)
            Me.Label7.TabIndex = 110
            Me.Label7.Text = "0.00"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label8.Location = New System.Drawing.Point(536, 440)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(96, 24)
            Me.Label8.TabIndex = 109
            Me.Label8.Text = "Total:"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblTasaCambio
            '
            Me.lblTasaCambio.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.lblTasaCambio.Location = New System.Drawing.Point(24, 16)
            Me.lblTasaCambio.Name = "lblTasaCambio"
            Me.lblTasaCambio.Size = New System.Drawing.Size(208, 23)
            Me.lblTasaCambio.TabIndex = 149
            Me.lblTasaCambio.Text = "Label2"
            '
            'txtConcepto
            '
            Me.txtConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtConcepto.Location = New System.Drawing.Point(8, 432)
            Me.txtConcepto.Multiline = True
            Me.txtConcepto.Name = "txtConcepto"
            Me.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtConcepto.Size = New System.Drawing.Size(1000, 40)
            Me.txtConcepto.TabIndex = 154
            Me.txtConcepto.Text = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label2.Location = New System.Drawing.Point(8, 416)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(80, 16)
            Me.Label2.TabIndex = 155
            Me.Label2.Text = "Concepto:"
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.Button3)
            Me.GroupBox2.Controls.Add(Me.Button2)
            Me.GroupBox2.Controls.Add(Me.cmdAceptar)
            Me.GroupBox2.Location = New System.Drawing.Point(8, 472)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(1000, 48)
            Me.GroupBox2.TabIndex = 156
            Me.GroupBox2.TabStop = False
            '
            'Button3
            '
            Me.Button3.Location = New System.Drawing.Point(168, 16)
            Me.Button3.Name = "Button3"
            Me.Button3.Size = New System.Drawing.Size(64, 24)
            Me.Button3.TabIndex = 154
            Me.Button3.Text = "Salir"
            '
            'Button2
            '
            Me.Button2.Location = New System.Drawing.Point(88, 16)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(64, 24)
            Me.Button2.TabIndex = 153
            Me.Button2.Text = "Ayuda"
            '
            'dtpFecha
            '
            Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
            Me.dtpFecha.Location = New System.Drawing.Point(728, 16)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
            Me.dtpFecha.TabIndex = 157
            '
            'etDiferencia
            '
            Me.etDiferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etDiferencia.ForeColor = System.Drawing.Color.Maroon
            Me.etDiferencia.Location = New System.Drawing.Point(776, 416)
            Me.etDiferencia.Name = "etDiferencia"
            Me.etDiferencia.Size = New System.Drawing.Size(136, 16)
            Me.etDiferencia.TabIndex = 1012
            Me.etDiferencia.Text = "0.00"
            Me.etDiferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.etDiferencia.Visible = False
            '
            'Label39
            '
            Me.Label39.BackColor = System.Drawing.Color.Transparent
            Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label39.Location = New System.Drawing.Point(408, 416)
            Me.Label39.Name = "Label39"
            Me.Label39.Size = New System.Drawing.Size(80, 16)
            Me.Label39.TabIndex = 1011
            Me.Label39.Text = "Saldo:"
            Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Label39.Visible = False
            '
            'Label38
            '
            Me.Label38.BackColor = System.Drawing.Color.Transparent
            Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label38.Location = New System.Drawing.Point(184, 416)
            Me.Label38.Name = "Label38"
            Me.Label38.Size = New System.Drawing.Size(64, 16)
            Me.Label38.TabIndex = 1010
            Me.Label38.Text = "Total:"
            Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etDebito
            '
            Me.etDebito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etDebito.ForeColor = System.Drawing.Color.Maroon
            Me.etDebito.Location = New System.Drawing.Point(264, 416)
            Me.etDebito.Name = "etDebito"
            Me.etDebito.Size = New System.Drawing.Size(136, 16)
            Me.etDebito.TabIndex = 1009
            Me.etDebito.Text = "0.00"
            Me.etDebito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etCredito
            '
            Me.etCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etCredito.ForeColor = System.Drawing.Color.Maroon
            Me.etCredito.Location = New System.Drawing.Point(496, 416)
            Me.etCredito.Name = "etCredito"
            Me.etCredito.Size = New System.Drawing.Size(136, 16)
            Me.etCredito.TabIndex = 1008
            Me.etCredito.Text = "0.00"
            Me.etCredito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.etCredito.Visible = False
            '
            'etTotalT
            '
            Me.etTotalT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTotalT.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.etTotalT.Location = New System.Drawing.Point(640, 416)
            Me.etTotalT.Name = "etTotalT"
            Me.etTotalT.Size = New System.Drawing.Size(120, 16)
            Me.etTotalT.TabIndex = 1007
            Me.etTotalT.Text = "DIFERENCIA"
            Me.etTotalT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.etTotalT.Visible = False
            '
            'cbCaja
            '
            Me.cbCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbCaja.Location = New System.Drawing.Point(88, 16)
            Me.cbCaja.Name = "cbCaja"
            Me.cbCaja.Size = New System.Drawing.Size(376, 21)
            Me.cbCaja.TabIndex = 1014
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label1.Location = New System.Drawing.Point(16, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(40, 24)
            Me.Label1.TabIndex = 1015
            Me.Label1.Text = "Caja:"
            '
            'etDisponible
            '
            Me.etDisponible.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etDisponible.ForeColor = System.Drawing.Color.Maroon
            Me.etDisponible.Location = New System.Drawing.Point(544, 16)
            Me.etDisponible.Name = "etDisponible"
            Me.etDisponible.Size = New System.Drawing.Size(120, 24)
            Me.etDisponible.TabIndex = 1016
            Me.etDisponible.Text = "0.00"
            Me.etDisponible.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.Transparent
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(472, 16)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(72, 23)
            Me.Label9.TabIndex = 1017
            Me.Label9.Text = "Balance:"
            '
            'Label10
            '
            Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label10.Location = New System.Drawing.Point(472, 48)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(40, 24)
            Me.Label10.TabIndex = 1019
            Me.Label10.Text = "Tipo:"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'cbTipoComp
            '
            Me.cbTipoComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbTipoComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbTipoComp.Location = New System.Drawing.Point(520, 48)
            Me.cbTipoComp.Name = "cbTipoComp"
            Me.cbTipoComp.Size = New System.Drawing.Size(304, 21)
            Me.cbTipoComp.TabIndex = 1018
            '
            'chkFacturas
            '
            Me.chkFacturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkFacturas.Location = New System.Drawing.Point(872, 48)
            Me.chkFacturas.Name = "chkFacturas"
            Me.chkFacturas.Size = New System.Drawing.Size(136, 24)
            Me.chkFacturas.TabIndex = 1020
            Me.chkFacturas.Text = "Factura Pendiente"
            Me.chkFacturas.Visible = False
            '
            'cbPagar
            '
            Me.cbPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbPagar.Location = New System.Drawing.Point(88, 48)
            Me.cbPagar.Name = "cbPagar"
            Me.cbPagar.Size = New System.Drawing.Size(376, 21)
            Me.cbPagar.TabIndex = 1021
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label11.Location = New System.Drawing.Point(16, 48)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(64, 24)
            Me.Label11.TabIndex = 1022
            Me.Label11.Text = "Pagar a:"
            '
            'cbPagar1
            '
            Me.cbPagar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbPagar1.Location = New System.Drawing.Point(468, 237)
            Me.cbPagar1.Name = "cbPagar1"
            Me.cbPagar1.Size = New System.Drawing.Size(80, 21)
            Me.cbPagar1.TabIndex = 1023
            Me.cbPagar1.Visible = False
            '
            'cbPagar2
            '
            Me.cbPagar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbPagar2.Location = New System.Drawing.Point(468, 269)
            Me.cbPagar2.Name = "cbPagar2"
            Me.cbPagar2.Size = New System.Drawing.Size(80, 21)
            Me.cbPagar2.TabIndex = 1024
            Me.cbPagar2.Visible = False
            '
            'etFecha
            '
            Me.etFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etFecha.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.etFecha.Location = New System.Drawing.Point(232, 184)
            Me.etFecha.Name = "etFecha"
            Me.etFecha.Size = New System.Drawing.Size(48, 24)
            Me.etFecha.TabIndex = 1027
            Me.etFecha.Text = "Fecha"
            Me.etFecha.Visible = False
            '
            'etPeriodo
            '
            Me.etPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etPeriodo.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.etPeriodo.Location = New System.Drawing.Point(184, 184)
            Me.etPeriodo.Name = "etPeriodo"
            Me.etPeriodo.Size = New System.Drawing.Size(40, 24)
            Me.etPeriodo.TabIndex = 1026
            Me.etPeriodo.Text = "Per"
            Me.etPeriodo.Visible = False
            '
            'etComprobante
            '
            Me.etComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etComprobante.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.etComprobante.Location = New System.Drawing.Point(288, 184)
            Me.etComprobante.Name = "etComprobante"
            Me.etComprobante.Size = New System.Drawing.Size(56, 24)
            Me.etComprobante.TabIndex = 1025
            Me.etComprobante.Text = "Comp"
            Me.etComprobante.Visible = False
            '
            'Label12
            '
            Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.Location = New System.Drawing.Point(832, 16)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(64, 23)
            Me.Label12.TabIndex = 1029
            Me.Label12.Text = "Recibo No:"
            '
            'lblrecibo
            '
            Me.lblrecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblrecibo.ForeColor = System.Drawing.Color.Maroon
            Me.lblrecibo.Location = New System.Drawing.Point(896, 16)
            Me.lblrecibo.Name = "lblrecibo"
            Me.lblrecibo.Size = New System.Drawing.Size(112, 23)
            Me.lblrecibo.TabIndex = 1028
            Me.lblrecibo.Text = "0000"
            Me.lblrecibo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'frmPagosCajaChicaVer
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.ClientSize = New System.Drawing.Size(1016, 526)
            Me.Controls.Add(Me.Label12)
            Me.Controls.Add(Me.lblrecibo)
            Me.Controls.Add(Me.etFecha)
            Me.Controls.Add(Me.etPeriodo)
            Me.Controls.Add(Me.etComprobante)
            Me.Controls.Add(Me.cbPagar1)
            Me.Controls.Add(Me.cbPagar2)
            Me.Controls.Add(Me.cbPagar)
            Me.Controls.Add(Me.Label11)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.GroupBox4)
            Me.Controls.Add(Me.chkFacturas)
            Me.Controls.Add(Me.Label10)
            Me.Controls.Add(Me.cbTipoComp)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.etDisponible)
            Me.Controls.Add(Me.cbCaja)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.etDiferencia)
            Me.Controls.Add(Me.Label39)
            Me.Controls.Add(Me.Label38)
            Me.Controls.Add(Me.etDebito)
            Me.Controls.Add(Me.etCredito)
            Me.Controls.Add(Me.etTotalT)
            Me.Controls.Add(Me.dtpFecha)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.txtConcepto)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.dgFacturacionCliente)
            Me.Controls.Add(Me.Label25)
            Me.Name = "frmPagosCajaChicaVer"
            Me.GroupBox4.ResumeLayout(False)
            CType(Me.dgFacturacionCliente, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private Sub frmPagosCajaChicaVer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Me.Text = "Comprobante Caja Chica"

            Me.dtpFecha.Value = r.Fecha
            Me.txtConcepto.CharacterCasing = CharacterCasing.Upper
            Me.txtConcepto.MaxLength = 200

            Me.cbCaja.DataSource = ObtieneDatos("SELECT Cuenta, Cuenta + '-' + Nombre as Nombre, Cuenta + '-' + Nombre as Nombre2, 1 AS Orden " & _
            "FROM Catalogo WHERE Empresa = " & EmpresaActual & "AND Tipo = 'A' and CChica = 1 ORDER BY Orden, CUENTA")

            'CatalogoDB.CatalogoList("A", 1).Tables("CATALOGO")
            Me.cbCaja.ValueMember = "Cuenta"
            Me.cbCaja.DisplayMember = "Nombre"

            cbTipoComp.DataSource = Comprobantes.GetTiposComprobantes(0).Tables("TipoComprobantes")
            cbTipoComp.ValueMember = "TipComp_Id"
            cbTipoComp.DisplayMember = "TipComp_Nombre"

            Me.cbPagar.DataSource = Proveedores.PagarList().Tables("Proveedores")
            Me.cbPagar.ValueMember = "Codigo"
            Me.cbPagar.DisplayMember = "Nombre"

            Me.cbPagar1.DataSource = Proveedores.PagarList1().Tables("Proveedores")
            Me.cbPagar1.ValueMember = "Codigo"
            Me.cbPagar1.DisplayMember = "Nombre"

            Me.cbPagar2.DataSource = Proveedores.PagarList().Tables("Proveedores")
            Me.cbPagar2.ValueMember = "Codigo"
            Me.cbPagar2.DisplayMember = "Nombre"

            r.FormularioColor(Me)
            Try
                lblTasaCambio.Text = Tasa.GetTasaCambioDia(Today.Month, Today.Year, Today.Day).Tables("Tasa_Cambio").Rows(0).Item("Tasa_Cambio")
            Catch ex As Exception
                lblTasaCambio.Text = 1
            End Try

            dtpFecha.MinDate = Fechas.FechaMinima 'PeriodosDB.GetDetails(PeriodosDB.Activo).Inicio
            dtpFecha.MaxDate = Fechas.FechaMaxima 'PeriodosDB.GetDetails(PeriodosDB.Activo).Final

            compDet = Comprobantes.GetComprobanteDetails(Me.etComprobante.Text, Me.etPeriodo.Text, Me.etFecha.Text)
            Dim Registros As Integer
            Registros = Comprobantes.ComprobanteAnularBuscar(Me.etComprobante.Text, Me.etPeriodo.Text, Me.etFecha.Text)

            If Registros > 0 Then
                Me.dgFacturacionCliente.ReadOnly = True
                Me.txtConcepto.ReadOnly = True
                Me.dtpFecha.Enabled = False
                Me.cbTipoComp.Enabled = False
                Me.cmdAceptar.Enabled = False
                Me.cmdAceptar.Enabled = False
                'Me.cmdRecalcular.Enabled = False
            Else
                Me.dgFacturacionCliente.ReadOnly = False
            End If

            ds1 = compDet.Detalles

            MakeDataSet()
            dgFacturacionCliente.SetDataBinding(myDataSet, "Articulos")
            AddCustomDataTableStyle()

            Me.cbTipoComp.SelectedValue = compDet.Tipo1
            Me.txtConcepto.Text = compDet.Concepto
            Me.dtpFecha.Text = compDet.Fecha
            Me.lblrecibo.Text = compDet.Recibo

            Me.Pagara = compDet.Pagara
            Me.Nombre = compDet.ChequeNombre

            If compDet.Pagara = "0" Then
                Me.cbPagar.Text = compDet.ChequeNombre
                'Me.cbPagar.Refresh()
            Else
                Me.cbPagar.SelectedValue = compDet.Pagara
                Me.cbPagar1.SelectedValue = compDet.Pagara
            End If

            'Me.txtNombre.Text = compDet.ChequeNombre


            BuscarCombo = False
            LeaveCommit = False

            Debito = 0
            Credito = 0

            r.ComboAutoComplete(Codigo1.ColumnComboBox)
            r.ComboAutoComplete(Catalogo.ColumnComboBox)
            r.ComboAutoComplete(Me.cbCaja)
            r.ComboAutoComplete(Me.cbPagar)
        End Sub

        Private Sub MakeDataSet()
            myDataSet = New DataSet("myDataSet")

            tCust = New DataTable("Articulos")

            Dim cCodigo As DataColumn
            cCodigo = New DataColumn("Codigo")

            Dim cCodigo1 As DataColumn
            cCodigo1 = New DataColumn("Codigo1")

            Dim cCatalogo As DataColumn
            cCatalogo = New DataColumn("Catalogo")

            Dim cFactura As DataColumn
            cFactura = New DataColumn("Factura")

            Dim cMonto As DataColumn
            cMonto = New DataColumn("Monto")

            'Dim cIR As DataColumn
            'cIR = New DataColumn("IR")

            'Dim cTotalPagar As DataColumn
            'cTotalPagar = New DataColumn("TotalPagar")

            Dim cConcepto As DataColumn
            cConcepto = New DataColumn("Concepto")

            Dim cProveedor As DataColumn
            cProveedor = New DataColumn("Proveedor")

            Dim cFacturaNo As DataColumn
            cFacturaNo = New DataColumn("FacturaNo")

            Dim cMontoInicial As DataColumn
            cMontoInicial = New DataColumn("MontoInicial")

            tCust.Columns.Add(cCodigo)
            tCust.Columns.Add(cCodigo1)
            tCust.Columns.Add(cCatalogo)
            tCust.Columns.Add(cFactura)
            tCust.Columns.Add(cMonto)
            'tCust.Columns.Add(cIR)
            'tCust.Columns.Add(cTotalPagar)
            tCust.Columns.Add(cConcepto)
            tCust.Columns.Add(cProveedor)
            tCust.Columns.Add(cFacturaNo)
            tCust.Columns.Add(cMontoInicial)

            myDataSet.Tables.Add(tCust)

            Dim newRow1 As DataRow
            Dim j As Integer

            For j = 0 To ds1.Tables("ComprobantesDetalles").Rows.Count - 1
                If ds1.Tables("ComprobantesDetalles").Rows(j).Item("Detalle") = 0 Then
                    Me.cbCaja.SelectedValue = ds1.Tables("ComprobantesDetalles").Rows(j).Item("Cuenta")
                    'Me.txtMonto.Text = CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("Monto")).ToString(Round)
                Else
                    newRow1 = tCust.NewRow
                    newRow1("Codigo1") = ds1.Tables("ComprobantesDetalles").Rows(j).Item("Cuenta") & " - " & ds1.Tables("ComprobantesDetalles").Rows(j).Item("Nombre")
                    tCust.Rows.Add(newRow1)

                    'tCust.Rows(j)("Codigo1") = ds1.Tables("ComprobantesDetalles").Rows(j).Item("Cuenta")
                    newRow1("Codigo") = ds1.Tables("ComprobantesDetalles").Rows(j).Item("Cuenta")
                    newRow1("Catalogo") = ds1.Tables("ComprobantesDetalles").Rows(j).Item("Nombre")
                    newRow1("Concepto") = ds1.Tables("ComprobantesDetalles").Rows(j).Item("Concepto")
                    newRow1("Factura") = ds1.Tables("ComprobantesDetalles").Rows(j).Item("Factura_ID")

                    If ds1.Tables("ComprobantesDetalles").Rows(j).Item("Proceso") = "Débito" Then
                        newRow1("Monto") = CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("Monto")).ToString(Round) ' CDbl(CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("Monto")) * CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("TasaCambio"))).ToString(Round)
                        'DebitoMonto = DebitoMonto + CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("Monto"))
                    ElseIf ds1.Tables("ComprobantesDetalles").Rows(j).Item("Proceso") = "Crédito" Then
                        newRow1("Monto") = "-" & CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("Monto")).ToString(Round) 'CDbl(CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("Monto")) * CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("TasaCambio"))).ToString(Round)
                        'CreditoMonto = CreditoMonto + CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("Monto"))
                    End If

                    'Me.lblDebito.Text = DebitoMonto.ToString(Round)
                    'Me.lblCredito.Text = CreditoMonto.ToString(Round)8931697

                    'tCust.Rows(j)("Proceso") = ds1.Tables("ComprobantesDetalles").Rows(j).Item("Proceso")

                End If
            Next

        End Sub

        Private Sub MontoLeaveHandler(ByVal sender As Object, ByVal e As EventArgs)
            If Not IsNumeric(Monto.TextBox.Text) Then
                Monto.TextBox.Text = CDbl(ValorActualMonto).ToString(Round)
            Else
                'If CDbl(CDbl(Monto.TextBox.Text).ToString(Round)) > CDbl(tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("MontoInicial")) Then
                '    If Me.chkFacturas.Checked = True Then
                '        dsFacturas = Facturas.FacturasXFactProv(tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Proveedor"), Factura.TextBox.Text)

                '        If dsFacturas.Tables("Facturas_Compra").Rows.Count = 0 Then
                '            Monto.TextBox.Text = CDbl(Monto.TextBox.Text).ToString(Round)
                '        Else
                '            MsgBox("El valor es mayor que el Monto de la Factura", MsgBoxStyle.Exclamation)
                '            Monto.TextBox.Text = CDbl(ValorActualMonto).ToString(Round)
                '        End If
                '    End If
                'Else
                '    Monto.TextBox.Text = CDbl(Monto.TextBox.Text).ToString(Round)
                'End If

                tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Monto") = CDbl(Monto.TextBox.Text).ToString(Round)

                'If CDbl(tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Monto")) >= CDbl(Conf.GetConfigDetails().MontoIR) Then
                '    tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("IR") = CDbl((Conf.GetConfigDetails().IRProd / 100.0) * CDbl(tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Monto"))).ToString(Round)
                'Else
                '    tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("IR") = CDbl(0).ToString(Round)
                'End If

                'tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("TotalPagar") = CDbl(CDbl(tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Monto")) - CDbl(tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("IR"))).ToString(Round)
            End If
        End Sub

        Private Sub FacturaDobleClick(ByVal sender As Object, ByVal e As EventArgs)
            If Me.dgFacturacionCliente.CurrentRowIndex >= tCust.Rows.Count Then
                Exit Sub
            End If

            If tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Codigo").ToString = "" Or tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Codigo") Is DBNull.Value Or tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Catalogo").ToString = "" Or tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Catalogo") Is DBNull.Value Then
                MsgBox("Seleccione el Proveedor", MsgBoxStyle.Critical)
                Exit Sub
            End If

            Dim f As New frmFacturasComprasPagar()
            f.etInicio.Text = "1"
            'f.cbProveedor.SelectedValue = tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Codigo")
            f.etProveedor.Text = tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Proveedor")
            f.ShowDialog()

            If f.etAceptar.Text = "SI" Then
                tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Factura") = f.dgFacturas.Item(f.dgFacturas.CurrentRowIndex, 0)
                tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Monto") = CDbl(f.dgFacturas.Item(f.dgFacturas.CurrentRowIndex, 8)).ToString(Round)
                tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("MontoInicial") = CDbl(f.dgFacturas.Item(f.dgFacturas.CurrentRowIndex, 8)).ToString(Round)
                tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("FacturaNo") = f.dgFacturas.Item(f.dgFacturas.CurrentRowIndex, 0)

                'If CDbl(tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Monto")) >= CDbl(Conf.GetConfigDetails().MontoIR) Then
                '    tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("IR") = CDbl((Conf.GetConfigDetails().IRProd / 100.0) * CDbl(tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Monto"))).ToString(Round)
                'Else
                '    tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("IR") = CDbl(0).ToString(Round)
                'End If

                'tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("TotalPagar") = CDbl(CDbl(tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Monto")) - CDbl(tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("IR"))).ToString(Round)

            End If
        End Sub

        Private Sub FacturaLeave(ByVal sender As Object, ByVal e As EventArgs)
            If Me.dgFacturacionCliente.CurrentRowIndex >= tCust.Rows.Count Then
                Exit Sub
            End If

            If Factura.TextBox.Text = "-" Or Factura.TextBox.Text = "" Then
                tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Factura") = "-"
                tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("FacturaNo") = "-"
                tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Monto") = CDbl(0).ToString(Round)
                tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("MontoInicial") = CDbl(0).ToString(Round)
            Else
                dsFacturas = Facturas.FacturasXFactProv(tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Proveedor"), Factura.TextBox.Text)

                If dsFacturas.Tables("Facturas_Compra").Rows.Count = 0 Then
                    tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Factura") = Factura.TextBox.Text
                    tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("FacturaNo") = Factura.TextBox.Text
                Else

                    tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Factura") = Factura.TextBox.Text
                    tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Monto") = CDbl(dsFacturas.Tables("Facturas_Compra").Rows(0).Item("Saldo")).ToString(Round)
                    tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("MontoInicial") = CDbl(dsFacturas.Tables("Facturas_Compra").Rows(0).Item("Saldo")).ToString(Round)
                    tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("FacturaNo") = tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Factura")
                End If
            End If

            'If CDbl(tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Monto")) >= CDbl(Conf.GetConfigDetails().MontoIR) Then
            '    tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("IR") = CDbl((Conf.GetConfigDetails().IRProd / 100.0) * CDbl(tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Monto"))).ToString(Round)
            'Else
            '    tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("IR") = CDbl(0).ToString(Round)
            'End If

            'tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("TotalPagar") = CDbl(CDbl(tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Monto")) - CDbl(tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("IR"))).ToString(Round)

        End Sub

        Private Sub Evento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        End Sub

        Public Sub CambioIndice(ByVal rowChanging As Integer, ByVal newValue As Object)
        End Sub

        Public Sub TipoValueChanged(ByVal rowChanging As Integer, ByVal newValue As Object)
            ''MsgBox(Indice)
            'Try
            '    If Indice >= 0 Then
            '        If tCust.Rows.Count < rowChanging + 1 Then
            '            Dim newRow1 As DataRow
            '            newRow1 = tCust.NewRow
            '            newRow1 = tCust.NewRow
            '            newRow1("Tipo") = Tipo.ColumnComboBox.Items.Item(Indice)
            '            tCust.Rows.Add(newRow1)
            '            tCust.Rows(rowChanging)("Codigo") = ""
            '            tCust.Rows(rowChanging)("Catalogo") = ""
            '            'tCust.Rows(rowChanging)("Articulo") = Articulo.ColumnComboBox.Items.Item(Indice)
            '        Else
            '            tCust.Rows(rowChanging)("Tipo") = Tipo.ColumnComboBox.Items.Item(Indice)
            '            tCust.Rows(rowChanging)("Codigo") = ""
            '            tCust.Rows(rowChanging)("Catalogo") = ""
            '            'tCust.Rows(rowChanging)("Articulo") = Articulo.ColumnComboBox.Items.Item(Indice)
            '        End If

            '        Codigo.ColumnComboBox.Items.Clear()
            '        Catalogo.ColumnComboBox.Items.Clear()
            '        If Indice = 1 Then
            '            dsCatalogo = Proveedores.ProveedoresCatalogo
            '            For i = 0 To dsCatalogo.Tables("Proveedores").Rows.Count - 1
            '                Codigo.ColumnComboBox.Items.Add(dsCatalogo.Tables("Proveedores").Rows(i).Item("Cuenta"))
            '                Catalogo.ColumnComboBox.Items.Add(dsCatalogo.Tables("Proveedores").Rows(i).Item("Nombre"))
            '                Proveedor.ColumnComboBox.Items.Add(dsCatalogo.Tables("Proveedores").Rows(i).Item("Codigo"))
            '            Next
            '        Else
            '            dsCatalogo = CatalogoDB.CatalogoList("A")
            '            For i = 0 To dsCatalogo.Tables("CATALOGO").Rows.Count - 1
            '                Codigo.ColumnComboBox.Items.Add(dsCatalogo.Tables("CATALOGO").Rows(i).Item("Cuenta"))
            '                Catalogo.ColumnComboBox.Items.Add(dsCatalogo.Tables("CATALOGO").Rows(i).Item("Nombre"))
            '            Next
            '        End If
            '    End If
            'Catch ex As Exception
            '    MsgBox(ex.Message & "MyComboValueChanged")
            'End Try
        End Sub


        Public Sub MyComboValueChanged(ByVal rowChanging As Integer, ByVal newValue As Object)
            Try
                'If Indice = 0 Then
                '    Dim f As New frmAgregarProveedorQuickCuenta()
                '    f.StartPosition = FormStartPosition.CenterScreen
                '    f.ShowDialog()

                '    If f.etAceptar.Text = "1" Then
                '        Codigo1.ColumnComboBox.Items.Clear()
                '        Codigo.ColumnComboBox.Items.Clear()
                '        Catalogo.ColumnComboBox.Items.Clear()
                '        Proveedor.ColumnComboBox.Items.Clear()

                '        dsCatalogo = Proveedores.ProveedoresCatalogo
                '        For i = 0 To dsCatalogo.Tables("Proveedores").Rows.Count - 1
                '            Codigo.ColumnComboBox.Items.Add(dsCatalogo.Tables("Proveedores").Rows(i).Item("Cuenta"))
                '            Catalogo.ColumnComboBox.Items.Add(dsCatalogo.Tables("Proveedores").Rows(i).Item("Nombre"))
                '            Proveedor.ColumnComboBox.Items.Add(dsCatalogo.Tables("Proveedores").Rows(i).Item("Codigo"))
                '            If f.txtCodigo.Text = dsCatalogo.Tables("Proveedores").Rows(i).Item("Codigo") Then
                '                'Indice = i
                '                Proveedor.ColumnComboBox.SelectedIndex = i
                '            End If
                '        Next
                '        'Proveedor.ColumnComboBox.SelectedIndex = Indice
                '        Codigo.ColumnComboBox.BringToFront()
                '        Catalogo.ColumnComboBox.BringToFront()
                '    Else
                '        tCust.Rows(rowChanging)("Codigo") = ""
                '        tCust.Rows(rowChanging)("Catalogo") = ""
                '    End If
                'End If

                If Indice >= 0 Then
                    If tCust.Rows.Count < rowChanging + 1 Then
                        Dim newRow1 As DataRow
                        newRow1 = tCust.NewRow
                        newRow1("Codigo") = Codigo.ColumnComboBox.Items.Item(Indice)
                        newRow1("Codigo1") = Codigo1.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows.Add(newRow1)
                        tCust.Rows(rowChanging)("Catalogo") = Catalogo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Factura") = "-"
                        tCust.Rows(rowChanging)("FacturaNo") = "-"
                        tCust.Rows(rowChanging)("Concepto") = "-"

                        tCust.Rows(rowChanging)("Monto") = CDbl(0).ToString(Round)
                        'tCust.Rows(rowChanging)("IR") = CDbl(0).ToString(Round)

                        If Me.chkFacturas.Checked = True Then
                            tCust.Rows(rowChanging)("Proveedor") = Proveedor.ColumnComboBox.Items.Item(Indice)
                        End If

                        tCust.Rows(rowChanging)("MontoInicial") = CDbl(Comprobantes.SaldoxCuenta(tCust.Rows(rowChanging)("Codigo"), VB.SysContab.PeriodosDB.Activo(dtpFecha.Value))).ToString(Round)

                    Else
                        tCust.Rows(rowChanging)("Codigo") = Codigo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Codigo1") = Codigo1.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Catalogo") = Catalogo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Factura") = "-"
                        tCust.Rows(rowChanging)("FacturaNo") = "-"
                        tCust.Rows(rowChanging)("Concepto") = "-"

                        tCust.Rows(rowChanging)("Monto") = CDbl(0).ToString(Round)
                        'tCust.Rows(rowChanging)("IR") = CDbl(0).ToString(Round)

                        If Me.chkFacturas.Checked = True Then
                            tCust.Rows(rowChanging)("Proveedor") = Proveedor.ColumnComboBox.Items.Item(Indice)
                        End If

                        tCust.Rows(rowChanging)("MontoInicial") = CDbl(Comprobantes.SaldoxCuenta(tCust.Rows(rowChanging)("Codigo"), VB.SysContab.PeriodosDB.Activo(dtpFecha.Value))).ToString(Round)
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message & "MyComboValueChanged")
            End Try
        End Sub

        Private Sub AddCustomDataTableStyle()
            Dim ts1 As DataGridTableStyle
            ts1 = New DataGridTableStyle()
            ts1.MappingName = "Articulos"
            ts1.AlternatingBackColor = Color.LightBlue
            Dim colCount As Integer
            colCount = 0

            Codigo = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))
            Codigo.MappingName = "Codigo"
            Codigo.HeaderText = ""
            Codigo.Width = 0
            Codigo.ReadOnly = False
            ts1.GridColumnStyles.Add(Codigo)
            Codigo.NullText = ""
            colCount = (colCount + 1)

            Codigo1 = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))
            Codigo1.MappingName = "Codigo1"
            Codigo1.HeaderText = "Cuenta"
            Codigo1.Width = 350
            Codigo1.ReadOnly = False
            ts1.GridColumnStyles.Add(Codigo1)
            Codigo1.NullText = ""
            colCount = (colCount + 1)

            Catalogo = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))
            Catalogo.MappingName = "Catalogo"
            Catalogo.HeaderText = "Nombre"
            Catalogo.Width = 300
            Catalogo.ReadOnly = False
            ts1.GridColumnStyles.Add(Catalogo)
            Catalogo.NullText = ""
            colCount = (colCount + 1)

            Factura = New DataGridTextBoxColumn()
            Factura.MappingName = "Factura"
            Factura.HeaderText = "Factura"
            Factura.Width = 100
            Factura.ReadOnly = False
            ts1.GridColumnStyles.Add(Factura)
            Factura.NullText = ""

            If Me.chkFacturas.Checked = True Then
                AddHandler Factura.TextBox.DoubleClick, New EventHandler(AddressOf FacturaDobleClick)
                AddHandler Factura.TextBox.Leave, New EventHandler(AddressOf FacturaLeave)
            End If

            colCount = (colCount + 1)

            Monto = New DataGridTextBoxColumn()
            Monto.MappingName = "Monto"
            Monto.HeaderText = "Monto"
            Monto.Width = 100
            Monto.Alignment = HorizontalAlignment.Right
            Monto.ReadOnly = False
            Monto.Format = "##,###0.00"
            AddHandler Monto.TextBox.Leave, New EventHandler(AddressOf MontoLeaveHandler)
            ts1.GridColumnStyles.Add(Monto)
            colCount = (colCount + 1)
            Monto.NullText = ""

            'Dim IR As DataGridTextBoxColumn
            'IR = New DataGridTextBoxColumn()
            'IR.MappingName = "IR"
            'IR.HeaderText = "IR"
            'IR.Width = 100
            'IR.Alignment = HorizontalAlignment.Right
            'IR.ReadOnly = False
            'IR.Format = "##,###0.00"
            ''AddHandler Monto.TextBox.Leave, New EventHandler(AddressOf MontoLeaveHandler)
            'ts1.GridColumnStyles.Add(IR)
            'colCount = (colCount + 1)
            'IR.NullText = ""

            'Dim TotalPagar As DataGridTextBoxColumn
            'TotalPagar = New DataGridTextBoxColumn()
            'TotalPagar.MappingName = "TotalPagar"
            'TotalPagar.HeaderText = "Total"
            'TotalPagar.Width = 100
            'TotalPagar.Alignment = HorizontalAlignment.Right
            'TotalPagar.ReadOnly = True
            'TotalPagar.Format = "##,###0.00"
            ''AddHandler Monto.TextBox.Leave, New EventHandler(AddressOf MontoLeaveHandler)
            'ts1.GridColumnStyles.Add(TotalPagar)
            'colCount = (colCount + 1)
            'TotalPagar.NullText = ""

            Dim Concepto As DataGridTextBoxColumn
            Concepto = New DataGridTextBoxColumn()
            Concepto.MappingName = "Concepto"
            Concepto.HeaderText = "Concepto"
            Concepto.Width = 250
            Concepto.ReadOnly = False
            ts1.GridColumnStyles.Add(Concepto)
            Concepto.NullText = ""
            colCount = (colCount + 1)

            Proveedor = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))
            Proveedor.MappingName = "Proveedor"
            Proveedor.HeaderText = ""
            Proveedor.Width = 0
            Proveedor.ReadOnly = True
            ts1.GridColumnStyles.Add(Proveedor)
            Proveedor.NullText = ""
            colCount = (colCount + 1)

            Dim FacturaNo As DataGridTextBoxColumn
            FacturaNo = New DataGridTextBoxColumn()
            FacturaNo.MappingName = "FacturaNo"
            FacturaNo.HeaderText = ""
            FacturaNo.Width = 0
            FacturaNo.ReadOnly = True
            ts1.GridColumnStyles.Add(FacturaNo)
            FacturaNo.NullText = ""
            colCount = (colCount + 1)

            MontoInicial = New DataGridTextBoxColumn()
            MontoInicial.MappingName = "MontoInicial"
            MontoInicial.HeaderText = ""
            MontoInicial.Width = 0
            MontoInicial.Alignment = HorizontalAlignment.Right
            MontoInicial.ReadOnly = True
            MontoInicial.Format = "##,###0.00"
            ts1.GridColumnStyles.Add(MontoInicial)
            colCount = (colCount + 1)
            MontoInicial.NullText = "0.00"

            If Me.chkFacturas.Checked = True Then
                dsCatalogo = Proveedores.ProveedoresCatalogo

                For i = 0 To dsCatalogo.Tables("Proveedores").Rows.Count - 1
                    Codigo.ColumnComboBox.Items.Add(dsCatalogo.Tables("Proveedores").Rows(i).Item("Cuenta"))
                    Codigo1.ColumnComboBox.Items.Add(dsCatalogo.Tables("Proveedores").Rows(i).Item("Cuenta") & " - " & dsCatalogo.Tables("Proveedores").Rows(i).Item("Nombre"))
                    Catalogo.ColumnComboBox.Items.Add(dsCatalogo.Tables("Proveedores").Rows(i).Item("Nombre"))
                    Proveedor.ColumnComboBox.Items.Add(dsCatalogo.Tables("Proveedores").Rows(i).Item("Codigo"))
                Next
            Else
                dsCatalogo = CatalogoDB.CatalogoList1("A")
                For i = 0 To dsCatalogo.Tables("CATALOGO").Rows.Count - 1
                    Codigo.ColumnComboBox.Items.Add(dsCatalogo.Tables("CATALOGO").Rows(i).Item("Cuenta"))
                    Codigo1.ColumnComboBox.Items.Add(dsCatalogo.Tables("CATALOGO").Rows(i).Item("Cuenta") & " - " & dsCatalogo.Tables("CATALOGO").Rows(i).Item("Nombre"))
                    Catalogo.ColumnComboBox.Items.Add(dsCatalogo.Tables("CATALOGO").Rows(i).Item("Nombre"))
                Next
            End If

            ts1.GridLineColor = Color.FromArgb(70, 130, 180)
            ts1.AllowSorting = False
            ts1.HeaderFont = Me.dgFacturacionCliente.HeaderFont
            ts1.HeaderBackColor = Color.LightSteelBlue
            Me.dgFacturacionCliente.CaptionVisible = False
            ts1.PreferredRowHeight = (Codigo1.ColumnComboBox.Height + 3)
            ts1.RowHeaderWidth = 20

            dgFacturacionCliente.TableStyles.Clear()
            dgFacturacionCliente.TableStyles.Add(ts1)
        End Sub

        Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
            'MsgBox("Falta !!!", MsgBoxStyle.Information)
            Me.Close()
            Exit Sub
            If Me.cbCaja.SelectedValue = "0" Or Me.cbCaja.SelectedValue = Nothing Then
                MsgBox("Seleccione la Caja de donde se va a realizar el pago", MsgBoxStyle.Exclamation)
                Me.cbCaja.Focus()
                Exit Sub
            End If

            If Me.cbTipoComp.SelectedValue = 0 Then
                MsgBox("Seleccione el Tipo de Comprobante", MsgBoxStyle.Information)
                Me.cbTipoComp.Focus()
                Exit Sub
            End If

            If tCust.Rows.Count = 0 Then
                MsgBox("Seleccione la Factura que desea pagar", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If Debito = 0 And tCust.Rows.Count > 0 Then
                MsgBox("Seleccione la Factura que desea pagar", MsgBoxStyle.Critical)
                Exit Sub
            End If

            'If Credito = 0 And tCust.Rows.Count > 0 Then
            '    MsgBox("Debe Seleccionar la Caja...", MsgBoxStyle.Critical)
            '    Exit Sub
            'End If

            ''''If Debito > CDbl(Me.etDisponible.Text) Then
            ''''    MsgBox("El monto disponible no es suficiente...", MsgBoxStyle.Critical)
            ''''    Exit Sub
            ''''End If

            'If Credito <> Debito Then
            '    MsgBox("El Débito y el Crédito no están cuadrados", MsgBoxStyle.Critical)
            '    Exit Sub
            'End If

            If tCust.Rows.Count > 0 Then
                If tCust.Rows(tCust.Rows.Count - 1)("Codigo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Catalogo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Monto") Is DBNull.Value Then
                    tCust.Rows(tCust.Rows.Count - 1).Delete()
                End If
            End If

            For i = 0 To tCust.Rows.Count - 1
                If tCust.Rows(i)("Codigo").ToString = "" Or tCust.Rows(i)("Codigo") Is DBNull.Value Or tCust.Rows(i)("Catalogo").ToString = "" Or tCust.Rows(i)("Catalogo") Is DBNull.Value Then
                    MsgBox("Seleccione un cuenta en la Linea " & i + 1, MsgBoxStyle.Critical)
                    dgFacturacionCliente.Select(i)
                    Exit Sub
                End If
            Next

            Dim DC As String
            Dim CompNo As String
            'Dim Debe As Double
            'Dim Haber As Double
            'Dim IR As Double
            'Dim TotalSinIR As Double
            'Dim Actualizar As Double

            Dim conexion As New VB.SysContab.Rutinas()
            DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction()

            Try
                CompNo = Comprobantes.AddComprobante(Me.cbTipoComp.SelectedValue, 1, Me.txtConcepto.Text, 1, PeriodosDB.Activo(dtpFecha.Value), Me.dtpFecha.Value, 0, Me.cbPagar.Text, 0, IIf(Me.cbPagar.SelectedValue = Nothing, 0, Me.cbPagar.SelectedValue), "", 5, "", Me.dtpFecha.Value, 0, OrigenComprobantes.CHEQUE)

                Comprobantes.AddComprobanteDetalles(CompNo, Me.cbCaja.SelectedValue, Me.txtConcepto.Text, Me.etDebito.Text, "", _
                        Me.cbTipoComp.SelectedValue, "C", "", 0, Me.dtpFecha.Value, 0)

                For i = 0 To tCust.Rows.Count - 1
                    Dim Opera As Integer
                    'If VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo")).Tables("Catalogo").Rows(0).Item("Clase") = 1 Then
                    '    DC = "D"
                    '    Debe = Math.Abs(CDbl(tCust.Rows(i)("Monto")))
                    '    Haber = 0
                    '    Opera = 1
                    'ElseIf VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo")).Tables("Catalogo").Rows(0).Item("Clase") = 2 And CDbl(tCust.Rows(i)("Monto")) >= 0 Then
                    '    DC = "D"
                    '    Debe = Math.Abs(CDbl(tCust.Rows(i)("Monto")))
                    '    Haber = 0
                    '    Opera = 1
                    'ElseIf VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo")).Tables("Catalogo").Rows(0).Item("Clase") = 2 And CDbl(tCust.Rows(i)("Monto")) < 0 Then
                    '    DC = "C"
                    '    Debe = 0
                    '    Haber = Math.Abs(CDbl(tCust.Rows(i)("Monto")))
                    '    Opera = 2
                    'End If

                    If VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo")).Tables("Catalogo").Rows(0).Item("Clase") = 1 And CDbl(tCust.Rows(i)("Monto")) >= 0 Then
                        DC = "D"
                    ElseIf VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo")).Tables("Catalogo").Rows(0).Item("Clase") = 1 And CDbl(tCust.Rows(i)("Monto")) < 0 Then
                        DC = "C"
                    ElseIf VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo")).Tables("Catalogo").Rows(0).Item("Clase") = 2 And CDbl(tCust.Rows(i)("Monto")) >= 0 Then
                        DC = "D"
                    ElseIf VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo")).Tables("Catalogo").Rows(0).Item("Clase") = 2 And CDbl(tCust.Rows(i)("Monto")) < 0 Then
                        DC = "C"
                    End If

                    If tCust.Rows(i)("Monto") = tCust.Rows(i)("MontoInicial") And Me.chkFacturas.Checked = True Then
                        Comprobantes.CancelarFactura(tCust.Rows(i)("FacturaNo"), tCust.Rows(i)("Proveedor"), 1)
                    End If

                    'If CDbl(tCust.Rows(i)("Monto")) >= CDbl(Conf.GetConfigDetails().MontoIR) Then
                    '    IR = CDbl((Conf.GetConfigDetails().IRProd / 100.0) * CDbl(tCust.Rows(i)("Monto"))).ToString(Round)
                    '    TotalSinIR = CDbl(tCust.Rows(i)("Monto")) - IR

                    '    Comprobantes.AddComprobanteDetalles(CompNo, tCust.Rows(i)("Codigo"), tCust.Rows(i)("Concepto"), Math.Abs(CDbl(tCust.Rows(i)("Monto"))), "", _
                    '                                        Me.cbTipoComp.SelectedValue, DC, tCust.Rows(i)("FacturaNo"), 0, Me.dtpFecha.Value, 1)
                    'Else
                    Comprobantes.AddComprobanteDetalles(CompNo, tCust.Rows(i)("Codigo"), tCust.Rows(i)("Concepto"), Math.Abs(CDbl(tCust.Rows(i)("Monto"))), "", _
                    Me.cbTipoComp.SelectedValue, DC, tCust.Rows(i)("Factura"), 0, Me.dtpFecha.Value, 1)

                    'End If

                    'If Debe = 0 Then
                    '    Actualizar = Haber
                    'Else
                    '    Actualizar = Debe
                    'End If
                Next

                vb.SysContab.Rutinas.okTransaccion()

                MakeDataSet()
                dgFacturacionCliente.SetDataBinding(myDataSet, "Articulos")
                AddCustomDataTableStyle()

                r.ComboAutoComplete(Codigo1.ColumnComboBox)
                r.ComboAutoComplete(Catalogo.ColumnComboBox)

                Me.etCredito.Text = CDbl(0).ToString(Round)
                Me.etDebito.Text = CDbl(0).ToString(Round)
                Me.etDiferencia.Text = CDbl(0).ToString(Round)
                Me.txtConcepto.Text = ""
                Me.cbPagar.SelectedValue = 0

                Me.etDisponible.Text = CDbl(Comprobantes.SaldoxCuenta(Me.cbCaja.SelectedValue.ToString, VB.SysContab.PeriodosDB.Activo(dtpFecha.Value))).ToString(Round)
                Debito = 0
                Credito = 0
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
                VB.SysContab.Rutinas.ErrorTransaccion()
            End Try
        End Sub

        Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
            Me.Close()
        End Sub

        Private Sub dgFacturacionCliente_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFacturacionCliente.CurrentCellChanged
            If Me.dgFacturacionCliente.CurrentRowIndex < 0 Then
                Exit Sub
            End If

            Dim CodigoActual As String

            If Me.dgFacturacionCliente.CurrentRowIndex >= tCust.Rows.Count Then
                Exit Sub
            End If

            If tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Codigo") Is DBNull.Value Then
                Exit Sub
            End If

            CodigoActual = tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Codigo").ToString

            If tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Monto") Is DBNull.Value Then
            Else
                ValorActualMonto = tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Monto").ToString
            End If

            If tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Factura") Is DBNull.Value Then
            Else
                ValorActualFactura = tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Factura").ToString
            End If

            If CodigoActual <> "" Then
                tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Codigo") = CodigoActual
            End If

        End Sub

        Private Sub tCust_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles tCust.ColumnChanged
            Credito = 0
            Debito = 0
            For j = 0 To tCust.Rows.Count - 1
                If tCust.Rows(j)("Monto") Is DBNull.Value Then
                Else
                    'If tCust.Rows(j)("Tipo") = "Caja" Then
                    'Credito = Credito + tCust.Rows(j)("Monto")
                    'ElseIf tCust.Rows(j)("Tipo") = "Proveedor" Then
                    Debito = Debito + tCust.Rows(j)("Monto")
                    Credito = CDbl(Me.etDisponible.Text) - Debito
                    'End If
                End If
            Next
            Me.etCredito.Text = Credito.ToString(Round)
            Me.etDebito.Text = Debito.ToString(Round)
            Me.etDiferencia.Text = (Credito - Debito).ToString(Round)
        End Sub

        Private Sub cbCaja_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCaja.SelectedValueChanged
            Try
                Me.etDisponible.Text = CDbl(Comprobantes.SaldoxCuenta(Me.cbCaja.SelectedValue.ToString, VB.SysContab.PeriodosDB.Activo(dtpFecha.Value))).ToString(Round)
                Credito = CDbl(Me.etDisponible.Text) - Debito
                Me.etCredito.Text = Credito.ToString(Round)
            Catch ex As Exception

            End Try
        End Sub

        Private Sub dtpFecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
        End Sub

        Private Sub chkFacturas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFacturas.CheckedChanged
            MakeDataSet()
            dgFacturacionCliente.SetDataBinding(myDataSet, "Articulos")
            AddCustomDataTableStyle()

            r.ComboAutoComplete(Codigo1.ColumnComboBox)
            r.ComboAutoComplete(Catalogo.ColumnComboBox)
        End Sub

        Private Sub cbPagar_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPagar.SelectedValueChanged
            If Me.Inicio = True Then
                Exit Sub
            End If

            Me.cbPagar1.SelectedIndex = Me.cbPagar.SelectedIndex
            Me.cbPagar2.SelectedIndex = Me.cbPagar.SelectedIndex

            'Me.txtNombre.Text = Me.cbPagar1.Text

            'If Me.cbPagar.SelectedValue = 0 Then
            '    'Me.txtRuc.Text = ""
            '    Me.etRuc.Visible = True
            '    Me.txtRuc.Visible = True
            '    Exit Sub
            'End If

            'ProveedoresDetalles = VB.SysContab.ProveedoresDB.GetDetails(Me.cbPagar.SelectedValue)

            'If ProveedoresDetalles.Varios = True Then
            '    Me.etRuc.Visible = True
            '    Me.txtRuc.Visible = True
            'Else
            '    Me.txtRuc.Text = ""
            '    Me.etRuc.Visible = False
            '    Me.txtRuc.Visible = False
            'End If
        End Sub

        Private Sub cbCaja_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCaja.SelectedIndexChanged

        End Sub
    End Class

End Namespace
