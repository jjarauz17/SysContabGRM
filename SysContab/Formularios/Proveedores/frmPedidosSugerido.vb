Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace DataGridTextBoxCombo
    Public Class frmPedidosSugerido
        Inherits DevExpress.XtraEditors.XtraForm
        Private Shared ChildInstance As frmPedidosSugerido = Nothing

        Public Shared Function Instance() As frmPedidosSugerido
            If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
                ChildInstance = New frmPedidosSugerido()
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
        Friend WithEvents txtPedido As System.Windows.Forms.TextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents cbProveedor As System.Windows.Forms.ComboBox
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents gbBotones As System.Windows.Forms.GroupBox
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
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaEntrega As System.Windows.Forms.DateTimePicker
        Friend WithEvents cmdConsultaProveedor As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdGenerar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents etTotalSugerido As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.txtPedido = New System.Windows.Forms.TextBox
            Me.Label7 = New System.Windows.Forms.Label
            Me.cbProveedor = New System.Windows.Forms.ComboBox
            Me.GroupBox3 = New System.Windows.Forms.GroupBox
            Me.etTotalSugerido = New System.Windows.Forms.Label
            Me.Label10 = New System.Windows.Forms.Label
            Me.gbBotones = New System.Windows.Forms.GroupBox
            Me.cmdGenerar = New DevExpress.XtraEditors.SimpleButton
            Me.cmdConsultaProveedor = New DevExpress.XtraEditors.SimpleButton
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
            Me.Label24 = New System.Windows.Forms.Label
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label11 = New System.Windows.Forms.Label
            Me.dtpFecha = New System.Windows.Forms.DateTimePicker
            Me.dtpFechaEntrega = New System.Windows.Forms.DateTimePicker
            Me.GroupBox3.SuspendLayout()
            Me.gbBotones.SuspendLayout()
            CType(Me.dgPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'txtPedido
            '
            Me.txtPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPedido.Location = New System.Drawing.Point(504, 8)
            Me.txtPedido.MaxLength = 50
            Me.txtPedido.Name = "txtPedido"
            Me.txtPedido.ReadOnly = True
            Me.txtPedido.Size = New System.Drawing.Size(128, 20)
            Me.txtPedido.TabIndex = 132
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.Transparent
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label7.Location = New System.Drawing.Point(432, 8)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(72, 25)
            Me.Label7.TabIndex = 131
            Me.Label7.Text = "No. Pedido:"
            '
            'cbProveedor
            '
            Me.cbProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbProveedor.Location = New System.Drawing.Point(96, 8)
            Me.cbProveedor.Name = "cbProveedor"
            Me.cbProveedor.Size = New System.Drawing.Size(328, 21)
            Me.cbProveedor.TabIndex = 126
            '
            'GroupBox3
            '
            Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox3.Controls.Add(Me.etTotalSugerido)
            Me.GroupBox3.Controls.Add(Me.Label10)
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
            Me.GroupBox3.Location = New System.Drawing.Point(8, 33)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(1008, 489)
            Me.GroupBox3.TabIndex = 130
            Me.GroupBox3.TabStop = False
            '
            'etTotalSugerido
            '
            Me.etTotalSugerido.BackColor = System.Drawing.Color.Transparent
            Me.etTotalSugerido.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTotalSugerido.ForeColor = System.Drawing.Color.Maroon
            Me.etTotalSugerido.Location = New System.Drawing.Point(680, 439)
            Me.etTotalSugerido.Name = "etTotalSugerido"
            Me.etTotalSugerido.Size = New System.Drawing.Size(184, 34)
            Me.etTotalSugerido.TabIndex = 133
            Me.etTotalSugerido.Text = "0.00"
            Me.etTotalSugerido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label10
            '
            Me.Label10.BackColor = System.Drawing.Color.Transparent
            Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label10.Location = New System.Drawing.Point(536, 447)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(128, 26)
            Me.Label10.TabIndex = 132
            Me.Label10.Text = "Total Sugerido:"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'gbBotones
            '
            Me.gbBotones.BackColor = System.Drawing.Color.Transparent
            Me.gbBotones.Controls.Add(Me.cmdGenerar)
            Me.gbBotones.Controls.Add(Me.cmdConsultaProveedor)
            Me.gbBotones.Controls.Add(Me.cmdConsulta)
            Me.gbBotones.Controls.Add(Me.cmdImprimir)
            Me.gbBotones.Controls.Add(Me.cmdCancelar)
            Me.gbBotones.Controls.Add(Me.cmdAceptar)
            Me.gbBotones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBotones.ForeColor = System.Drawing.Color.Maroon
            Me.gbBotones.Location = New System.Drawing.Point(8, 418)
            Me.gbBotones.Name = "gbBotones"
            Me.gbBotones.Size = New System.Drawing.Size(504, 60)
            Me.gbBotones.TabIndex = 130
            Me.gbBotones.TabStop = False
            '
            'cmdGenerar
            '
            Me.cmdGenerar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdGenerar.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdGenerar.Appearance.Options.UseFont = True
            Me.cmdGenerar.Appearance.Options.UseForeColor = True
            Me.cmdGenerar.Appearance.Options.UseTextOptions = True
            Me.cmdGenerar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.cmdGenerar.Location = New System.Drawing.Point(8, 17)
            Me.cmdGenerar.Name = "cmdGenerar"
            Me.cmdGenerar.Size = New System.Drawing.Size(72, 35)
            Me.cmdGenerar.TabIndex = 34
            Me.cmdGenerar.Text = "S&ugerir Pedido"
            '
            'cmdConsultaProveedor
            '
            Me.cmdConsultaProveedor.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdConsultaProveedor.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdConsultaProveedor.Appearance.Options.UseFont = True
            Me.cmdConsultaProveedor.Appearance.Options.UseForeColor = True
            Me.cmdConsultaProveedor.Location = New System.Drawing.Point(248, 17)
            Me.cmdConsultaProveedor.Name = "cmdConsultaProveedor"
            Me.cmdConsultaProveedor.Size = New System.Drawing.Size(72, 35)
            Me.cmdConsultaProveedor.TabIndex = 33
            Me.cmdConsultaProveedor.Text = "Pro&veedor"
            '
            'cmdConsulta
            '
            Me.cmdConsulta.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdConsulta.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdConsulta.Appearance.Options.UseFont = True
            Me.cmdConsulta.Appearance.Options.UseForeColor = True
            Me.cmdConsulta.Location = New System.Drawing.Point(424, 17)
            Me.cmdConsulta.Name = "cmdConsulta"
            Me.cmdConsulta.Size = New System.Drawing.Size(72, 35)
            Me.cmdConsulta.TabIndex = 31
            Me.cmdConsulta.Text = "&Productos"
            Me.cmdConsulta.Visible = False
            '
            'cmdImprimir
            '
            Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdImprimir.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdImprimir.Appearance.Options.UseFont = True
            Me.cmdImprimir.Appearance.Options.UseForeColor = True
            Me.cmdImprimir.Location = New System.Drawing.Point(168, 17)
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
            Me.cmdCancelar.Location = New System.Drawing.Point(336, 17)
            Me.cmdCancelar.Name = "cmdCancelar"
            Me.cmdCancelar.Size = New System.Drawing.Size(72, 35)
            Me.cmdCancelar.TabIndex = 29
            Me.cmdCancelar.Text = "&Salir"
            '
            'cmdAceptar
            '
            Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdAceptar.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdAceptar.Appearance.Options.UseFont = True
            Me.cmdAceptar.Appearance.Options.UseForeColor = True
            Me.cmdAceptar.Location = New System.Drawing.Point(88, 17)
            Me.cmdAceptar.Name = "cmdAceptar"
            Me.cmdAceptar.Size = New System.Drawing.Size(72, 35)
            Me.cmdAceptar.TabIndex = 28
            Me.cmdAceptar.Text = "&Guardar"
            '
            'txtMunicipio
            '
            Me.txtMunicipio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMunicipio.Location = New System.Drawing.Point(752, 69)
            Me.txtMunicipio.MaxLength = 50
            Me.txtMunicipio.Name = "txtMunicipio"
            Me.txtMunicipio.ReadOnly = True
            Me.txtMunicipio.Size = New System.Drawing.Size(248, 20)
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
            Me.txtTelefono.Size = New System.Drawing.Size(248, 20)
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
            Me.etTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTotal.ForeColor = System.Drawing.Color.Maroon
            Me.etTotal.Location = New System.Drawing.Point(680, 487)
            Me.etTotal.Name = "etTotal"
            Me.etTotal.Size = New System.Drawing.Size(184, 34)
            Me.etTotal.TabIndex = 110
            Me.etTotal.Text = "0.00"
            Me.etTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etTotalT
            '
            Me.etTotalT.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etTotalT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTotalT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etTotalT.Location = New System.Drawing.Point(528, 495)
            Me.etTotalT.Name = "etTotalT"
            Me.etTotalT.Size = New System.Drawing.Size(136, 26)
            Me.etTotalT.TabIndex = 109
            Me.etTotalT.Text = "Total Seleccionado:"
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
            Me.dgPedidos.Location = New System.Drawing.Point(8, 103)
            Me.dgPedidos.Name = "dgPedidos"
            Me.dgPedidos.ParentRowsBackColor = System.Drawing.Color.LightGray
            Me.dgPedidos.ParentRowsForeColor = System.Drawing.Color.Black
            Me.dgPedidos.SelectionBackColor = System.Drawing.Color.Firebrick
            Me.dgPedidos.SelectionForeColor = System.Drawing.Color.White
            Me.dgPedidos.Size = New System.Drawing.Size(992, 310)
            Me.dgPedidos.TabIndex = 27
            '
            'Label24
            '
            Me.Label24.BackColor = System.Drawing.Color.Transparent
            Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label24.Location = New System.Drawing.Point(8, 8)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(88, 25)
            Me.Label24.TabIndex = 127
            Me.Label24.Text = "Proveedor:"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(640, 8)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(64, 25)
            Me.Label1.TabIndex = 129
            Me.Label1.Text = "Fecha:"
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.Transparent
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label11.Location = New System.Drawing.Point(800, 9)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(112, 25)
            Me.Label11.TabIndex = 134
            Me.Label11.Text = "Fecha Entrega:"
            '
            'dtpFecha
            '
            Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFecha.Location = New System.Drawing.Point(704, 9)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
            Me.dtpFecha.TabIndex = 142
            '
            'dtpFechaEntrega
            '
            Me.dtpFechaEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaEntrega.Location = New System.Drawing.Point(912, 9)
            Me.dtpFechaEntrega.Name = "dtpFechaEntrega"
            Me.dtpFechaEntrega.Size = New System.Drawing.Size(96, 20)
            Me.dtpFechaEntrega.TabIndex = 143
            '
            'frmPedidosSugerido
            '
            Me.Appearance.BackColor = System.Drawing.SystemColors.Control
            Me.Appearance.Options.UseBackColor = True
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(1016, 526)
            Me.Controls.Add(Me.dtpFechaEntrega)
            Me.Controls.Add(Me.Label11)
            Me.Controls.Add(Me.txtPedido)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.cbProveedor)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.Label24)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.dtpFecha)
            Me.Name = "frmPedidosSugerido"
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.gbBotones.ResumeLayout(False)
            CType(Me.dgPedidos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        'Dim Inicio As Boolean
        Dim ds As DataSet
        Dim WithEvents tCust As DataTable
        Private WithEvents myDataSet As DataSet

        'Dim WithEvents Articulo As DataGridComboBoxColumn
        'Dim WithEvents ArticuloCodigo As DataGridComboBoxColumn

        'Dim WithEvents Articulo As DataGridTextBoxColumn
        'Dim WithEvents ArticuloCodigo As DataGridTextBoxColumn

        'Dim WithEvents ItemTipo As DataGridComboBoxColumn
        Dim Cantidad As DataGridTextBoxColumn
        Dim Fecha As DataGridTextBoxColumn
        'Dim Descuento As DataGridTextBoxColumn

        Dim r As New VB.SysContab.Rutinas()
        Dim Proveedores As New VB.SysContab.ProveedoresDB()
        Dim DetallesProveedor As New VB.SysContab.ProveedoresDetails()
        Dim Departamentos As New VB.SysContab.DepartamentosCDB()
        Dim Municipios As New VB.SysContab.MunicipiosDB()
        Dim Articulos As New VB.SysContab.ArticulosDB()
        Dim DetallesProducto As New VB.SysContab.ArticulosDetails()
        Dim Pedidos As New VB.SysContab.PedidosDB()

        Dim FormaPago As New VB.SysContab.Forma_PagoDB()

        Dim ValorActualCantidad As Double
        Dim ValorActualDescuento As Double
        Dim ValorActualFecha As String

        Dim i As Integer

        Dim Servicio As Boolean

        Dim dsItems As DataSet
        Dim Tipo As Integer

        Private myCheckBoxCol As Integer = 8 'my checkbox column 

        Dim TotalSugerido As Double

        Private Sub frmPedidosSugerido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            r.FormularioColor(Me)

            Me.dtpFecha.Value = r.Fecha
            Me.dtpFechaEntrega.Value = r.Fecha

            cbProveedor.DataSource = Proveedores.ProveedoresList(3).Tables("Proveedores")
            cbProveedor.ValueMember = "Codigo"
            cbProveedor.DisplayMember = "Nombre"

            cbProveedor.SelectedValue = 0

            txtPedido.Text = Pedidos.PedidoNumero

            'cbTipoFactura.DataSource = FormaPago.FormaPagoList().Tables("Forma_Pago")
            'cbTipoFactura.ValueMember = "CODIGO"
            'cbTipoFactura.DisplayMember = "NOMBRE"

            r.ComboAutoComplete(Me.cbProveedor)

            ds = Pedidos.SugerirPedido(-911)

            MakeDataSet()
            dgPedidos.SetDataBinding(myDataSet, "Articulos")
            AddCustomDataTableStyle()

            'dtpFecha.Value = Pedidos.GetList.Tables("Pedidos").Rows(0).Item("Ped_Fecha")

            'MsgBox(dtpFecha.Value)

            LeaveCommit = False
            BuscarCombo = True

            TipoItem = "P"

            Indice = -1

            Tipo = 0

            Servicio = False

            'r.ComboAutoComplete(Articulo.ColumnComboBox)
            'r.ComboAutoComplete(ArticuloCodigo.ColumnComboBox)


            Me.Text = "P e d i d o s"
            Me.Refresh()

        End Sub

        Private Sub cmdCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
            Me.Close()
        End Sub

        Private Sub frmPedidosSugerido_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
            'If MsgBox("Desea salir de Pedidos?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            '    e.Cancel = True
            '    Exit Sub
            'End If

        End Sub

        Private Sub Evento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
            'If rbActivo.Checked = False Then
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

            Dim cPromedio As DataColumn
            cPromedio = New DataColumn("Promedio")

            Dim cExistencias As DataColumn
            cExistencias = New DataColumn("Existencias")

            Dim cMinimo As DataColumn
            cMinimo = New DataColumn("Minimo")

            Dim cCantidad As DataColumn
            cCantidad = New DataColumn("Cantidad")

            Dim cCosto As DataColumn
            cCosto = New DataColumn("Costo")

            Dim cSubTotal As DataColumn
            cSubTotal = New DataColumn("SubTotal")

            'Dim cItemTipo As DataColumn
            'cItemTipo = New DataColumn("Tipo")

            Dim cAgregar As DataColumn
            cAgregar = New DataColumn("Agregar", GetType(System.Boolean))

            Dim cFecha As DataColumn
            cFecha = New DataColumn("Fecha")

            tCust.Columns.Add(cArticuloCodigo)
            tCust.Columns.Add(cArticulo)
            tCust.Columns.Add(cPromedio)
            tCust.Columns.Add(cExistencias)
            tCust.Columns.Add(cMinimo)
            tCust.Columns.Add(cCantidad)
            tCust.Columns.Add(cCosto)
            tCust.Columns.Add(cSubTotal)
            tCust.Columns.Add(cAgregar) '7
            tCust.Columns.Add(cFecha)

            'tCust.Columns.Add(cCurrent2)
            ' Add the tables to the DataSet.
            myDataSet.Tables.Add(tCust)

            Dim newRow1 As DataRow

            Dim j As Integer

            For j = 0 To ds.Tables("Articulos").Rows.Count - 1
                newRow1 = tCust.NewRow
                newRow1("ArticuloCodigo") = ds.Tables("Articulos").Rows(j).Item("Item_ID")
                tCust.Rows.Add(newRow1)

                tCust.Rows(j)("Articulo") = ds.Tables("Articulos").Rows(j).Item("Nombre")
                tCust.Rows(j)("Promedio") = CDbl(ds.Tables("Articulos").Rows(j).Item("Promedio")).ToString(Round)
                tCust.Rows(j)("Cantidad") = ds.Tables("Articulos").Rows(j).Item("Cantidad")
                tCust.Rows(j)("Existencias") = ds.Tables("Articulos").Rows(j).Item("Existencias")
                tCust.Rows(j)("Minimo") = ds.Tables("Articulos").Rows(j).Item("Minimo")
                tCust.Rows(j)("Costo") = CDbl(ds.Tables("Articulos").Rows(j).Item("Costo")).ToString(Round)
                tCust.Rows(j)("Agregar") = False
                tCust.Rows(j)("Fecha") = ""
            Next
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

            'If dgFacturacionCliente.CurrentRowIndex >= tCust.Rows.Count Then
            '    Exit Sub
            'End If

            'If tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo").ToString = "" Or tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo") Is DBNull.Value Then
            '    Exit Sub
            'End If

            'If TipoItem = "S" Then
            '    Exit Sub
            'ElseIf TipoItem = "A" Then
            '    If tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Tipo").ToString = "S" Then
            '        Exit Sub
            '    End If
            'End If

            'DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo"), tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Tipo"), EmpresaActual)
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

        Private Sub TextBoxFechaLeaveHandler(ByVal sender As Object, ByVal e As EventArgs)
            If Trim(Fecha.TextBox.Text) = "" Then
                Fecha.TextBox.Text = ""
                Exit Sub
            End If

            If IsDate(Fecha.TextBox.Text) = False Then
                MsgBox("Fecha no Valida", MsgBoxStyle.Information)
                Fecha.TextBox.Text = ValorActualFecha
                Fecha.TextBox.Focus()
                Exit Sub

                'If CDbl(Cantidad.TextBox.Text) <= 0 Then
                '    MsgBox("La cantidad debe ser mayor que Cero (0)", MsgBoxStyle.Information)
                '    Cantidad.TextBox.Text = ValorActualCantidad
                '    Exit Sub
                'End If
            End If
        End Sub

        'Private Sub TextBoxDescuentoLeaveHandler(ByVal sender As Object, ByVal e As EventArgs)
        '    If Not IsNumeric(Descuento.TextBox.Text) Then
        '        Descuento.TextBox.Text = ValorActualDescuento.ToString(Round)
        '    Else
        '        If CDbl(Descuento.TextBox.Text) < 0 Then
        '            MsgBox("El Descuento debe ser mayor o igual a Cero (0)", MsgBoxStyle.Information)
        '            Descuento.TextBox.Text = ValorActualDescuento.ToString(Round)
        '            'Cantidad.TextBox.Focus()
        '            Exit Sub
        '        Else
        '            Descuento.TextBox.Text = CDbl(Descuento.TextBox.Text).ToString(Round)
        '        End If
        '    End If


        '    'If dgFacturacionCliente.CurrentRowIndex >= tCust.Rows.Count Then
        '    '    Exit Sub
        '    'End If

        '    'If tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo").ToString = "" Or tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo") Is DBNull.Value Then
        '    '    Exit Sub
        '    'End If

        '    'If TipoItem = "S" Then
        '    '    Exit Sub
        '    'ElseIf TipoItem = "A" Then
        '    '    If tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Tipo").ToString = "S" Then
        '    '        Exit Sub
        '    '    End If
        '    'End If

        '    'DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo"), tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Tipo"), EmpresaActual)
        '    'If DetallesProducto.Existencia Is Nothing Or DetallesProducto.Existencia Is DBNull.Value Then
        '    '    '
        '    'ElseIf DetallesProducto.Existencia = 0 Then
        '    '    MsgBox("No hay existencias...", MsgBoxStyle.Critical)
        '    '    Cantidad.TextBox.Focus()
        '    '    Exit Sub
        '    'ElseIf CDbl(Cantidad.TextBox.Text) > CDbl(DetallesProducto.Existencia) Then
        '    '    MsgBox("La cantidad es mayor que la existencia actual", MsgBoxStyle.Critical)
        '    '    Exit Sub
        '    'End If

        'End Sub

        'Private Sub Evento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        '    If rbAmbos.Checked = False Then
        '        Exit Sub
        '    End If

        '    If e.KeyCode = Keys.F9 Then

        '        If Servicio = True Then
        '            Exit Sub
        '        End If

        '        Servicio = True

        '        ArticuloCodigo.ColumnComboBox.Items.Clear()
        '        Articulo.ColumnComboBox.Items.Clear()
        '        ItemTipo.ColumnComboBox.Items.Clear()

        '        For i = 0 To Articulos.ProductosGetAll("S").Tables("Articulos").Rows.Count - 1
        '            ArticuloCodigo.ColumnComboBox.Items.Add(Articulos.ProductosGetAll("S").Tables("Articulos").Rows(i).Item("Codigo"))

        '        Next

        '        For i = 0 To Articulos.ProductosGetAll("S").Tables("Articulos").Rows.Count - 1
        '            Articulo.ColumnComboBox.Items.Add(Articulos.ProductosGetAll("S").Tables("Articulos").Rows(i).Item("Nombre"))

        '        Next

        '        For i = 0 To Articulos.ProductosGetAll("S").Tables("Articulos").Rows.Count - 1
        '            ItemTipo.ColumnComboBox.Items.Add(Articulos.ProductosGetAll("S").Tables("Articulos").Rows(i).Item("Tipo"))

        '        Next

        '    ElseIf e.KeyCode = Keys.F10 Then

        '        If Servicio = False Then
        '            Exit Sub
        '        End If

        '        Servicio = False

        '        ArticuloCodigo.ColumnComboBox.Items.Clear()
        '        Articulo.ColumnComboBox.Items.Clear()
        '        ItemTipo.ColumnComboBox.Items.Clear()

        '        For i = 0 To Articulos.ProductosGetAll("P").Tables("Articulos").Rows.Count - 1
        '            ArticuloCodigo.ColumnComboBox.Items.Add(Articulos.ProductosGetAll("P").Tables("Articulos").Rows(i).Item("Codigo"))

        '        Next

        '        For i = 0 To Articulos.ProductosGetAll("P").Tables("Articulos").Rows.Count - 1
        '            Articulo.ColumnComboBox.Items.Add(Articulos.ProductosGetAll("P").Tables("Articulos").Rows(i).Item("Nombre"))

        '        Next

        '        For i = 0 To Articulos.ProductosGetAll("P").Tables("Articulos").Rows.Count - 1
        '            ItemTipo.ColumnComboBox.Items.Add(Articulos.ProductosGetAll("P").Tables("Articulos").Rows(i).Item("Tipo"))

        '        Next

        '    End If

        'End Sub


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

            Dim ArticuloCodigo As DataGridTextBoxColumn
            'ArticuloCodigo = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))
            ArticuloCodigo = New DataGridTextBoxColumn()
            ArticuloCodigo.MappingName = "ArticuloCodigo"
            ArticuloCodigo.HeaderText = "Código"
            ArticuloCodigo.ReadOnly = True
            ArticuloCodigo.Width = 75

            'AddHandler ArticuloCodigo.ColumnComboBox.KeyDown, AddressOf Evento_KeyPress
            'AddHandler ArticuloCodigo.TextBox.KeyDown, AddressOf Evento_KeyPress

            ts1.GridColumnStyles.Add(ArticuloCodigo)
            ts1.PreferredRowHeight = (ArticuloCodigo.TextBox.Height + 3)

            ArticuloCodigo.NullText = ""

            'If rbProductos.Checked = True Then
            '    For i = 0 To Articulos.ProductosGetAll("P").Tables("Articulos").Rows.Count - 1
            '        ArticuloCodigo.ColumnComboBox.Items.Add(Articulos.ProductosGetAll("P").Tables("Articulos").Rows(i).Item("Codigo"))

            '    Next
            'ElseIf rbServicios.Checked = True Then
            '    For i = 0 To Articulos.ProductosGetAll("S").Tables("Articulos").Rows.Count - 1
            '        ArticuloCodigo.ColumnComboBox.Items.Add(Articulos.ProductosGetAll("S").Tables("Articulos").Rows(i).Item("Codigo"))

            '    Next
            'Else
            '    For i = 0 To Articulos.ProductosGetAll("P").Tables("Articulos").Rows.Count - 1
            '        ArticuloCodigo.ColumnComboBox.Items.Add(Articulos.ProductosGetAll("P").Tables("Articulos").Rows(i).Item("Codigo"))

            '    Next

            'End If

            'ArticuloCodigo.ColumnComboBox.DropDownStyle = ComboBoxStyle.DropDown

            'ArticuloCodigo.ColumnComboBox.SelectedValue = -1

            colCount = (colCount + 1)

            Dim Articulo As DataGridTextBoxColumn
            'Articulo = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))
            Articulo = New DataGridTextBoxColumn()
            Articulo.MappingName = "Articulo"
            Articulo.HeaderText = "Descripción"
            Articulo.Width = 240
            Articulo.ReadOnly = True

            'AddHandler Articulo.ColumnComboBox.KeyDown, AddressOf Evento_KeyPress

            ts1.GridColumnStyles.Add(Articulo)
            ts1.PreferredRowHeight = (Articulo.TextBox.Height + 3)

            Articulo.NullText = ""

            colCount = (colCount + 1)

            Dim Promedio As DataGridTextBoxColumn
            Promedio = New DataGridTextBoxColumn()
            Promedio.MappingName = "Promedio"
            Promedio.HeaderText = "Promedio"
            Promedio.Width = 65
            Promedio.Alignment = HorizontalAlignment.Right
            Promedio.ReadOnly = True

            ts1.GridColumnStyles.Add(Promedio)
            colCount = (colCount + 1)

            Promedio.NullText = ""


            Dim Existencias As DataGridTextBoxColumn
            Existencias = New DataGridTextBoxColumn()
            Existencias.MappingName = "Existencias"
            Existencias.HeaderText = "Existencias"
            Existencias.Width = 75
            Existencias.Alignment = HorizontalAlignment.Right
            Existencias.ReadOnly = True


            ts1.GridColumnStyles.Add(Existencias)
            colCount = (colCount + 1)

            Existencias.NullText = ""

            Dim Minimo As DataGridTextBoxColumn
            Minimo = New DataGridTextBoxColumn()
            Minimo.MappingName = "Minimo"
            Minimo.HeaderText = "Minimo"
            Minimo.Width = 65
            Minimo.Alignment = HorizontalAlignment.Right
            Minimo.ReadOnly = True


            ts1.GridColumnStyles.Add(Minimo)
            colCount = (colCount + 1)

            Minimo.NullText = ""

            Cantidad = New DataGridTextBoxColumn()
            Cantidad.MappingName = "Cantidad"
            Cantidad.HeaderText = "Faltante"
            Cantidad.Width = 65
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
            Costo.Width = 80
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
            SubTotal.Width = 90
            SubTotal.Alignment = HorizontalAlignment.Right
            SubTotal.ReadOnly = True
            SubTotal.Format = "##,###0.00"
            ts1.GridColumnStyles.Add(SubTotal)
            colCount = (colCount + 1)

            SubTotal.NullText = "0.00"


            Dim boolCol As DataGridCheckBoxChangeEvent.MyDataGridBoolColumn
            boolCol = New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn(colCount)
            boolCol.MappingName = "Agregar"
            boolCol.HeaderText = "Seleccionar"
            boolCol.Alignment = HorizontalAlignment.Center
            'uncomment this line to get a two-state checkbox
            CType(boolCol, DataGridBoolColumn).AllowNull = False

            boolCol.Width = 70
            boolCol.ReadOnly = False

            boolCol.NullText = ""

            'hook the new event to our handler in the grid
            AddHandler boolCol.BoolValueChanged, New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn.BoolValueChangedEventHandler(AddressOf HandleBoolChanges)

            ts1.GridColumnStyles.Add(boolCol)
            colCount = (colCount + 1)

            'Dim Fecha As DataGridTextBoxColumn
            Fecha = New DataGridTextBoxColumn()
            Fecha.MappingName = "Fecha"
            Fecha.HeaderText = "Reprogramación"
            Fecha.Width = 105
            Fecha.Alignment = HorizontalAlignment.Left
            Fecha.ReadOnly = False
            Fecha.Format = "##,###0.00"

            AddHandler Fecha.TextBox.Leave, New EventHandler(AddressOf TextBoxFechaLeaveHandler)

            ts1.GridColumnStyles.Add(Fecha)
            colCount = (colCount + 1)

            Fecha.NullText = "-"

            ts1.GridLineColor = Color.FromArgb(70, 130, 180)
            ts1.AllowSorting = False
            ts1.HeaderFont = dgPedidos.HeaderFont
            ts1.HeaderBackColor = Color.LightSteelBlue

            dgPedidos.CaptionVisible = False

            dgPedidos.TableStyles.Clear()
            dgPedidos.TableStyles.Add(ts1)

        End Sub

        Private Sub HandleBoolChanges(ByVal sender As Object, ByVal e As DataGridCheckBoxChangeEvent.BoolValueChangedEventArgs)
            Dim s As String
            s = System.String.Format("Bool Changes: row {0}, col {1}   value {2}", e.Row, e.Column, e.BoolValue)
            Console.WriteLine(s)
        End Sub

        'Public Sub MyComboValueChanged(ByVal rowChanging As Integer, ByVal newValue As Object)
        '    Console.WriteLine("index changed {0} {1}", rowChanging, newValue)

        '    Try
        '        If Indice >= 0 Then
        '            DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(ArticuloCodigo.ColumnComboBox.Items.Item(Indice).ToString, "P", EmpresaActual)

        '            If tCust.Rows.Count < rowChanging + 1 Then
        '                Dim newRow1 As DataRow
        '                newRow1 = tCust.NewRow
        '                'newRow1("CodigoTemporal") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
        '                newRow1("ArticuloCodigo") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
        '                'tCust.Rows(rowChanging)("ArticuloCodigo") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
        '                tCust.Rows.Add(newRow1)

        '                'tCust.Rows(rowChanging)("ArticuloCodigo") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
        '                tCust.Rows(rowChanging)("Articulo") = Articulo.ColumnComboBox.Items.Item(Indice)
        '                tCust.Rows(rowChanging)("Cantidad") = 1
        '                tCust.Rows(rowChanging)("Costo") = CDbl(DetallesProducto.Costo).ToString(Round)

        '                tCust.Rows(rowChanging)("Tipo") = ItemTipo.ColumnComboBox.Items.Item(Indice)
        '            Else
        '                'tCust.Rows(rowChanging)("CodigoTemporal") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
        '                tCust.Rows(rowChanging)("ArticuloCodigo") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
        '                tCust.Rows(rowChanging)("Articulo") = Articulo.ColumnComboBox.Items.Item(Indice)
        '                'tCust.Rows(rowChanging)("Cantidad") = 1
        '                tCust.Rows(rowChanging)("Costo") = CDbl(DetallesProducto.Costo).ToString(Round)

        '                tCust.Rows(rowChanging)("Tipo") = ItemTipo.ColumnComboBox.Items.Item(Indice)
        '            End If

        '        End If
        '    Catch ex As Exception
        '        MsgBox(ex.Message & "MyComboValueChanged")
        '    End Try

        'End Sub

        Private Sub dgPedidos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgPedidos.CurrentCellChanged
            Try
                If Me.dgPedidos.CurrentRowIndex = tCust.Rows.Count Then
                    Me.dgPedidos.ReadOnly = True
                    Exit Sub
                Else
                    Me.dgPedidos.ReadOnly = False
                End If

                ValorActualCantidad = tCust.Rows(dgPedidos.CurrentRowIndex)("Cantidad")
                'ValorActualDescuento = tCust.Rows(dgPedidos.CurrentRowIndex)("Descuento")
                ValorActualFecha = tCust.Rows(dgPedidos.CurrentRowIndex)("Fecha")
            Catch ex As Exception
                'MsgBox(ex.Message)
                Exit Sub
            End Try
        End Sub

        Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
            Dim Cantidad As Integer
            Cantidad = 0
            If Trim(cbProveedor.Text) = "" Then
                MsgBox("Seleccione el Proveedor", MsgBoxStyle.Critical)
                cbProveedor.Focus()
                Exit Sub
            End If

            If tCust.Rows.Count = 0 Then
                MsgBox("Seleccione al menos un Producto", MsgBoxStyle.Critical)
                dgPedidos.Focus()
                'Articulo.ColumnComboBox.Focus()
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
                dgPedidos.Focus()
                Exit Sub
            End If

            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction

            Try
                txtPedido.Text = Pedidos.PedidoNumero
                Pedidos.AddItem(txtPedido.Text, dtpFecha.Value, dtpFechaEntrega.Value, cbProveedor.SelectedValue, Tipo, 0, Usuario_ID, 0, "", "", "", 0, 0, 0, "")

                If tCust.Rows.Count > 0 Then
                    If tCust.Rows(tCust.Rows.Count - 1)("ArticuloCodigo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Articulo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Costo") Is DBNull.Value Then
                        tCust.Rows(tCust.Rows.Count - 1).Delete()
                    End If
                End If

                For i = 0 To tCust.Rows.Count - 1
                    'Agrear las lineas de la Factura
                    If tCust.Rows(i)("Agregar") = True Then
                        Pedidos.AddPedidosLineas(txtPedido.Text, tCust.Rows(i)("ArticuloCodigo"), tCust.Rows(i)("Cantidad"), tCust.Rows(i)("Costo"), "P")
                    ElseIf tCust.Rows(i)("Fecha") <> "" Then
                        'UPDATE Fecha_Sugerir_Pedido
                        Articulos.UpdateFechaPedido(tCust.Rows(i)("ArticuloCodigo"), tCust.Rows(i)("Fecha"))
                    End If
                Next
            Catch ex As Exception
                VB.SysContab.Rutinas.ErrorTransaccion()
                MsgBox(ex.Message)
                Exit Sub
            End Try
            VB.SysContab.Rutinas.okTransaccion()

            'txtPedido.Text = Pedidos.PedidoNumero

            LimpiarControles()

        End Sub

        Private Sub cbProveedor_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbProveedor.SelectedValueChanged
            If Inicio = True Then
                Exit Sub
            End If

            tCust.Rows.Clear()
            Me.etTotal.Text = CDbl(0).ToString(Round)

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
                'Cliente = ""
                Exit Sub
            End If

            If Proveedores.ProveedoresBuscar(Trim(cbProveedor.Text)).Tables("Proveedores").Rows.Count = 0 Then
                cbProveedor.Text = cbProveedor.Text.ToUpper

                txtRuc.Text = ""
                txtDireccion.Text = ""
                txtTelefono.Text = ""
                txtDepartamento.Text = ""
                txtMunicipio.Text = ""
                'Cliente = ""

                If (MsgBox("Proveedor no existe. Desea agregarlo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)) = MsgBoxResult.No Then
                    'Exit Sub
                Else
                    'Dim f As New frmAgregarClienteQuick()
                    'f.WindowState = FormWindowState.Normal
                    'f.StartPosition = FormStartPosition.CenterScreen
                    'NombreCliente = cbProveedor.Text.ToUpper
                    'cbCliente.Text = cbCliente.Text.ToUpper

                    'f.ShowDialog()

                End If

                'Cliente = ""
                'Cod_Cliente = "9999" 'Clientes Varios
                'cbCliente.Focus()
                Exit Sub

            End If

            'cbVendedor.SelectedValue = v.GetListBuscarCombo(cbVendedor.Text).Tables("VENDEDORES").Rows(0).Item("CODIGO")
            'cbVendedor.Refresh()
            cbProveedor.Refresh()

            'Cod_Cliente = Clientes.ClientesBuscar(Trim(cbCliente.Text)).Tables("Clientes").Rows(0).Item("Codigo")

            'cbCliente.SelectedValue = Cod_Cliente

            'Cliente = ""
        End Sub

        Private Sub tCust_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles tCust.ColumnChanged

            If Not IsNumeric(e.Row.Item("Cantidad")) Then
                e.Row.Item("Cantidad") = ValorActualCantidad
            End If

            If e.Column.Ordinal = 5 Or e.Column.Ordinal = 6 Then
                If e.Row.Item("Cantidad") Is DBNull.Value Or e.Row.Item("Costo") Is DBNull.Value Then
                    '
                Else
                    If IsNumeric(e.Row.Item("Cantidad")) And IsNumeric(e.Row.Item("Costo")) Then
                        e.Row.Item("SubTotal") = (CDbl(e.Row.Item("Cantidad")) * CDbl(e.Row.Item("Costo"))).ToString(Round)
                    End If
                End If

            End If

            TotalPedido = 0
            TotalSugerido = 0

            For i = 0 To tCust.Rows.Count - 1
                If tCust.Rows(i)("Agregar") Is DBNull.Value Then
                    '
                Else
                    If tCust.Rows(i)("Agregar") = True Then
                        If tCust.Rows(i)("SubTotal") Is DBNull.Value Or tCust.Rows(i)("SubTotal").ToString = "" Or tCust.Rows(i)("SubTotal").ToString = "0.00" Then

                        ElseIf IsNumeric(tCust.Rows(i)("SubTotal")) And tCust.Rows(i)("SubTotal").ToString <> "" Then
                            Try
                                TotalPedido = TotalPedido + tCust.Rows(i)("SubTotal")
                                TotalSugerido = TotalSugerido + tCust.Rows(i)("SubTotal")
                            Catch ex As Exception
                                MsgBox(ex.Message)

                            End Try

                        End If
                    Else
                        If tCust.Rows(i)("SubTotal") Is DBNull.Value Or tCust.Rows(i)("SubTotal").ToString = "" Or tCust.Rows(i)("SubTotal").ToString = "0.00" Then

                        ElseIf IsNumeric(tCust.Rows(i)("SubTotal")) And tCust.Rows(i)("SubTotal").ToString <> "" Then
                            Try
                                'TotalPedido = TotalPedido + tCust.Rows(i)("SubTotal")
                                TotalSugerido = TotalSugerido + tCust.Rows(i)("SubTotal")
                            Catch ex As Exception
                                MsgBox(ex.Message)

                            End Try

                        End If
                    End If
                End If
            Next

            etTotal.Text = TotalPedido.ToString(Round)
            etTotalSugerido.Text = TotalSugerido.ToString(Round)
        End Sub

        Private Sub tCust_RowDeleted(ByVal sender As Object, ByVal e As System.Data.DataRowChangeEventArgs) Handles tCust.RowDeleted
            TotalPedido = 0
            'TotalSugerido = 0

            For i = 0 To tCust.Rows.Count - 1
                If tCust.Rows(i)("Agregar") = True Then
                    If tCust.Rows(i)("SubTotal") Is DBNull.Value Or tCust.Rows(i)("SubTotal").ToString = "" Or tCust.Rows(i)("SubTotal").ToString = "0.00" Then

                    ElseIf IsNumeric(tCust.Rows(i)("SubTotal")) And tCust.Rows(i)("SubTotal").ToString <> "" Then
                        Try 'MsgBox(tCust.Rows(i)("SubTotal").ToString)
                            TotalPedido = TotalPedido + tCust.Rows(i)("SubTotal")
                            'TotalSugerido = TotalSugerido + tCust.Rows(i)("SubTotal")
                        Catch ex As Exception
                            MsgBox(ex.Message)
                            'e.Row.Delete()
                        End Try
                    End If
                    'Else
                    '    If tCust.Rows(i)("SubTotal") Is DBNull.Value Or tCust.Rows(i)("SubTotal").ToString = "" Or tCust.Rows(i)("SubTotal").ToString = "0.00" Then

                    '    ElseIf IsNumeric(tCust.Rows(i)("SubTotal")) And tCust.Rows(i)("SubTotal").ToString <> "" Then
                    '        Try
                    '            TotalSugerido = TotalSugerido + tCust.Rows(i)("SubTotal")
                    '        Catch ex As Exception
                    '            MsgBox(ex.Message)
                    '        End Try
                    '    End If
                End If
            Next

            etTotal.Text = (TotalPedido).ToString(Round)
            'etTotalSugerido.Text = (TotalSugerido).ToString(Round)
        End Sub


        Private Sub LimpiarControles()
            txtPedido.Text = Pedidos.PedidoNumero
            etTotal.Text = (0).ToString(Round)
            etTotalSugerido.Text = (0).ToString(Round)
            'Indice = -1

            tCust.Rows.Clear()

            'MakeDataSet()
            'dgPedidos.SetDataBinding(myDataSet, "Articulos")
            'AddCustomDataTableStyle()

            'r.ComboAutoComplete(Articulo.ColumnComboBox)
            'r.ComboAutoComplete(ArticuloCodigo.ColumnComboBox)
        End Sub


        Private Sub cmdConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsulta.Click
            Dim f As frmBuscarItem = f.Instance

            If tCust.Rows.Count > 0 Then
                If tCust.Rows(tCust.Rows.Count - 1)("ArticuloCodigo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Articulo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Costo") Is DBNull.Value Then
                    tCust.Rows(tCust.Rows.Count - 1).Delete()
                End If
            End If

            f.MdiParent = Me.MdiParent
            f.Show()
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
                        'newRow1("CodigoTemporal") = ArticuloCodigo.ColumnComboBox.Items.Item(Articulo.ColumnComboBox.SelectedIndex)
                        newRow1("ArticuloCodigo") = tItem.Rows(k)("Codigo")
                        ' Add the row to the Customers table.
                        tCust.Rows.Add(newRow1)

                        'Articulo.ColumnComboBox.SelectedValue = tItem.Rows(k)("Codigo")
                        'ArticuloCodigo.ColumnComboBox.SelectedValue = tItem.Rows(k)("Codigo")
                        'ItemTipo.ColumnComboBox.SelectedValue = tItem.Rows(k)("Tipo")

                        'DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(tItem.Rows(k)("Codigo").ToString, tItem.Rows(k)("Tipo").ToString, EmpresaActual)

                        'tCust.Rows(rowChanging)("Codigo") = ArticuloCodigo.ColumnComboBox.Items.Item(Articulo.ColumnComboBox.SelectedIndex)
                        'tCust.Rows(tCust.Rows.Count - 1)("ArticuloCodigo") = tItem.Rows(k)("Codigo")
                        tCust.Rows(tCust.Rows.Count - 1)("Articulo") = tItem.Rows(k)("Descripcion")
                        tCust.Rows(tCust.Rows.Count - 1)("Cantidad") = tItem.Rows(k)("Cantidad")
                        tCust.Rows(tCust.Rows.Count - 1)("Costo") = CDbl(tItem.Rows(k)("Costo")).ToString(Round)

                        'If TipoDescuento = "A" Then
                        '    tCust.Rows(tCust.Rows.Count - 1)("Descuento") = CDbl(DetallesProducto.Descuento_A).ToString(Round)
                        'ElseIf TipoDescuento = "B" Then
                        '    tCust.Rows(tCust.Rows.Count - 1)("Descuento") = CDbl(DetallesProducto.Descuento_B).ToString(Round)
                        'ElseIf TipoDescuento = "C" Then
                        '    tCust.Rows(tCust.Rows.Count - 1)("Descuento") = CDbl(DetallesProducto.Descuento_C).ToString(Round)
                        'Else
                        '    tCust.Rows(tCust.Rows.Count - 1)("Descuento") = "0.00"

                        'End If

                        tCust.Rows(tCust.Rows.Count - 1)("Tipo") = tItem.Rows(k)("Tipo")

                    End If
                Next
                tItem.Clear()
                'ArticuloCodigo.TextBox.Focus()

            End If

        End Sub

        Private Sub etTotalT_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles etTotalT.MouseEnter

            AgregarItem()
        End Sub

        Private Sub frmPedidosSugerido_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter

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

        Private Sub cmdConsultaProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultaProveedor.Click
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

        Private Sub cmdGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerar.Click
            If Me.cbProveedor.SelectedValue = Nothing Then
                MsgBox("Seleccione el Proveedor", MsgBoxStyle.Critical)
                Me.cbProveedor.Focus()
                Exit Sub
            End If

            ds = Pedidos.SugerirPedido(cbProveedor.SelectedValue)
            MakeDataSet()
            dgPedidos.SetDataBinding(myDataSet, "Articulos")
            AddCustomDataTableStyle()
        End Sub

        Private Sub dgPedidos_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dgPedidos.MouseUp
            Dim hti As DataGrid.HitTestInfo = Me.dgPedidos.HitTest(e.X, e.Y)
            Try
                If hti.Type = DataGrid.HitTestType.Cell AndAlso hti.Column = myCheckBoxCol Then
                    Me.dgPedidos(hti.Row, hti.Column) = Not CBool(Me.dgPedidos(hti.Row, hti.Column))
                Else
                    Exit Sub
                End If
            Catch ex As Exception
                'MessageBox.Show(ex.ToString())
            End Try
        End Sub 'dataGrid2_MouseUp

        Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click

        End Sub
    End Class

End Namespace
