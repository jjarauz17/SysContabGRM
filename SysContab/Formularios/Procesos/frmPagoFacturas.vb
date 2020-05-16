Imports System.Data
Imports System.Data.SqlClient

Public Class frmPagoFacturas
    Inherits DevExpress.XtraEditors.XtraForm

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
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbBanco As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtTasa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMoneda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gridDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents txtComentarios As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents etFecha As System.Windows.Forms.Label
    Friend WithEvents etCodigoProveedor As System.Windows.Forms.Label
    Friend WithEvents lblFactMonto As System.Windows.Forms.Label
    Friend WithEvents lblProvID As System.Windows.Forms.Label
    Friend WithEvents cbCatalogo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblFact As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblProv As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rgIR As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents vTrans As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNoCheque As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBalance As DevExpress.XtraEditors.TextEdit
    Friend WithEvents etMontoIR As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkAlcaldia As System.Windows.Forms.CheckBox
    Friend WithEvents txtAlcaldia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbAlma As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents etInicio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDebe As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtHaber As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cbCuentas As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
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
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents etDebe As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents etDif As DevExpress.XtraEditors.TextEdit
    Friend WithEvents etHaber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cBorrar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FechaVencimiento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPagoFacturas))
        Me.cbBanco = New DevExpress.XtraEditors.LookUpEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.FechaVencimiento = New DevExpress.XtraEditors.DateEdit()
        Me.etDif = New DevExpress.XtraEditors.TextEdit()
        Me.etHaber = New DevExpress.XtraEditors.TextEdit()
        Me.etDebe = New DevExpress.XtraEditors.TextEdit()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.txtAlcaldia = New DevExpress.XtraEditors.TextEdit()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.lblProvID = New System.Windows.Forms.Label()
        Me.etCodigoProveedor = New System.Windows.Forms.Label()
        Me.lblFactMonto = New System.Windows.Forms.Label()
        Me.gridDatos = New DevExpress.XtraGrid.GridControl()
        Me.vTrans = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbCuentas = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDebe = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtHaber = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cTipo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cBorrar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.chkAlcaldia = New System.Windows.Forms.CheckBox()
        Me.etFecha = New System.Windows.Forms.Label()
        Me.etMontoIR = New DevExpress.XtraEditors.TextEdit()
        Me.txtComentarios = New DevExpress.XtraEditors.MemoEdit()
        Me.etInicio = New DevExpress.XtraEditors.LabelControl()
        Me.cbAlma = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtBalance = New DevExpress.XtraEditors.TextEdit()
        Me.rgIR = New DevExpress.XtraEditors.RadioGroup()
        Me.lblProv = New DevExpress.XtraEditors.TextEdit()
        Me.cbCatalogo = New DevExpress.XtraEditors.LookUpEdit()
        Me.Fecha = New DevExpress.XtraEditors.DateEdit()
        Me.txtNoCheque = New DevExpress.XtraEditors.TextEdit()
        Me.lblFact = New DevExpress.XtraEditors.TextEdit()
        Me.txtTasa = New DevExpress.XtraEditors.TextEdit()
        Me.txtMoneda = New DevExpress.XtraEditors.TextEdit()
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
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.cbBanco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.FechaVencimiento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaVencimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etDif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etHaber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etDebe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlcaldia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDebe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHaber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etMontoIR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComentarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbAlma.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBalance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgIR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblProv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoCheque.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFact.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbBanco
        '
        Me.cbBanco.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbBanco.Location = New System.Drawing.Point(114, 90)
        Me.cbBanco.Name = "cbBanco"
        Me.cbBanco.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBanco.Properties.Appearance.Options.UseFont = True
        Me.cbBanco.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbBanco.Properties.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.cbBanco.Properties.ShowFooter = False
        Me.cbBanco.Size = New System.Drawing.Size(386, 20)
        Me.cbBanco.StyleController = Me.LayoutControl1
        Me.cbBanco.TabIndex = 1
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.FechaVencimiento)
        Me.LayoutControl1.Controls.Add(Me.etDif)
        Me.LayoutControl1.Controls.Add(Me.etHaber)
        Me.LayoutControl1.Controls.Add(Me.etDebe)
        Me.LayoutControl1.Controls.Add(Me.btnSalir)
        Me.LayoutControl1.Controls.Add(Me.txtAlcaldia)
        Me.LayoutControl1.Controls.Add(Me.btnGuardar)
        Me.LayoutControl1.Controls.Add(Me.txtNombre)
        Me.LayoutControl1.Controls.Add(Me.lblProvID)
        Me.LayoutControl1.Controls.Add(Me.etCodigoProveedor)
        Me.LayoutControl1.Controls.Add(Me.lblFactMonto)
        Me.LayoutControl1.Controls.Add(Me.gridDatos)
        Me.LayoutControl1.Controls.Add(Me.chkAlcaldia)
        Me.LayoutControl1.Controls.Add(Me.etFecha)
        Me.LayoutControl1.Controls.Add(Me.etMontoIR)
        Me.LayoutControl1.Controls.Add(Me.txtComentarios)
        Me.LayoutControl1.Controls.Add(Me.etInicio)
        Me.LayoutControl1.Controls.Add(Me.cbAlma)
        Me.LayoutControl1.Controls.Add(Me.txtBalance)
        Me.LayoutControl1.Controls.Add(Me.rgIR)
        Me.LayoutControl1.Controls.Add(Me.lblProv)
        Me.LayoutControl1.Controls.Add(Me.cbCatalogo)
        Me.LayoutControl1.Controls.Add(Me.Fecha)
        Me.LayoutControl1.Controls.Add(Me.txtNoCheque)
        Me.LayoutControl1.Controls.Add(Me.lblFact)
        Me.LayoutControl1.Controls.Add(Me.txtTasa)
        Me.LayoutControl1.Controls.Add(Me.cbBanco)
        Me.LayoutControl1.Controls.Add(Me.txtMoneda)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1087, 211, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(794, 459)
        Me.LayoutControl1.TabIndex = 154
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'FechaVencimiento
        '
        Me.FechaVencimiento.EditValue = Nothing
        Me.FechaVencimiento.Location = New System.Drawing.Point(388, 12)
        Me.FechaVencimiento.Name = "FechaVencimiento"
        Me.FechaVencimiento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaVencimiento.Properties.Appearance.Options.UseFont = True
        Me.FechaVencimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaVencimiento.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaVencimiento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.FechaVencimiento.Size = New System.Drawing.Size(112, 20)
        Me.FechaVencimiento.StyleController = Me.LayoutControl1
        Me.FechaVencimiento.TabIndex = 157
        '
        'etDif
        '
        Me.etDif.Location = New System.Drawing.Point(665, 381)
        Me.etDif.Name = "etDif"
        Me.etDif.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etDif.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDif.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Maroon
        Me.etDif.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.etDif.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.etDif.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.etDif.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.etDif.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.etDif.Properties.Mask.EditMask = "n2"
        Me.etDif.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.etDif.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.etDif.Properties.ReadOnly = True
        Me.etDif.Size = New System.Drawing.Size(117, 24)
        Me.etDif.StyleController = Me.LayoutControl1
        Me.etDif.TabIndex = 156
        '
        'etHaber
        '
        Me.etHaber.Location = New System.Drawing.Point(377, 381)
        Me.etHaber.Name = "etHaber"
        Me.etHaber.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etHaber.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etHaber.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Maroon
        Me.etHaber.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.etHaber.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.etHaber.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.etHaber.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.etHaber.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.etHaber.Properties.Mask.EditMask = "n2"
        Me.etHaber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.etHaber.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.etHaber.Properties.ReadOnly = True
        Me.etHaber.Size = New System.Drawing.Size(182, 24)
        Me.etHaber.StyleController = Me.LayoutControl1
        Me.etHaber.TabIndex = 155
        '
        'etDebe
        '
        Me.etDebe.Location = New System.Drawing.Point(114, 381)
        Me.etDebe.Name = "etDebe"
        Me.etDebe.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etDebe.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDebe.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Maroon
        Me.etDebe.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.etDebe.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.etDebe.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.etDebe.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.etDebe.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.etDebe.Properties.Mask.EditMask = "n2"
        Me.etDebe.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.etDebe.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.etDebe.Properties.ReadOnly = True
        Me.etDebe.Size = New System.Drawing.Size(157, 24)
        Me.etDebe.StyleController = Me.LayoutControl1
        Me.etDebe.TabIndex = 153
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.ImageOptions.Image = CType(resources.GetObject("btnSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(684, 409)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(98, 38)
        Me.btnSalir.StyleController = Me.LayoutControl1
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "&Salir"
        '
        'txtAlcaldia
        '
        Me.txtAlcaldia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAlcaldia.EditValue = 0
        Me.txtAlcaldia.Location = New System.Drawing.Point(606, 166)
        Me.txtAlcaldia.Name = "txtAlcaldia"
        Me.txtAlcaldia.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtAlcaldia.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlcaldia.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtAlcaldia.Properties.Appearance.Options.UseBackColor = True
        Me.txtAlcaldia.Properties.Appearance.Options.UseFont = True
        Me.txtAlcaldia.Properties.Appearance.Options.UseForeColor = True
        Me.txtAlcaldia.Properties.Mask.EditMask = "n2"
        Me.txtAlcaldia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAlcaldia.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAlcaldia.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAlcaldia.Size = New System.Drawing.Size(176, 22)
        Me.txtAlcaldia.StyleController = Me.LayoutControl1
        Me.txtAlcaldia.TabIndex = 17
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.ImageOptions.Image = Global.SysContab.My.Resources.Resources.RibbonUserDesigner_SaveFileLarge
        Me.btnGuardar.Location = New System.Drawing.Point(579, 409)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(101, 38)
        Me.btnGuardar.StyleController = Me.LayoutControl1
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "&Guardar"
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.Location = New System.Drawing.Point(114, 193)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtNombre.Properties.Appearance.Options.UseBackColor = True
        Me.txtNombre.Properties.Appearance.Options.UseFont = True
        Me.txtNombre.Properties.Appearance.Options.UseForeColor = True
        Me.txtNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Size = New System.Drawing.Size(668, 22)
        Me.txtNombre.StyleController = Me.LayoutControl1
        Me.txtNombre.TabIndex = 152
        '
        'lblProvID
        '
        Me.lblProvID.Location = New System.Drawing.Point(153, 409)
        Me.lblProvID.Name = "lblProvID"
        Me.lblProvID.Size = New System.Drawing.Size(138, 28)
        Me.lblProvID.TabIndex = 145
        Me.lblProvID.Text = "Cuenta Proveedor"
        Me.lblProvID.Visible = False
        '
        'etCodigoProveedor
        '
        Me.etCodigoProveedor.Location = New System.Drawing.Point(436, 409)
        Me.etCodigoProveedor.Name = "etCodigoProveedor"
        Me.etCodigoProveedor.Size = New System.Drawing.Size(139, 28)
        Me.etCodigoProveedor.TabIndex = 148
        Me.etCodigoProveedor.Text = "Codigo Proveedor"
        Me.etCodigoProveedor.Visible = False
        '
        'lblFactMonto
        '
        Me.lblFactMonto.Location = New System.Drawing.Point(295, 409)
        Me.lblFactMonto.Name = "lblFactMonto"
        Me.lblFactMonto.Size = New System.Drawing.Size(137, 28)
        Me.lblFactMonto.TabIndex = 147
        Me.lblFactMonto.Text = "Monto"
        Me.lblFactMonto.Visible = False
        '
        'gridDatos
        '
        Me.gridDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDatos.Location = New System.Drawing.Point(12, 253)
        Me.gridDatos.MainView = Me.vTrans
        Me.gridDatos.Name = "gridDatos"
        Me.gridDatos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtDebe, Me.txtHaber, Me.cbCuentas})
        Me.gridDatos.Size = New System.Drawing.Size(770, 124)
        Me.gridDatos.TabIndex = 0
        Me.gridDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vTrans, Me.GridView1})
        '
        'vTrans
        '
        Me.vTrans.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.cTipo, Me.cBorrar, Me.GridColumn2})
        Me.vTrans.GridControl = Me.gridDatos
        Me.vTrans.Name = "vTrans"
        Me.vTrans.OptionsCustomization.AllowFilter = False
        Me.vTrans.OptionsCustomization.AllowSort = False
        Me.vTrans.OptionsFilter.AllowFilterEditor = False
        Me.vTrans.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.vTrans.OptionsView.ShowFooter = True
        Me.vTrans.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Cuenta"
        Me.GridColumn1.ColumnEdit = Me.cbCuentas
        Me.GridColumn1.FieldName = "Cuenta"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 253
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
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Débito"
        Me.GridColumn3.ColumnEdit = Me.txtDebe
        Me.GridColumn3.FieldName = "Debe"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debe", "{0:n2}")})
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 106
        '
        'txtDebe
        '
        Me.txtDebe.AutoHeight = False
        Me.txtDebe.Mask.EditMask = "n2"
        Me.txtDebe.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDebe.Mask.UseMaskAsDisplayFormat = True
        Me.txtDebe.Name = "txtDebe"
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Crédito"
        Me.GridColumn4.ColumnEdit = Me.txtHaber
        Me.GridColumn4.FieldName = "Haber"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Haber", "{0:n2}")})
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 124
        '
        'txtHaber
        '
        Me.txtHaber.AutoHeight = False
        Me.txtHaber.Mask.EditMask = "n2"
        Me.txtHaber.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtHaber.Mask.UseMaskAsDisplayFormat = True
        Me.txtHaber.Name = "txtHaber"
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn5.AppearanceHeader.Options.UseFont = True
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Descripción"
        Me.GridColumn5.DisplayFormat.FormatString = "{0:dd/MM/yyyy}"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn5.FieldName = "Descripcion"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 215
        '
        'cTipo
        '
        Me.cTipo.Caption = "Tipo"
        Me.cTipo.FieldName = "Tipo"
        Me.cTipo.Name = "cTipo"
        Me.cTipo.OptionsColumn.AllowEdit = False
        Me.cTipo.OptionsColumn.AllowFocus = False
        '
        'cBorrar
        '
        Me.cBorrar.Caption = "Borrar"
        Me.cBorrar.FieldName = "Borrar"
        Me.cBorrar.Name = "cBorrar"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Detalle"
        Me.GridColumn2.FieldName = "Detalle"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.AllowFocus = False
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gridDatos
        Me.GridView1.Name = "GridView1"
        '
        'chkAlcaldia
        '
        Me.chkAlcaldia.Checked = True
        Me.chkAlcaldia.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAlcaldia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAlcaldia.ForeColor = System.Drawing.Color.Navy
        Me.chkAlcaldia.Location = New System.Drawing.Point(12, 169)
        Me.chkAlcaldia.Name = "chkAlcaldia"
        Me.chkAlcaldia.Size = New System.Drawing.Size(488, 20)
        Me.chkAlcaldia.TabIndex = 18
        Me.chkAlcaldia.Text = "Aplicar I.R Alcaldia"
        '
        'etFecha
        '
        Me.etFecha.Location = New System.Drawing.Point(12, 409)
        Me.etFecha.Name = "etFecha"
        Me.etFecha.Size = New System.Drawing.Size(137, 28)
        Me.etFecha.TabIndex = 149
        Me.etFecha.Text = "Fecha"
        Me.etFecha.Visible = False
        '
        'etMontoIR
        '
        Me.etMontoIR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etMontoIR.EditValue = 0
        Me.etMontoIR.Location = New System.Drawing.Point(606, 140)
        Me.etMontoIR.Name = "etMontoIR"
        Me.etMontoIR.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.etMontoIR.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etMontoIR.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.etMontoIR.Properties.Appearance.Options.UseBackColor = True
        Me.etMontoIR.Properties.Appearance.Options.UseFont = True
        Me.etMontoIR.Properties.Appearance.Options.UseForeColor = True
        Me.etMontoIR.Properties.Mask.EditMask = "n2"
        Me.etMontoIR.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.etMontoIR.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.etMontoIR.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.etMontoIR.Size = New System.Drawing.Size(176, 22)
        Me.etMontoIR.StyleController = Me.LayoutControl1
        Me.etMontoIR.TabIndex = 15
        '
        'txtComentarios
        '
        Me.txtComentarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComentarios.Location = New System.Drawing.Point(114, 219)
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComentarios.Properties.Appearance.Options.UseFont = True
        Me.txtComentarios.Size = New System.Drawing.Size(668, 30)
        Me.txtComentarios.StyleController = Me.LayoutControl1
        Me.txtComentarios.TabIndex = 2
        '
        'etInicio
        '
        Me.etInicio.Location = New System.Drawing.Point(226, 12)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(6, 13)
        Me.etInicio.StyleController = Me.LayoutControl1
        Me.etInicio.TabIndex = 17
        Me.etInicio.Text = "0"
        Me.etInicio.Visible = False
        '
        'cbAlma
        '
        Me.cbAlma.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbAlma.Location = New System.Drawing.Point(493, 116)
        Me.cbAlma.Name = "cbAlma"
        Me.cbAlma.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAlma.Properties.Appearance.Options.UseFont = True
        Me.cbAlma.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbAlma.Properties.PopupFormMinSize = New System.Drawing.Size(500, 0)
        Me.cbAlma.Properties.ShowFooter = False
        Me.cbAlma.Size = New System.Drawing.Size(289, 20)
        Me.cbAlma.StyleController = Me.LayoutControl1
        Me.cbAlma.TabIndex = 16
        '
        'txtBalance
        '
        Me.txtBalance.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBalance.Location = New System.Drawing.Point(606, 38)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtBalance.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtBalance.Properties.Appearance.Options.UseBackColor = True
        Me.txtBalance.Properties.Appearance.Options.UseFont = True
        Me.txtBalance.Properties.Appearance.Options.UseForeColor = True
        Me.txtBalance.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBalance.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Navy
        Me.txtBalance.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtBalance.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtBalance.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtBalance.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtBalance.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtBalance.Properties.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(176, 20)
        Me.txtBalance.StyleController = Me.LayoutControl1
        Me.txtBalance.TabIndex = 14
        '
        'rgIR
        '
        Me.rgIR.EditValue = 2
        Me.rgIR.Location = New System.Drawing.Point(12, 140)
        Me.rgIR.Name = "rgIR"
        Me.rgIR.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgIR.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.rgIR.Properties.Appearance.Options.UseFont = True
        Me.rgIR.Properties.Appearance.Options.UseForeColor = True
        Me.rgIR.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "I.R Productos/Servicio"), New DevExpress.XtraEditors.Controls.RadioGroupItem(10, "I.R Servicios")})
        Me.rgIR.Size = New System.Drawing.Size(488, 25)
        Me.rgIR.StyleController = Me.LayoutControl1
        Me.rgIR.TabIndex = 1
        '
        'lblProv
        '
        Me.lblProv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProv.Location = New System.Drawing.Point(114, 64)
        Me.lblProv.Name = "lblProv"
        Me.lblProv.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.lblProv.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProv.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblProv.Properties.Appearance.Options.UseBackColor = True
        Me.lblProv.Properties.Appearance.Options.UseFont = True
        Me.lblProv.Properties.Appearance.Options.UseForeColor = True
        Me.lblProv.Properties.ReadOnly = True
        Me.lblProv.Size = New System.Drawing.Size(386, 22)
        Me.lblProv.StyleController = Me.LayoutControl1
        Me.lblProv.TabIndex = 10
        '
        'cbCatalogo
        '
        Me.cbCatalogo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCatalogo.Location = New System.Drawing.Point(114, 116)
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCatalogo.Properties.Appearance.Options.UseFont = True
        Me.cbCatalogo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo.Properties.PopupFormMinSize = New System.Drawing.Size(500, 0)
        Me.cbCatalogo.Properties.ShowFooter = False
        Me.cbCatalogo.Size = New System.Drawing.Size(273, 20)
        Me.cbCatalogo.StyleController = Me.LayoutControl1
        Me.cbCatalogo.TabIndex = 8
        '
        'Fecha
        '
        Me.Fecha.EditValue = New Date(2009, 2, 3, 11, 36, 23, 781)
        Me.Fecha.Enabled = False
        Me.Fecha.Location = New System.Drawing.Point(114, 12)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.Fecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Properties.Appearance.Options.UseFont = True
        Me.Fecha.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fecha.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.Fecha.Properties.AppearanceDisabled.Options.UseFont = True
        Me.Fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Fecha.Size = New System.Drawing.Size(108, 20)
        Me.Fecha.StyleController = Me.LayoutControl1
        Me.Fecha.TabIndex = 0
        '
        'txtNoCheque
        '
        Me.txtNoCheque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNoCheque.Location = New System.Drawing.Point(606, 12)
        Me.txtNoCheque.Name = "txtNoCheque"
        Me.txtNoCheque.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtNoCheque.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoCheque.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.txtNoCheque.Properties.Appearance.Options.UseBackColor = True
        Me.txtNoCheque.Properties.Appearance.Options.UseFont = True
        Me.txtNoCheque.Properties.Appearance.Options.UseForeColor = True
        Me.txtNoCheque.Size = New System.Drawing.Size(176, 22)
        Me.txtNoCheque.StyleController = Me.LayoutControl1
        Me.txtNoCheque.TabIndex = 12
        '
        'lblFact
        '
        Me.lblFact.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFact.Location = New System.Drawing.Point(114, 38)
        Me.lblFact.Name = "lblFact"
        Me.lblFact.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.lblFact.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFact.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.lblFact.Properties.Appearance.Options.UseBackColor = True
        Me.lblFact.Properties.Appearance.Options.UseFont = True
        Me.lblFact.Properties.Appearance.Options.UseForeColor = True
        Me.lblFact.Properties.ReadOnly = True
        Me.lblFact.Size = New System.Drawing.Size(386, 22)
        Me.lblFact.StyleController = Me.LayoutControl1
        Me.lblFact.TabIndex = 4
        '
        'txtTasa
        '
        Me.txtTasa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTasa.Location = New System.Drawing.Point(606, 64)
        Me.txtTasa.Name = "txtTasa"
        Me.txtTasa.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtTasa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasa.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.txtTasa.Properties.Appearance.Options.UseBackColor = True
        Me.txtTasa.Properties.Appearance.Options.UseFont = True
        Me.txtTasa.Properties.Appearance.Options.UseForeColor = True
        Me.txtTasa.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTasa.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasa.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Navy
        Me.txtTasa.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTasa.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTasa.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTasa.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtTasa.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTasa.Properties.Mask.EditMask = "n4"
        Me.txtTasa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTasa.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTasa.Properties.ReadOnly = True
        Me.txtTasa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTasa.Size = New System.Drawing.Size(176, 20)
        Me.txtTasa.StyleController = Me.LayoutControl1
        Me.txtTasa.TabIndex = 2
        '
        'txtMoneda
        '
        Me.txtMoneda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMoneda.Location = New System.Drawing.Point(606, 90)
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtMoneda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMoneda.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtMoneda.Properties.Appearance.Options.UseBackColor = True
        Me.txtMoneda.Properties.Appearance.Options.UseFont = True
        Me.txtMoneda.Properties.Appearance.Options.UseForeColor = True
        Me.txtMoneda.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMoneda.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Navy
        Me.txtMoneda.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtMoneda.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtMoneda.Properties.ReadOnly = True
        Me.txtMoneda.Size = New System.Drawing.Size(176, 22)
        Me.txtMoneda.StyleController = Me.LayoutControl1
        Me.txtMoneda.TabIndex = 3
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.EmptySpaceItem1, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem14, Me.LayoutControlItem15, Me.LayoutControlItem13, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem18, Me.LayoutControlItem23, Me.LayoutControlItem24, Me.EmptySpaceItem2, Me.LayoutControlItem22, Me.LayoutControlItem20, Me.LayoutControlItem21, Me.LayoutControlItem19, Me.LayoutControlItem25, Me.LayoutControlItem26, Me.LayoutControlItem27, Me.LayoutControlItem28})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(794, 459)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Fecha
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(214, 26)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(214, 26)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(214, 26)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Fecha:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtNoCheque
        Me.LayoutControlItem2.Location = New System.Drawing.Point(492, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(282, 26)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(282, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(282, 26)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "#Cheque:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.lblFact
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(492, 26)
        Me.LayoutControlItem3.Text = "Factura(s):"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtBalance
        Me.LayoutControlItem4.Location = New System.Drawing.Point(492, 26)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(282, 26)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(282, 26)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(282, 26)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "Balance:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.lblProv
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(492, 26)
        Me.LayoutControlItem5.Text = "Proveedor:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtTasa
        Me.LayoutControlItem6.Location = New System.Drawing.Point(492, 52)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(282, 26)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(282, 26)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(282, 26)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "T/Cambio:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cbBanco
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 78)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(492, 26)
        Me.LayoutControlItem7.Text = "Banco:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtMoneda
        Me.LayoutControlItem8.Location = New System.Drawing.Point(492, 78)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(282, 26)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(282, 26)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(282, 26)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.Text = "Moneda:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cbCatalogo
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 104)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(379, 24)
        Me.LayoutControlItem9.Text = "Cuenta IR:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(99, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(224, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(50, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cbAlma
        Me.LayoutControlItem10.Location = New System.Drawing.Point(379, 104)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(395, 24)
        Me.LayoutControlItem10.Text = "Cuenta IR Municipal:"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.etInicio
        Me.LayoutControlItem11.Location = New System.Drawing.Point(214, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(10, 26)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        Me.LayoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.rgIR
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 128)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(492, 29)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.etMontoIR
        Me.LayoutControlItem14.Location = New System.Drawing.Point(492, 128)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(282, 26)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(282, 26)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(282, 26)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.Text = "Monto IR:"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.txtAlcaldia
        Me.LayoutControlItem15.Location = New System.Drawing.Point(492, 154)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(282, 27)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(282, 27)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(282, 27)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.Text = "Monto IR Municipal:"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.chkAlcaldia
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 157)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(492, 24)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.txtNombre
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 181)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(774, 26)
        Me.LayoutControlItem16.Text = "A Nombre de:"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.gridDatos
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 241)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(774, 128)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.txtComentarios
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 207)
        Me.LayoutControlItem18.MaxSize = New System.Drawing.Size(0, 34)
        Me.LayoutControlItem18.MinSize = New System.Drawing.Size(117, 34)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(774, 34)
        Me.LayoutControlItem18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem18.Text = "Concepto:"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.btnGuardar
        Me.LayoutControlItem23.Location = New System.Drawing.Point(567, 397)
        Me.LayoutControlItem23.MaxSize = New System.Drawing.Size(105, 42)
        Me.LayoutControlItem23.MinSize = New System.Drawing.Size(105, 42)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(105, 42)
        Me.LayoutControlItem23.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem23.TextVisible = False
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.btnSalir
        Me.LayoutControlItem24.Location = New System.Drawing.Point(672, 397)
        Me.LayoutControlItem24.MaxSize = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem24.MinSize = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem24.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem24.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 429)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(567, 10)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.lblProvID
        Me.LayoutControlItem22.Location = New System.Drawing.Point(141, 397)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(142, 32)
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem22.TextVisible = False
        Me.LayoutControlItem22.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.lblFactMonto
        Me.LayoutControlItem20.Location = New System.Drawing.Point(283, 397)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(141, 32)
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextVisible = False
        Me.LayoutControlItem20.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.etCodigoProveedor
        Me.LayoutControlItem21.Location = New System.Drawing.Point(424, 397)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(143, 32)
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem21.TextVisible = False
        Me.LayoutControlItem21.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.etFecha
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 397)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(141, 32)
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        Me.LayoutControlItem19.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.etDebe
        Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 369)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(263, 28)
        Me.LayoutControlItem25.Text = "Debe:"
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.etHaber
        Me.LayoutControlItem26.Location = New System.Drawing.Point(263, 369)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(288, 28)
        Me.LayoutControlItem26.Text = "Haber:"
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.etDif
        Me.LayoutControlItem27.Location = New System.Drawing.Point(551, 369)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(223, 28)
        Me.LayoutControlItem27.Text = "Diferencia:"
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.Control = Me.FechaVencimiento
        Me.LayoutControlItem28.Location = New System.Drawing.Point(274, 0)
        Me.LayoutControlItem28.MaxSize = New System.Drawing.Size(218, 26)
        Me.LayoutControlItem28.MinSize = New System.Drawing.Size(218, 26)
        Me.LayoutControlItem28.Name = "LayoutControlItem28"
        Me.LayoutControlItem28.Size = New System.Drawing.Size(218, 26)
        Me.LayoutControlItem28.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem28.Text = "Fecha Vencimiento:"
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(99, 13)
        '
        'frmPagoFacturas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(794, 459)
        Me.Controls.Add(Me.LayoutControl1)
        Me.LookAndFeel.SkinName = "Blue"
        Me.Name = "frmPagoFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagos a Proveedores"
        CType(Me.cbBanco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.FechaVencimiento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaVencimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etDif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etHaber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etDebe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlcaldia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDebe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHaber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etMontoIR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComentarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbAlma.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBalance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgIR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblProv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoCheque.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFact.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ds As DataSet
    Dim dsCB As DataSet
    Dim TipoCompr As String
    Dim PorcentajeIR As Double

    Dim Plantilla As New VB.SysContab.PlantillaDB
    Dim r As New VB.SysContab.Rutinas
    Dim Comp As New VB.SysContab.ComprobanteDB
    Dim Proveedores As New VB.SysContab.ProveedoresDB
    Dim Config As New VB.SysContab.ConfiguracionDB
    Dim ConfigDet As VB.SysContab.ConfiguracionDetails = Config.GetConfigDetails()
    Dim CatBancos As New VB.SysContab.Catalogo_BancosDB
    Dim TasaCambio As New VB.SysContab.Tasa_CambioDB
    Dim TCambio As Double = 1
    Public TasaPago As Double = 1
    Dim Temp As Boolean = False

#Region "Variables Publicas"
    Public OK As String
    Public dtFact As DataTable

    Public Comp_No, Mes, Per_ID, FormaPago As String
    Public ComprasCredito, SubTotal, SubTotalUS As String

    Public Monto_IR_Pagado, Monto_IR_Pagado_Alcaldia, MontoIVAasumido, MontoIRxPagar, SubTotalIRxPagar As Double
    Public FactValor, Monto_IR_PagadoUS, Monto_IR_Pagado_AlcaldiaUS, MontoIVAasumidoUS, MontoIRxPagarUS, SubTotalIRxPagarUS, _
           MontoIR_ALMAxPagar, SubTotalIR_ALMAxPagar As Double

    Public IR_Pagado_Alcaldia, IRPagado, IVAAsumido, SegundoIR As Boolean

    Public CompFact As String
    Public SaldoFact As String, FactPagar As String, FactSubTotalIR As String, FactIR As String
    Public EsqID, PlaID As Integer

    Public FactMnto As Double
    Dim CuentaMtto As String

    Dim IRRegla3 As Double
    Dim CompNo As Integer = 0

#End Region

    Private DT_Distribucion As DataTable = New DataTable("Distribucion")

    Private Sub Distribucion()
        DT_Distribucion = CargaDistribucion(0, 0, 0)
    End Sub

    Private Sub frmPagoFacturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Distribucion()
        Me.etInicio.Text = "1"
        Cargar()
        Me.txtNombre.Text = Me.lblProv.Text
        'Me.txtComentarios.Text = String.Empty
    End Sub

    Sub Cargar()

        '***** Validar IR ********************************
        Me.rgIR.Enabled = IRPagado
        Me.cbCatalogo.Enabled = IRPagado
        Me.etMontoIR.Enabled = IRPagado
        PorcentajeIR = ConfigDet.IRProd
        Me.rgIR.EditValue = 2

        'Validando Retencia ALMA
        Me.chkAlcaldia.Enabled = IR_Pagado_Alcaldia
        Me.chkAlcaldia.Checked = IR_Pagado_Alcaldia
        Me.cbAlma.Enabled = IR_Pagado_Alcaldia
        Me.txtAlcaldia.Enabled = IR_Pagado_Alcaldia

        Me.chkAlcaldia.Checked = False
        Me.chkAlcaldia.Enabled = False
        '***************************************************

        Me.cbBanco.Properties.DataSource = ObtieneDatos("SP_GetCatalogoBancos " & EmpresaActual).DefaultView
        Me.cbBanco.Properties.ValueMember = "Cuenta"
        Me.cbBanco.Properties.DisplayMember = "Nombre"
        Me.cbBanco.Properties.PopulateColumns()

        Me.cbBanco.Properties.Columns("Codigo").Visible = False
        Me.cbBanco.Properties.Columns("Orden").Visible = False
        Me.cbBanco.Properties.Columns("Cod").Visible = False
        Me.cbBanco.ItemIndex = 0

        Me.cbAlma.Properties.DataSource = ObtieneDatos("_GetCuentasRetencion " & EmpresaActual)
        Me.cbAlma.Properties.ValueMember = "CUENTA"
        Me.cbAlma.Properties.DisplayMember = "Display"
        Me.cbAlma.Properties.PopulateColumns()
        Me.cbAlma.Properties.Columns("Display").Visible = False
        Me.cbAlma.ItemIndex = 0

        Me.cbCatalogo.Properties.DataSource = ObtieneDatos("_GetCuentasRetencion " & EmpresaActual)
        Me.cbCatalogo.Properties.ValueMember = "CUENTA"
        Me.cbCatalogo.Properties.DisplayMember = "Display"
        Me.cbCatalogo.Properties.PopulateColumns()
        Me.cbCatalogo.Properties.Columns("Display").Visible = False
        Me.cbCatalogo.ItemIndex = 0

        RepositorySearchLook(cbCuentas, ObtieneDatos("_GetCatalogo_CuentaActivo", EmpresaActual), "Cuenta", "Cuenta", 2)

        Dim f As frmListaFacturaProveedoresPlan = frmListaFacturaProveedoresPlan.Instance()
        Fecha.DateTime = f.fecha.DateTime
        FechaVencimiento.DateTime = Fecha.DateTime

        Dim Detalles As VB.SysContab.PlantillaDetails = Plantilla.GetPlantillasDetails(RegistroPlantilla)
        ds = Detalles.Detalles

        'Buscar Comprobante de Cheque
        TipoCompr = ObtieneDatos("SELECT tc.TipComp_Id Tipo FROM TipoComprobantes tc WHERE tc.TipComp_Cheque = 1 AND tc.Empresa =" & EmpresaActual).Rows.Item(0)(0)
        EsqID = Detalles.EsquemaID
        PlaID = Detalles.PlaID
        Me.cbCatalogo.EditValue = ds.Tables("PlantillasDetalles").Rows(0).Item("Cuenta").ToString

        If FactMnto <> 0 Then
            Try
                'Buscar las Cuentas de Matto Valor
                Dim DsPlantillas As DataSet = Plantilla.GetPlantillasDetails(7, 1).Detalles
                'CuentaIMtto = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
                CuentaMtto = IIf(FactMnto > 0, DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta"), DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta"))
            Catch ex As Exception
                XtraMsg("Hace Falta la Plantilla de Mantenimiento de Valor", MessageBoxIcon.Error)
                Me.btnGuardar.Enabled = False
            End Try
        End If

        ''Verificar si el proveedor es Exento de IR
        'If CBool(VB.SysContab.ProveedoresDB.GetDetails(Me.etCodigoProveedor.Text).Exento) = True Or SubTotalIRxPagar < Config.GetConfigDetails().MontoIR Then
        '    Me.rgIR.Enabled = False
        '    Me.cbCatalogo.Enabled = False
        'End If
        'If Me.pIR.Enabled = True Then

        If Me.rgIR.Enabled = True Then
            CalcularIR_Regla3()
        End If

        'If Me.chkAlcaldia.Checked Then CalcularIR_ALMA()

        If VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MonedaBase = dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("mon_codigo").ToString Then
            ObenerMontosC(Me.cbCatalogo.EditValue)
        Else
            ObenerMontosU(Me.cbCatalogo.EditValue)
        End If
    End Sub

    Sub ObenerMontosC(ByVal CuentaIR As String)

        CrearTabla()
        CalcularIR_Regla3()
        If Me.chkAlcaldia.Checked Then CalcularIR_ALMA()

        Dim dr As DataRow

        '' Proveedor
        dr = dtFact.NewRow

        dr("Cuenta") = lblProvID.Text
        dr("Debe") = CDbl(CDbl(lblFactMonto.Text) - FactMnto)
        dr("Haber") = 0.0
        dr("Descripcion") = lblProv.Text
        dr("Tipo") = 1
        dr("Borrar") = 0
        dr("Detalle") = 1

        dtFact.Rows.Add(dr)

        '' Mantenimiento de Valor
        If FactMnto <> 0 Then
            dr = dtFact.NewRow

            dr("Cuenta") = CuentaMtto
            dr("Debe") = IIf(FactMnto > 0, CDbl(FactMnto), 0.00)
            dr("Haber") = IIf(FactMnto < 0, FactMnto * -1, 0.0)
            dr("Descripcion") = "Mantenimiento de Valor"
            dr("Tipo") = 0
            dr("Borrar") = 1
            dr("Detalle") = 1

            dtFact.Rows.Add(dr)
        End If

        '' Banco
        dr = dtFact.NewRow

        dr("Cuenta") = Me.cbBanco.EditValue
        dr("Debe") = 0.0
        dr("Haber") = CDbl((CDbl(Me.lblFactMonto.Text) - CDbl(Me.etMontoIR.Text) - CDbl(Me.txtAlcaldia.Text)))
        dr("Descripcion") = Me.cbBanco.GetColumnValue("Descripcion").ToString    '"Banco"
        dr("Tipo") = 1
        dr("Borrar") = 0
        dr("Detalle") = 0

        dtFact.Rows.Add(dr)

        ''  I.R
        If Me.rgIR.Enabled = True And Me.etMontoIR.EditValue > 0 Then
            CalcularIR()
            dr = dtFact.NewRow

            dr("Cuenta") = Me.cbCatalogo.EditValue
            dr("Debe") = 0.0
            dr("Haber") = CDbl(Me.etMontoIR.Text)
            dr("Descripcion") = PorcentajeIR.ToString & "%" & " de I.R"
            dr("Tipo") = 0
            dr("Borrar") = 1
            dr("Detalle") = 1

            dtFact.Rows.Add(dr)
        End If

        If Me.chkAlcaldia.Enabled And txtAlcaldia.EditValue > 0 Then
            CalcularIR_ALMA()
            dr = dtFact.NewRow

            dr("Cuenta") = Me.cbAlma.EditValue
            dr("Debe") = 0.0
            dr("Haber") = CDbl(Me.txtAlcaldia.Text)
            dr("Descripcion") = "1% I.R Alcaldia"
            dr("Tipo") = 0
            dr("Borrar") = 1
            dr("Detalle") = 1

            dtFact.Rows.Add(dr)
        End If


        Me.gridDatos.DataSource = dtFact
        Totales()
    End Sub

    Sub ObenerMontosU(ByVal CuentaIR As String)
        CrearTabla()
        CalcularIR_Regla3()
        If Me.chkAlcaldia.Checked Then CalcularIR_ALMA()

        Dim dr As DataRow

        '' Proveedor
        dr = dtFact.NewRow

        dr("Cuenta") = Me.lblProvID.Text
        dr("Debe") = CDbl((CDbl(Me.lblFactMonto.Text) - FactMnto) / TCambio)
        dr("Haber") = 0.0
        dr("Descripcion") = Me.lblProv.Text
        dr("Tipo") = 1
        dr("Borrar") = 0
        dr("Detalle") = 1

        dtFact.Rows.Add(dr)

        '' Mantenimiento de Valor
        If FactMnto <> 0 Then
            dr = dtFact.NewRow

            dr("Cuenta") = CuentaMtto
            dr("Debe") = IIf(FactMnto > 0, CDbl(FactMnto / TCambio), 0.00)
            dr("Haber") = IIf(FactMnto < 0, (FactMnto / TCambio) * -1, 0.00)
            dr("Descripcion") = "Mantenimiento de Valor"
            dr("Tipo") = 0
            dr("Borrar") = 1
            dr("Detalle") = 1

            dtFact.Rows.Add(dr)
        End If

        '' Banco
        dr = dtFact.NewRow

        dr("Cuenta") = Me.cbBanco.EditValue
        dr("Debe") = 0.0
        dr("Haber") = CDbl((CDbl(CDbl(Me.lblFactMonto.Text) / TCambio) - CDbl(Me.etMontoIR.Text) - CDbl(Me.txtAlcaldia.Text)))
        dr("Descripcion") = Me.cbBanco.GetColumnValue("Descripcion").ToString    '"Banco"
        dr("Tipo") = 1
        dr("Borrar") = 0
        dr("Detalle") = 0

        dtFact.Rows.Add(dr)

        ' I.R
        If Me.rgIR.Enabled = True And Me.etMontoIR.EditValue > 0 Then
            CalcularIR()
            dr = dtFact.NewRow

            dr("Cuenta") = Me.cbCatalogo.EditValue
            dr("Debe") = 0.0
            dr("Haber") = CDbl(Me.etMontoIR.Text)
            dr("Descripcion") = PorcentajeIR.ToString & "%" & " de I.R"
            dr("Tipo") = 0
            dr("Borrar") = 1
            dr("Detalle") = 1

            dtFact.Rows.Add(dr)
        End If

        ' Alcaldia
        If Me.chkAlcaldia.Enabled And txtAlcaldia.EditValue > 0 Then
            CalcularIR_ALMA()
            dr = dtFact.NewRow

            dr("Cuenta") = Me.cbAlma.EditValue
            dr("Debe") = 0.0
            dr("Haber") = CDbl(Me.txtAlcaldia.Text)
            dr("Descripcion") = "1% I.R Alcaldia"
            dr("Tipo") = 0
            dr("Borrar") = 1
            dr("Detalle") = 1

            dtFact.Rows.Add(dr)
        End If

        Me.gridDatos.DataSource = dtFact
        Totales()
    End Sub

    Sub CalcularIR_Regla3()
        Try
            If Me.rgIR.Enabled Then
                dsCB = CatBancos.CatalogoBancosXCuenta(Me.cbBanco.EditValue)    'Obtener Detalle del Banco

                '****** Validar Moneda *****
                If VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MonedaBase = dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("mon_codigo").ToString Then
                    'Calcular SubTotal para IR con Regla de 3
                    Me.etMontoIR.Text = CDbl(Me.SubTotalIRxPagar * (PorcentajeIR / 100)).ToString("n2")
                    IRRegla3 = CDbl(Me.etMontoIR.Text) / (PorcentajeIR / 100)
                Else
                    Me.etMontoIR.Text = CDbl((Me.SubTotalIRxPagar / TCambio) * (PorcentajeIR / 100)).ToString("n2")
                    IRRegla3 = CDbl(Me.etMontoIR.Text) / (PorcentajeIR / 100)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub CalcularIR()
        Try
            If Me.rgIR.Enabled Then
                If Me.rgIR.EditValue = 2 Then
                    PorcentajeIR = ConfigDet.IRProd 'Calcular Porcentaje de I.R
                    CalcularIR_Regla3()
                    'Me.etMontoIR.Text = CDbl(IRRegla3 * (PorcentajeIR / 100)).ToString("n2")
                    'Me.etMontoIR.Text = CDbl((Me.SubTotalIRxPagarUS / TCambio) * (PorcentajeIR / 100)).ToString("n2")
                    'Actualizar Valores en el Comprobante

                    Me.vTrans.SetRowCellValue(2, "Haber", CDbl(Me.etMontoIR.Text))
                    Me.vTrans.SetRowCellValue(2, "Descripcion", PorcentajeIR.ToString & "%" & " de I.R")
                    Me.vTrans.SetRowCellValue(1, "Haber", CDbl((Me.vTrans.GetRowCellValue(0, "Debe") - CDbl(Me.etMontoIR.Text) - CDbl(Me.txtAlcaldia.EditValue))).ToString("n2"))

                    'Me.vTrans.SetRowCellValue(1, "Haber", CDbl((CDbl(FactValor / TCambio) - CDbl(Me.etMontoIR.Text))).ToString("n2"))
                    Totales()
                ElseIf Me.rgIR.EditValue = 10 Then
                    PorcentajeIR = ConfigDet.IRServ 'Calcular Porcentaje de I.R
                    CalcularIR_Regla3()
                    'IRRegla3 = CDbl((CDbl(Me.etMontoIR.Text) / (PorcentajeIR / 100)) / TCambio) 'Calcular SubTotal para IR con Regla de 3
                    'Me.etMontoIR.Text = CDbl(IRRegla3 * (PorcentajeIR / 100)).ToString("n2")
                    'CDbl((Me.SubTotalIRxPagarUS / TCambio) * (PorcentajeIR / 100)).ToString("n2")
                    'Actualizar Valores en el Comprobante
                    Me.vTrans.SetRowCellValue(2, "Haber", CDbl(Me.etMontoIR.Text))
                    Me.vTrans.SetRowCellValue(2, "Descripcion", PorcentajeIR.ToString & "%" & " de I.R")
                    Me.vTrans.SetRowCellValue(1, "Haber", CDbl((Me.vTrans.GetRowCellValue(0, "Debe") - CDbl(Me.etMontoIR.Text) - CDbl(Me.txtAlcaldia.Text))).ToString("n2"))
                    'Me.vTrans.SetRowCellValue(1, "Haber", CDbl((CDbl(FactValor / TCambio) - CDbl(Me.etMontoIR.Text))).ToString("n2"))
                    Totales()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub CalcularIR_ALMA()
        Try
            dsCB = CatBancos.CatalogoBancosXCuenta(Me.cbBanco.EditValue)    'Obtener Detalle del Banco
            Dim Muni As New VB.SysContab.MunicipiosDB
            Dim MunDet As VB.SysContab.MunicipioDetails = Muni.GetDetails(VB.SysContab.ProveedoresDB.GetDetails(Me.etCodigoProveedor.Text).Departamento, VB.SysContab.ProveedoresDB.GetDetails(Me.etCodigoProveedor.Text).Municipio)

            '****** Validar Moneda
            If VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MonedaBase = dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("mon_codigo").ToString Then
                Me.txtAlcaldia.EditValue = CDbl(Me.SubTotalIR_ALMAxPagar * (MunDet.Impuesto_SVenta / 100)).ToString("n2")
            Else
                Me.txtAlcaldia.EditValue = CDbl((Me.SubTotalIR_ALMAxPagar / TCambio) * (MunDet.Impuesto_SVenta / 100)).ToString("n2")
            End If

            Dim pos As Integer = 0
            If rgIR.Enabled Then
                pos = 3
            Else
                pos = 2
            End If

            Me.vTrans.SetRowCellValue(pos, "Haber", CDbl(Me.txtAlcaldia.EditValue))
            Me.vTrans.SetRowCellValue(pos, "Descripcion", "1% I.R Alcaldia")
            Me.vTrans.SetRowCellValue(1, "Haber", CDbl((Me.vTrans.GetRowCellValue(0, "Debe") - CDbl(Me.etMontoIR.Text) - CDbl(Me.txtAlcaldia.EditValue))).ToString("n2"))
        Catch ex As Exception
        End Try
    End Sub

    Sub CrearTabla()
        dtFact = Nothing
        dtFact = New DataTable

        dtFact.Columns.Add("Cuenta", Type.GetType("System.String"))
        dtFact.Columns.Add("Debe", Type.GetType("System.Decimal"))
        dtFact.Columns.Add("Haber", Type.GetType("System.Decimal"))
        dtFact.Columns.Add("Descripcion", Type.GetType("System.String"))
        dtFact.Columns.Add("Tipo", Type.GetType("System.Int32"))
        dtFact.Columns.Add("Borrar", Type.GetType("System.Int32"))
        dtFact.Columns.Add("Detalle", Type.GetType("System.Int32"))
    End Sub

    Sub Totales()        
        etDebe.EditValue = Math.Round(CDbl(vTrans.Columns("Debe").SummaryItem.SummaryValue), 2)
        etHaber.EditValue = Math.Round(CDbl(vTrans.Columns("Haber").SummaryItem.SummaryValue), 2)

        etDif.Text = Math.Round(etDebe.EditValue - etHaber.EditValue, 2)
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        OK = "NO"
        Me.Close()
    End Sub

    Private Sub cbBanco_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBanco.EditValueChanged
        If etInicio.Text = "0" Then Exit Sub

        Try
            dsCB = CatBancos.CatalogoBancosXCuenta(Me.cbBanco.EditValue)

            Me.txtMoneda.Text = dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("mon_descripcion")
            Me.txtNoCheque.Text = CatBancos.GetCheque(dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Banco"), dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Numero_Cuenta")).ToString
            Me.txtBalance.Text = CDbl(IsNull(Comp.SaldoxCuenta(Me.cbBanco.EditValue, VB.SysContab.PeriodosDB.Activo(Me.Fecha.DateTime.Date)), 0)).ToString("n2")

            If VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MonedaBase.Equals(dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("mon_codigo")) Then
                TCambio = 1
                Me.txtTasa.EditValue = TCambio
            Else
                TCambio = TasaPago
                Me.txtTasa.EditValue = TCambio
            End If

            'Me.txtTasa.Text = TasaCambio.GetTasaCambio(VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MonedaBase, _
            '            dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("mon_codigo"), Me.Fecha.DateTime.Date).Tables(0).Rows(0).Item("TCambio").ToString

            'TCambio = CDbl(Me.txtTasa.Text)

            Temp = True

            If VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MonedaBase = dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("mon_codigo").ToString Then
                ObenerMontosC(Me.cbCatalogo.EditValue)
            Else
                ObenerMontosU(Me.cbCatalogo.EditValue)
            End If


            'If CDbl(Me.txtTasa.Text) > 1 Then   'Banco U$
            '    ObenerMontosU(Me.cbCatalogo.EditValue)
            'Else    'Banco C$
            '    ObenerMontosC(Me.cbCatalogo.EditValue)
            'End If

            If FactMnto <> 0 Then
                Me.vTrans.SetRowCellValue(2, "Cuenta", Me.cbBanco.EditValue)
                Me.vTrans.SetRowCellValue(2, "Descripcion", Me.cbBanco.GetColumnValue("Descripcion").ToString())
            Else
                Me.vTrans.SetRowCellValue(1, "Cuenta", Me.cbBanco.EditValue)
                Me.vTrans.SetRowCellValue(1, "Descripcion", Me.cbBanco.GetColumnValue("Descripcion").ToString())
            End If

            Temp = False

        Catch ex As Exception
        End Try
    End Sub


    Private Sub Fecha_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fecha.EditValueChanged
        If etInicio.Text = "0" Then Exit Sub
        Try
            cbBanco_EditValueChanged(Nothing, Nothing)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        If vTrans.DataRowCount = 0 Then
            XtraMsg("No hay Facturas en la Lista")
            Exit Sub
        End If

        If txtNombre.Text.Trim.Length = 0 Then
            XtraMsg("Describa a Nombre de quien se va a elaborar el Cheque.")
            txtNombre.Focus()
            Exit Sub
        End If

        If txtComentarios.Text.Trim.Length = 0 Then
            XtraMsg("Describa un Comentario para el Comprobante de Cheque")
            txtComentarios.Focus()
            Exit Sub
        End If

        If ObtieneDatos("SELECT * FROM ComprobantesDetalles cd WHERE cd.CDet_NoChk = '" & Me.txtNoCheque.Text & "' AND cd.CDet_Cuenta = '" & Me.cbBanco.EditValue & "' AND cd.Empresa = " & EmpresaActual).Rows.Count > 0 Then
            XtraMsg("El Número de Cheque que intenta Guardar para el Banco seleccionado, YA EXISTE.", MessageBoxIcon.Error)
            txtNoCheque.Focus()
            txtNoCheque.SelectAll()
            Exit Sub
        End If

        If CDbl(Me.etDif.Text) <> 0 Then
            XtraMsg("El Comprobante Contable se Encuentra con diferencias, Favor corregir para Continuar.", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        '******** VERIFICAR DISTRIBUCION ***********************************
        For i As Integer = 0 To vTrans.DataRowCount - 1
            Dim CTemp As String = vbNullString
            Try
                CTemp = ObtieneDatos("SELECT CuentaContable FROM RubrosGastos WHERE Activo = 1 AND" _
                                     + " CuentaContable = '" & vTrans.GetRowCellValue(i, "Cuenta") & "'" _
                                     + " AND Empresa = " & EmpresaActual).Rows(0).Item(0)
            Catch ex As Exception
                CTemp = "xxx"
            End Try

            If CTemp <> "xxx" And CTemp <> vbNullString Then
                '
                If VerificaDistribucion(CTemp) = False And ObligarDistribucion = True Then
                    XtraMsg("La Cuenta " & vTrans.GetRowCellValue(i, "Cuenta").ToString & " Seleccionada es de Distribución, Favor Distribuirla " & vbCrLf &
                           "ó Verifique el Detalle de la Distribución.", MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If
        Next
        '******** FIN VERIFICAR DISTRIBUCION *****************************
        '
        Dim s, c As String
        Dim a(100), b(100), Monto(100), Saldo(100), APagar(100), Fech(100), PerFact(100) As String
        'Dim a(100), b(100) As String

        Dim Facturas As String() = Me.lblFact.Text.Split(New Char() {"|"})
        Dim Comprobante As String() = CompFact.Split(New Char() {"|"})

        Dim MontosFact As String() = Me.lblFactMonto.Text.Split(New Char() {"|"})
        'Dim MontosFact As String() = CompFact.Split(New Char() {"|"})
        Dim Saldos As String() = SaldoFact.Split(New Char() {"|"})
        Dim Abono As String() = FactPagar.Split(New Char() {"|"})
        Dim SubTotalIR As String() = FactSubTotalIR.Split(New Char() {"|"})
        Dim IR As String() = FactIR.Split(New Char() {"|"})

        Dim j As Integer = 0

        For Each s In Facturas
            Dim Ds As DataSet = Comp.GetComprobante(s.Trim, Me.etCodigoProveedor.Text)

            b(j) = Ds.Tables(0).Rows(0).Item("CDet_Importe")
            Fech(j) = Ds.Tables(0).Rows(0).Item("Factura_Fecha")
            PerFact(j) = Ds.Tables(0).Rows(0).Item("Per_Id")
            j = j + 1
            '
        Next

        Dim Per_Id As Integer = VB.SysContab.PeriodosDB.Activo(Fecha.DateTime.Date)

        '************************************************************************
        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction()

        Try

            CompNo = VB.SysContab.ComprobanteDB.AddComprobante(
                TipoCompr,
                CDbl(Me.txtTasa.Text),
                Me.txtComentarios.Text,
                dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("mon_codigo"),
                Per_Id,
                Fecha.DateTime.Date,
                "", Me.txtNombre.Text.Trim, False,
                etCodigoProveedor.Text,
                "",
                2,
                lblFact.Text,
                FechaVencimiento.DateTime.Date,
                0,
                OrigenComprobantes.CHEQUE)

            For i As Integer = 0 To Me.vTrans.DataRowCount - 1
                Dim Importe As Double = IIf(CDbl(Me.vTrans.GetRowCellValue(i, "Debe")) = 0, CDbl(Me.vTrans.GetRowCellValue(i, "Haber")), CDbl(Me.vTrans.GetRowCellValue(i, "Debe")))
                Dim DC As String = IIf(CDbl(Me.vTrans.GetRowCellValue(i, "Debe")) = 0, "C", "D")

                VB.SysContab.ComprobanteDB.AddComprobanteDetalles(
                CompNo,
                vTrans.GetRowCellValue(i, "Cuenta"),
                IsNull(vTrans.GetRowCellValue(i, "Descripcion"), ""),
                Math.Round(CDbl(Importe * TCambio), 2),
                txtNoCheque.Text,
                TipoCompr,
                DC,
                lblFact.Text,
                0,
                Fecha.DateTime.Date,
                IsNull(vTrans.GetRowCellValue(i, "Detalle"), 1))

                'IIf(i = Me.vTrans.DataRowCount - 1, 0, 1))
                'Select Case i
                '    Case 0  'Debito al Proveedor
                '        Comp.AddComprobanteDetalles(CompNo, Me.vTrans.GetRowCellValue(i, "Cuenta"), _
                '        Me.vTrans.GetRowCellValue(i, "Descripcion"), Math.Round(CDbl(Me.vTrans.GetRowCellValue(i, "Debe") * TCambio), 2), _
                '         Me.txtNoCheque.Text, TipoCompr, "D", Me.lblFact.Text, 0, Me.Fecha.DateTime.Date, 1)
                '    Case 1  'Credito al banco
                '        Comp.AddComprobanteDetalles(CompNo, Me.vTrans.GetRowCellValue(i, "Cuenta"), _
                '        Me.vTrans.GetRowCellValue(i, "Descripcion"), Math.Round(CDbl(Me.vTrans.GetRowCellValue(i, "Haber") * TCambio), 2), _
                '        Me.txtNoCheque.Text, TipoCompr, "C", Me.lblFact.Text, 0, Me.Fecha.DateTime.Date, 0)
                '    Case 2  'Credito I.R si hay.
                '        If Me.vTrans.GetRowCellValue(i, "Haber") > 0 Then
                '            Comp.AddComprobanteDetalles(CompNo, Me.vTrans.GetRowCellValue(i, "Cuenta"), _
                '                                    Me.vTrans.GetRowCellValue(i, "Descripcion"), Math.Round(CDbl(Me.vTrans.GetRowCellValue(i, "Haber") * TCambio), 2), _
                '                                    Me.txtNoCheque.Text, TipoCompr, "C", Me.lblFact.Text, 0, Me.Fecha.DateTime.Date, 1, 2)
                '        End If
                '    Case 3  'Credito I.R ALMA si hay.
                '        If Me.vTrans.GetRowCellValue(i, "Haber") > 0 Then
                '            Comp.AddComprobanteDetalles(CompNo, Me.vTrans.GetRowCellValue(i, "Cuenta"), _
                '                                    Me.vTrans.GetRowCellValue(i, "Descripcion"), Math.Round(CDbl(Me.vTrans.GetRowCellValue(i, "Haber") * TCambio), 2), _
                '                                    Me.txtNoCheque.Text, TipoCompr, "C", Me.lblFact.Text, 0, Me.Fecha.DateTime.Date, 1, 2)
                '        End If
                'End Select
            Next

            j = 0

            For Each c In Comprobante
                a(j) = c.Trim
                j = j + 1
            Next

            j = 0

            For Each c In MontosFact
                Monto(j) = c.Trim
                j = j + 1
            Next

            j = 0

            For Each c In Saldos
                Saldo(j) = c.Trim
                j = j + 1
            Next

            j = 0

            For Each c In Abono
                APagar(j) = c.Trim
                j = j + 1
            Next

            j = 0

            'For Each s In Facturas
            '    If s.Trim() <> "" Then

            '        CancelarFactura(s.Trim, Proveedor, 1)

            '        PagosFactura(a(j), PerIDFact, Fech(j), b(j), CompNo, PeriodosDB.Activo(ComprFecha), ComprFecha, s.Trim, Proveedor, FormaPago)
            '        j = j + 1

            '    End If
            'Next s

            '  Dim MontoPagar As Double = CDbl(Me.lblFactMonto.Text)

            Dim MontoPagar As Double = Math.Round(CDbl(vTrans.GetRowCellValue(0, "Debe")) * TCambio, 2)

            'If dtFact.Rows.Count > 0 Then
            '    Dim dr() As DataRow = dtFact.Select("Cuenta = '" & lblProvID.Text & "'")

            '    If dr.Length > 0 Then MontoPagar = Math.Round(CDbl(dr(0).Item("Debe")) * TCambio, 2)
            'End If

            For Each s In Facturas
                If s.Trim() <> "" Then
                    If Math.Round(MontoPagar, 2) >= Saldo(j) Then
                        Comp.CancelarFactura(s.Trim, Me.etCodigoProveedor.Text, 1)
                    End If

                    Comp.PagosFactura(a(j), PerFact(j), Fech(j),
                         APagar(j), CompNo, VB.SysContab.PeriodosDB.Activo(Me.Fecha.DateTime.Date),
                         Me.Fecha.DateTime.Date, s.Trim, Me.etCodigoProveedor.Text, 0)
                    MontoPagar -= Saldo(j)

                    ' '''Guardar Retencion
                    ' ''' Acordarme que aqui hay que buscar el Monto Original de Cada Factura Monto(j)
                    'Dim IRParcial As Double = Math.Round(CDbl((Abono(j) * IR(j)) / Monto(j)), 4)
                    'GuardaDatosTrans("SET DATEFORMAT dmy; INSERT INTO JAR_PagosIR ( Empresa, Factura, Proveedor, Fecha, SubTotal_Original, SubTotal_Parcial, IR_Porcentaje, IR_Original, IR_Parcial, Comp_No, Per_Id, Mes)" & _
                    '                 "VALUES (" & EmpresaActual & ",'" & s.Trim & "'," & etCodigoProveedor.Text & ",'" & Fecha.DateTime.Date & "', " & _
                    '                 " " & SubTotalIR(j) & ", " & SubTotalIR(j) & ", " & Math.Round(CDbl(IR(j)) / CDbl(SubTotalIR(j)), 4) & "," & IR(j) & "," & IRParcial & "," & CompNo & ", " & _
                    '                 " " & VB.SysContab.PeriodosDB.Activo(Me.Fecha.DateTime.Date) & "," & Fecha.DateTime.Month & ")")

                    j = j + 1
                End If
            Next s

            If IsNumeric(txtNoCheque.Text) Then
                Comp.ActualizarCheque(Me.cbBanco.EditValue, txtNoCheque.Text)
            End If

            VB.SysContab.Rutinas.okTransaccion()

            '-------------------------
            'Guarda la Distribucion
            '-------------------------
            '
            Dim DT_F As DataTable
            DT_F = DT_Distribucion.GetChanges(DataRowState.Added Or DataRowState.Modified Or DataRowState.Deleted)
            If Not DT_F Is Nothing Then
                For i = 0 To DT_F.Rows.Count - 1
                    With DT_F
                        If .Rows(i).RowState = DataRowState.Added Then
                            GuardaDatos("INSERT INTO Distribucion(IdEmpresa,NoComp,Mes,Per_Id,IdRubroGasto,IdCentroCosto,Valor,Tipo,Cuenta) " &
                            " VALUES(" & .Rows(i).Item("IdEmpresa") & "," & CompNo & "," & Fecha.DateTime.Month & "," &
                            VB.SysContab.PeriodosDB.Activo(Fecha.DateTime) & "," & .Rows(i).Item("IdRubroGasto") & "," & .Rows(i).Item("IdCentroCosto") & "," & .Rows(i).Item("Valor") & ",'" & .Rows(i).Item("Tipo") & "','" & .Rows(i).Item("Cuenta") & "')")
                        ElseIf .Rows(i).RowState = DataRowState.Modified Then
                            GuardaDatos("UPDATE Distribucion SET IdEmpresa=" & .Rows(i).Item("IdEmpresa") & ",NoComp = " & CompNo & ",Mes=" & Fecha.DateTime.Month & "," &
                            "Per_Id = " & VB.SysContab.PeriodosDB.Activo(Fecha.DateTime) & ",IdRubroGasto = " & .Rows(i).Item("IdRubroGasto") & ",IdCentroCosto =" & .Rows(i).Item("IdCentroCosto") & ",Valor = " & .Rows(i).Item("Valor") & "," &
                            "Tipo='" & .Rows(i).Item("Tipo") & "',Cuenta='" & .Rows(i).Item("Cuenta") & "' WHERE IdDetalle = " & .Rows(i).Item("IdDetalle"))
                        ElseIf .Rows(i).RowState = DataRowState.Deleted Then
                        End If
                    End With
                Next
            End If
            '
            'Distribucion()
            '----------------------------
            'Fin de Guarda Distribucion
            '----------------------------

            OK = "SI"

            Dim f As frmListaFacturaProveedoresPlan = frmListaFacturaProveedoresPlan.Instance()
            f.Cargar()

            Close()
        Catch ex As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            MsgBox("ERROR : " & ex.Message)
            Exit Sub
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


    Private Sub rgIR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgIR.SelectedIndexChanged
        If etInicio.Text = "0" Then Exit Sub

        CalcularIR()
    End Sub

    Private Sub cbCatalogo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCatalogo.EditValueChanged
        If etInicio.Text = "0" Then Exit Sub

        Try
            Me.vTrans.SetRowCellValue(3, "Cuenta", Me.cbCatalogo.EditValue)
            Me.vTrans.SetRowCellValue(3, "Descripcion", PorcentajeIR.ToString & "%" & " de I.R")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub etMontoIR_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles etMontoIR.EditValueChanged
        If etInicio.Text = "0" Then Exit Sub

        Try
            Me.vTrans.SetRowCellValue(2, "Haber", Me.etMontoIR.EditValue)
            Me.vTrans.SetRowCellValue(1, "Haber", Me.vTrans.GetRowCellValue(0, "Debe") - Me.etMontoIR.EditValue)

            etDebe.EditValue = Math.Round(CDbl(vTrans.Columns("Debe").SummaryItem.SummaryValue), 2)
            etHaber.EditValue = Math.Round(CDbl(vTrans.Columns("Haber").SummaryItem.SummaryValue), 2)

            etDif.Text = Math.Round(etDebe.EditValue - etHaber.EditValue, 2)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub frmPagoFacturas_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If OK = "SI" Then
            Dim f As frmListaFacturaProveedoresPlan = frmListaFacturaProveedoresPlan.Instance()
            If f.Created Then f.Cargar()
        End If
    End Sub


    Private Sub chkAlcaldia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAlcaldia.CheckedChanged
        If etInicio.Text = "0" Then Exit Sub

        If Me.chkAlcaldia.Checked Then
            Me.txtAlcaldia.Enabled = True
            CalcularIR_ALMA()
        Else
            Me.txtAlcaldia.EditValue = 0
            Me.txtAlcaldia.Enabled = False
        End If
    End Sub

    Private Sub txtAlcaldia_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAlcaldia.EditValueChanged
        If etInicio.Text = "0" Then Exit Sub

        Try
            If Me.vTrans.DataRowCount = 3 Then  'Solo Hay retencion de ALCALDIA
                Me.vTrans.SetRowCellValue(2, "Haber", Me.txtAlcaldia.EditValue)
                Me.vTrans.SetRowCellValue(1, "Haber", Me.vTrans.GetRowCellValue(0, "Debe") - Me.txtAlcaldia.EditValue)

                etDebe.EditValue = Math.Round(CDbl(vTrans.Columns("Debe").SummaryItem.SummaryValue), 2)
                etHaber.EditValue = Math.Round(CDbl(vTrans.Columns("Haber").SummaryItem.SummaryValue), 2)

                etDif.Text = Math.Round(etDebe.EditValue - etHaber.EditValue, 2)
            ElseIf Me.vTrans.DataRowCount = 4 Then 'Hay Retencion de I.R
                Me.vTrans.SetRowCellValue(3, "Haber", Me.txtAlcaldia.EditValue)
                Me.vTrans.SetRowCellValue(1, "Haber", Me.vTrans.GetRowCellValue(0, "Debe") - CDbl(Me.etMontoIR.Text) - Me.txtAlcaldia.EditValue)

                etDebe.EditValue = Math.Round(CDbl(vTrans.Columns("Debe").SummaryItem.SummaryValue), 2)
                etHaber.EditValue = Math.Round(CDbl(vTrans.Columns("Haber").SummaryItem.SummaryValue), 2)

                etDif.Text = Math.Round(etDebe.EditValue - etHaber.EditValue, 2)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub vTrans_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vTrans.CellValueChanged

        If Not Temp Then
            If e.Column.FieldName = "Cuenta" Then
                Me.vTrans.SetRowCellValue(e.RowHandle, "Debe", 0.0)
                Me.vTrans.SetRowCellValue(e.RowHandle, "Haber", 0.0)
                vTrans.SetRowCellValue(e.RowHandle, "Borrar", 1)
            End If
        End If
        '
        Totales()
    End Sub

    Private Sub vTrans_KeyDown(sender As Object, e As KeyEventArgs) Handles vTrans.KeyDown
        If vTrans.FocusedRowHandle < 0 Then Exit Sub

        If e.KeyCode = Keys.Delete Then

            If IsNull(vTrans.GetFocusedRowCellValue("Borrar"), 0) = 1 Then
                vTrans.DeleteSelectedRows()
                vTrans.RefreshData()

                Totales()
            End If

            'If vTrans.GetRowCellValue(0, "Cuenta") = cbBanco.EditValue Then

            'End If
            'If IsNull(vTrans.GetFocusedRowCellValue("Tipo"), 0) = 0 Then
            '    vTrans.DeleteSelectedRows()
            '    vTrans.RefreshData()

            '    Totales()
            'End If
        End If
    End Sub

    Private Sub vTrans_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles vTrans.RowCellClick


        If IsNull(vTrans.GetFocusedRowCellValue("Borrar"), 0) = 0 And _
           IsNull(vTrans.GetFocusedRowCellValue("Cuenta"), "") <> "" Then
            vTrans.Columns("Cuenta").OptionsColumn.AllowEdit = False
            '    e.Cancel = True
        Else
            vTrans.Columns("Cuenta").OptionsColumn.AllowEdit = True
        End If
    End Sub


    Private Sub vTrans_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles vTrans.RowUpdated
        vTrans.RefreshData()
        Totales()
    End Sub

    Private Sub vTrans_ShowingEditor(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles vTrans.ShowingEditor
        If IsNull(vTrans.GetFocusedRowCellValue("Borrar"), 0) = 0 And _
            IsNull(vTrans.GetFocusedRowCellValue("Cuenta"), "") <> "" Then
            vTrans.Columns("Cuenta").OptionsColumn.AllowEdit = False
            '    e.Cancel = True
        Else
            vTrans.Columns("Cuenta").OptionsColumn.AllowEdit = True
        End If

        'If IsNull(vTrans.GetRowCellValue(vTrans.FocusedRowHandle, "Tipo"), 0) = 1 Then
        '    vTrans.Columns("Cuenta").OptionsColumn.AllowEdit = False
        '    'e.Cancel = True
        'Else
        '    vTrans.Columns("Cuenta").OptionsColumn.AllowEdit = True
        'End If

    End Sub

    Private Sub vTrans_DoubleClick(sender As Object, e As EventArgs) Handles vTrans.DoubleClick
        If vTrans.FocusedRowHandle < 0 Then Exit Sub
        '
        Try
            Dim frm As New FrmDetalleRequisas
            With vTrans

                frm.Cuenta = .GetRowCellValue(.FocusedRowHandle, "Cuenta")

                If IsDBNull(.GetRowCellValue(.FocusedRowHandle, "Debe")) OrElse IsNothing(.GetRowCellValue(.FocusedRowHandle, "Debe")) OrElse .GetRowCellValue(.FocusedRowHandle, "Debe") = Nothing OrElse .GetRowCellValue(.FocusedRowHandle, "Debe") = 0.00 Then
                    frm.Monto = IIf(IsNull(.GetRowCellValue(.FocusedRowHandle, "Haber"), 0.00) < 0, .GetRowCellValue(.FocusedRowHandle, "Haber") * -1, .GetRowCellValue(.FocusedRowHandle, "Haber"))
                    frm.Tipo = IIf(IsNull(.GetRowCellValue(.FocusedRowHandle, "Haber"), 0.00) < 0, "D", "C")
                    frm.Periodo = VB.SysContab.PeriodosDB.Activo(Fecha.DateTime.Date)
                    frm.CompNo = CompNo
                    frm.Cuenta = .GetRowCellValue(.FocusedRowHandle, "Cuenta")
                    frm.Mes = Fecha.DateTime.Month
                Else
                    frm.Monto = IIf(IsNull(.GetRowCellValue(.FocusedRowHandle, "Debe"), 0.00) < 0, .GetRowCellValue(.FocusedRowHandle, "Debe") * -1, .GetRowCellValue(.FocusedRowHandle, "Debe"))
                    frm.Tipo = IIf(IsNull(.GetRowCellValue(.FocusedRowHandle, "Debe"), 0.00) < 0, "C", "D")
                    frm.Periodo = VB.SysContab.PeriodosDB.Activo(Fecha.DateTime.Date)
                    frm.CompNo = CompNo
                    frm.Cuenta = .GetRowCellValue(.FocusedRowHandle, "Cuenta")
                    frm.Mes = Fecha.DateTime.Month
                End If
                '
                frm.Mostrar(DT_Distribucion)
                Me.DT_Distribucion.DefaultView.RowFilter = ""
            End With
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
