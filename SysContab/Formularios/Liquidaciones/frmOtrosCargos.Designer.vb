<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOtrosCargos
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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PreLiqID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LiqGastoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepcbGasto = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Monto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepcbGasto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepcbGasto})
        Me.GridControl1.Size = New System.Drawing.Size(359, 227)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PreLiqID, Me.LiqGastoID, Me.Monto})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'PreLiqID
        '
        Me.PreLiqID.Caption = "PreLiqID"
        Me.PreLiqID.FieldName = "PreLiqID"
        Me.PreLiqID.Name = "PreLiqID"
        '
        'LiqGastoID
        '
        Me.LiqGastoID.Caption = "Nombre del Gasto"
        Me.LiqGastoID.ColumnEdit = Me.RepcbGasto
        Me.LiqGastoID.FieldName = "LiqGastoID"
        Me.LiqGastoID.Name = "LiqGastoID"
        Me.LiqGastoID.Visible = True
        Me.LiqGastoID.VisibleIndex = 0
        Me.LiqGastoID.Width = 251
        '
        'RepcbGasto
        '
        Me.RepcbGasto.AutoHeight = False
        Me.RepcbGasto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepcbGasto.Name = "RepcbGasto"
        Me.RepcbGasto.NullText = ""
        '
        'Monto
        '
        Me.Monto.AppearanceCell.Options.UseTextOptions = True
        Me.Monto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Monto.AppearanceHeader.Options.UseTextOptions = True
        Me.Monto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Monto.Caption = "Monto"
        Me.Monto.DisplayFormat.FormatString = "n2"
        Me.Monto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Monto.FieldName = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.SummaryItem.DisplayFormat = "{0:n2}"
        Me.Monto.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Monto.Visible = True
        Me.Monto.VisibleIndex = 1
        Me.Monto.Width = 77
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(109, 245)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 1
        Me.cmdSave.Text = "&Continuar"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(198, 245)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 1
        Me.cmdCancel.Text = "&Salir"
        '
        'frmOtrosCargos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 276)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.GridControl1)
        Me.MaximizeBox = False
        Me.Name = "frmOtrosCargos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Otros Cargos"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepcbGasto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PreLiqID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LiqGastoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepcbGasto As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Monto As DevExpress.XtraGrid.Columns.GridColumn
End Class
