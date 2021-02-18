Imports System.Linq
Imports System.Data.SqlClient
Imports SysContab.VB.SysContab
Imports DevExpress.XtraEditors
Imports ClasesBLL

Public Class frmHacerComprobantes
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmHacerComprobantes = Nothing

    Public Shared Function Instance() As frmHacerComprobantes
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmHacerComprobantes()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Dim PeriodosDB As New VB.SysContab.PeriodosDB()
    Dim CatalogoDB As New VB.SysContab.CatalogoDB()
    Dim Comprobantes As New VB.SysContab.ComprobanteDB()
    Dim Concept As New VB.SysContab.ConceptosDB()
    Dim Monedas As New VB.SysContab.MonedaDB()
    Dim Tasa As New VB.SysContab.Tasa_CambioDB()

    'Dim WithEvents Codigo1 As DataGridComboBoxColumn
    'Dim WithEvents Codigo As DataGridComboBoxColumn
    'Dim WithEvents Cuenta As DataGridComboBoxColumn
    Dim WithEvents Concepto As DataGridTextBoxColumn
    Dim WithEvents Debito As DataGridTextBoxColumn
    Dim WithEvents Credito As DataGridTextBoxColumn

    Dim ValorActualDescuento As Double
    Dim WithEvents tCust As DataTable
    Private WithEvents myDataSet As DataSet
    Dim ds As DataSet
    Dim i As Integer
    Dim Item As Integer
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtConcecutivo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckLiquidar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckDesgloce As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cbTipoLiq As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents NoOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbOrdenCompra As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbServicios As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtTasa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rMonto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbProyecto As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbOrdenesCompra As Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents txtConcepto As MemoEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyDesgloce As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyTipo As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtNoComprobante As TextEdit
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents etDiferencia As LabelControl
    Friend WithEvents etCredito As LabelControl
    Friend WithEvents etDebito As LabelControl
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Dim Fechas As New VB.SysContab.FechasdeTrabajo

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
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCalculadora As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbCatalogo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents vCatalogo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents vComprobante As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dtFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cbTipo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbMoneda As DevExpress.XtraEditors.LookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHacerComprobantes))
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.etDiferencia = New DevExpress.XtraEditors.LabelControl()
        Me.etCredito = New DevExpress.XtraEditors.LabelControl()
        Me.etDebito = New DevExpress.XtraEditors.LabelControl()
        Me.txtNoComprobante = New DevExpress.XtraEditors.TextEdit()
        Me.ckDesgloce = New DevExpress.XtraEditors.CheckEdit()
        Me.ckLiquidar = New DevExpress.XtraEditors.CheckEdit()
        Me.cbTipoLiq = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtTasa = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.txtConcecutivo = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtConcepto = New DevExpress.XtraEditors.MemoEdit()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.cbMoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbTipo = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmdCalculadora = New DevExpress.XtraEditors.SimpleButton()
        Me.dtFecha = New DevExpress.XtraEditors.DateEdit()
        Me.gridDatos = New DevExpress.XtraGrid.GridControl()
        Me.vComprobante = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbCatalogo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.vCatalogo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rMonto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NoOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbOrdenesCompra = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbServicios = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbProyecto = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyDesgloce = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyTipo = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.cbOrdenCompra = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtNoComprobante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckDesgloce.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckLiquidar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipoLiq.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConcecutivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vComprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbOrdenesCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbProyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyDesgloce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        Me.cmdAceptar.ImageOptions.Image = CType(resources.GetObject("cmdAceptar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAceptar.Location = New System.Drawing.Point(12, 461)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(106, 38)
        Me.cmdAceptar.StyleController = Me.LayoutControl1
        Me.cmdAceptar.TabIndex = 152
        Me.cmdAceptar.Text = "&Guardar"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.etDiferencia)
        Me.LayoutControl1.Controls.Add(Me.etCredito)
        Me.LayoutControl1.Controls.Add(Me.etDebito)
        Me.LayoutControl1.Controls.Add(Me.txtNoComprobante)
        Me.LayoutControl1.Controls.Add(Me.ckDesgloce)
        Me.LayoutControl1.Controls.Add(Me.ckLiquidar)
        Me.LayoutControl1.Controls.Add(Me.cbTipoLiq)
        Me.LayoutControl1.Controls.Add(Me.txtTasa)
        Me.LayoutControl1.Controls.Add(Me.cmdSalir)
        Me.LayoutControl1.Controls.Add(Me.txtConcecutivo)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.txtConcepto)
        Me.LayoutControl1.Controls.Add(Me.cmdAyuda)
        Me.LayoutControl1.Controls.Add(Me.cbMoneda)
        Me.LayoutControl1.Controls.Add(Me.cbTipo)
        Me.LayoutControl1.Controls.Add(Me.cmdCalculadora)
        Me.LayoutControl1.Controls.Add(Me.dtFecha)
        Me.LayoutControl1.Controls.Add(Me.cmdAceptar)
        Me.LayoutControl1.Controls.Add(Me.gridDatos)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(948, 261, 450, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(972, 511)
        Me.LayoutControl1.TabIndex = 1024
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'etDiferencia
        '
        Me.etDiferencia.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDiferencia.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.etDiferencia.Appearance.Options.UseFont = True
        Me.etDiferencia.Appearance.Options.UseForeColor = True
        Me.etDiferencia.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.etDiferencia.Location = New System.Drawing.Point(632, 364)
        Me.etDiferencia.Name = "etDiferencia"
        Me.etDiferencia.Size = New System.Drawing.Size(314, 18)
        Me.etDiferencia.StyleController = Me.LayoutControl1
        Me.etDiferencia.TabIndex = 1026
        Me.etDiferencia.Text = "0.00"
        '
        'etCredito
        '
        Me.etCredito.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etCredito.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.etCredito.Appearance.Options.UseFont = True
        Me.etCredito.Appearance.Options.UseForeColor = True
        Me.etCredito.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.etCredito.Location = New System.Drawing.Point(329, 364)
        Me.etCredito.Name = "etCredito"
        Me.etCredito.Size = New System.Drawing.Size(189, 18)
        Me.etCredito.StyleController = Me.LayoutControl1
        Me.etCredito.TabIndex = 1026
        Me.etCredito.Text = "0.00"
        '
        'etDebito
        '
        Me.etDebito.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDebito.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.etDebito.Appearance.Options.UseFont = True
        Me.etDebito.Appearance.Options.UseForeColor = True
        Me.etDebito.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.etDebito.Location = New System.Drawing.Point(122, 364)
        Me.etDebito.Name = "etDebito"
        Me.etDebito.Size = New System.Drawing.Size(203, 18)
        Me.etDebito.StyleController = Me.LayoutControl1
        Me.etDebito.TabIndex = 1025
        Me.etDebito.Text = "0.00"
        '
        'txtNoComprobante
        '
        Me.txtNoComprobante.Location = New System.Drawing.Point(354, 12)
        Me.txtNoComprobante.Name = "txtNoComprobante"
        Me.txtNoComprobante.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoComprobante.Properties.Appearance.Options.UseFont = True
        Me.txtNoComprobante.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNoComprobante.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoComprobante.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtNoComprobante.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtNoComprobante.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtNoComprobante.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtNoComprobante.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtNoComprobante.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtNoComprobante.Properties.MaxLength = 10
        Me.txtNoComprobante.Properties.ReadOnly = True
        Me.txtNoComprobante.Size = New System.Drawing.Size(164, 24)
        Me.txtNoComprobante.StyleController = Me.LayoutControl1
        Me.txtNoComprobante.TabIndex = 1024
        '
        'ckDesgloce
        '
        Me.ckDesgloce.Location = New System.Drawing.Point(694, 40)
        Me.ckDesgloce.Name = "ckDesgloce"
        Me.ckDesgloce.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckDesgloce.Properties.Appearance.Options.UseFont = True
        Me.ckDesgloce.Properties.Caption = "Desgloce en Litros"
        Me.ckDesgloce.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.ckDesgloce.Size = New System.Drawing.Size(128, 22)
        Me.ckDesgloce.StyleController = Me.LayoutControl1
        Me.ckDesgloce.TabIndex = 1020
        '
        'ckLiquidar
        '
        Me.ckLiquidar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckLiquidar.Location = New System.Drawing.Point(792, 12)
        Me.ckLiquidar.Name = "ckLiquidar"
        Me.ckLiquidar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckLiquidar.Properties.Appearance.Options.UseFont = True
        Me.ckLiquidar.Properties.Caption = "Agreagar a liquidación"
        Me.ckLiquidar.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.ckLiquidar.Size = New System.Drawing.Size(168, 22)
        Me.ckLiquidar.StyleController = Me.LayoutControl1
        Me.ckLiquidar.TabIndex = 1022
        Me.ckLiquidar.Visible = False
        '
        'cbTipoLiq
        '
        Me.cbTipoLiq.EditValue = "Tránsito"
        Me.cbTipoLiq.Location = New System.Drawing.Point(855, 40)
        Me.cbTipoLiq.Name = "cbTipoLiq"
        Me.cbTipoLiq.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipoLiq.Properties.Items.AddRange(New Object() {"-- Seleccione --", "Tránsito", "InBond", "Final"})
        Me.cbTipoLiq.Properties.NullText = "-- Seleccione --"
        Me.cbTipoLiq.Size = New System.Drawing.Size(105, 20)
        Me.cbTipoLiq.StyleController = Me.LayoutControl1
        Me.cbTipoLiq.TabIndex = 163
        Me.cbTipoLiq.Visible = False
        '
        'txtTasa
        '
        Me.txtTasa.EditValue = New Decimal(New Integer() {10000, 0, 0, 262144})
        Me.txtTasa.EnterMoveNextControl = True
        Me.txtTasa.Location = New System.Drawing.Point(862, 66)
        Me.txtTasa.Name = "txtTasa"
        Me.txtTasa.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtTasa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasa.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtTasa.Properties.Appearance.Options.UseBackColor = True
        Me.txtTasa.Properties.Appearance.Options.UseFont = True
        Me.txtTasa.Properties.Appearance.Options.UseForeColor = True
        Me.txtTasa.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtTasa.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasa.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtTasa.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTasa.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTasa.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTasa.Properties.Mask.EditMask = "n4"
        Me.txtTasa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTasa.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTasa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTasa.Size = New System.Drawing.Size(98, 22)
        Me.txtTasa.StyleController = Me.LayoutControl1
        Me.txtTasa.TabIndex = 1023
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.ImageOptions.Image = CType(resources.GetObject("cmdSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(854, 461)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(106, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl1
        Me.cmdSalir.TabIndex = 154
        Me.cmdSalir.Text = "&Salir"
        '
        'txtConcecutivo
        '
        Me.txtConcecutivo.Location = New System.Drawing.Point(528, 66)
        Me.txtConcecutivo.Name = "txtConcecutivo"
        Me.txtConcecutivo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtConcecutivo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConcecutivo.Properties.Appearance.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtConcecutivo.Properties.Appearance.Options.UseBackColor = True
        Me.txtConcecutivo.Properties.Appearance.Options.UseFont = True
        Me.txtConcecutivo.Properties.Appearance.Options.UseForeColor = True
        Me.txtConcecutivo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtConcecutivo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtConcecutivo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtConcecutivo.Properties.MaxLength = 50
        Me.txtConcecutivo.Size = New System.Drawing.Size(210, 22)
        Me.txtConcecutivo.StyleController = Me.LayoutControl1
        Me.txtConcecutivo.TabIndex = 1019
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.Appearance.Options.UseTextOptions = True
        Me.SimpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(744, 461)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(106, 38)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 156
        Me.SimpleButton1.Text = "&Actualizar"
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(12, 402)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(948, 55)
        Me.txtConcepto.StyleController = Me.LayoutControl1
        Me.txtConcepto.TabIndex = 1014
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Appearance.Options.UseTextOptions = True
        Me.cmdAyuda.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdAyuda.ImageOptions.Image = CType(resources.GetObject("cmdAyuda.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAyuda.Location = New System.Drawing.Point(232, 461)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(116, 38)
        Me.cmdAyuda.StyleController = Me.LayoutControl1
        Me.cmdAyuda.TabIndex = 153
        Me.cmdAyuda.Text = "&Importar Comprobante"
        '
        'cbMoneda
        '
        Me.cbMoneda.Location = New System.Drawing.Point(122, 66)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMoneda.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.cbMoneda.Properties.Appearance.Options.UseFont = True
        Me.cbMoneda.Properties.Appearance.Options.UseForeColor = True
        Me.cbMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMoneda.Properties.NullText = ""
        Me.cbMoneda.Properties.ShowFooter = False
        Me.cbMoneda.Properties.ShowHeader = False
        Me.cbMoneda.Size = New System.Drawing.Size(292, 20)
        Me.cbMoneda.StyleController = Me.LayoutControl1
        Me.cbMoneda.TabIndex = 1017
        '
        'cbTipo
        '
        Me.cbTipo.Location = New System.Drawing.Point(122, 40)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipo.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.cbTipo.Properties.Appearance.Options.UseFont = True
        Me.cbTipo.Properties.Appearance.Options.UseForeColor = True
        Me.cbTipo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipo.Properties.NullText = ""
        Me.cbTipo.Properties.ShowFooter = False
        Me.cbTipo.Properties.ShowHeader = False
        Me.cbTipo.Size = New System.Drawing.Size(568, 20)
        Me.cbTipo.StyleController = Me.LayoutControl1
        Me.cbTipo.TabIndex = 1016
        '
        'cmdCalculadora
        '
        Me.cmdCalculadora.ImageOptions.Image = CType(resources.GetObject("cmdCalculadora.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdCalculadora.Location = New System.Drawing.Point(122, 461)
        Me.cmdCalculadora.Name = "cmdCalculadora"
        Me.cmdCalculadora.Size = New System.Drawing.Size(106, 38)
        Me.cmdCalculadora.StyleController = Me.LayoutControl1
        Me.cmdCalculadora.TabIndex = 155
        Me.cmdCalculadora.Text = "Calculadora"
        '
        'dtFecha
        '
        Me.dtFecha.EditValue = New Date(2008, 12, 3, 15, 18, 58, 406)
        Me.dtFecha.Location = New System.Drawing.Point(122, 12)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dtFecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFecha.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.dtFecha.Properties.Appearance.Options.UseFont = True
        Me.dtFecha.Properties.Appearance.Options.UseForeColor = True
        Me.dtFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dtFecha.Size = New System.Drawing.Size(118, 20)
        Me.dtFecha.StyleController = Me.LayoutControl1
        Me.dtFecha.TabIndex = 1015
        '
        'gridDatos
        '
        Me.gridDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDatos.Location = New System.Drawing.Point(12, 92)
        Me.gridDatos.MainView = Me.vComprobante
        Me.gridDatos.Name = "gridDatos"
        Me.gridDatos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbCatalogo, Me.cbServicios, Me.rMonto, Me.cbProyecto, Me.cbOrdenesCompra})
        Me.gridDatos.Size = New System.Drawing.Size(948, 268)
        Me.gridDatos.TabIndex = 1013
        Me.gridDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vComprobante})
        '
        'vComprobante
        '
        Me.vComprobante.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn4, Me.GridColumn5, Me.GridColumn1, Me.NoOrden, Me.GridColumn3, Me.GridColumn6, Me.GridColumn7})
        Me.vComprobante.GridControl = Me.gridDatos
        Me.vComprobante.Name = "vComprobante"
        Me.vComprobante.OptionsCustomization.AllowColumnMoving = False
        Me.vComprobante.OptionsCustomization.AllowColumnResizing = False
        Me.vComprobante.OptionsCustomization.AllowFilter = False
        Me.vComprobante.OptionsCustomization.AllowSort = False
        Me.vComprobante.OptionsFilter.AllowFilterEditor = False
        Me.vComprobante.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.vComprobante.OptionsView.ShowFooter = True
        Me.vComprobante.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Cuenta"
        Me.GridColumn2.ColumnEdit = Me.cbCatalogo
        Me.GridColumn2.FieldName = "Cuenta"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 203
        '
        'cbCatalogo
        '
        Me.cbCatalogo.AutoHeight = False
        Me.cbCatalogo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo.DisplayMember = "Display"
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.NullText = ""
        Me.cbCatalogo.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.cbCatalogo.PopupView = Me.vCatalogo
        Me.cbCatalogo.ValueMember = "Cuenta"
        '
        'vCatalogo
        '
        Me.vCatalogo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.vCatalogo.Name = "vCatalogo"
        Me.vCatalogo.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.vCatalogo.OptionsView.ShowAutoFilterRow = True
        Me.vCatalogo.OptionsView.ShowGroupPanel = False
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Débito"
        Me.GridColumn4.ColumnEdit = Me.rMonto
        Me.GridColumn4.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "Debito"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debito", "{0:n2}")})
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 82
        '
        'rMonto
        '
        Me.rMonto.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rMonto.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rMonto.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rMonto.Appearance.Options.UseBackColor = True
        Me.rMonto.Appearance.Options.UseFont = True
        Me.rMonto.Appearance.Options.UseForeColor = True
        Me.rMonto.AutoHeight = False
        Me.rMonto.Mask.EditMask = "n2"
        Me.rMonto.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rMonto.Mask.UseMaskAsDisplayFormat = True
        Me.rMonto.Name = "rMonto"
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn5.AppearanceHeader.Options.UseFont = True
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Crédito"
        Me.GridColumn5.ColumnEdit = Me.rMonto
        Me.GridColumn5.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "Credito"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Credito", "{0:n2}")})
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 2
        Me.GridColumn5.Width = 87
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Concepto"
        Me.GridColumn1.FieldName = "Concepto"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 3
        Me.GridColumn1.Width = 158
        '
        'NoOrden
        '
        Me.NoOrden.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.NoOrden.AppearanceHeader.Options.UseFont = True
        Me.NoOrden.AppearanceHeader.Options.UseTextOptions = True
        Me.NoOrden.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NoOrden.Caption = "No. Pedido"
        Me.NoOrden.ColumnEdit = Me.cbOrdenesCompra
        Me.NoOrden.FieldName = "IdOrdenCompra"
        Me.NoOrden.Name = "NoOrden"
        Me.NoOrden.Visible = True
        Me.NoOrden.VisibleIndex = 6
        Me.NoOrden.Width = 88
        '
        'cbOrdenesCompra
        '
        Me.cbOrdenesCompra.AutoHeight = False
        Me.cbOrdenesCompra.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbOrdenesCompra.Name = "cbOrdenesCompra"
        Me.cbOrdenesCompra.PopupView = Me.GridView1
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "T/Retención"
        Me.GridColumn3.ColumnEdit = Me.cbServicios
        Me.GridColumn3.FieldName = "ret"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 7
        Me.GridColumn3.Width = 89
        '
        'cbServicios
        '
        Me.cbServicios.AutoHeight = False
        Me.cbServicios.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbServicios.Name = "cbServicios"
        Me.cbServicios.NullText = ""
        Me.cbServicios.ShowFooter = False
        Me.cbServicios.ShowHeader = False
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn6.AppearanceHeader.Options.UseFont = True
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "Proyecto"
        Me.GridColumn6.ColumnEdit = Me.cbProyecto
        Me.GridColumn6.FieldName = "IdProyecto"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 127
        '
        'cbProyecto
        '
        Me.cbProyecto.AutoHeight = False
        Me.cbProyecto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProyecto.Name = "cbProyecto"
        Me.cbProyecto.NullText = "[Proyecto]"
        Me.cbProyecto.PopupView = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn7.AppearanceHeader.Options.UseFont = True
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "No. Factura"
        Me.GridColumn7.FieldName = "Factura"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 4
        Me.GridColumn7.Width = 96
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem18, Me.LayoutControlItem19, Me.LayoutControlItem11, Me.lyDesgloce, Me.lyTipo, Me.EmptySpaceItem3})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(972, 511)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.gridDatos
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 80)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(952, 272)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtConcepto
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 374)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(0, 75)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(111, 75)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(952, 75)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Concepto:"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(107, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmdAceptar
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 449)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmdCalculadora
        Me.LayoutControlItem4.Location = New System.Drawing.Point(110, 449)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmdAyuda
        Me.LayoutControlItem5.Location = New System.Drawing.Point(220, 449)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(120, 42)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(120, 42)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(120, 42)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.SimpleButton1
        Me.LayoutControlItem6.Location = New System.Drawing.Point(732, 449)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cmdSalir
        Me.LayoutControlItem7.Location = New System.Drawing.Point(842, 449)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.dtFecha
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(232, 28)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(232, 28)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(232, 28)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.Text = "Fecha:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(107, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cbTipo
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 28)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(682, 26)
        Me.LayoutControlItem9.Text = "Tipo de Comprobante:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(107, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cbMoneda
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 54)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(406, 26)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(406, 26)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(406, 26)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.Text = "Moneda:"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(107, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtConcecutivo
        Me.LayoutControlItem12.Location = New System.Drawing.Point(406, 54)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(324, 26)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(324, 26)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(324, 26)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.Text = "No. Consecutivo:"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(107, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.ckLiquidar
        Me.LayoutControlItem13.Location = New System.Drawing.Point(780, 0)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(172, 26)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(172, 26)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(172, 28)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(340, 449)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(392, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(510, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(270, 28)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.txtNoComprobante
        Me.LayoutControlItem16.Location = New System.Drawing.Point(232, 0)
        Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(278, 28)
        Me.LayoutControlItem16.MinSize = New System.Drawing.Size(278, 28)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(278, 28)
        Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem16.Text = "No. Comprobante:"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(107, 13)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem17.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon
        Me.LayoutControlItem17.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem17.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem17.Control = Me.etDebito
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 352)
        Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(317, 22)
        Me.LayoutControlItem17.MinSize = New System.Drawing.Size(317, 22)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(317, 22)
        Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem17.Text = "Totales:"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(107, 18)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.etCredito
        Me.LayoutControlItem18.Location = New System.Drawing.Point(317, 352)
        Me.LayoutControlItem18.MaxSize = New System.Drawing.Size(193, 22)
        Me.LayoutControlItem18.MinSize = New System.Drawing.Size(193, 22)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(193, 22)
        Me.LayoutControlItem18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem19.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon
        Me.LayoutControlItem19.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem19.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem19.Control = Me.etDiferencia
        Me.LayoutControlItem19.Location = New System.Drawing.Point(510, 352)
        Me.LayoutControlItem19.MaxSize = New System.Drawing.Size(428, 22)
        Me.LayoutControlItem19.MinSize = New System.Drawing.Size(428, 22)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(442, 22)
        Me.LayoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem19.Text = "Diferencia:"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(107, 18)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txtTasa
        Me.LayoutControlItem11.Location = New System.Drawing.Point(740, 54)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(212, 26)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(212, 26)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(212, 26)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.Text = "Tasa de Cambio:"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(107, 13)
        '
        'lyDesgloce
        '
        Me.lyDesgloce.Control = Me.ckDesgloce
        Me.lyDesgloce.Location = New System.Drawing.Point(682, 28)
        Me.lyDesgloce.MaxSize = New System.Drawing.Size(132, 26)
        Me.lyDesgloce.MinSize = New System.Drawing.Size(132, 26)
        Me.lyDesgloce.Name = "lyDesgloce"
        Me.lyDesgloce.Size = New System.Drawing.Size(132, 26)
        Me.lyDesgloce.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lyDesgloce.TextSize = New System.Drawing.Size(0, 0)
        Me.lyDesgloce.TextVisible = False
        Me.lyDesgloce.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'lyTipo
        '
        Me.lyTipo.Control = Me.cbTipoLiq
        Me.lyTipo.Location = New System.Drawing.Point(814, 28)
        Me.lyTipo.MaxSize = New System.Drawing.Size(138, 26)
        Me.lyTipo.MinSize = New System.Drawing.Size(138, 26)
        Me.lyTipo.Name = "lyTipo"
        Me.lyTipo.Size = New System.Drawing.Size(138, 26)
        Me.lyTipo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lyTipo.Text = "Tipo:"
        Me.lyTipo.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.lyTipo.TextSize = New System.Drawing.Size(24, 13)
        Me.lyTipo.TextToControlDistance = 5
        Me.lyTipo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(730, 54)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'cbOrdenCompra
        '
        Me.cbOrdenCompra.AutoHeight = False
        Me.cbOrdenCompra.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbOrdenCompra.Name = "cbOrdenCompra"
        Me.cbOrdenCompra.NullText = ""
        '
        'frmHacerComprobantes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(972, 511)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmHacerComprobantes"
        Me.Text = "Hacer Comprobante"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtNoComprobante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckDesgloce.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckLiquidar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipoLiq.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConcecutivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vComprobante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbOrdenesCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbProyecto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyDesgloce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim r As New VB.SysContab.Rutinas
    Dim NoComp As Double = 0

    Private DT_Distribucion As DataTable = New DataTable("Distribucion")
    Dim _DT As New DataTable("Comprobantes")

    Private Sub Distribucion()
        'Me.DT_Distribucion = ObtieneDatos("SELECT * FROM Distribucion")
        DT_Distribucion = CargaDistribucion(0, 0, 0)
    End Sub

    Private Sub frmComprobantes_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.vComprobante.DataRowCount > 0 Then
            If CDbl(Me.vComprobante.Columns("Debito").SummaryItem.SummaryValue) = CDbl(Me.vComprobante.Columns("Credito").SummaryItem.SummaryValue) Then
                If XtraMsg2("No se han Guardado los Cambios ¿ Desea Registrarlos ?") Then
                    If Validar(1) Then
                        GuardarComprobante()
                    Else
                        e.Cancel = True
                    End If
                End If
            Else
                If XtraMsg2("El Comprobante se Encuentra Descuadrado ¿ Desea Cuadrarlo a una Cuenta Temporal ?") Then
                    If Validar(1) Then
                        My.Forms.frmShowDialog.ShowDialog()
                        If My.Forms.frmShowDialog.ok = "SI" Then
                            Dim Monto As Double = CDbl(Me.vComprobante.Columns("Debito").SummaryItem.SummaryValue) - CDbl(Me.vComprobante.Columns("Credito").SummaryItem.SummaryValue)
                            If Monto < 0 Then
                                Monto = Monto * -1
                                GuardarComprobante(My.Forms.frmShowDialog.cbCuentas.EditValue, "D", Monto)
                            Else
                                GuardarComprobante(My.Forms.frmShowDialog.cbCuentas.EditValue, "C", Monto)
                            End If
                        End If
                    Else
                        e.Cancel = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub frmComprobantes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Distribucion()
        Cargar()

        Me.Text = "Registrar Comprobante"

        Me.cbTipo.Properties.DataSource = Comprobantes.GetTiposComprobantes(0).Tables("TipoComprobantes")
        Me.cbTipo.Properties.ValueMember = "TipComp_Id"
        Me.cbTipo.Properties.DisplayMember = "TipComp_Nombre"
        Me.cbTipo.Properties.PopulateColumns()

        For i As Integer = 0 To Me.cbTipo.Properties.Columns.Count - 1
            Me.cbTipo.Properties.Columns(i).Visible = False
        Next

        Me.cbTipo.Properties.Columns(2).Visible = True
        Me.cbTipo.ItemIndex = 0

        Me.cbMoneda.Properties.DataSource = Monedas.GetList().Tables("Monedas")
        Me.cbMoneda.Properties.ValueMember = "Codigo"
        Me.cbMoneda.Properties.DisplayMember = "Descripcion"
        Me.cbMoneda.Properties.PopulateColumns()
        Me.cbMoneda.Properties.Columns(0).Visible = False

        Me.cbMoneda.EditValue = MonedaBase

        Me.dtFecha.Properties.MinValue = CDate(Fechas.FechaMinima)
        Me.dtFecha.Properties.MaxValue = CDate(Fechas.FechaMaxima)
        Me.dtFecha.DateTime = VB.SysContab.Rutinas.Fecha().Date

        Dim Periodo As Integer
        Periodo = VB.SysContab.PeriodosDB.Activo(Me.dtFecha.DateTime)

        If Periodo = 0 Then
            XtraMsg("No hay periodo activo", MessageBoxIcon.Error)
            Close()
        End If

        If MonedaBase Is Nothing Or MonedaBase Is DBNull.Value Then
            XtraMsg("El codigo de la Moneda Base de Trabajo de la empresa está en NULL", MessageBoxIcon.Error)
            Exit Sub
        End If

        'If VerifyLiqOption() Then ckLiquidar.Visible = True

        txtTasa.Text = GetTasaCambioDia(dtFecha.DateTime.Date).ToString("n4")
        txtNoComprobante.Text =
            ComprobanteDB.NuevoComprobante(dtFecha.DateTime.Date)

        'txtTasa.Text = CDbl(Tasa.TasaCambioDia(Me.dtFecha.DateTime.Day, Me.dtFecha.DateTime.Month, Me.dtFecha.DateTime.Year, MonedaBase, Me.cbMoneda.EditValue)).ToString(Round) '.Tables("Tasa_Cambio").Rows(0).Item("Cambio")
        'SetTiempos(OrigenComprobantes.NATURAL, funciones.Tiempos.TiempoInicio, Now, funciones.Eventos.Inicia, Me.lblNoComprobante.Text)
    End Sub

    Sub Cargar()
        'Me.gridDatos.DataSource = ObtieneDatos("SELECT '' as Cuenta,0.00 as Debito,0.00 as Credito,0 as NoOrden,'' as Concepto,'' ret, 0 IdProyecto, 0 IdOrdenCompra FROM Usuarios WHERE 0=1").DefaultView
        _DT = ObtieneDatos("sp_sel_ComprobantesVacio", EmpresaActual)
        gridDatos.DataSource = _DT
        CargarCatalogo()
        RepositorySearchLook(cbProyecto, db_Proyectos.Fill(), "Nombre", "IdProyecto", 0, 5, 6, 7, 8)
        RepositorySearchLook(cbOrdenesCompra, VB.SysContab.Ordenes_ComprasDB.FillComboLiquidacion(), "Orden Compra", "IdOrden", 0)
    End Sub

    Sub CargarCatalogo()

        RepositorySearchLook(
            cbCatalogo,
            ObtieneDatos("_GetCatalogo_CuentaActivo", EmpresaActual),
            "Display",
            "Cuenta",
            2)


        'Me.cbCatalogo.DataSource = ObtieneDatos("_GetCatalogo_Cuenta " & EmpresaActual).DefaultView
        'Me.cbCatalogo.ValueMember = "Cuenta"
        'Me.cbCatalogo.DisplayMember = "Display"
        'cbCatalogo.PopulateViewColumns()
        ''Me.vCatalogo.PopulateColumns()
        'FormatoGrid(Me.vCatalogo)

        'Me.vCatalogo.Columns("Display").Visible = False
        'Me.vCatalogo.Columns("Cuenta").VisibleIndex = 0
        'Me.vCatalogo.Columns("Nombre").VisibleIndex = 1
        'Me.vCatalogo.Columns("NombreCompleto").VisibleIndex = 2

        'Me.vCatalogo.BestFitColumns()

        GetServicios_Retencion(Me.cbServicios)
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        'Verificar Cierre del Día
        '---------------------------------------------------------------------
        If Not VerificarCierre(Me.dtFecha.DateTime.Date) Then
            Exit Sub
        End If
        '---------------------------------------------------------------------        

        If Validar() = True Then
            GuardarComprobante()
        End If
    End Sub


    Private Function Validar(Optional ByVal ban As Integer = 0) As Boolean

        If Me.cbTipo.ItemIndex = 0 Then
            XtraMsg("Seleccione el Tipo de Comprobante")
            Me.cbTipo.Focus()
            Return False
        End If

        If ban = 0 Then
            If Me.vComprobante.DataRowCount < 2 Then
                XtraMsg("Debe ingresar al menos dos lineas en el comprobante")
                Return False
            End If
        End If

        If ban = 0 Then
            If CDbl(Me.vComprobante.Columns("Debito").SummaryItem.SummaryValue) = 0 Then
                XtraMsg("Debe haber al menos una operación de Débito", MessageBoxIcon.Error)
                Return False
            End If
        End If

        If ban = 0 Then
            If CDbl(Me.vComprobante.Columns("Credito").SummaryItem.SummaryValue) = 0 Then
                XtraMsg("Debe haber al menos una operación de Crédito", MessageBoxIcon.Error)
                Return False
            End If
        End If

        If ban = 0 Then
            If etDiferencia.Text <> "0.00" Then
                XtraMsg("El Débito y el Crédito no estan cuadrados", MessageBoxIcon.Error)
                Exit Function
            End If

            'If Math.Round(CDbl(Me.vComprobante.Columns("Debito").SummaryItem.SummaryValue), 2) <> _
            '    Math.Round(CDbl(Me.vComprobante.Columns("Credito").SummaryItem.SummaryValue), 2) Then
            '    XtraMsg("El Débito y el Crédito no estan cuadrados", MessageBoxIcon.Error)
            '    Return False
            'End If
        End If

        If Me.txtConcepto.Text.Trim.Length = 0 Then
            XtraMsg("Describa el Concepto del Comprobante", MessageBoxIcon.Information)
            txtConcepto.Focus()
            Return False
        End If

        If ComprobanteDB.ValidarConcecutivo(txtConcecutivo.Text, cbTipo.EditValue,
                                                         dtFecha.DateTime.Month,
                                                         PeriodosDB.Activo(dtFecha.DateTime.Date)).Rows.Count > 0 Then

            XtraMsg("El Numero Consecutivo de Referencia usado para este Comprobante ya Existe", MessageBoxIcon.Error)
            txtConcecutivo.Focus()
            txtConcecutivo.SelectAll()
            Return False
        End If

        'If ObtieneDatos("SELECT * FROM Comprobantes c WHERE c.Concecutivo = '" & Me.txtConcecutivo.Text & "' AND c.Comp_Tipo =  " & Me.cbTipo.EditValue & " AND  c.Empresa = " & EmpresaActual).Rows.Count > 0 Then
        '    XtraMsg("El Numero Concecutivo de Referencia usado para este Comprobante ya Existe", MessageBoxIcon.Error)
        '    Me.txtConcecutivo.Focus()
        '    Me.txtConcecutivo.SelectAll()
        '    Return False
        'End If

        If ckLiquidar.Checked = True And cbTipoLiq.SelectedItem = Nothing Then
            XtraMsg("Favor seleccione el tipo de liquidación a asignar.", MessageBoxIcon.Error)
            Return False
        End If

        Dim OrdenSelected As Integer = 0
        For i As Integer = 0 To vComprobante.DataRowCount - 1
            If IsNull(vComprobante.GetRowCellValue(i, "NoOrden"), 0) <> 0 Then OrdenSelected += 1
        Next

        If ckLiquidar.Checked And OrdenSelected = 0 Then
            XtraMsg("Favor seleccione al menos un No. de pedido.", MessageBoxIcon.Error)
            Return False
        End If

        '******** VERIFICAR DISTRIBUCION ***********************************
        For i As Integer = 0 To Me.vComprobante.DataRowCount - 1
            Dim CTemp As String = vbNullString
            Try
                'CTemp = ObtieneDatos("SELECT CuentaContable FROM RubrosGastos WHERE Activo = 1 AND" _
                '                     + " CuentaContable = '" & Me.vComprobante.GetRowCellValue(i, "Cuenta") & "'" _
                '                     + " AND Empresa = " & EmpresaActual).Rows(0).Item(0)

                CTemp = ObtieneDatos("sp_sel_RubroGastos",
                              vComprobante.GetRowCellValue(i, "Cuenta"),
                              EmpresaActual).Rows(0).Item("CuentaContable")

            Catch ex As Exception
                CTemp = "xxx"
            End Try

            If CTemp <> "xxx" And CTemp <> vbNullString Then
                '
                If VerificaDistribucion(CTemp) = False And ObligarDistribucion = True Then
                    XtraMsg("La Cuenta " & Me.vComprobante.GetRowCellValue(i, "Cuenta").ToString & " Seleccionada es de Distribución, Favor Distribuirla " & vbCrLf &
                           "ó Verifique el Detalle de la Distribución.", MessageBoxIcon.Warning)
                    Return False
                End If
            End If
        Next
        '******** FIN VERIFICAR DISTRIBUCION *****************************
        '
        '******** VERIFICAR CUENTAS DE INGRESO ***************************
        Dim IsCuentaIngreso As Boolean = False
        Dim _dtI As DataTable =
            ObtieneDatos("sp_sel_Cuentas_Ingresos", EmpresaActual)

        If _dtI.Rows.Count > 0 Then
            For i As Integer = 0 To vComprobante.DataRowCount - 1
                If _dtI.Select("Cuenta = '" & vComprobante.GetRowCellValue(i, "Cuenta") & "'").Length > 0 Then
                    IsCuentaIngreso = True
                    Exit For
                End If
            Next
            '
            'Verificar Cierre de Bolsa
            If IsCuentaIngreso Then
                If dtFecha.DateTime.Date <= db_FACTURAS_BOLSA.UltimoCierre().Date Then
                    XtraMsg("La fecha: " & dtFecha.DateTime.ToShortDateString & " con la que intenta grabar este Diario ya fue reportada en BOLSA AGROPECUARIA, " & vbCrLf &
                            "Ultima fecha reportada al: " & db_FACTURAS_BOLSA.UltimoCierre().Date.ToShortDateString, MessageBoxIcon.Error)
                    Return False
                End If
            End If
        End If
        '******** FIN VERIFICAR CUENTAS DE INGRESO **********************

        Return True
    End Function

    Sub GuardarComprobante(Optional ByVal CuentaTemp As String = "", Optional ByVal DCtemp As String = "", Optional ByVal Monto As Double = 0)
        Dim Cuenta As String = String.Empty

        Dim DC As String = String.Empty
        Dim Importe As Decimal = 0
        Dim TCambio As Double = 1

        Try
            If Me.cbMoneda.EditValue <> MonedaBase Then
                TCambio = CDbl(Me.txtTasa.Text)
            Else
                TCambio = 1
            End If
            '    If TCambio <= 1 Then
            '        MsgBox("No Hay Tasa de Cambio Para La Fecha Señalada", MsgBoxStyle.Critical)
            '        Exit Sub
            '    End If
            'End If
        Catch ex As Exception
            'MsgBox("No Hay Tasa de Cambio Para La Fecha Señalada", MsgBoxStyle.Critical)
            'Exit Sub
        End Try

        Dim Per_Id As Integer = PeriodosDB.Activo(dtFecha.DateTime.Date)

        '----------------------------------------------------------------------
        Dim conexion As New VB.SysContab.Rutinas
        DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction()
        '----------------------------------------------------------------------

        Try
            ShowSplash("Guardando...")
            Dim NoComprob As Double =
            ComprobanteDB.AddComprobante(Me.cbTipo.EditValue, TCambio, txtConcepto.Text,
                                        Me.cbMoneda.EditValue, Per_Id,
                                        dtFecha.DateTime.Date, 0, "", False, 0, "", 0, 0, VB.SysContab.Rutinas.Fecha,
                                        0, OrigenComprobantes.NATURAL, "", 0, 0, Me.txtConcecutivo.Text, cbTipoLiq.SelectedIndex)

            With Me.vComprobante
                Try
                    For i As Integer = 0 To .DataRowCount - 1
                        Cuenta = .GetRowCellValue(i, "Cuenta")

                        If .GetRowCellValue(i, "Debito") > 0 Then
                            DC = "D"
                            Importe = .GetRowCellValue(i, "Debito") * TCambio
                        ElseIf .GetRowCellValue(i, "Credito") > 0 Then
                            DC = "C"
                            Importe = .GetRowCellValue(i, "Credito") * TCambio
                        End If

                        ComprobanteDB.AddComprobanteDetalles(NoComprob, Cuenta, .GetRowCellValue(i, "Concepto").ToString,
                                                            Math.Round(Importe, 2), 0, Me.cbTipo.EditValue, DC, IsNull(.GetRowCellValue(i, "Factura"), ""), 0,
                                                            dtFecha.DateTime.Date, 1, 0, IsNull(.GetRowCellValue(i, "ret"), ""),
                                                            IsNull(.GetRowCellValue(i, "IdProyecto"), 0),
                                                             IsNull(.GetRowCellValue(i, "IdOrdenCompra"), 0))
                    Next

                    If CuentaTemp <> "" Then
                        ComprobanteDB.AddComprobanteDetalles(NoComprob, CuentaTemp, "", Math.Round(Monto, 2), 0,
                                                            Me.cbTipo.EditValue, DCtemp, 0, 0, dtFecha.DateTime.Date,
                                                            1, 0, IsNull(.GetRowCellValue(i, "ret"), ""))
                    End If

                    HideSplash()
                Catch ex As Exception
                    XtraMsg("Hacen falta datos requeridos para guardar el comprobante, revise y vuelva a intentarlo" & vbCrLf &
                            ex.Message, MessageBoxIcon.Error)
                    Rutinas.ErrorTransaccion()
                    HideSplash()
                    Exit Sub
                End Try
            End With
            '
            Rutinas.okTransaccion()

            '----------------------
            'Guarda la Distribucion
            '----------------------
            _DT.AcceptChanges()
            Dim sCuentas = From row In _DT.AsEnumerable()
                           Select row.Field(Of String)("Cuenta") Distinct

            For Each s As Object In sCuentas
                If Not s Is Nothing Then

                    If DT_Distribucion.Select("Cuenta = '" & s & "'").Length > 0 Then
                        GuardaDistribucion(
                            DT_Distribucion.Select("Cuenta = '" & s & "'").CopyToDataTable,
                            NoComprob,
                            Per_Id,
                            dtFecha.DateTime.Month)
                    End If

                End If
            Next
            '
            Distribucion()
            '--------------------------
            'Fin de Guarda Distribucion
            '--------------------------

            'Dim DT_F As DataTable
            'DT_F = DT_Distribucion.GetChanges(DataRowState.Added Or DataRowState.Modified Or DataRowState.Deleted)
            'If Not DT_F Is Nothing Then
            '    For i = 0 To DT_F.Rows.Count - 1
            '        With DT_F
            '            If .Rows(i).RowState = DataRowState.Added Then
            '                GuardaDatos("INSERT INTO Distribucion(IdEmpresa,NoComp,Mes,Per_Id,IdRubroGasto,IdCentroCosto,Valor,Tipo,Cuenta) " &
            '                " VALUES(" & .Rows(i).Item("IdEmpresa") & "," & NoComprob & "," & Me.dtFecha.DateTime.Month & "," &
            '                VB.SysContab.PeriodosDB.Activo(Me.dtFecha.DateTime) & "," & .Rows(i).Item("IdRubroGasto") & "," & .Rows(i).Item("IdCentroCosto") & "," & .Rows(i).Item("Valor") & ",'" & .Rows(i).Item("Tipo") & "','" & .Rows(i).Item("Cuenta") & "')")
            '            ElseIf .Rows(i).RowState = DataRowState.Modified Then
            '                GuardaDatos("UPDATE Distribucion SET IdEmpresa=" & .Rows(i).Item("IdEmpresa") & ",NoComp = " & NoComprob & ",Mes=" & Me.dtFecha.DateTime.Month & "," &
            '                "Per_Id = " & VB.SysContab.PeriodosDB.Activo(Me.dtFecha.DateTime) & ",IdRubroGasto = " & .Rows(i).Item("IdRubroGasto") & ",IdCentroCosto =" & .Rows(i).Item("IdCentroCosto") & ",Valor = " & .Rows(i).Item("Valor") & "," &
            '                "Tipo='" & .Rows(i).Item("Tipo") & "',Cuenta='" & .Rows(i).Item("Cuenta") & "' WHERE IdDetalle = " & .Rows(i).Item("IdDetalle"))
            '            ElseIf .Rows(i).RowState = DataRowState.Deleted Then
            '            End If
            '        End With
            '    Next
            'End If


            'Para las liquidaciones de importacion
            'If ckLiquidar.Checked Then
            '    Dim ComprobanteID As Integer = ObtieneDatosTrans("SELECT ComprobanteID FROM Comprobantes c WHERE c.Comp_No =" & NoComprob & _
            '                                                " AND c.Empresa = " & EmpresaActual & "AND Per_ID = " & PeriodosDB.Activo(dtFecha.DateTime.Date) & _
            '                                                " AND c.Mes = " & dtFecha.DateTime.Month).Rows(0).Item(0)
            '    For j As Integer = 0 To vComprobante.DataRowCount - 1
            '        If IsNull(vComprobante.GetRowCellValue(j, "NoOrden"), 0) <> 0 Then
            '            If Not GuardaDatosTrans("SPJLiqMTAddDetalle " & vComprobante.GetRowCellValue(j, "NoOrden") & "," & 2 & "," & ComprobanteID & ",'" & vComprobante.GetRowCellValue(j, "Cuenta") & _
            '                          "'," & IIf(vComprobante.GetRowCellValue(j, "Debito") = 0, vComprobante.GetRowCellValue(j, "Credito"), vComprobante.GetRowCellValue(j, "Debito")) & _
            '                                                                   "," & ckDesgloce.Checked & "," & EmpresaActual) Then

            '                XtraMsg("ERROR al Guardar Datos de Liquidación", MessageBoxIcon.Error)
            '                VB.SysContab.Rutinas.ErrorTransaccion()
            '                Exit Sub
            '            End If
            '        End If
            '    Next
            'End If


            'SetTiempos(OrigenComprobantes.NATURAL, funciones.Tiempos.TiempoFin, Now, funciones.Eventos.Guarda, NoComprob)

            Cargar()
        Catch Mensaje As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            ' SetTiempos(OrigenComprobantes.NATURAL, funciones.Tiempos.TiempoFin, Now, funciones.Eventos.Error1, Me.lblNoComprobante.Text)
            XtraMsg(Mensaje.Message, MessageBoxIcon.Error)
            Exit Sub
        End Try


        Me.cbTipo.ItemIndex = 0
        Me.txtConcepto.Text = ""
        Me.etCredito.Text = "0.00"
        Me.etDebito.Text = "0.00"
        Me.etDiferencia.Text = "0.00"
        Me.ckLiquidar.Checked = False
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Dim DebitoMonto As Double
    Dim CreditoMonto As Double
    Dim c As Boolean

    Private Sub cmdCalculadora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculadora.Click
        Shell("C:\WINDOWS\system32\calc.exe")
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        'Help.ShowHelp(Me, "ayuda/Procesos/ProcesosComp.chm")

        With frmImportarComprobante
            .Tipo = "COMPROBANTE"
            .ShowDialog()

            If .Ok = "NO" Then
                .Dispose()
                Exit Sub
            End If

            If Not .DT Is Nothing Then
                _DT = .DT
                gridDatos.DataSource = .DT
            End If

            .Dispose()
        End With
    End Sub

    Private Sub frmComprobantes_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        ' SetTiempos(OrigenComprobantes.NATURAL, funciones.Tiempos.TiempoFin, Now, funciones.Eventos.Salir, Me.lblNoComprobante.Text)
    End Sub

    Private Sub vComprobante_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vComprobante.DoubleClick

        If Me.vComprobante.DataRowCount = 0 Then
            Exit Sub
        End If

        Dim Importe As Double = 0.00

        Try
            Dim forma As New FrmDetalleRequisas
            With Me.vComprobante
                forma.Cuenta = .GetRowCellValue(.FocusedRowHandle, "Cuenta")
                If IsDBNull(.GetRowCellValue(.FocusedRowHandle, "Debito")) OrElse IsNothing(.GetRowCellValue(.FocusedRowHandle, "Debito")) OrElse .GetRowCellValue(.FocusedRowHandle, "Debito") = Nothing OrElse .GetRowCellValue(.FocusedRowHandle, "Debito") = 0 Then

                    Importe = .GetRowCellValue(.FocusedRowHandle, "Credito")

                    If cbMoneda.EditValue <> MonedaBase Then
                        If EmpresaActual = 1 Then Importe = Math.Round(CDbl(Importe * txtTasa.EditValue), 2)
                    End If

                    forma.Monto = Importe
                    forma.Tipo = "C"
                    forma.Periodo = VB.SysContab.PeriodosDB.Activo(Me.dtFecha.DateTime)
                    forma.CompNo = NoComp
                    forma.Cuenta = .GetRowCellValue(.FocusedRowHandle, "Cuenta") '.Item(.CurrentRowIndex, 0)
                    forma.Mes = dtFecha.DateTime.Month
                Else
                    Importe = .GetRowCellValue(.FocusedRowHandle, "Debito")

                    If cbMoneda.EditValue <> MonedaBase Then
                        If EmpresaActual = 1 Then Importe = Math.Round(CDbl(Importe * txtTasa.EditValue), 2)
                    End If
                    '
                    forma.Monto = Importe
                    forma.Tipo = "D"
                    forma.Periodo = VB.SysContab.PeriodosDB.Activo(Me.dtFecha.DateTime)
                    forma.CompNo = NoComp
                    forma.Cuenta = .GetRowCellValue(.FocusedRowHandle, "Cuenta") '.Item(.CurrentRowIndex, 0)
                    forma.Mes = dtFecha.DateTime.Month

                End If

                forma.Mostrar(DT_Distribucion)
                Me.DT_Distribucion.DefaultView.RowFilter = ""
            End With
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub vComprobante_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vComprobante.CellValueChanged
        Try
            With Me.vComprobante

                If e.Column.FieldName = "Cuenta" Then

                    Dim Auxiliar As String = ObtieneDatos("sp_get_Cuentas_Auxiliares",
                                                          vComprobante.GetRowCellValue(vComprobante.FocusedRowHandle, "Cuenta"),
                                                          EmpresaActual).Rows.Item(0)("Auxiliar")

                    If Auxiliar <> "" Then
                        If Not XtraMsg2("Esta cuenta es de " & Auxiliar & vbCrLf &
                            "Esta Seguro de Utilizarla ?") Then
                            vComprobante.DeleteSelectedRows()
                            Exit Sub
                        End If

                    End If


                    If IsDBNull(.GetRowCellValue(e.RowHandle, "Debito")) Then
                        .SetRowCellValue(e.RowHandle, "Debito", 0.0)
                    End If

                    If IsDBNull(.GetRowCellValue(e.RowHandle, "Credito")) Then
                        .SetRowCellValue(e.RowHandle, "Credito", 0.0)
                    End If
                End If

                If e.Column.FieldName = "Debito" Then
                    If .GetRowCellValue(e.RowHandle, "Debito") > 0 Then
                        .SetRowCellValue(e.RowHandle, "Credito", 0.0)
                    End If
                End If

                If e.Column.FieldName = "Credito" Then
                    If .GetRowCellValue(e.RowHandle, "Credito") > 0 Then
                        .SetRowCellValue(e.RowHandle, "Debito", 0.0)
                    End If
                End If

                .UpdateTotalSummary()

                Calcular()
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub vComprobante_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vComprobante.KeyDown
        If Me.vComprobante.DataRowCount = 0 Then
            Exit Sub
        End If

        If e.KeyCode = Keys.Delete Then
            Me.vComprobante.DeleteSelectedRows()
            Calcular()
        End If
    End Sub

    Private Sub vComprobante_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles vComprobante.RowUpdated
        Calcular()
        CargarCatalogo()
    End Sub

    Sub Calcular()
        Try
            With Me.vComprobante
                Me.etDebito.Text = CDbl(.Columns("Debito").SummaryItem.SummaryValue).ToString(Round)
                Me.etCredito.Text = CDbl(.Columns("Credito").SummaryItem.SummaryValue).ToString(Round)
                Me.etDiferencia.Text = (CDbl(.Columns("Debito").SummaryItem.SummaryValue) - CDbl(.Columns("Credito").SummaryItem.SummaryValue)).ToString(Round)
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbMoneda_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMoneda.EditValueChanged
        Try
            'txtTasa.EditValue =
            'CDbl(Tasa.TasaCambioDia(Me.dtFecha.DateTime.Day, Me.dtFecha.DateTime.Month, Me.dtFecha.DateTime.Year, MonedaBase, Me.cbMoneda.EditValue)).ToString("n4") '.Tables("Tasa_Cambio").Rows(0).Item("Cambio")
            txtTasa.Text = GetTasaCambioDia(dtFecha.DateTime.Date).ToString("n4")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dtFecha_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtFecha.EditValueChanged
        Try
            'txtTasa.Text =
            'CDbl(Tasa.TasaCambioDia(Me.dtFecha.DateTime.Day, Me.dtFecha.DateTime.Month, Me.dtFecha.DateTime.Year, MonedaBase, Me.cbMoneda.EditValue)).ToString("n4") '.Tables("Tasa_Cambio").Rows(0).Item("Cambio")
            txtTasa.Text =
                GetTasaCambioDia(dtFecha.DateTime.Date).ToString("n4")

            txtNoComprobante.Text =
                ComprobanteDB.NuevoComprobante(dtFecha.DateTime.Date)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.cbCatalogo.DataSource = funciones.ObtieneDatos("_GetCatalogo_CuentaActivo " & EmpresaActual).DefaultView
    End Sub

    Private Sub cbTipo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipo.EditValueChanged
        Try
            Me.txtConcecutivo.Text = CInt(ObtieneDatos("SELECT max(tc.Concectivo) Concectivo FROM TipoComprobantes tc WHERE tc.TipComp_Id = " & Me.cbTipo.EditValue & " AND tc.Empresa = " & EmpresaActual).Rows.Item(0)("Concectivo"))
        Catch ex As Exception
            Me.txtConcecutivo.Text = ""
        End Try
    End Sub

    Private Sub ckLiquidar_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ckLiquidar.CheckedChanged, ckDesgloce.CheckedChanged
        If ckLiquidar.Checked Then
            lyDesgloce.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            lyTipo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            'gbLiquidacion.Visible = True
            'vComprobante.Columns("NoOrden").Visible = True : vComprobante.Columns("NoOrden").VisibleIndex = 3
            cbTipo_EditValueChanged(Nothing, Nothing)
        Else
            lyDesgloce.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            lyTipo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            'gbLiquidacion.Visible = False
            'vComprobante.Columns("NoOrden").Visible = False
        End If
    End Sub

    Private Sub cbTipoLiq_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoLiq.SelectedIndexChanged
        'If cbTipoLiq.SelectedIndex = 1 Then
        '    cbOrdenCompra.Properties.DataSource = ObtieneDatos("SPJLiqcbTipo " & 1 & "," & EmpresaActual)
        'ElseIf cbTipoLiq.SelectedIndex = 2 Then
        '    cbOrdenCompra.Properties.DataSource = ObtieneDatos("SPJLiqcbTipo " & 2 & "," & EmpresaActual)
        'Else
        '    cbOrdenCompra.Properties.DataSource = ObtieneDatos("SPJLiqcbTipo " & 3 & "," & EmpresaActual)
        'End If
        'cbOrdenCompra.Properties.DisplayMember = "NoOrden"
        'cbOrdenCompra.Properties.ValueMember = "LiqID"
        'cbOrdenCompra.PopulateColumns()
        'cbOrdenCompra.Properties.Columns(0).Visible = False
        'End If
    End Sub

    Private Function VerificaDistribucion(ByVal Cuenta As String) As Boolean
        Dim tmp As Boolean = False

        If DT_Distribucion Is Nothing Then
            Return False
        End If

        For i As Integer = 0 To DT_Distribucion.Rows.Count - 1
            If Cuenta = DT_Distribucion.Rows(i).Item("Cuenta") Then
                tmp = True
                Exit For
            End If
        Next

        Return tmp
    End Function

    Private Sub vComprobante_ShowingEditor(sender As Object, e As ComponentModel.CancelEventArgs) Handles vComprobante.ShowingEditor
        'If vComprobante.FocusedRowHandle < 0 Then Exit Sub

        'Try

        '    Dim Auxiliar As String = ObtieneDatos("sp_get_Cuentas_Auxiliares", vComprobante.GetRowCellValue(vComprobante.FocusedRowHandle, "Cuenta"), EmpresaActual).Rows.Item(0)("Auxiliar")

        '    If Auxiliar <> "" Then
        '        If Not XtraMsg2("Esta cuenta es de " & Auxiliar & vbCrLf & _
        '            "Esta Seguro de Utilizarla ?") Then
        '            e.Cancel = True
        '        End If

        '        'e.ErrorText = "Esta cuenta es de " & Auxiliar & vbCrLf & _
        '        '                    "Esta Seguro de Utilizarla ?"
        '        'e.Valid = False
        '    End If
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub vComprobante_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles vComprobante.ValidateRow
        'Dim Auxiliar As String = ObtieneDatos("sp_get_Cuentas_Auxiliares", vComprobante.GetRowCellValue(e.RowHandle, "Cuenta"), EmpresaActual).Rows.Item(0)("Auxiliar")
        'If Auxiliar <> "" Then

        '    e.ErrorText = "Esta cuenta es de " & Auxiliar & vbCrLf & _
        '                        "Esta Seguro de Utilizarla ?"

        '    e.Valid = False
        '    'If Not XtraMsg2("Esta cuenta es de " & Auxiliar & vbCrLf & _
        '    '"Esta Seguro de Utilizarla ?") Then
        '    '    e.Valid = False
        '    'End If
        'End If
    End Sub

    Private Sub vComprobante_ValidatingEditor(sender As Object, e As Controls.BaseContainerValidateEditorEventArgs) Handles vComprobante.ValidatingEditor
        'Dim Auxiliar As String = ObtieneDatos("sp_get_Cuentas_Auxiliares", vComprobante.GetRowCellValue(vComprobante.FocusedRowHandle, "Cuenta"), EmpresaActual).Rows.Item(0)("Auxiliar")

        'If Auxiliar <> "" Then
        '    e.ErrorText = "Esta cuenta es de " & Auxiliar & vbCrLf & _
        '                        "Esta Seguro de Utilizarla ?"
        '    e.Valid = False
        'End If
    End Sub
End Class

