Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.Strings
Imports SysContab.VB.SysContab

Namespace DataGridTextBox
    Public Class frmComprobantesDetalles
        Inherits DevExpress.XtraEditors.XtraForm

        Private Shared ChildInstance As frmComprobantesDetalles = Nothing

        Public Shared Function Instance() As frmComprobantesDetalles
            If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
                ChildInstance = New frmComprobantesDetalles()
            End If
            ChildInstance.BringToFront()

            Return ChildInstance
        End Function

#Region " Código generado por el Diseñador de Windows Forms "

        Public Sub New()
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
        Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents lblTasaCambio As System.Windows.Forms.Label
        Friend WithEvents dgFacturacionCliente As System.Windows.Forms.DataGrid
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents lblNoComprobante As System.Windows.Forms.Label
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents lblTipo As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents lblDescrip As System.Windows.Forms.Label
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents lblDebito As System.Windows.Forms.Label
        Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
        Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents lblDiferencia As System.Windows.Forms.Label
        Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
        Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents lblCredito As System.Windows.Forms.Label
        Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents lblCheque As System.Windows.Forms.Label
        Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents lblPeriodo As System.Windows.Forms.Label
        Friend WithEvents etCheque As System.Windows.Forms.Label
        Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents lblFecha123 As System.Windows.Forms.Label
        Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
        Friend WithEvents cbTipoComp As System.Windows.Forms.ComboBox
        Friend WithEvents ddlMoneda As System.Windows.Forms.ComboBox
        Friend WithEvents lblMoneda As System.Windows.Forms.Label
        Friend WithEvents etFactura As System.Windows.Forms.Label
        Friend WithEvents etRecibo As System.Windows.Forms.Label
        Friend WithEvents lblChequeNombre As System.Windows.Forms.Label
        Friend WithEvents etchequeNombre As System.Windows.Forms.Label
        Friend WithEvents txtFecha As System.Windows.Forms.Label
        Friend WithEvents etAnulado As System.Windows.Forms.Label
        Friend WithEvents cmdAnular As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents etPagara As System.Windows.Forms.Label
        Friend WithEvents dtpFechaPago As System.Windows.Forms.DateTimePicker
        Friend WithEvents etRuc As System.Windows.Forms.Label
        Friend WithEvents etFormaPago As System.Windows.Forms.Label
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents etTipoX As System.Windows.Forms.Label
        Friend WithEvents etFactura1 As System.Windows.Forms.Label
        Friend WithEvents Timer1 As System.Windows.Forms.Timer
        Friend WithEvents cmdDetalleDistribucion As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents chkdistribuir As System.Windows.Forms.CheckBox
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Me.txtConcepto = New System.Windows.Forms.TextBox
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            Me.TextBox1 = New System.Windows.Forms.TextBox
            Me.Label3 = New System.Windows.Forms.Label
            Me.Label7 = New System.Windows.Forms.Label
            Me.Label8 = New System.Windows.Forms.Label
            Me.lblTasaCambio = New System.Windows.Forms.Label
            Me.dgFacturacionCliente = New System.Windows.Forms.DataGrid
            Me.Label1 = New System.Windows.Forms.Label
            Me.GroupBox4 = New System.Windows.Forms.GroupBox
            Me.TextBox2 = New System.Windows.Forms.TextBox
            Me.Label4 = New System.Windows.Forms.Label
            Me.Label5 = New System.Windows.Forms.Label
            Me.Label6 = New System.Windows.Forms.Label
            Me.lblNoComprobante = New System.Windows.Forms.Label
            Me.Label25 = New System.Windows.Forms.Label
            Me.lblFecha123 = New System.Windows.Forms.Label
            Me.lblTipo = New System.Windows.Forms.Label
            Me.lblDescrip = New System.Windows.Forms.Label
            Me.Label10 = New System.Windows.Forms.Label
            Me.GroupBox2 = New System.Windows.Forms.GroupBox
            Me.Label11 = New System.Windows.Forms.Label
            Me.Label12 = New System.Windows.Forms.Label
            Me.GroupBox3 = New System.Windows.Forms.GroupBox
            Me.TextBox3 = New System.Windows.Forms.TextBox
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label9 = New System.Windows.Forms.Label
            Me.Label13 = New System.Windows.Forms.Label
            Me.lblDebito = New System.Windows.Forms.Label
            Me.GroupBox5 = New System.Windows.Forms.GroupBox
            Me.TextBox4 = New System.Windows.Forms.TextBox
            Me.Label15 = New System.Windows.Forms.Label
            Me.Label16 = New System.Windows.Forms.Label
            Me.Label17 = New System.Windows.Forms.Label
            Me.lblDiferencia = New System.Windows.Forms.Label
            Me.GroupBox6 = New System.Windows.Forms.GroupBox
            Me.TextBox5 = New System.Windows.Forms.TextBox
            Me.Label19 = New System.Windows.Forms.Label
            Me.Label20 = New System.Windows.Forms.Label
            Me.Label21 = New System.Windows.Forms.Label
            Me.lblCredito = New System.Windows.Forms.Label
            Me.GroupBox7 = New System.Windows.Forms.GroupBox
            Me.cmdDetalleDistribucion = New DevExpress.XtraEditors.SimpleButton
            Me.cmdAnular = New DevExpress.XtraEditors.SimpleButton
            Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
            Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
            Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
            Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
            Me.Label18 = New System.Windows.Forms.Label
            Me.Label22 = New System.Windows.Forms.Label
            Me.lblCheque = New System.Windows.Forms.Label
            Me.etCheque = New System.Windows.Forms.Label
            Me.lblPeriodo = New System.Windows.Forms.Label
            Me.dtpFecha = New System.Windows.Forms.DateTimePicker
            Me.cbTipoComp = New System.Windows.Forms.ComboBox
            Me.etTipoX = New System.Windows.Forms.Label
            Me.ddlMoneda = New System.Windows.Forms.ComboBox
            Me.lblMoneda = New System.Windows.Forms.Label
            Me.etFactura = New System.Windows.Forms.Label
            Me.etRecibo = New System.Windows.Forms.Label
            Me.lblChequeNombre = New System.Windows.Forms.Label
            Me.etchequeNombre = New System.Windows.Forms.Label
            Me.txtFecha = New System.Windows.Forms.Label
            Me.etAnulado = New System.Windows.Forms.Label
            Me.etPagara = New System.Windows.Forms.Label
            Me.dtpFechaPago = New System.Windows.Forms.DateTimePicker
            Me.etRuc = New System.Windows.Forms.Label
            Me.etFormaPago = New System.Windows.Forms.Label
            Me.Label23 = New System.Windows.Forms.Label
            Me.etFactura1 = New System.Windows.Forms.Label
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.chkdistribuir = New System.Windows.Forms.CheckBox
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgFacturacionCliente, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox4.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox5.SuspendLayout()
            Me.GroupBox6.SuspendLayout()
            Me.GroupBox7.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtConcepto
            '
            Me.txtConcepto.Location = New System.Drawing.Point(8, 17)
            Me.txtConcepto.Multiline = True
            Me.txtConcepto.Name = "txtConcepto"
            Me.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtConcepto.Size = New System.Drawing.Size(976, 52)
            Me.txtConcepto.TabIndex = 166
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
            Me.GroupBox1.Location = New System.Drawing.Point(744, 60)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(256, 43)
            Me.GroupBox1.TabIndex = 165
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
            Me.lblTasaCambio.Size = New System.Drawing.Size(208, 22)
            Me.lblTasaCambio.TabIndex = 149
            Me.lblTasaCambio.Text = "Label2"
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
            Me.dgFacturacionCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgFacturacionCliente.ForeColor = System.Drawing.Color.Black
            Me.dgFacturacionCliente.GridLineColor = System.Drawing.Color.Silver
            Me.dgFacturacionCliente.HeaderBackColor = System.Drawing.Color.Black
            Me.dgFacturacionCliente.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            Me.dgFacturacionCliente.HeaderForeColor = System.Drawing.Color.White
            Me.dgFacturacionCliente.LinkColor = System.Drawing.Color.DarkSlateBlue
            Me.dgFacturacionCliente.Location = New System.Drawing.Point(0, 112)
            Me.dgFacturacionCliente.Name = "dgFacturacionCliente"
            Me.dgFacturacionCliente.ParentRowsBackColor = System.Drawing.Color.LightGray
            Me.dgFacturacionCliente.ParentRowsForeColor = System.Drawing.Color.Black
            Me.dgFacturacionCliente.SelectionBackColor = System.Drawing.Color.Firebrick
            Me.dgFacturacionCliente.SelectionForeColor = System.Drawing.Color.White
            Me.dgFacturacionCliente.Size = New System.Drawing.Size(1000, 258)
            Me.dgFacturacionCliente.TabIndex = 161
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(48, 34)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(48, 18)
            Me.Label1.TabIndex = 159
            Me.Label1.Text = "Tipo:"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'GroupBox4
            '
            Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.GroupBox4.Controls.Add(Me.TextBox2)
            Me.GroupBox4.Controls.Add(Me.Label4)
            Me.GroupBox4.Controls.Add(Me.Label5)
            Me.GroupBox4.Controls.Add(Me.Label6)
            Me.GroupBox4.Controls.Add(Me.lblNoComprobante)
            Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
            Me.GroupBox4.Location = New System.Drawing.Point(392, 0)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(256, 43)
            Me.GroupBox4.TabIndex = 157
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "No. Comprobante"
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
            Me.lblNoComprobante.Location = New System.Drawing.Point(24, 17)
            Me.lblNoComprobante.Name = "lblNoComprobante"
            Me.lblNoComprobante.Size = New System.Drawing.Size(208, 22)
            Me.lblNoComprobante.TabIndex = 149
            Me.lblNoComprobante.Text = "Label2"
            '
            'Label25
            '
            Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label25.Location = New System.Drawing.Point(40, 9)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(56, 17)
            Me.Label25.TabIndex = 156
            Me.Label25.Text = "Fecha:"
            Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblFecha123
            '
            Me.lblFecha123.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.lblFecha123.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFecha123.ForeColor = System.Drawing.Color.Maroon
            Me.lblFecha123.Location = New System.Drawing.Point(424, 52)
            Me.lblFecha123.Name = "lblFecha123"
            Me.lblFecha123.Size = New System.Drawing.Size(176, 26)
            Me.lblFecha123.TabIndex = 168
            Me.lblFecha123.Text = "0.00"
            Me.lblFecha123.Visible = False
            '
            'lblTipo
            '
            Me.lblTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.lblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTipo.ForeColor = System.Drawing.Color.Maroon
            Me.lblTipo.Location = New System.Drawing.Point(104, 34)
            Me.lblTipo.Name = "lblTipo"
            Me.lblTipo.Size = New System.Drawing.Size(288, 26)
            Me.lblTipo.TabIndex = 169
            Me.lblTipo.Text = "0.00"
            '
            'lblDescrip
            '
            Me.lblDescrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.lblDescrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDescrip.ForeColor = System.Drawing.Color.Maroon
            Me.lblDescrip.Location = New System.Drawing.Point(592, 52)
            Me.lblDescrip.Name = "lblDescrip"
            Me.lblDescrip.Size = New System.Drawing.Size(296, 21)
            Me.lblDescrip.TabIndex = 172
            Me.lblDescrip.Text = "0.00"
            Me.lblDescrip.Visible = False
            '
            'Label10
            '
            Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label10.Location = New System.Drawing.Point(8, 60)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(88, 18)
            Me.Label10.TabIndex = 171
            Me.Label10.Text = "Descripción:"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.GroupBox2.Controls.Add(Me.Label11)
            Me.GroupBox2.Controls.Add(Me.Label12)
            Me.GroupBox2.Controls.Add(Me.txtConcepto)
            Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
            Me.GroupBox2.Location = New System.Drawing.Point(16, 431)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(992, 77)
            Me.GroupBox2.TabIndex = 173
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Concepto"
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.ForeColor = System.Drawing.Color.Maroon
            Me.Label11.Location = New System.Drawing.Point(632, 474)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(112, 26)
            Me.Label11.TabIndex = 110
            Me.Label11.Text = "0.00"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label12
            '
            Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label12.Location = New System.Drawing.Point(536, 474)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(96, 26)
            Me.Label12.TabIndex = 109
            Me.Label12.Text = "Total:"
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'GroupBox3
            '
            Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.GroupBox3.Controls.Add(Me.TextBox3)
            Me.GroupBox3.Controls.Add(Me.Label2)
            Me.GroupBox3.Controls.Add(Me.Label9)
            Me.GroupBox3.Controls.Add(Me.Label13)
            Me.GroupBox3.Controls.Add(Me.lblDebito)
            Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
            Me.GroupBox3.Location = New System.Drawing.Point(16, 379)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(328, 52)
            Me.GroupBox3.TabIndex = 174
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "DEBITO"
            '
            'TextBox3
            '
            Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox3.Location = New System.Drawing.Point(832, 17)
            Me.TextBox3.MaxLength = 50
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.ReadOnly = True
            Me.TextBox3.Size = New System.Drawing.Size(136, 20)
            Me.TextBox3.TabIndex = 123
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(752, 17)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(72, 26)
            Me.Label2.TabIndex = 103
            Me.Label2.Text = "Teléfono:"
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.Color.Maroon
            Me.Label9.Location = New System.Drawing.Point(632, 474)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(112, 26)
            Me.Label9.TabIndex = 110
            Me.Label9.Text = "0.00"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label13
            '
            Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label13.Location = New System.Drawing.Point(536, 474)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(96, 26)
            Me.Label13.TabIndex = 109
            Me.Label13.Text = "Total:"
            Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblDebito
            '
            Me.lblDebito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDebito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.lblDebito.Location = New System.Drawing.Point(24, 17)
            Me.lblDebito.Name = "lblDebito"
            Me.lblDebito.Size = New System.Drawing.Size(256, 25)
            Me.lblDebito.TabIndex = 149
            Me.lblDebito.Text = "Label2"
            '
            'GroupBox5
            '
            Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.GroupBox5.Controls.Add(Me.TextBox4)
            Me.GroupBox5.Controls.Add(Me.Label15)
            Me.GroupBox5.Controls.Add(Me.Label16)
            Me.GroupBox5.Controls.Add(Me.Label17)
            Me.GroupBox5.Controls.Add(Me.lblDiferencia)
            Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox5.ForeColor = System.Drawing.Color.Maroon
            Me.GroupBox5.Location = New System.Drawing.Point(680, 379)
            Me.GroupBox5.Name = "GroupBox5"
            Me.GroupBox5.Size = New System.Drawing.Size(328, 52)
            Me.GroupBox5.TabIndex = 175
            Me.GroupBox5.TabStop = False
            Me.GroupBox5.Text = "DIFERENCIA"
            '
            'TextBox4
            '
            Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox4.Location = New System.Drawing.Point(832, 17)
            Me.TextBox4.MaxLength = 50
            Me.TextBox4.Name = "TextBox4"
            Me.TextBox4.ReadOnly = True
            Me.TextBox4.Size = New System.Drawing.Size(136, 20)
            Me.TextBox4.TabIndex = 123
            '
            'Label15
            '
            Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label15.Location = New System.Drawing.Point(752, 17)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(72, 26)
            Me.Label15.TabIndex = 103
            Me.Label15.Text = "Teléfono:"
            '
            'Label16
            '
            Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label16.ForeColor = System.Drawing.Color.Maroon
            Me.Label16.Location = New System.Drawing.Point(632, 474)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(112, 26)
            Me.Label16.TabIndex = 110
            Me.Label16.Text = "0.00"
            Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label17
            '
            Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label17.Location = New System.Drawing.Point(536, 474)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(96, 26)
            Me.Label17.TabIndex = 109
            Me.Label17.Text = "Total:"
            Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblDiferencia
            '
            Me.lblDiferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDiferencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.lblDiferencia.Location = New System.Drawing.Point(24, 17)
            Me.lblDiferencia.Name = "lblDiferencia"
            Me.lblDiferencia.Size = New System.Drawing.Size(256, 25)
            Me.lblDiferencia.TabIndex = 149
            Me.lblDiferencia.Text = "Label2"
            '
            'GroupBox6
            '
            Me.GroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.GroupBox6.Controls.Add(Me.TextBox5)
            Me.GroupBox6.Controls.Add(Me.Label19)
            Me.GroupBox6.Controls.Add(Me.Label20)
            Me.GroupBox6.Controls.Add(Me.Label21)
            Me.GroupBox6.Controls.Add(Me.lblCredito)
            Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox6.ForeColor = System.Drawing.Color.Maroon
            Me.GroupBox6.Location = New System.Drawing.Point(344, 379)
            Me.GroupBox6.Name = "GroupBox6"
            Me.GroupBox6.Size = New System.Drawing.Size(336, 52)
            Me.GroupBox6.TabIndex = 176
            Me.GroupBox6.TabStop = False
            Me.GroupBox6.Text = "CREDITO"
            '
            'TextBox5
            '
            Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox5.Location = New System.Drawing.Point(832, 17)
            Me.TextBox5.MaxLength = 50
            Me.TextBox5.Name = "TextBox5"
            Me.TextBox5.ReadOnly = True
            Me.TextBox5.Size = New System.Drawing.Size(136, 20)
            Me.TextBox5.TabIndex = 123
            '
            'Label19
            '
            Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label19.Location = New System.Drawing.Point(752, 17)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(72, 26)
            Me.Label19.TabIndex = 103
            Me.Label19.Text = "Teléfono:"
            '
            'Label20
            '
            Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label20.ForeColor = System.Drawing.Color.Maroon
            Me.Label20.Location = New System.Drawing.Point(632, 474)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(112, 26)
            Me.Label20.TabIndex = 110
            Me.Label20.Text = "0.00"
            Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label21
            '
            Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label21.Location = New System.Drawing.Point(536, 474)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(96, 26)
            Me.Label21.TabIndex = 109
            Me.Label21.Text = "Total:"
            Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblCredito
            '
            Me.lblCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCredito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.lblCredito.Location = New System.Drawing.Point(24, 17)
            Me.lblCredito.Name = "lblCredito"
            Me.lblCredito.Size = New System.Drawing.Size(256, 25)
            Me.lblCredito.TabIndex = 149
            Me.lblCredito.Text = "Label2"
            '
            'GroupBox7
            '
            Me.GroupBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.GroupBox7.Controls.Add(Me.cmdDetalleDistribucion)
            Me.GroupBox7.Controls.Add(Me.cmdAnular)
            Me.GroupBox7.Controls.Add(Me.cmdAceptar)
            Me.GroupBox7.Controls.Add(Me.cmdImprimir)
            Me.GroupBox7.Controls.Add(Me.cmdAyuda)
            Me.GroupBox7.Controls.Add(Me.cmdSalir)
            Me.GroupBox7.Controls.Add(Me.Label18)
            Me.GroupBox7.Controls.Add(Me.Label22)
            Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox7.ForeColor = System.Drawing.Color.Maroon
            Me.GroupBox7.Location = New System.Drawing.Point(16, 508)
            Me.GroupBox7.Name = "GroupBox7"
            Me.GroupBox7.Size = New System.Drawing.Size(992, 52)
            Me.GroupBox7.TabIndex = 177
            Me.GroupBox7.TabStop = False
            '
            'cmdDetalleDistribucion
            '
            Me.cmdDetalleDistribucion.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdDetalleDistribucion.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdDetalleDistribucion.Appearance.Options.UseFont = True
            Me.cmdDetalleDistribucion.Appearance.Options.UseForeColor = True
            Me.cmdDetalleDistribucion.Location = New System.Drawing.Point(400, 9)
            Me.cmdDetalleDistribucion.Name = "cmdDetalleDistribucion"
            Me.cmdDetalleDistribucion.Size = New System.Drawing.Size(75, 34)
            Me.cmdDetalleDistribucion.TabIndex = 116
            Me.cmdDetalleDistribucion.Text = "&Detalle Distribución"
            '
            'cmdAnular
            '
            Me.cmdAnular.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdAnular.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdAnular.Appearance.Options.UseFont = True
            Me.cmdAnular.Appearance.Options.UseForeColor = True
            Me.cmdAnular.Location = New System.Drawing.Point(208, 9)
            Me.cmdAnular.Name = "cmdAnular"
            Me.cmdAnular.Size = New System.Drawing.Size(75, 34)
            Me.cmdAnular.TabIndex = 115
            Me.cmdAnular.Text = "A&nular"
            '
            'cmdAceptar
            '
            Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdAceptar.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdAceptar.Appearance.Options.UseFont = True
            Me.cmdAceptar.Appearance.Options.UseForeColor = True
            Me.cmdAceptar.Location = New System.Drawing.Point(16, 9)
            Me.cmdAceptar.Name = "cmdAceptar"
            Me.cmdAceptar.Size = New System.Drawing.Size(75, 34)
            Me.cmdAceptar.TabIndex = 114
            Me.cmdAceptar.Text = "&Guardar"
            '
            'cmdImprimir
            '
            Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdImprimir.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdImprimir.Appearance.Options.UseFont = True
            Me.cmdImprimir.Appearance.Options.UseForeColor = True
            Me.cmdImprimir.Location = New System.Drawing.Point(112, 9)
            Me.cmdImprimir.Name = "cmdImprimir"
            Me.cmdImprimir.Size = New System.Drawing.Size(75, 34)
            Me.cmdImprimir.TabIndex = 113
            Me.cmdImprimir.Text = "&Imprimir"
            '
            'cmdAyuda
            '
            Me.cmdAyuda.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdAyuda.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdAyuda.Appearance.Options.UseFont = True
            Me.cmdAyuda.Appearance.Options.UseForeColor = True
            Me.cmdAyuda.Location = New System.Drawing.Point(304, 9)
            Me.cmdAyuda.Name = "cmdAyuda"
            Me.cmdAyuda.Size = New System.Drawing.Size(75, 34)
            Me.cmdAyuda.TabIndex = 112
            Me.cmdAyuda.Text = "&Ayuda"
            '
            'cmdSalir
            '
            Me.cmdSalir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdSalir.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdSalir.Appearance.Options.UseFont = True
            Me.cmdSalir.Appearance.Options.UseForeColor = True
            Me.cmdSalir.Location = New System.Drawing.Point(496, 9)
            Me.cmdSalir.Name = "cmdSalir"
            Me.cmdSalir.Size = New System.Drawing.Size(75, 34)
            Me.cmdSalir.TabIndex = 111
            Me.cmdSalir.Text = "&Salir"
            '
            'Label18
            '
            Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label18.ForeColor = System.Drawing.Color.Maroon
            Me.Label18.Location = New System.Drawing.Point(632, 474)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(112, 26)
            Me.Label18.TabIndex = 110
            Me.Label18.Text = "0.00"
            Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label22
            '
            Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label22.Location = New System.Drawing.Point(536, 474)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(96, 26)
            Me.Label22.TabIndex = 109
            Me.Label22.Text = "Total:"
            Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblCheque
            '
            Me.lblCheque.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.lblCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCheque.ForeColor = System.Drawing.Color.Maroon
            Me.lblCheque.Location = New System.Drawing.Point(104, 86)
            Me.lblCheque.Name = "lblCheque"
            Me.lblCheque.Size = New System.Drawing.Size(176, 26)
            Me.lblCheque.TabIndex = 179
            Me.lblCheque.Text = "0.00"
            '
            'etCheque
            '
            Me.etCheque.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etCheque.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etCheque.Location = New System.Drawing.Point(0, 86)
            Me.etCheque.Name = "etCheque"
            Me.etCheque.Size = New System.Drawing.Size(88, 17)
            Me.etCheque.TabIndex = 178
            Me.etCheque.Text = "Cheque:"
            Me.etCheque.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblPeriodo
            '
            Me.lblPeriodo.Location = New System.Drawing.Point(840, 52)
            Me.lblPeriodo.Name = "lblPeriodo"
            Me.lblPeriodo.Size = New System.Drawing.Size(100, 24)
            Me.lblPeriodo.TabIndex = 180
            Me.lblPeriodo.Text = "\"
            Me.lblPeriodo.Visible = False
            '
            'dtpFecha
            '
            Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFecha.Location = New System.Drawing.Point(96, 9)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
            Me.dtpFecha.TabIndex = 181
            '
            'cbTipoComp
            '
            Me.cbTipoComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbTipoComp.Location = New System.Drawing.Point(96, 60)
            Me.cbTipoComp.Name = "cbTipoComp"
            Me.cbTipoComp.Size = New System.Drawing.Size(296, 21)
            Me.cbTipoComp.TabIndex = 183
            '
            'etTipoX
            '
            Me.etTipoX.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etTipoX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTipoX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etTipoX.Location = New System.Drawing.Point(392, 26)
            Me.etTipoX.Name = "etTipoX"
            Me.etTipoX.Size = New System.Drawing.Size(72, 17)
            Me.etTipoX.TabIndex = 182
            Me.etTipoX.Text = "Tipo:"
            Me.etTipoX.Visible = False
            '
            'ddlMoneda
            '
            Me.ddlMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ddlMoneda.Location = New System.Drawing.Point(432, 181)
            Me.ddlMoneda.Name = "ddlMoneda"
            Me.ddlMoneda.Size = New System.Drawing.Size(200, 21)
            Me.ddlMoneda.TabIndex = 185
            Me.ddlMoneda.Visible = False
            '
            'lblMoneda
            '
            Me.lblMoneda.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.lblMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMoneda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.lblMoneda.Location = New System.Drawing.Point(376, 181)
            Me.lblMoneda.Name = "lblMoneda"
            Me.lblMoneda.Size = New System.Drawing.Size(80, 17)
            Me.lblMoneda.TabIndex = 184
            Me.lblMoneda.Text = "Moneda:"
            Me.lblMoneda.Visible = False
            '
            'etFactura
            '
            Me.etFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etFactura.ForeColor = System.Drawing.Color.Maroon
            Me.etFactura.Location = New System.Drawing.Point(176, 258)
            Me.etFactura.Name = "etFactura"
            Me.etFactura.Size = New System.Drawing.Size(176, 26)
            Me.etFactura.TabIndex = 186
            Me.etFactura.Text = "Factura"
            Me.etFactura.Visible = False
            '
            'etRecibo
            '
            Me.etRecibo.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etRecibo.ForeColor = System.Drawing.Color.Maroon
            Me.etRecibo.Location = New System.Drawing.Point(176, 224)
            Me.etRecibo.Name = "etRecibo"
            Me.etRecibo.Size = New System.Drawing.Size(176, 26)
            Me.etRecibo.TabIndex = 187
            Me.etRecibo.Text = "Recibo"
            Me.etRecibo.Visible = False
            '
            'lblChequeNombre
            '
            Me.lblChequeNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.lblChequeNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblChequeNombre.ForeColor = System.Drawing.Color.Maroon
            Me.lblChequeNombre.Location = New System.Drawing.Point(392, 86)
            Me.lblChequeNombre.Name = "lblChequeNombre"
            Me.lblChequeNombre.Size = New System.Drawing.Size(544, 26)
            Me.lblChequeNombre.TabIndex = 188
            '
            'etchequeNombre
            '
            Me.etchequeNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etchequeNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etchequeNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etchequeNombre.Location = New System.Drawing.Point(280, 86)
            Me.etchequeNombre.Name = "etchequeNombre"
            Me.etchequeNombre.Size = New System.Drawing.Size(112, 17)
            Me.etchequeNombre.TabIndex = 189
            Me.etchequeNombre.Text = "Cheque a Nombre:"
            Me.etchequeNombre.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtFecha
            '
            Me.txtFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFecha.ForeColor = System.Drawing.Color.Maroon
            Me.txtFecha.Location = New System.Drawing.Point(176, 293)
            Me.txtFecha.Name = "txtFecha"
            Me.txtFecha.Size = New System.Drawing.Size(176, 26)
            Me.txtFecha.TabIndex = 190
            Me.txtFecha.Text = "Fecha"
            Me.txtFecha.Visible = False
            '
            'etAnulado
            '
            Me.etAnulado.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etAnulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etAnulado.ForeColor = System.Drawing.Color.Maroon
            Me.etAnulado.Location = New System.Drawing.Point(208, 10)
            Me.etAnulado.Name = "etAnulado"
            Me.etAnulado.Size = New System.Drawing.Size(96, 17)
            Me.etAnulado.TabIndex = 191
            Me.etAnulado.Text = "ANULADO"
            Me.etAnulado.Visible = False
            '
            'etPagara
            '
            Me.etPagara.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etPagara.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etPagara.ForeColor = System.Drawing.Color.Maroon
            Me.etPagara.Location = New System.Drawing.Point(176, 190)
            Me.etPagara.Name = "etPagara"
            Me.etPagara.Size = New System.Drawing.Size(176, 25)
            Me.etPagara.TabIndex = 192
            Me.etPagara.Text = "Pagara"
            Me.etPagara.Visible = False
            '
            'dtpFechaPago
            '
            Me.dtpFechaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaPago.Location = New System.Drawing.Point(464, 215)
            Me.dtpFechaPago.Name = "dtpFechaPago"
            Me.dtpFechaPago.Size = New System.Drawing.Size(96, 20)
            Me.dtpFechaPago.TabIndex = 193
            Me.dtpFechaPago.Visible = False
            '
            'etRuc
            '
            Me.etRuc.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etRuc.ForeColor = System.Drawing.Color.Maroon
            Me.etRuc.Location = New System.Drawing.Point(376, 241)
            Me.etRuc.Name = "etRuc"
            Me.etRuc.Size = New System.Drawing.Size(176, 26)
            Me.etRuc.TabIndex = 194
            Me.etRuc.Text = "Ruc"
            Me.etRuc.Visible = False
            '
            'etFormaPago
            '
            Me.etFormaPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etFormaPago.ForeColor = System.Drawing.Color.Maroon
            Me.etFormaPago.Location = New System.Drawing.Point(376, 276)
            Me.etFormaPago.Name = "etFormaPago"
            Me.etFormaPago.Size = New System.Drawing.Size(176, 26)
            Me.etFormaPago.TabIndex = 195
            Me.etFormaPago.Text = "Forma Pago"
            Me.etFormaPago.Visible = False
            '
            'Label23
            '
            Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label23.Location = New System.Drawing.Point(376, 215)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(80, 18)
            Me.Label23.TabIndex = 196
            Me.Label23.Text = "Fecha Pago"
            Me.Label23.Visible = False
            '
            'etFactura1
            '
            Me.etFactura1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etFactura1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etFactura1.ForeColor = System.Drawing.Color.Maroon
            Me.etFactura1.Location = New System.Drawing.Point(376, 310)
            Me.etFactura1.Name = "etFactura1"
            Me.etFactura1.Size = New System.Drawing.Size(176, 26)
            Me.etFactura1.TabIndex = 197
            Me.etFactura1.Text = "Factura 1"
            Me.etFactura1.Visible = False
            '
            'chkdistribuir
            '
            Me.chkdistribuir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkdistribuir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.chkdistribuir.Location = New System.Drawing.Point(696, 9)
            Me.chkdistribuir.Name = "chkdistribuir"
            Me.chkdistribuir.Size = New System.Drawing.Size(136, 25)
            Me.chkdistribuir.TabIndex = 198
            Me.chkdistribuir.Text = "Guardar sin Distribuir"
            '
            'frmComprobantesDetalles
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(1014, 567)
            Me.Controls.Add(Me.chkdistribuir)
            Me.Controls.Add(Me.GroupBox4)
            Me.Controls.Add(Me.etFactura1)
            Me.Controls.Add(Me.Label23)
            Me.Controls.Add(Me.etFormaPago)
            Me.Controls.Add(Me.etRuc)
            Me.Controls.Add(Me.dtpFechaPago)
            Me.Controls.Add(Me.etPagara)
            Me.Controls.Add(Me.etAnulado)
            Me.Controls.Add(Me.txtFecha)
            Me.Controls.Add(Me.etchequeNombre)
            Me.Controls.Add(Me.lblChequeNombre)
            Me.Controls.Add(Me.etRecibo)
            Me.Controls.Add(Me.etFactura)
            Me.Controls.Add(Me.ddlMoneda)
            Me.Controls.Add(Me.lblMoneda)
            Me.Controls.Add(Me.cbTipoComp)
            Me.Controls.Add(Me.etTipoX)
            Me.Controls.Add(Me.dtpFecha)
            Me.Controls.Add(Me.lblPeriodo)
            Me.Controls.Add(Me.lblCheque)
            Me.Controls.Add(Me.etCheque)
            Me.Controls.Add(Me.GroupBox7)
            Me.Controls.Add(Me.GroupBox6)
            Me.Controls.Add(Me.GroupBox5)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.lblDescrip)
            Me.Controls.Add(Me.Label10)
            Me.Controls.Add(Me.lblTipo)
            Me.Controls.Add(Me.lblFecha123)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.dgFacturacionCliente)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label25)
            Me.Name = "frmComprobantesDetalles"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.dgFacturacionCliente, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.GroupBox5.ResumeLayout(False)
            Me.GroupBox5.PerformLayout()
            Me.GroupBox6.ResumeLayout(False)
            Me.GroupBox6.PerformLayout()
            Me.GroupBox7.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

