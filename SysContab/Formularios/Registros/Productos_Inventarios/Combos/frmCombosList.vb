Imports ClasesBLL
Public Class frmCombosList
    Private Sub frmCombos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Public Sub Cargar()
        iGrid.DataSource = ObtieneDatos("sp_sel_combos_List", EmpresaActual)
        iVista.PopulateColumns()
        FormatoGrid(iVista)
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        frmCombos.ShowDialog()
        frmCombos.Dispose()
    End Sub

    Private Sub cmdModificar_Click(sender As Object, e As EventArgs) Handles cmdModificar.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Combo")
            Exit Sub
        End If
        '
        frmCombos.Codigo_Combo = iVista.GetFocusedRowCellValue("Codigo")
        frmCombos.ShowDialog()
        frmCombos.Dispose()
    End Sub

    Private Sub cmdBorrar_Click(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Combo")
            Exit Sub
        End If
        '
        If Not XtraMsg2("Esta Seguro de Anular el Combo Seleccionado ?") Then
            Exit Sub
        End If

        Dim obj As New Combos
        Dim db As New db_Combos

        obj.Codigo_Combo = iVista.GetFocusedRowCellValue("Codigo")

        Dim Msg As String = db.Borrar(obj)
        If Msg = "OK" Then
            XtraMsg("El Combo se ha borrado con exito.")
            Cargar()
        Else
            XtraMsg(Msg, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cmdAyuda_Click(sender As Object, e As EventArgs) Handles cmdAyuda.Click
        frmExportarImprimir.Mostrar(iGrid, Me.Text)
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        Close()
    End Sub
End Class