

Public Class frmRptControlPanel
    Inherits DevExpress.XtraEditors.XtraForm

    Dim Periodos As New VB.SysContab.PeriodosDB()
    Dim Per_Detail As New VB.SysContab.PeriodoDetails()

    Dim Tasa As New VB.SysContab.Tasa_CambioDB()
    Dim Empresas As New VB.SysContab.EmpresasDetails()
    Dim Libros As New VB.SysContab.LibrosDB()
    Dim bancos As New VB.SysContab.BancosDB()
    Dim Compras As New VB.SysContab.Facturas_ComprasDB()
    Dim Clientes As New VB.SysContab.ClientesDB()


    Dim Emp As New VB.SysContab.EmpresasDB()
    Private Shared ChildInstance As frmRptControlPanel = Nothing

    Public Shared Function Instance() As frmRptControlPanel
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmRptControlPanel()
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
    Friend WithEvents chk1 As System.Windows.Forms.CheckBox
    Friend WithEvents chk2 As System.Windows.Forms.CheckBox
    Friend WithEvents chk4 As System.Windows.Forms.CheckBox
    Friend WithEvents chk3 As System.Windows.Forms.CheckBox
    Friend WithEvents chk8 As System.Windows.Forms.CheckBox
    Friend WithEvents chk7 As System.Windows.Forms.CheckBox
    Friend WithEvents chk6 As System.Windows.Forms.CheckBox
    Friend WithEvents chk5 As System.Windows.Forms.CheckBox
    Friend WithEvents chk14 As System.Windows.Forms.CheckBox
    Friend WithEvents chk13 As System.Windows.Forms.CheckBox
    Friend WithEvents chk12 As System.Windows.Forms.CheckBox
    Friend WithEvents chk11 As System.Windows.Forms.CheckBox
    Friend WithEvents chk10 As System.Windows.Forms.CheckBox
    Friend WithEvents chk9 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Chk16 As System.Windows.Forms.CheckBox
    Friend WithEvents chk15 As System.Windows.Forms.CheckBox
    Friend WithEvents Chk17 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents chkMes As System.Windows.Forms.CheckBox
    Friend WithEvents ChkRango As System.Windows.Forms.CheckBox
    Friend WithEvents cbPeriodos As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GBMes As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbMes As System.Windows.Forms.ComboBox
    Friend WithEvents GBRango As System.Windows.Forms.GroupBox
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbNiveles As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbMonedaCambio As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chk_Memoria As System.Windows.Forms.CheckBox
    Friend WithEvents gbBanco As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbBancos As System.Windows.Forms.ComboBox
    Friend WithEvents chk18 As System.Windows.Forms.CheckBox
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRptControlPanel))
        Me.chk1 = New System.Windows.Forms.CheckBox
        Me.chk2 = New System.Windows.Forms.CheckBox
        Me.chk4 = New System.Windows.Forms.CheckBox
        Me.chk3 = New System.Windows.Forms.CheckBox
        Me.chk8 = New System.Windows.Forms.CheckBox
        Me.chk7 = New System.Windows.Forms.CheckBox
        Me.chk6 = New System.Windows.Forms.CheckBox
        Me.chk5 = New System.Windows.Forms.CheckBox
        Me.chk14 = New System.Windows.Forms.CheckBox
        Me.chk13 = New System.Windows.Forms.CheckBox
        Me.chk12 = New System.Windows.Forms.CheckBox
        Me.chk11 = New System.Windows.Forms.CheckBox
        Me.chk10 = New System.Windows.Forms.CheckBox
        Me.chk9 = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chk18 = New System.Windows.Forms.CheckBox
        Me.Chk16 = New System.Windows.Forms.CheckBox
        Me.chk15 = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Chk17 = New System.Windows.Forms.CheckBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.chkMes = New System.Windows.Forms.CheckBox
        Me.ChkRango = New System.Windows.Forms.CheckBox
        Me.cbPeriodos = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GBMes = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbMes = New System.Windows.Forms.ComboBox
        Me.GBRango = New System.Windows.Forms.GroupBox
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker
        Me.cbNiveles = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbMonedaCambio = New System.Windows.Forms.ComboBox
        Me.chk_Memoria = New System.Windows.Forms.CheckBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.gbBanco = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbBancos = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GBMes.SuspendLayout()
        Me.GBRango.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.gbBanco.SuspendLayout()
        Me.SuspendLayout()
        '
        'chk1
        '
        Me.chk1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk1.ForeColor = System.Drawing.Color.Maroon
        Me.chk1.Image = CType(resources.GetObject("chk1.Image"), System.Drawing.Image)
        Me.chk1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chk1.Location = New System.Drawing.Point(8, 24)
        Me.chk1.Name = "chk1"
        Me.chk1.Size = New System.Drawing.Size(248, 56)
        Me.chk1.TabIndex = 0
        Me.chk1.Text = "COMPROBANTES"
        Me.chk1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk2
        '
        Me.chk2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk2.ForeColor = System.Drawing.Color.Maroon
        Me.chk2.Image = CType(resources.GetObject("chk2.Image"), System.Drawing.Image)
        Me.chk2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chk2.Location = New System.Drawing.Point(8, 80)
        Me.chk2.Name = "chk2"
        Me.chk2.Size = New System.Drawing.Size(248, 56)
        Me.chk2.TabIndex = 1
        Me.chk2.Text = "DIARIO"
        Me.chk2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk4
        '
        Me.chk4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk4.ForeColor = System.Drawing.Color.Maroon
        Me.chk4.Image = CType(resources.GetObject("chk4.Image"), System.Drawing.Image)
        Me.chk4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chk4.Location = New System.Drawing.Point(8, 192)
        Me.chk4.Name = "chk4"
        Me.chk4.Size = New System.Drawing.Size(248, 56)
        Me.chk4.TabIndex = 3
        Me.chk4.Text = "BALANCE"
        Me.chk4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk3
        '
        Me.chk3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk3.ForeColor = System.Drawing.Color.Maroon
        Me.chk3.Image = CType(resources.GetObject("chk3.Image"), System.Drawing.Image)
        Me.chk3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chk3.Location = New System.Drawing.Point(8, 136)
        Me.chk3.Name = "chk3"
        Me.chk3.Size = New System.Drawing.Size(248, 56)
        Me.chk3.TabIndex = 2
        Me.chk3.Text = "MAYOR AUXILIAR"
        Me.chk3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk8
        '
        Me.chk8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk8.ForeColor = System.Drawing.Color.Maroon
        Me.chk8.Image = CType(resources.GetObject("chk8.Image"), System.Drawing.Image)
        Me.chk8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chk8.Location = New System.Drawing.Point(8, 416)
        Me.chk8.Name = "chk8"
        Me.chk8.Size = New System.Drawing.Size(248, 56)
        Me.chk8.TabIndex = 7
        Me.chk8.Text = "FLUJO DE CAJA"
        Me.chk8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk7
        '
        Me.chk7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk7.ForeColor = System.Drawing.Color.Maroon
        Me.chk7.Image = CType(resources.GetObject("chk7.Image"), System.Drawing.Image)
        Me.chk7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chk7.Location = New System.Drawing.Point(8, 360)
        Me.chk7.Name = "chk7"
        Me.chk7.Size = New System.Drawing.Size(248, 56)
        Me.chk7.TabIndex = 6
        Me.chk7.Text = "BANCOS"
        Me.chk7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk6
        '
        Me.chk6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk6.ForeColor = System.Drawing.Color.Maroon
        Me.chk6.Image = CType(resources.GetObject("chk6.Image"), System.Drawing.Image)
        Me.chk6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chk6.Location = New System.Drawing.Point(8, 304)
        Me.chk6.Name = "chk6"
        Me.chk6.Size = New System.Drawing.Size(248, 56)
        Me.chk6.TabIndex = 5
        Me.chk6.Text = "ESTADO DE RESULTADO"
        Me.chk6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk5
        '
        Me.chk5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk5.ForeColor = System.Drawing.Color.Maroon
        Me.chk5.Image = CType(resources.GetObject("chk5.Image"), System.Drawing.Image)
        Me.chk5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chk5.Location = New System.Drawing.Point(8, 248)
        Me.chk5.Name = "chk5"
        Me.chk5.Size = New System.Drawing.Size(248, 56)
        Me.chk5.TabIndex = 4
        Me.chk5.Text = "ESTADO DE SITUACION"
        Me.chk5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk14
        '
        Me.chk14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk14.ForeColor = System.Drawing.Color.Maroon
        Me.chk14.Image = CType(resources.GetObject("chk14.Image"), System.Drawing.Image)
        Me.chk14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chk14.Location = New System.Drawing.Point(8, 408)
        Me.chk14.Name = "chk14"
        Me.chk14.Size = New System.Drawing.Size(248, 40)
        Me.chk14.TabIndex = 13
        Me.chk14.Text = "I.R."
        Me.chk14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk13
        '
        Me.chk13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk13.ForeColor = System.Drawing.Color.Maroon
        Me.chk13.Image = CType(resources.GetObject("chk13.Image"), System.Drawing.Image)
        Me.chk13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chk13.Location = New System.Drawing.Point(8, 296)
        Me.chk13.Name = "chk13"
        Me.chk13.Size = New System.Drawing.Size(248, 56)
        Me.chk13.TabIndex = 12
        Me.chk13.Text = "VENTAS"
        Me.chk13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk12
        '
        Me.chk12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk12.ForeColor = System.Drawing.Color.Maroon
        Me.chk12.Image = CType(resources.GetObject("chk12.Image"), System.Drawing.Image)
        Me.chk12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chk12.Location = New System.Drawing.Point(8, 240)
        Me.chk12.Name = "chk12"
        Me.chk12.Size = New System.Drawing.Size(248, 56)
        Me.chk12.TabIndex = 11
        Me.chk12.Text = "CUENTAS X COBRAR"
        Me.chk12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk11
        '
        Me.chk11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk11.ForeColor = System.Drawing.Color.Maroon
        Me.chk11.Image = CType(resources.GetObject("chk11.Image"), System.Drawing.Image)
        Me.chk11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chk11.Location = New System.Drawing.Point(8, 192)
        Me.chk11.Name = "chk11"
        Me.chk11.Size = New System.Drawing.Size(248, 56)
        Me.chk11.TabIndex = 10
        Me.chk11.Text = "INVENTARIO"
        Me.chk11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk10
        '
        Me.chk10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk10.ForeColor = System.Drawing.Color.Maroon
        Me.chk10.Image = CType(resources.GetObject("chk10.Image"), System.Drawing.Image)
        Me.chk10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chk10.Location = New System.Drawing.Point(8, 80)
        Me.chk10.Name = "chk10"
        Me.chk10.Size = New System.Drawing.Size(248, 56)
        Me.chk10.TabIndex = 9
        Me.chk10.Text = "COMPRAS"
        Me.chk10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk9
        '
        Me.chk9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk9.ForeColor = System.Drawing.Color.Maroon
        Me.chk9.Image = CType(resources.GetObject("chk9.Image"), System.Drawing.Image)
        Me.chk9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chk9.Location = New System.Drawing.Point(8, 24)
        Me.chk9.Name = "chk9"
        Me.chk9.Size = New System.Drawing.Size(248, 56)
        Me.chk9.TabIndex = 8
        Me.chk9.Text = "CUENTAS X PAGAR"
        Me.chk9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk7)
        Me.GroupBox1.Controls.Add(Me.chk2)
        Me.GroupBox1.Controls.Add(Me.chk6)
        Me.GroupBox1.Controls.Add(Me.chk3)
        Me.GroupBox1.Controls.Add(Me.chk4)
        Me.GroupBox1.Controls.Add(Me.chk1)
        Me.GroupBox1.Controls.Add(Me.chk8)
        Me.GroupBox1.Controls.Add(Me.chk5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 504)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contabilidad"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk18)
        Me.GroupBox2.Controls.Add(Me.chk14)
        Me.GroupBox2.Controls.Add(Me.chk13)
        Me.GroupBox2.Controls.Add(Me.chk10)
        Me.GroupBox2.Controls.Add(Me.chk11)
        Me.GroupBox2.Controls.Add(Me.chk9)
        Me.GroupBox2.Controls.Add(Me.chk12)
        Me.GroupBox2.Controls.Add(Me.Chk16)
        Me.GroupBox2.Controls.Add(Me.chk15)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(704, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(264, 504)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gestión Comercial"
        '
        'chk18
        '
        Me.chk18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk18.ForeColor = System.Drawing.Color.Maroon
        Me.chk18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chk18.Location = New System.Drawing.Point(8, 456)
        Me.chk18.Name = "chk18"
        Me.chk18.Size = New System.Drawing.Size(248, 40)
        Me.chk18.TabIndex = 14
        Me.chk18.Text = "I.V.A."
        Me.chk18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Chk16
        '
        Me.Chk16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk16.ForeColor = System.Drawing.Color.Maroon
        Me.Chk16.Image = CType(resources.GetObject("Chk16.Image"), System.Drawing.Image)
        Me.Chk16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Chk16.Location = New System.Drawing.Point(8, 136)
        Me.Chk16.Name = "Chk16"
        Me.Chk16.Size = New System.Drawing.Size(248, 56)
        Me.Chk16.TabIndex = 9
        Me.Chk16.Text = "SALDOS PROVEEDORES"
        Me.Chk16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk15
        '
        Me.chk15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk15.ForeColor = System.Drawing.Color.Maroon
        Me.chk15.Image = CType(resources.GetObject("chk15.Image"), System.Drawing.Image)
        Me.chk15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chk15.Location = New System.Drawing.Point(8, 352)
        Me.chk15.Name = "chk15"
        Me.chk15.Size = New System.Drawing.Size(248, 56)
        Me.chk15.TabIndex = 8
        Me.chk15.Text = "SALDOS CLIENTES"
        Me.chk15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Chk17)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(280, 432)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(416, 88)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Resumen"
        '
        'Chk17
        '
        Me.Chk17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk17.ForeColor = System.Drawing.Color.Maroon
        Me.Chk17.Image = CType(resources.GetObject("Chk17.Image"), System.Drawing.Image)
        Me.Chk17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Chk17.Location = New System.Drawing.Point(80, 24)
        Me.Chk17.Name = "Chk17"
        Me.Chk17.Size = New System.Drawing.Size(248, 56)
        Me.Chk17.TabIndex = 10
        Me.Chk17.Text = "RESUMEN GENERAL"
        Me.Chk17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox8)
        Me.GroupBox4.Controls.Add(Me.cbPeriodos)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.GBMes)
        Me.GroupBox4.Controls.Add(Me.GBRango)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(400, 144)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.chkMes)
        Me.GroupBox8.Controls.Add(Me.ChkRango)
        Me.GroupBox8.Location = New System.Drawing.Point(8, 48)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(176, 88)
        Me.GroupBox8.TabIndex = 14
        Me.GroupBox8.TabStop = False
        '
        'chkMes
        '
        Me.chkMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMes.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.chkMes.Location = New System.Drawing.Point(16, 40)
        Me.chkMes.Name = "chkMes"
        Me.chkMes.Size = New System.Drawing.Size(96, 24)
        Me.chkMes.TabIndex = 1
        Me.chkMes.Text = "Mes"
        '
        'ChkRango
        '
        Me.ChkRango.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRango.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.ChkRango.Location = New System.Drawing.Point(16, 16)
        Me.ChkRango.Name = "ChkRango"
        Me.ChkRango.Size = New System.Drawing.Size(152, 24)
        Me.ChkRango.TabIndex = 0
        Me.ChkRango.Text = "Rango de Fechas"
        '
        'cbPeriodos
        '
        Me.cbPeriodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPeriodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPeriodos.Location = New System.Drawing.Point(88, 16)
        Me.cbPeriodos.Name = "cbPeriodos"
        Me.cbPeriodos.Size = New System.Drawing.Size(304, 23)
        Me.cbPeriodos.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 24)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Periodos:"
        '
        'GBMes
        '
        Me.GBMes.Controls.Add(Me.Label7)
        Me.GBMes.Controls.Add(Me.cbMes)
        Me.GBMes.Location = New System.Drawing.Point(192, 48)
        Me.GBMes.Name = "GBMes"
        Me.GBMes.Size = New System.Drawing.Size(200, 88)
        Me.GBMes.TabIndex = 16
        Me.GBMes.TabStop = False
        Me.GBMes.Visible = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 24)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Mes:"
        '
        'cbMes
        '
        Me.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMes.Location = New System.Drawing.Point(56, 40)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(136, 23)
        Me.cbMes.TabIndex = 1
        '
        'GBRango
        '
        Me.GBRango.Controls.Add(Me.dtpDesde)
        Me.GBRango.Controls.Add(Me.Label1)
        Me.GBRango.Controls.Add(Me.Label2)
        Me.GBRango.Controls.Add(Me.dtpHasta)
        Me.GBRango.Location = New System.Drawing.Point(192, 48)
        Me.GBRango.Name = "GBRango"
        Me.GBRango.Size = New System.Drawing.Size(200, 88)
        Me.GBRango.TabIndex = 15
        Me.GBRango.TabStop = False
        Me.GBRango.Visible = False
        '
        'dtpDesde
        '
        Me.dtpDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpDesde.Location = New System.Drawing.Point(72, 16)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(104, 20)
        Me.dtpDesde.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 24)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Desde:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 24)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Hasta:"
        '
        'dtpHasta
        '
        Me.dtpHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpHasta.Location = New System.Drawing.Point(72, 40)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(104, 20)
        Me.dtpHasta.TabIndex = 1
        '
        'cbNiveles
        '
        Me.cbNiveles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNiveles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNiveles.Location = New System.Drawing.Point(840, 504)
        Me.cbNiveles.Name = "cbNiveles"
        Me.cbNiveles.Size = New System.Drawing.Size(168, 23)
        Me.cbNiveles.TabIndex = 31
        Me.cbNiveles.Visible = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label9.Location = New System.Drawing.Point(952, 480)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 24)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Niveles:"
        Me.Label9.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.cbMonedaCambio)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 160)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(400, 56)
        Me.GroupBox5.TabIndex = 33
        Me.GroupBox5.TabStop = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 24)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Moneda:"
        '
        'cbMonedaCambio
        '
        Me.cbMonedaCambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonedaCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMonedaCambio.Location = New System.Drawing.Point(104, 24)
        Me.cbMonedaCambio.Name = "cbMonedaCambio"
        Me.cbMonedaCambio.Size = New System.Drawing.Size(288, 23)
        Me.cbMonedaCambio.TabIndex = 0
        '
        'chk_Memoria
        '
        Me.chk_Memoria.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chk_Memoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Memoria.Location = New System.Drawing.Point(8, 27)
        Me.chk_Memoria.Name = "chk_Memoria"
        Me.chk_Memoria.Size = New System.Drawing.Size(136, 24)
        Me.chk_Memoria.TabIndex = 34
        Me.chk_Memoria.Text = "Memoria"
        Me.chk_Memoria.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.GroupBox7)
        Me.GroupBox6.Controls.Add(Me.GroupBox4)
        Me.GroupBox6.Controls.Add(Me.GroupBox5)
        Me.GroupBox6.Controls.Add(Me.gbBanco)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox6.Location = New System.Drawing.Point(280, 16)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(416, 408)
        Me.GroupBox6.TabIndex = 35
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Parámetros"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.cmdAyuda)
        Me.GroupBox7.Controls.Add(Me.btnImprimir)
        Me.GroupBox7.Controls.Add(Me.chk_Memoria)
        Me.GroupBox7.Controls.Add(Me.btnSalir)
        Me.GroupBox7.Location = New System.Drawing.Point(8, 344)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(400, 56)
        Me.GroupBox7.TabIndex = 37
        Me.GroupBox7.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAyuda.Location = New System.Drawing.Point(208, 16)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(88, 32)
        Me.cmdAyuda.TabIndex = 37
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'btnImprimir
        '
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Location = New System.Drawing.Point(119, 16)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(88, 32)
        Me.btnImprimir.TabIndex = 35
        Me.btnImprimir.Text = "&Imprimir"
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(304, 16)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(88, 32)
        Me.btnSalir.TabIndex = 36
        Me.btnSalir.Text = "&Salir"
        '
        'gbBanco
        '
        Me.gbBanco.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.gbBanco.Controls.Add(Me.Label3)
        Me.gbBanco.Controls.Add(Me.cbBancos)
        Me.gbBanco.Location = New System.Drawing.Point(8, 224)
        Me.gbBanco.Name = "gbBanco"
        Me.gbBanco.Size = New System.Drawing.Size(400, 64)
        Me.gbBanco.TabIndex = 34
        Me.gbBanco.TabStop = False
        Me.gbBanco.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Banco:"
        '
        'cbBancos
        '
        Me.cbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBancos.Location = New System.Drawing.Point(104, 24)
        Me.cbBancos.Name = "cbBancos"
        Me.cbBancos.Size = New System.Drawing.Size(288, 23)
        Me.cbBancos.TabIndex = 0
        '
        'frmRptControlPanel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(1016, 526)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbNiveles)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmRptControlPanel"
        Me.Text = "Seleccion de Reportes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GBMes.ResumeLayout(False)
        Me.GBRango.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.gbBanco.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim r As New VB.SysContab.Rutinas()

    Private Sub frmRptControlPanel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Empresas = Emp.GetDetails(EmpresaActual)


        cbMonedaCambio.DataSource = Tasa.GetListTasaCambioDisponibles().Tables("Tasa_Cambio")
        cbMonedaCambio.ValueMember = "MonedaCambio"
        cbMonedaCambio.DisplayMember = "Nombre"

        cbPeriodos.DataSource = Periodos.GetList().Tables("Periodos")
        cbPeriodos.ValueMember = "codigo"
        cbPeriodos.DisplayMember = "descripcion"

        cbBancos.DataSource = bancos.GetListBancosCombo().Tables("Bancos")
        cbBancos.ValueMember = "Cuenta"
        cbBancos.DisplayMember = "Nombre"

        cbNiveles.DataSource = Libros.Niveles().Tables("Niveles") 'Grupos.GetList_SP("%").Tables("Niveles")
        cbNiveles.ValueMember = "Nivel"
        cbNiveles.DisplayMember = "Descripcion"
        Me.chkMes.Checked = True

        Dim Periodo
        Periodo = VB.SysContab.PeriodosDB.Actual
        If Periodo <> 0 Then
            Me.cbPeriodos.SelectedValue = Periodo
            Per_Detail = Periodos.GetDetails(Me.cbPeriodos.SelectedValue)
            If Per_Detail.Inicio.Year = CDate(r.Fecha).Year And Per_Detail.Inicio.Month <= CDate(r.Fecha).Month Then
                Me.cbMes.SelectedItem = Format(CDate(r.Fecha), "yyyy") & "-" & Format(CDate(r.Fecha), "MM")
            ElseIf Per_Detail.Final.Year = CDate(r.Fecha).Year And Per_Detail.Final.Month >= CDate(r.Fecha).Month Then
                Me.cbMes.SelectedItem = Format(CDate(r.Fecha), "yyyy") & "-" & Format(CDate(r.Fecha), "MM")
            Else
                Me.cbMes.SelectedItem = Format(Per_Detail.Inicio, "yyyy") & "-" & Format(Per_Detail.Inicio, "MM")
            End If
        End If

    End Sub

    Private Sub cbPeriodos_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPeriodos.SelectedValueChanged
        Dim tipo As Type
        tipo = Me.cbPeriodos.SelectedValue.GetType

        If tipo.FullName = "System.Data.DataRowView" Then
            Exit Sub
        Else
            'Llenar los datos del groupbox con el rango de fechas
            Per_Detail = Periodos.GetDetails(Me.cbPeriodos.SelectedValue)
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
            If Per_Detail.Inicio.Year = CDate(r.Fecha).Year And Per_Detail.Inicio.Month <= CDate(r.Fecha).Month Then
                Me.cbMes.SelectedItem = Format(CDate(r.Fecha), "yyyy") & "-" & Format(CDate(r.Fecha), "MM")
            ElseIf Per_Detail.Final.Year = CDate(r.Fecha).Year And Per_Detail.Final.Month >= CDate(r.Fecha).Month Then
                Me.cbMes.SelectedItem = Format(CDate(r.Fecha), "yyyy") & "-" & Format(CDate(r.Fecha), "MM")
            Else
                Me.cbMes.SelectedItem = Format(Per_Detail.Inicio, "yyyy") & "-" & Format(Per_Detail.Inicio, "MM")
            End If

            If Me.GBMes.Visible = True Then
                Me.dtpDesde.Value = New DateTime(Microsoft.VisualBasic.Left(Me.cbMes.SelectedItem, 4), Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2), 1)
                Me.dtpHasta.Value = New DateTime(Microsoft.VisualBasic.Left(Me.cbMes.SelectedItem, 4), Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2), Str(Meses(Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2) - 1)))

            End If

        End If
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
    Private Sub cbMes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMes.SelectedIndexChanged
        Me.dtpDesde.Value = New DateTime(Microsoft.VisualBasic.Left(Me.cbMes.SelectedItem, 4), Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2), 1)
        Me.dtpHasta.Value = New DateTime(Microsoft.VisualBasic.Left(Me.cbMes.SelectedItem, 4), Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2), Str(Meses(Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2) - 1)))

    End Sub


    Private Sub btnImprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim fReportes As New frmReportes

        If chk1.Checked Then

            'Dim Reporte As New rptComprobantes_Resumen()
            Dim Reporte As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Reporte.Load(Application.StartupPath & "\Reportes\rptComprobantes_Resumen.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            '
            Dim Ds As New DataSet
            Ds = VB.SysContab.ComprobanteDB.ListResumen(Me.chk_Memoria.Checked, Empresas.Nombre, Me.cbPeriodos.SelectedValue, Me.dtpDesde.Value, Me.dtpHasta.Value)

            If Ds.Tables(0).Rows.Count > 0 Then
                Ds.WriteXml(Application.StartupPath & "\xml\rptComprobantes_Resumen.xml", XmlWriteMode.WriteSchema)
                Reporte.Database.Tables("_ComprobantesList_Resumen;1").Location = Application.StartupPath & "\xml\rptComprobantes_Resumen.xml"
                Reporte.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoempresa.xml"

                fReportes.crvReportes.ReportSource = Reporte
                fReportes.Show()

            Else

                MsgBox("Comprobantes no encontrados")
                Exit Sub

            End If
            'reporte.Dispose()
            Exit Sub
        End If

        If chk2.Checked Then

            'Dim Reporte As New rptLibroDiario
            Dim Ds As New DataSet
            Dim Reporte As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Reporte.Load(Application.StartupPath & "\Reportes\rptLibroDiario.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            '
            Ds = Libros.Imprimir_LibroDiario(Me.dtpDesde.Value, Me.dtpHasta.Value, "%", _
                                Me.cbPeriodos.SelectedValue, "", "", "", Login, "", _
                                  Empresas.MonedaBase, Me.cbMonedaCambio.SelectedValue, False)

            Ds.WriteXml(Application.StartupPath & "\xml\rptLibroDiario.xml", XmlWriteMode.WriteSchema)
            Reporte.Database.Tables(0).Location = Application.StartupPath & "\xml\rptLibroDiario.xml"

            fReportes.crvReportes.ReportSource = Reporte
            fReportes.crvReportes.Zoom(91)
            fReportes.Show()


        End If
        If chk3.Checked Then
            Dim r As New VB.SysContab.RutinasNomina
            'Dim rColilla As New rptLibroAuxiliar
            Dim rColilla As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            rColilla.Load(Application.StartupPath & "\Reportes\rptLibroAuxiliar.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            '
            Dim CUENTA As New VB.SysContab.CatalogoDetails
            Dim catalogo As New VB.SysContab.CatalogoDB
            Dim Texto, texto1, texto2, texto3, texto4, texto5, texto6 As String
            Dim dsEncabezado, dsDetalle, dsDetalle_Resumen As DataSet
            Dim RecordArray() = {"", "", Me.dtpDesde.Value.Date, 0, "Saldo Anterior", "", 0.0, 0.0, _
                                 "", "", "", "", "", "", "", "", "", "", "", "", "", False, ""}
            Dim i As Integer
            Dim Llave As DataColumn
            Dim DetalleNivel As New VB.SysContab.NivelDetailsDB
            Dim rNivel As Integer


            dsEncabezado = Libros.Imprimir_LibroAuxiliar_SaldoAnterior(Me.dtpDesde.Value.Date, Me.dtpHasta.Value.Date, _
                    "%", Me.cbPeriodos.SelectedValue, Empresas.MonedaBase, Me.cbMonedaCambio.SelectedValue)
            dsDetalle = Libros.Imprimir_LibroAuxiliar(Me.dtpDesde.Value.Date, Me.dtpHasta.Value.Date, _
                "%", Me.cbPeriodos.SelectedValue, "0", "", "", Usuario, "", Empresas.MonedaBase, _
                Me.cbMonedaCambio.SelectedValue, Me.chk_Memoria.Checked, Empresas.Nombre)
            dsDetalle_Resumen = Libros.Imprimir_LibroAuxiliar_Resumen(Me.dtpDesde.Value.Date, Me.dtpHasta.Value.Date, _
                "%", Me.cbPeriodos.SelectedValue, "0", "", "", Usuario, "", Empresas.MonedaBase, _
                Me.cbMonedaCambio.SelectedValue)


            'Actualizar el encabezado
            'Ordenar la tabla de la balanza
            Llave = dsEncabezado.Tables(0).Columns("Cuenta")
            dsEncabezado.Tables(0).PrimaryKey = New DataColumn() {Llave}
            For i = 0 To dsDetalle_Resumen.Tables(0).Rows.Count - 1
                If Not dsEncabezado.Tables(0).Rows.Find(dsDetalle_Resumen.Tables(0).Rows(i)("Cuenta")) Is Nothing Then
                    dsEncabezado.Tables(0).Rows.Find(dsDetalle_Resumen.Tables(0).Rows(i)("Cuenta")).Item("Debitos") = _
                            dsDetalle_Resumen.Tables(0).Rows(i)("Debitos")
                    dsEncabezado.Tables(0).Rows.Find(dsDetalle_Resumen.Tables(0).Rows(i)("Cuenta")).Item("Creditos") = _
                            dsDetalle_Resumen.Tables(0).Rows(i)("Creditos")
                End If
            Next

            'Mayorizar
            For i = 0 To dsEncabezado.Tables(0).Rows.Count - 1

                If dsEncabezado.Tables(0).Rows(i)("Nivel") <> "00" Then
                    For rNivel = dsEncabezado.Tables(0).Rows(i)("Nivel") - 1 To 0 Step -1
                        DetalleNivel = Libros.Nivel_Detail("0" & rNivel)
                        If Not dsEncabezado.Tables(0).Rows.Find(Mid(dsEncabezado.Tables(0).Rows(i)("Cuenta"), 1, DetalleNivel.nLen)) Is Nothing Then
                            dsEncabezado.Tables(0).Rows.Find(Mid(dsEncabezado.Tables(0).Rows(i)("Cuenta"), 1, DetalleNivel.nLen)).Item("Debitos") += _
                                            dsEncabezado.Tables(0).Rows(i)("Debitos")
                            dsEncabezado.Tables(0).Rows.Find(Mid(dsEncabezado.Tables(0).Rows(i)("Cuenta"), 1, DetalleNivel.nLen)).Item("Creditos") += _
                                            dsEncabezado.Tables(0).Rows(i)("Creditos")
                        End If
                    Next
                End If
            Next

            'Generar los registros
            If dsDetalle.Tables(0).Rows.Count > 0 Then
                Texto = dsDetalle.Tables(0).Rows(0)("cTDocumento")
                texto1 = dsDetalle.Tables(0).Rows(0)("nMayor")
                texto2 = dsDetalle.Tables(0).Rows(0)("nSubcuenta")
                texto3 = dsDetalle.Tables(0).Rows(0)("nCuenta")
                texto4 = dsDetalle.Tables(0).Rows(0)("nivel")
                texto5 = dsDetalle.Tables(0).Rows(0)("NMB")
                texto6 = dsDetalle.Tables(0).Rows(0)("NMC")
            Else
                Texto = ""
                texto1 = ""
                texto2 = ""
                texto3 = ""
                texto4 = ""
                texto5 = ""
                texto6 = ""
            End If
            For i = 0 To dsEncabezado.Tables(0).Rows.Count - 1
                'Saldo Anterior
                CUENTA = catalogo.GetDetails(dsEncabezado.Tables(0).Rows(i)("Cuenta"))
                RecordArray(0) = dsEncabezado.Tables(0).Rows(i)("Cuenta")
                RecordArray(1) = IIf(CUENTA.Nombre Is Nothing, "", CUENTA.Nombre)
                RecordArray(3) = 0
                RecordArray(4) = "SaldoAnterior"
                RecordArray(6) = 0.0
                RecordArray(7) = dsEncabezado.Tables(0).Rows(i)("SaldoAnterior")
                RecordArray(8) = Me.dtpDesde.Value.Date.ToShortDateString
                RecordArray(9) = Me.dtpHasta.Value.Date.ToShortDateString
                RecordArray(10) = Texto
                RecordArray(11) = ""
                RecordArray(12) = ""
                RecordArray(13) = Usuario
                RecordArray(14) = ""
                RecordArray(15) = texto1
                RecordArray(16) = texto2
                RecordArray(17) = texto3
                RecordArray(18) = texto4
                RecordArray(19) = texto5
                RecordArray(20) = texto6
                RecordArray(21) = Me.chk_Memoria.Checked
                RecordArray(22) = Empresas.Nombre
                dsDetalle.Tables(0).Rows.Add(RecordArray)
                If CUENTA.Tipo <> "A" Then
                    If dsEncabezado.Tables(0).Rows(i)("Debitos") + dsEncabezado.Tables(0).Rows(i)("Creditos") <> 0 Then
                        'Debitos
                        RecordArray(0) = dsEncabezado.Tables(0).Rows(i)("Cuenta")
                        RecordArray(1) = IIf(CUENTA.Nombre Is Nothing, "", CUENTA.Nombre)
                        RecordArray(3) = 1
                        RecordArray(4) = "Débitos / Créditos del Periodo"
                        RecordArray(6) = dsEncabezado.Tables(0).Rows(i)("Debitos")
                        RecordArray(7) = dsEncabezado.Tables(0).Rows(i)("Creditos")
                        RecordArray(8) = Me.dtpDesde.Value.Date.ToShortDateString
                        RecordArray(9) = Me.dtpHasta.Value.Date.ToShortDateString
                        RecordArray(10) = Texto
                        RecordArray(11) = ""
                        RecordArray(12) = ""
                        RecordArray(13) = Usuario
                        RecordArray(14) = ""
                        RecordArray(15) = texto1
                        RecordArray(16) = texto2
                        RecordArray(17) = texto3
                        RecordArray(18) = texto4
                        RecordArray(19) = texto5
                        RecordArray(20) = texto6
                        RecordArray(21) = Me.chk_Memoria.Checked
                        RecordArray(22) = Empresas.Nombre
                        dsDetalle.Tables(0).Rows.Add(RecordArray)
                    End If
                End If
            Next

            rColilla.SetDataSource(dsDetalle)

            fReportes.crvReportes.ReportSource = rColilla
            fReportes.Show()
            'rcolilla.Dispose()
        End If

        If chk4.Checked Then
            'Dim Reporte As New rptBalanzaconsubreportesxml
            Dim ds As New DataSet
            Dim dsSR As New DataSet

            Dim Reporte As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Reporte.Load(Application.StartupPath & "\Reportes\rptBalanzaconsubreportesxml.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            '
            Libros.Imprimir_LibroBalanza(Me.cbPeriodos.SelectedValue, Me.dtpDesde.Value, Me.dtpHasta.Value, Login, _
            "", "B", "%", IIf(Me.cbNiveles.SelectedValue = "%", Me.cbNiveles.Items(Me.cbNiveles.Items.Count - 1).row.itemarray(0), Me.cbNiveles.SelectedValue), _
            False, Empresas.MonedaBase, Me.cbMonedaCambio.SelectedValue, False, "%", "%", _
           "B", False, ds, Me.chk_Memoria.Checked, Empresas.Nombre, "%", "%", 0, 0, 0)
            dsSR = Libros.Detalle_Apie(Me.dtpDesde.Value, Me.dtpHasta.Value, Me.cbPeriodos.SelectedValue, Me.cbMonedaCambio.SelectedValue)
            dsSR.WriteXml(Application.StartupPath & "\xml\detalleBalanza.xml", XmlWriteMode.WriteSchema)
            ds.WriteXml(Application.StartupPath & "\xml\balanza.xml", XmlWriteMode.WriteSchema)

            reporte.Database.Tables("vcd").Location = Application.StartupPath & "\xml\balanza.xml"
            Dim i As Integer
            For i = 0 To reporte.Subreports.Count - 1
                reporte.Subreports.Item(i).Database.Tables("_GetDetalleApie;1").Location = Application.StartupPath & "\xml\detalleBalanza.xml"
            Next


            fReportes.crvReportes.ReportSource = Reporte
            fReportes.crvReportes.Zoom(91)
            fReportes.Show()

        End If
        If chk5.Checked Then
            'Dim reporte As New rptEstadoSituacionconSubreportesXML
            Dim ds As New DataSet
            Dim dsbalanza As New DataSet
            Dim Reporte As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Reporte.Load(Application.StartupPath & "\Reportes\rptEstadoSituacionconSubreportesXML.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            '
            Libros.Imprimir_LibroBalanza(Me.cbPeriodos.SelectedValue, Me.dtpDesde.Value, _
                    Me.dtpHasta.Value, Login, "", "%", "%", _
                    IIf(Me.cbNiveles.SelectedValue = "%", Me.cbNiveles.Items(Me.cbNiveles.Items.Count - 1).row.itemarray(0), Me.cbNiveles.SelectedValue), _
                    False, Empresas.MonedaBase, Me.cbMonedaCambio.SelectedValue, False, _
                    "%", "%", "S", False, dsbalanza, False, Empresas.Nombre, "%", "%", 0, 0, 0)
            ds = Libros.Detalle_Apie(Me.dtpDesde.Value, Me.dtpHasta.Value, Me.cbPeriodos.SelectedValue, Me.cbMonedaCambio.SelectedValue)

            dsBalanza.WriteXml(Application.StartupPath & "\xml\balanza.xml", XmlWriteMode.WriteSchema)
            ds.WriteXml(Application.StartupPath & "\xml\detalleES.xml", XmlWriteMode.WriteSchema)

            reporte.Database.Tables("vcd").Location = Application.StartupPath & "\xml\balanza.xml"
            Dim i As Integer
            For i = 0 To reporte.Subreports.Count - 1
                reporte.Subreports.Item(i).Database.Tables("_GetDetalleApie;1").Location = Application.StartupPath & "\xml\detalleES.xml"
            Next


            fReportes.crvReportes.ReportSource = reporte
            fReportes.crvReportes.Zoom(91)
            fReportes.Show()
            'reporte.Dispose()
        End If
        If chk6.Checked Then
            Dim Periodo As New VB.SysContab.PeriodoDetails
            Dim DetalleNivel As New VB.SysContab.NivelDetailsDB
            Dim dsBalanza As New DataSet
            Dim rNivel As Integer

            'Crear el Catalogo
            Libros.Imprimir_LibroBalanza(Me.cbPeriodos.SelectedValue, Me.dtpDesde.Value.Date, Me.dtpHasta.Value.Date, _
                Usuario, "", "R", "%", _
                IIf(Me.cbNiveles.SelectedValue = "%", Me.cbNiveles.Items(Me.cbNiveles.Items.Count - 1).row.itemarray(0), Me.cbNiveles.SelectedValue), _
                False, Empresas.MonedaBase, Me.cbMonedaCambio.SelectedValue, _
                False, "%", "%", "S", False, dsBalanza, False, Empresas.Nombre, "%", "%", 0, 0, 0)

            'Agregar las formulas

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Buscar los Grupos que son resultado de una formula
            Dim Formulas As New DataSet, Formula() As Char
            Dim arreglo() As Object
            Dim i, j As Integer, rMayor As String
            Dim SAnterior, Debitos, Creditos As Double
            Dim Saldo As Object

            Formulas = Libros.Grupos("0", "R")
            arreglo = dsBalanza.Tables("LibroBalanza").Rows(0).ItemArray
            For i = 0 To Formulas.Tables(0).Rows.Count - 1
                Formula = Formulas.Tables(0).Rows(i)("Total")
                SAnterior = 0
                Debitos = 0
                Creditos = 0
                For j = 0 To Len(Formula) Step 2
                    rMayor = Formula(j)
                    'ds = miDS.Tables("LibroEstadoSituacion").Select("Balres= 'R' and Tipo = 'M' and MayorGrupo = " & rMayor)
                    Saldo = dsBalanza.Tables("LibroBalanza").Compute("Sum(SaldoAnterior)", "Balres= 'R' and MayorGrupo = " & rMayor)
                    SAnterior += IIf(IsNothing(Saldo) Or IsDBNull(Saldo), 0, Saldo)
                    Saldo = dsBalanza.Tables("LibroBalanza").Compute("Sum(Debitos)", "Balres= 'R'  and MayorGrupo = " & rMayor)
                    Debitos += IIf(IsNothing(Saldo) Or IsDBNull(Saldo), 0, Saldo)
                    Saldo = dsBalanza.Tables("LibroBalanza").Compute("Sum(Creditos)", "Balres= 'R'  and MayorGrupo = " & rMayor)
                    Creditos += IIf(IsNothing(Saldo) Or IsDBNull(Saldo), 0, Saldo)

                Next
                'Agregar el registro
                arreglo(2) = Libros.GruposCTA(Formula(Formula.GetUpperBound(0)), "R") & "XXX" 'Cuenta
                arreglo(6) = "M"
                arreglo(8) = "00"
                arreglo(16) = Formulas.Tables(0).Rows(i)("Nombre")
                arreglo(3) = SAnterior
                arreglo(4) = Debitos
                arreglo(5) = Creditos
                arreglo(17) = Formulas.Tables(0).Rows(i)("CGrupo")
                arreglo(18) = 0
                arreglo(19) = Formulas.Tables(0).Rows(i)("Nombre")
                arreglo(20) = Formulas.Tables(0).Rows(i)("CGrupo")
                arreglo(21) = Formulas.Tables(0).Rows(i)("Nombre")
                dsBalanza.Tables("LibroBalanza").Rows.Add(arreglo)

            Next

            '        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Pasar el DataSet Original
            'Dim rColilla As New rptEstadoResultadoTradicional
            Dim rColilla As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            rColilla.Load(Application.StartupPath & "\Reportes\rptEstadoResultadoTradicional.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            '
            rColilla.SetDataSource(dsBalanza.Tables("LibroBalanza"))
            fReportes.crvReportes.ReportSource = rColilla
            fReportes.crvReportes.Zoom(91)
            fReportes.Show()
            'rcolilla.Dispose()
        End If
        If chk7.Checked Then
            'Dim Reporte As New rptLibroBancos


            Dim ds As New DataSet
            Dim Reporte As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Reporte.Load(Application.StartupPath & "\Reportes\rptLibroBancos.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            '
            Libros.Imprimir_LibroBancos(Me.cbPeriodos.SelectedValue, _
                                        Me.dtpDesde.Value.Date, _
                                        Me.dtpHasta.Value.Date, _
                                         Login, Me.cbBancos.SelectedValue, _
                                         ds, _
                                        "%", _
                                         "")

            If Ds.Tables(0).Rows.Count > 0 Then

                ds.WriteXml(Application.StartupPath & "\xml\LibroBancos.xml", XmlWriteMode.WriteSchema)

                Reporte.Database.Tables("_LibroBancos;1").Location = Application.StartupPath & "\xml\LibroBancos.xml"
                fReportes.crvReportes.ReportSource = Reporte
                fReportes.Show()

            Else
                MsgBox("No se han encontrado datos bajo los criterios de búsqueda")
                Exit Sub
            End If


        End If
            If chk8.Checked Then

            'Dim Reporte As New rptflujoCaja
            Dim Reporte As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Reporte.Load(Application.StartupPath & "\Reportes\rptflujoCaja.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            Dim ds As New DataSet
            Dim Libros As New VB.SysContab.LibrosDB
            ds = Libros.Imprimir_FlujoCaja(Me.dtpDesde.Value.Date, Me.dtpHasta.Value.Date, _
                                       Me.cbPeriodos.SelectedValue, Me.cbMonedaCambio.SelectedValue)

            If Ds.Tables(0).Rows.Count > 0 Then

                ds.WriteXml(Application.StartupPath & "\xml\rFlujoCaja.xml", XmlWriteMode.WriteSchema)

                Reporte.Database.Tables("_GetFlujoCaja").Location = Application.StartupPath & "\xml\rFlujoCaja.xml"
                Reporte.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoempresa.xml"

                fReportes.crvReportes.ReportSource = Reporte
                fReportes.Show()

            Else
                MsgBox("No se han encontrado datos bajo los criterios de búsqueda")
                Exit Sub
            End If
            'reporte.Dispose()
        End If

        If chk9.Checked Then
            'Dim rFacturas As New RptCuentasPorPagar
            Dim rFacturas As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            rFacturas.Load(Application.StartupPath & "\Reportes\RptCuentasPorPagar.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            '
            Dim Clientes As New VB.SysContab.ClientesDB
            rFacturas.SetDataSource(Clientes.EstadoCuentaProveedorReporte("0", "0", "0", "", Me.dtpDesde.Value.Date.ToString, Me.dtpHasta.Value.Date.ToString))
            fReportes.crvReportes.ReportSource = rFacturas
            fReportes.Show()
            'rfacturas.Dispose()
        End If
        If chk10.Checked Then
            Dim FacRango2, ArtMax As String
            FacRango2 = Compras.MaxTotalFacturaCompras.Tables("Facturas_Compras").Rows(0).Item("Maximo")
            ArtMax = Compras.MaxTotalFacturaComprasLinea.Tables("Facturas_Compras_Lineas").Rows(0).Item("MaximoLinea")
            'Dim rFacturas As New rptFacturasCompras
            Dim rFacturas As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            rFacturas.Load(Application.StartupPath & "\Reportes\rptFacturasCompras.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            '
            rFacturas.SetDataSource(Compras.FacturasCompras("0", "0", Me.dtpDesde.Value.Date.ToString, Me.dtpHasta.Value.Date.ToString, _
                "", "", "", "0", FacRango2, "", "", "0", ArtMax, "", 1, 3))
            fReportes.crvReportes.ReportSource = rFacturas
            fReportes.Show()
            'rfacturas.Dispose()
        End If
        If chk11.Checked Then
            'Dim rInventario As New rptReporteInventario
            Dim FacRango2, ArtMax As String
            Dim rInventario As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            rInventario.Load(Application.StartupPath & "\Reportes\rptReporteInventario.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            '
            FacRango2 = Compras.MaxTotalFacturaCompras.Tables("Facturas_Compras").Rows(0).Item("Maximo")
            ArtMax = Compras.MaxTotalFacturaComprasLinea.Tables("Facturas_Compras_Lineas").Rows(0).Item("MaximoLinea")
            rInventario.SetDataSource(Compras.Inventario(0, "0", Me.dtpDesde.Value.Date.ToString, Me.dtpHasta.Value.Date.ToString, _
                "", "", "", "0", FacRango2, "0", Artmax, "", "", "", ""))
            fReportes.crvReportes.ReportSource = rInventario
            fReportes.Show()
            'rInventario.Dispose()
        End If
        If chk12.Checked Then
            'Dim rFacturas As New RptCuentasPorCobrar
            Dim rFacturas As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            rFacturas.Load(Application.StartupPath & "\Reportes\RptCuentasPorCobrar.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            '
            rFacturas.SetDataSource(Clientes.EstadoCuentaReporte(0, "0", 0, "", Me.dtpDesde.Value.Date.ToString, Me.dtpHasta.Value.Date.ToString))
            fReportes.crvReportes.ReportSource = rFacturas
            fReportes.Show()
            'rfacturas.Dispose()
        End If
        If chk13.Checked Then
            'Dim rFacturas As New rptReporteFacturas
            Dim FacRango2, ArtMax As String
            Dim rFacturas As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            rFacturas.Load(Application.StartupPath & "\Reportes\rptReporteFacturas.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            '
            FacRango2 = Compras.MaxTotalFacturaCompras.Tables("Facturas_Compras").Rows(0).Item("Maximo")
            ArtMax = Compras.MaxTotalFacturaComprasLinea.Tables("Facturas_Compras_Lineas").Rows(0).Item("MaximoLinea")
            rFacturas.SetDataSource(Clientes.FacturasReporte("", 0, "0", Me.dtpDesde.Value.Date.ToString, _
                Me.dtpHasta.Value.Date.ToString, "--Todos--", "", "", "", "", "", "", "0", FacRango2, "", "", "0", ArtMax, 1))
            fReportes.crvReportes.ReportSource = rFacturas
            fReportes.Show()
            'rfacturas.Dispose()
        End If
        If chk14.Checked Then

            'Dim crReportDocument As New rptIR
            Dim C As New VB.SysContab.ConfiguracionDetails
            Dim config As New VB.SysContab.ConfiguracionDB
            Dim Facturas As New VB.SysContab.Facturas_VentasDB
            Dim MesAnterior As Integer
            Dim ds As New DataSet
            C = config.GetConfigDetails()
            Dim crReportDocument As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            crReportDocument.Load(Application.StartupPath & "\Reportes\rptIR.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            '
            MesAnterior = Month(DateAdd(DateInterval.Month, -1, _
                New DateTime(Microsoft.VisualBasic.Left(Me.cbMes.SelectedItem, 4), Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2), 1)))

            ds = Facturas.IR(IIf(Me.chkMes.Checked, Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2), 0), _
                IIf(Me.chkMes.Checked, "", Me.dtpDesde.Value.Date), _
                IIf(Me.chkMes.Checked, "", Me.dtpHasta.Value.Date), EmpresaActual, _
                C.MontoIR, C.IRProd, C.IRServ, MesAnterior, C.IR_Ventas)

            crReportDocument.SetDataSource(ds.Tables(1))
            crReportDocument.Subreports(0).SetDataSource(ds.Tables(0))
            fReportes.crvReportes.ReportSource = crReportDocument
            fReportes.Show()
            'crreportdocument.Dispose()
        End If
        If chk15.Checked Then
            Dim TCambio As Double
            Dim ds As New DataSet

            ds = Tasa.GetTasaCambio(Empresas.MonedaBase, Me.cbMonedaCambio.SelectedValue, Me.dtpHasta.Value.Date)

            If IsNothing(ds) Or ds.Tables(0).Rows.Count = 0 Then
                MsgBox("Error al buscar la tasa de cambio del dia", MsgBoxStyle.Critical)
                Exit Sub
            Else
                TCambio = 1 / IIf(ds.Tables(0).Rows(0)("TCambio") = 0, 1, ds.Tables(0).Rows(0)("TCambio"))
            End If

            'Dim Report As New rptBalanceClientes
            ds.Clear()
            Dim Report As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Report.Load(Application.StartupPath & "\Reportes\rptBalanceClientes.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            '
            ds = VB.SysContab.ClientesDB.GetFacturasVentasPendientes(Me.dtpHasta.Value.Date, Me.cbMonedaCambio.Text, _
                                                   TCambio, Me.chk_Memoria.Checked, Empresas.Nombre)
            Ds.WriteXml(Application.StartupPath & "\xml\rptBalanceClientes.xml", XmlWriteMode.WriteSchema)

            Report.Database.Tables("EMPRESAS").Location = Application.StartupPath & "\xml\logoEmpresa.xml"
            Report.Database.Tables("Facturas_Ventas_Pendientes").Location = Application.StartupPath & "\xml\rptBalanceClientes.xml"
            fReportes.crvReportes.ReportSource = Report
            fReportes.Show()
        End If
        If Chk16.Checked Then

            Dim TCambio As Double
            Dim ds As New DataSet

            ds = Tasa.GetTasaCambio(Empresas.MonedaBase, Me.cbMonedaCambio.SelectedValue, Me.dtpHasta.Value.Date)

            If IsNothing(ds) Or ds.Tables(0).Rows.Count = 0 Then
                MsgBox("Error al buscar la tasa de cambio del dia", MsgBoxStyle.Critical)
                Exit Sub
            Else
                TCambio = 1 / IIf(ds.Tables(0).Rows(0)("TCambio") = 0, 1, ds.Tables(0).Rows(0)("TCambio"))
            End If

            'Dim Report As New rptBalanceProveedores
            Dim Report As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Report.Load(Application.StartupPath & "\Reportes\rptBalanceProveedores.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            Dim DsBal As DataSet = VB.SysContab.ProveedoresDB.GetFacturasVentasPendientes(Me.dtpHasta.Value.Date, Me.cbMonedaCambio.Text, _
                                                           TCambio, False, "")
            DsBal.WriteXml(Application.StartupPath & "\xml\rptBalanceProveedores.xml", XmlWriteMode.WriteSchema)

            Dim DsEmpr As DataSet = VB.SysContab.EmpresasDB.GetEmpresa(EmpresaActual)

            DsEmpr.WriteXml(Application.StartupPath & "\xml\rptEmpresa.xml", XmlWriteMode.WriteSchema)

            Report.Database.Tables("EMPRESAS").Location = Application.StartupPath & "\xml\rptEmpresa.xml"
            Report.Database.Tables("Facturas_Ventas_Pendientes").Location = Application.StartupPath & "\xml\rptBalanceProveedores.xml"


            fReportes.crvReportes.ReportSource = Report
            fReportes.Show()

        End If
        If Me.Chk17.Checked Then
            'Dim reporte As New rptAPIEconsubreportesxml
            Dim lDs As New DataSet
            Dim lDs1 As New DataSet
            Dim reporte As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            reporte.Load(Application.StartupPath & "\Reportes\rptAPIEconsubreportesxml.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            '
            lDs = Libros.Detalle_Apie(Me.dtpDesde.Value, Me.dtpHasta.Value, Me.cbPeriodos.SelectedValue, Me.cbMonedaCambio.SelectedValue)
            lDs1 = Libros.Apie(Me.dtpDesde.Value, Me.dtpHasta.Value, Me.cbPeriodos.SelectedValue, Me.cbMonedaCambio.SelectedValue)
            lDs.WriteXml(Application.StartupPath & "\xml\detalleApie.xml", XmlWriteMode.WriteSchema)
            lDs1.WriteXml(Application.StartupPath & "\xml\Apie.xml", XmlWriteMode.WriteSchema)

            reporte.Database.Tables("vcd").Location = Application.StartupPath & "\xml\Apie.xml"
            Dim i As Integer
            For i = 0 To reporte.Subreports.Count - 1
                reporte.Subreports.Item(i).Database.Tables("_GetDetalleApie;1").Location = Application.StartupPath & "\xml\detalleApie.xml"
            Next

            fReportes.crvReportes.ReportSource = reporte
            fReportes.crvReportes.Zoom(91)

            fReportes.Show()
            'reporte.Dispose()
        End If
        If Me.chk18.Checked Then

            'Dim crReportDocument As New rptIVA
            Dim C As New VB.SysContab.ConfiguracionDetails
            Dim config As New VB.SysContab.ConfiguracionDB
            Dim Facturas As New VB.SysContab.Facturas_VentasDB
            Dim MesAnterior As Integer
            Dim ds As New DataSet
            C = config.GetConfigDetails()

            Dim crReportDocument As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            crReportDocument.Load(Application.StartupPath & "\Reportes\rptIVA.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            MesAnterior = Month(DateAdd(DateInterval.Month, -1, _
                New DateTime(Microsoft.VisualBasic.Left(Me.cbMes.SelectedItem, 4), Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2), 1)))

            ds = Facturas.iva(IIf(Me.chkMes.Checked, Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2), 0), _
                IIf(Me.chkMes.Checked, "", Me.dtpDesde.Value.Date), _
                IIf(Me.chkMes.Checked, "", Me.dtpHasta.Value.Date), EmpresaActual, _
                C.MontoIR, C.IRProd, C.IRServ, MesAnterior, C.IR_Ventas)

            ds.WriteXml(Application.StartupPath & "\xml\rptIVA.xml", XmlWriteMode.WriteSchema)

            crReportDocument.Database.Tables(0).Location = Application.StartupPath & "\xml\rptIVA.xml"
            crReportDocument.Subreports(0).Database.Tables(0).Location = Application.StartupPath & "\xml\rptIVA.xml"

            fReportes.crvReportes.ReportSource = crReportDocument
            fReportes.Show()

        End If
    End Sub

    Private Sub chk7_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk7.CheckedChanged
        Me.gbBanco.Visible = Me.chk7.Checked
    End Sub

    Private Sub chk1_click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk1.Click, _
    chk2.Click, chk3.Click, chk4.Click, chk5.Click, chk6.Click, _
    chk7.Click, chk8.Click, chk9.Click, chk10.Click, chk11.Click, _
    chk12.Click, chk13.Click, chk14.Click, chk15.Click, Chk16.Click, _
    Chk17.Click, chk18.Click

        chk1.Checked = IIf(sender.name.tolower = "chk1", chk1.Checked, False)
        chk2.Checked = IIf(sender.name.tolower = "chk2", chk2.Checked, False)
        chk3.Checked = IIf(sender.name.tolower = "chk3", chk3.Checked, False)
        chk4.Checked = IIf(sender.name.tolower = "chk4", chk4.Checked, False)
        chk5.Checked = IIf(sender.name.tolower = "chk5", chk5.Checked, False)
        chk6.Checked = IIf(sender.name.tolower = "chk6", chk6.Checked, False)
        chk7.Checked = IIf(sender.name.tolower = "chk7", chk7.Checked, False)
        chk8.Checked = IIf(sender.name.tolower = "chk8", chk8.Checked, False)
        chk9.Checked = IIf(sender.name.tolower = "chk9", chk9.Checked, False)
        chk10.Checked = IIf(sender.name.tolower = "chk10", chk10.Checked, False)
        chk11.Checked = IIf(sender.name.tolower = "chk11", chk11.Checked, False)
        chk12.Checked = IIf(sender.name.tolower = "chk12", chk12.Checked, False)
        chk13.Checked = IIf(sender.name.tolower = "chk13", chk13.Checked, False)
        chk14.Checked = IIf(sender.name.tolower = "chk14", chk14.Checked, False)
        chk15.Checked = IIf(sender.name.tolower = "chk15", chk15.Checked, False)
        Chk16.Checked = IIf(sender.name.tolower = "chk16", Chk16.Checked, False)
        Chk17.Checked = IIf(sender.name.tolower = "chk17", Chk17.Checked, False)
        chk18.Checked = IIf(sender.name.tolower = "chk18", chk18.Checked, False)


    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/Reportes/ReportesGenerales.chm")
    End Sub

    Private Sub chk18_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk18.CheckedChanged

    End Sub
End Class
