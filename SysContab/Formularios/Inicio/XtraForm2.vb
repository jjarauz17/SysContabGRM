Imports Entities

Public Class XtraForm2
    Dim obj As New CLIENTES,
    ClientesDB As New db_CLIENTES

    Private Sub XtraForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iGrid.DataSource = ClientesDB.Listar(0, EmpresaActual)
        iVista.PopulateColumns()
    End Sub
End Class