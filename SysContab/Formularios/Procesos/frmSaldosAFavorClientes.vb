Public Class frmSaldosAFavorClientes

    Public IdCliente As Integer = 0
    Public Fecha As Date
    Public Monto As Double = 0
    Public IdNota As Integer = 0

    Private Sub frmSaldosAFavorClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Sub Cargar()

        iGrid.DataSource = ObtieneDatos("SET DATEFORMAT dmy; EXEC JAR_GetSaldosAFavorCliente " & IdCliente & ",'" & Fecha.Date & "', " & EmpresaActual)
        iVista.PopulateColumns()
        FormatoGrid(iVista)
        '
        iVista.Columns("IdNota").Visible = False

        iVista.Columns("Monto").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iVista.Columns("Monto").DisplayFormat.FormatString = "n2"
        iVista.Columns("Monto").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        iVista.Columns("Monto").SummaryItem.DisplayFormat = "{0:n2}"
        ''
        iVista.Columns("Aplicado").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iVista.Columns("Aplicado").DisplayFormat.FormatString = "n2"
        iVista.Columns("Aplicado").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        iVista.Columns("Aplicado").SummaryItem.DisplayFormat = "{0:n2}"
        ''
        iVista.Columns("Saldo").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iVista.Columns("Saldo").DisplayFormat.FormatString = "n2"
        iVista.Columns("Saldo").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        iVista.Columns("Saldo").SummaryItem.DisplayFormat = "{0:n2}"
        ''
        iVista.Columns("Saldo U$").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iVista.Columns("Saldo U$").DisplayFormat.FormatString = "n2"
        iVista.Columns("Saldo U$").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        iVista.Columns("Saldo U$").SummaryItem.DisplayFormat = "{0:n2}"

        iVista.Columns("Mnto. Valor").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iVista.Columns("Mnto. Valor").DisplayFormat.FormatString = "n2"
        iVista.Columns("Mnto. Valor").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        iVista.Columns("Mnto. Valor").SummaryItem.DisplayFormat = "{0:n2}"
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If iVista.FocusedRowHandle < 0 Then Exit Sub

        Monto = iVista.GetFocusedRowCellValue("Saldo")
        IdNota = iVista.GetFocusedRowCellValue("IdNota")

        Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub
End Class