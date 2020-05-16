Public Class frmCostoEditar

    Public IdMovimiento As String = "0"
    Public IdBodega As String = ""
    Public TipoDocumento As String = ""
    'Public Tipo As Integer = 0


    Private Sub frmCostoEditar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Sub Cargar()
        dgDatos.DataSource = ObtieneDatos("JAR_GetDetalleMovimiento '" & IdMovimiento & "','" & IdBodega & "','" & TipoDocumento & "'," & EmpresaActual)

        vDatos.PopulateColumns()
        FormatoGrid(vDatos)
        '
        For i As Integer = 0 To vDatos.Columns.Count - 1
            vDatos.Columns(i).OptionsColumn.AllowEdit = False
        Next
        '
        vDatos.Columns("codigo_bodega").Visible = False
        vDatos.Columns("tipo_documento").Visible = False
        'vDatos.Columns("codigo_bodega").Visible = False
        '
        vDatos.Columns("Costo Transaccion").OptionsColumn.AllowEdit = True
        vDatos.Columns("Costo Anterior").OptionsColumn.AllowEdit = True
        vDatos.Columns("Costo Promedio").OptionsColumn.AllowEdit = True
        '
        vDatos.Columns("Costo Transaccion").ColumnEdit = txtCosto
        vDatos.Columns("Costo Anterior").ColumnEdit = txtCosto
        vDatos.Columns("Costo Promedio").ColumnEdit = txtCosto
        '
        vDatos.Columns("Costo Transaccion").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        vDatos.Columns("Costo Transaccion").DisplayFormat.FormatString = "{0:n6}"
        '
        vDatos.Columns("Costo Anterior").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        vDatos.Columns("Costo Anterior").DisplayFormat.FormatString = "{0:n6}"
        '
        vDatos.Columns("Costo Promedio").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        vDatos.Columns("Costo Promedio").DisplayFormat.FormatString = "{0:n6}"
        '
        vDatos.BestFitColumns()
    End Sub

    Private Sub bGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bGuardar.Click
        If vDatos.DataRowCount = 0 Then
            XtraMsg("No hay datos en el detalle del Movimiento")
            Exit Sub
        End If
        '
        If Not XtraMsg2("Esta Seguro de la Acción Solicitada?") Then
            Exit Sub
        End If
        '
        Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
        Conn.IniciarTransaccion()
        Try
            For i As Integer = 0 To vDatos.DataRowCount - 1
                Conn.RemoveParameters()
                Conn.AddParameter("Codigo", SqlDbType.NVarChar, 50, ParameterDirection.Input, vDatos.GetRowCellValue(i, "Codigo"))
                Conn.AddParameter("Docuemento", SqlDbType.NVarChar, 50, ParameterDirection.Input, IdMovimiento)
                Conn.AddParameter("Bodega", SqlDbType.NVarChar, 50, ParameterDirection.Input, IdBodega)
                Conn.AddParameter("TipoDocumento", SqlDbType.NVarChar, 50, ParameterDirection.Input, TipoDocumento)
                Conn.AddParameter("CostoT", SqlDbType.Decimal, 20, ParameterDirection.Input, vDatos.GetRowCellValue(i, "Costo Transaccion"))
                Conn.AddParameter("CostoA", SqlDbType.Decimal, 20, ParameterDirection.Input, vDatos.GetRowCellValue(i, "Costo Anterior"))
                Conn.AddParameter("CostoP", SqlDbType.Decimal, 20, ParameterDirection.Input, vDatos.GetRowCellValue(i, "Costo Promedio"))
                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                '
                Conn.EjecutarComando("JAR_ActualizarCosto")
            Next
            '
            Conn.CompletarTransaccion()
            XtraMsg("Cambios Actualizados con Exito!")
            Cargar()
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            Conn.AnularTransaccion()
        End Try
        
    End Sub

    Private Sub bSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSalir.Click
        Close()
    End Sub
End Class