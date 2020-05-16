

Public Class frmReportesCatalogo
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmReportesCatalogo = Nothing


    Public Shared Function Instance() As frmReportesCatalogo
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmReportesCatalogo
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
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents cbGrupos As System.Windows.Forms.CheckBox
    Friend WithEvents cbMayores As System.Windows.Forms.CheckBox
    Friend WithEvents cbSubCuentas As System.Windows.Forms.CheckBox
    Friend WithEvents cbTodas As System.Windows.Forms.CheckBox
    Friend WithEvents cbGruposCuentas As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbPantalla As System.Windows.Forms.RadioButton
    Friend WithEvents rbImpresora As System.Windows.Forms.RadioButton
    Friend WithEvents rbArchivo As System.Windows.Forms.RadioButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbAuxiliares As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents rbNombre As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cbSaldos As System.Windows.Forms.CheckBox
    Friend WithEvents cbMes As System.Windows.Forms.CheckBox
    Friend WithEvents cbMeses As System.Windows.Forms.ComboBox
    Friend WithEvents rbCordobas As System.Windows.Forms.RadioButton
    Friend WithEvents rbDolares As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.cbGruposCuentas = New System.Windows.Forms.ComboBox
        Me.cbTodas = New System.Windows.Forms.CheckBox
        Me.cbAuxiliares = New System.Windows.Forms.CheckBox
        Me.cbSubCuentas = New System.Windows.Forms.CheckBox
        Me.cbMayores = New System.Windows.Forms.CheckBox
        Me.cbGrupos = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbArchivo = New System.Windows.Forms.RadioButton
        Me.rbImpresora = New System.Windows.Forms.RadioButton
        Me.rbPantalla = New System.Windows.Forms.RadioButton
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbCodigo = New System.Windows.Forms.RadioButton
        Me.rbNombre = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cbMeses = New System.Windows.Forms.ComboBox
        Me.cbMes = New System.Windows.Forms.CheckBox
        Me.cbSaldos = New System.Windows.Forms.CheckBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.rbCordobas = New System.Windows.Forms.RadioButton
        Me.rbDolares = New System.Windows.Forms.RadioButton
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.cbGruposCuentas)
        Me.GroupBox7.Controls.Add(Me.cbTodas)
        Me.GroupBox7.Controls.Add(Me.cbAuxiliares)
        Me.GroupBox7.Controls.Add(Me.cbSubCuentas)
        Me.GroupBox7.Controls.Add(Me.cbMayores)
        Me.GroupBox7.Controls.Add(Me.cbGrupos)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox7.Location = New System.Drawing.Point(16, 17)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(360, 233)
        Me.GroupBox7.TabIndex = 135
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "SELECCION"
        '
        'cbGruposCuentas
        '
        Me.cbGruposCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGruposCuentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGruposCuentas.Items.AddRange(New Object() {"TODAS", "BALANCE", "RESULTADO", "PRESUPUESTO"})
        Me.cbGruposCuentas.Location = New System.Drawing.Point(176, 26)
        Me.cbGruposCuentas.Name = "cbGruposCuentas"
        Me.cbGruposCuentas.Size = New System.Drawing.Size(176, 23)
        Me.cbGruposCuentas.TabIndex = 62
        '
        'cbTodas
        '
        Me.cbTodas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTodas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbTodas.Location = New System.Drawing.Point(16, 198)
        Me.cbTodas.Name = "cbTodas"
        Me.cbTodas.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbTodas.Size = New System.Drawing.Size(152, 26)
        Me.cbTodas.TabIndex = 61
        Me.cbTodas.Text = "Todas las Cuentas"
        Me.cbTodas.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'cbAuxiliares
        '
        Me.cbAuxiliares.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAuxiliares.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbAuxiliares.Location = New System.Drawing.Point(16, 155)
        Me.cbAuxiliares.Name = "cbAuxiliares"
        Me.cbAuxiliares.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbAuxiliares.Size = New System.Drawing.Size(152, 26)
        Me.cbAuxiliares.TabIndex = 60
        Me.cbAuxiliares.Text = "Cuentas Auxiliares"
        Me.cbAuxiliares.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'cbSubCuentas
        '
        Me.cbSubCuentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSubCuentas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbSubCuentas.Location = New System.Drawing.Point(16, 112)
        Me.cbSubCuentas.Name = "cbSubCuentas"
        Me.cbSubCuentas.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbSubCuentas.Size = New System.Drawing.Size(152, 26)
        Me.cbSubCuentas.TabIndex = 59
        Me.cbSubCuentas.Text = "Sub Cuentas"
        Me.cbSubCuentas.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'cbMayores
        '
        Me.cbMayores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMayores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbMayores.Location = New System.Drawing.Point(16, 69)
        Me.cbMayores.Name = "cbMayores"
        Me.cbMayores.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbMayores.Size = New System.Drawing.Size(152, 26)
        Me.cbMayores.TabIndex = 58
        Me.cbMayores.Text = "Cuentas de Mayor"
        Me.cbMayores.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'cbGrupos
        '
        Me.cbGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGrupos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbGrupos.Location = New System.Drawing.Point(16, 26)
        Me.cbGrupos.Name = "cbGrupos"
        Me.cbGrupos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbGrupos.Size = New System.Drawing.Size(152, 26)
        Me.cbGrupos.TabIndex = 57
        Me.cbGrupos.Text = "Cuentas por Grupo"
        Me.cbGrupos.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbArchivo)
        Me.GroupBox1.Controls.Add(Me.rbImpresora)
        Me.GroupBox1.Controls.Add(Me.rbPantalla)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(16, 267)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(160, 164)
        Me.GroupBox1.TabIndex = 136
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
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Appearance.Options.UseForeColor = True
        Me.cmdAceptar.Location = New System.Drawing.Point(328, 465)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(80, 26)
        Me.cmdAceptar.TabIndex = 3
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdSalir
        '
        Me.cmdSalir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdSalir.Appearance.Options.UseFont = True
        Me.cmdSalir.Appearance.Options.UseForeColor = True
        Me.cmdSalir.Location = New System.Drawing.Point(416, 465)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(80, 26)
        Me.cmdSalir.TabIndex = 137
        Me.cmdSalir.Text = "Salir"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.rbCodigo)
        Me.GroupBox2.Controls.Add(Me.rbNombre)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(184, 267)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(184, 164)
        Me.GroupBox2.TabIndex = 138
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ORDENADO POR"
        '
        'rbCodigo
        '
        Me.rbCodigo.Checked = True
        Me.rbCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbCodigo.Location = New System.Drawing.Point(16, 26)
        Me.rbCodigo.Name = "rbCodigo"
        Me.rbCodigo.Size = New System.Drawing.Size(112, 34)
        Me.rbCodigo.TabIndex = 1
        Me.rbCodigo.TabStop = True
        Me.rbCodigo.Text = "Código"
        '
        'rbNombre
        '
        Me.rbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbNombre.Location = New System.Drawing.Point(16, 78)
        Me.rbNombre.Name = "rbNombre"
        Me.rbNombre.Size = New System.Drawing.Size(112, 34)
        Me.rbNombre.TabIndex = 0
        Me.rbNombre.Text = "Nombre"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.cbMeses)
        Me.GroupBox3.Controls.Add(Me.cbMes)
        Me.GroupBox3.Controls.Add(Me.cbSaldos)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(384, 17)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(304, 112)
        Me.GroupBox3.TabIndex = 139
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SALDOS"
        '
        'cbMeses
        '
        Me.cbMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMeses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMeses.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cbMeses.Location = New System.Drawing.Point(152, 69)
        Me.cbMeses.Name = "cbMeses"
        Me.cbMeses.Size = New System.Drawing.Size(140, 23)
        Me.cbMeses.TabIndex = 63
        '
        'cbMes
        '
        Me.cbMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbMes.Location = New System.Drawing.Point(8, 69)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbMes.Size = New System.Drawing.Size(136, 26)
        Me.cbMes.TabIndex = 60
        Me.cbMes.Text = "Saldo de Mes"
        Me.cbMes.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'cbSaldos
        '
        Me.cbSaldos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSaldos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbSaldos.Location = New System.Drawing.Point(8, 26)
        Me.cbSaldos.Name = "cbSaldos"
        Me.cbSaldos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbSaldos.Size = New System.Drawing.Size(136, 26)
        Me.cbSaldos.TabIndex = 59
        Me.cbSaldos.Text = "Incorporar Saldos"
        Me.cbSaldos.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.rbCordobas)
        Me.GroupBox5.Controls.Add(Me.rbDolares)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox5.Location = New System.Drawing.Point(384, 138)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(304, 112)
        Me.GroupBox5.TabIndex = 141
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "MONEDA"
        '
        'rbCordobas
        '
        Me.rbCordobas.BackColor = System.Drawing.Color.Transparent
        Me.rbCordobas.Checked = True
        Me.rbCordobas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCordobas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbCordobas.Location = New System.Drawing.Point(16, 26)
        Me.rbCordobas.Name = "rbCordobas"
        Me.rbCordobas.Size = New System.Drawing.Size(136, 34)
        Me.rbCordobas.TabIndex = 1
        Me.rbCordobas.TabStop = True
        Me.rbCordobas.Text = "Córdobas"
        Me.rbCordobas.UseVisualStyleBackColor = False
        '
        'rbDolares
        '
        Me.rbDolares.BackColor = System.Drawing.Color.Transparent
        Me.rbDolares.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDolares.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbDolares.Location = New System.Drawing.Point(16, 69)
        Me.rbDolares.Name = "rbDolares"
        Me.rbDolares.Size = New System.Drawing.Size(112, 34)
        Me.rbDolares.TabIndex = 0
        Me.rbDolares.Text = "Dólares"
        Me.rbDolares.UseVisualStyleBackColor = False
        '
        'frmReportesCatalogo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 502)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Name = "frmReportesCatalogo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmReportesCatalogo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Reportes: Catalogo de Cuentas"
        cbGruposCuentas.SelectedIndex = 0
        cbMeses.SelectedIndex = 0
        Dim r As New VB.SysContab.Rutinas

        'r.CambiarEstilo(Me)
        'Dim Grupos As New VB.SysContab.GruposDB()

        'cbGruposCuentas.DataSource = Grupos.GetListAll().Tables("Grupos")
        'cbGruposCuentas.ValueMember = "CODIGO_GRUPO"
        'cbGruposCuentas.DisplayMember = "Nombre"

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim fReportes As New frmReportes
        'Dim rCatalogo As New rptCatalalogo
        'Dim rCatalogoSaldos As New rptCatalalogoSaldos
        Dim Catalogo As New VB.SysContab.CatalogoDB
        Dim r As New VB.SysContab.Rutinas
        Dim ds As DataSet

        Dim rCatalogo As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rCatalogo.Load(Application.StartupPath & "\Reportes\rptCatalalogo.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
        '
        Dim rCatalogoSaldos As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rCatalogoSaldos.Load(Application.StartupPath & "\Reportes\rptCatalalogoSaldos.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)


        Dim Grupo As String
        Dim Mayor As String
        Dim SubCuenta As String
        Dim Auxiliar As String
        Dim Moneda As String
        Dim TipoCambio As String

        Dim Ordenar As String

        If rbNombre.Checked = True Then
            Ordenar = "2"
        ElseIf rbCodigo.Checked = True Then
            Ordenar = "1"

        End If

        If cbTodas.Checked = True Then
            Grupo = "0"
            Mayor = "0"
            SubCuenta = "0"
            Auxiliar = "0"
        Else

            If cbGrupos.Checked = True Then
                If cbGruposCuentas.SelectedIndex = 1 Then
                    Grupo = "B"
                ElseIf cbGruposCuentas.SelectedIndex = 2 Then
                    Grupo = "P"
                ElseIf cbGruposCuentas.SelectedIndex = 3 Then
                    Grupo = "R"
                Else
                    Grupo = "0"
                End If

            Else
                Grupo = "0"
            End If

            If cbMayores.Checked = True Then
                Mayor = "M"
            Else
                Mayor = "0"

            End If

            If cbSubCuentas.Checked = True Then
                SubCuenta = "S"
            Else
                SubCuenta = "0"

            End If

            If cbAuxiliares.Checked = True Then
                Auxiliar = "A"
            Else
                Auxiliar = "0"

            End If

        End If

        If rbImpresora.Checked = False And rbPantalla.Checked = False And rbArchivo.Checked = False Then
            MsgBox("Seleccione el Formato", MsgBoxStyle.Information)
            Exit Sub

        End If
        TipoCambio = 0
        Moneda = 0

        If rbCordobas.Checked = True Then
            Moneda = 1
        ElseIf rbDolares.Checked = True Then
            Dim TipoC As New VB.SysContab.Tasa_CambioDB
            TipoCambio = TipoC.GetTasaCambioDia(Now.Month, Now.Year, Now.Day).Tables("Tasa_Cambio").Rows(0).Item("Tasa_Cambio")
            Moneda = 2

        End If

        If cbSaldos.Checked = True Then
            ds = Catalogo.GenReporte(Grupo, Mayor, SubCuenta, Auxiliar, 1, -1, Moneda, TipoCambio, Ordenar)
            fReportes.crvReportes.ReportSource = rCatalogoSaldos

        ElseIf cbMes.Checked = True Then
            ds = Catalogo.GenReporte(Grupo, Mayor, SubCuenta, Auxiliar, 1, cbMeses.SelectedIndex + 1, Moneda, TipoCambio, Ordenar)
            fReportes.crvReportes.ReportSource = rCatalogoSaldos
        Else
            ds = Catalogo.GenReporte(Grupo, Mayor, SubCuenta, Auxiliar, 0, -1, Moneda, TipoCambio, Ordenar)
            fReportes.crvReportes.ReportSource = rCatalogo
        End If

        ds.WriteXml(Application.StartupPath & "\xml\RepCatalogo.xml", XmlWriteMode.WriteSchema)

        If cbSaldos.Checked Or cbMes.Checked Then
            rCatalogoSaldos.Database.Tables("_GetListCatalogoGeneradorReportes;1").Location = Application.StartupPath & "\xml\RepCatalogo.xml"
            rCatalogoSaldos.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoempresa.xml"
        Else
            rCatalogo.Database.Tables("_GetListCatalogoGeneradorReportes;1").Location = Application.StartupPath & "\xml\RepCatalogo.xml"
            rCatalogo.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoempresa.xml"
        End If
        If rbImpresora.Checked = True Then
            fReportes.crvReportes.PrintReport()

        ElseIf rbPantalla.Checked = True Then
            fReportes.Show()
        Else
            fReportes.crvReportes.ExportReport()
        End If

        'freportes.Show()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub
    
    Private Sub cbSaldos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbSaldos.Click
        If cbSaldos.Checked = True Then
            If cbMes.Checked = True Then
                cbMes.Checked = False
            End If
        End If
    End Sub

    Private Sub cbMes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMes.Click
        If cbMes.Checked = True Then
            If cbSaldos.Checked = True Then
                cbSaldos.Checked = False
            End If
        End If
    End Sub
End Class
