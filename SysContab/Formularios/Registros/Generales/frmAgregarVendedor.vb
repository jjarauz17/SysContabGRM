Public Class frmAgregarVendedor
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAgregarVendedor = Nothing

    Public Shared Function Instance() As frmAgregarVendedor
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarVendedor()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance

    End Function

    Dim Comision As String
    Dim Comision_Servicio As String
    Dim linea As String
    Dim xx As Integer
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents chkActivo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents cbCentro As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem

    'Dim zona As String
    'Dim Cod_Zona As String

    Dim Salir As Boolean

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
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtCiudad As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents checkFijaServ As System.Windows.Forms.CheckBox
    Friend WithEvents checkVariableServ As System.Windows.Forms.CheckBox
    Friend WithEvents txtFijaServ As System.Windows.Forms.TextBox
    Friend WithEvents checkFija As System.Windows.Forms.CheckBox
    Friend WithEvents CheckVariable As System.Windows.Forms.CheckBox
    Friend WithEvents txtFija As System.Windows.Forms.TextBox
    Friend WithEvents cbLinea As System.Windows.Forms.ComboBox
    Friend WithEvents cmdVarProd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbZona As System.Windows.Forms.ComboBox
    Friend WithEvents cmdVarServicio As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumeroClientes As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents cmdLineas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdVentas As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarVendedor))
        Me.chkActivo = New DevExpress.XtraEditors.CheckEdit()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.cmdLineas = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNumeroClientes = New System.Windows.Forms.TextBox()
        Me.cbZona = New System.Windows.Forms.ComboBox()
        Me.cbLinea = New System.Windows.Forms.ComboBox()
        Me.cmdVarServicio = New DevExpress.XtraEditors.SimpleButton()
        Me.checkFijaServ = New System.Windows.Forms.CheckBox()
        Me.checkVariableServ = New System.Windows.Forms.CheckBox()
        Me.txtFijaServ = New System.Windows.Forms.TextBox()
        Me.checkFija = New System.Windows.Forms.CheckBox()
        Me.CheckVariable = New System.Windows.Forms.CheckBox()
        Me.txtFija = New System.Windows.Forms.TextBox()
        Me.cmdVarProd = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cmdVentas = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.cbCentro = New DevExpress.XtraEditors.LookUpEdit()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.chkActivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCentro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkActivo
        '
        Me.chkActivo.Location = New System.Drawing.Point(696, 231)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.chkActivo.Properties.Appearance.Options.UseFont = True
        Me.chkActivo.Properties.Appearance.Options.UseForeColor = True
        Me.chkActivo.Properties.Caption = "Activo"
        Me.chkActivo.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkActivo.Size = New System.Drawing.Size(132, 22)
        Me.chkActivo.StyleController = Me.LayoutControl1
        Me.chkActivo.TabIndex = 122
        '
        'RadioGroup1
        '
        Me.RadioGroup1.EditValue = 0
        Me.RadioGroup1.Location = New System.Drawing.Point(379, 43)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioGroup1.Properties.Appearance.Options.UseFont = True
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "VENDEDOR"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "TECNICO")})
        Me.RadioGroup1.Size = New System.Drawing.Size(449, 25)
        Me.RadioGroup1.StyleController = Me.LayoutControl1
        Me.RadioGroup1.TabIndex = 121
        '
        'cmdLineas
        '
        Me.cmdLineas.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLineas.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdLineas.Appearance.Options.UseFont = True
        Me.cmdLineas.Appearance.Options.UseForeColor = True
        Me.cmdLineas.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdLineas.Location = New System.Drawing.Point(120, 231)
        Me.cmdLineas.Name = "cmdLineas"
        Me.cmdLineas.Size = New System.Drawing.Size(129, 22)
        Me.cmdLineas.StyleController = Me.LayoutControl1
        Me.cmdLineas.TabIndex = 8
        Me.cmdLineas.Text = "Agregar Lineas"
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(120, 43)
        Me.txtCodigo.MaxLength = 50
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(159, 25)
        Me.txtCodigo.TabIndex = 0
        '
        'txtNumeroClientes
        '
        Me.txtNumeroClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroClientes.Location = New System.Drawing.Point(561, 182)
        Me.txtNumeroClientes.MaxLength = 5
        Me.txtNumeroClientes.Name = "txtNumeroClientes"
        Me.txtNumeroClientes.ReadOnly = True
        Me.txtNumeroClientes.Size = New System.Drawing.Size(267, 20)
        Me.txtNumeroClientes.TabIndex = 117
        '
        'cbZona
        '
        Me.cbZona.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbZona.ItemHeight = 13
        Me.cbZona.Location = New System.Drawing.Point(120, 182)
        Me.cbZona.Name = "cbZona"
        Me.cbZona.Size = New System.Drawing.Size(341, 21)
        Me.cbZona.TabIndex = 7
        '
        'cbLinea
        '
        Me.cbLinea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLinea.Location = New System.Drawing.Point(316, 215)
        Me.cbLinea.Name = "cbLinea"
        Me.cbLinea.Size = New System.Drawing.Size(249, 23)
        Me.cbLinea.TabIndex = 115
        Me.cbLinea.Visible = False
        '
        'cmdVarServicio
        '
        Me.cmdVarServicio.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVarServicio.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdVarServicio.Appearance.Options.UseFont = True
        Me.cmdVarServicio.Appearance.Options.UseForeColor = True
        Me.cmdVarServicio.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdVarServicio.Image = CType(resources.GetObject("cmdVarServicio.Image"), System.Drawing.Image)
        Me.cmdVarServicio.Location = New System.Drawing.Point(436, 414)
        Me.cmdVarServicio.Name = "cmdVarServicio"
        Me.cmdVarServicio.Size = New System.Drawing.Size(199, 38)
        Me.cmdVarServicio.StyleController = Me.LayoutControl1
        Me.cmdVarServicio.TabIndex = 14
        Me.cmdVarServicio.Text = "Variable por Servicios"
        Me.cmdVarServicio.Visible = False
        '
        'checkFijaServ
        '
        Me.checkFijaServ.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.checkFijaServ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkFijaServ.ForeColor = System.Drawing.Color.Blue
        Me.checkFijaServ.Location = New System.Drawing.Point(436, 390)
        Me.checkFijaServ.Name = "checkFijaServ"
        Me.checkFijaServ.Size = New System.Drawing.Size(244, 20)
        Me.checkFijaServ.TabIndex = 12
        Me.checkFijaServ.Text = "Comisión Fija:"
        Me.checkFijaServ.UseVisualStyleBackColor = False
        '
        'checkVariableServ
        '
        Me.checkVariableServ.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.checkVariableServ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkVariableServ.ForeColor = System.Drawing.Color.Blue
        Me.checkVariableServ.Location = New System.Drawing.Point(639, 414)
        Me.checkVariableServ.Name = "checkVariableServ"
        Me.checkVariableServ.Size = New System.Drawing.Size(177, 20)
        Me.checkVariableServ.TabIndex = 101
        Me.checkVariableServ.Text = "Variable por Linea"
        Me.checkVariableServ.UseVisualStyleBackColor = False
        Me.checkVariableServ.Visible = False
        '
        'txtFijaServ
        '
        Me.txtFijaServ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFijaServ.Location = New System.Drawing.Point(684, 390)
        Me.txtFijaServ.MaxLength = 5
        Me.txtFijaServ.Name = "txtFijaServ"
        Me.txtFijaServ.Size = New System.Drawing.Size(132, 20)
        Me.txtFijaServ.TabIndex = 13
        Me.txtFijaServ.Visible = False
        '
        'checkFija
        '
        Me.checkFija.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.checkFija.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkFija.ForeColor = System.Drawing.Color.Blue
        Me.checkFija.Location = New System.Drawing.Point(36, 390)
        Me.checkFija.Name = "checkFija"
        Me.checkFija.Size = New System.Drawing.Size(200, 20)
        Me.checkFija.TabIndex = 9
        Me.checkFija.Text = "Comisión Fija:"
        Me.checkFija.UseVisualStyleBackColor = False
        '
        'CheckVariable
        '
        Me.CheckVariable.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.CheckVariable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckVariable.ForeColor = System.Drawing.Color.Blue
        Me.CheckVariable.Location = New System.Drawing.Point(240, 414)
        Me.CheckVariable.Name = "CheckVariable"
        Me.CheckVariable.Size = New System.Drawing.Size(168, 20)
        Me.CheckVariable.TabIndex = 101
        Me.CheckVariable.Text = "Variable por Linea"
        Me.CheckVariable.UseVisualStyleBackColor = False
        Me.CheckVariable.Visible = False
        '
        'txtFija
        '
        Me.txtFija.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFija.Location = New System.Drawing.Point(240, 390)
        Me.txtFija.MaxLength = 5
        Me.txtFija.Name = "txtFija"
        Me.txtFija.Size = New System.Drawing.Size(168, 20)
        Me.txtFija.TabIndex = 10
        Me.txtFija.Visible = False
        '
        'cmdVarProd
        '
        Me.cmdVarProd.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVarProd.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdVarProd.Appearance.Options.UseFont = True
        Me.cmdVarProd.Appearance.Options.UseForeColor = True
        Me.cmdVarProd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdVarProd.Image = CType(resources.GetObject("cmdVarProd.Image"), System.Drawing.Image)
        Me.cmdVarProd.Location = New System.Drawing.Point(36, 414)
        Me.cmdVarProd.Name = "cmdVarProd"
        Me.cmdVarProd.Size = New System.Drawing.Size(200, 38)
        Me.cmdVarProd.StyleController = Me.LayoutControl1
        Me.cmdVarProd.TabIndex = 11
        Me.cmdVarProd.Text = "Variable por Productos"
        Me.cmdVarProd.Visible = False
        '
        'txtCorreo
        '
        Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(561, 158)
        Me.txtCorreo.MaxLength = 256
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(267, 20)
        Me.txtCorreo.TabIndex = 6
        '
        'txtCelular
        '
        Me.txtCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelular.Location = New System.Drawing.Point(120, 158)
        Me.txtCelular.MaxLength = 50
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(341, 20)
        Me.txtCelular.TabIndex = 5
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(561, 134)
        Me.txtTelefono.MaxLength = 50
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(267, 20)
        Me.txtTelefono.TabIndex = 4
        '
        'txtCiudad
        '
        Me.txtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiudad.Location = New System.Drawing.Point(120, 134)
        Me.txtCiudad.MaxLength = 50
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(341, 20)
        Me.txtCiudad.TabIndex = 3
        '
        'txtDireccion
        '
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(120, 96)
        Me.txtDireccion.MaxLength = 150
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDireccion.Size = New System.Drawing.Size(708, 34)
        Me.txtDireccion.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(120, 72)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(708, 20)
        Me.txtNombre.TabIndex = 1
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(12, 96)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(108, 38)
        Me.cmdCancelar.StyleController = Me.LayoutControl2
        Me.cmdCancelar.TabIndex = 8
        Me.cmdCancelar.Text = "&Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.Location = New System.Drawing.Point(12, 12)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(108, 38)
        Me.cmdAceptar.StyleController = Me.LayoutControl2
        Me.cmdAceptar.TabIndex = 7
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox5.Location = New System.Drawing.Point(12, 253)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(104, 448)
        Me.GroupBox5.TabIndex = 116
        Me.GroupBox5.TabStop = False
        '
        'cmdVentas
        '
        Me.cmdVentas.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVentas.Appearance.Options.UseFont = True
        Me.cmdVentas.Image = CType(resources.GetObject("cmdVentas.Image"), System.Drawing.Image)
        Me.cmdVentas.Location = New System.Drawing.Point(12, 54)
        Me.cmdVentas.Name = "cmdVentas"
        Me.cmdVentas.Size = New System.Drawing.Size(108, 38)
        Me.cmdVentas.StyleController = Me.LayoutControl2
        Me.cmdVentas.TabIndex = 22
        Me.cmdVentas.Text = "&Ventas"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cbCentro)
        Me.LayoutControl1.Controls.Add(Me.checkVariableServ)
        Me.LayoutControl1.Controls.Add(Me.cmdVarServicio)
        Me.LayoutControl1.Controls.Add(Me.CheckVariable)
        Me.LayoutControl1.Controls.Add(Me.checkFijaServ)
        Me.LayoutControl1.Controls.Add(Me.txtFijaServ)
        Me.LayoutControl1.Controls.Add(Me.cmdVarProd)
        Me.LayoutControl1.Controls.Add(Me.txtFija)
        Me.LayoutControl1.Controls.Add(Me.checkFija)
        Me.LayoutControl1.Controls.Add(Me.chkActivo)
        Me.LayoutControl1.Controls.Add(Me.cmdLineas)
        Me.LayoutControl1.Controls.Add(Me.RadioGroup1)
        Me.LayoutControl1.Controls.Add(Me.cbLinea)
        Me.LayoutControl1.Controls.Add(Me.txtCodigo)
        Me.LayoutControl1.Controls.Add(Me.txtNumeroClientes)
        Me.LayoutControl1.Controls.Add(Me.cbZona)
        Me.LayoutControl1.Controls.Add(Me.txtNombre)
        Me.LayoutControl1.Controls.Add(Me.txtDireccion)
        Me.LayoutControl1.Controls.Add(Me.txtCiudad)
        Me.LayoutControl1.Controls.Add(Me.txtTelefono)
        Me.LayoutControl1.Controls.Add(Me.txtCorreo)
        Me.LayoutControl1.Controls.Add(Me.txtCelular)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem13})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1223, 222, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(852, 488)
        Me.LayoutControl1.TabIndex = 117
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlGroup3, Me.EmptySpaceItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(852, 488)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtCodigo
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(259, 29)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(259, 29)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(259, 29)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Código:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.RadioGroup1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(259, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(549, 29)
        Me.LayoutControlItem3.Text = "Tipo:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtNombre
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 29)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(808, 24)
        Me.LayoutControlItem4.Text = "Nombre:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtDireccion
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 53)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(808, 38)
        Me.LayoutControlItem5.Text = "Dirección:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtCiudad
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 91)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(441, 24)
        Me.LayoutControlItem6.Text = "Cargo:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtTelefono
        Me.LayoutControlItem7.Location = New System.Drawing.Point(441, 91)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(367, 24)
        Me.LayoutControlItem7.Text = "Teléfono:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtCelular
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 115)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(441, 24)
        Me.LayoutControlItem8.Text = "Celular:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtCorreo
        Me.LayoutControlItem9.Location = New System.Drawing.Point(441, 115)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(367, 24)
        Me.LayoutControlItem9.Text = "Correo Electrónico:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cbZona
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 139)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(441, 25)
        Me.LayoutControlItem10.Text = "Zona:"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txtNumeroClientes
        Me.LayoutControlItem11.Location = New System.Drawing.Point(441, 139)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(367, 25)
        Me.LayoutControlItem11.Text = "No. de Clientes:"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cmdLineas
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 188)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(229, 26)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(229, 26)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(229, 26)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.Text = "Linea:"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.cbLinea
        Me.LayoutControlItem13.Location = New System.Drawing.Point(304, 203)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(253, 26)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(229, 188)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(443, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.chkActivo
        Me.LayoutControlItem14.Location = New System.Drawing.Point(672, 188)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(136, 26)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(136, 26)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(136, 26)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup2.AppearanceGroup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.LayoutControlItem10, Me.LayoutControlItem12, Me.EmptySpaceItem1, Me.LayoutControlItem14, Me.LayoutControlItem11, Me.LayoutControlItem9, Me.LayoutControlItem7, Me.LayoutControlItem25})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(832, 257)
        Me.LayoutControlGroup2.Text = "DATOS DEL VENDEDOR"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.checkFija
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(204, 24)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.txtFija
        Me.LayoutControlItem15.Location = New System.Drawing.Point(204, 0)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(172, 24)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.cmdVarProd
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(204, 42)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.CheckVariable
        Me.LayoutControlItem17.Location = New System.Drawing.Point(204, 24)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(172, 42)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup4, Me.LayoutControlGroup5})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 317)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(832, 151)
        Me.LayoutControlGroup3.Text = "COMISIONES"
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup4.AppearanceGroup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LayoutControlGroup4.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup4.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem17, Me.LayoutControlItem15, Me.LayoutControlItem1, Me.LayoutControlItem16})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(400, 109)
        Me.LayoutControlGroup4.Text = "PRODUCTOS"
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.checkFijaServ
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(248, 24)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.txtFijaServ
        Me.LayoutControlItem19.Location = New System.Drawing.Point(248, 0)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(136, 24)
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.cmdVarServicio
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(203, 42)
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextVisible = False
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.checkVariableServ
        Me.LayoutControlItem21.Location = New System.Drawing.Point(203, 24)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(181, 42)
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem21.TextVisible = False
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup5.AppearanceGroup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LayoutControlGroup5.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup5.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem20, Me.LayoutControlItem18, Me.LayoutControlItem19, Me.LayoutControlItem21})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(400, 0)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(408, 109)
        Me.LayoutControlGroup5.Text = "SERVICIOS"
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.ID = New System.Guid("90cfe01c-d09b-48e4-8224-121ff64fc0b1")
        Me.DockPanel1.Location = New System.Drawing.Point(852, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(140, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(140, 488)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(132, 461)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.cmdCancelar)
        Me.LayoutControl2.Controls.Add(Me.cmdVentas)
        Me.LayoutControl2.Controls.Add(Me.cmdAceptar)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup6
        Me.LayoutControl2.Size = New System.Drawing.Size(132, 461)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'LayoutControlGroup6
        '
        Me.LayoutControlGroup6.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup6.GroupBordersVisible = False
        Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem22, Me.LayoutControlItem23, Me.LayoutControlItem24})
        Me.LayoutControlGroup6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
        Me.LayoutControlGroup6.Size = New System.Drawing.Size(132, 461)
        Me.LayoutControlGroup6.TextVisible = False
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.cmdAceptar
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem22.TextVisible = False
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.cmdVentas
        Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem23.TextVisible = False
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.cmdCancelar
        Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(112, 357)
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem24.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 257)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(832, 60)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'cbCentro
        '
        Me.cbCentro.Location = New System.Drawing.Point(120, 207)
        Me.cbCentro.Name = "cbCentro"
        Me.cbCentro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCentro.Size = New System.Drawing.Size(708, 20)
        Me.cbCentro.StyleController = Me.LayoutControl1
        Me.cbCentro.TabIndex = 123
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.cbCentro
        Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 164)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(808, 24)
        Me.LayoutControlItem25.Text = "Centro de Costo:"
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(92, 13)
        '
        'frmAgregarVendedor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(992, 488)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "frmAgregarVendedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.chkActivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCentro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()

    End Sub

    Private Sub frmAgregarVendedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim z As New VB.SysContab.ZonasDB()
        Dim vendedor As New VB.SysContab.VendedoresDB()
        Dim g As New VB.SysContab.Grupos_InventarioDB()
        Dim r As New VB.SysContab.Rutinas()

        linea = ""

        Salir = True

        cbZona.DataSource = z.GetListBuscarCombo()
        cbZona.ValueMember = "Codigo"
        cbZona.DisplayMember = "Nombre"

        cbLinea.DataSource = g.GetListBuscarCombo("%", "P").Tables("GRUPOS_INVENTARIO")
        cbLinea.ValueMember = "CODIGO_GRUPO"
        cbLinea.DisplayMember = "NOMBRE"

        '  '''r.CambiarEstilo(Me)
        r.ComboAutoComplete(Me.cbZona)
        r.ComboAutoComplete(Me.cbLinea)

        Me.txtCodigo.ReadOnly = True
        r.FormularioColor(Me)

        GetCentrosCostosList(cbCentro, 1)

        'Me.etDescripcion.BackColor = Color.FromArgb(102, 153, 153)
        'Me.Label3.BackColor = Color.FromArgb(102, 153, 153)

        If Nuevo = "NO" Then

            Me.Text = "Editar Vendedor"
            'Me.etDescripcion.Text = "Editar Vendedor".ToUpper
            'txtCodigo.Enabled = False

            Dim Detalles As VB.SysContab.VendedoresDetails = vendedor.GetDetails(Registro)
            Me.txtNumeroClientes.Text = vendedor.GetClientesxVendedor(Registro)
            'Me.txtCodigo.Text = "V-" & Format(CInt(Detalles.Codigo), "0000")
            Me.txtCodigo.Text = Detalles.Codigo
            Me.txtNombre.Text = Detalles.Nombre
            Me.txtDireccion.Text = Detalles.Direccion
            Me.txtCiudad.Text = Detalles.Ciudad
            Me.txtTelefono.Text = Detalles.Telefono
            Me.txtCelular.Text = Detalles.Celular
            Me.txtCorreo.Text = Detalles.Correo
            RadioGroup1.EditValue = Detalles.Tipo
            chkActivo.Checked = Detalles.Activo
            cbCentro.EditValue = Detalles.IdCentro
            'Me.cbZona.Text = Detalles.Nombre_Zona
            'Cod_Zona = Detalles.Cod_Zona
            Me.cbZona.SelectedValue = Detalles.Cod_Zona
            Me.txtFija.Text = Detalles.Comision
            Me.txtFijaServ.Text = Detalles.Comision_Servicio

            Me.cbLinea.SelectedValue = Detalles.Linea

            If Detalles.Comision <> 0 Then
                Comision = Detalles.Comision
                checkFija.Checked = True
            Else
                Comision = "0.00"
                Me.txtFija.Text = "0.00"
            End If

            If Detalles.Comision_Servicio <> 0 Then
                Comision_Servicio = Detalles.Comision_Servicio
                checkFijaServ.Checked = True
            Else
                Comision_Servicio = "0.00"
                Me.txtFijaServ.Text = "0.00"
            End If

            cmdVarProd.Visible = True
            cmdVarServicio.Visible = True
            'cmdLineas.Visible = True

            txtNombre.Focus()

        Else
            Me.Text = "Agregar Vendedor"
            'Me.etDescripcion.Text = "Agregar Vendedor".ToUpper
            Comision = "0.00"
            Comision_Servicio = "0.00"

            If vendedor.GenerarCodigo.Tables("Vendedores").Rows.Count <> 0 Then
                Me.txtCodigo.Text = vendedor.GenerarCodigo.Tables("Vendedores").Rows(0).Item("Codigo") + 1
            Else
                Me.txtCodigo.Text = 1
            End If

            cmdVarProd.Visible = False
            cmdVarServicio.Visible = False

        End If

        Me.Refresh()

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim vendedor As New VB.SysContab.VendedoresDB()
        Dim r As New VB.SysContab.Rutinas()

        Dim resp As DialogResult

        If Trim(txtNombre.Text) = "" Then
            XtraMsg("Introduzca el Nombre del Vendedor")
            txtNombre.Focus()
            txtNombre.SelectAll()
            Exit Sub

        End If

        'If Trim(txtDireccion.Text) = "" Then
        '    MsgBox("Introduzca la Dirección del Vendedor", MsgBoxStyle.Information)
        '    txtDireccion.Focus()
        '    txtDireccion.SelectAll()
        '    Exit Sub

        'End If

        'If Trim(txtCiudad.Text) = "" Then
        '    MsgBox("Introduzca la Ciudad del Vendedor", MsgBoxStyle.Information)
        '    txtCiudad.Focus()
        '    txtCiudad.SelectAll()
        '    Exit Sub

        'End If

        ''If Trim(txtTelefono.Text) = "" Then
        ''    MsgBox("Introduzca el Teléfono del Vendedor", MsgBoxStyle.Information)
        ''    txtTelefono.Focus()
        ''    txtTelefono.SelectAll()
        ''    Exit Sub

        ''End If

        ''If Trim(txtCelular.Text) = "" Then
        ''    MsgBox("Introduzca el Celular del Vendedor", MsgBoxStyle.Information)
        ''    txtCelular.Focus()
        ''    txtCelular.SelectAll()
        ''    Exit Sub

        ''End If

        ''If Trim(txtCorreo.Text) = "" Then
        ''    MsgBox("Introduzca el Correo del Vendedor", MsgBoxStyle.Information)
        ''    txtCorreo.Focus()
        ''    txtCorreo.SelectAll()
        ''    Exit Sub

        ''End If

        'If Trim(cbZona.Text) = "" Then
        '    MsgBox("Introduzca la Zona del Vendedor", MsgBoxStyle.Information)
        '    cbZona.Focus()
        '    cbZona.SelectAll()
        '    Exit Sub

        'End If

        If checkFija.Checked = False Then
            Me.txtFija.Text = 0
        End If

        If Me.checkFijaServ.Checked = False Then
            Me.txtFijaServ.Text = 0
        End If

        If Nuevo = "SI" Then
            If vendedor.GenerarCodigo.Tables("Vendedores").Rows.Count <> 0 Then
                Me.txtCodigo.Text = vendedor.GenerarCodigo.Tables("Vendedores").Rows(0).Item("Codigo") + 1
            Else
                Me.txtCodigo.Text = 1
            End If

            'vendedor.AddItem(txtCodigo.Text.Substring(2), txtNombre.Text, xx, txtDireccion.Text, txtCiudad.Text, txtTelefono.Text, txtCelular.Text, txtCorreo.Text, Me.cbZona.SelectedValue, txtFija.Text, txtFijaServ.Text)
            vendedor.AddItem(txtCodigo.Text, txtNombre.Text, xx, txtDireccion.Text, txtCiudad.Text, txtTelefono.Text, _
                             txtCelular.Text, txtCorreo.Text, Me.cbZona.SelectedValue, txtFija.Text, txtFijaServ.Text, _
                             RadioGroup1.EditValue, IIf(chkActivo.Checked, 1, 0), IIf(cbCentro.EditValue Is Nothing, 0, cbCentro.EditValue))
            'MsgBox("El registro se ha grabado correctamente", MsgBoxStyle.Information)
            '31/08/2005
            ''''resp = MsgBox("Desea agregar comisiones por Producto y Servicio para este vendedor?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)

            ''''If resp = DialogResult.Yes Then
            ''''    VendedorP = vendedor.GetListComision().Tables("VENDEDORES").Rows(0).Item("Codigo")

            ''''    Dim frmChildInstance As frmComision = frmChildInstance.Instance
            ''''    frmChildInstance.MdiParent = Me.MdiParent
            ''''    frmChildInstance.Show()
            ''''    frmChildInstance.Refresh()

            ''''    frmChildInstance.cbArticulos.SelectedValue = -1

            ''''End If

            ' r.LimpiarControles(GroupBox1)
            'Me.txtCodigo.Text = vendedor.GenerarCodigo.Tables("Vendedores").Rows(0).Item("Codigo") + 1

            cbLinea.SelectedValue = -1
            cbZona.SelectedValue = -1

            If vendedor.GenerarCodigo.Tables("Vendedores").Rows.Count <> 0 Then
                Me.txtCodigo.Text = vendedor.GenerarCodigo.Tables("Vendedores").Rows(0).Item("Codigo") + 1
            Else
                Me.txtCodigo.Text = 1
            End If

            Me.txtFija.Text = 0
            Me.txtFijaServ.Text = 0

            txtNombre.Focus()
            Close()

            Dim f As frmVendedores = frmVendedores.Instance
            f.Cargar()
        Else
            vendedor.Update(Registro, txtNombre.Text, xx, txtDireccion.Text, txtCiudad.Text, txtTelefono.Text, _
                            txtCelular.Text, txtCorreo.Text, Me.cbZona.SelectedValue, txtFija.Text, txtFijaServ.Text, _
                            RadioGroup1.EditValue, IIf(chkActivo.Checked, 1, 0), IIf(cbCentro.EditValue Is Nothing, 0, cbCentro.EditValue))
            'MsgBox("El registro se ha actualizado correctamente", MsgBoxStyle.Information)
            Me.Close()

            Dim f As frmVendedores = frmVendedores.Instance
            f.Cargar()
        End If
    End Sub

    Private Sub frmAgregarVendedor_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        'Dim r As New VB.SysContab.Rutinas()
        'Dim vendedores As New VB.SysContab.VendedoresDB()
        'Dim v As frmVendedores = v.Instance
        'Dim Tabla As New DataTable()
        'Dim ds As New DataSet()

        'ds = vendedores.GetList()
        'v.dgVendedores.DataSource = vendedores.GetList().Tables("Vendedores").DefaultView
        'Tabla = ds.Tables("Vendedores")

        'r.FormatGenerico(v.dgVendedores, Tabla)

        'If ds.Tables("Vendedores").Rows.Count <> 0 Then
        '    Registro = v.dgVendedores.Item(0, 0)
        'End If

        Dim f As frmVendedores = frmVendedores.Instance()
        f.Cargar()
    End Sub

    Private Sub checkFija_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkFija.CheckedChanged
        If checkFija.Checked = True Then
            txtFija.Visible = True
            txtFija.Focus()
        Else
            txtFija.Visible = False
            txtFija.Text = Comision

        End If
    End Sub


    Private Sub checkFijaServ_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkFijaServ.CheckedChanged
        If checkFijaServ.Checked = True Then
            txtFijaServ.Visible = True
            txtFijaServ.Focus()
        Else
            txtFijaServ.Visible = False
            txtFijaServ.Text = Comision_Servicio

        End If
    End Sub

    Private Sub txtFija_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFija.Leave
        If Trim(txtFija.Text) <> "" Then
            If IsNumeric(txtFija.Text) Then
                '
            Else
                MsgBox("Introduzca un valor numérico", MsgBoxStyle.Information)
                txtFija.Focus()
                txtFija.SelectAll()
                Exit Sub

            End If
        End If
    End Sub

    Private Sub txtFijaServ_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFijaServ.Leave
        If Trim(txtFijaServ.Text) <> "" Then
            If IsNumeric(txtFijaServ.Text) Then
                '
            Else
                MsgBox("Introduzca un valor numérico", MsgBoxStyle.Information)
                txtFijaServ.Focus()
                txtFijaServ.SelectAll()
                Exit Sub

            End If
        End If
    End Sub

    Private Sub cbLinea_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbLinea.KeyPress
        Dim g As New VB.SysContab.Grupos_InventarioDB()

        If Microsoft.VisualBasic.Asc(e.KeyChar) < 32 Then
            If Microsoft.VisualBasic.Asc(e.KeyChar) = 27 Then
                linea = ""
                cbLinea.SelectAll()
                Exit Sub

            End If

            If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
                Exit Sub

            End If
        End If

        If cbLinea.Text = "" Then
            linea = ""
            Exit Sub
        End If

        If Microsoft.VisualBasic.Asc(e.KeyChar) = 8 Then
            If linea.Length = 1 Then
                linea = ""
            End If

            If linea.Length > 1 Then
                linea = Mid(linea, 1, linea.Length - 1)
            End If

            If cbLinea.Text = "" Then
                linea = ""
                Exit Sub

            End If

        Else
            linea = linea & e.KeyChar

        End If

        If g.GetListBuscarCombo(linea, "P").Tables("GRUPOS_INVENTARIO").Rows.Count = 0 Then
            '

        Else
            cbLinea.SelectedValue = g.GetListBuscarCombo(linea, "P").Tables("GRUPOS_INVENTARIO").Rows(0).Item("CODIGO_GRUPO")
            cbLinea.SelectionStart = linea.Length
            cbLinea.Select(linea.Length, cbLinea.Text.Length)

        End If

    End Sub

    Private Sub cbLinea_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbLinea.Leave
        Dim g As New VB.SysContab.Grupos_InventarioDB()

        If g.GetListBuscarCombo(cbLinea.Text, "P").Tables("GRUPOS_INVENTARIO").Rows.Count = 0 Then
            MsgBox("Linea no Existe", MsgBoxStyle.Information)
            linea = ""
            cbLinea.Focus()
            Exit Sub

        End If

        xx = g.GetListBuscarCombo(cbLinea.Text, "P").Tables("GRUPOS_INVENTARIO").Rows(0).Item("CODIGO_GRUPO")
        'cbLinea.SelectedValue = g.GetListBuscarCombo(cbLinea.Text, "P").Tables("GRUPOS_INVENTARIO").Rows(0).Item("CODIGO_GRUPO")

        linea = ""

    End Sub

    Private Sub cbLinea_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbLinea.SelectedValueChanged
        linea = ""

    End Sub

    Private Sub cmdVarProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVarProd.Click
        Dim frmChildInstance As frmComision = frmChildInstance.Instance
        'Me.IsMdiContainer = True
        VendedorP = Registro
        frmChildInstance.MdiParent = Me.MdiParent
        frmChildInstance.Show()
        frmChildInstance.Refresh()

        frmChildInstance.cbArticulos.SelectedValue = -1

    End Sub

    Private Sub cbZona_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbZona.KeyPress
        'Dim z As New VB.SysContab.ZonasDB()

        'If Microsoft.VisualBasic.Asc(e.KeyChar) < 32 Then
        '    If Microsoft.VisualBasic.Asc(e.KeyChar) = 27 Then
        '        zona = ""
        '        cbZona.SelectAll()
        '        Exit Sub

        '    End If

        '    If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
        '        Exit Sub

        '    End If
        'End If

        'If cbZona.Text = "" Then
        '    zona = ""
        '    Exit Sub
        'End If

        'If Microsoft.VisualBasic.Asc(e.KeyChar) = 8 Then
        '    If zona.Length = 1 Then
        '        zona = ""
        '    End If

        '    If zona.Length > 1 Then
        '        zona = Mid(zona, 1, zona.Length - 1)
        '    End If

        '    If cbZona.Text = "" Then
        '        zona = ""
        '        Exit Sub

        '    End If

        'Else
        '    zona = zona & e.KeyChar

        'End If

        'If z.GetListBuscarCombo(zona).Tables("ZONAS").Rows.Count = 0 Then
        '    '

        'Else
        '    cbZona.SelectedValue = z.GetListBuscarCombo(zona).Tables("ZONAS").Rows(0).Item("CODIGO")
        '    cbZona.SelectionStart = zona.Length
        '    cbZona.Select(zona.Length, cbZona.Text.Length)

        'End If

    End Sub

    Private Sub cbZona_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbZona.Leave
        'Dim z As New VB.SysContab.ZonasDB()

        'If Trim(cbZona.Text) = "" Then
        '    zona = ""
        '    Exit Sub
        'End If

        'If z.GetListBuscarCombo(cbZona.Text).Tables("Zonas").Rows.Count = 0 Then
        '    MsgBox("Zona no Existe", MsgBoxStyle.Information)
        '    zona = ""
        '    cbZona.Focus()
        '    Exit Sub

        'End If

        ''cbZona.SelectedValue = z.GetListBuscarCombo(cbZona.Text).Tables("ZONAS").Rows(0).Item("CODIGO")
        'Cod_Zona = z.GetListBuscarCombo(cbZona.Text).Tables("Zonas").Rows(0).Item("CODIGO")

        'zona = ""

    End Sub

    Private Sub cbZona_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbZona.SelectedValueChanged
        'zona = ""

    End Sub

    Private Sub cmdVarServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVarServicio.Click
        Dim frmChildInstance As frmComisionesServicios = frmChildInstance.Instance
        'Me.IsMdiContainer = True
        VendedorP = Registro
        frmChildInstance.MdiParent = Me.MdiParent
        frmChildInstance.Show()
        frmChildInstance.Refresh()

        frmChildInstance.cbServicios.SelectedValue = -1

    End Sub

    Private Sub cmdLineas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLineas.Click

        If Nuevo = "SI" Then
            Registro = CInt(txtCodigo.Text.Substring(2))
            XtraMsg("Primero debe guardar los datos.")
            cmdAceptar.Focus()
            Exit Sub
        End If

        Dim f As frmVendedor_Linea = frmVendedor_Linea.Instance
        f.Text = "Lineas por Vendedor"
        VendedorP = txtCodigo.Text
        f.ShowDialog()
        f.Dispose()


        'Dim resp As DialogResult
        'If Nuevo = "SI" Then
        '    Registro = CInt(txtCodigo.Text.Substring(2))
        '    resp = MsgBox("Primero debe guardar los datos. Desea Continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)

        '    If resp = DialogResult.No Then
        '        Exit Sub
        '    Else
        '        cmdAceptar_Click(sender, e)
        '    End If
        'End If

        'Dim f As frmVendedor_Linea = frmVendedor_Linea.Instance
        ''Me.IsMdiContainer = True
        'VendedorP = Registro
        'f.MdiParent = Me.MdiParent
        'f.Show()
        'f.Refresh()

    End Sub

    Private Sub cmdVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVentas.Click
        Dim f As frmVentasVendedor = frmVentasVendedor.Instance
        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub

End Class
