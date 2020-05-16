Imports System.Data
Imports System.Data.SqlClient
Imports SysContab.VB.SysContab
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class frmNotasCreditoProveedor
    Inherits DevExpress.XtraEditors.XtraForm
    'Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmNotasCreditoProveedor = Nothing

    Public Shared Function Instance() As frmNotasCreditoProveedor
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmNotasCreditoProveedor
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
    Friend WithEvents etInicio As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents etProveedorCodigo As System.Windows.Forms.Label
    Friend WithEvents GridDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemCuenta As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ItemCuentas As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbTipoComp As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dgFactura As DevExpress.XtraGrid.GridControl
    Friend WithEvents txtRef As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMonto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents vNota As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents vFactura As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbMoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnReCalcula As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQuit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rgNotas As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbServicios As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtConcepto As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkDiferencial As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lyDiferencial As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbCatalogo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbProveedor As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents rMonto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtTasa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rTotales As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotasCreditoProveedor))
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtTasa = New DevExpress.XtraEditors.TextEdit()
        Me.cbProveedor = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.chkDiferencial = New DevExpress.XtraEditors.CheckEdit()
        Me.btnQuit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnReCalcula = New DevExpress.XtraEditors.SimpleButton()
        Me.etProveedorCodigo = New System.Windows.Forms.Label()
        Me.GridDetalle = New DevExpress.XtraGrid.GridControl()
        Me.vNota = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbCatalogo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rMonto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbServicios = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemCuenta = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ItemCuentas = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.txtConcepto = New DevExpress.XtraEditors.MemoEdit()
        Me.rgNotas = New DevExpress.XtraEditors.RadioGroup()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.etInicio = New System.Windows.Forms.Label()
        Me.txtRef = New DevExpress.XtraEditors.TextEdit()
        Me.Fecha = New DevExpress.XtraEditors.DateEdit()
        Me.dgFactura = New DevExpress.XtraGrid.GridControl()
        Me.vFactura = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rTotales = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbTipoComp = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbMoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtMonto = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lyDiferencial = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtTasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDiferencial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vNota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgNotas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rTotales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipoComp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyDiferencial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.ImageOptions.Image = Global.SysContab.My.Resources.Resources.RibbonPrintPreview_SaveLarge
        Me.btnSave.Location = New System.Drawing.Point(12, 440)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 38)
        Me.btnSave.StyleController = Me.LayoutControl1
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Guardar"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtTasa)
        Me.LayoutControl1.Controls.Add(Me.cbProveedor)
        Me.LayoutControl1.Controls.Add(Me.chkDiferencial)
        Me.LayoutControl1.Controls.Add(Me.btnQuit)
        Me.LayoutControl1.Controls.Add(Me.btnReCalcula)
        Me.LayoutControl1.Controls.Add(Me.btnSave)
        Me.LayoutControl1.Controls.Add(Me.etProveedorCodigo)
        Me.LayoutControl1.Controls.Add(Me.GridDetalle)
        Me.LayoutControl1.Controls.Add(Me.txtConcepto)
        Me.LayoutControl1.Controls.Add(Me.rgNotas)
        Me.LayoutControl1.Controls.Add(Me.Label1)
        Me.LayoutControl1.Controls.Add(Me.etInicio)
        Me.LayoutControl1.Controls.Add(Me.txtRef)
        Me.LayoutControl1.Controls.Add(Me.Fecha)
        Me.LayoutControl1.Controls.Add(Me.dgFactura)
        Me.LayoutControl1.Controls.Add(Me.cbTipoComp)
        Me.LayoutControl1.Controls.Add(Me.cbMoneda)
        Me.LayoutControl1.Controls.Add(Me.txtMonto)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem12, Me.LayoutControlItem13})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(815, 404, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1061, 490)
        Me.LayoutControl1.TabIndex = 171
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtTasa
        '
        Me.txtTasa.EditValue = New Decimal(New Integer() {10000, 0, 0, 262144})
        Me.txtTasa.EnterMoveNextControl = True
        Me.txtTasa.Location = New System.Drawing.Point(465, 92)
        Me.txtTasa.Name = "txtTasa"
        Me.txtTasa.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtTasa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
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
        Me.txtTasa.Size = New System.Drawing.Size(96, 22)
        Me.txtTasa.StyleController = Me.LayoutControl1
        Me.txtTasa.TabIndex = 172
        '
        'cbProveedor
        '
        Me.cbProveedor.Location = New System.Drawing.Point(122, 118)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedor.Properties.Appearance.Options.UseFont = True
        Me.cbProveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProveedor.Properties.View = Me.SearchLookUpEdit1View
        Me.cbProveedor.Size = New System.Drawing.Size(439, 20)
        Me.cbProveedor.StyleController = Me.LayoutControl1
        Me.cbProveedor.TabIndex = 171
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'chkDiferencial
        '
        Me.chkDiferencial.Location = New System.Drawing.Point(323, 66)
        Me.chkDiferencial.Name = "chkDiferencial"
        Me.chkDiferencial.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDiferencial.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkDiferencial.Properties.Appearance.Options.UseFont = True
        Me.chkDiferencial.Properties.Appearance.Options.UseForeColor = True
        Me.chkDiferencial.Properties.Caption = "Aplicar como Diferencial"
        Me.chkDiferencial.Size = New System.Drawing.Size(238, 19)
        Me.chkDiferencial.StyleController = Me.LayoutControl1
        Me.chkDiferencial.TabIndex = 170
        Me.chkDiferencial.Visible = False
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.ImageOptions.Image = CType(resources.GetObject("btnQuit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnQuit.Location = New System.Drawing.Point(958, 440)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(91, 38)
        Me.btnQuit.StyleController = Me.LayoutControl1
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "&Salir"
        '
        'btnReCalcula
        '
        Me.btnReCalcula.ImageOptions.Image = CType(resources.GetObject("btnReCalcula.ImageOptions.Image"), System.Drawing.Image)
        Me.btnReCalcula.Location = New System.Drawing.Point(111, 440)
        Me.btnReCalcula.Name = "btnReCalcula"
        Me.btnReCalcula.Size = New System.Drawing.Size(102, 38)
        Me.btnReCalcula.StyleController = Me.LayoutControl1
        Me.btnReCalcula.TabIndex = 1
        Me.btnReCalcula.Text = "&Recalcular"
        '
        'etProveedorCodigo
        '
        Me.etProveedorCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etProveedorCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etProveedorCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etProveedorCodigo.Location = New System.Drawing.Point(436, 12)
        Me.etProveedorCodigo.Name = "etProveedorCodigo"
        Me.etProveedorCodigo.Size = New System.Drawing.Size(574, 20)
        Me.etProveedorCodigo.TabIndex = 162
        Me.etProveedorCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etProveedorCodigo.Visible = False
        '
        'GridDetalle
        '
        Me.GridDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDetalle.Location = New System.Drawing.Point(12, 218)
        Me.GridDetalle.MainView = Me.vNota
        Me.GridDetalle.Name = "GridDetalle"
        Me.GridDetalle.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ItemCuenta, Me.ItemCuentas, Me.cbServicios, Me.cbCatalogo, Me.rMonto})
        Me.GridDetalle.Size = New System.Drawing.Size(549, 218)
        Me.GridDetalle.TabIndex = 9
        Me.GridDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vNota})
        '
        'vNota
        '
        Me.vNota.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vNota.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.vNota.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vNota.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.vNota.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.vNota.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.vNota.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.vNota.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.vNota.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.vNota.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.vNota.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.vNota.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.vNota.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.vNota.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.vNota.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.vNota.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.vNota.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.vNota.Appearance.Empty.Options.UseBackColor = True
        Me.vNota.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vNota.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.vNota.Appearance.EvenRow.Options.UseBackColor = True
        Me.vNota.Appearance.EvenRow.Options.UseForeColor = True
        Me.vNota.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vNota.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.vNota.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vNota.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.vNota.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.vNota.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.vNota.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.vNota.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.vNota.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.vNota.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.vNota.Appearance.FilterPanel.Options.UseBackColor = True
        Me.vNota.Appearance.FilterPanel.Options.UseForeColor = True
        Me.vNota.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.vNota.Appearance.FixedLine.Options.UseBackColor = True
        Me.vNota.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.vNota.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.vNota.Appearance.FocusedCell.Options.UseBackColor = True
        Me.vNota.Appearance.FocusedCell.Options.UseForeColor = True
        Me.vNota.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.vNota.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.vNota.Appearance.FocusedRow.Options.UseBackColor = True
        Me.vNota.Appearance.FocusedRow.Options.UseForeColor = True
        Me.vNota.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vNota.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.vNota.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vNota.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.vNota.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.vNota.Appearance.FooterPanel.Options.UseBackColor = True
        Me.vNota.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.vNota.Appearance.FooterPanel.Options.UseForeColor = True
        Me.vNota.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.vNota.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.vNota.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.vNota.Appearance.GroupButton.Options.UseBackColor = True
        Me.vNota.Appearance.GroupButton.Options.UseBorderColor = True
        Me.vNota.Appearance.GroupButton.Options.UseForeColor = True
        Me.vNota.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.vNota.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.vNota.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.vNota.Appearance.GroupFooter.Options.UseBackColor = True
        Me.vNota.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.vNota.Appearance.GroupFooter.Options.UseForeColor = True
        Me.vNota.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.vNota.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vNota.Appearance.GroupPanel.Options.UseBackColor = True
        Me.vNota.Appearance.GroupPanel.Options.UseForeColor = True
        Me.vNota.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.vNota.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.vNota.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.vNota.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.vNota.Appearance.GroupRow.Options.UseBackColor = True
        Me.vNota.Appearance.GroupRow.Options.UseBorderColor = True
        Me.vNota.Appearance.GroupRow.Options.UseFont = True
        Me.vNota.Appearance.GroupRow.Options.UseForeColor = True
        Me.vNota.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vNota.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.vNota.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vNota.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.vNota.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.vNota.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.vNota.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.vNota.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.vNota.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.vNota.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.vNota.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.vNota.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.vNota.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.vNota.Appearance.HorzLine.Options.UseBackColor = True
        Me.vNota.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.vNota.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.vNota.Appearance.OddRow.Options.UseBackColor = True
        Me.vNota.Appearance.OddRow.Options.UseForeColor = True
        Me.vNota.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.vNota.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.vNota.Appearance.Preview.Options.UseBackColor = True
        Me.vNota.Appearance.Preview.Options.UseForeColor = True
        Me.vNota.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.vNota.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.vNota.Appearance.Row.Options.UseBackColor = True
        Me.vNota.Appearance.Row.Options.UseForeColor = True
        Me.vNota.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.vNota.Appearance.RowSeparator.Options.UseBackColor = True
        Me.vNota.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.vNota.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.vNota.Appearance.SelectedRow.Options.UseBackColor = True
        Me.vNota.Appearance.SelectedRow.Options.UseForeColor = True
        Me.vNota.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.vNota.Appearance.VertLine.Options.UseBackColor = True
        Me.vNota.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn6, Me.GridColumn18, Me.GridColumn19, Me.GridColumn27})
        Me.vNota.GridControl = Me.GridDetalle
        Me.vNota.Name = "vNota"
        Me.vNota.OptionsCustomization.AllowFilter = False
        Me.vNota.OptionsCustomization.AllowGroup = False
        Me.vNota.OptionsCustomization.AllowSort = False
        Me.vNota.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.vNota.OptionsView.ShowFooter = True
        Me.vNota.OptionsView.ShowGroupPanel = False
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Cuenta"
        Me.GridColumn4.ColumnEdit = Me.cbCatalogo
        Me.GridColumn4.FieldName = "Cuenta"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 136
        '
        'cbCatalogo
        '
        Me.cbCatalogo.AutoHeight = False
        Me.cbCatalogo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn6.AppearanceHeader.Options.UseFont = True
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "Monto"
        Me.GridColumn6.ColumnEdit = Me.rMonto
        Me.GridColumn6.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "Monto"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Monto", "{0:n2}")})
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        Me.GridColumn6.Width = 66
        '
        'rMonto
        '
        Me.rMonto.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rMonto.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rMonto.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rMonto.Appearance.Options.UseBackColor = True
        Me.rMonto.Appearance.Options.UseFont = True
        Me.rMonto.Appearance.Options.UseForeColor = True
        Me.rMonto.Appearance.Options.UseTextOptions = True
        Me.rMonto.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.rMonto.AutoHeight = False
        Me.rMonto.Mask.EditMask = "n2"
        Me.rMonto.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rMonto.Mask.UseMaskAsDisplayFormat = True
        Me.rMonto.Name = "rMonto"
        '
        'GridColumn18
        '
        Me.GridColumn18.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn18.AppearanceHeader.Options.UseFont = True
        Me.GridColumn18.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn18.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn18.Caption = "Descripción"
        Me.GridColumn18.FieldName = "Descripcion"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 2
        Me.GridColumn18.Width = 157
        '
        'GridColumn19
        '
        Me.GridColumn19.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn19.AppearanceHeader.Options.UseFont = True
        Me.GridColumn19.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn19.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn19.Caption = "Tipo Retensión"
        Me.GridColumn19.ColumnEdit = Me.cbServicios
        Me.GridColumn19.FieldName = "ret"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 4
        Me.GridColumn19.Width = 74
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
        'GridColumn27
        '
        Me.GridColumn27.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn27.AppearanceHeader.Options.UseFont = True
        Me.GridColumn27.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn27.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn27.Caption = "Factura"
        Me.GridColumn27.FieldName = "Factura"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.Visible = True
        Me.GridColumn27.VisibleIndex = 3
        Me.GridColumn27.Width = 98
        '
        'ItemCuenta
        '
        Me.ItemCuenta.AutoHeight = False
        Me.ItemCuenta.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemCuenta.Name = "ItemCuenta"
        Me.ItemCuenta.NullText = ""
        Me.ItemCuenta.ShowFooter = False
        Me.ItemCuenta.ShowHeader = False
        '
        'ItemCuentas
        '
        Me.ItemCuentas.AutoHeight = False
        Me.ItemCuentas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemCuentas.Name = "ItemCuentas"
        Me.ItemCuentas.NullText = ""
        Me.ItemCuentas.ShowFooter = False
        Me.ItemCuentas.ShowHeader = False
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(680, 368)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(369, 68)
        Me.txtConcepto.StyleController = Me.LayoutControl1
        Me.txtConcepto.TabIndex = 7
        '
        'rgNotas
        '
        Me.rgNotas.EditValue = 1
        Me.rgNotas.Location = New System.Drawing.Point(12, 36)
        Me.rgNotas.Name = "rgNotas"
        Me.rgNotas.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgNotas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgNotas.Properties.Appearance.ForeColor = System.Drawing.Color.Brown
        Me.rgNotas.Properties.Appearance.Options.UseBackColor = True
        Me.rgNotas.Properties.Appearance.Options.UseFont = True
        Me.rgNotas.Properties.Appearance.Options.UseForeColor = True
        Me.rgNotas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rgNotas.Properties.Columns = 2
        Me.rgNotas.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Nota de Débito"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Nota de Crédito")})
        Me.rgNotas.Size = New System.Drawing.Size(549, 26)
        Me.rgNotas.StyleController = Me.LayoutControl1
        Me.rgNotas.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1037, 20)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "EMISION DE NOTAS DE CRÉDITO Y DÉBITOS A PROVEEDORES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'etInicio
        '
        Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etInicio.Location = New System.Drawing.Point(329, 249)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(314, 83)
        Me.etInicio.TabIndex = 158
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
        '
        'txtRef
        '
        Me.txtRef.EditValue = ""
        Me.txtRef.Location = New System.Drawing.Point(122, 66)
        Me.txtRef.Name = "txtRef"
        Me.txtRef.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtRef.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRef.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.txtRef.Properties.Appearance.Options.UseBackColor = True
        Me.txtRef.Properties.Appearance.Options.UseFont = True
        Me.txtRef.Properties.Appearance.Options.UseForeColor = True
        Me.txtRef.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRef.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtRef.Size = New System.Drawing.Size(186, 22)
        Me.txtRef.StyleController = Me.LayoutControl1
        Me.txtRef.TabIndex = 1
        '
        'Fecha
        '
        Me.Fecha.EditValue = Nothing
        Me.Fecha.Location = New System.Drawing.Point(122, 92)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.Fecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Fecha.Properties.Appearance.Options.UseFont = True
        Me.Fecha.Properties.Appearance.Options.UseForeColor = True
        Me.Fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Fecha.Size = New System.Drawing.Size(142, 20)
        Me.Fecha.StyleController = Me.LayoutControl1
        Me.Fecha.TabIndex = 2
        '
        'dgFactura
        '
        Me.dgFactura.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgFactura.Location = New System.Drawing.Point(570, 36)
        Me.dgFactura.MainView = Me.vFactura
        Me.dgFactura.Name = "dgFactura"
        Me.dgFactura.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rTotales})
        Me.dgFactura.Size = New System.Drawing.Size(479, 328)
        Me.dgFactura.TabIndex = 8
        Me.dgFactura.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vFactura})
        '
        'vFactura
        '
        Me.vFactura.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vFactura.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.vFactura.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vFactura.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.vFactura.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.vFactura.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.vFactura.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.vFactura.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.vFactura.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.vFactura.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.vFactura.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.vFactura.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.vFactura.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.vFactura.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.vFactura.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.vFactura.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.vFactura.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.vFactura.Appearance.Empty.Options.UseBackColor = True
        Me.vFactura.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vFactura.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.vFactura.Appearance.EvenRow.Options.UseBackColor = True
        Me.vFactura.Appearance.EvenRow.Options.UseForeColor = True
        Me.vFactura.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vFactura.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.vFactura.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vFactura.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.vFactura.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.vFactura.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.vFactura.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.vFactura.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.vFactura.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.vFactura.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.vFactura.Appearance.FilterPanel.Options.UseBackColor = True
        Me.vFactura.Appearance.FilterPanel.Options.UseForeColor = True
        Me.vFactura.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.vFactura.Appearance.FixedLine.Options.UseBackColor = True
        Me.vFactura.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.vFactura.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.vFactura.Appearance.FocusedCell.Options.UseBackColor = True
        Me.vFactura.Appearance.FocusedCell.Options.UseForeColor = True
        Me.vFactura.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.vFactura.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.vFactura.Appearance.FocusedRow.Options.UseBackColor = True
        Me.vFactura.Appearance.FocusedRow.Options.UseForeColor = True
        Me.vFactura.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vFactura.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.vFactura.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vFactura.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.vFactura.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.vFactura.Appearance.FooterPanel.Options.UseBackColor = True
        Me.vFactura.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.vFactura.Appearance.FooterPanel.Options.UseForeColor = True
        Me.vFactura.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.vFactura.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.vFactura.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.vFactura.Appearance.GroupButton.Options.UseBackColor = True
        Me.vFactura.Appearance.GroupButton.Options.UseBorderColor = True
        Me.vFactura.Appearance.GroupButton.Options.UseForeColor = True
        Me.vFactura.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.vFactura.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.vFactura.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.vFactura.Appearance.GroupFooter.Options.UseBackColor = True
        Me.vFactura.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.vFactura.Appearance.GroupFooter.Options.UseForeColor = True
        Me.vFactura.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.vFactura.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vFactura.Appearance.GroupPanel.Options.UseBackColor = True
        Me.vFactura.Appearance.GroupPanel.Options.UseForeColor = True
        Me.vFactura.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.vFactura.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.vFactura.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.vFactura.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.vFactura.Appearance.GroupRow.Options.UseBackColor = True
        Me.vFactura.Appearance.GroupRow.Options.UseBorderColor = True
        Me.vFactura.Appearance.GroupRow.Options.UseFont = True
        Me.vFactura.Appearance.GroupRow.Options.UseForeColor = True
        Me.vFactura.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vFactura.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.vFactura.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.vFactura.Appearance.HeaderPanel.Options.UseFont = True
        Me.vFactura.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.vFactura.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.vFactura.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.vFactura.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.vFactura.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.vFactura.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.vFactura.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.vFactura.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.vFactura.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.vFactura.Appearance.HorzLine.Options.UseBackColor = True
        Me.vFactura.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.vFactura.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.vFactura.Appearance.OddRow.Options.UseBackColor = True
        Me.vFactura.Appearance.OddRow.Options.UseForeColor = True
        Me.vFactura.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.vFactura.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.vFactura.Appearance.Preview.Options.UseBackColor = True
        Me.vFactura.Appearance.Preview.Options.UseForeColor = True
        Me.vFactura.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.vFactura.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.vFactura.Appearance.Row.Options.UseBackColor = True
        Me.vFactura.Appearance.Row.Options.UseForeColor = True
        Me.vFactura.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.vFactura.Appearance.RowSeparator.Options.UseBackColor = True
        Me.vFactura.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.vFactura.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.vFactura.Appearance.SelectedRow.Options.UseBackColor = True
        Me.vFactura.Appearance.SelectedRow.Options.UseForeColor = True
        Me.vFactura.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.vFactura.Appearance.VertLine.Options.UseBackColor = True
        Me.vFactura.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn5, Me.GridColumn25, Me.GridColumn26})
        Me.vFactura.GridControl = Me.dgFactura
        Me.vFactura.Name = "vFactura"
        Me.vFactura.OptionsView.ShowAutoFilterRow = True
        Me.vFactura.OptionsView.ShowFooter = True
        Me.vFactura.OptionsView.ShowGroupPanel = False
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn7.AppearanceHeader.Options.UseFont = True
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "Factura"
        Me.GridColumn7.FieldName = "Factura"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 0
        Me.GridColumn7.Width = 52
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn8.AppearanceHeader.Options.UseFont = True
        Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.Caption = "Fecha"
        Me.GridColumn8.FieldName = "Fecha"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        Me.GridColumn8.Width = 54
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn9.AppearanceHeader.Options.UseFont = True
        Me.GridColumn9.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.Caption = "Saldo"
        Me.GridColumn9.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "Saldo"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Saldo", "{0:n2}")})
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 5
        Me.GridColumn9.Width = 58
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn10.AppearanceHeader.Options.UseFont = True
        Me.GridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.Caption = "Seleccionar"
        Me.GridColumn10.FieldName = "selecc"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 9
        Me.GridColumn10.Width = 51
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn11.AppearanceHeader.Options.UseFont = True
        Me.GridColumn11.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.Caption = "Total"
        Me.GridColumn11.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn11.FieldName = "GranTotal"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GranTotal", "{0:n2}")})
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 3
        Me.GridColumn11.Width = 56
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Tipo"
        Me.GridColumn12.FieldName = "Tipo"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'GridColumn13
        '
        Me.GridColumn13.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn13.AppearanceHeader.Options.UseFont = True
        Me.GridColumn13.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn13.Caption = "Parcial"
        Me.GridColumn13.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn13.FieldName = "Parcial"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Parcial", "{0:n2}")})
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 4
        Me.GridColumn13.Width = 57
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Comp_No"
        Me.GridColumn14.FieldName = "Comp_No"
        Me.GridColumn14.Name = "GridColumn14"
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Mes"
        Me.GridColumn15.FieldName = "Mes"
        Me.GridColumn15.Name = "GridColumn15"
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Per_Id"
        Me.GridColumn16.FieldName = "Per_Id"
        Me.GridColumn16.Name = "GridColumn16"
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Comp_Fecha"
        Me.GridColumn17.FieldName = "Comp_Fecha"
        Me.GridColumn17.Name = "GridColumn17"
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Comp_No1"
        Me.GridColumn20.FieldName = "Comp_No1"
        Me.GridColumn20.Name = "GridColumn20"
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "PerID1"
        Me.GridColumn21.FieldName = "PerID1"
        Me.GridColumn21.Name = "GridColumn21"
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "Mes1"
        Me.GridColumn22.FieldName = "Mes1"
        Me.GridColumn22.Name = "GridColumn22"
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "Fecha_Pago"
        Me.GridColumn23.FieldName = "Fecha_Pago"
        Me.GridColumn23.Name = "GridColumn23"
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "ND"
        Me.GridColumn24.FieldName = "ND"
        Me.GridColumn24.Name = "GridColumn24"
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Mnto. Valor"
        Me.GridColumn1.ColumnEdit = Me.rTotales
        Me.GridColumn1.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn1.FieldName = "Mnto"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Mnto", "{0:n2}")})
        Me.GridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 7
        Me.GridColumn1.Width = 51
        '
        'rTotales
        '
        Me.rTotales.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rTotales.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rTotales.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rTotales.Appearance.Options.UseBackColor = True
        Me.rTotales.Appearance.Options.UseFont = True
        Me.rTotales.Appearance.Options.UseForeColor = True
        Me.rTotales.AutoHeight = False
        Me.rTotales.Mask.EditMask = "n2"
        Me.rTotales.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rTotales.Mask.UseMaskAsDisplayFormat = True
        Me.rTotales.Name = "rTotales"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Moneda"
        Me.GridColumn2.FieldName = "Moneda"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.AllowFocus = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 33
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "A Pagar"
        Me.GridColumn3.ColumnEdit = Me.rTotales
        Me.GridColumn3.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "A Pagar"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "A Pagar", "{0:n2}")})
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 8
        Me.GridColumn3.Width = 49
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "AplicarMnto"
        Me.GridColumn5.FieldName = "AplicarMnto"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.AllowFocus = False
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "mon_codigo"
        Me.GridColumn25.FieldName = "mon_codigo"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.OptionsColumn.AllowEdit = False
        Me.GridColumn25.OptionsColumn.AllowFocus = False
        '
        'GridColumn26
        '
        Me.GridColumn26.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn26.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn26.Caption = "Abono"
        Me.GridColumn26.ColumnEdit = Me.rTotales
        Me.GridColumn26.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn26.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn26.FieldName = "Abono"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.OptionsColumn.AllowEdit = False
        Me.GridColumn26.OptionsColumn.AllowFocus = False
        Me.GridColumn26.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Abono", "{0:n2}")})
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 6
        '
        'cbTipoComp
        '
        Me.cbTipoComp.Location = New System.Drawing.Point(122, 142)
        Me.cbTipoComp.Name = "cbTipoComp"
        Me.cbTipoComp.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoComp.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.cbTipoComp.Properties.Appearance.Options.UseFont = True
        Me.cbTipoComp.Properties.Appearance.Options.UseForeColor = True
        Me.cbTipoComp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipoComp.Properties.NullText = ""
        Me.cbTipoComp.Properties.ShowFooter = False
        Me.cbTipoComp.Properties.ShowHeader = False
        Me.cbTipoComp.Size = New System.Drawing.Size(439, 20)
        Me.cbTipoComp.StyleController = Me.LayoutControl1
        Me.cbTipoComp.TabIndex = 4
        '
        'cbMoneda
        '
        Me.cbMoneda.Location = New System.Drawing.Point(122, 166)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMoneda.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.cbMoneda.Properties.Appearance.Options.UseFont = True
        Me.cbMoneda.Properties.Appearance.Options.UseForeColor = True
        Me.cbMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMoneda.Properties.NullText = ""
        Me.cbMoneda.Properties.ShowFooter = False
        Me.cbMoneda.Properties.ShowHeader = False
        Me.cbMoneda.Size = New System.Drawing.Size(439, 20)
        Me.cbMoneda.StyleController = Me.LayoutControl1
        Me.cbMoneda.TabIndex = 5
        '
        'txtMonto
        '
        Me.txtMonto.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMonto.Location = New System.Drawing.Point(122, 190)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtMonto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtMonto.Properties.Appearance.Options.UseBackColor = True
        Me.txtMonto.Properties.Appearance.Options.UseFont = True
        Me.txtMonto.Properties.Appearance.Options.UseForeColor = True
        Me.txtMonto.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtMonto.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Maroon
        Me.txtMonto.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtMonto.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtMonto.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtMonto.Properties.Mask.EditMask = "n2"
        Me.txtMonto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMonto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMonto.Properties.ReadOnly = True
        Me.txtMonto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMonto.Size = New System.Drawing.Size(170, 24)
        Me.txtMonto.StyleController = Me.LayoutControl1
        Me.txtMonto.TabIndex = 6
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.etInicio
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(317, 237)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(318, 87)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.etProveedorCodigo
        Me.LayoutControlItem13.CustomizationFormText = "LayoutControlItem13"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(424, 0)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(24, 24)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(578, 24)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem11, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.lyDiferencial, Me.LayoutControlItem18, Me.LayoutControlItem5, Me.LayoutControlItem14, Me.EmptySpaceItem4, Me.SplitterItem1, Me.LayoutControlItem9})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1061, 490)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Label1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(24, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1041, 24)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.rgNotas
        Me.LayoutControlItem3.CustomizationFormText = "Tipo de Nota"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(0, 30)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(54, 30)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(553, 30)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Tipo de Nota"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtRef
        Me.LayoutControlItem2.CustomizationFormText = "#Referencia:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 54)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(300, 26)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(300, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(300, 26)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "#Referencia:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(107, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.Fecha
        Me.LayoutControlItem4.CustomizationFormText = "Fecha:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 80)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(256, 26)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(256, 26)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(256, 26)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "Fecha:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(107, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cbTipoComp
        Me.LayoutControlItem6.CustomizationFormText = "Tipo de Comprobante:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 130)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(553, 24)
        Me.LayoutControlItem6.Text = "Tipo de Comprobante:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(107, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cbMoneda
        Me.LayoutControlItem7.CustomizationFormText = "Moneda:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 154)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(553, 24)
        Me.LayoutControlItem7.Text = "Moneda:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(107, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtMonto
        Me.LayoutControlItem8.CustomizationFormText = "Monto:"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 178)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(284, 28)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(284, 28)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(284, 28)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.Text = "Monto:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(107, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.dgFactura
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(558, 24)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(483, 332)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.btnSave
        Me.LayoutControlItem15.CustomizationFormText = "LayoutControlItem15"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 428)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.btnReCalcula
        Me.LayoutControlItem16.CustomizationFormText = "LayoutControlItem16"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(99, 428)
        Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem16.MinSize = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.btnQuit
        Me.LayoutControlItem17.CustomizationFormText = "LayoutControlItem17"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(946, 428)
        Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem17.MinSize = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(300, 54)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(11, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(256, 80)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(87, 26)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(205, 428)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(741, 42)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'lyDiferencial
        '
        Me.lyDiferencial.Control = Me.chkDiferencial
        Me.lyDiferencial.Location = New System.Drawing.Point(311, 54)
        Me.lyDiferencial.Name = "lyDiferencial"
        Me.lyDiferencial.Size = New System.Drawing.Size(242, 26)
        Me.lyDiferencial.TextSize = New System.Drawing.Size(0, 0)
        Me.lyDiferencial.TextVisible = False
        Me.lyDiferencial.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.cbProveedor
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 106)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(553, 24)
        Me.LayoutControlItem18.Text = "Proveedor:"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(107, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtTasa
        Me.LayoutControlItem5.Location = New System.Drawing.Point(343, 80)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(210, 26)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(210, 26)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(210, 26)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "T/Cambio:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(107, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.GridDetalle
        Me.LayoutControlItem14.CustomizationFormText = "LayoutControlItem14"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 206)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(553, 222)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(284, 178)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(269, 28)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'SplitterItem1
        '
        Me.SplitterItem1.AllowHotTrack = True
        Me.SplitterItem1.Location = New System.Drawing.Point(553, 24)
        Me.SplitterItem1.Name = "SplitterItem1"
        Me.SplitterItem1.Size = New System.Drawing.Size(5, 404)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtConcepto
        Me.LayoutControlItem9.CustomizationFormText = "Concepto:"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(558, 356)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(0, 72)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(124, 72)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(483, 72)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.Text = "Concepto:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(107, 13)
        '
        'frmNotasCreditoProveedor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1061, 490)
        Me.Controls.Add(Me.LayoutControl1)
        Me.LookAndFeel.SkinName = "Blue"
        Me.Name = "frmNotasCreditoProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtTasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDiferencial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vNota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgNotas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rTotales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipoComp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyDiferencial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Proveedores As New VB.SysContab.ProveedoresDB
    Public ProveedoresDetalle As New VB.SysContab.ProveedoresDetails

    Dim Facturas As New VB.SysContab.Facturas_ComprasDB
    Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails
    'Dim Tasa As New VB.SysContab.Tasa_CambioDB

    Dim r As New VB.SysContab.Rutinas
    Dim per As New VB.SysContab.PeriodosDB

    'Dim DT As DataTable
    Dim DC As Integer = 1
    'Dim TasaCambio As Double = 1
    'Dim TC As Double = 1
    Public Inicio As Integer
    'Dim NoComprob As Integer = 0
    Dim AsocioarPagos As Boolean = False

    Private DT_Distribucion As DataTable = New DataTable("Distribucion")
    Private Temp As Boolean = False
    Dim _DT As New DataTable("Facturas_Compras")

    Private Sub Distribucion()
        'Me.DT_Distribucion = ObtieneDatos("SELECT * FROM Distribucion")
        DT_Distribucion = CargaDistribucion(0, 0, 0)
    End Sub


    Private Sub frmListaFacturaClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProveedoresDetalle = Proveedores.GetDetails(etProveedorCodigo.Text)

        ' SearchLookUp(cbProveedor, ObtieneDatos("_ProveedoresLista", EmpresaActual, "%", 0), "NOMBRE", "CODIGO", 4, 5, 6, 7, 8, 9, 10, 11, 12, 13)
        SearchLookUp(cbProveedor, VB.SysContab.ProveedoresDB.ProveedoresList(1).Tables("Proveedores"), "Nombre", "Codigo")

        GetTipoComprobantesList(cbTipoComp)

        GetMonedasList(cbMoneda)


        'cbProveedor.Properties.DataSource = ObtieneDatos("SELECT 0 Codigo,'--- Seleccione ---' Nombre, '' Cuenta UNION SELECT Codigo, Nombre,Cuenta FROM Proveedores WHERE Empresa =" & EmpresaActual).DefaultView
        'cbProveedor.Properties.ValueMember = "Codigo"
        'cbProveedor.Properties.DisplayMember = "Nombre"
        'cbProveedor.EditValue = CInt(ProveedoresDetalle.Codigo)

        'cbTipoComp.Properties.DataSource = ObtieneDatos("SELECT 0 Codigo, '--- Seleccione ---' Nombre UNION SELECT tc.TipComp_Id Codigo,tc.TipComp_Nombre Nombre FROM TipoComprobantes tc WHERE tc.Empresa = " & EmpresaActual)
        'cbTipoComp.Properties.ValueMember = "Codigo"
        'cbTipoComp.Properties.DisplayMember = "Nombre"
        'cbTipoComp.Properties.PopulateColumns()
        'cbTipoComp.Properties.Columns(0).Visible = False
        'cbTipoComp.EditValue = 0

        'cbMoneda.Properties.DataSource = ObtieneDatos("SELECT m.mon_codigo Codigo,m.mon_simbolo + ' - ' + m.mon_descripcion Nombre FROM Monedas m WHERE m.empr_codigo = " & EmpresaActual)
        'cbMoneda.Properties.ValueMember = "Codigo"
        'cbMoneda.Properties.DisplayMember = "Nombre"
        'cbMoneda.Properties.PopulateColumns()
        'cbMoneda.Properties.Columns(0).Visible = False
        'cbMoneda.EditValue = EmpresasDB.GetDetails(EmpresaActual).MonedaBase

        Distribucion()
        '
        Cargar()
        Fecha.DateTime = VB.SysContab.Rutinas.Fecha().Date
        txtTasa.EditValue = GetTasaCambioDia(Fecha.DateTime.Date)
    End Sub

    Sub Cargar()
        RepositorySearchLook(cbCatalogo, ObtieneDatos("_GetCatalogo_CuentaActivo", EmpresaActual), "Display", "Cuenta", 2)


        'DT = ObtieneDatos("SP_CatalogoList 'A'," & EmpresaActual)
        'ItemCuenta.DataSource = DT
        'ItemCuenta.DisplayMember = "Cuenta"
        'ItemCuenta.ValueMember = "Cuenta"
        'ItemCuenta.PopulateColumns()

        'ItemCuentas.DataSource = DT
        'ItemCuentas.DisplayMember = "Nombre"
        'ItemCuentas.ValueMember = "Cuenta"
        'ItemCuentas.PopulateColumns()

        'For i As Integer = 2 To ItemCuenta.Columns.Count - 1
        '    ItemCuentas.Columns(i).Visible = False
        '    ItemCuenta.Columns(i).Visible = False
        'Next

        'ItemCuenta.Columns(1).Visible = False
        'ItemCuentas.Columns(0).Visible = False

        GetServicios_Retencion(cbServicios)

        GetDetalle()
        GetNota()
    End Sub

    Private Sub GetDetalle()
        'GridDetalle.DataSource = ObtieneDatos("SELECT '' as Cuenta,0.00 as Monto FROM Usuarios WHERE 0=1")
        'GridDetalle.DataSource = ObtieneDatos("SELECT '' as Cuenta,0.00 as Monto,'' Descripcion,'' ret FROM Usuarios WHERE 0=1")
        GridDetalle.DataSource = ObtieneDatos("sp_sel_ComprobantesVacio", EmpresaActual)
    End Sub

    Sub GetNota()   'Obtener Consecutivo de Nota de Debito
        Try
            Me.txtRef.Text = IIf(DC = 1, "ND", "NC") +
                ObtieneDatos("sp_sel_NCDProveedorNumero", DC, EmpresaActual).Rows.Item(0)("Numero")

            'ObtieneDatos("SELECT CAST(right(isnull(max(Factura_ID),'ND0000'),4) AS int) + 1 Referencia FROM FacturasTransacciones ft" _
            '+ " WHERE ft.Tipo = " & DC & " AND SUBSTRING(ft.Factura_ID,1,2) = '" & IIf(DC = 1, "ND", "NC") & "' AND ft.Empresa_ID = " & EmpresaActual).Rows.Item(0)(0).ToString.PadLeft(4, "0"c)
        Catch ex As Exception
            txtRef.Text = IIf(DC = 1, "ND", "NC") + "000001"
        End Try
    End Sub

    'Sub GetNotaTrans()   'Obtener Consecutivo de Nota de Debito
    '    Try
    '        Me.txtRef.Text = IIf(DC = 1, "ND", "NC") +
    '            ObtieneDatos("sp_sel_NCDProveedorNumero", DC, EmpresaActual).Rows.Item(0)("Numero")

    '        'ObtieneDatosTrans("SELECT CAST(right(isnull(max(Factura_ID),'ND0000'),4) AS int) + 1 Referencia FROM FacturasTransacciones ft" _
    '        '+ " WHERE ft.Tipo = " & DC & " AND SUBSTRING(ft.Factura_ID,1,2) = '" & IIf(DC = 1, "ND", "NC") & "' AND ft.Empresa_ID = " & EmpresaActual).Rows.Item(0)(0).ToString.PadLeft(4, "0"c)
    '    Catch ex As Exception
    '        txtRef.Text = IIf(DC = 1, "ND", "NC") + "000001"
    '    End Try
    'End Sub

    Private Sub SearchLookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles cbProveedor.EditValueChanged
        If Me.etInicio.Text = "1" Then Exit Sub
        '
        CargarNotas()

        'Try
        '    CargarNotas()
        'Catch ex As Exception
        'End Try
    End Sub

    Sub CargarFactura(ByVal Prove As Integer)

        If Me.rgNotas.EditValue = 1 Then
            ' Me.dgFactura.DataSource = ObtieneDatos("_GetFacturasSaldo_Proveedores " & Prove & "," & EmpresaActual & "").DefaultView

            _DT = ObtieneDatos("sp_GetFacturasSaldo_Proveedores", Fecha.DateTime.Date,
                                                txtTasa.EditValue,
                                                IIf(cbProveedor.EditValue Is Nothing, 0, cbProveedor.EditValue),
                                                EmpresaActual)
            dgFactura.DataSource = _DT

        ElseIf Me.rgNotas.EditValue = 2 Then

            _DT = ObtieneDatos("_GetFacturasSaldo_ProveedoresNC " & Prove & "," & EmpresaActual & "")
            dgFactura.DataSource = _DT

        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Verificar Cierre del Día
        '---------------------------------------------------------------------
        If Not VerificarCierre(Fecha.DateTime.Date) Then
            Exit Sub
        End If
        '-------------------------------------------------------------------

        If Me.txtRef.Text.Trim.Length = 0 Then  '# de Referencia de la Nota
            XtraMsg("Digite la Referencia de la Nota", MessageBoxIcon.Warning)
            Me.txtRef.Focus()
            Exit Sub
        End If

        If ObtieneDatos("SELECT ft.Factura_ID FROM FacturasTransacciones ft WHERE ft.Factura_ID = '" & Me.txtRef.Text & "' AND ft.Empresa_ID = " & EmpresaActual).Rows.Count > 0 Then
            XtraMsg("La Referencia de la Nota ya exite", MessageBoxIcon.Warning)
            Me.txtRef.Focus()
            Exit Sub
        End If

        If cbProveedor.EditValue Is Nothing Then
            XtraMsg("Seleccione el Proveedor")
            cbProveedor.Focus()
            Exit Sub
        End If

        'If Me.cbProveedor.EditValue = 0 Then ' Proveedor
        '    XtraMsg("Seleccione el Proveedor")
        '    Me.cbProveedor.Focus()
        '    Exit Sub
        'End If

        'If Me.cbTipoComp.EditValue = 0 Then ' Tipo de Comprobante
        '    XtraMsg("Seleccione el Tipo de Comprobante")
        '    Me.cbTipoComp.Focus()
        '    Exit Sub
        'End If

        If Me.cbTipoComp.EditValue Is Nothing Then ' Tipo de Comprobante
            XtraMsg("Seleccione el Tipo de Comprobante")
            cbTipoComp.Focus()
            Exit Sub
        End If

        If Me.cbMoneda.EditValue Is Nothing Then
            XtraMsg("Seleccione la Moneda de la Nota")
            cbMoneda.Focus()
            Exit Sub
        End If

        If CInt(Me.txtMonto.EditValue) < 0 Then 'Monto de la Nota
            XtraMsg("El Monto de la Nota Debe ser un Valor mayor que Cero (0), Presione el Botón Recalcular")
            Me.btnReCalcula.Focus()
            Exit Sub
        End If

        If Me.txtConcepto.Text.Trim.Length = 0 Then 'Concepto de la Nota
            XtraMsg("Describa el Concepto de la Nota")
            Me.txtConcepto.Focus()
            Exit Sub
        End If

        If Me.vNota.DataRowCount = 0 Then
            XtraMsg("Introduzca el Detalle de la Nota", MessageBoxIcon.Warning)
            Exit Sub
        End If

        '***** Validar Cuenta contable del Proveedor
        ProveedoresDetalle = Proveedores.GetDetails(Me.cbProveedor.EditValue)

        If ProveedoresDetalle.Cuenta.Trim = "" Then
            XtraMsg("No se pueda crear el Documento porque no hay cuenta contable para el Proveedor: " & ProveedoresDetalle.Nombre, MessageBoxIcon.Error)
            Exit Sub
        End If

        Recalcular()    'Refrescar Datos

        'If Math.Round(Me.txtMonto.EditValue, 2) <> Math.Round((Me.vNota.Columns("Monto").SummaryItem.SummaryValue), 2) Then
        '    XtraMsg("El Monto de la Nota no Corresponde con el Monto en el Detalle de la Nota, Presione el Boton Recalcular", MessageBoxIcon.Warning)
        '    btnReCalcula.Focus()
        '    Exit Sub
        'End If

        AsocioarPagos = False

        Dim Contador As Integer = 0, ValorMnto As Double = 0

        'If Me.rbDebito.Checked Then
        If Me.rgNotas.EditValue = 1 Then    'Notas de Debitos

            'If Me.vFactura.DataRowCount = 0 Then    'Verificar que hayan Factura
            '    XtraMsg("Seleccione la(s) Factura(s) que Desea aplicar La Nota de Débito", MessageBoxIcon.Exclamation)
            '    Exit Sub
            'End If

            vFactura.RefreshData()
            vFactura.UpdateTotalSummary()

            For i As Integer = 0 To Me.vFactura.DataRowCount - 1    'Verificando que hayan Facturas Seleccionadas
                If Me.vFactura.GetRowCellValue(i, "selecc") Then
                    Contador += 1
                    ValorMnto += vFactura.GetRowCellValue(i, "Mnto")
                End If
            Next

            'If cont = 0 Then
            '    If Not XtraMsg2("NO se ha seleccionado ninguna factura del proveedor. " & vbCrLf &
            '                    "Desea Aplicar la N / D a la Cuenta del Proveedor?") Then
            '        Exit Sub
            '    End If
            '    'XtraMsg("Seleccione al menos 1 Factura de la Lista", MessageBoxIcon.Warning)
            '    'Exit Sub
            'End If


            If vFactura.DataRowCount = 0 Then
                If Not XtraMsg2("No se ha seleccionado ninguna factura del proveedor. " & vbCrLf &
                                "Desea Aplicar la [N / D] Como Anticipo al Proveedor " & cbProveedor.Text & " ?") Then
                    Exit Sub
                End If
            Else
                If Contador = 0 Then
                    XtraMsg("Seleccione al menos una (1) [O / P] de la Lista", MessageBoxIcon.Warning)
                    Exit Sub
                End If
                '
                If Math.Round(txtMonto.EditValue, 2) <> Math.Round(CDbl(vFactura.Columns("A Pagar").SummaryItem.SummaryValue), 2) Then
                    XtraMsg("El Monto de la Nota de Débito es Diferente al Total a aplicar: " & vbCrLf _
                            & "Monto Nota de Débito: " & CDbl(txtMonto.EditValue).ToString("n2") & vbCrLf _
                            & "Monto a Aplicar: " & CDbl(vFactura.Columns("A Pagar").SummaryItem.SummaryValue).ToString("n2"), MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If

        End If

        If rgNotas.EditValue = 2 Then   'Para las Notas de Credito
            Dim cont As Integer = 0

            For i As Integer = 0 To Me.vFactura.DataRowCount - 1    'Verificando que hayan Facturas Seleccionadas
                If Me.vFactura.GetRowCellValue(i, "selecc") Then
                    cont += 1
                End If
            Next
            ''
            If cont > 0 Then
                If XtraMsg2("Desea asociar a los Pagos de Facturas con Diferencias?") Then
                    AsocioarPagos = True
                Else
                    AsocioarPagos = False
                End If
            End If
        End If


        '******** VERIFICAR DISTRIBUCION ***********************************
        For i As Integer = 0 To Me.vNota.DataRowCount - 1
            Dim CTemp As String = vbNullString
            Try
                CTemp = ObtieneDatos("SELECT CuentaContable FROM RubrosGastos WHERE Activo = 1 AND" _
                                     + " CuentaContable = '" & Me.vNota.GetRowCellValue(i, "Cuenta") & "'" _
                                     + " AND Empresa = " & EmpresaActual).Rows(0).Item(0)
            Catch ex As Exception
                CTemp = "xxx"
            End Try

            If CTemp <> "xxx" And CTemp <> vbNullString Then
                '
                If VerificaDistribucion(CTemp) = False And ObligarDistribucion = True Then
                    XtraMsg("La Cuenta " & Me.vNota.GetRowCellValue(i, "Cuenta").ToString & " Seleccionada es de Distribución, Favor Distribuirla " & vbCrLf &
                           "ó Verifique el Detalle de la Distribución.", MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If
        Next
        '******** FIN VERIFICAR DISTRIBUCION *****************************

        GuardarNota(Contador, ValorMnto)   'Si Cumple con Todas las condiciones
    End Sub

    Sub GuardarNota(cont As Integer, ValorMnto As Double)

        Dim CuentaMtto As String = ""
        Dim Anticipo As Integer = 0, NoComprob As Integer = 0

        'For i As Integer = 0 To vFactura.DataRowCount - 1    'Verificando que hayan Facturas Seleccionadas
        '    If vFactura.GetRowCellValue(i, "selecc") Then
        '        cont += 1
        '    End If
        'Next
        '
        'Validar para el caso de las N/D aplicadas a Cuenta

        If rgNotas.EditValue = 1 And cont = 0 Then
            Anticipo = 1
        End If

        Dim Per_Id As Integer = VB.SysContab.PeriodosDB.Activo(Fecha.DateTime.Date)

        Dim Plantilla As New VB.SysContab.PlantillaDB
        '
        If rgNotas.EditValue = 1 Then

            If ValorMnto <> 0 Then
                Try
                    'Buscar las Cuentas de Matto Valor
                    Dim DsPlantillas As DataSet = Plantilla.GetPlantillasDetails(7, 1).Detalles

                    If ValorMnto > 0 Then CuentaMtto = DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")
                    If ValorMnto < 0 Then CuentaMtto = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")

                    'CuentaIMtto = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
                Catch ex As Exception
                    XtraMsg("Hace Falta la Plantilla de Mantenimiento de Valor", MessageBoxIcon.Error)
                    Exit Sub
                End Try
            End If

        End If
        '
        '-------------------------------------------------------------
        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction
        '-------------------------------------------------------------

        Try
            'Obtener Numero de Comprobante
            NoComprob = VB.SysContab.ComprobanteDB.GetNoComprobante(Me.Fecha.DateTime.Date)
            Dim MontoNotas As Double = Me.txtMonto.EditValue

            'If Me.rbDebito.Checked Then 
            If rgNotas.EditValue = 1 Then    'Si es Nota de Débito Cancelar Facturas

                For i As Integer = 0 To vFactura.DataRowCount - 1

                    If vFactura.GetRowCellValue(i, "selecc") Then

                        If vFactura.GetRowCellValue(i, "Tipo") = 1 Then _
                                VB.SysContab.ComprobanteDB.CancelarFactura(NoFactura, Me.cbProveedor.EditValue, 1)

                        VB.SysContab.ComprobanteDB.PagosFactura(vFactura.GetRowCellValue(i, "Comp_No"),
                            vFactura.GetRowCellValue(i, "Per_Id"), vFactura.GetRowCellValue(i, "Comp_Fecha"),
                            CDbl(vFactura.GetRowCellValue(i, "Abono")), NoComprob, Per_Id,
                            Fecha.DateTime.Date, vFactura.GetRowCellValue(i, "Factura"), cbProveedor.EditValue, "ND")

                        'Dim tFact As DataTable = ObtieneDatosTrans("SELECT Comp_No,Per_Id,Comp_Fecha,Mes FROM Comprobantes WHERE Factura = '" & NoFactura & "' AND Proveedor = " & Me.cbProveedor.EditValue & " and Empresa = " & EmpresaActual)

                        'If vFactura.GetRowCellValue(i, "A Pagar") <= MontoNotas Then
                        '    'Cancelar Factura
                        '    If vFactura.GetRowCellValue(i, "Tipo") = 1 Then _
                        '        VB.SysContab.ComprobanteDB.CancelarFactura(NoFactura, Me.cbProveedor.EditValue, 1)

                        '    VB.SysContab.ComprobanteDB.PagosFactura(vFactura.GetRowCellValue(i, "Comp_No"),
                        '    vFactura.GetRowCellValue(i, "Per_Id"), vFactura.GetRowCellValue(i, "Fecha"),
                        '    CDbl(vFactura.GetRowCellValue(i, "Abono")), NoComprob, Per_Id,
                        '    Fecha.DateTime.Date, NoFactura, cbProveedor.EditValue, "ND")

                        '    MontoNotas -= Me.vFactura.GetRowCellValue(i, "A Pagar")
                        'Else
                        '    'Abonar a Factura
                        '    VB.SysContab.ComprobanteDB.PagosFactura(Me.vFactura.GetRowCellValue(i, "Comp_No"),
                        '    Me.vFactura.GetRowCellValue(i, "Per_Id"), Me.vFactura.GetRowCellValue(i, "Comp_Fecha"),
                        '    MontoNotas, NoComprob, Per_Id, Fecha.DateTime.Date, NoFactura,
                        '    Me.cbProveedor.EditValue, "ND")

                        '    MontoNotas = 0
                        '    Exit For
                        'End If


                    End If
                Next
                'ElseIf Me.rbCredito.Checked Then    
            ElseIf Me.rgNotas.EditValue = 2 Then    'Cargar Crédito al Proveedor

                If AsocioarPagos Then   'Generar Notas de Credito Asociadas a los pagos de Facturas con Diferencias
                    ShowSplash("Guardando...")
                    'Dim Per_Id As Integer = per.Activo(Fecha.DateTime.Date)

                    For i As Integer = 0 To Me.vFactura.DataRowCount - 1
                        If Me.vFactura.GetRowCellValue(i, "selecc") Then
                            '' GetNotaTrans()
                            NoComprob = VB.SysContab.ComprobanteDB.GetNoComprobante(Me.Fecha.DateTime.Date)
                            'Guardar Nota
                            VB.SysContab.ProveedoresDB.RegistrarTransaccion("NC" + vFactura.GetRowCellValue(i, "Factura"), Me.cbProveedor.EditValue,
                                                                            DC, DC, NoComprob, Me.txtConcepto.Text,
                                                                            Me.Fecha.DateTime.Date, Math.Round(vFactura.GetRowCellValue(i, "Saldo") * -1, 2),
                                                                            txtTasa.EditValue, Me.cbMoneda.EditValue, IIf(chkDiferencial.Checked, 1, 0))

                            'Guardar Encabezado Comprobante
                            VB.SysContab.ComprobanteDB.AddComprobante(cbTipoComp.EditValue, txtTasa.EditValue, Me.txtConcepto.Text, cbMoneda.EditValue,
                                                                      Per_Id, Me.Fecha.DateTime.Date, "", "", False,
                                                                      cbProveedor.EditValue, "", IIf(Me.rgNotas.EditValue = 1, 2, 1),
                                                                      "NC" + vFactura.GetRowCellValue(i, "Factura"), Fecha.DateTime.Date, 0,
                                                                      IIf(rgNotas.EditValue = 1, OrigenComprobantes.ND_PROVEEDOR, OrigenComprobantes.NC_PROVEEDOR), "", 0, Anticipo)

                            'Guardar Detalle del Comprobante
                            'Proveedor
                            VB.SysContab.ComprobanteDB.AddComprobanteDetalles(NoComprob, Proveedores.GetDetails(Me.cbProveedor.EditValue).Cuenta,
                                                                              Me.cbProveedor.Text, Math.Round(vFactura.GetRowCellValue(i, "Saldo") * -1, 2),
                                                                              0, 0, IIf(DC = 1, "D", "C"), "NC" + vFactura.GetRowCellValue(i, "Factura"), 0, Fecha.DateTime.Date,
                                                                              IIf(Me.rgNotas.EditValue = 1, 1, 0))

                            'Detalle
                            Dim Importe As Double = 0

                            For j As Integer = 0 To Me.vNota.DataRowCount - 1
                                Importe = Math.Round(vFactura.GetRowCellValue(i, "Saldo") * -1, 2)

                                VB.SysContab.ComprobanteDB.AddComprobanteDetalles(NoComprob, Me.vNota.GetRowCellValue(j, "Cuenta"),
                                                                                    IsNull(Me.vNota.GetRowCellValue(j, "Descripcion"), ""),
                                                                                     IIf(Importe < 0, Importe * -1, Importe), 0, 0,
                                                                                    IIf(Importe > 0, IIf(DC = 1, "C", "D"), IIf(DC = 1, "D", "C")),
                                                                                    IsNull(Me.vNota.GetRowCellValue(j, "Factura"), ""), 0, Me.Fecha.DateTime.Date,
                                                                                     IIf(Me.rgNotas.EditValue = 1, 0, 1), 0,
                                                                                     IsNull(Me.vNota.GetRowCellValue(j, "ret"), ""))
                            Next

                            'Asocioar a los Pagos
                            VB.SysContab.ComprobanteDB.PagosFactura(NoComprob,
                           Per_Id, Fecha.DateTime.Date,
                           Math.Round(vFactura.GetRowCellValue(i, "Saldo") * -1, 2),
                           vFactura.GetRowCellValue(i, "Comp_No1"),
                           vFactura.GetRowCellValue(i, "PerID1"),
                           vFactura.GetRowCellValue(i, "Fecha_Pago"), "NC" + vFactura.GetRowCellValue(i, "Factura"),
                           cbProveedor.EditValue, vFactura.GetRowCellValue(i, "ND"))
                        End If
                    Next
                    '
                    HideSplash()
                End If


                'Agregar Encabezado  de la Factura
                'Facturas.AddItem(Me.txtRef.Text, Me.Fecha.DateTime.Date, Me.Fecha.DateTime.Date, Me.cbProveedor.EditValue, Me.txtMonto.EditValue, 0, 0, 1, 0, 0, 1, 0, Me.txtConcepto.Text, "F", True, False, False, True, True)
                'VB.SysContab.ComprobanteDB.AddFacturaFecha(Me.cbProveedor.EditValue, Me.txtRef.Text, Me.Fecha.DateTime.Date)
                'Agregar Detalle de la Factura
                'Facturas.AddFacturaLineas(Me.txtRef.Text, "NC", _
                '    1, Me.txtMonto.EditValue, 0.0, 0.0, "P", _
                '     1, 0.0, ConfigDetalles.IVA, Me.cbProveedor.EditValue)
            End If

            If Not AsocioarPagos Then   'Cuando no se asocian los pagos
                ShowSplash("Guardando...")
                'Guardar Nota
                VB.SysContab.ProveedoresDB.RegistrarTransaccion(Me.txtRef.Text, Me.cbProveedor.EditValue,
                                                                DC, DC, NoComprob, Me.txtConcepto.Text,
                                                                Me.Fecha.DateTime.Date, Math.Round(Me.txtMonto.EditValue, 2), txtTasa.EditValue,
                                                                Me.cbMoneda.EditValue, IIf(chkDiferencial.Checked, 1, 0))
                'Guardar Encabezado Comprobante
                VB.SysContab.ComprobanteDB.AddComprobante(Me.cbTipoComp.EditValue, txtTasa.EditValue, Me.txtConcepto.Text, Me.cbMoneda.EditValue,
                                                          Per_Id, Me.Fecha.DateTime.Date, "", "", False,
                                                          Me.cbProveedor.EditValue, "", IIf(Me.rgNotas.EditValue = 1, 2, 1),
                                                          Me.txtRef.Text, Me.Fecha.DateTime.Date, 0,
                                                          IIf(rgNotas.EditValue = 1, OrigenComprobantes.NOTA_DEBITO, OrigenComprobantes.NOTA_CREDITO), "", 0, Anticipo)

                'Guardar Detalle del Comprobante
                'Proveedor
                VB.SysContab.ComprobanteDB.AddComprobanteDetalles(NoComprob, Proveedores.GetDetails(Me.cbProveedor.EditValue).Cuenta,
                                                                  Me.cbProveedor.Text, Math.Round(txtMonto.EditValue - ValorMnto, 2), 0, 0, IIf(DC = 1, "D", "C"),
                                                                  Me.txtRef.Text, 0, Me.Fecha.DateTime.Date, IIf(Me.rgNotas.EditValue = 1, 1, 0))

                If ValorMnto <> 0 Then
                    VB.SysContab.ComprobanteDB.AddComprobanteDetalles(NoComprob, CuentaMtto, "Mantenimiento de Valor, Proveedor : " & cbProveedor.Text,
                                                                  Math.Round(IIf(ValorMnto > 0, ValorMnto, ValorMnto * -1), 2), 0, 0, IIf(ValorMnto > 0, "D", "C"),
                                                                  Me.txtRef.Text, 0, Fecha.DateTime.Date, IIf(rgNotas.EditValue = 1, 1, 0))
                End If
                'Detalle
                Dim Importe As Double = 0

                For i As Integer = 0 To Me.vNota.DataRowCount - 1
                    Importe = Math.Round(CDbl(Me.vNota.GetRowCellValue(i, "Monto")), 2)

                    VB.SysContab.ComprobanteDB.AddComprobanteDetalles(NoComprob, Me.vNota.GetRowCellValue(i, "Cuenta"),
                                                                        IsNull(Me.vNota.GetRowCellValue(i, "Descripcion"), ""),
                                                                        IIf(Importe < 0, Importe * -1, Importe), 0, 0,
                                                                        IIf(Importe > 0, IIf(DC = 1, "C", "D"), IIf(DC = 1, "D", "C")),
                                                                        IsNull(Me.vNota.GetRowCellValue(i, "Factura"), ""), 0, Me.Fecha.DateTime.Date,
                                                                        IIf(Me.rgNotas.EditValue = 1, 0, 1), 0, IsNull(Me.vNota.GetRowCellValue(i, "ret"), ""))
                Next
                HideSplash()
            End If

            VB.SysContab.Rutinas.okTransaccion()   'Guardar Transacciones
        Catch ex As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            XtraMsg("ERROR : " & ex.Message, MessageBoxIcon.Error)
            Exit Sub
        End Try
        '
        Try
            '----------------------
            'Guarda la Distribucion
            '----------------------
            Dim DT_F As DataTable

            DT_F = DT_Distribucion.GetChanges(DataRowState.Added Or DataRowState.Modified Or DataRowState.Deleted)
            If Not DT_F Is Nothing Then
                For i As Integer = 0 To DT_F.Rows.Count - 1
                    With DT_F
                        If .Rows(i).RowState = DataRowState.Added Then
                            GuardaDatos("INSERT INTO Distribucion(IdEmpresa,NoComp,Mes,Per_Id,IdRubroGasto,IdCentroCosto,Valor,Tipo,Cuenta) " &
                            " VALUES(" & .Rows(i).Item("IdEmpresa") & "," & NoComprob & "," & Me.Fecha.DateTime.Month & "," &
                            Per_Id & "," & .Rows(i).Item("IdRubroGasto") & "," & .Rows(i).Item("IdCentroCosto") & "," & .Rows(i).Item("Valor") & ",'" & .Rows(i).Item("Tipo") & "','" & .Rows(i).Item("Cuenta") & "')")
                        ElseIf .Rows(i).RowState = DataRowState.Modified Then
                            GuardaDatos("UPDATE Distribucion SET IdEmpresa=" & .Rows(i).Item("IdEmpresa") & ",NoComp = " & NoComprob & ",Mes=" & Me.Fecha.DateTime.Month & "," &
                            "Per_Id = " & Per_Id & ",IdRubroGasto = " & .Rows(i).Item("IdRubroGasto") & ",IdCentroCosto =" & .Rows(i).Item("IdCentroCosto") & ",Valor = " & .Rows(i).Item("Valor") & "," &
                            "Tipo='" & .Rows(i).Item("Tipo") & "',Cuenta='" & .Rows(i).Item("Cuenta") & "' WHERE IdDetalle = " & .Rows(i).Item("IdDetalle"))
                        ElseIf .Rows(i).RowState = DataRowState.Deleted Then
                        End If
                    End With
                Next
            End If

            Distribucion()
            '--------------------------
            'Fin de Guarda Distribucion
            '--------------------------

            ' Dim ds As New DataSet

            If Not AsocioarPagos Then
                If XtraMsg2("Datos Guardados y Aplicados Correctamente, Imprimir La Nota ?") Then
                    'Dim DT_PINT As DataTable = VB.SysContab.ProveedoresDB.NotaProveedorImprimir(Me.txtRef.Text, Me.cbProveedor.EditValue, IIf(DC = 1, "D", "C"), _
                    'VB.SysContab.Rutinas.Letras(Me.txtMonto.EditValue))

                    'ds.Tables.Add(dtPrint)
                    'ds.WriteXml(Application.StartupPath & "\xml\rptNotaProveedorImprimir.xml", XmlWriteMode.WriteSchema)

                    Dim rpt As New rptNotasProveedores
                    'rpt.XmlDataPath = Application.StartupPath & "\xml\rptNotaProveedorImprimir.xml"
                    rpt.DataSource = VB.SysContab.ProveedoresDB.NotaProveedorImprimir(Me.txtRef.Text,
                                                                                      Me.cbProveedor.EditValue,
                                                                                      IIf(DC = 1, "D", "C"),
                                                                                      VB.SysContab.Rutinas.Letras(Me.txtMonto.EditValue))

                    rpt.ShowPrintMarginsWarning = False
                    rpt.BringToFront()
                    rpt.ShowRibbonPreview()
                End If
            End If


            LimpiarDatos()
            CargarNotas()

        Catch ex As Exception
            XtraMsg("ERROR : " & ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRecalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReCalcula.Click
        'If Me.cbMoneda.EditValue = "" Then
        '    MsgBox("Seleccione la Moneda", MsgBoxStyle.Information, "Moneda")
        '    Exit Sub
        'End If

        Recalcular()
    End Sub

    Sub Recalcular()
        'TC = CDbl(Tasa.TasaCambioDia(Me.Fecha.DateTime.Day, Me.Fecha.DateTime.Month, Me.Fecha.DateTime.Year, EmpresasDB.GetDetails(EmpresaActual).MonedaBase, Me.cbMoneda.EditValue))
        'If vNota.DataRowCount > 0 Then txtMonto.EditValue = CDbl(vNota.Columns("Monto").SummaryItem.SummaryValue)

        '

        vNota.RefreshData()
        vNota.UpdateTotalSummary()
        '
        txtMonto.EditValue = CDbl(vNota.Columns("Monto").SummaryItem.SummaryValue)
    End Sub

    Sub LimpiarDatos()
        Me.txtRef.Text = ""
        'If Me.rgNotas.EditValue = 1 Then CargarFactura(Me.cbProveedor.EditValue)
        'If Me.rbDebito.Checked Then CargarFactura(Me.cbProveedor.EditValue)

        'Me.cbTipoComp.EditValue = Nothing
        Me.cbMoneda.EditValue = EmpresasDB.GetDetails(EmpresaActual).MonedaBase
        Me.txtMonto.EditValue = 0.0
        Me.txtConcepto.Text = String.Empty

        'GetDetalle()
        'GetNota()
    End Sub

    'Function GetTasaCambio() As Boolean
    '    Try
    '        Dim TCambio As Double = CDbl(Tasa.TasaCambioDia(Me.Fecha.DateTime.Day, Me.Fecha.DateTime.Month, _
    '                                                        Me.Fecha.DateTime.Year, EmpresasDB.GetDetails(EmpresaActual).MonedaBase, _
    '                                                        Me.cbMoneda.EditValue))   ' CDbl(TC.GetTasaCambio(EmpresasDB.GetDetails(EmpresaActual).MonedaBase, ObtieneDatos("SELECT * FROM Micros_Configuraciones").Rows.Item(0)("mon_codigo"),   Rutinas.Fecha).Tables(0).Rows.Item(0)("TCambio").ToString)

    '        If TCambio <= 1 Then
    '            'Me.etTCambio.Text = "NO HAY"
    '            'Me.btnSave.Enabled = False
    '            Me.etTCambio.Text = "1.0000"
    '            'TasaCambio = 1
    '            Return False
    '        End If

    '        Me.etTCambio.Text = TCambio.ToString
    '        Me.btnSave.Enabled = True
    '        'TasaCambio = TCambio

    '        Return True
    '    Catch ex As Exception
    '        'Me.etTCambio.Text = "NO HAY"
    '        'Me.btnSave.Enabled = False
    '        Me.etTCambio.Text = "1.0000"
    '        Return False
    '    End Try
    'End Function

    Private Sub vNota_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vNota.KeyDown

        'If Me.vNota.FocusedRowHandle < 0 Then
        '    Exit Sub
        'End If

        If e.KeyCode = Keys.Delete Then
            vNota.DeleteSelectedRows()
            Recalcular()
        End If
    End Sub

    Private Sub Fecha_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fecha.EditValueChanged
        If Me.etInicio.Text = "1" Then Exit Sub

        txtTasa.EditValue = GetTasaCambioDia(Fecha.DateTime.Date)
        '
        CargarNotas()

        'If Not GetTasaCambio() Then
        '    'MsgBox("No hay Definida Tasa de Cambio del Dia : " & Me.Fecha.DateTime.Date, MsgBoxStyle.Exclamation, "Tasa de Cambio")
        'End If
    End Sub

    Private Sub cbMoneda_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMoneda.EditValueChanged
        'If Me.etInicio.Text = "1" Then Exit Sub
        'Try
        '    If Me.cbMoneda.EditValue <> EmpresasDB.GetDetails(EmpresaActual).MonedaBase Then
        '        If Not GetTasaCambio() Then
        '            MsgBox("No hay Definida Tasa de Cambio del Dia : " & Me.Fecha.DateTime.Date, MsgBoxStyle.Exclamation, "Tasa de Cambio")
        '            Exit Sub
        '        End If
        '    End If

        '    TC = CDbl(Tasa.TasaCambioDia(Me.Fecha.DateTime.Day, Me.Fecha.DateTime.Month, Me.Fecha.DateTime.Year, EmpresasDB.GetDetails(EmpresaActual).MonedaBase, Me.cbMoneda.EditValue))
        '    Me.etTCambio.Text = TC.ToString("n4")
        '    Me.btnSave.Enabled = True
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub vNota_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles vNota.RowUpdated
        Recalcular()
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        If My.Forms.frmNotasProveedoresList.Created Then My.Forms.frmNotasProveedoresList.Cargar()
        '
        Close()
    End Sub

    'Private Sub rbDebito_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbDebito.Click
    '    If Me.rbDebito.Checked = True Then
    '        DC = 1
    '        CargarFactura(Me.cbProveedor.EditValue)
    '        GetDetalle()
    '        GetNota()
    '    End If
    'End Sub

    'Private Sub rbCredito_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbCredito.Click
    '    If Me.rbCredito.Checked Then
    '        DC = 2
    '        Me.dgFactura.DataSource = Nothing
    '        GetDetalle()
    '        GetNota()
    '    End If
    'End Sub

    Private Sub rgNotas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgNotas.SelectedIndexChanged
        CargarNotas()
    End Sub

    Sub CargarNotas()
        If Me.rgNotas.EditValue = 1 Then
            DC = 1
            lyDiferencial.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            chkDiferencial.Visible = False
            chkDiferencial.Checked = False
            CargarFactura(Me.cbProveedor.EditValue)
            GetDetalle()
            GetNota()
        ElseIf Me.rgNotas.EditValue = 2 Then
            DC = 2
            lyDiferencial.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            chkDiferencial.Visible = True
            chkDiferencial.Checked = False
            CargarFactura(Me.cbProveedor.EditValue)
            GetDetalle()
            GetNota()
        End If
        '
        Recalcular()
    End Sub

    Private Sub vNota_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vNota.DoubleClick
        If Me.vNota.DataRowCount = 0 Then
            Exit Sub
        End If

        'If Me.rgNotas.EditValue = 1 Then
        '    Exit Sub
        'End If

        'NoComprob = VB.SysContab.ComprobanteDB.GetNoComprobante(Me.Fecha.DateTime.Date)

        Try
            'If dgFacturacionCliente.CurrentRowIndex >= 0 Then
            Dim forma As New FrmDetalleRequisas
            'With dgFacturacionCliente
            With Me.vNota
                If .GetRowCellValue(.FocusedRowHandle, "Monto") = 0 Then
                    XtraMsg("El Monto Debe Ser diferente de Cero (0)", MessageBoxIcon.Error)
                    Exit Sub
                End If
                'forma.Cuenta = .Item(.CurrentRowIndex, 0)
                forma.Cuenta = .GetRowCellValue(.FocusedRowHandle, "Cuenta")
                'If IsDBNull(.Item(.CurrentRowIndex, 3)) OrElse IsNothing(.Item(.CurrentRowIndex, 3)) OrElse .Item(.CurrentRowIndex, 3) = Nothing Then
                'If IsDBNull(.GetRowCellValue(.FocusedRowHandle, "Monto")) OrElse IsNothing(.GetRowCellValue(.FocusedRowHandle, "Monto")) OrElse .GetRowCellValue(.FocusedRowHandle, "Monto") = Nothing OrElse .GetRowCellValue(.FocusedRowHandle, "Monto") = 0 Then
                If Me.rgNotas.EditValue = 1 Then
                    forma.Monto = .GetRowCellValue(.FocusedRowHandle, "Monto") '.Item(.CurrentRowIndex, 4)
                    forma.Tipo = IIf(.GetRowCellValue(.FocusedRowHandle, "Monto") > 0, "C", "D")
                    forma.Periodo = VB.SysContab.PeriodosDB.Activo(Me.Fecha.DateTime)
                    forma.CompNo = 0
                    forma.Cuenta = .GetRowCellValue(.FocusedRowHandle, "Cuenta") '.Item(.CurrentRowIndex, 0)
                    forma.Mes = Fecha.DateTime.Month
                Else
                    forma.Monto = .GetRowCellValue(.FocusedRowHandle, "Monto") '.Item(.CurrentRowIndex, 3)
                    forma.Tipo = IIf(.GetRowCellValue(.FocusedRowHandle, "Monto") > 0, "D", "C")
                    forma.Periodo = VB.SysContab.PeriodosDB.Activo(Me.Fecha.DateTime)
                    forma.CompNo = 0
                    forma.Cuenta = .GetRowCellValue(.FocusedRowHandle, "Cuenta") '.Item(.CurrentRowIndex, 0)
                    forma.Mes = Fecha.DateTime.Month
                End If

                'MsgBox(forma.Tipo)
                'forma.GridView1.OptionsBehavior.Editable = False
                'forma.cmdaceptar.Visible = False

                forma.Mostrar(DT_Distribucion)
                Me.DT_Distribucion.DefaultView.RowFilter = ""
            End With
            'End If
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try
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

    Private Sub vFactura_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles vFactura.RowCellStyle

        If e.Column.FieldName = "A Pagar" Or
                e.Column.FieldName = "Mnto" Then

            e.Appearance.Font = New Font("Thaoma", 8, FontStyle.Bold)
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            e.Appearance.BackColor = Color.LightCyan
            e.Appearance.ForeColor = Color.DarkRed


        End If

        If e.Column.FieldName = "Parcial" Or
                e.Column.FieldName = "Saldo" Then

            e.Appearance.Font = New Font("Thaoma", 8, FontStyle.Regular)
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            e.Appearance.BackColor = Color.LightYellow
            e.Appearance.ForeColor = Color.DarkGreen

        End If

        If e.Column.FieldName = "Abono" Then

            e.Appearance.Font = New Font("Thaoma", 8, FontStyle.Regular)
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            e.Appearance.BackColor = Color.LightGray
            e.Appearance.ForeColor = Color.Red

        End If


    End Sub

    Private Sub vFactura_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles vFactura.CellValueChanged

        'If e.Column.FieldName = "Mnto" Then

        '    If Not IsNumeric(e.Value) Then
        '        vFactura.SetRowCellValue(e.RowHandle, "Mnto", 0.0)
        '    Else
        '        If Not Temp Then
        '            Temp = True
        '            With vFactura

        '                'If .GetRowCellValue(e.RowHandle, "AplicarMnto") Then
        '                '    Dim Mnto As Double = VB.SysContab.Facturas_ComprasDB.GetMntoCompras(.GetRowCellValue(e.RowHandle, "Fecha"),
        '                '                                                                    Fecha.DateTime.Date,
        '                '                                                                    Math.Round(.GetRowCellValue(e.RowHandle, "A Pagar") / txtTasa.EditValue, 2),
        '                '                                                                    .GetRowCellValue(e.RowHandle, "mon_codigo"))
        '                '    If .GetRowCellValue(14, "selecc") Then _
        '                '    vFactura.SetRowCellValue(e.RowHandle, "A Pagar", Math.Round(CDbl(.GetRowCellValue(e.RowHandle, "A Pagar") - Mnto), 2))

        '                '    'Me.vFacturas.SetRowCellValue(e.RowHandle, "PagarU", Math.Round(CDbl(vFactura.GetRowCellValue(e.RowHandle, "Pagar") / Me.txtTasa.EditValue), 2))
        '                'End If

        '                If .GetRowCellValue(e.RowHandle, "selecc") Then
        '                    vFactura.SetRowCellValue(e.RowHandle, "A Pagar", Math.Round(CDbl(.GetRowCellValue(e.RowHandle, "Saldo") + e.Value), 2))
        '                Else
        '                    vFactura.SetRowCellValue(e.RowHandle, "A Pagar", 0.0)
        '                End If


        '            End With
        '            Temp = False
        '        End If
        '    End If
        'End If
        '


        If e.Column.FieldName = "Mnto" Then

            If CDbl(IsNull(vFactura.GetRowCellValue(e.RowHandle, "A Pagar"), 0.0)) > 0 Then
                vFactura.SetRowCellValue(e.RowHandle, "Abono", vFactura.GetRowCellValue(e.RowHandle, "A Pagar") - e.Value)
            Else
                vFactura.SetRowCellValue(e.RowHandle, "Abono", 0.00)
            End If
        End If


        If e.Column.FieldName = "A Pagar" Then

            If e.Value > 0 Then

                If Math.Round(CDbl(e.Value), 2) > Math.Round(CDbl(vFactura.GetRowCellValue(e.RowHandle, "Saldo") + vFactura.GetRowCellValue(e.RowHandle, "Mnto")), 2) Then
                    XtraMsg("El Monto del Pago es Mayor al Saldo de la O/P", MessageBoxIcon.Error)
                    vFactura.SetRowCellValue(e.RowHandle, "Abono", vFactura.GetRowCellValue(e.RowHandle, "Saldo") - vFactura.GetRowCellValue(e.RowHandle, "Mnto"))
                    vFactura.SetRowCellValue(e.RowHandle, "A Pagar", vFactura.GetRowCellValue(e.RowHandle, "Saldo") + vFactura.GetRowCellValue(e.RowHandle, "Mnto"))
                Else
                    vFactura.SetRowCellValue(e.RowHandle, "Abono", e.Value - vFactura.GetRowCellValue(e.RowHandle, "Mnto"))
                End If
            End If

        End If



        If e.Column.FieldName = "selecc" Then

            'If _DT.Select("selecc = 1").Length = 0 Then
            'End If

            Dim APagar As Double = 0

            For i As Integer = 0 To vFactura.DataRowCount - 1
                If vFactura.GetRowCellValue(i, "selecc") Then APagar += vFactura.GetRowCellValue(i, "A Pagar")
            Next

            'Dim APagar As Double = IsNull(_DT.Compute("Sum(Saldo)", "selecc = 1"), 0.00) + IsNull(_DT.Compute("Sum(Mnto)", "selecc = 1"), 0.00)
            Dim Pendiente As Double = Math.Round(txtMonto.EditValue - APagar, 2)

            'If txtMonto.EditValue <= 0 Then
            '    vFactura.SetRowCellValue(e.RowHandle, "selecc", False)
            '    Exit Sub
            'End If
            '
            With vFactura

                If .GetRowCellValue(e.RowHandle, "selecc") Then

                    If Pendiente <= CDbl(vFactura.GetRowCellValue(e.RowHandle, "Saldo") + vFactura.GetRowCellValue(e.RowHandle, "Mnto")) Then
                        If Pendiente <= 0 Then
                            vFactura.SetRowCellValue(e.RowHandle, "selecc", False)
                            '_DT.AcceptChanges()
                            'Exit Sub
                        Else
                            vFactura.SetRowCellValue(e.RowHandle, "Abono", Pendiente - vFactura.GetRowCellValue(e.RowHandle, "Mnto"))
                            vFactura.SetRowCellValue(e.RowHandle, "A Pagar", Pendiente)
                        End If

                    Else
                        vFactura.SetRowCellValue(e.RowHandle, "Abono", CDbl(vFactura.GetRowCellValue(e.RowHandle, "Saldo")))
                        vFactura.SetRowCellValue(e.RowHandle, "A Pagar", CDbl(vFactura.GetRowCellValue(e.RowHandle, "Saldo") + vFactura.GetRowCellValue(e.RowHandle, "Mnto")))
                    End If

                    'vFactura.SetRowCellValue(e.RowHandle, "A Pagar", CDbl(vFactura.GetRowCellValue(e.RowHandle, "Saldo") + vFactura.GetRowCellValue(e.RowHandle, "Mnto")))
                Else
                    vFactura.SetRowCellValue(e.RowHandle, "Abono", 0.00)
                    vFactura.SetRowCellValue(e.RowHandle, "A Pagar", 0.00)
                End If

            End With
        End If

    End Sub

End Class
