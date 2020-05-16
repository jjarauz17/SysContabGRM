Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace DataGridTextBoxCombo
    Public Class frmFacturasPuntosVenta
        Inherits DevExpress.XtraEditors.XtraForm

        Private Shared ChildInstance As frmFacturasPuntosVenta = Nothing

        Public Shared Function Instance() As frmFacturasPuntosVenta
            If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
                ChildInstance = New frmFacturasPuntosVenta()
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
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents cbTipoFactura As System.Windows.Forms.ComboBox
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents etSaldoT As System.Windows.Forms.Label
        Friend WithEvents etSaldo As System.Windows.Forms.Label
        Friend WithEvents txtVendedor As System.Windows.Forms.TextBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents etSubTotal As System.Windows.Forms.Label
        Friend WithEvents etSubTotalT As System.Windows.Forms.Label
        Friend WithEvents etIva As System.Windows.Forms.Label
        Friend WithEvents etIvaT As System.Windows.Forms.Label
        Friend WithEvents gbBotones As System.Windows.Forms.GroupBox
        Friend WithEvents cmdConsultaClientes As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdConsulta As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents cmdProceso As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents gbTipo As System.Windows.Forms.GroupBox
        Friend WithEvents rbAmbos As System.Windows.Forms.RadioButton
        Friend WithEvents rbServicios As System.Windows.Forms.RadioButton
        Friend WithEvents rbProductos As System.Windows.Forms.RadioButton
        Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtDescuentoServicio As System.Windows.Forms.TextBox
        Friend WithEvents txtDescuentoProducto As System.Windows.Forms.TextBox
        Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents txtMunicipio As System.Windows.Forms.TextBox
        Friend WithEvents txtDepartamento As System.Windows.Forms.TextBox
        Friend WithEvents txtPais As System.Windows.Forms.TextBox
        Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
        Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
        Friend WithEvents txtRuc As System.Windows.Forms.TextBox
        Friend WithEvents cbMunicipios As System.Windows.Forms.ComboBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents cbDepartamentos As System.Windows.Forms.ComboBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents etTotal As System.Windows.Forms.Label
        Friend WithEvents etTotalT As System.Windows.Forms.Label
        Friend WithEvents dgFacturacionCliente As System.Windows.Forms.DataGrid
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaPago As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtFactura As System.Windows.Forms.TextBox
        Friend WithEvents cbCliente As System.Windows.Forms.ComboBox
        Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents txtPuntoVenta As System.Windows.Forms.TextBox
        Friend WithEvents cmdOrdenesProceso As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdCancelar1 As DevExpress.XtraEditors.SimpleButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label7 = New System.Windows.Forms.Label
            Me.GroupBox3 = New System.Windows.Forms.GroupBox
            Me.txtPuntoVenta = New System.Windows.Forms.TextBox
            Me.Label19 = New System.Windows.Forms.Label
            Me.cbTipoFactura = New System.Windows.Forms.ComboBox
            Me.Label25 = New System.Windows.Forms.Label
            Me.etSaldoT = New System.Windows.Forms.Label
            Me.etSaldo = New System.Windows.Forms.Label
            Me.txtVendedor = New System.Windows.Forms.TextBox
            Me.Label10 = New System.Windows.Forms.Label
            Me.etSubTotal = New System.Windows.Forms.Label
            Me.etSubTotalT = New System.Windows.Forms.Label
            Me.etIva = New System.Windows.Forms.Label
            Me.etIvaT = New System.Windows.Forms.Label
            Me.gbBotones = New System.Windows.Forms.GroupBox
            Me.cmdCancelar1 = New DevExpress.XtraEditors.SimpleButton
            Me.cmdOrdenesProceso = New DevExpress.XtraEditors.SimpleButton
            Me.cmdConsultaClientes = New DevExpress.XtraEditors.SimpleButton
            Me.cmdConsulta = New DevExpress.XtraEditors.SimpleButton
            Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
            Me.GroupBox2 = New System.Windows.Forms.GroupBox
            Me.cmdProceso = New DevExpress.XtraEditors.SimpleButton
            Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
            Me.gbTipo = New System.Windows.Forms.GroupBox
            Me.rbAmbos = New System.Windows.Forms.RadioButton
            Me.rbServicios = New System.Windows.Forms.RadioButton
            Me.rbProductos = New System.Windows.Forms.RadioButton
            Me.TextBox6 = New System.Windows.Forms.TextBox
            Me.Label12 = New System.Windows.Forms.Label
            Me.Label17 = New System.Windows.Forms.Label
            Me.Label18 = New System.Windows.Forms.Label
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            Me.txtDescuentoServicio = New System.Windows.Forms.TextBox
            Me.txtDescuentoProducto = New System.Windows.Forms.TextBox
            Me.TextBox5 = New System.Windows.Forms.TextBox
            Me.Label8 = New System.Windows.Forms.Label
            Me.Label13 = New System.Windows.Forms.Label
            Me.Label14 = New System.Windows.Forms.Label
            Me.Label15 = New System.Windows.Forms.Label
            Me.Label16 = New System.Windows.Forms.Label
            Me.txtMunicipio = New System.Windows.Forms.TextBox
            Me.txtDepartamento = New System.Windows.Forms.TextBox
            Me.txtPais = New System.Windows.Forms.TextBox
            Me.txtDireccion = New System.Windows.Forms.TextBox
            Me.txtTelefono = New System.Windows.Forms.TextBox
            Me.txtRuc = New System.Windows.Forms.TextBox
            Me.cbMunicipios = New System.Windows.Forms.ComboBox
            Me.Label5 = New System.Windows.Forms.Label
            Me.cbDepartamentos = New System.Windows.Forms.ComboBox
            Me.Label6 = New System.Windows.Forms.Label
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label9 = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.Label3 = New System.Windows.Forms.Label
            Me.etTotal = New System.Windows.Forms.Label
            Me.etTotalT = New System.Windows.Forms.Label
            Me.dgFacturacionCliente = New System.Windows.Forms.DataGrid
            Me.Label11 = New System.Windows.Forms.Label
            Me.Label24 = New System.Windows.Forms.Label
            Me.dtpFechaPago = New System.Windows.Forms.DateTimePicker
            Me.txtFactura = New System.Windows.Forms.TextBox
            Me.cbCliente = New System.Windows.Forms.ComboBox
            Me.dtpFecha = New System.Windows.Forms.DateTimePicker
            Me.GroupBox3.SuspendLayout()
            Me.gbBotones.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.gbTipo.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgFacturacionCliente, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(616, 8)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(64, 25)
            Me.Label1.TabIndex = 147
            Me.Label1.Text = "Fecha:"
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label7.Location = New System.Drawing.Point(400, 8)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(72, 25)
            Me.Label7.TabIndex = 149
            Me.Label7.Text = "No. Orden"
            '
            'GroupBox3
            '
            Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.GroupBox3.Controls.Add(Me.txtPuntoVenta)
            Me.GroupBox3.Controls.Add(Me.Label19)
            Me.GroupBox3.Controls.Add(Me.cbTipoFactura)
            Me.GroupBox3.Controls.Add(Me.Label25)
            Me.GroupBox3.Controls.Add(Me.etSaldoT)
            Me.GroupBox3.Controls.Add(Me.etSaldo)
            Me.GroupBox3.Controls.Add(Me.txtVendedor)
            Me.GroupBox3.Controls.Add(Me.Label10)
            Me.GroupBox3.Controls.Add(Me.etSubTotal)
            Me.GroupBox3.Controls.Add(Me.etSubTotalT)
            Me.GroupBox3.Controls.Add(Me.etIva)
            Me.GroupBox3.Controls.Add(Me.etIvaT)
            Me.GroupBox3.Controls.Add(Me.gbBotones)
            Me.GroupBox3.Controls.Add(Me.gbTipo)
            Me.GroupBox3.Controls.Add(Me.GroupBox1)
            Me.GroupBox3.Controls.Add(Me.txtMunicipio)
            Me.GroupBox3.Controls.Add(Me.txtDepartamento)
            Me.GroupBox3.Controls.Add(Me.txtPais)
            Me.GroupBox3.Controls.Add(Me.txtDireccion)
            Me.GroupBox3.Controls.Add(Me.txtTelefono)
            Me.GroupBox3.Controls.Add(Me.txtRuc)
            Me.GroupBox3.Controls.Add(Me.cbMunicipios)
            Me.GroupBox3.Controls.Add(Me.Label5)
            Me.GroupBox3.Controls.Add(Me.cbDepartamentos)
            Me.GroupBox3.Controls.Add(Me.Label6)
            Me.GroupBox3.Controls.Add(Me.Label2)
            Me.GroupBox3.Controls.Add(Me.Label9)
            Me.GroupBox3.Controls.Add(Me.Label4)
            Me.GroupBox3.Controls.Add(Me.Label3)
            Me.GroupBox3.Controls.Add(Me.etTotal)
            Me.GroupBox3.Controls.Add(Me.etTotalT)
            Me.GroupBox3.Controls.Add(Me.dgFacturacionCliente)
            Me.GroupBox3.Location = New System.Drawing.Point(8, 33)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(1000, 483)
            Me.GroupBox3.TabIndex = 148
            Me.GroupBox3.TabStop = False
            '
            'txtPuntoVenta
            '
            Me.txtPuntoVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtPuntoVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPuntoVenta.ForeColor = System.Drawing.Color.Maroon
            Me.txtPuntoVenta.Location = New System.Drawing.Point(776, 121)
            Me.txtPuntoVenta.MaxLength = 50
            Me.txtPuntoVenta.Name = "txtPuntoVenta"
            Me.txtPuntoVenta.ReadOnly = True
            Me.txtPuntoVenta.Size = New System.Drawing.Size(216, 20)
            Me.txtPuntoVenta.TabIndex = 143
            '
            'Label19
            '
            Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label19.Location = New System.Drawing.Point(672, 121)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(96, 25)
            Me.Label19.TabIndex = 142
            Me.Label19.Text = "Punto de Venta:"
            '
            'cbTipoFactura
            '
            Me.cbTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbTipoFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbTipoFactura.Location = New System.Drawing.Point(520, 112)
            Me.cbTipoFactura.Name = "cbTipoFactura"
            Me.cbTipoFactura.Size = New System.Drawing.Size(152, 21)
            Me.cbTipoFactura.TabIndex = 140
            '
            'Label25
            '
            Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label25.Location = New System.Drawing.Point(416, 112)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(96, 26)
            Me.Label25.TabIndex = 141
            Me.Label25.Text = "Forma de Pago:"
            '
            'etSaldoT
            '
            Me.etSaldoT.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etSaldoT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etSaldoT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etSaldoT.Location = New System.Drawing.Point(22, 448)
            Me.etSaldoT.Name = "etSaldoT"
            Me.etSaldoT.Size = New System.Drawing.Size(56, 26)
            Me.etSaldoT.TabIndex = 139
            Me.etSaldoT.Text = "Saldo:"
            Me.etSaldoT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.etSaldoT.Visible = False
            '
            'etSaldo
            '
            Me.etSaldo.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etSaldo.ForeColor = System.Drawing.Color.Black
            Me.etSaldo.Location = New System.Drawing.Point(86, 448)
            Me.etSaldo.Name = "etSaldo"
            Me.etSaldo.Size = New System.Drawing.Size(96, 26)
            Me.etSaldo.TabIndex = 138
            Me.etSaldo.Text = "0.00"
            Me.etSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.etSaldo.Visible = False
            '
            'txtVendedor
            '
            Me.txtVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtVendedor.Location = New System.Drawing.Point(752, 86)
            Me.txtVendedor.MaxLength = 50
            Me.txtVendedor.Name = "txtVendedor"
            Me.txtVendedor.ReadOnly = True
            Me.txtVendedor.Size = New System.Drawing.Size(240, 20)
            Me.txtVendedor.TabIndex = 136
            '
            'Label10
            '
            Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label10.Location = New System.Drawing.Point(672, 86)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(72, 26)
            Me.Label10.TabIndex = 135
            Me.Label10.Text = "Vendedor:"
            '
            'etSubTotal
            '
            Me.etSubTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etSubTotal.ForeColor = System.Drawing.Color.Maroon
            Me.etSubTotal.Location = New System.Drawing.Point(286, 448)
            Me.etSubTotal.Name = "etSubTotal"
            Me.etSubTotal.Size = New System.Drawing.Size(112, 26)
            Me.etSubTotal.TabIndex = 134
            Me.etSubTotal.Text = "0.00"
            Me.etSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etSubTotalT
            '
            Me.etSubTotalT.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etSubTotalT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etSubTotalT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etSubTotalT.Location = New System.Drawing.Point(198, 448)
            Me.etSubTotalT.Name = "etSubTotalT"
            Me.etSubTotalT.Size = New System.Drawing.Size(80, 26)
            Me.etSubTotalT.TabIndex = 133
            Me.etSubTotalT.Text = "Sub Total:"
            Me.etSubTotalT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etIva
            '
            Me.etIva.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etIva.ForeColor = System.Drawing.Color.Maroon
            Me.etIva.Location = New System.Drawing.Point(510, 448)
            Me.etIva.Name = "etIva"
            Me.etIva.Size = New System.Drawing.Size(112, 26)
            Me.etIva.TabIndex = 132
            Me.etIva.Text = "0.00"
            Me.etIva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etIvaT
            '
            Me.etIvaT.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etIvaT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etIvaT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etIvaT.Location = New System.Drawing.Point(406, 448)
            Me.etIvaT.Name = "etIvaT"
            Me.etIvaT.Size = New System.Drawing.Size(96, 26)
            Me.etIvaT.TabIndex = 131
            Me.etIvaT.Text = "IVA:"
            Me.etIvaT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'gbBotones
            '
            Me.gbBotones.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.gbBotones.Controls.Add(Me.cmdCancelar1)
            Me.gbBotones.Controls.Add(Me.cmdOrdenesProceso)
            Me.gbBotones.Controls.Add(Me.cmdConsultaClientes)
            Me.gbBotones.Controls.Add(Me.cmdConsulta)
            Me.gbBotones.Controls.Add(Me.cmdCancelar)
            Me.gbBotones.Controls.Add(Me.GroupBox2)
            Me.gbBotones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBotones.ForeColor = System.Drawing.Color.Maroon
            Me.gbBotones.Location = New System.Drawing.Point(904, 132)
            Me.gbBotones.Name = "gbBotones"
            Me.gbBotones.Size = New System.Drawing.Size(88, 341)
            Me.gbBotones.TabIndex = 130
            Me.gbBotones.TabStop = False
            '
            'cmdCancelar1
            '
            Me.cmdCancelar1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdCancelar1.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdCancelar1.Appearance.Options.UseFont = True
            Me.cmdCancelar1.Appearance.Options.UseForeColor = True
            Me.cmdCancelar1.Location = New System.Drawing.Point(8, 250)
            Me.cmdCancelar1.Name = "cmdCancelar1"
            Me.cmdCancelar1.Size = New System.Drawing.Size(72, 34)
            Me.cmdCancelar1.TabIndex = 145
            Me.cmdCancelar1.Text = "C&ancelar"
            '
            'cmdOrdenesProceso
            '
            Me.cmdOrdenesProceso.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdOrdenesProceso.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdOrdenesProceso.Appearance.Options.UseFont = True
            Me.cmdOrdenesProceso.Appearance.Options.UseForeColor = True
            Me.cmdOrdenesProceso.Location = New System.Drawing.Point(8, 207)
            Me.cmdOrdenesProceso.Name = "cmdOrdenesProceso"
            Me.cmdOrdenesProceso.Size = New System.Drawing.Size(72, 34)
            Me.cmdOrdenesProceso.TabIndex = 144
            Me.cmdOrdenesProceso.Text = "&Buscar Ordenes"
            '
            'cmdConsultaClientes
            '
            Me.cmdConsultaClientes.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdConsultaClientes.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdConsultaClientes.Appearance.Options.UseFont = True
            Me.cmdConsultaClientes.Appearance.Options.UseForeColor = True
            Me.cmdConsultaClientes.Location = New System.Drawing.Point(8, 60)
            Me.cmdConsultaClientes.Name = "cmdConsultaClientes"
            Me.cmdConsultaClientes.Size = New System.Drawing.Size(72, 35)
            Me.cmdConsultaClientes.TabIndex = 33
            Me.cmdConsultaClientes.Text = "C&lientes"
            '
            'cmdConsulta
            '
            Me.cmdConsulta.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdConsulta.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdConsulta.Appearance.Options.UseFont = True
            Me.cmdConsulta.Appearance.Options.UseForeColor = True
            Me.cmdConsulta.Location = New System.Drawing.Point(8, 17)
            Me.cmdConsulta.Name = "cmdConsulta"
            Me.cmdConsulta.Size = New System.Drawing.Size(72, 35)
            Me.cmdConsulta.TabIndex = 31
            Me.cmdConsulta.Text = "&Productos"
            '
            'cmdCancelar
            '
            Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdCancelar.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdCancelar.Appearance.Options.UseFont = True
            Me.cmdCancelar.Appearance.Options.UseForeColor = True
            Me.cmdCancelar.Location = New System.Drawing.Point(8, 302)
            Me.cmdCancelar.Name = "cmdCancelar"
            Me.cmdCancelar.Size = New System.Drawing.Size(72, 34)
            Me.cmdCancelar.TabIndex = 29
            Me.cmdCancelar.Text = "&Salir"
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.GroupBox2.Controls.Add(Me.cmdProceso)
            Me.GroupBox2.Controls.Add(Me.cmdAceptar)
            Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
            Me.GroupBox2.Location = New System.Drawing.Point(0, 95)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(88, 103)
            Me.GroupBox2.TabIndex = 142
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Grabar"
            '
            'cmdProceso
            '
            Me.cmdProceso.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdProceso.Appearance.ForeColor = System.Drawing.Color.Navy
            Me.cmdProceso.Appearance.Options.UseFont = True
            Me.cmdProceso.Appearance.Options.UseForeColor = True
            Me.cmdProceso.Location = New System.Drawing.Point(8, 60)
            Me.cmdProceso.Name = "cmdProceso"
            Me.cmdProceso.Size = New System.Drawing.Size(72, 35)
            Me.cmdProceso.TabIndex = 29
            Me.cmdProceso.Text = "Or&den en Proceso"
            '
            'cmdAceptar
            '
            Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdAceptar.Appearance.ForeColor = System.Drawing.Color.Navy
            Me.cmdAceptar.Appearance.Options.UseFont = True
            Me.cmdAceptar.Appearance.Options.UseForeColor = True
            Me.cmdAceptar.Location = New System.Drawing.Point(8, 17)
            Me.cmdAceptar.Name = "cmdAceptar"
            Me.cmdAceptar.Size = New System.Drawing.Size(72, 35)
            Me.cmdAceptar.TabIndex = 28
            Me.cmdAceptar.Text = "&Orden Terminada"
            '
            'gbTipo
            '
            Me.gbTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.gbTipo.Controls.Add(Me.rbAmbos)
            Me.gbTipo.Controls.Add(Me.rbServicios)
            Me.gbTipo.Controls.Add(Me.rbProductos)
            Me.gbTipo.Controls.Add(Me.TextBox6)
            Me.gbTipo.Controls.Add(Me.Label12)
            Me.gbTipo.Controls.Add(Me.Label17)
            Me.gbTipo.Controls.Add(Me.Label18)
            Me.gbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipo.ForeColor = System.Drawing.Color.Maroon
            Me.gbTipo.Location = New System.Drawing.Point(160, 95)
            Me.gbTipo.Name = "gbTipo"
            Me.gbTipo.Size = New System.Drawing.Size(256, 43)
            Me.gbTipo.TabIndex = 129
            Me.gbTipo.TabStop = False
            '
            'rbAmbos
            '
            Me.rbAmbos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbAmbos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.rbAmbos.Location = New System.Drawing.Point(184, 17)
            Me.rbAmbos.Name = "rbAmbos"
            Me.rbAmbos.Size = New System.Drawing.Size(64, 17)
            Me.rbAmbos.TabIndex = 126
            Me.rbAmbos.Text = "Ambos"
            '
            'rbServicios
            '
            Me.rbServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbServicios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.rbServicios.Location = New System.Drawing.Point(104, 17)
            Me.rbServicios.Name = "rbServicios"
            Me.rbServicios.Size = New System.Drawing.Size(80, 17)
            Me.rbServicios.TabIndex = 125
            Me.rbServicios.Text = "Servicios"
            '
            'rbProductos
            '
            Me.rbProductos.Checked = True
            Me.rbProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbProductos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.rbProductos.Location = New System.Drawing.Point(16, 17)
            Me.rbProductos.Name = "rbProductos"
            Me.rbProductos.Size = New System.Drawing.Size(88, 17)
            Me.rbProductos.TabIndex = 124
            Me.rbProductos.TabStop = True
            Me.rbProductos.Text = "Productos"
            '
            'TextBox6
            '
            Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox6.Location = New System.Drawing.Point(832, 17)
            Me.TextBox6.MaxLength = 50
            Me.TextBox6.Name = "TextBox6"
            Me.TextBox6.ReadOnly = True
            Me.TextBox6.Size = New System.Drawing.Size(136, 20)
            Me.TextBox6.TabIndex = 123
            '
            'Label12
            '
            Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label12.Location = New System.Drawing.Point(752, 17)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(72, 26)
            Me.Label12.TabIndex = 103
            Me.Label12.Text = "Teléfono:"
            '
            'Label17
            '
            Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label17.ForeColor = System.Drawing.Color.Maroon
            Me.Label17.Location = New System.Drawing.Point(632, 474)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(112, 26)
            Me.Label17.TabIndex = 110
            Me.Label17.Text = "0.00"
            Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label18
            '
            Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label18.Location = New System.Drawing.Point(536, 474)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(96, 26)
            Me.Label18.TabIndex = 109
            Me.Label18.Text = "Total:"
            Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.GroupBox1.Controls.Add(Me.txtDescuentoServicio)
            Me.GroupBox1.Controls.Add(Me.txtDescuentoProducto)
            Me.GroupBox1.Controls.Add(Me.TextBox5)
            Me.GroupBox1.Controls.Add(Me.Label8)
            Me.GroupBox1.Controls.Add(Me.Label13)
            Me.GroupBox1.Controls.Add(Me.Label14)
            Me.GroupBox1.Controls.Add(Me.Label15)
            Me.GroupBox1.Controls.Add(Me.Label16)
            Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
            Me.GroupBox1.Location = New System.Drawing.Point(8, 95)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(144, 43)
            Me.GroupBox1.TabIndex = 128
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Tipo de Cliente"
            '
            'txtDescuentoServicio
            '
            Me.txtDescuentoServicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDescuentoServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDescuentoServicio.Location = New System.Drawing.Point(96, 17)
            Me.txtDescuentoServicio.MaxLength = 50
            Me.txtDescuentoServicio.Name = "txtDescuentoServicio"
            Me.txtDescuentoServicio.ReadOnly = True
            Me.txtDescuentoServicio.Size = New System.Drawing.Size(32, 20)
            Me.txtDescuentoServicio.TabIndex = 126
            '
            'txtDescuentoProducto
            '
            Me.txtDescuentoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDescuentoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDescuentoProducto.Location = New System.Drawing.Point(32, 17)
            Me.txtDescuentoProducto.MaxLength = 50
            Me.txtDescuentoProducto.Name = "txtDescuentoProducto"
            Me.txtDescuentoProducto.ReadOnly = True
            Me.txtDescuentoProducto.Size = New System.Drawing.Size(32, 20)
            Me.txtDescuentoProducto.TabIndex = 125
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
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label8.Location = New System.Drawing.Point(8, 17)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(24, 17)
            Me.Label8.TabIndex = 115
            Me.Label8.Text = "P"
            '
            'Label13
            '
            Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label13.Location = New System.Drawing.Point(72, 17)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(24, 17)
            Me.Label13.TabIndex = 102
            Me.Label13.Text = "S"
            '
            'Label14
            '
            Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label14.Location = New System.Drawing.Point(752, 17)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(72, 26)
            Me.Label14.TabIndex = 103
            Me.Label14.Text = "Teléfono:"
            '
            'Label15
            '
            Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label15.ForeColor = System.Drawing.Color.Maroon
            Me.Label15.Location = New System.Drawing.Point(632, 474)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(112, 26)
            Me.Label15.TabIndex = 110
            Me.Label15.Text = "0.00"
            Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label16
            '
            Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label16.Location = New System.Drawing.Point(536, 474)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(96, 26)
            Me.Label16.TabIndex = 109
            Me.Label16.Text = "Total:"
            Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtMunicipio
            '
            Me.txtMunicipio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMunicipio.Location = New System.Drawing.Point(752, 52)
            Me.txtMunicipio.MaxLength = 50
            Me.txtMunicipio.Name = "txtMunicipio"
            Me.txtMunicipio.ReadOnly = True
            Me.txtMunicipio.Size = New System.Drawing.Size(240, 20)
            Me.txtMunicipio.TabIndex = 127
            '
            'txtDepartamento
            '
            Me.txtDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDepartamento.Location = New System.Drawing.Point(376, 69)
            Me.txtDepartamento.MaxLength = 50
            Me.txtDepartamento.Name = "txtDepartamento"
            Me.txtDepartamento.ReadOnly = True
            Me.txtDepartamento.Size = New System.Drawing.Size(280, 20)
            Me.txtDepartamento.TabIndex = 126
            '
            'txtPais
            '
            Me.txtPais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPais.Location = New System.Drawing.Point(48, 69)
            Me.txtPais.MaxLength = 50
            Me.txtPais.Name = "txtPais"
            Me.txtPais.ReadOnly = True
            Me.txtPais.Size = New System.Drawing.Size(216, 20)
            Me.txtPais.TabIndex = 125
            '
            'txtDireccion
            '
            Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDireccion.Location = New System.Drawing.Point(376, 17)
            Me.txtDireccion.MaxLength = 50
            Me.txtDireccion.Multiline = True
            Me.txtDireccion.Name = "txtDireccion"
            Me.txtDireccion.ReadOnly = True
            Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtDireccion.Size = New System.Drawing.Size(280, 43)
            Me.txtDireccion.TabIndex = 124
            '
            'txtTelefono
            '
            Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTelefono.Location = New System.Drawing.Point(752, 17)
            Me.txtTelefono.MaxLength = 50
            Me.txtTelefono.Name = "txtTelefono"
            Me.txtTelefono.ReadOnly = True
            Me.txtTelefono.Size = New System.Drawing.Size(240, 20)
            Me.txtTelefono.TabIndex = 123
            '
            'txtRuc
            '
            Me.txtRuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRuc.Location = New System.Drawing.Point(48, 17)
            Me.txtRuc.MaxLength = 50
            Me.txtRuc.Name = "txtRuc"
            Me.txtRuc.ReadOnly = True
            Me.txtRuc.Size = New System.Drawing.Size(216, 20)
            Me.txtRuc.TabIndex = 122
            '
            'cbMunicipios
            '
            Me.cbMunicipios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
            Me.cbMunicipios.Enabled = False
            Me.cbMunicipios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbMunicipios.Location = New System.Drawing.Point(448, 310)
            Me.cbMunicipios.Name = "cbMunicipios"
            Me.cbMunicipios.Size = New System.Drawing.Size(224, 23)
            Me.cbMunicipios.TabIndex = 121
            Me.cbMunicipios.Visible = False
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label5.Location = New System.Drawing.Point(672, 52)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(72, 26)
            Me.Label5.TabIndex = 120
            Me.Label5.Text = "Municipio:"
            '
            'cbDepartamentos
            '
            Me.cbDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
            Me.cbDepartamentos.Enabled = False
            Me.cbDepartamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbDepartamentos.Location = New System.Drawing.Point(448, 276)
            Me.cbDepartamentos.Name = "cbDepartamentos"
            Me.cbDepartamentos.Size = New System.Drawing.Size(224, 22)
            Me.cbDepartamentos.TabIndex = 119
            Me.cbDepartamentos.Visible = False
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(8, 69)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(40, 26)
            Me.Label6.TabIndex = 115
            Me.Label6.Text = "País:"
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(280, 17)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(88, 26)
            Me.Label2.TabIndex = 101
            Me.Label2.Text = "Dirección:"
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label9.Location = New System.Drawing.Point(8, 17)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(40, 26)
            Me.Label9.TabIndex = 100
            Me.Label9.Text = "RUC:"
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label4.Location = New System.Drawing.Point(280, 69)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(96, 26)
            Me.Label4.TabIndex = 102
            Me.Label4.Text = "Departamento:"
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(672, 17)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(72, 26)
            Me.Label3.TabIndex = 103
            Me.Label3.Text = "Teléfono:"
            '
            'etTotal
            '
            Me.etTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTotal.ForeColor = System.Drawing.Color.Maroon
            Me.etTotal.Location = New System.Drawing.Point(694, 439)
            Me.etTotal.Name = "etTotal"
            Me.etTotal.Size = New System.Drawing.Size(168, 35)
            Me.etTotal.TabIndex = 110
            Me.etTotal.Text = "0.00"
            Me.etTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etTotalT
            '
            Me.etTotalT.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etTotalT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTotalT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etTotalT.Location = New System.Drawing.Point(630, 448)
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
            Me.dgFacturacionCliente.Location = New System.Drawing.Point(8, 146)
            Me.dgFacturacionCliente.Name = "dgFacturacionCliente"
            Me.dgFacturacionCliente.ParentRowsBackColor = System.Drawing.Color.LightGray
            Me.dgFacturacionCliente.ParentRowsForeColor = System.Drawing.Color.Black
            Me.dgFacturacionCliente.SelectionBackColor = System.Drawing.Color.Firebrick
            Me.dgFacturacionCliente.SelectionForeColor = System.Drawing.Color.White
            Me.dgFacturacionCliente.Size = New System.Drawing.Size(888, 290)
            Me.dgFacturacionCliente.TabIndex = 27
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label11.Location = New System.Drawing.Point(792, 8)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(112, 25)
            Me.Label11.TabIndex = 151
            Me.Label11.Text = "Fecha de Pago:"
            '
            'Label24
            '
            Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label24.Location = New System.Drawing.Point(8, 8)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(64, 25)
            Me.Label24.TabIndex = 146
            Me.Label24.Text = "Cliente:"
            '
            'dtpFechaPago
            '
            Me.dtpFechaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaPago.Location = New System.Drawing.Point(904, 8)
            Me.dtpFechaPago.Name = "dtpFechaPago"
            Me.dtpFechaPago.Size = New System.Drawing.Size(96, 20)
            Me.dtpFechaPago.TabIndex = 153
            '
            'txtFactura
            '
            Me.txtFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFactura.Location = New System.Drawing.Point(480, 8)
            Me.txtFactura.MaxLength = 50
            Me.txtFactura.Name = "txtFactura"
            Me.txtFactura.ReadOnly = True
            Me.txtFactura.Size = New System.Drawing.Size(128, 20)
            Me.txtFactura.TabIndex = 150
            '
            'cbCliente
            '
            Me.cbCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbCliente.Location = New System.Drawing.Point(72, 8)
            Me.cbCliente.Name = "cbCliente"
            Me.cbCliente.Size = New System.Drawing.Size(320, 21)
            Me.cbCliente.TabIndex = 145
            '
            'dtpFecha
            '
            Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFecha.Location = New System.Drawing.Point(680, 8)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
            Me.dtpFecha.TabIndex = 152
            '
            'frmFacturasPuntosVenta
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(1016, 533)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.Label11)
            Me.Controls.Add(Me.Label24)
            Me.Controls.Add(Me.dtpFechaPago)
            Me.Controls.Add(Me.txtFactura)
            Me.Controls.Add(Me.cbCliente)
            Me.Controls.Add(Me.dtpFecha)
            Me.Name = "frmFacturasPuntosVenta"
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.gbBotones.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.gbTipo.ResumeLayout(False)
            Me.gbTipo.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.dgFacturacionCliente, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Dim OrdenProceso As New VB.SysContab.OrdenProcesoDB()

        'Dim FacturaTemporal As New VB.SysContab.Facturas_Ventas_TemporalDB()
        Dim Ordenes As New VB.SysContab.OrdenesDB()

        Dim Clientes As New VB.SysContab.ClientesDB()
        Dim Departamentos As New VB.SysContab.DepartamentosCDB()
        Dim Municipios As New VB.SysContab.MunicipiosDB()
        Dim Articulos As New VB.SysContab.ArticulosDB()
        Dim Servicios As New VB.SysContab.ServiciosDB()
        Dim DetallesProducto As New VB.SysContab.ArticulosDetails()
        Dim DetallesCliente As New VB.SysContab.ClientesDetails()
        'Dim PuntoVenta As New VB.SysContab.PuntosVentasDB()

        Dim FormaPago As New VB.SysContab.Forma_PagoDB()

        Dim Cotizaciones As New VB.SysContab.CotizacionesDB()

        Dim DetallesVendedor As New VB.SysContab.VendedoresDetails()
        Dim Vendedor As New VB.SysContab.VendedoresDB()

        Dim r As New VB.SysContab.Rutinas()
        Dim ds As DataSet

        Dim WithEvents tCust As DataTable
        Private WithEvents myDataSet As DataSet

        Dim i As Integer

        Dim WithEvents Articulo As DataGridComboBoxColumn
        Dim WithEvents ArticuloCodigo As DataGridComboBoxColumn
        Dim Cantidad As DataGridTextBoxColumn
        Dim Descuento As DataGridTextBoxColumn

        Dim WithEvents ItemTipo As DataGridComboBoxColumn

        Dim ValorActualCantidad As Double
        Dim ValorActualPrecio As Double
        Dim ValorActualDescuento As Double

        Dim TipoCambio As Double

        Dim TotalCordobas As Double

        Dim TipoDescuento As String

        Dim dsItems As DataSet

        ''''''''''Variables para buscar en el combo Cliente''''''''''
        Dim Cliente As String

        Public Codigo As String

        Dim VentaPerdidaNumero As Long

        'Dim dsProveedoresTemporales As DataSet
        'Dim Ordenes_Compras As New VB.SysContab.Ordenes_ComprasDB()
        'Dim dsItemTemporales As DataSet

        Dim Config As New VB.SysContab.ConfiguracionDB()
        Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails()

        'Dim FacturasCompras As New VB.SysContab.Facturas_ComprasDB()

        Dim CantidadPerdida As Double

        Dim Iva As Double
        Dim SubTotal As Double

        Private Sub frmFacturasPuntosVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            VB.SysContab.Rutinas.CambiarEstilo(Me)
            r.FormularioColor(Me)

            ConfigDetalles = Config.GetConfigDetails

            Me.dtpFecha.Value = VB.SysContab.Rutinas.Fecha
            Me.dtpFechaPago.Value = VB.SysContab.Rutinas.Fecha

            cbCliente.DataSource = Clientes.GetList().Tables("Clientes")
            cbCliente.ValueMember = "Codigo"
            cbCliente.DisplayMember = "Nombre"

            cbTipoFactura.DataSource = FormaPago.FormaPagoList().Tables("Forma_Pago")
            cbTipoFactura.ValueMember = "Codigo"
            cbTipoFactura.DisplayMember = "Nombre"

            r.ComboAutoComplete(Me.cbCliente)

            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction

            Try
                Articulos.ItemTemporalDelete("P" & PvCodigo)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                VB.SysContab.Rutinas.ErrorTransaccion()
            End Try

            VB.SysContab.Rutinas.okTransaccion()

            Servicio = False

            ds = Articulos.ProductosGetAll("P")

            MakeDataSet()
            dgFacturacionCliente.SetDataBinding(myDataSet, "Articulos")
            AddCustomDataTableStyle()

            'If Clientes.FacturaNumero.Tables("Facturas_Ventas").Rows.Count <> 0 Then
            '    txtFactura.Text = Format(Clientes.FacturaNumero.Tables("Facturas_Ventas").Rows(0).Item("Factura") + 1, "00000")
            'Else
            '    txtFactura.Text = "00001"
            'End If

            'txtFactura.Text = Format(Clientes.FacturaNumero, "00000")
            txtFactura.Text = Ordenes.Numero
            txtPuntoVenta.Text = PvCodigo & " - " & PvNombre

            LeaveCommit = False
            BuscarCombo = True

            TotalCheques = 0
            TotalTarjetas = 0
            TotalEfectivo = 0
            TotalNotaDebito = 0
            TotalFactura = 0
            TotalGlobal = 0

            etSaldo.Text = (0).ToString(Round)
            etSubTotal.Text = (0).ToString(Round)
            etIva.Text = (0).ToString(Round)
            etTotal.Text = (0).ToString(Round)

            If Clientes.GenerarRecibo.Tables("Cobros").Rows.Count = 0 Then
                Recibo = "00001"
            Else
                Recibo = Format(Clientes.GenerarRecibo.Tables("Cobros").Rows(0).Item("Recibo") + 1, "00000")
            End If

            TipoItem = "P"

            Indice = -1

            TipoDescuento = "P"

            r.ComboAutoComplete(Articulo.ColumnComboBox)
            r.ComboAutoComplete(ArticuloCodigo.ColumnComboBox)
            'SetTiempos(OrigenComprobantes.FACTURA, funciones.Tiempos.TiempoInicio, Now, funciones.Eventos.Inicia, Me.txtFactura.Text)
            Me.Text = "Facturación Punto de Venta"
            Me.Refresh()

        End Sub

        Private Sub MakeDataSet()

            ' Create a DataSet.
            myDataSet = New DataSet("myDataSet")

            ' Create two DataTables.
            'Dim tCust As DataTable
            tCust = New DataTable("Articulos")

            ' Create two columns, and add them to the first table.

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

            Dim cExento As DataColumn
            cExento = New DataColumn("Exento")

            tCust.Columns.Add(cArticuloCodigo)
            tCust.Columns.Add(cArticulo)
            tCust.Columns.Add(cCantidad)
            tCust.Columns.Add(cPrecio)
            tCust.Columns.Add(cDescuento)
            tCust.Columns.Add(cSubTotal)
            tCust.Columns.Add(cCodigoTemporal)
            tCust.Columns.Add(cItemTipo)
            tCust.Columns.Add(cExento)

            'tCust.Columns.Add(cCurrent2)
            ' Add the tables to the DataSet.
            myDataSet.Tables.Add(tCust)

            Dim newRow1 As DataRow

            Iva = 0
            SubTotal = 0

            If LoadOrdenProceso = True Then
                Dim j As Integer

                For j = 0 To ds.Tables("Ordenes_Proceso").Rows.Count - 1
                    newRow1 = tCust.NewRow
                    newRow1("ArticuloCodigo") = ds.Tables("Ordenes_Proceso").Rows(j).Item("Item")
                    ' Add the row to the Customers table.
                    tCust.Rows.Add(newRow1)

                    'tCust.Rows(i)("Cantidad") = ds.Tables("Recibo_Cheques").Rows(i).Item("Banco")
                    tCust.Rows(j)("CodigoTemporal") = ds.Tables("Ordenes_Proceso").Rows(j).Item("Item")
                    tCust.Rows(j)("Articulo") = ds.Tables("Ordenes_Proceso").Rows(j).Item("Descripcion")
                    tCust.Rows(j)("Cantidad") = ds.Tables("Ordenes_Proceso").Rows(j).Item("Cantidad")
                    tCust.Rows(j)("Precio") = CDbl(ds.Tables("Ordenes_Proceso").Rows(j).Item("Precio")).ToString(Round)
                    tCust.Rows(j)("Descuento") = CDbl(ds.Tables("Ordenes_Proceso").Rows(j).Item("Descuento")).ToString(Round)
                    tCust.Rows(j)("Tipo") = ds.Tables("Ordenes_Proceso").Rows(j).Item("Tipo_Item")
                    'Agregado x RMPR 27032007, ver _OrdenesProcesoDetalle en SQL
                    tCust.Rows(j)("Exento") = ds.Tables("Ordenes_Proceso").Rows(j).Item("Exento")

                    SubTotal = CDbl(CDbl(SubTotal) + CDbl(ds.Tables("Ordenes_Proceso").Rows(j).Item("Cantidad")) * CDbl(ds.Tables("Ordenes_Proceso").Rows(j).Item("Precio")) - ((CDbl(ds.Tables("Ordenes_Proceso").Rows(j).Item("Cantidad")) * CDbl(ds.Tables("Ordenes_Proceso").Rows(j).Item("Precio")) * (CDbl(ds.Tables("Ordenes_Proceso").Rows(j).Item("Descuento")) / 100.0)))).ToString(Round)
                    Iva = CDbl(Iva) + CDbl(ds.Tables("Ordenes_Proceso").Rows(j).Item("Iva"))
                Next

                etSubTotal.Text = CDbl(SubTotal).ToString(Round)
                etIva.Text = CDbl(Iva).ToString(Round)
                TotalFactura = CDbl(CDbl(etSubTotal.Text) + CDbl(etIva.Text)).ToString(Round)
                etTotal.Text = TotalFactura.ToString(Round)

            End If

        End Sub

        Private Sub TextBoxDescuentoLeaveHandler(ByVal sender As Object, ByVal e As EventArgs)
            If Not IsNumeric(Descuento.TextBox.Text) Then
                Descuento.TextBox.Text = ValorActualDescuento.ToString(Round)
            Else
                If CDbl(Descuento.TextBox.Text) < 0 Then
                    MsgBox("El Descuento debe ser mayor o igual a Cero (0)", MsgBoxStyle.Information)
                    Descuento.TextBox.Text = ValorActualDescuento.ToString(Round)
                    Exit Sub
                ElseIf CDbl(Descuento.TextBox.Text >= 100) Then
                    MsgBox("El Descuento debe ser menor que 100%", MsgBoxStyle.Information)
                    Descuento.TextBox.Text = ValorActualDescuento.ToString(Round)
                    Exit Sub
                Else
                    Descuento.TextBox.Text = CDbl(Descuento.TextBox.Text).ToString(Round)
                End If
            End If
        End Sub

        Private Sub TextBoxLeaveHandler(ByVal sender As Object, ByVal e As EventArgs)
            If Not IsNumeric(Cantidad.TextBox.Text) Then
                Cantidad.TextBox.Text = ValorActualCantidad '.ToString(Round)
            Else

                If CDbl(Cantidad.TextBox.Text) <= 0 Then
                    MsgBox("La cantidad debe ser mayor que Cero (0)", MsgBoxStyle.Information)
                    Cantidad.TextBox.Text = ValorActualCantidad '.ToString(Round)
                    Exit Sub
                End If

                If Articulos.ItemTemporalBuscar(tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo"), "P" & PvCodigo).Tables("Articulos").Rows.Count <> 0 Then
                    Exit Sub
                End If

            End If

            If dgFacturacionCliente.CurrentRowIndex >= tCust.Rows.Count Then
                Exit Sub
            End If

            If tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo").ToString = "" Or tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo") Is DBNull.Value Then
                Exit Sub
            End If

            If TipoItem = "S" Then
                Exit Sub
            ElseIf TipoItem = "A" Then
                If tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Tipo").ToString = "S" Then
                    Exit Sub
                End If
            End If

            DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo"), tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Tipo"))

            If DetallesProducto.Existencia Is Nothing Or DetallesProducto.Existencia Is DBNull.Value Then
                '
            ElseIf DetallesProducto.Existencia = 0 Then
                MsgBox("No hay existencias...", MsgBoxStyle.Critical)
                CantidadPerdida = Cantidad.TextBox.Text
                If VentaPerdidaNumero = 0 Then
                    VentaPerdidaNumero = Clientes.VentaPerdidaNumero
                End If
                If Clientes.VentasPerdidasBuscar(VentaPerdidaNumero, tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo"), "P" & PvCodigo).Tables("VentasPerdidas").Rows.Count = 0 Then
                    Clientes.VentasPerdidasAddItem(VentaPerdidaNumero, tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo"), "P" & PvCodigo, Me.cbCliente.SelectedValue, DetallesCliente.Vendedor, CantidadPerdida, tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Precio"), 1)
                End If
                'Cantidad.TextBox.Focus()
                Exit Sub
            ElseIf CDbl(Cantidad.TextBox.Text) > CDbl(DetallesProducto.Existencia) Then
                If VentaPerdidaNumero = 0 Then
                    VentaPerdidaNumero = Clientes.VentaPerdidaNumero
                End If

                If MsgBox("La existencia actual es de: " & DetallesProducto.Existencia & "." & Chr(13) & "Desea Adquirirlas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    CantidadPerdida = Cantidad.TextBox.Text
                    Cantidad.TextBox.Text = DetallesProducto.Existencia
                    CantidadPerdida = CantidadPerdida - Cantidad.TextBox.Text
                    If Clientes.VentasPerdidasBuscar(VentaPerdidaNumero, tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo"), "P" & PvCodigo).Tables("VentasPerdidas").Rows.Count = 0 Then
                        Clientes.VentasPerdidasAddItem(VentaPerdidaNumero, tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo"), "P" & PvCodigo, Me.cbCliente.SelectedValue, DetallesCliente.Vendedor, CantidadPerdida, tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Precio"), 2)
                    End If
                Else
                    CantidadPerdida = Cantidad.TextBox.Text
                    If Clientes.VentasPerdidasBuscar(VentaPerdidaNumero, tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo"), "P" & PvCodigo).Tables("VentasPerdidas").Rows.Count = 0 Then
                        Clientes.VentasPerdidasAddItem(VentaPerdidaNumero, tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo"), "P" & PvCodigo, Me.cbCliente.SelectedValue, DetallesCliente.Vendedor, CantidadPerdida, tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Precio"), 2)
                    End If
                    tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex).Delete()
                    'tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Cantidad") = tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Cantidad")
                    'tCust.Rows.RemoveAt(Me.dgFacturacionCliente.CurrentRowIndex)
                    'Me.dgFacturacionCliente.Item
                End If

                'MsgBox(CantidadPerdida)
                Exit Sub
            End If

        End Sub

        Dim Servicio As Boolean


        Private Sub Evento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
            If rbAmbos.Checked = False Then
                Exit Sub
            End If

            If e.KeyCode = Keys.F9 Then

                If Servicio = True Then
                    Exit Sub
                End If

                Servicio = True

                dsItems = Articulos.ProductosGetAll("S")

                ArticuloCodigo.ColumnComboBox.Items.Clear()
                Articulo.ColumnComboBox.Items.Clear()
                ItemTipo.ColumnComboBox.Items.Clear()

                For i = 0 To dsItems.Tables("Articulos").Rows.Count - 1
                    ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Codigo"))
                    Articulo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Nombre"))
                    ItemTipo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Tipo"))

                Next

            ElseIf e.KeyCode = Keys.F10 Then

                If Servicio = False Then
                    Exit Sub
                End If

                Servicio = False

                dsItems = Articulos.ProductosGetAll("P")

                ArticuloCodigo.ColumnComboBox.Items.Clear()
                Articulo.ColumnComboBox.Items.Clear()
                ItemTipo.ColumnComboBox.Items.Clear()

                For i = 0 To dsItems.Tables("Articulos").Rows.Count - 1
                    ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Codigo"))
                    Articulo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Nombre"))
                    ItemTipo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Tipo"))

                Next

            End If

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

            ArticuloCodigo = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))
            ArticuloCodigo.MappingName = "ArticuloCodigo"
            ArticuloCodigo.HeaderText = "Código"
            ArticuloCodigo.Width = 100

            AddHandler ArticuloCodigo.ColumnComboBox.KeyDown, AddressOf Evento_KeyPress

            ts1.GridColumnStyles.Add(ArticuloCodigo)
            ts1.PreferredRowHeight = (ArticuloCodigo.ColumnComboBox.Height + 3)

            ArticuloCodigo.NullText = ""
            colCount = (colCount + 1)

            Articulo = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))
            Articulo.MappingName = "Articulo"
            Articulo.HeaderText = "Descripción"
            Articulo.Width = 300

            AddHandler Articulo.ColumnComboBox.KeyDown, AddressOf Evento_KeyPress

            ts1.GridColumnStyles.Add(Articulo)
            ts1.PreferredRowHeight = (Articulo.ColumnComboBox.Height + 3)

            Articulo.NullText = ""
            colCount = (colCount + 1)


            Cantidad = New DataGridTextBoxColumn()
            Cantidad.MappingName = "Cantidad"
            'from dataset table
            Cantidad.HeaderText = "Cantidad"
            Cantidad.Width = 100
            Cantidad.Alignment = HorizontalAlignment.Right
            Cantidad.ReadOnly = False

            AddHandler Cantidad.TextBox.Leave, New EventHandler(AddressOf TextBoxLeaveHandler)

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

            Precio.NullText = "0.00"

            'Dim Descuento As DataGridTextBoxColumn
            Descuento = New DataGridTextBoxColumn()
            Descuento.MappingName = "Descuento"
            Descuento.HeaderText = "Descuento %"
            Descuento.Width = 100
            Descuento.Alignment = HorizontalAlignment.Right
            Descuento.ReadOnly = False
            Descuento.Format = "##,###0.00"

            AddHandler Descuento.TextBox.Leave, New EventHandler(AddressOf TextBoxDescuentoLeaveHandler)

            ts1.GridColumnStyles.Add(Descuento)
            colCount = (colCount + 1)

            Descuento.NullText = ""

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

            SubTotal.NullText = "0.00"

            Dim CodigoTemporal As DataGridTextBoxColumn
            CodigoTemporal = New DataGridTextBoxColumn()
            CodigoTemporal.MappingName = "CodigoTemporal"
            CodigoTemporal.HeaderText = "CodigoTemporal"
            CodigoTemporal.Width = 0
            CodigoTemporal.Alignment = HorizontalAlignment.Left
            CodigoTemporal.ReadOnly = True
            'CodigoTemporal.Format = "##,###0.00"
            ts1.GridColumnStyles.Add(CodigoTemporal)
            colCount = (colCount + 1)

            CodigoTemporal.NullText = ""


            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''Tipo = P: Producto S: Servicio'''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            ItemTipo = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))
            ItemTipo.MappingName = "Tipo"
            ItemTipo.HeaderText = "Tipo"
            ItemTipo.Width = 0
            ItemTipo.ReadOnly = True


            Dim Exento As DataGridTextBoxColumn
            Exento = New DataGridTextBoxColumn()
            Exento.MappingName = "Exento"
            Exento.HeaderText = ""
            Exento.Width = 0
            Exento.Alignment = HorizontalAlignment.Right
            Exento.ReadOnly = True
            Exento.Format = "##,###0.00"
            ts1.GridColumnStyles.Add(Exento)
            colCount = (colCount + 1)

            Exento.NullText = "0.00"

            ts1.GridColumnStyles.Add(ItemTipo)
            ts1.PreferredRowHeight = (ItemTipo.ColumnComboBox.Height + 3)

            ItemTipo.NullText = ""

            dsItems = Articulos.ProductosGetAll("P")

            If rbProductos.Checked = True Then
                For i = 0 To dsItems.Tables("Articulos").Rows.Count - 1
                    ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Codigo"))
                    Articulo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Nombre"))
                    ItemTipo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Tipo"))
                Next

            ElseIf rbServicios.Checked = True Then
            Else
            End If

            ItemTipo.ColumnComboBox.DropDownStyle = ComboBoxStyle.DropDown
            ItemTipo.ColumnComboBox.SelectedValue = -1

            ArticuloCodigo.ColumnComboBox.DropDownStyle = ComboBoxStyle.DropDown
            ArticuloCodigo.ColumnComboBox.SelectedValue = -1

            Articulo.ColumnComboBox.DropDownStyle = ComboBoxStyle.DropDown
            Articulo.ColumnComboBox.SelectedValue = -1

            colCount = (colCount + 1)


            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            'STEP 6: Add the tablestyle to your datagrids tablestlye collection
            ts1.GridLineColor = Color.FromArgb(70, 130, 180)
            ts1.AllowSorting = False
            ts1.HeaderFont = dgFacturacionCliente.HeaderFont
            ts1.HeaderBackColor = Color.LightSteelBlue  'Color.LightBlue

            dgFacturacionCliente.CaptionVisible = False

            dgFacturacionCliente.TableStyles.Clear()
            dgFacturacionCliente.TableStyles.Add(ts1)

        End Sub

        Public Sub MyComboValueChanged(ByVal rowChanging As Integer, ByVal newValue As Object)
            Console.WriteLine("index changed {0} {1}", rowChanging, newValue)

            If Indice = 0 Then

                Dim f As New frmAgregarArticuloQuick()
                f.WindowState = FormWindowState.Normal
                f.StartPosition = FormStartPosition.CenterScreen

                If Me.rbProductos.Checked = True Then
                    f.etTipo.Text = "P"
                ElseIf Me.rbServicios.Checked = True Then
                    f.etTipo.Text = "S"
                ElseIf Me.rbAmbos.Checked = True Then
                    If Servicio = True Then
                        f.etTipo.Text = "S"
                    Else
                        f.etTipo.Text = "P"
                    End If
                End If

                f.ShowDialog()

                dsItems = Articulos.ProductosGetAll(TipoItem)

                ArticuloCodigo.ColumnComboBox.Items.Clear()
                Articulo.ColumnComboBox.Items.Clear()
                ItemTipo.ColumnComboBox.Items.Clear()

                For i = 0 To dsItems.Tables("Articulos").Rows.Count - 1
                    ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Codigo"))
                    Articulo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Nombre"))
                    ItemTipo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Tipo"))

                    If ArticuloCodigo.ColumnComboBox.Items.Item(i) = Me.Codigo Then
                        Indice = i
                    End If
                Next

                ArticuloCodigo.ColumnComboBox.Visible = False
                Articulo.ColumnComboBox.Visible = False
            End If

            Try
                If Indice >= 0 Then
                    DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(ArticuloCodigo.ColumnComboBox.Items.Item(Indice).ToString, ItemTipo.ColumnComboBox.Items.Item(Indice).ToString)

                    If tCust.Rows.Count < rowChanging + 1 Then
                        Dim newRow1 As DataRow
                        newRow1 = tCust.NewRow
                        'newRow1("CodigoTemporal") = ArticuloCodigo.ColumnComboBox.Items.Item(Articulo.ColumnComboBox.SelectedIndex)
                        newRow1("CodigoTemporal") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
                        ' Add the row to the Customers table.
                        tCust.Rows.Add(newRow1)
                        tCust.Rows(rowChanging)("Tipo") = ItemTipo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Exento") = DetallesProducto.Exento

                        'tCust.Rows(rowChanging)("Codigo") = ArticuloCodigo.ColumnComboBox.Items.Item(Articulo.ColumnComboBox.SelectedIndex)
                        tCust.Rows(rowChanging)("ArticuloCodigo") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Articulo") = Articulo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Cantidad") = 1
                        tCust.Rows(rowChanging)("Precio") = CDbl(DetallesProducto.Precio_Venta_Cordobas).ToString(Round)

                        If TipoDescuento = "A" Then
                            tCust.Rows(rowChanging)("Descuento") = CDbl(DetallesProducto.Descuento_A).ToString(Round)
                        ElseIf TipoDescuento = "B" Then
                            tCust.Rows(rowChanging)("Descuento") = CDbl(DetallesProducto.Descuento_B).ToString(Round)
                        ElseIf TipoDescuento = "C" Then
                            tCust.Rows(rowChanging)("Descuento") = CDbl(DetallesProducto.Descuento_C).ToString(Round)
                        Else
                            tCust.Rows(rowChanging)("Descuento") = "0.00"

                        End If

                    Else
                        'tCust.Rows(rowChanging)("Codigo") = ArticuloCodigo.ColumnComboBox.Items.Item(Articulo.ColumnComboBox.SelectedIndex)
                        tCust.Rows(rowChanging)("CodigoTemporal") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Tipo") = ItemTipo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Exento") = DetallesProducto.Exento
                        tCust.Rows(rowChanging)("ArticuloCodigo") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Articulo") = Articulo.ColumnComboBox.Items.Item(Indice)
                        'tCust.Rows(rowChanging)("Cantidad") = 1
                        tCust.Rows(rowChanging)("Precio") = CDbl(DetallesProducto.Precio_Venta_Cordobas).ToString(Round)

                        If TipoDescuento = "A" Then
                            tCust.Rows(rowChanging)("Descuento") = CDbl(DetallesProducto.Descuento_A).ToString(Round)
                        ElseIf TipoDescuento = "B" Then
                            tCust.Rows(rowChanging)("Descuento") = CDbl(DetallesProducto.Descuento_B).ToString(Round)
                        ElseIf TipoDescuento = "C" Then
                            tCust.Rows(rowChanging)("Descuento") = CDbl(DetallesProducto.Descuento_C).ToString(Round)
                        Else
                            tCust.Rows(rowChanging)("Descuento") = "0.00"

                        End If

                    End If

                End If
            Catch ex As Exception
                MsgBox(ex.Message & "MyComboValueChanged")
            End Try

        End Sub

        Private Sub tCust_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles tCust.ColumnChanged

            Dim Descuento As Double
            If e.Column.Ordinal = 2 Or e.Column.Ordinal = 3 Or e.Column.Ordinal = 4 Then

                If Not IsNumeric(e.Row.Item(2)) Then
                    e.Row.Item(2) = ValorActualCantidad
                End If

                If Not IsNumeric(e.Row.Item(3)) Then
                    e.Row.Item(3) = ValorActualPrecio.ToString(Round)
                End If

                If Not IsNumeric(e.Row.Item(4)) Then
                    e.Row.Item(4) = ValorActualDescuento.ToString(Round)
                End If


                If e.Row.Item(2) Is DBNull.Value Or e.Row.Item(3) Is DBNull.Value Then

                Else
                    If e.Row.Item(4) Is DBNull.Value Then
                        If IsNumeric(e.Row.Item(2)) And IsNumeric(e.Row.Item(3)) Then
                            e.Row.Item(5) = CDbl(CDbl(e.Row.Item(2)) * CDbl(e.Row.Item(3))).ToString(Round)
                        End If

                    Else
                        If IsNumeric(e.Row.Item(2)) And IsNumeric(e.Row.Item(3)) And IsNumeric(e.Row.Item(4)) Then
                            Descuento = (CDbl(e.Row.Item(4)) * CDbl(e.Row.Item(2)) * CDbl(e.Row.Item(3))) / 100.0
                            'e.Row.Item(5) = CDbl(CDbl(e.Row.Item(2)) * CDbl(e.Row.Item(3)) - CDbl(e.Row.Item(4))).ToString(Round)
                            e.Row.Item(5) = CDbl(CDbl(e.Row.Item(2)) * CDbl(e.Row.Item(3)) - Descuento).ToString(Round)
                        End If


                    End If

                End If


                Dim TotalIva As Double
                SubTotalFacturaCliente = 0
                SubTotalFacturaNoDescuentos = 0
                TotalFacturaCliente = 0
                TotalDescuento = 0
                TotalIva = 0

                For i = 0 To tCust.Rows.Count - 1

                    If tCust.Rows(i)("SubTotal") Is DBNull.Value Or tCust.Rows(i)("SubTotal").ToString = "" Or tCust.Rows(i)("SubTotal").ToString = "0.00" Or tCust.Rows(i)("Exento") Is DBNull.Value Or tCust.Rows(i)("Tipo") Is DBNull.Value Then

                    ElseIf IsNumeric(tCust.Rows(i)("SubTotal")) And tCust.Rows(i)("SubTotal").ToString <> "" Then
                        Try
                            SubTotalFacturaCliente = SubTotalFacturaCliente + tCust.Rows(i)("SubTotal")
                            SubTotalFacturaNoDescuentos = SubTotalFacturaNoDescuentos + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio"))
                            TotalDescuento = TotalDescuento + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio") * tCust.Rows(i)("Descuento") / 100.0)

                            If DetallesCliente.Excento = True Then
                                TotalIva = 0
                            Else
                                If tCust.Rows(i)("Exento") = False Then
                                    TotalIva = TotalIva + (tCust.Rows(i)("SubTotal") * (ConfigDetalles.IVA / 100.0))
                                End If
                            End If

                        Catch ex As Exception
                            MsgBox(ex.Message)

                        End Try

                    End If

                Next

                etSubTotal.Text = SubTotalFacturaCliente.ToString(Round)
                etIva.Text = TotalIva.ToString(Round) '(SubTotalFacturaCliente * 0.15).ToString(Round)
                etTotal.Text = (SubTotalFacturaCliente + CDbl(etIva.Text)).ToString(Round)

                etSaldo.Text = (CDbl(etTotal.Text) - TotalGlobal).ToString(Round)

                TotalFactura = etTotal.Text
            End If
        End Sub

        Private Sub cbCliente_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCliente.SelectedIndexChanged

            'If Not IsNumeric(cbCliente.SelectedValue) Then
            '    Exit Sub

            'End If

            'If cbCliente.SelectedValue = 0 Or Trim(cbCliente.Text) = "" Then
            '    txtRuc.Text = ""
            '    txtDireccion.Text = ""
            '    txtTelefono.Text = ""
            '    txtDepartamento.Text = ""
            '    txtMunicipio.Text = ""
            '    txtDescuentoProducto.Text = ""
            '    txtDescuentoServicio.Text = ""
            '    txtVendedor.Text = ""
            '    Exit Sub
            'End If

            'DetallesCliente = VB.SysContab.ClientesDB.GetDetails(cbCliente.SelectedValue)

            'cbDepartamentos.DataSource = Departamentos.GetList().Tables("DepartamentosC")
            'cbDepartamentos.ValueMember = "Codigo"
            'cbDepartamentos.DisplayMember = "Nombre"

            'cbDepartamentos.SelectedValue = DetallesCliente.Departamento

            'cbMunicipios.DataSource = Municipios.GetList(cbDepartamentos.SelectedValue).Tables("Municipios")
            'cbMunicipios.ValueMember = "Codigo"
            'cbMunicipios.DisplayMember = "Nombre"

            'cbMunicipios.SelectedValue = DetallesCliente.Municipio

            'txtRuc.Text = DetallesCliente.Ruc
            'txtDireccion.Text = DetallesCliente.Direccion
            'txtTelefono.Text = DetallesCliente.Telefono

            'If DetallesCliente.Departamento = "0" Then
            '    txtDepartamento.Text = ""
            '    txtMunicipio.Text = ""
            'Else
            '    txtDepartamento.Text = cbDepartamentos.Text
            '    txtMunicipio.Text = cbMunicipios.Text
            'End If

            'txtDescuentoProducto.Text = DetallesCliente.Desc_Prod
            'txtDescuentoServicio.Text = DetallesCliente.Desc_Serv

            'TipoDescuento = DetallesCliente.Desc_Prod

            'DetallesVendedor = Vendedor.GetDetails(DetallesCliente.Vendedor)
            'txtVendedor.Text = DetallesVendedor.Nombre

            'Dim c As Integer
            'For c = 0 To tCust.Rows.Count - 1
            '    If TipoDescuento = "A" Then
            '        tCust.Rows(c)("Descuento") = CDbl(DetallesProducto.Descuento_A).ToString(Round)
            '    ElseIf TipoDescuento = "B" Then
            '        tCust.Rows(c)("Descuento") = CDbl(DetallesProducto.Descuento_B).ToString(Round)
            '    ElseIf TipoDescuento = "C" Then
            '        tCust.Rows(c)("Descuento") = CDbl(DetallesProducto.Descuento_C).ToString(Round)
            '    Else
            '        tCust.Rows(c)("Descuento") = "0.00"
            '    End If

            'Next

        End Sub

        Private Sub cbCliente_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCliente.Leave

            If Trim(cbCliente.Text) = "" Then
                txtRuc.Text = ""
                txtDireccion.Text = ""
                txtTelefono.Text = ""
                txtDepartamento.Text = ""
                txtMunicipio.Text = ""
                txtDescuentoProducto.Text = ""
                txtDescuentoServicio.Text = ""
                txtVendedor.Text = ""
                Cliente = ""
                Exit Sub
            End If

            If Clientes.ClientesBuscar(Trim(cbCliente.Text)).Tables("Clientes").Rows.Count = 0 Then
                cbCliente.Text = cbCliente.Text.ToUpper

                txtRuc.Text = ""
                txtDireccion.Text = ""
                txtTelefono.Text = ""
                txtDepartamento.Text = ""
                txtMunicipio.Text = ""
                txtDescuentoProducto.Text = ""
                txtDescuentoServicio.Text = ""
                txtVendedor.Text = ""
                Cliente = ""
                'Exit Sub

                If (MsgBox("Cliente no existe. Desea agregarlo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)) = MsgBoxResult.No Then
                    Cliente = cbCliente.Text.ToUpper
                    Cod_Cliente = "9999" 'Clientes Varios
                    DetallesCliente = VB.SysContab.ClientesDB.GetDetails(Cod_Cliente)
                    DetallesVendedor = Vendedor.GetDetails(DetallesCliente.Vendedor)
                Else
                    Dim f As New frmAgregarClienteQuick()
                    f.WindowState = FormWindowState.Normal
                    f.StartPosition = FormStartPosition.CenterScreen
                    NombreCliente = cbCliente.Text.ToUpper
                    f.ShowDialog()

                    cbCliente.DataSource = Clientes.GetList().Tables("Clientes")
                    cbCliente.ValueMember = "Codigo"
                    cbCliente.DisplayMember = "Nombre"

                    cbCliente.SelectedValue = f.txtCodigo.Text

                End If

                'Cliente = ""
                'Cod_Cliente = "9999" 'Clientes Varios
                Exit Sub

            End If

            '''''cbCliente.Refresh()
            '''''Cod_Cliente = Clientes.ClientesBuscar(Trim(cbCliente.Text)).Tables("Clientes").Rows(0).Item("Codigo")

            '''''cbCliente.SelectedValue = Cod_Cliente
            Cod_Cliente = cbCliente.SelectedValue

            Cliente = ""

        End Sub

        Private Sub rbProductos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbProductos.Click
            dsItems = Articulos.ProductosGetAll("P")

            ArticuloCodigo.ColumnComboBox.Items.Clear()
            Articulo.ColumnComboBox.Items.Clear()
            ItemTipo.ColumnComboBox.Items.Clear()

            For i = 0 To dsItems.Tables("Articulos").Rows.Count - 1
                ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Codigo"))
                Articulo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Nombre"))
                ItemTipo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Tipo"))

            Next

            TipoItem = "P"

        End Sub

        Private Sub rbServicios_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbServicios.Click

            dsItems = Articulos.ProductosGetAll("S")

            ArticuloCodigo.ColumnComboBox.Items.Clear()
            Articulo.ColumnComboBox.Items.Clear()
            ItemTipo.ColumnComboBox.Items.Clear()

            For i = 0 To dsItems.Tables("Articulos").Rows.Count - 1
                ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Codigo"))
                Articulo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Nombre"))
                ItemTipo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Tipo"))

            Next

            TipoItem = "S"

        End Sub

        Private Sub rbAmbos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbAmbos.Click

            dsItems = Articulos.ProductosGetAll("P")

            ArticuloCodigo.ColumnComboBox.Items.Clear()
            Articulo.ColumnComboBox.Items.Clear()
            ItemTipo.ColumnComboBox.Items.Clear()

            For i = 0 To dsItems.Tables("Articulos").Rows.Count - 1
                ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Codigo"))
                Articulo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Nombre"))
                ItemTipo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Tipo"))
            Next

            TipoItem = "A"

        End Sub



        Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
            ''Try
            ''    'Guardar los datos de la Factura
            ''    If GuardarTemporal() = False Then
            ''        Exit Sub
            ''    End If
            ''    LimpiarControles()
            ''    VB.SysContab.Rutinas.okTransaccion()
            ''Catch ex As Exception
            ''    VB.SysContab.Rutinas.ErrorTransaccion()
            ''    MsgBox(ex.Message & "Guardar Factura Temporal")
            ''    Exit Sub
            ''End Try
            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction
            Try
                'Guardar los datos de la Factura

                If GuardarTemporal() = False Then
                    ' SetTiempos(OrigenComprobantes.FACTURA, funciones.Tiempos.TiempoFin, Now, funciones.Eventos.Error1, Me.txtFactura.Text)
                    VB.SysContab.Rutinas.ErrorTransaccion()
                    Exit Sub
                End If
                'Guardar los pagos efectuados a la factura
                'GuardarPagos()
                LimpiarControles()
                VB.SysContab.Rutinas.okTransaccion()
                ' SetTiempos(OrigenComprobantes.FACTURA, funciones.Tiempos.TiempoFin, Now, funciones.Eventos.Guarda, Me.txtFactura.Text)
                LoadOrdenProceso = False
                RestablecerDataset()

            Catch ex As Exception
                VB.SysContab.Rutinas.ErrorTransaccion()
                ' SetTiempos(OrigenComprobantes.FACTURA, funciones.Tiempos.TiempoFin, Now, funciones.Eventos.Error1, Me.txtFactura.Text)
                MsgBox(ex.Message & "Aceptar")
                ''transaccionFacturas.Rollback()
                ''DBConnFacturas.Close()
                Exit Sub
            End Try
        End Sub

        Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
            Me.Close()
        End Sub

        Private Sub dgFacturacionCliente_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFacturacionCliente.CurrentCellChanged
            Try
                ValorActualCantidad = tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Cantidad")
                ValorActualPrecio = tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Precio")
                ValorActualDescuento = tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Descuento")

                If Servicio = False Or rbAmbos.Checked = False Then
                    Exit Sub
                End If

                dsItems = Articulos.ProductosGetAll("P")

                ArticuloCodigo.ColumnComboBox.Items.Clear()
                Articulo.ColumnComboBox.Items.Clear()
                ItemTipo.ColumnComboBox.Items.Clear()

                For i = 0 To dsItems.Tables("Articulos").Rows.Count - 1
                    ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Codigo"))
                    Articulo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Nombre"))
                    ItemTipo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Tipo"))

                Next

                Servicio = False

            Catch ex As Exception
                Exit Sub
            End Try
        End Sub

        Private Sub tCust_RowDeleted(ByVal sender As Object, ByVal e As System.Data.DataRowChangeEventArgs) Handles tCust.RowDeleted
            SubTotalFacturaCliente = 0
            SubTotalFacturaNoDescuentos = 0
            TotalFacturaCliente = 0
            TotalDescuento = 0

            Dim TotalIva As Double
            TotalIva = 0

            For i = 0 To tCust.Rows.Count - 1
                If tCust.Rows(i)("SubTotal") Is DBNull.Value Or tCust.Rows(i)("SubTotal").ToString = "" Or tCust.Rows(i)("SubTotal").ToString = "0.00" Or tCust.Rows(i)("Exento") Is DBNull.Value Or tCust.Rows(i)("Tipo") Is DBNull.Value Then

                ElseIf IsNumeric(tCust.Rows(i)("SubTotal")) And tCust.Rows(i)("SubTotal").ToString <> "" Then
                    Try 'MsgBox(tCust.Rows(i)("SubTotal").ToString)
                        SubTotalFacturaCliente = SubTotalFacturaCliente + tCust.Rows(i)("SubTotal")
                        SubTotalFacturaNoDescuentos = SubTotalFacturaNoDescuentos + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio"))
                        TotalDescuento = TotalDescuento + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio") * tCust.Rows(i)("Descuento") / 100.0)

                        If DetallesCliente.Excento = True Then
                            TotalIva = 0
                        Else
                            If tCust.Rows(i)("Exento") = False Then
                                TotalIva = TotalIva + (tCust.Rows(i)("SubTotal") * (ConfigDetalles.IVA / 100.0))
                            End If
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'e.Row.Delete()
                    End Try

                End If

            Next

            etSubTotal.Text = SubTotalFacturaCliente.ToString(Round)
            'etIva.Text = (SubTotalFacturaCliente * 0.15).ToString(Round)
            etIva.Text = TotalIva.ToString(Round)
            etTotal.Text = (SubTotalFacturaCliente + CDbl(etIva.Text)).ToString(Round)

            etSaldo.Text = (CDbl(etTotal.Text) - TotalGlobal).ToString(Round)

            TotalFactura = CDbl(etTotal.Text).ToString(Round)

        End Sub

        Private Sub cmdConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsulta.Click
            Dim f As frmBuscarItem = f.Instance

            If tCust.Rows.Count > 0 Then
                If tCust.Rows(tCust.Rows.Count - 1)("ArticuloCodigo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Articulo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Precio") Is DBNull.Value Then
                    tCust.Rows(tCust.Rows.Count - 1).Delete()
                End If
            End If

            f.MdiParent = Me.MdiParent
            f.Show()
        End Sub

        Private Sub frmFacturasPuntosVenta_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
            'If MsgBox("Desea salir de Facturación? ...", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            '    e.Cancel = True
            '    Exit Sub
            'End If

            Dim Estado As String = ""
            Dim ds As DataSet
            Dim Tabla As New DataTable()
            Dim f As frmListaOrdenes = frmListaOrdenes.Instance
            If f.rbFacturadas.Checked = True Then
                Estado = "F"
            ElseIf f.rbPendientes.Checked = True Then
                Estado = "P"
            ElseIf f.rbTodas.Checked = True Then
                Estado = "T"
            End If

            ds = Ordenes.ListOrdenes("", Estado)
            f.Cargar()


            'f.dgFacturas.DataSource = ds.Tables("Ordenes").DefaultView

            'Tabla = ds.Tables("Ordenes")

            'r.FormatGenerico(f.dgFacturas, Tabla)

            'If ds.Tables("Ordenes").Rows.Count <> 0 Then
            '    Registro = f.dgFacturas.Item(0, 0).ToString
            'Else
            '    Registro = "Vacio"
            'End If
            'SetTiempos(OrigenComprobantes.FACTURA, funciones.Tiempos.TiempoFin, Now, funciones.Eventos.Salir, Me.txtFactura.Text)
        End Sub

        Private Sub frmFacturasPuntosVenta_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter

        End Sub

        Private Sub dgFacturacionCliente_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFacturacionCliente.MouseEnter

            etSaldo.Text = (TotalFactura - TotalGlobal).ToString(Round)
            AgregarItem()
        End Sub

        Private Function GuardarTemporal() As Boolean
            If Trim(cbCliente.Text) = "" Then
                MsgBox("Seleccione el Cliente", MsgBoxStyle.Critical)
                cbCliente.Focus()
                Return False
                Exit Function
            End If

            If Trim(txtFactura.Text) = "" Then
                MsgBox("Introduzca el No. de Factura", MsgBoxStyle.Critical)
                txtFactura.Focus()
                Return False
                Exit Function
            End If

            If cbTipoFactura.SelectedValue = 0 Then
                MsgBox("Seleccione el Tipo de Pago", MsgBoxStyle.Information)
                cbTipoFactura.Focus()
                Return False
                Exit Function
            End If

            If tCust.Rows.Count = 0 Then
                MsgBox("Seleccione al menos un Producto o Servicio", MsgBoxStyle.Critical)
                dgFacturacionCliente.Focus()
                Articulo.ColumnComboBox.Focus()
                Return False
                Exit Function
            End If

            '
            If tCust.Rows.Count > 0 Then
                If tCust.Rows(tCust.Rows.Count - 1)("ArticuloCodigo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Articulo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Precio") Is DBNull.Value Then
                    tCust.Rows(tCust.Rows.Count - 1).Delete()
                End If
            End If
            '
            For i = 0 To tCust.Rows.Count - 1
                If tCust.Rows(i)("Articulo").ToString = "" Or tCust.Rows(i)("Articulo") Is DBNull.Value Or tCust.Rows(i)("ArticuloCodigo").ToString = "" Or tCust.Rows(i)("ArticuloCodigo") Is DBNull.Value Then
                    MsgBox("Elija el Producto o Servicio", MsgBoxStyle.Critical)
                    dgFacturacionCliente.Select(i)
                    Return False
                    Exit Function
                End If

            Next

            For i = 0 To tCust.Rows.Count - 1
                If tCust.Rows(i)("Articulo").ToString = "" Or tCust.Rows(i)("Articulo") Is DBNull.Value Or tCust.Rows(i)("ArticuloCodigo").ToString = "" Or tCust.Rows(i)("ArticuloCodigo") Is DBNull.Value Then
                    If tCust.Rows(i)("Tipo") = "P" Then
                        MsgBox("Elija el Producto", MsgBoxStyle.Critical)
                    ElseIf tCust.Rows(i)("Tipo") = "S" Then
                        MsgBox("Elija el Servicio", MsgBoxStyle.Critical)
                    Else
                        MsgBox("Elija el Producto o Servicio", MsgBoxStyle.Critical)
                    End If

                    dgFacturacionCliente.Select(i)
                    Return False
                    Exit Function
                End If

                If tCust.Rows(i)("Tipo") = "P" Then
                    If Articulos.ItemTemporalBuscar(tCust.Rows(i)("ArticuloCodigo"), "P" & PvCodigo).Tables("Articulos").Rows.Count <> 0 Then
                        'No verifica existencias por que es Nuevo
                    Else
                        DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(tCust.Rows(i)("ArticuloCodigo"), tCust.Rows(i)("Tipo"))
                        If DetallesProducto.Existencia Is Nothing Or DetallesProducto.Existencia Is DBNull.Value Then
                            '
                        ElseIf DetallesProducto.Existencia = 0 Then
                            MsgBox("No hay existencias Para el Producto: " & tCust.Rows(i)("ArticuloCodigo") & " - " & tCust.Rows(i)("Articulo"), MsgBoxStyle.Critical)
                            dgFacturacionCliente.Select(i)

                            CantidadPerdida = tCust.Rows(i)("Cantidad")
                            If VentaPerdidaNumero = 0 Then
                                VentaPerdidaNumero = Clientes.VentaPerdidaNumero
                            End If

                            If Clientes.VentasPerdidasBuscar(VentaPerdidaNumero, tCust.Rows(i)("ArticuloCodigo"), "P" & PvCodigo).Tables("VentasPerdidas").Rows.Count = 0 Then
                                Clientes.VentasPerdidasAddItem(VentaPerdidaNumero, tCust.Rows(i)("ArticuloCodigo"), "P" & PvCodigo, Me.cbCliente.SelectedValue, DetallesCliente.Vendedor, CantidadPerdida, tCust.Rows(i)("Precio"), 1)
                            End If

                            Exit Function
                        ElseIf CDbl(tCust.Rows(i)("Cantidad")) > CDbl(DetallesProducto.Existencia) Then
                            'MsgBox("La cantidad del producto: " & tCust.Rows(i)("ArticuloCodigo") & " - " & tCust.Rows(i)("Articulo") & " es mayor que la existencia actual.", MsgBoxStyle.Critical)
                            'dgFacturacionCliente.Select(i)

                            If VentaPerdidaNumero = 0 Then
                                VentaPerdidaNumero = Clientes.VentaPerdidaNumero
                            End If

                            If MsgBox("La existencia actual es de: " & DetallesProducto.Existencia & "." & Chr(13) & "Desea Adquirirlas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                CantidadPerdida = tCust.Rows(i)("Cantidad")
                                tCust.Rows(i)("Cantidad") = DetallesProducto.Existencia
                                CantidadPerdida = CantidadPerdida - tCust.Rows(i)("Cantidad")
                                If Clientes.VentasPerdidasBuscar(VentaPerdidaNumero, tCust.Rows(i)("ArticuloCodigo"), "P" & PvCodigo).Tables("VentasPerdidas").Rows.Count = 0 Then
                                    Clientes.VentasPerdidasAddItem(VentaPerdidaNumero, tCust.Rows(i)("ArticuloCodigo"), "P" & PvCodigo, Me.cbCliente.SelectedValue, DetallesCliente.Vendedor, CantidadPerdida, tCust.Rows(i)("Precio"), 2)
                                End If
                            Else
                                CantidadPerdida = Cantidad.TextBox.Text
                                If Clientes.VentasPerdidasBuscar(VentaPerdidaNumero, tCust.Rows(i)("ArticuloCodigo"), "P" & PvCodigo).Tables("VentasPerdidas").Rows.Count = 0 Then
                                    Clientes.VentasPerdidasAddItem(VentaPerdidaNumero, tCust.Rows(i)("ArticuloCodigo"), "P" & PvCodigo, Me.cbCliente.SelectedValue, DetallesCliente.Vendedor, CantidadPerdida, tCust.Rows(i)("Precio"), 2)
                                End If
                                tCust.Rows(i).Delete()
                            End If

                            Exit Function
                        End If

                    End If
                End If

            Next

            If CDbl(TotalGlobal.ToString(Round)) > CDbl(TotalFactura.ToString(Round)) Then
                MsgBox("El monto es mayor que el saldo de la factura", MsgBoxStyle.Information)
                Return False
                Exit Function
            End If

            'If MsgBox("Desea guardar los datos?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            '    Return False
            '    Exit Function
            'End If

            'DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            'DBConnFacturas.Open()
            'transaccionFacturas = DBConnFacturas.BeginTransaction

            'If Clientes.FacturaNumero.Tables("Facturas_Ventas").Rows.Count <> 0 Then
            '    txtFactura.Text = Format(Clientes.FacturaNumero.Tables("Facturas_Ventas").Rows(0).Item("Factura") + 1, "00000")
            'Else
            '    txtFactura.Text = "00001"
            'End If

            'txtFactura.Text = Format(Clientes.FacturaNumero, "00000")
            txtFactura.Text = Ordenes.Numero

            Dim Tipo As String
            If rbProductos.Checked = True Then
                Tipo = 0
            ElseIf rbServicios.Checked = True Then
                Tipo = 1
            Else
                Tipo = 2
            End If

            Dim Factura As String

            Factura = Ordenes.Numero

            'Dim OrdenCompra As String
            'Dim Proveedor As String
            'Dim NumeroTemporal As String

            Try
                Ordenes.AddOrden(Factura, dtpFecha.Value, Cod_Cliente, txtRuc.Text, etSubTotal.Text, _
                                 etTotal.Text, TotalDescuento, etIva.Text, "0", "0", etTotal.Text, TotalFactura - TotalGlobal, DetallesCliente.Vendedor, _
                                 dtpFechaPago.Value, dtpFechaPago.Value, Tipo, cbTipoFactura.SelectedValue, PvCodigo, Cliente, 0, 0, 0)

                Dim Descuento As Double
                Dim Iva As Double
                Dim Comision As Double
                Dim Comisiones As New VB.SysContab.ComisionDB()

                'Dim P As Integer
                'Dim Item As Integer
                'Dim q As Integer

                Dim dsComision As DataSet

                Dim Nuevo As Integer

                For i = 0 To tCust.Rows.Count - 1
                    If tCust.Rows(i)("Descuento") Is DBNull.Value Then
                        Descuento = 0
                    Else
                        Descuento = tCust.Rows(i)("Descuento")
                    End If

                    'If Comisiones.GetComisionItemVendedor(DetallesCliente.Vendedor, tCust.Rows(i)("CodigoTemporal"), "P").Tables("Comisiones").Rows.Count <> 0 Then
                    '    Comision = Comisiones.GetComisionItemVendedor(DetallesCliente.Vendedor, tCust.Rows(i)("CodigoTemporal"), "P").Tables("Comisiones").Rows(0).Item("Comision")
                    'Else
                    '    Comision = 0
                    'End If

                    dsComision = Comisiones.GetComisionItemVendedor(DetallesCliente.Vendedor, tCust.Rows(i)("CodigoTemporal"), tCust.Rows(i)("Tipo"))

                    If dsComision.Tables("Comisiones").Rows.Count <> 0 Then
                        Comision = dsComision.Tables("Comisiones").Rows(0).Item("Comision")
                    Else
                        DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(tCust.Rows(i)("CodigoTemporal"), tCust.Rows(i)("Tipo"))
                        dsComision = Comisiones.GetComisionLineaVendedor(DetallesCliente.Vendedor, DetallesProducto.Linea, tCust.Rows(i)("Tipo"))
                        If dsComision.Tables("Comisiones").Rows.Count <> 0 Then
                            Comision = dsComision.Tables("Comisiones").Rows(0).Item("Comision")
                        Else
                            If tCust.Rows(i)("Tipo") = "P" Then
                                Comision = DetallesVendedor.Comision
                            Else
                                Comision = DetallesVendedor.Comision_Servicio
                            End If
                            'DetallesVendedor.Comision()
                            'Comision = 0
                        End If
                    End If

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    '''''If i = 0 Then
                    '''''    dsProveedoresTemporales = Articulos.ItemTemporalProveedores(1)
                    '''''    For P = 0 To dsProveedoresTemporales.Tables("Articulos").Rows.Count - 1
                    '''''        OrdenCompra = Ordenes_Compras.Numero
                    '''''        NumeroTemporal = FacturasCompras.NumeroTemporal
                    '''''        'Ordenes_Compras.AddItem(OrdenCompra, r.Fecha, r.Fecha, dsProveedoresTemporales.Tables("Articulos").Rows(P).Item("Proveedor"), 0, 0, 0, Me.cbTipoFactura.SelectedValue, 0, 2, OrdenCompra)
                    '''''        Ordenes_Compras.AddItem("PT-" & NumeroTemporal, r.Fecha, r.Fecha, dsProveedoresTemporales.Tables("Articulos").Rows(P).Item("Proveedor"), 0, 0, 0, Me.cbTipoFactura.SelectedValue, 0, 2, OrdenCompra, NumeroTemporal)
                    '''''        FacturasCompras.AddItem("PT-" & NumeroTemporal, r.Fecha, r.Fecha, dsProveedoresTemporales.Tables("Articulos").Rows(P).Item("Proveedor"), 0, Me.cbTipoFactura.SelectedValue, 0, 1, 0, "PT-" & NumeroTemporal, 2, NumeroTemporal)
                    '''''        FacturasCompras.UpdateEstado("PT-" & NumeroTemporal, "F", r.Fecha)
                    '''''        FacturasCompras.UpdateFechaAlmacen("PT-" & NumeroTemporal, r.Fecha)
                    '''''        dsItemTemporales = Articulos.ItemTemporalXProveedores(dsProveedoresTemporales.Tables("Articulos").Rows(P).Item("Proveedor"), 1)
                    '''''        For Item = 0 To dsItemTemporales.Tables("Articulos").Rows.Count - 1
                    '''''            If Articulos.ItemTemporalBuscar(tCust.Rows(Item)("ArticuloCodigo"), 1).Tables("Articulos").Rows.Count <> 0 Then
                    '''''                For q = 0 To tCust.Rows.Count - 1
                    '''''                    If dsItemTemporales.Tables("Articulos").Rows(Item).Item("Item_ID") = tCust.Rows(q)("CodigoTemporal") Then
                    '''''                        If tCust.Rows(q)("Descuento") Is DBNull.Value Then
                    '''''                            Descuento = 0
                    '''''                        Else
                    '''''                            Descuento = tCust.Rows(q)("Descuento")
                    '''''                        End If

                    '''''                        'Agrega item a la Orden de Compra
                    '''''                        Ordenes_Compras.AddFacturaLineas("PT-" & NumeroTemporal, tCust.Rows(q)("CodigoTemporal"), tCust.Rows(q)("Cantidad"), tCust.Rows(q)("Costo"), Descuento, (CDbl(tCust.Rows(q)("Cantidad")) * CDbl(tCust.Rows(q)("Costo")) - ((CDbl(tCust.Rows(q)("Cantidad")) * CDbl(tCust.Rows(q)("Costo")) * (Descuento / 100.0)))) * ConfigDetalles.IVA / 100.0, tCust.Rows(q)("Tipo"))

                    '''''                        'Agrega item a la Entrada a Alamcen
                    '''''                        FacturasCompras.AddFacturaLineas("PT-" & NumeroTemporal, tCust.Rows(q)("CodigoTemporal"), tCust.Rows(q)("Cantidad"), tCust.Rows(q)("Costo"), Descuento, (CDbl(tCust.Rows(q)("Cantidad")) * CDbl(tCust.Rows(q)("Costo")) - ((CDbl(tCust.Rows(q)("Cantidad")) * CDbl(tCust.Rows(q)("Costo")) * (Descuento / 100.0)))) * ConfigDetalles.IVA / 100.0, tCust.Rows(q)("Tipo"), tCust.Rows(q)("Cantidad"), (CDbl(tCust.Rows(q)("Cantidad")) * CDbl(tCust.Rows(q)("Costo")) - ((CDbl(tCust.Rows(q)("Cantidad")) * CDbl(tCust.Rows(q)("Costo")) * (Descuento / 100.0)))) * ConfigDetalles.IVA / 100.0, ConfigDetalles.IVA)
                    '''''                    End If
                    '''''                Next
                    '''''            End If
                    '''''        Next
                    '''''    Next
                    '''''End If

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    If Articulos.ItemTemporalBuscar(tCust.Rows(i)("CodigoTemporal"), "P" & PvCodigo).Tables("Articulos").Rows.Count <> 0 Then
                        Nuevo = 1
                    Else
                        Nuevo = 0
                    End If

                    If DetallesCliente.Excento = True Then
                        Iva = 0
                    Else
                        If tCust.Rows(i)("Exento") = True Then
                            Iva = 0
                        Else
                            Iva = ConfigDetalles.IVA
                        End If
                    End If

                    'Agrear las lineas de la Factura
                    Ordenes.AddLineas(Factura, tCust.Rows(i)("CodigoTemporal"), tCust.Rows(i)("Cantidad"), tCust.Rows(i)("Precio"), Descuento, CDbl(tCust.Rows(i)("Cantidad")) * CDbl(tCust.Rows(i)("Precio")), Comision, tCust.Rows(i)("Tipo"), Nuevo, (CDbl(tCust.Rows(i)("Cantidad")) * CDbl(tCust.Rows(i)("Precio")) - ((CDbl(tCust.Rows(i)("Cantidad")) * CDbl(tCust.Rows(i)("Precio")) * (Descuento / 100.0)))) * Iva / 100.0)

                    'Actualizar la Existencia del Item
                    'Articulos.RestarExistencias(tCust.Rows(i)("CodigoTemporal"), tCust.Rows(i)("Cantidad"))
                Next

                If VentaPerdidaNumero <> 0 Then
                    Clientes.VentasPerdidasUpdateFactura(VentaPerdidaNumero, "P" & PvCodigo, "O" & txtFactura.Text)
                End If

                If LoadOrdenProceso = True Then 'Actualizar Estado de Factura Temporal
                    OrdenProceso.UpdateEstado(RegistroOrdenProceso)
                End If

                Articulos.ItemTemporalDelete("P" & PvCodigo)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                'VB.SysContab.Rutinas.ErrorTransaccion()
                Return False
            End Try
            'VB.SysContab.Rutinas.okTransaccion()
            Return True

        End Function

        Private Sub LimpiarControles()

            'If Clientes.GenerarRecibo.Tables("Cobros").Rows.Count = 0 Then
            '    Recibo = "00001"
            'Else
            '    Recibo = Format(Clientes.GenerarRecibo.Tables("Cobros").Rows(0).Item("Recibo") + 1, "00000")
            'End If

            If FacturarCotizacion = True Then
                Cotizaciones.UpdateEstado(RegistroCotizacion, txtFactura.Text)
                FacturarCotizacion = False
                NuevaFactura = "SI"
            End If

            'txtFactura.Text = FacturaTemporal.Numero

            'MakeDataSet()
            'dgFacturacionCliente.SetDataBinding(myDataSet, "Articulos")
            'AddCustomDataTableStyle()

            'r.ComboAutoComplete(Articulo.ColumnComboBox)
            'r.ComboAutoComplete(ArticuloCodigo.ColumnComboBox)

            'Clientes.DeleteReciboCheques("00000")
            'Clientes.DeleteReciboTarjetas("00000")

            etSubTotal.Text = "0.00"
            etIva.Text = "0.00"
            etTotal.Text = "0.00"

            TotalCheques = 0
            TotalTarjetas = 0
            TotalEfectivo = 0
            TotalNotaDebito = 0
            TotalFactura = 0


            TotalGlobal = 0

            etSaldo.Text = "0.00"

            cbTipoFactura.DataSource = FormaPago.FormaPagoList().Tables("Forma_Pago")
            cbTipoFactura.ValueMember = "CODIGO"
            cbTipoFactura.DisplayMember = "NOMBRE"
        End Sub

        Private Sub AgregarItem()
            Dim k As Integer
            Dim t As Integer

            If tItem.Rows.Count <> 0 Then
                For k = 0 To tItem.Rows.Count - 1

                    For t = 0 To tCust.Rows.Count - 1

                        If tCust.Rows(t)("ArticuloCodigo") = tItem.Rows(k)("Codigo") And tCust.Rows(t)("Tipo") = tItem.Rows(k)("Tipo") Then
                            tCust.Rows(t)("Cantidad") = CDbl(tCust.Rows(t)("Cantidad")) + tItem.Rows(k)("Cantidad")
                            Exit For

                        End If

                    Next

                    If t = tCust.Rows.Count Then
                        Dim newRow1 As DataRow
                        newRow1 = tCust.NewRow
                        'newRow1("CodigoTemporal") = ArticuloCodigo.ColumnComboBox.Items.Item(Articulo.ColumnComboBox.SelectedIndex)
                        newRow1("CodigoTemporal") = tItem.Rows(k)("Codigo")
                        ' Add the row to the Customers table.
                        tCust.Rows.Add(newRow1)

                        'Articulo.ColumnComboBox.SelectedValue = tItem.Rows(k)("Codigo")
                        'ArticuloCodigo.ColumnComboBox.SelectedValue = tItem.Rows(k)("Codigo")
                        'ItemTipo.ColumnComboBox.SelectedValue = tItem.Rows(k)("Tipo")

                        DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(tItem.Rows(k)("Codigo").ToString, tItem.Rows(k)("Tipo").ToString)

                        tCust.Rows(tCust.Rows.Count - 1)("Tipo") = tItem.Rows(k)("Tipo")
                        tCust.Rows(tCust.Rows.Count - 1)("Exento") = DetallesProducto.Exento

                        'tCust.Rows(rowChanging)("Codigo") = ArticuloCodigo.ColumnComboBox.Items.Item(Articulo.ColumnComboBox.SelectedIndex)
                        tCust.Rows(tCust.Rows.Count - 1)("ArticuloCodigo") = tItem.Rows(k)("Codigo")
                        tCust.Rows(tCust.Rows.Count - 1)("Articulo") = tItem.Rows(k)("Descripcion")
                        tCust.Rows(tCust.Rows.Count - 1)("Cantidad") = tItem.Rows(k)("Cantidad")
                        tCust.Rows(tCust.Rows.Count - 1)("Precio") = CDbl(tItem.Rows(k)("Precio")).ToString(Round)

                        If TipoDescuento = "A" Then
                            tCust.Rows(tCust.Rows.Count - 1)("Descuento") = CDbl(DetallesProducto.Descuento_A).ToString(Round)
                        ElseIf TipoDescuento = "B" Then
                            tCust.Rows(tCust.Rows.Count - 1)("Descuento") = CDbl(DetallesProducto.Descuento_B).ToString(Round)
                        ElseIf TipoDescuento = "C" Then
                            tCust.Rows(tCust.Rows.Count - 1)("Descuento") = CDbl(DetallesProducto.Descuento_C).ToString(Round)
                        Else
                            tCust.Rows(tCust.Rows.Count - 1)("Descuento") = "0.00"

                        End If

                    End If
                Next
                tItem.Clear()
                ArticuloCodigo.ColumnComboBox.Focus()

            End If

        End Sub

        Private Sub RestablecerDataset()
            VentaPerdidaNumero = 0

            txtFactura.Text = Ordenes.Numero 'Format(Clientes.FacturaNumero.Tables("Facturas_Ventas").Rows(0).Item("Factura") + 1, "00000")

            GenerarRecibo()

            MakeDataSet()
            dgFacturacionCliente.SetDataBinding(myDataSet, "Articulos")
            AddCustomDataTableStyle()

            cbTipoFactura.DataSource = FormaPago.FormaPagoList().Tables("Forma_Pago")
            cbTipoFactura.ValueMember = "CODIGO"
            cbTipoFactura.DisplayMember = "NOMBRE"

            r.ComboAutoComplete(Articulo.ColumnComboBox)
            r.ComboAutoComplete(ArticuloCodigo.ColumnComboBox)
        End Sub

        Private Sub GenerarRecibo()
            If Clientes.GenerarRecibo.Tables("Cobros").Rows.Count = 0 Then
                Recibo = "00001"
            Else
                Recibo = Format(Clientes.GenerarRecibo.Tables("Cobros").Rows(0).Item("Recibo") + 1, "00000")
            End If
        End Sub

        Private Function GuardarOrdenProceso() As Boolean
            If Trim(cbCliente.Text) = "" Then
                MsgBox("Seleccione el Cliente", MsgBoxStyle.Critical)
                cbCliente.Focus()
                Return False
                Exit Function
            End If

            If Trim(txtFactura.Text) = "" Then
                MsgBox("Introduzca el No. de Factura", MsgBoxStyle.Critical)
                txtFactura.Focus()
                Return False
                Exit Function
            End If

            If cbTipoFactura.SelectedValue = 0 Then
                MsgBox("Seleccione el Tipo de Pago", MsgBoxStyle.Information)
                cbTipoFactura.Focus()
                Return False
                Exit Function
            End If

            If tCust.Rows.Count = 0 Then
                MsgBox("Seleccione al menos un Producto o Servicio", MsgBoxStyle.Critical)
                dgFacturacionCliente.Focus()
                Articulo.ColumnComboBox.Focus()
                Return False
                Exit Function
            End If

            '
            If tCust.Rows.Count > 0 Then
                If tCust.Rows(tCust.Rows.Count - 1)("ArticuloCodigo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Articulo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Precio") Is DBNull.Value Then
                    tCust.Rows(tCust.Rows.Count - 1).Delete()
                End If
            End If
            '
            For i = 0 To tCust.Rows.Count - 1
                If tCust.Rows(i)("Articulo").ToString = "" Or tCust.Rows(i)("Articulo") Is DBNull.Value Or tCust.Rows(i)("ArticuloCodigo").ToString = "" Or tCust.Rows(i)("ArticuloCodigo") Is DBNull.Value Then
                    MsgBox("Elija el Producto o Servicio", MsgBoxStyle.Critical)
                    dgFacturacionCliente.Select(i)
                    Return False
                    Exit Function
                End If

            Next

            For i = 0 To tCust.Rows.Count - 1
                If tCust.Rows(i)("Articulo").ToString = "" Or tCust.Rows(i)("Articulo") Is DBNull.Value Or tCust.Rows(i)("ArticuloCodigo").ToString = "" Or tCust.Rows(i)("ArticuloCodigo") Is DBNull.Value Then
                    If tCust.Rows(i)("Tipo") = "P" Then
                        MsgBox("Elija el Producto", MsgBoxStyle.Critical)
                    ElseIf tCust.Rows(i)("Tipo") = "S" Then
                        MsgBox("Elija el Servicio", MsgBoxStyle.Critical)
                    Else
                        MsgBox("Elija el Producto o Servicio", MsgBoxStyle.Critical)
                    End If

                    dgFacturacionCliente.Select(i)
                    Return False
                    Exit Function
                End If

                If tCust.Rows(i)("Tipo") = "P" Then
                    DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(tCust.Rows(i)("ArticuloCodigo"), tCust.Rows(i)("Tipo"))
                    If DetallesProducto.Existencia Is Nothing Or DetallesProducto.Existencia Is DBNull.Value Then
                        '
                    ElseIf DetallesProducto.Existencia = 0 Then
                        MsgBox("No hay existencias Para el Producto: " & tCust.Rows(i)("ArticuloCodigo") & " - " & tCust.Rows(i)("Articulo"), MsgBoxStyle.Critical)
                        dgFacturacionCliente.Select(i)
                        Exit Function
                    ElseIf CDbl(tCust.Rows(i)("Cantidad")) > CDbl(DetallesProducto.Existencia) Then
                        MsgBox("La cantidad del producto: " & tCust.Rows(i)("ArticuloCodigo") & " - " & tCust.Rows(i)("Articulo") & " es mayor que la existencia actual.", MsgBoxStyle.Critical)
                        dgFacturacionCliente.Select(i)
                        Exit Function
                    End If

                End If

            Next

            If CDbl(TotalGlobal.ToString(Round)) > CDbl(TotalFactura.ToString(Round)) Then
                MsgBox("El monto es mayor que el saldo de la factura", MsgBoxStyle.Information)
                Return False
                Exit Function
            End If

            'If MsgBox("Desea guardar los datos?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            '    Return False
            '    Exit Function
            'End If

            'DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            'DBConnFacturas.Open()
            'transaccionFacturas = DBConnFacturas.BeginTransaction

            'txtFactura.Text = OrdenProceso.Numero

            Dim Tipo As String
            If rbProductos.Checked = True Then
                Tipo = 0
            ElseIf rbServicios.Checked = True Then
                Tipo = 1
            Else
                Tipo = 2
            End If

            Dim Factura As String

            Factura = OrdenProceso.Numero

            Try
                OrdenProceso.AddOrdenProceso(Factura, dtpFecha.Value, Cod_Cliente, txtRuc.Text, etSubTotal.Text, _
                                             etTotal.Text, TotalDescuento, etIva.Text, "0", "0", etTotal.Text, TotalFactura - TotalGlobal, DetallesCliente.Vendedor, _
                                             dtpFechaPago.Value, dtpFechaPago.Value, Tipo, cbTipoFactura.SelectedValue, PvCodigo, Cliente)

                Dim Descuento As Double
                Dim Comision As Double
                Dim Comisiones As New VB.SysContab.ComisionDB()
                For i = 0 To tCust.Rows.Count - 1
                    If tCust.Rows(i)("Descuento") Is DBNull.Value Then
                        Descuento = 0
                    Else
                        Descuento = tCust.Rows(i)("Descuento")
                    End If

                    If Comisiones.GetComisionItemVendedor(DetallesCliente.Vendedor, tCust.Rows(i)("CodigoTemporal"), "P").Tables("Comisiones").Rows.Count <> 0 Then
                        Comision = Comisiones.GetComisionItemVendedor(DetallesCliente.Vendedor, tCust.Rows(i)("CodigoTemporal"), "P").Tables("Comisiones").Rows(0).Item("Comision")
                    Else
                        Comision = 0
                    End If

                    If DetallesCliente.Excento = True Then
                        Iva = 0
                    Else
                        If tCust.Rows(i)("Exento") = True Then
                            Iva = 0
                        Else
                            Iva = ConfigDetalles.IVA
                        End If
                    End If

                    'Agrear las lineas de la Factura
                    OrdenProceso.AddLineas(Factura, tCust.Rows(i)("CodigoTemporal"), tCust.Rows(i)("Cantidad"), tCust.Rows(i)("Precio"), Descuento, CDbl(tCust.Rows(i)("Cantidad")) * CDbl(tCust.Rows(i)("Precio")), Comision, tCust.Rows(i)("Tipo"), (CDbl(tCust.Rows(i)("Cantidad")) * CDbl(tCust.Rows(i)("Precio")) - ((CDbl(tCust.Rows(i)("Cantidad")) * CDbl(tCust.Rows(i)("Precio")) * (Descuento / 100.0)))) * Iva / 100.0)

                    'Actualizar la Existencia del Item
                    'Articulos.RestarExistencias(tCust.Rows(i)("CodigoTemporal"), tCust.Rows(i)("Cantidad"))
                Next
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                'VB.SysContab.Rutinas.ErrorTransaccion()
                Return False
            End Try
            'VB.SysContab.Rutinas.okTransaccion()
            Return True

        End Function

        Private Sub cmdProceso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProceso.Click
            If LoadOrdenProceso = True Then
                MsgBox("La orden ya está en Proceso", MsgBoxStyle.Information)
                Exit Sub
            End If
            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction
            Try
                If GuardarOrdenProceso() = False Then
                    Exit Sub
                End If
                LimpiarControles()
                VB.SysContab.Rutinas.okTransaccion()
                RestablecerDataset()
            Catch ex As Exception
                VB.SysContab.Rutinas.ErrorTransaccion()
                MsgBox(ex.Message & "Aceptar")
                Exit Sub
            End Try
        End Sub

        Private Sub cmdOrdenesProceso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOrdenesProceso.Click
            Dim f As New frmOrdenesProceso()
            f.WindowState = FormWindowState.Normal
            f.StartPosition = FormStartPosition.CenterScreen
            f.ShowDialog()

            If LoadOrdenProceso = True Then

                ds = OrdenProceso.OrdenProcesoDetalle(RegistroOrdenProceso)

                If ds.Tables("Ordenes_Proceso").Rows.Count = 0 Then
                    Exit Sub
                End If

                If ds.Tables("Ordenes_Proceso").Rows(0).Item("Cliente").ToString = "9999" Then
                    cbCliente.SelectedIndex = -1
                    cbCliente.Text = ds.Tables("Ordenes_Proceso").Rows(0).Item("Nombre_Cliente").ToString
                    Cliente = ds.Tables("Ordenes_Proceso").Rows(0).Item("Nombre_Cliente").ToString
                    Cod_Cliente = ds.Tables("Ordenes_Proceso").Rows(0).Item("Cliente")
                    DetallesCliente.Vendedor = 0
                Else
                    cbCliente.SelectedValue = ds.Tables("Ordenes_Proceso").Rows(0).Item("Cliente")
                    Cod_Cliente = cbCliente.SelectedValue

                    Me.ClienteDetalles()

                End If
                'MsgBox(cbCliente.Text)

                cbTipoFactura.SelectedValue = ds.Tables("Ordenes_Proceso").Rows(0).Item("Tipo_Factura")

                If ds.Tables("Ordenes_Proceso").Rows(0).Item("Tipo").ToString = 0 Then
                    rbProductos.Checked = True
                ElseIf ds.Tables("Ordenes_Proceso").Rows(0).Item("Tipo").ToString = 1 Then
                    rbServicios.Checked = True
                ElseIf ds.Tables("Ordenes_Proceso").Rows(0).Item("Tipo").ToString = 2 Then
                    rbAmbos.Checked = True
                End If

                MakeDataSet()
                dgFacturacionCliente.SetDataBinding(myDataSet, "Articulos")
                AddCustomDataTableStyle()

            End If
        End Sub

        Private Sub cmdCancelar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar1.Click
            If MsgBox("Desea cancelar la Operación Actual?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
                Exit Sub
            End If

            Cancelar()
            cbCliente.Focus()
        End Sub

        Private Sub Cancelar()

            VentaPerdidaNumero = 0
            etSubTotal.Text = "0.00"
            etIva.Text = "0.00"
            etTotal.Text = "0.00"

            'TotalCheques = 0
            'TotalTarjetas = 0
            'TotalEfectivo = 0
            'TotalNotaDebito = 0
            TotalFactura = 0

            TotalGlobal = 0

            etSaldo.Text = "0.00"

            'Clientes.DeleteReciboCheques("00000")
            'Clientes.DeleteReciboTarjetas("00000")

            If Clientes.GenerarRecibo.Tables("Cobros").Rows.Count = 0 Then
                Recibo = "00001"
            Else
                Recibo = Format(Clientes.GenerarRecibo.Tables("Cobros").Rows(0).Item("Recibo") + 1, "00000")
            End If

            'If FacturarCotizacion = True Then
            '    'Cotizaciones.UpdateEstado(RegistroCotizacion, txtFactura.Text)
            '    'FacturarCotizacion = False
            'End If

            LoadOrdenProceso = False
            'FacturarCotizacion = False

            cbTipoFactura.DataSource = FormaPago.FormaPagoList().Tables("Forma_Pago")
            cbTipoFactura.ValueMember = "CODIGO"
            cbTipoFactura.DisplayMember = "NOMBRE"

            txtFactura.Text = Ordenes.Numero
            rbProductos.Checked = True
            cbCliente.SelectedValue = 0

            MakeDataSet()
            dgFacturacionCliente.SetDataBinding(myDataSet, "Articulos")
            AddCustomDataTableStyle()

            r.ComboAutoComplete(Articulo.ColumnComboBox)
            r.ComboAutoComplete(ArticuloCodigo.ColumnComboBox)
        End Sub

        Private Sub cmdConsultaClientes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdConsultaClientes.Click
            If cbCliente.Text = "" Then
                MsgBox("Seleccione el Cliente", MsgBoxStyle.Information)
                Exit Sub
            End If

            If cbCliente.SelectedValue = Nothing Then
                MsgBox("El Cliente no está registrado", MsgBoxStyle.Information)
                Exit Sub
            End If

            Dim f As frmAcumulados = f.Instance

            RegistroCliente = cbCliente.SelectedValue

            f.MdiParent = Me.MdiParent
            f.Show()
        End Sub

        Private Sub frmOrdenesVer_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter

            etSaldo.Text = (TotalFactura - TotalGlobal).ToString(Round)
            AgregarItem()
        End Sub

        Private Sub etSubTotal_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles etSubTotal.MouseEnter

            etSaldo.Text = (TotalFactura - TotalGlobal).ToString(Round)
            AgregarItem()
        End Sub

        Private Sub etSubTotalT_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles etSubTotalT.MouseEnter

            etSaldo.Text = (TotalFactura - TotalGlobal).ToString(Round)
            AgregarItem()
        End Sub

        Private Sub etIva_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles etIva.MouseEnter

            etSaldo.Text = (TotalFactura - TotalGlobal).ToString(Round)
            AgregarItem()
        End Sub

        Private Sub etIvaT_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles etIvaT.MouseEnter

            etSaldo.Text = (TotalFactura - TotalGlobal).ToString(Round)
            AgregarItem()
        End Sub

        Private Sub etTotal_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles etTotal.MouseEnter

            etSaldo.Text = (TotalFactura - TotalGlobal).ToString(Round)
            AgregarItem()
        End Sub

        Private Sub etTotalT_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles etTotalT.MouseEnter

            etSaldo.Text = (TotalFactura - TotalGlobal).ToString(Round)
            AgregarItem()
        End Sub

        Private Sub etSaldo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles etSaldo.MouseEnter

            etSaldo.Text = (TotalFactura - TotalGlobal).ToString(Round)
            AgregarItem()
        End Sub

        Private Sub etSaldoT_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles etSaldoT.MouseEnter

            etSaldo.Text = (TotalFactura - TotalGlobal).ToString(Round)
            AgregarItem()
        End Sub

        Private Sub frmFacturasPuntosVenta_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
            LoadOrdenProceso = False
        End Sub

        Private Sub cbCliente_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCliente.SelectedValueChanged
            If Not IsNumeric(cbCliente.SelectedValue) Then
                Exit Sub

            End If

            Me.ClienteDetalles()

            'If cbCliente.SelectedValue = 0 Or Trim(cbCliente.Text) = "" Then
            '    txtRuc.Text = ""
            '    txtDireccion.Text = ""
            '    txtTelefono.Text = ""
            '    txtDepartamento.Text = ""
            '    txtMunicipio.Text = ""
            '    txtDescuentoProducto.Text = ""
            '    txtDescuentoServicio.Text = ""
            '    txtVendedor.Text = ""
            '    Exit Sub
            'End If

            'DetallesCliente = VB.SysContab.ClientesDB.GetDetails(cbCliente.SelectedValue)

            'cbDepartamentos.DataSource = Departamentos.GetList().Tables("DepartamentosC")
            'cbDepartamentos.ValueMember = "Codigo"
            'cbDepartamentos.DisplayMember = "Nombre"

            'cbDepartamentos.SelectedValue = DetallesCliente.Departamento

            'cbMunicipios.DataSource = Municipios.GetList(cbDepartamentos.SelectedValue).Tables("Municipios")
            'cbMunicipios.ValueMember = "Codigo"
            'cbMunicipios.DisplayMember = "Nombre"

            'cbMunicipios.SelectedValue = DetallesCliente.Municipio

            'txtRuc.Text = DetallesCliente.Ruc
            'txtDireccion.Text = DetallesCliente.Direccion
            'txtTelefono.Text = DetallesCliente.Telefono

            'If DetallesCliente.Departamento = "0" Then
            '    txtDepartamento.Text = ""
            '    txtMunicipio.Text = ""
            'Else
            '    txtDepartamento.Text = cbDepartamentos.Text
            '    txtMunicipio.Text = cbMunicipios.Text
            'End If

            'txtDescuentoProducto.Text = DetallesCliente.Desc_Prod
            'txtDescuentoServicio.Text = DetallesCliente.Desc_Serv

            'TipoDescuento = DetallesCliente.Desc_Prod

            'DetallesVendedor = Vendedor.GetDetails(DetallesCliente.Vendedor)
            'txtVendedor.Text = DetallesVendedor.Nombre

            'Dim c As Integer
            'For c = 0 To tCust.Rows.Count - 1
            '    If TipoDescuento = "A" Then
            '        tCust.Rows(c)("Descuento") = CDbl(DetallesProducto.Descuento_A).ToString(Round)
            '    ElseIf TipoDescuento = "B" Then
            '        tCust.Rows(c)("Descuento") = CDbl(DetallesProducto.Descuento_B).ToString(Round)
            '    ElseIf TipoDescuento = "C" Then
            '        tCust.Rows(c)("Descuento") = CDbl(DetallesProducto.Descuento_C).ToString(Round)
            '    Else
            '        tCust.Rows(c)("Descuento") = "0.00"
            '    End If

            'Next
        End Sub

        Private Sub ClienteDetalles()
            If cbCliente.SelectedValue = 0 Or Trim(cbCliente.Text) = "" Then
                txtRuc.Text = ""
                txtDireccion.Text = ""
                txtTelefono.Text = ""
                txtDepartamento.Text = ""
                txtMunicipio.Text = ""
                txtDescuentoProducto.Text = ""
                txtDescuentoServicio.Text = ""
                txtVendedor.Text = ""
                Exit Sub
            End If

            DetallesCliente = VB.SysContab.ClientesDB.GetDetails(cbCliente.SelectedValue)

            cbDepartamentos.DataSource = Departamentos.GetList().Tables("DepartamentosC")
            cbDepartamentos.ValueMember = "Codigo"
            cbDepartamentos.DisplayMember = "Nombre"

            cbDepartamentos.SelectedValue = DetallesCliente.Departamento

            cbMunicipios.DataSource = Municipios.GetList(cbDepartamentos.SelectedValue).Tables("Municipios")
            cbMunicipios.ValueMember = "Codigo"
            cbMunicipios.DisplayMember = "Nombre"

            cbMunicipios.SelectedValue = DetallesCliente.Municipio

            txtRuc.Text = DetallesCliente.Ruc
            txtDireccion.Text = DetallesCliente.Direccion
            txtTelefono.Text = DetallesCliente.Telefono

            If DetallesCliente.Departamento = "0" Then
                txtDepartamento.Text = ""
                txtMunicipio.Text = ""
            Else
                txtDepartamento.Text = cbDepartamentos.Text
                txtMunicipio.Text = cbMunicipios.Text
            End If

            txtDescuentoProducto.Text = DetallesCliente.Desc_Prod
            txtDescuentoServicio.Text = DetallesCliente.Desc_Serv

            TipoDescuento = DetallesCliente.Desc_Prod

            DetallesVendedor = Vendedor.GetDetails(DetallesCliente.Vendedor)
            txtVendedor.Text = DetallesVendedor.Nombre

            Dim c As Integer
            For c = 0 To tCust.Rows.Count - 1
                If TipoDescuento = "A" Then
                    tCust.Rows(c)("Descuento") = CDbl(DetallesProducto.Descuento_A).ToString(Round)
                ElseIf TipoDescuento = "B" Then
                    tCust.Rows(c)("Descuento") = CDbl(DetallesProducto.Descuento_B).ToString(Round)
                ElseIf TipoDescuento = "C" Then
                    tCust.Rows(c)("Descuento") = CDbl(DetallesProducto.Descuento_C).ToString(Round)
                Else
                    tCust.Rows(c)("Descuento") = "0.00"
                End If

            Next
        End Sub

       
    End Class

End Namespace
