Public Class frmAjusteInventario 

    Private Sub frmAjusteInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fecha.EditValue = VB.SysContab.Rutinas.Fecha().Date
    End Sub

    Sub Buscar()
        Dim Desde As New DateTime(Fecha.DateTime.Year, Fecha.DateTime.Month, 1)
        iGrid.DataSource = ObtieneDatos("SET DATEFORMAT dmy; EXEC jar_GetAjusteInventario '" & Desde.Date & "','" & Fecha.DateTime.Date & "',1," & EmpresaActual)
        iVista.PopulateColumns()
        FormatoGrid(iVista)

        iVista.Columns("Existencia").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iVista.Columns("Existencia").DisplayFormat.FormatString = "{0:n4}"
        'iVista.Columns("Existencia").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        'iVista.Columns("Existencia").SummaryItem.DisplayFormat = "{0:n4}"
        '
        iVista.Columns("Costo Salida").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iVista.Columns("Costo Salida").DisplayFormat.FormatString = "{0:n6}"
        'iVista.Columns("Costo Salida").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        'iVista.Columns("Costo Salida").SummaryItem.DisplayFormat = "{0:n6}"
        '
        iVista.Columns("Primer Entrada").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iVista.Columns("Primer Entrada").DisplayFormat.FormatString = "{0:n4}"
        'iVista.Columns("Primer Entrada").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        'iVista.Columns("Primer Entrada").SummaryItem.DisplayFormat = "{0:n4}"
        '
        iVista.Columns("Costo Entrada").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iVista.Columns("Costo Entrada").DisplayFormat.FormatString = "{0:n6}"
        'iVista.Columns("Costo Entrada").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        'iVista.Columns("Costo Entrada").SummaryItem.DisplayFormat = "{0:n6}"
        '
        iVista.Columns("Ajuste").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iVista.Columns("Ajuste").DisplayFormat.FormatString = "{0:n2}"   

        iVista.Columns("Clase").Group()
        iVista.ExpandAllGroups()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ShowSplash("Cargando Ajustes...")
        Buscar()
        HideSplash()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim Desde As New DateTime(Fecha.DateTime.Year, Fecha.DateTime.Month, 1)

        frmContabilizarAjusteInventario.Desde = Desde.Date
        frmContabilizarAjusteInventario.Hasta = Fecha.DateTime.Date
        frmContabilizarAjusteInventario.Fecha.DateTime = Fecha.DateTime.Date
        frmContabilizarAjusteInventario.Text = "Contabilizar Ajuste de Inventario"
        frmContabilizarAjusteInventario.ShowDialog()
        frmContabilizarAjusteInventario.Dispose()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        frmExportarImprimir.Mostrar(iGrid)
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Close()
    End Sub
End Class