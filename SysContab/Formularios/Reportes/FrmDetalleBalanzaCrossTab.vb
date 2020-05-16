Public Class FrmDetalleBalanzaCrossTab
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
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    'Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdexportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rbDistribucion As System.Windows.Forms.RadioButton
    Friend WithEvents rbComprobantes As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmdexportar = New DevExpress.XtraEditors.SimpleButton()
        Me.rbDistribucion = New System.Windows.Forms.RadioButton()
        Me.rbComprobantes = New System.Windows.Forms.RadioButton()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.LookAndFeel.SkinName = "The Asphalt World"
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.Grid.MainView = Me.GridView2
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(1016, 526)
        Me.Grid.TabIndex = 2
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn1, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn3, Me.GridColumn10})
        Me.GridView2.GridControl = Me.Grid
        Me.GridView2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debitos", Me.GridColumn7, "{0:n}", 0), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Creditos", Me.GridColumn8, "{0:n}", "0")})
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn6, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Fecha"
        Me.GridColumn2.FieldName = "Fecha"
        Me.GridColumn2.MinWidth = 40
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cuenta"
        Me.GridColumn1.FieldName = "Cuenta"
        Me.GridColumn1.MinWidth = 40
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 98
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Nombre"
        Me.GridColumn4.FieldName = "Nombre"
        Me.GridColumn4.MinWidth = 100
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 182
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Comprobante"
        Me.GridColumn5.FieldName = "comp_no"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 127
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Concepto"
        Me.GridColumn6.FieldName = "comp_concepto"
        Me.GridColumn6.MinWidth = 100
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        Me.GridColumn6.Width = 234
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Debitos"
        Me.GridColumn7.DisplayFormat.FormatString = "{0:N}"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "Debitos"
        Me.GridColumn7.GroupFormat.FormatString = "{0:N}"
        Me.GridColumn7.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debitos", "{0:N}")})
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        Me.GridColumn7.Width = 95
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Creditos"
        Me.GridColumn8.DisplayFormat.FormatString = "{0:N}"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "Creditos"
        Me.GridColumn8.GroupFormat.FormatString = "{0:N}"
        Me.GridColumn8.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Creditos", "{0:N}")})
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        Me.GridColumn8.Width = 92
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
        Me.GridColumn9.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridColumn9.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Movimiento", "{0:N}")})
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 7
        Me.GridColumn9.Width = 92
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Per_Id"
        Me.GridColumn3.FieldName = "Per_Id"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "comp_id"
        Me.GridColumn10.FieldName = "comp_id"
        Me.GridColumn10.Name = "GridColumn10"
        '
        'cmdexportar
        '
        Me.cmdexportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdexportar.Location = New System.Drawing.Point(880, 4)
        Me.cmdexportar.Name = "cmdexportar"
        Me.cmdexportar.Size = New System.Drawing.Size(112, 26)
        Me.cmdexportar.TabIndex = 3
        Me.cmdexportar.Text = "&Exportar/Imprimir"
        '
        'rbDistribucion
        '
        Me.rbDistribucion.BackColor = System.Drawing.Color.Transparent
        Me.rbDistribucion.Location = New System.Drawing.Point(768, 0)
        Me.rbDistribucion.Name = "rbDistribucion"
        Me.rbDistribucion.Size = New System.Drawing.Size(336, 34)
        Me.rbDistribucion.TabIndex = 5
        Me.rbDistribucion.Text = "Distribución"
        Me.rbDistribucion.UseVisualStyleBackColor = False
        '
        'rbComprobantes
        '
        Me.rbComprobantes.BackColor = System.Drawing.Color.Transparent
        Me.rbComprobantes.Checked = True
        Me.rbComprobantes.Location = New System.Drawing.Point(640, 0)
        Me.rbComprobantes.Name = "rbComprobantes"
        Me.rbComprobantes.Size = New System.Drawing.Size(136, 34)
        Me.rbComprobantes.TabIndex = 4
        Me.rbComprobantes.TabStop = True
        Me.rbComprobantes.Text = "Comprobantes"
        Me.rbComprobantes.UseVisualStyleBackColor = False
        '
        'FrmDetalleBalanzaCrossTab
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 526)
        Me.Controls.Add(Me.cmdexportar)
        Me.Controls.Add(Me.rbDistribucion)
        Me.Controls.Add(Me.rbComprobantes)
        Me.Controls.Add(Me.Grid)
        Me.Name = "FrmDetalleBalanzaCrossTab"
        Me.Text = "FrmDetalleBalanzaCrossTab"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Public MonedaCambio As String

    Private Sub Grid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.DoubleClick
        Dim MyVista As DevExpress.XtraGrid.Views.Grid.GridView
        MyVista = Grid.MainView



        For Each i As Integer In MyVista.GetSelectedRows

            If Me.rbComprobantes.Checked Then

                If IsNumeric(MyVista.GetRowCellValue(i, "comp_id")) = False Then Exit Sub
                If CDbl(MyVista.GetRowCellValue(i, "comp_id")) = 0 Then Exit Sub

                Dim f As FrmComprobantesDetallesNew = FrmComprobantesDetallesNew.Instance()
                'f.Temp = True
                f.txtlNoComprobante.Text = MyVista.GetRowCellValue(i, "comp_id")
                f.Periodo = MyVista.GetRowCellValue(i, "Per_Id")
                f.Fecha.EditValue = MyVista.GetRowCellValue(i, "Fecha")
                f.Fecha1 = MyVista.GetRowCellValue(i, "Fecha")
                f.ComprobanteID = 0
                f.TipoLiq = 0
                f.StartPosition = FormStartPosition.CenterScreen
                f.cmdAceptar.Enabled = False
                f.cmdAnular.Enabled = False
                f.cmdAyuda.Enabled = False
                f.ShowDialog()



                'Dim f As DataGridTextBox.frmComprobantesDetalles = f.Instance
                'f.lblNoComprobante.Text = MyVista.GetRowCellValue(i, "comp_id")
                'f.lblPeriodo.Text = MyVista.GetRowCellValue(i, "Per_Id")
                'f.txtFecha.Text = MyVista.GetRowCellValue(i, "Fecha")
                'f.StartPosition = FormStartPosition.CenterScreen
                ''f.MdiParent = frmPrincipal.Instance
                'f.cmdAceptar.Enabled = False
                'f.cmdAnular.Enabled = False
                'f.cmdAyuda.Enabled = False
                ''Me.Close()
                'f.ShowDialog()

            Else
                Dim f As New FrmEstadoResultadosDetallesDistribucion
                f.Text = "Detalles de Distribución"
                f.StartPosition = FormStartPosition.CenterParent

                f.Grid.Parent = f
                f.Grid.Dock = DockStyle.Fill

                Dim a As String
                Dim Ds As New DataSet

                Ds = VB.SysContab.DistribucionDB.GetData(MyVista.GetRowCellValue(i, "comp_id"), _
                    MyVista.GetRowCellValue(i, "Per_Id"), MyVista.GetRowCellValue(i, "Fecha"), Me.MonedaCambio)


                f.Grid.DataSource = Ds.Tables(0)

                f.Width = 1024
                f.Height = 400
                f.ShowDialog()
                f.Dispose()

            End If


        Next


       
    End Sub

    Private Sub cmdexportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexportar.Click
        frmExportarImprimir.Mostrar(Grid, Me.Text)
        'Dim forma As New frmexportaciongrid
        'forma.Mostrar(Me.Grid)
    End Sub
End Class
