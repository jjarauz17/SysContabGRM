Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace DataGridTextBoxCombo
    Public Class frmDevolucionProveedorVer
        Inherits DevExpress.XtraEditors.XtraForm

        Private Shared ChildInstance As frmDevolucionProveedorVer = Nothing

        Public Shared Function Instance() As frmDevolucionProveedorVer
            If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
                ChildInstance = New frmDevolucionProveedorVer()
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
        Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cbTodos As System.Windows.Forms.CheckBox
        Friend WithEvents txtDevolucion As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents cbProveedor As System.Windows.Forms.ComboBox
        Friend WithEvents txtCliente As System.Windows.Forms.TextBox
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.cbProveedor = New System.Windows.Forms.ComboBox
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label24 = New System.Windows.Forms.Label
            Me.GroupBox3 = New System.Windows.Forms.GroupBox
            Me.cbTodos = New System.Windows.Forms.CheckBox
            Me.etSaldoT = New System.Windows.Forms.Label
            Me.etSaldo = New System.Windows.Forms.Label
            Me.etSubTotal = New System.Windows.Forms.Label
            Me.etSubTotalT = New System.Windows.Forms.Label
            Me.etIva = New System.Windows.Forms.Label
            Me.etIvaT = New System.Windows.Forms.Label
            Me.gbBotones = New System.Windows.Forms.GroupBox
            Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
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
            Me.txtDevolucion = New System.Windows.Forms.TextBox
            Me.Label8 = New System.Windows.Forms.Label
            Me.txtCliente = New System.Windows.Forms.TextBox
            Me.GroupBox3.SuspendLayout()
            Me.gbBotones.SuspendLayout()
            CType(Me.dgFacturacionCliente, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'cbProveedor
            '
            Me.cbProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbProveedor.Location = New System.Drawing.Point(96, 8)
            Me.cbProveedor.Name = "cbProveedor"
            Me.cbProveedor.Size = New System.Drawing.Size(304, 21)
            Me.cbProveedor.TabIndex = 146
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
            Me.Label24.Size = New System.Drawing.Size(88, 25)
            Me.Label24.TabIndex = 147
            Me.Label24.Text = "Proveedor:"
            '
            'GroupBox3
            '
            Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox3.Controls.Add(Me.cbTodos)
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
            Me.GroupBox3.Size = New System.Drawing.Size(1008, 481)
            Me.GroupBox3.TabIndex = 149
            Me.GroupBox3.TabStop = False
            '
            'cbTodos
            '
            Me.cbTodos.BackColor = System.Drawing.Color.Transparent
            Me.cbTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbTodos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cbTodos.Location = New System.Drawing.Point(768, 86)
            Me.cbTodos.Name = "cbTodos"
            Me.cbTodos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.cbTodos.Size = New System.Drawing.Size(88, 26)
            Me.cbTodos.TabIndex = 157
            Me.cbTodos.Text = "Todos"
            Me.cbTodos.TextAlign = System.Drawing.ContentAlignment.TopLeft
            Me.cbTodos.UseVisualStyleBackColor = False
            Me.cbTodos.Visible = False
            '
            'etSaldoT
            '
            Me.etSaldoT.BackColor = System.Drawing.Color.Transparent
            Me.etSaldoT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etSaldoT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etSaldoT.Location = New System.Drawing.Point(16, 445)
            Me.etSaldoT.Name = "etSaldoT"
            Me.etSaldoT.Size = New System.Drawing.Size(56, 26)
            Me.etSaldoT.TabIndex = 139
            Me.etSaldoT.Text = "Saldo:"
            Me.etSaldoT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.etSaldoT.Visible = False
            '
            'etSaldo
            '
            Me.etSaldo.BackColor = System.Drawing.Color.Transparent
            Me.etSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etSaldo.ForeColor = System.Drawing.Color.Black
            Me.etSaldo.Location = New System.Drawing.Point(80, 445)
            Me.etSaldo.Name = "etSaldo"
            Me.etSaldo.Size = New System.Drawing.Size(96, 26)
            Me.etSaldo.TabIndex = 138
            Me.etSaldo.Text = "0.00"
            Me.etSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.etSaldo.Visible = False
            '
            'etSubTotal
            '
            Me.etSubTotal.BackColor = System.Drawing.Color.Transparent
            Me.etSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etSubTotal.ForeColor = System.Drawing.Color.Maroon
            Me.etSubTotal.Location = New System.Drawing.Point(280, 445)
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
            Me.etSubTotalT.Location = New System.Drawing.Point(192, 445)
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
            Me.etIva.Location = New System.Drawing.Point(504, 445)
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
            Me.etIvaT.Location = New System.Drawing.Point(400, 445)
            Me.etIvaT.Name = "etIvaT"
            Me.etIvaT.Size = New System.Drawing.Size(96, 26)
            Me.etIvaT.TabIndex = 131
            Me.etIvaT.Text = "IVA:"
            Me.etIvaT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'gbBotones
            '
            Me.gbBotones.BackColor = System.Drawing.Color.Transparent
            Me.gbBotones.Controls.Add(Me.cmdAceptar)
            Me.gbBotones.Controls.Add(Me.cmdAyuda)
            Me.gbBotones.Controls.Add(Me.cmdConsultaClientes)
            Me.gbBotones.Controls.Add(Me.cmdImprimir)
            Me.gbBotones.Controls.Add(Me.cmdCancelar)
            Me.gbBotones.Controls.Add(Me.cmdVerPagos)
            Me.gbBotones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBotones.ForeColor = System.Drawing.Color.Maroon
            Me.gbBotones.Location = New System.Drawing.Point(912, 9)
            Me.gbBotones.Name = "gbBotones"
            Me.gbBotones.Size = New System.Drawing.Size(88, 424)
            Me.gbBotones.TabIndex = 130
            Me.gbBotones.TabStop = False
            '
            'cmdAceptar
            '
            Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdAceptar.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdAceptar.Appearance.Options.UseFont = True
            Me.cmdAceptar.Appearance.Options.UseForeColor = True
            Me.cmdAceptar.Location = New System.Drawing.Point(8, 241)
            Me.cmdAceptar.Name = "cmdAceptar"
            Me.cmdAceptar.Size = New System.Drawing.Size(72, 35)
            Me.cmdAceptar.TabIndex = 128
            Me.cmdAceptar.Text = "&Guardar"
            Me.cmdAceptar.Visible = False
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
            Me.cmdConsultaClientes.Location = New System.Drawing.Point(8, 293)
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
            Me.cmdVerPagos.Location = New System.Drawing.Point(8, 336)
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
            Me.etTotal.Location = New System.Drawing.Point(688, 436)
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
            Me.etTotalT.Location = New System.Drawing.Point(624, 445)
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
            Me.dgFacturacionCliente.Location = New System.Drawing.Point(8, 9)
            Me.dgFacturacionCliente.Name = "dgFacturacionCliente"
            Me.dgFacturacionCliente.ParentRowsBackColor = System.Drawing.Color.LightGray
            Me.dgFacturacionCliente.ParentRowsForeColor = System.Drawing.Color.Black
            Me.dgFacturacionCliente.SelectionBackColor = System.Drawing.Color.Firebrick
            Me.dgFacturacionCliente.SelectionForeColor = System.Drawing.Color.White
            Me.dgFacturacionCliente.Size = New System.Drawing.Size(896, 424)
            Me.dgFacturacionCliente.TabIndex = 27
            '
            'txtFactura
            '
            Me.txtFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFactura.Location = New System.Drawing.Point(712, 8)
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
            Me.Label7.Location = New System.Drawing.Point(640, 8)
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
            'txtDevolucion
            '
            Me.txtDevolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDevolucion.Location = New System.Drawing.Point(504, 9)
            Me.txtDevolucion.MaxLength = 50
            Me.txtDevolucion.Name = "txtDevolucion"
            Me.txtDevolucion.ReadOnly = True
            Me.txtDevolucion.Size = New System.Drawing.Size(128, 20)
            Me.txtDevolucion.TabIndex = 157
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.Transparent
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label8.Location = New System.Drawing.Point(400, 9)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(96, 25)
            Me.Label8.TabIndex = 156
            Me.Label8.Text = "No. Devolución:"
            '
            'txtCliente
            '
            Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCliente.Location = New System.Drawing.Point(96, 8)
            Me.txtCliente.MaxLength = 50
            Me.txtCliente.Name = "txtCliente"
            Me.txtCliente.ReadOnly = True
            Me.txtCliente.Size = New System.Drawing.Size(304, 20)
            Me.txtCliente.TabIndex = 155
            '
            'frmDevolucionProveedorVer
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(1016, 526)
            Me.Controls.Add(Me.txtDevolucion)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.cbProveedor)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label24)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.txtFactura)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.dtpFecha)
            Me.Controls.Add(Me.txtCliente)
            Me.Name = "frmDevolucionProveedorVer"
            Me.GroupBox3.ResumeLayout(False)
            Me.gbBotones.ResumeLayout(False)
            CType(Me.dgFacturacionCliente, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region
        Dim Proveedores As New VB.SysContab.ProveedoresDB()
        Dim FormaPago As New VB.SysContab.Forma_PagoDB()
        Dim Devolucion As New VB.SysContab.DevolucionesProveedor()
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

            Me.cbProveedor.DataSource = Proveedores.ProveedoresList(3).Tables("Proveedores")
            Me.cbProveedor.ValueMember = "Codigo"
            Me.cbProveedor.DisplayMember = "Nombre"

            ConfigDetalles = Config.GetConfigDetails

            ds = Devolucion.DevolucionDetalle(Me.txtDevolucion.Text) 'Clientes.FacturaDetalleDevolucion(txtFactura.Text)

            dgFacturacionCliente.ReadOnly = True

            Me.cbProveedor.Enabled = False

            'If ds.Tables("Facturas_Compras").Rows(0).Item("Proveedor") = "9999" Then
            '    txtCliente.Text = ds.Tables("Facturas_Compras").Rows(0).Item("Nombre_Cliente").ToString
            '    txtCliente.Visible = True
            'Else
            txtCliente.Visible = False
            Me.cbProveedor.SelectedValue = ds.Tables("Facturas_Compras").Rows(0).Item("Proveedor")
            'End If

            dtpFecha.Value = ds.Tables("Facturas_Compras").Rows(0).Item("Fecha")
            dtpFecha.Enabled = False

            txtFactura.Text = ds.Tables("Facturas_Compras").Rows(0).Item("Factura_ID")
            txtFactura.ReadOnly = True

            'txtDevolucion.Text = ds.Tables("Facturas_Compras").Rows(0).Item("Devolucion")
            txtDevolucion.ReadOnly = True

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
                    '
                ElseIf IsNumeric(tCust.Rows(i)("SubTotal")) And tCust.Rows(i)("SubTotal").ToString <> "" Then
                    Try
                        SubTotalFacturaClienteV = SubTotalFacturaClienteV + tCust.Rows(i)("SubTotal")
                        SubTotalFacturaNoDescuentosV = SubTotalFacturaNoDescuentosV + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio"))
                        TotalDescuentoV = TotalDescuentoV + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio") * tCust.Rows(i)("Descuento") / 100.0)
                    Catch ex As Exception
                        MsgBox(ex.Message)

                    End Try
                End If
            Next

            'etSubTotal.Visible = False
            'etIva.Visible = False
            etSaldo.Visible = False
            etSaldoT.Visible = False

            etSubTotal.Text = SubTotalFacturaClienteV.ToString(Round)
            etIva.Text = (SubTotalFacturaClienteV * (ConfigDetalles.IVA / 100.0)).ToString(Round)
            etTotal.Text = (SubTotalFacturaClienteV + CDbl(etIva.Text)).ToString(Round)

            'etSaldo.Text = CDbl(ds.Tables("Facturas_Compras").Rows(0).Item("Saldo")).ToString(Round)
            'etSaldo.Refresh()

            Me.Text = "Devolución a Proveedores"

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

            'Dim cAgregar As DataColumn
            'cAgregar = New DataColumn("Agregar", GetType(System.Boolean))

            tCust.Columns.Add(cArticuloCodigo)
            tCust.Columns.Add(cArticulo)
            tCust.Columns.Add(cCantidad)
            tCust.Columns.Add(cPrecio)
            tCust.Columns.Add(cDescuento)
            tCust.Columns.Add(cSubTotal)
            tCust.Columns.Add(cCodigoTemporal)
            tCust.Columns.Add(cItemTipo)
            'tCust.Columns.Add(cAgregar)

            tCust.DefaultView.AllowDelete = False
            tCust.DefaultView.AllowNew = False

            myDataSet.Tables.Add(tCust)

            myDataSet.Tables("Articulos").DefaultView.AllowDelete = False
            myDataSet.Tables("Articulos").DefaultView.AllowNew = False

            Dim newRow1 As DataRow

            Dim j As Integer

            For j = 0 To ds.Tables("Facturas_Compras").Rows.Count - 1
                newRow1 = tCust.NewRow
                newRow1("ArticuloCodigo") = ds.Tables("Facturas_Compras").Rows(j).Item("Item_ID")
                tCust.Rows.Add(newRow1)

                tCust.Rows(j)("CodigoTemporal") = ds.Tables("Facturas_Compras").Rows(j).Item("Item_ID")
                tCust.Rows(j)("Articulo") = ds.Tables("Facturas_Compras").Rows(j).Item("Descripcion")
                tCust.Rows(j)("Cantidad") = ds.Tables("Facturas_Compras").Rows(j).Item("Cantidad")
                tCust.Rows(j)("Precio") = CDbl(ds.Tables("Facturas_Compras").Rows(j).Item("Item_Costo")).ToString(Round)
                tCust.Rows(j)("Descuento") = CDbl(ds.Tables("Facturas_Compras").Rows(j).Item("Item_Descuento")).ToString(Round)
                tCust.Rows(j)("SubTotal") = (CDbl(CDbl(tCust.Rows(j)("Cantidad")) * CDbl(tCust.Rows(j)("Precio"))) - CDbl(CDbl(CDbl(tCust.Rows(j)("Cantidad")) * CDbl(tCust.Rows(j)("Precio")) * (CDbl(tCust.Rows(j)("Descuento")))) / 100.0)).ToString(Round)
                tCust.Rows(j)("Tipo") = ds.Tables("Facturas_Compras").Rows(j).Item("Tipo_Item")
                'tCust.Rows(j)("Agregar") = False

            Next

        End Sub

        Private Sub TextBoxCantidadLeaveHandler(ByVal sender As Object, ByVal e As EventArgs)

            If Not IsNumeric(Cantidad.TextBox.Text) Then
                Cantidad.TextBox.Text = ValorActualCantidad
            Else
                If CDbl(Cantidad.TextBox.Text) <= 0 Then
                    MsgBox("La cantidad debe ser mayor que Cero (0)", MsgBoxStyle.Information)
                    Cantidad.TextBox.Text = ValorActualCantidad
                    Exit Sub
                End If
            End If

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

            AddHandler Cantidad.TextBox.Leave, New EventHandler(AddressOf TextBoxCantidadLeaveHandler)

            ts1.GridColumnStyles.Add(Cantidad)
            colCount = (colCount + 1)

            Cantidad.NullText = ""

            Dim Precio As DataGridTextBoxColumn
            Precio = New DataGridTextBoxColumn()
            Precio.MappingName = "Precio"
            Precio.HeaderText = "Costo"
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
            SubTotal.Width = 120
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

            'Dim boolCol As DataGridCheckBoxChangeEvent.MyDataGridBoolColumn
            'boolCol = New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn(colCount)
            'boolCol.MappingName = "Agregar"
            'boolCol.HeaderText = "Seleccionar"
            'boolCol.Alignment = HorizontalAlignment.Center
            ''uncomment this line to get a two-state checkbox
            'CType(boolCol, DataGridBoolColumn).AllowNull = False

            'boolCol.Width = 70
            'boolCol.ReadOnly = False

            'boolCol.NullText = ""

            ''hook the new event to our handler in the grid
            'AddHandler boolCol.BoolValueChanged, New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn.BoolValueChangedEventHandler(AddressOf HandleBoolChanges)

            'ts1.GridColumnStyles.Add(boolCol)
            'colCount = (colCount + 1)

            ts1.AllowSorting = False
            ts1.HeaderFont = dgFacturacionCliente.HeaderFont
            ts1.HeaderBackColor = Color.LightSteelBlue
            ts1.GridLineColor = Color.FromArgb(70, 130, 180)

            dgFacturacionCliente.CaptionVisible = False

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

        Private Sub HandleBoolChanges(ByVal sender As Object, ByVal e As DataGridCheckBoxChangeEvent.BoolValueChangedEventArgs)
            Dim s As String
            s = System.String.Format("Bool Changes: row {0}, col {1}   value {2}", e.Row, e.Column, e.BoolValue)
            Console.WriteLine(s)
        End Sub

        Private Sub cmdCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
            Me.Close()
        End Sub

        Private Sub dgFacturacionCliente_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dgFacturacionCliente.MouseUp
            Dim hti As DataGrid.HitTestInfo = Me.dgFacturacionCliente.HitTest(e.X, e.Y)
            Try
                If hti.Type = DataGrid.HitTestType.Cell AndAlso hti.Column = myCheckBoxCol Then
                    Me.dgFacturacionCliente(hti.Row, hti.Column) = Not CBool(Me.dgFacturacionCliente(hti.Row, hti.Column))
                Else
                    Exit Sub
                End If
            Catch ex As Exception
                'MessageBox.Show(ex.ToString())
            End Try
        End Sub 'dataGrid2_MouseUp

        Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
            Exit Sub
            Dim Cantidad As Integer
            Cantidad = 0

            If tCust.Rows.Count = 0 Then
                MsgBox("Seleccione al menos un Producto", MsgBoxStyle.Critical)
                dgFacturacionCliente.Focus()
                Exit Sub
            End If

            For i = 0 To tCust.Rows.Count - 1
                If tCust.Rows(i)("Agregar") = True Then
                    Cantidad = 1
                    Exit For
                End If
            Next

            If Cantidad = 0 Then
                MsgBox("Seleccione al menos un Producto", MsgBoxStyle.Critical)
                dgFacturacionCliente.Focus()
                Exit Sub
            End If

            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction

            Dim Numero As String
            Dim Iva As Double

            Numero = Devolucion.Numero

            Try
                Devolucion.AddItem(Numero, Me.txtFactura.Text, Me.cbProveedor.SelectedValue)
                For i = 0 To tCust.Rows.Count - 1
                    If tCust.Rows(i)("Agregar") = True Then
                        Iva = (CDbl(tCust.Rows(i)("Precio")) * CDbl(tCust.Rows(i)("Cantidad"))) + ((CDbl(tCust.Rows(i)("Precio")) * CDbl(tCust.Rows(i)("Cantidad"))) * (ConfigDetalles.IVA / 100.0))
                        Devolucion.AddItemDetalle(Numero, tCust.Rows(i)("CodigoTemporal"), tCust.Rows(i)("Tipo"), tCust.Rows(i)("Cantidad"), Iva)
                        Devolucion.UpdateItem(Me.txtFactura.Text, Me.cbProveedor.SelectedValue, tCust.Rows(i)("CodigoTemporal"), "P", 1)
                    End If
                Next
                VB.SysContab.Rutinas.okTransaccion()
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message & " Guardar")
                VB.SysContab.Rutinas.ErrorTransaccion()
                Exit Sub
            End Try
        End Sub

        Private Sub dgFacturacionCliente_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFacturacionCliente.CurrentCellChanged
            Try
                'If Me.dgFacturacionCliente.CurrentRowIndex = tCust.Rows.Count Then
                '    Me.dgFacturacionCliente.ReadOnly = True
                '    Exit Sub
                'Else
                '    Me.dgFacturacionCliente.ReadOnly = False
                'End If

                'ValorActualCantidad = tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Cantidad")

            Catch ex As Exception
                'MsgBox(ex.Message)
                Exit Sub
            End Try
        End Sub

        Private Sub cbTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTodos.CheckedChanged
            If Me.cbTodos.Checked = True Then
                For i = 0 To tCust.Rows.Count - 1
                    tCust.Rows(i)("Agregar") = True
                Next
            Else
                For i = 0 To tCust.Rows.Count - 1
                    tCust.Rows(i)("Agregar") = False
                Next
            End If
        End Sub

        Private Sub cmdConsultaClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultaClientes.Click

        End Sub

        Private Sub cmdVerPagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVerPagos.Click

        End Sub
    End Class

End Namespace
