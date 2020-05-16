Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmNuevaCuentaQuick
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmNuevaCuentaQuick = Nothing

    Public Shared Function Instance() As frmNuevaCuentaQuick
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmNuevaCuentaQuick()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Dim Empresa As New VB.SysContab.EmpresasDB()
    Dim Detalles As New VB.SysContab.EmpresasDetails()
    Dim grupos As String
    Dim Cod_Grupo As String
    Dim Cod_Agrupacion As String
    Dim TG As String
    Dim CB As String
    Dim Agrupaciones As String

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
    Friend WithEvents cmdAcumulados As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSaldoDolar1 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoIniDolar As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoActual As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbCuentaDe As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents etDescripcion As System.Windows.Forms.Label
    Friend WithEvents lbGruposSup As System.Windows.Forms.ListBox
    Friend WithEvents etGruposSup As System.Windows.Forms.Label
    Friend WithEvents cbGrupos As System.Windows.Forms.ComboBox
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtPresupuestoAnual As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbCuenta As System.Windows.Forms.ListBox
    Friend WithEvents cbClase As System.Windows.Forms.ComboBox
    Friend WithEvents cbAgrupaciones As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbGpo_Presupuesto As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkDistribucion As System.Windows.Forms.CheckBox
    Friend WithEvents chkInventario As System.Windows.Forms.CheckBox
    Friend WithEvents chkProveedor As System.Windows.Forms.CheckBox
    Friend WithEvents chkCajaChica As System.Windows.Forms.CheckBox
    Friend WithEvents chkDeOrden As System.Windows.Forms.CheckBox
    Friend WithEvents ChkUA As System.Windows.Forms.CheckBox
    Friend WithEvents ChkUP As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdAcumulados = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chkDeOrden = New System.Windows.Forms.CheckBox
        Me.chkDistribucion = New System.Windows.Forms.CheckBox
        Me.chkInventario = New System.Windows.Forms.CheckBox
        Me.chkProveedor = New System.Windows.Forms.CheckBox
        Me.chkCajaChica = New System.Windows.Forms.CheckBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.cbGpo_Presupuesto = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbAgrupaciones = New System.Windows.Forms.ComboBox
        Me.cbClase = New System.Windows.Forms.ComboBox
        Me.lbCuenta = New System.Windows.Forms.ListBox
        Me.cbGrupos = New System.Windows.Forms.ComboBox
        Me.lbGruposSup = New System.Windows.Forms.ListBox
        Me.etGruposSup = New System.Windows.Forms.Label
        Me.txtSaldoDolar1 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtSaldoIniDolar = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtPresupuestoAnual = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtSaldoActual = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtSaldoInicial = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbCuentaDe = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbTipo = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.etDescripcion = New System.Windows.Forms.Label
        Me.ChkUA = New System.Windows.Forms.CheckBox
        Me.ChkUP = New System.Windows.Forms.CheckBox
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdAcumulados
        '
        Me.cmdAcumulados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAcumulados.ForeColor = System.Drawing.Color.Black
        Me.cmdAcumulados.Location = New System.Drawing.Point(24, 56)
        Me.cmdAcumulados.Name = "cmdAcumulados"
        Me.cmdAcumulados.Size = New System.Drawing.Size(88, 24)
        Me.cmdAcumulados.TabIndex = 10
        Me.cmdAcumulados.Text = "Acumulados"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.Color.Black
        Me.cmdAceptar.Location = New System.Drawing.Point(24, 16)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(88, 24)
        Me.cmdAceptar.TabIndex = 9
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.Color.Black
        Me.cmdCancelar.Location = New System.Drawing.Point(24, 96)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(88, 24)
        Me.cmdCancelar.TabIndex = 11
        Me.cmdCancelar.Text = "Salir"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdCancelar)
        Me.GroupBox2.Controls.Add(Me.cmdAcumulados)
        Me.GroupBox2.Controls.Add(Me.cmdAceptar)
        Me.GroupBox2.Location = New System.Drawing.Point(816, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(128, 512)
        Me.GroupBox2.TabIndex = 125
        Me.GroupBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.cbGpo_Presupuesto)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbAgrupaciones)
        Me.GroupBox1.Controls.Add(Me.cbClase)
        Me.GroupBox1.Controls.Add(Me.lbCuenta)
        Me.GroupBox1.Controls.Add(Me.cbGrupos)
        Me.GroupBox1.Controls.Add(Me.lbGruposSup)
        Me.GroupBox1.Controls.Add(Me.etGruposSup)
        Me.GroupBox1.Controls.Add(Me.txtSaldoDolar1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtSaldoIniDolar)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtPresupuestoAnual)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtSaldoActual)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtSaldoInicial)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbCuentaDe)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbTipo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(792, 512)
        Me.GroupBox1.TabIndex = 87
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ChkUA)
        Me.GroupBox3.Controls.Add(Me.ChkUP)
        Me.GroupBox3.Controls.Add(Me.chkDeOrden)
        Me.GroupBox3.Controls.Add(Me.chkDistribucion)
        Me.GroupBox3.Controls.Add(Me.chkInventario)
        Me.GroupBox3.Controls.Add(Me.chkProveedor)
        Me.GroupBox3.Controls.Add(Me.chkCajaChica)
        Me.GroupBox3.Location = New System.Drawing.Point(624, 80)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(136, 200)
        Me.GroupBox3.TabIndex = 123
        Me.GroupBox3.TabStop = False
        '
        'chkDeOrden
        '
        Me.chkDeOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDeOrden.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.chkDeOrden.Location = New System.Drawing.Point(8, 112)
        Me.chkDeOrden.Name = "chkDeOrden"
        Me.chkDeOrden.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkDeOrden.Size = New System.Drawing.Size(120, 24)
        Me.chkDeOrden.TabIndex = 125
        Me.chkDeOrden.Text = "De Orden"
        Me.chkDeOrden.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkDistribucion
        '
        Me.chkDistribucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDistribucion.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.chkDistribucion.Location = New System.Drawing.Point(8, 88)
        Me.chkDistribucion.Name = "chkDistribucion"
        Me.chkDistribucion.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkDistribucion.Size = New System.Drawing.Size(120, 24)
        Me.chkDistribucion.TabIndex = 123
        Me.chkDistribucion.Text = "Distribución"
        Me.chkDistribucion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkInventario
        '
        Me.chkInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInventario.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.chkInventario.Location = New System.Drawing.Point(8, 64)
        Me.chkInventario.Name = "chkInventario"
        Me.chkInventario.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkInventario.Size = New System.Drawing.Size(120, 24)
        Me.chkInventario.TabIndex = 122
        Me.chkInventario.Text = "Inventario"
        Me.chkInventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkProveedor
        '
        Me.chkProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProveedor.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.chkProveedor.Location = New System.Drawing.Point(8, 16)
        Me.chkProveedor.Name = "chkProveedor"
        Me.chkProveedor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkProveedor.Size = New System.Drawing.Size(120, 24)
        Me.chkProveedor.TabIndex = 120
        Me.chkProveedor.Text = "Proveedor"
        Me.chkProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkCajaChica
        '
        Me.chkCajaChica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCajaChica.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.chkCajaChica.Location = New System.Drawing.Point(8, 40)
        Me.chkCajaChica.Name = "chkCajaChica"
        Me.chkCajaChica.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkCajaChica.Size = New System.Drawing.Size(120, 24)
        Me.chkCajaChica.TabIndex = 121
        Me.chkCajaChica.Text = "Caja"
        Me.chkCajaChica.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(24, 272)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(136, 24)
        Me.Label14.TabIndex = 119
        Me.Label14.Text = "Grupo Presupuesto:"
        '
        'cbGpo_Presupuesto
        '
        Me.cbGpo_Presupuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGpo_Presupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGpo_Presupuesto.Items.AddRange(New Object() {"Tipo de Cuenta", "Débito", "Crédito"})
        Me.cbGpo_Presupuesto.Location = New System.Drawing.Point(168, 272)
        Me.cbGpo_Presupuesto.Name = "cbGpo_Presupuesto"
        Me.cbGpo_Presupuesto.Size = New System.Drawing.Size(280, 23)
        Me.cbGpo_Presupuesto.TabIndex = 118
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(24, 240)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 24)
        Me.Label13.TabIndex = 117
        Me.Label13.Text = "Tipo:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(24, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 24)
        Me.Label6.TabIndex = 116
        Me.Label6.Text = "Agrupación:"
        '
        'cbAgrupaciones
        '
        Me.cbAgrupaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAgrupaciones.Location = New System.Drawing.Point(168, 176)
        Me.cbAgrupaciones.Name = "cbAgrupaciones"
        Me.cbAgrupaciones.Size = New System.Drawing.Size(360, 23)
        Me.cbAgrupaciones.TabIndex = 5
        '
        'cbClase
        '
        Me.cbClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClase.Items.AddRange(New Object() {"Tipo de Cuenta", "Débito", "Crédito"})
        Me.cbClase.Location = New System.Drawing.Point(168, 240)
        Me.cbClase.Name = "cbClase"
        Me.cbClase.Size = New System.Drawing.Size(128, 23)
        Me.cbClase.TabIndex = 8
        '
        'lbCuenta
        '
        Me.lbCuenta.Location = New System.Drawing.Point(672, 312)
        Me.lbCuenta.Name = "lbCuenta"
        Me.lbCuenta.Size = New System.Drawing.Size(96, 30)
        Me.lbCuenta.TabIndex = 113
        Me.lbCuenta.Visible = False
        '
        'cbGrupos
        '
        Me.cbGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGrupos.Location = New System.Drawing.Point(168, 144)
        Me.cbGrupos.Name = "cbGrupos"
        Me.cbGrupos.Size = New System.Drawing.Size(360, 23)
        Me.cbGrupos.TabIndex = 4
        '
        'lbGruposSup
        '
        Me.lbGruposSup.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.lbGruposSup.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbGruposSup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGruposSup.ItemHeight = 16
        Me.lbGruposSup.Location = New System.Drawing.Point(24, 360)
        Me.lbGruposSup.Name = "lbGruposSup"
        Me.lbGruposSup.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lbGruposSup.Size = New System.Drawing.Size(752, 144)
        Me.lbGruposSup.TabIndex = 112
        Me.lbGruposSup.Visible = False
        '
        'etGruposSup
        '
        Me.etGruposSup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etGruposSup.ForeColor = System.Drawing.Color.Maroon
        Me.etGruposSup.Location = New System.Drawing.Point(20, 336)
        Me.etGruposSup.Name = "etGruposSup"
        Me.etGruposSup.Size = New System.Drawing.Size(168, 24)
        Me.etGruposSup.TabIndex = 111
        Me.etGruposSup.Text = "Cuentas Superiores: "
        Me.etGruposSup.Visible = False
        '
        'txtSaldoDolar1
        '
        Me.txtSaldoDolar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoDolar1.Location = New System.Drawing.Point(376, 248)
        Me.txtSaldoDolar1.Name = "txtSaldoDolar1"
        Me.txtSaldoDolar1.Size = New System.Drawing.Size(120, 21)
        Me.txtSaldoDolar1.TabIndex = 108
        Me.txtSaldoDolar1.Text = ""
        Me.txtSaldoDolar1.Visible = False
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(336, 248)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 24)
        Me.Label12.TabIndex = 107
        Me.Label12.Text = "U$:"
        Me.Label12.Visible = False
        '
        'txtSaldoIniDolar
        '
        Me.txtSaldoIniDolar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoIniDolar.Location = New System.Drawing.Point(568, 248)
        Me.txtSaldoIniDolar.Name = "txtSaldoIniDolar"
        Me.txtSaldoIniDolar.Size = New System.Drawing.Size(120, 21)
        Me.txtSaldoIniDolar.TabIndex = 106
        Me.txtSaldoIniDolar.Text = ""
        Me.txtSaldoIniDolar.Visible = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(528, 248)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 24)
        Me.Label11.TabIndex = 105
        Me.Label11.Text = "U$:"
        Me.Label11.Visible = False
        '
        'txtPresupuestoAnual
        '
        Me.txtPresupuestoAnual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPresupuestoAnual.Location = New System.Drawing.Point(168, 304)
        Me.txtPresupuestoAnual.Name = "txtPresupuestoAnual"
        Me.txtPresupuestoAnual.Size = New System.Drawing.Size(120, 21)
        Me.txtPresupuestoAnual.TabIndex = 7
        Me.txtPresupuestoAnual.Text = ""
        Me.txtPresupuestoAnual.Visible = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(24, 304)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 24)
        Me.Label10.TabIndex = 103
        Me.Label10.Text = "Presupuesto Anual:"
        Me.Label10.Visible = False
        '
        'txtSaldoActual
        '
        Me.txtSaldoActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoActual.Location = New System.Drawing.Point(432, 208)
        Me.txtSaldoActual.Name = "txtSaldoActual"
        Me.txtSaldoActual.ReadOnly = True
        Me.txtSaldoActual.Size = New System.Drawing.Size(120, 21)
        Me.txtSaldoActual.TabIndex = 102
        Me.txtSaldoActual.Text = ""
        Me.txtSaldoActual.Visible = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(312, 208)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 24)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "Saldo Act. C$:"
        Me.Label9.Visible = False
        '
        'txtSaldoInicial
        '
        Me.txtSaldoInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoInicial.Location = New System.Drawing.Point(168, 208)
        Me.txtSaldoInicial.Name = "txtSaldoInicial"
        Me.txtSaldoInicial.Size = New System.Drawing.Size(120, 21)
        Me.txtSaldoInicial.TabIndex = 6
        Me.txtSaldoInicial.Text = ""
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(24, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 24)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "Saldo Inicial:"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(400, 304)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(24, 21)
        Me.TextBox4.TabIndex = 98
        Me.TextBox4.Text = ""
        Me.TextBox4.Visible = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(320, 304)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 24)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Informe(I):"
        Me.Label7.Visible = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(24, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 24)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "Grupo:"
        '
        'cbCuentaDe
        '
        Me.cbCuentaDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCuentaDe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCuentaDe.Items.AddRange(New Object() {"Balance", "Resultado", "Presupuesto"})
        Me.cbCuentaDe.Location = New System.Drawing.Point(168, 112)
        Me.cbCuentaDe.Name = "cbCuentaDe"
        Me.cbCuentaDe.Size = New System.Drawing.Size(128, 23)
        Me.cbCuentaDe.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(24, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 24)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Cuenta de:"
        '
        'cbTipo
        '
        Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipo.Location = New System.Drawing.Point(168, 80)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(128, 23)
        Me.cbTipo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(24, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 24)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Nivel:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(168, 48)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(596, 21)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(24, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 24)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Nombre:"
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(168, 16)
        Me.txtCodigo.MaxLength = 16
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(272, 21)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(24, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 24)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "Cuenta:"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox7.Controls.Add(Me.etDescripcion)
        Me.GroupBox7.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(792, 32)
        Me.GroupBox7.TabIndex = 115
        Me.GroupBox7.TabStop = False
        '
        'etDescripcion
        '
        Me.etDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.etDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcion.ForeColor = System.Drawing.Color.White
        Me.etDescripcion.Location = New System.Drawing.Point(0, 8)
        Me.etDescripcion.Name = "etDescripcion"
        Me.etDescripcion.Size = New System.Drawing.Size(792, 20)
        Me.etDescripcion.TabIndex = 113
        Me.etDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkUA
        '
        Me.ChkUA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkUA.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.ChkUA.Location = New System.Drawing.Point(8, 160)
        Me.ChkUA.Name = "ChkUA"
        Me.ChkUA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkUA.Size = New System.Drawing.Size(120, 24)
        Me.ChkUA.TabIndex = 128
        Me.ChkUA.Text = "Util/Acumulada"
        Me.ChkUA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChkUP
        '
        Me.ChkUP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkUP.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.ChkUP.Location = New System.Drawing.Point(8, 136)
        Me.ChkUP.Name = "ChkUP"
        Me.ChkUP.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkUP.Size = New System.Drawing.Size(120, 24)
        Me.ChkUP.TabIndex = 127
        Me.ChkUP.Text = "Util / Perdida"
        Me.ChkUP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmNuevaCuentaQuick
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(960, 550)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmNuevaCuentaQuick"
        Me.ShowInTaskbar = False
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmNuevaCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim r As New VB.SysContab.Rutinas()
        Dim Catalogo As New VB.SysContab.CatalogoDB()
        Dim Agrupacion As New VB.SysContab.AgrupacionesDB()
        Dim Grupo As New VB.SysContab.GruposDB()

        cbAgrupaciones.DataSource = Agrupacion.GetListBuscarCombo("%").Tables("AGRUPACIONES")
        cbAgrupaciones.ValueMember = "CODIGO_AGRUPACION"
        cbAgrupaciones.DisplayMember = "NOMBRE"

        Me.cbGpo_Presupuesto.DataSource = Grupo.GetList_Presupuesto().Tables("GRUPOS")
        Me.cbGpo_Presupuesto.ValueMember = "CODIGO_GRUPO"
        Me.cbGpo_Presupuesto.DisplayMember = "Nombre"

        CB = ""

        Detalles = Empresa.GetDetails(EmpresaActual)

        If Detalles.Mayor <> 0 Then
            txtCodigo.MaxLength = Detalles.Mayor
        End If

        If Detalles.SC01 <> 0 Then
            txtCodigo.MaxLength = Detalles.SC01 ' + 1
        End If

        If Detalles.SC02 <> 0 Then
            txtCodigo.MaxLength = Detalles.SC02 ' + 2
        End If

        If Detalles.SC03 <> 0 Then
            txtCodigo.MaxLength = Detalles.SC03 ' + 3
        End If

        If Detalles.SC04 <> 0 Then
            txtCodigo.MaxLength = Detalles.SC04 ' + 4
        End If

        If Detalles.SC05 <> 0 Then
            txtCodigo.MaxLength = Detalles.SC05 ' + 5
        End If

        If Detalles.SC06 <> 0 Then
            txtCodigo.MaxLength = Detalles.SC06 ' + 6
        End If

        If Detalles.SC07 <> 0 Then
            txtCodigo.MaxLength = Detalles.SC07 ' + 7
        End If

        If Detalles.SC08 <> 0 Then
            txtCodigo.MaxLength = Detalles.SC08 ' + 8
        End If

        If Detalles.SC09 <> 0 Then
            txtCodigo.MaxLength = Detalles.SC09 ' + 9
        End If

        If Nuevo = "NO" Then
            Me.etDescripcion.Text = "Editar Cuenta".ToUpper
            Me.Text = "Editar Cuenta"

            Dim Detalles As VB.SysContab.CatalogoDetails = Catalogo.GetDetails(Registro)
            Me.txtCodigo.ReadOnly = True
            'Nombre = Detalles.Nombre
            Me.chkProveedor.Checked = Detalles.Proveedor
            Me.chkCajaChica.Checked = Detalles.Caja
            Me.chkDistribucion.Checked = Detalles.Distribucion
            Me.chkInventario.Checked = Detalles.Inventario
            Me.chkDeOrden.Checked = Detalles.DeOrden
            Me.ChkUP.Checked = Detalles.UtilidadPerdida
            Me.ChkUA.Checked = Detalles.UtilidadAcumulada


            Me.txtNombre.Text = Detalles.Nombre
            Me.txtCodigo.Text = Detalles.Cuenta
            Me.txtSaldoInicial.Text = CDbl(Detalles.Saldo_Inicial).ToString(Round)
            Me.txtPresupuestoAnual.Text = CDbl(Detalles.Presupuesto_Anual).ToString(Round)
            Me.cbGpo_Presupuesto.SelectedValue = Detalles.Gpo_Presupuesto.ToString

            If Detalles.Cuenta_De = "B" Then
                Me.cbCuentaDe.SelectedIndex = 0
            ElseIf Detalles.Cuenta_De = "R" Then
                Me.cbCuentaDe.SelectedIndex = 1
            ElseIf Detalles.Cuenta_De = "P" Then
                Me.cbCuentaDe.SelectedIndex = 2
            End If

            Me.cbGrupos.SelectedValue = Detalles.Grupo

            If Detalles.SubCuenta.ToString.ToUpper = "XXXX" Then
                cbTipo.Items.Clear()
                cbTipo.Items.Add("Mayor")
                cbTipo.SelectedIndex = 0
                Me.txtSaldoInicial.ReadOnly = True
                Me.txtPresupuestoAnual.ReadOnly = True


            ElseIf Catalogo.GetListSubCuenta(Detalles.Cuenta, EmpresaActual).Tables("Catalogo").Rows.Count <> 0 Then
                cbTipo.Items.Clear()
                cbTipo.Items.Add("SubCuenta")
                cbTipo.SelectedIndex = 0
                Me.txtSaldoInicial.ReadOnly = True
                Me.txtPresupuestoAnual.ReadOnly = True

            Else

                cbTipo.Items.Clear()
                cbTipo.Items.Add("SubCuenta")
                cbTipo.Items.Add("Auxiliar")

                If Detalles.Tipo = "S" Then
                    Me.cbTipo.SelectedIndex = 0
                    Me.txtSaldoActual.ReadOnly = True
                ElseIf Detalles.Tipo = "A" Then
                    Me.cbTipo.SelectedIndex = 1

                End If
            End If

            cbClase.SelectedIndex = Detalles.Clase


            Dim Catal As New VB.SysContab.CatalogoDB()
            Dim longitud As Integer
            Dim i As Integer

            longitud = Registro.Length

            If longitud = 1 Then
                Exit Sub
            Else
                lbGruposSup.Items.Clear()
                lbCuenta.Items.Clear()
                For i = 0 To longitud - 2
                    'If Catal.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), EmpresaActual).Tables("Catalogo").Rows.Count <> 0 Then
                    '    lbGruposSup.Items.Add(Catal.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), EmpresaActual).Tables("Catalogo").Rows(0).Item("Cuenta") & " - " & Catal.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), TipoGrupo).Tables("Catalogo").Rows(0).Item("Nombre"))

                    'End If

                    If Catal.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), EmpresaActual).Tables("CATALOGO").Rows.Count <> 0 And txtCodigo.Text.Substring(i, 1) <> " " Then
                        lbGruposSup.Items.Add(Catal.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), EmpresaActual).Tables("CATALOGO").Rows(0).Item("CUENTA") & " - " & Catal.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), EmpresaActual).Tables("CATALOGO").Rows(0).Item("Nombre"))
                        lbCuenta.Items.Add(Catal.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), EmpresaActual).Tables("CATALOGO").Rows(0).Item("CUENTA"))

                    End If

                Next

                If lbGruposSup.Items.Count <> 0 Then
                    etGruposSup.Visible = True
                    lbGruposSup.Visible = True

                End If

            End If

        Else
            Me.Text = "Agregar cuenta contable"
            Me.etDescripcion.Text = "Agregar cuenta contable".ToUpper

            Me.txtSaldoInicial.Text = "0.00"
            Me.txtPresupuestoAnual.Text = "0.00"

            Me.cbClase.SelectedIndex = 0

        End If
        'r.CambiarEstilo(Me)
        Me.Refresh()


    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.txtCodigo.Text = ""
        Me.txtNombre.Text = ""
        Me.Close()

    End Sub

    Private Sub txtCodigo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.Leave
        Dim c As New VB.SysContab.CatalogoDB()
        Dim longitud As Integer
        Dim i As Integer

        If Nuevo = "NO" Then
            If Clipboard.GetDataObject.GetDataPresent(System.Windows.Forms.DataFormats.Text) = True Then
                Clipboard.SetDataObject(CB)
            End If
            Exit Sub
        End If

        If Trim(txtCodigo.Text) <> "" Then
            If Detalles.Espacio = True Then
                If txtCodigo.TextLength < Detalles.Mayor Then
                    MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                    txtCodigo.Focus()
                    Exit Sub

                End If

                If Detalles.SC01 <> 0 Then
                    If txtCodigo.TextLength > Detalles.Mayor And txtCodigo.TextLength < Detalles.SC01 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC02 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC01 + 1 And txtCodigo.TextLength < Detalles.SC02 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC03 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC02 + 2 And txtCodigo.TextLength < Detalles.SC03 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC04 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC03 + 3 And txtCodigo.TextLength < Detalles.SC04 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC05 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC04 + 4 And txtCodigo.TextLength < Detalles.SC05 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC06 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC05 + 5 And txtCodigo.TextLength < Detalles.SC06 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC07 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC06 + 6 And txtCodigo.TextLength < Detalles.SC07 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC08 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC07 + 7 And txtCodigo.TextLength < Detalles.SC08 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC09 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC08 + 8 And txtCodigo.TextLength < Detalles.SC09 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If
            Else
                '''''''Aqui
                If Detalles.SC01 + 1 <> 0 Then
                    If txtCodigo.TextLength > Detalles.Mayor And txtCodigo.TextLength < Detalles.SC01 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC02 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC01 And txtCodigo.TextLength < Detalles.SC02 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC03 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC02 And txtCodigo.TextLength < Detalles.SC03 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC04 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC03 And txtCodigo.TextLength < Detalles.SC04 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC05 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC04 And txtCodigo.TextLength < Detalles.SC05 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC06 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC05 And txtCodigo.TextLength < Detalles.SC06 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC07 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC06 And txtCodigo.TextLength < Detalles.SC07 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC08 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC07 And txtCodigo.TextLength < Detalles.SC08 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC09 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC08 And txtCodigo.TextLength < Detalles.SC09 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If
                '''''''Aqui
            End If

            'If Detalles.SC01 + 1 <> 0 Then
            '    If txtCodigo.TextLength > Detalles.Mayor And txtCodigo.TextLength < Detalles.SC01 + 1 Then
            '        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
            '        txtCodigo.Focus()
            '        Exit Sub

            '    End If
            'End If

            'If Detalles.SC02 <> 0 Then
            '    If txtCodigo.TextLength > Detalles.SC01 + 1 And txtCodigo.TextLength < Detalles.SC02 + 2 Then
            '        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
            '        txtCodigo.Focus()
            '        Exit Sub

            '    End If
            'End If

            'If Detalles.SC03 <> 0 Then
            '    If txtCodigo.TextLength > Detalles.SC02 + 2 And txtCodigo.TextLength < Detalles.SC03 + 3 Then
            '        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
            '        txtCodigo.Focus()
            '        Exit Sub

            '    End If
            'End If

            'If Detalles.SC04 <> 0 Then
            '    If txtCodigo.TextLength > Detalles.SC03 + 3 And txtCodigo.TextLength < Detalles.SC04 + 4 Then
            '        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
            '        txtCodigo.Focus()
            '        Exit Sub

            '    End If
            'End If

            'If Detalles.SC05 <> 0 Then
            '    If txtCodigo.TextLength > Detalles.SC04 + 4 And txtCodigo.TextLength < Detalles.SC05 + 5 Then
            '        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
            '        txtCodigo.Focus()
            '        Exit Sub

            '    End If
            'End If

            'If Detalles.SC06 <> 0 Then
            '    If txtCodigo.TextLength > Detalles.SC05 + 5 And txtCodigo.TextLength < Detalles.SC06 + 6 Then
            '        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
            '        txtCodigo.Focus()
            '        Exit Sub

            '    End If
            'End If

            'If Detalles.SC07 <> 0 Then
            '    If txtCodigo.TextLength > Detalles.SC06 + 6 And txtCodigo.TextLength < Detalles.SC07 + 7 Then
            '        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
            '        txtCodigo.Focus()
            '        Exit Sub

            '    End If
            'End If

            'If Detalles.SC08 <> 0 Then
            '    If txtCodigo.TextLength > Detalles.SC07 + 7 And txtCodigo.TextLength < Detalles.SC08 + 8 Then
            '        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
            '        txtCodigo.Focus()
            '        Exit Sub

            '    End If
            'End If

            'If Detalles.SC09 <> 0 Then
            '    If txtCodigo.TextLength > Detalles.SC08 + 8 And txtCodigo.TextLength < Detalles.SC09 + 9 Then
            '        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
            '        txtCodigo.Focus()
            '        Exit Sub

            '    End If
            'End If




            longitud = txtCodigo.Text.Length
            c.GetListCodigo(txtCodigo.Text, EmpresaActual)

            If longitud = 1 Then
                If c.GetListCodigo(txtCodigo.Text, EmpresaActual).Tables("CATALOGO").Rows.Count <> 0 Then
                    MsgBox("Cuenta ya existe", MsgBoxStyle.Information)
                    txtCodigo.Focus()
                    Exit Sub

                End If
            Else
                If c.GetListCodigo(txtCodigo.Text, EmpresaActual).Tables("CATALOGO").Rows.Count <> 0 Then
                    MsgBox("Cuenta ya existe", MsgBoxStyle.Information)
                    txtCodigo.Focus()
                    Exit Sub

                End If

                lbGruposSup.Items.Clear()
                lbCuenta.Items.Clear()
                For i = 0 To longitud - 2

                    If c.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), EmpresaActual).Tables("CATALOGO").Rows.Count <> 0 And txtCodigo.Text.Substring(i, 1) <> " " Then
                        lbGruposSup.Items.Add(c.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), EmpresaActual).Tables("CATALOGO").Rows(0).Item("CUENTA") & " - " & c.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), EmpresaActual).Tables("CATALOGO").Rows(0).Item("Nombre"))
                        lbCuenta.Items.Add(c.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), EmpresaActual).Tables("CATALOGO").Rows(0).Item("CUENTA"))

                        If c.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), EmpresaActual).Tables("CATALOGO").Rows(0).Item("TIPO").ToString.ToUpper = "A" Then
                            MsgBox("La sub cuenta es Auxiliar", MsgBoxStyle.Information)
                            txtCodigo.Focus()
                            Exit Sub

                        End If


                    End If

                Next

                If Detalles.SC01 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC01 Then
                        If lbGruposSup.Items.Count < 1 Then
                            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                            txtCodigo.Focus()
                            Exit Sub

                        End If
                    End If
                End If

                If Detalles.SC02 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC02 Then
                        If lbGruposSup.Items.Count < 2 Then
                            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                            txtCodigo.Focus()
                            Exit Sub

                        End If

                    End If
                End If

                If Detalles.SC03 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC03 Then
                        If lbGruposSup.Items.Count < 3 Then
                            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                            txtCodigo.Focus()
                            Exit Sub

                        End If

                    End If
                End If


                If Detalles.SC04 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC04 Then
                        If lbGruposSup.Items.Count < 4 Then
                            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                            txtCodigo.Focus()
                            Exit Sub

                        End If

                    End If
                End If

                If Detalles.SC05 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC05 Then
                        If lbGruposSup.Items.Count < 5 Then
                            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                            txtCodigo.Focus()
                            Exit Sub

                        End If

                    End If
                End If

                If Detalles.SC06 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC06 Then
                        If lbGruposSup.Items.Count < 6 Then
                            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                            txtCodigo.Focus()
                            Exit Sub

                        End If

                    End If
                End If

                If Detalles.SC07 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC07 Then
                        If lbGruposSup.Items.Count < 7 Then
                            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                            txtCodigo.Focus()
                            Exit Sub

                        End If

                    End If
                End If

                If Detalles.SC08 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC08 Then
                        If lbGruposSup.Items.Count < 8 Then
                            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                            txtCodigo.Focus()
                            Exit Sub

                        End If

                    End If
                End If

                If Detalles.SC09 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC09 Then
                        If lbGruposSup.Items.Count < 9 Then
                            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                            txtCodigo.Focus()
                            Exit Sub

                        End If

                    End If
                End If

                'If Detalles.SC01 <> 0 Then
                '    If txtCodigo.TextLength = Detalles.SC01 + 1 Then
                '        If lbGruposSup.Items.Count < 1 Then
                '            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                '            txtCodigo.Focus()
                '            Exit Sub

                '        End If
                '    End If
                'End If

                'If Detalles.SC02 <> 0 Then
                '    If txtCodigo.TextLength = Detalles.SC02 + 2 Then
                '        If lbGruposSup.Items.Count < 2 Then
                '            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                '            txtCodigo.Focus()
                '            Exit Sub

                '        End If

                '    End If
                'End If

                'If Detalles.SC03 <> 0 Then
                '    If txtCodigo.TextLength = Detalles.SC03 + 3 Then
                '        If lbGruposSup.Items.Count < 3 Then
                '            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                '            txtCodigo.Focus()
                '            Exit Sub

                '        End If

                '    End If
                'End If


                'If Detalles.SC04 <> 0 Then
                '    If txtCodigo.TextLength = Detalles.SC04 + 4 Then
                '        If lbGruposSup.Items.Count < 4 Then
                '            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                '            txtCodigo.Focus()
                '            Exit Sub

                '        End If

                '    End If
                'End If

                'If Detalles.SC05 <> 0 Then
                '    If txtCodigo.TextLength = Detalles.SC05 + 5 Then
                '        If lbGruposSup.Items.Count < 5 Then
                '            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                '            txtCodigo.Focus()
                '            Exit Sub

                '        End If

                '    End If
                'End If

                'If Detalles.SC06 <> 0 Then
                '    If txtCodigo.TextLength = Detalles.SC06 + 6 Then
                '        If lbGruposSup.Items.Count < 6 Then
                '            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                '            txtCodigo.Focus()
                '            Exit Sub

                '        End If

                '    End If
                'End If

                'If Detalles.SC07 <> 0 Then
                '    If txtCodigo.TextLength = Detalles.SC07 + 7 Then
                '        If lbGruposSup.Items.Count < 7 Then
                '            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                '            txtCodigo.Focus()
                '            Exit Sub

                '        End If

                '    End If
                'End If

                'If Detalles.SC08 <> 0 Then
                '    If txtCodigo.TextLength = Detalles.SC08 + 8 Then
                '        If lbGruposSup.Items.Count < 8 Then
                '            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                '            txtCodigo.Focus()
                '            Exit Sub

                '        End If

                '    End If
                'End If

                'If Detalles.SC09 <> 0 Then
                '    If txtCodigo.TextLength = Detalles.SC09 + 9 Then
                '        If lbGruposSup.Items.Count < 9 Then
                '            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                '            txtCodigo.Focus()
                '            Exit Sub

                '        End If

                '    End If
                'End If

                If lbGruposSup.Items.Count <> 0 Then
                    'MsgBox(lbGruposSup.Items.Item(lbGruposSup.Items.Count - 1))
                    etGruposSup.Visible = True
                    lbGruposSup.Visible = True

                    cbTipo.Items.Clear()
                    cbTipo.Items.Add("SubCuenta")
                    cbTipo.Items.Add("Auxiliar")

                    cbClase.SelectedIndex = c.GetListCodigo(lbCuenta.Items.Item(lbCuenta.Items.Count - 1), EmpresaActual).Tables("CATALOGO").Rows(0).Item("Clase")
                    cbClase.Enabled = False

                Else
                    cbTipo.Items.Clear()
                    cbTipo.Items.Add("Mayor")

                    cbClase.SelectedIndex = 0
                    cbClase.Enabled = True

                End If

            End If

        End If

        If Clipboard.GetDataObject.GetDataPresent(System.Windows.Forms.DataFormats.Text) = True Then
            Clipboard.SetDataObject(CB)

        End If

    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged
        lbGruposSup.Items.Clear()
        lbCuenta.Items.Clear()
        lbGruposSup.Visible = False
        etGruposSup.Visible = False

        cbClase.SelectedIndex = 0
        cbClase.Enabled = True

    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress

        If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
            If Char.IsDigit(e.KeyChar) = False Then
                e.Handled = True
                Exit Sub

            End If

            If txtCodigo.TextLength = txtCodigo.MaxLength Then
                e.Handled = True
                Exit Sub

            End If

            If Detalles.Espacio = True Then
                If Detalles.Mayor <> 0 Then
                    If txtCodigo.TextLength = Detalles.Mayor Then
                        txtCodigo.Text = txtCodigo.Text & " "
                        txtCodigo.SelectionStart = txtCodigo.TextLength
                        Exit Sub

                    End If

                End If

                If Detalles.SC01 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC01 Then
                        txtCodigo.Text = txtCodigo.Text & " "
                        txtCodigo.SelectionStart = txtCodigo.TextLength
                        Exit Sub

                    End If

                End If

                If Detalles.SC02 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC02 Then
                        txtCodigo.Text = txtCodigo.Text & " "
                        txtCodigo.SelectionStart = txtCodigo.TextLength
                        Exit Sub

                    End If

                End If

                If Detalles.SC03 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC03 Then
                        txtCodigo.Text = txtCodigo.Text & " "
                        txtCodigo.SelectionStart = txtCodigo.TextLength
                        Exit Sub

                    End If

                End If

                If Detalles.SC04 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC04 Then
                        txtCodigo.Text = txtCodigo.Text & " "
                        txtCodigo.SelectionStart = txtCodigo.TextLength
                        Exit Sub

                    End If

                End If

                If Detalles.SC05 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC05 Then
                        txtCodigo.Text = txtCodigo.Text & " "
                        txtCodigo.SelectionStart = txtCodigo.TextLength
                        Exit Sub

                    End If

                End If

                If Detalles.SC06 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC06 Then
                        txtCodigo.Text = txtCodigo.Text & " "
                        txtCodigo.SelectionStart = txtCodigo.TextLength
                        Exit Sub

                    End If

                End If

                If Detalles.SC07 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC07 Then
                        txtCodigo.Text = txtCodigo.Text & " "
                        txtCodigo.SelectionStart = txtCodigo.TextLength
                        Exit Sub

                    End If

                End If

                If Detalles.SC08 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC08 Then
                        txtCodigo.Text = txtCodigo.Text & " "
                        txtCodigo.SelectionStart = txtCodigo.TextLength
                        Exit Sub

                    End If

                End If

                If Detalles.SC09 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC09 Then
                        txtCodigo.Text = txtCodigo.Text & " "
                        txtCodigo.SelectionStart = txtCodigo.TextLength
                        Exit Sub

                    End If

                End If

            End If


        End If

        '    If Detalles.SC01 <> 0 Then
        '        If txtCodigo.TextLength = Detalles.SC01 + 1 Then
        '            txtCodigo.Text = txtCodigo.Text & " "
        '            txtCodigo.SelectionStart = txtCodigo.TextLength
        '            Exit Sub

        '        End If

        '    End If

        '    If Detalles.SC02 <> 0 Then
        '        If txtCodigo.TextLength = Detalles.SC02 + 2 Then
        '            txtCodigo.Text = txtCodigo.Text & " "
        '            txtCodigo.SelectionStart = txtCodigo.TextLength
        '            Exit Sub

        '        End If

        '    End If

        '    If Detalles.SC03 <> 0 Then
        '        If txtCodigo.TextLength = Detalles.SC03 + 3 Then
        '            txtCodigo.Text = txtCodigo.Text & " "
        '            txtCodigo.SelectionStart = txtCodigo.TextLength
        '            Exit Sub

        '        End If

        '    End If

        '    If Detalles.SC04 <> 0 Then
        '        If txtCodigo.TextLength = Detalles.SC04 + 4 Then
        '            txtCodigo.Text = txtCodigo.Text & " "
        '            txtCodigo.SelectionStart = txtCodigo.TextLength
        '            Exit Sub

        '        End If

        '    End If

        '    If Detalles.SC05 <> 0 Then
        '        If txtCodigo.TextLength = Detalles.SC05 + 5 Then
        '            txtCodigo.Text = txtCodigo.Text & " "
        '            txtCodigo.SelectionStart = txtCodigo.TextLength
        '            Exit Sub

        '        End If

        '    End If

        '    If Detalles.SC06 <> 0 Then
        '        If txtCodigo.TextLength = Detalles.SC06 + 6 Then
        '            txtCodigo.Text = txtCodigo.Text & " "
        '            txtCodigo.SelectionStart = txtCodigo.TextLength
        '            Exit Sub

        '        End If

        '    End If

        '    If Detalles.SC07 <> 0 Then
        '        If txtCodigo.TextLength = Detalles.SC07 + 7 Then
        '            txtCodigo.Text = txtCodigo.Text & " "
        '            txtCodigo.SelectionStart = txtCodigo.TextLength
        '            Exit Sub

        '        End If

        '    End If

        '    If Detalles.SC08 <> 0 Then
        '        If txtCodigo.TextLength = Detalles.SC08 + 8 Then
        '            txtCodigo.Text = txtCodigo.Text & " "
        '            txtCodigo.SelectionStart = txtCodigo.TextLength
        '            Exit Sub

        '        End If

        '    End If

        '    If Detalles.SC09 <> 0 Then
        '        If txtCodigo.TextLength = Detalles.SC09 + 9 Then
        '            txtCodigo.Text = txtCodigo.Text & " "
        '            txtCodigo.SelectionStart = txtCodigo.TextLength
        '            Exit Sub

        '        End If

        '    End If
        'End If

    End Sub

    Private Sub cbCuentaDe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCuentaDe.SelectedIndexChanged
        Dim grupos As New VB.SysContab.GruposDB()

        cbGrupos.Text = ""

        If cbCuentaDe.Text = "Balance" Then
            cbGrupos.DataSource = grupos.GetListBuscarCombo("%", "B").Tables("GRUPOS")
            cbGrupos.ValueMember = "CODIGO_GRUPO"
            cbGrupos.DisplayMember = "Nombre"
            TG = "B"
        ElseIf cbCuentaDe.Text = "Resultado" Then
            cbGrupos.DataSource = grupos.GetListBuscarCombo("%", "R").Tables("GRUPOS")
            cbGrupos.ValueMember = "CODIGO_GRUPO"
            cbGrupos.DisplayMember = "Nombre"
            TG = "R"
        Else
            cbGrupos.DataSource = grupos.GetListBuscarCombo("%", "P").Tables("GRUPOS")
            cbGrupos.ValueMember = "CODIGO_GRUPO"
            cbGrupos.DisplayMember = "Nombre"
            TG = "P"

        End If

    End Sub

    Private Sub cbGrupos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbGrupos.KeyPress
        Dim g As New VB.SysContab.GruposDB()

        If Microsoft.VisualBasic.Asc(e.KeyChar) < 32 Then
            If Microsoft.VisualBasic.Asc(e.KeyChar) = 27 Then
                grupos = ""
                cbGrupos.SelectAll()
                Exit Sub

            End If

            If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
                Exit Sub

            End If
        End If

        If cbGrupos.Text = "" Then
            grupos = ""
            Exit Sub
        End If

        If Microsoft.VisualBasic.Asc(e.KeyChar) = 8 Then
            If grupos.Length = 1 Then
                grupos = ""
            End If

            If grupos.Length > 1 Then
                grupos = Mid(grupos, 1, grupos.Length - 1)
            End If

            If cbGrupos.Text = "" Then
                grupos = ""
                Exit Sub

            End If

        Else
            grupos = grupos & e.KeyChar

        End If

        If g.GetListBuscarCombo(grupos, TG).Tables("GRUPOS").Rows.Count = 0 Then
            '
        Else
            cbGrupos.SelectedValue = g.GetListBuscarCombo(grupos, TG).Tables("GRUPOS").Rows(0).Item("CODIGO_GRUPO")
            cbGrupos.SelectionStart = grupos.Length
            cbGrupos.Select(grupos.Length, cbGrupos.Text.Length)

        End If

    End Sub

    Private Sub cbGrupos_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbGrupos.Leave
        Dim g As New VB.SysContab.GruposDB()

        If Trim(cbGrupos.Text) = "" Then
            grupos = ""
            Exit Sub
        End If

        If g.GetListBuscarCombo(cbGrupos.Text, TG).Tables("Grupos").Rows.Count = 0 Then
            MsgBox("Grupo no Existe", MsgBoxStyle.Information)
            grupos = ""
            cbGrupos.Focus()
            Exit Sub

        End If

        cbGrupos.SelectedValue = g.GetListBuscarCombo(cbGrupos.Text, TG).Tables("GRUPOS").Rows(0).Item("CODIGO_GRUPO")
        Cod_Grupo = g.GetListBuscarCombo(cbGrupos.Text, TG).Tables("GRUPOS").Rows(0).Item("CODIGO_GRUPO")

        grupos = ""

    End Sub

    Private Sub cbGrupos_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbGrupos.SelectedValueChanged
        grupos = ""

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim catalogo As New VB.SysContab.CatalogoDB()
        Dim grp As New VB.SysContab.GruposDB()
        Dim r As New VB.SysContab.Rutinas()
        Dim Tipo As String
        Dim CuentaD As String

        Dim i As Integer
        Dim j As Integer

        Dim saldo As Double


        If Trim(txtCodigo.Text) = "" Then
            MsgBox("Introduzca el número de la Cuenta", MsgBoxStyle.Information)
            txtCodigo.Focus()
            txtCodigo.SelectAll()
            Exit Sub
        End If

        If Trim(txtNombre.Text) = "" Then
            MsgBox("Introduzca el Nombre de la Cuenta", MsgBoxStyle.Information)
            txtNombre.Focus()
            txtNombre.SelectAll()
            Exit Sub
        End If

        If cbTipo.Text = "" Then
            MsgBox("Seleccione el Nivel de la Cuenta", MsgBoxStyle.Information)
            cbTipo.Focus()
            Exit Sub
        End If

        If Trim(cbCuentaDe.Text) = "" Then
            MsgBox("Seleccione C....", MsgBoxStyle.Information)
            cbCuentaDe.Focus()
            Exit Sub
        End If

        If Trim(cbGrupos.Text) = "" Then
            MsgBox("Seleccione el Grupo de la Cuenta", MsgBoxStyle.Information)
            cbGrupos.Focus()
            Exit Sub

        End If

        If Trim(txtSaldoInicial.Text) = "" Then
            MsgBox("Introduzca el Saldo Inicial", MsgBoxStyle.Information)
            txtSaldoInicial.Focus()
            txtSaldoInicial.SelectAll()
            Exit Sub

        End If

        If Trim(txtPresupuestoAnual.Text) = "" Then
            MsgBox("Introduzca el Presupuesto Anual Inicial", MsgBoxStyle.Information)
            txtPresupuestoAnual.Focus()
            txtPresupuestoAnual.SelectAll()
            Exit Sub

        End If

        If cbClase.SelectedIndex = 0 Then
            MsgBox("Seleccione el Tipo de Cuenta", MsgBoxStyle.Information)
            cbClase.Focus()
            Exit Sub

        End If

        If cbTipo.Text = "Mayor" Then
            Tipo = "M"
        ElseIf cbTipo.Text = "SubCuenta" Then
            Tipo = "S"
        Else
            Tipo = "A"
        End If

        If cbCuentaDe.Text = "Balance" Then
            CuentaD = "B"
        ElseIf cbCuentaDe.Text = "Resultado" Then
            CuentaD = "R"
        Else
            CuentaD = "P"
        End If

        Dim SaldoInicial As Double
        Dim PresupuestoAnual As Double
        Dim Debito As Double
        Dim Credito As Double

        SaldoInicial = txtSaldoInicial.Text
        PresupuestoAnual = txtPresupuestoAnual.Text

        If cbClase.SelectedIndex = 1 Then
            Debito = SaldoInicial
            Credito = 0
        Else
            Debito = 0
            Credito = SaldoInicial
        End If
        Dim Proveedor As Integer
        Dim Caja As Integer

        If Me.chkProveedor.Checked = True Then
            Proveedor = 1
        Else
            Proveedor = 0
        End If

        If Me.chkCajaChica.Checked = True Then
            Caja = 1
        Else
            Caja = 0
        End If

        If Nuevo = "SI" Then
            If lbCuenta.Items.Count = 0 Then
                catalogo.AddItem(Trim(txtCodigo.Text), txtNombre.Text, Tipo, CuentaD, SaldoInicial, PresupuestoAnual, cbGrupos.SelectedValue, EmpresaActual, "XXXX", cbClase.SelectedIndex, Debito, Credito, Me.cbGpo_Presupuesto.SelectedValue, Proveedor, Caja, Me.cbAgrupaciones.SelectedValue, IIf(Me.chkInventario.Checked, 1, 0), IIf(Me.chkDistribucion.Checked, 1, 0), IIf(Me.chkDeOrden.Checked, 1, 0), IIf(Me.ChkUP.Checked, 1, 0), IIf(Me.ChkUA.Checked, 1, 0), False, False, False, False, False)
            Else
                catalogo.AddItem(Trim(txtCodigo.Text), txtNombre.Text, Tipo, CuentaD, SaldoInicial, PresupuestoAnual, cbGrupos.SelectedValue, EmpresaActual, lbCuenta.Items.Item(lbCuenta.Items.Count - 1), cbClase.SelectedIndex, Debito, Credito, Me.cbGpo_Presupuesto.SelectedValue, Proveedor, Caja, Me.cbAgrupaciones.SelectedValue, IIf(Me.chkInventario.Checked, 1, 0), IIf(Me.chkDistribucion.Checked, 1, 0), IIf(Me.chkDeOrden.Checked, 1, 0), IIf(Me.ChkUP.Checked, 1, 0), IIf(Me.ChkUA.Checked, 1, 0), False, False, False, False, False)
            End If

            If CDbl(Me.txtSaldoInicial.Text) <> 0 Then
                DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
                DBConnFacturas.Open()
                transaccionFacturas = DBConnFacturas.BeginTransaction
                Try
                    catalogo.SaldoInicialAdd(Me.txtCodigo.Text, VB.SysContab.PeriodosDB.Actual, Me.txtSaldoInicial.Text)
                    catalogo.SaldoInicialActualizar(Me.txtCodigo.Text, VB.SysContab.PeriodosDB.Actual, Me.txtSaldoInicial.Text, 1)
                    VB.SysContab.Rutinas.okTransaccion()
                Catch ex As Exception
                    VB.SysContab.Rutinas.ErrorTransaccion()
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            Else
                'Borrar la cuenta de Catalogo Saldo
            End If

            'catalogo.AddItem(Trim(txtCodigo.Text), txtNombre.Text, Tipo, CuentaD, txtSaldoInicial.Text, txtPresupuestoAnual.Text, cbGrupos.SelectedValue, EmpresaActual, lbCuenta.Items.Item(lbCuenta.Items.Count - 1))

            'For i = 0 To lbCuenta.Items.Count - 1
            '    catalogo.UpdateSaldos(lbCuenta.Items.Item(i), catalogo.GetListCodigo(lbCuenta.Items.Item(i), EmpresaActual).Tables("Catalogo").Rows(0).Item("SALDO_INICIAL"), txtSaldoInicial.Text, EmpresaActual)

            'Next

            If lbCuenta.Items.Count <> 0 Then
                saldo = 0
                For i = 0 To catalogo.GetListCodigoBorrar(lbCuenta.Items.Item(lbCuenta.Items.Count - 1), EmpresaActual).Tables("Catalogo").Rows.Count - 1
                    saldo = saldo + catalogo.GetListCodigoBorrar(lbCuenta.Items.Item(lbCuenta.Items.Count - 1), EmpresaActual).Tables("Catalogo").Rows(i).Item("SALDO_INICIAL")
                Next

                catalogo.UpdateSaldosEdit(lbCuenta.Items.Item(lbCuenta.Items.Count - 1), saldo, cbClase.SelectedIndex)

                i = lbCuenta.Items.Count - 1
                While i >= 0
                    saldo = 0

                    For j = 0 To catalogo.GetListSubCuenta(catalogo.GetListCodigo(lbCuenta.Items.Item(i), EmpresaActual).Tables("Catalogo").Rows(0).Item("SUBCUENTA"), EmpresaActual).Tables("Catalogo").Rows.Count - 1
                        'MsgBox(catalogo.GetListSubCuenta(catalogo.GetListCodigo(lbCuenta.Items.Item(i), EmpresaActual).Tables("Catalogo").Rows(0).Item("SUBCUENTA"), EmpresaActual).Tables("Catalogo").Rows(j).Item("Cuenta"))
                        saldo = saldo + catalogo.GetListSubCuenta(catalogo.GetListCodigo(lbCuenta.Items.Item(i), EmpresaActual).Tables("Catalogo").Rows(0).Item("SUBCUENTA"), EmpresaActual).Tables("Catalogo").Rows(j).Item("SALDO_INICIAL")

                    Next
                    If i > 0 Then
                        catalogo.UpdateSaldosEdit(lbCuenta.Items(i - 1), saldo, cbClase.SelectedIndex)
                    End If

                    i = i - 1

                End While

            End If

            'MsgBox("El registro se ha grabado correctamente", MsgBoxStyle.Information)

            'r.LimpiarControles(GroupBox1)
            'Me.txtSaldoInicial.Text = "0.00"
            'Me.txtPresupuestoAnual.Text = "0.00"

            'cbTipo.SelectedIndex = -1
            'cbCuentaDe.SelectedIndex = -1
            'cbClase.SelectedIndex = 0
            'cbAgrupaciones.SelectedValue = -1

            'cbGrupos.Items.Clear()

            'cbGrupos.DataSource = grp.GetListBuscarCombo("%", "Y").Tables("GRUPOS")
            'cbGrupos.ValueMember = "CODIGO_GRUPO"
            'cbGrupos.DisplayMember = "Nombre"
            Me.Close()
            'txtCodigo.Focus()

        Else

            catalogo.Update(Trim(txtCodigo.Text), txtNombre.Text, Tipo, CuentaD, SaldoInicial,
                            PresupuestoAnual, cbGrupos.SelectedValue, EmpresaActual, cbClase.SelectedIndex,
                            Me.cbGpo_Presupuesto.SelectedValue, Proveedor, Caja, Me.cbAgrupaciones.SelectedValue,
                            IIf(Me.chkInventario.Checked, 1, 0), IIf(Me.chkDistribucion.Checked, 1, 0),
                            IIf(Me.chkDeOrden.Checked, 1, 0), IIf(Me.ChkUP.Checked, 1, 0), IIf(Me.ChkUA.Checked, 1, 0),
                            False, False, False, False, False, False, True, False)

            If CDbl(Me.txtSaldoInicial.Text) <> 0 Then
                DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
                DBConnFacturas.Open()
                transaccionFacturas = DBConnFacturas.BeginTransaction
                Try
                    catalogo.SaldoInicialAdd(Me.txtCodigo.Text, VB.SysContab.PeriodosDB.Actual, Me.txtSaldoInicial.Text)
                    catalogo.SaldoInicialActualizar(Me.txtCodigo.Text, VB.SysContab.PeriodosDB.Actual, Me.txtSaldoInicial.Text, 1)
                    VB.SysContab.Rutinas.okTransaccion()
                Catch ex As Exception
                    VB.SysContab.Rutinas.ErrorTransaccion()
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            Else
                'Borrar la cuenta de Catalogo Saldo
            End If

            'MsgBox("El registro se ha actualizado correctamente", MsgBoxStyle.Information)

            'catalogo.GetListCodigoBorrar(lbCuenta.Items.Item(lbCuenta.Items.Count - 1), EmpresaActual)
            'lbCuenta.Items.Count - 1
            'For i = 0 To catalogo.GetListCodigoBorrar(lbCuenta.Items.Item(lbCuenta.Items.Count - 1), EmpresaActual).Tables("Catalogo").Rows.Count - 1

            If lbCuenta.Items.Count <> 0 Then
                saldo = 0
                For i = 0 To catalogo.GetListCodigoBorrar(lbCuenta.Items.Item(lbCuenta.Items.Count - 1), EmpresaActual).Tables("Catalogo").Rows.Count - 1
                    saldo = saldo + catalogo.GetListCodigoBorrar(lbCuenta.Items.Item(lbCuenta.Items.Count - 1), EmpresaActual).Tables("Catalogo").Rows(i).Item("SALDO_INICIAL")

                Next

                catalogo.UpdateSaldosEdit(lbCuenta.Items.Item(lbCuenta.Items.Count - 1), saldo, cbClase.SelectedIndex)

                i = lbCuenta.Items.Count - 1
                While i >= 0
                    saldo = 0

                    For j = 0 To catalogo.GetListSubCuenta(catalogo.GetListCodigo(lbCuenta.Items.Item(i), EmpresaActual).Tables("Catalogo").Rows(0).Item("SUBCUENTA"), EmpresaActual).Tables("Catalogo").Rows.Count - 1
                        'MsgBox(catalogo.GetListSubCuenta(catalogo.GetListCodigo(lbCuenta.Items.Item(i), EmpresaActual).Tables("Catalogo").Rows(0).Item("SUBCUENTA"), EmpresaActual).Tables("Catalogo").Rows(j).Item("Cuenta"))
                        saldo = saldo + catalogo.GetListSubCuenta(catalogo.GetListCodigo(lbCuenta.Items.Item(i), EmpresaActual).Tables("Catalogo").Rows(0).Item("SUBCUENTA"), EmpresaActual).Tables("Catalogo").Rows(j).Item("SALDO_INICIAL")

                    Next
                    If i > 0 Then
                        catalogo.UpdateSaldosEdit(lbCuenta.Items(i - 1), saldo, cbClase.SelectedIndex)
                    End If

                    i = i - 1

                End While

            End If


            Me.Close()

        End If

    End Sub

    Private Sub frmNuevaCuenta_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        'Dim r As New VB.SysContab.Rutinas()
        'Dim catalogo As New VB.SysContab.CatalogoDB()
        'Dim cat As frmCatalogo = cat.Instance
        'Dim Tabla As New DataTable()
        'Dim ds As New DataSet()

        'ds = catalogo.GetList(cat.txtBuscar.Text)
        'cat.dgCatalogo.DataSource = catalogo.GetList(cat.txtBuscar.Text).Tables("CATALOGO").DefaultView
        'Tabla = ds.Tables("CATALOGO")

        'r.FormatGenerico(cat.dgCatalogo, Tabla)

        'If ds.Tables("CATALOGO").Rows.Count <> 0 Then
        '    Registro = cat.dgCatalogo.Item(0, 0)

        'End If

    End Sub

    Private Sub txtCodigo_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.Enter
        Dim data As DataObject
        If Clipboard.GetDataObject.GetDataPresent(System.Windows.Forms.DataFormats.Text) = True Then
            CB = Clipboard.GetDataObject.GetData(System.Windows.Forms.DataFormats.Text)
            Clipboard.SetDataObject("")

        End If

    End Sub

    Private Sub cbAgrupaciones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbAgrupaciones.KeyPress
        Dim a As New VB.SysContab.AgrupacionesDB()

        If Microsoft.VisualBasic.Asc(e.KeyChar) < 32 Then
            If Microsoft.VisualBasic.Asc(e.KeyChar) = 27 Then
                Agrupaciones = ""
                cbAgrupaciones.SelectAll()
                Exit Sub

            End If

            If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
                Exit Sub

            End If
        End If

        If cbAgrupaciones.Text = "" Then
            Agrupaciones = ""
            Exit Sub
        End If

        If Microsoft.VisualBasic.Asc(e.KeyChar) = 8 Then
            If Agrupaciones.Length = 1 Then
                Agrupaciones = ""
            End If

            If Agrupaciones.Length > 1 Then
                Agrupaciones = Mid(Agrupaciones, 1, Agrupaciones.Length - 1)
            End If

            If cbAgrupaciones.Text = "" Then
                Agrupaciones = ""
                Exit Sub

            End If

        Else
            Agrupaciones = Agrupaciones & e.KeyChar

        End If

        If a.GetListBuscarCombo(Agrupaciones).Tables("Agrupaciones").Rows.Count = 0 Then
            '
        Else
            cbAgrupaciones.SelectedValue = a.GetListBuscarCombo(grupos).Tables("Agrupaciones").Rows(0).Item("CODIGO_AGRUPACION")
            cbAgrupaciones.SelectionStart = Agrupaciones.Length
            cbAgrupaciones.Select(Agrupaciones.Length, cbAgrupaciones.Text.Length)

        End If
    End Sub

    Private Sub cbAgrupaciones_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbAgrupaciones.Leave
        Dim a As New VB.SysContab.AgrupacionesDB()

        If Trim(cbAgrupaciones.Text) = "" Then
            Agrupaciones = ""
            Exit Sub
        End If

        If a.GetListBuscarCombo(cbAgrupaciones.Text).Tables("Agrupaciones").Rows.Count = 0 Then
            MsgBox("Agrupación no Existe", MsgBoxStyle.Information)
            Agrupaciones = ""
            cbAgrupaciones.Focus()
            Exit Sub

        End If

        cbAgrupaciones.SelectedValue = a.GetListBuscarCombo(cbAgrupaciones.Text).Tables("Agrupaciones").Rows(0).Item("CODIGO_AGRUPACION")
        Cod_Agrupacion = a.GetListBuscarCombo(cbAgrupaciones.Text).Tables("Agrupaciones").Rows(0).Item("CODIGO_AGRUPACION")

        Agrupaciones = ""

    End Sub

    Private Sub cbAgrupaciones_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbAgrupaciones.SelectedValueChanged
        Agrupaciones = ""

    End Sub

    Private Sub cmdAcumulados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcumulados.Click
        Dim f As frmAcumuladosCuenta = f.Instance

        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub

    Private Sub txtSaldoInicial_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSaldoInicial.Leave
        Try
            txtSaldoInicial.Text = CDbl(txtSaldoInicial.Text).ToString(Round)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtPresupuestoAnual_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPresupuestoAnual.Leave
        Try
            txtPresupuestoAnual.Text = CDbl(txtPresupuestoAnual.Text).ToString(Round)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cbTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipo.SelectedIndexChanged
        If Me.cbTipo.Text <> "Auxiliar" Then
            Me.cbGpo_Presupuesto.SelectedValue = 0
            Me.cbGpo_Presupuesto.Enabled = False
        Else
            Me.cbGpo_Presupuesto.Enabled = True
        End If
    End Sub
End Class
