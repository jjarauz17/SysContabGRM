Imports System.IO
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI
'Imports System.Diagnostics.Process


Public Class frmBodega_Traslado
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmBodega_Traslado = Nothing

    Public Shared Function Instance() As frmBodega_Traslado
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmBodega_Traslado()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function
    Dim Bodega As New VB.SysContab.BodegasDB()
    Private WithEvents myDataSet As DataSet
    Private WithEvents tCust As DataTable
    Private myCheckBoxCol As Integer = 4 'my checkbox column
    Dim Filtro As String
    Dim TipoArticulo As String
    Dim GruposP As New VB.SysContab.Grupos_InventarioDB
    Friend WithEvents cbBodegaD As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbBodegaO As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dgTraslados As DevExpress.XtraGrid.GridControl
    Friend WithEvents vTraslados As DevExpress.XtraGrid.Views.Grid.GridView
    Dim GruposCC As New VB.SysContab.GruposCCDB
    Friend WithEvents cbGrupo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cbLinea As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtDocumento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbMovimientos As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents etCuenta As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mConcepto As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dtpFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtTransporte As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtPlaca As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtConductor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtOtSuc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOtMatriz As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRemision As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbCliente As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents NoPoliza As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents NoFactura As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbOrden As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbProyectos As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents iVistaProyectos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Dim Config As New VB.SysContab.ConfiguracionDetails



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
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbOrigenInventario As System.Windows.Forms.ComboBox
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBodega_Traslado))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cbProyectos = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.iVistaProyectos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbOrden = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NoFactura = New DevExpress.XtraEditors.TextEdit()
        Me.NoPoliza = New DevExpress.XtraEditors.TextEdit()
        Me.cbCliente = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtOtSuc = New DevExpress.XtraEditors.TextEdit()
        Me.txtOtMatriz = New DevExpress.XtraEditors.TextEdit()
        Me.txtRemision = New DevExpress.XtraEditors.TextEdit()
        Me.txtConductor = New DevExpress.XtraEditors.TextEdit()
        Me.txtPlaca = New DevExpress.XtraEditors.TextEdit()
        Me.txtTransporte = New DevExpress.XtraEditors.TextEdit()
        Me.btnExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.dtpFecha = New DevExpress.XtraEditors.DateEdit()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.cbMovimientos = New DevExpress.XtraEditors.LookUpEdit()
        Me.dgTraslados = New DevExpress.XtraGrid.GridControl()
        Me.vTraslados = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbGrupo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cbLinea = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.txtCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cbOrigenInventario = New System.Windows.Forms.ComboBox()
        Me.mConcepto = New DevExpress.XtraEditors.MemoEdit()
        Me.etCuenta = New DevExpress.XtraEditors.LabelControl()
        Me.txtDocumento = New DevExpress.XtraEditors.TextEdit()
        Me.cbBodegaO = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbBodegaD = New DevExpress.XtraEditors.LookUpEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cbProyectos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVistaProyectos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoFactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoPoliza.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOtSuc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOtMatriz.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConductor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlaca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTransporte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMovimientos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTraslados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vTraslados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbBodegaO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbBodegaD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(895, 478)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(101, 38)
        Me.cmdCancelar.StyleController = Me.LayoutControl1
        Me.cmdCancelar.TabIndex = 2
        Me.cmdCancelar.Text = "&Salir"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cbProyectos)
        Me.LayoutControl1.Controls.Add(Me.cbOrden)
        Me.LayoutControl1.Controls.Add(Me.NoFactura)
        Me.LayoutControl1.Controls.Add(Me.NoPoliza)
        Me.LayoutControl1.Controls.Add(Me.cbCliente)
        Me.LayoutControl1.Controls.Add(Me.txtOtSuc)
        Me.LayoutControl1.Controls.Add(Me.txtOtMatriz)
        Me.LayoutControl1.Controls.Add(Me.txtRemision)
        Me.LayoutControl1.Controls.Add(Me.txtConductor)
        Me.LayoutControl1.Controls.Add(Me.txtPlaca)
        Me.LayoutControl1.Controls.Add(Me.txtTransporte)
        Me.LayoutControl1.Controls.Add(Me.cmdCancelar)
        Me.LayoutControl1.Controls.Add(Me.btnExportar)
        Me.LayoutControl1.Controls.Add(Me.dtpFecha)
        Me.LayoutControl1.Controls.Add(Me.cmdAyuda)
        Me.LayoutControl1.Controls.Add(Me.cbMovimientos)
        Me.LayoutControl1.Controls.Add(Me.dgTraslados)
        Me.LayoutControl1.Controls.Add(Me.cmdAceptar)
        Me.LayoutControl1.Controls.Add(Me.cbOrigenInventario)
        Me.LayoutControl1.Controls.Add(Me.mConcepto)
        Me.LayoutControl1.Controls.Add(Me.etCuenta)
        Me.LayoutControl1.Controls.Add(Me.txtDocumento)
        Me.LayoutControl1.Controls.Add(Me.cbBodegaO)
        Me.LayoutControl1.Controls.Add(Me.cbBodegaD)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(841, 241, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1008, 528)
        Me.LayoutControl1.TabIndex = 3
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cbProyectos
        '
        Me.cbProyectos.Location = New System.Drawing.Point(126, 114)
        Me.cbProyectos.Name = "cbProyectos"
        Me.cbProyectos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProyectos.Properties.Appearance.Options.UseFont = True
        Me.cbProyectos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProyectos.Properties.View = Me.iVistaProyectos
        Me.cbProyectos.Size = New System.Drawing.Size(199, 20)
        Me.cbProyectos.StyleController = Me.LayoutControl1
        Me.cbProyectos.TabIndex = 136
        '
        'iVistaProyectos
        '
        Me.iVistaProyectos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.iVistaProyectos.Name = "iVistaProyectos"
        Me.iVistaProyectos.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.iVistaProyectos.OptionsView.ShowGroupPanel = False
        '
        'cbOrden
        '
        Me.cbOrden.Location = New System.Drawing.Point(780, 64)
        Me.cbOrden.Name = "cbOrden"
        Me.cbOrden.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOrden.Properties.Appearance.Options.UseFont = True
        Me.cbOrden.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbOrden.Properties.View = Me.GridView3
        Me.cbOrden.Size = New System.Drawing.Size(216, 20)
        Me.cbOrden.StyleController = Me.LayoutControl1
        Me.cbOrden.TabIndex = 136
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'NoFactura
        '
        Me.NoFactura.Location = New System.Drawing.Point(873, 38)
        Me.NoFactura.Name = "NoFactura"
        Me.NoFactura.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.NoFactura.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoFactura.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.NoFactura.Properties.Appearance.Options.UseBackColor = True
        Me.NoFactura.Properties.Appearance.Options.UseFont = True
        Me.NoFactura.Properties.Appearance.Options.UseForeColor = True
        Me.NoFactura.Size = New System.Drawing.Size(123, 22)
        Me.NoFactura.StyleController = Me.LayoutControl1
        Me.NoFactura.TabIndex = 4
        '
        'NoPoliza
        '
        Me.NoPoliza.Location = New System.Drawing.Point(761, 114)
        Me.NoPoliza.Name = "NoPoliza"
        Me.NoPoliza.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoPoliza.Properties.Appearance.Options.UseFont = True
        Me.NoPoliza.Size = New System.Drawing.Size(235, 20)
        Me.NoPoliza.StyleController = Me.LayoutControl1
        Me.NoPoliza.TabIndex = 131
        '
        'cbCliente
        '
        Me.cbCliente.Location = New System.Drawing.Point(443, 114)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCliente.Properties.View = Me.SearchLookUpEdit1View
        Me.cbCliente.Size = New System.Drawing.Size(200, 20)
        Me.cbCliente.StyleController = Me.LayoutControl1
        Me.cbCliente.TabIndex = 135
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'txtOtSuc
        '
        Me.txtOtSuc.Location = New System.Drawing.Point(785, 210)
        Me.txtOtSuc.Name = "txtOtSuc"
        Me.txtOtSuc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtSuc.Properties.Appearance.Options.UseFont = True
        Me.txtOtSuc.Size = New System.Drawing.Size(211, 20)
        Me.txtOtSuc.StyleController = Me.LayoutControl1
        Me.txtOtSuc.TabIndex = 132
        '
        'txtOtMatriz
        '
        Me.txtOtMatriz.Location = New System.Drawing.Point(445, 210)
        Me.txtOtMatriz.Name = "txtOtMatriz"
        Me.txtOtMatriz.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtMatriz.Properties.Appearance.Options.UseFont = True
        Me.txtOtMatriz.Size = New System.Drawing.Size(222, 20)
        Me.txtOtMatriz.StyleController = Me.LayoutControl1
        Me.txtOtMatriz.TabIndex = 131
        '
        'txtRemision
        '
        Me.txtRemision.Location = New System.Drawing.Point(126, 210)
        Me.txtRemision.Name = "txtRemision"
        Me.txtRemision.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemision.Properties.Appearance.Options.UseFont = True
        Me.txtRemision.Size = New System.Drawing.Size(201, 20)
        Me.txtRemision.StyleController = Me.LayoutControl1
        Me.txtRemision.TabIndex = 130
        '
        'txtConductor
        '
        Me.txtConductor.Location = New System.Drawing.Point(761, 186)
        Me.txtConductor.Name = "txtConductor"
        Me.txtConductor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConductor.Properties.Appearance.Options.UseFont = True
        Me.txtConductor.Size = New System.Drawing.Size(235, 20)
        Me.txtConductor.StyleController = Me.LayoutControl1
        Me.txtConductor.TabIndex = 130
        '
        'txtPlaca
        '
        Me.txtPlaca.Location = New System.Drawing.Point(761, 162)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaca.Properties.Appearance.Options.UseFont = True
        Me.txtPlaca.Size = New System.Drawing.Size(235, 20)
        Me.txtPlaca.StyleController = Me.LayoutControl1
        Me.txtPlaca.TabIndex = 130
        '
        'txtTransporte
        '
        Me.txtTransporte.Location = New System.Drawing.Point(761, 138)
        Me.txtTransporte.Name = "txtTransporte"
        Me.txtTransporte.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransporte.Properties.Appearance.Options.UseFont = True
        Me.txtTransporte.Size = New System.Drawing.Size(235, 20)
        Me.txtTransporte.StyleController = Me.LayoutControl1
        Me.txtTransporte.TabIndex = 129
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.Appearance.Options.UseFont = True
        Me.btnExportar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.Location = New System.Drawing.Point(790, 478)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(101, 38)
        Me.btnExportar.StyleController = Me.LayoutControl1
        Me.btnExportar.TabIndex = 3
        Me.btnExportar.Text = "&Exportar"
        '
        'dtpFecha
        '
        Me.dtpFecha.EditValue = Nothing
        Me.dtpFecha.Location = New System.Drawing.Point(873, 12)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Properties.Appearance.Options.UseFont = True
        Me.dtpFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFecha.Size = New System.Drawing.Size(123, 20)
        Me.dtpFecha.StyleController = Me.LayoutControl1
        Me.dtpFecha.TabIndex = 128
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAyuda.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAyuda.Appearance.Options.UseFont = True
        Me.cmdAyuda.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAyuda.Image = Global.SysContab.My.Resources.Resources.RibbonPrintPreview_ParametersLarge
        Me.cmdAyuda.Location = New System.Drawing.Point(684, 478)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(102, 38)
        Me.cmdAyuda.StyleController = Me.LayoutControl1
        Me.cmdAyuda.TabIndex = 1
        Me.cmdAyuda.Text = "Ayuda"
        Me.cmdAyuda.Visible = False
        '
        'cbMovimientos
        '
        Me.cbMovimientos.Location = New System.Drawing.Point(126, 90)
        Me.cbMovimientos.Name = "cbMovimientos"
        Me.cbMovimientos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMovimientos.Properties.Appearance.Options.UseFont = True
        Me.cbMovimientos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "Borrar Datos", Nothing, Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "Editar/Cambiar  Datos", Nothing, Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "Agregar Nuevo Movimiento", Nothing, Nothing, False)})
        Me.cbMovimientos.Properties.NullText = ""
        Me.cbMovimientos.Properties.ShowFooter = False
        Me.cbMovimientos.Size = New System.Drawing.Size(834, 20)
        Me.cbMovimientos.StyleController = Me.LayoutControl1
        Me.cbMovimientos.TabIndex = 126
        '
        'dgTraslados
        '
        Me.dgTraslados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridLevelNode1.RelationName = "Level1"
        Me.dgTraslados.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.dgTraslados.Location = New System.Drawing.Point(12, 234)
        Me.dgTraslados.MainView = Me.vTraslados
        Me.dgTraslados.Name = "dgTraslados"
        Me.dgTraslados.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbGrupo, Me.cbLinea, Me.txtCantidad})
        Me.dgTraslados.Size = New System.Drawing.Size(984, 240)
        Me.dgTraslados.TabIndex = 1
        Me.dgTraslados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vTraslados})
        '
        'vTraslados
        '
        Me.vTraslados.GridControl = Me.dgTraslados
        Me.vTraslados.Name = "vTraslados"
        Me.vTraslados.OptionsView.ShowAutoFilterRow = True
        Me.vTraslados.OptionsView.ShowFooter = True
        Me.vTraslados.OptionsView.ShowGroupPanel = False
        '
        'cbGrupo
        '
        Me.cbGrupo.AutoHeight = False
        Me.cbGrupo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbGrupo.Name = "cbGrupo"
        Me.cbGrupo.ShowFooter = False
        Me.cbGrupo.ShowHeader = False
        '
        'cbLinea
        '
        Me.cbLinea.AutoHeight = False
        Me.cbLinea.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbLinea.Name = "cbLinea"
        Me.cbLinea.ShowFooter = False
        Me.cbLinea.ShowHeader = False
        '
        'txtCantidad
        '
        Me.txtCantidad.AutoHeight = False
        Me.txtCantidad.Mask.EditMask = "n4"
        Me.txtCantidad.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCantidad.Mask.UseMaskAsDisplayFormat = True
        Me.txtCantidad.Name = "txtCantidad"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Appearance.Options.UseTextOptions = True
        Me.cmdAceptar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.Location = New System.Drawing.Point(12, 478)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(111, 38)
        Me.cmdAceptar.StyleController = Me.LayoutControl1
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Text = "&Guardar Traslado"
        '
        'cbOrigenInventario
        '
        Me.cbOrigenInventario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbOrigenInventario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOrigenInventario.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOrigenInventario.Items.AddRange(New Object() {"PRODUCTOS DE CONSUMO", "ACTIVO FIJO", "PRODUCTOS"})
        Me.cbOrigenInventario.Location = New System.Drawing.Point(241, 478)
        Me.cbOrigenInventario.Name = "cbOrigenInventario"
        Me.cbOrigenInventario.Size = New System.Drawing.Size(160, 22)
        Me.cbOrigenInventario.TabIndex = 4
        '
        'mConcepto
        '
        Me.mConcepto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mConcepto.Location = New System.Drawing.Point(126, 138)
        Me.mConcepto.Name = "mConcepto"
        Me.mConcepto.Size = New System.Drawing.Size(517, 68)
        Me.mConcepto.StyleController = Me.LayoutControl1
        Me.mConcepto.TabIndex = 13
        '
        'etCuenta
        '
        Me.etCuenta.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etCuenta.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.etCuenta.Location = New System.Drawing.Point(964, 90)
        Me.etCuenta.Name = "etCuenta"
        Me.etCuenta.Size = New System.Drawing.Size(32, 16)
        Me.etCuenta.StyleController = Me.LayoutControl1
        Me.etCuenta.TabIndex = 127
        Me.etCuenta.Text = "****"
        '
        'txtDocumento
        '
        Me.txtDocumento.Location = New System.Drawing.Point(126, 12)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtDocumento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumento.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.txtDocumento.Properties.Appearance.Options.UseBackColor = True
        Me.txtDocumento.Properties.Appearance.Options.UseFont = True
        Me.txtDocumento.Properties.Appearance.Options.UseForeColor = True
        Me.txtDocumento.Size = New System.Drawing.Size(260, 22)
        Me.txtDocumento.StyleController = Me.LayoutControl1
        Me.txtDocumento.TabIndex = 0
        '
        'cbBodegaO
        '
        Me.cbBodegaO.Location = New System.Drawing.Point(126, 38)
        Me.cbBodegaO.Name = "cbBodegaO"
        Me.cbBodegaO.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBodegaO.Properties.Appearance.Options.UseFont = True
        Me.cbBodegaO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbBodegaO.Properties.NullText = "--- Seleccione Bodega Origen ---"
        Me.cbBodegaO.Properties.ShowFooter = False
        Me.cbBodegaO.Properties.ShowHeader = False
        Me.cbBodegaO.Size = New System.Drawing.Size(629, 22)
        Me.cbBodegaO.StyleController = Me.LayoutControl1
        Me.cbBodegaO.TabIndex = 1
        '
        'cbBodegaD
        '
        Me.cbBodegaD.Location = New System.Drawing.Point(126, 64)
        Me.cbBodegaD.Name = "cbBodegaD"
        Me.cbBodegaD.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBodegaD.Properties.Appearance.Options.UseFont = True
        Me.cbBodegaD.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbBodegaD.Properties.NullText = "--- Seleccione Bodega Destino ---"
        Me.cbBodegaD.Properties.ShowFooter = False
        Me.cbBodegaD.Properties.ShowHeader = False
        Me.cbBodegaD.Size = New System.Drawing.Size(536, 22)
        Me.cbBodegaD.StyleController = Me.LayoutControl1
        Me.cbBodegaD.TabIndex = 2
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.EmptySpaceItem1, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.EmptySpaceItem2, Me.LayoutControlItem16, Me.LayoutControlItem15, Me.LayoutControlItem14, Me.LayoutControlItem17, Me.LayoutControlItem18, Me.LayoutControlItem19, Me.LayoutControlItem20, Me.LayoutControlItem21, Me.LayoutControlItem22, Me.LayoutControlItem8, Me.LayoutControlItem23, Me.LayoutControlItem24})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1008, 528)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtDocumento
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(378, 26)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(378, 26)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(378, 26)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "#Documento:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cbBodegaO
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(747, 26)
        Me.LayoutControlItem2.Text = "Bodega Origen:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbBodegaD
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(654, 26)
        Me.LayoutControlItem3.Text = "Bodega Destino:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cbMovimientos
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 78)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(952, 24)
        Me.LayoutControlItem4.Text = "Tipo de Movimiento:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.etCuenta
        Me.LayoutControlItem5.Location = New System.Drawing.Point(952, 78)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(36, 24)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.mConcepto
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(635, 72)
        Me.LayoutControlItem6.Text = "Concepto:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.dtpFecha
        Me.LayoutControlItem7.Location = New System.Drawing.Point(747, 0)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(241, 26)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(241, 26)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(241, 26)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "Fecha:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(111, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(378, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(369, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.dgTraslados
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 222)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(988, 244)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cmdAceptar
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 466)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(115, 42)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(115, 42)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(115, 42)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cmdAyuda
        Me.LayoutControlItem11.Location = New System.Drawing.Point(672, 466)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        Me.LayoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.btnExportar
        Me.LayoutControlItem12.Location = New System.Drawing.Point(778, 466)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(105, 42)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(105, 42)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(105, 42)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.cmdCancelar
        Me.LayoutControlItem13.Location = New System.Drawing.Point(883, 466)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(105, 42)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(105, 42)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(105, 42)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(393, 466)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(279, 42)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.txtConductor
        Me.LayoutControlItem16.Location = New System.Drawing.Point(635, 174)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(353, 24)
        Me.LayoutControlItem16.Text = "Conductor:"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.txtPlaca
        Me.LayoutControlItem15.Location = New System.Drawing.Point(635, 150)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(353, 24)
        Me.LayoutControlItem15.Text = "No. Placa Vehiculo:"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtTransporte
        Me.LayoutControlItem14.Location = New System.Drawing.Point(635, 126)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(353, 24)
        Me.LayoutControlItem14.Text = "Tipo Transporte:"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.txtRemision
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 198)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(319, 24)
        Me.LayoutControlItem17.Text = "#Remisión:"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.txtOtMatriz
        Me.LayoutControlItem18.Location = New System.Drawing.Point(319, 198)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(340, 24)
        Me.LayoutControlItem18.Text = "#O. Entrega C. Matriz:"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.txtOtSuc
        Me.LayoutControlItem19.Location = New System.Drawing.Point(659, 198)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(329, 24)
        Me.LayoutControlItem19.Text = "#O. Entrega Sucursal:"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.cbCliente
        Me.LayoutControlItem20.Location = New System.Drawing.Point(317, 102)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(318, 24)
        Me.LayoutControlItem20.Text = "Cliente:"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.NoPoliza
        Me.LayoutControlItem21.Location = New System.Drawing.Point(635, 102)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(353, 24)
        Me.LayoutControlItem21.Text = "No. Poliza:"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.NoFactura
        Me.LayoutControlItem22.Location = New System.Drawing.Point(747, 26)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(241, 26)
        Me.LayoutControlItem22.Text = "No. Factura:"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cbOrigenInventario
        Me.LayoutControlItem8.Location = New System.Drawing.Point(115, 466)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(278, 42)
        Me.LayoutControlItem8.Text = "Tipo"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(111, 13)
        Me.LayoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.cbOrden
        Me.LayoutControlItem23.Location = New System.Drawing.Point(654, 52)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(334, 26)
        Me.LayoutControlItem23.Text = "Orden de Trabajo:"
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.cbProyectos
        Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 102)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(317, 24)
        Me.LayoutControlItem24.Text = "Proyecto:"
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(111, 13)
        '
        'frmBodega_Traslado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1008, 528)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmBodega_Traslado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cbProyectos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVistaProyectos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoFactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoPoliza.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOtSuc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOtMatriz.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConductor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlaca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTransporte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMovimientos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTraslados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vTraslados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbLinea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbBodegaO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbBodegaD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAgregarActivo_Fijo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Filtro = ""
        Config = VB.SysContab.ConfiguracionDB.GetConfigDetails()

        dtpFecha.DateTime = VB.SysContab.Rutinas.Fecha().Date

        'GetBodegasList(Me.cbBodegaO)
        GetBodegasxUsuario(cbBodegaO, 0)

        GetBodegasList(cbBodegaD)
        'GetTipoMovimientos(Me.cbMovimientos)

        LookUp(cbMovimientos, ObtieneDatos("sp_Get_TipoMovimientos_Traslados", EmpresaActual), "Nombre", "Codigo", "[Seleccione Movimiento]", 0, 2)
        cbMovimientos.ItemIndex = 0

        'Me.txtCodigo.Text = VB.SysContab.BodegasDB.GetDocumento_CodigoNuevo("T")
        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)

        'Me.Text = "Transferencias entre Bodegas"
        Me.TipoArticulo = "P"
        Me.cbOrigenInventario.SelectedIndex = 2
        Me.cbBodegaO.EditValue = Config.Bodega

        SearchLookUp(cbProyectos, db_Proyectos.Fill(1), "Nombre", "IdProyecto", 0, 6, 7, 8)
        cbProyectos.EditValue = 0

        SearchLookUp(cbCliente, ObtieneDatos("JAR_GetClientes", EmpresaActual), "Nombre", "Codigo")
        cbCliente.EditValue = 0

        SearchLookUp(cbOrden, ObtieneDatos("sp_Get_OrdenesTrabajo", EmpresaActual), "Numero", "IdOrden", 0)

        If Me.TipoArticulo = "A" Then
            cbLinea.DataSource = GruposCC.Lineas().Tables("GruposCC")
            cbLinea.ValueMember = "Código"
            cbLinea.DisplayMember = "Nombre"
            'cbLinea.SelectedValue = 0

            'cbGrupo.DataSource = GruposCC.Grupos(Me.cbLineas.SelectedValue).Tables("GruposCC")
            'cbGrupo.ValueMember = "Código"
            'cbGrupo.DisplayMember = "Nombre"

            'cbSubGrupos.DataSource = GruposCC.SubGrupos(Me.cbGrupos.SelectedValue).Tables("GruposCC")
            'cbSubGrupos.ValueMember = "Código"
            'cbSubGrupos.DisplayMember = "Nombre"
        Else
            ''Agregar los controles de busqueda
            Me.cbLinea.DataSource = GruposP.Lineas(TipoArticulo).Tables("GruposCC")
            Me.cbLinea.ValueMember = "Código"
            Me.cbLinea.DisplayMember = "Nombre"
            'Me.cbLinea.SelectedValue = 0

            'Me.cbGrupo.DataSource = GruposP.Grupos(Me.cbLineas.SelectedValue, TipoArticulo).Tables("GruposCC")
            'Me.cbGrupo.ValueMember = "Código"
            'Me.cbGrupo.DisplayMember = "Nombre"
        End If

        Cargar()
        Refresh()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Close()
        If frmTrasladosBodegasList.Created Then frmTrasladosBodegasList.Cargar()
    End Sub

    Sub Limpiar()
        Me.txtDocumento.Text = ""

        Me.cbOrigenInventario.SelectedIndex = 2
        Me.cbBodegaO.EditValue = Nothing
        Me.cbBodegaD.EditValue = Nothing

        Cargar()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        '*******************************************************************************************
        ' Validar Cierre de Inventario
        If Not VerificarCierre_Inventario(dtpFecha.DateTime.Date) Then
            Exit Sub
        End If
        '*******************************************************************************************

        If Me.txtDocumento.Text.Trim.Length = 0 Then
            XtraMsg("Digite el Número del Documento", MessageBoxIcon.Warning)
            Me.txtDocumento.Focus()
            Exit Sub
        End If

        If Me.cbBodegaO.EditValue = Me.cbBodegaD.EditValue Then
            XtraMsg("Las bodegas deben ser diferentes para realizar un traslado", MessageBoxIcon.Warning)
            cbBodegaD.Focus()
            Exit Sub
        End If

        If Me.cbBodegaD.EditValue Is Nothing Then
            XtraMsg("Seleccione la Bodega Destino", MessageBoxIcon.Warning)
            cbBodegaD.Focus()
            Exit Sub
        End If

        Dim cSalida, cEntrada As String, Dtl1 As Integer = 0, dtl2 As Integer = 0

        If cbMovimientos.EditValue Is Nothing Then
            XtraMsg("Seleccione el Tipo de Movimiento a Realizar!")
            cbMovimientos.Focus()
            Exit Sub
        End If

        '' Validar que el Número de Documento no este procesado
        If ObtieneDatos("JAR_ValidarTraslado '" & txtDocumento.Text & "'," & EmpresaActual).Rows.Count > 0 Then
            XtraMsg("El Número de Documento ya se encuentra procesado", MessageBoxIcon.Error)
            txtDocumento.Focus()
            txtDocumento.SelectAll()
            Exit Sub
        End If

        If mConcepto.Text.Trim.Length = 0 Then
            XtraMsg("Describa el Concepto del Traslado")
            mConcepto.Focus()
            Exit Sub
        End If

        Dim Requisa As Integer = 0, Entrada As Integer = 0, Salida As Integer = 0
        Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
        Conn.IniciarTransaccion()

        Try

            ShowSplash("Guardando Traslado...")

            'Conn.RemoveParameters()
            'Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            'Conn.AddParameter("Codigo", SqlDbType.Int, 5, ParameterDirection.Output, Requisa)

            'Dim dtR As DataTable = Conn.EjecutarComando("_GetList_RequisaCodigoNuevo")
            'Dim S As String = Conn.GetParameter("Codigo").Valor()
            '' Requisa = Conn.GetParameter("Codigo").Valor()

            Requisa = VB.SysContab.RequisasDB.GetCodigoNuevo()
            Entrada = Requisa
            'Registrando Entrada
            'Encabezado
            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
            Conn.AddParameter("TRequisa", SqlDbType.NVarChar, 5, ParameterDirection.Input, "E")
            Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, dtpFecha.DateTime.Date)
            Conn.AddParameter("Bodega", SqlDbType.NVarChar, 15, ParameterDirection.Input, Me.cbBodegaD.EditValue)
            Conn.AddParameter("RealizadoPor", SqlDbType.NVarChar, 50, ParameterDirection.Input, Login)
            Conn.AddParameter("Registro", SqlDbType.Bit, 1, ParameterDirection.Input, False)
            Conn.AddParameter("Factura", SqlDbType.NVarChar, 15, ParameterDirection.Input, NoFactura.Text)
            Conn.AddParameter("Movimiento", SqlDbType.Int, 4, ParameterDirection.Input, Me.cbMovimientos.EditValue)
            Conn.AddParameter("Referencia", SqlDbType.NVarChar, 100, ParameterDirection.Input, Me.txtDocumento.Text)
            Conn.AddParameter("Concepto", SqlDbType.NVarChar, 2048, ParameterDirection.Input, mConcepto.Text)
            Conn.AddParameter("Transporte", SqlDbType.NVarChar, 512, ParameterDirection.Input, txtTransporte.Text)
            Conn.AddParameter("NoPlaca", SqlDbType.NVarChar, 100, ParameterDirection.Input, txtPlaca.Text)
            Conn.AddParameter("Conductor", SqlDbType.NVarChar, 512, ParameterDirection.Input, txtConductor.Text)
            Conn.AddParameter("Remision", SqlDbType.NVarChar, 50, ParameterDirection.Input, txtRemision.Text)
            Conn.AddParameter("OT_Matriz", SqlDbType.NVarChar, 50, ParameterDirection.Input, txtOtMatriz.Text)
            Conn.AddParameter("OT_Suc", SqlDbType.NVarChar, 50, ParameterDirection.Input, txtOtSuc.Text)
            Conn.AddParameter("IdCliente", SqlDbType.Int, 5, ParameterDirection.Input, cbCliente.EditValue)
            Conn.AddParameter("NoPoliza", SqlDbType.NVarChar, 50, ParameterDirection.Input, NoPoliza.Text)
            Conn.AddParameter("IdProyecto", SqlDbType.Int, 5, ParameterDirection.Input, cbProyectos.EditValue)
            Conn.AddParameter("IdOrden", SqlDbType.Int, 5, ParameterDirection.Input, IIf(cbOrden.EditValue Is Nothing, 0, cbOrden.EditValue))
            Conn.AddParameter("IdRequisa_Referencia", SqlDbType.Int, 5, ParameterDirection.Input, Requisa + 1)

            Conn.EjecutarComando("SP_Requisas_Add")

            For i As Integer = 0 To Me.vTraslados.DataRowCount - 1
                If Me.vTraslados.GetRowCellValue(i, "Trasladar") Then
                    'Agregar el detalle de la requisa
                    Conn.RemoveParameters()
                    Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                    Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
                    Conn.AddParameter("Articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, Me.vTraslados.GetRowCellValue(i, "Código"))
                    Conn.AddParameter("TArticulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, TipoArticulo)
                    Conn.AddParameter("Cantidad", SqlDbType.Decimal, 20, ParameterDirection.Input, Me.vTraslados.GetRowCellValue(i, "Cantidad"))
                    Conn.AddParameter("Precio", SqlDbType.Decimal, 20, ParameterDirection.Input, Me.vTraslados.GetRowCellValue(i, "Costo"))
                    Conn.AddParameter("Cuenta", SqlDbType.NVarChar, 50, ParameterDirection.Input, Me.cbMovimientos.Properties.GetDataSourceValue("Cuenta", Me.cbMovimientos.ItemIndex).ToString)
                    Conn.AddParameter("Presentacion", SqlDbType.NVarChar, 100, ParameterDirection.Input, IsNull(vTraslados.GetRowCellValue(i, "Presentacion"), ""))

                    Conn.EjecutarComando("SP_Requisas_Detalle_Add")
                    '
                    'Conn.RemoveParameters()
                    'Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                    'Conn.AddParameter("Bodega", SqlDbType.NVarChar, 15, ParameterDirection.Input, Me.cbBodegaD.EditValue)
                    'Conn.AddParameter("Articulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, Me.vTraslados.GetRowCellValue(i, "Código"))
                    'Conn.AddParameter("Existencia", SqlDbType.Decimal, 20, ParameterDirection.Input, 0)
                    'Conn.AddParameter("Costo", SqlDbType.Decimal, 20, ParameterDirection.Input, Me.vTraslados.GetRowCellValue(i, "Costo"))
                    'Conn.AddParameter("Articulo_Tipo", SqlDbType.NVarChar, 20, ParameterDirection.Input, TipoArticulo)
                    'Conn.EjecutarComando("SP_Bodega_Articulos_Add")
                End If
            Next
            '******************************************************************
            ' Requisa = VB.SysContab.RequisasDB.GetCodigoNuevo()

            'Registrando Salida
            Salida = Requisa + 1
            'Encabezado
            Conn.RemoveParameters()
            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa + 1)
            Conn.AddParameter("TRequisa", SqlDbType.NVarChar, 5, ParameterDirection.Input, "S")
            Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, dtpFecha.DateTime.Date)
            Conn.AddParameter("Bodega", SqlDbType.NVarChar, 15, ParameterDirection.Input, Me.cbBodegaO.EditValue)
            Conn.AddParameter("RealizadoPor", SqlDbType.NVarChar, 50, ParameterDirection.Input, Login)
            Conn.AddParameter("Registro", SqlDbType.Bit, 1, ParameterDirection.Input, False)
            Conn.AddParameter("Factura", SqlDbType.NVarChar, 15, ParameterDirection.Input, NoFactura.Text)
            Conn.AddParameter("Movimiento", SqlDbType.Int, 4, ParameterDirection.Input, Me.cbMovimientos.EditValue)
            Conn.AddParameter("Referencia", SqlDbType.NVarChar, 100, ParameterDirection.Input, Me.txtDocumento.Text)
            Conn.AddParameter("Concepto", SqlDbType.NVarChar, 2048, ParameterDirection.Input, mConcepto.Text)
            Conn.AddParameter("Transporte", SqlDbType.NVarChar, 512, ParameterDirection.Input, txtTransporte.Text)
            Conn.AddParameter("NoPlaca", SqlDbType.NVarChar, 100, ParameterDirection.Input, txtPlaca.Text)
            Conn.AddParameter("Conductor", SqlDbType.NVarChar, 512, ParameterDirection.Input, txtConductor.Text)
            Conn.AddParameter("Remision", SqlDbType.NVarChar, 50, ParameterDirection.Input, txtRemision.Text)
            Conn.AddParameter("OT_Matriz", SqlDbType.NVarChar, 50, ParameterDirection.Input, txtOtMatriz.Text)
            Conn.AddParameter("OT_Suc", SqlDbType.NVarChar, 50, ParameterDirection.Input, txtOtSuc.Text)
            Conn.AddParameter("IdCliente", SqlDbType.Int, 5, ParameterDirection.Input, cbCliente.EditValue)
            Conn.AddParameter("NoPoliza", SqlDbType.NVarChar, 50, ParameterDirection.Input, NoPoliza.Text)
            Conn.AddParameter("IdProyecto", SqlDbType.Int, 5, ParameterDirection.Input, cbProyectos.EditValue)
            Conn.AddParameter("IdOrden", SqlDbType.Int, 5, ParameterDirection.Input, IIf(cbOrden.EditValue Is Nothing, 0, cbOrden.EditValue))
            Conn.AddParameter("IdRequisa_Referencia", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)

            Conn.EjecutarComando("SP_Requisas_Add")

            For i As Integer = 0 To Me.vTraslados.DataRowCount - 1
                If Me.vTraslados.GetRowCellValue(i, "Trasladar") Then
                    'Agregar el detalle de la requisa
                    Conn.RemoveParameters()
                    Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                    Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa + 1)
                    Conn.AddParameter("Articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, Me.vTraslados.GetRowCellValue(i, "Código"))
                    Conn.AddParameter("TArticulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, TipoArticulo)
                    Conn.AddParameter("Cantidad", SqlDbType.Decimal, 20, ParameterDirection.Input, Me.vTraslados.GetRowCellValue(i, "Cantidad"))
                    Conn.AddParameter("Precio", SqlDbType.Decimal, 20, ParameterDirection.Input, Me.vTraslados.GetRowCellValue(i, "Costo"))
                    Conn.AddParameter("Cuenta", SqlDbType.NVarChar, 50, ParameterDirection.Input, Me.cbMovimientos.Properties.GetDataSourceValue("Cuenta", Me.cbMovimientos.ItemIndex).ToString)
                    Conn.AddParameter("Presentacion", SqlDbType.NVarChar, 100, ParameterDirection.Input, IsNull(vTraslados.GetRowCellValue(i, "Presentacion"), ""))

                    Conn.EjecutarComando("SP_Requisas_Detalle_Add")
                End If
            Next

            Conn.CompletarTransaccion()
            HideSplash()
            XtraMsg("Traslado Realizado Exitosamente !!!", MessageBoxIcon.Information)
            '
            Cargar()
            '
            txtDocumento.Text = ""
            txtTransporte.Text = ""
            txtPlaca.Text = ""
            txtConductor.Text = ""
            txtRemision.Text = ""
            txtOtMatriz.Text = ""
            txtOtSuc.Text = ""
            cbBodegaD.EditValue = Nothing
            txtDocumento.Focus()

            ImprimirTraslado(Entrada, Salida)
        Catch ex As Exception
            HideSplash()
            XtraMsg(ex.Message & "Guardar", MessageBoxIcon.Error)
            Conn.AnularTransaccion()
        End Try

        ''DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        ''DBConnFacturas.Open()
        ''transaccionFacturas = DBConnFacturas.BeginTransaction

        ''For i As Integer = 0 To Me.vTraslados.DataRowCount - 1
        ''    If Me.vTraslados.GetRowCellValue(i, "Trasladar") Then
        ''        Dtl1 += 1
        ''        If Me.vTraslados.GetRowCellValue(i, "Cantidad") > 0 Then
        ''            dtl2 += 1
        ''        End If
        ''    End If
        ''    'If Me.vTraslados.GetRowCellValue(i, "Cantidad") <= 0 And Me.vTraslados.GetRowCellValue(i, "Trasladar") Then
        ''    '    Detalle += 1
        ''    'End If
        ''Next

        ' ''For i = 0 To myDataSet.Tables("Articulos").Rows.Count - 1
        ' ''    If myDataSet.Tables("Articulos").Rows(i)("Trasladar") = True Then
        ' ''        Detalle += 1
        ' ''    End If
        ' ''    If myDataSet.Tables("Articulos").Rows(i)("Cantidad") = 0 And myDataSet.Tables("Articulos").Rows(i)("Trasladar") Then
        ' ''        Detalle -= 1
        ' ''    End If
        ' ''Next


        ''If Dtl1 = 0 Then
        ''    'MsgBox("No hay detalle válido que Trasladar. Marque los Productos a Trasladar o Ingrese Cantidades válidas", MsgBoxStyle.Exclamation, "STS-Contabilidad")
        ''    MsgBox("Seleccione al Menos 1 Prodcuto para realizar el Traslado", MsgBoxStyle.Exclamation)
        ''    VB.SysContab.Rutinas.ErrorTransaccion()
        ''    Exit Sub
        ''End If

        ''If dtl2 = 0 Then
        ''    'MsgBox("No hay detalle válido que Trasladar. Marque los Productos a Trasladar o Ingrese Cantidades válidas", MsgBoxStyle.Exclamation, "STS-Contabilidad")
        ''    MsgBox("Exiten Cantidades a Trasladar Inválidas, favor Ingresar Cantidades Válidas", MsgBoxStyle.Exclamation)
        ''    VB.SysContab.Rutinas.ErrorTransaccion()
        ''    Exit Sub
        ''End If

        ''Try

        ''    VB.SysContab.BodegasDB.TransaccionBodega_Add(Me.cbBodegaO.EditValue, _
        ''            "T", Me.dtpFecha.Value.Date, _
        ''            Me.cbBodegaD.EditValue, _
        ''             cSalida, cEntrada)

        ''    For i As Integer = 0 To Me.vTraslados.DataRowCount - 1
        ''        'For i = 0 To myDataSet.Tables("Articulos").Rows.Count - 1
        ''        If Me.vTraslados.GetRowCellValue(i, "Trasladar") Then
        ''            'If myDataSet.Tables("Articulos").Rows(i)("Trasladar") = False Then
        ''            '    GoTo Etiqueta
        ''            'End If
        ''            'If myDataSet.Tables("Articulos").Rows(i)("Cantidad") = 0 Then
        ''            '    GoTo Etiqueta
        ''            'End If

        ''            'If myDataSet.Tables("Articulos").Rows(i)("Cantidad") > myDataSet.Tables("Articulos").Rows(i)("Existencia") Then
        ''            '    myDataSet.Tables("Articulos").Rows(i)("Cantidad") = myDataSet.Tables("Articulos").Rows(i)("Existencia")
        ''            'End If

        ''            If Me.vTraslados.GetRowCellValue(i, "Cantidad") > Me.vTraslados.GetRowCellValue(i, "Existencia") Then
        ''                Me.vTraslados.SetRowCellValue(i, "Cantidad", Me.vTraslados.GetRowCellValue(i, "Existencia"))
        ''            End If

        ''            If Me.cbOrigenInventario.SelectedIndex = 0 Then
        ''                TipoArticulo = "A"
        ''            ElseIf Me.cbOrigenInventario.SelectedIndex = 2 Then
        ''                TipoArticulo = "P"
        ''            ElseIf Me.cbOrigenInventario.SelectedIndex = 1 Then
        ''                TipoArticulo = "F"
        ''            End If

        ''            'Actualizar el Saldo en la bodega Origen
        ''            VB.SysContab.BodegasDB.Bodega_Articulos_Add(Me.cbBodegaO.EditValue, _
        ''                 Me.vTraslados.GetRowCellValue(i, "Código"), _
        ''                 Me.vTraslados.GetRowCellValue(i, "Cantidad") * -1, _
        ''                 0.0, TipoArticulo)
        ''            'Agregar el Detalle En la Salida de Bodega Origen
        ''            VB.SysContab.BodegasDB.TransaccionBodegaDetalle_Add(Me.cbBodegaO.EditValue, _
        ''                Me.vTraslados.GetRowCellValue(i, "Código"), _
        ''                "T", txtDocumento.Text, "S", Me.vTraslados.GetRowCellValue(i, "Cantidad"), _
        ''                0.0, 0, TipoArticulo)
        ''            'Actualizar el Saldo en la bodega Destino
        ''            VB.SysContab.BodegasDB.Bodega_Articulos_Add(Me.cbBodegaD.EditValue, _
        ''                 Me.vTraslados.GetRowCellValue(i, "Código"), _
        ''                 Me.vTraslados.GetRowCellValue(i, "Cantidad"), _
        ''                 0.0, TipoArticulo)
        ''            'Agregar el Detalle En la Salida de Bodega Origen
        ''            VB.SysContab.BodegasDB.TransaccionBodegaDetalle_Add(Me.cbBodegaD.EditValue, _
        ''                Me.vTraslados.GetRowCellValue(i, "Código"), _
        ''                "T", Me.txtDocumento.Text, "E", Me.vTraslados.GetRowCellValue(i, "Cantidad"), _
        ''                0.0, 0, TipoArticulo)
        ''        End If
        ''    Next

        ''    VB.SysContab.Rutinas.okTransaccion()
        ''    MsgBox("Traslado Realizado Exitosamente !!!", MsgBoxStyle.Information)

        ''    'If MsgBox("La transaccion fue registrada satisfactoriamente. Desea Imprimir los Documentos de Bodega?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "STS-Contab") = MsgBoxResult.Ok Then
        ''    '    'Imprimir Salida
        ''    '    Dim lds As New DataSet
        ''    '    Dim reporte As New rptTrasladoBodega
        ''    '    Dim reporte2 As New rptTrasladoBodega
        ''    '    Dim freportes As New frmReportes
        ''    '    Dim freportes2 As New frmReportes

        ''    '    lds = VB.SysContab.BodegasDB.GetList_TransaccionBodega(Me.cbBodegaO.EditValue, "T", Me.txtDocumento.Text, 0)
        ''    '    lds.WriteXml(Application.StartupPath & "\xml\EncTBod.xml", XmlWriteMode.WriteSchema)
        ''    '    lds.Clear()
        ''    '    lds = VB.SysContab.BodegasDB.GetList_TransaccionBodegaDetalle(Me.cbBodegaO.EditValue, "T", Me.txtDocumento.Text, 0)
        ''    '    lds.WriteXml(Application.StartupPath & "\xml\DetTBod.xml", XmlWriteMode.WriteSchema)


        ''    '    reporte.Database.Tables("Encabezado").Location = Application.StartupPath & "\xml\EncTBod.xml"
        ''    '    reporte.Database.Tables("Detalle").Location = Application.StartupPath & "\xml\DetTBod.xml"
        ''    '    reporte.Database.Tables("_GetlogoEmpresa").Location = Application.StartupPath & "\xml\logoEmpresa.xml"
        ''    '    freportes.crvReportes.ReportSource = reporte
        ''    '    freportes.ShowDialog()

        ''    '    'Imprimir Entrada
        ''    '    lds.Clear()
        ''    '    lds = VB.SysContab.BodegasDB.GetList_TransaccionBodega(Me.cbBodegaD.EditValue, "T", Me.txtDocumento.Text, 0)
        ''    '    lds.WriteXml(Application.StartupPath & "\xml\EncTBod.xml", XmlWriteMode.WriteSchema)
        ''    '    lds.Clear()
        ''    '    lds = VB.SysContab.BodegasDB.GetList_TransaccionBodegaDetalle(Me.cbBodegaD.EditValue, "T", Me.txtDocumento.Text, 0)
        ''    '    lds.WriteXml(Application.StartupPath & "\xml\DetTBod.xml", XmlWriteMode.WriteSchema)

        ''    '    reporte2.Database.Tables("Encabezado").Location = Application.StartupPath & "\xml\EncTBod.xml"
        ''    '    reporte2.Database.Tables("Detalle").Location = Application.StartupPath & "\xml\DetTBod.xml"
        ''    '    reporte2.Database.Tables("_GetlogoEmpresa").Location = Application.StartupPath & "\xml\logoEmpresa.xml"
        ''    '    freportes2.crvReportes.ReportSource = reporte2
        ''    '    freportes2.ShowDialog()
        ''    'End If
        ''    'Me.Close()
        ''Catch ex As Exception
        ''    MsgBox(ex.Message & "Error al Guardar la Transacción de Traslado de Bodega", MsgBoxStyle.Critical)
        ''    VB.SysContab.Rutinas.ErrorTransaccion()
        ''    'Me.Close()
        ''End Try
    End Sub

    Sub ImprimirTraslado(Entrada As Integer, Salida As Integer)
        '
        Dim Cadena As String
        Dim Temp As Boolean = False
        Dim Data() As Byte

        ShowSplash("Imprimiendo...")

        Try
            'Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 25 and Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())
            Data = CType(ObtieneDatos("sp_sel_Bodegas", cbBodegaO.EditValue, EmpresaActual).Rows(0).Item(0), Byte())
            Temp = True
            '
            Dim Tamano As Integer
            Tamano = Data.GetUpperBound(0)
            Cadena = Application.StartupPath & "\rptTraslado.repx"
            If File.Exists(Cadena) Then Kill(Cadena)
            Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
            Archivo.Write(Data, 0, Tamano)
            Archivo.Close()
        Catch ex As Exception
            Temp = False
        End Try

        Dim rpt As rptTrasladoBodegas

        If Temp = True Then
            rpt = XtraReport.FromFile(Application.StartupPath & "\rptTraslado.repx", True)
        Else
            rpt = New rptTrasladoBodegas
        End If

        rpt.DataSource = ObtieneDatos("JAR_ImprimirTraslado", Entrada, Salida, EmpresaActual)
        rpt.ShowPrintMarginsWarning = False
        HideSplash()

        rpt.ShowPrintMarginsWarning = False
        rpt.BringToFront()
        rpt.ShowRibbonPreview()
    End Sub

    Private Sub Cargar()
        Me.dgTraslados.DataSource = ObtieneDatos("sp_GetList_ArticulosBodega '" & IIf(Me.cbBodegaO.EditValue Is Nothing, "", Me.cbBodegaO.EditValue) & "','" & TipoArticulo & "'," & EmpresaActual)
        Me.vTraslados.PopulateColumns()
        FormatoGrid(Me.vTraslados, 4, 0, False)

        For i As Integer = 0 To Me.vTraslados.Columns.Count - 1
            Me.vTraslados.Columns(i).OptionsColumn.AllowEdit = False
            Me.vTraslados.Columns(i).OptionsColumn.AllowFocus = False
        Next

        Me.vTraslados.Columns("Existencia").Visible = False
        Me.vTraslados.Columns("LINEA").ColumnEdit = Me.cbLinea
        Me.vTraslados.Columns("Cantidad").ColumnEdit = Me.txtCantidad

        Me.vTraslados.Columns("Cantidad").OptionsColumn.AllowEdit = True
        Me.vTraslados.Columns("Cantidad").OptionsColumn.AllowFocus = True

        Me.vTraslados.Columns("Trasladar").OptionsColumn.AllowEdit = True
        Me.vTraslados.Columns("Trasladar").OptionsColumn.AllowFocus = True

        Me.vTraslados.Columns("Presentacion").OptionsColumn.AllowEdit = True
        Me.vTraslados.Columns("Presentacion").OptionsColumn.AllowFocus = True

        Me.vTraslados.Columns("Costo").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vTraslados.Columns("Costo").DisplayFormat.FormatString = "{0:" & RoundP & "}"
        Me.vTraslados.Columns("Costo").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vTraslados.Columns("Costo").SummaryItem.DisplayFormat = "{0:" & RoundP & "}"

        Me.vTraslados.Columns("Existencia").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vTraslados.Columns("Existencia").DisplayFormat.FormatString = "{0:n4}"
        Me.vTraslados.Columns("Existencia").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vTraslados.Columns("Existencia").SummaryItem.DisplayFormat = "{0:n4}"

        'MakeDataSet()
        'Me.dgArticulos.SetDataBinding(myDataSet, "Articulos")
        'AddCustomDataTableStyle()
        'dgArticulos.ReadOnly = False
    End Sub

    Private Sub cbOrigenInventario_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbOrigenInventario.SelectedIndexChanged
        If Not Me.cbBodegaO.EditValue Is Nothing Then
            ' If IsNumeric(Me.cbBodegaO.EditVaue) Then

            If Me.cbOrigenInventario.SelectedIndex = 0 Then         'PRODUCTOS DE CONSUMO
                TipoArticulo = "A"
            ElseIf Me.cbOrigenInventario.SelectedIndex = 2 Then     'PRODUCTOS
                TipoArticulo = "P"
            ElseIf Me.cbOrigenInventario.SelectedIndex = 1 Then     'ACTIVO FIJO
                TipoArticulo = "F"
            End If

            Me.Cargar()

            If Me.TipoArticulo = "A" Then

                cbLinea.DataSource = GruposCC.Lineas().Tables("GruposCC")
                cbLinea.ValueMember = "Código"
                cbLinea.DisplayMember = "Nombre"
                'cbLineas.SelectedValue = 0

                'cbGrupos.DataSource = GruposCC.Grupos(Me.cbLineas.SelectedValue).Tables("GruposCC")
                'cbGrupos.ValueMember = "Código"
                'cbGrupos.DisplayMember = "Nombre"

                'cbSubGrupos.DataSource = GruposCC.SubGrupos(Me.cbGrupos.SelectedValue).Tables("GruposCC")
                'cbSubGrupos.ValueMember = "Código"
                'cbSubGrupos.DisplayMember = "Nombre"

            Else
                ''Agregar los controles de busqueda
                Me.cbLinea.DataSource = GruposP.Lineas(TipoArticulo).Tables("GruposCC")
                Me.cbLinea.ValueMember = "Código"
                Me.cbLinea.DisplayMember = "Nombre"
                'Me.cbLinea.SelectedValue = 0

                'Me.cbGrupos.DataSource = GruposP.Grupos(Me.cbLineas.SelectedValue, TipoArticulo).Tables("GruposCC")
                'Me.cbGrupos.ValueMember = "Código"
                'Me.cbGrupos.DisplayMember = "Nombre"

                'cbSubGrupos.DataSource = GruposP.SubGrupos(Me.cbGrupos.SelectedValue, TipoArticulo).Tables("GruposCC")
                'cbSubGrupos.ValueMember = "Código"
                'cbSubGrupos.DisplayMember = "Nombre"

            End If

        End If
    End Sub

    'Private Sub cbLineas_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If IsNumeric(Me.cbLineas.SelectedValue) Then
    '        If Me.TipoArticulo = "A" Then
    '            cbGrupos.DataSource = GruposCC.Grupos(Me.cbLineas.SelectedValue).Tables("GruposCC")
    '            cbGrupos.ValueMember = "Código"
    '            cbGrupos.DisplayMember = "Nombre"

    '            cbSubGrupos.DataSource = GruposCC.SubGrupos(Me.cbGrupos.SelectedValue).Tables("GruposCC")
    '            cbSubGrupos.ValueMember = "Código"
    '            cbSubGrupos.DisplayMember = "Nombre"
    '        ElseIf Me.TipoArticulo = "P" Then

    '            Me.cbGrupos.DataSource = GruposP.Grupos(Me.cbLineas.SelectedValue, TipoArticulo).Tables("GruposCC")
    '            Me.cbGrupos.ValueMember = "Código"
    '            Me.cbGrupos.DisplayMember = "Nombre"

    '            cbSubGrupos.DataSource = GruposP.SubGrupos(Me.cbGrupos.SelectedValue, TipoArticulo).Tables("GruposCC")
    '            cbSubGrupos.ValueMember = "Código"
    '            cbSubGrupos.DisplayMember = "Nombre"
    '        End If
    '        aplicarfiltro()
    '    End If
    'End Sub

    'Private Sub cbGrupos_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If IsNumeric(Me.cbGrupos.SelectedValue) Then
    '        If Me.TipoArticulo = "A" Then
    '            cbSubGrupos.DataSource = GruposCC.SubGrupos(Me.cbGrupos.SelectedValue).Tables("GruposCC")
    '            cbSubGrupos.ValueMember = "Código"
    '            cbSubGrupos.DisplayMember = "Nombre"
    '        ElseIf Me.TipoArticulo = "P" Then
    '            cbSubGrupos.DataSource = GruposP.SubGrupos(Me.cbGrupos.SelectedValue, TipoArticulo).Tables("GruposCC")
    '            cbSubGrupos.ValueMember = "Código"
    '            cbSubGrupos.DisplayMember = "Nombre"
    '        Else

    '        End If
    '        aplicarfiltro()
    '    End If
    'End Sub

    'Private Sub aplicarfiltro()
    '    'If Len(Me.txtArticulo.Text) > 0 Then
    '    '    Filtro = " Nombre like '%" & Me.txtArticulo.Text & "%'"
    '    'End If
    '    Filtro = ""
    '    If IsNumeric(Me.cbLineas.SelectedValue) Then
    '        If Me.cbLineas.SelectedIndex > 0 Then
    '            Filtro = Filtro & IIf(Len(Filtro.Trim) > 0, " And ", "") & "Linea = '" & Me.cbLineas.SelectedValue & "'"
    '        Else
    '            'If Len(Me.txtArticulo.Text) > 0 Then
    '            '    Filtro = " Nombre like '%" & Me.txtArticulo.Text & "%'"
    '            'Else
    '            Filtro = ""
    '            'End If
    '        End If
    '    End If
    '    If IsNumeric(Me.cbGrupos.SelectedValue) Then
    '        If Me.cbGrupos.SelectedValue > 0 Then
    '            Filtro = Filtro & IIf(Len(Filtro.Trim) > 0, " And ", "") & "Grupo = '" & Me.cbGrupos.SelectedValue & "'"
    '        Else
    '            If IsNumeric(Me.cbLineas.SelectedValue) Then
    '                If Me.cbLineas.SelectedIndex > 0 Then
    '                    Filtro = "Linea = '" & Me.cbLineas.SelectedValue & "'"
    '                Else
    '                    Filtro = ""
    '                End If
    '            End If
    '        End If
    '    End If

    '    If IsNumeric(Me.cbSubGrupos.SelectedValue) Then
    '        If Me.cbSubGrupos.SelectedValue > 0 Then
    '            Filtro = Filtro & IIf(Len(Filtro.Trim) > 0, " And ", "") & "SubGrupo = '" & Me.cbSubGrupos.SelectedValue & "'"
    '        Else
    '            If IsNumeric(Me.cbLineas.SelectedValue) Then
    '                If Me.cbLineas.SelectedIndex > 0 Then
    '                    Filtro = "Linea = '" & Me.cbLineas.SelectedValue & "'"
    '                Else
    '                    Filtro = ""
    '                End If
    '            End If
    '            If IsNumeric(Me.cbGrupos.SelectedValue) Then
    '                If Me.cbGrupos.SelectedValue > 0 Then
    '                    Filtro = Filtro & IIf(Len(Filtro.Trim) > 0, " And ", "") & "Grupo = '" & Me.cbGrupos.SelectedValue & "'"
    '                End If
    '            End If
    '        End If
    '    End If

    '    'El filtro no lo pude realizar dentro del dataset
    '    'por eso voy a crear el filtro sacando los datos 
    '    Cargar()
    '    'DVFiltrada = New DataView(tCust)
    '    'DVFiltrada.RowStateFilter = DataViewRowState.CurrentRows
    '    'DVFiltrada.RowFilter = Filtro
    '    'Me.dgArticulos.DataSource = DVFiltrada
    '    'AddCustomDataTableStyle()
    'End Sub

    'Private Sub cbSubGrupos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If IsNumeric(Me.cbSubGrupos.SelectedValue) Then
    '        aplicarfiltro()
    '    End If
    'End Sub

    'Private Sub txtArticulo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    aplicarfiltro()
    'End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Try
            Process.Start(Application.StartupPath & "\Ayuda\TrasladoBodega.chm")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        'Start(Application.StartupPath & "\Ayuda\TrasladoBodega.chm")
        'Help.ShowHelp(Me, Application.StartupPath & "ayuda/TrasladoBodega.chm")
    End Sub

    Private Sub cbBodegaO_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBodegaO.EditValueChanged
        'If IsNumeric(Me.cbBodegaO.EditValue) Then
        If Not Me.cbBodegaO.EditValue Is Nothing Then

            If Me.cbOrigenInventario.SelectedIndex = 0 Then         'PRODUCTOS DE CONSUMO
                TipoArticulo = "A"
            ElseIf Me.cbOrigenInventario.SelectedIndex = 2 Then     'PRODUCTOS
                TipoArticulo = "P"
            ElseIf Me.cbOrigenInventario.SelectedIndex = 1 Then     'ACTIVO FIJO
                TipoArticulo = "F"
            End If

            Cargar()
        End If
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        My.Forms.frmExportarImprimir.Mostrar(Me.dgTraslados)
    End Sub

    Private Sub cbMovimientos_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMovimientos.EditValueChanged
        If Me.cbMovimientos.ItemIndex = 0 Then
            Me.etCuenta.Text = ""
        Else
            Me.etCuenta.Text = "Cuenta: " + Me.cbMovimientos.Properties.GetDataSourceValue("Cuenta", Me.cbMovimientos.ItemIndex).ToString
        End If
    End Sub

    Private Sub cbProyectos_EditValueChanged(sender As Object, e As EventArgs) Handles cbProyectos.EditValueChanged
        If cbProyectos.EditValue <> 0 Then
            cbCliente.EditValue = cbProyectos.Properties.View.GetRowCellValue(cbProyectos.Properties.View.FocusedRowHandle, "IdCliente")
            cbBodegaD.EditValue = cbProyectos.Properties.View.GetRowCellValue(cbProyectos.Properties.View.FocusedRowHandle, "Bodega")
            cbCliente.ReadOnly = True
            '
            txtDocumento.Text = cbProyectos.Text
        Else
            cbCliente.EditValue = 0
            cbCliente.ReadOnly = False
            '
            txtDocumento.Text = ""
        End If
    End Sub
End Class
