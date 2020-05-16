Imports DevExpress.XtraReports.UI

Public Class frmGruposBalance


    Public Tipo As String = "B"
    Dim IdGrupo As Integer

    Sub Nuevo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Mostrar(False)
    End Sub

    Sub Editar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        If Not iTreeList.FocusedNode.Focused Then Exit Sub
        '
        Mostrar(True)
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub FrmFormasPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' CargarLayout(Me, LayoutControl2)
        Fecha.DateTime = VB.SysContab.Rutinas.Fecha().Date

        Cargar()
        '
        iTreeList.KeyFieldName = "IdGrupo"
        iTreeList.ParentFieldName = "IdPadre"
        '
        iTreeList.ExpandAll()
    End Sub

    Sub Cargar()
        iTreeList.DataSource = db_GruposBalRes.Listar(0, Tipo)
        iTreeList.ExpandAll()
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        If Not iTreeList.FocusedNode.Focused Then Exit Sub

        'If iGridView.FocusedRowHandle < 0 Then
        '    Mensaje("Seleccione un Registro")
        '    Exit Sub
        'End If
        ''
        'If Not db_Periodos.Verificar(iGridView.GetFocusedRowCellValue("IdPeriodo")) Then
        '    Mensaje("El Periodo que intenta borrar contiene transacciones contables", MessageBoxIcon.Error)
        '    Exit Sub
        'End If

        If Not XtraMsg2("Esta Seguro de la acción Solicitada?") Then
            Exit Sub
        End If

        Dim obj As New GruposBalRes
        Dim db As New db_GruposBalRes

        obj.IdGrupo = IdGrupo
        db.Borrar(obj)
        '
        Cargar()

        'obj.IdPeriodo = iGridView.GetFocusedRowCellValue("IdPeriodo")
        'db.Borrar(obj)
        'Cargar()
    End Sub

    Sub Mostrar(Editar As Boolean)

        With frmGruposBalResAdd
            If Editar Then
                '.IdGrupo = iTreeList.Nodes(0).Nodes.Item(iTreeList.FocusedNode.Id).GetValue("ID")
                '.IdGrupo = iTreeList.Nodes.Item(iTreeList.FocusedNode.Id).GetValue("ID")
                .IdGrupo = IdGrupo
                .Editar = True
                .Tipo = Tipo
                .Text = "Editar - " & lblTitulo.Text
            Else
                .IdGrupo = 0
                .Editar = False
                .Tipo = Tipo
                .Text = "Nuevo - " & lblTitulo.Text
            End If
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
            .Dispose()

            Cargar()
        End With
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        frmExportarImprimir.Mostrar(iTreeList, IIf(Tipo = "B", "Balance General", "Estado de Resultado"))
    End Sub

    Private Sub frmTipoCuentas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            Cargar()
        End If
    End Sub

    Private Sub iGridView_DoubleClick(sender As Object, e As EventArgs)
        'If iGridView.FocusedRowHandle < 0 Then Exit Sub

        'Mostrar(True)
    End Sub

    Private Sub iGridView_KeyDown(sender As Object, e As KeyEventArgs)
        'If e.KeyCode = Keys.Enter Then
        '    Mostrar(True)
        'End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Cargar()
    End Sub

    Private Sub iTreeList_FocusedNodeChanged(sender As Object, e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles iTreeList.FocusedNodeChanged
        Try
            IdGrupo = e.Node.GetValue("ID")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub bExpandir_Click(sender As Object, e As EventArgs) Handles bExpandir.Click
        iTreeList.ExpandAll()
    End Sub

    Private Sub bContraer_Click(sender As Object, e As EventArgs) Handles bContraer.Click
        iTreeList.CollapseAll()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked Then iTreeList.ColumnsCustomization()
        If Not CheckEdit1.Checked Then iTreeList.DestroyCustomization()
    End Sub

    Private Sub iTreeList_HideCustomizationForm(sender As Object, e As EventArgs) Handles iTreeList.HideCustomizationForm
        CheckEdit1.Checked = False
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        ShowSplash("Generando Informe...")

        If Tipo = "B" Then
            Dim rpt As New rptBalanceGeneral
            Dim rptActivos As New rptBalanceActivos

            rpt.DataSource = ObtieneDatos("JAR_BalanceGeneralActivos", Fecha.DateTime.Date, MonedaBase, "A", EmpresaActual)
            rptActivos.DataSource = ObtieneDatos("JAR_BalanceGeneralPasivo", Fecha.DateTime.Date, MonedaBase, "P", EmpresaActual)

            rpt.pLogo.Image = frmPrincipalRibbon.pLogo.Image
            rpt.XrSubreport1.ReportSource = rptActivos
            rpt.ShowPrintMarginsWarning = False
            rpt.BringToFront()
            rpt.ShowRibbonPreview()
        ElseIf Tipo = "R" Then
            Dim rpt As New rptEstadoResultado

            rpt.pLogo.Image = frmPrincipalRibbon.pLogo.Image
            rpt.DataSource = ObtieneDatos("JAR_EstadoDeResultado", Fecha.DateTime.Date, MonedaBase, EmpresaActual)
            rpt.ShowPrintMarginsWarning = False
            rpt.BringToFront()
            rpt.ShowRibbonPreview()
        End If
        '
        HideSplash()
    End Sub

    Private Sub iTreeList_DoubleClick(sender As Object, e As EventArgs) Handles iTreeList.DoubleClick
        If Not iTreeList.FocusedNode.Focused Then Exit Sub
        '
        Mostrar(True)
    End Sub
End Class