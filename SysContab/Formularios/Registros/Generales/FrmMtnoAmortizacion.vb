Imports ClasesBLL
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Public Class FrmMtnoAmortizacion

    Dim dr As DataRow
    Public Nuevo As String = String.Empty
    Public Codigo As Integer = 0

    Private Sub FrmMtnoAmortizacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(LayoutControl1)
        Cargar()
        '
        iVista.PopulateColumns()
        FormatoGrid(iVista)
    End Sub

    Private Sub FrmMtnoAmortizacion_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then Cargar()
    End Sub

    Private Sub iVista_DoubleClick(sender As Object, e As EventArgs) Handles iVista.DoubleClick
        Editar()
    End Sub

    Public Sub Cargar()
        ' Me.GridCatalogo.DataSource = ObtieneDatos("_GetCatalogo_Amortiza " & EmpresaActual)
        iGrid.DataSource = db_CatalogoAmortizacion.Listar(0)
    End Sub

    'Private Sub GridAmortizacion_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    '    btnChange_Click(Nothing, Nothing)
    'End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        With frmAdd_Modificar
            .Text = "Nueva Amortización"
            ' .Nuevo = "SI"
            .Codigo = 0
            '.MdiParent = Me.MdiParent
            .ShowDialog()
            '.WindowState = FormWindowState.Maximized
            'Cargar()
            .Dispose()
        End With
    End Sub

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click

        Editar()

        'If Me.Catalogo.RowCount > 0 And Me.Catalogo.FocusedRowHandle >= 0 Then
        '    dr = Me.Catalogo.GetDataRow(Me.Catalogo.FocusedRowHandle)
        '    Nuevo = "NO"

        '    Codigo = CInt(dr("Codigo").ToString)

        '    My.Forms.frmAdd_Modificar.Text = "Modificar Amortización"
        '    My.Forms.frmAdd_Modificar.ShowDialog()
        '    My.Forms.frmAdd_Modificar.Dispose()
        '    Cargar()
        'Else
        '    MsgBox("Seleccione el un Registro", MsgBoxStyle.Information, "Amortizaciones")
        'End If
    End Sub

    Sub Editar()
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione el un Registro")
            Exit Sub
        End If
        '
        With My.Forms.frmAdd_Modificar
            .Text = "Editar Amortización"
            '  .Nuevo = "NO"
            .Codigo = iVista.GetFocusedRowCellValue("Codigo")
            ' .MdiParent = Me.MdiParent
            .ShowDialog()
            '.WindowState = FormWindowState.Maximized
            'Cargar()
            .Dispose()
        End With
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione el un Registro")
            Exit Sub
        End If

        Dim Estado As String = iVista.GetFocusedRowCellValue("Estado")

        If Estado = "EN PROCESO" Then
            XtraMsg("La Amortización se encuentra en Proceso, no se puede Borrar.", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If Estado = "FINALIZADA" Then
            XtraMsg("La Amortización ya fue Finalizada, no se puede Borrar.", MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not XtraMsg2("¿ Esta Seguro de la Acción Solicitada ?") Then
            Exit Sub
        End If


        Dim obj As New CatalogoAmortizacion
        Dim db As New db_CatalogoAmortizacion

        obj.Codigo = iVista.GetFocusedRowCellValue("Codigo")
        db.Borrar(obj)


        'If Not GuardaDatos("DELETE FROM CatalogoAmortizacion Where Codigo = " & iVista.GetFocusedRowCellValue("Codigo") & " AND Empresa = " & EmpresaActual) Then
        '    MsgBox("Error Inesperado, Consulta al Administrador del Sistema", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If

        Cargar()
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione el un Registro")
            Exit Sub
        End If
        '
        Dim rpt As New rptDetalle_Amortizacion
        rpt.pLogo.Image = frmPrincipalRibbon.pLogo.Image
        '
        AmortizacionesDB.Imprimir(iVista.GetFocusedRowCellValue("Codigo"), rpt)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        frmExportarImprimir.Mostrar(iGrid, "Listado de Amortizaciones")
    End Sub

    Private Sub iVista_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles iVista.RowCellStyle
        If e.Column.FieldName = "Estado" Then
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            If iVista.GetRowCellValue(e.RowHandle, "Estado") = "EN PROCESO" Then
                e.Appearance.BackColor = Color.LightYellow
                e.Appearance.BackColor2 = Color.Yellow
            ElseIf iVista.GetRowCellValue(e.RowHandle, "Estado") = "FINALIZADA" Then
                e.Appearance.BackColor = Color.LightGreen
                e.Appearance.BackColor2 = Color.Green
            ElseIf iVista.GetRowCellValue(e.RowHandle, "Estado") = "GENERADA" Then
                e.Appearance.BackColor = Color.Magenta
                e.Appearance.BackColor2 = Color.DarkMagenta
            Else
                e.Appearance.BackColor = Color.Salmon
                e.Appearance.BackColor2 = Color.Pink
            End If
        End If
    End Sub
End Class
