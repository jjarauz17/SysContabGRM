
Public Class frmRptPresupuesto
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmRptPresupuesto = Nothing
    Private i As Integer
    Dim Catalogo As New VB.SysContab.CatalogoDB()
    Dim Grupos As New VB.SysContab.GruposDB()
    Dim Periodos As New VB.SysContab.PeriodosDB()
    Dim Presupuesto As New VB.SysContab.PresupuestoDB()
    Dim Libros As New VB.SysContab.LibrosDB()
    Dim r As New VB.SysContab.RutinasNomina()
    Dim tcuenta As String
    Private Empresa As New VB.SysContab.EmpresasDetails()
    Private Empresas As New VB.SysContab.EmpresasDB()


    Public Shared Function Instance() As frmRptPresupuesto
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmRptPresupuesto()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbCatalogo As System.Windows.Forms.ComboBox
    Friend WithEvents cbPeriodos As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents GBRango As System.Windows.Forms.GroupBox
    Friend WithEvents cbNiveles As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GBMes As System.Windows.Forms.GroupBox
    Friend WithEvents cbMes As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkMes As System.Windows.Forms.CheckBox
    Friend WithEvents ChkRango As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbMonedaCambio As System.Windows.Forms.ComboBox
    Friend WithEvents chkComparar As System.Windows.Forms.CheckBox
    Friend WithEvents gbComparar As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkMes2 As System.Windows.Forms.CheckBox
    Friend WithEvents ChkRango2 As System.Windows.Forms.CheckBox
    Friend WithEvents cbPeriodos2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GBMes2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GBRango2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpDesde2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpHasta2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbMes2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.chkMes = New System.Windows.Forms.CheckBox
        Me.ChkRango = New System.Windows.Forms.CheckBox
        Me.cbPeriodos = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GBMes = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbMes = New System.Windows.Forms.ComboBox
        Me.GBRango = New System.Windows.Forms.GroupBox
        Me.cbCatalogo = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbNiveles = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cbMonedaCambio = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.chkComparar = New System.Windows.Forms.CheckBox
        Me.gbComparar = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chkMes2 = New System.Windows.Forms.CheckBox
        Me.ChkRango2 = New System.Windows.Forms.CheckBox
        Me.cbPeriodos2 = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GBMes2 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cbMes2 = New System.Windows.Forms.ComboBox
        Me.GBRango2 = New System.Windows.Forms.GroupBox
        Me.dtpDesde2 = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.dtpHasta2 = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GBMes.SuspendLayout()
        Me.GBRango.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.gbComparar.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GBMes2.SuspendLayout()
        Me.GBRango2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpDesde
        '
        Me.dtpDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(88, 17)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(104, 20)
        Me.dtpDesde.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 26)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Desde:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(16, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 26)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Hasta:"
        '
        'dtpHasta
        '
        Me.dtpHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(88, 43)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(104, 20)
        Me.dtpHasta.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox8)
        Me.GroupBox1.Controls.Add(Me.cbPeriodos)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.GBMes)
        Me.GroupBox1.Controls.Add(Me.GBRango)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 148)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 155)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.chkMes)
        Me.GroupBox8.Controls.Add(Me.ChkRango)
        Me.GroupBox8.Location = New System.Drawing.Point(16, 52)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(200, 94)
        Me.GroupBox8.TabIndex = 14
        Me.GroupBox8.TabStop = False
        '
        'chkMes
        '
        Me.chkMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkMes.Location = New System.Drawing.Point(16, 43)
        Me.chkMes.Name = "chkMes"
        Me.chkMes.Size = New System.Drawing.Size(96, 26)
        Me.chkMes.TabIndex = 1
        Me.chkMes.Text = "Mes"
        '
        'ChkRango
        '
        Me.ChkRango.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRango.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRango.Location = New System.Drawing.Point(16, 17)
        Me.ChkRango.Name = "ChkRango"
        Me.ChkRango.Size = New System.Drawing.Size(152, 26)
        Me.ChkRango.TabIndex = 0
        Me.ChkRango.Text = "Rango de Fechas"
        '
        'cbPeriodos
        '
        Me.cbPeriodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPeriodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPeriodos.Location = New System.Drawing.Point(88, 17)
        Me.cbPeriodos.Name = "cbPeriodos"
        Me.cbPeriodos.Size = New System.Drawing.Size(424, 23)
        Me.cbPeriodos.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(16, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 26)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Periodos:"
        '
        'GBMes
        '
        Me.GBMes.Controls.Add(Me.Label7)
        Me.GBMes.Controls.Add(Me.cbMes)
        Me.GBMes.Location = New System.Drawing.Point(224, 52)
        Me.GBMes.Name = "GBMes"
        Me.GBMes.Size = New System.Drawing.Size(288, 94)
        Me.GBMes.TabIndex = 16
        Me.GBMes.TabStop = False
        Me.GBMes.Visible = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(16, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 26)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Mes:"
        '
        'cbMes
        '
        Me.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMes.Location = New System.Drawing.Point(80, 43)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(192, 23)
        Me.cbMes.TabIndex = 1
        '
        'GBRango
        '
        Me.GBRango.Controls.Add(Me.dtpDesde)
        Me.GBRango.Controls.Add(Me.Label1)
        Me.GBRango.Controls.Add(Me.Label2)
        Me.GBRango.Controls.Add(Me.dtpHasta)
        Me.GBRango.Location = New System.Drawing.Point(224, 52)
        Me.GBRango.Name = "GBRango"
        Me.GBRango.Size = New System.Drawing.Size(288, 94)
        Me.GBRango.TabIndex = 15
        Me.GBRango.TabStop = False
        Me.GBRango.Visible = False
        '
        'cbCatalogo
        '
        Me.cbCatalogo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCatalogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCatalogo.Location = New System.Drawing.Point(88, 26)
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.Size = New System.Drawing.Size(424, 23)
        Me.cbCatalogo.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 26)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Cuenta:"
        '
        'cbNiveles
        '
        Me.cbNiveles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNiveles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNiveles.Location = New System.Drawing.Point(88, 60)
        Me.cbNiveles.Name = "cbNiveles"
        Me.cbNiveles.Size = New System.Drawing.Size(424, 23)
        Me.cbNiveles.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(8, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 26)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Niveles:"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.cbCatalogo)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.cbNiveles)
        Me.GroupBox4.Controls.Add(Me.cbMonedaCambio)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Location = New System.Drawing.Point(24, 9)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(520, 133)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'cbMonedaCambio
        '
        Me.cbMonedaCambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonedaCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMonedaCambio.Location = New System.Drawing.Point(88, 95)
        Me.cbMonedaCambio.Name = "cbMonedaCambio"
        Me.cbMonedaCambio.Size = New System.Drawing.Size(424, 23)
        Me.cbMonedaCambio.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(8, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 26)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Moneda:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cmdAyuda)
        Me.GroupBox6.Controls.Add(Me.cmdSalir)
        Me.GroupBox6.Controls.Add(Me.cmdImprimir)
        Me.GroupBox6.Location = New System.Drawing.Point(560, 9)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(112, 477)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Location = New System.Drawing.Point(16, 60)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(80, 26)
        Me.cmdAyuda.TabIndex = 2
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(16, 95)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(80, 26)
        Me.cmdSalir.TabIndex = 1
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(16, 26)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(80, 26)
        Me.cmdImprimir.TabIndex = 0
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'chkComparar
        '
        Me.chkComparar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkComparar.Location = New System.Drawing.Point(24, 309)
        Me.chkComparar.Name = "chkComparar"
        Me.chkComparar.Size = New System.Drawing.Size(168, 26)
        Me.chkComparar.TabIndex = 6
        Me.chkComparar.Text = "Comparar"
        '
        'gbComparar
        '
        Me.gbComparar.Controls.Add(Me.GroupBox3)
        Me.gbComparar.Controls.Add(Me.cbPeriodos2)
        Me.gbComparar.Controls.Add(Me.Label5)
        Me.gbComparar.Controls.Add(Me.GBMes2)
        Me.gbComparar.Controls.Add(Me.GBRango2)
        Me.gbComparar.Enabled = False
        Me.gbComparar.Location = New System.Drawing.Point(24, 331)
        Me.gbComparar.Name = "gbComparar"
        Me.gbComparar.Size = New System.Drawing.Size(520, 155)
        Me.gbComparar.TabIndex = 17
        Me.gbComparar.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkMes2)
        Me.GroupBox3.Controls.Add(Me.ChkRango2)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 52)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 94)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        '
        'chkMes2
        '
        Me.chkMes2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMes2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkMes2.Location = New System.Drawing.Point(16, 43)
        Me.chkMes2.Name = "chkMes2"
        Me.chkMes2.Size = New System.Drawing.Size(96, 26)
        Me.chkMes2.TabIndex = 1
        Me.chkMes2.Text = "Mes"
        '
        'ChkRango2
        '
        Me.ChkRango2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRango2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRango2.Location = New System.Drawing.Point(16, 17)
        Me.ChkRango2.Name = "ChkRango2"
        Me.ChkRango2.Size = New System.Drawing.Size(152, 26)
        Me.ChkRango2.TabIndex = 0
        Me.ChkRango2.Text = "Rango de Fechas"
        '
        'cbPeriodos2
        '
        Me.cbPeriodos2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPeriodos2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPeriodos2.Location = New System.Drawing.Point(88, 17)
        Me.cbPeriodos2.Name = "cbPeriodos2"
        Me.cbPeriodos2.Size = New System.Drawing.Size(424, 23)
        Me.cbPeriodos2.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(16, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 26)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Periodos:"
        '
        'GBMes2
        '
        Me.GBMes2.Controls.Add(Me.Label8)
        Me.GBMes2.Controls.Add(Me.cbMes2)
        Me.GBMes2.Location = New System.Drawing.Point(224, 52)
        Me.GBMes2.Name = "GBMes2"
        Me.GBMes2.Size = New System.Drawing.Size(288, 94)
        Me.GBMes2.TabIndex = 16
        Me.GBMes2.TabStop = False
        Me.GBMes2.Visible = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(16, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 26)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Mes:"
        '
        'cbMes2
        '
        Me.cbMes2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMes2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMes2.Location = New System.Drawing.Point(80, 43)
        Me.cbMes2.Name = "cbMes2"
        Me.cbMes2.Size = New System.Drawing.Size(192, 23)
        Me.cbMes2.TabIndex = 1
        '
        'GBRango2
        '
        Me.GBRango2.Controls.Add(Me.dtpDesde2)
        Me.GBRango2.Controls.Add(Me.Label9)
        Me.GBRango2.Controls.Add(Me.Label10)
        Me.GBRango2.Controls.Add(Me.dtpHasta2)
        Me.GBRango2.Location = New System.Drawing.Point(224, 52)
        Me.GBRango2.Name = "GBRango2"
        Me.GBRango2.Size = New System.Drawing.Size(288, 94)
        Me.GBRango2.TabIndex = 15
        Me.GBRango2.TabStop = False
        Me.GBRango2.Visible = False
        '
        'dtpDesde2
        '
        Me.dtpDesde2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde2.Location = New System.Drawing.Point(88, 17)
        Me.dtpDesde2.Name = "dtpDesde2"
        Me.dtpDesde2.Size = New System.Drawing.Size(104, 20)
        Me.dtpDesde2.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(16, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 26)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Desde:"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(16, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 26)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Hasta:"
        '
        'dtpHasta2
        '
        Me.dtpHasta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta2.Location = New System.Drawing.Point(88, 43)
        Me.dtpHasta2.Name = "dtpHasta2"
        Me.dtpHasta2.Size = New System.Drawing.Size(104, 20)
        Me.dtpHasta2.TabIndex = 1
        '
        'frmRptPresupuesto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(688, 496)
        Me.Controls.Add(Me.chkComparar)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbComparar)
        Me.Name = "frmRptPresupuesto"
        Me.Text = "Reportes - Presupuesto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GBMes.ResumeLayout(False)
        Me.GBRango.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.gbComparar.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GBMes2.ResumeLayout(False)
        Me.GBRango2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmRptPresupuesto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Tasa As New VB.SysContab.Tasa_CambioDB()

        'r.CambiarEstilo(Me)
        i = 0

        cbMonedaCambio.DataSource = Tasa.GetListTasaCambioDisponibles().Tables("Tasa_Cambio")
        cbMonedaCambio.ValueMember = "MonedaCambio"
        cbMonedaCambio.DisplayMember = "Nombre"

        cbCatalogo.DataSource = Presupuesto.GetList_CuentasPresupuesto_Combo().Tables("Presupuesto")
        cbCatalogo.ValueMember = "cuenta"
        cbCatalogo.DisplayMember = "concepto"

        cbNiveles.DataSource = Libros.Niveles().Tables("Niveles")
        cbNiveles.ValueMember = "Nivel"
        cbNiveles.DisplayMember = "Descripcion"

        cbPeriodos.DataSource = Periodos.GetList().Tables("Periodos")
        cbPeriodos.ValueMember = "codigo"
        cbPeriodos.DisplayMember = "descripcion"

        cbPeriodos2.DataSource = Periodos.GetList().Tables("Periodos")
        cbPeriodos2.ValueMember = "codigo"
        cbPeriodos2.DisplayMember = "descripcion"

        Me.chkMes.Checked = True
        chkComparar.Checked = False
        Me.chkMes2.Checked = True
    End Sub


    Private Sub cbPeriodos_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPeriodos.SelectedValueChanged

        Dim Per_Detail As New VB.SysContab.PeriodoDetails()
        Dim Periodo As New VB.SysContab.PeriodosDB()
        Dim tipo As Type
        tipo = Me.cbPeriodos.SelectedValue.GetType

        If tipo.FullName = "System.Data.DataRowView" Then
            Exit Sub
        Else

            'Llenar los datos del groupbox con el rango de fechas
            Per_Detail = Periodo.GetDetails(Me.cbPeriodos.SelectedValue)
            If Per_Detail.ID Is Nothing Or Per_Detail.ID = 0 Then
                ' MsgBox("No existe el código de Periodo Fiscal seleccionado", MsgBoxStyle.Critical)
                Exit Sub
            Else
                If Per_Detail.Inicio < Me.dtpDesde.MinDate Then

                    Me.dtpDesde.MinDate = Per_Detail.Inicio.Date
                    Me.dtpDesde.MaxDate = Per_Detail.Final.Date
                    Me.dtpDesde.Value = Per_Detail.Inicio.Date

                    Me.dtpHasta.MinDate = Per_Detail.Inicio.Date
                    Me.dtpHasta.MaxDate = Per_Detail.Final.Date
                    Me.dtpHasta.Value = Per_Detail.Final.Date
                Else
                    Me.dtpDesde.MaxDate = Per_Detail.Final.Date
                    Me.dtpDesde.MinDate = Per_Detail.Inicio.Date
                    Me.dtpDesde.Value = Per_Detail.Inicio.Date

                    Me.dtpHasta.MaxDate = Per_Detail.Final.Date
                    Me.dtpHasta.MinDate = Per_Detail.Inicio.Date
                    Me.dtpHasta.Value = Per_Detail.Final.Date
                End If
            End If
            'Llenar los datos de los meses del periodo
            Dim anio, aniofinal, i As Integer
            anio = Format(Per_Detail.Inicio, "yyyy") + Format(Per_Detail.Inicio, "MM")
            aniofinal = Format(Per_Detail.Final, "yyyy") + Format(Per_Detail.Final, "MM")
            i = 1
            Me.cbMes.Items.Clear()
            Do While anio <= aniofinal
                Me.cbMes.Items.Add(Microsoft.VisualBasic.Left(anio, 4) & "-" & Format(DateAdd(DateInterval.Month, i - 1, Per_Detail.Inicio), "MM")) 'Format(DateAdd(DateInterval.Month, i - 1, Per_Detail.Inicio), "MMMM")
                anio = Format(DateAdd(DateInterval.Month, i, Per_Detail.Inicio), "yyyy") + Format(DateAdd(DateInterval.Month, i, Per_Detail.Inicio), "MM")
                i = i + 1
            Loop
            Me.cbMes.SelectedItem = Format(Per_Detail.Inicio, "yyyy") & "-" & Format(Per_Detail.Inicio, "MM")
            If Me.GBMes.Visible = True Then
                Me.dtpDesde.Value = New DateTime(Microsoft.VisualBasic.Left(Me.cbMes.SelectedItem, 4), Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2), 1)
                Me.dtpHasta.Value = New DateTime(Microsoft.VisualBasic.Left(Me.cbMes.SelectedItem, 4), Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2), Str(Meses(Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2) - 1)))
            End If

        End If
    End Sub

    Private Sub cbPeriodos2_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPeriodos2.SelectedValueChanged
        Dim Per_Detail As New VB.SysContab.PeriodoDetails()
        Dim Periodo As New VB.SysContab.PeriodosDB()
        Dim tipo As Type
        tipo = Me.cbPeriodos2.SelectedValue.GetType

        If tipo.FullName = "System.Data.DataRowView" Then
            Exit Sub
        Else
            'Llenar los datos del groupbox con el rango de fechas
            Per_Detail = Periodo.GetDetails(Me.cbPeriodos2.SelectedValue)
            If Per_Detail.ID Is Nothing Or Per_Detail.ID = 0 Then
                ' MsgBox("No existe el código de Periodo Fiscal seleccionado", MsgBoxStyle.Critical)
                Exit Sub
            Else
                If Per_Detail.Inicio < Me.dtpDesde2.MinDate Then

                    Me.dtpDesde2.MinDate = Per_Detail.Inicio.Date
                    Me.dtpDesde2.MaxDate = Per_Detail.Final.Date
                    Me.dtpDesde2.Value = Per_Detail.Inicio.Date

                    Me.dtpHasta2.MinDate = Per_Detail.Inicio.Date
                    Me.dtpHasta2.MaxDate = Per_Detail.Final.Date
                    Me.dtpHasta2.Value = Per_Detail.Final.Date
                Else
                    Me.dtpDesde2.MaxDate = Per_Detail.Final.Date
                    Me.dtpDesde2.MinDate = Per_Detail.Inicio.Date
                    Me.dtpDesde2.Value = Per_Detail.Inicio.Date

                    Me.dtpHasta2.MaxDate = Per_Detail.Final.Date
                    Me.dtpHasta2.MinDate = Per_Detail.Inicio.Date
                    Me.dtpHasta2.Value = Per_Detail.Final.Date
                End If
            End If
            'Llenar los datos de los meses del periodo
            Dim anio, aniofinal, i As Integer
            anio = Format(Per_Detail.Inicio, "yyyy") + Format(Per_Detail.Inicio, "MM")
            aniofinal = Format(Per_Detail.Final, "yyyy") + Format(Per_Detail.Final, "MM")
            i = 1
            Me.cbMes2.Items.Clear()
            Do While anio <= aniofinal
                Me.cbMes2.Items.Add(Microsoft.VisualBasic.Left(anio, 4) & "-" & Format(DateAdd(DateInterval.Month, i - 1, Per_Detail.Inicio), "MM")) 'Format(DateAdd(DateInterval.Month, i - 1, Per_Detail.Inicio), "MMMM")
                anio = Format(DateAdd(DateInterval.Month, i, Per_Detail.Inicio), "yyyy") + Format(DateAdd(DateInterval.Month, i, Per_Detail.Inicio), "MM")
                i = i + 1
            Loop
            Me.cbMes2.SelectedItem = Format(Per_Detail.Inicio, "yyyy") & "-" & Format(Per_Detail.Inicio, "MM")
            If Me.GBMes.Visible = True Then
               Me.dtpDesde2.Value = New DateTime(Microsoft.VisualBasic.Left(Me.cbMes2.SelectedItem, 4), Microsoft.VisualBasic.Right(Me.cbMes2.SelectedItem, 2), 1)
                Me.dtpHasta2.Value = New DateTime(Microsoft.VisualBasic.Left(Me.cbMes2.SelectedItem, 4), Microsoft.VisualBasic.Right(Me.cbMes2.SelectedItem, 2), Str(Meses(Microsoft.VisualBasic.Right(Me.cbMes2.SelectedItem, 2) - 1)))

            End If

        End If
    End Sub
    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim fReportes As New frmReportes
        Dim Presupuesto As New VB.SysContab.PresupuestoDB
        Dim r As New VB.SysContab.Rutinas

        Dim ds As New DataSet
        Dim cPresupuesto As Integer

        ds = Presupuesto.GetPresupuesto_Activo()
        If ds.Tables(0).Rows.Count = 1 Then
            cPresupuesto = ds.Tables(0).Rows(0)("pre_codigo")
        Else
            MsgBox("No hay presupuesto activo para esta empresa", MsgBoxStyle.Critical, "SysContab")
            Exit Sub
        End If

        ds.Clear()
        ds = VB.SysContab.PresupuestoDB.GetListReporte_Filtro(Me.cbCatalogo.SelectedValue, _
            IIf(Me.cbNiveles.SelectedValue = "%", Me.cbNiveles.Items(Me.cbNiveles.Items.Count - 1).row.itemarray(0), Me.cbNiveles.SelectedValue), _
                Me.cbMonedaCambio.SelectedValue, _
                Me.cbPeriodos.SelectedValue, _
                Me.dtpDesde.Value.Date, _
                Me.dtpHasta.Value.Date, _
                Me.cbPeriodos2.SelectedValue, _
                Me.dtpDesde2.Value.Date, _
                Me.dtpHasta2.Value.Date)

        ds.WriteXml(Application.StartupPath & "\xml\PreFiltro_Comp.xml", XmlWriteMode.WriteSchema)

        If Me.chkComparar.Checked Then
            '            Dim Reporte As New rptPresupuestoFiltro_Comparativo

            Dim Reporte As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Reporte.Load(Application.StartupPath & "\Reportes\rptPresupuestoFiltro_Comparativo.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            '
            'Reporte.SetParameterValue("@Empresa", EmpresaActual)
            'Reporte.SetParameterValue("@PerID", Me.cbPeriodos.SelectedValue)
            'Reporte.SetParameterValue("@Desde", Me.dtpDesde.Value.Date)
            'Reporte.SetParameterValue("@Hasta", Me.dtpHasta.Value.Date)
            'Reporte.SetParameterValue("@Cuenta", Me.cbCatalogo.SelectedValue)
            'Reporte.SetParameterValue("@Nivel", IIf(Me.cbNiveles.SelectedValue = "%", Me.cbNiveles.Items(Me.cbNiveles.Items.Count - 1).row.itemarray(0), Me.cbNiveles.SelectedValue))
            'Reporte.SetParameterValue("@Moneda", Me.cbMonedaCambio.SelectedValue)
            'Reporte.SetParameterValue("@PerID2", Me.cbPeriodos2.SelectedValue)
            'Reporte.SetParameterValue("@Desde2", Me.dtpDesde2.Value.Date)
            'Reporte.SetParameterValue("@Hasta2", Me.dtpHasta2.Value.Date)

            reporte.Database.Tables(0).Location = Application.StartupPath & "\xml\PreFiltro_Comp.xml"
            fReportes.crvReportes.ReportSource = Reporte
        Else
            'Dim Reporte As New rptPresupuestoFiltro

            Dim Reporte As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Reporte.Load(Application.StartupPath & "\Reportes\rptPresupuestoFiltro.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)


            ''Reporte.SetParameterValue("@Empresa", EmpresaActual)
            ''Reporte.SetParameterValue("@PerID", Me.cbPeriodos.SelectedValue)
            ''Reporte.SetParameterValue("@Desde", Me.dtpDesde.Value.Date)
            ''Reporte.SetParameterValue("@Hasta", Me.dtpHasta.Value.Date)
            ''Reporte.SetParameterValue("@Cuenta", Me.cbCatalogo.SelectedValue)
            ''Reporte.SetParameterValue("@Nivel", IIf(Me.cbNiveles.SelectedValue = "%", Me.cbNiveles.Items(Me.cbNiveles.Items.Count - 1).row.itemarray(0), Me.cbNiveles.SelectedValue))
            ''Reporte.SetParameterValue("@Moneda", Me.cbMonedaCambio.SelectedValue)
            ''Reporte.SetParameterValue("@PerID2", Me.cbPeriodos2.SelectedValue)
            ''Reporte.SetParameterValue("@Desde2", Me.dtpDesde2.Value.Date)
            ''Reporte.SetParameterValue("@Hasta2", Me.dtpHasta2.Value.Date)
            reporte.Database.Tables(0).Location = Application.StartupPath & "\xml\PreFiltro_Comp.xml"
            fReportes.crvReportes.ReportSource = Reporte
        End If



        fReportes.Show()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cbMes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMes.SelectedIndexChanged
        Me.dtpDesde.Value = New DateTime(Microsoft.VisualBasic.Left(Me.cbMes.SelectedItem, 4), Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2), 1)  'CDate("01/" & Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2) & "/" & Microsoft.VisualBasic.Left(Me.cbMes.SelectedItem, 4))
        Me.dtpHasta.Value = New DateTime(Microsoft.VisualBasic.Left(Me.cbMes.SelectedItem, 4), Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2), Str(Meses(Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2) - 1)))  'CDate(Str(Meses(Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2) - 1)) & "/" & Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2) & "/" & Microsoft.VisualBasic.Left(Me.cbMes.SelectedItem, 4))
    End Sub
    Private Sub cbMes2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMes2.SelectedIndexChanged
        Me.dtpDesde2.Value = New DateTime(Microsoft.VisualBasic.Left(Me.cbMes2.SelectedItem, 4), Microsoft.VisualBasic.Right(Me.cbMes2.SelectedItem, 2), 1) 'CDate("01/" & Microsoft.VisualBasic.Right(Me.cbMes2.SelectedItem, 2) & "/" & Microsoft.VisualBasic.Left(Me.cbMes2.SelectedItem, 4))
        Me.dtpHasta2.Value = New DateTime(Microsoft.VisualBasic.Left(Me.cbMes2.SelectedItem, 4), Microsoft.VisualBasic.Right(Me.cbMes2.SelectedItem, 2), Str(Meses(Microsoft.VisualBasic.Right(Me.cbMes2.SelectedItem, 2) - 1)))  'CDate(Str(Meses(Microsoft.VisualBasic.Right(Me.cbMes2.SelectedItem, 2) - 1)) & "/" & Microsoft.VisualBasic.Right(Me.cbMes2.SelectedItem, 2) & "/" & Microsoft.VisualBasic.Left(Me.cbMes2.SelectedItem, 4))
    End Sub
    Private Sub chkMes_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMes.CheckedChanged
        If Me.chkMes.Checked Then
            Me.GBMes.Visible = True
            Me.GBRango.Visible = False
            Me.ChkRango.Checked = False
        Else
            Me.GBMes.Visible = False
            Me.GBRango.Visible = True
            Me.ChkRango.Checked = True
        End If
    End Sub
    Private Sub chkMes2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMes2.CheckedChanged
        If Me.chkMes2.Checked Then
            Me.GBMes2.Visible = True
            Me.GBRango2.Visible = False
            Me.ChkRango2.Checked = False
        Else
            Me.GBMes2.Visible = False
            Me.GBRango2.Visible = True
            Me.ChkRango2.Checked = True
        End If
    End Sub
    Private Sub ChkRango_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkRango.CheckedChanged
        If Me.ChkRango.Checked Then
            Me.GBMes.Visible = False
            Me.GBRango.Visible = True
            Me.chkMes.Checked = False
        Else
            Me.GBMes.Visible = True
            Me.GBRango.Visible = False
            Me.chkMes.Checked = True
        End If
    End Sub
    Private Sub ChkRango2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkRango2.CheckedChanged
        If Me.ChkRango2.Checked Then
            Me.GBMes2.Visible = False
            Me.GBRango2.Visible = True
            Me.chkMes2.Checked = False
        Else
            Me.GBMes2.Visible = True
            Me.GBRango2.Visible = False
            Me.chkMes2.Checked = True
        End If
    End Sub



    Private Sub chkComparar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkComparar.CheckedChanged
        Me.gbComparar.Enabled = chkComparar.Checked
    End Sub


    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/Reportes/ReportesPresupuesto.chm")
    End Sub
End Class
