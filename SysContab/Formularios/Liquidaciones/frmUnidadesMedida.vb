Public Class frmUnidadesMedida

    Private Shared ChildInstance As frmUnidadesMedida = Nothing

    Dim NewData As Boolean

    Public Shared Function Instance() As frmUnidadesMedida
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmUnidadesMedida
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Private Sub frmUnidadesMedida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmdExit.Focus()
        LoadData()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        If cmdExit.Text = "&Salir" Then
            Me.Close()
        Else
            EnableDisableFields(False)
            CleanFields()
            cmdNew.Text = "&Nuevo" : cmdExit.Text = "&Salir"
        End If
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        If cmdNew.Text = "&Nuevo" Then
            NewData = True
            cmdNew.Text = "&Guardar"
            cmdExit.Text = "&Cancelar"
            EnableDisableFields(True)
            tbName.Focus()
        Else
            ObtieneDatos("UPDATE UnidadesMedida SET MedNombre = " & tbName.Text & ",MedCod=" & tbCorto.Text & " WHERE " & "MedidaID=" & GridView1.GetFocusedRowCellValue("MedidaID") & "EmpresaID=" & EmpresaActual)

            EnableDisableFields(False)
            cmdNew.Text = "&Nuevo" : cmdExit.Text = "&Salir"
            NewData = True
            LoadData()
            CleanFields()
        End If
    End Sub

    Private Sub LoadData()
        GridControl1.DataSource = ObtieneDatos("Select * from UnidadesMedida WHERE EmpresaID=" & EmpresaActual)
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        NewData = False
        tbName.Text = GridView1.GetFocusedRowCellValue("MedNombre")
        tbCorto.Text = GridView1.GetFocusedRowCellValue("MedCod")
        EnableDisableFields(True)
        cmdExit.Text = "&Cancelar" : cmdNew.Text = "&Guardar"
    End Sub

    Private Sub EnableDisableFields(ByVal Accion As Boolean)
        tbName.Enabled = Accion : tbCorto.Enabled = Accion
        cmdEdit.Enabled = Not Accion ': cmdNew.Enabled = Not Accion
    End Sub

    Private Sub CleanFields()
        tbName.Text = "" : tbCorto.Text = ""
    End Sub
End Class