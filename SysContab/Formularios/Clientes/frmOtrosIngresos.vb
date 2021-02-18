Imports System
Imports System.Data
Imports System.Data.SqlClient

'Namespace DataGridTextBoxCombo
Public Class l
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As l = Nothing

    Public Shared Function Instance() As l
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New l()
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
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents etBalance As System.Windows.Forms.Label
    Friend WithEvents etInicio As System.Windows.Forms.Label
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCheque As System.Windows.Forms.TextBox
    Friend WithEvents cbPagar1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmdRecalcular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtRuc As System.Windows.Forms.TextBox
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbPagar2 As System.Windows.Forms.ComboBox
    Friend WithEvents chkEfectivo As System.Windows.Forms.CheckBox
    Friend WithEvents chkCheque As System.Windows.Forms.CheckBox
    Friend WithEvents txtFactura As System.Windows.Forms.TextBox
    Friend WithEvents txtRecibo As System.Windows.Forms.TextBox
    Friend WithEvents chkRecibo As System.Windows.Forms.CheckBox
    Friend WithEvents cbBancos As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gridDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vComprobante As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbCatalogo As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbPagar As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents vista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtCaja As System.Windows.Forms.Label
    Friend WithEvents txtBanco As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents txtConcepto As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
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
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cbTipoComp1 As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(l))
        Me.dtpFecha = New DevExpress.XtraEditors.DateEdit()
        Me.txtBanco = New System.Windows.Forms.TextBox()
        Me.txtCaja = New System.Windows.Forms.Label()
        Me.cbPagar = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.vista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.chkRecibo = New System.Windows.Forms.CheckBox()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.chkCheque = New System.Windows.Forms.CheckBox()
        Me.chkEfectivo = New System.Windows.Forms.CheckBox()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.txtCheque = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtRecibo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbPagar1 = New System.Windows.Forms.ComboBox()
        Me.etInicio = New System.Windows.Forms.Label()
        Me.cbTipoComp1 = New System.Windows.Forms.ComboBox()
        Me.cbPagar2 = New System.Windows.Forms.ComboBox()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.etBalance = New System.Windows.Forms.Label()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdRecalcular = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cbBancos = New DevExpress.XtraEditors.LookUpEdit()
        Me.gridDatos = New DevExpress.XtraGrid.GridControl()
        Me.vComprobante = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbCatalogo = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
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
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtConcepto = New DevExpress.XtraEditors.MemoEdit()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.dtpFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbPagar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbBancos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vComprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpFecha
        '
        Me.dtpFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecha.EditValue = Nothing
        Me.dtpFecha.Location = New System.Drawing.Point(735, 38)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Properties.Appearance.Options.UseFont = True
        Me.dtpFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dtpFecha.Size = New System.Drawing.Size(144, 22)
        Me.dtpFecha.StyleController = Me.LayoutControl1
        Me.dtpFecha.TabIndex = 169
        '
        'txtBanco
        '
        Me.txtBanco.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBanco.Enabled = False
        Me.txtBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBanco.Location = New System.Drawing.Point(687, 160)
        Me.txtBanco.MaxLength = 60
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(192, 20)
        Me.txtBanco.TabIndex = 160
        '
        'txtCaja
        '
        Me.txtCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCaja.Location = New System.Drawing.Point(12, 38)
        Me.txtCaja.Name = "txtCaja"
        Me.txtCaja.Size = New System.Drawing.Size(247, 21)
        Me.txtCaja.TabIndex = 160
        Me.txtCaja.Text = "Caja"
        Me.txtCaja.Visible = False
        '
        'cbPagar
        '
        Me.cbPagar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbPagar.Location = New System.Drawing.Point(100, 38)
        Me.cbPagar.Name = "cbPagar"
        Me.cbPagar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPagar.Properties.Appearance.Options.UseFont = True
        Me.cbPagar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPagar.Properties.NullText = "[Seleccione Cliente]"
        Me.cbPagar.Properties.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.cbPagar.Properties.PopupView = Me.vista
        Me.cbPagar.Size = New System.Drawing.Size(543, 22)
        Me.cbPagar.StyleController = Me.LayoutControl1
        Me.cbPagar.TabIndex = 168
        '
        'vista
        '
        Me.vista.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.vista.Name = "vista"
        Me.vista.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.vista.OptionsView.ShowGroupPanel = False
        '
        'chkRecibo
        '
        Me.chkRecibo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkRecibo.Checked = True
        Me.chkRecibo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRecibo.ForeColor = System.Drawing.Color.Black
        Me.chkRecibo.Location = New System.Drawing.Point(637, 88)
        Me.chkRecibo.Name = "chkRecibo"
        Me.chkRecibo.Size = New System.Drawing.Size(76, 20)
        Me.chkRecibo.TabIndex = 166
        Me.chkRecibo.Text = "Recibo"
        Me.chkRecibo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFactura
        '
        Me.txtFactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactura.Location = New System.Drawing.Point(717, 64)
        Me.txtFactura.MaxLength = 13
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(162, 20)
        Me.txtFactura.TabIndex = 164
        '
        'chkCheque
        '
        Me.chkCheque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCheque.ForeColor = System.Drawing.Color.Black
        Me.chkCheque.Location = New System.Drawing.Point(803, 112)
        Me.chkCheque.Name = "chkCheque"
        Me.chkCheque.Size = New System.Drawing.Size(76, 20)
        Me.chkCheque.TabIndex = 163
        Me.chkCheque.Text = "Cheque"
        Me.chkCheque.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkEfectivo
        '
        Me.chkEfectivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEfectivo.ForeColor = System.Drawing.Color.Black
        Me.chkEfectivo.Location = New System.Drawing.Point(687, 112)
        Me.chkEfectivo.Name = "chkEfectivo"
        Me.chkEfectivo.Size = New System.Drawing.Size(112, 20)
        Me.chkEfectivo.TabIndex = 162
        Me.chkEfectivo.Text = "Efectivo"
        '
        'txtRuc
        '
        Me.txtRuc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.Location = New System.Drawing.Point(382, 88)
        Me.txtRuc.MaxLength = 50
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(251, 20)
        Me.txtRuc.TabIndex = 159
        '
        'txtCheque
        '
        Me.txtCheque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheque.Location = New System.Drawing.Point(687, 136)
        Me.txtCheque.MaxLength = 13
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(192, 20)
        Me.txtCheque.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(100, 64)
        Me.txtNombre.MaxLength = 60
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(525, 20)
        Me.txtNombre.TabIndex = 2
        '
        'txtMonto
        '
        Me.txtMonto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMonto.BackColor = System.Drawing.SystemColors.Info
        Me.txtMonto.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.ForeColor = System.Drawing.Color.DarkRed
        Me.txtMonto.Location = New System.Drawing.Point(100, 88)
        Me.txtMonto.MaxLength = 13
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.ReadOnly = True
        Me.txtMonto.Size = New System.Drawing.Size(163, 20)
        Me.txtMonto.TabIndex = 5
        Me.txtMonto.Text = "0.00"
        '
        'txtRecibo
        '
        Me.txtRecibo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecibo.Location = New System.Drawing.Point(717, 88)
        Me.txtRecibo.MaxLength = 13
        Me.txtRecibo.Name = "txtRecibo"
        Me.txtRecibo.Size = New System.Drawing.Size(162, 20)
        Me.txtRecibo.TabIndex = 155
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(12, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 21)
        Me.Label9.TabIndex = 158
        Me.Label9.Text = "Tipo:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.Visible = False
        '
        'cbPagar1
        '
        Me.cbPagar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPagar1.Location = New System.Drawing.Point(120, 38)
        Me.cbPagar1.Name = "cbPagar1"
        Me.cbPagar1.Size = New System.Drawing.Size(889, 21)
        Me.cbPagar1.TabIndex = 156
        Me.cbPagar1.Visible = False
        '
        'etInicio
        '
        Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etInicio.Location = New System.Drawing.Point(12, 38)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(579, 21)
        Me.etInicio.TabIndex = 155
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
        '
        'cbTipoComp1
        '
        Me.cbTipoComp1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoComp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoComp1.Location = New System.Drawing.Point(911, 38)
        Me.cbTipoComp1.Name = "cbTipoComp1"
        Me.cbTipoComp1.Size = New System.Drawing.Size(98, 21)
        Me.cbTipoComp1.TabIndex = 151
        Me.cbTipoComp1.Visible = False
        '
        'cbPagar2
        '
        Me.cbPagar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPagar2.Location = New System.Drawing.Point(120, 38)
        Me.cbPagar2.Name = "cbPagar2"
        Me.cbPagar2.Size = New System.Drawing.Size(889, 21)
        Me.cbPagar2.TabIndex = 157
        Me.cbPagar2.Visible = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.ImageOptions.SvgImage = CType(resources.GetObject("cmdAceptar.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.cmdAceptar.Location = New System.Drawing.Point(12, 437)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(111, 36)
        Me.cmdAceptar.StyleController = Me.LayoutControl1
        Me.cmdAceptar.TabIndex = 8
        Me.cmdAceptar.Text = "&Guardar"
        '
        'etBalance
        '
        Me.etBalance.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etBalance.Location = New System.Drawing.Point(682, 12)
        Me.etBalance.Name = "etBalance"
        Me.etBalance.Size = New System.Drawing.Size(197, 22)
        Me.etBalance.TabIndex = 147
        Me.etBalance.Text = "0"
        Me.etBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etBalance.Visible = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Appearance.Options.UseFont = True
        Me.cmdSalir.ImageOptions.SvgImage = CType(resources.GetObject("cmdSalir.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.cmdSalir.Location = New System.Drawing.Point(768, 437)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(111, 36)
        Me.cmdSalir.StyleController = Me.LayoutControl1
        Me.cmdSalir.TabIndex = 11
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdRecalcular
        '
        Me.cmdRecalcular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdRecalcular.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRecalcular.Appearance.Options.UseFont = True
        Me.cmdRecalcular.ImageOptions.SvgImage = CType(resources.GetObject("cmdRecalcular.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.cmdRecalcular.Location = New System.Drawing.Point(127, 437)
        Me.cmdRecalcular.Name = "cmdRecalcular"
        Me.cmdRecalcular.Size = New System.Drawing.Size(111, 36)
        Me.cmdRecalcular.StyleController = Me.LayoutControl1
        Me.cmdRecalcular.TabIndex = 10
        Me.cmdRecalcular.Text = "&Recalcular"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImprimir.Appearance.Options.UseFont = True
        Me.cmdImprimir.Location = New System.Drawing.Point(637, 536)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(121, 22)
        Me.cmdImprimir.StyleController = Me.LayoutControl1
        Me.cmdImprimir.TabIndex = 9
        Me.cmdImprimir.Text = "&Imprimir"
        Me.cmdImprimir.Visible = False
        '
        'cbBancos
        '
        Me.cbBancos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbBancos.Location = New System.Drawing.Point(100, 12)
        Me.cbBancos.Name = "cbBancos"
        Me.cbBancos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBancos.Properties.Appearance.Options.UseFont = True
        Me.cbBancos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbBancos.Properties.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.cbBancos.Size = New System.Drawing.Size(490, 22)
        Me.cbBancos.StyleController = Me.LayoutControl1
        Me.cbBancos.TabIndex = 155
        '
        'gridDatos
        '
        Me.gridDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDatos.Location = New System.Drawing.Point(12, 184)
        Me.gridDatos.MainView = Me.vComprobante
        Me.gridDatos.Name = "gridDatos"
        Me.gridDatos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbCatalogo})
        Me.gridDatos.Size = New System.Drawing.Size(867, 249)
        Me.gridDatos.TabIndex = 156
        Me.gridDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vComprobante})
        '
        'vComprobante
        '
        Me.vComprobante.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn12, Me.GridColumn13})
        Me.vComprobante.GridControl = Me.gridDatos
        Me.vComprobante.Name = "vComprobante"
        Me.vComprobante.OptionsCustomization.AllowColumnMoving = False
        Me.vComprobante.OptionsCustomization.AllowColumnResizing = False
        Me.vComprobante.OptionsCustomization.AllowFilter = False
        Me.vComprobante.OptionsCustomization.AllowSort = False
        Me.vComprobante.OptionsFilter.AllowFilterEditor = False
        Me.vComprobante.OptionsView.EnableAppearanceEvenRow = True
        Me.vComprobante.OptionsView.EnableAppearanceOddRow = True
        Me.vComprobante.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.vComprobante.OptionsView.ShowFooter = True
        Me.vComprobante.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.Caption = "Cuenta"
        Me.GridColumn2.ColumnEdit = Me.cbCatalogo
        Me.GridColumn2.FieldName = "Cuenta"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 425
        '
        'cbCatalogo
        '
        Me.cbCatalogo.AutoHeight = False
        Me.cbCatalogo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo.DisplayMember = "Display"
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.NullText = ""
        Me.cbCatalogo.PopupFormMinSize = New System.Drawing.Size(700, 0)
        Me.cbCatalogo.PopupView = Me.GridView2
        Me.cbCatalogo.ValueMember = "Cuenta"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cuenta"
        Me.GridColumn1.FieldName = "Cuenta"
        Me.GridColumn1.MinWidth = 100
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 100
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Nombre"
        Me.GridColumn8.FieldName = "Nombre"
        Me.GridColumn8.MinWidth = 250
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        Me.GridColumn8.Width = 250
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Display"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Nombre Completo"
        Me.GridColumn10.FieldName = "NombreCompleto"
        Me.GridColumn10.MinWidth = 350
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 2
        Me.GridColumn10.Width = 350
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn12.AppearanceHeader.Options.UseFont = True
        Me.GridColumn12.Caption = "Monto"
        Me.GridColumn12.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn12.FieldName = "Credito"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Credito", "{0:n2}")})
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 1
        Me.GridColumn12.Width = 99
        '
        'GridColumn13
        '
        Me.GridColumn13.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn13.AppearanceHeader.Options.UseFont = True
        Me.GridColumn13.Caption = "Concepto"
        Me.GridColumn13.FieldName = "Concepto"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 2
        Me.GridColumn13.Width = 343
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cmdImprimir)
        Me.LayoutControl1.Controls.Add(Me.cmdSalir)
        Me.LayoutControl1.Controls.Add(Me.cmdRecalcular)
        Me.LayoutControl1.Controls.Add(Me.cmdAceptar)
        Me.LayoutControl1.Controls.Add(Me.txtCaja)
        Me.LayoutControl1.Controls.Add(Me.txtBanco)
        Me.LayoutControl1.Controls.Add(Me.gridDatos)
        Me.LayoutControl1.Controls.Add(Me.dtpFecha)
        Me.LayoutControl1.Controls.Add(Me.chkRecibo)
        Me.LayoutControl1.Controls.Add(Me.chkCheque)
        Me.LayoutControl1.Controls.Add(Me.txtConcepto)
        Me.LayoutControl1.Controls.Add(Me.chkEfectivo)
        Me.LayoutControl1.Controls.Add(Me.txtCheque)
        Me.LayoutControl1.Controls.Add(Me.txtFactura)
        Me.LayoutControl1.Controls.Add(Me.cbPagar)
        Me.LayoutControl1.Controls.Add(Me.etBalance)
        Me.LayoutControl1.Controls.Add(Me.etInicio)
        Me.LayoutControl1.Controls.Add(Me.cbPagar1)
        Me.LayoutControl1.Controls.Add(Me.cbBancos)
        Me.LayoutControl1.Controls.Add(Me.txtRecibo)
        Me.LayoutControl1.Controls.Add(Me.Label9)
        Me.LayoutControl1.Controls.Add(Me.cbPagar2)
        Me.LayoutControl1.Controls.Add(Me.txtRuc)
        Me.LayoutControl1.Controls.Add(Me.cbTipoComp1)
        Me.LayoutControl1.Controls.Add(Me.txtNombre)
        Me.LayoutControl1.Controls.Add(Me.txtMonto)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem26, Me.LayoutControlItem3, Me.LayoutControlItem21, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1105, 379, 650, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(891, 485)
        Me.LayoutControl1.TabIndex = 160
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem18, Me.LayoutControlItem19, Me.LayoutControlItem20, Me.LayoutControlItem17, Me.LayoutControlItem22, Me.LayoutControlItem23, Me.LayoutControlItem24, Me.LayoutControlItem25, Me.EmptySpaceItem1, Me.LayoutControlItem14, Me.LayoutControlItem13, Me.EmptySpaceItem2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(891, 485)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cbBancos
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(582, 26)
        Me.LayoutControlItem1.Text = "Caja:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.etBalance
        Me.LayoutControlItem2.Location = New System.Drawing.Point(582, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(289, 26)
        Me.LayoutControlItem2.Text = "Balance:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Label9
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(125, 25)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.etInicio
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(583, 25)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cbTipoComp1
        Me.LayoutControlItem5.Location = New System.Drawing.Point(791, 26)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(210, 25)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(96, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cbPagar2
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(1001, 25)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(96, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cbPagar1
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(1001, 25)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(96, 20)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cbPagar
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(635, 26)
        Me.LayoutControlItem8.Text = "Cobrar a:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtNombre
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(617, 24)
        Me.LayoutControlItem9.Text = "Nombre:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtMonto
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 76)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(255, 24)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(255, 24)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(255, 24)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.Text = "Monto:"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txtRuc
        Me.LayoutControlItem11.Location = New System.Drawing.Point(282, 76)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(343, 24)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(343, 24)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(343, 24)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.Text = "RUC / Cédula:"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(76, 13)
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(100, 112)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(495, 68)
        Me.txtConcepto.StyleController = Me.LayoutControl1
        Me.txtConcepto.TabIndex = 169
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtConcepto
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 100)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(0, 72)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(102, 72)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(587, 72)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.Text = "Concepto:"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.dtpFecha
        Me.LayoutControlItem13.Location = New System.Drawing.Point(635, 26)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.Text = "Fecha:"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtFactura
        Me.LayoutControlItem14.Location = New System.Drawing.Point(617, 52)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(254, 24)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(254, 24)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(254, 24)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.Text = "Factura:"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.txtRecibo
        Me.LayoutControlItem15.Location = New System.Drawing.Point(705, 76)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(166, 24)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(166, 24)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(166, 24)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.chkRecibo
        Me.LayoutControlItem16.Location = New System.Drawing.Point(625, 76)
        Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(80, 24)
        Me.LayoutControlItem16.MinSize = New System.Drawing.Size(80, 24)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(80, 24)
        Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.chkEfectivo
        Me.LayoutControlItem17.Location = New System.Drawing.Point(587, 100)
        Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(204, 24)
        Me.LayoutControlItem17.MinSize = New System.Drawing.Size(204, 24)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(204, 24)
        Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem17.Text = "Forma de Pago:"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.chkCheque
        Me.LayoutControlItem18.Location = New System.Drawing.Point(791, 100)
        Me.LayoutControlItem18.MaxSize = New System.Drawing.Size(80, 24)
        Me.LayoutControlItem18.MinSize = New System.Drawing.Size(80, 24)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(80, 24)
        Me.LayoutControlItem18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.txtCheque
        Me.LayoutControlItem19.Location = New System.Drawing.Point(587, 124)
        Me.LayoutControlItem19.MaxSize = New System.Drawing.Size(284, 24)
        Me.LayoutControlItem19.MinSize = New System.Drawing.Size(284, 24)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(284, 24)
        Me.LayoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem19.Text = "No. de Cheque:"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.txtBanco
        Me.LayoutControlItem20.Location = New System.Drawing.Point(587, 148)
        Me.LayoutControlItem20.MaxSize = New System.Drawing.Size(284, 24)
        Me.LayoutControlItem20.MinSize = New System.Drawing.Size(284, 24)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(284, 24)
        Me.LayoutControlItem20.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem20.Text = "Banco:"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.txtCaja
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(251, 25)
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem21.TextVisible = False
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.gridDatos
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 172)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(871, 253)
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem22.TextVisible = False
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.cmdAceptar
        Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 425)
        Me.LayoutControlItem23.MaxSize = New System.Drawing.Size(115, 40)
        Me.LayoutControlItem23.MinSize = New System.Drawing.Size(115, 40)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(115, 40)
        Me.LayoutControlItem23.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem23.TextVisible = False
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.cmdRecalcular
        Me.LayoutControlItem24.Location = New System.Drawing.Point(115, 425)
        Me.LayoutControlItem24.MaxSize = New System.Drawing.Size(115, 40)
        Me.LayoutControlItem24.MinSize = New System.Drawing.Size(115, 40)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(115, 40)
        Me.LayoutControlItem24.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem24.TextVisible = False
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.cmdSalir
        Me.LayoutControlItem25.Location = New System.Drawing.Point(756, 425)
        Me.LayoutControlItem25.MaxSize = New System.Drawing.Size(115, 40)
        Me.LayoutControlItem25.MinSize = New System.Drawing.Size(115, 40)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(115, 40)
        Me.LayoutControlItem25.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem25.TextVisible = False
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.cmdImprimir
        Me.LayoutControlItem26.Location = New System.Drawing.Point(625, 524)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(125, 40)
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem26.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(230, 425)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(526, 40)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(255, 76)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(27, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'l
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(891, 485)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "l"
        Me.Text = "Registro de Otros Ingresos"
        CType(Me.dtpFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbPagar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbBancos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vComprobante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim WithEvents tCust As DataTable
    Private WithEvents myDataSet As DataSet
    Dim ds As DataSet

    'Dim WithEvents Codigo1 As DataGridComboBoxColumn
    'Dim WithEvents Codigo As DataGridComboBoxColumn
    'Dim WithEvents Descripcion As DataGridComboBoxColumn
    Dim Monto As DataGridTextBoxColumn

    Dim CatalogoBancos As New VB.SysContab.Catalogo_BancosDB()
    Dim Proveedores As New VB.SysContab.ProveedoresDB()
    Dim ProveedoresDetalles As New VB.SysContab.ProveedoresDetails()
    Dim Catalogo As New VB.SysContab.CatalogoDB()
    Private Comprobantes As New VB.SysContab.ComprobanteDB()
    Dim PeriodosDB As New VB.SysContab.PeriodosDB()
    Dim Clientes As New VB.SysContab.ClientesDB()
    Dim ClientesDetalle As New VB.SysContab.ClientesDetails
    Dim CatBancos As New VB.SysContab.Catalogo_BancosDB()
    Dim r As New VB.SysContab.Rutinas()
    Dim Config As New VB.SysContab.ConfiguracionDB()
    Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails()
    'Dim dsCB As DataSet


    Dim d As Integer
    Dim dd As String
    Dim Digitos As Integer
    Dim Fechas As New VB.SysContab.FechasdeTrabajo
    Dim TipoCOmpr As String

    Private DT_Distribucion As DataTable = New DataTable("Distribucion")
    Dim NoComprob As Double

    Private Sub Distribucion()
        DT_Distribucion = CargaDistribucion(0, 0, 0)
    End Sub

    Private Sub frmOtrosIngresos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ConfigDetalles = Config.GetConfigDetails
        'Digitos = ConfigDetalles.ReciboDigitos

        'For d = 0 To Digitos - 1
        '    dd = dd & "0"
        'Next
        'If Clientes.GenerarRecibo.Tables("Cobros").Rows.Count = 0 Then
        '    txtRecibo.Text = Format(ConfigDetalles.ReciboNumero, dd)
        'Else
        '    txtRecibo.Text = Format(Clientes.GenerarRecibo.Tables("Cobros").Rows(0).Item("Recibo") + 1, dd)
        'End If

        'Dim Clientes As New VB.SysContab.ClientesDB
        ConfigDetalles = Config.GetConfigDetails

        For d As Integer = 0 To ConfigDetalles.ReciboDigitos - 1
            dd = dd & "0"
        Next

        If Clientes.GenerarRecibo.Tables("Cobros").Rows.Count = 0 Then
            txtRecibo.Text = Format(ConfigDetalles.ReciboNumero, dd)
        Else
            txtRecibo.Text = Format(Clientes.GenerarRecibo.Tables("Cobros").Rows(0).Item("Recibo") + 1, dd)
        End If

        Cargar()

        Try
            Dim Plantilla As New VB.SysContab.PlantillaDB
            TipoCOmpr = Plantilla.GetPlantillasDetails(4, 3).TipoCompr
        Catch ex As Exception
            XtraMsg("No Existe Plantilla Contable Configurada para realizar esta trasacción", MessageBoxIcon.Error)
            Exit Sub
        End Try

        Me.chkEfectivo.Checked = True

        'Me.dtpFecha.MinDate = Fechas.FechaMinima 'VB.SysContab.PeriodosDB.GetDetails(VB.SysContab.PeriodosDB.Activo).Inicio
        'Me.dtpFecha.MaxDate = Fechas.FechaMaxima 'VB.SysContab.PeriodosDB.GetDetails(VB.SysContab.PeriodosDB.Activo).Final
        'Dim Fecha As Date

        'Fecha = CDate(VB.SysContab.Rutinas.Fecha)
        'If Me.dtpFecha.MaxDate > Fecha Then Me.dtpFecha.Value = Fecha

        dtpFecha.DateTime = VB.SysContab.Rutinas.Fecha().Date

        'Me.etMontoLetras.Text = r.ConversionDecimales(0)

        'MakeDataSet()
        'dgCatalogo.SetDataBinding(myDataSet, "Articulos")
        'AddCustomDataTableStyle()

        LeaveCommit = False
        BuscarCombo = False

        'SetTiempos(OrigenComprobantes.OTROS_INGRESOS, funciones.Tiempos.TiempoInicio, Now, funciones.Eventos.Inicia, Me.txtRecibo.Text)

        Distribucion()
    End Sub

    Sub Cargar()
        'Me.cbBancos.DataSource = Catalogo.CatalogoList("A", 1).Tables("CATALOGO")
        'Me.cbBancos.ValueMember = "Cuenta"
        'Me.cbBancos.DisplayMember = "Nombre"

        'Me.cbPagar.DataSource = Clientes.GetList().Tables("Clientes") 'Proveedores.PagarList().Tables("Proveedores")
        'Me.cbPagar.ValueMember = "Codigo"
        'Me.cbPagar.DisplayMember = "Nombre"

        GetCajaBanco(Me.cbBancos)
        'GetClientesList(Me.cbPagar)
        GetCatalogoClientes(Me.cbPagar, vista)
        'cbPagar.Properties.HeaderClickMode = DevExpress.XtraEditors.Controls.HeaderClickMode.AutoSearch 'Para radioshack

        cbCatalogo.DataSource = ObtieneDatos("_GetCatalogo_CuentaActivo", EmpresaActual)
        gridDatos.DataSource = ObtieneDatos("SELECT '' Cuenta, 0.00 Credito, '' Concepto WHERE 0=1")

        FormatoGrid(vComprobante, 2, 0, False, True, False)
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        'Verificar Cierre del Día
        '---------------------------------------------------------------------
        If Not VerificarCierre(dtpFecha.DateTime.Date) Then
            Exit Sub
        End If
        '---------------------------------------------------------------------

        If Guardar() = False Then
            Exit Sub
        End If

        Dim f As frmOtrosIngresosList = frmOtrosIngresosList.Instance()
        f.Buscar()

        Close()


        'Me.txtDocumento.Text = ""
        'Me.txtMonto.Text = "0.00"
        'Me.cbPagar.EditValue = 0
        'Me.txtNombre.Text = ""
        'Me.txtConcepto.Text = ""
        'Me.txtCheque.Text = ""
        'Me.txtFactura.Text = ""
        'Cargar()
        'If Me.chkRecibo.Checked = True Then
        '    txtRecibo.Text = Format(Clientes.GenerarRecibo.Tables("Cobros").Rows(0).Item("Recibo") + 1, dd)
        'Else
        '    Me.txtRecibo.Text = ""
        'End If
        'Me.etMontoLetras.Text = r.ConversionDecimales(CDbl(Me.txtMonto.Text))
        'dsCB = CatBancos.CatalogoBancosXCuenta(Me.cbBancos.SelectedValue)
        'Me.txtCheque.Text = CatBancos.GetCheque(dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Banco"), dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Numero_Cuenta")).ToString
        'Me.etBalance.Text = CDbl(VB.SysContab.ComprobanteDB.SaldoxCuenta(Me.cbBancos.EditValue, VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.Value))).ToString(Round)
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    'Private Sub MakeDataSet()
    '    myDataSet = New DataSet("myDataSet")

    '    tCust = New DataTable("Articulos")

    '    Dim cCodigo1 As DataColumn
    '    cCodigo1 = New DataColumn("Codigo1")

    '    Dim cCodigo As DataColumn
    '    cCodigo = New DataColumn("Codigo")

    '    Dim cDescripcion As DataColumn
    '    cDescripcion = New DataColumn("Descripcion")

    '    Dim cMonto As DataColumn
    '    cMonto = New DataColumn("Monto")

    '    Dim cConcepto As DataColumn
    '    cConcepto = New DataColumn("Concepto")

    '    tCust.Columns.Add(cCodigo1)
    '    tCust.Columns.Add(cCodigo)
    '    tCust.Columns.Add(cDescripcion)
    '    tCust.Columns.Add(cMonto)
    '    tCust.Columns.Add(cConcepto)
    '    myDataSet.Tables.Add(tCust)

    '    Dim newRow1 As DataRow

    'End Sub

    'Private Sub AddCustomDataTableStyle()

    '    'Dim ts1 As DataGridTableStyle
    '    'ts1 = New DataGridTableStyle()
    '    'ts1.MappingName = "Articulos"
    '    'ts1.AlternatingBackColor = Color.LightBlue

    '    'Dim colCount As Integer
    '    'colCount = 0

    '    'Codigo1 = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))
    '    'Codigo1.MappingName = "Codigo1"
    '    'Codigo1.HeaderText = ""
    '    'Codigo1.Width = 0

    '    'ts1.GridColumnStyles.Add(Codigo1)
    '    'ts1.PreferredRowHeight = (Codigo1.ColumnComboBox.Height + 3)

    '    'Codigo1.NullText = ""

    '    'colCount = (colCount + 1)

    '    'Codigo = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))
    '    'Codigo.MappingName = "Codigo"
    '    'Codigo.HeaderText = "Cuenta"
    '    'Codigo.Width = 350

    '    'ts1.GridColumnStyles.Add(Codigo)
    '    'ts1.PreferredRowHeight = (Codigo.ColumnComboBox.Height + 3)

    '    'Codigo.NullText = ""

    '    'colCount = (colCount + 1)

    '    'Descripcion = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))
    '    'Descripcion.MappingName = "Descripcion"
    '    'Descripcion.HeaderText = "Nombre"
    '    'Descripcion.Width = 300

    '    'ts1.GridColumnStyles.Add(Descripcion)
    '    'ts1.PreferredRowHeight = (Descripcion.ColumnComboBox.Height + 3)

    '    'Descripcion.NullText = ""
    '    'colCount = (colCount + 1)

    '    'Monto = New DataGridTextBoxColumn()
    '    'Monto.MappingName = "Monto"
    '    'Monto.HeaderText = "Monto"
    '    'Monto.Width = 100
    '    'Monto.Alignment = HorizontalAlignment.Right
    '    'Monto.ReadOnly = False

    '    'AddHandler Monto.TextBox.Leave, New EventHandler(AddressOf TextBoxMontoLeaveHandler)

    '    'ts1.GridColumnStyles.Add(Monto)
    '    'colCount = (colCount + 1)

    '    'Monto.NullText = "0.00"

    '    'Dim Concepto As DataGridTextBoxColumn
    '    'Concepto = New DataGridTextBoxColumn()
    '    'Concepto.MappingName = "Concepto"
    '    'Concepto.HeaderText = "Descripción"
    '    'Concepto.Width = 210
    '    'Concepto.Alignment = HorizontalAlignment.Left
    '    'Concepto.ReadOnly = False

    '    'ts1.GridColumnStyles.Add(Concepto)
    '    'colCount = (colCount + 1)

    '    'Concepto.NullText = ""


    '    'Dim i As Long
    '    'ds = Catalogo.CatalogoList1("A")
    '    'For i = 0 To ds.Tables("CATALOGO").Rows.Count - 1
    '    '    Codigo1.ColumnComboBox.Items.Add(ds.Tables("CATALOGO").Rows(i).Item("Cuenta"))
    '    '    Codigo.ColumnComboBox.Items.Add(ds.Tables("CATALOGO").Rows(i).Item("Cuenta") & " - " & ds.Tables("CATALOGO").Rows(i).Item("Nombre"))
    '    '    Descripcion.ColumnComboBox.Items.Add(ds.Tables("CATALOGO").Rows(i).Item("Nombre"))
    '    'Next

    '    'Codigo.ColumnComboBox.DropDownStyle = ComboBoxStyle.DropDown

    '    'Descripcion.ColumnComboBox.DropDownStyle = ComboBoxStyle.DropDown

    '    'ts1.GridLineColor = Color.FromArgb(70, 130, 180)
    '    'ts1.AllowSorting = False
    '    'ts1.HeaderFont = Me.dgCatalogo.HeaderFont
    '    'ts1.HeaderBackColor = Color.LightSteelBlue
    '    'Me.dgCatalogo.CaptionVisible = False

    '    'Me.dgCatalogo.TableStyles.Clear()
    '    'Me.dgCatalogo.TableStyles.Add(ts1)

    'End Sub

    'Public Sub MyComboValueChanged(ByVal rowChanging As Integer, ByVal newValue As Object)
    '    'Console.WriteLine("index changed {0} {1}", rowChanging, newValue)

    '    'Try
    '    '    If Indice >= 0 Then
    '    '        If tCust.Rows.Count < rowChanging + 1 Then
    '    '            Dim newRow1 As DataRow
    '    '            newRow1 = tCust.NewRow
    '    '            newRow1("Codigo") = Codigo.ColumnComboBox.Items.Item(Indice)
    '    '            tCust.Rows.Add(newRow1)

    '    '            tCust.Rows(rowChanging)("Codigo1") = Codigo1.ColumnComboBox.Items.Item(Indice)
    '    '            tCust.Rows(rowChanging)("Descripcion") = Descripcion.ColumnComboBox.Items.Item(Indice)

    '    '            If rowChanging = 0 And tCust.Rows.Count = 1 Then
    '    '                tCust.Rows(rowChanging)("Monto") = CDbl(Me.txtMonto.Text).ToString(Round)
    '    '            End If
    '    '        Else
    '    '            tCust.Rows(rowChanging)("Codigo1") = Codigo1.ColumnComboBox.Items.Item(Indice)
    '    '            tCust.Rows(rowChanging)("Codigo") = Codigo.ColumnComboBox.Items.Item(Indice)
    '    '            tCust.Rows(rowChanging)("Descripcion") = Descripcion.ColumnComboBox.Items.Item(Indice)

    '    '        End If

    '    '    End If
    '    'Catch ex As Exception
    '    '    MsgBox(ex.Message & "MyComboValueChanged")
    '    'End Try

    'End Sub

    'Private Sub Evento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    'End Sub

    'Private Sub TextBoxMontoLeaveHandler(ByVal sender As Object, ByVal e As EventArgs)
    '    Try
    '        Monto.TextBox.Text = CDbl(Monto.TextBox.Text).ToString(Round)

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Exit Sub
    '        If Me.dgCatalogo.Item(Me.dgCatalogo.CurrentRowIndex, 2) Is DBNull.Value Then
    '            Monto.TextBox.Text = "0.00"
    '        Else
    '            Monto.TextBox.Text = CDbl(Me.dgCatalogo.Item(Me.dgCatalogo.CurrentRowIndex, 2)).ToString(Round) 'CDbl(tCust.Rows(Me.dgCatalogo.CurrentRowIndex)("Monto")).ToString(Round) 'ValorActualCantidad
    '        End If

    '        MsgBox("Introduzca un monto válido", MsgBoxStyle.Information)
    '        Me.dgCatalogo.Focus()
    '        Monto.TextBox.Focus()
    '        Exit Sub

    '    End Try
    'End Sub

    Private Sub txtMonto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMonto.Leave
        If Trim(Me.txtMonto.Text) = "" Then
            Me.txtMonto.Text = "0.00"
        End If

        If Not IsNumeric(Me.txtMonto.Text) Then
            MsgBox("Introduzca un valor númerico", MsgBoxStyle.Information)
            Me.txtMonto.Focus()
            Me.txtMonto.SelectAll()
            Exit Sub
        End If

        Me.txtMonto.Text = CDbl(Me.txtMonto.Text).ToString(Round)
        'Me.etMontoLetras.Text = r.ConversionDecimales(CDbl(Me.txtMonto.Text))
    End Sub

    Private Sub txtCheque_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCheque.KeyPress
        If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
            If Char.IsDigit(e.KeyChar) = False Then
                e.Handled = True
                Exit Sub
            End If
        End If
    End Sub

    Private Sub cmdRecalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRecalcular.Click
        'Dim i As Integer
        'Dim Total As Double
        'Total = 0

        'For i = 0 To tCust.Rows.Count - 1
        '    If (tCust.Rows(tCust.Rows.Count - 1)("Codigo1").ToString = "" Or tCust.Rows(tCust.Rows.Count - 1)("Codigo1") Is DBNull.Value) And (tCust.Rows(tCust.Rows.Count - 1)("Codigo").ToString = "" Or tCust.Rows(tCust.Rows.Count - 1)("Codigo") Is DBNull.Value) And (tCust.Rows(tCust.Rows.Count - 1)("Descripcion").ToString = "" Or tCust.Rows(tCust.Rows.Count - 1)("Descripcion") Is DBNull.Value) And (tCust.Rows(tCust.Rows.Count - 1)("Monto").ToString = "" Or tCust.Rows(tCust.Rows.Count - 1)("Monto") Is DBNull.Value) And (tCust.Rows(tCust.Rows.Count - 1)("Concepto").ToString = "" Or tCust.Rows(tCust.Rows.Count - 1)("Concepto") Is DBNull.Value) Then
        '        tCust.Rows(tCust.Rows.Count - 1).Delete()
        '    End If
        'Next

        'For i = 0 To tCust.Rows.Count - 1
        '    If tCust.Rows(i)("Codigo1") Is DBNull.Value Or tCust.Rows(i)("Codigo1").ToString = "" Then
        '        MsgBox("Especifique una cuenta en la linea " & i + 1, MsgBoxStyle.Information)
        '        Me.dgCatalogo.Focus()
        '        Codigo.TextBox.Focus()
        '        Exit Sub
        '    Else
        '        If tCust.Rows(i)("Monto") Is DBNull.Value Then
        '            '
        '        Else
        '            Total = Total + CDbl(tCust.Rows(i)("Monto"))
        '        End If

        '    End If
        'Next

        'Me.txtMonto.Text = Total.ToString(Round)
        ''Me.etMontoLetras.Text = r.ConversionDecimales(CDbl(Me.txtMonto.Text))

        Recalcular()
    End Sub

    Sub Recalcular()
        Me.txtMonto.Text = CDbl(Me.vComprobante.Columns("Credito").SummaryItem.SummaryValue).ToString(Round)
    End Sub

    Private Function Guardar() As Boolean

        Recalcular()

        If Me.cbBancos.EditValue = "0" Then
            XtraMsg("Seleccione la Caja")
            Me.cbBancos.Focus()
            Return False
            Exit Function
        End If

        If Trim(Me.txtNombre.Text) = "" Then
            XtraMsg("Introduzca nombre de quien realiza el pago")
            Me.txtNombre.Focus()
            Me.txtNombre.SelectAll()
            Return False
            Exit Function
        End If

        If Trim(Me.txtMonto.Text) = "" Then
            XtraMsg("Introduzca el monto", MessageBoxIcon.Error)
            Me.txtMonto.Focus()
            Me.txtMonto.SelectAll()
            Return False
            Exit Function
        End If

        If Me.chkCheque.Checked = True Then
            If Trim(Me.txtCheque.Text) = "" Then
                XtraMsg("Introduzca el No. de Cheque", MessageBoxIcon.Error)
                Me.txtCheque.Focus()
                Return False
                Exit Function
            End If
        Else
            Me.txtCheque.Text = "0"
        End If


        If Me.chkRecibo.Checked = True Then
            If Trim(Me.txtRecibo.Text) = "" Then
                XtraMsg("Introduzca el No. de Recibo", MessageBoxIcon.Error)
                Me.txtRecibo.Focus()
                Return False
                Exit Function
            Else 'Validar el numero de Recibo RMPR 16052008
                If txtRecibo.Text <> Nothing Then
                    Dim valor As Integer
                    valor = VB.SysContab.ClientesDB.ValidarRecibo(Me.txtRecibo.Text, "")
                    If valor = 1 Then
                        XtraMsg("Ese numero de recibo ya existe", MessageBoxIcon.Error)
                        txtRecibo.Text = ""
                        txtRecibo.Focus()
                        Exit Function
                    ElseIf valor = 2 Then
                        XtraMsg("Ese numero de recibo fue anulado", MessageBoxIcon.Error)
                        txtRecibo.Text = ""
                        txtRecibo.Focus()
                        Exit Function
                    End If
                End If
            End If
        Else
            Me.txtRecibo.Text = "0"
        End If
        'If Me.cbTipoComp.SelectedValue = "0" Or Me.cbTipoComp.SelectedValue = Nothing Then
        '    MsgBox("Seleccione el Tipo de Comprobante", MsgBoxStyle.Information)
        '    Me.cbTipoComp.Focus()
        '    Return False
        '    Exit Function
        'End If

        'If tCust.Rows.Count = 0 Then
        '    MsgBox("Seleccione al menos cuenta", MsgBoxStyle.Information)
        '    Me.dgCatalogo.Focus()
        '    Return False
        '    Exit Function
        'End If

        If Me.vComprobante.DataRowCount < 1 Then
            XtraMsg("Debe Ingresar al menos 1 linea en el Detalle del Comprobante", MessageBoxIcon.Warning)
            Return False
        End If

        'Dim i As Integer
        'Dim j As Integer
        'Dim Total As Double
        'Total = 0

        'For i = 0 To tCust.Rows.Count - 1
        '    If (tCust.Rows(tCust.Rows.Count - 1)("Codigo1").ToString = "" Or tCust.Rows(tCust.Rows.Count - 1)("Codigo1") Is DBNull.Value) And (tCust.Rows(tCust.Rows.Count - 1)("Codigo").ToString = "" Or tCust.Rows(tCust.Rows.Count - 1)("Codigo") Is DBNull.Value) And (tCust.Rows(tCust.Rows.Count - 1)("Descripcion").ToString = "" Or tCust.Rows(tCust.Rows.Count - 1)("Descripcion") Is DBNull.Value) And (tCust.Rows(tCust.Rows.Count - 1)("Monto").ToString = "" Or tCust.Rows(tCust.Rows.Count - 1)("Monto") Is DBNull.Value) And (tCust.Rows(tCust.Rows.Count - 1)("Concepto").ToString = "" Or tCust.Rows(tCust.Rows.Count - 1)("Concepto") Is DBNull.Value) Then
        '        tCust.Rows(tCust.Rows.Count - 1).Delete()
        '    End If
        'Next

        'For j = 0 To tCust.Rows.Count - 1
        '    If tCust.Rows(j)("Codigo1") Is DBNull.Value Or tCust.Rows(j)("Codigo1").ToString = "" Then
        '        MsgBox("Especifique una cuenta en la linea " & j + 1, MsgBoxStyle.Information)
        '        Me.dgCatalogo.Focus()
        '        'Codigo.TextBox.Focus()
        '        Return False
        '        Exit Function
        '    Else
        '        If tCust.Rows(j)("Monto") Is DBNull.Value Then
        '            '
        '        Else
        '            Total = Total + CDbl(tCust.Rows(j)("Monto"))
        '        End If

        '    End If

        'Next

        'If CDbl(CDbl(Total).ToString(Round)) > CDbl(CDbl(Me.txtMonto.Text).ToString(Round)) Then
        '    MsgBox("La suma del detalle en las Lineas es mayor que el Monto a Pagar", MsgBoxStyle.Information)
        '    Me.dgCatalogo.Focus()
        '    Return False
        '    Exit Function
        'ElseIf CDbl(CDbl(Total).ToString(Round)) < CDbl(CDbl(Me.txtMonto.Text).ToString(Round)) Then
        '    MsgBox("La suma del detalle en las Lineas es menor que el Monto a Pagar", MsgBoxStyle.Information)
        '    Me.dgCatalogo.Focus()
        '    Return False
        '    Exit Function
        'End If


        '******** VERIFICAR DISTRIBUCION ******************************************
        For i As Integer = 0 To Me.vComprobante.DataRowCount - 1
            Dim CTemp As String = vbNullString

            Try
                CTemp = ObtieneDatos("SELECT CuentaContable FROM RubrosGastos WHERE Activo = 1 AND" _
                                     + " CuentaContable = '" & vComprobante.GetRowCellValue(i, "Cuenta") & "'" _
                                     + " AND Empresa = " & EmpresaActual).Rows(0).Item(0)
            Catch ex As Exception
                CTemp = "xxx"
            End Try
            '
            If CTemp <> "xxx" And CTemp <> vbNullString Then
                '
                If VerificaDistribucion(CTemp) = False And ObligarDistribucion = True Then
                    XtraMsg("La Cuenta " & vComprobante.GetRowCellValue(i, "Cuenta").ToString & " Seleccionada es de Distribución, Favor Distribuirla " & vbCrLf &
                           "ó Verifique el Detalle de la Distribución.", MessageBoxIcon.Warning)
                    Exit Function
                End If
            End If

        Next
        '******** FIN VERIFICAR DISTRIBUCION **************************************


        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction()

        Try
            Dim DC As String
            ' Tipo = 3 Otros Ingresos
            NoComprob = VB.SysContab.ComprobanteDB.AddComprobante(TipoCOmpr, 1, txtConcepto.Text,
                                                                  VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MonedaBase,
                                                                  VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.DateTime.Date), dtpFecha.DateTime.Date, 0,
                                                                  Me.txtNombre.Text, False, 0, Me.txtRuc.Text, 3, Me.txtFactura.Text,
                                                                  VB.SysContab.Rutinas.Fecha, 0, OrigenComprobantes.OTROS_INGRESOS, Me.txtRuc.Text,
                                                                  0, 0, 0, 0, txtCaja.Text)
            '** Debitos
            DC = "D"

            'If Trim(Me.txtCheque.Text) <> "" Then
            '    Comprobantes.ActualizarCheque(Me.cbBancos.SelectedValue, Me.txtCheque.Text)
            'End If

            VB.SysContab.ComprobanteDB.AddComprobanteDetalles(NoComprob, cbBancos.EditValue, "", CDbl(Me.txtMonto.Text),
                                                              txtCheque.Text, TipoCOmpr, DC, txtBanco.Text, txtRecibo.Text, dtpFecha.DateTime, 0)
            'Comprobantes.AddCatalogoTrans(Me.cbBancos.SelectedValue, 0, Me.txtMonto.Text, "")
            'Catalogo.ActualizarCuentas(Me.cbBancos.SelectedValue, Me.txtMonto.Text, 1)
            If Trim(Me.txtRecibo.Text) = "" Then
                Me.txtRecibo.Text = "0"
            End If


            '** Creditos y Validar Negativos
            'DC = "C"
            With Me.vComprobante

                For i As Integer = 0 To .DataRowCount - 1
                    If IsNull(.GetRowCellValue(i, "Credito"), 0.0) <> 0 Then
                        VB.SysContab.ComprobanteDB.AddComprobanteDetalles(NoComprob, .GetRowCellValue(i, "Cuenta"),
                                                                              IsNull(.GetRowCellValue(i, "Concepto"), ""),
                                                                              Math.Abs(CDbl(IsNull(.GetRowCellValue(i, "Credito"), 0.0))),
                                                                              txtCheque.Text, TipoCOmpr,
                                                                              IIf(IsNull(.GetRowCellValue(i, "Credito"), 0.0) > 0, "C", "D"),
                                                                              txtBanco.Text, txtRecibo.Text, dtpFecha.DateTime.Date, 1)
                    End If
                Next

            End With

            'For i = 0 To tCust.Rows.Count - 1
            '    'If VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo1")).Tables("Catalogo").Rows(0).Item("Clase") = 1 Then
            '    '    DC = "C"
            '    'ElseIf VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo1")).Tables("Catalogo").Rows(0).Item("Clase") = 2 And CDbl(tCust.Rows(i)("Monto")) >= 0 Then
            '    '    DC = "C"
            '    'ElseIf VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo1")).Tables("Catalogo").Rows(0).Item("Clase") = 2 And CDbl(tCust.Rows(i)("Monto")) < 0 Then
            '    '    DC = "D"
            '    'End If

            '    If VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo1")).Tables("Catalogo").Rows(0).Item("Clase") = 1 And CDbl(tCust.Rows(i)("Monto")) >= 0 Then
            '        DC = "C"
            '    ElseIf VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo1")).Tables("Catalogo").Rows(0).Item("Clase") = 1 And CDbl(tCust.Rows(i)("Monto")) < 0 Then
            '        DC = "D"
            '    ElseIf VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo1")).Tables("Catalogo").Rows(0).Item("Clase") = 2 And CDbl(tCust.Rows(i)("Monto")) >= 0 Then
            '        DC = "C"
            '    ElseIf VB.SysContab.CatalogoDB.CatalogoXCuenta(tCust.Rows(i)("Codigo1")).Tables("Catalogo").Rows(0).Item("Clase") = 2 And CDbl(tCust.Rows(i)("Monto")) < 0 Then
            '        DC = "D"
            '    End If

            '    Comprobantes.AddComprobanteDetalles(NoComprob, tCust.Rows(i)("Codigo1"), tCust.Rows(i)("Concepto").ToString, Math.Abs(CDbl(tCust.Rows(i)("Monto"))), Me.txtCheque.Text, TipoCOmpr, DC, 0, Me.txtRecibo.Text, Me.dtpFecha.Value, 1)
            '    'Comprobantes.AddCatalogoTrans(tCust.Rows(i)("Codigo1"), tCust.Rows(i)("Monto"), 0, tCust.Rows(i)("Descripcion").ToString)
            '    'Catalogo.ActualizarCuentas(tCust.Rows(i)("Codigo1"), tCust.Rows(i)("Monto"), Opera)
            'Next

            VB.SysContab.Rutinas.okTransaccion()
            'SetTiempos(OrigenComprobantes.OTROS_INGRESOS, funciones.Tiempos.TiempoFin, Now, funciones.Eventos.Guarda, Me.txtRecibo.Text)


            '-----------------------------------------------
            'Guarda la Distribucion
            '-----------------------------------------------
            GuardaDistribucion(
                DT_Distribucion,
                dtpFecha.DateTime.Date,
                NoComprob,
                False)

            'Dim DT_F As DataTable
            'DT_F = DT_Distribucion.GetChanges(DataRowState.Added Or DataRowState.Modified Or DataRowState.Deleted)
            'If Not DT_F Is Nothing Then
            '    For i As Integer = 0 To DT_F.Rows.Count - 1
            '        With DT_F
            '            If .Rows(i).RowState = DataRowState.Added Then
            '                GuardaDatos("INSERT INTO Distribucion(IdEmpresa,NoComp,Mes,Per_Id,IdRubroGasto,IdCentroCosto,Valor,Tipo,Cuenta) " & _
            '                " VALUES(" & .Rows(i).Item("IdEmpresa") & "," & NoComprob & "," & Me.dtpFecha.DateTime.Month & "," & _
            '                VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.DateTime.Date) & "," & .Rows(i).Item("IdRubroGasto") & "," & .Rows(i).Item("IdCentroCosto") & "," & .Rows(i).Item("Valor") & ",'" & .Rows(i).Item("Tipo") & "','" & .Rows(i).Item("Cuenta") & "')")
            '            ElseIf .Rows(i).RowState = DataRowState.Modified Then
            '                GuardaDatos("UPDATE Distribucion SET IdEmpresa=" & .Rows(i).Item("IdEmpresa") & ",NoComp = " & NoComprob & ",Mes=" & Me.dtpFecha.DateTime.Month & "," & _
            '                "Per_Id = " & VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.DateTime) & ",IdRubroGasto = " & .Rows(i).Item("IdRubroGasto") & ",IdCentroCosto =" & .Rows(i).Item("IdCentroCosto") & ",Valor = " & .Rows(i).Item("Valor") & "," & _
            '                "Tipo='" & .Rows(i).Item("Tipo") & "',Cuenta='" & .Rows(i).Item("Cuenta") & "' WHERE IdDetalle = " & .Rows(i).Item("IdDetalle"))
            '            ElseIf .Rows(i).RowState = DataRowState.Deleted Then
            '            End If
            '        End With
            '    Next
            'End If

            Distribucion()
            '--------------------------
            'Fin de Guarda Distribucion
            '--------------------------

            If XtraMsg2("Imprimir el Recibo?") Then VB.SysContab.ClientesDB.ImprimirRecibo(txtRecibo.Text, "", 1)

            Return True
        Catch Mensaje As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            'SetTiempos(OrigenComprobantes.OTROS_INGRESOS, funciones.Tiempos.TiempoFin, Now, funciones.Eventos.Error1, Me.txtRecibo.Text)
            XtraMsg(Mensaje.Message, MessageBoxIcon.Error)
            Return False
        End Try

        'MakeDataSet()
        'Me.dgCatalogo.SetDataBinding(myDataSet, "Articulos")
        'AddCustomDataTableStyle()
        'r.ComboAutoComplete(Codigo.ColumnComboBox)
        'r.ComboAutoComplete(Descripcion.ColumnComboBox)

        'If Clientes.GenerarRecibo.Tables("Cobros").Rows.Count = 0 Then
        '    txtRecibo.Text = Format(ConfigDetalles.ReciboNumero, dd)
        'Else
        '    txtRecibo.Text = Format(Clientes.GenerarRecibo.Tables("Cobros").Rows(0).Item("Recibo") + 1, dd)
        'End If

        'Return True
    End Function

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

    Private Sub cbPagar_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        'Dim Cliente As Boolean
        'Dim Proveedor As Boolean
        'Cliente = False
        'Proveedor = False

        'If Trim(Me.cbPagar.Text) = "" Then
        '    Exit Sub
        'End If

        ''If Me.cbPagar.Text = Me.cbPagar2.Text Then
        ''    Exit Sub
        ''End If

        'If Clientes.ClientesBuscar(Trim(Me.cbPagar.Text)).Tables("Clientes").Rows.Count = 0 Then
        '    Cliente = True
        'End If

        'If Proveedores.ProveedoresBuscar(Trim(Me.cbPagar.Text)).Tables("Proveedores").Rows.Count = 0 Then
        '    Proveedor = True
        '    Me.cbPagar.Text = Me.cbPagar.Text.ToUpper

        '    If Cliente = True And Proveedor = True Then
        '        If (MsgBox("Proveedor no existe. Desea agregarlo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)) = MsgBoxResult.No Then
        '            Me.etRuc.Visible = True
        '            Me.txtRuc.Visible = True
        '            Me.txtNombre.Text = Me.cbPagar.Text.ToUpper
        '            Me.cbPagar.SelectedValue = 0
        '            'Me.cbPagar1.SelectedValue = 0
        '            Me.cbPagar.Text = Me.txtNombre.Text
        '        Else
        '            Dim f As New frmAgregarProveedorQuick()
        '            f.WindowState = FormWindowState.Normal
        '            f.StartPosition = FormStartPosition.CenterScreen

        '            f.txtNombre.Text = Me.cbPagar.Text.ToUpper
        '            cbPagar.Text = cbPagar.Text.ToUpper

        '            f.ShowDialog()

        '            Me.cbPagar.DataSource = Proveedores.PagarList().Tables("Proveedores")
        '            Me.cbPagar.ValueMember = "Codigo"
        '            Me.cbPagar.DisplayMember = "Nombre"

        '            'Me.cbPagar1.DataSource = Proveedores.PagarList1().Tables("Proveedores")
        '            'Me.cbPagar1.ValueMember = "Codigo"
        '            'Me.cbPagar1.DisplayMember = "Nombre"

        '            cbPagar.SelectedValue = f.txtCodigo.Text
        '            'Me.cbPagar1.SelectedIndex = Me.cbPagar.SelectedIndex
        '            Me.txtNombre.Text = f.txtNombre.Text.ToUpper

        '            Me.etRuc.Visible = False
        '            Me.txtRuc.Visible = False
        '        End If
        '        Exit Sub
        '    End If
        'End If

        'If Trim(Me.cbPagar.Text) = "" Then
        '    Me.txtRuc.Text = ""
        '    Exit Sub
        'End If

        'If Clientes.ClientesBuscar(Trim(Me.cbPagar.Text)).Tables("Clientes").Rows.Count = 0 Then
        '    Me.cbPagar.Text = Me.cbPagar.Text.ToUpper
        '    txtRuc.Text = ""

        '    If (MsgBox("Cliente no existe. ¿Desea agregarlo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)) = MsgBoxResult.No Then
        '        'Cod_Cliente = "9999" 'Clientes Varios
        '        'DetallesCliente = VB.SysContab.ClientesDB.GetDetails(Cod_Cliente)
        '        'DetallesVendedor = Vendedor.GetDetails(0)
        '        'DetallesVendedor = Vendedor.GetDetails(DetallesCliente.Vendedor)

        '        Me.etRuc.Visible = True
        '        Me.txtRuc.Visible = True
        '        Me.txtNombre.Text = Me.cbPagar.Text.ToUpper
        '        Me.cbPagar.EditValue = 0
        '        'Me.cbPagar1.SelectedValue = 0
        '        Me.cbPagar.Text = Me.txtNombre.Text
        '    Else
        '        Dim f As New frmAgregarClienteQuick()
        '        f.WindowState = FormWindowState.Normal
        '        f.StartPosition = FormStartPosition.CenterScreen
        '        NombreCliente = Me.cbPagar.Text.ToUpper
        '        'cbCliente.Text = cbCliente.Text.ToUpper

        '        f.ShowDialog()

        '        Me.cbPagar.EditValue = Clientes.GetList().Tables("Clientes")
        '        Me.cbPagar.ValueMember = "Codigo"
        '        Me.cbPagar.DisplayMember = "Nombre"

        '        Me.cbPagar.SelectedValue = f.txtCodigo.Text

        '        'Me.cbPagar1.SelectedIndex = Me.cbPagar.SelectedIndex
        '        Me.txtNombre.Text = f.txtNombre.Text.ToUpper

        '        Me.etRuc.Visible = False
        '        Me.txtRuc.Visible = False

        '    End If

        '    Exit Sub

        'End If

        'Me.cbPagar.Refresh()
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        'Exit Sub
        'If Guardar() = False Then
        '    Exit Sub
        'End If

        ''Dim ValorLetras As String = Me.etMontoLetras.Text 
        'Dim fReportes As New frmReportes()

        'Dim rFactura As New rptComprobanteCheque()
        ''rFactura.SetDataSource(Comprobantes.ImprimirCombrobante(NoComprob, PeriodosDB.Activo, ValorLetras, Me.dtpFecha.Value, CDbl(Me.txtMonto.Text)))
        'fReportes.crvReportes.ReportSource = rFactura

        'Me.txtDocumento.Text = ""
        'Me.txtMonto.Text = "0.00"
        'Me.cbPagar.EditValue = 0
        'Me.txtNombre.Text = ""
        'Me.txtConcepto.Text = ""

        ''Me.etMontoLetras.Text = r.ConversionDecimales(CDbl(Me.txtMonto.Text))

        ''dsCB = CatBancos.CatalogoBancosXCuenta(Me.cbBancos.SelectedValue)
        ''Me.txtCheque.Text = CatBancos.GetCheque(dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Banco"), dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Numero_Cuenta")).ToString
        'Me.etBalance.Text = CDbl(Comprobantes.SaldoxCuenta(Me.cbBancos.EditValue, VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.Value))).ToString(Round)
        'fReportes.Show()
    End Sub

    'Private Sub dgCatalogo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCatalogo.DoubleClick
    '    Dim f As New frmNuevaCuentaQuick()
    '    Nuevo = "SI"
    '    f.ShowDialog()
    '    Me.dgCatalogo.Item(Me.dgCatalogo.CurrentRowIndex, 0) = f.txtCodigo.Text
    '    Me.dgCatalogo.Item(Me.dgCatalogo.CurrentRowIndex, 1) = f.txtCodigo.Text & " - " & f.txtNombre.Text
    '    Me.dgCatalogo.Item(Me.dgCatalogo.CurrentRowIndex, 2) = f.txtNombre.Text
    'End Sub

    Private Sub chkEfectivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEfectivo.CheckedChanged
        If Me.chkEfectivo.Checked = True Then
            Me.chkCheque.Checked = False
            Me.txtCheque.Enabled = False
            Me.txtCheque.Text = ""
        Else
            Me.chkCheque.Checked = True
        End If
    End Sub

    Private Sub chkCheque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCheque.CheckedChanged
        If Me.chkCheque.Checked = True Then
            Me.chkEfectivo.Checked = False
            Me.txtCheque.Enabled = True
            txtBanco.Enabled = True
        Else
            chkEfectivo.Checked = True
            txtBanco.Text = ""
            txtCheque.Text = ""
        End If
    End Sub

    Private Sub txtRecibo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRecibo.KeyPress
        If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
            If Char.IsDigit(e.KeyChar) = False Then
                e.Handled = True
                Exit Sub
            End If
        End If
    End Sub

    Private Sub chkRecibo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRecibo.CheckedChanged
        If Me.chkRecibo.Checked = True Then
            Me.txtRecibo.Enabled = True
            If Clientes.GenerarRecibo.Tables("Cobros").Rows.Count = 0 Then
                txtRecibo.Text = Format(ConfigDetalles.ReciboNumero, dd)
            Else
                txtRecibo.Text = Format(Clientes.GenerarRecibo.Tables("Cobros").Rows(0).Item("Recibo") + 1, dd)
            End If
        Else
            Me.txtRecibo.Enabled = False
            Me.txtRecibo.Text = ""
        End If
    End Sub

    Private Sub frmOtrosIngresos_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        ' SetTiempos(OrigenComprobantes.OTROS_INGRESOS, funciones.Tiempos.TiempoFin, Now, funciones.Eventos.Salir, Me.txtRecibo.Text)
    End Sub

    Private Sub cbBancos_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBancos.EditValueChanged
        If Me.etInicio.Text = "1" Then
            Exit Sub
        End If

        Try
            If Me.cbBancos.EditValue = "0" Then
                'Me.Label8.Visible = False
                Me.etBalance.Text = "0.00"
                'Me.etBalance.Visible = False
                Me.txtCheque.Text = ""
            Else
                ShowSplash()
                'Me.Label8.Visible = True
                Me.etBalance.Visible = True
                'dsCB = CatBancos.CatalogoBancosXCuenta(Me.cbBancos.SelectedValue)
                'Me.txtCheque.Text = CatBancos.GetCheque(dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Banco"), dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Numero_Cuenta")).ToString
                Me.etBalance.Text = CDbl(VB.SysContab.ComprobanteDB.SaldoxCuenta(Me.cbBancos.EditValue, VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.DateTime.Date))).ToString(Round)
                HideSplash()
            End If
        Catch ex As Exception
            HideSplash()
            'Me.Label8.Visible = False
            Me.etBalance.Text = "0.00"
            'Me.etBalance.Visible = False
            Me.txtCheque.Text = ""
        End Try
    End Sub

    Private Sub cbPagar_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.etInicio.Text = "1" Then
            Exit Sub
        End If

        'Me.cbPagar1.SelectedIndex = Me.cbPagar.SelectedIndex
        'Me.cbPagar2.SelectedIndex = Me.cbPagar.SelectedIndex
        'Me.txtNombre.Text = Me.cbPagar1.Text


    End Sub

    Private Sub cbPagar_EditValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPagar.EditValueChanged
        Try
            Me.txtNombre.Text = Me.cbPagar.Text

            'If Me.cbPagar.EditValue = 0 Then
            '    Me.etRuc.Visible = True
            '    Me.txtRuc.Visible = True
            '    Exit Sub
            'End If

            ' ProveedoresDetalles = VB.SysContab.ProveedoresDB.GetDetails(Me.cbPagar.EditValue)
            ClientesDetalle = VB.SysContab.ClientesDB.GetDetails(cbPagar.EditValue)
            txtRuc.Text = IIf(IsNull(ClientesDetalle.Ruc, "").ToString.Trim = "", IsNull(ClientesDetalle.Cedula, ""), IsNull(ClientesDetalle.Ruc, ""))

            'If ProveedoresDetalles.Varios = True Then
            '    Me.etRuc.Visible = True
            '    Me.txtRuc.Visible = True
            'Else
            '    Me.txtRuc.Text = ""
            '    Me.etRuc.Visible = False
            '    Me.txtRuc.Visible = False
            'End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub vComprobante_DoubleClick(sender As Object, e As EventArgs) Handles vComprobante.DoubleClick
        If vComprobante.DataRowCount = 0 Then
            Exit Sub
        End If

        Try
            Dim f As New FrmDetalleRequisas
            With vComprobante

                f.Monto = Math.Abs(CDbl(IsNull(.GetRowCellValue(.FocusedRowHandle, "Credito"), 0.0)))
                f.Tipo = IIf(IsNull(.GetRowCellValue(.FocusedRowHandle, "Credito"), 0.0) > 0, "C", "D")
                f.Periodo = VB.SysContab.PeriodosDB.Activo(dtpFecha.DateTime.Date)
                f.CompNo = NoComprob
                f.Cuenta = .GetRowCellValue(.FocusedRowHandle, "Cuenta")
                f.Mes = dtpFecha.DateTime.Month

                f.Mostrar(DT_Distribucion)
                DT_Distribucion.DefaultView.RowFilter = ""
            End With
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub vComprobante_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles vComprobante.RowUpdated
        Recalcular()
    End Sub

    Private Sub vComprobante_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vComprobante.CellValueChanged
        Recalcular()
    End Sub

End Class

'End Namespace
