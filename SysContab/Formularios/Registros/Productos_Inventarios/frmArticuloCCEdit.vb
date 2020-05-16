Public Class frmArticuloCCEdit
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmArticuloCCEdit = Nothing

    Public Shared Function Instance() As frmArticuloCCEdit
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmArticuloCCEdit()
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCosto As System.Windows.Forms.TextBox
    Friend WithEvents txtPresentacion As System.Windows.Forms.TextBox
    Friend WithEvents txtUnidad As System.Windows.Forms.TextBox
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtStockMax As System.Windows.Forms.TextBox
    Friend WithEvents txtStockMin As System.Windows.Forms.TextBox
    Friend WithEvents txtExistencias As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents cbSubGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents cbGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents cbLinea As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTransito As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCostoUltimo As System.Windows.Forms.TextBox
    Friend WithEvents txtCostoPromedio As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtUbicacion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAcumulados As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdProveedoresAdicionales As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents etInicio As System.Windows.Forms.Label
    Friend WithEvents txtUltimaCompra As System.Windows.Forms.TextBox
    Friend WithEvents txtUltimaSalida As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents ckExento As System.Windows.Forms.CheckBox
    Friend WithEvents cbProveedor As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbCatalogo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents vCat1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label31 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbCatalogo = New DevExpress.XtraEditors.GridLookUpEdit
        Me.vCat1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cbProveedor = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ckExento = New System.Windows.Forms.CheckBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.etInicio = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.txtUltimaCompra = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtUltimaSalida = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtUbicacion = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.txtCosto = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtCostoUltimo = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtCostoPromedio = New System.Windows.Forms.TextBox
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtTransito = New System.Windows.Forms.TextBox
        Me.txtExistencias = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtStockMax = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtStockMin = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.cbSubGrupo = New System.Windows.Forms.ComboBox
        Me.cbGrupo = New System.Windows.Forms.ComboBox
        Me.cbLinea = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtPresentacion = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtUnidad = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtModelo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.GroupBox11 = New System.Windows.Forms.GroupBox
        Me.cmdProveedoresAdicionales = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAcumulados = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.cbCatalogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vCat1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cbCatalogo)
        Me.GroupBox1.Controls.Add(Me.cbProveedor)
        Me.GroupBox1.Controls.Add(Me.ckExento)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.etInicio)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.txtUbicacion)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox10)
        Me.GroupBox1.Controls.Add(Me.GroupBox8)
        Me.GroupBox1.Controls.Add(Me.GroupBox9)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.cbSubGrupo)
        Me.GroupBox1.Controls.Add(Me.cbGrupo)
        Me.GroupBox1.Controls.Add(Me.cbLinea)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtPresentacion)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtUnidad)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtModelo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(784, 407)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cbCatalogo
        '
        Me.cbCatalogo.Location = New System.Drawing.Point(136, 156)
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCatalogo.Properties.Appearance.Options.UseFont = True
        Me.cbCatalogo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo.Properties.NullText = "--- Seleccione Cuenta ---"
        Me.cbCatalogo.Properties.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.cbCatalogo.Properties.View = Me.vCat1
        Me.cbCatalogo.Size = New System.Drawing.Size(344, 22)
        Me.cbCatalogo.TabIndex = 6
        '
        'vCat1
        '
        Me.vCat1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.vCat1.Name = "vCat1"
        Me.vCat1.OptionsBehavior.Editable = False
        Me.vCat1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.vCat1.OptionsView.ShowGroupPanel = False
        '
        'cbProveedor
        '
        Me.cbProveedor.Location = New System.Drawing.Point(416, 19)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedor.Properties.Appearance.Options.UseFont = True
        Me.cbProveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProveedor.Properties.NullText = "--- Seleccione Proveedor ---"
        Me.cbProveedor.Properties.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.cbProveedor.Properties.View = Me.GridView1
        Me.cbProveedor.Size = New System.Drawing.Size(344, 22)
        Me.cbProveedor.TabIndex = 1
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'ckExento
        '
        Me.ckExento.Location = New System.Drawing.Point(624, 163)
        Me.ckExento.Name = "ckExento"
        Me.ckExento.Size = New System.Drawing.Size(104, 17)
        Me.ckExento.TabIndex = 11
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label31.Location = New System.Drawing.Point(549, 162)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(59, 16)
        Me.Label31.TabIndex = 171
        Me.Label31.Text = "Exento:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label32.Location = New System.Drawing.Point(60, 162)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(60, 16)
        Me.Label32.TabIndex = 168
        Me.Label32.Text = "Cuenta:"
        '
        'etInicio
        '
        Me.etInicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etInicio.Location = New System.Drawing.Point(24, 405)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(96, 26)
        Me.etInicio.TabIndex = 145
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Location = New System.Drawing.Point(524, 250)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(252, 35)
        Me.GroupBox6.TabIndex = 144
        Me.GroupBox6.TabStop = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(0, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(267, 21)
        Me.Label13.TabIndex = 113
        Me.Label13.Text = "ENTRADAS / SALIDAS"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.TextBox5)
        Me.GroupBox7.Controls.Add(Me.TextBox6)
        Me.GroupBox7.Controls.Add(Me.Label26)
        Me.GroupBox7.Controls.Add(Me.Label25)
        Me.GroupBox7.Controls.Add(Me.Label27)
        Me.GroupBox7.Controls.Add(Me.TextBox7)
        Me.GroupBox7.Controls.Add(Me.Label30)
        Me.GroupBox7.Controls.Add(Me.TextBox8)
        Me.GroupBox7.Location = New System.Drawing.Point(524, 276)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(252, 120)
        Me.GroupBox7.TabIndex = 143
        Me.GroupBox7.TabStop = False
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(155, 60)
        Me.TextBox5.MaxLength = 50
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(69, 20)
        Me.TextBox5.TabIndex = 125
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(155, 34)
        Me.TextBox6.MaxLength = 50
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(69, 20)
        Me.TextBox6.TabIndex = 124
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(132, 9)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(112, 17)
        Me.Label26.TabIndex = 123
        Me.Label26.Text = "Monto"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(48, 9)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(112, 17)
        Me.Label25.TabIndex = 118
        Me.Label25.Text = "Unidades"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(8, 60)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 18)
        Me.Label27.TabIndex = 122
        Me.Label27.Text = "Salidas:"
        '
        'TextBox7
        '
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(80, 60)
        Me.TextBox7.MaxLength = 50
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(64, 20)
        Me.TextBox7.TabIndex = 17
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label30.Location = New System.Drawing.Point(8, 34)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(64, 26)
        Me.Label30.TabIndex = 120
        Me.Label30.Text = "Compras:"
        '
        'TextBox8
        '
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(80, 34)
        Me.TextBox8.MaxLength = 50
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(64, 20)
        Me.TextBox8.TabIndex = 16
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(264, 250)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(254, 34)
        Me.GroupBox4.TabIndex = 142
        Me.GroupBox4.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(254, 21)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "COMPRAS-INVENTARIO FISICO"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.TextBox1)
        Me.GroupBox5.Controls.Add(Me.txtUltimaCompra)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.TextBox3)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.txtUltimaSalida)
        Me.GroupBox5.Location = New System.Drawing.Point(264, 276)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(254, 120)
        Me.GroupBox5.TabIndex = 141
        Me.GroupBox5.TabStop = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(8, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 25)
        Me.Label7.TabIndex = 118
        Me.Label7.Text = "Fecha Ultima Compra:"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(8, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 26)
        Me.Label9.TabIndex = 126
        Me.Label9.Text = "Pedido Transito:"
        Me.Label9.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(140, 86)
        Me.TextBox1.MaxLength = 50
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(102, 20)
        Me.TextBox1.TabIndex = 24
        Me.TextBox1.Visible = False
        '
        'txtUltimaCompra
        '
        Me.txtUltimaCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUltimaCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUltimaCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUltimaCompra.Location = New System.Drawing.Point(140, 9)
        Me.txtUltimaCompra.MaxLength = 50
        Me.txtUltimaCompra.Name = "txtUltimaCompra"
        Me.txtUltimaCompra.ReadOnly = True
        Me.txtUltimaCompra.Size = New System.Drawing.Size(102, 20)
        Me.txtUltimaCompra.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(8, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(126, 26)
        Me.Label11.TabIndex = 122
        Me.Label11.Text = "Fecha Ultimo Inv. Físico:"
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(140, 60)
        Me.TextBox3.MaxLength = 50
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(102, 20)
        Me.TextBox3.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(8, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 26)
        Me.Label12.TabIndex = 120
        Me.Label12.Text = "Fecha Ultima Salida:"
        '
        'txtUltimaSalida
        '
        Me.txtUltimaSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUltimaSalida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUltimaSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUltimaSalida.Location = New System.Drawing.Point(140, 34)
        Me.txtUltimaSalida.MaxLength = 50
        Me.txtUltimaSalida.Name = "txtUltimaSalida"
        Me.txtUltimaSalida.ReadOnly = True
        Me.txtUltimaSalida.Size = New System.Drawing.Size(102, 20)
        Me.txtUltimaSalida.TabIndex = 16
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(526, 133)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(82, 16)
        Me.Label29.TabIndex = 140
        Me.Label29.Text = "Ubicación:"
        '
        'txtUbicacion
        '
        Me.txtUbicacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUbicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbicacion.Location = New System.Drawing.Point(624, 129)
        Me.txtUbicacion.MaxLength = 15
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(136, 20)
        Me.txtUbicacion.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 181)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(760, 34)
        Me.GroupBox2.TabIndex = 127
        Me.GroupBox2.TabStop = False
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(0, 9)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(760, 21)
        Me.Label22.TabIndex = 113
        Me.Label22.Text = "COSTOS"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox10.Controls.Add(Me.txtCosto)
        Me.GroupBox10.Controls.Add(Me.Label24)
        Me.GroupBox10.Controls.Add(Me.txtCostoUltimo)
        Me.GroupBox10.Controls.Add(Me.Label8)
        Me.GroupBox10.Controls.Add(Me.Label23)
        Me.GroupBox10.Controls.Add(Me.txtCostoPromedio)
        Me.GroupBox10.Location = New System.Drawing.Point(16, 207)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(760, 43)
        Me.GroupBox10.TabIndex = 12
        Me.GroupBox10.TabStop = False
        '
        'txtCosto
        '
        Me.txtCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCosto.Location = New System.Drawing.Point(80, 17)
        Me.txtCosto.MaxLength = 13
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(112, 20)
        Me.txtCosto.TabIndex = 0
        Me.txtCosto.Text = "0.00"
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(464, 17)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(104, 17)
        Me.Label24.TabIndex = 131
        Me.Label24.Text = "Costo Ultimo:"
        '
        'txtCostoUltimo
        '
        Me.txtCostoUltimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCostoUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoUltimo.Location = New System.Drawing.Point(576, 17)
        Me.txtCostoUltimo.MaxLength = 13
        Me.txtCostoUltimo.Name = "txtCostoUltimo"
        Me.txtCostoUltimo.ReadOnly = True
        Me.txtCostoUltimo.Size = New System.Drawing.Size(112, 20)
        Me.txtCostoUltimo.TabIndex = 2
        Me.txtCostoUltimo.Text = "0.00"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(8, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 17)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Costo:"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(208, 17)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(120, 17)
        Me.Label23.TabIndex = 129
        Me.Label23.Text = "Costo Promedio:"
        '
        'txtCostoPromedio
        '
        Me.txtCostoPromedio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCostoPromedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoPromedio.Location = New System.Drawing.Point(336, 17)
        Me.txtCostoPromedio.MaxLength = 13
        Me.txtCostoPromedio.Name = "txtCostoPromedio"
        Me.txtCostoPromedio.ReadOnly = True
        Me.txtCostoPromedio.Size = New System.Drawing.Size(112, 20)
        Me.txtCostoPromedio.TabIndex = 1
        Me.txtCostoPromedio.Text = "0.00"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox8.Controls.Add(Me.Label28)
        Me.GroupBox8.Location = New System.Drawing.Point(16, 250)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(240, 34)
        Me.GroupBox8.TabIndex = 137
        Me.GroupBox8.TabStop = False
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(0, 9)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(240, 21)
        Me.Label28.TabIndex = 113
        Me.Label28.Text = "EXISTENCIAS"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox9.Controls.Add(Me.Label17)
        Me.GroupBox9.Controls.Add(Me.Label21)
        Me.GroupBox9.Controls.Add(Me.txtTransito)
        Me.GroupBox9.Controls.Add(Me.txtExistencias)
        Me.GroupBox9.Controls.Add(Me.Label19)
        Me.GroupBox9.Controls.Add(Me.txtStockMax)
        Me.GroupBox9.Controls.Add(Me.Label18)
        Me.GroupBox9.Controls.Add(Me.txtStockMin)
        Me.GroupBox9.Location = New System.Drawing.Point(16, 276)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(240, 120)
        Me.GroupBox9.TabIndex = 136
        Me.GroupBox9.TabStop = False
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(8, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 25)
        Me.Label17.TabIndex = 118
        Me.Label17.Text = "Existencias:"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(8, 86)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(104, 26)
        Me.Label21.TabIndex = 126
        Me.Label21.Text = "Pedido Transito:"
        '
        'txtTransito
        '
        Me.txtTransito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTransito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTransito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransito.Location = New System.Drawing.Point(120, 86)
        Me.txtTransito.MaxLength = 50
        Me.txtTransito.Name = "txtTransito"
        Me.txtTransito.ReadOnly = True
        Me.txtTransito.Size = New System.Drawing.Size(112, 20)
        Me.txtTransito.TabIndex = 24
        '
        'txtExistencias
        '
        Me.txtExistencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExistencias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtExistencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExistencias.Location = New System.Drawing.Point(120, 9)
        Me.txtExistencias.MaxLength = 50
        Me.txtExistencias.Name = "txtExistencias"
        Me.txtExistencias.ReadOnly = True
        Me.txtExistencias.Size = New System.Drawing.Size(112, 20)
        Me.txtExistencias.TabIndex = 15
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(8, 60)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(96, 26)
        Me.Label19.TabIndex = 122
        Me.Label19.Text = "Stock Máximo:"
        '
        'txtStockMax
        '
        Me.txtStockMax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStockMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockMax.Location = New System.Drawing.Point(120, 60)
        Me.txtStockMax.MaxLength = 50
        Me.txtStockMax.Name = "txtStockMax"
        Me.txtStockMax.Size = New System.Drawing.Size(112, 20)
        Me.txtStockMax.TabIndex = 17
        Me.txtStockMax.Text = "0"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(8, 34)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 26)
        Me.Label18.TabIndex = 120
        Me.Label18.Text = "Stock Mínimo:"
        '
        'txtStockMin
        '
        Me.txtStockMin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStockMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockMin.Location = New System.Drawing.Point(120, 34)
        Me.txtStockMin.MaxLength = 50
        Me.txtStockMin.Name = "txtStockMin"
        Me.txtStockMin.Size = New System.Drawing.Size(112, 20)
        Me.txtStockMin.TabIndex = 16
        Me.txtStockMin.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(58, 28)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 16)
        Me.Label16.TabIndex = 116
        Me.Label16.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(136, 24)
        Me.txtCodigo.MaxLength = 50
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(136, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'cbSubGrupo
        '
        Me.cbSubGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSubGrupo.Location = New System.Drawing.Point(136, 129)
        Me.cbSubGrupo.Name = "cbSubGrupo"
        Me.cbSubGrupo.Size = New System.Drawing.Size(344, 21)
        Me.cbSubGrupo.TabIndex = 5
        '
        'cbGrupo
        '
        Me.cbGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGrupo.Location = New System.Drawing.Point(136, 103)
        Me.cbGrupo.Name = "cbGrupo"
        Me.cbGrupo.Size = New System.Drawing.Size(344, 21)
        Me.cbGrupo.TabIndex = 4
        '
        'cbLinea
        '
        Me.cbLinea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLinea.Location = New System.Drawing.Point(136, 78)
        Me.cbLinea.Name = "cbLinea"
        Me.cbLinea.Size = New System.Drawing.Size(344, 21)
        Me.cbLinea.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(35, 134)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 16)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "Sub Grupo:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(66, 107)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 16)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "Grupo:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(325, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 16)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Proveedor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(505, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 16)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Presentación:"
        '
        'txtPresentacion
        '
        Me.txtPresentacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPresentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPresentacion.Location = New System.Drawing.Point(624, 103)
        Me.txtPresentacion.MaxLength = 10
        Me.txtPresentacion.Name = "txtPresentacion"
        Me.txtPresentacion.Size = New System.Drawing.Size(136, 20)
        Me.txtPresentacion.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(546, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Unidad:"
        '
        'txtUnidad
        '
        Me.txtUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnidad.Location = New System.Drawing.Point(624, 78)
        Me.txtUnidad.MaxLength = 12
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(136, 20)
        Me.txtUnidad.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(544, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Modelo:"
        '
        'txtModelo
        '
        Me.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(624, 52)
        Me.txtModelo.MaxLength = 7
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(136, 20)
        Me.txtModelo.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(70, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Linea:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(25, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Descripción:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(136, 52)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(344, 20)
        Me.txtNombre.TabIndex = 2
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(12, 141)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(80, 34)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Location = New System.Drawing.Point(12, 20)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(80, 34)
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Text = "Aceptar"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Location = New System.Drawing.Point(9, -6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(892, 34)
        Me.GroupBox3.TabIndex = 113
        Me.GroupBox3.TabStop = False
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(0, 9)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(896, 21)
        Me.Label20.TabIndex = 113
        Me.Label20.Text = "DESCRIPCION DEL PRODUCTO"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox11
        '
        Me.GroupBox11.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox11.Controls.Add(Me.cmdProveedoresAdicionales)
        Me.GroupBox11.Controls.Add(Me.cmdAcumulados)
        Me.GroupBox11.Controls.Add(Me.cmdCancelar)
        Me.GroupBox11.Controls.Add(Me.cmdAceptar)
        Me.GroupBox11.Location = New System.Drawing.Point(797, 21)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(104, 408)
        Me.GroupBox11.TabIndex = 1
        Me.GroupBox11.TabStop = False
        '
        'cmdProveedoresAdicionales
        '
        Me.cmdProveedoresAdicionales.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProveedoresAdicionales.Appearance.Options.UseFont = True
        Me.cmdProveedoresAdicionales.Appearance.Options.UseTextOptions = True
        Me.cmdProveedoresAdicionales.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdProveedoresAdicionales.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdProveedoresAdicionales.Location = New System.Drawing.Point(12, 100)
        Me.cmdProveedoresAdicionales.Name = "cmdProveedoresAdicionales"
        Me.cmdProveedoresAdicionales.Size = New System.Drawing.Size(80, 35)
        Me.cmdProveedoresAdicionales.TabIndex = 2
        Me.cmdProveedoresAdicionales.Text = "Proveedores Adicionales"
        '
        'cmdAcumulados
        '
        Me.cmdAcumulados.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAcumulados.Appearance.Options.UseFont = True
        Me.cmdAcumulados.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAcumulados.Location = New System.Drawing.Point(12, 60)
        Me.cmdAcumulados.Name = "cmdAcumulados"
        Me.cmdAcumulados.Size = New System.Drawing.Size(80, 34)
        Me.cmdAcumulados.TabIndex = 1
        Me.cmdAcumulados.Text = "Acumulados"
        '
        'frmArticuloCCEdit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(906, 435)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox11)
        Me.Name = "frmArticuloCCEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cbCatalogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vCat1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim r As New VB.SysContab.Rutinas()
    Dim GruposCC As New VB.SysContab.GruposCCDB()
    Dim ds As DataSet
    Dim Proveedores As New VB.SysContab.ProveedoresDB()
    Dim Catalogos As New VB.SysContab.CatalogoDB()
    Private Sub frmArticuloCCEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim g As New VB.SysContab.Grupos_InventarioDB()
        ds = GruposCC.ArticulosCCDetalles(Me.txtCodigo.Text)

        Me.txtCodigo.ReadOnly = True

        cbLinea.DataSource = GruposCC.Lineas().Tables("GruposCC")
        cbLinea.ValueMember = "Código"
        cbLinea.DisplayMember = "Nombre"

        GetCatalogoProveedores(Me.cbProveedor, GridView1)
        GetCatalogoCuenta(Me.cbCatalogo, vCat1)

        'cbProveedor.DataSource = Proveedores.ListAll().Tables("Proveedores")
        'cbProveedor.ValueMember = "Codigo"
        'cbProveedor.DisplayMember = "Nombre"

        'Me.cbCatalogo.DataSource = Catalogos.CatalogoList("A", 0).Tables("CATALOGO")
        'Me.cbCatalogo.ValueMember = "Cuenta"
        'Me.cbCatalogo.DisplayMember = "Nombre2"

        Me.cbProveedor.EditValue = ds.Tables("Tabla").Rows(0).Item("Proveedor_ID").ToString
        Me.txtNombre.Text = ds.Tables("Tabla").Rows(0).Item("Articulo_Descripcion").ToString
        Me.cbLinea.SelectedValue = ds.Tables("Tabla").Rows(0).Item("Linea_ID").ToString
        Me.cbCatalogo.EditValue = ds.Tables("Tabla").Rows(0).Item("Cuenta").ToString

        Me.txtModelo.Text = ds.Tables("Tabla").Rows(0).Item("Articulo_Modelo").ToString
        Me.txtUnidad.Text = ds.Tables("Tabla").Rows(0).Item("Articulo_Unidad").ToString
        Me.txtPresentacion.Text = ds.Tables("Tabla").Rows(0).Item("Articulo_Presentacion").ToString
        Me.txtUbicacion.Text = ds.Tables("Tabla").Rows(0).Item("Articulo_Ubicacion").ToString
        Me.txtCosto.Text = CDbl(ds.Tables("Tabla").Rows(0).Item("Articulo_Costo")).ToString(RoundP)
        Me.txtCostoPromedio.Text = CDbl(ds.Tables("Tabla").Rows(0).Item("Articulo_CostoPromedio")).ToString(RoundP)
        Me.txtCostoUltimo.Text = CDbl(ds.Tables("Tabla").Rows(0).Item("Articulo_CostoUltimo")).ToString(RoundP)
        Me.txtStockMin.Text = ds.Tables("Tabla").Rows(0).Item("Articulo_Stock_Minimo").ToString
        Me.txtStockMax.Text = ds.Tables("Tabla").Rows(0).Item("Articulo_Stock_Maximo").ToString
        Try
            Me.ckExento.Checked = CBool(ds.Tables("Tabla").Rows(0).Item("Exento").ToString)
        Catch ex As Exception
            Me.ckExento.Checked = False
        End Try

        Dim dsExistencias As DataSet
        dsExistencias = GruposCC.ArticulosCCExistencias(Me.txtCodigo.Text)

        If dsExistencias.Tables("GruposCC").Rows.Count = 0 Then
            Me.txtExistencias.Text = 0
        Else
            Me.txtExistencias.Text = dsExistencias.Tables("GruposCC").Rows(0).Item("Existencias")
        End If

        dsExistencias = GruposCC.ArticulosCCUltimaSalida(Me.txtCodigo.Text)

        If dsExistencias.Tables("GruposCC").Rows.Count = 0 Then
            'Me.txtExistencias.Text = 0
        Else
            Me.txtUltimaSalida.Text = dsExistencias.Tables("GruposCC").Rows(0).Item("Fecha")
        End If

        dsExistencias = GruposCC.ArticulosCCUltimaCompra(Me.txtCodigo.Text)

        If dsExistencias.Tables("GruposCC").Rows.Count = 0 Then
            'Me.txtExistencias.Text = 0
        Else
            Me.txtUltimaCompra.Text = dsExistencias.Tables("GruposCC").Rows(0).Item("Fecha")
        End If


        'dsExistencias = GruposCC.ArticulosCCExistencias(tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo"))

        'If dsExistencias.Tables("GruposCC").Rows.Count = 0 Then
        '    MsgBox("No hay existencias...", MsgBoxStyle.Critical)
        '    Cantidad.TextBox.Text = ValorActualCantidad
        'Else
        '    If dsExistencias.Tables("GruposCC").Rows(0).Item("Existencias") = 0 Then
        '        MsgBox("No hay existencias...", MsgBoxStyle.Critical)
        '        Cantidad.TextBox.Text = ValorActualCantidad
        '    ElseIf dsExistencias.Tables("GruposCC").Rows(0).Item("Existencias") < Cantidad.TextBox.Text Then
        '        MsgBox("La existencia no es suficiente", MsgBoxStyle.Critical)
        '        Cantidad.TextBox.Text = ValorActualCantidad
        '    End If

        'End If

        If Me.cbLinea.SelectedValue Is Nothing Then Me.cbLinea.SelectedValue = "%"

        cbGrupo.DataSource = GruposCC.Grupos(Me.cbLinea.SelectedValue).Tables("GruposCC")
        cbGrupo.ValueMember = "Código"
        cbGrupo.DisplayMember = "Nombre"

        Me.cbGrupo.SelectedValue = ds.Tables("Tabla").Rows(0).Item("Grupo_ID").ToString

        If Me.cbGrupo.SelectedValue Is Nothing Then Me.cbGrupo.SelectedValue = "%"
        cbSubGrupo.DataSource = GruposCC.SubGrupos(Me.cbGrupo.SelectedValue.ToString).Tables("GruposCC")
        cbSubGrupo.ValueMember = "Código"
        cbSubGrupo.DisplayMember = "Nombre"

        Me.cbSubGrupo.SelectedValue = ds.Tables("Tabla").Rows(0).Item("SubGrupo_ID").ToString
        If Me.cbSubGrupo.SelectedValue Is Nothing Then Me.cbSubGrupo.SelectedValue = "%"


        r.ComboAutoComplete(Me.cbLinea)
        r.ComboAutoComplete(Me.cbGrupo)
        r.ComboAutoComplete(Me.cbSubGrupo)
        'r.ComboAutoComplete(Me.cbProveedor)

        'r.FormularioColor(Me)
        Me.Label20.BackColor = Color.FromArgb(102, 153, 153)
        Me.Label22.BackColor = Color.FromArgb(102, 153, 153)
        Me.Label6.BackColor = Color.FromArgb(102, 153, 153)
        Me.Label13.BackColor = Color.FromArgb(102, 153, 153)
        Me.Label28.BackColor = Color.FromArgb(102, 153, 153)

        Me.Refresh()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()

    End Sub


    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Try
            Guardar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub cbLinea_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbLinea.SelectedValueChanged
        If Me.etInicio.Text = "1" Then
            Exit Sub
        End If

        cbGrupo.DataSource = GruposCC.Grupos(Me.cbLinea.SelectedValue).Tables("GruposCC")
        cbGrupo.ValueMember = "Código"
        cbGrupo.DisplayMember = "Nombre"
    End Sub

    Private Sub cbGrupo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbGrupo.SelectedValueChanged
        If Me.etInicio.Text = "1" Then
            Exit Sub
        End If

        cbSubGrupo.DataSource = GruposCC.SubGrupos(Me.cbGrupo.SelectedValue.ToString).Tables("GruposCC")
        cbSubGrupo.ValueMember = "Código"
        cbSubGrupo.DisplayMember = "Nombre"
    End Sub

    Private Sub txtCosto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCosto.Leave
        If Trim(Me.txtCosto.Text) = "" Then
            Me.txtCosto.Text = "0.00"
        End If
        If IsNumeric(Me.txtCosto.Text) = False Then
            MsgBox("Ingrese un valor numérico", MsgBoxStyle.Information)
            Me.txtCosto.Focus()
            Exit Sub
        Else
            Me.txtCosto.Text = CDbl(Me.txtCosto.Text).ToString(RoundP)
        End If
    End Sub

    Private Sub cmdAcumulados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcumulados.Click
        'Dim f As frmAcumuladosProductos = f.Instance
        'f.MdiParent = Me.MdiParent
        'f.Show()

        If Trim(Me.txtCodigo.Text) = "" Then
            MsgBox("Ingrese el Código del Articulo", MsgBoxStyle.Information)
            Me.txtCodigo.Focus()
            Exit Sub
        End If

        Dim f As frmArticuloCCDetalle = f.Instance
        f.etCodigo.Text = Me.txtCodigo.Text
        f.etNombre.Text = Me.txtNombre.Text
        f.etProveedor.Text = Me.cbProveedor.Text
        f.etLinea.Text = Me.cbLinea.Text
        f.etPrecio.Text = Me.txtCosto.Text
        f.etExistencias.Text = Me.txtExistencias.Text
        f.etStockMin.Text = Me.txtStockMin.Text
        f.etStockMax.Text = Me.txtStockMax.Text
        f.etUltimaCompra.Text = Me.txtUltimaCompra.Text
        f.etUltimaVenta.Text = Me.txtUltimaSalida.Text

        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub

    Private Sub cmdProveedoresAdicionales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProveedoresAdicionales.Click
        If Trim(Me.txtCodigo.Text) = "" Then
            MsgBox("Introduzca el Código del Articulo", MsgBoxStyle.Information)
            Me.txtCodigo.Focus()
            Exit Sub
        End If

        If Me.cbProveedor.EditValue Is Nothing Then
            MsgBox("Seleccione el Proveedor", MsgBoxStyle.Information)
            Me.cbProveedor.Focus()
            Exit Sub
        End If

        If Nuevo = "SI" Then
            Try
                Guardar()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
        End If

        Dim f As New frmProveedoresAdicionales()

        f.etProveedor.Text = cbProveedor.EditValue
        f.etArticulo.Text = Me.txtCodigo.Text

        f.StartPosition = FormStartPosition.CenterScreen
        f.FormBorderStyle = FormBorderStyle.Fixed3D
        f.MaximizeBox = False

        f.ShowDialog()

        If Nuevo = "SI" Then
            Limpiar()
        End If

    End Sub

    Private Sub Guardar()
        Dim linea, grupo, subgrupo As String

        linea = "0"
        grupo = "0"
        subgrupo = "0"

        If Trim(Me.txtCodigo.Text) = "" Then
            MsgBox("Ingrese el Código del Articulo", MsgBoxStyle.Information)
            Me.txtCodigo.Focus()
            Me.txtCodigo.SelectAll()
            Exit Sub
        End If

        'If Me.cbProveedor.SelectedValue = 0 Or Me.cbProveedor.SelectedValue = Nothing Then
        '    MsgBox("Seleccione el Proveedor del Articulo", MsgBoxStyle.Information)
        '    Me.cbProveedor.Focus()
        '    Exit Sub
        'End If


        If Me.cbProveedor.EditValue Is Nothing Then
            MsgBox("Seleccione el Proveedor", MsgBoxStyle.Information)
            Me.cbProveedor.Focus()
            Exit Sub
        End If

        If Trim(Me.txtNombre.Text) = "" Then
            MsgBox("Ingrese el Nombre del Articulo", MsgBoxStyle.Information)
            Me.txtNombre.Focus()
            Me.txtNombre.SelectAll()
            Exit Sub
        End If

        If Me.cbLinea.SelectedValue = "%" Or Me.cbLinea.SelectedValue = Nothing Then
            linea = "0"
            grupo = "0"
            subgrupo = "0"
        Else
            linea = Me.cbLinea.SelectedValue
        End If
        If Me.cbGrupo.SelectedValue = "%" Or Me.cbGrupo.SelectedValue = Nothing Then
            grupo = "0"
            subgrupo = "0"
        Else
            grupo = Me.cbGrupo.SelectedValue
        End If

        If Me.cbSubGrupo.SelectedValue = "%" Or Me.cbSubGrupo.SelectedValue = Nothing Then
            subgrupo = "0"
        Else
            subgrupo = Me.cbSubGrupo.SelectedValue
        End If

        GruposCC.ArticulosCCEdit(Me.txtCodigo.Text, Me.cbProveedor.EditValue, _
            txtNombre.Text, linea, grupo, _
            subgrupo, txtModelo.Text, txtUnidad.Text, _
            txtPresentacion.Text, txtUbicacion.Text, txtCosto.Text, _
            txtCostoPromedio.Text, txtCostoUltimo.Text, txtStockMin.Text, _
            txtStockMax.Text, IIf(Me.cbCatalogo.EditValue Is Nothing, "", Me.cbCatalogo.EditValue), Me.ckExento.Checked)

        Me.Close()
    End Sub

    Private Sub Limpiar()
        r.LimpiarControles(GroupBox1)
        r.LimpiarControles(GroupBox9)
        r.LimpiarControles(GroupBox10)
        txtCodigo.Focus()
    End Sub

    Private Sub txtStockMin_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStockMin.Leave
        If Trim(Me.txtStockMin.Text) = "" Then
            Me.txtStockMin.Text = "0"
        End If
        If Not IsNumeric(Me.txtStockMin.Text) Then
            MsgBox("Ingrese un valor numérico", MsgBoxStyle.Information)
            Me.txtStockMin.Focus()
            Exit Sub
        Else
        End If
    End Sub

    Private Sub txtStockMax_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStockMax.Leave
        If Trim(Me.txtStockMax.Text) = "" Then
            Me.txtStockMax.Text = "0"
        End If
        If Not IsNumeric(Me.txtStockMax.Text) Then
            MsgBox("Ingrese un valor numérico", MsgBoxStyle.Information)
            Me.txtStockMax.Focus()
            Exit Sub
        Else
        End If
    End Sub

    Private Sub frmArticuloCCEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim f As frmArticulosCCList = f.Instance
        f.Cargar()
    End Sub

End Class
