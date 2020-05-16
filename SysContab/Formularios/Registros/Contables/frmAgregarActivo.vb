Public Class frmAgregarActivo
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAgregarActivo = Nothing

    Public Shared Function Instance() As frmAgregarActivo
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarActivo()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function
    Public nEstado, nSituacion As String
    Public gp As New VB.SysContab.Grupos_DepreciacionDB()
    Public gdd As New VB.SysContab.Grupos_DepreciacionDetails()

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
    Friend WithEvents etCodigo As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbGrupoDepreciacion As System.Windows.Forms.ComboBox
    Friend WithEvents cbCuentaGastos As System.Windows.Forms.ComboBox
    Friend WithEvents cbCuentaDepreciacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents etDescripcion As System.Windows.Forms.Label
    Friend WithEvents txtCodigoBarra As System.Windows.Forms.TextBox
    Friend WithEvents txtUnidad As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha_entrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtComentarios As System.Windows.Forms.TextBox
    Friend WithEvents txtRegistro_Catastral As System.Windows.Forms.TextBox
    Friend WithEvents txtEscritura As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtRegistro As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtTomo As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents DTPFecha_Escritura As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbPropiedad As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Activo As System.Windows.Forms.TabPage
    Friend WithEvents Descripcion As System.Windows.Forms.TabPage
    Friend WithEvents Cuentas As System.Windows.Forms.TabPage
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha_Compra As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtMotor As System.Windows.Forms.TextBox
    Friend WithEvents txtChasis As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoAuto As System.Windows.Forms.TextBox
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtPlaca As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtAño As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents GBArticulo As System.Windows.Forms.GroupBox
    Friend WithEvents gbVehiculo As System.Windows.Forms.GroupBox
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents cbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents CbSituacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents gbCodigo As System.Windows.Forms.GroupBox
    Friend WithEvents gbCuentas As System.Windows.Forms.GroupBox
    Friend WithEvents gbComentarios As System.Windows.Forms.GroupBox
    Friend WithEvents gbDescripcion As System.Windows.Forms.GroupBox
    Friend WithEvents gbEstado As System.Windows.Forms.GroupBox
    Friend WithEvents cbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents txtFactura As System.Windows.Forms.TextBox
    Friend WithEvents gbValor As System.Windows.Forms.GroupBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtValorActual As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtValor_Revalorizacion As System.Windows.Forms.TextBox
    Friend WithEvents txtValor_Depreciacion As System.Windows.Forms.TextBox
    Friend WithEvents txtPorc_Revalorizacion As System.Windows.Forms.TextBox
    Friend WithEvents txtPorc_Depreciacion As System.Windows.Forms.TextBox
    Friend WithEvents txtVida_Util As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gbCodigo = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dtpFecha_Compra = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbProveedor = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpFecha_entrada = New System.Windows.Forms.DateTimePicker()
        Me.etCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCodigoBarra = New System.Windows.Forms.TextBox()
        Me.cbCuentaDepreciacion = New System.Windows.Forms.ComboBox()
        Me.cbCuentaGastos = New System.Windows.Forms.ComboBox()
        Me.cbGrupoDepreciacion = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.etDescripcion = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gbCuentas = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtRegistro_Catastral = New System.Windows.Forms.TextBox()
        Me.gbComentarios = New System.Windows.Forms.GroupBox()
        Me.txtComentarios = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.gbDescripcion = New System.Windows.Forms.GroupBox()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.GBArticulo = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.gbPropiedad = New System.Windows.Forms.GroupBox()
        Me.txtTomo = New System.Windows.Forms.TextBox()
        Me.DTPFecha_Escritura = New System.Windows.Forms.DateTimePicker()
        Me.txtRegistro = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtEscritura = New System.Windows.Forms.TextBox()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.gbVehiculo = New System.Windows.Forms.GroupBox()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtMotor = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtChasis = New System.Windows.Forms.TextBox()
        Me.txtTipoAuto = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Activo = New System.Windows.Forms.TabPage()
        Me.gbEstado = New System.Windows.Forms.GroupBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.CbSituacion = New System.Windows.Forms.ComboBox()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.Descripcion = New System.Windows.Forms.TabPage()
        Me.Cuentas = New System.Windows.Forms.TabPage()
        Me.gbValor = New System.Windows.Forms.GroupBox()
        Me.txtValor_Revalorizacion = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtValor_Depreciacion = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtPorc_Revalorizacion = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtValorActual = New System.Windows.Forms.TextBox()
        Me.txtPorc_Depreciacion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtVida_Util = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.gbCodigo.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbCuentas.SuspendLayout()
        Me.gbComentarios.SuspendLayout()
        Me.gbDescripcion.SuspendLayout()
        Me.GBArticulo.SuspendLayout()
        Me.gbPropiedad.SuspendLayout()
        Me.gbVehiculo.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Activo.SuspendLayout()
        Me.gbEstado.SuspendLayout()
        Me.Descripcion.SuspendLayout()
        Me.Cuentas.SuspendLayout()
        Me.gbValor.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCodigo
        '
        Me.gbCodigo.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label21, Me.dtpFecha_Compra, Me.Label20, Me.cbProveedor, Me.Label19, Me.txtFactura, Me.Label8, Me.dtpFecha_entrada, Me.etCodigo, Me.txtCodigo, Me.Label2, Me.txtDescripcion})
        Me.gbCodigo.Location = New System.Drawing.Point(8, 16)
        Me.gbCodigo.Name = "gbCodigo"
        Me.gbCodigo.Size = New System.Drawing.Size(712, 128)
        Me.gbCodigo.TabIndex = 8
        Me.gbCodigo.TabStop = False
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label21.Location = New System.Drawing.Point(288, 88)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(104, 24)
        Me.Label21.TabIndex = 33
        Me.Label21.Text = "Fecha Compra:"
        '
        'dtpFecha_Compra
        '
        Me.dtpFecha_Compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dtpFecha_Compra.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFecha_Compra.Location = New System.Drawing.Point(400, 88)
        Me.dtpFecha_Compra.Name = "dtpFecha_Compra"
        Me.dtpFecha_Compra.Size = New System.Drawing.Size(128, 20)
        Me.dtpFecha_Compra.TabIndex = 32
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label20.Location = New System.Drawing.Point(288, 64)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 24)
        Me.Label20.TabIndex = 31
        Me.Label20.Text = "Proveedor:"
        '
        'cbProveedor
        '
        Me.cbProveedor.Location = New System.Drawing.Point(400, 64)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Size = New System.Drawing.Size(296, 21)
        Me.cbProveedor.TabIndex = 30
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label19.Location = New System.Drawing.Point(16, 64)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 24)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "No. Factura:"
        '
        'txtFactura
        '
        Me.txtFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactura.Location = New System.Drawing.Point(128, 64)
        Me.txtFactura.MaxLength = 50
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(112, 20)
        Me.txtFactura.TabIndex = 28
        Me.txtFactura.Text = ""
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 24)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Fecha Entrada:"
        '
        'dtpFecha_entrada
        '
        Me.dtpFecha_entrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dtpFecha_entrada.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFecha_entrada.Location = New System.Drawing.Point(128, 88)
        Me.dtpFecha_entrada.Name = "dtpFecha_entrada"
        Me.dtpFecha_entrada.Size = New System.Drawing.Size(128, 20)
        Me.dtpFecha_entrada.TabIndex = 26
        '
        'etCodigo
        '
        Me.etCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.etCodigo.Location = New System.Drawing.Point(16, 16)
        Me.etCodigo.Name = "etCodigo"
        Me.etCodigo.Size = New System.Drawing.Size(72, 24)
        Me.etCodigo.TabIndex = 10
        Me.etCodigo.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(128, 16)
        Me.txtCodigo.MaxLength = 16
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(112, 20)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Descripción:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(128, 40)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(544, 20)
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.Text = ""
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 24)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Código de Barra:"
        '
        'txtCodigoBarra
        '
        Me.txtCodigoBarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoBarra.Location = New System.Drawing.Point(144, 24)
        Me.txtCodigoBarra.Name = "txtCodigoBarra"
        Me.txtCodigoBarra.Size = New System.Drawing.Size(208, 20)
        Me.txtCodigoBarra.TabIndex = 24
        Me.txtCodigoBarra.Text = ""
        '
        'cbCuentaDepreciacion
        '
        Me.cbCuentaDepreciacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCuentaDepreciacion.Location = New System.Drawing.Point(184, 80)
        Me.cbCuentaDepreciacion.Name = "cbCuentaDepreciacion"
        Me.cbCuentaDepreciacion.Size = New System.Drawing.Size(344, 21)
        Me.cbCuentaDepreciacion.TabIndex = 23
        '
        'cbCuentaGastos
        '
        Me.cbCuentaGastos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCuentaGastos.Location = New System.Drawing.Point(184, 48)
        Me.cbCuentaGastos.Name = "cbCuentaGastos"
        Me.cbCuentaGastos.Size = New System.Drawing.Size(344, 21)
        Me.cbCuentaGastos.TabIndex = 22
        '
        'cbGrupoDepreciacion
        '
        Me.cbGrupoDepreciacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGrupoDepreciacion.Location = New System.Drawing.Point(184, 16)
        Me.cbGrupoDepreciacion.Name = "cbGrupoDepreciacion"
        Me.cbGrupoDepreciacion.Size = New System.Drawing.Size(344, 21)
        Me.cbGrupoDepreciacion.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 24)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Cuenta de Depreciación:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 24)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Cuenta de Gastos:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 24)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Grupo de Depreciación:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Location = New System.Drawing.Point(384, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 24)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Unidad:"
        '
        'txtUnidad
        '
        Me.txtUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnidad.Location = New System.Drawing.Point(448, 24)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(88, 20)
        Me.txtUnidad.TabIndex = 11
        Me.txtUnidad.Text = ""
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Location = New System.Drawing.Point(16, 48)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 24)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Location = New System.Drawing.Point(16, 16)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 24)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "Aceptar"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.etDescripcion})
        Me.GroupBox3.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(856, 32)
        Me.GroupBox3.TabIndex = 114
        Me.GroupBox3.TabStop = False
        '
        'etDescripcion
        '
        Me.etDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.etDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcion.ForeColor = System.Drawing.Color.White
        Me.etDescripcion.Location = New System.Drawing.Point(8, 8)
        Me.etDescripcion.Name = "etDescripcion"
        Me.etDescripcion.Size = New System.Drawing.Size(840, 20)
        Me.etDescripcion.TabIndex = 113
        Me.etDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdAceptar, Me.cmdCancelar})
        Me.GroupBox2.Location = New System.Drawing.Point(768, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(104, 464)
        Me.GroupBox2.TabIndex = 115
        Me.GroupBox2.TabStop = False
        '
        'gbCuentas
        '
        Me.gbCuentas.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label5, Me.cbCuentaGastos, Me.Label4, Me.cbGrupoDepreciacion, Me.Label6, Me.cbCuentaDepreciacion})
        Me.gbCuentas.Location = New System.Drawing.Point(16, 32)
        Me.gbCuentas.Name = "gbCuentas"
        Me.gbCuentas.Size = New System.Drawing.Size(712, 112)
        Me.gbCuentas.TabIndex = 116
        Me.gbCuentas.TabStop = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 24)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Registro Catastral:"
        '
        'txtRegistro_Catastral
        '
        Me.txtRegistro_Catastral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRegistro_Catastral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegistro_Catastral.Location = New System.Drawing.Point(144, 16)
        Me.txtRegistro_Catastral.Name = "txtRegistro_Catastral"
        Me.txtRegistro_Catastral.Size = New System.Drawing.Size(208, 20)
        Me.txtRegistro_Catastral.TabIndex = 32
        Me.txtRegistro_Catastral.Text = ""
        '
        'gbComentarios
        '
        Me.gbComentarios.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtComentarios, Me.Label12})
        Me.gbComentarios.Location = New System.Drawing.Point(8, 144)
        Me.gbComentarios.Name = "gbComentarios"
        Me.gbComentarios.Size = New System.Drawing.Size(712, 104)
        Me.gbComentarios.TabIndex = 117
        Me.gbComentarios.TabStop = False
        '
        'txtComentarios
        '
        Me.txtComentarios.Location = New System.Drawing.Point(128, 16)
        Me.txtComentarios.Multiline = True
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.Size = New System.Drawing.Size(480, 80)
        Me.txtComentarios.TabIndex = 18
        Me.txtComentarios.Text = ""
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 24)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Comentarios:"
        '
        'gbDescripcion
        '
        Me.gbDescripcion.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbTipo, Me.GBArticulo, Me.Label18, Me.gbPropiedad, Me.gbVehiculo})
        Me.gbDescripcion.Location = New System.Drawing.Point(16, 8)
        Me.gbDescripcion.Name = "gbDescripcion"
        Me.gbDescripcion.Size = New System.Drawing.Size(712, 384)
        Me.gbDescripcion.TabIndex = 118
        Me.gbDescripcion.TabStop = False
        '
        'cbTipo
        '
        Me.cbTipo.Items.AddRange(New Object() {"Artículo", "Propiedad", "Vehículo"})
        Me.cbTipo.Location = New System.Drawing.Point(128, 16)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(160, 21)
        Me.cbTipo.TabIndex = 47
        '
        'GBArticulo
        '
        Me.GBArticulo.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtCodigoBarra, Me.Label7, Me.txtUnidad, Me.Label1})
        Me.GBArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBArticulo.Location = New System.Drawing.Point(8, 40)
        Me.GBArticulo.Name = "GBArticulo"
        Me.GBArticulo.Size = New System.Drawing.Size(696, 64)
        Me.GBArticulo.TabIndex = 46
        Me.GBArticulo.TabStop = False
        Me.GBArticulo.Text = "ARTICULO / BIEN"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label18.Location = New System.Drawing.Point(16, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 24)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "Tipo Activo:"
        '
        'gbPropiedad
        '
        Me.gbPropiedad.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label11, Me.txtTomo, Me.txtRegistro_Catastral, Me.DTPFecha_Escritura, Me.txtRegistro, Me.Label17, Me.txtEscritura, Me.txtFolio, Me.Label16, Me.Label13, Me.Label14, Me.Label15})
        Me.gbPropiedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPropiedad.Location = New System.Drawing.Point(8, 112)
        Me.gbPropiedad.Name = "gbPropiedad"
        Me.gbPropiedad.Size = New System.Drawing.Size(696, 96)
        Me.gbPropiedad.TabIndex = 44
        Me.gbPropiedad.TabStop = False
        Me.gbPropiedad.Text = "PROPIEDAD"
        '
        'txtTomo
        '
        Me.txtTomo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTomo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTomo.Location = New System.Drawing.Point(472, 40)
        Me.txtTomo.Name = "txtTomo"
        Me.txtTomo.Size = New System.Drawing.Size(208, 20)
        Me.txtTomo.TabIndex = 38
        Me.txtTomo.Text = ""
        '
        'DTPFecha_Escritura
        '
        Me.DTPFecha_Escritura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.DTPFecha_Escritura.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DTPFecha_Escritura.Location = New System.Drawing.Point(144, 64)
        Me.DTPFecha_Escritura.Name = "DTPFecha_Escritura"
        Me.DTPFecha_Escritura.Size = New System.Drawing.Size(128, 20)
        Me.DTPFecha_Escritura.TabIndex = 42
        '
        'txtRegistro
        '
        Me.txtRegistro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegistro.Location = New System.Drawing.Point(472, 16)
        Me.txtRegistro.Name = "txtRegistro"
        Me.txtRegistro.Size = New System.Drawing.Size(208, 20)
        Me.txtRegistro.TabIndex = 36
        Me.txtRegistro.Text = ""
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label17.Location = New System.Drawing.Point(16, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(120, 24)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "Fecha Escritura:"
        '
        'txtEscritura
        '
        Me.txtEscritura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEscritura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEscritura.Location = New System.Drawing.Point(144, 40)
        Me.txtEscritura.Name = "txtEscritura"
        Me.txtEscritura.Size = New System.Drawing.Size(208, 20)
        Me.txtEscritura.TabIndex = 34
        Me.txtEscritura.Text = ""
        '
        'txtFolio
        '
        Me.txtFolio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFolio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFolio.Location = New System.Drawing.Point(472, 64)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(208, 20)
        Me.txtFolio.TabIndex = 40
        Me.txtFolio.Text = ""
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label16.Location = New System.Drawing.Point(400, 64)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 24)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "Folio:"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(136, 24)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Escritura:"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label14.Location = New System.Drawing.Point(400, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 24)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Registro:"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label15.Location = New System.Drawing.Point(400, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 24)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Tomo:"
        '
        'gbVehiculo
        '
        Me.gbVehiculo.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtAño, Me.Label32, Me.txtPlaca, Me.Label31, Me.txtColor, Me.Label26, Me.Label25, Me.txtModelo, Me.txtMotor, Me.txtMarca, Me.txtChasis, Me.txtTipoAuto, Me.Label27, Me.Label28, Me.Label29, Me.Label30})
        Me.gbVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbVehiculo.Location = New System.Drawing.Point(8, 208)
        Me.gbVehiculo.Name = "gbVehiculo"
        Me.gbVehiculo.Size = New System.Drawing.Size(696, 128)
        Me.gbVehiculo.TabIndex = 45
        Me.gbVehiculo.TabStop = False
        Me.gbVehiculo.Text = "VEHICULO"
        '
        'txtAño
        '
        Me.txtAño.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAño.Location = New System.Drawing.Point(472, 88)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(208, 20)
        Me.txtAño.TabIndex = 46
        Me.txtAño.Text = ""
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label32.Location = New System.Drawing.Point(400, 88)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(72, 24)
        Me.Label32.TabIndex = 47
        Me.Label32.Text = "Año:"
        '
        'txtPlaca
        '
        Me.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaca.Location = New System.Drawing.Point(472, 64)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(208, 20)
        Me.txtPlaca.TabIndex = 44
        Me.txtPlaca.Text = ""
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label31.Location = New System.Drawing.Point(400, 64)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(72, 24)
        Me.Label31.TabIndex = 45
        Me.Label31.Text = "Placa:"
        '
        'txtColor
        '
        Me.txtColor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor.Location = New System.Drawing.Point(472, 40)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(208, 20)
        Me.txtColor.TabIndex = 42
        Me.txtColor.Text = ""
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label26.Location = New System.Drawing.Point(400, 40)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 24)
        Me.Label26.TabIndex = 43
        Me.Label26.Text = "Color:"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label25.Location = New System.Drawing.Point(16, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(128, 24)
        Me.Label25.TabIndex = 33
        Me.Label25.Text = "Motor:"
        '
        'txtModelo
        '
        Me.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(144, 88)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(208, 20)
        Me.txtModelo.TabIndex = 38
        Me.txtModelo.Text = ""
        '
        'txtMotor
        '
        Me.txtMotor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMotor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotor.Location = New System.Drawing.Point(144, 16)
        Me.txtMotor.Name = "txtMotor"
        Me.txtMotor.Size = New System.Drawing.Size(208, 20)
        Me.txtMotor.TabIndex = 32
        Me.txtMotor.Text = ""
        '
        'txtMarca
        '
        Me.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(144, 64)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(208, 20)
        Me.txtMarca.TabIndex = 36
        Me.txtMarca.Text = ""
        '
        'txtChasis
        '
        Me.txtChasis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtChasis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChasis.Location = New System.Drawing.Point(144, 40)
        Me.txtChasis.Name = "txtChasis"
        Me.txtChasis.Size = New System.Drawing.Size(208, 20)
        Me.txtChasis.TabIndex = 34
        Me.txtChasis.Text = ""
        '
        'txtTipoAuto
        '
        Me.txtTipoAuto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoAuto.Location = New System.Drawing.Point(472, 16)
        Me.txtTipoAuto.Name = "txtTipoAuto"
        Me.txtTipoAuto.Size = New System.Drawing.Size(208, 20)
        Me.txtTipoAuto.TabIndex = 40
        Me.txtTipoAuto.Text = ""
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label27.Location = New System.Drawing.Point(400, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(72, 24)
        Me.Label27.TabIndex = 41
        Me.Label27.Text = "Tipo Auto:"
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label28.Location = New System.Drawing.Point(16, 40)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(136, 24)
        Me.Label28.TabIndex = 35
        Me.Label28.Text = "Chasis"
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label29.Location = New System.Drawing.Point(16, 64)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(72, 24)
        Me.Label29.TabIndex = 37
        Me.Label29.Text = "Marca:"
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label30.Location = New System.Drawing.Point(16, 88)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(56, 24)
        Me.Label30.TabIndex = 39
        Me.Label30.Text = "Modelo:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Activo, Me.Descripcion, Me.Cuentas})
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(16, 48)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(744, 464)
        Me.TabControl1.TabIndex = 119
        '
        'Activo
        '
        Me.Activo.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Activo.Controls.AddRange(New System.Windows.Forms.Control() {Me.gbEstado, Me.gbCodigo, Me.gbComentarios})
        Me.Activo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Activo.Location = New System.Drawing.Point(4, 25)
        Me.Activo.Name = "Activo"
        Me.Activo.Size = New System.Drawing.Size(736, 435)
        Me.Activo.TabIndex = 0
        Me.Activo.Text = "Activo"
        '
        'gbEstado
        '
        Me.gbEstado.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label34, Me.Label33, Me.CbSituacion, Me.cbEstado})
        Me.gbEstado.Location = New System.Drawing.Point(8, 248)
        Me.gbEstado.Name = "gbEstado"
        Me.gbEstado.Size = New System.Drawing.Size(712, 96)
        Me.gbEstado.TabIndex = 119
        Me.gbEstado.TabStop = False
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label34.Location = New System.Drawing.Point(16, 48)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(72, 24)
        Me.Label34.TabIndex = 19
        Me.Label34.Text = "Situación:"
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label33.Location = New System.Drawing.Point(16, 18)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(96, 24)
        Me.Label33.TabIndex = 18
        Me.Label33.Text = "Estado:"
        '
        'CbSituacion
        '
        Me.CbSituacion.Items.AddRange(New Object() {"En Uso", "Desuso", "Almacén"})
        Me.CbSituacion.Location = New System.Drawing.Point(128, 48)
        Me.CbSituacion.Name = "CbSituacion"
        Me.CbSituacion.Size = New System.Drawing.Size(160, 21)
        Me.CbSituacion.TabIndex = 1
        '
        'cbEstado
        '
        Me.cbEstado.Items.AddRange(New Object() {"Perfecto", "Regular", "Mal"})
        Me.cbEstado.Location = New System.Drawing.Point(128, 18)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(160, 21)
        Me.cbEstado.TabIndex = 0
        '
        'Descripcion
        '
        Me.Descripcion.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Descripcion.Controls.AddRange(New System.Windows.Forms.Control() {Me.gbDescripcion})
        Me.Descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descripcion.Location = New System.Drawing.Point(4, 25)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(736, 435)
        Me.Descripcion.TabIndex = 1
        Me.Descripcion.Text = "Descripción"
        '
        'Cuentas
        '
        Me.Cuentas.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Cuentas.Controls.AddRange(New System.Windows.Forms.Control() {Me.gbValor, Me.gbCuentas})
        Me.Cuentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cuentas.Location = New System.Drawing.Point(4, 25)
        Me.Cuentas.Name = "Cuentas"
        Me.Cuentas.Size = New System.Drawing.Size(736, 435)
        Me.Cuentas.TabIndex = 2
        Me.Cuentas.Text = "Cuentas/Valores"
        '
        'gbValor
        '
        Me.gbValor.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtVida_Util, Me.Label35, Me.txtValor_Depreciacion, Me.Label24, Me.txtValorActual, Me.txtPorc_Depreciacion, Me.Label10, Me.Label3, Me.txtPrecio, Me.Label9, Me.txtPorc_Revalorizacion, Me.Label22, Me.txtValor_Revalorizacion, Me.Label23})
        Me.gbValor.Location = New System.Drawing.Point(16, 144)
        Me.gbValor.Name = "gbValor"
        Me.gbValor.Size = New System.Drawing.Size(712, 120)
        Me.gbValor.TabIndex = 119
        Me.gbValor.TabStop = False
        '
        'txtValor_Revalorizacion
        '
        Me.txtValor_Revalorizacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValor_Revalorizacion.Enabled = False
        Me.txtValor_Revalorizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor_Revalorizacion.Location = New System.Drawing.Point(616, 48)
        Me.txtValor_Revalorizacion.Name = "txtValor_Revalorizacion"
        Me.txtValor_Revalorizacion.Size = New System.Drawing.Size(88, 20)
        Me.txtValor_Revalorizacion.TabIndex = 36
        Me.txtValor_Revalorizacion.Text = ""
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label23.Location = New System.Drawing.Point(472, 48)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(144, 24)
        Me.Label23.TabIndex = 37
        Me.Label23.Text = "Valor Revalorización:"
        '
        'txtValor_Depreciacion
        '
        Me.txtValor_Depreciacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValor_Depreciacion.Enabled = False
        Me.txtValor_Depreciacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor_Depreciacion.Location = New System.Drawing.Point(376, 72)
        Me.txtValor_Depreciacion.Name = "txtValor_Depreciacion"
        Me.txtValor_Depreciacion.Size = New System.Drawing.Size(88, 20)
        Me.txtValor_Depreciacion.TabIndex = 34
        Me.txtValor_Depreciacion.Text = ""
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label24.Location = New System.Drawing.Point(240, 72)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(128, 24)
        Me.Label24.TabIndex = 35
        Me.Label24.Text = "Valor Depreciación"
        '
        'txtPorc_Revalorizacion
        '
        Me.txtPorc_Revalorizacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPorc_Revalorizacion.Enabled = False
        Me.txtPorc_Revalorizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorc_Revalorizacion.Location = New System.Drawing.Point(616, 24)
        Me.txtPorc_Revalorizacion.Name = "txtPorc_Revalorizacion"
        Me.txtPorc_Revalorizacion.Size = New System.Drawing.Size(88, 20)
        Me.txtPorc_Revalorizacion.TabIndex = 32
        Me.txtPorc_Revalorizacion.Text = ""
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label22.Location = New System.Drawing.Point(472, 24)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(120, 24)
        Me.Label22.TabIndex = 33
        Me.Label22.Text = "% Revalorización:"
        '
        'txtValorActual
        '
        Me.txtValorActual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValorActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorActual.Location = New System.Drawing.Point(144, 48)
        Me.txtValorActual.Name = "txtValorActual"
        Me.txtValorActual.Size = New System.Drawing.Size(88, 20)
        Me.txtValorActual.TabIndex = 28
        Me.txtValorActual.Text = ""
        '
        'txtPorc_Depreciacion
        '
        Me.txtPorc_Depreciacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPorc_Depreciacion.Enabled = False
        Me.txtPorc_Depreciacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorc_Depreciacion.Location = New System.Drawing.Point(376, 24)
        Me.txtPorc_Depreciacion.Name = "txtPorc_Depreciacion"
        Me.txtPorc_Depreciacion.Size = New System.Drawing.Size(88, 20)
        Me.txtPorc_Depreciacion.TabIndex = 30
        Me.txtPorc_Depreciacion.Text = ""
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label10.Location = New System.Drawing.Point(240, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 24)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "% Depreciación:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 24)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Precio de Compra:"
        '
        'txtPrecio
        '
        Me.txtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(144, 24)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(88, 20)
        Me.txtPrecio.TabIndex = 13
        Me.txtPrecio.Text = ""
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 24)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Valor en Libros:"
        '
        'txtVida_Util
        '
        Me.txtVida_Util.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVida_Util.Enabled = False
        Me.txtVida_Util.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVida_Util.Location = New System.Drawing.Point(376, 48)
        Me.txtVida_Util.Name = "txtVida_Util"
        Me.txtVida_Util.Size = New System.Drawing.Size(88, 20)
        Me.txtVida_Util.TabIndex = 36
        Me.txtVida_Util.Text = ""
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label35.Location = New System.Drawing.Point(240, 48)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(112, 24)
        Me.Label35.TabIndex = 37
        Me.Label35.Text = "Años Vida Útil:"
        '
        'frmAgregarActivo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(880, 517)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TabControl1, Me.GroupBox2, Me.GroupBox3})
        Me.Name = "frmAgregarActivo"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.WindowState = FormWindowState.Maximized
        Me.gbCodigo.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.gbCuentas.ResumeLayout(False)
        Me.gbComentarios.ResumeLayout(False)
        Me.gbDescripcion.ResumeLayout(False)
        Me.GBArticulo.ResumeLayout(False)
        Me.gbPropiedad.ResumeLayout(False)
        Me.gbVehiculo.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.Activo.ResumeLayout(False)
        Me.gbEstado.ResumeLayout(False)
        Me.Descripcion.ResumeLayout(False)
        Me.Cuentas.ResumeLayout(False)
        Me.gbValor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAgregarActivo_Fijo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim r As New VB.SysContab.Rutinas()
        Dim Activo_Fijo As New VB.SysContab.Activo_FijosDB()
        Dim g As New VB.SysContab.Grupos_InventarioDB()
        Dim Catalogo As New VB.SysContab.CatalogoDB()
        Dim p As New VB.SysContab.ProveedoresDB()

        cbCuentaGastos.DataSource = Catalogo.GetListBuscarCombo("%", EmpresaActual).Tables("CATALOGO")
        cbCuentaGastos.ValueMember = "CUENTA"
        cbCuentaGastos.DisplayMember = "NOMBRE"

        cbCuentaDepreciacion.DataSource = Catalogo.GetListBuscarCombo("%", EmpresaActual).Tables("CATALOGO")
        cbCuentaDepreciacion.ValueMember = "CUENTA"
        cbCuentaDepreciacion.DisplayMember = "NOMBRE"

        Me.cbGrupoDepreciacion.DataSource = gp.GetListBuscarCombo("%").Tables("Grupos_Depreciacion")
        Me.cbGrupoDepreciacion.ValueMember = "CODIGO_GRUPO_DEPRECIACION"
        Me.cbGrupoDepreciacion.DisplayMember = "DESCRIPCION"

        Me.cbProveedor.DataSource = p.ProveedoresListCombo().Tables("Proveedores")
        Me.cbProveedor.ValueMember = "CODIGO"
        Me.cbProveedor.DisplayMember = "NOMBRE"

        'cbProveedor.SelectedIndex = -1
        'cbProveedor.SelectedItem = 0
        'cbProveedor.Refresh()

        'r.CambiarEstilo(Me)
        Me.dtpFecha_entrada.Value = Today
        'Me.txtPrecio.Text.Format  = "###,###,##0.00"
        'Me.txtValorActual.Text.Format = "###,###,##0.00"
        If Nuevo = "NO" Then
            Me.Text = "Agregar Activo Fijo"
            etDescripcion.Text = "Editar Activo Fijo"

            Dim Detalles As VB.SysContab.Activo_FijosDetails = Activo_Fijo.GetDetails(Registro)
            Me.txtCodigo.Text = Detalles.Codigo
            Me.txtDescripcion.Text = Detalles.Descripcion
            Me.txtPrecio.Text = Detalles.Precio
            Me.txtValorActual.Text = Detalles.Valor_Libros
            Me.dtpFecha_entrada.Value = IIf(IsDBNull(Detalles.Fecha_Entrada), Today, Detalles.Fecha_Entrada)
            Me.cbCuentaDepreciacion.SelectedValue = Detalles.Cuenta_Depreciacion
            Me.cbCuentaGastos.SelectedValue = Detalles.Cuenta_Gastos
            Me.cbGrupoDepreciacion.SelectedValue = Detalles.Grupo_Depreciacion
            Me.cbTipo.SelectedItem = IIf(Detalles.Tipo = "A", "Artículo", IIf(Detalles.Tipo = "P", "Propiedad", "Vehículo"))
            Me.cbEstado.SelectedItem = IIf(Detalles.Estado = "P", "Perfecto", IIf(Detalles.Estado = "R", "Regular", "Mal"))
            Me.CbSituacion.SelectedItem = IIf(Detalles.Situacion = "U", "En Uso", IIf(Detalles.Situacion = "D", "Desuso", "Almacén"))
            Me.txtComentarios.Text = Detalles.Comentarios
            Me.cbProveedor.SelectedValue = Detalles.Proveedor
            Me.txtFactura.Text = Detalles.factura
            If Me.cbTipo.SelectedItem = "Artículo" Then
                Me.txtCodigoBarra.Text = Detalles.ArticuloDetail.Codigo_Barra
                Me.txtUnidad.Text = Detalles.ArticuloDetail.Unidad
            ElseIf Me.cbTipo.SelectedItem = "Propiedad" Then
                Me.txtRegistro_Catastral.Text = Detalles.PropiedadDetail.Registro_Catastral
                Me.txtEscritura.Text = Detalles.PropiedadDetail.Escritura
                Me.txtRegistro.Text = Detalles.PropiedadDetail.Registro
                Me.txtFolio.Text = Detalles.PropiedadDetail.Folio
                Me.txtTomo.Text = Detalles.PropiedadDetail.Tomo
                Me.DTPFecha_Escritura.Value = Detalles.PropiedadDetail.Fecha_Escritura
            Else
                Me.txtAño.Text = Detalles.VehiculoDetail.Año
                Me.txtChasis.Text = Detalles.VehiculoDetail.Chasis
                Me.txtColor.Text = Detalles.VehiculoDetail.Color
                Me.txtMarca.Text = Detalles.VehiculoDetail.Marca
                Me.txtModelo.Text = Detalles.VehiculoDetail.Modelo
                Me.txtMotor.Text = Detalles.VehiculoDetail.Motor
                Me.txtPlaca.Text = Detalles.VehiculoDetail.Placa
                Me.txtTipoAuto.Text = Detalles.VehiculoDetail.TipoAuto
            End If
            Me.GBArticulo.Enabled = False
            Me.gbCodigo.Enabled = False
            Me.gbComentarios.Enabled = True
            Me.gbCuentas.Enabled = False
            Me.gbDescripcion.Enabled = False
            Me.gbEstado.Enabled = True
            Me.gbPropiedad.Enabled = False
            Me.gbValor.Enabled = False
            Me.gbVehiculo.Enabled = False
        Else
            Me.Text = "Editar Activo Fijo"
            Me.txtPrecio.Text = "0.00"
            Me.txtValorActual.Text = "0.00"

        End If

        Me.Refresh()

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()

    End Sub

    Private Sub frmAgregarActivo_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim r As New VB.SysContab.Rutinas()
        Dim Activo_Fijos As New VB.SysContab.Activo_FijosDB()
        Dim a As frmActivos = a.Instance
        Dim Tabla As New DataTable()
        Dim ds As New DataSet()

        ds = Activo_Fijos.GetList("%")
        a.dgActivos_Fijos.DataSource = Activo_Fijos.GetList("%").Tables("Activo_Fijos").DefaultView
        Tabla = ds.Tables("Activo_Fijos")

        r.FormatGenerico(a.dgActivos_Fijos, Tabla)

        If ds.Tables("Activo_Fijos").Rows.Count <> 0 Then
            Registro = a.dgActivos_Fijos.Item(0, 0)
        End If
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        Dim Activo As New VB.SysContab.Activo_FijosDB()
        Dim r As New VB.SysContab.Rutinas()


        If Nuevo = "SI" Then
            If Me.cbTipo.SelectedItem = "Artículo" Then
                Activo.AddItem_Articulo(txtCodigo.Text, txtDescripcion.Text, txtPrecio.Text, cbGrupoDepreciacion.SelectedValue, cbCuentaGastos.SelectedValue, cbCuentaDepreciacion.SelectedValue, Me.dtpFecha_entrada.Value.Date, txtCodigoBarra.Text, txtUnidad.Text, nEstado, nSituacion, Me.cbTipo.SelectedItem, Me.txtFactura.Text, Me.cbProveedor.SelectedValue, Me.txtComentarios.Text)
            ElseIf Me.cbTipo.SelectedItem = "Propiedad" Then
                Activo.AddItem_Propiedad(txtCodigo.Text, txtDescripcion.Text, txtPrecio.Text, cbGrupoDepreciacion.SelectedValue, cbCuentaGastos.SelectedValue, cbCuentaDepreciacion.SelectedValue, Me.dtpFecha_entrada.Value.Date, Me.txtRegistro_Catastral.Text, Me.txtEscritura.Text, Me.DTPFecha_Escritura.Value.Date, Me.txtRegistro.Text, Me.txtTomo.Text, Me.txtFolio.Text, nEstado, nSituacion, Me.cbTipo.SelectedItem, Me.txtComentarios.Text)
            Else
                Activo.AddItem_Vehiculo(txtCodigo.Text, txtDescripcion.Text, txtPrecio.Text, cbGrupoDepreciacion.SelectedValue, cbCuentaGastos.SelectedValue, cbCuentaDepreciacion.SelectedValue, Me.dtpFecha_entrada.Value.Date, nEstado, nSituacion, Me.cbTipo.SelectedItem, Me.txtMotor.Text, Me.txtChasis.Text, Me.txtMarca.Text, Me.txtModelo.Text, Me.txtTipoAuto.Text, Me.txtColor.Text, Me.txtPlaca.Text, Me.txtAño.Text, Me.txtFactura.Text, Me.cbProveedor.SelectedValue, Me.txtComentarios.Text)
            End If
            'Activo.AddItem(txtCodigo.Text, txtDescripcion.Text, txtCodigoBarra.Text, txtUnidad.Text, txtPrecio.Text, cbGrupoDepreciacion.SelectedValue, cbCuentaGastos.SelectedValue, cbCuentaDepreciacion.SelectedValue, Me.dtpFecha_entrada.Value.Date, Me.txtRegistro_Catastral.Text, Me.txtEscritura.Text, Me.DTPFecha_Escritura.Value.Date, Me.txtRegistro.Text, Me.txtTomo.Text, Me.txtFolio.Text)
            'MsgBox("El registro se a grabado correctamente", MsgBoxStyle.Information)

            'r.LimpiarControles(gbCodigo)

            'Me.cbCuentaDepreciacion.SelectedValue = -1
            'Me.cbCuentaGastos.SelectedValue = -1

            'cbCuentaDepreciacion.SelectedValue = -1
            'cbCuentaGastos.SelectedValue = -1

            'cbCuentaDepreciacion.Text = ""
            'cbCuentaGastos.Text = ""

            'txtCodigo.Focus()
            Me.Close()

        Else
            'Dim Detalles As VB.SysContab.Activo_FijosDetails = Activo.GetDetails(Registro)
            If Me.cbTipo.SelectedItem = "Artículo" Then
                Activo.UpdateItem_Articulo(txtCodigo.Text, txtDescripcion.Text, txtPrecio.Text, cbGrupoDepreciacion.SelectedValue, cbCuentaGastos.SelectedValue, cbCuentaDepreciacion.SelectedValue, Me.dtpFecha_entrada.Value.Date, txtCodigoBarra.Text, txtUnidad.Text, nEstado, nSituacion, Me.cbTipo.SelectedItem, Me.txtFactura.Text, Me.cbProveedor.SelectedValue, Me.txtComentarios.Text)
            ElseIf Me.cbTipo.SelectedItem = "Propiedad" Then
                Activo.UpdateItem_Propiedad(txtCodigo.Text, txtDescripcion.Text, txtPrecio.Text, cbGrupoDepreciacion.SelectedValue, cbCuentaGastos.SelectedValue, cbCuentaDepreciacion.SelectedValue, Me.dtpFecha_entrada.Value.Date, Me.txtRegistro_Catastral.Text, Me.txtEscritura.Text, Me.DTPFecha_Escritura.Value.Date, Me.txtRegistro.Text, Me.txtTomo.Text, Me.txtFolio.Text, nEstado, nSituacion, Me.cbTipo.SelectedItem, Me.txtComentarios.Text)
            Else
                Activo.UpdateItem_Vehiculo(txtCodigo.Text, txtDescripcion.Text, txtPrecio.Text, cbGrupoDepreciacion.SelectedValue, cbCuentaGastos.SelectedValue, cbCuentaDepreciacion.SelectedValue, Me.dtpFecha_entrada.Value.Date, nEstado, nSituacion, Me.cbTipo.SelectedItem, Me.txtMotor.Text, Me.txtChasis.Text, Me.txtMarca.Text, Me.txtModelo.Text, Me.txtTipoAuto.Text, Me.txtColor.Text, Me.txtPlaca.Text, Me.txtAño.Text, Me.txtFactura.Text, Me.cbProveedor.SelectedValue, Me.txtComentarios.Text)
            End If

            'Activo.Update(txtCodigo.Text, txtDescripcion.Text, txtCodigoBarra.Text, txtUnidad.Text, Me.dtpFecha_entrada.Value.Date, txtPrecio.Text, cbGrupoDepreciacion.SelectedValue, cbCuentaGastos.SelectedValue, cbCuentaDepreciacion.SelectedValue, Me.txtRegistro_Catastral.Text, Me.txtEscritura.Text, Me.DTPFecha_Escritura.Value.Date, Me.txtRegistro.Text, Me.txtTomo.Text, Me.txtFolio.Text)
            'Articulo.Update(txtCodigo.Text, txtNombre.Text, Cod_Proveedor, cbLinea.SelectedValue, cbGrupo.SelectedValue, cbSubGrupo.SelectedValue, txtModelo.Text, txtUnidad.Text, txtPresentacion.Text, txtPVCordoba.Text, txtPVDolar.Text, txtCosto.Text, txtMargen.Text, txtExistencias.Text, txtStockMin.Text, txtStockMax.Text, txtDescuentoA.Text, txtDescuentoB.Text, txtDescuentoC.Text, txtTasaCambio.Text, EmpresaActual)
            'Articulo.Update(txtCodigo.Text, txtNombre.Text, Cod_Proveedor, Cod_Linea, Cod_Grupo, Cod_SubGrupo, txtModelo.Text, txtUnidad.Text, txtPresentacion.Text, txtUbicacion.Text, txtPVCordoba.Text, txtPVDolar.Text, txtCosto.Text, txtMargen.Text, txtExistencias.Text, txtStockMin.Text, txtStockMax.Text, txtDescuentoA.Text, txtDescuentoB.Text, txtDescuentoC.Text, txtTasaCambio.Text, EmpresaActual)
            'MsgBox("El registro se ha actualizado correctamente", MsgBoxStyle.Information)
            Me.Close()

        End If

    End Sub

    

    Private Sub cbTipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTipo.SelectedIndexChanged
        If Me.cbTipo.SelectedItem = "Artículo" Then
            Me.GBArticulo.Enabled = True
            Me.gbPropiedad.Enabled = False
            Me.gbVehiculo.Enabled = False
        ElseIf Me.cbTipo.SelectedItem = "Propiedad" Then
            Me.GBArticulo.Enabled = False
            Me.gbPropiedad.Enabled = True
            Me.gbVehiculo.Enabled = False
        Else
            Me.GBArticulo.Enabled = False
            Me.gbPropiedad.Enabled = False
            Me.gbVehiculo.Enabled = True

        End If
    End Sub

    Private Sub cbEstado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbEstado.SelectedIndexChanged
        If Me.cbEstado.SelectedItem = "Perfecto" Then
            nEstado = "P"
        ElseIf Me.cbEstado.SelectedItem = "Regular" Then
            nEstado = "R"
        Else
            nEstado = "M"
        End If
    End Sub

    Private Sub CbSituacion_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbSituacion.SelectedIndexChanged
        If Me.CbSituacion.SelectedItem = "En Uso" Then
            nSituacion = "U"
        ElseIf Me.CbSituacion.SelectedItem = "Desuso" Then
            nSituacion = "D"
        Else
            nSituacion = "A"
        End If
    End Sub

    Private Sub txtPrecio_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPrecio.Validating
        Me.txtValorActual.Text = Me.txtPrecio.Text
        If IsNumeric(Me.cbGrupoDepreciacion.SelectedValue) Then
            Me.txtVida_Util.Text = gdd.Vida_Util
            Me.txtPorc_Depreciacion.Text = gdd.Porcentaje
            Me.txtPorc_Revalorizacion.Text = gdd.Porcentaje_Revaloracion
            Me.txtValor_Depreciacion.Text = (Me.txtPrecio.Text * (gdd.Porcentaje / 100)) / IIf(gdd.Vida_Util = 0, 1, (gdd.Vida_Util * 12))
            Me.txtValor_Revalorizacion.Text = (Me.txtPrecio.Text * (gdd.Porcentaje_Revaloracion / 100)) '/ (gdd.Vida_Util * 12)
        End If

    End Sub

    Private Sub cbGrupoDepreciacion_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbGrupoDepreciacion.SelectedIndexChanged
        If IsNumeric(Me.cbGrupoDepreciacion.SelectedValue) Then
            gdd = gp.GetDetails(Me.cbGrupoDepreciacion.SelectedValue)
            'If Me.txtPrecio.Text > 0 Then
            '    Me.txtVida_Util.Text = gdd.Vida_Util
            '    Me.txtPorc_Depreciacion.Text = gdd.Porcentaje
            '    Me.txtPorc_Revalorizacion.Text = gdd.Porcentaje_Revaloracion
            '    Me.txtValor_Depreciacion.Text = (Me.txtPrecio.Text * (gdd.Porcentaje / 100)) / IIf(gdd.Vida_Util = 0, 1, (gdd.Vida_Util * 12))
            '    Me.txtValor_Revalorizacion.Text = (Me.txtPrecio.Text * (gdd.Porcentaje_Revaloracion / 100)) '/ (gdd.Vida_Util * 12)

            'End If
        End If
    End Sub
End Class
