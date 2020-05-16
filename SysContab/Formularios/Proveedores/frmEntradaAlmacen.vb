Imports System.Linq
Imports SysContab.VB.SysContab
Imports ClasesBLL

Namespace DataGridTextBoxCombo
    Public Class frmEntradaAlmacen 'frmFacturarCompra
        Inherits DevExpress.XtraEditors.XtraForm

        Private Shared ChildInstance As frmEntradaAlmacen = Nothing

        Public Shared Function Instance() As frmEntradaAlmacen
            If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
                ChildInstance = New frmEntradaAlmacen()
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
        Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdConsultaProveedores As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents etInicio As System.Windows.Forms.Label
        Friend WithEvents gridFact As DevExpress.XtraGrid.GridControl
        Friend WithEvents vFacturas As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents cbCodigo1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents cbCodigo2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents txtPrecio As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Friend WithEvents cbCatalogo As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Friend WithEvents vCatalogo As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents txtSubTotalIR As DevExpress.XtraEditors.TextEdit
        Friend WithEvents dFechaEntrada As DevExpress.XtraEditors.DateEdit
        Friend WithEvents cbBodegas As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents cbTipoFactura As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents cbMovimientos As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents rDescuento As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
        Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents cbProyecto As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
        Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents txtFactura As DevExpress.XtraEditors.TextEdit
        Friend WithEvents cbProveedor As DevExpress.XtraEditors.SearchLookUpEdit
        Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents dtpFechaPago As DevExpress.XtraEditors.DateEdit
        Friend WithEvents dtpFecha As DevExpress.XtraEditors.DateEdit
        Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
        Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
        Friend WithEvents etTotal As DevExpress.XtraEditors.LabelControl
        Friend WithEvents etIva As DevExpress.XtraEditors.LabelControl
        Friend WithEvents etSubTotal As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
        Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents chkLiquidar As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntradaAlmacen))
            Me.cbMovimientos = New DevExpress.XtraEditors.LookUpEdit()
            Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.chkLiquidar = New DevExpress.XtraEditors.CheckEdit()
            Me.etTotal = New DevExpress.XtraEditors.LabelControl()
            Me.etIva = New DevExpress.XtraEditors.LabelControl()
            Me.etSubTotal = New DevExpress.XtraEditors.LabelControl()
            Me.txtSubTotalIR = New DevExpress.XtraEditors.TextEdit()
            Me.gridFact = New DevExpress.XtraGrid.GridControl()
            Me.vFacturas = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.txtPrecio = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.rDescuento = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.cbProyecto = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
            Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.cbCodigo1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.cbCodigo2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.cbCatalogo = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
            Me.vCatalogo = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.dtpFechaPago = New DevExpress.XtraEditors.DateEdit()
            Me.dFechaEntrada = New DevExpress.XtraEditors.DateEdit()
            Me.dtpFecha = New DevExpress.XtraEditors.DateEdit()
            Me.cbBodegas = New DevExpress.XtraEditors.LookUpEdit()
            Me.cbTipoFactura = New DevExpress.XtraEditors.LookUpEdit()
            Me.txtFactura = New DevExpress.XtraEditors.TextEdit()
            Me.cbProveedor = New DevExpress.XtraEditors.SearchLookUpEdit()
            Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.etInicio = New System.Windows.Forms.Label()
            Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
            Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
            Me.cmdConsultaProveedores = New DevExpress.XtraEditors.SimpleButton()
            Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
            Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
            Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            CType(Me.cbMovimientos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.LayoutControl1.SuspendLayout()
            CType(Me.chkLiquidar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtSubTotalIR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridFact, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.vFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbProyecto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbCodigo1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbCodigo2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.vCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dtpFechaPago.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dtpFechaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dFechaEntrada.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dFechaEntrada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dtpFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbBodegas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbTipoFactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtFactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.LayoutControl2.SuspendLayout()
            CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.DockPanel1.SuspendLayout()
            Me.DockPanel1_Container.SuspendLayout()
            Me.SuspendLayout()
            '
            'cbMovimientos
            '
            Me.cbMovimientos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbMovimientos.Location = New System.Drawing.Point(414, 64)
            Me.cbMovimientos.Name = "cbMovimientos"
            Me.cbMovimientos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbMovimientos.Properties.Appearance.Options.UseFont = True
            Me.cbMovimientos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbMovimientos.Properties.NullText = ""
            Me.cbMovimientos.Properties.ShowFooter = False
            Me.cbMovimientos.Size = New System.Drawing.Size(418, 20)
            Me.cbMovimientos.StyleController = Me.LayoutControl1
            Me.cbMovimientos.TabIndex = 153
            Me.cbMovimientos.Tag = "True"
            '
            'LayoutControl1
            '
            Me.LayoutControl1.Controls.Add(Me.chkLiquidar)
            Me.LayoutControl1.Controls.Add(Me.etTotal)
            Me.LayoutControl1.Controls.Add(Me.etIva)
            Me.LayoutControl1.Controls.Add(Me.etSubTotal)
            Me.LayoutControl1.Controls.Add(Me.txtSubTotalIR)
            Me.LayoutControl1.Controls.Add(Me.cbMovimientos)
            Me.LayoutControl1.Controls.Add(Me.gridFact)
            Me.LayoutControl1.Controls.Add(Me.dtpFechaPago)
            Me.LayoutControl1.Controls.Add(Me.dFechaEntrada)
            Me.LayoutControl1.Controls.Add(Me.dtpFecha)
            Me.LayoutControl1.Controls.Add(Me.cbBodegas)
            Me.LayoutControl1.Controls.Add(Me.cbTipoFactura)
            Me.LayoutControl1.Controls.Add(Me.txtFactura)
            Me.LayoutControl1.Controls.Add(Me.cbProveedor)
            Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControl1.Name = "LayoutControl1"
            Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1141, 219, 250, 350)
            Me.LayoutControl1.Root = Me.LayoutControlGroup1
            Me.LayoutControl1.Size = New System.Drawing.Size(844, 508)
            Me.LayoutControl1.TabIndex = 153
            Me.LayoutControl1.Text = "LayoutControl1"
            '
            'chkLiquidar
            '
            Me.chkLiquidar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.chkLiquidar.Location = New System.Drawing.Point(732, 90)
            Me.chkLiquidar.Name = "chkLiquidar"
            Me.chkLiquidar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkLiquidar.Properties.Appearance.ForeColor = System.Drawing.Color.Red
            Me.chkLiquidar.Properties.Appearance.Options.UseFont = True
            Me.chkLiquidar.Properties.Appearance.Options.UseForeColor = True
            Me.chkLiquidar.Properties.Caption = "A Liquidar"
            Me.chkLiquidar.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
            Me.chkLiquidar.Properties.ReadOnly = True
            Me.chkLiquidar.Size = New System.Drawing.Size(100, 22)
            Me.chkLiquidar.StyleController = Me.LayoutControl1
            Me.chkLiquidar.TabIndex = 177
            '
            'etTotal
            '
            Me.etTotal.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTotal.Appearance.ForeColor = System.Drawing.Color.Crimson
            Me.etTotal.Appearance.Options.UseFont = True
            Me.etTotal.Appearance.Options.UseForeColor = True
            Me.etTotal.Location = New System.Drawing.Point(797, 474)
            Me.etTotal.Name = "etTotal"
            Me.etTotal.Size = New System.Drawing.Size(35, 19)
            Me.etTotal.StyleController = Me.LayoutControl1
            Me.etTotal.TabIndex = 172
            Me.etTotal.Text = "0.00"
            '
            'etIva
            '
            Me.etIva.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etIva.Appearance.ForeColor = System.Drawing.Color.Crimson
            Me.etIva.Appearance.Options.UseFont = True
            Me.etIva.Appearance.Options.UseForeColor = True
            Me.etIva.Location = New System.Drawing.Point(626, 474)
            Me.etIva.Name = "etIva"
            Me.etIva.Size = New System.Drawing.Size(35, 18)
            Me.etIva.StyleController = Me.LayoutControl1
            Me.etIva.TabIndex = 171
            Me.etIva.Text = "0.00"
            '
            'etSubTotal
            '
            Me.etSubTotal.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etSubTotal.Appearance.ForeColor = System.Drawing.Color.Crimson
            Me.etSubTotal.Appearance.Options.UseFont = True
            Me.etSubTotal.Appearance.Options.UseForeColor = True
            Me.etSubTotal.Location = New System.Drawing.Point(455, 474)
            Me.etSubTotal.Name = "etSubTotal"
            Me.etSubTotal.Size = New System.Drawing.Size(35, 18)
            Me.etSubTotal.StyleController = Me.LayoutControl1
            Me.etSubTotal.TabIndex = 170
            Me.etSubTotal.Text = "0.00"
            '
            'txtSubTotalIR
            '
            Me.txtSubTotalIR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtSubTotalIR.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
            Me.txtSubTotalIR.Location = New System.Drawing.Point(144, 474)
            Me.txtSubTotalIR.Name = "txtSubTotalIR"
            Me.txtSubTotalIR.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubTotalIR.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
            Me.txtSubTotalIR.Properties.Appearance.Options.UseFont = True
            Me.txtSubTotalIR.Properties.Appearance.Options.UseForeColor = True
            Me.txtSubTotalIR.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
            Me.txtSubTotalIR.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubTotalIR.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Maroon
            Me.txtSubTotalIR.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.txtSubTotalIR.Properties.AppearanceReadOnly.Options.UseFont = True
            Me.txtSubTotalIR.Properties.AppearanceReadOnly.Options.UseForeColor = True
            Me.txtSubTotalIR.Properties.Mask.EditMask = "n2"
            Me.txtSubTotalIR.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.txtSubTotalIR.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.txtSubTotalIR.Properties.ReadOnly = True
            Me.txtSubTotalIR.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.txtSubTotalIR.Size = New System.Drawing.Size(99, 22)
            Me.txtSubTotalIR.StyleController = Me.LayoutControl1
            Me.txtSubTotalIR.TabIndex = 166
            '
            'gridFact
            '
            Me.gridFact.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gridFact.Location = New System.Drawing.Point(12, 116)
            Me.gridFact.MainView = Me.vFacturas
            Me.gridFact.Name = "gridFact"
            Me.gridFact.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbCodigo1, Me.cbCodigo2, Me.txtPrecio, Me.cbCatalogo, Me.rDescuento, Me.cbProyecto})
            Me.gridFact.Size = New System.Drawing.Size(820, 354)
            Me.gridFact.TabIndex = 162
            Me.gridFact.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vFacturas})
            '
            'vFacturas
            '
            Me.vFacturas.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.vFacturas.Appearance.HeaderPanel.Options.UseFont = True
            Me.vFacturas.Appearance.HeaderPanel.Options.UseTextOptions = True
            Me.vFacturas.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.vFacturas.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.vFacturas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13})
            Me.vFacturas.GridControl = Me.gridFact
            Me.vFacturas.Name = "vFacturas"
            Me.vFacturas.OptionsBehavior.Editable = False
            Me.vFacturas.OptionsCustomization.AllowColumnMoving = False
            Me.vFacturas.OptionsCustomization.AllowFilter = False
            Me.vFacturas.OptionsCustomization.AllowGroup = False
            Me.vFacturas.OptionsCustomization.AllowSort = False
            Me.vFacturas.OptionsView.ShowFooter = True
            Me.vFacturas.OptionsView.ShowGroupPanel = False
            '
            'GridColumn1
            '
            Me.GridColumn1.Caption = "Código"
            Me.GridColumn1.FieldName = "Codigo"
            Me.GridColumn1.Name = "GridColumn1"
            Me.GridColumn1.Visible = True
            Me.GridColumn1.VisibleIndex = 0
            Me.GridColumn1.Width = 86
            '
            'GridColumn2
            '
            Me.GridColumn2.Caption = "Descripción"
            Me.GridColumn2.FieldName = "Nombre"
            Me.GridColumn2.Name = "GridColumn2"
            Me.GridColumn2.Visible = True
            Me.GridColumn2.VisibleIndex = 1
            Me.GridColumn2.Width = 198
            '
            'GridColumn3
            '
            Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
            Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.GridColumn3.Caption = "Cantidad"
            Me.GridColumn3.ColumnEdit = Me.txtPrecio
            Me.GridColumn3.FieldName = "Cantidad"
            Me.GridColumn3.Name = "GridColumn3"
            Me.GridColumn3.Visible = True
            Me.GridColumn3.VisibleIndex = 2
            Me.GridColumn3.Width = 72
            '
            'txtPrecio
            '
            Me.txtPrecio.AutoHeight = False
            Me.txtPrecio.Mask.EditMask = "n4"
            Me.txtPrecio.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.txtPrecio.Mask.UseMaskAsDisplayFormat = True
            Me.txtPrecio.Name = "txtPrecio"
            '
            'GridColumn4
            '
            Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
            Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.GridColumn4.Caption = "Costo"
            Me.GridColumn4.ColumnEdit = Me.txtPrecio
            Me.GridColumn4.DisplayFormat.FormatString = "{0:n2}"
            Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn4.FieldName = "Precio"
            Me.GridColumn4.Name = "GridColumn4"
            Me.GridColumn4.Visible = True
            Me.GridColumn4.VisibleIndex = 3
            Me.GridColumn4.Width = 79
            '
            'GridColumn5
            '
            Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
            Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.GridColumn5.Caption = "Descuento %"
            Me.GridColumn5.ColumnEdit = Me.rDescuento
            Me.GridColumn5.FieldName = "Descuento"
            Me.GridColumn5.Name = "GridColumn5"
            Me.GridColumn5.Visible = True
            Me.GridColumn5.VisibleIndex = 4
            Me.GridColumn5.Width = 96
            '
            'rDescuento
            '
            Me.rDescuento.AutoHeight = False
            Me.rDescuento.Mask.EditMask = "P2"
            Me.rDescuento.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.rDescuento.Mask.UseMaskAsDisplayFormat = True
            Me.rDescuento.Name = "rDescuento"
            '
            'GridColumn6
            '
            Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
            Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.GridColumn6.Caption = "Sub Total"
            Me.GridColumn6.ColumnEdit = Me.txtPrecio
            Me.GridColumn6.DisplayFormat.FormatString = "{0:n2}"
            Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn6.FieldName = "SubTotal"
            Me.GridColumn6.Name = "GridColumn6"
            Me.GridColumn6.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SubTotal", "{0:n2}")})
            Me.GridColumn6.Visible = True
            Me.GridColumn6.VisibleIndex = 5
            Me.GridColumn6.Width = 89
            '
            'GridColumn7
            '
            Me.GridColumn7.Caption = "Seleccionar"
            Me.GridColumn7.FieldName = "selecc"
            Me.GridColumn7.Name = "GridColumn7"
            Me.GridColumn7.Width = 101
            '
            'GridColumn8
            '
            Me.GridColumn8.Caption = "IVA"
            Me.GridColumn8.DisplayFormat.FormatString = "{0:n2}"
            Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn8.FieldName = "IVA"
            Me.GridColumn8.Name = "GridColumn8"
            Me.GridColumn8.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IVA", "{0:n2}")})
            '
            'GridColumn9
            '
            Me.GridColumn9.Caption = "Exento"
            Me.GridColumn9.FieldName = "Exento"
            Me.GridColumn9.Name = "GridColumn9"
            '
            'GridColumn10
            '
            Me.GridColumn10.Caption = "Tipo"
            Me.GridColumn10.FieldName = "PIn"
            Me.GridColumn10.Name = "GridColumn10"
            '
            'GridColumn11
            '
            Me.GridColumn11.Caption = "Cuenta"
            Me.GridColumn11.FieldName = "Cuenta"
            Me.GridColumn11.Name = "GridColumn11"
            '
            'GridColumn12
            '
            Me.GridColumn12.Caption = "Proyecto"
            Me.GridColumn12.ColumnEdit = Me.cbProyecto
            Me.GridColumn12.FieldName = "IdProyecto"
            Me.GridColumn12.Name = "GridColumn12"
            Me.GridColumn12.Visible = True
            Me.GridColumn12.VisibleIndex = 6
            Me.GridColumn12.Width = 222
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
            'GridColumn13
            '
            Me.GridColumn13.Caption = "Bodega"
            Me.GridColumn13.FieldName = "Bodega"
            Me.GridColumn13.Name = "GridColumn13"
            Me.GridColumn13.OptionsColumn.AllowEdit = False
            Me.GridColumn13.OptionsColumn.AllowFocus = False
            '
            'cbCodigo1
            '
            Me.cbCodigo1.AutoHeight = False
            EditorButtonImageOptions1.EnableTransparency = False
            Me.cbCodigo1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, True, True, True, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
            Me.cbCodigo1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código")})
            Me.cbCodigo1.Name = "cbCodigo1"
            Me.cbCodigo1.NullText = ""
            Me.cbCodigo1.ShowFooter = False
            Me.cbCodigo1.ShowHeader = False
            '
            'cbCodigo2
            '
            Me.cbCodigo2.AutoHeight = False
            EditorButtonImageOptions2.EnableTransparency = False
            Me.cbCodigo2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, True, True, True, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
            Me.cbCodigo2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Descripción")})
            Me.cbCodigo2.Name = "cbCodigo2"
            Me.cbCodigo2.NullText = ""
            Me.cbCodigo2.ShowFooter = False
            Me.cbCodigo2.ShowHeader = False
            '
            'cbCatalogo
            '
            Me.cbCatalogo.AutoHeight = False
            Me.cbCatalogo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbCatalogo.Name = "cbCatalogo"
            Me.cbCatalogo.NullText = ""
            Me.cbCatalogo.PopupFormMinSize = New System.Drawing.Size(600, 0)
            Me.cbCatalogo.PopupView = Me.vCatalogo
            '
            'vCatalogo
            '
            Me.vCatalogo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.vCatalogo.Name = "vCatalogo"
            Me.vCatalogo.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.vCatalogo.OptionsView.ShowAutoFilterRow = True
            Me.vCatalogo.OptionsView.ShowFooter = True
            Me.vCatalogo.OptionsView.ShowGroupPanel = False
            '
            'dtpFechaPago
            '
            Me.dtpFechaPago.EditValue = Nothing
            Me.dtpFechaPago.Location = New System.Drawing.Point(414, 38)
            Me.dtpFechaPago.Name = "dtpFechaPago"
            Me.dtpFechaPago.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.dtpFechaPago.Properties.Appearance.Options.UseFont = True
            Me.dtpFechaPago.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.dtpFechaPago.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaPago.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.dtpFechaPago.Properties.AppearanceReadOnly.Options.UseFont = True
            Me.dtpFechaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dtpFechaPago.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dtpFechaPago.Properties.ReadOnly = True
            Me.dtpFechaPago.Size = New System.Drawing.Size(135, 20)
            Me.dtpFechaPago.StyleController = Me.LayoutControl1
            Me.dtpFechaPago.TabIndex = 154
            '
            'dFechaEntrada
            '
            Me.dFechaEntrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dFechaEntrada.EditValue = Nothing
            Me.dFechaEntrada.Location = New System.Drawing.Point(144, 64)
            Me.dFechaEntrada.Name = "dFechaEntrada"
            Me.dFechaEntrada.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dFechaEntrada.Properties.Appearance.Options.UseFont = True
            Me.dFechaEntrada.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dFechaEntrada.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.dFechaEntrada.Size = New System.Drawing.Size(134, 22)
            Me.dFechaEntrada.StyleController = Me.LayoutControl1
            Me.dFechaEntrada.TabIndex = 167
            '
            'dtpFecha
            '
            Me.dtpFecha.EditValue = Nothing
            Me.dtpFecha.Location = New System.Drawing.Point(144, 38)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.dtpFecha.Properties.Appearance.Options.UseFont = True
            Me.dtpFecha.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.dtpFecha.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFecha.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.dtpFecha.Properties.AppearanceReadOnly.Options.UseFont = True
            Me.dtpFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dtpFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dtpFecha.Properties.ReadOnly = True
            Me.dtpFecha.Size = New System.Drawing.Size(134, 20)
            Me.dtpFecha.StyleController = Me.LayoutControl1
            Me.dtpFecha.TabIndex = 6
            '
            'cbBodegas
            '
            Me.cbBodegas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbBodegas.Location = New System.Drawing.Point(144, 90)
            Me.cbBodegas.Name = "cbBodegas"
            Me.cbBodegas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbBodegas.Properties.Appearance.Options.UseFont = True
            Me.cbBodegas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbBodegas.Properties.NullText = ""
            Me.cbBodegas.Properties.ShowFooter = False
            Me.cbBodegas.Properties.ShowHeader = False
            Me.cbBodegas.Size = New System.Drawing.Size(584, 22)
            Me.cbBodegas.StyleController = Me.LayoutControl1
            Me.cbBodegas.TabIndex = 168
            Me.cbBodegas.Tag = "True"
            '
            'cbTipoFactura
            '
            Me.cbTipoFactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbTipoFactura.EnterMoveNextControl = True
            Me.cbTipoFactura.Location = New System.Drawing.Point(685, 38)
            Me.cbTipoFactura.Name = "cbTipoFactura"
            Me.cbTipoFactura.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbTipoFactura.Properties.Appearance.Options.UseFont = True
            Me.cbTipoFactura.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Info
            Me.cbTipoFactura.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbTipoFactura.Properties.AppearanceDisabled.Options.UseBackColor = True
            Me.cbTipoFactura.Properties.AppearanceDisabled.Options.UseFont = True
            Me.cbTipoFactura.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cbTipoFactura.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbTipoFactura.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.cbTipoFactura.Properties.AppearanceReadOnly.Options.UseFont = True
            Me.cbTipoFactura.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbTipoFactura.Properties.NullText = ""
            Me.cbTipoFactura.Properties.ReadOnly = True
            Me.cbTipoFactura.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
            Me.cbTipoFactura.Properties.ShowFooter = False
            Me.cbTipoFactura.Properties.ShowHeader = False
            Me.cbTipoFactura.Size = New System.Drawing.Size(147, 20)
            Me.cbTipoFactura.StyleController = Me.LayoutControl1
            Me.cbTipoFactura.TabIndex = 169
            '
            'txtFactura
            '
            Me.txtFactura.Location = New System.Drawing.Point(614, 12)
            Me.txtFactura.Name = "txtFactura"
            Me.txtFactura.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.txtFactura.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFactura.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Crimson
            Me.txtFactura.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.txtFactura.Properties.AppearanceReadOnly.Options.UseFont = True
            Me.txtFactura.Properties.AppearanceReadOnly.Options.UseForeColor = True
            Me.txtFactura.Properties.AppearanceReadOnly.Options.UseTextOptions = True
            Me.txtFactura.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.txtFactura.Properties.ReadOnly = True
            Me.txtFactura.Size = New System.Drawing.Size(218, 22)
            Me.txtFactura.StyleController = Me.LayoutControl1
            Me.txtFactura.TabIndex = 5
            '
            'cbProveedor
            '
            Me.cbProveedor.Location = New System.Drawing.Point(144, 12)
            Me.cbProveedor.Name = "cbProveedor"
            Me.cbProveedor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbProveedor.Properties.Appearance.Options.UseFont = True
            Me.cbProveedor.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cbProveedor.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbProveedor.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.cbProveedor.Properties.AppearanceReadOnly.Options.UseFont = True
            Me.cbProveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbProveedor.Properties.PopupView = Me.SearchLookUpEdit1View
            Me.cbProveedor.Properties.ReadOnly = True
            Me.cbProveedor.Size = New System.Drawing.Size(334, 20)
            Me.cbProveedor.StyleController = Me.LayoutControl1
            Me.cbProveedor.TabIndex = 4
            '
            'SearchLookUpEdit1View
            '
            Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
            Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
            '
            'LayoutControlGroup1
            '
            Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.LayoutControlGroup1.GroupBordersVisible = False
            Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem9, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem17, Me.LayoutControlItem19, Me.EmptySpaceItem2, Me.LayoutControlItem18, Me.LayoutControlItem20, Me.LayoutControlItem5, Me.LayoutControlItem8, Me.LayoutControlItem13})
            Me.LayoutControlGroup1.Name = "Root"
            Me.LayoutControlGroup1.Size = New System.Drawing.Size(844, 508)
            Me.LayoutControlGroup1.TextVisible = False
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.cbProveedor
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(470, 26)
            Me.LayoutControlItem1.Text = "Proveedor:"
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(129, 13)
            '
            'LayoutControlItem2
            '
            Me.LayoutControlItem2.Control = Me.txtFactura
            Me.LayoutControlItem2.Location = New System.Drawing.Point(470, 0)
            Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(354, 26)
            Me.LayoutControlItem2.MinSize = New System.Drawing.Size(354, 26)
            Me.LayoutControlItem2.Name = "LayoutControlItem2"
            Me.LayoutControlItem2.Size = New System.Drawing.Size(354, 26)
            Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem2.Text = "No. Factura:"
            Me.LayoutControlItem2.TextSize = New System.Drawing.Size(129, 13)
            '
            'LayoutControlItem3
            '
            Me.LayoutControlItem3.Control = Me.dtpFecha
            Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 26)
            Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(270, 26)
            Me.LayoutControlItem3.MinSize = New System.Drawing.Size(270, 26)
            Me.LayoutControlItem3.Name = "LayoutControlItem3"
            Me.LayoutControlItem3.Size = New System.Drawing.Size(270, 26)
            Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem3.Text = "Fecha:"
            Me.LayoutControlItem3.TextSize = New System.Drawing.Size(129, 13)
            '
            'LayoutControlItem4
            '
            Me.LayoutControlItem4.Control = Me.dtpFechaPago
            Me.LayoutControlItem4.Location = New System.Drawing.Point(270, 26)
            Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(271, 26)
            Me.LayoutControlItem4.MinSize = New System.Drawing.Size(271, 26)
            Me.LayoutControlItem4.Name = "LayoutControlItem4"
            Me.LayoutControlItem4.Size = New System.Drawing.Size(271, 26)
            Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem4.Text = "Vencimiento:"
            Me.LayoutControlItem4.TextSize = New System.Drawing.Size(129, 13)
            '
            'LayoutControlItem9
            '
            Me.LayoutControlItem9.Control = Me.gridFact
            Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 104)
            Me.LayoutControlItem9.Name = "LayoutControlItem9"
            Me.LayoutControlItem9.Size = New System.Drawing.Size(824, 358)
            Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem9.TextVisible = False
            '
            'LayoutControlItem6
            '
            Me.LayoutControlItem6.Control = Me.cbBodegas
            Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 78)
            Me.LayoutControlItem6.Name = "LayoutControlItem6"
            Me.LayoutControlItem6.Size = New System.Drawing.Size(720, 26)
            Me.LayoutControlItem6.Text = "Bodega:"
            Me.LayoutControlItem6.TextSize = New System.Drawing.Size(129, 13)
            '
            'LayoutControlItem7
            '
            Me.LayoutControlItem7.Control = Me.dFechaEntrada
            Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 52)
            Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(270, 26)
            Me.LayoutControlItem7.MinSize = New System.Drawing.Size(270, 26)
            Me.LayoutControlItem7.Name = "LayoutControlItem7"
            Me.LayoutControlItem7.Size = New System.Drawing.Size(270, 26)
            Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem7.Text = "Fecha de Entrada:"
            Me.LayoutControlItem7.TextSize = New System.Drawing.Size(129, 13)
            '
            'LayoutControlItem17
            '
            Me.LayoutControlItem17.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LayoutControlItem17.AppearanceItemCaption.Options.UseFont = True
            Me.LayoutControlItem17.Control = Me.txtSubTotalIR
            Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 462)
            Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(235, 26)
            Me.LayoutControlItem17.MinSize = New System.Drawing.Size(235, 26)
            Me.LayoutControlItem17.Name = "LayoutControlItem17"
            Me.LayoutControlItem17.Size = New System.Drawing.Size(235, 26)
            Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem17.Text = "Sub Total Retención:"
            Me.LayoutControlItem17.TextSize = New System.Drawing.Size(129, 14)
            '
            'LayoutControlItem19
            '
            Me.LayoutControlItem19.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LayoutControlItem19.AppearanceItemCaption.Options.UseFont = True
            Me.LayoutControlItem19.Control = Me.etSubTotal
            Me.LayoutControlItem19.Location = New System.Drawing.Point(311, 462)
            Me.LayoutControlItem19.Name = "LayoutControlItem19"
            Me.LayoutControlItem19.Size = New System.Drawing.Size(171, 26)
            Me.LayoutControlItem19.Text = "Sub Total:"
            Me.LayoutControlItem19.TextSize = New System.Drawing.Size(129, 14)
            '
            'EmptySpaceItem2
            '
            Me.EmptySpaceItem2.AllowHotTrack = False
            Me.EmptySpaceItem2.Location = New System.Drawing.Point(235, 462)
            Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
            Me.EmptySpaceItem2.Size = New System.Drawing.Size(76, 26)
            Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            '
            'LayoutControlItem18
            '
            Me.LayoutControlItem18.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LayoutControlItem18.AppearanceItemCaption.Options.UseFont = True
            Me.LayoutControlItem18.Control = Me.etIva
            Me.LayoutControlItem18.Location = New System.Drawing.Point(482, 462)
            Me.LayoutControlItem18.Name = "LayoutControlItem18"
            Me.LayoutControlItem18.Size = New System.Drawing.Size(171, 26)
            Me.LayoutControlItem18.Text = "Impuesto:"
            Me.LayoutControlItem18.TextSize = New System.Drawing.Size(129, 14)
            '
            'LayoutControlItem20
            '
            Me.LayoutControlItem20.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LayoutControlItem20.AppearanceItemCaption.Options.UseFont = True
            Me.LayoutControlItem20.Control = Me.etTotal
            Me.LayoutControlItem20.Location = New System.Drawing.Point(653, 462)
            Me.LayoutControlItem20.Name = "LayoutControlItem20"
            Me.LayoutControlItem20.Size = New System.Drawing.Size(171, 26)
            Me.LayoutControlItem20.Text = "Total:"
            Me.LayoutControlItem20.TextSize = New System.Drawing.Size(129, 14)
            '
            'LayoutControlItem5
            '
            Me.LayoutControlItem5.Control = Me.cbTipoFactura
            Me.LayoutControlItem5.Location = New System.Drawing.Point(541, 26)
            Me.LayoutControlItem5.Name = "LayoutControlItem5"
            Me.LayoutControlItem5.Size = New System.Drawing.Size(283, 26)
            Me.LayoutControlItem5.Text = "Forma de Pago:"
            Me.LayoutControlItem5.TextSize = New System.Drawing.Size(129, 13)
            '
            'LayoutControlItem8
            '
            Me.LayoutControlItem8.Control = Me.cbMovimientos
            Me.LayoutControlItem8.Location = New System.Drawing.Point(270, 52)
            Me.LayoutControlItem8.Name = "LayoutControlItem8"
            Me.LayoutControlItem8.Size = New System.Drawing.Size(554, 26)
            Me.LayoutControlItem8.Text = "Tipo de Movimiento:"
            Me.LayoutControlItem8.TextSize = New System.Drawing.Size(129, 13)
            '
            'LayoutControlItem13
            '
            Me.LayoutControlItem13.Control = Me.chkLiquidar
            Me.LayoutControlItem13.Location = New System.Drawing.Point(720, 78)
            Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(104, 26)
            Me.LayoutControlItem13.MinSize = New System.Drawing.Size(104, 26)
            Me.LayoutControlItem13.Name = "LayoutControlItem13"
            Me.LayoutControlItem13.Size = New System.Drawing.Size(104, 26)
            Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem13.TextVisible = False
            '
            'etInicio
            '
            Me.etInicio.BackColor = System.Drawing.Color.Transparent
            Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etInicio.Location = New System.Drawing.Point(12, 402)
            Me.etInicio.Name = "etInicio"
            Me.etInicio.Size = New System.Drawing.Size(109, 25)
            Me.etInicio.TabIndex = 159
            Me.etInicio.Text = "1"
            Me.etInicio.Visible = False
            '
            'cmdAceptar
            '
            Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdAceptar.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdAceptar.Appearance.Options.UseFont = True
            Me.cmdAceptar.Appearance.Options.UseForeColor = True
            Me.cmdAceptar.Appearance.Options.UseTextOptions = True
            Me.cmdAceptar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.cmdAceptar.ImageOptions.Image = CType(resources.GetObject("cmdAceptar.ImageOptions.Image"), System.Drawing.Image)
            Me.cmdAceptar.Location = New System.Drawing.Point(12, 12)
            Me.cmdAceptar.Name = "cmdAceptar"
            Me.cmdAceptar.Size = New System.Drawing.Size(108, 38)
            Me.cmdAceptar.StyleController = Me.LayoutControl2
            Me.cmdAceptar.TabIndex = 28
            Me.cmdAceptar.Text = "&Guardar Entrada"
            '
            'LayoutControl2
            '
            Me.LayoutControl2.Controls.Add(Me.cmdAceptar)
            Me.LayoutControl2.Controls.Add(Me.etInicio)
            Me.LayoutControl2.Controls.Add(Me.cmdConsultaProveedores)
            Me.LayoutControl2.Controls.Add(Me.cmdCancelar)
            Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControl2.Name = "LayoutControl2"
            Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1450, 136, 250, 350)
            Me.LayoutControl2.Root = Me.LayoutControlGroup2
            Me.LayoutControl2.Size = New System.Drawing.Size(133, 479)
            Me.LayoutControl2.TabIndex = 0
            Me.LayoutControl2.Text = "LayoutControl2"
            '
            'cmdConsultaProveedores
            '
            Me.cmdConsultaProveedores.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdConsultaProveedores.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdConsultaProveedores.Appearance.Options.UseFont = True
            Me.cmdConsultaProveedores.Appearance.Options.UseForeColor = True
            Me.cmdConsultaProveedores.ImageOptions.Image = CType(resources.GetObject("cmdConsultaProveedores.ImageOptions.Image"), System.Drawing.Image)
            Me.cmdConsultaProveedores.Location = New System.Drawing.Point(12, 54)
            Me.cmdConsultaProveedores.Name = "cmdConsultaProveedores"
            Me.cmdConsultaProveedores.Size = New System.Drawing.Size(108, 38)
            Me.cmdConsultaProveedores.StyleController = Me.LayoutControl2
            Me.cmdConsultaProveedores.TabIndex = 33
            Me.cmdConsultaProveedores.Text = "Acumulado"
            Me.cmdConsultaProveedores.Visible = False
            '
            'cmdCancelar
            '
            Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdCancelar.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdCancelar.Appearance.Options.UseFont = True
            Me.cmdCancelar.Appearance.Options.UseForeColor = True
            Me.cmdCancelar.ImageOptions.Image = CType(resources.GetObject("cmdCancelar.ImageOptions.Image"), System.Drawing.Image)
            Me.cmdCancelar.Location = New System.Drawing.Point(12, 431)
            Me.cmdCancelar.Name = "cmdCancelar"
            Me.cmdCancelar.Size = New System.Drawing.Size(109, 36)
            Me.cmdCancelar.StyleController = Me.LayoutControl2
            Me.cmdCancelar.TabIndex = 29
            Me.cmdCancelar.Text = "&Salir"
            '
            'LayoutControlGroup2
            '
            Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.LayoutControlGroup2.GroupBordersVisible = False
            Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem10, Me.LayoutControlItem12, Me.EmptySpaceItem1, Me.LayoutControlItem16, Me.LayoutControlItem11})
            Me.LayoutControlGroup2.Name = "Root"
            Me.LayoutControlGroup2.Size = New System.Drawing.Size(133, 479)
            Me.LayoutControlGroup2.TextVisible = False
            '
            'LayoutControlItem10
            '
            Me.LayoutControlItem10.Control = Me.cmdAceptar
            Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(112, 42)
            Me.LayoutControlItem10.MinSize = New System.Drawing.Size(112, 42)
            Me.LayoutControlItem10.Name = "LayoutControlItem10"
            Me.LayoutControlItem10.Size = New System.Drawing.Size(113, 42)
            Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem10.TextVisible = False
            '
            'LayoutControlItem12
            '
            Me.LayoutControlItem12.Control = Me.cmdConsultaProveedores
            Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 42)
            Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(112, 42)
            Me.LayoutControlItem12.MinSize = New System.Drawing.Size(112, 42)
            Me.LayoutControlItem12.Name = "LayoutControlItem12"
            Me.LayoutControlItem12.Size = New System.Drawing.Size(113, 42)
            Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem12.TextVisible = False
            '
            'EmptySpaceItem1
            '
            Me.EmptySpaceItem1.AllowHotTrack = False
            Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 84)
            Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
            Me.EmptySpaceItem1.Size = New System.Drawing.Size(113, 306)
            Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            '
            'LayoutControlItem16
            '
            Me.LayoutControlItem16.Control = Me.etInicio
            Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 390)
            Me.LayoutControlItem16.Name = "LayoutControlItem16"
            Me.LayoutControlItem16.Size = New System.Drawing.Size(113, 29)
            Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem16.TextVisible = False
            Me.LayoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            '
            'LayoutControlItem11
            '
            Me.LayoutControlItem11.Control = Me.cmdCancelar
            Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 419)
            Me.LayoutControlItem11.Name = "LayoutControlItem11"
            Me.LayoutControlItem11.Size = New System.Drawing.Size(113, 40)
            Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem11.TextVisible = False
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
            Me.DockPanel1.ID = New System.Guid("3c976986-8112-4e8a-9c0d-1cccb2cf4eb8")
            Me.DockPanel1.Location = New System.Drawing.Point(844, 0)
            Me.DockPanel1.Name = "DockPanel1"
            Me.DockPanel1.Options.ShowCloseButton = False
            Me.DockPanel1.OriginalSize = New System.Drawing.Size(140, 200)
            Me.DockPanel1.Size = New System.Drawing.Size(140, 508)
            Me.DockPanel1.Text = "Opciones"
            '
            'DockPanel1_Container
            '
            Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
            Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 26)
            Me.DockPanel1_Container.Name = "DockPanel1_Container"
            Me.DockPanel1_Container.Size = New System.Drawing.Size(133, 479)
            Me.DockPanel1_Container.TabIndex = 0
            '
            'frmEntradaAlmacen
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(984, 508)
            Me.Controls.Add(Me.LayoutControl1)
            Me.Controls.Add(Me.DockPanel1)
            Me.Name = "frmEntradaAlmacen"
            CType(Me.cbMovimientos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.LayoutControl1.ResumeLayout(False)
            CType(Me.chkLiquidar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtSubTotalIR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridFact, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.vFacturas, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtPrecio, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rDescuento, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbProyecto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbCodigo1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbCodigo2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.vCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dtpFechaPago.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dtpFechaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dFechaEntrada.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dFechaEntrada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dtpFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbBodegas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbTipoFactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtFactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.LayoutControl2.ResumeLayout(False)
            CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.DockPanel1.ResumeLayout(False)
            Me.DockPanel1_Container.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

#Region "Variables"
        'Dim WithEvents tCust As DataTable
        Private WithEvents myDataSet As DataSet
        Dim DT_FACT As DataTable
        'Dim ds1 As DataSet

        Dim i As Integer
        Dim Tipo As Integer

        'Dim WithEvents Articulo As DataGridComboBoxColumn
        'Dim WithEvents ArticuloCodigo As DataGridComboBoxColumn
        Dim Cantidad As DataGridTextBoxColumn
        Dim Descuento As DataGridTextBoxColumn
        Dim Precio As DataGridTextBoxColumn
        'ArticuloCodigo = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))

        Dim WithEvents ItemTipo As DataGridComboBoxColumn

        Dim ValorActualCantidad As Double
        Dim ValorActualPrecio As Double
        Dim ValorActualDescuento As Double

        Dim Facturas As New VB.SysContab.Facturas_ComprasDB
        Dim FormaPago As New VB.SysContab.Forma_PagoDB
        Dim Proveedores As New VB.SysContab.ProveedoresDB
        Dim DetallesProveedor As New VB.SysContab.ProveedoresDetails
        Dim Articulos As New VB.SysContab.ArticulosDB
        Dim DetallesProducto As New VB.SysContab.ArticulosDetails
        Dim gruposcc As New VB.SysContab.GruposCCDB

        Dim DetallesServicio As New VB.SysContab.ServiciosDetails
        Dim Servicios As New VB.SysContab.ServiciosDB

        Dim r As New VB.SysContab.Rutinas

        Dim OrdenesCompra As New VB.SysContab.Ordenes_ComprasDB
        Dim Bodegas As New VB.SysContab.BodegasDB

        Dim Config As New VB.SysContab.ConfiguracionDB
        Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails

        Dim CargarOrden As Boolean
        Dim OrdenCompra As String

        Public Nuevo As Boolean

        Private myCheckBoxCol As Integer = 8 'my checkbox column 

        Dim dsItems As DataSet

        Public SubTotalParaIVA As Double
#End Region

        Public TipoProd As String
        Dim IvaAsumido As Boolean = False
        Dim IR_Pagado As Boolean = False
        Dim Ir_Serv As Boolean = False
        Dim Ir_Prod As Boolean = False
        Dim Cargando As Boolean = True
        Public IdProveedor As Integer = 0

        Private Sub frmFacturasCompra_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            AddValidation(Me, DxValidationProvider1)

            ConfigDetalles = ConfiguracionDB.GetConfigDetails

            'Me.dtpFecha.Value = r.Fecha
            'Me.dtpFechaPago.Value = r.Fecha
            'Me.dFechaEntrada.DateTime = r.Fecha

            'cbProveedor.DataSource = Proveedores.ProveedoresList(3).Tables("Proveedores")
            'cbProveedor.ValueMember = "Codigo"
            'cbProveedor.DisplayMember = "Nombre"
            'cbProveedor.SelectedIndex = 0
            'cbProveedor.SelectedValue = Me.txtProveedor.Text

            SearchLookUp(cbProveedor, ProveedoresDB.ProveedoresList(1).Tables("Proveedores"), "Nombre", "Codigo")
            cbProveedor.EditValue = IdProveedor

            'cbTipoFactura.DataSource = FormaPago.FormaPagoList().Tables("Forma_Pago")
            'cbTipoFactura.ValueMember = "Codigo"
            'cbTipoFactura.DisplayMember = "Nombre"

            'Me.cbBodegas.DataSource = Bodegas.GetList().Tables("Bodegas")
            'Me.cbBodegas.ValueMember = "CODIGO"
            'Me.cbBodegas.DisplayMember = "UBICACION"
            'Me.cbBodegas.SelectedValue = ConfigDetalles.Bodega

            GetFormaPagoList(cbTipoFactura)

            GetTipoMovimientos(cbMovimientos, 1)
            cbMovimientos.ItemIndex = 0

            'SearchLookUp(cbProyectos, db_Proyectos.Fill(), "Nombre", "IdProyecto", 0, 5, 6)
            'cbProyectos.EditValue = 0
            RepositorySearchLook(cbProyecto, db_Proyectos.Fill(), "Nombre", "IdProyecto", 0, 5, 6, 7, 8)
            GetBodegasList(cbBodegas)
            cbBodegas.EditValue = ConfigDetalles.Bodega

            'cbBodegas.Properties.DataSource = ObtieneDatos("SELECT Codigo_Bodega as Codigo,Codigo_Bodega + ' - ' + Ubicacion as Bodega FROM BODEGAS where empresa = " & EmpresaActual)
            'cbBodegas.Properties.ValueMember = "Codigo"
            'cbBodegas.Properties.DisplayMember = "Bodega"
            'cbBodegas.Properties.PopulateColumns()
            'cbBodegas.Properties.Columns(0).Visible = False
            'cbBodegas.EditValue = ConfigDetalles.Bodega
            'r.ComboAutoComplete(Me.cbProveedor)
            'CargarOrden = False

            'If Me.rbProdInvet.Checked Then
            '    'ds = Facturas.FacturaDetalle(txtFactura.Text, Me.txtProveedor.Text, 3)
            '    DT_FACT = Facturas.FacturaDetalle(txtFactura.Text, Me.txtProveedor.Text, 3).Tables(0)
            'Else
            '    'ds = Facturas.FacturaDetalle(txtFactura.Text, Me.txtProveedor.Text, Me.etDestino.Text)
            '    DT_FACT = Facturas.FacturaDetalle(txtFactura.Text, Me.txtProveedor.Text, Me.etDestino.Text).Tables(0)
            'End If

            DT_FACT = Facturas_ComprasDB.FacturaDetalle(txtFactura.Text, cbProveedor.EditValue, 3).Tables(0)

            If DT_FACT.Rows.Count > 0 Then

                '*Datos de la Factura
                'Me.cbProveedor.SelectedValue = DT_FACT.Rows(0).Item("Proveedor_ID")
                cbTipoFactura.EditValue = DT_FACT.Rows(0).Item("FormaPago_ID")
                dtpFecha.DateTime = DT_FACT.Rows(0).Item("Factura_Fecha")
                dtpFechaPago.DateTime = DT_FACT.Rows(0).Item("Factura_FechaPago")

                '*Obtiene los parametros del iva asumido y del ir
                IvaAsumido = IsNull(DT_FACT.Rows(0).Item("IVA_ASUMIDO"), False)
                IR_Pagado = IsNull(DT_FACT.Rows(0).Item("IR_Pagado"), False)
                Ir_Serv = IsNull(DT_FACT.Rows(0).Item("IR_Serv"), False)
                Ir_Prod = IsNull(DT_FACT.Rows(0).Item("IR_Prod"), False)

                'cbProveedor.Enabled = False
                'txtFactura.ReadOnly = True
                'cbTipoFactura.Enabled = False
                'dtpFecha.Enabled = False
                'dtpFechaPago.Enabled = False

                dFechaEntrada.DateTime = DT_FACT.Rows(0).Item("Factura_Fecha")
                chkLiquidar.Checked = DT_FACT.Rows(0).Item("ALiquidar")

            End If

            gridFact.DataSource = DT_FACT.DefaultView
            FormatoGrid(vFacturas, 2, 0, False, True, False)

            'Mostrar Totales de la Factura
            Totales()

            'GetIVAIR()
            'MakeDataSet()
            'Me.etSubTotal.Text = CDbl(tCust.Compute("Sum(Subtotal)", "")).ToString(Round)
            'Me.etIva.Text = CDbl(tCust.Compute("Sum(IVA)", "")).ToString(Round)
            'Me.etTotal.Text = CDbl(CDbl(Me.etSubTotal.Text) + CDbl(Me.etIva.Text)).ToString(Round)
            'If Me.IvaAsumido Then
            '    Me.SubTotalParaIVA = (tCust.Compute("Sum(Subtotal)", "exiva = 0 ") * ConfigDetalles.IVA / 100) / (1 + (ConfigDetalles.IVA / 100))
            'End If
            'dgFacturas.SetDataBinding(myDataSet, "Articulos")
            'AddCustomDataTableStyle()
            'LeaveCommit = False
            'BuscarCombo = True
            'TipoItem = "P"
            Indice = -1
            Tipo = 0

            'r.ComboAutoComplete(Articulo.ColumnComboBox)
            'r.ComboAutoComplete(ArticuloCodigo.ColumnComboBox)
            'Me.dgFacturas.ReadOnly = True
            'SetTiempos(OrigenComprobantes.ENTRADA_ALMACEN, funciones.Tiempos.TiempoInicio, Now, funciones.Eventos.Inicia, Me.txtFactura.Text)

            'Me.Text = "E n t r a d a  a  A l m a c é n"
            Me.Refresh()
        End Sub

        'Private Sub GetIVAIR()
        '    'Obtiene los parametros del iva asumido y del ir
        '    Try
        '        'Dim DT As DataTable = ObtieneDatos("SELECT Iva_Asumido,IR_Serv,Ir_Prod FROM Facturas_Compras " & _
        '        '           "WHERE Factura_ID = '" & txtFactura.Text & "' AND Proveedor_ID = " & cbProveedor.SelectedValue)

        '        'IvaAsumido = DT.Rows(0).Item("Iva_Asumido")
        '        'Ir_Serv = DT.Rows(0).Item("Ir_Serv")
        '        'Ir_Prod = DT.Rows(0).Item("Ir_Prod")
        '    Catch ex As Exception
        '    End Try
        'End Sub

        Sub Totales()
            'Me.etSubTotal.Text = CDbl(tCust.Compute("Sum(Subtotal)", "")).ToString(Round)
            'Me.etIva.Text = CDbl(tCust.Compute("Sum(IVA)", "")).ToString(Round)
            'Me.etTotal.Text = CDbl(CDbl(Me.etSubTotal.Text) + CDbl(Me.etIva.Text)).ToString(Round)
            'If Me.IvaAsumido Then
            '    Me.SubTotalParaIVA = (tCust.Compute("Sum(Subtotal)", "exiva = 0 ") * ConfigDetalles.IVA / 100) / (1 + (ConfigDetalles.IVA / 100))
            'End If

            Me.etSubTotal.Text = CDbl(Me.vFacturas.Columns("SubTotal").SummaryItem.SummaryValue).ToString(Round)
            Me.etIva.Text = CDbl(Me.vFacturas.Columns("IVA").SummaryItem.SummaryValue).ToString(Round)
            Me.etTotal.Text = CDbl(CDbl(Me.etSubTotal.Text) + CDbl(Me.etIva.Text)).ToString(Round)
            If Me.IvaAsumido Then
                Me.SubTotalParaIVA = (CDbl(Me.vFacturas.Columns("SubTotal").SummaryItem.SummaryValue) * ConfigDetalles.IVA / 100) / (1 + (ConfigDetalles.IVA / 100))
            End If

        End Sub


        Private Sub TextBoxPrecioLeaveHandler(ByVal sender As Object, ByVal e As EventArgs)
            If Not IsNumeric(Precio.TextBox.Text) Then
                Precio.TextBox.Text = ValorActualPrecio.ToString(RoundP)
            Else
                If CDbl(Precio.TextBox.Text) <= 0 Then
                    MsgBox("El Precio debe ser mayor a Cero (0)", MsgBoxStyle.Information)
                    Precio.TextBox.Text = ValorActualPrecio.ToString(RoundP)
                    'Cantidad.TextBox.Focus()
                    Exit Sub
                Else
                    'If Precio.TextBox.Text = "0" Then
                    '    Precio.TextBox.Text = "0.00"
                    'Else
                    Precio.TextBox.Text = CDbl(Precio.TextBox.Text).ToString(RoundP)
                    'End If

                    'Descuento.TextBox.Refresh()
                End If
            End If
        End Sub

        Private Sub TextBoxDescuentoLeaveHandler(ByVal sender As Object, ByVal e As EventArgs)
            If Not IsNumeric(Descuento.TextBox.Text) Then
                Descuento.TextBox.Text = ValorActualDescuento.ToString(Round)
            Else
                If CDbl(Descuento.TextBox.Text) < 0 Then
                    MsgBox("El Descuento debe ser mayor o igual a Cero (0)", MsgBoxStyle.Information)
                    Descuento.TextBox.Text = ValorActualDescuento.ToString(Round)
                    'Cantidad.TextBox.Focus()
                    Exit Sub
                Else
                    If Descuento.TextBox.Text = "0" Then
                        Descuento.TextBox.Text = "0.00"
                    Else
                        Descuento.TextBox.Text = CDbl(Descuento.TextBox.Text).ToString(Round)
                    End If

                    'Descuento.TextBox.Refresh()
                End If
            End If
        End Sub

        Private Sub TextBoxLeaveHandler(ByVal sender As Object, ByVal e As EventArgs)
            ''If Not IsNumeric(Cantidad.TextBox.Text) Then
            ''    Cantidad.TextBox.Text = ValorActualCantidad '.ToString(Round)
            ''Else
            ''    If CDbl(Cantidad.TextBox.Text) <= 0 Then
            ''        MsgBox("La cantidad debe ser mayor que Cero (0)", MsgBoxStyle.Information)
            ''        Cantidad.TextBox.Text = ValorActualCantidad '.ToString(Round)
            ''        'Cantidad.TextBox.Focus()
            ''        Exit Sub
            ''    End If

            ''End If

            ''If dgFacturas.CurrentRowIndex >= tCust.Rows.Count Then
            ''    Exit Sub
            ''End If

            ''If tCust.Rows(dgFacturas.CurrentRowIndex)("ArticuloCodigo").ToString = "" Or tCust.Rows(dgFacturas.CurrentRowIndex)("ArticuloCodigo") Is DBNull.Value Then
            ''    Exit Sub
            ''End If

            ''If TipoItem = "S" Then
            ''    Exit Sub
            ''ElseIf TipoItem = "A" Then
            ''    If tCust.Rows(dgFacturas.CurrentRowIndex)("Tipo").ToString = "S" Then
            ''        Exit Sub
            ''    End If
            ''End If

            'DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(tCust.Rows(dgFacturas.CurrentRowIndex)("ArticuloCodigo"), tCust.Rows(dgFacturas.CurrentRowIndex)("Tipo"), EmpresaActual)
            'If DetallesProducto.Existencia Is Nothing Or DetallesProducto.Existencia Is DBNull.Value Then
            '    '
            'ElseIf DetallesProducto.Existencia = 0 Then
            '    MsgBox("No hay existencias...", MsgBoxStyle.Critical)
            '    Cantidad.TextBox.Focus()
            '    Exit Sub
            'ElseIf CDbl(Cantidad.TextBox.Text) > CDbl(DetallesProducto.Existencia) Then
            '    MsgBox("La cantidad es mayor que la existencia actual", MsgBoxStyle.Critical)
            '    Exit Sub
            'End If

        End Sub

        Dim Servicio As Boolean

        Private Sub Evento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
            'If rbAmbos.Checked = False Then
            '    Exit Sub
            'End If

            'Dim dsItems As DataSet

            'If e.KeyCode = Keys.F9 Then

            '    If Servicio = True Then
            '        Exit Sub
            '    End If

            '    Servicio = True

            '    dsItems = Articulos.ProductosGetAll("S")

            '    ArticuloCodigo.ColumnComboBox.Items.Clear()
            '    Articulo.ColumnComboBox.Items.Clear()
            '    ItemTipo.ColumnComboBox.Items.Clear()

            '    For i = 0 To dsItems.Tables("Articulos").Rows.Count - 1
            '        ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Codigo"))
            '        Articulo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Nombre"))
            '        ItemTipo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Tipo"))

            '    Next

            'ElseIf e.KeyCode = Keys.F10 Then

            '    If Servicio = False Then
            '        Exit Sub
            '    End If

            '    Servicio = False

            '    dsItems = Articulos.ProductosGetAll("P")

            '    ArticuloCodigo.ColumnComboBox.Items.Clear()
            '    Articulo.ColumnComboBox.Items.Clear()
            '    ItemTipo.ColumnComboBox.Items.Clear()

            '    For i = 0 To dsItems.Tables("Articulos").Rows.Count - 1
            '        ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Codigo"))
            '        Articulo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Nombre"))
            '        ItemTipo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Tipo"))

            '    Next

            'End If

        End Sub

        Private Sub HandleBoolChanges(ByVal sender As Object, ByVal e As DataGridCheckBoxChangeEvent.BoolValueChangedEventArgs)
            Dim s As String
            s = System.String.Format("Bool Changes: row {0}, col {1}   value {2}", e.Row, e.Column, e.BoolValue)
            Console.WriteLine(s)
        End Sub

        Private Sub AddCustomDataTableStyle()

            ' ''STEP 1: Create a DataTable style object and set properties if required.
            ''Dim ts1 As DataGridTableStyle
            ''ts1 = New DataGridTableStyle
            ' ''specify the table from dataset (required step)
            ''ts1.MappingName = "Articulos"
            ' '' Set other properties (optional step)
            ''ts1.AlternatingBackColor = Color.LightBlue
            ''Dim colCount As Integer
            ''colCount = 0


            ''Dim ArticuloCodigo As DataGridTextBoxColumn
            ' ''ArticuloCodigo = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))
            ''ArticuloCodigo = New DataGridTextBoxColumn
            ''ArticuloCodigo.MappingName = "ArticuloCodigo"
            ''ArticuloCodigo.HeaderText = "Código"
            ''ArticuloCodigo.Width = 100
            ''ArticuloCodigo.ReadOnly = True

            ' ''AddHandler ArticuloCodigo.ColumnComboBox.KeyDown, AddressOf Evento_KeyPress

            ''ts1.GridColumnStyles.Add(ArticuloCodigo)
            ' ''ts1.PreferredRowHeight = (ArticuloCodigo.ColumnCombo.Height + 3)
            ''ts1.PreferredRowHeight = (ArticuloCodigo.TextBox.Height + 3)

            ''ArticuloCodigo.NullText = ""

            ''colCount = (colCount + 1)

            ''Dim Articulo As DataGridTextBoxColumn
            ''Articulo = New DataGridTextBoxColumn
            ''Articulo.MappingName = "Articulo"
            ''Articulo.HeaderText = "Descripción"
            ''Articulo.Width = 300
            ''Articulo.ReadOnly = True

            ' ''AddHandler Articulo.ColumnComboBox.KeyDown, AddressOf Evento_KeyPress

            ''ts1.GridColumnStyles.Add(Articulo)
            ''ts1.PreferredRowHeight = (Articulo.TextBox.Height + 3)

            ''Articulo.NullText = ""
            ''colCount = (colCount + 1)


            ' ''*********************************************************************
            ' ''Agregado by Jhonny Arauz
            ''Dim PIn As DataGridTextBoxColumn
            ''PIn = New DataGridTextBoxColumn
            ''PIn.MappingName = "PIn"
            ''PIn.HeaderText = "P/I"
            ''PIn.Width = 0
            ''PIn.ReadOnly = True

            ''ts1.GridColumnStyles.Add(PIn)
            ''colCount = (colCount + 1)
            ''PIn.NullText = ""
            ' ''*********************************************************************


            ' ''Dim Cantidad As DataGridTextBoxColumn
            ''Cantidad = New DataGridTextBoxColumn
            ''Cantidad.MappingName = "Cantidad"
            ' ''from dataset table
            ''Cantidad.HeaderText = "Cantidad"
            ' ''Cantidad.Format = "d3"
            ''Cantidad.Width = 75
            ''Cantidad.Alignment = HorizontalAlignment.Right
            ''Cantidad.ReadOnly = False

            ''AddHandler Cantidad.TextBox.Leave, New EventHandler(AddressOf TextBoxLeaveHandler)
            ''AddHandler Cantidad.TextBox.KeyDown, AddressOf Evento_KeyPress

            ''ts1.GridColumnStyles.Add(Cantidad)
            ''colCount = (colCount + 1)

            ''Cantidad.NullText = ""

            ' ''Dim Precio As DataGridTextBoxColumn
            ''Precio = New DataGridTextBoxColumn
            ''Precio.MappingName = "Precio"
            ''Precio.HeaderText = "Precio"
            ''Precio.Width = 95
            ''Precio.Alignment = HorizontalAlignment.Right
            ''Precio.ReadOnly = True
            ''Precio.Format = "##,###0.00"

            ''AddHandler Precio.TextBox.Leave, New EventHandler(AddressOf TextBoxPrecioLeaveHandler)

            ' ''AddHandler Precio.TextBox.KeyPress, New EventHandler(AddressOf TextBoxPrecioKeyPressHandler)

            ''ts1.GridColumnStyles.Add(Precio)
            ''colCount = (colCount + 1)

            ''Precio.NullText = (0).ToString(RoundP)

            ' ''Dim Descuento As DataGridTextBoxColumn
            ''Descuento = New DataGridTextBoxColumn
            ''Descuento.MappingName = "Descuento"
            ''Descuento.HeaderText = "Descuento %"
            ''Descuento.Width = 95
            ''Descuento.Alignment = HorizontalAlignment.Right
            ''Descuento.ReadOnly = True
            ''Descuento.Format = "##,###0.00"

            ''AddHandler Descuento.TextBox.Leave, New EventHandler(AddressOf TextBoxDescuentoLeaveHandler)

            ''ts1.GridColumnStyles.Add(Descuento)
            ''colCount = (colCount + 1)

            ''Descuento.NullText = "0"

            ''Dim SubTotal As DataGridTextBoxColumn
            ''SubTotal = New DataGridTextBoxColumn
            ''SubTotal.MappingName = "SubTotal"
            ''SubTotal.HeaderText = "Sub Total"
            ''SubTotal.Width = 100
            ''SubTotal.Alignment = HorizontalAlignment.Right
            ''SubTotal.ReadOnly = True
            ''SubTotal.Format = "##,###0.00"
            ''ts1.GridColumnStyles.Add(SubTotal)
            ''colCount = (colCount + 1)

            ''SubTotal.NullText = (0).ToString(Round)

            ''Dim CodigoTemporal As DataGridTextBoxColumn
            ''CodigoTemporal = New DataGridTextBoxColumn
            ''CodigoTemporal.MappingName = "CodigoTemporal"
            ''CodigoTemporal.HeaderText = "CodigoTemporal"
            ''CodigoTemporal.Width = 0
            ''CodigoTemporal.Alignment = HorizontalAlignment.Left
            ''CodigoTemporal.ReadOnly = True
            ' ''CodigoTemporal.Format = "##,###0.00"
            ''ts1.GridColumnStyles.Add(CodigoTemporal)
            ''colCount = (colCount + 1)

            ''CodigoTemporal.NullText = ""

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''''Tipo = P: Producto S: Servicio'''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            ''ItemTipo = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))
            ''ItemTipo.MappingName = "Tipo"
            ''ItemTipo.HeaderText = "Tipo"
            ''ItemTipo.Width = 0
            ''ItemTipo.ReadOnly = True

            ''ts1.GridColumnStyles.Add(ItemTipo)
            ''ts1.PreferredRowHeight = (ItemTipo.ColumnComboBox.Height + 3)

            ''ItemTipo.NullText = ""

            ' ''dsItems = Articulos.ProductosGetAll("P")

            ' ''For i = 0 To dsItems.Tables("Articulos").Rows.Count - 1
            ' ''    ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Codigo"))
            ' ''    Articulo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Nombre"))
            ' ''    ItemTipo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Tipo"))
            ' ''Next

            ' ''ItemTipo.ColumnComboBox.DropDownStyle = ComboBoxStyle.DropDown
            ' ''ItemTipo.ColumnComboBox.SelectedValue = -1

            ' ''ArticuloCodigo.ColumnComboBox.DropDownStyle = ComboBoxStyle.DropDown
            ' ''ArticuloCodigo.ColumnComboBox.SelectedValue = -1

            ' ''Articulo.ColumnComboBox.DropDownStyle = ComboBoxStyle.DropDown
            ' ''Articulo.ColumnComboBox.SelectedValue = -1


            ''colCount = (colCount + 1)

            ''Dim boolCol As DataGridCheckBoxChangeEvent.MyDataGridBoolColumn
            ''boolCol = New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn(colCount)
            ''boolCol.MappingName = "Agregar"
            ''boolCol.HeaderText = "Seleccionar"
            ''boolCol.Alignment = HorizontalAlignment.Center
            ' ''uncomment this line to get a two-state checkbox
            ''CType(boolCol, DataGridBoolColumn).AllowNull = False

            ''boolCol.Width = 70
            ''boolCol.ReadOnly = False

            ''boolCol.NullText = ""

            ' ''hook the new event to our handler in the grid
            ''AddHandler boolCol.BoolValueChanged, New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn.BoolValueChangedEventHandler(AddressOf HandleBoolChanges)

            ''ts1.GridColumnStyles.Add(boolCol)
            ''colCount = (colCount + 1)

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            ' ''STEP 6: Add the tablestyle to your datagrids tablestlye collection

            ''ts1.GridLineColor = Color.FromArgb(70, 130, 180)
            ''ts1.AllowSorting = False
            ''ts1.HeaderFont = dgFacturas.HeaderFont
            ''ts1.HeaderBackColor = Color.LightSteelBlue  'Color.LightBlue

            ''dgFacturas.CaptionVisible = False
            ''dgFacturas.TableStyles.Clear()
            ''dgFacturas.TableStyles.Add(ts1)
        End Sub

        Public Sub MyComboValueChanged(ByVal rowChanging As Integer, ByVal newValue As Object)
            'Console.WriteLine("index changed {0} {1}", rowChanging, newValue)

            'If Indice = 0 Then
            '    Dim f As New frmAgregarArticuloQuick()
            '    f.WindowState = FormWindowState.Normal
            '    f.StartPosition = FormStartPosition.CenterScreen
            '    f.etTipo.Text = "P"
            '    f.ShowDialog()

            '    dsItems = Articulos.ProductosGetAll("P")

            '    ArticuloCodigo.ColumnComboBox.Items.Clear()
            '    Articulo.ColumnComboBox.Items.Clear()
            '    ItemTipo.ColumnComboBox.Items.Clear()

            '    For i = 0 To dsItems.Tables("Articulos").Rows.Count - 1
            '        ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Codigo"))
            '        Articulo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Nombre"))
            '        ItemTipo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Tipo"))
            '    Next

            '    Exit Sub
            'End If

            'Try
            '    If Indice >= 0 Then
            '        DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(ArticuloCodigo.ColumnComboBox.Items.Item(Indice).ToString, ItemTipo.ColumnComboBox.Items.Item(Indice).ToString, EmpresaActual)

            '        If tCust.Rows.Count < rowChanging + 1 Then
            '            Dim newRow1 As DataRow
            '            newRow1 = tCust.NewRow
            '            newRow1("CodigoTemporal") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
            '            tCust.Rows.Add(newRow1)

            '            tCust.Rows(rowChanging)("ArticuloCodigo") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
            '            tCust.Rows(rowChanging)("Articulo") = Articulo.ColumnComboBox.Items.Item(Indice)
            '            tCust.Rows(rowChanging)("Cantidad") = 1
            '            tCust.Rows(rowChanging)("Precio") = CDbl(DetallesProducto.Costo).ToString(Round)
            '            tCust.Rows(rowChanging)("Agregar") = True

            '            tCust.Rows(rowChanging)("Tipo") = ItemTipo.ColumnComboBox.Items.Item(Indice)
            '        Else
            '            tCust.Rows(rowChanging)("CodigoTemporal") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
            '            tCust.Rows(rowChanging)("ArticuloCodigo") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
            '            tCust.Rows(rowChanging)("Articulo") = Articulo.ColumnComboBox.Items.Item(Indice)

            '            tCust.Rows(rowChanging)("Precio") = CDbl(DetallesProducto.Costo).ToString(Round)
            '            tCust.Rows(rowChanging)("Agregar") = True

            '            tCust.Rows(rowChanging)("Tipo") = ItemTipo.ColumnComboBox.Items.Item(Indice)
            '        End If

            '    End If
            'Catch ex As Exception
            '    MsgBox(ex.Message & "MyComboValueChanged")
            'End Try

        End Sub

        'Private Sub tCust_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles tCust.ColumnChanged

        '    '' ''Se agrego esto por la tardanza 15042008 RMPR
        '    ''If Not Cargando Then
        '    ''    '----------------
        '    ''    Dim Descuento As Double
        '    ''    If e.Column.Ordinal = 2 Or e.Column.Ordinal = 3 Or e.Column.Ordinal = 4 Then
        '    ''        If Not IsNumeric(e.Row.Item(2)) Then
        '    ''            e.Row.Item(2) = ValorActualCantidad
        '    ''        End If

        '    ''        If Not IsNumeric(e.Row.Item(3)) Then
        '    ''            e.Row.Item(3) = ValorActualPrecio.ToString(RoundP)
        '    ''        End If

        '    ''        If Not IsNumeric(e.Row.Item(4)) Then
        '    ''            e.Row.Item(4) = ValorActualDescuento.ToString(Round)
        '    ''        End If

        '    ''        If Not (e.Row.Item(2) Is DBNull.Value Or e.Row.Item(3) Is DBNull.Value) Then
        '    ''            If e.Row.Item(4) Is DBNull.Value Then
        '    ''                If IsNumeric(e.Row.Item(2)) And IsNumeric(e.Row.Item(3)) Then
        '    ''                    e.Row.Item(5) = CDbl(CDbl(e.Row.Item(2)) * CDbl(e.Row.Item(3))).ToString(Round)
        '    ''                    e.Row.Item(9) = CDbl(e.Row.Item(5) * IIf(e.Row.Item(10) = True, 0, ConfigDetalles.IVA / 100.0)).ToString(Round)
        '    ''                End If
        '    ''            Else
        '    ''                If IsNumeric(e.Row.Item(2)) And IsNumeric(e.Row.Item(3)) And IsNumeric(e.Row.Item(4)) Then
        '    ''                    Descuento = (CDbl(e.Row.Item(4)) * CDbl(e.Row.Item(2)) * CDbl(e.Row.Item(3))) / 100.0
        '    ''                    e.Row.Item(5) = CDbl(CDbl(e.Row.Item(2)) * CDbl(e.Row.Item(3)) - Descuento).ToString(Round)
        '    ''                    e.Row.Item(9) = CDbl(e.Row.Item(5) * IIf(e.Row.Item(10) = True, 0, ConfigDetalles.IVA / 100.0)).ToString(Round)
        '    ''                End If
        '    ''            End If
        '    ''        End If
        '    ''    End If
        '    ''End If

        '    'SubTotalFacturaCliente = 0
        '    'SubTotalFacturaNoDescuentos = 0
        '    'TotalFacturaCliente = 0
        '    'TotalDescuento = 0

        '    'SubTotalParaIVA = 0


        '    'If Me.rbProductos.Checked Then
        '    '    Me.TipoProd = "P"
        '    'End If

        '    'If Me.rbServicios.Checked Then
        '    '    Me.TipoProd = "S"
        '    'End If

        '    'If rbInventario.Checked Then
        '    '    Me.TipoProd = "P"
        '    'End If


        '    'For i = 0 To tCust.Rows.Count - 1

        '    '    If tCust.Rows(i)("SubTotal") Is DBNull.Value Or tCust.Rows(i)("SubTotal").ToString = "" Or tCust.Rows(i)("SubTotal").ToString = "0.00" Then

        '    '    ElseIf IsNumeric(tCust.Rows(i)("SubTotal")) And tCust.Rows(i)("SubTotal").ToString <> "" Then
        '    '        Try
        '    '            SubTotalFacturaCliente = SubTotalFacturaCliente + tCust.Rows(i)("SubTotal")

        '    '            Dim Det As VB.SysContab.ArticulosDetails = VB.SysContab.ArticulosDB.GetDetails(tCust.Rows(i)("ArticuloCodigo").ToString, TipoProd, EmpresaActual)


        '    '            If Det.Exento = "False" Then
        '    '                SubTotalParaIVA = SubTotalParaIVA + tCust.Rows(i)("IVA") 'Se quito el 15042008 RMPR '(tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio"))
        '    '            End If


        '    '            SubTotalFacturaNoDescuentos = SubTotalFacturaNoDescuentos + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio"))
        '    '            TotalDescuento = TotalDescuento + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio") * tCust.Rows(i)("Descuento") / 100)
        '    '        Catch ex As Exception
        '    '            MsgBox(ex.Message)

        '    '        End Try

        '    '    End If

        '    'Next


        '    'If IvaAsumido = True Then

        '    '    etSubTotal.Text = CDbl(SubTotalFacturaCliente + SubTotalParaIVA).ToString(Round) 'Se quito el 15042008 RMPR '* (ConfigDetalles.IVA / 100.0)).ToString(Round)
        '    '    'etSubTotal.Text = CDbl(SubTotalFacturaNoDescuentos + SubTotalParaIVA * (ConfigDetalles.IVA / 100.0)).ToString(Round)

        '    '    etIva.Text = SubTotalParaIVA '(SubTotalFacturaCliente * (ConfigDetalles.IVA / 100.0)).ToString(Round)
        '    '    'etIva.Text = CDbl(0.0).ToString(Round)

        '    '    etTotal.Text = (SubTotalFacturaCliente + SubTotalParaIVA).ToString(Round)  ' se quito el 15042008 rmpr * (ConfigDetalles.IVA / 100.0)).ToString(Round)).ToString(Round)

        '    '    TotalFactura = etTotal.Text


        '    'Else

        '    '    etSubTotal.Text = SubTotalFacturaCliente.ToString(Round)
        '    '    'etSubTotal.Text = SubTotalFacturaNoDescuentos.ToString(Round)
        '    '    ''Ver si el proveedor no es recardaudor del IVA.

        '    '    'If VB.SysContab.ProveedoresDB.GetDetails(Me.cbProveedor.SelectedValue).Retenedor Then


        '    '    etIva.Text = SubTotalParaIVA '(SubTotalFacturaCliente * (ConfigDetalles.IVA / 100.0)).ToString(Round)
        '    '    'etIva.Text = (SubTotalParaIVA * (ConfigDetalles.IVA / 100.0)).ToString(Round)

        '    '    'Else

        '    '    '    etIva.Text = "0.0"
        '    '    'End If

        '    '    etTotal.Text = (SubTotalFacturaCliente + CDbl(etIva.Text)).ToString(Round)
        '    '    TotalFactura = etTotal.Text

        '    'End If

        'End Sub

        'Private Sub tCust_RowDeleted(ByVal sender As Object, ByVal e As System.Data.DataRowChangeEventArgs) Handles tCust.RowDeleted
        '    SubTotalFacturaCliente = 0
        '    SubTotalFacturaNoDescuentos = 0
        '    TotalFacturaCliente = 0
        '    TotalDescuento = 0

        '    For i = 0 To tCust.Rows.Count - 1
        '        'If e.Row.Item(5) Is DBNull.Value Or e.Row.Item(5).ToString = "" Or e.Row.Item(5).ToString = "0.00" Then

        '        'ElseIf IsNumeric(e.Row.Item(5)) And e.Row.Item(5).ToString <> "" Then
        '        '    Try 'MsgBox(tCust.Rows(i)("SubTotal").ToString)
        '        '        SubTotalFacturaCliente = SubTotalFacturaCliente + tCust.Rows(i)("SubTotal")
        '        '    Catch
        '        '        'e.Row.Delete()
        '        '    End Try

        '        'End If

        '        If tCust.Rows(i)("SubTotal") Is DBNull.Value Or tCust.Rows(i)("SubTotal").ToString = "" Or tCust.Rows(i)("SubTotal").ToString = "0.00" Then

        '        ElseIf IsNumeric(tCust.Rows(i)("SubTotal")) And tCust.Rows(i)("SubTotal").ToString <> "" Then
        '            Try 'MsgBox(tCust.Rows(i)("SubTotal").ToString)
        '                SubTotalFacturaCliente = SubTotalFacturaCliente + tCust.Rows(i)("SubTotal")
        '                SubTotalFacturaNoDescuentos = SubTotalFacturaNoDescuentos + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio"))
        '                TotalDescuento = TotalDescuento + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio") * tCust.Rows(i)("Descuento") / 100)
        '            Catch ex As Exception
        '                MsgBox(ex.Message)
        '                'e.Row.Delete()
        '            End Try

        '        End If

        '    Next

        '    etSubTotal.Text = SubTotalFacturaCliente.ToString(Round)
        '    'etSubTotal.Text = SubTotalFacturaNoDescuentos.ToString(Round)
        '    If VB.SysContab.ProveedoresDB.GetDetails(Me.cbProveedor.SelectedValue).Retenedor Then
        '        etIva.Text = (SubTotalFacturaCliente * (ConfigDetalles.IVA / 100.0)).ToString(Round)
        '        'etIva.Text = (SubTotalFacturaNoDescuentos * (ConfigDetalles.IVA / 100.0)).ToString(Round)
        '    Else
        '        etIva.Text = "0.00"
        '    End If
        '    etTotal.Text = (SubTotalFacturaCliente + CDbl(etIva.Text)).ToString(Round)
        '    TotalFactura = CDbl(etTotal.Text).ToString(Round)

        'End Sub

        Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

            If Not DxValidationProvider1.Validate() Then Exit Sub

            'Dim i, j, x As Integer
            ''Dim Cuentas As Array = Array.CreateInstance(GetType(System.String), tCust.Rows.Count, 2)
            'Dim Cuentas(Me.vFacturas.DataRowCount) As String
            'Dim Montos(Me.vFacturas.DataRowCount) As Double
            'Dim Fact As New VB.SysContab.Facturas_ComprasDB
            'Dim DsFact As New DataSet

            'Dim Destino As Integer

            'If Me.rbInventario.Checked Then
            '    Destino = 2
            'Else
            '    Destino = 1
            'End If

            'If Me.rbProdInvet.Checked Then  'Si la Factura Contiene Productos e Inventario
            '    DsFact = Fact.FacturaDetalle(Me.txtFactura.Text, cbProveedor.SelectedValue, 3)
            'Else
            '    DsFact = Fact.FacturaDetalle(Me.txtFactura.Text, cbProveedor.SelectedValue, Destino)
            'End If

            'Dim IRAlcaldiaPAgado As Boolean

            'If DsFact.Tables(0).Rows.Count > 0 Then
            '    IRAlcaldiaPAgado = IsNull(DsFact.Tables(0).Rows(0).Item("ir_pagado_alcaldia"), 0)
            'End If

            'DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            'DBConnFacturas.Open()
            'transaccionFacturas = DBConnFacturas.BeginTransaction



            Try
                'Guardar los datos de la Factura
                'x = 0
                ''Si es de productos
                'If Me.rbProductos.Checked Then
                '    For i = 0 To Me.vFacturas.DataRowCount - 1 'tCust.Rows.Count - 1
                '        DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(Me.vFacturas.GetRowCellValue(i, "Codigo"), "P", EmpresaActual)

                '        If DetallesProducto.Cuenta = "" Or DetallesProducto.Cuenta = "0" Then
                '            MsgBox("No se puede contabilizar la entrada a almacen de la factura, porque no hay cuenta contable para el producto: " & DetallesProducto.Nombre, MsgBoxStyle.Critical, "STS-Contab")
                '            Exit Sub
                '        Else
                '            j = Cuentas.IndexOf(Cuentas, DetallesProducto.Cuenta)
                '            'Si no encuentra la cuenta contable en el arreglo, la adiciona

                '            If j = -1 Then
                '                Cuentas(x) = DetallesProducto.Cuenta
                '                Montos(x) = Me.vFacturas.GetRowCellValue(i, "SubTotal")
                '                x += 1
                '            Else
                '                Montos(j) = Montos(j) + Me.vFacturas.GetRowCellValue(i, "SubTotal")
                '            End If
                '        End If
                '    Next
                'ElseIf Me.rbInventario.Checked Then
                '    Dim rds As New DataSet
                '    For i = 0 To Me.vFacturas.DataRowCount - 1 ' tCust.Rows.Count - 1
                '        rds = gruposcc.ArticulosCCDetalles(Me.vFacturas.GetRowCellValue(i, "Codigo"))

                '        If rds.Tables(0).Rows(0)("Cuenta") = "" Or rds.Tables(0).Rows(0)("Cuenta") = "0" Then
                '            MsgBox("No se puede contabilizar la entrada a almacen de la factura, porque no hay cuenta contable para el producto: " & Me.vFacturas.GetRowCellValue(i, "Nombre"), MsgBoxStyle.Critical, "STS-Contab")
                '            Exit Sub
                '        Else
                '            j = Cuentas.IndexOf(Cuentas, Me.vFacturas.GetRowCellValue(i, "Cuenta"))
                '            'Si no encuentra la cuenta contable en el arreglo, la adiciona
                '            If j = -1 Then
                '                Cuentas(x) = Me.vFacturas.GetRowCellValue(i, "Cuenta")
                '                Montos(x) = Me.vFacturas.GetRowCellValue(i, "SubTotal")
                '                x += 1
                '            Else
                '                Montos(j) = Montos(j) + Me.vFacturas.GetRowCellValue(i, "SubTotal")
                '            End If
                '        End If
                '    Next
                '    'ElseIf Me.rbServicios.Checked Then
                '    '    Dim rds As New DataSet
                '    '    For i = 0 To tCust.Rows.Count - 1
                '    '        DetallesServicio = Servicios.GetDetails(Me.vFacturas.GetRowCellValue(i, "Codigo"), "S", "P")
                '    '        If DetallesServicio.Cuenta = "" Or DetallesServicio.Cuenta = "0" Then
                '    '            MsgBox("No se puede contabilizar la entrada a almacen de la factura, porque no hay cuenta contable para el servicio: " & DetallesServicio.Nombre, MsgBoxStyle.Critical, "STS-Contab")
                '    '            Exit Sub
                '    '        Else
                '    '            j = Cuentas.IndexOf(Cuentas, DetallesServicio.Cuenta)
                '    '            'Si no encuentra la cuenta contable en el arreglo, la adiciona
                '    '            If j = -1 Then
                '    '                Cuentas(x) = DetallesServicio.Cuenta
                '    '                Montos(x) = tCust.Rows(i)("SubTotal")
                '    '                x += 1
                '    '            Else
                '    '                Montos(j) = Montos(j) + tCust.Rows(i)("SubTotal")
                '    '            End If
                '    '        End If
                '    '    Next


                '    '******************************************************************************
                '    'Agregado y Modificado by Jhonny Arauz
                'ElseIf Me.rbProdInvet.Checked Then  ' Para Producto e Inventario
                '    Dim rds As New DataSet
                '    For i = 0 To Me.vFacturas.DataRowCount - 1 'tCust.Rows.Count - 1
                '        If Me.vFacturas.GetRowCellValue(i, "PIn") = "P" Then
                '            DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(Me.vFacturas.GetRowCellValue(i, "Codigo"), "P", EmpresaActual)
                '            If DetallesProducto.Cuenta = "" Or DetallesProducto.Cuenta = "0" Then
                '                MsgBox("No se puede contabilizar la entrada a almacen de la factura, porque no hay cuenta contable para el producto: " & DetallesProducto.Nombre, MsgBoxStyle.Critical, "STS-Contab")
                '                Exit Sub
                '            Else
                '                j = Cuentas.IndexOf(Cuentas, DetallesProducto.Cuenta)
                '                'Si no encuentra la cuenta contable en el arreglo, la adiciona
                '                If j = -1 Then
                '                    Cuentas(x) = DetallesProducto.Cuenta
                '                    Montos(x) = Me.vFacturas.GetRowCellValue(i, "SubTotal")
                '                    x += 1
                '                Else
                '                    Montos(j) = Montos(j) + Me.vFacturas.GetRowCellValue(i, "SubTotal")
                '                End If
                '            End If
                '        ElseIf Me.vFacturas.GetRowCellValue(i, "PIn") = "I" Then
                '            rds = gruposcc.ArticulosCCDetalles(Me.vFacturas.GetRowCellValue(i, "Codigo"))

                '            If rds.Tables(0).Rows(0)("Cuenta") = "" Or rds.Tables(0).Rows(0)("Cuenta") = "0" Then
                '                MsgBox("No se puede contabilizar la entrada a almacen de la factura, porque no hay cuenta contable para el producto: " & Me.vFacturas.GetRowCellValue(i, "Nombre"), MsgBoxStyle.Critical, "STS-Contab")
                '                Exit Sub
                '            Else
                '                j = Cuentas.IndexOf(Cuentas, Me.vFacturas.GetRowCellValue(i, "Cuenta"))
                '                'Si no encuentra la cuenta contable en el arreglo, la adiciona
                '                If j = -1 Then
                '                    Cuentas(x) = Me.vFacturas.GetRowCellValue(i, "Cuenta")
                '                    Montos(x) = Me.vFacturas.GetRowCellValue(i, "SubTotal")
                '                    x += 1
                '                Else
                '                    Montos(j) = Montos(j) + Me.vFacturas.GetRowCellValue(i, "SubTotal")
                '                End If
                '            End If
                '        End If
                '    Next
                'End If
                ''******************************************************************************

                'DetallesProveedor = VB.SysContab.ProveedoresDB.GetDetails(Me.cbProveedor.SelectedValue)

                'If DetallesProveedor.Cuenta.Trim = "" Then
                '    MsgBox("No se puede contabilizar la entrada a almacen de la factura, porque no hay cuenta contable para el proveedor: " & DetallesProveedor.Nombre, MsgBoxStyle.Critical, "STS-Contab")
                '    Exit Sub
                'End If

                If Guardar() = False Then
                    Exit Sub
                End If

                Close()

                'If Contabilizar(Cuentas, Montos, IRAlcaldiaPAgado) = False Then
                '    VB.SysContab.Rutinas.ErrorTransaccion()
                '    Exit Sub
                'End If

                ' VB.SysContab.Rutinas.okTransaccion()
                ' SetTiempos(OrigenComprobantes.ENTRADA_ALMACEN, funciones.Tiempos.TiempoFin, Now, funciones.Eventos.Guarda, Me.txtFactura.Text)

                'If Me.Nuevo = False Then
                '    Me.Close()
                'End If

                'LimpiarControles()
                'CargarOrden = False
                'RestablecerDataset()

                Dim f As frmFacturasComprasList = frmFacturasComprasList.Instance()
                If f.Created Then f.Cargar()
                '
            Catch ex As Exception
                XtraMsg(ex.Message, MessageBoxIcon.Error)
                'VB.SysContab.Rutinas.ErrorTransaccion()
                'SetTiempos(OrigenComprobantes.ENTRADA_ALMACEN, funciones.Tiempos.TiempoFin, Now, funciones.Eventos.Error1, Me.txtFactura.Text)                
            End Try

        End Sub

        Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
            Me.Close()
        End Sub

        'Funcion para guardar los datos de la factura
        Private Function Guardar() As Boolean
            Dim Cantidad As Integer = 0

            Dim dr() As DataRow = DT_FACT.Select("IdProyecto = 0")

            If Trim(cbProveedor.Text) = "" Then
                XtraMsg("Seleccione el Proveedor")
                cbProveedor.Focus()
                Return False
                Exit Function
            End If

            If Trim(txtFactura.Text) = "" Then
                XtraMsg("Introduzca el No. de Factura")
                txtFactura.Focus()
                Return False
                Exit Function
            End If

            If cbTipoFactura.EditValue Is Nothing Then
                XtraMsg("Seleccione el Tipo de Pago")
                cbTipoFactura.Focus()
                Return False
                Exit Function
            End If

            If cbTipoFactura.EditValue = 0 Then
                XtraMsg("Seleccione el Tipo de Pago")
                cbTipoFactura.Focus()
                Return False
                Exit Function
            End If

            If Me.vFacturas.DataRowCount = 0 Then
                XtraMsg("Seleccione al menos un Producto", MessageBoxIcon.Error)
                Return False
                Exit Function
            End If

            If dr.Length > 0 Then
                If cbMovimientos.ItemIndex = 0 Then
                    XtraMsg("Seleccione Tipo de Movimiento!")
                    cbMovimientos.Focus()
                    Return False
                End If
                '
                If cbMovimientos.EditValue Is Nothing Then
                    XtraMsg("Seleccione Tipo de Movimiento!")
                    cbMovimientos.Focus()
                    Return False
                End If
            End If
            '
            If chkLiquidar.Checked Then
                If Not XtraMsg2("Esta seguro que la informacion de esta IMPORTACIÓN es Correcto ?") Then
                    Exit Function
                End If
            Else
                If Not XtraMsg2("Esta seguro que la informacion de Registro de Entrada es Correcta ?") Then
                    Exit Function
                End If
            End If


            'For i = 0 To tCust.Rows.Count - 1
            '    If tCust.Rows(i)("Agregar") = True Then
            '        Cantidad = 1
            '        Exit For
            '    End If
            'Next

            'If Cantidad = 0 Then
            '    MsgBox("Seleccione al menos un Producto", MsgBoxStyle.Critical)
            '    'Me.dgFacturas.Focus()
            '    'Articulo.ColumnComboBox.Focus()
            '    Return False
            '    Exit Function
            'End If

            '
            'If tCust.Rows.Count > 0 Then
            '    If tCust.Rows(tCust.Rows.Count - 1)("ArticuloCodigo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Articulo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Precio") Is DBNull.Value Then
            '        tCust.Rows(tCust.Rows.Count - 1).Delete()
            '    End If
            'End If
            '
            'For i = 0 To tCust.Rows.Count - 1
            '    If tCust.Rows(i)("Articulo").ToString = "" Or tCust.Rows(i)("Articulo") Is DBNull.Value Or tCust.Rows(i)("ArticuloCodigo").ToString = "" Or tCust.Rows(i)("ArticuloCodigo") Is DBNull.Value Then
            '        MsgBox("Elija el Producto o Servicio", MsgBoxStyle.Critical)
            '        dgFacturas.Select(i)
            '        Return False
            '        Exit Function
            '    End If
            'Next

            'For i = 0 To tCust.Rows.Count - 1
            '    If tCust.Rows(i)("Articulo").ToString = "" Or tCust.Rows(i)("Articulo") Is DBNull.Value Or tCust.Rows(i)("ArticuloCodigo").ToString = "" Or tCust.Rows(i)("ArticuloCodigo") Is DBNull.Value Then
            '        If tCust.Rows(i)("Tipo") = "P" Then
            '            MsgBox("Elija el Producto", MsgBoxStyle.Critical)
            '        ElseIf tCust.Rows(i)("Tipo") = "S" Then
            '            MsgBox("Elija el Servicio", MsgBoxStyle.Critical)
            '        Else
            '            MsgBox("Elija el Producto o Servicio", MsgBoxStyle.Critical)
            '        End If

            '        dgFacturas.Select(i)
            '        Return False
            '        Exit Function
            '    End If
            'Next

            'If Me.Nuevo = True Then
            '    'Facturas.AddItem(txtFactura.Text, dtpFecha.Value, dtpFechaPago.Value, cbProveedor.SelectedValue, etTotal.Text, cbTipoFactura.SelectedValue, Tipo, 1, 0, 0, 1, 0)
            'Else
            '    'Actualizar
            'End If

            'Facturas.UpdateEstado(txtFactura.Text, "F", r.Fecha, cbProveedor.SelectedValue)
            'Facturas.UpdateFechaAlmacen(txtFactura.Text, Me.dFechaEntrada.DateTime, cbProveedor.SelectedValue, Me.cbBodegas.EditValue)
            'Bodegas.TransaccionBodega_Add(Me.cbBodegas.EditValue, "F", Me.txtFactura.Text, Me.dFechaEntrada.DateTime.Date, cbProveedor.SelectedValue)

            'Dim Descuento As Double = 0.0, DescuentoValor As Double = 0.0
            'Dim Comision As Double
            'Dim Comisiones As New VB.SysContab.ComisionDB

            'If Me.Nuevo = True Then
            '    '
            'Else
            '    '''Facturas.DeleteDetalle(txtFactura.Text)
            'End If

            '  For i = 0 To Me.vFacturas.DataRowCount - 1 'tCust.Rows.Count - 1
            'If tCust.Rows(i)("Agregar") = True Then
            'If tCust.Rows(i)("Descuento") Is DBNull.Value Then
            '    Descuento = 0
            '    DescuentoValor = 0
            'Else
            '    Descuento = tCust.Rows(i)("Descuento")
            '    DescuentoValor = CDbl(CDbl(tCust.Rows(i)("Cantidad")) * CDbl(tCust.Rows(i)("Precio")) * Math.Round(Descuento / 100.0, 4)).ToString(Round)
            'End If

            'Bodegas.Bodega_Articulos_Add(Me.cbBodegas.SelectedValue, _
            '    tCust.Rows(i)("CodigoTemporal"), _
            '    tCust.Rows(i)("Cantidad"), _
            '    tCust.Rows(i)("Precio"), _
            '    IIf(tCust.Rows(i)("PIn") = "P", "P", "A"))

            'Bodegas.TransaccionBodegaDetalle_Add(Me.cbBodegas.SelectedValue, _
            '    tCust.Rows(i)("CodigoTemporal"), _
            '    "F", _
            '    Me.txtFactura.Text, _
            '    "E", _
            '    tCust.Rows(i)("Cantidad"), _
            '    tCust.Rows(i)("Precio"), _
            '    cbProveedor.SelectedValue, _
            '    IIf(tCust.Rows(i)("PIn") = "P", "P", "A"))

            'Facturas.UpdateCantidadAlmacen(txtFactura.Text, _
            '    tCust.Rows(i)("CodigoTemporal"), _
            '    tCust.Rows(i)("Tipo"), _
            '    tCust.Rows(i)("Cantidad"), _
            '    (CDbl(tCust.Rows(i)("Cantidad")) * CDbl(tCust.Rows(i)("Precio")) - DescuentoValor) * ConfigDetalles.IVA / 100.0, _
            '    Me.cbProveedor.SelectedValue)

            ''If Me.etDestino.Text = "1" Then
            'If tCust.Rows(i)("PIn") = "P" Then
            '    Articulos.SumarExistencias(tCust.Rows(i)("CodigoTemporal"), tCust.Rows(i)("Cantidad"), tCust.Rows(i)("Tipo"))
            '    Articulos.UpdateCosto(tCust.Rows(i)("CodigoTemporal"), tCust.Rows(i)("Precio"), tCust.Rows(i)("Tipo"), tCust.Rows(i)("Cantidad"))
            'Else
            '    Articulos.UpdateCostoCC(tCust.Rows(i)("CodigoTemporal"), tCust.Rows(i)("Precio"))
            'End If

            'Descuento = Me.vFacturas.GetRowCellValue(i, "Descuento")
            'DescuentoValor = CDbl((Me.vFacturas.GetRowCellValue(i, "Cantidad") * Me.vFacturas.GetRowCellValue(i, "Precio")) * (Me.vFacturas.GetRowCellValue(i, "Descuento") / 100)).ToString(Round)

            'Bodegas.Bodega_Articulos_Add(Me.cbBodegas.EditValue, _
            '    Me.vFacturas.GetRowCellValue(i, "Codigo"), _
            '    Me.vFacturas.GetRowCellValue(i, "Cantidad"), _
            '   Math.Round(Me.vFacturas.GetRowCellValue(i, "Precio") - DescuentoValor, 2), _
            '    Me.vFacturas.GetRowCellValue(i, "PIn"))

            'Bodegas.TransaccionBodegaDetalle_Add(Me.cbBodegas.EditValue, _
            '     Me.vFacturas.GetRowCellValue(i, "Codigo"), "F", Me.txtFactura.Text, _
            '    "E", Me.vFacturas.GetRowCellValue(i, "Cantidad"), _
            '    Math.Round(Me.vFacturas.GetRowCellValue(i, "Precio") - DescuentoValor, 2), _
            '    cbProveedor.SelectedValue, Me.vFacturas.GetRowCellValue(i, "PIn"))

            'Facturas.UpdateCantidadAlmacen(txtFactura.Text, _
            '    Me.vFacturas.GetRowCellValue(i, "Codigo"), _
            '    Me.vFacturas.GetRowCellValue(i, "PIn"), _
            '    Me.vFacturas.GetRowCellValue(i, "Cantidad"), _
            '    Me.vFacturas.GetRowCellValue(i, "IVA"), _
            '    Me.cbProveedor.SelectedValue)

            'If Me.vFacturas.GetRowCellValue(i, "PIn") = "P" Then
            '    Articulos.SumarExistencias(Me.vFacturas.GetRowCellValue(i, "Codigo"), _
            '                               Me.vFacturas.GetRowCellValue(i, "Cantidad"), Me.vFacturas.GetRowCellValue(i, "PIn"))

            '    Articulos.UpdateCosto(Me.vFacturas.GetRowCellValue(i, "Codigo"), Me.vFacturas.GetRowCellValue(i, "Precio"), _
            '                          Me.vFacturas.GetRowCellValue(i, "PIn"), Me.vFacturas.GetRowCellValue(i, "Cantidad"))
            'Else
            '    Articulos.UpdateCostoCC(Me.vFacturas.GetRowCellValue(i, "Codigo"), Me.vFacturas.GetRowCellValue(i, "Precio"))
            'End If
            'End If
            '  Next


            'Dim Requisa As Integer = VB.SysContab.RequisasDB.GetCodigoNuevo()
            'Dim DT As DataTable = ObtieneDatos("JAR_GetComprobanteCompra", _
            '                                   txtFactura.Text, _
            '                                   cbProveedor.EditValue, _
            '                                   EmpresaActual)


            ShowSplash("Guardando Movimiento...")
            '
            'Cuando son solo productos.
            If dr.Length > 0 Then
                Dim DT_COMP As DataTable = ObtieneDatos("JAR_GetComprobanteCompra", txtFactura.Text,
                                                                                    cbProveedor.EditValue,
                                                                                    EmpresaActual)

                Dim DT_REQ As DataTable = DT_FACT.Select("IdProyecto = 0").CopyToDataTable
                '
                Dim Requisa As Integer = db_requisas.Add(EmpresaActual, "E", dFechaEntrada.DateTime.Date, cbBodegas.EditValue,
                                          Login, txtFactura.Text, cbMovimientos.EditValue, txtFactura.Text, DT_REQ.Rows(0).Item("Observaciones"),
                                          "", "", "", "", "", "", 0, "", 0, 0, cbProveedor.EditValue, 0, 0, IIf(chkLiquidar.Checked, 1, 0))

                If Requisa > 0 Then

                    Dim Descuento As Double = 0.0, DescuentoValor As Double = 0.0

                    For i = 0 To DT_REQ.Rows.Count - 1

                        'Agregar el detalle de la requisa
                        Descuento = DT_REQ.Rows.Item(i)("Descuento")
                        DescuentoValor = CDbl(DT_REQ.Rows.Item(i)("Precio") * (Descuento / 100))
                        '
                        If DT_REQ.Rows.Item(i)("Cantidad") > 0 Then

                            db_requisas.AddDetalle(EmpresaActual, Requisa, DT_REQ.Rows.Item(i)("Codigo"),
                                                   DT_REQ.Rows.Item(i)("PIn"),
                                                    DT_REQ.Rows.Item(i)("Cantidad"),
                                                   Math.Round(DT_REQ.Rows.Item(i)("Precio") - DescuentoValor, 4),
                                                   cbMovimientos.GetColumnValue("Cuenta"))

                        End If
                    Next
                    '
                    db_requisas.Requisa_Contabilizada(Requisa, IIf(DT_COMP.Rows.Count = 0, 0, DT_COMP.Rows.Item(0)("Comp_No")),
                                                      IIf(DT_COMP.Rows.Count = 0, 0, DT_COMP.Rows.Item(0)("Per_Id")),
                                                      IIf(DT_COMP.Rows.Count = 0, 0, DT_COMP.Rows.Item(0)("Mes")),
                                                      IIf(chkLiquidar.Checked, 0, 1), EmpresaActual)
                    '
                    VB.SysContab.Facturas_ComprasDB.UpdateEstado(txtFactura.Text, "F", cbProveedor.EditValue)
                    '
                    VB.SysContab.Facturas_ComprasDB.UpdateEstadoAlmacen(txtFactura.Text, dFechaEntrada.DateTime.Date,
                                                                        cbProveedor.EditValue, cbBodegas.EditValue)
                End If



                'Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
                'Conn.IniciarTransaccion()
                '
                ' Try
                'Conn.RemoveParameters()
                'Conn.AddParameter("Numero", SqlDbType.NVarChar, 50, ParameterDirection.Input, txtFactura.Text)
                'Conn.AddParameter("Estado", SqlDbType.NVarChar, 5, ParameterDirection.Input, "F")
                'Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, Now.Date)
                'Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
                'Conn.AddParameter("Proveedor", SqlDbType.Int, 4, ParameterDirection.Input, cbProveedor.EditValue)
                'Conn.EjecutarComando("_FacturasComprasUpdateEstado")
                ''

                ''VB.SysContab.Facturas_ComprasDB.UpdateEstado(Me.vFacturas.GetFocusedRowCellValue("No. Orden Pago"),
                ''"A", VB.SysContab.Rutinas.Fecha, Me.vFacturas.GetFocusedRowCellValue("Proveedor_ID"))


                'Conn.RemoveParameters()
                'Conn.AddParameter("Numero", SqlDbType.NVarChar, 50, ParameterDirection.Input, txtFactura.Text)
                'Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, dFechaEntrada.DateTime)
                'Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
                'Conn.AddParameter("Proveedor", SqlDbType.Int, 4, ParameterDirection.Input, cbProveedor.EditValue)
                'Conn.AddParameter("Bodega", SqlDbType.NVarChar, 10, ParameterDirection.Input, cbBodegas.EditValue)
                'Conn.EjecutarComando("_FacturasComprasUpdateFechaAlmacen")
                '
                'Conn.RemoveParameters()
                'Conn.AddParameter("Factura", SqlDbType.NVarChar, 50, ParameterDirection.Input, txtFactura.Text)
                'Conn.AddParameter("Proveedor", SqlDbType.Int, 4, ParameterDirection.Input, cbProveedor.EditValue)
                'Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
                'Dim DT_COMP As DataTable = Conn.EjecutarComando("JAR_GetComprobanteCompra")
                '                
                'Conn.RemoveParameters()
                'Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
                'Conn.AddParameter("Codigo", SqlDbType.Int, 4, ParameterDirection.Output, 0)
                'Conn.EjecutarComando("_GetList_RequisaCodigoNuevo")
                'Requisa = Conn.GetParameter("Codigo").Valor
                '

                '    Conn.CompletarTransaccion()
                '    'HideSplash()
                'Catch ex As Exception
                '    HideSplash()
                '    XtraMsg(ex.Message & "Guardar", MessageBoxIcon.Error)
                '    Conn.AnularTransaccion()
                '    Return False
                'End Try
                '
                'Conn.RemoveParameters()
                '    Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                '    Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
                '    Conn.AddParameter("TRequisa", SqlDbType.NVarChar, 5, ParameterDirection.Input, "E")
                '    Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, dFechaEntrada.DateTime.Date)
                '    Conn.AddParameter("Bodega", SqlDbType.NVarChar, 15, ParameterDirection.Input, cbBodegas.EditValue)
                '    Conn.AddParameter("RealizadoPor", SqlDbType.NVarChar, 50, ParameterDirection.Input, Login)
                '    Conn.AddParameter("Registro", SqlDbType.Bit, 1, ParameterDirection.Input, 0)
                '    Conn.AddParameter("Factura", SqlDbType.NVarChar, 15, ParameterDirection.Input, txtFactura.Text)
                '    Conn.AddParameter("Movimiento", SqlDbType.Int, 4, ParameterDirection.Input, cbMovimientos.EditValue)
                '    Conn.AddParameter("Referencia", SqlDbType.NVarChar, 100, ParameterDirection.Input, txtFactura.Text)
                '    Conn.AddParameter("Concepto", SqlDbType.NVarChar, 2048, ParameterDirection.Input, DT_REQ.Rows(0).Item("Observaciones"))
                '    Conn.AddParameter("Transporte", SqlDbType.NVarChar, 512, ParameterDirection.Input, "")
                '    Conn.AddParameter("NoPlaca", SqlDbType.NVarChar, 100, ParameterDirection.Input, "")
                '    Conn.AddParameter("Conductor", SqlDbType.NVarChar, 512, ParameterDirection.Input, "")
                '    Conn.AddParameter("Remision", SqlDbType.NVarChar, 50, ParameterDirection.Input, "")
                '    Conn.AddParameter("OT_Matriz", SqlDbType.NVarChar, 50, ParameterDirection.Input, "")
                '    Conn.AddParameter("OT_Suc", SqlDbType.NVarChar, 50, ParameterDirection.Input, "")
                '    Conn.AddParameter("IdCliente", SqlDbType.Int, 5, ParameterDirection.Input, 0)
                '    Conn.AddParameter("NoPoliza", SqlDbType.NVarChar, 50, ParameterDirection.Input, "")
                '    Conn.AddParameter("IdProyecto", SqlDbType.Int, 5, ParameterDirection.Input, 0)
                '    Conn.AddParameter("IdOrden", SqlDbType.Int, 5, ParameterDirection.Input, 0)
                '    Conn.AddParameter("IdProveedor", SqlDbType.Int, 5, ParameterDirection.Input, cbProveedor.EditValue)
                'Conn.EjecutarComando("SP_Requisas_Add")

                '
                'Conn.RemoveParameters()
                'Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
                'Conn.AddParameter("Requisa", SqlDbType.Int, 4, ParameterDirection.Input, Requisa)
                'Conn.AddParameter("Contabilizar", SqlDbType.Bit, 4, ParameterDirection.Input, True)
                'Conn.AddParameter("Distribuir", SqlDbType.Bit, 4, ParameterDirection.Input, False)
                'Conn.AddParameter("Comprobante", SqlDbType.Int, 4, ParameterDirection.Input, IIf(DT_COMP.Rows.Count = 0, 0, DT_COMP.Rows.Item(0)("Comp_No")))
                'Conn.AddParameter("Periodo", SqlDbType.Int, 4, ParameterDirection.Input, IIf(DT_COMP.Rows.Count = 0, 0, DT_COMP.Rows.Item(0)("Per_Id")))
                'Conn.AddParameter("Mes", SqlDbType.Int, 4, ParameterDirection.Input, IIf(DT_COMP.Rows.Count = 0, 0, DT_COMP.Rows.Item(0)("Mes")))
                'Conn.EjecutarComando("_Requisa_Contabilizar")
                '

                'Dim Descuento As Double = 0.0, DescuentoValor As Double = 0.0

                'For i = 0 To DT_REQ.Rows.Count - 1
                '    'Agregar el detalle de la requisa
                '    Descuento = DT_REQ.Rows.Item(i)("Descuento")
                '    DescuentoValor = CDbl(DT_REQ.Rows.Item(i)("Precio") * (Descuento / 100))

                '    If DT_REQ.Rows.Item(i)("Cantidad") > 0 Then
                '        Conn.RemoveParameters()
                '        Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                '        Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
                '        Conn.AddParameter("Articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, DT_REQ.Rows.Item(i)("Codigo"))
                '        Conn.AddParameter("TArticulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, DT_REQ.Rows.Item(i)("PIn"))
                '        Conn.AddParameter("Cantidad", SqlDbType.Decimal, 20, ParameterDirection.Input, DT_REQ.Rows.Item(i)("Cantidad"))
                '        Conn.AddParameter("Precio", SqlDbType.Decimal, 20, ParameterDirection.Input, Math.Round(DT_REQ.Rows.Item(i)("Precio") - DescuentoValor, 2))
                '        Conn.AddParameter("Cuenta", SqlDbType.NVarChar, 50, ParameterDirection.Input, cbMovimientos.GetColumnValue("Cuenta"))
                '        Conn.EjecutarComando("SP_Requisas_Detalle_Add")
                '    End If
                'Next
                '

                'Conn.CompletarTransaccion()

                HideSplash()
                '
                Return True
                'Catch ex As Exception
                '    HideSplash()
                '    XtraMsg(ex.Message & "Guardar", MessageBoxIcon.Error)
                '    Conn.AnularTransaccion()
                '    Return False
                'End Try
            Else
                Dim DT_PROY As DataTable = DT_FACT.Select("IdProyecto <> 0").CopyToDataTable

                Dim Proyectos = From row In DT_PROY.AsEnumerable()
                                Select row.Field(Of Integer)("IdProyecto") Distinct

                For Each s As Object In Proyectos
                    If Not s Is Nothing Then
                        Dim DT_DETALLE As DataTable = DT_PROY.Select("IdProyecto =" & s).CopyToDataTable

                        Dim obj As New ProyectosCostos
                        Dim db As New db_ProyectosCostos

                        For i As Integer = 0 To DT_DETALLE.Rows.Count - 1

                            obj.IdProyecto = DT_DETALLE.Rows.Item(i)("IdProyecto")
                            obj.Fecha = dFechaEntrada.DateTime.Date
                            obj.NoFactura = txtFactura.Text
                            obj.Proveedor = cbProveedor.EditValue
                            obj.Mes = dtpFecha.DateTime.Month
                            obj.Tipo = 1
                            obj.Costo = DT_DETALLE.Rows.Item(i)("SubTotal")

                            db.Insertar(obj)
                        Next

                    End If
                Next
                '
                'Actualizar Estado de la Factura

                VB.SysContab.Facturas_ComprasDB.UpdateEstado(txtFactura.Text, "F", cbProveedor.EditValue)
                '
                VB.SysContab.Facturas_ComprasDB.UpdateEstadoAlmacen(txtFactura.Text, dFechaEntrada.DateTime.Date,
                                                                        cbProveedor.EditValue, cbBodegas.EditValue)

                'Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
                '
                'Conn.RemoveParameters()
                'Conn.AddParameter("Numero", SqlDbType.NVarChar, 50, ParameterDirection.Input, txtFactura.Text)
                'Conn.AddParameter("Estado", SqlDbType.NVarChar, 5, ParameterDirection.Input, "F")
                'Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, Now.Date)
                'Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
                'Conn.AddParameter("Proveedor", SqlDbType.Int, 4, ParameterDirection.Input, cbProveedor.EditValue)
                'Conn.EjecutarComando("_FacturasComprasUpdateEstado")
                ''
                'Conn.RemoveParameters()
                'Conn.AddParameter("Numero", SqlDbType.NVarChar, 50, ParameterDirection.Input, txtFactura.Text)
                'Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, dFechaEntrada.DateTime)
                'Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
                'Conn.AddParameter("Proveedor", SqlDbType.Int, 4, ParameterDirection.Input, cbProveedor.EditValue)
                'Conn.AddParameter("Bodega", SqlDbType.NVarChar, 10, ParameterDirection.Input, cbBodegas.EditValue)
                'Conn.EjecutarComando("_FacturasComprasUpdateFechaAlmacen")
                '
                HideSplash()
                '
                Return True
            End If

            ''Dim Proyectos = From row In DT_FACT.AsEnumerable()
            ''    Select row.Field(Of Integer)("IdProyecto") Distinct

            'For Each s As Object In Proyectos
            '    If Not s Is Nothing Then

            '        Dim IdProyecto As Integer = s

            '        Conn.RemoveParameters()
            '        Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
            '        Conn.AddParameter("Codigo", SqlDbType.Int, 4, ParameterDirection.Output, 0)

            '        Conn.EjecutarComando("_GetList_RequisaCodigoNuevo")
            '        Dim Requisa As Integer = Conn.GetParameter("Codigo").Valor

            '        Conn.RemoveParameters()
            '        Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            '        Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
            '        Conn.AddParameter("TRequisa", SqlDbType.NVarChar, 5, ParameterDirection.Input, "E")
            '        Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, dFechaEntrada.DateTime.Date)
            '        Conn.AddParameter("Bodega", SqlDbType.NVarChar, 15, ParameterDirection.Input, cbBodegas.EditValue)
            '        Conn.AddParameter("RealizadoPor", SqlDbType.NVarChar, 50, ParameterDirection.Input, Login)
            '        Conn.AddParameter("Registro", SqlDbType.Bit, 1, ParameterDirection.Input, 0)
            '        Conn.AddParameter("Factura", SqlDbType.NVarChar, 15, ParameterDirection.Input, txtFactura.Text)
            '        Conn.AddParameter("Movimiento", SqlDbType.Int, 4, ParameterDirection.Input, cbMovimientos.EditValue)
            '        Conn.AddParameter("Referencia", SqlDbType.NVarChar, 100, ParameterDirection.Input, txtFactura.Text)
            '        Conn.AddParameter("Concepto", SqlDbType.NVarChar, 2048, ParameterDirection.Input, DT_FACT.Rows(0).Item("Observaciones"))
            '        Conn.AddParameter("Transporte", SqlDbType.NVarChar, 512, ParameterDirection.Input, "")
            '        Conn.AddParameter("NoPlaca", SqlDbType.NVarChar, 100, ParameterDirection.Input, "")
            '        Conn.AddParameter("Conductor", SqlDbType.NVarChar, 512, ParameterDirection.Input, "")
            '        Conn.AddParameter("Remision", SqlDbType.NVarChar, 50, ParameterDirection.Input, "")
            '        Conn.AddParameter("OT_Matriz", SqlDbType.NVarChar, 50, ParameterDirection.Input, "")
            '        Conn.AddParameter("OT_Suc", SqlDbType.NVarChar, 50, ParameterDirection.Input, "")
            '        Conn.AddParameter("IdCliente", SqlDbType.Int, 5, ParameterDirection.Input, 0)
            '        Conn.AddParameter("NoPoliza", SqlDbType.NVarChar, 50, ParameterDirection.Input, "")
            '        Conn.AddParameter("IdProyecto", SqlDbType.Int, 5, ParameterDirection.Input, s)
            '        Conn.AddParameter("IdOrden", SqlDbType.Int, 5, ParameterDirection.Input, 0)
            '        Conn.AddParameter("IdProveedor", SqlDbType.Int, 5, ParameterDirection.Input, cbProveedor.EditValue)

            '        Conn.EjecutarComando("SP_Requisas_Add")

            '        Dim DT_DETALLE As DataTable = DT_FACT.Select("IdProyecto =" & s).CopyToDataTable

            '        'For i = 0 To Me.vFacturas.DataRowCount - 1
            '        For i = 0 To DT_DETALLE.Rows.Count - 1
            '            'Agregar el detalle de la requisa
            '            Descuento = DT_DETALLE.Rows.Item(i)("Descuento")
            '            DescuentoValor = CDbl((DT_DETALLE.Rows.Item(i)("Cantidad") * DT_DETALLE.Rows.Item(i)("Precio")) * (DT_DETALLE.Rows.Item(i)("Descuento") / 100)).ToString(Round)

            '            If DT_DETALLE.Rows.Item(i)("Cantidad") > 0 Then
            '                Conn.RemoveParameters()
            '                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            '                Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
            '                Conn.AddParameter("Articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, DT_DETALLE.Rows.Item(i)("Codigo"))
            '                Conn.AddParameter("TArticulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, DT_DETALLE.Rows.Item(i)("PIn"))
            '                Conn.AddParameter("Cantidad", SqlDbType.Decimal, 20, ParameterDirection.Input, DT_DETALLE.Rows.Item(i)("Cantidad"))
            '                Conn.AddParameter("Precio", SqlDbType.Decimal, 20, ParameterDirection.Input, Math.Round(DT_DETALLE.Rows.Item(i)("Precio") - DescuentoValor, 2))
            '                Conn.AddParameter("Cuenta", SqlDbType.NVarChar, 50, ParameterDirection.Input, cbMovimientos.GetColumnValue("Cuenta"))
            '                Conn.EjecutarComando("SP_Requisas_Detalle_Add")
            '            End If
            '        Next
            '        '
            '        Conn.RemoveParameters()
            '        Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
            '        Conn.AddParameter("Requisa", SqlDbType.Int, 4, ParameterDirection.Input, Requisa)
            '        Conn.AddParameter("Contabilizar", SqlDbType.Bit, 4, ParameterDirection.Input, True)
            '        Conn.AddParameter("Distribuir", SqlDbType.Bit, 4, ParameterDirection.Input, False)
            '        Conn.AddParameter("Comprobante", SqlDbType.Int, 4, ParameterDirection.Input, IIf(DT.Rows.Count = 0, 0, DT.Rows.Item(0)("Comp_No")))
            '        Conn.AddParameter("Periodo", SqlDbType.Int, 4, ParameterDirection.Input, IIf(DT.Rows.Count = 0, 0, DT.Rows.Item(0)("Per_Id")))
            '        Conn.AddParameter("Mes", SqlDbType.Int, 4, ParameterDirection.Input, IIf(DT.Rows.Count = 0, 0, DT.Rows.Item(0)("Mes")))

            '        Conn.EjecutarComando("_Requisa_Contabilizar")
            '    End If
            'Next

        End Function

        Private Sub dgFacturas_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            'Try
            '    If Me.dgFacturas.CurrentRowIndex >= tCust.Rows.Count Then
            '        Me.dgFacturas.ReadOnly = True
            '        Exit Sub
            '    Else
            '        If Me.dgFacturas.CurrentCell.ColumnNumber = 2 Then
            '            Me.dgFacturas.ReadOnly = False
            '        Else
            '            Me.dgFacturas.ReadOnly = True
            '        End If
            '        'Exit Sub
            '    End If

            '    ValorActualCantidad = tCust.Rows(dgFacturas.CurrentRowIndex)("Cantidad")
            '    ValorActualPrecio = tCust.Rows(dgFacturas.CurrentRowIndex)("Precio")
            '    ValorActualDescuento = tCust.Rows(dgFacturas.CurrentRowIndex)("Descuento")

            'Catch ex As Exception
            '    Exit Sub
            'End Try
        End Sub

        Private Sub frmFacturacionCliente_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
            'SetTiempos(OrigenComprobantes.ENTRADA_ALMACEN, funciones.Tiempos.TiempoFin, Now, funciones.Eventos.Salir, Me.txtFactura.Text)
        End Sub

        'Private Sub dgFacturas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFacturas.DoubleClick
        '    If tCust.Rows.Count = 0 Then
        '        MsgBox("Seleccione el Producto o Servicio", MsgBoxStyle.Information)
        '        Exit Sub
        '    End If

        '    If dgFacturas.Item(dgFacturas.CurrentRowIndex, 0) Is DBNull.Value Then
        '        MsgBox("Seleccione el Producto o Servicio", MsgBoxStyle.Information)
        '        Exit Sub
        '    End If

        '    Dim f As frmDetalleArticulo = f.Instance
        '    f.Tipo = Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 7)
        '    Registro = dgFacturas.Item(dgFacturas.CurrentRowIndex, 0)

        '    f.MdiParent = Me.MdiParent
        '    f.Show()
        'End Sub

        Private Sub LimpiarControles()

            etSubTotal.Text = CDbl(0).ToString(Round)
            etIva.Text = CDbl(0).ToString(Round)
            etTotal.Text = CDbl(0).ToString(Round)

            'txtOrden.Text = ""

            TotalCheques = 0
            TotalTarjetas = 0
            TotalEfectivo = 0
            TotalNotaDebito = 0
            TotalFactura = 0


            TotalGlobal = 0

            'etSaldo.Text = "0.00"

        End Sub

        Private Sub RestablecerDataset()


            'MakeDataSet()
            'Me.etSubTotal.Text = tCust.Compute("Sum(Subtotal)", "")
            'Me.etIva.Text = tCust.Compute("Sum(IVA)", "")
            'Me.etTotal.Text = Me.etSubTotal.Text + Me.etIva.Text
            'If Me.IvaAsumido Then
            '    Me.SubTotalParaIVA = (tCust.Compute("Sum(Subtotal)", "exiva = 0 ") * ConfigDetalles.IVA / 100) / (1 + (ConfigDetalles.IVA / 100))
            'End If


            'dgFacturas.SetDataBinding(myDataSet, "Articulos")
            'AddCustomDataTableStyle()

            'Inicio = True
            'cbTipoFactura.SelectedValue = 0
            'Inicio = False


        End Sub

        Private Sub cbTipoFactura_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)


        End Sub

        Private Sub cmdOrdenes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


            'Dim f As New frmOrdenesCompraList
            'Me.Nuevo = False

            'f.WindowState = FormWindowState.Normal
            'f.StartPosition = FormStartPosition.CenterScreen
            'f.ShowDialog()

            'If f.Salir = True Then
            '    Exit Sub
            'Else
            '    CargarOrden = True
            '    OrdenCompra = f.dgOrdenes.Item(f.dgOrdenes.CurrentRowIndex, 0)
            '    ds = OrdenesCompra.OrdenCompraDetalle(OrdenCompra)
            '    'ordenescompra.
            '    txtOrden.Text = OrdenCompra
            '    If ds.Tables("Ordenes_Compras").Rows.Count = 0 Then
            '        Exit Sub
            '    End If

            '    Me.cbProveedor.SelectedValue = ds.Tables("Ordenes_Compras").Rows(0).Item("Proveedor_ID")
            'End If

            'MakeDataSet1()
            'Me.dgFacturas.SetDataBinding(myDataSet, "Articulos")
            'AddCustomDataTableStyle()
            'End If
        End Sub

        Private Sub cmdConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            'If tCust.Rows.Count > 0 Then
            '    If tCust.Rows(tCust.Rows.Count - 1)("ArticuloCodigo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Articulo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Precio") Is DBNull.Value Then
            '        tCust.Rows(tCust.Rows.Count - 1).Delete()
            '    End If
            'End If

            'If Me.rbProductos.Checked = True Then
            '    Dim f As frmBuscarItem = f.Instance
            '    f.MdiParent = Me.MdiParent
            '    f.Show()
            'Else
            '    Dim f As frmBuscarItemCC = f.Instance
            '    f.etInicio.Text = "1"
            '    f.MdiParent = Me.MdiParent
            '    f.Show()
            '    f.etInicio.Text = "0"
            'End If
        End Sub

        Private Sub AgregarItem()
            'Dim k As Integer
            'Dim t As Integer

            'If tItem.Rows.Count <> 0 Then
            '    For k = 0 To tItem.Rows.Count - 1

            '        For t = 0 To tCust.Rows.Count - 1

            '            If tCust.Rows(t)("ArticuloCodigo") = tItem.Rows(k)("Codigo") And tCust.Rows(t)("Tipo") = tItem.Rows(k)("Tipo") Then
            '                tCust.Rows(t)("Cantidad") = CDbl(tCust.Rows(t)("Cantidad")) + CDbl(tItem.Rows(k)("Cantidad"))
            '                Exit For

            '            End If

            '        Next

            '        If t = tCust.Rows.Count Then
            '            Dim newRow1 As DataRow
            '            newRow1 = tCust.NewRow
            '            newRow1("ArticuloCodigo") = tItem.Rows(k)("Codigo")
            '            tCust.Rows.Add(newRow1)
            '            tCust.Rows(tCust.Rows.Count - 1)("Articulo") = tItem.Rows(k)("Descripcion")
            '            tCust.Rows(tCust.Rows.Count - 1)("Cantidad") = tItem.Rows(k)("Cantidad")
            '            tCust.Rows(tCust.Rows.Count - 1)("Precio") = CDbl(tItem.Rows(k)("Costo")).ToString(RoundP)
            '            tCust.Rows(tCust.Rows.Count - 1)("Tipo") = tItem.Rows(k)("Tipo")

            '        End If
            '    Next
            '    tItem.Clear()
            'End If

        End Sub

        Private Sub etTotalT_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)

            AgregarItem()
        End Sub

        Private Sub frmFacturasCompra_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter

            AgregarItem()
        End Sub

        Private Sub dgFacturas_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
            '
            'AgregarItem()
        End Sub

        Private Sub txtDireccion_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)

            AgregarItem()
        End Sub

        Private Sub cmdAceptar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.MouseEnter

            AgregarItem()
        End Sub

        Private Sub gbBotones_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)

            AgregarItem()
        End Sub

        Private Sub gbTipo_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)

            AgregarItem()
        End Sub

        Private Sub GroupBox3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)

            AgregarItem()
        End Sub

        Private Sub cmdConsultaProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultaProveedores.Click
            If cbProveedor.EditValue Is Nothing Then
                MsgBox("El Proveedor no está registrado", MsgBoxStyle.Information)
                cbProveedor.Focus()
                Exit Sub
            End If
            '
            Dim f As frmAcumuladosProveedor = frmAcumuladosProveedor.Instance
            f.Proveedor = cbProveedor.EditValue
            f.MdiParent = Me.MdiParent
            f.Show()
            f.Text = "Acumulado de Proveedor"
            f.WindowState = FormWindowState.Maximized
        End Sub

        Private Sub frmFacturasCompra_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

        End Sub

        Private Sub dgFacturas_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
            'Dim hti As DataGrid.HitTestInfo = Me.dgFacturas.HitTest(e.X, e.Y)
            'Try
            '    If hti.Type = DataGrid.HitTestType.Cell AndAlso hti.Column = myCheckBoxCol Then
            '        Me.dgFacturas(hti.Row, hti.Column) = Not CBool(Me.dgFacturas(hti.Row, hti.Column))
            '    Else
            '        Exit Sub
            '    End If
            'Catch ex As Exception

            'End Try
        End Sub

        'Private Sub cbTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTodos.CheckedChanged
        '    If Me.etInicio.Text = "1" Then
        '        Exit Sub
        '    End If

        '    Dim j As Integer
        '    If Me.cbTodos.Checked = True Then
        '        For j = 0 To tCust.Rows.Count - 1
        '            tCust.Rows(j)("Agregar") = True
        '        Next
        '    Else
        '        For j = 0 To tCust.Rows.Count - 1
        '            tCust.Rows(j)("Agregar") = False
        '        Next
        '    End If
        'End Sub


        Private Sub dgFacturas_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            'Me.dgFacturas.ReadOnly = True
        End Sub

        'Private Function Contabilizar(ByVal Cuentas() As String, ByVal Montos() As Double, ByVal IRAlcaldiaPAgado As Boolean) As Boolean

        '    Dim IRxPagar As Double = 0
        '    Dim IRPorcentaje As Double = 0

        '    If IR_Pagado Then   'Si se va a Pagar IR en la Orden de Pago
        '        If Ir_Serv Then IRPorcentaje = ConfigDetalles.IRServ
        '        If Ir_Prod Then IRPorcentaje = ConfigDetalles.IRProd

        '        If Me.txtSubTotalIR.EditValue >= ConfigDetalles.MontoIR Then
        '            IRxPagar = Me.txtSubTotalIR.EditValue * (IRPorcentaje / 100)
        '        End If
        '    End If

        '    'If (etTotal.Text - etIva.Text) >= ConfigDetalles.MontoIR Then
        '    '    IRxPagar = CDbl((Me.etTotal.Text - IIf(IvaAsumido, (SubTotalParaIVA * (ConfigDetalles.IVA / 100.0)).ToString(Round), Me.etIva.Text)) * Math.Round((IRPorcentaje / 100), 2))
        '    'End If

        '    'If IR_Pagado Then   'Si no se ha pagado el Ir en la ORden de Pago, Calcular la retension
        '    '    'If Me.vFacturas.Columns("SubTotal").SummaryItem.SummaryValue >= ConfigDetalles.MontoIR Then
        '    'End If


        '    Dim Comprobantes As New VB.SysContab.ComprobanteDB
        '    Dim CompNo As String
        '    Dim Tipo As String
        '    Dim TipoCompr As String
        '    Dim EmpresasDB As New VB.SysContab.EmpresasDB
        '    Dim PeriodosDB As New VB.SysContab.PeriodosDB
        '    Dim ds As DataSet
        '    Dim Plantilla As New VB.SysContab.PlantillaDB
        '    Dim plan As String
        '    Dim i As Integer

        '    Dim Muni As New VB.SysContab.MunicipiosDB
        '    Dim MunDet As VB.SysContab.MunicipioDetails = Muni.GetDetails(VB.SysContab.ProveedoresDB.GetDetails(Me.cbProveedor.SelectedValue).Departamento, VB.SysContab.ProveedoresDB.GetDetails(Me.cbProveedor.SelectedValue).Municipio)

        '    'CALCULANDO IR PAGADO A ALCALDIA
        '    Dim ValorIRAlcaldia As Double

        '    If IRAlcaldiaPAgado = True Then
        '        If VB.SysContab.ProveedoresDB.GetDetails(Me.cbProveedor.SelectedValue).Departamento = "0" And VB.SysContab.ProveedoresDB.GetDetails(Me.cbProveedor.SelectedValue).Municipio = "0" Then
        '            MsgBox("No se puede completar la facturación, por favor ingrese departamento o municipio del Proveedor.", MsgBoxStyle.Critical)
        '            VB.SysContab.Rutinas.ErrorTransaccion()
        '            Exit Function
        '        End If

        '        If Me.vFacturas.Columns("SubTotal").SummaryItem.SummaryValue >= MunDet.Impuesto_SVenta_Min Then
        '            ValorIRAlcaldia = Me.vFacturas.Columns("SubTotal").SummaryItem.SummaryValue * (MunDet.Impuesto_SVenta / 100)
        '        Else
        '            ValorIRAlcaldia = 0
        '        End If

        '        'If CDbl((Me.etTotal.Text - IIf(IvaAsumido, (SubTotalParaIVA * (ConfigDetalles.IVA / 100.0)).ToString(Round), Me.etIva.Text))).ToString(Round) >= MunDet.Impuesto_SVenta_Min Then
        '        '    ValorIRAlcaldia = CDbl((Me.etTotal.Text - IIf(IvaAsumido, (SubTotalParaIVA * (ConfigDetalles.IVA / 100.0)).ToString(Round), Me.etIva.Text))).ToString(Round) * (MunDet.Impuesto_SVenta / 100) 'CDbl(Me.etSubTotal.Text) * (MunDet.Impuesto_SVenta / 100)
        '        'Else
        '        '    ValorIRAlcaldia = 0
        '        'End If
        '    Else
        '        ValorIRAlcaldia = 0
        '    End If

        '    ''If FormaPago.FormaPagoDias(cbTipoFactura.SelectedValue) = 0 Then  'Contado
        '    ''    'Factura de Contado
        '    ''    plan = Plantilla.GetTipoPlantilla(1, 6).ToString

        '    ''    If plan = "" Or plan Is DBNull.Value Then
        '    ''        MsgBox("No hay plantilla disponible para realizar esta transacción", MsgBoxStyle.Information)
        '    ''        Return False
        '    ''        Exit Function
        '    ''    End If

        '    ''    Dim Detalles As VB.SysContab.PlantillaDetails = Plantilla.GetPlantillasDetails(plan)
        '    ''    ds = Detalles.Detalles

        '    ''    TipoCompr = Detalles.TipoCompr
        '    ''    ' en el campo Tipo, se enviaba '0' y segun la tabla de Comprobantes, ese campo debe tener 1 si es factura de proveedor
        '    ''    CompNo = Comprobantes.AddComprobante(TipoCompr, 1, _
        '    ''        "Comprobante de Compra de Contado, Factura #: " & Me.txtFactura.Text, _
        '    ''        EmpresasDB.GetDetails(EmpresaActual).MonedaBase, _
        '    ''        PeriodosDB.Activo(dtpFecha.Value), Me.dtpFecha.Value, 0, "", False, _
        '    ''        Me.cbProveedor.SelectedValue, "", 1, Me.txtFactura.Text, VB.SysContab.Rutinas.Fecha, _
        '    ''        Me.cbTipoFactura.SelectedValue, OrigenComprobantes.ENTRADA_ALMACEN)

        '    ''    'Agregar las lineas de las cuentas de los productos
        '    ''    Dim x As Integer
        '    ''    Dim SumaMontos As Double
        '    ''    SumaMontos = 0
        '    ''    For x = 0 To Cuentas.GetUpperBound(0)
        '    ''        If Cuentas(x) <> "" Then
        '    ''            SumaMontos += Montos(x)
        '    ''            Comprobantes.AddComprobanteDetalles(CompNo, Cuentas(x), "", Montos(x), 0, TipoCompr, "D", Me.txtFactura.Text, 0, Me.dtpFecha.Value, 1)
        '    ''        End If
        '    ''    Next

        '    ''    'Si son servicios los que se estan comprando de contado
        '    ''    If Me.rbServicios.Checked Then
        '    ''        If SumaMontos >= ConfigDetalles.MontoIR Then
        '    ''            SumaMontos = SumaMontos * Math.Round((ConfigDetalles.IRServ / 100), 2)
        '    ''        End If
        '    ''    Else
        '    ''        If SumaMontos >= ConfigDetalles.MontoIR Then
        '    ''            SumaMontos = SumaMontos * Math.Round((ConfigDetalles.IRProd / 100), 2)
        '    ''        End If
        '    ''    End If

        '    ''    'Agregar la linea del IR
        '    ''    'If DetallesProveedor.Exento = False Then
        '    ''    If Not IR_Pagado Then
        '    ''        'If CDbl((Me.etTotal.Text - IIf(IvaAsumido, (SubTotalParaIVA * (ConfigDetalles.IVA / 100.0)).ToString(Round), Me.etIva.Text))).ToString(Round) >= ConfigDetalles.MontoIR Then
        '    ''        'Agregar la linea del IR
        '    ''        Comprobantes.AddComprobanteDetalles(CompNo, ds.Tables("PlantillasDetalles").Rows(0).Item("Cuenta"), _
        '    ''                                            "I.R", IRxPagar, 0, TipoCompr, "C", Me.txtFactura.Text, 0, Me.dtpFecha.Value, 1, 2)
        '    ''    Else
        '    ''        IRxPagar = 0
        '    ''    End If

        '    ''    If IIf(etIva.Text = "", 0, CDbl(etIva.Text)) <> 0 Then
        '    ''        'Se agrega la cuenta del IVA
        '    ''        Comprobantes.AddComprobanteDetalles(CompNo, ds.Tables("PlantillasDetalles").Rows(1).Item("Cuenta"), _
        '    ''                                            "I.V.A", Me.etIva.Text, 0, TipoCompr, "D", Me.txtFactura.Text, 0, Me.dtpFecha.Value, 1, 1)
        '    ''    End If

        '    ''    'Se agrega la cuenta del banco
        '    ''    Comprobantes.AddComprobanteDetalles(CompNo, ds.Tables("PlantillasDetalles").Rows(2).Item("Cuenta"), _
        '    ''                                        "Banco", Me.etTotal.Text - IRxPagar - ValorIRAlcaldia, 0, TipoCompr, "C", Me.txtFactura.Text, 0, Me.dtpFecha.Value, 1)

        '    ''    ' AGREGANDO LA CUENTA DE IR D ALCALDIA
        '    ''    If ValorIRAlcaldia > 0 Then
        '    ''        Comprobantes.AddComprobanteDetalles(CompNo, ds.Tables("PlantillasDetalles").Rows(3).Item("Cuenta"), _
        '    ''                                            "I.R. Alcaldia", ValorIRAlcaldia, 0, TipoCompr, "C", Me.txtFactura.Text, 0, Me.dtpFecha.Value, 1, 3)
        '    ''    End If
        '    ''    'Cancelar la Factura de Contado
        '    ''    Comprobantes.CancelarFactura(Me.txtFactura.Text, Me.cbProveedor.SelectedValue, 1)
        '    ''    '*********************************************************
        '    ''Else    

        '    '*************** Factura de Contado o de Credito
        '    plan = Plantilla.GetTipoPlantilla(2, 6).ToString

        '    If plan = "" Or plan Is DBNull.Value Then
        '        MsgBox("No hay plantilla disponible para realizar Esta Transacción", MsgBoxStyle.Information)
        '        Return False
        '        Exit Function
        '    End If

        '    Dim Detalles As VB.SysContab.PlantillaDetails = Plantilla.GetPlantillasDetails(plan)
        '    ds = Detalles.Detalles

        '    TipoCompr = Detalles.TipoCompr
        '    'Antes se enviaba de manera fija el valor '0' para la forma de pago, aunque no fuere una factura de contado, pq ??? se cambio al contenido del combobox TipoFactura RMPR: 09/04/2007,
        '    ' en el campo Tipo, se enviaba '0' y segun la tabla de Comprobantes, ese campo debe tener 1 si es factura de proveedor

        '    CompNo = Comprobantes.AddComprobante(TipoCompr, 1, "Comprobante de Orden de Pago #: " & Me.txtFactura.Text, _
        '                                         EmpresasDB.GetDetails(EmpresaActual).MonedaBase, PeriodosDB.Activo(dtpFecha.Value), Me.dtpFecha.Value, _
        '                                         0, "", False, Me.cbProveedor.SelectedValue, "", 1, Me.txtFactura.Text, VB.SysContab.Rutinas.Fecha, _
        '                                         Me.cbTipoFactura.EditValue, OrigenComprobantes.ENTRADA_ALMACEN)

        '    'Por que se cancelaba la factura al grabarse??? Rosa Maria 19/03/2007
        '    'Comprobantes.CancelarFactura(Me.txtFactura.Text, Me.cbProveedor.SelectedValue, 1)
        '    'For i = 0 To tCust.Rows.Count - 1
        '    '    If tCust.Rows(filas)("DC") = "Débito" Then
        '    '        Tipo = "D"
        '    '    Else
        '    '        Tipo = "C"
        '    '    End If

        '    If IIf(etIva.Text = "", 0, CDbl(etIva.Text)) <> 0 Then
        '        Comprobantes.AddComprobanteDetalles(CompNo, ds.Tables("PlantillasDetalles").Rows(0).Item("Cuenta"), _
        '                                            "I.V.A", Me.etIva.Text, 0, TipoCompr, "D", Me.txtFactura.Text, 0, _
        '                                            Me.dtpFecha.Value, 1, 1)
        '    End If
        '    'Agregar las lineas de las cuentas de los productos
        '    'Antes era: Comprobantes.AddComprobanteDetalles(CompNo, DetallesProducto.Cuenta, "", Me.etTotal.Text, 0, TipoCompr, "C", Me.txtFactura.Text, 0, Me.dtpFecha.Value, 1)
        '    Dim x As Integer
        '    For x = 0 To Cuentas.GetUpperBound(0)
        '        If Cuentas(x) <> "" Then
        '            Comprobantes.AddComprobanteDetalles(CompNo, Cuentas(x), "", Montos(x), 0, TipoCompr, "D", Me.txtFactura.Text, 0, Me.dtpFecha.Value, 1)
        '        End If
        '    Next

        '    'Dim Prove As String = ObtieneDatosTrans("SELECT NOMBRE FROM PROVEEDORES p WHERE p.Empresa = " & EmpresaActual & " AND p.CODIGO = " & Me.cbProveedor.SelectedValue).Rows.Item(0)(0)

        '    If IR_Pagado Then
        '        'Agregar la linea del I.R
        '        Comprobantes.AddComprobanteDetalles(CompNo, _
        '        ds.Tables("PlantillasDetalles").Rows(1).Item("Cuenta"), "I.R", _
        '        IRxPagar, 0, TipoCompr, "C", Me.txtFactura.Text, 0, Me.dtpFecha.Value, 1, 2)
        '    End If

        '    Comprobantes.AddComprobanteDetalles(CompNo, DetallesProveedor.Cuenta, DetallesProveedor.Nombre, _
        '                                            CDbl(Me.etTotal.Text) - IRxPagar - ValorIRAlcaldia, 0, TipoCompr, "C", _
        '                                            Me.txtFactura.Text, 0, Me.dtpFecha.Value, 0)


        '    'If Ir_Prod = True Or Ir_Serv = True Then
        '    '    If DetallesProveedor.Exento = False Then    'El Proveedor No es Exento de IR
        '    '        'If (etTotal.Text - etIva.Text) >= ConfigDetalles.MontoIR Then
        '    '        If Me.vFacturas.Columns("SubTotal").SummaryItem.SummaryValue >= ConfigDetalles.MontoIR Then
        '    '            'If CDbl((Me.etTotal.Text - IIf(IvaAsumido, (SubTotalParaIVA * (ConfigDetalles.IVA / 100.0)).ToString(Round), Me.etIva.Text))).ToString(Round) >= ConfigDetalles.MontoIR Then

        '    '            'Agregar la linea del I.R
        '    '            Comprobantes.AddComprobanteDetalles(CompNo, _
        '    '            ds.Tables("PlantillasDetalles").Rows(1).Item("Cuenta"), "I.R", _
        '    '             IRxPagar, 0, TipoCompr, "C", Me.txtFactura.Text, 0, Me.dtpFecha.Value, 1, 2)
        '    '        End If
        '    '        '*** Agregar Credito al Proveedor
        '    '        Comprobantes.AddComprobanteDetalles(CompNo, DetallesProveedor.Cuenta, DetallesProveedor.Nombre, _
        '    '                                            CDbl(Me.etTotal.Text) - IRxPagar - ValorIRAlcaldia, 0, TipoCompr, _
        '    '                                            "C", Me.txtFactura.Text, 0, Me.dtpFecha.Value, 0)
        '    '    Else
        '    '        Comprobantes.AddComprobanteDetalles(CompNo, DetallesProveedor.Cuenta, DetallesProveedor.Nombre, _
        '    '                                            Me.etTotal.Text - ValorIRAlcaldia, 0, TipoCompr, "C", _
        '    '                                            Me.txtFactura.Text, 0, Me.dtpFecha.Value, 0)
        '    '    End If
        '    'Else
        '    '    Comprobantes.AddComprobanteDetalles(CompNo, DetallesProveedor.Cuenta, DetallesProveedor.Nombre, _
        '    '                                        Me.etTotal.Text - IRxPagar - ValorIRAlcaldia, 0, TipoCompr, "C", _
        '    '                                        Me.txtFactura.Text, 0, Me.dtpFecha.Value, 0)
        '    'End If

        '    'If Ir_Prod = True Or Ir_Serv = True Then
        '    '    If DetallesProveedor.Exento = False Then    'El Proveedor es Exento de IR
        '    '        'If (etTotal.Text - etIva.Text) >= ConfigDetalles.MontoIR Then
        '    '        If CDbl((Me.etTotal.Text - IIf(IvaAsumido, (SubTotalParaIVA * (ConfigDetalles.IVA / 100.0)).ToString(Round), Me.etIva.Text))).ToString(Round) >= ConfigDetalles.MontoIR Then
        '    '            'Agregar la linea del IR
        '    '            Comprobantes.AddComprobanteDetalles(CompNo, _
        '    '            ds.Tables("PlantillasDetalles").Rows(1).Item("Cuenta"), "", _
        '    '             IRxPagar, _
        '    '            0, TipoCompr, "C", Me.txtFactura.Text, 0, Me.dtpFecha.Value, 1)
        '    '        End If
        '    '        Comprobantes.AddComprobanteDetalles(CompNo, DetallesProveedor.Cuenta, "", Me.etTotal.Text - IRxPagar - ValorIRAlcaldia, 0, TipoCompr, "C", Me.txtFactura.Text, 0, Me.dtpFecha.Value, 0)
        '    '    Else
        '    '        Comprobantes.AddComprobanteDetalles(CompNo, DetallesProveedor.Cuenta, "", Me.etTotal.Text - ValorIRAlcaldia, 0, TipoCompr, "C", Me.txtFactura.Text, 0, Me.dtpFecha.Value, 0)
        '    '    End If

        '    'End If

        '    If ValorIRAlcaldia > 0 Then
        '        Comprobantes.AddComprobanteDetalles(CompNo, _
        '                                ds.Tables("PlantillasDetalles").Rows(2).Item("Cuenta"), "I.R Alcadia", _
        '                                 ValorIRAlcaldia, _
        '                                0, TipoCompr, "C", Me.txtFactura.Text, 0, Me.dtpFecha.Value, 1, 3)

        '    End If

        '    ''End If
        '    Return True
        'End Function

        'Private Sub cbProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    If Not IsNumeric(Me.cbProveedor.SelectedValue) Then
        '        Exit Sub
        '    End If
        '    If Me.cbProveedor.SelectedValue Is Nothing Or IsNumeric(Me.cbProveedor.SelectedValue) = False Then
        '        txtRuc.Text = ""
        '        Me.txttel.Text = ""
        '        txtDireccion.Text = ""
        '        txtDepartamento.Text = ""
        '        txtMunicipio.Text = ""
        '        Exit Sub
        '    End If

        '    DetallesProveedor = ProveedoresDB.GetDetails(Me.cbProveedor.SelectedValue)

        '    Me.txtRuc.Text = DetallesProveedor.Ruc
        '    Me.txtDireccion.Text = DetallesProveedor.Direccion
        '    Me.txttel.Text = DetallesProveedor.Telefono
        '    If IsNumeric(DetallesProveedor.Departamento) = True Then
        '        Try
        '            Me.txtDepartamento.Text = ObtieneDatos("SELECT Nombre_Departamento FROM DepartamentosC WHERE Codigo_Departamento = " & DetallesProveedor.Departamento & " AND Empresa = " & EmpresaActual).Rows.Item(0)("Nombre_Departamento").ToString
        '            Me.txtMunicipio.Text = ObtieneDatos("SELECT Nombre_Municipio FROM Municipios WHERE Codigo_Departamento = " & DetallesProveedor.Departamento & " AND Codigo_Municipio = " & DetallesProveedor.Municipio).Rows.Item(0)("Nombre_Municipio").ToString
        '        Catch ex As Exception
        '        End Try
        '    End If
        'End Sub

        Private Sub vFacturas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vFacturas.DoubleClick
            If vFacturas.FocusedRowHandle < 0 Then Exit Sub
            '
            Dim f As frmDetalleArticulo = frmDetalleArticulo.Instance()
            f.Tipo = Me.vFacturas.GetFocusedRowCellValue("PIn")
            Registro = Me.vFacturas.GetFocusedRowCellValue("Codigo")

            f.MdiParent = Me.MdiParent
            f.Show()
            f.Text = "Acumulado"
        End Sub

        'Private Sub cmbformapago_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoFactura.EditValueChanged
        '    Try
        '        If IsNumeric(cbTipoFactura.EditValue) Then
        '            If Inicio = True Then
        '                Exit Sub
        '            End If

        '            If cbTipoFactura.EditValue = 0 Then
        '            Else
        '                TipoFactura = cbTipoFactura.EditValue.ToString
        '                dtpFechaPago.DateTime = dtpFecha.Value.AddDays(FormaPago.FormaPagoDias(cbTipoFactura.EditValue))
        '            End If
        '        End If
        '    Catch ex As Exception
        '    End Try
        'End Sub
    End Class

End Namespace


