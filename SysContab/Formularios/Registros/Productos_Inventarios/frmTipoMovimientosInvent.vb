Public Class frmTipoMovimientosInvent 

    Private Sub frmTipoMovimientosInvent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(LayoutControl2)
        Cargar()
    End Sub

    Public Sub Cargar()
        Me.dgDatos.DataSource = ObtieneDatos("SP_TipoMovimientosList " & EmpresaActual)
        Me.vDatos.PopulateColumns()
        FormatoGrid(Me.vDatos)
        '
        Me.vDatos.Columns("ID").Visible = False
        Me.vDatos.BestFitColumns()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        With My.Forms.frmTipoMovimientos
            .Nuevo = "SI"
            .GroupControl1.Text = "REGISTRAR NUEVO MOVIMIENTO"
            .ShowDialog()
            If .Ok = "SI" Then
                Cargar()
            End If
            .Dispose()
        End With        
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        If Me.vDatos.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
            Exit Sub
        End If
        '
        With My.Forms.frmTipoMovimientos
            .Nuevo = "NO"
            .GroupControl1.Text = "ACTUALIZAR DATOS DEL MOVIMIENTO"
            .ID = Me.vDatos.GetFocusedRowCellValue("ID")
            .ShowDialog()
            If .Ok = "SI" Then
                Cargar()
            End If
            .Dispose()
        End With
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        If Me.vDatos.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
            Exit Sub
        End If
        '
        If ObtieneDatos("SELECT * FROM Requisas r WHERE r.Movimiento_ID = " & Me.vDatos.GetFocusedRowCellValue("ID") & "" _
                            + " AND r.empresa = " & EmpresaActual).Rows.Count > 0 Then
            XtraMsg("El Registro Seleccionado contiene Movimientos Realizados, No se puede Borrar", MessageBoxIcon.Error)
            Exit Sub
        Else
            If XtraMsg2("Esta Seguro de Borrar el Tipo de Movimiento: " + Me.vDatos.GetFocusedRowCellValue("Nombre") + "?") Then
                If GuardaDatos("DELETE FROM TipoMovimientos WHERE ID = " & Me.vDatos.GetFocusedRowCellValue("ID") & " AND Empresa = " & EmpresaActual) Then
                    Cargar()
                End If
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