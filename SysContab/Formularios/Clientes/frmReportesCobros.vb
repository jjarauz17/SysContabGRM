Public Class frmReportesCobros
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmReportesCobros = Nothing

    Public Shared Function Instance() As frmReportesCobros
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmReportesCobros()
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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents cbFacturas As System.Windows.Forms.ComboBox
    Friend WithEvents cbBancos As System.Windows.Forms.ComboBox
    Friend WithEvents cbEmisores As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbArchivo As System.Windows.Forms.RadioButton
    Friend WithEvents rbImpresora As System.Windows.Forms.RadioButton
    Friend WithEvents rbPantalla As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbFecha As System.Windows.Forms.CheckBox
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cbTipo = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.cbFecha = New System.Windows.Forms.CheckBox
        Me.cbFormaPago = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbFacturas = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbBancos = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbEmisores = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbClientes = New System.Windows.Forms.ComboBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbArchivo = New System.Windows.Forms.RadioButton
        Me.rbImpresora = New System.Windows.Forms.RadioButton
        Me.rbPantalla = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.cbTipo)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.dtpFecha)
        Me.GroupBox3.Controls.Add(Me.cbFecha)
        Me.GroupBox3.Controls.Add(Me.cbFormaPago)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.cbFacturas)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.cbBancos)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.cbEmisores)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cbClientes)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(8, 9)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(400, 336)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CRITERIOS DE SELECCION"
        '
        'cbTipo
        '
        Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipo.Items.AddRange(New Object() {"", "Cancelación", "Adelanto", "Abono"})
        Me.cbTipo.Location = New System.Drawing.Point(128, 241)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(248, 21)
        Me.cbTipo.TabIndex = 154
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 241)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 26)
        Me.Label1.TabIndex = 155
        Me.Label1.Text = "Tipo:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(128, 293)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha.TabIndex = 153
        '
        'cbFecha
        '
        Me.cbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbFecha.Location = New System.Drawing.Point(8, 293)
        Me.cbFecha.Name = "cbFecha"
        Me.cbFecha.Size = New System.Drawing.Size(104, 26)
        Me.cbFecha.TabIndex = 151
        Me.cbFecha.Text = "Por Fecha:"
        Me.cbFecha.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'cbFormaPago
        '
        Me.cbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFormaPago.Items.AddRange(New Object() {"", "EFECTIVO", "CHEQUE", "TARJETA DE CREDITO"})
        Me.cbFormaPago.Location = New System.Drawing.Point(128, 198)
        Me.cbFormaPago.Name = "cbFormaPago"
        Me.cbFormaPago.Size = New System.Drawing.Size(248, 21)
        Me.cbFormaPago.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(8, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 26)
        Me.Label5.TabIndex = 113
        Me.Label5.Text = "Forma de Pago:"
        '
        'cbFacturas
        '
        Me.cbFacturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFacturas.Location = New System.Drawing.Point(128, 155)
        Me.cbFacturas.Name = "cbFacturas"
        Me.cbFacturas.Size = New System.Drawing.Size(248, 21)
        Me.cbFacturas.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 26)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "Factura:"
        '
        'cbBancos
        '
        Me.cbBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBancos.Location = New System.Drawing.Point(128, 69)
        Me.cbBancos.Name = "cbBancos"
        Me.cbBancos.Size = New System.Drawing.Size(248, 21)
        Me.cbBancos.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 26)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Banco:"
        '
        'cbEmisores
        '
        Me.cbEmisores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEmisores.Location = New System.Drawing.Point(128, 112)
        Me.cbEmisores.Name = "cbEmisores"
        Me.cbEmisores.Size = New System.Drawing.Size(248, 21)
        Me.cbEmisores.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 26)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Emisor:"
        '
        'cbClientes
        '
        Me.cbClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClientes.Location = New System.Drawing.Point(128, 26)
        Me.cbClientes.Name = "cbClientes"
        Me.cbClientes.Size = New System.Drawing.Size(248, 21)
        Me.cbClientes.TabIndex = 0
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(8, 26)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(64, 26)
        Me.Label24.TabIndex = 101
        Me.Label24.Text = "Cliente:"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Appearance.Options.UseForeColor = True
        Me.cmdCancelar.Location = New System.Drawing.Point(312, 16)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 36)
        Me.cmdCancelar.TabIndex = 7
        Me.cmdCancelar.Text = "&Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Appearance.Options.UseForeColor = True
        Me.cmdAceptar.Location = New System.Drawing.Point(8, 16)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 36)
        Me.cmdAceptar.TabIndex = 6
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.rbArchivo)
        Me.GroupBox1.Controls.Add(Me.rbImpresora)
        Me.GroupBox1.Controls.Add(Me.rbPantalla)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(8, 370)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 61)
        Me.GroupBox1.TabIndex = 143
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FORMATO"
        '
        'rbArchivo
        '
        Me.rbArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbArchivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbArchivo.Location = New System.Drawing.Point(276, 17)
        Me.rbArchivo.Name = "rbArchivo"
        Me.rbArchivo.Size = New System.Drawing.Size(88, 35)
        Me.rbArchivo.TabIndex = 2
        Me.rbArchivo.Text = "Archivo"
        '
        'rbImpresora
        '
        Me.rbImpresora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbImpresora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbImpresora.Location = New System.Drawing.Point(112, 17)
        Me.rbImpresora.Name = "rbImpresora"
        Me.rbImpresora.Size = New System.Drawing.Size(139, 35)
        Me.rbImpresora.TabIndex = 1
        Me.rbImpresora.Text = "Impresora"
        '
        'rbPantalla
        '
        Me.rbPantalla.Checked = True
        Me.rbPantalla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPantalla.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbPantalla.Location = New System.Drawing.Point(16, 17)
        Me.rbPantalla.Name = "rbPantalla"
        Me.rbPantalla.Size = New System.Drawing.Size(88, 35)
        Me.rbPantalla.TabIndex = 0
        Me.rbPantalla.TabStop = True
        Me.rbPantalla.Text = "Pantalla"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.cmdAceptar)
        Me.GroupBox2.Controls.Add(Me.cmdCancelar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(8, 448)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 60)
        Me.GroupBox2.TabIndex = 144
        Me.GroupBox2.TabStop = False
        '
        'frmReportesCobros
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 526)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmReportesCobros"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Clientes As New VB.SysContab.ClientesDB()
    Dim Bancos As New VB.SysContab.BancosDB()
    Dim Emisores As New VB.SysContab.EmisoresDB()
    Dim r As New VB.SysContab.Rutinas()

    Private Sub frmReportesCobros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'r.CambiarEstilo(Me)
        r.FormularioColor(Me)

        cbClientes.DataSource = Clientes.GetList().Tables("Clientes")
        cbClientes.ValueMember = "Codigo"
        cbClientes.DisplayMember = "Nombre"

        cbClientes.DropDownStyle = ComboBoxStyle.DropDownList

        cbFacturas.DataSource = Clientes.ListFacturas("").Tables("Facturas_Ventas")
        cbFacturas.ValueMember = "No Factura"
        cbFacturas.DisplayMember = "No Factura"

        cbBancos.DataSource = Bancos.List.Tables("Bancos")
        cbBancos.ValueMember = "Codigo"
        cbBancos.DisplayMember = "Nombre"

        cbBancos.DropDownStyle = ComboBoxStyle.DropDownList

        cbEmisores.DataSource = Emisores.GetList.Tables("Emisores")
        cbEmisores.ValueMember = "Codigo"
        cbEmisores.DisplayMember = "Nombre"

        cbEmisores.DropDownStyle = ComboBoxStyle.DropDownList

        Me.cbTipo.SelectedIndex = 0

        Me.Text = "Reportes de Cobros a Clientes"

        'cbEmisores.Items.Add("AVAL")
        'cbEmisores.Items.Add("BAC")
        'cbEmisores.Items.Add("BANCO UNO")
        'cbEmisores.Items.Add("OTRO")

        dtpFecha.Value = r.Fecha
        dtpFecha.Enabled = False

        'cbBancos.Items.Add("BANCO UNO")
        'cbBancos.Items.Add("BDF")
        'cbBancos.Items.Add("BAC")
        'cbBancos.Items.Add("BANCENTRO")
        'cbBancos.Items.Add("BANEXPO")
        'cbBancos.Items.Add("BANPRO")

        cbEmisores.SelectedIndex = -1
        cbBancos.SelectedIndex = -1

        cbFacturas.SelectedIndex = -1
        cbFormaPago.SelectedIndex = 0

        'txtFecha.CtlText = Now.ToShortDateString

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmReportesCobros_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim fReportes As New frmReportes()

        Dim rCobros As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rCobros.Load(Application.StartupPath & "\Reportes\rptCobros.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        'Dim rCobros As New rptCobros()
        Dim dsCobros As DataSet

        Dim Fecha As String
        If cbFecha.Checked = True Then
            Fecha = dtpFecha.Value.Date
        Else
            Fecha = ""
        End If

        dsCobros = Clientes.ListCobros(cbClientes.SelectedValue, Fecha, cbBancos.SelectedValue, cbEmisores.SelectedValue, cbFacturas.Text, cbFormaPago.SelectedIndex, Me.cbTipo.SelectedIndex)

        If dsCobros.Tables("Cobros").Rows.Count = 0 Then
            MsgBox("No hay datos bajos los criterios de selección", MsgBoxStyle.Information)
            Exit Sub
        End If
        rCobros.SetDataSource(dsCobros)
        fReportes.crvReportes.ReportSource = rCobros

        fReportes.Text = "Reporte de Cobros a Clientes"
        fReportes.Refresh()

        If rbPantalla.Checked = True Then
            freportes.Show()
        ElseIf rbImpresora.Checked = True Then
            fReportes.crvReportes.PrintReport()
        Else
            fReportes.crvReportes.ExportReport()
        End If
    End Sub

    Private Sub cbFecha_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbFecha.Click
        If cbFecha.Checked = True Then
            dtpFecha.Enabled = True
        Else
            dtpFecha.Enabled = False
        End If
    End Sub
End Class
