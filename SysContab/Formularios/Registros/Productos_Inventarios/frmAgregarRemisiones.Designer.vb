<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarRemisiones
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.cmbcentrocosto = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbclientes = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtdireccion = New DevExpress.XtraEditors.MemoEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTransportisat = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtConductor = New DevExpress.XtraEditors.TextEdit()
        Me.txtPlaca = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GridDetalle = New DevExpress.XtraGrid.GridControl()
        Me.vDatos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemArticulo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemArticuloD = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.fecha = New DevExpress.XtraEditors.DateEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBuscarTraslado = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBuscarOrden = New DevExpress.XtraEditors.SimpleButton()
        Me.btnQuit = New DevExpress.XtraEditors.SimpleButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNoRemision = New DevExpress.XtraEditors.TextEdit()
        Me.txtNoOrden = New DevExpress.XtraEditors.TextEdit()
        Me.txtTraslado = New DevExpress.XtraEditors.TextEdit()
        Me.etTasa = New DevExpress.XtraEditors.TextEdit()
        Me.Label29 = New System.Windows.Forms.Label()
        CType(Me.cmbcentrocosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbclientes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTransportisat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConductor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlaca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemArticuloD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtNoRemision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTraslado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etTasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbcentrocosto
        '
        Me.cmbcentrocosto.Location = New System.Drawing.Point(148, 34)
        Me.cmbcentrocosto.Name = "cmbcentrocosto"
        Me.cmbcentrocosto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcentrocosto.Properties.Appearance.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbcentrocosto.Properties.Appearance.Options.UseFont = True
        Me.cmbcentrocosto.Properties.Appearance.Options.UseForeColor = True
        Me.cmbcentrocosto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbcentrocosto.Properties.NullText = ""
        Me.cmbcentrocosto.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cmbcentrocosto.Properties.ShowFooter = False
        Me.cmbcentrocosto.Properties.ShowHeader = False
        Me.cmbcentrocosto.Size = New System.Drawing.Size(381, 20)
        Me.cmbcentrocosto.TabIndex = 2
        Me.cmbcentrocosto.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(75, 41)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 13)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "Sucursal:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(85, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Cliente:"
        '
        'cmbclientes
        '
        Me.cmbclientes.Location = New System.Drawing.Point(148, 60)
        Me.cmbclientes.Name = "cmbclientes"
        Me.cmbclientes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbclientes.Properties.NullText = ""
        Me.cmbclientes.Properties.PopupFormMinSize = New System.Drawing.Size(500, 0)
        Me.cmbclientes.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cmbclientes.Properties.ShowFooter = False
        Me.cmbclientes.Properties.ShowHeader = False
        Me.cmbclientes.Size = New System.Drawing.Size(381, 20)
        Me.cmbclientes.TabIndex = 3
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(148, 86)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtdireccion.Properties.AppearanceReadOnly.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtdireccion.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtdireccion.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtdireccion.Properties.ReadOnly = True
        Me.txtdireccion.Size = New System.Drawing.Size(678, 47)
        Me.txtdireccion.TabIndex = 4
        Me.txtdireccion.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(70, 101)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Direccion:"
        '
        'txtTransportisat
        '
        Me.txtTransportisat.Location = New System.Drawing.Point(148, 139)
        Me.txtTransportisat.Name = "txtTransportisat"
        Me.txtTransportisat.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtTransportisat.Properties.AppearanceReadOnly.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTransportisat.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTransportisat.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTransportisat.Size = New System.Drawing.Size(381, 20)
        Me.txtTransportisat.TabIndex = 5
        Me.txtTransportisat.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(50, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Transportista:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(66, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Conductor:"
        '
        'txtConductor
        '
        Me.txtConductor.Location = New System.Drawing.Point(148, 165)
        Me.txtConductor.Name = "txtConductor"
        Me.txtConductor.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtConductor.Properties.AppearanceReadOnly.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConductor.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtConductor.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtConductor.Size = New System.Drawing.Size(381, 20)
        Me.txtConductor.TabIndex = 6
        Me.txtConductor.TabStop = False
        '
        'txtPlaca
        '
        Me.txtPlaca.Location = New System.Drawing.Point(677, 165)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtPlaca.Properties.AppearanceReadOnly.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPlaca.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtPlaca.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtPlaca.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlaca.Size = New System.Drawing.Size(149, 20)
        Me.txtPlaca.TabIndex = 8
        Me.txtPlaca.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(563, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Vehiculo Placa #:"
        '
        'GridDetalle
        '
        Me.GridDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDetalle.Location = New System.Drawing.Point(15, 224)
        Me.GridDetalle.MainView = Me.vDatos
        Me.GridDetalle.Name = "GridDetalle"
        Me.GridDetalle.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ItemArticulo, Me.ItemArticuloD})
        Me.GridDetalle.Size = New System.Drawing.Size(811, 173)
        Me.GridDetalle.TabIndex = 10
        Me.GridDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vDatos})
        '
        'vDatos
        '
        Me.vDatos.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.vDatos.Appearance.EvenRow.Options.UseBackColor = True
        Me.vDatos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn6, Me.GridColumn11, Me.GridColumn4, Me.GridColumn5, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.vDatos.GridControl = Me.GridDetalle
        Me.vDatos.Name = "vDatos"
        Me.vDatos.OptionsCustomization.AllowColumnMoving = False
        Me.vDatos.OptionsCustomization.AllowFilter = False
        Me.vDatos.OptionsCustomization.AllowGroup = False
        Me.vDatos.OptionsCustomization.AllowSort = False
        Me.vDatos.OptionsFilter.AllowColumnMRUFilterList = False
        Me.vDatos.OptionsFilter.AllowFilterEditor = False
        Me.vDatos.OptionsFilter.AllowMRUFilterList = False
        Me.vDatos.OptionsView.EnableAppearanceEvenRow = True
        Me.vDatos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.vDatos.OptionsView.ShowFooter = True
        Me.vDatos.OptionsView.ShowGroupPanel = False
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
        Me.GridColumn1.Width = 109
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
        Me.GridColumn2.Width = 243
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
        Me.GridColumn3.Width = 77
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn6.AppearanceHeader.Options.UseFont = True
        Me.GridColumn6.Caption = "UNIDAD"
        Me.GridColumn6.FieldName = "Unidad"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn11.AppearanceHeader.Options.UseFont = True
        Me.GridColumn11.Caption = "Precio U$"
        Me.GridColumn11.DisplayFormat.FormatString = "{0:n4}"
        Me.GridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn11.FieldName = "PrecioU"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PrecioU", "{0:n2}")})
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 4
        Me.GridColumn11.Width = 77
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
        Me.GridColumn4.DisplayFormat.FormatString = "{0:n4}"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "Precio"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Precio", "{0:n2}")})
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 5
        Me.GridColumn4.Width = 77
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
        Me.GridColumn5.Width = 88
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "IVA"
        Me.GridColumn7.DisplayFormat.FormatString = "{0:n2}"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Orden de Entrega #:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(346, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Fecha:"
        '
        'fecha
        '
        Me.fecha.EditValue = Nothing
        Me.fecha.Location = New System.Drawing.Point(398, 8)
        Me.fecha.Name = "fecha"
        Me.fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.fecha.Size = New System.Drawing.Size(131, 20)
        Me.fecha.TabIndex = 1
        Me.fecha.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(550, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Nota de Traslado #:"
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.btnNew)
        Me.PanelControl1.Controls.Add(Me.btnBuscarTraslado)
        Me.PanelControl1.Controls.Add(Me.btnBuscarOrden)
        Me.PanelControl1.Controls.Add(Me.btnQuit)
        Me.PanelControl1.Location = New System.Drawing.Point(15, 403)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(811, 48)
        Me.PanelControl1.TabIndex = 11
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(20, 9)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(90, 30)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "&Guardar"
        '
        'btnBuscarTraslado
        '
        Me.btnBuscarTraslado.Location = New System.Drawing.Point(218, 9)
        Me.btnBuscarTraslado.Name = "btnBuscarTraslado"
        Me.btnBuscarTraslado.Size = New System.Drawing.Size(96, 30)
        Me.btnBuscarTraslado.TabIndex = 2
        Me.btnBuscarTraslado.Text = "&Buscar Traslados"
        '
        'btnBuscarOrden
        '
        Me.btnBuscarOrden.Location = New System.Drawing.Point(116, 9)
        Me.btnBuscarOrden.Name = "btnBuscarOrden"
        Me.btnBuscarOrden.Size = New System.Drawing.Size(96, 30)
        Me.btnBuscarOrden.TabIndex = 1
        Me.btnBuscarOrden.Text = "&Buscar Ordenes"
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.Location = New System.Drawing.Point(707, 9)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(90, 30)
        Me.btnQuit.TabIndex = 3
        Me.btnQuit.Text = "&Salir"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(55, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Nº Remision:"
        '
        'txtNoRemision
        '
        Me.txtNoRemision.Location = New System.Drawing.Point(148, 6)
        Me.txtNoRemision.Name = "txtNoRemision"
        Me.txtNoRemision.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtNoRemision.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoRemision.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtNoRemision.Properties.Appearance.Options.UseBackColor = True
        Me.txtNoRemision.Properties.Appearance.Options.UseFont = True
        Me.txtNoRemision.Properties.Appearance.Options.UseForeColor = True
        Me.txtNoRemision.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtNoRemision.Properties.AppearanceReadOnly.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNoRemision.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtNoRemision.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtNoRemision.Properties.Mask.EditMask = "d"
        Me.txtNoRemision.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNoRemision.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNoRemision.Size = New System.Drawing.Size(137, 22)
        Me.txtNoRemision.TabIndex = 0
        Me.txtNoRemision.TabStop = False
        '
        'txtNoOrden
        '
        Me.txtNoOrden.EditValue = 0
        Me.txtNoOrden.Location = New System.Drawing.Point(148, 191)
        Me.txtNoOrden.Name = "txtNoOrden"
        Me.txtNoOrden.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtNoOrden.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOrden.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtNoOrden.Properties.Appearance.Options.UseBackColor = True
        Me.txtNoOrden.Properties.Appearance.Options.UseFont = True
        Me.txtNoOrden.Properties.Appearance.Options.UseForeColor = True
        Me.txtNoOrden.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtNoOrden.Properties.AppearanceReadOnly.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNoOrden.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtNoOrden.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtNoOrden.Properties.Mask.EditMask = "d"
        Me.txtNoOrden.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNoOrden.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNoOrden.Size = New System.Drawing.Size(137, 22)
        Me.txtNoOrden.TabIndex = 7
        Me.txtNoOrden.TabStop = False
        '
        'txtTraslado
        '
        Me.txtTraslado.EditValue = 0
        Me.txtTraslado.Location = New System.Drawing.Point(677, 191)
        Me.txtTraslado.Name = "txtTraslado"
        Me.txtTraslado.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtTraslado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTraslado.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtTraslado.Properties.Appearance.Options.UseBackColor = True
        Me.txtTraslado.Properties.Appearance.Options.UseFont = True
        Me.txtTraslado.Properties.Appearance.Options.UseForeColor = True
        Me.txtTraslado.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtTraslado.Properties.AppearanceReadOnly.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTraslado.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTraslado.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTraslado.Properties.Mask.EditMask = "d"
        Me.txtTraslado.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTraslado.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTraslado.Size = New System.Drawing.Size(149, 22)
        Me.txtTraslado.TabIndex = 9
        Me.txtTraslado.TabStop = False
        '
        'etTasa
        '
        Me.etTasa.EditValue = 1
        Me.etTasa.EnterMoveNextControl = True
        Me.etTasa.Location = New System.Drawing.Point(738, 60)
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
        Me.etTasa.TabIndex = 187
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(672, 67)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(66, 13)
        Me.Label29.TabIndex = 188
        Me.Label29.Text = "T/Cambio:"
        '
        'frmAgregarRemisiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 463)
        Me.Controls.Add(Me.etTasa)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.txtTraslado)
        Me.Controls.Add(Me.txtNoOrden)
        Me.Controls.Add(Me.txtNoRemision)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.GridDetalle)
        Me.Controls.Add(Me.txtPlaca)
        Me.Controls.Add(Me.txtConductor)
        Me.Controls.Add(Me.txtTransportisat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbclientes)
        Me.Controls.Add(Me.cmbcentrocosto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label19)
        Me.Name = "frmAgregarRemisiones"
        Me.Text = "*** REMISIONES DE PRODUCTOS ***"
        CType(Me.cmbcentrocosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbclientes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTransportisat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConductor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlaca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemArticuloD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.txtNoRemision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTraslado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etTasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbcentrocosto As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbclientes As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtdireccion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTransportisat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtConductor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPlaca As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GridDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents vDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemArticulo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemArticuloD As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBuscarOrden As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQuit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBuscarTraslado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNoRemision As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNoOrden As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTraslado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents etTasa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
End Class
