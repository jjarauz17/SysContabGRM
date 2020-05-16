Public Class frmFacturasComprasEntrada
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmFacturasComprasEntrada = Nothing

    Public Shared Function Instance() As frmFacturasComprasEntrada
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmFacturasComprasEntrada()
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cBoxFecha As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents cmdEntradaAlmacen As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgFacturas As System.Windows.Forms.DataGrid
    Friend WithEvents etInicio As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbMeses As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents cmdRegistradasAlmacen As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtpFecha1 As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label24 = New System.Windows.Forms.Label
        Me.cbProveedor = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgFacturas = New System.Windows.Forms.DataGrid
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.cBoxFecha = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdRegistradasAlmacen = New DevExpress.XtraEditors.SimpleButton
        Me.cmdEntradaAlmacen = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbTipo = New System.Windows.Forms.ComboBox
        Me.etInicio = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbMeses = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbOrigen = New System.Windows.Forms.ComboBox
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgFacturas)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 390)
        Me.GroupBox1.TabIndex = 148
        Me.GroupBox1.TabStop = False
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
        Me.dgFacturas.Location = New System.Drawing.Point(8, 17)
        Me.dgFacturas.Name = "dgFacturas"
        Me.dgFacturas.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgFacturas.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgFacturas.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgFacturas.SelectionForeColor = System.Drawing.Color.White
        Me.dgFacturas.Size = New System.Drawing.Size(984, 365)
        Me.dgFacturas.TabIndex = 26
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(848, 9)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha.TabIndex = 154
        '
        'cBoxFecha
        '
        Me.cBoxFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBoxFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cBoxFecha.Location = New System.Drawing.Point(736, 9)
        Me.cBoxFecha.Name = "cBoxFecha"
        Me.cBoxFecha.Size = New System.Drawing.Size(104, 25)
        Me.cBoxFecha.TabIndex = 153
        Me.cBoxFecha.Text = "Por Fecha:"
        Me.cBoxFecha.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdRegistradasAlmacen)
        Me.GroupBox2.Controls.Add(Me.cmdEntradaAlmacen)
        Me.GroupBox2.Controls.Add(Me.cmdAyuda)
        Me.GroupBox2.Controls.Add(Me.cmdSalir)
        Me.GroupBox2.Controls.Add(Me.cmdImprimir)
        Me.GroupBox2.Controls.Add(Me.cmdBorrar)
        Me.GroupBox2.Controls.Add(Me.cmdModificar)
        Me.GroupBox2.Controls.Add(Me.cmdNuevo)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 462)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(674, 60)
        Me.GroupBox2.TabIndex = 155
        Me.GroupBox2.TabStop = False
        '
        'cmdRegistradasAlmacen
        '
        Me.cmdRegistradasAlmacen.Appearance.Options.UseTextOptions = True
        Me.cmdRegistradasAlmacen.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdRegistradasAlmacen.Location = New System.Drawing.Point(174, 17)
        Me.cmdRegistradasAlmacen.Name = "cmdRegistradasAlmacen"
        Me.cmdRegistradasAlmacen.Size = New System.Drawing.Size(80, 35)
        Me.cmdRegistradasAlmacen.TabIndex = 11
        Me.cmdRegistradasAlmacen.Text = "Registradas en Almacen"
        '
        'cmdEntradaAlmacen
        '
        Me.cmdEntradaAlmacen.Appearance.Options.UseTextOptions = True
        Me.cmdEntradaAlmacen.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdEntradaAlmacen.Location = New System.Drawing.Point(260, 17)
        Me.cmdEntradaAlmacen.Name = "cmdEntradaAlmacen"
        Me.cmdEntradaAlmacen.Size = New System.Drawing.Size(72, 35)
        Me.cmdEntradaAlmacen.TabIndex = 10
        Me.cmdEntradaAlmacen.Text = "Registro de &Entrada"
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Location = New System.Drawing.Point(497, 17)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 35)
        Me.cmdAyuda.TabIndex = 8
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(575, 17)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 35)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(338, 17)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 35)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Reportes"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(419, 17)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 35)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "&Borrar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(96, 17)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(72, 35)
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "&Ver Factura"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(18, 17)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(72, 35)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "&Nuevo"
        Me.cmdNuevo.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(48, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 26)
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
        Me.etInicio.Location = New System.Drawing.Point(864, 508)
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
        Me.Label4.BackColor = System.Drawing.Color.Transparent
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
        Me.dtpFecha1.Location = New System.Drawing.Point(848, 43)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha1.TabIndex = 168
        '
        'frmFacturasComprasEntrada
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 526)
        Me.Controls.Add(Me.dtpFecha1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbOrigen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbMeses)
        Me.Controls.Add(Me.etInicio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbTipo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.cBoxFecha)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.cbProveedor)
        Me.Name = "frmFacturasComprasEntrada"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
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

    Public Destino As String

    Private Sub frmFacturasComprasList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        r.FormularioColor(Me)

        Fecha = ""
        Fecha1 = ""

        Me.cbMeses.SelectedIndex = 0
        Me.cbOrigen.SelectedIndex = 0

        Me.dtpFecha.Value = r.Fecha
        Me.dtpFecha1.Value = r.Fecha
        Me.dtpFecha.Enabled = False
        Me.dtpFecha1.Enabled = False

        cbProveedor.DataSource = Proveedores.ProveedoresList(4).Tables("Proveedores")
        cbProveedor.ValueMember = "Codigo"
        cbProveedor.DisplayMember = "Nombre"

        cbTipo.DataSource = FormaPago.FormaPagoListAll().Tables("Forma_Pago")
        cbTipo.ValueMember = "Codigo"
        cbTipo.DisplayMember = "Nombre"

        ds = Facturas.FacturasCompraLista(cbProveedor.SelectedValue, Fecha, Fecha1, 0, 1, cbTipo.SelectedValue, 0, Me.cbOrigen.SelectedIndex, Destino)
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
        ds = Facturas.FacturasCompraLista(cbProveedor.SelectedValue, Fecha, Fecha1, Me.cbMeses.SelectedIndex, 1, cbTipo.SelectedValue, 0, Me.cbOrigen.SelectedIndex, Destino)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView
        'End If
    End Sub

    Private Sub cBoxFecha_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cBoxFecha.CheckedChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

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

        ds = Facturas.FacturasCompraLista(cbProveedor.SelectedValue, Fecha, Fecha1, cbMeses.SelectedIndex, 1, cbTipo.SelectedValue, 0, Me.cbOrigen.SelectedIndex, Destino)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView
    End Sub

    Private Sub dtpFecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
        If Fecha = Nothing Then
            Exit Sub
        End If

        Fecha = dtpFecha.Value.Date
        ds = Facturas.FacturasCompraLista(cbProveedor.SelectedValue, Fecha, Fecha1, cbMeses.SelectedIndex, 1, cbTipo.SelectedValue, 0, Me.cbOrigen.SelectedIndex, Destino)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView
    End Sub

    Private Sub dtpFecha1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha1.ValueChanged
        If Fecha1 = Nothing Then
            Exit Sub
        End If

        Fecha1 = dtpFecha1.Value.Date
        ds = Facturas.FacturasCompraLista(cbProveedor.SelectedValue, Fecha, Fecha1, cbMeses.SelectedIndex, 1, cbTipo.SelectedValue, 0, Me.cbOrigen.SelectedIndex, Destino)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        'Inicio = True

        'Dim f As DataGridTextBoxCombo.frmOrdenesCompra = f.Instance

        'f.MdiParent = Me.MdiParent
        'f.Show()
        'f.WindowState = FormWindowState.Maximized

        'Inicio = False

        Inicio = True
        Dim f As DataGridTextBoxCombo.frmEntradaAlmacen = f.Instance
        f.etInicio.Text = "1"
        'f.txtOrden.Text = dgOrdenes.Item(dgOrdenes.CurrentRowIndex, 0)
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "0"
        f.Nuevo = True
        Inicio = False
    End Sub

    Private Sub cbEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        'If IsNumeric(cbProveedor.SelectedValue) And IsNumeric(cbEstado.SelectedIndex) And IsNumeric(cbTipo.SelectedValue) Then
        ds = Facturas.FacturasCompraLista(cbProveedor.SelectedValue, Fecha, Fecha1, cbMeses.SelectedIndex, 1, cbTipo.SelectedValue, 0, Me.cbOrigen.SelectedIndex, Destino)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView
        'End If
    End Sub

    Private Sub cbTipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTipo.SelectedIndexChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        'If IsNumeric(cbProveedor.SelectedValue) And IsNumeric(cbEstado.SelectedIndex) And IsNumeric(cbTipo.SelectedValue) Then
        ds = Facturas.FacturasCompraLista(cbProveedor.SelectedValue, Fecha, Fecha1, cbMeses.SelectedIndex, 1, cbTipo.SelectedValue, 0, Me.cbOrigen.SelectedIndex, Destino)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView
        'End If
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim f As frmReportesFacturasCompras = f.Instance
        f.MdiParent = Me.MdiParent
        f.WindowState = FormWindowState.Maximized
        f.Show()
    End Sub

    Private Sub cmdEntradaAlmacen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEntradaAlmacen.Click
        If Me.dgFacturas.CurrentRowIndex = ds.Tables("Facturas_Compra").Rows.Count - 1 Then
            MsgBox("Seleccione una Factura", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 8) = "Facturada" Then
            MsgBox("La Factura ya fue Procesada", MsgBoxStyle.Information)
            Exit Sub
        End If

        Inicio = True
        Dim f As DataGridTextBoxCombo.frmEntradaAlmacen = f.Instance
        f.etInicio.Text = "1"
        f.txtFactura.Text = Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 0)
        f.txtProveedor.Text = Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 9)
        f.etDestino.Text = Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 10)

        If Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 11).ToString = "P" Then
            f.rbProductos.Checked = True
        ElseIf Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 11).ToString = "S" Then
            f.rbServicios.Checked = True
        ElseIf Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 11).ToString = "I" Then
            f.rbInventario.Checked = True
        End If

        'If f.etDestino.Text = "1" Then
        '    f.rbProductos.Checked = True
        'ElseIf f.etDestino.Text = "2" Then
        '    f.rbInventario.Checked = True
        'End If

        f.gbTipo.Enabled = False
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "0"
        f.Nuevo = False
        Inicio = False

        'Inicio = True
        'Dim f As DataGridTextBoxCombo.frmEntradaAlmacen = f.Instance
        'f.etInicio.Text = "1"
        'f.txtFactura.Text = Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 0)
        'f.txtProveedor.Text = Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 9)
        'f.MdiParent = Me.MdiParent
        'f.Show()
        'f.WindowState = FormWindowState.Maximized
        'f.etInicio.Text = "0"
        'f.Nuevo = False
        'Inicio = False
    End Sub

    Private Sub cbMeses_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMeses.SelectedIndexChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        'If IsNumeric(cbProveedor.SelectedValue) And IsNumeric(cbEstado.SelectedIndex) And IsNumeric(cbTipo.SelectedValue) Then
        ds = Facturas.FacturasCompraLista(cbProveedor.SelectedValue, Fecha, Fecha1, cbMeses.SelectedIndex, 1, cbTipo.SelectedValue, 0, Me.cbOrigen.SelectedIndex, Destino)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView
        'End If
    End Sub

    Private Sub cbOrigen_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbOrigen.SelectedIndexChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        ds = Facturas.FacturasCompraLista(cbProveedor.SelectedValue, Fecha, Fecha1, cbMeses.SelectedIndex, 1, cbTipo.SelectedValue, 0, Me.cbOrigen.SelectedIndex, Destino)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView
    End Sub

    Private Sub cbProveedor_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbProveedor.Leave
        If Trim(Me.cbProveedor.Text) = "" Or Me.cbProveedor.SelectedValue = Nothing Then
            Me.cbProveedor.SelectedValue = 0
        End If
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If Me.dgFacturas.CurrentRowIndex = ds.Tables("Facturas_Compra").Rows.Count - 1 Then
            MsgBox("Seleccione una Factura", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim f As DataGridTextBoxCombo.frmFacturasCompraVer = f.Instance

        f.txtFactura.Text = Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 0)
        f.txtProveedor.Text = Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 9)
        f.etDestino.Text = Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 10)
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cmdRegistradasAlmacen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRegistradasAlmacen.Click
        Dim f As frmFacturasComprasAlmacen = f.Instance
        f.etInicio.Text = "1"
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "0"
    End Sub

End Class
