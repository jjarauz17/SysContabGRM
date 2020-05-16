Public Class frmBcosConc_Detalle
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
    Friend WithEvents dgDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents Vista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents frmBcosConc_DetalleConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents btnQuit As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dgDatos = New DevExpress.XtraGrid.GridControl()
        Me.Vista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnQuit = New DevExpress.XtraEditors.SimpleButton()
        Me.frmBcosConc_DetalleConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.btnExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmBcosConc_DetalleConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmBcosConc_DetalleConvertedLayout.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgDatos
        '
        Me.dgDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDatos.Location = New System.Drawing.Point(24, 87)
        Me.dgDatos.MainView = Me.Vista
        Me.dgDatos.Name = "dgDatos"
        Me.dgDatos.Size = New System.Drawing.Size(936, 451)
        Me.dgDatos.TabIndex = 7
        Me.dgDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Vista})
        '
        'Vista
        '
        Me.Vista.GridControl = Me.dgDatos
        Me.Vista.Name = "Vista"
        Me.Vista.OptionsView.ShowAutoFilterRow = True
        Me.Vista.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Vista.OptionsView.ShowFooter = True
        Me.Vista.OptionsView.ShowGroupPanel = False
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.Appearance.Options.UseTextOptions = True
        Me.btnQuit.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnQuit.ImageOptions.Image = Global.SysContab.My.Resources.Resources._115
        Me.btnQuit.Location = New System.Drawing.Point(862, 45)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(98, 38)
        Me.btnQuit.StyleController = Me.frmBcosConc_DetalleConvertedLayout
        Me.btnQuit.TabIndex = 9
        Me.btnQuit.Text = "&Salir"
        '
        'frmBcosConc_DetalleConvertedLayout
        '
        Me.frmBcosConc_DetalleConvertedLayout.Controls.Add(Me.btnQuit)
        Me.frmBcosConc_DetalleConvertedLayout.Controls.Add(Me.btnExportar)
        Me.frmBcosConc_DetalleConvertedLayout.Controls.Add(Me.dgDatos)
        Me.frmBcosConc_DetalleConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmBcosConc_DetalleConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.frmBcosConc_DetalleConvertedLayout.Name = "frmBcosConc_DetalleConvertedLayout"
        Me.frmBcosConc_DetalleConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(692, 340, 250, 350)
        Me.frmBcosConc_DetalleConvertedLayout.Root = Me.LayoutControlGroup1
        Me.frmBcosConc_DetalleConvertedLayout.Size = New System.Drawing.Size(984, 562)
        Me.frmBcosConc_DetalleConvertedLayout.TabIndex = 9
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportar.Appearance.Options.UseTextOptions = True
        Me.btnExportar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnExportar.ImageOptions.Image = Global.SysContab.My.Resources.Resources.RibbonUserDesigner_RedoLarge
        Me.btnExportar.Location = New System.Drawing.Point(728, 45)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(130, 38)
        Me.btnExportar.StyleController = Me.frmBcosConc_DetalleConvertedLayout
        Me.btnExportar.TabIndex = 8
        Me.btnExportar.Text = "&Exportar Datos"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(984, 562)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup2.CustomizationFormText = "DETALLE CONCILIACION # 00001"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.EmptySpaceItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "GroupControl1item"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(964, 542)
        Me.LayoutControlGroup2.Text = "DETALLE CONCILIACION # 00001"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.btnQuit
        Me.LayoutControlItem1.CustomizationFormText = "btnQuititem"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(838, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem1.Name = "btnQuititem"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.btnExportar
        Me.LayoutControlItem2.CustomizationFormText = "btnExportaritem"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(704, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(134, 42)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(134, 42)
        Me.LayoutControlItem2.Name = "btnExportaritem"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(134, 42)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.dgDatos
        Me.LayoutControlItem3.CustomizationFormText = "dgDatositem"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem3.Name = "dgDatositem"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(940, 455)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(704, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmBcosConc_Detalle
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(984, 562)
        Me.Controls.Add(Me.frmBcosConc_DetalleConvertedLayout)
        Me.LookAndFeel.SkinName = "Blue"
        Me.Name = "frmBcosConc_Detalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "*** CONCILIACION BANCARIA - DETALLE ***"
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmBcosConc_DetalleConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmBcosConc_DetalleConvertedLayout.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Codigo As String

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        frmExportarImprimir.Mostrar(dgDatos)
    End Sub

    Private Sub frmBcosConc_Detalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        ArmarGrid()
    End Sub

    Sub Cargar()
        Me.dgDatos.DataSource = ObtieneDatos("_GetListConciliacion_Bancaria_Detalle '" & Codigo & "', " & EmpresaActual)
    End Sub

    Sub ArmarGrid()
        Me.Vista.PopulateColumns()
        FormatoGrid(Me.Vista)

        For i As Integer = 0 To Vista.Columns.Count - 1
            Vista.Columns(i).OptionsColumn.AllowEdit = False
        Next

        Vista.Columns("Conciliado").OptionsColumn.AllowEdit = True

        Me.Vista.Columns("Codigo").Visible = False
        Me.Vista.Columns("DetID").Visible = False



        'Me.Vista.PopulateColumns()
        'FormatoGrid(Me.Vista)

        'Me.Vista.Columns("Codigo").Visible = False
        'Me.Vista.Columns("DetID").Visible = False

        'Me.Vista.Columns("Comprobante").BestFit()
        'Me.Vista.Columns("Documento").BestFit()
        'Me.Vista.Columns("Debitos").BestFit()
        'Me.Vista.Columns("Creditos").BestFit()
        Me.Vista.Columns("Concepto").Width = 300

        Me.Vista.Columns("Debitos").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Vista.Columns("Debitos").DisplayFormat.FormatString = "n2"
        Me.Vista.Columns("Debitos").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Vista.Columns("Debitos").SummaryItem.DisplayFormat = "{0:n2}"

        Me.Vista.Columns("Creditos").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Vista.Columns("Creditos").DisplayFormat.FormatString = "n2"
        Me.Vista.Columns("Creditos").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Vista.Columns("Creditos").SummaryItem.DisplayFormat = "{0:n2}"
    End Sub

    Private Sub Vista_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles Vista.CellValueChanged
        If e.Column.FieldName = "Conciliado" Then
            If Not XtraMsg2("Esta Seguro de la Opción Solicitada?" & vbCrLf & _
                        "Este afectará los saldos de la Conciliación.") Then                
                Exit Sub
            End If
            '
            GuardaDatos("UPDATE ComprobantesDetalles SET conciliado = " & IIf(Vista.GetRowCellValue(e.RowHandle, "Conciliado"), 1, 0) & " WHERE cdet_id = " & Vista.GetRowCellValue(e.RowHandle, "DetID"))
            GuardaDatos("UPDATE Conciliacion_Bancaria_Detalle SET conciliado = " & IIf(Vista.GetRowCellValue(e.RowHandle, "Conciliado"), 1, 0) & " WHERE cb_detid =" & Vista.GetRowCellValue(e.RowHandle, "DetID"))
            '
            Cargar()
        End If
    End Sub
End Class

