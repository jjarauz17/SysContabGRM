Public Class frmReportesFacturasCompras
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmReportesFacturasCompras = Nothing

    Public Shared Function Instance() As frmReportesFacturasCompras
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmReportesFacturasCompras()
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
    Friend WithEvents chkInventario As System.Windows.Forms.CheckBox
    Friend WithEvents chkProductos As System.Windows.Forms.CheckBox
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbVCredito = New System.Windows.Forms.RadioButton
        Me.rbVContado = New System.Windows.Forms.RadioButton
        Me.rbVTotales = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DTPickerDe = New System.Windows.Forms.DateTimePicker
        Me.DTPickerHasta = New System.Windows.Forms.DateTimePicker
        Me.cbMes = New System.Windows.Forms.ComboBox
        Me.DTPicker = New System.Windows.Forms.DateTimePicker
        Me.rbRango = New System.Windows.Forms.RadioButton
        Me.rbFecha1 = New System.Windows.Forms.RadioButton
        Me.rbMes = New System.Windows.Forms.RadioButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.tbCodigo = New System.Windows.Forms.TextBox
        Me.cbProductos = New System.Windows.Forms.ComboBox
        Me.cbProveedores = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.chkInventario = New System.Windows.Forms.CheckBox
        Me.chkProductos = New System.Windows.Forms.CheckBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.tbRango2 = New System.Windows.Forms.TextBox
        Me.rbNinguno = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.tbVServicio = New System.Windows.Forms.TextBox
        Me.tbVProducto = New System.Windows.Forms.TextBox
        Me.tbRango1 = New System.Windows.Forms.TextBox
        Me.tbTotal = New System.Windows.Forms.TextBox
        Me.rbVServicio = New System.Windows.Forms.RadioButton
        Me.rbVProducto = New System.Windows.Forms.RadioButton
        Me.rbRangoFact = New System.Windows.Forms.RadioButton
        Me.rbTotalFact = New System.Windows.Forms.RadioButton
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.cbFormaPago = New System.Windows.Forms.ComboBox
        Me.rbIVA = New System.Windows.Forms.RadioButton
        Me.rbCpC = New System.Windows.Forms.RadioButton
        Me.rbVentas = New System.Windows.Forms.RadioButton
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.rbOrdenFac = New System.Windows.Forms.RadioButton
        Me.rbOrdenCliente = New System.Windows.Forms.RadioButton
        Me.rbOrdenFecha = New System.Windows.Forms.RadioButton
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.rbFile = New System.Windows.Forms.RadioButton
        Me.rbPrint = New System.Windows.Forms.RadioButton
        Me.rbScreen = New System.Windows.Forms.RadioButton
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.Cancel = New DevExpress.XtraEditors.SimpleButton
        Me.Print = New DevExpress.XtraEditors.SimpleButton
        Me.tbValorTotal = New System.Windows.Forms.TextBox
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.rbArtAll = New System.Windows.Forms.RadioButton
        Me.rbProducto = New System.Windows.Forms.RadioButton
        Me.rbServicio = New System.Windows.Forms.RadioButton
        Me.rbBoth = New System.Windows.Forms.RadioButton
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.etDescripcion = New System.Windows.Forms.Label
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
        Me.GroupBox1.Controls.Add(Me.rbVCredito)
        Me.GroupBox1.Controls.Add(Me.rbVContado)
        Me.GroupBox1.Controls.Add(Me.rbVTotales)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(41, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 112)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMACION "
        '
        'rbVCredito
        '
        Me.rbVCredito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbVCredito.Location = New System.Drawing.Point(8, 78)
        Me.rbVCredito.Name = "rbVCredito"
        Me.rbVCredito.Size = New System.Drawing.Size(136, 25)
        Me.rbVCredito.TabIndex = 2
        Me.rbVCredito.Text = "Compras al Crédito"
        Me.rbVCredito.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbVContado
        '
        Me.rbVContado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbVContado.Location = New System.Drawing.Point(8, 52)
        Me.rbVContado.Name = "rbVContado"
        Me.rbVContado.Size = New System.Drawing.Size(144, 26)
        Me.rbVContado.TabIndex = 1
        Me.rbVContado.Text = "Compras de Contado"
        Me.rbVContado.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbVTotales
        '
        Me.rbVTotales.Checked = True
        Me.rbVTotales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbVTotales.Location = New System.Drawing.Point(8, 26)
        Me.rbVTotales.Name = "rbVTotales"
        Me.rbVTotales.Size = New System.Drawing.Size(136, 26)
        Me.rbVTotales.TabIndex = 0
        Me.rbVTotales.TabStop = True
        Me.rbVTotales.Text = "Compras Totales"
        Me.rbVTotales.TextAlign = System.Drawing.ContentAlignment.TopLeft
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
        Me.GroupBox3.Location = New System.Drawing.Point(40, 164)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(312, 163)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "TIEMPO"
        '
        'DTPickerDe
        '
        Me.DTPickerDe.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPickerDe.Location = New System.Drawing.Point(104, 100)
        Me.DTPickerDe.Name = "DTPickerDe"
        Me.DTPickerDe.Size = New System.Drawing.Size(120, 21)
        Me.DTPickerDe.TabIndex = 15
        '
        'DTPickerHasta
        '
        Me.DTPickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPickerHasta.Location = New System.Drawing.Point(104, 127)
        Me.DTPickerHasta.Name = "DTPickerHasta"
        Me.DTPickerHasta.Size = New System.Drawing.Size(120, 21)
        Me.DTPickerHasta.TabIndex = 14
        '
        'cbMes
        '
        Me.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMes.Location = New System.Drawing.Point(104, 26)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(120, 23)
        Me.cbMes.TabIndex = 4
        '
        'DTPicker
        '
        Me.DTPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPicker.Location = New System.Drawing.Point(104, 54)
        Me.DTPicker.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.DTPicker.Name = "DTPicker"
        Me.DTPicker.Size = New System.Drawing.Size(120, 21)
        Me.DTPicker.TabIndex = 13
        '
        'rbRango
        '
        Me.rbRango.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbRango.Location = New System.Drawing.Point(8, 80)
        Me.rbRango.Name = "rbRango"
        Me.rbRango.Size = New System.Drawing.Size(88, 26)
        Me.rbRango.TabIndex = 3
        Me.rbRango.Text = "RANGO"
        Me.rbRango.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbFecha1
        '
        Me.rbFecha1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbFecha1.Location = New System.Drawing.Point(8, 54)
        Me.rbFecha1.Name = "rbFecha1"
        Me.rbFecha1.Size = New System.Drawing.Size(88, 26)
        Me.rbFecha1.TabIndex = 2
        Me.rbFecha1.Text = "Fecha"
        Me.rbFecha1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbMes
        '
        Me.rbMes.Checked = True
        Me.rbMes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbMes.Location = New System.Drawing.Point(8, 26)
        Me.rbMes.Name = "rbMes"
        Me.rbMes.Size = New System.Drawing.Size(72, 26)
        Me.rbMes.TabIndex = 1
        Me.rbMes.TabStop = True
        Me.rbMes.Text = "Mes"
        Me.rbMes.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(32, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Hasta"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(32, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 18)
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
        Me.GroupBox4.Controls.Add(Me.chkInventario)
        Me.GroupBox4.Controls.Add(Me.chkProductos)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(369, 45)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(416, 179)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CRITERIOS DE SELECCION"
        '
        'tbCodigo
        '
        Me.tbCodigo.Location = New System.Drawing.Point(96, 43)
        Me.tbCodigo.Name = "tbCodigo"
        Me.tbCodigo.Size = New System.Drawing.Size(160, 21)
        Me.tbCodigo.TabIndex = 5
        '
        'cbProductos
        '
        Me.cbProductos.Location = New System.Drawing.Point(96, 78)
        Me.cbProductos.Name = "cbProductos"
        Me.cbProductos.Size = New System.Drawing.Size(312, 23)
        Me.cbProductos.TabIndex = 6
        '
        'cbProveedores
        '
        Me.cbProveedores.Location = New System.Drawing.Point(96, 112)
        Me.cbProveedores.Name = "cbProveedores"
        Me.cbProveedores.Size = New System.Drawing.Size(312, 23)
        Me.cbProveedores.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(8, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 24)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Articulo"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(8, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 25)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Código"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(8, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 25)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Proveedor"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkInventario
        '
        Me.chkInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInventario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkInventario.Location = New System.Drawing.Point(200, 17)
        Me.chkInventario.Name = "chkInventario"
        Me.chkInventario.Size = New System.Drawing.Size(96, 26)
        Me.chkInventario.TabIndex = 117
        Me.chkInventario.Text = "Inventario"
        '
        'chkProductos
        '
        Me.chkProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProductos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkProductos.Location = New System.Drawing.Point(8, 17)
        Me.chkProductos.Name = "chkProductos"
        Me.chkProductos.Size = New System.Drawing.Size(176, 26)
        Me.chkProductos.TabIndex = 116
        Me.chkProductos.Text = "Productos y Servicios"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.tbRango2)
        Me.GroupBox5.Controls.Add(Me.rbNinguno)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.tbVServicio)
        Me.GroupBox5.Controls.Add(Me.tbVProducto)
        Me.GroupBox5.Controls.Add(Me.tbRango1)
        Me.GroupBox5.Controls.Add(Me.tbTotal)
        Me.GroupBox5.Controls.Add(Me.rbVServicio)
        Me.GroupBox5.Controls.Add(Me.rbVProducto)
        Me.GroupBox5.Controls.Add(Me.rbRangoFact)
        Me.GroupBox5.Controls.Add(Me.rbTotalFact)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox5.Location = New System.Drawing.Point(369, 228)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(416, 164)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "RANGO DE VALOR"
        '
        'tbRango2
        '
        Me.tbRango2.Location = New System.Drawing.Point(324, 78)
        Me.tbRango2.MaxLength = 11
        Me.tbRango2.Name = "tbRango2"
        Me.tbRango2.Size = New System.Drawing.Size(85, 21)
        Me.tbRango2.TabIndex = 6
        Me.tbRango2.Visible = False
        '
        'rbNinguno
        '
        Me.rbNinguno.BackColor = System.Drawing.Color.Transparent
        Me.rbNinguno.Checked = True
        Me.rbNinguno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNinguno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbNinguno.Location = New System.Drawing.Point(7, 26)
        Me.rbNinguno.Name = "rbNinguno"
        Me.rbNinguno.Size = New System.Drawing.Size(160, 26)
        Me.rbNinguno.TabIndex = 11
        Me.rbNinguno.TabStop = True
        Me.rbNinguno.Text = "Ninguno"
        Me.rbNinguno.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbNinguno.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(286, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Hasta"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(168, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "De"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Visible = False
        '
        'tbVServicio
        '
        Me.tbVServicio.Location = New System.Drawing.Point(168, 129)
        Me.tbVServicio.MaxLength = 11
        Me.tbVServicio.Name = "tbVServicio"
        Me.tbVServicio.Size = New System.Drawing.Size(88, 21)
        Me.tbVServicio.TabIndex = 8
        Me.tbVServicio.Visible = False
        '
        'tbVProducto
        '
        Me.tbVProducto.Location = New System.Drawing.Point(168, 103)
        Me.tbVProducto.MaxLength = 11
        Me.tbVProducto.Name = "tbVProducto"
        Me.tbVProducto.Size = New System.Drawing.Size(88, 21)
        Me.tbVProducto.TabIndex = 7
        Me.tbVProducto.Visible = False
        '
        'tbRango1
        '
        Me.tbRango1.Location = New System.Drawing.Point(196, 78)
        Me.tbRango1.MaxLength = 20
        Me.tbRango1.Name = "tbRango1"
        Me.tbRango1.Size = New System.Drawing.Size(83, 21)
        Me.tbRango1.TabIndex = 5
        Me.tbRango1.Visible = False
        '
        'tbTotal
        '
        Me.tbTotal.Location = New System.Drawing.Point(168, 52)
        Me.tbTotal.MaxLength = 11
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(88, 21)
        Me.tbTotal.TabIndex = 4
        Me.tbTotal.Visible = False
        '
        'rbVServicio
        '
        Me.rbVServicio.BackColor = System.Drawing.Color.Transparent
        Me.rbVServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbVServicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbVServicio.Location = New System.Drawing.Point(6, 129)
        Me.rbVServicio.Name = "rbVServicio"
        Me.rbVServicio.Size = New System.Drawing.Size(152, 26)
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
        Me.rbVProducto.Location = New System.Drawing.Point(6, 103)
        Me.rbVProducto.Name = "rbVProducto"
        Me.rbVProducto.Size = New System.Drawing.Size(152, 26)
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
        Me.rbRangoFact.Location = New System.Drawing.Point(6, 78)
        Me.rbRangoFact.Name = "rbRangoFact"
        Me.rbRangoFact.Size = New System.Drawing.Size(168, 25)
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
        Me.rbTotalFact.Location = New System.Drawing.Point(6, 52)
        Me.rbTotalFact.Name = "rbTotalFact"
        Me.rbTotalFact.Size = New System.Drawing.Size(160, 26)
        Me.rbTotalFact.TabIndex = 0
        Me.rbTotalFact.Text = "Valor Total de Factura"
        Me.rbTotalFact.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbTotalFact.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cbFormaPago)
        Me.GroupBox6.Controls.Add(Me.rbIVA)
        Me.GroupBox6.Controls.Add(Me.rbCpC)
        Me.GroupBox6.Controls.Add(Me.rbVentas)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox6.Location = New System.Drawing.Point(369, 398)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(416, 86)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "DESTINO DEL INFORME"
        '
        'cbFormaPago
        '
        Me.cbFormaPago.Location = New System.Drawing.Point(160, 38)
        Me.cbFormaPago.Name = "cbFormaPago"
        Me.cbFormaPago.Size = New System.Drawing.Size(144, 23)
        Me.cbFormaPago.TabIndex = 3
        Me.cbFormaPago.Visible = False
        '
        'rbIVA
        '
        Me.rbIVA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbIVA.Location = New System.Drawing.Point(6, 60)
        Me.rbIVA.Name = "rbIVA"
        Me.rbIVA.Size = New System.Drawing.Size(144, 22)
        Me.rbIVA.TabIndex = 2
        Me.rbIVA.Text = "Impuesto IVA"
        Me.rbIVA.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbIVA.Visible = False
        '
        'rbCpC
        '
        Me.rbCpC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbCpC.Location = New System.Drawing.Point(6, 38)
        Me.rbCpC.Name = "rbCpC"
        Me.rbCpC.Size = New System.Drawing.Size(146, 26)
        Me.rbCpC.TabIndex = 1
        Me.rbCpC.Text = "Cuentas por Pagar"
        Me.rbCpC.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbVentas
        '
        Me.rbVentas.Checked = True
        Me.rbVentas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbVentas.Location = New System.Drawing.Point(6, 17)
        Me.rbVentas.Name = "rbVentas"
        Me.rbVentas.Size = New System.Drawing.Size(152, 26)
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
        Me.GroupBox7.Location = New System.Drawing.Point(800, 52)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(176, 112)
        Me.GroupBox7.TabIndex = 6
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "ORDEN"
        '
        'rbOrdenFac
        '
        Me.rbOrdenFac.Checked = True
        Me.rbOrdenFac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbOrdenFac.Location = New System.Drawing.Point(6, 26)
        Me.rbOrdenFac.Name = "rbOrdenFac"
        Me.rbOrdenFac.Size = New System.Drawing.Size(144, 26)
        Me.rbOrdenFac.TabIndex = 2
        Me.rbOrdenFac.TabStop = True
        Me.rbOrdenFac.Text = "No. de Factura"
        Me.rbOrdenFac.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbOrdenCliente
        '
        Me.rbOrdenCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbOrdenCliente.Location = New System.Drawing.Point(6, 78)
        Me.rbOrdenCliente.Name = "rbOrdenCliente"
        Me.rbOrdenCliente.Size = New System.Drawing.Size(160, 25)
        Me.rbOrdenCliente.TabIndex = 1
        Me.rbOrdenCliente.Text = "Proveedor"
        Me.rbOrdenCliente.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbOrdenFecha
        '
        Me.rbOrdenFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbOrdenFecha.Location = New System.Drawing.Point(6, 52)
        Me.rbOrdenFecha.Name = "rbOrdenFecha"
        Me.rbOrdenFecha.Size = New System.Drawing.Size(152, 26)
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
        Me.GroupBox8.Location = New System.Drawing.Point(800, 172)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(176, 112)
        Me.GroupBox8.TabIndex = 7
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "SALIDA"
        '
        'rbFile
        '
        Me.rbFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbFile.Location = New System.Drawing.Point(6, 78)
        Me.rbFile.Name = "rbFile"
        Me.rbFile.Size = New System.Drawing.Size(154, 25)
        Me.rbFile.TabIndex = 2
        Me.rbFile.Text = "Archivo"
        Me.rbFile.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbPrint
        '
        Me.rbPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbPrint.Location = New System.Drawing.Point(6, 52)
        Me.rbPrint.Name = "rbPrint"
        Me.rbPrint.Size = New System.Drawing.Size(154, 26)
        Me.rbPrint.TabIndex = 1
        Me.rbPrint.Text = "Impresora"
        Me.rbPrint.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbScreen
        '
        Me.rbScreen.Checked = True
        Me.rbScreen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbScreen.Location = New System.Drawing.Point(6, 26)
        Me.rbScreen.Name = "rbScreen"
        Me.rbScreen.Size = New System.Drawing.Size(152, 26)
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
        Me.GroupBox9.Location = New System.Drawing.Point(800, 293)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(176, 191)
        Me.GroupBox9.TabIndex = 8
        Me.GroupBox9.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Location = New System.Drawing.Point(48, 112)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(75, 25)
        Me.cmdAyuda.TabIndex = 2
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(48, 146)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 25)
        Me.Cancel.TabIndex = 1
        Me.Cancel.Text = "&Cancelar"
        '
        'Print
        '
        Me.Print.Location = New System.Drawing.Point(48, 78)
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(75, 24)
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
        Me.GroupBox10.Controls.Add(Me.rbArtAll)
        Me.GroupBox10.Controls.Add(Me.rbProducto)
        Me.GroupBox10.Controls.Add(Me.rbServicio)
        Me.GroupBox10.Controls.Add(Me.rbBoth)
        Me.GroupBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox10.Location = New System.Drawing.Point(41, 333)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(311, 97)
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
        Me.rbArtAll.Location = New System.Drawing.Point(8, 25)
        Me.rbArtAll.Name = "rbArtAll"
        Me.rbArtAll.Size = New System.Drawing.Size(80, 25)
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
        Me.rbProducto.Location = New System.Drawing.Point(110, 25)
        Me.rbProducto.Name = "rbProducto"
        Me.rbProducto.Size = New System.Drawing.Size(88, 25)
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
        Me.rbServicio.Location = New System.Drawing.Point(7, 56)
        Me.rbServicio.Name = "rbServicio"
        Me.rbServicio.Size = New System.Drawing.Size(80, 25)
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
        Me.rbBoth.Location = New System.Drawing.Point(110, 56)
        Me.rbBoth.Name = "rbBoth"
        Me.rbBoth.Size = New System.Drawing.Size(72, 25)
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
        Me.GroupBox12.Location = New System.Drawing.Point(4, 0)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(1008, 34)
        Me.GroupBox12.TabIndex = 115
        Me.GroupBox12.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(8, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 14)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "REPORTE DE COMPRAS"
        '
        'etDescripcion
        '
        Me.etDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcion.ForeColor = System.Drawing.Color.White
        Me.etDescripcion.Location = New System.Drawing.Point(3, 9)
        Me.etDescripcion.Name = "etDescripcion"
        Me.etDescripcion.Size = New System.Drawing.Size(1000, 21)
        Me.etDescripcion.TabIndex = 113
        Me.etDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmReportesFacturasCompras
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 492)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox12)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmReportesFacturasCompras"
        Me.GroupBox1.ResumeLayout(False)
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

        Rutinas.ComboAutoComplete(Me.cbProveedores)
        Rutinas.ComboAutoComplete(Me.cbProductos)

    End Sub

    'Private Sub rbOrdenRed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    cbOrdenRed.Enabled = True
    '    cbOrdenWeb.Enabled = False
    '    tbCotizacion.Enabled = False
    'End Sub

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
        ' cbMes.SelectedValue = 0
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

    Private Sub rbIVA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbIVA.CheckedChanged
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

    Private Sub Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Print.Click
        Dim Mes As String
        Dim Fecha1 As Date
        Dim Fecha2 As Date
        Dim TipoArt As String

        Dim TipoProducto As Integer

        Mes = "" ' cbMes.SelectedValue
        TipoArt = ""

        If rbVentas.Checked = True Or rbCpC.Checked = True Then
            Dim Tipo As String
            If rbVTotales.Checked = True Then
                Tipo = 0
            ElseIf rbVContado.Checked = True Then
                Tipo = 1
            Else
                Tipo = 2
            End If

            If rbMes.Checked Then
                Mes = 0 'cbMes.SelectedValue
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

            'Dim FormaPago As String
            'If cbFormaPago.SelectedValue = 0 Then
            '    FormaPago = ""
            'Else
            '    FormaPago = cbFormaPago.Text
            'End If

            If Me.chkProductos.Checked = True Then
                TipoProducto = 1
            ElseIf Me.chkInventario.Checked = True Then
                TipoProducto = 2
            Else
                TipoProducto = 3
            End If

            'MsgBox(FormaPago)
            ''MsgBox(Fecha2)
            'Return
            Dim fReportes As New frmReportes
            'Dim rFacturas As New rptFacturasCompras
            Dim Clientes As New VB.SysContab.ClientesDB

            Dim rFacturas As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            rFacturas.Load(Application.StartupPath & "\Reportes\rptFacturasCompras.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)


            Dim lComprasFacturasCompras As DataSet = Compras.FacturasCompras(Tipo, Mes, _
                Fecha1, Fecha2, cbProveedores.SelectedValue, cbProductos.SelectedValue, tbCodigo.Text, _
                FacRango1, FacRango2, TipoFac2, TipoArt, ArtMin, ArtMax, cbFormaPago.SelectedValue, Orden, TipoProducto)

            If lComprasFacturasCompras.Tables(0).Rows.Count > 0 Then
                lComprasFacturasCompras.WriteXml(Application.StartupPath & "\xml\fcompras.xml", XmlWriteMode.WriteSchema)

                rFacturas.Database.Tables(0).Location = Application.StartupPath & "\xml\fcompras.xml"
                'rFacturas.SetDataSource(lComprasFacturasCompras)
                fReportes.crvReportes.ReportSource = rFacturas
            Else
                MsgBox("No hay Compras realizadas bajo los criterios de búsqueda")
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

        'Esto se comentariza porque el checkbox esta escondido. Revisar RMPR 28082007
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
        '    lds.WriteXml(Application.StartupPath & "\xml\rptIva.xml", XmlWriteMode.WriteSchema)

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

    Private Sub chkInventario_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkInventario.Click
        If Me.chkInventario.Checked = True Then
            Me.chkProductos.Checked = False
        End If
    End Sub

    Private Sub chkProductos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkProductos.Click
        If Me.chkProductos.Checked = True Then
            Me.chkInventario.Checked = False
        End If
    End Sub


    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/Reportes/ReportesGestion.chm", HelpNavigator.KeywordIndex, "3")
    End Sub
End Class
