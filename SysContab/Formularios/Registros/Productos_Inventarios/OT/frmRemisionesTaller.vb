Imports System.IO
Imports ClasesBLL
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Public Class frmRemisionesTaller

    Dim obj As New OrdenesTrabajo
    Dim db As New db_OrdenesTrabajo
    Dim DT_ROL As DataTable

    Private Sub frmRemisionesTaller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DT_ROL = RolesDB.UsuarioAcciones(LayoutControl2)

        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        Desde.DateTime = New DateTime(f.Year, f.Month, 1).Date
        Hasta.DateTime = UltimoDiaDelMes(f.Date).Date

        Cargar()
        Formato()
    End Sub

    Public Sub Cargar()
        iGrid.DataSource =
            db_OrdenesTrabajo.Listar(
            0,
            Desde.DateTime.Date,
            Hasta.DateTime.Date)
    End Sub

    Sub Formato()
        vDatos.PopulateColumns()
        FormatoGrid(vDatos)
        ''
        vDatos.Columns("IdOrden").Visible = False
        vDatos.Columns("Fallas_Equipo").Visible = False
        vDatos.Columns("Trabajo_Realizado").Visible = False
        vDatos.Columns("Observaciones").Visible = False
        vDatos.Columns("Monto").Visible = False
        vDatos.Columns("TCambio").Visible = False
        vDatos.Columns("Registro").Visible = False

        Dim columnCustomer As GridColumn = vDatos.Columns("Estado")
        columnCustomer.FilterInfo = New ColumnFilterInfo("[Estado] <> 'Anulada'")
    End Sub

    Private Sub bNuevo_Click(sender As Object, e As EventArgs) Handles bNuevo.Click
        Inicio = True
        ShowSplash("Cargando Orden...")
        frmOrdenTrabajoAdd.Dispose()
        frmOrdenTrabajoAdd.MdiParent = Me.MdiParent
        frmOrdenTrabajoAdd.IdOrden = 0
        frmOrdenTrabajoAdd.Text = "Crear Orden Trabajo"
        frmOrdenTrabajoAdd.DT_ROL = DT_ROL
        frmOrdenTrabajoAdd.Show()
        frmOrdenTrabajoAdd.WindowState = FormWindowState.Maximized
        HideSplash()
        Inicio = False
    End Sub

    Private Sub bEditar_Click(sender As Object, e As EventArgs) Handles bEditar.Click
        If vDatos.FocusedRowHandle < 0 Then
            XtraMsg("Seleecione un registro!")
            Exit Sub
        End If
        ''
        Inicio = True
        frmOrdenTrabajoAdd.Dispose()
        frmOrdenTrabajoAdd.MdiParent = Me.MdiParent
        frmOrdenTrabajoAdd.IdOrden = vDatos.GetFocusedRowCellValue("IdOrden")
        frmOrdenTrabajoAdd.Text = "Editar Orden Trabajo"
        frmOrdenTrabajoAdd.DT_ROL = DT_ROL
        If vDatos.GetFocusedRowCellValue("Estado") <> "Pendiente" Then frmOrdenTrabajoAdd.bGuardar.Enabled = False
        frmOrdenTrabajoAdd.Show()
        frmOrdenTrabajoAdd.WindowState = FormWindowState.Maximized
        Inicio = False
    End Sub

    Private Sub bBorrar_Click(sender As Object, e As EventArgs) Handles bBorrar.Click
        If vDatos.FocusedRowHandle < 0 Then
            XtraMsg("Seleecione un registro!")
            Exit Sub
        End If
        ''
        If vDatos.GetFocusedRowCellValue("Estado") <> "Pendiente" Then
            XtraMsg("La Orden de trabajo se encuentra en Estado :" + vDatos.GetFocusedRowCellValue("Estado").ToString(), MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        If XtraMsg2("Esta Seguro de Anular la O/T Seleccionada?") Then
            obj.IdOrden = vDatos.GetFocusedRowCellValue("IdOrden")

            If db.Borrar(obj) Then Cargar()
        End If

    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        If vDatos.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        Imprimir(vDatos.GetFocusedRowCellValue("IdOrden"))
    End Sub

    Sub Imprimir(IdOrden As Integer)
        ShowSplash("Imprimiendo...")

        'Dim Cadena As String
        'Dim Temp As Boolean = False
        'Dim Data() As Byte

        'Try
        '    Data = CType(ObtieneDatos("sp_get_formato_imprimir", 28, EmpresaA).Rows(0).Item(0), Byte())
        '    Temp = True
        '    '
        '    Dim Tamano As Integer
        '    Tamano = Data.GetUpperBound(0)
        '    Cadena = Application.StartupPath & "\rptOrdenTrabajo.repx"
        '    If File.Exists(Cadena) Then Kill(Cadena)
        '    Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
        '    Archivo.Write(Data, 0, Tamano)
        '    Archivo.Close()
        'Catch ex As Exception
        '    Temp = False
        'End Try

        Dim Temp As Boolean = db_Formatos.FormatoImpreso(28, "rptOrdenTrabajo")

        Dim rpt As rptOrdenTrabajo

        If Temp = True Then
            rpt = XtraReport.FromFile(Application.StartupPath & "\rptOrdenTrabajo.repx", True)
        Else
            rpt = New rptOrdenTrabajo
        End If

        'rpt.DataSource = ObtieneDatos("sp_sel_OrdenesTrabajo_Imprimir", IdOrden, EmpresaActual)

        VistaPreviaDX(rpt,
                      ObtieneDatos("sp_sel_OrdenesTrabajo_Imprimir", IdOrden, EmpresaActual),
                      "Orden de Trabajo No. " & db_OrdenesTrabajo.Detalles(IdOrden).NoOrden)
        HideSplash()
        'rpt.ShowPrintMarginsWarning = False
        'rpt.BringToFront()
        ''
        'HideSplash()
        'rpt.ShowRibbonPreview()
    End Sub

    Private Sub bDiseno_Click(sender As Object, e As EventArgs) Handles bDiseno.Click
        ShowSplash("Cargando Formaato...")
        FrmConfiguraCheque.Dispose()
        With FrmConfiguraCheque
            .Tipo = 28
            .Text = "Configurar Formato de Orden de Trabajo"
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
        HideSplash()
    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(iGrid)
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Cargar()
    End Sub

    Private Sub vDatos_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles vDatos.RowCellStyle
        If e.Column.FieldName = "Estado" Then
            e.Appearance.BackColor = Color.LightGray
            e.Appearance.Font = New Font("Tahoma", 8, FontStyle.Bold)
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            If vDatos.GetRowCellValue(e.RowHandle, "Estado") = "Pendiente" Then
                e.Appearance.ForeColor = Color.Salmon
            End If
            '
            If vDatos.GetRowCellValue(e.RowHandle, "Estado") = "Facturada" Then
                e.Appearance.ForeColor = Color.DarkGreen
            End If
            '
            If vDatos.GetRowCellValue(e.RowHandle, "Estado") = "Anulada" Then
                e.Appearance.ForeColor = Color.Red
            End If
            '
            If vDatos.GetRowCellValue(e.RowHandle, "Estado") = "Finalizada" Then
                e.Appearance.ForeColor = Color.Navy
            End If
        End If
    End Sub

    Private Sub bGenerarMovimiento_Click(sender As Object, e As EventArgs) Handles bGenerarMovimiento.Click
        If vDatos.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        If vDatos.GetFocusedRowCellValue("Estado") = "Anulada" Then
            XtraMsg("La O/T se encuentra en estado de Anulada*", MessageBoxIcon.Warning)
            Exit Sub
        End If

        If vDatos.GetFocusedRowCellValue("Estado") = "Facturada" Then
            XtraMsg("La O/T se encuentra facturada.", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        If vDatos.GetFocusedRowCellValue("Estado").ToString().Equals("N / D") Then
            XtraMsg("La O/T ya fue generada como Movimiento de Inventario.", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        With frmGuardarMovimiento
            .IdRemision = vDatos.GetFocusedRowCellValue("IdOrden")
            .NoRemision = vDatos.GetFocusedRowCellValue("Documento")
            .Tipo = 5
            .TipoServicio.Properties.Items(0).Description = "Nota de Débito"
            .TipoServicio.Properties.Items(0).Enabled = True
            .TipoServicio.Properties.Items(1).Enabled = False
            .TipoServicio.Properties.Items(2).Enabled = False
            .TipoServicio.EditValue = 1
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub bFinalizar_Click(sender As Object, e As EventArgs) Handles bFinalizar.Click
        If vDatos.FocusedRowHandle < 0 Then
            XtraMsg("Seleecione un registro!")
            Exit Sub
        End If
        '
        If vDatos.GetFocusedRowCellValue("Estado") = "Facturada" Then
            XtraMsg("La O/T se encuentra facturada.", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        If vDatos.GetFocusedRowCellValue("Estado") = "Anulada" Then
            XtraMsg("La O/T se encuentra Anulada.", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        If vDatos.GetFocusedRowCellValue("Estado") = "Finalizada" Then
            XtraMsg("La O/T ya encuentra Finalizada.", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        If XtraMsg2("Esta Seguro de Finalizar esta O/T ?") Then
            If db_OrdenesTrabajo.UpdateRemisiones(vDatos.GetFocusedRowCellValue("IdOrden"), "E") Then Cargar()
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles bReporte.Click
        ShowSplash()
        frmDinamicoOrdenesTrabajo.Dispose()
        frmDinamicoOrdenesTrabajo.MdiParent = Me.MdiParent
        frmDinamicoOrdenesTrabajo.Text = "Reporte Dinámico de O/T"
        frmDinamicoOrdenesTrabajo.Show()
        frmDinamicoOrdenesTrabajo.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub bAsociar_Click(sender As Object, e As EventArgs) Handles bAsociar.Click
        If vDatos.FocusedRowHandle < 0 Then
            XtraMsg("Seleecione un registro!")
            Exit Sub
        End If
        '
        Dim Estado As String = vDatos.GetFocusedRowCellValue("Estado")

        If Not Estado.Equals("Pendiente") Then
            XtraMsg("La O/T se encuentra en estado " + Estado + ", no puede ser asociada a Factura!",
                    MessageBoxIcon.Warning)
            Exit Sub
        End If
        '

        With frmAsociarFacturasOT
            .Text = "Asociar Ordenes de Trabajo a Facturas"
            .IdOrden = vDatos.GetFocusedRowCellValue("IdOrden")
            .ShowDialog()
            .Dispose()
        End With


    End Sub
End Class