Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports SysContab.VB.SysContab


Namespace DataGridTextBoxCombo
    Public Class frmPagosCajaChica
        Inherits DevExpress.XtraEditors.XtraForm

        Private Shared ChildInstance As frmPagosCajaChica = Nothing

        Public Shared Function Instance() As frmPagosCajaChica
            If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
                ChildInstance = New frmPagosCajaChica()
            End If
            ChildInstance.BringToFront()

            Return ChildInstance
        End Function

        Dim Proveedores As New VB.SysContab.ProveedoresDB()
        Dim PeriodosDB As New VB.SysContab.PeriodosDB()
        Dim CatalogoDB As New VB.SysContab.CatalogoDB()
        Dim Comprobantes As New VB.SysContab.ComprobanteDB()
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
            Me.Label25.BackColor = System.Drawing.Color.Transparent
            Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label25.Location = New System.Drawing.Point(709, 47)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(48, 26)
            Me.Label25.TabIndex = 143
            Me.Label25.Text = "Fecha:"
            Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'GroupBox4
            '
            Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.GroupBox4.Controls.Add(Me.TextBox2)
            Me.GroupBox4.Controls.Add(Me.Label4)
            Me.GroupBox4.Controls.Add(Me.Label5)
            Me.GroupBox4.Controls.Add(Me.Label6)
            Me.GroupBox4.Controls.Add(Me.lblNoComprobante)
            Me.GroupBox4.Controls.Add(Me.etProveedor)
            Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
            Me.GroupBox4.Location = New System.Drawing.Point(16, 103)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(120, 78)
            Me.GroupBox4.TabIndex = 145
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "No. Comprobante"
            Me.GroupBox4.Visible = False
            '
            'TextBox2
            '
            Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox2.Location = New System.Drawing.Point(832, 17)
            Me.TextBox2.MaxLength = 50
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.ReadOnly = True
            Me.TextBox2.Size = New System.Drawing.Size(136, 20)
            Me.TextBox2.TabIndex = 123
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label4.Location = New System.Drawing.Point(752, 17)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(72, 26)
            Me.Label4.TabIndex = 103
            Me.Label4.Text = "Teléfono:"
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.Maroon
            Me.Label5.Location = New System.Drawing.Point(632, 474)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(112, 26)
            Me.Label5.TabIndex = 110
            Me.Label5.Text = "0.00"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(536, 474)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(96, 26)
            Me.Label6.TabIndex = 109
            Me.Label6.Text = "Total:"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblNoComprobante
            '
            Me.lblNoComprobante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.lblNoComprobante.Location = New System.Drawing.Point(8, 17)
            Me.lblNoComprobante.Name = "lblNoComprobante"
            Me.lblNoComprobante.Size = New System.Drawing.Size(208, 17)
            Me.lblNoComprobante.TabIndex = 149
            Me.lblNoComprobante.Text = "Label2"
            '
            'etProveedor
            '
            Me.etProveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etProveedor.Location = New System.Drawing.Point(16, 43)
            Me.etProveedor.Name = "etProveedor"
            Me.etProveedor.Size = New System.Drawing.Size(64, 25)
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
            Me.dgFacturacionCliente.Location = New System.Drawing.Point(8, 78)
            Me.dgFacturacionCliente.Name = "dgFacturacionCliente"
            Me.dgFacturacionCliente.ParentRowsBackColor = System.Drawing.Color.LightGray
            Me.dgFacturacionCliente.ParentRowsForeColor = System.Drawing.Color.Black
            Me.dgFacturacionCliente.SelectionBackColor = System.Drawing.Color.Firebrick
            Me.dgFacturacionCliente.SelectionForeColor = System.Drawing.Color.White
            Me.dgFacturacionCliente.Size = New System.Drawing.Size(943, 313)
            Me.dgFacturacionCliente.TabIndex = 149
            '
            'cmdAceptar
            '
            Me.cmdAceptar.Location = New System.Drawing.Point(8, 17)
            Me.cmdAceptar.Name = "cmdAceptar"
            Me.cmdAceptar.Size = New System.Drawing.Size(64, 26)
            Me.cmdAceptar.TabIndex = 152
            Me.cmdAceptar.Text = "Guardar"
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.GroupBox1.Controls.Add(Me.TextBox1)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label7)
            Me.GroupBox1.Controls.Add(Me.Label8)
            Me.GroupBox1.Controls.Add(Me.lblTasaCambio)
            Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
            Me.GroupBox1.Location = New System.Drawing.Point(144, 103)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(256, 52)
            Me.GroupBox1.TabIndex = 153
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Tasa de Cambio"
            Me.GroupBox1.Visible = False
            '
            'TextBox1
            '
            Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox1.Location = New System.Drawing.Point(832, 17)
            Me.TextBox1.MaxLength = 50
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.ReadOnly = True
            Me.TextBox1.Size = New System.Drawing.Size(136, 20)
            Me.TextBox1.TabIndex = 123
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(752, 17)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(72, 26)
            Me.Label3.TabIndex = 103
            Me.Label3.Text = "Teléfono:"
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.Maroon
            Me.Label7.Location = New System.Drawing.Point(632, 474)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(112, 26)
            Me.Label7.TabIndex = 110
            Me.Label7.Text = "0.00"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label8.Location = New System.Drawing.Point(536, 474)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(96, 26)
            Me.Label8.TabIndex = 109
            Me.Label8.Text = "Total:"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblTasaCambio
            '
            Me.lblTasaCambio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.lblTasaCambio.Location = New System.Drawing.Point(24, 17)
            Me.lblTasaCambio.Name = "lblTasaCambio"
            Me.lblTasaCambio.Size = New System.Drawing.Size(208, 25)
            Me.lblTasaCambio.TabIndex = 149
            Me.lblTasaCambio.Text = "Label2"
            '
            'txtConcepto
            '
            Me.txtConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtConcepto.Location = New System.Drawing.Point(11, 427)
            Me.txtConcepto.Multiline = True
            Me.txtConcepto.Name = "txtConcepto"
            Me.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtConcepto.Size = New System.Drawing.Size(943, 43)
            Me.txtConcepto.TabIndex = 154
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(11, 406)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(80, 17)
            Me.Label2.TabIndex = 155
            Me.Label2.Text = "Concepto:"
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.Button3)
            Me.GroupBox2.Controls.Add(Me.Button2)
            Me.GroupBox2.Controls.Add(Me.cmdAceptar)
            Me.GroupBox2.Location = New System.Drawing.Point(11, 470)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(943, 52)
            Me.GroupBox2.TabIndex = 156
            Me.GroupBox2.TabStop = False
            '
            'Button3
            '
            Me.Button3.Location = New System.Drawing.Point(168, 17)
            Me.Button3.Name = "Button3"
            Me.Button3.Size = New System.Drawing.Size(64, 26)
            Me.Button3.TabIndex = 154
            Me.Button3.Text = "Salir"
            '
            'Button2
            '
            Me.Button2.Location = New System.Drawing.Point(88, 17)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(64, 26)
            Me.Button2.TabIndex = 153
            Me.Button2.Text = "Ayuda"
            '
            'dtpFecha
            '
            Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFecha.Location = New System.Drawing.Point(757, 51)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
            Me.dtpFecha.TabIndex = 157
            '
            'etDiferencia
            '
            Me.etDiferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etDiferencia.ForeColor = System.Drawing.Color.Maroon
            Me.etDiferencia.Location = New System.Drawing.Point(779, 399)
            Me.etDiferencia.Name = "etDiferencia"
            Me.etDiferencia.Size = New System.Drawing.Size(136, 17)
            Me.etDiferencia.TabIndex = 1012
            Me.etDiferencia.Text = "0.00"
            Me.etDiferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.etDiferencia.Visible = False
            '
            'Label39
            '
            Me.Label39.BackColor = System.Drawing.Color.Transparent
            Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label39.Location = New System.Drawing.Point(411, 399)
            Me.Label39.Name = "Label39"
            Me.Label39.Size = New System.Drawing.Size(80, 17)
            Me.Label39.TabIndex = 1011
            Me.Label39.Text = "Saldo:"
            Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label38
            '
            Me.Label38.BackColor = System.Drawing.Color.Transparent
            Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label38.Location = New System.Drawing.Point(187, 399)
            Me.Label38.Name = "Label38"
            Me.Label38.Size = New System.Drawing.Size(64, 17)
            Me.Label38.TabIndex = 1010
            Me.Label38.Text = "Total:"
            Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etDebito
            '
            Me.etDebito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etDebito.ForeColor = System.Drawing.Color.Maroon
            Me.etDebito.Location = New System.Drawing.Point(267, 399)
            Me.etDebito.Name = "etDebito"
            Me.etDebito.Size = New System.Drawing.Size(136, 17)
            Me.etDebito.TabIndex = 1009
            Me.etDebito.Text = "0.00"
            Me.etDebito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etCredito
            '
            Me.etCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etCredito.ForeColor = System.Drawing.Color.Maroon
            Me.etCredito.Location = New System.Drawing.Point(499, 399)
            Me.etCredito.Name = "etCredito"
            Me.etCredito.Size = New System.Drawing.Size(136, 17)
            Me.etCredito.TabIndex = 1008
            Me.etCredito.Text = "0.00"
            Me.etCredito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etTotalT
            '
            Me.etTotalT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTotalT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etTotalT.Location = New System.Drawing.Point(643, 399)
            Me.etTotalT.Name = "etTotalT"
            Me.etTotalT.Size = New System.Drawing.Size(120, 17)
            Me.etTotalT.TabIndex = 1007
            Me.etTotalT.Text = "DIFERENCIA"
            Me.etTotalT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.etTotalT.Visible = False
            '
            'cbCaja
            '
            Me.cbCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbCaja.Location = New System.Drawing.Point(88, 17)
            Me.cbCaja.Name = "cbCaja"
            Me.cbCaja.Size = New System.Drawing.Size(325, 21)
            Me.cbCaja.TabIndex = 1014
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(16, 17)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(40, 26)
            Me.Label1.TabIndex = 1015
            Me.Label1.Text = "Caja:"
            '
            'etDisponible
            '
            Me.etDisponible.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etDisponible.ForeColor = System.Drawing.Color.Maroon
            Me.etDisponible.Location = New System.Drawing.Point(588, 13)
            Me.etDisponible.Name = "etDisponible"
            Me.etDisponible.Size = New System.Drawing.Size(104, 26)
            Me.etDisponible.TabIndex = 1016
            Me.etDisponible.Text = "0.00"
            Me.etDisponible.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.Transparent
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(502, 15)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(80, 25)
            Me.Label9.TabIndex = 1017
            Me.Label9.Text = "Balance:"
            '
            'Label10
            '
            Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label10.Location = New System.Drawing.Point(423, 52)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(40, 26)
            Me.Label10.TabIndex = 1019
            Me.Label10.Text = "Tipo:"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'cbTipoComp
            '
            Me.cbTipoComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbTipoComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbTipoComp.Location = New System.Drawing.Point(471, 52)
            Me.cbTipoComp.Name = "cbTipoComp"
            Me.cbTipoComp.Size = New System.Drawing.Size(221, 21)
            Me.cbTipoComp.TabIndex = 1018
            '
            'chkFacturas
            '
            Me.chkFacturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkFacturas.Location = New System.Drawing.Point(878, 48)
            Me.chkFacturas.Name = "chkFacturas"
            Me.chkFacturas.Size = New System.Drawing.Size(73, 26)
            Me.chkFacturas.TabIndex = 1020
            Me.chkFacturas.Text = "Factura Pendiente"
            Me.chkFacturas.Visible = False
            '
            'cbPagar
            '
            Me.cbPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbPagar.Location = New System.Drawing.Point(88, 52)
            Me.cbPagar.Name = "cbPagar"
            Me.cbPagar.Size = New System.Drawing.Size(325, 21)
            Me.cbPagar.TabIndex = 1021
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.Transparent
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label11.Location = New System.Drawing.Point(16, 52)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(64, 26)
            Me.Label11.TabIndex = 1022
            Me.Label11.Text = "Pagar a:"
            '
            'cbPagar1
            '
            Me.cbPagar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbPagar1.Location = New System.Drawing.Point(468, 255)
            Me.cbPagar1.Name = "cbPagar1"
            Me.cbPagar1.Size = New System.Drawing.Size(80, 21)
            Me.cbPagar1.TabIndex = 1023
            Me.cbPagar1.Visible = False
            '
            'cbPagar2
            '
            Me.cbPagar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbPagar2.Location = New System.Drawing.Point(468, 290)
            Me.cbPagar2.Name = "cbPagar2"
            Me.cbPagar2.Size = New System.Drawing.Size(80, 21)
            Me.cbPagar2.TabIndex = 1024
            Me.cbPagar2.Visible = False
            '
            'Label12
            '
            Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.Location = New System.Drawing.Point(742, 17)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(98, 25)
            Me.Label12.TabIndex = 1025
            Me.Label12.Text = "Recibo No:"
            '
            'lblrecibo
            '
            Me.lblrecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblrecibo.ForeColor = System.Drawing.Color.Maroon
            Me.lblrecibo.Location = New System.Drawing.Point(836, 17)
            Me.lblrecibo.Name = "lblrecibo"
            Me.lblrecibo.Size = New System.Drawing.Size(115, 25)
            Me.lblrecibo.TabIndex = 1025
            Me.lblrecibo.Text = "0000"
            Me.lblrecibo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'frmPagosCajaChica
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(961, 527)
            Me.Controls.Add(Me.Label12)
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
            Me.Controls.Add(Me.lblrecibo)
            Me.Name = "frmPagosCajaChica"
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            CType(Me.dgFacturacionCliente, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private Sub frmComprobantes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Me.Text = "Comprobante Caja Chica"

            Me.dtpFecha.Value = r.Fecha
            Me.txtConcepto.CharacterCasing = CharacterCasing.Upper
            Me.txtConcepto.MaxLength = 200

            'Me.cbCaja.DataSource = CatalogoDB.CatalogoList("A", 1).Tables("CATALOGO")
            Me.cbCaja.DataSource = ObtieneDatos("SELECT Cuenta, Cuenta + '-' + Nombre as Nombre, Cuenta + '-' + Nombre as Nombre2, 1 AS Orden " & _
            "FROM Catalogo WHERE Empresa = " & EmpresaActual & "AND Tipo = 'A' and CChica = 1 ORDER BY Orden, CUENTA")
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

            MakeDataSet()
            dgFacturacionCliente.SetDataBinding(myDataSet, "Articulos")
            AddCustomDataTableStyle()

            BuscarCombo = False
            LeaveCommit = False

            Debito = 0
            Credito = 0

            r.ComboAutoComplete(Codigo1.ColumnComboBox)
            r.ComboAutoComplete(Catalogo.ColumnComboBox)
            r.ComboAutoComplete(Me.cbCaja)
            r.ComboAutoComplete(Me.cbPagar)

            GeneraRecibo()
        End Sub

        Private Sub GeneraRecibo()
            Dim Config As New VB.SysContab.ConfiguracionDB
            Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails
            Dim dd As String
            ConfigDetalles = Config.GetConfigDetails

            For d As Integer = 0 To ConfigDetalles.RecDigitos - 1
                dd = dd & "0"
            Next

            lblrecibo.Text = "RCC-" & Format(ConfigDetalles.RecChica, dd)
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

        End Sub

        Private Sub MontoLeaveHandler(ByVal sender As Object, ByVal e As EventArgs)
            If Not IsNumeric(Monto.TextBox.Text) Then
                Monto.TextBox.Text = CDbl(ValorActualMonto).ToString(Round)
            Else
                If CDbl(CDbl(Monto.TextBox.Text).ToString(Round)) > CDbl(tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("MontoInicial")) Then
                    If Me.chkFacturas.Checked = True Then
                        dsFacturas = Facturas.FacturasXFactProv(tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Proveedor"), Factura.TextBox.Text)

                        If dsFacturas.Tables("Facturas_Compra").Rows.Count = 0 Then
                            Monto.TextBox.Text = CDbl(Monto.TextBox.Text).ToString(Round)
                        Else
                            MsgBox("El valor es mayor que el Monto de la Factura", MsgBoxStyle.Exclamation)
                            Monto.TextBox.Text = CDbl(ValorActualMonto).ToString(Round)
                        End If
                    End If
                Else
                    Monto.TextBox.Text = CDbl(Monto.TextBox.Text).ToString(Round)
                End If

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

            Dim f As New frmFacturasComprasPagar
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

                        tCust.Rows(rowChanging)("MontoInicial") = CDbl(IsNull(Comprobantes.SaldoxCuenta(tCust.Rows(rowChanging)("Codigo"), VB.SysContab.PeriodosDB.Activo(dtpFecha.Value)), 0)).ToString(Round)
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message & "MyComboValueChanged")
            End Try
        End Sub

        Private Sub AddCustomDataTableStyle()
            Dim ts1 As DataGridTableStyle
            ts1 = New DataGridTableStyle
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

            Factura = New DataGridTextBoxColumn
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

            Monto = New DataGridTextBoxColumn
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
            Concepto = New DataGridTextBoxColumn
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
            FacturaNo = New DataGridTextBoxColumn
            FacturaNo.MappingName = "FacturaNo"
            FacturaNo.HeaderText = ""
            FacturaNo.Width = 0
            FacturaNo.ReadOnly = True
            ts1.GridColumnStyles.Add(FacturaNo)
            FacturaNo.NullText = ""
            colCount = (colCount + 1)

            MontoInicial = New DataGridTextBoxColumn
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
            If IsNull(ObtieneDatos("SELECT isnull(Count(Recibo),0) FROM Comprobantes C inner join ComprobantesDetalles CD on c.Comp_no = cd.Comp_no and c.per_id = cd.per_id and c.mes = cd.mes and c.empresa = cd.empresa Where c.Tipo = 5 and cd.recibo = '" & lblrecibo.Text & "'").Rows(0).Item(0), 0) >= 1 Then
                MsgBox("Ya se ha registrado ese numero de recibo", MsgBoxStyle.Information)
                Exit Sub
            End If

            If IsNull(etCredito.Text, 0) <= 0 Then
                MsgBox("No tiene fondos suficientes para realizar esta transaccion", MsgBoxStyle.Information)
                Exit Sub
            End If

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

            Dim conexion As New VB.SysContab.Rutinas
            DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction()

            Try
                CompNo = Comprobantes.AddComprobante(Me.cbTipoComp.SelectedValue, 1, Me.txtConcepto.Text, 1, PeriodosDB.Activo(dtpFecha.Value), Me.dtpFecha.Value, 0, Me.cbPagar.Text, 0, IIf(Me.cbPagar.SelectedValue = Nothing, 0, Me.cbPagar.SelectedValue), "", 5, "", Me.dtpFecha.Value, 0, OrigenComprobantes.CHEQUE)

                Comprobantes.AddComprobanteDetalles(CompNo, Me.cbCaja.SelectedValue, Me.txtConcepto.Text, Me.etDebito.Text, "", _
                        Me.cbTipoComp.SelectedValue, "C", "", lblrecibo.Text, Me.dtpFecha.Value, 0)

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
                    Me.cbTipoComp.SelectedValue, DC, tCust.Rows(i)("Factura"), lblrecibo.Text, Me.dtpFecha.Value, 1)

                    'End If

                    'If Debe = 0 Then
                    '    Actualizar = Haber
                    'Else
                    '    Actualizar = Debe
                    'End If
                Next

                VB.SysContab.Rutinas.okTransaccion()

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
                ObtieneDatos("UPDATE Configuraciones SET RecChica = RecChica + 1 WHERE Empresa = " & EmpresaActual)
                GeneraRecibo()
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
                ValorActualMonto = IsNull(tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Monto").ToString, 0)
            End If

            If tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Factura") Is DBNull.Value Then
            Else
                ValorActualFactura = IsNull(tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Factura").ToString, 0)
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

        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
            Help.ShowHelp(Me, "ayuda/ProcesosPagosPC.chm")
        End Sub

        Private Sub cbCaja_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCaja.SelectedIndexChanged

        End Sub
    End Class

End Namespace
