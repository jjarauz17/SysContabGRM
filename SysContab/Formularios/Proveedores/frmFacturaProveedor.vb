Imports System
Imports System.Data
Imports System.Data.SqlClient

Namespace DataGridTextBoxCombo
    Public Class frmFacturaProveedor
        Inherits DevExpress.XtraEditors.XtraForm

        Private Shared ChildInstance As frmFacturaProveedor = Nothing

        Public Shared Function Instance() As frmFacturaProveedor
            If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
                ChildInstance = New frmFacturaProveedor()
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
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtMonto As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
        Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents txtDocumento As System.Windows.Forms.TextBox
        Friend WithEvents etInicio As System.Windows.Forms.Label
        Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents dgCatalogo As System.Windows.Forms.DataGrid
        Friend WithEvents cbTipoComp As System.Windows.Forms.ComboBox
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents cmdRecalcular As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents cbFormaPago As System.Windows.Forms.ComboBox
        Friend WithEvents txtFactura As System.Windows.Forms.TextBox
        Friend WithEvents cbProveedor As System.Windows.Forms.ComboBox
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaPago As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents cbCuenta As System.Windows.Forms.ComboBox
        Friend WithEvents cmdFacturas As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaRecepcion As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents lblcredito As System.Windows.Forms.Label
        Friend WithEvents lbldebito As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents lbldiferencia As System.Windows.Forms.Label
        Friend WithEvents lbldiferencias As System.Windows.Forms.Label
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            Me.dtpFechaRecepcion = New System.Windows.Forms.DateTimePicker
            Me.Label8 = New System.Windows.Forms.Label
            Me.cbCuenta = New System.Windows.Forms.ComboBox
            Me.Label4 = New System.Windows.Forms.Label
            Me.dtpFechaPago = New System.Windows.Forms.DateTimePicker
            Me.Label11 = New System.Windows.Forms.Label
            Me.cbFormaPago = New System.Windows.Forms.ComboBox
            Me.Label25 = New System.Windows.Forms.Label
            Me.Label9 = New System.Windows.Forms.Label
            Me.etInicio = New System.Windows.Forms.Label
            Me.Label5 = New System.Windows.Forms.Label
            Me.txtFactura = New System.Windows.Forms.TextBox
            Me.Label3 = New System.Windows.Forms.Label
            Me.txtMonto = New System.Windows.Forms.TextBox
            Me.cbProveedor = New System.Windows.Forms.ComboBox
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label2 = New System.Windows.Forms.Label
            Me.dtpFecha = New System.Windows.Forms.DateTimePicker
            Me.Label6 = New System.Windows.Forms.Label
            Me.txtConcepto = New System.Windows.Forms.TextBox
            Me.cbTipoComp = New System.Windows.Forms.ComboBox
            Me.Label7 = New System.Windows.Forms.Label
            Me.txtDocumento = New System.Windows.Forms.TextBox
            Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
            Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
            Me.dgCatalogo = New System.Windows.Forms.DataGrid
            Me.cmdRecalcular = New DevExpress.XtraEditors.SimpleButton
            Me.cmdFacturas = New DevExpress.XtraEditors.SimpleButton
            Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
            Me.Label10 = New System.Windows.Forms.Label
            Me.lblcredito = New System.Windows.Forms.Label
            Me.lbldebito = New System.Windows.Forms.Label
            Me.Label13 = New System.Windows.Forms.Label
            Me.lbldiferencia = New System.Windows.Forms.Label
            Me.lbldiferencias = New System.Windows.Forms.Label
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.dtpFechaRecepcion)
            Me.GroupBox1.Controls.Add(Me.Label8)
            Me.GroupBox1.Controls.Add(Me.cbCuenta)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.dtpFechaPago)
            Me.GroupBox1.Controls.Add(Me.Label11)
            Me.GroupBox1.Controls.Add(Me.cbFormaPago)
            Me.GroupBox1.Controls.Add(Me.Label25)
            Me.GroupBox1.Controls.Add(Me.Label9)
            Me.GroupBox1.Controls.Add(Me.etInicio)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.txtFactura)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.txtMonto)
            Me.GroupBox1.Controls.Add(Me.cbProveedor)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.dtpFecha)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.txtConcepto)
            Me.GroupBox1.Controls.Add(Me.cbTipoComp)
            Me.GroupBox1.Location = New System.Drawing.Point(8, 17)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1000, 190)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            '
            'dtpFechaRecepcion
            '
            Me.dtpFechaRecepcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaRecepcion.Location = New System.Drawing.Point(840, 121)
            Me.dtpFechaRecepcion.Name = "dtpFechaRecepcion"
            Me.dtpFechaRecepcion.Size = New System.Drawing.Size(96, 20)
            Me.dtpFechaRecepcion.TabIndex = 164
            Me.dtpFechaRecepcion.Value = New Date(2006, 8, 10, 10, 38, 43, 562)
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.SystemColors.Control
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label8.Location = New System.Drawing.Point(696, 121)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(136, 25)
            Me.Label8.TabIndex = 165
            Me.Label8.Text = "Fecha de Recepcion:"
            '
            'cbCuenta
            '
            Me.cbCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbCuenta.Location = New System.Drawing.Point(152, 52)
            Me.cbCuenta.Name = "cbCuenta"
            Me.cbCuenta.Size = New System.Drawing.Size(480, 21)
            Me.cbCuenta.TabIndex = 162
            '
            'Label4
            '
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label4.Location = New System.Drawing.Point(16, 52)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(72, 26)
            Me.Label4.TabIndex = 163
            Me.Label4.Text = "Cuenta:"
            '
            'dtpFechaPago
            '
            Me.dtpFechaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaPago.Location = New System.Drawing.Point(840, 86)
            Me.dtpFechaPago.Name = "dtpFechaPago"
            Me.dtpFechaPago.Size = New System.Drawing.Size(96, 20)
            Me.dtpFechaPago.TabIndex = 6
            Me.dtpFechaPago.Value = New Date(2006, 8, 10, 10, 38, 43, 562)
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.SystemColors.Control
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label11.Location = New System.Drawing.Point(728, 86)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(112, 26)
            Me.Label11.TabIndex = 161
            Me.Label11.Text = "Fecha de Pago:"
            '
            'cbFormaPago
            '
            Me.cbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbFormaPago.Location = New System.Drawing.Point(152, 86)
            Me.cbFormaPago.Name = "cbFormaPago"
            Me.cbFormaPago.Size = New System.Drawing.Size(208, 21)
            Me.cbFormaPago.TabIndex = 1
            '
            'Label25
            '
            Me.Label25.BackColor = System.Drawing.SystemColors.Control
            Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label25.Location = New System.Drawing.Point(16, 86)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(104, 26)
            Me.Label25.TabIndex = 160
            Me.Label25.Text = "Forma de Pago:"
            '
            'Label9
            '
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label9.Location = New System.Drawing.Point(344, 103)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(40, 26)
            Me.Label9.TabIndex = 158
            Me.Label9.Text = "Tipo:"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'etInicio
            '
            Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etInicio.Location = New System.Drawing.Point(392, 78)
            Me.etInicio.Name = "etInicio"
            Me.etInicio.Size = New System.Drawing.Size(104, 25)
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
            Me.Label5.Text = "No. de Factura:"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtFactura
            '
            Me.txtFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFactura.Location = New System.Drawing.Point(840, 17)
            Me.txtFactura.MaxLength = 13
            Me.txtFactura.Name = "txtFactura"
            Me.txtFactura.Size = New System.Drawing.Size(152, 20)
            Me.txtFactura.TabIndex = 4
            '
            'Label3
            '
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(16, 121)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(104, 25)
            Me.Label3.TabIndex = 148
            Me.Label3.Text = "Monto:"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtMonto
            '
            Me.txtMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMonto.Location = New System.Drawing.Point(152, 121)
            Me.txtMonto.MaxLength = 13
            Me.txtMonto.Name = "txtMonto"
            Me.txtMonto.Size = New System.Drawing.Size(136, 20)
            Me.txtMonto.TabIndex = 2
            Me.txtMonto.Text = "0.00"
            '
            'cbProveedor
            '
            Me.cbProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbProveedor.Location = New System.Drawing.Point(152, 17)
            Me.cbProveedor.Name = "cbProveedor"
            Me.cbProveedor.Size = New System.Drawing.Size(480, 21)
            Me.cbProveedor.TabIndex = 0
            '
            'Label1
            '
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(16, 17)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(72, 26)
            Me.Label1.TabIndex = 145
            Me.Label1.Text = "Proveedor:"
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
            Me.dtpFecha.TabIndex = 5
            '
            'Label6
            '
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(16, 155)
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
            Me.txtConcepto.Location = New System.Drawing.Point(152, 155)
            Me.txtConcepto.MaxLength = 100
            Me.txtConcepto.Name = "txtConcepto"
            Me.txtConcepto.Size = New System.Drawing.Size(840, 20)
            Me.txtConcepto.TabIndex = 3
            '
            'cbTipoComp
            '
            Me.cbTipoComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbTipoComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbTipoComp.Location = New System.Drawing.Point(392, 103)
            Me.cbTipoComp.Name = "cbTipoComp"
            Me.cbTipoComp.Size = New System.Drawing.Size(240, 21)
            Me.cbTipoComp.TabIndex = 151
            '
            'Label7
            '
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label7.Location = New System.Drawing.Point(416, 0)
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
            Me.txtDocumento.Location = New System.Drawing.Point(552, 0)
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
            Me.cmdAceptar.Location = New System.Drawing.Point(16, 477)
            Me.cmdAceptar.Name = "cmdAceptar"
            Me.cmdAceptar.Size = New System.Drawing.Size(72, 26)
            Me.cmdAceptar.TabIndex = 8
            Me.cmdAceptar.Text = "&Guardar"
            '
            'cmdSalir
            '
            Me.cmdSalir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdSalir.Appearance.Options.UseFont = True
            Me.cmdSalir.Location = New System.Drawing.Point(368, 477)
            Me.cmdSalir.Name = "cmdSalir"
            Me.cmdSalir.Size = New System.Drawing.Size(72, 26)
            Me.cmdSalir.TabIndex = 10
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
            Me.dgCatalogo.Location = New System.Drawing.Point(8, 215)
            Me.dgCatalogo.Name = "dgCatalogo"
            Me.dgCatalogo.ParentRowsBackColor = System.Drawing.Color.LightGray
            Me.dgCatalogo.ParentRowsForeColor = System.Drawing.Color.Black
            Me.dgCatalogo.SelectionBackColor = System.Drawing.Color.Firebrick
            Me.dgCatalogo.SelectionForeColor = System.Drawing.Color.White
            Me.dgCatalogo.Size = New System.Drawing.Size(1000, 253)
            Me.dgCatalogo.TabIndex = 7
            '
            'cmdRecalcular
            '
            Me.cmdRecalcular.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdRecalcular.Appearance.Options.UseFont = True
            Me.cmdRecalcular.Location = New System.Drawing.Point(104, 477)
            Me.cmdRecalcular.Name = "cmdRecalcular"
            Me.cmdRecalcular.Size = New System.Drawing.Size(72, 26)
            Me.cmdRecalcular.TabIndex = 9
            Me.cmdRecalcular.Text = "&Recalcular"
            '
            'cmdFacturas
            '
            Me.cmdFacturas.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdFacturas.Appearance.Options.UseFont = True
            Me.cmdFacturas.Location = New System.Drawing.Point(192, 477)
            Me.cmdFacturas.Name = "cmdFacturas"
            Me.cmdFacturas.Size = New System.Drawing.Size(72, 26)
            Me.cmdFacturas.TabIndex = 155
            Me.cmdFacturas.Text = "&Facturas"
            '
            'cmdAyuda
            '
            Me.cmdAyuda.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdAyuda.Appearance.Options.UseFont = True
            Me.cmdAyuda.Location = New System.Drawing.Point(280, 477)
            Me.cmdAyuda.Name = "cmdAyuda"
            Me.cmdAyuda.Size = New System.Drawing.Size(72, 26)
            Me.cmdAyuda.TabIndex = 156
            Me.cmdAyuda.Text = "&Ayuda"
            '
            'Label10
            '
            Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.ForeColor = System.Drawing.Color.Maroon
            Me.Label10.Location = New System.Drawing.Point(488, 486)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(64, 17)
            Me.Label10.TabIndex = 157
            Me.Label10.Text = "Credito:"
            '
            'lblcredito
            '
            Me.lblcredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblcredito.ForeColor = System.Drawing.Color.Maroon
            Me.lblcredito.Location = New System.Drawing.Point(552, 486)
            Me.lblcredito.Name = "lblcredito"
            Me.lblcredito.Size = New System.Drawing.Size(72, 17)
            Me.lblcredito.TabIndex = 157
            Me.lblcredito.Text = "0.00"
            '
            'lbldebito
            '
            Me.lbldebito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbldebito.ForeColor = System.Drawing.Color.Maroon
            Me.lbldebito.Location = New System.Drawing.Point(704, 486)
            Me.lbldebito.Name = "lbldebito"
            Me.lbldebito.Size = New System.Drawing.Size(72, 17)
            Me.lbldebito.TabIndex = 157
            Me.lbldebito.Text = "0.00"
            '
            'Label13
            '
            Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.ForeColor = System.Drawing.Color.Maroon
            Me.Label13.Location = New System.Drawing.Point(640, 486)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(64, 17)
            Me.Label13.TabIndex = 157
            Me.Label13.Text = "Debito:"
            '
            'lbldiferencia
            '
            Me.lbldiferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbldiferencia.ForeColor = System.Drawing.Color.Maroon
            Me.lbldiferencia.Location = New System.Drawing.Point(872, 486)
            Me.lbldiferencia.Name = "lbldiferencia"
            Me.lbldiferencia.Size = New System.Drawing.Size(72, 17)
            Me.lbldiferencia.TabIndex = 157
            Me.lbldiferencia.Text = "0.00"
            '
            'lbldiferencias
            '
            Me.lbldiferencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbldiferencias.ForeColor = System.Drawing.Color.Maroon
            Me.lbldiferencias.Location = New System.Drawing.Point(800, 486)
            Me.lbldiferencias.Name = "lbldiferencias"
            Me.lbldiferencias.Size = New System.Drawing.Size(65, 17)
            Me.lbldiferencias.TabIndex = 157
            Me.lbldiferencias.Text = "Diferencia:"
            '
            'frmFacturaProveedor
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(1016, 515)
            Me.Controls.Add(Me.Label10)
            Me.Controls.Add(Me.cmdAyuda)
            Me.Controls.Add(Me.cmdFacturas)
            Me.Controls.Add(Me.cmdRecalcular)
            Me.Controls.Add(Me.dgCatalogo)
            Me.Controls.Add(Me.cmdSalir)
            Me.Controls.Add(Me.cmdAceptar)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.txtDocumento)
            Me.Controls.Add(Me.lblcredito)
            Me.Controls.Add(Me.lbldebito)
            Me.Controls.Add(Me.Label13)
            Me.Controls.Add(Me.lbldiferencia)
            Me.Controls.Add(Me.lbldiferencias)
            Me.Name = "frmFacturaProveedor"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.dgCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

