Public Class FrmDetalleCrossTab
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
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents cmdexportar As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Grid = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmdexportar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(1016, 546)
        Me.Grid.TabIndex = 0
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2, Me.GridView1})
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.Grid
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowFooter = True
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'cmdexportar
        '
        Me.cmdexportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdexportar.Location = New System.Drawing.Point(880, 9)
        Me.cmdexportar.Name = "cmdexportar"
        Me.cmdexportar.Size = New System.Drawing.Size(112, 24)
        Me.cmdexportar.TabIndex = 8
        Me.cmdexportar.Text = "&Exportar/Imprimir"
        '
        'FrmDetalleCrossTab
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 546)
        Me.Controls.Add(Me.cmdexportar)
        Me.Controls.Add(Me.Grid)
        Me.Name = "FrmDetalleCrossTab"
        Me.Text = "FrmDetalleCrossTab"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub Grid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.DoubleClick
        Dim MyVista As DevExpress.XtraGrid.Views.Grid.GridView
        MyVista = Grid.MainView
        For Each i As Integer In MyVista.GetSelectedRows
            'If IsNumeric(MyVista.GetRowCellValue(i, "comp_id")) = False Then Exit Sub
            'If CDbl(MyVista.GetRowCellValue(i, "comp_id")) = 0 Then Exit Sub
            'Dim f As DataGridTextBox.frmComprobantesDetalles = DataGridTextBox.frmComprobantesDetalles.Instance
            'f.lblNoComprobante.Text = MyVista.GetRowCellValue(i, "comp_id")
            'f.lblPeriodo.Text = MyVista.GetRowCellValue(i, "Per_Id")
            'f.txtFecha.Text = MyVista.GetRowCellValue(i, "comp_fecha")
            'f.StartPosition = FormStartPosition.CenterScreen
            ''f.MdiParent = frmPrincipal.Instance
            'f.cmdAceptar.Enabled = False
            'f.cmdAnular.Enabled = False
            'f.cmdAyuda.Enabled = False
            ''Me.Close()
            'f.ShowDialog()
        Next
    End Sub

    Private Sub cmdexportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexportar.Click
        frmExportarImprimir.Mostrar(Grid, Me.Text)
        'Dim forma As New frmexportaciongrid
        'forma.Mostrar(Me.GridView2)
    End Sub
End Class
