Public Class frmAgregarArticuloQuick
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
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAddAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents etTipo As System.Windows.Forms.Label
    Friend WithEvents txtMargen As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkexento As System.Windows.Forms.CheckBox
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbCuentas As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cbMoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtPrecio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtCosto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lbProvTemporal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents cbLinea As System.Windows.Forms.ComboBox
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbProveedores As DevExpress.XtraEditors.GridLookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarArticuloQuick))
        Me.cbCuentas = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.lbProvTemporal = New DevExpress.XtraEditors.LabelControl()
        Me.txtCosto = New DevExpress.XtraEditors.TextEdit()
        Me.txtPrecio = New DevExpress.XtraEditors.TextEdit()
        Me.cbMoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAddAll = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.chkexento = New System.Windows.Forms.CheckBox()
        Me.etTipo = New System.Windows.Forms.Label()
        Me.txtMargen = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.cbProveedores = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbGrupo = New System.Windows.Forms.ComboBox()
        Me.cbLinea = New System.Windows.Forms.ComboBox()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.cbCuentas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtCosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbProveedores.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbCuentas
        '
        Me.cbCuentas.Location = New System.Drawing.Point(73, 134)
        Me.cbCuentas.Name = "cbCuentas"
        Me.cbCuentas.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCuentas.Properties.Appearance.Options.UseFont = True
        Me.cbCuentas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCuentas.Properties.DisplayMember = "Display"
        Me.cbCuentas.Properties.NullText = ""
        Me.cbCuentas.Properties.PopupFormMinSize = New System.Drawing.Size(500, 0)
        Me.cbCuentas.Properties.ValueMember = "Cuenta"
        Me.cbCuentas.Properties.View = Me.GridLookUpEdit1View
        Me.cbCuentas.Size = New System.Drawing.Size(499, 20)
        Me.cbCuentas.StyleController = Me.LayoutControl1
        Me.cbCuentas.TabIndex = 3
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cuenta"
        Me.GridColumn1.FieldName = "Cuenta"
        Me.GridColumn1.MinWidth = 150
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 150
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Nombre"
        Me.GridColumn2.FieldName = "Nombre"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 231
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Display"
        Me.GridColumn3.FieldName = "Display"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cbGrupo)
        Me.LayoutControl1.Controls.Add(Me.cbLinea)
        Me.LayoutControl1.Controls.Add(Me.lbProvTemporal)
        Me.LayoutControl1.Controls.Add(Me.txtCosto)
        Me.LayoutControl1.Controls.Add(Me.txtPrecio)
        Me.LayoutControl1.Controls.Add(Me.cbMoneda)
        Me.LayoutControl1.Controls.Add(Me.cmdCancelar)
        Me.LayoutControl1.Controls.Add(Me.cbCuentas)
        Me.LayoutControl1.Controls.Add(Me.cmdAddAll)
        Me.LayoutControl1.Controls.Add(Me.cmdAceptar)
        Me.LayoutControl1.Controls.Add(Me.chkexento)
        Me.LayoutControl1.Controls.Add(Me.etTipo)
        Me.LayoutControl1.Controls.Add(Me.txtMargen)
        Me.LayoutControl1.Controls.Add(Me.txtCodigo)
        Me.LayoutControl1.Controls.Add(Me.txtNombre)
        Me.LayoutControl1.Controls.Add(Me.cbProveedores)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.LayoutControlItem6})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(691, 270, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(584, 274)
        Me.LayoutControl1.TabIndex = 27
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'lbProvTemporal
        '
        Me.lbProvTemporal.Location = New System.Drawing.Point(506, 158)
        Me.lbProvTemporal.Name = "lbProvTemporal"
        Me.lbProvTemporal.Size = New System.Drawing.Size(66, 13)
        Me.lbProvTemporal.StyleController = Me.LayoutControl1
        Me.lbProvTemporal.TabIndex = 148
        Me.lbProvTemporal.Text = "LabelControl1"
        '
        'txtCosto
        '
        Me.txtCosto.EditValue = 0.0R
        Me.txtCosto.Location = New System.Drawing.Point(326, 182)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCosto.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtCosto.Properties.Appearance.Options.UseFont = True
        Me.txtCosto.Properties.Appearance.Options.UseForeColor = True
        Me.txtCosto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCosto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCosto.Properties.Mask.EditMask = "n4"
        Me.txtCosto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCosto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCosto.Size = New System.Drawing.Size(246, 20)
        Me.txtCosto.StyleController = Me.LayoutControl1
        Me.txtCosto.TabIndex = 147
        '
        'txtPrecio
        '
        Me.txtPrecio.EditValue = 0.0R
        Me.txtPrecio.Location = New System.Drawing.Point(73, 182)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtPrecio.Properties.Appearance.Options.UseFont = True
        Me.txtPrecio.Properties.Appearance.Options.UseForeColor = True
        Me.txtPrecio.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPrecio.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPrecio.Properties.Mask.EditMask = "n4"
        Me.txtPrecio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrecio.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPrecio.Size = New System.Drawing.Size(188, 20)
        Me.txtPrecio.StyleController = Me.LayoutControl1
        Me.txtPrecio.TabIndex = 146
        '
        'cbMoneda
        '
        Me.cbMoneda.Location = New System.Drawing.Point(73, 158)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMoneda.Properties.NullText = "[Moneda]"
        Me.cbMoneda.Size = New System.Drawing.Size(406, 20)
        Me.cbMoneda.StyleController = Me.LayoutControl1
        Me.cbMoneda.TabIndex = 145
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Appearance.Options.UseForeColor = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(458, 224)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(114, 38)
        Me.cmdCancelar.StyleController = Me.LayoutControl1
        Me.cmdCancelar.TabIndex = 2
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAddAll
        '
        Me.cmdAddAll.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddAll.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdAddAll.Appearance.Options.UseFont = True
        Me.cmdAddAll.Appearance.Options.UseForeColor = True
        Me.cmdAddAll.Image = CType(resources.GetObject("cmdAddAll.Image"), System.Drawing.Image)
        Me.cmdAddAll.Location = New System.Drawing.Point(110, 224)
        Me.cmdAddAll.Name = "cmdAddAll"
        Me.cmdAddAll.Size = New System.Drawing.Size(175, 38)
        Me.cmdAddAll.StyleController = Me.LayoutControl1
        Me.cmdAddAll.TabIndex = 1
        Me.cmdAddAll.Text = "Agregar toda la información"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Appearance.Options.UseForeColor = True
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.Location = New System.Drawing.Point(12, 224)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(94, 38)
        Me.cmdAceptar.StyleController = Me.LayoutControl1
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Text = "&Guardar"
        '
        'chkexento
        '
        Me.chkexento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.chkexento.Location = New System.Drawing.Point(483, 158)
        Me.chkexento.Name = "chkexento"
        Me.chkexento.Size = New System.Drawing.Size(89, 20)
        Me.chkexento.TabIndex = 144
        Me.chkexento.Text = "Exento"
        '
        'etTipo
        '
        Me.etTipo.BackColor = System.Drawing.Color.Transparent
        Me.etTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etTipo.Location = New System.Drawing.Point(168, 36)
        Me.etTipo.Name = "etTipo"
        Me.etTipo.Size = New System.Drawing.Size(152, 20)
        Me.etTipo.TabIndex = 136
        Me.etTipo.Text = "Tipo"
        Me.etTipo.Visible = False
        '
        'txtMargen
        '
        Me.txtMargen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMargen.Location = New System.Drawing.Point(444, 12)
        Me.txtMargen.MaxLength = 13
        Me.txtMargen.Name = "txtMargen"
        Me.txtMargen.Size = New System.Drawing.Size(128, 20)
        Me.txtMargen.TabIndex = 5
        Me.txtMargen.Visible = False
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(73, 12)
        Me.txtCodigo.MaxLength = 20
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(227, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(73, 36)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(499, 20)
        Me.txtNombre.TabIndex = 1
        '
        'cbProveedores
        '
        Me.cbProveedores.Location = New System.Drawing.Point(73, 60)
        Me.cbProveedores.Name = "cbProveedores"
        Me.cbProveedores.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedores.Properties.Appearance.Options.UseFont = True
        Me.cbProveedores.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProveedores.Properties.DisplayMember = "Nombre"
        Me.cbProveedores.Properties.NullText = ""
        Me.cbProveedores.Properties.PopupFormMinSize = New System.Drawing.Size(500, 0)
        Me.cbProveedores.Properties.ValueMember = "Codigo"
        Me.cbProveedores.Properties.View = Me.GridView1
        Me.cbProveedores.Size = New System.Drawing.Size(499, 20)
        Me.cbProveedores.StyleController = Me.LayoutControl1
        Me.cbProveedores.TabIndex = 2
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn5})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Codigo"
        Me.GridColumn4.FieldName = "Codigo"
        Me.GridColumn4.MinWidth = 100
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 100
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Nombre"
        Me.GridColumn5.FieldName = "Nombre"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        Me.GridColumn5.Width = 281
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.etTipo
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(156, 24)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(156, 24)
        Me.LayoutControlItem8.Text = "LayoutControlItem8"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextToControlDistance = 0
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.lbProvTemporal
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(494, 146)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(70, 17)
        Me.LayoutControlItem6.Text = "LayoutControlItem6"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.LayoutControlItem12, Me.EmptySpaceItem1, Me.LayoutControlItem7, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem15, Me.LayoutControlItem16})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(584, 274)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtCodigo
        Me.LayoutControlItem1.CustomizationFormText = "Código:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(292, 24)
        Me.LayoutControlItem1.Text = "Código:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(58, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtMargen
        Me.LayoutControlItem2.CustomizationFormText = "Margen %:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(371, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(193, 24)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(193, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(193, 24)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Margen %:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(58, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtNombre
        Me.LayoutControlItem3.CustomizationFormText = "Descripción:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(564, 24)
        Me.LayoutControlItem3.Text = "Descripción:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(58, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cbProveedores
        Me.LayoutControlItem4.CustomizationFormText = "Proveedor:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(564, 24)
        Me.LayoutControlItem4.Text = "Proveedor:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(58, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cbCuentas
        Me.LayoutControlItem5.CustomizationFormText = "Cuenta:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 122)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(564, 24)
        Me.LayoutControlItem5.Text = "Cuenta:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(58, 13)
        Me.LayoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmdAceptar
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 212)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(98, 42)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(98, 42)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(98, 42)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.Text = "LayoutControlItem9"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextToControlDistance = 0
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cmdAddAll
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(98, 212)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(179, 42)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(179, 42)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(179, 42)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.Text = "LayoutControlItem10"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextToControlDistance = 0
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cmdCancelar
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(446, 212)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.Text = "LayoutControlItem11"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextToControlDistance = 0
        Me.LayoutControlItem11.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(292, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(79, 24)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(277, 212)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(169, 42)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cbMoneda
        Me.LayoutControlItem12.CustomizationFormText = "Moneda:"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 146)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(471, 24)
        Me.LayoutControlItem12.Text = "Moneda:"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(58, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 194)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(564, 18)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.chkexento
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(471, 146)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(93, 24)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(93, 24)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(93, 24)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "LayoutControlItem7"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextToControlDistance = 0
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtPrecio
        Me.LayoutControlItem13.CustomizationFormText = "Precio:"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 170)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(253, 24)
        Me.LayoutControlItem13.Text = "Precio:"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(58, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtCosto
        Me.LayoutControlItem14.CustomizationFormText = "Costo:"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(253, 170)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(311, 24)
        Me.LayoutControlItem14.Text = "Costo:"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(58, 13)
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(12, 424)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 61)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'cbGrupo
        '
        Me.cbGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGrupo.Location = New System.Drawing.Point(73, 109)
        Me.cbGrupo.Name = "cbGrupo"
        Me.cbGrupo.Size = New System.Drawing.Size(499, 21)
        Me.cbGrupo.TabIndex = 29
        '
        'cbLinea
        '
        Me.cbLinea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLinea.Location = New System.Drawing.Point(73, 84)
        Me.cbLinea.Name = "cbLinea"
        Me.cbLinea.Size = New System.Drawing.Size(499, 21)
        Me.cbLinea.TabIndex = 28
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.cbLinea
        Me.LayoutControlItem15.CustomizationFormText = "Linea:"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(564, 25)
        Me.LayoutControlItem15.Text = "Linea:"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(58, 13)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.cbGrupo
        Me.LayoutControlItem16.CustomizationFormText = "Grupo:"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 97)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(564, 25)
        Me.LayoutControlItem16.Text = "Grupo:"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(58, 13)
        '
        'frmAgregarArticuloQuick
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(584, 274)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAgregarArticuloQuick"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.cbCuentas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtCosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbProveedores.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Proveedores As New VB.SysContab.ProveedoresDB()
    Dim Articulos As New VB.SysContab.ArticulosDB
    Dim ArticulosCC As New VB.SysContab.GruposCCDB
    Dim r As New VB.SysContab.Rutinas
    Dim Proveedor As New VB.SysContab.ProveedoresDB()
    Dim Tipo As String
    Dim Cancelar As Boolean = False
    Dim CodigoP As String
    Public Nuevo As Boolean = True
    Public ifact As Integer
    Public ok As String = ""
    Public BodegaCaja As String
    Dim Grupos As New VB.SysContab.Grupos_InventarioDB

    Private Sub frmAgregarArticuloQuick_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.etTipo.Text = "P" Then
            Tipo = "Producto"
        Else
            Tipo = "Servicio"
        End If

        Me.Text = "*** Agregar Nuevo " & Tipo & " ***"

        txtCosto.Text = (0).ToString(RoundP)
        txtMargen.Text = (0).ToString(Round)

        GetMonedasList(cbMoneda)

        cbLinea.DataSource = Grupos.Lineas("P").Tables("GruposCC")
        cbLinea.ValueMember = "Código"
        cbLinea.DisplayMember = "Nombre"

        'cbProveedores.DataSource = Proveedor.ProveedoresList(3).Tables("PROVEEDORES")
        'cbProveedores.ValueMember = "Codigo"
        'cbProveedores.DisplayMember = "Nombre"
        'cbProveedores.SelectedValue = IIf(Me.lbProvTemporal.Text = "", 0, Me.lbProvTemporal.Text)
        'r.ComboAutoComplete(Me.cbProveedores)

        cbProveedores.Properties.DataSource = ObtieneDatos("SELECT Codigo, Nombre FROM Proveedores WHERE Tipo <> 4 AND Empresa =" & EmpresaActual).DefaultView
        Me.cbCuentas.Properties.DataSource = ObtieneDatos("SELECT Cuenta,Nombre,(cuenta + ' - ' + nombre) as Display FROM catalogo WHERE  Tipo = 'A' AND Empresa = " & EmpresaActual)

        Me.Refresh()
        Cancelar = True

        If Nuevo = False Then
            '-----------------------------------
            'CONDICION PARA LOS ARTICULOS DE INVENTARIO
            'Create By Jhonny Arauz
            '
            If Me.etTipo.Text = "I" Then    'PARA LOS PRODUCTOS DE INVENTARIO
                Me.txtMargen.Enabled = False
                Me.cmdAddAll.Visible = False

                Dim ds As DataSet = ArticulosCC.ArticulosCCDetalles(Me.txtCodigo.Text)

                Me.txtNombre.Text = ds.Tables(0).Rows(0).Item("Articulo_descripcion")
                Me.cbProveedores.EditValue = ds.Tables(0).Rows(0).Item("Proveedor_ID")
                Me.cbCuentas.EditValue = ds.Tables(0).Rows(0).Item("Cuenta")
                Me.txtCosto.Text = ds.Tables(0).Rows(0).Item("Articulo_costo")
                Try
                    Me.chkexento.Checked = CBool(ds.Tables(0).Rows(0).Item("exento"))
                Catch ex As Exception
                    Me.chkexento.Checked = False
                End Try
                '-------------------------------------

            Else    'PARA PRODUCTOS Y SERVICIOS
                Me.txtMargen.Enabled = True
                Me.cmdAddAll.Visible = True

                Dim A As VB.SysContab.ArticulosDetails = VB.SysContab.ArticulosDB.GetDetails(Me.txtCodigo.Text, Me.etTipo.Text)

                Me.txtNombre.Text = A.Nombre
                Me.txtCosto.Text = A.Costo
                Me.txtMargen.Text = A.Margen

                Me.chkexento.Checked = A.Exento
                Me.cbProveedores.EditValue = A.Proveedor
                Me.cbCuentas.EditValue = A.Cuenta

                If Me.etTipo.Text = "P" Then
                    Me.txtCosto.Enabled = False
                End If
            End If
        Else
            ' Label9.Visible = True
            txtMargen.Visible = True
        End If

        r.ComboAutoComplete(Me.cbLinea)
        r.ComboAutoComplete(Me.cbGrupo)
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        'If Trim(txtCodigo.Text) <> "" And Trim(txtNombre.Text) <> "" And Me.cbProveedores.EditValue <> Nothing _
        'And Me.cbCuentas.EditValue <> Nothing And Trim(txtCosto.Text) <> "" Then

        If Trim(txtCodigo.Text) = "" Then
            XtraMsg("Introduzca el Código del " & Tipo)
            txtCodigo.Focus()
            Exit Sub
        End If

        If Trim(txtNombre.Text) = "" Then
            XtraMsg("Introduzca el Nombre del " & Tipo)
            txtNombre.Focus()
            Exit Sub
        End If

        If Me.cbProveedores.EditValue Is Nothing Then
            XtraMsg("Seleccione el Proveedor")
            cbProveedores.Focus()
            Exit Sub
        End If

        'If Me.cbCuentas.EditValue Is Nothing Then
        '    MsgBox("Seleccione la Cuenta Contable", MsgBoxStyle.Information)
        '    Me.cbCuentas.Focus()
        '    Exit Sub
        'End If

        If Trim(txtCosto.Text) = "" Then
            XtraMsg("Introduzca el Costo del " & Tipo)
            txtCosto.Focus()
            Exit Sub
        End If

        If Me.cbLinea.SelectedValue = "%" And Me.cbLinea.Text.Length = 0 Then
            XtraMsg("Seleccione la Linea")
            cbLinea.Focus()
            Exit Sub
        End If

        If Me.cbGrupo.SelectedValue = "%" And Me.cbGrupo.Text.Length = 0 Then
            XtraMsg("Seleccione el Grupo")
            cbGrupo.Focus()
            Exit Sub
        End If

        GuardarQuick()
    End Sub

    Function GuardarQuick()

        Dim IVA As Integer, Precio As Double = 0
        If Me.chkexento.Checked = True Then IVA = 1
        If Me.chkexento.Checked = False Then IVA = 0

        If Me.Nuevo = True Then

            If Me.etTipo.Text = "I" Then    'INVENTARIO CONSUMIBLE
                If ArticulosCC.ArticulosCCDetalles(Me.txtCodigo.Text).Tables("Tabla").Rows.Count > 0 Then
                    XtraMsg("El código ya existe", MessageBoxIcon.Error)
                    Exit Function
                End If

                Try
                    ArticulosCC.ArticulosCCAddItem(Me.txtCodigo.Text, Me.cbProveedores.EditValue, Me.txtNombre.Text, 0, 0, 0, "", _
                                                   "", "", "", txtCosto.EditValue, txtCosto.EditValue, _
                                                   txtCosto.EditValue, 0, 0, "", IVA)

                    CodigoP = Me.txtCodigo.Text
                    Cancelar = False

                    ok = "SI"
                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Function
                End Try
            Else    'AGREGAR PRODUCTO O SERVICIO
                If Not (VB.SysContab.ArticulosDB.GetDetails(Me.txtCodigo.Text, etTipo.Text).Codigo Is Nothing) Then
                    XtraMsg("El código ya existe", MessageBoxIcon.Error)
                    Exit Function
                End If

                Try
                    ' Precio = (CDbl(txtCosto.Text) + (CDbl(txtCosto.Text) * CDbl(txtMargen.Text)) / 100.0).ToString(RoundP)
                    Precio = txtPrecio.EditValue

                    Articulos.AddItem(txtCodigo.Text, txtNombre.Text, cbProveedores.EditValue, cbLinea.SelectedValue, cbGrupo.SelectedValue, 0, 0, "", "", "", "", _
                                      Precio, 0, txtCosto.EditValue, _
                                      CDbl(txtMargen.Text).ToString(Round), txtCosto.EditValue, _
                                      txtCosto.EditValue, 0, 0, 0, 0, 0, 0, 0, 0, etTipo.Text, IVA, _
                                      IIf(cbCuentas.EditValue Is Nothing, "", cbCuentas.EditValue), "", "", "", "", cbMoneda.EditValue, "", 0)

                    Articulos.ItemTemporalAdd(txtCodigo.Text, "P" & PvCodigo)

                    If Tipo = "Producto" Then

                        Dim DetalleConfig As VB.SysContab.ConfiguracionDetails
                        DetalleConfig = VB.SysContab.ConfiguracionDB.GetConfigDetails()

                        Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())

                        Try
                            Conn.RemoveParameters()
                            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                            Conn.AddParameter("Bodega", SqlDbType.NVarChar, 10, ParameterDirection.Input, DetalleConfig.Bodega)
                            Conn.AddParameter("Articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, txtCodigo.Text)
                            Conn.AddParameter("Existencia", SqlDbType.Money, 20, ParameterDirection.Input, 0.0)
                            Conn.AddParameter("Costo", SqlDbType.Decimal, 20, ParameterDirection.Input, txtCosto.EditValue)
                            Conn.AddParameter("Articulo_Tipo", SqlDbType.NVarChar, 20, ParameterDirection.Input, "P")
                            Conn.EjecutarComando("SP_Bodega_Articulos_Add")
                        Catch ex As Exception
                        End Try
                        'VB.SysContab.BodegasDB.Bodega_Articulos_Add(BodegaCaja, txtCodigo.Text, 0, txtCosto.EditValue, "P")
                    End If

                    CodigoP = Me.txtCodigo.Text
                    Cancelar = False

                    ok = "SI"
                    Me.Close()
                Catch ex As Exception
                    XtraMsg(ex.Message, MessageBoxIcon.Error)
                    '' Exit Function
                End Try
            End If
        Else
            '---------------------------------
            'GUARDAR LOS ARTICULOS DE INVENTARIO
            'Create By Jhonny Arauz
            '
            If Me.etTipo.Text = "I" Then
                '--------------------------------
                ArticulosCC.ArticulosCCUpdate(Me.txtCodigo.Text, Me.txtNombre.Text, Me.cbProveedores.EditValue, _
                                              CDec(Me.txtCosto.Text), IVA, Me.cbCuentas.EditValue)
                CodigoP = Me.txtCodigo.Text
                ok = "SI"
                Me.Close()
                '---------------------------------
            Else
                Try
                    Dim A As VB.SysContab.ArticulosDetails = VB.SysContab.ArticulosDB.GetDetails(Me.txtCodigo.Text, Me.etTipo.Text)

                    Articulos.Update(txtCodigo.Text, txtNombre.Text, cbProveedores.EditValue, A.Linea, A.Grupo, A.SubGrupo, _
                        A.S_SubGrupo, A.Modelo, A.Unidad, A.Presentacion, A.Ubicacion, _
                         IIf(Me.etTipo.Text = "P", A.Precio_Venta_Cordobas, Me.txtCosto.Text), A.Precio_Venta_Dolar, _
                        Me.txtCosto.Text, A.Margen, A.Existencia, A.Stock_Min, A.Stock_Max, A.Descuento_A, A.Descuento_B, _
                        A.Descuento_C, A.Descuento_Maximo, A.Tasa_Cambio, IVA, Me.cbCuentas.EditValue, A.Concentracion, _
                        A.via_administracion, A.nivel_uso, A.receta, Me.etTipo.Text, MonedaBase, "", 0)
                    CodigoP = Me.txtCodigo.Text
                    ok = "SI"
                    Me.Close()
                Catch ex As Exception
                    XtraMsg(ex.Message, MessageBoxIcon.Error)
                    Exit Function
                End Try
            End If
        End If
    End Function

    Private Sub cmdAddAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddAll.Click
        Me.Close()

        ok = "SI"
        Dim f As frmAgregarArticulo = frmAgregarArticulo.Instance        
        Nuevo = True        
        f.StartPosition = FormStartPosition.CenterScreen
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        ok = "NO"
        'Indice = -1
        Cancelar = True
        Me.Close()
    End Sub

    Private Sub txtCosto_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        If Trim(txtCosto.Text) = "" Then
            txtCosto.Text = (0).ToString(RoundP)
        End If
        txtCosto.Text = CDbl(txtCosto.Text).ToString(RoundP)
    End Sub

    Private Sub txtMargen_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMargen.Leave
        If Trim(txtMargen.Text) = "" Then
            txtMargen.Text = (0).ToString(Round)
        End If
        txtMargen.Text = CDbl(txtMargen.Text).ToString(Round)
    End Sub

    'Private Sub cbProveedores_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Trim(cbProveedores.Text) = "" Then
    '        Exit Sub
    '    End If

    '    If Proveedores.ProveedoresBuscar(Trim(cbProveedores.Text)).Tables("Proveedores").Rows.Count = 0 Then
    '        cbProveedores.Text = cbProveedores.Text.ToUpper

    '        If (MsgBox("Proveedor no existe. Desea agregarlo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)) = MsgBoxResult.No Then
    '            Me.cbProveedores.Focus()
    '            Exit Sub
    '        Else
    '            Dim f As New frmAgregarProveedorQuick
    '            f.WindowState = FormWindowState.Normal
    '            f.StartPosition = FormStartPosition.CenterScreen

    '            f.txtNombre.Text = cbProveedores.Text.ToUpper
    '            cbProveedores.Text = cbProveedores.Text.ToUpper

    '            f.ShowDialog()

    '            cbProveedores.DataSource = Proveedores.ProveedoresList(3).Tables("Proveedores")
    '            cbProveedores.ValueMember = "Codigo"
    '            cbProveedores.DisplayMember = "Nombre"
    '            cbProveedores.SelectedValue = f.txtCodigo.Text
    '        End If
    '        Exit Sub
    '    End If

    '    cbProveedores.Refresh()

    'End Sub

    Private Sub frmAgregarArticuloQuick_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Cancelar = True Then
            'Indice = -1
        End If
        'Dim f As DataGridTextBoxCombo.frmFacturacionCliente = f.Instance

        Dim f1 As DataGridTextBoxCombo.frmOrdenesCompra = DataGridTextBoxCombo.frmOrdenesCompra.Instance
        Dim f2 As DataGridTextBoxCombo.frmFacturasPuntosVenta = DataGridTextBoxCombo.frmFacturasPuntosVenta.Instance

        'f.Codigo = Me.txtCodigo.Text
        f1.Codigo = Me.txtCodigo.Text
        f2.Codigo = Me.txtCodigo.Text
    End Sub

    Private Sub cbLinea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLinea.SelectedIndexChanged
        Try
            If Me.cbLinea.SelectedIndex > 0 Then
                cbGrupo.DataSource = Grupos.Grupos(Me.cbLinea.SelectedValue, "P").Tables("GruposCC")
                cbGrupo.ValueMember = "Código"
                cbGrupo.DisplayMember = "Nombre"
            End If         
        Catch ex As Exception
        End Try       
    End Sub
End Class
