Imports System.IO
Imports DevExpress.XtraReports.UI
Public Class FrmProduccion

    Dim obj As New Prod_Produccion
    Dim db As New db_Prod_Produccion

    Private Sub frmResponsables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date

        Desde.DateTime = New DateTime(f.Year, f.Month, 1).Date
        Hasta.DateTime = UltimoDiaDelMes(f.Date).Date

        Combo(cbEstado, db_Prod_EstadoProduccion.Listar(0))

        Dim db_Estado As New db_Prod_EstadoProduccion
        Dim Estados As String = db_Estado.GetTipoEstadoOrden(1).ToString & ", " + db_Estado.GetTipoEstadoOrden(2).ToString & ", " + db_Estado.GetTipoEstadoOrden(3).ToString
        cbEstado.SetEditValue(Estados)

        Cargar()
        FormatoGrid(iVista)
        '
        iVista.Columns("IdSysProduccion").Visible = False
        iVista.Columns("Fecha Autorización").Visible = False
        iVista.Columns("Cantidad Real").Visible = False
        iVista.Columns("Observaciones").Visible = False
        iVista.Columns("Etapa").Visible = False
        iVista.Columns("Producto Terminado").Width = 250
    End Sub

    Sub Cargar()
        iGrid.DataSource = db_Prod_Produccion.Listar(0, cbEstado.EditValue, Desde.DateTime.Date, Hasta.DateTime.Date)
        iVista.Columns("Etiqueta").ColumnEdit = rColor
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ShowSplash("Cargando Orden...")
        Inicio = 1
        FrmProduccionAdd.Dispose()
        FrmProduccionAdd.MdiParent = Me.MdiParent
        FrmProduccionAdd.IdProduccion = 0
        FrmProduccionAdd.Show()
        FrmProduccionAdd.Text = "Crear Orden de Producción"
        FrmProduccionAdd.WindowState = FormWindowState.Maximized
        Inicio = 0
        HideSplash()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        ShowSplash("Cargando Orden...")
        Inicio = 1
        FrmProduccionAdd.Dispose()
        FrmProduccionAdd.MdiParent = Me.MdiParent
        FrmProduccionAdd.IdProduccion = iVista.GetFocusedRowCellValue("IdSysProduccion")
        FrmProduccionAdd.bGuardar.Enabled = IIf(iVista.GetFocusedRowCellValue("Etapa") = "O" Or iVista.GetFocusedRowCellValue("Etapa") = "P", True, False)
        FrmProduccionAdd.bActualizar.Enabled = IIf(iVista.GetFocusedRowCellValue("Etapa") = "O" Or iVista.GetFocusedRowCellValue("Etapa") = "P", True, False)
        FrmProduccionAdd.Show()
        FrmProduccionAdd.Text = "Editar Orden de Producción"
        FrmProduccionAdd.WindowState = FormWindowState.Maximized
        Inicio = 0
        HideSplash()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '

        If iVista.GetFocusedRowCellValue("Etapa") = "F" Or _
            iVista.GetFocusedRowCellValue("Etapa") = "A" Or _
            iVista.GetFocusedRowCellValue("Etapa") = "B" Then
            XtraMsg("La Orden de Producción no se puede Anular cuando se encuentra en este Estado: " & iVista.GetFocusedRowCellValue("Estado"), MessageBoxIcon.Warning)
            Exit Sub
        End If
        '

        Dim msg As String = ""

        If iVista.GetFocusedRowCellValue("Etapa") = "O" Then msg = "Esta Seguro de Anular la Orden de Producción Número: " & iVista.GetFocusedRowCellValue("Numero") & "?"
        If iVista.GetFocusedRowCellValue("Etapa") = "P" Then msg = "La Orden de Producción Número: " & iVista.GetFocusedRowCellValue("Numero") & " se encuentra en estado de Producción, " & vbCrLf & "Esta seguro de Anularla?"


        If Not XtraMsg2(msg) Then
            Exit Sub
        End If

        obj.IdSysProduccion = iVista.GetFocusedRowCellValue("IdSysProduccion")        
        db.Anular(obj)
        Cargar()
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

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        With FrmConfiguraCheque
            .Tipo = 7
            .Text = "Diseño de Orden de Producción"
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked Then iVista.ShowCustomization()
        If Not CheckEdit1.Checked Then iVista.DestroyCustomization()
    End Sub

    Private Sub iVista_HideCustomizationForm(sender As Object, e As EventArgs) Handles iVista.HideCustomizationForm
        CheckEdit1.Checked = False
    End Sub

    Private Sub cbEstado_EditValueChanged(sender As Object, e As EventArgs) Handles cbEstado.EditValueChanged
        If Not Inicio Then
            ShowSplash("Cargando Ordenes...")
            Cargar()
            HideSplash()
        End If

    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        ShowSplash()
        Cargar()
        HideSplash()
    End Sub
End Class