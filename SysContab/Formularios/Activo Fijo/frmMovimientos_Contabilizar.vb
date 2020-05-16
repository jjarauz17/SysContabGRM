Imports System.Data
Imports System.Data.SqlClient

Public Class frmMovimientos_Contabilizar

    Inherits DevExpress.XtraEditors.XtraForm
    Private Shared ChildInstance As frmMovimientos_Contabilizar = Nothing

    Public Shared Function Instance() As frmMovimientos_Contabilizar
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmMovimientos_Contabilizar
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

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
    Friend WithEvents dgDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents vDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdContabilizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbCatalogo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents dtpFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cbTipoComprobante As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtConcepto As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cbCuentas As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Calcu As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimientos_Contabilizar))
        Me.dgDetalle = New DevExpress.XtraGrid.GridControl()
        Me.vDetalle = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbCatalogo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.Calcu = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.cbCuentas = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdContabilizar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtConcepto = New DevExpress.XtraEditors.MemoEdit()
        Me.cbTipoComprobante = New DevExpress.XtraEditors.LookUpEdit()
        Me.dtpFecha = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Calcu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipoComprobante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgDetalle
        '
        Me.dgDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDetalle.Location = New System.Drawing.Point(12, 118)
        Me.dgDetalle.MainView = Me.vDetalle
        Me.dgDetalle.Name = "dgDetalle"
        Me.dgDetalle.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbCatalogo, Me.Calcu, Me.cbCuentas})
        Me.dgDetalle.Size = New System.Drawing.Size(960, 389)
        Me.dgDetalle.TabIndex = 0
        Me.dgDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vDetalle})
        '
        'vDetalle
        '
        Me.vDetalle.GridControl = Me.dgDetalle
        Me.vDetalle.Name = "vDetalle"
        Me.vDetalle.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.vDetalle.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vDetalle.OptionsView.ShowFooter = True
        Me.vDetalle.OptionsView.ShowGroupPanel = False
        '
        'cbCatalogo
        '
        Me.cbCatalogo.AutoHeight = False
        Me.cbCatalogo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUENTA", "", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", 200, "NOMBRE")})
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.NullText = ""
        '
        'Calcu
        '
        Me.Calcu.AutoHeight = False
        Me.Calcu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Calcu.Name = "Calcu"
        '
        'cbCuentas
        '
        Me.cbCuentas.AutoHeight = False
        Me.cbCuentas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCuentas.Name = "cbCuentas"
        Me.cbCuentas.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.ImageOptions.Image = CType(resources.GetObject("cmdSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSalir.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.cmdSalir.Location = New System.Drawing.Point(874, 511)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(98, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl1
        Me.cmdSalir.TabIndex = 1
        Me.cmdSalir.Text = "&Salir"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cmdSalir)
        Me.LayoutControl1.Controls.Add(Me.cmdContabilizar)
        Me.LayoutControl1.Controls.Add(Me.dgDetalle)
        Me.LayoutControl1.Controls.Add(Me.txtConcepto)
        Me.LayoutControl1.Controls.Add(Me.cbTipoComprobante)
        Me.LayoutControl1.Controls.Add(Me.dtpFecha)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(2487, 269, 450, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(984, 561)
        Me.LayoutControl1.TabIndex = 8
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cmdContabilizar
        '
        Me.cmdContabilizar.ImageOptions.Image = CType(resources.GetObject("cmdContabilizar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdContabilizar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.cmdContabilizar.Location = New System.Drawing.Point(762, 511)
        Me.cmdContabilizar.Name = "cmdContabilizar"
        Me.cmdContabilizar.Size = New System.Drawing.Size(108, 38)
        Me.cmdContabilizar.StyleController = Me.LayoutControl1
        Me.cmdContabilizar.TabIndex = 0
        Me.cmdContabilizar.Text = "&Contabilizar"
        '
        'txtConcepto
        '
        Me.txtConcepto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConcepto.Location = New System.Drawing.Point(122, 60)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(850, 54)
        Me.txtConcepto.StyleController = Me.LayoutControl1
        Me.txtConcepto.TabIndex = 6
        '
        'cbTipoComprobante
        '
        Me.cbTipoComprobante.Location = New System.Drawing.Point(122, 36)
        Me.cbTipoComprobante.Name = "cbTipoComprobante"
        Me.cbTipoComprobante.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipoComprobante.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TipComp_Id", "Código", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TipComp_Nombre", 200, "Tipo de Comprobante")})
        Me.cbTipoComprobante.Properties.NullText = ""
        Me.cbTipoComprobante.Size = New System.Drawing.Size(850, 20)
        Me.cbTipoComprobante.StyleController = Me.LayoutControl1
        Me.cbTipoComprobante.TabIndex = 4
        '
        'dtpFecha
        '
        Me.dtpFecha.EditValue = Nothing
        Me.dtpFecha.Location = New System.Drawing.Point(122, 12)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFecha.Size = New System.Drawing.Size(132, 20)
        Me.dtpFecha.StyleController = Me.LayoutControl1
        Me.dtpFecha.TabIndex = 2
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.EmptySpaceItem1, Me.EmptySpaceItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(984, 561)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dtpFecha
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(246, 24)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(246, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(246, 24)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Fecha:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(107, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cbTipoComprobante
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(964, 24)
        Me.LayoutControlItem2.Text = "Tipo de Comprobante:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(107, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtConcepto
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(0, 58)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(125, 58)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(964, 58)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Concepto:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(107, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.dgDetalle
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 106)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(964, 393)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmdContabilizar
        Me.LayoutControlItem5.Location = New System.Drawing.Point(750, 499)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cmdSalir
        Me.LayoutControlItem6.Location = New System.Drawing.Point(862, 499)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(246, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(718, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 499)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(750, 42)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmMovimientos_Contabilizar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmMovimientos_Contabilizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contabilizando Movimientos de Activo Fijo"
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Calcu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipoComprobante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "Variables"
    Public Tipo As Integer
    Public DetalleActivo As VB.SysContab.Activo_FijosDetails
    Public Regresar As Boolean = False
    Public Valor As Double = 0
    Public Consecutivo As Integer
#End Region

    Private Sub frmMovimientos_Contabilizar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Tipo = 0 Then
            Me.dgDetalle.Enabled = False
        End If

        RepositorySearchLook(
            cbCuentas,
            ObtieneDatos("_GetCatalogo_Cuenta", EmpresaActual),
            "Display",
            "Cuenta", 2)

        GetTipoComprobantesList(cbTipoComprobante, 0)

        'Me.cbCatalogo.DataSource =
        '    VB.SysContab.CatalogoDB.GetListBuscarComboAuxiliar("%", "%", EmpresaActual).Tables(0)
        'Me.cbCatalogo.ValueMember = "CUENTA"
        'Me.cbCatalogo.DisplayMember = "NOMBRE"

        'Me.cbTipoComprobante.Properties.DataSource = VB.SysContab.ComprobanteDB.GetTiposComprobantes(0).Tables("TipoComprobantes")
        'Me.cbTipoComprobante.Properties.ValueMember = "TipComp_Id"
        'Me.cbTipoComprobante.Properties.DisplayMember = "TipComp_Nombre"

        Dim Tabla As New DataTable
        Tabla = ObtieneDatos("Select '' as Cuenta, 0.00 as Debitos, 0.00 as Creditos, '' as Concepto, cast(0 as bit) as Modificar where 1 = 0")

        Tabla.Columns("Cuenta").AllowDBNull = False
        Tabla.Columns("Cuenta").DefaultValue = ""
        Tabla.Columns("Debitos").AllowDBNull = False
        Tabla.Columns("Debitos").DefaultValue = 0.0
        Tabla.Columns("Creditos").AllowDBNull = False
        Tabla.Columns("Creditos").DefaultValue = 0.0
        Tabla.Columns("Concepto").AllowDBNull = False
        Tabla.Columns("Concepto").DefaultValue = ""
        Tabla.Columns("Modificar").AllowDBNull = False
        Tabla.Columns("Modificar").DefaultValue = True

        Me.dgDetalle.DataSource = Tabla
        Me.vDetalle.PopulateColumns()

        Me.vDetalle.Columns("Cuenta").ColumnEdit = cbCuentas
        Me.vDetalle.Columns("Debitos").ColumnEdit = Me.Calcu
        Me.vDetalle.Columns("Creditos").ColumnEdit = Me.Calcu
        Me.vDetalle.BestFitColumns()

        If Me.Tipo = 1 Then 'Aumento
            Me.txtConcepto.Text = "Contabilizando Revalorización (+) del Activo Fijo: " & Me.DetalleActivo.Codigo & "-" & Me.DetalleActivo.Descripcion
            Me.vDetalle.OptionsBehavior.Editable = True
            Dim nRow As DataRow
            'Cuentas de Activo
            If Me.DetalleActivo.Cuenta_Activo <> "" And Me.Valor <> 0.0 Then
                nRow = Tabla.NewRow
                nRow("Cuenta") = Me.DetalleActivo.Cuenta_Activo
                nRow("Debitos") = Me.Valor
                nRow("Creditos") = 0
                nRow("Concepto") = "Valor de Revalorización (+)"
                nRow("Modificar") = False
                Tabla.Rows.Add(nRow)
            End If
        End If
        If Me.Tipo = 2 Then 'Dismunución
            Me.txtConcepto.Text = "Contabilizando Revalorización (-) del Activo Fijo: " & Me.DetalleActivo.Codigo & "-" & Me.DetalleActivo.Descripcion
            Me.vDetalle.OptionsBehavior.Editable = True
            Dim nRow As DataRow
            'Cuentas de Activo
            If Me.DetalleActivo.Cuenta_Activo <> "" And Me.Valor <> 0.0 Then
                nRow = Tabla.NewRow
                nRow("Cuenta") = Me.DetalleActivo.Cuenta_Activo
                nRow("Debitos") = 0
                nRow("Creditos") = Me.Valor
                nRow("Concepto") = "Valor de Revalorización (-)"
                nRow("Modificar") = False
                Tabla.Rows.Add(nRow)
            End If
        End If

        If Me.Tipo = 3 Then 'Venta
            Me.txtConcepto.Text = "Contabilizando Venta del Activo Fijo: " & Me.DetalleActivo.Codigo & "-" & Me.DetalleActivo.Descripcion
            Me.vDetalle.OptionsBehavior.Editable = True
            Dim nRow As DataRow
            'Cuentas de Activo
            If Me.DetalleActivo.Cuenta_Activo <> "" And Me.DetalleActivo.Precio <> 0.0 Then
                nRow = Tabla.NewRow
                nRow("Cuenta") = Me.DetalleActivo.Cuenta_Activo
                nRow("Debitos") = 0.0
                nRow("Creditos") = Me.DetalleActivo.Precio
                nRow("Concepto") = "Valor de Adquisición"
                nRow("Modificar") = False
                Tabla.Rows.Add(nRow)
            End If
            'Cuentas de Depreciacion
            If Me.DetalleActivo.Cuenta_Depreciacion <> "" And Me.DetalleActivo.Valor_Depreciado <> 0.0 Then
                nRow = Tabla.NewRow
                nRow("Cuenta") = Me.DetalleActivo.Cuenta_Depreciacion
                nRow("Debitos") = Me.DetalleActivo.Valor_Depreciado
                nRow("Creditos") = 0.0
                nRow("Concepto") = "Valor Depreciado"
                nRow("Modificar") = False
                Tabla.Rows.Add(nRow)
                nRow = Nothing
            End If
        End If
        If Me.Tipo = 4 Then 'Baja
            Me.txtConcepto.Text = "Contabilizando Baja del Activo Fijo: " & Me.DetalleActivo.Codigo & "-" & Me.DetalleActivo.Descripcion
            Me.vDetalle.OptionsBehavior.Editable = True
            Dim nRow As DataRow
            'Cuentas de Activo
            If Me.DetalleActivo.Cuenta_Activo <> "" And Me.DetalleActivo.Precio <> 0.0 Then
                nRow = Tabla.NewRow
                nRow("Cuenta") = Me.DetalleActivo.Cuenta_Activo
                nRow("Debitos") = 0.0
                nRow("Creditos") = Me.DetalleActivo.Precio
                nRow("Concepto") = "Valor de Adquisición"
                nRow("Modificar") = False
                Tabla.Rows.Add(nRow)
            End If
            'Cuentas de Depreciacion
            If Me.DetalleActivo.Cuenta_Depreciacion <> "" And Me.DetalleActivo.Valor_Depreciado <> 0.0 Then
                nRow = Tabla.NewRow
                nRow("Cuenta") = Me.DetalleActivo.Cuenta_Depreciacion
                nRow("Debitos") = Me.DetalleActivo.Valor_Depreciado
                nRow("Creditos") = 0.0
                nRow("Concepto") = "Valor Depreciado"
                nRow("Modificar") = False
                Tabla.Rows.Add(nRow)
                nRow = Nothing
            End If
            'Cuentas de Gasto
            If Me.DetalleActivo.Cuenta_Gastos <> "" And (Me.DetalleActivo.Precio - Me.DetalleActivo.Valor_Depreciado) <> 0.0 Then
                nRow = Tabla.NewRow
                nRow("Cuenta") = Me.DetalleActivo.Cuenta_Gastos
                nRow("Debitos") = (Me.DetalleActivo.Precio - Me.DetalleActivo.Valor_Depreciado)
                nRow("Creditos") = 0.0
                nRow("Concepto") = "Valor Adquisición - Valor Depreciado"
                nRow("Modificar") = False
                Tabla.Rows.Add(nRow)
                nRow = Nothing
            End If
        End If

        Me.vDetalle.Columns("Modificar").Visible = False
        Me.vDetalle.Columns("Debitos").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDetalle.Columns("Debitos").DisplayFormat.FormatString = "n2"
        Me.vDetalle.Columns("Debitos").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDetalle.Columns("Debitos").SummaryItem.DisplayFormat = "{0:n2}"

        Me.vDetalle.Columns("Creditos").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDetalle.Columns("Creditos").DisplayFormat.FormatString = "n2"
        Me.vDetalle.Columns("Creditos").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDetalle.Columns("Creditos").SummaryItem.DisplayFormat = "{0:n2}"
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdContabilizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdContabilizar.Click

        If Math.Round(Me.vDetalle.Columns("Debitos").SummaryItem.SummaryValue, 2) <> Math.Round(Me.vDetalle.Columns("Creditos").SummaryItem.SummaryValue, 2) Then
            XtraMsg("El comprobante esta descuadrado", MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.cbTipoComprobante.EditValue Is Nothing Then
            XtraMsg("Seleccione un tipo de Comprobante")
            cbTipoComprobante.Focus()
            Exit Sub
        End If

        Dim conexion As New VB.SysContab.Rutinas
        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction()

        Dim NoComprob As Double
        Try
            NoComprob =
                VB.SysContab.ComprobanteDB.AddComprobante(Me.cbTipoComprobante.EditValue,
                    1, Me.txtConcepto.Text,
                    VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MonedaBase,
                    VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.EditValue),
                    Me.dtpFecha.EditValue,
                    0, "", False, 0, "", 0, "", VB.SysContab.Rutinas.Fecha, 0, OrigenComprobantes.ACTIVO_FIJO)

            For i As Integer = 0 To Me.vDetalle.DataRowCount - 1
                Dim DC As String
                DC = IIf(Me.vDetalle.GetRowCellValue(i, "Debitos") = 0, "C", "D")
                VB.SysContab.ComprobanteDB.AddComprobanteDetalles(NoComprob,
                    Me.vDetalle.GetRowCellValue(i, "Cuenta"),
                    Me.vDetalle.GetRowCellValue(i, "Concepto"),
                    Me.vDetalle.GetRowCellValue(i, "Debitos") + Me.vDetalle.GetRowCellValue(i, "Creditos"),
                    0, Me.cbTipoComprobante.EditValue, DC, 0, 0, Me.dtpFecha.EditValue, 1)
            Next

            VB.SysContab.Activo_FijosDB.TranValor_Contabilizar(Me.Consecutivo)

            If Me.Tipo = 3 Then
                VB.SysContab.Activo_FijosDB.AF_UpdateSituacion(Me.DetalleActivo.Codigo, "V")
                'VB.SysContab.Activo_FijosDB.AF_ValorLibrosUpdate(Me.DetalleActivo.Codigo)
                'Dim dt As DataTable = ObtieneDatosTrans("SELECT isnull(sum(afd.valor_depreciacion),0) Valor FROM Activo_Fijo_Depreciacion afd WHERE afd.CODIGO_ACTIVO = '" & Me.DetalleActivo.Codigo & "'")
                'If dt.Rows.Item(0)("Valor") > 0 Then
                '    Dim mes As String = Me.dtpFecha.DateTime.Year.ToString + Me.dtpFecha.DateTime.Month.ToString
                '    GuardaDatosTrans("SET DATEFORMAT dmy; INSERT INTO Activo_Fijo_Depreciacion VALUES (" & EmpresaActual & ",'" & Me.DetalleActivo.Codigo & "','" & mes & "','" & Me.dtpFecha.DateTime.Date & "'," & dt.Rows.Item(0)("Valor") * -1 & ",1,0,0)")
                'End If
            ElseIf Me.Tipo = 4 Then
                VB.SysContab.Activo_FijosDB.AF_UpdateSituacion(Me.DetalleActivo.Codigo, "B")
            End If

            VB.SysContab.Rutinas.okTransaccion()
            'SetTiempos(Module1.OrigenComprobantes.NATURAL, funciones.Tiempos.TiempoFin, Now, funciones.Eventos.Guarda, NoComprob)

            frmMovimientos.Cargar()
            Me.Close()
        Catch Mensaje As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            'SetTiempos(Module1.OrigenComprobantes.NATURAL, funciones.Tiempos.TiempoFin, Now, funciones.Eventos.Error1, NoComprob)
            MsgBox(Mensaje.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub vDetalle_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles vDetalle.FocusedRowChanged
        'If Me.vDetalle.GetFocusedRowCellValue("Modificar") = True Or Me.vDetalle.GetFocusedRowCellValue("Modificar") Is Nothing Then
        '    Me.vDetalle.Columns("Cuenta").OptionsColumn.AllowEdit = True
        '    Me.vDetalle.Columns("Debitos").OptionsColumn.AllowEdit = True
        '    Me.vDetalle.Columns("Creditos").OptionsColumn.AllowEdit = True
        'Else
        '    Me.vDetalle.Columns("Cuenta").OptionsColumn.AllowEdit = False
        '    Me.vDetalle.Columns("Debitos").OptionsColumn.AllowEdit = False
        '    Me.vDetalle.Columns("Creditos").OptionsColumn.AllowEdit = False
        'End If
    End Sub

    Private Sub dgDetalle_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgDetalle.KeyUp
        If e.KeyCode = Keys.Delete Then
            If Me.vDetalle.GetFocusedRowCellValue("Modificar") = True Then
                Me.vDetalle.DeleteRow(Me.vDetalle.FocusedRowHandle)
            End If
        End If
    End Sub

    Private Sub vDetalle_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vDetalle.CellValueChanged
        If e.Column.FieldName = "Debitos" And Regresar = False Then
            Regresar = True
            Me.vDetalle.SetFocusedRowCellValue(Me.vDetalle.Columns("Creditos"), 0)
            Regresar = False
        ElseIf e.Column.FieldName = "Creditos" And Regresar = False Then
            Regresar = True
            Me.vDetalle.SetFocusedRowCellValue(Me.vDetalle.Columns("Debitos"), 0)
            Regresar = False
        End If
    End Sub


End Class

