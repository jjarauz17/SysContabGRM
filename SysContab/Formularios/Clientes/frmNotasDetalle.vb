Imports DevExpress.XtraReports.UI

Public Class frmNotasDetalle

    Public IdNota As Integer = 0
    Public TipoDC As String = ""

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Close()
    End Sub

    Private Sub frmNotasDetalle_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cargar()
    End Sub

    Sub Cargar()
        Dim dt As DataTable = ObtieneDatos("JAR_GetDatosNota " & IdNota & ",0," & EmpresaActual)

        If dt.Rows.Count > 0 Then
            Tipo.Text = dt.Rows.Item(0)("Tipo")
            Numero.Text = dt.Rows.Item(0)("NoNota")
            Fecha.DateTime = dt.Rows.Item(0)("Fecha")
            Cliente.Text = dt.Rows.Item(0)("Cliente")
            Monto.EditValue = dt.Rows.Item(0)("Monto")
            Moneda.Text = IsNull(dt.Rows.Item(0)("Moneda"), "MONEDA NACIONAL")
            Comentario.Text = dt.Rows.Item(0)("Comentario")
        End If

        gridDatos.DataSource = ObtieneDatos("JAR_GetDatosNota " & IdNota & ",1," & EmpresaActual)
        vDatos.PopulateColumns()
        FormatoGrid(vDatos, 2, 0, False, False, False)

        Me.vDatos.Columns("Monto").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("Monto").DisplayFormat.FormatString = "{0:n2}"
        Me.vDatos.Columns("Monto").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("Monto").SummaryItem.DisplayFormat = "{0:n2}"

        Me.vDatos.Columns("Mnto. Valor").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("Mnto. Valor").DisplayFormat.FormatString = "{0:n2}"
        Me.vDatos.Columns("Mnto. Valor").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("Mnto. Valor").SummaryItem.DisplayFormat = "{0:n2}"

        Me.vDatos.BestFitColumns()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        ShowSplash("Imprimiendo...")
        '
        Dim rpt As New rptNotasProveedores
        rpt.pLogo.Image = frmPrincipalRibbon.pLogo.Image

        VistaPreviaDX(rpt,
                      ObtieneDatos("JAR_NotaClienteImprimir", IdNota, TipoDC, VB.SysContab.Rutinas.Letras(Monto.EditValue), EmpresaActual),
                      Tipo.Text & " NO. " & Numero.Text)
        '
        HideSplash()

        'rpt.ShowPrintMarginsWarning = False
        'rpt.BringToFront()
        'rpt.ShowRibbonPreview()
    End Sub

    Private Sub bExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(gridDatos)
    End Sub
End Class