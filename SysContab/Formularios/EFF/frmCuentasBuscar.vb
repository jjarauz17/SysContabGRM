Public Class frmCuentasBuscar

    Public ok As String = "NO"
    Public Cuenta As String = vbNullString
    Public CuentasMarcar As String = ""

#Region "Movimientos"
    Private Sub iGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles iVista.KeyDown

        If e.Control = True Then
            If e.KeyCode = Keys.Up Then
                iVista.FocusedRowHandle = 1
            End If

            If e.KeyCode = Keys.Down Then
                iVista.FocusedRowHandle = iVista.RowCount - 1
            End If

            If e.KeyCode = Keys.Left Then
                iVista.FocusedColumn = iVista.VisibleColumns(1)
            End If

            If e.KeyCode = Keys.Right Then
                iVista.FocusedColumn = iVista.VisibleColumns(iVista.VisibleColumns.Count - 2)
            End If

            If e.Control AndAlso e.KeyCode = Keys.C Then
                Clipboard.SetText(iVista.GetFocusedDisplayText())
                e.Handled = True
            End If
        End If
    End Sub
#End Region

    Private Sub frmCuentasBuscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowSplash("Cargando Cuentas...")
        '
        iGrid.DataSource = db_Cuentas.Listar_Catalogo_Seleccionar(CuentasMarcar)
        '
        HideSplash()
    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ' Validar que hayan cuentas marcadas
        '
        Dim buscar As Boolean = False

        For i As Integer = 0 To iVista.DataRowCount - 1
            If iVista.GetRowCellValue(i, "Seleccionar") Then
                buscar = True
            End If
        Next
        '
        If Not buscar Then
            XtraMsg("Debe seleccionar al menos 1 cuenta", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '

        Cuenta = ""
        For i As Integer = 0 To iVista.DataRowCount - 1
            If iVista.GetRowCellValue(i, "Seleccionar") Then
                If Cuenta.Trim.Length = 0 Then
                    Cuenta = iVista.GetRowCellValue(i, "Cuenta")
                Else
                    Cuenta = Cuenta & ", " & iVista.GetRowCellValue(i, "Cuenta")
                End If
            End If
        Next

        ok = "SI"
        Close()

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        ok = "NO"
        Close()
    End Sub

End Class