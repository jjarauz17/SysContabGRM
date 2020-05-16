Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace DataGridTextBoxCombo
    Public Class frmDevolucionProveedor
        Inherits DevExpress.XtraEditors.XtraForm

        Private Shared ChildInstance As frmDevolucionProveedor = Nothing

        Public Shared Function Instance() As frmDevolucionProveedor
            If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
                ChildInstance = New frmDevolucionProveedor()
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
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents gbBotones As System.Windows.Forms.GroupBox
        Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
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
        Friend WithEvents cmdConsultaProveedores As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents txtOrden As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents etInicio As System.Windows.Forms.Label
        Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cbTodos As System.Windows.Forms.CheckBox
        Friend WithEvents txtProveedor As System.Windows.Forms.TextBox
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
            Me.txtFactura = New System.Windows.Forms.TextBox()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.cbTodos = New System.Windows.Forms.CheckBox()
            Me.etInicio = New System.Windows.Forms.Label()
            Me.txtOrden = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.etSubTotal = New System.Windows.Forms.Label()
            Me.etSubTotalT = New System.Windows.Forms.Label()
            Me.etIva = New System.Windows.Forms.Label()
            Me.etIvaT = New System.Windows.Forms.Label()
            Me.gbBotones = New System.Windows.Forms.GroupBox()
            Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
            Me.cmdConsultaProveedores = New DevExpress.XtraEditors.SimpleButton()
            Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
            Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
            Me.etTotal = New System.Windows.Forms.Label()
            Me.etTotalT = New System.Windows.Forms.Label()
            Me.dgFacturas = New System.Windows.Forms.DataGrid()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.cbProveedor = New System.Windows.Forms.ComboBox()
            Me.txtProveedor = New System.Windows.Forms.TextBox()
            Me.GroupBox3.SuspendLayout()
            Me.gbBotones.SuspendLayout()
            CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label24
            '
            Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label24.Location = New System.Drawing.Point(8, 7)
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
            'txtFactura
            '
            Me.txtFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFactura.Location = New System.Drawing.Point(512, 7)
            Me.txtFactura.MaxLength = 50
            Me.txtFactura.Name = "txtFactura"
            Me.txtFactura.Size = New System.Drawing.Size(120, 20)
            Me.txtFactura.TabIndex = 149
            Me.txtFactura.Text = ""
            '
            'GroupBox3
            '
            Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtProveedor, Me.cbTodos, Me.etInicio, Me.txtOrden, Me.Label8, Me.etSubTotal, Me.etSubTotalT, Me.etIva, Me.etIvaT, Me.gbBotones, Me.etTotal, Me.etTotalT, Me.dgFacturas})
            Me.GroupBox3.Location = New System.Drawing.Point(8, 31)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(1000, 488)
            Me.GroupBox3.TabIndex = 147
            Me.GroupBox3.TabStop = False
            '
            'cbTodos
            '
            Me.cbTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbTodos.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.cbTodos.Location = New System.Drawing.Point(768, 16)
            Me.cbTodos.Name = "cbTodos"
            Me.cbTodos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.cbTodos.Size = New System.Drawing.Size(88, 24)
            Me.cbTodos.TabIndex = 160
            Me.cbTodos.Text = "Todos"
            Me.cbTodos.TextAlign = System.Drawing.ContentAlignment.TopLeft
            '
            'etInicio
            '
            Me.etInicio.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.etInicio.Location = New System.Drawing.Point(752, 312)
            Me.etInicio.Name = "etInicio"
            Me.etInicio.Size = New System.Drawing.Size(80, 24)
            Me.etInicio.TabIndex = 159
            Me.etInicio.Text = "1"
            Me.etInicio.Visible = False
            '
            'txtOrden
            '
            Me.txtOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtOrden.Location = New System.Drawing.Point(544, 352)
            Me.txtOrden.MaxLength = 50
            Me.txtOrden.Name = "txtOrden"
            Me.txtOrden.ReadOnly = True
            Me.txtOrden.Size = New System.Drawing.Size(120, 20)
            Me.txtOrden.TabIndex = 151
            Me.txtOrden.Text = ""
            Me.txtOrden.Visible = False
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label8.Location = New System.Drawing.Point(464, 352)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(72, 24)
            Me.Label8.TabIndex = 150
            Me.Label8.Text = "No. Orden:"
            Me.Label8.Visible = False
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
            'gbBotones
            '
            Me.gbBotones.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.gbBotones.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdAyuda, Me.cmdConsultaProveedores, Me.cmdGuardar, Me.cmdCancelar})
            Me.gbBotones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBotones.ForeColor = System.Drawing.Color.Maroon
            Me.gbBotones.Location = New System.Drawing.Point(904, 32)
            Me.gbBotones.Name = "gbBotones"
            Me.gbBotones.Size = New System.Drawing.Size(88, 408)
            Me.gbBotones.TabIndex = 130
            Me.gbBotones.TabStop = False
            '
            'cmdAyuda
            '
            Me.cmdAyuda.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.cmdAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdAyuda.ForeColor = System.Drawing.Color.Black
            Me.cmdAyuda.Location = New System.Drawing.Point(8, 112)
            Me.cmdAyuda.Name = "cmdAyuda"
            Me.cmdAyuda.Size = New System.Drawing.Size(72, 32)
            Me.cmdAyuda.TabIndex = 34
            Me.cmdAyuda.Text = "&Ayuda"
            '
            'cmdConsultaProveedores
            '
            Me.cmdConsultaProveedores.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.cmdConsultaProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdConsultaProveedores.ForeColor = System.Drawing.Color.Black
            Me.cmdConsultaProveedores.Location = New System.Drawing.Point(8, 64)
            Me.cmdConsultaProveedores.Name = "cmdConsultaProveedores"
            Me.cmdConsultaProveedores.Size = New System.Drawing.Size(72, 32)
            Me.cmdConsultaProveedores.TabIndex = 33
            Me.cmdConsultaProveedores.Text = "&Proveedor"
            '
            'cmdGuardar
            '
            Me.cmdGuardar.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.cmdGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdGuardar.ForeColor = System.Drawing.Color.Black
            Me.cmdGuardar.Location = New System.Drawing.Point(8, 16)
            Me.cmdGuardar.Name = "cmdGuardar"
            Me.cmdGuardar.Size = New System.Drawing.Size(72, 32)
            Me.cmdGuardar.TabIndex = 31
            Me.cmdGuardar.Text = "&Guardar"
            '
            'cmdCancelar
            '
            Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdCancelar.ForeColor = System.Drawing.Color.Black
            Me.cmdCancelar.Location = New System.Drawing.Point(8, 160)
            Me.cmdCancelar.Name = "cmdCancelar"
            Me.cmdCancelar.Size = New System.Drawing.Size(72, 32)
            Me.cmdCancelar.TabIndex = 29
            Me.cmdCancelar.Text = "&Salir"
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
            Me.dgFacturas.Location = New System.Drawing.Point(8, 40)
            Me.dgFacturas.Name = "dgFacturas"
            Me.dgFacturas.ParentRowsBackColor = System.Drawing.Color.LightGray
            Me.dgFacturas.ParentRowsForeColor = System.Drawing.Color.Black
            Me.dgFacturas.SelectionBackColor = System.Drawing.Color.Firebrick
            Me.dgFacturas.SelectionForeColor = System.Drawing.Color.White
            Me.dgFacturas.Size = New System.Drawing.Size(888, 400)
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
            Me.Label7.Location = New System.Drawing.Point(424, 7)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(80, 24)
            Me.Label7.TabIndex = 148
            Me.Label7.Text = "No. Factura:"
            '
            'cbProveedor
            '
            Me.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbProveedor.Location = New System.Drawing.Point(96, 7)
            Me.cbProveedor.Name = "cbProveedor"
            Me.cbProveedor.Size = New System.Drawing.Size(320, 21)
            Me.cbProveedor.TabIndex = 144
            '
            'txtProveedor
            '
            Me.txtProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtProveedor.Location = New System.Drawing.Point(440, 234)
            Me.txtProveedor.MaxLength = 50
            Me.txtProveedor.Name = "txtProveedor"
            Me.txtProveedor.Size = New System.Drawing.Size(120, 20)
            Me.txtProveedor.TabIndex = 161
            Me.txtProveedor.Text = "Proveedor"
            Me.txtProveedor.Visible = False
            '
            'frmDevolucionProveedor
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(1016, 526)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label24, Me.dtpFecha, Me.txtFactura, Me.GroupBox3, Me.Label1, Me.Label7, Me.cbProveedor})
            Me.Name = "frmDevolucionProveedor"
            Me.GroupBox3.ResumeLayout(False)
            Me.gbBotones.ResumeLayout(False)
            CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Dim WithEvents tCust As DataTable
        Private WithEvents myDataSet As DataSet
        Dim ds As DataSet
        'Dim ds1 As DataSet

        Dim i As Integer
        Dim Tipo As Integer

        Private myCheckBoxCol As Integer = 8

        Dim Cantidad As DataGridTextBoxColumn
        'Dim Descuento As DataGridTextBoxColumn
        'Dim Precio As DataGridTextBoxColumn
        'Dim WithEvents ItemTipo As DataGridComboBoxColumn

        'Dim ValorActualCantidad As Double
        'Dim ValorActualPrecio As Double
        'Dim ValorActualDescuento As Double

        Dim Facturas As New VB.SysContab.Facturas_ComprasDB()
        Dim FormaPago As New VB.SysContab.Forma_PagoDB()
        Dim Proveedores As New VB.SysContab.ProveedoresDB()
        Dim DetallesProveedor As New VB.SysContab.ProveedoresDetails()
        'Dim Articulos As New VB.SysContab.ArticulosDB()
        'Dim DetallesProducto As New VB.SysContab.ArticulosDetails()
        Dim r As New VB.SysContab.Rutinas()

        Dim OrdenesCompra As New VB.SysContab.Ordenes_ComprasDB()

        Dim Config As New VB.SysContab.ConfiguracionDB()
        Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails()

        Public Nuevo As Boolean

        Dim dsItems As DataSet

        Dim ValorActualCantidad As Double
        Dim Devolucion As New VB.SysContab.DevolucionesProveedor()
        Public TipoPedido As Integer
        Public Bodega As String

        Private Sub frmFacturasCompra_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'r.CambiarEstilo(Me)
            r.FormularioColor(Me)

            ConfigDetalles = Config.GetConfigDetails

            Me.dtpFecha.Value = r.Fecha

            cbProveedor.DataSource = Proveedores.ProveedoresList(3).Tables("Proveedores")
            cbProveedor.ValueMember = "Codigo"
            cbProveedor.DisplayMember = "Nombre"

            cbProveedor.SelectedValue = 0

            Me.cbProveedor.SelectedValue = Me.txtProveedor.Text

            ds = Facturas.FacturaCompraDetalleDevolucion(Me.txtFactura.Text, Me.txtProveedor.Text, Me.TipoPedido)

            If ds.Tables("Facturas_Compras").Rows.Count <> 0 Then
                cbProveedor.SelectedValue = ds.Tables("Facturas_Compras").Rows(0).Item("Proveedor_ID")
                dtpFecha.Value = ds.Tables("Facturas_Compras").Rows(0).Item("Factura_Fecha")
            End If

            MakeDataSet()
            dgFacturas.SetDataBinding(myDataSet, "Articulos")
            AddCustomDataTableStyle()

            Me.cbProveedor.Enabled = False
            Me.dtpFecha.Enabled = False
            Me.txtFactura.ReadOnly = True

            'Me.cbProveedor.BackColor = Color.White
            'Me.cbProveedor.ForeColor = Color.Black
            'Me.dtpFecha.BackColor = Color.White
            'Me.dtpFechaPago.BackColor = Color.White
            'Me.cbTipoFactura.BackColor = Color.White
            'Me.txtFactura.BackColor = Color.White
            'Me.txtDepartamento.BackColor = Color.White
            'Me.txtDireccion.BackColor = Color.White
            'Me.txtMunicipio.BackColor = Color.White
            'Me.txtOrden.BackColor = Color.White
            'Me.txtPais.BackColor = Color.White
            'Me.txtRuc.BackColor = Color.White
            'Me.txtTelefono.BackColor = Color.White

            LeaveCommit = False
            BuscarCombo = True

            TipoItem = "P"

            Indice = -1

            Tipo = 0

            Me.dgFacturas.ReadOnly = False

            Me.Text = "E n t r a d a  a  A l m a c é n"
            Me.Refresh()
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

            Dim cAgregar As DataColumn
            cAgregar = New DataColumn("Agregar", GetType(System.Boolean))

            Dim cCantidadFacturada As DataColumn
            cCantidadFacturada = New DataColumn("CantidadFacturada")

            Dim cCantidadDevuelta As DataColumn
            cCantidadDevuelta = New DataColumn("CantidadDevuelta")

            tCust.Columns.Add(cArticuloCodigo)
            tCust.Columns.Add(cArticulo)
            tCust.Columns.Add(cCantidad)
            tCust.Columns.Add(cPrecio)
            tCust.Columns.Add(cDescuento)
            tCust.Columns.Add(cSubTotal)
            tCust.Columns.Add(cCodigoTemporal)
            tCust.Columns.Add(cItemTipo)
            tCust.Columns.Add(cAgregar)
            tCust.Columns.Add(cCantidadFacturada)
            tCust.Columns.Add(cCantidadDevuelta)

            myDataSet.Tables.Add(tCust)

            Dim newRow1 As DataRow

            Dim j As Integer

            Dim SubTotal As Double
            Dim Iva As Double

            Dim Descuento As Double

            SubTotal = 0
            Iva = 0

            For j = 0 To ds.Tables("Facturas_Compras").Rows.Count - 1
                newRow1 = tCust.NewRow
                newRow1("ArticuloCodigo") = ds.Tables("Facturas_Compras").Rows(j).Item("Item_ID")

                tCust.Rows.Add(newRow1)

                tCust.Rows(j)("CodigoTemporal") = ds.Tables("Facturas_Compras").Rows(j).Item("Item_ID")
                tCust.Rows(j)("Articulo") = ds.Tables("Facturas_Compras").Rows(j).Item("Descripcion")
                tCust.Rows(j)("Cantidad") = ds.Tables("Facturas_Compras").Rows(j).Item("Cantidad")
                tCust.Rows(j)("Precio") = CDbl(ds.Tables("Facturas_Compras").Rows(j).Item("Item_Costo")).ToString(Round)
                tCust.Rows(j)("Descuento") = CDbl(ds.Tables("Facturas_Compras").Rows(j).Item("Item_Descuento")).ToString(Round)
                tCust.Rows(j)("Tipo") = ds.Tables("Facturas_Compras").Rows(j).Item("Tipo_Item")

                tCust.Rows(j)("Agregar") = False

                Descuento = (CDbl(tCust.Rows(j)("Descuento")) * CDbl(tCust.Rows(j)("Cantidad")) * CDbl(tCust.Rows(j)("Precio"))) / 100.0
                tCust.Rows(j)("SubTotal") = CDbl((CDbl(tCust.Rows(j)("Cantidad")) * CDbl(tCust.Rows(j)("Precio"))) - tCust.Rows(j)("Descuento")).ToString(Round)

                SubTotal = SubTotal + tCust.Rows(j)("SubTotal")
                'Item_Iva_Porcentaje
                Iva = Iva + (SubTotal * (CDbl(ds.Tables("Facturas_Compras").Rows(j).Item("Item_Iva_Porcentaje"))).ToString(Round) / 100.0) 'CDbl(ds.Tables("Facturas_Compras").Rows(j).Item("Item_Iva"))

                tCust.Rows(j)("CantidadFacturada") = ds.Tables("Facturas_Compras").Rows(j).Item("CantidadFacturada")
                tCust.Rows(j)("CantidadDevuelta") = ds.Tables("Facturas_Compras").Rows(j).Item("CantidadDevuelta")
            Next

            Me.etSubTotal.Text = CDbl(SubTotal).ToString(Round)
            Me.etIva.Text = CDbl(Iva).ToString(Round)
            Me.etTotal.Text = (CDbl(SubTotal).ToString(Round) + CDbl(Iva)).ToString(Round)

        End Sub

        Private Sub HandleBoolChanges(ByVal sender As Object, ByVal e As DataGridCheckBoxChangeEvent.BoolValueChangedEventArgs)
            Dim s As String
            s = System.String.Format("Bool Changes: row {0}, col {1}   value {2}", e.Row, e.Column, e.BoolValue)
            Console.WriteLine(s)
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
            ArticuloCodigo.ReadOnly = True

            ts1.GridColumnStyles.Add(ArticuloCodigo)
            ts1.PreferredRowHeight = (ArticuloCodigo.TextBox.Height + 3)

            ArticuloCodigo.NullText = ""

            colCount = (colCount + 1)

            Dim Articulo As DataGridTextBoxColumn
            Articulo = New DataGridTextBoxColumn()
            Articulo.MappingName = "Articulo"
            Articulo.HeaderText = "Descripción"
            Articulo.Width = 300
            Articulo.ReadOnly = True

            ts1.GridColumnStyles.Add(Articulo)
            ts1.PreferredRowHeight = (Articulo.TextBox.Height + 3)

            Articulo.NullText = ""
            colCount = (colCount + 1)

            'Dim Cantidad As DataGridTextBoxColumn
            Cantidad = New DataGridTextBoxColumn()
            Cantidad.MappingName = "Cantidad"
            Cantidad.HeaderText = "Cantidad"
            Cantidad.Width = 85
            Cantidad.Alignment = HorizontalAlignment.Right
            Cantidad.ReadOnly = False

            AddHandler Cantidad.TextBox.Leave, New EventHandler(AddressOf TextBoxCantidadLeaveHandler)

            ts1.GridColumnStyles.Add(Cantidad)
            colCount = (colCount + 1)

            Cantidad.NullText = ""

            Dim Precio As DataGridTextBoxColumn
            Precio = New DataGridTextBoxColumn()
            Precio.MappingName = "Precio"
            Precio.HeaderText = "Costo"
            Precio.Width = 90
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
            Descuento.Width = 90
            Descuento.Alignment = HorizontalAlignment.Right
            Descuento.ReadOnly = True
            Descuento.Format = "##,###0.00"

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

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''Tipo = P: Producto S: Servicio'''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim ItemTipo As DataGridTextBoxColumn
            ItemTipo = New DataGridTextBoxColumn()
            ItemTipo.MappingName = "Tipo"
            ItemTipo.HeaderText = "Tipo"
            ItemTipo.Width = 0
            ItemTipo.ReadOnly = True

            ts1.GridColumnStyles.Add(ItemTipo)
            ts1.PreferredRowHeight = (ItemTipo.TextBox.Height + 3)

            ItemTipo.NullText = ""

            colCount = (colCount + 1)

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

            Dim CantidadFacturada As DataGridTextBoxColumn
            CantidadFacturada = New DataGridTextBoxColumn()
            CantidadFacturada.MappingName = "CantidadFacturada"
            CantidadFacturada.HeaderText = ""
            CantidadFacturada.Width = 0
            CantidadFacturada.Alignment = HorizontalAlignment.Right
            CantidadFacturada.ReadOnly = True

            'AddHandler Cantidad.TextBox.Leave, New EventHandler(AddressOf TextBoxCantidadLeaveHandler)

            ts1.GridColumnStyles.Add(CantidadFacturada)
            colCount = (colCount + 1)

            CantidadFacturada.NullText = ""


            Dim CantidadDevuelta As DataGridTextBoxColumn
            CantidadDevuelta = New DataGridTextBoxColumn()
            CantidadDevuelta.MappingName = "CantidadDevuelta"
            CantidadDevuelta.HeaderText = ""
            CantidadDevuelta.Width = 0
            CantidadDevuelta.Alignment = HorizontalAlignment.Right
            CantidadDevuelta.ReadOnly = True

            'AddHandler Cantidad.TextBox.Leave, New EventHandler(AddressOf TextBoxCantidadLeaveHandler)

            ts1.GridColumnStyles.Add(CantidadDevuelta)
            colCount = (colCount + 1)

            CantidadDevuelta.NullText = ""

            ts1.AllowSorting = False
            ts1.HeaderFont = dgFacturas.HeaderFont
            ts1.HeaderBackColor = Color.LightSteelBlue
            ts1.GridLineColor = Color.FromArgb(70, 130, 180)

            dgFacturas.CaptionVisible = False

            dgFacturas.TableStyles.Clear()
            dgFacturas.TableStyles.Add(ts1)

        End Sub

        Private Sub tCust_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles tCust.ColumnChanged
            'Dim Descuento As Double

            'If e.Column.Ordinal = 2 Or e.Column.Ordinal = 3 Or e.Column.Ordinal = 4 Then
            '    If e.Row.Item(2) Is DBNull.Value Or e.Row.Item(3) Is DBNull.Value Then

            '    Else
            '        If e.Row.Item(4) Is DBNull.Value Then
            '            If IsNumeric(e.Row.Item(2)) And IsNumeric(e.Row.Item(3)) Then
            '                e.Row.Item(5) = CDbl(CDbl(e.Row.Item(2)) * CDbl(e.Row.Item(3))).ToString(Round)
            '            End If

            '        Else
            '            If IsNumeric(e.Row.Item(2)) And IsNumeric(e.Row.Item(3)) And IsNumeric(e.Row.Item(4)) Then
            '                Descuento = (CDbl(e.Row.Item(4)) * CDbl(e.Row.Item(2)) * CDbl(e.Row.Item(3))) / 100.0
            '                e.Row.Item(5) = CDbl(CDbl(e.Row.Item(2)) * CDbl(e.Row.Item(3)) - Descuento).ToString(Round)
            '            End If


            '        End If

            '    End If

            'End If

            'SubTotalFacturaCliente = 0
            'SubTotalFacturaNoDescuentos = 0
            'TotalFacturaCliente = 0
            'TotalDescuento = 0

            'For i = 0 To tCust.Rows.Count - 1

            '    If tCust.Rows(i)("SubTotal") Is DBNull.Value Or tCust.Rows(i)("SubTotal").ToString = "" Or tCust.Rows(i)("SubTotal").ToString = "0.00" Then

            '    ElseIf IsNumeric(tCust.Rows(i)("SubTotal")) And tCust.Rows(i)("SubTotal").ToString <> "" Then
            '        Try
            '            SubTotalFacturaCliente = SubTotalFacturaCliente + tCust.Rows(i)("SubTotal")
            '            SubTotalFacturaNoDescuentos = SubTotalFacturaNoDescuentos + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio"))
            '            TotalDescuento = TotalDescuento + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio") * tCust.Rows(i)("Descuento") / 100.0)
            '        Catch ex As Exception
            '            MsgBox(ex.Message)

            '        End Try

            '    End If

            'Next

            'etSubTotal.Text = SubTotalFacturaNoDescuentos.ToString(Round)
            'etIva.Text = (SubTotalFacturaNoDescuentos * (ConfigDetalles.IVA / 100.0)).ToString(Round)
            'etTotal.Text = (SubTotalFacturaCliente + CDbl(etIva.Text)).ToString(Round)

            'TotalFactura = etTotal.Text

        End Sub

        Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
            Me.Close()
        End Sub

        Private Sub frmFacturacionCliente_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
            'If MsgBox("Desea salir de Facturación?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            '    e.Cancel = True
            '    Exit Sub
            'End If

            'Try
            '    LoadFacturaTemporal = False
            '    FacturarCotizacion = False
            '    LoadOrden = False

            '    Clientes.DeleteReciboCheques("00000")
            '    Clientes.DeleteReciboTarjetas("00000")
            'Catch ex As Exception
            'End Try


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

        Private Sub etTotalT_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles etTotalT.MouseEnter
            '
        End Sub

        Private Sub frmFacturasCompra_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter

        End Sub

        Private Sub dgFacturas_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFacturas.MouseEnter

        End Sub

        Private Sub txtDireccion_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub cbProveedor_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbProveedor.MouseEnter

        End Sub

        Private Sub gbBotones_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles gbBotones.MouseEnter

        End Sub

        Private Sub GroupBox3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupBox3.MouseEnter

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

        Private Sub frmFacturasCompra_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
            Dim f As frmDevolucionesFacturasCompras = f.Instance
            f.etInicio.Text = "0"
            'Dim f As frmFacturasComprasList = f.Instance
            'ds = f.Facturas.FacturasCompraLista(f.cbProveedor.SelectedValue, f.Fecha, f.cbEstado.SelectedIndex, f.cbTipo.SelectedValue)
            'f.dgOrdenes.DataSource = ds.Tables("Facturas_Compra").DefaultView
        End Sub

        Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
            Dim Cantidad As Integer
            Dim k As Integer
            Cantidad = 0

            If tCust.Rows.Count = 0 Then
                MsgBox("Seleccione al menos un Producto", MsgBoxStyle.Critical)
                Me.dgFacturas.Focus()
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
                Me.dgFacturas.Focus()
                Exit Sub
            End If

            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction

            Dim Numero As String
            Dim Iva As Double

            Numero = Devolucion.Numero

            Try
                Devolucion.AddItem(Numero, Me.txtFactura.Text, Me.txtProveedor.Text)
                'VB.SysContab.BodegasDB.TransaccionBodega_Add(Bodega, "D", Numero, Me.dtpFecha.Value, Me.txtProveedor.Text)
                For k = 0 To tCust.Rows.Count - 1
                    If tCust.Rows(k)("Agregar") = True Then
                        Iva = ((CDbl(tCust.Rows(k)("Precio")) * CDbl(tCust.Rows(k)("Cantidad"))) - ((CDbl(tCust.Rows(k)("Precio")) * CDbl(tCust.Rows(k)("Cantidad"))) * (CDbl(tCust.Rows(k)("Descuento")) / 100.0))) * (ConfigDetalles.IVA / 100.0)
                        Devolucion.AddItemDetalle(Numero, tCust.Rows(k)("CodigoTemporal"), tCust.Rows(k)("Tipo"), tCust.Rows(k)("Cantidad"), Iva)
                        'If tCust.Rows(i)("Cantidad") = ds.Tables("Facturas_Ventas").Rows(i).Item("Cantidad") Then
                        If CDbl(CDbl(tCust.Rows(k)("Cantidad")) + CDbl(tCust.Rows(k)("CantidadDevuelta"))) = CDbl(tCust.Rows(k)("CantidadFacturada")) Then
                            Devolucion.UpdateItem(Me.txtFactura.Text, Me.cbProveedor.SelectedValue, tCust.Rows(k)("CodigoTemporal"), "P", 1)
                        End If
                        'VB.SysContab.BodegasDB.Bodega_Articulos_Add(Bodega, tCust.Rows(k)("CodigoTemporal"), CDbl(tCust.Rows(k)("Cantidad")) * -1, CDbl(tCust.Rows(k)("Precio")), IIf(Me.TipoPedido = 1, "P", "A"))
                        'VB.SysContab.BodegasDB.TransaccionBodegaDetalle_Add(Bodega, tCust.Rows(k)("CodigoTemporal"), "D", Numero, "S", CDbl(tCust.Rows(k)("Cantidad")), CDbl(tCust.Rows(k)("Precio")), Me.txtProveedor.Text, IIf(Me.TipoPedido = 1, "P", "A"))
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

        Private Sub dgFacturas_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dgFacturas.MouseUp
            Dim hti As DataGrid.HitTestInfo = Me.dgFacturas.HitTest(e.X, e.Y)
            Try
                If hti.Type = DataGrid.HitTestType.Cell AndAlso hti.Column = myCheckBoxCol Then
                    Me.dgFacturas(hti.Row, hti.Column) = Not CBool(Me.dgFacturas(hti.Row, hti.Column))
                Else
                    Exit Sub
                End If
            Catch ex As Exception
                'MessageBox.Show(ex.ToString())
            End Try
        End Sub 'dataGrid2_MouseUp

        Private Sub dgFacturas_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFacturas.CurrentCellChanged
            Try
                If Me.dgFacturas.CurrentRowIndex = tCust.Rows.Count Then
                    Me.dgFacturas.ReadOnly = True
                    Exit Sub
                Else
                    Me.dgFacturas.ReadOnly = False
                End If

                ValorActualCantidad = tCust.Rows(dgFacturas.CurrentRowIndex)("Cantidad")

            Catch ex As Exception
                'MsgBox(ex.Message)
                Exit Sub
            End Try
        End Sub

        Private Sub TextBoxCantidadLeaveHandler(ByVal sender As Object, ByVal e As EventArgs)
            If Not IsNumeric(Cantidad.TextBox.Text) Then
                Cantidad.TextBox.Text = ValorActualCantidad
            Else
                If CDbl(Cantidad.TextBox.Text) <= 0 Then
                    MsgBox("La cantidad debe ser mayor que Cero (0)", MsgBoxStyle.Information)
                    Cantidad.TextBox.Text = ValorActualCantidad
                    Exit Sub
                Else
                    If CDbl(Cantidad.TextBox.Text) > ds.Tables("Facturas_Compras").Rows(Me.dgFacturas.CurrentRowIndex).Item("Cantidad") Then
                        MsgBox("La cantidad a devolver debe ser menor o igual a la cantidad Facturada", MsgBoxStyle.Information)
                        Cantidad.TextBox.Text = ValorActualCantidad
                        Exit Sub
                    End If
                End If
            End If
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

    End Class

End Namespace

'Economart.
'Plaza españa
'DBA 

'Economart. Managua, Rotonda el Güegüense, 1/2c al lago, (505) 268-3499.
'Eduardo Internacional. Masaya, Barrio el Repliegue. Escuela Hermanos del Japón, ...

