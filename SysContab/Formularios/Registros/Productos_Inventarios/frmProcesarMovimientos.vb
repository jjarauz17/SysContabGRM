Public Class frmProcesarMovimientos

    Public IdRequisa As Integer
    Public dtMov As DataTable
    Public Permitir As Boolean = True

    Private Sub frmProcesarMovimientos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cargar()
        '' Me.Fecha.DateTime = VB.SysContab.Rutinas.Fecha()
    End Sub

    Sub Cargar()
        Me.dgDatos.DataSource = dtMov 'ObtieneDatos("sp_MovimientoDetalle " & IdRequisa & "," & EmpresaActual)
        Me.vDatos.PopulateColumns()
        FormatoGrid(Me.vDatos)
        '
        For i As Integer = 0 To Me.vDatos.Columns.Count - 1
            Me.vDatos.Columns(i).OptionsColumn.AllowEdit = False
            Me.vDatos.Columns(i).OptionsColumn.AllowFocus = False
        Next
        '
        Me.vDatos.Columns("CODIGO_BODEGA").Visible = False
        Me.vDatos.Columns("tipo_articulo").Visible = False
        Me.vDatos.Columns("req_tipo").Visible = False
        Me.vDatos.Columns("Movimiento_Nombre").Visible = False

        Me.vDatos.Columns("Costo").OptionsColumn.AllowEdit = Permitir
        Me.vDatos.Columns("Costo").OptionsColumn.AllowFocus = Permitir
        Me.vDatos.Columns("Costo").ColumnEdit = txtCosto
        '
        Me.vDatos.Columns("Cantidad").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("Cantidad").DisplayFormat.FormatString = "{0:n4}"
        'Me.vDatos.Columns("Cantidad").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.vDatos.Columns("Cantidad").SummaryItem.DisplayFormat = "{0:n2}"
        '
        Me.vDatos.Columns("Costo").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("Costo").DisplayFormat.FormatString = "{0:n6}"
        'Me.vDatos.Columns("Costo").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.vDatos.Columns("Costo").SummaryItem.DisplayFormat = "{0:n4}"
        '
        Me.vDatos.Columns("Costo Total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("Costo Total").DisplayFormat.FormatString = "{0:n6}"
        Me.vDatos.Columns("Costo Total").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("Costo Total").SummaryItem.DisplayFormat = "{0:n6}"
        '
        Me.vDatos.BestFitColumns()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        Dim valida As Boolean = False
        Dim cont As Integer = 0

        For i As Integer = 0 To Me.vDatos.DataRowCount - 1
            If CDbl(Me.vDatos.GetRowCellValue(i, "Costo")) = 0 Then
                valida = True
                cont += 1
            End If
        Next
        '
        If valida Then
            If Not XtraMsg2("Existen " + cont.ToString + " Items sin Costo" & vbCrLf & " Desea procesar los productos de todas formas?.") Then
                Exit Sub
            End If

        End If
        '
        If Not XtraMsg2("Esta Seguro que los Datos son Correctos?") Then
            Exit Sub
        End If

        Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
        Conn.IniciarTransaccion()
        '
        Me.ProgressBarControl1.Properties.Minimum = 0
        Me.ProgressBarControl1.Properties.Maximum = Me.vDatos.DataRowCount
        '
        Try
            For i As Integer = 0 To Me.vDatos.DataRowCount - 1
                Try
                    'Agregar La Transaccion en la Bodega
                    Conn.RemoveParameters()
                    Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                    Conn.AddParameter("Documento", SqlDbType.Int, 5, ParameterDirection.Input, Me.vDatos.GetRowCellValue(i, "Numero"))
                    Conn.AddParameter("Tipo", SqlDbType.NVarChar, 5, ParameterDirection.Input, "R")
                    Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, CDate(Me.vDatos.GetRowCellValue(i, "Fecha")).Date)
                    Conn.AddParameter("Bodega", SqlDbType.NVarChar, 15, ParameterDirection.Input, Me.vDatos.GetRowCellValue(i, "CODIGO_BODEGA"))
                    Conn.AddParameter("Proveedor", SqlDbType.Int, 5, ParameterDirection.Input, 0)
                    Conn.EjecutarComando("SP_Transaccion_Bodega_Add")
                Catch ex As Exception
                    'Si da error es porque ya se registro en la bodega.
                End Try

                'Agregar las existencias a la bodega
                Conn.RemoveParameters()
                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                Conn.AddParameter("Bodega", SqlDbType.NVarChar, 10, ParameterDirection.Input, Me.vDatos.GetRowCellValue(i, "CODIGO_BODEGA"))
                Conn.AddParameter("Articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, Me.vDatos.GetRowCellValue(i, "Items"))
                Conn.AddParameter("Existencia", SqlDbType.Money, 20, ParameterDirection.Input, IIf(Me.vDatos.GetRowCellValue(i, "Movimiento") = "Entrada", Me.vDatos.GetRowCellValue(i, "Cantidad"), Me.vDatos.GetRowCellValue(i, "Cantidad") * -1))
                Conn.AddParameter("Costo", SqlDbType.Decimal, 20, ParameterDirection.Input, Me.vDatos.GetRowCellValue(i, "Costo"))
                Conn.AddParameter("Articulo_Tipo", SqlDbType.NVarChar, 20, ParameterDirection.Input, Me.vDatos.GetRowCellValue(i, "tipo_articulo"))
                Conn.EjecutarComando("SP_Bodega_Articulos_Add")

                'Agregar el detalle de transaccion de bodega
                Conn.RemoveParameters()
                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                Conn.AddParameter("Bodega", SqlDbType.NVarChar, 10, ParameterDirection.Input, Me.vDatos.GetRowCellValue(i, "CODIGO_BODEGA"))
                Conn.AddParameter("Articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, Me.vDatos.GetRowCellValue(i, "Items"))
                Conn.AddParameter("Tipo", SqlDbType.NVarChar, 20, ParameterDirection.Input, "R")
                Conn.AddParameter("Documento", SqlDbType.NVarChar, 20, ParameterDirection.Input, Me.vDatos.GetRowCellValue(i, "Numero"))
                Conn.AddParameter("Proveedor", SqlDbType.Int, 10, ParameterDirection.Input, 0)
                Conn.AddParameter("Movimiento", SqlDbType.NVarChar, 10, ParameterDirection.Input, Me.vDatos.GetRowCellValue(i, "req_tipo"))
                Conn.AddParameter("Existencia", SqlDbType.Decimal, 20, ParameterDirection.Input, Me.vDatos.GetRowCellValue(i, "Cantidad"))
                Conn.AddParameter("Costo", SqlDbType.Decimal, 20, ParameterDirection.Input, Me.vDatos.GetRowCellValue(i, "Costo"))
                Conn.AddParameter("Articulo_Tipo", SqlDbType.NVarChar, 20, ParameterDirection.Input, Me.vDatos.GetRowCellValue(i, "tipo_articulo"))
                Conn.EjecutarComando("SP_Transaccion_Bodega_Detalle_Add")
                '
                Conn.RemoveParameters()
                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Me.vDatos.GetRowCellValue(i, "Numero"))
                Conn.AddParameter("Articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, Me.vDatos.GetRowCellValue(i, "Items"))
                Conn.AddParameter("TArticulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, Me.vDatos.GetRowCellValue(i, "tipo_articulo"))
                Conn.AddParameter("Cantidad", SqlDbType.Decimal, 20, ParameterDirection.Input, Me.vDatos.GetRowCellValue(i, "Cantidad"))
                Conn.AddParameter("Precio", SqlDbType.Decimal, 20, ParameterDirection.Input, Me.vDatos.GetRowCellValue(i, "Costo"))
                Conn.EjecutarComando("SP_Requisas_Detalle_Add")
                '
                Conn.RemoveParameters()
                Conn.AddParameter("Numero", SqlDbType.Int, 5, ParameterDirection.Input, Me.vDatos.GetRowCellValue(i, "Numero"))
                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                Conn.EjecutarComando("sp_GuardarEstadoMovimiento")
                '
                Me.ProgressBarControl1.Increment(1)
                Me.ProgressBarControl1.Refresh()
            Next

            Conn.CompletarTransaccion()
            '
            XtraMsg("Datos Procesados Correctamente!", MessageBoxIcon.Information)
            Me.ProgressBarControl1.EditValue = 0
            Me.btnProcesar.Enabled = False

            Dim f As frmRequisas_List = frmRequisas_List.Instance()
            f.GetData()
        Catch ex As Exception
            XtraMsg(ex.Message & ". Procesar", MessageBoxIcon.Error)
            Conn.AnularTransaccion()
        End Try
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        My.Forms.frmExportarImprimir.Mostrar(Me.dgDatos)
    End Sub

    Private Sub vDatos_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vDatos.CellValueChanged
        If e.Column.FieldName = "Costo" Then
            vDatos.SetRowCellValue(e.RowHandle, "Costo Total", (vDatos.GetRowCellValue(e.RowHandle, "Cantidad") * vDatos.GetRowCellValue(e.RowHandle, "Costo")))
            vDatos.RefreshData()
        End If
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        If Me.CheckEdit1.Checked Then vDatos.ColumnsCustomization()
        If Not Me.CheckEdit1.Checked Then vDatos.DestroyCustomization()
    End Sub

    Private Sub vDatos_HideCustomizationForm(ByVal sender As Object, ByVal e As System.EventArgs) Handles vDatos.HideCustomizationForm
        Me.CheckEdit1.Checked = False
    End Sub

    Private Sub frmProcesarMovimientos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim f As frmRequisas_List = frmRequisas_List.Instance()
        f.vDatos.Columns("Fecha").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Max
    End Sub
End Class