#Region "Variables"
        Dim comp As New VB.SysContab.ComprobanteDB
        Dim compDet As New VB.SysContab.ComprobantesDetails
        Dim Monedas As New VB.SysContab.MonedaDB
        Dim CatalogoDB As New VB.SysContab.CatalogoDB
        Dim PeriodosDB As New VB.SysContab.PeriodosDB
        Dim r As New VB.SysContab.Rutinas

        Dim WithEvents Codigo As DataGridComboBox
        Dim WithEvents CCodigo As DataGridComboBox
        Dim WithEvents Cuenta As DataGridComboBox
        Dim WithEvents Concepto As DataGridTextBoxColumn
        'Dim WithEvents ConceptoID As DataGridComboBox
        Dim WithEvents Debito As DataGridTextBoxColumn
        Dim WithEvents Credito As DataGridTextBoxColumn
        Dim WithEvents CdetID As DataGridTextBoxColumn

        Public WithEvents tCust As DataTable
        Private WithEvents myDataSet As DataSet

        Dim ds1 As DataSet

        Dim DebitoMonto As Double
        Dim CreditoMonto As Double

        Dim i As Integer
#End Region

        Private _Temp As Boolean = False

        Public Property Temp()
            Get
                Return _Temp
            End Get
            Set(ByVal Value)
                _Temp = Value
            End Set
        End Property

        Private DT_Distribucion As DataTable = New DataTable("Distribucion")

        Private Sub frmComprobantesDetalles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'Comp.GetComprobanteDetails()
            'Me.dgFacturacionCliente.ReadOnly = True

            Me.txtConcepto.ReadOnly = False
            r.FormularioColor(Me)

            cbTipoComp.DataSource = comp.GetTiposComprobantes(0).Tables("TipoComprobantes")
            cbTipoComp.ValueMember = "TipComp_Id"
            cbTipoComp.DisplayMember = "TipComp_Nombre"

            ddlMoneda.DataSource = Monedas.GetList().Tables("Monedas")
            ddlMoneda.ValueMember = "Codigo"
            ddlMoneda.DisplayMember = "Descripcion"

            compDet = comp.GetComprobanteDetails(Me.lblNoComprobante.Text, Me.lblPeriodo.Text, Me.txtFecha.Text)

            Dim Registros As Integer
            Registros = comp.ComprobanteAnularBuscar(Me.lblNoComprobante.Text, Me.lblPeriodo.Text, Me.txtFecha.Text)


            If Registros > 0 Then
                Me.dgFacturacionCliente.ReadOnly = True
                Me.txtConcepto.ReadOnly = True
                Me.txtFecha.Enabled = False
                Me.cbTipoComp.Enabled = False
                Me.cmdAceptar.Enabled = False
                Me.cmdAnular.Enabled = False
                Me.etAnulado.Visible = True
                'compDet = comp.GetComprobanteAnuladoDetails(Me.lblNoComprobante.Text, Me.lblPeriodo.Text, Me.txtFecha.Text)
            Else
                Me.dgFacturacionCliente.ReadOnly = False
            End If

            ds1 = compDet.Detalles

            MakeDataSet()

            Me.dgFacturacionCliente.SetDataBinding(myDataSet, "Articulos")
            AddCustomDataTableStyle()

            Me.dtpFecha.Text = CDate(compDet.Fecha).ToShortDateString
            Me.txtConcepto.Text = compDet.Concepto
            Me.lblTipo.Text = compDet.Tipo
            Me.cbTipoComp.SelectedValue = compDet.Tipo1
            Me.ddlMoneda.SelectedValue = compDet.Moneda
            Me.lblTasaCambio.Text = compDet.TasaCambio
            Me.lblDescrip.Text = compDet.Descripcion
            Me.lblChequeNombre.Text = compDet.ChequeNombre

            Me.etFactura.Text = compDet.Factura
            Me.etRecibo.Text = compDet.Recibo

            Me.etPagara.Text = compDet.Pagara.ToString

            Me.dtpFechaPago.Value = compDet.FechaPago
            Me.etFormaPago.Text = compDet.FormaPago
            Me.etRuc.Text = compDet.Ruc
            Me.etTipoX.Text = compDet.TipoX
            Me.etFactura1.Text = compDet.Factura1

            Me.lblDiferencia.Text = CDbl(CDbl(Me.lblDebito.Text) - CDbl(Me.lblCredito.Text)).ToString(Round)

            Me.lblCheque.Text = compDet.Cheque
            If Me.lblCheque.Text = "0" Or Me.lblCheque.Text = "" Then


                Dim Prov As New VB.SysContab.ProveedoresDB
                Me.lblCheque.Text = compDet.Factura1
                lblChequeNombre.Text = Prov.GetDetails(compDet.Proveedor).Nombre

                Me.etCheque.Text = "Factura No."
                Me.etchequeNombre.Text = "Proveedor: "

                'Me.etchequeNombre.Visible = False



            Else
                Me.etCheque.Visible = True
                Me.lblCheque.Visible = True
                Me.lblChequeNombre.Visible = True
                Me.etchequeNombre.Visible = True
            End If


            r.ComboAutoComplete(Me.Codigo.ColumnComboBox)
            r.ComboAutoComplete(Me.Cuenta.ColumnComboBox)


            Me.Text = "Detalle del Comprobante"

            'SetTiempos(OrigenComprobantes.NATURAL, funciones.Tiempos.TiempoInicio, Now, funciones.Eventos.Inicia, lblNoComprobante.Text)

            DT_Distribucion = CargaDistribucion(Me.dtpFecha.Value.Month, lblNoComprobante.Text, VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.Value))
        End Sub

        Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
            Dim i As Integer

            If Me.cbTipoComp.SelectedValue = 0 Then
                MsgBox("Seleccione el Tipo de Comprobante", MsgBoxStyle.Information)
                Me.cbTipoComp.Focus()
                Exit Sub
            End If


            If tCust.Rows.Count = 0 Then
                MsgBox("Debe ingresar al menos dos lineas en el comprobante", MsgBoxStyle.Critical)
                Me.dgFacturacionCliente.Focus()
                Exit Sub
            End If

            For i = 0 To tCust.Rows.Count - 1
                If tCust.Rows(tCust.Rows.Count - 1)("Codigo").ToString = "" And tCust.Rows(tCust.Rows.Count - 1)("Codigo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Cuenta").ToString = "" And tCust.Rows(tCust.Rows.Count - 1)("Cuenta") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Debito").ToString = "" And tCust.Rows(tCust.Rows.Count - 1)("Debito") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Credito").ToString = "" And tCust.Rows(tCust.Rows.Count - 1)("Credito") Is DBNull.Value Then
                    tCust.Rows(tCust.Rows.Count - 1).Delete()
                End If
            Next

            For i = 0 To tCust.Rows.Count - 1
                If tCust.Rows(i)("Codigo").ToString = "" Or tCust.Rows(i)("Codigo") Is DBNull.Value Or tCust.Rows(i)("Cuenta").ToString = "" Or tCust.Rows(i)("Cuenta") Is DBNull.Value Then
                    MsgBox("Seleccionar una Cuenta del Catalogo", MsgBoxStyle.Critical)
                    dgFacturacionCliente.Focus()
                    dgFacturacionCliente.Select(i)
                    Exit Sub
                End If

                If (tCust.Rows(i)("Debito") Is DBNull.Value Or tCust.Rows(i)("Debito").ToString = "") And (tCust.Rows(i)("Credito") Is DBNull.Value Or tCust.Rows(i)("Credito").ToString = "") Then
                    MsgBox("Introduzca el monto para el Débito o Crédito", MsgBoxStyle.Information)
                    dgFacturacionCliente.Focus()
                    dgFacturacionCliente.Select(i)
                    Exit Sub
                End If
            Next

            If DebitoMonto = 0 And CreditoMonto = 0 Then
                'Guardar Debito y Credito con valor = 0
            Else
                If DebitoMonto = 0 And tCust.Rows.Count > 0 Then
                    MsgBox("Debe haber al menos una operación de Débito", MsgBoxStyle.Critical)
                    Me.dgFacturacionCliente.Focus()
                    Exit Sub
                End If

                If CreditoMonto = 0 And tCust.Rows.Count > 0 Then
                    MsgBox("Debe haber al menos una operación de Crédito", MsgBoxStyle.Critical)
                    Me.dgFacturacionCliente.Focus()
                    Exit Sub
                End If
            End If


            If CDbl(DebitoMonto.ToString(Round)) <> CDbl(CreditoMonto.ToString(Round)) Then
                MsgBox("El Débito y el Crédito no estan cuadrados", MsgBoxStyle.Critical)
                Me.dgFacturacionCliente.Focus()
                Exit Sub
            End If

            Dim conexion As New VB.SysContab.Rutinas
            DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
            DBConnFacturas.Open()

            transaccionFacturas = DBConnFacturas.BeginTransaction()

            If chkdistribuir.Checked = False Then
                If VerificaDistribucion() = False And ObligarDistribucion = True Then
                    VB.SysContab.Rutinas.ErrorTransaccion()
                    Exit Sub
                End If
            End If

            Dim f As frmComprobantes
            If Not Temp Then f = f.Instance

            Dim CompNumero As Double


            Dim NoComprob As Double

            Try
                'comp.ComprobanteDetalleDelete(Me.lblNoComprobante.Text, Me.lblPeriodo.Text, Me.txtFecha.Text)

                If Month(dtpFecha.Value) = Month(compDet.Fecha) Then
                    CompNumero = comp.ComprobanteUpdate(Me.lblNoComprobante.Text, Me.cbTipoComp.SelectedValue, Me.lblTasaCambio.Text, Me.txtConcepto.Text, ddlMoneda.SelectedValue, Me.lblPeriodo.Text, Me.dtpFecha.Value, 0, False, Me.txtFecha.Text, Me.etRuc.Text, Me.lblChequeNombre.Text, Me.etPagara.Text, Me.etFactura1.Text, Me.dtpFechaPago.Value, Me.etFormaPago.Text, Me.etTipoX.Text)
                Else
                    comp.ComprobanteAnular(Me.lblNoComprobante.Text, Me.lblPeriodo.Text, Me.txtFecha.Text)
                    comp.CancelarFactura(compDet.Factura1, compDet.Proveedor, 0)


                    NoComprob = comp.AddComprobante(cbTipoComp.SelectedValue, lblTasaCambio.Text, txtConcepto.Text, ddlMoneda.SelectedValue, PeriodosDB.Activo(dtpFecha.Value), dtpFecha.Value, 0, "", False, 0, "", 0, "", VB.SysContab.Rutinas.Fecha, 0, compDet.Comp)

                    For i = 0 To tCust.Rows.Count - 1

                        Dim Debe As Double = 0
                        Dim Haber As Double = 0
                        Dim DC As String
                        Dim Opera As Integer

                        If tCust.Rows(i)("Credito") Is DBNull.Value Or tCust.Rows(i)("Credito").ToString = "" Then
                            'Debe = tCust.Rows(i)("Debito")
                            If tCust.Rows(i)("Debito") Is DBNull.Value Or tCust.Rows(i)("Debito").ToString = "" Then
                                Debe = "0.00"
                            Else
                                Debe = tCust.Rows(i)("Debito")
                            End If
                            DC = "D"
                            Opera = 1
                        Else
                            'Haber = tCust.Rows(i)("Credito")
                            If tCust.Rows(i)("Credito") Is DBNull.Value Or tCust.Rows(i)("Credito").ToString = "" Then
                                Haber = "0.00"
                            Else
                                Haber = tCust.Rows(i)("Credito")
                            End If
                            DC = "C"
                            Opera = 2
                        End If

                        If DC = "D" Then
                            comp.AddComprobanteDetalles(NoComprob, tCust.Rows(i)("Codigo"), tCust.Rows(i)("Concepto").ToString, Debe, 0, Me.cbTipoComp.SelectedValue, DC, 0, 0, dtpFecha.Value, compDet.Detalles.Tables(0).Rows(i).Item("Detalle"))
                        Else
                            comp.AddComprobanteDetalles(NoComprob, tCust.Rows(i)("Codigo"), tCust.Rows(i)("Concepto").ToString, Haber, 0, Me.cbTipoComp.SelectedValue, DC, 0, 0, dtpFecha.Value, compDet.Detalles.Tables(0).Rows(i).Item("Detalle"))
                        End If

                    Next

                End If

                ' Verifica si una linea fue suprimida

                Dim j As Integer
                Dim NoCambio As Boolean


                For i = 0 To ds1.Tables("ComprobantesDetalles").Rows.Count - 1
                    NoCambio = False

                    For j = 0 To tCust.Rows.Count - 1
                        If CStr(ds1.Tables("ComprobantesDetalles").Rows(i).Item("CDet_ID").ToString) = CStr(tCust.Rows(j)("CDet_ID").ToString) Then
                            NoCambio = True
                            Exit For
                        End If
                    Next

                    If NoCambio = False Then
                        comp.DeleteComprobanteDetalles(ds1.Tables("ComprobantesDetalles").Rows(i).Item("CDet_ID"))
                        '----------------------------------------------------------
                        'Distribucion
                        '----------------------------------------------------------
                        EliminaCuentaDistribucion(i)
                        '----------------------------------------------------------
                        '----------------------------------------------------------
                    End If

                Next


                For i = 0 To tCust.Rows.Count - 1
                    Dim Debe As Double = 0
                    Dim Haber As Double = 0
                    Dim DC As String
                    Dim Opera As Integer

                    If tCust.Rows(i)("Credito") Is DBNull.Value Or tCust.Rows(i)("Credito").ToString = "" Then
                        If tCust.Rows(i)("Debito") Is DBNull.Value Or tCust.Rows(i)("Debito").ToString = "" Then
                            Debe = "0.00"
                        Else
                            Debe = tCust.Rows(i)("Debito")
                        End If

                        DC = "D"
                        Opera = 1
                    Else
                        If tCust.Rows(i)("Credito") Is DBNull.Value Or tCust.Rows(i)("Credito").ToString = "" Then
                            Haber = "0.00"
                        Else
                            Haber = tCust.Rows(i)("Credito")
                        End If

                        DC = "C"
                        Opera = 2
                    End If

                    '      Or IIf(DC = "C", (tCust.Rows(i)("Debito")) <> (ds1.Tables("ComprobantesDetalles").Rows(i).Item("Monto")), (tCust.Rows(i)("Credito")) <> (ds1.Tables("ComprobantesDetalles").Rows(i).Item("Monto"))) Then



                    ' Verificar si ha cambiado el comprobante para realizar la actualizacion
                    If Not tCust.Rows(i)("CDet_ID") Is DBNull.Value Then

                        Dim Cambio As Boolean = False

                        If tCust.Rows(i)("Codigo") <> ds1.Tables("ComprobantesDetalles").Rows(i).Item("Cuenta") Then
                            Cambio = True
                        End If

                        If tCust.Rows(i)("Concepto") <> ds1.Tables("ComprobantesDetalles").Rows(i).Item("Concepto") Then
                            Cambio = True
                        End If

                        If DC = "D" Then
                            If CDbl(tCust.Rows(i)("Debito")) <> CDbl(ds1.Tables("ComprobantesDetalles").Rows(i).Item("Monto")) Then
                                Cambio = True
                            End If
                        End If

                        If DC = "C" Then
                            If CDbl(tCust.Rows(i)("Credito")) <> CDbl(ds1.Tables("ComprobantesDetalles").Rows(i).Item("Monto")) Then
                                Cambio = True
                            End If
                        End If

                        If Microsoft.VisualBasic.Left(ds1.Tables("ComprobantesDetalles").Rows(i).Item(4), 1) <> DC Then
                            Cambio = True
                        End If

                        If Cambio = True Then
                            '----------------------------------------------------------
                            'Distribucion
                            'elimina la distribucion de la cuenta anterior antes de la modificacion
                            '----------------------------------------------------------
                            ActualizaCuentaDistribucion(DC, i)
                            '----------------------------------------------------------
                            '----------------------------------------------------------
                            'If DC = "D" Then
                            '    comp.ComprobanteDetallesUpdate(tCust.Rows(i)("Cdet_ID"), tCust.Rows(i)("Codigo"), Debe, tCust.Rows(i)("Concepto").ToString, DC)
                            'Else
                            '    comp.ComprobanteDetallesUpdate(tCust.Rows(i)("Cdet_ID"), tCust.Rows(i)("Codigo"), Haber, tCust.Rows(i)("Concepto").ToString, DC)
                            'End If
                        End If

                    Else
                        If DC = "D" Then
                            comp.AddComprobanteDetalles(lblNoComprobante.Text, tCust.Rows(i)("Codigo"), tCust.Rows(i)("Concepto").ToString, Debe, 0, Me.cbTipoComp.SelectedValue, DC, 0, 0, dtpFecha.Value, compDet.Detalles.Tables(0).Rows(0).Item("Detalle"))
                        Else
                            comp.AddComprobanteDetalles(lblNoComprobante.Text, tCust.Rows(i)("Codigo"), tCust.Rows(i)("Concepto").ToString, Haber, 0, Me.cbTipoComp.SelectedValue, DC, 0, 0, dtpFecha.Value, compDet.Detalles.Tables(0).Rows(0).Item("Detalle"))
                        End If
                    End If

                Next



                'If tCust.Rows(i)("Proceso").ToString = "Débito" Then
                '    Debe = tCust.Rows(i)("Monto")
                '    DC = "D"
                '    Opera = 1
                'End If

                'If tCust.Rows(i)("Proceso").ToString = "Crédito" Then
                '    Haber = tCust.Rows(i)("Monto")
                '    DC = "C"
                '    Opera = 2
                'End If

                '   If DC = "D" Then
                'comp.AddComprobanteDetalles1(CompNumero, tCust.Rows(i)("Codigo"), tCust.Rows(i)("Concepto").ToString, Debe, Me.lblCheque.Text, Me.cbTipoComp.SelectedValue, DC, Me.etFactura.Text, Me.etRecibo.Text, Me.lblPeriodo.Text, Me.dtpFecha.Value, 1)
                '   Else
                '       comp.AddComprobanteDetalles1(CompNumero, tCust.Rows(i)("Codigo"), tCust.Rows(i)("Concepto").ToString, Haber, Me.lblCheque.Text, Me.cbTipoComp.SelectedValue, DC, Me.etFactura.Text, Me.etRecibo.Text, Me.lblPeriodo.Text, Me.dtpFecha.Value, 1)
                '   End If

                'comp.AddCatalogoTrans(tCust.Rows(i)("Codigo"), Debe, Haber, tCust.Rows(i)("Cuenta"))
                '''CatalogoDB.ActualizarCuentas(tCust.Rows(i)("ArticuloCodigo"), tCust.Rows(i)("Precio"), Opera)



                '----------------------
                'Guarda la Distribucion
                '----------------------
                EliminaNoValidos()
                GuardaDistribucion(DT_Distribucion, dtpFecha.Value.Date)
                DT_Distribucion = CargaDistribucion(Me.dtpFecha.Value.Month, lblNoComprobante.Text, VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.Value))
                '--------------------------
                'Fin de Guarda Distribucion
                '--------------------------

                VB.SysContab.Rutinas.okTransaccion()
                SetTiempos(OrigenComprobantes.NATURAL, funciones.Tiempos.TiempoFin, Now, funciones.Eventos.Guarda, lblNoComprobante.Text)
            Catch ex As Exception
                MsgBox(ex.Message)
                VB.SysContab.Rutinas.ErrorTransaccion()
                SetTiempos(OrigenComprobantes.NATURAL, funciones.Tiempos.TiempoFin, Now, funciones.Eventos.Error1, lblNoComprobante.Text)
            End Try
            If Not Temp Then f.Buscar()

            Me.Close()
        End Sub

#Region "Funciones de Distribucion"

        Private Sub EliminaNoValidos()
            Dim Temp As Boolean
Ciclo:
            For i As Integer = 0 To DT_Distribucion.Rows.Count - 1
                If DT_Distribucion.Rows(i).RowState <> DataRowState.Deleted Then
                    Temp = False
                    For j As Integer = 0 To tCust.Rows.Count - 1
                        If DT_Distribucion.Rows(i).Item("Cuenta") = tCust.Rows(j).Item(1) And DT_Distribucion.Rows(i).Item("Tipo") = IIf(IsDBNull(tCust.Rows(j).Item("Debito")) OrElse IsNothing(tCust.Rows(j).Item("Debito")) OrElse tCust.Rows(j).Item("Debito") = Nothing, "C", "D") Then
                            Temp = True
                            Exit For
                        End If
                    Next
                    If Not Temp Then
                        DT_Distribucion.Rows(i).Delete()
                        Temp = False
                        GoTo Ciclo
                    End If
                End If
            Next

        End Sub

        Private Sub EliminaCuentaDistribucion(ByVal j As Integer)
            With ds1.Tables("ComprobantesDetalles").Rows(j)
                GuardaDatos("DELETE FROM Distribucion WHERE IdEmpresa = " & EmpresaActual & " AND NoComp = " & lblNoComprobante.Text & _
                " AND mes = " & dtpFecha.Value.Month & " AND per_id = " & VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.Value) & _
                " AND Cuenta = '" & .Item("Cuenta") & _
                "' AND Tipo = '" & Microsoft.VisualBasic.Strings.Left(.Item(4), 1) & "'")
            End With
        End Sub

        Private Sub ActualizaCuentaDistribucion(ByVal DebCred As String, ByVal j As Integer)
            Dim CuentaTemp As String = ObtieneDatos("SELECT CDet_Cuenta FROM ComprobantesDetalles WHERE CDet_ID = " & tCust.Rows(j)("Cdet_ID")).Rows(0).Item(0)
            GuardaDatos("DELETE FROM Distribucion WHERE IdEmpresa = " & EmpresaActual & " AND NoComp = " & lblNoComprobante.Text & _
            " AND mes = " & dtpFecha.Value.Month & " AND per_id = " & VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.Value) & _
            " AND Cuenta = '" & CuentaTemp & _
            "' AND Tipo = '" & DebCred & "'")
        End Sub

        Private Function VerificaDistribucion() As Boolean
            Dim DebitoCredito As String
            Dim Valor As Double
            For i As Integer = 0 To tCust.Rows.Count - 1
                With tCust.Rows(i)
                    Dim CTemp As String
                    Try
                        CTemp = ObtieneDatos("SELECT CuentaContable FROM RubrosGastos WHERE Activo = 1 AND CuentaContable = '" & .Item(1) & "' AND Empresa = " & EmpresaActual).Rows(0).Item(0)
                    Catch e As Exception
                        CTemp = ""
                    End Try
                    If CTemp <> Nothing Then
                        Dim DT As DataTable = DT_Distribucion
                        Dim Total As Double = 0
                        If IsDBNull(.Item("Debito")) OrElse IsNothing(.Item("Debito")) OrElse .Item("Debito") = Nothing Then
                            DebitoCredito = "C"
                            Valor = .Item("Credito")
                        Else
                            DebitoCredito = "D"
                            Valor = .Item("Debito")
                        End If
                        DT.DefaultView.RowFilter = "Cuenta = '" & .Item(1) & "' AND NoComp = " & lblNoComprobante.Text & _
                        " AND Per_Id = " & VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.Value) & " AND IdEmpresa = " & EmpresaActual & _
                        " AND Mes = " & Month(dtpFecha.Value) & " AND Tipo = '" & DebitoCredito & "'"
                        For j As Integer = 0 To DT.DefaultView.Count - 1
                            If DT.DefaultView.Item(j).Row.RowState <> DataRowState.Deleted Then Total += DT.DefaultView.Item(j).Row.Item("Valor")
                        Next
                        If Math.Round(Total, 2) <> Math.Round(Valor, 2) Then
                            MsgBox("La cuenta : " & .Item("Cuenta") & " tiene un valor de " & Format(Valor, "n2") & vbCrLf & _
                            " que no corresponde al valor distribuido de " & Format(Total, "n2"))
                            Return False
                        End If
                    End If
                End With
            Next
            Return True
        End Function

#End Region

#Region "Otras Funciones"

        Private Sub AddCustomDataTableStyle()
            ' CODIGO
            Dim ts1 As DataGridTableStyle
            ts1 = New DataGridTableStyle
            ts1.MappingName = "Articulos"
            ts1.AlternatingBackColor = Color.LightBlue
            Dim colCount As Integer
            colCount = 0

            Codigo = New DataGridComboBox(New ComboValueChanged(AddressOf MyComboCuentaValueChanged))
            Codigo.MappingName = "Codigo"
            Codigo.HeaderText = "Código"
            Codigo.Width = 0
            Codigo.ReadOnly = False
            ts1.GridColumnStyles.Add(Codigo)
            ts1.PreferredRowHeight = (Codigo.ColumnComboBox.Height + 3)
            Codigo.NullText = ""
            colCount = (colCount + 1)

            CCodigo = New DataGridComboBox(New ComboValueChanged(AddressOf MyComboCuentaValueChanged))
            CCodigo.MappingName = "cCodigo"
            CCodigo.HeaderText = "cCódigo"
            CCodigo.Width = 150
            CCodigo.ReadOnly = False
            ts1.GridColumnStyles.Add(CCodigo)
            ts1.PreferredRowHeight = (CCodigo.ColumnComboBox.Height + 3)
            CCodigo.NullText = ""
            colCount = (colCount + 1)

            ' CATALOGO
            Cuenta = New DataGridComboBox(New ComboValueChanged(AddressOf MyComboCuentaValueChanged))
            Cuenta.MappingName = "Cuenta"
            Cuenta.HeaderText = "Catalogo"
            Cuenta.Width = 300
            Cuenta.ReadOnly = False
            ts1.GridColumnStyles.Add(Cuenta)
            ts1.PreferredRowHeight = (Cuenta.ColumnComboBox.Height + 3)
            Cuenta.NullText = ""
            colCount = (colCount + 1)

            Dim i As Long
            Dim dsCatalogo As DataSet
            dsCatalogo = CatalogoDB.CatalogoList("A", 0)
            For i = 0 To dsCatalogo.Tables("CATALOGO").Rows.Count - 1
                Codigo.ColumnComboBox.Items.Add(dsCatalogo.Tables("CATALOGO").Rows(i).Item("Cuenta"))
                CCodigo.ColumnComboBox.Items.Add(dsCatalogo.Tables("CATALOGO").Rows(i).Item("Cuenta") & " - " & dsCatalogo.Tables("CATALOGO").Rows(i).Item("Nombre"))
                Cuenta.ColumnComboBox.Items.Add(dsCatalogo.Tables("CATALOGO").Rows(i).Item("Nombre"))
            Next

            ' IMPORTE ---------
            'Dim Precio As DataGridTextBoxColumn
            Debito = New DataGridTextBoxColumn
            Debito.MappingName = "Debito"
            Debito.HeaderText = "Débito"
            Debito.Width = 100
            Debito.Alignment = HorizontalAlignment.Right
            Debito.ReadOnly = False
            Debito.Format = "##,###0.00"

            AddHandler Debito.TextBox.Leave, New EventHandler(AddressOf DebitoMontoLeaveHandler)

            ts1.GridColumnStyles.Add(Debito)
            colCount = (colCount + 1)
            Debito.NullText = ""

            'Dim Credito As DataGridTextBoxColumn
            Credito = New DataGridTextBoxColumn
            Credito.MappingName = "Credito"
            Credito.HeaderText = "Crédito"
            Credito.Width = 100
            Credito.Alignment = HorizontalAlignment.Right
            Credito.ReadOnly = False
            Credito.Format = "##,###0.00"

            AddHandler Credito.TextBox.Leave, New EventHandler(AddressOf CreditoMontoLeaveHandler)

            ts1.GridColumnStyles.Add(Credito)
            colCount = (colCount + 1)
            Credito.NullText = ""

            ' CONCEPTO
            'ConceptoID = New DataGridComboBox(New ComboValueChanged(AddressOf MyComboValueChanged))
            'ConceptoID.MappingName = "ConceptoID"
            'ConceptoID.HeaderText = "ConceptoID"
            'ConceptoID.Width = 0
            'ts1.GridColumnStyles.Add(ConceptoID)
            'ts1.PreferredRowHeight = (ConceptoID.ColumnComboBox.Height + 3)
            'ConceptoID.NullText = ""
            'colCount = (colCount + 1)

            Concepto = New DataGridTextBoxColumn
            Concepto.MappingName = "Concepto"
            Concepto.HeaderText = "Concepto"
            Concepto.Width = 230
            Concepto.Alignment = HorizontalAlignment.Left
            ts1.GridColumnStyles.Add(Concepto)
            ts1.PreferredRowHeight = (Concepto.TextBox.Height + 3)
            Concepto.NullText = ""
            colCount = (colCount + 1)



            '*****************************************************************************************

            'Dim Credito As DataGridTextBoxColumn
            CdetID = New DataGridTextBoxColumn
            CdetID.MappingName = "CDet_Id"
            CdetID.HeaderText = "CDet_Id"
            CdetID.Width = 100
            CdetID.Alignment = HorizontalAlignment.Right
            CdetID.ReadOnly = True

            '            AddHandler Credito.TextBox.Leave, New EventHandler(AddressOf CreditoMontoLeaveHandler)

            ts1.GridColumnStyles.Add(CdetID)
            colCount = (colCount + 1)
            '  CdetID.NullText = ""


            '*****************************************************************************************

            'Dim Ds As New DataSet()
            'Ds = Concept.GetList()
            'For i = 0 To Ds.Tables("Conceptos").Rows.Count - 1
            '    Concepto.ColumnComboBox.Items.Add(Ds.Tables("Conceptos").Rows(i).Item("Nombre"))
            '    ConceptoID.ColumnComboBox.Items.Add(Ds.Tables("Conceptos").Rows(i).Item("Codigo"))
            'Next



            '' DEBITO / CREDITO --- 0 / 1 
            'Tipo = New DataGridComboBox(New ComboValueChanged(AddressOf MyComboCredito))
            'Tipo.MappingName = "Tipo"
            'Tipo.HeaderText = "Débito/Crédito"
            'Tipo.Width = 100
            'Tipo.Alignment = HorizontalAlignment.Left
            'Tipo.ReadOnly = True
            'Tipo.ColumnComboBox.Items.Add("Débito")
            'Tipo.ColumnComboBox.Items.Add("Crédito")

            'ts1.GridColumnStyles.Add(Tipo)
            'colCount = (colCount + 1)
            'Tipo.NullText = "-Seleccione-"

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            'STEP 6: Add the tablestyle to your datagrids tablestlye collection

            ts1.AllowSorting = False
            ts1.GridLineColor = Color.FromArgb(70, 130, 180)
            ts1.HeaderFont = Me.dgFacturacionCliente.HeaderFont
            ts1.HeaderBackColor = Color.LightSteelBlue  'Color.LightBlue
            ts1.PreferredRowHeight = 25

            Me.dgFacturacionCliente.CaptionVisible = False
            Me.dgFacturacionCliente.TableStyles.Clear()
            Me.dgFacturacionCliente.TableStyles.Add(ts1)

        End Sub

        Private Sub MakeDataSet()

            ' Create a DataSet.
            myDataSet = New DataSet("myDataSet")

            ' Create two DataTables.
            tCust = New DataTable("Articulos")

            ' Create two columns, and add them to the first table.
            Dim ccCodigo As DataColumn
            ccCodigo = New DataColumn("cCodigo")

            Dim cCodigo As DataColumn
            cCodigo = New DataColumn("Codigo")

            Dim cCatalogo As DataColumn
            cCatalogo = New DataColumn("Cuenta")

            Dim cConcepto As DataColumn
            cConcepto = New DataColumn("Concepto")

            Dim cMonto As DataColumn
            cMonto = New DataColumn("Debito")

            Dim cCredito As DataColumn
            cCredito = New DataColumn("Credito")

            Dim cTipo As DataColumn
            cTipo = New DataColumn("Tipo")

            Dim cConceptoID As DataColumn
            cConceptoID = New DataColumn("ConceptoID")

            Dim cCDetID As DataColumn
            cCDetID = New DataColumn("CDet_Id")

            tCust.Columns.Add(ccCodigo)
            tCust.Columns.Add(cCodigo)
            tCust.Columns.Add(cCatalogo)
            tCust.Columns.Add(cMonto)
            tCust.Columns.Add(cCredito)
            tCust.Columns.Add(cConcepto)
            tCust.Columns.Add(cTipo)
            tCust.Columns.Add(cConceptoID)
            tCust.Columns.Add(cCDetID)

            myDataSet.Tables.Add(tCust)

            Dim newRow1 As DataRow

            Dim j As Integer
            DebitoMonto = 0
            CreditoMonto = 0

            For j = 0 To ds1.Tables("ComprobantesDetalles").Rows.Count - 1
                newRow1 = tCust.NewRow
                newRow1("Codigo") = ds1.Tables("ComprobantesDetalles").Rows(j).Item("Cuenta")
                tCust.Rows.Add(newRow1)

                tCust.Rows(j)("cCodigo") = ds1.Tables("ComprobantesDetalles").Rows(j).Item("Cuenta") & " - " & ds1.Tables("ComprobantesDetalles").Rows(j).Item("Nombre")
                tCust.Rows(j)("Cuenta") = ds1.Tables("ComprobantesDetalles").Rows(j).Item("Nombre")

                tCust.Rows(j)("Concepto") = ds1.Tables("ComprobantesDetalles").Rows(j).Item("Concepto")

                If ds1.Tables("ComprobantesDetalles").Rows(j).Item("Proceso") = "Débito" Then
                    'tCust.Rows(j)("Debito") = CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("Monto")).ToString(Round)
                    tCust.Rows(j)("Debito") = CDbl(CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("Monto")) * CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("TasaCambio"))).ToString(Round)
                    DebitoMonto = DebitoMonto + (CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("Monto")) * CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("TasaCambio")))
                ElseIf ds1.Tables("ComprobantesDetalles").Rows(j).Item("Proceso") = "Crédito" Then
                    tCust.Rows(j)("Credito") = CDbl(CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("Monto")) * CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("TasaCambio"))).ToString(Round) 'CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("Monto")).ToString(Round)
                    CreditoMonto = CreditoMonto + (CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("Monto")) * CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("TasaCambio")))
                End If

                Me.lblDebito.Text = DebitoMonto.ToString(Round)
                Me.lblCredito.Text = CreditoMonto.ToString(Round)

                tCust.Rows(j)("CDet_Id") = ds1.Tables("ComprobantesDetalles").Rows(j).Item("CDet_Id")

                'tCust.Rows(j)("Proceso") = ds1.Tables("ComprobantesDetalles").Rows(j).Item("Proceso")
            Next
        End Sub

        Public Sub MyComboCuentaValueChanged(ByVal rowChanging As Integer, ByVal newValue As Object)
            Console.WriteLine("index changed {0} {1}", rowChanging, newValue)

            Try
                If Indice >= 0 Then

                    If tCust.Rows.Count < rowChanging + 1 Then
                        Dim newRow1 As DataRow
                        newRow1 = tCust.NewRow
                        newRow1("Codigo") = Codigo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows.Add(newRow1)

                        tCust.Rows(rowChanging)("Cuenta") = Cuenta.ColumnComboBox.Items.Item(Indice)
                    Else
                        tCust.Rows(rowChanging)("cCodigo") = Codigo.ColumnComboBox.Items.Item(Indice) & " - " & Cuenta.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Codigo") = Codigo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Cuenta") = Cuenta.ColumnComboBox.Items.Item(Indice)
                    End If

                End If
            Catch ex As Exception
                MsgBox(ex.Message & "MyComboValueChanged")
            End Try
        End Sub

        Dim c As Boolean
        Private Sub DebitoMontoLeaveHandler(ByVal sender As Object, ByVal e As EventArgs)
            If Me.dgFacturacionCliente.CurrentRowIndex = Me.tCust.Rows.Count Then
                Exit Sub
            End If

            If Debito.TextBox.Text.ToString = "" Or Debito.TextBox.Text.ToString Is DBNull.Value Then
                tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Debito") = "0.00"
                c = True
                'Exit Sub
            Else
                c = False
                If Not IsNumeric(Debito.TextBox.Text) Then
                    'If Me.dgFacturacionCliente.Item(Me.dgFacturacionCliente.CurrentRowIndex, 2) Is DBNull.Value Then
                    '    Debito.TextBox.Text = ""
                    'Else
                    '    Debito.TextBox.Text = CDbl(Me.dgFacturacionCliente.Item(Me.dgFacturacionCliente.CurrentRowIndex, 2)).ToString(Round) 'CDbl(tCust.Rows(Me.dgCatalogo.CurrentRowIndex)("Monto")).ToString(Round) 'ValorActualCantidad
                    'End If

                    MsgBox("Introduzca un monto válido", MsgBoxStyle.Information)
                    Me.dgFacturacionCliente.Focus()
                    Debito.TextBox.Focus()
                    Debito.TextBox.Text = ""
                    tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Debito") = ""
                    'Exit Sub
                Else
                    'If CDbl(Monto.TextBox.Text) <= 0 Then
                    '    MsgBox("La cantidad debe ser mayor que Cero (0)", MsgBoxStyle.Information)
                    '    If Me.dgCatalogo.Item(Me.dgCatalogo.CurrentRowIndex, 2) Is DBNull.Value Then
                    '        Monto.TextBox.Text = "0.00"
                    '    Else
                    '        Monto.TextBox.Text = CDbl(Me.dgCatalogo.Item(Me.dgCatalogo.CurrentRowIndex, 2)).ToString(Round) 'CDbl(tCust.Rows(Me.dgCatalogo.CurrentRowIndex)("Monto")).ToString(Round) 'ValorActualCantidad
                    '    End If

                    '    Me.dgCatalogo.Focus()
                    '    Monto.TextBox.Focus()
                    '    Exit Sub
                    'Else
                    'End If

                    Debito.TextBox.Text = CDbl(Debito.TextBox.Text).ToString(Round)
                    tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Debito") = CDbl(Debito.TextBox.Text).ToString(Round)
                    tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Credito") = ""
                    'Credito.TextBox.Text = ""
                End If
            End If

            DebitoMonto = 0
            CreditoMonto = 0

            For i = 0 To tCust.Rows.Count - 1
                If tCust.Rows(i)("Debito") Is DBNull.Value Or tCust.Rows(i)("Debito").ToString = "" Then
                Else
                    DebitoMonto = DebitoMonto + CDbl(tCust.Rows(i)("Debito"))
                End If

                If tCust.Rows(i)("Credito") Is DBNull.Value Or tCust.Rows(i)("Credito").ToString = "" Then
                Else
                    CreditoMonto = CreditoMonto + CDbl(tCust.Rows(i)("Credito"))
                End If
            Next

            Me.lblDebito.Text = DebitoMonto.ToString(Round)
            Me.lblCredito.Text = CreditoMonto.ToString(Round)

            Me.lblDiferencia.Text = CDbl(DebitoMonto - CreditoMonto).ToString(Round)

            If c = True Then
                tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Debito") = ""
            End If
        End Sub

        Private Sub CreditoMontoLeaveHandler(ByVal sender As Object, ByVal e As EventArgs)
            If Me.dgFacturacionCliente.CurrentRowIndex = Me.tCust.Rows.Count Then
                Exit Sub
            End If

            If Credito.TextBox.Text.ToString = "" Or Credito.TextBox.Text.ToString Is DBNull.Value Then
                tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Credito") = "0.00"
                c = True
                'Exit Sub
            Else
                c = False
                If Not IsNumeric(Credito.TextBox.Text) Then
                    'If Me.dgFacturacionCliente.Item(Me.dgFacturacionCliente.CurrentRowIndex, 3) Is DBNull.Value Then
                    '    Credito.TextBox.Text = ""
                    'Else
                    '    Credito.TextBox.Text = CDbl(Me.dgFacturacionCliente.Item(Me.dgFacturacionCliente.CurrentRowIndex, 3)).ToString(Round)
                    'End If

                    MsgBox("Introduzca un monto válido", MsgBoxStyle.Information)
                    Me.dgFacturacionCliente.Focus()
                    Credito.TextBox.Focus()
                    Credito.TextBox.Text = ""
                    tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Credito") = ""

                    'Exit Sub
                Else
                    'If CDbl(Monto.TextBox.Text) <= 0 Then
                    '    MsgBox("La cantidad debe ser mayor que Cero (0)", MsgBoxStyle.Information)
                    '    If Me.dgCatalogo.Item(Me.dgCatalogo.CurrentRowIndex, 2) Is DBNull.Value Then
                    '        Monto.TextBox.Text = "0.00"
                    '    Else
                    '        Monto.TextBox.Text = CDbl(Me.dgCatalogo.Item(Me.dgCatalogo.CurrentRowIndex, 2)).ToString(Round) 'CDbl(tCust.Rows(Me.dgCatalogo.CurrentRowIndex)("Monto")).ToString(Round) 'ValorActualCantidad
                    '    End If

                    '    Me.dgCatalogo.Focus()
                    '    Monto.TextBox.Focus()
                    '    Exit Sub
                    'Else
                    'End If
                    tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Credito") = CDbl(Credito.TextBox.Text).ToString(Round)
                    Credito.TextBox.Text = CDbl(Credito.TextBox.Text).ToString(Round)
                    tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Debito") = ""
                    'Debito.TextBox.Text = ""
                End If
            End If

            CreditoMonto = 0
            DebitoMonto = 0
            For i = 0 To tCust.Rows.Count - 1
                If tCust.Rows(i)("Credito") Is DBNull.Value Or tCust.Rows(i)("Credito").ToString = "" Then
                Else
                    CreditoMonto = CreditoMonto + CDbl(tCust.Rows(i)("Credito"))
                End If

                If tCust.Rows(i)("Debito") Is DBNull.Value Or tCust.Rows(i)("Debito").ToString = "" Then
                Else
                    DebitoMonto = DebitoMonto + CDbl(tCust.Rows(i)("Debito"))
                End If
            Next

            Me.lblDebito.Text = DebitoMonto.ToString(Round)
            Me.lblCredito.Text = CreditoMonto.ToString(Round)

            Me.lblDiferencia.Text = CDbl(DebitoMonto - CreditoMonto).ToString(Round)

            If c = True Then
                tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Credito") = ""
            End If

        End Sub

        Private Sub cmdAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnular.Click
            Dim Registros As Integer
            Registros = comp.ComprobanteAnularBuscar(Me.lblNoComprobante.Text, Me.lblPeriodo.Text, Me.txtFecha.Text)
            If Registros > 0 Then
                MsgBox("El comprobante ya fue anulado", MsgBoxStyle.Information)
                Exit Sub
            End If
            'Si es una factura de compra
            If compDet.Factura <> "" Then
                If compDet.Proveedor <> "0" And compDet.Proveedor <> "" Then
                    MsgBox("No se puede borrar un comprobante de Factura de Compra, vaya al modulo correspondiente para anular la factura", MsgBoxStyle.Critical, "STS-Contab")
                    Exit Sub
                Else
                    MsgBox("No se puede borrar un comprobante de Factura de Venta, vaya al modulo correspondiente para anular la factura", MsgBoxStyle.Critical, "STS-Contab")
                    Exit Sub
                End If
            End If

            If MsgBox("¿Esta seguro que desea anular el comprobante No.: " & Me.lblNoComprobante.Text & " de la fecha: " & Me.txtFecha.Text, MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
                Exit Sub
            End If

            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction

            Try
                comp.ComprobanteAnular(Me.lblNoComprobante.Text, Me.lblPeriodo.Text, Me.txtFecha.Text)
                comp.CancelarFactura(compDet.Factura1, compDet.Proveedor, 0)
                comp.PagosFacturasBorrar(Me.lblNoComprobante.Text, Month(Me.txtFecha.Text), Me.lblPeriodo.Text)
                Me.dgFacturacionCliente.ReadOnly = True
                Me.txtConcepto.ReadOnly = True
                Me.txtFecha.Enabled = False
                Me.cbTipoComp.Enabled = False
                Me.cmdAceptar.Enabled = False
                Me.cmdAnular.Enabled = False
                Me.etAnulado.Visible = True
                '------------------------------
                '------------------------------
                'EliminaDistribucion(Me.lblNoComprobante.Text, Me.lblPeriodo.Text, Me.dtpFecha.Value.Month)
                '------------------------------
                '------------------------------
                VB.SysContab.Rutinas.okTransaccion()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
                VB.SysContab.Rutinas.ErrorTransaccion()
                Exit Sub
            End Try
        End Sub

        Private Sub dgFacturacionCliente_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFacturacionCliente.DoubleClick

            If (IsDBNull(dgFacturacionCliente.Item(dgFacturacionCliente.CurrentRowIndex, 0)) _
            Or IsDBNull(dgFacturacionCliente.Item(dgFacturacionCliente.CurrentRowIndex, 3))) _
            And IsDBNull(dgFacturacionCliente.Item(dgFacturacionCliente.CurrentRowIndex, 4)) Then Exit Sub
            Try
                If dgFacturacionCliente.CurrentRowIndex >= 0 Then
                    Dim forma As New FrmDetalleRequisas
                    With dgFacturacionCliente
                        forma.Cuenta = .Item(.CurrentRowIndex, 0)
                        If IsDBNull(.Item(.CurrentRowIndex, 3)) OrElse IsNothing(.Item(.CurrentRowIndex, 3)) OrElse .Item(.CurrentRowIndex, 3) = Nothing Then
                            forma.Monto = .Item(.CurrentRowIndex, 4)
                            forma.Tipo = "C"
                            forma.Periodo = VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.Value)
                            forma.CompNo = lblNoComprobante.Text
                            forma.Cuenta = .Item(.CurrentRowIndex, 0)
                            forma.Mes = dtpFecha.Value.Month
                        Else
                            forma.Monto = .Item(.CurrentRowIndex, 3)
                            forma.Tipo = "D"
                            forma.Periodo = VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.Value)
                            forma.CompNo = lblNoComprobante.Text
                            forma.Cuenta = .Item(.CurrentRowIndex, 0)
                            forma.Mes = dtpFecha.Value.Month
                        End If
                        'MsgBox(forma.Tipo)
                        'forma.GridView1.OptionsBehavior.Editable = False
                        'forma.cmdaceptar.Visible = False
                        forma.Mostrar(DT_Distribucion)
                        Me.DT_Distribucion.DefaultView.RowFilter = ""
                    End With
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End Sub

        Private Sub frmComprobantesDetalles_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
            SetTiempos(OrigenComprobantes.NATURAL, funciones.Tiempos.TiempoInicio, Now, funciones.Eventos.Salir, lblNoComprobante.Text)
        End Sub

        Private Sub cmdDetalleDistribucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDetalleDistribucion.Click
            Dim f As New FrmEstadoResultadosDetallesDistribucion
            f.Text = "Detalles de Distribución"
            f.StartPosition = FormStartPosition.CenterParent

            f.Grid.Parent = f
            f.Grid.Dock = DockStyle.Fill

            Dim a As String
            Dim Ds As New DataSet

            Ds = VB.SysContab.DistribucionDB.GetData(lblNoComprobante.Text, _
                 Me.lblPeriodo.Text, Me.txtFecha.Text, compDet.Moneda)


            f.Grid.DataSource = Ds.Tables(0)

            f.Width = 1024
            f.Height = 400
            f.ShowDialog()
            f.Dispose()
        End Sub

        Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
            Me.Close()
        End Sub

        Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
            'Dim ValorLetras As String = VB.SysContab.Rutinas.Letras(CDbl(lblDebito.Text).ToString(Round))
            'Dim fReportes As New frmReportes
            'Dim rFactura As New rptComprobante

            'Dim Ds As New DataSet

            'Ds = comp.ImprimirCombrobante(lblNoComprobante.Text, lblPeriodo.Text, ValorLetras, Me.txtFecha.Text, CDbl(lblDebito.Text))

            'Ds.WriteXml(Application.StartupPath & "\xml\rComprobante.xml", XmlWriteMode.WriteSchema)

            'rFactura.Database.Tables("ComprobantesImpreso").Location = Application.StartupPath & "\xml\rComprobante.xml"
            'rFactura.Database.Tables("ComprobantesImpresoDetalle").Location = Application.StartupPath & "\xml\rComprobante.xml"

            'fReportes.crvReportes.ReportSource = rFactura

            'fReportes.crvReportes.Zoom(91)
            'fReportes.Show()

            'fReportes.Show()

            ''Dim ValorLetras As String = VB.SysContab.Rutinas.ConversionDecimales(CDbl(lblDebito.Text).ToString(Round))
            ''Dim fReportes As New frmReportes()
            '''If lblCheque.Text = "0" Then
            ''Dim rFactura As New rptComprobante()

            '''Dim i As Integer
            '''For i = 0 To rFactura.ReportDefinition.ReportObjects.Count - 1
            '''    MsgBox(rFactura.ReportDefinition.ReportObjects.Item(i).Name.ToString)
            '''Next

            ''rFactura.SetDataSource(comp.ImprimirCombrobante(lblNoComprobante.Text, lblPeriodo.Text, ValorLetras, Me.txtFecha.Text, CDbl(lblDebito.Text)))
            ''fReportes.crvReportes.ReportSource = rFactura

            '''rfactura.

            '''Else
            '''    Dim rFactura As New rptComprobanteCheque()
            '''    rFactura.SetDataSource(comp.ImprimirCombrobante(lblNoComprobante.Text, lblPeriodo.Text, ValorLetras, Me.txtFecha.Text, CDbl(lblDebito.Text)))
            '''    fReportes.crvReportes.ReportSource = rFactura
            '''End If

            ''fReportes.Show()
        End Sub

#End Region

    End Class

End Namespace

