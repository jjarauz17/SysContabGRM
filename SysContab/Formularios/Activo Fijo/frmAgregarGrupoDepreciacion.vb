Public Class frmAgregarGrupoDepreciacion
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAgregarGrupoDepreciacion = Nothing

    Public Shared Function Instance() As frmAgregarGrupoDepreciacion
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarGrupoDepreciacion()
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
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtVidaUtil As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtActivo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDepreciacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtGastos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
    Friend WithEvents cbPeriodo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents frmAgregarGrupoDepreciacionConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtPorcentaje As DevExpress.XtraEditors.SpinEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarGrupoDepreciacion))
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.frmAgregarGrupoDepreciacionConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.txtGastos = New DevExpress.XtraEditors.TextEdit()
        Me.txtDepreciacion = New DevExpress.XtraEditors.TextEdit()
        Me.txtActivo = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.txtPorcentaje = New DevExpress.XtraEditors.SpinEdit()
        Me.txtVidaUtil = New DevExpress.XtraEditors.SpinEdit()
        Me.cbPeriodo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmAgregarGrupoDepreciacionConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmAgregarGrupoDepreciacionConvertedLayout.SuspendLayout()
        CType(Me.txtGastos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepreciacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorcentaje.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVidaUtil.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbPeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(80, 12)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodigo.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Red
        Me.txtCodigo.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCodigo.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtCodigo.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCodigo.Size = New System.Drawing.Size(180, 20)
        Me.txtCodigo.StyleController = Me.frmAgregarGrupoDepreciacionConvertedLayout
        Me.txtCodigo.TabIndex = 16
        '
        'frmAgregarGrupoDepreciacionConvertedLayout
        '
        Me.frmAgregarGrupoDepreciacionConvertedLayout.Controls.Add(Me.SimpleButton2)
        Me.frmAgregarGrupoDepreciacionConvertedLayout.Controls.Add(Me.SimpleButton1)
        Me.frmAgregarGrupoDepreciacionConvertedLayout.Controls.Add(Me.txtGastos)
        Me.frmAgregarGrupoDepreciacionConvertedLayout.Controls.Add(Me.txtDepreciacion)
        Me.frmAgregarGrupoDepreciacionConvertedLayout.Controls.Add(Me.txtActivo)
        Me.frmAgregarGrupoDepreciacionConvertedLayout.Controls.Add(Me.txtCodigo)
        Me.frmAgregarGrupoDepreciacionConvertedLayout.Controls.Add(Me.txtNombre)
        Me.frmAgregarGrupoDepreciacionConvertedLayout.Controls.Add(Me.txtPorcentaje)
        Me.frmAgregarGrupoDepreciacionConvertedLayout.Controls.Add(Me.txtVidaUtil)
        Me.frmAgregarGrupoDepreciacionConvertedLayout.Controls.Add(Me.cbPeriodo)
        Me.frmAgregarGrupoDepreciacionConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmAgregarGrupoDepreciacionConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.frmAgregarGrupoDepreciacionConvertedLayout.Name = "frmAgregarGrupoDepreciacionConvertedLayout"
        Me.frmAgregarGrupoDepreciacionConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(614, 159, 450, 400)
        Me.frmAgregarGrupoDepreciacionConvertedLayout.Root = Me.LayoutControlGroup1
        Me.frmAgregarGrupoDepreciacionConvertedLayout.Size = New System.Drawing.Size(670, 406)
        Me.frmAgregarGrupoDepreciacionConvertedLayout.TabIndex = 29
        '
        'txtGastos
        '
        Me.txtGastos.Location = New System.Drawing.Point(80, 132)
        Me.txtGastos.Name = "txtGastos"
        Me.txtGastos.Properties.MaxLength = 50
        Me.txtGastos.Size = New System.Drawing.Size(578, 20)
        Me.txtGastos.StyleController = Me.frmAgregarGrupoDepreciacionConvertedLayout
        Me.txtGastos.TabIndex = 26
        Me.txtGastos.Visible = False
        '
        'txtDepreciacion
        '
        Me.txtDepreciacion.Location = New System.Drawing.Point(80, 108)
        Me.txtDepreciacion.Name = "txtDepreciacion"
        Me.txtDepreciacion.Properties.MaxLength = 50
        Me.txtDepreciacion.Size = New System.Drawing.Size(578, 20)
        Me.txtDepreciacion.StyleController = Me.frmAgregarGrupoDepreciacionConvertedLayout
        Me.txtDepreciacion.TabIndex = 24
        Me.txtDepreciacion.Visible = False
        '
        'txtActivo
        '
        Me.txtActivo.Location = New System.Drawing.Point(80, 84)
        Me.txtActivo.Name = "txtActivo"
        Me.txtActivo.Properties.MaxLength = 50
        Me.txtActivo.Size = New System.Drawing.Size(578, 20)
        Me.txtActivo.StyleController = Me.frmAgregarGrupoDepreciacionConvertedLayout
        Me.txtActivo.TabIndex = 22
        Me.txtActivo.Visible = False
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(80, 36)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.MaxLength = 50
        Me.txtNombre.Size = New System.Drawing.Size(578, 20)
        Me.txtNombre.StyleController = Me.frmAgregarGrupoDepreciacionConvertedLayout
        Me.txtNombre.TabIndex = 17
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPorcentaje.Location = New System.Drawing.Point(80, 156)
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtPorcentaje.Properties.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.txtPorcentaje.Size = New System.Drawing.Size(180, 20)
        Me.txtPorcentaje.StyleController = Me.frmAgregarGrupoDepreciacionConvertedLayout
        Me.txtPorcentaje.TabIndex = 19
        Me.txtPorcentaje.ToolTip = "Porcentaje Anual de Depreciación de un Activo"
        Me.txtPorcentaje.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.txtPorcentaje.ToolTipTitle = "Sts.Activos"
        Me.txtPorcentaje.Visible = False
        '
        'txtVidaUtil
        '
        Me.txtVidaUtil.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtVidaUtil.Location = New System.Drawing.Point(80, 60)
        Me.txtVidaUtil.Name = "txtVidaUtil"
        Me.txtVidaUtil.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtVidaUtil.Properties.IsFloatValue = False
        Me.txtVidaUtil.Properties.Mask.EditMask = "N00"
        Me.txtVidaUtil.Size = New System.Drawing.Size(180, 20)
        Me.txtVidaUtil.StyleController = Me.frmAgregarGrupoDepreciacionConvertedLayout
        Me.txtVidaUtil.TabIndex = 18
        Me.txtVidaUtil.ToolTip = "Valor correspondiente a los meses en los que se depreciará un activo."
        Me.txtVidaUtil.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.txtVidaUtil.ToolTipTitle = "Sts.Activos"
        '
        'cbPeriodo
        '
        Me.cbPeriodo.Location = New System.Drawing.Point(332, 60)
        Me.cbPeriodo.Name = "cbPeriodo"
        Me.cbPeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPeriodo.Properties.Items.AddRange(New Object() {"Años", "Meses"})
        Me.cbPeriodo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbPeriodo.Size = New System.Drawing.Size(326, 20)
        Me.cbPeriodo.StyleController = Me.frmAgregarGrupoDepreciacionConvertedLayout
        Me.cbPeriodo.TabIndex = 20
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(670, 406)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Root"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.LayoutControlItem10, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.EmptySpaceItem1, Me.EmptySpaceItem6})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "GroupControl1item"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(650, 386)
        Me.LayoutControlGroup2.Text = "Root"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtGastos
        Me.LayoutControlItem1.CustomizationFormText = "Gastos:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem1.Name = "txtGastositem"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(650, 24)
        Me.LayoutControlItem1.Text = "Gastos:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(65, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtDepreciacion
        Me.LayoutControlItem2.CustomizationFormText = "Depreciacion:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem2.Name = "txtDepreciacionitem"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(650, 24)
        Me.LayoutControlItem2.Text = "Depreciacion:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(65, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtActivo
        Me.LayoutControlItem3.CustomizationFormText = "Activo:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem3.Name = "txtActivoitem"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(650, 24)
        Me.LayoutControlItem3.Text = "Activo:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(65, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtCodigo
        Me.LayoutControlItem4.CustomizationFormText = "Código:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "txtCodigoitem"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(252, 24)
        Me.LayoutControlItem4.Text = "Código:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(65, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtNombre
        Me.LayoutControlItem5.CustomizationFormText = "Descripción:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem5.Name = "txtNombreitem"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(650, 24)
        Me.LayoutControlItem5.Text = "Descripción:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(65, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtPorcentaje
        Me.LayoutControlItem6.CustomizationFormText = "Porcentaje"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem6.Name = "txtPorcentajeitem"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(252, 24)
        Me.LayoutControlItem6.Text = "Porcentaje"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(65, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtVidaUtil
        Me.LayoutControlItem8.CustomizationFormText = "Vida Util"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem8.Name = "txtVidaUtilitem"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(252, 24)
        Me.LayoutControlItem8.Text = "Vida Util"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(65, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cbPeriodo
        Me.LayoutControlItem10.CustomizationFormText = "Periodo"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(252, 48)
        Me.LayoutControlItem10.Name = "cbPeriodoitem"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(398, 24)
        Me.LayoutControlItem10.Text = "Periodo"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(65, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(252, 144)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(398, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 168)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(650, 176)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 344)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(418, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(252, 0)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(398, 24)
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(546, 356)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(112, 38)
        Me.SimpleButton2.StyleController = Me.frmAgregarGrupoDepreciacionConvertedLayout
        Me.SimpleButton2.TabIndex = 30
        Me.SimpleButton2.Text = "&Salir"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(430, 356)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(112, 38)
        Me.SimpleButton1.StyleController = Me.frmAgregarGrupoDepreciacionConvertedLayout
        Me.SimpleButton1.TabIndex = 29
        Me.SimpleButton1.Text = "&Aceptar"
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.SimpleButton1
        Me.LayoutControlItem11.Location = New System.Drawing.Point(418, 344)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.SimpleButton2
        Me.LayoutControlItem12.Location = New System.Drawing.Point(534, 344)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'frmAgregarGrupoDepreciacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(670, 406)
        Me.Controls.Add(Me.frmAgregarGrupoDepreciacionConvertedLayout)
        Me.Name = "frmAgregarGrupoDepreciacion"
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmAgregarGrupoDepreciacionConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmAgregarGrupoDepreciacionConvertedLayout.ResumeLayout(False)
        CType(Me.txtGastos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepreciacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorcentaje.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVidaUtil.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbPeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAgregarGrupos_Depreciacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Grupos_Depreciacion As New VB.SysContab.Grupos_DepreciacionDB()

        txtCodigo.Properties.ReadOnly = True

        If Nuevo = "NO" Then
            Me.Text = "Editar Grupo de Depreciación"
            Dim Detalles As VB.SysContab.Grupos_DepreciacionDetails = Grupos_Depreciacion.GetDetails(Registro)
            Me.txtCodigo.Text = Detalles.Codigo
            Me.txtNombre.Text = Detalles.Descripcion
            Me.txtVidaUtil.Text = Detalles.Vida_Util
            Me.txtPorcentaje.Text = Detalles.Porcentaje
            Me.txtNombre.Focus()
            Me.txtActivo.Text = Detalles.Activo
            Me.txtDepreciacion.Text = Detalles.Depreciacion
            Me.txtGastos.Text = Detalles.Gastos
            Me.cbPeriodo.EditValue = IIf(Detalles.Periodo = "A", "Años", "Meses")

        Else
            Me.Text = "Agregar Grupo de Depreciación"
            txtCodigo.Text = VB.SysContab.Grupos_DepreciacionDB.GetCodigo()
        End If

        Me.Refresh()

    End Sub

    Private Sub frmAgregarGrupos_Depreciacion_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Dim r As New VB.SysContab.Rutinas()
        'Dim Grupos_Depreciacions As New VB.SysContab.Grupos_DepreciacionDB()
        Dim f As frmGruposDepreciacion = frmGruposDepreciacion.Instance
        f.Cargar()
        'Dim Tabla As New DataTable()
        'Dim ds As New DataSet()

        'ds = Grupos_Depreciacions.GetList()
        'd.dgGrupos_Depreciacion.DataSource = Grupos_Depreciacions.GetList().Tables("Grupos_Depreciacion").DefaultView
        'Tabla = ds.Tables("Grupos_Depreciacion")

        'r.FormatGenerico(d.dgGrupos_Depreciacion, Tabla)

        'If ds.Tables("Grupos_Depreciacion").Rows.Count <> 0 Then
        '    Registro = d.dgGrupos_Depreciacion.Item(0, 0)
        'End If

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Me.txtVidaUtil.EditValue < 0 Then
            XtraMsg("No puede ser menor que cero el valor de la vida util")
            Exit Sub
        End If

        If Trim(txtNombre.Text) = "" Then
            MsgBox("Introduzca la Descripción del Grupo de Depreciación", MsgBoxStyle.Information)
            txtNombre.Focus()
            txtNombre.SelectAll()
            Exit Sub

        End If

        If Nuevo = "SI" Then
            Try
                VB.SysContab.Grupos_DepreciacionDB.AddItem(txtCodigo.Text,
                    txtNombre.Text,
                    txtVidaUtil.Text,
                    txtPorcentaje.Text,
                    Me.cbPeriodo.EditValue.ToString.Substring(0, 1),
                    Me.txtActivo.Text,
                    Me.txtDepreciacion.Text,
                    Me.txtGastos.Text)
            Catch ex As Exception
                XtraMsg(ex.Message, MessageBoxIcon.Error)
                txtCodigo.Focus()
                Exit Sub
            End Try
        Else
            VB.SysContab.Grupos_DepreciacionDB.Update(Registro,
                txtNombre.Text,
                txtVidaUtil.Text,
                txtPorcentaje.Text,
                Me.cbPeriodo.EditValue.ToString.Substring(0, 1),
                Me.txtActivo.Text,
                Me.txtDepreciacion.Text,
                Me.txtGastos.Text)
        End If
        Me.Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dispose()
    End Sub
End Class
