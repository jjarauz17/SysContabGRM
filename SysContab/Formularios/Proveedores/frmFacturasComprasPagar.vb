Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmFacturasComprasPagar
    Inherits DevExpress.XtraEditors.XtraForm

    'Private Shared ChildInstance As frmFacturasComprasPagar = Nothing

    'Public Shared Function Instance() As frmFacturasComprasPagar
    '    If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
    '        ChildInstance = New frmFacturasComprasPagar()
    '    End If
    '    ChildInstance.BringToFront()

    '    Return ChildInstance
    'End Function

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
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cBoxFecha As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgFacturas As System.Windows.Forms.DataGrid
    Friend WithEvents etInicio As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbMeses As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents etProveedor As System.Windows.Forms.Label
    Friend WithEvents etAceptar As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cbProveedor = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgFacturas = New System.Windows.Forms.DataGrid()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cBoxFecha = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.etAceptar = New System.Windows.Forms.Label()
        Me.etProveedor = New System.Windows.Forms.Label()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.etInicio = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbMeses = New System.Windows.Forms.ComboBox()
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label24.Location = New System.Drawing.Point(8, 8)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(88, 24)
        Me.Label24.TabIndex = 147
        Me.Label24.Text = "Proveedor:"
        '
        'cbProveedor
        '
        Me.cbProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedor.Location = New System.Drawing.Point(96, 8)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Size = New System.Drawing.Size(320, 21)
        Me.cbProveedor.TabIndex = 146
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgFacturas})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(976, 408)
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
        Me.dgFacturas.Location = New System.Drawing.Point(8, 16)
        Me.dgFacturas.Name = "dgFacturas"
        Me.dgFacturas.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgFacturas.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgFacturas.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgFacturas.SelectionForeColor = System.Drawing.Color.White
        Me.dgFacturas.Size = New System.Drawing.Size(960, 384)
        Me.dgFacturas.TabIndex = 26
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFecha.Location = New System.Drawing.Point(784, 8)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha.TabIndex = 154
        '
        'cBoxFecha
        '
        Me.cBoxFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBoxFecha.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.cBoxFecha.Location = New System.Drawing.Point(680, 8)
        Me.cBoxFecha.Name = "cBoxFecha"
        Me.cBoxFecha.Size = New System.Drawing.Size(96, 24)
        Me.cBoxFecha.TabIndex = 153
        Me.cBoxFecha.Text = "Por Fecha:"
        Me.cBoxFecha.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.etAceptar, Me.etProveedor, Me.cmdSalir, Me.cmdAceptar})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 456)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(864, 56)
        Me.GroupBox2.TabIndex = 155
        Me.GroupBox2.TabStop = False
        '
        'etAceptar
        '
        Me.etAceptar.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.etAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etAceptar.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.etAceptar.Location = New System.Drawing.Point(388, 16)
        Me.etAceptar.Name = "etAceptar"
        Me.etAceptar.Size = New System.Drawing.Size(88, 24)
        Me.etAceptar.TabIndex = 161
        Me.etAceptar.Text = "Aceptar"
        Me.etAceptar.Visible = False
        '
        'etProveedor
        '
        Me.etProveedor.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.etProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etProveedor.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.etProveedor.Location = New System.Drawing.Point(568, 16)
        Me.etProveedor.Name = "etProveedor"
        Me.etProveedor.Size = New System.Drawing.Size(88, 24)
        Me.etProveedor.TabIndex = 160
        Me.etProveedor.Text = "Proveedor"
        Me.etProveedor.Visible = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(104, 16)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 32)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(8, 16)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 32)
        Me.cmdAceptar.TabIndex = 1
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'etInicio
        '
        Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.etInicio.Location = New System.Drawing.Point(896, 472)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(32, 24)
        Me.etInicio.TabIndex = 160
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label3.Location = New System.Drawing.Point(424, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 24)
        Me.Label3.TabIndex = 162
        Me.Label3.Text = "Mes:"
        '
        'cbMeses
        '
        Me.cbMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMeses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMeses.Items.AddRange(New Object() {"Todos", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cbMeses.Location = New System.Drawing.Point(488, 8)
        Me.cbMeses.Name = "cbMeses"
        Me.cbMeses.Size = New System.Drawing.Size(184, 23)
        Me.cbMeses.TabIndex = 161
        '
        'dtpFecha1
        '
        Me.dtpFecha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFecha1.Location = New System.Drawing.Point(888, 8)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha1.TabIndex = 167
        '
        'frmFacturasComprasPagar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(994, 526)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.dtpFecha1, Me.Label3, Me.cbMeses, Me.etInicio, Me.GroupBox2, Me.dtpFecha, Me.cBoxFecha, Me.GroupBox1, Me.Label24, Me.cbProveedor})
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmFacturasComprasPagar"
        Me.StartPosition = FormStartPosition.CenterScreen
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


    Private Sub frmFacturasComprasList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        r.FormularioColor(Me)

        Fecha = ""
        Fecha1 = ""

        Me.cbMeses.SelectedIndex = 0

        Me.dtpFecha.Value = r.Fecha
        Me.dtpFecha1.Value = r.Fecha
        Me.dtpFecha.Enabled = False
        Me.dtpFecha1.Enabled = False

        cbProveedor.DataSource = Proveedores.ProveedoresList(-1).Tables("Proveedores")
        cbProveedor.ValueMember = "Codigo"
        cbProveedor.DisplayMember = "Nombre"
        cbProveedor.SelectedValue = 0

        ds = Facturas.FacturasComprasPagar(Me.etProveedor.Text, Fecha, Fecha1, 0, 0, 0, 0, 0)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView

        Tabla = ds.Tables("Facturas_Compra")

        r.FormatGenerico(Me.dgFacturas, Tabla)
        r.ComboAutoComplete(Me.cbProveedor)

        Me.dgFacturas.CaptionText = "           Facturas de Compra"
        Me.dgFacturas.ReadOnly = True
        dtpFecha.Enabled = False
        Me.Text = "F a c t u r a s  d e  C o m p r a"

        Me.etInicio.Text = "0"
        Me.etAceptar.Text = "NO"

        cbProveedor.SelectedValue = Me.etProveedor.Text

        Me.Refresh()
    End Sub

    Private Sub cbProveedor_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbProveedor.SelectedValueChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        'If IsNumeric(cbProveedor.SelectedValue) And IsNumeric(cbEstado.SelectedIndex) And IsNumeric(cbTipo.SelectedValue) Then
        ds = Facturas.FacturasComprasPagar(cbProveedor.SelectedValue, Fecha, Fecha1, Me.cbMeses.SelectedIndex, 0, 0, 0, 0)
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

        ds = Facturas.FacturasComprasPagar(cbProveedor.SelectedValue, Fecha, Fecha1, cbMeses.SelectedIndex, 0, 0, 0, 0)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView
    End Sub

    Private Sub dtpFecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
        If Fecha = Nothing Then
            Exit Sub
        End If

        Fecha = dtpFecha.Value.Date
        ds = Facturas.FacturasComprasPagar(cbProveedor.SelectedValue, Fecha, Fecha1, cbMeses.SelectedIndex, 0, 0, 0, 0)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView
    End Sub

    Private Sub dtpFecha1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha1.ValueChanged
        If Fecha1 = Nothing Then
            Exit Sub
        End If

        Fecha1 = dtpFecha1.Value.Date
        ds = Facturas.FacturasComprasPagar(cbProveedor.SelectedValue, Fecha, Fecha1, cbMeses.SelectedIndex, 0, 0, 0, 0)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.etAceptar.Text = "NO"
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Me.dgFacturas.CurrentRowIndex = ds.Tables("Facturas_Compra").Rows.Count - 1 Then
            MsgBox("Seleccione una Factura", MsgBoxStyle.Information)
            Exit Sub
        End If

        If ds.Tables("Facturas_Compra").Rows.Count = 1 Then
            MsgBox("No hay ninguna factura Seleccionada", MsgBoxStyle.Information)
            Exit Sub
        End If
        Me.etAceptar.Text = "SI"
        Me.Close()
    End Sub

    Private Sub cbEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        'If IsNumeric(cbProveedor.SelectedValue) And IsNumeric(cbEstado.SelectedIndex) And IsNumeric(cbTipo.SelectedValue) Then
        ds = Facturas.FacturasComprasPagar(cbProveedor.SelectedValue, Fecha, Fecha1, cbMeses.SelectedIndex, 0, 0, 0, 0)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView
        'End If
    End Sub

    Private Sub cbTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        'If IsNumeric(cbProveedor.SelectedValue) And IsNumeric(cbEstado.SelectedIndex) And IsNumeric(cbTipo.SelectedValue) Then
        ds = Facturas.FacturasComprasPagar(cbProveedor.SelectedValue, Fecha, Fecha1, cbMeses.SelectedIndex, 0, 0, 0, 0)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView
        'End If
    End Sub

    Private Sub cbMeses_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMeses.SelectedIndexChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        'If IsNumeric(cbProveedor.SelectedValue) And IsNumeric(cbEstado.SelectedIndex) And IsNumeric(cbTipo.SelectedValue) Then
        ds = Facturas.FacturasComprasPagar(cbProveedor.SelectedValue, Fecha, Fecha1, cbMeses.SelectedIndex, 0, 0, 0, 0)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView
        'End If
    End Sub

    Private Sub cbOrigen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        ds = Facturas.FacturasComprasPagar(cbProveedor.SelectedValue, Fecha, Fecha1, cbMeses.SelectedIndex, 0, 0, 0, 0)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView
    End Sub

End Class
