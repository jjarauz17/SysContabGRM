Imports Entities

Public Class frmListaNegraAdd

    Public IdLista As Integer = 0,
        IsAnula As Boolean = False,
        Ok As Boolean = False

    Dim objCliente As New ClientesListNegra
    Dim dbCliente As New db_ClientesListNegra

    Private Sub frmListaNegraAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)

        SearchLookUp(
            IdCliente,
            VB.SysContab.ClientesDB.GetList(1).Tables("Clientes"),
            "Nombre",
            "Codigo",
            4, 5, 6, 7, 8)

        If IdLista > 0 Then
            objCliente = dbCliente.Detalles(IdLista, EmpresaActual)
            IdCliente.EditValue = objCliente.IdCliente
            IdCliente.Properties.ReadOnly = True

            If Not IsAnula Then
                Fecha.DateTime = objCliente.FechaInicio
                Comentario.Text = objCliente.Comentario
                lblTitulo.Text = "Modificar datos en Lista Negra..."
            Else
                lblTitulo.Text = "Anular Cliente de Lista Negra..."
            End If
        Else
            lblTitulo.Text = "Agregar Cliente a Lista Negra..."
        End If

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Not DxValidationProvider1.Validate Then Exit Sub
        '
        objCliente.IdLista = IdLista
        objCliente.IdCliente = IdCliente.EditValue
        objCliente.Empresa = EmpresaActual
        objCliente.FechaFin = Fecha.DateTime.Date
        objCliente.FechaInicio = Fecha.DateTime.Date
        objCliente.Comentario = Comentario.Text
        objCliente.Comentario2 = Comentario.Text

        If IdLista = 0 Then
            dbCliente.Insertar(objCliente)
        Else
            If Not IsAnula Then dbCliente.Actualizar(objCliente)
            If IsAnula Then dbCliente.Borrar(objCliente)
        End If
        '
        Ok = True
        Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Ok = False
        Close()
    End Sub

    Private Sub frmListaNegraAdd_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Ok = False
            Close()
        End If
    End Sub
End Class