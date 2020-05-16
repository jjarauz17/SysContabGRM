Imports System.Data
Imports System.Data.SqlClient

Public Class frmProcesarTraslados

    Public Desde As Date
    Public Hasta As Date
    Public Permitir As Boolean = True
    Public Begin As Boolean = False

    Private Sub frmProcesarTraslados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''Fecha.DateTime = VB.SysContab.Rutinas.Fecha().Date
        CargarCombo()
        ''  Cargar()
    End Sub

    Sub CargarCombo()
        'Me.cbTipo.Properties.DataSource = ObtieneDatos("JAR_GetTipoTraslados " & EmpresaActual)
        'Me.cbTipo.Properties.ValueMember = "ID"
        'Me.cbTipo.Properties.DisplayMember = "Nombre"
        'Me.cbTipo.Properties.PopulateColumns()
        '''
        'Me.cbTipo.Properties.Columns(0).Visible = False
        'Me.cbTipo.ItemIndex = 0

        GetTiposTrasladosCheck(cbCheckTipo)
        cbCheckTipo.CheckAll()

        Me.dgTipo.DataSource = ObtieneDatos("JAR_GetTipoTrasladosGrid " & EmpresaActual)
        Me.vTipo.PopulateColumns()
        FormatoGrid(vTipo)
        ''
        For i As Integer = 0 To Me.vTipo.Columns.Count - 1
            Me.vTipo.Columns(i).OptionsColumn.AllowEdit = False
        Next

        Me.vTipo.Columns("Seleccionar").OptionsColumn.AllowEdit = True
        Me.vTipo.Columns("ID").Visible = False
        Me.vTipo.BestFitColumns()
    End Sub

    Sub Cargar()
        If Not Begin Then ShowSplash()
        '
        Me.dgDatos.DataSource = ObtieneDatos("SET DATEFORMAT dmy; EXEC JAR_MovimientoTraslados_Detalle '" & Desde & "','" & Hasta & "','" & cbCheckTipo.EditValue & "'," & EmpresaActual)
        Me.vDatos.PopulateColumns()
        FormatoGrid(Me.vDatos)
        '
        Formato()
        '
        If Not Begin Then HideSplash()
    End Sub

    Sub Formato()
        For i As Integer = 0 To Me.vDatos.Columns.Count - 1
            Me.vDatos.Columns(i).OptionsColumn.AllowEdit = False
            Me.vDatos.Columns(i).OptionsColumn.AllowFocus = False
        Next
        '
        Me.vDatos.Columns("Movimiento_Nombre").OptionsColumn.AllowEdit = True
        Me.vDatos.Columns("Movimiento_Nombre").OptionsColumn.AllowFocus = True
        Me.vDatos.Columns("Movimiento_Nombre").OptionsColumn.ReadOnly = True

        Me.vDatos.Columns("CODIGO_BODEGA").Visible = False
        Me.vDatos.Columns("CODIGO_BODEGAD").Visible = False
        Me.vDatos.Columns("#Entrada").Visible = False
        Me.vDatos.Columns("tipo_articulo").Visible = False
        Me.vDatos.Columns("req_tipo").Visible = False
        ''Me.vDatos.Columns("Movimiento_Nombre").Visible = False

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
        'Me.vDatos.BestFitColumns()
    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        If vDatos.DataRowCount = 0 Then Exit Sub

        If Not XtraMsg2("Esta Seguro que los Datos son Correctos?") Then
            Exit Sub
        End If

        Dim Data As DataTable = ObtieneDatos("SET DATEFORMAT dmy; EXEC JAR_NumerosTraslados '" & Desde & "','" & Hasta & "','" & cbCheckTipo.EditValue & "'," & EmpresaActual)
        '
        Me.ProgressBarControl1.Properties.Minimum = 0        
        Me.ProgressBarControl1.Properties.Maximum = Data.Rows.Count

        'For i As Integer = 0 To vDatos.DataRowCount - 1
        For i As Integer = 0 To Data.Rows.Count - 1
            Dim valida As Boolean = False

            'Conn.RemoveParameters()
            'Conn.AddParameter("Req_Codigo", SqlDbType.Int, 5, ParameterDirection.Input, Data.Rows.Item(i)("Numero"))
            'Conn.AddParameter("Empresa", SqlDbType.NVarChar, 15, ParameterDirection.Input, EmpresaActual)
            'Dim dtl As DataTable = Conn.EjecutarComando("JAR_GetDetalleTraslado", "")

            Dim dtl As DataTable = ObtieneDatos("JAR_GetDetalleTraslado " & Data.Rows.Item(i)("Numero") & "," & EmpresaActual)

            If dtl.Rows.Count > 0 Then
                For j As Integer = 0 To dtl.Rows.Count - 1
                    If dtl.Rows.Item(j)("Cantidad") <= dtl.Rows.Item(j)("Existencia") Then
                        If dtl.Rows.Item(j)("Costo") > 0 Then
                            '' Armar el desturque
                            valida = True
                        Else
                            GoTo SALTAR
                        End If
                    Else
                        GoTo SALTAR
                    End If
                Next
            Else
                GoTo SALTAR
            End If

            ''Realizar el Traslado
            If valida Then
                Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
                Conn.IniciarTransaccion()

                Try
                    Try
                        'Agregar La Transaccion en la Bodega para la Salida
                        Conn.RemoveParameters()
                        Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                        Conn.AddParameter("Bodega", SqlDbType.NVarChar, 15, ParameterDirection.Input, Data.Rows.Item(i)("Origen"))
                        Conn.AddParameter("Tipo", SqlDbType.NVarChar, 5, ParameterDirection.Input, "T")
                        Conn.AddParameter("Documento", SqlDbType.NVarChar, 20, ParameterDirection.Input, Data.Rows.Item(i)("Numero"))
                        Conn.AddParameter("Proveedor", SqlDbType.Int, 5, ParameterDirection.Input, 0)
                        Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, CDate(Data.Rows.Item(i)("Fecha")).Date)
                        Conn.AddParameter("Bodega_ref", SqlDbType.NVarChar, 20, ParameterDirection.Input, Data.Rows.Item(i)("Destino"))
                        Conn.AddParameter("Tipo_documento_ref", SqlDbType.NVarChar, 20, ParameterDirection.Input, "T")
                        Conn.AddParameter("Documento_ref", SqlDbType.NVarChar, 20, ParameterDirection.Input, Data.Rows.Item(i)("#Entrada"))
                        Conn.AddParameter("Tipo_movimiento", SqlDbType.NVarChar, 20, ParameterDirection.Input, "S")

                        Conn.EjecutarComando("SP_Transaccion_Bodega_Add")
                        ''
                        'Agregar La Transaccion en la Bodega para la Entrada
                        Conn.RemoveParameters()
                        Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                        Conn.AddParameter("Bodega", SqlDbType.NVarChar, 15, ParameterDirection.Input, Data.Rows.Item(i)("Destino"))
                        Conn.AddParameter("Tipo", SqlDbType.NVarChar, 5, ParameterDirection.Input, "T")
                        Conn.AddParameter("Documento", SqlDbType.NVarChar, 20, ParameterDirection.Input, Data.Rows.Item(i)("#Entrada"))
                        Conn.AddParameter("Proveedor", SqlDbType.Int, 5, ParameterDirection.Input, 0)
                        Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, CDate(Data.Rows.Item(i)("Fecha")).Date)
                        Conn.AddParameter("Bodega_ref", SqlDbType.NVarChar, 20, ParameterDirection.Input, Data.Rows.Item(i)("Origen"))
                        Conn.AddParameter("Tipo_documento_ref", SqlDbType.NVarChar, 20, ParameterDirection.Input, "T")
                        Conn.AddParameter("Documento_ref", SqlDbType.NVarChar, 20, ParameterDirection.Input, Data.Rows.Item(i)("Numero"))
                        Conn.AddParameter("Tipo_movimiento", SqlDbType.NVarChar, 20, ParameterDirection.Input, "E")

                        Conn.EjecutarComando("SP_Transaccion_Bodega_Add")
                    Catch ex As Exception
                    End Try

                    For j As Integer = 0 To dtl.Rows.Count - 1
                        ''****************  PROCESAR SALIDA ************************
                        'Agregar las existencias a la bodega
                        Conn.RemoveParameters()
                        Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                        Conn.AddParameter("Bodega", SqlDbType.NVarChar, 10, ParameterDirection.Input, Data.Rows.Item(i)("Origen"))
                        Conn.AddParameter("Articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, dtl.Rows.Item(j)("Codigo"))
                        Conn.AddParameter("Existencia", SqlDbType.Decimal, 20, ParameterDirection.Input, dtl.Rows.Item(j)("Cantidad") * -1)
                        Conn.AddParameter("Costo", SqlDbType.Decimal, 20, ParameterDirection.Input, dtl.Rows.Item(j)("Costo"))
                        Conn.AddParameter("Articulo_Tipo", SqlDbType.NVarChar, 20, ParameterDirection.Input, dtl.Rows.Item(j)("Tipo"))
                        Conn.EjecutarComando("SP_Bodega_Articulos_Add")
                        ''
                        'Agregar el detalle de transaccion de bodega
                        Conn.RemoveParameters()
                        Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                        Conn.AddParameter("Bodega", SqlDbType.NVarChar, 10, ParameterDirection.Input, Data.Rows.Item(i)("Origen"))
                        Conn.AddParameter("Articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, dtl.Rows.Item(j)("Codigo"))
                        Conn.AddParameter("Tipo", SqlDbType.NVarChar, 20, ParameterDirection.Input, "T")
                        Conn.AddParameter("Documento", SqlDbType.NVarChar, 20, ParameterDirection.Input, Data.Rows.Item(i)("Numero"))
                        Conn.AddParameter("Proveedor", SqlDbType.Int, 10, ParameterDirection.Input, 0)
                        Conn.AddParameter("Movimiento", SqlDbType.NVarChar, 10, ParameterDirection.Input, "S")
                        Conn.AddParameter("Existencia", SqlDbType.Decimal, 20, ParameterDirection.Input, dtl.Rows.Item(j)("Cantidad"))
                        Conn.AddParameter("Costo", SqlDbType.Decimal, 20, ParameterDirection.Input, dtl.Rows.Item(j)("Costo"))
                        Conn.AddParameter("Articulo_Tipo", SqlDbType.NVarChar, 20, ParameterDirection.Input, dtl.Rows.Item(j)("Tipo"))
                        Conn.EjecutarComando("SP_Transaccion_Bodega_Detalle_Add")

                        'Actualizar Costo en la Salida (Requisa de Salida)
                        Conn.RemoveParameters()
                        Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                        Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Data.Rows.Item(i)("Numero"))
                        Conn.AddParameter("Articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, dtl.Rows.Item(j)("Codigo"))
                        Conn.AddParameter("TArticulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, dtl.Rows.Item(j)("Tipo"))
                        Conn.AddParameter("Cantidad", SqlDbType.Decimal, 20, ParameterDirection.Input, dtl.Rows.Item(j)("Cantidad"))
                        Conn.AddParameter("Precio", SqlDbType.Decimal, 20, ParameterDirection.Input, dtl.Rows.Item(j)("Costo"))
                        Conn.EjecutarComando("SP_Requisas_Detalle_Add")

                        'Actualizar Estado del Movimiento
                        Conn.RemoveParameters()
                        Conn.AddParameter("Numero", SqlDbType.Int, 5, ParameterDirection.Input, Data.Rows.Item(i)("Numero"))
                        Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                        Conn.EjecutarComando("sp_GuardarEstadoMovimiento")

                        ''****************  PROCESAR ENTRADA ************************

                        'Agregar las existencias a la bodega
                        Conn.RemoveParameters()
                        Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                        Conn.AddParameter("Bodega", SqlDbType.NVarChar, 10, ParameterDirection.Input, Data.Rows.Item(i)("Destino"))
                        Conn.AddParameter("Articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, dtl.Rows.Item(j)("Codigo"))
                        Conn.AddParameter("Existencia", SqlDbType.Decimal, 20, ParameterDirection.Input, dtl.Rows.Item(j)("Cantidad"))
                        Conn.AddParameter("Costo", SqlDbType.Decimal, 20, ParameterDirection.Input, dtl.Rows.Item(j)("Costo"))
                        Conn.AddParameter("Articulo_Tipo", SqlDbType.NVarChar, 20, ParameterDirection.Input, dtl.Rows.Item(j)("Tipo"))
                        Conn.EjecutarComando("SP_Bodega_Articulos_Add")

                        'Agregar el detalle de transaccion de bodega
                        Conn.RemoveParameters()
                        Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                        Conn.AddParameter("Bodega", SqlDbType.NVarChar, 10, ParameterDirection.Input, Data.Rows.Item(i)("Destino"))
                        Conn.AddParameter("Articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, dtl.Rows.Item(j)("Codigo"))
                        Conn.AddParameter("Tipo", SqlDbType.NVarChar, 20, ParameterDirection.Input, "T")
                        Conn.AddParameter("Documento", SqlDbType.NVarChar, 20, ParameterDirection.Input, Data.Rows.Item(i)("#Entrada"))
                        Conn.AddParameter("Proveedor", SqlDbType.Int, 10, ParameterDirection.Input, 0)
                        Conn.AddParameter("Movimiento", SqlDbType.NVarChar, 10, ParameterDirection.Input, "E")
                        Conn.AddParameter("Existencia", SqlDbType.Decimal, 20, ParameterDirection.Input, dtl.Rows.Item(j)("Cantidad"))
                        Conn.AddParameter("Costo", SqlDbType.Decimal, 20, ParameterDirection.Input, dtl.Rows.Item(j)("Costo"))
                        Conn.AddParameter("Articulo_Tipo", SqlDbType.NVarChar, 20, ParameterDirection.Input, dtl.Rows.Item(j)("Tipo"))
                        Conn.EjecutarComando("SP_Transaccion_Bodega_Detalle_Add")

                        'Actualizar Costo en la Entrada (Requisa de Entrada)
                        Conn.RemoveParameters()
                        Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                        Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Data.Rows.Item(i)("#Entrada"))
                        Conn.AddParameter("Articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, dtl.Rows.Item(j)("Codigo"))
                        Conn.AddParameter("TArticulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, dtl.Rows.Item(j)("Tipo"))
                        Conn.AddParameter("Cantidad", SqlDbType.Decimal, 20, ParameterDirection.Input, dtl.Rows.Item(j)("Cantidad"))
                        Conn.AddParameter("Precio", SqlDbType.Decimal, 20, ParameterDirection.Input, dtl.Rows.Item(j)("Costo"))
                        Conn.EjecutarComando("SP_Requisas_Detalle_Add")

                        'Actualizar Estado del Movimiento
                        Conn.RemoveParameters()
                        Conn.AddParameter("Numero", SqlDbType.Int, 5, ParameterDirection.Input, Data.Rows.Item(i)("#Entrada"))
                        Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                        Conn.EjecutarComando("sp_GuardarEstadoMovimiento")
                    Next

                    Conn.CompletarTransaccion()
                Catch ex As Exception
                    XtraMsg(ex.Message & ". Procesar", MessageBoxIcon.Error)
                    Conn.AnularTransaccion()
                    GoTo SALTAR
                End Try
            End If
SALTAR:
            ProgressBarControl1.Increment(1)
            ProgressBarControl1.Refresh()
        Next
        '
        XtraMsg("Datos Procesados Correctamente!", MessageBoxIcon.Information)
        Me.ProgressBarControl1.EditValue = 0
        Cargar()
        ''Me.btnProcesar.Enabled = False

        Dim f As frmRequisas_List = frmRequisas_List.Instance()
        f.GetData()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        frmExportarImprimir.Mostrar(Me.dgDatos)
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Close()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        If Me.CheckEdit1.Checked Then vDatos.ColumnsCustomization()
        If Not Me.CheckEdit1.Checked Then vDatos.DestroyCustomization()
    End Sub

    Private Sub vDatos_HideCustomizationForm(ByVal sender As Object, ByVal e As System.EventArgs) Handles vDatos.HideCustomizationForm
        Me.CheckEdit1.Checked = False
    End Sub

    Private Sub vDatos_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vDatos.CellValueChanged
        If e.Column.FieldName = "Costo" Then
            Try
                vDatos.SetRowCellValue(e.RowHandle, "Costo Total", CDbl(e.Value * vDatos.GetRowCellValue(e.RowHandle, "Cantidad")))
                vDatos.RefreshData()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Dim selec As Boolean = False
        For i As Integer = 0 To Me.vTipo.DataRowCount - 1
            If Me.vTipo.GetRowCellValue(i, "Seleccionar") Then
                selec = True
            End If
        Next

        If Not selec Then
            XtraMsg("Debe Seleccionar al Menos 1 Tipo de Movimiento")
            Exit Sub
        End If

        Dim dt As New DataTable

        For i As Integer = 0 To Me.vTipo.DataRowCount - 1
            If Me.vTipo.GetRowCellValue(i, "Seleccionar") Then
                Dim da As New SqlDataAdapter("SET DATEFORMAT dmy; EXEC JAR_MovimientoTraslados_Detalle '" & Desde & "','" & Hasta & "'," & Me.vTipo.GetRowCellValue(i, "ID") & "," & EmpresaActual, VB.SysContab.Rutinas.AbrirConexion())
                da.Fill(dt)
            End If
        Next

        Me.dgDatos.DataSource = dt
        Me.vDatos.PopulateColumns()
        FormatoGrid(Me.vDatos)
        ''
        Formato()
        DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
    End Sub

    Private Sub cbCheckTipo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCheckTipo.EditValueChanged
        Cargar()
        If Begin = True Then Begin = False
    End Sub
End Class