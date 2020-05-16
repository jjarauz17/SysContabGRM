Imports System.Data.SqlClient

Public Class FrmOrdenesNew
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As FrmOrdenesNew = Nothing

    Public Shared Function Instance() As FrmOrdenesNew
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmOrdenesNew
        End If
        ChildInstance.BringToFront()

        Return ChildInstance

    End Function

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemArticulo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemArticuloD As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbclientes As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GridDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtdescuentos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtdescuentop As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TipoServicio As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtdireccion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cmbmoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtruc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtpais As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtdepto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtvendedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtmunicipio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txttelefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbformapago As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents lbliva As System.Windows.Forms.Label
    Friend WithEvents lblsubtotal As System.Windows.Forms.Label
    Friend WithEvents txtCaja As DevExpress.XtraEditors.TextEdit
    Friend WithEvents fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents FechaPago As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtfactura As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gbBotones As System.Windows.Forms.GroupBox
    Friend WithEvents cmdConsultaClientes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdConsulta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents etTasa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents cbBodegas As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtDirEntrega As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtPrecioC As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtPrecioU As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rgTipoO As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents cmbcentrocosto As DevExpress.XtraEditors.LookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtPrecioC = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemArticulo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemArticuloD = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtPrecioU = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridDetalle = New DevExpress.XtraGrid.GridControl()
        Me.cmbclientes = New DevExpress.XtraEditors.LookUpEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbBodegas = New DevExpress.XtraEditors.LookUpEdit()
        Me.etTasa = New DevExpress.XtraEditors.TextEdit()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.gbBotones = New System.Windows.Forms.GroupBox()
        Me.cmdConsultaClientes = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdConsulta = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtdescuentos = New DevExpress.XtraEditors.TextEdit()
        Me.txtdescuentop = New DevExpress.XtraEditors.TextEdit()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TipoServicio = New DevExpress.XtraEditors.RadioGroup()
        Me.txtdireccion = New DevExpress.XtraEditors.MemoEdit()
        Me.cmbmoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtruc = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpais = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdepto = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtvendedor = New DevExpress.XtraEditors.TextEdit()
        Me.txtmunicipio = New DevExpress.XtraEditors.TextEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txttelefono = New DevExpress.XtraEditors.TextEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbformapago = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lbliva = New System.Windows.Forms.Label()
        Me.lblsubtotal = New System.Windows.Forms.Label()
        Me.txtCaja = New DevExpress.XtraEditors.TextEdit()
        Me.cmbcentrocosto = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.fecha = New DevExpress.XtraEditors.DateEdit()
        Me.FechaPago = New DevExpress.XtraEditors.DateEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtfactura = New DevExpress.XtraEditors.TextEdit()
        Me.txtDirEntrega = New DevExpress.XtraEditors.MemoEdit()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.rgTipoO = New DevExpress.XtraEditors.RadioGroup()
        CType(Me.txtPrecioC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemArticuloD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecioU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbclientes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cbBodegas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etTasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBotones.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtdescuentos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdescuentop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoServicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbmoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtruc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpais.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtvendedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmunicipio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttelefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbformapago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCaja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbcentrocosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaPago.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDirEntrega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgTipoO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Cliente :"
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn6.AppearanceHeader.Options.UseFont = True
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "% Descuento"
        Me.GridColumn6.DisplayFormat.FormatString = "P2"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "Descuento"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Descuento", "{0:n2}")})
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Precio C$"
        Me.GridColumn4.ColumnEdit = Me.txtPrecioC
        Me.GridColumn4.FieldName = "Precio"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Precio", "{0:n2}")})
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        '
        'txtPrecioC
        '
        Me.txtPrecioC.AutoHeight = False
        Me.txtPrecioC.Mask.UseMaskAsDisplayFormat = True
        Me.txtPrecioC.Name = "txtPrecioC"
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Cantidad"
        Me.GridColumn3.DisplayFormat.FormatString = "n2"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "Cantidad"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cantidad", "{0:n2}")})
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'ItemArticulo
        '
        Me.ItemArticulo.AutoHeight = False
        Me.ItemArticulo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Insert), SerializableAppearanceObject1, "", Nothing, Nothing, False)})
        Me.ItemArticulo.Name = "ItemArticulo"
        Me.ItemArticulo.NullText = ""
        Me.ItemArticulo.ShowFooter = False
        Me.ItemArticulo.ShowHeader = False
        '
        'GridView1
        '
        Me.GridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn11, Me.GridColumn4, Me.GridColumn6, Me.GridColumn5, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.GridView1.GridControl = Me.GridDetalle
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowColumnResizing = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsFilter.AllowMRUFilterList = False
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Codigo"
        Me.GridColumn1.ColumnEdit = Me.ItemArticulo
        Me.GridColumn1.FieldName = "Item"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Descripcion"
        Me.GridColumn2.ColumnEdit = Me.ItemArticuloD
        Me.GridColumn2.FieldName = "Item"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'ItemArticuloD
        '
        Me.ItemArticuloD.AutoHeight = False
        Me.ItemArticuloD.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Insert), SerializableAppearanceObject2, "", Nothing, Nothing, False)})
        Me.ItemArticuloD.Name = "ItemArticuloD"
        Me.ItemArticuloD.NullText = ""
        Me.ItemArticuloD.ShowFooter = False
        Me.ItemArticuloD.ShowHeader = False
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn11.AppearanceHeader.Options.UseFont = True
        Me.GridColumn11.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.Caption = "Precio U$"
        Me.GridColumn11.ColumnEdit = Me.txtPrecioU
        Me.GridColumn11.FieldName = "PrecioU"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PrecioU", "{0:n2}")})
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 3
        '
        'txtPrecioU
        '
        Me.txtPrecioU.AutoHeight = False
        Me.txtPrecioU.Mask.UseMaskAsDisplayFormat = True
        Me.txtPrecioU.Name = "txtPrecioU"
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn5.AppearanceHeader.Options.UseFont = True
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Sub Total"
        Me.GridColumn5.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "Total"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.AllowFocus = False
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:n2}")})
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 6
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "IVA"
        Me.GridColumn7.DisplayFormat.FormatString = "n2"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "IVA"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IVA", "{0:n2}")})
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "GridColumn8"
        Me.GridColumn8.FieldName = "Cuenta"
        Me.GridColumn8.Name = "GridColumn8"
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "GridColumn9"
        Me.GridColumn9.FieldName = "Tipo"
        Me.GridColumn9.Name = "GridColumn9"
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "GridColumn10"
        Me.GridColumn10.FieldName = "Exento"
        Me.GridColumn10.Name = "GridColumn10"
        '
        'GridDetalle
        '
        Me.GridDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDetalle.Location = New System.Drawing.Point(9, 179)
        Me.GridDetalle.MainView = Me.GridView1
        Me.GridDetalle.Name = "GridDetalle"
        Me.GridDetalle.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ItemArticulo, Me.ItemArticuloD, Me.txtPrecioC, Me.txtPrecioU})
        Me.GridDetalle.Size = New System.Drawing.Size(865, 232)
        Me.GridDetalle.TabIndex = 14
        Me.GridDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'cmbclientes
        '
        Me.cmbclientes.Location = New System.Drawing.Point(60, 13)
        Me.cmbclientes.Name = "cmbclientes"
        Me.cmbclientes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Insert), SerializableAppearanceObject3, "", Nothing, Nothing, False)})
        Me.cmbclientes.Properties.NullText = ""
        Me.cmbclientes.Properties.PopupFormMinSize = New System.Drawing.Size(500, 0)
        Me.cmbclientes.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cmbclientes.Properties.ShowFooter = False
        Me.cmbclientes.Properties.ShowHeader = False
        Me.cmbclientes.Size = New System.Drawing.Size(300, 20)
        Me.cmbclientes.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cbBodegas)
        Me.GroupBox1.Controls.Add(Me.etTasa)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.gbBotones)
        Me.GroupBox1.Controls.Add(Me.GridDetalle)
        Me.GroupBox1.Controls.Add(Me.GroupControl1)
        Me.GroupBox1.Controls.Add(Me.TipoServicio)
        Me.GroupBox1.Controls.Add(Me.txtdireccion)
        Me.GroupBox1.Controls.Add(Me.cmbmoneda)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtruc)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtpais)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtdepto)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtvendedor)
        Me.GroupBox1.Controls.Add(Me.txtmunicipio)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txttelefono)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cmbformapago)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.lbltotal)
        Me.GroupBox1.Controls.Add(Me.lbliva)
        Me.GroupBox1.Controls.Add(Me.lblsubtotal)
        Me.GroupBox1.Controls.Add(Me.txtCaja)
        Me.GroupBox1.Controls.Add(Me.cmbcentrocosto)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 474)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'cbBodegas
        '
        Me.cbBodegas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbBodegas.Location = New System.Drawing.Point(792, 149)
        Me.cbBodegas.Name = "cbBodegas"
        Me.cbBodegas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBodegas.Properties.Appearance.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbBodegas.Properties.Appearance.Options.UseFont = True
        Me.cbBodegas.Properties.Appearance.Options.UseForeColor = True
        Me.cbBodegas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbBodegas.Properties.NullText = ""
        Me.cbBodegas.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cbBodegas.Properties.ShowFooter = False
        Me.cbBodegas.Properties.ShowHeader = False
        Me.cbBodegas.Size = New System.Drawing.Size(192, 20)
        Me.cbBodegas.TabIndex = 11
        Me.cbBodegas.TabStop = False
        '
        'etTasa
        '
        Me.etTasa.EditValue = 1
        Me.etTasa.EnterMoveNextControl = True
        Me.etTasa.Location = New System.Drawing.Point(352, 97)
        Me.etTasa.Name = "etTasa"
        Me.etTasa.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.etTasa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTasa.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.etTasa.Properties.Appearance.Options.UseBackColor = True
        Me.etTasa.Properties.Appearance.Options.UseFont = True
        Me.etTasa.Properties.Appearance.Options.UseForeColor = True
        Me.etTasa.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.etTasa.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTasa.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.etTasa.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.etTasa.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.etTasa.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.etTasa.Properties.Mask.EditMask = "n4"
        Me.etTasa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.etTasa.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.etTasa.Properties.ReadOnly = True
        Me.etTasa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.etTasa.Size = New System.Drawing.Size(88, 20)
        Me.etTasa.TabIndex = 5
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(286, 104)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(66, 13)
        Me.Label29.TabIndex = 186
        Me.Label29.Text = "T/Cambio:"
        '
        'gbBotones
        '
        Me.gbBotones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbBotones.BackColor = System.Drawing.Color.Transparent
        Me.gbBotones.Controls.Add(Me.cmdConsultaClientes)
        Me.gbBotones.Controls.Add(Me.cmdConsulta)
        Me.gbBotones.Controls.Add(Me.cmdCancelar)
        Me.gbBotones.Controls.Add(Me.GroupBox2)
        Me.gbBotones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBotones.ForeColor = System.Drawing.Color.Maroon
        Me.gbBotones.Location = New System.Drawing.Point(880, 172)
        Me.gbBotones.Name = "gbBotones"
        Me.gbBotones.Size = New System.Drawing.Size(112, 239)
        Me.gbBotones.TabIndex = 131
        Me.gbBotones.TabStop = False
        '
        'cmdConsultaClientes
        '
        Me.cmdConsultaClientes.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConsultaClientes.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdConsultaClientes.Appearance.Options.UseFont = True
        Me.cmdConsultaClientes.Appearance.Options.UseForeColor = True
        Me.cmdConsultaClientes.Location = New System.Drawing.Point(8, 60)
        Me.cmdConsultaClientes.Name = "cmdConsultaClientes"
        Me.cmdConsultaClientes.Size = New System.Drawing.Size(98, 35)
        Me.cmdConsultaClientes.TabIndex = 1
        Me.cmdConsultaClientes.Text = "C&lientes"
        '
        'cmdConsulta
        '
        Me.cmdConsulta.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConsulta.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdConsulta.Appearance.Options.UseFont = True
        Me.cmdConsulta.Appearance.Options.UseForeColor = True
        Me.cmdConsulta.Location = New System.Drawing.Point(8, 17)
        Me.cmdConsulta.Name = "cmdConsulta"
        Me.cmdConsulta.Size = New System.Drawing.Size(98, 35)
        Me.cmdConsulta.TabIndex = 0
        Me.cmdConsulta.Text = "&Productos"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Appearance.Options.UseForeColor = True
        Me.cmdCancelar.Image = Global.SysContab.My.Resources.Resources.SalirFrm
        Me.cmdCancelar.Location = New System.Drawing.Point(8, 195)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(96, 35)
        Me.cmdCancelar.TabIndex = 2
        Me.cmdCancelar.Text = "&Salir"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmdAceptar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(0, 100)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(120, 82)
        Me.GroupBox2.TabIndex = 142
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Grabar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Appearance.Options.UseForeColor = True
        Me.cmdAceptar.Appearance.Options.UseTextOptions = True
        Me.cmdAceptar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdAceptar.Image = Global.SysContab.My.Resources.Resources.RibbonUserDesigner_SaveFileLarge
        Me.cmdAceptar.Location = New System.Drawing.Point(8, 29)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(96, 35)
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Text = "&Guarar"
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupControl1.Appearance.Options.UseForeColor = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.txtdescuentos)
        Me.GroupControl1.Controls.Add(Me.txtdescuentop)
        Me.GroupControl1.Controls.Add(Me.Label14)
        Me.GroupControl1.Controls.Add(Me.Label15)
        Me.GroupControl1.Location = New System.Drawing.Point(9, 112)
        Me.GroupControl1.LookAndFeel.SkinName = "Blue"
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(232, 61)
        Me.GroupControl1.TabIndex = 12
        Me.GroupControl1.Text = "Tipo Descuento"
        '
        'txtdescuentos
        '
        Me.txtdescuentos.Location = New System.Drawing.Point(190, 27)
        Me.txtdescuentos.Name = "txtdescuentos"
        Me.txtdescuentos.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtdescuentos.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescuentos.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtdescuentos.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtdescuentos.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtdescuentos.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtdescuentos.Properties.ReadOnly = True
        Me.txtdescuentos.Size = New System.Drawing.Size(32, 20)
        Me.txtdescuentos.TabIndex = 1
        Me.txtdescuentos.TabStop = False
        '
        'txtdescuentop
        '
        Me.txtdescuentop.Location = New System.Drawing.Point(80, 27)
        Me.txtdescuentop.Name = "txtdescuentop"
        Me.txtdescuentop.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtdescuentop.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescuentop.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtdescuentop.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtdescuentop.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtdescuentop.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtdescuentop.Properties.ReadOnly = True
        Me.txtdescuentop.Size = New System.Drawing.Size(32, 20)
        Me.txtdescuentop.TabIndex = 0
        Me.txtdescuentop.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(10, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Productos :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(123, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 13)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Servicios :"
        '
        'TipoServicio
        '
        Me.TipoServicio.Location = New System.Drawing.Point(247, 139)
        Me.TipoServicio.Name = "TipoServicio"
        Me.TipoServicio.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.TipoServicio.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TipoServicio.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.TipoServicio.Properties.Appearance.Options.UseBackColor = True
        Me.TipoServicio.Properties.Appearance.Options.UseFont = True
        Me.TipoServicio.Properties.Appearance.Options.UseForeColor = True
        Me.TipoServicio.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("P", "Productos"), New DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Servicios"), New DevExpress.XtraEditors.Controls.RadioGroupItem("A", "Ambos")})
        Me.TipoServicio.Size = New System.Drawing.Size(264, 34)
        Me.TipoServicio.TabIndex = 13
        Me.TipoServicio.TabStop = False
        '
        'txtdireccion
        '
        Me.txtdireccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdireccion.Location = New System.Drawing.Point(352, 18)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtdireccion.Properties.AppearanceReadOnly.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtdireccion.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtdireccion.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtdireccion.Properties.ReadOnly = True
        Me.txtdireccion.Size = New System.Drawing.Size(349, 47)
        Me.txtdireccion.TabIndex = 3
        Me.txtdireccion.TabStop = False
        '
        'cmbmoneda
        '
        Me.cmbmoneda.Location = New System.Drawing.Point(352, 71)
        Me.cmbmoneda.Name = "cmbmoneda"
        Me.cmbmoneda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmbmoneda.Properties.Appearance.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbmoneda.Properties.Appearance.Options.UseFont = True
        Me.cmbmoneda.Properties.Appearance.Options.UseForeColor = True
        Me.cmbmoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbmoneda.Properties.NullText = ""
        Me.cmbmoneda.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cmbmoneda.Properties.ShowFooter = False
        Me.cmbmoneda.Properties.ShowHeader = False
        Me.cmbmoneda.Size = New System.Drawing.Size(245, 20)
        Me.cmbmoneda.TabIndex = 4
        Me.cmbmoneda.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(296, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Moneda:"
        '
        'txtruc
        '
        Me.txtruc.Location = New System.Drawing.Point(63, 16)
        Me.txtruc.Name = "txtruc"
        Me.txtruc.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtruc.Properties.AppearanceReadOnly.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtruc.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtruc.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtruc.Properties.ReadOnly = True
        Me.txtruc.Size = New System.Drawing.Size(217, 20)
        Me.txtruc.TabIndex = 0
        Me.txtruc.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(11, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "RUC :"
        '
        'txtpais
        '
        Me.txtpais.Location = New System.Drawing.Point(63, 41)
        Me.txtpais.Name = "txtpais"
        Me.txtpais.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtpais.Properties.AppearanceReadOnly.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtpais.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtpais.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtpais.Properties.ReadOnly = True
        Me.txtpais.Size = New System.Drawing.Size(217, 20)
        Me.txtpais.TabIndex = 1
        Me.txtpais.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(13, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Pais :"
        '
        'txtdepto
        '
        Me.txtdepto.Location = New System.Drawing.Point(63, 67)
        Me.txtdepto.Name = "txtdepto"
        Me.txtdepto.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtdepto.Properties.AppearanceReadOnly.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtdepto.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtdepto.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtdepto.Properties.ReadOnly = True
        Me.txtdepto.Size = New System.Drawing.Size(217, 20)
        Me.txtdepto.TabIndex = 2
        Me.txtdepto.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(6, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Depto :"
        '
        'txtvendedor
        '
        Me.txtvendedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtvendedor.Location = New System.Drawing.Point(792, 71)
        Me.txtvendedor.Name = "txtvendedor"
        Me.txtvendedor.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtvendedor.Properties.AppearanceReadOnly.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtvendedor.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtvendedor.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtvendedor.Properties.ReadOnly = True
        Me.txtvendedor.Size = New System.Drawing.Size(192, 20)
        Me.txtvendedor.TabIndex = 8
        Me.txtvendedor.TabStop = False
        '
        'txtmunicipio
        '
        Me.txtmunicipio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmunicipio.Location = New System.Drawing.Point(792, 45)
        Me.txtmunicipio.Name = "txtmunicipio"
        Me.txtmunicipio.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtmunicipio.Properties.AppearanceReadOnly.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtmunicipio.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtmunicipio.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtmunicipio.Properties.ReadOnly = True
        Me.txtmunicipio.Size = New System.Drawing.Size(192, 20)
        Me.txtmunicipio.TabIndex = 7
        Me.txtmunicipio.TabStop = False
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(720, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Municipio:"
        '
        'txttelefono
        '
        Me.txttelefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttelefono.Location = New System.Drawing.Point(792, 19)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txttelefono.Properties.AppearanceReadOnly.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txttelefono.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txttelefono.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txttelefono.Properties.ReadOnly = True
        Me.txttelefono.Size = New System.Drawing.Size(192, 20)
        Me.txttelefono.TabIndex = 6
        Me.txttelefono.TabStop = False
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(724, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Telefono:"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(720, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Vendedor:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(283, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Direccion :"
        '
        'cmbformapago
        '
        Me.cmbformapago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbformapago.Location = New System.Drawing.Point(792, 97)
        Me.cmbformapago.Name = "cmbformapago"
        Me.cmbformapago.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmbformapago.Properties.Appearance.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbformapago.Properties.Appearance.Options.UseFont = True
        Me.cmbformapago.Properties.Appearance.Options.UseForeColor = True
        Me.cmbformapago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbformapago.Properties.NullText = ""
        Me.cmbformapago.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cmbformapago.Properties.ShowFooter = False
        Me.cmbformapago.Properties.ShowHeader = False
        Me.cmbformapago.Size = New System.Drawing.Size(192, 20)
        Me.cmbformapago.TabIndex = 9
        Me.cmbformapago.TabStop = False
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(689, 102)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Forma de Pago:"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(428, 418)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Sub Total :"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(605, 418)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 13)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "IVA :"
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(743, 418)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 13)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Total :"
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.Color.Maroon
        Me.lbltotal.Location = New System.Drawing.Point(790, 418)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(104, 17)
        Me.lbltotal.TabIndex = 2
        Me.lbltotal.Text = "0.00"
        '
        'lbliva
        '
        Me.lbliva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbliva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbliva.ForeColor = System.Drawing.Color.Maroon
        Me.lbliva.Location = New System.Drawing.Point(641, 418)
        Me.lbliva.Name = "lbliva"
        Me.lbliva.Size = New System.Drawing.Size(101, 17)
        Me.lbliva.TabIndex = 2
        Me.lbliva.Text = "0.00"
        '
        'lblsubtotal
        '
        Me.lblsubtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblsubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubtotal.ForeColor = System.Drawing.Color.Maroon
        Me.lblsubtotal.Location = New System.Drawing.Point(504, 418)
        Me.lblsubtotal.Name = "lblsubtotal"
        Me.lblsubtotal.Size = New System.Drawing.Size(95, 17)
        Me.lblsubtotal.TabIndex = 2
        Me.lblsubtotal.Text = "0.00"
        '
        'txtCaja
        '
        Me.txtCaja.Location = New System.Drawing.Point(289, 41)
        Me.txtCaja.Name = "txtCaja"
        Me.txtCaja.Properties.ReadOnly = True
        Me.txtCaja.Size = New System.Drawing.Size(47, 20)
        Me.txtCaja.TabIndex = 5
        Me.txtCaja.TabStop = False
        Me.txtCaja.Visible = False
        '
        'cmbcentrocosto
        '
        Me.cmbcentrocosto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbcentrocosto.Location = New System.Drawing.Point(792, 123)
        Me.cmbcentrocosto.Name = "cmbcentrocosto"
        Me.cmbcentrocosto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcentrocosto.Properties.Appearance.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbcentrocosto.Properties.Appearance.Options.UseFont = True
        Me.cmbcentrocosto.Properties.Appearance.Options.UseForeColor = True
        Me.cmbcentrocosto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbcentrocosto.Properties.NullText = ""
        Me.cmbcentrocosto.Properties.ShowFooter = False
        Me.cmbcentrocosto.Properties.ShowHeader = False
        Me.cmbcentrocosto.Size = New System.Drawing.Size(192, 20)
        Me.cmbcentrocosto.TabIndex = 10
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(731, 156)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(54, 13)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Bodega:"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(725, 130)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 13)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Sucursal:"
        '
        'fecha
        '
        Me.fecha.EditValue = Nothing
        Me.fecha.Location = New System.Drawing.Point(600, 13)
        Me.fecha.Name = "fecha"
        Me.fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.fecha.Size = New System.Drawing.Size(100, 20)
        Me.fecha.TabIndex = 2
        Me.fecha.TabStop = False
        '
        'FechaPago
        '
        Me.FechaPago.EditValue = Nothing
        Me.FechaPago.Location = New System.Drawing.Point(804, 13)
        Me.FechaPago.Name = "FechaPago"
        Me.FechaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaPago.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.FechaPago.Size = New System.Drawing.Size(100, 20)
        Me.FechaPago.TabIndex = 3
        Me.FechaPago.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(368, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "No Orden :"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(552, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Fecha :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(712, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Fecha Vence:"
        '
        'txtfactura
        '
        Me.txtfactura.Location = New System.Drawing.Point(436, 10)
        Me.txtfactura.Name = "txtfactura"
        Me.txtfactura.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtfactura.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfactura.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtfactura.Properties.Appearance.Options.UseBackColor = True
        Me.txtfactura.Properties.Appearance.Options.UseFont = True
        Me.txtfactura.Properties.Appearance.Options.UseForeColor = True
        Me.txtfactura.Properties.Mask.EditMask = "d"
        Me.txtfactura.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtfactura.Size = New System.Drawing.Size(110, 22)
        Me.txtfactura.TabIndex = 1
        Me.txtfactura.TabStop = False
        '
        'txtDirEntrega
        '
        Me.txtDirEntrega.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDirEntrega.Location = New System.Drawing.Point(97, 39)
        Me.txtDirEntrega.Name = "txtDirEntrega"
        Me.txtDirEntrega.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirEntrega.Properties.Appearance.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDirEntrega.Properties.Appearance.Options.UseFont = True
        Me.txtDirEntrega.Properties.Appearance.Options.UseForeColor = True
        Me.txtDirEntrega.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtDirEntrega.Properties.AppearanceReadOnly.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDirEntrega.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtDirEntrega.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtDirEntrega.Size = New System.Drawing.Size(508, 25)
        Me.txtDirEntrega.TabIndex = 4
        Me.txtDirEntrega.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(12, 47)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(79, 13)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "Dir. Entrega:"
        '
        'rgTipoO
        '
        Me.rgTipoO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rgTipoO.EditValue = 1
        Me.rgTipoO.Location = New System.Drawing.Point(615, 39)
        Me.rgTipoO.Name = "rgTipoO"
        Me.rgTipoO.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgTipoO.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgTipoO.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.rgTipoO.Properties.Appearance.Options.UseBackColor = True
        Me.rgTipoO.Properties.Appearance.Options.UseFont = True
        Me.rgTipoO.Properties.Appearance.Options.UseForeColor = True
        Me.rgTipoO.Properties.Appearance.Options.UseTextOptions = True
        Me.rgTipoO.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.rgTipoO.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Remisión"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Traslado")})
        Me.rgTipoO.Size = New System.Drawing.Size(289, 24)
        Me.rgTipoO.TabIndex = 13
        '
        'FrmOrdenesNew
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 547)
        Me.ControlBox = False
        Me.Controls.Add(Me.rgTipoO)
        Me.Controls.Add(Me.txtDirEntrega)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbclientes)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.FechaPago)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtfactura)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FrmOrdenesNew"
        Me.Text = "Ordenes de Venta"
        CType(Me.txtPrecioC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemArticuloD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecioU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbclientes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cbBodegas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etTasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBotones.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtdescuentos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdescuentop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoServicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbmoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtruc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpais.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtvendedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmunicipio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttelefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbformapago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCaja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbcentrocosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaPago.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDirEntrega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgTipoO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


#Region "Variables"
    Private _Factura As String = ""
    Private DT_Facturas As DataTable = New DataTable("Facturas")
    Private Temp As Boolean = False
    Private dd As String

    Dim ds As DataTable
    Public Nuevo As String
    Public Tipo As String
    Public TipoO As Integer
    Public Estado As String


    Private Config As New VB.SysContab.ConfiguracionDB
    Private ConfigDetalles As New VB.SysContab.ConfiguracionDetails
    Private ServCont As Boolean
    Private r As New VB.SysContab.Rutinas
    Private FacturaImprimir As String
    Private Clientes As New VB.SysContab.ClientesDB
    Private DetallesCliente As New VB.SysContab.ClientesDetails
    Private FormaPago As New VB.SysContab.Forma_PagoDB
    Private Articulos As New VB.SysContab.ArticulosDB
    Private DetallesProducto As New VB.SysContab.ArticulosDetails
    Private DetallesVendedor As New VB.SysContab.VendedoresDetails
    Private Vendedor As New VB.SysContab.VendedoresDB
    Private dsProveedoresTemporales As DataSet
    Private dsItemTemporales As DataSet
    Private FacturasCompras As New VB.SysContab.Facturas_ComprasDB
    Private Ordenes_Compras As New VB.SysContab.Ordenes_ComprasDB
    Private Ordenes As New VB.SysContab.OrdenesDB
    Private VentaPerdidaNumero As Long
    Private FacturaTemporal As New VB.SysContab.Facturas_Ventas_TemporalDB

    Dim TCambio As Double = 1
#End Region

    Public Property Factura()
        Get
            Return _Factura
        End Get
        Set(ByVal Value)
            _Factura = Value
        End Set
    End Property

    Private Sub FrmFacturacionClienteNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Digitos As Integer
        Dim Clientes As New VB.SysContab.ClientesDB

        'GetClientesList(cmbclientes)
        LoadClients()
        GetMonedasList(cmbmoneda)
        GetFormaPagoList(cmbformapago)
        GetCentrosCostosList(Me.cmbcentrocosto)
        'GetBodegasList(Me.cbBodegas)
        GetBodegasxUsuario(cbBodegas, 0)

        ConfigDetalles = Config.GetConfigDetails
        Digitos = ConfigDetalles.FacturaDigitos

        For d As Integer = 0 To Digitos - 1
            dd = dd & "0"
        Next

        'If Nuevo = "NO" Then    'Editar Orden
        '    TipoServicio.EditValue = Tipo
        '    'ds = ObtieneDatos("sp_GetDetalleOrdenEntrega " & EmpresaActual & ",'" & RegistroOrdenVer & "'")
        '    Exit Sub
        'End If

        If Nuevo = "SI" Then
            TipoServicio.EditValue = Tipo
            txtfactura.Text = Ordenes.Numero
            fecha.EditValue = Now.Date
            FechaPago.EditValue = Now.Date

            '**** Cargar Tasa de Cambio
            TCambio = CDbl(ObtieneDatos("SELECT isnull(max(tc.TASA_CAMBIO),1) Tasa FROM TASA_CAMBIO tc" _
            + " WHERE tc.DIA = " & Me.fecha.DateTime.Day & " AND tc.MES = " & Me.fecha.DateTime.Month & " AND tc.ANIO = " & Me.fecha.DateTime.Year & "").Rows.Item(0)(0))
            Me.etTasa.Text = TCambio.ToString("n4")
        Else
            TipoServicio.EditValue = Tipo
            MostrarDatos()
            CalcularTotales()
        End If

    End Sub

    Sub MostrarDatos()
        Me.txtfactura.Text = DT_Facturas.Rows.Item(0)("Factura")
        Me.fecha.DateTime = DT_Facturas.Rows.Item(0)("Fecha")
        Me.cmbclientes.EditValue = DT_Facturas.Rows.Item(0)("Cliente")
        Me.FechaPago.DateTime = DT_Facturas.Rows.Item(0)("Fecha_Vencimiento")
        Me.txtDirEntrega.Text = DT_Facturas.Rows.Item(0)("DirEntrega")
        Me.cmbformapago.EditValue = DT_Facturas.Rows.Item(0)("TIPO_FACTURA")
        Me.cmbcentrocosto.EditValue = DT_Facturas.Rows.Item(0)("CentroCosto")
        Me.cbBodegas.EditValue = DT_Facturas.Rows.Item(0)("Bodega")

        If DT_Facturas.Rows.Item(0)("Remision") Then
            Me.rgTipoO.EditValue = 1
        ElseIf DT_Facturas.Rows.Item(0)("Nota") Then
            Me.rgTipoO.EditValue = 2
        End If

        Me.txtfactura.Properties.ReadOnly = True
        Me.TipoServicio.Enabled = False

        If DT_Facturas.Rows.Item(0)("Estado") = "F" Then
            Me.cmdAceptar.Enabled = False
        End If
    End Sub

    Private Sub GetData()

        Dim Datos As New ArrayList
        Dim Variables As New ArrayList

        Variables.Add("Empresa")
        Variables.Add("Factura")

        Datos.Add(EmpresaActual)
        Datos.Add(Factura)
        DT_Facturas = ProcedureParameters(Datos, Variables, "sp_GetDetalleOrdenEntrega")
        GridDetalle.DataSource = DT_Facturas

        Me.txtPrecioC.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrecioC.Mask.EditMask = "n" + ConfigDetalles.Decimales.ToString

        Me.txtPrecioU.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrecioU.Mask.EditMask = "n" + ConfigDetalles.Decimales.ToString
    End Sub

    Private Sub LoadClients()
        GetClientesList(cmbclientes)
        cmbclientes.Properties.Columns(0).Visible = True : cmbclientes.Properties.ShowHeader = True 'Para radioshack
        cmbclientes.Properties.HeaderClickMode = DevExpress.XtraEditors.Controls.HeaderClickMode.AutoSearch 'Para radioshack
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmbclientes_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbclientes.EditValueChanged
        Try
            Try
                'cmbcentrocosto.Properties.DataSource = ObtieneDatos("SELECT IdCentroCosto,Nombre FROM CentrosCostoCliente WHERE Empresa = " & EmpresaActual & " AND IdCliente = " & cmbclientes.EditValue)
                'cmbcentrocosto.Properties.DisplayMember = "Nombre"
                'cmbcentrocosto.Properties.ValueMember = "IdCentroCosto"
                'cmbcentrocosto.Properties.PopulateColumns()
                'cmbcentrocosto.Properties.Columns(0).Visible = False
            Catch ex As Exception

            End Try
            DetallesCliente = VB.SysContab.ClientesDB.GetDetails(cmbclientes.EditValue)
            cmbformapago.EditValue = cmbclientes.GetColumnValue("FormaPago")
            txtruc.Text = cmbclientes.GetColumnValue("RUC")
            txtdireccion.Text = cmbclientes.GetColumnValue("Direccion")
            txttelefono.Text = cmbclientes.GetColumnValue("Telefono")
            txtpais.Text = cmbclientes.GetColumnValue("Pais")
            txtmunicipio.Text = cmbclientes.GetColumnValue("Municipio")
            txtdepto.Text = cmbclientes.GetColumnValue("Departamento")
            txtdescuentop.Text = cmbclientes.GetColumnValue("Desc_Prod")
            txtdescuentos.Text = cmbclientes.GetColumnValue("Desc_Serv")
            txtvendedor.Text = cmbclientes.GetColumnValue("Vendedor")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TipoServicio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoServicio.SelectedIndexChanged
        GetArticulos()
        GetData()
    End Sub

    Private Sub GetArticulos()
        Dim DT As DataTable
        DT = ObtieneDatos("SP_ArticulosGetAll '" & TipoServicio.EditValue & "'," & EmpresaActual)
        ItemArticulo.DataSource = DT
        ItemArticulo.DisplayMember = "Codigo"
        ItemArticulo.ValueMember = "Codigo"
        ItemArticulo.PopulateColumns()
        For i As Integer = 2 To ItemArticulo.Columns.Count - 1
            ItemArticulo.Columns(i).Visible = False
        Next
        ItemArticulo.Columns(1).Visible = False
        ItemArticuloD.DataSource = DT
        ItemArticuloD.DisplayMember = "Nombre"
        ItemArticuloD.ValueMember = "Codigo"
        ItemArticuloD.PopulateColumns()
        For i As Integer = 2 To ItemArticuloD.Columns.Count - 1
            ItemArticuloD.Columns(i).Visible = False
        Next
        ItemArticuloD.Columns(0).Visible = False
    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        'If e.Column.FieldName = "Precio" And Temp = False Then
        'End If

        If e.Column.FieldName = "Item" Then
            Dim DR As DataRowView = ItemArticulo.GetDataSourceRowByKeyValue(e.Value)
            Temp = True
            GridView1.SetRowCellValue(e.RowHandle, "Precio", DR.Item("Precio"))
            GridView1.SetRowCellValue(e.RowHandle, "PrecioU", DR.Item("PrecioU"))
            GridView1.SetRowCellValue(e.RowHandle, "Cantidad", 1)
            GridView1.SetRowCellValue(e.RowHandle, "Descuento", 0)
            GridView1.SetRowCellValue(e.RowHandle, "Cuenta", dr.Item("Cuenta"))
            GridView1.SetRowCellValue(e.RowHandle, "Tipo", dr.Item("Tipo"))
            GridView1.SetRowCellValue(e.RowHandle, "Exento", dr.Item("Exento"))
            Temp = False
        End If

        If e.Column.FieldName = "Precio" And Not Temp Then
            If e.Value <> 0 Then
                Temp = True
                GridView1.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(e.Value / TCambio))
                Temp = False
            End If
        End If

        If e.Column.FieldName = "PrecioU" And Not Temp Then
            If e.Value <> 0 Then
                Temp = True
                GridView1.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * TCambio))
                Temp = False
            End If
        End If

        If e.Column.FieldName = "Descuento" And Not Temp Then
            If e.Value <> 0 Then
                Temp = True
                GridView1.SetRowCellValue(e.RowHandle, "Descuento", e.Value / 100)
                Temp = False
            End If
        End If

        If e.Column.FieldName = "Precio" Or e.Column.FieldName = "Cantidad" Or e.Column.FieldName = "Descuento" Then
            GridView1.SetRowCellValue(e.RowHandle, "Total", IsNull(GridView1.GetRowCellValue(e.RowHandle, "Cantidad"), 1) * IsNull(GridView1.GetRowCellValue(e.RowHandle, "Precio"), 0) - (IsNull(GridView1.GetRowCellValue(e.RowHandle, "Cantidad"), 1) * IsNull(GridView1.GetRowCellValue(e.RowHandle, "Precio"), 0) * IsNull(GridView1.GetRowCellValue(e.RowHandle, "Descuento"), 0)))
            Dim DR As DataRowView = ItemArticulo.GetDataSourceRowByKeyValue(GridView1.GetRowCellValue(e.RowHandle, "Item"))
            Dim Config As New VB.SysContab.ConfiguracionDB
            Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails
            ConfigDetalles = Config.GetConfigDetails
            If DR.Item("Exento") = False Then
                GridView1.SetRowCellValue(e.RowHandle, "IVA", IsNull(GridView1.GetRowCellValue(e.RowHandle, "Total") * (ConfigDetalles.IVA / 100.0), 0))
            End If
        End If

        GridView1.UpdateTotalSummary()
    End Sub

    Private Sub GridView1_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView1.RowUpdated
        CalcularTotales()
    End Sub

    Sub CalcularTotales()
        lblsubtotal.Text = FormatNumber(GridView1.Columns("Total").SummaryItem.SummaryValue, 2)
        lbliva.Text = FormatNumber(GridView1.Columns("IVA").SummaryItem.SummaryValue, 2)
        lbltotal.Text = FormatNumber(CDbl(lblsubtotal.Text) + CDbl(lbliva.Text), 2)
    End Sub

    Private Sub ItemArticulo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ItemArticulo.ButtonClick, ItemArticuloD.ButtonClick
        If e.Button.Index = 1 Then
            Dim f As New frmAgregarArticuloQuick
            f.WindowState = FormWindowState.Normal
            f.StartPosition = FormStartPosition.CenterScreen
            f.etTipo.Text = TipoServicio.EditValue
            If f.ShowDialog() = DialogResult.OK Then
                If IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Item")) OrElse GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Item") = Nothing Then
                    GridView1.InvalidateRow(GridView1.FocusedRowHandle)
                    GridView1.AddNewRow()
                End If
                GetArticulos()
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Item", f.txtCodigo.Text)
            End If
        End If
    End Sub

    Private Sub cmdConsultaClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultaClientes.Click
        If cmbclientes.EditValue = Nothing Then
            MsgBox("Seleccione el Cliente", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim f As frmAcumulados = f.Instance
        RegistroCliente = cmbclientes.EditValue

        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub

    Private Sub cmdConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsulta.Click
        Dim f As frmBuscarItem = f.Instance
        f.ShowDialog()
        For i As Integer = 0 To f.tItem.Rows.Count - 1
            GridView1.AddNewRow()
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Item", f.tItem.Rows(i).Item("Codigo"))
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Cantidad", f.tItem.Rows(i).Item("Cantidad"))
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Precio", f.tItem.Rows(i).Item("Precio"))
        Next
        GridView1.UpdateTotalSummary()
        'GridView1.AddNewRow()
    End Sub

    Private Sub cmbclientes_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cmbclientes.ButtonClick
        If e.Button.Index = 1 Then
            Dim f As New frmAgregarClienteQuick
            f.WindowState = FormWindowState.Normal
            f.StartPosition = FormStartPosition.CenterScreen
            NombreCliente = ""

            If f.ShowDialog() = DialogResult.OK Then
                GetClientesList(cmbclientes)
                cmbclientes.EditValue = CInt(f.txtCodigo.Text)
            End If
        End If
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Try
            If GuardarTemporal() = False Then
                ' SetTiempos(OrigenComprobantes.VENTAS, funciones.Tiempos.TiempoFin, Now, funciones.Eventos.Error1, Me.txtfactura.Text)
                VB.SysContab.Rutinas.ErrorTransaccion()
                Exit Sub
            End If

            VB.SysContab.Rutinas.okTransaccion()
            'SetTiempos(OrigenComprobantes.VENTAS, funciones.Tiempos.TiempoFin, Now, funciones.Eventos.Guarda, Me.txtfactura.Text)
            LoadOrdenProceso = False
            Close()

            '' Actualizar la Lista de Ordenes
            Dim f As frmListaOrdenes = f.Instance()
            f.Cargar()
        Catch ex As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            ' SetTiempos(OrigenComprobantes.VENTAS, funciones.Tiempos.TiempoFin, Now, funciones.Eventos.Error1, Me.txtfactura.Text)
            MsgBox(ex.Message & ". Consulte al Adminstrador del Sistema", MsgBoxStyle.Critical)
            Exit Sub
        End Try
    End Sub

    Private Function GuardarTemporal() As Boolean
        '********** Validando los Datos Requeridos  ******************************************
        If cmbclientes.EditValue = Nothing Then
            MsgBox("Seleccione el Cliente", MsgBoxStyle.Critical)
            cmbclientes.Focus()
            Return False
        End If

        If Trim(txtfactura.Text) = "" Or txtfactura.Text = vbNullString Then
            MsgBox("Introduzca el No. de Orden", MsgBoxStyle.Critical)
            txtfactura.Focus()
            Return False
        End If

        If cmbformapago.EditValue = Nothing Then
            MsgBox("Seleccione el Tipo de Pago", MsgBoxStyle.Information)
            cmbformapago.Focus()
            Return False
        End If

        If Me.cmbcentrocosto.EditValue Is Nothing Then
            MsgBox("Seleccione La Sucursal", MsgBoxStyle.Information)
            Me.cmbcentrocosto.Focus()
            Return False
        End If

        If Me.cbBodegas.EditValue Is Nothing Then
            MsgBox("Seleccione La Bodega", MsgBoxStyle.Information)
            Me.cmbcentrocosto.Focus()
            Return False
        End If

        If DT_Facturas.Rows.Count - 1 < 0 Then
            MsgBox("Seleccione al menos un Producto o Servicio", MsgBoxStyle.Critical)
            Return False
        End If

        If CDbl(TotalGlobal.ToString(Round)) > CDbl(TotalFactura.ToString(Round)) Then
            MsgBox("El monto es mayor que el saldo de la factura", MsgBoxStyle.Information)
            Return False
        End If
        '*****************************************************************************************

        If TipoServicio.EditValue = "P" Then
            TipoO = 0
        ElseIf TipoServicio.EditValue = "S" Then
            TipoO = 1
        Else
            TipoO = 2
        End If

        'Dim Factura As String = txtfactura.Text

        Dim OrdenCompra As String
        Dim Proveedor As String
        Dim NumeroTemporal As String

        '********   Iniciar Transaccion *******
        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction
        '////////////////////////////////////////////////////////

        Try
            If Nuevo = "SI" Then
                Ordenes.AddOrden(txtfactura.Text, fecha.DateTime.Date, cmbclientes.EditValue, txtruc.Text, CDbl(lblsubtotal.Text), _
                             CDbl(lbltotal.Text), TotalDescuento, CDbl(lbliva.Text), 0, 0, CDbl(lbltotal.Text), TotalFactura - TotalGlobal, IIf(IsNumeric(DetallesCliente.Vendedor), DetallesCliente.Vendedor, 0), _
                             FechaPago.DateTime.Date, FechaPago.DateTime.Date, TipoO, cmbformapago.EditValue, PvCodigo, cmbclientes.Text, _
                             IIf(Me.rgTipoO.EditValue = 1, 1, 0), IIf(Me.rgTipoO.EditValue = 2, 1, 0), _
                             IsNull(cbBodegas.EditValue, 0), Me.txtDirEntrega.Text.Trim, IsNull(cmbcentrocosto.EditValue, 0))
            ElseIf Nuevo = "NO" Then
                '***    Borrar Detalle de la Orden Para volverla a Ingresar
                Ordenes.DeleteOrdenDetalle(txtfactura.Text)

                '***    Actulizar Encabezado de la Orden
                Ordenes.UpdateOrden(txtfactura.Text, fecha.DateTime.Date, cmbclientes.EditValue, txtruc.Text, CDbl(lblsubtotal.Text), _
                                   CDbl(lbltotal.Text), TotalDescuento, CDbl(lbliva.Text), "0", "0", CDbl(lbltotal.Text), TotalFactura - TotalGlobal, IIf(IsNumeric(DetallesCliente.Vendedor), DetallesCliente.Vendedor, 0), _
                                    FechaPago.DateTime.Date, FechaPago.DateTime.Date, TipoO, cmbformapago.EditValue, PvCodigo, cmbclientes.Text, _
                                    IIf(Me.rgTipoO.EditValue = 1, 1, 0), IIf(Me.rgTipoO.EditValue = 2, 1, 0), _
                                    IsNull(cbBodegas.EditValue, 0), Me.txtDirEntrega.Text.Trim, IsNull(cmbcentrocosto.EditValue, 0))
                
            End If

            Dim Descuento As Double
            Dim Iva As Double
            Dim Comision As Double
            Dim Comisiones As New VB.SysContab.ComisionDB

            Dim dsComision As DataSet

            'For i As Integer = 0 To DT_Facturas.Rows.Count - 1
            For i As Integer = 0 To Me.GridView1.DataRowCount - 1
                If Me.GridView1.GetRowCellValue(i, "Descuento") Is DBNull.Value Then
                    Descuento = 0
                Else
                    Descuento = Me.GridView1.GetRowCellValue(i, "Descuento")
                End If

                'If DT_Facturas.Rows(i).Item("Descuento") Is DBNull.Value Then
                '    Descuento = 0
                'Else
                '    Descuento = DT_Facturas.Rows(i).Item("Descuento")
                'End If

                'dsComision = Comisiones.GetComisionItemVendedor(IIf(IsNumeric(DetallesCliente.Vendedor), DetallesCliente.Vendedor, 0), DT_Facturas.Rows(i).Item("Item"), DT_Facturas.Rows(i).Item("Tipo"))
                dsComision = Comisiones.GetComisionItemVendedor(IIf(IsNumeric(DetallesCliente.Vendedor), DetallesCliente.Vendedor, 0), Me.GridView1.GetRowCellValue(i, "Item"), Me.GridView1.GetRowCellValue(i, "Tipo"))

                If dsComision.Tables("Comisiones").Rows.Count <> 0 Then
                    Comision = dsComision.Tables("Comisiones").Rows(0).Item("Comision")
                Else
                    'DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(DT_Facturas.Rows(i).Item("Item"), DT_Facturas.Rows(i).Item("Tipo"), EmpresaActual)
                    'dsComision = Comisiones.GetComisionLineaVendedor(IIf(IsNumeric(DetallesCliente.Vendedor), DetallesCliente.Vendedor, 0), IIf(IsNumeric(DetallesProducto.Linea), DetallesProducto.Linea, 0), DT_Facturas.Rows(i).Item("Tipo"))
                    DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(Me.GridView1.GetRowCellValue(i, "Item"), Me.GridView1.GetRowCellValue(i, "Tipo"))
                    dsComision = Comisiones.GetComisionLineaVendedor(IIf(IsNumeric(DetallesCliente.Vendedor), DetallesCliente.Vendedor, 0), IIf(IsNumeric(DetallesProducto.Linea), DetallesProducto.Linea, 0), Me.GridView1.GetRowCellValue(i, "Tipo"))

                    If dsComision.Tables("Comisiones").Rows.Count <> 0 Then
                        Comision = dsComision.Tables("Comisiones").Rows(0).Item("Comision")
                    Else
                        'If DT_Facturas.Rows(i).Item("Tipo") = "P" Then
                        If Me.GridView1.GetRowCellValue(i, "Tipo") = "P" Then
                            Comision = DetallesVendedor.Comision
                        Else
                            Comision = DetallesVendedor.Comision_Servicio
                        End If
                    End If
                End If

                If DetallesCliente.Excento = True Then
                    Iva = 0
                Else
                    'If DT_Facturas.Rows(i).Item("Exento") = True Then
                    If Me.GridView1.GetRowCellValue(i, "Exento") = True Then
                        Iva = 0
                    Else
                        Iva = ConfigDetalles.IVA
                    End If
                End If

                'Ordenes.AddLineas(txtfactura.Text, DT_Facturas.Rows(i).Item("Item"), DT_Facturas.Rows(i).Item("Cantidad"), DT_Facturas.Rows(i).Item("Precio"), Descuento, _
                'CDbl(DT_Facturas.Rows(i).Item("Cantidad")) * CDbl(DT_Facturas.Rows(i).Item("Precio")), Comision, DT_Facturas.Rows(i).Item("Tipo"), 0, (CDbl(DT_Facturas.Rows(i).Item("Cantidad")) * CDbl(DT_Facturas.Rows(i).Item("Precio")) - ((CDbl(DT_Facturas.Rows(i).Item("Cantidad")) * CDbl(DT_Facturas.Rows(i).Item("Precio")) * (Descuento / 100.0)))) * Iva / 100.0)
                Ordenes.AddLineas(txtfactura.Text, Me.GridView1.GetRowCellValue(i, "Item"), Me.GridView1.GetRowCellValue(i, "Cantidad"), Me.GridView1.GetRowCellValue(i, "Precio"), _
                                  Descuento, CDbl(Me.GridView1.GetRowCellValue(i, "Cantidad")) * CDbl(Me.GridView1.GetRowCellValue(i, "Precio")), Comision, Me.GridView1.GetRowCellValue(i, "Tipo"), 0, _
                                   (CDbl(Me.GridView1.GetRowCellValue(i, "Cantidad")) * CDbl(Me.GridView1.GetRowCellValue(i, "Precio")) - ((CDbl(Me.GridView1.GetRowCellValue(i, "Cantidad")) * CDbl(Me.GridView1.GetRowCellValue(i, "Precio")) * (Descuento / 100.0)))) * Iva / 100.0)


                'Clientes.AddFacturaLineas(txtfactura.Text, DT_Facturas.Rows(i).Item("Item"), DT_Facturas.Rows(i).Item("Cantidad"), DT_Facturas.Rows(i).Item("Precio"), (CDbl(DT_Facturas.Rows(i).Item("Cantidad")) * CDbl(DT_Facturas.Rows(i).Item("Precio")) - ((CDbl(DT_Facturas.Rows(i).Item("Cantidad")) * CDbl(DT_Facturas.Rows(i).Item("Precio")) * (Descuento / 100.0)))) * Iva / 100.0, Descuento, CDbl(DT_Facturas.Rows(i).Item("Cantidad")) * CDbl(DT_Facturas.Rows(i).Item("Precio")), Comision, DT_Facturas.Rows(i).Item("Tipo"), Iva, DT_Facturas.Rows(i).Item("Item"))
            Next

            Return True
        Catch ex As SqlException
            MsgBox("La Orden Nº " & Me.txtfactura.Text & " que Intenta Registrar ya Fue Creada. " & vbCrLf & ex.Message, MsgBoxStyle.Information)
            Me.txtfactura.Focus()
            Me.txtfactura.SelectAll()
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
    End Function

    Private Sub cmbformapago_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbformapago.EditValueChanged
        Try
            If cmbformapago.GetColumnValue("Dias") = 0 Then
                cmdAceptar.Enabled = False
            Else
                cmdAceptar.Enabled = True
            End If

            FechaPago.EditValue = fecha.DateTime.AddDays(cmbformapago.GetColumnValue("Dias"))
        Catch ex As Exception
        End Try

    End Sub

    Private Sub fecha_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecha.EditValueChanged
        Try
            TCambio = CDbl(ObtieneDatos("SELECT isnull(max(tc.TASA_CAMBIO),1) Tasa FROM TASA_CAMBIO tc" _
            + " WHERE tc.DIA = " & Me.fecha.DateTime.Day & " AND tc.MES = " & Me.fecha.DateTime.Month & " AND tc.ANIO = " & Me.fecha.DateTime.Year & "").Rows.Item(0)(0))
            Me.etTasa.Text = TCambio.ToString("n4")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GridView1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Delete Then
            GridView1.DeleteRow(GridView1.FocusedRowHandle)
            GridView1.FocusedRowHandle = GridView1.DataRowCount - 1
        End If

        'DT_Facturas.AcceptChanges()
        CalcularTotales()
    End Sub
End Class
