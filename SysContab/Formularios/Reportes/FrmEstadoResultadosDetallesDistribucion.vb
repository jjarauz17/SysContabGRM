Public Class FrmEstadoResultadosDetallesDistribucion
    Inherits DevExpress.XtraEditors.XtraForm

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Me.Grid = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'Grid.EmbeddedNavigator
        '
        Me.Grid.EmbeddedNavigator.Name = ""
        GridLevelNode1.RelationName = "Level1"
        Me.Grid.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.LookAndFeel.SkinName = "The Asphalt World"
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.Grid.MainView = Me.GridView2
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(960, 546)
        Me.Grid.TabIndex = 2
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2, Me.GridView1})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn1, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn9})
        Me.GridView2.GridControl = Me.Grid
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowFooter = True

        Me.GridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn6, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Centro de Costos"
        Me.GridColumn2.FieldName = "Nombre"
        Me.GridColumn2.MinWidth = 40
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 237
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cuenta"
        Me.GridColumn1.FieldName = "cuenta"
        Me.GridColumn1.MinWidth = 40
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 95
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Comprobante"
        Me.GridColumn4.FieldName = "Comp_No"
        Me.GridColumn4.MinWidth = 100
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 101
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Debitos"
        Me.GridColumn5.DisplayFormat.FormatString = "{0:N}"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "Debitos"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.SummaryItem.DisplayFormat = "{0:N}"
        Me.GridColumn5.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 82
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Creditos"
        Me.GridColumn6.DisplayFormat.FormatString = "{0:N}"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "Creditos"
        Me.GridColumn6.MinWidth = 100
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.SummaryItem.DisplayFormat = "{0:N}"
        Me.GridColumn6.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 101
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Movimiento"
        Me.GridColumn9.DisplayFormat.FormatString = "{0:N}"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "Movimiento"
        Me.GridColumn9.GroupFormat.FormatString = "{0:N}"
        Me.GridColumn9.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True
        Me.GridColumn9.SummaryItem.DisplayFormat = "{0:N}"
        Me.GridColumn9.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 6
        Me.GridColumn9.Width = 71
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "Debitos", Nothing, "{0:n}")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn6, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Nombre"
        Me.GridColumn3.FieldName = "NombreCuenta"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 256
        '
        'FrmEstadoResultadosDetallesDistribucion
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(960, 546)
        Me.Controls.Add(Me.Grid)
        Me.Name = "FrmEstadoResultadosDetallesDistribucion"
        Me.Text = "FrmEstadoResultadosDetallesDistribucion"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class