#Region "Variables"
        Dim WithEvents tCust As DataTable
        Private WithEvents myDataSet As DataSet
        Dim ds As DataSet
        Dim ds1 As DataSet
        Dim ds2 As DataSet

        Dim WithEvents Codigo1 As DataGridComboBoxColumn
        Dim WithEvents Codigo As DataGridComboBoxColumn
        Dim WithEvents Descripcion As DataGridComboBoxColumn
        Dim Monto As DataGridTextBoxColumn

        Dim Proveedores As New VB.SysContab.ProveedoresDB
        Dim ProveedoresDetalles As New VB.SysContab.ProveedoresDetails
        Dim Catalogo As New VB.SysContab.CatalogoDB
        Private Comprobantes As New VB.SysContab.ComprobanteDB
        Dim PeriodosDB As New VB.SysContab.PeriodosDB
        Dim compDet As New VB.SysContab.ComprobantesDetails
        Dim Clientes As New VB.SysContab.ClientesDB

        Dim FormaPago As New VB.SysContab.Forma_PagoDB
        Dim r As New VB.SysContab.Rutinas

        Dim NoComprob As Double
        Dim Total As Double
        Dim Fechas As New VB.SysContab.FechasdeTrabajo
#End Region


        Private DT_Distribucion As DataTable = New DataTable("Distribucion")
        Private _Modifica As Boolean = False
        Private _TipoC As Integer = 1

        Public Property TipoC()
            Get
                Return _TipoC
            End Get
            Set(ByVal Value)
                _TipoC = Value
            End Set
        End Property

        Public Property Modifica()
            Get
                Return _Modifica
            End Get
            Set(ByVal Value)
                _Modifica = Value
            End Set
        End Property

        Private Function VerificaDistribucion() As Boolean
            Dim DebitoCredito As String
            Dim Valor As Double
            For i As Integer = 0 To tCust.Rows.Count - 1
                With tCust.Rows(i)
                    Dim CTemp As String
                    Try
                        CTemp = ObtieneDatos("SELECT CuentaContable FROM RubrosGastos WHERE Activo = 1 AND CuentaContable = '" & .Item("Codigo1") & "' AND Empresa = " & EmpresaActual).Rows(0).Item(0)
                    Catch e As Exception
                        CTemp = ""
                    End Try
                    If CTemp <> Nothing Then
                        Dim DT As DataTable = DT_Distribucion
                        Dim Total As Double = 0
                        If IsDBNull(.Item("Monto")) OrElse IsNothing(.Item("Monto")) OrElse .Item("Monto") = Nothing Then

                        Else
                            If CDbl(.Item("Monto")) > 0 Then DebitoCredito = "D" Else DebitoCredito = "C"
                            Valor = .Item("Monto")
                        End If
                        DT.DefaultView.RowFilter = "Cuenta = '" & .Item("Codigo1") & "' AND NoComp = 0 " & _
                        " AND Per_Id = " & VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.Value) & " AND IdEmpresa = " & EmpresaActual & _
                        " AND Mes = " & Month(dtpFecha.Value) & " AND Tipo = '" & DebitoCredito & "'"
                        For j As Integer = 0 To DT.DefaultView.Count - 1
                            If DT.DefaultView.Item(j).Row.RowState <> DataRowState.Deleted Then Total += DT.DefaultView.Item(j).Row.Item("Valor")
                        Next
                        If CDbl(Format(Total, "###,##0.00")) <> CDbl(Format(Valor, "###,##0.00")) Then
                            MsgBox("La cuenta : " & .Item("Codigo1") & " tiene un valor de " & Format(Valor, "n2") & vbCrLf & _
                            " que no corresponde al valor distribuido de " & Format(Total, "n2"))
                            Return False
                        End If
                    End If
                End With
            Next
            Return True
        End Function

        Private Sub EliminaNoValidos()
            Dim Temp As Boolean
