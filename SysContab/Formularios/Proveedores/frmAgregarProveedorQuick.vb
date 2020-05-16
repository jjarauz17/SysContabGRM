Public Class frmAgregarProveedorQuick
    Inherits DevExpress.XtraEditors.XtraForm

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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAddAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRuc As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents etAceptar As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents vCat1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents chkExento As System.Windows.Forms.CheckBox
    Friend WithEvents chkRetenedor As System.Windows.Forms.CheckBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbCatalogo2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents vCat2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbMunicipios As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbDepartamentos As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbCatalogo As DevExpress.XtraEditors.GridLookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbCatalogo2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.vCat2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.chkExento = New System.Windows.Forms.CheckBox()
        Me.chkRetenedor = New System.Windows.Forms.CheckBox()
        Me.cbCatalogo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.vCat1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.etAceptar = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAddAll = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbMunicipios = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbDepartamentos = New DevExpress.XtraEditors.LookUpEdit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.cbCatalogo2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vCat2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vCat1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cbMunicipios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDepartamentos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.cbMunicipios)
        Me.GroupBox3.Controls.Add(Me.cbCatalogo2)
        Me.GroupBox3.Controls.Add(Me.cbDepartamentos)
        Me.GroupBox3.Controls.Add(Me.txtDireccion)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.RadioGroup1)
        Me.GroupBox3.Controls.Add(Me.chkExento)
        Me.GroupBox3.Controls.Add(Me.chkRetenedor)
        Me.GroupBox3.Controls.Add(Me.cbCatalogo)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.etAceptar)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtRuc)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.txtCodigo)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtNombre)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(4, -3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(606, 308)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'cbCatalogo2
        '
        Me.cbCatalogo2.Location = New System.Drawing.Point(128, 95)
        Me.cbCatalogo2.Name = "cbCatalogo2"
        Me.cbCatalogo2.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCatalogo2.Properties.Appearance.Options.UseFont = True
        Me.cbCatalogo2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo2.Properties.DisplayMember = "Display"
        Me.cbCatalogo2.Properties.NullText = ""
        Me.cbCatalogo2.Properties.PopupFormMinSize = New System.Drawing.Size(700, 0)
        Me.cbCatalogo2.Properties.ValueMember = "Cuenta"
        Me.cbCatalogo2.Properties.View = Me.vCat2
        Me.cbCatalogo2.Size = New System.Drawing.Size(448, 20)
        Me.cbCatalogo2.TabIndex = 3
        '
        'vCat2
        '
        Me.vCat2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.vCat2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.vCat2.Name = "vCat2"
        Me.vCat2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.vCat2.OptionsView.ShowAutoFilterRow = True
        Me.vCat2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Cuenta"
        Me.GridColumn4.FieldName = "Cuenta"
        Me.GridColumn4.MinWidth = 150
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 150
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Nombre"
        Me.GridColumn5.FieldName = "Nombre"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        Me.GridColumn5.Width = 231
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Display"
        Me.GridColumn6.FieldName = "Display"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'txtDireccion
        '
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(128, 205)
        Me.txtDireccion.MaxLength = 150
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDireccion.Size = New System.Drawing.Size(448, 61)
        Me.txtDireccion.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(64, 283)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 172
        Me.Label5.Text = "Origen:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(44, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 172
        Me.Label4.Text = "Dirección:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label32.Location = New System.Drawing.Point(44, 183)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(78, 16)
        Me.Label32.TabIndex = 172
        Me.Label32.Text = "Municipio:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label33.Location = New System.Drawing.Point(68, 154)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(54, 16)
        Me.Label33.TabIndex = 171
        Me.Label33.Text = "Depto:"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadioGroup1
        '
        Me.RadioGroup1.EditValue = 0
        Me.RadioGroup1.Location = New System.Drawing.Point(128, 272)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioGroup1.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.RadioGroup1.Properties.Appearance.Options.UseFont = True
        Me.RadioGroup1.Properties.Appearance.Options.UseForeColor = True
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Nacional"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Extranjero")})
        Me.RadioGroup1.Size = New System.Drawing.Size(448, 27)
        Me.RadioGroup1.TabIndex = 8
        '
        'chkExento
        '
        Me.chkExento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkExento.ForeColor = System.Drawing.Color.DarkRed
        Me.chkExento.Location = New System.Drawing.Point(455, 173)
        Me.chkExento.Name = "chkExento"
        Me.chkExento.Size = New System.Drawing.Size(130, 26)
        Me.chkExento.TabIndex = 10
        Me.chkExento.Text = "Exento IR"
        '
        'chkRetenedor
        '
        Me.chkRetenedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRetenedor.ForeColor = System.Drawing.Color.DarkRed
        Me.chkRetenedor.Location = New System.Drawing.Point(455, 144)
        Me.chkRetenedor.Name = "chkRetenedor"
        Me.chkRetenedor.Size = New System.Drawing.Size(145, 26)
        Me.chkRetenedor.TabIndex = 9
        Me.chkRetenedor.Text = "Recaudador IVA"
        '
        'cbCatalogo
        '
        Me.cbCatalogo.Location = New System.Drawing.Point(128, 69)
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCatalogo.Properties.Appearance.Options.UseFont = True
        Me.cbCatalogo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo.Properties.DisplayMember = "Display"
        Me.cbCatalogo.Properties.NullText = ""
        Me.cbCatalogo.Properties.PopupFormMinSize = New System.Drawing.Size(700, 0)
        Me.cbCatalogo.Properties.ValueMember = "Cuenta"
        Me.cbCatalogo.Properties.View = Me.vCat1
        Me.cbCatalogo.Size = New System.Drawing.Size(448, 20)
        Me.cbCatalogo.TabIndex = 2
        '
        'vCat1
        '
        Me.vCat1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.vCat1.Name = "vCat1"
        Me.vCat1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.vCat1.OptionsView.ShowAutoFilterRow = True
        Me.vCat1.OptionsView.ShowGroupPanel = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label6.Location = New System.Drawing.Point(1, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 16)
        Me.Label6.TabIndex = 141
        Me.Label6.Text = "Cuenta Transito:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label3.Location = New System.Drawing.Point(62, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 141
        Me.Label3.Text = "Cuenta:"
        '
        'etAceptar
        '
        Me.etAceptar.BackColor = System.Drawing.Color.Transparent
        Me.etAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etAceptar.ForeColor = System.Drawing.Color.MediumBlue
        Me.etAceptar.Location = New System.Drawing.Point(257, 17)
        Me.etAceptar.Name = "etAceptar"
        Me.etAceptar.Size = New System.Drawing.Size(72, 20)
        Me.etAceptar.TabIndex = 140
        Me.etAceptar.Text = "Aceptar"
        Me.etAceptar.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label2.Location = New System.Drawing.Point(83, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "Ruc:"
        '
        'txtRuc
        '
        Me.txtRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.Location = New System.Drawing.Point(128, 121)
        Me.txtRuc.MaxLength = 50
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(176, 20)
        Me.txtRuc.TabIndex = 4
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label29.Location = New System.Drawing.Point(60, 21)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(62, 16)
        Me.Label29.TabIndex = 135
        Me.Label29.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.SystemColors.Info
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(128, 17)
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(104, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(55, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(128, 43)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(448, 20)
        Me.txtNombre.TabIndex = 1
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Location = New System.Drawing.Point(504, 14)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 35)
        Me.cmdCancelar.TabIndex = 2
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Location = New System.Drawing.Point(8, 14)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 35)
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Text = "&Guardar"
        '
        'cmdAddAll
        '
        Me.cmdAddAll.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddAll.Appearance.Options.UseFont = True
        Me.cmdAddAll.Appearance.Options.UseTextOptions = True
        Me.cmdAddAll.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdAddAll.Location = New System.Drawing.Point(86, 14)
        Me.cmdAddAll.Name = "cmdAddAll"
        Me.cmdAddAll.Size = New System.Drawing.Size(114, 35)
        Me.cmdAddAll.TabIndex = 1
        Me.cmdAddAll.Text = "Agregar toda la información"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmdAceptar)
        Me.GroupBox1.Controls.Add(Me.cmdAddAll)
        Me.GroupBox1.Controls.Add(Me.cmdCancelar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(4, 305)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(606, 60)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'cbMunicipios
        '
        Me.cbMunicipios.Location = New System.Drawing.Point(128, 179)
        Me.cbMunicipios.Name = "cbMunicipios"
        Me.cbMunicipios.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMunicipios.Properties.Appearance.Options.UseFont = True
        Me.cbMunicipios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMunicipios.Size = New System.Drawing.Size(320, 20)
        Me.cbMunicipios.TabIndex = 209
        '
        'cbDepartamentos
        '
        Me.cbDepartamentos.Location = New System.Drawing.Point(128, 150)
        Me.cbDepartamentos.Name = "cbDepartamentos"
        Me.cbDepartamentos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDepartamentos.Properties.Appearance.Options.UseFont = True
        Me.cbDepartamentos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbDepartamentos.Size = New System.Drawing.Size(320, 20)
        Me.cbDepartamentos.TabIndex = 208
        '
        'frmAgregarProveedorQuick
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(616, 371)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAgregarProveedorQuick"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.cbCatalogo2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vCat2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vCat1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.cbMunicipios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDepartamentos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Proveedores As New VB.SysContab.ProveedoresDB()
    Public Detalles As VB.SysContab.ProveedoresDetails

    Dim r As New VB.SysContab.Rutinas()
    Public Nuevo As String = ""

    Private Sub frmAgregarProveedorQuick_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Dpto As New VB.SysContab.DepartamentosCDB

        Combo(cbDepartamentos, VB.SysContab.DepartamentosCDB.List())
        cbDepartamentos.ItemIndex = 0

        'cbDepartamentos.DataSource = VB.SysContab.DepartamentosCDB.List()   '.Tables("DepartamentosC")
        'cbDepartamentos.ValueMember = "Codigo"
        'cbDepartamentos.DisplayMember = "Nombre"
        'Combo de Catalogo de Cuentas
        GetCatalogoCuenta(Me.cbCatalogo, Me.vCat1)
        GetCatalogoCuenta(Me.cbCatalogo2, Me.vCat2)
        'Me.cbCatalogo.Properties.DataSource = ObtieneDatos("SELECT Cuenta,Nombre,Cuenta + ' - ' + Nombre AS Display FROM CATALOGO WHERE Tipo = 'A'")

        If Nuevo = "NO" Then
            Me.Text = "Editar Proveedor"

            Detalles = VB.SysContab.ProveedoresDB.GetDetails(Registro)
            Me.txtCodigo.Text = Detalles.Codigo
            Me.txtCodigo.ReadOnly = True
            Me.txtCodigo.Enabled = False

            Me.txtNombre.Text = Detalles.Nombre

            Me.txtDireccion.Text = Detalles.Direccion
            Me.txtRuc.Text = Detalles.Ruc
            Me.RadioGroup1.EditValue = IIf(Detalles.Origen, 1, 0)

            Me.cbDepartamentos.EditValue = Detalles.Departamento
            Me.cbMunicipios.EditValue = Detalles.Municipio

            Me.cbCatalogo.EditValue = Detalles.Cuenta
            Me.cbCatalogo2.EditValue = Detalles.CuentaTransito
            Me.chkRetenedor.Checked = Detalles.Retenedor
            Me.chkExento.Checked = Detalles.Exento
        Else
            Me.Text = "Agregar Proveedor"
            If Proveedores.GenerarCodigo().Tables("Proveedores").Rows.Count <> 0 Then
                Me.txtCodigo.Text = Proveedores.GenerarCodigo().Tables("Proveedores").Rows(0).Item("Codigo") + 1
            Else
                Me.txtCodigo.Text = "1"
            End If
        End If

        Me.etAceptar.Text = "0"
        Me.Refresh()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Trim(txtCodigo.Text) = "" Then
            MsgBox("Introduzca el Código del Proveedor", MsgBoxStyle.Information)
            txtCodigo.Focus()
            Exit Sub
        End If

        If Trim(txtNombre.Text) = "" Then
            MsgBox("Introduzca el Nombre del Proveedor", MsgBoxStyle.Information)
            txtNombre.Focus()
            Exit Sub
        End If

        If Me.cbCatalogo.EditValue Is Nothing Then
            MsgBox("Introduzca el Nombre de la Cuenta Contable del Proveedor", MsgBoxStyle.Information)
            Me.cbCatalogo.Focus()
            Exit Sub
        End If

        If Trim(txtRuc.Text) = "" Then
            MsgBox("Introduzca el No. Ruc del Proveedor", MsgBoxStyle.Information)
            txtRuc.Focus()
            Exit Sub
        End If

        Dim Retenedor As Integer
        If chkRetenedor.Checked = True Then : Retenedor = 1 : Else : Retenedor = 0 : End If

        Dim exento As Integer
        If chkExento.Checked = True Then : exento = 1 : Else : exento = 0 : End If

        Dim Origen As Integer = Me.RadioGroup1.EditValue

        Try
            If Nuevo = "SI" Then    'Guardar Proveedor
                If Proveedores.GenerarCodigo().Tables("Proveedores").Rows.Count <> 0 Then
                    Me.txtCodigo.Text = Proveedores.GenerarCodigo().Tables("Proveedores").Rows(0).Item("Codigo") + 1
                Else
                    Me.txtCodigo.Text = "1"
                End If

                Proveedores.AddItem(txtCodigo.Text, txtNombre.Text, "", "", "", "", "", "", "", "", "", _
                                     "", "", "", Me.txtDireccion.Text, "", "", "", "", Me.txtRuc.Text, 1, 0, 0, Me.cbCatalogo.EditValue, _
                                     2, Retenedor, Me.cbDepartamentos.EditValue, IIf(cbMunicipios.EditValue Is Nothing, 0, cbMunicipios.EditValue), 0, exento, "", "", "", "", Origen, "", _
                                     IIf(Me.cbCatalogo2.EditValue Is Nothing, "", Me.cbCatalogo2.EditValue))

                Me.etAceptar.Text = "1"
            Else
                Proveedores.Update(txtCodigo.Text, txtNombre.Text, Detalles.Encargado, Detalles.Cargo, Detalles.Telefono_Contacto, Detalles.Email_Contacto, _
                                    Detalles.Gerente, Detalles.Telefono_Gerente, Detalles.Celular_Gerente, Detalles.Email_Gerente, Detalles.Contador, Detalles.Telefono_Contador, _
                                    Detalles.Celular_Contador, Detalles.Email_Contador, txtDireccion.Text, Detalles.Ciudad, Detalles.Telefono, Detalles.Fax, Detalles.Correo, txtRuc.Text, _
                                    Detalles.Tipo, Detalles.Cod_Forma_Pago, Detalles.Cod_Zona, Me.cbCatalogo.EditValue, 2, Retenedor, _
                                    Me.cbDepartamentos.EditValue, IIf(cbMunicipios.EditValue Is Nothing, 0, cbMunicipios.EditValue), Detalles.Varios, exento, Detalles.Cedula, Detalles.nNombre, Detalles.pApellido, Detalles.sApellido, Origen, _
                                    "", IIf(Me.cbCatalogo2.EditValue Is Nothing, "", Me.cbCatalogo2.EditValue))
            End If

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub cmdAddAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddAll.Click
        'Me.Close()
        'Dim f As frmAgregarCliente = f.Instance
        'Dim fp As DataGridTextBoxCombo.frmFacturacionCliente = fp.Instance
        'Nuevo = "SI"
        'AgregarClienteQuick = True
        'f.MdiParent = fp.MdiParent
        'f.Show()
        'f.cbZona.SelectedValue = -1
        'f.cbVendedor.SelectedValue = -1
        'f.cbCatalogo.SelectedValue = -1
        'f.txtNombre.Text = NombreCliente.ToUpper
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.etAceptar.Text = "0"
        Me.Close()
    End Sub

    'Private Sub cbDepartamentos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Dim Muni As New VB.SysContab.MunicipiosDB

    '        If IsNumeric(cbDepartamentos.SelectedValue) Then
    '            cbMunicipios.DataSource = Muni.List(cbDepartamentos.SelectedValue.ToString).Tables("Municipios")
    '            cbMunicipios.ValueMember = "Codigo"
    '            cbMunicipios.DisplayMember = "Nombre"
    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Private Sub LookUpEdit2_EditValueChanged(sender As Object, e As EventArgs) Handles cbDepartamentos.EditValueChanged
        Try
            Dim Muni As New VB.SysContab.MunicipiosDB

            Combo(cbMunicipios, Muni.List(cbDepartamentos.EditValue))

            'If IsNumeric(cbDepartamentos.SelectedValue) Then
            '    cbMunicipios.DataSource = Muni.List(cbDepartamentos.SelectedValue.ToString).Tables("Municipios")
            '    cbMunicipios.ValueMember = "Codigo"
            '    cbMunicipios.DisplayMember = "Nombre"
            'End If
        Catch ex As Exception
        End Try
    End Sub
End Class
