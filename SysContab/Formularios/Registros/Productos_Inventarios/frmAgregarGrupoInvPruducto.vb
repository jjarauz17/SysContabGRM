Imports System.Text.RegularExpressions

Public Class frmAgregarGrupoInvPruducto
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAgregarGrupoInvPruducto = Nothing

    Public Shared Function Instance() As frmAgregarGrupoInvPruducto
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarGrupoInvPruducto()
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
    Friend WithEvents lbGruposSup As System.Windows.Forms.ListBox
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNivel As System.Windows.Forms.TextBox
    Friend WithEvents etNivel As System.Windows.Forms.Label
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtUtilidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lyUtilidad As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtDescVentas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lyVentas As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtDescGerencia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lyGerencia As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtUtilidadMaxima As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUtilidadMinima As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lyUtilidadMin As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyUtilidadMax As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarGrupoInvPruducto))
        Me.lbGruposSup = New System.Windows.Forms.ListBox()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtDescGerencia = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescVentas = New DevExpress.XtraEditors.TextEdit()
        Me.txtUtilidad = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.etNivel = New System.Windows.Forms.Label()
        Me.txtNivel = New System.Windows.Forms.TextBox()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lyUtilidad = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyVentas = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyGerencia = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.txtUtilidadMinima = New DevExpress.XtraEditors.TextEdit()
        Me.lyUtilidadMin = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtUtilidadMaxima = New DevExpress.XtraEditors.TextEdit()
        Me.lyUtilidadMax = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtDescGerencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescVentas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUtilidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyUtilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyGerencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUtilidadMinima.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyUtilidadMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUtilidadMaxima.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyUtilidadMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbGruposSup
        '
        Me.lbGruposSup.BackColor = System.Drawing.SystemColors.Control
        Me.lbGruposSup.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbGruposSup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGruposSup.ItemHeight = 16
        Me.lbGruposSup.Location = New System.Drawing.Point(12, 241)
        Me.lbGruposSup.Name = "lbGruposSup"
        Me.lbGruposSup.Size = New System.Drawing.Size(653, 112)
        Me.lbGruposSup.TabIndex = 11
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(558, 362)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(107, 38)
        Me.cmdCancelar.StyleController = Me.LayoutControl1
        Me.cmdCancelar.TabIndex = 4
        Me.cmdCancelar.Text = "&Salir"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtUtilidadMaxima)
        Me.LayoutControl1.Controls.Add(Me.txtUtilidadMinima)
        Me.LayoutControl1.Controls.Add(Me.txtDescGerencia)
        Me.LayoutControl1.Controls.Add(Me.txtDescVentas)
        Me.LayoutControl1.Controls.Add(Me.txtUtilidad)
        Me.LayoutControl1.Controls.Add(Me.txtNombre)
        Me.LayoutControl1.Controls.Add(Me.txtCodigo)
        Me.LayoutControl1.Controls.Add(Me.lbGruposSup)
        Me.LayoutControl1.Controls.Add(Me.cmdCancelar)
        Me.LayoutControl1.Controls.Add(Me.cmdAceptar)
        Me.LayoutControl1.Controls.Add(Me.etNivel)
        Me.LayoutControl1.Controls.Add(Me.txtNivel)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1011, 161, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(677, 412)
        Me.LayoutControl1.TabIndex = 6
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtDescGerencia
        '
        Me.txtDescGerencia.Location = New System.Drawing.Point(178, 168)
        Me.txtDescGerencia.Name = "txtDescGerencia"
        Me.txtDescGerencia.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescGerencia.Properties.Appearance.Options.UseFont = True
        Me.txtDescGerencia.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDescGerencia.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDescGerencia.Properties.Mask.EditMask = "p4"
        Me.txtDescGerencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDescGerencia.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDescGerencia.Size = New System.Drawing.Size(140, 22)
        Me.txtDescGerencia.StyleController = Me.LayoutControl1
        Me.txtDescGerencia.TabIndex = 9
        '
        'txtDescVentas
        '
        Me.txtDescVentas.Location = New System.Drawing.Point(178, 142)
        Me.txtDescVentas.Name = "txtDescVentas"
        Me.txtDescVentas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescVentas.Properties.Appearance.Options.UseFont = True
        Me.txtDescVentas.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDescVentas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDescVentas.Properties.Mask.EditMask = "p4"
        Me.txtDescVentas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDescVentas.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDescVentas.Size = New System.Drawing.Size(140, 22)
        Me.txtDescVentas.StyleController = Me.LayoutControl1
        Me.txtDescVentas.TabIndex = 8
        '
        'txtUtilidad
        '
        Me.txtUtilidad.Location = New System.Drawing.Point(178, 64)
        Me.txtUtilidad.Name = "txtUtilidad"
        Me.txtUtilidad.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUtilidad.Properties.Appearance.Options.UseFont = True
        Me.txtUtilidad.Properties.Appearance.Options.UseTextOptions = True
        Me.txtUtilidad.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtUtilidad.Properties.Mask.EditMask = "p4"
        Me.txtUtilidad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtUtilidad.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtUtilidad.Size = New System.Drawing.Size(140, 22)
        Me.txtUtilidad.StyleController = Me.LayoutControl1
        Me.txtUtilidad.TabIndex = 7
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(178, 38)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Properties.Appearance.Options.UseFont = True
        Me.txtNombre.Size = New System.Drawing.Size(487, 22)
        Me.txtNombre.StyleController = Me.LayoutControl1
        Me.txtNombre.TabIndex = 7
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(178, 12)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Properties.Appearance.Options.UseFont = True
        Me.txtCodigo.Size = New System.Drawing.Size(138, 22)
        Me.txtCodigo.StyleController = Me.LayoutControl1
        Me.txtCodigo.TabIndex = 4
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.Location = New System.Drawing.Point(446, 362)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(108, 38)
        Me.cmdAceptar.StyleController = Me.LayoutControl1
        Me.cmdAceptar.TabIndex = 3
        Me.cmdAceptar.Text = "&Guardar"
        '
        'etNivel
        '
        Me.etNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etNivel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etNivel.Location = New System.Drawing.Point(12, 194)
        Me.etNivel.Name = "etNivel"
        Me.etNivel.Size = New System.Drawing.Size(324, 20)
        Me.etNivel.TabIndex = 4
        Me.etNivel.Text = "Nivel de Cuentas en Informe:"
        Me.etNivel.Visible = False
        '
        'txtNivel
        '
        Me.txtNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNivel.Location = New System.Drawing.Point(340, 194)
        Me.txtNivel.MaxLength = 1
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.Size = New System.Drawing.Size(325, 20)
        Me.txtNivel.TabIndex = 2
        Me.txtNivel.Visible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.SimpleSeparator1, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.lyUtilidad, Me.lyVentas, Me.lyGerencia, Me.EmptySpaceItem4, Me.EmptySpaceItem3, Me.lyUtilidadMin, Me.lyUtilidadMax})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(677, 412)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtCodigo
        Me.LayoutControlItem1.CustomizationFormText = "Código:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(308, 26)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(308, 26)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(308, 26)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Código:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(163, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtNombre
        Me.LayoutControlItem2.CustomizationFormText = "Nombre:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(657, 26)
        Me.LayoutControlItem2.Text = "Nombre:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(163, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtNivel
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(328, 182)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(329, 24)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        Me.LayoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.etNivel
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 182)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(328, 24)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        Me.LayoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem5.Control = Me.lbGruposSup
        Me.LayoutControlItem5.CustomizationFormText = "Grupos Superiores"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 208)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(657, 142)
        Me.LayoutControlItem5.Text = "Grupos Superiores"
        Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(163, 18)
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.AllowHotTrack = False
        Me.SimpleSeparator1.CustomizationFormText = "SimpleSeparator1"
        Me.SimpleSeparator1.Location = New System.Drawing.Point(0, 206)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(657, 2)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cmdAceptar
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(434, 350)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cmdCancelar
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(546, 350)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 350)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(434, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(308, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(349, 26)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'lyUtilidad
        '
        Me.lyUtilidad.Control = Me.txtUtilidad
        Me.lyUtilidad.CustomizationFormText = "Utilidad:"
        Me.lyUtilidad.Location = New System.Drawing.Point(0, 52)
        Me.lyUtilidad.MaxSize = New System.Drawing.Size(310, 26)
        Me.lyUtilidad.MinSize = New System.Drawing.Size(310, 26)
        Me.lyUtilidad.Name = "lyUtilidad"
        Me.lyUtilidad.Size = New System.Drawing.Size(310, 26)
        Me.lyUtilidad.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lyUtilidad.Text = "Utilidad %:"
        Me.lyUtilidad.TextSize = New System.Drawing.Size(163, 13)
        Me.lyUtilidad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'lyVentas
        '
        Me.lyVentas.Control = Me.txtDescVentas
        Me.lyVentas.CustomizationFormText = "Descuento Ventas:"
        Me.lyVentas.Location = New System.Drawing.Point(0, 130)
        Me.lyVentas.MaxSize = New System.Drawing.Size(310, 26)
        Me.lyVentas.MinSize = New System.Drawing.Size(310, 26)
        Me.lyVentas.Name = "lyVentas"
        Me.lyVentas.Size = New System.Drawing.Size(310, 26)
        Me.lyVentas.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lyVentas.Text = "Descuento Ventas %:"
        Me.lyVentas.TextSize = New System.Drawing.Size(163, 13)
        Me.lyVentas.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'lyGerencia
        '
        Me.lyGerencia.Control = Me.txtDescGerencia
        Me.lyGerencia.CustomizationFormText = "Descuento Gerencia Comercial:"
        Me.lyGerencia.Location = New System.Drawing.Point(0, 156)
        Me.lyGerencia.MaxSize = New System.Drawing.Size(310, 26)
        Me.lyGerencia.MinSize = New System.Drawing.Size(310, 26)
        Me.lyGerencia.Name = "lyGerencia"
        Me.lyGerencia.Size = New System.Drawing.Size(310, 26)
        Me.lyGerencia.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lyGerencia.Text = "Descuento Gerencia Comercial %:"
        Me.lyGerencia.TextSize = New System.Drawing.Size(163, 13)
        Me.lyGerencia.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(310, 52)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(347, 104)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(310, 156)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(347, 26)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'txtUtilidadMinima
        '
        Me.txtUtilidadMinima.Location = New System.Drawing.Point(178, 90)
        Me.txtUtilidadMinima.Name = "txtUtilidadMinima"
        Me.txtUtilidadMinima.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUtilidadMinima.Properties.Appearance.Options.UseFont = True
        Me.txtUtilidadMinima.Properties.Appearance.Options.UseTextOptions = True
        Me.txtUtilidadMinima.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtUtilidadMinima.Properties.Mask.EditMask = "p4"
        Me.txtUtilidadMinima.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtUtilidadMinima.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtUtilidadMinima.Size = New System.Drawing.Size(140, 22)
        Me.txtUtilidadMinima.StyleController = Me.LayoutControl1
        Me.txtUtilidadMinima.TabIndex = 8
        '
        'lyUtilidadMin
        '
        Me.lyUtilidadMin.Control = Me.txtUtilidadMinima
        Me.lyUtilidadMin.Location = New System.Drawing.Point(0, 78)
        Me.lyUtilidadMin.Name = "lyUtilidadMin"
        Me.lyUtilidadMin.Size = New System.Drawing.Size(310, 26)
        Me.lyUtilidadMin.Text = "Utilidad Mínima %:"
        Me.lyUtilidadMin.TextSize = New System.Drawing.Size(163, 13)
        Me.lyUtilidadMin.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'txtUtilidadMaxima
        '
        Me.txtUtilidadMaxima.Location = New System.Drawing.Point(178, 116)
        Me.txtUtilidadMaxima.Name = "txtUtilidadMaxima"
        Me.txtUtilidadMaxima.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUtilidadMaxima.Properties.Appearance.Options.UseFont = True
        Me.txtUtilidadMaxima.Properties.Appearance.Options.UseTextOptions = True
        Me.txtUtilidadMaxima.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtUtilidadMaxima.Properties.Mask.EditMask = "p4"
        Me.txtUtilidadMaxima.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtUtilidadMaxima.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtUtilidadMaxima.Size = New System.Drawing.Size(140, 22)
        Me.txtUtilidadMaxima.StyleController = Me.LayoutControl1
        Me.txtUtilidadMaxima.TabIndex = 8
        '
        'lyUtilidadMax
        '
        Me.lyUtilidadMax.Control = Me.txtUtilidadMaxima
        Me.lyUtilidadMax.Location = New System.Drawing.Point(0, 104)
        Me.lyUtilidadMax.Name = "lyUtilidadMax"
        Me.lyUtilidadMax.Size = New System.Drawing.Size(310, 26)
        Me.lyUtilidadMax.Text = "Utilidad Máxima %:"
        Me.lyUtilidadMax.TextSize = New System.Drawing.Size(163, 13)
        Me.lyUtilidadMax.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'frmAgregarGrupoInvPruducto
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(677, 412)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmAgregarGrupoInvPruducto"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtDescGerencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescVentas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUtilidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyUtilidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyGerencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUtilidadMinima.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyUtilidadMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUtilidadMaxima.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyUtilidadMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Nivel As Integer

    Dim gruposInv As New VB.SysContab.Grupos_InventarioDB()
    Dim r As New VB.SysContab.Rutinas()

    Private Sub frmAgregarGrupoInvPruducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'r.CambiarEstilo(Me)

        Me.Text = "Editar Grupo de Productos"
        Me.Refresh()

        'GroupBox1.Top = Me.Height / 12
        'GroupBox1.Left = Me.Height / 4

        If Nuevo = "NO" Then
            txtCodigo.Properties.ReadOnly = True
            Dim Detalles As VB.SysContab.Grupos_InventarioDetails = gruposInv.GetDetails(Registro, TipoGrupoInv)

            txtCodigo.Text = Detalles.Codigo
            txtNombre.Text = Detalles.Nombre
            txtUtilidad.EditValue = Detalles.Utilidad
            txtUtilidadMinima.EditValue = Detalles.Utilidad_Minima
            txtUtilidadMaxima.EditValue = Detalles.Utilidad_Maxima
            txtDescVentas.EditValue = Detalles.Descuento_Ventas
            txtDescGerencia.EditValue = Detalles.Descuento_Comercial

            Dim g As New VB.SysContab.Grupos_InventarioDB()
            Dim longitud As Integer
            Dim i As Integer

            'longitud = txtCodigo.Text.Length
            longitud = Registro.Length

            If longitud = 1 Then
                Exit Sub
            Else
                lbGruposSup.Items.Clear()
                For i = 0 To longitud - 2
                    If g.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), TipoGrupoInv).Tables("Grupos_Inventario").Rows.Count <> 0 Then
                        lbGruposSup.Items.Add(g.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), TipoGrupoInv).Tables("Grupos_Inventario").Rows(0).Item("Codigo_Grupo") & " - " & g.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), TipoGrupoInv).Tables("Grupos_Inventario").Rows(0).Item("Nombre"))
                    End If

                Next

                If lbGruposSup.Items.Count <> 0 Then
                    '  etGruposSup.Visible = True
                    lbGruposSup.Visible = True
                End If
            End If

            If lbGruposSup.Items.Count >= 2 Then
                lyUtilidad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                lyUtilidadMin.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                lyUtilidadMax.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                lyGerencia.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                lyVentas.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Else
                lyUtilidad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                lyUtilidadMin.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                lyUtilidadMax.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                lyGerencia.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                lyVentas.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            End If
        End If
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        If Trim(txtCodigo.Text) = "" Then
            XtraMsg("Introduzca el Código del Grupo")
            txtCodigo.Focus()
            txtCodigo.SelectAll()
            Exit Sub
        End If

        If Trim(txtNombre.Text) = "" Then
            XtraMsg("Introduzca el Nombre del Grupo")
            txtNombre.Focus()
            txtNombre.SelectAll()
            Exit Sub
        End If

        If lbGruposSup.Items.Count = 0 Then
            Nivel = 1
        ElseIf lbGruposSup.Items.Count = 1 Then
            Nivel = 2
        ElseIf lbGruposSup.Items.Count = 2 Then
            Nivel = 3
        ElseIf Me.lbGruposSup.Items.Count = 3 Then
            Nivel = 4
        End If

        If Nuevo = "SI" Then
            gruposInv.AddItem(txtCodigo.Text, txtNombre.Text, "P", Nivel, 0.0, 0.0, _
                              IIf(Nivel <> 3, 0.0, txtUtilidad.EditValue), _
                              IIf(Nivel <> 3, 0.0, txtDescVentas.EditValue), _
                              IIf(Nivel <> 3, 0.0, txtDescGerencia.EditValue), _
                              IIf(Nivel <> 3, 0.0, txtUtilidadMinima.EditValue), _
                              IIf(Nivel <> 3, 0.0, txtUtilidadMaxima.EditValue))

            'MsgBox("El registro se ha grabado correctamente", MsgBoxStyle.Information)
            'r.LimpiarControles(GroupBox1)

            LimpiarControles(LayoutControl1)
            txtCodigo.Focus()
        Else
            gruposInv.Update(txtCodigo.Text, txtNombre.Text, "P", 0.0, 0.0, _
                             IIf(Nivel <> 3, 0.0, txtUtilidad.EditValue), _
                             IIf(Nivel <> 3, 0.0, txtDescVentas.EditValue), _
                             IIf(Nivel <> 3, 0.0, txtDescGerencia.EditValue), _
                             IIf(Nivel <> 3, 0.0, txtUtilidadMinima.EditValue), _
                              IIf(Nivel <> 3, 0.0, txtUtilidadMaxima.EditValue))
            'MsgBox("El registro se ha actualizado correctamente", MsgBoxStyle.Information)
            Me.Close()
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmAgregarGrupoInvPruducto_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Dim GruposInv As New VB.SysContab.Grupos_InventarioDB
        'Dim r As New VB.SysContab.Rutinas
        Dim grupoInv As frmGruposInventarios = frmGruposInventarios.Instance()
        grupoInv.Cargar(TipoGrupoInv)
        'Dim Tabla As New DataTable
        'Dim ds As New DataSet

        'ds = GruposInv.GetList(TipoGrupoInv)

        'grupoInv.dgGruposInventario.DataSource = GruposInv.GetList(TipoGrupoInv).Tables("GRUPOS_INVENTARIO").DefaultView
        'Tabla = ds.Tables("GRUPOS_INVENTARIO")

        'r.FormatGenerico(grupoInv.dgGruposInventario, Tabla)

        'If ds.Tables("GRUPOS_INVENTARIO").Rows.Count <> 0 Then
        '    Registro = grupoInv.dgGruposInventario.Item(0, 0)
        'End If

    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'lbGruposSup.Items.Clear()
        'lbGruposSup.Visible = False
        'etGruposSup.Visible = False

        '''Dim codigo As New Regex("\d{1}", RegexOptions.IgnoreCase)
        ''Dim codigo As New Regex("^[+]?\d*$", RegexOptions.IgnoreCase)

        ''If Not codigo.IsMatch(txtCodigo.Text) Then
        ''    'txtCodigo.ResetText()
        ''    'If txtCodigo.Text.Length = 1 Then
        ''    '    txtCodigo.Text = ""
        ''    'Else
        ''    '    txtCodigo.Text = Mid(txtCodigo.Text, txtCodigo.Text.Length - 1)
        ''    'End If

        ''End If

    End Sub

    Private Sub txtCodigo_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
            If Char.IsDigit(e.KeyChar) = False Then
                e.Handled = True
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtCodigo_TextChanged1(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        lbGruposSup.Items.Clear()
        lbGruposSup.Visible = False        
    End Sub

    Private Sub txtCodigo_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
       

    End Sub

    'Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
    '        If Char.IsDigit(e.KeyChar) = False Then
    '            e.Handled = True
    '            Exit Sub
    '        End If
    '    End If
    'End Sub

    Private Sub txtCodigo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCodigo.Validating
        Dim g As New VB.SysContab.Grupos_InventarioDB
        Dim longitud As Integer
        Dim i As Integer

        If Nuevo = "NO" Then
            Exit Sub
        End If

        If Trim(txtCodigo.Text) <> "" Then
            longitud = txtCodigo.Text.Length
            g.GetListCodigo(txtCodigo.Text, TipoGrupoInv)

            If longitud = 1 Then
                If g.GetListCodigo(txtCodigo.Text, TipoGrupoInv).Tables("Grupos_INVENTARIO").Rows.Count <> 0 Then
                    XtraMsg("Código de Grupo ya existe", MessageBoxIcon.Error)
                    txtCodigo.Focus()
                    Exit Sub
                End If
            Else
                If g.GetListCodigo(txtCodigo.Text, TipoGrupoInv).Tables("Grupos_Inventario").Rows.Count <> 0 Then
                    XtraMsg("Código de Grupo ya existe", MessageBoxIcon.Error)
                    txtCodigo.Focus()
                    Exit Sub
                End If

                lbGruposSup.Items.Clear()
                For i = 0 To longitud - 2
                    If g.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), TipoGrupoInv).Tables("Grupos_Inventario").Rows.Count <> 0 Then
                        lbGruposSup.Items.Add(g.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), TipoGrupoInv).Tables("Grupos_Inventario").Rows(0).Item("Codigo_Grupo") & " - " & g.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), TipoGrupoInv).Tables("Grupos_Inventario").Rows(0).Item("Nombre"))
                    End If
                Next

                If lbGruposSup.Items.Count <> 0 Then
                    ' etGruposSup.Visible = True
                    lbGruposSup.Visible = True
                End If

                If lbGruposSup.Items.Count = 3 Then
                    lyUtilidad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    lyUtilidadMin.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    lyUtilidadMax.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    lyGerencia.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    lyVentas.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                Else
                    lyUtilidad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    lyUtilidadMin.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    lyUtilidadMax.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    lyGerencia.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    lyVentas.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                End If

            End If
        End If
    End Sub
End Class