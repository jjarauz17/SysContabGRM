Imports System.IO
Imports System.Configuration
Imports System.Drawing.Imaging
Imports DevExpress.XtraReports.UI
Public Class FrmProduccionGenerar

    Dim obj As New Prod_Produccion
    Dim db As New db_Prod_Produccion

    Private Sub frmResponsables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date

        Desde.DateTime = New DateTime(f.Year, f.Month, 1).Date
        Hasta.DateTime = UltimoDiaDelMes(f.Date).Date

        Cargar()
        iVista.PopulateColumns()
        FormatoGrid(iVista)

        iVista.Columns("IdSysProduccion").Visible = False
        iVista.Columns("Fecha Finalización").Visible = False
        iVista.Columns("Fecha Autorización").Visible = False
        iVista.Columns("Fecha Generación").Visible = False
        iVista.Columns("Etiqueta").Visible = False
        iVista.Columns("Observaciones").Visible = False
        iVista.Columns("Pendiente").Visible = False
        iVista.Columns("Registro").Visible = False
        iVista.Columns("Formula").Width = 200
    End Sub

    Sub Cargar()
        iGrid.DataSource = db_Prod_Produccion.ListarGenear(0, Desde.DateTime.Date, Hasta.DateTime.Date)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If

        With frmProduccionEstado
            .Text = "Generando Producción"
            .IdProduccion = iVista.GetFocusedRowCellValue("IdSysProduccion")
            .ShowDialog()
            If .Ok = "SI" Then Cargar()
            .Dispose()
        End With
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        Inicio = 1
        FrmProduccionAdd.Dispose()
        With FrmProduccionAdd            
            .IdProduccion = iVista.GetFocusedRowCellValue("IdSysProduccion")
            .lyGuardar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            .lyActualizarCosto.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            .Text = "Ver Orden de Producción"
            .Show()
            .WindowState = FormWindowState.Normal
            .StartPosition = FormStartPosition.CenterScreen
        End With        
        Inicio = 0
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        frmExportarImprimir.Mostrar(iGrid)
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Close()
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If

        db_Prod_Produccion.Imprimir(iVista.GetFocusedRowCellValue("IdSysProduccion"), _
                                    iVista.GetFocusedRowCellValue("Etiqueta"))
    End Sub


    'Private Sub iVista_CustomUnboundColumnData(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles iVista.CustomUnboundColumnData
    '    If e.IsGetData Then
    '        Dim dr As DataRow = iVista.GetDataRow(e.ListSourceRowIndex)
    '        If dr Is Nothing Then
    '            Return
    '        End If
    '        Try
    '            If dr("Pendiente") AndAlso e.Column.FieldName = "Info" Then
    '                Dim img As Image = My.Resources.high
    '                e.Value = DevExpress.XtraEditors.Controls.ByteImageConverter.ToByteArray(img, ImageFormat.Gif)
    '            End If
    '        Catch ex As Exception
    '        End Try
    '    End If
    'End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        ShowSplash()
        Cargar()
        HideSplash()
    End Sub
End Class