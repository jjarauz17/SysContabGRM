Imports System.Data.SqlClient
Imports System.Drawing
Imports DevExpress.XtraPrinting
Imports System.IO

Public Class frmLiquidacionAdd
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmLiquidacionAdd = Nothing

    Public Shared Function Instance() As frmLiquidacionAdd
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmLiquidacionAdd
        End If
        ChildInstance.BringToFront()
        Return ChildInstance
    End Function

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbProveedor As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbFactura As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tbValorFob As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tbTC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lArticulo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents tbGranTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tbTotalFOB As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tbFlete As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tbCIF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbFlete As System.Windows.Forms.Label
    Friend WithEvents lbCIF As System.Windows.Forms.Label
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ckTax As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lGastos As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lPagos As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbFlete1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tbBultos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tbBultosLiq As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Nombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Monto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Porcentaje As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LiqDetImpuestoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ckSelectData As DevExpress.XtraEditors.CheckEdit
    'Friend WithEvents LiqID As System.Windows.Forms.Label
    Friend WithEvents tbCuenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tbRecibo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tbPoliza As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtFechaLiq As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LiqID3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LiqID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LiqDetGastoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbLiqNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Desgloce As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tbAnifoda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents LiqDetalleID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents LiqID1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Articulo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Descuento As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents CantidadCaja As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Bonificados As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Cantidad As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Saldo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ValorFob As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents TotalFOB1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents TotalFOB2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents TotalFlete As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents TotalCIF As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents PagoMifin As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents PagoDAI As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents PagoISC As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents PagoIVA As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents TotalGastos As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents CostoBodega As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Costo1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Costo2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents PrecioVenta As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Margen As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Costo3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Exento As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Moneda As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Modified As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ALiquidar As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents IDFactura As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents DatosArticulo As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents UM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents Anifoda As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmdAnifoda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmAnifoda As System.Windows.Forms.ContextMenu
    Friend WithEvents AnifodaCalc As System.Windows.Forms.MenuItem
    Friend WithEvents AnifodaPrint As System.Windows.Forms.MenuItem
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents dtBodega As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tbPedido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLiquidacionAdd))
        Me.Label7 = New System.Windows.Forms.Label
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.DatosArticulo = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.ALiquidar = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Articulo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.lArticulo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.UM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Cantidad = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.ValorFob = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.TotalFOB1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.TotalFOB2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.TotalCIF = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Anifoda = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.TotalGastos = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Costo3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.CostoBodega = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.Costo1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Costo2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.LiqDetalleID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.LiqID1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Descuento = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.CantidadCaja = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Bonificados = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Saldo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.TotalFlete = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.PagoMifin = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.PagoDAI = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.PagoISC = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.PagoIVA = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.PrecioVenta = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Margen = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Exento = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Moneda = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Modified = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.IDFactura = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbProveedor = New DevExpress.XtraEditors.LookUpEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbFactura = New DevExpress.XtraEditors.TextEdit
        Me.tbValorFob = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.tbCuenta = New DevExpress.XtraEditors.TextEdit
        Me.tbTC = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.tbRecibo = New DevExpress.XtraEditors.TextEdit
        Me.Label16 = New System.Windows.Forms.Label
        Me.tbPoliza = New DevExpress.XtraEditors.TextEdit
        Me.Label15 = New System.Windows.Forms.Label
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.tbGranTotal = New DevExpress.XtraEditors.TextEdit
        Me.tbTotalFOB = New DevExpress.XtraEditors.TextEdit
        Me.tbFlete = New DevExpress.XtraEditors.TextEdit
        Me.tbCIF = New DevExpress.XtraEditors.TextEdit
        Me.lbFlete = New System.Windows.Forms.Label
        Me.lbCIF = New System.Windows.Forms.Label
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.Label13 = New System.Windows.Forms.Label
        Me.dtBodega = New DevExpress.XtraEditors.DateEdit
        Me.tbAnifoda = New DevExpress.XtraEditors.TextEdit
        Me.tbLiqNo = New DevExpress.XtraEditors.TextEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.dtFechaLiq = New DevExpress.XtraEditors.DateEdit
        Me.tbBultosLiq = New DevExpress.XtraEditors.TextEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.tbBultos = New DevExpress.XtraEditors.TextEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.tbFlete1 = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LiqDetImpuestoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LiqID2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nombre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lPagos = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Monto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Porcentaje = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LiqDetGastoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lGastos = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LiqID3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Desgloce = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ckTax = New DevExpress.XtraEditors.CheckEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.tbPedido = New DevExpress.XtraEditors.TextEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.ckSelectData = New DevExpress.XtraEditors.CheckEdit
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImportar = New DevExpress.XtraEditors.SimpleButton
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.cmdAnifoda = New DevExpress.XtraEditors.SimpleButton
        Me.cmAnifoda = New System.Windows.Forms.ContextMenu
        Me.AnifodaCalc = New System.Windows.Forms.MenuItem
        Me.AnifodaPrint = New System.Windows.Forms.MenuItem
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbValorFob.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbTC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbRecibo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbPoliza.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbGranTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbTotalFOB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFlete.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbCIF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.dtBodega.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBodega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbAnifoda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbLiqNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaLiq.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaLiq.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbBultosLiq.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbBultos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFlete1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckTax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbPedido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.ckSelectData.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(8, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Cuenta de Reg.  Nº."
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(-1, 0)
        Me.GridControl1.LookAndFeel.UseWindowsXPTheme = True
        Me.GridControl1.MainView = Me.BandedGridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lArticulo})
        Me.GridControl1.Size = New System.Drawing.Size(994, 399)
        Me.GridControl1.TabIndex = 17
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView1})
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Appearance.BandPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView1.Appearance.BandPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BandedGridView1.Appearance.BandPanel.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.BandPanel.Options.UseFont = True
        Me.BandedGridView1.Appearance.BandPanel.Options.UseTextOptions = True
        Me.BandedGridView1.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridView1.Appearance.BandPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.BandedGridView1.Appearance.BandPanelBackground.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView1.Appearance.BandPanelBackground.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.BandedGridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.BandedGridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.BandedGridView1.Appearance.Preview.Options.UseTextOptions = True
        Me.BandedGridView1.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.BandedGridView1.AppearancePrint.HeaderPanel.Options.UseTextOptions = True
        Me.BandedGridView1.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridView1.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.DatosArticulo, Me.GridBand1, Me.GridBand2})
        Me.BandedGridView1.ColumnPanelRowHeight = 55
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.LiqDetalleID, Me.LiqID1, Me.Articulo, Me.Descuento, Me.CantidadCaja, Me.Bonificados, Me.Cantidad, Me.Saldo, Me.ValorFob, Me.TotalFOB1, Me.TotalFOB2, Me.TotalFlete, Me.TotalCIF, Me.PagoMifin, Me.PagoDAI, Me.PagoISC, Me.PagoIVA, Me.TotalGastos, Me.CostoBodega, Me.Costo1, Me.Costo2, Me.PrecioVenta, Me.Margen, Me.Costo3, Me.Exento, Me.Moneda, Me.Modified, Me.ALiquidar, Me.IDFactura, Me.UM, Me.Anifoda})
        Me.BandedGridView1.GridControl = Me.GridControl1
        Me.BandedGridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.BandedGridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", Nothing, "")})
        Me.BandedGridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsCustomization.AllowColumnMoving = False
        Me.BandedGridView1.OptionsCustomization.AllowColumnResizing = False
        Me.BandedGridView1.OptionsPrint.ExpandAllDetails = True
        Me.BandedGridView1.OptionsPrint.PrintDetails = True
        Me.BandedGridView1.OptionsPrint.PrintFilterInfo = True
        Me.BandedGridView1.OptionsPrint.UsePrintStyles = True
        Me.BandedGridView1.OptionsView.ColumnAutoWidth = False
        Me.BandedGridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.BandedGridView1.OptionsView.ShowFooter = True
        Me.BandedGridView1.OptionsView.ShowGroupPanel = False
        '
        'DatosArticulo
        '
        Me.DatosArticulo.Caption = "DATOS DEL ARTICULO"
        Me.DatosArticulo.Columns.Add(Me.ALiquidar)
        Me.DatosArticulo.Columns.Add(Me.Articulo)
        Me.DatosArticulo.Columns.Add(Me.UM)
        Me.DatosArticulo.Columns.Add(Me.Cantidad)
        Me.DatosArticulo.Columns.Add(Me.ValorFob)
        Me.DatosArticulo.Name = "DatosArticulo"
        Me.DatosArticulo.Width = 418
        '
        'ALiquidar
        '
        Me.ALiquidar.Caption = "ALiquidar"
        Me.ALiquidar.FieldName = "ALiquidar"
        Me.ALiquidar.Name = "ALiquidar"
        Me.ALiquidar.OptionsColumn.AllowSize = False
        Me.ALiquidar.Width = 27
        '
        'Articulo
        '
        Me.Articulo.AppearanceHeader.Options.UseTextOptions = True
        Me.Articulo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.Articulo.Caption = "Artículo"
        Me.Articulo.ColumnEdit = Me.lArticulo
        Me.Articulo.FieldName = "ArticuloID"
        Me.Articulo.Name = "Articulo"
        Me.Articulo.OptionsColumn.AllowEdit = False
        Me.Articulo.SummaryItem.DisplayFormat = "{0:n0}"
        Me.Articulo.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.Articulo.Visible = True
        Me.Articulo.Width = 170
        '
        'lArticulo
        '
        Me.lArticulo.AutoHeight = False
        Me.lArticulo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing)})
        Me.lArticulo.DropDownRows = 10
        Me.lArticulo.HeaderClickMode = DevExpress.XtraEditors.Controls.HeaderClickMode.AutoSearch
        Me.lArticulo.Name = "lArticulo"
        Me.lArticulo.NullText = ""
        Me.lArticulo.PopupWidth = 350
        Me.lArticulo.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        '
        'UM
        '
        Me.UM.AppearanceHeader.Options.UseTextOptions = True
        Me.UM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.UM.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.UM.Caption = "Unidad de Medida"
        Me.UM.FieldName = "UM"
        Me.UM.Name = "UM"
        Me.UM.OptionsColumn.AllowEdit = False
        Me.UM.Visible = True
        Me.UM.Width = 74
        '
        'Cantidad
        '
        Me.Cantidad.AppearanceCell.Options.UseTextOptions = True
        Me.Cantidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Cantidad.AppearanceHeader.Options.UseTextOptions = True
        Me.Cantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Cantidad.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.Cantidad.Caption = "Unidades Solicitadas"
        Me.Cantidad.DisplayFormat.FormatString = "n2"
        Me.Cantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Cantidad.FieldName = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.OptionsColumn.AllowEdit = False
        Me.Cantidad.OptionsColumn.AllowSize = False
        Me.Cantidad.SummaryItem.DisplayFormat = "{0:n2}"
        Me.Cantidad.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Cantidad.Visible = True
        Me.Cantidad.Width = 74
        '
        'ValorFob
        '
        Me.ValorFob.AppearanceCell.Options.UseTextOptions = True
        Me.ValorFob.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ValorFob.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.ValorFob.AppearanceHeader.Options.UseTextOptions = True
        Me.ValorFob.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ValorFob.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ValorFob.Caption = "Valor FOB US$"
        Me.ValorFob.DisplayFormat.FormatString = "n6"
        Me.ValorFob.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ValorFob.FieldName = "ValorFob"
        Me.ValorFob.Name = "ValorFob"
        Me.ValorFob.OptionsColumn.AllowEdit = False
        Me.ValorFob.OptionsColumn.AllowSize = False
        Me.ValorFob.Visible = True
        Me.ValorFob.Width = 100
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "CALCULOS DE COSTO TOTAL"
        Me.GridBand1.Columns.Add(Me.TotalFOB1)
        Me.GridBand1.Columns.Add(Me.TotalFOB2)
        Me.GridBand1.Columns.Add(Me.TotalCIF)
        Me.GridBand1.Columns.Add(Me.Anifoda)
        Me.GridBand1.Columns.Add(Me.TotalGastos)
        Me.GridBand1.Columns.Add(Me.Costo3)
        Me.GridBand1.Columns.Add(Me.CostoBodega)
        Me.GridBand1.MinWidth = 20
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 500
        '
        'TotalFOB1
        '
        Me.TotalFOB1.AppearanceCell.Options.UseTextOptions = True
        Me.TotalFOB1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TotalFOB1.AppearanceHeader.Options.UseTextOptions = True
        Me.TotalFOB1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TotalFOB1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TotalFOB1.Caption = "FOB $"
        Me.TotalFOB1.DisplayFormat.FormatString = "n6"
        Me.TotalFOB1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TotalFOB1.FieldName = "TotalFOB1"
        Me.TotalFOB1.Name = "TotalFOB1"
        Me.TotalFOB1.OptionsColumn.AllowEdit = False
        Me.TotalFOB1.OptionsColumn.AllowSize = False
        Me.TotalFOB1.SummaryItem.DisplayFormat = "{0:n2}"
        Me.TotalFOB1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.TotalFOB1.Visible = True
        Me.TotalFOB1.Width = 100
        '
        'TotalFOB2
        '
        Me.TotalFOB2.AppearanceCell.Options.UseTextOptions = True
        Me.TotalFOB2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TotalFOB2.AppearanceHeader.Options.UseTextOptions = True
        Me.TotalFOB2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TotalFOB2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TotalFOB2.Caption = "FOB C$"
        Me.TotalFOB2.DisplayFormat.FormatString = "n6"
        Me.TotalFOB2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TotalFOB2.FieldName = "TotalFOB2"
        Me.TotalFOB2.Name = "TotalFOB2"
        Me.TotalFOB2.OptionsColumn.AllowEdit = False
        Me.TotalFOB2.OptionsColumn.AllowSize = False
        Me.TotalFOB2.SummaryItem.DisplayFormat = "{0:n2}"
        Me.TotalFOB2.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.TotalFOB2.Visible = True
        Me.TotalFOB2.Width = 100
        '
        'TotalCIF
        '
        Me.TotalCIF.AppearanceCell.Options.UseTextOptions = True
        Me.TotalCIF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TotalCIF.AppearanceHeader.Options.UseTextOptions = True
        Me.TotalCIF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TotalCIF.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TotalCIF.Caption = "CIF C$"
        Me.TotalCIF.DisplayFormat.FormatString = "n6"
        Me.TotalCIF.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TotalCIF.FieldName = "TotalCIF"
        Me.TotalCIF.Name = "TotalCIF"
        Me.TotalCIF.OptionsColumn.AllowEdit = False
        Me.TotalCIF.OptionsColumn.AllowSize = False
        Me.TotalCIF.SummaryItem.DisplayFormat = "{0:n2}"
        Me.TotalCIF.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.TotalCIF.Visible = True
        Me.TotalCIF.Width = 100
        '
        'Anifoda
        '
        Me.Anifoda.AppearanceCell.Options.UseTextOptions = True
        Me.Anifoda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Anifoda.Caption = "Anifoda"
        Me.Anifoda.DisplayFormat.FormatString = "n6"
        Me.Anifoda.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Anifoda.FieldName = "Anifoda"
        Me.Anifoda.Name = "Anifoda"
        Me.Anifoda.SummaryItem.DisplayFormat = "{0:n2}"
        Me.Anifoda.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Anifoda.Width = 110
        '
        'TotalGastos
        '
        Me.TotalGastos.AppearanceCell.Options.UseTextOptions = True
        Me.TotalGastos.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TotalGastos.AppearanceHeader.Options.UseTextOptions = True
        Me.TotalGastos.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TotalGastos.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TotalGastos.Caption = "Total Gastos"
        Me.TotalGastos.DisplayFormat.FormatString = "n6"
        Me.TotalGastos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TotalGastos.FieldName = "TotalGastos"
        Me.TotalGastos.Name = "TotalGastos"
        Me.TotalGastos.OptionsColumn.AllowEdit = False
        Me.TotalGastos.OptionsColumn.AllowSize = False
        Me.TotalGastos.SummaryItem.DisplayFormat = "{0:n2}"
        Me.TotalGastos.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.TotalGastos.Visible = True
        Me.TotalGastos.Width = 100
        '
        'Costo3
        '
        Me.Costo3.AppearanceHeader.Options.UseTextOptions = True
        Me.Costo3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Costo3.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.Costo3.Caption = "Costo Total Bodega"
        Me.Costo3.DisplayFormat.FormatString = "n2"
        Me.Costo3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Costo3.FieldName = "Costo3"
        Me.Costo3.Name = "Costo3"
        Me.Costo3.OptionsColumn.AllowEdit = False
        Me.Costo3.OptionsColumn.AllowSize = False
        Me.Costo3.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Costo3.Width = 81
        '
        'CostoBodega
        '
        Me.CostoBodega.AppearanceCell.Options.UseTextOptions = True
        Me.CostoBodega.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CostoBodega.AppearanceHeader.Options.UseTextOptions = True
        Me.CostoBodega.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CostoBodega.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.CostoBodega.Caption = "Bodega C$"
        Me.CostoBodega.DisplayFormat.FormatString = "n6"
        Me.CostoBodega.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CostoBodega.FieldName = "CostoBodega"
        Me.CostoBodega.Name = "CostoBodega"
        Me.CostoBodega.OptionsColumn.AllowEdit = False
        Me.CostoBodega.OptionsColumn.AllowSize = False
        Me.CostoBodega.SummaryItem.DisplayFormat = "{0:n2}"
        Me.CostoBodega.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.CostoBodega.Visible = True
        Me.CostoBodega.Width = 100
        '
        'GridBand2
        '
        Me.GridBand2.Caption = "COSTOS UNITARIOS"
        Me.GridBand2.Columns.Add(Me.Costo1)
        Me.GridBand2.Columns.Add(Me.Costo2)
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.Width = 200
        '
        'Costo1
        '
        Me.Costo1.AppearanceCell.Options.UseTextOptions = True
        Me.Costo1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Costo1.AppearanceHeader.Options.UseTextOptions = True
        Me.Costo1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Costo1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.Costo1.Caption = "Bodega C$"
        Me.Costo1.DisplayFormat.FormatString = "n6"
        Me.Costo1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Costo1.FieldName = "Costo1"
        Me.Costo1.Name = "Costo1"
        Me.Costo1.OptionsColumn.AllowEdit = False
        Me.Costo1.OptionsColumn.AllowSize = False
        Me.Costo1.SummaryItem.DisplayFormat = "{0:n2}"
        Me.Costo1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Costo1.Visible = True
        Me.Costo1.Width = 100
        '
        'Costo2
        '
        Me.Costo2.AppearanceCell.Options.UseTextOptions = True
        Me.Costo2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Costo2.AppearanceHeader.Options.UseTextOptions = True
        Me.Costo2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Costo2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.Costo2.Caption = "Bodega US$"
        Me.Costo2.DisplayFormat.FormatString = "n6"
        Me.Costo2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Costo2.FieldName = "Costo2"
        Me.Costo2.Name = "Costo2"
        Me.Costo2.OptionsColumn.AllowEdit = False
        Me.Costo2.OptionsColumn.AllowSize = False
        Me.Costo2.Visible = True
        Me.Costo2.Width = 100
        '
        'LiqDetalleID
        '
        Me.LiqDetalleID.Caption = "LiqDetalleID"
        Me.LiqDetalleID.FieldName = "LiqDetalleID"
        Me.LiqDetalleID.Name = "LiqDetalleID"
        Me.LiqDetalleID.OptionsColumn.AllowEdit = False
        Me.LiqDetalleID.Width = 27
        '
        'LiqID1
        '
        Me.LiqID1.Caption = "LiqID"
        Me.LiqID1.FieldName = "LiqID"
        Me.LiqID1.Name = "LiqID1"
        Me.LiqID1.Width = 27
        '
        'Descuento
        '
        Me.Descuento.AppearanceCell.Options.UseTextOptions = True
        Me.Descuento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Descuento.AppearanceHeader.Options.UseTextOptions = True
        Me.Descuento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Descuento.Caption = "Descuento"
        Me.Descuento.DisplayFormat.FormatString = "P2"
        Me.Descuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Descuento.FieldName = "Descuento"
        Me.Descuento.Name = "Descuento"
        Me.Descuento.Width = 27
        '
        'CantidadCaja
        '
        Me.CantidadCaja.AppearanceCell.Options.UseTextOptions = True
        Me.CantidadCaja.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CantidadCaja.AppearanceHeader.Options.UseTextOptions = True
        Me.CantidadCaja.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CantidadCaja.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.CantidadCaja.Caption = "Cantidad   por Caja"
        Me.CantidadCaja.FieldName = "CantidadCaja"
        Me.CantidadCaja.Name = "CantidadCaja"
        Me.CantidadCaja.OptionsColumn.AllowEdit = False
        Me.CantidadCaja.OptionsColumn.AllowSize = False
        Me.CantidadCaja.Width = 41
        '
        'Bonificados
        '
        Me.Bonificados.AppearanceHeader.Options.UseTextOptions = True
        Me.Bonificados.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Bonificados.Caption = "Bonificados"
        Me.Bonificados.DisplayFormat.FormatString = "n2"
        Me.Bonificados.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Bonificados.FieldName = "Bonificados"
        Me.Bonificados.Name = "Bonificados"
        Me.Bonificados.OptionsColumn.AllowEdit = False
        Me.Bonificados.OptionsColumn.AllowSize = False
        Me.Bonificados.Width = 26
        '
        'Saldo
        '
        Me.Saldo.Caption = "Saldo"
        Me.Saldo.FieldName = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.OptionsColumn.AllowEdit = False
        Me.Saldo.OptionsColumn.AllowSize = False
        Me.Saldo.Width = 27
        '
        'TotalFlete
        '
        Me.TotalFlete.AppearanceCell.Options.UseTextOptions = True
        Me.TotalFlete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TotalFlete.AppearanceHeader.Options.UseTextOptions = True
        Me.TotalFlete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TotalFlete.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TotalFlete.Caption = "Total Flete"
        Me.TotalFlete.DisplayFormat.FormatString = "n2"
        Me.TotalFlete.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TotalFlete.FieldName = "TotalFlete"
        Me.TotalFlete.Name = "TotalFlete"
        Me.TotalFlete.OptionsColumn.AllowEdit = False
        Me.TotalFlete.OptionsColumn.AllowSize = False
        Me.TotalFlete.SummaryItem.DisplayFormat = "{0:n2}"
        Me.TotalFlete.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.TotalFlete.Width = 65
        '
        'PagoMifin
        '
        Me.PagoMifin.AppearanceCell.Options.UseTextOptions = True
        Me.PagoMifin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.PagoMifin.AppearanceHeader.Options.UseTextOptions = True
        Me.PagoMifin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PagoMifin.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PagoMifin.Caption = "Pago MIFIN"
        Me.PagoMifin.DisplayFormat.FormatString = "n2"
        Me.PagoMifin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PagoMifin.FieldName = "PagoMifin"
        Me.PagoMifin.Name = "PagoMifin"
        Me.PagoMifin.OptionsColumn.AllowEdit = False
        Me.PagoMifin.OptionsColumn.AllowSize = False
        Me.PagoMifin.SummaryItem.DisplayFormat = "{0:n2}"
        Me.PagoMifin.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.PagoMifin.Width = 20
        '
        'PagoDAI
        '
        Me.PagoDAI.AppearanceCell.Options.UseTextOptions = True
        Me.PagoDAI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.PagoDAI.AppearanceHeader.Options.UseTextOptions = True
        Me.PagoDAI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PagoDAI.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PagoDAI.Caption = "Pago DAI"
        Me.PagoDAI.DisplayFormat.FormatString = "n2"
        Me.PagoDAI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PagoDAI.FieldName = "PagoDAI"
        Me.PagoDAI.Name = "PagoDAI"
        Me.PagoDAI.OptionsColumn.AllowEdit = False
        Me.PagoDAI.OptionsColumn.AllowSize = False
        Me.PagoDAI.SummaryItem.DisplayFormat = "{0:n2}"
        Me.PagoDAI.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.PagoDAI.Width = 20
        '
        'PagoISC
        '
        Me.PagoISC.AppearanceCell.Options.UseTextOptions = True
        Me.PagoISC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.PagoISC.AppearanceHeader.Options.UseTextOptions = True
        Me.PagoISC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PagoISC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PagoISC.Caption = "Pago ISC"
        Me.PagoISC.DisplayFormat.FormatString = "n2"
        Me.PagoISC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PagoISC.FieldName = "PagoISC"
        Me.PagoISC.Name = "PagoISC"
        Me.PagoISC.OptionsColumn.AllowEdit = False
        Me.PagoISC.OptionsColumn.AllowSize = False
        Me.PagoISC.Width = 20
        '
        'PagoIVA
        '
        Me.PagoIVA.AppearanceCell.Options.UseTextOptions = True
        Me.PagoIVA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.PagoIVA.AppearanceHeader.Options.UseTextOptions = True
        Me.PagoIVA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PagoIVA.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PagoIVA.Caption = "Pago IVA"
        Me.PagoIVA.DisplayFormat.FormatString = "n2"
        Me.PagoIVA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PagoIVA.FieldName = "PagoIVA"
        Me.PagoIVA.Name = "PagoIVA"
        Me.PagoIVA.OptionsColumn.AllowEdit = False
        Me.PagoIVA.OptionsColumn.AllowSize = False
        Me.PagoIVA.Width = 20
        '
        'PrecioVenta
        '
        Me.PrecioVenta.AppearanceCell.Options.UseTextOptions = True
        Me.PrecioVenta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.PrecioVenta.AppearanceHeader.Options.UseTextOptions = True
        Me.PrecioVenta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PrecioVenta.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PrecioVenta.Caption = "Precio de Venta Actual"
        Me.PrecioVenta.DisplayFormat.FormatString = "n2"
        Me.PrecioVenta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PrecioVenta.FieldName = "PrecioVenta"
        Me.PrecioVenta.Name = "PrecioVenta"
        Me.PrecioVenta.OptionsColumn.AllowEdit = False
        Me.PrecioVenta.OptionsColumn.AllowSize = False
        Me.PrecioVenta.Width = 53
        '
        'Margen
        '
        Me.Margen.AppearanceCell.Options.UseTextOptions = True
        Me.Margen.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Margen.AppearanceHeader.Options.UseTextOptions = True
        Me.Margen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Margen.Caption = "Margen"
        Me.Margen.DisplayFormat.FormatString = "p2"
        Me.Margen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Margen.FieldName = "Margen"
        Me.Margen.Name = "Margen"
        Me.Margen.OptionsColumn.AllowEdit = False
        Me.Margen.OptionsColumn.AllowSize = False
        Me.Margen.Width = 20
        '
        'Exento
        '
        Me.Exento.Caption = "Exento"
        Me.Exento.FieldName = "Exento"
        Me.Exento.Name = "Exento"
        Me.Exento.OptionsColumn.AllowSize = False
        Me.Exento.OptionsColumn.ShowInCustomizationForm = False
        Me.Exento.Width = 27
        '
        'Moneda
        '
        Me.Moneda.Caption = "Moneda"
        Me.Moneda.FieldName = "Moneda"
        Me.Moneda.Name = "Moneda"
        Me.Moneda.OptionsColumn.AllowSize = False
        Me.Moneda.OptionsColumn.ShowInCustomizationForm = False
        Me.Moneda.Width = 27
        '
        'Modified
        '
        Me.Modified.Caption = "Modified"
        Me.Modified.FieldName = "Modified"
        Me.Modified.Name = "Modified"
        Me.Modified.OptionsColumn.AllowSize = False
        Me.Modified.OptionsColumn.ShowInCustomizationForm = False
        Me.Modified.Width = 27
        '
        'IDFactura
        '
        Me.IDFactura.Caption = "IDFactura"
        Me.IDFactura.FieldName = "IDFactura"
        Me.IDFactura.Name = "IDFactura"
        Me.IDFactura.OptionsColumn.AllowSize = False
        Me.IDFactura.Width = 113
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Proveedor"
        '
        'cbProveedor
        '
        Me.cbProveedor.Enabled = False
        Me.cbProveedor.EnterMoveNextControl = True
        Me.cbProveedor.Location = New System.Drawing.Point(72, 31)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cbProveedor.Properties.Appearance.Options.UseFont = True
        Me.cbProveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProveedor.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cuenta", "", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.cbProveedor.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cbProveedor.Properties.LookAndFeel.UseWindowsXPTheme = True
        Me.cbProveedor.Properties.NullText = ""
        Me.cbProveedor.Size = New System.Drawing.Size(328, 20)
        Me.cbProveedor.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Factura No."
        '
        'tbFactura
        '
        Me.tbFactura.EnterMoveNextControl = True
        Me.tbFactura.Location = New System.Drawing.Point(72, 63)
        Me.tbFactura.Name = "tbFactura"
        Me.tbFactura.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.tbFactura.Properties.Appearance.Options.UseFont = True
        Me.tbFactura.Size = New System.Drawing.Size(120, 20)
        Me.tbFactura.TabIndex = 3
        '
        'tbValorFob
        '
        Me.tbValorFob.EditValue = "0.00"
        Me.tbValorFob.EnterMoveNextControl = True
        Me.tbValorFob.Location = New System.Drawing.Point(280, 63)
        Me.tbValorFob.Name = "tbValorFob"
        Me.tbValorFob.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.tbValorFob.Properties.Appearance.Options.UseFont = True
        Me.tbValorFob.Properties.DisplayFormat.FormatString = "n2"
        Me.tbValorFob.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.tbValorFob.Properties.EditFormat.FormatString = "n2"
        Me.tbValorFob.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.tbValorFob.Properties.Mask.EditMask = "n2"
        Me.tbValorFob.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tbValorFob.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tbValorFob.Properties.NullText = "0.00"
        Me.tbValorFob.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbValorFob.Size = New System.Drawing.Size(120, 20)
        Me.tbValorFob.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(199, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Valor FOB US$"
        '
        'tbCuenta
        '
        Me.tbCuenta.EnterMoveNextControl = True
        Me.tbCuenta.Location = New System.Drawing.Point(112, 122)
        Me.tbCuenta.Name = "tbCuenta"
        Me.tbCuenta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.tbCuenta.Properties.Appearance.Options.UseFont = True
        Me.tbCuenta.Size = New System.Drawing.Size(80, 20)
        Me.tbCuenta.TabIndex = 12
        '
        'tbTC
        '
        Me.tbTC.EditValue = "0.0"
        Me.tbTC.EnterMoveNextControl = True
        Me.tbTC.Location = New System.Drawing.Point(440, 31)
        Me.tbTC.Name = "tbTC"
        Me.tbTC.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tbTC.Properties.Appearance.Options.UseFont = True
        Me.tbTC.Properties.DisplayFormat.FormatString = "n4"
        Me.tbTC.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.tbTC.Properties.EditFormat.FormatString = "n4"
        Me.tbTC.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.tbTC.Properties.Mask.EditMask = "n4"
        Me.tbTC.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tbTC.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tbTC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbTC.Size = New System.Drawing.Size(100, 20)
        Me.tbTC.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(408, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "T/C"
        '
        'tbRecibo
        '
        Me.tbRecibo.EnterMoveNextControl = True
        Me.tbRecibo.Location = New System.Drawing.Point(515, 122)
        Me.tbRecibo.Name = "tbRecibo"
        Me.tbRecibo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.tbRecibo.Properties.Appearance.Options.UseFont = True
        Me.tbRecibo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbRecibo.Size = New System.Drawing.Size(101, 20)
        Me.tbRecibo.TabIndex = 14
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(408, 124)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 18)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "No. Recibo Bodega"
        '
        'tbPoliza
        '
        Me.tbPoliza.EnterMoveNextControl = True
        Me.tbPoliza.Location = New System.Drawing.Point(270, 122)
        Me.tbPoliza.Name = "tbPoliza"
        Me.tbPoliza.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.tbPoliza.Properties.Appearance.Options.UseFont = True
        Me.tbPoliza.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbPoliza.Size = New System.Drawing.Size(100, 20)
        Me.tbPoliza.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(214, 126)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 16)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Poliza No."
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Location = New System.Drawing.Point(921, 12)
        Me.SimpleButton1.LookAndFeel.UseWindowsXPTheme = True
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 20
        Me.SimpleButton1.Text = "&Salir"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Location = New System.Drawing.Point(598, 12)
        Me.cmdSave.LookAndFeel.UseWindowsXPTheme = True
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 19
        Me.cmdSave.Text = "&Aceptar"
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(199, 97)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(74, 16)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "Valor FOB C$"
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(408, 96)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(75, 16)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = "Total Flete C$"
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(624, 96)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(64, 16)
        Me.Label29.TabIndex = 2
        Me.Label29.Text = "Total C.I.F."
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label30.Location = New System.Drawing.Point(809, 10)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(76, 16)
        Me.Label30.TabIndex = 2
        Me.Label30.Text = "GRAN TOTAL"
        Me.Label30.Visible = False
        '
        'tbGranTotal
        '
        Me.tbGranTotal.EditValue = "0.00"
        Me.tbGranTotal.Enabled = False
        Me.tbGranTotal.EnterMoveNextControl = True
        Me.tbGranTotal.Location = New System.Drawing.Point(893, 8)
        Me.tbGranTotal.Name = "tbGranTotal"
        Me.tbGranTotal.Properties.AllowFocused = False
        Me.tbGranTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.tbGranTotal.Properties.Appearance.Options.UseFont = True
        Me.tbGranTotal.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.tbGranTotal.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.tbGranTotal.Properties.DisplayFormat.FormatString = "n2"
        Me.tbGranTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.tbGranTotal.Properties.Mask.BeepOnError = True
        Me.tbGranTotal.Properties.Mask.EditMask = "n2"
        Me.tbGranTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tbGranTotal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tbGranTotal.Properties.NullText = "0.00"
        Me.tbGranTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbGranTotal.Size = New System.Drawing.Size(100, 20)
        Me.tbGranTotal.TabIndex = 8
        Me.tbGranTotal.TabStop = False
        Me.tbGranTotal.Visible = False
        '
        'tbTotalFOB
        '
        Me.tbTotalFOB.EditValue = "0.00"
        Me.tbTotalFOB.Enabled = False
        Me.tbTotalFOB.EnterMoveNextControl = True
        Me.tbTotalFOB.Location = New System.Drawing.Point(270, 94)
        Me.tbTotalFOB.Name = "tbTotalFOB"
        Me.tbTotalFOB.Properties.AllowFocused = False
        Me.tbTotalFOB.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.tbTotalFOB.Properties.Appearance.Options.UseFont = True
        Me.tbTotalFOB.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.tbTotalFOB.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.tbTotalFOB.Properties.Mask.BeepOnError = True
        Me.tbTotalFOB.Properties.Mask.EditMask = "n2"
        Me.tbTotalFOB.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tbTotalFOB.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tbTotalFOB.Properties.NullText = "0.00"
        Me.tbTotalFOB.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbTotalFOB.Size = New System.Drawing.Size(130, 20)
        Me.tbTotalFOB.TabIndex = 9
        Me.tbTotalFOB.TabStop = False
        '
        'tbFlete
        '
        Me.tbFlete.EditValue = "0.00"
        Me.tbFlete.Enabled = False
        Me.tbFlete.EnterMoveNextControl = True
        Me.tbFlete.Location = New System.Drawing.Point(484, 94)
        Me.tbFlete.Name = "tbFlete"
        Me.tbFlete.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.tbFlete.Properties.Appearance.Options.UseFont = True
        Me.tbFlete.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.tbFlete.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.tbFlete.Properties.Mask.BeepOnError = True
        Me.tbFlete.Properties.Mask.EditMask = "n2"
        Me.tbFlete.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tbFlete.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tbFlete.Properties.NullText = "0.00"
        Me.tbFlete.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbFlete.Size = New System.Drawing.Size(132, 20)
        Me.tbFlete.TabIndex = 10
        Me.tbFlete.TabStop = False
        '
        'tbCIF
        '
        Me.tbCIF.EditValue = "0.00"
        Me.tbCIF.Enabled = False
        Me.tbCIF.EnterMoveNextControl = True
        Me.tbCIF.Location = New System.Drawing.Point(688, 94)
        Me.tbCIF.Name = "tbCIF"
        Me.tbCIF.Properties.AllowFocused = False
        Me.tbCIF.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.tbCIF.Properties.Appearance.Options.UseFont = True
        Me.tbCIF.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.tbCIF.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.tbCIF.Properties.Mask.BeepOnError = True
        Me.tbCIF.Properties.Mask.EditMask = "n2"
        Me.tbCIF.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tbCIF.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tbCIF.Properties.NullText = "0.00"
        Me.tbCIF.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbCIF.Size = New System.Drawing.Size(136, 20)
        Me.tbCIF.TabIndex = 11
        Me.tbCIF.TabStop = False
        '
        'lbFlete
        '
        Me.lbFlete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lbFlete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbFlete.Location = New System.Drawing.Point(920, 152)
        Me.lbFlete.Name = "lbFlete"
        Me.lbFlete.Size = New System.Drawing.Size(65, 16)
        Me.lbFlete.TabIndex = 23
        Me.lbFlete.Visible = False
        '
        'lbCIF
        '
        Me.lbCIF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lbCIF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbCIF.Location = New System.Drawing.Point(920, 176)
        Me.lbCIF.Name = "lbCIF"
        Me.lbCIF.Size = New System.Drawing.Size(65, 16)
        Me.lbCIF.TabIndex = 23
        Me.lbCIF.Visible = False
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.XtraTabControl1.Appearance.Options.UseBackColor = True
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 27)
        Me.XtraTabControl1.LookAndFeel.UseWindowsXPTheme = True
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1006, 434)
        Me.XtraTabControl1.TabIndex = 24
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPage1.Appearance.Header.ForeColor = System.Drawing.Color.Black
        Me.XtraTabPage1.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage1.Appearance.Header.Options.UseForeColor = True
        Me.XtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.XtraTabPage1.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage1.Controls.Add(Me.Label13)
        Me.XtraTabPage1.Controls.Add(Me.dtBodega)
        Me.XtraTabPage1.Controls.Add(Me.tbRecibo)
        Me.XtraTabPage1.Controls.Add(Me.tbAnifoda)
        Me.XtraTabPage1.Controls.Add(Me.tbLiqNo)
        Me.XtraTabPage1.Controls.Add(Me.Label10)
        Me.XtraTabPage1.Controls.Add(Me.dtFechaLiq)
        Me.XtraTabPage1.Controls.Add(Me.tbBultosLiq)
        Me.XtraTabPage1.Controls.Add(Me.Label9)
        Me.XtraTabPage1.Controls.Add(Me.tbBultos)
        Me.XtraTabPage1.Controls.Add(Me.Label8)
        Me.XtraTabPage1.Controls.Add(Me.tbFlete1)
        Me.XtraTabPage1.Controls.Add(Me.Label6)
        Me.XtraTabPage1.Controls.Add(Me.GridControl2)
        Me.XtraTabPage1.Controls.Add(Me.GridControl3)
        Me.XtraTabPage1.Controls.Add(Me.ckTax)
        Me.XtraTabPage1.Controls.Add(Me.tbCuenta)
        Me.XtraTabPage1.Controls.Add(Me.Label5)
        Me.XtraTabPage1.Controls.Add(Me.Label1)
        Me.XtraTabPage1.Controls.Add(Me.cbProveedor)
        Me.XtraTabPage1.Controls.Add(Me.Label17)
        Me.XtraTabPage1.Controls.Add(Me.Label2)
        Me.XtraTabPage1.Controls.Add(Me.tbPedido)
        Me.XtraTabPage1.Controls.Add(Me.tbFactura)
        Me.XtraTabPage1.Controls.Add(Me.tbTC)
        Me.XtraTabPage1.Controls.Add(Me.Label4)
        Me.XtraTabPage1.Controls.Add(Me.tbValorFob)
        Me.XtraTabPage1.Controls.Add(Me.Label3)
        Me.XtraTabPage1.Controls.Add(Me.Label11)
        Me.XtraTabPage1.Controls.Add(Me.Label7)
        Me.XtraTabPage1.Controls.Add(Me.tbPoliza)
        Me.XtraTabPage1.Controls.Add(Me.Label15)
        Me.XtraTabPage1.Controls.Add(Me.Label14)
        Me.XtraTabPage1.Controls.Add(Me.Label16)
        Me.XtraTabPage1.Controls.Add(Me.tbGranTotal)
        Me.XtraTabPage1.Controls.Add(Me.Label30)
        Me.XtraTabPage1.Controls.Add(Me.tbTotalFOB)
        Me.XtraTabPage1.Controls.Add(Me.Label27)
        Me.XtraTabPage1.Controls.Add(Me.tbFlete)
        Me.XtraTabPage1.Controls.Add(Me.Label28)
        Me.XtraTabPage1.Controls.Add(Me.Label29)
        Me.XtraTabPage1.Controls.Add(Me.tbCIF)
        Me.XtraTabPage1.Controls.Add(Me.Label12)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(997, 403)
        Me.XtraTabPage1.Text = "Datos Generales de Gastos"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(408, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "% de Anifoda"
        '
        'dtBodega
        '
        Me.dtBodega.EditValue = Nothing
        Me.dtBodega.Location = New System.Drawing.Point(688, 123)
        Me.dtBodega.Name = "dtBodega"
        Me.dtBodega.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dtBodega.Properties.Appearance.Options.UseFont = True
        Me.dtBodega.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBodega.Properties.DisplayFormat.FormatString = "dd-MMM-yy"
        Me.dtBodega.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtBodega.Properties.EditFormat.FormatString = "ddmmyy"
        Me.dtBodega.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtBodega.Properties.Mask.EditMask = ""
        Me.dtBodega.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtBodega.Properties.VistaTimeProperties.Mask.EditMask = ""
        Me.dtBodega.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtBodega.Size = New System.Drawing.Size(136, 20)
        Me.dtBodega.TabIndex = 26
        '
        'tbAnifoda
        '
        Me.tbAnifoda.EditValue = "0.5"
        Me.tbAnifoda.Location = New System.Drawing.Point(483, 5)
        Me.tbAnifoda.Name = "tbAnifoda"
        Me.tbAnifoda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tbAnifoda.Properties.Appearance.Options.UseFont = True
        Me.tbAnifoda.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbAnifoda.Size = New System.Drawing.Size(57, 20)
        Me.tbAnifoda.TabIndex = 25
        '
        'tbLiqNo
        '
        Me.tbLiqNo.Enabled = False
        Me.tbLiqNo.EnterMoveNextControl = True
        Me.tbLiqNo.Location = New System.Drawing.Point(288, 6)
        Me.tbLiqNo.Name = "tbLiqNo"
        Me.tbLiqNo.Properties.AllowFocused = False
        Me.tbLiqNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.tbLiqNo.Properties.Appearance.Options.UseFont = True
        Me.tbLiqNo.Properties.ReadOnly = True
        Me.tbLiqNo.Size = New System.Drawing.Size(112, 20)
        Me.tbLiqNo.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(8, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 26)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Fecha de Liquidación"
        '
        'dtFechaLiq
        '
        Me.dtFechaLiq.EditValue = Nothing
        Me.dtFechaLiq.EnterMoveNextControl = True
        Me.dtFechaLiq.Location = New System.Drawing.Point(72, 5)
        Me.dtFechaLiq.Name = "dtFechaLiq"
        Me.dtFechaLiq.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dtFechaLiq.Properties.Appearance.Options.UseFont = True
        Me.dtFechaLiq.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaLiq.Properties.DisplayFormat.FormatString = "dd-MMM-yy"
        Me.dtFechaLiq.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtFechaLiq.Properties.EditFormat.FormatString = "ddmmyy"
        Me.dtFechaLiq.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtFechaLiq.Properties.Mask.EditMask = ""
        Me.dtFechaLiq.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtFechaLiq.Properties.VistaTimeProperties.Mask.EditMask = ""
        Me.dtFechaLiq.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtFechaLiq.Size = New System.Drawing.Size(120, 20)
        Me.dtFechaLiq.TabIndex = 23
        '
        'tbBultosLiq
        '
        Me.tbBultosLiq.EditValue = "0.0"
        Me.tbBultosLiq.EnterMoveNextControl = True
        Me.tbBultosLiq.Location = New System.Drawing.Point(688, 63)
        Me.tbBultosLiq.Name = "tbBultosLiq"
        Me.tbBultosLiq.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.tbBultosLiq.Properties.Appearance.Options.UseFont = True
        Me.tbBultosLiq.Properties.DisplayFormat.FormatString = "n2"
        Me.tbBultosLiq.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.tbBultosLiq.Properties.EditFormat.FormatString = "n2"
        Me.tbBultosLiq.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.tbBultosLiq.Properties.Mask.EditMask = "n2"
        Me.tbBultosLiq.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tbBultosLiq.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tbBultosLiq.Properties.NullText = "0.0"
        Me.tbBultosLiq.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbBultosLiq.Size = New System.Drawing.Size(64, 20)
        Me.tbBultosLiq.TabIndex = 7
        Me.tbBultosLiq.Visible = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(624, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Bultos a Liq."
        Me.Label9.Visible = False
        '
        'tbBultos
        '
        Me.tbBultos.EditValue = "0.00"
        Me.tbBultos.EnterMoveNextControl = True
        Me.tbBultos.Location = New System.Drawing.Point(688, 31)
        Me.tbBultos.Name = "tbBultos"
        Me.tbBultos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.tbBultos.Properties.Appearance.Options.UseFont = True
        Me.tbBultos.Properties.DisplayFormat.FormatString = "n2"
        Me.tbBultos.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.tbBultos.Properties.EditFormat.FormatString = "n2"
        Me.tbBultos.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.tbBultos.Properties.Mask.EditMask = "n2"
        Me.tbBultos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tbBultos.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tbBultos.Properties.NullText = "0.00"
        Me.tbBultos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbBultos.Size = New System.Drawing.Size(64, 20)
        Me.tbBultos.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(624, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 12)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Total Bultos"
        '
        'tbFlete1
        '
        Me.tbFlete1.EditValue = "0.00"
        Me.tbFlete1.EnterMoveNextControl = True
        Me.tbFlete1.Location = New System.Drawing.Point(496, 63)
        Me.tbFlete1.Name = "tbFlete1"
        Me.tbFlete1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.tbFlete1.Properties.Appearance.Options.UseFont = True
        Me.tbFlete1.Properties.DisplayFormat.FormatString = "n2"
        Me.tbFlete1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.tbFlete1.Properties.EditFormat.FormatString = "n2"
        Me.tbFlete1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.tbFlete1.Properties.Mask.EditMask = "n2"
        Me.tbFlete1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tbFlete1.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tbFlete1.Properties.NullText = "0.00"
        Me.tbFlete1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbFlete1.Size = New System.Drawing.Size(120, 20)
        Me.tbFlete1.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(408, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 12)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Total Flete US$"
        '
        'GridControl2
        '
        Me.GridControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GridControl2.Location = New System.Drawing.Point(425, 174)
        Me.GridControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl2.LookAndFeel.UseWindowsXPTheme = True
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lPagos})
        Me.GridControl2.Size = New System.Drawing.Size(400, 172)
        Me.GridControl2.TabIndex = 16
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        Me.GridControl2.Visible = False
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.LiqDetImpuestoID, Me.LiqID2, Me.Nombre, Me.Monto, Me.Porcentaje})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsCustomization.AllowColumnResizing = False
        Me.GridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'LiqDetImpuestoID
        '
        Me.LiqDetImpuestoID.Caption = "LiqDetImpuestoID"
        Me.LiqDetImpuestoID.FieldName = "LiqDetImpuestoID"
        Me.LiqDetImpuestoID.Name = "LiqDetImpuestoID"
        Me.LiqDetImpuestoID.OptionsColumn.ShowInCustomizationForm = False
        '
        'LiqID2
        '
        Me.LiqID2.Caption = "LiqID"
        Me.LiqID2.FieldName = "LiqID"
        Me.LiqID2.Name = "LiqID2"
        Me.LiqID2.OptionsColumn.ShowInCustomizationForm = False
        '
        'Nombre
        '
        Me.Nombre.Caption = "Nombre"
        Me.Nombre.ColumnEdit = Me.lPagos
        Me.Nombre.FieldName = "ImpuestoID"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.OptionsColumn.AllowEdit = False
        Me.Nombre.OptionsColumn.AllowFocus = False
        Me.Nombre.Visible = True
        Me.Nombre.VisibleIndex = 0
        Me.Nombre.Width = 220
        '
        'lPagos
        '
        Me.lPagos.AutoHeight = False
        Me.lPagos.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lPagos.Name = "lPagos"
        Me.lPagos.NullText = ""
        Me.lPagos.ShowFooter = False
        '
        'Monto
        '
        Me.Monto.AppearanceCell.Options.UseTextOptions = True
        Me.Monto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Monto.AppearanceHeader.Options.UseTextOptions = True
        Me.Monto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Monto.Caption = "Monto"
        Me.Monto.DisplayFormat.FormatString = "n2"
        Me.Monto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Monto.FieldName = "ImpMonto"
        Me.Monto.Name = "Monto"
        Me.Monto.SummaryItem.DisplayFormat = "{0:n2}"
        Me.Monto.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Monto.Visible = True
        Me.Monto.VisibleIndex = 1
        Me.Monto.Width = 83
        '
        'Porcentaje
        '
        Me.Porcentaje.AppearanceCell.Options.UseTextOptions = True
        Me.Porcentaje.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Porcentaje.Caption = "Porcentaje"
        Me.Porcentaje.DisplayFormat.FormatString = "n6"
        Me.Porcentaje.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Porcentaje.FieldName = "Porcentaje"
        Me.Porcentaje.Name = "Porcentaje"
        Me.Porcentaje.OptionsColumn.AllowEdit = False
        Me.Porcentaje.OptionsColumn.AllowFocus = False
        Me.Porcentaje.SummaryItem.DisplayFormat = "{0:n6}"
        Me.Porcentaje.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Porcentaje.Visible = True
        Me.Porcentaje.VisibleIndex = 2
        '
        'GridControl3
        '
        Me.GridControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GridControl3.Location = New System.Drawing.Point(8, 174)
        Me.GridControl3.LookAndFeel.UseWindowsXPTheme = True
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lGastos})
        Me.GridControl3.Size = New System.Drawing.Size(400, 172)
        Me.GridControl3.TabIndex = 15
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.LiqDetGastoID, Me.GridColumn1, Me.GridColumn4, Me.GridColumn2, Me.GridColumn3, Me.LiqID3, Me.Desgloce})
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'LiqDetGastoID
        '
        Me.LiqDetGastoID.Caption = "LiqDetGastoID"
        Me.LiqDetGastoID.FieldName = "LiqDetGastoID"
        Me.LiqDetGastoID.Name = "LiqDetGastoID"
        Me.LiqDetGastoID.OptionsColumn.ShowInCustomizationForm = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Nombre"
        Me.GridColumn1.ColumnEdit = Me.lGastos
        Me.GridColumn1.FieldName = "LiqGastoID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 220
        '
        'lGastos
        '
        Me.lGastos.AutoHeight = False
        Me.lGastos.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lGastos.Name = "lGastos"
        Me.lGastos.NullText = ""
        Me.lGastos.ShowFooter = False
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Doc. No."
        Me.GridColumn4.FieldName = "Origen"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Monto"
        Me.GridColumn2.DisplayFormat.FormatString = "n2"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn2.FieldName = "GastoMonto"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.SummaryItem.DisplayFormat = "{0:n2}"
        Me.GridColumn2.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 83
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Porcentaje"
        Me.GridColumn3.DisplayFormat.FormatString = "n6"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "Porcentaje"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.AllowFocus = False
        Me.GridColumn3.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn3.Width = 83
        '
        'LiqID3
        '
        Me.LiqID3.Caption = "LiqID"
        Me.LiqID3.FieldName = "LiqID"
        Me.LiqID3.Name = "LiqID3"
        Me.LiqID3.OptionsColumn.ShowInCustomizationForm = False
        '
        'Desgloce
        '
        Me.Desgloce.Caption = "Desgloce"
        Me.Desgloce.FieldName = "Desgloce"
        Me.Desgloce.Name = "Desgloce"
        Me.Desgloce.Visible = True
        Me.Desgloce.VisibleIndex = 3
        '
        'ckTax
        '
        Me.ckTax.Location = New System.Drawing.Point(655, 8)
        Me.ckTax.Name = "ckTax"
        Me.ckTax.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ckTax.Properties.Appearance.Options.UseForeColor = True
        Me.ckTax.Properties.Caption = "Vino"
        Me.ckTax.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ckTax.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ckTax.Size = New System.Drawing.Size(48, 19)
        Me.ckTax.TabIndex = 0
        Me.ckTax.Visible = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(8, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "GASTOS"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(8, 95)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 16)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "No. Pedido"
        '
        'tbPedido
        '
        Me.tbPedido.EnterMoveNextControl = True
        Me.tbPedido.Location = New System.Drawing.Point(72, 93)
        Me.tbPedido.Name = "tbPedido"
        Me.tbPedido.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.tbPedido.Properties.Appearance.Options.UseFont = True
        Me.tbPedido.Size = New System.Drawing.Size(120, 20)
        Me.tbPedido.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(424, 158)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 16)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "IMPUESTOS"
        Me.Label11.Visible = False
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(623, 119)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 26)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Fecha de Recepción"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(208, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 18)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Liquidación No."
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GridControl1)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(997, 403)
        Me.XtraTabPage2.Text = "Articulos de Liquidación"
        '
        'ckSelectData
        '
        Me.ckSelectData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckSelectData.Location = New System.Drawing.Point(486, 15)
        Me.ckSelectData.Name = "ckSelectData"
        Me.ckSelectData.Properties.Caption = "Selector de Datos"
        Me.ckSelectData.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ckSelectData.Size = New System.Drawing.Size(108, 19)
        Me.ckSelectData.TabIndex = 18
        Me.ckSelectData.Visible = False
        '
        'cmdPrint
        '
        Me.cmdPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint.Enabled = False
        Me.cmdPrint.Location = New System.Drawing.Point(759, 12)
        Me.cmdPrint.LookAndFeel.UseWindowsXPTheme = True
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 23)
        Me.cmdPrint.TabIndex = 19
        Me.cmdPrint.Text = "I&mprimir"
        '
        'cmdImportar
        '
        Me.cmdImportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdImportar.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.cmdImportar.Appearance.Options.UseFont = True
        Me.cmdImportar.Enabled = False
        Me.cmdImportar.Location = New System.Drawing.Point(678, 12)
        Me.cmdImportar.LookAndFeel.UseWindowsXPTheme = True
        Me.cmdImportar.Name = "cmdImportar"
        Me.cmdImportar.Padding = New System.Windows.Forms.Padding(7)
        Me.cmdImportar.Size = New System.Drawing.Size(75, 23)
        Me.cmdImportar.TabIndex = 19
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'cmdAnifoda
        '
        Me.cmdAnifoda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAnifoda.Location = New System.Drawing.Point(840, 12)
        Me.cmdAnifoda.Name = "cmdAnifoda"
        Me.cmdAnifoda.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnifoda.TabIndex = 25
        Me.cmdAnifoda.Text = "Anifoda"
        '
        'cmAnifoda
        '
        Me.cmAnifoda.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.AnifodaCalc, Me.AnifodaPrint})
        '
        'AnifodaCalc
        '
        Me.AnifodaCalc.Index = 0
        Me.AnifodaCalc.Text = "Calcular"
        '
        'AnifodaPrint
        '
        Me.AnifodaPrint.Index = 1
        Me.AnifodaPrint.Text = "Imprimir"
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.GridControl1
        Me.PrintableComponentLink1.CustomPaperSize = New System.Drawing.Size(0, 0)
        Me.PrintableComponentLink1.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(50, 50, 80, 80)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"", "", "[Page #]"}, New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Center), Nothing)
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Exact
        '
        'frmLiquidacionAdd
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 464)
        Me.Controls.Add(Me.cmdAnifoda)
        Me.Controls.Add(Me.cmdImportar)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.ckSelectData)
        Me.Controls.Add(Me.lbFlete)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.lbCIF)
        Me.Name = "frmLiquidacionAdd"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbValorFob.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbTC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbRecibo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbPoliza.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbGranTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbTotalFOB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFlete.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbCIF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.dtBodega.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBodega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbAnifoda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbLiqNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaLiq.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaLiq.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbBultosLiq.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbBultos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFlete1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lGastos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckTax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbPedido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.ckSelectData.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Vaiables"
    Dim r As New VB.SysContab.Rutinas
    Dim TipoC As New VB.SysContab.Tasa_CambioDB
    Dim PrecioU As Double = 0.0
    Dim Temp As Integer = 0
    Dim IVAEmpresa As Double = 0.0
    Dim ArtImpCif As Double = 0.0 'Es para acumular el cif de los medicamentos que pagan impuesto
    Dim DT1 As DataTable : Dim DT2 As DataTable : Dim DT3 As DataTable : Dim DT4 As DataTable
    Dim Factor As Double = 0.0 : Dim IVAProd As Double = 0.0
    Public DR As DataRowView : Public ArtTemp As String 'Para guardar temporalmelte el codigo del nuevo articulo
    Public NewLiq As Boolean : Public LiqID As String = "0"
    Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion)
    Public FacSelec As String : Public ProvSelec As String
    Public Origen As Int16 '1-Liquidacion InBond, 2-Liquidacion Final,3-Liquidacion Directa
    Public ALiquidar1 As Boolean 'Para que aparezca la columna "ALiquidar "en el GV para Origen=2
    Dim Timer As Boolean = False 'Para que pueda validar en GridView1_CellValueChanged el comparar la cantidad con el saldo
    Public Directa As Boolean 'Para la seleccion de liquidaciones directas, mas que todo para las de medicamentos
    Public MT As Boolean = False
