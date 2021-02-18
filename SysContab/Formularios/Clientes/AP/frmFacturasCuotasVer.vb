Imports DevExpress.XtraGrid.Views.Grid
Imports Entities

Public Class frmFacturasCuotasVer

    Private _Id As Integer = 0

    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property

    Private _IdArreglo As Integer
    Public Property IdArreglo() As Integer
        Get
            Return _IdArreglo
        End Get
        Set(ByVal value As Integer)
            _IdArreglo = value
        End Set
    End Property

    Dim DT_DETALLE As DataTable,
        DT_AP As DataTable,
        dbDetalle As New db_FacturasCuotasDetalle

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub

    Private Sub frmFacturasCuotasVer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DT_DETALLE = dbDetalle.Listar(Id, EmpresaActual)
        iGridAP.DataSource = DT_DETALLE
        iVistaAP.PopulateColumns()
        FormatoGridNew(iVistaAP, 2, 2, False, False)
        '
        iVistaAP.Columns("IdDetalle").Visible = False
        iVistaAP.Columns("Vencimiento").Visible = False
        iVistaAP.Columns("Aplicada").Visible = False
        iVistaAP.Columns("Interes").Visible = False

        iGrid.DataSource = db_ArregloPagoDetalle.Listar(IdArreglo)
        iVista.PopulateColumns()
        FormatoGridNew(iVista, 2, 2, False, False)
        '
        iVista.Columns("IdDetalle").Visible = False
        iVista.Columns("Interes").Visible = False
        iVista.Columns("Aplicada").Visible = False
        iVista.Columns("FechaPago").Visible = False

        If IdArreglo > 0 Then TabbedControlGroup1.SelectedTabPageIndex = 1
    End Sub

    Private Sub frmFacturasCuotasVer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Close()
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles iGrid.Click

    End Sub

    Private Sub iVistaAP_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles iVistaAP.RowCellStyle
        If e.Column.FieldName = "Status" Then
            e.Appearance.BackColor = Color.LightGray
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            If iVistaAP.GetRowCellValue(e.RowHandle, "Status") = "CORRIENTE" Then
                e.Appearance.ForeColor = Color.DarkGreen
            ElseIf iVistaAP.GetRowCellValue(e.RowHandle, "Status") = "VENCIDO" Then
                e.Appearance.ForeColor = Color.OrangeRed
            End If
        End If

        If e.Column.FieldName = "Aplicada" Then
            If iVistaAP.GetRowCellValue(e.RowHandle, "Aplicada") Then
                e.Appearance.BackColor = Color.LimeGreen
            Else
                e.Appearance.BackColor = Color.Tomato
            End If
        End If
    End Sub

    Private Sub iVista_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles iVista.RowCellStyle
        If e.Column.FieldName = "Status" Then
            e.Appearance.BackColor = Color.LightGray
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            If iVista.GetRowCellValue(e.RowHandle, "Status") = "CORRIENTE" Then
                e.Appearance.ForeColor = Color.DarkGreen
            ElseIf iVista.GetRowCellValue(e.RowHandle, "Status") = "VENCIDO" Then
                e.Appearance.ForeColor = Color.OrangeRed
            End If
        End If
    End Sub
End Class