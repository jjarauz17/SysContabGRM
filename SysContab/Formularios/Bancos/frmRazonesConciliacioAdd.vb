Public Class frmRazonesConciliacioAdd
    Public IdDetalle As Integer = 0
    Public Ok As String = "NO"

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If txtNombre.Text.Trim.Length = 0 Then
            XtraMsg("Escriba el Nombre")
            txtNombre.Focus()
            Exit Sub
        End If

        If IdDetalle = 0 Then
            If GuardaDatos("INSERT INTO Conciliacion_Razones VALUES (" & EmpresaActual & ",'" & txtNombre.Text & "')") Then
                Ok = "SI"
                Close()
            End If
        Else
            If GuardaDatos("UPDATE Conciliacion_Razones SET Razon_Nombre = '" & txtNombre.Text & "' WHERE IdDetalle = " & IdDetalle) Then
                Ok = "SI"
                Close()
            End If
        End If
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Ok = "NO"
        Close()
    End Sub

    Private Sub frmRazonesConciliacioAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As DataTable = ObtieneDatos("SELECT * FROM Conciliacion_Razones cr WHERE cr.IdDetalle = " & IdDetalle)
        If dt.Rows.Count > 0 Then
            txtCodigo.EditValue = dt.Rows.Item(0)("IdDetalle")
            txtNombre.Text = dt.Rows.Item(0)("Razon_Nombre")
        Else
            txtCodigo.EditValue = 0
        End If
    End Sub
End Class