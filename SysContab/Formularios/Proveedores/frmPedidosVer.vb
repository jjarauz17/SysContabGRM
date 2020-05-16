Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace DataGridTextBoxCombo
    Public Class frmPedidosVer
        Inherits DevExpress.XtraEditors.XtraForm
        Private Shared ChildInstance As frmPedidosVer = Nothing

        Public Shared Function Instance() As frmPedidosVer
            If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
                ChildInstance = New frmPedidosVer()
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
        Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaEntrega As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtPedido As System.Windows.Forms.TextBox
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents cbProveedor As System.Windows.Forms.ComboBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents gbBotones As System.Windows.Forms.GroupBox
        Friend WithEvents cmdConsultaClientes As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdConsulta As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
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
        Friend WithEvents dgPedidos As System.Windows.Forms.DataGrid
        Friend WithEvents gbTipo As System.Windows.Forms.GroupBox
        Friend WithEvents rbActivo As System.Windows.Forms.RadioButton
        Friend WithEvents rbInventario As System.Windows.Forms.RadioButton
        Friend WithEvents rbProductos As System.Windows.Forms.RadioButton
        Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents Label18 As System.Windows.Forms.Label
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.dtpFecha = New System.Windows.Forms.DateTimePicker
            Me.dtpFechaEntrega = New System.Windows.Forms.DateTimePicker
            Me.txtPedido = New System.Windows.Forms.TextBox
            Me.Label24 = New System.Windows.Forms.Label
            Me.Label11 = New System.Windows.Forms.Label
            Me.Label7 = New System.Windows.Forms.Label
            Me.cbProveedor = New System.Windows.Forms.ComboBox
            Me.Label1 = New System.Windows.Forms.Label
            Me.GroupBox3 = New System.Windows.Forms.GroupBox
            Me.gbTipo = New System.Windows.Forms.GroupBox
            Me.rbActivo = New System.Windows.Forms.RadioButton
            Me.rbInventario = New System.Windows.Forms.RadioButton
            Me.rbProductos = New System.Windows.Forms.RadioButton
            Me.TextBox6 = New System.Windows.Forms.TextBox
            Me.Label12 = New System.Windows.Forms.Label
            Me.Label17 = New System.Windows.Forms.Label
            Me.Label18 = New System.Windows.Forms.Label
            Me.gbBotones = New System.Windows.Forms.GroupBox
            Me.cmdConsultaClientes = New DevExpress.XtraEditors.SimpleButton
            Me.cmdConsulta = New DevExpress.XtraEditors.SimpleButton
            Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
            Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
            Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
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
            Me.dgPedidos = New System.Windows.Forms.DataGrid
            Me.GroupBox3.SuspendLayout()
            Me.gbTipo.SuspendLayout()
            Me.gbBotones.SuspendLayout()
            CType(Me.dgPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dtpFecha
            '
            Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFecha.Location = New System.Drawing.Point(704, 9)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
            Me.dtpFecha.TabIndex = 151
            '
            'dtpFechaEntrega
            '
            Me.dtpFechaEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaEntrega.Location = New System.Drawing.Point(912, 9)
            Me.dtpFechaEntrega.Name = "dtpFechaEntrega"
            Me.dtpFechaEntrega.Size = New System.Drawing.Size(96, 20)
            Me.dtpFechaEntrega.TabIndex = 152
            '
            'txtPedido
            '
            Me.txtPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPedido.Location = New System.Drawing.Point(504, 8)
            Me.txtPedido.MaxLength = 50
            Me.txtPedido.Name = "txtPedido"
            Me.txtPedido.ReadOnly = True
            Me.txtPedido.Size = New System.Drawing.Size(128, 20)
            Me.txtPedido.TabIndex = 149
            '
            'Label24
            '
            Me.Label24.BackColor = System.Drawing.Color.Transparent
            Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label24.Location = New System.Drawing.Point(16, 8)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(88, 25)
            Me.Label24.TabIndex = 145
            Me.Label24.Text = "Proveedor:"
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.Transparent
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label11.Location = New System.Drawing.Point(800, 9)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(112, 25)
            Me.Label11.TabIndex = 150
            Me.Label11.Text = "Fecha Entrega:"
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.Transparent
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label7.Location = New System.Drawing.Point(432, 8)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(72, 25)
            Me.Label7.TabIndex = 148
            Me.Label7.Text = "No. Pedido:"
            '
            'cbProveedor
            '
            Me.cbProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbProveedor.Location = New System.Drawing.Point(104, 8)
            Me.cbProveedor.Name = "cbProveedor"
            Me.cbProveedor.Size = New System.Drawing.Size(320, 21)
            Me.cbProveedor.TabIndex = 144
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(640, 8)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(64, 25)
            Me.Label1.TabIndex = 146
            Me.Label1.Text = "Fecha:"
            '
            'GroupBox3
            '
            Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
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
            Me.GroupBox3.Controls.Add(Me.dgPedidos)
            Me.GroupBox3.Location = New System.Drawing.Point(16, 33)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(992, 481)
            Me.GroupBox3.TabIndex = 147
            Me.GroupBox3.TabStop = False
            '
            'gbTipo
            '
            Me.gbTipo.BackColor = System.Drawing.Color.Transparent
            Me.gbTipo.Controls.Add(Me.rbActivo)
            Me.gbTipo.Controls.Add(Me.rbInventario)
            Me.gbTipo.Controls.Add(Me.rbProductos)
            Me.gbTipo.Controls.Add(Me.TextBox6)
            Me.gbTipo.Controls.Add(Me.Label12)
            Me.gbTipo.Controls.Add(Me.Label17)
            Me.gbTipo.Controls.Add(Me.Label18)
            Me.gbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipo.ForeColor = System.Drawing.Color.Maroon
            Me.gbTipo.Location = New System.Drawing.Point(8, 103)
            Me.gbTipo.Name = "gbTipo"
            Me.gbTipo.Size = New System.Drawing.Size(291, 35)
            Me.gbTipo.TabIndex = 132
            Me.gbTipo.TabStop = False
            '
            'rbActivo
            '
            Me.rbActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbActivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.rbActivo.Location = New System.Drawing.Point(216, 9)
            Me.rbActivo.Name = "rbActivo"
            Me.rbActivo.Size = New System.Drawing.Size(64, 17)
            Me.rbActivo.TabIndex = 126
            Me.rbActivo.Text = "Activo"
            Me.rbActivo.Visible = False
            '
            'rbInventario
            '
            Me.rbInventario.BackColor = System.Drawing.Color.Transparent
            Me.rbInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbInventario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.rbInventario.Location = New System.Drawing.Point(112, 9)
            Me.rbInventario.Name = "rbInventario"
            Me.rbInventario.Size = New System.Drawing.Size(88, 17)
            Me.rbInventario.TabIndex = 125
            Me.rbInventario.Text = "Inventario"
            Me.rbInventario.UseVisualStyleBackColor = False
            '
            'rbProductos
            '
            Me.rbProductos.Checked = True
            Me.rbProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbProductos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.rbProductos.Location = New System.Drawing.Point(16, 9)
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
            'gbBotones
            '
            Me.gbBotones.BackColor = System.Drawing.Color.Transparent
            Me.gbBotones.Controls.Add(Me.cmdConsultaClientes)
            Me.gbBotones.Controls.Add(Me.cmdConsulta)
            Me.gbBotones.Controls.Add(Me.cmdImprimir)
            Me.gbBotones.Controls.Add(Me.cmdCancelar)
            Me.gbBotones.Controls.Add(Me.cmdAceptar)
            Me.gbBotones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBotones.ForeColor = System.Drawing.Color.Maroon
            Me.gbBotones.Location = New System.Drawing.Point(888, 103)
            Me.gbBotones.Name = "gbBotones"
            Me.gbBotones.Size = New System.Drawing.Size(88, 327)
            Me.gbBotones.TabIndex = 130
            Me.gbBotones.TabStop = False
            '
            'cmdConsultaClientes
            '
            Me.cmdConsultaClientes.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdConsultaClientes.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdConsultaClientes.Appearance.Options.UseFont = True
            Me.cmdConsultaClientes.Appearance.Options.UseForeColor = True
            Me.cmdConsultaClientes.Location = New System.Drawing.Point(8, 146)
            Me.cmdConsultaClientes.Name = "cmdConsultaClientes"
            Me.cmdConsultaClientes.Size = New System.Drawing.Size(72, 26)
            Me.cmdConsultaClientes.TabIndex = 33
            Me.cmdConsultaClientes.Text = "Pro&veedor"
            '
            'cmdConsulta
            '
            Me.cmdConsulta.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdConsulta.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdConsulta.Appearance.Options.UseFont = True
            Me.cmdConsulta.Appearance.Options.UseForeColor = True
            Me.cmdConsulta.Location = New System.Drawing.Point(8, 103)
            Me.cmdConsulta.Name = "cmdConsulta"
            Me.cmdConsulta.Size = New System.Drawing.Size(72, 26)
            Me.cmdConsulta.TabIndex = 31
            Me.cmdConsulta.Text = "&Productos"
            '
            'cmdImprimir
            '
            Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdImprimir.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdImprimir.Appearance.Options.UseFont = True
            Me.cmdImprimir.Appearance.Options.UseForeColor = True
            Me.cmdImprimir.Location = New System.Drawing.Point(8, 60)
            Me.cmdImprimir.Name = "cmdImprimir"
            Me.cmdImprimir.Size = New System.Drawing.Size(72, 26)
            Me.cmdImprimir.TabIndex = 30
            Me.cmdImprimir.Text = "&Imprimir"
            '
            'cmdCancelar
            '
            Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdCancelar.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdCancelar.Appearance.Options.UseFont = True
            Me.cmdCancelar.Appearance.Options.UseForeColor = True
            Me.cmdCancelar.Location = New System.Drawing.Point(8, 279)
            Me.cmdCancelar.Name = "cmdCancelar"
            Me.cmdCancelar.Size = New System.Drawing.Size(72, 26)
            Me.cmdCancelar.TabIndex = 29
            Me.cmdCancelar.Text = "&Salir"
            '
            'cmdAceptar
            '
            Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdAceptar.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdAceptar.Appearance.Options.UseFont = True
            Me.cmdAceptar.Appearance.Options.UseForeColor = True
            Me.cmdAceptar.Location = New System.Drawing.Point(8, 17)
            Me.cmdAceptar.Name = "cmdAceptar"
            Me.cmdAceptar.Size = New System.Drawing.Size(72, 26)
            Me.cmdAceptar.TabIndex = 28
            Me.cmdAceptar.Text = "&Grabar"
            '
            'txtMunicipio
            '
            Me.txtMunicipio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMunicipio.Location = New System.Drawing.Point(752, 69)
            Me.txtMunicipio.MaxLength = 50
            Me.txtMunicipio.Name = "txtMunicipio"
            Me.txtMunicipio.ReadOnly = True
            Me.txtMunicipio.Size = New System.Drawing.Size(224, 20)
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
            Me.txtDireccion.Size = New System.Drawing.Size(280, 35)
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
            Me.txtTelefono.Size = New System.Drawing.Size(224, 20)
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
            Me.cbMunicipios.Location = New System.Drawing.Point(448, 319)
            Me.cbMunicipios.Name = "cbMunicipios"
            Me.cbMunicipios.Size = New System.Drawing.Size(224, 22)
            Me.cbMunicipios.TabIndex = 121
            Me.cbMunicipios.Visible = False
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.Transparent
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label5.Location = New System.Drawing.Point(672, 69)
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
            Me.cbDepartamentos.Location = New System.Drawing.Point(448, 284)
            Me.cbDepartamentos.Name = "cbDepartamentos"
            Me.cbDepartamentos.Size = New System.Drawing.Size(224, 23)
            Me.cbDepartamentos.TabIndex = 119
            Me.cbDepartamentos.Visible = False
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.Transparent
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
            Me.Label2.BackColor = System.Drawing.Color.Transparent
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
            Me.Label9.BackColor = System.Drawing.Color.Transparent
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
            Me.Label4.BackColor = System.Drawing.Color.Transparent
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
            Me.Label3.BackColor = System.Drawing.Color.Transparent
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
            Me.etTotal.BackColor = System.Drawing.Color.Transparent
            Me.etTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTotal.ForeColor = System.Drawing.Color.Maroon
            Me.etTotal.Location = New System.Drawing.Point(688, 433)
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
            Me.etTotalT.Location = New System.Drawing.Point(624, 442)
            Me.etTotalT.Name = "etTotalT"
            Me.etTotalT.Size = New System.Drawing.Size(56, 26)
            Me.etTotalT.TabIndex = 109
            Me.etTotalT.Text = "Total:"
            Me.etTotalT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dgPedidos
            '
            Me.dgPedidos.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
            Me.dgPedidos.BackColor = System.Drawing.Color.Gainsboro
            Me.dgPedidos.BackgroundColor = System.Drawing.Color.DarkGray
            Me.dgPedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.dgPedidos.CaptionBackColor = System.Drawing.Color.DarkKhaki
            Me.dgPedidos.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            Me.dgPedidos.CaptionForeColor = System.Drawing.Color.Black
            Me.dgPedidos.DataMember = ""
            Me.dgPedidos.FlatMode = True
            Me.dgPedidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgPedidos.ForeColor = System.Drawing.Color.Black
            Me.dgPedidos.GridLineColor = System.Drawing.Color.Silver
            Me.dgPedidos.HeaderBackColor = System.Drawing.Color.Black
            Me.dgPedidos.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            Me.dgPedidos.HeaderForeColor = System.Drawing.Color.White
            Me.dgPedidos.LinkColor = System.Drawing.Color.DarkSlateBlue
            Me.dgPedidos.Location = New System.Drawing.Point(8, 138)
            Me.dgPedidos.Name = "dgPedidos"
            Me.dgPedidos.ParentRowsBackColor = System.Drawing.Color.LightGray
            Me.dgPedidos.ParentRowsForeColor = System.Drawing.Color.Black
            Me.dgPedidos.SelectionBackColor = System.Drawing.Color.Firebrick
            Me.dgPedidos.SelectionForeColor = System.Drawing.Color.White
            Me.dgPedidos.Size = New System.Drawing.Size(872, 292)
            Me.dgPedidos.TabIndex = 27
            '
            'frmPedidosVer
            '
            Me.Appearance.BackColor = System.Drawing.SystemColors.Control
            Me.Appearance.Options.UseBackColor = True
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(1016, 526)
            Me.Controls.Add(Me.dtpFecha)
            Me.Controls.Add(Me.dtpFechaEntrega)
            Me.Controls.Add(Me.txtPedido)
            Me.Controls.Add(Me.Label24)
            Me.Controls.Add(Me.Label11)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.cbProveedor)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.GroupBox3)
            Me.Name = "frmPedidosVer"
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.gbTipo.ResumeLayout(False)
            Me.gbTipo.PerformLayout()
            Me.gbBotones.ResumeLayout(False)
            CType(Me.dgPedidos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Dim Pedidos As New VB.SysContab.PedidosDB()
        Dim Articulos As New VB.SysContab.ArticulosDB()
        Dim DetallesProducto As New VB.SysContab.ArticulosDetails()
        Dim Proveedores As New VB.SysContab.ProveedoresDB()
        Dim ArticulosCC As New VB.SysContab.GruposCCDB()

        Dim ds As DataSet
        Dim WithEvents tCust As DataTable
        Private WithEvents myDataSet As DataSet
        Dim WithEvents Articulo As DataGridComboBoxColumn
        Dim WithEvents ArticuloCodigo As DataGridComboBoxColumn
        Dim WithEvents ItemTipo As DataGridComboBoxColumn
        Dim Cantidad As DataGridTextBoxColumn

        Dim ValorActualCantidad As Double

        Dim r As New VB.SysContab.Rutinas()

        'Dim j As Integer
        Dim i As Integer

        Dim dsItems As DataSet
        Dim Tipo As Integer

        Public Inicio As Boolean

        Public TipoPedido As Integer

        Private Sub frmPedidosVer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            r.FormularioColor(Me)
            'r.CambiarEstilo(Me)

            ds = Pedidos.PedidoDetalle(RegistroPedido, TipoPedido)

            cbProveedor.DataSource = Proveedores.ProveedoresList(3).Tables("Proveedores")
            cbProveedor.ValueMember = "Codigo"
            cbProveedor.DisplayMember = "Nombre"

            r.ComboAutoComplete(Me.cbProveedor)

            cbProveedor.SelectedValue = ds.Tables("Pedidos").Rows(0).Item("Proveedor_ID")

            dtpFecha.Value = ds.Tables("Pedidos").Rows(0).Item("Ped_Fecha")
            dtpFecha.Enabled = False

            dtpFechaEntrega.Value = ds.Tables("Pedidos").Rows(0).Item("Ped_FechaEntrega")
            dtpFechaEntrega.Enabled = False

            txtPedido.Text = ds.Tables("Pedidos").Rows(0).Item("Ped_ID")
            txtPedido.ReadOnly = True

            Tipo = ds.Tables("Pedidos").Rows(0).Item("Ped_Tipo")

            If ds.Tables("Pedidos").Rows(0).Item("Ped_Estado") = "F" Then
                dgPedidos.ReadOnly = True
                cbProveedor.Enabled = False
                cmdAceptar.Enabled = False
                cmdConsulta.Enabled = False
                Me.gbTipo.Enabled = False
            End If

            TipoItem = "P"

            Indice = -1

            If Me.TipoPedido = 2 Then
                Me.rbInventario.Checked = True
            Else
                Me.rbProductos.Checked = True
            End If

            MakeDataSet()
            dgPedidos.SetDataBinding(myDataSet, "Articulos")
            AddCustomDataTableStyle()


            If ds.Tables("Pedidos").Rows(0).Item("Ped_Estado") = "P" Then
                r.ComboAutoComplete(Articulo.ColumnComboBox)
                r.ComboAutoComplete(ArticuloCodigo.ColumnComboBox)
            End If

            Me.Text = "P e d i d o s"
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

            Dim cCosto As DataColumn
            cCosto = New DataColumn("Costo")

            'Dim cDescuento As DataColumn
            'cDescuento = New DataColumn("Descuento")

            Dim cSubTotal As DataColumn
            cSubTotal = New DataColumn("SubTotal")

            'Dim cCodigoTemporal As DataColumn
            'cCodigoTemporal = New DataColumn("CodigoTemporal")

            Dim cItemTipo As DataColumn
            cItemTipo = New DataColumn("Tipo")

            tCust.Columns.Add(cArticuloCodigo)
            tCust.Columns.Add(cArticulo)
            tCust.Columns.Add(cCantidad)
            tCust.Columns.Add(cCosto)
            'tCust.Columns.Add(cDescuento)
            tCust.Columns.Add(cSubTotal)
            'tCust.Columns.Add(cCodigoTemporal)
            tCust.Columns.Add(cItemTipo)

            'tCust.Columns.Add(cCurrent2)
            ' Add the tables to the DataSet.
            myDataSet.Tables.Add(tCust)
            Dim newRow1 As DataRow

            'i = 0

            'Do While (i < ds.Tables("Pedidos").Rows.Count)
            '    newRow1 = tCust.NewRow
            '    newRow1("ArticuloCodigo") = ds.Tables("Pedidos").Rows(i).Item("Item_ID")
            '    ' Add the row to the Customers table.
            '    tCust.Rows.Add(newRow1)
            '    i = (i + 1)

            'Loop

            Dim j As Integer

            For j = 0 To ds.Tables("Pedidos").Rows.Count - 1
                newRow1 = tCust.NewRow
                newRow1("ArticuloCodigo") = ds.Tables("Pedidos").Rows(j).Item("Item_ID")
                tCust.Rows.Add(newRow1)

                tCust.Rows(j)("Articulo") = ds.Tables("Pedidos").Rows(j).Item("Nombre")
                tCust.Rows(j)("Cantidad") = ds.Tables("Pedidos").Rows(j).Item("PedLinea_Cantidad")
                tCust.Rows(j)("Costo") = CDbl(ds.Tables("Pedidos").Rows(j).Item("Item_Costo")).ToString(RoundP)
                tCust.Rows(j)("Tipo") = ds.Tables("Pedidos").Rows(j).Item("Tipo")
            Next

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

            If ds.Tables("Pedidos").Rows(0).Item("Ped_Estado") = "F" Then
                Dim ArticuloCodigo As DataGridTextBoxColumn
                ArticuloCodigo = New DataGridTextBoxColumn()
                ArticuloCodigo.MappingName = "ArticuloCodigo"
                ArticuloCodigo.HeaderText = "Código"
                ArticuloCodigo.Width = 100
                ArticuloCodigo.Alignment = HorizontalAlignment.Left
                ArticuloCodigo.ReadOnly = True
                'ArticuloCodigo.Format = "##,###0.00"
                ts1.GridColumnStyles.Add(ArticuloCodigo)
                'colCount = (colCount + 1)

                ArticuloCodigo.NullText = "0.00"
            Else
                'Dim ArticuloCodigo As DataGridComboBoxColumn
                ArticuloCodigo = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))
                ArticuloCodigo.MappingName = "ArticuloCodigo"
                ArticuloCodigo.HeaderText = "Código"
                ArticuloCodigo.Width = 100

                'AddHandler ArticuloCodigo.ColumnComboBox.KeyDown, AddressOf Evento_KeyPress
                'AddHandler ArticuloCodigo.TextBox.KeyDown, AddressOf Evento_KeyPress

                ts1.GridColumnStyles.Add(ArticuloCodigo)
                ts1.PreferredRowHeight = (ArticuloCodigo.ColumnComboBox.Height + 3)

                ArticuloCodigo.NullText = ""

            End If

            colCount = (colCount + 1)

            If ds.Tables("Pedidos").Rows(0).Item("Ped_Estado") = "F" Then
                Dim Articulo As DataGridTextBoxColumn
                Articulo = New DataGridTextBoxColumn()
                Articulo.MappingName = "Articulo"
                Articulo.HeaderText = "Descripcion"
                Articulo.Width = 300
                Articulo.Alignment = HorizontalAlignment.Left
                Articulo.ReadOnly = True
                'Articulo.Format = "##,###0.00"
                ts1.GridColumnStyles.Add(Articulo)
                'colCount = (colCount + 1)

                Articulo.NullText = "0.00"

            Else
                'Dim Articulo As DataGridComboBoxColumn
                Articulo = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))
                Articulo.MappingName = "Articulo"
                Articulo.HeaderText = "Descripción"
                Articulo.Width = 300

                'AddHandler Articulo.ColumnComboBox.KeyDown, AddressOf Evento_KeyPress

                ts1.GridColumnStyles.Add(Articulo)
                ts1.PreferredRowHeight = (Articulo.ColumnComboBox.Height + 3)

                Articulo.NullText = ""


            End If

            colCount = (colCount + 1)

            'Dim Cantidad As DataGridTextBoxColumn
            Cantidad = New DataGridTextBoxColumn()
            Cantidad.MappingName = "Cantidad"
            Cantidad.HeaderText = "Cantidad"
            Cantidad.Width = 100
            Cantidad.Alignment = HorizontalAlignment.Right
            Cantidad.ReadOnly = False

            AddHandler Cantidad.TextBox.Leave, New EventHandler(AddressOf TextBoxLeaveHandler)

            ts1.GridColumnStyles.Add(Cantidad)
            colCount = (colCount + 1)

            Cantidad.NullText = ""

            Dim Costo As DataGridTextBoxColumn
            Costo = New DataGridTextBoxColumn()
            Costo.MappingName = "Costo"
            Costo.HeaderText = "Costo"
            Costo.Width = 100
            Costo.Alignment = HorizontalAlignment.Right
            Costo.ReadOnly = True
            Costo.Format = "##,###0.00"
            ts1.GridColumnStyles.Add(Costo)
            colCount = (colCount + 1)

            Costo.NullText = "0.00"

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

            ItemTipo = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))
            ItemTipo.MappingName = "Tipo"
            ItemTipo.HeaderText = "Tipo"
            ItemTipo.Width = 0
            ItemTipo.ReadOnly = True

            ts1.GridColumnStyles.Add(ItemTipo)
            ts1.PreferredRowHeight = (ItemTipo.ColumnComboBox.Height + 3)

            ItemTipo.NullText = ""

            'If Me.rbInventario.Checked = True Then
            '    BuscarCombo = False
            '    'txtPedido.Text = Pedidos.PedidoCCNumero
            '    dsItems = ArticulosCC.ArticulosCCList("", 0, 0, 0, 0)
            '    For i = 0 To dsItems.Tables("GruposCC").Rows.Count - 1
            '        ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("GruposCC").Rows(i).Item("Código"))
            '        Articulo.ColumnComboBox.Items.Add(dsItems.Tables("GruposCC").Rows(i).Item("Nombre"))
            '        ItemTipo.ColumnComboBox.Items.Add("I")
            '    Next
            'Else
            '    BuscarCombo = True
            '    'txtPedido.Text = Pedidos.PedidoNumero
            '    dsItems = Articulos.ProductosGetAll("P")
            '    For i = 0 To dsItems.Tables("Articulos").Rows.Count - 1
            '        ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Codigo"))
            '        Articulo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Nombre"))
            '        ItemTipo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Tipo"))
            '    Next
            'End If


            If ds.Tables("Pedidos").Rows(0).Item("Ped_Estado") <> "F" Then
                If Me.rbInventario.Checked = True Then
                    BuscarCombo = False
                    'txtPedido.Text = Pedidos.PedidoCCNumero
                    dsItems = ArticulosCC.ArticulosCCList("", 0, 0, 0, 0)
                    For i = 0 To dsItems.Tables("GruposCC").Rows.Count - 1
                        ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("GruposCC").Rows(i).Item("Código"))
                        Articulo.ColumnComboBox.Items.Add(dsItems.Tables("GruposCC").Rows(i).Item("Nombre"))
                        ItemTipo.ColumnComboBox.Items.Add("I")
                    Next
                Else
                    BuscarCombo = True
                    'txtPedido.Text = Pedidos.PedidoNumero
                    dsItems = Articulos.ProductosGetAll("P")
                    For i = 0 To dsItems.Tables("Articulos").Rows.Count - 1
                        ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Codigo"))
                        Articulo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Nombre"))
                        ItemTipo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Tipo"))
                    Next
                End If
                'dsItems = Articulos.ProductosGetAll("P")

                'For i = 0 To dsItems.Tables("Articulos").Rows.Count - 1
                '    ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Codigo"))
                '    Articulo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Nombre"))
                '    ItemTipo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Tipo"))
                'Next


                ArticuloCodigo.ColumnComboBox.DropDownStyle = ComboBoxStyle.DropDown
                ArticuloCodigo.ColumnComboBox.SelectedValue = -1

                Articulo.ColumnComboBox.DropDownStyle = ComboBoxStyle.DropDown
                Articulo.ColumnComboBox.SelectedValue = -1

                'ItemTipo.ColumnComboBox.DropDownStyle = ComboBoxStyle.DropDown
                'ItemTipo.ColumnComboBox.SelectedValue = -1

            End If

            colCount = (colCount + 1)

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            'STEP 6: Add the tablestyle to your datagrids tablestlye collection
            ts1.AllowSorting = False
            ts1.GridLineColor = Color.FromArgb(70, 130, 180)
            ts1.HeaderFont = dgPedidos.HeaderFont
            ts1.HeaderBackColor = Color.LightSteelBlue  'Color.LightBlue
            ts1.PreferredRowHeight = 25

            dgPedidos.CaptionVisible = False

            dgPedidos.TableStyles.Clear()
            dgPedidos.TableStyles.Add(ts1)

        End Sub

        Public Sub MyComboValueChanged(ByVal rowChanging As Integer, ByVal newValue As Object)
            Console.WriteLine("index changed {0} {1}", rowChanging, newValue)

            If Indice = 0 And Me.rbProductos.Checked = True Then
                Dim f As New frmAgregarArticuloQuick()
                f.WindowState = FormWindowState.Normal
                f.StartPosition = FormStartPosition.CenterScreen
                f.etTipo.Text = "P"
                f.lbProvTemporal.Text = cbProveedor.SelectedValue
                f.cbProveedores.EditValue = f.lbProvTemporal.Text
                f.ShowDialog()

                dsItems = Articulos.ProductosGetAll("P")

                ArticuloCodigo.ColumnComboBox.Items.Clear()
                Articulo.ColumnComboBox.Items.Clear()
                ItemTipo.ColumnComboBox.Items.Clear()

                For i = 0 To dsItems.Tables("Articulos").Rows.Count - 1
                    ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Codigo"))
                    Articulo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Nombre"))
                    ItemTipo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Tipo"))
                Next

                Exit Sub
            End If

            Try
                If Indice >= 0 Then
                    'DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(ArticuloCodigo.ColumnComboBox.Items.Item(Indice).ToString, ItemTipo.ColumnComboBox.Items.Item(Indice).ToString, EmpresaActual)
                    DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(ArticuloCodigo.ColumnComboBox.Items.Item(Indice).ToString, "P")

                    If tCust.Rows.Count < rowChanging + 1 Then
                        Dim newRow1 As DataRow
                        newRow1 = tCust.NewRow
                        'newRow1("CodigoTemporal") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
                        newRow1("ArticuloCodigo") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
                        'tCust.Rows(rowChanging)("ArticuloCodigo") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows.Add(newRow1)

                        'tCust.Rows(rowChanging)("ArticuloCodigo") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Articulo") = Articulo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Cantidad") = 1
                        tCust.Rows(rowChanging)("Costo") = CDbl(DetallesProducto.Costo).ToString(RoundP)

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
                        'tCust.Rows(rowChanging)("CodigoTemporal") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("ArticuloCodigo") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Articulo") = Articulo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Costo") = CDbl(DetallesProducto.Costo).ToString(RoundP)

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

        Private Sub TextBoxLeaveHandler(ByVal sender As Object, ByVal e As EventArgs)

            If Not IsNumeric(Cantidad.TextBox.Text) Then
                Cantidad.TextBox.Text = ValorActualCantidad '.ToString(Round)
            Else
                If CDbl(Cantidad.TextBox.Text) <= 0 Then
                    MsgBox("La cantidad debe ser mayor que Cero (0)", MsgBoxStyle.Information)
                    Cantidad.TextBox.Text = ValorActualCantidad '.ToString(Round)
                    'Cantidad.TextBox.Focus()
                    Exit Sub
                End If
            End If

        End Sub

        Private Sub tCust_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles tCust.ColumnChanged

            If Not IsNumeric(e.Row.Item(2)) Then
                e.Row.Item(2) = ValorActualCantidad
                'Else
                '    If CDbl(e.Row.Item(2)) <= 0 Then
                '        e.Row.Item(2) = ValorActualCantidad
                '    End If
            End If

            If e.Column.Ordinal = 2 Or e.Column.Ordinal = 3 Then
                If e.Row.Item(2) Is DBNull.Value Or e.Row.Item(3) Is DBNull.Value Then
                    '
                Else
                    If IsNumeric(e.Row.Item(2)) And IsNumeric(e.Row.Item(3)) Then
                        e.Row.Item(4) = (CDbl(e.Row.Item(2)) * CDbl(e.Row.Item(3))).ToString(Round)
                    End If

                    'If IsNumeric(e.Row.Item("Cantidad")) And IsNumeric(e.Row.Item("Costo")) Then
                    '    e.Row.Item("SubTotal") = (CDbl(e.Row.Item("Cantidad")) * CDbl(e.Row.Item("Costo"))).ToString(Round)
                    'End If

                End If

            End If

            TotalPedido = 0

            For i = 0 To tCust.Rows.Count - 1
                If tCust.Rows(i)("SubTotal") Is DBNull.Value Or tCust.Rows(i)("SubTotal").ToString = "" Or tCust.Rows(i)("SubTotal").ToString = "0.00" Then

                ElseIf IsNumeric(tCust.Rows(i)("SubTotal")) And tCust.Rows(i)("SubTotal").ToString <> "" Then
                    Try
                        TotalPedido = TotalPedido + tCust.Rows(i)("SubTotal")
                    Catch ex As Exception
                        MsgBox(ex.Message)

                    End Try

                End If
            Next

            etTotal.Text = TotalPedido.ToString(Round)

        End Sub


        Private Sub tCust_RowDeleted(ByVal sender As Object, ByVal e As System.Data.DataRowChangeEventArgs) Handles tCust.RowDeleted
            TotalPedido = 0
            For i = 0 To tCust.Rows.Count - 1
                If tCust.Rows(i)("SubTotal") Is DBNull.Value Or tCust.Rows(i)("SubTotal").ToString = "" Or tCust.Rows(i)("SubTotal").ToString = "0.00" Then

                ElseIf IsNumeric(tCust.Rows(i)("SubTotal")) And tCust.Rows(i)("SubTotal").ToString <> "" Then
                    Try 'MsgBox(tCust.Rows(i)("SubTotal").ToString)
                        TotalPedido = TotalPedido + tCust.Rows(i)("SubTotal")
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'e.Row.Delete()
                    End Try

                End If

            Next

            etTotal.Text = (TotalPedido).ToString(Round)

        End Sub

        Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
            Me.Close()

        End Sub

        Private Sub cmdConsultaClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultaClientes.Click
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

        Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
            If TipoPedido = 2 Then
                Me.Close()
                Exit Sub
            End If

            If Trim(cbProveedor.Text) = "" Then
                MsgBox("Seleccione el Proveedor", MsgBoxStyle.Critical)
                cbProveedor.Focus()
                Exit Sub
            End If

            If tCust.Rows.Count = 0 Then
                MsgBox("Seleccione al menos un Producto", MsgBoxStyle.Critical)
                dgPedidos.Focus()
                Articulo.ColumnComboBox.Focus()
                Exit Sub
            End If

            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction

            Try

                'If Me.rbInventario.Checked = True Then
                '    txtPedido.Text = Pedidos.PedidoCCNumero
                '    Pedidos.PedidosCCAdd(txtPedido.Text, dtpFecha.Value, dtpFechaEntrega.Value, cbProveedor.SelectedValue)
                'Else
                '    txtPedido.Text = Pedidos.PedidoNumero
                Pedidos.Update(txtPedido.Text, dtpFecha.Value, dtpFechaEntrega.Value, cbProveedor.SelectedValue, Tipo, 0, _
                               Usuario_ID, 0, "", "", "", 0, 0, 0, "")
                'End If

                If tCust.Rows.Count > 0 Then
                    If tCust.Rows(tCust.Rows.Count - 1)("ArticuloCodigo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Articulo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Costo") Is DBNull.Value Then
                        tCust.Rows(tCust.Rows.Count - 1).Delete()
                    End If
                End If

                'If Me.rbInventario.Checked = True Then
                '    For i = 0 To tCust.Rows.Count - 1
                '        Pedidos.PedidosCCLineasAdd(txtPedido.Text, tCust.Rows(i)("ArticuloCodigo"), tCust.Rows(i)("Cantidad"), tCust.Rows(i)("Costo"))
                '    Next
                'Else
                Pedidos.DeletePedidosLineas(txtPedido.Text)
                For i = 0 To tCust.Rows.Count - 1
                    Pedidos.AddPedidosLineas(txtPedido.Text, tCust.Rows(i)("ArticuloCodigo"), tCust.Rows(i)("Cantidad"), tCust.Rows(i)("Costo"), "P")
                Next
                'End If
                VB.SysContab.Rutinas.okTransaccion()
            Catch ex As Exception
                VB.SysContab.Rutinas.ErrorTransaccion()
                MsgBox(ex.Message)
                Exit Sub
            End Try

            Me.Close()
            'txtPedido.Text = Pedidos.PedidoNumero
            'LimpiarControles()
        End Sub

        Private Sub cmdImprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
            Pedidos.ImprimirOrden(Me.txtPedido.Text)
        End Sub

        Private Sub cmdConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsulta.Click
            If tCust.Rows.Count > 0 Then
                If tCust.Rows(tCust.Rows.Count - 1)("ArticuloCodigo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Articulo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Costo") Is DBNull.Value Then
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

        'Private Sub rbInventario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbInventario.CheckedChanged
        '    If Me.Inicio = True Then
        '        Exit Sub
        '    End If

        '    MakeDataSet()
        '    dgPedidos.SetDataBinding(myDataSet, "Articulos")
        '    AddCustomDataTableStyle()

        '    r.ComboAutoComplete(Articulo.ColumnComboBox)
        '    r.ComboAutoComplete(ArticuloCodigo.ColumnComboBox)
        'End Sub

        'Private Sub rbProductos_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbProductos.CheckedChanged
        '    If Me.Inicio = True Then
        '        Exit Sub
        '    End If

        '    MakeDataSet()
        '    dgPedidos.SetDataBinding(myDataSet, "Articulos")
        '    AddCustomDataTableStyle()

        '    r.ComboAutoComplete(Articulo.ColumnComboBox)
        '    r.ComboAutoComplete(ArticuloCodigo.ColumnComboBox)
        'End Sub

        Private Sub etTotalT_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles etTotalT.MouseEnter

            AgregarItem()
        End Sub

        Private Sub frmFacturacionCliente_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter

            AgregarItem()
        End Sub

        Private Sub dgPedidos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgPedidos.MouseEnter

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
                        tCust.Rows(tCust.Rows.Count - 1)("Costo") = CDbl(tItem.Rows(k)("Costo")).ToString(RoundP)
                        tCust.Rows(tCust.Rows.Count - 1)("Tipo") = tItem.Rows(k)("Tipo")

                    End If
                Next
                tItem.Clear()
                ArticuloCodigo.ColumnComboBox.Focus()

            End If

        End Sub

        Private Sub frmPedidosVer_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
            'Para refrescar la lista de los pedidos
            Dim f As frmListaPedidos = frmListaPedidos.Instance()
            'Dim ds As DataSet
            'If f.checkBoxFecha.Checked = True Then
            '    ds = Pedidos.PedidosListXFecha(f.cbProveedores.EditValue, f.cbEstado.SelectedIndex, f.fDesde.DateTime.Date, f.fHasta.DateTime.Date)
            '    f.Cargar()
            'Else
            '    ds = Pedidos.PedidosList(f.cbProveedores.EditValue, f.cbEstado.SelectedIndex)
            '    f.Cargar()
            'End If
            f.Cargar()
            f.CargarRegistro()
        End Sub
    End Class

End Namespace
