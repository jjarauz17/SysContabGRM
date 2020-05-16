
Public Class frmNotasDebitoCliente
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmNotasDebitoCliente = Nothing

    Public Shared Function Instance() As frmNotasDebitoCliente
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmNotasDebitoCliente()
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents checkBoxFecha As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents etInicio As System.Windows.Forms.Label
    Friend WithEvents dtpFecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgNotasDebitos As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents etClienteNombre As System.Windows.Forms.Label
    Friend WithEvents etClienteCodigo As System.Windows.Forms.Label
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.dgNotasDebitos = New System.Windows.Forms.DataGrid
        Me.checkBoxFecha = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker
        Me.etInicio = New System.Windows.Forms.Label
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.etClienteNombre = New System.Windows.Forms.Label
        Me.etClienteCodigo = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgNotasDebitos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdAyuda)
        Me.GroupBox1.Controls.Add(Me.cmdImprimir)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 433)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(664, 60)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Location = New System.Drawing.Point(104, 17)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 35)
        Me.cmdAyuda.TabIndex = 10
        Me.cmdAyuda.Text = "Ayuda"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(8, 17)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 35)
        Me.cmdImprimir.TabIndex = 9
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(200, 17)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 35)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'dgNotasDebitos
        '
        Me.dgNotasDebitos.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgNotasDebitos.BackColor = System.Drawing.Color.Gainsboro
        Me.dgNotasDebitos.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgNotasDebitos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgNotasDebitos.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgNotasDebitos.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgNotasDebitos.CaptionForeColor = System.Drawing.Color.Black
        Me.dgNotasDebitos.DataMember = ""
        Me.dgNotasDebitos.FlatMode = True
        Me.dgNotasDebitos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgNotasDebitos.ForeColor = System.Drawing.Color.Black
        Me.dgNotasDebitos.GridLineColor = System.Drawing.Color.Silver
        Me.dgNotasDebitos.HeaderBackColor = System.Drawing.Color.Black
        Me.dgNotasDebitos.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgNotasDebitos.HeaderForeColor = System.Drawing.Color.White
        Me.dgNotasDebitos.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgNotasDebitos.Location = New System.Drawing.Point(8, 86)
        Me.dgNotasDebitos.Name = "dgNotasDebitos"
        Me.dgNotasDebitos.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgNotasDebitos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgNotasDebitos.ReadOnly = True
        Me.dgNotasDebitos.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgNotasDebitos.SelectionForeColor = System.Drawing.Color.White
        Me.dgNotasDebitos.Size = New System.Drawing.Size(1000, 341)
        Me.dgNotasDebitos.TabIndex = 8
        '
        'checkBoxFecha
        '
        Me.checkBoxFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBoxFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.checkBoxFecha.Location = New System.Drawing.Point(8, 52)
        Me.checkBoxFecha.Name = "checkBoxFecha"
        Me.checkBoxFecha.Size = New System.Drawing.Size(96, 26)
        Me.checkBoxFecha.TabIndex = 150
        Me.checkBoxFecha.Text = "Por Fecha:"
        Me.checkBoxFecha.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(112, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 26)
        Me.Label4.TabIndex = 151
        Me.Label4.Text = "Desde:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(280, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 26)
        Me.Label5.TabIndex = 153
        Me.Label5.Text = "Hasta:"
        '
        'dtpFecha1
        '
        Me.dtpFecha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha1.Location = New System.Drawing.Point(176, 52)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha1.TabIndex = 160
        Me.dtpFecha1.Value = New Date(2005, 12, 6, 8, 56, 2, 62)
        '
        'etInicio
        '
        Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etInicio.Location = New System.Drawing.Point(616, 517)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(32, 26)
        Me.etInicio.TabIndex = 158
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
        '
        'dtpFecha2
        '
        Me.dtpFecha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha2.Location = New System.Drawing.Point(344, 52)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha2.TabIndex = 154
        Me.dtpFecha2.Value = New Date(2005, 12, 6, 8, 56, 2, 62)
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.etClienteNombre)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 9)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1000, 34)
        Me.GroupBox3.TabIndex = 161
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 21)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "NOTAS DE CREDITOS POR CLIENTE:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'etClienteNombre
        '
        Me.etClienteNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etClienteNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etClienteNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etClienteNombre.Location = New System.Drawing.Point(232, 9)
        Me.etClienteNombre.Name = "etClienteNombre"
        Me.etClienteNombre.Size = New System.Drawing.Size(768, 21)
        Me.etClienteNombre.TabIndex = 113
        Me.etClienteNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'etClienteCodigo
        '
        Me.etClienteCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etClienteCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etClienteCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etClienteCodigo.Location = New System.Drawing.Point(480, 52)
        Me.etClienteCodigo.Name = "etClienteCodigo"
        Me.etClienteCodigo.Size = New System.Drawing.Size(124, 21)
        Me.etClienteCodigo.TabIndex = 162
        Me.etClienteCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etClienteCodigo.Visible = False
        '
        'frmNotasDebitoCliente
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 518)
        Me.Controls.Add(Me.etClienteCodigo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dtpFecha1)
        Me.Controls.Add(Me.etInicio)
        Me.Controls.Add(Me.dtpFecha2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.checkBoxFecha)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgNotasDebitos)
        Me.Name = "frmNotasDebitoCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgNotasDebitos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Clientes As New VB.SysContab.ClientesDB()
    Public ClientesDetalle As New VB.SysContab.ClientesDetails()
    'Dim Cajas As New VB.SysContab.CajasDB()
    'Dim FormaPago As New VB.SysContab.Forma_PagoDB()
    Dim r As New VB.SysContab.Rutinas()
    Dim ds As DataSet

    'Dim Devoluciones As New VB.SysContab.DevolucionesClienteDB()
    'Dim DevolucionBodega As New VB.SysContab.DevolucionesClienteBodegaDB()
    Dim Fecha1 As String
    Dim Fecha2 As String

    Private Sub frmListaFacturaClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Tabla As DataTable

        Dim dsFormaPago As DataSet
        Dim i As Integer

        ''r.CambiarEstilo(Me)
        r.FormularioColor(Me)
        Me.Label1.BackColor = Color.FromArgb(102, 153, 153)
        Me.etClienteNombre.BackColor = Color.FromArgb(102, 153, 153)

        dtpFecha1.Enabled = False
        dtpFecha2.Enabled = False

        dtpFecha1.Value = r.Fecha
        dtpFecha2.Value = r.Fecha

        Fecha1 = ""
        Fecha2 = ""

        ClientesDetalle = VB.SysContab.ClientesDB.GetDetails(Me.etClienteCodigo.Text)
        Me.etClienteNombre.Text = ClientesDetalle.Nombre

        ds = Clientes.NotasDebitoXCliente(Me.etClienteCodigo.Text, Fecha1, Fecha2)

        Me.dgNotasDebitos.DataSource = ds.Tables("Cobros").DefaultView
        Tabla = ds.Tables("Cobros")

        r.FormatGenerico(Me.dgNotasDebitos, Tabla)

        Me.dgNotasDebitos.CaptionText = "          Notas de Crédito de Clientes"

        Me.Text = "Notas de Crédito de Clientes"
        Me.Refresh()

    End Sub

    'Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
    '    Dim f As DataGridTextBoxCombo.frmFacturacionCliente = f.Instance

    '    f.etCaja.Text = Cajas.PcNombre(Environment.MachineName.ToString).Tables("Cajas").Rows(0).Item("cj_Codigo").ToString

    '    NuevaFactura = "SI"

    '    f.MdiParent = Me.MdiParent
    '    f.WindowState = FormWindowState.Maximized
    '    f.Show()

    'End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub frmListaFacturaClientes_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter


    End Sub

    Private Sub dgFacturasClientes_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgNotasDebitos.MouseEnter

    End Sub

    'Private Sub cbTipoFactura_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTipoFactura.SelectedValueChanged
    '    Try
    '        If IsNumeric(cbTipoFactura.SelectedValue) And cbTipoFactura.Enabled = True Then
    '            dgFacturasClientes.DataSource = Clientes.FacturasXTipo(txtBuscar.Text, cbTipoFactura.SelectedValue.ToString, cbMeses.SelectedIndex).Tables("Facturas_Ventas").DefaultView
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Sub cbTipo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipo.CheckedChanged
    '    If cbTipo.Checked = True Then
    '        dgFacturasClientes.DataSource = Clientes.FacturasXTipo(txtBuscar.Text, cbTipoFactura.SelectedValue.ToString, cbMeses.SelectedIndex).Tables("Facturas_Ventas").DefaultView
    '        cbTipoFactura.Enabled = True
    '    Else
    '        cbTipoFactura.Enabled = False
    '        dgFacturasClientes.DataSource = Clientes.ListFacturas("").Tables("Facturas_Ventas").DefaultView
    '    End If
    'End Sub


    Private Sub checkBoxFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkBoxFecha.CheckedChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        Try
            If checkBoxFecha.Checked = True Then
                dtpFecha1.Enabled = True
                dtpFecha2.Enabled = True
                Fecha1 = dtpFecha1.Value.Date
                Fecha2 = dtpFecha2.Value.Date
                dtpFecha2.MinDate = Me.dtpFecha1.Value
            Else
                dtpFecha1.Enabled = False
                dtpFecha2.Enabled = False
                Fecha1 = ""
                Fecha2 = ""

            End If
            ds = Clientes.NotasDebitoXCliente(Me.etClienteCodigo.Text, Fecha1, Fecha2)
            Me.dgNotasDebitos.DataSource = ds.Tables("Cobros").DefaultView
        Catch ex As ExecutionEngineException
            MsgBox(ex.Message & " checkBoxFecha_CheckedChanged")
        End Try
    End Sub

    Private Sub dtpFecha1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha1.ValueChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        Try
            dtpFecha2.MinDate = Me.dtpFecha1.Value
            Fecha1 = dtpFecha1.Value.Date
            Fecha2 = dtpFecha2.Value.Date
            ds = Clientes.NotasDebitoXCliente(Me.etClienteCodigo.Text, Fecha1, Fecha2)
            Me.dgNotasDebitos.DataSource = ds.Tables("Cobros").DefaultView
        Catch ex As Exception
            'MsgBox(ex.Message & " dtpFechaDesde_ValueChanged1")
        End Try
    End Sub

    Private Sub dtpFecha2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha2.ValueChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        Try
            Fecha1 = dtpFecha1.Value.Date
            Fecha2 = dtpFecha2.Value.Date
            ds = Clientes.NotasDebitoXCliente(Me.etClienteCodigo.Text, Fecha1, Fecha2)
            Me.dgNotasDebitos.DataSource = ds.Tables("Cobros").DefaultView
        Catch ex As Exception
            'MsgBox(ex.Message & " dtpFechaDesde_ValueChanged2")
        End Try
    End Sub


    Private Sub frmNotasDebitoCliente_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim f As frmAgregarCliente = f.Instance
        f.etInicio.Text = "0"
    End Sub

End Class
