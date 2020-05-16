Imports ClasesBLL
Public Class frmCombosProcesar

    Dim DT As New DataTable("Combos")
    Private Sub frmCombosProcesar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date

        Desde.DateTime = New DateTime(f.Year, f.Month, 1).Date
        Hasta.DateTime = UltimoDiaDelMes(f).Date
        '
        GetTipoMovimientos(cbMovimiento, 1)
        cbMovimiento.ItemIndex = 0
        GetTipoMovimientos(cbMovimientoS, 1)
        cbMovimientoS.ItemIndex = 0

        Cargar()
        iVista.PopulateColumns()
        FormatoGrid(iVista)
        '
        For i As Integer = 0 To iVista.Columns.Count - 1
            iVista.Columns(i).OptionsColumn.AllowEdit = False
            iVista.Columns(i).OptionsColumn.AllowFocus = False
        Next
        '
        iVista.Columns("Producir").OptionsColumn.AllowEdit = True
        iVista.Columns("Producir").OptionsColumn.AllowFocus = True
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        ShowSplash()
        Cargar()
        HideSplash()
    End Sub

    Sub Cargar()
        DT = db_Combos.ListarProducir(Desde.DateTime.Date, Hasta.DateTime.Date)
        iGrid.DataSource = DT
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If cbMovimiento.ItemIndex = 0 Then
            XtraMsg("Seleccione el Tipo de Movimiento de Entrada", MessageBoxIcon.Warning)
            cbMovimiento.Focus()
            Exit Sub
        End If
        '
        If cbMovimientoS.ItemIndex = 0 Then
            XtraMsg("Seleccione el Tipo de Movimiento de Salida", MessageBoxIcon.Warning)
            cbMovimiento.Focus()
            Exit Sub
        End If
        '
        Dim _DT As DataTable = DT.Select("Producir = 1").CopyToDataTable

        If _DT.Rows.Count = 0 Then
            XtraMsg("Seleccione al menos 1 Combo que desea producir.", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If Not XtraMsg2("Esta Seguro de Producir los Combos Seleccionados ?") Then
            Exit Sub
        End If
        '
        Dim sAplicados As String = "", sNoAplicados As String = "", Aplicados As Integer = 0, NoAplicados As Integer = 0

        ShowSplash("Procesando Combos...")

        For i As Integer = 0 To _DT.Rows.Count - 1
            If db_Combos.Producir(_DT.Rows.Item(i)("CODIGO"), _DT.Rows.Item(i)("FACTURA"), cbMovimiento.EditValue, cbMovimientoS.EditValue) Then
                sAplicados += _DT.Rows.Item(i)("CODIGO") & vbCrLf
                Aplicados += 1
            Else
                sNoAplicados += _DT.Rows.Item(i)("CODIGO") & vbCrLf
                NoAplicados += 1
            End If
        Next

        HideSplash()

        XtraMsg("Combos Procesados: " & Aplicados.ToString & ", " & sAplicados & vbCrLf &
                "Errores Encontrados: " & NoAplicados.ToString & ", " & IIf(sNoAplicados = "", "NINGUNO", sNoAplicados))

        Dim frm As frmRequisas_List = frmRequisas_List.Instance()
        If frm.Created Then frm.GetData()
        Close()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        frmExportarImprimir.Mostrar(iGrid, Me.Text)
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Close()
    End Sub
End Class