Public Class frmClientesAdicionales

    Dim obj As New PNR_ClientesAdicionales
    Dim db As New db_PNR_ClientesAdicionales

    Dim vIdPlanNegocio As Integer

    Public Property IdPlanNegocio() As Integer
        Get
            Return vIdPlanNegocio
        End Get
        Set(ByVal value As Integer)
            vIdPlanNegocio = value
        End Set
    End Property

    Private Sub frmClientesAdicionales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.DoEvents()
        'RepositoryGridLookup(cbClientes, ObtieneDatos("SP_GetClientes " & EmpresaActual & ",0"), "Nombre", "Codigo", 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16)
        RepositoryGridLookup(cbClientes, ObtieneDatos("PNR_GetClientes", EmpresaActual), "Nombre", "Codigo")
        '
        Cargar()
    End Sub

    Sub Cargar()
        iGrid.DataSource = db_PNR_ClientesAdicionales.Listar(0, vIdPlanNegocio)
        SimpleFormatGrid(iVista, True, DevExpress.Utils.HorzAlignment.Center, 0, 2, False, 0)

        iVista.Columns("Cliente").ColumnEdit = cbClientes
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        'Borrar Todo para volver insertar
        obj.IdPlanNegocio = vIdPlanNegocio
        db.Borrar(obj)
        '
        'Insetar        
        For i As Integer = 0 To iVista.DataRowCount - 1
            obj.IdCliente = iVista.GetRowCellValue(i, "Cliente")

            db.Insertar(obj)
        Next

        Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub

    Private Sub iVista_KeyDown(sender As Object, e As KeyEventArgs) Handles iVista.KeyDown
        If iVista.FocusedRowHandle < 0 Then Exit Sub
        '
        iVista.DeleteSelectedRows()
        iVista.RefreshData()
    End Sub
End Class