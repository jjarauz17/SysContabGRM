Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class Ordenes_ComprasDB

        '*********************** NUEVA FUNCION ************************************
        Public Sub OrdenCompraUpdate(ByVal Orden As String, ByVal Fecha As Date, ByVal FechaPago As Date,
                                          ByVal Proveedor As String, ByVal SubTotal As Double, ByVal Iva As Double,
                                          ByVal Saldo As Double, ByVal FormaPago As String,
                                          ByVal NoOrden As String, ByVal TCambio As Double,
                                          NoPedido As String, Flete As Double,
                                          Seguro As Double, Otros As Double, Comentario As String,
                                          FechaEntrega As String, Moneda As String, Embarque As String,
                                          Condiciones As String, Atencion As String, Estado As Integer,
                                          IdConsignatario As Integer, IdAgencia As Integer, IdEnvio As Integer,
                                          Comentario_Gerencia As String, Liquidacion As Boolean,
                                          IR_Pagado As Integer, Ir_Pagado_Alma As Integer,
                                          SubTotalIR As Double, IR_Porcentaje As Double)

            Dim cmd As SqlCommand = New SqlCommand("_OrdenesComprasUpdate", DBConnFacturas)
            'Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            'Add Parameters to SPROC
            'Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Orden As SqlParameter = New SqlParameter("@Orden", SqlDbType.Int)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim _FechaPago As SqlParameter = New SqlParameter("@FechaPago", SqlDbType.DateTime)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Int)
            Dim _SubTotal As SqlParameter = New SqlParameter("@SubTotal", SqlDbType.Decimal)
            Dim _Iva As SqlParameter = New SqlParameter("@Iva", SqlDbType.Decimal)
            Dim _Saldo As SqlParameter = New SqlParameter("@Saldo", SqlDbType.Decimal)
            Dim _FormaPago As SqlParameter = New SqlParameter("@Forma_Pago", SqlDbType.Int)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)
            Dim _NoOrden As SqlParameter = New SqlParameter("@NoOrden", SqlDbType.NVarChar)
            Dim _TCambio As SqlParameter = New SqlParameter("@TCambio", SqlDbType.Decimal)

            _Orden.Value = Orden
            _Fecha.Value = Fecha
            _FechaPago.Value = FechaPago
            _Proveedor.Value = Proveedor
            _SubTotal.Value = SubTotal
            _Iva.Value = Iva
            _Saldo.Value = Saldo
            _FormaPago.Value = FormaPago
            _Empresa.Value = EmpresaActual
            _NoOrden.Value = NoOrden
            _TCambio.Value = TCambio

            cmd.Parameters.Add(_Orden)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_FechaPago)
            cmd.Parameters.Add(_Proveedor)
            cmd.Parameters.Add(_SubTotal)
            cmd.Parameters.Add(_Iva)
            cmd.Parameters.Add(_Saldo)
            cmd.Parameters.Add(_FormaPago)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_NoOrden)
            cmd.Parameters.Add(_TCambio)

            cmd.Parameters.AddWithValue("@NoPedido", NoPedido)
            cmd.Parameters.AddWithValue("@Flete", Flete)
            cmd.Parameters.AddWithValue("@Seguro", Seguro)
            cmd.Parameters.AddWithValue("@Otros", Otros)
            cmd.Parameters.AddWithValue("@Comentario", Comentario)
            cmd.Parameters.AddWithValue("@FechaEntrega", FechaEntrega)
            cmd.Parameters.AddWithValue("@Moneda", Moneda)
            cmd.Parameters.AddWithValue("@Embarque", Embarque)
            cmd.Parameters.AddWithValue("@Condiciones", Condiciones)
            cmd.Parameters.AddWithValue("@Atenciona", Atencion)
            cmd.Parameters.AddWithValue("@IdEstado", Estado)
            cmd.Parameters.AddWithValue("@IdConsignatario", IdConsignatario)
            cmd.Parameters.AddWithValue("@IdAgencia", IdAgencia)
            cmd.Parameters.AddWithValue("@IdEnvio", IdEnvio)
            cmd.Parameters.AddWithValue("@Comentario_Gerencia", Comentario_Gerencia)
            cmd.Parameters.AddWithValue("@Liquidacion", IIf(Liquidacion, 1, 0))
            cmd.Parameters.AddWithValue("@IR_Pagado", IR_Pagado)
            cmd.Parameters.AddWithValue("@IR_Pagado_Alma", Ir_Pagado_Alma)
            cmd.Parameters.AddWithValue("@SubTotalIR", SubTotalIR)
            cmd.Parameters.AddWithValue("@IR_Porcentaje", IR_Porcentaje)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()
        End Sub

        Public Function GeTOrdenCompraDetalle(ByVal Factura As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("_GetOrdenesComprasDetalle", DBConn)
            DBCommand = New SqlDataAdapter("_OrdenComprasDetalle", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pFactura.Value = Factura
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Ordenes_Compras")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function MaxTotalOrdenesCompras(ByVal Tipo As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim conexion As New VB.SysContab.Rutinas

            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetMaxTotalOrdenesCompras", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual
            pTipo.Value = Tipo

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.Fill(dsFicha, "Ordenes_Compras")
            DBConn.Close()
            Return dsFicha
        End Function

        Public Function MaxTotalOrdenesComprasLinea(ByVal Tipo As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim conexion As New VB.SysContab.Rutinas

            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetMaxTotalOrdenesComprasLinea", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual
            pTipo.Value = Tipo

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.Fill(dsFicha, "Ordenes_Compras_Lineas")
            DBConn.Close()
            Return dsFicha
        End Function

        Public Function OrdenesCompras(ByVal Estado As String, ByVal OrdenID As String, ByVal Mes As String, _
            ByVal Fecha1 As String, ByVal Fecha2 As String, ByVal FormaPago As Integer, ByVal CodArticulo As String, _
            ByVal Articulo As String, ByVal Proveedor As Integer, ByVal FacRango1 As Integer, ByVal FacRango2 As Integer, _
            ByVal ArtMin As String, ByVal ArtMax As String, ByVal TipoFac2 As String, ByVal TipoArt As String, _
            ByVal Orden As Integer, ByVal TipoProducto As String, ByVal Origen As Integer) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_OrdenesComprasList", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pTipoProducto As New SqlParameter("@TipoProd", SqlDbType.Int)
            Dim pEstado As New SqlParameter("@Estado", SqlDbType.Char)
            Dim pOrdenID As New SqlParameter("@OrdenID", SqlDbType.NVarChar)
            Dim pMes As New SqlParameter("@Mes", SqlDbType.NVarChar)
            Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
            Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
            Dim pFormaPago As New SqlParameter("@FormaPago", SqlDbType.Int)
            Dim pCodArticulo As New SqlParameter("@ItemID", SqlDbType.NVarChar)
            Dim pArticulo As New SqlParameter("@Articulo", SqlDbType.NVarChar)
            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            Dim pFacRango1 As New SqlParameter("@FacRango1", SqlDbType.Float)
            Dim pFacRango2 As New SqlParameter("@FacRango2", SqlDbType.Float)
            Dim pArtMin As New SqlParameter("@ArtMin", SqlDbType.Float)
            Dim pArtMAx As New SqlParameter("@ArtMax", SqlDbType.Float)
            Dim pTipoArt As New SqlParameter("@TipoArt", SqlDbType.Char)
            Dim pTipoFac2 As New SqlParameter("@TipoFac2", SqlDbType.Char)
            Dim pOrden As New SqlParameter("@Orden", SqlDbType.Int)
            Dim pOrigen As New SqlParameter("@Origen", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual
            pTipoProducto.Value = TipoProducto
            pEstado.Value = Estado
            pOrdenID.Value = OrdenID
            pMes.Value = Mes
            pFecha1.Value = Fecha1
            pFecha2.Value = Fecha2
            pFormaPago.Value = FormaPago
            pCodArticulo.Value = CodArticulo
            pArticulo.Value = Articulo
            pProveedor.Value = Proveedor
            pFacRango1.Value = FacRango1
            pFacRango2.Value = FacRango2
            pArtMin.Value = ArtMin
            pArtMAx.Value = ArtMax
            pTipoArt.Value = TipoArt
            pTipoFac2.Value = TipoFac2
            pOrden.Value = Orden
            pOrigen.Value = Origen

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pTipoProducto)
            DBCommand.SelectCommand.Parameters.Add(pEstado)
            DBCommand.SelectCommand.Parameters.Add(pOrdenID)
            DBCommand.SelectCommand.Parameters.Add(pMes)
            DBCommand.SelectCommand.Parameters.Add(pFecha1)
            DBCommand.SelectCommand.Parameters.Add(pFecha2)
            DBCommand.SelectCommand.Parameters.Add(pFormaPago)
            DBCommand.SelectCommand.Parameters.Add(pCodArticulo)
            DBCommand.SelectCommand.Parameters.Add(pArticulo)
            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pFacRango1)
            DBCommand.SelectCommand.Parameters.Add(pFacRango2)
            DBCommand.SelectCommand.Parameters.Add(pArtMin)
            DBCommand.SelectCommand.Parameters.Add(pArtMAx)
            DBCommand.SelectCommand.Parameters.Add(pTipoArt)
            DBCommand.SelectCommand.Parameters.Add(pTipoFac2)
            DBCommand.SelectCommand.Parameters.Add(pOrden)
            DBCommand.SelectCommand.Parameters.Add(pOrigen)
            'Try
            DBCommand.Fill(dsFicha, "Ordenes_Compras")
            'Catch e As Exception
            '    MsgBox(e.Message)
            'End Try
            DBConn.Close()
            Return dsFicha

        End Function


        Public Function OrdenCompraUpdate(ByVal Factura As String, ByVal Fecha As String, ByVal FechaPago As String, ByVal Proveedor As String, ByVal SubTotal As String, ByVal Iva As String, ByVal Saldo As String, ByVal FormaPago As String, ByVal Tipo As String, ByVal Origen As String, ByVal Orden As String, ByVal Temporal As String)

            Dim cmd As SqlCommand = New SqlCommand("_OrdenesComprasUpdate", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim _FechaPago As SqlParameter = New SqlParameter("@FechaPago", SqlDbType.DateTime)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Int, 4)
            Dim _SubTotal As SqlParameter = New SqlParameter("@SubTotal", SqlDbType.Float, 8)
            Dim _Iva As SqlParameter = New SqlParameter("@Iva", SqlDbType.Float, 8)
            Dim _Saldo As SqlParameter = New SqlParameter("@Saldo", SqlDbType.Float, 8)
            Dim _FormaPago As SqlParameter = New SqlParameter("@Forma_Pago", SqlDbType.Int, 4)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.Int, 4)
            Dim _Origen As SqlParameter = New SqlParameter("@Origen", SqlDbType.Int, 4)
            Dim _Orden As SqlParameter = New SqlParameter("@Orden", SqlDbType.NVarChar)
            Dim _Temporal As SqlParameter = New SqlParameter("@Temporal", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Factura.Value = Factura
            _Fecha.Value = Fecha
            _FechaPago.Value = FechaPago
            _Proveedor.Value = Proveedor
            _SubTotal.Value = SubTotal
            _Iva.Value = Iva
            _Saldo.Value = Saldo
            _FormaPago.Value = FormaPago
            _Tipo.Value = Tipo
            _Origen.Value = Origen
            _Orden.Value = Orden
            _Temporal.Value = Temporal
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_FechaPago)
            cmd.Parameters.Add(_Proveedor)
            cmd.Parameters.Add(_SubTotal)
            cmd.Parameters.Add(_Iva)
            cmd.Parameters.Add(_Saldo)
            cmd.Parameters.Add(_FormaPago)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Origen)
            cmd.Parameters.Add(_Orden)
            cmd.Parameters.Add(_Temporal)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function OrdenCompraCCUpdate(ByVal Factura As String, ByVal Fecha As String, ByVal FechaPago As String, ByVal Proveedor As String, ByVal SubTotal As Double, ByVal Iva As Double, ByVal Saldo As Double, ByVal FormaPago As String, ByVal Tipo As String, ByVal Origen As String, ByVal Orden As String, ByVal Temporal As String)

            Dim cmd As SqlCommand = New SqlCommand("_OrdenesComprasCCUpdate", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim _FechaPago As SqlParameter = New SqlParameter("@FechaPago", SqlDbType.DateTime)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Int, 4)
            Dim _SubTotal As SqlParameter = New SqlParameter("@SubTotal", SqlDbType.Float, 8)
            Dim _Iva As SqlParameter = New SqlParameter("@Iva", SqlDbType.Float, 8)
            Dim _Saldo As SqlParameter = New SqlParameter("@Saldo", SqlDbType.Float, 8)
            Dim _FormaPago As SqlParameter = New SqlParameter("@Forma_Pago", SqlDbType.Int, 4)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.Int, 4)
            Dim _Origen As SqlParameter = New SqlParameter("@Origen", SqlDbType.Int, 4)
            Dim _Orden As SqlParameter = New SqlParameter("@Orden", SqlDbType.NVarChar)
            Dim _Temporal As SqlParameter = New SqlParameter("@Temporal", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Factura.Value = Factura
            _Fecha.Value = Fecha
            _FechaPago.Value = FechaPago
            _Proveedor.Value = Proveedor
            _SubTotal.Value = SubTotal
            _Iva.Value = Iva
            _Saldo.Value = Saldo
            _FormaPago.Value = FormaPago
            _Tipo.Value = Tipo
            _Origen.Value = Origen
            _Orden.Value = Orden
            _Temporal.Value = Temporal
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_FechaPago)
            cmd.Parameters.Add(_Proveedor)
            cmd.Parameters.Add(_SubTotal)
            cmd.Parameters.Add(_Iva)
            cmd.Parameters.Add(_Saldo)
            cmd.Parameters.Add(_FormaPago)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Origen)
            cmd.Parameters.Add(_Orden)
            cmd.Parameters.Add(_Temporal)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function OrdenComprasAnular(ByVal Orden As String, ByVal Destino As Integer) As Boolean

            Return DAL.Guardar("_OrdenComprasAnular", Orden, Destino, EmpresaActual)


            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet
            'Dim conexion As New VB.SysContab.Rutinas
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())
            'DBCommand = New SqlDataAdapter("_OrdenComprasAnular", DBConn)
            'DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure
            'Dim _Orden As New SqlParameter("@Orden", SqlDbType.NVarChar)
            'Dim _Destino As New SqlParameter("@Destino", SqlDbType.Int)
            'Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            '_Orden.Value = Orden
            '_Destino.Value = Destino
            '_Empresa.Value = EmpresaActual
            'DBCommand.SelectCommand.Parameters.Add(_Orden)
            'DBCommand.SelectCommand.Parameters.Add(_Destino)
            'DBCommand.SelectCommand.Parameters.Add(_Empresa)
            'DBCommand.Fill(dsFicha, "Ordenes_Compras")
            'DBConn.Close()
            'Return dsFicha

        End Function

        Public Function OrdenComprasBorrar(ByVal Orden As String) As Boolean

            Return DAL.Guardar("JAR_OrdenCompraBorrar", Orden, EmpresaActual)

        End Function

        Public Function OrdenComprasDetalleDelete(ByVal Orden As String, ByVal Destino As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_OrdenComprasDetalleDelete", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Orden As New SqlParameter("@Orden", SqlDbType.NVarChar)
            Dim _Destino As New SqlParameter("@Destino", SqlDbType.Int)
            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)

            _Orden.Value = Orden
            _Destino.Value = Destino
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Orden)
            DBCommand.SelectCommand.Parameters.Add(_Destino)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "Ordenes_Compras")

            DBConn.Close()

            Return dsFicha

        End Function


        Public Sub OrdenComprasDetalleDelete(ByVal IDDetalle As Double)
            Dim cmd As SqlCommand =
                New SqlCommand("sp_del_OrdenComprasDetalle", DBConnFacturas)
            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            cmd.Parameters.AddWithValue("@ID", IDDetalle)
            cmd.Parameters.AddWithValue("@Empresa", EmpresaActual)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()
        End Sub

        Public Function OrdenComprasDetalleTrasladar(ByVal NoOrden As String) As DataTable

            Return ObtieneDatos("sp_OrdenComprasDetalleTrasladar", NoOrden, EmpresaActual)

        End Function

        Public Function OrdenComprasDetalle(ByVal Orden As String, ByVal Destino As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())
            'DBCommand = New SqlDataAdapter("JAR_OrdenComprasDetalleFactura", DBConn)

            If Destino = 99 Then
                DBCommand = New SqlDataAdapter("JAR_OrdenComprasDetalleFactura", DBConn)
            Else
                DBCommand = New SqlDataAdapter("_OrdenComprasDetalle", DBConn)
            End If

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim _Orden As New SqlParameter("@Orden", SqlDbType.NVarChar)
            Dim _Destino As New SqlParameter("@Destino", SqlDbType.Int)
            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)

            _Orden.Value = Orden
            _Destino.Value = Destino
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Orden)
            DBCommand.SelectCommand.Parameters.Add(_Destino)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "Ordenes_Compras")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Sub ImprimirOrden(ByVal Orden As String)
            ''If MsgBox("¿Desea imprimir la Cotización?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            'Dim fReportes As New frmReportes
            'Dim rOrdenes As New rptProvOrdenCompra
            'Dim ds As New DataSet
            'ds = VB.SysContab.Ordenes_ComprasDB.GetProvOrdenCompra(Orden)
            'ds.WriteXml(Application.StartupPath & "\xml\ProvOrdenCompra.xml", XmlWriteMode.WriteSchema)
            'rOrdenes.Database.Tables(0).Location = Application.StartupPath & "\xml\ProvOrdenCompra.xml"

            'fReportes.crvReportes.ReportSource = rOrdenes
            'fReportes.Show()
            ''End If
        End Sub

        Public Shared Function GetProvOrdenCompra(ByVal Factura As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ProveedoresOrdenCompra", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pFactura.Value = Factura
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Ordenes_Compras")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function OrdenCompraCCNumero() As Integer

            Dim cmd As SqlCommand = New SqlCommand("_OrdenesComprasCCNumero", DBConnFacturas)

            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual

            cmd.Parameters.Add(pEmpresa)

            Dim parameterFactura As SqlParameter = New SqlParameter("@Factura", SqlDbType.Int, 4)
            parameterFactura.Direction = ParameterDirection.Output
            cmd.Parameters.Add(parameterFactura)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

            If parameterFactura.Value.ToString() <> "" Then
                Return CType(parameterFactura.Value, Integer)
            Else
                Return 1
            End If

        End Function

        Public Function OrdenCompraCCAdd(ByVal Factura As String, ByVal Fecha As String, ByVal FechaPago As String, _
                                         ByVal Proveedor As String, ByVal SubTotal As String, ByVal Iva As String, _
                                         ByVal Saldo As String, ByVal FormaPago As String, ByVal Tipo As String, _
                                         ByVal Origen As String, ByVal Orden As String, ByVal Temporal As String, _
                                         ByVal NoOrden As String)

            Dim cmd As SqlCommand = New SqlCommand("_OrdenesComprasCCAdd", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim _FechaPago As SqlParameter = New SqlParameter("@FechaPago", SqlDbType.DateTime)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Int, 4)
            Dim _SubTotal As SqlParameter = New SqlParameter("@SubTotal", SqlDbType.Float, 8)
            Dim _Iva As SqlParameter = New SqlParameter("@Iva", SqlDbType.Float, 8)
            Dim _Saldo As SqlParameter = New SqlParameter("@Saldo", SqlDbType.Float, 8)
            Dim _FormaPago As SqlParameter = New SqlParameter("@Forma_Pago", SqlDbType.Int, 4)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.Int, 4)
            Dim _Origen As SqlParameter = New SqlParameter("@Origen", SqlDbType.Int, 4)
            Dim _Orden As SqlParameter = New SqlParameter("@Orden", SqlDbType.NVarChar)
            Dim _Temporal As SqlParameter = New SqlParameter("@Temporal", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _NoOrden As SqlParameter = New SqlParameter("@NoOrden", SqlDbType.NVarChar)

            _Factura.Value = Factura
            _Fecha.Value = Fecha
            _FechaPago.Value = FechaPago
            _Proveedor.Value = Proveedor
            _SubTotal.Value = SubTotal
            _Iva.Value = Iva
            _Saldo.Value = Saldo
            _FormaPago.Value = FormaPago
            _Tipo.Value = Tipo
            _Origen.Value = Origen
            _Orden.Value = Orden
            _Temporal.Value = Temporal
            _Empresa.Value = EmpresaActual
            _NoOrden.Value = NoOrden

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_FechaPago)
            cmd.Parameters.Add(_Proveedor)
            cmd.Parameters.Add(_SubTotal)
            cmd.Parameters.Add(_Iva)
            cmd.Parameters.Add(_Saldo)
            cmd.Parameters.Add(_FormaPago)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Origen)
            cmd.Parameters.Add(_Orden)
            cmd.Parameters.Add(_Temporal)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_NoOrden)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()
        End Function

        Public Function OrdenesComprasCCLineasAdd(ByVal Factura As String, ByVal Item As String, ByVal Cantidad As String, _
                                         ByVal Costo As String, ByVal IvaPorcentaje As String, ByVal IvaValor As String)


            Dim cmd As SqlCommand = New SqlCommand("_OrdenesComprasCCLineasAdd", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar)
            Dim _Cantidad As SqlParameter = New SqlParameter("@Cantidad", SqlDbType.Float)
            Dim _Costo As SqlParameter = New SqlParameter("@Costo", SqlDbType.Float)
            Dim _IvaPorcentaje As SqlParameter = New SqlParameter("@IvaPorcentaje", SqlDbType.Float)
            Dim _IvaValor As SqlParameter = New SqlParameter("@IvaValor", SqlDbType.Float)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Factura.Value = Factura
            _Item.Value = Item
            _Cantidad.Value = Cantidad
            _Costo.Value = Costo
            _IvaPorcentaje.Value = IvaPorcentaje
            _IvaValor.Value = IvaValor
            _Empresa.Value = EmpresaActual


            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Item)
            cmd.Parameters.Add(_Cantidad)
            cmd.Parameters.Add(_Costo)
            cmd.Parameters.Add(_IvaPorcentaje)
            cmd.Parameters.Add(_IvaValor)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function OrdenCompraCCDetalle(ByVal Factura As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_OrdenesComprasCCDetalle", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pFactura.Value = Factura
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Ordenes_Compras")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function OrdenCompraDetalle(ByVal Factura As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_OrdenesComprasDetalle", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pFactura.Value = Factura
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Ordenes_Compras")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function OrdenesCompraXProveedor(ByVal Proveedor As String, ByVal Fecha As String, ByVal Estado As String, ByVal Tipo As String, ByVal Origen As String, ByVal Destino As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim EstadoLocal As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_OrdenesCompraXProveedor", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            Dim pFecha As New SqlParameter("@Fecha", SqlDbType.NVarChar)
            Dim pEstado As New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)
            Dim pOrigen As New SqlParameter("@Origen", SqlDbType.Int)
            Dim pDestino As New SqlParameter("@Destino", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            If Estado = 0 Then
                EstadoLocal = "T"
            ElseIf Estado = 1 Then
                EstadoLocal = "P"
            ElseIf Estado = 2 Then
                EstadoLocal = "F"
            ElseIf Estado = 3 Then
                EstadoLocal = "A"
            End If





            pProveedor.Value = Proveedor
            pFecha.Value = Fecha
            pEstado.Value = EstadoLocal
            pTipo.Value = Tipo
            pOrigen.Value = Origen
            pDestino.Value = Destino
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pFecha)
            DBCommand.SelectCommand.Parameters.Add(pEstado)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pOrigen)
            DBCommand.SelectCommand.Parameters.Add(pDestino)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            'Try
            DBCommand.Fill(dsFicha, "Ordenes_Compra")
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function Numero() As Integer
            'Dim DBConn As SqlConnection
            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_OrdenesComprasNumero", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            'Dim pCotizacion As New SqlParameter("@Cotizacion", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual

            cmd.Parameters.Add(pEmpresa)

            Dim parameterFactura As SqlParameter = New SqlParameter("@Factura", SqlDbType.Int, 4)
            parameterFactura.Direction = ParameterDirection.Output
            cmd.Parameters.Add(parameterFactura)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

            'DBConn.Open()
            'cmd.ExecuteNonQuery()
            'DBConn.Close()

            ' Return the Total
            If parameterFactura.Value.ToString() <> "" Then
                Return CType(parameterFactura.Value, Integer)
            Else
                Return 1
            End If

        End Function


        Public Function OrdenCompraNumero(ByVal Tipo As Integer) As Integer

            Dim cmd As SqlCommand = Nothing
            Dim sCon As New SqlConnection(Rutinas.AbrirConexion)

            If Tipo = 1 Then
                cmd = New SqlCommand("_OrdenesComprasNumero", sCon)
            ElseIf Tipo = 2 Then
                cmd = New SqlCommand("_OrdenesComprasCCNumero", sCon)
            End If

            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual

            cmd.Parameters.Add(pEmpresa)

            Dim parameterFactura As SqlParameter = New SqlParameter("@Factura", SqlDbType.Int, 4)
            parameterFactura.Direction = ParameterDirection.Output
            cmd.Parameters.Add(parameterFactura)

            sCon.Open()
            cmd.ExecuteNonQuery()
            sCon.Close()

            If parameterFactura.Value.ToString() <> "" Then
                Return CType(parameterFactura.Value, Integer)
            Else
                Return 1
            End If

        End Function

        Public Shared Function CodigoPersonalizadoOC() As String

            Return ObtieneDatos("sp_Ordenes_Compra_GetNumero", EmpresaActual).Rows.Item(0)("Numero")

        End Function


        Public Function AddItem(ByVal Factura As String, ByVal Fecha As String, ByVal FechaPago As String,
                                ByVal Proveedor As String, ByVal SubTotal As String, ByVal Iva As String,
                                ByVal Saldo As String, ByVal FormaPago As String, ByVal Tipo As String,
                                ByVal Origen As String, ByVal Orden As String, ByVal Temporal As String,
                                ByVal NoOrden As String, ByVal TCambio As Double, NoPedido As String, Flete As Double,
                                Seguro As Double, Otros As Double, Comentario As String, FechaEntrega As String,
                                Moneda As String, Embarque As String, Condiciones As String, Atencion As String,
                                Estado As Integer, IdConsignatario As Integer, IdAgencia As Integer, IdEnvio As Integer,
                                Comentario_Gerencia As String, Liquidacion As Boolean,
                                IR_Pagado As Integer, Ir_Pagado_Alma As Integer,
                                SubTotalIR As Double, IR_Porcentaje As Double)

            Dim cmd As SqlCommand = New SqlCommand("_OrdenesComprasAdd", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim _FechaPago As SqlParameter = New SqlParameter("@FechaPago", SqlDbType.DateTime)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Int, 4)
            Dim _SubTotal As SqlParameter = New SqlParameter("@SubTotal", SqlDbType.Float, 8)
            Dim _Iva As SqlParameter = New SqlParameter("@Iva", SqlDbType.Float, 8)
            Dim _Saldo As SqlParameter = New SqlParameter("@Saldo", SqlDbType.Float, 8)
            Dim _FormaPago As SqlParameter = New SqlParameter("@Forma_Pago", SqlDbType.Int, 4)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.Int, 4)
            Dim _Origen As SqlParameter = New SqlParameter("@Origen", SqlDbType.Int, 4)
            Dim _Orden As SqlParameter = New SqlParameter("@Orden", SqlDbType.NVarChar)
            Dim _Temporal As SqlParameter = New SqlParameter("@Temporal", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _NoOrden As SqlParameter = New SqlParameter("@NoOrden", SqlDbType.NVarChar)
            Dim _TCambio As SqlParameter = New SqlParameter("@TCambio", SqlDbType.Decimal)


            _Factura.Value = Factura
            _Fecha.Value = Fecha
            _FechaPago.Value = FechaPago
            _Proveedor.Value = Proveedor
            _SubTotal.Value = SubTotal
            _Iva.Value = Iva
            _Saldo.Value = Saldo
            _FormaPago.Value = FormaPago
            _Tipo.Value = Tipo
            _Origen.Value = Origen
            _Orden.Value = Orden
            _Temporal.Value = Temporal
            _Empresa.Value = EmpresaActual
            _NoOrden.Value = NoOrden
            _TCambio.Value = TCambio

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_FechaPago)
            cmd.Parameters.Add(_Proveedor)
            cmd.Parameters.Add(_SubTotal)
            cmd.Parameters.Add(_Iva)
            cmd.Parameters.Add(_Saldo)
            cmd.Parameters.Add(_FormaPago)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Origen)
            cmd.Parameters.Add(_Orden)
            cmd.Parameters.Add(_Temporal)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_NoOrden)
            cmd.Parameters.Add(_TCambio)

            cmd.Parameters.AddWithValue("@NoPedido", NoPedido)
            cmd.Parameters.AddWithValue("@Flete", Flete)
            cmd.Parameters.AddWithValue("@Seguro", Seguro)
            cmd.Parameters.AddWithValue("@Otros", Otros)
            cmd.Parameters.AddWithValue("@Comentario", Comentario)
            cmd.Parameters.AddWithValue("@FechaEntrega", FechaEntrega)
            cmd.Parameters.AddWithValue("@Moneda", Moneda)
            cmd.Parameters.AddWithValue("@Embarque", Embarque)
            cmd.Parameters.AddWithValue("@Condiciones", Condiciones)
            cmd.Parameters.AddWithValue("@Atenciona", Atencion)
            cmd.Parameters.AddWithValue("@IdEstado", Estado)
            cmd.Parameters.AddWithValue("@IdConsignatario", IdConsignatario)
            cmd.Parameters.AddWithValue("@IdAgencia", IdAgencia)
            cmd.Parameters.AddWithValue("@IdEnvio", IdEnvio)
            cmd.Parameters.AddWithValue("@Comentario_Gerencia", Comentario_Gerencia)
            cmd.Parameters.AddWithValue("@Liquidacion", IIf(Liquidacion, 1, 0))
            cmd.Parameters.AddWithValue("@IR_Pagado", IR_Pagado)
            cmd.Parameters.AddWithValue("@IR_Pagado_Alma", Ir_Pagado_Alma)
            cmd.Parameters.AddWithValue("@SubTotalIR", SubTotalIR)
            cmd.Parameters.AddWithValue("@IR_Porcentaje", IR_Porcentaje)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()
        End Function

        Public Sub AddFacturaLineas(ByVal Factura As String, ByVal Item As String, ByVal Cantidad As String,
                                         ByVal Costo As String, ByVal Descuento As String, ByVal Iva As String,
                                         ByVal Tipo As String, Descripcion As String, IdProyecto As Integer,
                                         IdOrdenCompra As Integer, Flete As Integer, Seguro As Integer,
                                         IrP As Double)


            Dim cmd As SqlCommand = New SqlCommand("_OrdenesComprasLineasAdd", DBConnFacturas)
            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar, 50)
            Dim _Cantidad As SqlParameter = New SqlParameter("@Cantidad", SqlDbType.Float, 8)
            Dim _Costo As SqlParameter = New SqlParameter("@Costo", SqlDbType.Float, 8)
            Dim _Descuento As SqlParameter = New SqlParameter("@Descuento", SqlDbType.Float, 8)
            Dim _Iva As SqlParameter = New SqlParameter("@Iva", SqlDbType.Float, 8)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar, 2)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Factura.Value = Factura
            _Item.Value = Item
            _Cantidad.Value = Cantidad
            _Costo.Value = Costo
            _Descuento.Value = Descuento
            _Iva.Value = Iva
            _Tipo.Value = Tipo
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Item)
            cmd.Parameters.Add(_Cantidad)
            cmd.Parameters.Add(_Costo)
            cmd.Parameters.Add(_Descuento)
            cmd.Parameters.Add(_Iva)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Empresa)

            cmd.Parameters.AddWithValue("@Descripcion", Descripcion)
            cmd.Parameters.AddWithValue("@IdProyecto", IdProyecto)
            cmd.Parameters.AddWithValue("@IdOrdenCompra", IdOrdenCompra)
            cmd.Parameters.AddWithValue("@Flete", Flete)
            cmd.Parameters.AddWithValue("@Seguro", Seguro)
            cmd.Parameters.AddWithValue("@IR_Porcentaje", IrP)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()
        End Sub

        Public Sub UpdateFacturaLineas(ByVal IdDetalle As Double,
                                         ByVal Factura As String,
                                         ByVal Item As String,
                                         ByVal Cantidad As Double,
                                         ByVal Costo As Double,
                                         ByVal Descuento As Double,
                                         ByVal Iva As Double,
                                         ByVal Tipo As String,
                                         Descripcion As String,
                                         IdProyecto As Integer,
                                         IdOrdenCompra As Integer,
                                         Flete As Integer,
                                         Seguro As Integer,
                                         IrP As Double)

            Dim cmd As SqlCommand = New SqlCommand("sp_upd_OrdenesComprasLineas", DBConnFacturas)
            '   Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            '   Add Parameters to SPROC
            cmd.Parameters.AddWithValue("@IdDetalle", IdDetalle)
            cmd.Parameters.AddWithValue("@Factura", Factura)
            cmd.Parameters.AddWithValue("@Item", Item)
            cmd.Parameters.AddWithValue("@Cantidad", Cantidad)
            cmd.Parameters.AddWithValue("@Costo", Costo)
            cmd.Parameters.AddWithValue("@Descuento", Descuento)
            cmd.Parameters.AddWithValue("@Iva", Iva)
            cmd.Parameters.AddWithValue("@Tipo", Tipo)
            cmd.Parameters.AddWithValue("@Empresa", EmpresaActual)
            cmd.Parameters.AddWithValue("@Descripcion", Descripcion)
            cmd.Parameters.AddWithValue("@IdProyecto", IdProyecto)
            cmd.Parameters.AddWithValue("@IdOrdenCompra", IdOrdenCompra)
            cmd.Parameters.AddWithValue("@Flete", Flete)
            cmd.Parameters.AddWithValue("@Seguro", Seguro)
            cmd.Parameters.AddWithValue("@IR_Porcentaje", IrP)

            '' Add Parameters to SPROC
            'Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            'Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar, 50)
            'Dim _Cantidad As SqlParameter = New SqlParameter("@Cantidad", SqlDbType.Float, 8)
            'Dim _Costo As SqlParameter = New SqlParameter("@Costo", SqlDbType.Float, 8)
            'Dim _Descuento As SqlParameter = New SqlParameter("@Descuento", SqlDbType.Float, 8)
            'Dim _Iva As SqlParameter = New SqlParameter("@Iva", SqlDbType.Float, 8)
            'Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar, 2)
            'Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            '_Factura.Value = Factura
            '_Item.Value = Item
            '_Cantidad.Value = Cantidad
            '_Costo.Value = Costo
            '_Descuento.Value = Descuento
            '_Iva.Value = Iva
            '_Tipo.Value = Tipo
            '_Empresa.Value = EmpresaActual

            'cmd.Parameters.Add(_Factura)
            'cmd.Parameters.Add(_Item)
            'cmd.Parameters.Add(_Cantidad)
            'cmd.Parameters.Add(_Costo)
            'cmd.Parameters.Add(_Descuento)
            'cmd.Parameters.Add(_Iva)
            'cmd.Parameters.Add(_Tipo)
            'cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()
        End Sub

        Public Function PedidosUpdateEstado(ByVal Numero As String, ByVal Estado As String, ByVal Orden As String, ByVal Tipo As Integer)
            Dim cmd As SqlCommand = New SqlCommand("_PedidosUpdateEstado", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Numero As SqlParameter = New SqlParameter("@Numero", SqlDbType.NVarChar)
            Dim _Estado As SqlParameter = New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim _Orden As SqlParameter = New SqlParameter("@Orden", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.Int, 4)

            _Numero.Value = Numero
            _Estado.Value = Estado
            _Orden.Value = Orden
            _Empresa.Value = EmpresaActual
            _Tipo.Value = Tipo

            cmd.Parameters.Add(_Numero)
            cmd.Parameters.Add(_Estado)
            cmd.Parameters.Add(_Orden)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Tipo)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Shared Function FillComboLiquidacion() As DataTable

            Return ObtieneDatos("sp_ORDENES_COMPRAS_ActivasLiquidacion", EmpresaActual)

        End Function

        Public Shared Function ReporteDinamico(Desde As Date, Hasta As Date, Moneda As String) As DataTable

            Return ObtieneDatos("sp_sel_OrdenesCompraReporteDinamico",
                                Desde, Hasta, Moneda, EmpresaActual)

        End Function

        Public Shared Function MercaderiaTransito(Desde As Date, Hasta As Date) As DataTable

            Return ObtieneDatos("sp_sel_MercaderiaTransitoReporte",
                                Desde,
                                Hasta,
                                EmpresaActual)

        End Function


        Public Shared Function CuentaTransito() As String

            Dim _dt As DataTable = ObtieneDatos("sp_sel_GetCuentaTransito", EmpresaActual)

            If _dt.Rows.Count = 0 Then
                Return Nothing
            Else
                Return _dt.Rows.Item(0)("CUENTA")
            End If

        End Function

        Public Shared Function CuentaProyecto() As String

            Dim _dt As DataTable = ObtieneDatos("sp_sel_GetCuentaProyecto", EmpresaActual)

            If _dt.Rows.Count = 0 Then
                Return Nothing
            Else
                Return _dt.Rows.Item(0)("CUENTA")
            End If

        End Function

    End Class

End Namespace
