Imports System.Linq
Imports DevExpress.XtraGrid.Views.Grid
Imports ClasesBLL
Public Class frmProyectosLiquidar

    Public IdProyecto As Integer = 0
    Dim DT_COSTOS As DataTable
    Dim DT_REQ As DataTable
    Dim obj As New Proyectos
    Dim dbProyecto As New db_Proyectos

    Private Sub frmProyectosLiquidar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetTipoMovimientos(cbMovimiento, 1)
        cbMovimiento.ItemIndex = 0
        GetTipoMovimientos(cbMovimientoS, 1)
        cbMovimientoS.ItemIndex = 0

        RepositoryItemLookUpEdit(cbBodega1, ObtieneDatos("JAR_GetBodegasList", EmpresaActual), "UBICACION", "CODIGO", 2, 3, 4, 5, 6, 7, 8, 9, 10, 11)
        RepositoryItemLookUpEdit(cbBodega2, ObtieneDatos("JAR_GetBodegasList", EmpresaActual), "UBICACION", "CODIGO", 2, 3, 4, 5, 6, 7, 8, 9, 10, 11)

        Cargar()
        '
        iVista2.PopulateColumns() : FormatoGrid(iVista2, 2, 0, False, True, False)
        iVistaCostos.PopulateColumns() : FormatoGrid(iVistaCostos, 2, 0, False, True, False)
        '
        For i As Integer = 0 To iVistaCostos.Columns.Count - 1
            iVistaCostos.Columns(i).OptionsColumn.AllowEdit = False
        Next

        For i As Integer = 0 To iVista2.Columns.Count - 1
            iVista2.Columns(i).OptionsColumn.AllowEdit = False
        Next
        '        
        iVistaCostos.Columns("IdProyecto").Visible = False
        iVistaCostos.Columns("Facturado").ColumnEdit = rMonto
        iVistaCostos.Columns("Bodega").ColumnEdit = cbBodega1
        iVistaCostos.Columns("Costo").ColumnEdit = rMonto
        '
        iVista2.Columns("IdDetalle").Visible = False
        iVista2.Columns("IdProyecto").Visible = False
        iVista2.Columns("Unitario").ColumnEdit = rMonto
        iVista2.Columns("Costo Total").ColumnEdit = rMonto
        iVista2.Columns("Bodega").ColumnEdit = cbBodega2
        iVista2.Columns("Descargar").OptionsColumn.AllowEdit = True
        iVista2.Columns("Descargar").ColumnEdit = rChkRemision

        obj = db_Proyectos.Detalles(IdProyecto)
    End Sub

    Sub Cargar()
        DT_COSTOS = ObtieneDatos("sp_ProyectoCosto_Liquidar",
                                         IdProyecto,
                                         1,
                                         EmpresaActual)

        iGridItemProyectos.DataSource = DT_COSTOS.DefaultView

        DT_REQ = ObtieneDatos("sp_ProyectoCosto_Liquidar",
                                         IdProyecto,
                                         2,
                                         EmpresaActual)
        iGrid2.DataSource = DT_REQ.DefaultView
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If iVista2.DataRowCount = 0 And iVistaCostos.DataRowCount = 0 Then
            XtraMsg("No Existen Costos por Liquidar", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If cbMovimiento.ItemIndex = 0 Then
            XtraMsg("Seleccione el Tipo de Movimiento de Entrada", MessageBoxIcon.Warning)
            cbMovimiento.Focus()
            Exit Sub
        End If
        '
        If cbMovimientoS.ItemIndex = 0 Then
            XtraMsg("Seleccione el Tipo de Movimiento de Salida", MessageBoxIcon.Warning)
            cbMovimiento.Focus()
            Exit Sub
        End If

        'Dim dr() As DataRow = DT_REQ.Select("Descargar = 1")
        'If dr.Length = 0 Then
        '    XtraMsg("Debe Seleccionar al Menos 1 Producto para procesar la descarga.", MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        '
        'If iVistaCostos.DataRowCount > 0 Then
        '    GuardarCostos()
        'Else
        '    GuardarRequisa()
        'End If
        '

        'Verificar Cierre del Día
        '*******************************************************************************************
        If Not VerificarCierre(Fecha.DateTime.Date) Then
            Exit Sub
        End If
        '*******************************************************************************************
        '*******************************************************************************************
        ' Validar Cierre de Inventario
        If Not VerificarCierre_Inventario(Fecha.DateTime.Date) Then
            Exit Sub
        End If
        '*******************************************************************************************

        If Not XtraMsg2("Esta Seguro de Liquidar los costos de este Proyecto?") Then
            Exit Sub
        End If
        '
        Dim result As Boolean = True

        If DT_COSTOS.Rows.Count > 0 Then result = GuardarCostos()

        If result Then
            If DT_REQ.Rows.Count > 0 Then
                If DT_REQ.Select("Descargar = 1").Length > 0 Then
                    GuardarRequisa()
                Else
                    XtraMsg("Liquidación de Costo del Proyecto aplicado con Exito!")
                    Close()
                End If
            Else
                XtraMsg("Liquidación de Costo del Proyecto aplicado con Exito!")
                Close()
            End If
            '
            If frmProyectos.Created Then frmProyectos.Cargar()
        End If
    End Sub

    Function GuardarCostos()

        'Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
        'Conn.IniciarTransaccion()
        'Dim req = From row In DT_COSTOS.AsEnumerable()
        '          Select row.Field(Of String)("Bodega") Distinct

        Dim rEntrada As Integer = 0, rSalida As Integer = 0
        '
        Try
            If DT_COSTOS.Rows(0)("Costo") = 0.00 Then
                db_Proyectos.ProyectoFinalizar(DT_COSTOS.Rows(0)("IdProyecto"))
                Return True
            End If

            'Generar Entrada con el costo del Proyecto.
            rEntrada = db_requisas.Add(EmpresaActual, "E", Fecha.DateTime.Date, DT_COSTOS.Rows(0)("Bodega"),
                                                    Login, "", cbMovimiento.EditValue, "LIQUIDAR PROYECTO " & obj.Codigo, txtConcepto.Text,
                                       "", "", "", "", "", "", obj.IdCliente)



            For i As Integer = 0 To DT_COSTOS.Rows.Count - 1
                db_requisas.AddDetalle(EmpresaActual, rEntrada, DT_COSTOS.Rows(i)("Codigo"), "P", 1.0,
                                       DT_COSTOS.Rows(i)("Costo"), cbMovimiento.GetColumnValue("Cuenta"), "", "", "")

                db_Proyectos.ProyectoFinalizar(DT_COSTOS.Rows(i)("IdProyecto"))
            Next
            '
            'Contabilizar la Requisa de Entrada, ya que su costo ya fue contabilizado desde las O/P.
            db_requisas.Requisa_Contabilizada(rEntrada, EmpresaActual)
            '
            'Generar Salida con el costo del Proyecto
            rSalida = db_requisas.Add(EmpresaActual, "S", Fecha.DateTime.Date, DT_COSTOS.Rows(0)("Bodega"),
                                                    Login, "", cbMovimientoS.EditValue, "LIQUIDAR PROYECTO " & obj.Codigo, txtConcepto.Text,
                                      "", "", "", "", "", "", obj.IdCliente)

            For i As Integer = 0 To DT_COSTOS.Rows.Count - 1
                db_requisas.AddDetalle(EmpresaActual, rSalida, DT_COSTOS.Rows(i)("Codigo"), "P", 1.0,
                                       DT_COSTOS.Rows(i)("Costo"), cbMovimientoS.GetColumnValue("Cuenta"), "", "", "")
            Next

            '
            'XtraMsg("Liquidación de Costo del Proyecto aplicado con Exito!")
            'Close()

            'If frmProyectos.Created Then frmProyectos.Cargar()

            Return True
        Catch ex As Exception
            XtraMsg(ex.Message & "Guardar Costo. ",
                    MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Sub GuardarRequisa()


        Dim _DT_REQ As DataTable = DT_REQ.Select("Descargar = 1").CopyToDataTable

        Dim req = From row In _DT_REQ.AsEnumerable()
                  Select row.Field(Of String)("Bodega") Distinct

        Try
            For Each s As Object In req
                If Not s Is Nothing Then
                    Dim DT_DETALLE As DataTable = _DT_REQ.Select("Bodega =" & s).CopyToDataTable

                    Dim Requisa As Integer = db_requisas.Add(EmpresaActual, "S", Fecha.DateTime.Date, s.ToString,
                                                    Login, "", cbMovimientoS.EditValue, "LIQUIDAR PROYECTO " & obj.Codigo, txtConcepto.Text, "",
                                                             "", "", "", "", "", obj.IdCliente, "", IdProyecto)

                    For i As Integer = 0 To DT_DETALLE.Rows.Count - 1
                        db_requisas.AddDetalle(EmpresaActual, Requisa, DT_DETALLE.Rows(i)("Codigo"), "P",
                                               DT_DETALLE.Rows(i)("Cantidad"), DT_DETALLE.Rows(i)("Unitario"),
                                               cbMovimientoS.GetColumnValue("Cuenta"), "", "", "")

                        db_requisas.Proyectos_Liquidar(DT_DETALLE.Rows(i)("IdDetalle"),
                                                       DT_DETALLE.Rows(i)("IdProyecto"),
                                                       Requisa, DT_DETALLE.Rows(i)("Cantidad"),
                                                       EmpresaActual)
                    Next

                End If
            Next
            '

            XtraMsg("Liquidación de Costo del Proyecto por Remisiones aplicado con Exito!")
            Close()

            If frmProyectos.Created Then frmProyectos.Cargar()
        Catch ex As Exception
            XtraMsg(ex.Message & "Guardar", MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        frmExportarImprimir.Mostrar(iGrid2, "Remisiones Liquidar")
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Close()
    End Sub
End Class