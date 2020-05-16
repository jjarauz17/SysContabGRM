Public Class frmHistorialCobros
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmHistorialCobros = Nothing

    Public Shared Function Instance() As frmHistorialCobros
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmHistorialCobros()
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
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents iGrid2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFecha As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFactura As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbTodos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistorialCobros))
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cbTodos = New DevExpress.XtraEditors.CheckEdit()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.iGrid2 = New DevExpress.XtraGrid.GridControl()
        Me.iVista2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit()
        Me.txtFecha = New DevExpress.XtraEditors.TextEdit()
        Me.txtFactura = New DevExpress.XtraEditors.TextEdit()
        Me.txtCliente = New DevExpress.XtraEditors.TextEdit()
        Me.iGrid = New DevExpress.XtraGrid.GridControl()
        Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cbTodos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.ImageOptions.Image = CType(resources.GetObject("cmdSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(815, 529)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(109, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl1
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cbTodos)
        Me.LayoutControl1.Controls.Add(Me.cmdSalir)
        Me.LayoutControl1.Controls.Add(Me.cmdImprimir)
        Me.LayoutControl1.Controls.Add(Me.iGrid2)
        Me.LayoutControl1.Controls.Add(Me.txtTotal)
        Me.LayoutControl1.Controls.Add(Me.txtFecha)
        Me.LayoutControl1.Controls.Add(Me.txtFactura)
        Me.LayoutControl1.Controls.Add(Me.txtCliente)
        Me.LayoutControl1.Controls.Add(Me.iGrid)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(984, 175, 355, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(936, 579)
        Me.LayoutControl1.TabIndex = 179
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cbTodos
        '
        Me.cbTodos.Location = New System.Drawing.Point(815, 151)
        Me.cbTodos.Name = "cbTodos"
        Me.cbTodos.Properties.Caption = "Marcar Todo"
        Me.cbTodos.Size = New System.Drawing.Size(109, 19)
        Me.cbTodos.StyleController = Me.LayoutControl1
        Me.cbTodos.TabIndex = 183
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdImprimir.ImageOptions.Image = CType(resources.GetObject("cmdImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdImprimir.Location = New System.Drawing.Point(705, 529)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(106, 38)
        Me.cmdImprimir.StyleController = Me.LayoutControl1
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'iGrid2
        '
        Me.iGrid2.Location = New System.Drawing.Point(12, 310)
        Me.iGrid2.MainView = Me.iVista2
        Me.iGrid2.Name = "iGrid2"
        Me.iGrid2.Size = New System.Drawing.Size(912, 215)
        Me.iGrid2.TabIndex = 181
        Me.iGrid2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista2})
        '
        'iVista2
        '
        Me.iVista2.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iVista2.Appearance.HeaderPanel.Options.UseFont = True
        Me.iVista2.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.iVista2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.iVista2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18})
        Me.iVista2.GridControl = Me.iGrid2
        Me.iVista2.Name = "iVista2"
        Me.iVista2.NewItemRowText = "Agregar Nuevo Correo!"
        Me.iVista2.OptionsBehavior.Editable = False
        Me.iVista2.OptionsView.ShowAutoFilterRow = True
        Me.iVista2.OptionsView.ShowFooter = True
        Me.iVista2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Documento"
        Me.GridColumn6.FieldName = "Transaccion/Recibo"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Tipo Pago"
        Me.GridColumn7.FieldName = "Tipo Pago"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "No Cheque"
        Me.GridColumn8.FieldName = "No Cheque"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 2
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Banco"
        Me.GridColumn9.FieldName = "Banco"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 3
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Cuenta"
        Me.GridColumn10.FieldName = "Cuenta"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 4
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Tipo Tarjeta"
        Me.GridColumn11.FieldName = "Tipo Tarjeta"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 5
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Emisor"
        Me.GridColumn12.FieldName = "Emisor"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 6
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "No Tarjeta"
        Me.GridColumn13.FieldName = "No Tarjeta"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 7
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Efectivo"
        Me.GridColumn14.FieldName = "Efectivo"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 8
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Monto Cheque"
        Me.GridColumn15.FieldName = "Monto Cheque"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 9
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Monto Tarjeta"
        Me.GridColumn16.FieldName = "Monto Tarjeta"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 10
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Nota Debito"
        Me.GridColumn17.FieldName = "Nota Debito"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 11
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Moneda"
        Me.GridColumn18.FieldName = "Moneda"
        Me.GridColumn18.Name = "GridColumn18"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(581, 115)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotal.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtTotal.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotal.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTotal.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTotal.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtTotal.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotal.Properties.Mask.EditMask = "n2"
        Me.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotal.Properties.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(331, 20)
        Me.txtTotal.StyleController = Me.LayoutControl1
        Me.txtTotal.TabIndex = 182
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(581, 91)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFecha.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtFecha.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtFecha.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtFecha.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtFecha.Properties.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(331, 20)
        Me.txtFecha.StyleController = Me.LayoutControl1
        Me.txtFecha.TabIndex = 182
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(581, 67)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFactura.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactura.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtFactura.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtFactura.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtFactura.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtFactura.Properties.ReadOnly = True
        Me.txtFactura.Size = New System.Drawing.Size(331, 20)
        Me.txtFactura.StyleController = Me.LayoutControl1
        Me.txtFactura.TabIndex = 182
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(581, 43)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCliente.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtCliente.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCliente.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtCliente.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCliente.Properties.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(331, 20)
        Me.txtCliente.StyleController = Me.LayoutControl1
        Me.txtCliente.TabIndex = 181
        '
        'iGrid
        '
        Me.iGrid.Location = New System.Drawing.Point(12, 29)
        Me.iGrid.MainView = Me.iVista
        Me.iGrid.Name = "iGrid"
        Me.iGrid.Size = New System.Drawing.Size(445, 245)
        Me.iGrid.TabIndex = 180
        Me.iGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista})
        '
        'iVista
        '
        Me.iVista.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iVista.Appearance.HeaderPanel.Options.UseFont = True
        Me.iVista.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.iVista.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.iVista.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn19})
        Me.iVista.GridControl = Me.iGrid
        Me.iVista.Name = "iVista"
        Me.iVista.NewItemRowText = "Agregar Nuevo Correo!"
        Me.iVista.OptionsBehavior.Editable = False
        Me.iVista.OptionsView.ShowAutoFilterRow = True
        Me.iVista.OptionsView.ShowFooter = True
        Me.iVista.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Documento"
        Me.GridColumn1.FieldName = "Transaccion/Recibo"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Fecha"
        Me.GridColumn2.FieldName = "Fecha"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Fecha Pago"
        Me.GridColumn3.FieldName = "FechaCobro"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Monto"
        Me.GridColumn4.FieldName = "Total"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Cobro"
        Me.GridColumn5.FieldName = "Cobro"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Transaccion"
        Me.GridColumn19.FieldName = "Transaccion"
        Me.GridColumn19.Name = "GridColumn19"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem6, Me.LayoutControlGroup2, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.EmptySpaceItem5, Me.LayoutControlItem7, Me.EmptySpaceItem3, Me.SplitterItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(936, 579)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem1.Control = Me.iGrid
        Me.LayoutControlItem1.CustomizationFormText = "Pagos del Cliente"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(449, 266)
        Me.LayoutControlItem1.Text = "Pagos del Cliente"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(105, 14)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem6.Control = Me.iGrid2
        Me.LayoutControlItem6.CustomizationFormText = "Detalle de Pagos"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 281)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(916, 236)
        Me.LayoutControlItem6.Text = "Detalle de Pagos"
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(105, 14)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup2.AppearanceGroup.ForeColor = System.Drawing.Color.Red
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup2.CustomizationFormText = "Datos de Factura"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(449, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(467, 139)
        Me.LayoutControlGroup2.Text = "Datos de Factura"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtCliente
        Me.LayoutControlItem2.CustomizationFormText = "Cliente:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(443, 24)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(443, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(443, 24)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Cliente:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(105, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtFactura
        Me.LayoutControlItem3.CustomizationFormText = "#Factura:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(443, 24)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(443, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(443, 24)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "#Factura:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(105, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtFecha
        Me.LayoutControlItem4.CustomizationFormText = "Fecha:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(443, 24)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(443, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(443, 24)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "Fecha:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(105, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtTotal
        Me.LayoutControlItem5.CustomizationFormText = "Total Factura:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(443, 24)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(443, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(443, 24)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "Total Factura:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(105, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmdImprimir
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(693, 517)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmdSalir
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(803, 517)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 517)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(693, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 271)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(916, 10)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(449, 162)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(467, 104)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cbTodos
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(803, 139)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(113, 23)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(113, 23)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(113, 23)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(449, 139)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(354, 23)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'SplitterItem1
        '
        Me.SplitterItem1.AllowHotTrack = True
        Me.SplitterItem1.Location = New System.Drawing.Point(0, 266)
        Me.SplitterItem1.Name = "SplitterItem1"
        Me.SplitterItem1.Size = New System.Drawing.Size(916, 5)
        '
        'frmHistorialCobros
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(936, 579)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmHistorialCobros"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cbTodos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Clientes As New VB.SysContab.ClientesDB()
    Dim r As New VB.SysContab.Rutinas()

    Private Sub frmHistorialCobros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Tabla As DataTable
        Dim ds As DataSet

        ' r.FormularioColor(Me)

        ds = Clientes.CobrosHistorial(Registro)

        If ds.Tables("Cobros").Rows.Count = 0 Then
            Exit Sub
        End If

        txtCliente.Text = ds.Tables("Cobros").Rows(0).Item("Nombre")
        txtFactura.Text = ds.Tables("Cobros").Rows(0).Item("Factura")
        txtTotal.Text = ds.Tables("Cobros").Rows(0).Item("Total")
        txtFecha.Text = CDate(ds.Tables("Cobros").Rows(0).Item("Fecha")).Date

        txtCliente.Refresh()
        txtFactura.Refresh()
        txtTotal.Refresh()
        txtFecha.Refresh()

        iGrid.DataSource = ds.Tables("Cobros").DefaultView
        FormatoGrid(iVista, 2, 0, False, False)


        'dgCobrosHistorial.DataSource = ds.Tables("Cobros").DefaultView
        'Tabla = ds.Tables("Cobros")

        'r.FormatGenerico(dgCobrosHistorial, Tabla)

        'dgCobrosHistorial.CaptionText = "Pagos de Clientes"

        'ds = Clientes.CobrosXRecibo(dgCobrosHistorial.Item(0, 8), txtFactura.Text)
        ds = Clientes.CobrosXRecibo(iVista.GetRowCellValue(0, "Transaccion"), txtFactura.Text)

        'dgPagosXRecibo.DataSource = ds.Tables("Cobros").DefaultView
        'Tabla = ds.Tables("Cobros")

        'r.FormatGenerico(dgPagosXRecibo, Tabla)

        iGrid2.DataSource = ds.Tables("Cobros").DefaultView
        FormatoGrid(iVista2, 2, 0, False, False)

        'Dim i As Integer
        'For i = 0 To ds.Tables("Cobros").Rows.Count - 1
        'Next

        cbTodos.Checked = True

        '   dgPagosXRecibo.CaptionText = "Detalle de Pagos"

        Me.Text = "Historial de Pagos de Clientes"
        Me.Refresh()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Registro = "Vacio"
        Me.Close()
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim fReportes As New frmReportes
        'Dim rHistorial As New rptCobrosHistorial
        Dim rHistorial As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rHistorial.Load(Application.StartupPath & "\Reportes\rptCobrosHistorial.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
        '
        Dim Clientes As New VB.SysContab.ClientesDB
        Dim ds As DataSet
        ds = Clientes.CobrosHistorial(txtFactura.Text)
        ds.WriteXml(Application.StartupPath & "\xml\rptHistorialCobro.xml", XmlWriteMode.WriteSchema)
        rHistorial.Database.Tables(0).Location = Application.StartupPath & "\xml\rptHistorialCobro.xml"
        fReportes.crvReportes.ReportSource = rHistorial
        fReportes.ShowDialog()
    End Sub

    'Private Sub dgCobrosHistorial_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Dim Tabla As DataTable
    '    Dim ds As DataSet

    '    ds = Clientes.CobrosXRecibo(dgCobrosHistorial.Item(dgCobrosHistorial.CurrentRowIndex, 8), txtFactura.Text)
    '    dgPagosXRecibo.DataSource = ds.Tables("Cobros").DefaultView

    '    Tabla = ds.Tables("Cobros")

    '    r.FormatGenerico(dgPagosXRecibo, Tabla)

    '    If cbTodos.Checked = True Then
    '        cbTodos.Checked = False
    '    End If

    'End Sub

    'Private Sub dgCobrosHistorial_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Dim Tabla As DataTable
    '    Dim ds As DataSet

    '    ds = Clientes.CobrosXRecibo(dgCobrosHistorial.Item(dgCobrosHistorial.CurrentRowIndex, 8), txtFactura.Text)

    '    dgPagosXRecibo.DataSource = ds.Tables("Cobros").DefaultView

    '    Tabla = ds.Tables("Cobros")

    '    r.FormatGenerico(dgPagosXRecibo, Tabla)

    '    If cbTodos.Checked = True Then
    '        cbTodos.Checked = False
    '    End If

    'End Sub

    Private Sub cbTodos_CheckedChanged_1(sender As Object, e As EventArgs) Handles cbTodos.CheckedChanged
        Dim ds As DataSet

        If cbTodos.Checked = True Then
            ds = Clientes.CobrosXFacturaAll(txtFactura.Text)
        Else
            ds = Clientes.CobrosXRecibo(iVista.GetRowCellValue(iVista.FocusedRowHandle, "Transaccion"), txtFactura.Text)
        End If
        iGrid2.DataSource = ds.Tables("Cobros").DefaultView
    End Sub

    Private Sub iVista_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles iVista.FocusedRowChanged
        If e.FocusedRowHandle < 0 Then Exit Sub
        '
        Dim ds As DataSet
        ds = Clientes.CobrosXRecibo(iVista.GetRowCellValue(e.FocusedRowHandle, "Transaccion"), txtFactura.Text)
        iGrid2.DataSource = ds.Tables("Cobros").DefaultView
    End Sub

    Private Sub iVista_Click(sender As Object, e As EventArgs) Handles iVista.Click
        If iVista.FocusedRowHandle < 0 Then Exit Sub
        '
        Dim ds As DataSet
        ds = Clientes.CobrosXRecibo(iVista.GetRowCellValue(iVista.FocusedRowHandle, "Transaccion"), txtFactura.Text)
        iGrid2.DataSource = ds.Tables("Cobros").DefaultView
    End Sub

    Private Sub iGrid2_Click(sender As Object, e As EventArgs) Handles iGrid2.Click

    End Sub
End Class
