Namespace DataGridTextBoxCombo
    Public Class frmPagosReciboTarjeta
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
        Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents etTotalFactura As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents etTotalPagado As System.Windows.Forms.Label
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents etDiferencia As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents etCaja As System.Windows.Forms.Label
        Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents ItemTipoTarjeta As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents ItemEmisor As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
            Me.etTotalFactura = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.etTotalPagado = New System.Windows.Forms.Label()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.etDiferencia = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.etCaja = New System.Windows.Forms.Label()
            Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.ItemTipoTarjeta = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.ItemEmisor = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
            CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemTipoTarjeta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemEmisor, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'cmdSalir
            '
            Me.cmdSalir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdSalir.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdSalir.Appearance.Options.UseFont = True
            Me.cmdSalir.Appearance.Options.UseForeColor = True
            Me.cmdSalir.Location = New System.Drawing.Point(16, 261)
            Me.cmdSalir.Name = "cmdSalir"
            Me.cmdSalir.Size = New System.Drawing.Size(72, 26)
            Me.cmdSalir.TabIndex = 29
            Me.cmdSalir.Text = "&Aceptar"
            '
            'etTotalFactura
            '
            Me.etTotalFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etTotalFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTotalFactura.ForeColor = System.Drawing.Color.Maroon
            Me.etTotalFactura.Location = New System.Drawing.Point(208, 262)
            Me.etTotalFactura.Name = "etTotalFactura"
            Me.etTotalFactura.Size = New System.Drawing.Size(112, 25)
            Me.etTotalFactura.TabIndex = 162
            Me.etTotalFactura.Text = "0.00"
            Me.etTotalFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.etTotalFactura.Visible = False
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(96, 262)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(104, 25)
            Me.Label3.TabIndex = 161
            Me.Label3.Text = "Total Factura:"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Label3.Visible = False
            '
            'etTotalPagado
            '
            Me.etTotalPagado.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etTotalPagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTotalPagado.ForeColor = System.Drawing.Color.Maroon
            Me.etTotalPagado.Location = New System.Drawing.Point(207, 287)
            Me.etTotalPagado.Name = "etTotalPagado"
            Me.etTotalPagado.Size = New System.Drawing.Size(112, 26)
            Me.etTotalPagado.TabIndex = 158
            Me.etTotalPagado.Text = "0.00"
            Me.etTotalPagado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.etTotalPagado.Visible = False
            '
            'Label22
            '
            Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label22.Location = New System.Drawing.Point(96, 287)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(104, 26)
            Me.Label22.TabIndex = 157
            Me.Label22.Text = "Total Pagado:"
            Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Label22.Visible = False
            '
            'etDiferencia
            '
            Me.etDiferencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etDiferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etDiferencia.ForeColor = System.Drawing.Color.Maroon
            Me.etDiferencia.Location = New System.Drawing.Point(427, 262)
            Me.etDiferencia.Name = "etDiferencia"
            Me.etDiferencia.Size = New System.Drawing.Size(112, 25)
            Me.etDiferencia.TabIndex = 160
            Me.etDiferencia.Text = "0.00"
            Me.etDiferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.etDiferencia.Visible = False
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(341, 262)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(80, 25)
            Me.Label2.TabIndex = 159
            Me.Label2.Text = "Diferencia:"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Label2.Visible = False
            '
            'etCaja
            '
            Me.etCaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etCaja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etCaja.Location = New System.Drawing.Point(840, 258)
            Me.etCaja.Name = "etCaja"
            Me.etCaja.Size = New System.Drawing.Size(80, 26)
            Me.etCaja.TabIndex = 163
            Me.etCaja.Text = "Caja"
            Me.etCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.etCaja.Visible = False
            '
            'GridControl1
            '
            Me.GridControl1.Location = New System.Drawing.Point(16, 9)
            Me.GridControl1.MainView = Me.GridView1
            Me.GridControl1.Name = "GridControl1"
            Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ItemTipoTarjeta, Me.ItemEmisor})
            Me.GridControl1.Size = New System.Drawing.Size(904, 246)
            Me.GridControl1.TabIndex = 164
            Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
            '
            'GridView1
            '
            Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
            Me.GridView1.GridControl = Me.GridControl1
            Me.GridView1.Name = "GridView1"
            Me.GridView1.OptionsCustomization.AllowColumnMoving = False
            Me.GridView1.OptionsCustomization.AllowColumnResizing = False
            Me.GridView1.OptionsCustomization.AllowFilter = False
            Me.GridView1.OptionsCustomization.AllowGroup = False
            Me.GridView1.OptionsCustomization.AllowSort = False
            Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            Me.GridView1.OptionsView.ShowGroupPanel = False
            '
            'GridColumn1
            '
            Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.GridColumn1.AppearanceHeader.Options.UseFont = True
            Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
            Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.GridColumn1.Caption = "Tipo Tarjeta"
            Me.GridColumn1.ColumnEdit = Me.ItemTipoTarjeta
            Me.GridColumn1.FieldName = "Tipo"
            Me.GridColumn1.Name = "GridColumn1"
            Me.GridColumn1.Visible = True
            Me.GridColumn1.VisibleIndex = 0
            '
            'ItemTipoTarjeta
            '
            Me.ItemTipoTarjeta.AutoHeight = False
            Me.ItemTipoTarjeta.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.ItemTipoTarjeta.Name = "ItemTipoTarjeta"
            Me.ItemTipoTarjeta.NullText = ""
            Me.ItemTipoTarjeta.ShowFooter = False
            Me.ItemTipoTarjeta.ShowHeader = False
            '
            'GridColumn2
            '
            Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.GridColumn2.AppearanceHeader.Options.UseFont = True
            Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
            Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.GridColumn2.Caption = "Emisor"
            Me.GridColumn2.ColumnEdit = Me.ItemEmisor
            Me.GridColumn2.FieldName = "Emisor"
            Me.GridColumn2.Name = "GridColumn2"
            Me.GridColumn2.Visible = True
            Me.GridColumn2.VisibleIndex = 1
            '
            'ItemEmisor
            '
            Me.ItemEmisor.AutoHeight = False
            Me.ItemEmisor.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.ItemEmisor.Name = "ItemEmisor"
            Me.ItemEmisor.NullText = ""
            Me.ItemEmisor.ShowFooter = False
            Me.ItemEmisor.ShowHeader = False
            '
            'GridColumn3
            '
            Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.GridColumn3.AppearanceHeader.Options.UseFont = True
            Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
            Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.GridColumn3.Caption = "No. Tarjeta"
            Me.GridColumn3.FieldName = "Tarjeta"
            Me.GridColumn3.Name = "GridColumn3"
            Me.GridColumn3.Visible = True
            Me.GridColumn3.VisibleIndex = 2
            '
            'GridColumn4
            '
            Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.GridColumn4.AppearanceHeader.Options.UseFont = True
            Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
            Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.GridColumn4.Caption = "Cod. Autorizacion"
            Me.GridColumn4.FieldName = "Autorizacion"
            Me.GridColumn4.Name = "GridColumn4"
            Me.GridColumn4.Visible = True
            Me.GridColumn4.VisibleIndex = 3
            '
            'GridColumn5
            '
            Me.GridColumn5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.GridColumn5.AppearanceHeader.Options.UseFont = True
            Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
            Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.GridColumn5.Caption = "Monto"
            Me.GridColumn5.FieldName = "Monto"
            Me.GridColumn5.Name = "GridColumn5"
            Me.GridColumn5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Monto", "{0:n2}")})
            Me.GridColumn5.Visible = True
            Me.GridColumn5.VisibleIndex = 4
            '
            'frmPagosReciboTarjeta
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(934, 323)
            Me.Controls.Add(Me.GridControl1)
            Me.Controls.Add(Me.etCaja)
            Me.Controls.Add(Me.etTotalFactura)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.etTotalPagado)
            Me.Controls.Add(Me.Label22)
            Me.Controls.Add(Me.etDiferencia)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.cmdSalir)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmPagosReciboTarjeta"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemTipoTarjeta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemEmisor, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private Sub frmPagosReciboTarjeta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ItemEmisor.DataSource = ObtieneDatos("SELECT emisor_id Codigo,emisor_nombre Nombre FROM Emisores WHERE Empresa_id = " & EmpresaActual)
            ItemEmisor.DisplayMember = "Nombre"
            ItemEmisor.ValueMember = "Codigo"
            ItemEmisor.PopulateColumns()
            ItemEmisor.Columns(0).Visible = False

            ItemTipoTarjeta.DataSource = ObtieneDatos("SELECT tarjeta_id Codigo,tarjeta_nombre Nombre FROM Tarjetas WHERE Empresa_id = " & EmpresaActual)
            ItemTipoTarjeta.DisplayMember = "Nombre"
            ItemTipoTarjeta.ValueMember = "Codigo"
            ItemTipoTarjeta.PopulateColumns()
            ItemTipoTarjeta.Columns(0).Visible = False

            GridControl1.DataSource = DT_Tarjetas

            Totales()
        End Sub

        Private Sub Totales()
            etTotalFactura.Text = Format(TotalFactura, "n2")
            TotalTarjetas = GridView1.Columns("Monto").SummaryItem.SummaryValue
            etTotalPagado.Text = Format(TotalCheques + TotalEfectivo + TotalTarjetas, "n2")
            etDiferencia.Text = Format(TotalFactura - (TotalCheques + TotalEfectivo + TotalTarjetas), "n2")
        End Sub

        Private Sub GridView1_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView1.RowUpdated
            GridView1.UpdateTotalSummary()
            Totales()
        End Sub

        Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
            If e.KeyCode = Keys.Delete Then
                GridView1.DeleteRow(GridView1.FocusedRowHandle)
            End If
        End Sub

        Private Sub GridView1_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView1.ValidateRow
            With GridView1
                If IsNull(.GetRowCellValue(e.RowHandle, "Tipo"), 0) = 0 Or IsNull(.GetRowCellValue(e.RowHandle, "Emisor"), 0) = 0 Or _
                IsNull(.GetRowCellValue(e.RowHandle, "Tarjeta"), 0) = 0 Or IsNull(.GetRowCellValue(e.RowHandle, "Autorizacion"), 0) = 0 Or _
                IsNull(.GetRowCellValue(e.RowHandle, "Monto"), 0) = 0 Then
                    e.ErrorText = "Complete la informacion" & vbCrLf
                    e.Valid = False
                End If
            End With
        End Sub

        Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
            'If CDbl(etDiferencia.Text) < 0 Then
            '    MsgBox("No se puede pagar de mas", MsgBoxStyle.Information)
            '    Exit Sub
            'End If
            Close()
        End Sub
    End Class

End Namespace
