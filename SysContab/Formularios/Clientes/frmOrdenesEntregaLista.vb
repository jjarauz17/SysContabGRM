Public Class frmOrdenesEntregaLista 

    Private Sub frmOrdenesEntregaLista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbOrdenes.Properties.DataSource = ObtieneDatos("sp_GetOrdenesEntregaList 0," & EmpresaActual)
        cbOrdenes.Properties.DisplayMember = "Display"
        cbOrdenes.Properties.ValueMember = "No. Orden"

        vOrdenesList.PopulateColumns()
        FormatoGrid(Me.vOrdenesList)

        vOrdenesList.Columns("Display").Visible = False
    End Sub

    Private Sub cbOrdenes_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbOrdenes.EditValueChanged
        Try
            gridDatos.DataSource = ObtieneDatos("sp_GetOrdenesEntregaList " & Me.cbOrdenes.EditValue & "," & EmpresaActual)
            vDatos.PopulateColumns()

            FormatoGrid(Me.vDatos)

            vDatos.Columns("Codigo").OptionsColumn.AllowEdit = False
            vDatos.Columns("Descripción").OptionsColumn.AllowEdit = False
            vDatos.Columns("Cantidad").OptionsColumn.AllowEdit = False
            vDatos.Columns("Ingresada").OptionsColumn.AllowEdit = False
            vDatos.Columns("Precio").OptionsColumn.AllowEdit = False
            vDatos.Columns("Importe").OptionsColumn.AllowEdit = False

            vDatos.Columns("Descripción").Width = 200

            'vDatos.Columns("Codigo").BestFit()
            'vDatos.Columns("Cantidad").BestFit()
            'vDatos.Columns("Ingresada").BestFit()
            'vDatos.Columns("A Ingresar").BestFit()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

    End Sub
End Class