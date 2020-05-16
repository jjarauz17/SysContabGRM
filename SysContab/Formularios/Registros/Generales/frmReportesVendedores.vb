Public Class frmReportesVendedores
    Inherits DevExpress.XtraEditors.XtraForm
    Private Shared ChildInstance As frmReportesVendedores = Nothing

    Public Shared Function Instance() As frmReportesVendedores
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmReportesVendedores()
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
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rbCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents rbAlfabetico As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbZonas As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbGeneral As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbArchivo As System.Windows.Forms.RadioButton
    Friend WithEvents rbImpresora As System.Windows.Forms.RadioButton
    Friend WithEvents rbPantalla As System.Windows.Forms.RadioButton
    Friend WithEvents cbMunicipios As System.Windows.Forms.ComboBox
    Friend WithEvents cbDepartamentos As System.Windows.Forms.ComboBox
    Friend WithEvents rbZona As System.Windows.Forms.RadioButton
    Friend WithEvents rbMunicipio As System.Windows.Forms.RadioButton
    Friend WithEvents rbDepartamento As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbLineas As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents cbVendedores As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rbComisiones As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents rbCotizacion As System.Windows.Forms.RadioButton
    Friend WithEvents rbFacturado As System.Windows.Forms.RadioButton
    Friend WithEvents rbFacCot As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents rbFecha As System.Windows.Forms.RadioButton
    Friend WithEvents rbMes As System.Windows.Forms.RadioButton
    Friend WithEvents DTP1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents rbCliente As System.Windows.Forms.RadioButton
    Friend WithEvents rbVentas As System.Windows.Forms.RadioButton
    Friend WithEvents cbFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbMes As System.Windows.Forms.ComboBox
    Friend WithEvents ckTime As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.rbCliente = New System.Windows.Forms.RadioButton
        Me.rbZona = New System.Windows.Forms.RadioButton
        Me.rbMunicipio = New System.Windows.Forms.RadioButton
        Me.rbDepartamento = New System.Windows.Forms.RadioButton
        Me.rbCodigo = New System.Windows.Forms.RadioButton
        Me.rbAlfabetico = New System.Windows.Forms.RadioButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cbFormaPago = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbVendedores = New System.Windows.Forms.ComboBox
        Me.cbClientes = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbLineas = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbMunicipios = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbZonas = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbDepartamentos = New System.Windows.Forms.ComboBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbComisiones = New System.Windows.Forms.RadioButton
        Me.rbVentas = New System.Windows.Forms.RadioButton
        Me.rbGeneral = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbArchivo = New System.Windows.Forms.RadioButton
        Me.rbImpresora = New System.Windows.Forms.RadioButton
        Me.rbPantalla = New System.Windows.Forms.RadioButton
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.rbFacCot = New System.Windows.Forms.RadioButton
        Me.rbCotizacion = New System.Windows.Forms.RadioButton
        Me.rbFacturado = New System.Windows.Forms.RadioButton
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.DTP2 = New System.Windows.Forms.DateTimePicker
        Me.cbMes = New System.Windows.Forms.ComboBox
        Me.rbFecha = New System.Windows.Forms.RadioButton
        Me.rbMes = New System.Windows.Forms.RadioButton
        Me.DTP1 = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.ckTime = New System.Windows.Forms.CheckBox
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox6.Controls.Add(Me.rbCliente)
        Me.GroupBox6.Controls.Add(Me.rbZona)
        Me.GroupBox6.Controls.Add(Me.rbMunicipio)
        Me.GroupBox6.Controls.Add(Me.rbDepartamento)
        Me.GroupBox6.Controls.Add(Me.rbCodigo)
        Me.GroupBox6.Controls.Add(Me.rbAlfabetico)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox6.Location = New System.Drawing.Point(288, 272)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(136, 176)
        Me.GroupBox6.TabIndex = 146
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "ORDEN"
        '
        'rbCliente
        '
        Me.rbCliente.Checked = True
        Me.rbCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCliente.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbCliente.Location = New System.Drawing.Point(16, 15)
        Me.rbCliente.Name = "rbCliente"
        Me.rbCliente.Size = New System.Drawing.Size(112, 32)
        Me.rbCliente.TabIndex = 5
        Me.rbCliente.TabStop = True
        Me.rbCliente.Text = "Cliente"
        '
        'rbZona
        '
        Me.rbZona.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbZona.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbZona.Location = New System.Drawing.Point(16, 85)
        Me.rbZona.Name = "rbZona"
        Me.rbZona.Size = New System.Drawing.Size(112, 32)
        Me.rbZona.TabIndex = 4
        Me.rbZona.Text = "Zona"
        '
        'rbMunicipio
        '
        Me.rbMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMunicipio.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbMunicipio.Location = New System.Drawing.Point(16, 61)
        Me.rbMunicipio.Name = "rbMunicipio"
        Me.rbMunicipio.Size = New System.Drawing.Size(112, 32)
        Me.rbMunicipio.TabIndex = 3
        Me.rbMunicipio.Text = "Municipio"
        '
        'rbDepartamento
        '
        Me.rbDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDepartamento.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbDepartamento.Location = New System.Drawing.Point(16, 37)
        Me.rbDepartamento.Name = "rbDepartamento"
        Me.rbDepartamento.Size = New System.Drawing.Size(112, 32)
        Me.rbDepartamento.TabIndex = 2
        Me.rbDepartamento.Text = "Departamento"
        '
        'rbCodigo
        '
        Me.rbCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbCodigo.Location = New System.Drawing.Point(16, 133)
        Me.rbCodigo.Name = "rbCodigo"
        Me.rbCodigo.Size = New System.Drawing.Size(112, 32)
        Me.rbCodigo.TabIndex = 1
        Me.rbCodigo.Text = "Código"
        '
        'rbAlfabetico
        '
        Me.rbAlfabetico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAlfabetico.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbAlfabetico.Location = New System.Drawing.Point(16, 109)
        Me.rbAlfabetico.Name = "rbAlfabetico"
        Me.rbAlfabetico.Size = New System.Drawing.Size(112, 32)
        Me.rbAlfabetico.TabIndex = 0
        Me.rbAlfabetico.Text = "Alfabético"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.cbFormaPago)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.cbVendedores)
        Me.GroupBox4.Controls.Add(Me.cbClientes)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.cbLineas)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.cbMunicipios)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.cbZonas)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.cbDepartamentos)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(288, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(440, 248)
        Me.GroupBox4.TabIndex = 145
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CRITERIOS DE SELECCION"
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 216)
        Me.Label9.Name = "Label9"
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "Forma de Pago"
        '
        'cbFormaPago
        '
        Me.cbFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFormaPago.Location = New System.Drawing.Point(112, 216)
        Me.cbFormaPago.Name = "cbFormaPago"
        Me.cbFormaPago.Size = New System.Drawing.Size(312, 23)
        Me.cbFormaPago.TabIndex = 75
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Vendedor"
        '
        'cbVendedores
        '
        Me.cbVendedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbVendedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbVendedores.Location = New System.Drawing.Point(112, 24)
        Me.cbVendedores.Name = "cbVendedores"
        Me.cbVendedores.Size = New System.Drawing.Size(312, 23)
        Me.cbVendedores.TabIndex = 73
        '
        'cbClientes
        '
        Me.cbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClientes.Location = New System.Drawing.Point(112, 56)
        Me.cbClientes.Name = "cbClientes"
        Me.cbClientes.Size = New System.Drawing.Size(312, 23)
        Me.cbClientes.TabIndex = 72
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Cliente"
        '
        'cbLineas
        '
        Me.cbLineas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLineas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLineas.Location = New System.Drawing.Point(112, 88)
        Me.cbLineas.Name = "cbLineas"
        Me.cbLineas.Size = New System.Drawing.Size(312, 23)
        Me.cbLineas.TabIndex = 70
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Línea"
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Municipio"
        '
        'cbMunicipios
        '
        Me.cbMunicipios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMunicipios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMunicipios.Location = New System.Drawing.Point(112, 152)
        Me.cbMunicipios.Name = "cbMunicipios"
        Me.cbMunicipios.Size = New System.Drawing.Size(312, 23)
        Me.cbMunicipios.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Zona"
        '
        'cbZonas
        '
        Me.cbZonas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbZonas.Location = New System.Drawing.Point(112, 184)
        Me.cbZonas.Name = "cbZonas"
        Me.cbZonas.Size = New System.Drawing.Size(312, 23)
        Me.cbZonas.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Departamento"
        '
        'cbDepartamentos
        '
        Me.cbDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDepartamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDepartamentos.Location = New System.Drawing.Point(112, 120)
        Me.cbDepartamentos.Name = "cbDepartamentos"
        Me.cbDepartamentos.Size = New System.Drawing.Size(312, 23)
        Me.cbDepartamentos.TabIndex = 63
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox3.Controls.Add(Me.cmdSalir)
        Me.GroupBox3.Controls.Add(Me.cmdAceptar)
        Me.GroupBox3.Location = New System.Drawing.Point(288, 448)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(192, 40)
        Me.GroupBox3.TabIndex = 144
        Me.GroupBox3.TabStop = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Location = New System.Drawing.Point(104, 10)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 24)
        Me.cmdSalir.TabIndex = 22
        Me.cmdSalir.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Location = New System.Drawing.Point(16, 10)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 24)
        Me.cmdAceptar.TabIndex = 20
        Me.cmdAceptar.Text = "Aceptar"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox2.Controls.Add(Me.rbComisiones)
        Me.GroupBox2.Controls.Add(Me.rbVentas)
        Me.GroupBox2.Controls.Add(Me.rbGeneral)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(24, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(224, 128)
        Me.GroupBox2.TabIndex = 143
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TIPO DE REPORTE"
        '
        'rbComisiones
        '
        Me.rbComisiones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbComisiones.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbComisiones.Location = New System.Drawing.Point(16, 88)
        Me.rbComisiones.Name = "rbComisiones"
        Me.rbComisiones.Size = New System.Drawing.Size(96, 16)
        Me.rbComisiones.TabIndex = 140
        Me.rbComisiones.Text = "Comisión"
        '
        'rbVentas
        '
        Me.rbVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbVentas.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbVentas.Location = New System.Drawing.Point(16, 61)
        Me.rbVentas.Name = "rbVentas"
        Me.rbVentas.Size = New System.Drawing.Size(152, 16)
        Me.rbVentas.TabIndex = 3
        Me.rbVentas.Text = "Ventas Realizadas"
        '
        'rbGeneral
        '
        Me.rbGeneral.Checked = True
        Me.rbGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbGeneral.Location = New System.Drawing.Point(16, 32)
        Me.rbGeneral.Name = "rbGeneral"
        Me.rbGeneral.Size = New System.Drawing.Size(136, 16)
        Me.rbGeneral.TabIndex = 0
        Me.rbGeneral.TabStop = True
        Me.rbGeneral.Text = "Datos Generales"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox1.Controls.Add(Me.rbArchivo)
        Me.GroupBox1.Controls.Add(Me.rbImpresora)
        Me.GroupBox1.Controls.Add(Me.rbPantalla)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(464, 272)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(136, 104)
        Me.GroupBox1.TabIndex = 142
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FORMATO"
        '
        'rbArchivo
        '
        Me.rbArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbArchivo.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbArchivo.Location = New System.Drawing.Point(16, 64)
        Me.rbArchivo.Name = "rbArchivo"
        Me.rbArchivo.Size = New System.Drawing.Size(112, 32)
        Me.rbArchivo.TabIndex = 2
        Me.rbArchivo.Text = "Archivo"
        '
        'rbImpresora
        '
        Me.rbImpresora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbImpresora.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbImpresora.Location = New System.Drawing.Point(16, 40)
        Me.rbImpresora.Name = "rbImpresora"
        Me.rbImpresora.Size = New System.Drawing.Size(112, 32)
        Me.rbImpresora.TabIndex = 1
        Me.rbImpresora.Text = "Impresora"
        '
        'rbPantalla
        '
        Me.rbPantalla.Checked = True
        Me.rbPantalla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPantalla.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbPantalla.Location = New System.Drawing.Point(16, 16)
        Me.rbPantalla.Name = "rbPantalla"
        Me.rbPantalla.Size = New System.Drawing.Size(112, 32)
        Me.rbPantalla.TabIndex = 0
        Me.rbPantalla.TabStop = True
        Me.rbPantalla.Text = "Pantalla"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox7.Controls.Add(Me.rbFacCot)
        Me.GroupBox7.Controls.Add(Me.rbCotizacion)
        Me.GroupBox7.Controls.Add(Me.rbFacturado)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox7.Location = New System.Drawing.Point(24, 152)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(224, 112)
        Me.GroupBox7.TabIndex = 147
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "TIPO DE REPORTE"
        '
        'rbFacCot
        '
        Me.rbFacCot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFacCot.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbFacCot.Location = New System.Drawing.Point(16, 80)
        Me.rbFacCot.Name = "rbFacCot"
        Me.rbFacCot.Size = New System.Drawing.Size(144, 16)
        Me.rbFacCot.TabIndex = 4
        Me.rbFacCot.Text = "Factura/Cotización"
        '
        'rbCotizacion
        '
        Me.rbCotizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCotizacion.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbCotizacion.Location = New System.Drawing.Point(16, 52)
        Me.rbCotizacion.Name = "rbCotizacion"
        Me.rbCotizacion.Size = New System.Drawing.Size(112, 16)
        Me.rbCotizacion.TabIndex = 3
        Me.rbCotizacion.Text = "Cotización"
        '
        'rbFacturado
        '
        Me.rbFacturado.Checked = True
        Me.rbFacturado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFacturado.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbFacturado.Location = New System.Drawing.Point(16, 24)
        Me.rbFacturado.Name = "rbFacturado"
        Me.rbFacturado.Size = New System.Drawing.Size(112, 16)
        Me.rbFacturado.TabIndex = 0
        Me.rbFacturado.TabStop = True
        Me.rbFacturado.Text = "Facturado"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox8.Controls.Add(Me.Label8)
        Me.GroupBox8.Controls.Add(Me.DTP2)
        Me.GroupBox8.Controls.Add(Me.cbMes)
        Me.GroupBox8.Controls.Add(Me.rbFecha)
        Me.GroupBox8.Controls.Add(Me.rbMes)
        Me.GroupBox8.Controls.Add(Me.DTP1)
        Me.GroupBox8.Controls.Add(Me.Label7)
        Me.GroupBox8.Controls.Add(Me.ckTime)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox8.Location = New System.Drawing.Point(24, 272)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(224, 176)
        Me.GroupBox8.TabIndex = 148
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "TIEMPO"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(32, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 16)
        Me.Label8.TabIndex = 151
        Me.Label8.Text = "Hasta:"
        '
        'DTP2
        '
        Me.DTP2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DTP2.Enabled = False
        Me.DTP2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DTP2.Location = New System.Drawing.Point(72, 136)
        Me.DTP2.MinDate = New Date(1760, 1, 1, 0, 0, 0, 0)
        Me.DTP2.Name = "DTP2"
        Me.DTP2.Size = New System.Drawing.Size(144, 21)
        Me.DTP2.TabIndex = 150
        '
        'cbMes
        '
        Me.cbMes.Enabled = False
        Me.cbMes.Location = New System.Drawing.Point(72, 48)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(144, 23)
        Me.cbMes.TabIndex = 4
        '
        'rbFecha
        '
        Me.rbFecha.Enabled = False
        Me.rbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFecha.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbFecha.Location = New System.Drawing.Point(16, 80)
        Me.rbFecha.Name = "rbFecha"
        Me.rbFecha.Size = New System.Drawing.Size(80, 16)
        Me.rbFecha.TabIndex = 3
        Me.rbFecha.Text = "Fechas"
        '
        'rbMes
        '
        Me.rbMes.Enabled = False
        Me.rbMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMes.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbMes.Location = New System.Drawing.Point(16, 48)
        Me.rbMes.Name = "rbMes"
        Me.rbMes.Size = New System.Drawing.Size(56, 16)
        Me.rbMes.TabIndex = 0
        Me.rbMes.Text = "Mes"
        '
        'DTP1
        '
        Me.DTP1.Enabled = False
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DTP1.Location = New System.Drawing.Point(72, 104)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(144, 21)
        Me.DTP1.TabIndex = 149
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 16)
        Me.Label7.TabIndex = 149
        Me.Label7.Text = "De:"
        '
        'ckTime
        '
        Me.ckTime.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ckTime.Location = New System.Drawing.Point(16, 16)
        Me.ckTime.Name = "ckTime"
        Me.ckTime.TabIndex = 152
        '
        'frmReportesVendedores
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(744, 494)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmReportesVendedores"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Mes As String
    Private Sub frmReportesVendedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Mes As New VB.SysContab.MesesDB()
        Dim Vendedor As New VB.SysContab.VendedoresDB()
        Dim Cliente As New VB.SysContab.ClientesDB()
        Dim Linea As New VB.SysContab.ArticulosDB()
        Dim Dpto As New VB.SysContab.DepartamentosCDB()
        Dim Zonas As New VB.SysContab.ZonasDB()
        Dim FPago As New VB.SysContab.Forma_PagoDB()
        Dim r As New VB.SysContab.Rutinas()



        '  '''r.CambiarEstilo(Me)

        Me.DTP1.Value = VB.SysContab.Rutinas.Fecha()
        Me.DTP2.Value = VB.SysContab.Rutinas.Fecha()

        cbMes.DataSource = Mes.MesexPeriodo.Tables("Meses")
        cbMes.ValueMember = "Mes"
        cbMes.DisplayMember = "MesAnno"
        cbMes.SelectedValue = 0

        cbVendedores.DataSource = Vendedor.VendedoresList.Tables("Vendedores")
        cbVendedores.ValueMember = "Codigo"
        cbVendedores.DisplayMember = "Nombre"
        cbVendedores.SelectedValue = 0

        cbClientes.DataSource = Cliente.GetList.Tables("CLIENTES")
        cbClientes.ValueMember = "Codigo"
        cbClientes.DisplayMember = "Nombre"
        cbClientes.SelectedValue = 0

        cbLineas.DataSource = Linea.ArticulosListLineas().Tables("Grupos_Inventario")
        cbLineas.ValueMember = "Codigo"
        cbLineas.DisplayMember = "Nombre"


        cbDepartamentos.DataSource = Dpto.List()    '.Tables("DepartamentosC")
        cbDepartamentos.ValueMember = "Codigo"
        cbDepartamentos.DisplayMember = "Nombre"
        cbDepartamentos.SelectedValue = 0

        cbZonas.DataSource = Zonas.GetListNombre("%").Tables("Zonas")
        cbZonas.ValueMember = "Codigo"
        cbZonas.DisplayMember = "Nombre"
        cbZonas.SelectedValue = 0

        cbFormaPago.DataSource = FPago.FormaPagoListAll().Tables("Forma_Pago")
        cbFormaPago.ValueMember = "Codigo"
        cbFormaPago.DisplayMember = "Nombre"
        cbFormaPago.SelectedValue = 0

    End Sub

    Private Sub rbGeneral_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbGeneral.CheckedChanged
        GroupBox7.Enabled = False
    End Sub
    Private Sub rbVentas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbVentas.CheckedChanged
        GroupBox7.Enabled = True
    End Sub
    Private Sub rbComisiones_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbComisiones.CheckedChanged
        GroupBox7.Enabled = True
    End Sub

    Private Sub rbMes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMes.CheckedChanged
        cbMes.Enabled = True
        DTP1.Enabled = False
        DTP2.Enabled = False
        Mes = cbMes.SelectedValue
    End Sub

    Private Sub rbFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFecha.CheckedChanged
        cbMes.Enabled = False
        DTP1.Enabled = True
        DTP2.Enabled = True
        Mes = 0
    End Sub

    Private Sub cbDepartamentos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDepartamentos.SelectedIndexChanged
        Dim Muni As New VB.SysContab.MunicipiosDB

        If IsNumeric(cbDepartamentos.SelectedValue) Then
            cbMunicipios.DataSource = Muni.List(cbDepartamentos.SelectedValue.ToString).Tables("Municipios")
            cbMunicipios.ValueMember = "Codigo"
            cbMunicipios.DisplayMember = "Nombre"
        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim fReportes As New frmReportes
        Dim Clientes As New VB.SysContab.ClientesDB
        Dim Vendedores As New VB.SysContab.VendedoresDB
        Dim TipoReporte As Integer

        Dim Orden As Integer
        Dim Fecha1 As String
        Dim Fecha2 As String        
        Dim ds As DataSet

        If rbDepartamento.Checked = True Then
            Orden = 1
        ElseIf rbMunicipio.Checked = True Then
            Orden = 2
        ElseIf rbZona.Checked = True Then
            Orden = 3
        ElseIf rbAlfabetico.Checked = True Then
            Orden = 4
        ElseIf rbCodigo.Checked = True Then
            Orden = 5
        ElseIf rbCliente.Checked = True Then
            Orden = 6
        End If

        'If cbZonas.SelectedIndex = -1 Then
        'Zona = 0
        'Else
        '    Zona = cbZonas.SelectedValue
        'End If
        If rbMes.Checked = True Then
            Mes = cbMes.SelectedValue
        Else
            Mes = 0
        End If

        If rbFecha.Checked = True Then
            Fecha1 = DTP1.Value.Date
            Fecha2 = DTP2.Value.Date
        Else
            Fecha1 = ""
            Fecha2 = ""
        End If

        If rbGeneral.Checked = True Then
            TipoReporte = 1
            ds = Vendedores.GeneradorReportes(TipoReporte, Mes, Fecha1, Fecha2, _
                cbVendedores.SelectedValue, cbClientes.SelectedValue, cbLineas.SelectedValue, _
                cbDepartamentos.SelectedValue, cbMunicipios.SelectedValue, 0, Orden, cbFormaPago.SelectedValue)
            ds.WriteXml(Application.StartupPath & "\xml\RepVendedores.xml", XmlWriteMode.WriteSchema)
            'Dim rVendedor As New rptVendedores

            Dim rVendedor As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            rVendedor.Load(Application.StartupPath & "\Reportes\rptVendedores.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            '
            rVendedor.Database.Tables("_GeneradorReportesVendedores").Location = Application.StartupPath & "\xml\RepVendedores.xml"
            rVendedor.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoempresa.xml"
            fReportes.crvReportes.ReportSource = rVendedor
        End If

        If rbVentas.Checked = True Then
            If rbFacturado.Checked = True Then
                TipoReporte = 2
                ds = Vendedores.GeneradorReportes(TipoReporte, Mes, Fecha1, Fecha2, _
                        cbVendedores.SelectedValue, cbClientes.SelectedValue, cbLineas.SelectedValue, _
                        cbDepartamentos.SelectedValue, cbMunicipios.SelectedValue, 0, Orden, cbFormaPago.SelectedValue)
                ds.WriteXml(Application.StartupPath & "\xml\RepVendedores.xml", XmlWriteMode.WriteSchema)
                'Dim rVendedor2 As New rptVendedoresFacturado

                Dim rVendedor2 As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                rVendedor2.Load(Application.StartupPath & "\Reportes\rptVendedoresFacturado.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
                '
                rVendedor2.Database.Tables("_GeneradorReportesVendedores;1").Location = Application.StartupPath & "\xml\RepVendedores.xml"
                rVendedor2.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoempresa.xml"
                fReportes.crvReportes.ReportSource = rVendedor2
            End If

            If rbCotizacion.Checked = True Then
                TipoReporte = 3
                ds = Vendedores.GeneradorReportes(TipoReporte, Mes, Fecha1, Fecha2, _
                            cbVendedores.SelectedValue, cbClientes.SelectedValue, cbLineas.SelectedValue, _
                            cbDepartamentos.SelectedValue, cbMunicipios.SelectedValue, 0, Orden, cbFormaPago.SelectedValue)
                ds.WriteXml(Application.StartupPath & "\xml\RepVendedores.xml", XmlWriteMode.WriteSchema)
                'Dim rVendedor As New rptVendedoresCotizacionFac
                Dim rVendedor As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                rVendedor.Load(Application.StartupPath & "\Reportes\rptVendedoresCotizacionFac.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
                '
                rVendedor.Database.Tables("_GeneradorReportesVendedores;1").Location = Application.StartupPath & "\xml\RepVendedores.xml"
                rVendedor.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoempresa.xml"
                fReportes.crvReportes.ReportSource = rVendedor
            End If
            If rbFacCot.Checked = True Then
                TipoReporte = 4
                ds = Vendedores.GeneradorReportes(TipoReporte, Mes, Fecha1, Fecha2, _
                                cbVendedores.SelectedValue, cbClientes.SelectedValue, cbLineas.SelectedValue, _
                                cbDepartamentos.SelectedValue, cbMunicipios.SelectedValue, 0, Orden, cbFormaPago.SelectedValue)
                ds.WriteXml(Application.StartupPath & "\xml\RepVendedores.xml", XmlWriteMode.WriteSchema)
                'Dim rVendedor As New rptVendedoresCotizacionFac
                Dim rVendedor As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                rVendedor.Load(Application.StartupPath & "\Reportes\rptVendedoresCotizacionFac.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
                '
                rVendedor.Database.Tables("_GeneradorReportesVendedores;1").Location = Application.StartupPath & "\xml\RepVendedores.xml"
                rVendedor.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoempresa.xml"
                fReportes.crvReportes.ReportSource = rVendedor
            End If
        End If

        If rbComisiones.Checked = True Then
            TipoReporte = 5
            ds = Vendedores.GeneradorReportes(TipoReporte, Mes, Fecha1, Fecha2, _
                                cbVendedores.SelectedValue, cbClientes.SelectedValue, cbLineas.SelectedValue, _
                                cbDepartamentos.SelectedValue, cbMunicipios.SelectedValue, 0, Orden, cbFormaPago.SelectedValue)
            ds.WriteXml(Application.StartupPath & "\xml\RepVendedores.xml", XmlWriteMode.WriteSchema)
            'Dim rVendedor As New rptVendedoresComision
            Dim rVendedor As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            rVendedor.Load(Application.StartupPath & "\Reportes\rptVendedoresComision.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            '
            rVendedor.Database.Tables("_GeneradorReportesVendedores;1").Location = Application.StartupPath & "\xml\RepVendedores.xml"
            rVendedor.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoempresa.xml"
            fReportes.crvReportes.ReportSource = rVendedor
        End If

        If rbPantalla.Checked = True Then
            fReportes.Show()
        ElseIf rbImpresora.Checked = True Then
            fReportes.crvReportes.PrintReport()
        Else
            fReportes.crvReportes.ExportReport()
        End If

    End Sub

    Private Sub ckTime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckTime.CheckedChanged
        If ckTime.Checked = True Then
            Me.rbMes.Enabled = True
            cbMes.Enabled = True
            Me.rbFecha.Enabled = True
        Else
            Me.rbMes.Enabled = False
            rbMes.Checked = False
            cbMes.Enabled = False
            Me.rbFecha.Enabled = False
            Me.DTP1.Enabled = False
            Me.DTP2.Enabled = False
            Fecha1 = ""
            Fecha2 = ""
            Mes = 0
        End If
    End Sub
End Class
