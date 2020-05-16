Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.DataAccess
Imports DevExpress.DashboardCommon

Namespace Win_Dashboards
    Partial Public Class frmDashboard
        Inherits DevExpress.DashboardCommon.Dashboard
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub frmDashboard_DashboardLoading(sender As Object, e As EventArgs) Handles Me.DashboardLoading

        End Sub
    End Class
End Namespace