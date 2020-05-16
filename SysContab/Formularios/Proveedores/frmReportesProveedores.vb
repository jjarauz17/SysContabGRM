Public Class frmReportesProveedores
    Inherits DevExpress.XtraEditors.XtraForm
    Private Shared ChildInstance As frmReportesProveedores = Nothing

    Public Shared Function Instance() As frmReportesProveedores
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmReportesProveedores()
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
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rbCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents rbAlfabetico As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbZonas As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rbContador As System.Windows.Forms.RadioButton
    Friend WithEvents rbContacto1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbContacto As System.Windows.Forms.RadioButton
    Friend WithEvents rbEconomico As System.Windows.Forms.RadioButton
    Friend WithEvents rbComunicacion As System.Windows.Forms.RadioButton
    Friend WithEvents rbGeneral As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbArchivo As System.Windows.Forms.RadioButton
    Friend WithEvents rbImpresora As System.Windows.Forms.RadioButton
    Friend WithEvents rbPantalla As System.Windows.Forms.RadioButton
    Friend WithEvents rbGerente As System.Windows.Forms.RadioButton
    Friend WithEvents tbCiudad As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rbCodigo = New System.Windows.Forms.RadioButton()
        Me.rbAlfabetico = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tbCiudad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbFormaPago = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbZonas = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rbContador = New System.Windows.Forms.RadioButton()
        Me.rbGerente = New System.Windows.Forms.RadioButton()
        Me.rbContacto1 = New System.Windows.Forms.RadioButton()
        Me.rbContacto = New System.Windows.Forms.RadioButton()
        Me.rbEconomico = New System.Windows.Forms.RadioButton()
        Me.rbComunicacion = New System.Windows.Forms.RadioButton()
        Me.rbGeneral = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbArchivo = New System.Windows.Forms.RadioButton()
        Me.rbImpresora = New System.Windows.Forms.RadioButton()
        Me.rbPantalla = New System.Windows.Forms.RadioButton()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.rbCodigo)
        Me.GroupBox6.Controls.Add(Me.rbAlfabetico)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox6.Location = New System.Drawing.Point(256, 215)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(136, 181)
        Me.GroupBox6.TabIndex = 146
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "ORDEN"
        '
        'rbCodigo
        '
        Me.rbCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbCodigo.Location = New System.Drawing.Point(16, 69)
        Me.rbCodigo.Name = "rbCodigo"
        Me.rbCodigo.Size = New System.Drawing.Size(112, 34)
        Me.rbCodigo.TabIndex = 1
        Me.rbCodigo.Text = "Código"
        '
        'rbAlfabetico
        '
        Me.rbAlfabetico.Checked = True
        Me.rbAlfabetico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAlfabetico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbAlfabetico.Location = New System.Drawing.Point(16, 26)
        Me.rbAlfabetico.Name = "rbAlfabetico"
        Me.rbAlfabetico.Size = New System.Drawing.Size(112, 34)
        Me.rbAlfabetico.TabIndex = 0
        Me.rbAlfabetico.TabStop = True
        Me.rbAlfabetico.Text = "Alfabético"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.tbCiudad)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.cbFormaPago)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.cbZonas)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(256, 34)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(440, 173)
        Me.GroupBox4.TabIndex = 145
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CRITERIOS DE SELECCION"
        '
        'tbCiudad
        '
        Me.tbCiudad.Location = New System.Drawing.Point(120, 34)
        Me.tbCiudad.Name = "tbCiudad"
        Me.tbCiudad.Size = New System.Drawing.Size(304, 21)
        Me.tbCiudad.TabIndex = 69
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 25)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Forma de Pago"
        '
        'cbFormaPago
        '
        Me.cbFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFormaPago.Location = New System.Drawing.Point(120, 103)
        Me.cbFormaPago.Name = "cbFormaPago"
        Me.cbFormaPago.Size = New System.Drawing.Size(304, 23)
        Me.cbFormaPago.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 25)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Zona"
        '
        'cbZonas
        '
        Me.cbZonas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbZonas.Location = New System.Drawing.Point(120, 69)
        Me.cbZonas.Name = "cbZonas"
        Me.cbZonas.Size = New System.Drawing.Size(304, 23)
        Me.cbZonas.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 25)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Ciudad"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.cmdSalir)
        Me.GroupBox3.Controls.Add(Me.cmdAceptar)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 396)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(224, 43)
        Me.GroupBox3.TabIndex = 144
        Me.GroupBox3.TabStop = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Appearance.Options.UseFont = True
        Me.cmdSalir.Location = New System.Drawing.Point(144, 11)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 26)
        Me.cmdSalir.TabIndex = 22
        Me.cmdSalir.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Location = New System.Drawing.Point(8, 11)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 26)
        Me.cmdAceptar.TabIndex = 20
        Me.cmdAceptar.Text = "Aceptar"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.rbContacto)
        Me.GroupBox2.Controls.Add(Me.rbEconomico)
        Me.GroupBox2.Controls.Add(Me.rbComunicacion)
        Me.GroupBox2.Controls.Add(Me.rbGeneral)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(24, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(224, 362)
        Me.GroupBox2.TabIndex = 143
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TIPO DE REPORTE"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.rbContador)
        Me.GroupBox5.Controls.Add(Me.rbGerente)
        Me.GroupBox5.Controls.Add(Me.rbContacto1)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox5.Location = New System.Drawing.Point(40, 181)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(176, 146)
        Me.GroupBox5.TabIndex = 138
        Me.GroupBox5.TabStop = False
        '
        'rbContador
        '
        Me.rbContador.BackColor = System.Drawing.Color.Transparent
        Me.rbContador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbContador.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbContador.Location = New System.Drawing.Point(16, 95)
        Me.rbContador.Name = "rbContador"
        Me.rbContador.Size = New System.Drawing.Size(112, 34)
        Me.rbContador.TabIndex = 2
        Me.rbContador.Text = "Contador"
        Me.rbContador.UseVisualStyleBackColor = False
        '
        'rbGerente
        '
        Me.rbGerente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbGerente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbGerente.Location = New System.Drawing.Point(16, 52)
        Me.rbGerente.Name = "rbGerente"
        Me.rbGerente.Size = New System.Drawing.Size(112, 34)
        Me.rbGerente.TabIndex = 1
        Me.rbGerente.Text = "Gerente"
        '
        'rbContacto1
        '
        Me.rbContacto1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbContacto1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbContacto1.Location = New System.Drawing.Point(16, 9)
        Me.rbContacto1.Name = "rbContacto1"
        Me.rbContacto1.Size = New System.Drawing.Size(112, 34)
        Me.rbContacto1.TabIndex = 0
        Me.rbContacto1.Text = "Contacto"
        '
        'rbContacto
        '
        Me.rbContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbContacto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbContacto.Location = New System.Drawing.Point(16, 155)
        Me.rbContacto.Name = "rbContacto"
        Me.rbContacto.Size = New System.Drawing.Size(112, 35)
        Me.rbContacto.TabIndex = 3
        Me.rbContacto.Text = "Contactos"
        '
        'rbEconomico
        '
        Me.rbEconomico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEconomico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbEconomico.Location = New System.Drawing.Point(16, 112)
        Me.rbEconomico.Name = "rbEconomico"
        Me.rbEconomico.Size = New System.Drawing.Size(112, 34)
        Me.rbEconomico.TabIndex = 2
        Me.rbEconomico.Text = "Económicos"
        '
        'rbComunicacion
        '
        Me.rbComunicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbComunicacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbComunicacion.Location = New System.Drawing.Point(16, 69)
        Me.rbComunicacion.Name = "rbComunicacion"
        Me.rbComunicacion.Size = New System.Drawing.Size(112, 34)
        Me.rbComunicacion.TabIndex = 1
        Me.rbComunicacion.Text = "Comunicación"
        '
        'rbGeneral
        '
        Me.rbGeneral.Checked = True
        Me.rbGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbGeneral.Location = New System.Drawing.Point(16, 26)
        Me.rbGeneral.Name = "rbGeneral"
        Me.rbGeneral.Size = New System.Drawing.Size(112, 34)
        Me.rbGeneral.TabIndex = 0
        Me.rbGeneral.TabStop = True
        Me.rbGeneral.Text = "General"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbArchivo)
        Me.GroupBox1.Controls.Add(Me.rbImpresora)
        Me.GroupBox1.Controls.Add(Me.rbPantalla)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(400, 215)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(136, 181)
        Me.GroupBox1.TabIndex = 142
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FORMATO"
        '
        'rbArchivo
        '
        Me.rbArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbArchivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbArchivo.Location = New System.Drawing.Point(16, 112)
        Me.rbArchivo.Name = "rbArchivo"
        Me.rbArchivo.Size = New System.Drawing.Size(112, 34)
        Me.rbArchivo.TabIndex = 2
        Me.rbArchivo.Text = "Archivo"
        '
        'rbImpresora
        '
        Me.rbImpresora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbImpresora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbImpresora.Location = New System.Drawing.Point(16, 69)
        Me.rbImpresora.Name = "rbImpresora"
        Me.rbImpresora.Size = New System.Drawing.Size(112, 34)
        Me.rbImpresora.TabIndex = 1
        Me.rbImpresora.Text = "Impresora"
        '
        'rbPantalla
        '
        Me.rbPantalla.Checked = True
        Me.rbPantalla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPantalla.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbPantalla.Location = New System.Drawing.Point(16, 26)
        Me.rbPantalla.Name = "rbPantalla"
        Me.rbPantalla.Size = New System.Drawing.Size(112, 34)
        Me.rbPantalla.TabIndex = 0
        Me.rbPantalla.TabStop = True
        Me.rbPantalla.Text = "Pantalla"
        '
        'frmReportesProveedores
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(704, 451)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmReportesProveedores"
        Me.Text = "Reporte de Proveedores"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmReportesProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Zonas As New VB.SysContab.ZonasDB()
        Dim FormaPago As New VB.SysContab.Forma_PagoDB()
        Dim Departamento As New VB.SysContab.DepartamentosCDB()
        Dim Municipios As New VB.SysContab.MunicipiosDB()
        Dim Vendedor As New VB.SysContab.VendedoresDB()
        Dim r As New VB.SysContab.Rutinas()
        'r.CambiarEstilo(Me)

        cbZonas.DataSource = Zonas.ZonasList().Tables("Zonas")
        cbZonas.ValueMember = "Codigo"
        cbZonas.DisplayMember = "Nombre"
        cbZonas.SelectedValue = 0

        Me.cbFormaPago.DataSource = FormaPago.FormaPagoListAll().Tables("Forma_Pago")
        Me.cbFormaPago.ValueMember = "Codigo"
        Me.cbFormaPago.DisplayMember = "Nombre"
        Me.cbFormaPago.SelectedValue = 0

        'cbFormaPago.DataSource = FormaPago.GetListReporte("%", EmpresaActual).Tables("Forma_Pago")
        'cbFormaPago.ValueMember = "Codigo"
        'cbFormaPago.DisplayMember = "Nombre"

        Me.Text = "Reportes Proveedores".ToUpper

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim fReportes As New frmReportes()
        Dim Proveedores As New VB.SysContab.ProveedoresDB
        Dim ds As New DataSet

        Dim Orden As Integer
        Dim Zona As String
        Dim FormaPago As String
        Dim TipoReporte As Integer

        If rbAlfabetico.Checked = True Then
            Orden = 1
        Else
            Orden = 2
        End If

        If cbZonas.SelectedIndex = -1 Or Me.cbZonas.SelectedValue = Nothing Or Me.cbZonas.SelectedValue = 0 Then
            Zona = 0
        Else
            Zona = cbZonas.SelectedValue
        End If

        If cbFormaPago.SelectedIndex = -1 Or Me.cbFormaPago.SelectedValue = Nothing Or Me.cbFormaPago.SelectedValue = 0 Then
            FormaPago = 0
        Else
            FormaPago = cbFormaPago.SelectedValue
        End If

        If rbGeneral.Checked = True Then
            TipoReporte = 1
        ElseIf rbComunicacion.Checked = True Then
            TipoReporte = 2
        ElseIf rbEconomico.Checked = True Then
            TipoReporte = 3
        ElseIf rbContacto1.Checked = True Then
            TipoReporte = 4
        ElseIf rbContador.Checked = True Then
            TipoReporte = 5
        ElseIf rbGerente.Checked = True Then
            TipoReporte = 6
        End If

        ds = Proveedores.GeneradorReportes(tbCiudad.Text, Zona, FormaPago, Orden, TipoReporte)
        ds.WriteXml(Application.StartupPath & "\xml\RepProveedores.xml", XmlWriteMode.WriteSchema)

        'Dim rReporteProveedores As New rptProveedoresGeneral
        Dim rReporteProveedores As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rReporteProveedores.Load(Application.StartupPath & "\Reportes\rptProveedoresGeneral.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        rReporteProveedores.Database.Tables("_GeneradorReportesProveedores").Location = Application.StartupPath & "\xml\RepProveedores.xml"
        rReporteProveedores.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoempresa.xml"
        fReportes.crvReportes.ReportSource = rReporteProveedores

        If rbPantalla.Checked = True Then
            freportes.Show()

        ElseIf rbImpresora.Checked = True Then
            fReportes.crvReportes.PrintReport()

        Else
            fReportes.crvReportes.ExportReport()

        End If

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub rbContacto_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbContacto.CheckedChanged
        If rbContacto.Checked = True Then
            If rbContacto1.Checked = False And rbContador.Checked = False And rbGerente.Checked = False Then
                rbContacto1.Checked = True
            End If
        Else
            rbContacto1.Checked = False
            rbContador.Checked = False
            rbGerente.Checked = False

        End If

    End Sub

    Private Sub rbContacto1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbContacto1.Click
        rbGeneral.Checked = False
        rbEconomico.Checked = False
        rbComunicacion.Checked = False
        rbContacto.Checked = True

    End Sub

    Private Sub rbGerente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbGerente.Click
        rbGeneral.Checked = False
        rbEconomico.Checked = False
        rbComunicacion.Checked = False
        rbContacto.Checked = True

    End Sub

    Private Sub rbContador_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbContador.Click
        rbGeneral.Checked = False
        rbEconomico.Checked = False
        rbComunicacion.Checked = False
        rbContacto.Checked = True

    End Sub

    'Private Sub rbContacto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbContacto.Click
    '    If rbContacto.Checked = True Then
    '        rbContacto1.Checked = True
    '    Else
    '        rbContacto1.Checked = False
    '        rbContador.Checked = False
    '        rbGerente.Checked = False

    '    End If

    'End Sub

End Class
