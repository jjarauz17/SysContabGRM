Imports System.Data.SqlClient
Imports System.IO
Imports ClasesBLL
Imports DevExpress.Utils
Imports DevExpress.XtraReports.UI

Public Class frmRequisasImprimirEtiquetas

    Public Property req_codigo As Integer = 0

    Private Sub frmRequisasImprimirEtiquetas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Dispose()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dispose()
    End Sub

    Private Sub frmRequisasImprimirEtiquetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim _dt As DataTable = db_requisas.DetalleImprimirTicket(req_codigo)

        iGrid.DataSource = _dt
        iVista.PopulateColumns()
        SimpleFormatGrid(iVista, False, HorzAlignment.Center, 0, 2, False, 0, 1, 2, 3, 4, 5)
        '
        iVista.Columns("Descripcion").Width = 300
        iVista.Columns("Cantidad").OptionsColumn.AllowEdit = True
        iVista.Columns("Cantidad").ColumnEdit = rCantidad
        'iVista.Columns("#").OptionsColumn.AllowEdit = True
        '
        Dim rLink As New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        rLink.Caption = "Imprimir"
        '
        iVista.Columns("#").ColumnEdit = rLink
        iVista.Columns("#").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        '
        If _dt.Rows.Count > 0 Then
            txtCodigo.EditValue = _dt.Rows.Item(0)("req_codigo")
            txtReferencia.Text = _dt.Rows.Item(0)("Referencia")
            Fecha.DateTime = _dt.Rows.Item(0)("Fecha")
            txtBodega.Text = _dt.Rows.Item(0)("Bodega")
            txtTipo.Text = _dt.Rows.Item(0)("Tipo")
            txtTipoMovimiento.Text = _dt.Rows.Item(0)("TMovimiento")
        End If
    End Sub

    Private Sub txtReferencia_EditValueChanged(sender As Object, e As EventArgs) Handles txtReferencia.EditValueChanged

    End Sub

    Private Sub iVista_Click(sender As Object, e As EventArgs) Handles iVista.Click
        If iVista.FocusedRowHandle < 0 Then Exit Sub

        If iVista.FocusedColumn.FieldName = "#" Then
            '
            ShowSplash("Imprimiendo...")

            Try

                Dim rpt As rtpCodigoBarra

                If db_Formatos.FormatoImpreso(16, "RptCBarras") Then
                    rpt = XtraReport.FromFile(Application.StartupPath & "\RptCBarras.repx", True)
                Else
                    rpt = New rtpCodigoBarra
                End If
                '
                Dim DS As New DataSet
                Dim DA As New SqlDataAdapter("JAR_GetProductosCBarras 'P'," & EmpresaActual & ",'" & iVista.GetFocusedRowCellValue("Codigo") & "'", SysContab.VB.SysContab.Rutinas.AbrirConexion())

                For i As Integer = 0 To Math.Floor(CDbl(iVista.GetFocusedRowCellValue("Cantidad"))) - 1
                    DA.Fill(DS)
                Next

                rpt.DataSource = DS.Tables(0)

                HideSplash()
                rpt.ShowPrintMarginsWarning = False
                rpt.BringToFront()
                rpt.ShowRibbonPreview()

            Catch ex As Exception
                HideSplash()
                XtraMsg(ex.Message,
                        MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class