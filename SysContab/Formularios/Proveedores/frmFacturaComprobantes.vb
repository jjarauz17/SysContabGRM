Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmFacturaComprobantes
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmFacturaComprobantes = Nothing

    Public Shared Function Instance() As frmFacturaComprobantes
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmFacturaComprobantes()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
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
    Friend WithEvents dgArticulos As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents etBalance As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbBancos As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCheque As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents etInicio As System.Windows.Forms.Label
    Friend WithEvents cmdPagar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbTipoComp As System.Windows.Forms.ComboBox
    Friend WithEvents etTotalMonto As System.Windows.Forms.Label
    Friend WithEvents etTotales As System.Windows.Forms.Label
    Friend WithEvents etTotalPagado As System.Windows.Forms.Label
    Friend WithEvents etTotalPendiente As System.Windows.Forms.Label
    Friend WithEvents etTotalPagar As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbProveedores As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dgArticulos = New System.Windows.Forms.DataGrid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.etTotalPagar = New System.Windows.Forms.Label()
        Me.etTotalPendiente = New System.Windows.Forms.Label()
        Me.etTotalPagado = New System.Windows.Forms.Label()
        Me.etTotales = New System.Windows.Forms.Label()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdPagar = New DevExpress.XtraEditors.SimpleButton()
        Me.etTotalMonto = New System.Windows.Forms.Label()
        Me.etBalance = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbBancos = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCheque = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.etInicio = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbTipoComp = New System.Windows.Forms.ComboBox()
        Me.cbProveedores = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgArticulos
        '
        Me.dgArticulos.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgArticulos.BackColor = System.Drawing.Color.Gainsboro
        Me.dgArticulos.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgArticulos.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgArticulos.CaptionFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgArticulos.CaptionForeColor = System.Drawing.Color.DarkRed
        Me.dgArticulos.CaptionText = "Prueba"
        Me.dgArticulos.DataMember = ""
        Me.dgArticulos.FlatMode = True
        Me.dgArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgArticulos.ForeColor = System.Drawing.Color.Black
        Me.dgArticulos.GridLineColor = System.Drawing.Color.Silver
        Me.dgArticulos.HeaderBackColor = System.Drawing.Color.Black
        Me.dgArticulos.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgArticulos.HeaderForeColor = System.Drawing.Color.White
        Me.dgArticulos.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgArticulos.Location = New System.Drawing.Point(8, 8)
        Me.dgArticulos.Name = "dgArticulos"
        Me.dgArticulos.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgArticulos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgArticulos.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgArticulos.SelectionForeColor = System.Drawing.Color.White
        Me.dgArticulos.Size = New System.Drawing.Size(976, 24)
        Me.dgArticulos.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.etTotalPagar, Me.etTotalPendiente, Me.etTotalPagado, Me.etTotales, Me.cmdSalir, Me.cmdPagar, Me.dgArticulos, Me.etTotalMonto})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(992, 416)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'etTotalPagar
        '
        Me.etTotalPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalPagar.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.etTotalPagar.Location = New System.Drawing.Point(864, 384)
        Me.etTotalPagar.Name = "etTotalPagar"
        Me.etTotalPagar.Size = New System.Drawing.Size(88, 24)
        Me.etTotalPagar.TabIndex = 165
        Me.etTotalPagar.Text = "0.00"
        Me.etTotalPagar.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.etTotalPagar.Visible = False
        '
        'etTotalPendiente
        '
        Me.etTotalPendiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalPendiente.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.etTotalPendiente.Location = New System.Drawing.Point(768, 384)
        Me.etTotalPendiente.Name = "etTotalPendiente"
        Me.etTotalPendiente.Size = New System.Drawing.Size(88, 24)
        Me.etTotalPendiente.TabIndex = 164
        Me.etTotalPendiente.Text = "0.00"
        Me.etTotalPendiente.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.etTotalPendiente.Visible = False
        '
        'etTotalPagado
        '
        Me.etTotalPagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalPagado.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.etTotalPagado.Location = New System.Drawing.Point(664, 384)
        Me.etTotalPagado.Name = "etTotalPagado"
        Me.etTotalPagado.Size = New System.Drawing.Size(88, 24)
        Me.etTotalPagado.TabIndex = 163
        Me.etTotalPagado.Text = "0.00"
        Me.etTotalPagado.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.etTotalPagado.Visible = False
        '
        'etTotales
        '
        Me.etTotales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotales.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.etTotales.Location = New System.Drawing.Point(432, 384)
        Me.etTotales.Name = "etTotales"
        Me.etTotales.Size = New System.Drawing.Size(120, 24)
        Me.etTotales.TabIndex = 162
        Me.etTotales.Text = "Totales:"
        Me.etTotales.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.etTotales.Visible = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(104, 384)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Cancelar"
        '
        'cmdPagar
        '
        Me.cmdPagar.Location = New System.Drawing.Point(16, 384)
        Me.cmdPagar.Name = "cmdPagar"
        Me.cmdPagar.Size = New System.Drawing.Size(72, 24)
        Me.cmdPagar.TabIndex = 1
        Me.cmdPagar.Text = "&Pagar"
        '
        'etTotalMonto
        '
        Me.etTotalMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalMonto.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.etTotalMonto.Location = New System.Drawing.Point(568, 384)
        Me.etTotalMonto.Name = "etTotalMonto"
        Me.etTotalMonto.Size = New System.Drawing.Size(88, 24)
        Me.etTotalMonto.TabIndex = 161
        Me.etTotalMonto.Text = "0.00"
        Me.etTotalMonto.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.etTotalMonto.Visible = False
        '
        'etBalance
        '
        Me.etBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etBalance.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.etBalance.Location = New System.Drawing.Point(720, 8)
        Me.etBalance.Name = "etBalance"
        Me.etBalance.Size = New System.Drawing.Size(200, 24)
        Me.etBalance.TabIndex = 151
        Me.etBalance.Text = "0"
        Me.etBalance.Visible = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label8.Location = New System.Drawing.Point(648, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 24)
        Me.Label8.TabIndex = 150
        Me.Label8.Text = "Balance:"
        Me.Label8.Visible = False
        '
        'cbBancos
        '
        Me.cbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBancos.Location = New System.Drawing.Point(144, 8)
        Me.cbBancos.Name = "cbBancos"
        Me.cbBancos.Size = New System.Drawing.Size(480, 21)
        Me.cbBancos.TabIndex = 148
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label25.Location = New System.Drawing.Point(8, 8)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(128, 24)
        Me.Label25.TabIndex = 149
        Me.Label25.Text = "Cuentas de Bancos:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 24)
        Me.Label5.TabIndex = 156
        Me.Label5.Text = "No. de Cheque:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCheque
        '
        Me.txtCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheque.Location = New System.Drawing.Point(144, 40)
        Me.txtCheque.MaxLength = 13
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(152, 20)
        Me.txtCheque.TabIndex = 153
        Me.txtCheque.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 155
        Me.Label2.Text = "Fecha de Pago:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFecha.Location = New System.Drawing.Point(144, 72)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha.TabIndex = 154
        Me.dtpFecha.Value = New Date(2006, 8, 10, 10, 38, 43, 562)
        '
        'etInicio
        '
        Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.etInicio.Location = New System.Drawing.Point(648, 72)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(64, 24)
        Me.etInicio.TabIndex = 157
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label9.Location = New System.Drawing.Point(336, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 24)
        Me.Label9.TabIndex = 160
        Me.Label9.Text = "Tipo:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.Visible = False
        '
        'cbTipoComp
        '
        Me.cbTipoComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoComp.Location = New System.Drawing.Point(384, 72)
        Me.cbTipoComp.Name = "cbTipoComp"
        Me.cbTipoComp.Size = New System.Drawing.Size(240, 21)
        Me.cbTipoComp.TabIndex = 159
        Me.cbTipoComp.Visible = False
        '
        'cbProveedores
        '
        Me.cbProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedores.Location = New System.Drawing.Point(392, 40)
        Me.cbProveedores.Name = "cbProveedores"
        Me.cbProveedores.Size = New System.Drawing.Size(400, 21)
        Me.cbProveedores.TabIndex = 166
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Location = New System.Drawing.Point(304, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 24)
        Me.Label1.TabIndex = 167
        Me.Label1.Text = "Proveedor:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmFacturaComprobantes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1008, 526)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label9, Me.cbTipoComp, Me.etInicio, Me.Label5, Me.txtCheque, Me.Label2, Me.dtpFecha, Me.etBalance, Me.Label8, Me.cbBancos, Me.Label25, Me.GroupBox1, Me.Label1, Me.cbProveedores})
        Me.Name = "frmFacturaComprobantes"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.WindowState = FormWindowState.Maximized
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim CatalogoBancos As New VB.SysContab.Catalogo_BancosDB()
    Dim Proveedores As New VB.SysContab.ProveedoresDB()
    Private Comprobantes As New VB.SysContab.ComprobanteDB()

    Dim r As New VB.SysContab.Rutinas()

    Public WithEvents myDataSet As DataSet
    Dim tCust As DataTable
    Public WithEvents tCust1 As New DataTable()
    'Dim tCust1 As DataTable

    Public ds As DataSet
    Dim dsCB As DataSet

    Dim MontoPagar As New DataGridTextBoxColumn()
    Dim ValorActualCantidad As String
    Dim i As Integer
    Dim n As Integer
    Dim TotalPagar As Double
    Dim c As Integer

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub frmFacturaComprobantes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Tabla As New DataTable()

        'r.CambiarEstilo(Me)
        r.FormularioColor(Me)
        Me.dtpFecha.Value = r.Fecha

        Me.cbBancos.DataSource = CatalogoBancos.CatalogoBancos().Tables("Tabla")
        Me.cbBancos.ValueMember = "Cuenta"
        Me.cbBancos.DisplayMember = "Nombre"

        Me.cbTipoComp.DataSource = Comprobantes.TiposComprobantesCheques().Tables("TipoComprobantes")
        Me.cbTipoComp.ValueMember = "TipComp_Id"
        Me.cbTipoComp.DisplayMember = "TipComp_Nombre"

        Me.cbProveedores.DataSource = Proveedores.ListAll().Tables("Proveedores")
        Me.cbProveedores.ValueMember = "Codigo"
        Me.cbProveedores.DisplayMember = "Nombre"

        Buscar()

        r.ComboAutoComplete(Me.cbProveedores)

        Me.Refresh()

    End Sub

    Private Sub dgArticulos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgArticulos.CurrentCellChanged
        Try
            'MsgBox(Me.dgArticulos.Item(Me.dgArticulos.CurrentRowIndex, 5))
            ValorActualCantidad = tCust.Rows(dgArticulos.CurrentRowIndex)("MontoPagar")
            'tCust.Rows(i)("MontoPendiente")
            If CDbl(Me.dgArticulos.Item(Me.dgArticulos.CurrentRowIndex, 6)) = 0 Then
                Me.dgArticulos.ReadOnly = True
            Else
                Me.dgArticulos.ReadOnly = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

    End Sub

    Public Sub MakeDataSet()

        ' Create a DataSet.
        myDataSet = New DataSet("myDataSet")


        ' Create two DataTables.
        'Dim tCust As DataTable
        tCust = New DataTable("Item")


        Dim cAgregar As DataColumn
        cAgregar = New DataColumn("Agregar", GetType(System.Boolean))

        Dim cFecha As DataColumn
        cFecha = New DataColumn("Fecha")

        Dim cProveedor As DataColumn
        cProveedor = New DataColumn("Proveedor")

        Dim cFactura As DataColumn
        cFactura = New DataColumn("Factura")

        Dim cMonto As DataColumn
        cMonto = New DataColumn("Monto")

        Dim cMontoPagado As DataColumn
        cMontoPagado = New DataColumn("MontoPagado")

        Dim cMontoPendiente As DataColumn
        cMontoPendiente = New DataColumn("MontoPendiente")

        Dim cMontoPagar As DataColumn
        cMontoPagar = New DataColumn("MontoPagar")

        Dim cDetalle As DataColumn
        cDetalle = New DataColumn("Detalle")

        Dim cNumero As DataColumn
        cNumero = New DataColumn("Numero")

        'Dim cCurrent2 As DataColumn
        'cCurrent2 = New DataColumn("Current2", GetType(System.Boolean))
        tCust.Columns.Add(cAgregar)
        tCust.Columns.Add(cFecha)
        tCust.Columns.Add(cProveedor)
        tCust.Columns.Add(cFactura)
        tCust.Columns.Add(cMonto)
        tCust.Columns.Add(cMontoPagado)
        tCust.Columns.Add(cMontoPendiente)
        tCust.Columns.Add(cMontoPagar)
        tCust.Columns.Add(cDetalle)
        tCust.Columns.Add(cNumero)

        tCust.DefaultView.AllowDelete = False
        tCust.DefaultView.AllowNew = False
        tCust.DefaultView.AllowEdit = False

        myDataSet.Tables.Add(tCust)

        Dim newRow1 As DataRow
        Dim i As Integer
        i = 0
        Dim TotalMonto As Double
        Dim TotalPagado As Double
        Dim TotalPendiente As Double

        TotalMonto = 0
        TotalPagado = 0
        TotalPendiente = 0

        Me.dgArticulos.Size = New System.Drawing.Size(976, 24)

        For i = 0 To ds.Tables("Facturas").Rows.Count - 1
            newRow1 = tCust.NewRow
            newRow1("Proveedor") = ds.Tables("Facturas").Rows(i).Item("Proveedor")
            tCust.Rows.Add(newRow1)

            tCust.Rows(i)("Detalle") = "Mostrar Detalles"
            tCust.Rows(i)("Fecha") = ds.Tables("Facturas").Rows(i).Item("Fecha")
            tCust.Rows(i)("Factura") = ds.Tables("Facturas").Rows(i).Item("Factura")
            tCust.Rows(i)("Monto") = CDbl(ds.Tables("Facturas").Rows(i).Item("Monto")).ToString(Round)
            tCust.Rows(i)("MontoPagado") = CDbl(ds.Tables("Facturas").Rows(i).Item("Monto Pagado")).ToString(Round)
            tCust.Rows(i)("MontoPendiente") = CDbl(ds.Tables("Facturas").Rows(i).Item("Monto Pendiente")).ToString(Round)
            tCust.Rows(i)("MontoPagar") = ""
            tCust.Rows(i)("Agregar") = False
            TotalMonto = TotalMonto + CDbl(ds.Tables("Facturas").Rows(i).Item("Monto"))
            TotalPagado = TotalPagado + CDbl(ds.Tables("Facturas").Rows(i).Item("Monto Pagado"))
            TotalPendiente = TotalPendiente + CDbl(ds.Tables("Facturas").Rows(i).Item("Monto Pendiente"))
            'Me.dgArticulos.Size.Width = Me.dgArticulos.Size.Width + 24
            Me.dgArticulos.Size = New System.Drawing.Size(976, Me.dgArticulos.Size.Height + 24)
            tCust.Rows(i)("Numero") = i
        Next

        If ds.Tables("Facturas").Rows.Count > 0 Then
            Me.dgArticulos.Size = New System.Drawing.Size(976, Me.dgArticulos.Size.Height + 36)

            If Me.dgArticulos.Size.Height > 368 Then
                Me.dgArticulos.Size = New System.Drawing.Size(976, 368)
            End If
        End If

        'Me.cmdPagar.Location = New System.Drawing.Point(16, 384)

        Me.cmdPagar.Location = New System.Drawing.Point(Me.cmdPagar.Location.X, Me.dgArticulos.Size.Height + 16)
        Me.cmdSalir.Location = New System.Drawing.Point(Me.cmdSalir.Location.X, Me.dgArticulos.Size.Height + 16)
        Me.etTotales.Location = New System.Drawing.Point(Me.etTotales.Location.X, Me.dgArticulos.Size.Height + 16)
        Me.etTotalMonto.Location = New System.Drawing.Point(Me.etTotalMonto.Location.X, Me.dgArticulos.Size.Height + 16)
        Me.etTotalPagado.Location = New System.Drawing.Point(Me.etTotalPagado.Location.X, Me.dgArticulos.Size.Height + 16)
        Me.etTotalPendiente.Location = New System.Drawing.Point(Me.etTotalPendiente.Location.X, Me.dgArticulos.Size.Height + 16)
        Me.etTotalPagar.Location = New System.Drawing.Point(Me.etTotalPagar.Location.X, Me.dgArticulos.Size.Height + 16)

        myDataSet.Tables("Item").DefaultView.AllowDelete = False

        Me.etTotalMonto.Text = TotalMonto.ToString(Round)
        Me.etTotalPagado.Text = TotalPagado.ToString(Round)
        Me.etTotalPendiente.Text = TotalPendiente.ToString(Round)
        'myDataSet.Tables("EastCoastSales").DefaultView.AllowNew = False
    End Sub

    'Private Sub TextBoxDoubleClickHandler(ByVal sender As Object, ByVal e As EventArgs)
    Private Sub TextBoxMouseEnterHandler(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim f As frmDetalleArticulo = f.Instance

            Registro = dgArticulos.Item(dgArticulos.CurrentRowIndex, 3)

            f.MdiParent = Me.MdiParent
            f.Show()
            'Me.seleccionar()
        Catch ex As Exception
            'MsgBox(ex.Message)

        End Try
    End Sub

    'Private Sub TextBoxCantidadEnterHandler(ByVal sender As Object, ByVal e As EventArgs)
    '    If Me.dgArticulos.CurrentRowIndex >= ds.Tables("Facturas").Rows.Count Then
    '        Me.dgArticulos.ReadOnly = True
    '    Else
    '        Me.dgArticulos.ReadOnly = False
    '    End If
    'End Sub

    Private Sub TextBoxCantidadLeaveHandler(ByVal sender As Object, ByVal e As EventArgs)

        If Trim(MontoPagar.TextBox.Text) = "" Or MontoPagar.TextBox.Text Is DBNull.Value Then
            tCust.Rows(Me.dgArticulos.CurrentRowIndex)("Agregar") = False
            tCust.Rows(Me.dgArticulos.CurrentRowIndex)("MontoPagar") = ""
            'Me.dgArticulos.Refresh()
            CalcularTotalPagar()
            Exit Sub
        End If

        If Not IsNumeric(MontoPagar.TextBox.Text) Then
            MsgBox("Ingrese un valor válido", MsgBoxStyle.Information)
            If Not IsNumeric(ValorActualCantidad) Then
                MontoPagar.TextBox.Text = ValorActualCantidad 'ValorActualCantidad '.ToString(Round)
            Else
                MontoPagar.TextBox.Text = CDbl(ValorActualCantidad).ToString(Round)
            End If

        Else
            If CDbl(MontoPagar.TextBox.Text) = 0 Then
                MontoPagar.TextBox.Text = ""
                tCust.Rows(Me.dgArticulos.CurrentRowIndex)("Agregar") = False
                tCust.Rows(Me.dgArticulos.CurrentRowIndex)("MontoPagar") = ""
                Me.dgArticulos.Refresh()
            ElseIf CDbl(MontoPagar.TextBox.Text) < 0 Then
                MsgBox("La cantidad debe ser mayor que Cero (0)", MsgBoxStyle.Information)
                If Not IsNumeric(ValorActualCantidad) Then
                    MontoPagar.TextBox.Text = ValorActualCantidad 'ValorActualCantidad '.ToString(Round)
                Else
                    MontoPagar.TextBox.Text = CDbl(ValorActualCantidad).ToString(Round)
                End If
            Else
                tCust.Rows(Me.dgArticulos.CurrentRowIndex)("MontoPagar") = CDbl(MontoPagar.TextBox.Text).ToString(Round)
                tCust.Rows(Me.dgArticulos.CurrentRowIndex)("Agregar") = True
                'Me.dgArticulos.Refresh()
                CalcularTotalPagar()
                Exit Sub
            End If
        End If

        CalcularTotalPagar()

        'DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(tCust.Rows(Me.dgArticulos.CurrentRowIndex)("Codigo"), "P", EmpresaActual)
        'If DetallesProducto.Existencia Is Nothing Or DetallesProducto.Existencia Is DBNull.Value Then
        '    '
        'ElseIf DetallesProducto.Existencia = 0 Then
        '    MsgBox("No hay existencias", MsgBoxStyle.Critical)
        '    Cantidad.TextBox.Text = ValorActualCantidad
        '    Exit Sub
        'ElseIf CDbl(Cantidad.TextBox.Text) > CDbl(DetallesProducto.Existencia) Then
        '    MsgBox("La cantidad es mayor que la existencia actual", MsgBoxStyle.Critical)
        '    Cantidad.TextBox.Text = ValorActualCantidad
        '    Exit Sub
        'End If

    End Sub

    Public Sub AddCustomDataTableStyle()

        'STEP 1: Create a DataTable style object and set properties if required.
        Dim ts1 As DataGridTableStyle
        ts1 = New DataGridTableStyle()
        'specify the table from dataset (required step)
        ts1.MappingName = "Item"
        ' Set other properties (optional step)
        ts1.AlternatingBackColor = Color.LightBlue
        Dim colCount As Integer
        colCount = 0

        'STEP 4: Add the checkbox
        Dim boolCol As DataGridCheckBoxChangeEvent.MyDataGridBoolColumn
        boolCol = New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn(colCount)
        boolCol.MappingName = "Agregar"
        boolCol.HeaderText = "Pagar"
        boolCol.Alignment = HorizontalAlignment.Center
        'uncomment this line to get a two-state checkbox
        CType(boolCol, DataGridBoolColumn).AllowNull = False
        boolCol.Width = 50
        boolCol.ReadOnly = False
        boolCol.NullText = ""
        AddHandler boolCol.BoolValueChanged, New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn.BoolValueChangedEventHandler(AddressOf HandleBoolChanges)
        ts1.GridColumnStyles.Add(boolCol)
        colCount = (colCount + 1)

        'Dim Detalle As New DataGridTextBoxColumn()
        'Detalle.MappingName = "Detalle"
        'Detalle.HeaderText = "Mostrar Detalles"
        'Detalle.ReadOnly = True
        'Detalle.Alignment = HorizontalAlignment.Center
        'Detalle.Width = 115
        'Detalle.NullText = ""
        'AddHandler Detalle.TextBox.MouseEnter, New EventHandler(AddressOf TextBoxMouseEnterHandler)
        'ts1.GridColumnStyles.Add(Detalle)
        'colCount = (colCount + 1)


        Dim Fecha As DataGridTextBoxColumn
        Fecha = New DataGridTextBoxColumn()
        Fecha.MappingName = "Fecha"
        Fecha.HeaderText = "Fecha"
        Fecha.Width = 85
        Fecha.ReadOnly = True
        Fecha.Format = "dd/MM/yyyy"
        ts1.GridColumnStyles.Add(Fecha)
        colCount = (colCount + 1)
        Fecha.NullText = ""


        Dim Proveedor As DataGridColumnStyle
        Proveedor = New DataGridTextBoxColumn()
        Proveedor.MappingName = "Proveedor"
        Proveedor.HeaderText = "Proveedor"
        Proveedor.Width = 300
        Proveedor.ReadOnly = True
        ts1.GridColumnStyles.Add(Proveedor)
        colCount = (colCount + 1)
        Proveedor.NullText = ""

        Dim Factura As DataGridColumnStyle
        Factura = New DataGridTextBoxColumn()
        Factura.MappingName = "Factura"
        Factura.HeaderText = "Factura"
        Factura.Width = 75
        Factura.ReadOnly = True
        Factura.Alignment = HorizontalAlignment.Left
        ts1.GridColumnStyles.Add(Factura)
        colCount = (colCount + 1)
        Factura.NullText = ""

        Dim Monto As DataGridColumnStyle
        Monto = New DataGridTextBoxColumn()
        Monto.MappingName = "Monto"
        Monto.HeaderText = "Monto"
        Monto.Width = 100
        Monto.ReadOnly = True
        Monto.Alignment = HorizontalAlignment.Right
        ts1.GridColumnStyles.Add(Monto)
        colCount = (colCount + 1)
        Monto.NullText = "0.00"

        Dim MontoPagado As DataGridColumnStyle
        MontoPagado = New DataGridTextBoxColumn()
        MontoPagado.MappingName = "MontoPagado"
        MontoPagado.HeaderText = "Monto Pagado"
        MontoPagado.Width = 100
        MontoPagado.ReadOnly = True
        MontoPagado.Alignment = HorizontalAlignment.Right
        ts1.GridColumnStyles.Add(MontoPagado)
        colCount = (colCount + 1)
        MontoPagado.NullText = ""

        Dim MontoPendiente As DataGridColumnStyle
        MontoPendiente = New DataGridTextBoxColumn()
        MontoPendiente.MappingName = "MontoPendiente"
        MontoPendiente.HeaderText = "Monto Pendiente"
        MontoPendiente.Width = 100
        MontoPendiente.ReadOnly = True
        MontoPendiente.Alignment = HorizontalAlignment.Right
        ts1.GridColumnStyles.Add(MontoPendiente)
        colCount = (colCount + 1)
        MontoPendiente.NullText = ""

        MontoPagar.MappingName = "MontoPagar"
        MontoPagar.HeaderText = "Monto a Pagar"
        MontoPagar.ReadOnly = False
        MontoPagar.Alignment = HorizontalAlignment.Right
        MontoPagar.Width = 100
        MontoPagar.NullText = ""
        AddHandler MontoPagar.TextBox.Leave, New EventHandler(AddressOf TextBoxCantidadLeaveHandler)
        'AddHandler MontoPagar.TextBox.Enter, New EventHandler(AddressOf TextBoxCantidadEnterHandler)
        ts1.GridColumnStyles.Add(MontoPagar)
        colCount = (colCount + 1)

        Dim Numero As DataGridColumnStyle
        Numero = New DataGridTextBoxColumn()
        Numero.MappingName = "Numero"
        Numero.HeaderText = ""
        Numero.Width = 0
        Numero.ReadOnly = True
        Numero.Alignment = HorizontalAlignment.Right
        ts1.GridColumnStyles.Add(Numero)
        colCount = (colCount + 1)
        Numero.NullText = ""

        ts1.AllowSorting = False
        ts1.HeaderFont = Me.dgArticulos.HeaderFont
        ts1.PreferredRowHeight = 25
        ts1.GridLineColor = Color.FromArgb(70, 130, 180)
        ts1.HeaderBackColor = Color.LightSteelBlue
        Me.dgArticulos.CaptionVisible = False

        tCust.DefaultView.AllowDelete = False
        tCust.DefaultView.AllowNew = False
        tCust.DefaultView.AllowEdit = True


        myDataSet.Tables("Item").DefaultView.AllowDelete = False
        myDataSet.Tables("Item").DefaultView.AllowNew = False
        myDataSet.Tables("Item").DefaultView.AllowEdit = True

        dgArticulos.TableStyles.Clear()
        dgArticulos.TableStyles.Add(ts1)

    End Sub

    Private Sub HandleBoolChanges(ByVal sender As Object, ByVal e As DataGridCheckBoxChangeEvent.BoolValueChangedEventArgs)
        Dim s As String
        s = System.String.Format("Bool Changes: row {0}, col {1}   value {2}", e.Row, e.Column, e.BoolValue)
        Console.WriteLine(s)
    End Sub

    Private Sub dgArticulos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgArticulos.KeyDown
        'If e.KeyData = Keys.F3 Then
        '    Dim f As frmDetalleArticulo = f.Instance

        '    Registro = dgArticulos.Item(dgArticulos.CurrentRowIndex, 1)

        '    f.MdiParent = Me.MdiParent
        '    f.Show()
        'End If
    End Sub

    Private Sub frmBuscarItem_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
    End Sub

    Private Sub dgArticulos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgArticulos.MouseEnter        
    End Sub

    Private myCheckBoxCol As Integer = 0 'my checkbox column 

    Private Sub dgArticulos_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dgArticulos.MouseUp
        Dim hti As DataGrid.HitTestInfo = Me.dgArticulos.HitTest(e.X, e.Y)
        Try
            If hti.Type = DataGrid.HitTestType.Cell AndAlso hti.Column = myCheckBoxCol Then
                If CDbl(Me.dgArticulos.Item(Me.dgArticulos.CurrentRowIndex, 6)) = 0 Then
                    Me.dgArticulos(hti.Row, hti.Column) = False
                    tCust.Rows(hti.Row)("MontoPagar") = ""
                Else
                    Me.dgArticulos(hti.Row, hti.Column) = Not CBool(Me.dgArticulos(hti.Row, hti.Column))
                    If Me.dgArticulos(hti.Row, hti.Column) = True Then
                        If tCust.Rows(hti.Row)("MontoPagar") = "" Then
                            tCust.Rows(hti.Row)("MontoPagar") = CDbl(tCust.Rows(hti.Row)("MontoPendiente")).ToString(Round)
                        End If
                    Else
                        tCust.Rows(hti.Row)("MontoPagar") = ""
                    End If
                End If

                Me.dgArticulos.Refresh()
                CalcularTotalPagar()
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.ToString())
        End Try
    End Sub 'dataGrid2_MouseUp 

    Private Sub cbBancos_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbBancos.SelectedValueChanged
        If Me.etInicio.Text = "1" Then
            Exit Sub
        End If

        If Me.cbBancos.SelectedValue = "0" Then
            Me.Label8.Visible = False
            Me.etBalance.Text = 0
            Me.etBalance.Visible = False
            Me.txtCheque.Text = ""
        Else
            Me.Label8.Visible = True
            Me.etBalance.Visible = True
            dsCB = CatalogoBancos.CatalogoBancosXCuenta(Me.cbBancos.SelectedValue)
            Me.txtCheque.Text = CatalogoBancos.GetCheque(dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Banco"), dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Numero_Cuenta")).ToString
            Me.etBalance.Text = CDbl(Comprobantes.SaldoxCuenta(Me.cbBancos.SelectedValue, VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.Value))).ToString(Round)
        End If
    End Sub

    Dim NoComprob As Double
    Private Sub cmdPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPagar.Click
        MakeDataSet1()
        'dgArticulos.SetDataBinding(myDataSet, "Item")
        AddCustomDataTableStyle1()
        AgregarItemTemporal()

        ''For i = 0 To tCust1.Rows.Count - 1
        ''    MsgBox(tCust1.Rows(i)("MontoPagar"))
        ''Next
        '''MsgBox(tCust1.Rows.Count)

        ''Exit Sub

        If Me.cbBancos.SelectedValue = "0" Then
            MsgBox("Seleccione el Banco", MsgBoxStyle.Information)
            Me.cbBancos.Focus()
            Exit Sub
        End If

        If Me.cbTipoComp.SelectedValue = "0" Or Me.cbTipoComp.SelectedValue = Nothing Then
            MsgBox("Seleccione el Tipo de Comprobante", MsgBoxStyle.Information)
            Me.cbTipoComp.Focus()
            Exit Sub
        End If

        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction

        Dim DC As String
        Dim Opera As Integer
        Dim Cheque As Long
        Cheque = Me.txtCheque.Text
        Dim Linea As Integer
        Linea = 0
        NoComprob = 0

        'For i = 0 To tCust.Rows.Count - 1
        '    MsgBox(tCust.Rows(i).Item("Numero"))
        'Next

        'Exit Sub

        Try
            For i = 0 To tCust1.Rows.Count - 1
                'If tCust.Rows(i)("Agregar") = True Then
                Linea = 1
                NoComprob = Comprobantes.AddComprobante(Me.cbTipoComp.SelectedValue, 1, "", VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MonedaBase, VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.Value), dtpFecha.Value, 0, tCust1.Rows(i)("Proveedor"), False, tCust1.Rows(i)("Codigo"), "", 2, "", VB.SysContab.Rutinas.Fecha, 0, OrigenComprobantes.CHEQUE)

                For c = i To tCust.Rows.Count - 1
                    If i = tCust.Rows(c)("Numero") And tCust.Rows(c)("Agregar") = True Then
                        Comprobantes.PagosFactura(ds.Tables("Facturas").Rows(c).Item("Comp_No"), ds.Tables("Facturas").Rows(c).Item("Per_ID"), ds.Tables("Facturas").Rows(c).Item("Fecha"), tCust.Rows(c)("MontoPagar"), NoComprob, VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.Value), dtpFecha.Value, 0, 0, 0)
                        'Comprobantes.PagosFactura(ds.Tables("Facturas").Rows(c).Item("Comp_No"), ds.Tables("Facturas").Rows(c).Item("Per_ID"), ds.Tables("Facturas").Rows(c).Item("Fecha"), tCust.Rows(c)("MontoPagar"), NoComprob, VB.SysContab.PeriodosDB.Activo, dtpFecha.Value)
                    End If
                Next

                DC = "C"

                If Trim(Me.txtCheque.Text) <> "" Then
                    Comprobantes.ActualizarCheque(Me.cbBancos.SelectedValue, Cheque)
                End If

                Comprobantes.AddComprobanteDetalles(NoComprob, Me.cbBancos.SelectedValue, "", tCust1.Rows(i)("MontoPagar"), Cheque, Me.cbTipoComp.SelectedValue, DC, 0, 0, Me.dtpFecha.Value, 0)
                'Comprobantes.AddCatalogoTrans(Me.cbBancos.SelectedValue, 0, tCust1.Rows(i)("MontoPagar"), "")
                'Catalogo.ActualizarCuentas(Me.cbBancos.SelectedValue, Me.txtMonto.Text, 1)

                DC = "D"
                Opera = 1

                Comprobantes.AddComprobanteDetalles(NoComprob, tCust1.Rows(i)("Cuenta"), "", tCust1.Rows(i)("MontoPagar"), Cheque, Me.cbTipoComp.SelectedValue, DC, 0, 0, Me.dtpFecha.Value, 1)
                'Comprobantes.AddCatalogoTrans(tCust1.Rows(i)("Cuenta"), tCust1.Rows(i)("MontoPagar"), 0, "")

                Cheque = Cheque + 1

                'Else
                ' No esta seleccionado
                'End If
            Next

            ''For i = 0 To ds.Tables("Facturas").Rows.Count - 1
            ''    If tCust.Rows(i)("Agregar") = True Then
            ''        Linea = 1
            ''        Comprobantes.PagosFactura(ds.Tables("Facturas").Rows(i).Item("Comp_No"), ds.Tables("Facturas").Rows(i).Item("Per_ID"), ds.Tables("Facturas").Rows(i).Item("Fecha"), tCust.Rows(i)("MontoPagar"), NoComprob, VB.SysContab.PeriodosDB.Activo, dtpFecha.Value)
            ''    End If
            ''Next

            ''''For i = 0 To ds.Tables("Facturas").Rows.Count - 1 ' tCust.Rows.Count - 1
            ''''    If tCust.Rows(i)("Agregar") = True Then
            ''''        Linea = 1
            ''''        'Comprobantes.PagosFactura(ds.Tables("Facturas").Rows(i).Item("Comp_No"), ds.Tables("Facturas").Rows(i).Item("Per_ID"), ds.Tables("Facturas").Rows(i).Item("Fecha"), tCust.Rows(i)("MontoPagar"))

            ''''        NoComprob = Comprobantes.AddComprobante(Me.cbTipoComp.SelectedValue, 1, "", VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MonedaBase, VB.SysContab.PeriodosDB.Activo, dtpFecha.Value, 0, ds.Tables("Facturas").Rows(i).Item("Proveedor"), False, ds.Tables("Facturas").Rows(i).Item("Codigo"), "", 2, "", VB.SysContab.Rutinas.Fecha, 0)
            ''''        Comprobantes.PagosFactura(ds.Tables("Facturas").Rows(i).Item("Comp_No"), ds.Tables("Facturas").Rows(i).Item("Per_ID"), ds.Tables("Facturas").Rows(i).Item("Fecha"), tCust.Rows(i)("MontoPagar"), NoComprob, VB.SysContab.PeriodosDB.Activo, dtpFecha.Value)

            ''''        DC = "C"

            ''''        If Trim(Me.txtCheque.Text) <> "" Then
            ''''            Comprobantes.ActualizarCheque(Me.cbBancos.SelectedValue, Cheque)
            ''''        End If

            ''''        Comprobantes.AddComprobanteDetalles(NoComprob, Me.cbBancos.SelectedValue, "", tCust.Rows(i)("MontoPagar"), Cheque, Me.cbTipoComp.SelectedValue, DC, 0, 0, Me.dtpFecha.Value, 0)
            ''''        Comprobantes.AddCatalogoTrans(Me.cbBancos.SelectedValue, 0, tCust.Rows(i)("MontoPagar"), "")
            ''''        'Catalogo.ActualizarCuentas(Me.cbBancos.SelectedValue, Me.txtMonto.Text, 1)


            ''''        'For i = 0 To tCust.Rows.Count - 1


            ''''        'If VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo1")).Tables("Catalogo").Rows(0).Item("Clase") = 1 Then
            ''''        '    DC = "D"
            ''''        '    Opera = 1
            ''''        'ElseIf VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo1")).Tables("Catalogo").Rows(0).Item("Clase") = 2 And CDbl(tCust.Rows(i)("Monto")) >= 0 Then
            ''''        '    DC = "D"
            ''''        '    Opera = 1
            ''''        'ElseIf VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo1")).Tables("Catalogo").Rows(0).Item("Clase") = 2 And CDbl(tCust.Rows(i)("Monto")) < 0 Then
            ''''        '    DC = "C"
            ''''        '    Opera = 2
            ''''        'End If

            ''''        DC = "D"
            ''''        Opera = 1

            ''''        Comprobantes.AddComprobanteDetalles(NoComprob, ds.Tables("Facturas").Rows(i).Item("Cuenta"), "", tCust.Rows(i)("MontoPagar"), Cheque, Me.cbTipoComp.SelectedValue, DC, 0, 0, Me.dtpFecha.Value, 1)
            ''''        Comprobantes.AddCatalogoTrans(ds.Tables("Facturas").Rows(i).Item("Cuenta"), tCust.Rows(i)("MontoPagar"), 0, "")
            ''''        'Catalogo.ActualizarCuentas(tCust.Rows(i)("Codigo1"), tCust.Rows(i)("Monto"), Opera)
            ''''        'Next

            ''''        Cheque = Cheque + 1

            ''''    Else
            ''''        ' No esta seleccionado
            ''''    End If
            ''''Next

            'Comprobantes.PagosFactura(1, 12, "29/12/2006", "3612.5")
            VB.SysContab.Rutinas.okTransaccion()

            If Linea = 0 Then
                MsgBox("Seleccione al menos una Factura", MsgBoxStyle.Information)
                Exit Sub
            End If

            ds = Proveedores.FacturasComprobantes(Me.cbProveedores.SelectedValue)
            Me.etTotalPagar.Text = "0.00"

            If ds.Tables("Facturas").Rows.Count > 0 Then
                Me.etTotales.Visible = True
                Me.etTotalMonto.Visible = True
                Me.etTotalPagado.Visible = True
                Me.etTotalPendiente.Visible = True
                Me.etTotalPagar.Visible = True
            Else
                Me.etTotales.Visible = False
                Me.etTotalMonto.Visible = False
                Me.etTotalPagado.Visible = False
                Me.etTotalPendiente.Visible = False
                Me.etTotalPagar.Visible = False
            End If

            MakeDataSet()
            dgArticulos.SetDataBinding(myDataSet, "Item")
            AddCustomDataTableStyle()

            If ds.Tables("Facturas").Rows.Count = 0 Then
                Me.dgArticulos.Size = New System.Drawing.Size(976, 24)
                Me.dgArticulos.CaptionText = "No hay facturas."
                Me.dgArticulos.CaptionVisible = True
            End If

            dsCB = CatalogoBancos.CatalogoBancosXCuenta(Me.cbBancos.SelectedValue)
            Me.txtCheque.Text = CatalogoBancos.GetCheque(dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Banco"), dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Numero_Cuenta")).ToString
            Me.etBalance.Text = CDbl(Comprobantes.SaldoxCuenta(Me.cbBancos.SelectedValue, VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.Value))).ToString(Round)

        Catch ex As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub CalcularTotalPagar()
        TotalPagar = 0
        For i = 0 To tCust.Rows.Count - 1
            If tCust.Rows(i)("Agregar") = True Then
                TotalPagar = TotalPagar + CDbl(tCust.Rows(i)("MontoPagar"))
            End If
        Next
        Me.etTotalPagar.Text = TotalPagar.ToString(Round)
    End Sub

    Public Sub MakeDataSet1()
        ' Create a DataSet.
        myDataSet = New DataSet("myDataSet")

        ' Create two DataTables.
        'Dim tCust As DataTable
        tCust1 = New DataTable("Item1")

        Dim cAgregar As DataColumn
        cAgregar = New DataColumn("Agregar", GetType(System.Boolean))

        Dim cFecha As DataColumn
        cFecha = New DataColumn("Fecha")

        Dim cProveedor As DataColumn
        cProveedor = New DataColumn("Proveedor")

        Dim cFactura As DataColumn
        cFactura = New DataColumn("Factura")

        Dim cCodigo As DataColumn
        cCodigo = New DataColumn("Codigo")

        Dim cCuenta As DataColumn
        cCuenta = New DataColumn("Cuenta")

        Dim cComp_No As DataColumn
        cComp_No = New DataColumn("Comp_No")

        Dim cPer_ID As DataColumn
        cPer_ID = New DataColumn("Per_ID")

        'Dim cMonto As DataColumn
        'cMonto = New DataColumn("Monto")

        'Dim cMontoPagado As DataColumn
        'cMontoPagado = New DataColumn("MontoPagado")

        'Dim cMontoPendiente As DataColumn
        'cMontoPendiente = New DataColumn("MontoPendiente")

        Dim cMontoPagar As DataColumn
        cMontoPagar = New DataColumn("MontoPagar")

        'Dim cCurrent2 As DataColumn
        'cCurrent2 = New DataColumn("Current2", GetType(System.Boolean))
        tCust1.Columns.Add(cCodigo)
        tCust1.Columns.Add(cCuenta)
        tCust1.Columns.Add(cAgregar)
        tCust1.Columns.Add(cFecha)
        tCust1.Columns.Add(cProveedor)
        tCust1.Columns.Add(cFactura)
        tCust1.Columns.Add(cMontoPagar)
        tCust1.Columns.Add(cComp_No)
        tCust1.Columns.Add(cPer_ID)


        myDataSet.Tables.Add(tCust1)

        'Dim newRow1 As DataRow
        'Dim i As Integer
        'i = 0
        'Dim TotalMonto As Double
        'Dim TotalPagado As Double
        'Dim TotalPendiente As Double

        'TotalMonto = 0
        'TotalPagado = 0
        'TotalPendiente = 0

        'Me.dgArticulos.Size = New System.Drawing.Size(976, 24)

        'For i = 0 To ds.Tables("Facturas").Rows.Count - 1
        '    newRow1 = tCust.NewRow
        '    newRow1("Proveedor") = ds.Tables("Facturas").Rows(i).Item("Proveedor")
        '    tCust.Rows.Add(newRow1)

        '    tCust.Rows(i)("Detalle") = "Mostrar Detalles"
        '    tCust.Rows(i)("Fecha") = ds.Tables("Facturas").Rows(i).Item("Fecha")
        '    tCust.Rows(i)("Factura") = ds.Tables("Facturas").Rows(i).Item("Factura")
        '    tCust.Rows(i)("Monto") = CDbl(ds.Tables("Facturas").Rows(i).Item("Monto")).ToString(Round)
        '    tCust.Rows(i)("MontoPagado") = CDbl(ds.Tables("Facturas").Rows(i).Item("Monto Pagado")).ToString(Round)
        '    tCust.Rows(i)("MontoPendiente") = CDbl(ds.Tables("Facturas").Rows(i).Item("Monto Pendiente")).ToString(Round)
        '    tCust.Rows(i)("MontoPagar") = ""
        '    tCust.Rows(i)("Agregar") = False
        '    TotalMonto = TotalMonto + CDbl(ds.Tables("Facturas").Rows(i).Item("Monto"))
        '    TotalPagado = TotalPagado + CDbl(ds.Tables("Facturas").Rows(i).Item("Monto Pagado"))
        '    TotalPendiente = TotalPendiente + CDbl(ds.Tables("Facturas").Rows(i).Item("Monto Pendiente"))
        '    'Me.dgArticulos.Size.Width = Me.dgArticulos.Size.Width + 24
        '    Me.dgArticulos.Size = New System.Drawing.Size(976, Me.dgArticulos.Size.Height + 24)
        'Next

        'If ds.Tables("Facturas").Rows.Count > 0 Then
        '    Me.dgArticulos.Size = New System.Drawing.Size(976, Me.dgArticulos.Size.Height + 36)

        '    If Me.dgArticulos.Size.Height > 368 Then
        '        Me.dgArticulos.Size = New System.Drawing.Size(976, 368)
        '    End If
        'End If

        ''Me.cmdPagar.Location = New System.Drawing.Point(16, 384)

        'Me.cmdPagar.Location = New System.Drawing.Point(Me.cmdPagar.Location.X, Me.dgArticulos.Size.Height + 16)
        'Me.cmdSalir.Location = New System.Drawing.Point(Me.cmdSalir.Location.X, Me.dgArticulos.Size.Height + 16)
        'Me.etTotales.Location = New System.Drawing.Point(Me.etTotales.Location.X, Me.dgArticulos.Size.Height + 16)
        'Me.etTotalMonto.Location = New System.Drawing.Point(Me.etTotalMonto.Location.X, Me.dgArticulos.Size.Height + 16)
        'Me.etTotalPagado.Location = New System.Drawing.Point(Me.etTotalPagado.Location.X, Me.dgArticulos.Size.Height + 16)
        'Me.etTotalPendiente.Location = New System.Drawing.Point(Me.etTotalPendiente.Location.X, Me.dgArticulos.Size.Height + 16)
        'Me.etTotalPagar.Location = New System.Drawing.Point(Me.etTotalPagar.Location.X, Me.dgArticulos.Size.Height + 16)

        'myDataSet.Tables("Item").DefaultView.AllowDelete = False

        'Me.etTotalMonto.Text = TotalMonto.ToString(Round)
        'Me.etTotalPagado.Text = TotalPagado.ToString(Round)
        'Me.etTotalPendiente.Text = TotalPendiente.ToString(Round)
        ''myDataSet.Tables("EastCoastSales").DefaultView.AllowNew = False
    End Sub

    Public Sub AddCustomDataTableStyle1()

        'STEP 1: Create a DataTable style object and set properties if required.
        Dim ts1 As DataGridTableStyle
        ts1 = New DataGridTableStyle()
        'specify the table from dataset (required step)
        ts1.MappingName = "Item1"
        ' Set other properties (optional step)
        ts1.AlternatingBackColor = Color.LightBlue
        Dim colCount As Integer
        colCount = 0

        'STEP 4: Add the checkbox
        Dim boolCol As DataGridCheckBoxChangeEvent.MyDataGridBoolColumn
        boolCol = New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn(colCount)
        boolCol.MappingName = "Agregar"
        boolCol.HeaderText = "Pagar"
        boolCol.Alignment = HorizontalAlignment.Center
        'uncomment this line to get a two-state checkbox
        CType(boolCol, DataGridBoolColumn).AllowNull = False
        boolCol.Width = 50
        boolCol.ReadOnly = False
        boolCol.NullText = ""
        AddHandler boolCol.BoolValueChanged, New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn.BoolValueChangedEventHandler(AddressOf HandleBoolChanges)
        ts1.GridColumnStyles.Add(boolCol)
        colCount = (colCount + 1)

        Dim Fecha As DataGridTextBoxColumn
        Fecha = New DataGridTextBoxColumn()
        Fecha.MappingName = "Fecha"
        Fecha.HeaderText = "Fecha"
        Fecha.Width = 85
        Fecha.ReadOnly = True
        Fecha.Format = "dd/MM/yyyy"
        ts1.GridColumnStyles.Add(Fecha)
        colCount = (colCount + 1)
        Fecha.NullText = ""


        Dim Proveedor As DataGridColumnStyle
        Proveedor = New DataGridTextBoxColumn()
        Proveedor.MappingName = "Proveedor"
        Proveedor.HeaderText = "Proveedor"
        Proveedor.Width = 300
        Proveedor.ReadOnly = True
        ts1.GridColumnStyles.Add(Proveedor)
        colCount = (colCount + 1)
        Proveedor.NullText = ""

        Dim Factura As DataGridColumnStyle
        Factura = New DataGridTextBoxColumn()
        Factura.MappingName = "Factura"
        Factura.HeaderText = "Factura"
        Factura.Width = 75
        Factura.ReadOnly = True
        Factura.Alignment = HorizontalAlignment.Left
        ts1.GridColumnStyles.Add(Factura)
        colCount = (colCount + 1)
        Factura.NullText = ""

        Dim Codigo As DataGridColumnStyle
        Codigo = New DataGridTextBoxColumn()
        Codigo.MappingName = "Codigo"
        Codigo.HeaderText = "Codigo"
        Codigo.Width = 100
        Codigo.ReadOnly = True
        Codigo.Alignment = HorizontalAlignment.Right
        ts1.GridColumnStyles.Add(Codigo)
        colCount = (colCount + 1)
        Codigo.NullText = ""

        Dim Cuenta As DataGridColumnStyle
        Cuenta = New DataGridTextBoxColumn()
        Cuenta.MappingName = "Cuenta"
        Cuenta.HeaderText = "Cuenta"
        Cuenta.Width = 100
        Cuenta.ReadOnly = True
        Cuenta.Alignment = HorizontalAlignment.Right
        ts1.GridColumnStyles.Add(Cuenta)
        colCount = (colCount + 1)
        Cuenta.NullText = ""

        Dim Comp_No As DataGridColumnStyle
        Comp_No = New DataGridTextBoxColumn()
        Comp_No.MappingName = "Comp_No"
        Comp_No.HeaderText = "Comp_No"
        Comp_No.Width = 100
        Comp_No.ReadOnly = True
        Comp_No.Alignment = HorizontalAlignment.Right
        ts1.GridColumnStyles.Add(Comp_No)
        colCount = (colCount + 1)
        Comp_No.NullText = ""

        Dim Per_ID As DataGridColumnStyle
        Per_ID = New DataGridTextBoxColumn()
        Per_ID.MappingName = "Per_ID"
        Per_ID.HeaderText = "Per_ID"
        Per_ID.Width = 100
        Per_ID.ReadOnly = True
        Per_ID.Alignment = HorizontalAlignment.Right
        ts1.GridColumnStyles.Add(Per_ID)
        colCount = (colCount + 1)
        Per_ID.NullText = ""

        'Dim Monto As DataGridColumnStyle
        'Monto = New DataGridTextBoxColumn()
        'Monto.MappingName = "Monto"
        'Monto.HeaderText = "Monto"
        'Monto.Width = 100
        'Monto.ReadOnly = True
        'Monto.Alignment = HorizontalAlignment.Right
        'ts1.GridColumnStyles.Add(Monto)
        'colCount = (colCount + 1)
        'Monto.NullText = "0.00"

        'Dim MontoPagado As DataGridColumnStyle
        'MontoPagado = New DataGridTextBoxColumn()
        'MontoPagado.MappingName = "MontoPagado"
        'MontoPagado.HeaderText = "Monto Pagado"
        'MontoPagado.Width = 100
        'MontoPagado.ReadOnly = True
        'MontoPagado.Alignment = HorizontalAlignment.Right
        'ts1.GridColumnStyles.Add(MontoPagado)
        'colCount = (colCount + 1)
        'MontoPagado.NullText = ""

        'Dim MontoPendiente As DataGridColumnStyle
        'MontoPendiente = New DataGridTextBoxColumn()
        'MontoPendiente.MappingName = "MontoPendiente"
        'MontoPendiente.HeaderText = "Monto Pendiente"
        'MontoPendiente.Width = 100
        'MontoPendiente.ReadOnly = True
        'MontoPendiente.Alignment = HorizontalAlignment.Right
        'ts1.GridColumnStyles.Add(MontoPendiente)
        'colCount = (colCount + 1)
        'MontoPendiente.NullText = ""

        Dim MontoPagar As New DataGridTextBoxColumn()
        MontoPagar.MappingName = "MontoPagar"
        MontoPagar.HeaderText = "Monto a Pagar"
        MontoPagar.ReadOnly = False
        MontoPagar.Alignment = HorizontalAlignment.Right
        MontoPagar.Width = 100
        MontoPagar.NullText = ""
        ts1.GridColumnStyles.Add(MontoPagar)
        colCount = (colCount + 1)

    End Sub

    Dim p As Integer

    Private Sub AgregarItemTemporal()
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer

        Dim c As Integer
        c = 0

        For k = 0 To tCust.Rows.Count - 1
            If tCust.Rows(k)("Agregar") = True Then
                c = 1
                Exit For
            End If
        Next

        'If c = 0 Then
        '    MsgBox("Seleccione al menos una Factura", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        n = 0

        For i = 0 To tCust.Rows.Count - 1
            If tCust.Rows(i)("Agregar") = True Then
                For j = 0 To tCust1.Rows.Count - 1
                    If tCust.Rows(i)("Proveedor") = tCust1.Rows(j)("Proveedor") Then
                        tCust.Rows(i)("Numero") = j
                        tCust1.Rows(j)("MontoPagar") = CDbl(tCust1.Rows(j)("MontoPagar")) + CDbl(tCust.Rows(i)("MontoPagar"))
                        Exit For
                    End If
                    'If tCust.Rows(i)("Codigo") = tCust1.Rows(j)("Codigo") Then
                    '    Exit For
                    'End If
                Next

                If j = tCust1.Rows.Count Then
                    Dim newRow1 As DataRow
                    newRow1 = tCust1.NewRow

                    'newRow1("Codigo") = tCust.Rows(i)("Codigo")
                    newRow1("Codigo") = ds.Tables("Facturas").Rows(i).Item("Codigo")
                    ' Add the row to the Customers table.
                    tCust1.Rows.Add(newRow1)

                    tCust1.Rows(n)("Proveedor") = tCust.Rows(i)("Proveedor")
                    tCust1.Rows(n)("Fecha") = tCust.Rows(i)("Fecha")
                    'tCust1.Rows(n)("Monto") = tCust.Rows(i)("Monto")
                    'tCust1.Rows(n)("MontoPagado") = tCust.Rows(i)("MontoPagado")
                    'tCust1.Rows(n)("MontoPendiente") = tCust.Rows(i)("MontoPendiente")
                    tCust1.Rows(n)("MontoPagar") = tCust.Rows(i)("MontoPagar")
                    tCust1.Rows(n)("Comp_No") = ds.Tables("Facturas").Rows(i).Item("Comp_No")
                    tCust1.Rows(n)("Per_ID") = ds.Tables("Facturas").Rows(i).Item("Per_ID")
                    tCust1.Rows(n)("Cuenta") = ds.Tables("Facturas").Rows(i).Item("Cuenta")

                    'newRow1 = tCust.NewRow
                    'newRow1("Proveedor") = ds.Tables("Facturas").Rows(i).Item("Proveedor")
                    'tCust.Rows.Add(newRow1)

                    'tCust.Rows(i)("Fecha") = ds.Tables("Facturas").Rows(i).Item("Fecha")
                    'tCust.Rows(i)("Factura") = ds.Tables("Facturas").Rows(i).Item("Factura")
                    'tCust.Rows(i)("Monto") = CDbl(ds.Tables("Facturas").Rows(i).Item("Monto")).ToString(Round)
                    'tCust.Rows(i)("MontoPagado") = CDbl(ds.Tables("Facturas").Rows(i).Item("Monto Pagado")).ToString(Round)
                    'tCust.Rows(i)("MontoPendiente") = CDbl(ds.Tables("Facturas").Rows(i).Item("Monto Pendiente")).ToString(Round)
                    'tCust.Rows(i)("MontoPagar") = ""
                    'tCust.Rows(i)("Agregar") = False

                    n = n + 1
                End If
            Else

            End If

        Next

        For i = 0 To tCust.Rows.Count - 1
            For j = 0 To tCust1.Rows.Count - 1
                If tCust.Rows(i)("Proveedor") = tCust1.Rows(j)("Proveedor") Then
                    tCust.Rows(i)("Numero") = j
                    'tCust1.Rows(j)("MontoPagar") = CDbl(tCust1.Rows(j)("MontoPagar")) + CDbl(tCust.Rows(i)("MontoPagar"))
                    'Exit For
                End If
            Next
        Next

    End Sub

    Private Sub dgArticulos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgArticulos.DoubleClick
        Dim f As DataGridTextBoxCombo.frmFacturaProveedorEditar = f.Instance
        f.Comp = ds.Tables("Facturas").Rows(Me.dgArticulos.CurrentRowIndex).Item("Comp_No") ' Me.dgEstadoCuenta.Item(Me.dgEstadoCuenta.CurrentRowIndex, 6)
        f.Per = ds.Tables("Facturas").Rows(Me.dgArticulos.CurrentRowIndex).Item("Per_ID")
        f.Fecha = ds.Tables("Facturas").Rows(Me.dgArticulos.CurrentRowIndex).Item("Fecha")
        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub

    Private Sub cbProveedores_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbProveedores.SelectedValueChanged
        If Me.etInicio.Text = "1" Then
            Exit Sub
        End If
        Buscar()
    End Sub

    Public Sub Buscar()
        ds = Proveedores.FacturasComprobantes(Me.cbProveedores.SelectedValue.ToString)

        If ds.Tables("Facturas").Rows.Count > 0 Then
            Me.etTotales.Visible = True
            Me.etTotalMonto.Visible = True
            Me.etTotalPagado.Visible = True
            Me.etTotalPendiente.Visible = True
            Me.etTotalPagar.Visible = True
        End If

        dgArticulos.ReadOnly = False

        Me.Text = "Pagar Facturas"

        MakeDataSet()
        dgArticulos.SetDataBinding(myDataSet, "Item")
        AddCustomDataTableStyle()


        MakeDataSet1()
        'dgArticulos.SetDataBinding(myDataSet, "Item")
        AddCustomDataTableStyle1()

        If ds.Tables("Facturas").Rows.Count = 0 Then
            Me.dgArticulos.CaptionText = "No hay facturas."
            Me.dgArticulos.CaptionVisible = True
            'me.dgArticulos.ca
        End If
    End Sub

End Class
