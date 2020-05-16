<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturaManualAdd
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturaManualAdd))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bEnviar = New DevExpress.XtraBars.BarButtonItem()
        Me.bSalir = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtReferencia = New DevExpress.XtraEditors.TextEdit()
        Me.dFecha = New DevExpress.XtraEditors.DateEdit()
        Me.txtComentario = New DevExpress.XtraEditors.TextEdit()
        Me.txtAutorizacion = New DevExpress.XtraEditors.TextEdit()
        Me.txtOrdenCompra = New DevExpress.XtraEditors.TextEdit()
        Me.txtCliente = New DevExpress.XtraEditors.TextEdit()
        Me.txtPlaca = New DevExpress.XtraEditors.TextEdit()
        Me.txtOdometro = New DevExpress.XtraEditors.TextEdit()
        Me.cbFormaPago = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.txtTelefono = New DevExpress.XtraEditors.TextEdit()
        Me.txtCorreo = New DevExpress.XtraEditors.TextEdit()
        Me.mDireccion = New DevExpress.XtraEditors.MemoEdit()
        Me.cbBarrio = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtCedula = New DevExpress.XtraEditors.TextEdit()
        Me.cbDistrito = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtReceptor = New DevExpress.XtraEditors.TextEdit()
        Me.cbCanton = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbReceptores = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbProvincia = New DevExpress.XtraEditors.LookUpEdit()
        Me.iGrid = New DevExpress.XtraGrid.GridControl()
        Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbItemD = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rPrecio = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyGrupoReceptor = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtReferencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComentario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAutorizacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrdenCompra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlaca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOdometro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbFormaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCorreo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbBarrio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCedula.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDistrito.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReceptor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCanton.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbReceptores.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbProvincia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbItemD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyGrupoReceptor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ApplicationCaption = "Enviar Factura Electronica Manual"
        Me.RibbonControl.ApplicationIcon = CType(resources.GetObject("RibbonControl.ApplicationIcon"), System.Drawing.Bitmap)
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.bEnviar, Me.bSalir})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 3
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(890, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'bEnviar
        '
        Me.bEnviar.Caption = "&Enviar"
        Me.bEnviar.Id = 1
        Me.bEnviar.ImageOptions.Image = CType(resources.GetObject("bEnviar.ImageOptions.Image"), System.Drawing.Image)
        Me.bEnviar.ImageOptions.LargeImage = CType(resources.GetObject("bEnviar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bEnviar.Name = "bEnviar"
        '
        'bSalir
        '
        Me.bSalir.Caption = "&Salir"
        Me.bSalir.Id = 2
        Me.bSalir.ImageOptions.Image = CType(resources.GetObject("bSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.bSalir.ImageOptions.LargeImage = CType(resources.GetObject("bSalir.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bSalir.Name = "bSalir"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Incio"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bEnviar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bSalir)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 768)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(890, 31)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtReferencia)
        Me.LayoutControl1.Controls.Add(Me.dFecha)
        Me.LayoutControl1.Controls.Add(Me.txtComentario)
        Me.LayoutControl1.Controls.Add(Me.txtAutorizacion)
        Me.LayoutControl1.Controls.Add(Me.txtOrdenCompra)
        Me.LayoutControl1.Controls.Add(Me.txtCliente)
        Me.LayoutControl1.Controls.Add(Me.txtPlaca)
        Me.LayoutControl1.Controls.Add(Me.txtOdometro)
        Me.LayoutControl1.Controls.Add(Me.cbFormaPago)
        Me.LayoutControl1.Controls.Add(Me.RadioGroup1)
        Me.LayoutControl1.Controls.Add(Me.txtTelefono)
        Me.LayoutControl1.Controls.Add(Me.txtCorreo)
        Me.LayoutControl1.Controls.Add(Me.mDireccion)
        Me.LayoutControl1.Controls.Add(Me.cbBarrio)
        Me.LayoutControl1.Controls.Add(Me.txtCedula)
        Me.LayoutControl1.Controls.Add(Me.cbDistrito)
        Me.LayoutControl1.Controls.Add(Me.txtReceptor)
        Me.LayoutControl1.Controls.Add(Me.cbCanton)
        Me.LayoutControl1.Controls.Add(Me.cbReceptores)
        Me.LayoutControl1.Controls.Add(Me.cbProvincia)
        Me.LayoutControl1.Controls.Add(Me.iGrid)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 143)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(862, 412, 450, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(890, 625)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtReferencia
        '
        Me.txtReferencia.EditValue = ""
        Me.txtReferencia.Location = New System.Drawing.Point(642, 12)
        Me.txtReferencia.MenuManager = Me.RibbonControl
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtReferencia.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferencia.Properties.Appearance.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtReferencia.Properties.Appearance.Options.UseBackColor = True
        Me.txtReferencia.Properties.Appearance.Options.UseFont = True
        Me.txtReferencia.Properties.Appearance.Options.UseForeColor = True
        Me.txtReferencia.Properties.MaxLength = 20
        Me.txtReferencia.Size = New System.Drawing.Size(236, 22)
        Me.txtReferencia.StyleController = Me.LayoutControl1
        Me.txtReferencia.TabIndex = 12
        Me.txtReferencia.Tag = "True"
        '
        'dFecha
        '
        Me.dFecha.EditValue = Nothing
        Me.dFecha.Location = New System.Drawing.Point(114, 12)
        Me.dFecha.MenuManager = Me.RibbonControl
        Me.dFecha.Name = "dFecha"
        Me.dFecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dFecha.Properties.Appearance.Options.UseFont = True
        Me.dFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dFecha.Size = New System.Drawing.Size(119, 20)
        Me.dFecha.StyleController = Me.LayoutControl1
        Me.dFecha.TabIndex = 26
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(114, 305)
        Me.txtComentario.MenuManager = Me.RibbonControl
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComentario.Properties.Appearance.Options.UseFont = True
        Me.txtComentario.Properties.MaxLength = 160
        Me.txtComentario.Size = New System.Drawing.Size(764, 22)
        Me.txtComentario.StyleController = Me.LayoutControl1
        Me.txtComentario.TabIndex = 12
        Me.txtComentario.Tag = ""
        '
        'txtAutorizacion
        '
        Me.txtAutorizacion.Location = New System.Drawing.Point(716, 279)
        Me.txtAutorizacion.MenuManager = Me.RibbonControl
        Me.txtAutorizacion.Name = "txtAutorizacion"
        Me.txtAutorizacion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAutorizacion.Properties.Appearance.Options.UseFont = True
        Me.txtAutorizacion.Properties.MaxLength = 20
        Me.txtAutorizacion.Size = New System.Drawing.Size(162, 22)
        Me.txtAutorizacion.StyleController = Me.LayoutControl1
        Me.txtAutorizacion.TabIndex = 11
        Me.txtAutorizacion.Tag = ""
        '
        'txtOrdenCompra
        '
        Me.txtOrdenCompra.Location = New System.Drawing.Point(407, 279)
        Me.txtOrdenCompra.MenuManager = Me.RibbonControl
        Me.txtOrdenCompra.Name = "txtOrdenCompra"
        Me.txtOrdenCompra.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrdenCompra.Properties.Appearance.Options.UseFont = True
        Me.txtOrdenCompra.Properties.MaxLength = 20
        Me.txtOrdenCompra.Size = New System.Drawing.Size(203, 22)
        Me.txtOrdenCompra.StyleController = Me.LayoutControl1
        Me.txtOrdenCompra.TabIndex = 10
        Me.txtOrdenCompra.Tag = ""
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(114, 253)
        Me.txtCliente.MenuManager = Me.RibbonControl
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Properties.Appearance.Options.UseFont = True
        Me.txtCliente.Properties.MaxLength = 160
        Me.txtCliente.Size = New System.Drawing.Size(328, 22)
        Me.txtCliente.StyleController = Me.LayoutControl1
        Me.txtCliente.TabIndex = 10
        Me.txtCliente.Tag = ""
        '
        'txtPlaca
        '
        Me.txtPlaca.Location = New System.Drawing.Point(114, 279)
        Me.txtPlaca.MenuManager = Me.RibbonControl
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaca.Properties.Appearance.Options.UseFont = True
        Me.txtPlaca.Properties.MaxLength = 20
        Me.txtPlaca.Size = New System.Drawing.Size(187, 22)
        Me.txtPlaca.StyleController = Me.LayoutControl1
        Me.txtPlaca.TabIndex = 10
        Me.txtPlaca.Tag = ""
        '
        'txtOdometro
        '
        Me.txtOdometro.Location = New System.Drawing.Point(548, 253)
        Me.txtOdometro.MenuManager = Me.RibbonControl
        Me.txtOdometro.Name = "txtOdometro"
        Me.txtOdometro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOdometro.Properties.Appearance.Options.UseFont = True
        Me.txtOdometro.Properties.MaxLength = 50
        Me.txtOdometro.Size = New System.Drawing.Size(330, 22)
        Me.txtOdometro.StyleController = Me.LayoutControl1
        Me.txtOdometro.TabIndex = 9
        Me.txtOdometro.Tag = ""
        '
        'cbFormaPago
        '
        Me.cbFormaPago.Location = New System.Drawing.Point(114, 360)
        Me.cbFormaPago.MenuManager = Me.RibbonControl
        Me.cbFormaPago.Name = "cbFormaPago"
        Me.cbFormaPago.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFormaPago.Properties.Appearance.Options.UseFont = True
        Me.cbFormaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbFormaPago.Properties.View = Me.SearchLookUpEdit2View
        Me.cbFormaPago.Size = New System.Drawing.Size(764, 20)
        Me.cbFormaPago.StyleController = Me.LayoutControl1
        Me.cbFormaPago.TabIndex = 25
        '
        'SearchLookUpEdit2View
        '
        Me.SearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit2View.Name = "SearchLookUpEdit2View"
        Me.SearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'RadioGroup1
        '
        Me.RadioGroup1.EditValue = "01"
        Me.RadioGroup1.Location = New System.Drawing.Point(114, 331)
        Me.RadioGroup1.MenuManager = Me.RibbonControl
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioGroup1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioGroup1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioGroup1.Properties.Appearance.Options.UseBackColor = True
        Me.RadioGroup1.Properties.Appearance.Options.UseFont = True
        Me.RadioGroup1.Properties.Appearance.Options.UseForeColor = True
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("01", "CONTADO"), New DevExpress.XtraEditors.Controls.RadioGroupItem("02", "CREDITO")})
        Me.RadioGroup1.Size = New System.Drawing.Size(764, 25)
        Me.RadioGroup1.StyleController = Me.LayoutControl1
        Me.RadioGroup1.TabIndex = 24
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(720, 119)
        Me.txtTelefono.MenuManager = Me.RibbonControl
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Properties.Appearance.Options.UseFont = True
        Me.txtTelefono.Properties.Mask.BeepOnError = True
        Me.txtTelefono.Properties.Mask.EditMask = "f0"
        Me.txtTelefono.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTelefono.Properties.MaxLength = 10
        Me.txtTelefono.Size = New System.Drawing.Size(146, 22)
        Me.txtTelefono.StyleController = Me.LayoutControl1
        Me.txtTelefono.TabIndex = 11
        Me.txtTelefono.Tag = ""
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(126, 119)
        Me.txtCorreo.MenuManager = Me.RibbonControl
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Properties.Appearance.Options.UseFont = True
        Me.txtCorreo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtCorreo.Properties.Mask.BeepOnError = True
        Me.txtCorreo.Properties.MaxLength = 60
        Me.txtCorreo.Size = New System.Drawing.Size(488, 22)
        Me.txtCorreo.StyleController = Me.LayoutControl1
        Me.txtCorreo.TabIndex = 10
        Me.txtCorreo.Tag = ""
        '
        'mDireccion
        '
        Me.mDireccion.EditValue = ""
        Me.mDireccion.Location = New System.Drawing.Point(433, 161)
        Me.mDireccion.MenuManager = Me.RibbonControl
        Me.mDireccion.Name = "mDireccion"
        Me.mDireccion.Properties.MaxLength = 160
        Me.mDireccion.Size = New System.Drawing.Size(433, 76)
        Me.mDireccion.StyleController = Me.LayoutControl1
        Me.mDireccion.TabIndex = 15
        '
        'cbBarrio
        '
        Me.cbBarrio.Location = New System.Drawing.Point(126, 217)
        Me.cbBarrio.MenuManager = Me.RibbonControl
        Me.cbBarrio.Name = "cbBarrio"
        Me.cbBarrio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbBarrio.Size = New System.Drawing.Size(303, 20)
        Me.cbBarrio.StyleController = Me.LayoutControl1
        Me.cbBarrio.TabIndex = 23
        Me.cbBarrio.Tag = ""
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(720, 93)
        Me.txtCedula.MenuManager = Me.RibbonControl
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Properties.Appearance.Options.UseFont = True
        Me.txtCedula.Properties.MaxLength = 12
        Me.txtCedula.Size = New System.Drawing.Size(146, 22)
        Me.txtCedula.StyleController = Me.LayoutControl1
        Me.txtCedula.TabIndex = 9
        Me.txtCedula.Tag = ""
        '
        'cbDistrito
        '
        Me.cbDistrito.Location = New System.Drawing.Point(126, 193)
        Me.cbDistrito.MenuManager = Me.RibbonControl
        Me.cbDistrito.Name = "cbDistrito"
        Me.cbDistrito.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbDistrito.Size = New System.Drawing.Size(303, 20)
        Me.cbDistrito.StyleController = Me.LayoutControl1
        Me.cbDistrito.TabIndex = 22
        Me.cbDistrito.Tag = ""
        '
        'txtReceptor
        '
        Me.txtReceptor.Location = New System.Drawing.Point(126, 93)
        Me.txtReceptor.MenuManager = Me.RibbonControl
        Me.txtReceptor.Name = "txtReceptor"
        Me.txtReceptor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceptor.Properties.Appearance.Options.UseFont = True
        Me.txtReceptor.Properties.MaxLength = 80
        Me.txtReceptor.Size = New System.Drawing.Size(488, 22)
        Me.txtReceptor.StyleController = Me.LayoutControl1
        Me.txtReceptor.TabIndex = 8
        Me.txtReceptor.Tag = ""
        '
        'cbCanton
        '
        Me.cbCanton.Location = New System.Drawing.Point(126, 169)
        Me.cbCanton.MenuManager = Me.RibbonControl
        Me.cbCanton.Name = "cbCanton"
        Me.cbCanton.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCanton.Size = New System.Drawing.Size(303, 20)
        Me.cbCanton.StyleController = Me.LayoutControl1
        Me.cbCanton.TabIndex = 21
        Me.cbCanton.Tag = ""
        '
        'cbReceptores
        '
        Me.cbReceptores.Location = New System.Drawing.Point(126, 69)
        Me.cbReceptores.MenuManager = Me.RibbonControl
        Me.cbReceptores.Name = "cbReceptores"
        Me.cbReceptores.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbReceptores.Properties.Appearance.Options.UseFont = True
        Me.cbReceptores.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbReceptores.Properties.View = Me.SearchLookUpEdit1View
        Me.cbReceptores.Size = New System.Drawing.Size(740, 20)
        Me.cbReceptores.StyleController = Me.LayoutControl1
        Me.cbReceptores.TabIndex = 7
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'cbProvincia
        '
        Me.cbProvincia.Location = New System.Drawing.Point(126, 145)
        Me.cbProvincia.MenuManager = Me.RibbonControl
        Me.cbProvincia.Name = "cbProvincia"
        Me.cbProvincia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProvincia.Size = New System.Drawing.Size(303, 20)
        Me.cbProvincia.StyleController = Me.LayoutControl1
        Me.cbProvincia.TabIndex = 20
        Me.cbProvincia.Tag = ""
        '
        'iGrid
        '
        Me.iGrid.Location = New System.Drawing.Point(12, 384)
        Me.iGrid.MainView = Me.iVista
        Me.iGrid.MenuManager = Me.RibbonControl
        Me.iGrid.Name = "iGrid"
        Me.iGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rCantidad, Me.rPrecio, Me.cbItemD})
        Me.iGrid.Size = New System.Drawing.Size(866, 229)
        Me.iGrid.TabIndex = 5
        Me.iGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista})
        '
        'iVista
        '
        Me.iVista.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn1, Me.GridColumn10})
        Me.iVista.GridControl = Me.iGrid
        Me.iVista.Name = "iVista"
        Me.iVista.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.iVista.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.iVista.OptionsView.ShowAutoFilterRow = True
        Me.iVista.OptionsView.ShowChildrenInGroupPanel = True
        Me.iVista.OptionsView.ShowFooter = True
        Me.iVista.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Descripcion"
        Me.GridColumn2.ColumnEdit = Me.cbItemD
        Me.GridColumn2.FieldName = "Id"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 191
        '
        'cbItemD
        '
        Me.cbItemD.AutoHeight = False
        Me.cbItemD.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbItemD.Name = "cbItemD"
        Me.cbItemD.View = Me.RepositoryItemSearchLookUpEdit2View
        '
        'RepositoryItemSearchLookUpEdit2View
        '
        Me.RepositoryItemSearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit2View.Name = "RepositoryItemSearchLookUpEdit2View"
        Me.RepositoryItemSearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Cantidad"
        Me.GridColumn3.ColumnEdit = Me.rCantidad
        Me.GridColumn3.FieldName = "Cantidad"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 81
        '
        'rCantidad
        '
        Me.rCantidad.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rCantidad.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rCantidad.Appearance.ForeColor = System.Drawing.Color.OrangeRed
        Me.rCantidad.Appearance.Options.UseBackColor = True
        Me.rCantidad.Appearance.Options.UseFont = True
        Me.rCantidad.Appearance.Options.UseForeColor = True
        Me.rCantidad.Appearance.Options.UseTextOptions = True
        Me.rCantidad.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.rCantidad.AutoHeight = False
        Me.rCantidad.Mask.EditMask = "n5"
        Me.rCantidad.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rCantidad.Mask.UseMaskAsDisplayFormat = True
        Me.rCantidad.Name = "rCantidad"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Precio"
        Me.GridColumn4.ColumnEdit = Me.rPrecio
        Me.GridColumn4.FieldName = "Precio"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 81
        '
        'rPrecio
        '
        Me.rPrecio.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rPrecio.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rPrecio.Appearance.ForeColor = System.Drawing.Color.OrangeRed
        Me.rPrecio.Appearance.Options.UseBackColor = True
        Me.rPrecio.Appearance.Options.UseFont = True
        Me.rPrecio.Appearance.Options.UseForeColor = True
        Me.rPrecio.Appearance.Options.UseTextOptions = True
        Me.rPrecio.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.rPrecio.AutoHeight = False
        Me.rPrecio.Mask.EditMask = "n5"
        Me.rPrecio.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rPrecio.Mask.UseMaskAsDisplayFormat = True
        Me.rPrecio.Name = "rPrecio"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Impuesto"
        Me.GridColumn5.ColumnEdit = Me.rPrecio
        Me.GridColumn5.FieldName = "total_tax"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 81
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Neto"
        Me.GridColumn6.ColumnEdit = Me.rPrecio
        Me.GridColumn6.FieldName = "Neto"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Width = 81
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Total Linea"
        Me.GridColumn7.ColumnEdit = Me.rPrecio
        Me.GridColumn7.FieldName = "Linea_Monto"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.AllowFocus = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 4
        Me.GridColumn7.Width = 81
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Total Exento"
        Me.GridColumn8.ColumnEdit = Me.rPrecio
        Me.GridColumn8.FieldName = "Total_Exento"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Width = 81
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Total Grabado"
        Me.GridColumn9.ColumnEdit = Me.rPrecio
        Me.GridColumn9.FieldName = "Total_Grabado"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Width = 91
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Exento"
        Me.GridColumn1.FieldName = "Exento"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.AllowFocus = False
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Porcentaje"
        Me.GridColumn10.ColumnEdit = Me.rPrecio
        Me.GridColumn10.FieldName = "Porcentaje"
        Me.GridColumn10.Name = "GridColumn10"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.lyGrupoReceptor, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem16, Me.LayoutControlItem18, Me.LayoutControlItem20, Me.LayoutControlItem19, Me.LayoutControlItem17, Me.LayoutControlItem15, Me.LayoutControlItem23, Me.LayoutControlItem22, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(890, 625)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.iGrid
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 372)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(870, 233)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'lyGrupoReceptor
        '
        Me.lyGrupoReceptor.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lyGrupoReceptor.AppearanceGroup.ForeColor = System.Drawing.Color.OrangeRed
        Me.lyGrupoReceptor.AppearanceGroup.Options.UseFont = True
        Me.lyGrupoReceptor.AppearanceGroup.Options.UseForeColor = True
        Me.lyGrupoReceptor.ExpandButtonVisible = True
        Me.lyGrupoReceptor.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem4, Me.LayoutControlItem11, Me.LayoutControlItem5, Me.LayoutControlItem12})
        Me.lyGrupoReceptor.Location = New System.Drawing.Point(0, 26)
        Me.lyGrupoReceptor.Name = "lyGrupoReceptor"
        Me.lyGrupoReceptor.Size = New System.Drawing.Size(870, 215)
        Me.lyGrupoReceptor.Text = "Datos del Receptor"
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbReceptores
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(846, 24)
        Me.LayoutControlItem3.Text = "Buscar Receptor:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cbProvincia
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 76)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(409, 24)
        Me.LayoutControlItem6.Text = "Provincia:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cbCanton
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 100)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(409, 24)
        Me.LayoutControlItem7.Text = "Canton:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cbDistrito
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 124)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(409, 24)
        Me.LayoutControlItem8.Text = "Distrito:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cbBarrio
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 148)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(409, 24)
        Me.LayoutControlItem9.Text = "Barrio:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.mDireccion
        Me.LayoutControlItem10.Location = New System.Drawing.Point(409, 76)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(437, 96)
        Me.LayoutControlItem10.Text = "Dirección:"
        Me.LayoutControlItem10.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtReceptor
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(594, 26)
        Me.LayoutControlItem4.Text = "Nombre:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txtCorreo
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(594, 26)
        Me.LayoutControlItem11.Text = "Correo:"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtCedula
        Me.LayoutControlItem5.Location = New System.Drawing.Point(594, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(252, 26)
        Me.LayoutControlItem5.Text = "Cédula"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtTelefono
        Me.LayoutControlItem12.Location = New System.Drawing.Point(594, 50)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(252, 26)
        Me.LayoutControlItem12.Text = "Telefono:"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.RadioGroup1
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 319)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(0, 29)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(149, 29)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(870, 29)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.Text = "Condicion de Venta"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.cbFormaPago
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 348)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(870, 24)
        Me.LayoutControlItem14.Text = "Medio de Pago:"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.txtPlaca
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 267)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(293, 26)
        Me.LayoutControlItem16.Text = "Placa:"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.txtOrdenCompra
        Me.LayoutControlItem18.Location = New System.Drawing.Point(293, 267)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(309, 26)
        Me.LayoutControlItem18.Text = "Orden de Compra:"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.txtComentario
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 293)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(870, 26)
        Me.LayoutControlItem20.Text = "Comentario:"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.txtAutorizacion
        Me.LayoutControlItem19.Location = New System.Drawing.Point(602, 267)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(268, 26)
        Me.LayoutControlItem19.Text = "Autorización:"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.txtCliente
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 241)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(434, 26)
        Me.LayoutControlItem17.Text = "Cliente:"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.txtOdometro
        Me.LayoutControlItem15.Location = New System.Drawing.Point(434, 241)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(436, 26)
        Me.LayoutControlItem15.Text = "Odometro:"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem23.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem23.Control = Me.txtReferencia
        Me.LayoutControlItem23.Location = New System.Drawing.Point(528, 0)
        Me.LayoutControlItem23.MaxSize = New System.Drawing.Size(342, 26)
        Me.LayoutControlItem23.MinSize = New System.Drawing.Size(342, 26)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(342, 26)
        Me.LayoutControlItem23.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem23.Text = "No. Referencia:"
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(99, 16)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem22.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem22.Control = Me.dFecha
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem22.MaxSize = New System.Drawing.Size(225, 26)
        Me.LayoutControlItem22.MinSize = New System.Drawing.Size(225, 26)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(225, 26)
        Me.LayoutControlItem22.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem22.Text = "Fecha:"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(99, 14)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(225, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(303, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmFacturaManualAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 799)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmFacturaManualAdd"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Enviar Factura Electronica de Compra"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtReferencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComentario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAutorizacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrdenCompra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlaca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOdometro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbFormaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCorreo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbBarrio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCedula.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDistrito.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReceptor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCanton.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbReceptores.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbProvincia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbItemD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyGrupoReceptor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents bEnviar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bSalir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtCedula As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtReceptor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbReceptores As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbBarrio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbDistrito As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbCanton As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbProvincia As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents mDireccion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtCorreo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyGrupoReceptor As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtTelefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbFormaPago As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rCantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rPrecio As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cbItemD As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtPlaca As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOdometro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtComentario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAutorizacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOrdenCompra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtReferencia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
End Class
