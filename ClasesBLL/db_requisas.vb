
Imports DbConnect
Imports System.Windows.Forms


Public Class db_requisas

    Public Property req_codigo As Integer = 0
    Public Property req_codigo_referencia As Integer = 0
    Public Property Tipo As String = ""
    Public Property Fecha As Date
    Public Property Bodega As String = ""
    Public Property Referencia As String = ""
    Public Property Factura As String = ""
    Public Property Clase As String = ""
    Public Property Proveedor As Integer = 0
    Public Property Comp_No As Integer = 0
    Public Property Per_Id As Integer = 0
    Public Property Mes As Integer = 0
    Public Property ALiquidar As Boolean
    Public Property Procesado As Boolean
    Public Property Contabilizado As Boolean
    Public Property EsProyecto As Boolean


    Public Shared Function Add(Empresa As Integer, Tipo As String, Fecha As DateTime, Bodega As String, Usuario As String,
                               Factura As String, Movimiento As Integer, Referencia As String, Concepto As String,
                               Optional Transporte As String = "", Optional Placa As String = "",
                               Optional Conductor As String = "", Optional Remision As String = "",
                               Optional OTMatriz As String = "", Optional OTSucursal As String = "", Optional Cliente As Integer = 0,
                               Optional Poliza As String = "", Optional Proyecto As Integer = 0,
                               Optional Orden As Integer = 0, Optional Proveedor As Integer = 0,
                               Optional NoDevolucion As Integer = 0, Optional Reg_referencia As Integer = 0,
                               Optional ALiquidar As Integer = 0, Optional RecibimosDe As String = "") As Integer

        Dim Conn As New Connect(fn.Conexion())
        '
        Try
            Conn.IniciarTransaccion()
            '
            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, Empresa)
            Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Output, 0)
            Conn.AddParameter("TRequisa", SqlDbType.NVarChar, 5, ParameterDirection.Input, Tipo)
            Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, Fecha.Date)
            Conn.AddParameter("Bodega", SqlDbType.NVarChar, 15, ParameterDirection.Input, Bodega)
            Conn.AddParameter("RealizadoPor", SqlDbType.NVarChar, 50, ParameterDirection.Input, Usuario)
            Conn.AddParameter("Registro", SqlDbType.Bit, 1, ParameterDirection.Input, False)
            Conn.AddParameter("Factura", SqlDbType.NVarChar, 100, ParameterDirection.Input, Factura)
            Conn.AddParameter("Movimiento", SqlDbType.Int, 4, ParameterDirection.Input, Movimiento)
            Conn.AddParameter("Referencia", SqlDbType.NVarChar, 100, ParameterDirection.Input, Referencia)
            Conn.AddParameter("Concepto", SqlDbType.NVarChar, 2048, ParameterDirection.Input, Concepto)
            Conn.AddParameter("Transporte", SqlDbType.NVarChar, 512, ParameterDirection.Input, Transporte)
            Conn.AddParameter("NoPlaca", SqlDbType.NVarChar, 100, ParameterDirection.Input, Placa)
            Conn.AddParameter("Conductor", SqlDbType.NVarChar, 512, ParameterDirection.Input, Conductor)
            Conn.AddParameter("Remision", SqlDbType.NVarChar, 50, ParameterDirection.Input, Remision)
            Conn.AddParameter("OT_Matriz", SqlDbType.NVarChar, 50, ParameterDirection.Input, OTMatriz)
            Conn.AddParameter("OT_Suc", SqlDbType.NVarChar, 50, ParameterDirection.Input, OTSucursal)
            Conn.AddParameter("IdCliente", SqlDbType.Int, 5, ParameterDirection.Input, Cliente)
            Conn.AddParameter("NoPoliza", SqlDbType.NVarChar, 50, ParameterDirection.Input, Poliza)
            Conn.AddParameter("IdProyecto", SqlDbType.Int, 5, ParameterDirection.Input, Proyecto)
            Conn.AddParameter("IdOrden", SqlDbType.Int, 5, ParameterDirection.Input, Orden)
            Conn.AddParameter("IdProveedor", SqlDbType.Int, 5, ParameterDirection.Input, Proveedor)
            Conn.AddParameter("NoDevolucion", SqlDbType.Int, 5, ParameterDirection.Input, NoDevolucion)
            Conn.AddParameter("IdRequisa_Referencia", SqlDbType.Int, 5, ParameterDirection.Input, Reg_referencia)
            Conn.AddParameter("ALiquidar", SqlDbType.Int, 5, ParameterDirection.Input, ALiquidar)
            Conn.AddParameter("RecibimosDe", SqlDbType.NVarChar, 256, ParameterDirection.Input, RecibimosDe)

            Conn.EjecutarComando("SP_Requisas_Add")
            Conn.CompletarTransaccion()

            Return Conn.GetParameter("Requisa").Valor
        Catch ex As Exception
            Conn.AnularTransaccion()
            fn.XtraMsg(ex.Message, MessageBoxIcon.Error)
            Return 0
        End Try

    End Function

    Public Shared Function Update(Empresa As Integer, Requisa As Integer, Tipo As String, Fecha As DateTime, Bodega As String,
                             Usuario As String, Factura As String, Movimiento As Integer, Referencia As String, Concepto As String,
                             Transporte As String, Placa As String, Conductor As String, Remision As String, OTMatriz As String,
                             OTSucursal As String, Cliente As Integer, Poliza As String, Proyecto As Integer, Orden As Integer,
                             RecibimosDe As String, IdProveedor As Integer) As Boolean

        Dim Conn As New Connect(fn.Conexion())
        '
        Try
            Conn.IniciarTransaccion()
            '
            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, Empresa)
            Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
            Conn.AddParameter("TRequisa", SqlDbType.NVarChar, 5, ParameterDirection.Input, Tipo)
            Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, Fecha.Date)
            Conn.AddParameter("Bodega", SqlDbType.NVarChar, 15, ParameterDirection.Input, Bodega)
            Conn.AddParameter("RealizadoPor", SqlDbType.NVarChar, 50, ParameterDirection.Input, Usuario)
            Conn.AddParameter("Registro", SqlDbType.Bit, 1, ParameterDirection.Input, False)
            Conn.AddParameter("Factura", SqlDbType.NVarChar, 100, ParameterDirection.Input, Factura)
            Conn.AddParameter("Movimiento", SqlDbType.Int, 4, ParameterDirection.Input, Movimiento)
            Conn.AddParameter("Referencia", SqlDbType.NVarChar, 100, ParameterDirection.Input, Referencia)
            Conn.AddParameter("Concepto", SqlDbType.NVarChar, 2048, ParameterDirection.Input, Concepto)
            Conn.AddParameter("Transporte", SqlDbType.NVarChar, 512, ParameterDirection.Input, Transporte)
            Conn.AddParameter("NoPlaca", SqlDbType.NVarChar, 100, ParameterDirection.Input, Placa)
            Conn.AddParameter("Conductor", SqlDbType.NVarChar, 512, ParameterDirection.Input, Conductor)
            Conn.AddParameter("Remision", SqlDbType.NVarChar, 50, ParameterDirection.Input, Remision)
            Conn.AddParameter("OT_Matriz", SqlDbType.NVarChar, 50, ParameterDirection.Input, OTMatriz)
            Conn.AddParameter("OT_Suc", SqlDbType.NVarChar, 50, ParameterDirection.Input, OTSucursal)
            Conn.AddParameter("IdCliente", SqlDbType.Int, 5, ParameterDirection.Input, Cliente)
            Conn.AddParameter("NoPoliza", SqlDbType.NVarChar, 50, ParameterDirection.Input, Poliza)
            Conn.AddParameter("IdProyecto", SqlDbType.Int, 5, ParameterDirection.Input, Proyecto)
            Conn.AddParameter("IdProveedor", SqlDbType.Int, 5, ParameterDirection.Input, IdProveedor)
            Conn.AddParameter("IdOrden", SqlDbType.Int, 5, ParameterDirection.Input, Orden)
            Conn.AddParameter("RecibimosDe", SqlDbType.NVarChar, 256, ParameterDirection.Input, RecibimosDe)

            Conn.EjecutarComando("SP_Requisas_Add")

            Conn.CompletarTransaccion()

            Return True
        Catch ex As Exception
            Conn.AnularTransaccion()
            fn.XtraMsg(ex.Message, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Shared Sub AddDetalle(Empresa As Integer, Requisa As Integer, Codigo As String, Tipo As String, Cantidad As Double,
                                 Costo As Double, Cuenta As String, Optional Ubicacion As String = "",
                                 Optional Presentacion As String = "", Optional Agrupar As String = "",
                                 Optional Precio As Double = 0, Optional TCambio As Double = 1,
                                 Optional IdCentro As Integer = 0)
        Try
            Dim Conn As New Connect(fn.Conexion())
            '
            Conn.RemoveParameters()
            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, Empresa)
            Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
            Conn.AddParameter("Articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, Codigo)
            Conn.AddParameter("TArticulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, Tipo)
            Conn.AddParameter("Cantidad", SqlDbType.Decimal, 20, ParameterDirection.Input, Cantidad)
            Conn.AddParameter("Precio", SqlDbType.Decimal, 20, ParameterDirection.Input, Costo)
            Conn.AddParameter("Cuenta", SqlDbType.NVarChar, 50, ParameterDirection.Input, Cuenta)
            Conn.AddParameter("Ubicacion", SqlDbType.NVarChar, 100, ParameterDirection.Input, Ubicacion)
            Conn.AddParameter("Presentacion", SqlDbType.NVarChar, 100, ParameterDirection.Input, Presentacion)
            Conn.AddParameter("Agrupar", SqlDbType.NVarChar, 512, ParameterDirection.Input, Agrupar)
            Conn.AddParameter("Precio_Venta", SqlDbType.Decimal, 20, ParameterDirection.Input, Precio)
            Conn.AddParameter("TCambio", SqlDbType.Decimal, 20, ParameterDirection.Input, TCambio)
            Conn.AddParameter("IdCentro", SqlDbType.Int, 5, ParameterDirection.Input, IdCentro)
            '
            Conn.EjecutarComando("SP_Requisas_Detalle_Add")
        Catch ex As Exception
            fn.XtraMsg("Error al [Agregar/Actualizar] Codigo : " & Codigo & vbCrLf &
                       "Motivo del Error: " & ex.Message,
                       MessageBoxIcon.Error)
        End Try

    End Sub

    Public Shared Function Convertir_Combos(Requisa As Integer, Codigo As String) As Boolean

        Return Guardar("sp_Requisas_ConversionCombos", Requisa, Codigo, EmpresaA)

    End Function

    Public Shared Function Verificar_Combos(Codigo As String) As DataTable

        Return ObtieneDatos("sp_Combos_Verificar", Codigo, EmpresaA)

    End Function


    Public Shared Function Listar(Desde As Date, Hasta As Date) As DataTable

        Return ObtieneDatos("JAR_GetRequisasList", EmpresaA, Desde, Hasta)

    End Function

    Public Shared Function DetalleImprimirTicket(Codigo As Integer) As DataTable

        Return ObtieneDatos("sp_sel_Requisas_Detalle",
                            Codigo,
                            EmpresaA)

    End Function

    Public Shared Function Proyectos_Procesar(IdProyecto As Integer, IdRequisa As Integer, Empresa As Integer) As Boolean
        Try
            Dim Conn As New Connect(fn.Conexion())
            '
            Conn.RemoveParameters()
            Conn.AddParameter("IdProyecto", SqlDbType.Int, 5, ParameterDirection.Input, IdProyecto)
            Conn.AddParameter("IdRequisa", SqlDbType.Int, 5, ParameterDirection.Input, IdRequisa)
            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, Empresa)

            Conn.EjecutarComando("sp_upd_proyectos_procesar")

            Return True
        Catch ex As Exception
            fn.XtraMsg("Error al Marcar Proyecto,  Movimiento No. : " & IdRequisa.ToString() & vbCrLf &
                       "Motivo del Error: " & ex.Message, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Shared Sub Proyectos_Liquidar(IdDetalle As Integer, IdProyecto As Integer, IdRequisa As Integer, Cantidad As Double, Empresa As Integer)
        Try
            Dim Conn As New Connect(fn.Conexion())
            '
            Conn.RemoveParameters()
            Conn.AddParameter("IdDetalle", SqlDbType.Int, 5, ParameterDirection.Input, IdDetalle)
            Conn.AddParameter("IdProyecto", SqlDbType.Int, 5, ParameterDirection.Input, IdProyecto)
            Conn.AddParameter("IdRequisa", SqlDbType.Int, 5, ParameterDirection.Input, IdRequisa)
            Conn.AddParameter("Cantidad", SqlDbType.Float, 20, ParameterDirection.Input, Cantidad)
            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, Empresa)

            Conn.EjecutarComando("sp_upd_proyectos_requisas_liquidar")
        Catch ex As Exception
            fn.XtraMsg("Error al Marcar Proyecto,  Movimiento No. : " & IdRequisa.ToString() & vbCrLf &
                       "Motivo del Error: " & ex.Message, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Shared Function Requisa_Contabilizada(IdRequisa As Integer, Empresa As Integer) As Boolean
        Try
            Dim Conn As New Connect(fn.Conexion())
            '
            Conn.RemoveParameters()
            Conn.AddParameter("IdRequisa", SqlDbType.Int, 5, ParameterDirection.Input, IdRequisa)
            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, Empresa)

            Conn.EjecutarComando("sp_upd_requisas")

            Return True
        Catch ex As Exception
            fn.XtraMsg("Error al Marcar Movimiento No. : " & IdRequisa.ToString() & vbCrLf &
                       "Motivo del Error: " & ex.Message, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Shared Function Requisa_Contabilizada(IdRequisa As Integer, Comp_No As Integer, Per_Id As Integer, Mes As Integer, Contabilizar As Boolean, Empresa As Integer) As Boolean
        Try
            Dim Conn As New Connect(fn.Conexion())

            Conn.RemoveParameters()
            Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, Empresa)
            Conn.AddParameter("Requisa", SqlDbType.Int, 4, ParameterDirection.Input, IdRequisa)
            Conn.AddParameter("Contabilizar", SqlDbType.Bit, 4, ParameterDirection.Input, Contabilizar)
            Conn.AddParameter("Distribuir", SqlDbType.Bit, 4, ParameterDirection.Input, False)
            Conn.AddParameter("Comprobante", SqlDbType.Int, 4, ParameterDirection.Input, Comp_No)
            Conn.AddParameter("Periodo", SqlDbType.Int, 4, ParameterDirection.Input, Per_Id)
            Conn.AddParameter("Mes", SqlDbType.Int, 4, ParameterDirection.Input, Mes)

            Conn.EjecutarComando("_Requisa_Contabilizar")

            Return True
        Catch ex As Exception
            fn.XtraMsg("Error al Marcar Movimiento No. : " & IdRequisa.ToString() & vbCrLf &
                       "Motivo del Error: " & ex.Message, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Shared Function Buscar_Requisa(IdRequisa As Integer, Empresa As Integer) As Integer
        Try
            Dim Conn As New Connect(fn.Conexion())
            '
            Conn.RemoveParameters()
            Conn.AddParameter("IdRequisa", SqlDbType.Int, 5, ParameterDirection.Input, IdRequisa)
            Conn.AddParameter("Buscar", SqlDbType.Int, 5, ParameterDirection.Output, 0)
            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, Empresa)

            Conn.EjecutarComando("sp_requisa_buscar_proyecto")

            Return Conn.GetParameter("Buscar").Valor
        Catch ex As Exception
            fn.XtraMsg("Motivo del Error: " & ex.Message, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function

    Public Shared Sub DeleteDetalle(Empresa As Integer, Requisa As Integer, Codigo As String, Tipo As String)
        Try
            Dim Conn As New Connect(fn.Conexion())
            '
            Conn.RemoveParameters()
            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, Empresa)
            Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
            Conn.AddParameter("Articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, Codigo)
            Conn.AddParameter("TArticulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, Tipo)

            Conn.EjecutarComando("SP_Requisas_Detalle_Delete")
        Catch ex As Exception
            fn.XtraMsg("Error al Borrar Codigo : " & Codigo & vbCrLf &
                       "Motivo del Error: " & ex.Message, MessageBoxIcon.Error)

        End Try
    End Sub

    Public Sub Detalles(ByVal Factura As String, Proveedor As Integer)
        Dim _DT As DataTable = ObtieneDatos("sp_sel_requisasOP", Factura, Proveedor, EmpresaA)

        If _DT.Rows.Count > 0 Then
            With _DT.Rows(0)
                req_codigo = .Item("req_codigo")
                Tipo = .Item("Tipo")
                Fecha = .Item("Fecha")
                Bodega = .Item("Bodega")
                Referencia = .Item("Referencia")
                Factura = .Item("Factura")
                Proveedor = .Item("IdProveedor")
                Comp_No = .Item("Comp_No")
                Per_Id = .Item("Per_Id")
                Mes = .Item("Mes")
                ALiquidar = .Item("A Liquidar")
                Procesado = .Item("Procesado")
                Contabilizado = .Item("Contabilizado")
            End With
        End If
    End Sub

    Public Sub Detalles(Codigo As Integer)

        Dim _DT As DataTable = ObtieneDatos("sp_sel_requisas", Codigo, EmpresaA)

        If _DT.Rows.Count > 0 Then

            With _DT.Rows(0)
                req_codigo = .Item("req_codigo")
                req_codigo_referencia = .Item("IdRequisa_Referencia")
                Tipo = .Item("Tipo")
                Fecha = .Item("Fecha")
                Bodega = .Item("Bodega")
                Referencia = .Item("Referencia")
                Factura = .Item("Factura")
                Proveedor = .Item("IdProveedor")
                Clase = .Item("Codigo_Clase")
                Comp_No = IsNull(.Item("Comp_No"), 0)
                Per_Id = IsNull(.Item("Per_Id"), 0)
                Mes = IsNull(.Item("Mes"), 0)
                ALiquidar = .Item("A Liquidar")
                Procesado = .Item("Procesado")
                Contabilizado = .Item("Contabilizado")
                EsProyecto = .Item("EsProyecto")
            End With
        End If
    End Sub

    Public Shared Function GetDetalles(Codigo As Integer) As DataTable

        Return ObtieneDatos("sp_sel_requisas", Codigo, EmpresaA, 1)

    End Function

    Public Function BorrarMovimiento(Req_Codigo As Integer) As Boolean

        Return Guardar("sp_MovimientoDelete", Req_Codigo, EmpresaA)

    End Function

End Class
