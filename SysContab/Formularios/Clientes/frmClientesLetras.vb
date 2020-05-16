Imports System.IO
Imports ClasesBLL
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports Entities

Public Class frmClientesLetras

    Dim obj As New ClientesLetrasCambio
    Dim db As New db_ClientesLetrasCambio
    Dim DT_ROL As DataTable

    Private Sub frmClientesLetras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DT_ROL = RolesDB.UsuarioAcciones(LayoutControl2)

        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        Desde.DateTime = New DateTime(f.Year, f.Month, 1).Date
        Hasta.DateTime = UltimoDiaDelMes(f.Date).Date
        '
        Cargar()
        Formato()
    End Sub

    Public Sub Cargar()
        iGrid.DataSource =
            db.Listar(
            0,
            EmpresaActual,
            Desde.DateTime.Date,
            Hasta.DateTime.Date)
    End Sub

    Sub Formato()
        iVista.PopulateColumns()
        FormatoGrid(iVista)
        ''
        iVista.Columns("Id").Visible = False
        iVista.Columns("NEmpresa").Visible = False
        iVista.Columns("EnLetras").Visible = False
        iVista.Columns("Comentarios").Visible = False
        iVista.Columns("Comentarios").Visible = False
        iVista.Columns("Registro").Visible = False

        Dim columnCustomer As GridColumn = iVista.Columns("Estado")
        columnCustomer.FilterInfo = New ColumnFilterInfo("[Estado] <> 'Anulada'")
    End Sub

    Private Sub bNuevo_Click(sender As Object, e As EventArgs) Handles bNuevo.Click
        With frmClientesLetrasAdd
            .Text = "Nueva Letra de Cambio"
            .Id = 0
            .ShowDialog()
            If .Ok Then Cargar()
            .Dispose()
        End With
    End Sub

    Private Sub bEditar_Click(sender As Object, e As EventArgs) Handles bEditar.Click
        Editar()
    End Sub

    Sub Editar()
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleecione un registro!")
            Exit Sub
        End If
        '
        With frmClientesLetrasAdd
            .Text = "Editar Letra de Cambio"
            .Id = iVista.GetFocusedRowCellValue("Id")
            .ShowDialog()
            If .Ok Then Cargar()
            .Dispose()
        End With
    End Sub

    Private Sub bBorrar_Click(sender As Object, e As EventArgs) Handles bBorrar.Click

        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleecione un registro!")
            Exit Sub
        End If
        '
        If iVista.GetFocusedRowCellValue("Estado").ToString().Equals("Anulada") Then
            XtraMsg("La Letra de Cambio se encuentra en Estado :" + iVista.GetFocusedRowCellValue("Estado").ToString().ToUpper, MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        If XtraMsg2("Esta Seguro de Anular la Letra de Cambio Seleccionada ?") Then
            obj.Id = iVista.GetFocusedRowCellValue("Id")

            If db.Borrar(obj) Then
                ShowSplash()
                Cargar()
                HideSplash()
            End If
        End If

    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        ShowSplash("Imprimiendo...")
        db.Imprimir(iVista.GetFocusedRowCellValue("Id"), EmpresaActual)
        HideSplash()
        'Imprimir(iVista.GetFocusedRowCellValue("Id"))
    End Sub

    Sub Imprimir(IdOrden As Integer)
        ShowSplash("Imprimiendo...")

        'Dim Temp As Boolean = db_Formatos.FormatoImpreso(28, "rptOrdenTrabajo")

        'Dim rpt As rptOrdenTrabajo

        'If Temp = True Then
        '    rpt = XtraReport.FromFile(Application.StartupPath & "\rptOrdenTrabajo.repx", True)
        'Else
        '    rpt = New rptOrdenTrabajo
        'End If

        ''rpt.DataSource = ObtieneDatos("sp_sel_OrdenesTrabajo_Imprimir", IdOrden, EmpresaActual)

        'VistaPreviaDX(rpt,
        '              ObtieneDatos("sp_sel_OrdenesTrabajo_Imprimir", IdOrden, EmpresaActual),
        '              "Orden de Trabajo No. " & db_OrdenesTrabajo.Detalles(IdOrden).NoOrden)
        HideSplash()
        'rpt.ShowPrintMarginsWarning = False
        'rpt.BringToFront()
        ''
        'HideSplash()
        'rpt.ShowRibbonPreview()
    End Sub

    Private Sub bDiseno_Click(sender As Object, e As EventArgs) Handles btnDiseno.Click
        ShowSplash("Cargando Formaato...")
        FrmConfiguraCheque.Dispose()
        With FrmConfiguraCheque
            .Tipo = 29
            .Text = "Configurar Formato de Letra de Cambio"
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
        HideSplash()
    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(iGrid, Me.Text)
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ShowSplash()
        Cargar()
        HideSplash()
    End Sub

    Private Sub vDatos_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles iVista.RowCellStyle
        If e.Column.FieldName = "Estado" Then
            e.Appearance.BackColor = Color.LightGray
            e.Appearance.Font = New Font("Tahoma", 8, FontStyle.Bold)
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            If iVista.GetRowCellValue(e.RowHandle, "Estado") = "Pendiente" Then
                e.Appearance.ForeColor = Color.Salmon
            End If
            '
            If iVista.GetRowCellValue(e.RowHandle, "Estado") = "Procesada" Then
                e.Appearance.ForeColor = Color.DarkGreen
            End If
            '
            If iVista.GetRowCellValue(e.RowHandle, "Estado") = "Anulada" Then
                e.Appearance.ForeColor = Color.Red
            End If
            '
            If iVista.GetRowCellValue(e.RowHandle, "Estado") = "Finalizada" Then
                e.Appearance.ForeColor = Color.Navy
            End If
        End If
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked Then iVista.ShowCustomization()
        If Not CheckEdit1.Checked Then iVista.DestroyCustomization()
    End Sub

    Private Sub iVista_HideCustomizationForm(sender As Object, e As EventArgs) Handles iVista.HideCustomizationForm
        CheckEdit1.Checked = False
    End Sub

    Private Sub iVista_DoubleClick(sender As Object, e As EventArgs) Handles iVista.DoubleClick
        Editar()
    End Sub
End Class