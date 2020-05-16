Public Class frmTiposPago
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
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtEfectivo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents etCaja As System.Windows.Forms.Label
    Friend WithEvents txtNotaDebito As System.Windows.Forms.TextBox
    Friend WithEvents etTotalPagado As System.Windows.Forms.Label
    Friend WithEvents etTotalTarjetas As System.Windows.Forms.Label
    Friend WithEvents etTotalCheques As System.Windows.Forms.Label
    Friend WithEvents cmdTarjetas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCheques As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents etDiferencia As System.Windows.Forms.Label
    Friend WithEvents lbVuelto As System.Windows.Forms.Label
    Friend WithEvents txtrecibo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents cbMoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbCatalogo As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtAlma As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIR As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkAlma As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkRetencion As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTiposPago))
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.chkAlma = New DevExpress.XtraEditors.CheckEdit()
        Me.chkRetencion = New DevExpress.XtraEditors.CheckEdit()
        Me.txtAlma = New DevExpress.XtraEditors.TextEdit()
        Me.txtIR = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.etCaja = New System.Windows.Forms.Label()
        Me.txtEfectivo = New DevExpress.XtraEditors.TextEdit()
        Me.txtrecibo = New DevExpress.XtraEditors.TextEdit()
        Me.cbCatalogo = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbMoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.lbVuelto = New System.Windows.Forms.Label()
        Me.cmdCheques = New DevExpress.XtraEditors.SimpleButton()
        Me.etTotalPagado = New System.Windows.Forms.Label()
        Me.txtNotaDebito = New System.Windows.Forms.TextBox()
        Me.etDiferencia = New System.Windows.Forms.Label()
        Me.cmdTarjetas = New DevExpress.XtraEditors.SimpleButton()
        Me.etTotalCheques = New System.Windows.Forms.Label()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.etTotalTarjetas = New System.Windows.Forms.Label()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.chkAlma.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRetencion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlma.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEfectivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtrecibo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Appearance.Options.UseForeColor = True
        Me.cmdAceptar.ImageOptions.Image = CType(resources.GetObject("cmdAceptar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAceptar.Location = New System.Drawing.Point(441, 380)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(131, 38)
        Me.cmdAceptar.StyleController = Me.LayoutControl1
        Me.cmdAceptar.TabIndex = 7
        Me.cmdAceptar.Text = "F3 - &Aceptar"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.chkAlma)
        Me.LayoutControl1.Controls.Add(Me.chkRetencion)
        Me.LayoutControl1.Controls.Add(Me.txtAlma)
        Me.LayoutControl1.Controls.Add(Me.txtIR)
        Me.LayoutControl1.Controls.Add(Me.LabelControl2)
        Me.LayoutControl1.Controls.Add(Me.LabelControl1)
        Me.LayoutControl1.Controls.Add(Me.cmdCancelar)
        Me.LayoutControl1.Controls.Add(Me.cmdAceptar)
        Me.LayoutControl1.Controls.Add(Me.etCaja)
        Me.LayoutControl1.Controls.Add(Me.txtEfectivo)
        Me.LayoutControl1.Controls.Add(Me.txtrecibo)
        Me.LayoutControl1.Controls.Add(Me.cbCatalogo)
        Me.LayoutControl1.Controls.Add(Me.cbMoneda)
        Me.LayoutControl1.Controls.Add(Me.txtMonto)
        Me.LayoutControl1.Controls.Add(Me.lbVuelto)
        Me.LayoutControl1.Controls.Add(Me.cmdCheques)
        Me.LayoutControl1.Controls.Add(Me.etTotalPagado)
        Me.LayoutControl1.Controls.Add(Me.txtNotaDebito)
        Me.LayoutControl1.Controls.Add(Me.etDiferencia)
        Me.LayoutControl1.Controls.Add(Me.cmdTarjetas)
        Me.LayoutControl1.Controls.Add(Me.etTotalCheques)
        Me.LayoutControl1.Controls.Add(Me.TextEdit1)
        Me.LayoutControl1.Controls.Add(Me.TextEdit4)
        Me.LayoutControl1.Controls.Add(Me.TextEdit2)
        Me.LayoutControl1.Controls.Add(Me.etTotalTarjetas)
        Me.LayoutControl1.Controls.Add(Me.TextEdit3)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem18})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1072, 397, 450, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(697, 430)
        Me.LayoutControl1.TabIndex = 181
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'chkAlma
        '
        Me.chkAlma.Location = New System.Drawing.Point(12, 210)
        Me.chkAlma.Name = "chkAlma"
        Me.chkAlma.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAlma.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.chkAlma.Properties.Appearance.Options.UseFont = True
        Me.chkAlma.Properties.Appearance.Options.UseForeColor = True
        Me.chkAlma.Properties.Caption = "Retención Municipal:"
        Me.chkAlma.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkAlma.Size = New System.Drawing.Size(172, 22)
        Me.chkAlma.StyleController = Me.LayoutControl1
        Me.chkAlma.TabIndex = 186
        '
        'chkRetencion
        '
        Me.chkRetencion.Location = New System.Drawing.Point(12, 184)
        Me.chkRetencion.Name = "chkRetencion"
        Me.chkRetencion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRetencion.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.chkRetencion.Properties.Appearance.Options.UseFont = True
        Me.chkRetencion.Properties.Appearance.Options.UseForeColor = True
        Me.chkRetencion.Properties.Caption = "Retención:"
        Me.chkRetencion.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkRetencion.Size = New System.Drawing.Size(172, 22)
        Me.chkRetencion.StyleController = Me.LayoutControl1
        Me.chkRetencion.TabIndex = 185
        '
        'txtAlma
        '
        Me.txtAlma.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.txtAlma.Location = New System.Drawing.Point(188, 210)
        Me.txtAlma.Name = "txtAlma"
        Me.txtAlma.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlma.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtAlma.Properties.Appearance.Options.UseFont = True
        Me.txtAlma.Properties.Appearance.Options.UseForeColor = True
        Me.txtAlma.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAlma.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAlma.Properties.Mask.EditMask = "n2"
        Me.txtAlma.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAlma.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAlma.Size = New System.Drawing.Size(497, 20)
        Me.txtAlma.StyleController = Me.LayoutControl1
        Me.txtAlma.TabIndex = 184
        '
        'txtIR
        '
        Me.txtIR.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.txtIR.Location = New System.Drawing.Point(188, 184)
        Me.txtIR.Name = "txtIR"
        Me.txtIR.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIR.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtIR.Properties.Appearance.Options.UseFont = True
        Me.txtIR.Properties.Appearance.Options.UseForeColor = True
        Me.txtIR.Properties.Appearance.Options.UseTextOptions = True
        Me.txtIR.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtIR.Properties.Mask.EditMask = "n2"
        Me.txtIR.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtIR.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtIR.Size = New System.Drawing.Size(497, 20)
        Me.txtIR.StyleController = Me.LayoutControl1
        Me.txtIR.TabIndex = 183
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(12, 88)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(72, 14)
        Me.LabelControl2.StyleController = Me.LayoutControl1
        Me.LabelControl2.TabIndex = 182
        Me.LabelControl2.Text = "Nota de Debito:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(172, 20)
        Me.LabelControl1.StyleController = Me.LayoutControl1
        Me.LabelControl1.TabIndex = 181
        Me.LabelControl1.Text = "Efectivo:"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Appearance.Options.UseForeColor = True
        Me.cmdCancelar.ImageOptions.Image = CType(resources.GetObject("cmdCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(576, 380)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(109, 38)
        Me.cmdCancelar.StyleController = Me.LayoutControl1
        Me.cmdCancelar.TabIndex = 8
        Me.cmdCancelar.Text = "F4- &Salir"
        '
        'etCaja
        '
        Me.etCaja.BackColor = System.Drawing.Color.Transparent
        Me.etCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etCaja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etCaja.Location = New System.Drawing.Point(571, 108)
        Me.etCaja.Name = "etCaja"
        Me.etCaja.Size = New System.Drawing.Size(124, 70)
        Me.etCaja.TabIndex = 178
        Me.etCaja.Text = "Caja"
        Me.etCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etCaja.Visible = False
        '
        'txtEfectivo
        '
        Me.txtEfectivo.EditValue = "0"
        Me.txtEfectivo.Location = New System.Drawing.Point(474, 238)
        Me.txtEfectivo.Name = "txtEfectivo"
        Me.txtEfectivo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEfectivo.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtEfectivo.Properties.Appearance.Options.UseFont = True
        Me.txtEfectivo.Properties.Appearance.Options.UseForeColor = True
        Me.txtEfectivo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtEfectivo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtEfectivo.Properties.Mask.EditMask = "n2"
        Me.txtEfectivo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtEfectivo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtEfectivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtEfectivo.ShowToolTips = False
        Me.txtEfectivo.Size = New System.Drawing.Size(211, 26)
        Me.txtEfectivo.StyleController = Me.LayoutControl1
        Me.txtEfectivo.TabIndex = 164
        '
        'txtrecibo
        '
        Me.txtrecibo.EditValue = "0"
        Me.txtrecibo.Location = New System.Drawing.Point(469, 36)
        Me.txtrecibo.Name = "txtrecibo"
        Me.txtrecibo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrecibo.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtrecibo.Properties.Appearance.Options.UseFont = True
        Me.txtrecibo.Properties.Appearance.Options.UseForeColor = True
        Me.txtrecibo.Properties.Mask.EditMask = "f0"
        Me.txtrecibo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtrecibo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtrecibo.Properties.NullText = "0"
        Me.txtrecibo.Size = New System.Drawing.Size(216, 20)
        Me.txtrecibo.StyleController = Me.LayoutControl1
        Me.txtrecibo.TabIndex = 180
        '
        'cbCatalogo
        '
        Me.cbCatalogo.EditValue = "[Cuenta Cliente]"
        Me.cbCatalogo.Location = New System.Drawing.Point(136, 112)
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCatalogo.Properties.Appearance.Options.UseFont = True
        Me.cbCatalogo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo.Properties.NullText = "[Cuenta Cliente]"
        Me.cbCatalogo.Properties.View = Me.SearchLookUpEdit1View
        Me.cbCatalogo.Size = New System.Drawing.Size(549, 22)
        Me.cbCatalogo.StyleController = Me.LayoutControl1
        Me.cbCatalogo.TabIndex = 170
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'cbMoneda
        '
        Me.cbMoneda.Location = New System.Drawing.Point(469, 12)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMoneda.Properties.Appearance.Options.UseFont = True
        Me.cbMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMoneda.Properties.NullText = "[Moneda]"
        Me.cbMoneda.Size = New System.Drawing.Size(216, 20)
        Me.cbMoneda.StyleController = Me.LayoutControl1
        Me.cbMoneda.TabIndex = 4
        '
        'txtMonto
        '
        Me.txtMonto.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.ForeColor = System.Drawing.Color.Navy
        Me.txtMonto.Location = New System.Drawing.Point(188, 12)
        Me.txtMonto.MaxLength = 13
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(153, 20)
        Me.txtMonto.TabIndex = 158
        Me.txtMonto.Text = "0.00"
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbVuelto
        '
        Me.lbVuelto.BackColor = System.Drawing.Color.Transparent
        Me.lbVuelto.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVuelto.ForeColor = System.Drawing.Color.Maroon
        Me.lbVuelto.Location = New System.Drawing.Point(474, 268)
        Me.lbVuelto.Name = "lbVuelto"
        Me.lbVuelto.Size = New System.Drawing.Size(211, 20)
        Me.lbVuelto.TabIndex = 175
        Me.lbVuelto.Text = "0.00"
        Me.lbVuelto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdCheques
        '
        Me.cmdCheques.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCheques.Appearance.Options.UseFont = True
        Me.cmdCheques.ImageOptions.Image = CType(resources.GetObject("cmdCheques.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdCheques.Location = New System.Drawing.Point(12, 36)
        Me.cmdCheques.Name = "cmdCheques"
        Me.cmdCheques.Size = New System.Drawing.Size(172, 22)
        Me.cmdCheques.StyleController = Me.LayoutControl1
        Me.cmdCheques.TabIndex = 160
        Me.cmdCheques.Text = "&Cheques"
        '
        'etTotalPagado
        '
        Me.etTotalPagado.BackColor = System.Drawing.Color.Transparent
        Me.etTotalPagado.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalPagado.ForeColor = System.Drawing.Color.Maroon
        Me.etTotalPagado.Location = New System.Drawing.Point(136, 238)
        Me.etTotalPagado.Name = "etTotalPagado"
        Me.etTotalPagado.Size = New System.Drawing.Size(210, 26)
        Me.etTotalPagado.TabIndex = 171
        Me.etTotalPagado.Text = "0.00"
        Me.etTotalPagado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNotaDebito
        '
        Me.txtNotaDebito.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotaDebito.ForeColor = System.Drawing.Color.Navy
        Me.txtNotaDebito.Location = New System.Drawing.Point(88, 88)
        Me.txtNotaDebito.MaxLength = 13
        Me.txtNotaDebito.Name = "txtNotaDebito"
        Me.txtNotaDebito.Size = New System.Drawing.Size(253, 20)
        Me.txtNotaDebito.TabIndex = 162
        Me.txtNotaDebito.Text = "0.00"
        Me.txtNotaDebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etDiferencia
        '
        Me.etDiferencia.BackColor = System.Drawing.Color.Transparent
        Me.etDiferencia.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDiferencia.ForeColor = System.Drawing.Color.Maroon
        Me.etDiferencia.Location = New System.Drawing.Point(136, 268)
        Me.etDiferencia.Name = "etDiferencia"
        Me.etDiferencia.Size = New System.Drawing.Size(210, 20)
        Me.etDiferencia.TabIndex = 174
        Me.etDiferencia.Text = "0.00"
        Me.etDiferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdTarjetas
        '
        Me.cmdTarjetas.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTarjetas.Appearance.Options.UseFont = True
        Me.cmdTarjetas.ImageOptions.Image = CType(resources.GetObject("cmdTarjetas.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdTarjetas.Location = New System.Drawing.Point(12, 62)
        Me.cmdTarjetas.Name = "cmdTarjetas"
        Me.cmdTarjetas.Size = New System.Drawing.Size(172, 22)
        Me.cmdTarjetas.StyleController = Me.LayoutControl1
        Me.cmdTarjetas.TabIndex = 161
        Me.cmdTarjetas.Text = "&Tarjeta de Crédito"
        '
        'etTotalCheques
        '
        Me.etTotalCheques.BackColor = System.Drawing.Color.Transparent
        Me.etTotalCheques.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalCheques.ForeColor = System.Drawing.Color.Navy
        Me.etTotalCheques.Location = New System.Drawing.Point(188, 36)
        Me.etTotalCheques.Name = "etTotalCheques"
        Me.etTotalCheques.Size = New System.Drawing.Size(153, 22)
        Me.etTotalCheques.TabIndex = 168
        Me.etTotalCheques.Text = "0.00"
        Me.etTotalCheques.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextEdit1
        '
        Me.TextEdit1.EditValue = "00000"
        Me.TextEdit1.Location = New System.Drawing.Point(469, 60)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit1.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TextEdit1.Properties.NullText = "0"
        Me.TextEdit1.Size = New System.Drawing.Size(118, 20)
        Me.TextEdit1.StyleController = Me.LayoutControl1
        Me.TextEdit1.TabIndex = 180
        Me.TextEdit1.Visible = False
        '
        'TextEdit4
        '
        Me.TextEdit4.EditValue = "00000"
        Me.TextEdit4.Location = New System.Drawing.Point(591, 84)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit4.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TextEdit4.Properties.Appearance.Options.UseFont = True
        Me.TextEdit4.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit4.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit4.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit4.Properties.Mask.EditMask = "n2"
        Me.TextEdit4.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit4.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TextEdit4.Properties.NullText = "0"
        Me.TextEdit4.Size = New System.Drawing.Size(94, 20)
        Me.TextEdit4.StyleController = Me.LayoutControl1
        Me.TextEdit4.TabIndex = 180
        Me.TextEdit4.Visible = False
        '
        'TextEdit2
        '
        Me.TextEdit2.EditValue = "00000"
        Me.TextEdit2.Location = New System.Drawing.Point(469, 84)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TextEdit2.Properties.Appearance.Options.UseFont = True
        Me.TextEdit2.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit2.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TextEdit2.Properties.NullText = "0"
        Me.TextEdit2.Size = New System.Drawing.Size(118, 20)
        Me.TextEdit2.StyleController = Me.LayoutControl1
        Me.TextEdit2.TabIndex = 180
        Me.TextEdit2.Visible = False
        '
        'etTotalTarjetas
        '
        Me.etTotalTarjetas.BackColor = System.Drawing.Color.Transparent
        Me.etTotalTarjetas.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalTarjetas.ForeColor = System.Drawing.Color.Navy
        Me.etTotalTarjetas.Location = New System.Drawing.Point(188, 62)
        Me.etTotalTarjetas.Name = "etTotalTarjetas"
        Me.etTotalTarjetas.Size = New System.Drawing.Size(153, 22)
        Me.etTotalTarjetas.TabIndex = 169
        Me.etTotalTarjetas.Text = "0.00"
        Me.etTotalTarjetas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextEdit3
        '
        Me.TextEdit3.EditValue = "00000"
        Me.TextEdit3.Location = New System.Drawing.Point(591, 60)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TextEdit3.Properties.Appearance.Options.UseFont = True
        Me.TextEdit3.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit3.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit3.Properties.Mask.EditMask = "n2"
        Me.TextEdit3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit3.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TextEdit3.Properties.NullText = "0"
        Me.TextEdit3.Size = New System.Drawing.Size(94, 20)
        Me.TextEdit3.StyleController = Me.LayoutControl1
        Me.TextEdit3.TabIndex = 180
        Me.TextEdit3.Visible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.etCaja
        Me.LayoutControlItem18.Location = New System.Drawing.Point(559, 96)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(128, 74)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem10, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem1, Me.LayoutControlItem11, Me.LayoutControlItem19, Me.LayoutControlItem20, Me.LayoutControlItem21, Me.LayoutControlItem22, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem2, Me.LayoutControlItem7, Me.LayoutControlItem15, Me.LayoutControlItem23, Me.LayoutControlItem24, Me.SimpleSeparator1, Me.LayoutControlItem25, Me.LayoutControlItem26, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.EmptySpaceItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(697, 430)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmdCheques
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(176, 26)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(176, 26)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(176, 26)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmdTarjetas
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(176, 26)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(176, 26)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(176, 26)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem10.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem10.Control = Me.etDiferencia
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 256)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(338, 24)
        Me.LayoutControlItem10.Text = "Diferencia:"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(121, 14)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem12.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem12.Control = Me.TextEdit1
        Me.LayoutControlItem12.Location = New System.Drawing.Point(333, 48)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(246, 24)
        Me.LayoutControlItem12.Text = "Dev. Factura:"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(121, 14)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.TextEdit3
        Me.LayoutControlItem13.Location = New System.Drawing.Point(579, 48)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(98, 24)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem14.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem14.Control = Me.TextEdit2
        Me.LayoutControlItem14.Location = New System.Drawing.Point(333, 72)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(246, 28)
        Me.LayoutControlItem14.Text = "Nota Credito:"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(121, 14)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem1.Control = Me.cbMoneda
        Me.LayoutControlItem1.Location = New System.Drawing.Point(333, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(344, 24)
        Me.LayoutControlItem1.Text = "Moneda:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(121, 14)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem11.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem11.Control = Me.txtrecibo
        Me.LayoutControlItem11.Location = New System.Drawing.Point(333, 24)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(344, 24)
        Me.LayoutControlItem11.Text = "No Recibo:"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(121, 14)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.cmdAceptar
        Me.LayoutControlItem19.Location = New System.Drawing.Point(429, 368)
        Me.LayoutControlItem19.MaxSize = New System.Drawing.Size(135, 42)
        Me.LayoutControlItem19.MinSize = New System.Drawing.Size(135, 42)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(135, 42)
        Me.LayoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.cmdCancelar
        Me.LayoutControlItem20.Location = New System.Drawing.Point(564, 368)
        Me.LayoutControlItem20.MaxSize = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem20.MinSize = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem20.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextVisible = False
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.LabelControl1
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem21.MaxSize = New System.Drawing.Size(176, 24)
        Me.LayoutControlItem21.MinSize = New System.Drawing.Size(176, 24)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(176, 24)
        Me.LayoutControlItem21.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem21.TextVisible = False
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.LabelControl2
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 76)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(76, 24)
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem22.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem8.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem8.Control = Me.cbCatalogo
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 100)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(677, 26)
        Me.LayoutControlItem8.Text = "Cuenta:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(121, 14)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem9.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem9.Control = Me.etTotalPagado
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 226)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(338, 30)
        Me.LayoutControlItem9.Text = "Total:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(121, 14)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 126)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(677, 46)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 368)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(429, 42)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.etTotalCheques
        Me.LayoutControlItem5.Location = New System.Drawing.Point(176, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(157, 26)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.etTotalTarjetas
        Me.LayoutControlItem6.Location = New System.Drawing.Point(176, 50)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(157, 26)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtMonto
        Me.LayoutControlItem2.Location = New System.Drawing.Point(176, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(157, 24)
        Me.LayoutControlItem2.Text = "Efectivo:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtNotaDebito
        Me.LayoutControlItem7.Location = New System.Drawing.Point(76, 76)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(257, 24)
        Me.LayoutControlItem7.Text = "Nota de Débito:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.TextEdit4
        Me.LayoutControlItem15.Location = New System.Drawing.Point(579, 72)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(98, 28)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem23.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem23.Control = Me.txtIR
        Me.LayoutControlItem23.Location = New System.Drawing.Point(176, 172)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(501, 26)
        Me.LayoutControlItem23.Text = "Retención:"
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem23.TextVisible = False
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem24.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem24.Control = Me.txtAlma
        Me.LayoutControlItem24.Location = New System.Drawing.Point(176, 198)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(501, 26)
        Me.LayoutControlItem24.Text = "Retención Municipal:"
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem24.TextVisible = False
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.AllowHotTrack = False
        Me.SimpleSeparator1.Location = New System.Drawing.Point(0, 224)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(677, 2)
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.chkRetencion
        Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 172)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(176, 26)
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem25.TextVisible = False
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.chkAlma
        Me.LayoutControlItem26.Location = New System.Drawing.Point(0, 198)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(176, 26)
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem26.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem16.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem16.Control = Me.txtEfectivo
        Me.LayoutControlItem16.Location = New System.Drawing.Point(338, 226)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(339, 30)
        Me.LayoutControlItem16.Text = "Efectivo entregado:"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(121, 14)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem17.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem17.Control = Me.lbVuelto
        Me.LayoutControlItem17.Location = New System.Drawing.Point(338, 256)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(339, 24)
        Me.LayoutControlItem17.Text = "Efectivo Vuelto:"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(121, 14)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 280)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(677, 88)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmTiposPago
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(697, 430)
        Me.Controls.Add(Me.LayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmTiposPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.chkAlma.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRetencion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlma.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEfectivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtrecibo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim r As New VB.SysContab.Rutinas()
    ' Dim Clientes As New VB.SysContab.ClientesDB()
    'Dim Catalogo As New VB.SysContab.CatalogoDB()
    'Dim Tasa As New VB.SysContab.Tasa_CambioDB()

    Dim TipoCambio As Double
    Dim TotalCordobas As Double
    Dim Devolucion As Double
    Dim Credito As Double

    Private FormaPago As New VB.SysContab.Forma_PagoDB()
    Private ConfigDetalles As New VB.SysContab.ConfiguracionDetails
    Public DetallesCliente As New VB.SysContab.ClientesDetails
    '
    Public SubTotalIR As Double = 0.00
    'Public IdCliente As Integer = 0, Cuenta As String = "", IR As Boolean = False, IrAlma As Boolean = False, SubTotalIR As Double = 0.00

    Private Sub frmTiposPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''r.CambiarEstilo(Me)
        'Dim i As Integer
        'r.ComboAutoComplete(cbCatalogo)

        SearchLookUp(cbCatalogo, ObtieneDatos("_GetCatalogo_CuentaActivo", EmpresaActual), "Display", "Cuenta", 2)
        cbCatalogo.EditValue = DetallesCliente.Cuenta


        'cbCatalogo.DataSource = Catalogo.CatalogoList("A", 0).Tables("CATALOGO")
        'cbCatalogo.ValueMember = "Cuenta"
        'cbCatalogo.DisplayMember = "Nombre"
        'Try
        '    cbCatalogo.SelectedValue = Cuenta
        'Catch ex As Exception
        'End Try

        GetMonedasList(cbMoneda)

        'cbMoneda.DataSource = Tasa.GetListTasaCambioDisponibles.Tables("Tasa_Cambio")
        'cbMoneda.ValueMember = "MonedaCambio"
        'cbMoneda.DisplayMember = "Nombre"

        'Me.cbMoneda.SelectedValue = MonedaBase

        GuardarFactura = False

        etTotalPagado.Text = TotalGlobal.ToString(Round)

        txtMonto.Text = TotalEfectivo.ToString(Round)

        txtNotaDebito.Text = TotalNotaDebito.ToString(Round)
        etTotalCheques.Text = TotalCheques.ToString(Round)
        etTotalTarjetas.Text = TotalTarjetas.ToString(Round)

        etDiferencia.Text = (TotalFactura - CDbl(CDbl(etTotalPagado.Text).ToString(Round))).ToString(Round)

        'Dim Config As New VB.SysContab.ConfiguracionDB

        Dim dd As String
        ConfigDetalles = VB.SysContab.ConfiguracionDB.GetConfigDetails

        For d As Integer = 0 To ConfigDetalles.ReciboDigitos - 1
            dd = dd & "0"
        Next
        '
        txtrecibo.Properties.Mask.EditMask = dd
        chkRetencion.Text = "Retención " + ConfigDetalles.IRProd.ToString("n2") + "%:"

        chkRetencion.Checked = DetallesCliente.Retenedor
        chkAlma.Checked = DetallesCliente.RetenedorAlcaldia
        '
        Text = "Pago de Contado"
        Refresh()
    End Sub

    Private Sub cmdCheques_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCheques.Click
        Dim f As New DataGridTextBoxCombo.frmPagosRecibo

        f.etCaja.Text = etCaja.Text
        f.ShowDialog()

        TotalGlobal = TotalCheques + TotalTarjetas + TotalEfectivo

        etTotalCheques.Text = TotalCheques.ToString(Round)
        etTotalPagado.Text = TotalGlobal.ToString(Round)

        etDiferencia.Text = (TotalFactura - TotalGlobal).ToString(Round)

    End Sub

    Private Sub cmdTarjetas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTarjetas.Click
        Dim f As New DataGridTextBoxCombo.frmPagosReciboTarjeta
        f.etCaja.Text = etCaja.Text
        f.ShowDialog()

        TotalGlobal = TotalCheques + TotalTarjetas + TotalEfectivo

        etTotalTarjetas.Text = TotalTarjetas.ToString(Round)
        etTotalPagado.Text = TotalGlobal.ToString(Round)

        etDiferencia.Text = (TotalFactura - TotalGlobal).ToString(Round)
    End Sub

    Private Sub txtMonto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonto.Leave
        Efectivo()
    End Sub

    Public Sub Efectivo()
        If Trim(txtMonto.Text) = "" Then
            txtMonto.Text = "0.00"
        End If

        If NuevaFactura = "NO" Then
            Exit Sub
        End If

        If Not IsNumeric(txtMonto.Text) Then
            MsgBox("Valor no valido")
            txtMonto.Focus()
            Exit Sub
        Else

            txtMonto.Text = CDbl(txtMonto.Text).ToString(Round)

            TotalEfectivo = txtMonto.Text

            TotalGlobal = TotalTarjetas + TotalCheques + TotalEfectivo + TotalNotaDebito

            If CDbl(TotalGlobal.ToString(Round)) > CDbl(TotalFactura.ToString(Round)) Then
                XtraMsg("El monto es mayor que el saldo de la factura", MessageBoxIcon.Warning)
                txtMonto.Focus()
                Exit Sub
            End If

            etTotalPagado.Text = TotalGlobal.ToString(Round)
            etDiferencia.Text = (TotalFactura - TotalGlobal).ToString(Round)
        End If
    End Sub

    Private Sub txtMonto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        Dim i As Integer
        If Microsoft.VisualBasic.Asc(e.KeyChar) = 8 Then
            Exit Sub
        End If

        If e.KeyChar = "." Then
            For i = 0 To txtMonto.Text.Length - 1
                If e.KeyChar = txtMonto.Text.Substring(i, 1) Then
                    e.Handled = True
                End If
            Next
            Exit Sub
        End If

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub frmTiposPago_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If NuevaFactura = "NO" Then
            Exit Sub
        End If

        If Trim(txtMonto.Text) = "" Then
            TotalEfectivo = 0
            Exit Sub
        End If

        If Trim(txtNotaDebito.Text) = "" Then
            TotalNotaDebito = 0
            Exit Sub
        End If

        If CDbl(CDbl(txtMonto.Text).ToString(Round)) > CDbl(CDbl(TotalFactura).ToString(Round)) Then
            MsgBox("El monto es mayor que el saldo de la factura", MsgBoxStyle.Information)
            'rbCordobas.Checked = True
            txtMonto.Focus()
            e.Cancel = True
            Exit Sub
        End If

        If txtMonto.Text <> "" Then
            TotalEfectivo = txtMonto.Text
            TotalGlobal = TotalTarjetas + TotalCheques + TotalEfectivo

        End If

        If CDbl(CDbl(txtNotaDebito.Text).ToString(Round)) > CDbl(CDbl(TotalFactura).ToString(Round)) Then
            MsgBox("El monto es mayor que el saldo de la factura", MsgBoxStyle.Information)
            txtNotaDebito.Focus()
            e.Cancel = True
            Exit Sub
        End If

        If CDbl(CDbl(TotalGlobal).ToString(Round)) > CDbl(CDbl(TotalFactura).ToString(Round)) Then
            'If TotalGlobal.ToString(Round) > TotalFactura.ToString(Round) Then
            MsgBox("El monto es mayor que el saldo de la factura", MsgBoxStyle.Information)
            'rbCordobas.Checked = True
            txtMonto.Focus()
            e.Cancel = True
            Exit Sub
        End If

        TotalGlobal = TotalTarjetas + TotalCheques + TotalEfectivo + TotalNotaDebito
        If GuardarFactura = True Then
            If FormaPago.FormaPagoDias(TipoFactura) = 0 Then 'Contado If TipoFactura = 0 Then 'Contado
                If CDbl(TotalGlobal).ToString(Round) < CDbl(TotalFactura).ToString(Round) Then
                    MsgBox("La Factura es de Contado, el Monto a pagar debe ser igual al Total de la Factura.", MsgBoxStyle.Information)
                    txtMonto.Focus()
                    e.Cancel = True
                    Exit Sub
                End If
            Else 'Crédito
            End If
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Cerrar()
    End Sub

    Sub Cerrar()
        GuardarFactura = False
        Close()
    End Sub

    Private Sub txtMonto_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonto.Enter
        If txtMonto.Text = "0.00" Then
            txtMonto.Text = ""
        End If
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Aceptar()
    End Sub

    Sub Aceptar()
        'If TipoFactura = 0 Then 'Contado
        If FormaPago.FormaPagoDias(TipoFactura) = 0 Then 'Contado
            If CDbl(TotalGlobal).ToString(Round) < CDbl(TotalFactura).ToString(Round) Then
                MsgBox("La Factura es de Contado, el Monto a pagar debe ser igual al Total de la Factura.", MsgBoxStyle.Information)
                txtMonto.Focus()
                Exit Sub
            End If
        Else 'Crédito
        End If

        GuardarFactura = True
        Close()
    End Sub

    Private Sub txtNotaDebito_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNotaDebito.Enter
        If txtNotaDebito.Text = "0.00" Then
            txtNotaDebito.Text = ""
        End If

    End Sub

    Private Sub txtNotaDebito_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNotaDebito.KeyPress
        Dim i As Integer
        If Microsoft.VisualBasic.Asc(e.KeyChar) = 8 Then
            Exit Sub
        End If

        If e.KeyChar = "." Then
            For i = 0 To txtNotaDebito.Text.Length - 1
                If e.KeyChar = txtNotaDebito.Text.Substring(i, 1) Then
                    e.Handled = True
                End If
            Next
            Exit Sub
        End If

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub txtNotaDebito_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNotaDebito.Leave

        If Trim(txtNotaDebito.Text) = "" Then
            txtNotaDebito.Text = "0.00"
        End If

        If NuevaFactura = "NO" Then
            Exit Sub
        End If

        'Exit Sub

        If Not IsNumeric(txtNotaDebito.Text) Then
            MsgBox("Valor no valido")
            txtNotaDebito.Focus()
            Exit Sub
        Else

            txtNotaDebito.Text = CDbl(txtNotaDebito.Text).ToString(Round)

            TotalNotaDebito = txtNotaDebito.Text

            TotalGlobal = TotalTarjetas + TotalCheques + TotalEfectivo + TotalNotaDebito

            If CDbl(TotalGlobal.ToString(Round)) > CDbl(TotalFactura.ToString(Round)) Then
                MsgBox("El monto es mayor que el saldo de la factura", MsgBoxStyle.Information)
                'rbCordobas.Checked = True
                txtNotaDebito.Focus()
                Exit Sub
            End If

            etTotalPagado.Text = TotalGlobal.ToString(Round)
            etDiferencia.Text = (TotalFactura - TotalGlobal).ToString(Round)

            'etSaldo.Text = (CDbl(etTotal.Text) - TotalGlobal).ToString(Round)
        End If
    End Sub

    'Private Sub cbCatalogo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCatalogo.SelectedValueChanged
    '    CuentaNotaDebito = IsNull(cbCatalogo.SelectedValue.ToString, "")
    'End Sub

    Private Sub txtEfectivo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEfectivo.TextChanged
        '        If (txtMonto.Text <> "" Or txtMonto.Text <> "0.00") And (txtEfectivo.Text <> "" Or txtEfectivo.Text <> "0.00") Then
        lbVuelto.Text = Format(CDbl(IsNull(txtEfectivo.Text, 0)) - CDbl(IsNull(txtMonto.Text, 0)), "n2")
        '       End If
    End Sub

    Private Sub chkAlma_CheckedChanged(sender As Object, e As EventArgs) Handles chkAlma.CheckedChanged
        If chkAlma.Checked Then
            If VB.SysContab.MunicipiosDB.GetDetails(DetallesCliente.Departamento, DetallesCliente.Municipio) Is Nothing Then
                XtraMsg("Al cliente aún no se le ha asignado un municipio, para efectos del Impuesto Municipal Sobre Ventas", MessageBoxIcon.Error)
                txtAlma.EditValue = 0.00
                chkAlma.Checked = False
                Exit Sub
            End If
            '
            txtIR.EditValue = Math.Round(CDbl(SubTotalIR * (VB.SysContab.MunicipiosDB.GetDetails(DetallesCliente.Departamento, DetallesCliente.Municipio).Impuesto_SVenta / 100)), 2)
        Else
            txtAlma.EditValue = 0.00
        End If
    End Sub

    Private Sub chkRetencion_CheckedChanged(sender As Object, e As EventArgs) Handles chkRetencion.CheckedChanged
        If chkRetencion.Checked Then
            txtIR.EditValue = Math.Round(CDbl(SubTotalIR * (ConfigDetalles.IRProd / 100.0)), 2)
        Else
            txtIR.EditValue = 0.00
        End If
    End Sub

    Private Sub txtrecibo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtrecibo.Validating
        If txtrecibo.Text <> Nothing And txtrecibo.Text <> 0 Then
            Dim valor As Integer
            valor = VB.SysContab.ClientesDB.ValidarRecibo(Me.txtrecibo.Text, "")
            If valor = 1 Then
                XtraMsg("Ese numero de Recibo ya existe", MessageBoxIcon.Error)
                txtrecibo.Text = String.Empty
                txtrecibo.Focus()
            ElseIf valor = 2 Then
                XtraMsg("Ese numero de Recibo fue anulado", MessageBoxIcon.Error)
                txtrecibo.Text = String.Empty
                txtrecibo.Focus()
            End If
            Exit Sub
        End If
    End Sub

    Private Sub cbCatalogo_EditValueChanged(sender As Object, e As EventArgs) Handles cbCatalogo.EditValueChanged
        CuentaNotaDebito = IIf(cbCatalogo.EditValue Is Nothing, "", cbCatalogo.EditValue)
    End Sub

    Private Sub frmTiposPago_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F3 Then Aceptar()
        If e.KeyCode = Keys.F4 Then Cerrar()
    End Sub
End Class
