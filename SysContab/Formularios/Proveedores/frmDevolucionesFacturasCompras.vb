Public Class frmDevolucionesFacturasCompras
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmDevolucionesFacturasCompras = Nothing

    Public Shared Function Instance() As frmDevolucionesFacturasCompras
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmDevolucionesFacturasCompras()
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
    Friend WithEvents cbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cBoxFecha As System.Windows.Forms.CheckBox
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents dgFacturas As System.Windows.Forms.DataGrid
    Friend WithEvents etInicio As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbMeses As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents cmdDevolucion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdVerDevoluciones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalida As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dtpFecha1 As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label24 = New System.Windows.Forms.Label
        Me.cbProveedor = New System.Windows.Forms.ComboBox
        Me.dgFacturas = New System.Windows.Forms.DataGrid
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.cBoxFecha = New System.Windows.Forms.CheckBox
        Me.cmdSalida = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdVerDevoluciones = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDevolucion = New DevExpress.XtraEditors.SimpleButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbTipo = New System.Windows.Forms.ComboBox
        Me.etInicio = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbMeses = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbOrigen = New System.Windows.Forms.ComboBox
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(8, 9)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(88, 25)
        Me.Label24.TabIndex = 147
        Me.Label24.Text = "Proveedor:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbProveedor
        '
        Me.cbProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedor.Location = New System.Drawing.Point(104, 9)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Size = New System.Drawing.Size(312, 21)
        Me.cbProveedor.TabIndex = 146
        '
        'dgFacturas
        '
        Me.dgFacturas.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgFacturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.dgFacturas.Location = New System.Drawing.Point(11, 72)
        Me.dgFacturas.Name = "dgFacturas"
        Me.dgFacturas.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgFacturas.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgFacturas.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgFacturas.SelectionForeColor = System.Drawing.Color.White
        Me.dgFacturas.Size = New System.Drawing.Size(925, 165)
        Me.dgFacturas.TabIndex = 26
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(840, 9)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha.TabIndex = 154
        '
        'cBoxFecha
        '
        Me.cBoxFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBoxFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cBoxFecha.Location = New System.Drawing.Point(728, 9)
        Me.cBoxFecha.Name = "cBoxFecha"
        Me.cBoxFecha.Size = New System.Drawing.Size(104, 25)
        Me.cBoxFecha.TabIndex = 153
        Me.cBoxFecha.Text = "Por Fecha:"
        Me.cBoxFecha.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'cmdSalida
        '
        Me.cmdSalida.Enabled = False
        Me.cmdSalida.Location = New System.Drawing.Point(198, 6)
        Me.cmdSalida.Name = "cmdSalida"
        Me.cmdSalida.Size = New System.Drawing.Size(101, 35)
        Me.cmdSalida.TabIndex = 9
        Me.cmdSalida.Text = "&Registrar Salida"
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.Location = New System.Drawing.Point(305, 6)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(80, 35)
        Me.cmdAyuda.TabIndex = 8
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(391, 6)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(80, 35)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdVerDevoluciones
        '
        Me.cmdVerDevoluciones.Enabled = False
        Me.cmdVerDevoluciones.Location = New System.Drawing.Point(97, 6)
        Me.cmdVerDevoluciones.Name = "cmdVerDevoluciones"
        Me.cmdVerDevoluciones.Size = New System.Drawing.Size(95, 35)
        Me.cmdVerDevoluciones.TabIndex = 2
        Me.cmdVerDevoluciones.Text = "&Ver Devoluciones"
        '
        'cmdDevolucion
        '
        Me.cmdDevolucion.Enabled = False
        Me.cmdDevolucion.Location = New System.Drawing.Point(11, 6)
        Me.cmdDevolucion.Name = "cmdDevolucion"
        Me.cmdDevolucion.Size = New System.Drawing.Size(80, 35)
        Me.cmdDevolucion.TabIndex = 1
        Me.cmdDevolucion.Text = "&Devolución"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(40, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 26)
        Me.Label2.TabIndex = 159
        Me.Label2.Text = "Tipo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbTipo
        '
        Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipo.Location = New System.Drawing.Point(104, 43)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(312, 21)
        Me.cbTipo.TabIndex = 158
        '
        'etInicio
        '
        Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etInicio.Location = New System.Drawing.Point(811, 139)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(32, 26)
        Me.etInicio.TabIndex = 160
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(432, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 25)
        Me.Label3.TabIndex = 162
        Me.Label3.Text = "Mes:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbMeses
        '
        Me.cbMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMeses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMeses.Items.AddRange(New Object() {"Todos", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cbMeses.Location = New System.Drawing.Point(496, 9)
        Me.cbMeses.Name = "cbMeses"
        Me.cbMeses.Size = New System.Drawing.Size(224, 23)
        Me.cbMeses.TabIndex = 161
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(424, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 26)
        Me.Label4.TabIndex = 164
        Me.Label4.Text = "Origen:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbOrigen
        '
        Me.cbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOrigen.Items.AddRange(New Object() {"--Todas--", "1 - U", "2 - S"})
        Me.cbOrigen.Location = New System.Drawing.Point(496, 43)
        Me.cbOrigen.Name = "cbOrigen"
        Me.cbOrigen.Size = New System.Drawing.Size(224, 21)
        Me.cbOrigen.TabIndex = 163
        '
        'dtpFecha1
        '
        Me.dtpFecha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha1.Location = New System.Drawing.Point(840, 43)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha1.TabIndex = 165
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdSalida)
        Me.PanelControl1.Controls.Add(Me.cmdVerDevoluciones)
        Me.PanelControl1.Controls.Add(Me.cmdAyuda)
        Me.PanelControl1.Controls.Add(Me.cmdDevolucion)
        Me.PanelControl1.Controls.Add(Me.cmdSalir)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 243)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(943, 53)
        Me.PanelControl1.TabIndex = 166
        '
        'frmDevolucionesFacturasCompras
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(943, 296)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.dgFacturas)
        Me.Controls.Add(Me.dtpFecha1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbOrigen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbMeses)
        Me.Controls.Add(Me.etInicio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbTipo)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.cBoxFecha)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.cbProveedor)
        Me.Name = "frmDevolucionesFacturasCompras"
        CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Proveedores As New VB.SysContab.ProveedoresDB()
    Dim FormaPago As New VB.SysContab.Forma_PagoDB()
    Public Facturas As New VB.SysContab.Facturas_ComprasDB()
    Dim r As New VB.SysContab.Rutinas()
    Dim Tabla As DataTable
    Dim ds As DataSet
    Public Fecha As String
    Public Fecha1 As String

    Private Sub frmFacturasComprasList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(PanelControl1)
        r.FormularioColor(Me)

        Fecha = ""
        Fecha1 = ""

        Me.cbMeses.SelectedIndex = 0
        Me.cbOrigen.SelectedIndex = 0

        Me.dtpFecha.Value = r.Fecha
        Me.dtpFecha1.Value = r.Fecha

        Me.dtpFecha.Enabled = False
        Me.dtpFecha1.Enabled = False

        cbProveedor.DataSource = Proveedores.ProveedoresList(3).Tables("Proveedores")
        cbProveedor.ValueMember = "Codigo"
        cbProveedor.DisplayMember = "Nombre"

        cbTipo.DataSource = FormaPago.FormaPagoListAll().Tables("Forma_Pago")
        cbTipo.ValueMember = "Codigo"
        cbTipo.DisplayMember = "Nombre"

        ds = Facturas.DevolucionesProveedorFacturas(cbProveedor.SelectedValue, Fecha, Fecha1, 0, cbTipo.SelectedValue, Me.cbOrigen.SelectedIndex)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView

        Tabla = ds.Tables("Facturas_Compra")

        r.FormatGenerico(Me.dgFacturas, Tabla)
        r.ComboAutoComplete(Me.cbProveedor)

        Me.dgFacturas.CaptionText = "           Facturas de Compra"
        Me.dgFacturas.ReadOnly = True
        dtpFecha.Enabled = False
        Me.Text = "F a c t u r a s  d e  C o m p r a"

        Me.Refresh()
    End Sub

    Private Sub cbProveedor_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbProveedor.SelectedValueChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        'If IsNumeric(cbProveedor.SelectedValue) And IsNumeric(cbEstado.SelectedIndex) And IsNumeric(cbTipo.SelectedValue) Then
        ds = Facturas.DevolucionesProveedorFacturas(cbProveedor.SelectedValue, Fecha, Fecha1, Me.cbMeses.SelectedIndex, cbTipo.SelectedValue, Me.cbOrigen.SelectedIndex)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView
        'End If
    End Sub

    Private Sub cBoxFecha_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cBoxFecha.CheckedChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        'dtpFecha.Enabled = cBoxFecha.Checked

        If cBoxFecha.Checked = True Then
            cbMeses.SelectedIndex = 0
            Fecha = dtpFecha.Value.Date
            Fecha1 = dtpFecha1.Value.Date
            dtpFecha.Enabled = True
            dtpFecha1.Enabled = True
            cbMeses.Enabled = False
        Else
            dtpFecha.Enabled = False
            dtpFecha1.Enabled = False
            cbMeses.Enabled = True
            Fecha = ""
            Fecha1 = ""
        End If

        ds = Facturas.DevolucionesProveedorFacturas(cbProveedor.SelectedValue, Fecha, Fecha1, cbMeses.SelectedIndex, cbTipo.SelectedValue, Me.cbOrigen.SelectedIndex)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView
    End Sub

    Private Sub dtpFecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
        If Fecha = Nothing Then
            Exit Sub
        End If

        Fecha = dtpFecha.Value.Date
        ds = Facturas.DevolucionesProveedorFacturas(cbProveedor.SelectedValue, Fecha, Fecha1, cbMeses.SelectedIndex, cbTipo.SelectedValue, Me.cbOrigen.SelectedIndex)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView
    End Sub

    Private Sub dtpFecha1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha1.ValueChanged
        If Fecha1 = Nothing Then
            Exit Sub
        End If

        Fecha1 = dtpFecha1.Value.Date
        ds = Facturas.DevolucionesProveedorFacturas(cbProveedor.SelectedValue, Fecha, Fecha1, cbMeses.SelectedIndex, cbTipo.SelectedValue, Me.cbOrigen.SelectedIndex)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdDevolucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDevolucion.Click
        Dim TipoPedido As Integer

        If Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 0).ToString = "" Then
            MsgBox("Seleccione la Factura", MsgBoxStyle.Information)
            Exit Sub
        End If

        If dgFacturas.Item(dgFacturas.CurrentRowIndex, 10) = "I" Then
            TipoPedido = 2
        Else
            TipoPedido = 1
        End If

        If Facturas.FacturaCompraDetalleDevolucion(Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 0), Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 9), TipoPedido).Tables("Facturas_Compras").Rows.Count = 0 Then
            MsgBox("La Factura no tiene productos para devolución", MsgBoxStyle.Information)
            Exit Sub
        End If

        Me.etInicio.Text = "1"

        'If Clientes.FacturaDetalleDevolucion(dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 0)).Tables("Facturas_Ventas").Rows.Count = 0 Then
        '    MsgBox("La Factura no tiene productos para devolución", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        '''If Facturas.FacturaDetalleDevolucion(dgFacturas.Item(dgFacturas.CurrentRowIndex, 0)).Tables("Facturas_Compra").Rows.Count = 0 Then
        '''    MsgBox("La Factura no tiene productos para devolución", MsgBoxStyle.Information)
        '''    Exit Sub
        '''End If

        Dim f As DataGridTextBoxCombo.frmDevolucionProveedor = DataGridTextBoxCombo.frmDevolucionProveedor.Instance
        f.TipoPedido = TipoPedido
        f.txtFactura.Text = dgFacturas.Item(dgFacturas.CurrentRowIndex, 0)
        f.txtProveedor.Text = dgFacturas.Item(dgFacturas.CurrentRowIndex, 9)
        f.Bodega = dgFacturas.Item(dgFacturas.CurrentRowIndex, 11)

        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cbEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        'If IsNumeric(cbProveedor.SelectedValue) And IsNumeric(cbEstado.SelectedIndex) And IsNumeric(cbTipo.SelectedValue) Then
        ds = Facturas.DevolucionesProveedorFacturas(cbProveedor.SelectedValue, Fecha, Fecha1, cbMeses.SelectedIndex, cbTipo.SelectedValue, Me.cbOrigen.SelectedIndex)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView
        'End If
    End Sub

    Private Sub cbTipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTipo.SelectedIndexChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        'If IsNumeric(cbProveedor.SelectedValue) And IsNumeric(cbEstado.SelectedIndex) And IsNumeric(cbTipo.SelectedValue) Then
        ds = Facturas.DevolucionesProveedorFacturas(cbProveedor.SelectedValue, Fecha, Fecha1, cbMeses.SelectedIndex, cbTipo.SelectedValue, Me.cbOrigen.SelectedIndex)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView
        'End If
    End Sub

    Private Sub cbMeses_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMeses.SelectedIndexChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        'If IsNumeric(cbProveedor.SelectedValue) And IsNumeric(cbEstado.SelectedIndex) And IsNumeric(cbTipo.SelectedValue) Then
        ds = Facturas.DevolucionesProveedorFacturas(cbProveedor.SelectedValue, Fecha, Fecha1, cbMeses.SelectedIndex, cbTipo.SelectedValue, Me.cbOrigen.SelectedIndex)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView
        'End If
    End Sub

    Private Sub cbOrigen_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbOrigen.SelectedIndexChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        ds = Facturas.DevolucionesProveedorFacturas(cbProveedor.SelectedValue, Fecha, Fecha1, cbMeses.SelectedIndex, cbTipo.SelectedValue, Me.cbOrigen.SelectedIndex)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView
    End Sub

    Private Sub cmdVerDevoluciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVerDevoluciones.Click
        Me.etInicio.Text = "1"
        Dim f As frmDevolucionesProveedorList = f.Instance
        f.Proveedor = 0
        f.etInicio.Text = "1"
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "0"
    End Sub

    Private Sub cmdSalida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalida.Click
        Me.etInicio.Text = "1"
        Dim f As frmDevolucionesProveedorList = f.Instance
        f.Proveedor = 0
        f.etInicio.Text = "1"
        f.MdiParent = Me.MdiParent
        f.WindowState = FormWindowState.Maximized
        f.Show()
        f.etInicio.Text = "0"
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/ProvDevol.chm")
    End Sub

End Class
