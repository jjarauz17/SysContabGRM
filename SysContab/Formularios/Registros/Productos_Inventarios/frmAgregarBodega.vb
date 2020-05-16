Public Class frmAgregarBodega
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAgregarBodega = Nothing

    Public Shared Function Instance() As frmAgregarBodega
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarBodega()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Dim Encargado As String
    Dim Cod_Encargado As String
    Dim catalogo As New VB.SysContab.CatalogoDB()
    Dim Config As New VB.SysContab.ConfiguracionDetails()
    Friend WithEvents frmAgregarBodegaConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents chkExigir As System.Windows.Forms.CheckBox
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtCapacidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cbSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents txtGteMercadeo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtGteVentas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtGteSucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtTecnico As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkSinExistencia As System.Windows.Forms.CheckBox
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkAdvertencia As System.Windows.Forms.CheckBox
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Dim ConfigDB As New VB.SysContab.ConfiguracionDB()

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
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbEncargado As System.Windows.Forms.ComboBox
    Friend WithEvents txtUbicacion As System.Windows.Forms.TextBox
    Friend WithEvents cbCtaInventario As System.Windows.Forms.ComboBox
    Friend WithEvents chkDefault As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarBodega))
        Me.chkDefault = New System.Windows.Forms.CheckBox()
        Me.cbCtaInventario = New System.Windows.Forms.ComboBox()
        Me.cbEncargado = New System.Windows.Forms.ComboBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.frmAgregarBodegaConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.chkAdvertencia = New System.Windows.Forms.CheckBox()
        Me.chkSinExistencia = New System.Windows.Forms.CheckBox()
        Me.txtTecnico = New DevExpress.XtraEditors.TextEdit()
        Me.txtGteSucursal = New DevExpress.XtraEditors.TextEdit()
        Me.txtGteMercadeo = New DevExpress.XtraEditors.TextEdit()
        Me.txtGteVentas = New DevExpress.XtraEditors.TextEdit()
        Me.cbSucursal = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtCapacidad = New DevExpress.XtraEditors.TextEdit()
        Me.chkExigir = New System.Windows.Forms.CheckBox()
        Me.txtUbicacion = New System.Windows.Forms.TextBox()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.frmAgregarBodegaConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmAgregarBodegaConvertedLayout.SuspendLayout()
        CType(Me.txtTecnico.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGteSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGteMercadeo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGteVentas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCapacidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkDefault
        '
        Me.chkDefault.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDefault.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkDefault.Location = New System.Drawing.Point(24, 330)
        Me.chkDefault.Name = "chkDefault"
        Me.chkDefault.Size = New System.Drawing.Size(638, 20)
        Me.chkDefault.TabIndex = 17
        Me.chkDefault.Text = "Default Bodega"
        '
        'cbCtaInventario
        '
        Me.cbCtaInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCtaInventario.ItemHeight = 15
        Me.cbCtaInventario.Location = New System.Drawing.Point(162, 116)
        Me.cbCtaInventario.Name = "cbCtaInventario"
        Me.cbCtaInventario.Size = New System.Drawing.Size(500, 23)
        Me.cbCtaInventario.TabIndex = 13
        '
        'cbEncargado
        '
        Me.cbEncargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEncargado.ItemHeight = 15
        Me.cbEncargado.Location = New System.Drawing.Point(162, 91)
        Me.cbEncargado.Name = "cbEncargado"
        Me.cbEncargado.Size = New System.Drawing.Size(500, 23)
        Me.cbEncargado.TabIndex = 2
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(162, 43)
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(210, 20)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.Tag = "True"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(584, 460)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(90, 39)
        Me.cmdCancelar.StyleController = Me.frmAgregarBodegaConvertedLayout
        Me.cmdCancelar.TabIndex = 4
        Me.cmdCancelar.Text = "&Salir"
        '
        'frmAgregarBodegaConvertedLayout
        '
        Me.frmAgregarBodegaConvertedLayout.Controls.Add(Me.chkAdvertencia)
        Me.frmAgregarBodegaConvertedLayout.Controls.Add(Me.chkSinExistencia)
        Me.frmAgregarBodegaConvertedLayout.Controls.Add(Me.txtTecnico)
        Me.frmAgregarBodegaConvertedLayout.Controls.Add(Me.txtGteSucursal)
        Me.frmAgregarBodegaConvertedLayout.Controls.Add(Me.txtGteMercadeo)
        Me.frmAgregarBodegaConvertedLayout.Controls.Add(Me.txtGteVentas)
        Me.frmAgregarBodegaConvertedLayout.Controls.Add(Me.cbSucursal)
        Me.frmAgregarBodegaConvertedLayout.Controls.Add(Me.txtCapacidad)
        Me.frmAgregarBodegaConvertedLayout.Controls.Add(Me.chkExigir)
        Me.frmAgregarBodegaConvertedLayout.Controls.Add(Me.chkDefault)
        Me.frmAgregarBodegaConvertedLayout.Controls.Add(Me.cbCtaInventario)
        Me.frmAgregarBodegaConvertedLayout.Controls.Add(Me.cbEncargado)
        Me.frmAgregarBodegaConvertedLayout.Controls.Add(Me.txtCodigo)
        Me.frmAgregarBodegaConvertedLayout.Controls.Add(Me.txtUbicacion)
        Me.frmAgregarBodegaConvertedLayout.Controls.Add(Me.cmdAceptar)
        Me.frmAgregarBodegaConvertedLayout.Controls.Add(Me.cmdCancelar)
        Me.frmAgregarBodegaConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmAgregarBodegaConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.frmAgregarBodegaConvertedLayout.Name = "frmAgregarBodegaConvertedLayout"
        Me.frmAgregarBodegaConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(892, 166, 250, 350)
        Me.frmAgregarBodegaConvertedLayout.Root = Me.LayoutControlGroup1
        Me.frmAgregarBodegaConvertedLayout.Size = New System.Drawing.Size(686, 511)
        Me.frmAgregarBodegaConvertedLayout.TabIndex = 19
        '
        'chkAdvertencia
        '
        Me.chkAdvertencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAdvertencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkAdvertencia.Location = New System.Drawing.Point(345, 378)
        Me.chkAdvertencia.Name = "chkAdvertencia"
        Me.chkAdvertencia.Size = New System.Drawing.Size(317, 20)
        Me.chkAdvertencia.TabIndex = 22
        Me.chkAdvertencia.Text = "Advertencia Sin Existencias"
        '
        'chkSinExistencia
        '
        Me.chkSinExistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSinExistencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkSinExistencia.Location = New System.Drawing.Point(24, 378)
        Me.chkSinExistencia.Name = "chkSinExistencia"
        Me.chkSinExistencia.Size = New System.Drawing.Size(317, 20)
        Me.chkSinExistencia.TabIndex = 21
        Me.chkSinExistencia.Text = "Facturar Sin Existencias"
        '
        'txtTecnico
        '
        Me.txtTecnico.Location = New System.Drawing.Point(162, 263)
        Me.txtTecnico.Name = "txtTecnico"
        Me.txtTecnico.Size = New System.Drawing.Size(500, 20)
        Me.txtTecnico.StyleController = Me.frmAgregarBodegaConvertedLayout
        Me.txtTecnico.TabIndex = 30
        '
        'txtGteSucursal
        '
        Me.txtGteSucursal.Location = New System.Drawing.Point(162, 239)
        Me.txtGteSucursal.Name = "txtGteSucursal"
        Me.txtGteSucursal.Size = New System.Drawing.Size(500, 20)
        Me.txtGteSucursal.StyleController = Me.frmAgregarBodegaConvertedLayout
        Me.txtGteSucursal.TabIndex = 29
        '
        'txtGteMercadeo
        '
        Me.txtGteMercadeo.Location = New System.Drawing.Point(162, 215)
        Me.txtGteMercadeo.Name = "txtGteMercadeo"
        Me.txtGteMercadeo.Size = New System.Drawing.Size(500, 20)
        Me.txtGteMercadeo.StyleController = Me.frmAgregarBodegaConvertedLayout
        Me.txtGteMercadeo.TabIndex = 28
        '
        'txtGteVentas
        '
        Me.txtGteVentas.Location = New System.Drawing.Point(162, 191)
        Me.txtGteVentas.Name = "txtGteVentas"
        Me.txtGteVentas.Size = New System.Drawing.Size(500, 20)
        Me.txtGteVentas.StyleController = Me.frmAgregarBodegaConvertedLayout
        Me.txtGteVentas.TabIndex = 27
        '
        'cbSucursal
        '
        Me.cbSucursal.Location = New System.Drawing.Point(162, 165)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSucursal.Properties.Appearance.Options.UseFont = True
        Me.cbSucursal.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSucursal.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cbSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbSucursal.Properties.ShowFooter = False
        Me.cbSucursal.Properties.ShowHeader = False
        Me.cbSucursal.Size = New System.Drawing.Size(500, 22)
        Me.cbSucursal.StyleController = Me.frmAgregarBodegaConvertedLayout
        Me.cbSucursal.TabIndex = 26
        Me.cbSucursal.Tag = ""
        '
        'txtCapacidad
        '
        Me.txtCapacidad.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.txtCapacidad.Location = New System.Drawing.Point(162, 141)
        Me.txtCapacidad.Name = "txtCapacidad"
        Me.txtCapacidad.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapacidad.Properties.Appearance.Options.UseFont = True
        Me.txtCapacidad.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCapacidad.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCapacidad.Properties.Mask.EditMask = "n2"
        Me.txtCapacidad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCapacidad.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCapacidad.Size = New System.Drawing.Size(210, 20)
        Me.txtCapacidad.StyleController = Me.frmAgregarBodegaConvertedLayout
        Me.txtCapacidad.TabIndex = 21
        '
        'chkExigir
        '
        Me.chkExigir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkExigir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkExigir.Location = New System.Drawing.Point(24, 354)
        Me.chkExigir.Name = "chkExigir"
        Me.chkExigir.Size = New System.Drawing.Size(638, 20)
        Me.chkExigir.TabIndex = 20
        Me.chkExigir.Text = "Exigir en Facturación"
        '
        'txtUbicacion
        '
        Me.txtUbicacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUbicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbicacion.Location = New System.Drawing.Point(162, 67)
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(500, 20)
        Me.txtUbicacion.TabIndex = 1
        Me.txtUbicacion.Tag = "True"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.Location = New System.Drawing.Point(481, 460)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(99, 39)
        Me.cmdAceptar.StyleController = Me.frmAgregarBodegaConvertedLayout
        Me.cmdAceptar.TabIndex = 3
        Me.cmdAceptar.Text = "&Guardar"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlGroup3, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem1, Me.EmptySpaceItem4})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(686, 511)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlGroup2.CustomizationFormText = "Configuraciones"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem9, Me.LayoutControlItem15, Me.LayoutControlItem16})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 287)
        Me.LayoutControlGroup2.Name = "GroupBox2item"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(666, 115)
        Me.LayoutControlGroup2.Text = "Configuraciones"
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.chkDefault
        Me.LayoutControlItem3.CustomizationFormText = "chkDefaultitem"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "chkDefaultitem"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(642, 24)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.chkExigir
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(642, 24)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.chkSinExistencia
        Me.LayoutControlItem15.CustomizationFormText = "LayoutControlItem15"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(321, 24)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.chkAdvertencia
        Me.LayoutControlItem16.CustomizationFormText = "LayoutControlItem16"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(321, 48)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(321, 24)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup3.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup3.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup3.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlGroup3.CustomizationFormText = "Datos Generales"
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.LayoutControlItem10, Me.LayoutControlItem4, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "GroupBox1item"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(666, 287)
        Me.LayoutControlGroup3.Text = "Datos Generales"
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cbCtaInventario
        Me.LayoutControlItem5.CustomizationFormText = "Cuenta de Inventario:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 73)
        Me.LayoutControlItem5.Name = "cbCtaInventarioitem"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(642, 25)
        Me.LayoutControlItem5.Text = "Cuenta de Inventario:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(135, 14)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cbEncargado
        Me.LayoutControlItem6.CustomizationFormText = "Encargado:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem6.Name = "cbEncargadoitem"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(642, 25)
        Me.LayoutControlItem6.Text = "Encargado:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(135, 14)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtCodigo
        Me.LayoutControlItem7.CustomizationFormText = "Código:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem7.Name = "txtCodigoitem"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(352, 24)
        Me.LayoutControlItem7.Text = "Código:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(135, 14)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtUbicacion
        Me.LayoutControlItem8.CustomizationFormText = "Nombre:"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem8.Name = "txtUbicacionitem"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(642, 24)
        Me.LayoutControlItem8.Text = "Nombre:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(135, 14)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(352, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(290, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(352, 98)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(290, 24)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtCapacidad
        Me.LayoutControlItem10.CustomizationFormText = "Capacidad M3:"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 98)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(352, 24)
        Me.LayoutControlItem10.Text = "Capacidad M3:"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(135, 14)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cbSucursal
        Me.LayoutControlItem4.CustomizationFormText = "Sucursal:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 122)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(642, 26)
        Me.LayoutControlItem4.Text = "Sucursal:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(135, 14)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txtGteVentas
        Me.LayoutControlItem11.CustomizationFormText = "Gerente de Ventas:"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 148)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(642, 24)
        Me.LayoutControlItem11.Text = "Gerente de Ventas:"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(135, 14)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtGteMercadeo
        Me.LayoutControlItem12.CustomizationFormText = "Gerente de Mercadeo:"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 172)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(642, 24)
        Me.LayoutControlItem12.Text = "Gerente de Mercadeo:"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(135, 14)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtGteSucursal
        Me.LayoutControlItem13.CustomizationFormText = "Gerente de Sucursal:"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 196)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(642, 24)
        Me.LayoutControlItem13.Text = "Gerente de Sucursal:"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(135, 14)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtTecnico
        Me.LayoutControlItem14.CustomizationFormText = "Técnico:"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 220)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(642, 24)
        Me.LayoutControlItem14.Text = "Técnico:"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(135, 14)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cmdAceptar
        Me.LayoutControlItem1.CustomizationFormText = "cmdAceptaritem"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(469, 448)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(103, 43)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(103, 43)
        Me.LayoutControlItem1.Name = "cmdAceptaritem"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(103, 43)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmdCancelar
        Me.LayoutControlItem2.CustomizationFormText = "cmdCancelaritem"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(572, 448)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(94, 43)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(94, 43)
        Me.LayoutControlItem2.Name = "cmdCancelaritem"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(94, 43)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 448)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(469, 43)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 402)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(666, 46)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmAgregarBodega
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(686, 511)
        Me.Controls.Add(Me.frmAgregarBodegaConvertedLayout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAgregarBodega"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.frmAgregarBodegaConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmAgregarBodegaConvertedLayout.ResumeLayout(False)
        CType(Me.txtTecnico.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGteSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGteMercadeo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGteVentas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCapacidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Not DxValidationProvider1.Validate Then Exit Sub
        '
        Dim Bodega As New VB.SysContab.BodegasDB()
        Dim r As New VB.SysContab.Rutinas()

        'If Not IsNumeric(Me.txtCapacidad.Text) Then
        '    MsgBox("La capacidad volumetrica de la bodega debe ser expresada en metros cubicos", MsgBoxStyle.Critical, "STS-Contabilidad")
        '    Me.txtCapacidad.Text = "0.00"
        '    Exit Sub
        'End If

        If Trim(txtCodigo.Text) = "" Then
            XtraMsg("Introduzca el Código de la Bodega")
            txtCodigo.Focus()
            txtCodigo.SelectAll()
            Exit Sub

        End If

        If Trim(txtUbicacion.Text) = "" Then
            XtraMsg("Introduzca la Ubicación/Nombre de la Bodega")
            txtUbicacion.Focus()
            txtUbicacion.SelectAll()
            Exit Sub

        End If

        If Nuevo = "SI" Then
            Try
                Bodega.AddItem(txtCodigo.Text, txtUbicacion.Text, IsNull(cbEncargado.SelectedValue, cbEncargado.Text), _
                               Me.cbCtaInventario.SelectedValue, Me.txtCapacidad.EditValue, IIf(chkExigir.Checked, 1, 0), _
                               IIf(cbSucursal.EditValue Is Nothing, "", cbSucursal.EditValue), txtGteVentas.Text, _
                               txtGteMercadeo.Text, txtGteSucursal.Text, txtTecnico.Text, IIf(chkSinExistencia.Checked, 1, 0), _
                               IIf(chkAdvertencia.Checked, 1, 0))

                If Me.chkDefault.Checked Then
                    ConfigDB.UpdateBodegaDefault(Me.txtCodigo.Text)
                End If

                Close()
            Catch ex As Exception
                XtraMsg(ex.Message, MessageBoxIcon.Error)
                txtCodigo.Focus()
                Exit Sub
            End Try
            'MsgBox("El registro se ha grabado correctamente", MsgBoxStyle.Information)
            ''r.LimpiarControles(GroupBox1)
            'cbEncargado.SelectedValue = -1
            'txtCodigo.Focus()
        Else
            Bodega.Update(Registro, txtUbicacion.Text, IsNull(cbEncargado.SelectedValue, cbEncargado.Text), _
                          Me.cbCtaInventario.SelectedValue, Me.txtCapacidad.Text, IIf(chkExigir.Checked, 1, 0), _
                          IIf(cbSucursal.EditValue Is Nothing, "", cbSucursal.EditValue), txtGteVentas.Text, _
                          txtGteMercadeo.Text, txtGteSucursal.Text, txtTecnico.Text, IIf(chkSinExistencia.Checked, 1, 0), _
                          IIf(chkAdvertencia.Checked, 1, 0))
            If Me.chkDefault.Checked Then
                ConfigDB.UpdateBodegaDefault(Me.txtCodigo.Text)
            End If
            'MsgBox("El registro se ha actualizado correctamente", MsgBoxStyle.Information)
            Me.Close()
        End If

    End Sub

    Private Sub frmAgregarBodega_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)

        Dim Bodega As New VB.SysContab.BodegasDB()
        Dim Empleado As New VB.SysContab.EmpleadosDB()

        cbEncargado.DataSource = Empleado.GetListBuscarCombo("%").Tables("EMPLEADOS")
        cbEncargado.ValueMember = "Codigo"
        cbEncargado.DisplayMember = "Nombre"

        Me.cbCtaInventario.DataSource = catalogo.GetList_SPTipo256("A", 2).Tables("Catalogo")
        Me.cbCtaInventario.ValueMember = "CUENTA"
        Me.cbCtaInventario.DisplayMember = "NOMBRE"

        Combo(cbSucursal, ObtieneDatos("sp_GetSucursalesClientes " & EmpresaActual & ",1"))

        If Nuevo = "NO" Then
            Me.Text = "Editar Bodegas"
            txtCodigo.ReadOnly = True

            Dim Detalles As VB.SysContab.BodegasDetails = Bodega.GetDetails(Registro)
            txtCodigo.Text = Detalles.Codigo
            txtUbicacion.Text = Detalles.Ubicacion
            cbEncargado.SelectedValue = IIf(Detalles.Encargado Is DBNull.Value, "", Detalles.Encargado)
            Cod_Encargado = Detalles.Encargado
            cbCtaInventario.SelectedValue = Detalles.Cuenta_Inventario
            txtCapacidad.EditValue = Detalles.CapacidadM3
            chkExigir.Checked = Detalles.Exigir_Facturacion
            chkSinExistencia.Checked = Detalles.Fact_Sin_Existencia
            cbSucursal.EditValue = Detalles.Sucursal
            txtGteVentas.Text = Detalles.Gte_Ventas
            txtGteMercadeo.Text = Detalles.Gte_Mercadeo
            txtGteSucursal.Text = Detalles.Gte_Sucursal
            txtTecnico.Text = Detalles.Tecnico
            chkAdvertencia.Checked = Detalles.Advertencia

            Config = ConfigDB.GetConfigDetails()
            If Config.Bodega = Detalles.Codigo Then
                Me.chkDefault.Checked = True
            Else
                Me.chkDefault.Checked = False
            End If
            Me.txtUbicacion.Focus()

        Else
            Me.Text = "Agregar Bodegas"
        End If

        ' Me.Refresh()

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmAgregarBodega_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Dim r As New VB.SysContab.Rutinas()
        'Dim Bodegas As New VB.SysContab.BodegasDB()
        'Dim d As frmBodegas = d.Instance
        'Dim Tabla As New DataTable()
        'Dim ds As New DataSet()

        'ds = Bodegas.GetList()
        'd.dgBodegas.DataSource = Bodegas.GetList().Tables("Bodegas").DefaultView
        'Tabla = ds.Tables("Bodegas")

        'r.FormatGenerico(d.dgBodegas, Tabla)

        'If ds.Tables("Bodegas").Rows.Count <> 0 Then
        '    Registro = d.dgBodegas.Item(0, 0)
        'End If

    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
            If Char.IsDigit(e.KeyChar) = False Then
                e.Handled = True
                Exit Sub

            End If
        End If

    End Sub

    'Private Sub cbEncargado_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbEncargado.KeyPress
    '    Dim Emp As New VB.SysContab.EmpleadosDB()

    '    If Microsoft.VisualBasic.Asc(e.KeyChar) < 32 Then
    '        If Microsoft.VisualBasic.Asc(e.KeyChar) = 27 Then
    '            Encargado = ""
    '            cbEncargado.SelectAll()
    '            Exit Sub

    '        End If

    '        If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
    '            Exit Sub

    '        End If
    '    End If

    '    If cbEncargado.Text = "" Then
    '        Encargado = ""
    '        Exit Sub
    '    End If

    '    If Microsoft.VisualBasic.Asc(e.KeyChar) = 8 Then
    '        If Encargado.Length = 1 Then
    '            Encargado = ""
    '        End If

    '        If Encargado.Length > 1 Then
    '            Encargado = Mid(Encargado, 1, Encargado.Length - 1)
    '        End If

    '        If cbEncargado.Text = "" Then
    '            Encargado = ""
    '            Exit Sub

    '        End If

    '    Else
    '        Encargado = Encargado & e.KeyChar

    '    End If

    '    If Emp.GetListBuscarCombo(Encargado).Tables("EMPLEADOS").Rows.Count = 0 Then
    '        '

    '    Else
    '        cbEncargado.SelectedValue = Emp.GetListBuscarCombo(Encargado).Tables("EMPLEADOS").Rows(0).Item("Codigo")
    '        cbEncargado.SelectionStart = Encargado.Length
    '        cbEncargado.Select(Encargado.Length, cbEncargado.Text.Length)

    '    End If

    'End Sub

    'Private Sub cbEncargado_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEncargado.Leave
    '    Dim Emp As New VB.SysContab.EmpleadosDB()

    '    If Trim(cbEncargado.Text) = "" Then
    '        Encargado = ""
    '        Exit Sub
    '    End If

    '    If Emp.GetListBuscarCombo(cbEncargado.Text).Tables("EMPLEADOS").Rows.Count = 0 Then
    '        MsgBox("Empleado no Existe", MsgBoxStyle.Information)
    '        Encargado = ""
    '        cbEncargado.Focus()
    '        Exit Sub

    '    End If

    '    'cbEncargado.SelectedValue = z.GetListBuscarCombo(cbEncargado.Text).Tables("EncargadoS").Rows(0).Item("CODIGO")
    '    Cod_Encargado = Emp.GetListBuscarCombo(cbEncargado.Text).Tables("EMPLEADOS").Rows(0).Item("Codigo")

    '    Encargado = ""

    'End Sub

    'Private Sub cbEncargado_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEncargado.SelectedValueChanged
    'Encargado = ""

    'End Sub

    Private Sub txtCapacidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
