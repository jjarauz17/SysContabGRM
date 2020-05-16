Public Class frmLBBancos
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmLBBancos = Nothing
    Private Catalogo As New VB.SysContab.CatalogoDB
    Private Catalogo_Bancos As New VB.SysContab.Catalogo_BancosDB
    Private Bancos As New VB.SysContab.BancosDB
    Private DetalleBanco As New VB.SysContab.BancosDetails
    Private r As New VB.SysContab.Rutinas
    Private Tabla As DataTable
    Private ds As DataSet
    Dim Periodos As New VB.SysContab.PeriodosDB
    Dim Libros As New VB.SysContab.LibrosDB

    Dim DEmpresa As New VB.SysContab.EmpresasDetails
    Dim empresa As New VB.SysContab.EmpresasDB

    Dim dMoneda As New VB.SysContab.MonedaDetails
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents cbBancos As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents vBancos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents dtpHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Dim Moneda As New VB.SysContab.MonedaDB


    Public Shared Function Instance() As frmLBBancos
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmLBBancos
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSeleccionar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbMonedaCambio As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLBBancos))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cbMonedaCambio = New System.Windows.Forms.ComboBox()
        Me.cmdSeleccionar = New DevExpress.XtraEditors.SimpleButton()
        Me.cbBancos = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.vBancos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.dtpDesde = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.dtpHasta = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cbBancos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vBancos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(544, 290)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(88, 260)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.ImageOptions.Image = Global.SysContab.My.Resources.Resources.RibbonPrintPreview_ParametersLarge
        Me.cmdAyuda.Location = New System.Drawing.Point(524, 152)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(108, 38)
        Me.cmdAyuda.StyleController = Me.LayoutControl1
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "Ayuda"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.dtpHasta)
        Me.LayoutControl1.Controls.Add(Me.dtpDesde)
        Me.LayoutControl1.Controls.Add(Me.cmdSalir)
        Me.LayoutControl1.Controls.Add(Me.cmdAyuda)
        Me.LayoutControl1.Controls.Add(Me.cbMonedaCambio)
        Me.LayoutControl1.Controls.Add(Me.cmdSeleccionar)
        Me.LayoutControl1.Controls.Add(Me.cbBancos)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(840, 195, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(760, 202)
        Me.LayoutControl1.TabIndex = 143
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cmdSalir
        '
        Me.cmdSalir.ImageOptions.Image = CType(resources.GetObject("cmdSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(636, 152)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(112, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl1
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cbMonedaCambio
        '
        Me.cbMonedaCambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonedaCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMonedaCambio.Location = New System.Drawing.Point(57, 36)
        Me.cbMonedaCambio.Name = "cbMonedaCambio"
        Me.cbMonedaCambio.Size = New System.Drawing.Size(691, 23)
        Me.cbMonedaCambio.TabIndex = 17
        '
        'cmdSeleccionar
        '
        Me.cmdSeleccionar.ImageOptions.Image = CType(resources.GetObject("cmdSeleccionar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSeleccionar.Location = New System.Drawing.Point(520, 152)
        Me.cmdSeleccionar.Name = "cmdSeleccionar"
        Me.cmdSeleccionar.Size = New System.Drawing.Size(112, 38)
        Me.cmdSeleccionar.StyleController = Me.LayoutControl1
        Me.cmdSeleccionar.TabIndex = 2
        Me.cmdSeleccionar.Text = "Imprimir"
        '
        'cbBancos
        '
        Me.cbBancos.Location = New System.Drawing.Point(57, 12)
        Me.cbBancos.Name = "cbBancos"
        Me.cbBancos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBancos.Properties.Appearance.Options.UseFont = True
        Me.cbBancos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbBancos.Properties.NullText = "[Seleccione Banco]"
        Me.cbBancos.Properties.View = Me.vBancos
        Me.cbBancos.Size = New System.Drawing.Size(691, 20)
        Me.cbBancos.StyleController = Me.LayoutControl1
        Me.cbBancos.TabIndex = 4
        '
        'vBancos
        '
        Me.vBancos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.vBancos.Name = "vBancos"
        Me.vBancos.OptionsFind.AlwaysVisible = True
        Me.vBancos.OptionsFind.ShowClearButton = False
        Me.vBancos.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.vBancos.OptionsView.ShowAutoFilterRow = True
        Me.vBancos.OptionsView.ShowFooter = True
        Me.vBancos.OptionsView.ShowGroupPanel = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem5, Me.LayoutControlItem7, Me.EmptySpaceItem2, Me.EmptySpaceItem4, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(760, 202)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cbBancos
        Me.LayoutControlItem1.CustomizationFormText = "Banco:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(740, 24)
        Me.LayoutControlItem1.Text = "Banco:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(42, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cbMonedaCambio
        Me.LayoutControlItem2.CustomizationFormText = "Moneda:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(740, 25)
        Me.LayoutControlItem2.Text = "Moneda:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(42, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmdSeleccionar
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(508, 140)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cmdAyuda
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(512, 140)
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
        Me.LayoutControlItem7.Control = Me.cmdSalir
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(624, 140)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 140)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(508, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(184, 49)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(556, 48)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 97)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(740, 43)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'dtpDesde
        '
        Me.dtpDesde.EditValue = Nothing
        Me.dtpDesde.Location = New System.Drawing.Point(57, 61)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Properties.Appearance.Options.UseFont = True
        Me.dtpDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDesde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDesde.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dtpDesde.Size = New System.Drawing.Size(135, 20)
        Me.dtpDesde.StyleController = Me.LayoutControl1
        Me.dtpDesde.TabIndex = 18
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.dtpDesde
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 49)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(184, 24)
        Me.LayoutControlItem8.Text = "Desde:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(42, 13)
        '
        'dtpHasta
        '
        Me.dtpHasta.EditValue = Nothing
        Me.dtpHasta.Location = New System.Drawing.Point(57, 85)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Properties.Appearance.Options.UseFont = True
        Me.dtpHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpHasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpHasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dtpHasta.Size = New System.Drawing.Size(135, 20)
        Me.dtpHasta.StyleController = Me.LayoutControl1
        Me.dtpHasta.TabIndex = 144
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.dtpHasta
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 73)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(184, 24)
        Me.LayoutControlItem9.Text = "Hasta:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(42, 13)
        '
        'frmLBBancos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(760, 202)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLBBancos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cbBancos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vBancos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Per_Detail As New VB.SysContab.PeriodoDetails
    Dim Fechas As New VB.SysContab.FechasdeOperacion

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub frmLBBancos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cbBancos.Properties.DataSource = ObtieneDatos("SP_GetCatalogoBancos " & EmpresaActual)
        cbBancos.Properties.ValueMember = "Cuenta"
        cbBancos.Properties.DisplayMember = "Nombre"
        cbBancos.Properties.PopulateViewColumns()
        FormatoGrid(vBancos)

        vBancos.Columns("Codigo").Visible = False
        vBancos.Columns("Orden").Visible = False
        vBancos.Columns("Cod").Visible = False

        cbBancos.Properties.PopupFormMinSize = New Point(900, 0)

        ' '''r.CambiarEstilo(Me)
        'ds = Bancos.GetList
        Dim Tasa As New VB.SysContab.Tasa_CambioDB

        cbMonedaCambio.DataSource = Tasa.GetListTasaCambioDisponibles().Tables("Tasa_Cambio")
        cbMonedaCambio.ValueMember = "MonedaCambio"
        cbMonedaCambio.DisplayMember = "Nombre"

        'dgBancos.DataSource = Bancos.GetListActivos().Tables("Bancos").DefaultView
        'Tabla = ds.Tables("BANCOS")
        'r.FormatGenerico(dgBancos, Tabla)
        'If ds.Tables("Bancos").Rows.Count <> 0 Then
        '    Registro = dgBancos.Item(0, 0)
        'Else
        '    Registro = "Vacio"
        'End If

        'dgBancos.CaptionText = "Información de Bancos"
        'Me.Text = "Seleccionar un Banco"

        ''***
        'If Registro <> "Vacio" Then
        '    DetalleBanco = Bancos.GetDetails(Registro)

        '    ds = Catalogo_Bancos.GetList(Registro)
        '    dgCatalogoBancos.DataSource = Catalogo_Bancos.GetList(Registro).Tables("CATALOGO_BANCOS").DefaultView
        '    Tabla = ds.Tables("CATALOGO_BANCOS")
        '    r.FormatGenerico(dgCatalogoBancos, Tabla)
        '    dgCatalogoBancos.CaptionText = "Cuentas de Banco"

        '    If Catalogo_Bancos.GetList(Registro).Tables("CATALOGO_BANCOS").Rows.Count = 0 Then
        '        CatalogoBancosP = "Vacio"
        '    Else
        '        CatalogoBancosP = dgCatalogoBancos.Item(0, 0)
        '    End If
        'End If

        ''***
        ''cbPeriodos.DataSource = Periodos.GetList().Tables("Periodos")
        ''cbPeriodos.ValueMember = "codigo"
        ''cbPeriodos.DisplayMember = "descripcion"
        'Me.chkMes.Checked = False
        'Me.ChkRango.Checked = True


        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date


        dtpDesde.Properties.MinValue = Fechas.FechaMinima
        dtpDesde.Properties.MaxValue = Fechas.FechaMaxima
        dtpHasta.Properties.MinValue = Fechas.FechaMinima
        dtpHasta.Properties.MaxValue = Fechas.FechaMaxima

        dtpDesde.DateTime = New DateTime(f.Year, f.Month, 1).Date
        dtpHasta.DateTime = UltimoDiaDelMes(f).Date

        'Dim Periodo
        'Periodo = VB.SysContab.PeriodosDB.Actual
        'If Periodo <> 0 Then
        '    Me.cbPeriodos.SelectedValue = Periodo

        '    Per_Detail = Periodos.GetDetails(Me.cbPeriodos.SelectedValue)
        '    If Per_Detail.Inicio.Year = CDate(r.Fecha).Year And Per_Detail.Inicio.Month <= CDate(r.Fecha).Month Then
        '        Me.cbMes.SelectedItem = Format(CDate(r.Fecha), "yyyy") & "-" & Format(CDate(r.Fecha), "MM")
        '    ElseIf Per_Detail.Final.Year = CDate(r.Fecha).Year And Per_Detail.Final.Month >= CDate(r.Fecha).Month Then
        '        Me.cbMes.SelectedItem = Format(CDate(r.Fecha), "yyyy") & "-" & Format(CDate(r.Fecha), "MM")
        '    Else
        '        Me.cbMes.SelectedItem = Format(Per_Detail.Inicio, "yyyy") & "-" & Format(Per_Detail.Inicio, "MM")
        '    End If
        'End If

        Me.Refresh()
    End Sub

    Private Sub frmBancos_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Opened = "NO"
    End Sub

    Private Sub dgBancos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'Registro = dgBancos.Item(dgBancos.CurrentRowIndex, 0)
        'If Registro <> "Vacio" Then
        '    DetalleBanco = Bancos.GetDetails(Registro)

        '    ds = Catalogo_Bancos.GetList(Registro)
        '    dgCatalogoBancos.DataSource = Catalogo_Bancos.GetList(Registro).Tables("CATALOGO_BANCOS").DefaultView
        '    Tabla = ds.Tables("CATALOGO_BANCOS")
        '    r.FormatGenerico(dgCatalogoBancos, Tabla)
        '    dgCatalogoBancos.CaptionText = "Cuentas de Banco"

        '    If Catalogo_Bancos.GetList(Registro).Tables("CATALOGO_BANCOS").Rows.Count = 0 Then
        '        CatalogoBancosP = "Vacio"
        '    Else
        '        CatalogoBancosP = dgCatalogoBancos.Item(0, 0)
        '    End If
        'End If
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim Bancos As New VB.SysContab.BancosDB

        'dgBancos.DataSource = Bancos.GetListBuscar(txtBuscar.Text).Tables("Bancos").DefaultView
        'If Bancos.GetListBuscar(txtBuscar.Text).Tables("Bancos").Rows.Count = 0 Then
        '    Exit Sub
        'End If
        'Registro = dgBancos.Item(dgBancos.CurrentRowIndex, 0)
        'If Registro <> "Vacio" Then
        '    DetalleBanco = Bancos.GetDetails(Registro)

        '    ds = Catalogo_Bancos.GetList(Registro)
        '    dgCatalogoBancos.DataSource = Catalogo_Bancos.GetList(Registro).Tables("CATALOGO_BANCOS").DefaultView
        '    Tabla = ds.Tables("CATALOGO_BANCOS")
        '    r.FormatGenerico(dgCatalogoBancos, Tabla)
        '    dgCatalogoBancos.CaptionText = "Cuentas de Banco"
        'End If
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'If e.KeyChar = "'" Then
        '    e.Handled = True
        'End If

    End Sub

    Private Sub cmdSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSeleccionar.Click
        If cbBancos.EditValue Is Nothing Then
            XtraMsg("Seleccione Banco")
            cbBancos.Focus()
            Exit Sub
        End If
        ''
        ShowSplash()
        Dim Cuenta As String

        Cuenta = cbBancos.EditValue  ''dgCatalogoBancos.Item(dgCatalogoBancos.CurrentRowIndex, 1)
        DEmpresa = empresa.GetDetails(EmpresaActual)
        dMoneda = Moneda.GetDetails(DEmpresa.MonedaBase)

        Dim ds As New DataSet

        'Libros.Imprimir_LibroBancos(Me.cbPeriodos.SelectedValue, _
        '                            Me.dtpDesde.Value.Date, _
        '                            Me.dtpHasta.Value.Date, _
        '                            Login, Cuenta, _
        '                            ds, _
        '                            "%", _
        '                            dMoneda.Descripcion)

        Libros.Imprimir_LibroBancos(Me.dtpDesde.DateTime.Date, Me.dtpHasta.DateTime.Date,
            Login, Cuenta, ds, Me.cbMonedaCambio.SelectedValue)

        ds.WriteXml(Application.StartupPath & "\xml\LibroBancos.xml", XmlWriteMode.WriteSchema)

        Dim fReportes As New frmReportes
        'Dim Reporte As New rptLibroBancos_V2
        Dim Reporte As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Reporte.Load(Application.StartupPath & "\Reportes\rptLibroBancos_V2.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        Reporte.Database.Tables("_LibroBancos;1").Location = Application.StartupPath & "\xml\LibroBancos.xml"
        fReportes.crvReportes.ReportSource = Reporte
        fReportes.crvReportes.Zoom(91)
        fReportes.Show()
        ''
        HideSplash()
    End Sub

    Private Sub frmBancos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        'Menu Herramientas        
    End Sub

    Private Sub txtBuscar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)

        'Menu Herramientas        

    End Sub

    Private Sub dgBancos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)

        'Menu Herramientas        

    End Sub


    Private Sub cbPeriodos_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)

        'Dim tipo As Type
        'tipo = Me.cbPeriodos.SelectedValue.GetType

        'If tipo.FullName = "System.Data.DataRowView" Then
        '    Exit Sub
        'Else
        '    'Llenar los datos del groupbox con el rango de fechas
        '    Per_Detail = Periodos.GetDetails(Me.cbPeriodos.SelectedValue)
        '    If Per_Detail.ID Is Nothing Or Per_Detail.ID = 0 Then
        '        ' MsgBox("No existe el código de Periodo Fiscal seleccionado", MsgBoxStyle.Critical)
        '        Exit Sub
        '    Else
        '        If Per_Detail.Inicio < Me.dtpDesde.MinDate Then

        '            Me.dtpDesde.MinDate = Per_Detail.Inicio.Date
        '            Me.dtpDesde.MaxDate = Per_Detail.Final.Date
        '            Me.dtpDesde.Value = Per_Detail.Inicio.Date

        '            Me.dtpHasta.MinDate = Per_Detail.Inicio.Date
        '            Me.dtpHasta.MaxDate = Per_Detail.Final.Date
        '            Me.dtpHasta.Value = Per_Detail.Final.Date
        '        Else
        '            Me.dtpDesde.MaxDate = Per_Detail.Final.Date
        '            Me.dtpDesde.MinDate = Per_Detail.Inicio.Date
        '            Me.dtpDesde.Value = Per_Detail.Inicio.Date

        '            Me.dtpHasta.MaxDate = Per_Detail.Final.Date
        '            Me.dtpHasta.MinDate = Per_Detail.Inicio.Date
        '            Me.dtpHasta.Value = Per_Detail.Final.Date
        '        End If
        '    End If
        '    'Llenar los datos de los meses del periodo
        '    Dim anio, aniofinal, i As Integer
        '    anio = Format(Per_Detail.Inicio, "yyyy") + Format(Per_Detail.Inicio, "MM")
        '    aniofinal = Format(Per_Detail.Final, "yyyy") + Format(Per_Detail.Final, "MM")
        '    i = 1
        '    Me.cbMes.Items.Clear()
        '    Do While anio <= aniofinal
        '        Me.cbMes.Items.Add(Microsoft.VisualBasic.Left(anio, 4) & "-" & Format(DateAdd(DateInterval.Month, i - 1, Per_Detail.Inicio), "MM")) 'Format(DateAdd(DateInterval.Month, i - 1, Per_Detail.Inicio), "MMMM")
        '        anio = Format(DateAdd(DateInterval.Month, i, Per_Detail.Inicio), "yyyy") + Format(DateAdd(DateInterval.Month, i, Per_Detail.Inicio), "MM")
        '        i = i + 1
        '    Loop
        '    'Me.cbMes.SelectedItem = Format(Per_Detail.Inicio, "yyyy") & "-" & Format(Per_Detail.Inicio, "MM")

        '    If Per_Detail.Inicio.Year = CDate(r.Fecha).Year And Per_Detail.Inicio.Month <= CDate(r.Fecha).Month Then
        '        Me.cbMes.SelectedItem = Format(CDate(r.Fecha), "yyyy") & "-" & Format(CDate(r.Fecha), "MM")
        '    ElseIf Per_Detail.Final.Year = CDate(r.Fecha).Year And Per_Detail.Final.Month >= CDate(r.Fecha).Month Then
        '        Me.cbMes.SelectedItem = Format(CDate(r.Fecha), "yyyy") & "-" & Format(CDate(r.Fecha), "MM")
        '    Else
        '        Me.cbMes.SelectedItem = Format(Per_Detail.Inicio, "yyyy") & "-" & Format(Per_Detail.Inicio, "MM")
        '    End If

        '    If Me.GBMes.Visible = True Then
        '        'Me.dtpDesde.Value = CDate("01/" & Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2) & "/" & Microsoft.VisualBasic.Left(Me.cbMes.SelectedItem, 4))
        '        'Me.dtpHasta.Value = CDate(Str(Meses(Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2) - 1)) & "/" & Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2) & "/" & Microsoft.VisualBasic.Left(Me.cbMes.SelectedItem, 4))
        '        Me.dtpDesde.Value = New DateTime(Microsoft.VisualBasic.Left(Me.cbMes.SelectedItem, 4), Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2), 1)
        '        Me.dtpHasta.Value = New DateTime(Microsoft.VisualBasic.Left(Me.cbMes.SelectedItem, 4), Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2), Str(Meses(Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2) - 1)))

        '    End If

        'End If
    End Sub

    Private Sub cbMes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'Me.dtpDesde.Value = New DateTime(Microsoft.VisualBasic.Left(Me.cbMes.SelectedItem, 4), Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2), 1)
        'Me.dtpHasta.Value = New DateTime(Microsoft.VisualBasic.Left(Me.cbMes.SelectedItem, 4), Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2), Str(Meses(Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2) - 1)))

    End Sub

    Private Sub chkMes_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'If Me.chkMes.Checked Then
        '    Me.GBMes.Visible = True
        '    Me.GBRango.Visible = False
        '    Me.ChkRango.Checked = False
        '    Me.dtpDesde.Value = New DateTime(Microsoft.VisualBasic.Left(Me.cbMes.SelectedItem, 4), Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2), 1)
        '    Me.dtpHasta.Value = New DateTime(Microsoft.VisualBasic.Left(Me.cbMes.SelectedItem, 4), Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2), Str(Meses(Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2) - 1)))

        'Else
        '    Me.GBMes.Visible = False
        '    Me.GBRango.Visible = True
        '    Me.ChkRango.Checked = True
        'End If
    End Sub

    Private Sub ChkRango_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'If Me.ChkRango.Checked Then
        '    Me.GBMes.Visible = False
        '    Me.GBRango.Visible = True
        '    Me.chkMes.Checked = False
        'Else
        '    Me.GBMes.Visible = True
        '    Me.GBRango.Visible = False
        '    Me.chkMes.Checked = True
        'End If
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/BancosLibro.chm")
    End Sub
End Class
