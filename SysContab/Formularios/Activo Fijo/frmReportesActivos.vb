
Public Class frmReportesActivos
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmReportesActivos = Nothing

    Public Shared Function Instance() As frmReportesActivos
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmReportesActivos()
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbContacto As System.Windows.Forms.RadioButton
    Friend WithEvents rbEconomico As System.Windows.Forms.RadioButton
    Friend WithEvents rbComunicacion As System.Windows.Forms.RadioButton
    Friend WithEvents rbGeneral As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbArchivo As System.Windows.Forms.RadioButton
    Friend WithEvents rbImpresora As System.Windows.Forms.RadioButton
    Friend WithEvents rbPantalla As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cbCargos As System.Windows.Forms.ComboBox
    Friend WithEvents cbDepartamentos As System.Windows.Forms.ComboBox
    Friend WithEvents cbEmpleados As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbSituacion As System.Windows.Forms.ComboBox
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.rbCodigo = New System.Windows.Forms.RadioButton()
        Me.rbAlfabetico = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbSituacion = New System.Windows.Forms.ComboBox()
        Me.cbEmpleados = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbCargos = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbDepartamentos = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
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
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox6.Controls.AddRange(New System.Windows.Forms.Control() {Me.RadioButton2, Me.RadioButton1, Me.rbCodigo, Me.rbAlfabetico})
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox6.Location = New System.Drawing.Point(256, 264)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(136, 184)
        Me.GroupBox6.TabIndex = 146
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "ORDEN"
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(16, 104)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(112, 32)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.Text = "Departamento"
        '
        'RadioButton1
        '
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(16, 144)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(112, 32)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.Text = "Empleado"
        '
        'rbCodigo
        '
        Me.rbCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.rbCodigo.Location = New System.Drawing.Point(16, 64)
        Me.rbCodigo.Name = "rbCodigo"
        Me.rbCodigo.Size = New System.Drawing.Size(112, 32)
        Me.rbCodigo.TabIndex = 1
        Me.rbCodigo.Text = "Código"
        '
        'rbAlfabetico
        '
        Me.rbAlfabetico.Checked = True
        Me.rbAlfabetico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAlfabetico.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.rbAlfabetico.Location = New System.Drawing.Point(16, 24)
        Me.rbAlfabetico.Name = "rbAlfabetico"
        Me.rbAlfabetico.Size = New System.Drawing.Size(112, 32)
        Me.rbAlfabetico.TabIndex = 0
        Me.rbAlfabetico.TabStop = True
        Me.rbAlfabetico.Text = "Alfabético"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox4.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label5, Me.cbSituacion, Me.cbEmpleados, Me.Label4, Me.Label3, Me.cbStatus, Me.Label2, Me.cbCargos, Me.Label1, Me.cbDepartamentos})
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(256, 32)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(440, 216)
        Me.GroupBox4.TabIndex = 145
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CRITERIOS DE SELECCION"
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Situación"
        '
        'cbSituacion
        '
        Me.cbSituacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSituacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSituacion.Items.AddRange(New Object() {"En Uso", "Desuso", "Almacén"})
        Me.cbSituacion.Location = New System.Drawing.Point(120, 176)
        Me.cbSituacion.Name = "cbSituacion"
        Me.cbSituacion.Size = New System.Drawing.Size(304, 23)
        Me.cbSituacion.TabIndex = 71
        '
        'cbEmpleados
        '
        Me.cbEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEmpleados.ItemHeight = 15
        Me.cbEmpleados.Location = New System.Drawing.Point(120, 24)
        Me.cbEmpleados.Name = "cbEmpleados"
        Me.cbEmpleados.Size = New System.Drawing.Size(304, 23)
        Me.cbEmpleados.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 24)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Empleado"
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Estatus"
        '
        'cbStatus
        '
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStatus.Items.AddRange(New Object() {"Perfecto", "Regular", "Mal"})
        Me.cbStatus.Location = New System.Drawing.Point(120, 144)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(304, 23)
        Me.cbStatus.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Cargo"
        '
        'cbCargos
        '
        Me.cbCargos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCargos.Location = New System.Drawing.Point(120, 104)
        Me.cbCargos.Name = "cbCargos"
        Me.cbCargos.Size = New System.Drawing.Size(304, 23)
        Me.cbCargos.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Departamento"
        '
        'cbDepartamentos
        '
        Me.cbDepartamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDepartamentos.Location = New System.Drawing.Point(120, 64)
        Me.cbDepartamentos.Name = "cbDepartamentos"
        Me.cbDepartamentos.Size = New System.Drawing.Size(304, 23)
        Me.cbDepartamentos.TabIndex = 63
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdAyuda, Me.cmdSalir, Me.cmdAceptar})
        Me.GroupBox3.Location = New System.Drawing.Point(264, 464)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(272, 40)
        Me.GroupBox3.TabIndex = 144
        Me.GroupBox3.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAyuda.Location = New System.Drawing.Point(103, 10)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 24)
        Me.cmdAyuda.TabIndex = 23
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Location = New System.Drawing.Point(188, 10)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 24)
        Me.cmdSalir.TabIndex = 22
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Location = New System.Drawing.Point(16, 10)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 24)
        Me.cmdAceptar.TabIndex = 20
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbContacto, Me.rbEconomico, Me.rbComunicacion, Me.rbGeneral})
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(24, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(224, 336)
        Me.GroupBox2.TabIndex = 143
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TIPO DE REPORTE"
        '
        'rbContacto
        '
        Me.rbContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbContacto.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.rbContacto.Location = New System.Drawing.Point(16, 144)
        Me.rbContacto.Name = "rbContacto"
        Me.rbContacto.Size = New System.Drawing.Size(112, 32)
        Me.rbContacto.TabIndex = 3
        Me.rbContacto.Text = "Contactos"
        Me.rbContacto.Visible = False
        '
        'rbEconomico
        '
        Me.rbEconomico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEconomico.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.rbEconomico.Location = New System.Drawing.Point(16, 104)
        Me.rbEconomico.Name = "rbEconomico"
        Me.rbEconomico.Size = New System.Drawing.Size(112, 32)
        Me.rbEconomico.TabIndex = 2
        Me.rbEconomico.Text = "Económicos"
        Me.rbEconomico.Visible = False
        '
        'rbComunicacion
        '
        Me.rbComunicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbComunicacion.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.rbComunicacion.Location = New System.Drawing.Point(16, 64)
        Me.rbComunicacion.Name = "rbComunicacion"
        Me.rbComunicacion.Size = New System.Drawing.Size(112, 32)
        Me.rbComunicacion.TabIndex = 1
        Me.rbComunicacion.Text = "Comunicación"
        Me.rbComunicacion.Visible = False
        '
        'rbGeneral
        '
        Me.rbGeneral.Checked = True
        Me.rbGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.rbGeneral.Location = New System.Drawing.Point(16, 24)
        Me.rbGeneral.Name = "rbGeneral"
        Me.rbGeneral.Size = New System.Drawing.Size(112, 32)
        Me.rbGeneral.TabIndex = 0
        Me.rbGeneral.TabStop = True
        Me.rbGeneral.Text = "General"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbArchivo, Me.rbImpresora, Me.rbPantalla})
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(400, 264)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(136, 184)
        Me.GroupBox1.TabIndex = 142
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FORMATO"
        '
        'rbArchivo
        '
        Me.rbArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbArchivo.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.rbArchivo.Location = New System.Drawing.Point(16, 104)
        Me.rbArchivo.Name = "rbArchivo"
        Me.rbArchivo.Size = New System.Drawing.Size(112, 32)
        Me.rbArchivo.TabIndex = 2
        Me.rbArchivo.Text = "Archivo"
        '
        'rbImpresora
        '
        Me.rbImpresora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbImpresora.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.rbImpresora.Location = New System.Drawing.Point(16, 64)
        Me.rbImpresora.Name = "rbImpresora"
        Me.rbImpresora.Size = New System.Drawing.Size(112, 32)
        Me.rbImpresora.TabIndex = 1
        Me.rbImpresora.Text = "Impresora"
        '
        'rbPantalla
        '
        Me.rbPantalla.Checked = True
        Me.rbPantalla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPantalla.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.rbPantalla.Location = New System.Drawing.Point(16, 24)
        Me.rbPantalla.Name = "rbPantalla"
        Me.rbPantalla.Size = New System.Drawing.Size(112, 32)
        Me.rbPantalla.TabIndex = 0
        Me.rbPantalla.TabStop = True
        Me.rbPantalla.Text = "Pantalla"
        '
        'frmReportesActivos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(832, 558)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox6, Me.GroupBox4, Me.GroupBox3, Me.GroupBox2, Me.GroupBox1})
        Me.Name = "frmReportesActivos"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmReportesActivos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Empleado As New VB.SysContab.EmpleadosDB()
        Dim Departamento As New VB.SysContab.DepartamentosDB()
        Dim Cargo As New VB.SysContab.CargosDB()

        Dim r As New VB.SysContab.Rutinas()
        'r.CambiarEstilo(Me)

        cbEmpleados.DataSource = Empleado.GetListBuscarCombo("%").Tables("EMPLEADOS")
        cbEmpleados.ValueMember = "Codigo"
        cbEmpleados.DisplayMember = "Nombre"

        cbDepartamentos.DataSource = Departamento.GetListBuscarCombo("%").Tables("DEPARTAMENTOS")
        cbDepartamentos.ValueMember = "Codigo"
        cbDepartamentos.DisplayMember = "Nombre"

        cbCargos.DataSource = Cargo.GetListBuscarCombo("%").Tables("CARGOS")
        cbCargos.ValueMember = "Codigo"
        cbCargos.DisplayMember = "Nombre"

        Me.cbStatus.SelectedIndex = 0
        Me.cbSituacion.SelectedIndex = 0

        'cbEmpleados.SelectedValue = 0

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim fReportes As New frmReportes()
        Dim Activos As New VB.SysContab.Activo_FijosDB()
        Dim Orden As Integer
        Dim ds As DataSet

        If rbAlfabetico.Checked = True Then
            Orden = 1
        ElseIf rbCodigo.Checked = True Then
            Orden = 2
        End If

        ds = Activos.GeneradorReportes(IIf(cbEmpleados.SelectedValue Is Nothing, "%", cbEmpleados.SelectedValue), IIf(cbDepartamentos.SelectedValue Is Nothing, "%", cbDepartamentos.SelectedValue), IIf(cbCargos.SelectedValue Is Nothing, "%", cbCargos.SelectedValue), cbStatus.SelectedIndex + 1, cbSituacion.SelectedIndex + 1, Orden)
        ds.WriteXml(Application.StartupPath & "\xml\RepActivos.xml", XmlWriteMode.WriteSchema)

        If cbStatus.SelectedIndex = 1 Then
            'Dim rActivosPendientes As New rptActivosPendientes
            Dim rActivosPendientes As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            rActivosPendientes.Load(Application.StartupPath & "\Reportes\rptActivosPendientes.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            'rActivosPendientes.SetDataSource(Activos.GeneradorReportes(IIf(cbEmpleados.SelectedValue Is Nothing, "%", cbEmpleados.SelectedValue), IIf(cbDepartamentos.SelectedValue Is Nothing, "%", cbDepartamentos.SelectedValue), IIf(cbCargos.SelectedValue Is Nothing, "%", cbCargos.SelectedValue), cbStatus.SelectedIndex + 1, cbSituacion.SelectedIndex + 1, Orden))
            rActivosPendientes.Database.Tables("_GeneradorReportesActivos;1").Location = Application.StartupPath & "\xml\RepActivos.xml"
            rActivosPendientes.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoempresa.xml"
            fReportes.crvReportes.ReportSource = rActivosPendientes
        Else
            'Dim rActivosG As New rptActivosEmpleadosG
            Dim rActivosG As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            rActivosG.Load(Application.StartupPath & "\Reportes\rptActivosEmpleadosG.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            'rActivosG.SetDataSource(Activos.GeneradorReportes(IIf(cbEmpleados.SelectedValue Is Nothing, "%", cbEmpleados.SelectedValue), IIf(cbDepartamentos.SelectedValue Is Nothing, "%", cbDepartamentos.SelectedValue), IIf(cbCargos.SelectedValue Is Nothing, "%", cbCargos.SelectedValue), cbStatus.SelectedIndex + 1, cbSituacion.SelectedIndex + 1, Orden))
            rActivosG.Database.Tables("_GeneradorReportesActivos;1").Location = Application.StartupPath & "\xml\RepActivos.xml"
            rActivosG.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoempresa.xml"
            fReportes.crvReportes.ReportSource = rActivosG
        End If

        If rbPantalla.Checked = True Then
            fReportes.Show()

        ElseIf rbImpresora.Checked = True Then
            fReportes.crvReportes.PrintReport()

        Else
            fReportes.crvReportes.ExportReport()

        End If

        'MsgBox(cbEmpleados.SelectedValue)

    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/Reportes/ReportesActivos.chm")
    End Sub
End Class
