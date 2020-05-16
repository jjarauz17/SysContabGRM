'Imports System.DirectoryServices
'imports System.Management
Imports DevExpress.XtraEditors
Imports System

Public Class frmAgregarCaja
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAgregarCaja = Nothing

    Public Shared Function Instance() As frmAgregarCaja
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarCaja()
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
    Friend WithEvents txtNombrePC As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lbComputadoras As System.Windows.Forms.ListBox
    Friend WithEvents Serie As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Factura As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AgregarF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbCliente As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtNombreGrte As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtSerieR As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnAgregarR As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtRecibo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbCatalogo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents vCatalogo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbCentroCosto As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents frmAgregarCajaConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents HoraCorteFacturacion As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents HoraCorteFijo As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents lHoraCierreFijo As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lHoraFacturacion As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rLink As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents mDescripcion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmbbodega As DevExpress.XtraEditors.LookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarCaja))
        Me.cbCentroCosto = New DevExpress.XtraEditors.LookUpEdit()
        Me.frmAgregarCajaConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.mDescripcion = New DevExpress.XtraEditors.MemoEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rLink = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.btnAgregarR = New DevExpress.XtraEditors.SimpleButton()
        Me.AgregarF = New DevExpress.XtraEditors.SimpleButton()
        Me.txtSerieR = New DevExpress.XtraEditors.TextEdit()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Serie = New DevExpress.XtraEditors.TextEdit()
        Me.txtRecibo = New DevExpress.XtraEditors.TextEdit()
        Me.Factura = New DevExpress.XtraEditors.TextEdit()
        Me.HoraCorteFacturacion = New DevExpress.XtraEditors.TimeEdit()
        Me.HoraCorteFijo = New DevExpress.XtraEditors.TimeEdit()
        Me.txtNombrePC = New System.Windows.Forms.TextBox()
        Me.cbCatalogo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.vCatalogo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtNombreGrte = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.cbCliente = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbbodega = New DevExpress.XtraEditors.LookUpEdit()
        Me.lbComputadoras = New System.Windows.Forms.ListBox()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lHoraCierreFijo = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lHoraFacturacion = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.cbCentroCosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmAgregarCajaConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmAgregarCajaConvertedLayout.SuspendLayout()
        CType(Me.mDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerieR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Serie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRecibo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Factura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HoraCorteFacturacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HoraCorteFijo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreGrte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbbodega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lHoraCierreFijo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lHoraFacturacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbCentroCosto
        '
        Me.cbCentroCosto.Location = New System.Drawing.Point(604, 132)
        Me.cbCentroCosto.Name = "cbCentroCosto"
        Me.cbCentroCosto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCentroCosto.Properties.NullText = "[Seleccione Centro de Costo]"
        Me.cbCentroCosto.Properties.ShowFooter = False
        Me.cbCentroCosto.Properties.ShowHeader = False
        Me.cbCentroCosto.Size = New System.Drawing.Size(309, 20)
        Me.cbCentroCosto.StyleController = Me.frmAgregarCajaConvertedLayout
        Me.cbCentroCosto.TabIndex = 12
        Me.cbCentroCosto.Tag = "True"
        '
        'frmAgregarCajaConvertedLayout
        '
        Me.frmAgregarCajaConvertedLayout.Controls.Add(Me.mDescripcion)
        Me.frmAgregarCajaConvertedLayout.Controls.Add(Me.GridControl1)
        Me.frmAgregarCajaConvertedLayout.Controls.Add(Me.btnAgregarR)
        Me.frmAgregarCajaConvertedLayout.Controls.Add(Me.AgregarF)
        Me.frmAgregarCajaConvertedLayout.Controls.Add(Me.txtSerieR)
        Me.frmAgregarCajaConvertedLayout.Controls.Add(Me.GridControl2)
        Me.frmAgregarCajaConvertedLayout.Controls.Add(Me.Serie)
        Me.frmAgregarCajaConvertedLayout.Controls.Add(Me.txtRecibo)
        Me.frmAgregarCajaConvertedLayout.Controls.Add(Me.Factura)
        Me.frmAgregarCajaConvertedLayout.Controls.Add(Me.HoraCorteFacturacion)
        Me.frmAgregarCajaConvertedLayout.Controls.Add(Me.HoraCorteFijo)
        Me.frmAgregarCajaConvertedLayout.Controls.Add(Me.txtNombrePC)
        Me.frmAgregarCajaConvertedLayout.Controls.Add(Me.cbCatalogo)
        Me.frmAgregarCajaConvertedLayout.Controls.Add(Me.txtNombre)
        Me.frmAgregarCajaConvertedLayout.Controls.Add(Me.txtNombreGrte)
        Me.frmAgregarCajaConvertedLayout.Controls.Add(Me.txtCodigo)
        Me.frmAgregarCajaConvertedLayout.Controls.Add(Me.cbCliente)
        Me.frmAgregarCajaConvertedLayout.Controls.Add(Me.cmbbodega)
        Me.frmAgregarCajaConvertedLayout.Controls.Add(Me.lbComputadoras)
        Me.frmAgregarCajaConvertedLayout.Controls.Add(Me.cbCentroCosto)
        Me.frmAgregarCajaConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmAgregarCajaConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.frmAgregarCajaConvertedLayout.Name = "frmAgregarCajaConvertedLayout"
        Me.frmAgregarCajaConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1117, 269, 250, 350)
        Me.frmAgregarCajaConvertedLayout.Root = Me.LayoutControlGroup1
        Me.frmAgregarCajaConvertedLayout.Size = New System.Drawing.Size(925, 710)
        Me.frmAgregarCajaConvertedLayout.TabIndex = 13
        '
        'mDescripcion
        '
        Me.mDescripcion.Location = New System.Drawing.Point(24, 255)
        Me.mDescripcion.Name = "mDescripcion"
        Me.mDescripcion.Size = New System.Drawing.Size(448, 73)
        Me.mDescripcion.StyleController = Me.frmAgregarCajaConvertedLayout
        Me.mDescripcion.TabIndex = 15
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(24, 332)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rLink})
        Me.GridControl1.Size = New System.Drawing.Size(448, 216)
        Me.GridControl1.TabIndex = 8
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn7})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowColumnResizing = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "IdDetalle"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Serie"
        Me.GridColumn2.FieldName = "Serie"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 222
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Factura"
        Me.GridColumn3.FieldName = "Factura"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 140
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "Descripción"
        Me.GridColumn7.FieldName = "Descripcion"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 2
        Me.GridColumn7.Width = 68
        '
        'rLink
        '
        Me.rLink.AutoHeight = False
        Me.rLink.Caption = "Descripción"
        Me.rLink.Name = "rLink"
        '
        'btnAgregarR
        '
        Me.btnAgregarR.Image = CType(resources.GetObject("btnAgregarR.Image"), System.Drawing.Image)
        Me.btnAgregarR.Location = New System.Drawing.Point(808, 213)
        Me.btnAgregarR.Name = "btnAgregarR"
        Me.btnAgregarR.Size = New System.Drawing.Size(80, 22)
        Me.btnAgregarR.StyleController = Me.frmAgregarCajaConvertedLayout
        Me.btnAgregarR.TabIndex = 2
        Me.btnAgregarR.Text = "Agregar"
        '
        'AgregarF
        '
        Me.AgregarF.Image = CType(resources.GetObject("AgregarF.Image"), System.Drawing.Image)
        Me.AgregarF.Location = New System.Drawing.Point(379, 213)
        Me.AgregarF.Name = "AgregarF"
        Me.AgregarF.Size = New System.Drawing.Size(82, 22)
        Me.AgregarF.StyleController = Me.frmAgregarCajaConvertedLayout
        Me.AgregarF.TabIndex = 2
        Me.AgregarF.Text = "Agregar"
        '
        'txtSerieR
        '
        Me.txtSerieR.Location = New System.Drawing.Point(602, 189)
        Me.txtSerieR.Name = "txtSerieR"
        Me.txtSerieR.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieR.Properties.MaxLength = 2
        Me.txtSerieR.Size = New System.Drawing.Size(202, 20)
        Me.txtSerieR.StyleController = Me.frmAgregarCajaConvertedLayout
        Me.txtSerieR.TabIndex = 0
        '
        'GridControl2
        '
        Me.GridControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GridControl2.Location = New System.Drawing.Point(481, 239)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(420, 309)
        Me.GridControl2.TabIndex = 9
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowColumnMoving = False
        Me.GridView2.OptionsCustomization.AllowColumnResizing = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsCustomization.AllowSort = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "ID"
        Me.GridColumn4.FieldName = "IdDetalle"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn5.AppearanceHeader.Options.UseFont = True
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Serie"
        Me.GridColumn5.FieldName = "Serie"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn6.AppearanceHeader.Options.UseFont = True
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "Recibo"
        Me.GridColumn6.FieldName = "Recibo"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        '
        'Serie
        '
        Me.Serie.Location = New System.Drawing.Point(145, 189)
        Me.Serie.Name = "Serie"
        Me.Serie.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Serie.Properties.MaxLength = 50
        Me.Serie.Size = New System.Drawing.Size(230, 20)
        Me.Serie.StyleController = Me.frmAgregarCajaConvertedLayout
        Me.Serie.TabIndex = 0
        '
        'txtRecibo
        '
        Me.txtRecibo.Location = New System.Drawing.Point(602, 213)
        Me.txtRecibo.Name = "txtRecibo"
        Me.txtRecibo.Properties.Mask.EditMask = "d"
        Me.txtRecibo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtRecibo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtRecibo.Size = New System.Drawing.Size(202, 20)
        Me.txtRecibo.StyleController = Me.frmAgregarCajaConvertedLayout
        Me.txtRecibo.TabIndex = 1
        '
        'Factura
        '
        Me.Factura.Location = New System.Drawing.Point(145, 213)
        Me.Factura.Name = "Factura"
        Me.Factura.Properties.Mask.EditMask = "d"
        Me.Factura.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.Factura.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Factura.Size = New System.Drawing.Size(230, 20)
        Me.Factura.StyleController = Me.frmAgregarCajaConvertedLayout
        Me.Factura.TabIndex = 1
        '
        'HoraCorteFacturacion
        '
        Me.HoraCorteFacturacion.EditValue = New Date(2012, 10, 17, 0, 0, 0, 0)
        Me.HoraCorteFacturacion.Location = New System.Drawing.Point(812, 12)
        Me.HoraCorteFacturacion.Name = "HoraCorteFacturacion"
        Me.HoraCorteFacturacion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HoraCorteFacturacion.Properties.Appearance.Options.UseFont = True
        Me.HoraCorteFacturacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.HoraCorteFacturacion.Properties.Mask.EditMask = "t"
        Me.HoraCorteFacturacion.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.HoraCorteFacturacion.Size = New System.Drawing.Size(101, 20)
        Me.HoraCorteFacturacion.StyleController = Me.frmAgregarCajaConvertedLayout
        Me.HoraCorteFacturacion.TabIndex = 14
        '
        'HoraCorteFijo
        '
        Me.HoraCorteFijo.EditValue = New Date(2012, 10, 17, 0, 0, 0, 0)
        Me.HoraCorteFijo.Location = New System.Drawing.Point(578, 12)
        Me.HoraCorteFijo.Name = "HoraCorteFijo"
        Me.HoraCorteFijo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HoraCorteFijo.Properties.Appearance.Options.UseFont = True
        Me.HoraCorteFijo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.HoraCorteFijo.Properties.Mask.EditMask = "t"
        Me.HoraCorteFijo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.HoraCorteFijo.Size = New System.Drawing.Size(109, 20)
        Me.HoraCorteFijo.StyleController = Me.frmAgregarCajaConvertedLayout
        Me.HoraCorteFijo.TabIndex = 13
        '
        'txtNombrePC
        '
        Me.txtNombrePC.BackColor = System.Drawing.SystemColors.Info
        Me.txtNombrePC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombrePC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombrePC.Location = New System.Drawing.Point(133, 36)
        Me.txtNombrePC.Name = "txtNombrePC"
        Me.txtNombrePC.ReadOnly = True
        Me.txtNombrePC.Size = New System.Drawing.Size(780, 20)
        Me.txtNombrePC.TabIndex = 5
        '
        'cbCatalogo
        '
        Me.cbCatalogo.Location = New System.Drawing.Point(133, 108)
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo.Properties.NullText = "[Seleccione Cuenta Contable]"
        Me.cbCatalogo.Properties.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.cbCatalogo.Properties.View = Me.vCatalogo
        Me.cbCatalogo.Size = New System.Drawing.Size(346, 20)
        Me.cbCatalogo.StyleController = Me.frmAgregarCajaConvertedLayout
        Me.cbCatalogo.TabIndex = 11
        Me.cbCatalogo.Tag = "True"
        '
        'vCatalogo
        '
        Me.vCatalogo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.vCatalogo.Name = "vCatalogo"
        Me.vCatalogo.OptionsBehavior.Editable = False
        Me.vCatalogo.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.vCatalogo.OptionsView.ShowAutoFilterRow = True
        Me.vCatalogo.OptionsView.ShowFooter = True
        Me.vCatalogo.OptionsView.ShowGroupPanel = False
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(133, 60)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(780, 20)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.Tag = "True"
        '
        'txtNombreGrte
        '
        Me.txtNombreGrte.Location = New System.Drawing.Point(133, 132)
        Me.txtNombreGrte.Name = "txtNombreGrte"
        Me.txtNombreGrte.Size = New System.Drawing.Size(346, 20)
        Me.txtNombreGrte.StyleController = Me.frmAgregarCajaConvertedLayout
        Me.txtNombreGrte.TabIndex = 3
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.SystemColors.Info
        Me.txtCodigo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.Maroon
        Me.txtCodigo.Location = New System.Drawing.Point(133, 12)
        Me.txtCodigo.MaxLength = 4
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCodigo.Size = New System.Drawing.Size(161, 20)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.Tag = "True"
        '
        'cbCliente
        '
        Me.cbCliente.EnterMoveNextControl = True
        Me.cbCliente.Location = New System.Drawing.Point(604, 108)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCliente.Properties.NullText = "[Cliente de Contado]"
        Me.cbCliente.Properties.PopupFormMinSize = New System.Drawing.Size(600, 0)
        Me.cbCliente.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cbCliente.Properties.ShowFooter = False
        Me.cbCliente.Size = New System.Drawing.Size(309, 20)
        Me.cbCliente.StyleController = Me.frmAgregarCajaConvertedLayout
        Me.cbCliente.TabIndex = 4
        Me.cbCliente.Tag = "True"
        '
        'cmbbodega
        '
        Me.cmbbodega.Location = New System.Drawing.Point(133, 84)
        Me.cmbbodega.Name = "cmbbodega"
        Me.cmbbodega.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbbodega.Properties.NullText = ""
        Me.cmbbodega.Size = New System.Drawing.Size(780, 20)
        Me.cmbbodega.StyleController = Me.frmAgregarCajaConvertedLayout
        Me.cmbbodega.TabIndex = 2
        Me.cmbbodega.Tag = "True"
        '
        'lbComputadoras
        '
        Me.lbComputadoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbComputadoras.ItemHeight = 15
        Me.lbComputadoras.Location = New System.Drawing.Point(12, 564)
        Me.lbComputadoras.Name = "lbComputadoras"
        Me.lbComputadoras.Size = New System.Drawing.Size(901, 124)
        Me.lbComputadoras.TabIndex = 6
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.EmptySpaceItem1, Me.lHoraCierreFijo, Me.lHoraFacturacion, Me.LayoutControlItem7, Me.LayoutControlItem5, Me.LayoutControlItem3, Me.LayoutControlItem10, Me.LayoutControlGroup2, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(925, 710)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtNombre
        Me.LayoutControlItem4.CustomizationFormText = "Nombre:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem4.Name = "txtNombreitem"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(905, 24)
        Me.LayoutControlItem4.Text = "Nombre:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(118, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtCodigo
        Me.LayoutControlItem6.CustomizationFormText = "Código:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(286, 24)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(286, 24)
        Me.LayoutControlItem6.Name = "txtCodigoitem"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(286, 24)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Código:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(118, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmbbodega
        Me.LayoutControlItem8.CustomizationFormText = "Bodega :"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem8.Name = "cmbbodegaitem"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(905, 24)
        Me.LayoutControlItem8.Text = "Bodega :"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(118, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.lbComputadoras
        Me.LayoutControlItem9.CustomizationFormText = "lbComputadorasitem"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 552)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(0, 138)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(24, 138)
        Me.LayoutControlItem9.Name = "lbComputadorasitem"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(905, 138)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(286, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(159, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'lHoraCierreFijo
        '
        Me.lHoraCierreFijo.Control = Me.HoraCorteFijo
        Me.lHoraCierreFijo.CustomizationFormText = "LayoutControlItem12"
        Me.lHoraCierreFijo.Location = New System.Drawing.Point(445, 0)
        Me.lHoraCierreFijo.MaxSize = New System.Drawing.Size(234, 24)
        Me.lHoraCierreFijo.MinSize = New System.Drawing.Size(234, 24)
        Me.lHoraCierreFijo.Name = "lHoraCierreFijo"
        Me.lHoraCierreFijo.Size = New System.Drawing.Size(234, 24)
        Me.lHoraCierreFijo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lHoraCierreFijo.Text = "Hora Cierre Fijo:"
        Me.lHoraCierreFijo.TextSize = New System.Drawing.Size(118, 13)
        '
        'lHoraFacturacion
        '
        Me.lHoraFacturacion.Control = Me.HoraCorteFacturacion
        Me.lHoraFacturacion.CustomizationFormText = "Hora Cierre Facturación:"
        Me.lHoraFacturacion.Location = New System.Drawing.Point(679, 0)
        Me.lHoraFacturacion.MaxSize = New System.Drawing.Size(226, 24)
        Me.lHoraFacturacion.MinSize = New System.Drawing.Size(226, 24)
        Me.lHoraFacturacion.Name = "lHoraFacturacion"
        Me.lHoraFacturacion.Size = New System.Drawing.Size(226, 24)
        Me.lHoraFacturacion.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lHoraFacturacion.Text = "Hora Cierre Facturación:"
        Me.lHoraFacturacion.TextSize = New System.Drawing.Size(118, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cbCliente
        Me.LayoutControlItem7.CustomizationFormText = "Cliente Contado:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(471, 96)
        Me.LayoutControlItem7.Name = "cbClienteitem"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(434, 24)
        Me.LayoutControlItem7.Text = "Cliente Contado:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(118, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtNombreGrte
        Me.LayoutControlItem5.CustomizationFormText = "Gerente de Ventas:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem5.Name = "txtNombreGrteitem"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(471, 24)
        Me.LayoutControlItem5.Text = "Gerente de Ventas:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(118, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbCatalogo
        Me.LayoutControlItem3.CustomizationFormText = "Cuenta Contable:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem3.Name = "cbCatalogoitem"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(471, 24)
        Me.LayoutControlItem3.Text = "Cuenta Contable:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(118, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cbCentroCosto
        Me.LayoutControlItem10.CustomizationFormText = "Centro de Costo:"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(471, 120)
        Me.LayoutControlItem10.Name = "cbCentroCostoitem"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(434, 24)
        Me.LayoutControlItem10.Text = "Centro de Costo:"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(118, 13)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup2.AppearanceGroup.ForeColor = System.Drawing.Color.Crimson
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem12, Me.LayoutControlItem16, Me.LayoutControlItem14, Me.LayoutControlItem17, Me.SplitterItem1, Me.LayoutControlItem15, Me.LayoutControlItem13, Me.LayoutControlItem18, Me.EmptySpaceItem2, Me.LayoutControlItem19, Me.EmptySpaceItem3, Me.EmptySpaceItem4, Me.EmptySpaceItem5, Me.LayoutControlItem11})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(905, 408)
        Me.LayoutControlGroup2.Text = "Configurar Series"
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.Serie
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(355, 24)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(355, 24)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(355, 24)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.Text = "Serie (C.A.I):"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(118, 13)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.GridControl1
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 143)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(452, 220)
        Me.LayoutControlItem16.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtSerieR
        Me.LayoutControlItem14.Location = New System.Drawing.Point(457, 0)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(327, 24)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(327, 24)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(327, 24)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.Text = "Serie:"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(118, 13)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.GridControl2
        Me.LayoutControlItem17.Location = New System.Drawing.Point(457, 50)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(424, 313)
        Me.LayoutControlItem17.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'SplitterItem1
        '
        Me.SplitterItem1.AllowHotTrack = True
        Me.SplitterItem1.Location = New System.Drawing.Point(452, 0)
        Me.SplitterItem1.Name = "SplitterItem1"
        Me.SplitterItem1.Size = New System.Drawing.Size(5, 363)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.txtRecibo
        Me.LayoutControlItem15.Location = New System.Drawing.Point(457, 24)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(327, 26)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(327, 26)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(327, 26)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.Text = "# Recibo:"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(118, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.Factura
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(355, 26)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(355, 26)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(355, 26)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.Text = "# Factura:"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(118, 13)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.AgregarF
        Me.LayoutControlItem18.Location = New System.Drawing.Point(355, 24)
        Me.LayoutControlItem18.MaxSize = New System.Drawing.Size(86, 26)
        Me.LayoutControlItem18.MinSize = New System.Drawing.Size(86, 26)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(86, 26)
        Me.LayoutControlItem18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(355, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(86, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.btnAgregarR
        Me.LayoutControlItem19.Location = New System.Drawing.Point(784, 24)
        Me.LayoutControlItem19.MaxSize = New System.Drawing.Size(84, 26)
        Me.LayoutControlItem19.MinSize = New System.Drawing.Size(84, 26)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(84, 26)
        Me.LayoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(784, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(84, 24)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(868, 0)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(13, 50)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(441, 0)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(11, 50)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.mDescripcion
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(452, 93)
        Me.LayoutControlItem11.Text = "Descripción:"
        Me.LayoutControlItem11.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(118, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtNombrePC
        Me.LayoutControlItem2.CustomizationFormText = "PC:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "txtNombrePCitem"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(905, 24)
        Me.LayoutControlItem2.Text = "PC:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(118, 13)
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(12, 54)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(108, 38)
        Me.cmdCancelar.StyleController = Me.LayoutControl1
        Me.cmdCancelar.TabIndex = 1
        Me.cmdCancelar.Text = "&Salir"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cmdCancelar)
        Me.LayoutControl1.Controls.Add(Me.cmdAceptar)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup3
        Me.LayoutControl1.Size = New System.Drawing.Size(132, 683)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Image = Global.SysContab.My.Resources.Resources.RibbonUserDesigner_SaveFileLarge
        Me.cmdAceptar.Location = New System.Drawing.Point(12, 12)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(108, 38)
        Me.cmdAceptar.StyleController = Me.LayoutControl1
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Text = "&Guardar"
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem20})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(132, 683)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cmdAceptar
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.cmdCancelar
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(112, 621)
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextVisible = False
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.ID = New System.Guid("b707a43a-1269-4ccf-8996-0f771d04eb1d")
        Me.DockPanel1.Location = New System.Drawing.Point(925, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(140, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(140, 710)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(132, 683)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'frmAgregarCaja
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1065, 710)
        Me.Controls.Add(Me.frmAgregarCajaConvertedLayout)
        Me.Controls.Add(Me.DockPanel1)
        Me.KeyPreview = True
        Me.Name = "frmAgregarCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.cbCentroCosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmAgregarCajaConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmAgregarCajaConvertedLayout.ResumeLayout(False)
        CType(Me.mDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerieR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Serie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRecibo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Factura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HoraCorteFacturacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HoraCorteFijo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreGrte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbbodega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lHoraCierreFijo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lHoraFacturacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim r As New VB.SysContab.Rutinas()
    Dim Cajas As New VB.SysContab.CajasDB()
    Dim Red As String
    Dim i As Integer
    Public Caja As Integer = 0
    Dim DT As New DataTable("Series")
    Dim DT2 As New DataTable("SeriesR")

    Private Sub frmAgregarCaja_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim f As frmCajas = frmCajas.Instance()
        If f.Created Then f.Cargar()
    End Sub

    Private Sub frmAgregarCaja_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Close()
    End Sub

    Private Sub frmAgregarCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)
        '
        Try
            If Caja <> 0 Then   ''Validar si tiene derecho a cambiar las Horas de Corte
                Recurso = ObtieneDatos("SELECT rr.ID FROM REST_Recursos rr WHERE rr.Control = 'etCajas'").Rows.Item(0)(0)
                Dim dt As DataTable = ObtieneDatos("_REST_GetAccionesUsuario " & Usr_Rol & "," & Recurso & "")

                HoraCorteFijo.Enabled = False
                HoraCorteFacturacion.Enabled = False

                For i As Integer = 0 To dt.Rows.Count - 1
                    If dt.Rows.Item(i)("Control") = HoraCorteFijo.Name Then HoraCorteFijo.Enabled = True
                    If dt.Rows.Item(i)("Control") = HoraCorteFacturacion.Name Then HoraCorteFacturacion.Enabled = True
                Next
            End If
        Catch ex As Exception
        End Try

        Try
            cmbbodega.Properties.DataSource = ObtieneDatos("SELECT Codigo_Bodega as Codigo,Codigo_Bodega + ' - ' + Ubicacion as Bodega FROM BODEGAS where empresa = " & EmpresaActual)
            cmbbodega.Properties.ValueMember = "Codigo"
            cmbbodega.Properties.DisplayMember = "Bodega"
            cmbbodega.Properties.PopulateColumns()
            cmbbodega.Properties.Columns(0).Visible = False
            cmbbodega.Properties.ShowFooter = False
            cmbbodega.Properties.ShowHeader = False

            GetClientesContado(cbCliente)
            GetCentrosCostosList(cbCentroCosto)

            GetCatalogoCuenta(Me.cbCatalogo, Me.vCatalogo)
            'Me.cbCliente.ItemIndex = 0

            If Caja <> 0 Then ' Edita la caja

                Dim dtCaja As DataTable = ObtieneDatos("sp_sel_Caja_Detalle", Caja, EmpresaActual) 'ObtieneDatos("SELECT * FROM CAJAS c WHERE c.cj_Codigo = " & Caja & " AND c.Empresa_ID = " & EmpresaActual)
                '
                txtCodigo.Text = Caja
                lbComputadoras.Visible = False
                '
                txtNombrePC.Text = dtCaja.Rows.Item(0)("pc_Nombre")
                txtNombre.Text = dtCaja.Rows.Item(0)("cj_nombre")
                cmbbodega.EditValue = dtCaja.Rows.Item(0)("Bodega")
                txtNombreGrte.Text = dtCaja.Rows.Item(0)("cj_NombreGerente")
                cbCatalogo.EditValue = dtCaja.Rows.Item(0)("Cuenta")
                cbCentroCosto.EditValue = dtCaja.Rows.Item(0)("CentroCosto")
                HoraCorteFijo.EditValue = dtCaja.Rows.Item(0)("HoraCorte_Fija")
                HoraCorteFacturacion.EditValue = dtCaja.Rows.Item(0)("HoraCorte")
                cbCliente.EditValue = dtCaja.Rows.Item(0)("IdCliente")
            Else
                'Dim ConnectionFile As New System.IO.StreamReader(Application.StartupPath & "\Red.txt")

                'Red = "WinNT://" & ConnectionFile.ReadLine.ToString()
                '"WinNT://GRUPODESARROLLO"
                ''r.FormularioColor(Me)

                Me.lbComputadoras.BackColor = Color.White

                'Dim domain As New DirectoryServices.DirectoryEntry(Red)
                'Dim computadoras As DirectoryServices.DirectoryEntries
                'Dim computadora As DirectoryServices.DirectoryEntry

                'computadoras = domain.Children
                'computadoras.SchemaFilter.Add("Computer")


                'For Each computadora In computadoras
                '    i = 1
                '    'MessageBox.Show(computadora.Name)
                '    If Cajas.PcNombre(computadora.Name).Tables("Cajas").Rows.Count = 0 Then
                '        lbComputadoras.Items.Add(computadora.Name)
                '    End If
                'Next

                'If i = 0  Then
                If Cajas.PcNombre(Environment.MachineName.ToString).Tables("Cajas").Rows.Count = 0 Then
                    Me.lbComputadoras.Items.Add(Environment.MachineName.ToString)
                End If
                'End If

                txtCodigo.Text = Cajas.Numero
                txtNombre.Focus()
            End If
            '
            GetSeries()

            'Dim mo As System.Management.ManagementObject
            'Dim moq As System.Management.ObjectQuery = New System.Management.ObjectQuery("select * from Win32_NetworkAdapter")
            'Dim mos As New System.Management.ManagementObjectSearcher(moq)
            'For Each mo In mos.Get()
            '    MessageBox.Show("MACAddress = " & mo("MACAddress"))
            'Next mo
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Not DxValidationProvider1.Validate Then Exit Sub
        '
        'If Caja = 0 Then
        '    If Me.lbComputadoras.Items.Count = 0 Then
        '        XtraMessageBox.Show("Todas las Computadoras de la red ya fueron configuradas como Cajas.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        Exit Sub
        '    End If
        'End If

        If Trim(txtNombre.Text) = "" Then
            XtraMsg("Introduzca el nombre de la Caja")
            txtNombre.Focus()
            txtNombre.SelectAll()
            Exit Sub
        End If

        If Trim(txtNombrePC.Text) = "" Then
            XtraMsg("Seleccione el nombre de la Computadora")
            txtNombrePC.Focus()
            txtNombrePC.SelectAll()
            Exit Sub
        End If

        If Me.cbCatalogo.EditValue Is Nothing Then
            XtraMsg("Seleccione la Cuenta Contable de la Caja")
            cbCatalogo.Focus()
            Exit Sub
        End If

        If GridView1.DataRowCount = 0 Then
            XtraMsg("Debe Configurar las Series para Facturación!", MessageBoxIcon.Warning)
            Serie.Focus()
            Exit Sub
        End If

        Try
            If Caja <> 0 Then 'Edita
                Cajas.Update(txtCodigo.Text, txtNombre.Text, txtNombrePC.Text, HoraCorteFijo.EditValue, HoraCorteFacturacion.EditValue, _
                             cmbbodega.EditValue, Me.txtNombreGrte.Text, Me.cbCatalogo.EditValue, _
                             IIf(Me.cbCentroCosto.EditValue Is Nothing, 0, Me.cbCentroCosto.EditValue))

                'GuardaDatos("UPDATE Cajas set cj_nombre = '" & txtNombre.Text & "'," _
                '            + " bodega = '" & cmbbodega.EditValue & "'," _
                '            + " cj_NombreGerente = '" & Me.txtNombreGrte.Text & "'" _
                '            + " WHERE empresa_id = " & EmpresaActual & " and cj_codigo = " & Caja)
                '
                Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion)
                Conn.IniciarTransaccion()
                '
                Try
                    '****  Guaradar Series Cajas   ****
                    For i As Integer = 0 To GridView1.DataRowCount - 1
                        With GridView1
                            Conn.AddParameter("IdDetalle", SqlDbType.Int, 4, ParameterDirection.Input, IsNull(.GetRowCellValue(i, "IdDetalle"), 0))
                            Conn.AddParameter("Serie", SqlDbType.NVarChar, 50, ParameterDirection.Input, IsNull(.GetRowCellValue(i, "Serie"), ""))
                            Conn.AddParameter("Factura", SqlDbType.Float, 10, ParameterDirection.Input, IsNull(.GetRowCellValue(i, "Factura"), 1))
                            Conn.AddParameter("Codigo", SqlDbType.Int, 4, ParameterDirection.Input, txtCodigo.Text)
                            Conn.AddParameter("Tipo", SqlDbType.Int, 4, ParameterDirection.Input, IIf(Me.cbCliente.EditValue Is Nothing, 0, Me.cbCliente.EditValue))
                            Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
                            Conn.AddParameter("Descripcion", SqlDbType.NVarChar, -1, ParameterDirection.Input, IsNull(.GetRowCellValue(i, "Descripcion"), ""))
                            Conn.EjecutarComando("SPGuardaSeriesCajas")
                        End With
                    Next
                    '****  Guaradar Series Recibos   ****
                    For i As Integer = 0 To GridView2.DataRowCount - 1
                        With GridView2
                            Conn.AddParameter("IdDetalle", SqlDbType.Int, 4, ParameterDirection.Input, IsNull(.GetRowCellValue(i, "IdDetalle"), 0))
                            Conn.AddParameter("Serie", SqlDbType.NVarChar, 50, ParameterDirection.Input, IsNull(.GetRowCellValue(i, "Serie"), ""))
                            Conn.AddParameter("Recibo", SqlDbType.Float, 10, ParameterDirection.Input, IsNull(.GetRowCellValue(i, "Recibo"), 1))
                            Conn.AddParameter("Codigo", SqlDbType.Int, 4, ParameterDirection.Input, txtCodigo.Text)
                            Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
                            Conn.EjecutarComando("SPGuardaSeriesRecibos")
                        End With
                    Next
                    Conn.CompletarTransaccion()
                Catch ex As Exception
                    Conn.AnularTransaccion()
                    XtraMsg("Error : " & ex.Message & vbCrLf & "No se puede guardar la serie", MessageBoxIcon.Error)
                End Try

                XtraMsg("Los Datos de la Caja han sido Actualizados Satisfactoriamente !!!")
                Me.Close()
            Else    'Guardar
                Cajas.AddItem(txtCodigo.Text, txtNombre.Text, txtNombrePC.Text, HoraCorteFijo.EditValue, HoraCorteFacturacion.EditValue, _
                              cmbbodega.EditValue, Me.txtNombreGrte.Text, Me.cbCatalogo.EditValue, _
                              IIf(Me.cbCentroCosto.EditValue Is Nothing, 0, Me.cbCentroCosto.EditValue))

                Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion)
                Conn.IniciarTransaccion()
                Try
                    '****  Guaradar Series Cajas   ****
                    For i As Integer = 0 To GridView1.DataRowCount - 1
                        With GridView1
                            Conn.AddParameter("IdDetalle", SqlDbType.Int, 4, ParameterDirection.Input, IsNull(.GetRowCellValue(i, "IdDetalle"), 0))
                            Conn.AddParameter("Serie", SqlDbType.NVarChar, 50, ParameterDirection.Input, IsNull(.GetRowCellValue(i, "Serie"), ""))
                            Conn.AddParameter("Factura", SqlDbType.Int, 4, ParameterDirection.Input, IsNull(.GetRowCellValue(i, "Factura"), 1))
                            Conn.AddParameter("Codigo", SqlDbType.Int, 4, ParameterDirection.Input, txtCodigo.Text)
                            Conn.AddParameter("Tipo", SqlDbType.Int, 4, ParameterDirection.Input, IIf(Me.cbCliente.EditValue Is Nothing, 0, Me.cbCliente.EditValue))
                            Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
                            Conn.AddParameter("Descripcion", SqlDbType.NVarChar, -1, ParameterDirection.Input, IsNull(.GetRowCellValue(i, "Descripcion"), ""))
                            Conn.EjecutarComando("SPGuardaSeriesCajas")
                        End With
                    Next
                    '****  Guaradar Series Recibos   ****
                    For i As Integer = 0 To GridView2.DataRowCount - 1
                        With GridView2
                            Conn.AddParameter("IdDetalle", SqlDbType.Int, 4, ParameterDirection.Input, IsNull(.GetRowCellValue(i, "IdDetalle"), 0))
                            Conn.AddParameter("Serie", SqlDbType.NVarChar, 50, ParameterDirection.Input, IsNull(.GetRowCellValue(i, "Serie"), ""))
                            Conn.AddParameter("Recibo", SqlDbType.Float, 10, ParameterDirection.Input, IsNull(.GetRowCellValue(i, "Recibo"), 1))
                            Conn.AddParameter("Codigo", SqlDbType.Int, 4, ParameterDirection.Input, txtCodigo.Text)
                            Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
                            Conn.EjecutarComando("SPGuardaSeriesRecibos")
                        End With
                    Next
                    Conn.CompletarTransaccion()
                Catch ex As Exception
                    Conn.AnularTransaccion()
                    XtraMsg("Error : " & ex.Message & vbCrLf & "No se puede guardar la serie", MessageBoxIcon.Error)

                End Try

                XtraMsg("Los Datos de la Caja han Sido Registrados Satisfactoriamente !!!")
                Me.Close()

                'r.LimpiarControles(GroupBox1)
                'txtCodigo.Text = Cajas.Numero
                'GetSeries()
                'txtNombre.Focus()
                ''Me.lbComputadoras.SelectedIndex = 0

                ''Dim domain As New DirectoryServices.DirectoryEntry("WinNT://GRUPODESARROLLO")
                'Dim domain As New DirectoryServices.DirectoryEntry(Red)
                'Dim computadoras As DirectoryServices.DirectoryEntries
                'Dim computadora As DirectoryServices.DirectoryEntry

                'computadoras = domain.Children
                'computadoras.SchemaFilter.Add("Computer")
                'lbComputadoras.Items.Clear()

                'For Each computadora In computadoras
                '    'MessageBox.Show(computadora.Name)
                '    If Cajas.PcNombre(computadora.Name).Tables("Cajas").Rows.Count = 0 Then
                '        lbComputadoras.Items.Add(computadora.Name)
                '    End If
                'Next
            End If
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmAgregarCaja_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim Tabla As New DataTable()
        Dim ds As New DataSet()

        Dim f As frmCajas = f.Instance
        f.Cargar()

        'ds = Cajas.List
        'f.dgCajas.DataSource = ds.Tables("Cajas").DefaultView
        'Tabla = ds.Tables("Cajas")

        'r.FormatGenerico(f.dgCajas, Tabla)

        'If ds.Tables("Cajas").Rows.Count <> 0 Then
        '    Registro = f.dgCajas.Item(0, 0)
        'Else
        '    Registro = "Vacio"
        'End If
    End Sub

    Private Sub lbComputadoras_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbComputadoras.SelectedIndexChanged
        Me.txtNombrePC.Text = lbComputadoras.Items.Item(lbComputadoras.SelectedIndex)
    End Sub

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarF.Click
        'If IsNumeric(Me.Serie.EditValue) Then
        '    MsgBox("La Serie de la Factura NO puede ser un valor Númercio", MsgBoxStyle.Exclamation)
        '    Exit Sub
        'End If

        If Me.Factura.Text.Trim.Length = 0 Then
            XtraMsg("Introduzca el No. de Factura")
            Factura.Focus()
            Exit Sub
        End If

        'If VerificarExiste("F") Then
        '    XtraMessageBox.Show("La Serie ya Existe.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Exit Sub
        'End If

        Dim Fila As DataRow = DT.NewRow
        Fila.Item(0) = 0
        Fila.Item(1) = Serie.Text.Trim
        Fila.Item(2) = Factura.Text.Trim
        Fila.Item(6) = mDescripcion.Text

        DT.Rows.Add(Fila)
        Serie.Text = vbNullString
        Factura.Text = vbNullString
        GridView1.RefreshData()
        Serie.Focus()
    End Sub

    Private Sub btnAgregarR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarR.Click
        If Me.txtRecibo.Text.Trim.Length = 0 Then
            XtraMessageBox.Show("Introduzca el No. de Factura", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'If VerificarExiste("R") Then
        '    XtraMessageBox.Show("La Serie ya Existe.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Exit Sub
        'End If

        Dim Fila As DataRow = DT2.NewRow
        Fila.Item(0) = 0
        Fila.Item(1) = txtSerieR.Text.Trim
        Fila.Item(2) = txtRecibo.Text.Trim
        DT2.Rows.Add(Fila)
        txtSerieR.Text = vbNullString
        txtRecibo.Text = vbNullString
        GridView2.RefreshData()
    End Sub

    Function VerificarExiste(ByVal TipoS As String) As Boolean
        If TipoS = "F" Then
            For i As Integer = 0 To Me.GridView1.DataRowCount - 1
                If Me.Serie.Text.Trim = Me.GridView1.GetRowCellValue(i, "Serie") Then
                    Return True
                End If
            Next
        ElseIf TipoS = "R" Then
            For i As Integer = 0 To Me.GridView2.DataRowCount - 1
                If Me.txtSerieR.Text.Trim = Me.GridView2.GetRowCellValue(i, "Serie") Then
                    Return True
                End If
            Next
        End If

        Return False
    End Function

    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Delete Then
            If XtraMessageBox.Show("Esta seguro que desea eliminar el registro?", "Borrar Linea", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
                GuardaDatos("DELETE FROM SeriesCajas WHERE IdDetalle = " & IsNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IdDetalle"), 0))
                GridView1.DeleteRow(GridView1.FocusedRowHandle)
            End If
        End If
    End Sub

    Private Sub GridView2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView2.KeyDown
        If e.KeyCode = Keys.Delete Then
            If XtraMessageBox.Show("Esta seguro que desea eliminar el registro?", "Borrar Linea", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
                GuardaDatos("DELETE FROM SeriesRecibos WHERE IdDetalle = " & IsNull(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "IdDetalle"), 0))
                GridView2.DeleteRow(GridView2.FocusedRowHandle)
            End If
        End If
    End Sub

    Private Sub GetSeries()
        DT = Nothing
        DT2 = Nothing

        DT = ObtieneDatos("SELECT * FROM SeriesCajas WHERE Codigo = " & IIf(txtCodigo.Text = "", 0, Me.txtCodigo.Text) & " and empresa = " & EmpresaActual)
        GridControl1.DataSource = DT
        '
        DT2 = ObtieneDatos("SELECT * FROM SeriesRecibos sr WHERE sr.Codigo = " & IIf(txtCodigo.Text = "", 0, Me.txtCodigo.Text) & " AND sr.Empresa = " & EmpresaActual)
        GridControl2.DataSource = DT2

        'Try
        '    Me.cbCliente.EditValue = DT.Rows.Item(0)("Tipo")
        'Catch ex As Exception
        'End Try
    End Sub
End Class

'Para el usuario logueado:
'        MessageBox.Show(System.Environment.UserName)

'Para el nombre de la máquina:
'        MessageBox.Show(SystemInformation.ComputerName())

'Para el Volumen del disco C por ejemplo:
'Dim disco As New 
'System.Management.ManagementObject("Win32_LogicalDisk.DeviceId='C:'")
'        MessageBox.Show("VolumeSerialNumber = " & disco("VolumeSerialNumber"))

'Para los parámetros de máscara de red:
'Dim mo As System.Management.ManagementObject
'        Dim moq As System.Management.ObjectQuery = New 
'System.Management.ObjectQuery("select * from Win32_NetworkAdapter")
'Dim mos As New System.Management.ManagementObjectSearcher(moq)
'        For Each mo In mos.Get()
'            MessageBox.Show("MACAddress = " & mo("MACAddress"))
'        Next mo
