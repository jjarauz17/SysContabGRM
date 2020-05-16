Public Class frmDetalleVentasCostos

    Public Desde As Date, Hasta As Date
    Public Caja As Integer, Tipo As Integer

    Private Sub frmDetalleVentasCostos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowSplash("Generando Reporte...")
        Cargar()
        HideSplash()
    End Sub

    Sub Cargar()
        Dim Datos As New ArrayList
        Dim Variables As New ArrayList

        Variables.Add("Desde")
        Variables.Add("Hasta")
        Variables.Add("Caja")
        Variables.Add("fp")
        Variables.Add("Empresa")

        Datos.Add(Desde.Date)
        Datos.Add(Hasta.Date)
        Datos.Add(Caja)
        Datos.Add(Tipo)
        Datos.Add(EmpresaActual)

        dgDatos.DataSource = ProcedureParameters(Datos, Variables, "JAR_GetVentaDetalle_Todo")
        Me.vDatos.PopulateColumns()
        FormatoGrid(Me.vDatos)
        ''
        Me.vDatos.Columns("CANTIDAD").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("CANTIDAD").DisplayFormat.FormatString = "{0:n4}"
        Me.vDatos.Columns("CANTIDAD").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("CANTIDAD").SummaryItem.DisplayFormat = "{0:n4}"
        ''
        Me.vDatos.Columns("PRECIO").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("PRECIO").DisplayFormat.FormatString = "{0:n4}"
        Me.vDatos.Columns("PRECIO").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("PRECIO").SummaryItem.DisplayFormat = "{0:n4}"
        ''
        Me.vDatos.Columns("C. UNITARIO").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("C. UNITARIO").DisplayFormat.FormatString = "{0:n6}"
        Me.vDatos.Columns("C. UNITARIO").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("C. UNITARIO").SummaryItem.DisplayFormat = "{0:n6}"
        ''
        Me.vDatos.Columns("COSTO TOTAL").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("COSTO TOTAL").DisplayFormat.FormatString = "{0:n6}"
        Me.vDatos.Columns("COSTO TOTAL").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("COSTO TOTAL").SummaryItem.DisplayFormat = "{0:n6}"
        ''
        Me.vDatos.Columns("TOTAL").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("TOTAL").DisplayFormat.FormatString = "{0:n2}"
        Me.vDatos.Columns("TOTAL").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("TOTAL").SummaryItem.DisplayFormat = "{0:n2}"

        ''Me.vDatos.BestFitColumns()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        frmExportarImprimir.Mostrar(dgDatos)
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Close()
    End Sub
End Class