Imports DevExpress.XtraGrid.Views.Base


Public Class frmMercaderiaTransito
    'Inherits System.Windows.Forms.Form
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmMercaderiaTransito = Nothing

    Public Shared Function Instance() As frmMercaderiaTransito
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmMercaderiaTransito
        End If
        ChildInstance.BringToFront()
        Return ChildInstance
    End Function

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
    Friend WithEvents cmdAprobar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRevision As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcTransito As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvTransito As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents vProducts As New DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents vExpenses As New DevExpress.XtraGrid.Views.Grid.GridView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridLevelNode3 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim GridLevelNode4 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gcTransito = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gvTransito = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAprobar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRevision = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcTransito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTransito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.gcTransito
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsCustomization.AllowColumnMoving = False
        Me.GridView2.OptionsCustomization.AllowColumnResizing = False
        '
        'gcTransito
        '
        Me.gcTransito.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridLevelNode3.LevelTemplate = Me.GridView2
        GridLevelNode3.RelationName = "Products"
        GridLevelNode4.LevelTemplate = Me.GridView3
        GridLevelNode4.RelationName = "Expenses"
        Me.gcTransito.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode3, GridLevelNode4})
        Me.gcTransito.Location = New System.Drawing.Point(12, 56)
        Me.gcTransito.MainView = Me.gvTransito
        Me.gcTransito.Name = "gcTransito"
        Me.gcTransito.Size = New System.Drawing.Size(1002, 478)
        Me.gcTransito.TabIndex = 7
        Me.gcTransito.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3, Me.gvTransito, Me.GridView2})
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.gcTransito
        Me.GridView3.Name = "GridView3"
        '
        'gvTransito
        '
        Me.gvTransito.GridControl = Me.gcTransito
        Me.gvTransito.Name = "gvTransito"
        Me.gvTransito.OptionsView.ShowAutoFilterRow = True
        Me.gvTransito.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvTransito.OptionsView.ShowFooter = True
        Me.gvTransito.OptionsView.ShowGroupPanel = False
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("Tahoma", 9.5!)
        Me.cmdExit.Appearance.ForeColor = System.Drawing.Color.Red
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.Appearance.Options.UseForeColor = True
        Me.cmdExit.Image = Global.SysContab.My.Resources.Resources.SalirFrm
        Me.cmdExit.Location = New System.Drawing.Point(934, 12)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 35)
        Me.cmdExit.TabIndex = 5
        Me.cmdExit.Text = "&Salir"
        '
        'cmdAprobar
        '
        Me.cmdAprobar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.5!)
        Me.cmdAprobar.Appearance.Options.UseFont = True
        Me.cmdAprobar.Image = Global.SysContab.My.Resources.Resources.ALiquidar
        Me.cmdAprobar.Location = New System.Drawing.Point(12, 12)
        Me.cmdAprobar.Name = "cmdAprobar"
        Me.cmdAprobar.Size = New System.Drawing.Size(90, 35)
        Me.cmdAprobar.TabIndex = 5
        Me.cmdAprobar.Text = "&Liqudiar"
        '
        'cmdRevision
        '
        Me.cmdRevision.Appearance.Font = New System.Drawing.Font("Tahoma", 9.5!)
        Me.cmdRevision.Appearance.Options.UseFont = True
        Me.cmdRevision.Image = Global.SysContab.My.Resources.Resources.ARevisar
        Me.cmdRevision.Location = New System.Drawing.Point(108, 12)
        Me.cmdRevision.Name = "cmdRevision"
        Me.cmdRevision.Size = New System.Drawing.Size(90, 35)
        Me.cmdRevision.TabIndex = 5
        Me.cmdRevision.Text = "&Revisión"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.5!)
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Image = Global.SysContab.My.Resources.Resources.RibbonUserDesigner_RedoLarge
        Me.SimpleButton1.Location = New System.Drawing.Point(204, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(95, 35)
        Me.SimpleButton1.TabIndex = 8
        Me.SimpleButton1.Text = "&Exportar"
        '
        'frmMercaderiaTransito
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 547)
        Me.ControlBox = False
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.gcTransito)
        Me.Controls.Add(Me.cmdRevision)
        Me.Controls.Add(Me.cmdAprobar)
        Me.Controls.Add(Me.cmdExit)
        Me.Name = "frmMercaderiaTransito"
        Me.Text = "Mercaderia en Tránsito"
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcTransito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTransito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim DT As DataTable

    Private Sub frmMercaderiaTransito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DS As New DataSet
        Dim DT, DT1, DT2 As New DataTable
        DT = ObtieneDatos("SPJ_LiqMecTransitoList " & EmpresaActual)
        DT.TableName = "MT"
        DT1 = ObtieneDatos("SPJ_LiqMecTransitoArtDetalle " & EmpresaActual) : DT1.TableName = "Products"
        DT2 = ObtieneDatos("SPJ_LiqMecTransitoGastosDetalle " & EmpresaActual) : DT2.TableName = "Expenses"

        DS.Tables.Add(DT) : DS.Tables.Add(DT1) : DS.Tables.Add(DT2)
        DS.Relations.Add("Productos", DT.Columns("MTID"), DT1.Columns("MTID"), False)
        DS.Relations.Add("Gastos", DT.Columns("MTID"), DT2.Columns("MTID"), False)

        gcTransito.DataSource = DS.Tables("MT")
        gcTransito.ForceInitialize()
        gvTransito.OptionsBehavior.Editable = False

        'GridView2.PopulateColumns(DS.Tables("Products"))
        'GridView3.PopulateColumns(DS.Tables("Expenses"))

        gvTransito.Columns("Fecha").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        gvTransito.Columns("Fecha").DisplayFormat.FormatString = "dd-MMM-yyyy"
        gvTransito.Columns("MTID").Visible = False
        '
        FormatoGrid(Me.gvTransito)
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    'Private Sub txtRegistro_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    For i As Integer = 0 To GridView1.DataRowCount - 1
    '        GridView1.SetRowCellValue(i, "Registro", GridView1.GetRowCellValue(i, "ValorFob") / GridView1.Columns(2).SummaryItem.SummaryValue * Me.txtRegistro.EditValue)
    '        GridView1.SetRowCellValue(i, "Total", GridView1.GetRowCellValue(i, "ValorFob") + GridView1.GetRowCellValue(i, "Registro"))
    '    Next
    'End Sub

    Private Sub cmdAprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAprobar.Click
        ObtieneDatos("UPDATE Liquidaciones_MercaderiaTransito SET Estado = 2 WHERE MTID=" & gvTransito.GetFocusedRowCellValue("MTID"))
        frmMercaderiaTransito_Load(Nothing, Nothing)
    End Sub

    Private Sub gvTransito_MasterRowExpanded(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs) Handles gvTransito.MasterRowExpanded
        If sender.FocusedRowHandle >= 0 Then
            vProducts = sender.GetVisibleDetailView(sender.focusedrowHandle)
            If Not vProducts Is Nothing Then
                vProducts.Columns("MTID").Visible = False
                vProducts.OptionsCustomization.AllowColumnMoving = False
                vProducts.OptionsCustomization.AllowColumnResizing = False
                '
                FormatoGrid(vProducts)
            End If
        End If
    End Sub

    Private Sub gvTransito_MasterRowGetRelationCount(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs) Handles gvTransito.MasterRowGetRelationCount
        'e.RelationCount
        e.RelationCount = 3
    End Sub

    Private Sub cmdRevision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRevision.Click
        ObtieneDatos("UPDATE Liquidaciones_MercaderiaTransito SET Estado = 3 WHERE MTID=" & gvTransito.GetFocusedRowCellValue("MTID"))
        frmMercaderiaTransito_Load(Nothing, Nothing)
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        My.Forms.frmExportarImprimir.Mostrar(gcTransito)
    End Sub
End Class
