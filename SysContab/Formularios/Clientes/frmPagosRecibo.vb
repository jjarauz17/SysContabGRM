Imports ClasesBLL

Namespace DataGridTextBoxCombo
    Public Class frmPagosRecibo
        Inherits DevExpress.XtraEditors.XtraForm

#Region " C�digo generado por el Dise�ador de Windows Forms "

        Public Sub New()
            MyBase.New()

            'El Dise�ador de Windows Forms requiere esta llamada.
            InitializeComponent()

            'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

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

        'Requerido por el Dise�ador de Windows Forms
        Private components As System.ComponentModel.IContainer

        'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
        'Puede modificarse utilizando el Dise�ador de Windows Forms. 
        'No lo modifique con el editor de c�digo.
        Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents etTotalPagado As System.Windows.Forms.Label
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents etDiferencia As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents etTotalFactura As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents etCaja As System.Windows.Forms.Label
        Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents ItemBanco As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents ItemMoneda As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
            Me.etTotalPagado = New System.Windows.Forms.Label()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.etDiferencia = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.etTotalFactura = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.etCaja = New System.Windows.Forms.Label()
            Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.ItemBanco = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.ItemMoneda = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemBanco, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'cmdSalir
            '
            Me.cmdSalir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdSalir.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdSalir.Appearance.Options.UseFont = True
            Me.cmdSalir.Appearance.Options.UseForeColor = True
            Me.cmdSalir.Location = New System.Drawing.Point(8, 257)
            Me.cmdSalir.Name = "cmdSalir"
            Me.cmdSalir.Size = New System.Drawing.Size(72, 26)
            Me.cmdSalir.TabIndex = 27
            Me.cmdSalir.Text = "&Aceptar"
            '
            'etTotalPagado
            '
            Me.etTotalPagado.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etTotalPagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTotalPagado.ForeColor = System.Drawing.Color.Maroon
            Me.etTotalPagado.Location = New System.Drawing.Point(196, 285)
            Me.etTotalPagado.Name = "etTotalPagado"
            Me.etTotalPagado.Size = New System.Drawing.Size(112, 26)
            Me.etTotalPagado.TabIndex = 152
            Me.etTotalPagado.Text = "0.00"
            Me.etTotalPagado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.etTotalPagado.Visible = False
            '
            'Label22
            '
            Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label22.Location = New System.Drawing.Point(86, 285)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(104, 26)
            Me.Label22.TabIndex = 151
            Me.Label22.Text = "Total Pagado:"
            Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Label22.Visible = False
            '
            'etDiferencia
            '
            Me.etDiferencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etDiferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etDiferencia.ForeColor = System.Drawing.Color.Maroon
            Me.etDiferencia.Location = New System.Drawing.Point(400, 258)
            Me.etDiferencia.Name = "etDiferencia"
            Me.etDiferencia.Size = New System.Drawing.Size(112, 25)
            Me.etDiferencia.TabIndex = 154
            Me.etDiferencia.Text = "0.00"
            Me.etDiferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.etDiferencia.Visible = False
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(314, 258)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(80, 25)
            Me.Label2.TabIndex = 153
            Me.Label2.Text = "Diferencia:"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Label2.Visible = False
            '
            'etTotalFactura
            '
            Me.etTotalFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etTotalFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTotalFactura.ForeColor = System.Drawing.Color.Maroon
            Me.etTotalFactura.Location = New System.Drawing.Point(196, 258)
            Me.etTotalFactura.Name = "etTotalFactura"
            Me.etTotalFactura.Size = New System.Drawing.Size(112, 25)
            Me.etTotalFactura.TabIndex = 156
            Me.etTotalFactura.Text = "0.00"
            Me.etTotalFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.etTotalFactura.Visible = False
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(86, 258)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(104, 25)
            Me.Label3.TabIndex = 155
            Me.Label3.Text = "Total Factura:"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Label3.Visible = False
            '
            'etCaja
            '
            Me.etCaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etCaja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etCaja.Location = New System.Drawing.Point(840, 254)
            Me.etCaja.Name = "etCaja"
            Me.etCaja.Size = New System.Drawing.Size(80, 26)
            Me.etCaja.TabIndex = 157
            Me.etCaja.Text = "Caja"
            Me.etCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.etCaja.Visible = False
            '
            'GridControl1
            '
            Me.GridControl1.Location = New System.Drawing.Point(8, 9)
            Me.GridControl1.MainView = Me.GridView1
            Me.GridControl1.Name = "GridControl1"
            Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ItemBanco, Me.ItemMoneda})
            Me.GridControl1.Size = New System.Drawing.Size(912, 242)
            Me.GridControl1.TabIndex = 158
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
            Me.GridView1.OptionsCustomization.AllowRowSizing = True
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
            Me.GridColumn1.Caption = "Banco"
            Me.GridColumn1.ColumnEdit = Me.ItemBanco
            Me.GridColumn1.FieldName = "Banco"
            Me.GridColumn1.Name = "GridColumn1"
            Me.GridColumn1.Visible = True
            Me.GridColumn1.VisibleIndex = 0
            '
            'ItemBanco
            '
            ToolTipItem1.Text = "Agregar Banco"
            SuperToolTip1.Items.Add(ToolTipItem1)
            Me.ItemBanco.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, True, True, True, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, SuperToolTip1)})
            Me.ItemBanco.Name = "ItemBanco"
            Me.ItemBanco.NullText = ""
            Me.ItemBanco.ShowHeader = False
            '
            'GridColumn2
            '
            Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.GridColumn2.AppearanceHeader.Options.UseFont = True
            Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
            Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.GridColumn2.Caption = "No. Cheque"
            Me.GridColumn2.FieldName = "Cheque"
            Me.GridColumn2.Name = "GridColumn2"
            Me.GridColumn2.Visible = True
            Me.GridColumn2.VisibleIndex = 1
            '
            'GridColumn3
            '
            Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.GridColumn3.AppearanceHeader.Options.UseFont = True
            Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
            Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.GridColumn3.Caption = "Cuenta"
            Me.GridColumn3.FieldName = "Cuenta"
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
            Me.GridColumn4.Caption = "Monto"
            Me.GridColumn4.DisplayFormat.FormatString = "N2"
            Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn4.FieldName = "Monto"
            Me.GridColumn4.Name = "GridColumn4"
            Me.GridColumn4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Monto", "{0:n2}")})
            Me.GridColumn4.Visible = True
            Me.GridColumn4.VisibleIndex = 3
            '
            'GridColumn5
            '
            Me.GridColumn5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.GridColumn5.AppearanceHeader.Options.UseFont = True
            Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
            Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.GridColumn5.Caption = "Moneda"
            Me.GridColumn5.ColumnEdit = Me.ItemMoneda
            Me.GridColumn5.FieldName = "Moneda"
            Me.GridColumn5.Name = "GridColumn5"
            Me.GridColumn5.Visible = True
            Me.GridColumn5.VisibleIndex = 4
            '
            'ItemMoneda
            '
            Me.ItemMoneda.AutoHeight = False
            Me.ItemMoneda.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.ItemMoneda.Name = "ItemMoneda"
            Me.ItemMoneda.NullText = ""
            Me.ItemMoneda.ShowFooter = False
            Me.ItemMoneda.ShowHeader = False
            '
            'frmPagosRecibo
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(934, 320)
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
            Me.Name = "frmPagosRecibo"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemBanco, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemMoneda, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private Sub frmPagosRecibo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            GetItemMonedasList(ItemMoneda)
            CargarCombo()
            GridControl1.DataSource = DT_Cheques

            Totales()
        End Sub

        Sub CargarCombo()
            ItemBanco.DataSource = db_BancosCK.Listar() '.ObtieneDatos("SELECT IdBanco Codigo, b.Nombre FROM BancosCK b WHERE b.Empresa = " & EmpresaActual)
            ItemBanco.DisplayMember = "Nombre"
            ItemBanco.ValueMember = "IdBanco"
            ItemBanco.PopulateColumns()
            ItemBanco.Columns(0).Visible = False
        End Sub

        Private Sub Totales()
            etTotalFactura.Text = Format(TotalFactura, "n2")
            TotalCheques = GridView1.Columns("Monto").SummaryItem.SummaryValue
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
                GridView1.UpdateTotalSummary()
                Totales()
            End If
        End Sub

        Private Sub GridView1_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView1.ValidateRow
            With GridView1
                If IsNull(.GetRowCellValue(e.RowHandle, "Banco"), 0) = 0 Or IsNull(.GetRowCellValue(e.RowHandle, "Cheque"), 0) = 0 Or
                IsNull(.GetRowCellValue(e.RowHandle, "Monto"), 0) = 0 Or
                IsNull(.GetRowCellValue(e.RowHandle, "Moneda"), 0) = 0 Then
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

        Private Sub ItemBanco_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ItemBanco.ButtonClick
            If e.Button.Index = 1 Then
                frmBancosCK.Dispose()
                frmBancosCK.IdBanco = 0
                frmBancosCK.ShowDialog()
                If frmBancosCK.Ok = "SI" Then CargarCombo()
            End If
        End Sub
    End Class

End Namespace

