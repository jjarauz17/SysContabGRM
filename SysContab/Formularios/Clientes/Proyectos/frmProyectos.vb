Imports System.IO
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Public Class frmProyectos

    Dim obj As New Proyectos
    Dim db As New db_Proyectos

    Private Sub frmResponsables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(LayoutControl2)
        '
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        Desde.DateTime = New DateTime(f.Year, f.Month, 1).Date
        Hasta.DateTime = UltimoDiaDelMes(f.Date)

        Cargar()
        FormatoGrid(iVista)
        '
        iVista.Columns("IdProyecto").Visible = False
        iVista.Columns("Descripcion").Visible = False
        iVista.Columns("Registro").Visible = False
    End Sub

    Public Sub Cargar()
        iGrid.DataSource = db_Proyectos.Listar(0, Desde.DateTime.Date, Hasta.DateTime.Date)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        With frmProyectAdd
            .IdProyecto = 0
            .lyEtapa.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            .Text = "Agregar Proyecto"
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Editar()
    End Sub

    Sub Editar()
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '

        Dim Estado As Boolean = IIf((iVista.GetFocusedRowCellValue("Etapa") = "Final" Or iVista.GetFocusedRowCellValue("Etapa") = "Anulado"), False, True)

        With frmProyectAdd
            .IdProyecto = iVista.GetFocusedRowCellValue("IdProyecto")
            .Text = "Editar Proyecto: " & iVista.GetFocusedRowCellValue("Codigo").ToString
            If Estado Then
                .lblEtapa.Appearance.BackColor = Color.LightGreen
                .lblEtapa.Appearance.BackColor2 = Color.DarkGreen
            Else
                .lblEtapa.Appearance.BackColor = Color.Pink
                .lblEtapa.Appearance.BackColor2 = Color.DarkRed
            End If
            .lblEtapa.ForeColor = Color.MidnightBlue
            .lblEtapa.Text = "Etapa del Proyecto: " & iVista.GetFocusedRowCellValue("Etapa").ToString
            .bGuardar.Enabled = Estado
            .bGuardarSalir.Enabled = Estado
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        If Not XtraMsg2("Esta Seguro de la Acción Solicitada?") Then
            Exit Sub
        End If
        '
        obj.IdProyecto = iVista.GetFocusedRowCellValue("IdProyecto")
        obj.msg = ""

        Dim msg As String = db.Borrar(obj)

        If msg = "OK" Then
            Cargar()
        Else
            XtraMsg("El Proyecto " & iVista.GetFocusedRowCellValue("Codigo") & " - " & iVista.GetFocusedRowCellValue("Nombre") & " no se puede Borrar porque " & vbCrLf &
                    msg.Replace("/", vbCrLf), MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        frmExportarImprimir.Mostrar(iGrid)
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Close()
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        ShowSplash()
        Cargar()
        HideSplash()
    End Sub

    Private Sub iVista_DoubleClick(sender As Object, e As EventArgs) Handles iVista.DoubleClick
        Editar()
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        ShowSplash()
        frmProyectosVer.Dispose()
        '
        With New frmProyectosVer
            .IdProyecto = iVista.GetFocusedRowCellValue("IdProyecto")
            .Text = "Costo del Proyecto: " & iVista.GetFocusedRowCellValue("Codigo").ToString
            .Show()
        End With
        '
        HideSplash()
    End Sub

    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs) Handles SimpleButton9.Click
        With FrmConfiguraCheque
            .Tipo = 26
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro", MessageBoxIcon.Information)
            Exit Sub
        End If
        '
        db_Proyectos.Imprimir(iVista.GetFocusedRowCellValue("IdProyecto"))
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked Then iVista.ShowCustomization()
        If Not CheckEdit1.Checked Then iVista.DestroyCustomization()
    End Sub

    Private Sub iVista_HideCustomizationForm(sender As Object, e As EventArgs) Handles iVista.HideCustomizationForm
        CheckEdit1.Checked = False
    End Sub

    Private Sub bProcesar_Click(sender As Object, e As EventArgs) Handles bProcesar.Click
        ShowSplash("Generando Costos...")
        frmProyectosProcesar.Dispose()
        With frmProyectosProcesar
            .MdiParent = Me.MdiParent
            .fDesde.DateTime = Desde.DateTime.Date
            .fHasta.DateTime = Hasta.DateTime.Date
            .Text = "Procesar Proyectos"
            .Cargar(Desde.DateTime.Date, Hasta.DateTime.Date)
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
        HideSplash()
    End Sub

    Private Sub iVista_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles iVista.RowCellStyle
        If e.Column.FieldName = "Procesado" Then

            If iVista.GetRowCellValue(e.RowHandle, "Procesado") Then
                e.Appearance.BackColor = Color.LightGreen
            End If
        End If

        If e.Column.FieldName = "Etapa" Then
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            e.Appearance.ForeColor = Color.MidnightBlue
            e.Appearance.Font = New Font("Tahoma", 9, FontStyle.Bold)

            If iVista.GetRowCellValue(e.RowHandle, "Etapa") = "Inicial" Or
                iVista.GetRowCellValue(e.RowHandle, "Etapa") = "En Proceso" Then
                e.Appearance.BackColor = Color.LightGreen
                e.Appearance.BackColor2 = Color.DarkGreen
            ElseIf iVista.GetRowCellValue(e.RowHandle, "Etapa") = "Final" Or
                    e.Appearance.BackColor = Color.Pink Then
                e.Appearance.BackColor2 = Color.DarkRed
            Else
                e.Appearance.BackColor2 = Color.Tomato
            End If

        End If
    End Sub

    Private Sub bLiquidar_Click(sender As Object, e As EventArgs) Handles bLiquidar.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        If iVista.GetFocusedRowCellValue("Etapa") = "Final" Then
            XtraMsg("El Proyecto ya se encuentra en etapa de Finalización.", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        ShowSplash("Generando Costos...")
        frmProyectosLiquidar.Dispose()
        With frmProyectosLiquidar
            .MdiParent = Me.MdiParent
            .IdProyecto = iVista.GetFocusedRowCellValue("IdProyecto")
            .Fecha.DateTime = iVista.GetFocusedRowCellValue("Fecha")
            .Text = "Liquidar Proyectos"
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
        HideSplash()

    End Sub

    Private Sub SimpleButton10_Click(sender As Object, e As EventArgs) Handles bReporteAuxiliar.Click
        ShowSplash()
        frmReporteAuxiliarProyectos.Dispose()
        With frmReporteAuxiliarProyectos
            .MdiParent = Me.MdiParent
            .Text = "Auxiliar de Proyectos"
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
        HideSplash()
    End Sub

    Private Sub bFinalizar_Click(sender As Object, e As EventArgs) Handles bFinalizar.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        Dim Estado As String = iVista.GetFocusedRowCellValue("Etapa")

        If Estado = "Anulado" Then
            XtraMsg("El Proyecto seleccionado se encuentra Anulado...", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If Estado = "Final" Then
            XtraMsg("El Proyecto seleccionado ya se encuentra en estapa de Finalización...", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If Not XtraMsg2("Esta Seguro de Finalizar este Proyecto?") Then
            Exit Sub
        End If
        '
        If db_Proyectos.ProyectoFinalizar(iVista.GetFocusedRowCellValue("IdProyecto")) Then
            Cargar()
        End If
    End Sub
End Class