Public Class frmReportesInventario
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmReportesInventario = Nothing

    Public Shared Function Instance() As frmReportesInventario
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmReportesInventario()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Dim Mes As New VB.SysContab.MesesDB()
    Dim Compras As New VB.SysContab.Facturas_ComprasDB()
    Dim Articulo As New VB.SysContab.ArticulosDB()
    Dim Puntos_Venta As New VB.SysContab.PuntosVentasDB()
    Dim Servicios As New VB.SysContab.ServiciosDB()
    Dim Vendedores As New VB.SysContab.VendedoresDB()
    Dim FormaPago As New VB.SysContab.Forma_PagoDB()
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbMes As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rbVTotales As System.Windows.Forms.RadioButton
    Friend WithEvents rbVContado As System.Windows.Forms.RadioButton
    Friend WithEvents rbVCredito As System.Windows.Forms.RadioButton
    Friend WithEvents rbOrdenRed As System.Windows.Forms.RadioButton
    Friend WithEvents rbFactDir As System.Windows.Forms.RadioButton
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
    Friend WithEvents cbProveedores As System.Windows.Forms.ComboBox
    Friend WithEvents cbProductos As System.Windows.Forms.ComboBox
    Friend WithEvents tbCodigo As System.Windows.Forms.TextBox
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
    Friend WithEvents cbFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents rbInvMin As System.Windows.Forms.RadioButton
    Friend WithEvents rbInvMax As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents rbOrdenCompra As System.Windows.Forms.RadioButton
    Friend WithEvents rbEntradaAlmacen As System.Windows.Forms.RadioButton
    Friend WithEvents rbNoFactura As System.Windows.Forms.RadioButton
    Friend WithEvents rbOrdenWeb As System.Windows.Forms.RadioButton
    Friend WithEvents tbNoFactura As System.Windows.Forms.TextBox
    Friend WithEvents tbEntradaAlmacen As System.Windows.Forms.TextBox
    Friend WithEvents tbOrdenCompra As System.Windows.Forms.TextBox
    Friend WithEvents rbConsulNone As System.Windows.Forms.RadioButton
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbInvMax = New System.Windows.Forms.RadioButton()
        Me.rbInvMin = New System.Windows.Forms.RadioButton()
        Me.rbVCredito = New System.Windows.Forms.RadioButton()
        Me.rbVContado = New System.Windows.Forms.RadioButton()
        Me.rbVTotales = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbOrdenWeb = New System.Windows.Forms.RadioButton()
        Me.rbOrdenRed = New System.Windows.Forms.RadioButton()
        Me.rbFactDir = New System.Windows.Forms.RadioButton()
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
        Me.tbCodigo = New System.Windows.Forms.TextBox()
        Me.cbProductos = New System.Windows.Forms.ComboBox()
        Me.cbProveedores = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
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
        Me.cbFormaPago = New System.Windows.Forms.ComboBox()
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
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
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
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.rbConsulNone = New System.Windows.Forms.RadioButton()
        Me.tbNoFactura = New System.Windows.Forms.TextBox()
        Me.tbEntradaAlmacen = New System.Windows.Forms.TextBox()
        Me.tbOrdenCompra = New System.Windows.Forms.TextBox()
        Me.rbNoFactura = New System.Windows.Forms.RadioButton()
        Me.rbEntradaAlmacen = New System.Windows.Forms.RadioButton()
        Me.rbOrdenCompra = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbInvMax)
        Me.GroupBox1.Controls.Add(Me.rbInvMin)
        Me.GroupBox1.Controls.Add(Me.rbVCredito)
        Me.GroupBox1.Controls.Add(Me.rbVContado)
        Me.GroupBox1.Controls.Add(Me.rbVTotales)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(8, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 185)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMACION "
        '
        'rbInvMax
        '
        Me.rbInvMax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbInvMax.Location = New System.Drawing.Point(10, 147)
        Me.rbInvMax.Name = "rbInvMax"
        Me.rbInvMax.Size = New System.Drawing.Size(211, 30)
        Me.rbInvMax.TabIndex = 4
        Me.rbInvMax.Text = "Inventario sobre Máximo"
        Me.rbInvMax.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbInvMin
        '
        Me.rbInvMin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbInvMin.Location = New System.Drawing.Point(10, 118)
        Me.rbInvMin.Name = "rbInvMin"
        Me.rbInvMin.Size = New System.Drawing.Size(201, 29)
        Me.rbInvMin.TabIndex = 3
        Me.rbInvMin.Text = "Inventario Bajo Mínimo"
        Me.rbInvMin.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbVCredito
        '
        Me.rbVCredito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbVCredito.Location = New System.Drawing.Point(10, 89)
        Me.rbVCredito.Name = "rbVCredito"
        Me.rbVCredito.Size = New System.Drawing.Size(182, 29)
        Me.rbVCredito.TabIndex = 2
        Me.rbVCredito.Text = "Pedidos en Tránsito"
        Me.rbVCredito.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbVContado
        '
        Me.rbVContado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbVContado.Location = New System.Drawing.Point(10, 59)
        Me.rbVContado.Name = "rbVContado"
        Me.rbVContado.Size = New System.Drawing.Size(201, 30)
        Me.rbVContado.TabIndex = 1
        Me.rbVContado.Text = "Entradas Incompletas"
        Me.rbVContado.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbVTotales
        '
        Me.rbVTotales.Checked = True
        Me.rbVTotales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbVTotales.Location = New System.Drawing.Point(10, 30)
        Me.rbVTotales.Name = "rbVTotales"
        Me.rbVTotales.Size = New System.Drawing.Size(163, 29)
        Me.rbVTotales.TabIndex = 0
        Me.rbVTotales.TabStop = True
        Me.rbVTotales.Text = "Entradas Totales"
        Me.rbVTotales.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbOrdenWeb)
        Me.GroupBox2.Controls.Add(Me.rbOrdenRed)
        Me.GroupBox2.Controls.Add(Me.rbFactDir)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(8, 232)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 128)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ORIGEN DEL REGISTRO"
        '
        'rbOrdenWeb
        '
        Me.rbOrdenWeb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbOrdenWeb.Location = New System.Drawing.Point(10, 89)
        Me.rbOrdenWeb.Name = "rbOrdenWeb"
        Me.rbOrdenWeb.Size = New System.Drawing.Size(182, 29)
        Me.rbOrdenWeb.TabIndex = 3
        Me.rbOrdenWeb.Text = "Inventarios"
        Me.rbOrdenWeb.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbOrdenWeb.Visible = False
        '
        'rbOrdenRed
        '
        Me.rbOrdenRed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbOrdenRed.Location = New System.Drawing.Point(10, 59)
        Me.rbOrdenRed.Name = "rbOrdenRed"
        Me.rbOrdenRed.Size = New System.Drawing.Size(172, 30)
        Me.rbOrdenRed.TabIndex = 1
        Me.rbOrdenRed.Text = "Entradas a Almacen"
        Me.rbOrdenRed.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbFactDir
        '
        Me.rbFactDir.Checked = True
        Me.rbFactDir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbFactDir.Location = New System.Drawing.Point(10, 30)
        Me.rbFactDir.Name = "rbFactDir"
        Me.rbFactDir.Size = New System.Drawing.Size(182, 29)
        Me.rbFactDir.TabIndex = 0
        Me.rbFactDir.TabStop = True
        Me.rbFactDir.Text = "Facturas Confirmadas"
        Me.rbFactDir.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DTPickerDe)
        Me.GroupBox3.Controls.Add(Me.DTPickerHasta)
        Me.GroupBox3.Controls.Add(Me.cbMes)
        Me.GroupBox3.Controls.Add(Me.DTPicker)
        Me.GroupBox3.Controls.Add(Me.rbRango)
        Me.GroupBox3.Controls.Add(Me.rbFecha1)
        Me.GroupBox3.Controls.Add(Me.rbMes)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(8, 370)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(288, 188)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "TIEMPO"
        '
        'DTPickerDe
        '
        Me.DTPickerDe.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPickerDe.Location = New System.Drawing.Point(125, 114)
        Me.DTPickerDe.Name = "DTPickerDe"
        Me.DTPickerDe.Size = New System.Drawing.Size(144, 24)
        Me.DTPickerDe.TabIndex = 15
        '
        'DTPickerHasta
        '
        Me.DTPickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPickerHasta.Location = New System.Drawing.Point(125, 145)
        Me.DTPickerHasta.Name = "DTPickerHasta"
        Me.DTPickerHasta.Size = New System.Drawing.Size(144, 24)
        Me.DTPickerHasta.TabIndex = 14
        '
        'cbMes
        '
        Me.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMes.Location = New System.Drawing.Point(125, 30)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(144, 26)
        Me.cbMes.TabIndex = 4
        '
        'DTPicker
        '
        Me.DTPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPicker.Location = New System.Drawing.Point(125, 62)
        Me.DTPicker.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.DTPicker.Name = "DTPicker"
        Me.DTPicker.Size = New System.Drawing.Size(144, 24)
        Me.DTPicker.TabIndex = 13
        '
        'rbRango
        '
        Me.rbRango.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbRango.Location = New System.Drawing.Point(10, 91)
        Me.rbRango.Name = "rbRango"
        Me.rbRango.Size = New System.Drawing.Size(105, 30)
        Me.rbRango.TabIndex = 3
        Me.rbRango.Text = "RANGO"
        Me.rbRango.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbFecha1
        '
        Me.rbFecha1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbFecha1.Location = New System.Drawing.Point(10, 62)
        Me.rbFecha1.Name = "rbFecha1"
        Me.rbFecha1.Size = New System.Drawing.Size(105, 29)
        Me.rbFecha1.TabIndex = 2
        Me.rbFecha1.Text = "Fecha"
        Me.rbFecha1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbMes
        '
        Me.rbMes.Checked = True
        Me.rbMes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbMes.Location = New System.Drawing.Point(10, 30)
        Me.rbMes.Name = "rbMes"
        Me.rbMes.Size = New System.Drawing.Size(86, 29)
        Me.rbMes.TabIndex = 1
        Me.rbMes.TabStop = True
        Me.rbMes.Text = "Mes"
        Me.rbMes.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(38, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Hasta"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(38, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "De"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tbCodigo)
        Me.GroupBox4.Controls.Add(Me.cbProductos)
        Me.GroupBox4.Controls.Add(Me.cbProveedores)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(316, 38)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(499, 125)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CRITERIOS DE SELECCION"
        '
        'tbCodigo
        '
        Me.tbCodigo.Location = New System.Drawing.Point(115, 59)
        Me.tbCodigo.Name = "tbCodigo"
        Me.tbCodigo.Size = New System.Drawing.Size(192, 24)
        Me.tbCodigo.TabIndex = 5
        '
        'cbProductos
        '
        Me.cbProductos.Location = New System.Drawing.Point(115, 89)
        Me.cbProductos.Name = "cbProductos"
        Me.cbProductos.Size = New System.Drawing.Size(375, 26)
        Me.cbProductos.TabIndex = 6
        '
        'cbProveedores
        '
        Me.cbProveedores.Location = New System.Drawing.Point(115, 30)
        Me.cbProveedores.Name = "cbProveedores"
        Me.cbProveedores.Size = New System.Drawing.Size(375, 26)
        Me.cbProveedores.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(10, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 28)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Articulo"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(10, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 28)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Código"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(10, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 28)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Proveedor"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.rbNinguno)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.tbVServicio)
        Me.GroupBox5.Controls.Add(Me.tbVProducto)
        Me.GroupBox5.Controls.Add(Me.tbRango2)
        Me.GroupBox5.Controls.Add(Me.tbRango1)
        Me.GroupBox5.Controls.Add(Me.tbTotal)
        Me.GroupBox5.Controls.Add(Me.rbVServicio)
        Me.GroupBox5.Controls.Add(Me.rbVProducto)
        Me.GroupBox5.Controls.Add(Me.rbRangoFact)
        Me.GroupBox5.Controls.Add(Me.rbTotalFact)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox5.Location = New System.Drawing.Point(316, 163)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(499, 188)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "RANGO DE VALOR"
        '
        'rbNinguno
        '
        Me.rbNinguno.BackColor = System.Drawing.Color.Transparent
        Me.rbNinguno.Checked = True
        Me.rbNinguno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNinguno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbNinguno.Location = New System.Drawing.Point(8, 30)
        Me.rbNinguno.Name = "rbNinguno"
        Me.rbNinguno.Size = New System.Drawing.Size(192, 29)
        Me.rbNinguno.TabIndex = 11
        Me.rbNinguno.TabStop = True
        Me.rbNinguno.Text = "Ninguno"
        Me.rbNinguno.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbNinguno.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(335, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Hasta"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(198, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "De"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Visible = False
        '
        'tbVServicio
        '
        Me.tbVServicio.Location = New System.Drawing.Point(202, 147)
        Me.tbVServicio.MaxLength = 11
        Me.tbVServicio.Name = "tbVServicio"
        Me.tbVServicio.Size = New System.Drawing.Size(105, 24)
        Me.tbVServicio.TabIndex = 8
        Me.tbVServicio.Visible = False
        '
        'tbVProducto
        '
        Me.tbVProducto.Location = New System.Drawing.Point(202, 118)
        Me.tbVProducto.MaxLength = 11
        Me.tbVProducto.Name = "tbVProducto"
        Me.tbVProducto.Size = New System.Drawing.Size(105, 24)
        Me.tbVProducto.TabIndex = 7
        Me.tbVProducto.Visible = False
        '
        'tbRango2
        '
        Me.tbRango2.Location = New System.Drawing.Point(384, 89)
        Me.tbRango2.MaxLength = 11
        Me.tbRango2.Name = "tbRango2"
        Me.tbRango2.Size = New System.Drawing.Size(106, 24)
        Me.tbRango2.TabIndex = 6
        Me.tbRango2.Visible = False
        '
        'tbRango1
        '
        Me.tbRango1.Location = New System.Drawing.Point(228, 89)
        Me.tbRango1.MaxLength = 20
        Me.tbRango1.Name = "tbRango1"
        Me.tbRango1.Size = New System.Drawing.Size(106, 24)
        Me.tbRango1.TabIndex = 5
        Me.tbRango1.Visible = False
        '
        'tbTotal
        '
        Me.tbTotal.Location = New System.Drawing.Point(202, 59)
        Me.tbTotal.MaxLength = 11
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(105, 24)
        Me.tbTotal.TabIndex = 4
        Me.tbTotal.Visible = False
        '
        'rbVServicio
        '
        Me.rbVServicio.BackColor = System.Drawing.Color.Transparent
        Me.rbVServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbVServicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbVServicio.Location = New System.Drawing.Point(7, 147)
        Me.rbVServicio.Name = "rbVServicio"
        Me.rbVServicio.Size = New System.Drawing.Size(183, 30)
        Me.rbVServicio.TabIndex = 3
        Me.rbVServicio.Text = "Valor de Servicio"
        Me.rbVServicio.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbVServicio.UseVisualStyleBackColor = False
        '
        'rbVProducto
        '
        Me.rbVProducto.BackColor = System.Drawing.Color.Transparent
        Me.rbVProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbVProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbVProducto.Location = New System.Drawing.Point(7, 118)
        Me.rbVProducto.Name = "rbVProducto"
        Me.rbVProducto.Size = New System.Drawing.Size(183, 29)
        Me.rbVProducto.TabIndex = 2
        Me.rbVProducto.Text = "Valor de Producto"
        Me.rbVProducto.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbVProducto.UseVisualStyleBackColor = False
        '
        'rbRangoFact
        '
        Me.rbRangoFact.BackColor = System.Drawing.Color.Transparent
        Me.rbRangoFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRangoFact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbRangoFact.Location = New System.Drawing.Point(7, 89)
        Me.rbRangoFact.Name = "rbRangoFact"
        Me.rbRangoFact.Size = New System.Drawing.Size(161, 29)
        Me.rbRangoFact.TabIndex = 1
        Me.rbRangoFact.Text = "Rango de Valor Factura"
        Me.rbRangoFact.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbRangoFact.UseVisualStyleBackColor = False
        '
        'rbTotalFact
        '
        Me.rbTotalFact.BackColor = System.Drawing.Color.Transparent
        Me.rbTotalFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTotalFact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbTotalFact.Location = New System.Drawing.Point(7, 59)
        Me.rbTotalFact.Name = "rbTotalFact"
        Me.rbTotalFact.Size = New System.Drawing.Size(192, 30)
        Me.rbTotalFact.TabIndex = 0
        Me.rbTotalFact.Text = "Valor Total de Factura"
        Me.rbTotalFact.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbTotalFact.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cbFormaPago)
        Me.GroupBox6.Controls.Add(Me.rbCpC)
        Me.GroupBox6.Controls.Add(Me.rbVentas)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox6.Location = New System.Drawing.Point(834, 35)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(326, 148)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "DESTINO DEL INFORME"
        '
        'cbFormaPago
        '
        Me.cbFormaPago.Location = New System.Drawing.Point(180, 89)
        Me.cbFormaPago.Name = "cbFormaPago"
        Me.cbFormaPago.Size = New System.Drawing.Size(139, 26)
        Me.cbFormaPago.TabIndex = 3
        Me.cbFormaPago.Visible = False
        '
        'rbCpC
        '
        Me.rbCpC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbCpC.Location = New System.Drawing.Point(7, 89)
        Me.rbCpC.Name = "rbCpC"
        Me.rbCpC.Size = New System.Drawing.Size(173, 29)
        Me.rbCpC.TabIndex = 1
        Me.rbCpC.Text = "Cuentas por Pagar"
        Me.rbCpC.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbVentas
        '
        Me.rbVentas.Checked = True
        Me.rbVentas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbVentas.Location = New System.Drawing.Point(7, 49)
        Me.rbVentas.Name = "rbVentas"
        Me.rbVentas.Size = New System.Drawing.Size(183, 30)
        Me.rbVentas.TabIndex = 0
        Me.rbVentas.TabStop = True
        Me.rbVentas.Text = "Compras"
        Me.rbVentas.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.rbOrdenFac)
        Me.GroupBox7.Controls.Add(Me.rbOrdenCliente)
        Me.GroupBox7.Controls.Add(Me.rbOrdenFecha)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox7.Location = New System.Drawing.Point(834, 190)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(326, 107)
        Me.GroupBox7.TabIndex = 6
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "ORDEN"
        '
        'rbOrdenFac
        '
        Me.rbOrdenFac.Checked = True
        Me.rbOrdenFac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbOrdenFac.Location = New System.Drawing.Point(7, 22)
        Me.rbOrdenFac.Name = "rbOrdenFac"
        Me.rbOrdenFac.Size = New System.Drawing.Size(173, 29)
        Me.rbOrdenFac.TabIndex = 2
        Me.rbOrdenFac.TabStop = True
        Me.rbOrdenFac.Text = "No. de Factura"
        Me.rbOrdenFac.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbOrdenCliente
        '
        Me.rbOrdenCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbOrdenCliente.Location = New System.Drawing.Point(7, 75)
        Me.rbOrdenCliente.Name = "rbOrdenCliente"
        Me.rbOrdenCliente.Size = New System.Drawing.Size(192, 30)
        Me.rbOrdenCliente.TabIndex = 1
        Me.rbOrdenCliente.Text = "Proveedor"
        Me.rbOrdenCliente.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbOrdenFecha
        '
        Me.rbOrdenFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbOrdenFecha.Location = New System.Drawing.Point(7, 47)
        Me.rbOrdenFecha.Name = "rbOrdenFecha"
        Me.rbOrdenFecha.Size = New System.Drawing.Size(183, 30)
        Me.rbOrdenFecha.TabIndex = 0
        Me.rbOrdenFecha.Text = "Fecha"
        Me.rbOrdenFecha.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.rbFile)
        Me.GroupBox8.Controls.Add(Me.rbPrint)
        Me.GroupBox8.Controls.Add(Me.rbScreen)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox8.Location = New System.Drawing.Point(834, 306)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(326, 128)
        Me.GroupBox8.TabIndex = 7
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "SALIDA"
        '
        'rbFile
        '
        Me.rbFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbFile.Location = New System.Drawing.Point(7, 89)
        Me.rbFile.Name = "rbFile"
        Me.rbFile.Size = New System.Drawing.Size(185, 29)
        Me.rbFile.TabIndex = 2
        Me.rbFile.Text = "Archivo"
        Me.rbFile.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbPrint
        '
        Me.rbPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbPrint.Location = New System.Drawing.Point(7, 59)
        Me.rbPrint.Name = "rbPrint"
        Me.rbPrint.Size = New System.Drawing.Size(185, 30)
        Me.rbPrint.TabIndex = 1
        Me.rbPrint.Text = "Impresora"
        Me.rbPrint.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbScreen
        '
        Me.rbScreen.Checked = True
        Me.rbScreen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbScreen.Location = New System.Drawing.Point(7, 30)
        Me.rbScreen.Name = "rbScreen"
        Me.rbScreen.Size = New System.Drawing.Size(183, 29)
        Me.rbScreen.TabIndex = 0
        Me.rbScreen.TabStop = True
        Me.rbScreen.Text = "Pantalla"
        Me.rbScreen.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.cmdAyuda)
        Me.GroupBox9.Controls.Add(Me.Cancel)
        Me.GroupBox9.Controls.Add(Me.Print)
        Me.GroupBox9.Location = New System.Drawing.Point(834, 449)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(326, 109)
        Me.GroupBox9.TabIndex = 8
        Me.GroupBox9.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Location = New System.Drawing.Point(120, 19)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(90, 30)
        Me.cmdAyuda.TabIndex = 2
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(226, 19)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(90, 30)
        Me.Cancel.TabIndex = 1
        Me.Cancel.Text = "&Cancelar"
        '
        'Print
        '
        Me.Print.Location = New System.Drawing.Point(12, 19)
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(90, 30)
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
        Me.tbValorTotal.Size = New System.Drawing.Size(104, 22)
        Me.tbValorTotal.TabIndex = 8
        Me.tbValorTotal.Text = "33333333333333"
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox10.Controls.Add(Me.rbArtAll)
        Me.GroupBox10.Controls.Add(Me.rbProducto)
        Me.GroupBox10.Controls.Add(Me.rbServicio)
        Me.GroupBox10.Controls.Add(Me.rbBoth)
        Me.GroupBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox10.Location = New System.Drawing.Point(316, 351)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(499, 56)
        Me.GroupBox10.TabIndex = 9
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Articulos de Factura"
        '
        'rbArtAll
        '
        Me.rbArtAll.BackColor = System.Drawing.Color.Transparent
        Me.rbArtAll.Checked = True
        Me.rbArtAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbArtAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbArtAll.Location = New System.Drawing.Point(10, 22)
        Me.rbArtAll.Name = "rbArtAll"
        Me.rbArtAll.Size = New System.Drawing.Size(96, 28)
        Me.rbArtAll.TabIndex = 17
        Me.rbArtAll.TabStop = True
        Me.rbArtAll.Text = "TODOS"
        Me.rbArtAll.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbArtAll.UseVisualStyleBackColor = False
        '
        'rbProducto
        '
        Me.rbProducto.BackColor = System.Drawing.Color.Transparent
        Me.rbProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbProducto.Location = New System.Drawing.Point(113, 15)
        Me.rbProducto.Name = "rbProducto"
        Me.rbProducto.Size = New System.Drawing.Size(117, 28)
        Me.rbProducto.TabIndex = 16
        Me.rbProducto.Text = "Producto"
        Me.rbProducto.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbProducto.UseVisualStyleBackColor = False
        '
        'rbServicio
        '
        Me.rbServicio.BackColor = System.Drawing.Color.Transparent
        Me.rbServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbServicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbServicio.Location = New System.Drawing.Point(248, 15)
        Me.rbServicio.Name = "rbServicio"
        Me.rbServicio.Size = New System.Drawing.Size(96, 28)
        Me.rbServicio.TabIndex = 14
        Me.rbServicio.Text = "Servicio"
        Me.rbServicio.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbServicio.UseVisualStyleBackColor = False
        '
        'rbBoth
        '
        Me.rbBoth.BackColor = System.Drawing.Color.Transparent
        Me.rbBoth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBoth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbBoth.Location = New System.Drawing.Point(403, 15)
        Me.rbBoth.Name = "rbBoth"
        Me.rbBoth.Size = New System.Drawing.Size(87, 28)
        Me.rbBoth.TabIndex = 15
        Me.rbBoth.Text = "Ambos"
        Me.rbBoth.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbBoth.UseVisualStyleBackColor = False
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox12.Controls.Add(Me.Label4)
        Me.GroupBox12.Controls.Add(Me.etDescripcion)
        Me.GroupBox12.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox12.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(1016, 39)
        Me.GroupBox12.TabIndex = 115
        Me.GroupBox12.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(10, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(249, 16)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "REPORTE DE INVENTARIO"
        '
        'etDescripcion
        '
        Me.etDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcion.ForeColor = System.Drawing.Color.White
        Me.etDescripcion.Location = New System.Drawing.Point(4, 10)
        Me.etDescripcion.Name = "etDescripcion"
        Me.etDescripcion.Size = New System.Drawing.Size(997, 24)
        Me.etDescripcion.TabIndex = 113
        Me.etDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.rbConsulNone)
        Me.GroupBox11.Controls.Add(Me.tbNoFactura)
        Me.GroupBox11.Controls.Add(Me.tbEntradaAlmacen)
        Me.GroupBox11.Controls.Add(Me.tbOrdenCompra)
        Me.GroupBox11.Controls.Add(Me.rbNoFactura)
        Me.GroupBox11.Controls.Add(Me.rbEntradaAlmacen)
        Me.GroupBox11.Controls.Add(Me.rbOrdenCompra)
        Me.GroupBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox11.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox11.Location = New System.Drawing.Point(316, 409)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(499, 149)
        Me.GroupBox11.TabIndex = 116
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "CONSULTAS"
        '
        'rbConsulNone
        '
        Me.rbConsulNone.Checked = True
        Me.rbConsulNone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbConsulNone.Location = New System.Drawing.Point(12, 22)
        Me.rbConsulNone.Name = "rbConsulNone"
        Me.rbConsulNone.Size = New System.Drawing.Size(125, 29)
        Me.rbConsulNone.TabIndex = 6
        Me.rbConsulNone.TabStop = True
        Me.rbConsulNone.Text = "Ninguno"
        '
        'tbNoFactura
        '
        Me.tbNoFactura.Location = New System.Drawing.Point(211, 109)
        Me.tbNoFactura.Name = "tbNoFactura"
        Me.tbNoFactura.Size = New System.Drawing.Size(173, 23)
        Me.tbNoFactura.TabIndex = 5
        '
        'tbEntradaAlmacen
        '
        Me.tbEntradaAlmacen.Location = New System.Drawing.Point(211, 79)
        Me.tbEntradaAlmacen.Name = "tbEntradaAlmacen"
        Me.tbEntradaAlmacen.Size = New System.Drawing.Size(173, 23)
        Me.tbEntradaAlmacen.TabIndex = 4
        '
        'tbOrdenCompra
        '
        Me.tbOrdenCompra.Location = New System.Drawing.Point(211, 49)
        Me.tbOrdenCompra.Name = "tbOrdenCompra"
        Me.tbOrdenCompra.Size = New System.Drawing.Size(173, 23)
        Me.tbOrdenCompra.TabIndex = 3
        '
        'rbNoFactura
        '
        Me.rbNoFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNoFactura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbNoFactura.Location = New System.Drawing.Point(10, 109)
        Me.rbNoFactura.Name = "rbNoFactura"
        Me.rbNoFactura.Size = New System.Drawing.Size(192, 29)
        Me.rbNoFactura.TabIndex = 2
        Me.rbNoFactura.Text = "No. de Factura"
        '
        'rbEntradaAlmacen
        '
        Me.rbEntradaAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEntradaAlmacen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbEntradaAlmacen.Location = New System.Drawing.Point(10, 79)
        Me.rbEntradaAlmacen.Name = "rbEntradaAlmacen"
        Me.rbEntradaAlmacen.Size = New System.Drawing.Size(192, 30)
        Me.rbEntradaAlmacen.TabIndex = 1
        Me.rbEntradaAlmacen.Text = "No. de Entrada a Almacen"
        '
        'rbOrdenCompra
        '
        Me.rbOrdenCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbOrdenCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbOrdenCompra.Location = New System.Drawing.Point(10, 49)
        Me.rbOrdenCompra.Name = "rbOrdenCompra"
        Me.rbOrdenCompra.Size = New System.Drawing.Size(172, 30)
        Me.rbOrdenCompra.TabIndex = 0
        Me.rbOrdenCompra.Text = "No. Orden de Compra"
        '
        'frmReportesInventario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.ClientSize = New System.Drawing.Size(1016, 526)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox12)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmReportesInventario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
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

        cbMes.DataSource = Mes.MesexPeriodo.Tables("Meses")
        cbMes.ValueMember = "Mes"
        cbMes.DisplayMember = "MesAnno"
        cbMes.SelectedValue = 0

        cbProductos.DataSource = Articulo.ArticulosListAll.Tables("Articulos")
        cbProductos.ValueMember = "Codigo"
        cbProductos.DisplayMember = "Nombre"
        cbProductos.SelectedValue = 0

        cbProveedores.DataSource = Proveedor.ProveedoresList(3).Tables("PROVEEDORES")
        cbProveedores.ValueMember = "Codigo"
        cbProveedores.DisplayMember = "Nombre"
        cbProveedores.SelectedValue = 0

        cbFormaPago.DataSource = FormaPago.FormaPagoCreditos.Tables("Forma_Pago")
        cbFormaPago.ValueMember = "Codigo"
        cbFormaPago.DisplayMember = "Nombre"

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub rbVTotales_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbVTotales.CheckedChanged
        rbFactDir.Enabled = True
        rbOrdenRed.Enabled = True
        rbOrdenWeb.Checked = False
        rbMes.Enabled = True
        cbMes.Enabled = True
        rbFecha1.Enabled = True
        DTPicker.Enabled = True
        rbRango.Enabled = True
        DTPickerDe.Enabled = True
        DTPickerHasta.Enabled = True
        rbTotalFact.Enabled = True
        rbRangoFact.Enabled = True
        rbVProducto.Enabled = True
        rbVServicio.Enabled = True
        rbOrdenCompra.Enabled = True
        rbEntradaAlmacen.Enabled = True
        rbNoFactura.Enabled = True
        rbOrdenCompra.Enabled = True
        tbOrdenCompra.Visible = True
        rbEntradaAlmacen.Enabled = True
        rbNoFactura.Enabled = True
        rbOrdenFac.Enabled = True
        rbOrdenFecha.Enabled = True
        rbOrdenCliente.Checked = False

    End Sub

    Private Sub rbVContado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbVContado.CheckedChanged
        rbFactDir.Enabled = True
        rbOrdenRed.Enabled = True
        rbOrdenWeb.Checked = False
        rbMes.Enabled = True
        cbMes.Enabled = True
        rbFecha1.Enabled = True
        DTPicker.Enabled = True
        rbRango.Enabled = True
        DTPickerDe.Enabled = True
        DTPickerHasta.Enabled = True
        rbTotalFact.Enabled = True
        rbRangoFact.Enabled = True
        rbVProducto.Enabled = True
        rbVServicio.Enabled = True
        rbOrdenCompra.Enabled = True
        tbOrdenCompra.Visible = True
        rbEntradaAlmacen.Enabled = True
        rbNoFactura.Enabled = True
        rbOrdenCompra.Enabled = True
        rbEntradaAlmacen.Enabled = True
        rbNoFactura.Enabled = True
        rbOrdenFac.Enabled = True
        rbOrdenFecha.Enabled = True
        rbOrdenCliente.Checked = False

    End Sub

    Private Sub rbVCredito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbVCredito.CheckedChanged
        rbFactDir.Enabled = True
        rbOrdenRed.Enabled = True
        rbOrdenWeb.Checked = False
        rbMes.Enabled = True
        cbMes.Enabled = True
        rbFecha1.Enabled = True
        DTPicker.Enabled = True
        rbRango.Enabled = True
        DTPickerDe.Enabled = True
        DTPickerHasta.Enabled = True
        rbTotalFact.Enabled = True
        rbRangoFact.Enabled = True
        rbVProducto.Enabled = True
        rbVServicio.Enabled = True
        rbOrdenCompra.Enabled = True
        tbOrdenCompra.Visible = True
        rbEntradaAlmacen.Enabled = True
        rbNoFactura.Enabled = True
        rbOrdenCompra.Enabled = True
        rbEntradaAlmacen.Enabled = True
        rbNoFactura.Enabled = True
        rbOrdenFac.Enabled = True
        rbOrdenFecha.Enabled = True
        rbOrdenCliente.Checked = False

    End Sub

    Private Sub rbInvMin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbInvMin.CheckedChanged
        rbFactDir.Enabled = False
        rbOrdenRed.Enabled = False
        rbOrdenWeb.Checked = True
        rbMes.Enabled = False
        cbMes.Enabled = False
        rbFecha1.Enabled = False
        DTPicker.Enabled = False
        rbRango.Enabled = False
        DTPickerDe.Enabled = False
        DTPickerHasta.Enabled = False
        rbTotalFact.Enabled = False
        tbTotal.Visible = False
        rbRangoFact.Enabled = False
        rbVProducto.Enabled = False
        rbVServicio.Enabled = False
        rbOrdenCompra.Enabled = False
        tbOrdenCompra.Visible = False
        rbEntradaAlmacen.Enabled = False
        tbEntradaAlmacen.Visible = False
        rbNoFactura.Enabled = False
        tbNoFactura.Visible = False
        rbEntradaAlmacen.Enabled = False
        rbNoFactura.Enabled = False
        rbOrdenCompra.Enabled = False
        rbEntradaAlmacen.Enabled = False
        rbNoFactura.Enabled = False
        rbOrdenFac.Enabled = False
        rbOrdenFecha.Enabled = False
        rbOrdenCliente.Checked = True

    End Sub

    Private Sub rbInvMax_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbInvMax.CheckedChanged
        rbFactDir.Enabled = False
        rbOrdenRed.Enabled = False
        rbOrdenWeb.Checked = True
        rbMes.Enabled = False
        cbMes.Enabled = False
        rbFecha1.Enabled = False
        DTPicker.Enabled = False
        rbRango.Enabled = False
        DTPickerDe.Enabled = False
        DTPickerHasta.Enabled = False
        rbTotalFact.Enabled = False
        tbTotal.Visible = False
        rbRangoFact.Enabled = False
        rbVProducto.Enabled = False
        rbVServicio.Enabled = False
        rbOrdenCompra.Enabled = False
        tbOrdenCompra.Visible = False
        rbEntradaAlmacen.Enabled = False
        tbEntradaAlmacen.Visible = False
        rbNoFactura.Enabled = False
        tbNoFactura.Visible = False
        rbOrdenCompra.Enabled = False
        rbEntradaAlmacen.Enabled = False
        rbNoFactura.Enabled = False
        rbOrdenFac.Enabled = False
        rbOrdenFecha.Enabled = False
        rbOrdenCliente.Checked = True

    End Sub

    Private Sub rbTodas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  cbMes.SelectedValue = 0
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
        '   cbMes.SelectedIndex = 0
        cbMes.Enabled = False
        DTPicker.Enabled = True
        DTPickerDe.Enabled = False
        DTPickerHasta.Enabled = False
    End Sub

    Private Sub rbRango_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRango.CheckedChanged
        ' cbMes.SelectedIndex = 0
        cbMes.Enabled = False
        DTPicker.Enabled = False
        DTPickerDe.Enabled = True
        DTPickerHasta.Enabled = True
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
    End Sub

    Private Sub rbVServicio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbVServicio.CheckedChanged
        tbTotal.Visible = False
        Label3.Visible = False
        tbRango1.Visible = False
        Label2.Visible = False
        tbRango2.Visible = False
        tbVProducto.Visible = False
        tbVServicio.Visible = True
    End Sub

    Private Sub rbVentas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbVentas.CheckedChanged
        rbVContado.Enabled = True
        rbVCredito.Enabled = True
        rbFecha1.Enabled = True
        rbRango.Enabled = True
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
        cbFormaPago.Visible = False
    End Sub

    Private Sub rbCpC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCpC.CheckedChanged
        rbVContado.Enabled = True
        rbVCredito.Enabled = True
        rbFecha1.Enabled = True
        rbRango.Enabled = True
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
        cbFormaPago.Visible = True
    End Sub

    Private Sub rbIVA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        rbVContado.Enabled = False
        rbVCredito.Enabled = False
        rbMes.Checked = True
        rbFecha1.Enabled = False
        rbRango.Enabled = False
        cbProveedores.Enabled = False
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
        cbFormaPago.Visible = False
    End Sub
    Private Sub rbOrdenCompra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbOrdenCompra.CheckedChanged
        tbOrdenCompra.Visible = True
        tbEntradaAlmacen.Visible = False
        tbNoFactura.Visible = False
    End Sub

    Private Sub rbEntradaAlamcen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEntradaAlmacen.CheckedChanged
        tbOrdenCompra.Visible = False
        tbEntradaAlmacen.Visible = True
        tbNoFactura.Visible = False
    End Sub

    Private Sub rbNoFactura_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNoFactura.CheckedChanged
        tbOrdenCompra.Visible = False
        tbEntradaAlmacen.Visible = False
        tbNoFactura.Visible = True
    End Sub

    Private Sub Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Print.Click
        Dim Mes As String
        Dim Fecha1 As String
        Dim Fecha2 As String
        Dim ArtTipo As String
        Dim fReportes As New frmReportes()


        ArtTipo = ""
        Fecha1 = ""
        Fecha2 = ""

        '  If rbVentas.Checked = True Or rbCpC.Checked = True Then
        Dim Tipo As Integer
        If rbVTotales.Checked = True Then
            Tipo = 0
        ElseIf rbVContado.Checked = True Then
            Tipo = 1
        ElseIf rbVCredito.Checked = True Then
            Tipo = 2
        ElseIf rbInvMin.Checked = True Then
            Tipo = 3
        Else
            Tipo = 4
        End If

        If rbMes.Checked = True Then
            Mes = cbMes.SelectedValue
        Else
            Mes = 0
        End If

        If rbFecha1.Checked = True Then
            Fecha1 = DTPicker.Value.Date
            Fecha2 = DTPicker.Value.Date
        End If

        If rbRango.Checked = True Then
            Fecha1 = DTPickerDe.Value.Date
            Fecha2 = DTPickerHasta.Value.Date
            If Fecha1 <> "" And Fecha2 <> "" Then
                If CDate(Fecha1) > CDate(Fecha2) Then  ' Verifca que las fecha inicial sea menor a la final
                    MsgBox("Por favor seleccione una Fecha Inicial menor a la Fecha Final")
                    Return
                End If
            End If
        End If

        Dim FacRango1 As String
        Dim FacRango2 As String
        FacRango1 = 0
        FacRango2 = Compras.MaxTotalFacturaCompras.Tables("Facturas_Compras").Rows(0).Item("Maximo")
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
        ArtMax = Compras.MaxTotalFacturaComprasLinea.Tables("Facturas_Compras_Lineas").Rows(0).Item("MaximoLinea")

        If rbVProducto.Checked = True Then
            ArtTipo = "P"
            ArtMin = tbVProducto.Text
            ArtMax = tbVProducto.Text
        End If

        If rbVServicio.Checked = True Then
            ArtTipo = "S"
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

        Dim FormaPago As String
        If cbFormaPago.SelectedValue = 0 Then
            FormaPago = ""
        Else
            FormaPago = cbFormaPago.Text
        End If


        If rbVTotales.Checked = True Or rbVContado.Checked = True Or rbVCredito.Checked = True Then
            'Dim rInventario As New rptReporteInventario
            Dim rInventario As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            rInventario.Load(Application.StartupPath & "\Reportes\rptReporteInventario.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            '
            rInventario.SetDataSource(Compras.Inventario(Tipo, Mes, Fecha1, Fecha2, cbProveedores.Text, tbCodigo.Text, cbProductos.Text, FacRango1, FacRango2, ArtMin, ArtMax, ArtTipo, tbOrdenCompra.Text, tbEntradaAlmacen.Text, tbNoFactura.Text))
            fReportes.crvReportes.ReportSource = rInventario
        End If

        If rbInvMin.Checked = True Or rbInvMax.Checked = True Then
            'Dim rInventario2 As New rptReporteInventario2
            Dim rInventario2 As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            rInventario2.Load(Application.StartupPath & "\Reportes\rptReporteInventario2.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            '            
            rInventario2.SetDataSource(Compras.Inventario2(Tipo, cbProveedores.Text, tbCodigo.Text, cbProductos.Text, ArtTipo, ArtMin, ArtMax))
            fReportes.crvReportes.ReportSource = rInventario2

        End If

        If rbScreen.Checked = True Then
            fReportes.Show()
        ElseIf rbPrint.Checked = True Then
            fReportes.crvReportes.PrintReport()
        Else
            fReportes.crvReportes.ExportReport()
        End If

        'End If

        'If rbIVA.Checked = True Then

        '    If cbMes.SelectedValue = 0 Then
        '        MsgBox("Favor seleccione un mes específico para generar el registro.")
        '        Return
        '    Else
        '        Mes = cbMes.SelectedValue
        '    End If

        '    If rbProducto.Checked = True Then
        '        ArtTipo = "P"
        '    ElseIf rbServicio.Checked = True Then
        '        ArtTipo = "S"
        '    End If

        '    Dim fReportesIVA As New frmReportes()
        '    Dim rFacturasIVA As New rptReporteIVA()
        '    Dim Clientes As New VB.SysContab.ClientesDB()
        '    rFacturasIVA.SetDataSource(Clientes.FacturasIVA(Mes, ArtTipo))
        '    fReportesIVA.crvReportes.ReportSource = rFacturasIVA

        '    If rbScreen.Checked = True Then
        '        fReportesIVA.ShowDialog()
        '    ElseIf rbPrint.Checked = True Then
        '        fReportesIVA.crvReportes.PrintReport()
        '    Else
        '        fReportesIVA.crvReportes.ExportReport()
        '    End If

        'End If

    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/Reportes/ReportesGestion.chm", HelpNavigator.KeywordIndex, "8")
    End Sub
End Class