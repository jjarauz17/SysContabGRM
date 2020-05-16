Namespace Win_Dashboards
    Partial Public Class frmDashboard
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim ChartPane1 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim GridMeasureColumn1 As DevExpress.DashboardCommon.GridMeasureColumn = New DevExpress.DashboardCommon.GridMeasureColumn()
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutGroup2 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutGroup3 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem3 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem4 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.CardDashboardItem1 = New DevExpress.DashboardCommon.CardDashboardItem()
            Me.ChartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.GaugeDashboardItem1 = New DevExpress.DashboardCommon.GaugeDashboardItem()
            Me.GridDashboardItem1 = New DevExpress.DashboardCommon.GridDashboardItem()
            CType(Me.CardDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GaugeDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'CardDashboardItem1
            '
            Me.CardDashboardItem1.ComponentName = "CardDashboardItem1"
            Me.CardDashboardItem1.DataItemRepository.Clear()
            Me.CardDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.CardDashboardItem1.Name = "Cards 1"
            Me.CardDashboardItem1.ShowCaption = True
            '
            'ChartDashboardItem1
            '
            Me.ChartDashboardItem1.AxisX.TitleVisible = False
            Me.ChartDashboardItem1.ComponentName = "ChartDashboardItem1"
            Me.ChartDashboardItem1.DataItemRepository.Clear()
            Me.ChartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.ChartDashboardItem1.Name = "Chart 1"
            ChartPane1.Name = "Pane 1"
            ChartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.PrimaryAxisY.ShowGridLines = True
            ChartPane1.PrimaryAxisY.TitleVisible = True
            ChartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.SecondaryAxisY.ShowGridLines = False
            ChartPane1.SecondaryAxisY.TitleVisible = True
            Me.ChartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane1})
            Me.ChartDashboardItem1.ShowCaption = True
            '
            'GaugeDashboardItem1
            '
            Me.GaugeDashboardItem1.ComponentName = "GaugeDashboardItem1"
            Me.GaugeDashboardItem1.DataItemRepository.Clear()
            Me.GaugeDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.GaugeDashboardItem1.Name = "Gauges 1"
            Me.GaugeDashboardItem1.ShowCaption = True
            '
            'GridDashboardItem1
            '
            GridMeasureColumn1.Name = "Suma"
            GridMeasureColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            Me.GridDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.GridColumnBase() {GridMeasureColumn1})
            Me.GridDashboardItem1.ComponentName = "GridDashboardItem1"
            Me.GridDashboardItem1.DataItemRepository.Clear()
            Me.GridDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.GridDashboardItem1.Name = "Grid 1"
            Me.GridDashboardItem1.ShowCaption = True
            '
            'frmDashboard
            '
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.CardDashboardItem1, Me.ChartDashboardItem1, Me.GridDashboardItem1, Me.GaugeDashboardItem1})
            DashboardLayoutItem1.DashboardItem = Me.CardDashboardItem1
            DashboardLayoutItem1.Weight = 50.0R
            DashboardLayoutItem2.DashboardItem = Me.ChartDashboardItem1
            DashboardLayoutItem2.Weight = 50.0R
            DashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1, DashboardLayoutItem2})
            DashboardLayoutGroup2.DashboardItem = Nothing
            DashboardLayoutGroup2.Weight = 50.061957868649316R
            DashboardLayoutItem3.DashboardItem = Me.GaugeDashboardItem1
            DashboardLayoutItem3.Weight = 50.0R
            DashboardLayoutItem4.DashboardItem = Me.GridDashboardItem1
            DashboardLayoutItem4.Weight = 50.0R
            DashboardLayoutGroup3.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem3, DashboardLayoutItem4})
            DashboardLayoutGroup3.DashboardItem = Nothing
            DashboardLayoutGroup3.Weight = 49.938042131350684R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutGroup2, DashboardLayoutGroup3})
            DashboardLayoutGroup1.DashboardItem = Nothing
            DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            Me.LayoutRoot = DashboardLayoutGroup1
            Me.Title.Text = "Dashboard"
            CType(Me.CardDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GaugeDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        Friend WithEvents CardDashboardItem1 As DevExpress.DashboardCommon.CardDashboardItem
        Friend WithEvents ChartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents GridDashboardItem1 As DevExpress.DashboardCommon.GridDashboardItem
        Friend WithEvents GaugeDashboardItem1 As DevExpress.DashboardCommon.GaugeDashboardItem

#End Region
    End Class
End Namespace