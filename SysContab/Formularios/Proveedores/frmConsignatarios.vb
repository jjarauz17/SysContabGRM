Public Class frmConsignatarios

    Private Sub frmTipoMovimientosInvent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' RolesDB.UsuarioAcciones(PanelControl1)
        Cargar()
    End Sub

    Public Sub Cargar()
        Me.dgDatos.DataSource = ObtieneDatos("JAR_GetConsignatarios " & EmpresaActual)
        Me.vDatos.PopulateColumns()
        FormatoGrid(Me.vDatos)
        '
        Me.vDatos.Columns("IdDetalle").Visible = False
        Me.vDatos.BestFitColumns()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        frmConsignatariosAdd.Text = "Nuevo..."
        frmConsignatariosAdd.ShowDialog()
        If frmConsignatariosAdd.Ok = "SI" Then Cargar()
        frmConsignatariosAdd.Dispose()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        If Me.vDatos.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
            Exit Sub
        End If
        '
        With frmConsignatariosAdd
            .Text = "Editar..."
            .IdDetalle = Me.vDatos.GetFocusedRowCellValue("IdDetalle")
            .txtNombre.Text = vDatos.GetFocusedRowCellValue("Nombre")
            .txtDescripcion.Text = vDatos.GetFocusedRowCellValue("Descripcion")
            .ShowDialog()
            If .Ok = "SI" Then Cargar()
            .Dispose()
        End With
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        If Me.vDatos.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
            Exit Sub
        End If
        '
        If XtraMsg2("Esta Seguro de Borrar el Consignatario: " + Me.vDatos.GetFocusedRowCellValue("Nombre") + "?") Then
            If GuardaDatos("DELETE FROM Consignatarios WHERE IdDetalle =  " & Me.vDatos.GetFocusedRowCellValue("IdDetalle")) Then
                Cargar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub vDatos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vDatos.DoubleClick
        btnEditar_Click(Nothing, Nothing)
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        frmExportarImprimir.Mostrar(dgDatos)
    End Sub
End Class