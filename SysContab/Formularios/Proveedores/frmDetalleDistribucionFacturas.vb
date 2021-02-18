Imports DevExpress.XtraEditors.Repository

Public Class frmDetalleDistribucionFacturas

    Public ok As String = ""
    Public DT As New DataTable

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        ok = "NO"
        DT = Nothing
        Me.Close()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        ok = "SI"
        Me.Close()
    End Sub

    Private Sub frmDetalleDistribucionFacturas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'DT.AcceptChanges()
        '
        If DT Is Nothing Or DT.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim DT_NEW As DataTable
        DT_NEW = DT.GetChanges(DataRowState.Added Or DataRowState.Modified)

        If DT_NEW Is Nothing Then DT_NEW = DT

        Dim cbRubro As New RepositoryItemLookUpEdit
        cbRubro.ShowFooter = False

        Dim cbCentro As New RepositoryItemLookUpEdit
        cbCentro.ShowFooter = False

        RepositoryItemLookUpEdit(
                cbRubro,
                ObtieneDatos("sp_sel_RubroGastos", "%", EmpresaActual),
                "Nombre",
                "Codigo",
                0, 2, 3, 4, 5, 6)

        RepositoryItemLookUpEdit(
                cbCentro,
                ObtieneDatos("sp_sel_CentroDeCosto", 0, 0, EmpresaActual),
                "Nombre",
                "Codigo",
                0, 2)

        'For i As Integer = 0 To DT_NEW.Rows.Count - 1
        '    DT_NEW.Rows.Item(i)("Rubro") = ObtieneDatos("SELECT rg.Nombre FROM RubrosGastos rg WHERE rg.Codigo = " & DT_NEW.Rows.Item(i)("IdRubroGasto") & " AND rg.Empresa = " & EmpresaActual).Rows.Item(0)(0)
        '    DT_NEW.Rows.Item(i)("Centro") = ObtieneDatos("SELECT cdc.Nombre FROM CentroDeCosto cdc WHERE cdc.Codigo = " & DT_NEW.Rows.Item(i)("IdCentroCosto") & " AND cdc.Empresa = " & EmpresaActual).Rows.Item(0)(0)
        'Next

        gridDetalle.DataSource = DT_NEW.DefaultView
        vDistribucion.Columns("IdRubroGasto").ColumnEdit = cbRubro
        vDistribucion.Columns("IdCentroCosto").ColumnEdit = cbCentro

        FormatoGrid(vDistribucion, 2, 0, False, False, False)
    End Sub
End Class