Public Class frmReportesFactura
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmReportesFactura = Nothing

    Public Shared Function Instance() As frmReportesFactura
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmReportesFactura()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Dim Mes As New VB.SysContab.MesesDB()
    Dim Cliente As New VB.SysContab.ClientesDB()
    Dim Articulo As New VB.SysContab.ArticulosDB()
    Dim Puntos_Venta As New VB.SysContab.PuntosVentasDB()
    Dim Servicios As New VB.SysContab.ServiciosDB()
    Dim Vendedores As New VB.SysContab.VendedoresDB()
    Dim Rutinas As New VB.SysContab.Rutinas()
    Friend WithEvents dgCodigo As System.Windows.Forms.DataGrid

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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbMes As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rbVTotales As System.Windows.Forms.RadioButton
    Friend WithEvents rbVContado As System.Windows.Forms.RadioButton
    Friend WithEvents rbVCredito As System.Windows.Forms.RadioButton
    Friend WithEvents rbIVA As System.Windows.Forms.RadioButton
    Friend WithEvents rbCpC As System.Windows.Forms.RadioButton
    Friend WithEvents rbVentas As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents rbFile As System.Windows.Forms.RadioButton
    Friend WithEvents rbPrint As System.Windows.Forms.RadioButton
    Friend WithEvents rbScreen As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rbRango As System.Windows.Forms.RadioButton
    Friend WithEvents rbFecha1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbMes As System.Windows.Forms.RadioButton
    Friend WithEvents cbLineas As System.Windows.Forms.ComboBox
    Friend WithEvents cbSubGrupos As System.Windows.Forms.ComboBox
    Friend WithEvents cbGrupos As System.Windows.Forms.ComboBox
    Friend WithEvents cbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents cbProductos As System.Windows.Forms.ComboBox
    Friend WithEvents tbCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbVendedores As System.Windows.Forms.ComboBox
    Friend WithEvents tbValorTotal As System.Windows.Forms.TextBox
    Friend WithEvents rbVServicio As System.Windows.Forms.RadioButton
    Friend WithEvents rbVProducto As System.Windows.Forms.RadioButton
    Friend WithEvents rbRangoFact As System.Windows.Forms.RadioButton
    Friend WithEvents rbTotalFact As System.Windows.Forms.RadioButton
    Friend WithEvents tbTotal As System.Windows.Forms.TextBox
    Friend WithEvents tbRango1 As System.Windows.Forms.TextBox
    Friend WithEvents tbRango2 As System.Windows.Forms.TextBox
    Friend WithEvents tbVProducto As System.Windows.Forms.TextBox
    Friend WithEvents tbVServicio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents rbProducto As System.Windows.Forms.RadioButton
    Friend WithEvents rbServicio As System.Windows.Forms.RadioButton
    Friend WithEvents rbBoth As System.Windows.Forms.RadioButton
    Friend WithEvents rbNinguno As System.Windows.Forms.RadioButton
    Friend WithEvents rbOrdenFecha As System.Windows.Forms.RadioButton
    Friend WithEvents rbOrdenCliente As System.Windows.Forms.RadioButton
    Friend WithEvents DTPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPickerHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPickerDe As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents etDescripcion As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rbArtAll As System.Windows.Forms.RadioButton
    Friend WithEvents rbOrdenFac As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbVCredito = New System.Windows.Forms.RadioButton()
        Me.rbVContado = New System.Windows.Forms.RadioButton()
        Me.rbVTotales = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DTPickerDe = New System.Windows.Forms.DateTimePicker()
        Me.DTPickerHasta = New System.Windows.Forms.DateTimePicker()
        Me.cbMes = New System.Windows.Forms.ComboBox()
        Me.DTPicker = New System.Windows.Forms.DateTimePicker()
        Me.rbRango = New System.Windows.Forms.RadioButton()
        Me.rbFecha1 = New System.Windows.Forms.RadioButton()
        Me.rbMes = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbVendedores = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbCodigo = New System.Windows.Forms.TextBox()
        Me.cbSubGrupos = New System.Windows.Forms.ComboBox()
        Me.cbGrupos = New System.Windows.Forms.ComboBox()
        Me.cbLineas = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbProductos = New System.Windows.Forms.ComboBox()
        Me.cbClientes = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rbNinguno = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbVServicio = New System.Windows.Forms.TextBox()
        Me.tbVProducto = New System.Windows.Forms.TextBox()
        Me.tbRango2 = New System.Windows.Forms.TextBox()
        Me.tbRango1 = New System.Windows.Forms.TextBox()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.rbVServicio = New System.Windows.Forms.RadioButton()
        Me.rbVProducto = New System.Windows.Forms.RadioButton()
        Me.rbRangoFact = New System.Windows.Forms.RadioButton()
        Me.rbTotalFact = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rbIVA = New System.Windows.Forms.RadioButton()
        Me.rbCpC = New System.Windows.Forms.RadioButton()
        Me.rbVentas = New System.Windows.Forms.RadioButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.rbOrdenFac = New System.Windows.Forms.RadioButton()
        Me.rbOrdenCliente = New System.Windows.Forms.RadioButton()
        Me.rbOrdenFecha = New System.Windows.Forms.RadioButton()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.rbFile = New System.Windows.Forms.RadioButton()
        Me.rbPrint = New System.Windows.Forms.RadioButton()
        Me.rbScreen = New System.Windows.Forms.RadioButton()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.Print = New DevExpress.XtraEditors.SimpleButton()
        Me.tbValorTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.rbArtAll = New System.Windows.Forms.RadioButton()
        Me.rbProducto = New System.Windows.Forms.RadioButton()
        Me.rbServicio = New System.Windows.Forms.RadioButton()
        Me.rbBoth = New System.Windows.Forms.RadioButton()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.etDescripcion = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbVCredito, Me.rbVContado, Me.rbVTotales})
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(41, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 104)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMACION "
        '
        'rbVCredito
        '
        Me.rbVCredito.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbVCredito.Location = New System.Drawing.Point(8, 72)
        Me.rbVCredito.Name = "rbVCredito"
        Me.rbVCredito.Size = New System.Drawing.Size(136, 24)
        Me.rbVCredito.TabIndex = 2
        Me.rbVCredito.Text = "Ventas al Crédito"
        Me.rbVCredito.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbVContado
        '
        Me.rbVContado.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbVContado.Location = New System.Drawing.Point(8, 48)
        Me.rbVContado.Name = "rbVContado"
        Me.rbVContado.Size = New System.Drawing.Size(144, 24)
        Me.rbVContado.TabIndex = 1
        Me.rbVContado.Text = "Ventas de Contado"
        Me.rbVContado.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbVTotales
        '
        Me.rbVTotales.Checked = True
        Me.rbVTotales.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbVTotales.Location = New System.Drawing.Point(8, 24)
        Me.rbVTotales.Name = "rbVTotales"
        Me.rbVTotales.Size = New System.Drawing.Size(112, 24)
        Me.rbVTotales.TabIndex = 0
        Me.rbVTotales.TabStop = True
        Me.rbVTotales.Text = "Ventas Totales"
        Me.rbVTotales.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.DTPickerDe, Me.DTPickerHasta, Me.cbMes, Me.DTPicker, Me.rbRango, Me.rbFecha1, Me.rbMes, Me.Label6, Me.Label5})
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(41, 152)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(312, 152)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "TIEMPO"
        '
        'DTPickerDe
        '
        Me.DTPickerDe.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DTPickerDe.Location = New System.Drawing.Point(104, 93)
        Me.DTPickerDe.Name = "DTPickerDe"
        Me.DTPickerDe.Size = New System.Drawing.Size(120, 21)
        Me.DTPickerDe.TabIndex = 15
        '
        'DTPickerHasta
        '
        Me.DTPickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DTPickerHasta.Location = New System.Drawing.Point(104, 118)
        Me.DTPickerHasta.Name = "DTPickerHasta"
        Me.DTPickerHasta.Size = New System.Drawing.Size(120, 21)
        Me.DTPickerHasta.TabIndex = 14
        '
        'cbMes
        '
        Me.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMes.Location = New System.Drawing.Point(104, 24)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(120, 23)
        Me.cbMes.TabIndex = 4
        '
        'DTPicker
        '
        Me.DTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DTPicker.Location = New System.Drawing.Point(104, 50)
        Me.DTPicker.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.DTPicker.Name = "DTPicker"
        Me.DTPicker.Size = New System.Drawing.Size(120, 21)
        Me.DTPicker.TabIndex = 13
        '
        'rbRango
        '
        Me.rbRango.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbRango.Location = New System.Drawing.Point(8, 74)
        Me.rbRango.Name = "rbRango"
        Me.rbRango.Size = New System.Drawing.Size(88, 24)
        Me.rbRango.TabIndex = 3
        Me.rbRango.Text = "RANGO"
        Me.rbRango.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbFecha1
        '
        Me.rbFecha1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbFecha1.Location = New System.Drawing.Point(8, 50)
        Me.rbFecha1.Name = "rbFecha1"
        Me.rbFecha1.Size = New System.Drawing.Size(88, 24)
        Me.rbFecha1.TabIndex = 2
        Me.rbFecha1.Text = "Fecha"
        Me.rbFecha1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbMes
        '
        Me.rbMes.Checked = True
        Me.rbMes.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbMes.Location = New System.Drawing.Point(8, 24)
        Me.rbMes.Name = "rbMes"
        Me.rbMes.Size = New System.Drawing.Size(72, 24)
        Me.rbMes.TabIndex = 1
        Me.rbMes.TabStop = True
        Me.rbMes.Text = "Mes"
        Me.rbMes.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Hasta"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "De"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbVendedores, Me.Label1, Me.tbCodigo, Me.cbSubGrupos, Me.cbGrupos, Me.cbLineas, Me.Label13, Me.cbProductos, Me.cbClientes, Me.Label12, Me.Label11, Me.Label10, Me.Label9, Me.Label7})
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(369, 42)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(416, 216)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CRITERIOS DE SELECCION"
        '
        'cbVendedores
        '
        Me.cbVendedores.Location = New System.Drawing.Point(96, 72)
        Me.cbVendedores.Name = "cbVendedores"
        Me.cbVendedores.Size = New System.Drawing.Size(312, 23)
        Me.cbVendedores.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 40)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Vendedor"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbCodigo
        '
        Me.tbCodigo.Location = New System.Drawing.Point(96, 104)
        Me.tbCodigo.Name = "tbCodigo"
        Me.tbCodigo.Size = New System.Drawing.Size(160, 21)
        Me.tbCodigo.TabIndex = 5
        Me.tbCodigo.Text = ""
        '
        'cbSubGrupos
        '
        Me.cbSubGrupos.Location = New System.Drawing.Point(96, 248)
        Me.cbSubGrupos.Name = "cbSubGrupos"
        Me.cbSubGrupos.Size = New System.Drawing.Size(312, 23)
        Me.cbSubGrupos.TabIndex = 9
        Me.cbSubGrupos.Visible = False
        '
        'cbGrupos
        '
        Me.cbGrupos.Location = New System.Drawing.Point(96, 216)
        Me.cbGrupos.Name = "cbGrupos"
        Me.cbGrupos.Size = New System.Drawing.Size(312, 23)
        Me.cbGrupos.TabIndex = 8
        Me.cbGrupos.Visible = False
        '
        'cbLineas
        '
        Me.cbLineas.Location = New System.Drawing.Point(96, 168)
        Me.cbLineas.Name = "cbLineas"
        Me.cbLineas.Size = New System.Drawing.Size(312, 23)
        Me.cbLineas.TabIndex = 7
        Me.cbLineas.Visible = False
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 248)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 23)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Sub Grupo"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label13.Visible = False
        '
        'cbProductos
        '
        Me.cbProductos.Location = New System.Drawing.Point(96, 136)
        Me.cbProductos.Name = "cbProductos"
        Me.cbProductos.Size = New System.Drawing.Size(312, 23)
        Me.cbProductos.TabIndex = 6
        '
        'cbClientes
        '
        Me.cbClientes.Location = New System.Drawing.Point(96, 40)
        Me.cbClientes.Name = "cbClientes"
        Me.cbClientes.Size = New System.Drawing.Size(312, 23)
        Me.cbClientes.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 216)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 23)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Grupo"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Visible = False
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 168)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 23)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Linea"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label11.Visible = False
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 136)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 23)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Articulo"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 23)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Código"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 23)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Cliente"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbNinguno, Me.Label2, Me.Label3, Me.tbVServicio, Me.tbVProducto, Me.tbRango2, Me.tbRango1, Me.tbTotal, Me.rbVServicio, Me.rbVProducto, Me.rbRangoFact, Me.rbTotalFact})
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox5.Location = New System.Drawing.Point(369, 266)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(416, 152)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "RANGO DE VALOR"
        '
        'rbNinguno
        '
        Me.rbNinguno.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.rbNinguno.Checked = True
        Me.rbNinguno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNinguno.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbNinguno.Location = New System.Drawing.Point(7, 24)
        Me.rbNinguno.Name = "rbNinguno"
        Me.rbNinguno.Size = New System.Drawing.Size(160, 24)
        Me.rbNinguno.TabIndex = 11
        Me.rbNinguno.TabStop = True
        Me.rbNinguno.Text = "Ninguno"
        Me.rbNinguno.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(286, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 8)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Hasta"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(168, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 8)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "De"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Visible = False
        '
        'tbVServicio
        '
        Me.tbVServicio.Location = New System.Drawing.Point(168, 120)
        Me.tbVServicio.MaxLength = 11
        Me.tbVServicio.Name = "tbVServicio"
        Me.tbVServicio.Size = New System.Drawing.Size(88, 21)
        Me.tbVServicio.TabIndex = 8
        Me.tbVServicio.Text = ""
        Me.tbVServicio.Visible = False
        '
        'tbVProducto
        '
        Me.tbVProducto.Location = New System.Drawing.Point(168, 96)
        Me.tbVProducto.MaxLength = 11
        Me.tbVProducto.Name = "tbVProducto"
        Me.tbVProducto.Size = New System.Drawing.Size(88, 21)
        Me.tbVProducto.TabIndex = 7
        Me.tbVProducto.Text = ""
        Me.tbVProducto.Visible = False
        '
        'tbRango2
        '
        Me.tbRango2.Location = New System.Drawing.Point(320, 72)
        Me.tbRango2.MaxLength = 11
        Me.tbRango2.Name = "tbRango2"
        Me.tbRango2.Size = New System.Drawing.Size(88, 21)
        Me.tbRango2.TabIndex = 6
        Me.tbRango2.Text = ""
        Me.tbRango2.Visible = False
        '
        'tbRango1
        '
        Me.tbRango1.Location = New System.Drawing.Point(190, 72)
        Me.tbRango1.MaxLength = 20
        Me.tbRango1.Name = "tbRango1"
        Me.tbRango1.Size = New System.Drawing.Size(88, 21)
        Me.tbRango1.TabIndex = 5
        Me.tbRango1.Text = ""
        Me.tbRango1.Visible = False
        '
        'tbTotal
        '
        Me.tbTotal.Location = New System.Drawing.Point(168, 48)
        Me.tbTotal.MaxLength = 11
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(88, 21)
        Me.tbTotal.TabIndex = 4
        Me.tbTotal.Text = ""
        Me.tbTotal.Visible = False
        '
        'rbVServicio
        '
        Me.rbVServicio.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.rbVServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbVServicio.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbVServicio.Location = New System.Drawing.Point(6, 120)
        Me.rbVServicio.Name = "rbVServicio"
        Me.rbVServicio.Size = New System.Drawing.Size(152, 24)
        Me.rbVServicio.TabIndex = 3
        Me.rbVServicio.Text = "Valor de Servicio"
        Me.rbVServicio.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbVProducto
        '
        Me.rbVProducto.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.rbVProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbVProducto.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbVProducto.Location = New System.Drawing.Point(6, 96)
        Me.rbVProducto.Name = "rbVProducto"
        Me.rbVProducto.Size = New System.Drawing.Size(152, 24)
        Me.rbVProducto.TabIndex = 2
        Me.rbVProducto.Text = "Valor de Producto"
        Me.rbVProducto.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbRangoFact
        '
        Me.rbRangoFact.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.rbRangoFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRangoFact.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbRangoFact.Location = New System.Drawing.Point(6, 72)
        Me.rbRangoFact.Name = "rbRangoFact"
        Me.rbRangoFact.Size = New System.Drawing.Size(168, 24)
        Me.rbRangoFact.TabIndex = 1
        Me.rbRangoFact.Text = "Rango de Valor Factura"
        Me.rbRangoFact.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbTotalFact
        '
        Me.rbTotalFact.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.rbTotalFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTotalFact.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbTotalFact.Location = New System.Drawing.Point(6, 48)
        Me.rbTotalFact.Name = "rbTotalFact"
        Me.rbTotalFact.Size = New System.Drawing.Size(160, 24)
        Me.rbTotalFact.TabIndex = 0
        Me.rbTotalFact.Text = "Valor Total de Factura"
        Me.rbTotalFact.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbIVA, Me.rbCpC, Me.rbVentas})
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox6.Location = New System.Drawing.Point(801, 42)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(176, 104)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "DESTINO DEL INFORME"
        '
        'rbIVA
        '
        Me.rbIVA.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbIVA.Location = New System.Drawing.Point(6, 72)
        Me.rbIVA.Name = "rbIVA"
        Me.rbIVA.Size = New System.Drawing.Size(144, 24)
        Me.rbIVA.TabIndex = 2
        Me.rbIVA.Text = "Impuesto IVA"
        Me.rbIVA.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbIVA.Visible = False
        '
        'rbCpC
        '
        Me.rbCpC.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbCpC.Location = New System.Drawing.Point(6, 48)
        Me.rbCpC.Name = "rbCpC"
        Me.rbCpC.Size = New System.Drawing.Size(160, 24)
        Me.rbCpC.TabIndex = 1
        Me.rbCpC.Text = "Cuentas por Cobrar"
        Me.rbCpC.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbVentas
        '
        Me.rbVentas.Checked = True
        Me.rbVentas.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbVentas.Location = New System.Drawing.Point(6, 24)
        Me.rbVentas.Name = "rbVentas"
        Me.rbVentas.Size = New System.Drawing.Size(152, 24)
        Me.rbVentas.TabIndex = 0
        Me.rbVentas.TabStop = True
        Me.rbVentas.Text = "Ventas"
        Me.rbVentas.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbOrdenFac, Me.rbOrdenCliente, Me.rbOrdenFecha})
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox7.Location = New System.Drawing.Point(801, 154)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(176, 104)
        Me.GroupBox7.TabIndex = 6
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "ORDEN"
        '
        'rbOrdenFac
        '
        Me.rbOrdenFac.Checked = True
        Me.rbOrdenFac.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbOrdenFac.Location = New System.Drawing.Point(6, 24)
        Me.rbOrdenFac.Name = "rbOrdenFac"
        Me.rbOrdenFac.Size = New System.Drawing.Size(144, 24)
        Me.rbOrdenFac.TabIndex = 2
        Me.rbOrdenFac.TabStop = True
        Me.rbOrdenFac.Text = "No. de Factura"
        Me.rbOrdenFac.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbOrdenCliente
        '
        Me.rbOrdenCliente.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbOrdenCliente.Location = New System.Drawing.Point(6, 72)
        Me.rbOrdenCliente.Name = "rbOrdenCliente"
        Me.rbOrdenCliente.Size = New System.Drawing.Size(160, 24)
        Me.rbOrdenCliente.TabIndex = 1
        Me.rbOrdenCliente.Text = "Cliente"
        Me.rbOrdenCliente.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbOrdenFecha
        '
        Me.rbOrdenFecha.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbOrdenFecha.Location = New System.Drawing.Point(6, 48)
        Me.rbOrdenFecha.Name = "rbOrdenFecha"
        Me.rbOrdenFecha.Size = New System.Drawing.Size(152, 24)
        Me.rbOrdenFecha.TabIndex = 0
        Me.rbOrdenFecha.Text = "Fecha"
        Me.rbOrdenFecha.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbFile, Me.rbPrint, Me.rbScreen})
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox8.Location = New System.Drawing.Point(801, 266)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(176, 104)
        Me.GroupBox8.TabIndex = 7
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "SALIDA"
        '
        'rbFile
        '
        Me.rbFile.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbFile.Location = New System.Drawing.Point(6, 72)
        Me.rbFile.Name = "rbFile"
        Me.rbFile.Size = New System.Drawing.Size(154, 24)
        Me.rbFile.TabIndex = 2
        Me.rbFile.Text = "Archivo"
        Me.rbFile.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbPrint
        '
        Me.rbPrint.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbPrint.Location = New System.Drawing.Point(6, 48)
        Me.rbPrint.Name = "rbPrint"
        Me.rbPrint.Size = New System.Drawing.Size(154, 24)
        Me.rbPrint.TabIndex = 1
        Me.rbPrint.Text = "Impresora"
        Me.rbPrint.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbScreen
        '
        Me.rbScreen.Checked = True
        Me.rbScreen.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbScreen.Location = New System.Drawing.Point(6, 24)
        Me.rbScreen.Name = "rbScreen"
        Me.rbScreen.Size = New System.Drawing.Size(152, 24)
        Me.rbScreen.TabIndex = 0
        Me.rbScreen.TabStop = True
        Me.rbScreen.Text = "Pantalla"
        Me.rbScreen.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1, Me.Cancel, Me.Print})
        Me.GroupBox9.Location = New System.Drawing.Point(801, 378)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(176, 96)
        Me.GroupBox9.TabIndex = 8
        Me.GroupBox9.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Button1.Location = New System.Drawing.Point(48, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Ayuda"
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Cancel.Location = New System.Drawing.Point(48, 68)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.TabIndex = 1
        Me.Cancel.Text = "&Cancelar"
        '
        'Print
        '
        Me.Print.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Print.Location = New System.Drawing.Point(48, 11)
        Me.Print.Name = "Print"
        Me.Print.TabIndex = 0
        Me.Print.Text = "&Generar"
        '
        'tbValorTotal
        '
        Me.tbValorTotal.BackColor = System.Drawing.SystemColors.HotTrack
        Me.tbValorTotal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbValorTotal.ForeColor = System.Drawing.Color.Chartreuse
        Me.tbValorTotal.Location = New System.Drawing.Point(152, 24)
        Me.tbValorTotal.Name = "tbValorTotal"
        Me.tbValorTotal.Size = New System.Drawing.Size(104, 20)
        Me.tbValorTotal.TabIndex = 8
        Me.tbValorTotal.Text = "33333333333333"
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox10.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbArtAll, Me.rbProducto, Me.rbServicio, Me.rbBoth})
        Me.GroupBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox10.Location = New System.Drawing.Point(369, 426)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(416, 46)
        Me.GroupBox10.TabIndex = 9
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Articulos de Factura"
        '
        'rbArtAll
        '
        Me.rbArtAll.BackColor = System.Drawing.Color.Transparent
        Me.rbArtAll.Checked = True
        Me.rbArtAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbArtAll.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbArtAll.Location = New System.Drawing.Point(8, 18)
        Me.rbArtAll.Name = "rbArtAll"
        Me.rbArtAll.Size = New System.Drawing.Size(80, 23)
        Me.rbArtAll.TabIndex = 17
        Me.rbArtAll.TabStop = True
        Me.rbArtAll.Text = "TODOS"
        Me.rbArtAll.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbProducto
        '
        Me.rbProducto.BackColor = System.Drawing.Color.Transparent
        Me.rbProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbProducto.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbProducto.Location = New System.Drawing.Point(110, 18)
        Me.rbProducto.Name = "rbProducto"
        Me.rbProducto.Size = New System.Drawing.Size(80, 23)
        Me.rbProducto.TabIndex = 16
        Me.rbProducto.Text = "Producto"
        Me.rbProducto.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbServicio
        '
        Me.rbServicio.BackColor = System.Drawing.Color.Transparent
        Me.rbServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbServicio.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbServicio.Location = New System.Drawing.Point(218, 18)
        Me.rbServicio.Name = "rbServicio"
        Me.rbServicio.Size = New System.Drawing.Size(80, 23)
        Me.rbServicio.TabIndex = 14
        Me.rbServicio.Text = "Servicio"
        Me.rbServicio.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbBoth
        '
        Me.rbBoth.BackColor = System.Drawing.Color.Transparent
        Me.rbBoth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBoth.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbBoth.Location = New System.Drawing.Point(336, 18)
        Me.rbBoth.Name = "rbBoth"
        Me.rbBoth.Size = New System.Drawing.Size(72, 23)
        Me.rbBoth.TabIndex = 15
        Me.rbBoth.Text = "Ambos"
        Me.rbBoth.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox12.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label4, Me.etDescripcion})
        Me.GroupBox12.Location = New System.Drawing.Point(4, 0)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(1008, 32)
        Me.GroupBox12.TabIndex = 115
        Me.GroupBox12.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(8, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 13)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "REPORTE DE FACTURACION"
        '
        'etDescripcion
        '
        Me.etDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.etDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcion.ForeColor = System.Drawing.Color.White
        Me.etDescripcion.Location = New System.Drawing.Point(3, 8)
        Me.etDescripcion.Name = "etDescripcion"
        Me.etDescripcion.Size = New System.Drawing.Size(1000, 20)
        Me.etDescripcion.TabIndex = 113
        Me.etDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmReportesFactura
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(1016, 566)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox12, Me.GroupBox9, Me.GroupBox10, Me.GroupBox8, Me.GroupBox7, Me.GroupBox6, Me.GroupBox5, Me.GroupBox4, Me.GroupBox3, Me.GroupBox1})
        Me.Name = "frmReportesFactura"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub frmReportesFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Proveedor As New VB.SysContab.ProveedoresDB()
        Dim Linea As New VB.SysContab.Grupos_InventarioDB()


        'cbOrdenRed.DataSource = Puntos_Venta.Getlist().Tables("PUNTOS_VENTA")
        'cbOrdenRed.ValueMember = "Codigo"
        'cbOrdenRed.DisplayMember = "Nombre"
        'cbOrdenRed.SelectedValue = -1

        Me.DTPicker.Value = Rutinas.Fecha
        Me.DTPickerDe.Value = Rutinas.Fecha
        Me.DTPickerHasta.Value = Rutinas.Fecha

        cbMes.DataSource = Mes.MesexPeriodo.Tables("Meses")
        cbMes.ValueMember = "Fecha"
        cbMes.DisplayMember = "MesAnno"
        cbMes.SelectedIndex = 0

        cbClientes.DataSource = Cliente.GetList.Tables("CLIENTES")
        cbClientes.ValueMember = "Codigo"
        cbClientes.DisplayMember = "Nombre"
        cbClientes.SelectedValue = 0

        cbVendedores.DataSource = Vendedores.VendedoresList.Tables("Vendedores")
        cbVendedores.ValueMember = "Codigo"
        cbVendedores.DisplayMember = "Nombre"
        cbVendedores.SelectedValue = 0

        cbProductos.DataSource = Articulo.ArticulosListAll.Tables("Articulos")
        cbProductos.ValueMember = "Codigo"
        cbProductos.DisplayMember = "Nombre"
        cbProductos.SelectedValue = 0

        'cbProveedores.DataSource = Proveedor.ProveedoresList(-1).Tables("PROVEEDORES")
        'cbProveedores.ValueMember = "Codigo"
        'cbProveedores.DisplayMember = "Nombre"
        'cbProveedores.SelectedValue = 0

        'cbLineas.DataSource = Linea.GetListBuscarCombo("%", "P").Tables("GRUPOS_INVENTARIO")
        'cbLineas.ValueMember = "CODIGO_GRUPO"
        'cbLineas.DisplayMember = "NOMBRE"

        cbLineas.Text = ""

        cbGrupos.DataSource = Linea.GetListBuscarCombo("%", "P").Tables("GRUPOS_INVENTARIO")
        cbGrupos.ValueMember = "CODIGO_GRUPO"
        cbGrupos.DisplayMember = "NOMBRE"

        cbSubGrupos.DataSource = Linea.GetListBuscarCombo("%", "P").Tables("GRUPOS_INVENTARIO")
        cbSubGrupos.ValueMember = "CODIGO_GRUPO"
        cbSubGrupos.DisplayMember = "NOMBRE"

        Rutinas.ComboAutoComplete(Me.cbClientes)
        Rutinas.ComboAutoComplete(Me.cbProductos)
        'Rutinas.ComboAutoComplete(Me.cbProveedores)
        Rutinas.ComboAutoComplete(Me.cbVendedores)

    End Sub

    Private Sub rbOrdenRed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'cbOrdenRed.Enabled = True
        'cbOrdenWeb.Enabled = False
        'tbCotizacion.Enabled = False
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    'Private Sub rbOredenWeb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    cbOrdenRed.Enabled = False
    '    cbOrdenWeb.Enabled = True
    '    tbCotizacion.Enabled = False

    'End Sub

    'Private Sub rbCotizacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    cbOrdenRed.Enabled = False
    '    cbOrdenWeb.Enabled = False
    '    tbCotizacion.Enabled = True
    'End Sub

    'Private Sub rbStsComerc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    cbOrdenRed.Enabled = False
    '    cbOrdenWeb.Enabled = False
    '    tbCotizacion.Enabled = False
    'End Sub

    'Private Sub rbFactDir_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    cbOrdenRed.Enabled = False
    '    cbOrdenWeb.Enabled = False
    '    tbCotizacion.Enabled = False
    'End Sub

    Private Sub rbTodas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cbMes.SelectedIndex = 0
        cbMes.Enabled = False
        DTPicker.Enabled = False
        DTPickerDe.Enabled = False
        DTPickerHasta.Enabled = False
    End Sub

    Private Sub rbMes_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMes.CheckedChanged
        cbMes.Enabled = True
        DTPicker.Enabled = False
        DTPickerDe.Enabled = False
        DTPickerHasta.Enabled = False
    End Sub

    Private Sub rbFecha1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFecha1.CheckedChanged
        'cbMes.SelectedValue = 0
        cbMes.Enabled = False
        DTPicker.Enabled = True
        DTPickerDe.Enabled = False
        DTPickerHasta.Enabled = False
    End Sub

    Private Sub rbRango_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRango.CheckedChanged
        'cbMes.SelectedValue = 0
        cbMes.Enabled = False
        DTPicker.Enabled = False
        DTPickerDe.Enabled = True
        DTPickerHasta.Enabled = True
    End Sub

    Private Sub rbProducto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cbProductos.Enabled = True
    End Sub

    Private Sub rbServicio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cbProductos.Enabled = False
    End Sub

    Private Sub rbBoth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cbProductos.Enabled = True
    End Sub

    Private Sub tbCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCodigo.TextChanged
        'Dim codigo As New VB.SysContab.ArticulosDB()

        'dgCodigo.DataSource = codigo.GetListBuscar(tbCodigo.Text).Tables("ARTICULOS").DefaultView


        'If codigo.GetListBuscar(tbCodigo.Text).Tables("Clientes").Rows.Count = 0 Then
        '    Exit Sub

        'End If

        'Registro = dgClientes.Item(dgClientes.CurrentRowIndex, 0)

    End Sub

    Private Sub rbNinguno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNinguno.CheckedChanged
        tbTotal.Visible = False
        Label3.Visible = False
        tbRango1.Visible = False
        Label2.Visible = False
        tbRango2.Visible = False
        tbVProducto.Visible = False
        tbVServicio.Visible = False
        rbArtAll.Checked = True

    End Sub

    Private Sub rbTotalFact_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTotalFact.CheckedChanged
        tbTotal.Visible = True
        Label3.Visible = False
        tbRango1.Visible = False
        Label2.Visible = False
        tbRango2.Visible = False
        tbVProducto.Visible = False
        tbVServicio.Visible = False
        rbArtAll.Checked = True
    End Sub

    Private Sub rbRangoFact_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRangoFact.CheckedChanged
        tbTotal.Visible = False
        Label3.Visible = True
        tbRango1.Visible = True
        Label2.Visible = True
        tbRango2.Visible = True
        tbVProducto.Visible = False
        tbVServicio.Visible = False
        rbArtAll.Checked = True
    End Sub

    Private Sub rbVProducto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbVProducto.CheckedChanged
        tbTotal.Visible = False
        Label3.Visible = False
        tbRango1.Visible = False
        Label2.Visible = False
        tbRango2.Visible = False
        tbVProducto.Visible = True
        tbVServicio.Visible = False
        'rbProducto.Checked = True
    End Sub

    Private Sub rbVServicio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbVServicio.CheckedChanged
        tbTotal.Visible = False
        Label3.Visible = False
        tbRango1.Visible = False
        Label2.Visible = False
        tbRango2.Visible = False
        tbVProducto.Visible = False
        tbVServicio.Visible = True
        'rbServicio.Checked = True
    End Sub

    Private Sub rbVentas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbVentas.CheckedChanged
        rbVContado.Enabled = True
        rbVCredito.Enabled = True
        rbFecha1.Enabled = True
        rbRango.Enabled = True
        cbClientes.Enabled = True
        cbVendedores.Enabled = True
        'cbProveedores.Enabled = True
        tbCodigo.Enabled = True
        cbProductos.Enabled = True
        rbTotalFact.Enabled = True
        rbRangoFact.Enabled = True
        rbVProducto.Enabled = True
        rbVServicio.Enabled = True
        rbArtAll.Enabled = True
        rbArtAll.Checked = True
        rbBoth.Enabled = True
        rbOrdenFac.Enabled = True
        rbOrdenFac.Checked = True
        rbOrdenCliente.Enabled = True
    End Sub

    Private Sub rbIVA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbIVA.CheckedChanged
        rbVContado.Enabled = False
        rbVCredito.Enabled = False
        rbMes.Checked = True
        rbFecha1.Enabled = False
        rbRango.Enabled = False
        cbClientes.Enabled = False
        cbVendedores.Enabled = False
        'cbProveedores.Enabled = False
        tbCodigo.Enabled = False
        cbProductos.Enabled = False
        rbTotalFact.Enabled = False
        rbRangoFact.Enabled = False
        rbVProducto.Enabled = False
        rbVServicio.Enabled = False
        rbArtAll.Enabled = False
        rbBoth.Enabled = False
        rbOrdenFac.Enabled = False
        rbOrdenFecha.Checked = True
        rbOrdenCliente.Enabled = False
        rbProducto.Checked = True
    End Sub

    Private Sub Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Print.Click
        Dim Mes As String
        Dim Fecha1 As Date
        Dim Fecha2 As Date
        Dim TipoArt As String

        Mes = 0 'cbMes.SelectedValue
        TipoArt = ""

        If rbVentas.Checked = True Then
            Dim Tipo As Integer
            If rbVTotales.Checked = True Then
                Tipo = 0
            ElseIf rbVContado.Checked = True Then
                Tipo = 1
            Else
                Tipo = 2
            End If

            If rbMes.Checked Then
                Mes = Me.cbMes.SelectedItem.row.itemarray(0)
                Fecha1 = Me.cbMes.SelectedValue
                Fecha2 = Fecha1.AddMonths(1).AddDays(-1)
            End If

            If rbFecha1.Checked = True Then
                Fecha1 = DTPicker.Value.Date
                Fecha2 = DTPicker.Value.Date
            End If

            If rbRango.Checked = True Then
                Fecha1 = DTPickerDe.Value.Date
                Fecha2 = DTPickerHasta.Value.Date

                If CDate(Fecha1) > CDate(Fecha2) Then  ' Verifca que las fecha inicial sea menor a la final
                    MsgBox("Por favor seleccione una Fecha Inicial menor a la Fecha Final")
                    Return
                End If
            End If

            Dim FacRango1 As String
            Dim FacRango2 As String
            FacRango1 = 0
            FacRango2 = Cliente.MaxTotalFactura.Tables("Facturas_Ventas").Rows(0).Item("Maximo")
            If rbNinguno.Checked = True Then
            ElseIf rbTotalFact.Checked = True Then
                FacRango1 = tbTotal.Text
                FacRango2 = tbTotal.Text
            ElseIf rbRangoFact.Checked = True Then
                FacRango1 = tbRango1.Text
                FacRango2 = tbRango2.Text
                If FacRango2 < FacRango1 Then
                    MsgBox("Por favor verifique que el rango de inicio sea menor que el final.")
                    Return
                End If
            End If

            Dim ArtMin As String
            Dim ArtMax As String
            ArtMin = 0
            ArtMax = Cliente.MaxTotalFacturaLinea.Tables("Facturas_Ventas_Lineas").Rows(0).Item("MaximoLinea")

            If rbVProducto.Checked = True Then
                TipoArt = "P"
                ArtMin = tbVProducto.Text
                ArtMax = tbVProducto.Text
            End If

            If rbVServicio.Checked = True Then
                TipoArt = "S"
                ArtMin = tbVServicio.Text
                ArtMax = tbVServicio.Text
            End If

            Dim TipoFac2 As String
            If rbArtAll.Checked = True Then
                TipoFac2 = ""
            ElseIf rbProducto.Checked = True Then
                TipoFac2 = "0"
            ElseIf rbServicio.Checked = True Then
                TipoFac2 = "1"
            ElseIf rbBoth.Checked = True Then
                TipoFac2 = "2"
            End If

            Dim Orden As Integer
            If rbOrdenFac.Checked = True Then
                Orden = 1
            ElseIf rbOrdenFecha.Checked = True Then
                Orden = 2
            Else
                Orden = 3
            End If

            If rbTotalFact.Checked = True Or rbRangoFact.Checked = True Or rbVProducto.Checked = True Or rbVServicio.Checked = True Then
                If IsNumeric(FacRango1) And IsNumeric(FacRango2) Then
                Else
                    MsgBox("Favor Introduzca un valor numérico.")
                    Return
                End If
                If IsNumeric(ArtMax) Then
                Else
                    MsgBox("Favor Introduzca un valor numérico.")
                    Return
                End If
            End If

            'MsgBox(Mes)
            'Return
            Dim fReportes As New frmReportes
            'Dim rFacturas As New rptReporteFacturas
            Dim rFacturas As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            rFacturas.Load(Application.StartupPath & "\Reportes\rptReporteFacturas.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            Dim Clientes As New VB.SysContab.ClientesDB

            Dim lClientesFacturasReporte As DataSet = Clientes.FacturasReporte(cbClientes.Text, Tipo, Mes, Fecha1, Fecha2, cbVendedores.Text, "", tbCodigo.Text, cbProductos.Text, cbLineas.Text, cbGrupos.Text, cbSubGrupos.Text, FacRango1, FacRango2, TipoFac2, TipoArt, ArtMin, ArtMax, Orden)

            If lClientesFacturasReporte.Tables(0).Rows.Count > 0 Then
                lClientesFacturasReporte.WriteXml(Application.StartupPath & "\xml\rFacturas.xml", XmlWriteMode.WriteSchema)
                rFacturas.Database.Tables(0).Location = Application.StartupPath & "\xml\rFacturas.xml"
                rFacturas.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoempresa.xml"
                'rFacturas.SetDataSource(lClientesFacturasReporte)
                fReportes.crvReportes.ReportSource = rFacturas
            Else
                MsgBox("No hay ventas realizadas bajo los criterios de búsqueda")
                Exit Sub
            End If



            If rbScreen.Checked = True Then
                fReportes.Show()
            ElseIf rbPrint.Checked = True Then
                fReportes.crvReportes.PrintReport()
            Else
                fReportes.crvReportes.ExportReport()
            End If

        End If

        'El checkbox del IVA Esta invisible
        'If rbIVA.Checked = True Then

        '    If cbMes.SelectedValue = 0 Then
        '        MsgBox("Favor seleccione un mes específico para generar el registro.")
        '        Return
        '    Else
        '        Mes = cbMes.SelectedValue
        '    End If

        '    If rbProducto.Checked = True Then
        '        TipoArt = "P"
        '    ElseIf rbServicio.Checked = True Then
        '        TipoArt = "S"
        '    End If

        '    Dim fReportesIVA As New frmReportes()
        '    Dim rFacturasIVA As New rptReporteIVA()
        '    Dim Clientes As New VB.SysContab.ClientesDB
        '    Dim lds As New DataSet
        '    lds = Clientes.FacturasIVA(Mes, TipoArt)
        '    lds.WriteXml(Application.StartupPath & "\xml\rptIVA.xml", XmlWriteMode.WriteSchema)

        '    rFacturasIVA.SetDataSource(Clientes.FacturasIVA(Mes, TipoArt))
        '    fReportesIVA.crvReportes.ReportSource = rFacturasIVA

        '    If rbScreen.Checked = True Then
        '        fReportesIVA.Show()
        '    ElseIf rbPrint.Checked = True Then
        '        fReportesIVA.crvReportes.PrintReport()
        '    Else
        '        fReportesIVA.crvReportes.ExportReport()
        '    End If

        'End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Help.ShowHelp(Me, "Ayuda/Reportes/ReportesGestion.chm", HelpNavigator.KeywordIndex, "6")
    End Sub
End Class