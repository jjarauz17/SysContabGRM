Imports DevExpress.XtraReports.UI

Public Class frmEstadoCuenta
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmEstadoCuenta = Nothing

    Public Shared Function Instance() As frmEstadoCuenta
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmEstadoCuenta()
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
    Friend WithEvents etSaldo As System.Windows.Forms.Label
    Friend WithEvents cbTipoFactura As System.Windows.Forms.ComboBox
    Friend WithEvents cmdPendientes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdVencidas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtpFecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbFecha As System.Windows.Forms.CheckBox
    Friend WithEvents cmdFacturas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPagos1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents VEstadoCuenta As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cbMoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dgEstadoCuenta As DevExpress.XtraGrid.GridControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstadoCuenta))
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cbMoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.dgEstadoCuenta = New DevExpress.XtraGrid.GridControl()
        Me.VEstadoCuenta = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdVencidas = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdPendientes = New DevExpress.XtraEditors.SimpleButton()
        Me.etSaldo = New System.Windows.Forms.Label()
        Me.cmdPagos1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdFacturas = New DevExpress.XtraEditors.SimpleButton()
        Me.cbFecha = New System.Windows.Forms.CheckBox()
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker()
        Me.cbTipoFactura = New System.Windows.Forms.ComboBox()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgEstadoCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VEstadoCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSalir
        '
        Me.cmdSalir.ImageOptions.Image = CType(resources.GetObject("cmdSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(617, 236)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(86, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl1
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cbMoneda)
        Me.LayoutControl1.Controls.Add(Me.lblTitulo)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.cmdSalir)
        Me.LayoutControl1.Controls.Add(Me.dgEstadoCuenta)
        Me.LayoutControl1.Controls.Add(Me.cmdVencidas)
        Me.LayoutControl1.Controls.Add(Me.cmdImprimir1)
        Me.LayoutControl1.Controls.Add(Me.cmdPendientes)
        Me.LayoutControl1.Controls.Add(Me.etSaldo)
        Me.LayoutControl1.Controls.Add(Me.cmdPagos1)
        Me.LayoutControl1.Controls.Add(Me.cmdFacturas)
        Me.LayoutControl1.Controls.Add(Me.cbFecha)
        Me.LayoutControl1.Controls.Add(Me.dtpFecha2)
        Me.LayoutControl1.Controls.Add(Me.dtpFecha1)
        Me.LayoutControl1.Controls.Add(Me.cbTipoFactura)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem3, Me.LayoutControlItem5})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(572, 163, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(715, 286)
        Me.LayoutControl1.TabIndex = 169
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cbMoneda
        '
        Me.cbMoneda.Location = New System.Drawing.Point(101, 36)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMoneda.Properties.Appearance.Options.UseFont = True
        Me.cbMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMoneda.Size = New System.Drawing.Size(602, 20)
        Me.cbMoneda.StyleController = Me.LayoutControl1
        Me.cbMoneda.TabIndex = 173
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(12, 12)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(691, 20)
        Me.lblTitulo.TabIndex = 172
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(107, 236)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(95, 38)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 170
        Me.SimpleButton1.Text = "E&xportar"
        '
        'dgEstadoCuenta
        '
        Me.dgEstadoCuenta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgEstadoCuenta.Location = New System.Drawing.Point(12, 60)
        Me.dgEstadoCuenta.MainView = Me.VEstadoCuenta
        Me.dgEstadoCuenta.Name = "dgEstadoCuenta"
        Me.dgEstadoCuenta.Size = New System.Drawing.Size(691, 148)
        Me.dgEstadoCuenta.TabIndex = 168
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
        Me.VEstadoCuenta.OptionsView.ShowAutoFilterRow = True
        Me.VEstadoCuenta.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VEstadoCuenta.OptionsView.ShowFooter = True
        Me.VEstadoCuenta.OptionsView.ShowGroupPanel = False
        '
        'cmdVencidas
        '
        Me.cmdVencidas.ImageOptions.Image = CType(resources.GetObject("cmdVencidas.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdVencidas.Location = New System.Drawing.Point(502, 236)
        Me.cmdVencidas.Name = "cmdVencidas"
        Me.cmdVencidas.Size = New System.Drawing.Size(95, 38)
        Me.cmdVencidas.StyleController = Me.LayoutControl1
        Me.cmdVencidas.TabIndex = 164
        Me.cmdVencidas.Text = "&Vencidas"
        '
        'cmdImprimir1
        '
        Me.cmdImprimir1.ImageOptions.Image = CType(resources.GetObject("cmdImprimir1.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdImprimir1.Location = New System.Drawing.Point(12, 236)
        Me.cmdImprimir1.Name = "cmdImprimir1"
        Me.cmdImprimir1.Size = New System.Drawing.Size(91, 38)
        Me.cmdImprimir1.StyleController = Me.LayoutControl1
        Me.cmdImprimir1.TabIndex = 4
        Me.cmdImprimir1.Text = "&Imprimir"
        '
        'cmdPendientes
        '
        Me.cmdPendientes.ImageOptions.Image = CType(resources.GetObject("cmdPendientes.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdPendientes.Location = New System.Drawing.Point(392, 236)
        Me.cmdPendientes.Name = "cmdPendientes"
        Me.cmdPendientes.Size = New System.Drawing.Size(106, 38)
        Me.cmdPendientes.StyleController = Me.LayoutControl1
        Me.cmdPendientes.TabIndex = 163
        Me.cmdPendientes.Text = "&Pendientes"
        '
        'etSaldo
        '
        Me.etSaldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etSaldo.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etSaldo.ForeColor = System.Drawing.Color.Maroon
        Me.etSaldo.Location = New System.Drawing.Point(503, 212)
        Me.etSaldo.Name = "etSaldo"
        Me.etSaldo.Size = New System.Drawing.Size(200, 20)
        Me.etSaldo.TabIndex = 136
        Me.etSaldo.Text = "0.00"
        Me.etSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdPagos1
        '
        Me.cmdPagos1.ImageOptions.Image = CType(resources.GetObject("cmdPagos1.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdPagos1.Location = New System.Drawing.Point(305, 236)
        Me.cmdPagos1.Name = "cmdPagos1"
        Me.cmdPagos1.Size = New System.Drawing.Size(83, 38)
        Me.cmdPagos1.StyleController = Me.LayoutControl1
        Me.cmdPagos1.TabIndex = 162
        Me.cmdPagos1.Text = "&Pagos"
        '
        'cmdFacturas
        '
        Me.cmdFacturas.ImageOptions.Image = CType(resources.GetObject("cmdFacturas.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdFacturas.Location = New System.Drawing.Point(206, 236)
        Me.cmdFacturas.Name = "cmdFacturas"
        Me.cmdFacturas.Size = New System.Drawing.Size(95, 38)
        Me.cmdFacturas.StyleController = Me.LayoutControl1
        Me.cmdFacturas.TabIndex = 144
        Me.cmdFacturas.Text = "&Facturas"
        '
        'cbFecha
        '
        Me.cbFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbFecha.Location = New System.Drawing.Point(12, 300)
        Me.cbFecha.Name = "cbFecha"
        Me.cbFecha.Size = New System.Drawing.Size(753, 20)
        Me.cbFecha.TabIndex = 165
        Me.cbFecha.Text = "Por Fecha:"
        Me.cbFecha.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cbFecha.Visible = False
        '
        'dtpFecha2
        '
        Me.dtpFecha2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtpFecha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha2.Location = New System.Drawing.Point(490, 300)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(275, 20)
        Me.dtpFecha2.TabIndex = 167
        Me.dtpFecha2.Value = New Date(2005, 12, 6, 8, 56, 2, 62)
        Me.dtpFecha2.Visible = False
        '
        'dtpFecha1
        '
        Me.dtpFecha1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtpFecha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha1.Location = New System.Drawing.Point(301, 300)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(464, 20)
        Me.dtpFecha1.TabIndex = 166
        Me.dtpFecha1.Visible = False
        '
        'cbTipoFactura
        '
        Me.cbTipoFactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoFactura.Location = New System.Drawing.Point(112, 299)
        Me.cbTipoFactura.Name = "cbTipoFactura"
        Me.cbTipoFactura.Size = New System.Drawing.Size(653, 21)
        Me.cbTipoFactura.TabIndex = 142
        Me.cbTipoFactura.Visible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cbTipoFactura
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 287)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(757, 25)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.dtpFecha2
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(378, 288)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(379, 24)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.dtpFecha1
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(189, 288)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(568, 24)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cbFecha
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 288)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(757, 24)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem6, Me.EmptySpaceItem1, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.EmptySpaceItem2, Me.LayoutControlItem15})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(715, 286)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dgEstadoCuenta
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(695, 152)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem6.Control = Me.etSaldo
        Me.LayoutControlItem6.CustomizationFormText = "Saldo Actual:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(402, 200)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(293, 24)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(293, 24)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(293, 24)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Saldo Actual:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(86, 16)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 200)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(402, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cmdImprimir1
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 224)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmdFacturas
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(194, 224)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmdPagos1
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(293, 224)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(87, 42)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(87, 42)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(87, 42)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cmdPendientes
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(380, 224)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cmdVencidas
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(490, 224)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cmdSalir
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(605, 224)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(90, 42)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(90, 42)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(90, 42)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.SimpleButton1
        Me.LayoutControlItem13.CustomizationFormText = "LayoutControlItem13"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(95, 224)
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
        Me.LayoutControlItem14.Control = Me.lblTitulo
        Me.LayoutControlItem14.CustomizationFormText = "LayoutControlItem14"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(24, 24)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(695, 24)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(589, 224)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(16, 42)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.cbMoneda
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(695, 24)
        Me.LayoutControlItem15.Text = "Moneda:"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(86, 13)
        '
        'frmEstadoCuenta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(715, 286)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmEstadoCuenta"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgEstadoCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VEstadoCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Clientes As New VB.SysContab.ClientesDB()
    'Dim DetallesCliente As New VB.SysContab.ClientesDetails()
    Dim FormaPago As New VB.SysContab.Forma_PagoDB()
    Dim Saldo As Double
    Public fp As String
    Public NombreCliente As String = ""
    Dim _DT_EC As New DataTable("EstadoCuentaCliente")

    Private Sub frmEstadoCuenta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            dtpFecha1.Value = VB.SysContab.Rutinas.Fecha
            dtpFecha2.Value = VB.SysContab.Rutinas.Fecha

            dtpFecha1.Enabled = False
            dtpFecha2.Enabled = False

            Fecha1 = ""
            Fecha2 = ""

            cbTipoFactura.DataSource = FormaPago.FormaPagoListAll().Tables("Forma_Pago")
            cbTipoFactura.ValueMember = "Codigo"
            cbTipoFactura.DisplayMember = "Nombre"

            cbTipoFactura.DropDownStyle = ComboBoxStyle.DropDown

            Text = "Estado de Cuenta"
            GetMonedasList(cbMoneda)
            '
            'Formato()
            ' Cargar()

            'Corregir el asunto de los roles, estan por la %"·$%"$·%"$% Rtg 05082008
            'VB.SysContab.Rutinas.UsuariosAcciones(Me, "frmClientes")
        Catch ex As Exception
            XtraMsg(ex.Message,
                    MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Cargar()

        _DT_EC = Clientes.EstadoCuenta(
            RegistroCliente,
            cbMoneda.EditValue)

        dgEstadoCuenta.DataSource = _DT_EC
        '
        Formato()
        '
        'If VEstadoCuenta.DataRowCount = 0 Then
        '    etSaldo.Text = "0.00"
        'Else
        '    etSaldo.Text = CDbl(Me.VEstadoCuenta.GetRowCellValue(Me.VEstadoCuenta.DataRowCount - 1, "Saldo")).ToString(Round)
        'End If
    End Sub

    Sub Formato()

        If Inicio Then VEstadoCuenta.PopulateColumns()
        Saldo = 0
        '
        For i As Integer = 0 To Me.VEstadoCuenta.DataRowCount - 1
            Saldo += VEstadoCuenta.GetRowCellValue(i, "Débitos") - VEstadoCuenta.GetRowCellValue(i, "Créditos")
            VEstadoCuenta.SetRowCellValue(i, "Saldo", Saldo)
        Next

        If Inicio Then
            Me.VEstadoCuenta.Columns("Cliente").Visible = False
            Me.VEstadoCuenta.Columns("Débitos").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.VEstadoCuenta.Columns("Débitos").DisplayFormat.FormatString = "{0:n2}"
            Me.VEstadoCuenta.Columns("Débitos").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.VEstadoCuenta.Columns("Débitos").SummaryItem.DisplayFormat = "{0:n2}"

            Me.VEstadoCuenta.Columns("Créditos").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.VEstadoCuenta.Columns("Créditos").DisplayFormat.FormatString = "{0:n2}"
            Me.VEstadoCuenta.Columns("Créditos").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.VEstadoCuenta.Columns("Créditos").SummaryItem.DisplayFormat = "{0:n2}"

            Me.VEstadoCuenta.Columns("Saldo").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.VEstadoCuenta.Columns("Saldo").DisplayFormat.FormatString = "{0:n2}"
            'Me.VEstadoCuenta.Columns("Saldo").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            'Me.VEstadoCuenta.Columns("Saldo").SummaryItem.DisplayFormat = "{0;n2}"

            Me.VEstadoCuenta.Columns("Orden").Visible = False

            Me.VEstadoCuenta.Columns("Fecha").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True
            Me.VEstadoCuenta.Columns("Acción").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.VEstadoCuenta.Columns("Factura").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.VEstadoCuenta.Columns("Forma de Pago").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.VEstadoCuenta.Columns("Fecha Vencimiento").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True
            Me.VEstadoCuenta.Columns("Recibo").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.VEstadoCuenta.Columns("Débitos").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.VEstadoCuenta.Columns("Créditos").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.VEstadoCuenta.Columns("Saldo").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
        End If

        'DetallesCliente = VB.SysContab.ClientesDB.GetDetails(RegistroCliente)

        If _DT_EC.Rows.Count = 0 Then
            etSaldo.Text = "0.00"
        Else
            etSaldo.Text = CDbl(_DT_EC.Rows.Item(_DT_EC.Rows.Count - 1)("Saldo")).ToString(Round)
        End If


        'If VEstadoCuenta.DataRowCount = 0 Then
        '    etSaldo.Text = "0.00"
        'Else
        '    etSaldo.Text = CDbl(Me.VEstadoCuenta.GetRowCellValue(Me.VEstadoCuenta.DataRowCount - 1, "Saldo")).ToString(Round)
        'End If
    End Sub
    Private Sub cmdSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFacturas.Click
        Dim f As frmFacturasxTipo = frmFacturasxTipo.Instance

        If Trim(cbTipoFactura.Text) = "" Then
            TipoFacturaCliente = 0
        Else
            TipoFacturaCliente = cbTipoFactura.SelectedValue
        End If

        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub

    Private Sub cmdPagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPagos1.Click
        Dim f As frmPagosXCliente = f.Instance

        If Trim(cbTipoFactura.Text) = "" Then
            TipoFacturaCliente = 0
        Else
            TipoFacturaCliente = cbTipoFactura.SelectedValue
        End If

        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub

    Private Sub cmdPendientes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPendientes.Click
        Dim f As frmFacturasPendientes = frmFacturasPendientes.Instance

        If Trim(cbTipoFactura.Text) = "" Then
            TipoFacturaCliente = 0
        Else
            TipoFacturaCliente = cbTipoFactura.SelectedValue
        End If

        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub

    Private Sub cmdVencidas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdVencidas.Click
        Dim f As frmFacturasVencidas = f.Instance

        If Trim(cbTipoFactura.Text) = "" Then
            TipoFacturaCliente = 0
        Else
            TipoFacturaCliente = cbTipoFactura.SelectedValue
        End If

        f.MdiParent = Me.MdiParent
        f.Show()
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

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir1.Click

        ' VistaPrevia(dgEstadoCuenta, "Cliente: " & NombreCliente, "ESTADO DE CUENTA" & vbCrLf & cbMoneda.Text)

        'Dim fReportes As New frmReportes
        'Dim rFacturas As New RptCuentasPorCobrar
        'Dim Clientes As New VB.SysContab.ClientesDB
        'Dim lds As New DataTable
        'lds = Clientes.EstadoCuentaReporte(RegistroCliente, 0, 0, Now.Date, DateAdd(DateInterval.Year, -10, Now.Date), Now.Date).Tables(0)
        'lds.DataSet.WriteXml(Application.StartupPath & "\xml\ECCliente_.xml")
        'lds = Nothing
        'Return
        'rFacturas.SetDataSource(lds.DataSet)
        'fReportes.crvReportes.ReportSource = rFacturas
        'fReportes.Show()

        'Dim f As frmReporteEstadoCuenta = f.Instance
        'f.MdiParent = Me.MdiParent
        'f.Show()
        'f.cbClientes.SelectedValue = RegistroCliente
        'f.cbClientes.Enabled = False

        'f.WindowState = FormWindowState.Maximized
        'Dim Clientes As New VB.SysContab.ClientesDB

        ShowSplash()
        Dim rpt As New RptEstadoCuentaCliente
        rpt.DataSource = Clientes.EstadoCuentaReporteNew(RegistroCliente, 0, 0, Now.Date, DateAdd(DateInterval.Year, -10, Now.Date), Now.Date, "%", "%", 0).Tables(0)
        HideSplash()

        Try
            Dim LogoPath As Object = VB.SysContab.EmpresasDB.GetLogoEmpresaPath()
            'Dim DT_LOGO As DataTable = VB.SysContab.EmpresasDB.GetLogoEmpresa().Tables(0)
            'Dim data As Byte() = DirectCast(LogoPath, Byte())
            'Dim ms As New System.IO.MemoryStream(data)
            rpt.Logo.Image = Image.FromFile(LogoPath) 'Image.FromStream(ms)
        Catch ex As Exception
        End Try

        rpt.ShowPrintMarginsWarning = False
        rpt.BringToFront()
        rpt.ShowRibbonPreview()
    End Sub

    Private Sub frmEstadoCuenta_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim f As frmAgregarCliente = f.Instance
        f.etInicio.Text = "0"
    End Sub


    Private Sub VEstadoCuenta_EndSorting(ByVal sender As Object, ByVal e As System.EventArgs) Handles VEstadoCuenta.EndSorting
        Saldo = 0

        For i As Integer = 0 To Me.VEstadoCuenta.DataRowCount - 1
            Saldo += Me.VEstadoCuenta.GetRowCellValue(i, "Débitos") - Me.VEstadoCuenta.GetRowCellValue(i, "Créditos")
            Me.VEstadoCuenta.SetRowCellValue(i, "Saldo", Saldo)
        Next
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        VEstadoCuenta.Columns("Forma de Pago").Visible = False
        frmExportarImprimir.Mostrar(dgEstadoCuenta, "Cliente: " & NombreCliente, "ESTADO DE CUENTA" & vbCrLf & cbMoneda.Text)
        VEstadoCuenta.Columns("Forma de Pago").Visible = True
    End Sub

    Private Sub cbMoneda_EditValueChanged(sender As Object, e As EventArgs) Handles cbMoneda.EditValueChanged
        If Not Inicio Then ShowSplash()
        Cargar()
        If Not Inicio Then HideSplash()
    End Sub
End Class