#End Region

    Private Sub frmLiquidacionAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmdImportar.Text = "&Entrada" & vbCrLf & "Inventario"
        Dim p As New VB.SysContab.ProveedoresDB
        r.CambiarEstilo(Me)

        IVAEmpresa = ObtieneDatos("SELECT IVA FROM Configuraciones WHERE Empresa=" & EmpresaActual).Rows(0).Item(0) / 100
        If TipoC.GetTasaCambioDia(Today.Month, Today.Year, Today.Day).Tables("Tasa_Cambio").Rows.Count = 0 Then
            tbTC.Text = "1.00" : Else
            tbTC.Text = TipoC.GetTasaCambioDia(Today.Month, Today.Year, Today.Day).Tables("Tasa_Cambio").Rows(0).Item("Tasa_Cambio")
        End If

        cbProveedor.Properties.DataSource = ObtieneDatos("SELECT CODIGO,NOMBRE,ISNULL(CuentaTransito,'')AS Cuenta FROM Proveedores WHERE Empresa=" & EmpresaActual) 'p.ProveedoresListCombo().Tables("Proveedores")
        cbProveedor.Properties.DisplayMember = "NOMBRE" : cbProveedor.Properties.ValueMember = "CODIGO"

        lArticulo.DataSource = ObtieneDatos("SELECT '' AS Codigo, '' AS Nombre,0 AS Precio, Exento, 1 as Unidad FROM Articulos WHERE Codigo_Articulo=''")
        lArticulo.PopulateColumns() : lArticulo.NullText = ""
        lArticulo.ValueMember = "Codigo" : lArticulo.DisplayMember = "Nombre"
        lArticulo.Columns(2).Visible = False : lArticulo.Columns(3).Visible = False : lArticulo.Columns(4).Visible = False

        lGastos.DataSource = ObtieneDatos("SELECT * FROM LiquidacionesGastos")
        lGastos.PopulateColumns() : lGastos.NullText = ""
        lGastos.ValueMember = "LiqGastoID" : lGastos.DisplayMember = "GastoNombre"
        lGastos.Columns(0).Visible = False

        lPagos.DataSource = ObtieneDatos("SELECT ImpuestoID,ImpNombre,ImpMonto,ImpPorcentaje FROM Impuestos WHERE InstitucionID=1")
        lPagos.PopulateColumns() : lPagos.NullText = ""
        lPagos.ValueMember = "ImpuestoID" : lPagos.DisplayMember = "ImpNombre"
        lPagos.Columns(0).Visible = False : lPagos.Columns(2).Visible = False : lPagos.Columns(3).Visible = False

        'DT3 = GetEncabezados(3)
        'DT2 = GetEncabezados(2)
        'GridControl3.DataSource = DT3
        'GridControl2.DataSource = DT2

        BandedGridView1.Columns("PagoDAI").Visible = False
        dtFechaLiq.DateTime = New DateTime(Today.Year, Today.Month, 1) '"01/" & Today.Month & "/" & Today.Year
        dtBodega.DateTime = Today
        If NewLiq = False Then
            DT3 = GetEncabezados(3)
            DT2 = GetEncabezados(2)
            GridControl3.DataSource = DT3
            GridControl2.DataSource = DT2

            Dim DTS As DataTable
            DTS = GetEncabezados(1)
            If DTS.Rows.Count > 0 Then
                With DTS.Rows(0)
                    Me.dtFechaLiq.DateTime = .Item(2)
                    ckTax.Checked = .Item(3)
                    tbTC.Text = .Item(5)
                    tbFactura.Text = .Item(6).Trim
                    tbValorFob.EditValue = .Item(7)
                    tbFlete1.EditValue = .Item(8)
                    tbBultos.EditValue = .Item(9)
                    tbBultosLiq.EditValue = .Item(10)
                    tbCuenta.Text = .Item(11).Trim
                    tbPoliza.Text = .Item(12).Trim
                    tbRecibo.Text = .Item("Recibo").Trim : dtBodega.DateTime = .Item("FechaBodega")
                    tbPedido.Text = .Item("OrdenCompra_ID")
                    tbGranTotal.EditValue = GridView2.Columns("ImpMonto").SummaryItem.SummaryValue + GridView3.Columns("GastoMonto").SummaryItem.SummaryValue
                    cbProveedor.Enabled = False : ckTax.Enabled = False
                End With
            End If
            LoadArticulo()
            ReloadGrid(LiqID)
            If DTS.Rows(0).Item(3) = False Then ckTax.Checked = True
            For i As Int16 = 0 To BandedGridView1.DataRowCount - 1
                BandedGridView1.SetRowCellValue(i, ValorFob, DT1.Rows(i).Item("ValorFob"))
                BandedGridView1.SetRowCellValue(i, "Cantidad", DT1.Rows(i).Item("Cantidad"))
            Next
            If DTS.Rows(0).Item(3) = False Then ckTax.Checked = False
            Calc2()
            GridView3_RowUpdated(Nothing, Nothing) 'GridView3.AddNewRow()
            cmdPrint.Enabled = True : If Origen = 1 Then GridControl2.Enabled = False
            'cmdImportar.Enabled = True

        ElseIf NewLiq And (Origen = 1 Or Origen = 3) Then
            Dim ValorFobTemp As Double = 0.0 : Dim CantidadTemp As Double = 0.0
            DT1 = ObtieneDatos("SPJLiquidarGetFacturasDetalle " & "'" & FacSelec & "'," & "'" & _
                               ProvSelec & "'" & "," & Origen & "," & CInt(EmpresaActual))

            For i As Int16 = 0 To DT1.Rows.Count - 1 'Para calcular el total FOB en $ y el numero total de bultos.
                ValorFobTemp = ValorFobTemp + (CDbl(DT1.Rows(i).Item("ValorFob")) * CDbl(DT1.Rows(i).Item("Cantidad")))
                CantidadTemp = CantidadTemp + DT1.Rows(i).Item("Cantidad")
            Next

            tbValorFob.Text = ValorFobTemp
            tbBultos.Text = CantidadTemp

            LoadArticulo()

            GridControl1.DataSource = DT1 'DTTemp
            For i As Int16 = 0 To DT1.Rows.Count - 1 'Para que los calculos del GV1 se elaboren y no den 'error divsion by 0'.
                BandedGridView1.SetRowCellValue(i, "ValorFob", DT1.Rows(i).Item("ValorFob"))
                BandedGridView1.SetRowCellValue(i, "Cantidad", DT1.Rows(i).Item("Cantidad"))
            Next

            GridControl2.Enabled = False : tbBultosLiq.Enabled = False
            : tbPoliza.Enabled = False 'tbFlete1.Enabled = False 
            tbFactura.Enabled = False
            tbValorFob.Enabled = False : tbBultos.Enabled = False
            'GridView1.Columns("Saldo").Visible = True

            'GridView1.Columns(29).Group()
            BandedGridView1.ExpandAllGroups()
            BandedGridView1.GroupRowHeight = 10

            If Origen = 3 Then
                DT3 = GetEncabezados(3)
                GridControl3.DataSource = DT3
                GridView3.SetFocusedRowModified()
            End If
        End If
        If ALiquidar1 = True Then
            BandedGridView1.Columns("ALiquidar").Visible = True : BandedGridView1.Columns("ALiquidar").VisibleIndex = 0
            BandedGridView1.Columns("Saldo").Visible = True : BandedGridView1.Columns("Saldo").VisibleIndex = 6
            tbBultos.Enabled = False : tbValorFob.Enabled = False : tbCuenta.Enabled = False : tbRecibo.Enabled = False
            GridControl2.Enabled = True : Me.cmdPrint.Enabled = False : tbFlete1.Enabled = False : NewLiq = True
            Origen = 2 'Para que pueda grabarse en las tablase de Liquidaciones y LiquidacionesDetalle
            'For i As Integer = 0 To GridView1.DataRowCount - 1
            '    GridView1.SetRowCellValue(i, "Cantidad", 0)
            'Next
        End If

        If Directa Then
            GridControl2.Enabled = True : tbCuenta.Enabled = True : tbRecibo.Enabled = True : tbPoliza.Enabled = True
            tbBultosLiq.Text = tbBultos.Text : tbBultos.Enabled = False : tbBultosLiq.Enabled = False
            tbValorFob.Enabled = False
            For i As Integer = 0 To DT1.Rows.Count - 1
                BandedGridView1.SetRowCellValue(i, "Saldo", DT1.Rows(i).Item("Cantidad"))
            Next
            tbBultosLiq.Text = BandedGridView1.Columns("Cantidad").SummaryItem.SummaryValue
            Me.Origen = 2
            cbProveedor.Enabled = True
        End If
        'GridView1.AddNewRow()
        BandedGridView1.UpdateTotalSummary()
        Timer = True
        'For k As Integer = 0 To BandedGridView1.Columns.Count - 1
        '    If BandedGridView1.Columns(k).Visible Then BandedGridView1.Columns(k).BestFit()
        'Next
        GridView3.MoveLastVisible()
        tbTC.SelectAll()
        tbTC.Focus()

        If NewLiq = False Then
            BandedGridView1.Columns("Anifoda").Visible = False
            cmdAnifoda.Enabled = False
        End If
        BandedGridView1.MoveLastVisible()
    End Sub

    Private Sub cbProveedor_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbProveedor.EditValueChanged
        GridControl1.DataSource = Nothing
        ReloadGrid(0)
        If NewLiq And Origen <> 1 Then LoadArticulo()
    End Sub

    Private Sub LoadArticulo()
        lArticulo.DataSource = ObtieneDatos("SELECT Codigo_Articulo AS Codigo, Articulos.Nombre,Precio_Venta_Cordobas AS Precio,Articulos.Exento," & _
                " 1 AS Unidad,Moneda,isnull(ValorFob,0)AS ValorFob,Unidad as UM FROM Articulos INNER JOIN Proveedores ON Articulos.Proveedor=Proveedores.Codigo " & _
                "AND Articulos.Empresa=Proveedores.Empresa WHERE Articulos.Empresa=" & EmpresaActual) '& " AND Proveedores.Codigo IN (" & IIf(ProvSelec = "", cbProveedor.EditValue, ProvSelec) & ")")
        lArticulo.ValueMember = "Codigo" : lArticulo.DisplayMember = "Nombre"
        lArticulo.NullText = "" : lArticulo.PopupWidth = 600 : lArticulo.PopulateColumns()
        lArticulo.Columns(0).Width = 50 : lArticulo.Columns(1).Width = 140 : lArticulo.Columns(2).Width = 50
        lArticulo.Columns(2).Visible = False : lArticulo.Columns(3).Visible = False : lArticulo.Columns(4).Visible = False
        lArticulo.ShowFooter = False
        'GridView1.SetFocusedRowCellValue(CantidadCaja, 0.0)
    End Sub

    Private Function GetEncabezados(ByVal A As Int16)
        Select Case A
            Case 1
                Return ObtieneDatos("SPJLiquidarGetEncabezados " & Origen & "," & LiqID & "," & EmpresaActual)

                'If Origen = 1 Then
                '    Return ObtieneDatos("SELECT LiqIBID AS LiqID,LiqIBNo AS LiqNo, FechaIngreso AS Fecha,Vino AS Impuesto,ProveedorID,TC,Factura,FOB,Flete,BultosIn,0 as BultosLiq,LiquidacionesIB.Cuenta," & _
                '                        "'' AS Poliza,Recibo FROM LiquidacionesIB JOIN Proveedores ON ProveedorID=Codigo AND  EmpresaID=Empresa WHERE LiqIBID=" & LiqID)
                'Else
                '    Return ObtieneDatos("SELECT LiqID,LiqNo,Fecha,Impuesto,ProveedorID,TC,Factura,FOB,Flete,BultosIn,BultosLiq,Liquidaciones.Cuenta," & _
                '           "Poliza,Recibo,Proveedores.Nombre FROM Liquidaciones JOIN Proveedores ON ProveedorID=Codigo AND EmpresaID=Empresa WHERE LiqID=" & LiqID)
                'End If
            Case 2
                Return ObtieneDatos("SELECT *, 0.0 as Porcentaje FROM LiquidacionesDetalleImpuesto WHERE LiqID=" & LiqID)
            Case 3
                If NewLiq Then
                    Return ObtieneDatos("SPJLiquidarGetEncabezados " & Origen & "," & LiqID & "," & EmpresaActual)
                    'Return ObtieneDatos("SELECT 0 LiqDetGastoID,GastoID AS LiqGastoID,Factura_ID AS Origen,Item_Costo*Item_Cantidad AS GastoMonto,0.0 AS Porcentaje,MTDId AS LiqID " & _
                    '                    "FROM Liquidaciones_MercaderiaTransitoGastos lmtg JOIN FACTURAS_COMPRAS_LINEAS ocl ON lmtg.facturacompra = ocl.Factura_ID AND " & _
                    '                    "lmtg.itemID = ocl.Item_ID WHERE MTID = " & CInt(FacSelec) & " AND ocl.Empresa_ID = " & EmpresaActual)
                Else
                    Return ObtieneDatos("SELECT *,0.0 as Porcentaje FROM LiquidacionesDetalleGasto WHERE LiqID=" & LiqID & IIf(Origen = 1, " AND IB=1", ""))
                End If
        End Select
    End Function

    Private Function ReloadGrid(ByVal Var As String)
        If Origen <> 1 Then 'Para las tablas Liquidaciones y LiquidacionesDetalle
            DT1 = ObtieneDatos("SELECT CAST(0 as bit) AS ALiquidar,LiqDetalleID,LiqID,ArticuloID,Descuento,1 AS CantidadCaja,Cantidad,0 AS Saldo,Bonificados," & _
            IIf(NewLiq, "Articulos.ValorFob", "LD.ValorFob") & ",0.00 AS TotalFOB1, 0.00 AS TotalFOB2,0.00 AS TotalFlete,0.00 AS TotalCIF,0.00 AS PagoMifin,0.00 AS PagoDAI,0.00 AS PagoISC " & _
            ",0.00 AS PagoIVA,0.00 AS TotalGastos,0.00 AS CostoBodega,0.00 AS Costo1,0.00 AS Costo2,0.00 AS PrecioVenta,0.00 AS Margen,0 AS Modified,Exento,articulos.Moneda,0.00 AS Costo3,IDFactura, Unidad as UM, 0 Anifoda FROM " & _
           "LiquidacionesDetalle LD JOIN Articulos ON ArticuloID=Codigo_Articulo WHERE LiqID IN (" & Var & ") ORDER BY IDFactura")
        Else 'Para las Tablas LiquidacionesIB y LiquidacionesIBDetalles -- INBOND
            DT1 = ObtieneDatos("SELECT CAST(0 AS Bit) AS ALiquidar,LiqIBDetalleID AS LiqDetalleID,LiqIBID AS LiqID,ArticuloID,LD.Descuento,1 AS CantidadCaja,Cantidad, " & _
            "(SELECT LD.Cantidad-ISNULL(SUM(Cantidad),0)FROM LiquidacionesDetalle LD1 JOIN Liquidaciones L ON LD1.LiqID=L.LiqID WHERE Estado = 1 And ArticuloID = Codigo_Articulo And L.LiqIBID = LD.LiqIBID)" & _
            " AS Saldo, Bonificados,LD.ValorFob,0.00 AS TotalFOB1,0.00 AS TotalFOB2,0.00 AS TotalFlete,0.00 AS TotalCIF,0.00 AS PagoMifin,0.00 AS PagoDAI,0.00 AS PagoISC,0.00 AS PagoIVA " & _
            ",0.00 AS TotalGastos,0.00 AS CostoBodega,0.00 AS Costo1,0.00 AS Costo2,0.00 AS PrecioVenta,0.00 AS Margen,0 AS Modified,Articulos.Exento,articulos.Moneda,0.00 AS Costo3,ld.IDFactura, Unidad as UM, 0 Anifoda, p.NOMBRE AS ProvNombre" & _
            " FROM LiquidacionesIBDetalle LD JOIN Articulos ON ArticuloID=Codigo_Articulo JOIN facturas_Compras FC ON ld.IDFactura = fc.IDFactura " & _
            "JOIN PROVEEDORES p ON fc.Proveedor_ID = p.CODIGO AND fc.Empresa_ID = p.EMPRESA WHERE LiqIBID IN (" & Var & ")")
        End If
        GridControl1.DataSource = DT1
        BandedGridView1.MoveLast()
    End Function

    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles BandedGridView1.CellValueChanged
        Dim DRT As DataRow
        If e.Column.FieldName = "ArticuloID" Or e.Column.FieldName = "Cantidad" Then 'Or e.Column.FieldName = "ValorFob" Then
            If NewLiq Then
                DR = lArticulo.GetDataSourceRowByKeyValue(BandedGridView1.GetRowCellValue(e.RowHandle, "ArticuloID"))
            Else
                DRT = ObtieneDatos("SELECT Codigo_Articulo AS Codigo,Nombre,Precio_Venta_Cordobas AS Precio,Exento,1 as Unidad,Moneda,Exento,Unidad as UM FROM Articulos WHERE Codigo_Articulo='" & BandedGridView1.GetRowCellValue(e.RowHandle, "ArticuloID") & "'").Rows(0)
            End If

            With BandedGridView1
                .SetRowCellValue(e.RowHandle, "TotalFOB1", Math.Round(IsNull(.GetRowCellValue(e.RowHandle, "Cantidad"), 0) * IsNull(.GetRowCellValue(e.RowHandle, "ValorFob"), 0), 9))
                .SetRowCellValue(e.RowHandle, "TotalFOB2", Math.Round(IsNull(.GetRowCellValue(e.RowHandle, "TotalFOB1"), 0) * CDbl(tbTC.Text), 9))
                If NewLiq Then
                    '.SetRowCellValue(e.RowHandle, "ValorFob", IsNull(DR.Item(6), 0.0))
                    .SetRowCellValue(e.RowHandle, "CantidadCaja", IIf(.GetRowCellValue(e.RowHandle, "CantidadCaja") Is DBNull.Value, DR.Item(4), .GetRowCellValue(e.RowHandle, "CantidadCaja")))
                    .SetRowCellValue(e.RowHandle, "PrecioVenta", DR.Item(2))
                    .SetRowCellValue(e.RowHandle, "Exento", DR.Item(3))
                    .SetRowCellValue(e.RowHandle, "Moneda", DR.Item(5))
                    .SetRowCellValue(e.RowHandle, "UM", DR.Item(7))
                Else : .SetRowCellValue(e.RowHandle, "CantidadCaja", IIf(.GetRowCellValue(e.RowHandle, "CantidadCaja") Is DBNull.Value, DRT.Item(4), .GetRowCellValue(e.RowHandle, "CantidadCaja")))
                    '.SetRowCellValue(e.RowHandle, "PrecioVenta", IsNull(DRT.Item(6), 0.0))
                    .SetRowCellValue(e.RowHandle, "PrecioVenta", DRT.Item(2))
                    .SetRowCellValue(e.RowHandle, "Exento", DRT.Item(3))
                    .SetRowCellValue(e.RowHandle, "Moneda", DRT.Item(5))
                    .SetRowCellValue(e.RowHandle, "UM", DRT.Item(7))
                End If
                If ckTax.Checked Then
                    .SetRowCellValue(e.RowHandle, "TotalFlete", Math.Round(Factor * CDbl(tbTC.EditValue) * IsNull(.GetRowCellValue(e.RowHandle, "Cantidad"), 0), 9))
                    .SetRowCellValue(e.RowHandle, "TotalCIF", IsNull(.GetRowCellValue(e.RowHandle, "TotalFOB2"), 0) + IsNull(.GetRowCellValue(e.RowHandle, "TotalFlete"), 0))
                Else
                    .SetRowCellValue(e.RowHandle, "TotalFlete", Math.Round(IsNull(.GetRowCellValue(e.RowHandle, "TotalFOB2"), 0) * CDbl(lbFlete.Text), 9))
                    If DR.Item("Exento") = 0 Then 'Or DRT.Item("Exento") = 0 Then
                        IVAProd = (IsNull(.GetRowCellValue(e.RowHandle, "TotalFOB2"), 0) + IsNull(.GetRowCellValue(e.RowHandle, "TotalFlete"), 0)) * IVAEmpresa
                        ArtImpCif += IsNull(.GetRowCellValue(e.RowHandle, "TotalFOB2"), 0) + IsNull(.GetRowCellValue(e.RowHandle, "TotalFlete"), 0) + Math.Round(IVAProd, 2)
                    End If
                    .SetRowCellValue(e.RowHandle, "TotalCIF", IsNull(.GetRowCellValue(e.RowHandle, "TotalFOB2"), 0) + IsNull(.GetRowCellValue(e.RowHandle, "TotalFlete"), 0) + Math.Round(IVAProd, 9))
                End If
                'If NewLiq Then : .SetRowCellValue(e.RowHandle, "LiqDetalleID", 0) : .SetRowCellValue(e.RowHandle, "LiqID", 0) : End If
            End With

            If Timer And e.Column.FieldName = "Cantidad" Then
                'If IsNull(GridView1.GetRowCellValue(e.RowHandle, "Cantidad"), 0) > IsNull(GridView1.GetRowCellValue(e.RowHandle, "Saldo"), 0) Then
                '    MsgBox("La cantidad solicidada ingresada es mayor al saldo. Favor ingrese una cantidad menor o igual a " & IsNull(GridView1.GetRowCellValue(e.RowHandle, "Saldo"), 0))
                '    GridView1.SetRowCellValue(e.RowHandle, "Cantidad", 0)
                'End If 
            End If
        End If
    End Sub

    Private Sub tbFlete1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbFlete1.EditValueChanged, _
    tbBultos.EditValueChanged, tbBultosLiq.EditValueChanged, tbTC.EditValueChanged, tbValorFob.EditValueChanged, _
    tbAnifoda.EditValueChanged

        If Temp > 5 Then
            If CDbl(tbTC.Text) <> 0 Then
                tbTotalFOB.Text = CDbl(tbValorFob.Text) * CDbl(tbTC.Text)
                If ckTax.Checked Then
                    Factor = CDbl(tbFlete1.EditValue) / CDbl(tbBultos.EditValue)
                    tbFlete.Text = Math.Round(Factor * CDbl(tbBultosLiq.EditValue) * CDbl(tbTC.EditValue), 8)
                Else
                    tbFlete.Text = CDbl(tbFlete1.EditValue) * CDbl(tbTC.EditValue)
                    lbFlete.Text = Math.Round(CDbl(tbFlete.Text) / CDbl(tbTotalFOB.Text), 8)
                End If
                tbCIF.Text = CDbl(tbFlete.Text) + CDbl(tbTotalFOB.Text)

                If BandedGridView1.DataRowCount > 0 Then
                    ArtImpCif = 0.0
                    With BandedGridView1
                        For i As Integer = 0 To .DataRowCount
                            .SetRowCellValue(i, "TotalFOB2", Math.Round(IsNull(.GetRowCellValue(i, "TotalFOB1"), 0) * CDbl(tbTC.Text), 9))
                            If ckTax.Checked Then
                                .SetRowCellValue(i, "TotalFlete", Math.Round(Factor * CDbl(tbTC.EditValue) * IsNull(.GetRowCellValue(i, "Cantidad"), 0), 9))
                                .SetRowCellValue(i, "TotalCIF", IsNull(.GetRowCellValue(i, "TotalFOB2"), 0) + IsNull(.GetRowCellValue(i, "TotalFlete"), 0))
                            Else
                                .SetRowCellValue(i, "TotalFlete", Math.Round(IsNull(.GetRowCellValue(i, "TotalFOB2"), 0) * CDbl(lbFlete.Text), 9))
                                If DR.Item("Exento") = 0 Then
                                    IVAProd = (IsNull(.GetRowCellValue(i, "TotalFOB2"), 0) + IsNull(.GetRowCellValue(i, "TotalFlete"), 0)) * IVAEmpresa
                                    ArtImpCif += IsNull(.GetRowCellValue(i, "TotalFOB2"), 0) + IsNull(.GetRowCellValue(i, "TotalFlete"), 0) + Math.Round(IVAProd, 9)
                                End If
                                .SetRowCellValue(i, "TotalCIF", IsNull(.GetRowCellValue(i, "TotalFOB2"), 0) + IsNull(.GetRowCellValue(i, "TotalFlete"), 0) + Math.Round(IVAProd, 2))
                            End If
                        Next

                    End With
                    GridView1_RowUpdated(Nothing, Nothing)
                End If
            End If
        End If
        Temp += 1
    End Sub

    Private Sub tbCIF_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCIF.EditValueChanged
        If Temp > 5 Then If CDbl(tbCIF.Text) < 1 Then lbCIF.Text = "1" Else lbCIF.Text = Math.Round(CDbl(tbCIF.Text) / CDbl(Me.tbValorFob.Text), 7)
    End Sub

    Private Sub GridView1_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs)
        BandedGridView1.UpdateSummary()
        Calc2()
    End Sub

    Private Sub Calc2()
        Dim GastoSimple As Double = 0 : Dim GastoAnifoda As Double = 0

        If BandedGridView1.Columns("TotalCIF").SummaryItem.SummaryValue <> 0 Then
            With GridView3
                For i As Integer = 0 To .DataRowCount - 1
                    If IsNull(.GetRowCellValue(i, "LiqGastoID"), 0) <> 0 And IsNull(.GetRowCellValue(i, "GastoMonto"), 0) <> 0 Then
                        .SetRowCellValue(i, "Porcentaje", Math.Round(.GetRowCellValue(i, "GastoMonto") / BandedGridView1.Columns("TotalCIF").SummaryItem.SummaryValue, 9))
                    End If
                Next i
            End With
            With GridView2
                For j As Integer = 0 To .DataRowCount
                    .SetRowCellValue(j, "Porcentaje", Math.Round(.GetRowCellValue(j, "ImpMonto") / BandedGridView1.Columns("TotalCIF").SummaryItem.SummaryValue, 9))
                Next j
            End With
        End If
        If NewLiq Then
            If GridView2.GetRowCellValue(0, "Monto") <> 0 Then BandedGridView1.Columns("PagoIVA").Visible = True
            If GridView2.GetRowCellValue(2, "Monto") <> 0 Then BandedGridView1.Columns("PagoDAI").Visible = True
        End If

        For l As Integer = 0 To GridView3.RowCount - 1
            If Not GridView3.GetRowCellValue(l, "Desgloce") Then
                GastoSimple += GridView3.GetRowCellValue(l, "Porcentaje")
                'Else
                '    GastoAnifoda = +GridView3.GetRowCellValue(l, "Porcentaje")
            End If
        Next
        'MsgBox(GastoSimple)
        With BandedGridView1
            For k As Integer = 0 To .DataRowCount
                If ckTax.Checked Then
                    .SetRowCellValue(k, "PagoMifin", Math.Round(.GetRowCellValue(k, "TotalCIF") * GridView2.GetRowCellValue(3, "Porcentaje"), 9))
                    .SetRowCellValue(k, "PagoDAI", Math.Round(.GetRowCellValue(k, "TotalCIF") * GridView2.GetRowCellValue(0, "Porcentaje"), 9))
                    .SetRowCellValue(k, "PagoISC", Math.Round(.GetRowCellValue(k, "TotalCIF") * GridView2.GetRowCellValue(1, "Porcentaje"), 9))
                    .SetRowCellValue(k, "PagoIVA", Math.Round(.GetRowCellValue(k, "TotalCIF") * GridView2.GetRowCellValue(2, "Porcentaje"), 9))
                Else
                    If BandedGridView1.Columns("PagoDAI").Visible = True And BandedGridView1.GetRowCellValue(k, "Exento") = 0 Then .SetRowCellValue(k, "PagoDAI", Math.Round(.GetRowCellValue(k, "TotalCIF") * GridView2.GetRowCellValue(0, "Porcentaje"), 9))
                    If BandedGridView1.Columns("PagoIVA").Visible = True And BandedGridView1.GetRowCellValue(k, "Exento") = 0 Then .SetRowCellValue(k, "PagoIVA", Math.Round(.GetRowCellValue(k, "TotalCIF") * GridView2.GetRowCellValue(0, "Porcentaje"), 9))
                    .SetRowCellValue(k, "PagoMifin", Math.Round(.GetRowCellValue(k, "TotalCIF") * GridView2.Columns("Porcentaje").SummaryItem.SummaryValue, 2))
                End If

                .SetRowCellValue(k, "TotalGastos", Math.Round((.GetRowCellValue(k, "TotalCIF") * GastoSimple) + IIf(.GetRowCellValue(k, "UM") = "LTS", .GetRowCellValue(k, "TotalCIF") * tbAnifoda.EditValue / 100, 0) + .GetRowCellValue(k, "Anifoda"), 9)) 'GridView3.Columns("Porcentaje").SummaryItem.SummaryValue, 2))
                .SetRowCellValue(k, "CostoBodega", .GetRowCellValue(k, "TotalCIF") + .GetRowCellValue(k, "PagoMifin") + IsNull(.GetRowCellValue(k, "PagoDAI"), 0) + .GetRowCellValue(k, "TotalGastos"))
                If .GetRowCellValue(k, "Cantidad") <> 0 Then
                    If ckTax.Checked Then
                        .SetRowCellValue(k, "Costo1", Math.Round(.GetRowCellValue(k, "CostoBodega") / ((IsNull(.GetRowCellValue(k, "Cantidad"), 1)) * IsNull(.GetRowCellValue(k, "CantidadCaja"), 1)), 9))
                    Else : .SetRowCellValue(k, "Costo1", Math.Round(.GetRowCellValue(k, "CostoBodega") / (IsNull(.GetRowCellValue(k, "Cantidad"), 1)), 9))
                    End If
                End If
                .SetRowCellValue(k, "Costo2", Math.Round(.GetRowCellValue(k, "Costo1") / CDbl(tbTC.EditValue), 9))
                .SetRowCellValue(k, "Margen", Math.Round((.GetRowCellValue(k, "PrecioVenta") - .GetRowCellValue(k, "Costo1")) / IsNull(.GetRowCellValue(k, "Costo1"), 1), 9))
                .SetRowCellValue(k, "Costo3", Math.Round(((.GetRowCellValue(k, "Cantidad") + .GetRowCellValue(k, "Bonificados")) * .GetRowCellValue(k, "Costo1")) * tbTC.EditValue, 9))
                '        ''lbGlobales.Text = Math.Round(CDbl(tbGlobales.EditValue) / (GridView1.Columns("TotalFOB2").SummaryItem.SummaryValue + GridView1.Columns("TotalFlete").SummaryItem.SummaryValue), 6)
            Next k
        End With
    End Sub

    Private Sub ckTax_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckTax.CheckedChanged
        If ckTax.Checked Then
            BandedGridView1.Columns("PagoDAI").Visible = True
            BandedGridView1.Columns("PagoISC").Visible = True
            BandedGridView1.Columns("PagoIVA").Visible = True
            BandedGridView1.Columns("PagoMifin").Caption = "Imp. Globales"
            BandedGridView1.Columns("Margen").OptionsColumn.ReadOnly = False
            tbBultos.Visible = True : tbBultosLiq.Visible = True
            Label8.Visible = True : Label9.Visible = True
        Else
            BandedGridView1.Columns("PagoDAI").Visible = False
            BandedGridView1.Columns("PagoISC").Visible = False
            BandedGridView1.Columns("PagoIVA").Visible = False
            BandedGridView1.Columns("PagoMifin").Caption = "Pago MIFIN"
            BandedGridView1.Columns("Margen").OptionsColumn.ReadOnly = False
            tbBultos.Visible = False : tbBultosLiq.Visible = False
            Label8.Visible = False : Label9.Visible = False
        End If
    End Sub

    Private Sub GridView3_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView3.RowUpdated, GridView2.RowUpdated
        GridView3.UpdateSummary() : GridView2.UpdateSummary()
        tbGranTotal.Text = GridView3.Columns("GastoMonto").SummaryItem.SummaryValue + GridView2.Columns("ImpMonto").SummaryItem.SummaryValue
        If BandedGridView1.DataRowCount <> 0 Then Calc2()
    End Sub

    Private Sub GridControl2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl2.Enter
        Dim Impuesto As Integer
        If ckTax.Checked Then Impuesto = 1 Else Impuesto = 2
        If GridView2.DataRowCount = 0 Then 'And ckTax.Checked Then
            Dim Variables As New ArrayList
            Dim Datos As New ArrayList
            Variables.Clear() : Datos.Clear()
            Variables.Add("CIF")
            Variables.Add("LiqID")
            Variables.Add("Empresa")
            Variables.Add("Origen")
            Datos.Add(tbCIF.EditValue)
            Datos.Add(LiqID)
            Datos.Add(EmpresaActual)
            Datos.Add(Impuesto)
            DT2 = ProcedureParameters(Datos, Variables, "_LiquidacionesGetCalcMific")
            GridControl2.DataSource = DT2
        End If
        GridView3_RowUpdated(Nothing, Nothing)
    End Sub

    Private Sub Gridview1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = System.Windows.Forms.MouseButtons.Right And Origen <> 1 Then
            'GridView1.DeleteRow(GridView1.FocusedRowHandle)
            'GridView1.UpdateSummary()
            'Calc2()
        End If
    End Sub

    Private Sub Gridview3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridView3.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            GridView3.DeleteRow(GridView3.FocusedRowHandle)
            GridView3_RowUpdated(Nothing, Nothing)
        End If
    End Sub

    Private Sub ckSelectData_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckSelectData.CheckedChanged
        If ckSelectData.Checked Then BandedGridView1.ColumnsCustomization() : BandedGridView1.CustomizationForm.Height = 300 Else BandedGridView1.DestroyCustomization()
    End Sub

    Private Sub GridView1_HideCustomizationForm(ByVal sender As Object, ByVal e As System.EventArgs)
        ckSelectData.Checked = False
    End Sub

    Private Sub lArticulo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles lArticulo.ButtonClick
        'If e.Button.Index = 1 Then
        '    Dim f As New frmAgregarArticuloQuick
        '    f.WindowState = FormWindowState.Normal
        '    f.StartPosition = FormStartPosition.CenterScreen
        '    '            f.Origen = 1
        '    f.etTipo.Text = "P"
        '    f.lbProvTemporal.Text = cbProveedor.EditValue
        '    f.cbProveedores.SelectedValue = f.lbProvTemporal.Text
        '    If f.ShowDialog = DialogResult.OK Then
        '        If IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Codigo")) OrElse GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Codigo") = Nothing Then
        '            GridView1.InvalidateRow(GridView1.FocusedRowHandle)
        '            GridView1.AddNewRow()
        '        End If
        '        LoadArticulo()
        '        For i As Integer = 0 To GridView1.DataRowCount
        '            MsgBox(GridView1.GetRowCellValue(i, Articulo))
        '        Next
        '        GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Codigo", f.txtCodigo.Text)
        '    End If
        'End If

    End Sub

    Private Sub GridView3_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView3.CellValueChanged
        If NewLiq = True Then
            If e.Column.FieldName = "GastoMonto" Then
                GridView3.SetFocusedRowCellValue(LiqDetGastoID, 0)
            End If
        End If
    End Sub

    Private Sub ReadGrid(ByVal i As Integer, ByVal Grid As Integer)
        With DT4
            If Grid <> 1 Then
                If Grid = 3 Then
                    Conn.AddParameter("LiqDetalleID", SqlDbType.Int, 5, ParameterDirection.Input, .Rows(i).Item("LiqDetGastoID", DataRowVersion.Current))
                    Conn.AddParameter("GastoID", SqlDbType.Int, 5, ParameterDirection.Input, .Rows(i).Item("LiqGastoID", DataRowVersion.Current))
                    Conn.AddParameter("Monto", SqlDbType.Money, 5, ParameterDirection.Input, .Rows(i).Item("GastoMonto", DataRowVersion.Current))
                    Conn.AddParameter("Origen", SqlDbType.Bit, 1, ParameterDirection.Input, True)
                ElseIf Grid = 2 Then
                    If .Rows(i).Item("ImpMonto") <> 0 Then
                        Conn.AddParameter("LiqDetalleID", SqlDbType.Int, 5, ParameterDirection.Input, .Rows(i).Item("LiqDetImpuestoID", DataRowVersion.Current))
                        Conn.AddParameter("GastoID", SqlDbType.Int, 5, ParameterDirection.Input, .Rows(i).Item("ImpuestoID", DataRowVersion.Current))
                        Conn.AddParameter("Monto", SqlDbType.Money, 5, ParameterDirection.Input, .Rows(i).Item("ImpMonto", DataRowVersion.Current))
                        Conn.AddParameter("Origen", SqlDbType.Bit, 1, ParameterDirection.Input, False)
                    End If
                End If
                Conn.AddParameter("LiqID", SqlDbType.Int, 5, ParameterDirection.Input, LiqID)
                Conn.AddParameter("Nuevo", SqlDbType.Bit, 1, ParameterDirection.Input, NewLiq)
                Conn.AddParameter("FacturaID", SqlDbType.Int, 1, ParameterDirection.Input, CInt(FacSelec))
                Conn.AddParameter("ProveedorID", SqlDbType.Int, 5, ParameterDirection.Input, cbProveedor.EditValue)
                Conn.AddParameter("Desgloce", SqlDbType.Bit, 1, ParameterDirection.Input, .Rows(i).Item("Desgloce"))
                Conn.AddParameter("FacturaNo", SqlDbType.NVarChar, 20, ParameterDirection.Input, .Rows(i).Item("Origen"))
                Conn.EjecutarComando("_LiquidacionAddGastoImpuesto")
            Else
                Conn.AddParameter("LiqDetalleID", SqlDbType.Int, 5, ParameterDirection.Input, .Rows(i).Item("LiqDetalleID", DataRowVersion.Current))
                Conn.AddParameter("LiqID", SqlDbType.Int, 5, ParameterDirection.Input, LiqID)
                Conn.AddParameter("ArticuloID", SqlDbType.NVarChar, 50, ParameterDirection.Input, .Rows(i).Item("ArticuloID", DataRowVersion.Current))
                Conn.AddParameter("ValorFob", SqlDbType.Money, 20, ParameterDirection.Input, .Rows(i).Item("ValorFob", DataRowVersion.Current))
                Conn.AddParameter("CantidadCaja", SqlDbType.Float, 10, ParameterDirection.Input, 1) 'CDbl(IIf(.Rows(i).Item("CantidadCaja", DataRowVersion.Current) = "", 0, .Rows(i).Item("CantidadCaja", DataRowVersion.Current))))
                Conn.AddParameter("Cantidad", SqlDbType.Float, 10, ParameterDirection.Input, .Rows(i).Item("Cantidad", DataRowVersion.Current))
                Conn.AddParameter("Bonificados", SqlDbType.Float, 10, ParameterDirection.Input, .Rows(i).Item("Bonificados", DataRowVersion.Current))
                'Conn.AddParameter("Descuento", SqlDbType.Float, 10, ParameterDirection.Input, .Rows(i).Item("Descuento", DataRowVersion.Current))
                Conn.AddParameter("Modified", SqlDbType.Bit, 1, ParameterDirection.Input, .Rows(i).Item("Modified", DataRowVersion.Current))
                Conn.AddParameter("EmpresaID", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                Conn.AddParameter("Nuevo", SqlDbType.Bit, 1, ParameterDirection.Input, NewLiq)
                'Conn.AddParameter("Tipo", SqlDbType.Int, 1, ParameterDirection.Input, Origen)
                Conn.AddParameter("IDFactura", SqlDbType.Int, 5, ParameterDirection.Input, CInt(.Rows(i).Item("IDFactura", DataRowVersion.Current)))
                Conn.EjecutarComando("_LiquidacionAddDetalle")
            End If
        End With
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim f As frmLiquidacionList = frmLiquidacionList.Instance
        f.Refrescar()
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Conn.IniciarTransaccion()
        Try
            Conn.RemoveParameters()
            Conn.AddParameter("LiqID", SqlDbType.Int, 5, ParameterDirection.Output, LiqID)
            If Origen = 2 And NewLiq Then Conn.AddParameter("LiqIBID", SqlDbType.Int, 5, ParameterDirection.Input, LiqID)
            Conn.AddParameter("Fecha", SqlDbType.DateTime, 20, ParameterDirection.Input, dtFechaLiq.DateTime.Date)
            Conn.AddParameter("Impuesto", SqlDbType.Bit, 1, ParameterDirection.Input, ckTax.Checked)
            Conn.AddParameter("ProveedorID", SqlDbType.Int, 5, ParameterDirection.Input, cbProveedor.EditValue)
            Conn.AddParameter("TC", SqlDbType.Float, 5, ParameterDirection.Input, tbTC.EditValue)
            'Conn.AddParameter("Factura", SqlDbType.NChar, 10, ParameterDirection.Input, tbFactura.Text.Trim)
            Conn.AddParameter("Factura", SqlDbType.NChar, 10, ParameterDirection.Input, tbFactura.Text)
            Conn.AddParameter("FOB", SqlDbType.Decimal, 10, ParameterDirection.Input, tbValorFob.EditValue)
            Conn.AddParameter("Flete", SqlDbType.Decimal, 10, ParameterDirection.Input, tbFlete1.EditValue)
            Conn.AddParameter("BultosIn", SqlDbType.Decimal, 10, ParameterDirection.Input, IIf(ckTax.Checked, tbBultos.EditValue, BandedGridView1.Columns("Cantidad").SummaryItem.SummaryValue))
            Conn.AddParameter("BultosLiq", SqlDbType.Decimal, 10, ParameterDirection.Input, IIf(ckTax.Checked, tbBultosLiq.EditValue, BandedGridView1.Columns("Cantidad").SummaryItem.SummaryValue))
            Conn.AddParameter("Cuenta", SqlDbType.NChar, 10, ParameterDirection.Input, tbCuenta.Text)
            Conn.AddParameter("Poliza", SqlDbType.NChar, 10, ParameterDirection.Input, tbPoliza.Text)
            Conn.AddParameter("Recibo", SqlDbType.NChar, 10, ParameterDirection.Input, tbRecibo.Text)
            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Conn.AddParameter("Nuevo", SqlDbType.Bit, 1, ParameterDirection.Input, NewLiq)
            Conn.AddParameter("FechaBodega", SqlDbType.DateTime, 20, ParameterDirection.Input, dtBodega.DateTime)
            'Conn.AddParameter("Tipo", SqlDbType.Int, 1, ParameterDirection.Input, Origen)

            Conn.EjecutarComando("_LiquidacionAdd")
            If NewLiq = True Then LiqID = Conn.GetParameter("LiqID").Valor
            Conn.RemoveParameters()

            If NewLiq Then For b As Int16 = 0 To GridView2.DataRowCount - 1 : GridView2.SetRowCellValue(b, "LiqID", LiqID) : Next
            If NewLiq Then For a As Int16 = 0 To GridView2.DataRowCount - 1 : GridView2.SetRowCellValue(a, "LiqDetImpuestoID", 0) : Next

            DT4 = DT3.GetChanges(DataRowState.Added)
            If Not DT4 Is Nothing Then
                For i As Integer = 0 To (DT4.Rows.Count - 1)
                    ReadGrid(i, 3)
                Next
                DT4.Clear()
                Conn.RemoveParameters()
            End If
            DT4 = DT3.GetChanges(Data.DataRowState.Modified)
            If Not DT4 Is Nothing Then
                For i As Integer = 0 To (DT4.Rows.Count - 1)
                    ReadGrid(i, 3)
                Next
                DT4.Clear()
                Conn.RemoveParameters()
            End If

            'DT4 = DT2.GetChanges(DataRowState.Added)
            'If Not DT4 Is Nothing Then
            '    For i As Integer = 0 To (DT4.Rows.Count - 1)
            '        ReadGrid(i, 2)
            '    Next
            '    DT4.Clear()
            '    Conn.RemoveParameters()
            'End If
            'DT4 = DT2.GetChanges(Data.DataRowState.Modified)
            'If Not DT4 Is Nothing Then
            '    For i As Integer = 0 To (DT4.Rows.Count - 1)
            '        ReadGrid(i, 2)
            '    Next
            '    DT4.Clear()
            '    Conn.RemoveParameters()
            'End If

            DT4 = DT1.GetChanges(DataRowState.Added)
            If Not DT4 Is Nothing Then
                For i As Integer = 0 To (DT4.Rows.Count - 1)
                    ReadGrid(i, 1)
                Next
                DT4.Clear()
                Conn.RemoveParameters()
            End If
            DT4 = DT1.GetChanges(Data.DataRowState.Modified)
            If Not DT4 Is Nothing Then
                For i As Integer = 0 To (DT4.Rows.Count - 1)
                    If ALiquidar1 = False Then
                        ReadGrid(i, 1)
                    Else
                        If DT4.Rows(i).Item(0) = True Then
                            ReadGrid(i, 1)
                        End If
                    End If
                Next
                DT4.Clear()

                Conn.RemoveParameters()
            End If
            'Conn.AnularTransaccion()

            cmdPrint.Enabled = True
            cmdImportar.Enabled = True
            cbProveedor.Enabled = False : cmdSave.Enabled = False : NewLiq = False

            For i As Int16 = 0 To BandedGridView1.DataRowCount - 1
                BandedGridView1.SetRowCellValue(i, ValorFob, DT1.Rows(i).Item("ValorFob"))
                BandedGridView1.SetRowCellValue(i, "Cantidad", DT1.Rows(i).Item("Cantidad"))
            Next

            Conn.CompletarTransaccion()
            'REVIEW
            'If ALiquidar1 Then
            '    ReloadGrid(LiqID)
            '    For i As Int16 = 0 To GridView1.DataRowCount - 1
            '        GridView1.SetRowCellValue(i, ValorFob, DT1.Rows(i).Item("ValorFob"))
            '        GridView1.SetRowCellValue(i, "Cantidad", DT1.Rows(i).Item("Cantidad"))
            '    Next
            '    GridView1_RowUpdated(Nothing, Nothing)
            'End If
            BandedGridView1.Columns("ALiquidar").Visible = False : BandedGridView1.Columns("Saldo").Visible = False
            If Origen = 1 Then SimpleButton1_Click(Nothing, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message & "Guardar")
            Conn.AnularTransaccion()
            Exit Sub
        End Try
        tbLiqNo.Text = ObtieneDatos("SELECT LiqNo FROM Liquidaciones WHERE LiqID=" & LiqID).Rows(0).Item(0)
        BandedGridView1.MoveLastVisible()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Dim DTR As DataTable
        Dim Rep1 As New rptEncabezado
        Dim Rep2 As rptSubReport1
        Dim Rep3 As rptSubReport2

        DTR = GetEncabezados(1)
        Rep1.DataSource = DTR
        Rep1.ShowPreview()
        DTR.Dispose()

        'DTR = GetEncabezados(2)
        'Rep2.datasource = DTR
        'DTR.Dispose()

    End Sub

    Private Sub cmdImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImportar.Click
        Dim First, Last, Prox As Int16
        Dim Cuentas(BandedGridView1.DataRowCount - 1) As String
        Dim Montos(BandedGridView1.DataRowCount - 1) As Double
        Dim IRAlcaldiaPAgado, IvaAsumido As Boolean
        Dim Articulos As New VB.SysContab.ArticulosDB
        Dim DetallesProducto As New VB.SysContab.ArticulosDetails
        Dim TipoFactura As Integer

        Dim j, x As Int16 : Dim CuentaTemp As String = ""

        Dim FacturaID As String
        Dim LiqNo As Integer

        Dim DTContab As New DataTable
        DTContab = ObtieneDatos("SELECT ir_pagado_alcaldia,Iva_Asumido,FormaPago_ID FROM Facturas_Compras WHERE Factura_ID IN ('" & tbFactura.Text & "')")
        IRAlcaldiaPAgado = DTContab.Rows(0).Item(0)
        IvaAsumido = DTContab.Rows(0).Item(1)
        TipoFactura = DTContab.Rows(0).Item(2)

        Conn.IniciarTransaccion() : Conn.RemoveParameters()

        LiqNo = tbLiqNo.Text 'ObtieneDatos("SELECT LiqNo FROM Liquidaciones WHERE LiqID=" & LiqID).Rows(0).Item(0)
        Try

            If cbProveedor.GetColumnValue("Cuenta") Is Nothing Or cbProveedor.GetColumnValue("Cuenta") = "" Then
                MsgBox("No se puede realizar la importación de la mercadería al sistema" & vbCrLf & "ya que este proveedor no tiene cuenta contable asignada.", MsgBoxStyle.Information, formtitulo)
                Exit Try
            End If

            'Se obitene el id de la factura que se genero por la orden de compra
            'FacturaID = ObtieneDatos("SELECT isnull(fc.Factura_ID,'') FROM liquidaciones l JOIN ORDENES_COMPRAS oc ON l.OrdenCompraID = oc.OrdenCompra " & _
            '                     "LEFT JOIN facturas_compras fc ON oc.OrdenCompra = fc.OrdenCompra_ID AND oc.Empresa_ID = fc.Empresa_ID AND " & _
            '                     "oc.Proveedor_ID = fc.Proveedor_ID WHERE l.LiqID = " & LiqID).Rows(0).Item(0)

            'IRAlcaldiaPAgado = ObtieneDatos("SELECT ir_pagado_alcaldia FROM Facturas_Compras WHERE Empresa_ID=" & EmpresaActual & " AND Factura_ID='" & tbFactura.Text & "'").Rows(0).Item(0)

            'For i = 0 To Me.vFacturas.DataRowCount - 1 'tCust.Rows.Count - 1
            '    DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(Me.vFacturas.GetRowCellValue(i, "Codigo"), "P", EmpresaActual)
            '    If DetallesProducto.Cuenta = "" Or DetallesProducto.Cuenta = "0" Then
            '        MsgBox("No se puede contabilizar la entrada a almacen de la factura, porque no hay cuenta contable para el producto: " & DetallesProducto.Nombre, MsgBoxStyle.Critical, "STS-Contab")
            '        Exit Sub
            '    Else
            '        j = Cuentas.IndexOf(Cuentas, DetallesProducto.Cuenta)
            '        'Si no encuentra la cuenta contable en el arreglo, la adiciona
            '        If j = -1 Then
            '            Cuentas(x) = DetallesProducto.Cuenta
            '            Montos(x) = Me.vFacturas.GetRowCellValue(i, "SubTotal")
            '            x += 1
            '        Else
            '            Montos(j) = Montos(j) + Me.vFacturas.GetRowCellValue(i, "SubTotal")
            '        End If
            '    End If
            'Next

            For i As Int16 = 0 To BandedGridView1.DataRowCount - 1
                DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(BandedGridView1.GetRowCellValue(i, "ArticuloID"), "P", EmpresaActual)
                If DetallesProducto.Cuenta = "" Or DetallesProducto.Cuenta = "0" Then
                    CuentaTemp = BandedGridView1.GetRowCellDisplayText(i, "ArticuloID") + ","
                End If
            Next

            If CuentaTemp.Trim <> "" Then
                If CuentaTemp.EndsWith(",") Then CuentaTemp = CuentaTemp.Remove(CuentaTemp.Length - 1, 1)
                MsgBox("No se puede realizar la importación de la mecadería ya que el siguiente(s) articulo(s) no tiene(n) cuenta contable:" & vbCrLf & CuentaTemp)
                Exit Try
            Else
                For i As Int16 = 0 To BandedGridView1.RowCount - 1
                    j = Cuentas.IndexOf(Cuentas, DetallesProducto.Cuenta)
                    'Si no encuentra la cuenta contable en el arreglo, la adiciona
                    If j = -1 Then
                        Cuentas(x) = DetallesProducto.Cuenta
                        Montos(x) = BandedGridView1.GetRowCellValue(i, "CostoBodega") 'tCust.Rows(i)("SubTotal")
                        x += 1
                    Else
                        Montos(j) = Montos(j) + BandedGridView1.GetRowCellValue(i, "CostoBodega")
                    End If
                Next
            End If

            Conn.AddParameter("Facturas", SqlDbType.NVarChar, 50, ParameterDirection.Input, tbFactura.EditValue)
            Conn.AddParameter("Proveedor", SqlDbType.Int, 5, ParameterDirection.Input, cbProveedor.EditValue)
            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Conn.AddParameter("LiqNo", SqlDbType.Int, 10, ParameterDirection.Input, LiqNo)
            Conn.AddParameter("Succesful", SqlDbType.Bit, 1, ParameterDirection.Output, 0)
            Conn.EjecutarComando("SPJLiquidaciones_Fact_Bodega")


            If Conn.GetParameter("Succesful").Valor = False Then
                MsgBox("El sistema ha encotrado un error en al momento de actualizar las facturas de compras." & vbCrLf & "Favor contactar al administrador.")
                Conn.AnularTransaccion()
                Exit Try
            End If
            Conn.RemoveParameters()

            Dim Bodegas As VB.SysContab.BodegasDB
            Dim Facturas As VB.SysContab.Facturas_ComprasDB
            'Dim Articulos As New VB.SysContab.ArticulosDB



            With BandedGridView1
                DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
                DBConnFacturas.Open()
                transaccionFacturas = DBConnFacturas.BeginTransaction

                For i As Int16 = 0 To .DataRowCount - 1

                    Bodegas.Bodega_Articulos_Add("1", .GetRowCellValue(i, "ArticuloID"), .GetRowCellValue(i, "Cantidad") + .GetRowCellValue(i, "Bonificados"), .GetRowCellValue(i, "Costo1"), "P")
                    Bodegas.TransaccionBodegaDetalle_Add("1", .GetRowCellValue(i, "ArticuloID"), "L", LiqNo, "E", .GetRowCellValue(i, "Cantidad"), .GetRowCellValue(i, "PrecioVenta"), cbProveedor.EditValue, "P")

                    Conn.AddParameter("LiqID", SqlDbType.Int, 5, ParameterDirection.Input, LiqID)
                    Conn.AddParameter("ArticuloID", SqlDbType.NVarChar, 50, ParameterDirection.Input, .GetRowCellValue(i, "ArticuloID"))
                    Conn.AddParameter("Tipo", SqlDbType.Char, 1, ParameterDirection.Input, "P")
                    Conn.AddParameter("IDFactura", SqlDbType.Int, 3, ParameterDirection.Input, .GetRowCellValue(i, "IDFactura"))
                    Conn.AddParameter("Proveedor", SqlDbType.Int, 3, ParameterDirection.Input, cbProveedor.EditValue)
                    Conn.AddParameter("IvaAlmacen", SqlDbType.Int, 3, ParameterDirection.Input, .GetRowCellValue(i, "PagoIVA"))
                    Conn.AddParameter("Cantidad", SqlDbType.Int, 3, ParameterDirection.Input, .GetRowCellValue(i, "Cantidad") + .GetRowCellValue(i, "Bonificados"))
                    Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                    Conn.EjecutarComando("SPJLiquidaciones_UpdateAlmacen")
                    Conn.RemoveParameters()

                    Articulos.SumarExistencias(DT1.Rows(i).Item("ArticuloID"), DT1.Rows(i).Item("Cantidad") + DT1.Rows(i).Item("Bonificados"), "P")
                    Articulos.UpdateCosto(DT1.Rows(i).Item("ArticuloID"), DT1.Rows(i).Item("Costo1"), "P", DT1.Rows(i).Item("Cantidad") + DT1.Rows(i).Item("Bonificados"))
                    'Articulos.SumarExistencias(.GetRowCellValue(i, "ArticuloID"), .GetRowCellValue(i, "Cantidad") + .GetRowCellValue(i, "Bonificados"), "P")
                    'Articulos.UpdateCosto(.GetRowCellValue(i, "ArticuloID"), .GetRowCellValue(i, "Costo1"), "P", .GetRowCellValue(i, "Cantidad") + .GetRowCellValue(i, "Bonificados"))
                Next

                'Para actualizar el estado de la orden de compra si esta existe.
                'Conn.AddParameter("FactuasID", SqlDbType.NVarChar, 30, ParameterDirection.Input, Me.FacSelec)
                'Conn.AddParameter("EmpresaID", SqlDbType.Int, 1, ParameterDirection.Input, EmpresaActual)
                'Conn.EjecutarComando("SPJLiquidaciones_UpdateOrdenes")
                'Conn.RemoveParameters()

                ': Dim IRAlcaldiaPAgado As Boolean
                '''Dim Cuentas(GridView1.RowCount - 1) As String
                '''Dim Montos(GridView1.RowCount - 1) As Double
                '''Dim x As Int16
                '''DTContab = ObtieneDatos("SELECT ir_pagado_alcaldia,Iva_Asumindo FROM Facturas_Compras FC JOIN LiquidacionesDetalle ld ON FC.IDFactura = ld.IDFactura " & _
                '''"JOIN Liquidaciones l ON ld.LiqID = l.LiqID AND fc.Empresa_ID = l.EmpresaID WHERE ld.LiqID =" & Me.LiqID)


                '''For t As Integer = 0 To DTContab.Rows.Count
                '''    x = 0
                '''    For k As Integer = 0 To GridView1.DataRowCount - 1
                '''        If GridView1.GetRowCellValue(k, "IDFactura") = DTContab.Rows(k).Item(2) Then
                '''            Cuentas(x) = GridView1.GetRowCellValue(k, "Cuenta")
                '''            Montos(x) = GridView1.GetRowCellValue(k, "Costo1") - GridView1.GetRowCellValue(k, "PagoIVA")
                '''            x += 1
                '''        End If
                '''    Next

                '''    'IRAlcaldiaPAgado = ObtieneDatos("SELECT ir_pagado_alcaldia FROM Facturas_Compras WHERE IDFactura = " & DTContab.Rows(0).Item(1)).Rows(0).Item(0)
                If Contabilizar(Cuentas, Montos, IRAlcaldiaPAgado, tbFactura.Text, IvaAsumido, TipoFactura) = False Then
                    VB.SysContab.Rutinas.ErrorTransaccion()
                    Conn.AnularTransaccion()
                    Exit Sub
                End If
                ObtieneDatos("Update Liquidaciones set Estado=1 where liqno = " & tbLiqNo.Text)
                transaccionFacturas.Commit()
                DBConnFacturas.Close()
            End With
            cmdImportar.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, formtitulo)
            Conn.RemoveParameters()
            Conn.AnularTransaccion()
            Exit Sub
        End Try
        Conn.RemoveParameters()
        Conn.CompletarTransaccion()
        'SimpleButton1_Click(Nothing, Nothing)
    End Sub

    Private Function Contabilizar(ByVal Cuentas() As String, ByVal Montos() As Double, ByVal IRAlcaldiaPagado As Boolean, _
                                  ByVal LaFactura As String, ByVal IvaAsumido As Boolean, ByVal FacturaTipo As Integer) As Boolean
        Dim IRxPagar As Double = 0
        Dim IRPorcentaje As Double = 0
        Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails
        'Dim IvaAsumido As Boolean = False
        Dim SubTotalParaIVA As Double
        'If Ir_Serv Then IRPorcentaje = ConfigDetalles.IRServ
        'If Ir_Prod Then IRPorcentaje = ConfigDetalles.IRProd
        'IvaAsumido = ObtieneDatos("SELECT Iva_Asumido FROM Facturas_Compras WHERE Factura_ID = '" & LaFactura & "' AND Proveedor_ID = " & cbProveedor.EditValue).Rows(0).Item(0)
        IRPorcentaje = ConfigDetalles.IRProd

        If IvaAsumido Then

            'SubTotalParaIVA = GridView1.Columns("Costo1").SummaryItem.SummaryValue - GridView1.Columns("PagoIVA").SummaryItem.SummaryValue '(tCust.Compute("Sum(Subtotal)", "exiva = 0 ") * ConfigDetalles.IVA / 100) / (1 + (ConfigDetalles.IVA / 100))
        End If

        If (BandedGridView1.Columns("CostoBodega").SummaryItem.SummaryValue - BandedGridView1.Columns("PagoIVA").SummaryItem.SummaryValue) >= ConfigDetalles.MontoIR Then
            IRxPagar = CDbl((BandedGridView1.Columns("CostoBodega").SummaryItem.SummaryValue - IIf(IvaAsumido, (SubTotalParaIVA * (ConfigDetalles.IVA / 100.0)).ToString(Round), BandedGridView1.Columns("PagoIVA").SummaryItem.SummaryValue)) * Math.Round((IRPorcentaje / 100), 2))
        End If

        Dim Comprobantes As New VB.SysContab.ComprobanteDB
        Dim CompNo As String
        Dim Tipo As String
        Dim TipoCompr As String
        Dim EmpresasDB As New VB.SysContab.EmpresasDB
        Dim PeriodosDB As New VB.SysContab.PeriodosDB
        Dim Proveedores As New VB.SysContab.ProveedoresDB
        Dim DetallesProveedor As New VB.SysContab.ProveedoresDetails
        Dim ds As DataSet
        Dim Plantilla As New VB.SysContab.PlantillaDB
        Dim plan As String
        Dim i As Integer
        Dim Muni As New VB.SysContab.MunicipiosDB
        Dim MunDet As VB.SysContab.MunicipioDetails = Muni.GetDetails(VB.SysContab.ProveedoresDB.GetDetails(cbProveedor.EditValue).Departamento, VB.SysContab.ProveedoresDB.GetDetails(cbProveedor.EditValue).Municipio)
        Dim FormaPago As New VB.SysContab.Forma_PagoDB


        'TipoFactura = ObtieneDatos("SELECT FormaPago_ID FROM Facturas_Compras WHERE Factura_ID = " & LaFactura).Rows(0).Item(0)
        'CALCULANDO IR PAGADO A ALCALDIA
        Dim ValorIRAlcaldia As Double

        If IRAlcaldiaPagado = True Then

            If VB.SysContab.ProveedoresDB.GetDetails(cbProveedor.EditValue).Departamento = "0" And VB.SysContab.ProveedoresDB.GetDetails(cbProveedor.EditValue).Municipio = "0" Then
                MsgBox("No se puede completar la facturación, por favor ingrese departamento o municipio", MsgBoxStyle.Critical)
                VB.SysContab.Rutinas.ErrorTransaccion()
                Exit Function
            End If

            'se quito el 15042008 rmpr
            'If CDbl(Me.etSubTotal.Text) >= MunDet.Impuesto_SVenta_Min Then
            If CDbl((BandedGridView1.Columns("CostoBodega").SummaryItem.SummaryValue - IIf(IvaAsumido, (SubTotalParaIVA * (ConfigDetalles.IVA / 100.0)).ToString(Round), BandedGridView1.Columns("PagoIVA").SummaryItem.SummaryValue))).ToString(Round) >= MunDet.Impuesto_SVenta_Min Then
                ValorIRAlcaldia = CDbl((BandedGridView1.Columns("CostoBodega").SummaryItem.SummaryValue - IIf(IvaAsumido, (SubTotalParaIVA * (ConfigDetalles.IVA / 100.0)).ToString(Round), BandedGridView1.Columns("PagoIVA").SummaryItem.SummaryValue))).ToString(Round) * (MunDet.Impuesto_SVenta / 100) 'CDbl(Me.etSubTotal.Text) * (MunDet.Impuesto_SVenta / 100)
            Else
                ValorIRAlcaldia = 0
            End If
        Else
            ValorIRAlcaldia = 0
        End If

        If FormaPago.FormaPagoDias(FacturaTipo) = 0 Then  'Contado
            'Factura de Contado
            plan = Plantilla.GetTipoPlantilla(1, 6).ToString

            If plan = "" Or plan Is DBNull.Value Then
                MsgBox("No hay plantilla disponible para realizar esta transacción", MsgBoxStyle.Information)
                Return False
                Exit Function
            End If
            Dim Detalles As VB.SysContab.PlantillaDetails = Plantilla.GetPlantillasDetails(plan)
            ds = Detalles.Detalles

            TipoCompr = Detalles.TipoCompr
            ' en el campo Tipo, se enviaba '0' y segun la tabla de Comprobantes, ese campo debe tener 1 si es factura de proveedor
            CompNo = Comprobantes.AddComprobante(TipoCompr, 1, _
                "Comprobante de Factura de Compra de Contado a Proveedor #" & LaFactura, _
                EmpresasDB.GetDetails(EmpresaActual).MonedaBase, _
                PeriodosDB.Activo(dtBodega.DateTime.Date), dtBodega.DateTime.Date, 0, "", False, Me.cbProveedor.EditValue, "", 1, LaFactura, _
                VB.SysContab.Rutinas.Fecha, TipoFactura, OrigenComprobantes.ENTRADA_ALMACEN)

            'Agregar las lineas de las cuentas de los productos
            Dim x As Integer
            Dim SumaMontos As Double
            SumaMontos = 0
            For x = 0 To Cuentas.GetUpperBound(0)
                If Cuentas(x) <> "" Then
                    SumaMontos += Montos(x)
                    Comprobantes.AddComprobanteDetalles(CompNo, Cuentas(x), "", Montos(x), 0, TipoCompr, "D", LaFactura, 0, Today.Date, 1)
                End If
            Next
            'Si son servicios los que se estan comprando de contado
            If SumaMontos >= ConfigDetalles.MontoIR Then
                SumaMontos = SumaMontos * Math.Round((ConfigDetalles.IRProd / 100), 2)
            End If

            'Agregar la linea del IR
            ' If Me.ckIR.Checked Then
            If DetallesProveedor.Exento = False Then

                '(etTotal.Text - BandedGridView1.Columns("IVA").SummaryItem.SummaryValue) >= ConfigDetalles.MontoIR Then
                If CDbl((BandedGridView1.Columns("CostoBodega").SummaryItem.SummaryValue - IIf(IvaAsumido, (SubTotalParaIVA * (ConfigDetalles.IVA / 100.0)).ToString(Round), BandedGridView1.Columns("PagoIVA").SummaryItem.SummaryValue))).ToString(Round) >= ConfigDetalles.MontoIR Then
                    'Agregar la linea del IR
                    Comprobantes.AddComprobanteDetalles(CompNo, ds.Tables("PlantillasDetalles").Rows(0).Item("Cuenta"), "", IRxPagar, 0, TipoCompr, "C", LaFactura, 0, Today.Date, 1)
                End If
                'Agregar la linea del IR

            End If
            'End If
            If IsNull(BandedGridView1.Columns("PagoIVA").SummaryItem.SummaryValue, 0) <> 0 Then
                'Se agrega la cuenta del IVA
                Comprobantes.AddComprobanteDetalles(CompNo, ds.Tables("PlantillasDetalles").Rows(1).Item("Cuenta"), "", BandedGridView1.Columns("PagoIVA").SummaryItem.SummaryValue, 0, TipoCompr, "D", LaFactura, 0, Today.Date, 1)
            End If
            'Se agrega la cuenta del banco
            Comprobantes.AddComprobanteDetalles(CompNo, ds.Tables("PlantillasDetalles").Rows(2).Item("Cuenta"), "Banco", BandedGridView1.Columns("TotalFOB2").SummaryItem.SummaryValue - IRxPagar - ValorIRAlcaldia, 0, TipoCompr, "C", LaFactura, 0, Today.Date, 1)

            ' AGREGANDO LA CUENTA DE IR D ALCALDIA

            If ValorIRAlcaldia > 0 Then
                Comprobantes.AddComprobanteDetalles(CompNo, ds.Tables("PlantillasDetalles").Rows(3).Item("Cuenta"), "I.R. Alcaldia", ValorIRAlcaldia, 0, TipoCompr, "C", LaFactura, 0, Today.Date, 1)
            End If
            '*********************************************************
            '
            'Cancelar la Factura de Contado
            Comprobantes.CancelarFactura(LaFactura, cbProveedor.EditValue, 1)
        Else
            plan = Plantilla.GetTipoPlantilla(2, 6).ToString

            If plan = "" Or plan Is DBNull.Value Then
                MsgBox("No hay plantilla disponible para realizar esta transacción", MsgBoxStyle.Information)
                Return False
                Exit Function
            End If

            Dim Detalles As VB.SysContab.PlantillaDetails = Plantilla.GetPlantillasDetails(plan)
            ds = Detalles.Detalles

            TipoCompr = Detalles.TipoCompr
            'Antes se enviaba de manera fija el valor '0' para la forma de pago, aunque no fuere una factura de contado, pq ??? se cambio al contenido del combobox TipoFactura RMPR: 09/04/2007,
            ' en el campo Tipo, se enviaba '0' y segun la tabla de Comprobantes, ese campo debe tener 1 si es factura de proveedor
            CompNo = Comprobantes.AddComprobante(TipoCompr, 1, "Comprobante de Factura de Compra de Crédito # " & _
                                                 LaFactura & " del Proveedor " & cbProveedor.Text & " con el No. de Pedido: " & _
                                                 tbPedido.Text & " y liquidacion No. " & tbLiqNo.Text _
                                                 , EmpresasDB.GetDetails(EmpresaActual).MonedaBase, PeriodosDB.Activo(dtBodega.DateTime.Date), _
                                                 dtBodega.DateTime.Date, 0, "", False, cbProveedor.EditValue, "", 1, LaFactura, _
                                                 VB.SysContab.Rutinas.Fecha, FacturaTipo, OrigenComprobantes.ENTRADA_ALMACEN)
            'Por que se cancelaba la factura al grabarse??? Rosa Maria 19/03/2007
            'Comprobantes.CancelarFactura(LaFactura, Me.cbProveedor.SelectedValue, 1)

            'For i = 0 To tCust.Rows.Count - 1
            '    If tCust.Rows(filas)("DC") = "Débito" Then
            '        Tipo = "D"
            '    Else
            '        Tipo = "C"
            '    End If
            If IsNull(BandedGridView1.Columns("PagoIVA").SummaryItem.SummaryValue, 0) <> 0 Then
                Comprobantes.AddComprobanteDetalles(CompNo, ds.Tables("PlantillasDetalles").Rows(0).Item("Cuenta"), "", _
                                                    BandedGridView1.Columns("PagoIVA").SummaryItem.SummaryValue, 0, TipoCompr, "D", LaFactura, _
                                                    0, dtBodega.DateTime.Date, 1)
            End If
            'Agregar las lineas de las cuentas de los productos
            'Antes era: Comprobantes.AddComprobanteDetalles(CompNo, DetallesProducto.Cuenta, "", BandedGridView1.Columns("Costo1").SummaryItem.SummaryValue, 0, TipoCompr, "C", LaFactura, 0, Today.Date, 1)
            Dim x As Integer
            For x = 0 To Cuentas.GetUpperBound(0)
                If Cuentas(x) <> "" Then
                    Comprobantes.AddComprobanteDetalles(CompNo, Cuentas(x), "", Montos(x), 0, TipoCompr, "D", LaFactura, 0, dtBodega.DateTime.Date, 1)
                End If
            Next

            Comprobantes.AddComprobanteDetalles(CompNo, cbProveedor.GetColumnValue("Cuenta"), "", _
                                BandedGridView1.Columns("TotalFOB2").SummaryItem.SummaryValue - IRxPagar - ValorIRAlcaldia, _
                                0, TipoCompr, "C", LaFactura, 0, dtBodega.DateTime.Date, 0)

            'If Ir_Prod = True Or Ir_Serv = True Then
            If DetallesProveedor.Exento = False Then

                'If (etTotal.Text - BandedGridView1.Columns("IVA").SummaryItem.SummaryValue) >= ConfigDetalles.MontoIR Then
                If CDbl((BandedGridView1.Columns("TotalFOB2").SummaryItem.SummaryValue - _
                         IIf(IvaAsumido, (SubTotalParaIVA * (ConfigDetalles.IVA / 100.0)).ToString(Round), _
                             BandedGridView1.Columns("PagoIVA").SummaryItem.SummaryValue))).ToString(Round) >= ConfigDetalles.MontoIR Then
                    'Agregar la linea del IR
                    'Comprobantes.AddComprobanteDetalles(CompNo, _
                    'ds.Tables("PlantillasDetalles").Rows(1).Item("Cuenta"), "", _
                    ' IRxPagar, _
                    '0, TipoCompr, "C", LaFactura, 0, dtBodega.DateTime.Date, 1)
                End If
            End If
            'End If

            If ValorIRAlcaldia > 0 Then
                Comprobantes.AddComprobanteDetalles(CompNo, _
                                        ds.Tables("PlantillasDetalles").Rows(2).Item("Cuenta"), "", _
                                         ValorIRAlcaldia, _
                                        0, TipoCompr, "C", LaFactura, 0, dtBodega.DateTime.Date, 1)
            End If
        End If

        If GridView3.DataRowCount >= 0 Then
            For l As Integer = 0 To GridView3.DataRowCount - 1
                Comprobantes.AddComprobanteDetalles(CompNo, cbProveedor.GetColumnValue("Cuenta"), "", _
                                GridView3.GetRowCellValue(l, "GastoMonto"), _
                                0, TipoCompr, "C", LaFactura, 0, dtBodega.DateTime.Date, 0)
            Next
        End If
        Return True
    End Function

    Private Sub AnifodaPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnifodaPrint.Click
        ReportFooter()
        PrintableComponentLink1.CreateDocument()
        PrintableComponentLink1.Landscape = True
        PrintableComponentLink1.ShowPreview()
    End Sub

    Private Sub AnifodaCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnifodaCalc.Click
        If NewLiq And Origen = 3 Then
            BandedGridView1.Columns("Anifoda").Visible = True
            With BandedGridView1
                For i As Integer = 0 To .RowCount - 1
                    If .GetRowCellValue(i, "UM") = "LTS" Then
                        .SetRowCellValue(i, "Anifoda", .GetRowCellValue(i, "TotalFOB1") * CDbl(tbTC.Text) * CDbl(tbAnifoda.Text) / 100)
                    Else
                        .SetRowCellValue(i, "Anifoda", 0.0)
                    End If
                    BandedGridView1.Columns("Anifoda").BestFit()
                Next
            End With
        End If
    End Sub

    Private Sub cmdAnifoda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnifoda.Click
        cmAnifoda.Show(cmdAnifoda, New System.Drawing.Point(38, 23))
    End Sub

    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim DT As New DataTable
        DT = ObtieneDatos("SELECT Nombre, empr_logo FROM Empresas WHERE Codigo = " & EmpresaActual)
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Tahoma", 13, FontStyle.Bold)
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50)
        Dim rec2 As RectangleF = New RectangleF(0, 30, e.Graph.ClientPageSize.Width, 60)
        Dim rec3 As RectangleF = New RectangleF(0, 0, 184, 116)
        Dim im As System.Drawing.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\" & DT.Rows(0).Item(1))

        e.Graph.DrawString(DT.Rows(0).Item(0), Color.Black, rec, BorderSide.None)
        e.Graph.DrawString("Reporte de Calculo de Anifoda" & System.Environment.NewLine & "Proveedor : " & cbProveedor.Text & ", Factura : " & tbFactura.Text & _
                           ", No Orden : " & tbPedido.Text, Color.Black, rec2, BorderSide.None)
        e.Graph.DrawImage(im, rec3, BorderSide.None, Color.Transparent)
    End Sub

    Private Sub PrintableComponentLink1_CreateDetailFooterArea(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateDetailFooterArea
        
    End Sub

    Private Sub PrintableComponentLink1_CreateReportFooterArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportFooterArea
        Dim s As String = "Autorizado por"
        Dim s2 As String = "Realizado por"
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Arial", 10)
        e.Graph.BackColor = Color.Transparent

        Dim sz As SizeF = e.Graph.MeasureString(s)
        sz.Width += 80
        Dim r As RectangleF = New RectangleF(New PointF(50, 80), sz)
        Dim t As RectangleF = New RectangleF(New PointF(700, 80), sz)
        Dim t2 As RectangleF = New RectangleF(New PointF(700, 95), sz)
        e.Graph.DrawString(s, Color.Black, r, BorderSide.Top)
        e.Graph.DrawString(s2, Color.Black, t, BorderSide.Top)
        e.Graph.DrawString(Usuario, Color.Black, t2, BorderSide.None)

    End Sub

    Private Sub ReportFooter()
        Dim leftColumn As String = "Fecha y Hora : [Date Printed] - [Time Printed]"
        Dim middleColumn As String = "Usuario: " & Usuario
        Dim rightColumn As String = "Paginas: [Page # of Pages #]"

        ' Create a PageHeaderFooter object and initializing it with
        ' the link's PageHeaderFooter.
        Dim phf As PageHeaderFooter = _
            TryCast(PrintableComponentLink1.PageHeaderFooter, PageHeaderFooter)

        ' Clear the PageHeaderFooter's contents.
        phf.Footer.Content.Clear()

        ' Add custom information to the link's header.
        phf.Footer.Content.AddRange(New String() _
            {leftColumn, middleColumn, rightColumn})
        phf.Footer.LineAlignment = BrickAlignment.Center
    End Sub
End Class