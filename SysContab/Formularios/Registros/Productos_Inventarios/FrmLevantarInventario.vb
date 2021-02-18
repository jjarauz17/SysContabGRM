Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI

Public Class FrmLevantarInventario

    Public IdInventario As Integer = 0
    Private Data As New DataTable("Inventario")
    Public IdRequisa As Integer = 0

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        FrmInventarioList.Cargar()
        Close()
    End Sub

    Private Sub FrmLevantarInventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)

        GetBodegasList(Bodega)
        'GetBodegasxUsuario(Bodega, 0)

        Fecha.EditValue = VB.SysContab.Rutinas.Fecha().Date
        Elaborado.Text = Usuario

        If IdInventario > 0 Then
            Dim DT As DataTable = ObtieneDatos("SELECT * FROM Inventario_fisico where idinventario = " & IdInventario)

            If DT.Rows.Count > 0 Then
                Tipo.EditValue = DT.Rows(0).Item("origen")
                Fecha.EditValue = DT.Rows(0).Item("Fecha")
                Bodega.EditValue = DT.Rows(0).Item("Codigo_Bodega")
                Elaborado.Text = DT.Rows(0).Item("realizadopor")
                txtNumero.Text = DT.Rows(0).Item("documento")
                txtComentario.Text = DT.Rows(0).Item("Comentario")

                Bodega.Properties.ReadOnly = True
                Fecha.Properties.ReadOnly = True
                Elaborado.Properties.ReadOnly = True
                Tipo.Properties.ReadOnly = True

                If DT.Rows(0).Item("Autorizado") Then Guardar.Enabled = False
            End If
        Else
            txtNumero.Text = ObtieneDatos("JAR_GetNumeroInventarioFisico", EmpresaActual).Rows.Item(0)(0)
        End If

        '  ListaArticulos()
    End Sub

    Private Sub Formato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Formato.Click        
        frmInventarioFisicoLineas.Tipo = Tipo.EditValue
        frmInventarioFisicoLineas.ShowDialog()
        frmInventarioFisicoLineas.Dispose()
    End Sub

    Private Sub Tipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tipo.SelectedIndexChanged, Bodega.EditValueChanged
        Try
            ListaArticulos()
            CargaInventario()
        Catch ex As Exception
        End Try

    End Sub

    'Private Sub ListaArticulos()
    '    Dim DT As DataTable
    '    DT = ObtieneDatos("SP_GetArticulo " & EmpresaActual & ",'" & Tipo.EditValue & "'")
    '    ItemProducto.DataSource = DT
    '    ItemProducto.DisplayMember = "Codigo"
    '    ItemProducto.ValueMember = "Codigo"
    '    ItemProducto.PopulateColumns()
    '    ItemProductoD.DataSource = DT
    '    ItemProductoD.DisplayMember = "Nombre"
    '    ItemProductoD.ValueMember = "Codigo"
    '    ItemProductoD.PopulateColumns()
    '    ItemProducto.PopupWidth = 350
    '    ItemProductoD.PopupWidth = 350
    'End Sub

    Private Sub ListaArticulos()
        Dim DT As DataTable
        DT = ObtieneDatos("SP_ArticulosGetAll '" & Tipo.EditValue & "'," & EmpresaActual & ",'" & Bodega.EditValue & "'")
        RepositoryGridLookup(cbItem, DT, "Codigo", "Codigo", 3, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31)


        'ItemProducto.DataSource = DT
        'ItemProducto.DisplayMember = "Codigo"
        'ItemProducto.ValueMember = "Codigo"
        'ItemProducto.PopulateColumns()
        'For i As Integer = 2 To ItemProducto.Columns.Count - 1
        '    ItemProducto.Columns(i).Visible = False
        'Next
        'Me.ItemProducto.Columns("Nombre").Visible = True

        'ItemProductoD.DataSource = DT
        'ItemProductoD.DisplayMember = "Nombre"
        'ItemProductoD.ValueMember = "Codigo"
        'ItemProductoD.PopulateColumns()
        'For i As Integer = 2 To ItemProductoD.Columns.Count - 1
        '    ItemProductoD.Columns(i).Visible = False
        'Next
        'ItemProductoD.Columns("Codigo").Visible = True
    End Sub

    'Private Sub Bodega_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bodega.EditValueChanged
    '    ListaArticulos()
    '    CargaInventario()
    'End Sub

    Private Sub CargaInventario()

        Dim Variables As New ArrayList
        Dim Datos As New ArrayList

        Variables.Add("Bodega")
        Variables.Add("Tipo")
        Variables.Add("IdInventario")
        ' Variables.Add("Fecha")
        Variables.Add("Empresa")

        Datos.Add(IIf(Bodega.EditValue Is Nothing, "0", Bodega.EditValue))
        Datos.Add(Tipo.EditValue)
        Datos.Add(IdInventario)
        ' Datos.Add(Fecha.DateTime.Date)
        Datos.Add(EmpresaActual)

        Data = ProcedureParameters(Datos, Variables, "RCT_SPGetInventarioFisico")
        iGrid.DataSource = Data

        'Try
        '    If DateDiff(DateInterval.Month, Fecha.EditValue, VB.SysContab.Rutinas.Fecha().Date) > 30 Then
        '        Data = ProcedureParameters(Datos, Variables, "RCT_SPGetInventarioFisicoSaved")
        '        Guardar.Visible = False
        '    Else
        '        Data = ProcedureParameters(Datos, Variables, "RCT_SPGetInventarioFisico")
        '    End If
        '    'ObtieneData("RCT_SPGetInventarioFisico '" & Bodega.EditValue & "','" & Tipo.EditValue & "'," & IdInventario & ",'" & Fecha.DateTime.Date & "'")
        '    iGrid.DataSource = Data
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles iVista.CellValueChanged
        If e.Column.FieldName = "Codigo" Then

            If Data.Compute("Count(Codigo)", "Codigo = '" & e.Value & "'") >= 1 Then
                XtraMsg("Ya existe este articulo en la lista")
                iVista.DeleteRow(iVista.FocusedRowHandle)
            End If

            Try
                'vDatos.SetRowCellValue(e.RowHandle, "Existencia", ObtieneDatos("SELECT ISNULL(SUM(Existencia),0) FROM Bodegas_Articulos WHERE Empresa = " & EmpresaActual & " AND Codigo_Bodega = '" & cmbbodega.EditValue & "' AND Codigo_Articulo = '" & e.Value & "'").Rows(0).Item(0))
                'vDatos.SetRowCellValue(e.RowHandle, "Costo", ObtieneDatos("SELECT isnull(costo,0) FROM Bodegas_Articulos WHERE Empresa = " & EmpresaActual & " AND Codigo_Bodega = '" & cmbbodega.EditValue & "' AND Codigo_Articulo = '" & e.Value & "'").Rows(0).Item(0))
                ' iVista.SetRowCellValue(e.RowHandle, "Existencia", ObtieneDatos("SELECT dbo.fn_CalcularExistenciaREAL('" & Bodega.EditValue & "','" & e.Value & "'," & EmpresaActual & ") Existencia").Rows(0).Item(0))

                iVista.SetRowCellValue(e.RowHandle, "Existencia", ExistenciaReal(e.Value))
                iVista.SetRowCellValue(e.RowHandle, "Costo", ObtieneDatos("SELECT isnull(ba.Costo_Prom,0.00) FROM Bodegas_Articulos ba WHERE Empresa = " & EmpresaActual & " AND Codigo_Bodega = '" & Bodega.EditValue & "' AND Codigo_Articulo = '" & e.Value & "'").Rows(0).Item(0))
                iVista.SetRowCellValue(e.RowHandle, "Fisico", 0.0)
                iVista.SetRowCellValue(e.RowHandle, "Diferencia", iVista.GetRowCellValue(e.RowHandle, "Existencia") * -1)
                iVista.SetRowCellValue(e.RowHandle, "Encontrado", True)

                Dim DR As DataRowView = cbItem.GetRowByKeyValue(e.Value)

                iVista.SetRowCellValue(e.RowHandle, "Item_Nombre", IsNull(DR.Item("Nombre"), ""))
                iVista.SetRowCellValue(e.RowHandle, "Unidad", IsNull(DR.Item("Unidad"), ""))
                iVista.SetRowCellValue(e.RowHandle, "Modelo", IsNull(DR.Item("MODELO"), ""))
                iVista.SetRowCellValue(e.RowHandle, "Ubicacion", IsNull(DR.Item("UBICACION"), ""))
                iVista.SetRowCellValue(e.RowHandle, "Proveedor", IsNull(DR.Item("Proveedor"), ""))

                ' iVista.SetRowCellValue(e.RowHandle, "Justificar", False)
            Catch ex As Exception
                iVista.SetRowCellValue(e.RowHandle, "Existencia", 0)
                iVista.SetRowCellValue(e.RowHandle, "Costo", 0)
                iVista.SetRowCellValue(e.RowHandle, "Fisico", 0)
                iVista.SetRowCellValue(e.RowHandle, "Diferencia", 0)
            End Try

            'iVista.SetRowCellValue(e.RowHandle, "Existencia", ObtieneDatos("SELECT ISNULL(SUM(Existencia),0) FROM Bodegas_Articulos WHERE Empresa = " & EmpresaActual & " AND Codigo_Bodega = '" & Bodega.EditValue & "' AND Codigo_Articulo = '" & e.Value & "'").Rows(0).Item(0))            
            'iVista.SetRowCellValue(e.RowHandle, "Fisico", ObtieneDatos("SELECT isnull(sum(isnull(Fisico,0)),0) FROM inventario_fisico_detalle where codigo_articulo = '" & iVista.GetRowCellValue(e.RowHandle, "Codigo") & "' and idfisico = " & IdInventario & " and articulo_tipo = '" & Tipo.EditValue & "'").Rows(0).Item(0))
            'iVista.SetRowCellValue(e.RowHandle, "Justificar", False)
            'Try
            '    iVista.SetRowCellValue(e.RowHandle, "IdDetalle", ObtieneDatos("SELECT IdDetalle FROM inventario_fisico_detalle where codigo_articulo = '" & iVista.GetRowCellValue(e.RowHandle, "Codigo") & "' and idfisico = " & IdInventario & " and articulo_tipo = '" & Tipo.EditValue & "'").Rows(0).Item(0))
            'Catch ex As Exception
            '    iVista.SetRowCellValue(e.RowHandle, "IdDetalle", 0)
            'End Try
        End If

        If e.Column.FieldName = "Fisico" Then
            Dim Existencia As Double = IIf(IsNull(iVista.GetRowCellValue(e.RowHandle, "Existencia"), 0) < 0, IsNull(iVista.GetRowCellValue(e.RowHandle, "Existencia"), 0) * -1, IsNull(iVista.GetRowCellValue(e.RowHandle, "Existencia") * -1, 0))
            iVista.SetRowCellValue(e.RowHandle, "Diferencia", IsNull(e.Value, 0) + Existencia)

            'Dim DR As DataRowView = ItemProducto.GetDataSourceRowByKeyValue(iVista.GetRowCellValue(e.RowHandle, "Codigo"))
            ' iVista.SetRowCellValue(e.RowHandle, "Precio_Venta", DR.Item("Precio_Venta"))
            ' iVista.SetRowCellValue(e.RowHandle, "Costo_Promedio", DR.Item("Costo_Promedio"))

            ' iVista.SetRowCellValue(e.RowHandle, "Total_Precio", DR.Item("Precio_Venta") * IsNull(iVista.GetRowCellValue(e.RowHandle, "Diferencia"), 0))
            iVista.SetRowCellValue(e.RowHandle, "Total_Costo", iVista.GetRowCellValue(e.RowHandle, "Costo") * IsNull(iVista.GetRowCellValue(e.RowHandle, "Diferencia"), 0))
        End If

        If e.Column.FieldName = "Costo" Then
            iVista.SetRowCellValue(e.RowHandle, "Total_Costo", e.Value * IsNull(iVista.GetRowCellValue(e.RowHandle, "Diferencia"), 0))
        End If

    End Sub

    Function ExistenciaReal(Codigo As String) As Double

        Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
        'Calcular Existencia Real por producto para sacar diferencias contra el Fisico
        Dim Existencia As Double = 0.0

        Try
            Conn.RemoveParameters()
            Conn.AddParameter("Bodega", SqlDbType.NVarChar, 10, ParameterDirection.Input, Bodega.EditValue)
            Conn.AddParameter("Codigo", SqlDbType.NVarChar, 100, ParameterDirection.Input, Codigo)
            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 4, ParameterDirection.Input, Fecha.DateTime.Date)
            Conn.AddParameter("Existencia", SqlDbType.Decimal, 20, ParameterDirection.Output, 0)

            Conn.EjecutarComando("JAR_GetExistenciaReal")
            Existencia = Conn.GetParameter("Existencia").Valor

            Return Existencia
        Catch ex As Exception
            Return 0.0
        End Try

    End Function

    Private Sub Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exportar.Click
        My.Forms.frmExportarImprimir.Mostrar(Me.iGrid)
    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        If Not DxValidationProvider1.Validate Then Exit Sub

        iVista.ActiveFilterString = "'"

        If Bodega.EditValue Is Nothing Then
            XtraMsg("Seleccione la Bodega")
            Bodega.Focus()
            Exit Sub
        End If

        If Fecha.EditValue Is Nothing Then
            XtraMsg("Seleccione la fecha")
            Fecha.Focus()
            Exit Sub
        End If

        pBar.EditValue = 0
        pBar.Properties.Minimum = 0
        pBar.Properties.Maximum = iVista.DataRowCount

        Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion)
        Conn.IniciarTransaccion()

        Try
            If IdInventario = 0 Then txtNumero.Text = ObtieneDatos("JAR_GetNumeroInventarioFisico", EmpresaActual).Rows.Item(0)(0)

            Conn.AddParameter("IdInventario", SqlDbType.Int, 4, ParameterDirection.Input, IdInventario)
            Conn.AddParameter("empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
            Conn.AddParameter("fecha", SqlDbType.SmallDateTime, 4, ParameterDirection.Input, Fecha.DateTime.Date)
            Conn.AddParameter("codigo_bodega", SqlDbType.NVarChar, 50, ParameterDirection.Input, Bodega.EditValue)
            Conn.AddParameter("realizadopor", SqlDbType.NVarChar, 50, ParameterDirection.Input, Elaborado.Text)
            'Conn.AddParameter("Autorizado", SqlDbType.Bit, 1, ParameterDirection.Input, 0)
            'Conn.AddParameter("Autorizadopor", SqlDbType.NVarChar, 50, ParameterDirection.Input, "")
            'Conn.AddParameter("fechaRegistro", SqlDbType.SmallDateTime, 4, ParameterDirection.Input, Now)
            Conn.AddParameter("documento", SqlDbType.NVarChar, 50, ParameterDirection.Input, txtNumero.Text)
            Conn.AddParameter("origen", SqlDbType.NVarChar, 1, ParameterDirection.Input, Tipo.EditValue)
            Conn.AddParameter("Comentario", SqlDbType.NVarChar, -1, ParameterDirection.Input, txtComentario.Text)
            Conn.AddParameter("Id", SqlDbType.Int, 4, ParameterDirection.Output, 0)

            Conn.EjecutarComando("RCT_GuardaInventarioFisico")
            If IdInventario = 0 Then IdInventario = Conn.GetParameter("Id").Valor

            For i As Integer = 0 To iVista.DataRowCount - 1
                Conn.RemoveParameters()
                If Not iVista.GetRowCellValue(i, "Codigo") Is DBNull.Value Then
                    Conn.AddParameter("empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
                    Conn.AddParameter("fecha", SqlDbType.SmallDateTime, 4, ParameterDirection.Input, Fecha.DateTime.Date)
                    Conn.AddParameter("codigo_bodega", SqlDbType.NVarChar, 50, ParameterDirection.Input, Bodega.EditValue)
                    Conn.AddParameter("codigo_articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, iVista.GetRowCellValue(i, "Codigo"))
                    Conn.AddParameter("articulo_tipo", SqlDbType.NVarChar, 1, ParameterDirection.Input, Tipo.EditValue)
                    Conn.AddParameter("existencias", SqlDbType.Float, 8, ParameterDirection.Input, iVista.GetRowCellValue(i, "Existencia"))
                    Conn.AddParameter("fisico", SqlDbType.Float, 8, ParameterDirection.Input, iVista.GetRowCellValue(i, "Fisico"))
                    Conn.AddParameter("diferencias", SqlDbType.Float, 8, ParameterDirection.Input, iVista.GetRowCellValue(i, "Diferencia"))
                    Conn.AddParameter("justificar", SqlDbType.Int, 4, ParameterDirection.Input, IsNull(iVista.GetRowCellValue(i, "Justificar"), 0))
                    Conn.AddParameter("comentarios", SqlDbType.Text, 16, ParameterDirection.Input, IsNull(iVista.GetRowCellValue(i, "Comentarios"), ""))
                    Conn.AddParameter("comentarios_justificar", SqlDbType.Text, 16, ParameterDirection.Input, "")
                    Conn.AddParameter("IdDetalle", SqlDbType.Int, 4, ParameterDirection.Input, IsNull(iVista.GetRowCellValue(i, "IdDetalle"), 0))
                    Conn.AddParameter("IdFisico", SqlDbType.Int, 4, ParameterDirection.Input, IdInventario)
                    Conn.AddParameter("costo", SqlDbType.Float, 8, ParameterDirection.Input, iVista.GetRowCellValue(i, "Costo"))
                    Conn.AddParameter("Unidad", SqlDbType.NVarChar, 50, ParameterDirection.Input, IsNull(iVista.GetRowCellValue(i, "Unidad"), ""))
                    Conn.AddParameter("Modelo", SqlDbType.NVarChar, 50, ParameterDirection.Input, IsNull(iVista.GetRowCellValue(i, "Modelo"), ""))
                    Conn.AddParameter("Ubicacion", SqlDbType.NVarChar, 50, ParameterDirection.Input, IsNull(iVista.GetRowCellValue(i, "Ubicacion"), ""))
                    Conn.AddParameter("Item_Nombre", SqlDbType.NVarChar, 50, ParameterDirection.Input, IsNull(iVista.GetRowCellValue(i, "Item_Nombre"), ""))

                    Conn.EjecutarComando("RCT_SPGuardaInventarioFisicoDetalle")

                End If

                pBar.Increment(1)
                pBar.Refresh()
            Next

            Conn.CompletarTransaccion()

            XtraMsg("Inventario Guardado con Exito!")

            CargaInventario()
        Catch ex As Exception
            Conn.AnularTransaccion()
            XtraMsg("Error : " & ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub



    'Sub GuardaRequisa()

    '    Dim Factor As Integer

    '    Dim Registro As Boolean
    '    Registro = False

    '    Factor = 1
    '    'If cmbrequisa.Text.ToString.Substring(0, 1) = "E" Then Factor = 1 Else Factor = -1

    '    Dim Requisa As Integer
    '    Requisa = VB.SysContab.RequisasDB.GetCodigoNuevo()
    '    Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion)
    '    Conn.IniciarTransaccion()

    '    Try
    '        Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
    '        Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
    '        Conn.AddParameter("TRequisa", SqlDbType.NVarChar, 5, ParameterDirection.Input, Requisa)
    '        Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, Fecha.DateTime.Date)
    '        Conn.AddParameter("Bodega", SqlDbType.NVarChar, 15, ParameterDirection.Input, Bodega.EditValue)
    '        Conn.AddParameter("RealizadoPor", SqlDbType.NVarChar, 50, ParameterDirection.Input, Elaborado.Text)
    '        Conn.AddParameter("Registro", SqlDbType.Bit, 1, ParameterDirection.Input, Registro)
    '        Conn.AddParameter("Factura", SqlDbType.NVarChar, 15, ParameterDirection.Input, "")

    '        Conn.EjecutarComando("SP_Requisas_Add")

    '        If Requisa <> -1 Then
    '            Conn.RemoveParameters()
    '            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
    '            Conn.AddParameter("Documento", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
    '            Conn.AddParameter("Tipo", SqlDbType.NVarChar, 5, ParameterDirection.Input, "R")
    '            Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, Fecha.DateTime.Date)
    '            Conn.AddParameter("Bodega", SqlDbType.NVarChar, 15, ParameterDirection.Input, Bodega.EditValue)
    '            Conn.AddParameter("Proveedor", SqlDbType.Int, 5, ParameterDirection.Input, 0)
    '            Conn.EjecutarComando("SP_Transaccion_Bodega_Add")
    '            'VB.SysContab.BodegasDB.TransaccionBodega_Add(cmbbodega.EditValue, _
    '            '"R", Requisa, fecha.DateTime.Date, "0")
    '        Else
    '            Conn.AnularTransaccion()
    '            Exit Sub
    '        End If

    '        Dim DT As DataTable
    '        'Dim Articulos As New VB.SysContab.ArticulosDB

    '        '            If cmbrequisa.EditValue = 1 Then DT = Data.GetChanges(DataRowState.Added Or DataRowState.Modified) Else DT = Data.GetChanges(DataRowState.Modified)

    '        DT = Data.GetChanges(DataRowState.Added Or DataRowState.Modified)

    '        If Not DT Is Nothing Then
    '            For i As Integer = 0 To DT.Rows.Count - 1
    '                'Agregar las existencias a la bodega
    '                Conn.RemoveParameters()
    '                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
    '                Conn.AddParameter("Bodega", SqlDbType.NVarChar, 10, ParameterDirection.Input, Bodega.EditValue)
    '                Conn.AddParameter("Articulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, DT.Rows(i)("Codigo"))

    '                Dim ValorX As Double = 0
    '                Dim Fila As DataRow = DT.Rows(i)

    '                Try
    '                    If Fila.HasVersion(DataRowVersion.Original) = True Then
    '                        If DT.Rows(i)("Fisico") <> Fila.Item("Fisico", DataRowVersion.Original) Then
    '                            If DT.Rows(i)("Fisico") > Fila.Item("Fisico", DataRowVersion.Original) Then
    '                                ValorX = (DT.Rows(i)("Fisico") - Fila.Item("Fisico", DataRowVersion.Original)) * Factor '* IIf(cmbrequisa.Text.ToString.Substring(0, 1) = "S", Factor, 1)
    '                            Else
    '                                ValorX = (Fila.Item("Fisico", DataRowVersion.Original) - DT.Rows(i)("Fisico")) * Factor * -1
    '                            End If
    '                        Else
    '                            ValorX = DT.Rows(i)("Fisico") * Factor
    '                        End If
    '                    Else
    '                        ValorX = DT.Rows(i)("Fisico") * Factor
    '                    End If
    '                Catch ex As Exception
    '                    ValorX = DT.Rows(i)("Fisico") * Factor
    '                End Try

    '                Conn.AddParameter("Existencia", SqlDbType.Money, 20, ParameterDirection.Input, ValorX)
    '                Conn.AddParameter("Costo", SqlDbType.Money, 20, ParameterDirection.Input, DT.Rows.Item(i)("Costo"))
    '                Conn.AddParameter("Articulo_Tipo", SqlDbType.NVarChar, 20, ParameterDirection.Input, Tipo.EditValue)
    '                Conn.EjecutarComando("SP_Bodega_Articulos_Add")
    '                'VB.SysContab.BodegasDB.Bodega_Articulos_Add(cmbbodega.EditValue, DT.Rows(i)("Codigo"), DT.Rows(i)("Fisico") * Factor, 0.0, TipoServicio.EditValue)

    '                'Agregar el detalle de la requisa
    '                Conn.RemoveParameters()
    '                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
    '                Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
    '                Conn.AddParameter("Articulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, DT.Rows(i)("Codigo"))
    '                Conn.AddParameter("TArticulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, Tipo.EditValue)
    '                ' Conn.AddParameter("Fisico", SqlDbType.Money, 10, ParameterDirection.Input, DT.Rows(i)("Fisico") * Factor)
    '                Conn.AddParameter("Precio", SqlDbType.Money, 10, ParameterDirection.Input, DT.Rows.Item(i)("Costo"))
    '                Conn.AddParameter("Cantidad", SqlDbType.Int, 5, ParameterDirection.Input, DT.Rows.Item(i)("Diferencia"))

    '                Conn.EjecutarComando("SP_Requisas_Detalle_Add")

    '                'VB.SysContab.RequisasDB.Detalle_AddItem(Requisa, DT.Rows(i)("Codigo"), TipoServicio.EditValue, DT.Rows(i)("Fisico") * Factor, 0)
    '                'Agregar el detalle de transaccion de bodega
    '                Conn.RemoveParameters()
    '                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
    '                Conn.AddParameter("Bodega", SqlDbType.NVarChar, 10, ParameterDirection.Input, Bodega.EditValue)
    '                Conn.AddParameter("Articulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, DT.Rows(i)("Codigo"))
    '                Conn.AddParameter("Tipo", SqlDbType.NVarChar, 20, ParameterDirection.Input, "R")
    '                Conn.AddParameter("Documento", SqlDbType.NVarChar, 20, ParameterDirection.Input, Requisa)
    '                Conn.AddParameter("Proveedor", SqlDbType.Int, 10, ParameterDirection.Input, 0)
    '                Conn.AddParameter("Movimiento", SqlDbType.NVarChar, 10, ParameterDirection.Input, Requisa)
    '                Conn.AddParameter("Existencia", SqlDbType.Money, 20, ParameterDirection.Input, DT.Rows(i)("Fisico") * Factor)
    '                Conn.AddParameter("Costo", SqlDbType.Money, 20, ParameterDirection.Input, DT.Rows.Item(i)("Costo"))
    '                Conn.AddParameter("Articulo_Tipo", SqlDbType.NVarChar, 20, ParameterDirection.Input, Tipo.EditValue)
    '                Conn.EjecutarComando("SP_Transaccion_Bodega_Detalle_Add")

    '                'VB.SysContab.BodegasDB.TransaccionBodegaDetalle_Add(cmbbodega.EditValue, _
    '                '     DT.Rows(i)("Codigo"), "R", Requisa, cmbrequisa.Text.ToString.Substring(0, 1), _
    '                'DT.Rows(i)("Fisico") * Factor, 0, "0", TipoServicio.EditValue)
    '                'sumar las existencias

    '                Conn.RemoveParameters()
    '                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
    '                Conn.AddParameter("Cantidad", SqlDbType.Money, 10, ParameterDirection.Input, DT.Rows.Item(i)("Diferencia"))
    '                Conn.AddParameter("Item", SqlDbType.NVarChar, 20, ParameterDirection.Input, DT.Rows(i)("Codigo"))
    '                Conn.AddParameter("Tipo", SqlDbType.NVarChar, 20, ParameterDirection.Input, Tipo.EditValue)
    '                Conn.EjecutarComando("SP_ItemsSumarExistencia")

    '                'Articulos.SumarExistencias(DT.Rows(i)("Codigo"), DT.Rows(i)("Fisico") * Factor, TipoServicio.EditValue)

    '                Conn.RemoveParameters()
    '                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
    '                Conn.AddParameter("Item", SqlDbType.NVarChar, 50, ParameterDirection.Input, DT.Rows(i)("Codigo"))
    '                Conn.AddParameter("Tipo", SqlDbType.NVarChar, 20, ParameterDirection.Input, Tipo.EditValue)
    '                Conn.AddParameter("Costo", SqlDbType.Money, 10, ParameterDirection.Input, DT.Rows(i)("Costo"))
    '                Conn.AddParameter("Cantidad", SqlDbType.Money, 10, ParameterDirection.Input, DT.Rows(i)("Diferencia"))
    '                Conn.AddParameter("Precio", SqlDbType.Money, 10, ParameterDirection.Input, 0)
    '                'Conn.AddParameter("Fisico", SqlDbType.Money, 10, ParameterDirection.Input, ValorX)
    '                Conn.EjecutarComando("[_ItemsUpdateCosto]")
    '            Next
    '        End If
    '        Conn.CompletarTransaccion()
    '        Data.AcceptChanges()
    '        IdRequisa = Requisa
    '    Catch ex As Exception
    '        MsgBox(ex.Message & "Guardar")
    '        Conn.AnularTransaccion()
    '    End Try



    'End Sub




    Private Sub Fecha_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fecha.EditValueChanged
        CargaInventario()
    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iGrid.Click

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Bodega.EditValue Is Nothing Then
            XtraMsg("Seleccione Bodega!")
            Bodega.Focus()
            Exit Sub
        End If
        '

        With frmImportarComprobante
            .Tipo = "FISICO"
            .ShowDialog()

            If Not .dt Is Nothing Then

                Dim DT_IMPORT As DataTable = .dt

                Data.Rows.Clear()

                pBar.EditValue = 0
                pBar.Properties.Minimum = 0
                pBar.Properties.Maximum = DT_IMPORT.Rows.Count

                For i As Integer = 0 To DT_IMPORT.Rows.Count - 1
                    Dim dr As DataRow = Data.NewRow

                    Dim DT_PROD As DataTable = ObtieneDatos("JAR_GetDetalleProductoxBodega", DT_IMPORT.Rows.Item(i)("CODIGO"), _
                                                            Bodega.EditValue, Fecha.DateTime.Date, _
                                                            EmpresaActual)

                    If DT_PROD.Rows.Count > 0 Then  'Si Encuentra el Producto
                        dr.Item("Codigo") = DT_IMPORT.Rows.Item(i)("CODIGO")
                        dr.Item("Item_Nombre") = DT_IMPORT.Rows.Item(i)("DESCRIPCION")
                        dr.Item("Clase") = DT_PROD.Rows.Item(0)("Clase")
                        dr.Item("Proveedor") = DT_PROD.Rows.Item(0)("Proveedor")
                        dr.Item("Existencia") = DT_PROD.Rows.Item(0)("Existencia")
                        dr.Item("Fisico") = IsNull(DT_IMPORT.Rows.Item(i)("FISICO"), 0.0)
                        dr.Item("Diferencia") = dr.Item("Fisico") - dr.Item("Existencia")
                        dr.Item("Costo") = IIf(DT_PROD.Rows.Item(0)("Costo") = 0.0, DT_IMPORT.Rows.Item(i)("COSTO"), DT_PROD.Rows.Item(0)("Costo"))
                        dr.Item("Total_Costo") = IIf(DT_PROD.Rows.Item(0)("Costo") = 0.0, DT_IMPORT.Rows.Item(i)("COSTO"), DT_PROD.Rows.Item(0)("Costo")) * dr.Item("Diferencia")
                        dr.Item("Unidad") = IIf(DT_IMPORT.Rows.Item(i)("UNIDAD") = "", DT_PROD.Rows.Item(0)("UNIDAD"), DT_IMPORT.Rows.Item(i)("UNIDAD"))
                        dr.Item("Modelo") = IIf(DT_IMPORT.Rows.Item(i)("MODELO") = "", DT_PROD.Rows.Item(0)("MODELO"), DT_IMPORT.Rows.Item(i)("MODELO"))
                        dr.Item("Ubicacion") = IIf(DT_IMPORT.Rows.Item(i)("UBICACION") = "", DT_PROD.Rows.Item(0)("UBICACION"), DT_IMPORT.Rows.Item(i)("UBICACION"))
                        dr.Item("Encontrado") = True
                    Else    'Si no lo Encuentra
                        dr.Item("Codigo") = DT_IMPORT.Rows.Item(i)("CODIGO")
                        dr.Item("Item_Nombre") = DT_IMPORT.Rows.Item(i)("DESCRIPCION")
                        dr.Item("Clase") = ""
                        dr.Item("Proveedor") = ""
                        dr.Item("Existencia") = 0.0
                        dr.Item("Fisico") = IsNull(DT_IMPORT.Rows.Item(i)("FISICO"), 0.0)
                        dr.Item("Diferencia") = IsNull(DT_IMPORT.Rows.Item(i)("FISICO"), 0.0) * -1
                        dr.Item("Costo") = DT_IMPORT.Rows.Item(i)("COSTO")
                        dr.Item("Total_Costo") = DT_IMPORT.Rows.Item(i)("COSTO") * dr.Item("Diferencia")
                        dr.Item("Unidad") = DT_IMPORT.Rows.Item(i)("UNIDAD")
                        dr.Item("Modelo") = DT_IMPORT.Rows.Item(i)("MODELO")
                        dr.Item("Ubicacion") = DT_IMPORT.Rows.Item(i)("UBICACION")
                        dr.Item("Encontrado") = False

                        '/*************************************************************************
                        '***    Registrando Nuevos Items
                        '/*************************************************************************
                        Dim Prod As New VB.SysContab.ArticulosDB

                        Prod.AddItem(DT_IMPORT.Rows.Item(i)("CODIGO"), DT_IMPORT.Rows.Item(i)("DESCRIPCION"), 0, _
                                     0, 0, 0, 0, "", "", "", "", _
                                      0, 0, DT_IMPORT.Rows.Item(i)("COSTO"), _
                                      0, DT_IMPORT.Rows.Item(i)("COSTO"), _
                                      DT_IMPORT.Rows.Item(i)("COSTO"), 0, 0, 0, 0, 0, 0, 0, 0, "P", 0, _
                                      "", "", "", "", "", MonedaBase, "", 0)

                        Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())

                        Try
                            Conn.RemoveParameters()
                            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                            Conn.AddParameter("Bodega", SqlDbType.NVarChar, 10, ParameterDirection.Input, Bodega.EditValue)
                            Conn.AddParameter("Articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, DT_IMPORT.Rows.Item(i)("CODIGO"))
                            Conn.AddParameter("Existencia", SqlDbType.Money, 20, ParameterDirection.Input, 0.0)
                            Conn.AddParameter("Costo", SqlDbType.Decimal, 20, ParameterDirection.Input, DT_IMPORT.Rows.Item(i)("COSTO"))
                            Conn.AddParameter("Articulo_Tipo", SqlDbType.NVarChar, 20, ParameterDirection.Input, "P")
                            Conn.EjecutarComando("SP_Bodega_Articulos_Add")
                        Catch ex As Exception
                        End Try
                        '/*************************************************************************
                        '***    Fin Registrando Nuevos Items
                        '/*************************************************************************
                    End If
                    

                    Data.Rows.Add(dr)

                    pBar.Increment(1)
                    pBar.Refresh()
                Next

            End If
            .Dispose()
        End With

        ListaArticulos()
        Data.AcceptChanges()
        iGrid.DataSource = Data
        iVista.Columns("Encontrado").Visible = True
    End Sub
End Class