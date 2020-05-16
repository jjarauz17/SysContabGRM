Public Class frmFirmasContables

    Private Sub frmFirmasContables_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(PanelControl1)
        Me.Cargar()
    End Sub

    Private Sub Cargar()
        Me.Grid.DataSource = VB.SysContab.LibrosDB.FirmasContables()
        Me.vLista.PopulateColumns()
        vLista.Columns("nombre").Caption = "Nombre"
        vLista.Columns("cargo").Caption = "Cargo"
        vLista.Columns("empresa").Visible = False
        Me.vLista.Columns(0).Visible = False
        Me.vLista.BestFitColumns()
    End Sub

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Dim f As New frmFirmasContables_Agregar
        f.Nombre = ""
        f.Orden = 1
        f.Cargo = ""
        If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.Cargar()
        End If
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        If Me.vLista.DataRowCount = 0 Then
            MsgBox("No hay datos en la lista", MsgBoxStyle.Exclamation, "Sts.Contab")
            Exit Sub
        End If
        Dim f As New frmFirmasContables_Agregar
        f.Nombre = vLista.GetFocusedRowCellValue("nombre")
        f.Orden = vLista.GetFocusedRowCellValue("Orden")
        f.Cargo = vLista.GetFocusedRowCellValue("cargo")
        f.Id = vLista.GetFocusedRowCellValue("id")
        If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.Cargar()
        End If
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        If Me.vLista.DataRowCount = 0 Then
            MsgBox("No hay datos en la lista", MsgBoxStyle.Exclamation, "Sts.Contab")
            Exit Sub
        End If

        If XtraMsg2("Esta Seguro de la Operación Solicitada") Then
            VB.SysContab.LibrosDB.FirmasContables(vLista.GetFocusedRowCellValue("id"))
            Me.Cargar()
        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub
End Class