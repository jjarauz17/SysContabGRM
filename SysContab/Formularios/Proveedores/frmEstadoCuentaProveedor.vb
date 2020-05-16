
Public Class frmEstadoCuentaProveedor
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmEstadoCuentaProveedor = Nothing

    Public Shared Function Instance() As frmEstadoCuentaProveedor
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmEstadoCuentaProveedor()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

#Region " Código generado por el Diseñador de Windows Forms "

    Private Sub New()
        MyBase.New()

        'Application.EnableVisualStyles()

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
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents etSaldo As System.Windows.Forms.Label
    Friend WithEvents cbTipoFactura As System.Windows.Forms.ComboBox
    Friend WithEvents cmdVer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPagos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPendientes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdVencidas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtpFecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbFecha As System.Windows.Forms.CheckBox
    Friend WithEvents etProveedor As System.Windows.Forms.Label
    Friend WithEvents VEstadoCuenta As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents bExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbMoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dgEstadoCuenta As DevExpress.XtraGrid.GridControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstadoCuentaProveedor))
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cbMoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.bExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdVencidas = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdPendientes = New DevExpress.XtraEditors.SimpleButton()
        Me.dgEstadoCuenta = New DevExpress.XtraGrid.GridControl()
        Me.VEstadoCuenta = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdPagos = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdVer = New DevExpress.XtraEditors.SimpleButton()
        Me.etSaldo = New System.Windows.Forms.Label()
        Me.cbFecha = New System.Windows.Forms.CheckBox()
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.etProveedor = New System.Windows.Forms.Label()
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker()
        Me.cbTipoFactura = New System.Windows.Forms.ComboBox()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgEstadoCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VEstadoCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdImprimir
        '
        Me.cmdImprimir.ImageOptions.Image = CType(resources.GetObject("cmdImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdImprimir.Location = New System.Drawing.Point(12, 243)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(91, 38)
        Me.cmdImprimir.StyleController = Me.LayoutControl1
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cbMoneda)
        Me.LayoutControl1.Controls.Add(Me.lblTitulo)
        Me.LayoutControl1.Controls.Add(Me.bExportar)
        Me.LayoutControl1.Controls.Add(Me.cmdSalir)
        Me.LayoutControl1.Controls.Add(Me.cmdVencidas)
        Me.LayoutControl1.Controls.Add(Me.cmdImprimir)
        Me.LayoutControl1.Controls.Add(Me.cmdPendientes)
        Me.LayoutControl1.Controls.Add(Me.dgEstadoCuenta)
        Me.LayoutControl1.Controls.Add(Me.cmdPagos)
        Me.LayoutControl1.Controls.Add(Me.cmdVer)
        Me.LayoutControl1.Controls.Add(Me.etSaldo)
        Me.LayoutControl1.Controls.Add(Me.cbFecha)
        Me.LayoutControl1.Controls.Add(Me.dtpFecha2)
        Me.LayoutControl1.Controls.Add(Me.etProveedor)
        Me.LayoutControl1.Controls.Add(Me.dtpFecha1)
        Me.LayoutControl1.Controls.Add(Me.cbTipoFactura)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem6, Me.LayoutControlItem5, Me.LayoutControlItem4})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(568, 205, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(733, 293)
        Me.LayoutControl1.TabIndex = 170
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cbMoneda
        '
        Me.cbMoneda.Location = New System.Drawing.Point(101, 36)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMoneda.Properties.Appearance.Options.UseFont = True
        Me.cbMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMoneda.Size = New System.Drawing.Size(620, 22)
        Me.cbMoneda.StyleController = Me.LayoutControl1
        Me.cbMoneda.TabIndex = 172
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(12, 12)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(709, 20)
        Me.lblTitulo.TabIndex = 171
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bExportar
        '
        Me.bExportar.ImageOptions.Image = CType(resources.GetObject("bExportar.ImageOptions.Image"), System.Drawing.Image)
        Me.bExportar.Location = New System.Drawing.Point(107, 243)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(95, 38)
        Me.bExportar.StyleController = Me.LayoutControl1
        Me.bExportar.TabIndex = 171
        Me.bExportar.Text = "E&xportar"
        '
        'cmdSalir
        '
        Me.cmdSalir.ImageOptions.Image = CType(resources.GetObject("cmdSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(626, 243)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(95, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl1
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdVencidas
        '
        Me.cmdVencidas.ImageOptions.Image = CType(resources.GetObject("cmdVencidas.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdVencidas.Location = New System.Drawing.Point(512, 243)
        Me.cmdVencidas.Name = "cmdVencidas"
        Me.cmdVencidas.Size = New System.Drawing.Size(95, 38)
        Me.cmdVencidas.StyleController = Me.LayoutControl1
        Me.cmdVencidas.TabIndex = 164
        Me.cmdVencidas.Text = "&Vencidas"
        '
        'cmdPendientes
        '
        Me.cmdPendientes.ImageOptions.Image = CType(resources.GetObject("cmdPendientes.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdPendientes.Location = New System.Drawing.Point(402, 243)
        Me.cmdPendientes.Name = "cmdPendientes"
        Me.cmdPendientes.Size = New System.Drawing.Size(106, 38)
        Me.cmdPendientes.StyleController = Me.LayoutControl1
        Me.cmdPendientes.TabIndex = 163
        Me.cmdPendientes.Text = "&Pendientes"
        '
        'dgEstadoCuenta
        '
        Me.dgEstadoCuenta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgEstadoCuenta.Location = New System.Drawing.Point(12, 62)
        Me.dgEstadoCuenta.MainView = Me.VEstadoCuenta
        Me.dgEstadoCuenta.Name = "dgEstadoCuenta"
        Me.dgEstadoCuenta.Size = New System.Drawing.Size(709, 153)
        Me.dgEstadoCuenta.TabIndex = 169
        Me.dgEstadoCuenta.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VEstadoCuenta})
        '
        'VEstadoCuenta
        '
        Me.VEstadoCuenta.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VEstadoCuenta.Appearance.HeaderPanel.Options.UseFont = True
        Me.VEstadoCuenta.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.VEstadoCuenta.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.VEstadoCuenta.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.VEstadoCuenta.GridControl = Me.dgEstadoCuenta
        Me.VEstadoCuenta.Name = "VEstadoCuenta"
        Me.VEstadoCuenta.OptionsBehavior.Editable = False
        Me.VEstadoCuenta.OptionsView.EnableAppearanceEvenRow = True
        Me.VEstadoCuenta.OptionsView.EnableAppearanceOddRow = True
        Me.VEstadoCuenta.OptionsView.ShowAutoFilterRow = True
        Me.VEstadoCuenta.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VEstadoCuenta.OptionsView.ShowFooter = True
        Me.VEstadoCuenta.OptionsView.ShowGroupPanel = False
        '
        'cmdPagos
        '
        Me.cmdPagos.ImageOptions.Image = Global.SysContab.My.Resources.Resources.pago
        Me.cmdPagos.Location = New System.Drawing.Point(305, 243)
        Me.cmdPagos.Name = "cmdPagos"
        Me.cmdPagos.Size = New System.Drawing.Size(93, 38)
        Me.cmdPagos.StyleController = Me.LayoutControl1
        Me.cmdPagos.TabIndex = 162
        Me.cmdPagos.Text = "&Pagos"
        '
        'cmdVer
        '
        Me.cmdVer.ImageOptions.Image = CType(resources.GetObject("cmdVer.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdVer.Location = New System.Drawing.Point(206, 243)
        Me.cmdVer.Name = "cmdVer"
        Me.cmdVer.Size = New System.Drawing.Size(95, 38)
        Me.cmdVer.StyleController = Me.LayoutControl1
        Me.cmdVer.TabIndex = 144
        Me.cmdVer.Text = "&Facturas"
        '
        'etSaldo
        '
        Me.etSaldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etSaldo.BackColor = System.Drawing.Color.Transparent
        Me.etSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etSaldo.ForeColor = System.Drawing.Color.Maroon
        Me.etSaldo.Location = New System.Drawing.Point(499, 219)
        Me.etSaldo.Name = "etSaldo"
        Me.etSaldo.Size = New System.Drawing.Size(222, 20)
        Me.etSaldo.TabIndex = 136
        Me.etSaldo.Text = "0.00"
        Me.etSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbFecha
        '
        Me.cbFecha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbFecha.Location = New System.Drawing.Point(12, 341)
        Me.cbFecha.Name = "cbFecha"
        Me.cbFecha.Size = New System.Drawing.Size(387, 20)
        Me.cbFecha.TabIndex = 165
        Me.cbFecha.Text = "Por Fecha:"
        Me.cbFecha.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cbFecha.Visible = False
        '
        'dtpFecha2
        '
        Me.dtpFecha2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha2.Location = New System.Drawing.Point(50, 341)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(545, 20)
        Me.dtpFecha2.TabIndex = 167
        Me.dtpFecha2.Value = New Date(2005, 12, 6, 8, 56, 2, 62)
        Me.dtpFecha2.Visible = False
        '
        'etProveedor
        '
        Me.etProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etProveedor.BackColor = System.Drawing.Color.Transparent
        Me.etProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etProveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etProveedor.Location = New System.Drawing.Point(12, 341)
        Me.etProveedor.Name = "etProveedor"
        Me.etProveedor.Size = New System.Drawing.Size(779, 20)
        Me.etProveedor.TabIndex = 168
        Me.etProveedor.Text = "Codigo Proveedor"
        Me.etProveedor.Visible = False
        '
        'dtpFecha1
        '
        Me.dtpFecha1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha1.Location = New System.Drawing.Point(48, 341)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(743, 20)
        Me.dtpFecha1.TabIndex = 166
        Me.dtpFecha1.Visible = False
        '
        'cbTipoFactura
        '
        Me.cbTipoFactura.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTipoFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoFactura.Location = New System.Drawing.Point(80, 340)
        Me.cbTipoFactura.Name = "cbTipoFactura"
        Me.cbTipoFactura.Size = New System.Drawing.Size(711, 21)
        Me.cbTipoFactura.TabIndex = 142
        Me.cbTipoFactura.Visible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.etProveedor
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 329)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(783, 24)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbTipoFactura
        Me.LayoutControlItem3.CustomizationFormText = "Tipo Factura:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 328)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(783, 25)
        Me.LayoutControlItem3.Text = "Tipo Factura:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cbFecha
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 329)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(391, 24)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.dtpFecha2
        Me.LayoutControlItem5.CustomizationFormText = "Desde:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 329)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(587, 24)
        Me.LayoutControlItem5.Text = "Desde:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.dtpFecha1
        Me.LayoutControlItem4.CustomizationFormText = "Hasta:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 329)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(783, 24)
        Me.LayoutControlItem4.Text = "Hasta:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem7, Me.EmptySpaceItem1, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.EmptySpaceItem2, Me.LayoutControlItem15, Me.LayoutControlItem16})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(733, 293)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dgEstadoCuenta
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(713, 157)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem7.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem7.Control = Me.etSaldo
        Me.LayoutControlItem7.CustomizationFormText = "Saldo Actual:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(398, 207)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(315, 24)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(315, 24)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(315, 24)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "Saldo Actual:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(86, 16)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 207)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(398, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmdImprimir
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 231)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmdVer
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(194, 231)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cmdPagos
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(293, 231)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cmdPendientes
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(390, 231)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cmdVencidas
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(500, 231)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.cmdSalir
        Me.LayoutControlItem13.CustomizationFormText = "LayoutControlItem13"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(614, 231)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.bExportar
        Me.LayoutControlItem14.CustomizationFormText = "LayoutControlItem14"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(95, 231)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(599, 231)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(15, 42)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.lblTitulo
        Me.LayoutControlItem15.CustomizationFormText = "LayoutControlItem15"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(24, 24)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(713, 24)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.cbMoneda
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(713, 26)
        Me.LayoutControlItem16.Text = "Moneda:"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(86, 13)
        '
        'frmEstadoCuentaProveedor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(733, 293)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmEstadoCuentaProveedor"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgEstadoCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VEstadoCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Proveedores As New VB.SysContab.ProveedoresDB()
    Dim ProveedorDetalle As New VB.SysContab.ProveedoresDetails()
    Dim FormaPago As New VB.SysContab.Forma_PagoDB
    Dim Saldo As Double
    Public FilaActual As Integer
    Dim ini As Boolean = True

    Private Sub frmEstadoCuenta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.dtpFecha1.Value = VB.SysContab.Rutinas.Fecha
        Me.dtpFecha2.Value = VB.SysContab.Rutinas.Fecha

        dtpFecha1.Enabled = False
        dtpFecha2.Enabled = False

        Fecha1 = ""
        Fecha2 = ""

        cbTipoFactura.DataSource = FormaPago.FormaPagoListAll().Tables("Forma_Pago")
        cbTipoFactura.ValueMember = "Codigo"
        cbTipoFactura.DisplayMember = "Nombre"

        cbTipoFactura.DropDownStyle = ComboBoxStyle.DropDownList

        ProveedorDetalle =
            VB.SysContab.ProveedoresDB.GetDetails(etProveedor.Text)

        GetMonedasList(cbMoneda)

        'Buscar(ini)

        ini = False

        Text = "Estado de Cuenta Proveedor: " & ProveedorDetalle.Nombre
        lblTitulo.Text = CStr("Estado de Cuenta Proveedor: " & ProveedorDetalle.Nombre).ToUpper

        Me.VEstadoCuenta.PopulateColumns()
        '
        Saldo = 0
        '
        For i As Integer = 0 To Me.VEstadoCuenta.DataRowCount - 1
            Saldo += Me.VEstadoCuenta.GetRowCellValue(i, "Créditos") - Me.VEstadoCuenta.GetRowCellValue(i, "Débitos")
            Me.VEstadoCuenta.SetRowCellValue(i, "Saldo", Saldo)
        Next
        '
        Me.VEstadoCuenta.Columns("Proveedor").Visible = False
        Me.VEstadoCuenta.Columns("Débitos").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VEstadoCuenta.Columns("Débitos").DisplayFormat.FormatString = "n2"
        Me.VEstadoCuenta.Columns("Débitos").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.VEstadoCuenta.Columns("Débitos").SummaryItem.DisplayFormat = "{0:n2}"

        Me.VEstadoCuenta.Columns("Créditos").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VEstadoCuenta.Columns("Créditos").DisplayFormat.FormatString = "n2"
        Me.VEstadoCuenta.Columns("Créditos").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.VEstadoCuenta.Columns("Créditos").SummaryItem.DisplayFormat = "{0:n2}"

        Me.VEstadoCuenta.Columns("Saldo").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VEstadoCuenta.Columns("Saldo").DisplayFormat.FormatString = "n2"
        'Me.VEstadoCuenta.Columns("Saldo").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.VEstadoCuenta.Columns("Saldo").SummaryItem.DisplayFormat = "{0;n2}"

        Me.VEstadoCuenta.Columns("Orden").Visible = False

        Me.VEstadoCuenta.Columns("Fecha").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True
        Me.VEstadoCuenta.Columns("Acción").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
        Me.VEstadoCuenta.Columns("Factura").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
        Me.VEstadoCuenta.Columns("Tipo").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
        Me.VEstadoCuenta.Columns("Fecha Vencimiento").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True
        Me.VEstadoCuenta.Columns("Comprobante").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
        Me.VEstadoCuenta.Columns("Débitos").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
        Me.VEstadoCuenta.Columns("Créditos").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
        Me.VEstadoCuenta.Columns("Saldo").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
        Me.VEstadoCuenta.Columns("Estado").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
        Me.VEstadoCuenta.Columns("Per_ID").Visible = False
        Me.VEstadoCuenta.Columns("TipoMovimiento").Visible = False

        If Me.VEstadoCuenta.DataRowCount = 0 Then
            etSaldo.Text = "0.00"
        Else
            etSaldo.Text = CDbl(Me.VEstadoCuenta.GetRowCellValue(Me.VEstadoCuenta.DataRowCount - 1, "Saldo")).ToString(Round)
        End If
    End Sub

    Public Sub Buscar(Optional inic As Boolean = False)

        Dim lds As New DataTable
        lds = Proveedores.EstadoCuenta(
            Me.etProveedor.Text,
            cbMoneda.EditValue) _
            .Tables("Proveedores")

        lds.DataSet.WriteXml(Application.StartupPath & "\xml\ECProveedor.xml", XmlWriteMode.WriteSchema)
        dgEstadoCuenta.DataSource = lds
        lds = Nothing

        Saldo = 0

        If Not inic Then
            For i As Integer = 0 To Me.VEstadoCuenta.DataRowCount - 1
                Saldo += Me.VEstadoCuenta.GetRowCellValue(i, "Créditos") - Me.VEstadoCuenta.GetRowCellValue(i, "Débitos")
                Me.VEstadoCuenta.SetRowCellValue(i, "Saldo", Saldo)
            Next
            '
            If Me.VEstadoCuenta.DataRowCount = 0 Then
                etSaldo.Text = "0.00"
            Else
                etSaldo.Text = CDbl(Me.VEstadoCuenta.GetRowCellValue(Me.VEstadoCuenta.DataRowCount - 1, "Saldo")).ToString(Round)
            End If
        End If

    End Sub

    'Public Sub Saldo()
    '    'Me.dgEstadoCuenta.Visible = False
    '    'System.Threading.Thread.Sleep(5000)
    '    dgEstadoCuenta.DataSource = ds.Tables("Proveedores").DefaultView
    '    r.FormatGenerico(dgEstadoCuenta, Tabla)

    '    If ds.Tables("Proveedores").Rows.Count > 0 Then
    '        Me.dgEstadoCuenta.CurrentRowIndex = 0
    '        etSaldo.Text = CDbl(dgEstadoCuenta.Item(ds.Tables("Proveedores").Rows.Count - 1, 9)).ToString(Round)
    '    Else
    '        etSaldo.Text = (0).ToString(Round)
    '    End If
    '    'Me.dgEstadoCuenta.Visible = True
    'End Sub

    Private Sub cmdSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVer.Click
        frmFacturasComprasListNew.Dispose()
        '
        With frmFacturasComprasListNew
            .IdProveedor = etProveedor.Text
            .IdTipoPago = 0
            .Estado = "T"
            .Text = "Compras a Proveedores"
            .Show()
        End With



        'Dim f As frmFacturasComprasLista = frmFacturasComprasLista.Instance()

        'f.etProveedor.Text = Me.etProveedor.Text
        'f.etTipoPago.Text = Me.cbTipoFactura.SelectedValue

        'If cbFecha.Checked = True Then
        '    f.etFecha1.Text = dtpFecha1.Value.Date
        '    f.etFecha2.Text = dtpFecha2.Value.Date
        'Else
        '    f.etFecha1.Text = ""
        '    f.etFecha2.Text = ""
        'End If

        'f.etEstado.Text = "T"

        'f.MdiParent = Me.MdiParent
        'f.Show()
        'f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cmdPagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPagos.Click
        Dim f As frmPagosProveedor = frmPagosProveedor.Instance()
        f.etInicio.Text = "1"
        f.etProveedor.Text = Me.etProveedor.Text
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "0"
    End Sub

    Private Sub cmdPendientes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPendientes.Click
        frmFacturasComprasListNew.Dispose()
        '
        With frmFacturasComprasListNew
            .IdProveedor = etProveedor.Text
            .IdTipoPago = 0
            .Estado = "P"
            .Text = "Compras a Proveedores - Pendientes"
            .Show()
        End With

        'Dim f As frmFacturasComprasLista = frmFacturasComprasLista.Instance()
        'f.etProveedor.Text = Me.etProveedor.Text
        'f.etTipoPago.Text = Me.cbTipoFactura.SelectedValue

        'If cbFecha.Checked = True Then
        '    f.etFecha1.Text = dtpFecha1.Value.Date
        '    f.etFecha2.Text = dtpFecha2.Value.Date
        'Else
        '    f.etFecha1.Text = ""
        '    f.etFecha2.Text = ""
        'End If

        'f.etEstado.Text = "P"

        'f.MdiParent = Me.MdiParent
        'f.Show()
        'f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cmdVencidas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdVencidas.Click
        frmFacturasComprasListNew.Dispose()
        '
        With frmFacturasComprasListNew
            .IdProveedor = etProveedor.Text
            .IdTipoPago = 0
            .Estado = "V"
            .Text = "Compras a Proveedores - Vencidas"
            .Show()
        End With

        'Dim f As frmFacturasComprasLista = f.Instance

        'f.etProveedor.Text = Me.etProveedor.Text
        'f.etTipoPago.Text = Me.cbTipoFactura.SelectedValue

        'If cbFecha.Checked = True Then
        '    f.etFecha1.Text = dtpFecha1.Value.Date
        '    f.etFecha2.Text = dtpFecha2.Value.Date
        'Else
        '    f.etFecha1.Text = ""
        '    f.etFecha2.Text = ""
        'End If

        'f.etEstado.Text = "V"

        'f.MdiParent = Me.MdiParent
        'f.Show()
        'f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cbFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFecha.CheckedChanged
        If cbFecha.Checked = True Then
            dtpFecha1.Enabled = True
            dtpFecha2.Enabled = True

            Fecha1 = dtpFecha1.Value.Date
            Fecha2 = dtpFecha2.Value.Date

        Else
            dtpFecha1.Enabled = False
            dtpFecha2.Enabled = False

            Fecha1 = ""
            Fecha2 = ""
        End If
    End Sub

    Private Sub dtpFecha1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha1.ValueChanged
        Fecha1 = dtpFecha1.Value.Date
        Fecha2 = dtpFecha2.Value.Date
    End Sub

    Private Sub dtpFecha2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha2.ValueChanged
        Fecha1 = dtpFecha1.Value.Date
        Fecha2 = dtpFecha2.Value.Date
    End Sub

    Private Sub frmEstadoCuentaProveedor_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim f As frmAgregarProveedor = frmAgregarProveedor.Instance
        f.etInicio.Text = "0"
    End Sub


    Private Sub MostrarPago()
        Dim f As DataGridTextBoxCombo.frmChequesEditarEC =
            DataGridTextBoxCombo.frmChequesEditarEC.Instance
        f.MdiParent = Me.MdiParent
        f.etInicio.Text = "1"
        f.etComprobante.Text = Me.VEstadoCuenta.GetFocusedRowCellValue("Comprobante")
        f.etFecha.Text = Me.VEstadoCuenta.GetFocusedRowCellValue("Fecha")
        f.etPeriodo.Text = Me.VEstadoCuenta.GetFocusedRowCellValue("Per_ID")
        f.Show()
        f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "0"
    End Sub



    Private Sub VEstadoCuenta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles VEstadoCuenta.DoubleClick
        If Me.VEstadoCuenta.GetFocusedRowCellValue("TipoMovimiento") = 2 Then
            Dim f As DataGridTextBoxCombo.frmFacturaProveedorEditarEC = DataGridTextBoxCombo.frmFacturaProveedorEditarEC.Instance
            FilaActual = Me.VEstadoCuenta.FocusedRowHandle
            f.Comp = Me.VEstadoCuenta.GetFocusedRowCellValue("Comprobante")
            f.Per = Me.VEstadoCuenta.GetFocusedRowCellValue("Per_ID")
            f.Fecha = Me.VEstadoCuenta.GetFocusedRowCellValue("Fecha")
            f.MdiParent = Me.MdiParent
            f.Show()
        ElseIf Me.VEstadoCuenta.GetFocusedRowCellValue("TipoMovimiento") = 1 Then

            ShowSplash()
            '
            Dim frm As frmFacturasCompra = frmFacturasCompra.Instance()
            frm.Dispose()
            '
            Dim f As frmFacturasCompra = frmFacturasCompra.Instance()
            f.etInicio.Text = "1"

            f.cmdAceptar.Enabled = False
            f.cmbdistribucion.Enabled = False
            f.btnDetalle.Enabled = False
            'f.gridDatos.Enabled = False
            f.ckIR.Enabled = False
            f.chkIRAlc.Enabled = False
            'f.ckLiquidar.Enabled = False
            f.ckIVAAsumido.Enabled = False

            f.txtfactura.Text = Me.VEstadoCuenta.GetFocusedRowCellValue("Factura")
            f.Proveedor = ProveedorDetalle.Codigo
            f.etOrigen.Text = "1" 'Me.VEstadoCuenta.GetFocusedRowCellValue("Destino")
            f.TipoF = "A"   'Me.VEstadoCuenta.GetFocusedRowCellValue("TipoF")
            f.Modifica = True
            f.VerFactura = True
            f.TipoC = 2
            'f.rbServicios.Checked = True
            f.gbTipo.Enabled = False

            If f.TipoF = "P" Then
                f.gbTipo.EditValue = 0
            ElseIf f.TipoF = "S" Then
                f.gbTipo.EditValue = 1
            ElseIf f.TipoF = "A" Then
                f.gbTipo.EditValue = 3
            ElseIf f.TipoF = "I" Then
                f.gbTipo.EditValue = 4
            End If

            f.MdiParent = Me.MdiParent
            f.Text = "Ver Orden de Pago"
            f.Show()
            f.etInicio.Text = "0"
            '
            HideSplash()

            'Dim f As DataGridTextBoxCombo.frmFacturasCompraVer = DataGridTextBoxCombo.frmFacturasCompraVer.Instance

            'f.txtFactura.Text = Me.VEstadoCuenta.GetFocusedRowCellValue("Factura")
            'f.txtProveedor.Text = Me.etProveedor.Text
            'f.etDestino.Text = "1"

            'f.gbTipo.Enabled = False
            'f.MdiParent = Me.MdiParent
            'f.Show()
            'f.WindowState = FormWindowState.Maximized

        ElseIf Me.VEstadoCuenta.GetFocusedRowCellValue("TipoMovimiento") = 3 Or Me.VEstadoCuenta.GetFocusedRowCellValue("TipoMovimiento") = 4 Then
            MostrarPago()
        End If
    End Sub

    Private Sub VEstadoCuenta_EndSorting(ByVal sender As Object, ByVal e As System.EventArgs) Handles VEstadoCuenta.EndSorting
        Saldo = 0
        For i As Integer = 0 To Me.VEstadoCuenta.DataRowCount - 1
            Saldo += Me.VEstadoCuenta.GetRowCellValue(i, "Créditos") - Me.VEstadoCuenta.GetRowCellValue(i, "Débitos")
            Me.VEstadoCuenta.SetRowCellValue(i, "Saldo", Saldo)
        Next
    End Sub

    Private Sub dgEstadoCuenta_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgEstadoCuenta.KeyUp
        If e.KeyCode = Keys.F5 Then
            Me.Buscar()
        End If
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        'Dim rep As New rptECProveedor_
        Dim vrep As New frmReportes

        Dim rep As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rep.Load(Application.StartupPath & "\Reportes\rptECProveedor_.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        rep.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoempresa.xml"
        rep.Database.Tables("Proveedores").Location = Application.StartupPath & "\xml\ECProveedor.xml"
        vrep.crvReportes.ReportSource = rep
        vrep.Show()
    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(dgEstadoCuenta, lblTitulo.Text)
    End Sub

    Private Sub cbMoneda_EditValueChanged(sender As Object, e As EventArgs) Handles cbMoneda.EditValueChanged
        Buscar(ini)
    End Sub
End Class
