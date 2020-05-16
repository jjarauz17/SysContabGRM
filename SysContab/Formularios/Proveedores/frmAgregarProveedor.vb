Public Class frmAgregarProveedor
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAgregarProveedor = Nothing

    Public Shared Function Instance() As frmAgregarProveedor
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarProveedor()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance

    End Function

    Dim cuenta As String
    Dim Cod_Cuenta As String
    Dim NombresParecidos As DataSet = Nothing
    Dim RUC_ANTERIOR As String
    Dim Ced_ANTERIOR As String
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkVarios As System.Windows.Forms.CheckBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents rbExtranjero As System.Windows.Forms.RadioButton
    Friend WithEvents rbNacional As System.Windows.Forms.RadioButton
    Friend WithEvents chkRetenedor As System.Windows.Forms.CheckBox
    Friend WithEvents chkExento As System.Windows.Forms.CheckBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents cbFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cbZona As System.Windows.Forms.ComboBox
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCiudad As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbCatalogo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents vCat1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbCuentaTransito As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents vCat2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtPrefijo As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents cbDepartamentos As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbMunicipios As DevExpress.XtraEditors.LookUpEdit
    Dim Nombre_Anterior As String


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
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAcumulado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents etInicio As System.Windows.Forms.Label
    Friend WithEvents cmdEstadoCuenta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDevoluciones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNotasCreditos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents TPGenerales As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TPContactos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtsApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtpApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtnNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents verOtrosProveedores As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbTipoProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtRuc As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtEmailContacto As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtCargoContacto As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTelefonoContacto As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtEncargado As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtEmailGerente As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTelefonoGerente As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCelularGerente As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtGerente As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtEmailContador As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCelularContador As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtTelefonoContador As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtContador As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAcumulado = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdNotasCreditos = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdDevoluciones = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdEstadoCuenta = New DevExpress.XtraEditors.SimpleButton()
        Me.etInicio = New System.Windows.Forms.Label()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.TPGenerales = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbMunicipios = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbDepartamentos = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtPrefijo = New System.Windows.Forms.TextBox()
        Me.cbCuentaTransito = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.vCat2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbCatalogo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.vCat1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.cbFormaPago = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbZona = New System.Windows.Forms.ComboBox()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkVarios = New System.Windows.Forms.CheckBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.rbExtranjero = New System.Windows.Forms.RadioButton()
        Me.rbNacional = New System.Windows.Forms.RadioButton()
        Me.chkRetenedor = New System.Windows.Forms.CheckBox()
        Me.chkExento = New System.Windows.Forms.CheckBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtCodigo2 = New System.Windows.Forms.TextBox()
        Me.txtsApellido = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtpApellido = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtnNombre = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.verOtrosProveedores = New DevExpress.XtraEditors.SimpleButton()
        Me.cbTipoProveedor = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TPContactos = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtEmailContacto = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtCargoContacto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTelefonoContacto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEncargado = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtEmailGerente = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTelefonoGerente = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCelularGerente = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtGerente = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtEmailContador = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCelularContador = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtTelefonoContador = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtContador = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.TPGenerales.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cbMunicipios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDepartamentos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCuentaTransito.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vCat2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vCat1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TPContactos.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Appearance.Options.UseForeColor = True
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(8, 218)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(96, 34)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "&Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Appearance.Options.UseForeColor = True
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Location = New System.Drawing.Point(8, 17)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(96, 35)
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Text = "&Guardar"
        '
        'cmdAcumulado
        '
        Me.cmdAcumulado.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAcumulado.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdAcumulado.Appearance.Options.UseFont = True
        Me.cmdAcumulado.Appearance.Options.UseForeColor = True
        Me.cmdAcumulado.Location = New System.Drawing.Point(8, 98)
        Me.cmdAcumulado.Name = "cmdAcumulado"
        Me.cmdAcumulado.Size = New System.Drawing.Size(96, 34)
        Me.cmdAcumulado.TabIndex = 2
        Me.cmdAcumulado.Text = "&Acumulado"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.cmdNotasCreditos)
        Me.GroupBox2.Controls.Add(Me.cmdDevoluciones)
        Me.GroupBox2.Controls.Add(Me.cmdEstadoCuenta)
        Me.GroupBox2.Controls.Add(Me.etInicio)
        Me.GroupBox2.Controls.Add(Me.cmdAceptar)
        Me.GroupBox2.Controls.Add(Me.cmdCancelar)
        Me.GroupBox2.Controls.Add(Me.cmdAcumulado)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(896, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(112, 462)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'cmdNotasCreditos
        '
        Me.cmdNotasCreditos.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNotasCreditos.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdNotasCreditos.Appearance.Options.UseFont = True
        Me.cmdNotasCreditos.Appearance.Options.UseForeColor = True
        Me.cmdNotasCreditos.Location = New System.Drawing.Point(8, 178)
        Me.cmdNotasCreditos.Name = "cmdNotasCreditos"
        Me.cmdNotasCreditos.Size = New System.Drawing.Size(96, 34)
        Me.cmdNotasCreditos.TabIndex = 4
        Me.cmdNotasCreditos.Text = "&Notas de Créditos"
        '
        'cmdDevoluciones
        '
        Me.cmdDevoluciones.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDevoluciones.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdDevoluciones.Appearance.Options.UseFont = True
        Me.cmdDevoluciones.Appearance.Options.UseForeColor = True
        Me.cmdDevoluciones.Location = New System.Drawing.Point(8, 138)
        Me.cmdDevoluciones.Name = "cmdDevoluciones"
        Me.cmdDevoluciones.Size = New System.Drawing.Size(96, 35)
        Me.cmdDevoluciones.TabIndex = 3
        Me.cmdDevoluciones.Text = "&Devoluciones"
        '
        'cmdEstadoCuenta
        '
        Me.cmdEstadoCuenta.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEstadoCuenta.Appearance.Options.UseFont = True
        Me.cmdEstadoCuenta.Location = New System.Drawing.Point(8, 58)
        Me.cmdEstadoCuenta.Name = "cmdEstadoCuenta"
        Me.cmdEstadoCuenta.Size = New System.Drawing.Size(96, 34)
        Me.cmdEstadoCuenta.TabIndex = 1
        Me.cmdEstadoCuenta.Text = "Estado de &Cuenta"
        '
        'etInicio
        '
        Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etInicio.Location = New System.Drawing.Point(19, 332)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(32, 26)
        Me.etInicio.TabIndex = 160
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.XtraTabControl1.Appearance.Options.UseBackColor = True
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.Location = New System.Drawing.Point(6, 1)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.TPGenerales
        Me.XtraTabControl1.Size = New System.Drawing.Size(888, 487)
        Me.XtraTabControl1.TabIndex = 118
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TPGenerales, Me.TPContactos})
        '
        'TPGenerales
        '
        Me.TPGenerales.Appearance.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TPGenerales.Appearance.Header.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TPGenerales.Appearance.Header.Options.UseBackColor = True
        Me.TPGenerales.Appearance.HeaderActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TPGenerales.Appearance.HeaderActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TPGenerales.Appearance.HeaderActive.Options.UseBackColor = True
        Me.TPGenerales.Appearance.HeaderDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TPGenerales.Appearance.HeaderDisabled.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TPGenerales.Appearance.HeaderDisabled.Options.UseBackColor = True
        Me.TPGenerales.Appearance.HeaderHotTracked.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TPGenerales.Appearance.HeaderHotTracked.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TPGenerales.Appearance.HeaderHotTracked.Options.UseBackColor = True
        Me.TPGenerales.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TPGenerales.Appearance.PageClient.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TPGenerales.Appearance.PageClient.Options.UseBackColor = True
        Me.TPGenerales.Controls.Add(Me.GroupBox1)
        Me.TPGenerales.Name = "TPGenerales"
        Me.TPGenerales.Size = New System.Drawing.Size(882, 458)
        Me.TPGenerales.Text = "Datos Generales"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbMunicipios)
        Me.GroupBox1.Controls.Add(Me.cbDepartamentos)
        Me.GroupBox1.Controls.Add(Me.txtPrefijo)
        Me.GroupBox1.Controls.Add(Me.cbCuentaTransito)
        Me.GroupBox1.Controls.Add(Me.cbCatalogo)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Controls.Add(Me.cbFormaPago)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.cbZona)
        Me.GroupBox1.Controls.Add(Me.cbTipo)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtCorreo)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtFax)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtCiudad)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.txtCodigo2)
        Me.GroupBox1.Controls.Add(Me.txtsApellido)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.txtpApellido)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.txtnNombre)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.txtCedula)
        Me.GroupBox1.Controls.Add(Me.Label36)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.verOtrosProveedores)
        Me.GroupBox1.Controls.Add(Me.cbTipoProveedor)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtRuc)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(882, 458)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cbMunicipios
        '
        Me.cbMunicipios.Location = New System.Drawing.Point(137, 210)
        Me.cbMunicipios.Name = "cbMunicipios"
        Me.cbMunicipios.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMunicipios.Properties.Appearance.Options.UseFont = True
        Me.cbMunicipios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMunicipios.Size = New System.Drawing.Size(336, 20)
        Me.cbMunicipios.TabIndex = 207
        '
        'cbDepartamentos
        '
        Me.cbDepartamentos.Location = New System.Drawing.Point(137, 181)
        Me.cbDepartamentos.Name = "cbDepartamentos"
        Me.cbDepartamentos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDepartamentos.Properties.Appearance.Options.UseFont = True
        Me.cbDepartamentos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbDepartamentos.Size = New System.Drawing.Size(336, 20)
        Me.cbDepartamentos.TabIndex = 206
        '
        'txtPrefijo
        '
        Me.txtPrefijo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrefijo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrefijo.Location = New System.Drawing.Point(674, 10)
        Me.txtPrefijo.MaxLength = 5
        Me.txtPrefijo.Name = "txtPrefijo"
        Me.txtPrefijo.Size = New System.Drawing.Size(165, 21)
        Me.txtPrefijo.TabIndex = 205
        '
        'cbCuentaTransito
        '
        Me.cbCuentaTransito.Location = New System.Drawing.Point(137, 398)
        Me.cbCuentaTransito.Name = "cbCuentaTransito"
        Me.cbCuentaTransito.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCuentaTransito.Properties.Appearance.Options.UseFont = True
        Me.cbCuentaTransito.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCuentaTransito.Properties.NullText = "--- Seleccione Cuenta Contable ---"
        Me.cbCuentaTransito.Properties.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.cbCuentaTransito.Properties.View = Me.vCat2
        Me.cbCuentaTransito.Size = New System.Drawing.Size(335, 20)
        Me.cbCuentaTransito.TabIndex = 204
        '
        'vCat2
        '
        Me.vCat2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.vCat2.Name = "vCat2"
        Me.vCat2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.vCat2.OptionsView.ShowGroupPanel = False
        '
        'cbCatalogo
        '
        Me.cbCatalogo.Location = New System.Drawing.Point(137, 371)
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCatalogo.Properties.Appearance.Options.UseFont = True
        Me.cbCatalogo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo.Properties.NullText = "--- Seleccione Cuenta Contable ---"
        Me.cbCatalogo.Properties.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.cbCatalogo.Properties.View = Me.vCat1
        Me.cbCatalogo.Size = New System.Drawing.Size(335, 20)
        Me.cbCatalogo.TabIndex = 203
        '
        'vCat1
        '
        Me.vCat1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.vCat1.Name = "vCat1"
        Me.vCat1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.vCat1.OptionsView.ShowGroupPanel = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label32.Location = New System.Drawing.Point(42, 214)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(78, 16)
        Me.Label32.TabIndex = 202
        Me.Label32.Text = "Municipio:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label33.Location = New System.Drawing.Point(66, 185)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(54, 16)
        Me.Label33.TabIndex = 201
        Me.Label33.Text = "Depto:"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbFormaPago
        '
        Me.cbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFormaPago.ItemHeight = 15
        Me.cbFormaPago.Location = New System.Drawing.Point(504, 425)
        Me.cbFormaPago.Name = "cbFormaPago"
        Me.cbFormaPago.Size = New System.Drawing.Size(232, 23)
        Me.cbFormaPago.TabIndex = 191
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(379, 432)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(119, 16)
        Me.Label21.TabIndex = 200
        Me.Label21.Text = "Forma de Pago:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label34.Location = New System.Drawing.Point(-1, 403)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(121, 16)
        Me.Label34.TabIndex = 199
        Me.Label34.Text = "Cuenta Tránsito:"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(60, 376)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 16)
        Me.Label20.TabIndex = 198
        Me.Label20.Text = "Cuenta:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbZona
        '
        Me.cbZona.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbZona.ItemHeight = 15
        Me.cbZona.Location = New System.Drawing.Point(136, 262)
        Me.cbZona.Name = "cbZona"
        Me.cbZona.Size = New System.Drawing.Size(337, 23)
        Me.cbZona.TabIndex = 184
        '
        'cbTipo
        '
        Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipo.Items.AddRange(New Object() {"Productos", "Servicios", "Productos y Servicios", "Servicios Basicos"})
        Me.cbTipo.Location = New System.Drawing.Point(136, 425)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(232, 23)
        Me.cbTipo.TabIndex = 190
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(64, 349)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 16)
        Me.Label17.TabIndex = 197
        Me.Label17.Text = "E-Mail:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCorreo
        '
        Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(137, 345)
        Me.txtCorreo.MaxLength = 50
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(336, 20)
        Me.txtCorreo.TabIndex = 187
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(13, 432)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 16)
        Me.Label9.TabIndex = 196
        Me.Label9.Text = "Proveedor de:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(73, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 195
        Me.Label3.Text = "Zona:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFax
        '
        Me.txtFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFax.Location = New System.Drawing.Point(137, 318)
        Me.txtFax.MaxLength = 50
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(231, 21)
        Me.txtFax.TabIndex = 186
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(80, 323)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 16)
        Me.Label7.TabIndex = 194
        Me.Label7.Text = "FAX:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(137, 291)
        Me.txtTelefono.MaxLength = 50
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(231, 21)
        Me.txtTelefono.TabIndex = 185
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(46, 296)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 193
        Me.Label5.Text = "Teléfono:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCiudad
        '
        Me.txtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiudad.Location = New System.Drawing.Point(137, 235)
        Me.txtCiudad.MaxLength = 100
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(336, 21)
        Me.txtCiudad.TabIndex = 183
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(59, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 16)
        Me.Label4.TabIndex = 192
        Me.Label4.Text = "Ciudad:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkVarios)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.rbExtranjero)
        Me.GroupBox3.Controls.Add(Me.rbNacional)
        Me.GroupBox3.Controls.Add(Me.chkRetenedor)
        Me.GroupBox3.Controls.Add(Me.chkExento)
        Me.GroupBox3.Location = New System.Drawing.Point(568, 186)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(168, 180)
        Me.GroupBox3.TabIndex = 180
        Me.GroupBox3.TabStop = False
        '
        'chkVarios
        '
        Me.chkVarios.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkVarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVarios.ForeColor = System.Drawing.Color.Maroon
        Me.chkVarios.Location = New System.Drawing.Point(40, 20)
        Me.chkVarios.Name = "chkVarios"
        Me.chkVarios.Size = New System.Drawing.Size(110, 25)
        Me.chkVarios.TabIndex = 20
        Me.chkVarios.Text = "Varios"
        Me.chkVarios.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label30.Location = New System.Drawing.Point(17, 100)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(67, 26)
        Me.Label30.TabIndex = 137
        Me.Label30.Text = "Origen:"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rbExtranjero
        '
        Me.rbExtranjero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbExtranjero.ForeColor = System.Drawing.Color.Maroon
        Me.rbExtranjero.Location = New System.Drawing.Point(46, 147)
        Me.rbExtranjero.Name = "rbExtranjero"
        Me.rbExtranjero.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rbExtranjero.Size = New System.Drawing.Size(104, 26)
        Me.rbExtranjero.TabIndex = 24
        Me.rbExtranjero.Text = "Extranjero"
        '
        'rbNacional
        '
        Me.rbNacional.Checked = True
        Me.rbNacional.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbNacional.ForeColor = System.Drawing.Color.Maroon
        Me.rbNacional.Location = New System.Drawing.Point(46, 123)
        Me.rbNacional.Name = "rbNacional"
        Me.rbNacional.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rbNacional.Size = New System.Drawing.Size(104, 26)
        Me.rbNacional.TabIndex = 23
        Me.rbNacional.TabStop = True
        Me.rbNacional.Text = "Nacional"
        '
        'chkRetenedor
        '
        Me.chkRetenedor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkRetenedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRetenedor.ForeColor = System.Drawing.Color.Maroon
        Me.chkRetenedor.Location = New System.Drawing.Point(4, 44)
        Me.chkRetenedor.Name = "chkRetenedor"
        Me.chkRetenedor.Size = New System.Drawing.Size(146, 26)
        Me.chkRetenedor.TabIndex = 21
        Me.chkRetenedor.Text = "Recaudador IVA"
        Me.chkRetenedor.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chkExento
        '
        Me.chkExento.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkExento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkExento.ForeColor = System.Drawing.Color.Maroon
        Me.chkExento.Location = New System.Drawing.Point(20, 71)
        Me.chkExento.Name = "chkExento"
        Me.chkExento.Size = New System.Drawing.Size(130, 26)
        Me.chkExento.TabIndex = 22
        Me.chkExento.Text = "Exento IR"
        Me.chkExento.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label31.Location = New System.Drawing.Point(291, 12)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(156, 16)
        Me.Label31.TabIndex = 178
        Me.Label31.Text = "Código Alfanumerico:"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCodigo2
        '
        Me.txtCodigo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo2.Location = New System.Drawing.Point(453, 9)
        Me.txtCodigo2.MaxLength = 10
        Me.txtCodigo2.Name = "txtCodigo2"
        Me.txtCodigo2.Size = New System.Drawing.Size(152, 21)
        Me.txtCodigo2.TabIndex = 1
        '
        'txtsApellido
        '
        Me.txtsApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsApellido.Location = New System.Drawing.Point(504, 112)
        Me.txtsApellido.MaxLength = 25
        Me.txtsApellido.Name = "txtsApellido"
        Me.txtsApellido.Size = New System.Drawing.Size(232, 21)
        Me.txtsApellido.TabIndex = 8
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(414, 117)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(84, 16)
        Me.Label29.TabIndex = 175
        Me.Label29.Text = "S. Apellido"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtpApellido
        '
        Me.txtpApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtpApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpApellido.Location = New System.Drawing.Point(136, 112)
        Me.txtpApellido.MaxLength = 25
        Me.txtpApellido.Name = "txtpApellido"
        Me.txtpApellido.Size = New System.Drawing.Size(232, 21)
        Me.txtpApellido.TabIndex = 7
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(32, 117)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(88, 16)
        Me.Label28.TabIndex = 173
        Me.Label28.Text = "P. Apellido:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtnNombre
        '
        Me.txtnNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnNombre.Location = New System.Drawing.Point(136, 86)
        Me.txtnNombre.MaxLength = 50
        Me.txtnNombre.Name = "txtnNombre"
        Me.txtnNombre.Size = New System.Drawing.Size(600, 21)
        Me.txtnNombre.TabIndex = 6
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(53, 91)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(67, 16)
        Me.Label25.TabIndex = 171
        Me.Label25.Text = "Nombre:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCedula
        '
        Me.txtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCedula.Enabled = False
        Me.txtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(584, 60)
        Me.txtCedula.MaxLength = 20
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(152, 21)
        Me.txtCedula.TabIndex = 5
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label36.Location = New System.Drawing.Point(611, 12)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(57, 16)
        Me.Label36.TabIndex = 169
        Me.Label36.Text = "Prefijo:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(523, 60)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(61, 16)
        Me.Label24.TabIndex = 169
        Me.Label24.Text = "Cédula:"
        '
        'verOtrosProveedores
        '
        Me.verOtrosProveedores.Enabled = False
        Me.verOtrosProveedores.Location = New System.Drawing.Point(630, 33)
        Me.verOtrosProveedores.Name = "verOtrosProveedores"
        Me.verOtrosProveedores.Size = New System.Drawing.Size(80, 22)
        Me.verOtrosProveedores.TabIndex = 164
        Me.verOtrosProveedores.Text = "Ver Nombres "
        '
        'cbTipoProveedor
        '
        Me.cbTipoProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoProveedor.Items.AddRange(New Object() {"Jurídico", "Natural"})
        Me.cbTipoProveedor.Location = New System.Drawing.Point(136, 59)
        Me.cbTipoProveedor.Name = "cbTipoProveedor"
        Me.cbTipoProveedor.Size = New System.Drawing.Size(176, 23)
        Me.cbTipoProveedor.TabIndex = 3
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(76, 66)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(44, 16)
        Me.Label22.TabIndex = 140
        Me.Label22.Text = "Tipo:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(136, 9)
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(152, 21)
        Me.txtCodigo.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(58, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 16)
        Me.Label13.TabIndex = 137
        Me.Label13.Text = "Código:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRuc
        '
        Me.txtRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.Location = New System.Drawing.Point(368, 59)
        Me.txtRuc.MaxLength = 20
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(152, 21)
        Me.txtRuc.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(320, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 26)
        Me.Label8.TabIndex = 102
        Me.Label8.Text = "RUC:"
        '
        'txtDireccion
        '
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(136, 139)
        Me.txtDireccion.MaxLength = 150
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDireccion.Size = New System.Drawing.Size(703, 33)
        Me.txtDireccion.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(42, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "Dirección:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(136, 34)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(488, 21)
        Me.txtNombre.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(49, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "R.Social:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TPContactos
        '
        Me.TPContactos.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TPContactos.Appearance.PageClient.Options.UseBackColor = True
        Me.TPContactos.Controls.Add(Me.GroupBox6)
        Me.TPContactos.Controls.Add(Me.GroupBox4)
        Me.TPContactos.Controls.Add(Me.GroupBox5)
        Me.TPContactos.Name = "TPContactos"
        Me.TPContactos.Size = New System.Drawing.Size(882, 458)
        Me.TPContactos.Text = "Contactos"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.Label26)
        Me.GroupBox6.Controls.Add(Me.txtEmailContacto)
        Me.GroupBox6.Controls.Add(Me.Label23)
        Me.GroupBox6.Controls.Add(Me.txtCargoContacto)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.txtTelefonoContacto)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.txtEncargado)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox6.Location = New System.Drawing.Point(8, 9)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(840, 103)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "CONTACTO"
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(448, 52)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(64, 26)
        Me.Label26.TabIndex = 92
        Me.Label26.Text = "E-Mail:"
        '
        'txtEmailContacto
        '
        Me.txtEmailContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailContacto.Location = New System.Drawing.Point(520, 52)
        Me.txtEmailContacto.MaxLength = 50
        Me.txtEmailContacto.Name = "txtEmailContacto"
        Me.txtEmailContacto.Size = New System.Drawing.Size(312, 20)
        Me.txtEmailContacto.TabIndex = 3
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(448, 17)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 26)
        Me.Label23.TabIndex = 88
        Me.Label23.Text = "Cargo:"
        '
        'txtCargoContacto
        '
        Me.txtCargoContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCargoContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargoContacto.Location = New System.Drawing.Point(520, 17)
        Me.txtCargoContacto.MaxLength = 50
        Me.txtCargoContacto.Name = "txtCargoContacto"
        Me.txtCargoContacto.Size = New System.Drawing.Size(312, 20)
        Me.txtCargoContacto.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(8, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 26)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Teléfono:"
        '
        'txtTelefonoContacto
        '
        Me.txtTelefonoContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoContacto.Location = New System.Drawing.Point(96, 52)
        Me.txtTelefonoContacto.MaxLength = 50
        Me.txtTelefonoContacto.Name = "txtTelefonoContacto"
        Me.txtTelefonoContacto.Size = New System.Drawing.Size(344, 20)
        Me.txtTelefonoContacto.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(8, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 26)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "Contácto:"
        '
        'txtEncargado
        '
        Me.txtEncargado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEncargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEncargado.Location = New System.Drawing.Point(96, 17)
        Me.txtEncargado.MaxLength = 50
        Me.txtEncargado.Name = "txtEncargado"
        Me.txtEncargado.Size = New System.Drawing.Size(344, 20)
        Me.txtEncargado.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.txtEmailGerente)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.txtTelefonoGerente)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txtCelularGerente)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txtGerente)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(8, 121)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(840, 129)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GERENTE"
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(8, 95)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(80, 26)
        Me.Label27.TabIndex = 90
        Me.Label27.Text = "E-Mail:"
        '
        'txtEmailGerente
        '
        Me.txtEmailGerente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailGerente.Location = New System.Drawing.Point(96, 95)
        Me.txtEmailGerente.MaxLength = 50
        Me.txtEmailGerente.Name = "txtEmailGerente"
        Me.txtEmailGerente.Size = New System.Drawing.Size(312, 20)
        Me.txtEmailGerente.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(8, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 26)
        Me.Label15.TabIndex = 64
        Me.Label15.Text = "Teléfono:"
        '
        'txtTelefonoGerente
        '
        Me.txtTelefonoGerente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoGerente.Location = New System.Drawing.Point(96, 60)
        Me.txtTelefonoGerente.MaxLength = 50
        Me.txtTelefonoGerente.Name = "txtTelefonoGerente"
        Me.txtTelefonoGerente.Size = New System.Drawing.Size(120, 20)
        Me.txtTelefonoGerente.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(224, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 26)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Celular:"
        '
        'txtCelularGerente
        '
        Me.txtCelularGerente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelularGerente.Location = New System.Drawing.Point(296, 60)
        Me.txtCelularGerente.MaxLength = 50
        Me.txtCelularGerente.Name = "txtCelularGerente"
        Me.txtCelularGerente.Size = New System.Drawing.Size(112, 20)
        Me.txtCelularGerente.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(8, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 26)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "Nombre:"
        '
        'txtGerente
        '
        Me.txtGerente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGerente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGerente.Location = New System.Drawing.Point(96, 26)
        Me.txtGerente.MaxLength = 50
        Me.txtGerente.Name = "txtGerente"
        Me.txtGerente.Size = New System.Drawing.Size(312, 20)
        Me.txtGerente.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.txtEmailContador)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.txtCelularContador)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.txtTelefonoContador)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.txtContador)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox5.Location = New System.Drawing.Point(8, 258)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(840, 130)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "CONTADOR"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(8, 95)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 26)
        Me.Label18.TabIndex = 90
        Me.Label18.Text = "E-Mail:"
        '
        'txtEmailContador
        '
        Me.txtEmailContador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailContador.Location = New System.Drawing.Point(96, 95)
        Me.txtEmailContador.MaxLength = 50
        Me.txtEmailContador.Name = "txtEmailContador"
        Me.txtEmailContador.Size = New System.Drawing.Size(336, 20)
        Me.txtEmailContador.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(224, 60)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 26)
        Me.Label16.TabIndex = 66
        Me.Label16.Text = "Celular:"
        '
        'txtCelularContador
        '
        Me.txtCelularContador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelularContador.Location = New System.Drawing.Point(296, 60)
        Me.txtCelularContador.MaxLength = 50
        Me.txtCelularContador.Name = "txtCelularContador"
        Me.txtCelularContador.Size = New System.Drawing.Size(136, 20)
        Me.txtCelularContador.TabIndex = 2
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(8, 60)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 26)
        Me.Label19.TabIndex = 64
        Me.Label19.Text = "Teléfono:"
        '
        'txtTelefonoContador
        '
        Me.txtTelefonoContador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoContador.Location = New System.Drawing.Point(96, 60)
        Me.txtTelefonoContador.MaxLength = 50
        Me.txtTelefonoContador.Name = "txtTelefonoContador"
        Me.txtTelefonoContador.Size = New System.Drawing.Size(120, 20)
        Me.txtTelefonoContador.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(8, 26)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 26)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "Nombre:"
        '
        'txtContador
        '
        Me.txtContador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContador.Location = New System.Drawing.Point(96, 26)
        Me.txtContador.MaxLength = 50
        Me.txtContador.Name = "txtContador"
        Me.txtContador.Size = New System.Drawing.Size(336, 20)
        Me.txtContador.TabIndex = 0
        '
        'frmAgregarProveedor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(50, 0)
        Me.ClientSize = New System.Drawing.Size(1016, 495)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmAgregarProveedor"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.TPGenerales.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cbMunicipios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDepartamentos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCuentaTransito.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vCat2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vCat1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.TPContactos.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Proveedores As New VB.SysContab.ProveedoresDB
    Public Detalles As VB.SysContab.ProveedoresDetails

    Private Sub frmAgregarProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim z As New VB.SysContab.ZonasDB
        Dim r As New VB.SysContab.Rutinas
        Dim f As New VB.SysContab.Forma_PagoDB
        Dim Catalogo As New VB.SysContab.CatalogoDB

        Dim Dpto As New VB.SysContab.DepartamentosCDB

        Combo(cbDepartamentos, VB.SysContab.DepartamentosCDB.List())
        cbDepartamentos.ItemIndex = 0

        'r.FormularioColor(Me)
        'cbDepartamentos.DataSource = VB.SysContab.DepartamentosCDB.List().Tables("DepartamentosC")
        'cbDepartamentos.ValueMember = "Codigo"
        'cbDepartamentos.DisplayMember = "Nombre"

        cbZona.DataSource = z.GetListBuscarCombo()
        cbZona.ValueMember = "Codigo"
        cbZona.DisplayMember = "Nombre"

        GetCatalogoCuenta(Me.cbCatalogo, Me.vCat1)
        GetCatalogoCuenta(Me.cbCuentaTransito, Me.vCat2)

        'cbCatalogo.DataSource = Catalogo.GetListBuscarCombo("%", EmpresaActual).Tables("CATALOGO")
        'cbCatalogo.ValueMember = "CUENTA"
        'cbCatalogo.DisplayMember = "NOMBRE"

        'cbCuentaTransito.DataSource = Catalogo.GetListBuscarCombo("%", EmpresaActual).Tables("CATALOGO")
        'cbCuentaTransito.ValueMember = "CUENTA"
        'cbCuentaTransito.DisplayMember = "NOMBRE"

        cbFormaPago.DataSource = f.GetList(0)
        cbFormaPago.ValueMember = "Codigo"
        cbFormaPago.DisplayMember = "Nombre"

        cbTipo.SelectedIndex = 0
        cbTipoProveedor.SelectedIndex = 0

        Me.txtCodigo.ReadOnly = True

        If Nuevo = "NO" Then
            Me.Text = "Editar Proveedor"
            'Me.etDescripcion.Text = "Editar Proveedor".ToUpper
            'txtCodigo.Enabled = False

            Detalles = VB.SysContab.ProveedoresDB.GetDetails(Registro)
            'Me.txtCodigo.Text = "P-" & Format(CInt(Detalles.Codigo), "0000")
            Me.txtCodigo.Text = Detalles.Codigo
            Me.txtCodigo.ReadOnly = True
            Me.txtCodigo.Enabled = False

            Me.txtCodigo2.Text = Detalles.CodigoLetra
            Me.Nombre_Anterior = Detalles.Nombre

            Me.txtnNombre.Text = Detalles.nNombre
            Me.txtpApellido.Text = Detalles.pApellido
            Me.txtsApellido.Text = Detalles.sApellido

            Me.txtNombre.Text = Detalles.Nombre
            Me.txtEncargado.Text = Detalles.Encargado
            Me.txtCargoContacto.Text = Detalles.Cargo
            Me.txtTelefonoContacto.Text = Detalles.Telefono_Contacto
            Me.txtEmailContacto.Text = Detalles.Email_Contacto
            Me.txtGerente.Text = Detalles.Gerente
            Me.txtTelefonoGerente.Text = Detalles.Telefono_Gerente
            Me.txtCelularGerente.Text = Detalles.Celular_Gerente
            Me.txtEmailGerente.Text = Detalles.Email_Gerente
            Me.txtContador.Text = Detalles.Contador
            Me.txtTelefonoContador.Text = Detalles.Telefono_Contador
            Me.txtCelularContador.Text = Detalles.Celular_Contador
            Me.txtEmailContador.Text = Detalles.Email_Contador
            Me.txtDireccion.Text = Detalles.Direccion
            Me.txtCiudad.Text = Detalles.Ciudad
            Me.txtTelefono.Text = Detalles.Telefono
            Me.txtFax.Text = Detalles.Fax
            Me.txtCorreo.Text = Detalles.Correo
            Me.RUC_ANTERIOR = Detalles.Ruc
            Me.Ced_ANTERIOR = Detalles.Cedula
            Me.txtRuc.Text = Detalles.Ruc
            Me.txtCedula.Text = Detalles.Cedula
            If Detalles.Origen = False Then rbNacional.Checked = True Else rbExtranjero.Checked = True
            cbTipo.SelectedIndex = Detalles.Tipo - 1

            Me.cbDepartamentos.EditValue = Detalles.Departamento
            Me.cbMunicipios.EditValue = Detalles.Municipio
            Me.cbCuentaTransito.EditValue = Detalles.CuentaTransito

            'If Detalles.Tipo = "Productos" Then
            '    cbTipo.SelectedIndex = 0
            'Else
            '    cbTipo.SelectedIndex = 1
            'End If

            Me.cbFormaPago.SelectedValue = Detalles.Cod_Forma_Pago
            Me.cbZona.SelectedValue = Detalles.Cod_Zona
            Me.cbCatalogo.EditValue = Detalles.Cuenta
            Cod_Cuenta = Detalles.Cuenta
            Me.cbTipoProveedor.SelectedIndex = Detalles.TipoProveedor - 1
            Me.chkRetenedor.Checked = Detalles.Retenedor
            Me.chkVarios.Checked = Detalles.Varios
            Me.chkExento.Checked = Detalles.Exento

            'Me.rbExtranjero.Checked = IIf(Detalles.Origen = 0, False, True)
            'Me.rbNacional.Checked = IIf(Detalles.Origen = 1, False, True)

            txtPrefijo.Text = Detalles.Prefijo
        Else
            Me.Text = "Agregar Proveedor"
            'Me.etDescripcion.Text = "Agregar Proveedor".ToUpper

            If Proveedores.GenerarCodigo().Tables("Proveedores").Rows.Count <> 0 Then
                Me.txtCodigo.Text = Proveedores.GenerarCodigo().Tables("Proveedores").Rows(0).Item("Codigo") + 1
            Else
                Me.txtCodigo.Text = "1"
            End If
        End If

        'r.ComboAutoComplete(Me.cbCatalogo)
        'r.ComboAutoComplete(Me.cbZona)
        Me.Refresh()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        'Dim proveedor As New VB.SysContab.ProveedoresDB()
        Dim r As New VB.SysContab.Rutinas

        If Me.txtCodigo.Text.Trim.Length = 0 Then
            MsgBox("Introduzca el Código del Proveedor", MsgBoxStyle.Information)
            Me.txtCodigo.Focus()
            Exit Sub
        End If

        If Trim(txtNombre.Text) = "" Then
            MsgBox("Introduzca el Nombre del Proveedor", MsgBoxStyle.Information)
            txtNombre.Focus()
            txtNombre.SelectAll()
            Exit Sub

        End If

        'If Trim(txtEncargado.Text) = "" Then
        '    MsgBox("Introduzca el Encargado del Proveedor", MsgBoxStyle.Information)
        '    txtEncargado.Focus()
        '    txtEncargado.SelectAll()
        '    Exit Sub

        'End If

        'If Trim(txtDireccion.Text) = "" Then
        '    MsgBox("Introduzca la Dirección del Proveedor", MsgBoxStyle.Information)
        '    txtDireccion.Focus()
        '    txtDireccion.SelectAll()
        '    Exit Sub

        'End If

        'If Trim(txtCiudad.Text) = "" Then
        '    MsgBox("Introduzca la Ciudad del Proveedor", MsgBoxStyle.Information)
        '    txtCiudad.Focus()
        '    txtCiudad.SelectAll()
        '    Exit Sub

        'End If

        'If Trim(txtTelefono.Text) = "" Then
        '    MsgBox("Introduzca el Teléfono del Proveedorr", MsgBoxStyle.Information)
        '    txtTelefono.Focus()
        '    txtTelefono.SelectAll()
        '    Exit Sub

        'End If

        'If Trim(txtFax.Text) = "" Then
        '    MsgBox("Introduzca el FAX del Proveedor", MsgBoxStyle.Information)
        '    txtFax.Focus()
        '    txtFax.SelectAll()
        '    Exit Sub

        'End If

        'Buscar Codigo del Proveedor
        'If Nuevo = "SI" Then
        '    If ObtieneDatos("SELECT * FROM PROVEEDORES p WHERE p.CODIGO = '" & Me.txtCodigo.Text & "' AND p.EMPRESA = " & EmpresaActual).Rows.Count > 0 Then
        '        MsgBox("El Código del Proveedor ya Existe.", MsgBoxStyle.Exclamation)
        '        Me.txtCodigo.Focus()
        '        Exit Sub
        '    End If
        'End If

        If Me.cbTipoProveedor.SelectedIndex = 0 Then
            If Me.txtRuc.Text <> "" Then
                If VB.SysContab.ProveedoresDB.BuscarxRuc(Me.txtRuc.Text) <> -1 Then  'Existe
                    If Nuevo = "NO" And (Me.txtRuc.Text <> Me.RUC_ANTERIOR) Then
                        MsgBox("El RUC registrado para ese proveedor ya existe, revise sus datos por favor", MsgBoxStyle.Critical, "STS-Contab")
                        txtRuc.Focus()
                        txtRuc.SelectAll()
                        Exit Sub
                    End If
                End If
            Else
                MsgBox("Digite el numero RUC del proveedor", MsgBoxStyle.Exclamation, "Sts.Contab")
                Exit Sub
            End If
        Else
            If Me.txtCedula.Text <> "" Then
                If VB.SysContab.ProveedoresDB.BuscarxCedula(Me.txtCedula.Text) <> -1 Then  'Existe
                    If Nuevo = "NO" And (Me.txtCedula.Text <> Me.Ced_ANTERIOR) Then
                        MsgBox("La Cedula para ese proveedor ya existe, revise sus datos por favor", MsgBoxStyle.Critical, "STS-Contab")
                        txtCedula.Focus()
                        txtCedula.SelectAll()
                        Exit Sub
                    End If
                End If
            Else
                MsgBox("Digite la cédula del proveedor", MsgBoxStyle.Exclamation, "Sts.Contab")
                Exit Sub
            End If

        End If



        'If Trim(cbZona.Text) = "" Then
        '    MsgBox("Introduzca la Zona del Proveedor", MsgBoxStyle.Information)
        '    cbZona.Focus()
        '    cbZona.SelectAll()
        '    Exit Sub

        'End If

        Try
            Dim Retenedor As Integer
            If chkRetenedor.Checked = True Then : Retenedor = 1 : Else : Retenedor = 0 : End If

            Dim exento As Integer
            If chkExento.Checked = True Then : exento = 1 : Else : exento = 0 : End If

            Dim Varios As Integer
            If chkVarios.Checked = True Then : Varios = 1 : Else : Varios = 0 : End If

            Dim Origen As Integer
            If rbNacional.Checked Then : Origen = 0 : Else : Origen = 1 : End If

            If Nuevo = "SI" Then
                If txtCodigo2.Text.Trim.Length > 0 Then
                    If ObtieneDatos("JAR_BuscarCodigoLetra '" & txtCodigo2.Text & "',2," & EmpresaActual).Rows.Count > 0 Then
                        XtraMsg("El Código Ya Existe!", MessageBoxIcon.Error)
                        txtCodigo2.SelectAll()
                        txtCodigo2.Focus()
                        Exit Sub
                    End If
                End If

                If Proveedores.GenerarCodigo().Tables("Proveedores").Rows.Count <> 0 Then
                    Me.txtCodigo.Text = Proveedores.GenerarCodigo().Tables("Proveedores").Rows(0).Item("Codigo") + 1
                Else
                    Me.txtCodigo.Text = "1"
                End If

                Proveedores.AddItem(txtCodigo.Text, txtNombre.Text, txtEncargado.Text, txtCargoContacto.Text, _
                       txtTelefonoContacto.Text, txtEmailContacto.Text, txtGerente.Text, txtTelefonoGerente.Text, _
                       txtCelularGerente.Text, txtEmailGerente.Text, txtContador.Text, txtTelefonoContador.Text, _
                       txtCelularContador.Text, txtEmailContador.Text, txtDireccion.Text, txtCiudad.Text, _
                       txtTelefono.Text, txtFax.Text, txtCorreo.Text, txtRuc.Text, cbTipo.SelectedIndex + 1, _
                       cbFormaPago.SelectedValue, cbZona.SelectedValue, cbCatalogo.EditValue, _
                       cbTipoProveedor.SelectedIndex + 1, Retenedor, cbDepartamentos.EditValue, _
                       IIf(cbMunicipios.EditValue Is Nothing, 0, cbMunicipios.EditValue), Varios, exento, txtCedula.Text, txtnNombre.Text, _
                       txtpApellido.Text, txtsApellido.Text, Origen, _
                        IIf(Me.txtCodigo2.Text.Trim.Length = 0, "", Me.txtCodigo2.Text.Trim), cbCuentaTransito.EditValue, txtPrefijo.Text)

                'MsgBox("El registro se ha grabado correctamente", MsgBoxStyle.Information)

                r.LimpiarControles(GroupBox1)
                r.LimpiarControles(GroupBox4)
                r.LimpiarControles(GroupBox5)
                r.LimpiarControles(GroupBox6)

                If Proveedores.GenerarCodigo().Tables("Proveedores").Rows.Count <> 0 Then
                    Me.txtCodigo.Text = Proveedores.GenerarCodigo().Tables("Proveedores").Rows(0).Item("Codigo") + 1
                Else
                    Me.txtCodigo.Text = "1"
                End If

                txtNombre.Focus()
                Me.chkVarios.Checked = False
                'txtCodigo.Text = proveedor.GetListNuevo().Tables("Proveedores").Rows(0).Item("Cod_Proveedor") + 1
            Else
                Proveedores.Update(txtCodigo.Text, txtNombre.Text, txtEncargado.Text, txtCargoContacto.Text, _
                                       txtTelefonoContacto.Text, txtEmailContacto.Text, txtGerente.Text, txtTelefonoGerente.Text, _
                                       txtCelularGerente.Text, txtEmailGerente.Text, txtContador.Text, txtTelefonoContador.Text, _
                                       txtCelularContador.Text, txtEmailContador.Text, txtDireccion.Text, txtCiudad.Text, txtTelefono.Text, _
                                       txtFax.Text, txtCorreo.Text, txtRuc.Text, cbTipo.SelectedIndex + 1, cbFormaPago.SelectedValue, _
                                       cbZona.SelectedValue, Me.cbCatalogo.EditValue, Me.cbTipoProveedor.SelectedIndex + 1, Retenedor, _
                                       cbDepartamentos.EditValue, IIf(cbMunicipios.EditValue Is Nothing, 0, cbMunicipios.EditValue), Varios, exento, Me.txtCedula.Text, _
                                       Me.txtnNombre.Text, Me.txtpApellido.Text, Me.txtsApellido.Text, Origen, _
                                       IIf(Me.txtCodigo2.Text.Trim.Length = 0, "", Me.txtCodigo2.Text.Trim), cbCuentaTransito.EditValue, txtPrefijo.Text)

                'MsgBox("El registro se ha actualizado correctamente", MsgBoxStyle.Information)
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    'Private Sub cbCatalogo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbCatalogo.KeyPress
    '    Dim C As New VB.SysContab.CatalogoDB()
    '    If e.KeyChar = "'" Then
    '        e.Handled = True
    '        Exit Sub

    '    End If

    '    If Microsoft.VisualBasic.Asc(e.KeyChar) < 32 Then
    '        If Microsoft.VisualBasic.Asc(e.KeyChar) = 27 Then
    '            cuenta = ""
    '            cbCatalogo.SelectAll()
    '            Exit Sub

    '        End If

    '        If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
    '            Exit Sub

    '        End If
    '    End If

    '    If cbCatalogo.Text = "" Then
    '        cuenta = ""
    '        Exit Sub

    '    End If

    '    If Microsoft.VisualBasic.Asc(e.KeyChar) = 8 Then
    '        If cuenta.Length = 1 Then
    '            cuenta = ""
    '        End If

    '        If cuenta.Length > 1 Then
    '            cuenta = Mid(cuenta, 1, cuenta.Length - 1)

    '        End If

    '        If cbCatalogo.Text = "" Then
    '            cuenta = ""
    '            Exit Sub

    '        End If

    '    Else
    '        cuenta = cuenta & e.KeyChar

    '    End If

    '    If C.GetListBuscarCombo(cuenta, EmpresaActual).Tables("CATALOGO").Rows.Count = 0 Then
    '        '
    '    Else
    '        cbCatalogo.SelectedValue = C.GetListBuscarCombo(cuenta, EmpresaActual).Tables("CATALOGO").Rows(0).Item("CUENTA")
    '        e.Handled = True
    '        cbCatalogo.SelectionStart = cuenta.Length
    '        cbCatalogo.Select(cuenta.Length, cbCatalogo.Text.Length)

    '    End If

    'End Sub

    'Private Sub cbCatalogo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    If Me.cbCatalogo.SelectedValue = Nothing Then
    '        MsgBox("Seleccione una cuenta", MsgBoxStyle.Information)
    '        Me.cbCatalogo.Focus()
    '        Exit Sub
    '    End If

    'End Sub

    'Private Sub cbCatalogo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'cuenta = ""
    'End Sub

    Private Sub cmdAcumulado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcumulado.Click
        'Dim f As frmAcumulados = f.Instance

        'TipoAcumulado = "P"

        'f.MdiParent = Me.MdiParent
        'f.Show()

        Dim f As frmAcumuladosProveedor = f.Instance
        Me.etInicio.Text = "1"
        f.Proveedor = Me.txtCodigo.Text

        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub

    Private Sub frmAgregarProveedor_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim P As frmProveedores = frmProveedores.Instance
        P.cargar()

    End Sub

    Private Sub cmdEstadoCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEstadoCuenta.Click
        Dim f As frmEstadoCuentaProveedor = frmEstadoCuentaProveedor.Instance
        Me.etInicio.Text = "1"
        f.etProveedor.Text = Me.txtCodigo.Text
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cmdDevoluciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDevoluciones.Click
        Dim f As frmDevolucionesProveedorList = frmDevolucionesProveedorList.Instance
        Me.etInicio.Text = "1"
        f.etInicio.Text = "1"
        f.Proveedor = Me.txtCodigo.Text
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
        f.cbProveedores.SelectedValue = Me.txtCodigo.Text
        f.cbProveedores.Focus()
        f.etInicio.Text = "0"
    End Sub

    Private Sub cmdNotasCreditos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNotasCreditos.Click
        Dim f As frmNotasCreditoProveedor = frmNotasCreditoProveedor.Instance
        Me.etInicio.Text = "1"
        f.etInicio.Text = "1"
        f.etProveedorCodigo.Text = txtCodigo.Text

        f.MdiParent = Me.MdiParent
        f.Show()
        f.etInicio.Text = "0"
    End Sub

    Private Sub txtRuc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRuc.TextChanged
        If Me.txtRuc.Text <> "" Then
            'Validar si ya existe el numero RUC del proveedor.
            If VB.SysContab.ProveedoresDB.BuscarxRuc(Me.txtRuc.Text) <> -1 Then  'Existe
                If Nuevo = "NO" And (Me.RUC_ANTERIOR <> Me.txtRuc.Text) Then
                    MsgBox("El RUC registrado para ese proveedor ya existe, revise sus datos por favor", MsgBoxStyle.Critical, "STS-Contab")
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
        If Me.txtNombre.Text <> "" Then
            NombresParecidos = New DataSet
            NombresParecidos = VB.SysContab.ProveedoresDB.BuscarxNombre(Me.txtNombre.Text)
        End If
    End Sub

    Private Sub txtNombre_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.Leave
        If NombresParecidos Is Nothing Then Exit Sub
        If NombresParecidos.Tables(0).Rows.Count > 1 Then
            MsgBox("Existen proveedores con nombres similares al nombre actual, vea el detalle por favor", MsgBoxStyle.Critical, "STS-Contab")
            Me.verOtrosProveedores.Enabled = True
        Else
            Me.verOtrosProveedores.Enabled = False
        End If
    End Sub

    Private Sub verOtrosProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verOtrosProveedores.Click
        If NombresParecidos.Tables.Count = 1 Then
            If NombresParecidos.Tables(0).Rows.Count > 1 Then
                Dim f As New frmVerNombresProveedores
                f.Datos = NombresParecidos
                f.ShowDialog()
            End If
        End If
    End Sub

    Private Sub cbTipoProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoProveedor.SelectedIndexChanged
        If Me.cbTipoProveedor.SelectedIndex = 0 Then
            Me.txtCedula.Text = ""
            Me.txtCedula.Enabled = False
        Else
            Me.txtCedula.Enabled = True
        End If

    End Sub

    Private Sub txtCedula_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCedula.TextChanged
        If Me.txtCedula.Text <> "" Then
            'Validar si ya existe la Cedula del proveedor.
            If VB.SysContab.ProveedoresDB.BuscarxCedula(Me.txtCedula.Text) <> -1 Then  'Existe
                If Nuevo = "NO" And (Me.Ced_ANTERIOR <> Me.txtCedula.Text) Then
                    MsgBox("La Cédula egistrada para ese proveedor ya existe, revise sus datos por favor", MsgBoxStyle.Critical, "STS-Contab")
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub LookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles cbDepartamentos.EditValueChanged
        If Me.etInicio.Text = "1" Then
            Exit Sub
        End If

        Dim Muni As New VB.SysContab.MunicipiosDB

        Combo(cbMunicipios, Muni.List(cbDepartamentos.EditValue))

        'If IsNumeric(cbDepartamentos.SelectedValue) Then
        '    cbMunicipios.DataSource = Muni.List(cbDepartamentos.SelectedValue.ToString).Tables("Municipios")
        '    cbMunicipios.ValueMember = "Codigo"
        '    cbMunicipios.DisplayMember = "Nombre"
        'End If
    End Sub

    Private Sub cbMunicipios_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class
