Public Class frmSairi

    Private Sub frmSairi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cargar()
    End Sub

    Sub Cargar()
        Me.FDesde.DateTime = Now.Date
        Me.FHasta.DateTime = Now.Date     
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        My.Forms.frmExportarImprimir.Mostrar(Me.dgDatos)
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Me.dgDatos.DataSource = VB.SysContab.SAIRI.Sairi_Facturas(Me.FDesde.DateTime.Date, Me.FHasta.DateTime.Date).Tables("Ir")
        Me.vDatos.PopulateColumns()
        FormatoGrid(Me.vDatos)
        '
        '
        'Me.vDatos.Columns("Linea").Visible = False

        Me.vDatos.Columns("MONTO").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("MONTO").DisplayFormat.FormatString = "{0:n2}"
        Me.vDatos.Columns("MONTO").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("MONTO").SummaryItem.DisplayFormat = "{0:n2}"

        Me.vDatos.Columns("IVA").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("IVA").DisplayFormat.FormatString = "{0:n2}"
        Me.vDatos.Columns("IVA").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("IVA").SummaryItem.DisplayFormat = "{0:n2}"

        Me.vDatos.Columns("IR").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("IR").DisplayFormat.FormatString = "{0:n2}"
        Me.vDatos.Columns("IR").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("IR").SummaryItem.DisplayFormat = "{0:n2}"

        Me.vDatos.BestFitColumns()

        'Me.SFD.InitialDirectory = Application.StartupPath()
        'Me.SFD.Filter = "Text Files (*.txt)|*.txt"
        'Me.SFD.FilterIndex = 1
        'Me.SFD.RestoreDirectory = True
        'Me.SFD.FileName = Application.StartupPath() & "\xml\IR_Sairi_" & Format(Me.FDesde.DateTime.Date, "ddMMyyyy") & "_" & Format(Me.FHasta.DateTime.Date, "ddMMyyyy") & ".txt"

        'If SFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        '    Try
        '        If VB.SysContab.SAIRIdB.ExportarTXT(ds.Tables("Ir"), Me.SFD.FileName, Longitud_Linea_Archivos.SAIRI) Then
        '            MsgBox("Archivo generado satisfactoriamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        '        Else
        '            MsgBox("El archivo no pudo ser generado. Consulte con al Administrador del Sistema", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        '        End If
        '    Catch Ex As Exception
        '        MessageBox.Show("No se puede escribir el archivo. Error original: " & Ex.Message)
        '        Exit Sub
        '    Finally

        '    End Try
        'End If
    End Sub


    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        If sender.checked = True Then Me.vDatos.ColumnsCustomization() Else Me.vDatos.DestroyCustomization()
    End Sub
End Class