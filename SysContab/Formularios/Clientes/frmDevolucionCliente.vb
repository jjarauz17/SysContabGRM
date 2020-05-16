Imports ClasesBLL
Imports System.Linq
Imports System.Data.SqlClient
Imports SysContab.VB.SysContab


'Namespace DataGridTextBoxCombo
Public Class frmDevolucionCliente
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmDevolucionCliente = Nothing

    Public Shared Function Instance() As frmDevolucionCliente
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmDevolucionCliente()
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
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents cmdConsultaClientes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdVerPagos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFactura As System.Windows.Forms.TextBox
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbTodos As System.Windows.Forms.CheckBox
    Friend WithEvents txtDevolucion As System.Windows.Forms.TextBox
    Friend WithEvents etTotal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents etSubTotal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents etIva As DevExpress.XtraEditors.LabelControl
    Friend WithEvents etSaldo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents etSaldoT As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dgDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents FechaD As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cbMovimientos As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtReferencia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbCentroDeCosto As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cbTipoNota As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Razon As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtTotalU As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtTCambio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevolucionCliente))
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.cbTodos = New System.Windows.Forms.CheckBox()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtTotalU = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit()
        Me.Razon = New DevExpress.XtraEditors.MemoEdit()
        Me.cbTipoNota = New DevExpress.XtraEditors.LookUpEdit()
        Me.etSaldoT = New DevExpress.XtraEditors.LabelControl()
        Me.etSaldo = New DevExpress.XtraEditors.LabelControl()
        Me.dgDatos = New DevExpress.XtraGrid.GridControl()
        Me.vDatos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.cbCentroDeCosto = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.etIva = New DevExpress.XtraEditors.LabelControl()
        Me.txtReferencia = New DevExpress.XtraEditors.TextEdit()
        Me.etTotal = New DevExpress.XtraEditors.LabelControl()
        Me.cbMovimientos = New DevExpress.XtraEditors.LookUpEdit()
        Me.etSubTotal = New DevExpress.XtraEditors.LabelControl()
        Me.dtpFecha = New DevExpress.XtraEditors.DateEdit()
        Me.cmdVerPagos = New DevExpress.XtraEditors.SimpleButton()
        Me.FechaD = New DevExpress.XtraEditors.DateEdit()
        Me.cmdConsultaClientes = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.txtDevolucion = New System.Windows.Forms.TextBox()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.txtTCambio = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtTotalU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Razon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipoNota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCentroDeCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReferencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMovimientos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaD.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTCambio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCliente
        '
        Me.txtCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCliente.BackColor = System.Drawing.SystemColors.Info
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(138, 12)
        Me.txtCliente.MaxLength = 50
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(652, 20)
        Me.txtCliente.TabIndex = 0
        '
        'cbTodos
        '
        Me.cbTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTodos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbTodos.Location = New System.Drawing.Point(810, 62)
        Me.cbTodos.Name = "cbTodos"
        Me.cbTodos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbTodos.Size = New System.Drawing.Size(68, 22)
        Me.cbTodos.TabIndex = 7
        Me.cbTodos.Text = "Todos"
        Me.cbTodos.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cbTodos.Visible = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Appearance.Options.UseForeColor = True
        Me.cmdAceptar.ImageOptions.Image = CType(resources.GetObject("cmdAceptar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAceptar.Location = New System.Drawing.Point(784, 403)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(105, 38)
        Me.cmdAceptar.StyleController = Me.LayoutControl1
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Text = "&Guardar"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtTCambio)
        Me.LayoutControl1.Controls.Add(Me.txtTotalU)
        Me.LayoutControl1.Controls.Add(Me.txtTotal)
        Me.LayoutControl1.Controls.Add(Me.Razon)
        Me.LayoutControl1.Controls.Add(Me.cbTipoNota)
        Me.LayoutControl1.Controls.Add(Me.etSaldoT)
        Me.LayoutControl1.Controls.Add(Me.cbTodos)
        Me.LayoutControl1.Controls.Add(Me.etSaldo)
        Me.LayoutControl1.Controls.Add(Me.dgDatos)
        Me.LayoutControl1.Controls.Add(Me.etIva)
        Me.LayoutControl1.Controls.Add(Me.txtReferencia)
        Me.LayoutControl1.Controls.Add(Me.etTotal)
        Me.LayoutControl1.Controls.Add(Me.cbMovimientos)
        Me.LayoutControl1.Controls.Add(Me.etSubTotal)
        Me.LayoutControl1.Controls.Add(Me.dtpFecha)
        Me.LayoutControl1.Controls.Add(Me.cmdVerPagos)
        Me.LayoutControl1.Controls.Add(Me.FechaD)
        Me.LayoutControl1.Controls.Add(Me.cmdConsultaClientes)
        Me.LayoutControl1.Controls.Add(Me.cmdAceptar)
        Me.LayoutControl1.Controls.Add(Me.cmdAyuda)
        Me.LayoutControl1.Controls.Add(Me.cmdCancelar)
        Me.LayoutControl1.Controls.Add(Me.cmdImprimir)
        Me.LayoutControl1.Controls.Add(Me.txtCliente)
        Me.LayoutControl1.Controls.Add(Me.txtFactura)
        Me.LayoutControl1.Controls.Add(Me.txtDevolucion)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem12, Me.LayoutControlItem15, Me.LayoutControlItem14, Me.LayoutControlItem13, Me.LayoutControlItem17, Me.LayoutControlItem19, Me.LayoutControlItem18, Me.LayoutControlItem20, Me.LayoutControlItem16, Me.LayoutControlItem9})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(912, 234, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1008, 453)
        Me.LayoutControl1.TabIndex = 3
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtTotalU
        '
        Me.txtTotalU.Location = New System.Drawing.Point(138, 419)
        Me.txtTotalU.Name = "txtTotalU"
        Me.txtTotalU.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalU.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalU.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtTotalU.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotalU.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTotalU.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTotalU.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtTotalU.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalU.Properties.Mask.EditMask = "n2"
        Me.txtTotalU.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalU.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalU.Properties.ReadOnly = True
        Me.txtTotalU.Size = New System.Drawing.Size(217, 22)
        Me.txtTotalU.StyleController = Me.LayoutControl1
        Me.txtTotalU.TabIndex = 131
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(138, 393)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotal.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtTotal.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotal.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTotal.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTotal.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtTotal.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotal.Properties.Mask.EditMask = "n2"
        Me.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotal.Properties.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(217, 22)
        Me.txtTotal.StyleController = Me.LayoutControl1
        Me.txtTotal.TabIndex = 130
        '
        'Razon
        '
        Me.Razon.Location = New System.Drawing.Point(138, 86)
        Me.Razon.Name = "Razon"
        Me.Razon.Size = New System.Drawing.Size(634, 48)
        Me.Razon.StyleController = Me.LayoutControl1
        Me.Razon.TabIndex = 6
        Me.Razon.Tag = "True"
        '
        'cbTipoNota
        '
        Me.cbTipoNota.Location = New System.Drawing.Point(632, 62)
        Me.cbTipoNota.Name = "cbTipoNota"
        Me.cbTipoNota.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipoNota.Properties.NullText = ""
        Me.cbTipoNota.Properties.ShowFooter = False
        Me.cbTipoNota.Properties.ShowHeader = False
        Me.cbTipoNota.Size = New System.Drawing.Size(364, 20)
        Me.cbTipoNota.StyleController = Me.LayoutControl1
        Me.cbTipoNota.TabIndex = 19
        '
        'etSaldoT
        '
        Me.etSaldoT.Location = New System.Drawing.Point(746, 313)
        Me.etSaldoT.Name = "etSaldoT"
        Me.etSaldoT.Size = New System.Drawing.Size(32, 13)
        Me.etSaldoT.StyleController = Me.LayoutControl1
        Me.etSaldoT.TabIndex = 129
        Me.etSaldoT.Text = "SaldoT"
        Me.etSaldoT.Visible = False
        '
        'etSaldo
        '
        Me.etSaldo.Location = New System.Drawing.Point(721, 330)
        Me.etSaldo.Name = "etSaldo"
        Me.etSaldo.Size = New System.Drawing.Size(26, 13)
        Me.etSaldo.StyleController = Me.LayoutControl1
        Me.etSaldo.TabIndex = 129
        Me.etSaldo.Text = "Saldo"
        Me.etSaldo.Visible = False
        '
        'dgDatos
        '
        Me.dgDatos.Location = New System.Drawing.Point(12, 138)
        Me.dgDatos.MainView = Me.vDatos
        Me.dgDatos.Name = "dgDatos"
        Me.dgDatos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtCantidad, Me.cbCentroDeCosto})
        Me.dgDatos.Size = New System.Drawing.Size(984, 251)
        Me.dgDatos.TabIndex = 0
        Me.dgDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vDatos})
        '
        'vDatos
        '
        Me.vDatos.GridControl = Me.dgDatos
        Me.vDatos.Name = "vDatos"
        Me.vDatos.OptionsView.ShowFooter = True
        Me.vDatos.OptionsView.ShowGroupPanel = False
        '
        'txtCantidad
        '
        Me.txtCantidad.AutoHeight = False
        Me.txtCantidad.Mask.EditMask = "n2"
        Me.txtCantidad.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCantidad.Mask.UseMaskAsDisplayFormat = True
        Me.txtCantidad.Name = "txtCantidad"
        '
        'cbCentroDeCosto
        '
        Me.cbCentroDeCosto.AutoHeight = False
        Me.cbCentroDeCosto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCentroDeCosto.Name = "cbCentroDeCosto"
        '
        'etIva
        '
        Me.etIva.Location = New System.Drawing.Point(700, 330)
        Me.etIva.Name = "etIva"
        Me.etIva.Size = New System.Drawing.Size(17, 13)
        Me.etIva.StyleController = Me.LayoutControl1
        Me.etIva.TabIndex = 129
        Me.etIva.Text = "IVA"
        Me.etIva.Visible = False
        '
        'txtReferencia
        '
        Me.txtReferencia.Location = New System.Drawing.Point(555, 36)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtReferencia.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferencia.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtReferencia.Properties.Appearance.Options.UseBackColor = True
        Me.txtReferencia.Properties.Appearance.Options.UseFont = True
        Me.txtReferencia.Properties.Appearance.Options.UseForeColor = True
        Me.txtReferencia.Size = New System.Drawing.Size(235, 22)
        Me.txtReferencia.StyleController = Me.LayoutControl1
        Me.txtReferencia.TabIndex = 2
        '
        'etTotal
        '
        Me.etTotal.Location = New System.Drawing.Point(751, 330)
        Me.etTotal.Name = "etTotal"
        Me.etTotal.Size = New System.Drawing.Size(24, 13)
        Me.etTotal.StyleController = Me.LayoutControl1
        Me.etTotal.TabIndex = 129
        Me.etTotal.Text = "Total"
        Me.etTotal.Visible = False
        '
        'cbMovimientos
        '
        Me.cbMovimientos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbMovimientos.Location = New System.Drawing.Point(138, 62)
        Me.cbMovimientos.Name = "cbMovimientos"
        Me.cbMovimientos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMovimientos.Properties.Appearance.Options.UseFont = True
        Me.cbMovimientos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMovimientos.Properties.NullText = ""
        Me.cbMovimientos.Properties.ShowFooter = False
        Me.cbMovimientos.Size = New System.Drawing.Size(364, 20)
        Me.cbMovimientos.StyleController = Me.LayoutControl1
        Me.cbMovimientos.TabIndex = 3
        '
        'etSubTotal
        '
        Me.etSubTotal.Location = New System.Drawing.Point(736, 313)
        Me.etSubTotal.Name = "etSubTotal"
        Me.etSubTotal.Size = New System.Drawing.Size(42, 13)
        Me.etSubTotal.StyleController = Me.LayoutControl1
        Me.etSubTotal.TabIndex = 129
        Me.etSubTotal.Text = "SubTotal"
        Me.etSubTotal.Visible = False
        '
        'dtpFecha
        '
        Me.dtpFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecha.EditValue = Nothing
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Location = New System.Drawing.Point(872, 36)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Properties.Appearance.Options.UseFont = True
        Me.dtpFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFecha.Size = New System.Drawing.Size(124, 22)
        Me.dtpFecha.StyleController = Me.LayoutControl1
        Me.dtpFecha.TabIndex = 5
        '
        'cmdVerPagos
        '
        Me.cmdVerPagos.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVerPagos.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdVerPagos.Appearance.Options.UseFont = True
        Me.cmdVerPagos.Appearance.Options.UseForeColor = True
        Me.cmdVerPagos.Location = New System.Drawing.Point(550, 313)
        Me.cmdVerPagos.Name = "cmdVerPagos"
        Me.cmdVerPagos.Size = New System.Drawing.Size(122, 22)
        Me.cmdVerPagos.StyleController = Me.LayoutControl1
        Me.cmdVerPagos.TabIndex = 5
        Me.cmdVerPagos.Text = "&Ver Pagos"
        Me.cmdVerPagos.Visible = False
        '
        'FechaD
        '
        Me.FechaD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaD.EditValue = Nothing
        Me.FechaD.Location = New System.Drawing.Point(869, 86)
        Me.FechaD.Name = "FechaD"
        Me.FechaD.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaD.Properties.Appearance.Options.UseFont = True
        Me.FechaD.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaD.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.FechaD.Size = New System.Drawing.Size(127, 22)
        Me.FechaD.StyleController = Me.LayoutControl1
        Me.FechaD.TabIndex = 6
        '
        'cmdConsultaClientes
        '
        Me.cmdConsultaClientes.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConsultaClientes.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdConsultaClientes.Appearance.Options.UseFont = True
        Me.cmdConsultaClientes.Appearance.Options.UseForeColor = True
        Me.cmdConsultaClientes.Location = New System.Drawing.Point(550, 313)
        Me.cmdConsultaClientes.Name = "cmdConsultaClientes"
        Me.cmdConsultaClientes.Size = New System.Drawing.Size(180, 22)
        Me.cmdConsultaClientes.StyleController = Me.LayoutControl1
        Me.cmdConsultaClientes.TabIndex = 4
        Me.cmdConsultaClientes.Text = "C&lientes"
        Me.cmdConsultaClientes.Visible = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAyuda.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdAyuda.Appearance.Options.UseFont = True
        Me.cmdAyuda.Appearance.Options.UseForeColor = True
        Me.cmdAyuda.Location = New System.Drawing.Point(550, 313)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(228, 22)
        Me.cmdAyuda.StyleController = Me.LayoutControl1
        Me.cmdAyuda.TabIndex = 3
        Me.cmdAyuda.Text = "Ayuda"
        Me.cmdAyuda.Visible = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Appearance.Options.UseForeColor = True
        Me.cmdCancelar.ImageOptions.Image = CType(resources.GetObject("cmdCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(893, 403)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(103, 38)
        Me.cmdCancelar.StyleController = Me.LayoutControl1
        Me.cmdCancelar.TabIndex = 1
        Me.cmdCancelar.Text = "&Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImprimir.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdImprimir.Appearance.Options.UseFont = True
        Me.cmdImprimir.Appearance.Options.UseForeColor = True
        Me.cmdImprimir.Location = New System.Drawing.Point(550, 313)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(52, 22)
        Me.cmdImprimir.StyleController = Me.LayoutControl1
        Me.cmdImprimir.TabIndex = 2
        Me.cmdImprimir.Text = "&Imprimir"
        Me.cmdImprimir.Visible = False
        '
        'txtFactura
        '
        Me.txtFactura.BackColor = System.Drawing.SystemColors.Info
        Me.txtFactura.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactura.ForeColor = System.Drawing.Color.DarkRed
        Me.txtFactura.Location = New System.Drawing.Point(138, 36)
        Me.txtFactura.MaxLength = 50
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.ReadOnly = True
        Me.txtFactura.Size = New System.Drawing.Size(287, 22)
        Me.txtFactura.TabIndex = 1
        '
        'txtDevolucion
        '
        Me.txtDevolucion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDevolucion.BackColor = System.Drawing.SystemColors.Info
        Me.txtDevolucion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDevolucion.ForeColor = System.Drawing.Color.DarkRed
        Me.txtDevolucion.Location = New System.Drawing.Point(866, 12)
        Me.txtDevolucion.MaxLength = 50
        Me.txtDevolucion.Name = "txtDevolucion"
        Me.txtDevolucion.ReadOnly = True
        Me.txtDevolucion.Size = New System.Drawing.Size(130, 20)
        Me.txtDevolucion.TabIndex = 4
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cmdImprimir
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(538, 301)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(56, 42)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.cmdVerPagos
        Me.LayoutControlItem15.CustomizationFormText = "LayoutControlItem15"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(538, 301)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(126, 42)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.cmdConsultaClientes
        Me.LayoutControlItem14.CustomizationFormText = "LayoutControlItem14"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(538, 301)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(184, 42)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.cmdAyuda
        Me.LayoutControlItem13.CustomizationFormText = "LayoutControlItem13"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(538, 301)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(232, 42)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.etTotal
        Me.LayoutControlItem17.CustomizationFormText = "LayoutControlItem17"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(739, 318)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(31, 25)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.etSaldo
        Me.LayoutControlItem19.CustomizationFormText = "LayoutControlItem19"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(709, 318)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(61, 25)
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.etIva
        Me.LayoutControlItem18.CustomizationFormText = "LayoutControlItem18"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(688, 318)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(82, 25)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.etSaldoT
        Me.LayoutControlItem20.CustomizationFormText = "LayoutControlItem20"
        Me.LayoutControlItem20.Location = New System.Drawing.Point(734, 301)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(36, 42)
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.etSubTotal
        Me.LayoutControlItem16.CustomizationFormText = "LayoutControlItem16"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(724, 301)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(46, 42)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cbTodos
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(798, 50)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(72, 26)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(72, 26)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(72, 26)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.LayoutControlItem11, Me.LayoutControlItem4, Me.LayoutControlItem22, Me.LayoutControlItem10, Me.LayoutControlItem23, Me.LayoutControlItem24, Me.EmptySpaceItem3, Me.EmptySpaceItem1, Me.LayoutControlItem3, Me.LayoutControlItem7, Me.LayoutControlItem25, Me.LayoutControlItem21})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1008, 453)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtCliente
        Me.LayoutControlItem1.CustomizationFormText = "Cliente:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(782, 24)
        Me.LayoutControlItem1.Text = "Cliente:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(123, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtFactura
        Me.LayoutControlItem2.CustomizationFormText = "#Factura:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(417, 26)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(417, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(417, 26)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "#Factura:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(123, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbMovimientos
        Me.LayoutControlItem3.CustomizationFormText = "Movimiento:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(494, 24)
        Me.LayoutControlItem3.Text = "Movimiento:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(123, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtDevolucion
        Me.LayoutControlItem5.CustomizationFormText = "# Devolución:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(782, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(206, 24)
        Me.LayoutControlItem5.Text = "# Devolución:"
        Me.LayoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(67, 13)
        Me.LayoutControlItem5.TextToControlDistance = 5
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.dtpFecha
        Me.LayoutControlItem6.CustomizationFormText = "Fecha Factura:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(782, 24)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(206, 26)
        Me.LayoutControlItem6.Text = "Fecha Factura:"
        Me.LayoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(73, 13)
        Me.LayoutControlItem6.TextToControlDistance = 5
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.FechaD
        Me.LayoutControlItem7.CustomizationFormText = "Fecha Devolución:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(764, 74)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "Fecha Devolución:"
        Me.LayoutControlItem7.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(88, 13)
        Me.LayoutControlItem7.TextToControlDistance = 5
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.dgDatos
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(988, 255)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cmdAceptar
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(772, 391)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(109, 42)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(109, 42)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(109, 42)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cmdCancelar
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(881, 391)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(107, 42)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(107, 42)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(107, 42)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtReferencia
        Me.LayoutControlItem4.CustomizationFormText = "Referencia:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(417, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(365, 26)
        Me.LayoutControlItem4.Text = "Referencia:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(123, 13)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.cbTipoNota
        Me.LayoutControlItem21.Location = New System.Drawing.Point(494, 50)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(494, 24)
        Me.LayoutControlItem21.Text = "Tipo N / C:"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(123, 13)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.Razon
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 74)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(764, 52)
        Me.LayoutControlItem22.Text = "Motivo:"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(123, 13)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem23.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem23.Control = Me.txtTotal
        Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 381)
        Me.LayoutControlItem23.MaxSize = New System.Drawing.Size(347, 26)
        Me.LayoutControlItem23.MinSize = New System.Drawing.Size(347, 26)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(347, 26)
        Me.LayoutControlItem23.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem23.Text = "Total Devolución:"
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(123, 14)
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem24.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem24.Control = Me.txtTotalU
        Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 407)
        Me.LayoutControlItem24.MaxSize = New System.Drawing.Size(347, 26)
        Me.LayoutControlItem24.MinSize = New System.Drawing.Size(347, 26)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(347, 26)
        Me.LayoutControlItem24.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem24.Text = "Total Devolucón U$:"
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(123, 14)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(347, 381)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(425, 52)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'txtTCambio
        '
        Me.txtTCambio.EditValue = New Decimal(New Integer() {10000, 0, 0, 262144})
        Me.txtTCambio.Location = New System.Drawing.Point(830, 112)
        Me.txtTCambio.Name = "txtTCambio"
        Me.txtTCambio.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTCambio.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTCambio.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Red
        Me.txtTCambio.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTCambio.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTCambio.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTCambio.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtTCambio.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTCambio.Properties.Mask.EditMask = "n4"
        Me.txtTCambio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTCambio.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTCambio.Properties.ReadOnly = True
        Me.txtTCambio.Size = New System.Drawing.Size(166, 22)
        Me.txtTCambio.StyleController = Me.LayoutControl1
        Me.txtTCambio.TabIndex = 22
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.txtTCambio
        Me.LayoutControlItem25.Location = New System.Drawing.Point(764, 100)
        Me.LayoutControlItem25.MaxSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem25.MinSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem25.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem25.Text = "T/Cambio:"
        Me.LayoutControlItem25.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(49, 13)
        Me.LayoutControlItem25.TextToControlDistance = 5
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(772, 381)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(216, 10)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmDevolucionCliente
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1008, 453)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmDevolucionCliente"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtTotalU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Razon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipoNota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCentroDeCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReferencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMovimientos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaD.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTCambio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Clientes As New VB.SysContab.ClientesDB
    Dim FormaPago As New VB.SysContab.Forma_PagoDB

    'Dim Devolucion As New VB.SysContab.DevolucionesClienteDB
    'Dim r As New VB.SysContab.Rutinas

    Dim ds As DataSet

    Dim WithEvents tCust As DataTable
    Private WithEvents myDataSet As DataSet

    Dim Cantidad As DataGridTextBoxColumn
    Dim ValorActualCantidad As Double

    ''Agregado 17/04/2007 RMPR
    ''''''''''''''''''''''''''''''
    Dim ValorActualPrecio As Double
    Dim ValorActualDescuento As Double

    Public Bodega As String
    Public CuentaCaja As String
    Public Cliente As Integer
    Public TipoPago As Integer

    Dim TipoFactura As String
    Dim cFormapago As String

    ''''''''''''''''''''''''''''''
    'Dim i As Integer

    Dim SubTotalFacturaClienteV As Double
    Dim SubTotalFacturaNoDescuentosV As Double
    Dim TotalFacturaClienteV As Double
    Dim TotalDescuentoV As Double

    Private myCheckBoxCol As Integer = 8 'my checkbox column 
    Dim Config As New VB.SysContab.ConfiguracionDB
    Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails
    Dim Llenando As Boolean
    Dim DT_DETALLE As New DataTable("DETALLE")

    Private Sub frmFacturacionClienteVer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''r.CambiarEstilo(Me)
        'r.FormularioColor(Me)
        'cbCliente.DataSource = Clientes.ClientesList().Tables("Clientes")
        'cbCliente.ValueMember = "Codigo"
        'cbCliente.DisplayMember = "Nombre"

        ConfigDetalles = ConfiguracionDB.GetConfigDetails

        'dgFacturacionCliente.ReadOnly = False
        'cbCliente.Enabled = False
        'Me.Bodega = ConfigDetalles.Bodega
        'Me.Cliente = ds.Tables("Facturas_Ventas").Rows(0).Item("Cliente")
        'Me.TipoFactura = ds.Tables("Facturas_Ventas").Rows(0).Item("Tipo_ITEM")
        'Me.cFormapago = ds.Tables("Facturas_Ventas").Rows(0).Item("Tipo_Factura")
        'If ds.Tables("Facturas_Ventas").Rows(0).Item("Cliente") = "9999" Then
        '    txtCliente.Text = ds.Tables("Facturas_Ventas").Rows(0).Item("Nombre_Cliente").ToString
        '    txtCliente.Visible = True
        'Else
        '    txtCliente.Visible = False
        '    cbCliente.SelectedValue = ds.Tables("Facturas_Ventas").Rows(0).Item("Cliente")
        'End If
        'dtpFecha.DateTime.Date = ds.Tables("Facturas_Ventas").Rows(0).Item("Fecha")
        'dtpFecha.Enabled = False
        'txtFactura.Text = ds.Tables("Facturas_Ventas").Rows(0).Item("Factura")

        dtpFecha.Enabled = False
        txtFactura.ReadOnly = True
        txtDevolucion.Text = DevolucionesClienteDB.Numero()
        FechaD.DateTime = Rutinas.Fecha()

        GetTipoMovimientos(cbMovimientos, 1)
        cbMovimientos.ItemIndex = 0

        Combo(cbTipoNota, db_TipoNotasCD.Listar(0), "[Seleccione Tipo de Nota]")
        txtTCambio.EditValue = FechaD.DateTime.Date

        'GetCentrosCostosList(cbCentroCosto)

        Combo(cbCentroDeCosto,
              ObtieneDatos("SELECT cdc.Codigo, cdc.Nombre FROM CentroDeCosto cdc" _
                                                   + " WHERE cdc.Activo = 1 AND cdc.Empresa = " & EmpresaActual & " ORDER BY cdc.Nombre"))


        'MakeDataSet()
        'dgFacturacionCliente.SetDataBinding(myDataSet, "Articulos")
        'AddCustomDataTableStyle()
        '
        txtReferencia.Text = "NC" & txtFactura.Text.PadLeft(6, "0"c)
        Cargar()
        Text = "Devolución de Clientes"
        Refresh()
        '
        'SubTotalFacturaClienteV = 0
        'SubTotalFacturaNoDescuentosV = 0
        'TotalFacturaClienteV = 0
        'TotalDescuentoV = 0

        'For i = 0 To tCust.Rows.Count - 1
        '    If tCust.Rows(i)("SubTotal") Is DBNull.Value Or tCust.Rows(i)("SubTotal").ToString = "" Or tCust.Rows(i)("SubTotal").ToString = "0.00" Then
        '        '
        '    ElseIf IsNumeric(tCust.Rows(i)("SubTotal")) And tCust.Rows(i)("SubTotal").ToString <> "" Then
        '        Try
        '            SubTotalFacturaClienteV = SubTotalFacturaClienteV + tCust.Rows(i)("SubTotal")
        '            SubTotalFacturaNoDescuentosV = SubTotalFacturaNoDescuentosV + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio"))
        '            TotalDescuentoV = TotalDescuentoV + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio") * tCust.Rows(i)("Descuento") / 100)
        '        Catch ex As Exception
        '            MsgBox(ex.Message)
        '        End Try
        '    End If
        'Next
        'etSaldo.Visible = False
        'etSaldoT.Visible = False
        'etSubTotal.Text = SubTotalFacturaClienteV.ToString(Round)
        'etIva.Text = (SubTotalFacturaClienteV * (ConfigDetalles.IVA / 100.0)).ToString(Round)
        'etTotal.Text = (SubTotalFacturaClienteV + CDbl(etIva.Text)).ToString(Round)
    End Sub

    Sub Cargar()

        'ds = Clientes.FacturaDetalleDevolucion(txtFactura.Text)
        'Me.dgDatos.DataSource = ds.Tables("Facturas_Ventas")

        DT_DETALLE = ObtieneDatos("sp_FacturaDetalleDevolucion",
            txtFactura.Text,
            EmpresaActual)

        dgDatos.DataSource = DT_DETALLE
        vDatos.PopulateColumns()
        FormatoGrid(vDatos, 2, 0, False, False, False)
        '
        For i As Integer = 0 To Me.vDatos.Columns.Count - 1
            Me.vDatos.Columns(i).OptionsColumn.AllowEdit = False
        Next

        Me.vDatos.Columns("CANTIDAD").OptionsColumn.AllowEdit = True
        Me.vDatos.Columns("CANTIDAD").ColumnEdit = Me.txtCantidad
        Me.vDatos.Columns("SELECCIONAR").OptionsColumn.AllowEdit = True

        Me.vDatos.Columns("CentroID").OptionsColumn.AllowEdit = True
        Me.vDatos.Columns("CentroID").ColumnEdit = cbCentroDeCosto
        Me.vDatos.Columns("CentroID").Caption = "C.COSTO"
        '
        Me.vDatos.Columns("COSTO").Visible = False
        Me.vDatos.Columns("NUMERO").Visible = False
        Me.vDatos.Columns("BODEGA").Visible = False
        Me.vDatos.Columns("Exento").Visible = False
        Me.vDatos.Columns("CentroID").VisibleIndex = 8
        Me.vDatos.Columns("Tipo").Visible = False
        Me.vDatos.Columns("IvaP").Visible = False
        vDatos.Columns("TCambio").Visible = False
        vDatos.Columns("IdProyecto").Visible = False
        vDatos.Columns("EsProyecto").Visible = False
        '
        Me.vDatos.Columns("CANTIDAD FACTURADA").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("CANTIDAD FACTURADA").DisplayFormat.FormatString = "{0:n6}"
        '
        Me.vDatos.Columns("CANTIDAD DEVUELTA").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("CANTIDAD DEVUELTA").DisplayFormat.FormatString = "{0:n6}"
        '
        Me.vDatos.Columns("PRECIO").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("PRECIO").DisplayFormat.FormatString = "{0:n6}"
        '
        Me.vDatos.Columns("COSTO").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("COSTO").DisplayFormat.FormatString = "{0:n6}"
        '
        Me.vDatos.Columns("IVA").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("IVA").DisplayFormat.FormatString = "{0:n2}"
        '
        Me.vDatos.Columns("CANTIDAD").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("CANTIDAD").DisplayFormat.FormatString = "{0:n6}"

        txtCantidad.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        txtCantidad.Mask.EditMask = "n6"
        txtCantidad.Mask.UseMaskAsDisplayFormat = True
        '
        Me.vDatos.Columns("DESCUENTO").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("DESCUENTO").DisplayFormat.FormatString = "{0:n3}"
        '
        Me.vDatos.Columns("TOTAL").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("TOTAL").DisplayFormat.FormatString = "{0:n2}"
        Me.vDatos.Columns("TOTAL").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("TOTAL").SummaryItem.DisplayFormat = "{0:n2}"
        '
        Me.vDatos.BestFitColumns()
    End Sub

    'Private Sub MakeDataSet()

    '    myDataSet = New DataSet("myDataSet")

    '    tCust = New DataTable("Articulos")

    '    Dim cArticuloCodigo As DataColumn
    '    cArticuloCodigo = New DataColumn("ArticuloCodigo")

    '    Dim cArticulo As DataColumn
    '    cArticulo = New DataColumn("Articulo")

    '    Dim cCantidad As DataColumn
    '    cCantidad = New DataColumn("Cantidad")

    '    Dim cPrecio As DataColumn
    '    cPrecio = New DataColumn("Precio")

    '    Dim cCosto As DataColumn
    '    cCosto = New DataColumn("Costo")

    '    Dim cDescuento As DataColumn
    '    cDescuento = New DataColumn("Descuento")

    '    Dim cSubTotal As DataColumn
    '    cSubTotal = New DataColumn("SubTotal")

    '    Dim cCodigoTemporal As DataColumn
    '    cCodigoTemporal = New DataColumn("CodigoTemporal")

    '    Dim cCuenta As DataColumn
    '    cCuenta = New DataColumn("Cuenta")

    '    Dim cItemTipo As DataColumn
    '    cItemTipo = New DataColumn("Tipo")

    '    Dim cAgregar As DataColumn
    '    cAgregar = New DataColumn("Agregar", GetType(System.Boolean))

    '    Dim cCantidadFacturada As DataColumn
    '    cCantidadFacturada = New DataColumn("CantidadFacturada")

    '    Dim cCantidadDevuelta As DataColumn
    '    cCantidadDevuelta = New DataColumn("CantidadDevuelta")

    '    Dim cCantidadOriginal As DataColumn
    '    cCantidadOriginal = New DataColumn("CantidadOriginal")

    '    tCust.Columns.Add(cArticuloCodigo)
    '    tCust.Columns.Add(cArticulo)
    '    tCust.Columns.Add(cCantidad)
    '    tCust.Columns.Add(cPrecio)
    '    tCust.Columns.Add(cDescuento)
    '    tCust.Columns.Add(cSubTotal)
    '    tCust.Columns.Add(cCodigoTemporal)
    '    tCust.Columns.Add(cItemTipo)
    '    tCust.Columns.Add(cAgregar)
    '    tCust.Columns.Add(cCantidadFacturada)
    '    tCust.Columns.Add(cCantidadDevuelta)
    '    tCust.Columns.Add(cCantidadOriginal)
    '    tCust.Columns.Add(cCosto)
    '    tCust.Columns.Add(cCuenta)

    '    tCust.DefaultView.AllowDelete = False
    '    tCust.DefaultView.AllowNew = False

    '    myDataSet.Tables.Add(tCust)

    '    myDataSet.Tables("Articulos").DefaultView.AllowDelete = False
    '    myDataSet.Tables("Articulos").DefaultView.AllowNew = False

    '    Dim newRow1 As DataRow

    '    Dim j As Integer
    '    Llenando = True
    '    For j = 0 To ds.Tables("Facturas_Ventas").Rows.Count - 1
    '        'If ds.Tables("Facturas_Ventas").Rows(j).Item("Cantidad") <> 0 Then
    '        newRow1 = tCust.NewRow
    '        newRow1("ArticuloCodigo") = ds.Tables("Facturas_Ventas").Rows(j).Item("Item")
    '        tCust.Rows.Add(newRow1)

    '        tCust.Rows(j)("CodigoTemporal") = ds.Tables("Facturas_Ventas").Rows(j).Item("Item")
    '        tCust.Rows(j)("Articulo") = ds.Tables("Facturas_Ventas").Rows(j).Item("Descripcion")
    '        tCust.Rows(j)("CantidadOriginal") = ds.Tables("Facturas_Ventas").Rows(j).Item("Cantidad")
    '        tCust.Rows(j)("Cantidad") = ds.Tables("Facturas_Ventas").Rows(j).Item("Cantidad")
    '        tCust.Rows(j)("Precio") = CDbl(ds.Tables("Facturas_Ventas").Rows(j).Item("Precio")).ToString(Round)
    '        tCust.Rows(j)("Descuento") = CDbl(ds.Tables("Facturas_Ventas").Rows(j).Item("Descuento")).ToString(Round)
    '        tCust.Rows(j)("SubTotal") = (CDbl(CDbl(tCust.Rows(j)("Cantidad")) * CDbl(tCust.Rows(j)("Precio"))) - CDbl(CDbl(CDbl(tCust.Rows(j)("Cantidad")) * CDbl(tCust.Rows(j)("Precio")) * (CDbl(tCust.Rows(j)("Descuento")))) / 100.0)).ToString(Round)
    '        tCust.Rows(j)("Tipo") = ds.Tables("Facturas_Ventas").Rows(j).Item("Tipo_Item")
    '        tCust.Rows(j)("Agregar") = False

    '        tCust.Rows(j)("CantidadFacturada") = ds.Tables("Facturas_Ventas").Rows(j).Item("CantidadFacturada")
    '        tCust.Rows(j)("CantidadDevuelta") = ds.Tables("Facturas_Ventas").Rows(j).Item("CantidadDevuelta")
    '        tCust.Rows(j)("Costo") = ds.Tables("Facturas_Ventas").Rows(j).Item("Costo")
    '        tCust.Rows(j)("Cuenta") = ds.Tables("Facturas_Ventas").Rows(j).Item("Cuenta")
    '        'End If
    '    Next
    '    Llenando = False
    'End Sub

    'Private Sub TextBoxCantidadLeaveHandler(ByVal sender As Object, ByVal e As EventArgs)

    '    If Not IsNumeric(Cantidad.TextBox.Text) Then
    '        Cantidad.TextBox.Text = ValorActualCantidad
    '    Else
    '        If CDbl(Cantidad.TextBox.Text) <= 0 Then
    '            MsgBox("La cantidad debe ser mayor que Cero (0)", MsgBoxStyle.Information)
    '            Cantidad.TextBox.Text = ValorActualCantidad
    '            Exit Sub
    '        Else
    '            'If CDbl(Cantidad.TextBox.Text) > ds.Tables("Facturas_Ventas").Rows(Me.dgFacturacionCliente.CurrentRowIndex).Item("Cantidad") Then
    '            '    MsgBox("La cantidad a devolver debe ser menor o igual a la cantidad Facturada", MsgBoxStyle.Information)
    '            '    Cantidad.TextBox.Text = ds.Tables("Facturas_Ventas").Rows(Me.dgFacturacionCliente.CurrentRowIndex).Item("Cantidad")
    '            '    Exit Sub
    '            'End If
    '        End If
    '    End If
    'End Sub

    'Private Sub AddCustomDataTableStyle()
    '    Dim ts1 As DataGridTableStyle
    '    ts1 = New DataGridTableStyle

    '    ts1.MappingName = "Articulos"
    '    ts1.AlternatingBackColor = Color.LightBlue
    '    Dim colCount As Integer
    '    colCount = 0

    '    Dim ArticuloCodigo As DataGridTextBoxColumn
    '    ArticuloCodigo = New DataGridTextBoxColumn
    '    ArticuloCodigo.MappingName = "ArticuloCodigo"
    '    ArticuloCodigo.HeaderText = "Código"
    '    ArticuloCodigo.Width = 100
    '    ArticuloCodigo.Alignment = HorizontalAlignment.Left
    '    ArticuloCodigo.ReadOnly = True
    '    ArticuloCodigo.Format = "##,###0.00"
    '    ts1.GridColumnStyles.Add(ArticuloCodigo)
    '    colCount = (colCount + 1)

    '    ArticuloCodigo.NullText = ""


    '    Dim Articulo As DataGridTextBoxColumn
    '    Articulo = New DataGridTextBoxColumn
    '    Articulo.MappingName = "Articulo"
    '    Articulo.HeaderText = "Descripción"
    '    Articulo.Width = 300
    '    Articulo.Alignment = HorizontalAlignment.Left
    '    Articulo.ReadOnly = True
    '    Articulo.Format = "##,###0.00"
    '    ts1.GridColumnStyles.Add(Articulo)
    '    colCount = (colCount + 1)

    '    Articulo.NullText = ""

    '    'Dim Cantidad As DataGridTextBoxColumn
    '    Cantidad = New DataGridTextBoxColumn
    '    Cantidad.MappingName = "Cantidad"
    '    Cantidad.HeaderText = "Cantidad"
    '    Cantidad.Width = 100
    '    Cantidad.Alignment = HorizontalAlignment.Right
    '    Cantidad.ReadOnly = False

    '    AddHandler Cantidad.TextBox.Leave, New EventHandler(AddressOf TextBoxCantidadLeaveHandler)

    '    ts1.GridColumnStyles.Add(Cantidad)
    '    colCount = (colCount + 1)

    '    Cantidad.NullText = ""

    '    Dim Precio As DataGridTextBoxColumn
    '    Precio = New DataGridTextBoxColumn
    '    Precio.MappingName = "Precio"
    '    Precio.HeaderText = "Precio"
    '    Precio.Width = 85
    '    Precio.Alignment = HorizontalAlignment.Right
    '    Precio.ReadOnly = True
    '    Precio.Format = "##,###0.00"
    '    ts1.GridColumnStyles.Add(Precio)
    '    colCount = (colCount + 1)

    '    Precio.NullText = (0).ToString(Round)

    '    Dim Descuento As DataGridTextBoxColumn
    '    Descuento = New DataGridTextBoxColumn
    '    Descuento.MappingName = "Descuento"
    '    Descuento.HeaderText = "Descuento %"
    '    Descuento.Width = 85
    '    Descuento.Alignment = HorizontalAlignment.Right
    '    Descuento.ReadOnly = True
    '    Descuento.Format = "##,###0.00"

    '    ts1.GridColumnStyles.Add(Descuento)
    '    colCount = (colCount + 1)

    '    Descuento.NullText = (0).ToString(Round)

    '    Dim SubTotal As DataGridTextBoxColumn
    '    SubTotal = New DataGridTextBoxColumn
    '    SubTotal.MappingName = "SubTotal"
    '    SubTotal.HeaderText = "Sub Total"
    '    SubTotal.Width = 100
    '    SubTotal.Alignment = HorizontalAlignment.Right
    '    SubTotal.ReadOnly = True
    '    SubTotal.Format = "##,###0.00"
    '    ts1.GridColumnStyles.Add(SubTotal)
    '    colCount = (colCount + 1)

    '    SubTotal.NullText = (0).ToString(Round)

    '    Dim CodigoTemporal As DataGridTextBoxColumn
    '    CodigoTemporal = New DataGridTextBoxColumn
    '    CodigoTemporal.MappingName = "CodigoTemporal"
    '    CodigoTemporal.HeaderText = "CodigoTemporal"
    '    CodigoTemporal.Width = 0
    '    CodigoTemporal.Alignment = HorizontalAlignment.Left
    '    CodigoTemporal.ReadOnly = True
    '    ts1.GridColumnStyles.Add(CodigoTemporal)
    '    colCount = (colCount + 1)

    '    CodigoTemporal.NullText = ""

    '    Dim ItemTipo As DataGridTextBoxColumn
    '    ItemTipo = New DataGridTextBoxColumn
    '    ItemTipo.MappingName = "Tipo"
    '    ItemTipo.HeaderText = "Tipo"
    '    ItemTipo.Width = 0
    '    ItemTipo.ReadOnly = True

    '    ts1.GridColumnStyles.Add(ItemTipo)
    '    colCount = (colCount + 1)

    '    ItemTipo.NullText = ""


    '    Dim boolCol As DataGridCheckBoxChangeEvent.MyDataGridBoolColumn
    '    boolCol = New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn(colCount)
    '    boolCol.MappingName = "Agregar"
    '    boolCol.HeaderText = "Seleccionar"
    '    boolCol.Alignment = HorizontalAlignment.Center
    '    'uncomment this line to get a two-state checkbox
    '    CType(boolCol, DataGridBoolColumn).AllowNull = False

    '    boolCol.Width = 70
    '    boolCol.ReadOnly = False

    '    boolCol.NullText = ""

    '    'hook the new event to our handler in the grid
    '    AddHandler boolCol.BoolValueChanged, New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn.BoolValueChangedEventHandler(AddressOf HandleBoolChanges)

    '    ts1.GridColumnStyles.Add(boolCol)
    '    colCount = (colCount + 1)

    '    Dim CantidadFacturada As DataGridTextBoxColumn
    '    CantidadFacturada = New DataGridTextBoxColumn
    '    CantidadFacturada.MappingName = "CantidadFacturada"
    '    CantidadFacturada.HeaderText = ""
    '    CantidadFacturada.Width = 0
    '    CantidadFacturada.Alignment = HorizontalAlignment.Right
    '    CantidadFacturada.ReadOnly = True

    '    'AddHandler Cantidad.TextBox.Leave, New EventHandler(AddressOf TextBoxCantidadLeaveHandler)

    '    ts1.GridColumnStyles.Add(CantidadFacturada)
    '    colCount = (colCount + 1)

    '    CantidadFacturada.NullText = ""


    '    Dim CantidadDevuelta As DataGridTextBoxColumn
    '    CantidadDevuelta = New DataGridTextBoxColumn
    '    CantidadDevuelta.MappingName = "CantidadDevuelta"
    '    CantidadDevuelta.HeaderText = ""
    '    CantidadDevuelta.Width = 0
    '    CantidadDevuelta.Alignment = HorizontalAlignment.Right
    '    CantidadDevuelta.ReadOnly = True

    '    'AddHandler Cantidad.TextBox.Leave, New EventHandler(AddressOf TextBoxCantidadLeaveHandler)

    '    ts1.GridColumnStyles.Add(CantidadDevuelta)
    '    colCount = (colCount + 1)

    '    CantidadDevuelta.NullText = ""

    '    Dim Costo As DataGridTextBoxColumn
    '    Costo = New DataGridTextBoxColumn
    '    Costo.MappingName = "Costo"
    '    Costo.HeaderText = "Costo"
    '    Costo.Width = 0
    '    Costo.Alignment = HorizontalAlignment.Right
    '    Costo.ReadOnly = True
    '    Costo.Format = "##,###0.00"
    '    ts1.GridColumnStyles.Add(Costo)
    '    colCount = (colCount + 1)

    '    Costo.NullText = (0).ToString(Round)

    '    Dim Cuenta As DataGridTextBoxColumn
    '    Cuenta = New DataGridTextBoxColumn
    '    Cuenta.MappingName = "Cuenta"
    '    Cuenta.HeaderText = "Cuenta"
    '    Cuenta.Width = 0
    '    Cuenta.Alignment = HorizontalAlignment.Left
    '    Cuenta.ReadOnly = True
    '    ts1.GridColumnStyles.Add(Cuenta)
    '    colCount = (colCount + 1)

    '    Cuenta.NullText = ""

    '    'ts1.AllowSorting = False
    '    'ts1.HeaderFont = dgFacturacionCliente.HeaderFont
    '    'ts1.HeaderBackColor = Color.LightSteelBlue  'Color.LightBlue 'LightSteelBlue
    '    'dgFacturacionCliente.CaptionVisible = False
    '    'ts1.GridLineColor = Color.FromArgb(70, 130, 180)

    '    ts1.PreferredRowHeight = 25

    '    'TS1.DefaultTableStyl
    '    myDataSet.Tables("Articulos").DefaultView.AllowDelete = False
    '    'dsTasaCambio.Tables("TASA_CAMBIO").DefaultView.AllowEdit = True
    '    'ts1.ReadOnly = True
    '    tCust.DefaultView.AllowDelete = False

    '    'dgFacturacionCliente.CaptionVisible = False

    '    'dgFacturacionCliente.TableStyles.Clear()
    '    'dgFacturacionCliente.TableStyles.Add(ts1)

    'End Sub

    'Private Sub HandleBoolChanges(ByVal sender As Object, ByVal e As DataGridCheckBoxChangeEvent.BoolValueChangedEventArgs)
    'Dim s As String
    '    s = System.String.Format("Bool Changes: row {0}, col {1}   value {2}", e.Row, e.Column, e.BoolValue)
    '    Console.WriteLine(s)
    'End Sub

    Private Sub cmdCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdConsultaClientes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdConsultaClientes.Click
        'If cbCliente.Text = "" Then
        '    MsgBox("Seleccione el Cliente", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'If cbCliente.SelectedValue = Nothing Then
        '    MsgBox("El cliente no está registrado", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'If txtCliente.Visible = True Then
        '    MsgBox("El cliente no está registrado", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        Dim f As frmAcumulados = frmAcumulados.Instance()
        'RegistroCliente = cbCliente.SelectedValue
        RegistroCliente = Cliente

        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub

    Private Sub cmdVerPagos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdVerPagos.Click
        Registro = txtFactura.Text
        If Clientes.CobrosHistorial(txtFactura.Text).Tables("Cobros").Rows.Count = 0 Then
            MsgBox("La Factura seleccionada no tiene ningún pago", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim f As frmHistorialCobros = frmHistorialCobros.Instance()

        f.MdiParent = Me.MdiParent
        f.WindowState = FormWindowState.Maximized
        f.Show()
    End Sub

    Private Sub dgFacturacionCliente_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        'Dim hti As DataGrid.HitTestInfo = Me.dgFacturacionCliente.HitTest(e.X, e.Y)
        'Try
        '    If hti.Type = DataGrid.HitTestType.Cell AndAlso hti.Column = myCheckBoxCol Then
        '        Me.dgFacturacionCliente(hti.Row, hti.Column) = Not CBool(Me.dgFacturacionCliente(hti.Row, hti.Column))
        '    Else
        '        Exit Sub
        '    End If
        'Catch ex As Exception
        '    'MessageBox.Show(ex.ToString())
        'End Try
    End Sub 'dataGrid2_MouseUp

    Sub GuardarDevolucion()

        Dim Numero As String = DevolucionesClienteDB.Numero()
        txtDevolucion.Text = Numero
        '
        Dim Plantilla As New VB.SysContab.PlantillaDB
        Dim plan As String = Plantilla.GetTipoPlantilla(4, 4).ToString
        '
        If plan = "" Or plan Is DBNull.Value Then
            XtraMsg("No hay Plantilla Contable de Devolución para Realizar esta Transacción", MessageBoxIcon.Error)
            Exit Sub
        End If

        'Dim Detalles As VB.SysContab.PlantillaDetails = Plantilla.GetPlantillasDetails(plan)
        'DetalleCliente = VB.SysContab.ClientesDB.GetDetails(Cliente)

        Dim ClienteDetalle As New VB.SysContab.ClientesDetails
        ClienteDetalle = VB.SysContab.ClientesDB.GetDetails(Cliente)
        '
        Dim CuentaCliente As String = String.Empty,
            CompNo As Integer = 0,
            NoFactura As String = txtFactura.Text,
            EsProducto As Boolean = True,
            Repetido As Boolean = False,
            CuentaIVA As String = String.Empty,
            fp As Integer = 0,
            FechaDevolucion As Date = FechaD.DateTime.Date,
            TipoComp As Integer = Plantilla.GetPlantillasDetails(plan).TipoCompr

        Dim CuentasIventario As New ArrayList,     'CUENTAS CONTABLES D PRODUCTOS
            MontosIventario As New ArrayList,  'MONTO DE PRODUCTOS INVENTARIO        
            CuentasCostos As New ArrayList,     'CUENTAS CONTABLES D PRODUCTOS
            MontosCostos As New ArrayList,  'MONTO DE PRODUCTOS COSTO        
            CuentasIngresos As New ArrayList,   'CUENTAS CONTABLES D PRODUCTOS
            MontosIngresos As New ArrayList,  'MONTO DE PRODUCTOS INVENTARIO VS. COSTO
            ArrayCentros As New ArrayList,   'DISTRIBUION A LOS CENTROS DE COSTOS.
            TotalCaja As Double = 0,
            MontoIVA As Double = 0,
            DetalleProducto As New ArticulosDetails

        Dim PlanillaDetalle As New VB.SysContab.PlantillaDetails()
        Dim Per_Id As Integer = PeriodosDB.Activo(FechaD.DateTime.Date)
        Dim Dev As New DevolucionesClienteDB()
        Dim DTDistribucion As DataTable = CargaDistribucion(0, 0, 0)

        If Clientes.FacturaDetalleDevolucion(NoFactura) _
            .Tables("Facturas_Ventas") _
            .Rows.Count = 0 Then EsProducto = False

        If FormaPago.FormaPagoDias(TipoPago) = 0 Then   'Contado
            fp = 0
            PlanillaDetalle = VB.SysContab.PlantillaDB.GetPlantillasDetails(4, 1)

            If PlanillaDetalle.PlaID Is DBNull.Value Or
                PlanillaDetalle.PlaID Is Nothing Or
                PlanillaDetalle.PlaID = "" Then

                XtraMsg("No existen plantilla del tipo Factura de Contado", MessageBoxIcon.Warning)
                Exit Sub
            Else
                CuentaCliente = PlanillaDetalle.Detalles.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
                CuentaIVA = PlanillaDetalle.Detalles.Tables("PlantillasDetalles").Rows(3).Item("Cuenta")
                'CuentaIR = PlanillaDetalle.Detalles.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")
                'CuentaIR_Alcaldia = PlanillaDetalle.Detalles.Tables("PlantillasDetalles").Rows(6).Item("Cuenta")
            End If
        Else
            fp = 1
            PlanillaDetalle = VB.SysContab.PlantillaDB.GetPlantillasDetails(4, 2)

            If ClienteDetalle.Cuenta.Trim = "" Then
                XtraMsg("No se puede contabilizar la Devolución, porque no hay cuenta contable para el cliente: " & ClienteDetalle.Nombre, MessageBoxIcon.Error)
                Exit Sub
            End If
            '
            If PlanillaDetalle.PlaID Is DBNull.Value Or
               PlanillaDetalle.PlaID Is Nothing Or
               PlanillaDetalle.PlaID = "" Then

                XtraMsg("No existen plantilla del tipo Factura de Crédito", MessageBoxIcon.Warning)
                Exit Sub
            Else
                CuentaCliente = ClienteDetalle.Cuenta
                CuentaIVA = PlanillaDetalle.Detalles.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")
            End If
        End If
        '
        'Iniciar Transacción...
        '/****************************************************************************
        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction
        '****************************************************************************/

        Try
            ShowSplash("Guardando Devolición....")
            '***************  CONTABILIZANDO DEVOLUCION FACTURA
            CompNo = ComprobanteDB.AddComprobante(TipoComp, 1,
           "Nota de Crédito por Devolución #: " & Numero & ", Referencia #: " & txtReferencia.Text,
           MonedaBase, Per_Id,
           FechaDevolucion, 0, "", False,
           Cliente, "", 0, "NC" & IIf(NoFactura.Length < 6, NoFactura.PadLeft(6, "0"), NoFactura),
           Rutinas.Fecha, 0,
           IIf(CInt(EmpresaActual) = 20, OrigenComprobantes.NC_ELECTRONICA, OrigenComprobantes.NC_DEVOLUCION))

            Dev.AddItem(Numero,
                        NoFactura,
                        txtReferencia.Text,
                        CompNo,
                        Per_Id,
                        FechaDevolucion.Month,
                        1,
                        "",
                        Razon.Text)

            For i As Integer = 0 To vDatos.DataRowCount - 1
                If vDatos.GetRowCellValue(i, "SELECCIONAR") Then

                    Dim IVAUnidad As Double = (((vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO")) -
                                                ((vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO")) *
                                                (vDatos.GetRowCellValue(i, "DESCUENTO") / 100.0))) * vDatos.GetRowCellValue(i, "IvaP"))

                    'Dim Descuento As Double = vDatos.GetRowCellValue(i, "DESCUENTO")

                    Dev.AddItemDetalle(
                        Numero,
                        vDatos.GetRowCellValue(i, "ITEM"),
                        vDatos.GetRowCellValue(i, "Tipo"),
                        vDatos.GetRowCellValue(i, "CANTIDAD"),
                        IVAUnidad,
                        vDatos.GetRowCellValue(i, "PRECIO"))

                    'VB.SysContab.Rutinas.ErrorTransaccion()
                    'Exit Sub

                    Guardar_Con_Transaccion("sp_DevolucionClienteDetalle_Proyecto",
                                            vDatos.GetRowCellValue(i, "NUMERO"),
                                            vDatos.GetRowCellValue(i, "CANTIDAD"),
                                            EmpresaActual)

                    Guardar_Con_Transaccion("sp_DevolucionClienteDetalle_Devuelto",
                                            vDatos.GetRowCellValue(i, "NUMERO"),
                                            EmpresaActual)

                    DetalleProducto = ArticulosDB.GetDetailsTrans(
                        vDatos.GetRowCellValue(i, "ITEM"),
                        vDatos.GetRowCellValue(i, "Tipo"),
                        EmpresaActual)
                    ''***********   CUENTAS DE INGRESOS  **********************
                    Repetido = False

                    For c As Integer = 0 To CuentasIngresos.Count - 1
                        If DetalleProducto.CDevolucion = CuentasIngresos(c) Then
                            MontosIngresos(c) = MontosIngresos(c) + ((vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO")) -
                                                                    ((vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO")) *
                                                                    (vDatos.GetRowCellValue(i, "DESCUENTO") / 100.0)))

                            Repetido = True
                        End If
                    Next
                    '
                    If Repetido = False Then
                        CuentasIngresos.Add(DetalleProducto.CDevolucion)

                        MontosIngresos.Add(((vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO")) -
                                                                    ((vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO")) *
                                                                    (vDatos.GetRowCellValue(i, "DESCUENTO") / 100.0))))
                    End If
                    '' ***********   FIN CUENTAS DE INGRESOS  *********************
                    '' ***********  DISTRIBUCION CUENTAS DE INGRESOS  *************
                    Dim ExisteCentro As Boolean = False
                    Dim Existe As Boolean = False
                    '
                    For c As Integer = 0 To ArrayCentros.Count - 1
                        'Verifica si existe centro
                        If vDatos.GetRowCellValue(i, "CentroID") = ArrayCentros(c) Then
                            ExisteCentro = True
                            'Distribucion Ingresos
                            For d As Integer = 0 To DTDistribucion.Rows.Count - 1
                                If DetalleProducto.CDevolucion = DTDistribucion.Rows(d).Item("Cuenta") And
                                             DTDistribucion.Rows(d).Item("IdCentroCosto") = ArrayCentros(c) Then

                                    Existe = True
                                    DTDistribucion.Rows(d).Item("Valor") = Math.Round(((vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO")) -
                                                                    ((vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO")) *
                                                                    (vDatos.GetRowCellValue(i, "DESCUENTO") / 100.0))) +
                                                                                      DTDistribucion.Rows(d).Item("Valor"), 2)
                                End If
                            Next
                        End If
                    Next
                    '
                    If ExisteCentro = False Then
                        'Verifica si no existe y lo agrega
                        ArrayCentros.Add(vDatos.GetRowCellValue(i, "CentroID"))
                    End If
                    '' ***********  FIN DISTRIBUCION CUENTAS DE INGRESOS  *************
                    ''******************** AGREGAR DISTRIBUCION A LA TABLA ***********
                    If Existe = False Then
                        Dim row As DataRow = DTDistribucion.NewRow()
                        Dim DT_RG As DataTable = ObtieneDatosTrans("sp_sel_RubroGastos",
                                                                    DetalleProducto.CDevolucion,
                                                                    EmpresaActual)

                        If DT_RG.Rows.Count > 0 Then
                            row("IdRubroGasto") = DT_RG.Rows(0).Item("Codigo")
                            row("IdEmpresa") = EmpresaActual
                            row("NoComp") = CompNo
                            row("Mes") = FechaDevolucion.Month
                            row("Per_Id") = Per_Id
                            row("IdCentroCosto") = vDatos.GetRowCellValue(i, "CentroID")   'cbCentroCosto.EditValue  
                            row("Valor") = Math.Round(((vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO")) -
                                                                    ((vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO")) *
                                                                    (vDatos.GetRowCellValue(i, "DESCUENTO") / 100.0))), 2)
                            row("Tipo") = "D"
                            row("Cuenta") = DetalleProducto.CDevolucion

                            DTDistribucion.Rows.Add(row)
                        End If
                    End If
                    '**************************************************
                    'FIN DE DISTRIBUCION -  CENTRO DE COSTOS
                    '**************************************************
                    TotalCaja = TotalCaja + ((vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO")) -
                                                                    ((vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO")) *
                                                                    (vDatos.GetRowCellValue(i, "DESCUENTO") / 100.0)))
                    '
                    MontoIVA = MontoIVA + IVAUnidad
                End If
            Next
            '
            '*****************  CONTABILIZANDO DEBITOS ***********************
            '*****************************************************************
            'Ingresos 
            For c As Integer = 0 To CuentasIngresos.Count - 1
                ComprobanteDB.AddComprobanteDetalles(CompNo, CuentasIngresos(c), "Ingreso por Devolución No. " & Numero,
                                          Math.Round(MontosIngresos(c), 2), "0", TipoComp, "D", "0", "0", FechaDevolucion.Date, 1)
            Next
            '
            'IVA    
            If MontoIVA > 0 Then
                ComprobanteDB.AddComprobanteDetalles(CompNo, CuentaIVA, "IVA Por Devolución No. " & Numero,
                                          Math.Round(MontoIVA, 2), "0", TipoComp, "D", "0", "0", FechaDevolucion.Date, 1)
            End If
            '
            '*****************  CONTABILIZANDO CREDITO ***********************
            '*****************************************************************
            'Cajas
            ComprobanteDB.AddComprobanteDetalles(CompNo, CuentaCliente, IIf(fp = 0, "Fondos por Depositar/Cajas", "Cuentas x Cobrar Clientes"),
                                        Math.Round(TotalCaja + MontoIVA, 2), "0", TipoComp, "C", "0", "0", FechaDevolucion.Date, 1)
            '
            '----------------------
            'Guarda la Distribucion
            '----------------------
            GuardaDistribucionTrans(
                DTDistribucion,
                FechaDevolucion.Date,
                CompNo)

            VB.SysContab.Rutinas.okTransaccion()

            HideSplash()
        Catch ex As Exception
            HideSplash()
            XtraMsg(ex.Message & " Contabilizar.",
                    MessageBoxIcon.Error)
            Rutinas.ErrorTransaccion()
            Exit Sub
        End Try
        '
        Try
            ShowSplash("Guardando N/C...")
            '***************** GUARDAR NOTA DE CREDITO ***********************
            Dim db_Notas As New db_MaestroNotasCD
            Dim NoNota As String = "NC" + IIf(NoFactura.Length < 6, NoFactura.PadLeft(6, "0"), NoFactura)
            '
            Dim IdNota As Integer = db_Notas.Guardar(
                NoNota,
                ClienteDetalle.Codigo,
                FechaDevolucion.Date,
                TipoComp,
                TotalCaja + MontoIVA,
                "Nota de Crédito por Devolución #: " & Numero & ", Referencia #: " & txtReferencia.Text,
                1,
                MonedaBase,
                CompNo,
                Per_Id,
                FechaDevolucion.Month,
                FechaDevolucion.Date,
                0,
                cbTipoNota.EditValue,
                "",
                Numero)
            '
            If IdNota > 0 Then
                'Detalle de la N/C
                db_Notas.GuardarDetalle(
                    IdNota,
                    NoFactura,
                    TotalCaja + MontoIVA,
                    FechaDevolucion.Date,
                    0.00)
            End If
            ''*************** FIN REGISTRO NOTA DE CREDITO ****************
            '----------------------------------------
            'Guarda Movimiento de Inventario
            '----------------------------------------
            If EsProducto Then

                Dim dr() As DataRow = DT_DETALLE.Select(
                    "SELECCIONAR = 1 AND Tipo = 'P'")

                If dr.Length > 0 Then

                    Dim _DETALLE As DataTable = DT_DETALLE.Select(
                        "SELECCIONAR = 1 AND Tipo = 'P'") _
                       .CopyToDataTable

                    If _DETALLE.Select("IdProyecto = 0") _
                        .Length > 0 Then

                        Dim _SIN_PROY As DataTable =
                            _DETALLE.Select("IdProyecto = 0") _
                            .CopyToDataTable

                        If _SIN_PROY.Rows.Count > 0 Then

                            Dim Requisa As Integer = db_requisas.Add(
                                EmpresaActual,
                                "E",
                                FechaDevolucion.Date,
                                _SIN_PROY.Rows.Item(0)("BODEGA"),
                                Login, Numero,
                                cbMovimientos.EditValue,
                                "NC" & IIf(NoFactura.Length < 6, NoFactura.PadLeft(6, "0"), NoFactura),
                                "Nota de Crédito por Devolución #: " & Numero & ", Referencia #: " & txtReferencia.Text,
                                "", "", "", "", "", "", ClienteDetalle.Codigo, "", 0, 0, 0, Numero)

                            For i As Integer = 0 To _SIN_PROY.Rows.Count - 1
                                'If _SIN_PROY.Rows.Item(i)("Tipo") = "P" Then

                                db_requisas.AddDetalle(
                                        EmpresaActual,
                                        Requisa,
                                        _SIN_PROY.Rows.Item(i)("ITEM"),
                                        "P",
                                        _SIN_PROY.Rows.Item(i)("CANTIDAD"),
                                        _SIN_PROY.Rows.Item(i)("COSTO"),
                                        "NC", "", "", "")

                                'End If
                            Next
                        End If

                    End If

                    'Productos con Relacion a los Proyectos.
                    If _DETALLE.Select("IdProyecto > 0") _
                        .Length > 0 Then

                        Dim _CON_PROY As DataTable = _DETALLE _
                            .Select("IdProyecto > 0") _
                            .CopyToDataTable

                        If _CON_PROY.Rows.Count > 0 Then

                            Dim req = From row In _CON_PROY.AsEnumerable()
                                      Select row.Field(Of Object)("IdProyecto") Distinct

                            For Each s As Object In req
                                If Not s Is Nothing Then

                                    Dim _DT As DataTable =
                                        _CON_PROY _
                                        .Select("IdProyecto = " & s) _
                                        .CopyToDataTable

                                    Dim Requisa As Integer = db_requisas.Add(
                                        EmpresaActual,
                                        "E",
                                        FechaDevolucion.Date,
                                        _DT.Rows.Item(0)("BODEGA"),
                                        Login,
                                        Numero,
                                        cbMovimientos.EditValue,
                                        "NC" & IIf(NoFactura.Length < 6, NoFactura.PadLeft(6, "0"), NoFactura),
                                        "Nota de Crédito por Devolución #: " & Numero & ", Referencia #: " & txtReferencia.Text,
                                        "", "", "", "", "", "", ClienteDetalle.Codigo, "", s, 0, 0, Numero)

                                    For i As Integer = 0 To _DT.Rows.Count - 1
                                        'If _DT.Rows.Item(i)("Tipo") = "P" Then

                                        db_requisas.AddDetalle(
                                                EmpresaActual,
                                                Requisa,
                                                _DT.Rows.Item(i)("ITEM"),
                                                "P",
                                                _DT.Rows.Item(i)("CANTIDAD"),
                                                _DT.Rows.Item(i)("COSTO"),
                                                "NC", "", "", "")
                                        'End If
                                    Next

                                End If
                            Next

                        End If
                    End If
                End If
            End If

            HideSplash()
            XtraMsg("Devolución realizada Exitosamente !!!",
                    MessageBoxIcon.Information)

            'XtraMsg("Devolución Electrónica realizada Éxitosamente !!!",
            '        MessageBoxIcon.Information)

            ''Imprimir el Comprobante Contable de la Devolución
            ComprobanteDB.ImprimirComprobante(
                CompNo,
                PeriodosDB.Activo(FechaD.DateTime.Date),
                FechaD.DateTime.Date)

            'Actualizar Lista de Devoluciones
            Dim f As frmDevolucionesClienteList = frmDevolucionesClienteList.Instance()
            If f.Created Then f.Cargar()

            Close()
        Catch ex As Exception
            HideSplash()
            XtraMsg(ex.Message & " Guardar N/C",
                    MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim Cantidad As Integer = 0

        Dim Articulos As New VB.SysContab.ArticulosDB
        Dim DetallesProducto As New VB.SysContab.ArticulosDetails
        'Dim gruposcc As New VB.SysContab.GruposCCDB

        Dim DetalleCliente As New VB.SysContab.ClientesDetails
        Dim Comprobantes As New VB.SysContab.ComprobanteDB
        Dim EmpresasDB As New VB.SysContab.EmpresasDB
        Dim PeriodosDB As New VB.SysContab.PeriodosDB

        'Verificar Cierre del Día
        '*******************************************************************************************
        If Not VerificarCierre(FechaD.DateTime.Date) Then
            Exit Sub
        End If
        '*******************************************************************************************
        ''
        '*******************************************************************************************
        ' Validar Cierre de Inventario
        If Not VerificarCierre_Inventario(FechaD.DateTime.Date) Then
            Exit Sub
        End If
        '*******************************************************************************************

        '*******************************************************************************************
        'Verificar Cierre de Bolsa        
        If FechaD.DateTime.Date <= db_FACTURAS_BOLSA.UltimoCierre().Date Then
            XtraMsg("La fecha: " & FechaD.DateTime.ToShortDateString & " con la que intenta grabar esta Devolución ya fue reportada en BOLSA AGROPECUARIA, " & vbCrLf &
                    "Ultima fecha reportada al: " & db_FACTURAS_BOLSA.UltimoCierre().Date.ToShortDateString, MessageBoxIcon.Error)
            Exit Sub
        End If
        '*******************************************************************************************

        If cbMovimientos.ItemIndex = 0 Then
            XtraMsg("Seleccione el Tipo de Movimiento de Inventario")
            cbMovimientos.Focus()
            Exit Sub
        End If
        '
        If cbTipoNota.EditValue Is Nothing Then
            XtraMsg("Seleccione el tipo de Nota de Crédito", MessageBoxIcon.Warning)
            cbTipoNota.Focus()
            Exit Sub
        End If
        '
        If txtReferencia.Text.Trim.Length = 0 Then
            XtraMsg("Introduzca el Numero de Referencia de la Devolución")
            txtReferencia.Focus()
            Exit Sub
        End If
        '
        Dim selec As Boolean = False

        For i As Integer = 0 To vDatos.DataRowCount - 1
            If IsNull(vDatos.GetRowCellValue(i, "CentroID"), 0) = 0 Then
                XtraMsg("Seleccione Centro de Costo!",
                        MessageBoxIcon.Warning)
                Exit Sub
            End If

            If vDatos.GetRowCellValue(i, "SELECCIONAR") Then
                selec = True
            End If
        Next

        If Not selec Then
            XtraMsg("Debe Seleccionar al menos 1 producto", MessageBoxIcon.Warning)
            Exit Sub
        End If

        GuardarDevolucion()

        'If cbCentroCosto.EditValue Is Nothing Then
        '    XtraMsg("Seleccione Centro de Costo")
        '    cbCentroCosto.Focus()
        '    Exit Sub
        'End If

        'Dim Cuentas(tCust.Rows.Count) As String
        'Dim Montos(tCust.Rows.Count) As Double

        'Dim IVA As Double = 0
        'Dim CompNo As Integer = 0

        'If tCust.Rows.Count = 0 Then
        '    MsgBox("Seleccione al menos un Producto", MsgBoxStyle.Critical)
        '    dgFacturacionCliente.Focus()
        '    Exit Sub
        'End If

        'For i = 0 To tCust.Rows.Count - 1
        '    If tCust.Rows(i)("Agregar") = True Then
        '        Cantidad = 1
        '        Exit For
        '    End If
        'Next

        'If Cantidad = 0 Then
        '    MsgBox("Seleccione al menos un Producto", MsgBoxStyle.Critical)
        '    dgFacturacionCliente.Focus()
        '    Exit Sub
        'End If

        'Genear Tabla Temporal de ARTICULOS
        'GuardaDatos("JAR_CrearArticulosTemp " & EmpresaActual)
        '        

        'Dim j As Integer
        'Dim x As Integer

        'Dim Numero As String = DevolucionesClienteDB.Numero()
        'txtDevolucion.Text = Numero

        'x = 0
        'Si es de productos
        'If Me.TipoFactura = "P" Then
        '    For i = 0 To tCust.Rows.Count - 1
        '        If tCust.Rows(i)("Agregar") Then
        '            DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(tCust.Rows(i)("CodigoTemporal"), Me.TipoFactura, EmpresaActual)
        '            If DetallesProducto.Cuenta = "" Or DetallesProducto.Cuenta = "0" Then
        '                MsgBox("No se puede contabilizar la entrada a almacen por devolucion, porque no hay cuenta contable para el producto: " & DetallesProducto.Nombre, MsgBoxStyle.Critical, "STS-Contab")
        '                Exit Sub
        '            Else
        '                j = Cuentas.IndexOf(Cuentas, DetallesProducto.Cuenta)
        '                'Si no encuentra la cuenta contable en el arreglo, la adiciona
        '                If j = -1 Then
        '                    Cuentas(x) = DetallesProducto.Cuenta
        '                    Montos(x) = tCust.Rows(i)("SubTotal")
        '                    x += 1
        '                Else
        '                    Montos(j) = Montos(j) + tCust.Rows(i)("SubTotal")
        '                End If
        '            End If
        '        End If
        '    Next
        'ElseIf Me.TipoFactura = "A" Then
        '    Dim rds As New DataSet
        '    For i = 0 To tCust.Rows.Count - 1
        '        If tCust.Rows(i)("Agregar") Then
        '            rds = gruposcc.ArticulosCCDetalles(tCust.Rows(i)("CodigoTemporal"))

        '            If rds.Tables(0).Rows(0)("Cuenta") = "" Or rds.Tables(0).Rows(0)("Cuenta") = "0" Then
        '                MsgBox("No se puede contabilizar la entrada a almacen por devolucion, porque no hay cuenta contable para el producto: " & DetallesProducto.Nombre, MsgBoxStyle.Critical, "STS-Contab")
        '                Exit Sub
        '            Else
        '                j = Cuentas.IndexOf(Cuentas, rds.Tables(0).Rows(0)("Cuenta"))
        '                'Si no encuentra la cuenta contable en el arreglo, la adiciona
        '                If j = -1 Then
        '                    Cuentas(x) = rds.Tables(0).Rows(0)("Cuenta")
        '                    Montos(x) = tCust.Rows(i)("SubTotal")
        '                    x += 1
        '                Else
        '                    Montos(j) = Montos(j) + tCust.Rows(i)("SubTotal")
        '                End If
        '            End If
        '        End If
        '    Next
        'End If

        'Dim Plantilla As New VB.SysContab.PlantillaDB
        'Dim plan As String

        'plan = Plantilla.GetTipoPlantilla(4, 4).ToString

        'If plan = "" Or plan Is DBNull.Value Then
        '    XtraMsg("No hay Plantilla Contable Disponible para Realizar esta Transacción", MessageBoxIcon.Exclamation)
        '    VB.SysContab.Rutinas.ErrorTransaccion()
        '    Exit Sub
        'End If

        'Dim Plantilla As New VB.SysContab.PlantillaDB
        'Dim plan As String = Plantilla.GetTipoPlantilla(4, 4).ToString
        ''
        'If plan = "" Or plan Is DBNull.Value Then
        '    XtraMsg("No hay Plantilla Contable de Devolución para Realizar esta Transacción", MessageBoxIcon.Error)
        '    Exit Sub
        'End If

        ''Dim Detalles As VB.SysContab.PlantillaDetails = Plantilla.GetPlantillasDetails(plan)
        ''DetalleCliente = VB.SysContab.ClientesDB.GetDetails(Cliente)

        'Dim ClienteDetalle As New VB.SysContab.ClientesDetails
        'ClienteDetalle = VB.SysContab.ClientesDB.GetDetails(Cliente)

        ''
        'If DetalleCliente.Cuenta.Trim = "" Then
        '    XtraMsg("No se puede contabilizar la Devolución, porque no hay cuenta contable para el cliente: " & DetalleCliente.Nombre, MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        '

        ''Devolucion.AddItem(Numero, Me.txtFactura.Text, txtReferencia.Text)
        ' ''
        ' ''VB.SysContab.BodegasDB.TransaccionBodega_Add(Me.Bodega, "D", Numero, Me.FechaD.DateTime.Date, 0)
        ' ''
        ''For i As Integer = 0 To Me.vDatos.DataRowCount - 1
        ''    If Me.vDatos.GetRowCellValue(i, "SELECCIONAR") Then
        ''        Devolucion.AddItemDetalle(Numero, Me.vDatos.GetRowCellValue(i, "ITEM"), "P", Me.vDatos.GetRowCellValue(i, "CANTIDAD"), Me.vDatos.GetRowCellValue(i, "IVA"))
        ''        If Me.vDatos.GetRowCellValue(i, "CANTIDAD") + Me.vDatos.GetRowCellValue(i, "CANTIDAD DEVUELTA") = Me.vDatos.GetRowCellValue(i, "CANTIDAD FACTURADA") Then
        ''            GuardaDatosTrans("UPDATE Facturas_Ventas_Lineas SET Devuelto = 1 WHERE NUMERO = " & Me.vDatos.GetRowCellValue(i, "NUMERO"))
        ''        End If
        ''        '
        ''        'VB.SysContab.BodegasDB.Bodega_Articulos_Add(Bodega, Me.vDatos.GetRowCellValue(i, "ITEM"), Me.vDatos.GetRowCellValue(i, "CANTIDAD"), _
        ''        '                                           Me.vDatos.GetRowCellValue(i, "COSTO"), "P", 1)
        ''        'VB.SysContab.BodegasDB.TransaccionBodegaDetalle_Add(Bodega, Me.vDatos.GetRowCellValue(i, "ITEM"), "D", Numero, "E", Me.vDatos.GetRowCellValue(i, "CANTIDAD"), _
        ''        '                                                    Me.vDatos.GetRowCellValue(i, "COSTO"), 0, "P")
        ''    End If
        ''Next
        '
        'For k = 0 To tCust.Rows.Count - 1
        '    If tCust.Rows(k)("Agregar") = True Then

        '        IVA = ((CDbl(tCust.Rows(k)("Precio")) * CDbl(tCust.Rows(k)("Cantidad"))) - ((CDbl(tCust.Rows(k)("Precio")) * CDbl(tCust.Rows(k)("Cantidad"))) * (CDbl(tCust.Rows(k)("Descuento")) / 100.0))) * (ConfigDetalles.IVA / 100.0)
        '        Devolucion.AddItemDetalle(Numero, tCust.Rows(k)("CodigoTemporal"), tCust.Rows(k)("Tipo"), tCust.Rows(k)("Cantidad"), IVA)

        '        If CDbl(CDbl(tCust.Rows(k)("Cantidad")) + CDbl(tCust.Rows(k)("CantidadDevuelta"))) = CDbl(tCust.Rows(k)("CantidadFacturada")) Then
        'Devolucion.UpdateItem(Me.txtFactura.Text, tCust.Rows(k)("CodigoTemporal"), "P", 1)
        '        End If
        '        'VB.SysContab.BodegasDB.Bodega_Articulos_Add(Me.Bodega, tCust.Rows(k)("CodigoTemporal"), CDbl(tCust.Rows(k)("Cantidad")), CDbl(tCust.Rows(k)("Precio")), tCust.Rows(k)("Tipo"))
        '        'Articulos.SumarExistencias(tCust.Rows(k)("CodigoTemporal"), CDbl(tCust.Rows(k)("Cantidad")), tCust.Rows(k)("Tipo"))
        '        'VB.SysContab.BodegasDB.TransaccionBodegaDetalle_Add(Me.Bodega, tCust.Rows(k)("CodigoTemporal"), "D", Numero, "E", CDbl(tCust.Rows(k)("Cantidad")), CDbl(tCust.Rows(k)("Precio")), 0, tCust.Rows(k)("Tipo"))
        '    End If
        'Next
        '

        '----------------------------------------------------------------------------------
        'Nuevo con reversion de plantilla de venta (Oscar Valdivia 12/04/2008 09:03:00 a.m)
        '----------------------------------------------------------------------------------

        'Dim CuentaIngr As String
        'Dim CuentaCosto As String
        '    Dim CuentaInventario As String
        '    Dim CuentaIVA As String
        '    Dim IR As String
        '    'Dim Comprobantes As New VB.SysContab.ComprobanteDB
        '    Dim CuentaIR As String
        '    'Dim CuentaCaja As String                
        '    'Dim CompNo As String
        '    Dim q As Integer
        '    Dim MontoCosto, MontoCostoTotal As Double
        '    Dim FormaPago As New VB.SysContab.Forma_PagoDB
        '    Dim CuentaIR_Alcaldia As String
        '    Dim Creditos, Debitos, IR_Alcaldia As Double
        '    Dim ClientesDB As New VB.SysContab.ClientesDB
        '    'Dim detalleCliente As New VB.SysContab.ClientesDetails
        '    Dim TipoCOmpr As String
        '    '
        '    Dim DetalleProducto As New ArticulosDetails
        '    Dim Repetido As Boolean = False
        '    Dim TotalCaja As Double = 0
        '    Dim MontoIVA As Double = 0
        '    '
        '    Dim CuentasIventario As New ArrayList     'CUENTAS CONTABLES D PRODUCTOS
        '    Dim MontosIventario As New ArrayList  'MONTO DE PRODUCTOS INVENTARIO
        '    '
        '    Dim CuentasCostos As New ArrayList     'CUENTAS CONTABLES D PRODUCTOS
        '    Dim MontosCostos As New ArrayList  'MONTO DE PRODUCTOS COSTO
        '    '
        '    Dim CuentasIngresos As New ArrayList   'CUENTAS CONTABLES D PRODUCTOS
        'Dim MontosIngresos As New ArrayList  'MONTO DE PRODUCTOS INVENTARIO VS. COSTO

        'Dim ArrayCentros As New ArrayList       'CENTROS DE DISTRIBUCION
        'Dim dtDistribucion As DataTable = CargaDistribucion(0, 0, 0)


        ''Iniciar Transacción...
        ''/****************************************************************************
        'DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        'DBConnFacturas.Open()
        'transaccionFacturas = DBConnFacturas.BeginTransaction
        ''****************************************************************************/

        ''
        'Try
        '    If FormaPago.FormaPagoDias(TipoPago) = 0 Then   'Contado    
        '        TipoCOmpr = Plantilla.GetPlantillasDetails(4, 1).TipoCompr

        '        If Plantilla.GetPlantillasDetails(4, 1).PlaID Is DBNull.Value Or Plantilla.GetPlantillasDetails(4, 1).PlaID Is Nothing Or Plantilla.GetPlantillasDetails(4, 1).PlaID = "" Then
        '            XtraMsg("No existen plantilla del tipo Pago de Contado", MessageBoxIcon.Warning)
        '            VB.SysContab.Rutinas.ErrorTransaccion()
        '            Exit Sub
        '        Else
        '            Dim DsPlantillas As DataSet = Plantilla.GetPlantillasDetails(4, 1).Detalles

        '            'CuentaCaja = DsPlantillas.Tables("PlantillasDetalles").Rows(7).Item("Cuenta")
        '            CuentaIR = DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")
        '            'CuentaIngr = DsPlantillas.Tables("PlantillasDetalles").Rows(2).Item("Cuenta")
        '            CuentaIVA = DsPlantillas.Tables("PlantillasDetalles").Rows(3).Item("Cuenta")
        '            CuentaIR_Alcaldia = DsPlantillas.Tables("PlantillasDetalles").Rows(6).Item("Cuenta")

        '            '' Buscar el municipio del cliente para aplicar el impuesto de la alcaldia
        '            If VB.SysContab.MunicipiosDB.GetDetails(DetalleCliente.Departamento, DetalleCliente.Municipio) Is Nothing Then
        '                XtraMsg("Hace falta asignarle al Cliente el Municipio correspondiente para la retención Municipal Sobre Ventas", MessageBoxIcon.Error)
        '                VB.SysContab.Rutinas.ErrorTransaccion()
        '                Exit Sub
        '            End If
        '            '
        '            'If DetalleCliente.Municipio = "0" Or DetalleCliente.RetenedorAlcaldia = False Then
        '            '    IR_Alcaldia = 0
        '            '    CuentaIR_Alcaldia = ""
        '            'Else
        '            '    If CDbl(CDbl(etSubTotal.Text).ToString(Round)) >= VB.SysContab.MunicipiosDB.GetDetails(DetalleCliente.Departamento, DetalleCliente.Municipio).Impuesto_SVenta_Min Then
        '            '        IR_Alcaldia = CDbl(CDbl(etSubTotal.Text).ToString(Round)) * (VB.SysContab.MunicipiosDB.GetDetails(DetalleCliente.Departamento, DetalleCliente.Municipio).Impuesto_SVenta / 100.0)
        '            '        CuentaIR_Alcaldia = DsPlantillas.Tables("PlantillasDetalles").Rows(6).Item("Cuenta")
        '            '    End If
        '            'End If

        '            ' Solo cuando sea producto
        '            'If TipoFactura = "P" Or TipoFactura = "A" Then
        '            '    CuentaCosto = DsPlantillas.Tables("PlantillasDetalles").Rows(4).Item("Cuenta")
        '            '    CuentaInventario = DsPlantillas.Tables("PlantillasDetalles").Rows(5).Item("Cuenta")
        '            'End If

        '            Dim Per_Id As Integer = PeriodosDB.Activo(Me.FechaD.DateTime.Date)

        '            CompNo = Comprobantes.AddComprobante(Detalles.TipoCompr, 1,
        '            "Comprobante de Devolucion #: " & Numero & ", Referencia#: " & txtReferencia.Text,
        '            EmpresasDB.GetDetails(EmpresaActual).MonedaBase, Per_Id,
        '            Me.FechaD.DateTime.Date, 0, "", False, Me.Cliente, "", 0, "D" & Numero, VB.SysContab.Rutinas.Fecha, 0, OrigenComprobantes.DEVOLUCION_CLIENTE)

        '            Devolucion.AddItem(Numero, Me.txtFactura.Text, txtReferencia.Text, CompNo, Per_Id, FechaD.DateTime.Date.Month)
        '            '
        '            For i As Integer = 0 To Me.vDatos.DataRowCount - 1
        '                If Me.vDatos.GetRowCellValue(i, "SELECCIONAR") Then
        '                    'Calcular el IVA en Regla de 3
        '                    Dim IVAUnidad As Double = CDbl(vDatos.GetRowCellValue(i, "IVA") / vDatos.GetRowCellValue(i, "CANTIDAD FACTURADA"))
        '                    Dim Descuento As Double = vDatos.GetRowCellValue(i, "DESCUENTO")

        '                    'Guardar Detalle de la Devolucion
        '                    '**************************************************************************
        '                    Devolucion.AddItemDetalle(Numero, Me.vDatos.GetRowCellValue(i, "ITEM"), "P", Me.vDatos.GetRowCellValue(i, "CANTIDAD"), (IVAUnidad * vDatos.GetRowCellValue(i, "CANTIDAD")))
        '                    Guardar_Con_Transaccion("sp_DevolucionClienteDetalle_Proyecto", vDatos.GetRowCellValue(i, "NUMERO"), vDatos.GetRowCellValue(i, "CANTIDAD"), EmpresaActual)
        '                    If Me.vDatos.GetRowCellValue(i, "CANTIDAD") + Me.vDatos.GetRowCellValue(i, "CANTIDAD DEVUELTA") = Me.vDatos.GetRowCellValue(i, "CANTIDAD FACTURADA") Then
        '                        Guardar_Con_Transaccion("sp_DevolucionClienteDetalle_Devuelto", vDatos.GetRowCellValue(i, "NUMERO"), EmpresaActual)
        '                        'GuardaDatosTrans("UPDATE Facturas_Ventas_Lineas SET Devuelto = 1 WHERE NUMERO = " & Me.vDatos.GetRowCellValue(i, "NUMERO"))
        '                    End If
        '                    '**************************************************************************

        '                    DetalleProducto = ArticulosDB.GetDetailsTrans(vDatos.GetRowCellValue(i, "ITEM"), "P", EmpresaActual)

        '                    '' ***********   CUENTAS DE INGRESOS  **************************************************
        '                    Repetido = False
        '                    '
        '                    For c As Integer = 0 To CuentasIngresos.Count - 1
        '                        If DetalleProducto.CDevolucion = CuentasIngresos(c) Then
        '                            MontosIngresos(c) = MontosIngresos(c) + ((vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO")) -
        '                                                                     (vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO") * (Descuento / 100)))
        '                            Repetido = True
        '                        End If
        '                    Next

        '                    If Repetido = False Then
        '                        CuentasIngresos.Add(DetalleProducto.CDevolucion)
        '                        MontosIngresos.Add((vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO")) -
        '                                           (vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO") * (Descuento / 100)))
        '                    End If
        '                    '' ***********   FIN CUENTAS DE INGRESOS  ***********************************************


        '                    '' ***********  DISTRIBUCION CUENTAS DE INGRESOS  **************************************************
        '                    Dim ExisteCentro As Boolean = False
        '                    Dim Existe As Boolean = False

        '                    For c As Integer = 0 To ArrayCentros.Count - 1
        '                        ' Verifica si existe centro
        '                        If vDatos.GetRowCellValue(i, "CentroID") = ArrayCentros(c) Then
        '                            'If cbCentroCosto.EditValue = ArrayCentros(c) Then
        '                            ExisteCentro = True
        '                            '' Distribucion Ingresos
        '                            For d As Integer = 0 To dtDistribucion.Rows.Count - 1
        '                                If DetalleProducto.CDevolucion = dtDistribucion.Rows(d).Item("Cuenta") And
        '                                 dtDistribucion.Rows(d).Item("IdCentroCosto") = ArrayCentros(c) Then
        '                                    Existe = True
        '                                    dtDistribucion.Rows(d).Item("Valor") = Math.Round(((vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO")) -
        '                                                                                      (vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO") * (Descuento / 100))) +
        '                                                                                       dtDistribucion.Rows(d).Item("Valor"), 2)
        '                                End If
        '                            Next
        '                        End If
        '                    Next

        '                    If ExisteCentro = False Then
        '                        ' Verifica si no existe y lo agrega
        '                        ArrayCentros.Add(Me.vDatos.GetRowCellValue(i, "CentroID"))
        '                        'ArrayCentros.Add(cbCentroCosto.EditValue)
        '                    End If

        '                    ''******************** Agregar Distribucion de Ingresos *********************
        '                    If Existe = False Then

        '                        Dim row As DataRow
        '                        row = dtDistribucion.NewRow()
        '                        '
        '                        Try
        '                            row("IdRubroGasto") = ObtieneDatosTrans("Select Codigo from  RubrosGastos WHERE CuentaContable = '" & DetalleProducto.CDevolucion & "' AND Empresa  =" & EmpresaActual).Rows(0).Item("Codigo")

        '                            row("IdEmpresa") = EmpresaActual
        '                            row("NoComp") = CompNo
        '                            row("Mes") = FechaD.DateTime.Date.Month
        '                            row("Per_Id") = VB.SysContab.PeriodosDB.Activo(FechaD.DateTime.Date)
        '                            row("IdCentroCosto") = vDatos.GetRowCellValue(i, "CentroID")   'cbCentroCosto.EditValue 
        '                            row("Valor") = Math.Round(((vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO")) -
        '                                                    (vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO") * (Descuento / 100))), 2)
        '                            row("Tipo") = "D"
        '                            row("Cuenta") = DetalleProducto.CDevolucion

        '                            dtDistribucion.Rows.Add(row)
        '                        Catch ex As Exception
        '                            VB.SysContab.Rutinas.ErrorTransaccion()
        '                            XtraMsg("La cuenta Contable de Devolución: " & DetalleProducto.CDevolucion & " no se encuentra en rubros de Distribución por favor agreguela para poder contabilizar ", MessageBoxIcon.Warning)
        '                            Exit Sub
        '                        End Try
        '                    End If

        '                    '***********************************************************************************************
        '                    'FIN DE DISTRIBUCION -  CENTRO DE COSTOS
        '                    '***********************************************************************************************
        '                    '
        '                    ' '' ***********   CUENTAS DE INVENTARIO  ***************************************
        '                    'Repetido = False
        '                    ''
        '                    'For c As Integer = 0 To CuentasIventario.Count - 1
        '                    '    If DetalleProducto.Cuenta = CuentasIventario(c) Then
        '                    '        MontosIventario(c) = MontosIventario(c) + (vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "COSTO"))
        '                    '        Repetido = True
        '                    '    End If
        '                    'Next

        '                    'If Repetido = False Then
        '                    '    CuentasIventario.Add(DetalleProducto.Cuenta)
        '                    '    MontosIventario.Add(vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "COSTO"))
        '                    'End If
        '                    ' '' *********** FIN CUENTAS DE INVENTARIO  ***************************************
        '                    '
        '                    ' '' ***********   CUENTAS DE COSTO  ***************************************
        '                    'Repetido = False
        '                    ''
        '                    'For c As Integer = 0 To CuentasCostos.Count - 1
        '                    '    If DetalleProducto.CCosto = CuentasCostos(c) Then
        '                    '        MontosCostos(c) = MontosCostos(c) + (vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "COSTO"))
        '                    '        Repetido = True
        '                    '    End If
        '                    'Next

        '                    'If Repetido = False Then
        '                    '    CuentasCostos.Add(DetalleProducto.CCosto)
        '                    '    MontosCostos.Add(vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "COSTO"))
        '                    'End If
        '                    ' '' *********** FIN CUENTAS DE COSTO  ***************************************

        '                    'DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(vDatos.GetRowCellValue(i, "ITEM"), "P", EmpresaActual)

        '                    TotalCaja = TotalCaja + ((vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO")) -
        '                                            (vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO") * (Descuento / 100)))
        '                    'MontoIVA = MontoIVA + vDatos.GetRowCellValue(i, "IVA")

        '                    'MontoIVA = MontoIVA + (((vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO")) - _
        '                    '                       (vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO") * (Descuento / 100))) * _
        '                    '                       IIf(vDatos.GetRowCellValue(i, "Exento") = False And DetalleCliente.Excento = False, ConfigDetalles.IVA / 100, 0))

        '                    MontoIVA = MontoIVA + (IVAUnidad * vDatos.GetRowCellValue(i, "CANTIDAD"))
        '                End If
        '            Next


        '            '*****************  CONTABILIZANDO DEBITOS ***********************
        '            '*****************************************************************
        '            'Ingresos  / Devolución
        '            For c As Integer = 0 To CuentasIngresos.Count - 1
        '                Comprobantes.AddComprobanteDetalles(CompNo, CuentasIngresos(c), "Ingreso por Devolucion No. " & Numero,
        '                                         Math.Round(MontosIngresos(c), 2), "0", TipoCOmpr, "D", "0", "0", Me.FechaD.DateTime.Date, 1)
        '            Next
        '            ''Inventario
        '            'For c As Integer = 0 To CuentasIventario.Count - 1
        '            '    Comprobantes.AddComprobanteDetalles(CompNo, CuentasIventario(c), "Cargo al Inventario por Devolucion No. " & Numero, _
        '            '                                MontosIventario(c), "0", TipoCOmpr, "D", "0", "0", Me.FechaD.DateTime.Date, 1)
        '            'Next
        '            'IVA    
        '            If MontoIVA > 0 Then
        '                Comprobantes.AddComprobanteDetalles(CompNo, CuentaIVA, "IVA Por Devolucion No. " & Numero,
        '                                          Math.Round(MontoIVA, 2), "0", TipoCOmpr, "D", "0", "0", Me.FechaD.DateTime.Date, 1)
        '            End If

        '            '*****************  CONTABILIZANDO CREDITO ***********************
        '            '*****************************************************************
        '            'Cajas
        '            Comprobantes.AddComprobanteDetalles(CompNo, CuentaCaja, "Caja por Devolucion No. " & Numero,
        '                                      Math.Round(TotalCaja + MontoIVA, 2), "0", TipoCOmpr, "C", "0", "0",
        '                                      Me.FechaD.DateTime.Date, 1)
        '            ''Costos de Venta
        '            'For c As Integer = 0 To CuentasCostos.Count - 1
        '            '    Comprobantes.AddComprobanteDetalles(CompNo, CuentasCostos(c), "Costo por Devolucion No. " & Numero, _
        '            '                                MontosCostos(c), "0", TipoCOmpr, "C", "0", "0", Me.FechaD.DateTime.Date, 1)
        '            'Next
        '        End If
        '        '    Dim Prod As Boolean = False
        '        '    Dim CostoServicio As Double = 0.0
        '        '    For q = 0 To tCust.Rows.Count - 1
        '        '        If tCust.Rows(q)("Tipo") = "P" Then
        '        '            MontoCosto = ((CDbl(tCust.Rows(q).Item("Cantidad"))) * CDbl(tCust.Rows(q).Item("Costo")))
        '        '            MontoCostoTotal = MontoCosto + MontoCostoTotal
        '        '            Prod = True
        '        '        End If

        '        '        If IsNull(tCust.Rows(q).Item("Cuenta"), "0") = "0" Then
        '        '            MsgBox("El Articulo " & tCust.Rows(q).Item("Item") & " no tiene cuenta contable asignada.  ")
        '        '            VB.SysContab.Rutinas.ErrorTransaccion()
        '        '            Exit Sub
        '        '        End If
        '        '        'Cargo al inventario
        '        '        If tCust.Rows(q)("Tipo") = "P" Then Comprobantes.AddComprobanteDetalles(CompNo, tCust.Rows(q).Item("Cuenta"), "Cargo al Inventario por Devolucion No. " & Numero, _
        '        '                                                                     MontoCosto, 0, TipoCOmpr, "D", "", 0, dtpFecha.DateTime.Date.Date, 1)
        '        '        If tCust.Rows(q)("Tipo") = "S" Then
        '        '            Comprobantes.AddComprobanteDetalles(CompNo, tCust.Rows(q).Item("Cuenta"), "Cargo por Servicio de Devolucion No. " & Numero, _
        '        '            ((CDbl(tCust.Rows(q).Item("Cantidad"))) * CDbl(tCust.Rows(q).Item("Precio"))), 0, TipoCOmpr, "D", "", 0, dtpFecha.DateTime.Date.Date, 1)
        '        '            CostoServicio += ((CDbl(tCust.Rows(q).Item("Cantidad"))) * CDbl(tCust.Rows(q).Item("Precio")))
        '        '        End If
        '        '    Next
        '        '    'Caja
        '        '    Comprobantes.AddComprobanteDetalles(CompNo, CuentaCaja, "Por Devolucion No. " & Numero, _
        '        '                                                                 etTotal.Text - CDbl(IR) - CDbl(IR_Alcaldia), 0, TipoCOmpr, "C", "", 0, dtpFecha.DateTime.Date.Date, 1)
        '        '    'Cuenta de Ingresos
        '        '    If TipoFactura = "P" Or Prod Then Comprobantes.AddComprobanteDetalles(CompNo, CuentaIngr, "Ingreso por Devolucion No. " & Numero, _
        '        '                                                 etSubTotal.Text - CostoServicio, 0, TipoCOmpr, "D", "", 0, dtpFecha.DateTime.Date.Date, 1)
        '        '    ' Para IVA
        '        '    If CDbl(IsNull(etIva.Text, 0)) > 0 Then Comprobantes.AddComprobanteDetalles(CompNo, CuentaIVA, "IVA Por Devolucion No. " & Numero, _
        '        '                                             etIva.Text, 0, TipoCOmpr, "D", "", 0, dtpFecha.DateTime.Date.Date, 1)
        '        '    'Para IR
        '        '    If CDbl(IR) > 0 Then Comprobantes.AddComprobanteDetalles(CompNo, CuentaIR, "IR Por Devolucion No. " & Numero, _
        '        '                         CDbl(IR), 0, TipoCOmpr, "C", "", 0, dtpFecha.DateTime.Date.Date, 1)
        '        '    'PAra IR Alcaldia                                                                     
        '        '    If CDbl(IR_Alcaldia) > 0 Then Comprobantes.AddComprobanteDetalles(CompNo, CuentaIR_Alcaldia, "IR Alcaldia Por Devolucion No. " & Numero, _
        '        '                                  CDbl(IR_Alcaldia), 0, TipoCOmpr, "C", "", 0, dtpFecha.DateTime.Date.Date, 1)
        '        '    ' Solo cuando sea producto o ambos
        '        '    If TipoFactura = "P" Or Prod Then
        '        '        'Costo de Venta
        '        '        Comprobantes.AddComprobanteDetalles(CompNo, CuentaCosto, "Costo por Devolucion No. " & Numero, _
        '        '        MontoCostoTotal, 0, TipoCOmpr, "C", "", 0, dtpFecha.DateTime.Date.Date, 1)
        '        '    End If
        '        'End If

        '    Else ' **************  FACTURA DE CREDITO
        '        TipoCOmpr = Plantilla.GetPlantillasDetails(4, 2).TipoCompr

        '        If Plantilla.GetPlantillasDetails(4, 2).PlaID Is DBNull.Value Or Plantilla.GetPlantillasDetails(4, 2).PlaID Is Nothing Or Plantilla.GetPlantillasDetails(4, 2).PlaID = "" Then
        '            XtraMsg("No existen plantilla del tipo Pago de Crédito", MessageBoxIcon.Warning)
        '            VB.SysContab.Rutinas.ErrorTransaccion()
        '            Exit Sub
        '        Else
        '            Dim DsPlantillas As DataSet = Plantilla.GetPlantillasDetails(4, 2).Detalles

        '            'CuentaIngr = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
        '            CuentaIVA = DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")

        '            '' Se valida que sea producto para no incluir las siguientes cuentas que no pertenecen a servicios
        '            '' So+++lo cuando sea producto
        '            'If TipoServicio.EditValue = "P" Or TipoServicio.EditValue = "A" Then
        '            '    CuentaCosto = DsPlantillas.Tables("PlantillasDetalles").Rows(2).Item("Cuenta")
        '            '    CuentaInventario = DsPlantillas.Tables("PlantillasDetalles").Rows(3).Item("Cuenta")
        '            'End If

        '            IR = 0

        '            If ClientesDB.GetDetails(Cliente).Cuenta = "" Or ClientesDB.GetDetails(Cliente).Cuenta Is Nothing Then
        '                XtraMsg("La cuenta del cliente no es valida", MessageBoxIcon.Error)
        '                VB.SysContab.Rutinas.ErrorTransaccion()
        '                Exit Sub
        '            End If

        '            Dim Per_Id As Integer = PeriodosDB.Activo(Me.FechaD.DateTime.Date)

        '            '***************  CONTABILIZANDO DEVOLUCION FACTURA DE CREDITO
        '            CompNo = Comprobantes.AddComprobante(Detalles.TipoCompr, 1,
        '           "Comprobante de Devolucion #: " & Numero & ", Referencia#: " & txtReferencia.Text,
        '           EmpresasDB.GetDetails(EmpresaActual).MonedaBase, Per_Id,
        '           Me.FechaD.DateTime.Date, 0, "", False, Me.Cliente, "", 0, "D" & Numero, VB.SysContab.Rutinas.Fecha, 0, OrigenComprobantes.DEVOLUCION_CLIENTE)

        '            Devolucion.AddItem(Numero, Me.txtFactura.Text, txtReferencia.Text, CompNo, Per_Id, FechaD.DateTime.Date.Month)

        '            For i As Integer = 0 To Me.vDatos.DataRowCount - 1
        '                If Me.vDatos.GetRowCellValue(i, "SELECCIONAR") Then
        '                    Dim IVAUnidad As Double = CDbl(vDatos.GetRowCellValue(i, "IVA") / vDatos.GetRowCellValue(i, "CANTIDAD FACTURADA"))
        '                    Dim Descuento As Double = vDatos.GetRowCellValue(i, "DESCUENTO")

        '                    'Guardar Detalle de la Devolucion
        '                    '**************************************************************************
        '                    Devolucion.AddItemDetalle(Numero, Me.vDatos.GetRowCellValue(i, "ITEM"), "P", Me.vDatos.GetRowCellValue(i, "CANTIDAD"), (IVAUnidad * vDatos.GetRowCellValue(i, "CANTIDAD")))
        '                    Guardar_Con_Transaccion("sp_DevolucionClienteDetalle_Proyecto", vDatos.GetRowCellValue(i, "NUMERO"), vDatos.GetRowCellValue(i, "CANTIDAD"), EmpresaActual)
        '                    If Me.vDatos.GetRowCellValue(i, "CANTIDAD") + Me.vDatos.GetRowCellValue(i, "CANTIDAD DEVUELTA") = Me.vDatos.GetRowCellValue(i, "CANTIDAD FACTURADA") Then
        '                        Guardar_Con_Transaccion("sp_DevolucionClienteDetalle_Devuelto", vDatos.GetRowCellValue(i, "NUMERO"), EmpresaActual)
        '                        'GuardaDatosTrans("UPDATE Facturas_Ventas_Lineas SET Devuelto = 1 WHERE NUMERO = " & Me.vDatos.GetRowCellValue(i, "NUMERO"))
        '                    End If
        '                    '**************************************************************************
        '                    '
        '                    DetalleProducto = ArticulosDB.GetDetailsTrans(vDatos.GetRowCellValue(i, "ITEM"), "P", EmpresaActual)

        '                    '' ***********   CUENTAS DE INGRESOS  **************************************************
        '                    Repetido = False
        '                    '
        '                    For c As Integer = 0 To CuentasIngresos.Count - 1
        '                        If DetalleProducto.CDevolucion = CuentasIngresos(c) Then
        '                            MontosIngresos(c) = MontosIngresos(c) + ((vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO")) -
        '                                                                     (vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO") * (Descuento / 100)))
        '                            Repetido = True
        '                        End If
        '                    Next

        '                    If Repetido = False Then
        '                        CuentasIngresos.Add(DetalleProducto.CDevolucion)
        '                        MontosIngresos.Add((vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO")) -
        '                                           (vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO") * (Descuento / 100)))
        '                    End If
        '                    '' ***********   FIN CUENTAS DE INGRESOS  ***********************************************                            
        '                    ' 
        '                    '' ***********  DISTRIBUCION CUENTAS DE INGRESOS  **************************************************
        '                    Dim ExisteCentro As Boolean = False
        '                    Dim Existe As Boolean = False

        '                    For c As Integer = 0 To ArrayCentros.Count - 1
        '                        ' Verifica si existe centro
        '                        If vDatos.GetRowCellValue(i, "CentroID") = ArrayCentros(c) Then
        '                            'If cbCentroCosto.EditValue = ArrayCentros(c) Then
        '                            ExisteCentro = True
        '                            '' Distribucion Ingresos
        '                            For d As Integer = 0 To dtDistribucion.Rows.Count - 1
        '                                If DetalleProducto.CDevolucion = dtDistribucion.Rows(d).Item("Cuenta") And
        '                                 dtDistribucion.Rows(d).Item("IdCentroCosto") = ArrayCentros(c) Then
        '                                    Existe = True
        '                                    dtDistribucion.Rows(d).Item("Valor") = Math.Round(((vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO")) -
        '                                                                                     (vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO") * (Descuento / 100))) +
        '                                                                                      dtDistribucion.Rows(d).Item("Valor"), 2)
        '                                End If
        '                            Next
        '                        End If
        '                    Next

        '                    If ExisteCentro = False Then
        '                        ' Verifica si no existe y lo agrega
        '                        ArrayCentros.Add(Me.vDatos.GetRowCellValue(i, "CentroID"))
        '                        'ArrayCentros.Add(cbCentroCosto.EditValue)
        '                    End If

        '                    ''******************** Agregar Distribucion de Ingresos *********************
        '                    If Existe = False Then

        '                        Dim row As DataRow
        '                        row = dtDistribucion.NewRow()
        '                        '
        '                        Try
        '                            row("IdRubroGasto") = ObtieneDatosTrans("Select Codigo from  RubrosGastos WHERE CuentaContable = '" & DetalleProducto.CDevolucion & "' AND Empresa  =" & EmpresaActual).Rows(0).Item("Codigo")

        '                            row("IdEmpresa") = EmpresaActual
        '                            row("NoComp") = CompNo
        '                            row("Mes") = FechaD.DateTime.Date.Month
        '                            row("Per_Id") = VB.SysContab.PeriodosDB.Activo(FechaD.DateTime.Date)
        '                            row("IdCentroCosto") = vDatos.GetRowCellValue(i, "CentroID")    'cbCentroCosto.EditValue  
        '                            row("Valor") = Math.Round(((vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO")) -
        '                                                    (vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO") * (Descuento / 100))), 2)
        '                            row("Tipo") = "D"
        '                            row("Cuenta") = DetalleProducto.CDevolucion

        '                            dtDistribucion.Rows.Add(row)
        '                        Catch ex As Exception
        '                            VB.SysContab.Rutinas.ErrorTransaccion()
        '                            XtraMsg("La cuenta Contable de Devolución: " & DetalleProducto.CDevolucion & " no se encuentra en rubros de Distribución por favor agreguela para poder contabilizar ", MessageBoxIcon.Warning)
        '                            Exit Sub
        '                        End Try
        '                    End If

        '                    '***********************************************************************************************
        '                    'FIN DE DISTRIBUCION -  CENTRO DE COSTOS
        '                    '***********************************************************************************************

        '                    'DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(vDatos.GetRowCellValue(i, "ITEM"), "P", EmpresaActual)

        '                    TotalCaja = TotalCaja + ((vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO")) -
        '                                           (vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO") * (Descuento / 100)))
        '                    'MontoIVA = MontoIVA + vDatos.GetRowCellValue(i, "IVA")
        '                    'MontoIVA = MontoIVA + (((vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO")) - _
        '                    '                       (vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO") * (Descuento / 100))) * _
        '                    '                       IIf(vDatos.GetRowCellValue(i, "Exento") = False And DetalleCliente.Excento = False, ConfigDetalles.IVA / 100, 0))
        '                    ''IIf(DetallesProducto.Exento, 0, ConfigDetalles.IVA / 100))

        '                    MontoIVA = MontoIVA + (IVAUnidad * vDatos.GetRowCellValue(i, "CANTIDAD"))
        '                End If
        '            Next

        '            '*****************  CONTABILIZANDO DEBITOS ***********************
        '            '*****************************************************************
        '            'Ingresos 
        '            For c As Integer = 0 To CuentasIngresos.Count - 1
        '                Comprobantes.AddComprobanteDetalles(CompNo, CuentasIngresos(c), "Ingreso por Devolucion No. " & Numero,
        '                                          Math.Round(MontosIngresos(c), 2), "0", TipoCOmpr, "D", "0", "0", Me.FechaD.DateTime.Date, 1)
        '            Next
        '            ''Inventario
        '            'For c As Integer = 0 To CuentasIventario.Count - 1
        '            '    Comprobantes.AddComprobanteDetalles(CompNo, CuentasIventario(c), "Cargo al Inventario por Devolucion No. " & Numero, _
        '            '                                MontosIventario(c), "0", TipoCOmpr, "D", "0", "0", Me.FechaD.DateTime.Date, 1)
        '            'Next
        '            'IVA    
        '            If MontoIVA > 0 Then
        '                Comprobantes.AddComprobanteDetalles(CompNo, CuentaIVA, "IVA Por Devolucion No. " & Numero,
        '                                          Math.Round(MontoIVA, 2), "0", TipoCOmpr, "D", "0", "0", Me.FechaD.DateTime.Date, 1)
        '            End If

        '            '*****************  CONTABILIZANDO CREDITO ***********************
        '            '*****************************************************************
        '            'Cajas
        '            Comprobantes.AddComprobanteDetalles(CompNo, ClientesDB.GetDetails(Cliente).Cuenta, "Cuentas x Cobrar Clientes",
        '                                        Math.Round(TotalCaja + MontoIVA, 2), "0", TipoCOmpr, "C", "0", "0", Me.FechaD.DateTime.Date, 1)



        '            'CompNo = Comprobantes.AddComprobante(TipoCOmpr, 1, "Comprobante de Factura No. " & cmbserie.Text & txtFactura.Text, 1, VB.SysContab.PeriodosDB.Activo(fecha.DateTime.Date), fecha.DateTime.Date, _
        '            '    0, "", False, 0, "", 0, cmbserie.Text & txtFactura.Text, VB.SysContab.Rutinas.Fecha, 0, False)

        '            'Dim Prod As Boolean = False
        '            'Dim CostoServicio As Double = 0.0

        '            'For q = 0 To DT_Facturas.Rows.Count - 1

        '            '    If DT_Facturas.Rows(q)("Tipo") = "P" Then
        '            '        MontoCosto = ((CDbl(DT_Facturas.Rows(q).Item("Cantidad"))) * CDbl(DT_Facturas.Rows(q).Item("Costo")))
        '            '        MontoCostoTotal = MontoCosto + MontoCostoTotal
        '            '        Prod = True
        '            '    End If

        '            '    If IsNull(DT_Facturas.Rows(q).Item("Cuenta"), "") = "" Or IsNull(DT_Facturas.Rows(q).Item("Cuenta"), "") = "0" Then
        '            '        MsgBox("El Articulo " & DT_Facturas.Rows(q).Item("Item") & " no tiene cuenta contable asignada.  ")
        '            '        VB.SysContab.Rutinas.ErrorTransaccion()
        '            '        Exit Sub
        '            '    End If
        '            '    'Cargo al inventario
        '            '    If DT_Facturas.Rows(q)("Tipo") = "P" Then Comprobantes.AddComprobanteDetalles(CompNo, DT_Facturas.Rows(q).Item("Cuenta"), "Cargo al Inventario por Fact No. " & cmbserie.Text & Me.txtFactura.Text, _
        '            '                                                                 MontoCosto, 0, TipoCOmpr, "C", cmbserie.Text & Me.txtFactura.Text, 0, fecha.DateTime.Date, 1)
        '            '    If DT_Facturas.Rows(q)("Tipo") = "S" Then
        '            '        Comprobantes.AddComprobanteDetalles(CompNo, DT_Facturas.Rows(q).Item("Cuenta"), "Cargo por Servicio de Fact No. " & cmbserie.Text & Me.txtFactura.Text, _
        '            '        ((CDbl(DT_Facturas.Rows(q).Item("Cantidad"))) * CDbl(DT_Facturas.Rows(q).Item("Precio"))), 0, TipoCOmpr, "C", cmbserie.Text & Me.txtFactura.Text, 0, fecha.DateTime.Date, 1)
        '            '        CostoServicio += ((CDbl(DT_Facturas.Rows(q).Item("Cantidad"))) * CDbl(DT_Facturas.Rows(q).Item("Precio")))
        '            '    End If
        '            'Next
        '            ''Cliente
        '            'Comprobantes.AddComprobanteDetalles(CompNo, ClientesDB.GetDetails(cmbclientes.EditValue).Cuenta, "Por Fact No. " & cmbserie.Text & Me.txtFactura.Text, _
        '            '                                                             lbltotal.Text, 0, TipoCOmpr, "D", cmbserie.Text & Me.txtFactura.Text, 0, fecha.DateTime.Date, 1)
        '            ''Cuenta de Ingresos
        '            'If TipoServicio.EditValue = "P" Or Prod Then Comprobantes.AddComprobanteDetalles(CompNo, CuentaIngr, "Ingreso por Fact No. " & cmbserie.Text & Me.txtFactura.Text, _
        '            '                                                           lblsubtotal.Text - CostoServicio, 0, TipoCOmpr, "C", cmbserie.Text & Me.txtFactura.Text, 0, fecha.DateTime.Date, 1)
        '            '' Para IVA
        '            'If CDbl(IsNull(lbliva.Text, 0)) > 0 Then Comprobantes.AddComprobanteDetalles(CompNo, CuentaIVA, "IVA Por Fact No. " & cmbserie.Text & Me.txtFactura.Text, _
        '            '                                                             lbliva.Text, 0, TipoCOmpr, "C", cmbserie.Text & Me.txtFactura.Text, 0, fecha.DateTime.Date, 1)
        '            '' Solo cuando sea producto o ambos
        '            'If TipoServicio.EditValue = "P" Or Prod Then

        '            '    'Costo de Venta
        '            '    Comprobantes.AddComprobanteDetalles(CompNo, CuentaCosto, "Costo por Fact No. " & cmbserie.Text & Me.txtFactura.Text, _
        '            '    MontoCostoTotal, 0, TipoCOmpr, "D", cmbserie.Text & Me.txtFactura.Text, 0, fecha.DateTime.Date, 1)
        '            'End If
        '        End If
        '    End If
        '    '-------------------------------------------
        '    '------------------------------------------
        '    'Contabilizar
        '    'Buscar el esquema de Nota de Debito
        '    'plan = Plantilla.GetTipoPlantilla(4, 4).ToString

        '    'If plan = "" Or plan Is DBNull.Value Then
        '    '    MsgBox("No hay plantilla disponible para realizar esta transacción", MsgBoxStyle.Information)
        '    '    VB.SysContab.Rutinas.ErrorTransaccion()
        '    '    Exit Sub
        '    'End If

        '    'Dim Detalles As VB.SysContab.PlantillaDetails = Plantilla.GetPlantillasDetails(plan)
        '    'ds = Detalles.Detalles

        '    ''Agregar el encabezado del comprobante
        '    'CompNo = Comprobantes.AddComprobante(Detalles.TipoCompr, 1, _
        '    '        "Comprobante de Devolucion del Cliente #" & Me.Cliente, _
        '    '        EmpresasDB.GetDetails(EmpresaActual).MonedaBase, PeriodosDB.Activo(dtpFecha.DateTime.Date), _
        '    '        Me.dtpFecha.DateTime.Date, 0, "", False, Me.Cliente, "", 0, "D" & Numero, VB.SysContab.Rutinas.Fecha, 0, OrigenComprobantes.DEVOLUCION_CLIENTE)

        '    ''Agregar las lineas de las cuentas de los productos
        '    'Dim SumaMontos As Double
        '    'SumaMontos = 0
        '    'For x = 0 To Cuentas.GetUpperBound(0)
        '    '    If Cuentas(x) <> "" Then
        '    '        SumaMontos += Montos(x)
        '    '        Comprobantes.AddComprobanteDetalles(CompNo, Cuentas(x), "", Montos(x), 0, Detalles.TipoCompr, "D", "D" & Numero, _
        '    '            0, Me.dtpFecha.DateTime.Date, 1)
        '    '    End If
        '    'Next
        '    ''Agregar la linea del IVA
        '    'IVA = Math.Round(SumaMontos * Math.Round(ConfigDetalles.IVA / 100.0, 2), 2)
        '    'Comprobantes.AddComprobanteDetalles(CompNo, ds.Tables("PlantillasDetalles").Rows(0).Item("Cuenta"), _
        '    '    "", IVA, 0, Detalles.TipoCompr, "D", " ", 0, Me.dtpFecha.DateTime.Date, 1)
        '    'If FormaPago.FormaPagoDias(Me.cFormapago) = 0 Then
        '    '    'Se agrega la cuenta del banco
        '    '    Comprobantes.AddComprobanteDetalles(CompNo, ds.Tables("PlantillasDetalles").Rows(1).Item("Cuenta"), _
        '    '        "", SumaMontos + IVA, 0, Detalles.TipoCompr, "C", "", 0, Me.dtpFecha.DateTime.Date, 1)
        '    'Else
        '    '    'Se agrega la cuenta del proveedor
        '    '    Comprobantes.AddComprobanteDetalles(CompNo, DetalleCliente.Cuenta, _
        '    '        "", SumaMontos + IVA, 0, Detalles.TipoCompr, "C", "", 0, Me.dtpFecha.DateTime.Date, 1)
        '    'End If

        '    '----------------------
        '    'Guarda la Distribucion
        '    '----------------------            
        '    GuardaDistribucionTrans(dtDistribucion, FechaD.DateTime.Date, CompNo)

        '    VB.SysContab.Rutinas.okTransaccion()

        '    '****************  Fin de la contabilizacion  *****************************
        'Catch ex As Exception
        '    XtraMsg(ex.Message & " Contabilizar", MessageBoxIcon.Error)
        '    Rutinas.ErrorTransaccion()
        '    Exit Sub
        'End Try
        ''
        ''-----------------------------
        ''Fin de Guarda Distribucion
        ''-----------------------------
        ''GuardaDistribucion(dtDistribucion, FechaD.DateTime.Date, CompNo)
        ''--------------------------
        ''Enviar Alerta por Correo
        ''-------------------------
        'VB.SysContab.DevolucionesClienteDB.EnviarAlertaCorreo(Numero)

        'Try
        '    ''****************   REGISTRAR NOTA DE CREDITO ****************************
        '    Dim Note As String = "NC" + txtReferencia.Text.PadLeft(6, "0"c)
        '    Dim db_Notas As New db_MaestroNotasCD

        '    Dim IdNota As Integer = db_Notas.Guardar(Note, Cliente, FechaD.DateTime.Date, TipoCOmpr,
        '                            TotalCaja + MontoIVA, "Nota de Credito por Devolución #: " & Numero & ", Referencia#: " & txtReferencia.Text,
        '                            1, MonedaBase, CompNo, PeriodosDB.Activo(FechaD.DateTime.Date),
        '                            FechaD.DateTime.Date.Month, FechaD.DateTime.Date, 0,
        '                            IIf(cbTipoNota.EditValue Is Nothing, 0, cbTipoNota.EditValue), "", Numero)

        '    'Detalle
        '    If IdNota > 0 Then db_Notas.GuardarDetalle(IdNota, txtFactura.Text, TotalCaja + MontoIVA, FechaD.DateTime.Date, 0.00)

        '    ''****************   FIN REGISTRO NOTA DE CREDITO ****************************
        '    '
        '    '**************   REGISTRANDO MOVIMIENTO DE INVENTARIO   *********************
        '    Dim Requisa As Integer = db_requisas.Add(EmpresaActual, "E", FechaD.DateTime.Date, vDatos.GetRowCellValue(0, "BODEGA"), Login,
        '                                             txtDevolucion.Text, cbMovimientos.EditValue, txtReferencia.Text,
        '                                             "Nota de Credito por Devolución #: " & Numero & ", Referencia#: " & txtReferencia.Text,
        '                                             "", "", "", "", "", "", Cliente, "", 0, 0, 0, Numero, 0)


        '    For i As Integer = 0 To Me.vDatos.DataRowCount - 1
        '        If vDatos.GetRowCellValue(i, "SELECCIONAR") Then

        '            db_requisas.AddDetalle(EmpresaActual, Requisa, vDatos.GetRowCellValue(i, "ITEM"), "P", vDatos.GetRowCellValue(i, "CANTIDAD"),
        '                                    vDatos.GetRowCellValue(i, "COSTO"), "NC", "", "", "")

        '        End If
        '    Next

        '    'Dim Variables As New ArrayList
        '    'Dim Datos As New ArrayList

        '    'Encabezado
        '    'Variables.Clear()
        '    'Variables.Add("NoNota")
        '    'Variables.Add("IdCliente")
        '    'Variables.Add("Empresa")
        '    'Variables.Add("Fecha")
        '    'Variables.Add("TipoComprobante")
        '    'Variables.Add("Monto")
        '    'Variables.Add("Comentario")
        '    'Variables.Add("Tipo")
        '    'Variables.Add("Anulado")
        '    'Variables.Add("Moneda")
        '    'Variables.Add("Comp_No")
        '    'Variables.Add("Per_Id")
        '    'Variables.Add("Mes")

        '    'Datos.Clear()
        '    'Datos.Add(Note)
        '    'Datos.Add(Cliente)
        '    'Datos.Add(EmpresaActual)
        '    'Datos.Add(FechaD.DateTime.Date)
        '    'Datos.Add(TipoCOmpr)
        '    'Datos.Add(TotalCaja + MontoIVA)
        '    'Datos.Add("Nota de Credito por Devolución #: " & Numero & ", Referencia#: " & txtReferencia.Text)
        '    'Datos.Add(1)        ''Credito
        '    'Datos.Add(0)
        '    'Datos.Add(MonedaBase)
        '    'Datos.Add(CompNo)
        '    'Datos.Add(PeriodosDB.Activo(FechaD.DateTime.Date))
        '    'Datos.Add(FechaD.DateTime.Date.Month)

        '    'Dim IdNota As Integer = ProcedureParameters(Datos, Variables, "SP_GuardaMaestroNotasCD").Rows(0).Item(0)

        '    'Detalle
        '    'Variables.Clear()
        '    'Variables.Add("IdNota")
        '    'Variables.Add("Factura")
        '    'Variables.Add("Monto")
        '    'Variables.Add("Fecha")
        '    'Variables.Add("Empresa")

        '    'Datos.Clear()
        '    'Datos.Add(IdNota)
        '    'Datos.Add(txtFactura.Text)
        '    'Datos.Add(TotalCaja + MontoIVA)
        '    'Datos.Add(FechaD.DateTime.Date)
        '    'Datos.Add(EmpresaActual)
        '    ''
        '    'ProcedureSave(Datos, Variables, "SP_GuardaDetalleNotasCD")

        '    ''Dim Requisa As Integer = 0
        '    'Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
        '    'Conn.IniciarTransaccion()

        '    'Try
        '    '    Requisa = VB.SysContab.RequisasDB.GetCodigoNuevo()
        '    '    'Registrando Entrada
        '    '    'Encabezado
        '    '    Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        '    '    Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
        '    '    Conn.AddParameter("TRequisa", SqlDbType.NVarChar, 5, ParameterDirection.Input, "E")
        '    '    Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, Me.FechaD.DateTime.Date)
        '    '    Conn.AddParameter("Bodega", SqlDbType.NVarChar, 15, ParameterDirection.Input, Me.vDatos.GetRowCellValue(0, "BODEGA"))
        '    '    Conn.AddParameter("RealizadoPor", SqlDbType.NVarChar, 50, ParameterDirection.Input, Login)
        '    '    Conn.AddParameter("Registro", SqlDbType.Bit, 1, ParameterDirection.Input, False)
        '    '    Conn.AddParameter("Factura", SqlDbType.NVarChar, 15, ParameterDirection.Input, txtDevolucion.Text)
        '    '    Conn.AddParameter("Movimiento", SqlDbType.Int, 4, ParameterDirection.Input, Me.cbMovimientos.EditValue)
        '    '    Conn.AddParameter("Referencia", SqlDbType.NVarChar, 100, ParameterDirection.Input, Me.txtReferencia.Text)
        '    '    Conn.AddParameter("Concepto", SqlDbType.NVarChar, 2048, ParameterDirection.Input, "Nota de Credito por Devolución #: " & Numero & ", Referencia#: " & txtReferencia.Text)
        '    '    Conn.AddParameter("Transporte", SqlDbType.NVarChar, 512, ParameterDirection.Input, "")
        '    '    Conn.AddParameter("NoPlaca", SqlDbType.NVarChar, 100, ParameterDirection.Input, "")
        '    '    Conn.AddParameter("Conductor", SqlDbType.NVarChar, 512, ParameterDirection.Input, "")
        '    '    Conn.AddParameter("Remision", SqlDbType.NVarChar, 50, ParameterDirection.Input, "")
        '    '    Conn.AddParameter("OT_Matriz", SqlDbType.NVarChar, 50, ParameterDirection.Input, "")
        '    '    Conn.AddParameter("OT_Suc", SqlDbType.NVarChar, 50, ParameterDirection.Input, "")
        '    '    Conn.AddParameter("IdCliente", SqlDbType.Int, 5, ParameterDirection.Input, Cliente)
        '    '    Conn.AddParameter("NoPoliza", SqlDbType.NVarChar, 50, ParameterDirection.Input, "")
        '    '    Conn.AddParameter("IdProyecto", SqlDbType.Int, 5, ParameterDirection.Input, 0)
        '    '    Conn.AddParameter("IdOrden", SqlDbType.Int, 5, ParameterDirection.Input, 0)
        '    '    Conn.AddParameter("IdProveedor", SqlDbType.Int, 5, ParameterDirection.Input, 0)
        '    '    Conn.AddParameter("NoDevolucion", SqlDbType.Int, 5, ParameterDirection.Input, txtDevolucion.Text)

        '    '    Conn.EjecutarComando("SP_Requisas_Add")

        '    '    For i As Integer = 0 To Me.vDatos.DataRowCount - 1
        '    '        If Me.vDatos.GetRowCellValue(i, "SELECCIONAR") Then
        '    '            'Devolucion.AddItemDetalle(Numero, Me.vDatos.GetRowCellValue(i, "ITEM"), "P", Me.vDatos.GetRowCellValue(i, "CANTIDAD"), Me.vDatos.GetRowCellValue(i, "IVA"))
        '    '            'If Me.vDatos.GetRowCellValue(i, "CANTIDAD") + Me.vDatos.GetRowCellValue(i, "CANTIDAD DEVUELTA") = Me.vDatos.GetRowCellValue(i, "CANTIDAD FACTURADA") Then
        '    '            '    GuardaDatosTrans("UPDATE Facturas_Ventas_Lineas SET Devuelto = 1 WHERE NUMERO = " & Me.vDatos.GetRowCellValue(i, "NUMERO"))
        '    '            'End If
        '    '            'Agregar el detalle de la requisa
        '    '            'Conn.RemoveParameters()
        '    '            'Conn.AddParameter("Articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, vDatos.GetRowCellValue(i, "ITEM"))
        '    '            'Conn.AddParameter("Tipo", SqlDbType.NVarChar, 10, ParameterDirection.Input, "P")
        '    '            'Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
        '    '            'Dim DT_PROD As DataTable = Conn.EjecutarComando("JAR_GetCuentasProducto")

        '    '            Conn.RemoveParameters()
        '    '            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        '    '            Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
        '    '            Conn.AddParameter("Articulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, vDatos.GetRowCellValue(i, "ITEM"))
        '    '            Conn.AddParameter("TArticulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, "P")
        '    '            Conn.AddParameter("Cantidad", SqlDbType.Decimal, 20, ParameterDirection.Input, vDatos.GetRowCellValue(i, "CANTIDAD"))
        '    '            Conn.AddParameter("Precio", SqlDbType.Decimal, 20, ParameterDirection.Input, vDatos.GetRowCellValue(i, "COSTO"))
        '    '            Conn.AddParameter("Cuenta", SqlDbType.NVarChar, 20, ParameterDirection.Input, "NC")  '' DT_PROD.Rows.Item(0)("CUENTA_COSTO"))

        '    '            Conn.EjecutarComando("SP_Requisas_Detalle_Add")
        '    '            '
        '    '        End If
        '    '    Next

        '    'Conn.CompletarTransaccion()
        '    XtraMsg("Devolución realizada Exitosamente !!!", MessageBoxIcon.Information)

        '    ''Imprimir el Comprobante Contable de la Devolución
        '    ComprobanteDB.ImprimirComprobante(CompNo, PeriodosDB.Activo(Me.FechaD.DateTime.Date), FechaD.DateTime.Date)
        '    'ImprimirComprobante(CompNo, PeriodosDB.Activo(Me.FechaD.DateTime.Date))

        '    'Actualizar Lista de Devoluciones
        '    Dim f As frmDevolucionesClienteList = frmDevolucionesClienteList.Instance()
        '    If f.Created Then f.Cargar()

        '    Close()
        'Catch ex As Exception
        '    XtraMsg(ex.Message & " Guardar N/C", MessageBoxIcon.Error)
        ''Conn.AnularTransaccion()
        'End Try

    End Sub

    'Sub ImprimirComprobante(Comp_No As Double, Per_Id As Integer)

    '    Dim Cadena As String
    '    Dim Temp As Boolean = False
    '    Dim Data() As Byte

    '    Try
    '        Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 17 AND Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())

    '        Temp = True
    '        Dim Tamano As Integer
    '        Tamano = Data.GetUpperBound(0)
    '        Cadena = Application.StartupPath & "\rptComprobante.repx"

    '        If File.Exists(Cadena) Then Kill(Cadena)
    '        Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
    '        Archivo.Write(Data, 0, Tamano)
    '        Archivo.Close()
    '    Catch ex As Exception
    '        Temp = False
    '    End Try

    '    Dim DSComp As New DataSet

    '    Dim DA As New SqlDataAdapter("_ComprobantesImpresoALL", VB.SysContab.Rutinas.AbrirConexion)
    '    DA.SelectCommand.CommandType = CommandType.StoredProcedure

    '    DA.SelectCommand.Parameters.Add("@ComprNO", SqlDbType.NChar)
    '    DA.SelectCommand.Parameters.Add("@Empresa", SqlDbType.Int)
    '    DA.SelectCommand.Parameters.Add("@PerID", SqlDbType.Int)
    '    DA.SelectCommand.Parameters.Add("@Fecha", SqlDbType.DateTime)

    '    DA.SelectCommand.Parameters("@Empresa").Value = EmpresaActual
    '    DA.SelectCommand.Parameters("@ComprNO").Value = Comp_No
    '    DA.SelectCommand.Parameters("@PerID").Value = Per_Id
    '    DA.SelectCommand.Parameters("@Fecha").Value = FechaD.DateTime.Date

    '    DA.Fill(DSComp, "Comprobantes")

    '    Dim DTDistrubucion As DataTable = ObtieneDatos("JAR_GetComprobanteDistribucion " & Comp_No & "," & _
    '                                                  "" & Per_Id & "," & _
    '                                                  "" & FechaD.DateTime.Date.Month & "," & EmpresaActual)
    '    Dim rptDistribucin As New rptComprobanteDistribucion
    '    rptDistribucin.DataSource = DTDistrubucion

    '    Dim rpt As rptComprobantesALL

    '    If Temp = True Then
    '        rpt = XtraReport.FromFile(Application.StartupPath & "\rptComprobante.repx", True)
    '    Else
    '        rpt = New rptComprobantesALL
    '    End If

    '    rpt.ver = True
    '    rpt.XrSubreport1.ReportSource = rptDistribucin
    '    rpt.gfDistribucion.Visible = True
    '    rpt.DataSource = DSComp.Tables(0)
    '    rpt.ShowRibbonPreview()
    'End Sub

    'Sub ImprimirComprobante(ByVal Numero As Integer, ByVal Periodo As Integer)
    '    Dim DSComp As New DataSet

    '    Dim DA As New SqlDataAdapter("_ComprobantesImpresoALL", VB.SysContab.Rutinas.AbrirConexion)
    '    DA.SelectCommand.CommandType = CommandType.StoredProcedure

    '    DA.SelectCommand.Parameters.Add("@ComprNO", SqlDbType.NChar)
    '    DA.SelectCommand.Parameters.Add("@Empresa", SqlDbType.Int)
    '    DA.SelectCommand.Parameters.Add("@PerID", SqlDbType.Int)
    '    DA.SelectCommand.Parameters.Add("@Fecha", SqlDbType.DateTime)

    '    DA.SelectCommand.Parameters("@Empresa").Value = EmpresaActual
    '    DA.SelectCommand.Parameters("@ComprNO").Value = Numero
    '    DA.SelectCommand.Parameters("@PerID").Value = Periodo
    '    DA.SelectCommand.Parameters("@Fecha").Value = Me.FechaD.DateTime.Date

    '    DA.Fill(DSComp, "Comprobantes")

    '    'DSComp.WriteXml(Application.StartupPath & "\xml\rptComprobantesAll.xml", XmlWriteMode.WriteSchema)
    '    'rpt.XmlDataPath = Application.StartupPath & "\xml\rptComprobantesAll.xml"

    '    Dim rpt As New rptComprobantesALL
    '    rpt.ver = True
    '    rpt.DataSource = DSComp.Tables(0)
    '    rpt.ShowRibbonPreview()
    'End Sub

    Private Sub dgFacturacionCliente_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'Try
        '    If Me.dgFacturacionCliente.CurrentRowIndex = tCust.Rows.Count Then
        '        Me.dgFacturacionCliente.ReadOnly = True
        '        Exit Sub
        '    Else
        '        Me.dgFacturacionCliente.ReadOnly = False
        '    End If

        '    ValorActualCantidad = tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Cantidad")
        '    ValorActualPrecio = tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Precio")
        '    ValorActualDescuento = tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Descuento")

        'Catch ex As Exception
        '    'MsgBox(ex.Message)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub cbTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTodos.CheckedChanged
        If Me.cbTodos.Checked = True Then
            For i = 0 To tCust.Rows.Count - 1
                tCust.Rows(i)("Agregar") = True
            Next
        Else
            For i = 0 To tCust.Rows.Count - 1
                tCust.Rows(i)("Agregar") = False
            Next
        End If
    End Sub

    Private Sub frmDevolucionCliente_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim f As frmDevolucionesFacturas = f.Instance
        f.etInicio.Text = "0"
    End Sub

    'Private Sub tCust_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles tCust.ColumnChanged
    '    Dim Descuento As Double

    '    If e.Column.Ordinal = 2 Or e.Column.Ordinal = 3 Or e.Column.Ordinal = 4 Then

    '        If Not IsNumeric(e.Row.Item(2)) Then
    '            e.Row.Item(2) = ValorActualCantidad
    '        Else
    '            If e.Row.Item(2) > e.Row.Item(11) And Not Llenando Then
    '                MsgBox("No se puede devolver más de " & e.Row.Item(11) & " unidades del producto", MsgBoxStyle.Critical, "STS-Contab")
    '                e.Row.Item(2) = e.Row.Item(11)
    '            End If
    '        End If

    '        If Not IsNumeric(e.Row.Item(3)) Then
    '            e.Row.Item(3) = ValorActualPrecio.ToString(Round)
    '        End If

    '        If Not IsNumeric(e.Row.Item(4)) Then
    '            e.Row.Item(4) = ValorActualDescuento.ToString(Round)
    '        End If


    '        If e.Row.Item(2) Is DBNull.Value Or e.Row.Item(3) Is DBNull.Value Then

    '        Else
    '            If e.Row.Item(4) Is DBNull.Value Then
    '                If IsNumeric(e.Row.Item(2)) And IsNumeric(e.Row.Item(3)) Then
    '                    e.Row.Item(5) = CDbl(CDbl(e.Row.Item(2)) * CDbl(e.Row.Item(3))).ToString(Round)
    '                End If

    '            Else
    '                If IsNumeric(e.Row.Item(2)) And IsNumeric(e.Row.Item(3)) And IsNumeric(e.Row.Item(4)) Then
    '                    Descuento = (CDbl(e.Row.Item(4)) * CDbl(e.Row.Item(2)) * CDbl(e.Row.Item(3))) / 100.0
    '                    e.Row.Item(5) = CDbl(CDbl(e.Row.Item(2)) * CDbl(e.Row.Item(3)) - Descuento).ToString(Round)
    '                End If


    '            End If

    '        End If

    '    End If

    '    SubTotalFacturaCliente = 0
    '    SubTotalFacturaNoDescuentos = 0
    '    TotalFacturaCliente = 0
    '    TotalDescuento = 0

    '    For i = 0 To tCust.Rows.Count - 1

    '        If tCust.Rows(i)("SubTotal") Is DBNull.Value Or tCust.Rows(i)("SubTotal").ToString = "" Or tCust.Rows(i)("SubTotal").ToString = "0.00" Then

    '        ElseIf IsNumeric(tCust.Rows(i)("SubTotal")) And tCust.Rows(i)("SubTotal").ToString <> "" Then
    '            Try
    '                SubTotalFacturaCliente = SubTotalFacturaCliente + tCust.Rows(i)("SubTotal")
    '                SubTotalFacturaNoDescuentos = SubTotalFacturaNoDescuentos + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio"))
    '                TotalDescuento = TotalDescuento + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio") * tCust.Rows(i)("Descuento") / 100.0)
    '            Catch ex As Exception
    '                MsgBox(ex.Message)

    '            End Try

    '        End If

    '    Next


    '    etSubTotal.Text = SubTotalFacturaNoDescuentos.ToString(Round)
    '    etIva.Text = (SubTotalFacturaNoDescuentos * (ConfigDetalles.IVA / 100.0)).ToString(Round)
    '    etTotal.Text = (SubTotalFacturaCliente + CDbl(etIva.Text)).ToString(Round)
    '    TotalFactura = etTotal.Text
    'End Sub

    'Private Sub vDatos_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles vDatos.InvalidRowException
    '    'e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    '    'e.ErrorText = "El Valor Digitado es Inválido"
    '    'XtraMsg(e.ErrorText, MessageBoxIcon.Error)
    '    ''Show the message with the error text specified 
    '    ''If DevExpress.XtraEditors.XtraMessageBox.Show(e.ErrorText, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
    '    ''End If
    'End Sub

    Private Sub vDatos_RowCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles vDatos.RowCellStyle
        If e.Column.FieldName = "CANTIDAD" Then
            If vDatos.GetRowCellValue(e.RowHandle, "CANTIDAD") = 0.00 Then
                e.Appearance.BackColor = Color.Salmon
            End If
        End If
    End Sub

    Private Sub vDatos_ShowingEditor(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles vDatos.ShowingEditor
        If vDatos.GetRowCellValue(vDatos.FocusedRowHandle, "CANTIDAD") = 0 Then e.Cancel = True
        Totales()
    End Sub

    Private Sub vDatos_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles vDatos.ValidateRow
        If vDatos.GetRowCellValue(e.RowHandle, "CANTIDAD") <= 0 Then
            e.Valid = False
            e.ErrorText = "Digite un Valor mayor que Cero (0)" & vbCrLf
        End If
        '
        If vDatos.GetRowCellValue(e.RowHandle, "CANTIDAD") > (vDatos.GetRowCellValue(e.RowHandle, "CANTIDAD FACTURADA") - vDatos.GetRowCellValue(e.RowHandle, "CANTIDAD DEVUELTA")) Then
            e.Valid = False
            e.ErrorText = "La Cantida a Devolver debe ser menor o igual a la Cantidad Facturada" & vbCrLf
        End If
        Totales()
    End Sub

    Sub Totales()
        vDatos.RefreshData()
        vDatos.UpdateTotalSummary()

        Dim Total As Double = 0.00
        Dim Iva As Double = 0.00
        Dim TCambio As Double = 1.0

        For i As Integer = 0 To vDatos.DataRowCount - 1
            If vDatos.GetRowCellValue(i, "SELECCIONAR") Then
                Iva += (((vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO")) -
                    ((vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO")) *
                    (vDatos.GetRowCellValue(i, "DESCUENTO") / 100.0))) * vDatos.GetRowCellValue(i, "IvaP"))


                Total += ((vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO")) -
                    ((vDatos.GetRowCellValue(i, "CANTIDAD") * vDatos.GetRowCellValue(i, "PRECIO")) *
                    (vDatos.GetRowCellValue(i, "DESCUENTO") / 100.0)))

                TCambio = vDatos.GetRowCellValue(i, "TCambio")
            End If
        Next
        '
        txtTotal.EditValue = Total + Iva
        txtTotalU.EditValue = (Total + Iva) / TCambio
    End Sub

    Private Sub vDatos_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles vDatos.ValidatingEditor
        'Dim View As GridView = sender
        'If View.FocusedColumn.FieldName = "CANTIDAD" Then
        '    If View.GetFocusedRowCellValue("CANTIDAD") <= 0 Then
        '        e.Valid = False
        '        e.ErrorText = "Digite un Valor mayor que cero"
        '        Exit Sub
        '    End If
        '    '
        '    If View.GetFocusedRowCellValue("CANTIDAD") > View.GetFocusedRowCellValue("CANTIDAD FACTURADA") Then
        '        e.Valid = False
        '        e.ErrorText = "La Cantida a Devolver debe ser menor o igual a la Cantidad Facturada"
        '        Exit Sub
        '    End If
        'End If
    End Sub

    Private Sub vDatos_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles vDatos.InvalidValueException
        'e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
        'XtraMsg(e.ErrorText, MessageBoxIcon.Error)
    End Sub

    Private Sub FechaD_EditValueChanged(sender As Object, e As EventArgs) Handles FechaD.EditValueChanged
        txtTCambio.EditValue = GetTasaCambioDia(IsNull(FechaD.DateTime.Date, Now.Date))
    End Sub

    'Public Shared Sub GuardarDistribucion(ByVal DT_Distribucion As DataTable, ByVal Fecha As Date, Optional ByVal Comprobante As String = vbNullString)
    '    Dim i As Integer
    '    Dim DT_F As DataTable
    '    DT_F = DT_Distribucion
    '    If Not DT_F Is Nothing Then
    '        For i = 0 To DT_F.Rows.Count - 1
    '            With DT_F
    '                GuardaDatos("INSERT INTO Distribucion(IdEmpresa,NoComp,Mes,Per_Id,IdRubroGasto,IdCentroCosto,Valor,Tipo,Cuenta) " & _
    '                 " VALUES(" & EmpresaActual & "," & Comprobante & "," & Fecha.Month & "," & _
    '                VB.SysContab.PeriodosDB.Activo(Fecha.Date) & "," & .Rows(i).Item("IdRubroGasto") & "," & .Rows(i).Item("IdCentroCosto") & "," & Math.Round(.Rows(i).Item("Valor"), 2) & ",'" & .Rows(i).Item("Tipo") & "','" & .Rows(i).Item("Cuenta") & "')")
    '            End With
    '        Next
    '    End If
    'End Sub


End Class

'End Namespace
