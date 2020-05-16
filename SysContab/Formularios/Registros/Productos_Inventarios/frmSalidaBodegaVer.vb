Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace DataGridTextBoxCombo
    Public Class frmSalidaBodegaVer
        Inherits DevExpress.XtraEditors.XtraForm

        Private Shared ChildInstance As frmSalidaBodegaVer = Nothing

        Public Shared Function Instance() As frmSalidaBodegaVer
            If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
                ChildInstance = New frmSalidaBodegaVer()
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
        Friend WithEvents txtCliente As System.Windows.Forms.TextBox
        Friend WithEvents cbCliente As System.Windows.Forms.ComboBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents etSaldoT As System.Windows.Forms.Label
        Friend WithEvents etSaldo As System.Windows.Forms.Label
        Friend WithEvents etSubTotal As System.Windows.Forms.Label
        Friend WithEvents etSubTotalT As System.Windows.Forms.Label
        Friend WithEvents etIva As System.Windows.Forms.Label
        Friend WithEvents etIvaT As System.Windows.Forms.Label
        Friend WithEvents gbBotones As System.Windows.Forms.GroupBox
        Friend WithEvents cmdConsultaClientes As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdVerPagos As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents etTotal As System.Windows.Forms.Label
        Friend WithEvents etTotalT As System.Windows.Forms.Label
        Friend WithEvents dgFacturacionCliente As System.Windows.Forms.DataGrid
        Friend WithEvents txtFactura As System.Windows.Forms.TextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
        Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents txtSalida As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.txtCliente = New System.Windows.Forms.TextBox
            Me.cbCliente = New System.Windows.Forms.ComboBox
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label24 = New System.Windows.Forms.Label
            Me.GroupBox3 = New System.Windows.Forms.GroupBox
            Me.etSaldoT = New System.Windows.Forms.Label
            Me.etSaldo = New System.Windows.Forms.Label
            Me.etSubTotal = New System.Windows.Forms.Label
            Me.etSubTotalT = New System.Windows.Forms.Label
            Me.etIva = New System.Windows.Forms.Label
            Me.etIvaT = New System.Windows.Forms.Label
            Me.gbBotones = New System.Windows.Forms.GroupBox
            Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
            Me.cmdConsultaClientes = New DevExpress.XtraEditors.SimpleButton
            Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
            Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
            Me.cmdVerPagos = New DevExpress.XtraEditors.SimpleButton
            Me.etTotal = New System.Windows.Forms.Label
            Me.etTotalT = New System.Windows.Forms.Label
            Me.dgFacturacionCliente = New System.Windows.Forms.DataGrid
            Me.txtFactura = New System.Windows.Forms.TextBox
            Me.Label7 = New System.Windows.Forms.Label
            Me.dtpFecha = New System.Windows.Forms.DateTimePicker
            Me.txtSalida = New System.Windows.Forms.TextBox
            Me.Label8 = New System.Windows.Forms.Label
            Me.GroupBox3.SuspendLayout()
            Me.gbBotones.SuspendLayout()
            CType(Me.dgFacturacionCliente, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'txtCliente
            '
            Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCliente.Location = New System.Drawing.Point(72, 8)
            Me.txtCliente.MaxLength = 50
            Me.txtCliente.Name = "txtCliente"
            Me.txtCliente.ReadOnly = True
            Me.txtCliente.Size = New System.Drawing.Size(320, 20)
            Me.txtCliente.TabIndex = 155
            '
            'cbCliente
            '
            Me.cbCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbCliente.Location = New System.Drawing.Point(72, 8)
            Me.cbCliente.Name = "cbCliente"
            Me.cbCliente.Size = New System.Drawing.Size(320, 21)
            Me.cbCliente.TabIndex = 146
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(840, 8)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(64, 25)
            Me.Label1.TabIndex = 148
            Me.Label1.Text = "Fecha:"
            '
            'Label24
            '
            Me.Label24.BackColor = System.Drawing.Color.Transparent
            Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label24.Location = New System.Drawing.Point(8, 8)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(64, 25)
            Me.Label24.TabIndex = 147
            Me.Label24.Text = "Cliente:"
            '
            'GroupBox3
            '
            Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox3.Controls.Add(Me.etSaldoT)
            Me.GroupBox3.Controls.Add(Me.etSaldo)
            Me.GroupBox3.Controls.Add(Me.etSubTotal)
            Me.GroupBox3.Controls.Add(Me.etSubTotalT)
            Me.GroupBox3.Controls.Add(Me.etIva)
            Me.GroupBox3.Controls.Add(Me.etIvaT)
            Me.GroupBox3.Controls.Add(Me.gbBotones)
            Me.GroupBox3.Controls.Add(Me.etTotal)
            Me.GroupBox3.Controls.Add(Me.etTotalT)
            Me.GroupBox3.Controls.Add(Me.dgFacturacionCliente)
            Me.GroupBox3.Location = New System.Drawing.Point(8, 33)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(1008, 487)
            Me.GroupBox3.TabIndex = 149
            Me.GroupBox3.TabStop = False
            '
            'etSaldoT
            '
            Me.etSaldoT.BackColor = System.Drawing.Color.Transparent
            Me.etSaldoT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etSaldoT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etSaldoT.Location = New System.Drawing.Point(16, 448)
            Me.etSaldoT.Name = "etSaldoT"
            Me.etSaldoT.Size = New System.Drawing.Size(56, 26)
            Me.etSaldoT.TabIndex = 139
            Me.etSaldoT.Text = "Saldo:"
            Me.etSaldoT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etSaldo
            '
            Me.etSaldo.BackColor = System.Drawing.Color.Transparent
            Me.etSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etSaldo.ForeColor = System.Drawing.Color.Black
            Me.etSaldo.Location = New System.Drawing.Point(80, 448)
            Me.etSaldo.Name = "etSaldo"
            Me.etSaldo.Size = New System.Drawing.Size(96, 26)
            Me.etSaldo.TabIndex = 138
            Me.etSaldo.Text = "0.00"
            Me.etSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etSubTotal
            '
            Me.etSubTotal.BackColor = System.Drawing.Color.Transparent
            Me.etSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etSubTotal.ForeColor = System.Drawing.Color.Maroon
            Me.etSubTotal.Location = New System.Drawing.Point(280, 448)
            Me.etSubTotal.Name = "etSubTotal"
            Me.etSubTotal.Size = New System.Drawing.Size(112, 26)
            Me.etSubTotal.TabIndex = 134
            Me.etSubTotal.Text = "0.00"
            Me.etSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etSubTotalT
            '
            Me.etSubTotalT.BackColor = System.Drawing.Color.Transparent
            Me.etSubTotalT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etSubTotalT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etSubTotalT.Location = New System.Drawing.Point(192, 448)
            Me.etSubTotalT.Name = "etSubTotalT"
            Me.etSubTotalT.Size = New System.Drawing.Size(80, 26)
            Me.etSubTotalT.TabIndex = 133
            Me.etSubTotalT.Text = "Sub Total:"
            Me.etSubTotalT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etIva
            '
            Me.etIva.BackColor = System.Drawing.Color.Transparent
            Me.etIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etIva.ForeColor = System.Drawing.Color.Maroon
            Me.etIva.Location = New System.Drawing.Point(504, 448)
            Me.etIva.Name = "etIva"
            Me.etIva.Size = New System.Drawing.Size(112, 26)
            Me.etIva.TabIndex = 132
            Me.etIva.Text = "0.00"
            Me.etIva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etIvaT
            '
            Me.etIvaT.BackColor = System.Drawing.Color.Transparent
            Me.etIvaT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etIvaT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etIvaT.Location = New System.Drawing.Point(400, 448)
            Me.etIvaT.Name = "etIvaT"
            Me.etIvaT.Size = New System.Drawing.Size(96, 26)
            Me.etIvaT.TabIndex = 131
            Me.etIvaT.Text = "IVA:"
            Me.etIvaT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'gbBotones
            '
            Me.gbBotones.BackColor = System.Drawing.Color.Transparent
            Me.gbBotones.Controls.Add(Me.cmdAyuda)
            Me.gbBotones.Controls.Add(Me.cmdConsultaClientes)
            Me.gbBotones.Controls.Add(Me.cmdImprimir)
            Me.gbBotones.Controls.Add(Me.cmdCancelar)
            Me.gbBotones.Controls.Add(Me.cmdVerPagos)
            Me.gbBotones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBotones.ForeColor = System.Drawing.Color.Maroon
            Me.gbBotones.Location = New System.Drawing.Point(912, 17)
            Me.gbBotones.Name = "gbBotones"
            Me.gbBotones.Size = New System.Drawing.Size(88, 417)
            Me.gbBotones.TabIndex = 130
            Me.gbBotones.TabStop = False
            '
            'cmdAyuda
            '
            Me.cmdAyuda.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdAyuda.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdAyuda.Appearance.Options.UseFont = True
            Me.cmdAyuda.Appearance.Options.UseForeColor = True
            Me.cmdAyuda.Location = New System.Drawing.Point(8, 78)
            Me.cmdAyuda.Name = "cmdAyuda"
            Me.cmdAyuda.Size = New System.Drawing.Size(72, 34)
            Me.cmdAyuda.TabIndex = 127
            Me.cmdAyuda.Text = "Ayuda"
            '
            'cmdConsultaClientes
            '
            Me.cmdConsultaClientes.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdConsultaClientes.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdConsultaClientes.Appearance.Options.UseFont = True
            Me.cmdConsultaClientes.Appearance.Options.UseForeColor = True
            Me.cmdConsultaClientes.Location = New System.Drawing.Point(8, 276)
            Me.cmdConsultaClientes.Name = "cmdConsultaClientes"
            Me.cmdConsultaClientes.Size = New System.Drawing.Size(72, 34)
            Me.cmdConsultaClientes.TabIndex = 33
            Me.cmdConsultaClientes.Text = "C&lientes"
            Me.cmdConsultaClientes.Visible = False
            '
            'cmdImprimir
            '
            Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdImprimir.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdImprimir.Appearance.Options.UseFont = True
            Me.cmdImprimir.Appearance.Options.UseForeColor = True
            Me.cmdImprimir.Location = New System.Drawing.Point(8, 17)
            Me.cmdImprimir.Name = "cmdImprimir"
            Me.cmdImprimir.Size = New System.Drawing.Size(72, 35)
            Me.cmdImprimir.TabIndex = 30
            Me.cmdImprimir.Text = "&Imprimir"
            '
            'cmdCancelar
            '
            Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdCancelar.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdCancelar.Appearance.Options.UseFont = True
            Me.cmdCancelar.Appearance.Options.UseForeColor = True
            Me.cmdCancelar.Location = New System.Drawing.Point(8, 138)
            Me.cmdCancelar.Name = "cmdCancelar"
            Me.cmdCancelar.Size = New System.Drawing.Size(72, 34)
            Me.cmdCancelar.TabIndex = 29
            Me.cmdCancelar.Text = "&Salir"
            '
            'cmdVerPagos
            '
            Me.cmdVerPagos.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdVerPagos.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdVerPagos.Appearance.Options.UseFont = True
            Me.cmdVerPagos.Appearance.Options.UseForeColor = True
            Me.cmdVerPagos.Location = New System.Drawing.Point(8, 319)
            Me.cmdVerPagos.Name = "cmdVerPagos"
            Me.cmdVerPagos.Size = New System.Drawing.Size(72, 34)
            Me.cmdVerPagos.TabIndex = 126
            Me.cmdVerPagos.Text = "&Ver Pagos"
            Me.cmdVerPagos.Visible = False
            '
            'etTotal
            '
            Me.etTotal.BackColor = System.Drawing.Color.Transparent
            Me.etTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTotal.ForeColor = System.Drawing.Color.Maroon
            Me.etTotal.Location = New System.Drawing.Point(688, 439)
            Me.etTotal.Name = "etTotal"
            Me.etTotal.Size = New System.Drawing.Size(168, 35)
            Me.etTotal.TabIndex = 110
            Me.etTotal.Text = "0.00"
            Me.etTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etTotalT
            '
            Me.etTotalT.BackColor = System.Drawing.Color.Transparent
            Me.etTotalT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTotalT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etTotalT.Location = New System.Drawing.Point(624, 448)
            Me.etTotalT.Name = "etTotalT"
            Me.etTotalT.Size = New System.Drawing.Size(56, 26)
            Me.etTotalT.TabIndex = 109
            Me.etTotalT.Text = "Total:"
            Me.etTotalT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
            Me.dgFacturacionCliente.Location = New System.Drawing.Point(8, 17)
            Me.dgFacturacionCliente.Name = "dgFacturacionCliente"
            Me.dgFacturacionCliente.ParentRowsBackColor = System.Drawing.Color.LightGray
            Me.dgFacturacionCliente.ParentRowsForeColor = System.Drawing.Color.Black
            Me.dgFacturacionCliente.SelectionBackColor = System.Drawing.Color.Firebrick
            Me.dgFacturacionCliente.SelectionForeColor = System.Drawing.Color.White
            Me.dgFacturacionCliente.Size = New System.Drawing.Size(896, 417)
            Me.dgFacturacionCliente.TabIndex = 27
            '
            'txtFactura
            '
            Me.txtFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFactura.Location = New System.Drawing.Point(704, 8)
            Me.txtFactura.MaxLength = 50
            Me.txtFactura.Name = "txtFactura"
            Me.txtFactura.ReadOnly = True
            Me.txtFactura.Size = New System.Drawing.Size(128, 20)
            Me.txtFactura.TabIndex = 151
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.Transparent
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label7.Location = New System.Drawing.Point(624, 8)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(72, 25)
            Me.Label7.TabIndex = 150
            Me.Label7.Text = "No. Factura"
            '
            'dtpFecha
            '
            Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFecha.Location = New System.Drawing.Point(904, 8)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
            Me.dtpFecha.TabIndex = 153
            '
            'txtSalida
            '
            Me.txtSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSalida.Location = New System.Drawing.Point(480, 9)
            Me.txtSalida.MaxLength = 50
            Me.txtSalida.Name = "txtSalida"
            Me.txtSalida.ReadOnly = True
            Me.txtSalida.Size = New System.Drawing.Size(128, 20)
            Me.txtSalida.TabIndex = 157
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.Transparent
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label8.Location = New System.Drawing.Point(400, 9)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(72, 25)
            Me.Label8.TabIndex = 156
            Me.Label8.Text = "No. Salida"
            '
            'frmSalidaBodegaVer
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(1016, 526)
            Me.Controls.Add(Me.txtSalida)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.txtCliente)
            Me.Controls.Add(Me.cbCliente)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label24)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.txtFactura)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.dtpFecha)
            Me.Name = "frmSalidaBodegaVer"
            Me.GroupBox3.ResumeLayout(False)
            Me.gbBotones.ResumeLayout(False)
            CType(Me.dgFacturacionCliente, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region
        Dim Clientes As New VB.SysContab.ClientesDB()
        Dim FormaPago As New VB.SysContab.Forma_PagoDB()
        Dim SalidaBodega As New VB.SysContab.SalidaBodegaDB()
        Dim r As New VB.SysContab.Rutinas()

        Dim ds As DataSet

        Dim WithEvents tCust As DataTable
        Private WithEvents myDataSet As DataSet

        Dim Cantidad As DataGridTextBoxColumn
        Dim ValorActualCantidad As Double

        Dim i As Integer

        Dim SubTotalFacturaClienteV As Double
        Dim SubTotalFacturaNoDescuentosV As Double
        Dim TotalFacturaClienteV As Double
        Dim TotalDescuentoV As Double

        Private myCheckBoxCol As Integer = 8 'my checkbox column 

        Dim Config As New VB.SysContab.ConfiguracionDB()
        Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails()

        Private Sub frmFacturacionClienteVer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ''r.CambiarEstilo(Me)
            r.FormularioColor(Me)

            cbCliente.DataSource = Clientes.ClientesList().Tables("Clientes")
            cbCliente.ValueMember = "Codigo"
            cbCliente.DisplayMember = "Nombre"

            ConfigDetalles = Config.GetConfigDetails

            ds = SalidaBodega.SalidaBodegaDetalle(Me.txtSalida.Text)

            dgFacturacionCliente.ReadOnly = True

            cbCliente.Enabled = False

            If ds.Tables("Facturas_Ventas").Rows(0).Item("Cliente") = "9999" Then
                txtCliente.Text = ds.Tables("Facturas_Ventas").Rows(0).Item("Nombre_Cliente").ToString
                txtCliente.Visible = True
            Else
                txtCliente.Visible = False
                cbCliente.SelectedValue = ds.Tables("Facturas_Ventas").Rows(0).Item("Cliente")
            End If

            dtpFecha.Value = ds.Tables("Facturas_Ventas").Rows(0).Item("Fecha")
            dtpFecha.Enabled = False

            txtFactura.Text = ds.Tables("Facturas_Ventas").Rows(0).Item("Factura")
            txtFactura.ReadOnly = True

            MakeDataSet()
            dgFacturacionCliente.SetDataBinding(myDataSet, "Articulos")
            AddCustomDataTableStyle()

            '
            SubTotalFacturaClienteV = 0
            SubTotalFacturaNoDescuentosV = 0
            TotalFacturaClienteV = 0
            TotalDescuentoV = 0

            For i = 0 To tCust.Rows.Count - 1

                If tCust.Rows(i)("SubTotal") Is DBNull.Value Or tCust.Rows(i)("SubTotal").ToString = "" Or tCust.Rows(i)("SubTotal").ToString = "0.00" Then

                ElseIf IsNumeric(tCust.Rows(i)("SubTotal")) And tCust.Rows(i)("SubTotal").ToString <> "" Then
                    Try
                        SubTotalFacturaClienteV = SubTotalFacturaClienteV + tCust.Rows(i)("SubTotal")
                        SubTotalFacturaNoDescuentosV = SubTotalFacturaNoDescuentosV + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio"))
                        TotalDescuentoV = TotalDescuentoV + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio") * tCust.Rows(i)("Descuento") / 100)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            Next

            etSaldo.Visible = False
            etSaldoT.Visible = False

            etSubTotal.Text = SubTotalFacturaClienteV.ToString(Round)
            etIva.Text = (SubTotalFacturaClienteV * (ConfigDetalles.IVA / 100.0)).ToString(Round)
            etTotal.Text = (SubTotalFacturaClienteV + CDbl(etIva.Text)).ToString(Round)

            Me.Text = "Salida de Bodega"

        End Sub

        Private Sub MakeDataSet()

            myDataSet = New DataSet("myDataSet")

            tCust = New DataTable("Articulos")

            Dim cArticuloCodigo As DataColumn
            cArticuloCodigo = New DataColumn("ArticuloCodigo")

            Dim cArticulo As DataColumn
            cArticulo = New DataColumn("Articulo")

            Dim cCantidad As DataColumn
            cCantidad = New DataColumn("Cantidad")

            Dim cPrecio As DataColumn
            cPrecio = New DataColumn("Precio")

            Dim cDescuento As DataColumn
            cDescuento = New DataColumn("Descuento")

            Dim cSubTotal As DataColumn
            cSubTotal = New DataColumn("SubTotal")

            Dim cCodigoTemporal As DataColumn
            cCodigoTemporal = New DataColumn("CodigoTemporal")

            Dim cItemTipo As DataColumn
            cItemTipo = New DataColumn("Tipo")

            tCust.Columns.Add(cArticuloCodigo)
            tCust.Columns.Add(cArticulo)
            tCust.Columns.Add(cCantidad)
            tCust.Columns.Add(cPrecio)
            tCust.Columns.Add(cDescuento)
            tCust.Columns.Add(cSubTotal)
            tCust.Columns.Add(cCodigoTemporal)
            tCust.Columns.Add(cItemTipo)

            tCust.DefaultView.AllowDelete = False
            tCust.DefaultView.AllowNew = False

            myDataSet.Tables.Add(tCust)

            myDataSet.Tables("Articulos").DefaultView.AllowDelete = False
            myDataSet.Tables("Articulos").DefaultView.AllowNew = False

            Dim newRow1 As DataRow

            Dim j As Integer

            For j = 0 To ds.Tables("Facturas_Ventas").Rows.Count - 1
                newRow1 = tCust.NewRow
                newRow1("ArticuloCodigo") = ds.Tables("Facturas_Ventas").Rows(j).Item("Item")
                tCust.Rows.Add(newRow1)

                tCust.Rows(j)("CodigoTemporal") = ds.Tables("Facturas_Ventas").Rows(j).Item("Item")
                tCust.Rows(j)("Articulo") = ds.Tables("Facturas_Ventas").Rows(j).Item("Descripcion")
                tCust.Rows(j)("Cantidad") = ds.Tables("Facturas_Ventas").Rows(j).Item("Cantidad")
                tCust.Rows(j)("Precio") = CDbl(ds.Tables("Facturas_Ventas").Rows(j).Item("Precio")).ToString(Round)
                tCust.Rows(j)("Descuento") = CDbl(ds.Tables("Facturas_Ventas").Rows(j).Item("Descuento")).ToString(Round)
                tCust.Rows(j)("SubTotal") = (CDbl(CDbl(tCust.Rows(j)("Cantidad")) * CDbl(tCust.Rows(j)("Precio"))) - CDbl(CDbl(CDbl(tCust.Rows(j)("Cantidad")) * CDbl(tCust.Rows(j)("Precio")) * (CDbl(tCust.Rows(j)("Descuento")))) / 100.0)).ToString(Round)
                tCust.Rows(j)("Tipo") = ds.Tables("Facturas_Ventas").Rows(j).Item("Tipo_Item")
                'tCust.Rows(j)("Agregar") = False

            Next

        End Sub

        Private Sub AddCustomDataTableStyle()
            Dim ts1 As DataGridTableStyle
            ts1 = New DataGridTableStyle()

            ts1.MappingName = "Articulos"
            ts1.AlternatingBackColor = Color.LightBlue
            Dim colCount As Integer
            colCount = 0

            Dim ArticuloCodigo As DataGridTextBoxColumn
            ArticuloCodigo = New DataGridTextBoxColumn()
            ArticuloCodigo.MappingName = "ArticuloCodigo"
            ArticuloCodigo.HeaderText = "Código"
            ArticuloCodigo.Width = 100
            ArticuloCodigo.Alignment = HorizontalAlignment.Left
            ArticuloCodigo.ReadOnly = True
            ArticuloCodigo.Format = "##,###0.00"
            ts1.GridColumnStyles.Add(ArticuloCodigo)
            colCount = (colCount + 1)

            ArticuloCodigo.NullText = ""


            Dim Articulo As DataGridTextBoxColumn
            Articulo = New DataGridTextBoxColumn()
            Articulo.MappingName = "Articulo"
            Articulo.HeaderText = "Descripción"
            Articulo.Width = 300
            Articulo.Alignment = HorizontalAlignment.Left
            Articulo.ReadOnly = True
            Articulo.Format = "##,###0.00"
            ts1.GridColumnStyles.Add(Articulo)
            colCount = (colCount + 1)

            Articulo.NullText = ""

            'Dim Cantidad As DataGridTextBoxColumn
            Cantidad = New DataGridTextBoxColumn()
            Cantidad.MappingName = "Cantidad"
            Cantidad.HeaderText = "Cantidad"
            Cantidad.Width = 100
            Cantidad.Alignment = HorizontalAlignment.Right
            Cantidad.ReadOnly = True

            ts1.GridColumnStyles.Add(Cantidad)
            colCount = (colCount + 1)

            Cantidad.NullText = ""

            Dim Precio As DataGridTextBoxColumn
            Precio = New DataGridTextBoxColumn()
            Precio.MappingName = "Precio"
            Precio.HeaderText = "Precio"
            Precio.Width = 100
            Precio.Alignment = HorizontalAlignment.Right
            Precio.ReadOnly = True
            Precio.Format = "##,###0.00"
            ts1.GridColumnStyles.Add(Precio)
            colCount = (colCount + 1)

            Precio.NullText = (0).ToString(Round)

            Dim Descuento As DataGridTextBoxColumn
            Descuento = New DataGridTextBoxColumn()
            Descuento.MappingName = "Descuento"
            Descuento.HeaderText = "Descuento %"
            Descuento.Width = 100
            Descuento.Alignment = HorizontalAlignment.Right
            Descuento.ReadOnly = True
            Descuento.Format = "##,###0.00"

            ts1.GridColumnStyles.Add(Descuento)
            colCount = (colCount + 1)

            Descuento.NullText = (0).ToString(Round)

            Dim SubTotal As DataGridTextBoxColumn
            SubTotal = New DataGridTextBoxColumn()
            SubTotal.MappingName = "SubTotal"
            SubTotal.HeaderText = "Sub Total"
            SubTotal.Width = 100
            SubTotal.Alignment = HorizontalAlignment.Right
            SubTotal.ReadOnly = True
            SubTotal.Format = "##,###0.00"
            ts1.GridColumnStyles.Add(SubTotal)
            colCount = (colCount + 1)

            SubTotal.NullText = (0).ToString(Round)

            Dim CodigoTemporal As DataGridTextBoxColumn
            CodigoTemporal = New DataGridTextBoxColumn()
            CodigoTemporal.MappingName = "CodigoTemporal"
            CodigoTemporal.HeaderText = "CodigoTemporal"
            CodigoTemporal.Width = 0
            CodigoTemporal.Alignment = HorizontalAlignment.Left
            CodigoTemporal.ReadOnly = True
            ts1.GridColumnStyles.Add(CodigoTemporal)
            colCount = (colCount + 1)

            CodigoTemporal.NullText = ""

            Dim ItemTipo As DataGridTextBoxColumn
            ItemTipo = New DataGridTextBoxColumn()
            ItemTipo.MappingName = "Tipo"
            ItemTipo.HeaderText = "Tipo"
            ItemTipo.Width = 0
            ItemTipo.ReadOnly = True

            ts1.GridColumnStyles.Add(ItemTipo)
            colCount = (colCount + 1)

            ItemTipo.NullText = ""

            ts1.AllowSorting = False
            ts1.HeaderFont = dgFacturacionCliente.HeaderFont
            ts1.HeaderBackColor = Color.LightSteelBlue
            ts1.GridLineColor = Color.FromArgb(70, 130, 180)

            ts1.PreferredRowHeight = 25

            'TS1.DefaultTableStyl
            myDataSet.Tables("Articulos").DefaultView.AllowDelete = False
            'dsTasaCambio.Tables("TASA_CAMBIO").DefaultView.AllowEdit = True
            'ts1.ReadOnly = True
            tCust.DefaultView.AllowDelete = False

            dgFacturacionCliente.CaptionVisible = False

            dgFacturacionCliente.TableStyles.Clear()
            dgFacturacionCliente.TableStyles.Add(ts1)

        End Sub

        Private Sub cmdCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
            Me.Close()
        End Sub

    End Class

End Namespace