Ciclo:
            For i As Integer = 0 To DT_Distribucion.Rows.Count - 1
                If DT_Distribucion.Rows(i).RowState <> DataRowState.Deleted Then
                    Temp = False
                    For j As Integer = 0 To tCust.Rows.Count - 1
                        If DT_Distribucion.Rows(i).Item("Cuenta") = tCust.Rows(j).Item("Codigo1") And DT_Distribucion.Rows(i).Item("Tipo") = IIf(tCust.Rows(j).Item("Monto") > 0, "D", "C") Then
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

        Private Sub frmFacturaProveedor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'r.FormularioColor(Me)
            DT_Distribucion = CargaDistribucion(0, 0, 0)
            Me.cbProveedor.DataSource = Proveedores.ListAll().Tables("Proveedores")
            Me.cbProveedor.ValueMember = "Codigo"
            Me.cbProveedor.DisplayMember = "Nombre"

            Me.cbCuenta.DataSource = Catalogo.CatalogoListTipo("A", 1).Tables("CATALOGO")
            Me.cbCuenta.ValueMember = "Cuenta"
            Me.cbCuenta.DisplayMember = "Nombre"

            Me.cbFormaPago.DataSource = FormaPago.FormaPagoList().Tables("Forma_Pago")
            Me.cbFormaPago.ValueMember = "Codigo"
            Me.cbFormaPago.DisplayMember = "Nombre"

            cbTipoComp.DataSource = Comprobantes.TiposComprobantesCheques(False).Tables(0)
            cbTipoComp.ValueMember = "TipComp_Id"
            cbTipoComp.DisplayMember = "TipComp_Nombre"

            Me.dtpFecha.MinDate = Fechas.FechaMinima 'VB.SysContab.PeriodosDB.GetDetails(VB.SysContab.PeriodosDB.Activo).Inicio
            Me.dtpFecha.MaxDate = Fechas.FechaMaxima 'VB.SysContab.PeriodosDB.GetDetails(VB.SysContab.PeriodosDB.Activo).Final

            Dim Fecha As Date

            Fecha = CDate(r.Fecha)
            If Me.dtpFecha.MaxDate > Fecha Then
                Me.dtpFecha.Value = Fecha
                Me.dtpFechaPago.Value = Fecha
                Me.dtpFechaRecepcion.Value = Fecha
            Else
            End If

            MakeDataSet()
            Me.dgCatalogo.SetDataBinding(myDataSet, "Articulos")
            AddCustomDataTableStyle()

            LeaveCommit = False
            BuscarCombo = False
            SetTiempos(OrigenComprobantes.FACTURA_PROVEEDOR, funciones.Tiempos.TiempoInicio, Now, funciones.Eventos.Inicia, Me.txtFactura.Text)
            r.ComboAutoComplete(Me.cbProveedor)
            r.ComboAutoComplete(Me.cbCuenta)
            r.ComboAutoComplete(Codigo.ColumnComboBox)
            r.ComboAutoComplete(Descripcion.ColumnComboBox)

        End Sub

        Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

            If VerificaDistribucion() = False And ObligarDistribucion = True Then
                Exit Sub
            End If

            If Guardar() = False Then
                Exit Sub
            End If

            Me.txtDocumento.Text = ""
            Me.txtMonto.Text = "0.00"
            Me.cbProveedor.SelectedValue = 0
            Me.txtConcepto.Text = ""
            Me.txtFactura.Text = ""
        End Sub

        Private Sub Distribuir()
            Dim Valor As Double
            For i As Integer = 0 To tCust.Rows.Count - 1
                With tCust
                    Dim CTemp As String
                    Try
                        CTemp = ObtieneDatos("SELECT CuentaContable FROM RubrosGastos WHERE Activo = 1 AND CuentaContable = '" & .Rows(i)("Codigo1") & "' AND Empresa = " & EmpresaActual).Rows(0).Item(0)
                    Catch e As Exception
                        CTemp = ""
                    End Try
                    If CTemp <> Nothing Then
                        For j As Integer = 0 To DT_Distribucion.Rows.Count - 1
                            Dim Fila As DataRow = DT_Distribucion.Rows(j)
                            If Fila.Item("Cuenta") = .Rows(i)("Codigo1") And Fila.Item("Tipo") = IIf(.Rows(i)("Monto") > 0, "D", "C") Then
                                GuardaDatos("INSERT INTO Distribucion(IdEmpresa,NoComp,Mes,Per_Id,IdRubroGasto,IdCentroCosto,Valor,Tipo,Cuenta) " & _
                                " VALUES(" & EmpresaActual & "," & NoComprob & "," & dtpFecha.Value.Month & "," & _
                                VB.SysContab.PeriodosDB.Activo(dtpFecha.Value.Date) & "," & Fila.Item("IdRubroGasto") & "," & _
                                Fila.Item("IdCentroCosto") & "," & Fila.Item("Valor") & ",'" & Fila.Item("Tipo") & "','" & _
                                Fila.Item("Cuenta") & "')")
                            End If
                        Next
                    End If
                End With
            Next
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
            cMonto.DefaultValue = 0.0

            Dim cConcepto As DataColumn
            cConcepto = New DataColumn("Concepto")
            cConcepto.DefaultValue = ""

            tCust.Columns.Add(cCodigo1)
            tCust.Columns.Add(cCodigo)
            tCust.Columns.Add(cDescripcion)
            tCust.Columns.Add(cMonto)
            tCust.Columns.Add(cConcepto)
            'tCust.Columns.Add(cCurrent2)
            ' Add the tables to the DataSet.
            myDataSet.Tables.Add(tCust)

            ' Populates the tables. For each customer and order, 
            'creates two DataRow variables. 
            Dim newRow1 As DataRow
            '''''''' Create three customers in the Customers Table.

        End Sub

        Private Sub AddCustomDataTableStyle()

            'STEP 1: Create a DataTable style object and set properties if required.
            Dim ts1 As DataGridTableStyle
            ts1 = New DataGridTableStyle
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
            Monto = New DataGridTextBoxColumn
            Monto.MappingName = "Monto"
            Monto.HeaderText = "Monto"

            Monto.Width = 100
            Monto.Alignment = HorizontalAlignment.Right
            Monto.ReadOnly = False
            Monto.Format = "##,###.00"


            AddHandler Monto.TextBox.Leave, New EventHandler(AddressOf TextBoxMontoLeaveHandler)
            '   AddHandler Monto.TextBox.KeyDown, New EventHandler(AddressOf TextBoxMontoLeaveHandler)
            'AddHandler Monto.TextBox.KeyUp, New KeyEventHandler(AddressOf TextBoxMontoLeaveHandler)

            'AddHandler Monto.TextBox.KeyDown, AddressOf Evento_KeyPress
            'AddHandler olumnComboBox.KeyDown, AddressOf Evento_KeyPress
            'AddHandler ArticuloCodigo.ColumnComboBox.KeyDown, AddressOf Evento_KeyPress

            ts1.GridColumnStyles.Add(Monto)
            colCount = (colCount + 1)

            Monto.NullText = "0.00"

            Dim Concepto As DataGridTextBoxColumn
            Concepto = New DataGridTextBoxColumn
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

                        If rowChanging = 0 And tCust.Rows.Count = 1 Then
                            tCust.Rows(rowChanging)("Monto") = CDbl(Me.txtMonto.Text).ToString(Round)
                        End If

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

        Private Sub TextBoxMontoLeaveHandler(ByVal sender As Object, ByVal e As EventArgs)
            Try
                'Monto.TextBox.Text
                'microsoft.VisualBas
                Monto.TextBox.Text = CDbl(Monto.TextBox.Text).ToString(Round)
                tCust.Rows(Me.dgCatalogo.CurrentRowIndex)("mONTO") = Monto.TextBox.Text
                'txtMonto.Text = 0
                'Dim i As Integer

                'For i = 0 To dgCatalogo.VisibleRowCount - 2
                '    txtMonto.Text = CDbl(dgCatalogo.Item(i, 3)) + CDbl(txtMonto.Text)
                'Next


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
        End Sub

        Private Function Guardar() As Boolean

            If Me.txtFactura.Text = vbNullString Or Me.txtFactura.Text = "" Then
                MsgBox("Ingrese el numero de referencia de Factura", MsgBoxStyle.Critical, "STS-Contab")
                Me.txtFactura.Focus()
                Return False
                Exit Function
            End If
            If Me.cbProveedor.SelectedValue = "0" Or Me.cbProveedor.SelectedValue = Nothing Then
                MsgBox("Seleccione un proveedor", MsgBoxStyle.Information)
                Me.cbProveedor.Focus()
                Return False
                Exit Function
            End If

            If Me.cbCuenta.SelectedValue = "0" Or Me.cbCuenta.SelectedValue = Nothing Then
                MsgBox("Seleccione una Cuenta", MsgBoxStyle.Information)
                Me.cbCuenta.Focus()
                Return False
                Exit Function
            End If

            If Me.cbFormaPago.SelectedValue = 0 Then
                MsgBox("Seleccione la Forma de Pago", MsgBoxStyle.Information)
                Me.cbFormaPago.Focus()
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

            If Not Modifica Then
                If InputBox("Conforme con el registro que desea guardar?", "Confirmacion de Registro").ToString <> CStr(ObtieneDatos("SELECT Codigo FROM CodigoFactura WHERE Tipo = " & TipoC).Rows(0).Item(0)) Then
                    MsgBox("Codigo Invalido")
                    Exit Function
                End If
            Else
                If InputBox("Va a modificar una factura, digite el codigo de autorizacion:", "Confirmacion de Modificacion").ToString <> CStr(ObtieneDatos("SELECT Codigo FROM CodigoFactura WHERE Tipo = " & TipoC).Rows(0).Item(0)) Then
                    MsgBox("Codigo Invalido")
                    Exit Function
                Else
                End If
            End If

            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction()

            Try
                Dim DC As String
                NoComprob = Comprobantes.AddComprobante(Me.cbTipoComp.SelectedValue, 1, txtConcepto.Text, VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MonedaBase, PeriodosDB.Activo(Me.dtpFecha.Value), dtpFecha.Value, 0, "", False, Me.cbProveedor.SelectedValue, "", 1, Me.txtFactura.Text, Me.dtpFechaPago.Value, Me.cbFormaPago.SelectedValue, 0)

                Comprobantes.AddFacturaFecha(Me.cbProveedor.SelectedValue, Me.txtFactura.Text, Me.dtpFechaRecepcion.Value)

                DC = "C"

                Comprobantes.AddComprobanteDetalles(NoComprob, Me.cbCuenta.SelectedValue, "", Me.txtMonto.Text, "", Me.cbTipoComp.SelectedValue, DC, 0, 0, Me.dtpFecha.Value, 0)
                'Comprobantes.AddCatalogoTrans(Me.cbProveedor.SelectedValue, 0, Me.txtMonto.Text, "")
                'Catalogo.ActualizarCuentas(Me.cbProveedor.SelectedValue, Me.txtMonto.Text, 1)

                For i = 0 To tCust.Rows.Count - 1
                    Dim Opera As Integer

                    If VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo1")).Tables("Catalogo").Rows(0).Item("Clase") = 1 And CDbl(tCust.Rows(i)("Monto")) >= 0 Then
                        DC = "D"
                        Opera = 1

                    ElseIf VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo1")).Tables("Catalogo").Rows(0).Item("Clase") = 1 And CDbl(tCust.Rows(i)("Monto")) <= 0 Then
                        DC = "C"
                        Opera = 2
                    ElseIf VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo1")).Tables("Catalogo").Rows(0).Item("Clase") = 2 And CDbl(tCust.Rows(i)("Monto")) >= 0 Then
                        DC = "D"
                        Opera = 1
                    ElseIf VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo1")).Tables("Catalogo").Rows(0).Item("Clase") = 2 And CDbl(tCust.Rows(i)("Monto")) < 0 Then
                        DC = "C"
                        Opera = 2
                    End If

                    Comprobantes.AddComprobanteDetalles(NoComprob, tCust.Rows(i)("Codigo1"), tCust.Rows(i)("Concepto").ToString, Math.Abs(CDbl(tCust.Rows(i)("Monto"))), "", Me.cbTipoComp.SelectedValue, DC, 0, 0, Me.dtpFecha.Value, 1)
                    'Comprobantes.AddCatalogoTrans(tCust.Rows(i)("Codigo1"), tCust.Rows(i)("Monto"), 0, tCust.Rows(i)("Descripcion").ToString)
                    'Catalogo.ActualizarCuentas(tCust.Rows(i)("Codigo1"), tCust.Rows(i)("Monto"), Opera)

                Next
                '----------------------
                'Guarda la Distribucion
                '----------------------
                'EliminaNoValidos()
                'GuardaDistribucion(DT_Distribucion, dtpFecha.Value.Date, NoComprob)
                Distribuir()
                DT_Distribucion = CargaDistribucion(0, 0, 0)
                '--------------------------
                'Fin de Guarda Distribucion
                '--------------------------

                VB.SysContab.Rutinas.okTransaccion()
                SetTiempos(OrigenComprobantes.FACTURA_PROVEEDOR, funciones.Tiempos.TiempoFin, Now, funciones.Eventos.Guarda, Me.txtFactura.Text)
            Catch Mensaje As Exception
                VB.SysContab.Rutinas.ErrorTransaccion()
                SetTiempos(OrigenComprobantes.FACTURA_PROVEEDOR, funciones.Tiempos.TiempoFin, Now, funciones.Eventos.Error1, Me.txtFactura.Text)
                MsgBox(Mensaje.Message)
                Return False
                Exit Function
            End Try


            MakeDataSet()
            Me.dgCatalogo.SetDataBinding(myDataSet, "Articulos")
            AddCustomDataTableStyle()

            r.ComboAutoComplete(Codigo.ColumnComboBox)
            r.ComboAutoComplete(Descripcion.ColumnComboBox)

            Return True

            'MsgBox("Se ha generado satisfactoriamente el Comprobante", MsgBoxStyle.Critical)
            'Me.Close()
        End Function

        Private Sub cbProveedor_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbProveedor.SelectedValueChanged
            If Me.etInicio.Text = "1" Then
                Exit Sub
            End If

            If Me.cbProveedor.SelectedValue = 0 Then
                Me.cbCuenta.SelectedValue = "0"
                ProveedoresDetalles.Cuenta = ""
            Else
                ProveedoresDetalles = VB.SysContab.ProveedoresDB.GetDetails(Me.cbProveedor.SelectedValue)
            End If

            ds2 = Comprobantes.ProveedorUltimoComp(Me.cbProveedor.SelectedValue)
            If ds2.Tables("Comprobantes").Rows.Count = 0 Then

                'If ProveedoresDetalles.Cuenta.ToString = "" Then

                'Else
                '    Me.cbCuenta.SelectedValue = ProveedoresDetalles.Cuenta.ToString
                'End If

                MakeDataSet()
                Me.dgCatalogo.SetDataBinding(myDataSet, "Articulos")
                AddCustomDataTableStyle()

                r.ComboAutoComplete(Codigo.ColumnComboBox)
                r.ComboAutoComplete(Descripcion.ColumnComboBox)
                Me.txtMonto.Text = "0.00"
                Me.cbCuenta.SelectedValue = "0"
                Me.cbFormaPago.SelectedValue = 0
                Me.txtConcepto.Text = ""

                If ProveedoresDetalles.Cuenta.ToString = "" Then
                Else
                    Me.cbCuenta.SelectedValue = ProveedoresDetalles.Cuenta.ToString
                    Me.cbCuenta.Refresh()
                End If
            Else
                compDet = Comprobantes.GetComprobanteDetails2(ds2.Tables("Comprobantes").Rows(0).Item("Comp_No"), ds2.Tables("Comprobantes").Rows(0).Item("Per_ID"), ds2.Tables("Comprobantes").Rows(0).Item("Fecha"))
                ds1 = compDet.Detalles

                MakeDataSet1()
                Me.dgCatalogo.SetDataBinding(myDataSet, "Articulos")
                AddCustomDataTableStyle()

                r.ComboAutoComplete(Codigo.ColumnComboBox)
                r.ComboAutoComplete(Descripcion.ColumnComboBox)

                Me.txtMonto.Text = Total.ToString(Round)
                Me.cbFormaPago.SelectedValue = compDet.FormaPago
                Me.txtConcepto.Text = compDet.Concepto

            End If

            Try
                dgCatalogo_CurrentCellChanged(Nothing, Nothing)
            Catch ex As Exception

            End Try

        End Sub

        Private Sub MakeDataSet1()

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
            Total = 0

            For j = 0 To ds1.Tables("ComprobantesDetalles").Rows.Count - 1
                If ds1.Tables("ComprobantesDetalles").Rows(j).Item("Detalle") = 0 Then
                    Total = Total + CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("Monto"))
                    Me.cbCuenta.SelectedValue = ds1.Tables("ComprobantesDetalles").Rows(j).Item("Cuenta")
                    'Me.txtMonto.Text = CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("Monto")).ToString(Round)
                Else
                    newRow1 = tCust.NewRow
                    newRow1("Codigo") = ds1.Tables("ComprobantesDetalles").Rows(j).Item("Cuenta") & " - " & ds1.Tables("ComprobantesDetalles").Rows(j).Item("Nombre")
                    tCust.Rows.Add(newRow1)

                    'tCust.Rows(j)("Codigo1") = ds1.Tables("ComprobantesDetalles").Rows(j).Item("Cuenta")
                    newRow1("Codigo1") = ds1.Tables("ComprobantesDetalles").Rows(j).Item("Cuenta")
                    newRow1("Descripcion") = ds1.Tables("ComprobantesDetalles").Rows(j).Item("Nombre")
                    newRow1("Concepto") = ds1.Tables("ComprobantesDetalles").Rows(j).Item("Concepto")

                    If ds1.Tables("ComprobantesDetalles").Rows(j).Item("Proceso") = "Débito" Then
                        newRow1("Monto") = CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("Monto")).ToString(Round)
                        'DebitoMonto = DebitoMonto + CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("Monto"))
                    ElseIf ds1.Tables("ComprobantesDetalles").Rows(j).Item("Proceso") = "Crédito" Then
                        newRow1("Monto") = "-" & CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("Monto")).ToString(Round)
                        'CreditoMonto = CreditoMonto + CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("Monto"))
                    End If

                    'Me.lblDebito.Text = DebitoMonto.ToString(Round)
                    'Me.lblCredito.Text = CreditoMonto.ToString(Round)

                    'tCust.Rows(j)("Proceso") = ds1.Tables("ComprobantesDetalles").Rows(j).Item("Proceso")

                End If
            Next

        End Sub

        Private Sub cbFormaPago_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbFormaPago.SelectedValueChanged
            Try
                If IsNumeric(Me.cbFormaPago.SelectedValue) Then
                    If Inicio = True Then
                        Exit Sub
                    End If

                    If Me.cbFormaPago.SelectedValue = 0 Then

                    Else
                        'TipoFactura = Me.cbFormaPago.SelectedValue.ToString
                        Me.dtpFechaPago.Value = Me.dtpFecha.Value.AddDays(FormaPago.FormaPagoDias(Me.cbFormaPago.SelectedValue))
                    End If


                End If
            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try

        End Sub

        Private Sub cmdFacturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFacturas.Click
            Dim F As frmListaFacturaProveedores = frmListaFacturaProveedores.Instance
            F.MdiParent = Me.MdiParent
            F.etInicio.Text = "1"
            F.Show()
            F.etInicio.Text = "0"

            'Dim f As frmFacturaComprobantes = f.Instance
            'f.etInicio.Text = "1"
            'f.MdiParent = Me.MdiParent
            'f.Show()
            'f.etInicio.Text = "0"
        End Sub

        Private Sub dgCatalogo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCatalogo.DoubleClick
            'Dim f As New frmNuevaCuentaQuick
            'Nuevo = "SI"
            'f.ShowDialog()
            'Me.dgCatalogo.Item(Me.dgCatalogo.CurrentRowIndex, 0) = f.txtCodigo.Text
            'Me.dgCatalogo.Item(Me.dgCatalogo.CurrentRowIndex, 1) = f.txtCodigo.Text & " - " & f.txtNombre.Text
            'Me.dgCatalogo.Item(Me.dgCatalogo.CurrentRowIndex, 2) = f.txtNombre.Text


            If (IsDBNull(dgCatalogo.Item(dgCatalogo.CurrentRowIndex, 0)) _
        Or IsDBNull(dgCatalogo.Item(dgCatalogo.CurrentRowIndex, 3))) _
        And IsDBNull(dgCatalogo.Item(dgCatalogo.CurrentRowIndex, 4)) Then Exit Sub
            Try
                If dgCatalogo.CurrentRowIndex >= 0 Then
                    Dim forma As New FrmDetalleRequisas
                    With dgCatalogo
                        If IsDBNull(.Item(.CurrentRowIndex, 3)) Or IsNothing(.Item(.CurrentRowIndex, 3)) Then
                        Else
                            forma.Monto = .Item(.CurrentRowIndex, 3)
                            forma.Tipo = IIf(.Item(.CurrentRowIndex, 3) > 0, "D", "C")
                            forma.Periodo = VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.Value)
                            forma.CompNo = 0
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

            End Try
        End Sub

        Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
            Help.ShowHelp(Me, "ayuda/ProvGrabfact.chm")
        End Sub
        Private Sub cbTipoComp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoComp.SelectedIndexChanged
            'Try
            '    If IsNumeric(Me.cbTipoComp.SelectedValue) Then
            '        If Inicio = True Then
            '            Exit Sub
            '        End If

            '        If Me.cbTipoComp.SelectedValue = 0 Then

            '        Else
            '            'TipoFactura = Me.cbFormaPago.SelectedValue.ToString
            '            'Me.dtpFechaPago.Value = Me.dtpFecha.Value.AddDays(FormaPago.FormaPagoDias(Me.cbFormaPago.SelectedValue))
            '        End If
            '    End If
            'Catch ex As Exception
            '    'MsgBox(ex.Message)
            'End Try
        End Sub

        Private Sub txtFactura_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtFactura.Validating
            Try
                'Valida si existe la factura digitada en la tabla Facturas_compras
                If cbProveedor.Text = vbNullString Then
                    txtFactura.Text = vbNullString
                    MsgBox("Seleccione el proveedor", MsgBoxStyle.Information)
                    cbProveedor.Focus()
                    Exit Sub
                End If
                Dim ds As DataTable = ObtieneDatos("SELECT * FROM Facturas_Compras WHERE Empresa_ID=" & EmpresaActual & " AND Proveedor_ID = " & cbProveedor.SelectedValue & " AND Factura_ID='" & txtFactura.Text & "'")
                If ds.Rows.Count > 0 Then
                    MsgBox("Esta factura ya fue registrada", MsgBoxStyle.Critical)
                    txtFactura.Focus()
                    txtFactura.Text = vbNullString
                    Exit Sub
                End If
                'Validar si la factura ya fue digitada directamente en comprobantes
                If VB.SysContab.Facturas_ComprasDB.VerifyExistencia(Me.txtFactura.Text, Me.cbProveedor.SelectedValue) Then
                    MsgBox("Factura ya fue grabada para este proveedor", MsgBoxStyle.Critical, "STS-Nomina")
                    Me.txtFactura.Text = vbNullString
                    Exit Sub
                End If
            Catch ex As Exception

            End Try

        End Sub

        Private Sub frmFacturaProveedor_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
            SetTiempos(OrigenComprobantes.FACTURA_PROVEEDOR, funciones.Tiempos.TiempoFin, Now, funciones.Eventos.Salir, Me.txtFactura.Text)
        End Sub

        Private Sub dgCatalogo_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dgCatalogo.Navigate

        End Sub

        Private Sub dgCatalogo_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCatalogo.CurrentCellChanged, txtMonto.Leave, cmdRecalcular.Click
            lblcredito.Text = "0.00"
            lbldebito.Text = "0.00"
            lbldiferencia.Text = "0.00"
            For i As Integer = 0 To tCust.Rows.Count - 1
                If tCust.Rows(i)("Monto") Is DBNull.Value Or tCust.Rows(i)("Monto").ToString = "" Then
                Else
                    'If tCust.Rows(i)("Monto") > 0 Then
                    '             lblcredito.Text = Format(CDbl(lblcredito.Text) + tCust.Rows(i)("Monto"), "n2")
                    '         Else
                    'lbldebito.Text = Format(CDbl(lbldebito.Text) + tCust.Rows(i)("Monto"), "n2")
                    lbldebito.Text = Format(CDbl(lbldebito.Text) + tCust.Rows(i)("Monto"), "n2")
                    'End If
                    'lbldiferencia.Text = Format(CDbl(lbldiferencia.Text) + tCust.Rows(i)("Monto"), "n2")
                End If
            Next
            Try
                lblcredito.Text = Format(CDbl(txtMonto.Text), "n2")
                lbldiferencia.Text = Format(CDbl(lblcredito.Text) - CDbl(lbldebito.Text), "n2")
            Catch ex As Exception

            End Try

        End Sub

        Private Sub txtFactura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFactura.TextChanged

        End Sub
    End Class

End Namespace

