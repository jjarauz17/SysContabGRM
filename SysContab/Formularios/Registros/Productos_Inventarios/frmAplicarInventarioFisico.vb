Public Class frmAplicarInventarioFisico

    Public Bodega As String
    Public IdInventario As Integer = 0

    Private Sub frmAplicarInventarioFisico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)
        '
        'GetBodegasList(cbBodega)
        GetBodegasxUsuario(cbBodega, 0)
        GetTipoMovimientos(cbND, 1)
        GetTipoMovimientos(cbNC, 1)

        cbBodega.EditValue = Bodega
        txtNumero.Properties.PasswordChar = ""
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
    '        Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, iVista.GetFocusedRowCellValue("Fecha"))
    '        Conn.AddParameter("Bodega", SqlDbType.NVarChar, 15, ParameterDirection.Input, iVista.GetFocusedRowCellValue("codigo_bodega"))
    '        Conn.AddParameter("RealizadoPor", SqlDbType.NVarChar, 50, ParameterDirection.Input, iVista.GetFocusedRowCellValue("Realizado"))
    '        Conn.AddParameter("Registro", SqlDbType.Bit, 1, ParameterDirection.Input, Registro)
    '        Conn.AddParameter("Factura", SqlDbType.NVarChar, 15, ParameterDirection.Input, "")

    '        Conn.EjecutarComando("SP_Requisas_Add")

    '        If Requisa <> -1 Then
    '            Conn.RemoveParameters()
    '            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
    '            Conn.AddParameter("Documento", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
    '            Conn.AddParameter("Tipo", SqlDbType.NVarChar, 5, ParameterDirection.Input, "R")
    '            Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, iVista.GetFocusedRowCellValue("Fecha"))
    '            Conn.AddParameter("Bodega", SqlDbType.NVarChar, 15, ParameterDirection.Input, iVista.GetFocusedRowCellValue("codigo_bodega"))
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


    '        Dim Variables As New ArrayList
    '        Dim Datos As New ArrayList
    '        Variables.Add("Bodega")
    '        Variables.Add("Tipo")
    '        Variables.Add("IdInventario")
    '        Variables.Add("Fecha")
    '        Datos.Add(iVista.GetFocusedRowCellValue("codigo_bodega"))
    '        Datos.Add(iVista.GetFocusedRowCellValue("Tipo"))
    '        Datos.Add(iVista.GetFocusedRowCellValue("IdInventario"))
    '        Datos.Add(Today)


    '        DT = ProcedureParameters(Datos, Variables, "RCT_SPGetInventarioFisico")


    '        If Not DT Is Nothing Then
    '            For i As Integer = 0 To DT.Rows.Count - 1
    '                'Agregar las existencias a la bodega

    '                Conn.RemoveParameters()
    '                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
    '                Conn.AddParameter("Item", SqlDbType.NVarChar, 50, ParameterDirection.Input, DT.Rows(i)("Codigo"))
    '                Conn.AddParameter("Tipo", SqlDbType.NVarChar, 20, ParameterDirection.Input, iVista.GetFocusedRowCellValue("Tipo"))
    '                Conn.AddParameter("Costo", SqlDbType.Money, 10, ParameterDirection.Input, DT.Rows(i)("Costo"))
    '                Conn.AddParameter("Cantidad", SqlDbType.Money, 10, ParameterDirection.Input, DT.Rows(i)("Diferencia"))
    '                'Conn.AddParameter("Precio", SqlDbType.Money, 10, ParameterDirection.Input, 0)
    '                'Conn.AddParameter("Fisico", SqlDbType.Money, 10, ParameterDirection.Input, ValorX)
    '                Conn.EjecutarComando("_ItemsUpdateCosto")


    '                Conn.RemoveParameters()
    '                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
    '                Conn.AddParameter("Bodega", SqlDbType.NVarChar, 10, ParameterDirection.Input, iVista.GetFocusedRowCellValue("codigo_bodega"))
    '                Conn.AddParameter("Articulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, DT.Rows(i)("Codigo"))

    '                Conn.AddParameter("Existencia", SqlDbType.Money, 20, ParameterDirection.Input, DT.Rows.Item(i)("Diferencia"))
    '                Conn.AddParameter("Costo", SqlDbType.Money, 20, ParameterDirection.Input, DT.Rows.Item(i)("Costo"))
    '                Conn.AddParameter("Articulo_Tipo", SqlDbType.NVarChar, 20, ParameterDirection.Input, iVista.GetFocusedRowCellValue("Tipo"))
    '                Conn.EjecutarComando("SP_Bodega_Articulos_Add")
    '                'VB.SysContab.BodegasDB.Bodega_Articulos_Add(cmbbodega.EditValue, DT.Rows(i)("Codigo"), DT.Rows(i)("Fisico") * Factor, 0.0, TipoServicio.EditValue)

    '                'Agregar el detalle de la requisa
    '                Conn.RemoveParameters()
    '                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
    '                Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
    '                Conn.AddParameter("Articulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, DT.Rows(i)("Codigo"))
    '                Conn.AddParameter("TArticulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, iVista.GetFocusedRowCellValue("Tipo"))
    '                ' Conn.AddParameter("Fisico", SqlDbType.Money, 10, ParameterDirection.Input, DT.Rows(i)("Fisico") * Factor)
    '                Conn.AddParameter("Precio", SqlDbType.Money, 10, ParameterDirection.Input, DT.Rows.Item(i)("Costo"))
    '                Conn.AddParameter("Cantidad", SqlDbType.Int, 5, ParameterDirection.Input, DT.Rows.Item(i)("Diferencia"))

    '                Conn.EjecutarComando("SP_Requisas_Detalle_Add")

    '                'VB.SysContab.RequisasDB.Detalle_AddItem(Requisa, DT.Rows(i)("Codigo"), TipoServicio.EditValue, DT.Rows(i)("Fisico") * Factor, 0)
    '                'Agregar el detalle de transaccion de bodega
    '                Conn.RemoveParameters()
    '                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
    '                Conn.AddParameter("Bodega", SqlDbType.NVarChar, 10, ParameterDirection.Input, iVista.GetFocusedRowCellValue("codigo_bodega"))
    '                Conn.AddParameter("Articulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, DT.Rows(i)("Codigo"))
    '                Conn.AddParameter("Tipo", SqlDbType.NVarChar, 20, ParameterDirection.Input, "R")
    '                Conn.AddParameter("Documento", SqlDbType.NVarChar, 20, ParameterDirection.Input, Requisa)
    '                Conn.AddParameter("Proveedor", SqlDbType.Int, 10, ParameterDirection.Input, 0)
    '                Conn.AddParameter("Movimiento", SqlDbType.NVarChar, 10, ParameterDirection.Input, Requisa)
    '                Conn.AddParameter("Existencia", SqlDbType.Money, 20, ParameterDirection.Input, DT.Rows(i)("Diferencia") * Factor)
    '                Conn.AddParameter("Costo", SqlDbType.Money, 20, ParameterDirection.Input, DT.Rows.Item(i)("Costo"))
    '                Conn.AddParameter("Articulo_Tipo", SqlDbType.NVarChar, 20, ParameterDirection.Input, iVista.GetFocusedRowCellValue("Tipo"))
    '                Conn.EjecutarComando("SP_Transaccion_Bodega_Detalle_Add")

    '                'VB.SysContab.BodegasDB.TransaccionBodegaDetalle_Add(cmbbodega.EditValue, _
    '                '     DT.Rows(i)("Codigo"), "R", Requisa, cmbrequisa.Text.ToString.Substring(0, 1), _
    '                'DT.Rows(i)("Fisico") * Factor, 0, "0", TipoServicio.EditValue)
    '                'sumar las existencias

    '                Conn.RemoveParameters()
    '                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
    '                Conn.AddParameter("Cantidad", SqlDbType.Money, 10, ParameterDirection.Input, DT.Rows.Item(i)("Diferencia"))
    '                Conn.AddParameter("Item", SqlDbType.NVarChar, 20, ParameterDirection.Input, DT.Rows(i)("Codigo"))
    '                Conn.AddParameter("Tipo", SqlDbType.NVarChar, 20, ParameterDirection.Input, iVista.GetFocusedRowCellValue("Tipo"))
    '                Conn.EjecutarComando("SP_ItemsSumarExistencia")

    '                'Articulos.SumarExistencias(DT.Rows(i)("Codigo"), DT.Rows(i)("Fisico") * Factor, TipoServicio.EditValue)


    '            Next
    '        End If

    '        Conn.RemoveParameters()

    '        Conn.AddParameter("IdInventario", SqlDbType.Int, 5, ParameterDirection.Input, iVista.GetFocusedRowCellValue("IdInventario"))
    '        Conn.EjecutarComando("sp_autorizar_Inventario_fisco")

    '        Conn.CompletarTransaccion()

    '        Contabilizar()





    '        'IdRequisa = Requisa
    '    Catch ex As Exception
    '        XtraMsg(ex.Message & "Guardar", MessageBoxIcon.Error)
    '        Conn.AnularTransaccion()
    '    End Try


    'End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Not DxValidationProvider1.Validate Then Exit Sub

        Dim Requisa As Integer = 0
        ' Requisa = VB.SysContab.RequisasDB.GetCodigoNuevo()

        Dim DT_Debito As DataTable = ObtieneDatos("JAR_GetInventarioFisicoAjsute", IdInventario, "E")
        Dim DT_Credito As DataTable = ObtieneDatos("JAR_GetInventarioFisicoAjsute", IdInventario, "S")

        Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
        Conn.IniciarTransaccion()

        Try
            Conn.RemoveParameters()
            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Conn.AddParameter("Codigo", SqlDbType.Int, 5, ParameterDirection.Output, 0)
            Conn.EjecutarComando("_GetList_RequisaCodigoNuevo")

            Requisa = Conn.GetParameter("Codigo").Valor

            '/***********************************************************
            'Guardando Nota de Debito
            '/***********************************************************
            If DT_Debito.Rows.Count > 0 Then
                ShowSplash("Guardando Ajustes...")

                Conn.RemoveParameters()
                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
                Conn.AddParameter("TRequisa", SqlDbType.NVarChar, 5, ParameterDirection.Input, "E")
                Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, Fecha.DateTime.Date)
                Conn.AddParameter("Bodega", SqlDbType.NVarChar, 15, ParameterDirection.Input, cbBodega.EditValue)
                Conn.AddParameter("RealizadoPor", SqlDbType.NVarChar, 50, ParameterDirection.Input, Usuario)
                Conn.AddParameter("Registro", SqlDbType.Bit, 1, ParameterDirection.Input, 0)
                Conn.AddParameter("Factura", SqlDbType.NVarChar, 15, ParameterDirection.Input, "")
                Conn.AddParameter("Movimiento", SqlDbType.Int, 4, ParameterDirection.Input, Me.cbND.EditValue)
                Conn.AddParameter("Referencia", SqlDbType.NVarChar, 100, ParameterDirection.Input, txtNumero.Text)

                Conn.EjecutarComando("SP_Requisas_Add")

                For i As Integer = 0 To DT_Debito.Rows.Count - 1
                    Conn.RemoveParameters()
                    Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                    Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
                    Conn.AddParameter("Articulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, DT_Debito.Rows(i)("codigo_articulo"))
                    Conn.AddParameter("TArticulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, DT_Debito.Rows(i)("articulo_tipo"))
                    Conn.AddParameter("Cantidad", SqlDbType.Decimal, 20, ParameterDirection.Input, DT_Debito.Rows(i)("diferencias"))
                    Conn.AddParameter("Precio", SqlDbType.Decimal, 20, ParameterDirection.Input, DT_Debito.Rows(i)("Costo"))
                    Conn.AddParameter("Cuenta", SqlDbType.NVarChar, 50, ParameterDirection.Input, cbND.GetColumnValue("Cuenta"))
                    Conn.EjecutarComando("SP_Requisas_Detalle_Add")
                Next
            End If
            '
            '/***********************************************************
            'Guardando Nota de Credito
            '/***********************************************************
            If DT_Credito.Rows.Count > 0 Then

                '  Requisa = VB.SysContab.RequisasDB.GetCodigoNuevo()

                Conn.RemoveParameters()
                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                Conn.AddParameter("Codigo", SqlDbType.Int, 5, ParameterDirection.Output, 0)
                Conn.EjecutarComando("_GetList_RequisaCodigoNuevo")

                Requisa = Conn.GetParameter("Codigo").Valor

                Conn.RemoveParameters()
                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
                Conn.AddParameter("TRequisa", SqlDbType.NVarChar, 5, ParameterDirection.Input, "S")
                Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, Fecha.DateTime.Date)
                Conn.AddParameter("Bodega", SqlDbType.NVarChar, 15, ParameterDirection.Input, cbBodega.EditValue)
                Conn.AddParameter("RealizadoPor", SqlDbType.NVarChar, 50, ParameterDirection.Input, Usuario)
                Conn.AddParameter("Registro", SqlDbType.Bit, 1, ParameterDirection.Input, 0)
                Conn.AddParameter("Factura", SqlDbType.NVarChar, 15, ParameterDirection.Input, "")
                Conn.AddParameter("Movimiento", SqlDbType.Int, 4, ParameterDirection.Input, Me.cbNC.EditValue)
                Conn.AddParameter("Referencia", SqlDbType.NVarChar, 100, ParameterDirection.Input, txtNumero.Text)

                Conn.EjecutarComando("SP_Requisas_Add")

                For i As Integer = 0 To DT_Credito.Rows.Count - 1
                    Conn.RemoveParameters()
                    Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                    Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
                    Conn.AddParameter("Articulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, DT_Credito.Rows(i)("codigo_articulo"))
                    Conn.AddParameter("TArticulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, DT_Credito.Rows(i)("articulo_tipo"))
                    Conn.AddParameter("Cantidad", SqlDbType.Decimal, 20, ParameterDirection.Input, DT_Credito.Rows(i)("diferencias") * -1)
                    Conn.AddParameter("Precio", SqlDbType.Decimal, 20, ParameterDirection.Input, DT_Credito.Rows(i)("Costo"))
                    Conn.AddParameter("Cuenta", SqlDbType.NVarChar, 50, ParameterDirection.Input, cbNC.GetColumnValue("Cuenta"))
                    Conn.EjecutarComando("SP_Requisas_Detalle_Add")
                Next
            End If

            Conn.RemoveParameters()
            Conn.AddParameter("IdInventario", SqlDbType.Int, 5, ParameterDirection.Input, IdInventario)
            Conn.EjecutarComando("sp_autorizar_Inventario_fisco")

            Conn.CompletarTransaccion()

            HideSplash()
            XtraMsg("Ajustes Guardados con Exito!")
            FrmInventarioList.Cargar()

            Close()
        Catch ex As Exception
            HideSplash()
            XtraMsg(ex.Message & "Guardar", MessageBoxIcon.Error)
            Conn.AnularTransaccion()
        End Try

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub
End Class