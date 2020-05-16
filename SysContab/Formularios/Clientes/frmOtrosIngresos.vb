Imports System
Imports System.Data
Imports System.Data.SqlClient

'Namespace DataGridTextBoxCombo
Public Class frmOtrosIngresos
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmOtrosIngresos = Nothing

    Public Shared Function Instance() As frmOtrosIngresos
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmOtrosIngresos()
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
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDocumento As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents etBalance As System.Windows.Forms.Label
    Friend WithEvents etInicio As System.Windows.Forms.Label
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCheque As System.Windows.Forms.TextBox
    Friend WithEvents cbPagar1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmdRecalcular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents etRuc As System.Windows.Forms.Label
    Friend WithEvents txtRuc As System.Windows.Forms.TextBox
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbPagar2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chkEfectivo As System.Windows.Forms.CheckBox
    Friend WithEvents chkCheque As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
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
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtCaja As System.Windows.Forms.Label
    Friend WithEvents txtBanco As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cbTipoComp1 As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpFecha = New DevExpress.XtraEditors.DateEdit()
        Me.txtBanco = New System.Windows.Forms.TextBox()
        Me.txtCaja = New System.Windows.Forms.Label()
        Me.cbPagar = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.vista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.chkRecibo = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.chkCheque = New System.Windows.Forms.CheckBox()
        Me.chkEfectivo = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.etRuc = New System.Windows.Forms.Label()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCheque = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.txtRecibo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbPagar1 = New System.Windows.Forms.ComboBox()
        Me.etInicio = New System.Windows.Forms.Label()
        Me.cbTipoComp1 = New System.Windows.Forms.ComboBox()
        Me.cbPagar2 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.Label8 = New System.Windows.Forms.Label()
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtpFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbPagar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbBancos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vComprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(56, 21)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(36, 13)
        Me.Label25.TabIndex = 143
        Me.Label25.Text = "Caja:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.txtBanco)
        Me.GroupBox1.Controls.Add(Me.txtCaja)
        Me.GroupBox1.Controls.Add(Me.cbPagar)
        Me.GroupBox1.Controls.Add(Me.chkRecibo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtFactura)
        Me.GroupBox1.Controls.Add(Me.chkCheque)
        Me.GroupBox1.Controls.Add(Me.chkEfectivo)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.etRuc)
        Me.GroupBox1.Controls.Add(Me.txtRuc)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtCheque)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtConcepto)
        Me.GroupBox1.Controls.Add(Me.txtRecibo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 172)
        Me.GroupBox1.TabIndex = 144
        Me.GroupBox1.TabStop = False
        '
        'dtpFecha
        '
        Me.dtpFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecha.EditValue = Nothing
        Me.dtpFecha.Location = New System.Drawing.Point(840, 16)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Properties.Appearance.Options.UseFont = True
        Me.dtpFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFecha.Size = New System.Drawing.Size(152, 20)
        Me.dtpFecha.TabIndex = 169
        '
        'txtBanco
        '
        Me.txtBanco.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBanco.Enabled = False
        Me.txtBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBanco.Location = New System.Drawing.Point(840, 140)
        Me.txtBanco.MaxLength = 60
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(152, 20)
        Me.txtBanco.TabIndex = 160
        '
        'txtCaja
        '
        Me.txtCaja.AutoSize = True
        Me.txtCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCaja.Location = New System.Drawing.Point(960, 19)
        Me.txtCaja.Name = "txtCaja"
        Me.txtCaja.Size = New System.Drawing.Size(32, 13)
        Me.txtCaja.TabIndex = 160
        Me.txtCaja.Text = "Caja"
        Me.txtCaja.Visible = False
        '
        'cbPagar
        '
        Me.cbPagar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbPagar.Location = New System.Drawing.Point(104, 16)
        Me.cbPagar.Name = "cbPagar"
        Me.cbPagar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPagar.Properties.Appearance.Options.UseFont = True
        Me.cbPagar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPagar.Properties.NullText = "[Seleccione Cliente]"
        Me.cbPagar.Properties.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.cbPagar.Properties.View = Me.vista
        Me.cbPagar.Size = New System.Drawing.Size(595, 22)
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
        Me.chkRecibo.Location = New System.Drawing.Point(760, 71)
        Me.chkRecibo.Name = "chkRecibo"
        Me.chkRecibo.Size = New System.Drawing.Size(72, 26)
        Me.chkRecibo.TabIndex = 166
        Me.chkRecibo.Text = "Recibo"
        Me.chkRecibo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(728, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 26)
        Me.Label11.TabIndex = 165
        Me.Label11.Text = "Factura:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFactura
        '
        Me.txtFactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactura.Location = New System.Drawing.Point(840, 44)
        Me.txtFactura.MaxLength = 13
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(152, 20)
        Me.txtFactura.TabIndex = 164
        '
        'chkCheque
        '
        Me.chkCheque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkCheque.AutoSize = True
        Me.chkCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCheque.ForeColor = System.Drawing.Color.Black
        Me.chkCheque.Location = New System.Drawing.Point(925, 94)
        Me.chkCheque.Name = "chkCheque"
        Me.chkCheque.Size = New System.Drawing.Size(69, 17)
        Me.chkCheque.TabIndex = 163
        Me.chkCheque.Text = "Cheque"
        Me.chkCheque.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkEfectivo
        '
        Me.chkEfectivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkEfectivo.AutoSize = True
        Me.chkEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEfectivo.ForeColor = System.Drawing.Color.Black
        Me.chkEfectivo.Location = New System.Drawing.Point(841, 94)
        Me.chkEfectivo.Name = "chkEfectivo"
        Me.chkEfectivo.Size = New System.Drawing.Size(73, 17)
        Me.chkEfectivo.TabIndex = 162
        Me.chkEfectivo.Text = "Efectivo"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(736, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 13)
        Me.Label10.TabIndex = 161
        Me.Label10.Text = "Forma de Pago:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'etRuc
        '
        Me.etRuc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etRuc.AutoSize = True
        Me.etRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etRuc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etRuc.Location = New System.Drawing.Point(371, 80)
        Me.etRuc.Name = "etRuc"
        Me.etRuc.Size = New System.Drawing.Size(82, 13)
        Me.etRuc.TabIndex = 160
        Me.etRuc.Text = "RUC/Cédula:"
        Me.etRuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRuc
        '
        Me.txtRuc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.Location = New System.Drawing.Point(459, 77)
        Me.txtRuc.MaxLength = 50
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(240, 20)
        Me.txtRuc.TabIndex = 159
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(785, 147)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 13)
        Me.Label12.TabIndex = 152
        Me.Label12.Text = "Banco:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(736, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "No. de Cheque:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCheque
        '
        Me.txtCheque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheque.Location = New System.Drawing.Point(840, 115)
        Me.txtCheque.MaxLength = 13
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(152, 20)
        Me.txtCheque.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(26, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 150
        Me.Label4.Text = "Nombre:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(104, 46)
        Me.txtNombre.MaxLength = 60
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(595, 23)
        Me.txtNombre.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(34, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 148
        Me.Label3.Text = "Monto:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMonto
        '
        Me.txtMonto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMonto.BackColor = System.Drawing.SystemColors.Info
        Me.txtMonto.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.ForeColor = System.Drawing.Color.DarkRed
        Me.txtMonto.Location = New System.Drawing.Point(104, 75)
        Me.txtMonto.MaxLength = 13
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.ReadOnly = True
        Me.txtMonto.Size = New System.Drawing.Size(136, 23)
        Me.txtMonto.TabIndex = 5
        Me.txtMonto.Text = "0.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(21, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 145
        Me.Label1.Text = "Cobrar a:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(728, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 17)
        Me.Label2.TabIndex = 145
        Me.Label2.Text = "Fecha:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(15, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 152
        Me.Label6.Text = "Concepto:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtConcepto
        '
        Me.txtConcepto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConcepto.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConcepto.Location = New System.Drawing.Point(104, 106)
        Me.txtConcepto.MaxLength = 100
        Me.txtConcepto.Multiline = True
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(595, 54)
        Me.txtConcepto.TabIndex = 6
        '
        'txtRecibo
        '
        Me.txtRecibo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecibo.Location = New System.Drawing.Point(840, 69)
        Me.txtRecibo.MaxLength = 13
        Me.txtRecibo.Name = "txtRecibo"
        Me.txtRecibo.Size = New System.Drawing.Size(152, 20)
        Me.txtRecibo.TabIndex = 155
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(864, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 158
        Me.Label9.Text = "Tipo:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.Visible = False
        '
        'cbPagar1
        '
        Me.cbPagar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPagar1.Location = New System.Drawing.Point(977, 9)
        Me.cbPagar1.Name = "cbPagar1"
        Me.cbPagar1.Size = New System.Drawing.Size(35, 21)
        Me.cbPagar1.TabIndex = 156
        Me.cbPagar1.Visible = False
        '
        'etInicio
        '
        Me.etInicio.AutoSize = True
        Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etInicio.Location = New System.Drawing.Point(886, 22)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(14, 13)
        Me.etInicio.TabIndex = 155
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
        '
        'cbTipoComp1
        '
        Me.cbTipoComp1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoComp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoComp1.Location = New System.Drawing.Point(906, 9)
        Me.cbTipoComp1.Name = "cbTipoComp1"
        Me.cbTipoComp1.Size = New System.Drawing.Size(20, 21)
        Me.cbTipoComp1.TabIndex = 151
        Me.cbTipoComp1.Visible = False
        '
        'cbPagar2
        '
        Me.cbPagar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPagar2.Location = New System.Drawing.Point(932, 9)
        Me.cbPagar2.Name = "cbPagar2"
        Me.cbPagar2.Size = New System.Drawing.Size(39, 21)
        Me.cbPagar2.TabIndex = 157
        Me.cbPagar2.Visible = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(423, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 26)
        Me.Label7.TabIndex = 154
        Me.Label7.Text = "No. Documento:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Visible = False
        '
        'txtDocumento
        '
        Me.txtDocumento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumento.Location = New System.Drawing.Point(549, 5)
        Me.txtDocumento.MaxLength = 60
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(136, 20)
        Me.txtDocumento.TabIndex = 153
        Me.txtDocumento.Visible = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.ImageOptions.Image = Global.SysContab.My.Resources.Resources.RibbonUserDesigner_SaveFileLarge
        Me.cmdAceptar.Location = New System.Drawing.Point(8, 5)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(91, 32)
        Me.cmdAceptar.TabIndex = 8
        Me.cmdAceptar.Text = "&Guardar"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(605, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 25)
        Me.Label8.TabIndex = 146
        Me.Label8.Text = "Balance:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Visible = False
        '
        'etBalance
        '
        Me.etBalance.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etBalance.Location = New System.Drawing.Point(677, 9)
        Me.etBalance.Name = "etBalance"
        Me.etBalance.Size = New System.Drawing.Size(167, 25)
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
        Me.cmdSalir.ImageOptions.Image = Global.SysContab.My.Resources.Resources.SalirFrm
        Me.cmdSalir.Location = New System.Drawing.Point(212, 5)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(89, 32)
        Me.cmdSalir.TabIndex = 11
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdRecalcular
        '
        Me.cmdRecalcular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdRecalcular.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRecalcular.Appearance.Options.UseFont = True
        Me.cmdRecalcular.ImageOptions.Image = Global.SysContab.My.Resources.Resources.RibbonUserDesigner_HtmlRefreshLarge
        Me.cmdRecalcular.Location = New System.Drawing.Point(105, 5)
        Me.cmdRecalcular.Name = "cmdRecalcular"
        Me.cmdRecalcular.Size = New System.Drawing.Size(101, 32)
        Me.cmdRecalcular.TabIndex = 10
        Me.cmdRecalcular.Text = "&Recalcular"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImprimir.Appearance.Options.UseFont = True
        Me.cmdImprimir.Location = New System.Drawing.Point(307, 5)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 32)
        Me.cmdImprimir.TabIndex = 9
        Me.cmdImprimir.Text = "&Imprimir"
        Me.cmdImprimir.Visible = False
        '
        'cbBancos
        '
        Me.cbBancos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbBancos.Location = New System.Drawing.Point(116, 12)
        Me.cbBancos.Name = "cbBancos"
        Me.cbBancos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBancos.Properties.Appearance.Options.UseFont = True
        Me.cbBancos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbBancos.Properties.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.cbBancos.Size = New System.Drawing.Size(480, 22)
        Me.cbBancos.TabIndex = 155
        '
        'gridDatos
        '
        Me.gridDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDatos.Location = New System.Drawing.Point(12, 207)
        Me.gridDatos.MainView = Me.vComprobante
        Me.gridDatos.Name = "gridDatos"
        Me.gridDatos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbCatalogo})
        Me.gridDatos.Size = New System.Drawing.Size(1000, 184)
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
        Me.cbCatalogo.ValueMember = "Cuenta"
        Me.cbCatalogo.View = Me.GridView2
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
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdAceptar)
        Me.PanelControl1.Controls.Add(Me.cmdRecalcular)
        Me.PanelControl1.Controls.Add(Me.cmdSalir)
        Me.PanelControl1.Controls.Add(Me.cmdImprimir)
        Me.PanelControl1.Controls.Add(Me.txtDocumento)
        Me.PanelControl1.Controls.Add(Me.Label7)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 397)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1021, 48)
        Me.PanelControl1.TabIndex = 159
        '
        'frmOtrosIngresos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1021, 445)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.gridDatos)
        Me.Controls.Add(Me.cbBancos)
        Me.Controls.Add(Me.etBalance)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.etInicio)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbPagar1)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.cbPagar2)
        Me.Controls.Add(Me.cbTipoComp1)
        Me.Name = "frmOtrosIngresos"
        Me.Text = "Registro de Otros Ingresos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtpFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbPagar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbBancos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vComprobante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
        If Guardar() = False Then
            Exit Sub
        End If

        Dim f As frmOtrosIngresosList = frmOtrosIngresosList.Instance()
        f.Cargar()

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
            NoComprob = VB.SysContab.ComprobanteDB.AddComprobante(TipoCOmpr, 1, txtConcepto.Text, _
                                                                  VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MonedaBase, _
                                                                  VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.DateTime.Date), dtpFecha.DateTime.Date, 0, _
                                                                  Me.txtNombre.Text, False, 0, Me.txtRuc.Text, 3, Me.txtFactura.Text, _
                                                                  VB.SysContab.Rutinas.Fecha, 0, OrigenComprobantes.OTROS_INGRESOS, Me.txtRuc.Text, _
                                                                  0, 0, 0, 0, txtCaja.Text)
            '** Debitos
            DC = "D"

            'If Trim(Me.txtCheque.Text) <> "" Then
            '    Comprobantes.ActualizarCheque(Me.cbBancos.SelectedValue, Me.txtCheque.Text)
            'End If

            VB.SysContab.ComprobanteDB.AddComprobanteDetalles(NoComprob, cbBancos.EditValue, "", CDbl(Me.txtMonto.Text), _
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
                        VB.SysContab.ComprobanteDB.AddComprobanteDetalles(NoComprob, .GetRowCellValue(i, "Cuenta"), _
                                                                              IsNull(.GetRowCellValue(i, "Concepto"), ""), _
                                                                              Math.Abs(CDbl(IsNull(.GetRowCellValue(i, "Credito"), 0.0))), _
                                                                              txtCheque.Text, TipoCOmpr, _
                                                                              IIf(IsNull(.GetRowCellValue(i, "Credito"), 0.0) > 0, "C", "D"), _
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
            Dim DT_F As DataTable
            DT_F = DT_Distribucion.GetChanges(DataRowState.Added Or DataRowState.Modified Or DataRowState.Deleted)
            If Not DT_F Is Nothing Then
                For i As Integer = 0 To DT_F.Rows.Count - 1
                    With DT_F
                        If .Rows(i).RowState = DataRowState.Added Then
                            GuardaDatos("INSERT INTO Distribucion(IdEmpresa,NoComp,Mes,Per_Id,IdRubroGasto,IdCentroCosto,Valor,Tipo,Cuenta) " & _
                            " VALUES(" & .Rows(i).Item("IdEmpresa") & "," & NoComprob & "," & Me.dtpFecha.DateTime.Month & "," & _
                            VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.DateTime.Date) & "," & .Rows(i).Item("IdRubroGasto") & "," & .Rows(i).Item("IdCentroCosto") & "," & .Rows(i).Item("Valor") & ",'" & .Rows(i).Item("Tipo") & "','" & .Rows(i).Item("Cuenta") & "')")
                        ElseIf .Rows(i).RowState = DataRowState.Modified Then
                            GuardaDatos("UPDATE Distribucion SET IdEmpresa=" & .Rows(i).Item("IdEmpresa") & ",NoComp = " & NoComprob & ",Mes=" & Me.dtpFecha.DateTime.Month & "," & _
                            "Per_Id = " & VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.DateTime) & ",IdRubroGasto = " & .Rows(i).Item("IdRubroGasto") & ",IdCentroCosto =" & .Rows(i).Item("IdCentroCosto") & ",Valor = " & .Rows(i).Item("Valor") & "," & _
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
                Me.Label8.Visible = False
                Me.etBalance.Text = "0.00"
                Me.etBalance.Visible = False
                Me.txtCheque.Text = ""
            Else
                Me.Label8.Visible = True
                Me.etBalance.Visible = True
                'dsCB = CatBancos.CatalogoBancosXCuenta(Me.cbBancos.SelectedValue)
                'Me.txtCheque.Text = CatBancos.GetCheque(dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Banco"), dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Numero_Cuenta")).ToString
                Me.etBalance.Text = CDbl(VB.SysContab.ComprobanteDB.SaldoxCuenta(Me.cbBancos.EditValue, VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.DateTime.Date))).ToString(Round)
            End If
        Catch ex As Exception
            Me.Label8.Visible = False
            Me.etBalance.Text = "0.00"
            Me.etBalance.Visible = False
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
