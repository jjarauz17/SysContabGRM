Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace DataGridTextBoxCombo
    Public Class frmOrdenesCompraVer
        Inherits DevExpress.XtraEditors.XtraForm

        Private Shared ChildInstance As frmOrdenesCompraVer = Nothing

        Public Shared Function Instance() As frmOrdenesCompraVer
            If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
                ChildInstance = New frmOrdenesCompraVer()
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
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents gbTipo As System.Windows.Forms.GroupBox
        Friend WithEvents rbProductos As System.Windows.Forms.RadioButton
        Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents gbBotones As System.Windows.Forms.GroupBox
        Friend WithEvents cmdConsulta As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
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
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents cbProveedor As System.Windows.Forms.ComboBox
        Friend WithEvents txtFactura As System.Windows.Forms.TextBox
        Friend WithEvents dgFacturas As System.Windows.Forms.DataGrid
        Friend WithEvents etSubTotal As System.Windows.Forms.Label
        Friend WithEvents etSubTotalT As System.Windows.Forms.Label
        Friend WithEvents etIva As System.Windows.Forms.Label
        Friend WithEvents etIvaT As System.Windows.Forms.Label
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents cbTipoFactura As System.Windows.Forms.ComboBox
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents cmdPedidos As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents dtpFechaPago As System.Windows.Forms.DateTimePicker
        Friend WithEvents cmdConsultaProveedores As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents rbActivo As System.Windows.Forms.RadioButton
        Friend WithEvents rbInventario As System.Windows.Forms.RadioButton
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents txtPedido As System.Windows.Forms.TextBox
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.Label24 = New System.Windows.Forms.Label
            Me.dtpFecha = New System.Windows.Forms.DateTimePicker
            Me.Label11 = New System.Windows.Forms.Label
            Me.txtFactura = New System.Windows.Forms.TextBox
            Me.dtpFechaPago = New System.Windows.Forms.DateTimePicker
            Me.GroupBox3 = New System.Windows.Forms.GroupBox
            Me.txtPedido = New System.Windows.Forms.TextBox
            Me.Label8 = New System.Windows.Forms.Label
            Me.cbTipoFactura = New System.Windows.Forms.ComboBox
            Me.Label25 = New System.Windows.Forms.Label
            Me.etSubTotal = New System.Windows.Forms.Label
            Me.etSubTotalT = New System.Windows.Forms.Label
            Me.etIva = New System.Windows.Forms.Label
            Me.etIvaT = New System.Windows.Forms.Label
            Me.gbTipo = New System.Windows.Forms.GroupBox
            Me.rbActivo = New System.Windows.Forms.RadioButton
            Me.rbInventario = New System.Windows.Forms.RadioButton
            Me.rbProductos = New System.Windows.Forms.RadioButton
            Me.TextBox6 = New System.Windows.Forms.TextBox
            Me.Label12 = New System.Windows.Forms.Label
            Me.Label17 = New System.Windows.Forms.Label
            Me.Label18 = New System.Windows.Forms.Label
            Me.gbBotones = New System.Windows.Forms.GroupBox
            Me.cmdPedidos = New DevExpress.XtraEditors.SimpleButton
            Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
            Me.Label20 = New System.Windows.Forms.Label
            Me.cmdConsultaProveedores = New DevExpress.XtraEditors.SimpleButton
            Me.cmdConsulta = New DevExpress.XtraEditors.SimpleButton
            Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
            Me.Label19 = New System.Windows.Forms.Label
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
            Me.dgFacturas = New System.Windows.Forms.DataGrid
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label7 = New System.Windows.Forms.Label
            Me.cbProveedor = New System.Windows.Forms.ComboBox
            Me.GroupBox3.SuspendLayout()
            Me.gbTipo.SuspendLayout()
            Me.gbBotones.SuspendLayout()
            CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label24
            '
            Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label24.Location = New System.Drawing.Point(16, 7)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(88, 24)
            Me.Label24.TabIndex = 145
            Me.Label24.Text = "Proveedor:"
            '
            'dtpFecha
            '
            Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
            Me.dtpFecha.Location = New System.Drawing.Point(704, 8)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
            Me.dtpFecha.TabIndex = 151
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label11.Location = New System.Drawing.Point(808, 8)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(96, 24)
            Me.Label11.TabIndex = 150
            Me.Label11.Text = "Fecha Pago:"
            '
            'txtFactura
            '
            Me.txtFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFactura.Location = New System.Drawing.Point(520, 7)
            Me.txtFactura.MaxLength = 50
            Me.txtFactura.Name = "txtFactura"
            Me.txtFactura.ReadOnly = True
            Me.txtFactura.Size = New System.Drawing.Size(112, 20)
            Me.txtFactura.TabIndex = 149
            Me.txtFactura.Text = ""
            '
            'dtpFechaPago
            '
            Me.dtpFechaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short
            Me.dtpFechaPago.Location = New System.Drawing.Point(912, 8)
            Me.dtpFechaPago.Name = "dtpFechaPago"
            Me.dtpFechaPago.Size = New System.Drawing.Size(96, 20)
            Me.dtpFechaPago.TabIndex = 152
            '
            'GroupBox3
            '
            Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.GroupBox3.Controls.Add(Me.txtPedido)
            Me.GroupBox3.Controls.Add(Me.Label8)
            Me.GroupBox3.Controls.Add(Me.cbTipoFactura)
            Me.GroupBox3.Controls.Add(Me.Label25)
            Me.GroupBox3.Controls.Add(Me.etSubTotal)
            Me.GroupBox3.Controls.Add(Me.etSubTotalT)
            Me.GroupBox3.Controls.Add(Me.etIva)
            Me.GroupBox3.Controls.Add(Me.etIvaT)
            Me.GroupBox3.Controls.Add(Me.gbTipo)
            Me.GroupBox3.Controls.Add(Me.gbBotones)
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
            Me.GroupBox3.Controls.Add(Me.dgFacturas)
            Me.GroupBox3.Location = New System.Drawing.Point(16, 31)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(992, 488)
            Me.GroupBox3.TabIndex = 147
            Me.GroupBox3.TabStop = False
            '
            'txtPedido
            '
            Me.txtPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPedido.Location = New System.Drawing.Point(840, 96)
            Me.txtPedido.MaxLength = 50
            Me.txtPedido.Name = "txtPedido"
            Me.txtPedido.ReadOnly = True
            Me.txtPedido.Size = New System.Drawing.Size(136, 20)
            Me.txtPedido.TabIndex = 151
            Me.txtPedido.Text = ""
            Me.txtPedido.Visible = False
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label8.Location = New System.Drawing.Point(760, 96)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(72, 24)
            Me.Label8.TabIndex = 150
            Me.Label8.Text = "No. Pedido:"
            Me.Label8.Visible = False
            '
            'cbTipoFactura
            '
            Me.cbTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbTipoFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbTipoFactura.Location = New System.Drawing.Point(488, 96)
            Me.cbTipoFactura.Name = "cbTipoFactura"
            Me.cbTipoFactura.Size = New System.Drawing.Size(264, 21)
            Me.cbTipoFactura.TabIndex = 142
            '
            'Label25
            '
            Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label25.Location = New System.Drawing.Point(384, 96)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(96, 24)
            Me.Label25.TabIndex = 143
            Me.Label25.Text = "Forma de Pago:"
            '
            'etSubTotal
            '
            Me.etSubTotal.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.etSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etSubTotal.ForeColor = System.Drawing.Color.Maroon
            Me.etSubTotal.Location = New System.Drawing.Point(272, 456)
            Me.etSubTotal.Name = "etSubTotal"
            Me.etSubTotal.Size = New System.Drawing.Size(112, 24)
            Me.etSubTotal.TabIndex = 138
            Me.etSubTotal.Text = "0.00"
            Me.etSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etSubTotalT
            '
            Me.etSubTotalT.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.etSubTotalT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etSubTotalT.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.etSubTotalT.Location = New System.Drawing.Point(184, 456)
            Me.etSubTotalT.Name = "etSubTotalT"
            Me.etSubTotalT.Size = New System.Drawing.Size(80, 24)
            Me.etSubTotalT.TabIndex = 137
            Me.etSubTotalT.Text = "Sub Total:"
            Me.etSubTotalT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etIva
            '
            Me.etIva.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.etIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etIva.ForeColor = System.Drawing.Color.Maroon
            Me.etIva.Location = New System.Drawing.Point(496, 456)
            Me.etIva.Name = "etIva"
            Me.etIva.Size = New System.Drawing.Size(104, 24)
            Me.etIva.TabIndex = 136
            Me.etIva.Text = "0.00"
            Me.etIva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etIvaT
            '
            Me.etIvaT.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.etIvaT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etIvaT.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.etIvaT.Location = New System.Drawing.Point(392, 456)
            Me.etIvaT.Name = "etIvaT"
            Me.etIvaT.Size = New System.Drawing.Size(96, 24)
            Me.etIvaT.TabIndex = 135
            Me.etIvaT.Text = "IVA:"
            Me.etIvaT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'gbTipo
            '
            Me.gbTipo.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.gbTipo.Controls.Add(Me.rbActivo)
            Me.gbTipo.Controls.Add(Me.rbInventario)
            Me.gbTipo.Controls.Add(Me.rbProductos)
            Me.gbTipo.Controls.Add(Me.TextBox6)
            Me.gbTipo.Controls.Add(Me.Label12)
            Me.gbTipo.Controls.Add(Me.Label17)
            Me.gbTipo.Controls.Add(Me.Label18)
            Me.gbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipo.ForeColor = System.Drawing.Color.Maroon
            Me.gbTipo.Location = New System.Drawing.Point(8, 88)
            Me.gbTipo.Name = "gbTipo"
            Me.gbTipo.Size = New System.Drawing.Size(368, 40)
            Me.gbTipo.TabIndex = 131
            Me.gbTipo.TabStop = False
            '
            'rbActivo
            '
            Me.rbActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbActivo.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.rbActivo.Location = New System.Drawing.Point(240, 8)
            Me.rbActivo.Name = "rbActivo"
            Me.rbActivo.Size = New System.Drawing.Size(96, 24)
            Me.rbActivo.TabIndex = 126
            Me.rbActivo.Text = "Activo"
            Me.rbActivo.Visible = False
            '
            'rbInventario
            '
            Me.rbInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbInventario.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.rbInventario.Location = New System.Drawing.Point(128, 8)
            Me.rbInventario.Name = "rbInventario"
            Me.rbInventario.Size = New System.Drawing.Size(96, 24)
            Me.rbInventario.TabIndex = 125
            Me.rbInventario.Text = "Inventario"
            '
            'rbProductos
            '
            Me.rbProductos.Checked = True
            Me.rbProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbProductos.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.rbProductos.Location = New System.Drawing.Point(16, 8)
            Me.rbProductos.Name = "rbProductos"
            Me.rbProductos.Size = New System.Drawing.Size(96, 24)
            Me.rbProductos.TabIndex = 124
            Me.rbProductos.TabStop = True
            Me.rbProductos.Text = "Productos"
            '
            'TextBox6
            '
            Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox6.Location = New System.Drawing.Point(832, 16)
            Me.TextBox6.MaxLength = 50
            Me.TextBox6.Name = "TextBox6"
            Me.TextBox6.ReadOnly = True
            Me.TextBox6.Size = New System.Drawing.Size(136, 20)
            Me.TextBox6.TabIndex = 123
            Me.TextBox6.Text = ""
            '
            'Label12
            '
            Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label12.Location = New System.Drawing.Point(752, 16)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(72, 24)
            Me.Label12.TabIndex = 103
            Me.Label12.Text = "Teléfono:"
            '
            'Label17
            '
            Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label17.ForeColor = System.Drawing.Color.Maroon
            Me.Label17.Location = New System.Drawing.Point(632, 440)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(112, 24)
            Me.Label17.TabIndex = 110
            Me.Label17.Text = "0.00"
            Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label18
            '
            Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label18.Location = New System.Drawing.Point(536, 440)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(96, 24)
            Me.Label18.TabIndex = 109
            Me.Label18.Text = "Total:"
            Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'gbBotones
            '
            Me.gbBotones.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.gbBotones.Controls.Add(Me.cmdPedidos)
            Me.gbBotones.Controls.Add(Me.cmdAceptar)
            Me.gbBotones.Controls.Add(Me.Label20)
            Me.gbBotones.Controls.Add(Me.cmdConsultaProveedores)
            Me.gbBotones.Controls.Add(Me.cmdConsulta)
            Me.gbBotones.Controls.Add(Me.cmdCancelar)
            Me.gbBotones.Controls.Add(Me.Label19)
            Me.gbBotones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBotones.ForeColor = System.Drawing.Color.Maroon
            Me.gbBotones.Location = New System.Drawing.Point(888, 128)
            Me.gbBotones.Name = "gbBotones"
            Me.gbBotones.Size = New System.Drawing.Size(88, 320)
            Me.gbBotones.TabIndex = 130
            Me.gbBotones.TabStop = False
            '
            'cmdPedidos
            '
            Me.cmdPedidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdPedidos.ForeColor = System.Drawing.Color.Black
            Me.cmdPedidos.Location = New System.Drawing.Point(8, 128)
            Me.cmdPedidos.Name = "cmdPedidos"
            Me.cmdPedidos.Size = New System.Drawing.Size(72, 24)
            Me.cmdPedidos.TabIndex = 149
            Me.cmdPedidos.Text = "Pe&didos"
            '
            'cmdAceptar
            '
            Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdAceptar.ForeColor = System.Drawing.Color.Black
            Me.cmdAceptar.Location = New System.Drawing.Point(8, 96)
            Me.cmdAceptar.Name = "cmdAceptar"
            Me.cmdAceptar.Size = New System.Drawing.Size(72, 24)
            Me.cmdAceptar.TabIndex = 28
            Me.cmdAceptar.Text = "&Guardar"
            '
            'Label20
            '
            Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label20.ForeColor = System.Drawing.Color.Maroon
            Me.Label20.Location = New System.Drawing.Point(0, 88)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(88, 96)
            Me.Label20.TabIndex = 148
            Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'cmdConsultaProveedores
            '
            Me.cmdConsultaProveedores.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.cmdConsultaProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdConsultaProveedores.ForeColor = System.Drawing.Color.Black
            Me.cmdConsultaProveedores.Location = New System.Drawing.Point(8, 50)
            Me.cmdConsultaProveedores.Name = "cmdConsultaProveedores"
            Me.cmdConsultaProveedores.Size = New System.Drawing.Size(72, 24)
            Me.cmdConsultaProveedores.TabIndex = 33
            Me.cmdConsultaProveedores.Text = "Pro&veedor"
            '
            'cmdConsulta
            '
            Me.cmdConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdConsulta.ForeColor = System.Drawing.Color.Black
            Me.cmdConsulta.Location = New System.Drawing.Point(8, 24)
            Me.cmdConsulta.Name = "cmdConsulta"
            Me.cmdConsulta.Size = New System.Drawing.Size(72, 24)
            Me.cmdConsulta.TabIndex = 31
            Me.cmdConsulta.Text = "&Productos"
            '
            'cmdCancelar
            '
            Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdCancelar.ForeColor = System.Drawing.Color.Black
            Me.cmdCancelar.Location = New System.Drawing.Point(8, 288)
            Me.cmdCancelar.Name = "cmdCancelar"
            Me.cmdCancelar.Size = New System.Drawing.Size(72, 24)
            Me.cmdCancelar.TabIndex = 29
            Me.cmdCancelar.Text = "&Salir"
            '
            'Label19
            '
            Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label19.ForeColor = System.Drawing.Color.Maroon
            Me.Label19.Location = New System.Drawing.Point(0, 8)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(88, 72)
            Me.Label19.TabIndex = 147
            Me.Label19.Text = "Consulta"
            Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'txtMunicipio
            '
            Me.txtMunicipio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMunicipio.Location = New System.Drawing.Point(752, 64)
            Me.txtMunicipio.MaxLength = 50
            Me.txtMunicipio.Name = "txtMunicipio"
            Me.txtMunicipio.ReadOnly = True
            Me.txtMunicipio.Size = New System.Drawing.Size(224, 20)
            Me.txtMunicipio.TabIndex = 127
            Me.txtMunicipio.Text = ""
            '
            'txtDepartamento
            '
            Me.txtDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDepartamento.Location = New System.Drawing.Point(376, 64)
            Me.txtDepartamento.MaxLength = 50
            Me.txtDepartamento.Name = "txtDepartamento"
            Me.txtDepartamento.ReadOnly = True
            Me.txtDepartamento.Size = New System.Drawing.Size(280, 20)
            Me.txtDepartamento.TabIndex = 126
            Me.txtDepartamento.Text = ""
            '
            'txtPais
            '
            Me.txtPais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPais.Location = New System.Drawing.Point(48, 64)
            Me.txtPais.MaxLength = 50
            Me.txtPais.Name = "txtPais"
            Me.txtPais.ReadOnly = True
            Me.txtPais.Size = New System.Drawing.Size(216, 20)
            Me.txtPais.TabIndex = 125
            Me.txtPais.Text = ""
            '
            'txtDireccion
            '
            Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDireccion.Location = New System.Drawing.Point(376, 16)
            Me.txtDireccion.MaxLength = 50
            Me.txtDireccion.Multiline = True
            Me.txtDireccion.Name = "txtDireccion"
            Me.txtDireccion.ReadOnly = True
            Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtDireccion.Size = New System.Drawing.Size(280, 32)
            Me.txtDireccion.TabIndex = 124
            Me.txtDireccion.Text = ""
            '
            'txtTelefono
            '
            Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTelefono.Location = New System.Drawing.Point(752, 16)
            Me.txtTelefono.MaxLength = 50
            Me.txtTelefono.Name = "txtTelefono"
            Me.txtTelefono.ReadOnly = True
            Me.txtTelefono.Size = New System.Drawing.Size(224, 20)
            Me.txtTelefono.TabIndex = 123
            Me.txtTelefono.Text = ""
            '
            'txtRuc
            '
            Me.txtRuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRuc.Location = New System.Drawing.Point(48, 16)
            Me.txtRuc.MaxLength = 50
            Me.txtRuc.Name = "txtRuc"
            Me.txtRuc.ReadOnly = True
            Me.txtRuc.Size = New System.Drawing.Size(216, 20)
            Me.txtRuc.TabIndex = 122
            Me.txtRuc.Text = ""
            '
            'cbMunicipios
            '
            Me.cbMunicipios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
            Me.cbMunicipios.Enabled = False
            Me.cbMunicipios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbMunicipios.Location = New System.Drawing.Point(448, 296)
            Me.cbMunicipios.Name = "cbMunicipios"
            Me.cbMunicipios.Size = New System.Drawing.Size(224, 21)
            Me.cbMunicipios.TabIndex = 121
            Me.cbMunicipios.Visible = False
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label5.Location = New System.Drawing.Point(672, 64)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(72, 24)
            Me.Label5.TabIndex = 120
            Me.Label5.Text = "Municipio:"
            '
            'cbDepartamentos
            '
            Me.cbDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
            Me.cbDepartamentos.Enabled = False
            Me.cbDepartamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbDepartamentos.Location = New System.Drawing.Point(448, 264)
            Me.cbDepartamentos.Name = "cbDepartamentos"
            Me.cbDepartamentos.Size = New System.Drawing.Size(224, 21)
            Me.cbDepartamentos.TabIndex = 119
            Me.cbDepartamentos.Visible = False
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label6.Location = New System.Drawing.Point(8, 64)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(40, 24)
            Me.Label6.TabIndex = 115
            Me.Label6.Text = "País:"
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label2.Location = New System.Drawing.Point(280, 16)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(88, 24)
            Me.Label2.TabIndex = 101
            Me.Label2.Text = "Dirección:"
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label9.Location = New System.Drawing.Point(8, 16)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(40, 24)
            Me.Label9.TabIndex = 100
            Me.Label9.Text = "RUC:"
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label4.Location = New System.Drawing.Point(280, 64)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(96, 24)
            Me.Label4.TabIndex = 102
            Me.Label4.Text = "Departamento:"
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label3.Location = New System.Drawing.Point(672, 16)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(72, 24)
            Me.Label3.TabIndex = 103
            Me.Label3.Text = "Teléfono:"
            '
            'etTotal
            '
            Me.etTotal.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.etTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTotal.ForeColor = System.Drawing.Color.Maroon
            Me.etTotal.Location = New System.Drawing.Point(680, 448)
            Me.etTotal.Name = "etTotal"
            Me.etTotal.Size = New System.Drawing.Size(184, 32)
            Me.etTotal.TabIndex = 110
            Me.etTotal.Text = "0.00"
            Me.etTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etTotalT
            '
            Me.etTotalT.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.etTotalT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTotalT.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.etTotalT.Location = New System.Drawing.Point(608, 456)
            Me.etTotalT.Name = "etTotalT"
            Me.etTotalT.Size = New System.Drawing.Size(56, 24)
            Me.etTotalT.TabIndex = 109
            Me.etTotalT.Text = "Total:"
            Me.etTotalT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dgFacturas
            '
            Me.dgFacturas.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
            Me.dgFacturas.BackColor = System.Drawing.Color.Gainsboro
            Me.dgFacturas.BackgroundColor = System.Drawing.Color.DarkGray
            Me.dgFacturas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.dgFacturas.CaptionBackColor = System.Drawing.Color.DarkKhaki
            Me.dgFacturas.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            Me.dgFacturas.CaptionForeColor = System.Drawing.Color.Black
            Me.dgFacturas.DataMember = ""
            Me.dgFacturas.FlatMode = True
            Me.dgFacturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgFacturas.ForeColor = System.Drawing.Color.Black
            Me.dgFacturas.GridLineColor = System.Drawing.Color.Silver
            Me.dgFacturas.HeaderBackColor = System.Drawing.Color.Black
            Me.dgFacturas.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            Me.dgFacturas.HeaderForeColor = System.Drawing.Color.White
            Me.dgFacturas.LinkColor = System.Drawing.Color.DarkSlateBlue
            Me.dgFacturas.Location = New System.Drawing.Point(8, 128)
            Me.dgFacturas.Name = "dgFacturas"
            Me.dgFacturas.ParentRowsBackColor = System.Drawing.Color.LightGray
            Me.dgFacturas.ParentRowsForeColor = System.Drawing.Color.Black
            Me.dgFacturas.SelectionBackColor = System.Drawing.Color.Firebrick
            Me.dgFacturas.SelectionForeColor = System.Drawing.Color.White
            Me.dgFacturas.Size = New System.Drawing.Size(872, 320)
            Me.dgFacturas.TabIndex = 27
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label1.Location = New System.Drawing.Point(640, 7)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(64, 24)
            Me.Label1.TabIndex = 146
            Me.Label1.Text = "Fecha:"
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label7.Location = New System.Drawing.Point(432, 7)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(80, 24)
            Me.Label7.TabIndex = 148
            Me.Label7.Text = "No. Orden:"
            '
            'cbProveedor
            '
            Me.cbProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbProveedor.Location = New System.Drawing.Point(104, 7)
            Me.cbProveedor.Name = "cbProveedor"
            Me.cbProveedor.Size = New System.Drawing.Size(320, 21)
            Me.cbProveedor.TabIndex = 144
            '
            'frmOrdenesCompraVer
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(1024, 526)
            Me.Controls.Add(Me.Label24)
            Me.Controls.Add(Me.dtpFecha)
            Me.Controls.Add(Me.Label11)
            Me.Controls.Add(Me.txtFactura)
            Me.Controls.Add(Me.dtpFechaPago)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.cbProveedor)
            Me.Name = "frmOrdenesCompraVer"
            Me.GroupBox3.ResumeLayout(False)
            Me.gbTipo.ResumeLayout(False)
            Me.gbBotones.ResumeLayout(False)
            CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Dim WithEvents tCust As DataTable
        Private WithEvents myDataSet As DataSet
        Dim ds As DataSet

        Dim i As Integer
        Dim Tipo As Integer

        Public WithEvents Articulo As DataGridComboBoxColumn
        Public WithEvents ArticuloCodigo As DataGridComboBoxColumn
        Dim Cantidad As DataGridTextBoxColumn
        Dim Descuento As DataGridTextBoxColumn
        Dim Precio As DataGridTextBoxColumn

        Dim WithEvents ItemTipo As DataGridComboBoxColumn

        Dim ValorActualCantidad As Double
        Dim ValorActualPrecio As Double
        Dim ValorActualDescuento As Double

        Dim Facturas As New VB.SysContab.Ordenes_ComprasDB()
        Dim FormaPago As New VB.SysContab.Forma_PagoDB()
        Dim Proveedores As New VB.SysContab.ProveedoresDB()
        Dim DetallesProveedor As New VB.SysContab.ProveedoresDetails()
        Dim Articulos As New VB.SysContab.ArticulosDB()
        Dim DetallesProducto As New VB.SysContab.ArticulosDetails()
        Dim r As New VB.SysContab.Rutinas()

        Dim ArticulosCC As New VB.SysContab.GruposCCDB()

        Dim Pedidos As New VB.SysContab.PedidosDB()

        Dim Config As New VB.SysContab.ConfiguracionDB()
        Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails()

        Public CargarPedido As Boolean
        Public Pedido As String

        Dim dsItems As DataSet

        Public Codigo As String

        Dim dsItemCC As DataSet
        Public NoOrden As String
        Public Destino As String

        Private Sub frmOrdenesCompraVer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            r.FormularioColor(Me)

            ConfigDetalles = Config.GetConfigDetails

            Me.cmdPedidos.Visible = False

            Me.dtpFecha.Value = r.Fecha
            Me.dtpFechaPago.Value = r.Fecha

            ds = Facturas.OrdenComprasDetalle(Me.NoOrden, Destino)
            Me.txtFactura.Text = Me.NoOrden

            cbProveedor.DataSource = Proveedores.ProveedoresList(3).Tables("Proveedores")
            cbProveedor.ValueMember = "Codigo"
            cbProveedor.DisplayMember = "Nombre"

            cbTipoFactura.DataSource = FormaPago.FormaPagoList().Tables("Forma_Pago")
            cbTipoFactura.ValueMember = "Codigo"
            cbTipoFactura.DisplayMember = "Nombre"

            cbProveedor.SelectedValue = 0

            If ds.Tables("Ordenes_Compras").Rows.Count <> 0 Then
                Me.txtFactura.ReadOnly = True
                'Me.cbProveedor.Enabled = False
                'Me.cbTipoFactura.Enabled = False
                'Me.dtpFecha.Enabled = False
                'Me.dtpFechaPago.Enabled = False
                'Me.dgFacturas.ReadOnly = True

                cbProveedor.SelectedValue = ds.Tables("Ordenes_Compras").Rows(0).Item("Proveedor_ID")
                cbTipoFactura.SelectedValue = ds.Tables("Ordenes_Compras").Rows(0).Item("FormaPago_ID")
                dtpFecha.Value = ds.Tables("Ordenes_Compras").Rows(0).Item("Factura_Fecha")
                dtpFechaPago.Value = ds.Tables("Ordenes_Compras").Rows(0).Item("Factura_FechaPago")
                'Me.txtPedido.Text = ds.Tables("Facturas_Compras").Rows(0).Item("OrdenCompra_ID").ToString

            End If

            MakeDataSet()
            dgFacturas.SetDataBinding(myDataSet, "Articulos")
            AddCustomDataTableStyle()

            LeaveCommit = False
            BuscarCombo = True

            TipoItem = "P"

            Indice = -1

            Tipo = 0

            r.ComboAutoComplete(Articulo.ColumnComboBox)
            r.ComboAutoComplete(ArticuloCodigo.ColumnComboBox)

            Me.Text = "O r d e n e s  d e  C o m p r a"
            Me.Refresh()
        End Sub

        Private Sub cbProveedor_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbProveedor.SelectedValueChanged
            If Not IsNumeric(cbProveedor.SelectedValue) Then
                Exit Sub

            End If

            If cbProveedor.SelectedValue = 0 Or Trim(cbProveedor.Text) = "" Then
                txtRuc.Text = ""
                txtDireccion.Text = ""
                txtTelefono.Text = ""
                txtDepartamento.Text = ""
                txtMunicipio.Text = ""
                Exit Sub
            End If

            DetallesProveedor = VB.SysContab.ProveedoresDB.GetDetails(cbProveedor.SelectedValue)

            txtRuc.Text = DetallesProveedor.Ruc
            txtDireccion.Text = DetallesProveedor.Direccion
            txtTelefono.Text = DetallesProveedor.Telefono
        End Sub

        Private Sub cbProveedor_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbProveedor.Leave
            If Trim(cbProveedor.Text) = "" Then
                txtRuc.Text = ""
                txtDireccion.Text = ""
                txtTelefono.Text = ""
                txtDepartamento.Text = ""
                txtMunicipio.Text = ""
                Exit Sub
            End If

            If Proveedores.ProveedoresBuscar(Trim(cbProveedor.Text)).Tables("Proveedores").Rows.Count = 0 Then
                cbProveedor.Text = cbProveedor.Text.ToUpper

                txtRuc.Text = ""
                txtDireccion.Text = ""
                txtTelefono.Text = ""
                txtDepartamento.Text = ""
                txtMunicipio.Text = ""

                If (MsgBox("Proveedor no existe. Desea agregarlo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)) = MsgBoxResult.No Then
                Else
                    Dim f As New frmAgregarProveedorQuick()
                    f.WindowState = FormWindowState.Normal
                    f.StartPosition = FormStartPosition.CenterScreen

                    f.txtNombre.Text = cbProveedor.Text.ToUpper
                    cbProveedor.Text = cbProveedor.Text.ToUpper

                    f.ShowDialog()

                    cbProveedor.DataSource = Proveedores.ProveedoresList(3).Tables("Proveedores")
                    cbProveedor.ValueMember = "Codigo"
                    cbProveedor.DisplayMember = "Nombre"

                    cbProveedor.SelectedValue = f.txtCodigo.Text

                End If
                Exit Sub
            End If

            cbProveedor.Refresh()
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

            myDataSet.Tables.Add(tCust)

            Dim newRow1 As DataRow
            Dim j As Integer

            For j = 0 To ds.Tables("Ordenes_Compras").Rows.Count - 1
                newRow1 = tCust.NewRow
                newRow1("ArticuloCodigo") = ds.Tables("Ordenes_Compras").Rows(j).Item("Item_ID")

                tCust.Rows.Add(newRow1)

                tCust.Rows(j)("Articulo") = ds.Tables("Ordenes_Compras").Rows(j).Item("Nombre")
                tCust.Rows(j)("Cantidad") = ds.Tables("Ordenes_Compras").Rows(j).Item("Item_Cantidad")
                tCust.Rows(j)("Precio") = CDbl(ds.Tables("Ordenes_Compras").Rows(j).Item("Item_Costo")).ToString(RoundP)
                tCust.Rows(j)("Descuento") = CDbl(ds.Tables("Ordenes_Compras").Rows(j).Item("Item_Descuento")).ToString(Round)
                tCust.Rows(j)("Tipo") = ds.Tables("Ordenes_Compras").Rows(j).Item("Item_Tipo")

                tCust.Rows(j)("SubTotal") = CDbl((tCust.Rows(j)("Cantidad") * tCust.Rows(j)("Precio")) - ((tCust.Rows(j)("Cantidad") * tCust.Rows(j)("Precio")) * (tCust.Rows(j)("Descuento")) / 100.0)).ToString(Round)

                'Me.etIva.Text = (CDbl(Me.etIva.Text) + CDbl(ds.Tables("Ordenes_Compras").Rows(j).Item("Item_Iva")).ToString(Round)).ToString(Round)
                'Me.etSubTotal.Text = (CDbl(Me.etSubTotal.Text) + CDbl(tCust.Rows(j)("SubTotal"))).ToString(Round)

            Next
        End Sub

        Private Sub TextBoxPrecioLeaveHandler(ByVal sender As Object, ByVal e As EventArgs)
            If Not IsNumeric(Precio.TextBox.Text) Then
                Precio.TextBox.Text = ValorActualPrecio.ToString(RoundP)
            Else
                If CDbl(Precio.TextBox.Text) <= 0 Then
                    MsgBox("El Precio debe ser mayor a Cero (0)", MsgBoxStyle.Information)
                    Precio.TextBox.Text = ValorActualPrecio.ToString(RoundP)
                    Exit Sub
                Else
                    Precio.TextBox.Text = CDbl(Precio.TextBox.Text).ToString(RoundP)
                End If
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
                Else
                    If Descuento.TextBox.Text = "0" Then
                        Descuento.TextBox.Text = "0.00"
                    Else
                        Descuento.TextBox.Text = CDbl(Descuento.TextBox.Text).ToString(Round)
                    End If
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

            End If

            If dgFacturas.CurrentRowIndex >= tCust.Rows.Count Then
                Exit Sub
            End If

            If tCust.Rows(dgFacturas.CurrentRowIndex)("ArticuloCodigo").ToString = "" Or tCust.Rows(dgFacturas.CurrentRowIndex)("ArticuloCodigo") Is DBNull.Value Then
                Exit Sub
            End If

            If TipoItem = "S" Then
                Exit Sub
            ElseIf TipoItem = "A" Then
                If tCust.Rows(dgFacturas.CurrentRowIndex)("Tipo").ToString = "S" Then
                    Exit Sub
                End If
            End If

            'DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(tCust.Rows(dgFacturas.CurrentRowIndex)("ArticuloCodigo"), tCust.Rows(dgFacturas.CurrentRowIndex)("Tipo"), EmpresaActual)
            'If DetallesProducto.Existencia Is Nothing Or DetallesProducto.Existencia Is DBNull.Value Then
            '    '
            'ElseIf DetallesProducto.Existencia = 0 Then
            '    MsgBox("No hay existencias...", MsgBoxStyle.Critical)
            '    Cantidad.TextBox.Focus()
            '    Exit Sub
            'ElseIf CDbl(Cantidad.TextBox.Text) > CDbl(DetallesProducto.Existencia) Then
            '    MsgBox("La cantidad es mayor que la existencia actual", MsgBoxStyle.Critical)
            '    Exit Sub
            'End If

        End Sub

        Dim Servicio As Boolean

        Private Sub Evento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
            'If Me.rbActivo.Checked = False Then
            '    Exit Sub
            'End If

            'Dim dsItems As DataSet

            'If e.KeyCode = Keys.F9 Then

            '    If Servicio = True Then
            '        Exit Sub
            '    End If

            '    Servicio = True

            '    dsItems = Articulos.ProductosGetAll("S")

            '    ArticuloCodigo.ColumnComboBox.Items.Clear()
            '    Articulo.ColumnComboBox.Items.Clear()
            '    ItemTipo.ColumnComboBox.Items.Clear()

            '    For i = 0 To dsItems.Tables("Articulos").Rows.Count - 1
            '        ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Codigo"))
            '        Articulo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Nombre"))
            '        ItemTipo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Tipo"))

            '    Next

            'ElseIf e.KeyCode = Keys.F10 Then

            '    If Servicio = False Then
            '        Exit Sub
            '    End If

            '    Servicio = False

            '    dsItems = Articulos.ProductosGetAll("P")

            '    ArticuloCodigo.ColumnComboBox.Items.Clear()
            '    Articulo.ColumnComboBox.Items.Clear()
            '    ItemTipo.ColumnComboBox.Items.Clear()

            '    For i = 0 To dsItems.Tables("Articulos").Rows.Count - 1
            '        ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Codigo"))
            '        Articulo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Nombre"))
            '        ItemTipo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Tipo"))

            '    Next
            'End If

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

            'Dim ArticuloCodigo As DataGridComboBoxColumn
            ArticuloCodigo = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))
            ArticuloCodigo.MappingName = "ArticuloCodigo"
            ArticuloCodigo.HeaderText = "Código"
            ArticuloCodigo.Width = 100

            AddHandler ArticuloCodigo.ColumnComboBox.KeyDown, AddressOf Evento_KeyPress

            ts1.GridColumnStyles.Add(ArticuloCodigo)
            ts1.PreferredRowHeight = (ArticuloCodigo.ColumnComboBox.Height + 3)

            ArticuloCodigo.NullText = ""

            colCount = (colCount + 1)

            'Dim Articulo As DataGridComboBoxColumn
            Articulo = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))
            Articulo.MappingName = "Articulo"
            Articulo.HeaderText = "Descripción"
            Articulo.Width = 300

            AddHandler Articulo.ColumnComboBox.KeyDown, AddressOf Evento_KeyPress

            ts1.GridColumnStyles.Add(Articulo)
            ts1.PreferredRowHeight = (Articulo.ColumnComboBox.Height + 3)

            Articulo.NullText = ""
            colCount = (colCount + 1)

            'Dim Cantidad As DataGridTextBoxColumn
            Cantidad = New DataGridTextBoxColumn()
            Cantidad.MappingName = "Cantidad"
            'from dataset table
            Cantidad.HeaderText = "Cantidad"
            Cantidad.Format = "d3"
            Cantidad.Width = 100
            Cantidad.Alignment = HorizontalAlignment.Right
            Cantidad.ReadOnly = False

            AddHandler Cantidad.TextBox.Leave, New EventHandler(AddressOf TextBoxLeaveHandler)
            'AddHandler Cantidad.TextBox.KeyDown, AddressOf Evento_KeyPress

            ts1.GridColumnStyles.Add(Cantidad)
            colCount = (colCount + 1)

            Cantidad.NullText = ""

            'Dim Precio As DataGridTextBoxColumn
            Precio = New DataGridTextBoxColumn()
            Precio.MappingName = "Precio"
            Precio.HeaderText = "Precio"
            Precio.Width = 100
            Precio.Alignment = HorizontalAlignment.Right
            Precio.ReadOnly = False
            Precio.Format = "##,###0.00"

            AddHandler Precio.TextBox.Leave, New EventHandler(AddressOf TextBoxPrecioLeaveHandler)

            'AddHandler Precio.TextBox.KeyPress, New EventHandler(AddressOf TextBoxPrecioKeyPressHandler)

            ts1.GridColumnStyles.Add(Precio)
            colCount = (colCount + 1)

            Precio.NullText = "0"

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

            Descuento.NullText = "0"

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

            ts1.GridColumnStyles.Add(ItemTipo)
            ts1.PreferredRowHeight = (ItemTipo.ColumnComboBox.Height + 3)

            ItemTipo.NullText = ""

            'DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            'DBConnFacturas.Open()
            'transaccionFacturas = DBConnFacturas.BeginTransaction

            If Me.rbInventario.Checked = True Then
                BuscarCombo = False
                'txtFactura.Text = Facturas.OrdenCompraCCNumero
                dsItems = ArticulosCC.ArticulosCCList("", 0, 0, 0, 0)
                For i = 0 To dsItems.Tables("GruposCC").Rows.Count - 1
                    ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("GruposCC").Rows(i).Item("Código"))
                    Articulo.ColumnComboBox.Items.Add(dsItems.Tables("GruposCC").Rows(i).Item("Nombre"))
                    ItemTipo.ColumnComboBox.Items.Add("I")
                Next
            Else
                BuscarCombo = True
                'Me.txtFactura.Text = Facturas.Numero
                dsItems = Articulos.ProductosGetAll("P")
                For i = 0 To dsItems.Tables("Articulos").Rows.Count - 1
                    ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Codigo"))
                    Articulo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Nombre"))
                    ItemTipo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Tipo"))
                Next
            End If

            'VB.SysContab.Rutinas.okTransaccion()

            ''''dsItems = Articulos.ProductosGetAll("P")

            '''''If rbProductos.Checked = True Then
            ''''For i = 0 To dsItems.Tables("Articulos").Rows.Count - 1
            ''''    ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Codigo"))
            ''''    Articulo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Nombre"))
            ''''    ItemTipo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Tipo"))
            ''''Next

            'ElseIf rbServicios.Checked = True Then
            'Else
            'End If

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
            ts1.HeaderFont = dgFacturas.HeaderFont
            ts1.HeaderBackColor = Color.LightSteelBlue  'Color.LightBlue

            dgFacturas.CaptionVisible = False

            dgFacturas.TableStyles.Clear()
            dgFacturas.TableStyles.Add(ts1)

        End Sub

        Public Sub MyComboValueChanged(ByVal rowChanging As Integer, ByVal newValue As Object)
            Console.WriteLine("index changed {0} {1}", rowChanging, newValue)

            If Indice = 0 And Me.rbProductos.Checked Then
                Dim f As New frmAgregarArticuloQuick()
                f.WindowState = FormWindowState.Normal
                f.StartPosition = FormStartPosition.CenterScreen

                f.etTipo.Text = "P"
                f.lbProvTemporal.Text = cbProveedor.SelectedValue
                f.cbProveedores.EditValue = f.lbProvTemporal.Text
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
                    If Me.rbProductos.Checked = True Then
                        'DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(ArticuloCodigo.ColumnComboBox.Items.Item(Indice).ToString, "P", EmpresaActual)
                        DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(ArticuloCodigo.ColumnComboBox.Items.Item(Indice).ToString, ItemTipo.ColumnComboBox.Items.Item(Indice).ToString)
                    Else
                        dsItemCC = ArticulosCC.ArticulosCCDetalles(ArticuloCodigo.ColumnComboBox.Items.Item(Indice).ToString)
                    End If

                    If tCust.Rows.Count < rowChanging + 1 Then
                        Dim newRow1 As DataRow
                        newRow1 = tCust.NewRow
                        newRow1("CodigoTemporal") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
                        ' Add the row to the Customers table.
                        tCust.Rows.Add(newRow1)

                        tCust.Rows(rowChanging)("ArticuloCodigo") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Articulo") = Articulo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Cantidad") = 1

                        If Me.rbProductos.Checked = True Then
                            tCust.Rows(rowChanging)("Precio") = CDbl(DetallesProducto.Costo).ToString(RoundP)
                        Else
                            tCust.Rows(rowChanging)("Precio") = CDbl(dsItemCC.Tables("Tabla").Rows(0).Item("Articulo_Costo")).ToString(RoundP)
                        End If

                        'If TipoDescuento = "A" Then
                        '    tCust.Rows(rowChanging)("Descuento") = CDbl(DetallesProducto.Descuento_A).ToString(Round)
                        'ElseIf TipoDescuento = "B" Then
                        '    tCust.Rows(rowChanging)("Descuento") = CDbl(DetallesProducto.Descuento_B).ToString(Round)
                        'ElseIf TipoDescuento = "C" Then
                        '    tCust.Rows(rowChanging)("Descuento") = CDbl(DetallesProducto.Descuento_C).ToString(Round)
                        'Else
                        '    tCust.Rows(rowChanging)("Descuento") = "0.00"
                        'End If

                        tCust.Rows(rowChanging)("Tipo") = ItemTipo.ColumnComboBox.Items.Item(Indice)
                    Else
                        tCust.Rows(rowChanging)("CodigoTemporal") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("ArticuloCodigo") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Articulo") = Articulo.ColumnComboBox.Items.Item(Indice)
                        'tCust.Rows(rowChanging)("Cantidad") = 1

                        If Me.rbProductos.Checked = True Then
                            tCust.Rows(rowChanging)("Precio") = CDbl(DetallesProducto.Costo).ToString(RoundP)
                        Else
                            tCust.Rows(rowChanging)("Precio") = CDbl(dsItemCC.Tables("Tabla").Rows(0).Item("Articulo_Costo")).ToString(RoundP)
                        End If

                        'tCust.Rows(rowChanging)("Precio") = CDbl(DetallesProducto.Costo).ToString(Round)

                        'If TipoDescuento = "A" Then
                        '    tCust.Rows(rowChanging)("Descuento") = CDbl(DetallesProducto.Descuento_A).ToString(Round)
                        'ElseIf TipoDescuento = "B" Then
                        '    tCust.Rows(rowChanging)("Descuento") = CDbl(DetallesProducto.Descuento_B).ToString(Round)
                        'ElseIf TipoDescuento = "C" Then
                        '    tCust.Rows(rowChanging)("Descuento") = CDbl(DetallesProducto.Descuento_C).ToString(Round)
                        'Else
                        '    tCust.Rows(rowChanging)("Descuento") = "0.00"
                        'End If

                        tCust.Rows(rowChanging)("Tipo") = ItemTipo.ColumnComboBox.Items.Item(Indice)
                    End If

                End If
            Catch ex As Exception
                MsgBox(ex.Message & "MyComboValueChanged")
            End Try

        End Sub

        Private Sub tCust_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles tCust.ColumnChanged

            'If e.Column.Ordinal = 0 And ArticuloCodigo.ColumnComboBox.SelectedIndex >= 0 Then
            '    'DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(Articulo.ColumnComboBox.Items.Item(ArticuloCodigo.ColumnComboBox.SelectedIndex), EmpresaActual)

            '    e.Row.Item(1) = Articulo.ColumnComboBox.Items.Item(ArticuloCodigo.ColumnComboBox.SelectedIndex)
            '    'e.Row.Item(6) = Articulo.ColumnComboBox.Items.Item(ArticuloCodigo.ColumnComboBox.SelectedIndex)
            '    'e.Row.Item(3) = CDbl(DetallesProducto.Precio_Venta_Cordobas).ToString(Round)

            'End If
            'If e.Column.Ordinal = 1 And Articulo.ColumnComboBox.SelectedIndex >= 0 Then
            '    DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(ArticuloCodigo.ColumnComboBox.Items.Item(Articulo.ColumnComboBox.SelectedIndex), EmpresaActual)
            '    'ArticuloCodigo.ColumnComboBox.SelectedIndex = Articulo.ColumnComboBox.SelectedIndex
            '    e.Row.Item(0) = ArticuloCodigo.ColumnComboBox.Items.Item(Articulo.ColumnComboBox.SelectedIndex)
            '    e.Row.Item(6) = ArticuloCodigo.ColumnComboBox.Items.Item(Articulo.ColumnComboBox.SelectedIndex)
            '    e.Row.Item(3) = CDbl(DetallesProducto.Precio_Venta_Cordobas).ToString(Round)

            'End If

            Dim Descuento As Double

            '''If e.Column.Ordinal = 2 Then
            '''    If e.Row.Item(7).ToString = "P" Then
            '''        DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(e.Row.Item(0).ToString, e.Row.Item(7).ToString, EmpresaActual)
            '''        If DetallesProducto.Existencia Is Nothing Or DetallesProducto.Existencia Is DBNull.Value Then
            '''            '
            '''        ElseIf DetallesProducto.Existencia = 0 Then
            '''            MsgBox("No hay existencias...", MsgBoxStyle.Critical)
            '''            Exit Sub
            '''        ElseIf CDbl(e.Row.Item(2).ToString) > CDbl(DetallesProducto.Existencia) Then
            '''            MsgBox("La cantidad es mayor que la existencia actual", MsgBoxStyle.Critical)
            '''            Exit Sub
            '''        End If

            '''    Else
            '''        '

            '''    End If


            '''End If


            If Not IsNumeric(e.Row.Item(2)) Then
                e.Row.Item(2) = ValorActualCantidad
                'Else
                '    If CDbl(e.Row.Item(2)) <= 0 Then
                '        e.Row.Item(2) = ValorActualCantidad
                '    End If
            End If

            If Not IsNumeric(e.Row.Item(3)) Then
                e.Row.Item(3) = ValorActualPrecio.ToString(RoundP)
            End If

            If Not IsNumeric(e.Row.Item(4)) Then
                e.Row.Item(4) = ValorActualDescuento.ToString(Round)
            End If

            If e.Column.Ordinal = 2 Or e.Column.Ordinal = 3 Or e.Column.Ordinal = 4 Then
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

            End If

            SubTotalFacturaCliente = 0
            SubTotalFacturaNoDescuentos = 0
            TotalFacturaCliente = 0
            TotalDescuento = 0

            For i = 0 To tCust.Rows.Count - 1

                If tCust.Rows(i)("SubTotal") Is DBNull.Value Or tCust.Rows(i)("SubTotal").ToString = "" Or tCust.Rows(i)("SubTotal").ToString = "0.00" Then

                ElseIf IsNumeric(tCust.Rows(i)("SubTotal")) And tCust.Rows(i)("SubTotal").ToString <> "" Then
                    Try
                        SubTotalFacturaCliente = SubTotalFacturaCliente + tCust.Rows(i)("SubTotal")
                        SubTotalFacturaNoDescuentos = SubTotalFacturaNoDescuentos + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio"))
                        TotalDescuento = TotalDescuento + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio") * tCust.Rows(i)("Descuento") / 100)
                    Catch ex As Exception
                        MsgBox(ex.Message)

                    End Try

                End If

            Next

            'etSubTotal.Text = SubTotalFacturaCliente.ToString(Round)
            etSubTotal.Text = SubTotalFacturaNoDescuentos.ToString(Round)
            'etIva.Text = (SubTotalFacturaNoDescuentos * 0.15).ToString(Round)
            etIva.Text = (SubTotalFacturaNoDescuentos * (ConfigDetalles.IVA / 100.0)).ToString(Round)
            etTotal.Text = (SubTotalFacturaCliente + CDbl(etIva.Text)).ToString(Round)

            'etSaldo.Text = (CDbl(etTotal.Text) - TotalGlobal).ToString(Round)

            TotalFactura = etTotal.Text

        End Sub

        Private Sub tCust_RowDeleted(ByVal sender As Object, ByVal e As System.Data.DataRowChangeEventArgs) Handles tCust.RowDeleted
            SubTotalFacturaCliente = 0
            SubTotalFacturaNoDescuentos = 0
            TotalFacturaCliente = 0
            TotalDescuento = 0

            For i = 0 To tCust.Rows.Count - 1
                'If e.Row.Item(5) Is DBNull.Value Or e.Row.Item(5).ToString = "" Or e.Row.Item(5).ToString = "0.00" Then

                'ElseIf IsNumeric(e.Row.Item(5)) And e.Row.Item(5).ToString <> "" Then
                '    Try 'MsgBox(tCust.Rows(i)("SubTotal").ToString)
                '        SubTotalFacturaCliente = SubTotalFacturaCliente + tCust.Rows(i)("SubTotal")
                '    Catch
                '        'e.Row.Delete()
                '    End Try

                'End If

                If tCust.Rows(i)("SubTotal") Is DBNull.Value Or tCust.Rows(i)("SubTotal").ToString = "" Or tCust.Rows(i)("SubTotal").ToString = "0.00" Then

                ElseIf IsNumeric(tCust.Rows(i)("SubTotal")) And tCust.Rows(i)("SubTotal").ToString <> "" Then
                    Try 'MsgBox(tCust.Rows(i)("SubTotal").ToString)
                        SubTotalFacturaCliente = SubTotalFacturaCliente + tCust.Rows(i)("SubTotal")
                        SubTotalFacturaNoDescuentos = SubTotalFacturaNoDescuentos + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio"))
                        TotalDescuento = TotalDescuento + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio") * tCust.Rows(i)("Descuento") / 100)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'e.Row.Delete()
                    End Try

                End If

            Next

            'etSubTotal.Text = SubTotalFacturaCliente.ToString(Round)
            etSubTotal.Text = SubTotalFacturaNoDescuentos.ToString(Round)
            etIva.Text = (SubTotalFacturaNoDescuentos * (ConfigDetalles.IVA / 100.0)).ToString(Round)
            etTotal.Text = (SubTotalFacturaCliente + CDbl(etIva.Text)).ToString(Round)

            'etSaldo.Text = (CDbl(etTotal.Text) - TotalGlobal).ToString(Round)

            TotalFactura = CDbl(etTotal.Text).ToString(Round)

        End Sub

        Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
            Try
                If Guardar() = False Then
                    Exit Sub
                End If

                VB.SysContab.Rutinas.okTransaccion()
                Me.Close()

                'LimpiarControles()
                'CargarPedido = False
                'RestablecerDataset()
            Catch ex As Exception
                VB.SysContab.Rutinas.ErrorTransaccion()
                MsgBox(ex.Message & "Aceptar")
                Exit Sub
            End Try

        End Sub

        Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
            Me.Close()
        End Sub

        'Funcion para guardar los datos de la factura
        Private Function Guardar() As Boolean
            If Trim(cbProveedor.Text) = "" Then
                MsgBox("Seleccione el Proveedor", MsgBoxStyle.Critical)
                cbProveedor.Focus()
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
                dgFacturas.Focus()
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
                    dgFacturas.Select(i)
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

                    dgFacturas.Select(i)
                    Return False
                    Exit Function
                End If
            Next

            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction

            Try
                If Me.rbInventario.Checked = True Then
                    'txtFactura.Text = Facturas.OrdenCompraCCNumero
                    Facturas.OrdenCompraCCUpdate(txtFactura.Text, dtpFecha.Value, dtpFechaPago.Value, cbProveedor.SelectedValue, etSubTotal.Text, etIva.Text, _
                                              etTotal.Text, cbTipoFactura.SelectedValue, Tipo, 1, txtFactura.Text, 0)

                Else
                    'txtFactura.Text = Facturas.Numero
                    Facturas.OrdenCompraUpdate(txtFactura.Text, dtpFecha.Value, dtpFechaPago.Value, cbProveedor.SelectedValue, CDbl(etSubTotal.Text), CDbl(etIva.Text), _
                                     CDbl(etTotal.Text), cbTipoFactura.SelectedValue, Tipo, 1, txtFactura.Text, 0)
                End If

                Facturas.OrdenComprasDetalleDelete(Me.txtFactura.Text, Me.Destino)

                Dim Descuento As Double
                Dim Comision As Double
                Dim Comisiones As New VB.SysContab.ComisionDB()

                If Me.rbInventario.Checked = True Then
                    For i = 0 To tCust.Rows.Count - 1
                        If tCust.Rows(i)("Descuento") Is DBNull.Value Then
                            Descuento = 0
                        Else
                            Descuento = tCust.Rows(i)("Descuento")
                        End If
                        Facturas.OrdenesComprasCCLineasAdd(txtFactura.Text, tCust.Rows(i)("ArticuloCodigo"), tCust.Rows(i)("Cantidad"), tCust.Rows(i)("Precio"), ConfigDetalles.IVA, (CDbl(tCust.Rows(i)("Cantidad")) * CDbl(tCust.Rows(i)("Precio")) - Descuento) * ConfigDetalles.IVA / 100.0)
                    Next
                Else
                    For i = 0 To tCust.Rows.Count - 1
                        If tCust.Rows(i)("Descuento") Is DBNull.Value Then
                            Descuento = 0
                        Else
                            Descuento = tCust.Rows(i)("Descuento")
                        End If
                        Facturas.AddFacturaLineas(txtFactura.Text, tCust.Rows(i)("ArticuloCodigo"), tCust.Rows(i)("Cantidad"),
                                                  tCust.Rows(i)("Precio"), Descuento,
                                                  (CDbl(tCust.Rows(i)("Cantidad")) * CDbl(tCust.Rows(i)("Precio")) - Descuento) * ConfigDetalles.IVA / 100.0, tCust.Rows(i)("Tipo"), "")
                    Next

                    'If CargarPedido = True Then
                    '    Facturas.PedidosUpdateEstado(Pedido, "F", txtFactura.Text, TipoPedido)
                    'End If

                End If

            Catch ex As Exception
                MsgBox(ex.Message & "Guardar")
                VB.SysContab.Rutinas.ErrorTransaccion()
                Return False
                Exit Function
            End Try
            VB.SysContab.Rutinas.okTransaccion()
            Return True

        End Function

        Private Sub dgFacturas_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFacturas.CurrentCellChanged
            Try
                ValorActualCantidad = tCust.Rows(dgFacturas.CurrentRowIndex)("Cantidad")
                ValorActualPrecio = tCust.Rows(dgFacturas.CurrentRowIndex)("Precio")
                ValorActualDescuento = tCust.Rows(dgFacturas.CurrentRowIndex)("Descuento")
            Catch ex As Exception
                Exit Sub
            End Try
        End Sub

        Private Sub dgFacturas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFacturas.DoubleClick
            If tCust.Rows.Count = 0 Then
                MsgBox("Seleccione el Producto o Servicio", MsgBoxStyle.Information)
                Exit Sub
            End If

            If dgFacturas.Item(dgFacturas.CurrentRowIndex, 0) Is DBNull.Value Then
                MsgBox("Seleccione el Producto o Servicio", MsgBoxStyle.Information)
                Exit Sub
            End If

            Dim f As frmDetalleArticulo = f.Instance

            Registro = dgFacturas.Item(dgFacturas.CurrentRowIndex, 0)

            f.MdiParent = Me.MdiParent
            f.Show()
        End Sub

        Private Sub LimpiarControles()
            etSubTotal.Text = "0.00"
            etIva.Text = "0.00"
            etTotal.Text = "0.00"

            TotalCheques = 0
            TotalTarjetas = 0
            TotalEfectivo = 0
            TotalNotaDebito = 0
            TotalFactura = 0

            txtPedido.Text = ""

            TotalGlobal = 0
        End Sub

        Private Sub RestablecerDataset()
            MakeDataSet()
            dgFacturas.SetDataBinding(myDataSet, "Articulos")
            AddCustomDataTableStyle()

            Inicio = True
            cbTipoFactura.SelectedValue = 0
            Inicio = False

            r.ComboAutoComplete(Articulo.ColumnComboBox)
            r.ComboAutoComplete(ArticuloCodigo.ColumnComboBox)
        End Sub

        Private Sub cbTipoFactura_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTipoFactura.SelectedValueChanged
            Try
                If IsNumeric(cbTipoFactura.SelectedValue) Then
                    If Inicio = True Then
                        Exit Sub
                    End If

                    If cbTipoFactura.SelectedValue = 0 Then
                    Else
                        TipoFactura = cbTipoFactura.SelectedValue.ToString
                        dtpFechaPago.Value = dtpFecha.Value.AddDays(FormaPago.FormaPagoDias(cbTipoFactura.SelectedValue))
                    End If
                End If
            Catch ex As Exception
            End Try

        End Sub

        Private Sub cmdPedidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPedidos.Click
            Dim f As New frmPedidosList()
            Dim TipoPedido As Integer

            f.Proveedor = cbProveedor.SelectedValue
            f.WindowState = FormWindowState.Normal
            f.StartPosition = FormStartPosition.CenterScreen
            f.ShowDialog()

            If f.Salir = True Then
                Exit Sub
            Else
                CargarPedido = True
                Pedido = f.dgPedidos.Item(f.dgPedidos.CurrentRowIndex, 0)
                TipoPedido = f.dgPedidos.Item(f.dgPedidos.CurrentRowIndex, 8)


                ds = Pedidos.PedidoDetalle(Pedido, TipoPedido)

                Me.txtPedido.Text = Pedido

                If ds.Tables("Pedidos").Rows.Count = 0 Then
                    Exit Sub
                End If

                Me.cbProveedor.SelectedValue = ds.Tables("Pedidos").Rows(0).Item("Proveedor_ID")
            End If

            MakeDataSet()
            Me.dgFacturas.SetDataBinding(myDataSet, "Articulos")
            AddCustomDataTableStyle()

        End Sub

        Private Sub cmdConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsulta.Click

            If tCust.Rows.Count > 0 Then
                If tCust.Rows(tCust.Rows.Count - 1)("ArticuloCodigo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Articulo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Precio") Is DBNull.Value Then
                    tCust.Rows(tCust.Rows.Count - 1).Delete()
                End If
            End If
            If Me.rbProductos.Checked = True Then
                Dim f As frmBuscarItem = f.Instance
                f.MdiParent = Me.MdiParent
                f.Show()
            Else
                Dim f As frmBuscarItemCC = f.Instance
                f.etInicio.Text = "1"
                f.MdiParent = Me.MdiParent
                f.Show()
                f.etInicio.Text = "0"
            End If

        End Sub

        Private Sub AgregarItem()
            Dim k As Integer
            Dim t As Integer

            If tItem.Rows.Count <> 0 Then
                For k = 0 To tItem.Rows.Count - 1

                    For t = 0 To tCust.Rows.Count - 1

                        If tCust.Rows(t)("ArticuloCodigo") = tItem.Rows(k)("Codigo") And tCust.Rows(t)("Tipo") = tItem.Rows(k)("Tipo") Then
                            tCust.Rows(t)("Cantidad") = CDbl(tCust.Rows(t)("Cantidad")) + CDbl(tItem.Rows(k)("Cantidad"))
                            Exit For

                        End If

                    Next

                    If t = tCust.Rows.Count Then
                        Dim newRow1 As DataRow
                        newRow1 = tCust.NewRow
                        newRow1("ArticuloCodigo") = tItem.Rows(k)("Codigo")
                        tCust.Rows.Add(newRow1)

                        tCust.Rows(tCust.Rows.Count - 1)("Articulo") = tItem.Rows(k)("Descripcion")
                        tCust.Rows(tCust.Rows.Count - 1)("Cantidad") = tItem.Rows(k)("Cantidad")
                        tCust.Rows(tCust.Rows.Count - 1)("Precio") = CDbl(tItem.Rows(k)("Costo")).ToString(RoundP)
                        tCust.Rows(tCust.Rows.Count - 1)("Tipo") = tItem.Rows(k)("Tipo")

                    End If
                Next
                tItem.Clear()
                ArticuloCodigo.ColumnComboBox.Focus()

            End If

        End Sub

        Private Sub etTotalT_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles etTotalT.MouseEnter

            AgregarItem()
        End Sub

        Private Sub frmFacturasCompra_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter

            AgregarItem()
        End Sub

        Private Sub dgFacturas_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFacturas.MouseEnter

            AgregarItem()
        End Sub

        Private Sub txtDireccion_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDireccion.MouseEnter

            AgregarItem()
        End Sub

        Private Sub cmdAceptar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.MouseEnter

            AgregarItem()
        End Sub

        Private Sub cbProveedor_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbProveedor.MouseEnter

            AgregarItem()
        End Sub

        Private Sub gbBotones_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles gbBotones.MouseEnter

            AgregarItem()
        End Sub

        Private Sub gbTipo_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)

            AgregarItem()
        End Sub

        Private Sub GroupBox3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupBox3.MouseEnter

            AgregarItem()
        End Sub

        Private Sub cmdConsultaProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultaProveedores.Click
            If Me.cbProveedor.Text = "" Then
                MsgBox("Seleccione el Proveedor", MsgBoxStyle.Information)
                Me.cbProveedor.Focus()
                Exit Sub
            End If

            If Me.cbProveedor.SelectedValue = Nothing Then
                MsgBox("El Proveedor no está registrado", MsgBoxStyle.Information)
                Me.cbProveedor.Focus()
                Exit Sub
            End If

            Dim f As frmAcumuladosProveedor = f.Instance

            f.Proveedor = Me.cbProveedor.SelectedValue

            f.MdiParent = Me.MdiParent
            f.Show()

        End Sub

        Private Sub cbProveedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbProveedor.KeyDown
            If e.KeyData = Keys.Enter Then
                Me.dgFacturas.Focus()
            End If
        End Sub

    End Class

End Namespace

'Economart.
'Plaza españa
'DBA 

'Economart. Managua, Rotonda el Güegüense, 1/2c al lago, (505) 268-3499.
'Eduardo Internacional. Masaya, Barrio el Repliegue. Escuela Hermanos del Japón, ...

