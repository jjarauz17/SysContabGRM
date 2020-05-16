Imports System.IO
Imports System.Configuration
Imports System.Drawing.Imaging
Imports DevExpress.XtraReports.UI
Public Class frmSolicitudesVencimientos

    Dim obj As New SolicitudesVencimiento
    Dim db As New db_SolicitudesVencimiento

    Private Sub frmResponsables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Combo(cbEstado, db_SolicitudesVencimiento.GetEstados())
        cbEstado.SetEditValue("S")

        Cargar()
        iVista.PopulateColumns()
        FormatoGrid(iVista)

        iVista.Columns("IdSolicitud").Visible = False
        iVista.Columns("Fecha_Aprobada").Visible = False        
        iVista.Columns("Fecha_Denegada").Visible = False
        iVista.Columns("Correo").Visible = False
        iVista.Columns("Usuario_Aprueba").Visible = False
        iVista.Columns("Usuario_Deniega").Visible = False        
        iVista.Columns("Registro").Visible = False        
    End Sub

    Sub Cargar()
        iGrid.DataSource = db_SolicitudesVencimiento.Listar(0, cbEstado.EditValue)
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        frmExportarImprimir.Mostrar(iGrid)
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Close()
    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        ShowSplash("Cargando Solicitud...")
        frmSolicitudAprobar.Dispose()
        frmSolicitudAprobar.MdiParent = Me.MdiParent
        frmSolicitudAprobar.Text = "Nueva Solicitud"
        frmSolicitudAprobar.IdSolicitud = iVista.GetFocusedRowCellValue("IdSolicitud")
        frmSolicitudAprobar.Show()
        frmSolicitudAprobar.WindowState = FormWindowState.Maximized
        HideSplash()
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
            ShowSplash("Cargando Solicitudes...")
            Cargar()
            HideSplash()
        End If
    End Sub

    Private Sub iVista_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles iVista.RowCellStyle
        If e.Column.FieldName = "Estado" Then
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            e.Appearance.Font = New Font("Thaoma", 8.75, FontStyle.Bold)
            If iVista.GetRowCellValue(e.RowHandle, "Estado") = "Enviada" Then
                e.Appearance.BackColor = Color.Tomato
            ElseIf iVista.GetRowCellValue(e.RowHandle, "Estado") = "Aprobado" Then
                e.Appearance.BackColor = Color.Green
            ElseIf iVista.GetRowCellValue(e.RowHandle, "Estado") = "Denegado" Then
                e.Appearance.BackColor = Color.Red
            End If
        End If
    End Sub
End Class